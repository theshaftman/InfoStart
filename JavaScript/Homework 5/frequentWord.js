'use strict'

function findMostFreqWord(value) {
    var valueObj = [];
    var frequentObj = [], alphabeticalOrder = [];
    var i, j, count = 0, max = -Infinity, index, result;

    value = value.toLowerCase();
    valueObj = value.split(' ');

    for (i = 0; i < valueObj.length; i++) {
        for (j = 0; j < valueObj.length; j++) {
            if (valueObj[i] === valueObj[j]) {
                count++;
            }
        }
        frequentObj.push(count);
        count = 0;
    }

    for (i = 0; i < frequentObj.length; i++) {
        if ((frequentObj[i] > max) || (frequentObj[i] === max)) {
            max = frequentObj[i];
            index = i;
        }
    }

    alphabeticalOrder.push(valueObj[index].replace(/[.]/g, "") + " -> " + max + " times");
    return alphabeticalOrder;
}

console.log(findMostFreqWord('in the middle of the night'));
console.log(findMostFreqWord('Welcome to SoftUni. Welcome to Java. Welcome everyone.'));
console.log(findMostFreqWord('Hello my friend, hello my darling. Come on, come here. Welcome, welcome darling.'));
