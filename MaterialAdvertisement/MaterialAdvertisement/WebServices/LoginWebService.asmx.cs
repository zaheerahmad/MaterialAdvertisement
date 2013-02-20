using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Script.Services;
using System.Text;
using MaterialAdvertisement.Common;

namespace MaterialAdvertisement.WebServices
{
    /// <summary>
    /// Summary description for LoginWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    [ScriptService]
    public class LoginWebService : System.Web.Services.WebService
    {

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string SignInUser(string pUserName, string pPassword)
        {
            Model.User user = new Model.User("userName", pUserName);
            if (user == null || user.UserName.Equals(""))
            {
                return String.Empty;
            }
            else
            {
                if (user.UserPassword.Equals(pPassword))
                {
                    //Verified Successfully...
                    //Return UserId and Full Name in Response and Success Response
                    StringBuilder responseString = new StringBuilder();
                    string temp = @"<div class='control-group'>
                                    </div>";
                    responseString.Append(user.UserId + "|" + pUserName + "|" + user.FullName);
                    List<Person> people = new List<Person>{
                   new Person{ID = 1, name = temp, last = "Gurthie"},
                   new Person{ID = 2, name = "Bill", last = "Gates"}
                   };

                    Person p1 = new Person { name = "Khurram", last = "farooq", ID = 25 };

                    string jsonString = p1.ToJSON();
                    return jsonString;
                    //return responseString.ToString();
                }
            }
            return String.Empty;
        }
    }
}
