'use strict'

function bitChecker(value) {
    var bin = value.toString(2);
    var thirdBitNumber = bin.charAt(bin.length - 4);
    var thirdBit = true;

    if (thirdBitNumber == 0) {
        thirdBit = false;
    }

    return thirdBit;
}

console.log(bitChecker(333));
console.log(bitChecker(425));
console.log(bitChecker(2567564754));
