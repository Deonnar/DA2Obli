(function () {
    'use strict';

    var obligatorioApp = angular.module('TodoPagos');

    obligatorioApp.service('administradorServicio', function ($log, $http) {
        var administradorServicio = this;

        //NUEVO ADMIN
        administradorServicio.nuevoAdmin = function (nombre, apellido, contrasenia, direccion, nombreusuario) {
            var promise = $http({
                url: '/api/administrador',
                method: "POST",
                data: { 'Nombre': nombre, 
                        'Apellido': apellido,
                        'Direccion': direccion,
                        'Contrasenia': contrasenia,
                        'NombreUsuario': nombreusuario }     

            })
             .then(function (response) {
                 //sessionStorage.authToken = response.data.Email;
                 location.href = "#/menu";
             },
             function (response) {
                 administradorServicio.message = response.data.Message;
             });
            return promise;
        }


        administradorServicio.logout = function () {
            sessionStorage.typeOfUser = 0;
            $http({
                url: '/api/auth?email=' + sessionStorage.authToken,
                method: 'DELETE'
            })
            sessionStorage.authToken = undefined;
            location.href = "#/administrador"
        }

        //DELETE
        administradorServicio.BorrarAdmin = function (id) {
            var promise = $http({
                url: '/api/administrador/' + id,
                method: "DELETE",
                data: {}
            })
             .then(function (response) { 
                 location.href = "#/index";
             },
             function (response) {
                 pagoServicio.message = response.data.Message;
             });
            return promise;
        }


        return administradorServicio;
    });
})();

