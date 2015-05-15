$(document).ready(function () {
    ktiListView();    
});

function ktiListView() {
    $(".lv-PagerItemNumeric").hover(function () {
        $(this).addClass("lv-PagerItemNumericHover");
    },
    function () {
        $(this).removeClass("lv-PagerItemNumericHover");
    });

    $(".lv-PagerItem").each(function () {
        var s = $(this).attr("src");
        var p = s.substring(0, s.length - 5);
        p += ".png";
        $(this).css("background-image", "url('" + p + "')");
        $(this).css("background-position", "bottom");
    });

    $(".lv-PagerItem").hover(function () {
        $(this).css("background-position", "0 0");
    },
    function () {
        $(this).css("background-position", "bottom");
    });
}