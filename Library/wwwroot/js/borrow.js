var dataTable;


$(document).ready(function () {
    loadDataTable();
});


function loadDataTable() {
    dataTable = $("#table").DataTable({
        "processing": true,
        "serverSide": true,
        "filter": true,
        "orderMulti": false,
        "ajax": {
            "url": "/api/Book",
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            { "data": "title", "name": "title", "autoWidth": true },
            { "data": "author.FirstName", "name": "author", autoWidth: true }
        ],
        "language": {
            "emptyTable": "No data found."
        },
        "width": "100%"
    });
}

