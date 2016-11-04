var myApp = angular.module('App', ['ngResource', 'ngRoute', 'ui.bootstrap']);

myApp.config(function ($routeProvider) {
    $routeProvider
    
        .when('/login', {
            templateUrl: '/Pages/logidn.html',
            controller: 'LoginCtrl',
        })
        .otherwise({
        redirectTo: '/login'
    });
});

