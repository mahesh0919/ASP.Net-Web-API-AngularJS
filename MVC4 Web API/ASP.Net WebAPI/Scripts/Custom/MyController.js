app.controller("PersonController", function ($scope, $http, PersonsService) {
    $scope.heading = "Get List of all Persons";
    $scope.personsData = null;
    $scope.message = PersonsService.message1;

    //Get all persons information
    //$http.get('/api/Person/').success(function (data) {
    //    $scope.personsData2 = data;
    //    $scope.loading = false;
    //})
    //.error(function () {
    //    alert("An Error has occured while loading posts!");
    //    $scope.loading = false;
    //});

    //// Fetching all records from service
    PersonsService.GetAllRecords().then(function (d) {
        $scope.personsData = d.data; // Success
    }, function () {
        alert('Error Occured !!!'); // Failed
    });

})
.controller("GetController", function ($scope) {
    $scope.heading = "Get Person details";
})
.controller("UpdatePersonController", function ($scope) {
    $scope.heading = "Update Person details";
})
.controller("AddPersonController", function ($scope) {
    $scope.heading = "Add person details";
})
.controller("DeletePersonController", function ($scope) {
    $scope.heading = "Delete person details";
})