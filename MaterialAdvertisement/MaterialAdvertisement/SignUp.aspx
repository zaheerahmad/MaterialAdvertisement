<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="MaterialAdvertisement.SignUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphFilterSideBar" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphBodyContent" runat="server">
    <legend>Please Fill In the Form to Publish Your Adds</legend>
    <form class="form-horizontal" runat="server">
        <div class="alert alert-error" id="divStatusError" runat="server">
            <button type="button" class="close" data-dismiss="alert">&times;</button>
            <h4>Error!</h4>
            Bad Request Error!
        </div>
        <div class="alert alert-success" id="divStatusSuccess" runat="server">
          <button type="button" class="close" data-dismiss="alert">&times;</button>
            <h4>Success!</h4>
            Congratulations, Request Completed Successfully!
        </div>
        <div class="control-group">
        <asp:Label ID="lblFullName" runat="server" Text="Full Name" class="control-label" for="txtFullName"></asp:Label>
        
        <%--<label class="control-label" for="fullname">Full Name</label>--%>
        <div class="controls">
            <asp:TextBox ID="txtFullName" runat="server" placeholder="Full Name"></asp:TextBox>
           <%-- <input type="text" id="fullname" placeholder="Full Name">--%>
        </div>
        </div>
        <div class="control-group">
        <label class="control-label" for="username">User Name</label>
        <div class="controls">
            <input type="text" id="username" placeholder="User Name">
        </div>
        </div>
        <div class="control-group">
        <label class="control-label" for="inputEmail">Email</label>
        <div class="controls">
            <input type="text" id="inputEmail" placeholder="Email">
        </div>
        </div>
        <div class="control-group">
        <label class="control-label" for="inputPassword">Password</label>
        <div class="controls">
            <input type="password" id="inputPassword" placeholder="Password">
        </div>
        </div>
        <div class="control-group">
        <label class="control-label" for="confirmPassword">Confirm Password</label>
        <div class="controls">
            <input type="password" id="confirmPassword" placeholder="Confirm Password">
        </div>
        </div>
        <div class="control-group">
        <div class="controls">
            <button type="submit" class="btn  btn-primary">Sign Up</button>
        </div>
        </div>
    </form>
</asp:Content>
