using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Script.Services;
using System.Text;
using MaterialAdvertisement.BO;
using MaterialAdvertisement.Common;

namespace MaterialAdvertisement.WebServices
{
    /// <summary>
    /// Summary description for AdvertisementContent
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
   [ScriptService]
    public class AdvertisementContent : System.Web.Services.WebService
    {


        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string getAllMaterialContent()
        {

            StringBuilder responseString = new StringBuilder();

            responseString.Append(@"<Legend>Material Information</Legend>");
          //  responseString.Append(@"<div class='row'><div class='span1'> Material </div><div class='span2 offset1'> Material Type</div><div class='span1'> Image </div><div class='span1'></div><div class='span1'></div></div>");
            responseString.Append(@"<table class='table table-striped'><th>Material</th><th>Material Type</th><th>Status</th><th>Date</th><th>Name</th><th>Image</th><th>Operations</th>
                                           <div class='row' style='margin-top:10px'> 
                                                <tr class='materialInfo'>
                                                <td class='materialInfo'>Material Name A</td>
                                                <td>Material Type A</td>                                               
                                                <td>10-12-2012</td>
                                                <td>Zaheer Ahmad</td>
                                                <td><i class='icon-ok'></i>Sold</td>
                                                <td><a onClick='getMaterialDetail()'>Details</a></td>
                                                <td><img height='100px' width='100px' alt='no img avaiable'></img></td>
                                                </tr>
                                                </div>");

            responseString.Append(@"            <div class='row' style='margin-top:10px'> 
                                                <tr class='materialInfo'>
                                                <td>Material Name A</td>
                                                <td>Material Type A</td>                                               
                                                <td>10-12-2012</td>
                                                <td>Khurram Farooq</td>
                                                <td><i class='icon-ok'></i>Sold</td>
                                                <td><a href='#'>Details</a></td>
                                                <td><img height='100px' width='100px' alt='no img avaiable'></img></td>
                                                </tr>
                                                </div></table><div class='row'><ul class='pager'>
                                                <li class='previous'>
                                                <a onClick='getMaterialDetail()'>&larr; Older</a>
                                                </li>
                                                <li class='next'>
                                                <a href='#'>Newer &rarr;</a>
                                                </li>
                                                </ul></div>");
            ServiceResponce serviceResponce = new ServiceResponce
            {
                html = responseString.ToString(),
                serviceErrorCode = 0
            };
            string jsonString = serviceResponce.ToJSON();
            return jsonString;

        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string getMaterialDetails()
        {

            StringBuilder responceString = new StringBuilder();
            responceString.Append(@"<div class='page-header'>
            <h1>Details<small> Add Name here</small></h1>
        </div>
        <div id='sliderFrame'>
            <div id='slider'>
                        
                    <img src='assets/images/image-slider-1.jpg' alt='Welcome to jQuery Slider' />
                        
                        <img src='assets/images/image-slider-2.jpg' alt='Pure Javascript. No jQuery. No Flash.' />
                        <img src='assets/images/image-slider-3.jpg' />
                        <img src='assets/images/image-slider-4.jpg' />
            </div>
            <!--thumbnails-->
            <div id='thumbs'>
                <div class='thumb'>
                    <div class='frame'><img src='assets/images/thumb1.jpg' /></div>
                    <div class='thumb-content'><p>HTML Content</p>Thumbnails allows any HTML content</div>
                    <div style='clear:both;'></div>
                </div>
                <div class='thumb'>
                    <div class='frame'><img src='assets/images/thumb2.jpg' /></div>
                    <div class='thumb-content'><p>Customizable</p>Thumbnail style is customizable</div>
                    <div style='clear:both;'></div>
                </div>
                <div class='thumb'>
                    <div class='frame'><img src='assets/images/thumb3.jpg' /></div>
                    <div class='thumb-content'><p>Variety of Layouts</p>Just a CSS tweak.</div>
                    <div style='clear:both;'></div>
                </div>
                <div class='thumb'>
                    <div class='frame'><img src='assets/images/thumb4.jpg' /></div>
                    <div class='thumb-content'><p>Integration</p>Built-in functions for the thumbnails</div>
                    <div style='clear:both;'></div>
                </div>
            </div>

            <!--clear above float:left elements. It is required if above #slider is styled as float:left. -->
            <div style='clear:both;height:0;'></div>
        </div>
        <div class='page-header'>
            <h4>Contact Details</h4>
        </div>
        <address>
            <strong>Twitter, Inc.</strong><br>
            795 Folsom Ave, Suite 600<br>
            San Francisco, CA 94107<br>
            <abbr title='Phone'>P:</abbr> (123) 456-7890
        </address>
 
        <address>
            <strong>Full Name</strong><br>
            <a href='mailto:#'>first.last@example.com</a>
        </address>");
                          
            ServiceResponce serviceResponce = new ServiceResponce
            {
                html = responceString.ToString(),
                serviceErrorCode = 0
            };
            string jsonString = serviceResponce.ToJSON();
            return jsonString;
        }
    }
}
