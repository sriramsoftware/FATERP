<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 11-Apr-2013, 01:28:07
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CRMAgreementDetailsWithApproval.ascx.cs"
    Inherits="Bay.ERP.Web.UI.CRMAgreementDetailsWithApprovalControl" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit.HTMLEditor"
    TagPrefix="HTMLEditor" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div id="Div1" class="TableRow" style="text-align: left;" runat="server">
            <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
        </div>
        <div>
            <asp:Wizard ID="wizAgreement" runat="server" Width="1100" OnNextButtonClick="wizAgreement_NextButtonClick" ActiveStepIndex="1" OnPreviousButtonClick="wizAgreement_PreviousButtonClick" DisplaySideBar="False"
                OnFinishButtonClick="wizAgreement_FinishButtonClick" FinishCompleteButtonText="Finalize &amp; Sumit For Approval"
                StartNextButtonText="Compile">
                <WizardSteps>
                    <asp:WizardStep ID="agreementSetup" runat="server" Title="Setup">
                        <div>
                         <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Payment Schedule&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlPaymentScheduleID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="CRMAgreementEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvPaymentScheduleID" runat="server" ControlToValidate="ddlPaymentScheduleID"
                            ErrorMessage="Please Select Payment Schedule" ValidationGroup="CRMAgreementEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>

                            <div class="TableRow" style="width: 100;">
                                <div class="TableFormLeble" style="text-align: right;">
                                    Agreement Type&nbsp;:
                                </div>
                                <div class="TableFormContent">
                                    <asp:DropDownList ID="ddlAgreementTypeID" CssClass="ktiSelect" ClientIDMode="Static"
                                        runat="server" ValidationGroup="CRMAgreementEntity" Width="234">
                                    </asp:DropDownList>
                                    <span class="RequiredField">*</span>
                                </div>
                                <div class="TableFormValidatorContent">
                                    <asp:RequiredFieldValidator ID="rfvAgreementTypeID" runat="server" ControlToValidate="ddlAgreementTypeID"
                                        ErrorMessage="Please Select Agreement Type" ValidationGroup="CRMAgreementEntity"
                                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <div class="TableRow" style="width: 100;">
                                <div class="TableFormLeble" style="text-align: right;">
                                    Buyer Basic Info&nbsp;:
                                </div>
                                <div class="TableFormContent">
                                    <asp:DropDownList ID="ddlBuyerBasicInfoID" CssClass="ktiSelect" ClientIDMode="Static"
                                        runat="server" ValidationGroup="CRMAgreementEntity" Width="234">
                                    </asp:DropDownList>
                                    <span class="RequiredField">*</span>
                                </div>
                                <div class="TableFormValidatorContent">
                                    <asp:RequiredFieldValidator ID="rfvBuyerBasicInfoID" runat="server" ControlToValidate="ddlBuyerBasicInfoID"
                                        ErrorMessage="Please Select Buyer Basic Info" ValidationGroup="CRMAgreementEntity"
                                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <div class="TableRow" style="width: 100;">
                                <div class="TableFormLeble" style="text-align: right;">
                                    Project&nbsp;:
                                </div>
                                <div class="TableFormContent">
                                    <asp:DropDownList ID="ddlProjectID" CssClass="ktiSelect" ClientIDMode="Static" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlProjectID_SelectedIndexChanged"
                                        ValidationGroup="CRMAgreementEntity" Width="234">
                                    </asp:DropDownList>
                                    <span class="RequiredField">*</span>
                                </div>
                                <div class="TableFormValidatorContent">
                                    <asp:RequiredFieldValidator ID="rfvProjectID" runat="server" ControlToValidate="ddlProjectID"
                                        ErrorMessage="Please Select Project" ValidationGroup="CRMAgreementEntity" EnableViewState="False"
                                        Display="Dynamic"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <div class="TableRow" style="width: 100;">
                                <div class="TableFormLeble" style="text-align: right;">
                                    Project Floor Unit&nbsp;:
                                </div>
                                <div class="TableFormContent">
                                    <asp:DropDownList ID="ddlProjectFloorUnitID" CssClass="ktiSelect" ClientIDMode="Static"
                                        runat="server" ValidationGroup="CRMAgreementEntity" Width="234">
                                    </asp:DropDownList>
                                    <span class="RequiredField">*</span>
                                </div>
                                <div class="TableFormValidatorContent">
                                    <asp:RequiredFieldValidator ID="rfvProjectFloorUnitID" runat="server" ControlToValidate="ddlProjectFloorUnitID"
                                        ErrorMessage="Please Select Project Floor Unit" ValidationGroup="CRMAgreementEntity"
                                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <div class="TableRow" style="width: 100;">
                                <div class="TableFormLeble" style="text-align: right;">
                                    Template Name&nbsp;:
                                </div>
                                <div class="TableFormContent">
                                    <asp:DropDownList ID="ddlTemplateID" CssClass="ktiSelect" ClientIDMode="Static" AutoPostBack="true"
                                        OnSelectedIndexChanged="ddlTemplateID_SelectedIndexChanged" runat="server" ValidationGroup="CRMAgreementEntity"
                                        Width="234">
                                    </asp:DropDownList>
                                     <span><asp:HyperLink ID="hypAgreementVariablePopup" runat="server" Text="Agreement Variable" NavigateUrl="~/MD/CRMMDAgreementVariable.aspx" Target="_blank"></asp:HyperLink></span>
                                </div>
                                <div class="TableFormValidatorContent">
                                </div>
                            </div>
                            <div class="TableRow" style="width: 100;">
                                <div class="TableFormLeble" style="text-align: right;">
                                    Text&nbsp;:
                                </div>
                                <div class="TableFormContent">
                                    <HTMLEditor:Editor runat="server" ID="txtText" Height="530px" AutoFocus="true" Width="100%"
                                        ValidationGroup="CRMAgreementEntity" />
                                    <span class="RequiredField">*</span>
                                </div>
                                <div class="TableFormValidatorContent">
                                    <asp:RequiredFieldValidator ID="rfvText" runat="server" ControlToValidate="txtText"
                                        ErrorMessage="Please Enter Text" ValidationGroup="CRMAgreementEntity" EnableViewState="False"
                                        Display="Dynamic"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <div class="TableRow" style="width: 100;">
                                <div class="TableFormLeble" style="text-align: right;">
                                    Agreement Date&nbsp;:
                                </div>
                                <div class="TableFormContent">
                                    <asp:TextBox ID="txtAgreementDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                                        ValidationGroup="CRMAgreementEntity" Width="230" />
                                </div>
                                <div class="TableFormValidatorContent">
                                    <asp:RegularExpressionValidator ID="revAgreementDate" runat="server" ControlToValidate="txtAgreementDate"
                                        Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                                        ValidationGroup="CRMAgreementEntity"></asp:RegularExpressionValidator>
                                </div>
                            </div>
                            <div class="TableRow" style="width: 100;">
                                <div class="TableFormLeble" style="text-align: right;">
                                    Sign Date&nbsp;:
                                </div>
                                <div class="TableFormContent">
                                    <asp:TextBox ID="txtSignDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                                        ValidationGroup="CRMAgreementEntity" Width="230" />
                                </div>
                                <div class="TableFormValidatorContent">
                                    <asp:RegularExpressionValidator ID="revSignDate" runat="server" ControlToValidate="txtSignDate"
                                        Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                                        ValidationGroup="CRMAgreementEntity"></asp:RegularExpressionValidator>
                                </div>
                            </div>
                            <div class="TableRow" style="width: 100;">
                                <div class="TableFormLeble" style="text-align: right;">
                                    Execute Date&nbsp;:
                                </div>
                                <div class="TableFormContent">
                                    <asp:TextBox ID="txtExecuteDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                                        ValidationGroup="CRMAgreementEntity" Width="230" />
                                </div>
                                <div class="TableFormValidatorContent">
                                    <asp:RegularExpressionValidator ID="revExecuteDate" runat="server" ControlToValidate="txtExecuteDate"
                                        Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                                        ValidationGroup="CRMAgreementEntity"></asp:RegularExpressionValidator>
                                </div>
                            </div>
                            <div class="TableRow" style="width: 100;">
                                <div class="TableFormLeble" style="text-align: right;">
                                    Remarks&nbsp;:
                                </div>
                                <div class="TableFormContent">
                                    <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                                        ID="txtWizardRemarks" runat="server" ValidationGroup="CRMAgreementEntity" />
                                </div>
                                <div class="TableFormValidatorContent">
                                </div>
                            </div>
                            <div class="TableRow" style="width: 100;">
                                <div class="TableFormLeble" style="text-align: right;">
                                    Approval Status&nbsp;:
                                </div>
                                <div class="TableFormContent">
                                    <asp:DropDownList ID="ddlAgreementApprovalStatusID" CssClass="ktiSelect" ClientIDMode="Static"
                                        Enabled="false" runat="server" ValidationGroup="CRMAgreementEntity" Width="234">
                                    </asp:DropDownList>
                                    <span class="RequiredField">*</span>
                                </div>
                                <div class="TableFormValidatorContent">
                                    <asp:RequiredFieldValidator ID="rfvAgreementApprovalStatusID" runat="server" ControlToValidate="ddlAgreementApprovalStatusID"
                                        ErrorMessage="Please Select Agreement Approval Status" ValidationGroup="CRMAgreementEntity"
                                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                        </div>
                    </asp:WizardStep>
                    <asp:WizardStep ID="agreementFinalize" runat="server" Title="Finalize">
                    <div style="float:right;">
                    <asp:HyperLink ID="hypAgreementVariableMap" runat="server" Text="Agreement Variable Map" Target="_blank" ></asp:HyperLink>
                    <asp:HyperLink ID="hypConvertToPdf" runat="server" Text="Convert To Pdf" Visible="false"></asp:HyperLink>
                    </div>
                    <br />
                    <br />
                    
                    
                        <div class="TableRowAgreement" style="width: 100; border: 1px solid #DDDDDD; padding: 3px 200px 3px 230px;">
                            <div class="TableFormContentAgreement">
                                <asp:Label ID="lblTextView" runat="server"></asp:Label>
                            </div>
                            <div class="TableFormValidatorContent">
                            </div>
                        </div>
                    </asp:WizardStep>
                </WizardSteps>
                <StartNavigationTemplate>
                    <asp:Button ID="StartNextButton" runat="server" CommandName="MoveNext" Text="Compile"
                        ValidationGroup="CRMAgreementEntity" />
                </StartNavigationTemplate>
                <FinishNavigationTemplate>
                    <asp:Button ID="FinishPreviousButton" runat="server" CausesValidation="False" CommandName="MovePrevious"
                        Text="Previous" />
                    <asp:Button ID="FinishButton" runat="server" CommandName="MoveComplete" Text="Update"
                        ValidationGroup="CRMAgreementApprovalEntity" />
                </FinishNavigationTemplate>
                <SideBarStyle VerticalAlign="Top" />
            </asp:Wizard>
            <br />
            <div id="commentboxholder">
                <div id="commentbox" >
                    <div style="width: 550px; text-align: center;">
                        <h3>
                            Approval Process Panel</h3>
                    </div>
                    <br />
                    <div style="width: 650px;">
                        <div style="width: 120px; float: left; font-weight: bold;">
                            Action
                        </div>
                        <div style="width: 10px; float: left; font-weight: bold;">
                            :</div>
                        <div style="width: 46%; float: left;">
                            <asp:DropDownList ID="ddlAction" runat="server" ClientIDMode="Static" CssClass="ktiSelect"
                                Width="236">
                            </asp:DropDownList>
                        </div>
                        <div style="clear: both;">
                        </div>
                        <br />
                    </div>
                    <div id="trRemarks" style="width: 650px;">
                        <div style="width: 120px; float: left; font-weight: bold;">
                            Remarks
                        </div>
                        <div style="width: 10px; float: left; font-weight: bold;">
                            :</div>
                        <div style="width: 480px; float: left;">
                            <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="384" ClientIDMode="Static"
                                ID="txtRemarks" runat="server" />
                        </div>
                        <div style="clear: both;">
                        </div>
                        <br />
                    </div>
                    <div id="trRejectTo" style="width: 650px;">
                        <div style="width: 120px; float: left; font-weight: bold;">
                            Reject To
                        </div>
                        <div style="width: 10px; float: left; font-weight: bold;">
                            :</div>
                        <div style="width: 480px; float: left;">
                            <asp:DropDownList ID="ddlRejectTo" runat="server" ClientIDMode="Static" CssClass="ktiSelect"
                                Width="236">
                            </asp:DropDownList>
                        </div>
                        <div style="clear: both;">
                        </div>
                        <br />
                    </div>
                    <div id="trForwardTo" style="width: 650px;">
                        <div style="width: 120px; float: left; font-weight: bold;">
                            Forward To
                        </div>
                        <div style="width: 10px; float: left; font-weight: bold;">
                            :</div>
                        <div style="width: 480px; float: left;">
                            <asp:DropDownList ID="ddlForwardTo" runat="server" ClientIDMode="Static" CssClass="ktiSelect"
                                Width="236">
                            </asp:DropDownList>
                        </div>
                        <div style="clear: both;">
                        </div>
                        <br />
                    </div>
                    <div id="trForwardRemarks" style="width: 650px;">
                        <div style="width: 120px; float: left; font-weight: bold;">
                            Forward Remarks
                        </div>
                        <div style="width: 10px; float: left; font-weight: bold;">
                            :</div>
                        <div style="width: 480px; float: left;">
                            <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="384" ClientIDMode="Static"
                                ID="txtForwardRemarks" runat="server" />
                        </div>
                        <div style="clear: both;">
                        </div>
                        <br />
                    </div>
                    <div id="trComment" style="width: 650px;">
                        <div style="width: 120px; float: left; font-weight: bold;">
                            Comment
                        </div>
                        <div style="width: 10px; float: left; font-weight: bold;">
                            :</div>
                        <div style="width: 480px; float: left;">
                            <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="384" ClientIDMode="Static"
                                ID="txtComment" runat="server" />
                        </div>
                        <div style="clear: both;">
                        </div>
                        <br />
                    </div>
                    <div id="trbtnApprove" style="width: 650px;">
                        <div style="width: 120px; float: left; font-weight: bold;">
                            &nbsp;
                        </div>
                        <div style="width: 10px; float: left; font-weight: bold;">
                        </div>
                        <div style="width: 480px; float: left; padding-left: 10px;">
                            <asp:Button ID="btnApprove" ValidationGroup="None" runat="server" Text="Approve"
                                UniqueKey="CRMAgreementDetailsWithApprovalControl_Approve_key" OnClick="btnApprove_Click" />
                        </div>
                        <div style="clear: both;">
                        </div>
                        <br />
                    </div>
                    <div id="trbtnReject" style="width: 650px;">
                        <div style="width: 120px; float: left; font-weight: bold;">
                            &nbsp;
                        </div>
                        <div style="width: 10px; float: left; font-weight: bold;">
                        </div>
                        <div style="width: 480px; float: left; padding-left: 10px;">
                            <asp:Button ID="btnReject" ValidationGroup="None" runat="server" Text="Reject"
                                UniqueKey="CRMAgreementDetailsWithApprovalControl_Reject_key" OnClick="btnReject_Click" />
                        </div>
                        <div style="clear: both;">
                        </div>
                        <br />
                    </div>
                    <div id="trbtnForward" style="width: 650px;">
                        <div style="width: 120px; float: left; font-weight: bold;">
                            &nbsp;
                        </div>
                        <div style="width: 10px; float: left; font-weight: bold;">
                        </div>
                        <div style="width: 480px; float: left; padding-left: 10px;">
                            <asp:Button ID="btnForward" ValidationGroup="None" runat="server" Text="Forward"
                                UniqueKey="CRMAgreementDetailsWithApprovalControl_Forward_key" OnClick="btnForward_Click" />
                        </div>
                        <div style="clear: both;">
                        </div>
                        <br />
                    </div>
                    <div id="trbtnSubmitComment" style="width: 650px;">
                        <div style="width: 120px; float: left; font-weight: bold;">
                            &nbsp;
                        </div>
                        <div style="width: 10px; float: left; font-weight: bold;">
                        </div>
                        <div style="width: 480px; float: left; padding-left: 10px;">
                            <asp:Button ID="btnSubmitComment" ValidationGroup="None" runat="server" Text="Submit Comment"
                                UniqueKey="CRMAgreementDetailsWithApprovalControl_SubmitComment_key" OnClick="btnSubmitComment_Click" />
                        </div>
                        <div style="clear: both;">
                        </div>
                        <br />
                    </div>
                    <div style="width: 550px;">
                        <div style="width: 510px; margin: 10px; padding: 10px;">
                            <div style="padding-bottom: 15px;">
                                <h3 style="color: #4B4B4B;">
                                    All Remarks By Panel Members:</h3>
                            </div>
                            <div>
                                <asp:ListView ID="lvAPMemberFeedbackRemarks" runat="server" OnItemDataBound="lvAPMemberFeedbackRemarks_ItemDataBound">
                                    <LayoutTemplate>
                                        <div runat="server" id="itemPlaceholder">
                                        </div>
                                    </LayoutTemplate>
                                    <ItemTemplate>
                                        <div style="padding-bottom: 20px;">
                                            <div style="padding-bottom: 3px;">
                                                <table cellpadding="0" cellspacing="0" width="100%">
                                                    <tr>
                                                        <td align="left">
                                                            <b>
                                                                <%# (Int64)Eval("APFeedbackID") == Bay.ERP.Web.UI.MasterDataConstants.APFeedback.APPROVED ? ("<span style='color: green;'>" + Eval("APFeedbackName") + "</span>") : ("") %>
                                                                <%# (Int64)Eval("APFeedbackID") == Bay.ERP.Web.UI.MasterDataConstants.APFeedback.REJECTED ? ("<span style='color: Red;'>" + Eval("APFeedbackName") + "</span>") : ("")%>
                                                                <%# (Int64)Eval("APFeedbackID") == Bay.ERP.Web.UI.MasterDataConstants.APFeedback.FORWARDED ? ("<span style='color: Blue;'>" + Eval("APFeedbackName") + "</span>") : ("")%>
                                                                <%# (Int64)Eval("APFeedbackID") == Bay.ERP.Web.UI.MasterDataConstants.APFeedback.FORWARD_RESPONSE_RECEIVED ? ("<span style='color: Blue;'>" + Eval("APFeedbackName") + "</span>") : ("")%>
                                                            </b><span style='color: gray;'><i>by <b>
                                                                <%# Eval("MemberFullName")%></b></i></span>
                                                        </td>
                                                        <td align="right">
                                                            on <b>
                                                                <%# Eval("RemarksDateTime") !=  null ? ((DateTime)Eval("RemarksDateTime")).ToString(Bay.ERP.Web.UI.UIConstants.SHORT_DATE_FORMAT) : ""%></b>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </div>
                                            <div style="border-top: 1px solid gray; height: 1px; width: 100%;">
                                            </div>
                                            <div style="text-align: justify; letter-spacing: 0px; word-spacing: 0px; line-height: 18px;
                                                color: #4B4B4B; font-size: 12px; font-family: 'Verdana'; padding-top: 3px;">
                                                <%# Eval("Remarks")%>
                                            </div>
                                            <div id="forwardInfoDiv" runat="server">
                                            </div>
                                        </div>
                                    </ItemTemplate>
                                </asp:ListView>
                            </div>
                        </div>
                    </div>
                    <br />
                    <br />
                </div>
            </div>
        </div>
        
        <script type="text/javascript">
            $(function () {
                function manageActionOptions(selectedAction) {
                    if (selectedAction == 1) {
                        $('#trRemarks').show();
                        $('#trRejectTo').hide();
                        $('#trForwardTo').hide();
                        $('#trForwardRemarks').hide();
                        $('#trComment').hide();
                        $('#trbtnApprove').show();
                        $('#trbtnReject').hide();
                        $('#trbtnForward').hide();
                        $('#trbtnSubmitComment').hide();
                    }
                    else if (selectedAction == 2) {
                        $('#trRemarks').show();
                        $('#trRejectTo').show();
                        $('#trForwardTo').hide();
                        $('#trForwardRemarks').hide();
                        $('#trComment').hide();
                        $('#trbtnApprove').hide();
                        $('#trbtnReject').show();
                        $('#trbtnForward').hide();
                        $('#trbtnSubmitComment').hide();
                    }
                    else if (selectedAction == 3) {
                        $('#trRemarks').show();
                        $('#trRejectTo').hide();
                        $('#trForwardTo').show();
                        $('#trForwardRemarks').show();
                        $('#trComment').hide();
                        $('#trbtnApprove').hide();
                        $('#trbtnReject').hide();
                        $('#trbtnForward').show();
                        $('#trbtnSubmitComment').hide();
                    }
                    else if (selectedAction == 4) {
                        $('#trRemarks').hide();
                        $('#trRejectTo').hide();
                        $('#trForwardTo').hide();
                        $('#trForwardRemarks').hide();
                        $('#trComment').show();
                        $('#trbtnApprove').hide();
                        $('#trbtnReject').hide();
                        $('#trbtnForward').hide();
                        $('#trbtnSubmitComment').show();
                    }
                }

                function CurrentPageLoad() {

                    $('#ddlAction').change(function () {

                        var selectedAction = $('#ddlAction').val();
                        manageActionOptions(selectedAction);
                    });

                    manageActionOptions($('#ddlAction').val());
                }

                CurrentPageLoad();

                var prm = Sys.WebForms.PageRequestManager.getInstance();
                prm.add_endRequest(function () {
                    $(function () {
                        CurrentPageLoad();
                    });
                });
            });
        </script>
    </ContentTemplate>
</asp:UpdatePanel>
