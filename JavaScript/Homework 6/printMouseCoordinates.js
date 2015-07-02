'use strict'

function printMouseCoordinates(event) {
    document.getElementById('mouseCoordinates').innerHTML = 'X: ' + event.pageX + '; Y: ' + event.pageY + '; Time: ' + new Date();
}

document.addEventListener('mouseover', printMouseCoordinates, false);