<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 25-Feb-2012, 05:48:58
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HRMemberPasswordRecovery.ascx.cs"
    Inherits="Bay.ERP.Web.UI.HRMemberPasswordRecoveryControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <h2>Password Recovery</h2>

        </div>        
    </ContentTemplate>
</asp:UpdatePanel>

<asp:PasswordRecovery ID="PasswordRecovery1" runat="server" BackColor="#F7F6F3" 
    BorderColor="#E6E2D8" BorderPadding="4" BorderStyle="Solid" BorderWidth="1px" 
    Font-Names="Verdana" Font-Size="Large">
    <SubmitButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" 
        BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" 
        ForeColor="#284775" />
    <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
    <SuccessTextStyle Font-Bold="True" ForeColor="#5D7B9D" />
    <TextBoxStyle Font-Size="12pt" />
    <TitleTextStyle BackColor="#5D7B9D" Font-Bold="True" Font-Names="14" 
        Font-Size="0.9em" ForeColor="White" />
</asp:PasswordRecovery>


