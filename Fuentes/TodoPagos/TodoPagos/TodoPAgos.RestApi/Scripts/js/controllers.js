myApp

.controller('MainCtrl', function ($scope, $route, $routeParams, $location) {
    $scope.$route = $route;
    $scope.$location = $location;
    $scope.$routeParams = $routeParams;
    $scope.usuario = null;
})
.controller('LoginCtrl', function ($scope, $routeParams, $location, LoginFactory) {
    $scope.nombreUsuario = "";
    $scope.contrasenia = "";
    $scope.falloLogin = false;
    alert("Se ha ");

    $scope.identificarse = function () {
        $scope.$parent.usuario = LoginFactory.doLogin({
            Email: $scope.nombreUsuario,
            Clave: $scope.contrasenia
        }, function () {
            alert("Se ha identificado correctamente " + $scope.$parent.usuario.Nombre);
            $location.path("/menu");
        }, function () {
            $scope.falloLogin = true;
        });
    };

})
