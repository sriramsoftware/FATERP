<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 20-Dec-2013, 02:17:52
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HREmployeeLeaveApplicationForFrontDesk.ascx.cs"
    Inherits="Bay.ERP.Web.UI.HREmployeeLeaveApplicationForFrontDeskControl" %>
<script language="javascript" type="text/javascript">
    function BindEvents() {
        $(document).ready(function () {
            $("#txtRequestEndDate").change(function () {
                var startDate = $.datepicker.parseDate('dd-mm-yy', $("#txtRequestStartDate").val());
                var endDate = $.datepicker.parseDate('dd-mm-yy', $("#txtRequestEndDate").val());

                startDate = new Date(startDate);
                endDate = new Date(endDate);

                var diff = 1;
                if (startDate && endDate) {
                    diff = diff + Math.floor((endDate.getTime() - startDate.getTime()) / 86400000); // ms per day
                }

                $("#txtTotalLeaveDays").val(diff);
            });

            $("#txtRequestStartDate").change(function () {
                var startDate = $.datepicker.parseDate('dd-mm-yy', $("#txtRequestStartDate").val());
                var endDate = $.datepicker.parseDate('dd-mm-yy', $("#txtRequestEndDate").val());

                startDate = new Date(startDate);
                endDate = new Date(endDate);

                var diff = 1;
                if (startDate && endDate) {
                    diff = diff + Math.floor((endDate.getTime() - startDate.getTime()) / 86400000); // ms per day
                }

                $("#txtTotalLeaveDays").val(diff);
            });
        });
    }

    var ddlText, ddlValue, ddl, lblMesg;

    function CacheItems() {

        ddlText = new Array();

        ddlValue = new Array();

        ddl = document.getElementById("<%=ddlEmployeeID.ClientID %>");

        lblMesg = document.getElementById("<%=lblMessage2.ClientID%>");

        for (var i = 0; i < ddl.options.length; i++) {

            ddlText[ddlText.length] = ddl.options[i].text;

            ddlValue[ddlValue.length] = ddl.options[i].value;

        }

    }

    window.onload = CacheItems;



    function FilterItems(value) {

        ddl.options.length = 0;

        for (var i = 0; i < ddlText.length; i++) {

            if (ddlText[i].toLowerCase().indexOf(value) != -1) {

                AddItem(ddlText[i], ddlValue[i]);

            }

        }

        lblMesg.innerHTML = ddl.options.length + " items found.";

        if (ddl.options.length == 0) {

            AddItem("No items found.", "");

        }

    }



    function AddItem(text, value) {

        var opt = document.createElement("option");

        opt.text = text;

        opt.value = value;

        ddl.options.add(opt);

    }
