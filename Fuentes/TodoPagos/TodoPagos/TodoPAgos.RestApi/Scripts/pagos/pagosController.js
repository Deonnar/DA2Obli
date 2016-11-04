(function() {
    'use strict';

    var tresanaApp = angular.module('Tresana');

    tresanaApp.controller('Pagos.Controller', function() {
        var ctrl = this;

        ctrl.pagos = [
            {
                Id: 3,
                Name: "Crear Proyecto Angular"
             
            },
            {
                Id: 4,
                Name: "Enseñar Angular"
               
            }
        ];

    });
})();