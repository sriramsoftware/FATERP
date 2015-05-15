$(document).ready(function () {
    var selectedIndex = 0;

    var url = new String(window.location);

    if (url.indexOf("CRM/CRMBuyerBasicInfo.aspx") != -1) {
        selectedIndex = 0;
    }
    else if (url.indexOf("CRM/CRMCommunication.aspx") != -1) {
        selectedIndex = 1;
    }
    else if (url.indexOf("CRM/CRMExistingBuyerBasicInfo.aspx") != -1) {
        selectedIndex = 2;
    }
//    else if (url.indexOf("Customer/MemberEducationalBackgroundInfo.aspx") != -1) {
//        selectedIndex = 3;
//    }
//    else if (url.indexOf("Customer/MemberSkillSet.aspx") != -1) {
//        selectedIndex = 4;
//    }
//    else if (url.indexOf("Customer/MemberLanguageInfo.aspx") != -1) {
//        selectedIndex = 5;
//    }
//    else if (url.indexOf("Product/MemberProduct.aspx") != -1) {
//        selectedIndex = 6;
//    }
//    else if (url.indexOf("BD/BDRegisteredMemberArticle.aspx") != -1) {
//        selectedIndex = 7;
//    }
//    else if (url.indexOf("Customer/MemberWatchList.aspx") != -1) {
//        selectedIndex = 8;
//    }
//    else if (url.indexOf("Customer/MemberProfile.aspx") != -1) {
//        selectedIndex = 9;
//    }
//    else if (url.indexOf("Customer/MemberGroup.aspx") != -1) {
//        selectedIndex = 10;
//    }
//    else if (url.indexOf("Customer/ChangePassword.aspx") != -1) {
//        selectedIndex = 11;
//    }


    $("#CRMOverviewtabs").tabs({
        selected: selectedIndex,
        select: function (e, ui) {
            if (ui.index == 0) {
                window.location.replace("/CRM/CRMBuyerBasicInfo.aspx");
            }
            else if (ui.index == 1) {
                window.location.replace("/CRM/CRMCommunication.aspx");
            }
            else if (ui.index == 2) {
                window.location.replace("/CRM/CRMExistingBuyerBasicInfo.aspx");
            }
//            else if (ui.index == 3) {
//                window.location.replace("/Customer/MemberEducationalBackgroundInfo.aspx");
//            }
//            else if (ui.index == 4) {
//                window.location.replace("/Customer/MemberSkillSet.aspx");
//            }
//            else if (ui.index == 5) {
//                window.location.replace("/Customer/MemberLanguageInfo.aspx");
//            }
//            else if (ui.index == 6) {
//                window.location.replace("/Product/MemberProduct.aspx");
//            }
//            else if (ui.index == 7) {
//                window.location.replace("/BD/BDRegisteredMemberArticle.aspx");
//            }
//            else if (ui.index == 8) {
//                window.location.replace("/Customer/MemberWatchList.aspx");
//            }
//            else if (ui.index == 9) {
//                window.location.replace("/Customer/MemberProfile.aspx");
//            }
//            else if (ui.index == 10) {
//                window.location.replace("/Customer/MemberGroup.aspx");
//            }
//            else if (ui.index == 11) {
//                window.location.replace("/Customer/ChangePassword.aspx");
//            }
        }
    });
});