(function () {
    'use strict';
      
    angular.module('TodoPagos')
       .controller('Usuarios.Controller', function ($scope) {
           var ctrl = this;

           $scope.usuarios = [
               { nombre: "Alejandro", apellido: "Tocar" },
               { nombre: "Gabriel", apellido: "Piffaretti" }
           ];
       });

})();