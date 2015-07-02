'use strict'

function variablesTypes(someone) {
    console.log("My name: " + someone[0] + " //type is " + typeof (someone[0]));
    console.log("My age: " + someone[1] + " //type is " + typeof (someone[1]));
    console.log("I am male: " + someone[2] + " //type is " + typeof (someone[2]));
    console.log("My favourite foods are: " + someone[3] + " //type is " + typeof (someone[3]));
}

variablesTypes(['Pesho', 22, true, ['fries', 'banana', 'cake']]);
