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
                     <input type="email" id="" class="form-control" placeholder="Username"  />
                  </div>
                  <div class="form-outline mb-4" style="margin-right: 20px; margin-left:20px;">
                     <input type="password" id="" class="form-control" placeholder="Password"  />
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
                  <button type="button" class="btn btn-primary btn-block mb-4">Sign in</button>
                  <div class="text-center">
                     <p>Not a member? <a href="Signup.aspx">Sign Up</a></p>
               </form>
               </div>
            </div>
         </div>
      </div>
   </div>
</asp:Content>