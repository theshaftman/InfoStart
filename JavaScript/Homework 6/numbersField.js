'use strict'

function numbersField() {
    var field = document.getElementById('numberField');
    var inputValue = field.value;
    var correctValue;

    if (isNaN(inputValue)) {
        field.style.backgroundColor = 'red';
        field.disabled = true;
        correctValue = field.value.replace(/([^0-9])/g, "");
        field.value = correctValue;
    }
    setTimeout(function () {
        field.style.backgroundColor = 'transparent';
        field.disabled = false;
        field.focus();
    }, 2000);
}