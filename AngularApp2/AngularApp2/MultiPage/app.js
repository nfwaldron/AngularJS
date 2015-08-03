(function () {
    angular.module('MultiPage', ['ngRoute']).config(function ($routeProvider, $locationProvider) {
        $routeProvider
        .when('/', {
            templateUrl: '/ngViews/viewA.html',
            controller: 'ViewAController',
            controllerAs: 'main'
        })
             .when('/viewA', {
                 templateUrl: '/ngViews/viewA.html',
                 controller: 'ViewAController',
                 controllerAs: 'main'
             })
         .when('/viewB/:id', {
             templateUrl: '/ngViews/viewB.html',
             controller: 'ViewBController',
             controllerAs: 'main'
         })
        .otherwise({
            templateUrl: '/ngViews/notFound.html'
        });

        $locationProvider.html5Mode(true);
    });

    

})();