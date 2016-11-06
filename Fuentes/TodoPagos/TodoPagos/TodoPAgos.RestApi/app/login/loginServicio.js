(function () {
    'use strict';

    var obligatorioApp = angular.module('TodoPagos');

    obligatorioApp.service('loginServicio', function ($log, $http) {
        var loginServicio = this;

        loginServicio.login = function (usuario, contraseña) {
            var promise = $http({
                url: '/api/login',
                method: "POST",
                data: { 'nombreUsuario': usuario, 'contrasenia': contrasenia }
            })
             .then(function (response) {
                 //sessionStorage.authToken = response.data.Email;
                 location.href = "#/menu";
             },
             function (response) {
                 loginServicio.message = response.data.Message;
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

