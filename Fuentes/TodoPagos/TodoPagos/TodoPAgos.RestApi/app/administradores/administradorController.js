(function () {
    'use strict';

    var obligatorioApp = angular.module('TodoPagos');
    
    obligatorioApp.controller('Administrador.Controller', function ($scope, administradorServicio) {

        var ctrl = this;
        ctrl.administrador = administradorServicio;

        $scope.Administrador = function () {
            administradorServicio.nuevoAdmin($scope.nombre, $scope.apellido, $scope.contrasenia, $scope.direccion, $scope.nombreusuario           
            ).then(function () {
                if (nuevo.message)
                    $scope.showError = administradorServicio.message;
            });
            //   $scope.token = sessionStorage.authToken;
        };

        return ctrl;
    });
})();





/*(function () {
    'use-strict';

    angular.module('TodoPagos')
        .controller('NuevoAdministrador.Controller', function ($scope, $http, $timeout) {
            $("#error").hide();
            $("#success").hide();

            $http.get("/api/administradores", {
             //   headers: { 'token': '1' }
            }).success(function (data, status, headers, config) {
                $scope.usuarios = data;
            }).error(function (data, status, headers, config) {
                $("#error").show();
                $scope.msgerror = "Error";
                $timeout(function () { $scope.msgerror = ""; $("alert alert-danger").hide(); }, 3000);
            });

            $scope.submit = function () {
                var data = {
                    "Nombre": $scope.nombre,
                    "Apellido": $scope.apellido,
                    "Contrasenia": $scope.contrasenia,
                    "Clave": $scope.contrasenia,
                    "Direccion": $scope.direccion,
                    "NombreUsuario": $scope.nombreusuario
                };

                $http.post('api/administradores', data, {
               //     headers: { 'token': '1' }
                })
                .success(function (data, status, headers, config) {
                    $scope.msgsuccess = "Administrador agregado!";
                    $("#success").show();
                    var form = document.getElementById("usuarioForm"); // welche Form ist richtig 
                    form.reset();
                })
                .error(function (data, status, header, config) {
                    $("#error").show();
                    $scope.msgerror = data.Message;
                });
                $timeout(function () { $scope.msgerror = ""; $("#error").hide(); }, 5000);
                $timeout(function () { $scope.msgsuccess = ""; $("#success").hide(); }, 5000);
            }

        });
})();*/