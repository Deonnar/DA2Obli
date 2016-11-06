(function () {
    'use strict';

    var obligatorioApp = angular.module('TodoPagos');

    obligatorioApp.service('loginServicio', function ($log, $http) {
        var loginServicio = this;

        loginServicio.login = function (u, password) {
            var promise = $http({
                url: '/api/auth',
                method: "POST",
                data: { 'email': emaildata, 'password': password }
            })
             .then(function (response) {
                 sessionStorage.authToken = response.data.Email;
                 loginServicio.TypeOfUser().then(function (typeOfUser) {
                     if (typeOfUser.data == 1) {
                         location.href = "#/stocks";
                         sessionStorage.typeOfUser = 1;
                     }
                     if (typeOfUser.data == 2) {
                         location.href = "#/portfolio";
                         sessionStorage.typeOfUser = 2;
                     }

                 });
             },
             function (response) {
                 loginServicio.message = response.data.Message;
             });
            return promise;
        }

        loginServicio.TypeOfUser = function () {
            var promise = $http.get('/api/auth?mail=' + sessionStorage.authToken)
             .success(function (result) {
                 return result;
             })
             .error(function (data, status) {
                 $log.error(data);
             });
            return promise;
        }

        loginServicio.logout = function () {
            sessionStorage.typeOfUser = 0;
            $http({
                url: '/api/auth?email=' + sessionStorage.authToken,
                method: 'DELETE'
            })
            sessionStorage.authToken = undefined;
            location.href = "#/login"
        }

        return loginServicio;
    });
})();

