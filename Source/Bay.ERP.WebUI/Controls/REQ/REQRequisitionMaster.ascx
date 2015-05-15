<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 11-Jan-2012, 04:11:49
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="REQRequisitionMaster.ascx.cs"
    Inherits="Bay.ERP.Web.UI.REQRequisitionMasterControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                   <asp:HyperLink CssClass="hypTableFormLeble" ID="hypProject" runat="server" Text="Project" NavigateUrl="~/BD/BDProject.aspx" Target="_blank"></asp:HyperLink>
                        &nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlProjectID" CssClass="ktiSelect" ClientIDMode="Static" runat="server" OnSelectedIndexChanged="ddlProjectID_SelectedIndexChanged" AutoPostBack="true"
                        ValidationGroup="REQRequisitionEntity" Width="236">
                    </asp:DropDownList>
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvProjectID" runat="server" ControlToValidate="ddlProjectID"
                        ErrorMessage="Please Select Project" ValidationGroup="REQRequisitionEntity" EnableViewState="False"
                        Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Requisition No&nbsp;:
                </div>
                <div class="TableFormContent waterMarkContainer">
                    <label class="watermarkLabel" for="txtRequisitionNo">
                        Enter Requisition No</label>
                    <asp:TextBox ID="txtRequisitionNo" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                        ValidationGroup="REQRequisitionEntity" Width="230" />
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvRequisitionNo" runat="server" ControlToValidate="txtRequisitionNo"
                        ErrorMessage="Please Enter Requisition No" ValidationGroup="REQRequisitionEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Requisition Date&nbsp;:
                </div>
                <div class="TableFormContent waterMarkContainer">
                    <label class="watermarkLabel" for="txtRequisitionDate">
                        Enter Requisition Date</label>
                    <asp:TextBox ID="txtRequisitionDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                        ValidationGroup="REQRequisitionEntity" Width="230" />
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvRequisitionDate" runat="server" ControlToValidate="txtRequisitionDate"
                        ErrorMessage="Please Enter Requisition Date" ValidationGroup="REQRequisitionEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revRequisitionDate" runat="server" ControlToValidate="txtRequisitionDate"
                        Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                        ValidationGroup="REQRequisitionEntity"></asp:RegularExpressionValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Remarks&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox ID="txtRemarks" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                        ValidationGroup="REQRequisitionEntity" Width="230" />
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Requisition Status&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlRequisitionStatusID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="REQRequisitionEntity" Width="236">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvRequisitionStatusID" runat="server" ControlToValidate="ddlRequisitionStatusID"
                            ErrorMessage="Please Select Requisition Status" ValidationGroup="REQRequisitionEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
            <div class="TableRow" style="text-align: center;">
                <div class="TableFormLeble">
                    &nbsp;</div>
            </div>
            <br />
            <div class="lv-c">
                <asp:ListView ID="lvRequisitionItem" runat="server" DataSourceID="odsPRMPreBOQDetail_Custom" OnItemDataBound="lvRequisitionItem_ItemDataBound"
                    OnDataBound="lvRequisitionItem_DataBound">
                    <LayoutTemplate>
                        <table class="lv" cellpadding="0" cellspacing="0">
                            <tr class="h">
                                <td class="rp">
                                    &nbsp;
                                </td>
                                <td style="width: 25px;">
                                <asp:CheckBox ID="chbxHeader" runat="server" Checked="false" OnCheckedChanged="chbxHeader_CheckedChanged" AutoPostBack="true"/>
                                </td>
                                <td class="hi" style="width: 50px;">
                                    Accounts Code
                                </td>
                                <td class="hi">
                                    Parent Category
                                </td>
                                <td class="hi" style="width: 100px;">
                                    Sub Category
                                </td>
                                <td class="hi" style="width:1px;">
                                </td>
                                <td class="hi">
                                   ItemName
                                </td>
                                <td class="hi" style="width:50px;">
                                    Unit
                                </td>
                                <td class="hi" style="width: 50px;">
                                    Rate
                                </td>
                                <td class="hi" style="width: 50px;">
                                    Total Required Qty
                                </td>
                                <td class="hi" style="width: 50px;">
                                    Purchased Qty
                                </td>
                                <td class="hi" style="width: 50px;">
                                    Present Required Qty
                                </td>
                                <td class="hi" style="width: 50px;">
                                   Required Date
                                </td>
                                <td class="hi" style="width:120px;">
                                    Remarks
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
                                            <asp:DataPager ID="dpListView" runat="server" PageSize="15" OnPagePropertiesChanged="lvPRMPreBOQDetail_PagePropertiesChanged">
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
                            <td>
                                <asp:CheckBox ID="chbxState" runat="server" Checked="false" />
                            </td>
                            <td class="i">
                                <asp:TextBox ID="txtAccountsCodeLV" runat="server" CssClass="ktiNumberTextBoxListview" Style="width: 40px;"></asp:TextBox>
                            </td>
                            <td class="i">
                                <%# Eval("ParentCategoryName")%>
                            </td>
                            <td class="i">
                                <%# Eval("CategoryName")%>
                            </td>
                            <td class="i">
                                <asp:Label ID="lblItem" Text='<%# Eval("ItemID")%>' runat="server" Visible="False"></asp:Label>
                            </td>
                            <td class="i">
                                <%# Eval("MDItemItemName")%>
                            </td>
                            <td class="i">
                            <%# Eval("UnitName")%>
                            </td>
                            <td class="i">
                                <asp:TextBox ID="txtRateLV" runat="server" Text='<%# Eval("Rate")%>' CssClass="ktiDecimalTextBoxListview" Style="width:40px;"></asp:TextBox>
                            </td>
                            <td class="i">
                                <asp:TextBox ID="txtQtyLV" runat="server" Text='<%# Eval("TotalQty")%>' Enabled="false" CssClass="ktiDecimalTextBoxListview" Style="width:40px;"></asp:TextBox>
                            </td>
                             <td class="i">
                                <asp:TextBox ID="txtPurchasedQty" runat="server" CssClass="ktiDecimalTextBoxListview" Style="width:40px;"></asp:TextBox>
                            </td>
                             <td class="i">
                                <asp:TextBox ID="txtPresentRequiredQty" runat="server" CssClass="ktiDecimalTextBoxListview" Style="width: 40px;"></asp:TextBox>
                            </td>
                             <td class="i">
                                <asp:TextBox ID="txtRequiredDate" runat="server" CssClass="ktiDateTextBoxListview" Style="width: 70px;"></asp:TextBox>
                            </td>
                            <td class="i">
                                <asp:TextBox ID="txtRemarksLV" runat="server" CssClass="ktiTextBoxListview" Style="width:120px;"></asp:TextBox>
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
                            <td>
                                <asp:CheckBox ID="chbxState" runat="server" />
                            </td>
                            <td class="i">
                                <asp:TextBox ID="txtAccountsCodeLV" runat="server" CssClass="ktiNumberTextBoxListview" Style="width: 40px;"></asp:TextBox>
                            </td>
                            <td class="i">
                                <%# Eval("ParentCategoryName")%>
                            </td>
                            <td class="i">
                                <%# Eval("CategoryName")%>
                            </td>
                            <td class="i">
                                <asp:Label ID="lblItem" Text='<%# Eval("ItemID")%>' runat="server" Visible="False"></asp:Label>
                            </td>
                            <td class="i">
                                <%# Eval("MDItemItemName")%>
                            </td>
                            <td class="i">
                            <%# Eval("UnitName")%>
                            </td>
                             <td class="i">
                                <asp:TextBox ID="txtRateLV" runat="server" Text='<%# Eval("Rate")%>' CssClass="ktiDecimalTextBoxListview" Style="width:40px;"></asp:TextBox>
                            </td>
                            <td class="i">
                                <asp:TextBox ID="txtQtyLV" runat="server" Text='<%# Eval("TotalQty")%>' Enabled="false" CssClass="ktiDecimalTextBoxListview" Style="width: 40px;"></asp:TextBox>
                            </td>
                            <td class="i">
                                <asp:TextBox ID="txtPurchasedQty" runat="server" CssClass="ktiDecimalTextBoxListview" Style="width: 40px;"></asp:TextBox>
                            </td>
                             <td class="i">
                                <asp:TextBox ID="txtPresentRequiredQty" runat="server" CssClass="ktiDecimalTextBoxListview" Style="width: 40px;"></asp:TextBox>
                            </td>
                             <td class="i">
                                <asp:TextBox ID="txtRequiredDate" runat="server" CssClass="ktiDateTextBoxListview" Style="width:70px;"></asp:TextBox>
                            </td>
                            <td class="i">
                                <asp:TextBox ID="txtRemarksLV" runat="server" CssClass="ktiTextBoxListview" Style="width:120px;"></asp:TextBox>
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
            <asp:ObjectDataSource ID="odsPRMPreBOQDetail_Custom" runat="server" SelectMethod="GetPagedData"
                SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.PRMPreBOQDetail_CustomDataSource"
                SortParameterName="sortExpression" OnSelecting="odsPRMPreBOQDetail_Custom_Selecting">
                <SelectParameters>
                    <asp:Parameter Name="startRowIndex" Type="Int32" />
                    <asp:Parameter Name="pageSize" Type="Int32" />
                    <asp:Parameter Name="sortExpression" Type="String" />
                    <asp:Parameter Name="filterExpression" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <div class="TableFormContent">
                <kti:SecureButton ID="btnSubmit" ValidationGroup="REQRequisitionEntity" OnClick="btnSave_Click"
                    runat="server" Text="Save" UniqueKey="REQRequisitionMasterControl_Submit_key" />
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
