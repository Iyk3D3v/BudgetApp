var input = {};
var response = [];
var spendings = [];
var table = "";
var email = "harry@gmail.com";//need to get logged in user email

$(function () {
    alert("dbdkn");
    getAllSpending();
});
//$(document).ready(function () {
//    getAllSpending();
//    createSpending();
//});

function createSpending()
{
    //how to get ID from c# to js
    input.UserId = 2005;
    input.Amount = $('#amount').val();
    input.Description = $('#description').val();
    //need to also get dateTime

    $.ajax({
        url: "http://localhost:30571/api/Spending/Create",
        type: "POST",
        contentType: "application/json",
        data: JSON.stringify(input),
        success: function (data) {
            console.log(data);
            response = data;
        }
    })
    $('#modall').modal().hide();
}

//to retrieve data from spending table and put in data table

function getAllSpending()
{
    $.ajax({
        url: "http://localhost:30571/api/Spending/View?id=" + 2005,
        type: "GET",
        contentType: "application/json",
        success:function(data)
        {
            console.log(data);
            spendings = data;
            renderData();
        }
    })
}

function renderData()
{
    var display = [];
    if(table != "")
    {
        table.destroy();
    }
    $.each(spendings, function (index, row) {
        display.push([
            index + 1,
            row.Amount,
            row.Description
        ])
    })

    table = $('#spendingTable').DataTable();

    //table = $('#spendingTable').DataTable({
    //    data: display,
    //    "responsive": true,
    //    "paging": true,
    //    "lengthChange": true,
    //    "searching": true,
    //    "ordering": true,
    //    "info": true,
    //    "autoWidth": true
    //});
}