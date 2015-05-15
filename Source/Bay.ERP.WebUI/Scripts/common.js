function hideMeClick(ctlId) {
    document.getElementById(ctlId).style.display = 'none';
}

function reRegisterjQueryFunctions() {
    $(document).ready(function () {
        ktiCommon();
        ktiWaterMark();
        ktiNumberTextBox();
        ktiDecimalTextBox();
        ktiListView();
       // GetTheTabsBound();
    });
}