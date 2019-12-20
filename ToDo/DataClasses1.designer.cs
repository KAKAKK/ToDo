﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ToDo
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ToDoDB")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 可扩展性方法定义
    partial void OnCreated();
    partial void InsertmyPlan(myPlan instance);
    partial void UpdatemyPlan(myPlan instance);
    partial void DeletemyPlan(myPlan instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::ToDo.Properties.Settings.Default.ToDoDBConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<myPlan> myPlan
		{
			get
			{
				return this.GetTable<myPlan>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.myPlan")]
	public partial class myPlan : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _KeyWord;
		
		private string _PlanText;
		
		private string _Grade;
		
		private string _Statu;
		
		private string _Type;
		
		private System.DateTime _BeginTime;
		
		private System.DateTime _EndTime;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnKeyWordChanging(string value);
    partial void OnKeyWordChanged();
    partial void OnPlanTextChanging(string value);
    partial void OnPlanTextChanged();
    partial void OnGradeChanging(string value);
    partial void OnGradeChanged();
    partial void OnStatuChanging(string value);
    partial void OnStatuChanged();
    partial void OnTypeChanging(string value);
    partial void OnTypeChanged();
    partial void OnBeginTimeChanging(System.DateTime value);
    partial void OnBeginTimeChanged();
    partial void OnEndTimeChanging(System.DateTime value);
    partial void OnEndTimeChanged();
    #endregion
		
		public myPlan()
		{
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KeyWord", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string KeyWord
		{
			get
			{
				return this._KeyWord;
			}
			set
			{
				if ((this._KeyWord != value))
				{
					this.OnKeyWordChanging(value);
					this.SendPropertyChanging();
					this._KeyWord = value;
					this.SendPropertyChanged("KeyWord");
					this.OnKeyWordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PlanText", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string PlanText
		{
			get
			{
				return this._PlanText;
			}
			set
			{
				if ((this._PlanText != value))
				{
					this.OnPlanTextChanging(value);
					this.SendPropertyChanging();
					this._PlanText = value;
					this.SendPropertyChanged("PlanText");
					this.OnPlanTextChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Grade", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Grade
		{
			get
			{
				return this._Grade;
			}
			set
			{
				if ((this._Grade != value))
				{
					this.OnGradeChanging(value);
					this.SendPropertyChanging();
					this._Grade = value;
					this.SendPropertyChanged("Grade");
					this.OnGradeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Statu", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Statu
		{
			get
			{
				return this._Statu;
			}
			set
			{
				if ((this._Statu != value))
				{
					this.OnStatuChanging(value);
					this.SendPropertyChanging();
					this._Statu = value;
					this.SendPropertyChanged("Statu");
					this.OnStatuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Type", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Type
		{
			get
			{
				return this._Type;
			}
			set
			{
				if ((this._Type != value))
				{
					this.OnTypeChanging(value);
					this.SendPropertyChanging();
					this._Type = value;
					this.SendPropertyChanged("Type");
					this.OnTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BeginTime", DbType="Date NOT NULL")]
		public System.DateTime BeginTime
		{
			get
			{
				return this._BeginTime;
			}
			set
			{
				if ((this._BeginTime != value))
				{
					this.OnBeginTimeChanging(value);
					this.SendPropertyChanging();
					this._BeginTime = value;
					this.SendPropertyChanged("BeginTime");
					this.OnBeginTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EndTime", DbType="Date NOT NULL")]
		public System.DateTime EndTime
		{
			get
			{
				return this._EndTime;
			}
			set
			{
				if ((this._EndTime != value))
				{
					this.OnEndTimeChanging(value);
					this.SendPropertyChanging();
					this._EndTime = value;
					this.SendPropertyChanged("EndTime");
					this.OnEndTimeChanged();
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
