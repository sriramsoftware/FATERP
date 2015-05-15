<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 20-Dec-2013, 02:17:52
--%>




<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HREmployeeEducation.ascx.cs"
    Inherits="Bay.ERP.Web.UI.HREmployeeEducationControl" %>

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
                    <asp:Label ID="lvlCollapsText" runat="server" Text="Add/Edit Employee Education"></asp:Label>
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
                        <asp:HyperLink CssClass="hypTableFormLeble" ID="hypEducationalDegree" runat="server" Text="Educational Degree" NavigateUrl="~/MD/MDEducationalDegree.aspx"
                                Target="_blank"></asp:HyperLink>
                    :
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlEducationalDegreeID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="HREmployeeEducationEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvEducationalDegreeID" runat="server" ControlToValidate="ddlEducationalDegreeID"
                            ErrorMessage="Please Select Educational Degree" ValidationGroup="HREmployeeEducationEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Passed Year&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtPassedYear" runat="server" ClientIDMode="Static" CssClass="ktiNumberTextBox"
                            ValidationGroup="HREmployeeEducationEntity" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvPassedYear" runat="server" ControlToValidate="txtPassedYear" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136)" MinimumValue="-2147483648" MaximumValue="2147483647"
                            Type="Integer" ValidationGroup="HREmployeeEducationEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Session&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtSession" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="HREmployeeEducationEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Result&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtResult">
                            Enter Result</label>
                        <asp:TextBox ID="txtResult" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="HREmployeeEducationEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvResult" runat="server" ControlToValidate="txtResult"
                            ErrorMessage="Please Enter Result" ValidationGroup="HREmployeeEducationEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Result Out Of&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtResultOutOf" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="HREmployeeEducationEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Remarks&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtRemarks" runat="server" ValidationGroup="HREmployeeEducationEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Is Completed&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:CheckBox ID="chkIsCompleted" runat="server" ClientIDMode="Static" ValidationGroup="HREmployeeEducationEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Is Last Acquired&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:CheckBox ID="chkIsLastAcquired" runat="server" ClientIDMode="Static" ValidationGroup="HREmployeeEducationEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="HREmployeeEducationEntity" OnClick="btnSave_Click"
                            runat="server" Text="Add" UniqueKey="HREmployeeEducationControl_Submit_key" />
                        <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click"
                            runat="server" Text="Add New" UniqueKey="HREmployeeEducationControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click"
                            runat="server" Text="Clear" UniqueKey="HREmployeeEducationControl_Clear_key" />
                    </div>
                </div>
                <br />
            </asp:Panel>
            <div class="listContentTitle">
                Employee Education List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvHREmployeeEducation" runat="server" DataSourceID="odsHREmployeeEducation" OnItemCommand="lvHREmployeeEducation_ItemCommand">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    
                                    <td class="hi">
                                        Educational Degree
                                    </td>
                                    <td class="hi">
                                        Passed Year
                                    </td>
                                    <td class="hi">
                                        Session
                                    </td>
                                    <td class="hi">
                                        Result
                                    </td>
                                    <td class="hi">
                                        Result Out Of
                                    </td>
                                    <td class="hi">
                                        Remarks
                                    </td>
                                    <td class="hi">
                                        Is Completed
                                    </td>
                                    <td class="hi">
                                        Is Last Acquired
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
                                    <%# Eval("EducationalDegreeName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("PassedYear")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Session")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Result")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ResultOutOf")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i">
                                    <%# Eval("IsCompleted") != null ? (((Boolean)Eval("IsCompleted")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("IsLastAcquired") != null ? (((Boolean)Eval("IsLastAcquired")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("EmployeeEducationID")%>' UniqueKey="HREmployeeEducation_lvHREmployeeEducation_Edit_key" />
                                </td>
                                <td class="i">
                            <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Employee Education?')"
                                        CommandArgument='<%#Eval("EmployeeEducationID")%>' UniqueKey="HREmployeeEducation_lvHREmployeeEducation_Edit_key"/>
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
                                    <%# Eval("EducationalDegreeName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("PassedYear")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Session")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Result")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ResultOutOf")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i">
                                    <%# Eval("IsCompleted") != null ? (((Boolean)Eval("IsCompleted")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("IsLastAcquired") != null ? (((Boolean)Eval("IsLastAcquired")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("EmployeeEducationID")%>' UniqueKey="HREmployeeEducation_lvHREmployeeEducation_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Employee Education?')"
                                        CommandArgument='<%#Eval("EmployeeEducationID")%>' UniqueKey="HREmployeeEducation_lvHREmployeeEducation_Edit_key"/>
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
                <asp:ObjectDataSource ID="odsHREmployeeEducation" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.HREmployeeEducation_DetailedDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsHREmployeeEducation_Selecting">
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
