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

namespace Cynomex.cynomys.webservice.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Cynomys")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAlerta(Alerta instance);
    partial void UpdateAlerta(Alerta instance);
    partial void DeleteAlerta(Alerta instance);
    partial void InsertUsuario(Usuario instance);
    partial void UpdateUsuario(Usuario instance);
    partial void DeleteUsuario(Usuario instance);
    partial void InsertContactoEmergencia(ContactoEmergencia instance);
    partial void UpdateContactoEmergencia(ContactoEmergencia instance);
    partial void DeleteContactoEmergencia(ContactoEmergencia instance);
    partial void InsertSexo(Sexo instance);
    partial void UpdateSexo(Sexo instance);
    partial void DeleteSexo(Sexo instance);
    partial void InsertTIpoAlerta(TIpoAlerta instance);
    partial void UpdateTIpoAlerta(TIpoAlerta instance);
    partial void DeleteTIpoAlerta(TIpoAlerta instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["CynomysConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Alerta> Alertas
		{
			get
			{
				return this.GetTable<Alerta>();
			}
		}
		
		public System.Data.Linq.Table<Usuario> Usuarios
		{
			get
			{
				return this.GetTable<Usuario>();
			}
		}
		
		public System.Data.Linq.Table<ContactoEmergencia> ContactoEmergencias
		{
			get
			{
				return this.GetTable<ContactoEmergencia>();
			}
		}
		
		public System.Data.Linq.Table<Sexo> Sexos
		{
			get
			{
				return this.GetTable<Sexo>();
			}
		}
		
		public System.Data.Linq.Table<TIpoAlerta> TIpoAlertas
		{
			get
			{
				return this.GetTable<TIpoAlerta>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Alerta")]
	public partial class Alerta : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idAlerta;
		
		private string _lat;
		
		private string _lon;
		
		private System.Nullable<int> _idTipoAlerta;
		
		private System.Nullable<int> _idUsuario;
		
		private System.Nullable<bool> _status;
		
		private EntityRef<Usuario> _Usuario;
		
		private EntityRef<TIpoAlerta> _TIpoAlerta;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidAlertaChanging(int value);
    partial void OnidAlertaChanged();
    partial void OnlatChanging(string value);
    partial void OnlatChanged();
    partial void OnlonChanging(string value);
    partial void OnlonChanged();
    partial void OnidTipoAlertaChanging(System.Nullable<int> value);
    partial void OnidTipoAlertaChanged();
    partial void OnidUsuarioChanging(System.Nullable<int> value);
    partial void OnidUsuarioChanged();
    partial void OnstatusChanging(System.Nullable<bool> value);
    partial void OnstatusChanged();
    #endregion
		
		public Alerta()
		{
			this._Usuario = default(EntityRef<Usuario>);
			this._TIpoAlerta = default(EntityRef<TIpoAlerta>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idAlerta", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idAlerta
		{
			get
			{
				return this._idAlerta;
			}
			set
			{
				if ((this._idAlerta != value))
				{
					this.OnidAlertaChanging(value);
					this.SendPropertyChanging();
					this._idAlerta = value;
					this.SendPropertyChanged("idAlerta");
					this.OnidAlertaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lat", DbType="VarChar(120)")]
		public string lat
		{
			get
			{
				return this._lat;
			}
			set
			{
				if ((this._lat != value))
				{
					this.OnlatChanging(value);
					this.SendPropertyChanging();
					this._lat = value;
					this.SendPropertyChanged("lat");
					this.OnlatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lon", DbType="VarChar(120)")]
		public string lon
		{
			get
			{
				return this._lon;
			}
			set
			{
				if ((this._lon != value))
				{
					this.OnlonChanging(value);
					this.SendPropertyChanging();
					this._lon = value;
					this.SendPropertyChanged("lon");
					this.OnlonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idTipoAlerta", DbType="Int")]
		public System.Nullable<int> idTipoAlerta
		{
			get
			{
				return this._idTipoAlerta;
			}
			set
			{
				if ((this._idTipoAlerta != value))
				{
					if (this._TIpoAlerta.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidTipoAlertaChanging(value);
					this.SendPropertyChanging();
					this._idTipoAlerta = value;
					this.SendPropertyChanged("idTipoAlerta");
					this.OnidTipoAlertaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idUsuario", DbType="Int")]
		public System.Nullable<int> idUsuario
		{
			get
			{
				return this._idUsuario;
			}
			set
			{
				if ((this._idUsuario != value))
				{
					if (this._Usuario.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidUsuarioChanging(value);
					this.SendPropertyChanging();
					this._idUsuario = value;
					this.SendPropertyChanged("idUsuario");
					this.OnidUsuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="Bit")]
		public System.Nullable<bool> status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this.OnstatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("status");
					this.OnstatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Usuario_Alerta", Storage="_Usuario", ThisKey="idUsuario", OtherKey="idUsuario", IsForeignKey=true)]
		public Usuario Usuario
		{
			get
			{
				return this._Usuario.Entity;
			}
			set
			{
				Usuario previousValue = this._Usuario.Entity;
				if (((previousValue != value) 
							|| (this._Usuario.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Usuario.Entity = null;
						previousValue.Alertas.Remove(this);
					}
					this._Usuario.Entity = value;
					if ((value != null))
					{
						value.Alertas.Add(this);
						this._idUsuario = value.idUsuario;
					}
					else
					{
						this._idUsuario = default(Nullable<int>);
					}
					this.SendPropertyChanged("Usuario");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TIpoAlerta_Alerta", Storage="_TIpoAlerta", ThisKey="idTipoAlerta", OtherKey="idTipoAlerta", IsForeignKey=true)]
		public TIpoAlerta TIpoAlerta
		{
			get
			{
				return this._TIpoAlerta.Entity;
			}
			set
			{
				TIpoAlerta previousValue = this._TIpoAlerta.Entity;
				if (((previousValue != value) 
							|| (this._TIpoAlerta.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TIpoAlerta.Entity = null;
						previousValue.Alertas.Remove(this);
					}
					this._TIpoAlerta.Entity = value;
					if ((value != null))
					{
						value.Alertas.Add(this);
						this._idTipoAlerta = value.idTipoAlerta;
					}
					else
					{
						this._idTipoAlerta = default(Nullable<int>);
					}
					this.SendPropertyChanged("TIpoAlerta");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Usuario")]
	public partial class Usuario : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idUsuario;
		
		private string _usuario1;
		
		private string _password;
		
		private System.Nullable<System.DateTime> _fecha_nacimiento;
		
		private System.Nullable<int> _idsexo;
		
		private string _nombre;
		
		private string _email;
		
		private System.Nullable<bool> _status;
		
		private EntitySet<Alerta> _Alertas;
		
		private EntitySet<ContactoEmergencia> _ContactoEmergencias;
		
		private EntityRef<Sexo> _Sexo;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidUsuarioChanging(int value);
    partial void OnidUsuarioChanged();
    partial void Onusuario1Changing(string value);
    partial void Onusuario1Changed();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    partial void Onfecha_nacimientoChanging(System.Nullable<System.DateTime> value);
    partial void Onfecha_nacimientoChanged();
    partial void OnidsexoChanging(System.Nullable<int> value);
    partial void OnidsexoChanged();
    partial void OnnombreChanging(string value);
    partial void OnnombreChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OnstatusChanging(System.Nullable<bool> value);
    partial void OnstatusChanged();
    #endregion
		
		public Usuario()
		{
			this._Alertas = new EntitySet<Alerta>(new Action<Alerta>(this.attach_Alertas), new Action<Alerta>(this.detach_Alertas));
			this._ContactoEmergencias = new EntitySet<ContactoEmergencia>(new Action<ContactoEmergencia>(this.attach_ContactoEmergencias), new Action<ContactoEmergencia>(this.detach_ContactoEmergencias));
			this._Sexo = default(EntityRef<Sexo>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idUsuario", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idUsuario
		{
			get
			{
				return this._idUsuario;
			}
			set
			{
				if ((this._idUsuario != value))
				{
					this.OnidUsuarioChanging(value);
					this.SendPropertyChanging();
					this._idUsuario = value;
					this.SendPropertyChanged("idUsuario");
					this.OnidUsuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="usuario", Storage="_usuario1", DbType="VarChar(50)")]
		public string usuario1
		{
			get
			{
				return this._usuario1;
			}
			set
			{
				if ((this._usuario1 != value))
				{
					this.Onusuario1Changing(value);
					this.SendPropertyChanging();
					this._usuario1 = value;
					this.SendPropertyChanged("usuario1");
					this.Onusuario1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="VarChar(50)")]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fecha_nacimiento", DbType="Date")]
		public System.Nullable<System.DateTime> fecha_nacimiento
		{
			get
			{
				return this._fecha_nacimiento;
			}
			set
			{
				if ((this._fecha_nacimiento != value))
				{
					this.Onfecha_nacimientoChanging(value);
					this.SendPropertyChanging();
					this._fecha_nacimiento = value;
					this.SendPropertyChanged("fecha_nacimiento");
					this.Onfecha_nacimientoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idsexo", DbType="Int")]
		public System.Nullable<int> idsexo
		{
			get
			{
				return this._idsexo;
			}
			set
			{
				if ((this._idsexo != value))
				{
					if (this._Sexo.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidsexoChanging(value);
					this.SendPropertyChanging();
					this._idsexo = value;
					this.SendPropertyChanged("idsexo");
					this.OnidsexoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre", DbType="VarChar(50)")]
		public string nombre
		{
			get
			{
				return this._nombre;
			}
			set
			{
				if ((this._nombre != value))
				{
					this.OnnombreChanging(value);
					this.SendPropertyChanging();
					this._nombre = value;
					this.SendPropertyChanged("nombre");
					this.OnnombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(50)")]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="Bit")]
		public System.Nullable<bool> status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this.OnstatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("status");
					this.OnstatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Usuario_Alerta", Storage="_Alertas", ThisKey="idUsuario", OtherKey="idUsuario")]
		public EntitySet<Alerta> Alertas
		{
			get
			{
				return this._Alertas;
			}
			set
			{
				this._Alertas.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Usuario_ContactoEmergencia", Storage="_ContactoEmergencias", ThisKey="idUsuario", OtherKey="idUsuario")]
		public EntitySet<ContactoEmergencia> ContactoEmergencias
		{
			get
			{
				return this._ContactoEmergencias;
			}
			set
			{
				this._ContactoEmergencias.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Sexo_Usuario", Storage="_Sexo", ThisKey="idsexo", OtherKey="idSexo", IsForeignKey=true)]
		public Sexo Sexo
		{
			get
			{
				return this._Sexo.Entity;
			}
			set
			{
				Sexo previousValue = this._Sexo.Entity;
				if (((previousValue != value) 
							|| (this._Sexo.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Sexo.Entity = null;
						previousValue.Usuarios.Remove(this);
					}
					this._Sexo.Entity = value;
					if ((value != null))
					{
						value.Usuarios.Add(this);
						this._idsexo = value.idSexo;
					}
					else
					{
						this._idsexo = default(Nullable<int>);
					}
					this.SendPropertyChanged("Sexo");
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
		
		private void attach_Alertas(Alerta entity)
		{
			this.SendPropertyChanging();
			entity.Usuario = this;
		}
		
		private void detach_Alertas(Alerta entity)
		{
			this.SendPropertyChanging();
			entity.Usuario = null;
		}
		
		private void attach_ContactoEmergencias(ContactoEmergencia entity)
		{
			this.SendPropertyChanging();
			entity.Usuario = this;
		}
		
		private void detach_ContactoEmergencias(ContactoEmergencia entity)
		{
			this.SendPropertyChanging();
			entity.Usuario = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ContactoEmergencia")]
	public partial class ContactoEmergencia : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idContactoEmergencia;
		
		private string _nombre;
		
		private string _telefono;
		
		private string _email;
		
		private System.Nullable<int> _idUsuario;
		
		private System.Nullable<int> _prioridad;
		
		private EntityRef<Usuario> _Usuario;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidContactoEmergenciaChanging(int value);
    partial void OnidContactoEmergenciaChanged();
    partial void OnnombreChanging(string value);
    partial void OnnombreChanged();
    partial void OntelefonoChanging(string value);
    partial void OntelefonoChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OnidUsuarioChanging(System.Nullable<int> value);
    partial void OnidUsuarioChanged();
    partial void OnprioridadChanging(System.Nullable<int> value);
    partial void OnprioridadChanged();
    #endregion
		
		public ContactoEmergencia()
		{
			this._Usuario = default(EntityRef<Usuario>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idContactoEmergencia", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idContactoEmergencia
		{
			get
			{
				return this._idContactoEmergencia;
			}
			set
			{
				if ((this._idContactoEmergencia != value))
				{
					this.OnidContactoEmergenciaChanging(value);
					this.SendPropertyChanging();
					this._idContactoEmergencia = value;
					this.SendPropertyChanged("idContactoEmergencia");
					this.OnidContactoEmergenciaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre", DbType="VarChar(50)")]
		public string nombre
		{
			get
			{
				return this._nombre;
			}
			set
			{
				if ((this._nombre != value))
				{
					this.OnnombreChanging(value);
					this.SendPropertyChanging();
					this._nombre = value;
					this.SendPropertyChanged("nombre");
					this.OnnombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_telefono", DbType="VarChar(50)")]
		public string telefono
		{
			get
			{
				return this._telefono;
			}
			set
			{
				if ((this._telefono != value))
				{
					this.OntelefonoChanging(value);
					this.SendPropertyChanging();
					this._telefono = value;
					this.SendPropertyChanged("telefono");
					this.OntelefonoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(50)")]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idUsuario", DbType="Int")]
		public System.Nullable<int> idUsuario
		{
			get
			{
				return this._idUsuario;
			}
			set
			{
				if ((this._idUsuario != value))
				{
					if (this._Usuario.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidUsuarioChanging(value);
					this.SendPropertyChanging();
					this._idUsuario = value;
					this.SendPropertyChanged("idUsuario");
					this.OnidUsuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_prioridad", DbType="Int")]
		public System.Nullable<int> prioridad
		{
			get
			{
				return this._prioridad;
			}
			set
			{
				if ((this._prioridad != value))
				{
					this.OnprioridadChanging(value);
					this.SendPropertyChanging();
					this._prioridad = value;
					this.SendPropertyChanged("prioridad");
					this.OnprioridadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Usuario_ContactoEmergencia", Storage="_Usuario", ThisKey="idUsuario", OtherKey="idUsuario", IsForeignKey=true)]
		public Usuario Usuario
		{
			get
			{
				return this._Usuario.Entity;
			}
			set
			{
				Usuario previousValue = this._Usuario.Entity;
				if (((previousValue != value) 
							|| (this._Usuario.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Usuario.Entity = null;
						previousValue.ContactoEmergencias.Remove(this);
					}
					this._Usuario.Entity = value;
					if ((value != null))
					{
						value.ContactoEmergencias.Add(this);
						this._idUsuario = value.idUsuario;
					}
					else
					{
						this._idUsuario = default(Nullable<int>);
					}
					this.SendPropertyChanged("Usuario");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Sexo")]
	public partial class Sexo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idSexo;
		
		private string _Nombre;
		
		private EntitySet<Usuario> _Usuarios;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidSexoChanging(int value);
    partial void OnidSexoChanged();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    #endregion
		
		public Sexo()
		{
			this._Usuarios = new EntitySet<Usuario>(new Action<Usuario>(this.attach_Usuarios), new Action<Usuario>(this.detach_Usuarios));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idSexo", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idSexo
		{
			get
			{
				return this._idSexo;
			}
			set
			{
				if ((this._idSexo != value))
				{
					this.OnidSexoChanging(value);
					this.SendPropertyChanging();
					this._idSexo = value;
					this.SendPropertyChanged("idSexo");
					this.OnidSexoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(50)")]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this.OnNombreChanging(value);
					this.SendPropertyChanging();
					this._Nombre = value;
					this.SendPropertyChanged("Nombre");
					this.OnNombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Sexo_Usuario", Storage="_Usuarios", ThisKey="idSexo", OtherKey="idsexo")]
		public EntitySet<Usuario> Usuarios
		{
			get
			{
				return this._Usuarios;
			}
			set
			{
				this._Usuarios.Assign(value);
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
		
		private void attach_Usuarios(Usuario entity)
		{
			this.SendPropertyChanging();
			entity.Sexo = this;
		}
		
		private void detach_Usuarios(Usuario entity)
		{
			this.SendPropertyChanging();
			entity.Sexo = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TIpoAlerta")]
	public partial class TIpoAlerta : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idTipoAlerta;
		
		private string _tipo;
		
		private EntitySet<Alerta> _Alertas;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidTipoAlertaChanging(int value);
    partial void OnidTipoAlertaChanged();
    partial void OntipoChanging(string value);
    partial void OntipoChanged();
    #endregion
		
		public TIpoAlerta()
		{
			this._Alertas = new EntitySet<Alerta>(new Action<Alerta>(this.attach_Alertas), new Action<Alerta>(this.detach_Alertas));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idTipoAlerta", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idTipoAlerta
		{
			get
			{
				return this._idTipoAlerta;
			}
			set
			{
				if ((this._idTipoAlerta != value))
				{
					this.OnidTipoAlertaChanging(value);
					this.SendPropertyChanging();
					this._idTipoAlerta = value;
					this.SendPropertyChanged("idTipoAlerta");
					this.OnidTipoAlertaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tipo", DbType="VarChar(50)")]
		public string tipo
		{
			get
			{
				return this._tipo;
			}
			set
			{
				if ((this._tipo != value))
				{
					this.OntipoChanging(value);
					this.SendPropertyChanging();
					this._tipo = value;
					this.SendPropertyChanged("tipo");
					this.OntipoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TIpoAlerta_Alerta", Storage="_Alertas", ThisKey="idTipoAlerta", OtherKey="idTipoAlerta")]
		public EntitySet<Alerta> Alertas
		{
			get
			{
				return this._Alertas;
			}
			set
			{
				this._Alertas.Assign(value);
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
		
		private void attach_Alertas(Alerta entity)
		{
			this.SendPropertyChanging();
			entity.TIpoAlerta = this;
		}
		
		private void detach_Alertas(Alerta entity)
		{
			this.SendPropertyChanging();
			entity.TIpoAlerta = null;
		}
	}
}
#pragma warning restore 1591