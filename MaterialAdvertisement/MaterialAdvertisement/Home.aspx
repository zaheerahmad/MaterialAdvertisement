<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="MaterialAdvertisement.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphFilterSideBar" runat="server">

    <div style="position:fixed;background-color:#f5f7fa;margin-top: 36px;">
    <legend>Filter Advertisements</legend>
    <form action="">
        <table class="table">
          <tr>
            <td>
                <label>Material Name</label>
                <input type="text" class="input-small" placeholder="Material Name"/>
            </td>
            <td>
                <label>Material Tpe</label>
                <select class="span1">
                  <option>All</option>
                  <option>Type A</option>
                  <option>Type B</option>
                  <option>Type C</option>
                  <option>Type D</option>
                </select>
            </td>
          </tr>
          <tr>
            <td>
                <label>Country</label>
                <select class="span1">
                  <option>All</option>
                  <option>United States</option>
                  <option>Pakistan</option>
                  <option>Canada</option>
                  <option>India</option>
                  <option>Srilanka</option>
                  <option>Australia</option>
                </select>
            </td>
            <td>
                <label>State/City</label>
                <select class="span1">
                  <option>All</option>
                  <option>A</option>
                  <option>B</option>
                  <option>C</option>
                  <option>D</option>
                </select>
            </td>
          </tr>
          <tr>
            <td>
                <label>Status</label>
                <select class="span1">
                  <option>All</option>
                  <option>Sold</option>
                  <option>Not Sold</option>
                </select>
            </td>
            <td>&nbsp;</td>
          </tr>
        </table>
        <table class="table">
            <tr>
                <td>
              <!--     <div id="datetimepicker1" class="input-append date">
                        <label class="control-label" for="startDate">Start Date</label>
                         
                          <input data-format="yyyy/dd/MM hh:mm:ss" value="" type="text" name="startDate"></input>
                         <span class="add-on">
                         <i data-time-icon="icon-time" data-date-icon="icon-calendar">
                         </i>
                         </span>-->
                    
                   <div class="input-append date" id="dp3" data-date="12-02-2012" data-date-format="dd-mm-yyyy">
                      <input class="span2" size="16" type="text" value="12-02-2012">
                      <span class="add-on"><i class="icon-th"></i></span>
                   </div>
                    </div>
                </td>
            </tr>
            <tr>
                <td>
                    <label>End Date</label>
                    <input data-format="yyyy/dd/MM hh:mm:ss" value="" type="text" name="startDate"></input>
                         <span class="add-on">
                         <i data-time-icon="icon-time" data-date-icon="icon-calendar">
                </td>
          </tr>
        </table>
        <div class="control-group">
        <div class="controls">
            <button type="submit" class="btn  btn-primary">Filter Result</button>
        </div>
        </div>
    </form>
    </div>
</asp:Content>
<asp:Content ID="content2" runat="server" ContentPlaceHolderID="currenContent">


&nbsp;<asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>

</asp:Content>

