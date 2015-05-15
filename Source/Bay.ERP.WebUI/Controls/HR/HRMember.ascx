<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 28-Dec-2011, 07:18:54
--%>




<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HRMember.ascx.cs"
    Inherits="Bay.ERP.Web.UI.HRMemberControl" %>

<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
      
        
        <div>
            <asp:Panel ID="pnlEditor" runat="server" CssClass="pnlEditor" Visible="false">
                <div class="TableRow" style="text-align: left;" runat="server">
                    <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        First Name&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtFirstName">
                            Enter First Name</label>
                        <asp:TextBox ID="txtFirstName" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="HRMemberEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvFirstName" runat="server" ControlToValidate="txtFirstName"
                            ErrorMessage="Please Enter First Name" ValidationGroup="HRMemberEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Middle Name&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtMiddleName" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="HRMemberEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Last Name&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtLastName">
                            Enter Last Name</label>
                        <asp:TextBox ID="txtLastName" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="HRMemberEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvLastName" runat="server" ControlToValidate="txtLastName"
                            ErrorMessage="Please Enter Last Name" ValidationGroup="HRMemberEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Member Type&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlMemberTypeID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="HRMemberEntity" Width="236">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvMemberTypeID" runat="server" ControlToValidate="ddlMemberTypeID"
                            ErrorMessage="Please Select Member Type" ValidationGroup="HRMemberEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="HRMemberEntity" OnClick="btnSave_Click"
                            runat="server" Text="Add" UniqueKey="HRMemberControl_Submit_key" />
                        <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click"
                            runat="server" Text="Add New" UniqueKey="HRMemberControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click"
                            runat="server" Text="Clear" UniqueKey="HRMemberControl_Clear_key" />
                    </div>
                </div>
                
                <br />
                 </asp:Panel>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Search Type&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlSearchType" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" Width="236">
                        </asp:DropDownList>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Search Text&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtSearchText" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            Width="230" />
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="ktiSearch" OnClick="btnSearch_Click"
                            runat="server" Text="Search" UniqueKey="HRMemberControl_Search_key" />
                        <kti:SecureButton ID="btnReset" OnClick="btnReset_Click"
                            runat="server" Text="Reset" UniqueKey="HRMemberControl_Reset_key" />
                    </div>
                </div>
                <br />
           <div style="float:right;">
                <asp:HyperLink ID="hypChangePassword" runat="server" Text="Change Password" Target="_blank" NavigateUrl="~/Security/ChangeMyPassword.aspx"></asp:HyperLink>
                </div>
            <div class="listContentTitle">
                Member List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvHRMember" runat="server" DataSourceID="odsHRMember" OnItemCommand="lvHRMember_ItemCommand" OnItemDataBound="lvHRMember_ItemDataBound">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi">
                                        First Name
                                    </td>
                                    <td class="hi">
                                        Middle Name
                                    </td>
                                    <td class="hi">
                                        Last Name
                                    </td>
                                     <td class="hi">
                                        Employee Code
                                    </td>
                                    <td class="hi">
                                        Member Type
                                    </td>
                                    <td class="hi" style="width: 60px;">
                                        Role
                                    </td>
                                    <td class="hi">
                                        Access
                                    </td>
                                    <td class="hi">
                                        Roles
                                    </td>
                                    <td class="hi">
                                        Reset Password 
                                    </td>
                                    <td class="his" style="display:none;">
                                        EDIT
                                    </td>
                                    <td class="his" style="display:none;">
                                        DELETE
                                    </td>
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="rpb">
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr runat="server" id="itemPlaceholder">
                                </tr>
                                <tr>
                                    <td colspan="100%">
                                        <div class="lv-FooterContainer">
                                            <div class="lv-Footer">
                                                <asp:DataPager ID="dpListView" runat="server" PageSize="15">
                                                    <Fields>
                                                        <asp:NextPreviousPagerField ButtonType="Image" ButtonCssClass="lv-PagerItem" FirstPageImageUrl="~/Images/CustomListView/Default/FT.png"
                                                            PreviousPageImageUrl="~/Images/CustomListView/Default/PT.png" ShowFirstPageButton="true"
                                                            ShowPreviousPageButton="true" ShowNextPageButton="false" ShowLastPageButton="false" />
                                                        <asp:NumericPagerField ButtonType="Button" ButtonCount="10" NumericButtonCssClass="lv-PagerItemNumeric"
                                                            CurrentPageLabelCssClass="lv-PagerItemNumericCurrent" RenderNonBreakingSpacesBetweenControls="false" />
                                                        <asp:NextPreviousPagerField ButtonType="Image" ButtonCssClass="lv-PagerItem" NextPageImageUrl="~/Images/CustomListView/Default/NT.png"
                                                            LastPageImageUrl="~/Images/CustomListView/Default/LT.png" ShowFirstPageButton="false"
                                                            ShowPreviousPageButton="false" ShowNextPageButton="true" ShowLastPageButton="true"
                                                            RenderNonBreakingSpacesBetweenControls="true" />
                                                        <asp:TemplatePagerField>
                                                    <PagerTemplate>
                                                                <div class="lv-PagerCount">
                                                                    Items <span>
                                                                        <%# Container.StartRowIndex +1%></span> to <span>
                                                                            <%# (Container.StartRowIndex+Container.PageSize ) < Container.TotalRowCount ? (Container.StartRowIndex+Container.PageSize) : Container.TotalRowCount %></span>
                                                                    of <span>
                                                                        <%# Container.TotalRowCount%></span>
                                                                </div>
                                                            </PagerTemplate>
                                                        </asp:TemplatePagerField>
                                                    </Fields>
                                                </asp:DataPager>
                                            </div>
                                        </div>
                                    </td>
                                </tr>
                            </table>
                        </LayoutTemplate>
                        <ItemTemplate>
                            <tr class="r">
                                <td class="rp">
                                    &nbsp;
                                </td>
                                <td class="i">
                                    <%# Eval("FirstName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MiddleName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("LastName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("EmployeeCode")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MemberTypeName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("UserRole")%>
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="hypAccess" runat="server" Text="Access" CssClass="CommonButtonLink"></asp:HyperLink>
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="hypRoles" runat="server" Text="Manage Roles" CssClass="CommonButtonLink"></asp:HyperLink>
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="hypChangePassword" runat="server" Text="Reset Password" CssClass="CommonButtonLink"></asp:HyperLink>
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="hypBlockUser" runat="server" Text="Block User" CssClass="CommonButtonLink"></asp:HyperLink>
                                </td>
                                <td class="i" style="display:none;">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("MemberID")%>' UniqueKey="HRMember_lvHRMember_Edit_key" />
                                </td>
                                <td class="i" style="display:none;">
                            <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Member?')"
                                        CommandArgument='<%#Eval("MemberID")%>' UniqueKey="HRMember_lvHRMember_Delete_key"/>
                                </td>
                                <td class="rp">
                                    &nbsp;
                                </td>
                                <td class="rpb">
                                    &nbsp;
                                </td>
                            </tr>
                        </ItemTemplate>
                        <AlternatingItemTemplate>
                            <tr class="ar">
                                <td class="rp">
                                    &nbsp;
                                </td>
                                <td class="i">
                                    <%# Eval("FirstName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MiddleName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("LastName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("EmployeeCode")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MemberTypeName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("UserRole")%>
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="hypAccess" runat="server" Text="Access" CssClass="CommonButtonLink"></asp:HyperLink>
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="hypRoles" runat="server" Text="Manage Roles" CssClass="CommonButtonLink"></asp:HyperLink>
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="hypChangePassword" runat="server" Text="Reset Password" CssClass="CommonButtonLink"></asp:HyperLink>
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="hypBlockUser" runat="server" Text="Block User" CssClass="CommonButtonLink"></asp:HyperLink>
                                </td>
                                <td class="i" style="display:none;">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("MemberID")%>' UniqueKey="HRMember_lvHRMember_Edit_key" />
                                </td>
                                <td class="i" style="display:none;">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Member?')"
                                        CommandArgument='<%#Eval("MemberID")%>' UniqueKey="HRMember_lvHRMember_Delete_key"/>
                                </td>
                                <td class="rp">
                                    &nbsp;
                                </td>
                                <td class="rpb">
                                    &nbsp;
                                </td>
                            </tr>
                        </AlternatingItemTemplate>
                        <EmptyDataTemplate>
                            <div class="edr">
                                No Records Found To Display
                            </div>
                        </EmptyDataTemplate>
                    </asp:ListView>
                </div>
                <asp:ObjectDataSource ID="odsHRMember" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.HRMember_CustomDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsHRMember_Selecting">
                    <SelectParameters>
                        <asp:Parameter Name="startRowIndex" Type="Int32" />
                        <asp:Parameter Name="pageSize" Type="Int32" />
                        <asp:Parameter Name="sortExpression" Type="String" />
                        <asp:Parameter Name="filterExpression" Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
