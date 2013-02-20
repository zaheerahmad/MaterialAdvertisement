using System; 
using System.Text; 
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration; 
using System.Xml; 
using System.Xml.Serialization;
using SubSonic; 
using SubSonic.Utilities;
using MaterialAdvertisement.Model;

namespace MaterialAdvertisement.Controller
{
    /// <summary>
    /// Controller class for tblUser
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class UserController
    {
        // Preload our schema..
        User thisSchemaLoad = new User();
        private string userName = string.Empty;
        protected string UserName
        {
            get
            {
				if (userName.Length == 0) 
				{
    				if (System.Web.HttpContext.Current != null)
    				{
						userName=System.Web.HttpContext.Current.User.Identity.Name;
					}

					else
					{
						userName=System.Threading.Thread.CurrentPrincipal.Identity.Name;
					}

				}

				return userName;
            }

        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public UserCollection FetchAll()
        {
            UserCollection coll = new UserCollection();
            Query qry = new Query(User.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public UserCollection FetchByID(object UserId)
        {
            UserCollection coll = new UserCollection().Where("userId", UserId).Load();
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public UserCollection FetchByUserName(object UserName)
        {
            UserCollection coll = new UserCollection().Where("userName", UserName).Load();
            return coll;
        }

		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public UserCollection FetchByQuery(Query qry)
        {
            UserCollection coll = new UserCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object UserId)
        {
            return (User.Delete(UserId) == 1);
        }

        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object UserId)
        {
            return (User.Destroy(UserId) == 1);
        }

        
        
        
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(int UserId,string UserName)
        {
            Query qry = new Query(User.Schema);
            qry.QueryType = QueryType.Delete;
            qry.AddWhere("UserId", UserId).AND("UserName", UserName);
            qry.Execute();
            return (true);
        }
        
       
    	
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string UserName,string UserPassword,string FullName,string EmailAddress,string Role)
	    {
		    User item = new User();
		    
            item.UserName = UserName;
            
            item.UserPassword = UserPassword;
            
            item.FullName = FullName;
            
            item.EmailAddress = EmailAddress;
            
            item.Role = Role;
            
	    
		    item.Save(UserName);
	    }

    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int UserId,string UserName,string UserPassword,string FullName,string EmailAddress,string Role)
	    {
		    User item = new User();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.UserId = UserId;
				
			item.UserName = UserName;
				
			item.UserPassword = UserPassword;
				
			item.FullName = FullName;
				
			item.EmailAddress = EmailAddress;
				
			item.Role = Role;
				
	        item.Save(UserName);
	    }

    }

}

