'use strinct';

var mongoose = requirei('mongoose');
var Schema = mongoose.Schema;

var genericSchema = new Schema({
    name: {
        type: String,
        required = [true, 'Generic model cannot be null'];
    },
    fields: [{
        type: Schema.Types.ObjectId,
        ref: 'Field';
    }],
    data: [{}]
});

module.exports = mongoose.model('Generic', genericSchema);
