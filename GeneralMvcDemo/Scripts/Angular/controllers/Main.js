/* File Created: October 1, 2014 */
//var EmployeeApp = angular.module('EmployeeApp', []); 
//EmployeeApp.run(function ($templateCache) {
//    //$templateCache.put("zippy.html", '<div><p>Hello</p></div>')
//    //$templateCache.put("editTmp", '<div><p>Hello</p></div>')
//})
EmployeeApp.controller('EmployeeCtrl', function ($scope, $templateCache) {
  
    $scope.editId = "";
    $scope.editFullName = "";
    $scope.editAddress = "";
    $scope.editEmail = "";
    $scope.ImportData = function () {
        $.each($scope.employees, function (index, value) {
            if ($("#cb" + value.Id).is(":checked")) {
                setTimeout(function () { $("#" + value.Id).css("background-color", "yellow"); }, index * 2000);
            }
        });

    }
    $scope.loadPrameter = function () {
        $scope.employees = [{ "Id": "1", "FullName": "Ngo tri minh quan", "Address": "Nghe an", "Email": "ngominhquan@gmail.com" }, { "Id": "2", "FullName": "Ngo thi phuong le", "Address": "Ha Noi", "Email": "ngothiphuongle@gmail.com" }, { "Id": "3", "FullName": "Ngo tri le minh", "Address": "Nghe an", "Email": "ngotrileminh@gmail.com" }, { "Id": "4", "FullName": "Le thi thu ha", "Address": "thanh pho vinh", "Email": "lethuha@gmail.com"}];
    }
    
    $scope.Edit = function (Id) {
        $.each($scope.employees, function (index, employee) {
            if (employee.Id == Id)
            {          
                document.getElementById("divMain").innerHTML = "";
                //$("#editTmp").tmpl(employee).appendTo("#divMain");
                document.getElementById("divMain").innerHTML = $templateCache.get("toggle-button.html");
            };
        });
        //console.log($templateCache.get("zippy.html"));      
    }
    $scope.Update = function () {
        alert("ffsf");
    }
    $scope.flags = {
        flag: true
    };
    $scope.toggleFlag = function () {
        $scope.flags.flag = !$scope.flags.flag;
    }
});