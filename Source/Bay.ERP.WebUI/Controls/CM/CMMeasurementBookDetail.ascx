<%--
 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 04-Oct-2012, 01:19:13
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CMMeasurementBookDetail.ascx.cs"
    Inherits="Bay.ERP.Web.UI.CMMeasurementBookDetailControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div class="TableRow">
                <div style="text-align: left; padding-left: 840px;">
                    <b>Bill No</b>&nbsp;: &nbsp; &nbsp;<asp:Label ID="lblBillNo" Font-Bold="true" runat="server"></asp:Label>
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
            </div>
            <br />
              <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Project Floor&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlProjectFloorID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="CMMeasurementBookEntity" Width="234">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <br />
            <div class="listContentTitle">
                Measurement Book Detail List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvCMMeasurementBookDetail" runat="server" DataSourceID="odsCMMeasurementBookDetail"
                        OnItemDataBound="lvCMMeasurementBookDetail_ItemDataBound" OnItemCreated="lvCMMeasurementBookDetail_ItemCreated"
                        InsertItemPosition="LastItem" OnItemCommand="lvCMMeasurementBookDetail_ItemCommand">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi" style="display: none;">
                                        Measurement Book
                                    </td>
                                    <td class="hi">
                                        Description
                                    </td>
                                    <td class="hi" style="width: 70px;">
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
                                <td class="i" style="display: none;">
                                    <asp:Label ID="lbllstMeasurementBookID" runat="server" Text='<%# Eval("MeasurementBookID")%>'></asp:Label>
                                </td>
                                <td class="i">
                                    <div class="TableFormValidatorContent">
                                        <asp:TextBox ID="txtlstDescription" CssClass="ktiTextBoxListview" runat="server"
                                            Text='<%# Eval("Description")%>' TextMode="MultiLine" Enabled="false"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="rfvlstDescription" runat="server" ControlToValidate="txtlstDescription"
                                            ErrorMessage="Enter Description" ValidationGroup="CMMeasurementBookDetailEntity"
                                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                    </div>
                                </td>
                                <td class="i">
                                    <div class="TableFormValidatorContent">
                                        <asp:DropDownList ID="ddlUnitIDLV" runat="server" Enabled="false">
                                        </asp:DropDownList>
                                        <asp:RequiredFieldValidator ID="rfvUnitIDLV" runat="server" ControlToValidate="ddlUnitIDLV"
                                            ErrorMessage="Please Select Unit" ValidationGroup="CMMeasurementBookDetailEntity"
                                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                    </div>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtlstLengthft" CssClass="ktiTextBoxListview" Text='<%# Eval("Lengthft")%>'
                                        runat="server" Enabled="false"></asp:TextBox>
                                    <div class="TableFormValidatorContent">
                                        <asp:RangeValidator ID="rvLengthft" runat="server" ControlToValidate="txtlstLengthft"
                                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number"
                                            MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                            Type="Double" ValidationGroup="CMMeasurementBookDetailEntity"></asp:RangeValidator>
                                    </div>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtlstLengthin" CssClass="ktiTextBoxListview" Text='<%# Eval("Lenghtin")%>'
                                        runat="server" Enabled="false"></asp:TextBox>
                                    <div class="TableFormValidatorContent">
                                        <asp:RangeValidator ID="rvLenghtin" runat="server" ControlToValidate="txtlstLengthin"
                                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number"
                                            MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                            Type="Double" ValidationGroup="CMMeasurementBookDetailEntity"></asp:RangeValidator>
                                    </div>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtlstWidthft" CssClass="ktiTextBoxListview" Text='<%# Eval("Widthft")%>'
                                        runat="server" Enabled="false"></asp:TextBox>
                                    <div class="TableFormValidatorContent">
                                        <asp:RangeValidator ID="rvWidthft" runat="server" ControlToValidate="txtlstWidthft"
                                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number"
                                            MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                            Type="Double" ValidationGroup="CMMeasurementBookDetailEntity"></asp:RangeValidator>
                                    </div>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtlstWidthin" CssClass="ktiTextBoxListview" Text='<%# Eval("Widthin")%>'
                                        runat="server" Enabled="false"></asp:TextBox>
                                    <div class="TableFormValidatorContent">
                                        <asp:RangeValidator ID="rvWidthin" runat="server" ControlToValidate="txtlstWidthin"
                                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number"
                                            MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                            Type="Double" ValidationGroup="CMMeasurementBookDetailEntity"></asp:RangeValidator>
                                    </div>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtlstHeightft" CssClass="ktiTextBoxListview" Text='<%# Eval("Heightft")%>'
                                        runat="server" Enabled="false"></asp:TextBox>
                                    <div class="TableFormValidatorContent">
                                        <asp:RangeValidator ID="rvHeightft" runat="server" ControlToValidate="txtlstHeightft"
                                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number"
                                            MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                            Type="Double" ValidationGroup="CMMeasurementBookDetailEntity"></asp:RangeValidator>
                                    </div>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtlstHeightin" CssClass="ktiTextBoxListview" Text='<%# Eval("Heightin")%>'
                                        runat="server" Enabled="false"></asp:TextBox>
                                    <div class="TableFormValidatorContent">
                                        <asp:RangeValidator ID="rvHeightin" runat="server" ControlToValidate="txtlstHeightin"
                                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number"
                                            MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                            Type="Double" ValidationGroup="CMMeasurementBookDetailEntity"></asp:RangeValidator>
                                    </div>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtlstNos" CssClass="ktiTextBoxListview" Text='<%# Eval("Nos")%>'
                                        runat="server" Enabled="false"></asp:TextBox>
                                    <div class="TableFormValidatorContent">
                                        <asp:RequiredFieldValidator ID="rfvNos" runat="server" ControlToValidate="txtlstNos"
                                            ErrorMessage="Please Enter Nos" ValidationGroup="CMMeasurementBookDetailEntity"
                                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                        <asp:RangeValidator ID="rvNos" runat="server" ControlToValidate="txtlstNos" Display="Dynamic"
                                            EnableViewState="False" ErrorMessage="Enter Number" MinimumValue="-79228162514264337593543950335"
                                            MaximumValue="79228162514264337593543950335" Type="Double" ValidationGroup="CMMeasurementBookDetailEntity"></asp:RangeValidator>
                                    </div>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtlstQty" CssClass="ktiTextBoxListview" Text='<%#Decimal.Round((Decimal)Eval("Qty"),2)%>'
                                        runat="server" Enabled="false"></asp:TextBox>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("MeasurementBookDetailID")%>'
                                        UniqueKey="CMMeasurementBookDetail_lvCMMeasurementBookDetail_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete C MMeasurement Book Detail?')"
                                        CommandArgument='<%#Eval("MeasurementBookDetailID")%>' UniqueKey="CMMeasurementBookDetail_lvCMMeasurementBookDetail_Delete_key" />
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
                                <td class="i" style="display: none;">
                                    <asp:Label ID="lbllstMeasurementBookID" runat="server" Text='<%# Eval("MeasurementBookID")%>'></asp:Label>
                                </td>
                                <td class="i">
                                    <div class="TableFormValidatorContent">
                                        <asp:TextBox ID="txtlstDescription" CssClass="ktiTextBoxListview" runat="server"
                                            Text='<%# Eval("Description")%>' TextMode="MultiLine" Enabled="false"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="rfvlstDescription" runat="server" ControlToValidate="txtlstDescription"
                                            ErrorMessage="Enter Description" ValidationGroup="CMMeasurementBookDetailEntity"
                                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                    </div>
                                </td>
                                <td class="i">
                                    <div class="TableFormValidatorContent">
                                        <asp:DropDownList ID="ddlUnitIDLV" runat="server" Enabled="false">
                                        </asp:DropDownList>
                                        <asp:RequiredFieldValidator ID="rfvUnitIDLV" runat="server" ControlToValidate="ddlUnitIDLV"
                                            ErrorMessage="Please Select Unit" ValidationGroup="CMMeasurementBookDetailEntity"
                                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                    </div>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtlstLengthft" CssClass="ktiTextBoxListview" Text='<%# Eval("Lengthft")%>'
                                        runat="server" Enabled="false"></asp:TextBox>
                                    <div class="TableFormValidatorContent">
                                        <asp:RangeValidator ID="rvLengthft" runat="server" ControlToValidate="txtlstLengthft"
                                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number"
                                            MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                            Type="Double" ValidationGroup="CMMeasurementBookDetailEntity"></asp:RangeValidator>
                                    </div>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtlstLengthin" CssClass="ktiTextBoxListview" Text='<%# Eval("Lenghtin")%>'
                                        runat="server" Enabled="false"></asp:TextBox>
                                    <div class="TableFormValidatorContent">
                                        <asp:RangeValidator ID="rvLenghtin" runat="server" ControlToValidate="txtlstLengthin"
                                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number"
                                            MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                            Type="Double" ValidationGroup="CMMeasurementBookDetailEntity"></asp:RangeValidator>
                                    </div>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtlstWidthft" CssClass="ktiTextBoxListview" Text='<%# Eval("Widthft")%>'
                                        runat="server" Enabled="false"></asp:TextBox>
                                    <div class="TableFormValidatorContent">
                                        <asp:RangeValidator ID="rvWidthft" runat="server" ControlToValidate="txtlstWidthft"
                                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number"
                                            MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                            Type="Double" ValidationGroup="CMMeasurementBookDetailEntity"></asp:RangeValidator>
                                    </div>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtlstWidthin" CssClass="ktiTextBoxListview" Text='<%# Eval("Widthin")%>'
                                        runat="server" Enabled="false"></asp:TextBox>
                                    <div class="TableFormValidatorContent">
                                        <asp:RangeValidator ID="rvWidthin" runat="server" ControlToValidate="txtlstWidthin"
                                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number"
                                            MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                            Type="Double" ValidationGroup="CMMeasurementBookDetailEntity"></asp:RangeValidator>
                                    </div>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtlstHeightft" CssClass="ktiTextBoxListview" Text='<%# Eval("Heightft")%>'
                                        runat="server" Enabled="false"></asp:TextBox>
                                    <div class="TableFormValidatorContent">
                                        <asp:RangeValidator ID="rvHeightft" runat="server" ControlToValidate="txtlstHeightft"
                                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number"
                                            MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                            Type="Double" ValidationGroup="CMMeasurementBookDetailEntity"></asp:RangeValidator>
                                    </div>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtlstHeightin" CssClass="ktiTextBoxListview" Text='<%# Eval("Heightin")%>'
                                        runat="server" Enabled="false"></asp:TextBox>
                                    <div class="TableFormValidatorContent">
                                        <asp:RangeValidator ID="rvHeightin" runat="server" ControlToValidate="txtlstHeightin"
                                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number"
                                            MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                            Type="Double" ValidationGroup="CMMeasurementBookDetailEntity"></asp:RangeValidator>
                                    </div>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtlstNos" CssClass="ktiTextBoxListview" Text='<%# Eval("Nos")%>'
                                        runat="server" Enabled="false"></asp:TextBox>
                                    <div class="TableFormValidatorContent">
                                        <asp:RequiredFieldValidator ID="rfvNos" runat="server" ControlToValidate="txtlstNos"
                                            ErrorMessage="Please Enter Nos" ValidationGroup="CMMeasurementBookDetailEntity"
                                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                        <asp:RangeValidator ID="rvNos" runat="server" ControlToValidate="txtlstNos" Display="Dynamic"
                                            EnableViewState="False" ErrorMessage="Enter Number" MinimumValue="-79228162514264337593543950335"
                                            MaximumValue="79228162514264337593543950335" Type="Double" ValidationGroup="CMMeasurementBookDetailEntity"></asp:RangeValidator>
                                    </div>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtlstQty" CssClass="ktiTextBoxListview" Text='<%# Decimal.Round((Decimal)Eval("Qty"),2)%>'
                                        runat="server" Enabled="false"></asp:TextBox>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("MeasurementBookDetailID")%>'
                                        UniqueKey="CMMeasurementBookDetail_lvCMMeasurementBookDetail_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete C MMeasurement Book Detail?')"
                                        CommandArgument='<%#Eval("MeasurementBookDetailID")%>' UniqueKey="CMMeasurementBookDetail_lvCMMeasurementBookDetail_Delete_key" />
                                </td>
                                <td class="rp">
                                    &nbsp;
                                </td>
                                <td class="rpb">
                                    &nbsp;
                                </td>
                            </tr>
                        </AlternatingItemTemplate>
                        <InsertItemTemplate>
                            <tr class="ar">
                                <td class="rp">
                                    &nbsp;
                                </td>
                                <td class="i">
                                    <div class="TableFormValidatorContent">
                                        <asp:TextBox ID="txtDescriptionLV" runat="server" CssClass="ktiTextBoxListview" Text='<%# Eval("Description")%>'
                                            TextMode="MultiLine" />
                                        <asp:RequiredFieldValidator ID="rfvDescriptionLV" runat="server" ControlToValidate="txtDescriptionLV"
                                            ErrorMessage="Enter Description" ValidationGroup="CMMeasurementBookDetailLVEntity"
                                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                    </div>
                                </td>
                                <td class="i">
                                    <div class="TableFormContent">
                                        <asp:DropDownList ID="ddlUnitIDInsert" ClientIDMode="Static" runat="server" ValidationGroup="CMMeasurementBookDetailLVEntity">
                                        </asp:DropDownList>
                                        <span class="RequiredField">*</span>
                                    </div>
                                    <div class="TableFormValidatorContent">
                                        <asp:RequiredFieldValidator ID="rfvUnitIDInsert" runat="server" ControlToValidate="ddlUnitIDInsert"
                                            ErrorMessage="Please Select Unit" ValidationGroup="CMMeasurementBookDetailLVEntity"
                                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                    </div>
                                </td>
                                <td class="i">
                                    <div class="TableFormValidatorContent">
                                        <asp:TextBox ID="txtLengthftLV" runat="server" CssClass="ktiTextBoxListview" Text='<%# Eval("Lengthft")%>' />
                                        <asp:RangeValidator ID="rvLengthftLV" runat="server" ControlToValidate="txtLengthftLV"
                                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number" MinimumValue="-79228162514264337593543950335"
                                            MaximumValue="79228162514264337593543950335" Type="Double" ValidationGroup="CMMeasurementBookDetailLVEntity"></asp:RangeValidator>
                                    </div>
                                </td>
                                <td class="i">
                                    <div class="TableFormValidatorContent">
                                        <asp:TextBox ID="txtLenghtinLV" runat="server" CssClass="ktiTextBoxListview" Text='<%# Eval("Lenghtin")%>' />
                                        <asp:RangeValidator ID="rvtxtLenghtinLV" runat="server" ControlToValidate="txtLenghtinLV"
                                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number" MinimumValue="-79228162514264337593543950335"
                                            MaximumValue="79228162514264337593543950335" Type="Double" ValidationGroup="CMMeasurementBookDetailLVEntity"></asp:RangeValidator>
                                    </div>
                                </td>
                                <td class="i">
                                    <div class="TableFormValidatorContent">
                                        <asp:TextBox ID="txtWidthftLV" runat="server" CssClass="ktiTextBoxListview" Text='<%# Eval("Widthft")%>' />
                                        <asp:RangeValidator ID="rvtxtWidthftLV" runat="server" ControlToValidate="txtWidthftLV"
                                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number" MinimumValue="-79228162514264337593543950335"
                                            MaximumValue="79228162514264337593543950335" Type="Double" ValidationGroup="CMMeasurementBookDetailLVEntity"></asp:RangeValidator>
                                    </div>
                                </td>
                                <td class="i">
                                    <div class="TableFormValidatorContent">
                                        <asp:TextBox ID="txtWidthinLV" runat="server" CssClass="ktiTextBoxListview" Text='<%# Eval("Widthin")%>' />
                                        <asp:RangeValidator ID="rvtxtWidthinLV" runat="server" ControlToValidate="txtWidthinLV"
                                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number" MinimumValue="-79228162514264337593543950335"
                                            MaximumValue="79228162514264337593543950335" Type="Double" ValidationGroup="CMMeasurementBookDetailLVEntity"></asp:RangeValidator>
                                    </div>
                                </td>
                                <td class="i">
                                    <div class="TableFormValidatorContent">
                                        <asp:TextBox ID="txtHeightftLV" runat="server" CssClass="ktiTextBoxListview" Text='<%# Eval("Heightft")%>' />
                                        <asp:RangeValidator ID="rvtxtHeightftLV" runat="server" ControlToValidate="txtHeightftLV"
                                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number" MinimumValue="-79228162514264337593543950335"
                                            MaximumValue="79228162514264337593543950335" Type="Double" ValidationGroup="CMMeasurementBookDetailLVEntity"></asp:RangeValidator>
                                    </div>
                                </td>
                                <td class="i">
                                    <div class="TableFormValidatorContent">
                                        <asp:TextBox ID="txtHeightinLV" runat="server" CssClass="ktiTextBoxListview" Text='<%# Eval("Heightin")%>' />
                                        <asp:RangeValidator ID="rvtxtHeightinLV" runat="server" ControlToValidate="txtHeightinLV"
                                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number" MinimumValue="-79228162514264337593543950335"
                                            MaximumValue="79228162514264337593543950335" Type="Double" ValidationGroup="CMMeasurementBookDetailLVEntity"></asp:RangeValidator>
                                    </div>
                                </td>
                                <td class="i">
                                    <div class="TableFormValidatorContent">
                                        <asp:TextBox ID="txtNosLV" runat="server" CssClass="ktiTextBoxListview" Text='<%# Eval("Nos")%>' />
                                        <asp:RequiredFieldValidator ID="rfvtxtNosLV" runat="server" ControlToValidate="txtNosLV"
                                            ErrorMessage="Please Enter Nos" ValidationGroup="CMMeasurementBookDetailLVEntity"
                                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                        <asp:RangeValidator ID="rvNosLV" runat="server" ControlToValidate="txtNosLV" Display="Dynamic"
                                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335"
                                            MaximumValue="79228162514264337593543950335" Type="Double" ValidationGroup="CMMeasurementBookDetailLVEntity"></asp:RangeValidator>
                                    </div>
                                </td>
                                <td class="i">
                                   <%-- <asp:TextBox ID="txtQtyLV" runat="server" CssClass="ktiTextBoxListview" Text='<%# Eval("Qty")%>'
                                        Enabled="false" />--%>
                                </td>
                                <td class="i">
                                    <asp:LinkButton ID="lnkBtnInsert" runat="server" CssClass="CommonButtonLink"
                                        ValidationGroup="CMMeasurementBookDetailLVEntity" Text="Insert" CommandName="InsertItem"
                                        UniqueKey="CMMeasurementBookDetail_lvCMMeasurementBookDetail_Insert_key" />
                                </td>
                                <td class="i">
                                </td>
                                <td class="rp">
                                    &nbsp;
                                </td>
                                <td class="rpb">
                                    &nbsp;
                                </td>
                            </tr>
                        </InsertItemTemplate>
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
            <div class="TableRow" style="text-align: center;">
                <div class="TableFormLeble">
                    <kti:SecureButton ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update All" ValidationGroup="CMMeasurementBookDetailEntity"
                        UniqueKey="CMMeasurementBookDetailControl_Submit_key" />
                </div>
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
