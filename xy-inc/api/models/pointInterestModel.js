'use strict';
var mongoose = require("mongoose");
var Schema = mongoose.Schema;

var PointInterestSchema = new Schema({
    name: {
        type: String,
        Required: "Enter the Point of interest name"
    },
    x-coordinate: {
        type: Number,
        min:0,
        get: value => Math.round(value),
        set: value => Math.round(value)
    },
    y-coordinate: {
        type: Number,
        min:0,
        get: value => Math.round(value),
        set: value => Math.round(value)
    }
});


module.exports = mongoose.model('PointInterest', PointInterestSchema)
