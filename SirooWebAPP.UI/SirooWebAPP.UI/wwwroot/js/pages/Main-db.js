////const onIntersection = (entries) => {
////    //debugger;
////    for (const entry of entries) {
////        if (entry.isIntersecting) {
////            if (!$(entry.target).hasClass('watched')) {
////                $(entry.target).addClass('watched');
////                var startAttr = $(entry.target).attr('starttime');
////                if (typeof startAttr == 'undefined' || startAttr == false) {
////                    $(entry.target).attr('starttime', entry.time);
////                }
////            }

////        } else {
////            if ($(entry.target).hasClass('watched')) {
////                var endAttr = $(entry.target).attr('endtime');
////                if (typeof endAttr == 'undefined' || endAttr == false) {
////                    watchedTime = entry.time - parseFloat($(entry.target).attr('starttime'));
////                    if (watchedTime > 5000) {
////                        $(entry.target).attr('endtime', entry.time);

////                        var fetchedAttr = $(entry.target).attr('fetched');
////                        if (typeof fetchedAttr == 'undefined' || fetchedAttr == false) {
////                            let adId = $(entry.target).attr('adid');
////                            $.ajax({
////                                url: '/viewedPost/' + adId,
////                                type: 'GET',
////                                success: function (result) {

////                                    //debugger;

////                                    if (result == null) {
////                                        $('#postobject' + adId).fadeOut(300, function () { $('#postobject' + adId).remove(); });
////                                        removeAds(adId);
////                                    } else {
////                                        justAddAds(result);
////                                        $(entry.target).attr('fetched', 'done');
////                                    }

////                                },
////                            });
////                        }









////                    } else {
////                        $(entry.target).removeClass('watched');
////                        $(entry.target).removeAttr('starttime');
////                    }

////                } else {

////                }
////            }
////        }
////    }
////};



const onIntersectionEndPosts = (entries) => {


    for (const entry of entries) {

        if (entry.isIntersecting) {
            //debugger;

            if (!$(entry.target).hasClass('fetching')) {
                $(entry.target).addClass('fetching');
                var lastpostIdAttr = $(entry.target).attr('lastpostId');
                if (typeof lastpostIdAttr == 'undefined' || lastpostIdAttr == false) {
                    let lastId = $('.posts .post:last-child').attr('adid');
                    $('.threeDotsLoading2').show();
                    $('.threeDotsLoading2').css('display','flex');
                    GetBeforeAds(lastId);
                }
            }

        }

    }


};

//const observer = new IntersectionObserver(onIntersection);
const observerEndPosts = new IntersectionObserver(onIntersectionEndPosts);

function removeAds(adId) {
    //debugger;
    theAd = JSON.parse(localStorage.getItem(adId));
    allIds = JSON.parse(localStorage.getItem('allids'));
    if (theAd != null) {
        localStorage.removeItem(adId);

        allIds = allIds.filter(function (obj) {
            return obj != id;
        });
    }

}

function justAddAds(incomingAd) {
    //debugger;
    allIds = JSON.parse(localStorage.getItem('allids'));
    gofindads = allIds.filter(function (obj) {
        return obj == incomingAd.advertiseID;
    });

    if (gofindads != null) {
        allIds = allIds.filter(function (obj) {
            return obj != incomingAd.advertiseID;
        });
        allIds.push(incomingAd.advertiseID);
        setToLocalStorage('allids', JSON.stringify(allIds));
        localStorage.removeItem(incomingAd.advertiseID);
        setToLocalStorage(incomingAd.advertiseID, incomingAd);
    }

    fetchedAds = $('#adsTemplate').tmpl(incomingAd);
    $('#postobject' + incomingAd.advertiseID).replaceWith(fetchedAds);
    //observer.observe(document.querySelector('#postobject' + incomingAd.advertiseID));

}

//function read() {
//    var transaction = db.transaction(["Posts"]);
//    var objectStore = transaction.objectStore("Posts");
//    var request = objectStore.get("00-03");

//    request.onerror = function (event) {
//        alert("Unable to retrieve daa from database!");
//    };

//    request.onsuccess = function (event) {

//    };
//}

//function readAll() {
//    var objectStore = db.transaction("Posts").objectStore("Posts");

//    var res = new Array();
//    objectStore.openCursor().onsuccess = function (event) {
//        var cursor = event.target.result;

//        if (cursor) {
//            //$('#adsTemplate').tmpl(cursor.value).appendTo('#adsContainer');
//            res.push(cursor.value);
//            cursor.continue();
//        } else {
//            res = res.sort(compareDates);

