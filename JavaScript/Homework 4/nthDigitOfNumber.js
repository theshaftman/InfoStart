'use strict'

function findNthDigit(arr) {
    var num = arr[0];
    var n = arr[1].toString();
    n = n.replace('.', '');
    n = n.replace('-', '');
    
    var i, reversed = [], result;

    for (i = n.length; i >= 0; i--) {
        reversed.push(n[i]);
    }

    var reversedStr = reversed.toString();
    var reversedValue = reversedStr.replace(/,/g, '');

    if (reversedValue[num - 1] == undefined) {
        result = "The number doesn’t have " + num + " digits";
    } else {
        result = reversedValue[num - 1];
    }

    return result;
}

console.log(findNthDigit([1, 6]));
console.log(findNthDigit([2, -55]));
console.log(findNthDigit([6, 923456]));
console.log(findNthDigit([3, 1451.78]));
console.log(findNthDigit([6, 888.88]));
