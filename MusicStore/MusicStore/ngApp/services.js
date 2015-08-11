(function () {
    var app = angular.module('myApp');
    app.factory('albumService', function ($resource) {

        var Album = $resource('/api/albums/:id');
        var albums = Album.query();

        // Empty array of albums
        var albums = [];

        // The listAll functions will return the array of albums
        var _listAll = function () {
            // Returns a promise that at some point this query method will either be successful or fail
            return Album.query();
        };

        var _save = function (album) {
            // Should call post method
            return Album.save(album);
        };

        // Exports
        // Create an object that returns a set of functions from inside the service. 
        return {
            listAll: _listAll
        };
    })

})();