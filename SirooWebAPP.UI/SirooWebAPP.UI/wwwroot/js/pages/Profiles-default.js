
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
        url: '/ads2/' + profileUsername + '/' + Math.random(),
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
                    if (result[i].isAudio) {
                        prepareAudio(result[i].advertiseID);
                    }

                }

                setToLocalStorage("allids", JSON.stringify(ads));

                observerEndPosts.observe(document.querySelector('#afterLastPost'));
                $('#alldrawsBTN').show();

                if (result.length == 0) {
                    $('#adsContainer').html('<div class="siroo-header-h3">' + 'هنوز پستی ارسال نشده.' + '</div>');
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

    if (fromAdsId == undefined) {
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
                        if (result[i].isAudio) {
                            prepareAudio(result[i].advertiseID);
                        }

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
            if (ad[i].isAudio) {
                prepareAudio(ad[i].advertiseID);
            }
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
        });
        $('.the_Audio').each(function () {
            if ($(this).is(":in-viewport")) {
                $(this).find('audio')[0].muted = mute;
                $(this).find('audio')[0].play();

            } else {
                $(this).find('audio')[0].pause();
            }
        });
    }

});

function _onProgress(obj) {
    console.log(obj.currentTime);
    var theId = obj.id;
    var theMins = Math.round((obj.duration - obj.currentTime) / 60);
    var theSeconds = Math.round((obj.duration - obj.currentTime) % 60);
    $("#timer_" + theId).html(theMins + ":" + theSeconds);
}


var mute = false;
function toggleMute(obj) {
    mute = !mute;

    var vid = document.getElementById(obj);
    vid.muted = mute;

    if (!mute) {
        $('#mute_btn').hide();
        $('#unmute_btn').show();
    } else {
        $('#unmute_btn').hide();
        $('#mute_btn').show();

    }

    toggleMuteAllVideos(mute);
}

function hideUnmute() {
    $('#unmute_btn').hide();
}
function hideMute() {
    $('#mute_btn').hide();
}
function toggleMuteAudio(obj) {
    mute = !mute;


    if (!$(obj).find('audio')[0].paused && mute) {
        $(obj).find('audio')[0].pause();
    }

    if ($(obj).find('audio')[0].paused && !mute) {
        $(obj).find('audio')[0].play();
    }

    if (!mute) {
        $('#mute_btn').hide();
        $('#unmute_btn').show();
    } else {
        $('#unmute_btn').hide();
        $('#mute_btn').show();

    }

    toggleMuteAllVideos(mute);
}

var muteCondition = false;



function toggleMuteAllVideos(cmd) {
    muteCondition = cmd;
    $('video').each(function () {
        $(this)[0].muted = cmd;
    });
    $('audio').each(function () {
        $(this)[0].muted = cmd;
    });

}




function prepareAudio(theContainer) {

    var containerID = '#the_audio_' + theContainer;

    $(containerID).jsRapAudio({
        src: $(containerID).attr('data-theURL'),
        loop: false,
        onEnded: function () {
            console.log('onEnded');
            _dobLike(this, theContainer)
        },
        onLoadedmetadata: function () {
            console.log('onLoadedmetadata ' + this.audio.duration);
        },
        onVolumechange: function () {
            console.log(this.audio.volume);
        }
    });

    ID3.loadTags($(containerID).attr('data-theURL'), function () {
        showTags(containerID, $(containerID).attr('data-theURL'));
    }, {
        tags: ["title", "artist", "album", "picture"]
    });
}


function showTags(theContainer, url) {
    var tags = ID3.getAllTags(url);
    console.log(tags);
    //document.getElementById('title').textContent = tags.title || "";
    //document.getElementById('artist').textContent = tags.artist || "";
    //document.getElementById('album').textContent = tags.album || "";
    var image = tags.picture;
    if (image) {
        var base64String = "";
        for (var i = 0; i < image.data.length; i++) {
            base64String += String.fromCharCode(image.data[i]);
        }
        var base64 = "data:" + image.format + ";base64," +
            window.btoa(base64String);
        //document.getElementById(theContainer + '_image').setAttribute('src', base64);
        $(theContainer + '_image').attr('src', base64);
        $(theContainer + ' canvas').css('background', 'url(' + $(theContainer + '_image').attr('src') + ')');
    } else {
        document.getElementById('picture').style.display = "none";
    }
}



