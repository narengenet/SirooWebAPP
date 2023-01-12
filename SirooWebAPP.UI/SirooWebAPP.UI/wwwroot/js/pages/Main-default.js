
var lastRequest = 0;

$(document).ready(function () {
    //debugger;

    prepareWheel();

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


    snowFall();



});



function snowFall() {
    $("<div class='snows'></div>").appendTo(".MainDashboard");
    for (var i = 0; i < 197; i++) {
        $("<div class='snow'></div>").appendTo(".MainDashboard .snows");
    }

}




function myfunction() {
    $('button.spin').hide();
    var min = 1024;
    var max = 9999;
    var deg = Math.floor(Math.random() * (max - min)) + min;
    document.getElementById('box').style.transform = "rotate(" + deg + "deg)";

    $.ajax({
        url: '/getDiamond',
        type: 'GET',
        success: function (result) {
            if (result == "gologin") {
                window.location = "/login/login";
            } else {
                if (result != "-1") {

                    setTimeout(function () {
                        theArrays = result.split(',');
                        pointUpdated('-' + theArrays[0]);
                        diamondUpdated(theArrays[1]);
                        alert(theArrays[2]);
                        $('button.spin').show();
                    }, 4000);

                } else {
                    alert('شما امتیاز کافی برای چرخش گردونه الماس ندارید.');
                    $('button.spin').show();
                }


            }
        }
    });

}

var audio = null;
var theWheel = null;

function prepareWheel() {

    if (arraysofDiamonds) {

        theSegments = new Array();
        theCollors = ["#ee1c24", "#3cb878", "#f6989d", "#00aef0", "#f26522", "#e70697", "#fff200", "#f6989d", "#ee1c24", "#3cb878", "#f26522", "#a186be", "#fff200", "#00aef0", "#ee1c24", "#f6989d", "#f26522", "#3cb878", "#a186be", "#fff200", "#00aef0"];

        for (var i = 0; i < arraysofDiamonds.length; i++) {
            tmpSegment = new Segment;
            tmpSegment.fillStyle = theCollors[Math.floor(Math.random() * theCollors.length)];;
            tmpSegment.text = arraysofDiamonds[i];
            theSegments.push(tmpSegment);

        }

        // Create new wheel object specifying the parameters at creation time.
        theWheel = new Winwheel({
            'outerRadius': 150,        // Set outer radius so wheel fits inside the background.
            'innerRadius': 40,         // Make wheel hollow so segments don't go all way to center.
            'textFontSize': 14,         // Set default font size for the segments.
            'textOrientation': 'vertical', // Make text vertial so goes down from the outside of wheel.
            'textAlignment': 'outer',    // Align text to outside of wheel.
            'numSegments': arraysofDiamonds.length,         // Specify number of segments.
            'segments': theSegments,
            'animation':           // Specify the animation to use.
            {
                'type': 'spinToStop',
                'duration': 10,    // Duration in seconds.
                'spins': 3,     // Default number of complete spins.
                'callbackFinished': alertPrize,
                'callbackSound': playSound,   // Function to call when the tick sound is to be triggered.
                'soundTrigger': 'pin',        // Specify pins are to trigger the sound, the other option is 'segment'.
                'stopAngle': 36
            },
            'pins':				// Turn pins on.
            {
                'number': arraysofDiamonds.length,
                'fillStyle': 'green',
                'outerRadius': 4,
            }
        });


    }






    // Loads the tick audio sound in to an audio object.
    audio = new Audio('../sounds/tick.mp3');
}

// This function is called when the sound is to be played.
function playSound() {
    // Stop and rewind the sound if it already happens to be playing.
    audio.pause();
    audio.currentTime = 0;

    // Play the sound.
    audio.play();
}

// Vars used by the code in this page to do power controls.
let wheelPower = 0;
let wheelSpinning = false;

//// -------------------------------------------------------
//// Function to handle the onClick on the power buttons.
//// -------------------------------------------------------
//function powerSelected(powerLevel) {
//    // Ensure that power can't be changed while wheel is spinning.
//    if (wheelSpinning == false) {
//        // Reset all to grey incase this is not the first time the user has selected the power.
//        document.getElementById('pw1').className = "";
//        document.getElementById('pw2').className = "";
//        document.getElementById('pw3').className = "";

