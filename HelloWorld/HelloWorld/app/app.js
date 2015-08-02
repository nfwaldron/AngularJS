(function () {
    var app = angular.module('gemStore', [])

    //create controller
    app.controller('StoreController', function () {
        this.products = gems;

    });

    // create objects that will be represented in the real world
    var gems = [
         {
             name: 'Ruby',
             price: 3.50,
             description: '....',
             canPurchase: false,
             soldOut: true
         },

        {
            name: 'Diamond',
            price: 4.50,
            description: '....',
            canPurchase: true,
            soldOut: false
        },
        {
            name: 'Emerald',
            price: 7.25,
            description: '....',
            canPurchase: true,
            soldOut: false
        }
    ];

})();
