<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 20-Dec-2013, 02:17:52
--%>




<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HREmployeeJobDescription.ascx.cs"
    Inherits="Bay.ERP.Web.UI.HREmployeeJobDescriptionControl" %>

<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
          
                <div class="TableRow" style="text-align: left;" runat="server">
                    <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Description&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtDescription">
                            Enter Description</label>
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="776" Height="442" ClientIDMode="Static"
                            ID="txtDescription" runat="server" ValidationGroup="HREmployeeJobDescriptionEntity" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvDescription" runat="server" ControlToValidate="txtDescription"
                            ErrorMessage="Please Enter Description" ValidationGroup="HREmployeeJobDescriptionEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Remarks&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="776" Height="140" ClientIDMode="Static"
                            ID="txtRemarks" runat="server" ValidationGroup="HREmployeeJobDescriptionEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="HREmployeeJobDescriptionEntity" OnClick="btnSave_Click"
                            runat="server" Text="Add" UniqueKey="HREmployeeJobDescriptionControl_Submit_key" />
                    </div>
                </div>
                <br />
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
