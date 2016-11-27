(function (angular) {

    var app = angular.module("questionnaire",
        ["ngRoute", "ngResource"]);

    app.config(["$locationProvider", function ($locationProvider) {
        $locationProvider.html5Mode(true);
    }]);

})(window.angular);