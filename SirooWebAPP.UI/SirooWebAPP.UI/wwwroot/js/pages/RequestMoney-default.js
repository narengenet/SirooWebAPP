$(document).ready(function () {


});



function copyToClipboard(theObj) {

    theText = $(theObj).text();
    navigator.clipboard
        .writeText(theText)
        .then(() => {
            alert("کپی شد.");
        })
        .catch(() => {
            alert("مشکلی پیش آمده.");
        });

}


function confirmPayment(theID) {
    $.ajax({
        url: '/confirmPayment/' + theID,
        type: 'GET',
        success: function (result) {

            if (result == "gologin") {
                window.location = "/login/login";
            } else {
                $('#' + theID).css('display', 'none');

            }
        },
    });
}