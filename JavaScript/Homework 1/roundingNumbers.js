'use strict'

function roundNumber(value) {
    var roundNumber = Math.round(value);
    var floorNumber = Math.floor(value);
    var result;

    result = "Round number: " + roundNumber + "\nFloor number: " + floorNumber;
    return result;
}

console.log(roundNumber(22.7));
console.log(roundNumber(12.3));
console.log(roundNumber(58.7));
