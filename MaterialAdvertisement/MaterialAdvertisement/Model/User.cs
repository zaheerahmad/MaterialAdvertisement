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

namespace MaterialAdvertisement.Model
{
	/// <summary>
	/// Strongly-typed collection for the User class.
	/// </summary>
///ssss
	[Serializable]
	public partial class UserCollection : ActiveList<User,UserCollection>
	{	   
		public UserCollection() {}

	}

	/// <summary>
	/// This is an ActiveRecord class which wraps the tblUser table.
	/// </summary>
	[Serializable]
	public partial class User : ActiveRecord<User>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public User()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}

		
		private void InitSetDefaults() { SetDefaults(); }

		
		public User(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}

        
		public User(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}

		 
		public User(string columnName, object columnValue)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByParam(columnName,columnValue);
		}

		
		protected static void SetSQLProps() { GetTableSchema(); }

		
		#endregion
		
		#region Schema and Query Accessor	
		public static Query CreateQuery() { return new Query(Schema); }

		public static TableSchema.Table Schema
		{
			get
			{
				if (BaseSchema == null)
					SetSQLProps();
				return BaseSchema;
			}

		}

		
		private static void GetTableSchema() 
		{
			if(!IsSchemaInitialized)
			{
				//Schema declaration
				TableSchema.Table schema = new TableSchema.Table("tblUser", TableType.Table, DataService.GetInstance("csmDefaultDB"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarUserId = new TableSchema.TableColumn(schema);
				colvarUserId.ColumnName = "userId";
				colvarUserId.DataType = DbType.Int32;
				colvarUserId.MaxLength = 0;
				colvarUserId.AutoIncrement = true;
				colvarUserId.IsNullable = false;
				colvarUserId.IsPrimaryKey = true;
				colvarUserId.IsForeignKey = false;
				colvarUserId.IsReadOnly = false;
				colvarUserId.DefaultSetting = @"";
				colvarUserId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUserId);
				
				TableSchema.TableColumn colvarUserName = new TableSchema.TableColumn(schema);
				colvarUserName.ColumnName = "userName";
				colvarUserName.DataType = DbType.String;
				colvarUserName.MaxLength = 150;
				colvarUserName.AutoIncrement = false;
				colvarUserName.IsNullable = false;
				colvarUserName.IsPrimaryKey = true;
				colvarUserName.IsForeignKey = false;
				colvarUserName.IsReadOnly = false;
				colvarUserName.DefaultSetting = @"";
				colvarUserName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUserName);
				
				TableSchema.TableColumn colvarUserPassword = new TableSchema.TableColumn(schema);
				colvarUserPassword.ColumnName = "userPassword";
				colvarUserPassword.DataType = DbType.String;
				colvarUserPassword.MaxLength = 150;
				colvarUserPassword.AutoIncrement = false;
				colvarUserPassword.IsNullable = false;
				colvarUserPassword.IsPrimaryKey = false;
				colvarUserPassword.IsForeignKey = false;
				colvarUserPassword.IsReadOnly = false;
				colvarUserPassword.DefaultSetting = @"";
				colvarUserPassword.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUserPassword);
				
				TableSchema.TableColumn colvarFullName = new TableSchema.TableColumn(schema);
				colvarFullName.ColumnName = "fullName";
				colvarFullName.DataType = DbType.String;
				colvarFullName.MaxLength = 250;
				colvarFullName.AutoIncrement = false;
				colvarFullName.IsNullable = false;
				colvarFullName.IsPrimaryKey = false;
				colvarFullName.IsForeignKey = false;
				colvarFullName.IsReadOnly = false;
				colvarFullName.DefaultSetting = @"";
				colvarFullName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFullName);
				
				TableSchema.TableColumn colvarEmailAddress = new TableSchema.TableColumn(schema);
				colvarEmailAddress.ColumnName = "emailAddress";
				colvarEmailAddress.DataType = DbType.String;
				colvarEmailAddress.MaxLength = 150;
				colvarEmailAddress.AutoIncrement = false;
				colvarEmailAddress.IsNullable = false;
				colvarEmailAddress.IsPrimaryKey = false;
				colvarEmailAddress.IsForeignKey = false;
				colvarEmailAddress.IsReadOnly = false;
				colvarEmailAddress.DefaultSetting = @"";
				colvarEmailAddress.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEmailAddress);
				
				TableSchema.TableColumn colvarRole = new TableSchema.TableColumn(schema);
				colvarRole.ColumnName = "role";
				colvarRole.DataType = DbType.String;
				colvarRole.MaxLength = 150;
				colvarRole.AutoIncrement = false;
				colvarRole.IsNullable = false;
				colvarRole.IsPrimaryKey = false;
				colvarRole.IsForeignKey = false;
				colvarRole.IsReadOnly = false;
				colvarRole.DefaultSetting = @"";
				colvarRole.ForeignKeyTableName = "";
				schema.Columns.Add(colvarRole);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["csmDefaultDB"].AddSchema("tblUser",schema);
			}

		}

		#endregion
		
		#region Props
		  
		[XmlAttribute("UserId")]
		[Bindable(true)]
		public int UserId 
		{
			get { return GetColumnValue<int>(Columns.UserId); }

			set { SetColumnValue(Columns.UserId, value); }

		}

		  
		[XmlAttribute("UserName")]
		[Bindable(true)]
		public string UserName 
		{
			get { return GetColumnValue<string>(Columns.UserName); }

			set { SetColumnValue(Columns.UserName, value); }

		}

		  
		[XmlAttribute("UserPassword")]
		[Bindable(true)]
		public string UserPassword 
		{
			get { return GetColumnValue<string>(Columns.UserPassword); }

			set { SetColumnValue(Columns.UserPassword, value); }

		}

		  
		[XmlAttribute("FullName")]
		[Bindable(true)]
		public string FullName 
		{
			get { return GetColumnValue<string>(Columns.FullName); }

			set { SetColumnValue(Columns.FullName, value); }

		}

		  
		[XmlAttribute("EmailAddress")]
		[Bindable(true)]
		public string EmailAddress 
		{
			get { return GetColumnValue<string>(Columns.EmailAddress); }

			set { SetColumnValue(Columns.EmailAddress, value); }

		}

		  
		[XmlAttribute("Role")]
		[Bindable(true)]
		public string Role 
		{
			get { return GetColumnValue<string>(Columns.Role); }

			set { SetColumnValue(Columns.Role, value); }

		}

		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varUserName,string varUserPassword,string varFullName,string varEmailAddress,string varRole)
		{
			User item = new User();
			
			item.UserName = varUserName;
			
			item.UserPassword = varUserPassword;
			
			item.FullName = varFullName;
			
			item.EmailAddress = varEmailAddress;
			
			item.Role = varRole;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}

		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varUserId,string varUserName,string varUserPassword,string varFullName,string varEmailAddress,string varRole)
		{
			User item = new User();
			
				item.UserId = varUserId;
			
				item.UserName = varUserName;
			
				item.UserPassword = varUserPassword;
			
				item.FullName = varFullName;
			
				item.EmailAddress = varEmailAddress;
			
				item.Role = varRole;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}

		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn UserIdColumn
        {
            get { return Schema.Columns[0]; }

        }

        
        
        
        public static TableSchema.TableColumn UserNameColumn
        {
            get { return Schema.Columns[1]; }

        }

        
        
        
        public static TableSchema.TableColumn UserPasswordColumn
        {
            get { return Schema.Columns[2]; }

        }

        
        
        
        public static TableSchema.TableColumn FullNameColumn
        {
            get { return Schema.Columns[3]; }

        }

        
        
        
        public static TableSchema.TableColumn EmailAddressColumn
        {
            get { return Schema.Columns[4]; }

        }

        
        
        
        public static TableSchema.TableColumn RoleColumn
        {
            get { return Schema.Columns[5]; }

        }

        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string UserId = @"userId";
			 public static string UserName = @"userName";
			 public static string UserPassword = @"userPassword";
			 public static string FullName = @"fullName";
			 public static string EmailAddress = @"emailAddress";
			 public static string Role = @"role";
						
		}

		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}

}

