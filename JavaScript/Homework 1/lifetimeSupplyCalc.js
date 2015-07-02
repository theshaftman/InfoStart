'use strict'

function calcSupply(age, maxAge, food, amount) {
    var days = (maxAge - age) * 365;
    var need = days * amount;
    var result;

    result = "You will need " + need + " of " + food;
    return result;
}

console.log(calcSupply(20, 65, "chocolate", 0.5));
console.log(calcSupply(20, 65, "cheese", 0.8));
console.log(calcSupply(20, 65, "water", 2));
console.log(calcSupply(20, 65, "bread", 1));
