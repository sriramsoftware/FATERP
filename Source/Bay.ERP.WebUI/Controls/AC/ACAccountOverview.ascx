<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 B2B Solutions, info@b2b-erp.com.
 ©2006 – 2010.

 Code Generate Time - 22-Jan-2013, 03:28:28
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ACAccountOverview.ascx.cs"
    Inherits="Bay.ERP.Web.UI.ACAccountOverviewControl" %>
<style type="text/css">
    .LinkLabel
    {
        text-decoration: none;
        padding-left: 50px;
        padding-right: 20px;
        padding-bottom: 30px;
        line-height: 19px;
    }
    .LinkLabel:Hover
    {
        text-decoration: underline;
        color: Green;
        padding-left: 50px;
        padding-right: 20px;
        padding-bottom: 30px;
        line-height: 19px;
    }
</style>
<script type="text/javascript">
    function BindEvents() {
        $(document).ready(function () {
            $("#tabs").tabs();
        });
    }
</script>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <script type="text/javascript">
            Sys.Application.add_load(BindEvents);
        </script>
        <div id="Div1" class="TableRow" style="text-align: left;" runat="server">
            <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
        </div>
        <div>
            <div id="tabs">
                <ul>
                    <li><a href="#ItemsandInventory">Items and Inventory</a></li>
                    <li><a href="#BankingandGeneralLedgerSetup">Banking and General Ledger</a></li>
                    <li><a href="#Setup">Setup</a></li>
                </ul>
                <div id="ItemsandInventory">
                
                <div style="width: 100%">
                      <div class="listContentTitle">
                          Items and Inventory
                        </div>
                        <div style="width: 100%;">
                            <div style="width: 503px; border: 1px solid #8CACBB; background-color: #F9F9F9; margin: 1px;
                                padding: 10px; float: left;">
                                <asp:HyperLink CssClass="LinkLabel" ID="HyperLink17" runat="server" NavigateUrl="~/AC/ACItemAccountMap.aspx"
                                    Text="Item Account Map"></asp:HyperLink>
                                <br />
                                <asp:HyperLink CssClass="LinkLabel" ID="HyperLink18" runat="server" NavigateUrl="~/AC/ACItemGroupAccountMap.aspx"
                                    Text="Item Group Map"></asp:HyperLink>
                           
                            </div>
                            <div style="width: 503px; border: 1px solid #8CACBB; background-color: #F9F9F9; margin: 1px;
                                padding: 10px; float: left;">
                                <asp:HyperLink CssClass="LinkLabel" ID="HyperLink20" runat="server" NavigateUrl="~/AC/ACItemAccountMap.aspx"
                                    Text="Item Depreciation Setup"></asp:HyperLink>
                                <br />
                                <asp:HyperLink CssClass="LinkLabel" ID="HyperLink21" runat="server" NavigateUrl="~/AC/ACItemGroupAccountMap.aspx"
                                    Text="Item Group Depreciation Setup"></asp:HyperLink>
                            </div>
                            <div style="clear: both;">
                            </div>
                        </div>
                  </div>
                  <br />
                  <br />
                  <div style="width: 100%">
                      <div class="listContentTitle">
                          Inquiries and Reports
                        </div>
                        <div style="width: 100%;">
                            <div style="width: 503px; border: 1px solid #8CACBB; background-color: #F9F9F9; margin: 1px;
                                padding: 10px; float: left;">
                                <asp:HyperLink CssClass="LinkLabel" ID="HyperLink29" runat="server" NavigateUrl="~/INV/INVStoreUnitItem.aspx"
                                    Text="Item Current Balance"></asp:HyperLink>
                                <br />
                                <asp:HyperLink CssClass="LinkLabel" ID="HyperLink30" runat="server" NavigateUrl="~/INV/INVCurrentStock.aspx"
                                    Text="Item Current Stock (All Store)"></asp:HyperLink>
                              <%--  <br />
                                <asp:HyperLink CssClass="LinkLabel" ID="HyperLink31" runat="server" NavigateUrl="~/AC/ACCurrencyExchangeRates.aspx"
                                    Text="Journal List"></asp:HyperLink>--%>
                               
                            </div>
                            <div style="width: 503px; border: 1px solid #8CACBB; background-color: #F9F9F9; margin: 1px;
                                padding: 10px; float: left;">
                                <asp:HyperLink CssClass="LinkLabel" ID="HyperLink32" runat="server" NavigateUrl="~/INV/INVTransaction.aspx"
                                    Text="Item Transaction"></asp:HyperLink>
                                <br />
                                <asp:HyperLink CssClass="LinkLabel" ID="HyperLink333" runat="server" NavigateUrl="~/INV/INVTransactionINOUT_CustomDetailedListCustom.aspx"
                                    Text="Inventory IN / OUT Inquery"></asp:HyperLink>
                                <br />
                               <%-- <asp:HyperLink CssClass="LinkLabel" ID="HyperLink34" runat="server" NavigateUrl="~/AC/ACClass.aspx"
                                    Text="GL Account Classes"></asp:HyperLink>
                                <br />--%>
                            </div>
                            <div style="clear: both;">
                            </div>
                        </div>
                  </div>
                  <br />
                  <br />
                   <div class="listContentTitle">
                            Maintenance
                        </div>
                        <div style="width: 100%;">
                            <div style="width: 503px; border: 1px solid #8CACBB; background-color: #F9F9F9; margin: 1px;
                                padding: 10px; float: left;">
                                <asp:HyperLink CssClass="LinkLabel" ID="HyperLink19" runat="server" NavigateUrl="~/INV/INVStore.aspx"
                                    Text="Add Store"></asp:HyperLink>
                                
                                
                               <%-- <br />
                                <asp:HyperLink CssClass="LinkLabel" ID="HyperLink300" runat="server" NavigateUrl="~/AC/ACCurrencyExchangeRates.aspx"
                                    Text="Exchange Rates"></asp:HyperLink>
                                <br />--%>
                            </div>
                            <div style="width: 503px; border: 1px solid #8CACBB; background-color: #F9F9F9; margin: 1px;
                                padding: 10px; float: left;">
                                <asp:HyperLink CssClass="LinkLabel" ID="HyperLink22" runat="server" NavigateUrl="~/INV/INVStoreUnit.aspx"
                                    Text="Add Store Unit"></asp:HyperLink>
                               <%-- <asp:HyperLink CssClass="LinkLabel" ID="HyperLink31" runat="server" NavigateUrl="~/AC/ACAccount.aspx"
                                    Text="GL Accounts"></asp:HyperLink>
                                <br />
                                <asp:HyperLink CssClass="LinkLabel" ID="HyperLink33" runat="server" NavigateUrl="~/AC/ACAccountGroup.aspx"
                                    Text="GL Account Groups"></asp:HyperLink>
                                <br />
                                <asp:HyperLink CssClass="LinkLabel" ID="HyperLink34" runat="server" NavigateUrl="~/AC/ACClass.aspx"
                                    Text="GL Account Classes"></asp:HyperLink>
                                <br />--%>
                            </div>
                            <div style="clear: both;">
                            </div>
                        </div>
                </div>
                <div id="BankingandGeneralLedgerSetup">
                    <div style="width: 100%">
                        <div class="listContentTitle">
                            Transaction
                        </div>
                        <div style="width: 100%;">
                            <div style="width: 503px; border: 1px solid #8CACBB; background-color: #F9F9F9; margin: 1px;
                                padding: 10px; float: left;">
                                <asp:HyperLink CssClass="LinkLabel" ID="hypPayment" runat="server" NavigateUrl="~/AC/ACBankAccountPayment.aspx"
                                    Text="Payment"></asp:HyperLink>
                                <br />
                                 <asp:HyperLink CssClass="LinkLabel" ID="hypPaymentList" runat="server" NavigateUrl="~/AC/ACBankAccountPaymentList.aspx"
                                    Text="Payment List"></asp:HyperLink>
                                <br />
                                <asp:HyperLink CssClass="LinkLabel" ID="hypCashPayment" runat="server" NavigateUrl="~/AC/ACCashPayment.aspx"
                                    Text="Cash Payment"></asp:HyperLink>
                                <br />
                                 <asp:HyperLink CssClass="LinkLabel" ID="HyperLink46" runat="server" NavigateUrl="~/AC/ACCashPaymentList.aspx"
                                    Text="Cash Payment List"></asp:HyperLink>
                                <br />
                                <asp:HyperLink CssClass="LinkLabel" ID="hypDeposit" runat="server" NavigateUrl="~/AC/ACBankAccountDeposit.aspx"
                                    Text="Deposit"></asp:HyperLink>
                                <br />
                                <asp:HyperLink CssClass="LinkLabel" ID="HyperLink31" runat="server" NavigateUrl="~/AC/ACBankAccountDepositList.aspx"
                                    Text="Deposit List"></asp:HyperLink>
                                <br />
                            </div>
                            <div style="width: 503px; border: 1px solid #8CACBB; background-color: #F9F9F9; margin: 1px;
                                padding: 10px; float: left;">
                                <asp:HyperLink CssClass="LinkLabel" ID="hypJournalEntry" runat="server" NavigateUrl="~/AC/ACTemporaryJournalMaster.aspx"
                                    Text="Journal List"></asp:HyperLink>
                                <br />
                                <asp:HyperLink CssClass="LinkLabel" ID="HyperLink33" runat="server" NavigateUrl="~/AC/ACJournal.aspx"
                                    Text="Journal Entry"></asp:HyperLink>
                                <br />
                                <asp:HyperLink CssClass="LinkLabel" ID="hypBudgetEntry" runat="server" NavigateUrl="~/AC/ACBudget.aspx"
                                    Text="Budget Entry"></asp:HyperLink>
                                <br />
                                <asp:HyperLink CssClass="LinkLabel" ID="hypBankAccountTransfer" runat="server" NavigateUrl="~/AC/ACBankAccountTransfer.aspx"
                                    Text="Bank Account Transfer"></asp:HyperLink>
                                <br />
                                <asp:HyperLink CssClass="LinkLabel" ID="HyperLink34" runat="server" NavigateUrl="~/AC/ACBankAccountTransferList.aspx"
                                    Text="Bank Account Transfer List"></asp:HyperLink>
                                <br />
                                <asp:HyperLink CssClass="LinkLabel" ID="hypReconcileBankAccount" runat="server" NavigateUrl="#"
                                    Text="Reconcile Bank Account"></asp:HyperLink>
                                <br />
                            </div>
                            <div style="clear: both;">
                            </div>
                        </div>
                        <br />
                        <br />
                        <div class="listContentTitle">
                            Inquiries and Reports
                        </div>
                        <div style="width: 100%;">
                            <div style="width: 503px; border: 1px solid #8CACBB; background-color: #F9F9F9; margin: 1px;
                                padding: 10px; float: left;">
                                <asp:HyperLink CssClass="LinkLabel" ID="HyperLink1" runat="server" NavigateUrl="~/AC/ACJournalInquery.aspx"
                                    Text="Journal Inquiry"></asp:HyperLink>
                                <br />
                                <asp:HyperLink CssClass="LinkLabel" ID="HyperLink2" runat="server" NavigateUrl="~/AC/ACGLAccountInquery.aspx"
                                    Text="GL Inquiry"></asp:HyperLink>
                                <br />
                                <asp:HyperLink CssClass="LinkLabel" ID="HyperLink3" runat="server" NavigateUrl="~/AC/ACBankAccountInquery.aspx"
                                    Text="Bank Account Inquiry"></asp:HyperLink>
                                <br />
                                <asp:HyperLink CssClass="LinkLabel" ID="HyperLink9" runat="server" NavigateUrl="~/AC/ACAccountTreeview.aspx"
                                    Text="Chart of Accounts"></asp:HyperLink>
                                    <br />
                                    <asp:HyperLink CssClass="LinkLabel" ID="HyperLink41" runat="server" NavigateUrl="~/AC/ACAccountVendorPortfolio.aspx"
                                    Text="Vendor Portfolio"></asp:HyperLink>
                            </div>
                            <div style="width: 503px; border: 1px solid #8CACBB; background-color: #F9F9F9; margin: 1px;
                                padding: 10px; float: left;">
                                <asp:HyperLink CssClass="LinkLabel" ID="HyperLink4" runat="server" NavigateUrl="~/AC/ACTrialBalance.aspx"
                                    Text="Trial Balance"></asp:HyperLink>
                                <br />
                                <asp:HyperLink CssClass="LinkLabel" ID="HyperLink7" runat="server" NavigateUrl="~/AC/ACBalanceSheet.aspx"
                                    Text="Balance Sheet Drilldown"></asp:HyperLink>
                                <br />
                                <asp:HyperLink CssClass="LinkLabel" ID="HyperLink8" runat="server" NavigateUrl="~/AC/ACAccountOverview.aspx"
                                    Text="Profit and Loss Drilldown"></asp:HyperLink>
                                <br />
                                <asp:HyperLink CssClass="LinkLabel" ID="HyperLink10" runat="server" NavigateUrl="~/AC/ACAccountBalanceSheetReport.aspx"
                                    Text="Balance Sheet Report"></asp:HyperLink>
                                    <br />
                                    <asp:HyperLink CssClass="LinkLabel" ID="HyperLink42" runat="server" NavigateUrl="~/AC/ACAccountOverview.aspx"
                                    Text="Project Wise Vendor Portfolio"></asp:HyperLink>
                            </div>
                            <div style="clear: both;">
                            </div>
                        </div>
                        <br />
                        <br />
                        <div class="listContentTitle">
                            Maintenance
                        </div>
                        <div style="width: 100%;">
                            <div style="width: 503px; border: 1px solid #8CACBB; background-color: #F9F9F9; margin: 1px;
                                padding: 10px; float: left;">
                                <asp:HyperLink CssClass="LinkLabel" ID="hypBankAccounts" runat="server" NavigateUrl="~/AC/ACBankAccount.aspx"
                                    Text="Bank Accounts"></asp:HyperLink>
                                <br />
                                <asp:HyperLink CssClass="LinkLabel" ID="hypCurrencies" runat="server" NavigateUrl="~/MD/MDCurrency.aspx"
                                    Text="Currencies"></asp:HyperLink>
                                <br />
                                <asp:HyperLink CssClass="LinkLabel" ID="hypExchangeRates" runat="server" NavigateUrl="~/AC/ACCurrencyExchangeRates.aspx"
                                    Text="Exchange Rates"></asp:HyperLink>
                                <br />
                            </div>
                            <div style="width: 503px; border: 1px solid #8CACBB; background-color: #F9F9F9; margin: 1px;
                                padding: 10px; float: left;">
                                <asp:HyperLink CssClass="LinkLabel" ID="hyp" runat="server" NavigateUrl="~/AC/ACAccount.aspx"
                                    Text="GL Accounts"></asp:HyperLink>
                                <br />
                                <asp:HyperLink CssClass="LinkLabel" ID="HyperLink5" runat="server" NavigateUrl="~/AC/ACAccountGroup.aspx"
                                    Text="GL Account Groups"></asp:HyperLink>
                                <br />
                                <asp:HyperLink CssClass="LinkLabel" ID="HyperLink6" runat="server" NavigateUrl="~/AC/ACClass.aspx"
                                    Text="GL Account Classes"></asp:HyperLink>
                                <br />
                            </div>
                            <div style="clear: both;">
                            </div>
                        </div>
                        <div>
                        </div>
                    </div>
                </div>
                
                <div id="Setup">
                  <div style="width: 100%">
                      <div class="listContentTitle">
                           Company Setup
                        </div>
                        <div style="width: 100%;">
                            <div style="width: 503px; border: 1px solid #8CACBB; background-color: #F9F9F9; margin: 1px;
                                padding: 10px; float: left;">
                                <asp:HyperLink CssClass="LinkLabel" ID="HyperLink11" runat="server" NavigateUrl="~/AC/ACFiscalYear.aspx"
                                    Text="Fiscal Year"></asp:HyperLink>
                                <br />
                                <asp:HyperLink CssClass="LinkLabel" ID="HyperLink12" runat="server" NavigateUrl="~/AC/ACCompanyInfo.aspx"
                                    Text="Company Info"></asp:HyperLink>
                                <br />
                                <asp:HyperLink CssClass="LinkLabel" ID="HyperLink13" runat="server" NavigateUrl="~/AC/ACTaxType.aspx"
                                    Text="Tax Type"></asp:HyperLink>
                                <br />
                                <asp:HyperLink CssClass="LinkLabel" ID="HyperLink43" runat="server" NavigateUrl="~/CRM/CRMCustomer.aspx"
                                    Text="Customer Info"></asp:HyperLink>
                            </div>
                            <div style="width: 503px; border: 1px solid #8CACBB; background-color: #F9F9F9; margin: 1px;
                                padding: 10px; float: left;">
                                <asp:HyperLink CssClass="LinkLabel" ID="HyperLink14" runat="server" NavigateUrl="~/AC/ACAccountResourceAccountMap.aspx"
                                    Text="Account Vendor / Customer Map"></asp:HyperLink>
                                <br />
                                <asp:HyperLink CssClass="LinkLabel" ID="HyperLink15" runat="server" NavigateUrl="~/AC/ACDimension.aspx"
                                    Text="Dimension"></asp:HyperLink>
                                <br />
                                <asp:HyperLink CssClass="LinkLabel" ID="HyperLink16" runat="server" NavigateUrl="~/MD/ACMDBankAccountType.aspx"
                                    Text="Bank Account Type"></asp:HyperLink>
                                <br />
                                <asp:HyperLink CssClass="LinkLabel" ID="HyperLink44" runat="server" NavigateUrl="~/CRM/CRMCustomerAddressInfo.aspx"
                                    Text="Customer Address Info"></asp:HyperLink>
                            </div>
                            <div style="clear: both;">
                            </div>
                        </div>
                        <br />
                        <br />
                        <div class="listContentTitle">
                           System Setup
                        </div>
                        <div style="width: 100%;">
                            <div style="width: 503px; border: 1px solid #8CACBB; background-color: #F9F9F9; margin: 1px;
                                padding: 10px; float: left;">
                                <asp:HyperLink CssClass="LinkLabel" ID="HyperLink23" runat="server" NavigateUrl="~/MD/ACMDTemporaryJournalApprovalStatus.aspx"
                                    Text="Journal Approval Status"></asp:HyperLink>
                                <br />
                                <asp:HyperLink CssClass="LinkLabel" ID="HyperLink24" runat="server" NavigateUrl="~/MD/ACMDBankAccountPaymentApprovalStatus.aspx"
                                    Text="Payment Approval Status"></asp:HyperLink>
                                <br />
                                <asp:HyperLink CssClass="LinkLabel" ID="HyperLink25" runat="server" NavigateUrl="~/MD/ACMDBankAccountDepositApprovalStatus.aspx"
                                    Text="Deposit Approval Status"></asp:HyperLink>
                                <br />
                            </div>
                            <div style="width: 503px; border: 1px solid #8CACBB; background-color: #F9F9F9; margin: 1px;
                                padding: 10px; float: left;">
                                <asp:HyperLink CssClass="LinkLabel" ID="HyperLink26" runat="server" NavigateUrl="~/AC/ACClassType.aspx"
                                    Text="Account Class Type"></asp:HyperLink>
                                <br />
                                <asp:HyperLink CssClass="LinkLabel" ID="HyperLink27" runat="server" NavigateUrl="~/MD/ACMDAccountResourceCategory.aspx"
                                    Text="Resource Category"></asp:HyperLink>
                                <br />
                                <asp:HyperLink CssClass="LinkLabel" ID="HyperLink28" runat="server" NavigateUrl="~/AC/ACDepreciationMethod.aspx"
                                    Text="Depreciation Method"></asp:HyperLink>
                                <br />
                            </div>
                            <div style="clear: both;">
                            </div>
                        </div>
                         <br />
                        <br />
                        <div class="listContentTitle">
                           System Setup
                        </div>
                        <div style="width: 100%;">
                            <div style="width: 503px; border: 1px solid #8CACBB; background-color: #F9F9F9; margin: 1px;
                                padding: 10px; float: left;">
                                <asp:HyperLink CssClass="LinkLabel" ID="HyperLink35" runat="server" NavigateUrl="~/MD/ACMDPayTo.aspx"
                                    Text="Paid To"></asp:HyperLink>
                                <br />
                                <asp:HyperLink CssClass="LinkLabel" ID="HyperLink36" runat="server" NavigateUrl="~/MD/ACMDPaidFrom.aspx"
                                    Text="Paid From"></asp:HyperLink>
                                <br />
                                <asp:HyperLink CssClass="LinkLabel" ID="HyperLink37" runat="server" NavigateUrl="~/MD/ACMDDebitCredit.aspx"
                                    Text="Debit / Credit"></asp:HyperLink>
                                <br />
                            </div>
                            <div style="width: 503px; border: 1px solid #8CACBB; background-color: #F9F9F9; margin: 1px;
                                padding: 10px; float: left;">
                                <asp:HyperLink CssClass="LinkLabel" ID="HyperLink38" runat="server" NavigateUrl="~/AC/ACClassType.aspx"
                                    Text="Account Class Type"></asp:HyperLink>
                                <br />
                                <asp:HyperLink CssClass="LinkLabel" ID="HyperLink39" runat="server" NavigateUrl="~/AC/ACAccountOverview.aspx"
                                    Text="Account Overview"></asp:HyperLink>
                                <br />
                                <asp:HyperLink CssClass="LinkLabel" ID="HyperLink40" runat="server" NavigateUrl="~/AC/ACDepreciationMethod.aspx"
                                    Text="Depreciation Method"></asp:HyperLink>
                                <br />
                            </div>
                            <div style="clear: both;">
                            </div>
                        </div>
                  </div>
                </div>
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
