(function () {
    'use-strict';

    angular.module('TodoPagos')
        .controller('EliminarPago.Controller', function ($scope, $filter, $http, $timeout) {
            $("#error").hide();
            $("#success").hide();

            $http.get("/api/administradores", {
                //       headers: { 'token': '1' }
            }).success(function (data, status, headers, config) {
                $scope.administradores = data;
            }).error(function (data, status, headers, config) {
                $("#error").show();
                $scope.msgerror = "Error";
            });

            $scope.eliminar = function (administradorId) {

                $http.delete("/api/administradores/" + administradorId, {
                    //  headers: { 'token': '1' }
                }).success(function (data, status, headers, config) {
                    $("#success").show();
                    $scope.msgerror = "Se eliminó el administrador"

                    var index = -1;
                    var administradoresArray = eval($scope.administradores);
                    for (var i = 0; i < administradoresArray.length; i++) {
                        if (administradoresArray[i].Id === administradorId) {
                            index = i;
                            break;
                        }
                    }
                    if (index === -1) {
                        $("#error").show();
                        $scope.msgerror = "Error";
                    }
                    $scope.administradores.splice(index, 1);

                }).error(function (data, status, headers, config) {
                    $("#error").show();
                    $scope.msgerror = "Error";
                });
                $timeout(function () { $scope.msgerror = ""; $("#error").hide(); }, 5000);
                $timeout(function () { $scope.msgsuccess = ""; $("#success").hide(); }, 5000);
            }
        });
})();