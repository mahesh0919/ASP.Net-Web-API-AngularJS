
app.factory('PersonsService', function ($http) {
    var fac = {};
    fac.GetAllRecords = function () {
        return $http.get('/api/Person/');
    };
    fac.message1 = "I am from service";

    return fac;
});