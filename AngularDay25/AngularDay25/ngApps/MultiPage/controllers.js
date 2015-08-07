(function () {

    var app = angular.module('MultiPage');
    app.controller('ViewAController', function () {
        var self = this;
        self.tasks = [];
        self.addTask = function () {
            if (self.task) {
            self.tasks.push({
                taskDescription: self.task.taskDescription
            });

            self.task = null;
            }
        };

    });

    app.controller('ViewBController', function () {

    })

})();