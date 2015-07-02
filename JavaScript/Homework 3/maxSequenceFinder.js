'use strict'

function findMaxSequence(value) {
    var i, j;
    var counter = 0;
    var sequenceObj = [0];
    var result;

    for (i = 1; i < value.length; i++) {
        if (value[i] > value[i - 1]) {
            counter++;
        }
        else {
            counter = 0;
        }
        sequenceObj.push(counter);
    }

    return sequenceObj;
}

console.log(findMaxSequence([3, 2, 3, 4, 2, 2, 4]));
console.log(findMaxSequence([3, 5, 4, 6, 1, 2, 3, 6, 10, 32]));
console.log(findMaxSequence([3, 2, 1]));
