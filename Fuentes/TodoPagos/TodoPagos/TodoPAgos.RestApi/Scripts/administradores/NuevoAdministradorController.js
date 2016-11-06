(function () {
    'use-strict';

    angular.module('Tresana')
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
})();