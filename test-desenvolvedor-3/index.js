var express = require('express'),
    app = express(),
    port = process.env.PORT || 3000,
    mongoose = require('mongoose'),
    PointInterest = require('./api/models/pointInterestModel'),
    bodyParser = require('body-parser');

var config = require('./config.js')

mongoose.Promise = global.Promise;
//mongoose.connect(config.configuration.DBCONNECTION);

app.use(bodyParser.urlencoded({ extended: true }));
app.use(bodyParser.json());

var routes = require('./api/routes/');
routes(app);

app.listen(port);

console.log('Application RESTful API server started on: ' + port);
