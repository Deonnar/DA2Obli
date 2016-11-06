(function () {
    'use-strict';

    var app = angular.module('TodoPagos', ['ngRoute', 'ngMessages']);

    app.config(function ($routeProvider, $locationProvider) {
        $routeProvider

        //menu principal
        .when('/index', {
            templateUrl: 'index.html',
           // controller: 'Administrador.Controller'
        })

        //admin
        .when('/NuevoAdmin', {
            templateUrl: 'app/administradores/NuevoAdministrador.html',
            controller: 'Administrador.Controller'
        })
        
        .when('/ModifcarAdmin', {
            templateUrl: 'app/administradores/ModificarAdministrador.html',
            controller: 'Administrador.Controller'
        })
        
        .when('/BajaAdmin', {
            templateUrl: 'app/administradores/EliminarAdministrador.html',
            controller: 'Administrador.Controller'
        })
    
        //pago
        .when('/NuevoPago', {
            templateUrl: 'app/pagos/ad.html',
            controller: 'Pagos.Controller'
        })
        
        .when('/ModifcarPago', {
            templateUrl: 'app/pagos/adminMenu.html',
            controller: 'Pagos.Controller'
        })
        
        .when('/BajaPago', {
            templateUrl: 'app/pagos/adminsMenu.html',
            controller: 'Pagos.Controller'
        })

        //puntos
        .when('/Puntos', {
            templateUrl: 'app/admins/adminsMenu.html',
            controller: 'Admins.Controller'
        })

        //CamposFactura
        .when('/camposfactura', {
            templateUrl: 'app/admins/adminsMenu.html',
            controller: 'Admins.Controller'
        })
        //login
        .when('/login', {
            templateUrl: 'app/login/login.html',
            controller: 'Login.Controller'
        })
        .otherwise({
            redirectTo: '/login'
        });
    });
})();

