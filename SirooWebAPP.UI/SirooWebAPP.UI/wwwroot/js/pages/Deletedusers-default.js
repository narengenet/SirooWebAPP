﻿selectedUserToUndelete = '-1';

function undeleteUser() {
    if (selectedUserToUndelete == "-1") {
        return;
    }

    $('.waitingPlease').css('display', 'flex');

    $.ajax({
        url: '/undeleteUser/' + selectedUserToUndelete,
        type: 'GET',
        success: function (result) {
            $('.waitingPlease').css('display', 'none');
            if (result == "-1") {
                alert('خطا');
            } else {
                $('tr#' + selectedUserToUndelete).hide();

                alert('کاربر مورد نظر فعال شد.');

            }
        },
    });
}

selectedUserTodelete = '-1';

function deleteUser() {
    if (selectedUserTodelete == "-1") {
        return;
    }

    $('.waitingPlease').css('display', 'flex');

    $.ajax({
        url: '/deleteUserForever/' + selectedUserTodelete,
        type: 'GET',
        success: function (result) {
            $('.waitingPlease').css('display', 'none');
            if (result == "-1") {
                alert('خطا');
            } else {
                $('tr#' + selectedUserTodelete).hide();

                alert('کاربر مورد نظر برای همیشه حذف شد.');

            }
        },
    });
}