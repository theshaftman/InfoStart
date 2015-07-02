'use strict'

function printNumbers(n) {
    var num = [];

    if (n > 0) {
        for (var i = 1; i <= n; i++) {
            if ((i % 4 != 0) && (i % 5 != 0)) {
                num.push(i);
            }
        }

        return num;
    }
    else {
        return "no";
    }
}

console.log(printNumbers(20));
console.log(printNumbers(-5));
console.log(printNumbers(13));
