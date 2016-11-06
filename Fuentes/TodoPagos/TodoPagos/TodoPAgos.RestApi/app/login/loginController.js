(function () {
    'use strict';

    var obligatorioApp = angular.module('TodoPagos');

    obligatorioApp.controller('Login.Controller', function ($scope, loginServicio) {

        var ctrl = this;
        ctrl.servicio = loginServicio;

        $scope.Login = function () {
            loginServicio.login($scope.usuario, $scope.contraseña).then(function () {
                if (login.message)
                    $scope.showError = loginServicio.message;
            });
            //   $scope.token = sessionStorage.authToken;
        };

        $scope.Logout = function () {
            loginServicio.logout();
        };

        var errorMessagge = loginServicio.message;

        $scope.showError = errorMessagge;

        $scope.$watch(function () {
            return loginServicio.message;
        }, function (value) {
            $scope.showError = value;
        });

        var token = sessionStorage.authToken;

        $scope.showToken = token;

        $scope.$watch(function () {
            return sessionStorage.authToken;
        }, function (value) {
            $scope.showToken = value;
        });

        return ctrl;
    });
})();

