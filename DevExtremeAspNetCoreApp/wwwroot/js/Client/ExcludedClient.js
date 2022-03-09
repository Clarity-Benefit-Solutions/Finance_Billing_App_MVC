$("#idAddClient").click(function () {
    let clientId = $("#idExcludedClient").val()
    var Url = `/Client/AddExcludedClient/` + clientId
    $.ajax({
        type: "GET",
        url: Url,
        success: function (result) {
            if (result != null) {
                alert(result.message)
                location.reload();
            }
        }
    });
});