'use strict'

function convertKWtoHP(kw) {
    var hp = kw / 0.745699872;
    var result = Math.round(hp * 100) / 100;
    return result;
}

console.log(convertKWtoHP(75));
console.log(convertKWtoHP(150));
console.log(convertKWtoHP(1000));
