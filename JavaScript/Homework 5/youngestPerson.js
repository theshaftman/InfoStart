'use strict'

var people = [
  { firstname: 'George', lastname: 'Kolev', age: 32 },
  { firstname: 'Bay', lastname: 'Ivan', age: 81 },
  { firstname: 'Baba', lastname: 'Ginka', age: 40 }]

console.log(findYoungestPerson(people));

function findYoungestPerson(people) {
    var i, minIndex, fullName, min = Infinity;

    for (i = 0; i < people.length; i++) {
        if (people[i].age < min) {
            min = people[i].age;
            minIndex = i;
        }
    }

    fullName = people[minIndex].firstname + " " + people[minIndex].lastname;
    return "The youngest person is " + fullName;
}
