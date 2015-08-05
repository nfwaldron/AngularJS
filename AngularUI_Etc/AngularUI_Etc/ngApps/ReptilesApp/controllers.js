(function () {

    var app = angular.module('ReptileApp');
    app.controller('ReptilesController', function ($http) {
        var self = this;
        this.fetch = function () {

            if (self.filter) {
                $http.get('/api/reptiles?filter=' + encodeURIComponent(self.filter))
                    .success(function (results) {
                        self.reptiles = results;
                    })
                    .error(function (results) {
                        console.error(results);
                    });
            }
        }

    });

})();