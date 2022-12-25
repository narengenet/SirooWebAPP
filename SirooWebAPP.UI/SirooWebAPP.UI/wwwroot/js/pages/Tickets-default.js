


function switchToNewContact() {
    $('#allContacts').hide();

    $('#NewContact').removeClass('isHide');

}


function _sendContact() {
    var note = $('#contactBody').val();
    if (note.length<10) {
        alert('حداقل طول پیام 10 کاراکتر است. خطا.');
        return;
    }

    waiting();

    var data = { messageBody: note };

    $.ajax({
        type: "POST",
        url: "/sendContact",
        data: JSON.stringify(data),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            waiting();
            if (data == "1") {
                $('#NewContact').fadeOut(300, function () { $(this).remove(); });
                alert("پیام شما ارسال شد.");
            } else {
                alert("خطا");
            }
        },
        error: function (errMsg) {
            waiting();
            alert(errMsg);
        }
    });

    return;
}