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


                var dates = $('.dates');
                for (i = 0; i < dates.length; i++) {
                    $(dates[i]).text(jQuery.timeago($(dates[i]).text()));
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