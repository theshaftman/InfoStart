'use strict'

function replaceSpaces(value) {
    var object = [];
    object = value.split(' ');

    var str = object.toString();
    var result = str.replace(/,/g, '');
    return result;
}

console.log(replaceSpaces("But you were living in another world tryin' to get your message through"));
