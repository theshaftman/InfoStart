﻿'use strict'

function sumTwoHugeNumbers(value) {
    var num1, num2;

    num1 = Number(value[0]);
    num2 = Number(value[1]);

    return num1 + num2;
}

console.log(sumTwoHugeNumbers(['155', '65']));
console.log(sumTwoHugeNumbers(['123456789', '123456789']));
console.log(sumTwoHugeNumbers(['887987345974539', '4582796427862587']));
console.log(sumTwoHugeNumbers(['347135713985789531798031509832579382573195807', '817651358763158761358796358971685973163314321']));
