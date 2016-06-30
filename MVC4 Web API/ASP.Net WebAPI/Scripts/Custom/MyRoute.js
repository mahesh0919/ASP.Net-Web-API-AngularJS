//Declaring route configuration

app.config(function ($stateProvider) // $locationProvider to remove # in url
         {
            //$urlMatcherFactoryProvider.caseInsensitive(true); // Case insencitive URL's

            $stateProvider  // check routing patterns in href to redirect views
                    .state("home", {
                        url: "/home",
                        controller: "PersonController",
                        controllerAs: "stdParentCtrl",
                        templateUrl: "Home/GetPersons"
                    })
                    .state("getperson", {
                        url: "/getperson",
                        controller: "GetController",
                        controllerAs: "getParentCtrl",
                        templateUrl: "Home/GetPersonDetails"
                    })
                    .state("updateperson", {
                        url: "/updateperson",
                        controller: "UpdatePersonController",
                        controllerAs: "updtParentCtrl",
                        templateUrl: "Home/UpdatePersonController"
                    })
                    .state("addperson", {
                        url: "/addperson",
                        controller: "AddPersonController",
                        controllerAs: "addParentCtrl",
                        templateUrl: "Home/AddPersonController"
                    })
                    .state("deleteperson", {
                        url: "/deleteperson",
                        controller: "DeletePersonController",
                        controllerAs: "deleteParentCtrl",
                        templateUrl: "Home/DeletePersonController"
                    })
         })








