<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 14-Aug-2013, 02:50:29
--%>




<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CMBillFloorDetail.ascx.cs"
    Inherits="Bay.ERP.Web.UI.CMBillFloorDetailControl" %>

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
                    <asp:Label ID="lvlCollapsText" runat="server" Text="Add/Edit C MBill Floor Detail"></asp:Label>
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
                    <div class="TableFormLeble" style="text-align: right;">
                        Bill&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlBillID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="CMBillFloorDetailEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvBillID" runat="server" ControlToValidate="ddlBillID"
                            ErrorMessage="Please Select Bill" ValidationGroup="CMBillFloorDetailEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Bill Floor Detail Category&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlBillFloorDetailCategoryID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="CMBillFloorDetailEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvBillFloorDetailCategoryID" runat="server" ControlToValidate="ddlBillFloorDetailCategoryID"
                            ErrorMessage="Please Select Bill Floor Detail Category" ValidationGroup="CMBillFloorDetailEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Project Floor&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlProjectFloorID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="CMBillFloorDetailEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvProjectFloorID" runat="server" ControlToValidate="ddlProjectFloorID"
                            ErrorMessage="Please Select Project Floor" ValidationGroup="CMBillFloorDetailEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Project Floor Unit&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlProjectFloorUnitID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="CMBillFloorDetailEntity" Width="234">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Floor Bill Amount&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtFloorBillAmount" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="CMBillFloorDetailEntity" Type="Number" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvFloorBillAmount" runat="server" ControlToValidate="txtFloorBillAmount" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="CMBillFloorDetailEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Remarks&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtRemarks" runat="server" ValidationGroup="CMBillFloorDetailEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Entry Date&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtEntryDate">
                            Enter Entry Date</label>
                        <asp:TextBox ID="txtEntryDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="CMBillFloorDetailEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvEntryDate" runat="server" ControlToValidate="txtEntryDate"
                            ErrorMessage="Please Enter Entry Date" ValidationGroup="CMBillFloorDetailEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revEntryDate" runat="server" ControlToValidate="txtEntryDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)\d\d$"
                            ValidationGroup="CMBillFloorDetailEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Extra1&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtExtra1" runat="server" ValidationGroup="CMBillFloorDetailEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Extra2&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtExtra2" runat="server" ValidationGroup="CMBillFloorDetailEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="CMBillFloorDetailEntity" OnClick="btnSave_Click"
                            runat="server" Text="Add" UniqueKey="CMBillFloorDetailControl_Submit_key" />
                        <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click"
                            runat="server" Text="Add New" UniqueKey="CMBillFloorDetailControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click"
                            runat="server" Text="Clear" UniqueKey="CMBillFloorDetailControl_Clear_key" />
                    </div>
                </div>
                <br />
            </asp:Panel>
            <div class="listContentTitle">
                C MBill Floor Detail List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvCMBillFloorDetail" runat="server" DataSourceID="odsCMBillFloorDetail" OnItemCommand="lvCMBillFloorDetail_ItemCommand">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi">
                                        Bill
                                    </td>
                                    <td class="hi">
                                        Bill Floor Detail Category
                                    </td>
                                    <td class="hi">
                                        Project Floor
                                    </td>
                                    <td class="hi">
                                        Project Floor Unit
                                    </td>
                                    <td class="hi">
                                        Floor Bill Amount
                                    </td>
                                    <td class="hi">
                                        Remarks
                                    </td>
                                    <td class="hi">
                                        Entry Date
                                    </td>
                                    <td class="hi">
                                        Extra1
                                    </td>
                                    <td class="hi">
                                        Extra2
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
                                    <%# Eval("BillID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BillFloorDetailCategoryID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ProjectFloorID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ProjectFloorUnitID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("FloorBillAmount")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i">
                                    <%# Eval("EntryDate") != null ? ((DateTime)Eval("EntryDate")).ToString("mm-dd-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("Extra1")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Extra2")%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("BillFloorDetailID")%>' UniqueKey="CMBillFloorDetail_lvCMBillFloorDetail_Edit_key" />
                                </td>
                                <td class="i">
                            <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete C MBill Floor Detail?')"
                                        CommandArgument='<%#Eval("BillFloorDetailID")%>' UniqueKey="CMBillFloorDetail_lvCMBillFloorDetail_Edit_key"/>
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
                                    <%# Eval("BillID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BillFloorDetailCategoryID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ProjectFloorID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ProjectFloorUnitID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("FloorBillAmount")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i">
                                    <%# Eval("EntryDate") != null ? ((DateTime)Eval("EntryDate")).ToString("mm-dd-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("Extra1")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Extra2")%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("BillFloorDetailID")%>' UniqueKey="CMBillFloorDetail_lvCMBillFloorDetail_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete C MBill Floor Detail?')"
                                        CommandArgument='<%#Eval("BillFloorDetailID")%>' UniqueKey="CMBillFloorDetail_lvCMBillFloorDetail_Edit_key"/>
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
                <asp:ObjectDataSource ID="odsCMBillFloorDetail" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.CMBillFloorDetailDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsCMBillFloorDetail_Selecting">
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
