'use strict'

function calculate() {
    var value = document.getElementById("inputText").value;
    var result = eval(value);

    document.getElementById("result").innerHTML = result;
}