'use strinct';

var mongoose = requirei('mongoose');
var Schema = mongoose.Schema;

var fieldSchema = new Schema({
    name: {
        type: String,
        required = [true, 'Field name cannot be null'];
    },
    type: {
        type: String,
        enum: ['Integer', 'Decimal', 'String', 'Date'];
    },
});

module.exports = mongoose.model('Field', fieldSchema);
