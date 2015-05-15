<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 04-Oct-2012, 01:19:13
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SiteCMMeasurementBookDetail.ascx.cs"
    Inherits="Bay.ERP.Web.UI.SiteCMMeasurementBookDetailControl" %>

    <script language="javascript" type="text/javascript">
        function BindEvents() {
            $(document).ready(function () {
                $("#txtNos").keyup(function () {
//                    var lenghtft = parseDouble($("#txtLengthft").val());
//                    alert(lenghtft);
//                    var lenghtin = parseDouble($("#txtLengthin").val() / 12);
//                    var widthft = parseDouble($("#txtWidthft").val());
//                    var widthin = parseDouble($("#txtWidthin").val() / 12);
//                    var heightft = parseDouble($("#txtHeightft").val());
//                    var heightin = parseDouble($("#txtHeightin").val() / 12);
//                    $("#txtQty").val($(this).val() * (lenghtft + lenghtin) * (widthft + widthin));
                });
            });
        }
</script>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
     <script type="text/javascript">
         Sys.Application.add_load(BindEvents);
     </script>
        <div>
            <div class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div class="TableRow">
            <div style="text-align: left; padding-left: 840px;">
                    <b>Bill No</b>&nbsp;: &nbsp; &nbsp;<asp:Label ID="lblBillNo" Font-Bold="true"
                        runat="server"></asp:Label>
                </div>
                <div class="TableRow">
                    <div style="text-align: left; padding-top: 2px; padding-left: 840px;">
                        <b>Work Order</b>&nbsp;: &nbsp; &nbsp;<asp:Label ID="lblWorkOrder" Font-Bold="true"
                            runat="server"></asp:Label>
                    </div>
                </div>
                <div class="TableRow">
                    <div style="text-align: left; padding-top: 2px; padding-left: 840px;">
                        <b>Item Name</b>&nbsp;: &nbsp; &nbsp;<asp:Label ID="lblItemName" Font-Bold="true"
                            runat="server"></asp:Label>
                    </div>
                </div>
                <div class="TableFormLeble" style="text-align: right;">
                    Description&nbsp;:
                </div>
                <div class="TableFormContent waterMarkContainer">
                    <label class="watermarkLabel" for="txtDescription">
                        Enter Description</label>
                    <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="390" Height="105" ClientIDMode="Static"
                        ID="txtDescription" runat="server" ValidationGroup="CMMeasurementBookDetailEntity" />
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvDescription" runat="server" ControlToValidate="txtDescription"
                        ErrorMessage="Please Enter Description" ValidationGroup="CMMeasurementBookDetailEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    Unit&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlUnitID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                        ValidationGroup="CMMeasurementBookDetailEntity" Width="236">
                    </asp:DropDownList>
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvUnitID" runat="server" ControlToValidate="ddlUnitID"
                        ErrorMessage="Please Select Unit" ValidationGroup="CMMeasurementBookDetailEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right; text-decoration:underline;">
                    Length&nbsp;
                </div>
                <div class="TableFormContent">
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    ft&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox ID="txtLengthft" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                        runat="server" ValidationGroup="CMMeasurementBookDetailEntity" Type="Number"
                        Width="210" />
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RangeValidator ID="rvLengthft" runat="server" ControlToValidate="txtLengthft"
                        Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                        MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                        Type="Double" ValidationGroup="CMMeasurementBookDetailEntity"></asp:RangeValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    in&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox ID="txtLenghtin" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                        runat="server" ValidationGroup="CMMeasurementBookDetailEntity" Type="Number"
                        Width="210" />
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RangeValidator ID="rvLenghtin" runat="server" ControlToValidate="txtLenghtin"
                        Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                        MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                        Type="Double" ValidationGroup="CMMeasurementBookDetailEntity"></asp:RangeValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right; text-decoration:underline;">
                    Width&nbsp;
                </div>
                <div class="TableFormContent">
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    ft&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox ID="txtWidthft" CssClass="ktiDecimalTextBox" ClientIDMode="Static" runat="server"
                        ValidationGroup="CMMeasurementBookDetailEntity" Type="Number" Width="210" />
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RangeValidator ID="rvWidthft" runat="server" ControlToValidate="txtWidthft"
                        Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                        MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                        Type="Double" ValidationGroup="CMMeasurementBookDetailEntity"></asp:RangeValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    in&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox ID="txtWidthin" CssClass="ktiDecimalTextBox" ClientIDMode="Static" runat="server"
                        ValidationGroup="CMMeasurementBookDetailEntity" Type="Number" Width="210" />
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RangeValidator ID="rvWidthin" runat="server" ControlToValidate="txtWidthin"
                        Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                        MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                        Type="Double" ValidationGroup="CMMeasurementBookDetailEntity"></asp:RangeValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right; text-decoration:underline;">
                    Height&nbsp;
                </div>
                <div class="TableFormContent">
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    ft&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox ID="txtHeightft" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                        runat="server" ValidationGroup="CMMeasurementBookDetailEntity" Type="Number"
                        Width="210" />
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RangeValidator ID="rvHeightft" runat="server" ControlToValidate="txtHeightft"
                        Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                        MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                        Type="Double" ValidationGroup="CMMeasurementBookDetailEntity"></asp:RangeValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    in&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox ID="txtHeightin" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                        runat="server" ValidationGroup="CMMeasurementBookDetailEntity" Type="Number"
                        Width="210" />
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RangeValidator ID="rvHeightin" runat="server" ControlToValidate="txtHeightin"
                        Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                        MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                        Type="Double" ValidationGroup="CMMeasurementBookDetailEntity"></asp:RangeValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    Nos&nbsp;:
                </div>
                <div class="TableFormContent waterMarkContainer">
                    <label class="watermarkLabel" for="txtNos">
                        Enter Nos</label>
                    <asp:TextBox ID="txtNos" CssClass="ktiDecimalTextBox" ClientIDMode="Static" runat="server"
                        ValidationGroup="CMMeasurementBookDetailEntity" Width="210" />
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvNos" runat="server" ControlToValidate="txtNos"
                        ErrorMessage="Please Enter Nos" ValidationGroup="CMMeasurementBookDetailEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="rvNos" runat="server" ControlToValidate="txtNos" Display="Dynamic"
                        EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335"
                        MaximumValue="79228162514264337593543950335" Type="Double" ValidationGroup="CMMeasurementBookDetailEntity"></asp:RangeValidator>
                </div>
            </div>
            <div class="TableRow" style="text-align: center;">
                <div class="TableFormLeble">
                    &nbsp;</div>
                <div class="TableFormContent">
                    <kti:SecureButton ID="btnSubmit" ValidationGroup="CMMeasurementBookDetailEntity"
                        OnClick="btnSave_Click" runat="server" Text="Add" UniqueKey="SiteCMMeasurementBookDetailControl_Submit_key" />
                    <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click" runat="server"
                        Text="Add New" UniqueKey="SiteCMMeasurementBookDetailControl_AddNew_key" />
                    <kti:SecureButton ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear"
                        UniqueKey="SiteCMMeasurementBookDetailControl_Clear_key" />
                </div>
            </div>
            <br />
            <div class="listContentTitle">
                Measurement Book Detail List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvCMMeasurementBookDetail" runat="server" DataSourceID="odsCMMeasurementBookDetail"
                        OnItemCommand="lvCMMeasurementBookDetail_ItemCommand">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Measurement Book
                                    </td>
                                    <td class="hi">
                                        Description
                                    </td>
                                    <td class="hi">
                                        Unit
                                    </td>
                                    <td class="hi">
                                        Length(ft)
                                    </td>
                                    <td class="hi">
                                        Lenght(in)
                                    </td>
                                    <td class="hi">
                                        Width(ft)
                                    </td>
                                    <td class="hi">
                                        Width(in)
                                    </td>
                                    <td class="hi">
                                        Height(ft)
                                    </td>
                                    <td class="hi">
                                        Height(in)
                                    </td>
                                    <td class="hi">
                                        Nos
                                    </td>
                                    <td class="hi">
                                        Qty
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
                                <td class="i" style="display:none;">
                                    <%# Eval("MeasurementBookID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Description")%>
                                </td>
                                <td class="i">
                                    <%# Eval("UnitName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Lengthft")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Lenghtin")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Widthft")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Widthin")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Heightft")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Heightin")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Nos")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Qty")%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("MeasurementBookDetailID")%>'
                                        UniqueKey="SiteCMMeasurementBookDetail_lvCMMeasurementBookDetail_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete C MMeasurement Book Detail?')"
                                        CommandArgument='<%#Eval("MeasurementBookDetailID")%>' UniqueKey="SiteCMMeasurementBookDetail_lvCMMeasurementBookDetail_Delete_key" />
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
                                <td class="i" style="display:none;">
                                    <%# Eval("MeasurementBookID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Description")%>
                                </td>
                                <td class="i">
                                    <%# Eval("UnitName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Lengthft")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Lenghtin")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Widthft")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Widthin")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Heightft")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Heightin")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Nos")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Qty")%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("MeasurementBookDetailID")%>'
                                        UniqueKey="SiteCMMeasurementBookDetail_lvCMMeasurementBookDetail_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete C MMeasurement Book Detail?')"
                                        CommandArgument='<%#Eval("MeasurementBookDetailID")%>' UniqueKey="SiteCMMeasurementBookDetail_lvCMMeasurementBookDetail_Delete_key" />
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
                <asp:ObjectDataSource ID="odsCMMeasurementBookDetail" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.CMMeasurementBookDetail_DetailedDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsCMMeasurementBookDetail_Selecting">
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
