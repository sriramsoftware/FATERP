<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 28-Apr-2013, 12:14:24
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CRMPaymentCollectionList.ascx.cs"
    Inherits="Bay.ERP.Web.UI.CRMPaymentCollectionListControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div id="Div1" class="TableRow" style="text-align: left;" runat="server">
            <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
        </div>
         <div class="TableRow" style="width: 100%; padding-left:460px;">
            <div class="TableFormLeble" style="text-align: right;">
               Filter Text&nbsp;:
            </div>
            <div class="TableFormContent waterMarkContainer">
             <label class="watermarkLabel" for="txtSearchText">
                            Type Money Receipt,Project, Installment, Payment</label>
                <asp:TextBox ID="txtSearchText" runat="server" ClientIDMode="Static" CssClass="ktiTextBox"
                     Width="350" /><span><asp:CheckBox ID="chbxFilter"
                        runat="server" AutoPostBack="true" OnCheckedChanged="chbxFilter_CheckedChanged"
                        Text="Use Filter" /></span>
            </div>
            <div class="TableFormValidatorContent">
            </div>
        </div>
        <div>
            <div class="lv-c">
                <asp:ListView ID="lvCRMPaymentCollection" runat="server" DataSourceID="odsCRMPaymentCollection" OnItemDataBound="lvCRMPaymentCollection_ItemDataBound"
                    OnItemCommand="lvCRMPaymentCollection_ItemCommand">
                    <LayoutTemplate>
                        <table class="lv" cellpadding="0" cellspacing="0">
                            <tr class="h">
                                <td class="rp">
                                    &nbsp;
                                </td>
                                <td class="hi" style="display: none;">
                                    Payment Schedule Map
                                </td>
                                <td class="hi">
                                    Confirmation?
                                </td>
                                <td class="hi">
                                    Agreement Type
                                </td>
                                <td class="hi">
                                    Project
                                </td>
                                <td class="hi">
                                    Installment
                                </td>
                                <td class="hi">
                                    Due Date
                                </td>
                                <td class="hi">
                                    Money Receipt No
                                </td>
                                <td class="hi">
                                    Installment Payment Amount
                                </td>
                                <td class="hi">
                                    Actual Payment Date
                                </td>
                                <td class="hi" style="display: none;">
                                    Payment Description
                                </td>
                                <td class="hi" style="display: none;">
                                    Installment Payment In Word
                                </td>
                                <td class="hi" style="display: none;">
                                    Initial Amount In Agreement
                                </td>
                                <td class="hi">
                                    Over Due Amount
                                </td>
                                <td class="hi">
                                    Delay Day On Payment
                                </td>
                                <td class="hi">
                                    Delay Day On Over Due
                                </td>
                                <td class="hi" style="display: none;">
                                    Payment Received In Bank
                                </td>
                                <td class="hi" style="display: none;">
                                    Payment Not Received Note
                                </td>
                                <td class="hi" style="display: none;">
                                    Agreement
                                </td>
                                <td class="hi" style="display: none;">
                                    Reverse Entry
                                </td>
                                <td class="hi" style="display: none;">
                                    Last Payment
                                </td>
                                <td class="hi" style="display: none;">
                                    Discount Amount
                                </td>
                                <td class="hi" style="display: none;">
                                    Vat
                                </td>
                                <td class="hi" style="display: none;">
                                    Tax
                                </td>
                                <td class="hi" style="display: none;">
                                    Service Charge
                                </td>
                                <td class="hi" style="display: none;">
                                    Additional Fee
                                </td>
                                <td class="hi" style="display: none;">
                                    Gross Amount
                                </td>
                                <td class="hi" style="display: none;">
                                    Net Amount
                                </td>
                                <td class="hi" style="display: none;">
                                    Payment Approval Status
                                </td>
                                <td class="hi">
                                    Payment Category
                                </td>
                                <td class="hi" style="display: none;">
                                    Extra Field
                                </td>
                                <td class="hi" style="display: none;">
                                    Remarks
                                </td>
                                <td class="his" style="display: none;">
                                    EDIT
                                </td>
                                <td class="his" style="display: none;">
                                    DELETE
                                </td>
                                 <td class="his">
                                    Report
                                </td>
                                <td class="rp">
                                    &nbsp;
                                </td>
                                <td class="rpb">
                                    &nbsp;
                                </td>
                            </tr>
                            <tr runat="server" id="itemPlaceholder">
                            </tr>
                            <tr>
                                <td colspan="100%">
                                    <div class="lv-FooterContainer">
                                        <div class="lv-Footer">
                                            <asp:DataPager ID="dpListView" runat="server" PageSize="15">
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
                            <td class="rp">
                                &nbsp;
                            </td>
                            <td class="i" style="display: none;">
                                <%# Eval("PaymentScheduleMapID")%>
                                <%# Eval("PaymentDescription")%>
                                <%# Eval("InstallmentPaymentInWord")%>
                                <%# Eval("InitialAmountInAgreement")%>
                                <%# Eval("PaymentReceivedInBank")%>
                                <%# Eval("PaymentNotReceivedNote")%>
                                <%# Eval("AgreementID")%>
                                <%# Eval("ReverseEntry") != null ? (((Boolean)Eval("ReverseEntry")) ? "Yes" : "No") : ""%>
                                <%# Eval("LastPayment") != null ? (((Boolean)Eval("LastPayment")) ? "Yes" : "No") : ""%>
                                <asp:CheckBox ID="chbxChequeInCashConfirmationLV" runat="server" Checked='<%# Eval("ChequeInCashConfirmation")%>'></asp:CheckBox>
                                <%# Eval("DiscountAmount")%>
                                <%# Eval("Vat")%>
                                <%# Eval("Tax")%>
                                <%# Eval("ServiceCharge")%>
                                <%# Eval("AdditionalFee")%>
                                <%# Eval("GrossAmount")%>
                                <%# Eval("NetAmount")%>
                                <%# Eval("PaymentApprovalStatusID")%>
                                <%# Eval("ExtraField")%>
                                <%# Eval("Remarks")%>
                            </td>
                             <td class="i">
                             <asp:Button ID="btnChequeInCashConfirmationLV" Text="Encashed" runat="server" CommandName="UpdateItem"
                                        OnClientClick="return confirm('Are you sure to Confirm?')" CommandArgument='<%#Eval("PaymentCollectionID")%>'></asp:Button>
                            </td>
                            <td class="i">
                                <%# Eval("AgreementTypeName")%>
                            </td>
                            <td class="i">
                                <%# Eval("ProjectName")%>
                            </td>
                            <td class="i">
                                <%# Eval("PaymentScheduleMapInstallmentName")%>
                            </td>
                            <td class="i">
                                <%# Eval("InstallmentDueDate")!= null ? ((DateTime)Eval("InstallmentDueDate")).ToString("dd-MM-yyyy") : ""%>
                            </td>
                            <td class="i">
                                <%# Eval("MoneyReceiptNo")%>
                            </td>
                            <td class="i">
                                <%# Eval("InstallmentPaymentAmount")%>
                            </td>
                            <td class="i">
                                <%# Eval("ActualPaymentDate") != null ? ((DateTime)Eval("ActualPaymentDate")).ToString("dd-MM-yyyy") : ""%>
                            </td>
                            <td class="i">
                                <%# Eval("OverDueAmount")%>
                            </td>
                            <td class="i">
                                <%# Eval("DelayDayOnPayment")%>
                            </td>
                            <td class="i">
                                <%# Eval("DelayDayOnOverDue")%>
                            </td>
                            <td class="i">
                                <%# Eval("CRMMDPaymentCategoryName")%>
                            </td>
                            <td class="i" style="display: none;">
                                <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                    Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("PaymentCollectionID")%>'
                                    UniqueKey="CRMPaymentCollection_lvCRMPaymentCollection_Edit_key" />
                            </td>
                            <td class="i" style="display: none;">
                                <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                    Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete C RMPayment Collection?')"
                                    CommandArgument='<%#Eval("PaymentCollectionID")%>' UniqueKey="CRMPaymentCollection_lvCRMPaymentCollection_Edit_key" />
                            </td>
                            <td class="i">
                            
                                        <asp:HyperLink ID="hypReport" runat="server" Text="Report" />
                                        </td>
                            <td class="rp">
                                &nbsp;
                            </td>
                            <td class="rpb">
                                &nbsp;
                            </td>
                        </tr>
                    </ItemTemplate>
                    <AlternatingItemTemplate>
                        <tr class="ar">
                            <td class="rp">
                                &nbsp;
                            </td>
                            <td class="i" style="display: none;">
                                <%# Eval("PaymentScheduleMapID")%>
                                <%# Eval("PaymentDescription")%>
                                <%# Eval("InstallmentPaymentInWord")%>
                                <%# Eval("InitialAmountInAgreement")%>
                                <%# Eval("PaymentReceivedInBank")%>
                                <%# Eval("PaymentNotReceivedNote")%>
                                <%# Eval("AgreementID")%>
                                <%# Eval("ReverseEntry") != null ? (((Boolean)Eval("ReverseEntry")) ? "Yes" : "No") : ""%>
                                <%# Eval("LastPayment") != null ? (((Boolean)Eval("LastPayment")) ? "Yes" : "No") : ""%>
                               <asp:CheckBox ID="chbxChequeInCashConfirmationLV" runat="server" Checked='<%# Eval("ChequeInCashConfirmation")%>'></asp:CheckBox>
                                <%# Eval("DiscountAmount")%>
                                <%# Eval("Vat")%>
                                <%# Eval("Tax")%>
                                <%# Eval("ServiceCharge")%>
                                <%# Eval("AdditionalFee")%>
                                <%# Eval("GrossAmount")%>
                                <%# Eval("NetAmount")%>
                                <%# Eval("PaymentApprovalStatusName")%>
                                <%# Eval("ExtraField")%>
                                <%# Eval("Remarks")%>
                            </td>
                            <td class="i">
                                <asp:Button ID="btnChequeInCashConfirmationLV" Text="Encashed" runat="server" CommandName="UpdateItem"
                                        OnClientClick="return confirm('Are you sure to Confirm?')" CommandArgument='<%#Eval("PaymentCollectionID")%>'></asp:Button>
                            </td>
                            <td class="i">
                                <%# Eval("AgreementTypeName")%>
                            </td>
                            <td class="i">
                                <%# Eval("ProjectName")%>
                            </td>
                            <td class="i">
                                <%# Eval("PaymentScheduleMapInstallmentName")%>
                            </td>
                            <td class="i">
                                <%# Eval("InstallmentDueDate")!= null ? ((DateTime)Eval("InstallmentDueDate")).ToString("dd-MM-yyyy") : ""%>
                            </td>
                            <td class="i">
                                <%# Eval("MoneyReceiptNo")%>
                            </td>
                            <td class="i">
                                <%# Eval("InstallmentPaymentAmount")%>
                            </td>
                            <td class="i">
                                <%# Eval("ActualPaymentDate") != null ? ((DateTime)Eval("ActualPaymentDate")).ToString("dd-MM-yyyy") : ""%>
                            </td>
                            <td class="i">
                                <%# Eval("OverDueAmount")%>
                            </td>
                            <td class="i">
                                <%# Eval("DelayDayOnPayment")%>
                            </td>
                            <td class="i">
                                <%# Eval("DelayDayOnOverDue")%>
                            </td>
                            <td class="i">
                                <%# Eval("CRMMDPaymentCategoryName")%>
                            </td>
                            <td class="i" style="display: none;">
                                <kti:SecureLinkButton ID="SecureLinkButton1" runat="server" CssClass="CommonButtonLink"
                                    Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("PaymentCollectionID")%>'
                                    UniqueKey="CRMPaymentCollection_lvCRMPaymentCollection_Edit_key" />
                            </td>
                            <td class="i" style="display: none;">
                                <kti:SecureLinkButton ID="SecureLinkButton2" runat="server" CssClass="CommonButtonLink"
                                    Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete C RMPayment Collection?')"
                                    CommandArgument='<%#Eval("PaymentCollectionID")%>' UniqueKey="CRMPaymentCollection_lvCRMPaymentCollection_Edit_key" />
                            </td>
                            <td class="i" style="display: none;">
                                <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                    Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("PaymentCollectionID")%>'
                                    UniqueKey="CRMPaymentCollection_lvCRMPaymentCollection_Edit_key" />
                            </td>
                            <td class="i" style="display: none;">
                                <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                    Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete C RMPayment Collection?')"
                                    CommandArgument='<%#Eval("PaymentCollectionID")%>' UniqueKey="CRMPaymentCollection_lvCRMPaymentCollection_Edit_key" />
                            </td>
                            <td class="i">
                            
                                        <asp:HyperLink ID="hypReport" runat="server" Text="Report" />
                                        </td>
                            <td class="rp">
                                &nbsp;
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
            <asp:ObjectDataSource ID="odsCRMPaymentCollection" runat="server" SelectMethod="GetPagedData"
                SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.CRMPaymentCollection_DetailedDataSource"
                SortParameterName="sortExpression" OnSelecting="odsCRMPaymentCollection_Selecting">
                <SelectParameters>
                    <asp:Parameter Name="startRowIndex" Type="Int32" />
                    <asp:Parameter Name="pageSize" Type="Int32" />
                    <asp:Parameter Name="sortExpression" Type="String" />
                    <asp:Parameter Name="filterExpression" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
