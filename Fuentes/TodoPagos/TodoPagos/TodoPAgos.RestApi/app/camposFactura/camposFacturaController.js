(function () {
    'use strict';

    var obligatorioApp = angular.module('TodoPagos');

    obligatorioApp.controller('CamposFactura.Controller', function ($scope, $routeParams, camposFacturaServicio) {
        var ctrl = this;
        ctrl.servicio = camposFacturaServicio;
       
        ctrl.servicio.getCamposFacturas();       

        ctrl.imprimirFecha = function (dateString) {
            var date = new Date(dateString)
            return date.getDate() + "-" + (date.getMonth() + 1) + "-" + date.getFullYear();
        }
        
        return ctrl;
    });
})();