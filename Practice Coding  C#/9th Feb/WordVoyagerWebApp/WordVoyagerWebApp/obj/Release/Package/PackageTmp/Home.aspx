<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WordVoyagerWebApp.home" %>
<asp:Content ID="Home" ContentPlaceHolderID="MainContent" runat="server">
   <body>
      <div class="carousel-item active">
         <img src="homebg.jpg" class="d-block w-100">
         <div class="carousel-caption d-none d-md-block">
            <div class="card text-center bg-transparent">
               <div class="card-body">
                  <h1 class="card-title">Welcome to Word Voyager</h1>
                  <p class="card-text">For exciting articles and more Sign in now!!</p>
                  <div class="col">
                     <a href="Login.aspx">
                     <button runat="server" type="button" class="btn btn-outline-light">Sign</button></a>
                  </div>
               </div>
            </div>
         </div>
      </div>
   </body>
</asp:Content>