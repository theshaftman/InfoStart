'use strict'

function fixCasing(value) {
    var i, j;
    var upCase, downCase, mixCase, endResult;
    var endResultObject = [];
    var valueObj = value.split(/<\/[a-z]*>/);

    for (i = 0; i < valueObj.length; i++) {
        if (typeUpcase(valueObj[i]) !== undefined) { }
        else if (typeLowcase(valueObj[i]) !== undefined) { }
        else if (typeMixcase(valueObj[i]) !== undefined) { }
        else {
            endResultObject.push(valueObj[i]);
        }
    }

    function typeUpcase(str) {
        var valueStr = str.split("<upcase>");
        if (valueStr[1] !== undefined) {
            upCase = valueStr[1].toString();
            upCase = upCase.toUpperCase();

            endResultObject.push(valueStr[0] + upCase);
        }
        return valueStr[1];
    }

    function typeLowcase(str) {
        var valueStr = str.split("<lowcase>");
        if (valueStr[1] !== undefined) {
            downCase = valueStr[1].toString();
            downCase = downCase.toLowerCase();

            endResultObject.push(valueStr[0] + downCase);
        }
        return valueStr[1];
    }

    function typeMixcase(str) {
        var valueStr = str.split("<mixcase>");
        if (valueStr[1] !== undefined) {
            mixCase = valueStr[1].toString();

            for (j = 0; j < mixCase.length ; j++) {
                if (j % 2 == 0) {
                    mixCase = mixCase.replace(mixCase[j], mixCase[j].toUpperCase())
                } else {
                    mixCase = mixCase.replace(mixCase[j], mixCase[j].toLowerCase())
                }
            }

            endResultObject.push(valueStr[0] + mixCase);
        }
        return valueStr[1];
    }

    endResult = endResultObject.toString();
    endResult = endResult.replace(/,/g, "");
    return endResult;
}

console.log(fixCasing("We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don't</mixcase> have <lowcase>Anything</lowcase> else."));
