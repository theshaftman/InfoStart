'use strict'

function divisionBy3(value) {
    var result;

    if (value > 9) {
        if (value % 3 === 0) {
            result = "the number " + value + " is divided by 3 without remainder";
        } else {
            result = "the number " + value + " is NOT divided by 3 without remainder";
        }
    } else {
        result = "Error! Number MUST BE higher than 9!";
    }

    return result;
}

console.log(divisionBy3(12));
console.log(divisionBy3(188));
console.log(divisionBy3(591));
