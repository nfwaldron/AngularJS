(function () {
    angular.module('MultiPage', ['ngAnimate', 'ngRoute']).config(function ($routeProvider){
        $routeProvider             .when('/', {                 templateUrl: '/ngViews/viewA.html',                 controller: 'ViewAController',                 controllerAs: 'main'             })             .when('/viewB', {                 templateUrl: '/ngViews/viewB.html',                 controller: 'ViewBController',                 controllerAs: 'main'             });
    })

})();