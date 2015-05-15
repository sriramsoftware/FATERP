<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 09-Dec-2012, 08:03:28
--%>




<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ACCPrePayableStatement.ascx.cs"
    Inherits="Bay.ERP.Web.UI.ACCPrePayableStatementControl" %>

<script language="javascript" type="text/javascript">
        function BindEvents() {
            $(document).ready(function () {
                $("#txtStartDate").change(function () {
                    var StartDate = $.datepicker.parseDate('dd-mm-yy', $("#txtStartDate").val());

                    var actualDate = new Date(StartDate);
                    var newDate = new Date(actualDate.getFullYear(), actualDate.getMonth(), actualDate.getDate() + 7);

                    $('#txtEndDate').val($.datepicker.formatDate('dd-mm-yy', newDate));

                    var ref = $('#txtRef').val();
                    if (ref == "") {
                        ref = "PAYABLE - WEEK / YEAR DATE- " + $("#txtStartDate").val();
                        $('#txtRef').val(ref);
                    }
                });
            });
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
                    <asp:Label ID="lvlCollapsText" runat="server" Text="Add/Edit Payable Statement"></asp:Label>
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
                        Ref Note&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtRef" runat="server" ValidationGroup="ACCPrePayableStatementEntity" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvRef" runat="server" ControlToValidate="txtRef"
                            ErrorMessage="Please Enter Ref" ValidationGroup="ACCPrePayableStatementEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Create Date&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtCreateDate">
                            Enter Create Date</label>
                        <asp:TextBox ID="txtCreateDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox" Enabled="false"
                            ValidationGroup="ACCPrePayableStatementEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvCreateDate" runat="server" ControlToValidate="txtCreateDate"
                            ErrorMessage="Please Enter Create Date" ValidationGroup="ACCPrePayableStatementEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revCreateDate" runat="server" ControlToValidate="txtCreateDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="ACCPrePayableStatementEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                 <ajaxToolkit:CalendarExtender ID="CEtxtStartDate" runat="server" TargetControlID="txtStartDate" Format="dd-MM-yyyy">
                            </ajaxToolkit:CalendarExtender>
                            <ajaxToolkit:CalendarExtender ID="CEtxtEndDate" runat="server" TargetControlID="txtEndDate" Format="dd-MM-yyyy">
                            </ajaxToolkit:CalendarExtender>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Start Date&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <label class="watermarkLabel" for="txtStartDate">
                            Enter Start Date</label>
                           
                        <asp:TextBox ID="txtStartDate" runat="server" ClientIDMode="Static" CssClass="ktiTextBox"
                            ValidationGroup="ACCPrePayableStatementEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvStartDate" runat="server" ControlToValidate="txtStartDate"
                            ErrorMessage="Please Enter Start Date" ValidationGroup="ACCPrePayableStatementEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revStartDate" runat="server" ControlToValidate="txtStartDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="ACCPrePayableStatementEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        End Date&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <label class="watermarkLabel" for="txtEndDate">
                            Enter End Date</label>
                        <asp:TextBox ID="txtEndDate" runat="server" ClientIDMode="Static" CssClass="ktiTextBox"
                            ValidationGroup="ACCPrePayableStatementEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvEndDate" runat="server" ControlToValidate="txtEndDate"
                            ErrorMessage="Please Enter End Date" ValidationGroup="ACCPrePayableStatementEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revEndDate" runat="server" ControlToValidate="txtEndDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="ACCPrePayableStatementEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100; display:none;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Is Removed&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:CheckBox ID="chkIsRemoved" runat="server" ClientIDMode="Static" ValidationGroup="ACCPrePayableStatementEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="ACCPrePayableStatementEntity" OnClick="btnSave_Click"
                            runat="server" Text="Add" UniqueKey="ACCPrePayableStatementControl_Submit_key" />
                        <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click"
                            runat="server" Text="Add New" UniqueKey="ACCPrePayableStatementControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click"
                            runat="server" Text="Clear" UniqueKey="ACCPrePayableStatementControl_Clear_key" />
                    </div>
                </div>
                <br />
            </asp:Panel>
            <div class="listContentTitle">
                Payable Statement List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvACCPrePayableStatement" runat="server" DataSourceID="odsACCPrePayableStatement" OnItemCommand="lvACCPrePayableStatement_ItemCommand" OnItemDataBound="lvACCPrePayableStatement_ItemDataBound">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi" style="width:250px;">
                                        Ref #
                                    </td>
                                    <td class="hi">
                                        Create Date
                                    </td>
                                    <td class="hi">
                                        Start Date
                                    </td>
                                    <td class="hi">
                                        End Date
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Is Removed
                                    </td>
                                    <td class="his">
                                        Report
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
                                <asp:HyperLink ID="hypPayableRef" runat="server" Text=' <%# Eval("Ref")%>' CssClass="CommonLink"
                                            ToolTip="Please Click Here To See The Overview!"></asp:HyperLink>
                                </td>
                                <td class="i">
                                    <%# Eval("CreateDate") != null ? ((DateTime)Eval("CreateDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("StartDate") != null ? ((DateTime)Eval("StartDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("EndDate") != null ? ((DateTime)Eval("EndDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("IsRemoved") != null ? (((Boolean)Eval("IsRemoved")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                <asp:HyperLink ID="hypReport" runat="server" CssClass="CommonButtonLink"
                                    Text="Report" CommandName="Report" CommandArgument='<%#Eval("PrePayableStatementID")%>'></asp:HyperLink>
                            </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("PrePayableStatementID")%>' UniqueKey="ACCPrePayableStatement_lvACCPrePayableStatement_Edit_key" />
                                </td>
                                <td class="i">
                            <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete A CCPre Payable Statement?')"
                                        CommandArgument='<%#Eval("PrePayableStatementID")%>' UniqueKey="ACCPrePayableStatement_lvACCPrePayableStatement_Delete_key"/>
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
                                  <asp:HyperLink ID="hypPayableRef" runat="server" Text=' <%# Eval("Ref")%>' CssClass="CommonLink"
                                            ToolTip="Please Click Here To See The Overview!"></asp:HyperLink>
                                </td>
                                <td class="i">
                                    <%# Eval("CreateDate") != null ? ((DateTime)Eval("CreateDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("StartDate") != null ? ((DateTime)Eval("StartDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("EndDate") != null ? ((DateTime)Eval("EndDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("IsRemoved") != null ? (((Boolean)Eval("IsRemoved")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                <asp:HyperLink ID="hypReport" runat="server" CssClass="CommonButtonLink"
                                    Text="Report" CommandName="Report" CommandArgument='<%#Eval("PrePayableStatementID")%>'></asp:HyperLink>
                            </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("PrePayableStatementID")%>' UniqueKey="ACCPrePayableStatement_lvACCPrePayableStatement_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete A CCPre Payable Statement?')"
                                        CommandArgument='<%#Eval("PrePayableStatementID")%>' UniqueKey="ACCPrePayableStatement_lvACCPrePayableStatement_Delete_key"/>
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
                <asp:ObjectDataSource ID="odsACCPrePayableStatement" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.ACCPrePayableStatementDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsACCPrePayableStatement_Selecting">
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
