(function (angular) {
    angular.module("questionnaire").directive("questionnaireForm",
        ["$window", "questionnaireSvc",
        function ($window, questionnaireSvc) {
            return {
                restrict: "E",
                replace: true,
                scope: false,
                templateUrl: "/app/Templates/questionnaireForm.html",
                link: function ($scope) {

                    $scope.questionnaire = {};

                    $scope.sendAnswers = function() {

                        alert("Sending answers");
                    }

                    questionnaireSvc.getQuestions(function(response) {

                        $scope.questionnaire = response;
                        $window.document.title = response.QuestionnaireTitle;

                    }, function(error) {

                        alert(error);
                    });

                }
            };
        }
        ]);
})(window.angular);