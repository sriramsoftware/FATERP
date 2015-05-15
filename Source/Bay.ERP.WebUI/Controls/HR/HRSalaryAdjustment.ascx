<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 12-Jan-2014, 03:42:17
--%>




<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HRSalaryAdjustment.ascx.cs"
    Inherits="Bay.ERP.Web.UI.HRSalaryAdjustmentControl" %>

<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div class="listContentTitle">
                Salary Adjustment List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvHRSalaryAdjustment" runat="server" DataSourceID="odsHRSalaryAdjustment" OnItemCommand="lvHRSalaryAdjustment_ItemCommand">
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
                                        Salary Session
                                    </td>
                                    <td class="hi">
                                        Employee
                                    </td>
                                    <td class="hi">
                                        Salary Level
                                    </td>
                                    <td class="hi">
                                        Designation
                                    </td>
                                    <td class="hi">
                                        Employee Code
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Employee Job Type
                                    </td>
                                    <td class="hi">
                                        Adjustment Amount
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
                                                <asp:DataPager ID="dpListView" runat="server" PageSize="25">
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
                                    <%# Eval("SalarySessionID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("EmployeeID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("SalaryLevel")%>
                                </td>
                                <td class="i">
                                    <%# Eval("DesignationID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("EmployeeCode")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("EmployeeJobTypeID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("AdjustmentAmount")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <asp:LinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("SalaryAdjustmentID")%>' UniqueKey="HRSalaryAdjustment_lvHRSalaryAdjustment_Edit_key" />
                                </td>
                                <td class="i" style="display:none;">
                            <asp:LinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Salary Adjustment?')"
                                        CommandArgument='<%#Eval("SalaryAdjustmentID")%>' UniqueKey="HRSalaryAdjustment_lvHRSalaryAdjustment_Edit_key"/>
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
                                    <%# Eval("FiscalYearID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("SalarySessionID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("EmployeeID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("SalaryLevel")%>
                                </td>
                                <td class="i">
                                    <%# Eval("DesignationID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("EmployeeCode")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("EmployeeJobTypeID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("AdjustmentAmount")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("SalaryAdjustmentID")%>' UniqueKey="HRSalaryAdjustment_lvHRSalaryAdjustment_Edit_key" />
                                </td>
                                <td class="i" style="display:none;">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Salary Adjustment?')"
                                        CommandArgument='<%#Eval("SalaryAdjustmentID")%>' UniqueKey="HRSalaryAdjustment_lvHRSalaryAdjustment_Edit_key"/>
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
                <asp:ObjectDataSource ID="odsHRSalaryAdjustment" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.HRSalaryAdjustmentDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsHRSalaryAdjustment_Selecting">
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
