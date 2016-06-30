# react-native-webpack-starter-kit

[![Build Status](https://travis-ci.org/jhabdas/react-native-webpack-starter-kit.svg?branch=master)](https://travis-ci.org/jhabdas/react-native-webpack-starter-kit)
[![Dependency Status](https://david-dm.org/jhabdas/react-native-webpack-starter-kit.svg)](https://david-dm.org/jhabdas/react-native-webpack-starter-kit)
[![devDependency Status](https://david-dm.org/jhabdas/react-native-webpack-starter-kit/dev-status.svg)](https://david-dm.org/jhabdas/react-native-webpack-starter-kit#info=devDependencies)
[![Gitter](https://img.shields.io/gitter/room/nwjs/nw.js.svg)](https://gitter.im/jhabdas/react-native-webpack-starter-kit)

Build your React Native app with Webpack and Babel.

![React Native Webpack Starter Kit](https://dl.dropboxusercontent.com/u/10150480/rn-starter-kit-hero-wordswag.jpg)

Asset pipeline for scalable apps built with React Native. Uses Babel 6 for ES7 JavaScript transpilation with Stage 1 support, and Webpack as a dev server and module bundler. Provides static code linting using ESLint and build output in the same console window, and Source Maps for debugging in the browser. Unprescriptive in terms of test frameworks and Flux implementations. Additional features listed below.

This kit was originally used to build and ship, and later extracted from, [Lumpen Radio].

## Features

- Minimal dependencies
- Follows the latest React Native stable release
- Manage assets using [Webpack](http://webpack.github.io/)
- Dynamically generates JS bundles using [Webpack Dev Server](http://webpack.github.io/docs/webpack-dev-server.html)
- Provides static code analysis with [ESLint](http://eslint.org/)
- Keeps dependencies fresh using [Greenkeeper](https://greenkeeper.io/)
- Monitors dependency vulnerabilities with [Snyk](https://snyk.io/)
- Aids code consistency using [EditorConfig](http://editorconfig.org/)
- Integrates with [`webpack-notifier`](https://github.com/Turbo87/webpack-notifier) for desktop notifications on OS X
- Example CI service integration using [Travis](https://travis-ci.org)

## Requirements

- [Node](https://nodejs.org) 4.x or better
- [Docker](https://www.docker.com/) for containerized development
- [Xcode](https://developer.apple.com/xcode/) for iOS development
- [Android SDK](https://developer.android.com/sdk/) for Android development
- [Android Lollipop](https://www.android.com/versions/lollipop-5-0/) or better for Android device testing

## Installation

Clone repo and install dependencies once your [environment is set-up](https://facebook.github.io/react-native/docs/getting-started.html):

```sh
git clone -o upstream -b master --single-branch \
    https://github.com/jhabdas/react-native-webpack-starter-kit.git native-starter-kit && cd $_ && npm i
```

## Running

Once project cloned and dependencies installed, run it with:

```sh
npm start
```

This will start the React Packager and a [Webpack Dev Server](https://github.com/webpack/webpack-dev-server). The dev server will watch your JS files for changes, automatically linting your code as you iterate. Additionally, the dev server will generate the `index.[platform].js` files expected by your React Native iOS or Android app, allowing you the freedom to build

### iOS

**Status:** All systems go.

Open `ios/App.xcodeproj` in Xcode, build and run the project.

Unlike the app currently generated by `react-native init` this app removes the `UIViewControllerBasedStatusBarAppearance` key to prevent an App Store rejection I received submitting [Lumpen Radio] to the App Store. The key may be added back, if desired.

For information on HMR support for iOS see [react-native-webpack-server/issues/103](https://github.com/mjohnston/react-native-webpack-server/issues/103).

### Android

**Status:** [Bug in simulator](https://github.com/jhabdas/react-native-webpack-starter-kit/issues/58). Test on actual device instead.

For android development use the following:

```sh
npm run android-setup-port # Note that this option is available on devices running android 5.0+ (API 21)
react-native run-android
```

If you run into any issues please see the [Getting Started](http://facebook.github.io/react-native/docs/getting-started.html) guide for React Native before submitting an issue.

### Docker

**Status:** Experimental.

This kit includes a `Dockerfile` which can be used to create a virtualized development environment for building your app. To use it on Windows [set-up Docker Machine](https://docs.docker.com/machine/get-started/) then run the commands below with [cmder](http://cmder.net/) (or similar) to get going. OS X users are encouraged to use [dlite](https://github.com/nlf/dlite) instead of Docker Machine for this setup.

1. Clone this repo then update `.watchmanconfig` to the following: `{"ignore_dirs": ["node_modules"]}`.
1. Run `docker build --rm .` command from the project root directory to build a virtualized Linunx environment configured for development using this starter kit.
1. Get the ID of the built Docker image by running `docker images` and looking for the most recently created image.
1. Then shell into the box with `docker run -it 09608e4ec865 /bin/bash` (where `09608e4ec865` is the Image ID) and run the app with `npm start`.

If iOS and Android device emulators are not available for your development environment (anything except OS X, basically) consider shipping code directly to a native device using [Exponent](https://exponentjs.com/) or [CodePush](https://github.com/Microsoft/code-push).

## Testing

As a minimalist seed this project does not introduce a testing framework. Instead it leverages simple static code analysis to help prevent coding mistakes and introduce some patterns for building React Native apps with ES2015 and ES7 with a _functional mindset_ inspired by the [Elm architecture](https://github.com/evancz/elm-architecture-tutorial/) and functional React alternatives like [Deku](https://segment.com/blog/deku-our-functional-alternative-to-react/).

Webpack is configured with a pre-loader to lint the application with ESLint using the Babel parser during app development. And the `npm lint` command may be run at anytime to lint source code otherwise. See the `.eslintrc` file to adjust [linter rules](http://eslint.org/docs/rules/) to your liking. Or run `npm test` to lint the application and scan its dependencies it for known security vulnerabilities.

## Bundling

To bundle the app for distribution for both iOS and Android:

1. Execute `npm run bundle` to generate the [offline JS bundle](https://facebook.github.io/react-native/docs/running-on-device-ios.html#using-offline-bundle).
1. For iOS, update `AppDelegate.m` to load from pre-bundled file on disk.
1. Test the application, create an archive and submit to the store.

## Submitting to Store

Please see [Submitting to App Store](http://habd.as/reflecting-on-react-native-development/#submitting-to-app-store) for instructions on iOS. If you have any good Android instructions, please send a PR this way. Good luck and have fun out there!

[Lumpen Radio]: https://github.com/jhabdas/lumpen-radio