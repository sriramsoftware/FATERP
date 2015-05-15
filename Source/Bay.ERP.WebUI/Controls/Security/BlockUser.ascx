<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BlockUser.ascx.cs" 
Inherits="Bay.ERP.Web.UI.BlockUserControl" %>
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
        <div>
            <div class="TableRow" style="text-align: left;">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    <asp:Label ID="Label1" runat="server" Text="Is Active Login"></asp:Label>:
                </div>
                <div class="TableFormContent">
                    <asp:CheckBox ID="chkIsActiveLogin" runat="server" ValidationGroup="MemberVideoEntity" />
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
             <div class="TableRow" style="text-align: center;">
                <div class="TableFormLeble">
                    &nbsp;</div>
                <div class="TableFormContent">
                    <kti:SecureButton ID="btnSubmit" ValidationGroup="MemberUserEntity" OnClick="btnSave_Click"
                        runat="server" Text="Update" UniqueKey="BlockUserEntityControl_Submit_key" />
                </div>
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
