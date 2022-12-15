var delId = -1;
function _deletePost() {
    adv = delId;
    if (adv == -1) {
        return;
    }
    $.ajax({
        url: '/delPost/' + adv,
        type: 'GET',
        success: function (result) {
            if (result) {
                if (result == "gologin") {
                    window.location = "/login/login";
                } else {
                    $('.post.' + adv).fadeOut(300, function () { $(this).remove(); });
                    $('#deletePostModal').modal('toggle');
                    removeAds(adv);
                    //$('.post.'+adv).fadeOut();
                    //$('.post.'+adv).remove();
                }
            } else {
                alert("failed");
            }
        },
    });

    return;

}

var pinId = -1;
function _pinPost() {
    adv = pinId;
    if (adv == -1) {
        return;
    }
    $.ajax({
        url: '/pinPost/' + adv,
        type: 'GET',
        success: function (result) {
            if (result) {
                if (result == "gologin") {
                    window.location = "/login/login";
                } else {
                    if (result == "1") {
                        alert('وضعیت سنجاق پست تغییر داده شد.');
                    } else {
                        alert("خطا");
                    }
                }
            } else {
                alert("failed");
            }
        },
    });

    return;

}