function _doFollow(userid) {


    $.ajax({
        url: '/dofollow/' + userid,
        type: 'GET',
        success: function (result) {

            if (result == "gologin") {
                window.location = "/login/login";
            } else {

                if (result == "1") {
                    $('#followBTN').addClass('btn');
                    $('#followBTN').addClass('btn-danger');
                    $('#followBTN').val('دنبال نکردن');
                    $('.profiles-followbtn').removeClass('fa-user-plus');
                    $('.profiles-followbtn').addClass('fa-user-minus');
                    alert('اکنون شما این کاربر را دنبال می‌کنید.')
                } else if (result == "0") {
                    $('#followBTN').removeClass('btn');
                    $('#followBTN').removeClass('btn-danger');
                    $('#followBTN').val('دنبال کردن');
                    $('.profiles-followbtn').addClass('fa-user-plus');
                    $('.profiles-followbtn').removeClass('fa-user-minus');
                    alert(' شما این کاربر را  دیگر دنبال نمی‌کنید.')
                }

            }
        },
    });

}
function _doFollowSmall(userid) {


    $.ajax({
        url: '/dofollow/' + userid,
        type: 'GET',
        success: function (result) {

            if (result == "gologin") {
                window.location = "/login/login";
            } else {

                if (result == "1") {
                    $('#smallFollowBtn_' + userid).hide();
                    alert(' اکنون شما این کاربر را دنبال می‌کنید.')
                } else if (result == "0") {
                    //$('#followBTN').removeClass('btn');
                    //$('#followBTN').removeClass('btn-danger');
                    //$('#followBTN').val('دنبال کردن');
                    //$('.profiles-followbtn').addClass('fa-user-plus');
                    //$('.profiles-followbtn').removeClass('fa-user-minus');
                    //alert('از اکنون شما این کاربر را  دیگر دنبال نمی‌کنید.')
                }

            }
        },
    });

}

var theCurrentUserID = -1;
var theCurrentPageIndex = 0;

function _getFollowers(userid,pageindex=0) {

    $('.followersList.followers').css('display', 'flex');
    theCurrentUserID = userid;

    if (theCurrentPageIndex == 0 || pageindex == 0) {
        $('#followerListContainer').html('درحال دریافت اطلاعات');
        $('.loadMore.SirooBtn').show();

        if (pageindex==0) {
            theCurrentPageIndex = 0;
        }
    }

    $.ajax({
        url: '/getfollowers/'+pageindex+'/' + userid,
        type: 'GET',
        success: function (result) {

            if (result == "gologin") {
                window.location = "/login/login";
            } else {
                if (result != "-1") {

                    if (pageindex==0) {
                        $('#followerListContainer').html('');
                    }

                    AddFollowersToTemplate(result);
                    theCurrentPageIndex += 1;
                } else {
                    $('#followerListContainer').html('یافت نشد');
                    $('.loadMore.SirooBtn').hide();
                }
                


            }
        },
    });

}




function _getFollowings(userid, pageindex = 0) {

    $('.followersList.followings').css('display', 'flex');
    theCurrentUserID = userid;

    if (theCurrentPageIndex == 0 || pageindex == 0) {
        $('#followingListContainer').html('درحال دریافت اطلاعات');
        $('.loadMore.SirooBtn').show();

        if (pageindex == 0) {
            theCurrentPageIndex = 0;
        }
    }

    $.ajax({
        url: '/getfollowings/' + pageindex + '/' + userid,
        type: 'GET',
        success: function (result) {

            if (result == "gologin") {
                window.location = "/login/login";
            } else {
                if (result != "-1") {

                    if (pageindex == 0) {
                        $('#followingListContainer').html('');
                    }

                    AddFollowingsToTemplate(result);
                    theCurrentPageIndex += 1;
                } else {
                    $('#followingListContainer').html('یافت نشد');
                    $('.loadMore.SirooBtn').hide();
                }



            }
        },
    });

}

function loadMoreFollowers() {
    _getFollowers(theCurrentUserID, theCurrentPageIndex);
}
function loadMoreFollowings() {
    _getFollowings(theCurrentUserID, theCurrentPageIndex);
}
function closeList() {
    $('.followersList').hide();
}

function AddFollowersToTemplate(ad, prepend = false) {

    if (prepend) {
        $('#followersTemplate').tmpl(ad).prependTo('#followerListContainer');
    } else {
        $('#followersTemplate').tmpl(ad).appendTo('#followerListContainer');
    }

    $('#followerListContainer').scrollTop($('#followerListContainer')[0].scrollHeight);


}
function AddFollowingsToTemplate(ad, prepend = false) {

    if (prepend) {
        $('#followersTemplate').tmpl(ad).prependTo('#followingListContainer');
    } else {
        $('#followersTemplate').tmpl(ad).appendTo('#followingListContainer');
    }

    $('#followingListContainer').scrollTop($('#followingListContainer')[0].scrollHeight);

}