<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Blank.master" AutoEventWireup="true"
    CodeFile="ReportViewer.aspx.cs" Inherits="Bay.ERP.Web.UI.Reports_ReportViewer" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304"
    Namespace="CrystalDecisions.Web" TagPrefix="CR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="Server">
    <div id="Div1" class="TableRow" style="text-align: left;" runat="server">
        <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
    </div>
    <CR:CrystalReportViewer ID="reportViewer" runat="server" AutoDataBind="true" />
   
   <asp:Button ID="btnGeneratePayable" ValidationGroup="ACCPrePayableStatementDetailEntity" Visible="false"
                        OnClick="btnGeneratePayable_Click" runat="server" Text="Post To Payable Report"/>
</asp:Content>


