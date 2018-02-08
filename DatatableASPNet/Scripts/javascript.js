
function datatable() {

    $(document).ready(function () {
        $("#employeeTable").DataTable(
            {
                "ajax": {
                    "url": "/Employee/GetEmployee",
                    "type": "GET",
                    "datatype": "json"
                }, "columns": [

                    { "data": "FirstName" },
                    { "data": "LastName" },
                    { "data": "Address" },
                    { "data": "Position" }
                ]
            }
        );
    });
}

$(function() {
    datatable();
});