'use strict'

function treeHouseCompare(a, b) {
    var roofArea = a * (2/3 * a) / 2;
    var floorArea = a * a;
    var houseArea = roofArea + floorArea;

    var treeStemArea = b * (b / 3);
    var treeCircleRadius = (2 / 3) * b;
    var treeCircleArea = Math.PI * treeCircleRadius * treeCircleRadius;
    var treeArea = treeStemArea + treeCircleArea;
    var result;

    if (houseArea > treeArea) {
        result = "house/" + houseArea.toFixed(2);
        return result;
    } else {
        result = "tree/" + treeArea.toFixed(2);
        return result;
    }
}

console.log(treeHouseCompare(3, 2));
console.log(treeHouseCompare(3, 3));
console.log(treeHouseCompare(4, 5));
