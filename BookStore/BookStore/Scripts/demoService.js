(function () {
    var app = angular.module('BookApp');

    app.factory("demoService", function () {
        function haha() {
            console.log("hello");
        }

        return {
            haha: haha
        };
    });
})();
//# sourceMappingURL=demoService.js.map
