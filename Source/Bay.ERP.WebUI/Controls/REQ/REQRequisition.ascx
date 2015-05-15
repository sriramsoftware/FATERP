<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 04-Apr-2012, 09:57:10
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="REQRequisition.ascx.cs"
    Inherits="Bay.ERP.Web.UI.REQRequisitionControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    <asp:HyperLink CssClass="hypTableFormLeble" ID="hypProject" runat="server" Text="Project"
                        NavigateUrl="~/BD/BDProject.aspx" Target="_blank"></asp:HyperLink>
                    &nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlProjectID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                        ValidationGroup="REQRequisitionEntity" Width="236">
                    </asp:DropDownList>
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvProjectID" runat="server" ControlToValidate="ddlProjectID"
                        ErrorMessage="Please Select Project" ValidationGroup="REQRequisitionEntity" EnableViewState="False"
                        Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Requisition No&nbsp;:
                </div>
                <div class="TableFormContent waterMarkContainer">
                    <label class="watermarkLabel" for="txtRequisitionNo">
                        Enter Requisition No</label>
                    <asp:TextBox ID="txtRequisitionNo" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                        ReadOnly="true" ValidationGroup="REQRequisitionEntity" Width="230" />
                    <span class="RequiredField">*</span> <span>
                        <kti:SecureButton ID="btnGetRequisitionNo" Visible="false" Enabled="false" runat="server"
                            Text="Get Requistion No" ToolTip="Please Click To Get The Next Requisition Number."
                            UniqueKey="REQRequisitionControl_GetRequistionNo_key" OnClick="btnGetRequisitionNo_Click" /></span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvRequisitionNo" runat="server" ControlToValidate="txtRequisitionNo"
                        ErrorMessage="Please Enter Requisition No" ValidationGroup="REQRequisitionEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Requisition Date&nbsp;:
                </div>
                <div class="TableFormContent waterMarkContainer">
                    <label class="watermarkLabel" for="txtRequisitionDate">
                        Enter Requisition Date</label>
                    <asp:TextBox ID="txtRequisitionDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                        ValidationGroup="REQRequisitionEntity" Width="230" />
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvRequisitionDate" runat="server" ControlToValidate="txtRequisitionDate"
                        ErrorMessage="Please Enter Requisition Date" ValidationGroup="REQRequisitionEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revRequisitionDate" runat="server" ControlToValidate="txtRequisitionDate"
                        Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                        ValidationGroup="REQRequisitionEntity"></asp:RegularExpressionValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Remarks&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox ID="txtRemarks" TextMode="MultiLine" CssClass="ktiTextArea" Width="390"
                        Height="105" ClientIDMode="Static" runat="server" ValidationGroup="REQRequisitionEntity" />
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Requisition Status&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlRequisitionStatusID" CssClass="ktiSelect" ClientIDMode="Static"
                        Enabled="false" runat="server" ValidationGroup="REQRequisitionEntity" Width="236">
                    </asp:DropDownList>
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvRequisitionStatusID" runat="server" ControlToValidate="ddlRequisitionStatusID"
                        ErrorMessage="Please Select Requisition Status" ValidationGroup="REQRequisitionEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Cash Payment&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:CheckBox ID="chkIsCashPayment" runat="server" ClientIDMode="Static" ValidationGroup="REQRequisitionEntity" />
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        ID Materials&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:CheckBox ID="chkIsRCS" runat="server" ClientIDMode="Static" ValidationGroup="REQRequisitionEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
            <div class="TableRow" style="text-align: center;">
                <div class="TableFormLeble">
                    &nbsp;</div>
                <div class="TableFormContent">
                    <kti:SecureButton ID="btnSubmit" ValidationGroup="REQRequisitionEntity" OnClick="btnSave_Click"
                        runat="server" Text="Add" UniqueKey="REQRequisitionControl_Submit_key" />
                    <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click" runat="server"
                        Text="Add New" UniqueKey="REQRequisitionControl_AddNew_key" />
                    <kti:SecureButton ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear"
                        UniqueKey="REQRequisitionControl_Clear_key" />
                </div>
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
