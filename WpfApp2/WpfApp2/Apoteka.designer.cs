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

namespace WpfApp2
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Apoteka")]
	public partial class ApotekaDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDijagnoza(Dijagnoza instance);
    partial void UpdateDijagnoza(Dijagnoza instance);
    partial void DeleteDijagnoza(Dijagnoza instance);
    partial void InsertRecept(Recept instance);
    partial void UpdateRecept(Recept instance);
    partial void DeleteRecept(Recept instance);
    partial void InsertTerapija(Terapija instance);
    partial void UpdateTerapija(Terapija instance);
    partial void DeleteTerapija(Terapija instance);
    #endregion
		
		public ApotekaDataContext() : 
				base(global::WpfApp2.Properties.Settings.Default.ApotekaConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ApotekaDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ApotekaDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ApotekaDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ApotekaDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Dijagnoza> Dijagnozas
		{
			get
			{
				return this.GetTable<Dijagnoza>();
			}
		}
		
		public System.Data.Linq.Table<Recept> Recepts
		{
			get
			{
				return this.GetTable<Recept>();
			}
		}
		
		public System.Data.Linq.Table<Terapija> Terapijas
		{
			get
			{
				return this.GetTable<Terapija>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Dijagnoza")]
	public partial class Dijagnoza : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _SifraBolesti;
		
		private string _Naziv;
		
		private EntitySet<Recept> _Recepts;
		
		private EntitySet<Terapija> _Terapijas;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSifraBolestiChanging(int value);
    partial void OnSifraBolestiChanged();
    partial void OnNazivChanging(string value);
    partial void OnNazivChanged();
    #endregion
		
		public Dijagnoza()
		{
			this._Recepts = new EntitySet<Recept>(new Action<Recept>(this.attach_Recepts), new Action<Recept>(this.detach_Recepts));
			this._Terapijas = new EntitySet<Terapija>(new Action<Terapija>(this.attach_Terapijas), new Action<Terapija>(this.detach_Terapijas));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SifraBolesti", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int SifraBolesti
		{
			get
			{
				return this._SifraBolesti;
			}
			set
			{
				if ((this._SifraBolesti != value))
				{
					this.OnSifraBolestiChanging(value);
					this.SendPropertyChanging();
					this._SifraBolesti = value;
					this.SendPropertyChanged("SifraBolesti");
					this.OnSifraBolestiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Naziv", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Naziv
		{
			get
			{
				return this._Naziv;
			}
			set
			{
				if ((this._Naziv != value))
				{
					this.OnNazivChanging(value);
					this.SendPropertyChanging();
					this._Naziv = value;
					this.SendPropertyChanged("Naziv");
					this.OnNazivChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Dijagnoza_Recept", Storage="_Recepts", ThisKey="SifraBolesti", OtherKey="SifraBolesti")]
		public EntitySet<Recept> Recepts
		{
			get
			{
				return this._Recepts;
			}
			set
			{
				this._Recepts.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Dijagnoza_Terapija", Storage="_Terapijas", ThisKey="SifraBolesti", OtherKey="SifraBolesti")]
		public EntitySet<Terapija> Terapijas
		{
			get
			{
				return this._Terapijas;
			}
			set
			{
				this._Terapijas.Assign(value);
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
		
		private void attach_Recepts(Recept entity)
		{
			this.SendPropertyChanging();
			entity.Dijagnoza = this;
		}
		
		private void detach_Recepts(Recept entity)
		{
			this.SendPropertyChanging();
			entity.Dijagnoza = null;
		}
		
		private void attach_Terapijas(Terapija entity)
		{
			this.SendPropertyChanging();
			entity.Dijagnoza = this;
		}
		
		private void detach_Terapijas(Terapija entity)
		{
			this.SendPropertyChanging();
			entity.Dijagnoza = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Recept")]
	public partial class Recept : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ReceptID;
		
		private string _Ime;
		
		private string _Prezime;
		
		private System.Nullable<int> _BrKutija;
		
		private int _SifraBolesti;
		
		private int _SifraLeka;
		
		private EntityRef<Dijagnoza> _Dijagnoza;
		
		private EntityRef<Terapija> _Terapija;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnReceptIDChanging(int value);
    partial void OnReceptIDChanged();
    partial void OnImeChanging(string value);
    partial void OnImeChanged();
    partial void OnPrezimeChanging(string value);
    partial void OnPrezimeChanged();
    partial void OnBrKutijaChanging(System.Nullable<int> value);
    partial void OnBrKutijaChanged();
    partial void OnSifraBolestiChanging(int value);
    partial void OnSifraBolestiChanged();
    partial void OnSifraLekaChanging(int value);
    partial void OnSifraLekaChanged();
    #endregion
		
		public Recept()
		{
			this._Dijagnoza = default(EntityRef<Dijagnoza>);
			this._Terapija = default(EntityRef<Terapija>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReceptID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ReceptID
		{
			get
			{
				return this._ReceptID;
			}
			set
			{
				if ((this._ReceptID != value))
				{
					this.OnReceptIDChanging(value);
					this.SendPropertyChanging();
					this._ReceptID = value;
					this.SendPropertyChanged("ReceptID");
					this.OnReceptIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ime", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Ime
		{
			get
			{
				return this._Ime;
			}
			set
			{
				if ((this._Ime != value))
				{
					this.OnImeChanging(value);
					this.SendPropertyChanging();
					this._Ime = value;
					this.SendPropertyChanged("Ime");
					this.OnImeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Prezime", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Prezime
		{
			get
			{
				return this._Prezime;
			}
			set
			{
				if ((this._Prezime != value))
				{
					this.OnPrezimeChanging(value);
					this.SendPropertyChanging();
					this._Prezime = value;
					this.SendPropertyChanged("Prezime");
					this.OnPrezimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BrKutija", DbType="Int")]
		public System.Nullable<int> BrKutija
		{
			get
			{
				return this._BrKutija;
			}
			set
			{
				if ((this._BrKutija != value))
				{
					this.OnBrKutijaChanging(value);
					this.SendPropertyChanging();
					this._BrKutija = value;
					this.SendPropertyChanged("BrKutija");
					this.OnBrKutijaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SifraBolesti", DbType="Int NOT NULL")]
		public int SifraBolesti
		{
			get
			{
				return this._SifraBolesti;
			}
			set
			{
				if ((this._SifraBolesti != value))
				{
					if ((this._Dijagnoza.HasLoadedOrAssignedValue || this._Terapija.HasLoadedOrAssignedValue))
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSifraBolestiChanging(value);
					this.SendPropertyChanging();
					this._SifraBolesti = value;
					this.SendPropertyChanged("SifraBolesti");
					this.OnSifraBolestiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SifraLeka", DbType="Int NOT NULL")]
		public int SifraLeka
		{
			get
			{
				return this._SifraLeka;
			}
			set
			{
				if ((this._SifraLeka != value))
				{
					if (this._Terapija.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSifraLekaChanging(value);
					this.SendPropertyChanging();
					this._SifraLeka = value;
					this.SendPropertyChanged("SifraLeka");
					this.OnSifraLekaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Dijagnoza_Recept", Storage="_Dijagnoza", ThisKey="SifraBolesti", OtherKey="SifraBolesti", IsForeignKey=true)]
		public Dijagnoza Dijagnoza
		{
			get
			{
				return this._Dijagnoza.Entity;
			}
			set
			{
				Dijagnoza previousValue = this._Dijagnoza.Entity;
				if (((previousValue != value) 
							|| (this._Dijagnoza.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Dijagnoza.Entity = null;
						previousValue.Recepts.Remove(this);
					}
					this._Dijagnoza.Entity = value;
					if ((value != null))
					{
						value.Recepts.Add(this);
						this._SifraBolesti = value.SifraBolesti;
					}
					else
					{
						this._SifraBolesti = default(int);
					}
					this.SendPropertyChanged("Dijagnoza");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Terapija_Recept", Storage="_Terapija", ThisKey="SifraBolesti,SifraLeka", OtherKey="SifraBolesti,SifraLeka", IsForeignKey=true)]
		public Terapija Terapija
		{
			get
			{
				return this._Terapija.Entity;
			}
			set
			{
				Terapija previousValue = this._Terapija.Entity;
				if (((previousValue != value) 
							|| (this._Terapija.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Terapija.Entity = null;
						previousValue.Recepts.Remove(this);
					}
					this._Terapija.Entity = value;
					if ((value != null))
					{
						value.Recepts.Add(this);
						this._SifraBolesti = value.SifraBolesti;
						this._SifraLeka = value.SifraLeka;
					}
					else
					{
						this._SifraBolesti = default(int);
						this._SifraLeka = default(int);
					}
					this.SendPropertyChanged("Terapija");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Terapija")]
	public partial class Terapija : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _SifraBolesti;
		
		private int _SifraLeka;
		
		private int _Doza;
		
		private EntitySet<Recept> _Recepts;
		
		private EntityRef<Dijagnoza> _Dijagnoza;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSifraBolestiChanging(int value);
    partial void OnSifraBolestiChanged();
    partial void OnSifraLekaChanging(int value);
    partial void OnSifraLekaChanged();
    partial void OnDozaChanging(int value);
    partial void OnDozaChanged();
    #endregion
		
		public Terapija()
		{
			this._Recepts = new EntitySet<Recept>(new Action<Recept>(this.attach_Recepts), new Action<Recept>(this.detach_Recepts));
			this._Dijagnoza = default(EntityRef<Dijagnoza>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SifraBolesti", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int SifraBolesti
		{
			get
			{
				return this._SifraBolesti;
			}
			set
			{
				if ((this._SifraBolesti != value))
				{
					if (this._Dijagnoza.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSifraBolestiChanging(value);
					this.SendPropertyChanging();
					this._SifraBolesti = value;
					this.SendPropertyChanged("SifraBolesti");
					this.OnSifraBolestiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SifraLeka", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int SifraLeka
		{
			get
			{
				return this._SifraLeka;
			}
			set
			{
				if ((this._SifraLeka != value))
				{
					this.OnSifraLekaChanging(value);
					this.SendPropertyChanging();
					this._SifraLeka = value;
					this.SendPropertyChanged("SifraLeka");
					this.OnSifraLekaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Doza", DbType="Int NOT NULL")]
		public int Doza
		{
			get
			{
				return this._Doza;
			}
			set
			{
				if ((this._Doza != value))
				{
					this.OnDozaChanging(value);
					this.SendPropertyChanging();
					this._Doza = value;
					this.SendPropertyChanged("Doza");
					this.OnDozaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Terapija_Recept", Storage="_Recepts", ThisKey="SifraBolesti,SifraLeka", OtherKey="SifraBolesti,SifraLeka")]
		public EntitySet<Recept> Recepts
		{
			get
			{
				return this._Recepts;
			}
			set
			{
				this._Recepts.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Dijagnoza_Terapija", Storage="_Dijagnoza", ThisKey="SifraBolesti", OtherKey="SifraBolesti", IsForeignKey=true)]
		public Dijagnoza Dijagnoza
		{
			get
			{
				return this._Dijagnoza.Entity;
			}
			set
			{
				Dijagnoza previousValue = this._Dijagnoza.Entity;
				if (((previousValue != value) 
							|| (this._Dijagnoza.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Dijagnoza.Entity = null;
						previousValue.Terapijas.Remove(this);
					}
					this._Dijagnoza.Entity = value;
					if ((value != null))
					{
						value.Terapijas.Add(this);
						this._SifraBolesti = value.SifraBolesti;
					}
					else
					{
						this._SifraBolesti = default(int);
					}
					this.SendPropertyChanged("Dijagnoza");
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
		
		private void attach_Recepts(Recept entity)
		{
			this.SendPropertyChanging();
			entity.Terapija = this;
		}
		
		private void detach_Recepts(Recept entity)
		{
			this.SendPropertyChanging();
			entity.Terapija = null;
		}
	}
}
#pragma warning restore 1591