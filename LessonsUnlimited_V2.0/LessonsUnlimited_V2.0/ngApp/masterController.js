(function () {
    var app = angular.module('myApp');

    app.controller('HomeController', function ($location) {
        var self = this;
        self.message = "Hello from Home View";
        self.move = function (id) {
            $location.path('lessons/' + id);
        };
    });

    app.controller('LessonsController', function ($routeParams, $resource, $modal, lessonServices, $sce) {
        var self = this;
       
        self.embedLink = function (videoLink) {

            return $sce.trustAsResourceUrl("https://www.youtube.com/embed/" + videoLink);

        };

        self.lessons = [];

        self.getLessons = function () {
            // Array to store the list of lessons fretrieved from the API controller
            self.lessons = lessonServices.listAll();
        };

        // When the controller is called, the getLessons() method is executed, which 
        // executes lines 18-20.
        self.getLessons();
        

        //Create MODAL
        self.showCreateModal = function () {
            $modal.open({
                templateUrl: '/ngViews/createModal.html',
                controller: 'CreateLessonModal',
                controllerAs: 'modal'
            }).result.then(function () {
                self.getLessons();
            });
        };
       
        // Edit MODAL
        self.showEditModal = function (id) {
            $modal.open({
                templateUrl: '/ngViews/createModal.html',
                controller: 'EditLessonModal',
                controllerAs: 'modal',
                resolve: { id: function () { return id; } }
            }).result.then(function () {
                self.getLessons();
            });
        }

        // Delete MODAL
        self.showRemoveModal = function (id) {
            $modal.open({
                templateUrl: '/ngViews/removeModal.html',
                controller: 'RemoveLessonModal',
                controllerAs: 'modal',
                resolve: {
                    id: function () {
                        return id;
                    }
                }
            }).result.then(function () {
                self.getLessons();
            });
        }

    });

    app.controller('CreateLessonModal', function ( $modalInstance, lessonServices) {
        var self = this;
        self.save = function () {
            lessonServices.save(self.lesson).$promise.then(function () {
                $modalInstance.close();
            });
        };
    });

    app.controller('EditLessonModal', function ($modalInstance, lessonServices, id) {
        var self = this;
        self.lesson = lessonServices.get(id);
        self.save = function () {
            lessonServices.save(self.lesson).$promise.then(function () {
                $modalInstance.close();
            });
        };
    });

    app.controller('RemoveLessonModal', function ($modalInstance, lessonServices, id) {
        var self = this;

        // Remove a selected lesson.
        self.remove = function () {
            lessonServices.remove(id).$promise.then(function () {
                $modalInstance.close();
            })
        }
        // Dismiss the modal (in the case that the user does not want to delete)
        self.exit = function () {
            $modalInstance.dismiss();
        };
    });

})();