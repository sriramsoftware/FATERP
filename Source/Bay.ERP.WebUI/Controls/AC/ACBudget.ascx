<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 B2B Solutions, info@b2b-erp.com.
 ©2006 – 2010.

 Code Generate Time - 27-Jan-2013, 02:50:43
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ACBudget.ascx.cs" Inherits="Bay.ERP.Web.UI.ACBudgetControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        
        <div>
                <div class="TableRow" style="text-align: left;" runat="server">
                    <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Fiscal Year&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlFiscalYearID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="ACBudgetEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvFiscalYearID" runat="server" ControlToValidate="ddlFiscalYearID"
                            ErrorMessage="Please Select Fiscal Year" ValidationGroup="ACBudgetEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Account&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <kti:BayGroupDropDownList ID="ddlAccountID" runat="server" CssClass="ktiSelect" ClientIDMode="Static"
                            ValidationGroup="ACBudgetEntity" Width="234" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvAccountID" runat="server" ControlToValidate="ddlAccountID"
                            ErrorMessage="Please Select Account" ValidationGroup="ACBudgetEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <asp:Button ID="btnGet" ValidationGroup="none" OnClick="btnGet_Click" runat="server"
                            Text="Get" />
                    </div>
                </div>
                <br />
            <div class="listContentTitle">
                Budget List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvACBudget" runat="server" DataSourceID="odsACBudget" OnItemCommand="lvACBudget_ItemCommand" DataKeyNames="BudgetID">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi" style="display: none;">
                                        Fiscal Year
                                    </td>
                                    <td class="hi" style="display: none;">
                                        Account
                                    </td>
                                    <td class="hi">
                                        Period
                                    </td>
                                    <td class="hi">
                                        Amount
                                    </td>
                                    <td class="hi">
                                        Last Year
                                    </td>
                                    <td class="his" style="display: none;">
                                        EDIT
                                    </td>
                                    <td class="his" style="display: none;">
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
                                <td class="i" style="display: none;">
                                    <%# Eval("ACFiscalYear")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("AccountName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Period") != null ? ((DateTime)Eval("Period")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtAmountLV" Text='<%# Eval("Amount")%>' runat="server" CssClass="ktiDecimalTextBoxListview"></asp:TextBox>
                                </td>
                                <td class="i">
                                    &nbsp;
                                </td>
                                <td class="i" style="display: none;">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("BudgetID")%>' UniqueKey="ACBudget_lvACBudget_Edit_key" />
                                </td>
                                <td class="i" style="display: none;">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Budget?')"
                                        CommandArgument='<%#Eval("BudgetID")%>' UniqueKey="ACBudget_lvACBudget_Delete_key" />
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
                                <td class="i" style="display: none;">
                                    <%# Eval("ACFiscalYear")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("AccountName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Period") != null ? ((DateTime)Eval("Period")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtAmountLV" Text='<%# Eval("Amount")%>' runat="server" CssClass="ktiDecimalTextBoxListview"></asp:TextBox>
                                </td>
                                <td class="i">
                                    &nbsp;
                                </td>
                                <td class="i" style="display: none;">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("BudgetID")%>' UniqueKey="ACBudget_lvACBudget_Edit_key" />
                                </td>
                                <td class="i" style="display: none;">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Budget?')"
                                        CommandArgument='<%#Eval("BudgetID")%>' UniqueKey="ACBudget_lvACBudget_Delete_key" />
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
                <asp:ObjectDataSource ID="odsACBudget" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.ACBudget_DetailedDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsACBudget_Selecting">
                    <SelectParameters>
                        <asp:Parameter Name="startRowIndex" Type="Int32" />
                        <asp:Parameter Name="pageSize" Type="Int32" />
                        <asp:Parameter Name="sortExpression" Type="String" />
                        <asp:Parameter Name="filterExpression" Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </div>
            <div style="font-size: 13px; font-weight: bold; color: Green; padding-bottom: 10px;">
                Total Budgeted Value:
                <asp:Label ID="lblTopTotalBudgetValue" runat="server"></asp:Label>
            </div>
            <br />
            <br />
            <div class="TableRow" style="text-align: center;">
                <div class="TableFormLeble">
                    &nbsp;</div>
                <div class="TableFormContent">
                    <kti:SecureButton ID="btnSubmit" ValidationGroup="ACBudgetEntity" OnClick="btnSave_Click"
                        runat="server" Text="Save" UniqueKey="ACBudgetControl_Submit_key" />
                    <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click" runat="server"
                        Text="Add New" UniqueKey="ACBudgetControl_AddNew_key" />
                    <kti:SecureButton ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear" Visible="false" 
                        UniqueKey="ACBudgetControl_Clear_key" />
                </div>
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
