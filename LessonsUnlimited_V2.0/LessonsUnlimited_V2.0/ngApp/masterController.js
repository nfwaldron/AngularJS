(function () {
    var app = angular.module('myApp');

    app.controller('HomeController', function ($location) {
        var self = this;
        self.message = "Hello from Home View";
        self.move = function (id) {
            $location.path('lessons/' + id);
        };
    });

    app.controller('LessonsController', function ($routeParams, $resource, $modal, lessonsControllerUrl) {
        var self = this;
        self.message = "Hello from the Lessons View. You requested id" + $routeParams.id;

        // Resource object to retrieve a list of movies from the server. 
        // It retrieves a list of movies from the HTTP GET Ajax call...
        var Lesson = $resource('/api/lessons/:id')
        // The .query() method performs an HTTP GET Ajax call to the URL /api/lessons/:id
        self.lessons = Lesson.query();

        // Client-side function used to Create a book
        self.createLesson = function () {
            var lesson = new Lesson(self.lesson);
            lesson.$save(function (newLesson) {
                self.lessons.push(newLesson);
                self.lessons = null;

            });
        };

        // Client-side function used to Delete a book
        self.delete = function (lesson) {
            lesson.$remove({ id: lesson.id }, function () {
                self.lessons = self.lessons.filter(function (item) {
                    return item.id != lesson.id;
                });
            });
        };

        self.showEditModal = function (id) {
            $modal.open({
                templateUrl: '/ngViews/editModal.html',
                controller: 'ModalController',
                controllerAs: 'modal',
                resolve: { id: function () { return id; } }
            }).result.then(function () {
                self.lessons = Lesson.query();
            });
        }

    });

    app.controller('ModalController', function (id, $modalInstance, $resource, lessonsControllerUrl) {
        var self = this;
        var Lesson = $resource('/api/lessons/:id');
        self.lesson = Lesson.get({ id: id });

        self.editLesson = function () {
            self.lesson.$save(function () {
            $modalInstance.close();
            });
        };
    });

})();