<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 B2B Solutions, info@b2b-erp.com.
 ©2006 – 2010.

 Code Generate Time - 22-Jan-2013, 03:28:28
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HREmployeeBasicOverview.ascx.cs"
    Inherits="Bay.ERP.Web.UI.HREmployeeBasicOverviewControl" %>
<%@ Register Src="~/Controls/HR/HREmployeeEditor.ascx" TagName="HREmployeeEditorEntity"
    TagPrefix="uc" %>
<style type="text/css">
    #tabs
    {
        padding: 0px;
        border: 0px solid;
        font-size: 11px;
    }
    #tab-contents
    {
        background-image: url(../Images/reza/box-mm.png);
        background-repeat: repeat-x repeat-y;
        background-repeat: repeat;
        border-left: 1px solid #aaaaaa;
        border-right: 1px solid #aaaaaa;
        border-bottom: 1px solid #aaaaaa;
        width: 100%;
        height: auto; /* min-height:400px;*/
    }
    
    .ui-corner-all, .ui-corner-bottom, .ui-corner-right, .ui-corner-br
    {
        border-bottom: 0px;
    }
</style>
<script type="text/javascript">
    function BindEvents() {
        $(document).ready(function () {
            $("#HREmployeeBasicOverviewtabs").tabs();
        });
    }
</script>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <script type="text/javascript">
            Sys.Application.add_load(BindEvents);
        </script>
        <div id="Div1" class="TableRow" style="text-align: left;" runat="server">
            <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
        </div>
        <div>
            <div id="HREmployeeBasicOverviewtabs">
                <ul>
                    <li><a href="#BasicInfo">Basic Info</a></li>
                    <li><a href="#JobDescription">Job Description</a></li>
                    <li><a href="#ConfidentialInfo">Personal Info</a></li>
                    <li><a href="#SkillInfo">Skill Info</a></li>
                    <li><a href="#LanguageInfo">Language Info</a></li>
                    <li><a href="#ContactInfo<">Contact Info</a></li>
                    <li><a href="#AddressInfo">Address Info</a></li>
                    <li><a href="#BankAccountInfo">Bank Account Info</a></li>
                    <li><a href="#EducationalInfo">Educational Info</a></li>
                    <li><a href="#ExperienceInfo">Experience Info</a></li>
                    <li><a href="#DrivingLicenseInfo">License Info</a></li>
                    <li><a href="#FamilyInfo">Family Info</a></li>
                    <li><a href="#PassportInfo">Passport Info</a></li>
                    <li><a href="#VisaInfo">Visa Info</a></li>
                    <li><a href="#NoticeInfo">Notice Info</a></li>
                    <li><a href="#DocumentInfo">Document Info</a></li>
                    <li><a href="#Resume">Resume</a></li>
                    <li><a href="#LoanApplication<">Loan Application</a></li>
                    <li><a href="#LeaveApplication">Leave Application</a></li>
                    <li><a href="#MemberLeaveAccount">Member Leave Account</a></li>
                    <li><a href="#DepartmentMap">Department Map</a></li>
                    <li><a href="#AdditionalInfo">Additional Info</a></li>
                    <li><a href="#EmergencyContact">Emergency Contact</a></li>
                    <li><a href="#Allowance">Allowance</a></li>
                </ul>
                <div id="BasicInfo">
                </div>
                <div id="JobDescription">
                </div>
                <div id="ConfidentialInfo">
                </div>
                <div id="SkillInfo">
                </div>
                <div id="LanguageInfo">
                </div>
                <div id="ContactInfo">
                </div>
                <div id="AddressInfo">
                </div>
                <div id="BankAccountInfo">
                </div>
                <div id="EducationalInfo">
                </div>
                <div id="ExperienceInfo">
                </div>
                <div id="DrivingLicenseInfo">
                </div>
                <div id="FamilyInfo">
                </div>
                <div id="PassportInfo">
                </div>
                <div id="VisaInfo">
                </div>
                <div id="NoticeInfo">
                </div>
                <div id="DocumentInfo">
                </div>
                <div id="Resume">
                </div>
                <div id="LoanApplication">
                </div>
                <div id="LeaveApplication">
                </div>
                <div id="MemberLeaveAccount">
                </div>
                <div id="AdditionalInfo">
                </div>
                <div id="DepartmentMap">
                </div>
                <div id="EmergencyContact">
                </div>
                <div id="Allowance">
                </div>
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
