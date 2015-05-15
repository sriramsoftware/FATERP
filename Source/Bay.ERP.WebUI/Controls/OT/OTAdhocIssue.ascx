<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 28-Dec-2011, 07:18:54
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="OTAdhocIssue.ascx.cs"
    Inherits="Bay.ERP.Web.UI.OTAdhocIssueControl" %>

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
    div.demo {
        padding: 8px !important;
    }
</style>
<script type="text/javascript">
    function BindSliderEvents() {
        $(function () {
            var x = $("#txtCompletionPercentage").val();
            $("#slider-range-min").slider({
                range: "min",
                value: x,
                min: 0,
                max: 100,
                slide: function (event, ui) {
                    $("#txtCompletionPercentage").val(ui.value);
                    $("#amount").val(ui.value + " % ");
                }
            });
            $("#amount").val($("#slider-range-min").slider("value") + " % ");
        });
    }
</script>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <script type="text/javascript">
            Sys.Application.add_load(BindEvents);
            Sys.Application.add_load(BindSliderEvents);
        </script>
        <div>
            <div id="Div1" class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div style="float: left; width: 600px;">
                <asp:Panel ID="pnlCreateIssue" runat="server">
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: left;">
                            Issue Category&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:DropDownList ID="ddlIssueCategoryID" CssClass="ktiSelect" ClientIDMode="Static"
                                runat="server" ValidationGroup="OTIssueEntity" Width="236">
                            </asp:DropDownList>
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="rfvIssueCategoryID" runat="server" ControlToValidate="ddlIssueCategoryID"
                                ErrorMessage="Please Select Issue Category" ValidationGroup="OTIssueEntity" EnableViewState="False"
                                Display="Dynamic"></asp:RequiredFieldValidator>
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
                                ValidationGroup="OTIssueEntity" Width="230" />
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="rfvTitle" runat="server" ControlToValidate="txtTitle"
                                ErrorMessage="Please Enter Title" ValidationGroup="OTIssueEntity" EnableViewState="False"
                                Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: left;">
                            Description&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="390" Height="105"
                                ClientIDMode="Static" ID="txtDescription" runat="server" ValidationGroup="OTIssueEntity" />
                        </div>
                        <div class="TableFormValidatorContent">
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: left;">
                            <asp:HyperLink CssClass="hypTableFormLeble" ID="hypIssuePriority" runat="server"
                                Text="Issue Priority" NavigateUrl="~/MD/MDIssuePriority.aspx" Target="_blank"></asp:HyperLink>
                            &nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:DropDownList ID="ddlIssuePriorityID" CssClass="ktiSelect" ClientIDMode="Static"
                                runat="server" ValidationGroup="OTIssueEntity" Width="236">
                            </asp:DropDownList>
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="rfvIssuePriorityID" runat="server" ControlToValidate="ddlIssuePriorityID"
                                ErrorMessage="Please Select Issue Priority" ValidationGroup="OTIssueEntity" EnableViewState="False"
                                Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>
                    </div>

                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: left;">
                            Duration&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:TextBox ID="txtDuration" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                                runat="server" ValidationGroup="OTIssueEntity" Type="Number" Width="210" />
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RangeValidator ID="rvDuration" runat="server" ControlToValidate="txtDuration"
                                Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                Type="Double" ValidationGroup="OTIssueEntity"></asp:RangeValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: left;">
                            Expected Start Date&nbsp;:
                        </div>
                        <div class="TableFormContent waterMarkContainer">
                            <label class="watermarkLabel" for="txtExpectedStartDate">
                                Enter Expected Start Date Time</label>
                            <asp:TextBox ID="txtExpectedStartDate" runat="server" ClientIDMode="Static" CssClass="ktiTextBox"
                                ValidationGroup="OTIssueEntity" Width="230" />
                            <span class="RequiredField">*</span>
                            <asp:TextBox ID="example1" runat="server" ClientIDMode="Static" Visible="false" ValidationGroup="OTIssueEntity"
                                Width="230" />
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="rfvExpectedStartDate" runat="server" ControlToValidate="txtExpectedStartDate"
                                ErrorMessage="Please Enter Expected Start Date" ValidationGroup="OTIssueEntity"
                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="revExpectedStartDate" runat="server" ControlToValidate="example1"
                                Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="^([0]\d|[1][0-2])\/([0-2]\d|[3][0-1])\/([2][01]|[1][6-9])\d{2}(\s([0-1]\d|[2][0-3])(\:[0-5]\d){1,2})?$"></asp:RegularExpressionValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: left;">
                            Expected End Date&nbsp;:
                        </div>
                        <div class="TableFormContent waterMarkContainer">
                            <label class="watermarkLabel" for="txtExpectedEndDate">
                                Enter Expected End Date Time</label>
                            <asp:TextBox ID="txtExpectedEndDate" runat="server" ClientIDMode="Static" CssClass="ktiTextBox"
                                ValidationGroup="OTIssueEntity" Width="230" />
                            <asp:TextBox ID="TextBox1" runat="server" ClientIDMode="Static" Visible="false" ValidationGroup="OTIssueEntity"
                                Width="230" />
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="rfvExpectedEndDate" runat="server" ControlToValidate="txtExpectedEndDate"
                                ErrorMessage="Please Enter Expected End Date" ValidationGroup="OTIssueEntity"
                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="revExpectedEndDate" runat="server" ControlToValidate="TextBox1"
                                Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="^([0]\d|[1][0-2])\/([0-2]\d|[3][0-1])\/([2][01]|[1][6-9])\d{2}(\s([0-1]\d|[2][0-3])(\:[0-5]\d){1,2})?$"
                                ValidationGroup="OTIssueEntity"></asp:RegularExpressionValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: left;">
                            Supervisor&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:DropDownList ID="ddlSupervisorEmployeeID" CssClass="ktiSelect" ClientIDMode="Static"
                                runat="server" ValidationGroup="OTIssueEntity" Width="234">
                            </asp:DropDownList>
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="rfvSupervisorEmployeeID" runat="server" ControlToValidate="ddlSupervisorEmployeeID"
                                ErrorMessage="Please Select Supervisor Employee" ValidationGroup="OTIssueEntity" EnableViewState="False"
                                Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: left;">
                            Assigned To&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:DropDownList ID="ddlAssignedToEmployeeID" CssClass="ktiSelect" ClientIDMode="Static"
                                runat="server" ValidationGroup="OTIssueEntity" Width="234">
                            </asp:DropDownList>
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="rfvAssignedToEmployeeID" runat="server" ControlToValidate="ddlAssignedToEmployeeID"
                                ErrorMessage="Please Select Assigned To Employee" ValidationGroup="OTIssueEntity" EnableViewState="False"
                                Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                </asp:Panel>
                <asp:Panel ID="pnlCommon" runat="server">
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: left;">
                            Completion(%)&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <div class="demo" style="width: 230px;">
                                <div id="slider-range-min">
                                </div>
                                <p style="width: 230px;">
                                    <label for="amount">
                                    </label>
                                    <input type="text" id="amount" style="border: 0; color: #f6931f; font-weight: bold;" />
                                </p>
                            </div>
                            <div style="display: none;">
                                <asp:TextBox ID="txtCompletionPercentage" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                                    runat="server" ValidationGroup="OTIssueEntity" Type="Number" Width="210" />
                            </div>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RangeValidator ID="rvCompletionPercentage" runat="server" ControlToValidate="txtCompletionPercentage"
                                Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                Type="Double" ValidationGroup="OTIssueEntity"></asp:RangeValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: left;">
                            <asp:HyperLink CssClass="hypTableFormLeble" ID="hypIssueStatus" runat="server" Text="Issue Status"
                                NavigateUrl="~/MD/MDIssueStatus.aspx" Target="_blank"></asp:HyperLink>
                            &nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:DropDownList ID="ddlIssueStatusID" CssClass="ktiSelect" ClientIDMode="Static"
                                runat="server" ValidationGroup="OTIssueEntity" Width="236">
                            </asp:DropDownList>
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="rfvIssueStatusID" runat="server" ControlToValidate="ddlIssueStatusID"
                                ErrorMessage="Please Select Issue Status" ValidationGroup="OTIssueEntity" EnableViewState="False"
                                Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                </asp:Panel>
                <asp:Panel ID="pnlEditMode" runat="server">
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: left;">
                            Actual Start Date&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:TextBox ID="txtActualStartDate" runat="server" ClientIDMode="Static" CssClass="ktiTextBox"
                                ValidationGroup="OTIssueEntity" Width="230" />
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RegularExpressionValidator ID="revActualStartDate" runat="server" ControlToValidate="txtActualStartDate"
                                Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="^([0]\d|[1][0-2])\/([0-2]\d|[3][0-1])\/([2][01]|[1][6-9])\d{2}(\s([0-1]\d|[2][0-3])(\:[0-5]\d){1,2})?$"
                                ValidationGroup="OTIssueEntity"></asp:RegularExpressionValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: left;">
                            Actual End Date&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:TextBox ID="txtActualEndDate" runat="server" ClientIDMode="Static" CssClass="ktiTextBox"
                                ValidationGroup="OTIssueEntity" Width="230" />
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RegularExpressionValidator ID="revActualEndDate" runat="server" ControlToValidate="txtActualEndDate"
                                Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="^([0]\d|[1][0-2])\/([0-2]\d|[3][0-1])\/([2][01]|[1][6-9])\d{2}(\s([0-1]\d|[2][0-3])(\:[0-5]\d){1,2})?$"
                                ValidationGroup="OTIssueEntity"></asp:RegularExpressionValidator>
                        </div>
                    </div>

                    <div class="TableRow" style="width: 100; display: none;">
                        <div class="TableFormLeble" style="text-align: left;">
                            Notify Before Min&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:TextBox ID="txtNotifyBeforeMin" runat="server" ClientIDMode="Static" CssClass="ktiNumberTextBox"
                                ValidationGroup="OTIssueEntity" Width="210" />
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RangeValidator ID="rvNotifyBeforeMin" runat="server" ControlToValidate="txtNotifyBeforeMin"
                                Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136)"
                                MinimumValue="-2147483648" MaximumValue="2147483647" Type="Integer" ValidationGroup="OTIssueEntity"></asp:RangeValidator>
                        </div>
                    </div>
                </asp:Panel>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Remarks&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="390" Height="105"
                            ClientIDMode="Static" ID="txtRemarks" runat="server" ValidationGroup="OTIssueEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;
                    </div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="OTIssueEntity" OnClick="btnSave_Click"
                            runat="server" Text="Add" UniqueKey="OTAdhocIssueControl_Submit_key" />
                        <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click" runat="server"
                            Text="Post New" UniqueKey="OTAdhocIssueControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear"
                            UniqueKey="OTAdhocIssueControl_Clear_key" />
                        <br />
                        <br />
                        <br />
                        <br />
                        <asp:Panel ID="pnlSupervisor" runat="server" Visible="false">
                            <asp:Label ID="lblSupervisorOpnion" runat="server" Text="Supervisor Opnion On the Progress" Font-Bold="true"></asp:Label>
                            <br />
                            <br />
                            <asp:Button ID="btnAgree" OnClick="btnAgree_Click" runat="server" Text="Agree" />
                            <asp:Button ID="btnDisAgree" OnClick="Disagree_Click" runat="server" Text="Disagree" />
                        </asp:Panel>
                    </div>
                </div>
            </div>
            <div class="contentSeperator">
            </div>
            <div style="float: left; padding-left: 20px; width: 400px;">
                <div class="listContentTitle">
                    Adhoc Issue List
                </div>
                <div>
                    <div class="lv-c" style="overflow: hidden;">
                        <asp:ListView ID="lvOTIssue" runat="server" DataSourceID="odsOTIssue" OnItemDataBound="lvOTIssue_ItemDataBound">
                            <LayoutTemplate>
                                <table class="lv" cellpadding="0" cellspacing="0">
                                    <tr class="h">
                                        <td class="rp">&nbsp;
                                        </td>
                                        <td class="hi" style="width: 222px;">Title
                                        </td>
                                        <td class="hi">Create Date
                                        </td>
                                        <td class="rp">&nbsp;
                                        </td>
                                        <td class="rpb">&nbsp;
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
                                    <td class="rp">&nbsp;
                                    </td>
                                    <td class="i">
                                        <asp:HyperLink ID="hypIssueReport" runat="server" CssClass="CommonButtonLink" Text='<%# Eval("Title")%>'
                                            CommandName="IssueReport" CommandArgument='<%#Eval("IssueID")%>'></asp:HyperLink>
                                    </td>
                                    <td class="i">
                                        <%# Eval("CreateDate") != null ? ((DateTime)Eval("CreateDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                                    </td>
                                    <td class="rp">&nbsp;
                                    </td>
                                    <td class="rpb">&nbsp;
                                    </td>
                                </tr>
                            </ItemTemplate>
                            <AlternatingItemTemplate>
                                <tr class="ar">
                                    <td class="rp">&nbsp;
                                    </td>
                                    <td class="i">
                                        <asp:HyperLink ID="hypIssueReport" runat="server" CssClass="CommonButtonLink" Text='<%# Eval("Title")%>'
                                            CommandName="IssueReport" CommandArgument='<%#Eval("IssueID")%>'></asp:HyperLink>
                                    </td>
                                    <td class="i">
                                        <%# Eval("CreateDate") != null ? ((DateTime)Eval("CreateDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                                    </td>
                                    <td class="rp">&nbsp;
                                    </td>
                                    <td class="rpb">&nbsp;
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
                    <asp:ObjectDataSource ID="odsOTIssue" runat="server" SelectMethod="GetPagedData"
                        SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                        StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.OTIssueDataSource"
                        SortParameterName="sortExpression" OnSelecting="odsOTIssue_Selecting">
                        <SelectParameters>
                            <asp:Parameter Name="startRowIndex" Type="Int32" />
                            <asp:Parameter Name="pageSize" Type="Int32" />
                            <asp:Parameter Name="sortExpression" Type="String" />
                            <asp:Parameter Name="filterExpression" Type="String" />
                        </SelectParameters>
                    </asp:ObjectDataSource>
                </div>
            </div>
            <asp:Panel ID="pnlComments" Style="float: left; width: 100%;" runat="server">
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
                </asp:Panel>
        </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
