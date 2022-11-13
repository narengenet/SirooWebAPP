finishId = -1;
function finishDraw() {
    adv = finishId;
    if (adv == -1) {
        return;
    }
    $.ajax({
        url: '/finishDraw/' + adv,
        type: 'GET',
        success: function (result) {
            if (result) {
                if (result == "gologin") {
                    window.location = "/login/login";
                } else {
                    alert("دوره با موفقیت به پایان رسید و جوایز بین برندگان تقسیم شد.");
                    getDraws();
                }
            } else {
                alert("failed");
                $('#finishdraw_' + adv).css('opacity', '1');
            }
        },
    });
}

deactiveId = -1;
function deactiveDraw() {
    adv = deactiveId;
    if (adv == -1) {
        return;
    }
    $.ajax({
        url: '/deactiveDraw/' + adv,
        type: 'GET',
        success: function (result) {
            if (result) {
                if (result == "gologin") {
                    window.location = "/login/login";
                } else {
                    alert(adv + " is liked");
                    getDraws();
                }
            } else {
                alert("failed");
            }
        },
    });
}