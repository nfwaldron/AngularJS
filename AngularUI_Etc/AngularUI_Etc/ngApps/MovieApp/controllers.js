(function () {

    var app = angular.module('MovieApp');
    app.controller('MoviesController', function () {
        //this.movies = [
        //    { title: "Star Wars", description: "Greatest movie ever" },
        //    { title: "Rogue Nation", description: "Flyest movie ever" },
        //    { title: "Man of Steel", description: "Worst movie ever" },
        //]

        this.movies = [
            "Star Wars",
            "Rogue Nation",
            "Man of Steel",
            "Star Wars",
            "Star Wars Episode II: Attach of the Clones"
    ]
    });

})();