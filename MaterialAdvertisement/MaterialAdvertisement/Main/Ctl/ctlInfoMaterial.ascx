<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctlInfoMaterial.ascx.cs" Inherits="MaterialAdvertisement.Main.Ctl.ctlInfoMaterial" %>

<Legend>Material Information</Legend>
<table class='table table-striped'><th>Material</th><th>Material Type</th><th>Status</th><th>Date</th><th>Name</th><th>Image</th><th>Operations</th>
                                           <div class='row' style='margin-top:10px'> 
                                                <tr class='materialInfo'>
                                                <td class='materialInfo'>Material Name A</td>
                                                <td>Material Type A</td>                                               
                                                <td>10-12-2012</td>
                                                <td>Zaheer Ahmad</td>
                                                <td><i class='icon-ok'></i>Sold</td>
                                                <td><img src='../../assets/images/thumb1.jpg' alt='no img avaiable'></img></td>
                                                <td><a type='submit' href='../../Home.aspx?ctl=17'>Details</a></td>
                                                </tr>
                                                </div>"	
									       <div class='row' style='margin-top:10px'> 
                                                    <tr class='materialInfo'>
                                                    <td>Material Name A</td>
                                                    <td>Material Type A</td>                                               
                                                    <td>10-12-2012</td>
                                                    <td>Khurram Farooq</td>
                                                    <td><i class='icon-ok'></i>Sold</td>
                                                    <td><img src='../../assets/images/thumb1.jpg' alt='no img avaiable'></img></td>
                                                    <td><a type='submit' class='btn' onClick='getMaterialDetail()'>Details</a></td>
                                                    </tr>
                                                    </div></table><div class='row'><ul class='pager'>
                                                    <li class='previous'>
                                                    <a href='#' onClick=''>&larr; Older</a>
                                                    </li>
                                                    <li class='next'>
                                                    <a href='#'>Newer &rarr;</a>
                                                    </li>
                                                    </ul>
                                         </div>