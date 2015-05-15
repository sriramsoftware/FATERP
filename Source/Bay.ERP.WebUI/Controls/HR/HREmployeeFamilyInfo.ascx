<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 20-Dec-2013, 02:17:52
--%>




<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HREmployeeFamilyInfo.ascx.cs"
    Inherits="Bay.ERP.Web.UI.HREmployeeFamilyInfoControl" %>

<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <ajaxToolkit:CollapsiblePanelExtender ID="cpeEditor" runat="server" TargetControlID="pnlEditor"
            ExpandControlID="divCollapsControl" CollapseControlID="divCollapsControl" Collapsed="true"
            ImageControlID="imgExpandCollaps" CollapsedImage="~/Images/expand-plus.gif" ExpandedImage="~/Images/collapse-minus.gif"
            SuppressPostBack="false">
        </ajaxToolkit:CollapsiblePanelExtender>
        <asp:Panel ID="pnlCPEContent" runat="server" CssClass="pnlCPEContent">
            <div id="divCollapsControl" class="divCollapsControl">
                <div style="float: left; height: 16px; width: 16px;">
                    <asp:Image ID="imgExpandCollaps" ImageUrl="~/Images/expand-plus.gif" runat="server" />
                </div>
                <div style="float: left; padding-left: 3px;">
                    <asp:Label ID="lvlCollapsText" runat="server" Text="Add/Edit Employee Family Info"></asp:Label>
                </div>
                <div style="clear: both;">
                </div>
            </div>
        </asp:Panel>
        <div>
            <asp:Panel ID="pnlEditor" runat="server" CssClass="pnlEditor">
                <div class="TableRow" style="text-align: left;" runat="server">
                    <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right; width:160px;">
                    <asp:HyperLink CssClass="hypTableFormLeble" ID="hypFamilyRelationType" runat="server" Text="Family Relation Type" NavigateUrl="~/MD/MDFamilyRelationType.aspx"
                                Target="_blank"></asp:HyperLink>
                   :
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlFamilyRelationTypeID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="HREmployeeFamilyInfoEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvFamilyRelationTypeID" runat="server" ControlToValidate="ddlFamilyRelationTypeID"
                            ErrorMessage="Please Select Family Relation Type" ValidationGroup="HREmployeeFamilyInfoEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right; width:160px;">
                        First Name&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtFirstName">
                            Enter First Name</label>
                        <asp:TextBox ID="txtFirstName" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="HREmployeeFamilyInfoEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvFirstName" runat="server" ControlToValidate="txtFirstName"
                            ErrorMessage="Please Enter First Name" ValidationGroup="HREmployeeFamilyInfoEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right; width:160px;">
                        Middle Name&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtMiddleName" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="HREmployeeFamilyInfoEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right; width:160px;">
                        Last Name&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtLastName">
                            Enter Last Name</label>
                        <asp:TextBox ID="txtLastName" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="HREmployeeFamilyInfoEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvLastName" runat="server" ControlToValidate="txtLastName"
                            ErrorMessage="Please Enter Last Name" ValidationGroup="HREmployeeFamilyInfoEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right; width:160px;">
                        Description&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtProfession" runat="server" ValidationGroup="HREmployeeFamilyInfoEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right; width:160px;">
                        Is Dependent&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:CheckBox ID="chkIsDependent" runat="server" ClientIDMode="Static" ValidationGroup="HREmployeeFamilyInfoEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right; width:160px;">
                    <asp:HyperLink CssClass="hypTableFormLeble" ID="hypLastEducationAcq" runat="server" Text="Last Education Acq." NavigateUrl="~/MD/MDEducationalDegree.aspx"
                                Target="_blank"></asp:HyperLink>
                   :
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlLastEducationAcquired" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="HREmployeeFamilyInfoEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvLastEducationAcquired" runat="server" ControlToValidate="ddlLastEducationAcquired"
                            ErrorMessage="Please Select Last Education Acquired" ValidationGroup="HREmployeeFamilyInfoEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right; width:160px;">
                        Is Employed&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:CheckBox ID="chkIsEmployed" runat="server" ClientIDMode="Static" ValidationGroup="HREmployeeFamilyInfoEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right; width:160px;">
                        Age&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtAge" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="HREmployeeFamilyInfoEntity" Type="Number" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvAge" runat="server" ControlToValidate="txtAge" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="HREmployeeFamilyInfoEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right; width:160px;">
                        Email Address&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtEmailAddress" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="HREmployeeFamilyInfoEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revEmailAddress" runat="server" ControlToValidate="txtEmailAddress" Display="Dynamic"
                            EnableViewState="False" ValidationGroup="HREmployeeFamilyInfoEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right; width:160px;">
                        Phone&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtPhone" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="HREmployeeFamilyInfoEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revPhone" runat="server" ControlToValidate="txtPhone" Display="Dynamic"
                            EnableViewState="true" ValidationGroup="HREmployeeFamilyInfoEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble" style="width:160px;">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="HREmployeeFamilyInfoEntity" OnClick="btnSave_Click"
                            runat="server" Text="Add" UniqueKey="HREmployeeFamilyInfoControl_Submit_key" />
                        <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click"
                            runat="server" Text="Add New" UniqueKey="HREmployeeFamilyInfoControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click"
                            runat="server" Text="Clear" UniqueKey="HREmployeeFamilyInfoControl_Clear_key" />
                    </div>
                </div>
                <br />
            </asp:Panel>
            <div class="listContentTitle">
                Employee Family Info List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvHREmployeeFamilyInfo" runat="server" DataSourceID="odsHREmployeeFamilyInfo" OnItemCommand="lvHREmployeeFamilyInfo_ItemCommand">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi">
                                        Employee
                                    </td>
                                    <td class="hi">
                                        Family Relation Type
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
                                        Profession
                                    </td>
                                    <td class="hi">
                                        Is Dependent
                                    </td>
                                    <td class="hi">
                                        Last Education Acquired
                                    </td>
                                    <td class="hi">
                                        Is Employed
                                    </td>
                                    <td class="hi">
                                        Age
                                    </td>
                                    <td class="hi">
                                        Email Address
                                    </td>
                                    <td class="hi">
                                        Phone
                                    </td>
                                    <td class="his">
                                        EDIT
                                    </td>
                                    <td class="his">
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
                                    <%# Eval("EmployeeFullName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("FamilyRelationTypeName")%>
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
                                    <%# Eval("Profession")%>
                                </td>
                                <td class="i">
                                    <%# Eval("IsDependent") != null ? (((Boolean)Eval("IsDependent")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("EducationalDegreeName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("IsEmployed") != null ? (((Boolean)Eval("IsEmployed")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("Age")%>
                                </td>
                                <td class="i">
                                    <%# Eval("EmailAddress")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Phone")%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("HREmployeeFamilyInfoID")%>' UniqueKey="HREmployeeFamilyInfo_lvHREmployeeFamilyInfo_Edit_key" />
                                </td>
                                <td class="i">
                            <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Employee Family Info?')"
                                        CommandArgument='<%#Eval("HREmployeeFamilyInfoID")%>' UniqueKey="HREmployeeFamilyInfo_lvHREmployeeFamilyInfo_Edit_key"/>
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
                                    <%# Eval("EmployeeFullName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("FamilyRelationTypeName")%>
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
                                    <%# Eval("Profession")%>
                                </td>
                                <td class="i">
                                    <%# Eval("IsDependent") != null ? (((Boolean)Eval("IsDependent")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("EducationalDegreeName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("IsEmployed") != null ? (((Boolean)Eval("IsEmployed")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("Age")%>
                                </td>
                                <td class="i">
                                    <%# Eval("EmailAddress")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Phone")%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("HREmployeeFamilyInfoID")%>' UniqueKey="HREmployeeFamilyInfo_lvHREmployeeFamilyInfo_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Employee Family Info?')"
                                        CommandArgument='<%#Eval("HREmployeeFamilyInfoID")%>' UniqueKey="HREmployeeFamilyInfo_lvHREmployeeFamilyInfo_Edit_key"/>
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
                <asp:ObjectDataSource ID="odsHREmployeeFamilyInfo" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.HREmployeeFamilyInfo_DetailedDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsHREmployeeFamilyInfo_Selecting">
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
