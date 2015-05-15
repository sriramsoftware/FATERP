<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 30-Nov-2011, 02:42:57
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="HREmployeeDesignation.aspx.cs" Inherits="Bay.ERP.Web.UI.HREmployeeDesignationPage" Title="Bay's ERP New" culture="auto" meta:resourcekey="PageResource1" uiculture="auto" %>


<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>Create Employee Designation</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
        <%--<uc:MDCityEntity ID="ucMDCityEntity" runat="server" />--%>
        <div>
            <asp:FormView ID="FormView1" runat="server" AllowPaging="True" 
                DataKeyNames="DesignationID" DataSourceID="SqlDataSource1" DefaultMode="Insert" 
                HeaderText="Please Insert New Designation" Height="169px" Width="472px">
                <EditItemTemplate>
                    DesignationID:
                    <asp:Label ID="DesignationIDLabel1" runat="server" 
                        Text='<%# Eval("DesignationID") %>' />
                    <br />
                    DepartmentID:
                    <asp:TextBox ID="DepartmentIDTextBox" runat="server" 
                        Text='<%# Bind("DepartmentID") %>' />
                    <br />
                    Name:
                    <asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
                    <br />
                    Description:
                    <asp:TextBox ID="DescriptionTextBox" runat="server" 
                        Text='<%# Bind("Description") %>' />
                    <br />
                    IsRemoved:
                    <asp:CheckBox ID="IsRemovedCheckBox" runat="server" 
                        Checked='<%# Bind("IsRemoved") %>' />
                    <br />
                    <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" 
                        CommandName="Update" Text="Update" />
                    &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" 
                        CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                </EditItemTemplate>
                <HeaderStyle BackColor="#999999" />
                <InsertItemTemplate>
                    &nbsp;<table style="width:100%;">
                        <tr>
                            <td>
                                DepartmentID:
                            </td>
                            <td>
                                <asp:DropDownList ID="DepartmentID" runat="server" 
                                    DataSourceID="SqlDataSource2" DataTextField="Name" 
                                    DataValueField="DepartmentID" 
                                    SelectedValue='<%# Bind("DepartmentID", "{0}") %>' style="margin-left: 0px">
                                </asp:DropDownList>
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                Designation:
                            </td>
                            <td>
                                <asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                Description:</td>
                            <td>
                                <asp:TextBox ID="DescriptionTextBox" runat="server" Height="47px" Rows="3" 
                                    Text='<%# Bind("Description") %>' Width="264px" />
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                IsRemoved:</td>
                            <td>
                                <asp:CheckBox ID="IsRemovedCheckBox" runat="server" 
                                    Checked='<%# Bind("IsRemoved") %>' />
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" 
                                    CommandName="Insert" CssClass="CommonButton" Text="Insert" />
                                <asp:LinkButton ID="InsertCancelButton" runat="server" BorderStyle="Solid" 
                                    BorderWidth="1px" CausesValidation="False" CommandName="Cancel" 
                                    CssClass="CommonButton" Text="Cancel" />
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                    </table>
                </InsertItemTemplate>
                <ItemTemplate>
                    DesignationID:
                    <asp:Label ID="DesignationIDLabel" runat="server" 
                        Text='<%# Eval("DesignationID") %>' />
                    <br />
                    DepartmentID:
                    <asp:Label ID="DepartmentIDLabel" runat="server" 
                        Text='<%# Bind("DepartmentID") %>' />
                    <br />
                    Name:
                    <asp:Label ID="NameLabel" runat="server" Text='<%# Bind("Name") %>' />
                    <br />
                    Description:
                    <asp:Label ID="DescriptionLabel" runat="server" 
                        Text='<%# Bind("Description") %>' />
                    <br />
                    IsRemoved:
                    <asp:CheckBox ID="IsRemovedCheckBox" runat="server" 
                        Checked='<%# Bind("IsRemoved") %>' Enabled="false" />
                    <br />
                    <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" 
                        CommandName="Edit" Text="Edit" />
                    &nbsp;<asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" 
                        CommandName="Delete" Text="Delete" />
                    &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" 
                        CommandName="New" Text="New" />
                </ItemTemplate>
            </asp:FormView>


            <br />
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
                AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" 
                DataKeyNames="DesignationID" DataSourceID="SqlDataSource1" ForeColor="#333333" 
                GridLines="None" PageSize="20" Width="90%">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                    <asp:BoundField DataField="DepartmentID" HeaderText="Dept ID" 
                        SortExpression="DepartmentID" />
                    <asp:BoundField DataField="Name" HeaderText="Designation" 
                        SortExpression="Name" />
                    <asp:BoundField DataField="Description" HeaderText="Description" 
                        SortExpression="Description" />
                    <asp:CheckBoxField DataField="IsRemoved" HeaderText="IsRemoved" 
                        SortExpression="IsRemoved" />
                </Columns>
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#646464" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#646464" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
            <br />
            <br />


            <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                ConnectionString="<%$ ConnectionStrings:ETCON %>" 
                SelectCommand="SELECT [DepartmentID], [Name] FROM [MDDepartment]">
            </asp:SqlDataSource>
            <br />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                ConnectionString="<%$ ConnectionStrings:ETCON %>" 
                DeleteCommand="DELETE FROM [MDDesignation] WHERE [DesignationID] = @DesignationID" 
                InsertCommand="INSERT INTO [MDDesignation] ([DepartmentID], [Name], [Description], [IsRemoved]) VALUES (@DepartmentID, @Name, @Description, @IsRemoved)" 
                oninserting="SqlDataSource1_Inserting" 
                ProviderName="<%$ ConnectionStrings:ETCON.ProviderName %>" 
                SelectCommand="SELECT [DesignationID], [DepartmentID], [Name], [Description], [IsRemoved] FROM [MDDesignation]" 
                UpdateCommand="UPDATE [MDDesignation] SET [DepartmentID] = @DepartmentID, [Name] = @Name, [Description] = @Description, [IsRemoved] = @IsRemoved WHERE [DesignationID] = @DesignationID">
                <DeleteParameters>
                    <asp:Parameter Name="DesignationID" Type="Int64" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="DepartmentID" Type="Int64" />
                    <asp:Parameter Name="Name" Type="String" />
                    <asp:Parameter Name="Description" Type="String" />
                    <asp:Parameter Name="IsRemoved" Type="Boolean" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="DepartmentID" Type="Int64" />
                    <asp:Parameter Name="Name" Type="String" />
                    <asp:Parameter Name="Description" Type="String" />
                    <asp:Parameter Name="IsRemoved" Type="Boolean" />
                    <asp:Parameter Name="DesignationID" Type="Int64" />
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
