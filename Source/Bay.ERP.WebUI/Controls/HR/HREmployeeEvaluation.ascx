<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 08-Sep-2013, 11:07:00
--%>




<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HREmployeeEvaluation.ascx.cs"
    Inherits="Bay.ERP.Web.UI.HREmployeeEvaluationControl" %>

<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
       
       <div id="Div1" class="TableRow" style="text-align: left;" runat="server">
                    <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
                </div>
                 <div class="TableRow" style="width: 100; padding-left:635px;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Filter Text&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtSearchText">
                            Type Employee Code</label>
                        <asp:TextBox ID="txtSearchText" runat="server" ClientIDMode="Static" CssClass="ktiTextBox"
                            Width="230" /><span><asp:CheckBox ID="chbxFilter" runat="server" AutoPostBack="true"
                                OnCheckedChanged="chbxFilter_CheckedChanged" Text="Filter" /></span>
                                <span ><asp:CheckBox ID="chbxShowAll" runat="server" AutoPostBack="true"
                                OnCheckedChanged="chbxShowAll_CheckedChanged" Text="Show All" /></span>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
            <div class="listContentTitle">
                Employee Evaluation List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvHREmployeeEvaluation" runat="server" DataSourceID="odsHREmployeeEvaluation" OnItemCommand="lvHREmployeeEvaluation_ItemCommand" OnItemDataBound="lvHREmployeeEvaluation_ItemDataBound">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi">
                                        Session
                                    </td>
                                    <td class="hi" style="width:120px;">
                                        Submit Date
                                    </td>
                                    <td class="hi" style="width:250px;">
                                        Supervisor
                                    </td>
                                    <td class="hi" style="width:190px;">
                                        Employee
                                    </td>
                                    <td class="hi" style="width:127px;">
                                        Info
                                    </td>
                                    <td class="hi" style="width:50px;">
                                        Links
                                    </td>
                                    <td class="hi" style="width:100px;">
                                        Date
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
                                <td class="i" style="display:none;">
                                    <asp:Label ID="lblSessionIDLV" runat="server" Text='<%# Eval("SessionID")%>'></asp:Label>
                                    <asp:Label ID="lblEmployeeIDLV" runat="server" Text='<%# Eval("EmployeeID")%>'></asp:Label>
                                    <asp:Label ID="lblSupervisorIDLV" runat="server" Text='<%# Eval("SupervisorEmployeeID")%>'></asp:Label>
                                    <%# Eval("EvaluatedByID")%>
                                    <%# Eval("EvaluationSessionStatusID")%>
                                    <%# Eval("SessionCategoryID")%>
                                    <%# Eval("EvaluationSessionCategoryName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("SessionName")%>(<%# Eval("EvaluationSessionStatusName")%>)<br />
                                    <br />
                                    <asp:HyperLink ID="hypBtnDoEvaluation" runat="server" CssClass="CommonButtonLink" Text="Do Evaluation" CommandArgument='<%#Eval("EmployeeEvaluationID")%>'/><br />
                                    <asp:HyperLink ID="hypBtnDoHREvaluation" runat="server" CssClass="CommonButtonLink" Text="Do HR Evaluation" CommandArgument='<%#Eval("EmployeeEvaluationID")%>'/><br />
                                </td>
                                
                                <td class="i">
                                    <b>Emp. Submit&nbsp;:</b><%# Eval("EmployeeSubmitDate") != null ? ((DateTime)Eval("EmployeeSubmitDate")).ToString("dd-MM-yyyy") : ""%>
                                    <b>Sup. Submmit&nbsp;:</b><%# Eval("SupervisorSubmitDate") != null ? ((DateTime)Eval("SupervisorSubmitDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <b>Supervisor&nbsp;:</b><asp:Label ID="lblSupervisor" Font-Size="12" Text='<%# Eval("SupervisorFullName")%>' runat="server"></asp:Label><br />
                                    <b>Employee Code&nbsp;:</b><%# Eval("SupervisorEmployeeCode")%><br />
                                    <b>Department&nbsp;:</b><%# Eval("SupervisorEmployeeDepartmentName")%><br />
                                    <b>Level&nbsp;:</b><%# Eval("SupervisorEmployeeLevel")%>
                                </td>
                                <td class="i">
                                    <b>Employee Name&nbsp;:</b><%# Eval("EmployeeFullName")%><br />
                                    <b>Employee Code&nbsp;:</b><%# Eval("EmployeeCode")%><br />
                                    <b>Department &nbsp;:</b><%# Eval("EmployeeDepartmentName")%><br />
                                    <b>Level&nbsp;:</b><%# Eval("EmployeeLevel")%>
                                </td>
                                 <td class="i">
                                    <asp:Label ID="lblRequestInfo" runat="server" Font-Bold="true" Font-Size="10" ForeColor="Red"></asp:Label>
                                    <asp:Label ID="lblEmployeeSubmitInfo" runat="server" Font-Bold="true" Font-Size="10" ForeColor="Green"></asp:Label>
                                    <asp:Label ID="lblSupervisorSubmitInfo" runat="server" Font-Bold="true" Font-Size="10" ForeColor="Green"></asp:Label>
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="hypReport" runat="server" CssClass="CommonButtonLink" Text="Report"/><br />
                                    <asp:HyperLink ID="hypHRReport" runat="server" CssClass="CommonButtonLink" Text="HR Report"/>
                                </td>
                                <td class="i">
                                    <b>Start&nbsp;:</b><%# Eval("StartDate") != null ? ((DateTime)Eval("StartDate")).ToString("dd-MM-yyyy") : ""%><br />
                                    <b>End&nbsp;:</b><%# Eval("EndDate") != null ? ((DateTime)Eval("EndDate")).ToString("dd-MM-yyyy") : ""%><br />
                                    <b>DeadLine&nbsp;:</b><%# Eval("DeadlineDate") != null ? ((DateTime)Eval("DeadlineDate")).ToString("dd-MM-yyyy") : ""%>
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
                               <td class="i" style="display:none;">
                                    <asp:Label ID="lblSessionIDLV" runat="server" Text='<%# Eval("SessionID")%>'></asp:Label>
                                    <asp:Label ID="lblEmployeeIDLV" runat="server" Text='<%# Eval("EmployeeID")%>'></asp:Label>
                                    <asp:Label ID="lblSupervisorIDLV" runat="server" Text='<%# Eval("SupervisorEmployeeID")%>'></asp:Label>
                                    <%# Eval("EvaluatedByID")%>
                                    <%# Eval("EvaluationSessionStatusID")%>
                                    <%# Eval("SessionCategoryID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("SessionName")%>(<%# Eval("EvaluationSessionStatusName")%>)<br /><br />
                                    <asp:HyperLink ID="hypBtnDoEvaluation" runat="server" CssClass="CommonButtonLink" Text="Do Evaluation" CommandArgument='<%#Eval("EmployeeEvaluationID")%>'/><br />
                                    <asp:HyperLink ID="hypBtnDoHREvaluation" runat="server" CssClass="CommonButtonLink" Text="Do HR Evaluation" CommandArgument='<%#Eval("EmployeeEvaluationID")%>'/><br />
                                </td>
                                <td class="i">
                                    <b>Emp. Submit&nbsp;:</b><%# Eval("EmployeeSubmitDate") != null ? ((DateTime)Eval("EmployeeSubmitDate")).ToString("dd-MM-yyyy") : ""%>
                                    <b>Sup. Submmit&nbsp;:</b><%# Eval("SupervisorSubmitDate") != null ? ((DateTime)Eval("SupervisorSubmitDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                 <td class="i">
                                    <b>Supervisor&nbsp;:</b><asp:Label ID="lblSupervisor" Font-Size="12" Text='<%# Eval("SupervisorFullName")%>' runat="server"></asp:Label><br />
                                    <b>Employee Code&nbsp;:</b><%# Eval("SupervisorEmployeeCode")%><br />
                                    <b>Department&nbsp;:</b><%# Eval("SupervisorEmployeeDepartmentName")%><br />
                                    <b>Level&nbsp;:</b><%# Eval("SupervisorEmployeeLevel")%>
                                </td>
                                <td class="i">
                                    <b>Employee Name&nbsp;:</b><%# Eval("EmployeeFullName")%><br />
                                    <b>Employee Code&nbsp;:</b><%# Eval("EmployeeCode")%><br />
                                    <b>Department &nbsp;:</b><%# Eval("EmployeeDepartmentName")%><br />
                                    <b>Level&nbsp;:</b><%# Eval("EmployeeLevel")%>
                                </td>
                                <td class="i">
                                    <asp:Label ID="lblRequestInfo" runat="server" Font-Bold="true" Font-Size="10" ForeColor="Red"></asp:Label>
                                    <asp:Label ID="lblEmployeeSubmitInfo" runat="server" Font-Bold="true" Font-Size="10" ForeColor="Green"></asp:Label>
                                    <asp:Label ID="lblSupervisorSubmitInfo" runat="server" Font-Bold="true" Font-Size="10" ForeColor="Green"></asp:Label>
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="hypReport" runat="server" CssClass="CommonButtonLink" Text="Report"/><br />
                                    <asp:HyperLink ID="hypHRReport" runat="server" CssClass="CommonButtonLink" Text="HR Report"/>
                                </td>
                                <td class="i">
                                    <b>Start&nbsp;:</b><%# Eval("StartDate") != null ? ((DateTime)Eval("StartDate")).ToString("dd-MM-yyyy") : ""%><br />
                                    <b>End&nbsp;:</b><%# Eval("EndDate") != null ? ((DateTime)Eval("EndDate")).ToString("dd-MM-yyyy") : ""%><br />
                                    <b>DeadLine&nbsp;:</b><%# Eval("DeadlineDate") != null ? ((DateTime)Eval("DeadlineDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                              <%--  <td class="i">
                                    <%# Eval("SupervisorFullName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("SupervisorEmployeeCode")%>
                                </td>
                                <td class="i">
                                    <%# Eval("SupervisorEmployeeDepartmentName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("SupervisorEmployeeLevel")%>
                                </td>
                                <td class="i">
                                    <%# Eval("EmployeeSubmitDate") != null ? ((DateTime)Eval("EmployeeSubmitDate")).ToString("mm-dd-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("SupervisorSubmitDate") != null ? ((DateTime)Eval("SupervisorSubmitDate")).ToString("mm-dd-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("CreateDate") != null ? ((DateTime)Eval("CreateDate")).ToString("mm-dd-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("EvaluatedByID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Extra")%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("EmployeeEvaluationID")%>' UniqueKey="HREmployeeEvaluation_lvHREmployeeEvaluation_Edit_key" />
                                </td>
                                <td class="i">
                            <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Employee Evaluation?')"
                                        CommandArgument='<%#Eval("EmployeeEvaluationID")%>' UniqueKey="HREmployeeEvaluation_lvHREmployeeEvaluation_Edit_key"/>
                                </td>--%>
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
                <asp:ObjectDataSource ID="odsHREmployeeEvaluation" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.HREmployeeEvaluationIndividual_CustomDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsHREmployeeEvaluation_Selecting">
                    <SelectParameters>
                        <asp:Parameter Name="startRowIndex" Type="Int32" />
                        <asp:Parameter Name="pageSize" Type="Int32" />
                        <asp:Parameter Name="sortExpression" Type="String" />
                        <asp:Parameter Name="filterExpression" Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
