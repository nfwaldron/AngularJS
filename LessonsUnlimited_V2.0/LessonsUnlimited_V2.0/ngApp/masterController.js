(function () {
    var app = angular.module('myApp');

    app.controller('HomeController', function ($location) {
        var self = this;
        self.message = "Hello from Home View";
        self.move = function (id) {
            $location.path('lessons/' + id);
        };
    });

    app.controller('LessonsController', function ($routeParams, $resource) {
        var self = this;
        self.message = "Hello from the Lessons View. You requested id" + $routeParams.id;

        // Resource object to retrieve a list of movies from the server. 
        // It retrieves a list of movies from the HTTP GET Ajax call...
        var Lesson = $resource('/api/lessons/:id')
        self.lessons = Lesson.query();
    });


})();