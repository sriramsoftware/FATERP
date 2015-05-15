<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 12-Jan-2014, 03:42:17
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HREmployeeSalaryInfo.ascx.cs"
    Inherits="Bay.ERP.Web.UI.HREmployeeSalaryInfoControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <br />
            <div class="listContentTitle">
                Employee Salary Info List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvHREmployeeSalaryInfo" runat="server" DataSourceID="odsHREmployeeSalaryInfo"
                        OnItemDataBound="lvHREmployeeSalaryInfo_ItemDataBound" OnItemCommand="lvHREmployeeSalaryInfo_ItemCommand">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi">
                                        Fiscal Year
                                    </td>
                                    <td class="hi">
                                        Is Deposite
                                    </td>
                                    <td class="hi">
                                        Salary Amount
                                    </td>
                                    <td class="hi">
                                        Pay Cycle
                                    </td>
                                    <td class="hi">
                                        Payscale
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
                                    <%# Eval("FiscalYearID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("IsDeposite") != null ? (((Boolean)Eval("IsDeposite")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("SalaryAmount")%>
                                </td>
                                <td class="i">
                                    <%# Eval("EmployeeCode")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("EmployeeSalaryInfoID")%>'
                                        UniqueKey="HREmployeeSalaryInfo_lvHREmployeeSalaryInfo_Edit_key" />
                                </td>
                                <td class="i" style="display: none;">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Employee Salary Info?')"
                                        CommandArgument='<%#Eval("EmployeeSalaryInfoID")%>' UniqueKey="HREmployeeSalaryInfo_lvHREmployeeSalaryInfo_Edit_key" />
                                </td>
                                <td class="rp">
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
                                    <%# Eval("FiscalYearID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("IsDeposite") != null ? (((Boolean)Eval("IsDeposite")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("SalaryAmount")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("EmployeeSalaryInfoID")%>'
                                        UniqueKey="HREmployeeSalaryInfo_lvHREmployeeSalaryInfo_Edit_key" />
                                </td>
                                <td class="i" style="display: none;">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Employee Salary Info?')"
                                        CommandArgument='<%#Eval("EmployeeSalaryInfoID")%>' UniqueKey="HREmployeeSalaryInfo_lvHREmployeeSalaryInfo_Edit_key" />
                                </td>
                                <td class="rp">
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
                <asp:ObjectDataSource ID="odsHREmployeeSalaryInfo" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.HREmployeeSalaryInfoDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsHREmployeeSalaryInfo_Selecting">
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
