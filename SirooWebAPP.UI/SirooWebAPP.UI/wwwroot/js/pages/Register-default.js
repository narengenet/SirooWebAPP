



$('#btnRegister').on('click', function () {
    //$('#btnRegister').attr('disabled','true');
    $('form').removeData("validator").removeData("unobtrusiveValidation");
    $.validator.unobtrusive.parse($('form'));
    if ($('form').valid()) {
        $('#btnRegister').attr('disabled', 'true');
        $('#registerForm').attr("action", $('#btnRegister').attr('formaction'));
        $('#registerForm').submit();
    }

});
//Allow users to enter numbers only
$(".numericOnly").bind('keydown', function (e) {
    if (e.keyCode == '9' || e.keyCode == '16') {
        return;
    }
    var code;
    if (e.keyCode) code = e.keyCode;
    else if (e.which) code = e.which;
    if (e.which == 46)
        return false;
    if (code == 8 || code == 46)
        return true;
    if (code < 48 || code > 57)
        return false;
});

//Disable paste
$(".numericOnly").bind("paste", function (e) {
    e.preventDefault();
});

$(".numericOnly").bind('mouseenter', function (e) {
    var val = $(this).val();
    if (val != '0') {
        val = val.replace(/[^0-9]+/g, "")
        $(this).val(val);
    }
});
//Allow users to enter a-z only
$(".latinNOnly").bind('keydown', function (e) {
    if (e.keyCode == 8) {
        return;
    }
    var val = e.key;
    var letters = /^[0-9a-z]+$/;
    if (val.match(letters)) {
        return;
    }
    else {
        return false;
    }
    //if (e.keyCode == '9' || e.keyCode == '16') {
    //    return;
    //}
    //var code;
    //if (e.keyCode) code = e.keyCode;
    //else if (e.which) code = e.which;
    //if (e.which == 46)
    //    return false;
    //if (code == 8 || code == 46)
    //    return true;
    //if (code < 97 || code > 122)
    //    return false;
});

//Disable paste
$(".latinNOnly").bind("paste", function (e) {
    e.preventDefault();
});

        //$(".latinNOnly").bind('mouseenter', function (e) {
        //    var val = $(this)[0].value;
        //    if (val != '0') {
        //        val = val.replace(/^[0-9a-z]+$/, "")
        //        $(this).val(val);
        //    }
        //});