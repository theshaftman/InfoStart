'use strict'

function checkBrackets(value) {
    var leftBraketsCount = checkBraketsCount(value, "(");
    var rightBraketsCount = checkBraketsCount(value, ")");
    var result = "correct";

    if (leftBraketsCount === rightBraketsCount) {
        return result;
    } else {
        return "in" + result;
    }
}

function checkBraketsCount(value, bracket) {
    var count = 0;
    var i;

    for (i = 0; i < value.length; i++) {
        if (value[i] == bracket) {
            count++;
        }
    }
    return count;
}

console.log(checkBrackets('( ( a + b ) / 5 – d )'));
console.log(checkBrackets(') ( a + b ) )'));
console.log(checkBrackets('( b * ( c + d *2 / ( 2 + ( 12 – c / ( a + 3 ) ) ) )'));
