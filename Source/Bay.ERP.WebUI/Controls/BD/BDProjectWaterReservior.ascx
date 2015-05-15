<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 22-Jun-2013, 02:07:01
--%>




<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BDProjectWaterReservior.ascx.cs"
    Inherits="Bay.ERP.Web.UI.BDProjectWaterReserviorControl" %>

<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
           
                <div class="TableRow" style="text-align: left;" runat="server">
                    <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align:left;width:250px;">
                        Capacity Of Underground Reservior&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtCapacityOfUndergroundReservior">
                            Capacity Of Underground Reservior</label>
                        <asp:TextBox ID="txtCapacityOfUndergroundReservior" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="BDProjectWaterReserviorEntity" Width="237" />
                            <asp:DropDownList ID="ddlUndergroundReserviorUnitID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="BDProjectWaterReserviorEntity" Width="88">
                        </asp:DropDownList>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;width:250px;">
                        Capacity Of Overhead Reservior&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtCapacityOfOverheadReservior">
                            Enter Capacity Of Overhead Reservior</label>
                        <asp:TextBox ID="txtCapacityOfOverheadReservior" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="BDProjectWaterReserviorEntity" Width="237" />
                            <asp:DropDownList ID="ddlOverheadReserviorUnitID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="BDProjectWaterReserviorEntity" Width="88">
                        </asp:DropDownList>
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble" style="width:248px;">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <asp:Button ID="btnSubmit" ValidationGroup="BDProjectWaterReserviorEntity" OnClick="btnSave_Click"
                            runat="server" Text="Add" UniqueKey="BDProjectWaterReserviorControl_Submit_key" />
                        <asp:Button ID="btnClear" OnClick="btnClear_Click"
                            runat="server" Text="Clear" UniqueKey="BDProjectWaterReserviorControl_Clear_key" />
                    </div>
                </div>
                <br />
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
