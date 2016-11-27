(function (angular) {

    angular.module("questionnaire").factory("questionnaireSvc", ["questionnaireRestClient",
    function (questionnaireRestClient) {

        var _questions = {};

        var getQuestions = function(successFunction, errorFunction) {
            
            questionnaireRestClient.get().$promise.then(function (response) {

                successFunction(response);

            }, function (error) {

                errorFunction(error);
            });
        }

        return {
            getQuestions: getQuestions
        };
    }]);

})(window.angular);