<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 23-Mar-2013, 04:14:01
--%>




<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CMNReport.ascx.cs"
    Inherits="Bay.ERP.Web.UI.CMNReportControl" %>

<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
      <div>
      <div id="dvToDate" runat="server" visible="false">
       <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    To Date&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox ID="txtToDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                        ValidationGroup="REQRequisitionEntity" Width="230" />
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvRequisitionDate" runat="server" ControlToValidate="txtToDate"
                        ErrorMessage="Please Enter To Date" ValidationGroup="REQRequisitionEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revRequisitionDate" runat="server" ControlToValidate="txtToDate"
                        Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                        ValidationGroup="REQRequisitionEntity"></asp:RegularExpressionValidator>
                </div>
            </div>
            </div>
            <div id="dvEncash" runat="server" visible="false">
       <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    To Date&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox ID="txtToDateEncash" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                        ValidationGroup="REQRequisitionEntity" Width="230" />
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvtxtToDateEncash" runat="server" ControlToValidate="txtToDateEncash"
                        ErrorMessage="Please Enter To Date" ValidationGroup="REQRequisitionEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revtxtToDateEncash" runat="server" ControlToValidate="txtToDateEncash"
                        Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                        ValidationGroup="REQRequisitionEntity"></asp:RegularExpressionValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Encashed&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:CheckBox ID="chkIsEncashed" runat="server" ClientIDMode="Static"/>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
            </div>
        <asp:Button ID="btnShowReport" OnClick="btnShowReport_Click" runat="server" Text="Show Report"  />
      </div>
    </ContentTemplate>
</asp:UpdatePanel>
