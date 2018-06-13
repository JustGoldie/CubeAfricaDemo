var CubeAfricaDemo = angular.module("CubeAfricaDemo", ['ui.router', 'ui.bootstrap', 'cgBusy']);

CubeAfricaDemo.config(['$stateProvider', '$urlRouterProvider', '$httpProvider', function ($stateProvider, $urlRouterProvider, $httpProvider) {
    var pagesPath = "Views/Pages/";

    $urlRouterProvider.otherwise("/login");

    $stateProvider
        .state('login', {
            url: '/login',
            views: {
                "mainFrame": {
                    controller: 'LoginController',
                    templateUrl: pagesPath + '/Login/LoginPage.html'
                }
            },
            ncyBreadcrumb: {
                skip: true
            }
        });

    //$httpProvider.interceptors.push('AuthenticationService');

}]);

CubeAfricaDemo.run(function ($rootScope, $state) {

});
