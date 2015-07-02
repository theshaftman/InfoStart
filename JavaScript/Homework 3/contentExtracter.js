'use strict'

function extractContent(value) {
    value = value.replace("<p>", "").replace("</p>", "").replace("<a href='http://w3c.org'>", "").replace("</a>", "");
    return value;
}

console.log(extractContent("<p>Hello</p><a href='http://w3c.org'>W3C</a>"));