//        // Now light up all cells below-and-including the one selected by changing the class.
//        if (powerLevel >= 1) {
//            document.getElementById('pw1').className = "pw1";
//        }

//        if (powerLevel >= 2) {
//            document.getElementById('pw2').className = "pw2";
//        }

//        if (powerLevel >= 3) {
//            document.getElementById('pw3').className = "pw3";
//        }

//        // Set wheelPower var used when spin button is clicked.
//        wheelPower = powerLevel;

//        // Light up the spin button by changing it's source image and adding a clickable class to it.
//        document.getElementById('spin_button').src = "spin_on.png";
//        document.getElementById('spin_button').className = "clickable";
//    }
//}

// -------------------------------------------------------
// Click handler for spin button.
// -------------------------------------------------------

var theResultString = "";

function startSpin() {

    if (wheelSpinning == false) {



        $.ajax({
            url: '/getDiamond',
            type: 'GET',
            success: function (result) {
                if (result == "gologin") {
                    window.location = "/login/login";
                } else {
                    if (result != "-1") {

                        theArrays = result.split(',');
                        pointUpdated('-' + theArrays[0]);
                        diamondUpdated(theArrays[1]);

                        theResultString=theArrays[3];



                        // Ensure that spinning can't be clicked again while already running.

                        // Based on the power level selected adjust the number of spins for the wheel, the more times is has
                        // to rotate with the duration of the animation the quicker the wheel spins.
                        if (wheelPower == 1) {
                            theWheel.animation.spins = 3;
                        } else if (wheelPower == 2) {
                            theWheel.animation.spins = 6;
                        } else if (wheelPower == 3) {
                            theWheel.animation.spins = 10;
                        }

                        // Disable the spin button so can't click again while wheel is spinning.
                        //document.getElementById('spin_button').src = "spin_off.png";
                        //document.getElementById('spin_button').className = "";

                        $('#theWheel').removeClass('the_wheel');
                        $('#theWheel').addClass('the_wheel2');

                        theStopAngle = (360 / theWheel.segments.length) / 2;
                        theWheel.animation['stopAngle'] = parseInt(theArrays[2])-theStopAngle;
                        
                        // Begin the spin animation by calling startAnimation on the wheel object.
                        theWheel.startAnimation();

                        // Set to true so that power can't be changed and spin button re-enabled during
                        // the current animation. The user will have to reset before spinning again.
                        wheelSpinning = true;


                    } else {
                        alert('شما امتیاز کافی برای چرخش گردونه الماس ندارید.');
                        $('button.spin').show();
                    }


                }
            }
        });

    }


}

// -------------------------------------------------------
// Function for reset button.
// -------------------------------------------------------
function resetWheel() {
    theWheel.stopAnimation(false);  // Stop the animation, false as param so does not call callback function.
    theWheel.rotationAngle = 0;     // Re-set the wheel angle to 0 degrees.
    theWheel.draw();                // Call draw to render changes to the wheel.

    //document.getElementById('pw1').className = "";  // Remove all colours from the power level indicators.
    //document.getElementById('pw2').className = "";
    //document.getElementById('pw3').className = "";

    wheelSpinning = false;          // Reset to false to power buttons and spin can be clicked again.
    $('#theWheel').removeClass('the_wheel2');
    $('#theWheel').addClass('the_wheel');
}

// -------------------------------------------------------
// Called when the spin animation has finished by the callback feature of the wheel because I specified callback in the parameters.
// -------------------------------------------------------
function alertPrize(indicatedSegment) {
    // Just alert to the user what happened.
    // In a real project probably want to do something more interesting than this with the result.
    //if (indicatedSegment.text == 'LOOSE TURN') {
    //    alert('Sorry but you loose a turn.');
    //} else if (indicatedSegment.text == 'BANKRUPT') {
    //    alert('Oh no, you have gone BANKRUPT!');
    //} else {
    //    alert("You have won " + indicatedSegment.text);
    //}
    alert(theResultString);

    resetWheel();
}



function setVersion() {
    setToLocalStorage('v', '1');
}

