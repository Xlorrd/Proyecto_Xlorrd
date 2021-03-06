﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Capa_Datos
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ProyectoCitas")]
	public partial class Proyecto_CitasDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertPersona(Persona instance);
    partial void UpdatePersona(Persona instance);
    partial void DeletePersona(Persona instance);
    #endregion
		
		public Proyecto_CitasDataContext() : 
				base(global::Capa_Datos.Properties.Settings.Default.ProyectoCitasConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public Proyecto_CitasDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Proyecto_CitasDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Proyecto_CitasDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Proyecto_CitasDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Persona> Persona
		{
			get
			{
				return this.GetTable<Persona>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Migrar_datos_persona")]
		public ISingleResult<Migrar_datos_personaResult> Migrar_datos_persona()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<Migrar_datos_personaResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Mostrar_Persona")]
		public ISingleResult<Mostrar_PersonaResult> Mostrar_Persona()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<Mostrar_PersonaResult>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Persona")]
	public partial class Persona : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _per_id;
		
		private string _per_nombres;
		
		private string _per_apellidos;
		
		private System.Nullable<int> _per_cedula;
		
		private string _per_email;
		
		private string _per_telefono;
		
		private string _per_fechanacimiento;
		
		private string _per_genero;
		
		private string _per_direccion;
		
		private string _per_estado;
		
		private string _per_fechaCreacion;
		
		private string _per_usuario;
		
		private string _per_contrasenia;
		
		private System.Nullable<int> _id_tipousu;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onper_idChanging(int value);
    partial void Onper_idChanged();
    partial void Onper_nombresChanging(string value);
    partial void Onper_nombresChanged();
    partial void Onper_apellidosChanging(string value);
    partial void Onper_apellidosChanged();
    partial void Onper_cedulaChanging(System.Nullable<int> value);
    partial void Onper_cedulaChanged();
    partial void Onper_emailChanging(string value);
    partial void Onper_emailChanged();
    partial void Onper_telefonoChanging(string value);
    partial void Onper_telefonoChanged();
    partial void Onper_fechanacimientoChanging(string value);
    partial void Onper_fechanacimientoChanged();
    partial void Onper_generoChanging(string value);
    partial void Onper_generoChanged();
    partial void Onper_direccionChanging(string value);
    partial void Onper_direccionChanged();
    partial void Onper_estadoChanging(string value);
    partial void Onper_estadoChanged();
    partial void Onper_fechaCreacionChanging(string value);
    partial void Onper_fechaCreacionChanged();
    partial void Onper_usuarioChanging(string value);
    partial void Onper_usuarioChanged();
    partial void Onper_contraseniaChanging(string value);
    partial void Onper_contraseniaChanged();
    partial void Onid_tipousuChanging(System.Nullable<int> value);
    partial void Onid_tipousuChanged();
    #endregion
		
		public Persona()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_per_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int per_id
		{
			get
			{
				return this._per_id;
			}
			set
			{
				if ((this._per_id != value))
				{
					this.Onper_idChanging(value);
					this.SendPropertyChanging();
					this._per_id = value;
					this.SendPropertyChanged("per_id");
					this.Onper_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_per_nombres", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string per_nombres
		{
			get
			{
				return this._per_nombres;
			}
			set
			{
				if ((this._per_nombres != value))
				{
					this.Onper_nombresChanging(value);
					this.SendPropertyChanging();
					this._per_nombres = value;
					this.SendPropertyChanged("per_nombres");
					this.Onper_nombresChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_per_apellidos", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string per_apellidos
		{
			get
			{
				return this._per_apellidos;
			}
			set
			{
				if ((this._per_apellidos != value))
				{
					this.Onper_apellidosChanging(value);
					this.SendPropertyChanging();
					this._per_apellidos = value;
					this.SendPropertyChanged("per_apellidos");
					this.Onper_apellidosChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_per_cedula", DbType="Int")]
		public System.Nullable<int> per_cedula
		{
			get
			{
				return this._per_cedula;
			}
			set
			{
				if ((this._per_cedula != value))
				{
					this.Onper_cedulaChanging(value);
					this.SendPropertyChanging();
					this._per_cedula = value;
					this.SendPropertyChanged("per_cedula");
					this.Onper_cedulaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_per_email", DbType="VarChar(50)")]
		public string per_email
		{
			get
			{
				return this._per_email;
			}
			set
			{
				if ((this._per_email != value))
				{
					this.Onper_emailChanging(value);
					this.SendPropertyChanging();
					this._per_email = value;
					this.SendPropertyChanged("per_email");
					this.Onper_emailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_per_telefono", DbType="NChar(10)")]
		public string per_telefono
		{
			get
			{
				return this._per_telefono;
			}
			set
			{
				if ((this._per_telefono != value))
				{
					this.Onper_telefonoChanging(value);
					this.SendPropertyChanging();
					this._per_telefono = value;
					this.SendPropertyChanged("per_telefono");
					this.Onper_telefonoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_per_fechanacimiento", DbType="NVarChar(50)")]
		public string per_fechanacimiento
		{
			get
			{
				return this._per_fechanacimiento;
			}
			set
			{
				if ((this._per_fechanacimiento != value))
				{
					this.Onper_fechanacimientoChanging(value);
					this.SendPropertyChanging();
					this._per_fechanacimiento = value;
					this.SendPropertyChanged("per_fechanacimiento");
					this.Onper_fechanacimientoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_per_genero", DbType="VarChar(50)")]
		public string per_genero
		{
			get
			{
				return this._per_genero;
			}
			set
			{
				if ((this._per_genero != value))
				{
					this.Onper_generoChanging(value);
					this.SendPropertyChanging();
					this._per_genero = value;
					this.SendPropertyChanged("per_genero");
					this.Onper_generoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_per_direccion", DbType="VarChar(100)")]
		public string per_direccion
		{
			get
			{
				return this._per_direccion;
			}
			set
			{
				if ((this._per_direccion != value))
				{
					this.Onper_direccionChanging(value);
					this.SendPropertyChanging();
					this._per_direccion = value;
					this.SendPropertyChanged("per_direccion");
					this.Onper_direccionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_per_estado", DbType="NVarChar(50)")]
		public string per_estado
		{
			get
			{
				return this._per_estado;
			}
			set
			{
				if ((this._per_estado != value))
				{
					this.Onper_estadoChanging(value);
					this.SendPropertyChanging();
					this._per_estado = value;
					this.SendPropertyChanged("per_estado");
					this.Onper_estadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_per_fechaCreacion", DbType="NVarChar(50)")]
		public string per_fechaCreacion
		{
			get
			{
				return this._per_fechaCreacion;
			}
			set
			{
				if ((this._per_fechaCreacion != value))
				{
					this.Onper_fechaCreacionChanging(value);
					this.SendPropertyChanging();
					this._per_fechaCreacion = value;
					this.SendPropertyChanged("per_fechaCreacion");
					this.Onper_fechaCreacionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_per_usuario", DbType="VarChar(50)")]
		public string per_usuario
		{
			get
			{
				return this._per_usuario;
			}
			set
			{
				if ((this._per_usuario != value))
				{
					this.Onper_usuarioChanging(value);
					this.SendPropertyChanging();
					this._per_usuario = value;
					this.SendPropertyChanged("per_usuario");
					this.Onper_usuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_per_contrasenia", DbType="VarChar(50)")]
		public string per_contrasenia
		{
			get
			{
				return this._per_contrasenia;
			}
			set
			{
				if ((this._per_contrasenia != value))
				{
					this.Onper_contraseniaChanging(value);
					this.SendPropertyChanging();
					this._per_contrasenia = value;
					this.SendPropertyChanged("per_contrasenia");
					this.Onper_contraseniaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_tipousu", DbType="Int")]
		public System.Nullable<int> id_tipousu
		{
			get
			{
				return this._id_tipousu;
			}
			set
			{
				if ((this._id_tipousu != value))
				{
					this.Onid_tipousuChanging(value);
					this.SendPropertyChanging();
					this._id_tipousu = value;
					this.SendPropertyChanged("id_tipousu");
					this.Onid_tipousuChanged();
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
	
	public partial class Migrar_datos_personaResult
	{
		
		private string _Nombres;
		
		private string _Apellidos;
		
		private System.Nullable<int> _Cédula;
		
		private string _Mail;
		
		private string _Dirección;
		
		public Migrar_datos_personaResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombres", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Nombres
		{
			get
			{
				return this._Nombres;
			}
			set
			{
				if ((this._Nombres != value))
				{
					this._Nombres = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Apellidos", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Apellidos
		{
			get
			{
				return this._Apellidos;
			}
			set
			{
				if ((this._Apellidos != value))
				{
					this._Apellidos = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cédula", DbType="Int")]
		public System.Nullable<int> Cédula
		{
			get
			{
				return this._Cédula;
			}
			set
			{
				if ((this._Cédula != value))
				{
					this._Cédula = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mail", DbType="VarChar(50)")]
		public string Mail
		{
			get
			{
				return this._Mail;
			}
			set
			{
				if ((this._Mail != value))
				{
					this._Mail = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dirección", DbType="VarChar(100)")]
		public string Dirección
		{
			get
			{
				return this._Dirección;
			}
			set
			{
				if ((this._Dirección != value))
				{
					this._Dirección = value;
				}
			}
		}
	}
	
	public partial class Mostrar_PersonaResult
	{
		
		private int _per_id;
		
		private string _per_nombres;
		
		private string _per_apellidos;
		
		private System.Nullable<int> _per_cedula;
		
		private string _per_email;
		
		private string _per_telefono;
		
		private string _per_fechanacimiento;
		
		private string _per_genero;
		
		private string _per_direccion;
		
		private string _per_estado;
		
		private string _per_fechaCreacion;
		
		private string _per_usuario;
		
		private string _per_contrasenia;
		
		private System.Nullable<int> _id_tipousu;
		
		public Mostrar_PersonaResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_per_id", DbType="Int NOT NULL")]
		public int per_id
		{
			get
			{
				return this._per_id;
			}
			set
			{
				if ((this._per_id != value))
				{
					this._per_id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_per_nombres", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string per_nombres
		{
			get
			{
				return this._per_nombres;
			}
			set
			{
				if ((this._per_nombres != value))
				{
					this._per_nombres = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_per_apellidos", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string per_apellidos
		{
			get
			{
				return this._per_apellidos;
			}
			set
			{
				if ((this._per_apellidos != value))
				{
					this._per_apellidos = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_per_cedula", DbType="Int")]
		public System.Nullable<int> per_cedula
		{
			get
			{
				return this._per_cedula;
			}
			set
			{
				if ((this._per_cedula != value))
				{
					this._per_cedula = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_per_email", DbType="VarChar(50)")]
		public string per_email
		{
			get
			{
				return this._per_email;
			}
			set
			{
				if ((this._per_email != value))
				{
					this._per_email = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_per_telefono", DbType="NChar(10)")]
		public string per_telefono
		{
			get
			{
				return this._per_telefono;
			}
			set
			{
				if ((this._per_telefono != value))
				{
					this._per_telefono = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_per_fechanacimiento", DbType="NVarChar(50)")]
		public string per_fechanacimiento
		{
			get
			{
				return this._per_fechanacimiento;
			}
			set
			{
				if ((this._per_fechanacimiento != value))
				{
					this._per_fechanacimiento = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_per_genero", DbType="VarChar(50)")]
		public string per_genero
		{
			get
			{
				return this._per_genero;
			}
			set
			{
				if ((this._per_genero != value))
				{
					this._per_genero = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_per_direccion", DbType="VarChar(100)")]
		public string per_direccion
		{
			get
			{
				return this._per_direccion;
			}
			set
			{
				if ((this._per_direccion != value))
				{
					this._per_direccion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_per_estado", DbType="NVarChar(50)")]
		public string per_estado
		{
			get
			{
				return this._per_estado;
			}
			set
			{
				if ((this._per_estado != value))
				{
					this._per_estado = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_per_fechaCreacion", DbType="NVarChar(50)")]
		public string per_fechaCreacion
		{
			get
			{
				return this._per_fechaCreacion;
			}
			set
			{
				if ((this._per_fechaCreacion != value))
				{
					this._per_fechaCreacion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_per_usuario", DbType="VarChar(50)")]
		public string per_usuario
		{
			get
			{
				return this._per_usuario;
			}
			set
			{
				if ((this._per_usuario != value))
				{
					this._per_usuario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_per_contrasenia", DbType="VarChar(50)")]
		public string per_contrasenia
		{
			get
			{
				return this._per_contrasenia;
			}
			set
			{
				if ((this._per_contrasenia != value))
				{
					this._per_contrasenia = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_tipousu", DbType="Int")]
		public System.Nullable<int> id_tipousu
		{
			get
			{
				return this._id_tipousu;
			}
			set
			{
				if ((this._id_tipousu != value))
				{
					this._id_tipousu = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
