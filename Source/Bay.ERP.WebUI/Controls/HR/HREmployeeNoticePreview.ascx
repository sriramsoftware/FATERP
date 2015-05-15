<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 20-Dec-2013, 02:17:52
--%>




<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HREmployeeNoticePreview.ascx.cs"
    Inherits="Bay.ERP.Web.UI.HREmployeeNoticePreviewControl" %>

<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
     <div id="Div1" class="TableRow" style="text-align: left;" runat="server">
                    <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
                </div>
                <div>
                 <div class="TableFormContentAgreement">
                                <asp:Literal ID="lblNoticeTextView" runat="server"></asp:Literal>
                            </div>

        </div>
    </ContentTemplate>
</asp:UpdatePanel>
