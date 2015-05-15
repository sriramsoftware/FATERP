<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 28-Apr-2013, 04:59:58
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CRMPaymentScheduleList.ascx.cs"
    Inherits="Bay.ERP.Web.UI.CRMPaymentScheduleListControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div id="Div1" class="TableRow" style="text-align: left;" runat="server">
            <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
        </div>
        <div>
         <div class="TableRow" style="width: 100%; padding-left:480px; display:none;">
            <div class="TableFormLeble" style="text-align: right;">
               Filter Text&nbsp;:
            </div>
            <div class="TableFormContent waterMarkContainer">
             <label class="watermarkLabel" for="txtSearchText">
                            Type Requisition# Or Status</label>
                <asp:TextBox ID="txtSearchText" runat="server" ClientIDMode="Static" CssClass="ktiTextBox"
                     Width="230" /><span><asp:CheckBox ID="chbxFilter"
                        runat="server" AutoPostBack="true" OnCheckedChanged="chbxFilter_CheckedChanged"
                        Text="Use Filter" /></span>
            </div>
            <div class="TableFormValidatorContent">
            </div>
        </div>
            <div class="listContentTitle">
                Payment Schedule List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvCRMPaymentSchedule" runat="server" DataSourceID="odsCRMPaymentSchedule" OnItemDataBound="lvCRMPaymentSchedule_ItemDataBound"
                        OnItemCommand="lvCRMPaymentSchedule_ItemCommand">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Agreement
                                    </td>
                                    <td class="hi">
                                        Handover Date
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Actual Handover Date
                                    </td>
                                    <td class="hi" style="width:150px;">
                                        Project Name
                                    </td>
                                    <td class="hi" style="width:150px;">
                                        Buyer Info
                                    </td>
                                    <td class="hi">
                                        Common Service
                                    </td>
                                    <td class="hi">
                                        Utility Connection Cost
                                    </td>
                                    <td class="hi">
                                        Reserved Fund
                                    </td>
                                    <td class="hi">
                                        Total Installment
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Remarks
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Create By Employee
                                    </td>
                                    <td class="hi" style="display:none;">
                                        I P
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Create Date
                                    </td>
                                    <td class="his" style="width:100px;">
                                        Option
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
                                    <%# Eval("HandoverDate") != null ? ((DateTime)Eval("HandoverDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("ActualHandoverDate") != null ? ((DateTime)Eval("ActualHandoverDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                               <td class="i">
                                    <%# Eval("ProjectName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BuyerBasicInfoContactFullName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CommonService")%>
                                </td>
                                <td class="i">
                                    <%# Eval("UtilityConnectionCost")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ReservedFund")%>
                                </td>
                                <td class="i">
                                    <%# Eval("TotalInstallment")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("CreateByEmployeeID")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("IP")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("CreateDate") != null ? ((DateTime)Eval("CreateDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("PaymentScheduleID")%>'
                                        UniqueKey="CRMPaymentSchedule_lvCRMPaymentSchedule_Edit_key" />
                                        <br />
                                        <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete C RMPayment Schedule?')"
                                        CommandArgument='<%#Eval("PaymentScheduleID")%>' UniqueKey="CRMPaymentSchedule_lvCRMPaymentSchedule_Edit_key" />
                                        <br />
                                        <asp:HyperLink ID="hypReport" runat="server" Text="Report" />
                                        <br />
                                        <asp:HyperLink ID="hypPaymentCollectionReport" runat="server" Text="Collection Report" />

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
                                    <%# Eval("HandoverDate") != null ? ((DateTime)Eval("HandoverDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("ActualHandoverDate") != null ? ((DateTime)Eval("ActualHandoverDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("ProjectName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BuyerBasicInfoContactFullName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CommonService")%>
                                </td>
                                <td class="i">
                                    <%# Eval("UtilityConnectionCost")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ReservedFund")%>
                                </td>
                                <td class="i">
                                    <%# Eval("TotalInstallment")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("CreateByEmployeeID")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("IP")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("CreateDate") != null ? ((DateTime)Eval("CreateDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("PaymentScheduleID")%>'
                                        UniqueKey="CRMPaymentSchedule_lvCRMPaymentSchedule_Edit_key" />
                                        <br />
                                        <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete C RMPayment Schedule?')"
                                        CommandArgument='<%#Eval("PaymentScheduleID")%>' UniqueKey="CRMPaymentSchedule_lvCRMPaymentSchedule_Edit_key" />
                                        <br />
                                        <asp:HyperLink ID="hypReport" runat="server" Text="Report" />
                                        <br />
                                        <asp:HyperLink ID="hypPaymentCollectionReport" runat="server" Text="Collection Report" />
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
                <asp:ObjectDataSource ID="odsCRMPaymentSchedule" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.CRMPaymentSchedule_DetailedDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsCRMPaymentSchedule_Selecting">
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
