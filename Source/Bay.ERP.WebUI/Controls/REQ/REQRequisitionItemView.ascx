<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 11-Jan-2012, 04:11:49
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="REQRequisitionItemView.ascx.cs"
    Inherits="Bay.ERP.Web.UI.REQRequisitionItemViewControl" %>
<script type="text/javascript">
    function ace1_itemSelected(sender, e) {
        $("#hdEmpID").val(e.get_value());
    }
    function SetContextKey() {
        var behavior = $find("AutoCompleteEx");
        behavior.set_contextKey(window.document.getElementById("hypProjectID").value.toString());
    }
    function BindEvents() {
        $(document).ready(function () {
            $('#txtItemName').keyup(function (event) {
                var KeyID = event.keyCode;
                if (KeyID != 13) {
                    $("#hdEmpID").val("0");
                }
            });
        });
    }
</script>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <script type="text/javascript">
            Sys.Application.add_load(BindEvents);
        </script>
        <asp:HiddenField ID="hypProjectID" runat="server" Value="0" ClientIDMode="Static" />
        <div id="Div1" class="TableRow" style="text-align: left;" runat="server">
            <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
        </div>
        <div>
            <div class="TableRow">
                <div>
                    <b>Requisition No</b>&nbsp;: &nbsp; &nbsp;<asp:Label ID="lblRequisitonNo" Font-Bold="true"
                        runat="server"></asp:Label>
                </div>
                <div class="TableRow">
                    <div>
                        <b>Project Name</b>&nbsp;: &nbsp; &nbsp;<asp:Label ID="lblProjectName" Font-Bold="true"
                            runat="server"></asp:Label>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div>
                    </div>
                </div>
                <div class="TableFormContent" style="padding-left: 160px;">
                </div>
                <div class="listContentTitle">
                </div>
                <div>
                    <div class="lv-c">
                        <asp:ListView ID="lvREQRequisitionItem" runat="server" DataSourceID="odsREQRequisitionItem">
                            <LayoutTemplate>
                                <table class="lv" cellpadding="0" cellspacing="0">
                                    <tr class="h">
                                        <td class="rp">
                                            &nbsp;
                                        </td>
                                        <td class="hi" style="display: none;">
                                            Requisition
                                        </td>
                                        <td class="hi" style="width: 200px;">
                                            <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByItem"
                                                CommandName="Sort" Text="Item" CommandArgument="MDItem.ItemName" />
                                        </td>
                                        <td class="hi" style="display: none;">
                                        </td>
                                        <td class="hi">
                                            <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByTotalReqQty"
                                                CommandName="Sort" Text="Total Req. Qty" CommandArgument="REQRequisitionItem.TotalRequiredQty" />
                                        </td>
                                        <td class="hi">
                                            <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByPurchasedQty"
                                                CommandName="Sort" Text="Purchased Qty" CommandArgument="REQRequisitionItem.PurchasedQtyTillToDate" />
                                        </td>
                                        <td class="hi" style="width: 95px;">
                                            <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByPresentReqQty"
                                                CommandName="Sort" Text="Present Req. Qty" CommandArgument="REQRequisitionItem.PresentRequiredQty" />
                                        </td>
                                        <td class="hi" style="width: 85px;">
                                            <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByRequiredDate"
                                                CommandName="Sort" Text="Required Date" CommandArgument="REQRequisitionItem.RequiredDate" />
                                        </td>
                                        <td class="hi" style="width:120px;">
                                            <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByRemarks"
                                                CommandName="Sort" Text="Remarks" CommandArgument="REQRequisitionItem.Remarks" />
                                        </td>
                                        <td class="his" style="display: none;">
                                            EDIT
                                        </td>
                                        <td class="rp" style="display: none;">
                                            &nbsp;
                                        </td>
                                        <td class="rpb">
                                            &nbsp;
                                        </td>
                                    </tr>
                                    <tr runat="server" id="itemPlaceholder">
                                    </tr>
                                </table>
                            </LayoutTemplate>
                            <ItemTemplate>
                                <tr class="r">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="i" style="display: none;">
                                        <%# Eval("RequisitionID")%>
                                    </td>
                                    <td class="i">
                                        <%# Eval("MDItemItemName")%>
                                    </td>
                                    <td class="i" style="display: none;">
                                        <asp:Label ID="lblItemLV" runat="server" Visible="false" Text='<%# Eval("ItemID")%>'></asp:Label>
                                    </td>
                                    <td class="i">
                                        <asp:Label ID="txtQtyLV" runat="server" Text='<%# Eval("TotalRequiredQty")%>'></asp:Label>
                                    </td>
                                    <td class="i">
                                        <asp:Label ID="txtPurchasedQty" runat="server" Text='<%# Eval("PurchasedQtyTillToDateNew")%>'></asp:Label>
                                    </td>
                                    <td class="i">
                                        <%# Eval("PresentRequiredQty")%>
                                    </td>
                                    <td class="i">
                                        <%# Eval("RequiredDate") != null ? ((DateTime)Eval("RequiredDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                                    </td>
                                    <td class="i">
                                        <%# Eval("Remarks")%>
                                    </td>
                                    <td class="i" style="display: none;">
                                        <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                            Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("RequisitionItemID")%>'
                                            UniqueKey="REQRequisitionItemView_lvREQRequisitionItem_Edit_key" />
                                    </td>
                                    <td class="i" style="display: none;">
                                        <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                            ToolTip="Please Click Here To Delete Item From This Requisition!" Text="Delete"
                                            CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Requisition Item?')"
                                            CommandArgument='<%#Eval("RequisitionItemID")%>' UniqueKey="REQRequisitionItemView_lvREQRequisitionItem_Delete_key" />
                                    </td>
                                    <td class="rp" style="display: none;">
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
                                        <%# Eval("RequisitionID")%>
                                    </td>
                                    <td class="i">
                                        <%# Eval("MDItemItemName")%>
                                    </td>
                                    <td class="i" style="display: none;">
                                        <asp:Label ID="lblItemLV" runat="server" Visible="false" Text='<%# Eval("ItemID")%>'></asp:Label>
                                    </td>
                                    <td class="i">
                                        <asp:Label ID="txtQtyLV" runat="server" Text='<%# Eval("TotalRequiredQty")%>'></asp:Label>
                                    </td>
                                    <td class="i">
                                        <asp:Label ID="txtPurchasedQty" runat="server" Text='<%# Eval("PurchasedQtyTillToDateNew")%>'></asp:Label>
                                    </td>
                                    <td class="i">
                                        <%# Eval("PresentRequiredQty")%>
                                    </td>
                                    <td class="i">
                                        <%# Eval("RequiredDate") != null ? ((DateTime)Eval("RequiredDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                                    </td>
                                    <td class="i">
                                        <%# Eval("Remarks")%>
                                    </td>
                                    <td class="i" style="display: none;">
                                        <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                            Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("RequisitionItemID")%>'
                                            UniqueKey="REQRequisitionItemView_lvREQRequisitionItem_Edit_key" />
                                    </td>
                                    <td class="i" style="display: none;">
                                        <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                            ToolTip="Please Click Here To Delete Item From This Requisition!" Text="Delete"
                                            CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Requisition Item?')"
                                            CommandArgument='<%#Eval("RequisitionItemID")%>' UniqueKey="REQRequisitionItemView_lvREQRequisitionItem_Delete_key" />
                                    </td>
                                    <td class="rp" style="display: none;">
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
                    <asp:ObjectDataSource ID="odsREQRequisitionItem" runat="server" SelectMethod="GetPagedData"
                        SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                        StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.REQRequisitionItem_DetailedDataSource"
                        SortParameterName="sortExpression" OnSelecting="odsREQRequisitionItem_Selecting">
                        <SelectParameters>
                            <asp:Parameter Name="startRowIndex" Type="Int32" />
                            <asp:Parameter Name="pageSize" Type="Int32" />
                            <asp:Parameter Name="sortExpression" Type="String" />
                            <asp:Parameter Name="filterExpression" Type="String" />
                        </SelectParameters>
                    </asp:ObjectDataSource>
                </div>
                <br />
                <br />
                <div>
                     <kti:SecureLinkButton ID="btnBack" ClientIDMode="Static" OnClientClick="javascript:history.go(-1)"
                        runat="server" Text="Back" UniqueKey="REQRequisitionItemViewControl_Back_key" />
                  </div>
            </div>
    </ContentTemplate>
</asp:UpdatePanel>
