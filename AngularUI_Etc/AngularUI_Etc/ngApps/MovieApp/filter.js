(function () {
    'use strict'

    var app = angular.module('MovieApp');
    app.filter('startsWith', function () {
        return function (input, expression) {
            if (expression){
            expression = expression.toLowerCase();
            return input.filter(function (item) {
                return item.toLowerCase().startsWith(expression);
            });
            }
        }
    });

    app.filter('unique', function () {
        return function (input, expression) {
            var movieSet = new Set(input);
            var movieArray = [];
            for (let movie of movieSet)
            {
                movieArray.push(movie);
            };
            return movieArray;
            
        }
    );






})();