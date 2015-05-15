$(document).ready(function () {
    ktiCommon();
});

function ktiCommon() {

    $(".ktiTextBox").hover(
    function () {
        var tb = $(this);
        tb.removeClass("ktiCommonNormal");
        tb.addClass("ktiCommonHover");
        //tb.css("background", " url(/Images/forms/form_inp_236_20_hover.gif) no-repeat");
    },
    function () {
        var tb = $(this);
        tb.removeClass("ktiCommonHover");   
        tb.addClass("ktiCommonNormal");        
        //tb.css("background", " url(/Images/forms/form_inp_236_20.gif) no-repeat");
    });


    $(".ktiTextArea").hover(
    function () {
        var tb = $(this);
        tb.removeClass("ktiTextArea");
        tb.addClass("ktiTextAreaHover");
        //tb.css("border-color", "#515151");
    },
    function () {
        var tb = $(this);
        tb.removeClass("ktiTextAreaHover");
        tb.addClass("ktiTextArea");
//        tb.css("border-left-color", "#8E8E8E");
//        tb.css("border-top-color", "#8E8E8E");
//        tb.css("border-right-color", "#B8B8B8");
//        tb.css("border-bottom-color", "#B8B8B8");
//        tb.css("color", "black");
    });

    $(".ktiSelect").hover(
    function () {
        var s = $(this);
        s.removeClass("ktiSelect");
        s.addClass("ktiSelectHover");
        //s.css("border-color", "#515151");
    },
    function () {
        var s = $(this);
        s.removeClass("ktiSelectHover");
        s.addClass("ktiSelect");  
//        s.css("border-left-color", "#8E8E8E");
//        s.css("border-top-color", "#8E8E8E");
//        s.css("border-right-color", "#B8B8B8");
//        s.css("border-bottom-color", "#B8B8B8");
//        s.css("color", "black");
    });

    $(".ktiDateTextBox").hover(
    function () {
        var s = $(this);
        s.removeClass("ktiDateTextBox");
        s.addClass("ktiDateTextBoxHover");
    },
    function () {
        var s = $(this);
        s.removeClass("ktiDateTextBoxHover");
        s.addClass("ktiDateTextBox");  
//        s.css("border-left-color", "#8E8E8E");
//        s.css("border-top-color", "#8E8E8E");
//        s.css("border-right-color", "#B8B8B8");
//        s.css("border-bottom-color", "#B8B8B8");
//        s.css("color", "black");
    });

    /* Date Start */
    
    $(".ktiDateTextBox").each(function () {
        var txt = $(this)
        txt.DatePicker({
            format: 'd-m-Y',
            date: txt.val(),
            current: txt.val(),
            starts: 1,
            position: 'bottom',
            onChange: function (formated, dates) {
                txt.val(formated);
                txt.DatePickerHide();
                txt.focus();
            }
        });
    });

    /* Date End*/

    /* Temporary Requisition Date Start */

    $(".ktiDateTextBoxListview").each(function () {
        var txt = $(this)
        txt.DatePicker({
            format: 'd-m-Y',
            date: txt.val(),
            current: txt.val(),
            starts: 1,
            position: 'bottom',
            onChange: function (formated, dates) {
                txt.val(formated);
                txt.DatePickerHide();
                txt.focus();
            }
        });
    });

    /* Temporary Requisition Date End*/


    $(".productCategoryDiv a").css("color","#01354D");    

}

/*

$(function () 
{
    new Page().initPage();
    sh();
});

function sh() 
{
    if (document.getElementById('lblMessage').val() != "") 
    {
        document.getElementById('lblMessage').style.display = 'none'; return;
    }

    $('.mac').show(500, function() { window.setTimeout(function() { $('.mac').hide(500, function() { $('.mac').removeClass('mac'); }); }, 2000); });           
}*/