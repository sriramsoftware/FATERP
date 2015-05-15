<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 30-Nov-2011, 02:49:46
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PRMPreBOQInfo.ascx.cs"
    Inherits="Bay.ERP.Web.UI.PRMPreBOQInfoControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Start Date&nbsp;:
                </div>
                <div class="TableFormContent waterMarkContainer">
                    <label class="watermarkLabel" for="txtStartDate">
                        Enter Start Date</label>
                    <asp:TextBox ID="txtStartDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox" ToolTip="Please Select The Date; By Default- Current Date! Format : DD-MM-YYYY"
                        ValidationGroup="PRMPreBOQEntity" Width="230" />
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvStartDate" runat="server" ControlToValidate="txtStartDate"
                        ErrorMessage="Please Enter Start Date" ValidationGroup="PRMPreBOQEntity" EnableViewState="False"
                        Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revStartDate" runat="server" ControlToValidate="txtStartDate"
                        Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                        ValidationGroup="PRMPreBOQEntity"></asp:RegularExpressionValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                <asp:HyperLink CssClass="hypTableFormLeble" ID="hypPreparedByMember" runat="server" Text="Prepared By" NavigateUrl="~/HR/HRMember.aspx" Target="_blank"></asp:HyperLink>
                       &nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlPreparedByMemberID" CssClass="ktiSelect" ClientIDMode="Static" ToolTip="Please Select The Pre-BOQ Prepared Person; By Default - Current Logged User"
                        runat="server" ValidationGroup="PRMPreBOQEntity" Width="236">
                    </asp:DropDownList>
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvPreparedByMemberID" runat="server" ControlToValidate="ddlPreparedByMemberID"
                        ErrorMessage="Please Select Prepared By Member" ValidationGroup="PRMPreBOQEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Remarks&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="390" Height="105" ClientIDMode="Static" ToolTip="Please Write Some Remarks!"
                        ID="txtRemarks" runat="server" ValidationGroup="PRMPreBOQEntity" />
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                <asp:HyperLink CssClass="hypTableFormLeble" ID="hypPreBOQStatus" runat="server" Text="Pre BOQStatus" NavigateUrl="~/MD/MDPreBOQStatus.aspx" Target="_blank" ToolTip="Please Select Pre-BOQ Status! e.g. In Process"></asp:HyperLink>
                       &nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlPreBOQStatusID" CssClass="ktiSelect" ClientIDMode="Static"
                        runat="server" ValidationGroup="PRMPreBOQEntity" Width="236">
                    </asp:DropDownList>
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvPreBOQStatusID" runat="server" ControlToValidate="ddlPreBOQStatusID"
                        ErrorMessage="Please Select Pre BOQStatus" ValidationGroup="PRMPreBOQEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100; display:none;">
                <div class="TableFormLeble" style="text-align: left;">
                    Is Removed&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:CheckBox ID="chkIsRemoved" runat="server" ClientIDMode="Static" ValidationGroup="PRMPreBOQEntity" />
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="text-align: center;">
                <div class="TableFormLeble">
                    &nbsp;</div>
                <div class="TableFormContent">
                    <kti:SecureButton ID="btnSubmit" ValidationGroup="PRMPreBOQEntity" OnClick="btnSave_Click"
                        runat="server" Text="Add" UniqueKey="PRMPreBOQInfoControl_Submit_key" />
                    <kti:SecureButton ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear"
                        UniqueKey="PRMPreBOQInfoControl_Clear_key" />
                    <br /><br />
                    <asp:Label ID="lblFormLock" runat="server" Text="Note: The Form has been Locked, no information can be changed." CssClass="msgLock"></asp:Label>
                </div>
            </div>
            <br />
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
