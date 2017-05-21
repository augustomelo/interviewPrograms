var mongoose = require('mongoose'),
    PointInterest = mongoose.model('PointInterest');

function checkMaxDistance(value) {
    return Number.isInteger(value) || value > 0
}

function checkCoordinates(value) {
    for(var i = 0; i < value.length; i++) {
        if (!Number.isInteger(value[i]) || (value[i] < 0))
            return false;
    }

    return true;
}

exports.listAll = function(req, res) {
    PointInterest.find({}, function(err, pointInterest) {
        if(err)
            res.send(err);

        res.json(pointInterest);
    });
};

exports.createPointInterest = function(req, res) {
    var newPointInterest = new PointInterest(req.body);

    newPointInterest.save(function(err, pointInterest) {
        if (err)
            res.send(err);

        res.json(pointInterest);
    });
}

exports.getByDinstance = function(req, res) {
    var maxDistance = Number(req.params.distance);
    var coords = [];
    coords[0] = Number(req.params.xCoordinate);
    coords[1] = Number(req.params.yCoordinate);

    if (!checkMaxDistance(maxDistance) || !checkCoordinates(coords))
        return res.json(500, "Invalid inputs!");

    // find a location
    PointInterest.find({
        loc: {
            $near: coords,
            $maxDistance: maxDistance
        }
    }).select({'name': 1, "_id": 0})
    .exec(function(err, result) {
        if (err) {
            return res.json(err);
        }

        res.json(result);
    });
}
