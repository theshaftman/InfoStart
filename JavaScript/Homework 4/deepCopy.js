'use strict'

var a = { name: 'Pesho', age: 21 }
var b = clone(a); // a deep copy 
console.log(compareObjects(a, b));

var a = { name: 'Pesho', age: 21 };
var b = a; // not a deep copy
console.log(compareObjects(a, b));

function clone(obj) {
    var result = {};

    for (var prop in obj) {
        if (((typeof (obj[prop]) === "number") && (obj[prop] !== null)) || 
            ((typeof (obj[prop]) === "string") && (obj[prop] !== null))) {
            result[prop] = obj[prop];
        }
    }

    return result; //returns a deep copy
}

function compareObjects(obj, objCopy) {
    var compare = obj == objCopy; //compare the two objects by reference (==)
    var result = "a == b --> " + compare;

    return result;
}
