<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 28-Dec-2011, 07:18:54
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="OTDailyLogDatewise.ascx.cs"
    Inherits="Bay.ERP.Web.UI.OTDailyLogDatewiseControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div id="Div1" class="TableRow" style="text-align: left;" runat="server">
            <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
        </div>
        <div>
         <div style="float: left; width: 674px;">
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
                <asp:Label ID="lblDateInfo" runat="server" Font-Bold="true"></asp:Label>
                    <br />
                    <br />
                   <div class="lv-c">
                <asp:ListView ID="lvOTIssueCategoryWise" runat="server">
                    <LayoutTemplate>
                        <table class="lv" cellpadding="0" cellspacing="0">
                           <tr class="h">
                            <td class="rp">
                                Sl.
                            </td>
                            <td class="hi" style="width:200px;">
                                Project
                            </td>
                            <td class="hi" style="width:300px;">
                                Name
                            </td>
                            <td class="hi">
                                Total Time(hh:mm:ss)
                            </td>
                            <td class="rpb">
                                &nbsp;
                            </td>
                        </tr>
                            <tr runat="server" id="itemPlaceholder">
                            </tr>
                            
                        </table>
                    </LayoutTemplate>
                    <ItemTemplate>
                        <tr class="r">
                        <td class="rp">
                        <%# Container.DataItemIndex+1 %>
                        </td>
                        <td class="i">
                            <%# Eval("ProjectName")%>
                        </td>
                        <td class="i">
                            <%# Eval("Name")%>
                        </td>
                        <td class="i">
                            <%# Eval("TotalTime")%>
                        </td>
                        <td class="rpb">
                            &nbsp;
                        </td>
                    </tr>
                    </ItemTemplate>
                    <AlternatingItemTemplate>
                        <tr class="ar">
                        <td class="rp">
                         <%# Container.DataItemIndex+1 %>
                        </td>
                        <td class="i">
                            <%# Eval("ProjectName")%>
                        </td>
                        <td class="i">
                            <%# Eval("Name")%>
                        </td>
                        <td class="i">
                            <%# Eval("TotalTime")%>
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
              <br />
              <br />
                <asp:Label ID="lblTotal" runat="server" Font-Bold="true" ></asp:Label>
                    <br />
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
