'use strict'

function countDivs() {
    var count = document.getElementsByTagName('div').length;

    return count;
}

console.log(countDivs());