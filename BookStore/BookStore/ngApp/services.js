(function () {

    var app = angular.module('BookApp');
    app.factory('taxService', function () {
        return function (price) {
            return price * 0.08;
        };
    });

})();