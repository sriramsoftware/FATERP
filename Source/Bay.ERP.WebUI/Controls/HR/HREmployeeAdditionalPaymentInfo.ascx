<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 12-Jan-2014, 03:42:17
--%>




<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HREmployeeAdditionalPaymentInfo.ascx.cs"
    Inherits="Bay.ERP.Web.UI.HREmployeeAdditionalPaymentInfoControl" %>

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
                    <asp:Label ID="lvlCollapsText" runat="server" Text="Add/Edit Employee Additional Payment Info"></asp:Label>
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
                        Pay Date&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtPayDate">
                            Enter Pay Date</label>
                        <asp:TextBox ID="txtPayDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="HREmployeeAdditionalPaymentInfoEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvPayDate" runat="server" ControlToValidate="txtPayDate"
                            ErrorMessage="Please Enter Pay Date" ValidationGroup="HREmployeeAdditionalPaymentInfoEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revPayDate" runat="server" ControlToValidate="txtPayDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)\d\d$"
                            ValidationGroup="HREmployeeAdditionalPaymentInfoEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Pay Amount&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtPayAmount">
                            Enter Pay Amount</label>
                        <asp:TextBox ID="txtPayAmount" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="HREmployeeAdditionalPaymentInfoEntity" Width="210" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvPayAmount" runat="server" ControlToValidate="txtPayAmount"
                            ErrorMessage="Please Enter Pay Amount" ValidationGroup="HREmployeeAdditionalPaymentInfoEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvPayAmount" runat="server" ControlToValidate="txtPayAmount" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="HREmployeeAdditionalPaymentInfoEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Pay Currency&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtPayCurrency">
                            Enter Pay Currency</label>
                        <asp:TextBox ID="txtPayCurrency" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="HREmployeeAdditionalPaymentInfoEntity" Width="210" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvPayCurrency" runat="server" ControlToValidate="txtPayCurrency"
                            ErrorMessage="Please Enter Pay Currency" ValidationGroup="HREmployeeAdditionalPaymentInfoEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvPayCurrency" runat="server" ControlToValidate="txtPayCurrency" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="HREmployeeAdditionalPaymentInfoEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Notes&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtNotes">
                            Enter Notes</label>
                        <asp:TextBox ID="txtNotes" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="HREmployeeAdditionalPaymentInfoEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvNotes" runat="server" ControlToValidate="txtNotes"
                            ErrorMessage="Please Enter Notes" ValidationGroup="HREmployeeAdditionalPaymentInfoEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Pay Now&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:CheckBox ID="chkPayNow" runat="server" ClientIDMode="Static" ValidationGroup="HREmployeeAdditionalPaymentInfoEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Pay During Payroll Generation&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtPayDuringPayrollGenerationEditorID">
                            Enter Pay During Payroll Generation</label>
                        <asp:TextBox ID="txtPayDuringPayrollGenerationEditorID" CssClass="ktiNumberTextBox" ClientIDMode="Static" runat="server"
                            ValidationGroup="HREmployeeAdditionalPaymentInfoEntity" Width="210" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvPayDuringPayrollGenerationEditorID" runat="server" ControlToValidate="txtPayDuringPayrollGenerationEditorID"
                            ErrorMessage="Please Enter Pay During Payroll Generation" ValidationGroup="HREmployeeAdditionalPaymentInfoEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvPayDuringPayrollGenerationEditorID" runat="server" ControlToValidate="txtPayDuringPayrollGenerationEditorID" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136)" MinimumValue="-2147483648" MaximumValue="2147483647"
                            Type="Integer" ValidationGroup="HREmployeeAdditionalPaymentInfoEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="HREmployeeAdditionalPaymentInfoEntity" OnClick="btnSave_Click"
                            runat="server" Text="Add" UniqueKey="HREmployeeAdditionalPaymentInfoControl_Submit_key" />
                        <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click"
                            runat="server" Text="Add New" UniqueKey="HREmployeeAdditionalPaymentInfoControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click"
                            runat="server" Text="Clear" UniqueKey="HREmployeeAdditionalPaymentInfoControl_Clear_key" />
                    </div>
                </div>
                <br />
            </asp:Panel>
            <div class="listContentTitle">
                Employee Additional Payment Info List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvHREmployeeAdditionalPaymentInfo" runat="server" DataSourceID="odsHREmployeeAdditionalPaymentInfo" OnItemCommand="lvHREmployeeAdditionalPaymentInfo_ItemCommand">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi">
                                        Pay Date
                                    </td>
                                    <td class="hi">
                                        Pay Amount
                                    </td>
                                    <td class="hi">
                                        Pay Currency
                                    </td>
                                    <td class="hi">
                                        Notes
                                    </td>
                                    <td class="hi">
                                        Pay Now
                                    </td>
                                    <td class="hi">
                                        Pay During Payroll Generation
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
                                    <%# Eval("PayDate") != null ? ((DateTime)Eval("PayDate")).ToString("mm-dd-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("PayAmount")%>
                                </td>
                                <td class="i">
                                    <%# Eval("PayCurrency")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Notes")%>
                                </td>
                                <td class="i">
                                    <%# Eval("PayNow") != null ? (((Boolean)Eval("PayNow")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("PayDuringPayrollGenerationEditorID")%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("EmployeeAdditonalPaymentInfoID")%>' UniqueKey="HREmployeeAdditionalPaymentInfo_lvHREmployeeAdditionalPaymentInfo_Edit_key" />
                                </td>
                                <td class="i">
                            <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Employee Additional Payment Info?')"
                                        CommandArgument='<%#Eval("EmployeeAdditonalPaymentInfoID")%>' UniqueKey="HREmployeeAdditionalPaymentInfo_lvHREmployeeAdditionalPaymentInfo_Edit_key"/>
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
                                    <%# Eval("PayDate") != null ? ((DateTime)Eval("PayDate")).ToString("mm-dd-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("PayAmount")%>
                                </td>
                                <td class="i">
                                    <%# Eval("PayCurrency")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Notes")%>
                                </td>
                                <td class="i">
                                    <%# Eval("PayNow") != null ? (((Boolean)Eval("PayNow")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("PayDuringPayrollGenerationEditorID")%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("EmployeeAdditonalPaymentInfoID")%>' UniqueKey="HREmployeeAdditionalPaymentInfo_lvHREmployeeAdditionalPaymentInfo_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Employee Additional Payment Info?')"
                                        CommandArgument='<%#Eval("EmployeeAdditonalPaymentInfoID")%>' UniqueKey="HREmployeeAdditionalPaymentInfo_lvHREmployeeAdditionalPaymentInfo_Edit_key"/>
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
                <asp:ObjectDataSource ID="odsHREmployeeAdditionalPaymentInfo" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.HREmployeeAdditionalPaymentInfoDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsHREmployeeAdditionalPaymentInfo_Selecting">
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
