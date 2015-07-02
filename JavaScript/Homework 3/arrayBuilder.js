'use strict'

function createArray() {
    var maxLength = 20;
    var array = [];
    var i;

    for (i = 0; i < maxLength; i++) {
        array[i] = i * 5;
    }

    return array;
}

console.log(createArray());
