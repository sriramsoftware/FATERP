<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 B2B Solutions, info@b2b-erp.com.
 ©2006 – 2010.

 Code Generate Time - 08-Oct-2013, 02:28:24
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CMNEventView.ascx.cs" Inherits="Bay.ERP.Web.UI.CMNEventViewControl" %>
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
                    <kti:SecureButton ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear"
                        UniqueKey="CMNEventControl_Clear_key" />
                </div>
            </div>
            <br />
            <div class="TableFormLeble" style="text-align: left;">
                    Comment&nbsp;:
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtComment">
                            Enter Comment</label>
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="476" ClientIDMode="Static"
                            ID="txtComment" runat="server" ValidationGroup="CMNERPCommentEntity" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvComment" runat="server" ControlToValidate="txtComment"
                            ErrorMessage="Please Enter Comment" ValidationGroup="CMNERPCommentEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="text-align: left;">
                    <div class="TableFormLeble">
                        <asp:Button ID="btnSavePost" ValidationGroup="CMNERPCommentEntity" OnClick="btnSavePost_Click"
                            runat="server" Text="Post" UniqueKey="CMNERPCommentControl_Submit_key" />
                    </div>
                </div>
                <br />
                 <div style="width: 50%;">
                    <div style="width: 720px; margin: 10px; padding: 10px;">
                        <div style="padding-bottom: 15px;">
                            <h3 style="color: #4B4B4B;">All Comments:</h3>
                        </div>
                        <div>
                            <asp:ListView ID="lvCMNERPComment" runat="server" DataSourceID="odsCMNERPComment">
                                <LayoutTemplate>
                                    <div runat="server" id="itemPlaceholder">
                                    </div>
                                </LayoutTemplate>
                                <ItemTemplate>
                                    <div style="padding-bottom: 0px;">
                                        <div style="padding-bottom: 3px;">
                                            <table cellpadding="0" cellspacing="0" width="50%">
                                                <tr>
                                                    <td align="left">
                                                        <b>
                                                            <%# Eval("MemberFullName")%></b></i></span>
                                                    </td>
                                                    <td align="left">on <b>
                                                        <%# Eval("CommentDate") != null ? ((DateTime)Eval("CommentDate")).ToString("dd-MM-yyyy hh:mm:ss") : ""%></b>
                                                    </td>
                                                </tr>
                                            </table>
                                        </div>
                                        <div style="border-top: 1px solid gray; height: 1px; width: 50%;">
                                        </div>
                                        <div style="float: left;">
                                            <%--<asp:Image ID="imgEmployee" runat="server" ImageUrl="~/Images/user.png" Width="40" Height="40" />--%>
                                        </div>
                                        <div style="text-align: justify; letter-spacing: 0px; word-spacing: 0px; line-height: 18px; color: #4B4B4B; font-size: 12px; font-family: 'Verdana'; padding-top: 3px; float: left;">
                                            <%# Eval("Comment")%>
                                        </div>
                                        <div style="clear: both;"></div>

                                    </div>
                                </ItemTemplate>
                                <EmptyDataTemplate>
                                    <div class="edr">
                                        No Comment Available To Display
                                    </div>
                                </EmptyDataTemplate>
                            </asp:ListView>
                        </div>
                    </div>
                    <asp:ObjectDataSource ID="odsCMNERPComment" runat="server" SelectMethod="GetPagedData"
                        SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                        StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.CMNERPComment_DetailedDataSource"
                        SortParameterName="sortExpression" OnSelecting="odsCMNERPComment_Selecting">
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
