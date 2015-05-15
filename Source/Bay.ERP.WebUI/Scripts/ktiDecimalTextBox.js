$(document).ready(function () {
    ktiDecimalTextBox();
    ktiDecimalTextBoxListview();
});

function ktiDecimalTextBox() {
    $(".ktiDecimalTextBox").hover(
                function () {
                    var numetikTextBox = $(this);
                    numetikTextBox.removeClass("ktiDecimalTextBox");
                    numetikTextBox.addClass("ktiDecimalTextBoxHover");
                },
                function () {
                    var numetikTextBox = $(this);
                    numetikTextBox.removeClass("ktiDecimalTextBoxHover");
                    numetikTextBox.addClass("ktiDecimalTextBox");
                });

                $(".ktiDecimalTextBox").keypress(function (e) {
                    var numetikTextBox = $(this);
                    if (e.which == 46) {
                        if (numetikTextBox.val().split(".").length <= 1) {
                            return true;
                        }
                    }
                    if (e.which != 8 && e.which != 0 && (e.which < 48 || e.which > 57)) {
                        numetikTextBox.addClass("ktiDecimalTextBoxAlert");
                        setTimeout(function () {
                            numetikTextBox.removeClass("ktiDecimalTextBoxAlert");
                            numetikTextBox.addClass("ktiDecimalTextBox");
                        }, 100);

                        return false;
                    }
                });
            }


            /*--------Temporary Block for Requisition textBox  START-----------*/

            function ktiDecimalTextBoxListview() {
                $(".ktiDecimalTextBoxListview").hover(
                function () {
                    var numetikTextBox = $(this);
                    numetikTextBox.removeClass("ktiDecimalTextBoxListview");
                    numetikTextBox.addClass("ktiDecimalTextBoxListview");
                },
                function () {
                    var numetikTextBox = $(this);
                    numetikTextBox.removeClass("ktiDecimalTextBoxListview");
                    numetikTextBox.addClass("ktiDecimalTextBoxListview");
                });

                $(".ktiDecimalTextBoxListview").keypress(function (e) {
                    var numetikTextBox = $(this);
                    if (e.which == 46) {
                        if (numetikTextBox.val().split(".").length <= 1) {
                            return true;
                        }
                    }
                    if (e.which != 8 && e.which != 0 && (e.which < 48 || e.which > 57)) {
                        numetikTextBox.addClass("ktiDecimalTextBoxListview");
                        setTimeout(function () {
                            numetikTextBox.removeClass("ktiDecimalTextBoxListview");
                            numetikTextBox.addClass("ktiDecimalTextBoxListview");
                        }, 100);

                        return false;
                    }
                });
            }

            /*--------Temporary Block for Requisition textBox  END-----------*/