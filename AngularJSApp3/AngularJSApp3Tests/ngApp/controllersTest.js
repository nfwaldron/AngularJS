/// <reference path="../../angularjsapp3/scripts/angular.min.js" />
/// <reference path="../../angularjsapp3/scripts/angular-mocks.js" />
/// <reference path="../../angularjsapp3/ngapp/app.js" />
/// <reference path="../../angularjsapp3/ngapp/controller.js" />
  describe('MoviesController', function () {
     beforeEach(module('myApp'));       var $controller;     beforeEach(inject(function ($injector) {
        $controller = $injector.get('$controller');
    }));       it('returns expected movies', function () {
        var vm = $controller('MoviesController');         expect(vm.movies).toEqual(['Star Wars', 'King Kong', 'The Mighty Ducks']);
    });
   });