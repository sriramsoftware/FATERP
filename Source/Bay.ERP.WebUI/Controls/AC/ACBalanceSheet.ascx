<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 B2B Solutions, info@b2b-erp.com.
 ©2006 – 2010.

 Code Generate Time - 30-Jan-2013, 03:35:13
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ACBalanceSheet.ascx.cs"
    Inherits="Bay.ERP.Web.UI.ACBalanceSheetControl" %>

        <style type="text/css">
        
     .AccountTable 
     {
      margin: 5px;
      padding:2px; 
      margin-top: 20px;
      border-collapse: collapse;
      width:90%;
     }
 
    .Accounttd
    {
     padding: .1em; 
     border-bottom: 1px #ccc solid;
     font-size : 10pt; 
     height:25px;
    }   

    .AccountTable .TableHeader
    {
     padding: .1em; 
     border-bottom: 1px #ccc solid;
     font-size : 10pt; 
     font-weight:bold;
     text-decoration:underline;
     height:40px;
    }   
    
    </style>

<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div style="width:600px; float:left;">
             <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    As at&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox ID="txtAsAt" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                        ValidationGroup="ACJournalEntity" Width="230" />
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvtxtAsAt" runat="server" ControlToValidate="txtAsAt"
                        ErrorMessage="Please Enter As At Date" ValidationGroup="ACJournalEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtAsAt"
                        Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                        ValidationGroup="ACJournalEntity"></asp:RegularExpressionValidator>
                </div>
            </div>
             <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Fiscal Year&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlFiscalYearID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="ACJournalEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvFiscalYearID" runat="server" ControlToValidate="ddlFiscalYearID"
                            ErrorMessage="Please Select Fiscal Year" ValidationGroup="ACJournalEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
            <div class="TableRow" style="text-align: center;">
                <div class="TableFormLeble">
                    &nbsp;</div>
                <div class="TableFormContent">
                    <asp:Button ID="btnSearch" ValidationGroup="ACJournalEntity" OnClick="btnSearch_Click"
                        runat="server" Text="Search" />
                </div>
            </div>
            </div>
            <div style="width: 400px; float: left;">
                <div style="font-size: 13px; font-weight: bold; color: Green; padding-bottom: 10px; border:1px solid gray; ">
                    <table cellpadding="0" cellspacing="0" style="margin-bottom: 15px; padding-left: 65px;padding-right: 30px;padding-top: 30px; line-height:18px;">
                        <tr>
                            <td>
                                Total Asset&nbsp;:
                            </td>
                            <td>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblTotalAsset" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Total Liabilities&nbsp;:
                            </td>
                            <td>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblTotalLiabilities" runat="server"></asp:Label>
                            </td>
                        </tr>
                         <tr>
                            <td>
                                Total Return&nbsp;:
                            </td>
                            <td>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblTotalReturn" runat="server"></asp:Label>
                            </td>
                        </tr>
                    </table>
                </div>
                       </div>
                       <div style="clear:both;"></div>
            <br />
            <div>
                <div>
                    <asp:ListView ID="lvACJournal" runat="server" OnItemDataBound="lvACJournal_ItemDataBound">
                        <LayoutTemplate>
                            <table class="AccountTable" cellpadding="0" cellspacing="0">
                                <tr>
                                    <td class="TableHeader" style="width:300px;">
                                        Account Group
                                    </td>
                                    <td class="TableHeader" style="width:220px;">
                                        Balance
                                    </td>
                                </tr>
                                <tr runat="server" id="itemPlaceholder">
                                </tr>
                                <tr>
                                    <td colspan="100%">
                                        <div>
                                            <div class="lv-Footer">
                                                <asp:DataPager ID="dpListView" runat="server" PageSize="50">
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
                            <tr>
                                <td class="Accounttd">
                                 <asp:HyperLink ID="hypAccountGroupLV" CssClass="CommonLink" runat="server" Text='<%# Eval("AccountGroup")%>'></asp:HyperLink>
                                </td>
                              <%--  <td class="i">
                                    <%# Decimal.Round((Decimal)Eval("DebitAmount"),2)%>
                                </td>
                                <td class="i">
                                    <%# Decimal.Round((Decimal)Eval("CreditAmount"),2)%>
                                </td>--%>
                                <td class="Accounttd">
                                    <%# Decimal.Round((Decimal)Eval("Balance"),2)%>
                                </td>
                            </tr>
                        </ItemTemplate>
                        <EmptyDataTemplate>
                            <div class="edr">
                                No Records Found To Display
                            </div>
                        </EmptyDataTemplate>
                    </asp:ListView>
                </div>
            </div>
           
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
