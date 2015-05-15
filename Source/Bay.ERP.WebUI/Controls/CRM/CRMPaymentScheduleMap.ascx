<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 28-Apr-2013, 12:14:24
--%>




<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CRMPaymentScheduleMap.ascx.cs"
    Inherits="Bay.ERP.Web.UI.CRMPaymentScheduleMapControl" %>

<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <ajaxToolkit:CollapsiblePanelExtender ID="cpeEditor" runat="server" TargetControlID="pnlEditor"
            ExpandControlID="divCollapsControl" CollapseControlID="divCollapsControl" Collapsed="true"
            ImageControlID="imgExpandCollaps" CollapsedImage="~/Images/expand-plus.gif" ExpandedImage="~/Images/collapse-minus.gif"
            SuppressPostBack="false">
        </ajaxToolkit:CollapsiblePanelExtender>
        <asp:Panel ID="pnlCPEContent" runat="server" CssClass="pnlCPEContent">
            <div id="divCollapsControl" class="divCollapsControl">
                <div style="float: left; height: 16px; width: 16px;">
                    <asp:Image ID="imgExpandCollaps" ImageUrl="~/Images/expand-plus.gif" runat="server" />
                </div>
                <div style="float: left; padding-left: 3px;">
                    <asp:Label ID="lvlCollapsText" runat="server" Text="Add/Edit C RMPayment Schedule Map"></asp:Label>
                </div>
                <div style="clear: both;">
                </div>
            </div>
        </asp:Panel>
        <div>
            <asp:Panel ID="pnlEditor" runat="server" CssClass="pnlEditor">
                <div class="TableRow" style="text-align: left;" runat="server">
                    <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Link Payment Schedule Map&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlLinkPaymentScheduleMapID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="CRMPaymentScheduleMapEntity" Width="234">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Payment Schedule&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlPaymentScheduleID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="CRMPaymentScheduleMapEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvPaymentScheduleID" runat="server" ControlToValidate="ddlPaymentScheduleID"
                            ErrorMessage="Please Select Payment Schedule" ValidationGroup="CRMPaymentScheduleMapEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Installment Name&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtInstallmentName">
                            Enter Installment Name</label>
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtInstallmentName" runat="server" ValidationGroup="CRMPaymentScheduleMapEntity" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvInstallmentName" runat="server" ControlToValidate="txtInstallmentName"
                            ErrorMessage="Please Enter Installment Name" ValidationGroup="CRMPaymentScheduleMapEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Installment Due Date&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtInstallmentDueDate">
                            Enter Installment Due Date</label>
                        <asp:TextBox ID="txtInstallmentDueDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="CRMPaymentScheduleMapEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvInstallmentDueDate" runat="server" ControlToValidate="txtInstallmentDueDate"
                            ErrorMessage="Please Enter Installment Due Date" ValidationGroup="CRMPaymentScheduleMapEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revInstallmentDueDate" runat="server" ControlToValidate="txtInstallmentDueDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)\d\d$"
                            ValidationGroup="CRMPaymentScheduleMapEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Installment Due Date New&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtInstallmentDueDateNew" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="CRMPaymentScheduleMapEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revInstallmentDueDateNew" runat="server" ControlToValidate="txtInstallmentDueDateNew"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)\d\d$"
                            ValidationGroup="CRMPaymentScheduleMapEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Agreement&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlAgreementID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="CRMPaymentScheduleMapEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvAgreementID" runat="server" ControlToValidate="ddlAgreementID"
                            ErrorMessage="Please Select Agreement" ValidationGroup="CRMPaymentScheduleMapEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Agreement AAmount&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtAgreementAAmount" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="CRMPaymentScheduleMapEntity" Type="Number" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvAgreementAAmount" runat="server" ControlToValidate="txtAgreementAAmount" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="CRMPaymentScheduleMapEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Agreement BAmount&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtAgreementBAmount" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="CRMPaymentScheduleMapEntity" Type="Number" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvAgreementBAmount" runat="server" ControlToValidate="txtAgreementBAmount" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="CRMPaymentScheduleMapEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Agreement CAmount&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtAgreementCAmount" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="CRMPaymentScheduleMapEntity" Type="Number" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvAgreementCAmount" runat="server" ControlToValidate="txtAgreementCAmount" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="CRMPaymentScheduleMapEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Agreement DAmount&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtAgreementDAmount" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="CRMPaymentScheduleMapEntity" Type="Number" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvAgreementDAmount" runat="server" ControlToValidate="txtAgreementDAmount" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="CRMPaymentScheduleMapEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Agreement EAmount&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtAgreementEAmount" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="CRMPaymentScheduleMapEntity" Type="Number" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvAgreementEAmount" runat="server" ControlToValidate="txtAgreementEAmount" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="CRMPaymentScheduleMapEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Payment Due Date&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtPaymentDueDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="CRMPaymentScheduleMapEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revPaymentDueDate" runat="server" ControlToValidate="txtPaymentDueDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)\d\d$"
                            ValidationGroup="CRMPaymentScheduleMapEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Final Payment&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:CheckBox ID="chkFinalPayment" runat="server" ClientIDMode="Static" ValidationGroup="CRMPaymentScheduleMapEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Revised&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:CheckBox ID="chkRevised" runat="server" ClientIDMode="Static" ValidationGroup="CRMPaymentScheduleMapEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Revised IP&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtRevisedIP" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="CRMPaymentScheduleMapEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Last Revised By Employee&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlLastRevisedByEmployeeID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="CRMPaymentScheduleMapEntity" Width="234">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Last Revised Date&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtLastRevisedDate">
                            Enter Last Revised Date</label>
                        <asp:TextBox ID="txtLastRevisedDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="CRMPaymentScheduleMapEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvLastRevisedDate" runat="server" ControlToValidate="txtLastRevisedDate"
                            ErrorMessage="Please Enter Last Revised Date" ValidationGroup="CRMPaymentScheduleMapEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revLastRevisedDate" runat="server" ControlToValidate="txtLastRevisedDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)\d\d$"
                            ValidationGroup="CRMPaymentScheduleMapEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Remarks&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtRemarks" runat="server" ValidationGroup="CRMPaymentScheduleMapEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Create Date&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtCreateDate">
                            Enter Create Date</label>
                        <asp:TextBox ID="txtCreateDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="CRMPaymentScheduleMapEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvCreateDate" runat="server" ControlToValidate="txtCreateDate"
                            ErrorMessage="Please Enter Create Date" ValidationGroup="CRMPaymentScheduleMapEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revCreateDate" runat="server" ControlToValidate="txtCreateDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)\d\d$"
                            ValidationGroup="CRMPaymentScheduleMapEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Create By Employee&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlCreateByEmployeeID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="CRMPaymentScheduleMapEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvCreateByEmployeeID" runat="server" ControlToValidate="ddlCreateByEmployeeID"
                            ErrorMessage="Please Select Create By Employee" ValidationGroup="CRMPaymentScheduleMapEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        I P&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtIP">
                            Enter I P</label>
                        <asp:TextBox ID="txtIP" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="CRMPaymentScheduleMapEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvIP" runat="server" ControlToValidate="txtIP"
                            ErrorMessage="Please Enter I P" ValidationGroup="CRMPaymentScheduleMapEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="CRMPaymentScheduleMapEntity" OnClick="btnSave_Click"
                            runat="server" Text="Add" UniqueKey="CRMPaymentScheduleMapControl_Submit_key" />
                        <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click"
                            runat="server" Text="Add New" UniqueKey="CRMPaymentScheduleMapControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click"
                            runat="server" Text="Clear" UniqueKey="CRMPaymentScheduleMapControl_Clear_key" />
                    </div>
                </div>
                <br />
            </asp:Panel>
            <div class="listContentTitle">
                C RMPayment Schedule Map List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvCRMPaymentScheduleMap" runat="server" DataSourceID="odsCRMPaymentScheduleMap" OnItemCommand="lvCRMPaymentScheduleMap_ItemCommand">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi">
                                        Link Payment Schedule Map
                                    </td>
                                    <td class="hi">
                                        Payment Schedule
                                    </td>
                                    <td class="hi">
                                        Installment Name
                                    </td>
                                    <td class="hi">
                                        Installment Due Date
                                    </td>
                                    <td class="hi">
                                        Installment Due Date New
                                    </td>
                                    <td class="hi">
                                        Agreement
                                    </td>
                                    <td class="hi">
                                        Agreement AAmount
                                    </td>
                                    <td class="hi">
                                        Agreement BAmount
                                    </td>
                                    <td class="hi">
                                        Agreement CAmount
                                    </td>
                                    <td class="hi">
                                        Agreement DAmount
                                    </td>
                                    <td class="hi">
                                        Agreement EAmount
                                    </td>
                                    <td class="hi">
                                        Payment Due Date
                                    </td>
                                    <td class="hi">
                                        Final Payment
                                    </td>
                                    <td class="hi">
                                        Revised
                                    </td>
                                    <td class="hi">
                                        Revised IP
                                    </td>
                                    <td class="hi">
                                        Last Revised By Employee
                                    </td>
                                    <td class="hi">
                                        Last Revised Date
                                    </td>
                                    <td class="hi">
                                        Remarks
                                    </td>
                                    <td class="hi">
                                        Create Date
                                    </td>
                                    <td class="hi">
                                        Create By Employee
                                    </td>
                                    <td class="hi">
                                        I P
                                    </td>
                                    <td class="his">
                                        EDIT
                                    </td>
                                    <td class="his">
                                        DELETE
                                    </td>
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="rpb">
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr runat="server" id="itemPlaceholder">
                                </tr>
                                <tr>
                                    <td colspan="100%">
                                        <div class="lv-FooterContainer">
                                            <div class="lv-Footer">
                                                <asp:DataPager ID="dpListView" runat="server" PageSize="15">
                                                    <Fields>
                                                        <asp:NextPreviousPagerField ButtonType="Image" ButtonCssClass="lv-PagerItem" FirstPageImageUrl="~/Images/CustomListView/Default/FT.png"
                                                            PreviousPageImageUrl="~/Images/CustomListView/Default/PT.png" ShowFirstPageButton="true"
                                                            ShowPreviousPageButton="true" ShowNextPageButton="false" ShowLastPageButton="false" />
                                                        <asp:NumericPagerField ButtonType="Button" ButtonCount="10" NumericButtonCssClass="lv-PagerItemNumeric"
                                                            CurrentPageLabelCssClass="lv-PagerItemNumericCurrent" RenderNonBreakingSpacesBetweenControls="false" />
                                                        <asp:NextPreviousPagerField ButtonType="Image" ButtonCssClass="lv-PagerItem" NextPageImageUrl="~/Images/CustomListView/Default/NT.png"
                                                            LastPageImageUrl="~/Images/CustomListView/Default/LT.png" ShowFirstPageButton="false"
                                                            ShowPreviousPageButton="false" ShowNextPageButton="true" ShowLastPageButton="true"
                                                            RenderNonBreakingSpacesBetweenControls="true" />
                                                        <asp:TemplatePagerField>
                                                    <PagerTemplate>
                                                                <div class="lv-PagerCount">
                                                                    Items <span>
                                                                        <%# Container.StartRowIndex +1%></span> to <span>
                                                                            <%# (Container.StartRowIndex+Container.PageSize ) < Container.TotalRowCount ? (Container.StartRowIndex+Container.PageSize) : Container.TotalRowCount %></span>
                                                                    of <span>
                                                                        <%# Container.TotalRowCount%></span>
                                                                </div>
                                                            </PagerTemplate>
                                                        </asp:TemplatePagerField>
                                                    </Fields>
                                                </asp:DataPager>
                                            </div>
                                        </div>
                                    </td>
                                </tr>
                            </table>
                        </LayoutTemplate>
                        <ItemTemplate>
                            <tr class="r">
                                <td class="rp">
                                    &nbsp;
                                </td>
                                <td class="i">
                                    <%# Eval("LinkPaymentScheduleMapID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("PaymentScheduleID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("InstallmentName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("InstallmentDueDate") != null ? ((DateTime)Eval("InstallmentDueDate")).ToString("mm-dd-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("InstallmentDueDateNew") != null ? ((DateTime)Eval("InstallmentDueDateNew")).ToString("mm-dd-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("AgreementID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("AgreementAAmount")%>
                                </td>
                                <td class="i">
                                    <%# Eval("AgreementBAmount")%>
                                </td>
                                <td class="i">
                                    <%# Eval("AgreementCAmount")%>
                                </td>
                                <td class="i">
                                    <%# Eval("AgreementDAmount")%>
                                </td>
                                <td class="i">
                                    <%# Eval("AgreementEAmount")%>
                                </td>
                                <td class="i">
                                    <%# Eval("PaymentDueDate") != null ? ((DateTime)Eval("PaymentDueDate")).ToString("mm-dd-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("FinalPayment") != null ? (((Boolean)Eval("FinalPayment")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("Revised") != null ? (((Boolean)Eval("Revised")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("RevisedIP")%>
                                </td>
                                <td class="i">
                                    <%# Eval("LastRevisedByEmployeeID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("LastRevisedDate") != null ? ((DateTime)Eval("LastRevisedDate")).ToString("mm-dd-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CreateDate") != null ? ((DateTime)Eval("CreateDate")).ToString("mm-dd-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("CreateByEmployeeID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("IP")%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("PaymentScheduleMapID")%>' UniqueKey="CRMPaymentScheduleMap_lvCRMPaymentScheduleMap_Edit_key" />
                                </td>
                                <td class="i">
                            <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete C RMPayment Schedule Map?')"
                                        CommandArgument='<%#Eval("PaymentScheduleMapID")%>' UniqueKey="CRMPaymentScheduleMap_lvCRMPaymentScheduleMap_Edit_key"/>
                                </td>
                                <td class="rp">
                                    &nbsp;
                                </td>
                                <td class="rpb">
                                    &nbsp;
                                </td>
                            </tr>
                        </ItemTemplate>
                        <AlternatingItemTemplate>
                            <tr class="ar">
                                <td class="rp">
                                    &nbsp;
                                </td>
                                <td class="i">
                                    <%# Eval("LinkPaymentScheduleMapID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("PaymentScheduleID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("InstallmentName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("InstallmentDueDate") != null ? ((DateTime)Eval("InstallmentDueDate")).ToString("mm-dd-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("InstallmentDueDateNew") != null ? ((DateTime)Eval("InstallmentDueDateNew")).ToString("mm-dd-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("AgreementID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("AgreementAAmount")%>
                                </td>
                                <td class="i">
                                    <%# Eval("AgreementBAmount")%>
                                </td>
                                <td class="i">
                                    <%# Eval("AgreementCAmount")%>
                                </td>
                                <td class="i">
                                    <%# Eval("AgreementDAmount")%>
                                </td>
                                <td class="i">
                                    <%# Eval("AgreementEAmount")%>
                                </td>
                                <td class="i">
                                    <%# Eval("PaymentDueDate") != null ? ((DateTime)Eval("PaymentDueDate")).ToString("mm-dd-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("FinalPayment") != null ? (((Boolean)Eval("FinalPayment")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("Revised") != null ? (((Boolean)Eval("Revised")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("RevisedIP")%>
                                </td>
                                <td class="i">
                                    <%# Eval("LastRevisedByEmployeeID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("LastRevisedDate") != null ? ((DateTime)Eval("LastRevisedDate")).ToString("mm-dd-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CreateDate") != null ? ((DateTime)Eval("CreateDate")).ToString("mm-dd-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("CreateByEmployeeID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("IP")%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("PaymentScheduleMapID")%>' UniqueKey="CRMPaymentScheduleMap_lvCRMPaymentScheduleMap_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete C RMPayment Schedule Map?')"
                                        CommandArgument='<%#Eval("PaymentScheduleMapID")%>' UniqueKey="CRMPaymentScheduleMap_lvCRMPaymentScheduleMap_Edit_key"/>
                                </td>
                                <td class="rp">
                                    &nbsp;
                                </td>
                                <td class="rpb">
                                    &nbsp;
                                </td>
                            </tr>
                        </AlternatingItemTemplate>
                        <EmptyDataTemplate>
                            <div class="edr">
                                No Records Found To Display
                            </div>
                        </EmptyDataTemplate>
                    </asp:ListView>
                </div>
                <asp:ObjectDataSource ID="odsCRMPaymentScheduleMap" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.CRMPaymentScheduleMapDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsCRMPaymentScheduleMap_Selecting">
                    <SelectParameters>
                        <asp:Parameter Name="startRowIndex" Type="Int32" />
                        <asp:Parameter Name="pageSize" Type="Int32" />
                        <asp:Parameter Name="sortExpression" Type="String" />
                        <asp:Parameter Name="filterExpression" Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
