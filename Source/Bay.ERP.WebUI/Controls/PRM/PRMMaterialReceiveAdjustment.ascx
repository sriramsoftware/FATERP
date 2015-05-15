<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 25-Jun-2012, 05:50:09
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PRMMaterialReceiveAdjustment.ascx.cs"
    Inherits="Bay.ERP.Web.UI.PRMMaterialReceiveAdjustmentControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        
            <div class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    MRR &nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlMaterialReceiveID" CssClass="ktiSelect" ClientIDMode="Static"
                        runat="server" ValidationGroup="PRMMaterialReceiveEntity" Width="236">
                    </asp:DropDownList>
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvMaterialReceiveID" runat="server" ControlToValidate="ddlMaterialReceiveID"
                        ErrorMessage="Please Select MRR" ValidationGroup="PRMMaterialReceiveEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
              <div style="padding-left:160px;">
                <asp:Button ID="btnAdjustMRR" ValidationGroup="PRMMaterialReceiveEntity" OnClick="btnAdjustMRR_Click"
                    runat="server" Text="Adjust MRR" />
            </div>
    </ContentTemplate>
</asp:UpdatePanel>
