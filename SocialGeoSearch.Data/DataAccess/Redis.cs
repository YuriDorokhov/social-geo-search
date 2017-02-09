using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Models;

namespace SocialGeoSearch.Data.DataAccess
{
	public static class Redis
	{
		private const string ConnectionString = "127.0.0.1:6379";
		private static string _getScript = "return redis.call('GEORADIUS', @key, @value1, @value2, @value3, @value4)";
		private static string _setScript = "return redis.call('GEOADD', @key, @value1, @value2, @value3)";
		private static string _redisKey = "geosearch";
		public static string[] GetIdsInRadius(double latitude, double longitude, int radius)
		{
			//SetId("1", 50.005, 36.23361111111111);
			//SetId("2", 50.015277777777776, 36.22972222222222);
			//SetId("3", 50.029444444444444, 36.225833333333334);
			//SetId("4", 50.05555555555555, 36.29722222222222);

			ConnectionMultiplexer redis = ConnectionMultiplexer.Connect(ConnectionString);
			IDatabase db = redis.GetDatabase();

			var prepared = LuaScript.Prepare(_getScript);
			var ids = (string[])db.ScriptEvaluate(prepared, new { key = (RedisKey)_redisKey, value1 = longitude, value2 = latitude, value3 = radius, value4 = "m" });

			return ids;
		}

		public static bool SetId(string id, double latitude, double longitude)
		{
			ConnectionMultiplexer redis = ConnectionMultiplexer.Connect(ConnectionString);
			IDatabase db = redis.GetDatabase();

			var prepared = LuaScript.Prepare(_setScript);
			var result = db.ScriptEvaluate(prepared, new { key = (RedisKey)_redisKey, value1 = longitude, value2 = latitude, value3 = id });

			return true;
		}

	}
}
