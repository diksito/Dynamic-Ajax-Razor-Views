/// <reference path="jquery-1.10.2.min.js" />

function add() {
    var url = $('#article-list').data('request-url');
    var jqxhr = $.get(url, function (data) {
        console.log(data);
    })
    .fail(function () {
        alert("Error: cannot load the data.");
    });
}