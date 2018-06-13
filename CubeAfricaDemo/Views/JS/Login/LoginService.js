CubeAfricaDemo.service('LoginService', ['$http', function ($http) {

    this.Login = function (loginDetails) {
        var request = $http.post('api/Account/Login', loginDetails);

        return request;
    };

    this.RegisterUser = function (userDetails) {
        var request = $http.post('api/Account/RegisterUser', userDetails);

        return request;
    };

}]);