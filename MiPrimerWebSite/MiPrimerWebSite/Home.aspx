<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Home.aspx.vb" Inherits="Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="JavaScript/HomeScript.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="styleHeets" Runat="Server">
    <link rel="stylesheet" href="CSS/HomeStyle.css" type="text/css" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Body" Runat="Server">
    <div id="jumboTronPostear">
         <h4>Nuevo post</h4>
         <textarea id="tPostear" placeholder="Que estas pensando?..."></textarea>
         <button id="addPost">Publicar</button>
         <a href="#openModal">Lanzar el modal</a>
    </div>
 <!--<div id="openModal" class="modalDialog">
	<div>
		<a href="#close" title="Close" class="close">X</a>
    <div>
         <h4>Nuevo post</h4>
            <textarea>Que estas pensando?...</textarea>
         <button>Publicar</button>
    </div>
	</div>
</div>-->
    <div id="miContenido"></div>               
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="nose" Runat="Server">
</asp:Content>
<asp:Content ID="ContentUltimo" ContentPlaceHolderID="UltimosjavaScript" runat="server">
</asp:Content>

