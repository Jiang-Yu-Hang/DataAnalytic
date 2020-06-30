/*
				   File: type_SdtSDT_MicroUserInfo_Institutes
			Description: Institutes
				 Author: Nemo for C# version 16.0.0.127771
		   Generated on: 2020/2/27 12:08:05
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
	[XmlRoot(ElementName="SDT_MicroUserInfo.Institutes")]
	[XmlType(TypeName="SDT_MicroUserInfo.Institutes" , Namespace="DataAnalysisPlatform" )]
	[Serializable]
	public class SdtSDT_MicroUserInfo_Institutes : GxUserType
	{
		public SdtSDT_MicroUserInfo_Institutes( )
		{
			/* Constructor for serialization */
			gxTv_SdtSDT_MicroUserInfo_Institutes_Code = "";

			gxTv_SdtSDT_MicroUserInfo_Institutes_Name = "";

		}

		public SdtSDT_MicroUserInfo_Institutes(IGxContext context)
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
			AddObjectProperty("Permissions", gxTv_SdtSDT_MicroUserInfo_Institutes_Permissions, false);  
			AddObjectProperty("Tenants", gxTv_SdtSDT_MicroUserInfo_Institutes_Tenants, false);  
			return;
		}
		#endregion

		#region Properties

		[SoapElement(ElementName="Code")]
		[XmlElement(ElementName="Code")]
		public String gxTpr_Code
		{
			get { 
				return gxTv_SdtSDT_MicroUserInfo_Institutes_Code; 
			}
			set { 
				gxTv_SdtSDT_MicroUserInfo_Institutes_Code = value;
				SetDirty("Code");
			}
		}


		[SoapElement(ElementName="Name")]
		[XmlElement(ElementName="Name")]
		public String gxTpr_Name
		{
			get { 
				return gxTv_SdtSDT_MicroUserInfo_Institutes_Name; 
			}
			set { 
				gxTv_SdtSDT_MicroUserInfo_Institutes_Name = value;
				SetDirty("Name");
			}
		}


		[SoapElement(ElementName="Permissions" )]
		[XmlArray(ElementName="Permissions"  )]
		[XmlArrayItemAttribute(ElementName="Item" , IsNullable=false )]
		public GxSimpleCollection<String> gxTpr_Permissions_GxSimpleCollection
		{
			get {
				if ( gxTv_SdtSDT_MicroUserInfo_Institutes_Permissions == null )
				{
					gxTv_SdtSDT_MicroUserInfo_Institutes_Permissions = new GxSimpleCollection<String>( );
				}
				return gxTv_SdtSDT_MicroUserInfo_Institutes_Permissions;
			}
			set {
				if ( gxTv_SdtSDT_MicroUserInfo_Institutes_Permissions == null )
				{
					gxTv_SdtSDT_MicroUserInfo_Institutes_Permissions = new GxSimpleCollection<String>( );
				}
				gxTv_SdtSDT_MicroUserInfo_Institutes_Permissions = value;
			}
		}

		[SoapIgnore]
		[XmlIgnore]
		public GxSimpleCollection<String> gxTpr_Permissions
		{
			get {
				if ( gxTv_SdtSDT_MicroUserInfo_Institutes_Permissions == null )
				{
					gxTv_SdtSDT_MicroUserInfo_Institutes_Permissions = new GxSimpleCollection<String>();
				}
				return gxTv_SdtSDT_MicroUserInfo_Institutes_Permissions ;
			}
			set {
				gxTv_SdtSDT_MicroUserInfo_Institutes_Permissions = value;
				SetDirty("Permissions");
			}
		}

		public void gxTv_SdtSDT_MicroUserInfo_Institutes_Permissions_SetNull()
		{
			gxTv_SdtSDT_MicroUserInfo_Institutes_Permissions = null;
			return  ;
		}

		public bool gxTv_SdtSDT_MicroUserInfo_Institutes_Permissions_IsNull()
		{
			if (gxTv_SdtSDT_MicroUserInfo_Institutes_Permissions == null)
			{
				return true ;
			}
			return false ;
		}



		[SoapElement(ElementName="Tenants" )]
		[XmlArray(ElementName="Tenants"  )]
		[XmlArrayItemAttribute(ElementName="Item" , IsNullable=false )]
		public GxSimpleCollection<String> gxTpr_Tenants_GxSimpleCollection
		{
			get {
				if ( gxTv_SdtSDT_MicroUserInfo_Institutes_Tenants == null )
				{
					gxTv_SdtSDT_MicroUserInfo_Institutes_Tenants = new GxSimpleCollection<String>( );
				}
				return gxTv_SdtSDT_MicroUserInfo_Institutes_Tenants;
			}
			set {
				if ( gxTv_SdtSDT_MicroUserInfo_Institutes_Tenants == null )
				{
					gxTv_SdtSDT_MicroUserInfo_Institutes_Tenants = new GxSimpleCollection<String>( );
				}
				gxTv_SdtSDT_MicroUserInfo_Institutes_Tenants = value;
			}
		}

		[SoapIgnore]
		[XmlIgnore]
		public GxSimpleCollection<String> gxTpr_Tenants
		{
			get {
				if ( gxTv_SdtSDT_MicroUserInfo_Institutes_Tenants == null )
				{
					gxTv_SdtSDT_MicroUserInfo_Institutes_Tenants = new GxSimpleCollection<String>();
				}
				return gxTv_SdtSDT_MicroUserInfo_Institutes_Tenants ;
			}
			set {
				gxTv_SdtSDT_MicroUserInfo_Institutes_Tenants = value;
				SetDirty("Tenants");
			}
		}

		public void gxTv_SdtSDT_MicroUserInfo_Institutes_Tenants_SetNull()
		{
			gxTv_SdtSDT_MicroUserInfo_Institutes_Tenants = null;
			return  ;
		}

		public bool gxTv_SdtSDT_MicroUserInfo_Institutes_Tenants_IsNull()
		{
			if (gxTv_SdtSDT_MicroUserInfo_Institutes_Tenants == null)
			{
				return true ;
			}
			return false ;
		}



		#endregion

		#region Initialization

		public void initialize( )
		{
			gxTv_SdtSDT_MicroUserInfo_Institutes_Code = "";
			gxTv_SdtSDT_MicroUserInfo_Institutes_Name = "";


			return  ;
		}



		#endregion

		#region Declaration

		protected String gxTv_SdtSDT_MicroUserInfo_Institutes_Code;
		protected String gxTv_SdtSDT_MicroUserInfo_Institutes_Name;
		protected GxSimpleCollection<String> gxTv_SdtSDT_MicroUserInfo_Institutes_Permissions = null; protected GxSimpleCollection<String> gxTv_SdtSDT_MicroUserInfo_Institutes_Tenants = null; 


		#endregion
	}
	#region Rest interface
	[DataContract(Name=@"SDT_MicroUserInfo.Institutes", Namespace="DataAnalysisPlatform")]
	public class SdtSDT_MicroUserInfo_Institutes_RESTInterface : GxGenericCollectionItem<SdtSDT_MicroUserInfo_Institutes>, System.Web.SessionState.IRequiresSessionState
	{
		public SdtSDT_MicroUserInfo_Institutes_RESTInterface( ) : base()
		{
		}

		public SdtSDT_MicroUserInfo_Institutes_RESTInterface( SdtSDT_MicroUserInfo_Institutes psdt ) : base(psdt)
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

		[DataMember(Name="Tenants", Order=3)]
		public  GxSimpleCollection<String> gxTpr_Tenants
		{
			get { 
				return sdt.gxTpr_Tenants;
			}
			set { 
				sdt.gxTpr_Tenants = value;
			}
		}


		#endregion

		public SdtSDT_MicroUserInfo_Institutes sdt
		{
			get { 
				return (SdtSDT_MicroUserInfo_Institutes)Sdt;
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
				sdt = new SdtSDT_MicroUserInfo_Institutes() ;
			}
		}
	}
	#endregion
}