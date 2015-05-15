<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 16-Apr-2012, 04:09:50
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PRMSupplierItemMapAdd.ascx.cs"
    Inherits="Bay.ERP.Web.UI.PRMSupplierItemMapAddControl" %>

     <script language="javascript" type="text/javascript">
         function BindEvents() {
             $(document).ready(function () {
                 $("#txtActualPrice").keyup(function () {
                     var discountedAmount = $("#txtActualPrice").val() * ($("#txtDiscountPercentage").val() / 100);
                     var NetPrice = $("#txtActualPrice").val() - discountedAmount;
                     $("#txtPrice").val(NetPrice);
                 });
                   $("#txtDiscountPercentage").keyup(function () {
                         $("#txtActualPrice").keyup();  
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
            <div id="Div1" class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div style="float: left; width: 400px;">
                <div class="contentSubTittle">
                    Brand Item Map Tree</div>
                <div style="float: left; width: 275px;">
                    <kti:BayBrandItemMapTreeView ID="treeBrandItemMap" runat="server" ShowCheckBoxesInAllNodes="false"
                        OnSelectedNodeChanged="treeBrandItemMap_SelectedNodeChanged">
                    </kti:BayBrandItemMapTreeView>
                </div>
            </div>
            <div class="contentSeperator">
            </div>
            <div style="float: left; width: 600px;">
                <div id="divUpdatePanel" runat="server" visible="false">
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: left;">
                        <asp:HyperLink CssClass="hypTableFormLeble" ID="hypOrigionRegion" runat="server"
                                Text="Origin Region" NavigateUrl="~/MD/MDRegion.aspx" Target="_blank"></asp:HyperLink>
                            &nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:DropDownList ID="ddlOriginRegionID" CssClass="ktiSelect" ClientIDMode="Static"
                                OnSelectedIndexChanged="ddlOriginRegionID_SelectedIndexChanged" AutoPostBack="true"
                                runat="server" ValidationGroup="PRMSupplierItemMapEntity" Width="236">
                            </asp:DropDownList>
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvOriginRegionID" runat="server" ControlToValidate="ddlOriginRegionID"
                                ErrorMessage="Please Select Origin Region" ValidationGroup="PRMSupplierItemMapEntity"
                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: left;">
                        <asp:HyperLink CssClass="hypTableFormLeble" ID="hypOriginCountry" runat="server"
                                Text="Origin Country" NavigateUrl="~/MD/MDCountry.aspx" Target="_blank"></asp:HyperLink>
                            &nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:DropDownList ID="ddlOriginCountryID" CssClass="ktiSelect" ClientIDMode="Static"
                                runat="server" ValidationGroup="PRMSupplierItemMapEntity" Width="236">
                            </asp:DropDownList>
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvOriginCountryID" runat="server" ControlToValidate="ddlOriginCountryID"
                                ErrorMessage="Please Select Origin Country" ValidationGroup="PRMSupplierItemMapEntity"
                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: left;">
                        <asp:Label ID="lblModel" runat="server" Text="Model"></asp:Label>
                            &nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:TextBox ID="txtModel" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                                ValidationGroup="PRMSupplierItemMapEntity" Width="230" />
                        </div>
                        <div class="TableFormValidatorContent">
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: left;">
                            Warranty Period&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:TextBox ID="txtWarrantyPeriod" runat="server" ClientIDMode="Static" CssClass="ktiNumberTextBox"
                                ValidationGroup="PRMSupplierItemMapEntity" Width="210" />
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RangeValidator ID="rvWarrantyPeriod" runat="server" ControlToValidate="txtWarrantyPeriod"
                                Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136)"
                                MinimumValue="-2147483648" MaximumValue="2147483647" Type="Integer" ValidationGroup="PRMSupplierItemMapEntity"></asp:RangeValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: left;">
                            Entry Date&nbsp;:
                        </div>
                        <div class="TableFormContent waterMarkContainer">
                            <label class="watermarkLabel" for="txtEntryDate">
                                Enter Entry Date</label>
                            <asp:TextBox ID="txtEntryDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                                ValidationGroup="PRMSupplierItemMapEntity" Width="230" />
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="rfvEntryDate" runat="server" ControlToValidate="txtEntryDate"
                                ErrorMessage="Please Enter Entry Date" ValidationGroup="PRMSupplierItemMapEntity"
                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="revEntryDate" runat="server" ControlToValidate="txtEntryDate"
                                Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                                ValidationGroup="PRMSupplierItemMapEntity"></asp:RegularExpressionValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: left;">
                            Price&nbsp;:
                        </div>
                        <div class="TableFormContent waterMarkContainer">
                            <label class="watermarkLabel" for="txtActualPrice">
                                Enter Actual Price</label>
                            <asp:TextBox ID="txtActualPrice" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                                runat="server" ValidationGroup="PRMSupplierItemMapEntity" Width="210" />
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="rfvActualPrice" runat="server" ControlToValidate="txtActualPrice"
                                ErrorMessage="Please Enter Actual Price" ValidationGroup="PRMSupplierItemMapEntity"
                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:RangeValidator ID="rvActualPrice" runat="server" ControlToValidate="txtActualPrice"
                                Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                Type="Double" ValidationGroup="PRMSupplierItemMapEntity"></asp:RangeValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: left;">
                            Discount Percentage&nbsp;:
                        </div>
                        <div class="TableFormContent waterMarkContainer">
                            <label class="watermarkLabel" for="txtDiscountPercentage">
                                Enter Discount Percentage</label>
                            <asp:TextBox ID="txtDiscountPercentage" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                                runat="server" ValidationGroup="PRMSupplierItemMapEntity" Width="210" />
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="rfvDiscountPercentage" runat="server" ControlToValidate="txtDiscountPercentage"
                                ErrorMessage="Please Enter Discount Percentage" ValidationGroup="PRMSupplierItemMapEntity"
                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:RangeValidator ID="rvDiscountPercentage" runat="server" ControlToValidate="txtDiscountPercentage"
                                Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                Type="Double" ValidationGroup="PRMSupplierItemMapEntity"></asp:RangeValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: left;">
                            Net Price&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:TextBox ID="txtPrice" CssClass="ktiDecimalTextBox" ClientIDMode="Static" runat="server" ReadOnly="true" style="font-weight:bold;"
                                ValidationGroup="PRMSupplierItemMapEntity" Width="210" />
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="rfvPrice" runat="server" ControlToValidate="txtPrice"
                                ValidationGroup="PRMSupplierItemMapEntity"
                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:RangeValidator ID="rvPrice" runat="server" ControlToValidate="txtPrice" Display="Dynamic"
                                EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335"
                                MaximumValue="79228162514264337593543950335" Type="Double" ValidationGroup="PRMSupplierItemMapEntity"></asp:RangeValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100; display: none;">
                        <div class="TableFormLeble" style="text-align: left;">
                            Is Removed&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:CheckBox ID="chkIsRemoved" runat="server" ClientIDMode="Static" ValidationGroup="PRMSupplierItemMapEntity" />
                        </div>
                        <div class="TableFormValidatorContent">
                        </div>
                    </div>
                    <div class="TableRow" style="text-align: center;">
                        <div class="TableFormLeble">
                            &nbsp;</div>
                        <div class="TableFormContent">
                            <kti:SecureButton ID="btnSubmit" ValidationGroup="PRMSupplierItemMapEntity" OnClick="btnSave_Click"
                                runat="server" Text="Add" UniqueKey="PRMSupplierItemMapAddControl_Submit_key" />
                            <kti:SecureButton ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear"
                                UniqueKey="PRMSupplierItemMapAddControl_Clear_key" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
