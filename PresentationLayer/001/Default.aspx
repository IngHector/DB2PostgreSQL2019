<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PresentationLayer.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" type="text/css" href="/gridView.css" media="screen" />
    <style type="text/css">
        .auto-style1 { 
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label width=100% CssClass="labelstyletitle" ID="Label18" runat="server" Text="Ejercicios PDF 001"></asp:Label>
        <table>
            <tr>
                <td>
                    <div>
                        <asp:Label ID="Label5" width=100% CssClass="labelstyle" runat="server" Text="query01"></asp:Label>
                        <asp:GridView ID="dg1" class="myGridClass" runat="server" OnSelectedIndexChanged="gridData_SelectedIndexChanged"/>
                    </div>
                </td>
                <td>
                    <div>
                        <asp:Label ID="Label1" width=100% CssClass="labelstyle" runat="server" Text="query02"></asp:Label>
                        <asp:GridView ID="dg2" class="myGridClass" runat="server"></asp:GridView>
                    </div>
                </td>
                <td>
                    <div>
                        <asp:Label ID="Label2" width=100% CssClass="labelstyle" runat="server" Text="query03"></asp:Label>
                        <asp:GridView ID="dg3" class="myGridClass" runat="server"></asp:GridView>
                    </div>
                </td>
            </tr>
            <tr>
                <td >
                    <div>
                        <asp:Label ID="Label3" width=100% CssClass="labelstyle" runat="server" Text="query04"></asp:Label>
                        <asp:GridView ID="dg4" class="myGridClass" runat="server"></asp:GridView>
                    </div>
                </td>
                <td>
                    <div>
                        <asp:Label ID="Label4" width=100% CssClass="labelstyle" runat="server" Text="query05"></asp:Label>
                        <asp:GridView ID="dg5" class="myGridClass" runat="server"></asp:GridView>
                    </div>
                </td>
                <td>
                    <div>
                        <asp:Label ID="Label6" width=100% CssClass="labelstyle" runat="server" Text="query06"></asp:Label>
                        <asp:GridView ID="dg6" class="myGridClass" runat="server"></asp:GridView>
                    </div>
                </td>
            </tr>
            <tr>
                <td>
                    <div>
                        <asp:Label ID="Label7" width=100% CssClass="labelstyle" runat="server" Text="query07"></asp:Label>
                        <asp:GridView ID="dg7" class="myGridClass" runat="server"></asp:GridView>
                    </div>
                </td>
                <td>
                    <div>
                        <asp:Label ID="Label8" width=100% CssClass="labelstyle" runat="server" Text="query08"></asp:Label>
                        <asp:GridView ID="dg8" class="myGridClass" runat="server"></asp:GridView>
                    </div>
                </td>
                <td>
                    <div>
                        <asp:Label ID="Label9" width=100% CssClass="labelstyle" runat="server" Text="query09"></asp:Label>
                        <asp:GridView ID="dg9" class="myGridClass" runat="server"></asp:GridView>
                    </div>
                </td>
            </tr>
            <tr>
                <td>
                    <div>
                        <asp:Label ID="Label10" width=100% CssClass="labelstyle" runat="server" Text="query10"></asp:Label>
                        <asp:GridView ID="dg10" class="myGridClass" runat="server"></asp:GridView>
                    </div>
                </td>
                <td>
                    <div>
                        <asp:Label ID="Label11" width=100% CssClass="labelstyle" runat="server" Text="query11"></asp:Label>
                        <asp:GridView ID="dg11" class="myGridClass" runat="server"></asp:GridView>
                    </div>
                </td>
                <td>
                    <div>
                        <asp:Label ID="Label12" width=100% CssClass="labelstyle" runat="server" Text="query12"></asp:Label>
                        <asp:GridView ID="dg12" class="myGridClass" runat="server"></asp:GridView>
                    </div>
                </td>
            </tr>
            <tr>
                <td>
                    <div>
                        <asp:Label ID="Label13" width=100% CssClass="labelstyle" runat="server" Text="query13"></asp:Label>
                        <asp:GridView ID="dg13" class="myGridClass" runat="server"></asp:GridView>
                    </div>
                </td>
                <td>
                    <div>
                        <asp:Label ID="Label14" width=100% CssClass="labelstyle" runat="server" Text="query14"></asp:Label>
                        <asp:GridView ID="dg14" class="myGridClass" runat="server"></asp:GridView>
                    </div>
                </td>
                <td>
                    <div>
                        <asp:Label ID="Label15" width=100% CssClass="labelstyle" runat="server" Text="query15"></asp:Label>
                        <asp:GridView ID="dg15" class="myGridClass" runat="server"></asp:GridView>
                    </div>
                </td>
            </tr>
            <tr>
                <td>
                    <div>
                        <asp:Label ID="Label16" width=100% CssClass="labelstyle" runat="server" Text="query16"></asp:Label>
                        <asp:GridView ID="dg16" class="myGridClass" runat="server"></asp:GridView>
                    </div>
                </td>
                <td>
                    <div>
                        <asp:Label ID="Label17" width=100% CssClass="labelstyle" runat="server" Text="query17"></asp:Label>
                        <asp:GridView ID="dg17" class="myGridClass" runat="server"></asp:GridView>
                    </div>
                </td>
               
            </tr>
        </table><br />
        <div align="center">
          <asp:Button class="bordereffect" ID="Button1" runat="server" Text="Siguiente" OnClick="Button1_Click" />
      </div>
    </form>
</body>
</html>
