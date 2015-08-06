(function () {
    'use strict'
    angular.module('myApp', ['ngRoute', 'ngResource']).config(function ($routeProvider, $locationProvider) {
        //$routeProvider to define our routes. If someone enters the address/or the address/viewA in 
        //their browser then the /ngViews/viewA.html template will be inserted into the layout. If 
        //someone requests the URL /viewB/78 or /viewB/2 then the /ngViews/viewB.html template will be 
        //inserted into the layout. Finally, if someone enters a URL that does not exit then the /ngViews/notFound.html 
        //template is displayed in the layout. Notice that controller and controllerAs options are included 
        //for each route. When the view is opened, these controllers are associated with the views automatically.
        $routeProvider
            .when('/', {
                templateUrl: '/ngViews/home.html',
                controller: 'HomeController',
                controllerAs: 'main'
            })
            .when('/home', {
                templateUrl: '/ngViews/home.html',
                controller: 'HomeController',
                controllerAs: 'main'
            })
            .when('/lessons', {
                templateUrl: '/ngViews/lessons.html',
                controller: 'LessonsController',
                controllerAs: 'main'
            })
            .otherwise({
                templateUrl: '/ngViews/notFound.html'

            });
        $locationProvider.html5Mode(true);
            
    });

})();