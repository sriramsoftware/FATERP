<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 20-Dec-2013, 02:17:52
--%>




<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HREmployeeConfidentialInfo.ascx.cs"
    Inherits="Bay.ERP.Web.UI.HREmployeeConfidentialInfoControl" %>

<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
       
        <div>
           
                <div class="TableRow" style="text-align: left;" runat="server">
                    <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        No of Children&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtNumberofChildren" runat="server" ClientIDMode="Static" CssClass="ktiNumberTextBox"
                            ValidationGroup="HREmployeeConfidentialInfoEntity" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvNumberofChildren" runat="server" ControlToValidate="txtNumberofChildren" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136)" MinimumValue="-2147483648" MaximumValue="2147483647"
                            Type="Integer" ValidationGroup="HREmployeeConfidentialInfoEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Spouse DOB&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtDateofBirth" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="HREmployeeConfidentialInfoEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revDateofBirth" runat="server" ControlToValidate="txtDateofBirth"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="HREmployeeConfidentialInfoEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Anniversary Date&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtAnniversaryDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="HREmployeeConfidentialInfoEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revAnniversaryDate" runat="server" ControlToValidate="txtAnniversaryDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="HREmployeeConfidentialInfoEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                       <asp:HyperLink CssClass="hypTableFormLeble" ID="hypMaritalStatus" runat="server" Text="Marital Status" NavigateUrl="~/MD/MDMaritalStatus.aspx"
                                Target="_blank"></asp:HyperLink>
                       &nbsp;:
                        
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlMaritalStatusID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="HREmployeeConfidentialInfoEntity" Width="234">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Birth Place&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtCityofBirth" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="HREmployeeConfidentialInfoEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                    <asp:HyperLink CssClass="hypTableFormLeble" ID="hypBirthState" runat="server" Text="Birth State" NavigateUrl="~/MD/MDDistrict.aspx"
                                Target="_blank"></asp:HyperLink>
                        &nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlBirthOfStateID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="HREmployeeConfidentialInfoEntity" Width="234">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                     <asp:HyperLink CssClass="hypTableFormLeble" ID="hypBirthCountry" runat="server" Text="Birth Country" NavigateUrl="~/MD/MDCountry.aspx"
                                Target="_blank"></asp:HyperLink>
                        &nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlCountryOfBirthCountryID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="HREmployeeConfidentialInfoEntity" Width="234">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                    <asp:HyperLink CssClass="hypTableFormLeble" ID="hypRegion" runat="server" Text="Region" NavigateUrl="~/MD/MDRegion.aspx"
                                Target="_blank"></asp:HyperLink>
                        &nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlRegionID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="HREmployeeConfidentialInfoEntity" Width="234">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100; display:none;">
                    <div class="TableFormLeble" style="text-align: right;">
                     <asp:HyperLink CssClass="hypTableFormLeble" ID="hypResidenceCountry" runat="server" Text="Residence Country" NavigateUrl="~/MD/MDCountry.aspx"
                                Target="_blank"></asp:HyperLink>
                        &nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlResidenceCountryID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="HREmployeeConfidentialInfoEntity" Width="234">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Personl Tax Id&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtPersonlTaxIdNumber" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="HREmployeeConfidentialInfoEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        National Id&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtNationalIdNumber" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="HREmployeeConfidentialInfoEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                     <asp:HyperLink CssClass="hypTableFormLeble" ID="hypReligion" runat="server" Text="Religion" NavigateUrl="~/MD/MDReligion.aspx"
                                Target="_blank"></asp:HyperLink>
                        &nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlReligionID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="HREmployeeConfidentialInfoEntity" Width="234">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Special Marks&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtBirthMark" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="HREmployeeConfidentialInfoEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                       <asp:HyperLink CssClass="hypTableFormLeble" ID="hypBloodGroup" runat="server" Text="Blood Group" NavigateUrl="~/MD/MDBloodGroup.aspx"
                                Target="_blank"></asp:HyperLink>
                        &nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlBloodGroupID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="HREmployeeConfidentialInfoEntity" Width="234">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Disability Info.&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtDisabilityInformation" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="HREmployeeConfidentialInfoEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        <asp:HyperLink CssClass="hypTableFormLeble" ID="hypGender" runat="server" Text="Gender" NavigateUrl="~/MD/MDGender.aspx"
                                Target="_blank"></asp:HyperLink>
                        &nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlGenderID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="HREmployeeConfidentialInfoEntity" Width="234">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Height&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtHeight" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="HREmployeeConfidentialInfoEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Weight&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtWeight" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="HREmployeeConfidentialInfoEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                    <asp:HyperLink CssClass="hypTableFormLeble" ID="hypNationality" runat="server" Text="Nationality" NavigateUrl="~/MD/MDCountry.aspx"
                                Target="_blank"></asp:HyperLink>
                        &nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlCurrentNationalityCountryID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="HREmployeeConfidentialInfoEntity" Width="234">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Previous Nationality&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlPreviousNationalityCountryID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="HREmployeeConfidentialInfoEntity" Width="234">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Has Passport&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:CheckBox ID="chkHasPassport" runat="server" ClientIDMode="Static" ValidationGroup="HREmployeeConfidentialInfoEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Has Driving Lisence&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:CheckBox ID="chkHasDrivingLisence" runat="server" ClientIDMode="Static" ValidationGroup="HREmployeeConfidentialInfoEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100; display:none;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Is Removed&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:CheckBox ID="chkIsRemoved" runat="server" ClientIDMode="Static" ValidationGroup="HREmployeeConfidentialInfoEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="HREmployeeConfidentialInfoEntity" OnClick="btnSave_Click"
                            runat="server" Text="Add" UniqueKey="HREmployeeConfidentialInfoControl_Submit_key" />
                    </div>
                </div>
                <br />
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
