(function () {
    'use strict';

    var obligatorioApp = angular.module('TodoPagos');

    obligatorioApp.service('camposFacturaServicio', function ($log, $http) {
        var service = this;
        //var authToken = sessionStorage.authToken;

        service.getCamposFacturas = function getCamposFacturas() {

            $http.get('/api/camposFacturas')
            .success(function (result) {
                service.camposFactura = result;
            })
            .error(function (data, status) {
                $log.error(data);
            });
        }

        return service;
    });
})();