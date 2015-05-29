<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 25-May-2015, 10:52:29
--%>




<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BDProject.ascx.cs"
    Inherits="Bay.ERP.Web.UI.BDProjectControl" %>

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
                    <asp:Label ID="lvlCollapsText" runat="server" Text="Add/Edit Project"></asp:Label>
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
                        Operator&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlOperatorID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="BDProjectEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvOperatorID" runat="server" ControlToValidate="ddlOperatorID"
                            ErrorMessage="Please Select Operator" ValidationGroup="BDProjectEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Zone&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlZoneID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="BDProjectEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvZoneID" runat="server" ControlToValidate="ddlZoneID"
                            ErrorMessage="Please Select Zone" ValidationGroup="BDProjectEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Project Code&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtProjectCode">
                            Enter Project Code</label>
                        <asp:TextBox ID="txtProjectCode" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="BDProjectEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvProjectCode" runat="server" ControlToValidate="txtProjectCode"
                            ErrorMessage="Please Enter Project Code" ValidationGroup="BDProjectEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Project Name&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtProjectName">
                            Enter Project Name</label>
                        <asp:TextBox ID="txtProjectName" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="BDProjectEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvProjectName" runat="server" ControlToValidate="txtProjectName"
                            ErrorMessage="Please Enter Project Name" ValidationGroup="BDProjectEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Land Area Katha&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtLandAreaKatha" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="BDProjectEntity" Type="Number" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvLandAreaKatha" runat="server" ControlToValidate="txtLandAreaKatha" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="BDProjectEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Land Area Sft&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtLandAreaSft" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="BDProjectEntity" Type="Number" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvLandAreaSft" runat="server" ControlToValidate="txtLandAreaSft" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="BDProjectEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Road Width&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtRoadWidth" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="BDProjectEntity" Type="Number" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvRoadWidth" runat="server" ControlToValidate="txtRoadWidth" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="BDProjectEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Road Width Unit&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlRoadWidthUnitID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="BDProjectEntity" Width="234">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        No Of Storied&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtNoOfStoried" runat="server" ClientIDMode="Static" CssClass="ktiNumberTextBox"
                            ValidationGroup="BDProjectEntity" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvNoOfStoried" runat="server" ControlToValidate="txtNoOfStoried" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136)" MinimumValue="-2147483648" MaximumValue="2147483647"
                            Type="Integer" ValidationGroup="BDProjectEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        No Of Basement&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtNoOfBasement" runat="server" ClientIDMode="Static" CssClass="ktiNumberTextBox"
                            ValidationGroup="BDProjectEntity" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvNoOfBasement" runat="server" ControlToValidate="txtNoOfBasement" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136)" MinimumValue="-2147483648" MaximumValue="2147483647"
                            Type="Integer" ValidationGroup="BDProjectEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Description&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtDescription" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="BDProjectEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        B SC&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtBSC" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="BDProjectEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Client Percentage&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtClientPercentage" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="BDProjectEntity" Type="Number" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvClientPercentage" runat="server" ControlToValidate="txtClientPercentage" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="BDProjectEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Company Percentage&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtCompanyPercentage" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="BDProjectEntity" Type="Number" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvCompanyPercentage" runat="server" ControlToValidate="txtCompanyPercentage" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="BDProjectEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Project Category&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlProjectCategoryID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="BDProjectEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvProjectCategoryID" runat="server" ControlToValidate="ddlProjectCategoryID"
                            ErrorMessage="Please Select Project Category" ValidationGroup="BDProjectEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Project Status&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlProjectStatusID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="BDProjectEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvProjectStatusID" runat="server" ControlToValidate="ddlProjectStatusID"
                            ErrorMessage="Please Select Project Status" ValidationGroup="BDProjectEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Is Removed&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:CheckBox ID="chkIsRemoved" runat="server" ClientIDMode="Static" ValidationGroup="BDProjectEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="BDProjectEntity" OnClick="btnSave_Click"
                            runat="server" Text="Add" UniqueKey="BDProjectControl_Submit_key" />
                        <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click"
                            runat="server" Text="Add New" UniqueKey="BDProjectControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click"
                            runat="server" Text="Clear" UniqueKey="BDProjectControl_Clear_key" />
                    </div>
                </div>
                <br />
            </asp:Panel>
            <div class="listContentTitle">
                Project List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvBDProject" runat="server" DataSourceID="odsBDProject" OnItemCommand="lvBDProject_ItemCommand">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi">
                                        Operator
                                    </td>
                                    <td class="hi">
                                        Zone
                                    </td>
                                    <td class="hi">
                                        Project Code
                                    </td>
                                    <td class="hi">
                                        Project Name
                                    </td>
                                    <td class="hi">
                                        Land Area Katha
                                    </td>
                                    <td class="hi">
                                        Land Area Sft
                                    </td>
                                    <td class="hi">
                                        Road Width
                                    </td>
                                    <td class="hi">
                                        Road Width Unit
                                    </td>
                                    <td class="hi">
                                        No Of Storied
                                    </td>
                                    <td class="hi">
                                        No Of Basement
                                    </td>
                                    <td class="hi">
                                        Description
                                    </td>
                                    <td class="hi">
                                        B SC
                                    </td>
                                    <td class="hi">
                                        Client Percentage
                                    </td>
                                    <td class="hi">
                                        Company Percentage
                                    </td>
                                    <td class="hi">
                                        Project Category
                                    </td>
                                    <td class="hi">
                                        Project Status
                                    </td>
                                    <td class="hi">
                                        Is Removed
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
                                    <%# Eval("OperatorID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ZoneID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ProjectCode")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ProjectName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("LandAreaKatha")%>
                                </td>
                                <td class="i">
                                    <%# Eval("LandAreaSft")%>
                                </td>
                                <td class="i">
                                    <%# Eval("RoadWidth")%>
                                </td>
                                <td class="i">
                                    <%# Eval("RoadWidthUnitID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("NoOfStoried")%>
                                </td>
                                <td class="i">
                                    <%# Eval("NoOfBasement")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Description")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BSC")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ClientPercentage")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CompanyPercentage")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ProjectCategoryID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ProjectStatusID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("IsRemoved") != null ? (((Boolean)Eval("IsRemoved")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("ProjectID")%>' UniqueKey="BDProject_lvBDProject_Edit_key" />
                                </td>
                                <td class="i">
                            <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Project?')"
                                        CommandArgument='<%#Eval("ProjectID")%>' UniqueKey="BDProject_lvBDProject_Edit_key"/>
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
                                    <%# Eval("OperatorID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ZoneID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ProjectCode")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ProjectName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("LandAreaKatha")%>
                                </td>
                                <td class="i">
                                    <%# Eval("LandAreaSft")%>
                                </td>
                                <td class="i">
                                    <%# Eval("RoadWidth")%>
                                </td>
                                <td class="i">
                                    <%# Eval("RoadWidthUnitID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("NoOfStoried")%>
                                </td>
                                <td class="i">
                                    <%# Eval("NoOfBasement")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Description")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BSC")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ClientPercentage")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CompanyPercentage")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ProjectCategoryID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ProjectStatusID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("IsRemoved") != null ? (((Boolean)Eval("IsRemoved")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("ProjectID")%>' UniqueKey="BDProject_lvBDProject_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Project?')"
                                        CommandArgument='<%#Eval("ProjectID")%>' UniqueKey="BDProject_lvBDProject_Edit_key"/>
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
                <asp:ObjectDataSource ID="odsBDProject" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.BDProjectDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsBDProject_Selecting">
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
