﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CubeAfricaDemo
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="CubeAfricaDemo")]
	public partial class DataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InserttUser(tUser instance);
    partial void UpdatetUser(tUser instance);
    partial void DeletetUser(tUser instance);
    #endregion
		
		public DataClassesDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["CubeAfricaDemoConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tUser> tUsers
		{
			get
			{
				return this.GetTable<tUser>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tUsers")]
	public partial class tUser : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _pkUserId;
		
		private string _sFirstName;
		
		private string _sLastName;
		
		private string _sCompany;
		
		private string _sEmailAddress;
		
		private string _sCellNo;
		
		private string _sWorkNo;
		
		private string _sPassword;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnpkUserIdChanging(string value);
    partial void OnpkUserIdChanged();
    partial void OnsFirstNameChanging(string value);
    partial void OnsFirstNameChanged();
    partial void OnsLastNameChanging(string value);
    partial void OnsLastNameChanged();
    partial void OnsCompanyChanging(string value);
    partial void OnsCompanyChanged();
    partial void OnsEmailAddressChanging(string value);
    partial void OnsEmailAddressChanged();
    partial void OnsCellNoChanging(string value);
    partial void OnsCellNoChanged();
    partial void OnsWorkNoChanging(string value);
    partial void OnsWorkNoChanged();
    partial void OnsPasswordChanging(string value);
    partial void OnsPasswordChanged();
    #endregion
		
		public tUser()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pkUserId", DbType="VarChar(40) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string pkUserId
		{
			get
			{
				return this._pkUserId;
			}
			set
			{
				if ((this._pkUserId != value))
				{
					this.OnpkUserIdChanging(value);
					this.SendPropertyChanging();
					this._pkUserId = value;
					this.SendPropertyChanged("pkUserId");
					this.OnpkUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sFirstName", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string sFirstName
		{
			get
			{
				return this._sFirstName;
			}
			set
			{
				if ((this._sFirstName != value))
				{
					this.OnsFirstNameChanging(value);
					this.SendPropertyChanging();
					this._sFirstName = value;
					this.SendPropertyChanged("sFirstName");
					this.OnsFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sLastName", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string sLastName
		{
			get
			{
				return this._sLastName;
			}
			set
			{
				if ((this._sLastName != value))
				{
					this.OnsLastNameChanging(value);
					this.SendPropertyChanging();
					this._sLastName = value;
					this.SendPropertyChanged("sLastName");
					this.OnsLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sCompany", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string sCompany
		{
			get
			{
				return this._sCompany;
			}
			set
			{
				if ((this._sCompany != value))
				{
					this.OnsCompanyChanging(value);
					this.SendPropertyChanging();
					this._sCompany = value;
					this.SendPropertyChanged("sCompany");
					this.OnsCompanyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sEmailAddress", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string sEmailAddress
		{
			get
			{
				return this._sEmailAddress;
			}
			set
			{
				if ((this._sEmailAddress != value))
				{
					this.OnsEmailAddressChanging(value);
					this.SendPropertyChanging();
					this._sEmailAddress = value;
					this.SendPropertyChanged("sEmailAddress");
					this.OnsEmailAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sCellNo", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string sCellNo
		{
			get
			{
				return this._sCellNo;
			}
			set
			{
				if ((this._sCellNo != value))
				{
					this.OnsCellNoChanging(value);
					this.SendPropertyChanging();
					this._sCellNo = value;
					this.SendPropertyChanged("sCellNo");
					this.OnsCellNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sWorkNo", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string sWorkNo
		{
			get
			{
				return this._sWorkNo;
			}
			set
			{
				if ((this._sWorkNo != value))
				{
					this.OnsWorkNoChanging(value);
					this.SendPropertyChanging();
					this._sWorkNo = value;
					this.SendPropertyChanged("sWorkNo");
					this.OnsWorkNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sPassword", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string sPassword
		{
			get
			{
				return this._sPassword;
			}
			set
			{
				if ((this._sPassword != value))
				{
					this.OnsPasswordChanging(value);
					this.SendPropertyChanging();
					this._sPassword = value;
					this.SendPropertyChanged("sPassword");
					this.OnsPasswordChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
