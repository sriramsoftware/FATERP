<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 11-Jan-2012, 04:11:49
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AFMRequisitionList.ascx.cs"
    Inherits="Bay.ERP.Web.UI.AFMRequisitionListControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>

    <script type="text/javascript">
//        function Confirm() {
//            var answer = confirm("Please click on Go to continue.")
//            if (answer)
//                window.location = "~/AC/ACBankAccountPayment.aspx";
//            else
//                window.location = "http://www.facebook.com";
        //        }
        function Confirm(message) {
            $('<div></div>').appendTo('body')
                    .html('<div><h6>' + message + '?</h6></div>')
                    .dialog({
                        modal: true, title: 'Payment Confirmation ', zIndex: 10000, autoOpen: true,
                        width: 'auto', resizable: false,
                        buttons: {
                            Bank: function () {
                                window.location = "http://192.168.0.9:9999/AC/ACBankAccountPayment.aspx";
                            },
                            Cash: function () {
                                window.location = "http://192.168.0.9:9999/AC/ACCashPayment.aspx";
                            }
                        },
                        close: function (event, ui) {
                            $(this).remove();
                        }
                    });
        };

</script>
        <div class="TableRow" style="text-align: left;" runat="server">
            <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
        </div>
        <div class="TableRow" style="width: 100%; padding-left: 480px;">
            <div class="TableFormLeble" style="text-align: right;">
                Filter Text&nbsp;:
            </div>
            <div class="TableFormContent waterMarkContainer">
                <label class="watermarkLabel" for="txtSearchText">
                    Type Requisition#</label>
                <asp:TextBox ID="txtSearchText" runat="server" ClientIDMode="Static" CssClass="ktiTextBox"
                    Width="230" /><span><asp:CheckBox ID="chbxFilter" runat="server" AutoPostBack="true"
                        OnCheckedChanged="chbxFilter_CheckedChanged" Text="Use Filter" /></span>
            </div>
            <div class="TableFormValidatorContent">
            </div>
        </div>
        <div>
            <div class="lv-c">
                <asp:ListView ID="lvREQRequisition" runat="server" DataSourceID="odsREQRequisition"
                    OnItemCommand="lvREQRequisition_ItemCommand" OnItemDataBound="lvREQRequisition_ItemDataBound">
                    <LayoutTemplate>
                        <table class="lv" cellpadding="0" cellspacing="0">
                            <tr class="h">
                                <td class="rp">
                                    &nbsp;
                                </td>
                                <td class="hi">
                                    <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByProject"
                                        CommandName="Sort" Text="Project" CommandArgument="BDProject.ProjectName" />
                                </td>
                                <td class="hi" style="width: 200px;">
                                    <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByRequisitionNo"
                                        CommandName="Sort" Text="Requisition No" CommandArgument="REQRequisition.RequisitionNo" />
                                </td>
                                <td class="hi" style="width: 170px;">
                                    <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByRequisitionDate"
                                        CommandName="Sort" Text="Requisition Date" CommandArgument="REQRequisition.RequisitionDate" />
                                </td>
                                <td class="hi" style="display: none;">
                                    <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByRemarks"
                                        CommandName="Sort" Text="Remarks" CommandArgument="REQRequisition.Remarks" />
                                </td>
                                <td class="hi">
                                    <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByStatus"
                                        CommandName="Sort" Text="Status" CommandArgument="MDRequisitionStatus.Name" />
                                </td>
                                <td class="his" style="width: 30px;">
                                    WO Created
                                </td>
                                <td class="his" style="width: 30px;">
                                    Cash Payment
                                </td>
                                <td class="his">
                                    Report
                                </td>
                                <td class="his" style="width: 100px;">
                                    Make Payment
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
                                <%# Eval("ProjectName")%>
                            </td>
                            <td class="i">
                                <%# Eval("RequisitionNo")%>
                            </td>
                            <td class="i">
                                <%# Eval("RequisitionDate") != null ? ((DateTime)Eval("RequisitionDate")).ToString(Bay.ERP.Web.UI.UIConstants.SHORT_DATE_FORMAT) : ""%>
                            </td>
                            <td class="i" style="display: none;">
                                <%# Eval("Remarks")%>
                            </td>
                            <td class="i">
                                <%# Eval("RequisitionStatusName")%>
                            </td>
                            <td class="i" style="text-align: center;">
                                <asp:Label ID="lblWorkOrderCreated" runat="server"></asp:Label>
                            </td>
                            <td class="i">
                                <%# Eval("IsCashPayment") != null ? (((Boolean)Eval("IsCashPayment")) ? "Yes" : "No") : ""%>
                            </td>
                            <td class="i">
                                <asp:HyperLink ID="hypRequisitionReport" runat="server" CssClass="CommonButtonLink"
                                    Text="Report" CommandName="RequisitionReport" CommandArgument='<%#Eval("RequisitionID")%>'
                                    UniqueKey="AFMRequisitionList_lvREQRequisition_RequisitionReport_key"></asp:HyperLink>
                            </td>
                            <td class="i">
                                <asp:Button ID="btnMadeCashPaymentLV" Text="Make Payment" runat="server" CommandName="UpdateItem"
                                    OnClientClick="return Confirm('Choose your Payment');" OnClick="btnMadeCashPayment_Click" CommandArgument='<%#Eval("RequisitionID")%>'>
                                </asp:Button>
                                <br />
                                <asp:Label ID="lblMadeCashPaymentLV" runat="server"></asp:Label>
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
                                <%# Eval("ProjectName")%>
                            </td>
                            <td class="i">
                                <%# Eval("RequisitionNo")%>
                            </td>
                            <td class="i">
                                <%# Eval("RequisitionDate") != null ? ((DateTime)Eval("RequisitionDate")).ToString(Bay.ERP.Web.UI.UIConstants.SHORT_DATE_FORMAT) : ""%>
                            </td>
                            <td class="i" style="display: none;">
                                <%# Eval("Remarks")%>
                            </td>
                            <td class="i">
                                <%# Eval("RequisitionStatusName")%>
                            </td>
                            <td class="i" style="text-align: center;">
                                <asp:Label ID="lblWorkOrderCreated" runat="server"></asp:Label>
                            </td>
                            <td class="i">
                                <%# Eval("IsCashPayment") != null ? (((Boolean)Eval("IsCashPayment")) ? "Yes" : "No") : ""%>
                            </td>
                            <td class="i">
                                <asp:HyperLink ID="hypRequisitionReport" runat="server" CssClass="CommonButtonLink"
                                    Text="Report" CommandName="RequisitionReport" CommandArgument='<%#Eval("RequisitionID")%>'
                                    UniqueKey="AFMRequisitionList_lvREQRequisition_RequisitionReport_key"></asp:HyperLink>
                            </td>
                            <td class="i">
                                <asp:Button ID="btnMadeCashPaymentLV" Text="Make Payment" runat="server" CommandName="UpdateItem"
                                    OnClientClick="return Confirm('Are You Sure');" CommandArgument='<%#Eval("RequisitionID")%>'>
                                </asp:Button>
                                <br />
                                <asp:Label ID="lblMadeCashPaymentLV" runat="server"></asp:Label>
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
            <asp:ObjectDataSource ID="odsREQRequisition" runat="server" SelectMethod="GetPagedData"
                SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.REQRequisition_DetailedDataSource"
                SortParameterName="sortExpression" OnSelecting="odsREQRequisition_Selecting">
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
