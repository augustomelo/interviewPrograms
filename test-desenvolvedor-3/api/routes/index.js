'use strict';

module.exports = function(app) {
    var generic = require('../controllers/genericController');

    app.route('/genericmodel')
        .post(generic.persistGenericModel);

    app.route('/:genericName')
        .get(generic.getGenericData)
        .post(generic.persistGenericData);

    app.route('/:genericName/:id')
        .get(generic.getGenericDataById)
        .put(generic.updateGenericData)
        .delete(generic.deleteGenericData);
};
