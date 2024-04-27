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

namespace Sistema_Asistencia_BLHH.DataClase
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="db_Asistencia")]
	public partial class DataClasesResumenDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    #endregion
		
		public DataClasesResumenDataContext() : 
				base(global::Sistema_Asistencia_BLHH.Properties.Settings.Default.db_AsistenciaConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasesResumenDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasesResumenDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasesResumenDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasesResumenDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_LoginUsuario")]
		public ISingleResult<SP_LoginUsuarioResult> SP_LoginUsuario([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(30)")] string pusuario, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(100)")] string ppassword)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), pusuario, ppassword);
			return ((ISingleResult<SP_LoginUsuarioResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_BuscarAsistenciasPorDia")]
		public ISingleResult<SP_BuscarAsistenciasPorDiaResult> SP_BuscarAsistenciasPorDia([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Date")] System.Nullable<System.DateTime> fecha)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), fecha);
			return ((ISingleResult<SP_BuscarAsistenciasPorDiaResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_BuscarEmpleado")]
		public ISingleResult<SP_BuscarEmpleadoResult> SP_BuscarEmpleado([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string buscar)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), buscar);
			return ((ISingleResult<SP_BuscarEmpleadoResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_ObtenerFaltasPorEmpleado")]
		public ISingleResult<SP_ObtenerFaltasPorEmpleadoResult> SP_ObtenerFaltasPorEmpleado([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string buscar)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), buscar);
			return ((ISingleResult<SP_ObtenerFaltasPorEmpleadoResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_ObtenerFaltasPorFecha")]
		public ISingleResult<SP_ObtenerFaltasPorFechaResult> SP_ObtenerFaltasPorFecha([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Date")] System.Nullable<System.DateTime> fecha)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), fecha);
			return ((ISingleResult<SP_ObtenerFaltasPorFechaResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_ObtenerTardanzas")]
		public ISingleResult<SP_ObtenerTardanzasResult> SP_ObtenerTardanzas([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string buscar, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Date")] System.Nullable<System.DateTime> dia)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), buscar, dia);
			return ((ISingleResult<SP_ObtenerTardanzasResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_MarcarAsistencia")]
		public ISingleResult<SP_MarcarAsistenciaResult> SP_MarcarAsistencia([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nombre", DbType="VarChar(100)")] string nombre, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DNI", DbType="VarChar(20)")] string dNI)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nombre, dNI);
			return ((ISingleResult<SP_MarcarAsistenciaResult>)(result.ReturnValue));
		}
	}
	
	public partial class SP_LoginUsuarioResult
	{
		
		private int _IdUsuario;
		
		private string _Nombre;
		
		private string _Nivel;
		
		public SP_LoginUsuarioResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdUsuario", DbType="Int NOT NULL")]
		public int IdUsuario
		{
			get
			{
				return this._IdUsuario;
			}
			set
			{
				if ((this._IdUsuario != value))
				{
					this._IdUsuario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
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
					this._Nombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nivel", DbType="VarChar(15) NOT NULL", CanBeNull=false)]
		public string Nivel
		{
			get
			{
				return this._Nivel;
			}
			set
			{
				if ((this._Nivel != value))
				{
					this._Nivel = value;
				}
			}
		}
	}
	
	public partial class SP_BuscarAsistenciasPorDiaResult
	{
		
		private int _IdAsistencia;
		
		private string _Nombre;
		
		private string _Apellido;
		
		private System.DateTime _FechaAsistencia;
		
		private System.Nullable<System.TimeSpan> _HoraEntrada;
		
		private System.Nullable<System.TimeSpan> _HoraSalida;
		
		public SP_BuscarAsistenciasPorDiaResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdAsistencia", DbType="Int NOT NULL")]
		public int IdAsistencia
		{
			get
			{
				return this._IdAsistencia;
			}
			set
			{
				if ((this._IdAsistencia != value))
				{
					this._IdAsistencia = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
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
					this._Nombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Apellido", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Apellido
		{
			get
			{
				return this._Apellido;
			}
			set
			{
				if ((this._Apellido != value))
				{
					this._Apellido = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaAsistencia", DbType="Date NOT NULL")]
		public System.DateTime FechaAsistencia
		{
			get
			{
				return this._FechaAsistencia;
			}
			set
			{
				if ((this._FechaAsistencia != value))
				{
					this._FechaAsistencia = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoraEntrada", DbType="Time")]
		public System.Nullable<System.TimeSpan> HoraEntrada
		{
			get
			{
				return this._HoraEntrada;
			}
			set
			{
				if ((this._HoraEntrada != value))
				{
					this._HoraEntrada = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoraSalida", DbType="Time")]
		public System.Nullable<System.TimeSpan> HoraSalida
		{
			get
			{
				return this._HoraSalida;
			}
			set
			{
				if ((this._HoraSalida != value))
				{
					this._HoraSalida = value;
				}
			}
		}
	}
	
	public partial class SP_BuscarEmpleadoResult
	{
		
		private int _IdEmpleado;
		
		private string _NombreArea;
		
		private string _Nombre;
		
		private string _Apellido;
		
		private string _DNI;
		
		private System.Nullable<char> _Genero;
		
		private string _Telefono;
		
		private System.Nullable<char> _Estado;
		
		public SP_BuscarEmpleadoResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdEmpleado", DbType="Int NOT NULL")]
		public int IdEmpleado
		{
			get
			{
				return this._IdEmpleado;
			}
			set
			{
				if ((this._IdEmpleado != value))
				{
					this._IdEmpleado = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NombreArea", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string NombreArea
		{
			get
			{
				return this._NombreArea;
			}
			set
			{
				if ((this._NombreArea != value))
				{
					this._NombreArea = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
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
					this._Nombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Apellido", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Apellido
		{
			get
			{
				return this._Apellido;
			}
			set
			{
				if ((this._Apellido != value))
				{
					this._Apellido = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DNI", DbType="Char(8) NOT NULL", CanBeNull=false)]
		public string DNI
		{
			get
			{
				return this._DNI;
			}
			set
			{
				if ((this._DNI != value))
				{
					this._DNI = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Genero", DbType="Char(1)")]
		public System.Nullable<char> Genero
		{
			get
			{
				return this._Genero;
			}
			set
			{
				if ((this._Genero != value))
				{
					this._Genero = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Telefono", DbType="VarChar(20)")]
		public string Telefono
		{
			get
			{
				return this._Telefono;
			}
			set
			{
				if ((this._Telefono != value))
				{
					this._Telefono = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Estado", DbType="Char(1)")]
		public System.Nullable<char> Estado
		{
			get
			{
				return this._Estado;
			}
			set
			{
				if ((this._Estado != value))
				{
					this._Estado = value;
				}
			}
		}
	}
	
	public partial class SP_ObtenerFaltasPorEmpleadoResult
	{
		
		private int _IdEmpleado;
		
		private string _Nombre;
		
		private string _Apellido;
		
		private System.Nullable<int> _Falta;
		
		public SP_ObtenerFaltasPorEmpleadoResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdEmpleado", DbType="Int NOT NULL")]
		public int IdEmpleado
		{
			get
			{
				return this._IdEmpleado;
			}
			set
			{
				if ((this._IdEmpleado != value))
				{
					this._IdEmpleado = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
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
					this._Nombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Apellido", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Apellido
		{
			get
			{
				return this._Apellido;
			}
			set
			{
				if ((this._Apellido != value))
				{
					this._Apellido = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Falta", DbType="Int")]
		public System.Nullable<int> Falta
		{
			get
			{
				return this._Falta;
			}
			set
			{
				if ((this._Falta != value))
				{
					this._Falta = value;
				}
			}
		}
	}
	
	public partial class SP_ObtenerFaltasPorFechaResult
	{
		
		private int _IdEmpleado;
		
		private string _Nombre;
		
		private string _Apellido;
		
		private string _NombreArea;
		
		private System.Nullable<int> _Falta;
		
		public SP_ObtenerFaltasPorFechaResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdEmpleado", DbType="Int NOT NULL")]
		public int IdEmpleado
		{
			get
			{
				return this._IdEmpleado;
			}
			set
			{
				if ((this._IdEmpleado != value))
				{
					this._IdEmpleado = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
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
					this._Nombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Apellido", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Apellido
		{
			get
			{
				return this._Apellido;
			}
			set
			{
				if ((this._Apellido != value))
				{
					this._Apellido = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NombreArea", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string NombreArea
		{
			get
			{
				return this._NombreArea;
			}
			set
			{
				if ((this._NombreArea != value))
				{
					this._NombreArea = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Falta", DbType="Int")]
		public System.Nullable<int> Falta
		{
			get
			{
				return this._Falta;
			}
			set
			{
				if ((this._Falta != value))
				{
					this._Falta = value;
				}
			}
		}
	}
	
	public partial class SP_ObtenerTardanzasResult
	{
		
		private int _IdEmpleado;
		
		private string _Nombre;
		
		private string _Apellido;
		
		private System.DateTime _FechaAsistencia;
		
		private System.Nullable<System.TimeSpan> _HoraEntrada;
		
		private System.TimeSpan _HoraEntradaEsperada;
		
		private string _Area;
		
		private System.Nullable<int> _TardanzaEnMinutos;
		
		public SP_ObtenerTardanzasResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdEmpleado", DbType="Int NOT NULL")]
		public int IdEmpleado
		{
			get
			{
				return this._IdEmpleado;
			}
			set
			{
				if ((this._IdEmpleado != value))
				{
					this._IdEmpleado = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
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
					this._Nombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Apellido", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Apellido
		{
			get
			{
				return this._Apellido;
			}
			set
			{
				if ((this._Apellido != value))
				{
					this._Apellido = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaAsistencia", DbType="Date NOT NULL")]
		public System.DateTime FechaAsistencia
		{
			get
			{
				return this._FechaAsistencia;
			}
			set
			{
				if ((this._FechaAsistencia != value))
				{
					this._FechaAsistencia = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoraEntrada", DbType="Time")]
		public System.Nullable<System.TimeSpan> HoraEntrada
		{
			get
			{
				return this._HoraEntrada;
			}
			set
			{
				if ((this._HoraEntrada != value))
				{
					this._HoraEntrada = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoraEntradaEsperada", DbType="Time NOT NULL")]
		public System.TimeSpan HoraEntradaEsperada
		{
			get
			{
				return this._HoraEntradaEsperada;
			}
			set
			{
				if ((this._HoraEntradaEsperada != value))
				{
					this._HoraEntradaEsperada = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Area", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Area
		{
			get
			{
				return this._Area;
			}
			set
			{
				if ((this._Area != value))
				{
					this._Area = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TardanzaEnMinutos", DbType="Int")]
		public System.Nullable<int> TardanzaEnMinutos
		{
			get
			{
				return this._TardanzaEnMinutos;
			}
			set
			{
				if ((this._TardanzaEnMinutos != value))
				{
					this._TardanzaEnMinutos = value;
				}
			}
		}
	}
	
	public partial class SP_MarcarAsistenciaResult
	{
		
		private string _Mensaje;
		
		public SP_MarcarAsistenciaResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mensaje", DbType="VarChar(33) NOT NULL", CanBeNull=false)]
		public string Mensaje
		{
			get
			{
				return this._Mensaje;
			}
			set
			{
				if ((this._Mensaje != value))
				{
					this._Mensaje = value;
				}
			}
		}
	}
}
#pragma warning restore 1591