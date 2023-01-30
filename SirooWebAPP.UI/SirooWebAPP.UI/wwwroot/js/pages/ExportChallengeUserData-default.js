function ExportChallengeData() {
    $('.waitingPlease').css('display', 'flex');

    $.ajax({
        url: '/exportChallengeUserData/',
        type: 'GET',
        success: function (result) {
            $('.waitingPlease').css('display', 'none');
            if (result == "-1") {
                alert('خطا');
            } else {
                alert('اطلاعات کاربران چالش تولید شدند.');
                window.location = '/uploads/challenge.csv';

            }
        },
    });
}
function ExportNewChallengeData() {
    $('.waitingPlease').css('display', 'flex');

    $.ajax({
        url: '/exportnewChallengeUserData/',
        type: 'GET',
        success: function (result) {
            $('.waitingPlease').css('display', 'none');
            if (result == "-1") {
                alert('خطا');
            } else {
                if (result == "-2") {
                    alert('رکورد جدیدی موجود نیست.')
                } else {
                    alert('اطلاعات کاربران چالش تولید شدند.');
                    window.location = '/uploads/challenge.csv';
                }


            }
        },
    });
}