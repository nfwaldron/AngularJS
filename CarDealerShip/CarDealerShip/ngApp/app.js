(function () {
    'use strict'
    angular.module('myApp', ['ngRoute', 'ngResource', 'ui.bootstrap']).config(function($routeProvider, $locationProvider) {
        $routeProvider
            .when('/', { templateUrl: '/ngViews/home.html', controller: 'HomeController', controllerAs: 'main' })
            .when('/home', { templateUrl: '/ngViews/home.html', controller: 'HomeController', controllerAs: 'main' })
            .when('/admin', { templateUrl: '/ngViews/admin.html', coontroller: 'AdminController', controllerAs: 'main' })
            .otherwise({ templateUrl: '/ngViews/notFound.html' });
        $locationProvider.html5Mode(true);
    });
})();