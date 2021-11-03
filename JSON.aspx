<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="JSON.aspx.cs" Inherits="ProductList.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

  

    <div class="row">
        <div class="col-md-4">
            <h2>Proizvodi sacuvani u JSON fajlu</h2>
            <p>&nbsp;</p>
            <table class="nav-justified">
                <tr>
                    <td style="width: 59px">&nbsp;&nbsp;</td>
                    <td style="width: 30px">Naziv Proizvoda:</td>
                    <td class="modal-lg" style="width: 184px">
                        <asp:TextBox ID="txtJSONName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 59px">&nbsp;</td>
                    <td style="width: 30px">Opis:</td>
                    <td class="modal-lg" style="width: 184px">
                        <asp:TextBox ID="txtJSONDescription" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 59px">&nbsp;</td>
                    <td style="width: 30px">Kategorija</td>
                    <td class="modal-lg" style="width: 184px">
                        <asp:TextBox ID="txtJSONCategory" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 59px">&nbsp;</td>
                    <td style="width: 30px">Proizvođač:</td>
                    <td class="modal-lg" style="width: 184px">
                        <asp:TextBox ID="txtJSONManuf" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 59px">&nbsp;</td>
                    <td style="width: 30px">Dobavljač:</td>
                    <td class="modal-lg" style="width: 184px">
                        <asp:TextBox ID="txtJSONSupplier" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 59px">&nbsp;</td>
                    <td style="width: 30px">Cijena:</td>
                    <td class="modal-lg" style="width: 184px">
                        <asp:TextBox ID="txtJSONPrice" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 59px; height: 20px;"></td>
                    <td style="width: 30px; height: 20px;"></td>
                    <td class="modal-lg" style="width: 184px; height: 20px;"></td>
                </tr>
                <tr>
                    <td style="width: 59px; height: 20px;">&nbsp;</td>
                    <td style="width: 30px; height: 20px;">&nbsp;</td>
                    <td class="modal-lg" style="width: 184px; height: 20px;">
                        <asp:Button ID="btnJSONSave" runat="server" OnClick="btnJSONSave_Click" Text="Sacuvaj" Width="125px" />
                    </td>
                </tr>
                <tr>
                    <td style="width: 59px; height: 20px;"></td>
                    <td style="width: 30px; height: 20px;"></td>
                    <td class="modal-lg" style="width: 184px; height: 20px;"></td>
                </tr>
                <tr>
                    <td style="width: 59px">&nbsp;</td>
                    <td style="width: 30px">&nbsp;</td>
                    <td class="modal-lg" style="width: 184px">
                        <asp:Button ID="btnJSONUpdate" runat="server" Text="Izmijeni" Width="122px" OnClick="btnJSONUpdate_Click" />
                    </td>
                </tr>
                <tr>
                    <td style="width: 59px">&nbsp;</td>
                    <td style="width: 30px">&nbsp;</td>
                    <td class="modal-lg" style="width: 184px">
                        <asp:Label ID="lblError" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
            <p>
                
                <asp:TextBox ID="txtShowProduct" runat="server" Height="371px" ReadOnly="True" TextMode="MultiLine" Width="967px" style="margin-top: 61px"></asp:TextBox>
            </p>
            <p>
                
                &nbsp;</p>
        </div>
       
       
    </div>

</asp:Content>
