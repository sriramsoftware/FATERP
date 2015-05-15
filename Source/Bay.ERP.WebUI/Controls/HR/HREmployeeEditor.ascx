<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 28-Dec-2011, 07:18:54
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HREmployeeEditor.ascx.cs"
    Inherits="Bay.ERP.Web.UI.HREmployeeEditorControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
 <Triggers>
        <asp:AsyncPostBackTrigger ControlID="btnClick" EventName="Click" />
    </Triggers>
    <ContentTemplate>
   
        <div>
            <div class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div id="Div1" class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="Label1" EnableViewState="false" runat="server"></asp:Label>
            </div>
        <div style="float:left; width:500px;">
            <div id="Div2" class="TableRow" style="text-align: left;" runat="server">
                    <asp:Label ID="Label2" EnableViewState="false" runat="server"></asp:Label>
                </div>
                <div id="Div3" class="TableRow" style="text-align: left;" runat="server">
                    <asp:Label ID="Label3" EnableViewState="false" runat="server"></asp:Label>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        First Name&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtFirstName">
                            Enter First Name</label>
                        <asp:TextBox ID="txtFirstName" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="CMContractorEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvFirstName" runat="server" ControlToValidate="txtFirstName"
                            ErrorMessage="Please Enter First Name" ValidationGroup="CMContractorEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Middle Name&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtMiddleName" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="CMContractorEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Last Name&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtLastName">
                            Enter Last Name</label>
                        <asp:TextBox ID="txtLastName" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="CMContractorEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvLastName" runat="server" ControlToValidate="txtLastName"
                            ErrorMessage="Please Enter Last Name" ValidationGroup="HRMemberEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Employee Code&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtEmployeeCode">
                            Enter Employee Code</label>
                        <asp:TextBox ID="txtEmployeeCode" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="HREmployeeEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvEmployeeCode" runat="server" ControlToValidate="txtEmployeeCode"
                            ErrorMessage="Please Enter Employee Code" ValidationGroup="HREmployeeEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div> 
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                    <asp:HyperLink CssClass="hypTableFormLeble" ID="hypProject" runat="server" Text="Designation" NavigateUrl="~/HR/HREmployeeDesignation.aspx"
                                Target="_blank"></asp:HyperLink>
                    &nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlDesignationID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="HREmployeeEntity" Width="234">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Employee Job Type&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlEmployeeJobTypeID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="HREmployeeEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvEmployeeJobTypeID" runat="server" ControlToValidate="ddlEmployeeJobTypeID"
                            ErrorMessage="Please Select Employee Job Type" ValidationGroup="HREmployeeEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Confirm Date&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtConfirmDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="HREmployeeEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revConfirmDate" runat="server" ControlToValidate="txtConfirmDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="HREmployeeEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Join Date&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtJoinDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="HREmployeeEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revJoinDate" runat="server" ControlToValidate="txtJoinDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="HREmployeeEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        DOB&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtDOB" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="HREmployeeEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revDOB" runat="server" ControlToValidate="txtDOB"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="HREmployeeEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                    <asp:HyperLink CssClass="hypTableFormLeble" ID="hypBloodGroup" runat="server" Text="Blood Group" NavigateUrl="~/MD/MDBloodGroup.aspx"
                                Target="_blank"></asp:HyperLink>
                        &nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlBloodGroupID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="HREmployeeEntity" Width="234">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Primary Email&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtPrimaryEmail">
                            Enter Primary Email</label>
                        <asp:TextBox ID="txtPrimaryEmail" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="HREmployeeEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvPrimaryEmail" runat="server" ControlToValidate="txtPrimaryEmail"
                            ErrorMessage="Please Enter Primary Email" ValidationGroup="HREmployeeEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revPrimaryEmail" runat="server" ControlToValidate="txtPrimaryEmail" Display="Dynamic"
                            EnableViewState="True" ValidationGroup="HREmployeeEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Secondary Email&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtSecondaryEmail" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="HREmployeeEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revSecondaryEmail" runat="server" ControlToValidate="txtSecondaryEmail" Display="Dynamic"
                            EnableViewState="true" ValidationGroup="HREmployeeEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Initials&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtInitials" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="HREmployeeEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>               
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <asp:Button ID="btnSubmit" ValidationGroup="HREmployeeEntity" OnClick="btnSave_Click"
                            runat="server" Text="Add" UniqueKey="HREmployeeControl_Submit_key" />
                    </div>
                </div>

            </div>
             <div style="width:500px; float:left;">
         <div class="lv-c">
            <asp:ListView ID="lvMemberImage" runat="server" DataSourceID="odsMemberImage">
                <LayoutTemplate>
                    <table class="lv" cellpadding="0" cellspacing="0">
                        <tr runat="server" id="itemPlaceholder">
                        </tr>
                        <tr style="display:none;">
                            <td colspan="100%">
                                <div class="lv-FooterContainer">
                                    <div class="lv-Footer">
                                        <asp:DataPager ID="dpListView" runat="server" PageSize="1">
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
                        <td class="i">
                            <asp:Image ID="imgProduct" Width="225" Height="225" runat="server" ImageUrl='<%# Eval("Path")%>' AlternateText="" />
                        </td>
                    </tr>
                </ItemTemplate>
                <EmptyDataTemplate>
                    <div class="edr">
                        No Picture Available
                    </div>
                </EmptyDataTemplate>
            </asp:ListView>
        </div>
        <asp:ObjectDataSource ID="odsMemberImage" runat="server" SelectMethod="GetPagedData"
            SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
            StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.HREmployeePhotoDataSource"
            SortParameterName="sortExpression" OnSelecting="odsMemberImage_Selecting">
            <SelectParameters>
                <asp:Parameter Name="startRowIndex" Type="Int32" />
                <asp:Parameter Name="pageSize" Type="Int32" />
                <asp:Parameter Name="sortExpression" Type="String" />
                <asp:Parameter Name="filterExpression" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>

             <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Select Photo&nbsp;:
                </div>
                <div class="TableFormContent">
                    <div style="float: left;">
                        <ajaxToolkit:AsyncFileUpload runat="server" ID="afuFiles" CssClass="FileUploadClass"
                            UploaderStyle="Modern" UploadingBackColor="#CCFFFF" Width="230px" ThrobberID="myThrobber"
                            OnClientUploadError="uploadError" OnClientUploadComplete="uploadComplete" />
                          <asp:Button runat="server" ID="btnClick" ClientIDMode="Static" Text="Update grid"
                            Style="display: none" OnClick="btnClick_Click" />
                    </div>
                    <div style="float: left; padding-left: 10px; padding-top: 5px;">
                        <asp:Label runat="server" ID="myThrobber">
                            <asp:Image ID="imgUploading" runat="server" ImageAlign="AbsMiddle" AlternateText="Uploading..."
                                ImageUrl="~/Images/UploadImage/uploading.gif" /></asp:Label>
                    </div>
                    <div style="clear: both;">
                    </div>
                </div>
            </div>
            <br />

    </div>
    <div style="clear:both;"></div>
        </div>
          <script type="text/javascript">
              function uploadError(sender, args) {
              }
              function uploadComplete(sender, args) {
                  var btnClick = document.getElementById("btnClick");
                  btnClick.click();
              }
        </script>
    </ContentTemplate>
</asp:UpdatePanel>
