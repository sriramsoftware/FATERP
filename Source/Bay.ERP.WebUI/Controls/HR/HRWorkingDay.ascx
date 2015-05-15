<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 29-Dec-2013, 03:14:39
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HRWorkingDay.ascx.cs"
    Inherits="Bay.ERP.Web.UI.HRWorkingDayControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div style="width: 1000px;">
                <div style="float: left; width: 500px;">
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Fiscal Year&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:DropDownList ID="ddlFiscalYearID" CssClass="ktiSelect" ClientIDMode="Static"
                                runat="server" ValidationGroup="HRWorkingDayEntity" Width="234">
                            </asp:DropDownList>
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="rfvFiscalYearID" runat="server" ControlToValidate="ddlFiscalYearID"
                                ErrorMessage="Please Select Fiscal Year" ValidationGroup="HRWorkingDayEntity"
                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Salary Session&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:DropDownList ID="ddlSalarySessionID" CssClass="ktiSelect" ClientIDMode="Static"
                                runat="server" ValidationGroup="HRWorkingDayEntity" Width="234">
                            </asp:DropDownList>
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="rfvSalarySessionID" runat="server" ControlToValidate="ddlSalarySessionID"
                                ErrorMessage="Please Select Salary Session" ValidationGroup="HRWorkingDayEntity"
                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="text-align: center;">
                        <div class="TableFormLeble">
                            &nbsp;</div>
                        <div class="TableFormContent">
                            <asp:Button ID="btnGet" ValidationGroup="none" OnClick="btnGet_Click" runat="server"
                                Text="Generate" />
                        </div>
                    </div>
                    
                </div>
                <div style="float: left; width: 415px; border:2px solid; background-color:#D1EEEB;">
                <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Holiday&nbsp;:
                        </div>
                        <div class="TableFormLeble">
                            <asp:Label ID="lblHoliday" runat="server" />
                        </div>
                        <div class="TableFormValidatorContent">
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Working Day&nbsp;:
                        </div>
                        <div class="TableFormLeble">
                            <asp:Label ID="lblWorkingDay" runat="server" />
                        </div>
                        <div class="TableFormValidatorContent">
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Total Day&nbsp;:
                        </div>
                        <div class="TableFormLeble">
                            <asp:Label ID="lblTotalDay" runat="server" />
                        </div>
                        <div class="TableFormValidatorContent">
                        </div>
                    </div>
                    <div class="TableRow" style="text-align: center;">
                        <div class="TableFormLeble">
                            &nbsp;</div>
                        <div class="TableFormContent">
                            <asp:Button ID="btnReGenerate" ValidationGroup="none" OnClick="btnbtnReGenerate_Click" runat="server"
                                Text="ReGenerate" />
                        </div>
                    </div>
                </div>
                <div style="clear: both">
                </div>
            </div>
            <br />
            <div class="listContentTitle">
                Working Day List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvHRWorkingDay" runat="server" OnItemCommand="lvHRWorkingDay_ItemCommand">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi">
                                        Working Day
                                    </td>
                                    <td class="hi">
                                        Category
                                    </td>
                                    <td class="hi">
                                        Remarks
                                    </td>
                                </tr>
                                <tr runat="server" id="itemPlaceholder">
                                </tr>
                                <tr>
                                    <td colspan="100%" style="display: none;">
                                        <div class="lv-FooterContainer">
                                            <div class="lv-Footer">
                                                <asp:DataPager ID="dpListView" runat="server" PageSize="40">
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
                            <tr class="r" runat="server" id="_itemrow">
                                <td class="rp">
                                    &nbsp;
                                </td>
                                <td class="i" style="display: none;">
                                    <asp:Label ID="lblFiscalYearIDLV" runat="server" Text='<%# Eval("FiscalYearID")%>'></asp:Label>
                                    <asp:Label ID="lblSalarySessionIDLV" runat="server" Text='<%# Eval("SalarySessionID")%>'></asp:Label>
                                    <asp:Label ID="lblYearLV" runat="server" Text='<%# Eval("Year")%>'></asp:Label>
                                    <asp:Label ID="lblMonthLV" runat="server" Text='<%# Eval("Month")%>'></asp:Label>
                                    <asp:Label ID="lblDayLV" runat="server" Text='<%# Eval("Day")%>'></asp:Label>
                                    <asp:Label ID="lblDateLV" runat="server" Text='<%# Eval("Date") != null ? ((DateTime)Eval("Date")).ToString("dd-MM-yyyy") : ""%>'></asp:Label>
                                </td>
                                <td class="i" style="display: none;">
                                    <asp:Label ID="lblNoteIDLV" runat="server" Text='<%# Eval("Note")%>'></asp:Label>
                                </td>
                                <td class="i">
                                    <asp:Label ID="lblWorkingDayLV" runat="server" Text='<%# Eval("WorkingDay") != null ? ((DateTime)Eval("WorkingDay")).ToString("dd-MM-yyyy") : ""%>'></asp:Label>
                                </td>
                                <td class="i">
                                    <div style="display: none">
                                        <asp:Label ID="lblAttendanceLeaveAndHolidayCategoryIDLV" runat="server" Text='<%# Eval("AttendanceLeaveAndHolidayCategoryID")%>'></asp:Label></div>
                                    <asp:DropDownList ID="ddlAttendanceLeaveAndHolidayCategoryID" ClientIDMode="Static"
                                        runat="server" ValidationGroup="HRWorkingDayEntity">
                                    </asp:DropDownList>
                                    <%--<asp:DropDownList ID="ddlAttendanceLeaveAndHolidayCategoryID" runat="server" Width="234"> </asp:DropDownList>--%>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtRemarksLV" runat="server" Text='<%# Eval("Remarks")%>' TextMode="SingleLine"></asp:TextBox>
                                </td>
                            </tr>
                        </ItemTemplate>
                        <AlternatingItemTemplate>
                            <tr class="ar" runat="server" id="_itemrow">
                                <td class="rp">
                                    &nbsp;
                                </td>
                                <td class="i" style="display: none;">
                                    <asp:Label ID="lblFiscalYearIDLV" runat="server" Text='<%# Eval("FiscalYearID")%>'></asp:Label>
                                    <asp:Label ID="lblSalarySessionIDLV" runat="server" Text='<%# Eval("SalarySessionID")%>'></asp:Label>
                                    <asp:Label ID="lblYearLV" runat="server" Text='<%# Eval("Year")%>'></asp:Label>
                                    <asp:Label ID="lblMonthLV" runat="server" Text='<%# Eval("Month")%>'></asp:Label>
                                    <asp:Label ID="lblDayLV" runat="server" Text='<%# Eval("Day")%>'></asp:Label>
                                    <asp:Label ID="lblDateLV" runat="server" Text='<%# Eval("Date") != null ? ((DateTime)Eval("Date")).ToString("dd-MM-yyyy") : ""%>'></asp:Label>
                                </td>
                                <td class="i" style="display: none;">
                                    <asp:Label ID="lblNoteIDLV" runat="server" Text='<%# Eval("Note")%>'></asp:Label>
                                </td>
                                <td class="i">
                                    <asp:Label ID="lblWorkingDayLV" runat="server" Text='<%# Eval("WorkingDay") != null ? ((DateTime)Eval("WorkingDay")).ToString("dd-MM-yyyy") : ""%>'></asp:Label>
                                </td>
                                <td class="i">
                                    <div style="display: none">
                                        <asp:Label ID="lblAttendanceLeaveAndHolidayCategoryIDLV" runat="server" Text='<%# Eval("AttendanceLeaveAndHolidayCategoryID")%>'></asp:Label></div>
                                    <asp:DropDownList ID="ddlAttendanceLeaveAndHolidayCategoryID" ClientIDMode="Static"
                                        runat="server" ValidationGroup="HRWorkingDayEntity">
                                    </asp:DropDownList>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtRemarksLV" runat="server" Text='<%# Eval("Remarks")%>' TextMode="SingleLine"></asp:TextBox>
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
            </div>
            <div class="TableRow" style="text-align: center;">
                <div class="TableFormLeble">
                    &nbsp;</div>
                <div class="TableFormContent">
                    <kti:SecureButton ID="btnSubmit" ValidationGroup="HRWorkingDayEntity" OnClick="btnSave_Click"
                        runat="server" Text="Save" UniqueKey="HRWorkingDayControl_Submit_key" />
                </div>
            </div>
            <br />
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
