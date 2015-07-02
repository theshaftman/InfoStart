'use strict'

function evenNumber(value) {
    var even = true;

    if (value % 2 != 0) {
        even = false;
    }
    return even;
}

console.log(evenNumber(3));
console.log(evenNumber(127));
console.log(evenNumber(588));
