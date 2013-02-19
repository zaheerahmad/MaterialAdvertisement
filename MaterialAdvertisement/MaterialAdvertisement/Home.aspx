<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="MaterialAdvertisement.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphFilterSideBar" runat="server">
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
                <label>Start Date</label>
            </td>
            <td>
                <label>End Date</label>
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
        </table><br />
        <div class="control-group">
        <div class="controls">
            <button type="submit" class="btn  btn-primary">Filter Result</button>
        </div>
        </div>
    </form>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphBodyContent" runat="server">
    <legend>Welcome to Materials Advertisement WebSite</legend>
      <h1>Materials Advertisement</h1>
      <table class="table table-hover">
        <tr>
            <th>Material Name</th>
            <th>Material Type</th>
            <th>Image</th>
            <th>Posted On (Date)</th>
            <th>Posted By (Full Name)</th>
            <th>Status</th>
            <th>&nbsp;</th>
        </tr>
        <tr>
            <td>Material Name A</td>
            <td>Material Type A</td>
            <td></td>
            <td>10-12-2012</td>
            <td>Zaheer Ahmad</td>
            <td><i class="icon-ok"></i>Sold</td>
            <td><a href="#">Check Details</a></td>
        </tr>
        <tr>
            <td>Material Name B</td>
            <td>Material Type B</td>
            <td></td>
            <td>2-19-2013</td>
            <td>Khurram Farooq</td>
            <td><i class="icon-flag"></i>Not Sold</td>
            <td><a href="#">Check Details</a></td>
        </tr>
        <tr>
            <td>Material Name A</td>
            <td>Material Type A</td>
            <td></td>
            <td>10-12-2012</td>
            <td>Zaheer Ahmad</td>
            <td><i class="icon-ok"></i>Sold</td>
            <td><a href="#">Check Details</a></td>
        </tr>
        <tr>
            <td>Material Name B</td>
            <td>Material Type B</td>
            <td></td>
            <td>2-19-2013</td>
            <td>Khurram Farooq</td>
            <td><i class="icon-flag"></i>Not Sold</td>
            <td><a href="#">Check Details</a></td>
        </tr>
        <tr>
            <td>Material Name A</td>
            <td>Material Type A</td>
            <td></td>
            <td>10-12-2012</td>
            <td>Zaheer Ahmad</td>
            <td><i class="icon-ok"></i>Sold</td>
            <td><a href="#">Check Details</a></td>
        </tr>
        <tr>
            <td>Material Name B</td>
            <td>Material Type B</td>
            <td></td>
            <td>2-19-2013</td>
            <td>Khurram Farooq</td>
            <td><i class="icon-flag"></i>Not Sold</td>
            <td><a href="#">Check Details</a></td>
        </tr>
        <tr>
            <td>Material Name A</td>
            <td>Material Type A</td>
            <td></td>
            <td>10-12-2012</td>
            <td>Zaheer Ahmad</td>
            <td><i class="icon-ok"></i>Sold</td>
            <td><a href="#">Check Details</a></td>
        </tr>
        <tr>
            <td>Material Name B</td>
            <td>Material Type B</td>
            <td></td>
            <td>2-19-2013</td>
            <td>Khurram Farooq</td>
            <td><i class="icon-flag"></i>Not Sold</td>
            <td><a href="#">Check Details</a></td>
        </tr>
        <tr>
            <td>Material Name A</td>
            <td>Material Type A</td>
            <td></td>
            <td>10-12-2012</td>
            <td>Zaheer Ahmad</td>
            <td><i class="icon-ok"></i>Sold</td>
            <td><a href="#">Check Details</a></td>
        </tr>
        <tr>
            <td>Material Name B</td>
            <td>Material Type B</td>
            <td></td>
            <td>2-19-2013</td>
            <td>Khurram Farooq</td>
            <td><i class="icon-flag"></i>Not Sold</td>
            <td><a href="#">Check Details</a></td>
        </tr>
        <tr>
            <td>Material Name A</td>
            <td>Material Type A</td>
            <td></td>
            <td>10-12-2012</td>
            <td>Zaheer Ahmad</td>
            <td><i class="icon-ok"></i>Sold</td>
            <td><a href="#">Check Details</a></td>
        </tr>
        <tr>
            <td>Material Name B</td>
            <td>Material Type B</td>
            <td></td>
            <td>2-19-2013</td>
            <td>Khurram Farooq</td>
            <td><i class="icon-flag"></i>Not Sold</td>
            <td><a href="#">Check Details</a></td>
        </tr>
        <tr>
            <td>Material Name A</td>
            <td>Material Type A</td>
            <td></td>
            <td>10-12-2012</td>
            <td>Zaheer Ahmad</td>
            <td><i class="icon-ok"></i>Sold</td>
            <td><a href="#">Check Details</a></td>
        </tr>
        <tr>
            <td>Material Name B</td>
            <td>Material Type B</td>
            <td></td>
            <td>2-19-2013</td>
            <td>Khurram Farooq</td>
            <td><i class="icon-flag"></i>Not Sold</td>
            <td><a href="#">Check Details</a></td>
        </tr>
        <tr>
            <td>Material Name A</td>
            <td>Material Type A</td>
            <td></td>
            <td>10-12-2012</td>
            <td>Zaheer Ahmad</td>
            <td><i class="icon-ok"></i>Sold</td>
            <td><a href="#">Check Details</a></td>
        </tr>
        <tr>
            <td>Material Name B</td>
            <td>Material Type B</td>
            <td></td>
            <td>2-19-2013</td>
            <td>Khurram Farooq</td>
            <td><i class="icon-flag"></i>Not Sold</td>
            <td><a href="#">Check Details</a></td>
        </tr>
        <tr>
            <td>Material Name A</td>
            <td>Material Type A</td>
            <td></td>
            <td>10-12-2012</td>
            <td>Zaheer Ahmad</td>
            <td><i class="icon-ok"></i>Sold</td>
            <td><a href="#">Check Details</a></td>
        </tr>
        <tr>
            <td>Material Name B</td>
            <td>Material Type B</td>
            <td></td>
            <td>2-19-2013</td>
            <td>Khurram Farooq</td>
            <td><i class="icon-flag"></i>Not Sold</td>
            <td><a href="#">Check Details</a></td>
        </tr>
        <tr>
            <td>Material Name A</td>
            <td>Material Type A</td>
            <td></td>
            <td>10-12-2012</td>
            <td>Zaheer Ahmad</td>
            <td><i class="icon-ok"></i>Sold</td>
            <td><a href="#">Check Details</a></td>
        </tr>
        <tr>
            <td>Material Name B</td>
            <td>Material Type B</td>
            <td></td>
            <td>2-19-2013</td>
            <td>Khurram Farooq</td>
            <td><i class="icon-flag"></i>Not Sold</td>
            <td><a href="#">Check Details</a></td>
        </tr>
        <tr>
            <td>Material Name A</td>
            <td>Material Type A</td>
            <td></td>
            <td>10-12-2012</td>
            <td>Zaheer Ahmad</td>
            <td><i class="icon-ok"></i>Sold</td>
            <td><a href="#">Check Details</a></td>
        </tr>
        <tr>
            <td>Material Name B</td>
            <td>Material Type B</td>
            <td></td>
            <td>2-19-2013</td>
            <td>Khurram Farooq</td>
            <td><i class="icon-flag"></i>Not Sold</td>
            <td><a href="#">Check Details</a></td>
        </tr>
       </table>
       <ul class="pager">
          <li class="previous">
            <a href="#">&larr; Older</a>
          </li>
          <li class="next">
            <a href="#">Newer &rarr;</a>
          </li>
        </ul>
</asp:Content>
