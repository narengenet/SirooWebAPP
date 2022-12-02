function ResetPostCash() {

    $('.waitingPlease').css('display', 'flex');

    $.ajax({
        url: '/resetPostCache',
        type: 'GET',
        success: function (result) {
            $('.waitingPlease').css('display', 'none');
            if (result == "-1") {
                alert('خطا');
            } else {
                alert('کش پُست ها ریست شد.');

            }
        },
    });
}

function ChangeConstant(theID) {

    $('.waitingPlease').css('display', 'flex');

    $.ajax({
        url: '/changeConstant/' + $('#' + theID).val()+'/'+theID,
        type: 'GET',
        success: function (result) {
            $('.waitingPlease').css('display', 'none');
            if (result == "-1") {
                alert('خطا');
            } else {
                alert('تغییر اعمال شد.');

            }
        },
    });
}