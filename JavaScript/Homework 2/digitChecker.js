'use strict'

function checkDigit(n) {
    var isThree = false;

    if (n > 1000) {
        var number = n.toString();

        if (number.charAt(number.length - 3) == 3) {
            isThree = true;
        }
        return isThree;
    }
    else {
        return "Error! Number must be higher than 1000!";
    }
}

console.log(checkDigit(1235));
console.log(checkDigit(25368));
console.log(checkDigit(123456));
