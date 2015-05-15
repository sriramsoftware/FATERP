<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 02-Apr-2013, 12:12:56
--%>




<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CRMBuyerBookSpace.ascx.cs"
    Inherits="Bay.ERP.Web.UI.CRMBuyerBookSpaceControl" %>



<asp:UpdatePanel ID="upMauin" runat="server">
     <Triggers>
        <asp:PostBackTrigger ControlID="btnSubmit" />
    </Triggers>
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
                    <asp:Label ID="lvlCollapsText" runat="server" Text="Add/Edit Book Space"></asp:Label>
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
                        Landowner&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:CheckBox ID="chkIsLandOwner" runat="server" ClientIDMode="Static" ValidationGroup="CRMBuyerBookSpaceEntity" AutoPostBack="true" OnCheckedChanged="chkIsLandOwner_CheckedChanged" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                  <asp:Label ID="lblLandOwnerInfo" runat="server" Text="Buyer Info"></asp:Label>
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlBuyerBasicInfoID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="CRMBuyerBookSpaceEntity" Width="330">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvBuyerBasicInfoID" runat="server" ControlToValidate="ddlBuyerBasicInfoID"
                            ErrorMessage="Please Select Buyer Basic Info" ValidationGroup="CRMBuyerBookSpaceEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Project&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlProjectID" CssClass="ktiSelect" ClientIDMode="Static" AutoPostBack="true" OnSelectedIndexChanged="ddlProjectID_SelectedIndexChanged"
                            runat="server" ValidationGroup="CRMBuyerBookSpaceEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvProjectID" runat="server" ControlToValidate="ddlProjectID"
                            ErrorMessage="Please Select Project" ValidationGroup="CRMBuyerBookSpaceEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Project Floor Unit&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlProjectFloorUnitID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="CRMBuyerBookSpaceEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvProjectFloorUnitID" runat="server" ControlToValidate="ddlProjectFloorUnitID"
                            ErrorMessage="Please Select Project Floor Unit" ValidationGroup="CRMBuyerBookSpaceEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Booking Note&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtBookingNote" runat="server" ValidationGroup="CRMBuyerBookSpaceEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
               
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Approved By Mgt.&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:CheckBox ID="chkIsApprovedByManagement" runat="server" ClientIDMode="Static" ValidationGroup="CRMBuyerBookSpaceEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Booking Status&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlBookingStatusID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="CRMBuyerBookSpaceEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvBookingStatusID" runat="server" ControlToValidate="ddlBookingStatusID"
                            ErrorMessage="Please Select Booking Status" ValidationGroup="CRMBuyerBookSpaceEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Upload File&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:FileUpload ID="fuImageUrl" ClientIDMode="Static" runat="server" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                 <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                    </div>
                    <div class="TableFormContent">
                    <asp:Label ID="lblFormLock" runat="server" Text="Note: Please Select Floor Unit Carefully." CssClass="msgLock"></asp:Label>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="CRMBuyerBookSpaceEntity" OnClick="btnSave_Click"
                            runat="server" Text="Save and Book Another" UniqueKey="CRMBuyerBookSpaceControl_Submit_key" />
                        <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click"
                            runat="server" Text="Add New" UniqueKey="CRMBuyerBookSpaceControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click"
                            runat="server" Text="Clear" UniqueKey="CRMBuyerBookSpaceControl_Clear_key" />
                    </div>
                </div>
                <br />
            </asp:Panel>
            <br />
             <div class="TableRow" style="width: 100%; float: right;">
                <div class="TableFormLeble">
                    &nbsp;</div>
                <div class="TableFormLeble" style="text-align: right; width: 617px;">
                    Filter Text&nbsp;:
                </div>
                <div class="TableFormContent waterMarkContainer">
                    <label class="watermarkLabel" for="txtSearchText">
                        Type Buyer or Name</label>
                    <asp:TextBox ID="txtSearchText" runat="server" ClientIDMode="Static" CssClass="ktiTextBox"
                        Width="230" /><span><asp:CheckBox ID="chbxFilter" runat="server" AutoPostBack="true"
                            OnCheckedChanged="chbxFilter_CheckedChanged" Text="Use Filter" /></span>
                </div>
            </div>
            <div class="listContentTitle">
                Book Space List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvCRMBuyerBookSpace" runat="server" DataSourceID="odsCRMBuyerBookSpace" OnItemCommand="lvCRMBuyerBookSpace_ItemCommand" OnItemDataBound="lvCRMBuyerBookSpace_ItemDataBound">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi">
                                        Buyer Basic Info
                                    </td>
                                    <td class="hi">
                                        Project
                                    </td>
                                    <td class="hi">
                                        Project Floor Unit
                                    </td>
                                    <td class="hi">
                                        Booking Note
                                    </td>
                                    <td class="hi">
                                        Is Landowner
                                    </td>
                                    <td class="hi">
                                        Is Approved By Management
                                    </td>
                                    <td class="hi">
                                        Booking Status
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
                                 <asp:HyperLink ID="hypContatFullNameLV" runat="server" ClientIDMode="Static" Text='<%# Eval("ContactFullName")%>'
                                    ToolTip="Please Click Here To Edit The Template Items!" CssClass="CommonLink"></asp:HyperLink>
                                </td>
                                <td class="i">
                                    <%# Eval("ProjectName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BDProjectFloorUnitProjectFloorUnitName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BookingNote")%>
                                </td>
                                <td class="i">
                                    <%# Eval("IsLandOwner") != null ? (((Boolean)Eval("IsLandOwner")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("IsApprovedByManagement") != null ? (((Boolean)Eval("IsApprovedByManagement")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("BookingStatusName")%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("BuyerBookSpaceID")%>' UniqueKey="CRMBuyerBookSpace_lvCRMBuyerBookSpace_Edit_key" />
                                </td>
                                <td class="i">
                            <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete C RMBuyer Book Space?')"
                                        CommandArgument='<%#Eval("BuyerBookSpaceID")%>' UniqueKey="CRMBuyerBookSpace_lvCRMBuyerBookSpace_Delete_key"/>
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
                                    <asp:HyperLink ID="hypContatFullNameLV" runat="server" ClientIDMode="Static" Text='<%# Eval("ContactFullName")%>'
                                    ToolTip="Please Click Here To Edit The Template Items!" CssClass="CommonLink"></asp:HyperLink>
                                </td>
                                <td class="i">
                                    <%# Eval("ProjectName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BDProjectFloorUnitProjectFloorUnitName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BookingNote")%>
                                </td>
                                <td class="i">
                                    <%# Eval("IsLandOwner") != null ? (((Boolean)Eval("IsLandOwner")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("IsApprovedByManagement") != null ? (((Boolean)Eval("IsApprovedByManagement")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("BookingStatusName")%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("BuyerBookSpaceID")%>' UniqueKey="CRMBuyerBookSpace_lvCRMBuyerBookSpace_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete C RMBuyer Book Space?')"
                                        CommandArgument='<%#Eval("BuyerBookSpaceID")%>' UniqueKey="CRMBuyerBookSpace_lvCRMBuyerBookSpace_Delete_key"/>
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
                <asp:ObjectDataSource ID="odsCRMBuyerBookSpace" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.CRMBuyerBookSpace_DetailedDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsCRMBuyerBookSpace_Selecting">
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
