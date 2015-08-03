(function () {
    var app = angular.module('CarApp');
    app.controller('CarController', function () {
        this.saveCar = function () {
            console.dir(this.car);
        };
    });

})();