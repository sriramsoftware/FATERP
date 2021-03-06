<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 28-May-2015, 08:31:04
--%>




<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BDOperatorAddressInfo.ascx.cs"
    Inherits="Bay.ERP.Web.UI.BDOperatorAddressInfoControl" %>

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
                    <asp:Label ID="lvlCollapsText" runat="server" Text="Add/Edit Operator Address Info"></asp:Label>
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
                            runat="server" ValidationGroup="BDOperatorAddressInfoEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvOperatorID" runat="server" ControlToValidate="ddlOperatorID"
                            ErrorMessage="Please Select Operator" ValidationGroup="BDOperatorAddressInfoEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Web Link&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtWebLink" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="BDOperatorAddressInfoEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revWebLink" runat="server" ControlToValidate="txtWebLink" Display="Dynamic"
                            EnableViewState="False" ValidationGroup="BDOperatorAddressInfoEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Operator Address Type&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlOperatorAddressTypeID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="BDOperatorAddressInfoEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvOperatorAddressTypeID" runat="server" ControlToValidate="ddlOperatorAddressTypeID"
                            ErrorMessage="Please Select Operator Address Type" ValidationGroup="BDOperatorAddressInfoEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Address Line1&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtAddressLine1">
                            Enter Address Line1</label>
                        <asp:TextBox ID="txtAddressLine1" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="BDOperatorAddressInfoEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvAddressLine1" runat="server" ControlToValidate="txtAddressLine1"
                            ErrorMessage="Please Enter Address Line1" ValidationGroup="BDOperatorAddressInfoEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Address Line2&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtAddressLine2" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="BDOperatorAddressInfoEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Country&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtCountryID" runat="server" ClientIDMode="Static" CssClass="ktiNumberTextBox"
                            ValidationGroup="BDOperatorAddressInfoEntity" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvCountryID" runat="server" ControlToValidate="txtCountryID" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136)" MinimumValue="-2147483648" MaximumValue="2147483647"
                            Type="Integer" ValidationGroup="BDOperatorAddressInfoEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        City&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtCityID" runat="server" ClientIDMode="Static" CssClass="ktiNumberTextBox"
                            ValidationGroup="BDOperatorAddressInfoEntity" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvCityID" runat="server" ControlToValidate="txtCityID" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136)" MinimumValue="-2147483648" MaximumValue="2147483647"
                            Type="Integer" ValidationGroup="BDOperatorAddressInfoEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Zip Code&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtZipCode" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="BDOperatorAddressInfoEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revZipCode" runat="server" ControlToValidate="txtZipCode" Display="Dynamic"
                            EnableViewState="False" ValidationGroup="BDOperatorAddressInfoEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Phone&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtPhone" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="BDOperatorAddressInfoEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revPhone" runat="server" ControlToValidate="txtPhone" Display="Dynamic"
                            EnableViewState="False" ValidationGroup="BDOperatorAddressInfoEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Email&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtEmail" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="BDOperatorAddressInfoEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail" Display="Dynamic"
                            EnableViewState="False" ValidationGroup="BDOperatorAddressInfoEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="BDOperatorAddressInfoEntity" OnClick="btnSave_Click"
                            runat="server" Text="Add" UniqueKey="BDOperatorAddressInfoControl_Submit_key" />
                        <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click"
                            runat="server" Text="Add New" UniqueKey="BDOperatorAddressInfoControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click"
                            runat="server" Text="Clear" UniqueKey="BDOperatorAddressInfoControl_Clear_key" />
                    </div>
                </div>
                <br />
            </asp:Panel>
            <div class="listContentTitle">
                Operator Address Info List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvBDOperatorAddressInfo" runat="server" DataSourceID="odsBDOperatorAddressInfo" OnItemCommand="lvBDOperatorAddressInfo_ItemCommand">
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
                                        Web Link
                                    </td>
                                    <td class="hi">
                                        Operator Address Type
                                    </td>
                                    <td class="hi">
                                        Address Line1
                                    </td>
                                    <td class="hi">
                                        Address Line2
                                    </td>
                                    <td class="hi">
                                        Country
                                    </td>
                                    <td class="hi">
                                        City
                                    </td>
                                    <td class="hi">
                                        Zip Code
                                    </td>
                                    <td class="hi">
                                        Phone
                                    </td>
                                    <td class="hi">
                                        Email
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
                                    <%# Eval("WebLink")%>
                                </td>
                                <td class="i">
                                    <%# Eval("OperatorAddressTypeID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("AddressLine1")%>
                                </td>
                                <td class="i">
                                    <%# Eval("AddressLine2")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CountryID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CityID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ZipCode")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Phone")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Email")%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("OperatorAddressInfoID")%>' UniqueKey="BDOperatorAddressInfo_lvBDOperatorAddressInfo_Edit_key" />
                                </td>
                                <td class="i">
                            <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Operator Address Info?')"
                                        CommandArgument='<%#Eval("OperatorAddressInfoID")%>' UniqueKey="BDOperatorAddressInfo_lvBDOperatorAddressInfo_Edit_key"/>
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
                                    <%# Eval("WebLink")%>
                                </td>
                                <td class="i">
                                    <%# Eval("OperatorAddressTypeID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("AddressLine1")%>
                                </td>
                                <td class="i">
                                    <%# Eval("AddressLine2")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CountryID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CityID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ZipCode")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Phone")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Email")%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("OperatorAddressInfoID")%>' UniqueKey="BDOperatorAddressInfo_lvBDOperatorAddressInfo_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Operator Address Info?')"
                                        CommandArgument='<%#Eval("OperatorAddressInfoID")%>' UniqueKey="BDOperatorAddressInfo_lvBDOperatorAddressInfo_Edit_key"/>
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
                <asp:ObjectDataSource ID="odsBDOperatorAddressInfo" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.BDOperatorAddressInfoDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsBDOperatorAddressInfo_Selecting">
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
