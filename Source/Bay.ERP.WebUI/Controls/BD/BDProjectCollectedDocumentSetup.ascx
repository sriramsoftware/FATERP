<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 30-Nov-2011, 02:49:46
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BDProjectCollectedDocumentSetup.ascx.cs"
    Inherits="Bay.ERP.Web.UI.BDProjectCollectedDocumentSetupControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div class="TableRow" style="width: 100;">
                <div style="padding-bottom: 5px;">
                    <b> Document Template&nbsp;:</b>
                </div>
                <div>
                    <asp:DropDownList ID="ddlProjectDocumentTemplateID" CssClass="ktiSelect" ClientIDMode="Static"
                        runat="server" ValidationGroup="BDProjectCollectedDocumentInfoEntity" Width="236"
                        OnSelectedIndexChanged="ddlProjectDocumentTemplateID_SelectedIndexChanged" AutoPostBack="true">
                    </asp:DropDownList>
                </div>
                <br />
                <div style="padding-bottom: 5px;">
                    <b>Project Documents&nbsp;:</b>
                </div>
                <div>
                    <kti:BayProjectDocumentTreeView ID="treeDocument" runat="server" ShowCheckBoxesInDocumentNodes="true" ProjectID="0">
                    </kti:BayProjectDocumentTreeView>
                </div>
                <br />
                <div style="padding-left: 20px;">
                    <kti:SecureButton ID="btnSubmit" OnClick="btnSave_Click" 
                        runat="server" Text="Update" UniqueKey="BDProjectCollectedDocumentSetupControl_Submit_key" />
                </div>
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
