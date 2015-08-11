(function () {

    angular.module('myApp').factory('lessonServices', function ($resource) {

        // Resource object to retrieve a list of movies from the server. 
        // It retrieves a list of movies from the HTTP GET Ajax call...
        var Lesson = $resource('/api/lessons/:id')

        var _listAll = function () {
            return Lesson.query();
        };

        var _save = function (lesson) {
            return Lesson.save(lesson);
        };

        var _get = function(id)
        {
            return Lesson.get({id:id})
        };

        var _remove = function (id) {
            return Lesson.remove({id:id})
        };

        //Exports
        return {
            listAll: _listAll,
            save: _save,
            get: _get,
            remove: _remove
        };

    });

})();