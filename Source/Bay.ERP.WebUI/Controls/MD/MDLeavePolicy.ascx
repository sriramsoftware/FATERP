<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 19-Dec-2013, 12:42:28
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MDLeavePolicy.ascx.cs"
    Inherits="Bay.ERP.Web.UI.MDLeavePolicyControl" %>
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
                    <asp:Label ID="lvlCollapsText" runat="server" Text="Add/Edit Loan Category"></asp:Label>
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
                        Fiscal Year:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlFiscalYearID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="MDLeavePolicyEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvFiscalYearID" runat="server" ControlToValidate="ddlFiscalYearID"
                            ErrorMessage="Please Select Fiscal Year" ValidationGroup="MDLeavePolicyEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Employee Job Type:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlEmployeeJobTypeID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="MDLeavePolicyEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvEmployeeJobTypeID" runat="server" ControlToValidate="ddlEmployeeJobTypeID"
                            ErrorMessage="Please Select Fiscal Year" ValidationGroup="MDLeavePolicyEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Leave Category:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlLeaveCategoryID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="MDLeavePolicyEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvLeaveCategoryID" runat="server" ControlToValidate="ddlLeaveCategoryID"
                            ErrorMessage="Please Select Leave Category" ValidationGroup="MDLeavePolicyEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Leave In Days&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtLeaveInDays">
                            Enter Leave In Days</label>
                        <asp:TextBox ID="txtLeaveInDays" ClientIDMode="Static" CssClass="ktiDecimalTextBox" runat="server"
                            ValidationGroup="MDLeavePolicyEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvLeaveInDays" runat="server" ControlToValidate="txtLeaveInDays"
                            ErrorMessage="Please Enter Leave In Days" ValidationGroup="MDLeavePolicyEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Remarks&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtRemarks">
                            Enter Remarks</label>
                        <asp:TextBox ID="txtRemarks" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="MDLeavePolicyEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Is Removed&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:CheckBox ID="chkIsRemoved" runat="server" ClientIDMode="Static" ValidationGroup="MDLeavePolicyEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <asp:Button ID="btnSubmit" ValidationGroup="MDLeavePolicyEntity" OnClick="btnSave_Click"
                            runat="server" Text="Add" UniqueKey="MDLeavePolicyControl_Submit_key" />
                        <asp:Button ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click" runat="server"
                            Text="Add New" UniqueKey="MDLeavePolicyControl_AddNew_key" />
                        <asp:Button ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear" UniqueKey="MDLeavePolicyControl_Clear_key" />
                    </div>
                </div>
                <br />
            </asp:Panel>
            <div class="listContentTitle">
                Leave Policy List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvMDLeavePolicy" runat="server" DataSourceID="odsMDLeavePolicy"
                        OnItemCommand="lvMDLeavePolicy_ItemCommand">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi">
                                        Fiscal Year
                                    </td>
                                    <td class="hi" style="width: 128px;">
                                        Employee Job Type
                                    </td>
                                    <td class="hi">
                                        Leave Category
                                    </td>
                                    <td class="hi">
                                        LeaveInDays
                                    </td>
                                    <td class="hi">
                                        Remarks
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
                                    <%# Eval("FiscalYearBeginDate") != null ? ((DateTime)Eval("FiscalYearBeginDate")).ToString("dd-MM-yyyy") : ""%>&nbsp;to
                                    <br />
                                    <%# Eval("FiscalYearEndDate") != null ? ((DateTime)Eval("FiscalYearEndDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("EmployeeJobTypeName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("LeaveCategoryName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("LeaveInDays")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Remarks")%>
                                </td>
                                
                                <td class="i">
                                    <asp:LinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("LeavePolicyID")%>' UniqueKey="MDLoanCategory_lvMDLoanCategory_Edit_key" />
                                </td>
                                <td class="i">
                                    <asp:LinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Loan Category?')"
                                        CommandArgument='<%#Eval("LeavePolicyID")%>' UniqueKey="MDLoanCategory_lvMDLoanCategory_Edit_key" />
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
                                    <%# Eval("FiscalYearBeginDate") != null ? ((DateTime)Eval("FiscalYearBeginDate")).ToString("dd-MM-yyyy") : ""%>&nbsp;to
                                    <br />
                                    <%# Eval("FiscalYearEndDate") != null ? ((DateTime)Eval("FiscalYearEndDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                 <td class="i">
                                    <%# Eval("EmployeeJobTypeName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("LeaveCategoryName")%>
                                </td>
                                 <td class="i">
                                    <%# Eval("LeaveInDays")%>
                                </td>
                                 <td class="i">
                                    <%# Eval("Remarks")%>
                                </td>
                                 
                                <td class="i">
                                    <asp:LinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("LeavePolicyID")%>' UniqueKey="MDLeavePolicy_lvMDLeavePolicy_Edit_key" />
                                </td>
                                <td class="i">
                                    <asp:LinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Leave Policy?')"
                                        CommandArgument='<%#Eval("LeavePolicyID")%>' UniqueKey="MDLeavePolicy_lvMDLeavePolicy_Edit_key" />
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
                <asp:ObjectDataSource ID="odsMDLeavePolicy" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.MDLeavePolicy_DetailedDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsMDLeavePolicy_Selecting">
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