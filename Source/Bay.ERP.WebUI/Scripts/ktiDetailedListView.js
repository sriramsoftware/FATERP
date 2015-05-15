$(document).ready(function () {
    ktiListDetailedView();    
});

function ktiListDetailedView() {
    $(".d-lv-PagerItemNumeric").hover(function () {
        $(this).addClass("d-lv-PagerItemNumericHover");
    },
    function () {
        $(this).removeClass("d-lv-PagerItemNumericHover");
    });

    $(".d-lv-PagerItem").each(function () {
        var s = $(this).attr("src");
        var p = s.substring(0, s.length - 5);
        p += ".png";
        $(this).css("background-image", "url('" + p + "')");
        $(this).css("background-position", "bottom");
    });

    $(".d-lv-PagerItem").hover(function () {
        $(this).css("background-position", "0 0");
    },
    function () {
        $(this).css("background-position", "bottom");
    });
}