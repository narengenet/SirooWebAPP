$(document).ready(function () {
    getDraws();

});

var alldraws = '';

function getDraws() {
    $.ajax({
        url: '/draws',
        type: 'GET',
        success: function (result) {
            if (result == "gologin") {
                window.location = "/login/login";
            } else {
                sina = "{draws:" + result + "}";
                alldraws = result;
                $('#drawsContainer').html('');
                $('#drawTemplate').tmpl(result).appendTo('#drawsContainer');
                var myflippers = $('.myFlipper');
                for (i = 0; i < myflippers.length; i++) {
                    var enddate = new Date($(myflippers[i]).attr('data-datetime'));
                    $(myflippers[i]).attr('data-datetime', enddate.getFullYear() + '-' + (enddate.getMonth() + 1) + '-' + enddate.getDate() + " 00:00:00");
                    $(myflippers[i]).flipper('init');
                }


                //var dates = $('.dates');
                //for (i = 0; i < dates.length; i++) {
                //    $(dates[i]).text(jQuery.timeago($(dates[i]).text()));
                //}


                var dates = $('.dates');
                for (i = 0; i < dates.length; i++) {
                    //$(dates[i]).text(new persianDate($(dates[i]).val()).format());
                    $(dates[i]).text(milToShamsi($(dates[i]).text()));
                }


                theCounter = 0;
                meInvolved = false;
                winnerTmpl = $('.winnerTemplate');
                for (i = 0; i < alldraws.length; i++) {
                    theCounter = 0;
                    meInvolved = false;
                    for (j = 0; j < alldraws[i].prizes.length; j++) {
                        for (k = 0; k < alldraws[i].prizes[j].winnerCount; k++) {
                            if (theCounter < alldraws[i].prizeWinners.length) {
                                theCounter += 1;
                                $(winnerTmpl).attr('count', theCounter);
                                $(winnerTmpl).find('.winnerRank').html(theCounter);
                                $(winnerTmpl).find('.winnerUsername').html(alldraws[i].prizeWinners[theCounter - 1].username);
                                $(winnerTmpl).find('.winningPoints').html(alldraws[i].prizeWinners[theCounter - 1].points + ' امتیاز');
                                $(winnerTmpl).find('.winningPrize').html(alldraws[i].prizes[j].name);
                                if (myUsername == alldraws[i].prizeWinners[theCounter - 1].username) {
                                    $(winnerTmpl).find('.Textbox').addClass('me');
                                    $(winnerTmpl).find('.winner').addClass('me');
                                    meInvolved = true;
                                } else {
                                    $(winnerTmpl).find('.Textbox').removeClass('me');
                                    $(winnerTmpl).find('.winner').removeClass('me');
                                }
                                $('.theWinners.' + alldraws[i].drawId).append(winnerTmpl.html());
                            }
                        }
                    }

                    if (meInvolved == false && alldraws[i].isFinished == false) {
                        myRank = 0;
                        for (x = 0; x < alldraws[i].prizeWinners.length; x++) {
                            myRank += 1;
                            if (alldraws[i].prizeWinners[x].username == myUsername) {
                                $(winnerTmpl).find('.winnerRank').html(myRank);
                                $(winnerTmpl).find('.winnerUsername').html(myUsername);
                                $(winnerTmpl).find('.winningPoints').html(myPoint + ' امتیاز');
                                $(winnerTmpl).find('.winningPrize').html('---');
                                $(winnerTmpl).find('.Textbox').addClass('me');
                                $(winnerTmpl).find('.winner').addClass('me');

                                $('.theWinners.' + alldraws[i].drawId).append($('.threeDots').html());
                                $('.theWinners.' + alldraws[i].drawId).append(winnerTmpl.html());
                            }
                        }
                    }
                }


            }


        },
    });
}












$(document).ready(function () {
    var dates = $('.item-date');
    for (i = 0; i < dates.length; i++) {
        //$(dates[i]).text(new persianDate($(dates[i]).val()).format());
        $(dates[i]).val(milToShamsi($(dates[i]).val()));
    }
});


function milToShamsi(mysql_timestamp) {

    //let date_convert_y = parseInt(mysql_timestamp.substr(6, 4));
    //let date_convert_m = parseInt(mysql_timestamp.substr(0, 2));
    //let date_convert_d = parseInt(mysql_timestamp.substr(3, 2));

    let date_convert_y = new Date(mysql_timestamp).getFullYear();
    let date_convert_m = (new Date(mysql_timestamp).getMonth() + 1);
    let date_convert_d = new Date(mysql_timestamp).getDate();
    return miladi_be_shamsi(date_convert_y, date_convert_m, date_convert_d);
}
function miladi_be_shamsi(gy, gm, gd) {
    var g_d_m, jy, jm, jd, gy2, days;
    g_d_m = [0, 31, 59, 90, 120, 151, 181, 212, 243, 273, 304, 334];
    gy2 = (gm > 2) ? (gy + 1) : gy;
    days = 355666 + (365 * gy) + ~~((gy2 + 3) / 4) - ~~((gy2 + 99) / 100) + ~~((gy2 + 399) / 400) + gd + g_d_m[gm - 1];
    jy = -1595 + (33 * ~~(days / 12053));
    days %= 12053;
    jy += 4 * ~~(days / 1461);
    days %= 1461;
    if (days > 365) {
        jy += ~~((days - 1) / 365);
        days = (days - 1) % 365;
    }
    if (days < 186) {
        jm = 1 + ~~(days / 31);
        jd = 1 + (days % 31);
    } else {
        jm = 7 + ~~((days - 186) / 30);
        jd = 1 + ((days - 186) % 30);
    }
    return [jy + '/' + jm + '/' + jd];
}

