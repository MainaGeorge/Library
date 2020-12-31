$(document).ready(function () {
    $(".borrow").click(function () {
        const bookId = $("#borrow").val();

        $.ajax({
            type: "GET",
            url: `https://localhost:44399/Books/borrow/${bookId}`,
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {
                alert("done");

            },
            error: function (data) {
                alert(data.responseText);
            }
        });
    });
});