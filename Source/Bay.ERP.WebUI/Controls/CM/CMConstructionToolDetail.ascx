<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 25-Jan-2012, 03:00:49
--%>




<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CMConstructionToolDetail.ascx.cs"
    Inherits="Bay.ERP.Web.UI.CMConstructionToolDetailControl" %>

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
                    <asp:Label ID="lvlCollapsText" runat="server" Text="Add/Edit Construction Tool Detail"></asp:Label>
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
                        Construction Tool&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:Label ID="lblConstructionTool" runat="server" Font-Bold="true"></asp:Label>                        
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Specification&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtSpecification">
                            Enter Specification</label>
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="390" Height="105" ClientIDMode="Static"
                            ID="txtSpecification" runat="server" ValidationGroup="CMConstructionToolDetailEntity" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvSpecification" runat="server" ControlToValidate="txtSpecification"
                            ErrorMessage="Please Enter Specification" ValidationGroup="CMConstructionToolDetailEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                       <asp:HyperLink CssClass="hypTableFormLeble" ID="hypWorkingCondition" runat="server" Text="Working Condition" NavigateUrl="~/MD/MDConstructionToolWorkingCondition.aspx" Target="_blank"></asp:HyperLink>
                        &nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlConstructionToolWorkingConditionID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="CMConstructionToolDetailEntity" Width="236">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvConstructionToolWorkingConditionID" runat="server" ControlToValidate="ddlConstructionToolWorkingConditionID"
                            ErrorMessage="Please Select Construction Tool Working Condition" ValidationGroup="CMConstructionToolDetailEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                       <asp:HyperLink CssClass="hypTableFormLeble" ID="hypBrand" runat="server" Text="Brand" NavigateUrl="~/MD/MDBrand.aspx" Target="_blank"></asp:HyperLink>
                        &nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlBrandID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="CMConstructionToolDetailEntity" Width="236">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                    <asp:HyperLink CssClass="hypTableFormLeble" ID="hypSupplier" runat="server" Text="Vendor" NavigateUrl="~/PRM/PRMSupplier.aspx" Target="_blank"></asp:HyperLink>
                        &nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlSupplierID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="CMConstructionToolDetailEntity" Width="236">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Next Main. Date&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtNextMaintananceDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="CMConstructionToolDetailEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revNextMaintananceDate" runat="server" ControlToValidate="txtNextMaintananceDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="CMConstructionToolDetailEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Used Or Handeled By&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtUsedOrHandeledBy" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="CMConstructionToolDetailEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                    <asp:HyperLink CssClass="hypTableFormLeble" ID="hypProject" runat="server" Text="Project" NavigateUrl="~/BD/BDProject.aspx" Target="_blank"></asp:HyperLink>
                        &nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlProjectID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="CMConstructionToolDetailEntity" Width="236">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Remarks&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtRemarks" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="CMConstructionToolDetailEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="CMConstructionToolDetailEntity" OnClick="btnSave_Click"
                            runat="server" Text="Add" UniqueKey="CMConstructionToolDetailControl_Submit_key" />
                        <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click"
                            runat="server" Text="Add New" UniqueKey="CMConstructionToolDetailControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click"
                            runat="server" Text="Clear" UniqueKey="CMConstructionToolDetailControl_Clear_key" />
                    </div>
                </div>
                <br />
            </asp:Panel>
            <div class="listContentTitle">
                Construction Tool Detail List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvCMConstructionToolDetail" runat="server" DataSourceID="odsCMConstructionToolDetail" OnItemCommand="lvCMConstructionToolDetail_ItemCommand">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi">
                                        Construction Tool
                                    </td>
                                    <td class="hi">
                                        Specification
                                    </td>
                                    <td class="hi">
                                        Construction Tool Working Condition
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Brand
                                    </td>
                                    <td class="hi">
                                        Vendor
                                    </td>
                                    <td class="hi">
                                        Next Maintanance Date
                                    </td>
                                    <td class="hi">
                                        Used Or Handeled By
                                    </td>
                                    <td class="hi">
                                        Project
                                    </td>
                                    <td class="hi" style="display:none;">
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
                                    <%# Eval("ConstructionToolToolName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Specification")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ConstructionToolWorkingConditionName")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("MDBrandBrandName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("SupplierName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("NextMaintananceDate") != null ? ((DateTime)Eval("NextMaintananceDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("UsedOrHandeledBy")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ProjectName")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("ConstructionToolDetailID")%>' UniqueKey="CMConstructionToolDetail_lvCMConstructionToolDetail_Edit_key" />
                                </td>
                                <td class="i">
                            <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Construction Tool Detail?')"
                                        CommandArgument='<%#Eval("ConstructionToolDetailID")%>' UniqueKey="CMConstructionToolDetail_lvCMConstructionToolDetail_Delete_key"/>
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
                                    <%# Eval("ConstructionToolToolName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Specification")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ConstructionToolWorkingConditionName")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("MDBrandBrandName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("SupplierName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("NextMaintananceDate") != null ? ((DateTime)Eval("NextMaintananceDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("UsedOrHandeledBy")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ProjectName")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("ConstructionToolDetailID")%>' UniqueKey="CMConstructionToolDetail_lvCMConstructionToolDetail_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Construction Tool Detail?')"
                                        CommandArgument='<%#Eval("ConstructionToolDetailID")%>' UniqueKey="CMConstructionToolDetail_lvCMConstructionToolDetail_Delete_key"/>
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
                <asp:ObjectDataSource ID="odsCMConstructionToolDetail" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.CMConstructionToolDetail_DetailedDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsCMConstructionToolDetail_Selecting">
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
