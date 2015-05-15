<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 28-Dec-2011, 07:18:54
--%>
 
<script language="javascript" type="text/javascript">
    function BindEvents() {
        $(document).ready(function () {
            $("#txtJoinDate").change(function () {
                var startDate = $.datepicker.parseDate('dd-mm-yy', $("#txtJoinDate").val());


                startDate = new Date(startDate);

                var diff = 1;
                if (startDate) {
                    startDate = addDate(startDate, 180); // ms per day
                    //startDate = 
                    $("#txtConfirmDate").val(startDate.toLocaleString());
                }

                
            });


        });

        function addDate(dateObject, numDays) {
            
            dateObject.setDate(dateObject.getDate() + numDays);
            return dateObject.toLocaleDateString();
        }

    }
</script>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HREmployee.ascx.cs" Inherits="Bay.ERP.Web.UI.HREmployeeControl" %>
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
                    <asp:Label ID="lvlCollapsText" runat="server" Text="Add/Edit Employee"></asp:Label>
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
                <div id="Div1" class="TableRow" style="text-align: left;" runat="server">
                    <asp:Label ID="Label1" EnableViewState="false" runat="server"></asp:Label>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        First Name&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtFirstName">
                            Enter First Name</label>
                        <asp:TextBox ID="txtFirstName" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="CMContractorEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvFirstName" runat="server" ControlToValidate="txtFirstName"
                            ErrorMessage="Please Enter First Name" ValidationGroup="CMContractorEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Middle Name&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtMiddleName" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="CMContractorEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Last Name&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtLastName">
                            Enter Last Name</label>
                        <asp:TextBox ID="txtLastName" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="CMContractorEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvLastName" runat="server" ControlToValidate="txtLastName"
                            ErrorMessage="Please Enter Last Name" ValidationGroup="HRMemberEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Employee Code&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtEmployeeCode">
                            Enter Employee Code</label>
                        <asp:TextBox ID="txtEmployeeCode" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="HREmployeeEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvEmployeeCode" runat="server" ControlToValidate="txtEmployeeCode"
                            ErrorMessage="Please Enter Employee Code" ValidationGroup="HREmployeeEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Salary Level&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtSalaryLevel">
                            Enter Salary Level</label>
                        <asp:TextBox ID="txtSalaryLevel" ClientIDMode="Static" CssClass="ktiDecimalTextBox" runat="server"
                            ValidationGroup="HREmployeeEntity" Width="210" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvSalaryLevel" runat="server" ControlToValidate="txtSalaryLevel"
                            ErrorMessage="Please Enter Salary Level" ValidationGroup="HREmployeeEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Project&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlProjectID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="HREmployeeEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="ddlProjectID"
                            ErrorMessage="Please Select Department" ValidationGroup="HREmployeeEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Department&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlDepartmentID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="HREmployeeEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvDepartmentID" runat="server" ControlToValidate="ddlDepartmentID"
                            ErrorMessage="Please Select Department" ValidationGroup="HREmployeeEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        <asp:HyperLink CssClass="hypTableFormLeble" ID="hypDesignation" runat="server" Text="Designation"
                            NavigateUrl="~/HR/HREmployeeDesignation.aspx" Target="_blank"></asp:HyperLink>
                        &nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlDesignationID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="HREmployeeEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvDesignationID" runat="server" ControlToValidate="ddlDesignationID"
                            ErrorMessage="Please Select Designation" ValidationGroup="HREmployeeEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Employee Job Type&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlEmployeeJobTypeID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="HREmployeeEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvEmployeeJobTypeID" runat="server" ControlToValidate="ddlEmployeeJobTypeID"
                            ErrorMessage="Please Select Employee Job Type" ValidationGroup="HREmployeeEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <ajaxToolkit:CalendarExtender ID="CEtxtJoinDate" runat="server" TargetControlID="txtJoinDate"
                                Format="dd-MM-yyyy">
                            </ajaxToolkit:CalendarExtender>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Join Date&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtJoinDate" runat="server" ClientIDMode="Static" CssClass="ktiTextBox"
                            ValidationGroup="HREmployeeEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvJoinDate" runat="server" ControlToValidate="txtJoinDate"
                            ErrorMessage="Please Enter Join Date" ValidationGroup="HREmployeeEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revJoinDate" runat="server" ControlToValidate="txtJoinDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="HREmployeeEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Confirm Date&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtConfirmDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="HREmployeeEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <%--<asp:RegularExpressionValidator ID="revConfirmDate" runat="server" ControlToValidate="txtConfirmDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="HREmployeeEntity"></asp:RegularExpressionValidator>--%>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        DOB&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtDOB" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="HREmployeeEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revDOB" runat="server" ControlToValidate="txtDOB"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="HREmployeeEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Blood Group&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlBloodGroupID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="HREmployeeEntity" Width="234">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Primary Email&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtPrimaryEmail">
                            Enter Primary Email</label>
                        <asp:TextBox ID="txtPrimaryEmail" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="HREmployeeEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvPrimaryEmail" runat="server" ControlToValidate="txtPrimaryEmail"
                            ErrorMessage="Please Enter Primary Email" ValidationGroup="HREmployeeEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revPrimaryEmail" runat="server" ControlToValidate="txtPrimaryEmail"
                            Display="Dynamic" EnableViewState="True" ValidationGroup="HREmployeeEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Secondary Email&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtSecondaryEmail" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="HREmployeeEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revSecondaryEmail" runat="server" ControlToValidate="txtSecondaryEmail"
                            Display="Dynamic" EnableViewState="true" ValidationGroup="HREmployeeEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Initials&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtInitials" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="HREmployeeEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Employment Status&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlEmploymentStatusID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="HREmployeeEntity" AutoPostBack="true" OnSelectedIndexChanged="ddlEmploymentStatusID_SelectedIndexChanged"
                            Width="234">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <asp:Panel ID="pnlDiscontinuedDate" runat="server">
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: left;">
                            Discontinued Date&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:TextBox ID="txtDiscontinuedDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                                ValidationGroup="HREmployeeEntity" Width="230" />
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RegularExpressionValidator ID="revDiscontinuedDate" runat="server" ControlToValidate="txtDiscontinuedDate"
                                Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                                ValidationGroup="HREmployeeEntity"></asp:RegularExpressionValidator>
                        </div>
                    </div>
                </asp:Panel>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="HREmployeeEntity" OnClick="btnSave_Click"
                            runat="server" Text="Add" UniqueKey="HREmployeeControl_Submit_key" />
                        <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click" runat="server"
                            Text="Add New" UniqueKey="HREmployeeControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear"
                            UniqueKey="HREmployeeControl_Clear_key" />
                    </div>
                </div>
                <br />
            </asp:Panel>
            <div class="TableRow" style="width: 100%; float: right;">
                <div class="TableFormLeble">
                    &nbsp;</div>
                <div class="TableFormLeble" style="text-align: right; width: 617px;">
                    Filter Text&nbsp;:
                </div>
                <div class="TableFormContent waterMarkContainer">
                    <label class="watermarkLabel" for="txtSearchText">
                        Type Employee Code or Name</label>
                    <asp:TextBox ID="txtSearchText" runat="server" ClientIDMode="Static" CssClass="ktiTextBox"
                        Width="230" /><span><asp:CheckBox ID="chbxFilter" runat="server" AutoPostBack="true"
                            OnCheckedChanged="chbxFilter_CheckedChanged" Text="Use Filter" /></span>
                </div>
            </div>
            <div class="TableRow" style="width: 100%; float: right;">
                <div class="TableFormLeble">
                    &nbsp;</div>
                <div class="TableFormLeble" style="text-align: right; width: 929px;">
                    <asp:HyperLink ID="hypEmployeeListReport" runat="server" CssClass="CommonButtonLink"
                        Text="Employee List Report" CommandName="EmployeeListReport" UniqueKey="HREmployee_lvHREmployee_ProjectReport_key"></asp:HyperLink>
                </div>
            </div>
            <div style="width: 100%;">
                <div style="float: left;">
                    Total Employee&nbsp:&nbsp;<asp:Label ID="lblTotalEmployee" runat="server"></asp:Label>
                    &nbsp;&nbsp;&nbsp;
                </div>
                <div style="float: left;">
                    Active Employee&nbsp:&nbsp;<asp:Label ID="lblActiveEmployee" runat="server" ForeColor="Green"></asp:Label>
                </div>
                <div style="clear: both;">
                </div>
            </div>
            <br />
            <div class="listContentTitle">
                Employee List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvHREmployee" runat="server" DataSourceID="odsHREmployee_Detailed"
                        OnItemDataBound="lvHREmployee_ItemDataBound" OnItemCommand="lvHREmployee_ItemCommand">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="his">
                                        EDIT
                                    </td>
                                    <td class="his">
                                        DELETE
                                    </td>
                                    <td class="hi" style="width: 186px;">
                                        Employee
                                    </td>
                                    <td class="hi">
                                        Employee Code
                                    </td>
                                    <td class="hi" style="width: 122px;">
                                        JoinDate
                                    </td>
                                    <td class="hi" style="width: 122px;">
                                        ConfirmDate
                                    </td>
                                    <td class="hi" style="width: 69px;">
                                        Salary Level
                                    </td>
                                    <td class="hi">
                                        Job Type
                                    </td>
                                    <td class="hi">
                                        Designation
                                    </td>
                                    <td class="hi">
                                        Employment Status
                                    </td>
                                    
                                    <td class="his">
                                        Employee Details
                                    </td>
                                    <td class="his" style="width: 150px;">
                                        Employee Personal File
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
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("EmployeeID")%>'
                                        UniqueKey="HREmployee_lvHREmployee_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Employee?')"
                                        CommandArgument='<%#Eval("EmployeeID")%>' UniqueKey="HREmployee_lvHREmployee_Delete_key" />
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="hypEmployeeFullName" runat="server" Text='<%# Eval("EmployeeFullName")%>'
                                        Target="_blank"></asp:HyperLink>
                                    <br />
                                    <asp:HyperLink ID="hypEmployee" runat="server" Text='<%# Eval("EmployeeID")%>' CssClass="CommonLink"
                                        Visible="false" ToolTip="Please Click Here To See The Overview!"></asp:HyperLink>
                                </td>
                                <td class="i">
                                    <%# Eval("EmployeeCode")%>
                                </td>
                                <td class="i">
                                    <%# Eval("JoinDate") != null ? ((DateTime)Eval("JoinDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                <%# Eval("ConfirmDate") != null ? ((DateTime)Eval("ConfirmDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("SalaryLevel")%>
                                </td>
                                
                                <td class="i">
                                    <%# Eval("Name")%>
                                </td>
                                <td class="i">
                                    <%# Eval("DesignationName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("EmploymentStatusName")%>
                                </td>
                                
                                <td class="i">
                                    <asp:HyperLink ID="hypEmployeeDetailsReport" runat="server" CssClass="CommonButtonLink"
                                        Text="Report" CommandName="EmployeeDetailsReport" CommandArgument='<%#Eval("EmployeeID")%>'
                                        UniqueKey="HREmployee_lvHREmployee_ProjectReport_key"></asp:HyperLink>
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="hypEmployeePersonalFile" runat="server" CssClass="CommonButtonLink"
                                        Text="Employee Personal File" CommandName="EmployeePersonalFile" CommandArgument='<%#Eval("EmployeeID")%>'
                                        UniqueKey="HREmployee_lvHREmployee_ProjectReport_key"></asp:HyperLink>
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
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("EmployeeID")%>'
                                        UniqueKey="HREmployee_lvHREmployee_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Employee?')"
                                        CommandArgument='<%#Eval("EmployeeID")%>' UniqueKey="HREmployee_lvHREmployee_Delete_key" />
                                </td>
                                
                                <td class="i">
                                    <asp:HyperLink ID="hypEmployeeFullName" runat="server" Text='<%# Eval("EmployeeFullName")%>'
                                        Target="_blank"></asp:HyperLink>
                                    <br />
                                    <asp:HyperLink ID="hypEmployee" runat="server" Text='<%# Eval("EmployeeID")%>' CssClass="CommonLink"
                                        Visible="false" ToolTip="Please Click Here To See The Overview!"></asp:HyperLink>
                                </td>
                                <td class="i">
                                    <%# Eval("EmployeeCode")%>
                                </td>
                                <td class="i">
                                    <%# Eval("JoinDate") != null ? ((DateTime)Eval("JoinDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                <%# Eval("ConfirmDate") != null ? ((DateTime)Eval("ConfirmDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("SalaryLevel")%>
                                </td>
                                
                                <td class="i">
                                    <%# Eval("Name")%>
                                </td>
                                <td class="i">
                                    <%# Eval("DesignationName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("EmploymentStatusName")%>
                                </td>
                                
                                <td class="i">
                                    <asp:HyperLink ID="hypEmployeeDetailsReport" runat="server" CssClass="CommonButtonLink"
                                        Text="Report" CommandName="EmployeeDetailsReport" CommandArgument='<%#Eval("EmployeeID")%>'
                                        UniqueKey="HREmployee_lvHREmployee_ProjectReport_key"></asp:HyperLink>
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="hypEmployeePersonalFile" runat="server" CssClass="CommonButtonLink"
                                        Text="Employee Personal File" CommandName="EmployeePersonalFile" CommandArgument='<%#Eval("EmployeeID")%>'
                                        UniqueKey="HREmployee_lvHREmployee_ProjectReport_key"></asp:HyperLink>
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
                <asp:ObjectDataSource ID="odsHREmployee_Detailed" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.HREmployee_DetailedDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsHREmployee_Detailed_Selecting">
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
