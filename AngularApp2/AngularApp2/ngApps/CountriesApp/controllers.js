(function () {
    angular.module('CountriesApp').controller('CountriesController', function () {
        this.countries = countries;

        });
    var countries = [
        {name:'Trinidad',
        population: 120000},
        {name: 'USA',
        population: 6000000},
        {name: 'Indonesia',
        population: 130000
        }
    ]

    this.chooseColor = function (selectedColor) {
        alert('You chose' + selectedColor);
    }

})();