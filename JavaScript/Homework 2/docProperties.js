'use strict'

function displayProperties(value) {
    var valueSorted = [];

    for (var property in value) {
        //valueSorted.push(property);

        if (value.hasOwnProperty(property)) {
            valueSorted.push(property);
        }
    }
    valueSorted.sort();

    return valueSorted;
}

console.log(displayProperties(document));
