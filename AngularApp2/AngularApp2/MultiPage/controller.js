(function () {
    var app = angular.module('MultiPage');
    app.controller('ViewAController', function ($location) {
        this.message = "Hello from View A!";
        this.move = function (id) {
            $location.path('viewB/' + id);
        };
    });

    app.controller('ViewBController', function () {
        this.message = "Helo from View B!";
    });


})();