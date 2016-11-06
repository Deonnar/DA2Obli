(function () {
    'use strict';

    var obligatorioApp = angular.module('TodoPagos');

    obligatorioApp.controller('Login.Controller', function ($scope, loginService) {

        var ctrl = this;
        ctrl.service = loginService;

        $scope.Login = function () {
            loginService.login($scope.loginEmail, $scope.loginPassword).then(function () {
                if (loginService.message)
                    $scope.showError = loginService.message;
            });
            $scope.token = sessionStorage.authToken;
        };

        $scope.Logout = function () {
            loginService.logout();
        };

        var errorMessagge = loginService.message;

        $scope.showError = errorMessagge;

        $scope.$watch(function () {
            return loginService.message;
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

