<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="WordVoyagerWebApp.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
 
  <div class="container">
    <div class="row  justify-content-center align-items-center">
      <div class="col-lg-6">
        <div class="card">
          <div class="card-body py-5 px-md-5">
                <h3 class="mb-5">Sign up</h3>
            <form>
            <div class="form-outline mb-4">
                <asp:TextBox runat="server" CssClass="form-control" ID="username" OnTextChanged="onUsernameChange" required=""></asp:TextBox>
                <label class="form-label" for="form3Example3">Username</label>
              </div>
              
              <div class="form-outline mb-4">
                  <asp:TextBox ID="email" runat="server" CssClass="form-control" OnTextChanged="email_TextChanged"></asp:TextBox>
                <label class="form-label" for="form3Example3">Email address</label>
              </div>

              <!-- Password input -->
              <div class="form-outline mb-4">
                  <asp:TextBox ID="password" runat="server" CssClass="form-control" OnTextChanged="password_TextChanged"></asp:TextBox>
                <label class="form-label" for="form3Example4">Password</label>
              </div>

            <div class="text-center mb-3">
                            <label class="form-check-label" for="form2Example33"> Already a member?
                                <a href="Login.aspx">Sign</a>
                            </label>
                        </div>
             <div class="text-center">
                 <asp:Button ID="Button1" runat="server" Text="Sign up" CssClass="btn btn-primary btn-block" OnClick="Button1_Click" />btn btn-primary btn-block
             </div>           
            </form>
          </div>
        </div>
      </div>
    </div>
  </div>

    

</asp:Content>
