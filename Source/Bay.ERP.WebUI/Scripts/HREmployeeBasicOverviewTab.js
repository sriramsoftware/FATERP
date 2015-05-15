$(document).ready(function () {
    var selectedIndex = 0;

    var url = new String(window.location);

    if (url.indexOf("HR/HREmployeeEditor.asp") != -1) {
        selectedIndex = 0;
    }
    else if (url.indexOf("HR/HREmployeeJobDescription.aspx") != -1) {
        selectedIndex = 1;
    }
    else if (url.indexOf("HR/HREmployeeConfidentialInfo.aspx") != -1) {
        selectedIndex = 2;
    }
    else if (url.indexOf("HR/HREmployeeSkillMap.aspx") != -1) {
        selectedIndex = 3;
    }
    else if (url.indexOf("HR/HREmployeeLanguageMap.aspx") != -1) {
        selectedIndex = 4;
    }
    else if (url.indexOf("HR/HREmployeeContactInfo.aspx") != -1) {
        selectedIndex = 5;
    }
    else if (url.indexOf("HR/HREmployeeAddressInfo.aspx") != -1) {
        selectedIndex = 6;
    }
    else if (url.indexOf("HR/HREmployeeBankAccountInformation.aspx") != -1) {
        selectedIndex = 7;
    }
    else if (url.indexOf("HR/HREmployeeEducation.aspx") != -1) {
        selectedIndex = 8;
    }
    else if (url.indexOf("HR/HREmployeeExperience.aspx") != -1) {
        selectedIndex = 9;
    }
    else if (url.indexOf("HR/HREmployeeDrivingLicenseInformation.aspx") != -1) {
        selectedIndex = 10;
    }
    else if (url.indexOf("HR/HREmployeeFamilyInfo.aspx") != -1) {
        selectedIndex = 11;
    }
    if (url.indexOf("HR/HREmployeePassportInformation.aspx") != -1) {
        selectedIndex = 12;
    }
    else if (url.indexOf("HR/HREmployeeVisaInfomation.aspx") != -1) {
        selectedIndex = 13;
    }
    else if (url.indexOf("HR/HREmployeeNotice.aspx") != -1) {
        selectedIndex = 14;
    }
    else if (url.indexOf("HR/HREmployeeDocument.aspx") != -1) {
        selectedIndex = 15;
    }
    else if (url.indexOf("HR/HREmployeeResume.aspx") != -1) {
        selectedIndex = 16;
    }
    else if (url.indexOf("HR/HREmployeeLoanApplication.aspx") != -1) {
        selectedIndex = 17;
    }
    else if (url.indexOf("HR/HREmployeeLeaveApplication.aspx") != -1) {
        selectedIndex = 18;
    }
    else if (url.indexOf("HR/HRMemberLeaveAccount.aspx") != -1) {
        selectedIndex = 19;
    }
    else if (url.indexOf("HR/HRDepartmentEmployeeMap.aspx") != -1) {
        selectedIndex = 20;
    }
    else if (url.indexOf("HR/HRAdditonalInformation.aspx") != -1) {
        selectedIndex = 21;
    }
    else if (url.indexOf("HR/HREmployeeEmergencyContactInfo.aspx") != -1) {
        selectedIndex = 22;
    }
    else if (url.indexOf("HR/HREmployeeAllowance.aspx") != -1) {
        selectedIndex = 23;
    }


    function getUrlVars() {
        var vars = [], hash;
        var hashes = window.location.href.slice(window.location.href.indexOf('?') + 1).split('&');
        for (var i = 0; i < hashes.length; i++) {
            hash = hashes[i].split('=');
            vars.push(hash[0]);
            vars[hash[0]] = hash[1];
        }
        return vars;
    }

    $("#HREmployeeBasicOverviewtabs").tabs({
        selected: selectedIndex,
        select: function (e, ui) {
            var employeeID = getUrlVars()["param"];
            if (ui.index == 0) {
                window.location.replace("/Bay.ERP.WebUI/HR/HREmployeeEditor.aspx?param=" + employeeID);
            }
            else if (ui.index == 1) {
                window.location.replace("/Bay.ERP.WebUI/HR/HREmployeeJobDescription.aspx?param=" + employeeID);
            }
            else if (ui.index == 2) {
                window.location.replace("/Bay.ERP.WebUI/HR/HREmployeeConfidentialInfo.aspx?param=" + employeeID);
            }
            else if (ui.index == 3) {
                window.location.replace("/Bay.ERP.WebUI/HR/HREmployeeSkillMap.aspx?param=" + employeeID);
            }
            else if (ui.index == 4) {
                window.location.replace("/Bay.ERP.WebUI/HR/HREmployeeLanguageMap.aspx?param=" + employeeID);
            }
            else if (ui.index == 5) {
                window.location.replace("/Bay.ERP.WebUI/HR/HREmployeeContactInfo.aspx?param=" + employeeID);
            }
            else if (ui.index == 6) {
                window.location.replace("/Bay.ERP.WebUI/HR/HREmployeeAddressInfo.aspx?param=" + employeeID);
            }
            else if (ui.index == 7) {
                window.location.replace("/Bay.ERP.WebUI/HR/HREmployeeBankAccountInformation.aspx?param=" + employeeID);
            }
            else if (ui.index == 8) {
                window.location.replace("/Bay.ERP.WebUI/HR/HREmployeeEducation.aspx?param=" + employeeID);
            }
            else if (ui.index == 9) {
                window.location.replace("/Bay.ERP.WebUI/HR/HREmployeeExperience.aspx?param=" + employeeID);
            }
            else if (ui.index == 10) {
                window.location.replace("/Bay.ERP.WebUI/HR/HREmployeeDrivingLicenseInformation.aspx?param=" + employeeID);
            }
            else if (ui.index == 11) {
                window.location.replace("/Bay.ERP.WebUI/HR/HREmployeeFamilyInfo.aspx?param=" + employeeID);
            }
            else if (ui.index == 12) {
                window.location.replace("/Bay.ERP.WebUI/HR/HREmployeePassportInformation.aspx?param=" + employeeID);
            }
            else if (ui.index == 13) {
                window.location.replace("/Bay.ERP.WebUI/HR/HREmployeeVisaInfomation.aspx?param=" + employeeID);
            }
            else if (ui.index == 14) {
                window.location.replace("/Bay.ERP.WebUI/HR/HREmployeeNotice.aspx?param=" + employeeID);
            }
            else if (ui.index == 15) {
                window.location.replace("/Bay.ERP.WebUI/HR/HREmployeeDocument.aspx?param=" + employeeID);
            }
            else if (ui.index == 16) {
                window.location.replace("/Bay.ERP.WebUI/HR/HREmployeeResume.aspx?param=" + employeeID);
            }
            else if (ui.index == 17) {
                window.location.replace("/Bay.ERP.WebUI/HR/HREmployeeLoanApplication.aspx?param=" + employeeID);
            }
            else if (ui.index == 18) {
                window.location.replace("/Bay.ERP.WebUI/HR/HREmployeeLeaveApplication.aspx?param=" + employeeID);
            }
            else if (ui.index == 19) {
                window.location.replace("/Bay.ERP.WebUI/HR/HRMemberLeaveAccount.aspx?param=" + employeeID);
            }
            else if (ui.index == 20) {
                window.location.replace("/Bay.ERP.WebUI/HR/HRDepartmentEmployeeMap.aspx?param=" + employeeID);
            }
            else if (ui.index == 21) {
                window.location.replace("/Bay.ERP.WebUI/HR/HRAdditonalInformation.aspx?param=" + employeeID);
            }
            else if (ui.index == 22) {
                window.location.replace("/Bay.ERP.WebUI/HR/HREmployeeEmergencyContactInfo.aspx?param=" + employeeID);
            }
            else if (ui.index == 23) {
                window.location.replace("/Bay.ERP.WebUI/HR/HREmployeeAllowance.aspx?param=" + employeeID);
            }

        }
    });
});