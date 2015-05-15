<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 28-Dec-2011, 07:18:54
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="OTDailyLogDatewiseIndividual.ascx.cs"
    Inherits="Bay.ERP.Web.UI.OTDailyLogDatewiseIndividualControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div id="Div1" class="TableRow" style="text-align: left;" runat="server">
            <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
        </div>
        <div>
         <div style="float: left; width: 674px;">
          <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Employee&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlEmployeeID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="OTIssueEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvSupervisorEmployeeID" runat="server" ControlToValidate="ddlEmployeeID"
                            ErrorMessage="Please Select Employee" ValidationGroup="OTIssueEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
         <div id="dvselection" runat="server">
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: left;">
                            Start Date&nbsp;:
                        </div>
                        <div class="TableFormContent waterMarkContainer">
                            <label class="watermarkLabel" for="txtStartDate">
                                Enter Start Date</label>
                            <asp:TextBox ID="txtStartDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                                ValidationGroup="ACRegisterEntity" Width="230" />
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtStartDate"
                        ErrorMessage="Please Enter Start Date" ValidationGroup="ACRegisterEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtStartDate"
                        Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                        ValidationGroup="ACRegisterEntity"></asp:RegularExpressionValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: left;">
                            End Date&nbsp;:
                        </div>
                        <div class="TableFormContent waterMarkContainer">
                            <label class="watermarkLabel" for="txtEndDate">
                                Enter End Date</label>
                            <asp:TextBox ID="txtEndDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                                ValidationGroup="ACRegisterEntity" Width="230" />
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtEndDate"
                        ErrorMessage="Please Enter End Date" ValidationGroup="ACRegisterEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtEndDate"
                        Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                        ValidationGroup="ACRegisterEntity"></asp:RegularExpressionValidator>
                        </div>
                    </div>
                     <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <asp:Button ID="btnSubmit" ValidationGroup="ACRegisterEntity" OnClick="btnShowReport_Click"
                            runat="server" Text="Show Report"/>
                    </div>
                </div>
                </div>
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
