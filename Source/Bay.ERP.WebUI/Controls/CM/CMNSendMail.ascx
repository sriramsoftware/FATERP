<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 05-Oct-2012, 11:26:30
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CMNSendMail.ascx.cs" Inherits="Bay.ERP.Web.UI.CMNSendMailControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div id="Div1" class="TableRow" style="text-align: left;" runat="server">
            <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
        </div>
        <div>
            <div>
                <kti:SecureButton ID="Button1" ValidationGroup="CMContractorLicenceEntity" OnClick="Button1_Click"
                    runat="server" Text="Send Mail" UniqueKey="CMNSendMailControl_Submit_key" />
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
