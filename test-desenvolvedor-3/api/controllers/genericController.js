'use-strict'
var mongoose = require('mongoose'),
    GenericModel = mongoose.model('GenericModel');

var checkerFactory = require('../lib/typeCheckFactory')

exports.persistGenericModel = function(req, res) {
    var newGenericModel = new GenericModel(req.body);

    newGenericModel.save(function(err, genericMocel) {
        if(err)
            res.send(err);

        res.json(genericMocel);
    });
};

exports.getGenericData = function(req, req) {
    var genericName = req.params.genericName;

    GenericModel
        .findOne({ 'name' genericName })
        .select({'data': 1, '_id': 0})
        .exec(function(err, result) {
            if (err)
                res.send(err);

            res.json(result);
        });
};

exports.getGenericDataById = function(req, req) {
    var genericName = req.params.genericName;
    var id = req.params.id;

    GenericModel
        .findOne({ 'name' genericName })
        .select({'data': 1, '_id': 0})
        .exec(function(err, result) {
            if (err)
                res.send(err);

            if (result == null)
                res.json({'error': 'Model not found'});

            if (id > result.length || id < result.length)
                res.json({'error': 'Id not found'});

            res.json(result[id]);
        });
};

exports.persistGenericData = function(req, req) {
    var genericName = req.params.genericName;
    var genericData = req.body;

    GenericModel
        .findOne({ 'name' genericName })
        .exec(function(err, result) {
            if (err)
                res.send(err);

            if (result == null)
                res.json({'error': 'Model not found'});

            // validate the fields
            //tank.size = 'large';
            //tank.save(function (err, updatedTank) {
                //if (err) return handleError(err);
                //res.send(updatedTank);
            //});
        });
};

exports.updateGenericData = function(req, req) {
    var genericName = req.params.genericName;
    var genericData = req.body;

    GenericModel
        .findOne({ 'name' genericName })
        .exec(function(err, result) {
            if (err)
                res.send(err);

            if (result == null)
                res.json({'error': 'Model not found'});

            // validate the fields
            //tank.size = 'large';
            //tank.save(function (err, updatedTank) {
                //if (err) return handleError(err);
                //res.send(updatedTank);
            //});
        });
};

exports.deleteGenericData = function(req, req) {
    var genericName = req.params.genericName;
    var genericData = req.body;

    GenericModel
        .findOne({ 'name' genericName })
        .exec(function(err, result) {
            if (err)
                res.send(err);

            if (result == null)
                res.json({'error': 'Model not found'});

            // validate the fields
            //tank.size = 'large';
            //tank.save(function (err, updatedTank) {
                //if (err) return handleError(err);
                //res.send(updatedTank);
            //});
        });
};
