<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 B2B Solutions, info@b2b-erp.com.
 ©2006 – 2010.

 Code Generate Time - 08-Oct-2013, 02:28:24
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CMNEvent.ascx.cs" Inherits="Bay.ERP.Web.UI.CMNEventControl" %>
<script type="text/javascript">
    function BindEvents() {
        $(document).ready(function () {
            $('#txtExpectedStartDate').timepicker();
            $('#txtExpectedEndDate').timepicker();
            $('#txtActualStartDate').timepicker();
            $('#txtActualEndDate').timepicker();
        });
    }
</script>
<style type="text/css">
    div.demo
    {
        padding: 8px !important;
    }
</style>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <script type="text/javascript">
            Sys.Application.add_load(BindEvents);
        </script>
        <ajaxToolkit:CollapsiblePanelExtender ID="cpeEditor" runat="server" TargetControlID="pnlEditor"
            ExpandControlID="divCollapsControl" CollapseControlID="divCollapsControl" Collapsed="true"
            ImageControlID="imgExpandCollaps" CollapsedImage="~/Images/expand-plus.gif" ExpandedImage="~/Images/collapse-minus.gif"
            SuppressPostBack="false">
        </ajaxToolkit:CollapsiblePanelExtender>
        <ajaxToolkit:CollapsiblePanelExtender ID="cpeUrlDetailControl" runat="server" TargetControlID="pnlUrlDetail"
            ExpandControlID="divUrlDetailControl" CollapseControlID="divUrlDetailControl"
            Collapsed="true" ImageControlID="imgExpandCollaps" CollapsedImage="~/Images/expand-plus.gif"
            ExpandedImage="~/Images/collapse-minus.gif" SuppressPostBack="false">
        </ajaxToolkit:CollapsiblePanelExtender>
        <ajaxToolkit:CollapsiblePanelExtender ID="cpeLocationDetail" runat="server" TargetControlID="pnlLocationDetail"
            ExpandControlID="dvLocationDetail" CollapseControlID="dvLocationDetail" Collapsed="true"
            ImageControlID="imgExpandCollaps" CollapsedImage="~/Images/expand-plus.gif" ExpandedImage="~/Images/collapse-minus.gif"
            SuppressPostBack="false">
        </ajaxToolkit:CollapsiblePanelExtender>
        <ajaxToolkit:CollapsiblePanelExtender ID="cpeSetting" runat="server" TargetControlID="pnlSetting"
            ExpandControlID="dvSetting" CollapseControlID="dvSetting" Collapsed="true" ImageControlID="imgExpandCollaps"
            CollapsedImage="~/Images/expand-plus.gif" ExpandedImage="~/Images/collapse-minus.gif"
            SuppressPostBack="false">
        </ajaxToolkit:CollapsiblePanelExtender>
        <div>
            <div class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    Event Category&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlEventCategoryID" CssClass="ktiSelect" ClientIDMode="Static"
                        runat="server" ValidationGroup="CMNEventEntity" Width="234">
                    </asp:DropDownList>
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvEventCategoryID" runat="server" ControlToValidate="ddlEventCategoryID"
                        ErrorMessage="Please Select Event Category" ValidationGroup="CMNEventEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    Reference No&nbsp;:
                </div>
                <div class="TableFormContent waterMarkContainer">
                    <label class="watermarkLabel" for="txtEventReferenceNo">
                        Enter Event Reference No</label>
                    <asp:TextBox ID="txtEventReferenceNo" ClientIDMode="Static" CssClass="ktiTextBox"
                        ReadOnly="true" runat="server" ValidationGroup="CMNEventEntity" Width="230" />
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvEventReferenceNo" runat="server" ControlToValidate="txtEventReferenceNo"
                        ErrorMessage="Please Enter Event Reference No" ValidationGroup="CMNEventEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    Title&nbsp;:
                </div>
                <div class="TableFormContent waterMarkContainer">
                    <label class="watermarkLabel" for="txtTitle">
                        Enter Title</label>
                    <asp:TextBox ID="txtTitle" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                        ValidationGroup="CMNEventEntity" Width="300" />
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvTitle" runat="server" ControlToValidate="txtTitle"
                        ErrorMessage="Please Enter Title" ValidationGroup="CMNEventEntity" EnableViewState="False"
                        Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    Details&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="300" ClientIDMode="Static"
                        ID="txtDetails" runat="server" ValidationGroup="CMNEventEntity" />
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    Expected Start Date&nbsp;:
                </div>
                <div class="TableFormContent waterMarkContainer">
                    <label class="watermarkLabel" for="txtExpectedStartDate">
                        Enter Expected Start Date</label>
                    <asp:TextBox ID="txtExpectedStartDate" runat="server" ClientIDMode="Static" CssClass="ktiTextBox"
                        ValidationGroup="CMNEventEntity" Width="230" />
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvExpectedStartDate" runat="server" ControlToValidate="txtExpectedStartDate"
                        ErrorMessage="Please Enter Expected Start Date" ValidationGroup="CMNEventEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    <%--<asp:RegularExpressionValidator ID="revExpectedStartDate" runat="server" ControlToValidate="exampl"
                        Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="^([0]\d|[1][0-2])\/([0-2]\d|[3][0-1])\/([2][01]|[1][6-9])\d{2}(\s([0-1]\d|[2][0-3])(\:[0-5]\d){1,2})?$"
                        ValidationGroup="CMNEventEntity"></asp:RegularExpressionValidator>--%>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <asp:Panel ID="pnlCPEContent" runat="server" CssClass="pnlCPEContent">
                    <div id="divCollapsControl" class="divCollapsControl" style="float: left;">
                        <div style="float: left; height: 16px; width: 16px; padding-left: 145px;">
                            <asp:Image ID="imgExpandCollaps" ImageUrl="~/Images/expand-plus.gif" runat="server" />
                        </div>
                        <div style="float: left; padding-right: 3px;">
                            <asp:Label ID="lvlCollapsText" runat="server" Text="Time Details"></asp:Label>
                        </div>
                        <div style="clear: both;">
                        </div>
                    </div>
                </asp:Panel>
            </div>
            <br />
            <div class="TableRow" style="width: 100;">
                <asp:Panel ID="pnlEditor" runat="server" CssClass="pnlEditor">
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Expected End Date&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:TextBox ID="txtExpectedEndDate" runat="server" ClientIDMode="Static" CssClass="ktiTextBox"
                                ValidationGroup="CMNEventEntity" Width="230" />
                        </div>
                        <div class="TableFormValidatorContent">
                            <%-- <asp:RegularExpressionValidator ID="revExpectedEndDate" runat="server" ControlToValidate="txtActualEndDateSA"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="^([0]\d|[1][0-2])\/([0-2]\d|[3][0-1])\/([2][01]|[1][6-9])\d{2}(\s([0-1]\d|[2][0-3])(\:[0-5]\d){1,2})?$"
                            ValidationGroup="CMNEventEntity"></asp:RegularExpressionValidator>--%>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Actual Start Date&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:TextBox ID="txtActualStartDate" runat="server" ClientIDMode="Static" CssClass="ktiTextBox"
                                ValidationGroup="CMNEventEntity" Width="230" />
                        </div>
                        <div class="TableFormValidatorContent">
                            <%-- <asp:RegularExpressionValidator ID="revActualStartDate" runat="server" ControlToValidate="txtActualEndDateSA"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="^([0]\d|[1][0-2])\/([0-2]\d|[3][0-1])\/([2][01]|[1][6-9])\d{2}(\s([0-1]\d|[2][0-3])(\:[0-5]\d){1,2})?$"
                            ValidationGroup="CMNEventEntity"></asp:RegularExpressionValidator>--%>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Actual End Date&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:TextBox ID="txtActualEndDate" runat="server" ClientIDMode="Static" CssClass="ktiTextBox"
                                ValidationGroup="CMNEventEntity" Width="230" />
                        </div>
                        <div class="TableFormValidatorContent">
                            <%--<asp:RegularExpressionValidator ID="revActualEndDate" runat="server" ControlToValidate="txtActualEndDateSA"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="^([0]\d|[1][0-2])\/([0-2]\d|[3][0-1])\/([2][01]|[1][6-9])\d{2}(\s([0-1]\d|[2][0-3])(\:[0-5]\d){1,2})?$"
                            ValidationGroup="CMNEventEntity"></asp:RegularExpressionValidator>--%>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Duration&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:TextBox ID="txtDuration" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                                runat="server" ValidationGroup="CMNEventEntity" Type="Number" Width="210" />
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RangeValidator ID="rvDuration" runat="server" ControlToValidate="txtDuration"
                                Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                Type="Double" ValidationGroup="CMNEventEntity"></asp:RangeValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            All Day&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:CheckBox ID="chkIsAllDay" runat="server" ClientIDMode="Static" ValidationGroup="CMNEventEntity" />
                        </div>
                        <div class="TableFormValidatorContent">
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Notify Before Min&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:TextBox ID="txtNotifyBeforeMin" runat="server" ClientIDMode="Static" CssClass="ktiNumberTextBox"
                                ValidationGroup="CMNEventEntity" Width="210" />
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RangeValidator ID="rvNotifyBeforeMin" runat="server" ControlToValidate="txtNotifyBeforeMin"
                                Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136)"
                                MinimumValue="-2147483648" MaximumValue="2147483647" Type="Integer" ValidationGroup="CMNEventEntity"></asp:RangeValidator>
                        </div>
                    </div>
                </asp:Panel>
            </div>
            <div class="TableRow" style="width: 100;">
                <asp:Panel ID="pnlLocationDetailControl" runat="server" CssClass="pnlCPEContent">
                    <div id="dvLocationDetail" class="divCollapsControl" style="float: left;">
                        <div style="float: left; height: 16px; width: 16px; padding-left: 145px;">
                            <asp:Image ID="Image2" ImageUrl="~/Images/expand-plus.gif" runat="server" />
                        </div>
                        <div style="float: left; padding-left: 3px; padding-right: 3px;">
                            <asp:Label ID="lblLocationDetail" runat="server" Text="Location Details"></asp:Label>
                        </div>
                        <div style="clear: both;">
                        </div>
                    </div>
                </asp:Panel>
            </div>
            <br />
            <div class="TableRow" style="width: 100;">
                <asp:Panel ID="pnlLocationDetail" runat="server" CssClass="pnlEditor">
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Location Map&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                                ID="txtLocation" runat="server" ValidationGroup="CMNEventEntity" />
                        </div>
                        <div class="TableFormValidatorContent">
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Location Category&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:DropDownList ID="ddlEventLocationCategoryID" CssClass="ktiSelect" ClientIDMode="Static"
                                AutoPostBack="true" OnSelectedIndexChanged="ddlEventLocationCategoryID_SelectedIndexChanged"
                                runat="server" ValidationGroup="CMNEventEntity" Width="234">
                            </asp:DropDownList>
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="rfvEventLocationCategoryID" runat="server" ControlToValidate="ddlEventLocationCategoryID"
                                ErrorMessage="Please Select Event Location Category" ValidationGroup="CMNEventEntity"
                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <asp:Panel ID="pnlGalleria" runat="server" Visible="false">
                        <div class="TableRow" style="width: 100;">
                            <div class="TableFormLeble" style="text-align: right;">
                                <asp:Label ID="lblGalleria" runat="server" Text="Galleria"></asp:Label>
                            </div>
                            <div class="TableFormContent">
                                <asp:DropDownList ID="ddlGalleriaLocationID" CssClass="ktiSelect" ClientIDMode="Static"
                                    runat="server" ValidationGroup="CMNEventEntity" Width="234">
                                </asp:DropDownList>
                            </div>
                            <div class="TableFormValidatorContent">
                            </div>
                        </div>
                    </asp:Panel>
                </asp:Panel>
            </div>
            <div class="TableRow" style="width: 100;">
                <asp:Panel ID="pnlUrlDetailControl" runat="server" CssClass="pnlCPEContent">
                    <div id="divUrlDetailControl" class="divCollapsControl" style="float: left;">
                        <div style="float: left; height: 16px; width: 16px; padding-left: 145px;">
                            <asp:Image ID="Image1" ImageUrl="~/Images/expand-plus.gif" runat="server" />
                        </div>
                        <div style="float: left; padding-left: 3px; padding-right: 3px;">
                            <asp:Label ID="lblOthersInfo" runat="server" Text="Others Info"></asp:Label>
                        </div>
                        <div style="clear: both;">
                        </div>
                    </div>
                </asp:Panel>
            </div>
            <br />
            <div class="TableRow" style="width: 100;">
                <asp:Panel ID="pnlUrlDetail" runat="server" CssClass="pnlEditor">
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Website URL&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:TextBox TextMode="SingleLine" CssClass="ktiTextBox" Width="230" ClientIDMode="Static"
                                ID="txtWebsiteURL" runat="server" ValidationGroup="CMNEventEntity" />
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RegularExpressionValidator ID="revWebsiteURL" runat="server" ControlToValidate="txtWebsiteURL"
                                Display="Dynamic" EnableViewState="False" ValidationGroup="CMNEventEntity"></asp:RegularExpressionValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Ticket Seller URL&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:TextBox TextMode="SingleLine" CssClass="ktiTextBox" Width="230" ClientIDMode="Static"
                                ID="txtTicketSellerURL" runat="server" ValidationGroup="CMNEventEntity" />
                        </div>
                        <div class="TableFormValidatorContent">
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Youtube URL&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:TextBox TextMode="SingleLine" CssClass="ktiTextBox" Width="230" ClientIDMode="Static"
                                ID="txtYoutubeURL" runat="server" ValidationGroup="CMNEventEntity" />
                        </div>
                        <div class="TableFormValidatorContent">
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Transit & Parking&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:TextBox TextMode="SingleLine" CssClass="ktiTextBox" Width="230" ClientIDMode="Static"
                                ID="txtTransitAndParkingInformation" runat="server" ValidationGroup="CMNEventEntity" />
                        </div>
                        <div class="TableFormValidatorContent">
                        </div>
                    </div>
                </asp:Panel>
            </div>
            <div class="TableRow" style="width: 100;">
                <asp:Panel ID="pnlSettingControl" runat="server" CssClass="pnlCPEContent">
                    <div id="dvSetting" class="divCollapsControl" style="float: left;">
                        <div style="float: left; height: 16px; width: 16px; padding-left: 145px;">
                            <asp:Image ID="Image3" ImageUrl="~/Images/expand-plus.gif" runat="server" />
                        </div>
                        <div style="float: left; padding-left: 3px; padding-right: 3px;">
                            <asp:Label ID="lblSetting" runat="server" Text="Settings"></asp:Label>
                        </div>
                        <div style="clear: both;">
                        </div>
                    </div>
                </asp:Panel>
            </div>
            <br />
            <div class="TableRow" style="width: 100;">
                <asp:Panel ID="pnlSetting" runat="server" CssClass="pnlEditor">
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Event Option&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:DropDownList ID="ddlEventOptionID" CssClass="ktiSelect" ClientIDMode="Static"
                                runat="server" ValidationGroup="CMNEventEntity" Width="234">
                            </asp:DropDownList>
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="rfvEventOptionID" runat="server" ControlToValidate="ddlEventOptionID"
                                ErrorMessage="Please Select Event Option" ValidationGroup="CMNEventEntity" EnableViewState="False"
                                Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Repeat Category&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:DropDownList ID="ddlRepeatCategoryID" CssClass="ktiSelect" ClientIDMode="Static"
                                runat="server" ValidationGroup="CMNEventEntity" Width="234">
                            </asp:DropDownList>
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="rfvRepeatCategoryID" runat="server" ControlToValidate="ddlRepeatCategoryID"
                                ErrorMessage="Please Select Repeat Category" ValidationGroup="CMNEventEntity"
                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Remarks&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                                ID="txtRemarks" runat="server" ValidationGroup="CMNEventEntity" />
                        </div>
                        <div class="TableFormValidatorContent">
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Shared Setting&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:DropDownList ID="ddlSharedSettingID" CssClass="ktiSelect" ClientIDMode="Static"
                                runat="server" ValidationGroup="CMNEventEntity" Width="234">
                            </asp:DropDownList>
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="rfvSharedSettingID" runat="server" ControlToValidate="ddlSharedSettingID"
                                ErrorMessage="Please Select Shared Setting" ValidationGroup="CMNEventEntity"
                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                </asp:Panel>
            </div>
            <div class="TableRow" style="text-align: center;">
                <div class="TableFormLeble">
                    &nbsp;</div>
                <div class="TableFormContent">
                    <kti:SecureButton ID="btnSubmit" ValidationGroup="CMNEventEntity" OnClick="btnSave_Click"
                        runat="server" Text="Add" UniqueKey="CMNEventControl_Submit_key" />
                    <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click" runat="server"
                        Text="Add New" UniqueKey="CMNEventControl_AddNew_key" />
                    <kti:SecureButton ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear"
                        UniqueKey="CMNEventControl_Clear_key" />
                </div>
            </div>
            <br />
            <div style="text-align:right">
                <asp:HyperLink ID="hypEventSchedule" runat="server" CssClass="CommonButtonLink" Text="Event Schedule"
                                        CommandArgument='<%#Eval("EventCategoryID")%>' UniqueKey="CMNEvent_lvCMNEvent_Schedule_key" />
            </div>
            <br />
            <div class="TableRow" style="width: 100%; padding-left:480px;">
            <div class="TableFormLeble" style="text-align: right;">
               Filter Text&nbsp;:
            </div>
            <div class="TableFormContent waterMarkContainer">
             <label class="watermarkLabel" for="txtSearchText">
                            Type Event No# Or Title</label>
                <asp:TextBox ID="txtSearchText" runat="server" ClientIDMode="Static" CssClass="ktiTextBox"
                     Width="230" /><span><asp:CheckBox ID="chbxFilter"
                        runat="server" AutoPostBack="true" OnCheckedChanged="chbxFilter_CheckedChanged"
                        Text="Use Filter" /></span>
            </div>
            <div class="TableFormValidatorContent">
            </div>
        </div>
            <div class="listContentTitle">
                Event List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvCMNEvent" runat="server" DataSourceID="odsCMNEvent" OnItemCommand="lvCMNEvent_ItemCommand"
                        OnItemDataBound="lvCMNEvent_ItemDataBound">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="his">
                                        Option
                                    </td>
                                    <td class="his" style="width: 62px;">
                                        Command
                                    </td>
                                    <td class="hi" style="width: 150px;">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByTitle"
                                        CommandName="Sort" Text="Title" CommandArgument="CMNEvent.Title" />
                                    </td>
                                    <td class="hi" style="width: 118px;">
                                        Expected
                                    </td>
                                    <td class="hi" style="width: 200px;">
                                        Details
                                    </td>
                                    <td class="hi" style="width: 125px;">
                                        Location Info
                                    </td>
                                    <td class="hi" style="width: 176px;">
                                        Member
                                    </td>
                                    <td class="hi" style="width: 133px;">
                                        URL Info
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
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("EventID")%>' UniqueKey="CMNEvent_lvCMNEvent_Edit_key" />
                                    <br />
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete C MNEvent?')"
                                        CommandArgument='<%#Eval("EventID")%>' UniqueKey="CMNEvent_lvCMNEvent_Edit_key" />
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="hypUploadInfo" runat="server" CssClass="CommonButtonLink" Text="Upload Info"
                                        CommandArgument='<%#Eval("EventID")%>' UniqueKey="CMNEvent_lvCMNEvent_Upload_key" />
                                    <br />
                                    <asp:HyperLink ID="hypInvitationInfo" runat="server" CssClass="CommonButtonLink"
                                        Text="Invitation Info" CommandArgument='<%#Eval("EventID")%>' UniqueKey="CMNEvent_lvCMNEvent_Invitation_key" />
                                </td>
                              
                                <td class="i">
                                (<%# Eval("Name")%>)<br />
                                    <b>
                                      <%# Eval("EventReferenceNo")%></b>
                                      <br /><asp:HyperLink ID="hypTitleLV" runat="server" Text='<%# Eval("Title")%>'></asp:HyperLink>
                                </td>
                                <td class="i">
                                    Start Date :<%# Eval("ExpectedStartDate") != null ? ((DateTime)Eval("ExpectedStartDate")).ToString("dd-MM-yyyy") : ""%>
                                    <br />
                                    End Date :<%# Eval("ExpectedEndDate") != null ? ((DateTime)Eval("ExpectedEndDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <asp:Label runat="server" ToolTip='<%# Eval("Details")%>' ID="a"><%# Eval("Details") != String.Empty ? Eval("Details").ToString().Substring(0, Math.Min(Eval("Details").ToString().Length, 50)) : ""%></asp:Label>
                                </td>
                                <td class="i">
                                    Category :<%# Eval("EventLocationCategoryName")%>
                                    <br />
                                    Location :<%# Eval("LocationName")%>
                                </td>
                                <td class="i">
                                    Created By :<%# Eval("CreatedByMemberFullName")%>
                                    <br />
                                    Owner :<%# Eval("OwnerMemberFullName")%>
                                </td>
                                <td class="i">
                                    <b>Website</b>:&nbsp;<%# Eval("WebsiteURL")%>
                                    <br />
                                    <b>Ticket Seller</b>:&nbsp;<%# Eval("TicketSellerURL")%>
                                    <br />
                                    <b>Youtube</b>:&nbsp;<%# Eval("YoutubeURL")%>
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
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("EventID")%>' UniqueKey="CMNEvent_lvCMNEvent_Edit_key" />
                                    <br />
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete C MNEvent?')"
                                        CommandArgument='<%#Eval("EventID")%>' UniqueKey="CMNEvent_lvCMNEvent_Edit_key" />
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="hypUploadInfo" runat="server" CssClass="CommonButtonLink" Text="Upload Info"
                                        CommandArgument='<%#Eval("EventID")%>' UniqueKey="CMNEvent_lvCMNEvent_Upload_key" />
                                    <br />
                                    <asp:HyperLink ID="hypInvitationInfo" runat="server" CssClass="CommonButtonLink"
                                        Text="Invitation Info" CommandArgument='<%#Eval("EventID")%>' UniqueKey="CMNEvent_lvCMNEvent_Invitation_key" />
                                </td>
                                <td class="i">
                                (<%# Eval("Name")%>)<br />
                                    <b>
                                        <%# Eval("EventReferenceNo")%></b>
                                        <br /><asp:HyperLink ID="hypTitleLV" runat="server" Text='<%# Eval("Title")%>'></asp:HyperLink>
                                </td>
                                <td class="i">
                                    Start Date :<%# Eval("ExpectedStartDate") != null ? ((DateTime)Eval("ExpectedStartDate")).ToString("dd-MM-yyyy") : ""%>
                                    <br />
                                    End Date :<%# Eval("ExpectedEndDate") != null ? ((DateTime)Eval("ExpectedEndDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <asp:Label runat="server" ToolTip='<%# Eval("Details")%>' ID="a"><%# Eval("Details") != String.Empty ? Eval("Details").ToString().Substring(0, Math.Min(Eval("Details").ToString().Length, 50)) : ""%></asp:Label>
                                </td>
                                <td class="i">
                                    Category :<%# Eval("EventLocationCategoryName")%>
                                    <br />
                                    Location :<%# Eval("LocationName")%>
                                </td>
                                <td class="i">
                                    Created By :<%# Eval("CreatedByMemberFullName")%>
                                    <br />
                                    Owner :<%# Eval("OwnerMemberFullName")%>
                                </td>
                                <td class="i">
                                    <b>Website</b>:&nbsp;<%# Eval("WebsiteURL")%>
                                    <br />
                                    <b>Ticket Seller</b>:&nbsp;<%# Eval("TicketSellerURL")%>
                                    <br />
                                    <b>Youtube</b>:&nbsp;<%# Eval("YoutubeURL")%>
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
                <asp:ObjectDataSource ID="odsCMNEvent" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.CMNEvent_DetailedDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsCMNEvent_Selecting">
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
