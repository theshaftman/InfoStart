'use strict'

function hideRows() {
    var number = document.getElementsByTagName('button');
    var i, j, tableRows;

    for (i = 0; i < number.length; i++) {
        if (number[i].id === "btnHideOddRows") {
            tableRows = document.getElementsByTagName('tr');

            for (j = 0; j < tableRows.length; j++) {
                if ((j + 1) % 2 !== 0) {
                    tableRows[j].style.display = 'none';
                }
            }
        }
    }
}

var button = document.getElementById('btnHideOddRows');
button.addEventListener('click', hideRows, false);
