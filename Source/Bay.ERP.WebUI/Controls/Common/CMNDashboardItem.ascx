<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 19-Feb-2012, 06:02:47
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CMNDashboardItem.ascx.cs"
    Inherits="Bay.ERP.Web.UI.CMNDashboardItemControl" %>
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
                    <asp:Label ID="lvlCollapsText" runat="server" Text="Add/Edit Dashboard Item"></asp:Label>
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
                    <div class="TableFormLeble" style="text-align: left;">
                        Parent Dashboard&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlParentDashboardItemID" CssClass="ktiSelect" ClientIDMode="Static"
                            AutoPostBack="true" OnSelectedIndexChanged="ddlParentDashboardItemID_SelectedIndexChanged"
                            runat="server" ValidationGroup="CMNDashboardItemEntity" Width="236">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Title&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtTitle">
                            Enter Title</label>
                        <asp:TextBox ID="txtTitle" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="CMNDashboardItemEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvTitle" runat="server" ControlToValidate="txtTitle"
                            ErrorMessage="Please Enter Title" ValidationGroup="CMNDashboardItemEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Tittle Color&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtTittleColor">
                            Enter Tittle Color</label>
                        <asp:TextBox ID="txtTittleColor" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="CMNDashboardItemEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvTittleColor" runat="server" ControlToValidate="txtTittleColor"
                            ErrorMessage="Please Enter Tittle Color" ValidationGroup="CMNDashboardItemEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Description&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtDescription" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="CMNDashboardItemEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Description Color&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtDescriptionColor">
                            Enter Description Color</label>
                        <asp:TextBox ID="txtDescriptionColor" ClientIDMode="Static" CssClass="ktiTextBox"
                            runat="server" ValidationGroup="CMNDashboardItemEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvDescriptionColor" runat="server" ControlToValidate="txtDescriptionColor"
                            ErrorMessage="Please Enter Description Color" ValidationGroup="CMNDashboardItemEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Image Url&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <asp:FileUpload ID="fuImageUrl" ClientIDMode="Static" runat="server" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvImageUrl" runat="server" ControlToValidate="fuImageUrl"
                            ErrorMessage="Please Enter Image Url" ValidationGroup="CMNDashboardItemEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Hover Image Url&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:FileUpload ID="fuHoverImageUrl" ClientIDMode="Static" runat="server" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Navigation Url&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtNavigationUrl">
                            Enter Navigation Url</label>
                        <asp:TextBox TextMode="SingleLine" CssClass="ktiTextBox" Width="230" ClientIDMode="Static"
                            ID="txtNavigationUrl" runat="server" ValidationGroup="CMNDashboardItemEntity" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvNavigationUrl" runat="server" ControlToValidate="txtNavigationUrl"
                            ErrorMessage="Please Enter Navigation Url" ValidationGroup="CMNDashboardItemEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                    <div class="NoteLabel">
                        Note:Enter Url like '~/REQ/REQRequisition.aspx'</div>
                    <div>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Hover Message&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtHoverMessage" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="CMNDashboardItemEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100; display:none;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Sequence&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtSequenceID">
                            Enter Sequence</label>
                        <asp:TextBox ID="txtSequenceID" CssClass="ktiNumberTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="CMNDashboardItemEntity" Width="210" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvSequenceID" runat="server" ControlToValidate="txtSequenceID"
                            ErrorMessage="Please Enter Sequence" ValidationGroup="CMNDashboardItemEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvSequenceID" runat="server" ControlToValidate="txtSequenceID"
                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136)"
                            MinimumValue="-2147483648" MaximumValue="2147483647" Type="Integer" ValidationGroup="CMNDashboardItemEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Image Width&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtImageWidth">
                            Enter Image Width</label>
                        <asp:TextBox ID="txtImageWidth" CssClass="ktiNumberTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="CMNDashboardItemEntity" Width="210" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvImageWidth" runat="server" ControlToValidate="txtImageWidth"
                            ErrorMessage="Please Enter Image Width" ValidationGroup="CMNDashboardItemEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvImageWidth" runat="server" ControlToValidate="txtImageWidth"
                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136)"
                            MinimumValue="-2147483648" MaximumValue="2147483647" Type="Integer" ValidationGroup="CMNDashboardItemEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Image Height&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtImageHeight">
                            Enter Image Height</label>
                        <asp:TextBox ID="txtImageHeight" CssClass="ktiNumberTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="CMNDashboardItemEntity" Width="210" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvImageHeight" runat="server" ControlToValidate="txtImageHeight"
                            ErrorMessage="Please Enter Image Height" ValidationGroup="CMNDashboardItemEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvImageHeight" runat="server" ControlToValidate="txtImageHeight"
                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136)"
                            MinimumValue="-2147483648" MaximumValue="2147483647" Type="Integer" ValidationGroup="CMNDashboardItemEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Item Width&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtDashboardItemWidth">
                            Enter Dashboard Item Width</label>
                        <asp:TextBox ID="txtDashboardItemWidth" CssClass="ktiNumberTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="CMNDashboardItemEntity" Width="210" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvDashboardItemWidth" runat="server" ControlToValidate="txtDashboardItemWidth"
                            ErrorMessage="Please Enter Dashboard Item Width" ValidationGroup="CMNDashboardItemEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvDashboardItemWidth" runat="server" ControlToValidate="txtDashboardItemWidth"
                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136)"
                            MinimumValue="-2147483648" MaximumValue="2147483647" Type="Integer" ValidationGroup="CMNDashboardItemEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Item Height&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtDashboardItemHeight">
                            Enter Dashboard Item Height</label>
                        <asp:TextBox ID="txtDashboardItemHeight" CssClass="ktiNumberTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="CMNDashboardItemEntity" Width="210" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvDashboardItemHeight" runat="server" ControlToValidate="txtDashboardItemHeight"
                            ErrorMessage="Please Enter Dashboard Item Height" ValidationGroup="CMNDashboardItemEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvDashboardItemHeight" runat="server" ControlToValidate="txtDashboardItemHeight"
                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136)"
                            MinimumValue="-2147483648" MaximumValue="2147483647" Type="Integer" ValidationGroup="CMNDashboardItemEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Is Popup&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:CheckBox ID="chkIsPopup" runat="server" ClientIDMode="Static" ValidationGroup="CMNDashboardItemEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100; display: none;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Is Removed&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:CheckBox ID="chkIsRemoved" runat="server" ClientIDMode="Static" ValidationGroup="CMNDashboardItemEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="CMNDashboardItemEntity" OnClick="btnSave_Click"
                            runat="server" Text="Add" UniqueKey="CMNDashboardItemControl_Submit_key" />
                        <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click" runat="server"
                            Text="Add New" UniqueKey="CMNDashboardItemControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear"
                            UniqueKey="CMNDashboardItemControl_Clear_key" />
                    </div>
                </div>
                <br />
            </asp:Panel>
            <div class="listContentTitle">
                Dashboard Item List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvCMNDashboardItem" runat="server" DataSourceID="odsCMNDashboardItem"
                        OnItemCommand="lvCMNDashboardItem_ItemCommand">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi">
                                    <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByParentDashboardItemName"
                                            CommandName="Sort" Text="Parent Dashboard Item" CommandArgument="ParentCMNDashboardItem.Title"/>
                                    </td>
                                    <td class="hi">
                                    <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByTitle"
                                            CommandName="Sort" Text="Title" CommandArgument="CMNDashboardItem.Title" />
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Tittle Color
                                    </td>
                                    <td class="hi">
                                        Description
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Description Color
                                    </td>
                                    <td class="hi">
                                        Image Url
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Hover Image Url
                                    </td>
                                    <td class="hi" style="width:240px;">
                                        Navigation Url
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Is Popup
                                    </td>
                                    <td class="hi">
                                        Hover Message
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Sequence
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Image Width
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Image Height
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Dashboard Item Width
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Dashboard Item Height
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Is Removed
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
                                                <asp:DataPager ID="dpListView" runat="server" PageSize="5">
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
                                    <%# Eval("CMNDashboardItemParentDashboardItemName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Title")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("TittleColor")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Description")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("DescriptionColor")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ImageUrl")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("HoverImageUrl")%>
                                </td>
                                <td class="i">
                                    <%# Eval("NavigationUrl")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("IsPopup") != null ? (((Boolean)Eval("IsPopup")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("HoverMessage")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("SequenceID")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("ImageWidth")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("ImageHeight")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("DashboardItemWidth")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("DashboardItemHeight")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("IsRemoved") != null ? (((Boolean)Eval("IsRemoved")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("DashboardItemID")%>'
                                        UniqueKey="CMNDashboardItem_lvCMNDashboardItem_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Dashboard Item?')"
                                        CommandArgument='<%#Eval("DashboardItemID")%>' UniqueKey="CMNDashboardItem_lvCMNDashboardItem_Delete_key" />
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
                                    <%# Eval("CMNDashboardItemParentDashboardItemName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Title")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("TittleColor")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Description")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("DescriptionColor")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ImageUrl")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("HoverImageUrl")%>
                                </td>
                                <td class="i" >
                                    <%# Eval("NavigationUrl")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("IsPopup") != null ? (((Boolean)Eval("IsPopup")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("HoverMessage")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("SequenceID")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("ImageWidth")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("ImageHeight")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("DashboardItemWidth")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("DashboardItemHeight")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("IsRemoved") != null ? (((Boolean)Eval("IsRemoved")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("DashboardItemID")%>'
                                        UniqueKey="CMNDashboardItem_lvCMNDashboardItem_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Dashboard Item?')"
                                        CommandArgument='<%#Eval("DashboardItemID")%>' UniqueKey="CMNDashboardItem_lvCMNDashboardItem_Delete_key" />
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
                <asp:ObjectDataSource ID="odsCMNDashboardItem" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.CMNDashboardItem_DetailedDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsCMNDashboardItem_Selecting">
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
