'use strict'

function findLargestBySumOfDigits(nums) {
    var sum = [];
    var endResult = "0";
    var str;

    if (nums.length < 1) {
        endResult = "undefined";
    }
    else {
        for (var i = 0; i < nums.length; i++) {
            str = nums[i].toString();
            var result = "";

            if (typeof (nums[i]) === "string") {
                endResult = "undefined";
                break;
            }

            for (var j = 0; j < str.length; j++) {
                if (str[j] == ".") {
                    endResult = "undefined";
                    break;
                }

                result = result + str[j] + "+"
            }

            result = result + "0";
            result = result.replace("-", "");
            var resultSum = eval(result);
            sum.push(resultSum);
        }

        if (endResult !== "undefined") {
            //console.log(sum);
            //var max = Math.max.apply(null, sum);

            var max = -Infinity;
            var index;

            for (var i = 0; i < sum.length; i++) {
                if (sum[i] > max) {
                    max = sum[i];
                    index = i;
                }
            }
            //console.log(max + "index" + index);
            endResult = nums[index];
        }
    }

    return endResult;
}

console.log(findLargestBySumOfDigits([5, 10, 15, 111]));
console.log(findLargestBySumOfDigits([33, 44, -99, 0, 20]));
console.log(findLargestBySumOfDigits(['hello']));
console.log(findLargestBySumOfDigits([5, 3.3]));
