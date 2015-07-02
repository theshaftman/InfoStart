'use strict'

function reverseString(value) {
    var reversed = [];
    var i;

    for (i = value.length; i >= 0; i--) {
        reversed.push(value[i]);
    }

    var reversedStr = reversed.toString();
    var reversedVal = reversedStr.replace(/,/g, '');
    return reversedVal;
}

console.log(reverseString('sample'));
console.log(reverseString('softUni'));
console.log(reverseString('java script'));
