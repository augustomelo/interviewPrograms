var integerCheck = require('./typeInteger');
var decimalCheck = require('./typeDecimal');
var stringCheck = require('./typeString');
var dateCheck = require('./typeDate');


exports.getChecker = function (value) {
    switch (value) {
        case 'Integer':
            return integerCheck;

        case 'Decimal':
            return decimalCheck;

        case 'String':
            return stringCheck;

        case 'Date':
            return dateCheck;
    }
}
