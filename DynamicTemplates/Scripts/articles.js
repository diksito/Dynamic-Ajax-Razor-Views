/// <reference path="jquery-1.10.2.min.js" />

function add() {
    var url = $('#article-list').data('request-url');
    var title = $("#title").val();
    var description = $("#description").val();
    var jqxhr = $.get(url, { title: title, description: description }, function (data) {
        $('#article-list li:eq(0)').before("<li>" + data + "</li>");
    })
    .fail(function () {
        alert("Error: cannot load the data.");
    });
}