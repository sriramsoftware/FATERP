<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 05-Oct-2013, 03:32:47
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BDProjectUnitLocation.ascx.cs"
    Inherits="Bay.ERP.Web.UI.BDProjectUnitLocationControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Project Floor&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlProjectFloorID" CssClass="ktiSelect" ClientIDMode="Static"
                        AutoPostBack="true" OnSelectedIndexChanged="ddlProjectFloorID_SelectedIndexChanged"
                        runat="server" ValidationGroup="BDProjectUnitLocationEntity" Width="234">
                    </asp:DropDownList>
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Project Floor Unit&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlProjectFloorUnitID" CssClass="ktiSelect" ClientIDMode="Static"
                        runat="server" ValidationGroup="BDProjectUnitLocationEntity" Width="234">
                    </asp:DropDownList>
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Location Category&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlFloorUnitLocationCategoryID" CssClass="ktiSelect" ClientIDMode="Static"
                        runat="server" ValidationGroup="BDProjectUnitLocationEntity" Width="234">
                    </asp:DropDownList>
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvFloorUnitLocationCategoryID" runat="server" ControlToValidate="ddlFloorUnitLocationCategoryID"
                        ErrorMessage="Please Select Floor Unit Location Category" ValidationGroup="BDProjectUnitLocationEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
        
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Location&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox ID="txtLocation" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                        ValidationGroup="BDProjectUnitLocationEntity" Width="230" />
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtLocation"
                        ErrorMessage="Please Enter Name" ValidationGroup="BDProjectUnitLocationEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Net Area Sft&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox ID="txtNetAreaSft" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                        runat="server" ValidationGroup="BDProjectUnitLocationEntity" Type="Number" Width="210" />
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RangeValidator ID="rvNetAreaSft" runat="server" ControlToValidate="txtNetAreaSft"
                        Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                        MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                        Type="Double" ValidationGroup="BDProjectUnitLocationEntity"></asp:RangeValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Gross Area Sft&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox ID="txtGrossAreaSft" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                        runat="server" ValidationGroup="BDProjectUnitLocationEntity" Type="Number" Width="210" />
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RangeValidator ID="rvGrossAreaSft" runat="server" ControlToValidate="txtGrossAreaSft"
                        Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                        MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                        Type="Double" ValidationGroup="BDProjectUnitLocationEntity"></asp:RangeValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Measurement&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                        ID="txtMeasurement" runat="server" ValidationGroup="BDProjectUnitLocationEntity" />
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Facing&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox ID="txtFacing" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                        ValidationGroup="BDProjectUnitLocationEntity" Width="230" />
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Dimension&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox ID="txtDimension" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                        ValidationGroup="BDProjectUnitLocationEntity" Width="230" />
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Description&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox ID="txtDescription" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                        ValidationGroup="BDProjectUnitLocationEntity" Width="230" />
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Modification Date&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox ID="txtModificationDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                        ValidationGroup="BDProjectUnitLocationEntity" Width="230" />
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RegularExpressionValidator ID="revModificationDate" runat="server" ControlToValidate="txtModificationDate"
                        Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                        ValidationGroup="BDProjectUnitLocationEntity"></asp:RegularExpressionValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Modification Note&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                        ID="txtModificationNote" runat="server" ValidationGroup="BDProjectUnitLocationEntity" />
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    Special Features&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                        ID="txtSpecialFeatures" runat="server" ValidationGroup="BDProjectUnitLocationEntity" />
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="width: 100; display: none;">
                <div class="TableFormLeble" style="text-align: right;">
                    Extra1&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                        ID="txtExtra1" runat="server" ValidationGroup="BDProjectUnitLocationEntity" />
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="width: 100; display: none;">
                <div class="TableFormLeble" style="text-align: right;">
                    Extra2&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                        ID="txtExtra2" runat="server" ValidationGroup="BDProjectUnitLocationEntity" />
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="text-align: center;">
                <div class="TableFormLeble">
                    &nbsp;</div>
                <div class="TableFormContent">
                    <asp:Button ID="btnSubmit" ValidationGroup="BDProjectUnitLocationEntity" OnClick="btnSave_Click"
                        runat="server" Text="Add" />
                    <asp:Button ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click" runat="server"
                        Text="Add New" />
                    <asp:Button ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear" />
                </div>
            </div>
            <br />
            <div class="listContentTitle">
                Project Unit Location List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvBDProjectUnitLocation" runat="server" DataSourceID="odsBDProjectUnitLocation"
                        OnItemCommand="lvBDProjectUnitLocation_ItemCommand">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi">
                                        Project
                                    </td>
                                    <td class="hi">
                                        Project Floor
                                    </td>
                                    <td class="hi">
                                        Project Floor Unit
                                    </td>
                                    <td class="hi">
                                        Floor Unit Location Category
                                    </td>
                                    <td class="hi">
                                        Project Unit Location Name
                                    </td>
                                    <td class="hi">
                                        Net Area Sft
                                    </td>
                                    <td class="hi">
                                        Gross Area Sft
                                    </td>
                                    <td class="hi">
                                        Measurement
                                    </td>
                                    <td class="hi">
                                        Facing
                                    </td>
                                    <td class="hi">
                                        Dimension
                                    </td>
                                    <td class="hi">
                                        Description
                                    </td>
                                    <td class="hi">
                                        Modification Date
                                    </td>
                                    <td class="hi">
                                        Modification Note
                                    </td>
                                    <td class="hi">
                                        Special Features
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
                                    <%# Eval("ProjectName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ProjectFloorName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ProjectFloorUnitName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("FloorUnitLocationCategoryName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ProjectUnitLocationName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("NetAreaSft")%>
                                </td>
                                <td class="i">
                                    <%# Eval("GrossAreaSft")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Measurement")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Facing")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Dimension")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Description")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ModificationDate") != null ? ((DateTime)Eval("ModificationDate")).ToString("mm-dd-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("ModificationNote")%>
                                </td>
                                <td class="i">
                                    <%# Eval("SpecialFeatures")%>
                                </td>
                                <td class="i">
                                    <asp:LinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("ProjectUnitLocationID")%>' />
                                </td>
                                <td class="i">
                                    <asp:LinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Project Unit Location?')"
                                        CommandArgument='<%#Eval("ProjectUnitLocationID")%>' />
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
                                    <%# Eval("ProjectName")%>
                                </td>
                               <td class="i">
                                    <%# Eval("ProjectFloorName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ProjectFloorUnitName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("FloorUnitLocationCategoryName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ProjectUnitLocationName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("NetAreaSft")%>
                                </td>
                                <td class="i">
                                    <%# Eval("GrossAreaSft")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Measurement")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Facing")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Dimension")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Description")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ModificationDate") != null ? ((DateTime)Eval("ModificationDate")).ToString("mm-dd-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("ModificationNote")%>
                                </td>
                                <td class="i">
                                    <%# Eval("SpecialFeatures")%>
                                </td>
                                <td class="i">
                                    <asp:LinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("ProjectUnitLocationID")%>' />
                                </td>
                                <td class="i">
                                    <asp:LinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Project Unit Location?')"
                                        CommandArgument='<%#Eval("ProjectUnitLocationID")%>' />
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
                <asp:ObjectDataSource ID="odsBDProjectUnitLocation" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.BDProjectUnitLocation_DetailedDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsBDProjectUnitLocation_Selecting">
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
