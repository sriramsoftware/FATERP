<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 23-Dec-2013, 01:17:51
--%>




<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HREmployeeEvaluationReport.ascx.cs" Inherits="Bay.ERP.Web.UI.HREmployeeEvaluationReportControl" %>

<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
       <%--<ajaxToolkit:CollapsiblePanelExtender ID="cpeEditor" runat="server" TargetControlID="pnlEditor"
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
                    <asp:Label ID="lvlCollapsText" runat="server" Text="Add/Edit Survey Master"></asp:Label>
                </div>
                <div style="clear: both;">
                </div>
            </div>
        </asp:Panel>--%>
        <div>
            <asp:Panel ID="pnlEditor" runat="server" CssClass="pnlEditor">
                <div class="TableRow" style="text-align: left;" runat="server">
                    <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right; width:235px;">
                        Employee Name&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <asp:TextBox CssClass="ktiTextBox" Width="230" ClientIDMode="Static"
                            ID="txtEmployeeName" runat="server" Enabled="false" ValidationGroup="HREmployeeEvaluationReportEntity" />
                        <span class="RequiredField">*</span>
                    </div>
                 </div>
                 <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right; width:235px;">
                        Employee Code&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <asp:TextBox CssClass="ktiTextBox" Enabled="false" Width="230" ClientIDMode="Static"
                            ID="txtEmployeeCode" runat="server" ValidationGroup="HREmployeeEvaluationReportEntity" />
                        <span class="RequiredField">*</span>
                    </div>
                 </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right; width:235px;">
                        EBR 1&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <asp:TextBox CssClass="ktiTextBox" Width="230" ClientIDMode="Static"
                            ID="txtTitle1" runat="server" ValidationGroup="HREmployeeEvaluationReportEntity" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvTitle1" runat="server" ControlToValidate="txtTitle1"
                            ErrorMessage="Please Enter Title1" ValidationGroup="HREmployeeEvaluationReportEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right; width:235px;">
                        Period&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <asp:TextBox CssClass="ktiTextBox" Width="230" ClientIDMode="Static"
                            ID="txtTitle1Column1" runat="server" ValidationGroup="HREmployeeEvaluationReportEntity" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvTitle1Column1" runat="server" ControlToValidate="txtTitle1Column1"
                            ErrorMessage="Please Enter Title1 Column1" ValidationGroup="HREmployeeEvaluationReportEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100; display:none;">
                    <div class="TableFormLeble" style="text-align: right; width:235px;">
                        Title1 Column2&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <asp:TextBox CssClass="ktiTextBox" Width="230" ClientIDMode="Static"
                            ID="txtTitle1Column2" runat="server" ValidationGroup="HREmployeeEvaluationReportEntity" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvTitle1Column2" runat="server" ControlToValidate="txtTitle1Column2"
                            ErrorMessage="Please Enter Title1 Column2" ValidationGroup="HREmployeeEvaluationReportEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100; display:none;">
                    <div class="TableFormLeble" style="text-align: right; width:235px;">
                        Title1 Category1&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <asp:TextBox CssClass="ktiTextBox" Width="230" ClientIDMode="Static"
                            ID="txtTitle1Category1" runat="server" ValidationGroup="HREmployeeEvaluationReportEntity" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvTitle1Category1" runat="server" ControlToValidate="txtTitle1Category1"
                            ErrorMessage="Please Enter Title1 Category1" ValidationGroup="HREmployeeEvaluationReportEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right; width:235px;">
                        Self&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <asp:TextBox CssClass="ktiTextBox" Width="230" ClientIDMode="Static"
                            ID="txtTitle1Category1Column1Value" runat="server" ValidationGroup="HREmployeeEvaluationReportEntity" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvTitle1Category1Column1Value" runat="server" ControlToValidate="txtTitle1Category1Column1Value"
                            ErrorMessage="Please Enter Title1 Category1 Column1 Value" ValidationGroup="HREmployeeEvaluationReportEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100; display:none;">
                    <div class="TableFormLeble" style="text-align: right; width:235px;">
                        Title1 Category1 Column2 Value&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <asp:TextBox CssClass="ktiTextBox" Width="230" ClientIDMode="Static"
                            ID="txtTitle1Category1Column2Value" runat="server" ValidationGroup="HREmployeeEvaluationReportEntity" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvTitle1Category1Column2Value" runat="server" ControlToValidate="txtTitle1Category1Column2Value"
                            ErrorMessage="Please Enter Title1 Category1 Column2 Value" ValidationGroup="HREmployeeEvaluationReportEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100; display:none;">
                    <div class="TableFormLeble" style="text-align: right; width:235px;">
                        Title1 Category2&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <asp:TextBox CssClass="ktiTextBox" Width="230" ClientIDMode="Static"
                            ID="txtTitle1Category2" runat="server" ValidationGroup="HREmployeeEvaluationReportEntity" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvTitle1Category2" runat="server" ControlToValidate="txtTitle1Category2"
                            ErrorMessage="Please Enter Title1 Category2" ValidationGroup="HREmployeeEvaluationReportEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right; width:235px;">
                        Supervisor&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <asp:TextBox CssClass="ktiTextBox" Width="230" ClientIDMode="Static"
                            ID="txtTitle1Category2Column1Value" runat="server" ValidationGroup="HREmployeeEvaluationReportEntity" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvTitle1Category2Column1Value" runat="server" ControlToValidate="txtTitle1Category2Column1Value"
                            ErrorMessage="Please Enter Title1 Category2 Column1 Value" ValidationGroup="HREmployeeEvaluationReportEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100; display:none;">
                    <div class="TableFormLeble" style="text-align: right; width:235px;">
                        Title1 Category2 Column2 Value&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <asp:TextBox CssClass="ktiTextBox" Width="230" ClientIDMode="Static"
                            ID="txtTitle1Category2Column2Value" runat="server" ValidationGroup="HREmployeeEvaluationReportEntity" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvTitle1Category2Column2Value" runat="server" ControlToValidate="txtTitle1Category2Column2Value"
                            ErrorMessage="Please Enter Title1 Category2 Column2 Value" ValidationGroup="HREmployeeEvaluationReportEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100; display:none;">
                    <div class="TableFormLeble" style="text-align: right; width:235px;">
                        Title2&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <asp:TextBox CssClass="ktiTextBox" Width="230" ClientIDMode="Static"
                            ID="txtTitle2" runat="server" ValidationGroup="HREmployeeEvaluationReportEntity" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvTitle2" runat="server" ControlToValidate="txtTitle2"
                            ErrorMessage="Please Enter Title2" ValidationGroup="HREmployeeEvaluationReportEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right; width:235px;">
                        PBR 1&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <asp:TextBox ID="txtTitle4Column1Value" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="HREmployeeEvaluationReportEntity" Width="210" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvTitle4Column1Value" runat="server" ControlToValidate="txtTitle4Column1Value"
                            ErrorMessage="Please Enter Title4 Column1 Value" ValidationGroup="HREmployeeEvaluationReportEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvTitle4Column1Value" runat="server" ControlToValidate="txtTitle4Column1Value" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="HREmployeeEvaluationReportEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right; width:235px;">
                        PBR 1 Period&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <asp:TextBox CssClass="ktiTextBox" Width="230" ClientIDMode="Static"
                            ID="txtTitle2Column1" runat="server" ValidationGroup="HREmployeeEvaluationReportEntity" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvTitle2Column1" runat="server" ControlToValidate="txtTitle2Column1"
                            ErrorMessage="Please Enter Title2 Column1" ValidationGroup="HREmployeeEvaluationReportEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100; display:none;">
                    <div class="TableFormLeble" style="text-align: right; width:235px;">
                        Title2 Category1&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <asp:TextBox CssClass="ktiTextBox" Width="230" ClientIDMode="Static"
                            ID="txtTitle2Category1" runat="server" ValidationGroup="HREmployeeEvaluationReportEntity" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvTitle2Category1" runat="server" ControlToValidate="txtTitle2Category1"
                            ErrorMessage="Please Enter Title2 Category1" ValidationGroup="HREmployeeEvaluationReportEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right; width:235px;">
                        PBR 1 Target&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <asp:TextBox CssClass="ktiTextBox" Width="230" ClientIDMode="Static"
                            ID="txtTitle2Category1Column1Value" runat="server" ValidationGroup="HREmployeeEvaluationReportEntity" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvTitle2Category1Column1Value" runat="server" ControlToValidate="txtTitle2Category1Column1Value"
                            ErrorMessage="Please Enter Title2 Category1 Column1 Value" ValidationGroup="HREmployeeEvaluationReportEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100; display:none;">
                    <div class="TableFormLeble" style="text-align: right; width:235px;">
                        Title2 Category1 Column2 Value&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <asp:TextBox CssClass="ktiTextBox" Width="230" ClientIDMode="Static"
                            ID="txtTitle2Category1Column2Value" runat="server" ValidationGroup="HREmployeeEvaluationReportEntity" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvTitle2Category1Column2Value" runat="server" ControlToValidate="txtTitle2Category1Column2Value"
                            ErrorMessage="Please Enter Title2 Category1 Column2 Value" ValidationGroup="HREmployeeEvaluationReportEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100; display:none;">
                    <div class="TableFormLeble" style="text-align: right; width:235px;">
                        Title2 Category2&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <asp:TextBox CssClass="ktiTextBox" Width="230" ClientIDMode="Static"
                            ID="txtTitle2Category2" runat="server" ValidationGroup="HREmployeeEvaluationReportEntity" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvTitle2Category2" runat="server" ControlToValidate="txtTitle2Category2"
                            ErrorMessage="Please Enter Title2 Category2" ValidationGroup="HREmployeeEvaluationReportEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right; width:235px;">
                        PBR 1 Cap&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">                        
                        <asp:TextBox CssClass="ktiTextBox" Width="230" ClientIDMode="Static"
                            ID="txtTitle2Category2Column1Value" runat="server" ValidationGroup="HREmployeeEvaluationReportEntity" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvTitle2Category2Column1Value" runat="server" ControlToValidate="txtTitle2Category2Column1Value"
                            ErrorMessage="Please Enter Title2 Category2 Column1 Value" ValidationGroup="HREmployeeEvaluationReportEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;display:none;">
                    <div class="TableFormLeble" style="text-align: right; width:235px;">
                        Title2 Category2 Column2 Value&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <asp:TextBox CssClass="ktiTextBox" Width="230" ClientIDMode="Static"
                            ID="txtTitle2Category2Column2Value" runat="server" ValidationGroup="HREmployeeEvaluationReportEntity" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvTitle2Category2Column2Value" runat="server" ControlToValidate="txtTitle2Category2Column2Value"
                            ErrorMessage="Please Enter Title2 Category2 Column2 Value" ValidationGroup="HREmployeeEvaluationReportEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;display:none;">
                    <div class="TableFormLeble" style="text-align: right; width:235px;">
                        Title3&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <asp:TextBox CssClass="ktiTextBox" Width="230" ClientIDMode="Static"
                            ID="txtTitle3" runat="server" ValidationGroup="HREmployeeEvaluationReportEntity" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvTitle3" runat="server" ControlToValidate="txtTitle3"
                            ErrorMessage="Please Enter Title3" ValidationGroup="HREmployeeEvaluationReportEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;display:none;">
                    <div class="TableFormLeble" style="text-align: right; width:235px;">
                        Title3 Column1&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <asp:TextBox CssClass="ktiTextBox" Width="230" ClientIDMode="Static"
                            ID="txtTitle3Column1" runat="server" ValidationGroup="HREmployeeEvaluationReportEntity" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvTitle3Column1" runat="server" ControlToValidate="txtTitle3Column1"
                            ErrorMessage="Please Enter Title3 Column1" ValidationGroup="HREmployeeEvaluationReportEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;display:none;">
                    <div class="TableFormLeble" style="text-align: right; width:235px;">
                        Title3 Category1&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <asp:TextBox CssClass="ktiTextBox" Width="230" ClientIDMode="Static"
                            ID="txtTitle3Category1" runat="server" ValidationGroup="HREmployeeEvaluationReportEntity" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvTitle3Category1" runat="server" ControlToValidate="txtTitle3Category1"
                            ErrorMessage="Please Enter Title3 Category1" ValidationGroup="HREmployeeEvaluationReportEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;display:none;">
                    <div class="TableFormLeble" style="text-align: right; width:235px;">
                        Title3 Category1 Column1 Value&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <asp:TextBox CssClass="ktiTextBox" Width="230" ClientIDMode="Static"
                            ID="txtTitle3Category1Column1Value" runat="server" ValidationGroup="HREmployeeEvaluationReportEntity" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvTitle3Category1Column1Value" runat="server" ControlToValidate="txtTitle3Category1Column1Value"
                            ErrorMessage="Please Enter Title3 Category1 Column1 Value" ValidationGroup="HREmployeeEvaluationReportEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;display:none;">
                    <div class="TableFormLeble" style="text-align: right; width:235px;">
                        Title3 Category1 Column2 Value&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <asp:TextBox CssClass="ktiTextBox" Width="230" ClientIDMode="Static"
                            ID="txtTitle3Category1Column2Value" runat="server" ValidationGroup="HREmployeeEvaluationReportEntity" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvTitle3Category1Column2Value" runat="server" ControlToValidate="txtTitle3Category1Column2Value"
                            ErrorMessage="Please Enter Title3 Category1 Column2 Value" ValidationGroup="HREmployeeEvaluationReportEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;display:none;">
                    <div class="TableFormLeble" style="text-align: right; width:235px;">
                        Title3 Category2&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <asp:TextBox CssClass="ktiTextBox" Width="230" ClientIDMode="Static"
                            ID="txtTitle3Category2" runat="server" ValidationGroup="HREmployeeEvaluationReportEntity" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvTitle3Category2" runat="server" ControlToValidate="txtTitle3Category2"
                            ErrorMessage="Please Enter Title3 Category2" ValidationGroup="HREmployeeEvaluationReportEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;display:none;">
                    <div class="TableFormLeble" style="text-align: right; width:235px;">
                        Title3 Category2 Column1 Value&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <asp:TextBox CssClass="ktiTextBox" Width="230" ClientIDMode="Static"
                            ID="txtTitle3Category2Column1Value" runat="server" ValidationGroup="HREmployeeEvaluationReportEntity" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvTitle3Category2Column1Value" runat="server" ControlToValidate="txtTitle3Category2Column1Value"
                            ErrorMessage="Please Enter Title3 Category2 Column1 Value" ValidationGroup="HREmployeeEvaluationReportEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;display:none;">
                    <div class="TableFormLeble" style="text-align: right; width:235px;">
                        Title3 Category2 Column2 Value&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <asp:TextBox  CssClass="ktiTextBox" Width="230" ClientIDMode="Static"
                            ID="txtTitle3Category2Column2Value" runat="server" ValidationGroup="HREmployeeEvaluationReportEntity" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvTitle3Category2Column2Value" runat="server" ControlToValidate="txtTitle3Category2Column2Value"
                            ErrorMessage="Please Enter Title3 Category2 Column2 Value" ValidationGroup="HREmployeeEvaluationReportEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;display:none;">
                    <div class="TableFormLeble" style="text-align: right; width:235px;">
                        Report Question1 Title&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtHRReportQuestion1Title" runat="server" ValidationGroup="HREmployeeEvaluationReportEntity" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvHRReportQuestion1Title" runat="server" ControlToValidate="txtHRReportQuestion1Title"
                            ErrorMessage="Please Enter Report Question1 Title" ValidationGroup="HREmployeeEvaluationReportEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right; width:235px;">
                        WHRL&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtHRReportQuestion1TitleValue" runat="server" ValidationGroup="HREmployeeEvaluationReportEntity" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvHRReportQuestion1TitleValue" runat="server" ControlToValidate="txtHRReportQuestion1TitleValue"
                            ErrorMessage="Please Enter Report Question1 Title Value" ValidationGroup="HREmployeeEvaluationReportEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                

                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right; width:235px;">
                        Actual Score&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <asp:TextBox ID="txtActualScoreValue" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="HREmployeeEvaluationReportEntity" Width="210" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvActualScoreValue" runat="server" ControlToValidate="txtActualScoreValue"
                            ErrorMessage="Please Enter Actual Score Value" ValidationGroup="HREmployeeEvaluationReportEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvActualScoreValue" runat="server" ControlToValidate="txtActualScoreValue" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="HREmployeeEvaluationReportEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right; width:235px;">
                        Score&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <asp:TextBox ID="txtScoreValue" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="HREmployeeEvaluationReportEntity" Width="210" />&nbsp;%
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvScoreValue" runat="server" ControlToValidate="txtScoreValue"
                            ErrorMessage="Please Enter Score Value" ValidationGroup="HREmployeeEvaluationReportEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvScoreValue" runat="server" ControlToValidate="txtScoreValue" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="HREmployeeEvaluationReportEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right; width:235px;">
                        Deducation of Score&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <asp:TextBox ID="txtDeducationValue" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="HREmployeeEvaluationReportEntity" Width="210" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvDeducationValue" runat="server" ControlToValidate="txtDeducationValue"
                            ErrorMessage="Please Enter Deducation Value" ValidationGroup="HREmployeeEvaluationReportEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvDeducationValue" runat="server" ControlToValidate="txtDeducationValue" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="HREmployeeEvaluationReportEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right; width:235px;">
                        Amount to be Paid&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <asp:TextBox ID="txtSupervisorNumberValue" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="HREmployeeEvaluationReportEntity" Width="210" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvSupervisorNumberValue" runat="server" ControlToValidate="txtSupervisorNumberValue"
                            ErrorMessage="Please Enter Supervisor Number Value" ValidationGroup="HREmployeeEvaluationReportEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvSupervisorNumberValue" runat="server" ControlToValidate="txtSupervisorNumberValue" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="HREmployeeEvaluationReportEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100; display:none;">
                    <div class="TableFormLeble" style="text-align: right; width:235px;">
                        Title4&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtTitle4">
                            Enter Title4</label>
                        <asp:TextBox CssClass="ktiTextBox" Width="230" ClientIDMode="Static"
                            ID="txtTitle4" runat="server" ValidationGroup="HREmployeeEvaluationReportEntity" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvTitle4" runat="server" ControlToValidate="txtTitle4"
                            ErrorMessage="Please Enter Title4" ValidationGroup="HREmployeeEvaluationReportEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                
                <div class="TableRow" style="width: 100;display:none;">
                    <div class="TableFormLeble" style="text-align: right; width:235px;">
                        Report Question2 Title&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtHRReportQuestion2Title">
                            Enter Report Question2 Title</label>
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtHRReportQuestion2Title" runat="server" ValidationGroup="HREmployeeEvaluationReportEntity" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvHRReportQuestion2Title" runat="server" ControlToValidate="txtHRReportQuestion2Title"
                            ErrorMessage="Please Enter Report Question2 Title" ValidationGroup="HREmployeeEvaluationReportEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right; width:235px;">
                        HR Report&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtHRReportQuestion2TitleValue" runat="server" ValidationGroup="HREmployeeEvaluationReportEntity" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvHRReportQuestion2TitleValue" runat="server" ControlToValidate="txtHRReportQuestion2TitleValue"
                            ErrorMessage="Please Enter Report Question2 Title Value" ValidationGroup="HREmployeeEvaluationReportEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                     <div class="TableFormLeble" style="width:235px;">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="HREmployeeEvaluationReportEntity" OnClick="btnSave_Click"
                            runat="server" Text="Add" UniqueKey="HREmployeeEvaluationReportControl_Submit_key"/>
                        <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click"
                            runat="server" Text="Add New" UniqueKey="HREmployeeEvaluationReportControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click"
                            runat="server" Text="Clear" UniqueKey="HREmployeeEvaluationReportControl_Clear_key" />
                        <asp:HyperLink ID="hypHRReport" runat="server" CssClass="CommonButtonLink" Text="HR Report"/>
                    </div>
                </div>
                <br />
            </asp:Panel>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
