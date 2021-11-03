<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ProductList._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

  

    <div class="row">
        <div class="col-md-4" style="left: 19px; top: 30px; width: 1377px; height: 673px">
            <h2>Proizvodi u bazi</h2>
            <p>&nbsp;</p>
            <table class="nav-justified">
                <tr>
                    <td style="width: 59px">&nbsp;</td>
                    <td style="width: 30px">Naziv Proizvoda:</td>
                    <td class="modal-lg" style="width: 184px">
                        <asp:TextBox ID="txtDbName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 59px">&nbsp;</td>
                    <td style="width: 30px">Opis:</td>
                    <td class="modal-lg" style="width: 184px">
                        <asp:TextBox ID="txtDbDescription" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 59px">&nbsp;</td>
                    <td style="width: 30px">Kategorija</td>
                    <td class="modal-lg" style="width: 184px">
                        <asp:TextBox ID="txtDbCategory" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 59px">&nbsp;</td>
                    <td style="width: 30px">Proizvođač:</td>
                    <td class="modal-lg" style="width: 184px">
                        <asp:TextBox ID="txtDbManuf" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 59px">&nbsp;</td>
                    <td style="width: 30px">Dobavljač:</td>
                    <td class="modal-lg" style="width: 184px">
                        <asp:TextBox ID="txtDbSupplier" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 59px">&nbsp;</td>
                    <td style="width: 30px">Cijena:</td>
                    <td class="modal-lg" style="width: 184px">
                        <asp:TextBox ID="txtDbPrice" runat="server"></asp:TextBox>
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
                        <asp:Button ID="btnDbSave" runat="server" OnClick="btnDbSave_Click" Text="Sacuvaj" Width="135px" />
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
                        <asp:Button ID="btnDbUpdate" runat="server" OnClick="btnDbUpdate_Click" Text="Izmijeni" Width="135px" />
                    </td>
                </tr>
                <tr>
                    <td style="width: 59px">&nbsp;</td>
                    <td style="width: 30px">&nbsp;</td>
                    <td class="modal-lg" style="width: 184px">
                        <asp:Label ID="lblError" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="width: 59px">&nbsp;</td>
                    <td style="width: 30px">&nbsp;</td>
                    <td class="modal-lg" style="width: 184px">
                        <asp:GridView ID="gvDbList" runat="server" Height="205px" Width="648px" OnSelectedIndexChanged="gvListDb_SelectedIndexChanged" style="margin-top: 0px">
            </asp:GridView>

                    </td>
                </tr>
            </table>
            <p>&nbsp;</p>
            <p>&nbsp;</p>
           
            <p>
                
                &nbsp;</p>
        </div>
       
       
    </div>

</asp:Content>