//            $('#adsTemplate').tmpl(res).appendTo('#adsContainer');
//            //observer.observe(document.querySelector(".SirooPost"));
//            for (var i in res) {
//                observer.observe(document.querySelector('#postobject' + res[i].advertiseID));
//            }



//            ReadOtherAds();
//            //alert("No more entries!");
//        }
//    };
//}

//const onIntersection = (entries) => {
//    for (const entry of entries) {
//        if (entry.isIntersecting) {
//            if (!$(entry.target).hasClass('watched')) {
//                $(entry.target).addClass('watched');
//                var startAttr = $(entry.target).attr('starttime');
//                if (typeof startAttr == 'undefined' || startAttr == false) {
//                    $(entry.target).attr('starttime', entry.time);
//                }
//            }

//        } else {
//            if ($(entry.target).hasClass('watched')) {
//                var endAttr = $(entry.target).attr('endtime');
//                if (typeof endAttr == 'undefined' || endAttr == false) {
//                    watchedTime = entry.time - parseFloat($(entry.target).attr('starttime'));
//                    if (watchedTime > 5000) {
//                        $(entry.target).attr('endtime', entry.time);

//                        var fetchedAttr = $(entry.target).attr('fetched');
//                        if (typeof fetchedAttr == 'undefined' || fetchedAttr == false) {
//                            let adId = $(entry.target).attr('adid');
//                            $.ajax({
//                                url: '/viewedPost/' + adId,
//                                type: 'GET',
//                                success: function (result) {

//                                    //debugger;
//                                    if (result == null) {
//                                        $('#postobject' + adId).fadeOut(300, function () { $('#postobject' + adId).remove(); });
//                                        removeAds(adId);
//                                    } else {
//                                        justAddAds(result);
//                                        $(entry.target).attr('fetched', 'done');
//                                    }

//                                },
//                            });
//                        }









//                    } else {
//                        $(entry.target).removeClass('watched');
//                        $(entry.target).removeAttr('starttime');
//                    }

//                } else {

//                }
//            }
//        }
//    }
//};

//const observer = new IntersectionObserver(onIntersection);


//function ReadOtherAds() {
//    let lastAdsDate = localStorage.getItem('last-fetch-date');

//    var res = new Array();

//    $.ajax({
//        url: '/nextads/' + lastAdsDate,
//        type: 'GET',
//        success: function (result) {
//            if (result == "gologin") {
//                window.location = "/login/login";
//            } else {

//                for (var i in result) {
//                    res.push(result[i]);
//                }
//                res = res.sort(compareDates);
//                for (var i in res) {
//                    addAds(result[i], true);
//                }

//                $('.threeDotsLoading').hide();
//                localStorage.setItem('last-fetch-date', new Date().toJSON());


//                var dates = $('.profile-date');
//                for (i = 0; i < dates.length; i++) {
//                    $(dates[i]).text(jQuery.timeago($(dates[i]).text()));
//                }

//            }

//        },
//    });
//}

//function addAds(ads, mustPrepend = false) {
//    //debugger;
//    var request = db.transaction(["Posts"], "readwrite")
//        .objectStore("Posts")
//        .put(ads);

//    request.onsuccess = function (event) {
//        $('.threeDotsLoading').hide();
//        if (mustPrepend) {
//            $('#adsTemplate').tmpl(ads).prependTo('#adsContainer');
//        } else {
//            $('#adsTemplate').tmpl(ads).appendTo('#adsContainer');
//        }

//    };

//    request.onerror = function (event) {
//        alert("Unable to add data\r\nKenny is aready exist in your database! ");
//    }
//}
//function justAddAds(ads) {
//    //debugger;
//    var request = db.transaction(["Posts"], "readwrite")
//        .objectStore("Posts")
//        .put(ads);

//    request.onsuccess = function (event) {
//        //debugger;
//        fetchedAds = $('#adsTemplate').tmpl(ads);
//        $('#postobject' + ads.advertiseID).replaceWith(fetchedAds);
//    };

//    request.onerror = function (event) {
//        alert("Unable to add data\r\nKenny is aready exist in your database! ");
//    }
//}



//function removeAds(id) {
//    var request = db.transaction(["Posts"], "readwrite")
//        .objectStore("Posts")
//        .delete(id);

//    request.onsuccess = function (event) {
//        //alert("Kenny's entry has been removed from your database.");
//    };
//    request.onerror = function (event) {
//        alert("NOT removed from your web database.");
//    };
//}

function compareDates(a, b) {
    aDate = new Date(a.creationDate);
    bDate = new Date(b.creationDate);
    if (aDate > bDate) {
        return -1;
    }
    if (aDate < bDate) {
        return 1;
    }
    return 0;
}