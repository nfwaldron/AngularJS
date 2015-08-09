(function () {

    var app = angular.module('MultiPage');
    app.directive('myTask', function () {

        return { template: '<b>{{task.taskDescription}}<b>' }
    });

    app.directive('callout', function () {
        var style = 'style="border:1px solid black; padding:4px;background-color:orange"';
        return {
            transclude: true,
            template: '<div' + style + 'ng-transclude></div>'
        };
    })

})();