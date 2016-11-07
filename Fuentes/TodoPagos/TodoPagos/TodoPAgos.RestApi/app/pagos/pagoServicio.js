(function () {
    'use strict';

    var obligatorioApp = angular.module('TodoPagos');

    obligatorioApp.service('pagoServicio', function ($log, $http) {
        var pagoServicio = this;

        //POST
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

        //DELETE
        pagoServicio.BorrarPago = function (id) {
            var promise = $http({
                url: '/api/pago/' + id,
                method: "DELETE",
                data: {}
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

       //GET
       pagoServicio.getPagos = function getPagos() {

            $http.get('/api/pagos')
            .success(function (result) {
                pagoServicio.getPagos = result;
            })
            .error(function (data, status) {
                $log.error(data);
            });
        }



        return pagoServicio;
    });
})();

