'use strict'

function reverseWordsInString(str) {
    var strObject = str.split(' ');
    var i, j, reversedStr, result;
    var reversed = [];
    var reversedVal = [];

    for (i = 0; i < strObject.length; i++) {

        for (j = strObject[i].length; j >= 0; j--) {
            reversed.push(strObject[i][j]);
        }

        reversedStr = reversed.toString().replace(/,/g, "");
        reversedVal.push(reversedStr);
        reversed = [];
    }

    result = reversedVal.toString().replace(/,/g, ' ');
    return result;
}

console.log(reverseWordsInString("Hello, how are you."));
console.log(reverseWordsInString("Life is pretty good, isn’t it?"));
