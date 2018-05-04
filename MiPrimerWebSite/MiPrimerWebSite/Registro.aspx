<%@ Page Title="" Language="VB" MasterPageFile="~/loginRegistro.master" AutoEventWireup="false" CodeFile="Registro.aspx.vb" Inherits="Registro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="CSS/RegistroStyle.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Formulario" Runat="Server">
    <asp:TextBox ID="TextBoxNombre" runat="server" class= "textBox" placeholder="Ingrese su Nombre"></asp:TextBox>
    <asp:TextBox ID="TextBoxApellido" runat="server" class= "textBox" placeholder="Ingrese su Apellido"></asp:TextBox> 
    <asp:TextBox ID="TextBoxCorreo" runat="server" class= "textBox" placeholder="Ingrese su Correo"></asp:TextBox>
    <asp:TextBox ID="TextBoxContrasenia" runat="server" class= "textBox" placeholder="Contraseña"></asp:TextBox> 
     <asp:Button ID="bRegistrar" runat="server" Text="Registrar" />
     <asp:Label id="lError" runat="server" ForeColor="Red" ></asp:Label>
     <a id="aRegistro" href="Login.aspx">¿Tienes cuenta? Iniciar sesión</a>
</asp:Content>

