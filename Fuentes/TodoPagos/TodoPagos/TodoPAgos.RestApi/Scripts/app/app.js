(function () {
    'use-strict';

    var app = angular.module('TodoPagos', ['ngRoute', 'ngMessages']);

    app.config(function ($routeProvider, $locationProvider) {
        $routeProvider
        
        //admin
        .when('/NuevoAdmin', {
            templateUrl: 'app/admins/adminsMenu.html',
            controller: 'Admins.Controller'
        })
        
        .when('/ModifcarAdmin', {
            templateUrl: 'app/admins/adminsMenu.html',
            controller: 'Admins.Controller'
        })
        
        .when('/BajaAdmin', {
            templateUrl: 'app/admins/adminsMenu.html',
            controller: 'Admins.Controller'
        })
    
        //pago
        .when('/NuevoPago', {
            templateUrl: 'app/admins/adminsMenu.html',
            controller: 'Admins.Controller'
        })
        
        .when('/ModifcarPago', {
            templateUrl: 'app/admins/adminsMenu.html',
            controller: 'Admins.Controller'
        })
        
        .when('/BajaPago', {
            templateUrl: 'app/admins/adminsMenu.html',
            controller: 'Admins.Controller'
        })
        //Puntos
        .when('/Puntos', {
            templateUrl: 'app/admins/adminsMenu.html',
            controller: 'Admins.Controller'
        })
        //Proveedores
        .when('/Puntos', {
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

