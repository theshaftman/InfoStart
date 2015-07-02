'use strict'

Array.prototype.removeItem = function remove(value) {
    var i;
    var arrNew = [];

    for (i = 0; i < arr.length; i++) {
        if (arr[i] !== value) {
            arrNew.push(arr[i]);
        }
    }

    return arrNew;
}

var arr = [1, 2, 1, 4, 1, 3, 4, 1, 111, 3, 2, 1, '1'];
console.log(arr.removeItem(1));

var arr = ['hi', 'bye', 'hello'];
console.log(arr.removeItem('bye'));
