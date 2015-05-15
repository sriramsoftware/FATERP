<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 25-Dec-2012, 02:59:46
--%>




<%@ Control Language="C#" AutoEventWireup="true" CodeFile="INVTransactionINOUT_CustomDetailedListCustom.ascx.cs"
    Inherits="Bay.ERP.Web.UI.INVTransactionINOUT_CustomControlDetailedListCustom" %>
<div>
    <div class="TableRow" style="text-align: left;">
        <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
    </div>
     <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: left;">
                            Start Date&nbsp;:
                        </div>
                        <div class="TableFormContent waterMarkContainer">
                            <label class="watermarkLabel" for="txtStartDate">
                                Enter Start Date</label>
                            <asp:TextBox ID="txtStartDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                                ValidationGroup="INVinventoryEntity" Width="230" />
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtStartDate"
                        ErrorMessage="Please Enter Start Date" ValidationGroup="INVinventoryEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtStartDate"
                        Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                        ValidationGroup="INVinventoryEntity"></asp:RegularExpressionValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: left;">
                            End Date&nbsp;:
                        </div>
                        <div class="TableFormContent waterMarkContainer">
                            <label class="watermarkLabel" for="txtEndDate">
                                Enter End Date</label>
                            <asp:TextBox ID="txtEndDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                                ValidationGroup="INVinventoryEntity" Width="230" />
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtEndDate"
                        ErrorMessage="Please Enter Date" ValidationGroup="INVinventoryEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtEndDate"
                        Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                        ValidationGroup="INVinventoryEntity"></asp:RegularExpressionValidator>
                        </div>
                    </div>
                     <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <asp:Button ID="btnSubmit" ValidationGroup="INVinventoryEntity" OnClick="btnSearch_Click"
                            runat="server" Text="Show Report"/>
                    </div>
                </div>
    <div class="listContentTitle">
        Transaction IN / OUT List
    </div>
    <div>
        <div class="lv-c">
            <asp:ListView ID="lvINVTransactionINOUT_Custom" runat="server" DataSourceID="odsINVTransactionINOUT_Custom">
                <LayoutTemplate>
                    <table class="lv" cellpadding="0" cellspacing="0">
                        <tr class="h">
                            <td class="rp">
                                &nbsp;
                            </td>
                            <td class="hi" style="display:none;">
                                Brand
                            </td>
                            <td class="hi" style="display:none;">
                                Region
                            </td>
                            <td class="hi" style="display:none;">
                                Country
                            </td>
                            <td class="hi" style="width:200px;">
                                Item Name
                            </td>
                            <td class="hi">
                                Brand Name
                            </td>
                            <td class="hi">
                                Region Name
                            </td>
                            <td class="hi">
                                Country Name
                            </td>
                            <td class="hi">
                                IN
                            </td>
                            <td class="hi">
                                OUT
                            </td>
                            <td class="hi">
                                Balance
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
                        <td class="i" style="display:none;">
                            <%# Eval("BrandID")%>
                        </td>
                        <td class="i" style="display:none;">
                            <%# Eval("RegionID")%>
                        </td>
                        <td class="i" style="display:none;">
                            <%# Eval("CountryID")%>
                        </td>
                        <td class="i">
                            <%# Eval("ItemName")%>
                        </td>
                        <td class="i">
                            <%# Eval("BrandName")%>
                        </td>
                        <td class="i">
                            <%# Eval("RegionName")%>
                        </td>
                        <td class="i">
                            <%# Eval("CountryName")%>
                        </td>
                        <td class="i">
                            <%# Eval("IN")%>
                        </td>
                        <td class="i">
                            <%# Eval("OUT")%>
                        </td>
                        <td class="i">
                            <%# Eval("BalanceQty")%>
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
                        <td class="i" style="display:none;">
                            <%# Eval("BrandID")%>
                        </td>
                        <td class="i" style="display:none;">
                            <%# Eval("RegionID")%>
                        </td>
                        <td class="i" style="display:none;">
                            <%# Eval("CountryID")%>
                        </td>
                        <td class="i">
                            <%# Eval("ItemName")%>
                        </td>
                        <td class="i">
                            <%# Eval("BrandName")%>
                        </td>
                        <td class="i">
                            <%# Eval("RegionName")%>
                        </td>
                        <td class="i">
                            <%# Eval("CountryName")%>
                        </td>
                        <td class="i">
                            <%# Eval("IN")%>
                        </td>
                        <td class="i">
                            <%# Eval("OUT")%>
                        </td>
                        <td class="i">
                            <%# Eval("BalanceQty")%>
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
        <asp:ObjectDataSource ID="odsINVTransactionINOUT_Custom" runat="server" SelectMethod="GetPagedData"
            SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
            StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.INVTransactionINOUT_CustomDataSource"
            SortParameterName="sortExpression" OnSelecting="odsINVTransactionINOUT_Custom_Selecting">
            <SelectParameters>
                <asp:Parameter Name="startRowIndex" Type="Int32" />
                <asp:Parameter Name="pageSize" Type="Int32" />
                <asp:Parameter Name="sortExpression" Type="String" />
                <asp:Parameter Name="filterExpression" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>
    </div>
</div>
