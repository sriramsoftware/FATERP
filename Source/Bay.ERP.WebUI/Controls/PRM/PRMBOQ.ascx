<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 10-May-2012, 05:58:01
--%>




<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PRMBOQ.ascx.cs"
    Inherits="Bay.ERP.Web.UI.PRMBOQControl" %>

<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>        
        <div>
                <div class="TableRow" style="text-align: left;" runat="server">
                    <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
                </div>                               
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Start Date&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtStartDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="PRMBOQEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revStartDate" runat="server" ControlToValidate="txtStartDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="PRMBOQEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Prepared By&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlPreparedByMemberID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="PRMBOQEntity" Width="238">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvPreparedByMemberID" runat="server" ControlToValidate="ddlPreparedByMemberID"
                            ErrorMessage="Please Select Prepared By Member" ValidationGroup="PRMBOQEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Remarks&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="390" ClientIDMode="Static"
                            ID="txtRemarks" runat="server" ValidationGroup="PRMBOQEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        BOQ Status&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlBOQStatusID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="PRMBOQEntity" Width="238">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>                
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="PRMBOQEntity" OnClick="btnSave_Click"
                            runat="server" Text="Add" UniqueKey="PRMBOQControl_Submit_key" />                        
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click"
                            runat="server" Text="Clear" UniqueKey="PRMBOQControl_Clear_key" />
                              <br /><br />
                    <asp:Label ID="lblFormLock" runat="server" Text="Note: BOQ is not migrated yet." CssClass="msgLock"></asp:Label>
                    </div>
                </div>
                <br />
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
