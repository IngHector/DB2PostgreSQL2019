<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PresentationLayer._002.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" type="text/css" href="/gridView.css" media="screen" />
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label width=100% CssClass="labelstyletitle" ID="Label18" runat="server" Text="Ejercicios PDF 002"></asp:Label>
         <table>
            <tr>
                <td>
                    <div>
                        <asp:Label ID="Label1" width=100% CssClass="labelstyle" runat="server" Text="query18"></asp:Label>
                        <asp:GridView ID="dg18" class="myGridClass" runat="server"></asp:GridView>
                    </div>
                </td>
                <td>
                    <div>
                        <asp:Label ID="Label2" width=100% CssClass="labelstyle" runat="server" Text="query19"></asp:Label>
                        <asp:GridView ID="dg19" class="myGridClass" runat="server"></asp:GridView>
                    </div>
                </td>
                <td>
                    <div>
                        <asp:Label ID="Label3" width=100% CssClass="labelstyle" runat="server" Text="query20"></asp:Label>
                        <asp:GridView ID="dg20" class="myGridClass" runat="server"></asp:GridView>
                    </div>
                </td>
            </tr>
            <tr>
                <td >
                    <div>
                        <asp:Label ID="Label4" width=100% CssClass="labelstyle" runat="server" Text="query21"></asp:Label>
                        <asp:GridView ID="dg21" class="myGridClass" runat="server"></asp:GridView>
                    </div>
                </td>
                <td>
                    <div>
                        <asp:Label ID="Label5" width=100% CssClass="labelstyle" runat="server" Text="query22"></asp:Label>
                        <asp:GridView ID="dg22" class="myGridClass" runat="server"></asp:GridView>
                    </div>
                </td>
                <td>
                    <div>
                        <asp:Label ID="Label6" width=100% CssClass="labelstyle" runat="server" Text="query23"></asp:Label>
                        <asp:GridView ID="dg23" class="myGridClass" runat="server"></asp:GridView>
                    </div>
                </td>
            </tr>
            <tr>
                <td>
                    <div>
                        <asp:Label ID="Label7" width=100% CssClass="labelstyle" runat="server" Text="query24"></asp:Label>
                        <asp:GridView ID="dg24" class="myGridClass" runat="server"></asp:GridView>
                    </div>
                </td>
                <td>
                    <div>
                        <asp:Label ID="Label8" width=100% CssClass="labelstyle" runat="server" Text="query25"></asp:Label>
                        <asp:GridView ID="dg25" class="myGridClass" runat="server"></asp:GridView>
                    </div>
                </td>
                <td>
                    <div>
                        <asp:Label ID="Label9" width=100% CssClass="labelstyle" runat="server" Text="query26"></asp:Label>
                        <asp:GridView ID="dg26" class="myGridClass" runat="server"></asp:GridView>
                    </div>
                </td>
            </tr>
            <tr>
                <td>
                    <div>
                        <asp:Label ID="Label10" width=100% CssClass="labelstyle" runat="server" Text="query27"></asp:Label>
                        <asp:GridView ID="dg27" class="myGridClass" runat="server"></asp:GridView>
                    </div>
                </td>
                <td>
                    <div>
                        <asp:Label ID="Label11" width=100% CssClass="labelstyle" runat="server" Text="query28"></asp:Label>
                        <asp:GridView ID="dg28" class="myGridClass" runat="server"></asp:GridView>
                    </div>
                </td>
                <td>
                    <div>
                        <asp:Label ID="Label12" width=100% CssClass="labelstyle" runat="server" Text="query29"></asp:Label>
                        <asp:GridView ID="dg29" class="myGridClass" runat="server"></asp:GridView>
                    </div>
                </td>
            </tr>
            <tr>
                <td>
                    <div>
                        <asp:Label ID="Label13" width=100% CssClass="labelstyle" runat="server" Text="query30"></asp:Label>
                        <asp:GridView ID="dg30" class="myGridClass" runat="server"></asp:GridView>
                    </div>
                </td>
                <td>
                    <div>
                        <asp:Label ID="Label14" width=100% CssClass="labelstyle" runat="server" Text="query31"></asp:Label>
                        <asp:GridView ID="dg31" class="myGridClass" runat="server"></asp:GridView>
                    </div>
                </td>
                <td>
                    <div>
                        <asp:Label ID="Label15" width=100% CssClass="labelstyle" runat="server" Text="query32"></asp:Label>
                        <asp:GridView ID="dg32" class="myGridClass" runat="server"></asp:GridView>
                    </div>
                </td>
            </tr>
           
        </table><br />
        <div align="center">
        <asp:Button class="bordereffect" ID="Button1" runat="server" Text="Anterior" OnClick="Button1_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button class="bordereffect" ID="Button2" runat="server" Text="Siguiente" OnClick="Button2_Click" />
    </div>
    </form>
</body>
</html>
