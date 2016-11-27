(function (angular) {

    angular.module("questionnaire").factory("questionnaireRestClient", ["$resource",
    function ($resource) {

        return $resource('http://localhost:50014/api/questions');
    }]);

})(window.angular);