'use strict';

module.exports = function(app) {
    var pointInterest = require('../controllers/pointInterestController');


    app.route('/pointInterest')
        .get(pointInterest.listAll)
        .post(pointInterest.createPointInterest);

    app.route('/pointInterest/:xCoordinate/:yCoordinate/:distance')
        .get(pointInterest.getByDinstance);
};
