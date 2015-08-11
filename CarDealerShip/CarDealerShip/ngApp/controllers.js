(function () {

    var app = angular.module('myApp');
    app.controller('HomeController', function ($routeParams, $resource) {
        var self = this;
        self.message = 'Home View';

        // TESLA DISPLAY //

        var Tesla = $resource('/api/tesla/:id');
        self.teslas = Tesla.query();

        // ROLLS ROYCE DISPLAY //
        var RollsRoyce = $resource('/api/rollsroyce/:id');
        self.rolls = RollsRoyce.query();

    });

    app.controller('AccountController', function ($http) {
                var self = this;

                self.login = function () {
                    self.loginMessage = '';
                    var data = "grant_type=password&username=" + self.login.email + "&password=" + self.login.password;

                    $http.post('/Token', data,
                    {
                        headers: { 'Content-Type': 'application/x-www-form-urlencoded' }
                    }).success(function (result) {
                        self.login = null;
                        $http.defaults.headers.common['Authorization'] = 'bearer ' + result.access_token;
                        $http.get('/api/Admin/isAdmin').success(function (isAdmin) {
                            sessionStorage.setItem('accessToken', result.access_token);
                            sessionStorage.setItem('isAdmin', isAdmin);
                        });

                        
                    }).error(function () {
                        self.loginMessage = 'Invalid user name/password';
                    });
                };

                self.logout = function () {
                    sessionStorage.removeItem('accessToken');
                    sessionStorage.removeItem('isAdmin');
                };
                
                self.isAdmin = function () {
                    return sessionStorage.getItem('isAdmin') === "true";
                }

                self.isLoggedIn = function () {
                    return sessionStorage.getItem('accessToken') != undefined;
                }

    });

})();