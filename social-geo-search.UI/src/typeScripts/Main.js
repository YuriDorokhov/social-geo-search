var Person = (function () {
    function Person() {
    }
    return Person;
}());
function GetUsers() {
    var person1 = new Person();
    person1.facebookLink = "link1";
    var person2 = new Person();
    person2.facebookLink = "link2";
    var person3 = new Person();
    person3.facebookLink = "link3";
    var persons = [person1, person2, person3];
    return persons;
}
function SearchUsers() {
    var persons = GetUsers();
    var personElements = [];
    persons.forEach(function (person) {
        personElements.push(createElement(person));
    });
    return generateDivElementFromArray(personElements);
}
function createElement(person) {
    var facebookLinkText = document.createTextNode(person.facebookLink);
    var personElement = generateDivElement(facebookLinkText);
    return personElement;
}
function generateDivElementFromArray(array) {
    var div = document.createElement('div');
    for (var i = 0, arg; arg = array[i]; i++) {
        div.appendChild(arg);
    }
    return div;
}
function generateDivElement() {
    var args = [];
    for (var _i = 0; _i < arguments.length; _i++) {
        args[_i - 0] = arguments[_i];
    }
    var div = document.createElement('div');
    for (var i = 0, arg; arg = args[i]; i++) {
        div.appendChild(arg);
    }
    return div;
}
function createPersonInput() {
    var facebookLinkInput = document.createElement('input');
    var searchButton = document.createElement('button');
    searchButton.textContent = "Search";
    searchButton.setAttribute('class', 'btn btn-lg btn-default');
    searchButton.onclick = function () {
        document.body.innerHTML = '';
        document.body.appendChild(SearchUsers());
    };
    var div = generateDivElement(facebookLinkInput, searchButton);
    return div;
}
document.body.appendChild(createPersonInput());
//# sourceMappingURL=Main.js.map