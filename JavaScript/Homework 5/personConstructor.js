'use strict'

function Person(firstName, lastName, age) {
    this.firstName = firstName;
    this.lastName = lastName;
    this.age = age;
};


Person.prototype.toString = function toStr() {
    return this.firstName + ' ' + this.lastName + '(age ' + this.age + ')';
};

function group(people, key) {
    var groups = [], persons = people.slice(' ');
    var i, person, index;

    for (i = 0; i < persons.length; i++) {
        person = persons.pop(), index;

        switch (key) {
            case 'firstname':
                index = 'Group ' + person.firstName;
                break;
            case 'age':
                index = 'Group ' + person.age;
                break;
            case 'lastname':
                index = 'Group ' + person.lastName;
                break;
            default:
                return persons;
                break;
        }

        if (groups[index] === undefined) {
            groups[index] = [];
        }

        groups[index].push(person.toString());
    }

    return groups;
}

var persons = [];
persons.push(new Person("Scott", "Guthrie", 38));
persons.push(new Person("Scott", "Johns", 36));
persons.push(new Person("Scott", "Hanselman", 39));
persons.push(new Person("Jesse", "Liberty", 57));
persons.push(new Person("Jon", "Skeet", 38));

console.log(group(persons, 'firstname'));
console.log(group(persons, 'age'));
console.log(group(persons, 'lastname'));
