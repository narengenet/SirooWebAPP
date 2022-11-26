$(document).ready(function () {
    
    _usernames = $('.username');
    _cellphones = $('.cellphone');

    $('.passwords').hide();
    $('.inviters').hide();
    $('.inviter').hide();



   
});
var _usernames;
var _cellphones;

var selectedUserToAddPoint = "-1";

var passwords = false;
var inviters = false;

function togglePasswords() {
    if (!passwords) {
        $('.passwords').show();
        passwords = true;
    } else {
        $('.passwords').hide();
        passwords = false;
    }
}



function toggleInviters() {
    if (!inviters) {
        $('.inviter').show();
        $('.inviters').show();
        inviters = true;
        $('.waitingPlease').css('display', 'flex');
        setTimeout(function () {
            goFindInviters();
        }, 100);
        
        
    } else {
        $('.inviter').hide();
        $('.inviters').hide();
        inviters = false;
    }
}

var foundInviters = false;

function goFindInviters() {
    if (!foundInviters) {
        foundInviters = true;
        
        
        var allusernames = $('.username');
        var allids = $('.ids');
        var allInviters = $('.inviter');
        for (var i = 0; i < allids.length; i++) {
            inviterId = $(allInviters[i]).text();
            inviterUsername = findUsernameById(inviterId);
            $(allInviters[i]).text(inviterUsername);
        }
        
    }
    $('.waitingPlease').css('display', 'none');

}




function findUser() {
    let searchText = $('#searchuser').val();
    if (searchText.startsWith("09")) {
        findByCellphone(searchText);
    } else {
        findByUsername(searchText);
    }
}

function findByCellphone(cellText) {
    for (var i = 0; i < _cellphones.length; i++) {
        if ($(_cellphones[i]).text() == cellText) {
            $('.userRow').hide();
            $('#' + $(_cellphones[i]).attr('data-id')).show();
            break;
        }
    }
}
function findByUsername(cellText) {
    for (var i = 0; i < _usernames.length; i++) {
        if ($(_usernames[i]).text() == cellText) {
            $('.userRow').hide();
            $('#' + $(_usernames[i]).attr('data-id')).show();
            break;
        }
    }
}

function addPointsGo() {
    if (selectedUserToAddPoint=="-1") {
        return;
    }
    let point = $('#point-' + selectedUserToAddPoint).val();
    $('.waitingPlease').css('display', 'flex');

    $.ajax({
        url: '/addPointToUser/' + selectedUserToAddPoint+'/'+point,
        type: 'GET',
        success: function (result) {
            $('.waitingPlease').css('display', 'none');
            if (result == "-1") {
                alert('خطا');
            } else {
                current = parseInt($('#current-' + selectedUserToAddPoint).text());
                current += parseInt(point);
                $('#current-' + selectedUserToAddPoint).text(current);

                alert('امتیاز به کاربر اضافه شد.');

            }
        },
    });
}

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