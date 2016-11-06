(function () {
    'use-strict';

    angular.module('TodoPagos')
        .controller('Pago.Controller', function ($scope, $http, $timeout) {
            $("#error").hide();
            $("#success").hide();

            $http.get("/api/pagos", {
               // headers: { 'token': '1' }
            }).success(function (data, status, headers, config) {
                $scope.pagos = data;
            }).error(function (data, status, headers, config) {
                $("#error").show();
                $scope.msgerror = "Error! Reintente más tarde";
                $timeout(function () { $scope.msgerror = ""; $("alert alert-danger").hide(); }, 2000);
            });

            $scope.submit = function () {
                var data = {
                    "Importe": $scope.importe,
                    "Cliente": $scope.cliente,
                    "Proveedor": $scope.proveedor,
                    "Forma": $scope.forma
                };

                $http.post('api/pagos', data, {
               //     headers: { 'token': '1' }
                })
                .success(function (data, status, headers, config) {
                    $scope.msgsuccess = "Pago agregado exitosamente!!!";
                    $("#success").show();
                    var form = document.getElementById("pagosForm");
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