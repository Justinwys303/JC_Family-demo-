$("form").submit(function () {
    var isValid = $("form").valid();
    if (isValid) {
        $(".loader-container").show();
    };
    $(".validation-container").hide();
});