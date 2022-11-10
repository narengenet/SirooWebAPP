var db;
$(document).ready(function () {
    debugger;
    //prefixes of implementation that we want to test
    window.indexedDB = window.indexedDB || window.mozIndexedDB ||
        window.webkitIndexedDB || window.msIndexedDB;

    //prefixes of window.IDB objects
    window.IDBTransaction = window.IDBTransaction ||
        window.webkitIDBTransaction || window.msIDBTransaction;
    window.IDBKeyRange = window.IDBKeyRange || window.webkitIDBKeyRange ||
        window.msIDBKeyRange

    if (!window.indexedDB) {
        window.alert("Your browser doesn't support a stable version of IndexedDB.")
    }

    db;
    var request = window.indexedDB.open("SirooDatabase", 1);

    request.onerror = function (event) {
        console.log("error: ");
    };

    request.onsuccess = function (event) {
        db = request.result;
        if (localStorage.getItem('last-fetch-date') != null) {

            readAll();

        }
        console.log("success: " + db);
    };

    request.onupgradeneeded = function (event) {
        var db = event.target.result;
        var objectStore = db.createObjectStore("Posts", { keyPath: "advertiseID" });
        debugger;

        $.ajax({
            url: '/ads?rnd=' + Math.random(),
            type: 'GET',
            success: function (result) {
                if (result == "gologin") {
                    window.location = "/login/login";
                } else {

                    for (var i in result) {
                        addAds(result[i]);
                        //objectStore.add(result[i]);
                    }
                    localStorage.setItem('last-fetch-date', new Date().toJSON());
                }

            },
        });



    }






    //var thePosts = JSON.parse(localStorage.getItem("ads"));
    //if (thePosts != null) {
    //    $('#adsTemplate').tmpl(thePosts).appendTo('#adsContainer');
    //}

    //$.ajax({
    //    url: '/ads?rnd=' + Math.random(),
    //    type: 'GET',
    //    success: function (result) {
    //        if (result == "gologin") {
    //            window.location = "/login/login";
    //        } else {
    //            //var ads = jQuery.parseJSON(result);
    //            sina = "{ads:" + result + "}";
    //            $('#adsContainer').html('');
    //            $('#adsTemplate').tmpl(result).appendTo('#adsContainer');
    //            localStorage.setItem("ads", JSON.stringify(result));


    //            var dates = $('.profile-date');
    //            for (i = 0; i < dates.length; i++) {
    //                $(dates[i]).text(jQuery.timeago($(dates[i]).text()));
    //            }
    //        }

    //    },
    //});
});
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
    $('video').each(function () {
        if ($(this).is(":in-viewport")) {
            $(this)[0].muted = mute;
            $(this)[0].play();
        } else {
            $(this)[0].pause();
        }
    })
});


var mute = false;
function toggleMute(obj) {
    mute = !mute;

    var vid = document.getElementById(obj);
    vid.muted = mute;
}


//var observer = new IntersectionObserver(function (entries) {
//    console.log(entries);
//    for (var i = 0; i < entries.length; i++) {
//        if (entries[i]['isIntersecting'] === true) {
//            if (entries[i]['intersectionRatio'] === 1)
//                console.log('Target is fully visible in screen');
//            else if (entries[i]['intersectionRatio'] > 0.5)
//                console.log('More than 50% of target is visible in screen');
//            else
//                console.log('Less than 50% of target is visible in screen');
//        }
//        else {
//            console.log('Target is not visible in screen');
//        }
//    }

//}, { threshold: [0, 0.5, 1] });


