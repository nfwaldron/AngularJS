(function () {
    var app = angular.module('myApp');
    app.controller('MoviesController',[function () {
        var self = this;
        self.movies = ['Star Wars', 'King Kong', 'The Mighty Ducks'];
    }]);

})();