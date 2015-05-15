<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 21-Jan-2013, 04:58:29
--%>




<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ACCRequisitionWorkOrderMRRDetail_DetailedListCustom.ascx.cs"
    Inherits="Bay.ERP.Web.UI.ACCRequisitionWorkOrderMRRDetail_DetailedControlListCustom" %>

<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div>
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
             <div class="TableRow" style="width: 100%; padding-left:480px;">
            <div class="TableFormLeble" style="text-align: right;">
               Filter Text&nbsp;:
            </div>
            <div class="TableFormContent waterMarkContainer">
             <label class="watermarkLabel" for="txtSearchText">
                            Type Project# Requisiton Or Item</label>
                <asp:TextBox ID="txtSearchText" runat="server" ClientIDMode="Static" CssClass="ktiTextBox"
                     Width="230" /><span><asp:CheckBox ID="chbxFilter"
                        runat="server" AutoPostBack="true" OnCheckedChanged="chbxFilter_CheckedChanged"
                        Text="Use Filter" /></span>
            </div>
            <div class="TableFormValidatorContent">
            </div>
        </div>
            <div class="listContentTitle">
                ACC View
            </div>
            <div>
               <div>
                <div class="lv-c">
                    <asp:ListView ID="lvACCRequisitionWorkOrderMRRDetail_Detailed" runat="server" DataSourceID="odsACCRequisitionWorkOrderMRRDetail_Detailed">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                   <td class="hi" style="width:190px;">
                                        Project
                                    </td>
                                    <td class="hi" style="width:190px;">
                                        Item Name
                                    </td>
                                    <td class="hi">
                                       Requisition Qty
                                    </td>
                                    <td class="hi">
                                       WO Qty
                                    </td>
                                    <td class="hi">
                                       MRR Qty
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
                                    <%# Eval("ProjectName")%>(<%# Eval("ProjectCode")%>)
                                </td>
                                <td class="i">
                                    <%# Eval("ItemName")%> <br /> 
                                     Brand: <%# Eval("BrandName")%><br /> 
                                     Origin: <%# Eval("OriginRegionName")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("OriginCountryName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("RequisitionQty")%><br /> 
                                    (<%# Eval("RequisitionNo")%>)<br /> 
                                     Dt: <%# Eval("RequisitionDate") != null ? ((DateTime)Eval("RequisitionDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("WORequiredQty")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MRRQty")%>
                                </td>
                                <td class="rp">
                                    &nbsp;
                                </td>
                                <td class="rpb">
                                    &nbsp;
                                </td>
                            </tr>
                        </ItemTemplate>
                        <%--<AlternatingItemTemplate>
                            <tr class="ar">
                                <td class="rp">
                                    &nbsp;
                                </td>
                              <td class="i">
                                    <%# Eval("ProjectName")%>(<%# Eval("ProjectCode")%>)
                                </td>
                                <td class="i">
                                    <%# Eval("ItemName")%> <br /> 
                                     <%# Eval("BrandName")%><br /> 
                                     <%# Eval("OriginRegionName")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("OriginCountryName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("RequisitionQty")%><br /> 
                                    <%# Eval("RequisitionNo")%><br /> 
                                     <%# Eval("RequisitionDate") != null ? ((DateTime)Eval("RequisitionDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("WORequiredQty")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MRRQty")%>
                                </td>
                                <td class="rp">
                                    &nbsp;
                                </td>
                                <td class="rpb">
                                    &nbsp;
                                </td>
                            </tr>
                        </AlternatingItemTemplate>--%>
                        <EmptyDataTemplate>
                            <div class="edr">
                                No Records Found To Display
                            </div>
                        </EmptyDataTemplate>
                    </asp:ListView>
                </div>
                <asp:ObjectDataSource ID="odsACCRequisitionWorkOrderMRRDetail_Detailed" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.ACCRequisitionWorkOrderMRRDetail_DetailedDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsACCRequisitionWorkOrderMRRDetail_Detailed_Selecting">
                    <SelectParameters>
                        <asp:Parameter Name="startRowIndex" Type="Int32" />
                        <asp:Parameter Name="pageSize" Type="Int32" />
                        <asp:Parameter Name="sortExpression" Type="String" />
                        <asp:Parameter Name="filterExpression" Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </div>
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
