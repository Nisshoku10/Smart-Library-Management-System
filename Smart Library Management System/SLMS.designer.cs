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

namespace Smart_Library_Management_System
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="LibWonder")]
	public partial class SLMSDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAccount(Account instance);
    partial void UpdateAccount(Account instance);
    partial void DeleteAccount(Account instance);
    partial void InsertBook_Documentation(Book_Documentation instance);
    partial void UpdateBook_Documentation(Book_Documentation instance);
    partial void DeleteBook_Documentation(Book_Documentation instance);
    partial void InsertBook(Book instance);
    partial void UpdateBook(Book instance);
    partial void DeleteBook(Book instance);
    partial void InsertLog(Log instance);
    partial void UpdateLog(Log instance);
    partial void DeleteLog(Log instance);
    #endregion
		
		public SLMSDataContext() : 
				base(global::Smart_Library_Management_System.Properties.Settings.Default.LibWonderConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SLMSDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SLMSDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SLMSDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SLMSDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Account> Accounts
		{
			get
			{
				return this.GetTable<Account>();
			}
		}
		
		public System.Data.Linq.Table<Book_Documentation> Book_Documentations
		{
			get
			{
				return this.GetTable<Book_Documentation>();
			}
		}
		
		public System.Data.Linq.Table<Book> Books
		{
			get
			{
				return this.GetTable<Book>();
			}
		}
		
		public System.Data.Linq.Table<Log> Logs
		{
			get
			{
				return this.GetTable<Log>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Accounts")]
	public partial class Account : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Acc_ID;
		
		private string _Acc_Type;
		
		private string _Username;
		
		private string _Password;
		
		private string _First_Name;
		
		private string _Last_Name;
		
		private System.Data.Linq.Binary _Acc_Image;
		
		private EntitySet<Book_Documentation> _Book_Documentations;
		
		private EntitySet<Log> _Logs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAcc_IDChanging(string value);
    partial void OnAcc_IDChanged();
    partial void OnAcc_TypeChanging(string value);
    partial void OnAcc_TypeChanged();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnFirst_NameChanging(string value);
    partial void OnFirst_NameChanged();
    partial void OnLast_NameChanging(string value);
    partial void OnLast_NameChanged();
    partial void OnAcc_ImageChanging(System.Data.Linq.Binary value);
    partial void OnAcc_ImageChanged();
    #endregion
		
		public Account()
		{
			this._Book_Documentations = new EntitySet<Book_Documentation>(new Action<Book_Documentation>(this.attach_Book_Documentations), new Action<Book_Documentation>(this.detach_Book_Documentations));
			this._Logs = new EntitySet<Log>(new Action<Log>(this.attach_Logs), new Action<Log>(this.detach_Logs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Acc_ID", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Acc_ID
		{
			get
			{
				return this._Acc_ID;
			}
			set
			{
				if ((this._Acc_ID != value))
				{
					this.OnAcc_IDChanging(value);
					this.SendPropertyChanging();
					this._Acc_ID = value;
					this.SendPropertyChanged("Acc_ID");
					this.OnAcc_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Acc_Type", DbType="VarChar(10)")]
		public string Acc_Type
		{
			get
			{
				return this._Acc_Type;
			}
			set
			{
				if ((this._Acc_Type != value))
				{
					this.OnAcc_TypeChanging(value);
					this.SendPropertyChanging();
					this._Acc_Type = value;
					this.SendPropertyChanged("Acc_Type");
					this.OnAcc_TypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="Char(8)")]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(8)")]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_First_Name", DbType="NVarChar(20)")]
		public string First_Name
		{
			get
			{
				return this._First_Name;
			}
			set
			{
				if ((this._First_Name != value))
				{
					this.OnFirst_NameChanging(value);
					this.SendPropertyChanging();
					this._First_Name = value;
					this.SendPropertyChanged("First_Name");
					this.OnFirst_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Last_Name", DbType="NVarChar(20)")]
		public string Last_Name
		{
			get
			{
				return this._Last_Name;
			}
			set
			{
				if ((this._Last_Name != value))
				{
					this.OnLast_NameChanging(value);
					this.SendPropertyChanging();
					this._Last_Name = value;
					this.SendPropertyChanged("Last_Name");
					this.OnLast_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Acc_Image", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary Acc_Image
		{
			get
			{
				return this._Acc_Image;
			}
			set
			{
				if ((this._Acc_Image != value))
				{
					this.OnAcc_ImageChanging(value);
					this.SendPropertyChanging();
					this._Acc_Image = value;
					this.SendPropertyChanged("Acc_Image");
					this.OnAcc_ImageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Account_Book_Documentation", Storage="_Book_Documentations", ThisKey="Acc_ID", OtherKey="Acc_ID")]
		public EntitySet<Book_Documentation> Book_Documentations
		{
			get
			{
				return this._Book_Documentations;
			}
			set
			{
				this._Book_Documentations.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Account_Log", Storage="_Logs", ThisKey="Acc_ID", OtherKey="Acc_ID")]
		public EntitySet<Log> Logs
		{
			get
			{
				return this._Logs;
			}
			set
			{
				this._Logs.Assign(value);
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
		
		private void attach_Book_Documentations(Book_Documentation entity)
		{
			this.SendPropertyChanging();
			entity.Account = this;
		}
		
		private void detach_Book_Documentations(Book_Documentation entity)
		{
			this.SendPropertyChanging();
			entity.Account = null;
		}
		
		private void attach_Logs(Log entity)
		{
			this.SendPropertyChanging();
			entity.Account = this;
		}
		
		private void detach_Logs(Log entity)
		{
			this.SendPropertyChanging();
			entity.Account = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Book_Documentation")]
	public partial class Book_Documentation : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Doc_ID;
		
		private string _Book_ID;
		
		private string _Acc_ID;
		
		private System.Data.Linq.Binary _Borrow_Image;
		
		private System.Nullable<System.DateTime> _Borrow_Date;
		
		private System.Data.Linq.Binary _Return_Image;
		
		private System.Nullable<System.DateTime> _Return_Date;
		
		private EntityRef<Account> _Account;
		
		private EntityRef<Book> _Book;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDoc_IDChanging(string value);
    partial void OnDoc_IDChanged();
    partial void OnBook_IDChanging(string value);
    partial void OnBook_IDChanged();
    partial void OnAcc_IDChanging(string value);
    partial void OnAcc_IDChanged();
    partial void OnBorrow_ImageChanging(System.Data.Linq.Binary value);
    partial void OnBorrow_ImageChanged();
    partial void OnBorrow_DateChanging(System.Nullable<System.DateTime> value);
    partial void OnBorrow_DateChanged();
    partial void OnReturn_ImageChanging(System.Data.Linq.Binary value);
    partial void OnReturn_ImageChanged();
    partial void OnReturn_DateChanging(System.Nullable<System.DateTime> value);
    partial void OnReturn_DateChanged();
    #endregion
		
		public Book_Documentation()
		{
			this._Account = default(EntityRef<Account>);
			this._Book = default(EntityRef<Book>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Doc_ID", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Doc_ID
		{
			get
			{
				return this._Doc_ID;
			}
			set
			{
				if ((this._Doc_ID != value))
				{
					this.OnDoc_IDChanging(value);
					this.SendPropertyChanging();
					this._Doc_ID = value;
					this.SendPropertyChanged("Doc_ID");
					this.OnDoc_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Book_ID", DbType="VarChar(10)")]
		public string Book_ID
		{
			get
			{
				return this._Book_ID;
			}
			set
			{
				if ((this._Book_ID != value))
				{
					if (this._Book.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnBook_IDChanging(value);
					this.SendPropertyChanging();
					this._Book_ID = value;
					this.SendPropertyChanged("Book_ID");
					this.OnBook_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Acc_ID", DbType="VarChar(10)")]
		public string Acc_ID
		{
			get
			{
				return this._Acc_ID;
			}
			set
			{
				if ((this._Acc_ID != value))
				{
					if (this._Account.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnAcc_IDChanging(value);
					this.SendPropertyChanging();
					this._Acc_ID = value;
					this.SendPropertyChanged("Acc_ID");
					this.OnAcc_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Borrow_Image", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary Borrow_Image
		{
			get
			{
				return this._Borrow_Image;
			}
			set
			{
				if ((this._Borrow_Image != value))
				{
					this.OnBorrow_ImageChanging(value);
					this.SendPropertyChanging();
					this._Borrow_Image = value;
					this.SendPropertyChanged("Borrow_Image");
					this.OnBorrow_ImageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Borrow_Date", DbType="Date")]
		public System.Nullable<System.DateTime> Borrow_Date
		{
			get
			{
				return this._Borrow_Date;
			}
			set
			{
				if ((this._Borrow_Date != value))
				{
					this.OnBorrow_DateChanging(value);
					this.SendPropertyChanging();
					this._Borrow_Date = value;
					this.SendPropertyChanged("Borrow_Date");
					this.OnBorrow_DateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Return_Image", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary Return_Image
		{
			get
			{
				return this._Return_Image;
			}
			set
			{
				if ((this._Return_Image != value))
				{
					this.OnReturn_ImageChanging(value);
					this.SendPropertyChanging();
					this._Return_Image = value;
					this.SendPropertyChanged("Return_Image");
					this.OnReturn_ImageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Return_Date", DbType="Date")]
		public System.Nullable<System.DateTime> Return_Date
		{
			get
			{
				return this._Return_Date;
			}
			set
			{
				if ((this._Return_Date != value))
				{
					this.OnReturn_DateChanging(value);
					this.SendPropertyChanging();
					this._Return_Date = value;
					this.SendPropertyChanged("Return_Date");
					this.OnReturn_DateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Account_Book_Documentation", Storage="_Account", ThisKey="Acc_ID", OtherKey="Acc_ID", IsForeignKey=true)]
		public Account Account
		{
			get
			{
				return this._Account.Entity;
			}
			set
			{
				Account previousValue = this._Account.Entity;
				if (((previousValue != value) 
							|| (this._Account.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Account.Entity = null;
						previousValue.Book_Documentations.Remove(this);
					}
					this._Account.Entity = value;
					if ((value != null))
					{
						value.Book_Documentations.Add(this);
						this._Acc_ID = value.Acc_ID;
					}
					else
					{
						this._Acc_ID = default(string);
					}
					this.SendPropertyChanged("Account");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Book_Book_Documentation", Storage="_Book", ThisKey="Book_ID", OtherKey="Book_ID", IsForeignKey=true)]
		public Book Book
		{
			get
			{
				return this._Book.Entity;
			}
			set
			{
				Book previousValue = this._Book.Entity;
				if (((previousValue != value) 
							|| (this._Book.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Book.Entity = null;
						previousValue.Book_Documentations.Remove(this);
					}
					this._Book.Entity = value;
					if ((value != null))
					{
						value.Book_Documentations.Add(this);
						this._Book_ID = value.Book_ID;
					}
					else
					{
						this._Book_ID = default(string);
					}
					this.SendPropertyChanged("Book");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Books")]
	public partial class Book : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Book_ID;
		
		private string _Title;
		
		private string _Author;
		
		private string _Genre;
		
		private System.Nullable<short> _Publish_Year;
		
		private string _Status;
		
		private System.Data.Linq.Binary _Book_Image;
		
		private System.Data.Linq.Binary _QR_Path;
		
		private EntitySet<Book_Documentation> _Book_Documentations;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnBook_IDChanging(string value);
    partial void OnBook_IDChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnAuthorChanging(string value);
    partial void OnAuthorChanged();
    partial void OnGenreChanging(string value);
    partial void OnGenreChanged();
    partial void OnPublish_YearChanging(System.Nullable<short> value);
    partial void OnPublish_YearChanged();
    partial void OnStatusChanging(string value);
    partial void OnStatusChanged();
    partial void OnBook_ImageChanging(System.Data.Linq.Binary value);
    partial void OnBook_ImageChanged();
    partial void OnQR_PathChanging(System.Data.Linq.Binary value);
    partial void OnQR_PathChanged();
    #endregion
		
		public Book()
		{
			this._Book_Documentations = new EntitySet<Book_Documentation>(new Action<Book_Documentation>(this.attach_Book_Documentations), new Action<Book_Documentation>(this.detach_Book_Documentations));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Book_ID", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Book_ID
		{
			get
			{
				return this._Book_ID;
			}
			set
			{
				if ((this._Book_ID != value))
				{
					this.OnBook_IDChanging(value);
					this.SendPropertyChanging();
					this._Book_ID = value;
					this.SendPropertyChanged("Book_ID");
					this.OnBook_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(50)")]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Author", DbType="NVarChar(50)")]
		public string Author
		{
			get
			{
				return this._Author;
			}
			set
			{
				if ((this._Author != value))
				{
					this.OnAuthorChanging(value);
					this.SendPropertyChanging();
					this._Author = value;
					this.SendPropertyChanged("Author");
					this.OnAuthorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Genre", DbType="VarChar(50)")]
		public string Genre
		{
			get
			{
				return this._Genre;
			}
			set
			{
				if ((this._Genre != value))
				{
					this.OnGenreChanging(value);
					this.SendPropertyChanging();
					this._Genre = value;
					this.SendPropertyChanged("Genre");
					this.OnGenreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Publish_Year", DbType="SmallInt")]
		public System.Nullable<short> Publish_Year
		{
			get
			{
				return this._Publish_Year;
			}
			set
			{
				if ((this._Publish_Year != value))
				{
					this.OnPublish_YearChanging(value);
					this.SendPropertyChanging();
					this._Publish_Year = value;
					this.SendPropertyChanged("Publish_Year");
					this.OnPublish_YearChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="VarChar(20)")]
		public string Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				if ((this._Status != value))
				{
					this.OnStatusChanging(value);
					this.SendPropertyChanging();
					this._Status = value;
					this.SendPropertyChanged("Status");
					this.OnStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Book_Image", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary Book_Image
		{
			get
			{
				return this._Book_Image;
			}
			set
			{
				if ((this._Book_Image != value))
				{
					this.OnBook_ImageChanging(value);
					this.SendPropertyChanging();
					this._Book_Image = value;
					this.SendPropertyChanged("Book_Image");
					this.OnBook_ImageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QR_Path", DbType="VarBinary(MAX)", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary QR_Path
		{
			get
			{
				return this._QR_Path;
			}
			set
			{
				if ((this._QR_Path != value))
				{
					this.OnQR_PathChanging(value);
					this.SendPropertyChanging();
					this._QR_Path = value;
					this.SendPropertyChanged("QR_Path");
					this.OnQR_PathChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Book_Book_Documentation", Storage="_Book_Documentations", ThisKey="Book_ID", OtherKey="Book_ID")]
		public EntitySet<Book_Documentation> Book_Documentations
		{
			get
			{
				return this._Book_Documentations;
			}
			set
			{
				this._Book_Documentations.Assign(value);
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
		
		private void attach_Book_Documentations(Book_Documentation entity)
		{
			this.SendPropertyChanging();
			entity.Book = this;
		}
		
		private void detach_Book_Documentations(Book_Documentation entity)
		{
			this.SendPropertyChanging();
			entity.Book = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Logs")]
	public partial class Log : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Log_ID;
		
		private string _Acc_ID;
		
		private System.Nullable<System.DateTime> _TimeStamp;
		
		private string _Log_Activity;
		
		private EntityRef<Account> _Account;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnLog_IDChanging(string value);
    partial void OnLog_IDChanged();
    partial void OnAcc_IDChanging(string value);
    partial void OnAcc_IDChanged();
    partial void OnTimeStampChanging(System.Nullable<System.DateTime> value);
    partial void OnTimeStampChanged();
    partial void OnLog_ActivityChanging(string value);
    partial void OnLog_ActivityChanged();
    #endregion
		
		public Log()
		{
			this._Account = default(EntityRef<Account>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Log_ID", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Log_ID
		{
			get
			{
				return this._Log_ID;
			}
			set
			{
				if ((this._Log_ID != value))
				{
					this.OnLog_IDChanging(value);
					this.SendPropertyChanging();
					this._Log_ID = value;
					this.SendPropertyChanged("Log_ID");
					this.OnLog_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Acc_ID", DbType="VarChar(10)")]
		public string Acc_ID
		{
			get
			{
				return this._Acc_ID;
			}
			set
			{
				if ((this._Acc_ID != value))
				{
					if (this._Account.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnAcc_IDChanging(value);
					this.SendPropertyChanging();
					this._Acc_ID = value;
					this.SendPropertyChanged("Acc_ID");
					this.OnAcc_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TimeStamp", DbType="DateTime")]
		public System.Nullable<System.DateTime> TimeStamp
		{
			get
			{
				return this._TimeStamp;
			}
			set
			{
				if ((this._TimeStamp != value))
				{
					this.OnTimeStampChanging(value);
					this.SendPropertyChanging();
					this._TimeStamp = value;
					this.SendPropertyChanged("TimeStamp");
					this.OnTimeStampChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Log_Activity", DbType="VarChar(50)")]
		public string Log_Activity
		{
			get
			{
				return this._Log_Activity;
			}
			set
			{
				if ((this._Log_Activity != value))
				{
					this.OnLog_ActivityChanging(value);
					this.SendPropertyChanging();
					this._Log_Activity = value;
					this.SendPropertyChanged("Log_Activity");
					this.OnLog_ActivityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Account_Log", Storage="_Account", ThisKey="Acc_ID", OtherKey="Acc_ID", IsForeignKey=true)]
		public Account Account
		{
			get
			{
				return this._Account.Entity;
			}
			set
			{
				Account previousValue = this._Account.Entity;
				if (((previousValue != value) 
							|| (this._Account.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Account.Entity = null;
						previousValue.Logs.Remove(this);
					}
					this._Account.Entity = value;
					if ((value != null))
					{
						value.Logs.Add(this);
						this._Acc_ID = value.Acc_ID;
					}
					else
					{
						this._Acc_ID = default(string);
					}
					this.SendPropertyChanged("Account");
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