<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PresentationLayer._004.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" type="text/css" href="/gridView.css" media="screen" />
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label width=100% CssClass="labelstyletitle" ID="Label18" runat="server" Text="Ejercicios PDF 004"></asp:Label>
         <table>
            <tr>
                <td>
                    <div>
                        <asp:Label ID="Label1" width=100% CssClass="labelstyletitle" runat="server" Text="query33"></asp:Label>
                        <asp:GridView ID="dg33" class="myGridClass" runat="server"></asp:GridView>
                    </div>
                </td>
                <td>
                    <div>
                        <asp:Label ID="Label2" width=100% CssClass="labelstyletitle" runat="server" Text="query34"></asp:Label>
                        <asp:GridView ID="dg34" class="myGridClass" runat="server"></asp:GridView>
                    </div>
                </td>
                <td>
                    <div>
                        <asp:Label ID="Label3" width=100% CssClass="labelstyletitle" runat="server" Text="query35"></asp:Label>
                        <asp:GridView ID="dg35" class="myGridClass" runat="server"></asp:GridView>
                    </div>
                </td>
            </tr>
            <tr>
                <td >
                    <div>
                        <asp:Label ID="Label4" width=100% CssClass="labelstyletitle" runat="server" Text="query36"></asp:Label>
                        <asp:GridView ID="dg36" class="myGridClass" runat="server"></asp:GridView>
                    </div>
                </td>
                <td>
                    <div>
                        <asp:Label ID="Label5" width=100% CssClass="labelstyletitle" runat="server" Text="query37"></asp:Label>
                        <asp:GridView ID="dg37" class="myGridClass" runat="server"></asp:GridView>
                    </div>
                </td>
                <td>
                    <div>
                        <asp:Label ID="Label6" width=100% CssClass="labelstyletitle" runat="server" Text="query38"></asp:Label>
                        <asp:GridView ID="dg38" class="myGridClass" runat="server"></asp:GridView>
                    </div>
                </td>
            </tr>
            <tr>
                <td>
                    <div>
                        <asp:Label ID="Label7" width=100% CssClass="labelstyletitle" runat="server" Text="query39"></asp:Label>
                        <asp:GridView ID="dg39" class="myGridClass" runat="server"></asp:GridView>
                    </div>
                    
                </td>
                <td>
                    <div>
                        <asp:Label ID="Label8" width=100% CssClass="labelstyletitle" runat="server" Text="query40"></asp:Label>
                        <asp:GridView ID="dg40" class="myGridClass" runat="server"></asp:GridView>
                    </div>
                </td>
                <td>
                    <div>
                        <asp:Label ID="Label9" width=100% CssClass="labelstyletitle" runat="server" Text="query41"></asp:Label>
                        <asp:GridView ID="dg41" class="myGridClass" runat="server"></asp:GridView>
                    </div>
                </td>
            </tr>
            <tr>
                <td>
                    <div>
                        <asp:Label ID="Label10" width=100% CssClass="labelstyletitle" runat="server" Text="query42"></asp:Label>
                        <asp:GridView ID="dg42" class="myGridClass" runat="server"></asp:GridView>
                    </div>
                </td>
                <td>
                    <div>
                        <asp:Label ID="Label11" width=100% CssClass="labelstyletitle" runat="server" Text="query43"></asp:Label>
                        <asp:GridView ID="dg43" class="myGridClass" runat="server"></asp:GridView>
                    </div>
                </td>
               
            </tr>
         
           
        </table><br />
        <div align="center">
          <asp:Button class="bordereffect" ID="Button1" runat="server" Text="Anterior" OnClick="Button1_Click" />
      </div>
    </form>
</body>
</html>
