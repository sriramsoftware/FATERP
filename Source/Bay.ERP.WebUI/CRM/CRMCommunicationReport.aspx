<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 30-Nov-2011, 02:42:57
--%>

<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true"
    CodeFile="CRMCommunicationReport.aspx.cs" Inherits="Bay.ERP.Web.UI.CRMCommunicationReportPage"
    Title="Bay's ERP New" Culture="auto" meta:resourcekey="PageResource1" UICulture="auto" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
    <style type="text/css">
        .style1
        {
            height: 26px;
        }
        .style2
        {
            width: 294px;
        }
        .style3
        {
            height: 26px;
            width: 294px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>
        Sales Communication Summary</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
        <%--<uc:MDCityEntity ID="ucMDCityEntity" runat="server" />--%>
        <div>
            <table style="width: 500px; border-collapse: collapse;">
                <tr>
                    <td class="style2">
                        Database:<br />
                        <asp:DropDownList ID="DropDownProcess" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1"
                            DataTextField="Name" DataValueField="ProcessCategoryID" Width="140px">
                        </asp:DropDownList>
                    </td>
                    <td>
                        Please Select Contact Person<br />
                        <asp:DropDownList ID="DropDownLeadName" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource3"
                            DataTextField="ContactFullName" DataValueField="BuyerBasicInfoID" 
                            Width="260px" onselectedindexchanged="DropDownLeadName_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="style3">
                        &nbsp;
                    </td>
                    <td class="style1">
                        &nbsp;
                    </td>
                </tr>
                <tr style="vertical-align: top">
                    <td class="style2">
                        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" BackColor="White"
                            BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="SqlDataPersonDetails"
                            ForeColor="Black" GridLines="Horizontal" HeaderText="Buyer Personal Details"
                            Height="50px" Width="366px">
                            <EditRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                            <Fields>
                                <asp:BoundField DataField="BuyerBasicInfoID" HeaderText="BuyerBasicInfoID" InsertVisible="False"
                                    ReadOnly="True" SortExpression="BuyerBasicInfoID" />
                                <asp:BoundField DataField="ContactFullName" HeaderText="ContactFullName" SortExpression="ContactFullName" />
                                <asp:BoundField DataField="MobileNo" HeaderText="MobileNo" SortExpression="MobileNo" />
                                <asp:BoundField DataField="LandPhone" HeaderText="LandPhone" SortExpression="LandPhone" />
                                <asp:BoundField DataField="PresentAddress" HeaderText="PresentAddress" SortExpression="PresentAddress" />
                                <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                                <asp:BoundField DataField="CityID" HeaderText="CityID" SortExpression="CityID" />
                                <asp:BoundField DataField="AreaNeededFrom" HeaderText="AreaNeededFrom" SortExpression="AreaNeededFrom" />
                                <asp:BoundField DataField="AreaNeededTo" HeaderText="AreaNeededTo" SortExpression="AreaNeededTo" />
                                <asp:BoundField DataField="ParkingNeeded" HeaderText="ParkingNeeded" SortExpression="ParkingNeeded" />
                                <asp:BoundField DataField="ToiletNeeded" HeaderText="ToiletNeeded" SortExpression="ToiletNeeded" />
                                <asp:BoundField DataField="UnitNeeded" HeaderText="UnitNeeded" SortExpression="UnitNeeded" />
                                <asp:BoundField DataField="LeadGeneratedByEmployeeID" HeaderText="LeadGeneratedByEmployeeID"
                                    SortExpression="LeadGeneratedByEmployeeID" />
                                <asp:BoundField DataField="LeadManagedByOneEmployeeID" HeaderText="LeadManagedByOneEmployeeID"
                                    SortExpression="LeadManagedByOneEmployeeID" />
                                <asp:BoundField DataField="CreateDate" HeaderText="CreateDate" SortExpression="CreateDate" />
                                <asp:HyperLinkField DataNavigateUrlFields="Email" DataTextField="Email" HeaderText="Email"
                                    NavigateUrl="mailto:@email" Text="Email" />
                            </Fields>
                            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                        </asp:DetailsView>
                    </td>
                    <td>
                        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True"
                            AutoGenerateColumns="False" CellPadding="4" DataSourceID="SqlDataSource2" ForeColor="Black"
                            GridLines="Horizontal" PageSize="20" Width="90%" BackColor="White" BorderColor="#CCCCCC"
                            BorderStyle="None" BorderWidth="1px">
                            <Columns>
                                <asp:BoundField DataField="CommunicationID" HeaderText="ID" ReadOnly="True" SortExpression="CommunicationID" />
                                <asp:BoundField DataField="CreateDate" HeaderText="Create Date" ReadOnly="True" SortExpression="CreateDate"
                                    DataFormatString="{0:d}" />
                                <asp:BoundField DataField="Topics" HeaderText="Topics" ReadOnly="True" SortExpression="Topics" />
                                <asp:BoundField DataField="Note" HeaderText="Details Note" ReadOnly="True" SortExpression="Note">
                                    <HeaderStyle Wrap="False" />
                                    <ItemStyle Width="80px" />
                                </asp:BoundField>
                                <asp:CheckBoxField DataField="IsIWillCall" HeaderText="Will Call" ReadOnly="True"
                                    SortExpression="IsIWillCall" />
                                <asp:BoundField DataField="NextCommunicationDate" HeaderText="Next Comm. Date" ReadOnly="True"
                                    SortExpression="NextCommunicationDate" DataFormatString="{0:d}" />
                                <asp:BoundField DataField="NextAction" HeaderText="Next Action" SortExpression="NextAction"
                                    ReadOnly="True" />
                                <asp:BoundField DataField="ContactFullName" HeaderText="Contact FullName" ReadOnly="True"
                                    SortExpression="ContactFullName" />
                                <asp:BoundField DataField="CommuicationDiscussionTypeName" HeaderText="Discussion"
                                    ReadOnly="True" SortExpression="CommuicationDiscussionTypeName" />
                                <asp:BoundField DataField="CommunicationStatusName" HeaderText="Status" ReadOnly="True"
                                    SortExpression="CommunicationStatusName" />
                                <asp:BoundField DataField="CreatedByMemberFullName" HeaderText="CreatedBy " ReadOnly="True"
                                    SortExpression="CreatedByMemberFullName" />
                            </Columns>
                            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" BorderStyle="Outset" />
                            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                            <SortedAscendingCellStyle BackColor="#F7F7F7" />
                            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                            <SortedDescendingCellStyle BackColor="#E5E5E5" />
                            <SortedDescendingHeaderStyle BackColor="#242121" />
                        </asp:GridView>
                        <div class="listContentTitle">
              <h2>Book Space List</h2>
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvCRMBuyerBookSpace" runat="server" DataSourceID="odsCRMBuyerBookSpace">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi">
                                        Project
                                    </td>
                                    <td class="hi">
                                        Project Floor Unit
                                    </td>
                                    <td class="hi">
                                        Booking Note
                                    </td>
                                    <td class="hi">
                                        Booking Status
                                    </td>
                                    <td class="hi">
                                        File
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
                                <%--<tr>
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
                                </tr>--%>
                            </table>
                        </LayoutTemplate>
                        <ItemTemplate>
                            <tr class="r">
                                <td class="rp">
                                    &nbsp;
                                </td>
                                <td class="i">
                                    <%# Eval("ProjectName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BDProjectFloorUnitProjectFloorUnitName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BookingNote")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BookingStatusName")%>
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="hypOrginalFileName" runat="server" Text="File"
                                        NavigateUrl='<%# Eval("ImageUrl")%>' Target="_blank"></asp:HyperLink>
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
                                <td class="i">
                                    <%# Eval("ProjectName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BDProjectFloorUnitProjectFloorUnitName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BookingNote")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BookingStatusName")%>
                                </td>
                              <td class="i">
                                    <asp:HyperLink ID="hypOrginalFileName" runat="server" Text="File"
                                        NavigateUrl='<%# Eval("ImageUrl")%>' Target="_blank"></asp:HyperLink>
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
                <asp:ObjectDataSource ID="odsCRMBuyerBookSpace" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.CRMBuyerBookSpace_DetailedDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsCRMBuyerBookSpace_Selecting">
                    <SelectParameters>
                        <asp:Parameter Name="startRowIndex" Type="Int32" />
                        <asp:Parameter Name="pageSize" Type="Int32" />
                        <asp:Parameter Name="sortExpression" Type="String" />
                        <asp:Parameter Name="filterExpression" Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </div>
                        <asp:Button ID="btnCommunication" runat="server" OnClick="btnCommunication_Click"
                            Text="Create Communication" Visible="False" />
                        <div >
                        <br />
                            <asp:HyperLink ID="hypCommunication" CssClass="linkButton" runat="server" Text="Create New Communication"></asp:HyperLink></div>
                    </td>
                </tr>
            </table>
        </div>
        <div>
            <br />
            <br />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ETCON %>"
                OnInserting="SqlDataSource1_Inserting" ProviderName="<%$ ConnectionStrings:ETCON.ProviderName %>"
                SelectCommand="SELECT ProcessCategoryID, Name FROM CMNProcessCategory WHERE (IsRemoved = @IsRemoved)
and ProcessCategoryID IN (8)">
                <SelectParameters>
                    <asp:Parameter DefaultValue="false" Name="IsRemoved" Type="Boolean" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:ETCON %>"
                OnInserting="SqlDataSource1_Inserting" ProviderName="<%$ ConnectionStrings:ETCON.ProviderName %>"
                SelectCommand="SELECT BuyerBasicInfoID, ContactFullName, Type FROM vw_CRMLeads WHERE (Type = @Type) Order by ContactFullName">
                <SelectParameters>
                    <asp:ControlParameter ControlID="DropDownProcess" DbType="String" DefaultValue=""
                        Name="Type" PropertyName="SelectedItem.text" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ETCON %>"
                SelectCommand="SELECT CommunicationID, CommuicationDiscussionTypeID, ProcessCategoryID, ReferenceID, DiscussionDate, CommunicateByEmployeeID, Topics, Note, IsFollowUpNeeded, IsIWillCall, IsField1, NextAction, NextCommunicationDate, CommunicationStatusID, CreatedByEmployeeID, IP, CreateDate, ContactFullName, CommuicationDiscussionTypeName, CommunicationStatusName, CreatedByMemberFullName FROM (SELECT CRMCommunication.CommunicationID, CRMCommunication.CommuicationDiscussionTypeID, CRMCommunication.ProcessCategoryID, CRMCommunication.ReferenceID, CRMCommunication.DiscussionDate, CRMCommunication.CommunicateByEmployeeID, CRMCommunication.Topics, CRMCommunication.Note, CRMCommunication.IsFollowUpNeeded, CRMCommunication.IsIWillCall, CRMCommunication.IsField1, CRMCommunication.NextAction, CRMCommunication.NextCommunicationDate, CRMCommunication.CommunicationStatusID, CRMCommunication.CreatedByEmployeeID, CRMCommunication.IP, CRMCommunication.CreateDate, CRMLandBasicInfo.ContactFullName, CRMMDCommuicationDiscussionType.Name AS CommuicationDiscussionTypeName, M1.FirstName + CASE WHEN M1.MiddleName ! = '' THEN ' ' + M1.MiddleName ELSE '' END + CASE WHEN M1.MiddleName ! = NULL THEN ' ' + M1.MiddleName ELSE '' END + ' ' + M1.LastName AS CommunicateByMemberFullName, CRMMDCommunicationStatus.Name AS CommunicationStatusName, M2.FirstName + CASE WHEN M2.MiddleName ! = '' THEN ' ' + M2.MiddleName ELSE '' END + CASE WHEN M2.MiddleName ! = NULL THEN ' ' + M2.MiddleName ELSE '' END + ' ' + M2.LastName AS CreatedByMemberFullName FROM CRMCommunication INNER JOIN CRMLandBasicInfo ON CRMCommunication.ReferenceID = CRMLandBasicInfo.LandBasicInfoID AND CRMCommunication.ProcessCategoryID = @pid LEFT OUTER JOIN CRMMDCommuicationDiscussionType ON CRMCommunication.CommuicationDiscussionTypeID = CRMMDCommuicationDiscussionType.CommuicationDiscussionTypeID LEFT OUTER JOIN HREmployee AS H1 ON CRMCommunication.CommunicateByEmployeeID = H1.EmployeeID LEFT OUTER JOIN HRMember AS M1 ON M1.MemberID = H1.MemberID LEFT OUTER JOIN CRMMDCommunicationStatus ON CRMCommunication.CommunicationStatusID = CRMMDCommunicationStatus.CommunicationStatusID LEFT OUTER JOIN HREmployee AS H2 ON CRMCommunication.CreatedByEmployeeID = H2.EmployeeID LEFT OUTER JOIN HRMember AS M2 ON M2.MemberID = H2.MemberID UNION ALL SELECT CRMCommunication_1.CommunicationID, CRMCommunication_1.CommuicationDiscussionTypeID, CRMCommunication_1.ProcessCategoryID, CRMCommunication_1.ReferenceID, CRMCommunication_1.DiscussionDate, CRMCommunication_1.CommunicateByEmployeeID, CRMCommunication_1.Topics, CRMCommunication_1.Note, CRMCommunication_1.IsFollowUpNeeded, CRMCommunication_1.IsIWillCall, CRMCommunication_1.IsField1, CRMCommunication_1.NextAction, CRMCommunication_1.NextCommunicationDate, CRMCommunication_1.CommunicationStatusID, CRMCommunication_1.CreatedByEmployeeID, CRMCommunication_1.IP, CRMCommunication_1.CreateDate, CRMBuyerBasicInfo.ContactFullName, CRMMDCommuicationDiscussionType_1.Name AS CommuicationDiscussionTypeName, M1.FirstName + CASE WHEN M1.MiddleName ! = '' THEN ' ' + M1.MiddleName ELSE '' END + CASE WHEN M1.MiddleName ! = NULL THEN ' ' + M1.MiddleName ELSE '' END + ' ' + M1.LastName AS CommunicateByMemberFullName, CRMMDCommunicationStatus_1.Name AS CommunicationStatusName, M2.FirstName + CASE WHEN M2.MiddleName ! = '' THEN ' ' + M2.MiddleName ELSE '' END + CASE WHEN M2.MiddleName ! = NULL THEN ' ' + M2.MiddleName ELSE '' END + ' ' + M2.LastName AS CreatedByMemberFullName FROM CRMCommunication AS CRMCommunication_1 INNER JOIN CRMBuyerBasicInfo ON CRMCommunication_1.ReferenceID = CRMBuyerBasicInfo.BuyerBasicInfoID AND CRMCommunication_1.ProcessCategoryID = @pid LEFT OUTER JOIN CRMMDCommuicationDiscussionType AS CRMMDCommuicationDiscussionType_1 ON CRMCommunication_1.CommuicationDiscussionTypeID = CRMMDCommuicationDiscussionType_1.CommuicationDiscussionTypeID LEFT OUTER JOIN HREmployee AS H1 ON CRMCommunication_1.CommunicateByEmployeeID = H1.EmployeeID LEFT OUTER JOIN HRMember AS M1 ON M1.MemberID = H1.MemberID LEFT OUTER JOIN CRMMDCommunicationStatus AS CRMMDCommunicationStatus_1 ON CRMCommunication_1.CommunicationStatusID = CRMMDCommunicationStatus_1.CommunicationStatusID LEFT OUTER JOIN HREmployee AS H2 ON CRMCommunication_1.CreatedByEmployeeID = H2.EmployeeID LEFT OUTER JOIN HRMember AS M2 ON M2.MemberID = H2.MemberID) AS Communication WHERE (ReferenceID = @leadId) AND (ProcessCategoryID = @pid)">
                <SelectParameters>
                    <asp:ControlParameter ControlID="DropDownProcess" Name="pid" PropertyName="SelectedValue"
                        Type="Int16" />
                    <asp:ControlParameter ControlID="DropDownLeadName" Name="leadId" PropertyName="SelectedValue"
                        DbType="Single" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:SqlDataSource ID="SqlDataPersonDetails" runat="server" ConnectionString="<%$ ConnectionStrings:ETCON %>"
                OnInserting="SqlDataSource1_Inserting" ProviderName="<%$ ConnectionStrings:ETCON.ProviderName %>"
                SelectCommand="SELECT * FROM [CRMBuyerBasicInfo] where BuyerBasicInfoID =@bid"
                DeleteCommand="DELETE FROM [CRMBuyerBasicInfo] WHERE [BuyerBasicInfoID] = @BuyerBasicInfoID"
                InsertCommand="INSERT INTO [CRMBuyerBasicInfo] ([BuyerTypeID], [ContactFullName], [MobileNo], [LandPhone], [PresentAddress], [Email], [InterestedLandLocationID], [CityID], [AreaNeededFrom], [AreaNeededTo], [ParkingNeeded], [AreaUnitID], [ToiletNeeded], [UnitNeeded], [AdvertiseWayID], [LeadGeneratedByEmployeeID], [LeadManagedByOneEmployeeID], [LeadManagedByTwoEmployeeID], [LeadConversionDate], [ProspectForProject], [Remarks], [CreatedByEmployeeID], [IP], [CreateDate]) VALUES (@BuyerTypeID, @ContactFullName, @MobileNo, @LandPhone, @PresentAddress, @Email, @InterestedLandLocationID, @CityID, @AreaNeededFrom, @AreaNeededTo, @ParkingNeeded, @AreaUnitID, @ToiletNeeded, @UnitNeeded, @AdvertiseWayID, @LeadGeneratedByEmployeeID, @LeadManagedByOneEmployeeID, @LeadManagedByTwoEmployeeID, @LeadConversionDate, @ProspectForProject, @Remarks, @CreatedByEmployeeID, @IP, @CreateDate)"
                UpdateCommand="UPDATE CRMBuyerBasicInfo SET BuyerTypeID = @BuyerTypeID, ContactFullName = @ContactFullName, MobileNo = @MobileNo, LandPhone = @LandPhone, PresentAddress = @PresentAddress, Email = @Email, InterestedLandLocationID = @InterestedLandLocationID, CityID = @CityID, AreaNeededFrom = @AreaNeededFrom, AreaNeededTo = @AreaNeededTo, ParkingNeeded = @ParkingNeeded, AreaUnitID = @AreaUnitID, ToiletNeeded = @ToiletNeeded, UnitNeeded = @UnitNeeded, AdvertiseWayID = @AdvertiseWayID, LeadGeneratedByEmployeeID = @LeadGeneratedByEmployeeID, LeadManagedByOneEmployeeID = @LeadManagedByOneEmployeeID, LeadManagedByTwoEmployeeID = @LeadManagedByTwoEmployeeID, LeadConversionDate = @LeadConversionDate, ProspectForProject = @ProspectForProject, Remarks = @Remarks, CreatedByEmployeeID = @CreatedByEmployeeID, IP = @IP, CreateDate = @CreateDate WHERE (BuyerBasicInfoID = @BuyerBasicInfoID)">
                <DeleteParameters>
                    <asp:Parameter Name="BuyerBasicInfoID" Type="Int64" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="BuyerTypeID" Type="Int64" />
                    <asp:Parameter Name="ContactFullName" Type="String" />
                    <asp:Parameter Name="MobileNo" Type="String" />
                    <asp:Parameter Name="LandPhone" Type="String" />
                    <asp:Parameter Name="PresentAddress" Type="String" />
                    <asp:Parameter Name="Email" Type="String" />
                    <asp:Parameter Name="InterestedLandLocationID" Type="Int64" />
                    <asp:Parameter Name="CityID" Type="Int64" />
                    <asp:Parameter Name="AreaNeededFrom" Type="Decimal" />
                    <asp:Parameter Name="AreaNeededTo" Type="Decimal" />
                    <asp:Parameter Name="ParkingNeeded" Type="Decimal" />
                    <asp:Parameter Name="AreaUnitID" Type="Int64" />
                    <asp:Parameter Name="ToiletNeeded" Type="Decimal" />
                    <asp:Parameter Name="UnitNeeded" Type="Decimal" />
                    <asp:Parameter Name="AdvertiseWayID" Type="Int64" />
                    <asp:Parameter Name="LeadGeneratedByEmployeeID" Type="Int64" />
                    <asp:Parameter Name="LeadManagedByOneEmployeeID" Type="Int64" />
                    <asp:Parameter Name="LeadManagedByTwoEmployeeID" Type="Int64" />
                    <asp:Parameter Name="LeadConversionDate" Type="DateTime" />
                    <asp:Parameter Name="ProspectForProject" Type="Int64" />
                    <asp:Parameter Name="Remarks" Type="String" />
                    <asp:Parameter Name="CreatedByEmployeeID" Type="Int64" />
                    <asp:Parameter Name="IP" Type="String" />
                    <asp:Parameter Name="CreateDate" Type="DateTime" />
                </InsertParameters>
                <SelectParameters>
                    <asp:ControlParameter ControlID="DropDownLeadName" Name="bid" PropertyName="SelectedValue" />
                </SelectParameters>
                <UpdateParameters>
                    <asp:ControlParameter ControlID="DetailsView1" Name="BuyerTypeID" PropertyName="SelectedValue"
                        Type="Int64" />
                    <asp:Parameter Name="ContactFullName" Type="String" />
                    <asp:Parameter Name="MobileNo" Type="String" />
                    <asp:Parameter Name="LandPhone" Type="String" />
                    <asp:Parameter Name="PresentAddress" Type="String" />
                    <asp:Parameter Name="Email" Type="String" />
                    <asp:Parameter Name="InterestedLandLocationID" Type="Int64" />
                    <asp:Parameter Name="CityID" Type="Int64" />
                    <asp:ControlParameter ControlID="DetailsView1" Name="AreaNeededFrom" PropertyName="SelectedValue"
                        Type="Decimal" />
                    <asp:Parameter Name="AreaNeededTo" Type="Decimal" />
                    <asp:Parameter Name="ParkingNeeded" Type="Decimal" />
                    <asp:Parameter Name="AreaUnitID" Type="Int64" />
                    <asp:Parameter Name="ToiletNeeded" Type="Decimal" />
                    <asp:Parameter Name="UnitNeeded" Type="Decimal" />
                    <asp:Parameter Name="AdvertiseWayID" Type="Int64" />
                    <asp:Parameter Name="LeadGeneratedByEmployeeID" Type="Int64" />
                    <asp:Parameter Name="LeadManagedByOneEmployeeID" Type="Int64" />
                    <asp:Parameter Name="LeadManagedByTwoEmployeeID" Type="Int64" />
                    <asp:Parameter Name="LeadConversionDate" Type="DateTime" />
                    <asp:Parameter Name="ProspectForProject" Type="Int64" />
                    <asp:Parameter Name="Remarks" Type="String" />
                    <asp:Parameter Name="CreatedByEmployeeID" Type="Int64" />
                    <asp:Parameter Name="IP" Type="String" />
                    <asp:Parameter Name="CreateDate" Type="DateTime" />
                    <asp:Parameter Name="BuyerBasicInfoID" Type="Int64" />
                </UpdateParameters>
            </asp:SqlDataSource>
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