</script>
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
        <asp:Panel ID="pnlCPEContent" runat="server" CssClass="pnlCPEContent">
            <div id="divCollapsControl" class="divCollapsControl">
                <div style="float: left; height: 16px; width: 16px;">
                    <asp:Image ID="imgExpandCollaps" ImageUrl="~/Images/expand-plus.gif" runat="server" />
                </div>
                <div style="float: left; padding-left: 3px;">
                    <asp:Label ID="lvlCollapsText" runat="server" Text="Add/Edit Employee Leave Application"></asp:Label>
                </div>
                <div style="clear: both;">
                </div>
            </div>
        </asp:Panel>
        <div id="sub" class="" style="margin: 0px; padding: 0px; visibility: visible; height: auto;
            border: 2px none; display: block; width: 1110px;">
            <div id="" class="" style="border: 0px none; margin: 0px; padding: 0px; overflow-y: hidden;
                visibility: visible; height: auto; width: 1110px;">
                <asp:Panel ID="pnlEditor" runat="server" CssClass="pnlEditor">
                    <div class="TableRow" style="text-align: left;" runat="server">
                        <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
                    </div>
                    <div id="div2" style="width: 1100px; border: 0px solid red; height: 500px;">
                        <div id="div3" style="float: left; width: 500px; overflow: visible;">
                            <div class="TableRow" style="width: 100;">
                                <div class="TableFormLeble" style="text-align: right;">
                                    Search Employee&nbsp;:
                                </div>
                                <div class="TableFormContent">
                                    <asp:TextBox ID="txtSearch" runat="server" CssClass="ktiTextBox" onkeyup="FilterItems(this.value)"></asp:TextBox><br />
                                    <asp:Label ID="lblMessage2" runat="server" Text=""></asp:Label>
                                </div>
                            </div>
                            <div class="TableRow" style="width: 100;">
                                <div class="TableFormLeble" style="text-align: right;">
                                    Employee&nbsp;:
                                </div>
                                <div class="TableFormContent">
                                    <asp:DropDownList ID="ddlEmployeeID" AutoPostBack="true" OnSelectedIndexChanged="ddlEmployeeID_SelectedIndexChanged"
                                        CssClass="ktiSelect" ClientIDMode="Static" runat="server" ValidationGroup="HREmployeeLeaveApplicationEntity"
                                        Width="234">
                                    </asp:DropDownList>
                                </div>
                                <div class="TableFormValidatorContent">
                                </div>
                            </div>
                            <div class="TableRow" style="width: 100;">
                                <div class="TableFormLeble" style="text-align: right;">
                                    Application Date&nbsp;:
                                </div>
                                <div class="TableFormContent waterMarkContainer">
                                    <label class="watermarkLabel" for="txtApplicationDate">
                                        Enter Application Date</label>
                                    <asp:TextBox ID="txtApplicationDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                                        ValidationGroup="HREmployeeLeaveApplicationEntity" Width="230" />
                                    <span class="RequiredField">*</span>
                                </div>
                                <div class="TableFormValidatorContent">
                                    <asp:RequiredFieldValidator ID="rfvApplicationDate" runat="server" ControlToValidate="txtApplicationDate"
                                        ErrorMessage="Please Enter Application Date" ValidationGroup="HREmployeeLeaveApplicationEntity"
                                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                    <%--<asp:RegularExpressionValidator ID="revApplicationDate" runat="server" ControlToValidate="txtApplicationDate"
                                        Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                                        ValidationGroup="HREmployeeLeaveApplicationEntity"></asp:RegularExpressionValidator>--%>
                                </div>
                            </div>
                            <ajaxToolkit:CalendarExtender ID="CEtxtStartDate" runat="server" TargetControlID="txtRequestStartDate"
                                Format="dd-MM-yyyy">
                            </ajaxToolkit:CalendarExtender>
                            <ajaxToolkit:CalendarExtender ID="CEtxtRequestEndDate" runat="server" TargetControlID="txtRequestEndDate"
                                Format="dd-MM-yyyy">
                            </ajaxToolkit:CalendarExtender>
                            <div class="TableRow" style="width: 100;">
                                <div class="TableFormLeble" style="text-align: right;">
                                    Request Start Date&nbsp;:
                                </div>
                                <div class="TableFormContent">
                                    <label class="watermarkLabel" for="txtRequestStartDate">
                                        Enter Request Start Date</label>
                                    <asp:TextBox ID="txtRequestStartDate" runat="server" ClientIDMode="Static" CssClass="ktiTextBox"
                                        ValidationGroup="HREmployeeLeaveApplicationEntity" Width="230" />
                                    <span class="RequiredField">*</span>
                                </div>
                                <div class="TableFormValidatorContent">
                                    <asp:RequiredFieldValidator ID="rfvRequestStartDate" runat="server" ControlToValidate="txtRequestStartDate"
                                        ErrorMessage="Please Enter Start Date" ValidationGroup="HREmployeeLeaveApplicationEntity"
                                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="revRequestStartDate" runat="server" ControlToValidate="txtRequestStartDate"
                                        Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                                        ValidationGroup="HREmployeeLeaveApplicationEntity"></asp:RegularExpressionValidator>
                                </div>
                            </div>
                            <div class="TableRow" style="width: 100;">
                                <div class="TableFormLeble" style="text-align: right;">
                                    Request End Date&nbsp;:
                                </div>
                                <div class="TableFormContent" style="width: 333px;">
                                    <label class="watermarkLabel" for="txtRequestEndDate">
                                        Enter Request End Date</label>
                                    <asp:TextBox ID="txtRequestEndDate" runat="server" ClientIDMode="Static" CssClass="ktiTextBox"
                                        ValidationGroup="HREmployeeLeaveApplicationEntity" Width="230" />
                                    <span class="RequiredField">*</span>
                                </div>
                                <div class="TableFormValidatorContent">
                                    <asp:RequiredFieldValidator ID="rfvRequestEndDate" runat="server" ControlToValidate="txtRequestEndDate"
                                        ErrorMessage="Please Enter End Date" ValidationGroup="HREmployeeLeaveApplicationEntity"
                                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="revRequestEndDate" runat="server" ControlToValidate="txtRequestEndDate"
                                        Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                                        ValidationGroup="HREmployeeLeaveApplicationEntity"></asp:RegularExpressionValidator>
                                </div>
                            </div>
                            <div class="TableRow" style="width: 100;">
                                <div class="TableFormLeble" style="text-align: right; width: 156px;">
                                    Check Leave and Task&nbsp;:
                                </div>
                                <div class="TableFormContent" style="width: 50px;">
                                    <asp:CheckBox ID="chbxFilter" runat="server" AutoPostBack="true" OnCheckedChanged="chbxFilter_CheckedChanged"
                                        Text="" />
                                </div>
                                <div class="TableFormValidatorContent">
                                </div>
                            </div>
                            <div class="TableRow" style="width: 100;">
                                <div class="TableFormLeble" style="text-align: right;">
                                    Total Leave Days&nbsp;:
                                </div>
                                <div class="TableFormContent waterMarkContainer">
                                    <asp:TextBox ID="txtTotalLeaveDays" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                                        runat="server" ValidationGroup="HREmployeeLeaveApplicationEntity" Width="210" />
                                    <span class="RequiredField">*</span>
                                </div>
                                <div class="TableFormValidatorContent">
                                    <asp:RequiredFieldValidator ID="rfvTotalLeaveDays" runat="server" ControlToValidate="txtTotalLeaveDays"
                                        ErrorMessage="Please Enter Total Leave Days" ValidationGroup="HREmployeeLeaveApplicationEntity"
                                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                    <asp:RangeValidator ID="rvTotalLeaveDays" runat="server" ControlToValidate="txtTotalLeaveDays"
                                        Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                        MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                        Type="Double" ValidationGroup="HREmployeeLeaveApplicationEntity"></asp:RangeValidator>
                                </div>
                            </div>
                            <div class="TableRow" style="width: 100;">
                                <div class="TableFormLeble" style="text-align: right;">
                                    Leave Purpose&nbsp;:
                                </div>
                                <div class="TableFormContent">
                                    <asp:DropDownList ID="ddlLeavePurpose" CssClass="ktiSelect" ClientIDMode="Static"
                                        runat="server" ValidationGroup="HREmployeeLeaveApplicationEntity" AutoPostBack="true"
                                        Width="234">
                                        <asp:ListItem Selected="false" Text="Personal" Value="Personal"></asp:ListItem>
                                        <asp:ListItem Text="Exchange Leave" Value="Exchange Leave"></asp:ListItem>
                                        <asp:ListItem Text="Sick" Value="Sick"></asp:ListItem>
                                        <asp:ListItem Text="Accident" Value="Accident"></asp:ListItem>
                                        <asp:ListItem Text="Uninformed Delay" Value="Uninformed Delay"></asp:ListItem>
                                        <asp:ListItem Text="Vacation" Value="Vacation"></asp:ListItem>
                                        <asp:ListItem Text="Treatment" Value="Treatment"></asp:ListItem>
                                        <asp:ListItem Text="Marriage Ceremony" Value="Marriage Ceremony"></asp:ListItem>
                                        <asp:ListItem Text="Maternal Leave" Value="Maternal Leave"></asp:ListItem>
                                        <asp:ListItem Text="Parent death" Value="Parent death"></asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <div class="TableFormValidatorContent">
                                </div>
                            </div>
                            <div class="TableRow" style="width: 100;">
                                <div class="TableFormLeble" style="text-align: right;">
                                    Leave Location&nbsp;:
                                </div>
                                <div class="TableFormContent">
                                    <div class="TableFormContent">
                                        <asp:DropDownList ID="ddlLeaveLocation" CssClass="ktiSelect" ClientIDMode="Static"
                                            runat="server" ValidationGroup="HREmployeeLeaveApplicationEntity" AutoPostBack="true"
                                            Width="234">
                                            <asp:ListItem Selected="false" Text="Village" Value="Village"></asp:ListItem>
                                            <asp:ListItem Text="Home" Value="Home"></asp:ListItem>
                                            <asp:ListItem Text="Out of Dhaka" Value="Out of Dhaka"></asp:ListItem>
                                            <asp:ListItem Text="Out of country" Value="Out of country"></asp:ListItem>
                                            <asp:ListItem Text="Hospital" Value="Hospital"></asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="TableFormValidatorContent">
                                </div>
                            </div>
                            <div class="TableRow" style="width: 100;">
                                <div class="TableFormLeble" style="text-align: right;">
                                    Backup Employee&nbsp;:
                                </div>
                                <div class="TableFormContent">
                                    <asp:DropDownList ID="ddlBackupEmployeeID" CssClass="ktiSelect" ClientIDMode="Static"
                                        runat="server" ValidationGroup="HREmployeeLeaveApplicationEntity" Width="234">
                                    </asp:DropDownList>
                                </div>
                                <div class="TableFormValidatorContent">
                                </div>
                            </div>
                            <div class="TableRow" style="width: 100;">
                                <div class="TableFormLeble" style="text-align: right;">
                                    Application Status&nbsp;:
                                </div>
                                <div class="TableFormContent">
                                    <asp:DropDownList ID="ddlLeaveApplicationApplicationStatusID" CssClass="ktiSelect"
                                        ClientIDMode="Static" Enabled="false" runat="server" ValidationGroup="HREmployeeLeaveApplicationEntity"
                                        Width="234">
                                    </asp:DropDownList>
                                    <span class="RequiredField">*</span>
                                </div>
                                <div class="TableFormValidatorContent">
                                    <asp:RequiredFieldValidator ID="rfvLeaveApplicationApplicationStatusID" runat="server"
                                        ControlToValidate="ddlLeaveApplicationApplicationStatusID" ErrorMessage="Please Select Leave Application Application Status"
                                        ValidationGroup="HREmployeeLeaveApplicationEntity" EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <div class="TableRow" style="width: 100;">
                                <div class="TableFormLeble" style="text-align: right;">
                                    Appr. Proc. Panel&nbsp;:
                                </div>
                                <div class="TableFormContent">
                                    <asp:DropDownList ID="ddlAPPanelID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                                        ValidationGroup="APPanelMemberEntity" Width="236">
                                    </asp:DropDownList>
                                    <span class="RequiredField">*</span>
                                </div>
                                <div class="TableFormValidatorContent">
                                    <asp:RequiredFieldValidator ID="rfvAPPanelID" runat="server" ControlToValidate="ddlAPPanelID"
                                        ErrorMessage="Please Select Approval Process Panel" ValidationGroup="APPanelMemberEntity"
                                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <div class="TableRow" style="text-align: center;">
                                <div class="TableFormLeble">
                                    &nbsp;</div>
                                <div class="TableFormContent">
                                    <asp:Button ID="btnSubmit" ValidationGroup="HREmployeeLeaveApplicationEntity" OnClick="btnSave_Click"
                                        runat="server" Text="Save & Submit For Approval" UniqueKey="HREmployeeLeaveApplicationControl_Submit_key" />
                                    <asp:Button ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click" runat="server"
                                        Text="Add New" UniqueKey="HREmployeeLeaveApplicationControl_AddNew_key" />
                                    <asp:Button ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear" UniqueKey="HREmployeeLeaveApplicationControl_Clear_key" />
                                </div>
                            </div>
                            <div class="TableRow" style="text-align: center; display: none;">
                                <div class="TableFormLeble" style="width: 460px;">
                                    <asp:Label ID="lblPending" runat="server" />
                                </div>
                            </div>
                        </div>
                        <br />
                        <div id="div4" style="float: left; width: 492px; padding-bottom: 105px; height: 150px;">
                            <div class="lv-c">
                                <asp:ListView ID="lvLeaveApplicationChecking" runat="server" DataSourceID="odsLeaveApplicationChecking"
                                    OnItemDataBound="lvLeaveApplicationChecking_ItemDataBound">
                                    <LayoutTemplate>
                                        <table class="lv" cellpadding="0" cellspacing="0">
                                            <tr class="h">
                                                <td class="rp">
                                                    &nbsp;
                                                </td>
                                                <td class="hi">
                                                    Request Start Date
                                                </td>
                                                <td class="hi">
                                                    Request End Date
                                                </td>
                                                <td class="hi">
                                                    Total Leave Days
                                                </td>
                                                <td class="hi">
                                                    Description
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
                                                <%# Eval("RequestStartDate") != null ? ((DateTime)Eval("RequestStartDate")).ToString("dd-MM-yyyy") : ""%>
                                            </td>
                                            <td class="i">
                                                <%# Eval("RequestEndDate") != null ? ((DateTime)Eval("RequestEndDate")).ToString("dd-MM-yyyy") : ""%>
                                            </td>
                                            <td class="i">
                                                <%# Eval("TotalLeaveDays")%>
                                            </td>
                                            <td class="i">
                                                <%# Eval("Description")%>
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
                                                <%# Eval("RequestStartDate") != null ? ((DateTime)Eval("RequestStartDate")).ToString("dd-MM-yyyy") : ""%>
                                            </td>
                                            <td class="i">
                                                <%# Eval("RequestEndDate") != null ? ((DateTime)Eval("RequestEndDate")).ToString("dd-MM-yyyy") : ""%>
                                            </td>
                                            <td class="i">
                                                <%# Eval("TotalLeaveDays")%>
                                            </td>
                                            <td class="i">
                                                <%# Eval("Description")%>
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
                            <asp:ObjectDataSource ID="odsLeaveApplicationChecking" runat="server" SelectMethod="GetPagedData"
                                SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                                StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.HREmployeeLeaveApplication_DetailedDataSource"
                                SortParameterName="sortExpression" OnSelecting="odsLeaveApplicationChecking_Selecting">
                                <SelectParameters>
                                    <asp:Parameter Name="startRowIndex" Type="Int32" />
                                    <asp:Parameter Name="pageSize" Type="Int32" />
                                    <asp:Parameter Name="sortExpression" Type="String" />
                                    <asp:Parameter Name="filterExpression" Type="String" />
                                </SelectParameters>
                            </asp:ObjectDataSource>
                        </div>
                        <div id="task" style="float: left; width: 492px; padding-bottom: 10px;">
                            <div class="d-lv-c">
                                <asp:ListView ID="lvOTIssue_Detailed" runat="server" DataSourceID="odsOTIssue_Detailed"
                                    OnItemDataBound="lvOTIssue_Detailed_ItemDataBound">
                                    <LayoutTemplate>
                                        <table class="lv" cellpadding="0" cellspacing="0">
                                            <tr class="h">
                                                <td class="hi">
                                                    <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByCategory"
                                                        CommandName="Sort" Text="Category" CommandArgument="MDIssueCategory.Name" />
                                                </td>
                                                <td class="hi" style="width: 150px;">
                                                    <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByTitle"
                                                        CommandName="Sort" Text="Title" CommandArgument="OTIssue.Title" />
                                                </td>
                                                <td class="hi">
                                                    <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByPriority"
                                                        CommandName="Sort" Text="Priority" CommandArgument="MDIssuePriority.Name" />
                                                </td>
                                                <td class="hi">
                                                    Date
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
                                            <td class="i">
                                                <%# Eval("IssueCategoryName")%>
                                            </td>
                                            <td class="i">
                                                <%# Eval("IssueStatusName")%>:&nbsp<asp:HyperLink ID="hypIssueReport" runat="server"
                                                    CssClass="CommonButtonLink" Text='<%# Eval("Title")%>' CommandName="IssueReport"
                                                    CommandArgument='<%#Eval("IssueID")%>'></asp:HyperLink>
                                            </td>
                                            <td class="i">
                                                <asp:Label ID="lblIssuePriorityNameLV" runat="server" Text='<%# Eval("IssuePriorityName")%>'></asp:Label>
                                            </td>
                                            <td class="i">
                                                <b>Start</b>:&nbsp<%# Eval("ExpectedStartDate") != null ? ((DateTime)Eval("ExpectedStartDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%><br />
                                                <b>End</b>:&nbsp<%# Eval("ExpectedEndDate") != null ? ((DateTime)Eval("ExpectedEndDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                                            </td>
                                            <td class="rpb">
                                                &nbsp;
                                            </td>
                                        </tr>
                                    </ItemTemplate>
                                    <AlternatingItemTemplate>
                                        <tr class="ar">
                                            <td class="i">
                                                <%# Eval("IssueCategoryName")%>
                                            </td>
                                            <td class="i">
                                                <%# Eval("IssueStatusName")%>:&nbsp<asp:HyperLink ID="hypIssueReport" runat="server"
                                                    CssClass="CommonButtonLink" Text='<%# Eval("Title")%>' CommandName="IssueReport"
                                                    CommandArgument='<%#Eval("IssueID")%>'></asp:HyperLink>
                                            </td>
                                            <td class="i">
                                                <asp:Label ID="lblIssuePriorityNameLV" runat="server" Text='<%# Eval("IssuePriorityName")%>'></asp:Label>
                                            </td>
                                            <td class="i">
                                                <b>Start</b>:&nbsp<%# Eval("ExpectedStartDate") != null ? ((DateTime)Eval("ExpectedStartDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%><br />
                                                <b>End</b>:&nbsp<%# Eval("ExpectedEndDate") != null ? ((DateTime)Eval("ExpectedEndDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                                            </td>
                                            <td class="rpb">
                                                &nbsp;
                                            </td>
                                        </tr>
                                    </AlternatingItemTemplate>
                                    <EmptyDataTemplate>
                                        <div class="d-edr">
                                            No Records Found To Display
                                        </div>
                                    </EmptyDataTemplate>
                                </asp:ListView>
                            </div>
                            <asp:ObjectDataSource ID="odsOTIssue_Detailed" runat="server" SelectMethod="GetPagedData"
                                SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                                StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.OTIssue_DetailedDataSource"
                                SortParameterName="sortExpression" OnSelecting="odsOTIssue_Detailed_Selecting">
                                <SelectParameters>
                                    <asp:Parameter Name="startRowIndex" Type="Int32" />
                                    <asp:Parameter Name="pageSize" Type="Int32" />
                                    <asp:Parameter Name="sortExpression" Type="String" />
                                    <asp:Parameter Name="filterExpression" Type="String" />
                                </SelectParameters>
                            </asp:ObjectDataSource>
                        </div>
                    </div>
                </asp:Panel>
            </div>
        </div>
        <div style="display: none;">
            <asp:Button ID="btnHidden" runat="server" Text="Hidden" Visible="true" />
        </div>
        <ajaxToolkit:ModalPopupExtender ID="MPE" runat="server" TargetControlID="btnHidden"
            PopupControlID="MessageBox" BackgroundCssClass="modalBackground" DropShadow="true"
            OkControlID="btnOk" PopupDragHandleControlID="MessageBox">
        </ajaxToolkit:ModalPopupExtender>
        <asp:Panel ID="MessageBox" CssClass="ModalPopup" runat="server">
            <div>
                <asp:Label ID="messageDetails" runat="server" Text="Recorded Inserted.">
                </asp:Label>
                <br />
                <asp:Button runat="server" ID="btnOk" Text="OK" />
            </div>
        </asp:Panel>
        <br />
        <br />
        <div class="listContentTitle">
            Leave Balance
        </div>
        <div>
            <div class="lv-c" style="border: none; padding: 10px; margin: 10px;">
                <asp:ListView ID="lvLeaveStatus" runat="server" DataSourceID="odsLeaveStatus" OnItemDataBound="lvLeaveStatus_ItemDataBound">
                    <LayoutTemplate>
                        <table class="lv" cellpadding="0" cellspacing="0" style="width: auto; border: 1px solid #efefef">
                            <tr class="h">
                                <td class="hi" style="width: 75px;">
                                    <b>Status</b>
                                </td>
                                <td class="hi" style="width: 75px;">
                                    <b>Leave Earned</b>
                                </td>
                                <td class="hi" style="width: 90px;">
                                    <b>Leave Enjoyed</b>
                                </td>
                                <td class="hi" style="width: 75px;">
                                    <b>Balance</b>
                                </td>
                                <td class="hi" style="width: 75px;">
                                    <b>Others</b>
                                </td>
                            </tr>
                            <tr runat="server" id="itemPlaceholder">
                            </tr>
                        </table>
                    </LayoutTemplate>
                    <ItemTemplate>
                        <tr class="r">
                            <td class="i">
                                <b>Casual</b>
                            </td>
                            <td class="i">
                                <asp:Label ID="lblCasualLeaveEarned" Text='<%# Eval("CasualLeaveEarned")%>' runat="server" />
                            </td>
                            <td class="i">
                                <asp:Label ID="lblCasualLeaveEnjoyed" Text='<%# Eval("CasualLeaveEnjoyed")%>' runat="server" />
                            </td>
                            <td class="i">
                                <asp:Label ID="lblCasualleaveBalance" runat="server" />
                            </td>
                            <td class="i">
                                <asp:Label ID="Label1" runat="server" />
                            </td>
                        </tr>
                        <tr class="r">
                            <td class="i">
                                <b>Medical</b>
                            </td>
                            <td class="i">
                                <asp:Label ID="lblMedicalLeaveEarned" Text='<%# Eval("MedicalLeaveEarned")%>' runat="server" />
                            </td>
                            <td class="i">
                                <asp:Label ID="lblMedicalLeaveEnjoyed" Text='<%# Eval("MedicalLeaveEnjoyed")%>' runat="server" />
                            </td>
                            <td class="i">
                                <asp:Label ID="lblMedicalLeaveBalance" runat="server" />
                            </td>
                            <td class="i">
                                <asp:Label ID="Label2" runat="server" />
                            </td>
                        </tr>
                        <tr class="r">
                            <td class="i">
                                <b>Earn</b>
                            </td>
                            <td class="i">
                                <asp:Label ID="lblEarnLeaveEarned" Text='<%# Eval("EarnLeaveEarned")%>' runat="server" />
                            </td>
                            <td class="i">
                                <asp:Label ID="lblEarnLeaveEnjoyed" Text='<%# Eval("EarnLeaveEnjoyed")%>' runat="server" />
                            </td>
                            <td class="i">
                                <asp:Label ID="lblEarnLeaveBalance" runat="server" />
                            </td>
                            <td class="i">
                                <asp:Label ID="Label3" runat="server" />
                            </td>
                        </tr>
                        <tr class="r">
                            <td class="i">
                                <b>LWP</b>
                            </td>
                            <td class="i">
                                <asp:Label ID="lblLWPLeaveEarned" Text='<%# Eval("LWPLeaveEarned")%>' runat="server" />
                            </td>
                            <td class="i">
                                <asp:Label ID="lblLWPLeaveEnjoyed" Text='<%# Eval("LWPLeaveEnjoyed")%>' runat="server" />
                            </td>
                            <td class="i">
                                <asp:Label ID="lblLWPLeaveBalance" runat="server" />
                            </td>
                            <td class="i">
                                <asp:Label ID="Label4" runat="server" />
                            </td>
                        </tr>
                        <tr class="r">
                            <td colspan="3" class="i" align="center">
                                <b>Leave Status</b>
                            </td>
                            <td class="i">
                                <b>Total Enjoyed</b>
                            </td>
                            <td class="i">
                                <asp:Label ID="lblTotalLeaveEnjoyed" runat="server" />
                            </td>
                        </tr>
                    </ItemTemplate>
                    <EmptyDataTemplate>
                        <div class="edr">
                            No Records Found To Display
                        </div>
                    </EmptyDataTemplate>
                </asp:ListView>
            </div>
            <asp:ObjectDataSource ID="odsLeaveStatus" runat="server" SelectMethod="GetPagedData"
                SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.HREmployeeLeaveStatus_DetailedDataSource"
                SortParameterName="sortExpression" OnSelecting="odsLeaveStatus_Selecting">
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
        <div class="listContentTitle">
            Employee Leave Application List
        </div>
        <div>
            <div class="lv-c">
                <asp:ListView ID="lvHREmployeeLeaveApplication" runat="server" DataSourceID="odsHREmployeeLeaveApplication"
                    OnItemCommand="lvHREmployeeLeaveApplication_ItemCommand" OnItemDataBound="lvHREmployeeLeaveApplication_ItemDataBound">
                    <LayoutTemplate>
                        <table class="lv" cellpadding="0" cellspacing="0">
                            <tr class="h">
                                <td class="rp">
                                    &nbsp;
                                </td>
                                <td class="hi">
                                    Employee
                                </td>
                                <td class="hi">
                                    Application Date
                                </td>
                                <td class="hi">
                                    Request Start Date
                                </td>
                                <td class="hi">
                                    Request End Date
                                </td>
                                <td class="hi">
                                    Total Leave Days
                                </td>
                                <td class="hi">
                                    Description
                                </td>
                                <td class="hi">
                                    Backup Employee
                                </td>
                                <td class="hi">
                                    Application Status
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
                                <%# Eval("EmployeeFullName")%>
                            </td>
                            <td class="i">
                                <%# Eval("ApplicationDate") != null ? ((DateTime)Eval("ApplicationDate")).ToString("dd-MM-yyyy") : ""%>
                            </td>
                            <td class="i">
                                <%# Eval("RequestStartDate") != null ? ((DateTime)Eval("RequestStartDate")).ToString("dd-MM-yyyy") : ""%>
                            </td>
                            <td class="i">
                                <%# Eval("RequestEndDate") != null ? ((DateTime)Eval("RequestEndDate")).ToString("dd-MM-yyyy") : ""%>
                            </td>
                            <td class="i">
                                <%# Eval("TotalLeaveDays")%>
                            </td>
                            <td class="i">
                                <%# Eval("Description")%>
                            </td>
                            <td class="i">
                                <%# Eval("BackupEmployeeFullName")%>
                            </td>
                            <td class="i">
                                <%# Eval("Name")%>
                                <br />
                                <asp:HyperLink ID="lnkShowApprovalStatus" runat="server" Text="Approval Status" />
                            </td>
                            <td class="i" style="display: none;">
                                <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                    Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("EmployeeLeaveApplicationID")%>'
                                    UniqueKey="HREmployeeLeaveApplication_lvHREmployeeLeaveApplication_Edit_key" />
                            </td>
                            <td class="i" style="display: none;">
                                <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                    Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Employee Leave Application?')"
                                    CommandArgument='<%#Eval("EmployeeLeaveApplicationID")%>' UniqueKey="HREmployeeLeaveApplication_lvHREmployeeLeaveApplication_Edit_key" />
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
                                <%# Eval("EmployeeFullName")%>
                            </td>
                            <td class="i">
                                <%# Eval("ApplicationDate") != null ? ((DateTime)Eval("ApplicationDate")).ToString("dd-MM-yyyy") : ""%>
                            </td>
                            <td class="i">
                                <%# Eval("RequestStartDate") != null ? ((DateTime)Eval("RequestStartDate")).ToString("dd-MM-yyyy") : ""%>
                            </td>
                            <td class="i">
                                <%# Eval("RequestEndDate") != null ? ((DateTime)Eval("RequestEndDate")).ToString("dd-MM-yyyy") : ""%>
                            </td>
                            <td class="i">
                                <%# Eval("TotalLeaveDays")%>
                            </td>
                            <td class="i">
                                <%# Eval("Description")%>
                            </td>
                            <td class="i">
                                <%# Eval("BackupEmployeeFullName")%>
                            </td>
                            <td class="i">
                                <%# Eval("Name")%>
                                <br />
                                <asp:HyperLink ID="lnkShowApprovalStatus" runat="server" Text="Approval Status" />
                            </td>
                            <td class="i" style="display: none;">
                                <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                    Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("EmployeeLeaveApplicationID")%>'
                                    UniqueKey="HREmployeeLeaveApplication_lvHREmployeeLeaveApplication_Edit_key" />
                            </td>
                            <td class="i" style="display: none;">
                                <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                    Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Employee Leave Application?')"
                                    CommandArgument='<%#Eval("EmployeeLeaveApplicationID")%>' UniqueKey="HREmployeeLeaveApplication_lvHREmployeeLeaveApplication_Edit_key" />
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
            <asp:ObjectDataSource ID="odsHREmployeeLeaveApplication" runat="server" SelectMethod="GetPagedData"
                SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.HREmployeeLeaveApplication_DetailedDataSource"
                SortParameterName="sortExpression" OnSelecting="odsHREmployeeLeaveApplication_Selecting">
                <SelectParameters>
                    <asp:Parameter Name="startRowIndex" Type="Int32" />
                    <asp:Parameter Name="pageSize" Type="Int32" />
                    <asp:Parameter Name="sortExpression" Type="String" />
                    <asp:Parameter Name="filterExpression" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
