(function () {
    angular.module('CountriesApp').controller('CountriesController', function () {
        this.countries = countries;
        this.chooseColor = function (selectedColor) {
            alert('You chose' + selectedColor);
        };
        this.submit = function() {
            this.firstNameEnhanced = this.firstName + '!';
        };

        this.calculate = function () {
            this.result = +this.num1 + +this.num2;
        };

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

   

})();