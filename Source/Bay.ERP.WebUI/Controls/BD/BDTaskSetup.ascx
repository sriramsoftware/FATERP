<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 30-Nov-2011, 02:49:46
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BDTaskSetup.ascx.cs" Inherits="Bay.ERP.Web.UI.BDTaskSetupControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div class="TableRow" style="width: 100;">
                <div style="padding-bottom: 5px;">
                    <b>Task Template&nbsp;:</b>
                </div>
                <div>
                    <asp:DropDownList ID="ddlTaskTemplateID" CssClass="ktiSelect" ClientIDMode="Static"
                        runat="server" ValidationGroup="BDProjectCollectedDocumentInfoEntity" Width="236"
                        OnSelectedIndexChanged="ddlProjectDocumentTemplateID_SelectedIndexChanged" AutoPostBack="true">
                    </asp:DropDownList>
                </div>
                <br />
                <div id="dvQuick">
                <h3>Quick Links</h3>
                <asp:HyperLink ID="hypTaskCategory" runat="server" NavigateUrl="~/MD/BDMDTaskCategory.aspx" Text="Task Category" Target="_blank"></asp:HyperLink><br />
                <asp:HyperLink ID="hypTask" runat="server" NavigateUrl="~/MD/BDMDTask.aspx" Text="Create Task" Target="_blank"></asp:HyperLink><br />
                <asp:HyperLink ID="hypTaskTemplate" runat="server" NavigateUrl="~/BD/BDTaskTemplate.aspx" Text="Task Template" Target="_blank"></asp:HyperLink><br />
                <asp:HyperLink ID="hypTaskSetup" runat="server" NavigateUrl="~/BD/BDTaskSetup.aspx" Text="Task Assign" Target="_blank"></asp:HyperLink><br />
                </div>
                <div style="padding-bottom: 5px;">
                    <b>Project Documents&nbsp;:</b>
                </div>
                <div>
                    <kti:BayTaskTreeView ID="treeTask" runat="server" ShowCheckBoxesInDocumentNodes="true"
                        ProjectID="0">
                    </kti:BayTaskTreeView>
                </div>
                <br />
                <br />
                <br />
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        <asp:HyperLink CssClass="hypTableFormLeble" ID="hypProject" runat="server" Text="Project"
                            NavigateUrl="~/BD/BDProject.aspx" Target="_blank"></asp:HyperLink>
                        &nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlProjectID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                            ValidationGroup="OTIssueEntity" Width="236">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Assigned To&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlAssignedToEmployeeID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="OTIssueEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvAssignedToEmployeeID" runat="server" ControlToValidate="ddlAssignedToEmployeeID"
                            ErrorMessage="Please Select Assigned To Employee" ValidationGroup="OTIssueEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <br />
                <div style="padding-left: 20px;">
                    <kti:SecureButton ID="btnSubmit" OnClick="btnSave_Click" ValidationGroup="OTIssueEntity"
                        runat="server" Text="Update" UniqueKey="BDProjectCollectedDocumentSetupControl_Submit_key" />
                </div>
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
