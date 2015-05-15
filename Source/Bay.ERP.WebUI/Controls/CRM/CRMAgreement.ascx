<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 11-Apr-2013, 01:28:07
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CRMAgreement.ascx.cs"
    Inherits="Bay.ERP.Web.UI.CRMAgreementControl" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit.HTMLEditor"
    TagPrefix="HTMLEditor" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div id="Div1" class="TableRow" style="text-align: left;" runat="server">
            <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
        </div>
        <div>
            <asp:Wizard ID="wizAgreement" runat="server" Width="1100" OnNextButtonClick="wizAgreement_NextButtonClick" DisplaySideBar="False"
                OnFinishButtonClick="wizAgreement_FinishButtonClick" FinishCompleteButtonText="Finalize &amp; Sumit For Approval"
                StartNextButtonText="Compile">
                <WizardSteps>
                    <asp:WizardStep ID="agreementSetup" runat="server" Title="Setup">
                        <div>
                         <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                    <asp:HyperLink CssClass="hypTableFormLeble" ID="hypPaymentSchedule" runat="server" Text="Payment Schedule"
                            ></asp:HyperLink>
                            &nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlPaymentScheduleID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlPaymentScheduleID_SelectedIndexChanged"
                             ValidationGroup="CRMAgreementEntity" Width="234">
                        </asp:DropDownList>
                        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click"></asp:Button></span>
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
                                    <asp:DropDownList ID="ddlTemplateID" CssClass="ktiSelect" ClientIDMode="Static"
                                        runat="server" ValidationGroup="CRMAgreementEntity"
                                        Width="234">
                                    </asp:DropDownList>
                                    <span><asp:Button ID="btnLoad" runat="server" Text="Load" OnClick="btnLoad_Click"></asp:Button></span>
                                    <span style="background-color:Yellow;"><asp:HyperLink ID="hypAgreementVariablePopup" runat="server" Text="Agreement Variable" Visible="false"></asp:HyperLink></span>
                                    <span style="background-color:Yellow;"><asp:HyperLink ID="hypAgreementSpec" runat="server" Text="Agreement Specs Variable" Visible="false"></asp:HyperLink></span>
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
                                        ID="txtRemarks" runat="server" ValidationGroup="CRMAgreementEntity" />
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
                        <div class="TableRowAgreement" style="width: 100; border: 1px solid #DDDDDD; padding: 3px 215px 3px 230px;">
                            <div class="TableFormContentAgreement">
                                <asp:Label ID="lblTextView" runat="server"></asp:Label>
                            </div>
                            <div class="TableFormValidatorContent">
                            </div>
                            <br />
                            <br />
                            <hr />
                            <div style="text-align: center;">
                                <div class="TableRow" style="width: 100;">
                                    <div class="TableFormLeble" style="text-align: right;">
                                        Appr. Proc. Panel&nbsp;:
                                    </div>
                                    <div class="TableFormContent">
                                        <asp:DropDownList ID="ddlAPPanelID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                                            ValidationGroup="CRMAgreementApprovalEntity" Width="236">
                                        </asp:DropDownList>
                                        <span class="RequiredField">*</span>
                                    </div>
                                    <div class="TableFormValidatorContent">
                                        <asp:RequiredFieldValidator ID="rfvAPPanelID" runat="server" ControlToValidate="ddlAPPanelID"
                                            ErrorMessage="Please Select Approval Process Panel" ValidationGroup="CRMAgreementApprovalEntity"
                                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </asp:WizardStep>
                </WizardSteps>
                <StartNavigationTemplate>
                <asp:Button ID="btnSaveDraft" runat="server" CommandName="MoveNext" Text="Save Draft & Preview" OnClick="btnSaveDraft_Click"
                        ValidationGroup="CRMAgreementEntity" />
                    <asp:Button ID="StartNextButton" runat="server" CommandName="MoveNext" Text="Preview" Visible="false"
                        ValidationGroup="CRMAgreementEntity" />
                </StartNavigationTemplate>
                <FinishNavigationTemplate>
                
                    <asp:Button ID="FinishPreviousButton" runat="server" CausesValidation="False" CommandName="MovePrevious"
                        Text="Edit Again" />
                    <asp:Button ID="FinishButton" runat="server" CommandName="MoveComplete" Text="Finalize & Submit For Approval"
                        ValidationGroup="CRMAgreementApprovalEntity" />
                        <asp:Button ID="btnCancel" runat="server" CausesValidation="False" CommandName="CancelAgreement" OnClick="btnCancel_Click" OnClientClick="return confirm('Are you sure to delete Agreement?')" 
                        Text="Cancel Agreement" />
                </FinishNavigationTemplate>
                <SideBarStyle VerticalAlign="Top" />
            </asp:Wizard>
            <br />
            <asp:LinkButton ID="test" runat="server"></asp:LinkButton>
        </div>
        <ajaxToolkit:ModalPopupExtender ID="Panel2_ModalPopupExtender" runat="server" PopupControlID="Panel2"
                DynamicServicePath="" Enabled="false" TargetControlID="test" OkControlID="lnkTargetPopup"
                CancelControlID="btnPopupCancel" BackgroundCssClass="modalBackground">
            </ajaxToolkit:ModalPopupExtender>
            <div>
                <asp:Panel ID="Panel2" runat="server" Width="610" Height="470" BorderWidth="1" Style="display: none;">
                    <div class="modalPanelBackground">
                        <br />
                        <div class="TableRow" style="width: 100;">
                            <div class="TableFormLeble" style="text-align: left;">
                                &nbsp;
                            </div>
                            <div class="TableFormContent" style="text-align: right; padding-right: 14px;">
                                <asp:Button ID="btnPopupClose" CssClass="Panel-button" runat="server" Text="X"></asp:Button>
                            </div>
                        </div>
                        <table border="0" cellpadding="0" cellspacing="0" class="content-table" style="width: auto;
                            padding-left: 10px;">
                            <tr>
                                <th rowspan="3" class="sized">
                                    <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/shared/side_shadowleft.jpg"
                                        Width="20" Height="300" AlternateText="" />
                                </th>
                                <th class="topleft">
                                </th>
                                <td class="tbl-border-top">
                                    &nbsp;
                                </td>
                                <th class="topright">
                                </th>
                                <th rowspan="3" class="sized">
                                    <asp:Image ID="Image2" runat="server" ImageUrl="~/Images/shared/side_shadowright.jpg"
                                        Width="20" Height="300" AlternateText="" />
                                </th>
                            </tr>
                            <tr>
                                <td class="tbl-border-left">
                                </td>
                                <td>
                                    <div class="table-content" style="width: 500px;">
                                        <div class="page-content">
                                            <h1>
                                                Create New Node</h1>
                                            <div>
                                                <div class="TableRow" style="width: 500px;">
                                                    <div class="TableFormLeble" style="text-align: left;">
                                                        &nbsp;
                                                    </div>
                                                    <div class="TableFormContent" style="padding-top: 10px;">
                                                        <asp:Label ID="Label1" runat="server" Font-Bold="true"></asp:Label>
                                                    </div>
                                                </div>
                                                <div class="TableRow" style="width: 100;">
                                                    <div class="TableFormLeble" style="text-align: right;">
                                                        Name&nbsp;:
                                                    </div>
                                                    <div class="TableFormContent waterMarkContainer">
                                                        <label class="watermarkLabel" for="txtName">
                                                            Enter Name</label>
                                                        <asp:TextBox ID="txtName" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                                                            ValidationGroup="DMSDocumentNodeEntity" Width="230" />
                                                        <span class="RequiredField">*</span>
                                                    </div>
                                                    <div class="TableFormValidatorContent">
                                                        <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName"
                                                            ErrorMessage="Please Enter Name" ValidationGroup="DMSDocumentNodeEntity" EnableViewState="False"
                                                            Display="Dynamic"></asp:RequiredFieldValidator>
                                                    </div>
                                                </div>
                                                <br />
                                                <div>
                                                    N.B. This Tree is shared amongs the company.<br />
                                                    Please Create Node Carefully with meaningful names according to the SOP
                                                </div>
                                                <div class="TableRow" style="text-align: center;">
                                                    <div class="TableFormLeble">
                                                        &nbsp;</div>
                                                    <div class="TableFormContent">
                                                        <asp:LinkButton ID="lnkTargetPopup" runat="server"></asp:LinkButton>
                                                        <kti:SecureButton ID="btnSubmit" CssClass="Panel-button" ValidationGroup="DMSDocumentNodeEntity"
                                                            runat="server" Text="Create" UniqueKey="DMSDocumentNodeControl_Submit_key" />
                                                        <kti:SecureButton ID="btnPopupCancel" CssClass="Panel-button" runat="server" Text="Cancel"/>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="quick-links">
                                        </div>
                                        <div class="clear">
                                        </div>
                                    </div>
                                </td>
                                <td class="tbl-border-right">
                                </td>
                            </tr>
                            <tr>
                                <th class="sized bottomleft">
                                </th>
                                <td class="tbl-border-bottom">
                                    &nbsp;
                                </td>
                                <th class="sized bottomright">
                                </th>
                            </tr>
                        </table>
                    </div>
                </asp:Panel>
            </div>
    </ContentTemplate>
</asp:UpdatePanel>
