'use strict'

function findMaxSequence(value) {
    var sequence = [];
    var maxSequence = [];
    var equalNum;
    var index = 0;
    var i;

    if (value.length > 1) {
        for (i = 1; i < value.length; i++) {
            equalNum = value[i - 1];

            if (equalNum === value[i]) {
                index++;
            } else {
                index = 0;
            }

            sequence.push(index);
        }

        var max;
        var maxNum;
        for (i = 1; i < sequence.length; i++) {
            if (sequence[i] > sequence[i - 1]) {
                max = sequence[i];
                maxNum = value[i + 1];
            }
        }

        var maxSequenceLength = max + 1;
        for (var i = 0; i < maxSequenceLength; i++) {
            maxSequence.push(maxNum);
        }

        return maxSequence;
    } else {
        sequence.push(value[0]);
        return sequence;
    }
}

console.log(findMaxSequence([2, 1, 1, 2, 3, 3, 2, 2, 2, 1]));
console.log(findMaxSequence(['happy']));
console.log(findMaxSequence([2, 'qwe', 'qwe', 3, 3, '3']));
