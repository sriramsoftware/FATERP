<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 20-Dec-2013, 02:17:52
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HREmployeeBankAccountInformation.ascx.cs"
    Inherits="Bay.ERP.Web.UI.HREmployeeBankAccountInformationControl" %>
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
                    <asp:Label ID="lvlCollapsText" runat="server" Text="Add/Edit Employee Bank Account Information"></asp:Label>
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
                    <div class="TableFormLeble" style="text-align: right;">
                        Bank Account No&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtBankAccountNo">
                            Enter Bank Account No</label>
                        <asp:TextBox ID="txtBankAccountNo" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="HREmployeeBankAccountInformationEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvBankAccountNo" runat="server" ControlToValidate="txtBankAccountNo"
                            ErrorMessage="Please Enter Bank Account No" ValidationGroup="HREmployeeBankAccountInformationEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Bank&nbsp;:
                    </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlBankList" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                        ValidationGroup="HREmployeeBankAccountInformationEntity" AutoPostBack="true"
                        Width="234" OnSelectedIndexChanged="ddlBankList_SelectedIndexChanged">
                    </asp:DropDownList>
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="ddlCityID"
                        ErrorMessage="Please Select City" ValidationGroup="HREmployeeBankAccountInformationEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Bank Name&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtBankName">
                            Enter Bank Name</label>
                        <asp:TextBox ID="txtBankName" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="HREmployeeBankAccountInformationEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvBankName" runat="server" ControlToValidate="txtBankName"
                            ErrorMessage="Please Enter Bank Name" ValidationGroup="HREmployeeBankAccountInformationEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Bank Address&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtBankAddress">
                            Enter Bank Address</label>
                        <asp:TextBox ID="txtBankAddress" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="HREmployeeBankAccountInformationEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvBankAddress" runat="server" ControlToValidate="txtBankAddress"
                            ErrorMessage="Please Enter Bank Address" ValidationGroup="HREmployeeBankAccountInformationEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        <asp:HyperLink CssClass="hypTableFormLeble" ID="hypCity" runat="server" Text="City"
                            NavigateUrl="~/MD/MDCity.aspx" Target="_blank"></asp:HyperLink>
                        &nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlCityID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                            ValidationGroup="HREmployeeBankAccountInformationEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvCityID" runat="server" ControlToValidate="ddlCityID"
                            ErrorMessage="Please Select City" ValidationGroup="HREmployeeBankAccountInformationEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Zip Code&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtZipCode" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="HREmployeeBankAccountInformationEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revZipCode" runat="server" ControlToValidate="txtZipCode"
                            Display="Dynamic" EnableViewState="False" ValidationGroup="HREmployeeBankAccountInformationEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        <asp:HyperLink CssClass="hypTableFormLeble" ID="hypAccountCategory" runat="server"
                            Text="Account Category" NavigateUrl="~/MD/MDBankAccountCategory.aspx" Target="_blank"></asp:HyperLink>
                        &nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlBankAccountCategoryID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="HREmployeeBankAccountInformationEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvBankAccountCategoryID" runat="server" ControlToValidate="ddlBankAccountCategoryID"
                            ErrorMessage="Please Select Bank Account Category" ValidationGroup="HREmployeeBankAccountInformationEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Swipe Code&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtSwipeCode" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="HREmployeeBankAccountInformationEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Routing No&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtRoutingNo" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="HREmployeeBankAccountInformationEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Is Salary Accotunt&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:CheckBox ID="chkIsSalaryAccotunt" runat="server" ClientIDMode="Static" ValidationGroup="HREmployeeBankAccountInformationEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Is Default&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:CheckBox ID="chkIsDefault" runat="server" ClientIDMode="Static" ValidationGroup="HREmployeeBankAccountInformationEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="HREmployeeBankAccountInformationEntity"
                            OnClick="btnSave_Click" runat="server" Text="Add" UniqueKey="HREmployeeBankAccountInformationControl_Submit_key" />
                        <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click" runat="server"
                            Text="Add New" UniqueKey="HREmployeeBankAccountInformationControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear"
                            UniqueKey="HREmployeeBankAccountInformationControl_Clear_key" />
                    </div>
                </div>
                <br />
            </asp:Panel>
            <div class="listContentTitle">
                Employee Bank Account Information List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvHREmployeeBankAccountInformation" runat="server" DataSourceID="odsHREmployeeBankAccountInformation"
                        OnItemCommand="lvHREmployeeBankAccountInformation_ItemCommand">
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
                                        Bank Account No
                                    </td>
                                    <td class="hi">
                                        Bank Name
                                    </td>
                                    <td class="hi">
                                        Bank Address
                                    </td>
                                    <td class="hi">
                                        City
                                    </td>
                                    <td class="hi">
                                        Zip Code
                                    </td>
                                    <td class="hi">
                                        P OBox
                                    </td>
                                    <td class="hi">
                                        Bank Account Category
                                    </td>
                                    <td class="hi">
                                        Swipe Code
                                    </td>
                                    <td class="hi">
                                        Routing No
                                    </td>
                                    <td class="hi">
                                        Is Salary Accotunt
                                    </td>
                                    <td class="hi">
                                        Is Default
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
                                <tr style="display:none;">
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
                                    <%# Eval("BankAccountNo")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BankName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BankAddress")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CityName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ZipCode")%>
                                </td>
                                <td class="i">
                                    <%# Eval("POBox")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BankAccountCategoryName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("SwipeCode")%>
                                </td>
                                <td class="i">
                                    <%# Eval("RoutingNo")%>
                                </td>
                                <td class="i">
                                    <%# Eval("IsSalaryAccotunt") != null ? (((Boolean)Eval("IsSalaryAccotunt")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("IsDefault") != null ? (((Boolean)Eval("IsDefault")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("EmployeeBankAccountInformationID")%>'
                                        UniqueKey="HREmployeeBankAccountInformation_lvHREmployeeBankAccountInformation_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Employee Bank Account Information?')"
                                        CommandArgument='<%#Eval("EmployeeBankAccountInformationID")%>' UniqueKey="HREmployeeBankAccountInformation_lvHREmployeeBankAccountInformation_Edit_key" />
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
                                    <%# Eval("BankAccountNo")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BankName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BankAddress")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CityName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ZipCode")%>
                                </td>
                                <td class="i">
                                    <%# Eval("POBox")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BankAccountCategoryName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("SwipeCode")%>
                                </td>
                                <td class="i">
                                    <%# Eval("RoutingNo")%>
                                </td>
                                <td class="i">
                                    <%# Eval("IsSalaryAccotunt") != null ? (((Boolean)Eval("IsSalaryAccotunt")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("IsDefault") != null ? (((Boolean)Eval("IsDefault")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("EmployeeBankAccountInformationID")%>'
                                        UniqueKey="HREmployeeBankAccountInformation_lvHREmployeeBankAccountInformation_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Employee Bank Account Information?')"
                                        CommandArgument='<%#Eval("EmployeeBankAccountInformationID")%>' UniqueKey="HREmployeeBankAccountInformation_lvHREmployeeBankAccountInformation_Edit_key" />
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
                <asp:ObjectDataSource ID="odsHREmployeeBankAccountInformation" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.HREmployeeBankAccountInformation_DetailedDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsHREmployeeBankAccountInformation_Selecting">
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
