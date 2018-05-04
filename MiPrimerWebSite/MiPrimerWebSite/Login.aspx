<%@ Page Title="" Language="VB" MasterPageFile="~/loginRegistro.master" AutoEventWireup="false" CodeFile="Login.aspx.vb" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="CSS/LoginStyle.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Formulario" Runat="Server">
    <asp:TextBox ID="TextBoxCorreo" runat="server" class= "textBox" placeholder="Ingrese su Correo"></asp:TextBox>
    <asp:TextBox ID="TextBoxContrasenia" runat="server" class= "textBox" placeholder="Contraseña"></asp:TextBox>        
    <asp:Label id="lError" runat="server" ForeColor="Red" ></asp:Label>
    <span id="checkboxSpan">
    <asp:CheckBox ID="CheckBox1" runat="server" /><label id="labelMantenmeRegistrado">Mantenerme registrado</label>
    </span>
        <asp:Button ID="Button1" runat="server" Text="Iniciar Sesion" />
    <a href="ResetContrasena.aspx">¿Olvidaste tu contraseña?</a>
    <a id="aRegistro" href="Registro.aspx">¿Sin cuenta aun?</a>
</asp:Content>

