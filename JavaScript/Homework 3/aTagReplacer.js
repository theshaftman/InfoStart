'use strict'

function replaceATag(value) {
    value = value.replace("<a href='http://infostart.eu'>", "[URL href='http://infostart.eu']").replace(/<\/a>/g, "[/URL]");

    return value;
}

console.log(replaceATag("<ul><li><a href='http://infostart.eu'>InfoStart</a></li></ul>"));
