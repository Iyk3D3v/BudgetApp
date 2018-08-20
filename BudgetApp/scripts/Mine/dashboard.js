var budget = [];

$(document).ready(function () {
    alert("wensiosjm");
    getBudget();
});

function getBudget()
{
    alert("jfopkekewa");
    $.ajax({
        url: "http://localhost:30571/api/Budget/GetBudget?id=" + 2005,
        type: "GET",
        contentType: "application/json",
        success: function(data)
        {
            console.log(data);
            budget = data;
        }
    })
}