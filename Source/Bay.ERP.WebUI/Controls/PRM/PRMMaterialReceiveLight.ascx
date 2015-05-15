<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 18-Nov-2012, 09:57:55
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PRMMaterialReceiveLight.ascx.cs"
    Inherits="Bay.ERP.Web.UI.PRMMaterialReceiveLightControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Project&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlProjectID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                        ValidationGroup="PRMMaterialReceiveEntity" Width="236">
                    </asp:DropDownList>
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvProjectID" runat="server" ControlToValidate="ddlProjectID"
                        ErrorMessage="Please Select Project" ValidationGroup="PRMMaterialReceiveEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Vendor&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlSupplierID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                        ValidationGroup="PRMMaterialReceiveEntity" Width="236">
                    </asp:DropDownList>
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvSupplierID" runat="server" ControlToValidate="ddlSupplierID"
                        ErrorMessage="Please Select Supplier" ValidationGroup="PRMMaterialReceiveEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
             <div class="TableFormLeble" style="text-align: left;">
                    Requisition&nbsp;:
                </div>
                <div class="TableFormContent waterMarkContainer">
                    <label class="watermarkLabel" for="txtRequisition">
                        Enter Requisition No</label>
                    <asp:TextBox ID="txtRequisition" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                        ValidationGroup="PRMMaterialReceiveEntity" Width="230" />
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvRequisition" runat="server" ControlToValidate="txtRequisition"
                        ErrorMessage="Please Enter Requisition" ValidationGroup="PRMMaterialReceiveEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Work Order&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlWorkOrderID" CssClass="ktiSelect" ClientIDMode="Static"
                        runat="server" ValidationGroup="PRMMaterialReceiveEntity" Width="236">
                    </asp:DropDownList>
                </div>
                <div class="TableFormValidatorContent">
                
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    MRR No&nbsp;:
                </div>
                <div class="TableFormContent waterMarkContainer">
                    <label class="watermarkLabel" for="txtMRRNo">
                        Enter MRR No</label>
                    <asp:TextBox ID="txtMRRNo" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                        ValidationGroup="PRMMaterialReceiveEntity" Width="230" />
                    <span class="RequiredField">Leave Blank For Auto Number</span>
                </div>
                <div class="TableFormValidatorContent">
                    
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    MRR Date&nbsp;:
                </div>
                <div class="TableFormContent waterMarkContainer">
                    <label class="watermarkLabel" for="txtMRRDate">
                        Enter MRR Date</label>
                    <asp:TextBox ID="txtMRRDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                        ValidationGroup="PRMMaterialReceiveEntity" Width="230" />
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvMRRDate" runat="server" ControlToValidate="txtMRRDate"
                        ErrorMessage="Please Enter M RRDate" ValidationGroup="PRMMaterialReceiveEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revMRRDate" runat="server" ControlToValidate="txtMRRDate"
                        Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                        ValidationGroup="PRMMaterialReceiveEntity"></asp:RegularExpressionValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Remarks&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                        ID="txtRemarks" runat="server" ValidationGroup="PRMMaterialReceiveEntity" />
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Item&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlRequisitionItemID" CssClass="ktiSelect" ClientIDMode="Static" AutoPostBack="true" OnSelectedIndexChanged="ddlRequisitionItemID_SelectedIndexChanged"
                        runat="server" ValidationGroup="PRMMaterialReceiveEntity" Width="236">
                    </asp:DropDownList>
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvRequisitionItemID" runat="server" ControlToValidate="ddlRequisitionItemID"
                        ErrorMessage="Please Select Requisition Item" ValidationGroup="PRMMaterialReceiveEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Brand&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlBrandID" CssClass="ktiSelect" ClientIDMode="Static" ToolTip="Please Select The Brand To Find The Item Price! e.g. BSRM"
                            runat="server" ValidationGroup="PRMMaterialReceiveEntity" Width="236">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvBrandID" runat="server" ControlToValidate="ddlBrandID" 
                            ErrorMessage="Please Select Brand" ValidationGroup="PRMMaterialReceiveEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Region&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlRegionID" CssClass="ktiSelect" ClientIDMode="Static" AutoPostBack="true" OnSelectedIndexChanged="ddlRegionID_SelectedIndexChanged" ToolTip="Please Select The Region! e.g. Asian"
                            runat="server" ValidationGroup="PRMMaterialReceiveEntity" Width="236">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvRegionID" runat="server" ControlToValidate="ddlRegionID"
                            ErrorMessage="Please Select Region" ValidationGroup="PRMMaterialReceiveEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Country&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlCountryID" CssClass="ktiSelect" ClientIDMode="Static" ToolTip="Please Select Country! e.g. Bangladesh"
                            runat="server" ValidationGroup="PRMMaterialReceiveEntity" Width="236">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvCountryID" runat="server" ControlToValidate="ddlCountryID"
                            ErrorMessage="Please Select Country" ValidationGroup="PRMMaterialReceiveEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
            <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: left;">
                           Price&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:TextBox ID="txtPrice" CssClass="ktiDecimalTextBox" ClientIDMode="Static" runat="server" style="font-weight:bold;"
                                ValidationGroup="PRMMaterialReceiveEntity" Width="210" />
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="rfvPrice" runat="server" ControlToValidate="txtPrice"
                                ValidationGroup="PRMMaterialReceiveEntity"
                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:RangeValidator ID="rvPrice" runat="server" ControlToValidate="txtPrice" Display="Dynamic"
                                EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335"
                                MaximumValue="79228162514264337593543950335" Type="Double" ValidationGroup="PRMMaterialReceiveEntity"></asp:RangeValidator>
                        </div>
             </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Receive Date&nbsp;:
                </div>
                <div class="TableFormContent waterMarkContainer">
                    <label class="watermarkLabel" for="txtReceiveDate">
                        Enter Receive Date</label>
                    <asp:TextBox ID="txtReceiveDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                        ValidationGroup="PRMMaterialReceiveEntity" Width="230" />
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvReceiveDate" runat="server" ControlToValidate="txtReceiveDate"
                        ErrorMessage="Please Enter Receive Date" ValidationGroup="PRMMaterialReceiveEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revReceiveDate" runat="server" ControlToValidate="txtReceiveDate"
                        Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                        ValidationGroup="PRMMaterialReceiveEntity"></asp:RegularExpressionValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Receive Qty&nbsp;:
                </div>
                <div class="TableFormContent waterMarkContainer">
                    <label class="watermarkLabel" for="txtReceiveQty">
                        Enter Receive Qty</label>
                    <asp:TextBox ID="txtReceiveQty" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                        runat="server" ValidationGroup="PRMMaterialReceiveEntity" Width="210" />
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvReceiveQty" runat="server" ControlToValidate="txtReceiveQty"
                        ErrorMessage="Please Enter Receive Qty" ValidationGroup="PRMMaterialReceiveEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="rvReceiveQty" runat="server" ControlToValidate="txtReceiveQty"
                        Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                        MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                        Type="Double" ValidationGroup="PRMMaterialReceiveEntity"></asp:RangeValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Challan No&nbsp;:
                </div>
                <div class="TableFormContent waterMarkContainer">
                    <label class="watermarkLabel" for="txtChallanNo">
                        Enter Challan No</label>
                    <asp:TextBox ID="txtChallanNo" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                        ValidationGroup="PRMMaterialReceiveEntity" Width="230" />
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvChallanNo" runat="server" ControlToValidate="txtChallanNo"
                        ErrorMessage="Please Enter Challan No" ValidationGroup="PRMMaterialReceiveEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="TableRow" style="text-align: center;">
                <div class="TableFormLeble">
                    &nbsp;</div>
                <div class="TableFormContent">
                    <kti:SecureButton ID="btnSubmit" ValidationGroup="PRMMaterialReceiveEntity" OnClick="btnSave_Click"
                        runat="server" Text="Add Item To MRR & Requisition" UniqueKey="PRMMaterialReceiveLightControl_Submit_key" />
                    <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click" runat="server"
                        Text="Create New" UniqueKey="PRMMaterialReceiveLightControl_AddNew_key" />
                </div>
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
