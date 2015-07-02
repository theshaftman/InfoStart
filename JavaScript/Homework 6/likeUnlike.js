'use strict'

function likeUnlike() {
    var value = document.getElementsByTagName('button');

    if (value[0].textContent === 'Like') {
        value[0].textContent = 'Unlike';
    } else {
        value[0].textContent = 'Like';
    }
}