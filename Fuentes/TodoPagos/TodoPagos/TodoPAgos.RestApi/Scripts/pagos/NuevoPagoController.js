﻿(function () {
    'use-strict';

    angular.module('Tresana')
        .controller('NuevoPago.Controller', function ($scope, $http, $timeout) {
            $("#error").hide();
            $("#success").hide();

            $http.get("/api/pagos", {
               // headers: { 'token': '1' }
            }).success(function (data, status, headers, config) {
                $scope.usuarios = data;
            }).error(function (data, status, headers, config) {
                $("#error").show();
                $scope.msgerror = "Error! Reintente más tarde";
                $timeout(function () { $scope.msgerror = ""; $("alert alert-danger").hide(); }, 3000);
            });

            $scope.submit = function () {
                var data = {
                    "Nombre": $scope.
                    "Apellido": $scope.apellido,
                    "Contrasenia": $scope.contrasenia,
                    "Clave": $scope.clave,
                    "Tipo": $scope.tipo
                };

                $http.post('api/usuarios', data, {
                    headers: { 'token': '1' }
                })
                .success(function (data, status, headers, config) {
                    $scope.msgsuccess = "Usuario agregado exitosamente!!!";
                    $("#success").show();
                    var form = document.getElementById("usuarioForm");
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
})();