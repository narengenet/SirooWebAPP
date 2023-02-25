var theTemplate = "<div class='d-flex flex-row justify-content-center mb-1 myMessage'><div class='d-flex flex-row justify-content-end mb-1 col-12 messageHolder' sender = '@@chatMessage.FromUser' ><div class='col-9 text-warning text-center theMessage' id='themessage-@@chatMessage.Id'>@@chatMessage.theMessageBody</div><div class='col-3 datetime chat_date' id='themessagedatetime-@@chatMessage.Id'>@@chatMessage.Created</div></div ></div >";
function _sendMessageChat() {
    $('#SendChat').prop("disabled", true);
    var _receiverUsername = $('#UserName').val();
    var _theMessage = $('#chatMessage').val();
    if (_theMessage=="") {
        return;
    }
    $('#chatMessage').prop("disabled", true);
    var _receiverId = "";
    if (qs["touser"] == "") {
        _receiverId = _receiverUsername;
    } else {
        _receiverId = qs["touser"];
    }

    var data = { receiverUserid: _receiverId, receiverUsername: _receiverUsername, theMessageBody: _theMessage };



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
            if (data!="-1" && data!="-2") {
                console.log('sent');
                $('#SendChat').prop("disabled", false);
                $('#chatMessage').prop("disabled", false);
                $('#chatMessage').val('');
                $('.conversationPanel').append(theTemplate.replace('@@chatMessage.theMessageBody', _theMessage).replace('@@chatMessage.Created', new Date().toLocaleString("fa-IR")).replace('@@chatMessage.Id', data));
                $('.conversationPanel').scrollTop($('.conversationPanel')[0].scrollHeight);
                audioElement.play();
                return;
            }
            if (data == "-1") {
                alert('نام کاربری دریافت کننده موجود نیست!');
                return;
            }
            if (data == "-2") {
                alert('امکان ارسال پیام به این کاربر وچود ندارد.');
                return;
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

function _goNewChat() {
    if ($('#UserName').val().length > 4) {
        window.location = "/Clients/ChatHistory?touser=" + $('#UserName').val();
    }
}






function _blockUser() {
    //$('#SendChat').prop("disabled", true);
    var _receiverUsername = $('#UserName').val();
    //var _theMessage = $('#chatMessage').val();
    //if (_theMessage == "") {
    //    return;
    //}
    //$('#chatMessage').prop("disabled", true);
    var _receiverId = "";
    if (qs["touser"] == "") {
        _receiverId = _receiverUsername;
    } else {
        _receiverId = qs["touser"];
    }

    var data = { receiverUserid: _receiverId, receiverUsername: _receiverUsername, theMessageBody: "" };



    $.ajax({
        type: "POST",
        url: "/blockChatUser",
        data: JSON.stringify(data),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {

            if (data == "-1") {
                alert('کاربر بلاک شد. امکان ارسال و دریافت چت بین شما دیگر امکانپذیر نیست.');
                window.location = "/Clients/ChatHistory?touser=" + _receiverId;
                return;
            }
            if (data == "-2") {
                alert('کاربر از حالت بلاک خارج شد. مجددا امکان چت بین شما و کاربر برقرار شد.');
                window.location = "/Clients/ChatHistory?touser=" + _receiverId;
                return;
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