'use strict'

function findPalindromes(value) {
    var obj = [];
    var endObj = [];
    var i;

    value = value.replace(",", "").replace(".", "");
    value = value.toLowerCase();
    obj = value.split(" ");

    for (i = 0; i < obj.length; i++) {
        if (obj[i].length == 1) {
            endObj.push(obj[i]);
        } else {
            if (checkIndex(obj[i])) {
                endObj.push(obj[i]);
            }
        }
    }

    return endObj;
}

function checkIndex(str) {
    var strObj = [];
    var result;
    var i;

    for (i = 0; i < str.length; i++) {
        strObj.push(str[i]);
    }
    strObj.reverse();
    result = strObj.toString();
    result = result.replace(/,/g, "");

    if (result === str) {
        return true;
    }
}

console.log(findPalindromes('There is a man, his name was Bob.'));
