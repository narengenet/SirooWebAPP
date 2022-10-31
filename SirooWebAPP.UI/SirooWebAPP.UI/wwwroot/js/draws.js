////$(document).ready(function () {
////    var windowHeight = $(window).height(),
////        gridTop = windowHeight * .05,
////        gridBottom = windowHeight * .85;
////    $(window).on('scroll', function () {
////        $('.draw').each(function () {
////            var thisTop = $(this).offset().top - $(window).scrollTop();

////            if (thisTop > gridTop && (thisTop + $(this).height()) < gridBottom) {
////                $(this).addClass('current');
////            } else {
////                $(this).removeClass('current');
////            }
////        });
////    });
////});