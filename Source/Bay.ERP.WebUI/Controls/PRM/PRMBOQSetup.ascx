<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 30-Nov-2011, 02:49:46
--%>




<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PRMBOQSetup.ascx.cs"
    Inherits="Bay.ERP.Web.UI.PRMBOQSetupControl" %>

<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div id="Div1" class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div class="TableRow" style="width: 100; ">
                <div style="padding-bottom: 5px;">
                    <b> Project Cost Template&nbsp;:</b>
                </div>
                <div>
                    <asp:DropDownList ID="ddlBOQTemplateID" CssClass="ktiSelect" ClientIDMode="Static"
                        runat="server" Width="236" OnSelectedIndexChanged="ddlBOQTemplateID_SelectedIndexChanged" AutoPostBack="true">
                    </asp:DropDownList>
                </div>
                <div style="float:right;">
                <h1>Note: Becareful to Modify this page,<br /> This may delete the complete BOQ</h1>
                </div>
                <br />
                <div style="padding-bottom: 5px;">
                    <b>Items&nbsp;:</b>
                </div>
                <div>
                    <kti:BayItemTreeView ID="treeItem" runat="server" ShowCheckBoxesInAllNodes="true" ShowCheckedAtLastNode="false" OnSelectedNodeChanged="treeItem_SelectedNodeChanged">
                    </kti:BayItemTreeView>
                </div>
                <br />
                <div style="padding-left: 20px;">
                    <kti:SecureButton ID="btnSubmit" OnClick="btnSave_Click" 
                        runat="server" Text="Update" UniqueKey="PRMBOQSetupControl_Submit_key" />                        
                </div>
                <br />
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
