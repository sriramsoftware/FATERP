<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 30-Nov-2011, 02:42:57
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="BillDetailsReport.aspx.cs" Inherits="Bay.ERP.Web.UI.BillDetailsReportPage" Title="Bay's ERP New" culture="auto" meta:resourcekey="PageResource1" uiculture="auto" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>Create Test Me</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
        <%--<uc:MDCityEntity ID="ucMDCityEntity" runat="server" />--%>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:ETCON %>" 
            SelectCommand="SELECT [ProjectID], [ProjectCode], [ProjectName] FROM [BDProject] ORDER BY [ProjectCode]">
        </asp:SqlDataSource>
        <asp:SqlDataSource ID="SQLProjectDetail" runat="server" 
            ConnectionString="<%$ ConnectionStrings:ETCON %>" 
            SelectCommand="SELECT * FROM [BDProject] WHERE ([ProjectID] = @ProjectID)">
            <SelectParameters>
                <asp:ControlParameter ControlID="ddlProjectList" DefaultValue="1" 
                    Name="ProjectID" PropertyName="SelectedValue" Type="Int64" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:SqlDataSource ID="SQLMRR" runat="server" 
            ConnectionString="<%$ ConnectionStrings:ETCON %>" 
            SelectCommand="SELECT * FROM [PRMMaterialReceive] WHERE ([ProjectID] = @ProjectID)">
            <SelectParameters>
                <asp:ControlParameter ControlID="ddlProjectList" Name="ProjectID" 
                    PropertyName="SelectedValue" Type="Int64" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:SqlDataSource ID="SQLBillUploadInfo" runat="server" 
            ConnectionString="<%$ ConnectionStrings:ETCON %>" SelectCommand="select * from CMBillUploadInfo
LEFT OUTER join CMBill ON CMBillUploadInfo.BillID = CMBillUploadInfo.BillID
where CMBill .ProjectID = @ProjectID">
            <SelectParameters>
                <asp:ControlParameter ControlID="ddlProjectList" Name="ProjectID" 
                    PropertyName="SelectedValue" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:SqlDataSource ID="SQLWorkOrder" runat="server" 
            ConnectionString="<%$ ConnectionStrings:ETCON %>" SelectCommand="SELECT        PRMWorkOrder.WorkOrderNo, PRMWorkOrder.BodyTitle, PRMWorkOrder.StartDate, PRMWorkOrder.CompletionDate, 
                         REQRequisition.ProjectID
FROM            PRMWorkOrderItemMap INNER JOIN
                         REQRequisition ON PRMWorkOrderItemMap.RequisitionID = REQRequisition.RequisitionID INNER JOIN
                         PRMWorkOrder ON PRMWorkOrderItemMap.WorkOrderID = PRMWorkOrder.WorkOrderID
