$(document).ready(function () {
    var dates = $('.item-date');
    for (i = 0; i < dates.length; i++) {
        //$(dates[i]).text(new persianDate($(dates[i]).val()).format());
        $(dates[i]).text(milToShamsi($(dates[i]).text()));
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