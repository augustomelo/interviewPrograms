exports.validate = function(value) {
    return Number.isFinite(value) && !Number.isInteger(value);
}
