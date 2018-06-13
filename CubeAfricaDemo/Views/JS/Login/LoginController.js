CubeAfricaDemo.controller('LoginController', ['$scope', '$rootScope', 'LoginService', '$state', function ($scope, $rootScope, LoginService, $state) {

    $scope.view = 'Login';

    $scope.loginDetails = {};
    $scope.registrationDetails = {};

    $scope.Login = function (loginForm) {
        if (loginForm.$valid) {
            $scope.loginPromise = LoginService.Login($scope.loginDetails);
            $scope.loginPromise.then(function (successObject) {

                $scope.SwitchView('LoggedIn');

            }, function (errorObject) {
                console.log(errorObject);
            });
        }
    };

    $scope.Register = function (registerForm) {
        if (registerForm.$valid) {
            $scope.registerPromise = LoginService.RegisterUser($scope.registrationDetails);
            $scope.registerPromise.then(function (successObject) {

                $scope.SwitchView('Registered');

            }, function (errorObject) {
                console.log(errorObject);
            });
        }
    };

    $scope.SwitchView = function (view) {
        $scope.view = view;
    };

}]);