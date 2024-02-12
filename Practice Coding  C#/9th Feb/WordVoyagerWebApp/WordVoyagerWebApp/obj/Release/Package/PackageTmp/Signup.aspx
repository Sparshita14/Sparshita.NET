<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="WordVoyagerWebApp.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="card mx-2 mx-md-3 shadow-5-strong">
    <div class="card-body py-4 px-md-4">

      <div class="row d-flex justify-content-center">
        <div class="col-lg-8">
          <h3 class="fw-bold mb-5 text-center">Sign up now</h3>
          <form>
            <div class="row">
              <div class="col-md-6 mb-4">
                <div class="form-outline">
                  <input type="text" id="form3Example1" class="form-control" />
                  <label class="form-label" for="form3Example1">First name</label>
                </div>
              </div>
              <div class="col-md-6 mb-4">
                <div class="form-outline">
                  <input type="text" id="form3Example2" class="form-control" />
                  <label class="form-label" for="form3Example2">Last name</label>
                </div>
              </div>
            </div>
            <div class="row">
                  <div class="col-md-6 mb-4">
                    <div class="form-outline">
                      <input type="text" id="" class="form-control" />
                      <label class="form-label" for="form3Example1">Email</label>
                    </div>
                  </div>
                  <div class="col-md-6 mb-4">
                    <div class="form-outline">
                      <input type="password" id="" class="form-control" />
                      <label class="form-label" for="form3Example2">Password</label>
                    </div>
                  </div>
            </div>
            
             <div class="text-center mb-3">
                            <label class="form-check-label" for="form2Example33"> Already a member?
                                <a href="Login.aspx">Sign</a>
                            </label>
                        </div>
                       <div class="text-center"> <!-- Centering div for the button -->
                            <button type="submit" class="btn btn-primary btn-block">
                                Sign up
                            </button>
                        </div>
            
          </form>
        </div>
      </div>
    </div>
        </div>
    

</asp:Content>
