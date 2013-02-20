<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctlServices.ascx.cs" Inherits="AdminSite.Controls.ctlServices" %>
<link href="~/assets/bootstrap/css/bootstrap.min.css" rel="stylesheet" media="screen"/>
<link href="~/assets/bootstrap/css/bootstrap-responsive.css" rel="stylesheet"/>

<script type="text/javascript">
    $(document).ready(function () {
        $("li#add").click(function () {
            $("li.#home").css({ "class": "active" });
        });
    });
</script>
<div class="span2" style="position:fixed">
    <ul class="nav nav-list">
      <li class="nav-header">Advertisements</li>
      <li id="home" class="active"><a href="Admin.aspx?ctl=5">Home</a></li>
      <li id="add"><a href="Admin.aspx?ctl=2">Post Ad</a></li>
      <li id="manage"><a href="Admin.aspx?ctl=3">Manage Your Ads</a></li>
    </ul>
</div>
<div class="span8">
    <div class="page-header">
      <h1>Advertisement<small> Welcome to Advertisements Control</small></h1>
    </div>
    <div class="hero-unit">
        <legend><h3>Account Summary</h3></legend>

    </div>
</div>