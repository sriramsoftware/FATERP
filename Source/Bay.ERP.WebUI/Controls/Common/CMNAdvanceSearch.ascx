<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 30-Nov-2011, 02:49:46
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CMNAdvanceSearch.ascx.cs"
    Inherits="Bay.ERP.Web.UI.CMNAdvanceSearchControl" %>


    <script language="javascript" type="text/javascript">
        function BindEvents() {
            $(document).ready(function () {
                $('#<%= ddlSearchWith.ClientID %>').change(function () {
                    $('#<%= txtSearchText.ClientID %>').val("");
                    if ($('#<%= hdfDataType.ClientID %>').val() == "String") {
                        $('#<%= txtSearchText.ClientID %>').removeClass("ktiTextBox");
                        $('#<%= txtSearchText.ClientID %>').addClass("ktiNumberTextBox");
                    }
                    else {
                        $('#<%= txtSearchText.ClientID %>').removeClass();
                        $('#<%= txtSearchText.ClientID %>').addClass("ktiTextBox");
                    }
                    //                    $('#<%= txtSearchText.ClientID %>').addClass("ktiDateTextBox");
                    alert($('#<%= hdfDataType.ClientID %>').val());
                });
            });
        }
</script>

<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <script type="text/javascript">
            Sys.Application.add_load(BindEvents);
        </script>
        <asp:HiddenField ID="hdfDataType" runat="server" Value="0" ClientIDMode="Static" />
        <div style="visibility: visible;">
            <div>
                <div class="TableRow" style="text-align: left;" runat="server">
                    <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble">
                        Search With&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlSearchWith" CssClass="ktiSelect" ClientIDMode="Static" runat="server" AutoPostBack="true"
                            Width="236" OnSelectedIndexChanged="ddlSearchWith_SelectedIndexChanged">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble">
                        Search Criteria&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlSearchCriteria" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" Width="236">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble">
                        Search Text&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtSearchText" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revSearchTextDateTime" runat="server" ControlToValidate="txtSearchText"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"></asp:RegularExpressionValidator>
                        <asp:RangeValidator ID="rvSearchTextInt" runat="server" ControlToValidate="txtSearchText"
                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136)"
                            MinimumValue="-2147483648" MaximumValue="2147483647" Type="Integer" ValidationGroup="BDProjectFloorEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSearch" OnClick="btnSearch_Click" runat="server" Text="Search"
                            ValidationGroup="cMNAdvanceSearchEntity" UniqueKey="CMNAdvanceSearchControl_Search_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Reset"
                            UniqueKey="CMNAdvanceSearchControl_Clear_key" />
                    </div>
                </div>
                <br />
                <div class="listContentTitle">
                    <asp:label ID="lblSearch" Text="Search Result" runat="server" Visible="false"></asp:label>
                </div>
                <div>
                    <div class="lv-c" style="display:none;">
                        <asp:ListView ID="lvCMNAdvanceSearch" runat="server" OnItemDataBound="lvCMNAdvanceSearch_ItemDataBound" >
                            <ItemTemplate>
                                <tr>
                                    <asp:PlaceHolder ID="plhCommon" runat="server" />
                                </tr>
                            </ItemTemplate>
                        </asp:ListView>
                    </div>
                    <div>
                        <asp:GridView ID="grvCMNAdvanceSearch" runat="server" AllowPaging="True" 
                            CellPadding="4" ForeColor="#333333" GridLines="None" PageSize="50">
                            <AlternatingRowStyle BackColor="White" />
                            <EditRowStyle BackColor="#2461BF" />
                            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#EFF3FB" />
                            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#F5F7FB" />
                            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                            <SortedDescendingCellStyle BackColor="#E9EBEF" />
                            <SortedDescendingHeaderStyle BackColor="#4870BE" />
                        </asp:GridView>
                    </div>
                </div>
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
