
var lastRequest = 0;

$(document).ready(function () {
    //debugger;

//    alert(username);

    $('.threeDotsLoading2').hide();

    permitToUseLocalStorage = false;

    try {
        localStorage.setItem("tester", "Hello World!"); //saves to the database, "key", "value"
        permitToUseLocalStorage = true;
        if (localStorage.getItem('v') == null) {
            localStorage.clear();
            setToLocalStorage('v', '1');
        }

    } catch (e) {

        getNewPosts();
        //if (e == QUOTA_EXCEEDED_ERR) {
        //    getNewPosts();
        //}
    }


    //GoToFindLocalPosts();
    getNewPosts();






});




var theResultString = "";





function setVersion() {
    setToLocalStorage('v', '1');
}

function getNewPosts() {

    $.ajax({
        url: '/ads2/' + profileUsername +'/' + Math.random(),
        type: 'GET',
        success: function (result) {
            if (result == "gologin") {
                window.location = "/login/login";
            } else {
                //var ads = jQuery.parseJSON(result);
                //debugger;
                $('#adsContainer').html('');
                // $('#adsTemplate').tmpl(result[2]).appendTo('#adsContainer');
                // $('#adsTemplate').tmpl(result[1]).appendTo('#adsContainer');
                // $('#adsTemplate').tmpl(result[0]).appendTo('#adsContainer');
                //sortedResult = result.sort(compareDates);

                $('#adsTemplate').tmpl(result).appendTo('#adsContainer');

                //for (i = result.length - 1; i >= 0; i--) {
                //    $('#adsTemplate').tmpl(result[i]).appendTo('#adsContainer');
                //}


                localStorage.clear();
                setVersion();

                let ads = new Array();
                let rawAds = new Array();

                for (i = 0; i < result.length; i++) {

                    ads.push(result[i].advertiseID);
                    setToLocalStorage(result[i].advertiseID, JSON.stringify(result[i]));

                }

                setToLocalStorage("allids", JSON.stringify(ads));

                observerEndPosts.observe(document.querySelector('#afterLastPost'));
                $('#alldrawsBTN').show();

                if (result.length==0) {
                    $('#adsContainer').html('<div class="siroo-header-h3">'+ 'هنوز پستی ارسال نشده.'+'</div>');
                    $('.threeDotsLoading2').hide();
                    $('#afterLastPost').hide();
                }

                //var dates = $('.profile-date');
                //for (i = 0; i < dates.length; i++) {
                //    $(dates[i]).text(jQuery.timeago($(dates[i]).text()));
                //}
            }

        },
    });
}

function GoToFindLocalPosts() {

    var thePostIDs = JSON.parse(localStorage.getItem("allids"));
    var firstAd;
    if (thePostIDs != null) {

        if (thePostIDs.length > 0) {
            for (var i = 0; i < thePostIDs.length; i++) {

                theAd = JSON.parse(localStorage.getItem(thePostIDs[i]));
                if (i == 0) {
                    firstAd = theAd;
                }
                AddPostToTemplate(theAd);
                //observer.observe(document.querySelector('#postobject' + theAd.advertiseID));

            }

            GetNextAds(firstAd.advertiseID);
        } else {
            getNewPosts();
        }



    } else {

        getNewPosts();
    }

}


function GetBeforeAds(fromAdsId) {
    //debugger;

    if (fromAdsId==undefined) {
        return;
    }

    $.ajax({
        url: '/beforeads2/' + fromAdsId + '/' + profileUsername,
        type: 'GET',
        success: function (result) {

            if (result == "gologin") {

                window.location = "/login/login";

            } else {

                //debugger;

                sortedResult = result.sort(compareDates);

                AddPostToTemplate(result);

                $('#afterLastPost').removeClass('fetching');
                $('#alldrawsBTN').show();
                $('.threeDotsLoading2').hide();

            }

        },
    });


}




function GetNextAds(fromThisAd) {

    $.ajax({
        url: '/nextads/' + fromThisAd,
        type: 'GET',
        success: function (result) {

            if (result == "gologin") {

                window.location = "/login/login";

            } else {

                //debugger;


                AddPostToTemplate(result, true);

                let ads = new Array();
                let rawAds = new Array();

                if (result.length > 0) {
                    localStorage.clear();
                    setVersion();

                    for (i = 0; i < result.length; i++) {

                        ads.push(result[i].advertiseID);
                        setToLocalStorage(result[i].advertiseID, JSON.stringify(result[i]));

                    }

                    setToLocalStorage("allids", JSON.stringify(ads));
                }

                $('#alldrawsBTN').show();
                $('.threeDotsLoading').hide();

            }

        },
    });


}


function AddPostToTemplate(ad, prepend = false) {

    if (prepend) {
        $('#adsTemplate').tmpl(ad).prependTo('#adsContainer');
    } else {
        $('#adsTemplate').tmpl(ad).appendTo('#adsContainer');
    }
    if (Array.isArray(ad)) {
        for (var i = 0; i < ad.length; i++) {
            //observer.observe(document.querySelector('#postobject' + ad[i].advertiseID));
        }
    } else {
        //observer.observe(document.querySelector('#postobject' + ad.advertiseID));
    }



}

function setToLocalStorage(key, value) {
    try {
        localStorage.setItem(key, value);
    } catch (e) {

    }

}

function removeFromLocalStrorage(key) {
    if (localStorage.getItem(key) != null) {
        localStorage.removeItem(key);
    }
}


function _dobLike(obj, adv) {
    if ($('.' + adv + ' .like-btn').hasClass('liked')) {
        return;
    }
    if ($('.post.' + adv).hasClass('finished')) {
        //_doLike(obj,adv);
        return;
    }
    $('.post.' + adv).addClass('finished');


}
function _doLike(obj, adv) {
    if ($(' .like-btn.' + adv).hasClass('liked')) {
        return;
    }

    if ($('.post.' + adv).hasClass('finished')) {
        $('.' + adv + ' .like-btn').addClass('liked');

        $.ajax({
            url: '/dolike/' + adv,
            type: 'GET',
            success: function (result) {

                if (result == "gologin") {
                    window.location = "/login/login";
                } else {
                    $('.' + adv + ' .like-btn').addClass('liked');

                    _result = parseInt(result);
                    if (_result > -1) {
                        $('.like-details.' + adv + ' b').text(parseInt($('.like-details.' + adv + ' b').text()) + 1);
                        pointUpdated(result);
                    }
                    //alert(adv+" is liked");
                }
            },
        });
    } else {
        alert('باید ویدئو را تا انتها ملاحظه بفرمایید تا امتیاز لایک این ویدئو را دریافت نمایید.');
    }
}



$(window).scroll(function () {

    if (muteCondition == false) {
        $('video').each(function () {
            if ($(this).is(":in-viewport")) {
                $(this)[0].muted = mute;
                $(this)[0].play();

            } else {
                $(this)[0].pause();
            }
        })
    }

});

function _onProgress(obj) {
    console.log(obj.currentTime);
    var theId = obj.id;
    var theMins = Math.round((obj.duration-obj.currentTime)/60);
    var theSeconds = Math.round((obj.duration-obj.currentTime)%60);
    $("#timer_" + theId).html(theMins+":"+theSeconds);
}


var mute = false;
function toggleMute(obj) {
    mute = !mute;

    var vid = document.getElementById(obj);
    vid.muted = mute;
}

var muteCondition = false;
function toggleMuteAllVideos(cmd) {
    muteCondition = cmd;
    $('video').each(function () {
        $(this)[0].muted = cmd;
    });

}






