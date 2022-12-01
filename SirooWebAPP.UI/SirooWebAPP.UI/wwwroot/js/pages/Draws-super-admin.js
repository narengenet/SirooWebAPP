finishId = -1;
alldrawsPermit = -1;
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
                    if (alldrawsPermit == 1) {
                        getAllDraws();
                    } else {
                        getDraws();
                    }
                    
                }
            } else {
                alert("امکان اتمام دوره وجود ندارد.");
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
                    if (alldrawsPermit == 1) {
                        getAllDraws();
                    } else {
                        getDraws();
                    }
                }
            } else {
                alert("failed");
            }
        },
    });
}



archiveId = -1;
function archiveDraw() {
    adv = archiveId;
    if (adv == -1) {
        return;
    }
    $.ajax({
        url: '/archiveDraw/' + adv,
        type: 'GET',
        success: function (result) {
            if (result) {
                if (result == "gologin") {
                    window.location = "/login/login";
                } else {
                    alert(adv + " آرشیو شد.");
                    if (alldrawsPermit == 1) {
                        getAllDraws();
                    } else {
                        getDraws();
                    }
                }
            } else {
                alert("امکان آرشیو وجود ندارد.");
            }
        },
    });
}