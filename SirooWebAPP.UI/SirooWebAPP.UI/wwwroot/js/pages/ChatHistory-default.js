var theTemplate = "<div class='d-flex flex-row justify-content-center mb-1 myMessage'><div class='d-flex flex-row justify-content-end mb-1 col-12 messageHolder' sender = '@@chatMessage.FromUser' ><div class='col-9 text-warning text-center theMessage' id='themessage-@@chatMessage.Id'>@@chatMessage.theMessageBody</div><div class='col-3 datetime' id='themessagedatetime-@@chatMessage.Id'>@@chatMessage.Created</div></div ></div >";
function _sendMessageChat() {
    $('#SendChat').prop("disabled", true);
    var _receiverUsername = $('#UserName').val();
    var _theMessage = $('#chatMessage').val();
    if (_theMessage=="") {
        return;
    }
    $('#chatMessage').prop("disabled", true);

    var data = {receiverUserid:qs['touser'], receiverUsername: _receiverUsername, theMessageBody: _theMessage };

    $.ajax({
        type: "POST",
        url: "/sendMessageChat",
        data: JSON.stringify(data),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            //if (data) {
            //    $('.post.' + adv).fadeOut(300, function () { $(this).remove(); });
            //}
            if (data!="-1" || data!="-2") {
                console.log('sent');
                $('#SendChat').prop("disabled", false);
                $('#chatMessage').prop("disabled", false);
                $('#chatMessage').val('');
                $('.conversationPanel').append(theTemplate.replace('@@chatMessage.theMessageBody', _theMessage).replace('@@chatMessage.Created', new Date().toLocaleString("fa-IR")).replace('@@chatMessage.Id',data));
            }

        },
        error: function (errMsg) {
            alert(errMsg);
            $('#SendChat').prop("disabled", false);
            $('#chatMessage').prop("disabled", false);
        }
    });

    return;
}