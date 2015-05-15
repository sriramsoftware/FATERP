$(document).ready(function () {
    ktiNumberTextBox();
    ktiNumberTextBoxListview();
    ktiNumberTextBoxSmall();
});

function ktiNumberTextBox() {
    $(".ktiNumberTextBox").hover(
                function () {
                    var numetikTextBox = $(this);
                    numetikTextBox.removeClass("ktiNumberTextBox");
                    numetikTextBox.addClass("ktiNumberTextBoxHover");
                },
                function () {
                    var numetikTextBox = $(this);
                    numetikTextBox.removeClass("ktiNumberTextBoxHover");
                    numetikTextBox.addClass("ktiNumberTextBox");
                });

    $(".ktiNumberTextBox").keypress(function (e) {
        var numetikTextBox = $(this);
        if (e.which != 8 && e.which != 0 && (e.which < 48 || e.which > 57)) {
            numetikTextBox.addClass("ktiNumberTextBoxAlert");
            setTimeout(function () {
                numetikTextBox.removeClass("ktiNumberTextBoxAlert");
                numetikTextBox.addClass("ktiNumberTextBox");
            }, 100);

            return false;
        }
    });
}

/*--------Listview TextBox  START-----------*/

function ktiNumberTextBoxListview() {
    $(".ktiNumberTextBoxListview").hover(
                function () {
                    var numetikTextBox = $(this);
                    numetikTextBox.removeClass("ktiNumberTextBoxListview");
                    numetikTextBox.addClass("ktiNumberTextBoxListview");
                },
                function () {
                    var numetikTextBox = $(this);
                    numetikTextBox.removeClass("ktiNumberTextBoxListview");
                    numetikTextBox.addClass("ktiNumberTextBoxListview");
                });

                $(".ktiNumberTextBoxListview").keypress(function (e) {
        var numetikTextBox = $(this);
        if (e.which != 8 && e.which != 0 && (e.which < 48 || e.which > 57)) {
            numetikTextBox.addClass("ktiNumberTextBoxListview");
            setTimeout(function () {
                numetikTextBox.removeClass("ktiNumberTextBoxListview");
                numetikTextBox.addClass("ktiNumberTextBoxListview");
            }, 100);

            return false;
        }
    });
}
/*--------Listview TextBox  END-----------*/

/*--------TextBox Small START-----------*/

function ktiNumberTextBoxSmall() {
    $(".ktiNumberTextBoxSmall").hover(
                function () {
                    var numetikTextBox = $(this);
                    numetikTextBox.removeClass("ktiNumberTextBoxSmall");
                    numetikTextBox.addClass("ktiNumberTextBoxSmallHover");
                },
                function () {
                    var numetikTextBox = $(this);
                    numetikTextBox.removeClass("ktiNumberTextBoxSmallHover");
                    numetikTextBox.addClass("ktiNumberTextBoxSmall");
                });

                $(".ktiNumberTextBoxSmall").keypress(function (e) {
        var numetikTextBox = $(this);
        if (e.which != 8 && e.which != 0 && (e.which < 48 || e.which > 57)) {
            numetikTextBox.addClass("ktiNumberTextBoxAlert");
            setTimeout(function () {
                numetikTextBox.removeClass("ktiNumberTextBoxAlert");
                numetikTextBox.addClass("ktiNumberTextBoxSmall");
            }, 100);

            return false;
        }
    });
}
/*--------TextBox Small  END-----------*/