(function () {
    'use strict';

    var obligatorioApp = angular.module('TodoPagos');

    obligatorioApp.service('pagoServicio', function ($log, $http) {
        var pagoServicio = this;

        pagoServicio.NuevoPago = function (importe, cliente, proveedor, forma) {
            var promise = $http({
                url: '/api/pago',
                method: "POST",
                data: {
                    'Importe': importe,
                    'Cliente': cliente,
                    'Proveedor': proveedor,
                    'Forma': forma
                }
            })
             .then(function (response) {
                 //sessionStorage.authToken = response.data.Email;
                 location.href = "#/index";
             },
             function (response) {
                 pagoServicio.message = response.data.Message;
             });
            return promise;
        }

        return pagoServicio;
    });
})();

