
myApp
.factory("LoginFactory", function ($resource) {
    return $resource('/api/login', {}, {
        doLogin: { method: 'POST' }
    });
})
