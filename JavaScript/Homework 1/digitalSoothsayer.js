'use strict'

function soothsayer(value) {
    var result = {};
    var number, resultStr;

    for (var i = 0; i < 4; i++) {
        number = Math.floor((Math.random() * 4) + 1);
        result[i] = value[i][number];
    }

    resultStr = "You will work " + result[0] + " years on " + result[1] + ". You will live in " + result[2] + " and drive " + result[3] + ".";
    return resultStr;
}

console.log(soothsayer([[3, 5, 2, 7, 9],
    ["Java", "Python", "C#", "JavaScript", "Ruby"],
    ["Silicon Valley", "London", "Las Vegas", "Paris", "Sofia"],
    ["BMW", "Audi", "Lada", "Skoda", "Opel"]]));
