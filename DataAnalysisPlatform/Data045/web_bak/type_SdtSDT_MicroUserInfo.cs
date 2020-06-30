/*
				   File: type_SdtSDT_MicroUserInfo
			Description: SDT_MicroUserInfo
				 Author: Nemo for C# version 16.0.0.127771
		   Generated on: 2020/2/27 9:48:52
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
	[XmlRoot(ElementName="SDT_MicroUserInfo")]
	[XmlType(TypeName="SDT_MicroUserInfo" , Namespace="DataAnalysisPlatform" )]
	[Serializable]
	public class SdtSDT_MicroUserInfo : GxUserType
	{
		public SdtSDT_MicroUserInfo( )
		{
			/* Constructor for serialization */
			gxTv_SdtSDT_MicroUserInfo_Displayname = "";

			gxTv_SdtSDT_MicroUserInfo_Account = "";

		}

		public SdtSDT_MicroUserInfo(IGxContext context)
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
			AddObjectProperty("UserID", gxTpr_Userid, false);
			AddObjectProperty("DisplayName", gxTpr_Displayname, false);
			AddObjectProperty("Account", gxTpr_Account, false);
			AddObjectProperty("UserType", gxTpr_Usertype, false);
			AddObjectProperty("Permissions", gxTv_SdtSDT_MicroUserInfo_Permissions, false);  
			AddObjectProperty("Institutes", gxTv_SdtSDT_MicroUserInfo_Institutes, false);  
			AddObjectProperty("Tenants", gxTv_SdtSDT_MicroUserInfo_Tenants, false);  
			return;
		}
		#endregion

		#region Properties

		[SoapElement(ElementName="UserID")]
		[XmlElement(ElementName="UserID")]
		public Guid gxTpr_Userid
		{
			get { 
				return gxTv_SdtSDT_MicroUserInfo_Userid; 
			}
			set { 
				gxTv_SdtSDT_MicroUserInfo_Userid = value;
				SetDirty("Userid");
			}
		}


		[SoapElement(ElementName="DisplayName")]
		[XmlElement(ElementName="DisplayName")]
		public String gxTpr_Displayname
		{
			get { 
				return gxTv_SdtSDT_MicroUserInfo_Displayname; 
			}
			set { 
				gxTv_SdtSDT_MicroUserInfo_Displayname = value;
				SetDirty("Displayname");
			}
		}


		[SoapElement(ElementName="Account")]
		[XmlElement(ElementName="Account")]
		public String gxTpr_Account
		{
			get { 
				return gxTv_SdtSDT_MicroUserInfo_Account; 
			}
			set { 
				gxTv_SdtSDT_MicroUserInfo_Account = value;
				SetDirty("Account");
			}
		}


		[SoapElement(ElementName="UserType")]
		[XmlElement(ElementName="UserType")]
		public short gxTpr_Usertype
		{
			get { 
				return gxTv_SdtSDT_MicroUserInfo_Usertype; 
			}
			set { 
				gxTv_SdtSDT_MicroUserInfo_Usertype = value;
				SetDirty("Usertype");
			}
		}


		[SoapElement(ElementName="Permissions" )]
		[XmlArray(ElementName="Permissions"  )]
		[XmlArrayItemAttribute(ElementName="Item" , IsNullable=false )]
		public GxSimpleCollection<String> gxTpr_Permissions_GxSimpleCollection
		{
			get {
				if ( gxTv_SdtSDT_MicroUserInfo_Permissions == null )
				{
					gxTv_SdtSDT_MicroUserInfo_Permissions = new GxSimpleCollection<String>( );
				}
				return gxTv_SdtSDT_MicroUserInfo_Permissions;
			}
			set {
				if ( gxTv_SdtSDT_MicroUserInfo_Permissions == null )
				{
					gxTv_SdtSDT_MicroUserInfo_Permissions = new GxSimpleCollection<String>( );
				}
				gxTv_SdtSDT_MicroUserInfo_Permissions = value;
			}
		}

		[SoapIgnore]
		[XmlIgnore]
		public GxSimpleCollection<String> gxTpr_Permissions
		{
			get {
				if ( gxTv_SdtSDT_MicroUserInfo_Permissions == null )
				{
					gxTv_SdtSDT_MicroUserInfo_Permissions = new GxSimpleCollection<String>();
				}
				return gxTv_SdtSDT_MicroUserInfo_Permissions ;
			}
			set {
				gxTv_SdtSDT_MicroUserInfo_Permissions = value;
				SetDirty("Permissions");
			}
		}

		public void gxTv_SdtSDT_MicroUserInfo_Permissions_SetNull()
		{
			gxTv_SdtSDT_MicroUserInfo_Permissions = null;
			return  ;
		}

		public bool gxTv_SdtSDT_MicroUserInfo_Permissions_IsNull()
		{
			if (gxTv_SdtSDT_MicroUserInfo_Permissions == null)
			{
				return true ;
			}
			return false ;
		}



		[SoapElement(ElementName="Institutes" )]
		[XmlArray(ElementName="Institutes"  )]
		[XmlArrayItemAttribute(ElementName="Institutes" , IsNullable=false )]
		public GXBaseCollection<SdtSDT_MicroUserInfo_Institutes> gxTpr_Institutes
		{
			get {
				if ( gxTv_SdtSDT_MicroUserInfo_Institutes == null )
				{
					gxTv_SdtSDT_MicroUserInfo_Institutes = new GXBaseCollection<SdtSDT_MicroUserInfo_Institutes>( context, "SDT_MicroUserInfo.Institutes", "");
				}
				return gxTv_SdtSDT_MicroUserInfo_Institutes;
			}
			set {
				if ( gxTv_SdtSDT_MicroUserInfo_Institutes == null )
				{
					gxTv_SdtSDT_MicroUserInfo_Institutes = new GXBaseCollection<SdtSDT_MicroUserInfo_Institutes>( context, "SDT_MicroUserInfo.Institutes", "");
				}
				gxTv_SdtSDT_MicroUserInfo_Institutes = value;
				SetDirty("Institutes");
			}
		}

		public void gxTv_SdtSDT_MicroUserInfo_Institutes_SetNull()
		{
			gxTv_SdtSDT_MicroUserInfo_Institutes = null;
			return  ;
		}

		public bool gxTv_SdtSDT_MicroUserInfo_Institutes_IsNull()
		{
			if (gxTv_SdtSDT_MicroUserInfo_Institutes == null)
			{
				return true ;
			}
			return false ;
		}




		[SoapElement(ElementName="Tenants" )]
		[XmlArray(ElementName="Tenants"  )]
		[XmlArrayItemAttribute(ElementName="Tenants" , IsNullable=false )]
		public GXBaseCollection<SdtSDT_MicroUserInfo_Tenants> gxTpr_Tenants
		{
			get {
				if ( gxTv_SdtSDT_MicroUserInfo_Tenants == null )
				{
					gxTv_SdtSDT_MicroUserInfo_Tenants = new GXBaseCollection<SdtSDT_MicroUserInfo_Tenants>( context, "SDT_MicroUserInfo.Tenants", "");
				}
				return gxTv_SdtSDT_MicroUserInfo_Tenants;
			}
			set {
				if ( gxTv_SdtSDT_MicroUserInfo_Tenants == null )
				{
					gxTv_SdtSDT_MicroUserInfo_Tenants = new GXBaseCollection<SdtSDT_MicroUserInfo_Tenants>( context, "SDT_MicroUserInfo.Tenants", "");
				}
				gxTv_SdtSDT_MicroUserInfo_Tenants = value;
				SetDirty("Tenants");
			}
		}

		public void gxTv_SdtSDT_MicroUserInfo_Tenants_SetNull()
		{
			gxTv_SdtSDT_MicroUserInfo_Tenants = null;
			return  ;
		}

		public bool gxTv_SdtSDT_MicroUserInfo_Tenants_IsNull()
		{
			if (gxTv_SdtSDT_MicroUserInfo_Tenants == null)
			{
				return true ;
			}
			return false ;
		}




		#endregion

		#region Initialization

		public void initialize( )
		{
			gxTv_SdtSDT_MicroUserInfo_Displayname = "";
			gxTv_SdtSDT_MicroUserInfo_Account = "";




			return  ;
		}



		#endregion

		#region Declaration

		protected Guid gxTv_SdtSDT_MicroUserInfo_Userid;
		protected String gxTv_SdtSDT_MicroUserInfo_Displayname;
		protected String gxTv_SdtSDT_MicroUserInfo_Account;
		protected short gxTv_SdtSDT_MicroUserInfo_Usertype;
		protected GxSimpleCollection<String> gxTv_SdtSDT_MicroUserInfo_Permissions = null; protected GXBaseCollection<SdtSDT_MicroUserInfo_Institutes> gxTv_SdtSDT_MicroUserInfo_Institutes = null; protected GXBaseCollection<SdtSDT_MicroUserInfo_Tenants> gxTv_SdtSDT_MicroUserInfo_Tenants = null; 


		#endregion
	}
	#region Rest interface
	[DataContract(Name=@"SDT_MicroUserInfo", Namespace="DataAnalysisPlatform")]
	public class SdtSDT_MicroUserInfo_RESTInterface : GxGenericCollectionItem<SdtSDT_MicroUserInfo>, System.Web.SessionState.IRequiresSessionState
	{
		public SdtSDT_MicroUserInfo_RESTInterface( ) : base()
		{
		}

		public SdtSDT_MicroUserInfo_RESTInterface( SdtSDT_MicroUserInfo psdt ) : base(psdt)
		{
		}

		#region Rest Properties
		[DataMember(Name="UserID", Order=0)]
		public Guid gxTpr_Userid
		{
			get { 
				return sdt.gxTpr_Userid;
			}
			set { 
				sdt.gxTpr_Userid = value;
			}
		}

		[DataMember(Name="DisplayName", Order=1)]
		public String gxTpr_Displayname
		{
			get { 
				return sdt.gxTpr_Displayname;
			}
			set { 
				sdt.gxTpr_Displayname = value;
			}
		}

		[DataMember(Name="Account", Order=2)]
		public String gxTpr_Account
		{
			get { 
				return sdt.gxTpr_Account;
			}
			set { 
				sdt.gxTpr_Account = value;
			}
		}

		[DataMember(Name="UserType", Order=3)]
		public  Nullable<short> gxTpr_Usertype
		{
			get { 
				return sdt.gxTpr_Usertype;
			}
			set { 
				sdt.gxTpr_Usertype = (short) (value.HasValue ? value.Value : 0);
			}
		}

		[DataMember(Name="Permissions", Order=4)]
		public  GxSimpleCollection<String> gxTpr_Permissions
		{
			get { 
				return sdt.gxTpr_Permissions;
			}
			set { 
				sdt.gxTpr_Permissions = value;
			}
		}

		[DataMember(Name="Institutes", Order=5)]
		public GxGenericCollection<SdtSDT_MicroUserInfo_Institutes_RESTInterface> gxTpr_Institutes
		{
			get {
				return new GxGenericCollection<SdtSDT_MicroUserInfo_Institutes_RESTInterface>(sdt.gxTpr_Institutes) ;
			}

			set {
				value.LoadCollection(sdt.gxTpr_Institutes);
			}

		}

		[DataMember(Name="Tenants", Order=6)]
		public GxGenericCollection<SdtSDT_MicroUserInfo_Tenants_RESTInterface> gxTpr_Tenants
		{
			get {
				return new GxGenericCollection<SdtSDT_MicroUserInfo_Tenants_RESTInterface>(sdt.gxTpr_Tenants) ;
			}

			set {
				value.LoadCollection(sdt.gxTpr_Tenants);
			}

		}


		#endregion

		public SdtSDT_MicroUserInfo sdt
		{
			get { 
				return (SdtSDT_MicroUserInfo)Sdt;
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
				sdt = new SdtSDT_MicroUserInfo() ;
			}
		}
	}
	#endregion
}