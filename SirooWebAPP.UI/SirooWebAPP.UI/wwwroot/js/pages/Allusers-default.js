$(document).ready(function () {
    debugger;
    var allusernames = $('.username');
    var allids = $('.ids');
    var allInviters = $('.inviter');
    for (var i = 0; i < allids.length; i++) {
        inviterId = $(allInviters[i]).text();
        inviterUsername = findUsernameById(inviterId);
        $(allInviters[i]).text(inviterUsername);
    }

});

function findUsernameById(theId) {
    var result;
    var foundId = -1;
    var allids = $('.ids');
    for (i = 0; i < allids.length; i++) {
        if ($(allids[i]).text() == theId) {
            foundId = i;
            break;
        }
    }
    var allusernames = $('.username');
    if (foundId != -1) {

        return $(allusernames[foundId]).text();
    } else {
        return '----';
    }
}

function copyToClipboard(theObj) {

    theText=$(theObj).text();
    navigator.clipboard
        .writeText(theText)
        .then(() => {
            alert("کپی شد.");
        })
        .catch(() => {
            alert("مشکلی پیش آمده.");
        });


}