<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 01-Apr-2013, 02:41:21
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CRMLandBasicInfo.ascx.cs"
    Inherits="Bay.ERP.Web.UI.CRMLandBasicInfoControl" %>

    <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit.HTMLEditor"
    TagPrefix="HTMLEditor" %>

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
                    <asp:Label ID="lvlCollapsText" runat="server" Text="Add/Edit Land Basic Info"></asp:Label>
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
                        Landowner Type&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlLandOwnerTypeID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="CRMLandBasicInfoEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvLandOwnerTypeID" runat="server" ControlToValidate="ddlLandOwnerTypeID"
                            ErrorMessage="Please Select Landowner Type" ValidationGroup="CRMLandBasicInfoEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Contact Full Name&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtContactFullName">
                            Enter Contact Full Name</label>
                        <asp:TextBox ID="txtContactFullName" ClientIDMode="Static" CssClass="ktiTextBox"
                            runat="server" ValidationGroup="CRMLandBasicInfoEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvContactFullName" runat="server" ControlToValidate="txtContactFullName"
                            ErrorMessage="Please Enter Contact Full Name" ValidationGroup="CRMLandBasicInfoEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Mobile No&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtMobileNo">
                            Enter Mobile No</label>
                        <asp:TextBox ID="txtMobileNo" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="CRMLandBasicInfoEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvMobileNo" runat="server" ControlToValidate="txtMobileNo"
                            ErrorMessage="Please Enter Mobile No" ValidationGroup="CRMLandBasicInfoEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Land Phone&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtLandPhone" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="CRMLandBasicInfoEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revLandPhone" runat="server" ControlToValidate="txtLandPhone"
                            Display="Dynamic" EnableViewState="true" ValidationGroup="CRMLandBasicInfoEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Present Address&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="530" ClientIDMode="Static"
                            ID="txtPresentAddress" runat="server" ValidationGroup="CRMLandBasicInfoEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Email&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtEmail" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="CRMLandBasicInfoEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail"
                            Display="Dynamic" EnableViewState="true" ValidationGroup="CRMLandBasicInfoEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Location&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlInterestedLandLocationID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="CRMLandBasicInfoEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvInterestedLandLocationID" runat="server" ControlToValidate="ddlInterestedLandLocationID"
                            ErrorMessage="Please Select Interested Land Location" ValidationGroup="CRMLandBasicInfoEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        City&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlCityID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                            ValidationGroup="CRMLandBasicInfoEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvCityID" runat="server" ControlToValidate="ddlCityID"
                            ErrorMessage="Please Select City" ValidationGroup="CRMLandBasicInfoEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Land Area&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtLandArea1" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="CRMLandBasicInfoEntity" Width="90" />
                            <asp:DropDownList ID="ddlAreaUnitID1" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="CRMLandBasicInfoEntity" Width="90"></asp:DropDownList>
                            <asp:TextBox ID="txtLandArea2" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="CRMLandBasicInfoEntity" Width="90" />
                            <asp:DropDownList ID="ddlAreaUnitID2" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="CRMLandBasicInfoEntity" Width="90">
                        
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Plot Description&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtPlotNumber">
                            Enter Plot Description</label>
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="530" ClientIDMode="Static"
                            ID="txtPlotNumber" runat="server" ValidationGroup="CRMLandBasicInfoEntity" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvPlotNumber" runat="server" ControlToValidate="txtPlotNumber"
                            ErrorMessage="Please Enter Plot Number" ValidationGroup="CRMLandBasicInfoEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Plot Address&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtPlotNumber">
                            Enter Plot Address</label>
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="530" ClientIDMode="Static"
                            ID="txtPlotAddress" runat="server" ValidationGroup="CRMLandBasicInfoEntity" />
                            <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                     <asp:RequiredFieldValidator ID="rfvtxtPlotAddress" runat="server" ControlToValidate="txtPlotAddress"
                            ErrorMessage="Please Enter Plot Address" ValidationGroup="CRMLandBasicInfoEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Plot Map Url&nbsp;:
                    </div>
                    <div class="TableFormContent">
                    <HTMLEditor:Editor runat="server" ID="txtPlotMapUrl" ValidationGroup="CRMLandBasicInfoEntity"
                                Height="300px" AutoFocus="true" Width="530" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100; display:none;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Area&nbsp;:
                    </div>

                    <div class="TableFormContent">
                        <asp:TextBox ID="txtArea" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="CRMLandBasicInfoEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Dimension&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtDimension" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="CRMLandBasicInfoEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Special Features&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="530" ClientIDMode="Static"
                            ID="txtSpecialFeatures" runat="server" ValidationGroup="CRMLandBasicInfoEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Structure&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="530" ClientIDMode="Static"
                            ID="txtStructure" runat="server" ValidationGroup="CRMLandBasicInfoEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        RAJUK Details&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="530" ClientIDMode="Static"
                            ID="txtRAJUKDetails" runat="server" ValidationGroup="CRMLandBasicInfoEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Lead Generated By&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlLeadGeneratedByEmployeeID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="CRMLandBasicInfoEntity" Width="234">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Lead Managed By&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlLeadManagedByOneEmployeeID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="CRMLandBasicInfoEntity" Width="234">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Lead Managed By&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlLeadManagedByTwoEmployeeID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="CRMLandBasicInfoEntity" Width="234">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Conversion Date&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtLeadConversionDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="CRMLandBasicInfoEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revLeadConversionDate" runat="server" ControlToValidate="txtLeadConversionDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="CRMLandBasicInfoEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Referred By&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlReferredByEmployeeID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="CRMLandBasicInfoEntity" Width="234">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Land Own Of Project&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlLandOwnerOfProject" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="CRMLandBasicInfoEntity" Width="234">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="CRMLandBasicInfoEntity" OnClick="btnSave_Click"
                            runat="server" Text="Save and Add New" UniqueKey="CRMLandBasicInfoControl_Submit_key" />
                             <kti:SecureButton ID="btnSubmitAndCommunicate" ValidationGroup="CRMLandBasicInfoEntity" OnClick="btnSubmitAndCommunicate_Click"
                            runat="server" Text="Save And Communicate" UniqueKey="CRMLandBasicInfoControl_Submit_key" />
                        <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click" runat="server"
                            Text="Add New" UniqueKey="CRMLandBasicInfoControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear"
                            UniqueKey="CRMLandBasicInfoControl_Clear_key" />
                            <asp:Button ID="btnImportInfo" OnClick="btnImportInfo_Click" runat="server" Text="Get From Website" ToolTip="You may not see Imported Data because of permission issue."/>
                    </div>
                </div>
                <br />
            </asp:Panel>
            <div class="listContentTitle">
                Land Basic Info List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvCRMLandBasicInfo" runat="server" DataSourceID="odsCRMLandBasicInfo"
                        OnItemCommand="lvCRMLandBasicInfo_ItemCommand" OnItemDataBound="lvCRMLandBasicInfo_ItemDataBound">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi">
                                        Landowner
                                    </td>
                                    <td class="hi">
                                        Current Status
                                    </td>
                                    <td class="hi">
                                        Landowner Type
                                    </td>
                                    <td class="hi">
                                        Contact Full Name
                                    </td>
                                    <td class="hi">
                                        Mobile No
                                    </td>
                                    <td class="hi">
                                        Land Phone
                                    </td>
                                    <td class="hi">
                                        Present Address
                                    </td>
                                    <td class="hi">
                                        Email
                                    </td>
                                    <td class="hi">
                                        Interested Land Location
                                    </td>
                                    <td class="hi">
                                        City
                                    </td>
                                    <td class="hi">
                                        Land Area
                                    </td>
                                    <td class="hi">
                                        Plot Number
                                    </td>
                                    <td class="hi">
                                        Plot Address
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Plot Map Url
                                    </td>
                                    <td class="hi">
                                        Dimension
                                    </td>
                                    <td class="hi">
                                        Special Features
                                    </td>
                                    <td class="hi">
                                        Structure
                                    </td>
                                    <td class="hi">
                                        RAJUK Details
                                    </td>
                                    <td class="hi">
                                        Lead Generated
                                    </td>
                                    <td class="hi">
                                        Lead Managed By
                                    </td>
                                    <td class="hi">
                                        Lead Managed By
                                    </td>
                                    <td class="hi">
                                        Lead Conversion Date
                                    </td>
                                    <td class="hi">
                                        Landowner Of Project
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
                                    <asp:HyperLink ID="hypLandOwnerInfo" runat="server" Text="Landowner" CssClass="CommonLink"
                                        ToolTip="Please Click Here To See The Landowner!"></asp:HyperLink>
                                </td>
                                 <td class="i">
                                    <asp:HyperLink ID="hypLandCurrentStatus" runat="server" Text="Land Current Status" CssClass="CommonLink"
                                        ToolTip="Please Click Here To See The Land Current Status!"></asp:HyperLink>
                                </td>
                                <td class="i">
                                    <%# Eval("CRMMDLandOwnerTypeName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ContactFullName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MobileNo")%>
                                </td>
                                <td class="i">
                                    <%# Eval("LandPhone")%>
                                </td>
                                <td class="i">
                                    <%# Eval("PresentAddress")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Email")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CRMMDLandLocationName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MDCityName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("LandArea1")%>
                                </td>
                                <td class="i">
                                    <%# Eval("PlotNumber")%>
                                </td>
                                <td class="i">
                                    <%# Eval("PlotAddress")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("PlotMapUrl")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Dimension")%>
                                </td>
                                <td class="i">
                                    <%# Eval("SpecialFeatures")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Structure")%>
                                </td>
                                <td class="i">
                                    <%# Eval("RAJUKDetails")%>
                                </td>
                                <td class="i">
                                    <%# Eval("LeadGeneratedByMemberFullName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("LeadManagedByOneMemberFullName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("LeadManagedByTwoMemberFullName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("LeadConversionDate") != null ? ((DateTime)Eval("LeadConversionDate")).ToString("mm-dd-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("BDProjectProjectName")%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("LandBasicInfoID")%>'
                                        UniqueKey="CRMLandBasicInfo_lvCRMLandBasicInfo_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Land Basic Info?')"
                                        CommandArgument='<%#Eval("LandBasicInfoID")%>' UniqueKey="CRMLandBasicInfo_lvCRMLandBasicInfo_Delete_key" />
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
                                    <asp:HyperLink ID="hypLandOwnerInfo" runat="server" Text="Landowner" CssClass="CommonLink"
                                        ToolTip="Please Click Here To See The Landowner!"></asp:HyperLink>
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="hypLandCurrentStatus" runat="server" Text="Land Current Status" CssClass="CommonLink"
                                        ToolTip="Please Click Here To See The Land Current Status!"></asp:HyperLink>
                                </td>
                               <td class="i">
                                    <%# Eval("CRMMDLandOwnerTypeName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ContactFullName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MobileNo")%>
                                </td>
                                <td class="i">
                                    <%# Eval("LandPhone")%>
                                </td>
                                <td class="i">
                                    <%# Eval("PresentAddress")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Email")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CRMMDLandLocationName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MDCityName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("LandArea1")%>
                                </td>
                                <td class="i">
                                    <%# Eval("PlotNumber")%>
                                </td>
                                <td class="i">
                                    <%# Eval("PlotAddress")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("PlotMapUrl")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Dimension")%>
                                </td>
                                <td class="i">
                                    <%# Eval("SpecialFeatures")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Structure")%>
                                </td>
                                <td class="i">
                                    <%# Eval("RAJUKDetails")%>
                                </td>
                                <td class="i">
                                    <%# Eval("LeadGeneratedByMemberFullName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("LeadManagedByOneMemberFullName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("LeadManagedByTwoMemberFullName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("LeadConversionDate") != null ? ((DateTime)Eval("LeadConversionDate")).ToString("mm-dd-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("BDProjectProjectName")%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("LandBasicInfoID")%>'
                                        UniqueKey="CRMLandBasicInfo_lvCRMLandBasicInfo_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Land Basic Info?')"
                                        CommandArgument='<%#Eval("LandBasicInfoID")%>' UniqueKey="CRMLandBasicInfo_lvCRMLandBasicInfo_Delete_key" />
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
                <asp:ObjectDataSource ID="odsCRMLandBasicInfo" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.CRMLandBasicInfo_DetailedDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsCRMLandBasicInfo_Selecting">
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