WHERE        (REQRequisition.ProjectID = @ProjectID)">
            <SelectParameters>
                <asp:ControlParameter ControlID="ddlProjectList" Name="ProjectID" 
                    PropertyName="SelectedValue" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:SqlDataSource ID="SQLRequisition" runat="server" 
            ConnectionString="<%$ ConnectionStrings:ETCON %>" 
            SelectCommand="SELECT REQRequisition.RequisitionID, REQRequisition.ProjectID, REQRequisition.RequisitionNo, REQRequisition.RequisitionDate, REQRequisition.Remarks, REQRequisition.RequisitionStatusID, BDProject.ProjectName, MDRequisitionStatus.Name AS RequisitionStatusName FROM REQRequisition LEFT OUTER JOIN BDProject ON REQRequisition.ProjectID = BDProject.ProjectID LEFT OUTER JOIN MDRequisitionStatus ON REQRequisition.RequisitionStatusID = MDRequisitionStatus.RequisitionStatusID WHERE (REQRequisition.ProjectID = @ProjectID)">
            <SelectParameters>
                <asp:ControlParameter ControlID="ddlProjectList" Name="ProjectID" 
                    PropertyName="SelectedValue" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:SqlDataSource ID="SQLMeasurement" runat="server" 
            ConnectionString="<%$ ConnectionStrings:ETCON %>" 
            SelectCommand="SELECT CMMeasurementBook.MeasurementBookID, CMMeasurementBook.ProjectID, CMMeasurementBook.ProjectCode, CMMeasurementBook.SupplierID, CMMeasurementBook.BillID, CMMeasurementBook.WorkOrderID, CMMeasurementBook.ItemID, CMMeasurementBook.CreateDate, BDProject.ProjectName AS BDProjectProjectName, PRMSupplier.SupplierName AS PRMSupplierSupplierName, CMBill.BillNo, PRMWorkOrder.WorkOrderNo, MDItem.ItemName FROM CMMeasurementBook LEFT OUTER JOIN BDProject ON CMMeasurementBook.ProjectID = BDProject.ProjectID LEFT OUTER JOIN PRMSupplier ON CMMeasurementBook.SupplierID = PRMSupplier.SupplierID LEFT OUTER JOIN CMBill ON CMMeasurementBook.BillID = CMBill.BillID LEFT OUTER JOIN PRMWorkOrder ON CMMeasurementBook.WorkOrderID = PRMWorkOrder.WorkOrderID LEFT OUTER JOIN MDItem ON CMMeasurementBook.ItemID = MDItem.ItemID WHERE (CMMeasurementBook.ProjectID = @ProjectID)">
            <SelectParameters>
                <asp:ControlParameter ControlID="ddlProjectList" Name="ProjectID" 
                    PropertyName="SelectedValue" />
            </SelectParameters>
        </asp:SqlDataSource>
        <br />
        <br />
        <ajaxToolkit:ComboBox ID="ComboBox1" runat="server" AutoCompleteMode="Suggest">
        </ajaxToolkit:ComboBox>
        <br />
        <br />
        <br />
        <div>
            <asp:DropDownList ID="ddlProjectList" runat="server" 
                DataSourceID="SqlDataSource1" DataTextField="ProjectName" 
                DataValueField="ProjectID" Height="26px" Width="189px" AutoPostBack="True" 
                meta:resourcekey="ddlProjectListResource1">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SQLProjectAssignPerson" runat="server" 
                ConnectionString="<%$ ConnectionStrings:ETCON %>" 
                
                SelectCommand="SELECT HREmployee.EmployeeCode, MDProjectAssignedPersonTeamRole.Name AS AssignedPersonTeamRole, HRMember.FirstName + CASE WHEN HRMember.MiddleName ! = '' THEN ' ' + HRMember.MiddleName ELSE '' END + CASE WHEN HRMember.MiddleName ! = NULL THEN ' ' + HRMember.MiddleName ELSE '' END + ' ' + HRMember.LastName AS MemberFullName, BDProjectAssignedPerson.ProjectID FROM HREmployee INNER JOIN BDProjectAssignedPerson ON HREmployee.EmployeeID = BDProjectAssignedPerson.EmployeeID INNER JOIN HRMember ON HREmployee.MemberID = HRMember.MemberID INNER JOIN MDProjectAssignedPersonTeamRole ON BDProjectAssignedPerson.ProjectAssignedPersonTeamRoleID = MDProjectAssignedPersonTeamRole.ProjectAssignedPersonTeamRoleID WHERE (BDProjectAssignedPerson.ProjectID = @ProjectID)">
                <SelectParameters>
                    <asp:ControlParameter ControlID="ddlProjectList" Name="ProjectID" 
                        PropertyName="SelectedValue" />
                </SelectParameters>
            </asp:SqlDataSource>
            <br />
            <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" 
                BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                CellPadding="4" DataKeyNames="ProjectID" DataSourceID="SQLProjectDetail" 
                ForeColor="Black" GridLines="Horizontal" Height="50px" Width="90%" 
                meta:resourcekey="DetailsView1Resource1">
                <EditRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                <Fields>
                    <asp:BoundField DataField="ProjectCode" HeaderText="ProjectCode" 
                        SortExpression="ProjectCode" meta:resourcekey="BoundFieldResource1" />
                    <asp:BoundField DataField="ProjectName" HeaderText="ProjectName" 
                        SortExpression="ProjectName" meta:resourcekey="BoundFieldResource2" />
                    <asp:BoundField DataField="LandAreaKatha" HeaderText="LandAreaKatha" 
                        SortExpression="LandAreaKatha" meta:resourcekey="BoundFieldResource3" />
                    <asp:BoundField DataField="LandAreaSft" HeaderText="LandAreaSft" 
                        SortExpression="LandAreaSft" meta:resourcekey="BoundFieldResource4" />
                    <asp:BoundField DataField="NoOfStoried" HeaderText="NoOfStoried" 
                        SortExpression="NoOfStoried" meta:resourcekey="BoundFieldResource5" />
                    <asp:BoundField DataField="NoOfBasement" HeaderText="NoOfBasement" 
                        SortExpression="NoOfBasement" meta:resourcekey="BoundFieldResource6" />
                </Fields>
                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            </asp:DetailsView>


            <br />
            <asp:GridView ID="GridView4" runat="server" AutoGenerateColumns="False" 
                DataSourceID="SQLProjectAssignPerson" BackColor="White" BorderColor="#CCCCCC" 
                BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" 
                GridLines="Horizontal" AllowSorting="True" Caption="Assigned Person" 
                meta:resourcekey="GridView4Resource1" Width="90%">
                <Columns>
                    <asp:BoundField DataField="EmployeeCode" 
                        HeaderText="EmployeeCode" 
                        SortExpression="EmployeeCode" meta:resourcekey="BoundFieldResource7" />
                    <asp:BoundField DataField="AssignedPersonTeamRole" HeaderText="AssignedPersonTeamRole" 
                        SortExpression="AssignedPersonTeamRole" 
                        meta:resourcekey="BoundFieldResource8" />
                    <asp:BoundField DataField="MemberFullName" HeaderText="MemberFullName" 
                        SortExpression="MemberFullName" ReadOnly="True" 
                        meta:resourcekey="BoundFieldResource9" />
                </Columns>
                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                <HeaderStyle Font-Bold="True" ForeColor="#333333" />
                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#242121" />
            </asp:GridView>
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                DataKeyNames="MaterialReceiveID" DataSourceID="SQLMRR" AllowSorting="True" 
                BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                Caption="MRR List" CellPadding="4" ForeColor="Black" GridLines="Horizontal" 
                Width="90%" meta:resourcekey="GridView1Resource1">
                <Columns>
                    <asp:BoundField DataField="MRRNo" HeaderText="MRRNo" SortExpression="MRRNo" 
                        meta:resourcekey="BoundFieldResource10" />
                    <asp:BoundField DataField="MRRDate" HeaderText="MRRDate"  DataFormatString="{0:dd-MM-yyyy}"
                        SortExpression="MRRDate" meta:resourcekey="BoundFieldResource11" />
                    <asp:BoundField DataField="Remarks" HeaderText="Remarks" 
                        SortExpression="Remarks" meta:resourcekey="BoundFieldResource12" />
                </Columns>
                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                <HeaderStyle BackColor="White" Font-Bold="True" ForeColor="#333333" />
                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#242121" />
            </asp:GridView>
            <br />
            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
                DataSourceID="SQLBillUploadInfo" BackColor="White" 
                BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" Caption="Bill" 
                CellPadding="4" ForeColor="Black" GridLines="Horizontal" 
                meta:resourcekey="GridView2Resource1" Width="90%">
                <Columns>
                    <asp:BoundField DataField="OriginalFileName" HeaderText="OriginalFileName" 
                        SortExpression="OriginalFileName" meta:resourcekey="BoundFieldResource13"/>
                    <asp:BoundField DataField="BillNo" HeaderText="BillNo" 
                        SortExpression="BillNo" meta:resourcekey="BoundFieldResource14" />
                    <asp:BoundField DataField="Vendor" HeaderText="Vendor" 
                        SortExpression="Vendor" meta:resourcekey="BoundFieldResource15" />
                    <asp:BoundField DataField="WorkOrderID" HeaderText="WorkOrderID" 
                        SortExpression="WorkOrderID" meta:resourcekey="BoundFieldResource16" />
                    <asp:BoundField DataField="Amount" HeaderText="Amount" 
                        SortExpression="Amount" meta:resourcekey="BoundFieldResource17" />
                    <asp:BoundField DataField="BillDate" HeaderText="BillDate" 
                        SortExpression="BillDate" meta:resourcekey="BoundFieldResource18" DataFormatString="{0:dd-MM-yyyy}" />
                </Columns>
                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                <HeaderStyle BackColor="White" Font-Bold="True" ForeColor="#333333" />
                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#242121" />
            </asp:GridView>


            <br />
            <br />
            <asp:GridView ID="GridView3" runat="server" AllowSorting="True" 
                AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" 
                BorderStyle="None" BorderWidth="1px" Caption="Work Order" CellPadding="4" 
                DataSourceID="SQLWorkOrder" ForeColor="Black" GridLines="Horizontal" 
                meta:resourcekey="GridView3Resource1" Width="90%">
                <Columns>
                    <asp:BoundField DataField="WorkOrderNo" HeaderText="WorkOrderNo" 
                        SortExpression="WorkOrderNo" meta:resourcekey="BoundFieldResource19" />
                    <asp:BoundField DataField="BodyTitle" HeaderText="BodyTitle" 
                        SortExpression="BodyTitle" meta:resourcekey="BoundFieldResource20" />
                    <asp:BoundField DataField="StartDate" HeaderText="StartDate" 
                        SortExpression="StartDate" meta:resourcekey="BoundFieldResource21" DataFormatString="{0:dd-MM-yyyy}" />
                    <asp:BoundField DataField="CompletionDate" HeaderText="CompletionDate" 
                        SortExpression="CompletionDate" meta:resourcekey="BoundFieldResource22" DataFormatString="{0:dd-MM-yyyy}" />
                </Columns>
                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                <HeaderStyle BackColor="White" Font-Bold="True" ForeColor="#333333" />
                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#242121" />
            </asp:GridView>
            <br />
            <asp:GridView ID="GridView5" runat="server" AutoGenerateColumns="False" 
                BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                Caption="Requisition" CellPadding="4" DataKeyNames="RequisitionID" 
                DataSourceID="SQLRequisition" ForeColor="Black" GridLines="Horizontal" 
                Width="90%">
                <Columns>
                    <asp:BoundField DataField="RequisitionNo" HeaderText="RequisitionNo" 
                        SortExpression="RequisitionNo" />
                    <asp:BoundField DataField="RequisitionDate" HeaderText="RequisitionDate" 
                        SortExpression="RequisitionDate" DataFormatString="{0:dd-MM-yyyy}" />
                    <asp:BoundField DataField="Remarks" HeaderText="Remarks" 
                        SortExpression="Remarks" />
                    <asp:BoundField DataField="RequisitionStatusName" 
                        HeaderText="RequisitionStatusName" SortExpression="RequisitionStatusName" />
                </Columns>
                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#242121" />
            </asp:GridView>
            <br />
            <br />
            <asp:GridView ID="GridView6" runat="server" AutoGenerateColumns="False" 
                BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                Caption="Measurement Book" CellPadding="4" DataKeyNames="MeasurementBookID" 
                DataSourceID="SQLMeasurement" ForeColor="Black" GridLines="Horizontal" 
                Width="90%">
                <Columns>
                    <asp:BoundField DataField="PRMSupplierSupplierName" 
                        HeaderText="PRMSupplierSupplierName" SortExpression="PRMSupplierSupplierName" />
                    <asp:BoundField DataField="BillNo" HeaderText="BillNo" 
                        SortExpression="BillNo" />
                    <asp:BoundField DataField="WorkOrderNo" HeaderText="WorkOrderNo" 
                        SortExpression="WorkOrderNo" />
                    <asp:BoundField DataField="ItemName" HeaderText="ItemName" 
                        SortExpression="ItemName" />
                </Columns>
                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#242121" />
            </asp:GridView>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    
    </div>
</asp:Content>
