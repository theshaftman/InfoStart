'use strict'

function findMostFreqNum(value) {
    var i, j, k, maxNumber, result = "";
    var counter = 0;
    var counterObj = [];
    var maxIndex = -Infinity;

    for (i = 0; i < value.length; i++) {
        for (j = 0; j < value.length; j++) {
            if (value[i] === value[j]) {
                counter++;
            }
        }
        counterObj.push(counter);
        counter = 0;
    }

    for (k = 0; k < counterObj.length; k++) {
        if (counterObj[k] > maxIndex) {
            maxIndex = counterObj[k];
            maxNumber = value[k];
        }
    }

    result = maxNumber + "(" + maxIndex + " times)";
    return result;
}

console.log(findMostFreqNum([4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3]));
console.log(findMostFreqNum([2, 1, 1, 5, 7, 1, 2, 5, 7, 3, 87, 2, 12, 634, 123, 51, 1]));
console.log(findMostFreqNum([1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13]));
