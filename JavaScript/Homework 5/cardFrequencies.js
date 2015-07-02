'use strict'

function findCardFrequency(value) {
    var i, count = 1, max = -Infinity;
    var cardObj = [], appearances = [], percent = [], endResult = [];
    var cardArr = value.split(' ');

    for (i = 0; i < cardArr.length; i++) {
        if (cardArr[i][1] === "0") {
            cardObj.push(cardArr[i][0] + cardArr[i][1]);
        } else {
            cardObj.push(cardArr[i][0]);
        }
    }

    cardObj = cardObj.sort(); //sorts the array

    for (i = 1; i < cardObj.length; i++) {
        if (cardObj[i] === cardObj[i - 1]) {
            count++;
        } else {
            appearances.push(cardObj[i - 1] + " " + count); //card, any times
            percent.push(count);
            count = 1;
        }
    }
    appearances.push(cardObj[i - 1] + " " + count); //card, any times
    percent.push(count);
    count = 0;
    
    for (i = 0; i < percent.length; i++) {
        count = count + percent[i];
    } //Returns N

    for (i = 0; i < appearances.length; i++) {
        if (Number(appearances[i][2])) {
            endResult.push(appearances[i][0] + " -> " + ((Number(appearances[i][2]) / count) * 100).toFixed(2) + "%");
        } else {
            endResult.push(appearances[i][0] + appearances[i][1] + " -> " + ((Number(appearances[i][3]) / count) * 100).toFixed(2) + "%");
        }
    } //returns the end result(card face -> % appearances)

    return endResult;
}

console.log(findCardFrequency('8♥ 2♣ 4♦ 10♦ J♥ A♠ K♦ 10♥ K♠ K♦'));
console.log(findCardFrequency('J♥ 2♣ 2♦ 2♥ 2♦ 2♠ 2♦ J♥ 2♠'));
console.log(findCardFrequency('10♣ 10♥'));
