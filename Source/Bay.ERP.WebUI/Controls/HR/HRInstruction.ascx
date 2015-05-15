<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 20-Dec-2013, 02:17:52
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HRInstruction.ascx.cs"
    Inherits="Bay.ERP.Web.UI.HRInstructionControl" %>
    <Style>
        #dvQuick2 {
            border-radius: 4px;
            box-shadow: 0 0 10px #CCCCCC;
            float: right;
            margin: 2px;
            padding: 5px 10px 10px;
    </Style>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div id="Div1" class="TableRow" style="text-align: left;" runat="server">
            <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
        </div>
        <div>
        <div style="float:left; width:425px;">
            <div id="dvQuick" style="width: 400px;">
                <h3>
                    Follow Steps For Current Fiscal year</h3>
                <asp:HyperLink ID="hypLeavePolicy" runat="server" NavigateUrl="~/MD/MDLeavePolicy.aspx"
                    Text="Step 1: Check Leave Policy For All Employee" Target="_blank"></asp:HyperLink><br />
                <br />
                <asp:HyperLink ID="hypLeaveAccount" runat="server" NavigateUrl="~/HR/HRMemberLeaveAccountOperation.aspx"
                    Text="Step 2: Check Leave Account for For All Employee" Target="_blank"></asp:HyperLink><br />
                <br />
                <asp:HyperLink ID="hypCreateSalary" runat="server" NavigateUrl="~/HR/HREmployeeSalaryInfoOperation.aspx"
                    Text="Step 3: Check Salary For All Employee" Target="_blank"></asp:HyperLink><br />
                <br />
                <asp:HyperLink ID="hypSalarySession" runat="server" NavigateUrl="~/MD/MDSalarySession.aspx"
                    Text="Step 4: Create Salary Session"></asp:HyperLink><br />
                <br />
            </div>
            </div>
            <div class="contentSeperator" style="min-height:200px;">
            </div>
            <div style="float:left; width:400px;">
            <div id="dvQuick2" style="width: 360px;">
                <h3>
                    Follow Steps For Session</h3>
                <asp:HyperLink ID="hypTaskCategory" runat="server" NavigateUrl="~/AC/ACFiscalyear.aspx"
                    Text="Step 1: Create Fiscal Year" Target="_blank"></asp:HyperLink><br />
                <br />
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/MD/MDSalarySession.aspx"
                    Text="Step 2: Create Salary Session"></asp:HyperLink><br />
                <br />
                <asp:HyperLink ID="hypTask" runat="server" NavigateUrl="~/HR/HRWorkingDay.aspx" Text="Step 3: Generate Working Day"
                    Target="_blank"></asp:HyperLink><br />
                <br />
                <asp:HyperLink ID="hypTaskTemplate" runat="server" NavigateUrl="~/Default.aspx" Text="Step 4: Check Leave Approval Do Approve or Not"
                    Target="_blank"></asp:HyperLink><br />
                <br />
                <asp:HyperLink ID="hypTaskSetup" runat="server" NavigateUrl="~/HR/HREmployeeMonthlyTimeSheetSummary.aspx"
                    Text="Step 5: Genereate Time Sheet" Target="_blank"></asp:HyperLink><br />
                <br />
                <asp:HyperLink ID="HyperLink2" runat="server" Text="Step 6: Genereate Salary From Salary Session List"></asp:HyperLink><br />
                <br />
            </div>
            </div>
            <div style="clear:both"></div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
