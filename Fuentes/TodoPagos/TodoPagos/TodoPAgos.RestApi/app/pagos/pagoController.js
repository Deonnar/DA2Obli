(function () {
    'use strict';

    var obligatorioApp = angular.module('TodoPagos');
    
    obligatorioApp.controller('Pago.Controller', function ($scope, pagoServicio) {

        var ctrl = this;

        ctrl.pago = pagoServicio;
        //obtener lista pagos
        ctrl.pago.getPagos();
       
        //agregar nuevo pago
        $scope.NuevoPago = function () {
            pagoServicio.NuevoPago($scope.importe, $scope.cliente, $scope.proveedor, $scope.forma           
            ).then(function () {
                if (nuevo.message)
                    $scope.showError = pagoServicio.message;
            });
            //   $scope.token = sessionStorage.authToken;
        };

        return ctrl;
    });
})();
