/*
				   File: type_SdtSDT_MicroUserInfo_Tenants
			Description: Tenants
				 Author: Nemo for C# version 16.0.0.127771
		   Generated on: 2020/2/28 15:18:02
		   Program type: Callable routine
			  Main DBMS: SQL Server
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Cryptography;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using GeneXus.Http.Server;
using System.Reflection;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Web.Services.Protocols;


namespace GeneXus.Programs{
	[XmlSerializerFormat]
	[XmlRoot(ElementName="SDT_MicroUserInfo.Tenants")]
	[XmlType(TypeName="SDT_MicroUserInfo.Tenants" , Namespace="DataAnalysisPlatform" )]
	[Serializable]
	public class SdtSDT_MicroUserInfo_Tenants : GxUserType
	{
		public SdtSDT_MicroUserInfo_Tenants( )
		{
			/* Constructor for serialization */
			gxTv_SdtSDT_MicroUserInfo_Tenants_Code = "";

			gxTv_SdtSDT_MicroUserInfo_Tenants_Name = "";

		}

		public SdtSDT_MicroUserInfo_Tenants(IGxContext context)
		{
			this.context = context;
			initialize();
		}

		#region Json
		private static Hashtable mapper;
		public override String JsonMap(String value)
		{
			if (mapper == null)
			{
				mapper = new Hashtable();
			}
			return (String)mapper[value]; ;
		}

		public override void ToJSON()
		{
			ToJSON(true) ;
			return;
		}

		public override void ToJSON(bool includeState)
		{
			AddObjectProperty("Code", gxTpr_Code, false);
			AddObjectProperty("Name", gxTpr_Name, false);
			AddObjectProperty("Permissions", gxTv_SdtSDT_MicroUserInfo_Tenants_Permissions, false);  
			AddObjectProperty("DataScoptes", gxTv_SdtSDT_MicroUserInfo_Tenants_Datascoptes, false);  
			return;
		}
		#endregion

		#region Properties

		[SoapElement(ElementName="Code")]
		[XmlElement(ElementName="Code")]
		public String gxTpr_Code
		{
			get { 
				return gxTv_SdtSDT_MicroUserInfo_Tenants_Code; 
			}
			set { 
				gxTv_SdtSDT_MicroUserInfo_Tenants_Code = value;
				SetDirty("Code");
			}
		}


		[SoapElement(ElementName="Name")]
		[XmlElement(ElementName="Name")]
		public String gxTpr_Name
		{
			get { 
				return gxTv_SdtSDT_MicroUserInfo_Tenants_Name; 
			}
			set { 
				gxTv_SdtSDT_MicroUserInfo_Tenants_Name = value;
				SetDirty("Name");
			}
		}


		[SoapElement(ElementName="Permissions" )]
		[XmlArray(ElementName="Permissions"  )]
		[XmlArrayItemAttribute(ElementName="Item" , IsNullable=false )]
		public GxSimpleCollection<String> gxTpr_Permissions_GxSimpleCollection
		{
			get {
				if ( gxTv_SdtSDT_MicroUserInfo_Tenants_Permissions == null )
				{
					gxTv_SdtSDT_MicroUserInfo_Tenants_Permissions = new GxSimpleCollection<String>( );
				}
				return gxTv_SdtSDT_MicroUserInfo_Tenants_Permissions;
			}
			set {
				if ( gxTv_SdtSDT_MicroUserInfo_Tenants_Permissions == null )
				{
					gxTv_SdtSDT_MicroUserInfo_Tenants_Permissions = new GxSimpleCollection<String>( );
				}
				gxTv_SdtSDT_MicroUserInfo_Tenants_Permissions = value;
			}
		}

		[SoapIgnore]
		[XmlIgnore]
		public GxSimpleCollection<String> gxTpr_Permissions
		{
			get {
				if ( gxTv_SdtSDT_MicroUserInfo_Tenants_Permissions == null )
				{
					gxTv_SdtSDT_MicroUserInfo_Tenants_Permissions = new GxSimpleCollection<String>();
				}
				return gxTv_SdtSDT_MicroUserInfo_Tenants_Permissions ;
			}
			set {
				gxTv_SdtSDT_MicroUserInfo_Tenants_Permissions = value;
				SetDirty("Permissions");
			}
		}

		public void gxTv_SdtSDT_MicroUserInfo_Tenants_Permissions_SetNull()
		{
			gxTv_SdtSDT_MicroUserInfo_Tenants_Permissions = null;
			return  ;
		}

		public bool gxTv_SdtSDT_MicroUserInfo_Tenants_Permissions_IsNull()
		{
			if (gxTv_SdtSDT_MicroUserInfo_Tenants_Permissions == null)
			{
				return true ;
			}
			return false ;
		}



		[SoapElement(ElementName="DataScoptes" )]
		[XmlArray(ElementName="DataScoptes"  )]
		[XmlArrayItemAttribute(ElementName="Item" , IsNullable=false )]
		public GxSimpleCollection<String> gxTpr_Datascoptes_GxSimpleCollection
		{
			get {
				if ( gxTv_SdtSDT_MicroUserInfo_Tenants_Datascoptes == null )
				{
					gxTv_SdtSDT_MicroUserInfo_Tenants_Datascoptes = new GxSimpleCollection<String>( );
				}
				return gxTv_SdtSDT_MicroUserInfo_Tenants_Datascoptes;
			}
			set {
				if ( gxTv_SdtSDT_MicroUserInfo_Tenants_Datascoptes == null )
				{
					gxTv_SdtSDT_MicroUserInfo_Tenants_Datascoptes = new GxSimpleCollection<String>( );
				}
				gxTv_SdtSDT_MicroUserInfo_Tenants_Datascoptes = value;
			}
		}

		[SoapIgnore]
		[XmlIgnore]
		public GxSimpleCollection<String> gxTpr_Datascoptes
		{
			get {
				if ( gxTv_SdtSDT_MicroUserInfo_Tenants_Datascoptes == null )
				{
					gxTv_SdtSDT_MicroUserInfo_Tenants_Datascoptes = new GxSimpleCollection<String>();
				}
				return gxTv_SdtSDT_MicroUserInfo_Tenants_Datascoptes ;
			}
			set {
				gxTv_SdtSDT_MicroUserInfo_Tenants_Datascoptes = value;
				SetDirty("Datascoptes");
			}
		}

		public void gxTv_SdtSDT_MicroUserInfo_Tenants_Datascoptes_SetNull()
		{
			gxTv_SdtSDT_MicroUserInfo_Tenants_Datascoptes = null;
			return  ;
		}

		public bool gxTv_SdtSDT_MicroUserInfo_Tenants_Datascoptes_IsNull()
		{
			if (gxTv_SdtSDT_MicroUserInfo_Tenants_Datascoptes == null)
			{
				return true ;
			}
			return false ;
		}



		#endregion

		#region Initialization

		public void initialize( )
		{
			gxTv_SdtSDT_MicroUserInfo_Tenants_Code = "";
			gxTv_SdtSDT_MicroUserInfo_Tenants_Name = "";


			return  ;
		}



		#endregion

		#region Declaration

		protected String gxTv_SdtSDT_MicroUserInfo_Tenants_Code;
		protected String gxTv_SdtSDT_MicroUserInfo_Tenants_Name;
		protected GxSimpleCollection<String> gxTv_SdtSDT_MicroUserInfo_Tenants_Permissions = null; protected GxSimpleCollection<String> gxTv_SdtSDT_MicroUserInfo_Tenants_Datascoptes = null; 


		#endregion
	}
	#region Rest interface
	[DataContract(Name=@"SDT_MicroUserInfo.Tenants", Namespace="DataAnalysisPlatform")]
	public class SdtSDT_MicroUserInfo_Tenants_RESTInterface : GxGenericCollectionItem<SdtSDT_MicroUserInfo_Tenants>, System.Web.SessionState.IRequiresSessionState
	{
		public SdtSDT_MicroUserInfo_Tenants_RESTInterface( ) : base()
		{
		}

		public SdtSDT_MicroUserInfo_Tenants_RESTInterface( SdtSDT_MicroUserInfo_Tenants psdt ) : base(psdt)
		{
		}

		#region Rest Properties
		[DataMember(Name="Code", Order=0)]
		public String gxTpr_Code
		{
			get { 
				return sdt.gxTpr_Code;
			}
			set { 
				sdt.gxTpr_Code = value;
			}
		}

		[DataMember(Name="Name", Order=1)]
		public String gxTpr_Name
		{
			get { 
				return sdt.gxTpr_Name;
			}
			set { 
				sdt.gxTpr_Name = value;
			}
		}

		[DataMember(Name="Permissions", Order=2)]
		public  GxSimpleCollection<String> gxTpr_Permissions
		{
			get { 
				return sdt.gxTpr_Permissions;
			}
			set { 
				sdt.gxTpr_Permissions = value;
			}
		}

		[DataMember(Name="DataScoptes", Order=3)]
		public  GxSimpleCollection<String> gxTpr_Datascoptes
		{
			get { 
				return sdt.gxTpr_Datascoptes;
			}
			set { 
				sdt.gxTpr_Datascoptes = value;
			}
		}


		#endregion

		public SdtSDT_MicroUserInfo_Tenants sdt
		{
			get { 
				return (SdtSDT_MicroUserInfo_Tenants)Sdt;
			}
			set { 
				Sdt = value;
			}
		}

		[OnDeserializing]
		void checkSdt( StreamingContext ctx )
		{
			if ( sdt == null )
			{
				sdt = new SdtSDT_MicroUserInfo_Tenants() ;
			}
		}
	}
	#endregion
}