<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true"
    CodeFile="AddUser.aspx.cs" Inherits="Bay.ERP.Web.UI.AddUser" Title="Untitled Page" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>Add User</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
     <asp:CreateUserWizard ID="wzdCreatUser" runat="server">
        <WizardSteps>
            <asp:CreateUserWizardStep ID="CreateUserWizardStep1" runat="server" OnActivate="ActivateRoleSetup"
                OnDeactivate="DeactivateRoleSetup">
            </asp:CreateUserWizardStep>
            <asp:WizardStep ID="WizardStep1" runat="server" Title="Choose Role">
                Select Role<br />
                <asp:ListBox ID="ListBox1" runat="server" Width="140px"></asp:ListBox>
            </asp:WizardStep>
            <asp:CompleteWizardStep ID="CompleteWizardStep1" runat="server">
            </asp:CompleteWizardStep>
        </WizardSteps>
    </asp:CreateUserWizard>
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>