function getNewPosts() {

    $.ajax({
        url: '/ads?rnd=' + Math.random(),
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
    $.ajax({
        url: '/beforeads/' + fromAdsId,
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






function useChip() {
    let thePIN = $('#chipPIN').val();
    if (thePIN.length < 5) {
        alert('کد امتیاز اشتباه است.');
        return;
    }

    $('.waitingPlease').css('display', 'flex');

    $.ajax({
        url: '/useChips/' + thePIN,
        type: 'GET',
        success: function (result) {
            $('.waitingPlease').css('display', 'none');
            if (result == "-2") {
                alert('تعداد استفاده مجاز شما امروز به اتمام رسیده است.');
                return;
            };
            if (result == "-3") {
                alert('کد امتیاز اشتباه است.');
                return;
            };
            if (result == "-4") {
                alert('کد امتیاز قبلا استفاده شده است.');
                return;
            };
            if (result == "-5") {
                alert('خطای سیستمی رخ داده است.');
                return;
            };

            let successResult = parseInt(result);
            if (successResult > 0) {
                pointUpdated(result);
                alert(result + 'امتیاز دریافت کردید.');
            }
        },
    });
}





////var db;
////$(document).ready(function () {
////    //debugger;
////    //prefixes of implementation that we want to test
////    window.indexedDB = window.indexedDB || window.mozIndexedDB ||
////        window.webkitIndexedDB || window.msIndexedDB;

////    //prefixes of window.IDB objects
////    window.IDBTransaction = window.IDBTransaction ||
////        window.webkitIDBTransaction || window.msIDBTransaction;
////    window.IDBKeyRange = window.IDBKeyRange || window.webkitIDBKeyRange ||
////        window.msIDBKeyRange

////    if (!window.indexedDB) {
////        window.alert("Your browser doesn't support a stable version of IndexedDB.")
////    }

////    db;
////    var request = window.indexedDB.open("SirooDatabase", 1);

////    request.onerror = function (event) {
////        console.log("error: ");
////    };

////    request.onsuccess = function (event) {
////        db = request.result;
////        if (localStorage.getItem('last-fetch-date') != null) {

////            readAll();

////        }
////        console.log("success: " + db);
////    };

////    request.onupgradeneeded = function (event) {
////        var db = event.target.result;
////        var objectStore = db.createObjectStore("Posts", { keyPath: "advertiseID" });
////        //debugger;

////        $.ajax({
////            url: '/ads?rnd=' + Math.random(),
////            type: 'GET',
////            success: function (result) {
////                if (result == "gologin") {
////                    window.location = "/login/login";
////                } else {

////                    for (var i in result) {
////                        addAds(result[i]);
////                        //objectStore.add(result[i]);
////                    }
////                    localStorage.setItem('last-fetch-date', new Date().toJSON());
////                }

////            },
////        });



////    }


////});
////function _dobLike(obj, adv) {
////    if ($('.' + adv + ' .like-btn').hasClass('liked')) {
////        return;
////    }
////    if ($('.post.' + adv).hasClass('finished')) {
////        //_doLike(obj,adv);
////        return;
////    }
////    $('.post.' + adv).addClass('finished');


////}
////function _doLike(obj, adv) {
////    if ($(' .like-btn.' + adv).hasClass('liked')) {
////        return;
////    }
////    if ($('.post.' + adv).hasClass('finished')) {
////        $.ajax({
////            url: '/dolike/' + adv,
////            type: 'GET',
////            success: function (result) {

////                if (result == "gologin") {
////                    window.location = "/login/login";
////                } else {
////                    $('.' + adv + ' .like-btn').addClass('liked');

////                    _result = parseInt(result);
////                    if (_result > -1) {
////                        $('.like-details.' + adv + ' b').text(parseInt($('.like-details.' + adv + ' b').text()) + 1);
////                        pointUpdated(result);
////                    }
////                    //alert(adv+" is liked");
////                }
////            },
////        });
////    } else {
////        alert('باید ویدئو را تا انتها ملاحظه بفرمایید تا امتیاز لایک این ویدئو را دریافت نمایید.');
////    }
////}



////$(window).scroll(function () {
////    $('video').each(function () {
////        if ($(this).is(":in-viewport")) {
////            $(this)[0].muted = mute;
////            $(this)[0].play();
////        } else {
////            $(this)[0].pause();
////        }
////    })
////});


////var mute = false;
////function toggleMute(obj) {
////    mute = !mute;

////    var vid = document.getElementById(obj);
////    vid.muted = mute;
////}




