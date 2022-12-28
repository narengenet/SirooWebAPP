function _sendReplyContact(messageId) {
    var theReply = $('#replyBody').val();
    if (theReply.length < 10) {
        alert('حداقل طول پیام 10 کاراکتر است. خطا.');
        return;
    }

    waiting();

    var data = { messageBody: theReply, messageID: messageId };

    $.ajax({
        type: "POST",
        url: "/sendReplyContact",
        data: JSON.stringify(data),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            waiting();
            if (data == "1") {
                $('.replySendArea').fadeOut(300, function () { $(this).remove(); });
                alert("پاسخ شما ارسال شد.");
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