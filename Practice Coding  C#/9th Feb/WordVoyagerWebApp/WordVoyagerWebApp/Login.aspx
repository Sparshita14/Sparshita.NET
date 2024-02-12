<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WordVoyagerWebApp.WebForm1" %>
<asp:Content ID="Login" ContentPlaceHolderID="MainContent" runat="server">
   <div class="container py-5 h-100">
   <div class="row d-flex justify-content-center align-items-center h-100">
      <div class="col-12 col-md-8 col-lg-6 col-xl-5">
         <div class="card shadow-2-strong" style="border-radius: 1rem;">
            <div class="card-body p-5 text-center">
               <h3 class="mb-5">Sign in</h3>
               <form>   
                  <div class="form-outline mb-3" style="margin-right: 20px; margin-left:20px;">
                      <asp:TextBox ID="username" runat="server" placeholder="Username" TextMode="Email" OnTextChanged="username_TextChanged" CssClass="form-control"></asp:TextBox>
                  </div>
                  <div class="form-outline mb-4" style="margin-right: 20px; margin-left:20px;">
                      <asp:TextBox ID="password" runat="server" TextMode="Password" placeholder="Password" CssClass="form-control" OnTextChanged="password_TextChanged"></asp:TextBox>
                  </div>
                  <div class="row mb-4">
                     <div class="col d-flex justify-content-center">
                        <div class="form-check">
                           <input class="form-check-input" type="checkbox" value="" id="form2Example31" checked />
                           <label class="form-check-label" for="form2Example31"> Remember me </label>
                        </div>
                     </div>
                     <div class="col">
                        <a href="#!">Forgot password?</a>
                     </div>
                  </div>
                   <asp:Button ID="signin" runat="server" Text="Sign in" CssClass="btn btn-primary btn-block mb-4" OnClick="signin_Click" />
                  <div class="text-center">
                     <p>Not a member? <a href="Signup.aspx">Sign Up</a></p>
               </form>
               </div>
            </div>
         </div>
      </div>
   </div>
</asp:Content>