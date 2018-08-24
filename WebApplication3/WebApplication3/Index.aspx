<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebApplication3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:GridView ID="gdvContato" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:TemplateField HeaderText="ID" >
                    <EditItemTemplate>
                        <asp:Label ID="lblID" runat="server" Text='<%# Bind("id") %>'></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblID" runat="server" Text='<%# Bind("id") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Nome">
                    <EditItemTemplate>
                        <asp:Label ID="lblNome" runat="server" Text='<%# Bind("nome") %>'></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:TextBox ID="txtNome" runat="server" Text='<%# Bind("nome") %>'></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                  <asp:TemplateField HeaderText="Telefone">
                    <EditItemTemplate>
                        <asp:Label ID="lblFone" runat="server" Text='<%# Bind("fone") %>'></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:TextBox ID="txtFone" runat="server" Text='<%# Bind("fone") %>'></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                  <asp:TemplateField HeaderText="E-Mail">
                    <EditItemTemplate>
                        <asp:Label ID="lblEmail" runat="server" Text='<%# Bind("email") %>'></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:TextBox ID="txtEmail" runat="server" Text='<%# Bind("email") %>'></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <EditItemTemplate>
                        <asp:Button ID="btnSalvar" runat="server"  Text="Salvar"  CommandName="Update" />
                        <asp:Button ID="btnCancelar" runat="server"  Text="Cancelar"  CommandName="Cancel" />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Button ID="btnEditar" runat="server"  Text="Editar"  CommandName="Edit" />
                        <asp:Button ID="btnExcluir" runat="server"  Text="Excluir"  CommandName="Delete" />
                    </ItemTemplate>
                </asp:TemplateField>


            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
