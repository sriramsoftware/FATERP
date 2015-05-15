<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 B2B Solutions, info@b2b-erp.com.
 ©2006 – 2010.

 Code Generate Time - 27-Jan-2013, 02:50:43
--%>




<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ACBankAccount.ascx.cs"
    Inherits="Bay.ERP.Web.UI.ACBankAccountControl" %>

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
                    <asp:Label ID="lvlCollapsText" runat="server" Text="Add/Edit Bank Account"></asp:Label>
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
                    <div class="TableFormLeble" style="text-align: left;">
                    <asp:HyperLink CssClass="hypTableFormLeble" ID="hypAccount" runat="server"
                                Text="Account" NavigateUrl="~/AC/ACAccount.aspx" Target="_blank"></asp:HyperLink>
                            &nbsp;:
                    </div>
                    <div class="TableFormContent">
                    <kti:BayGroupDropDownList ID="ddlACCAccountID" runat="server"  CssClass="ktiSelect" ClientIDMode="Static" ValidationGroup="ACBankAccountEntity"
                             Width="234" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvACCAccountID" runat="server" ControlToValidate="ddlACCAccountID"
                            ErrorMessage="Please Select A CCAccount" ValidationGroup="ACBankAccountEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Bank Account Name&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtBankAccountName">
                            Enter Bank Account Name</label>
                        <asp:TextBox ID="txtBankAccountName" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="ACBankAccountEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvBankAccountName" runat="server" ControlToValidate="txtBankAccountName"
                            ErrorMessage="Please Enter Bank Account Name" ValidationGroup="ACBankAccountEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Bank Acc. Number&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtBankAccountNumber">
                            Enter Bank Account Number</label>
                        <asp:TextBox ID="txtBankAccountNumber" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="ACBankAccountEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvBankAccountNumber" runat="server" ControlToValidate="txtBankAccountNumber"
                            ErrorMessage="Please Enter Bank Account Number" ValidationGroup="ACBankAccountEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Bank Account Type&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlBankAccountTypeID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="ACBankAccountEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvBankAccountTypeID" runat="server" ControlToValidate="ddlBankAccountTypeID"
                            ErrorMessage="Please Select Bank Account Type" ValidationGroup="ACBankAccountEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Currency&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlCurrencyID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="ACBankAccountEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvCurrencyID" runat="server" ControlToValidate="ddlCurrencyID"
                            ErrorMessage="Please Select Currency" ValidationGroup="ACBankAccountEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Is Default&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:CheckBox ID="chkIsDefaultCurrencyAccount" runat="server" ClientIDMode="Static" ValidationGroup="ACBankAccountEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Bank Name&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtBankName">
                            Enter Bank Name</label>
                        <asp:TextBox ID="txtBankName" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="ACBankAccountEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvBankName" runat="server" ControlToValidate="txtBankName"
                            ErrorMessage="Please Enter Bank Name" ValidationGroup="ACBankAccountEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Bank Address&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtBankAddress" ClientIDMode="Static" CssClass="ktiTextArea" runat="server" TextMode="MultiLine"
                            ValidationGroup="ACBankAccountEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="ACBankAccountEntity" OnClick="btnSave_Click" Visible="false"
                            runat="server" Text="Add" UniqueKey="ACBankAccountControl_Submit_key" />
                        <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click" 
                            runat="server" Text="Add New" UniqueKey="ACBankAccountControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click" Visible="false"
                            runat="server" Text="Clear" UniqueKey="ACBankAccountControl_Clear_key" />
                    </div>
                </div>
                <br />
            </asp:Panel>
            <div class="listContentTitle">
                Bank Account List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvACBankAccount" runat="server" DataSourceID="odsACBankAccount" OnItemCommand="lvACBankAccount_ItemCommand">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi">
                                        Account
                                    </td>
                                    <td class="hi">
                                        Bank Account Name
                                    </td>
                                    <td class="hi">
                                        Bank Account Number
                                    </td>
                                    <td class="hi">
                                        Bank Account Type
                                    </td>
                                    <td class="hi">
                                        Currency
                                    </td>
                                    <td class="hi">
                                        Is Default Currency
                                    </td>
                                    <td class="hi">
                                        Bank Name
                                    </td>
                                    <td class="hi">
                                        Bank Address
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
                                    <%# Eval("AccountName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BankAccountName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BankAccountNumber")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BankAccountTypeName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CurrencyName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("IsDefaultCurrencyAccount") != null ? (((Boolean)Eval("IsDefaultCurrencyAccount")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("BankName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BankAddress")%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("BankAccountID")%>' UniqueKey="ACBankAccount_lvACBankAccount_Edit_key" />
                                </td>
                                <td class="i">
                            <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Bank Account?')"
                                        CommandArgument='<%#Eval("BankAccountID")%>' UniqueKey="ACBankAccount_lvACBankAccount_Delete_key"/>
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
                                    <%# Eval("AccountName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BankAccountName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BankAccountNumber")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BankAccountTypeName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CurrencyName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("IsDefaultCurrencyAccount") != null ? (((Boolean)Eval("IsDefaultCurrencyAccount")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("BankName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BankAddress")%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("BankAccountID")%>' UniqueKey="ACBankAccount_lvACBankAccount_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Bank Account?')"
                                        CommandArgument='<%#Eval("BankAccountID")%>' UniqueKey="ACBankAccount_lvACBankAccount_Delete_key"/>
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
                <asp:ObjectDataSource ID="odsACBankAccount" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.ACBankAccount_DetailedDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsACBankAccount_Selecting">
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
