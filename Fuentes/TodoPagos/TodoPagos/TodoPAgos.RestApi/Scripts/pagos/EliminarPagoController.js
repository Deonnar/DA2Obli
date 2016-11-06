(function () {
    'use-strict';

    angular.module('TodoPagos')
        .controller('EliminarPago.Controller', function ($scope, $filter, $http, $timeout) {
            $("#error").hide();
            $("#success").hide();

            $http.get("/api/pagos", {
         //       headers: { 'token': '1' }
            }).success(function (data, status, headers, config) {
                $scope.pagos = data;
            }).error(function (data, status, headers, config) {
                $("#error").show();
                $scope.msgerror = "Error";
            });

            $scope.eliminar = function (pagoId) {

                $http.delete("/api/pagos/" + pagoId, {
                  //  headers: { 'token': '1' }
                }).success(function (data, status, headers, config) {
                    $("#success").show();
                    $scope.msgerror = "Se eliminó correctamente el usuario"

                    var index = -1;
                    var pagosArray = eval($scope.pagos);
                    for (var i = 0; i < pagosArray.length; i++) {
                        if (pagosArray[i].Id === pagoId) {
                            index = i;
                            break;
                        }
                    }
                    if (index === -1) {
                        $("#error").show();
                        $scope.msgerror = "Error";
                    }
                    $scope.pagos.splice(index, 1);

                }).error(function (data, status, headers, config) {
                    $("#error").show();
                    $scope.msgerror = "Error";
                });
                $timeout(function () { $scope.msgerror = ""; $("#error").hide(); }, 5000);
                $timeout(function () { $scope.msgsuccess = ""; $("#success").hide(); }, 5000);
            }
        });
})();