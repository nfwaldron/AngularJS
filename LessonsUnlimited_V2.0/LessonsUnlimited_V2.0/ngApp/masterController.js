(function () {
    var app = angular.module('myApp');

    app.controller('HomeController', function ($location) {
        this.message = "Hello from Home View";
        this.move = function (id) {
            $location.path('lessons/' + id);
        };
    });

    app.controller('LessonsController', function ($routeParams) {
        this.message = "Hellos from the Lessons View. You requested id" + $routeParams.id;
    });

})();