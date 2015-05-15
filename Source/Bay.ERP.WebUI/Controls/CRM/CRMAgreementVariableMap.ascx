<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 17-Apr-2013, 05:21:43
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CRMAgreementVariableMap.ascx.cs"
    Inherits="Bay.ERP.Web.UI.CRMAgreementVariableMapControl" %>
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
                    <asp:Label ID="lvlCollapsText" runat="server" Text="Add/Edit Agreement Variable Map"></asp:Label>
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
                        Name&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtName">
                            Enter Name</label>
                        <asp:TextBox ID="txtName" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="CRMAgreementVariableMapEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName"
                            ErrorMessage="Please Enter Name" ValidationGroup="CRMAgreementVariableMapEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Value&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtValue">
                            Enter Value</label>
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtValue" runat="server" ValidationGroup="CRMAgreementVariableMapEntity" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvValue" runat="server" ControlToValidate="txtValue"
                            ErrorMessage="Please Enter Value" ValidationGroup="CRMAgreementVariableMapEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Remarks&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtRemarks" runat="server" ValidationGroup="CRMAgreementVariableMapEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="CRMAgreementVariableMapEntity"
                            OnClick="btnSave_Click" runat="server" Text="Add" UniqueKey="CRMAgreementVariableMapControl_Submit_key" />
                        <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click" runat="server"
                            Text="Add New" UniqueKey="CRMAgreementVariableMapControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear"
                            UniqueKey="CRMAgreementVariableMapControl_Clear_key" />
                    </div>
                </div>
                <div id="">
                <div id="dvQuick" style="float:left;">
                N.B. <br />
                After Creating the Variable go back to your agreement in the previous tab <br />
                and Add the variable with this format &lt;%variablename%&gt;. example: &lt;%1st installment%&gt;

                </div>
                
                </div>
                <br />
            </asp:Panel>
            <div class="TableRow" style="width: 100%; padding-left:480px;">
            <div class="TableFormLeble" style="text-align: right;">
               Filter Text&nbsp;:
            </div>
            <div class="TableFormContent waterMarkContainer">
             <label class="watermarkLabel" for="txtSearchText">
                            Type Agre. Name# Value</label>
                <asp:TextBox ID="txtSearchText" runat="server" ClientIDMode="Static" CssClass="ktiTextBox" Width="230" /><span><asp:CheckBox ID="chbxFilter"
                        runat="server" AutoPostBack="true" OnCheckedChanged="chbxFilter_CheckedChanged" Text="Use Filter" /></span>
            </div>
            <div class="TableFormValidatorContent">
            </div>
        </div>
            <div class="listContentTitle">
              Agreement Variable Map List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvCRMAgreementVariableMap" runat="server" DataSourceID="odsCRMAgreementVariableMap"
                        OnItemCommand="lvCRMAgreementVariableMap_ItemCommand">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi" style="width:250px;">
                                        Name
                                    </td>
                                    <td class="hi" style="width:200px;">
                                        Value
                                    </td>
                                    <td class="hi" style="width:100px;">
                                        Remarks
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Created By Employee
                                    </td>
                                    <td class="hi">
                                        Create Date
                                    </td>
                                    <td class="hi" style="display:none;">
                                        I P
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
                                    <%# Eval("Name")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Value")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("CreatedByEmployeeID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CreateDate") != null ? ((DateTime)Eval("CreateDate")).ToString("mm-dd-yyyy") : ""%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("IP")%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("AgreementVariableMapID")%>'
                                        UniqueKey="CRMAgreementVariableMap_lvCRMAgreementVariableMap_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete C RMAgreement Variable Map?')"
                                        CommandArgument='<%#Eval("AgreementVariableMapID")%>' UniqueKey="CRMAgreementVariableMap_lvCRMAgreementVariableMap_Edit_key" />
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
                                    <%# Eval("Name")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Value")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("CreatedByEmployeeID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CreateDate") != null ? ((DateTime)Eval("CreateDate")).ToString("mm-dd-yyyy") : ""%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("IP")%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("AgreementVariableMapID")%>'
                                        UniqueKey="CRMAgreementVariableMap_lvCRMAgreementVariableMap_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete C RMAgreement Variable Map?')"
                                        CommandArgument='<%#Eval("AgreementVariableMapID")%>' UniqueKey="CRMAgreementVariableMap_lvCRMAgreementVariableMap_Edit_key" />
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
                <asp:ObjectDataSource ID="odsCRMAgreementVariableMap" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.CRMAgreementVariableMapDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsCRMAgreementVariableMap_Selecting">
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
