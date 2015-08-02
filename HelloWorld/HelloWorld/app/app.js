(function () {
    var app = angular.module('gemStore', [])

    //create controller
    app.controller('StoreController', function () {
        this.product = gem;

    });

    // create objects that will be represented in the real world
    var gem = {
        name:'Ruby',
        price:3.50,
        description:'....'
    };

})();
