<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 05-Sep-2013, 01:19:45
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HREmployeeEvaluationMigration.ascx.cs"
    Inherits="Bay.ERP.Web.UI.HREmployeeEvaluationMigrationControl" %>
<style type="text/css">
   
</style>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div id="Div1" class="TableRow" style="text-align: left;" runat="server">
            <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
        </div>
        <div>
            <div style="width: 520px; float: left; min-height: 100px; border: 0px solid lightgray;
                margin: 10px; background-color: #F8F8F8;">
                <div style="border:1px solid #ccc; margin:0px 2px 0px 2px; padding:0px 2px 0px 2px; background-color:#E6F1FA;">
                <h3>Details</h3>
                </div>
                <div style="padding-left: 14px; float: left; width: 350px; padding-bottom:5px;">
                <h2>
                    <asp:Label ID="lblEmployeeName" runat="server" Text="Employee Name Here"></asp:Label></h2>
                    Employee Code&nbsp;:<asp:Label ID="lblEmployeeCode" CssClass="lblDescription" runat="server"></asp:Label><br />
                    Department&nbsp;:<asp:Label ID="lblDepartment" CssClass="lblDescription" runat="server"></asp:Label><br />
                    Designation&nbsp;:<asp:Label ID="lblDesignation" CssClass="lblDescription" runat="server"></asp:Label><br />
                    Join Date&nbsp;:<asp:Label ID="lblJoinDate" CssClass="lblDescription" runat="server"></asp:Label><br />
                    Confirm Date&nbsp;:<asp:Label ID="lblConfirmDate" CssClass="lblDescription" runat="server"></asp:Label>    
                </div>
                <div style="float: left; padding-left: 10px; padding-top: 10px; width:60px;">
                    <asp:Image ID="imgEmployeePicture" runat="server" ImageUrl="~/Images/approval_pic.JPG"
                        Width="120" />
                </div>
                <div style="clear: both;">
                </div>
            </div>
            <div style="width: 420px; float: left; min-height: 100px; border: 0px solid lightgray;
                margin: 10px; background-color: #F8F8F8;">
                <div style="border:1px solid #ccc; margin:0px 2px 0px 2px; padding:0px 2px 0px 2px; background-color:#E6F1FA;">
                <h3>Session Details</h3>
                </div>
                <div style="padding-left: 20px;" class="lblDescription">
                    Session&nbsp;:<asp:Label ID="lblSessionName" CssClass="lblDescription" runat="server"></asp:Label><br />
                    Start Date&nbsp;:<asp:Label ID="lblSessionStartDate" CssClass="lblDescription" runat="server"></asp:Label><br />
                    End Date&nbsp;:<asp:Label ID="lblSessionEndDate" CssClass="lblDescription" runat="server"></asp:Label><br />
                    Evaluation Type&nbsp;:<asp:Label ID="lblSessionEvaluationType" CssClass="lblDescription"
                        runat="server"></asp:Label><br />
                    Evaluation By&nbsp;:<asp:Label ID="lblSessionEvaluatedBy" CssClass="lblDescription"
                        runat="server"></asp:Label>
                </div>
            </div>
            <div style="clear: both;">
            </div>
            <br />
            <div>
                <div>
                    <asp:ListView ID="lvMDEvaluationCriteria" runat="server" DataSourceID="odsMDEvaluationCriteria"
                        OnItemDataBound="lvMDEvaluationCriteria_ItemDataBound">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr runat="server" id="itemPlaceholder">
                                </tr>
                                <tr>
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
                            <tr class="rf">
                                <div id="dvQuick">
                                    <div style="margin: 10px; border: 0px solid gray; width: 130px; float: right; min-height: 180px;">
                                        <div style="padding: 5px;">
                                            <b>
                                                <%# Eval("EvaluationCriteriaCategoryName")%></b>&nbsp;|<%# Eval("QuestionOrderInDisplay")%>
                                        </div>
                                        <div style="padding: 5px;">
                                            <asp:HyperLink ID="hypImage" runat="server" NavigateUrl='<%# Eval("ImageUrl")%>'
                                                Target="_blank">
                                                <asp:Image ID="imgImageUrl" ImageUrl='<%# Eval("ImageUrl")%>' runat="server"
                                                    Width="124" />
                                            </asp:HyperLink>
                                        </div>
                                    </div>
                                    <div style="margin: 10px; border: 0px solid gray; width: 890px; float: left; min-height: 180px;">
                                        <asp:Image ID="imgEmployeePicture" runat="server" ImageUrl="~/Images/HRQuestion.png"
                                            Height="16" Width="16" />
                                        <asp:Label ID="lblQuestionLV" runat="server" CssClass="lblQuestion" Text='<%# Eval("Question")%>'></asp:Label></b><%# Eval("PointInThisQuestion")%><br />
                                        <br />
                                        <div style="border:1px solid #ccc; margin:0px 2px 0px 2px; padding:0px 2px 0px 2px; background-color:#ffe; width:90%;">
                                  <asp:Label ID="lblDescriptionLV" runat="server" CssClass="lblDescription" Text='<%# Eval("Description")%>'></asp:Label><br />
                                    </div>
                                        <br />
                                        <br />
                                        <div style="width:750px; float:left; padding-left:10px;">
                                        <asp:Panel ID="pnlDropdownAnswer" runat="server">
                                        <b>Answer&nbsp;&nbsp;&nbsp;&nbsp;:&nbsp;&nbsp;</b>
                                        <asp:DropDownList ID="ddlAnswerScaleID" CssClass="ktiSelect"
                                            ClientIDMode="Static" runat="server" Width="400">
                                        </asp:DropDownList>
                                        </asp:Panel>
                                        <br />
                                        <div style="float:left;">
                                        <b>Remarks&nbsp;&nbsp;&nbsp;:&nbsp;&nbsp;</b>
                                        </div>
                                        <div class="TableFormContent waterMarkContainer" style=" float:left;">
                                            <label class="watermarkLabel" for="txtRemarksLV">
                                                Enter Remarks</label>
                                            <asp:TextBox ID="txtRemarksLV" TextMode="MultiLine" CssClass="ktiTextArea" Width="645"
                                                Height="70" ClientIDMode="Static" runat="server" ValidationGroup="REQRequisitionEntity" />
                                        </div>
                                        </div>
                                        
                                          <div id= "answer_given" style="padding-left:91px; border:0px solid yellow; min-height:10px; width:50%; clear:both;">
                                          <asp:Panel ID="pnlEmployeeAnswer" runat="server" Visible="false">
                                          <div style="border:1px solid #ccc; margin:0px 2px 0px 2px; padding:0px 2px 0px 2px; background-color:#ffe;">
                                          <p style="font-weight:bold; text-decoration:underline; font-size:12px;">Employee Answer</p>
                                    <asp:Label ID="lblEmployeeAnswer" runat="server" CssClass="lblDescription"></asp:Label><br />
                                    <asp:Label ID="lblEmployeeRemarks" runat="server" CssClass="lblDescription"></asp:Label>
                                    </div>
                                    </asp:Panel>
                                    </div>
                                    <div style="clear:both;"></div>
                                    </div>
                                    <div style="clear: both;">
                                    </div>
                                </div>
                                <td style="display: none;">
                                    <asp:Label ID="lblEvaluationCriteriaCategoryIDLV" runat="server" Text='<%# Eval("EvaluationCriteriaCategoryID")%>'></asp:Label>
                                    <asp:Label ID="lblEmployeeEvaluationResultIDLV" runat="server" Text='<%# Eval("EmployeeEvaluationResultID")%>'></asp:Label>
                                    <asp:Label ID="lblEmployeeCodeLV" runat="server" Text='<%# Eval("EmployeeCode")%>'></asp:Label>
                                    <asp:Label ID="lblEmployeeIDLV" runat="server" Text='<%# Eval("EmployeeID")%>'></asp:Label>
                                    <asp:Label ID="lblSupervisorEmployeeIDLV" runat="server" Text='<%# Eval("SupervisorEmployeeID")%>'></asp:Label>
                                    <asp:Label ID="lblSupervisorFullNameLV" runat="server" Text='<%# Eval("SupervisorFullName")%>'></asp:Label>
                                    <asp:Label ID="lblSupervisorEmployeeCodeLV" runat="server" Text='<%# Eval("SupervisorEmployeeCode")%>'></asp:Label>
                                    <asp:Label ID="lblSupervisorEmployeeDepartmentNameLV" runat="server" Text='<%# Eval("SupervisorEmployeeDepartmentName")%>'></asp:Label>
                                    <asp:Label ID="lblSupervisorEmployeeLevelLV" runat="server" Text='<%# Eval("SupervisorEmployeeLevel")%>'></asp:Label>
                                    <asp:Label ID="lblEmployeeFullNameLV" runat="server" Text='<%# Eval("EmployeeFullName")%>'></asp:Label>
                                    <asp:Label ID="lblEmployeeEvaluationIDLV" runat="server" Text='<%# Eval("EmployeeEvaluationID")%>'></asp:Label>
                                    <asp:Label ID="lblEvaluationCriteriaIDLV" runat="server" Text='<%# Eval("EvaluationCriteriaID")%>'></asp:Label>
                                    <asp:TextBox ID="txtEmployeeResultLV" Text='<%# Eval("EmployeeResult")%>' runat="server"></asp:TextBox>
                                    <asp:TextBox ID="txtSupervisorResultLV" Text='<%# Eval("Result")%>' runat="server"></asp:TextBox>
                                </td>
                                <div>
                                    <div class="TableRow" style="width: 100;">
                                        <div class="TableFormLeble" style="text-align: right;">
                                            &nbsp;
                                        </div>
                                    </div>
                                </div>
                            </tr>
                        </ItemTemplate>
                        <EmptyDataTemplate>
                            <div class="edr">
                                No Questions available for this session
                            </div>
                        </EmptyDataTemplate>
                    </asp:ListView>
                </div>
                <asp:ObjectDataSource ID="odsMDEvaluationCriteria" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.HREmployeeEvaluationSession_CustomDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsMDEvaluationCriteria_Selecting">
                    <SelectParameters>
                        <asp:Parameter Name="startRowIndex" Type="Int32" />
                        <asp:Parameter Name="pageSize" Type="Int32" />
                        <asp:Parameter Name="sortExpression" Type="String" />
                        <asp:Parameter Name="filterExpression" Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </div>
            <br />
            <br />
            <div style="text-align: left;">
                <asp:Label ID="lblFormLock" runat="server" Text="Note: The Form has been Locked, no information can be changed."
                    CssClass="msgLock"></asp:Label>
                <asp:Button ID="btnSubmit" runat="server" CssClass="btnSubmit" Text="Submit" OnClick="btnSubmit_Click" Visible="false" />
                <div class="markDisplay">
                    <b>Supervisor</b>
                    <div class="ttime">
                        <asp:Label ID="lblSupervisorMarks" runat="server"></asp:Label></div>
                </div>
                <div class="markDisplay">
                    <b>Self Score</b>
                    <div class="ttime">
                        <asp:Label ID="lblMyMarks" runat="server"></asp:Label></div>
                </div>
                <div style="clear: both;">
                </div>
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
