(function () {

    var app = angular.module('MultiPage');
    app.directive('myTask', function () {

        return { template: '<b>{{task.taskDescription}}<b>' }
    });

})();