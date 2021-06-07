﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod araç tarafından oluşturuldu.
//     Çalışma Zamanı Sürümü:4.0.30319.42000
//
//     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YurtLife.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Db")]
	public partial class DbDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCategory(Category instance);
    partial void UpdateCategory(Category instance);
    partial void DeleteCategory(Category instance);
    partial void InsertCustomer(Customer instance);
    partial void UpdateCustomer(Customer instance);
    partial void DeleteCustomer(Customer instance);
    partial void InsertProduct(Product instance);
    partial void UpdateProduct(Product instance);
    partial void DeleteProduct(Product instance);
    partial void InsertReservation(Reservation instance);
    partial void UpdateReservation(Reservation instance);
    partial void DeleteReservation(Reservation instance);
    partial void InsertSale(Sale instance);
    partial void UpdateSale(Sale instance);
    partial void DeleteSale(Sale instance);
    #endregion
		
		public DbDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["DbConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DbDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DbDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DbDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DbDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Category> Category
		{
			get
			{
				return this.GetTable<Category>();
			}
		}
		
		public System.Data.Linq.Table<Customer> Customer
		{
			get
			{
				return this.GetTable<Customer>();
			}
		}
		
		public System.Data.Linq.Table<Product> Product
		{
			get
			{
				return this.GetTable<Product>();
			}
		}
		
		public System.Data.Linq.Table<Reservation> Reservation
		{
			get
			{
				return this.GetTable<Reservation>();
			}
		}
		
		public System.Data.Linq.Table<Sale> Sale
		{
			get
			{
				return this.GetTable<Sale>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Category")]
	public partial class Category : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private short _Id;
		
		private string _Text;
		
		private string _SeoText;
		
		private System.Nullable<short> _OrderNumber;
		
		private EntitySet<Product> _Product;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(short value);
    partial void OnIdChanged();
    partial void OnTextChanging(string value);
    partial void OnTextChanged();
    partial void OnSeoTextChanging(string value);
    partial void OnSeoTextChanged();
    partial void OnOrderNumberChanging(System.Nullable<short> value);
    partial void OnOrderNumberChanged();
    #endregion
		
		public Category()
		{
			this._Product = new EntitySet<Product>(new Action<Product>(this.attach_Product), new Action<Product>(this.detach_Product));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="SmallInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public short Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Text", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Text
		{
			get
			{
				return this._Text;
			}
			set
			{
				if ((this._Text != value))
				{
					this.OnTextChanging(value);
					this.SendPropertyChanging();
					this._Text = value;
					this.SendPropertyChanged("Text");
					this.OnTextChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SeoText", DbType="VarChar(150) NOT NULL", CanBeNull=false)]
		public string SeoText
		{
			get
			{
				return this._SeoText;
			}
			set
			{
				if ((this._SeoText != value))
				{
					this.OnSeoTextChanging(value);
					this.SendPropertyChanging();
					this._SeoText = value;
					this.SendPropertyChanged("SeoText");
					this.OnSeoTextChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderNumber", DbType="SmallInt")]
		public System.Nullable<short> OrderNumber
		{
			get
			{
				return this._OrderNumber;
			}
			set
			{
				if ((this._OrderNumber != value))
				{
					this.OnOrderNumberChanging(value);
					this.SendPropertyChanging();
					this._OrderNumber = value;
					this.SendPropertyChanged("OrderNumber");
					this.OnOrderNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Category_Product", Storage="_Product", ThisKey="Id", OtherKey="CategoryId")]
		public EntitySet<Product> Product
		{
			get
			{
				return this._Product;
			}
			set
			{
				this._Product.Assign(value);
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
		
		private void attach_Product(Product entity)
		{
			this.SendPropertyChanging();
			entity.Category = this;
		}
		
		private void detach_Product(Product entity)
		{
			this.SendPropertyChanging();
			entity.Category = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Customer")]
	public partial class Customer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _EmailAdress;
		
		private string _Password;
		
		private string _FullName;
		
		private string _PhoneNumber;
		
		private EntitySet<Reservation> _Reservation;
		
		private EntitySet<Sale> _Sale;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnEmailAdressChanging(string value);
    partial void OnEmailAdressChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnFullNameChanging(string value);
    partial void OnFullNameChanged();
    partial void OnPhoneNumberChanging(string value);
    partial void OnPhoneNumberChanged();
    #endregion
		
		public Customer()
		{
			this._Reservation = new EntitySet<Reservation>(new Action<Reservation>(this.attach_Reservation), new Action<Reservation>(this.detach_Reservation));
			this._Sale = new EntitySet<Sale>(new Action<Sale>(this.attach_Sale), new Action<Sale>(this.detach_Sale));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmailAdress", DbType="VarChar(70) NOT NULL", CanBeNull=false)]
		public string EmailAdress
		{
			get
			{
				return this._EmailAdress;
			}
			set
			{
				if ((this._EmailAdress != value))
				{
					this.OnEmailAdressChanging(value);
					this.SendPropertyChanging();
					this._EmailAdress = value;
					this.SendPropertyChanged("EmailAdress");
					this.OnEmailAdressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(70) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FullName", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string FullName
		{
			get
			{
				return this._FullName;
			}
			set
			{
				if ((this._FullName != value))
				{
					this.OnFullNameChanging(value);
					this.SendPropertyChanging();
					this._FullName = value;
					this.SendPropertyChanged("FullName");
					this.OnFullNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhoneNumber", DbType="VarChar(20)")]
		public string PhoneNumber
		{
			get
			{
				return this._PhoneNumber;
			}
			set
			{
				if ((this._PhoneNumber != value))
				{
					this.OnPhoneNumberChanging(value);
					this.SendPropertyChanging();
					this._PhoneNumber = value;
					this.SendPropertyChanged("PhoneNumber");
					this.OnPhoneNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Customer_Reservation", Storage="_Reservation", ThisKey="Id", OtherKey="CustomerId")]
		public EntitySet<Reservation> Reservation
		{
			get
			{
				return this._Reservation;
			}
			set
			{
				this._Reservation.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Customer_Sale", Storage="_Sale", ThisKey="Id", OtherKey="CustomerId")]
		public EntitySet<Sale> Sale
		{
			get
			{
				return this._Sale;
			}
			set
			{
				this._Sale.Assign(value);
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
		
		private void attach_Reservation(Reservation entity)
		{
			this.SendPropertyChanging();
			entity.Customer = this;
		}
		
		private void detach_Reservation(Reservation entity)
		{
			this.SendPropertyChanging();
			entity.Customer = null;
		}
		
		private void attach_Sale(Sale entity)
		{
			this.SendPropertyChanging();
			entity.Customer = this;
		}
		
		private void detach_Sale(Sale entity)
		{
			this.SendPropertyChanging();
			entity.Customer = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Product")]
	public partial class Product : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private short _CategoryId;
		
		private string _YurtAdı;
		
		private int _OdaKapasite;
		
		private double _Fiyat;
		
		private string _Kategori;
		
		private int _YurtKapasite;
		
		private string _Adres;
		
		private string _Açıklama;
		
		private int _TelNo;
		
		private string _ImageUrl;
		
		private string _Seo;
		
		private string _SiteUrl;
		
		private EntitySet<Reservation> _Reservation;
		
		private EntitySet<Sale> _Sale;
		
		private EntityRef<Category> _Category;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnCategoryIdChanging(short value);
    partial void OnCategoryIdChanged();
    partial void OnYurtAdıChanging(string value);
    partial void OnYurtAdıChanged();
    partial void OnOdaKapasiteChanging(int value);
    partial void OnOdaKapasiteChanged();
    partial void OnFiyatChanging(double value);
    partial void OnFiyatChanged();
    partial void OnKategoriChanging(string value);
    partial void OnKategoriChanged();
    partial void OnYurtKapasiteChanging(int value);
    partial void OnYurtKapasiteChanged();
    partial void OnAdresChanging(string value);
    partial void OnAdresChanged();
    partial void OnAçıklamaChanging(string value);
    partial void OnAçıklamaChanged();
    partial void OnTelNoChanging(int value);
    partial void OnTelNoChanged();
    partial void OnImageUrlChanging(string value);
    partial void OnImageUrlChanged();
    partial void OnSeoChanging(string value);
    partial void OnSeoChanged();
    partial void OnSiteUrlChanging(string value);
    partial void OnSiteUrlChanged();
    #endregion
		
		public Product()
		{
			this._Reservation = new EntitySet<Reservation>(new Action<Reservation>(this.attach_Reservation), new Action<Reservation>(this.detach_Reservation));
			this._Sale = new EntitySet<Sale>(new Action<Sale>(this.attach_Sale), new Action<Sale>(this.detach_Sale));
			this._Category = default(EntityRef<Category>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryId", DbType="SmallInt NOT NULL")]
		public short CategoryId
		{
			get
			{
				return this._CategoryId;
			}
			set
			{
				if ((this._CategoryId != value))
				{
					if (this._Category.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCategoryIdChanging(value);
					this.SendPropertyChanging();
					this._CategoryId = value;
					this.SendPropertyChanged("CategoryId");
					this.OnCategoryIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_YurtAdı", DbType="VarChar(150) NOT NULL", CanBeNull=false)]
		public string YurtAdı
		{
			get
			{
				return this._YurtAdı;
			}
			set
			{
				if ((this._YurtAdı != value))
				{
					this.OnYurtAdıChanging(value);
					this.SendPropertyChanging();
					this._YurtAdı = value;
					this.SendPropertyChanged("YurtAdı");
					this.OnYurtAdıChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OdaKapasite", DbType="Int NOT NULL")]
		public int OdaKapasite
		{
			get
			{
				return this._OdaKapasite;
			}
			set
			{
				if ((this._OdaKapasite != value))
				{
					this.OnOdaKapasiteChanging(value);
					this.SendPropertyChanging();
					this._OdaKapasite = value;
					this.SendPropertyChanged("OdaKapasite");
					this.OnOdaKapasiteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fiyat", DbType="Float NOT NULL")]
		public double Fiyat
		{
			get
			{
				return this._Fiyat;
			}
			set
			{
				if ((this._Fiyat != value))
				{
					this.OnFiyatChanging(value);
					this.SendPropertyChanging();
					this._Fiyat = value;
					this.SendPropertyChanged("Fiyat");
					this.OnFiyatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Kategori", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Kategori
		{
			get
			{
				return this._Kategori;
			}
			set
			{
				if ((this._Kategori != value))
				{
					this.OnKategoriChanging(value);
					this.SendPropertyChanging();
					this._Kategori = value;
					this.SendPropertyChanged("Kategori");
					this.OnKategoriChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_YurtKapasite", DbType="Int NOT NULL")]
		public int YurtKapasite
		{
			get
			{
				return this._YurtKapasite;
			}
			set
			{
				if ((this._YurtKapasite != value))
				{
					this.OnYurtKapasiteChanging(value);
					this.SendPropertyChanging();
					this._YurtKapasite = value;
					this.SendPropertyChanged("YurtKapasite");
					this.OnYurtKapasiteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Adres", DbType="VarChar(150) NOT NULL", CanBeNull=false)]
		public string Adres
		{
			get
			{
				return this._Adres;
			}
			set
			{
				if ((this._Adres != value))
				{
					this.OnAdresChanging(value);
					this.SendPropertyChanging();
					this._Adres = value;
					this.SendPropertyChanged("Adres");
					this.OnAdresChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Açıklama", DbType="VarChar(1000) NOT NULL", CanBeNull=false)]
		public string Açıklama
		{
			get
			{
				return this._Açıklama;
			}
			set
			{
				if ((this._Açıklama != value))
				{
					this.OnAçıklamaChanging(value);
					this.SendPropertyChanging();
					this._Açıklama = value;
					this.SendPropertyChanged("Açıklama");
					this.OnAçıklamaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TelNo", DbType="Int NOT NULL")]
		public int TelNo
		{
			get
			{
				return this._TelNo;
			}
			set
			{
				if ((this._TelNo != value))
				{
					this.OnTelNoChanging(value);
					this.SendPropertyChanging();
					this._TelNo = value;
					this.SendPropertyChanged("TelNo");
					this.OnTelNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ImageUrl", DbType="VarChar(1000) NOT NULL", CanBeNull=false)]
		public string ImageUrl
		{
			get
			{
				return this._ImageUrl;
			}
			set
			{
				if ((this._ImageUrl != value))
				{
					this.OnImageUrlChanging(value);
					this.SendPropertyChanging();
					this._ImageUrl = value;
					this.SendPropertyChanged("ImageUrl");
					this.OnImageUrlChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Seo", DbType="VarChar(150) NOT NULL", CanBeNull=false)]
		public string Seo
		{
			get
			{
				return this._Seo;
			}
			set
			{
				if ((this._Seo != value))
				{
					this.OnSeoChanging(value);
					this.SendPropertyChanging();
					this._Seo = value;
					this.SendPropertyChanged("Seo");
					this.OnSeoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SiteUrl", DbType="VarChar(500)")]
		public string SiteUrl
		{
			get
			{
				return this._SiteUrl;
			}
			set
			{
				if ((this._SiteUrl != value))
				{
					this.OnSiteUrlChanging(value);
					this.SendPropertyChanging();
					this._SiteUrl = value;
					this.SendPropertyChanged("SiteUrl");
					this.OnSiteUrlChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_Reservation", Storage="_Reservation", ThisKey="Id", OtherKey="ProductId")]
		public EntitySet<Reservation> Reservation
		{
			get
			{
				return this._Reservation;
			}
			set
			{
				this._Reservation.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_Sale", Storage="_Sale", ThisKey="Id", OtherKey="ProductId")]
		public EntitySet<Sale> Sale
		{
			get
			{
				return this._Sale;
			}
			set
			{
				this._Sale.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Category_Product", Storage="_Category", ThisKey="CategoryId", OtherKey="Id", IsForeignKey=true)]
		public Category Category
		{
			get
			{
				return this._Category.Entity;
			}
			set
			{
				Category previousValue = this._Category.Entity;
				if (((previousValue != value) 
							|| (this._Category.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Category.Entity = null;
						previousValue.Product.Remove(this);
					}
					this._Category.Entity = value;
					if ((value != null))
					{
						value.Product.Add(this);
						this._CategoryId = value.Id;
					}
					else
					{
						this._CategoryId = default(short);
					}
					this.SendPropertyChanged("Category");
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
		
		private void attach_Reservation(Reservation entity)
		{
			this.SendPropertyChanging();
			entity.Product = this;
		}
		
		private void detach_Reservation(Reservation entity)
		{
			this.SendPropertyChanging();
			entity.Product = null;
		}
		
		private void attach_Sale(Sale entity)
		{
			this.SendPropertyChanging();
			entity.Product = this;
		}
		
		private void detach_Sale(Sale entity)
		{
			this.SendPropertyChanging();
			entity.Product = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Reservation")]
	public partial class Reservation : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _CustomerId;
		
		private int _ProductId;
		
		private EntityRef<Customer> _Customer;
		
		private EntityRef<Product> _Product;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnCustomerIdChanging(int value);
    partial void OnCustomerIdChanged();
    partial void OnProductIdChanging(int value);
    partial void OnProductIdChanged();
    #endregion
		
		public Reservation()
		{
			this._Customer = default(EntityRef<Customer>);
			this._Product = default(EntityRef<Product>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerId", DbType="Int NOT NULL")]
		public int CustomerId
		{
			get
			{
				return this._CustomerId;
			}
			set
			{
				if ((this._CustomerId != value))
				{
					if (this._Customer.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCustomerIdChanging(value);
					this.SendPropertyChanging();
					this._CustomerId = value;
					this.SendPropertyChanged("CustomerId");
					this.OnCustomerIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductId", DbType="Int NOT NULL")]
		public int ProductId
		{
			get
			{
				return this._ProductId;
			}
			set
			{
				if ((this._ProductId != value))
				{
					if (this._Product.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnProductIdChanging(value);
					this.SendPropertyChanging();
					this._ProductId = value;
					this.SendPropertyChanged("ProductId");
					this.OnProductIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Customer_Reservation", Storage="_Customer", ThisKey="CustomerId", OtherKey="Id", IsForeignKey=true)]
		public Customer Customer
		{
			get
			{
				return this._Customer.Entity;
			}
			set
			{
				Customer previousValue = this._Customer.Entity;
				if (((previousValue != value) 
							|| (this._Customer.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Customer.Entity = null;
						previousValue.Reservation.Remove(this);
					}
					this._Customer.Entity = value;
					if ((value != null))
					{
						value.Reservation.Add(this);
						this._CustomerId = value.Id;
					}
					else
					{
						this._CustomerId = default(int);
					}
					this.SendPropertyChanged("Customer");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_Reservation", Storage="_Product", ThisKey="ProductId", OtherKey="Id", IsForeignKey=true)]
		public Product Product
		{
			get
			{
				return this._Product.Entity;
			}
			set
			{
				Product previousValue = this._Product.Entity;
				if (((previousValue != value) 
							|| (this._Product.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Product.Entity = null;
						previousValue.Reservation.Remove(this);
					}
					this._Product.Entity = value;
					if ((value != null))
					{
						value.Reservation.Add(this);
						this._ProductId = value.Id;
					}
					else
					{
						this._ProductId = default(int);
					}
					this.SendPropertyChanged("Product");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Sale")]
	public partial class Sale : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _ProductId;
		
		private int _CustomerId;
		
		private short _SaleState;
		
		private EntityRef<Customer> _Customer;
		
		private EntityRef<Product> _Product;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnProductIdChanging(int value);
    partial void OnProductIdChanged();
    partial void OnCustomerIdChanging(int value);
    partial void OnCustomerIdChanged();
    partial void OnSaleStateChanging(short value);
    partial void OnSaleStateChanged();
    #endregion
		
		public Sale()
		{
			this._Customer = default(EntityRef<Customer>);
			this._Product = default(EntityRef<Product>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductId", DbType="Int NOT NULL")]
		public int ProductId
		{
			get
			{
				return this._ProductId;
			}
			set
			{
				if ((this._ProductId != value))
				{
					if (this._Product.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnProductIdChanging(value);
					this.SendPropertyChanging();
					this._ProductId = value;
					this.SendPropertyChanged("ProductId");
					this.OnProductIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerId", DbType="Int NOT NULL")]
		public int CustomerId
		{
			get
			{
				return this._CustomerId;
			}
			set
			{
				if ((this._CustomerId != value))
				{
					if (this._Customer.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCustomerIdChanging(value);
					this.SendPropertyChanging();
					this._CustomerId = value;
					this.SendPropertyChanged("CustomerId");
					this.OnCustomerIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SaleState", DbType="SmallInt NOT NULL")]
		public short SaleState
		{
			get
			{
				return this._SaleState;
			}
			set
			{
				if ((this._SaleState != value))
				{
					this.OnSaleStateChanging(value);
					this.SendPropertyChanging();
					this._SaleState = value;
					this.SendPropertyChanged("SaleState");
					this.OnSaleStateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Customer_Sale", Storage="_Customer", ThisKey="CustomerId", OtherKey="Id", IsForeignKey=true)]
		public Customer Customer
		{
			get
			{
				return this._Customer.Entity;
			}
			set
			{
				Customer previousValue = this._Customer.Entity;
				if (((previousValue != value) 
							|| (this._Customer.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Customer.Entity = null;
						previousValue.Sale.Remove(this);
					}
					this._Customer.Entity = value;
					if ((value != null))
					{
						value.Sale.Add(this);
						this._CustomerId = value.Id;
					}
					else
					{
						this._CustomerId = default(int);
					}
					this.SendPropertyChanged("Customer");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_Sale", Storage="_Product", ThisKey="ProductId", OtherKey="Id", IsForeignKey=true)]
		public Product Product
		{
			get
			{
				return this._Product.Entity;
			}
			set
			{
				Product previousValue = this._Product.Entity;
				if (((previousValue != value) 
							|| (this._Product.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Product.Entity = null;
						previousValue.Sale.Remove(this);
					}
					this._Product.Entity = value;
					if ((value != null))
					{
						value.Sale.Add(this);
						this._ProductId = value.Id;
					}
					else
					{
						this._ProductId = default(int);
					}
					this.SendPropertyChanged("Product");
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