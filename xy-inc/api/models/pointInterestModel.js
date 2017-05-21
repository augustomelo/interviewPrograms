'use strict';

function validateSize(value) {
    return !(value.length > 2);
}

function validateType(value) {
    for(var i = 0; i < value.length; i++) {
        if (!Number.isInteger(value[i]) || (value[i] < 0))
            return false;
    }

    return true;
}

var mongoose = require("mongoose");
var Schema = mongoose.Schema;
var validators = [
    { validator: validateSize, msg: "Only two coordinates are allowed!"},
    { validator: validateType, msg: "Only positive and integer values are allowed as coordinates!"}
];

var PointInterestSchema = new Schema({
    name: {
        type: String,
        required: [true, "Enter the Point of interest name"]
    },
    loc: {
        type: [Number],
        index: '2d',
        required: [true, "Enter x and y coordinate"],
        validate: validators
    }
});

module.exports = mongoose.model('PointInterest', PointInterestSchema);
