/*
				   File: type_SdtWWPContext
			Description: WWPContext
				 Author: Nemo for C# version 16.0.0.127771
		   Generated on: 2020/2/27 9:48:53
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

using GeneXus.Programs;
namespace GeneXus.Programs.wwpbaseobjects{
	[XmlSerializerFormat]
	[XmlRoot(ElementName="WWPContext")]
	[XmlType(TypeName="WWPContext" , Namespace="DataAnalysisPlatform" )]
	[Serializable]
	public class SdtWWPContext : GxUserType
	{
		public SdtWWPContext( )
		{
			/* Constructor for serialization */
			gxTv_SdtWWPContext_Userguid = "";

			gxTv_SdtWWPContext_Username = "";

			gxTv_SdtWWPContext_Userdisplayname = "";

			gxTv_SdtWWPContext_Userprovidername = "";

			gxTv_SdtWWPContext_Clientip = "";

		}

		public SdtWWPContext(IGxContext context)
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
			AddObjectProperty("UserId", gxTpr_Userid, false);
			AddObjectProperty("UserGUID", gxTpr_Userguid, false);
			AddObjectProperty("UserName", gxTpr_Username, false);
			AddObjectProperty("UserType", gxTpr_Usertype, false);
			AddObjectProperty("UserDisplayName", gxTpr_Userdisplayname, false);
			AddObjectProperty("UserProviderID", StringUtil.LTrim( StringUtil.Str( (decimal)gxTpr_Userproviderid, 18, 0)), false);
			AddObjectProperty("UserProviderName", gxTpr_Userprovidername, false);
			AddObjectProperty("currentTNum", gxTpr_Currenttnum, false);
			AddObjectProperty("ClientIP", gxTpr_Clientip, false);
			return;
		}
		#endregion

		#region Properties

		[SoapElement(ElementName="UserId")]
		[XmlElement(ElementName="UserId")]
		public short gxTpr_Userid
		{
			get { 
				return gxTv_SdtWWPContext_Userid; 
			}
			set { 
				gxTv_SdtWWPContext_Userid = value;
				SetDirty("Userid");
			}
		}


		[SoapElement(ElementName="UserGUID")]
		[XmlElement(ElementName="UserGUID")]
		public String gxTpr_Userguid
		{
			get { 
				return gxTv_SdtWWPContext_Userguid; 
			}
			set { 
				gxTv_SdtWWPContext_Userguid = value;
				SetDirty("Userguid");
			}
		}


		[SoapElement(ElementName="UserName")]
		[XmlElement(ElementName="UserName")]
		public String gxTpr_Username
		{
			get { 
				return gxTv_SdtWWPContext_Username; 
			}
			set { 
				gxTv_SdtWWPContext_Username = value;
				SetDirty("Username");
			}
		}


		[SoapElement(ElementName="UserType")]
		[XmlElement(ElementName="UserType")]
		public short gxTpr_Usertype
		{
			get { 
				return gxTv_SdtWWPContext_Usertype; 
			}
			set { 
				gxTv_SdtWWPContext_Usertype = value;
				SetDirty("Usertype");
			}
		}


		[SoapElement(ElementName="UserDisplayName")]
		[XmlElement(ElementName="UserDisplayName")]
		public String gxTpr_Userdisplayname
		{
			get { 
				return gxTv_SdtWWPContext_Userdisplayname; 
			}
			set { 
				gxTv_SdtWWPContext_Userdisplayname = value;
				SetDirty("Userdisplayname");
			}
		}


		[SoapElement(ElementName="UserProviderID")]
		[XmlElement(ElementName="UserProviderID")]
		public long gxTpr_Userproviderid
		{
			get { 
				return gxTv_SdtWWPContext_Userproviderid; 
			}
			set { 
				gxTv_SdtWWPContext_Userproviderid = value;
				SetDirty("Userproviderid");
			}
		}


		[SoapElement(ElementName="UserProviderName")]
		[XmlElement(ElementName="UserProviderName")]
		public String gxTpr_Userprovidername
		{
			get { 
				return gxTv_SdtWWPContext_Userprovidername; 
			}
			set { 
				gxTv_SdtWWPContext_Userprovidername = value;
				SetDirty("Userprovidername");
			}
		}


		[SoapElement(ElementName="currentTNum")]
		[XmlElement(ElementName="currentTNum")]
		public short gxTpr_Currenttnum
		{
			get { 
				return gxTv_SdtWWPContext_Currenttnum; 
			}
			set { 
				gxTv_SdtWWPContext_Currenttnum = value;
				SetDirty("Currenttnum");
			}
		}


		[SoapElement(ElementName="ClientIP")]
		[XmlElement(ElementName="ClientIP")]
		public String gxTpr_Clientip
		{
			get { 
				return gxTv_SdtWWPContext_Clientip; 
			}
			set { 
				gxTv_SdtWWPContext_Clientip = value;
				SetDirty("Clientip");
			}
		}


		#endregion

		#region Initialization

		public void initialize( )
		{
			gxTv_SdtWWPContext_Userguid = "";
			gxTv_SdtWWPContext_Username = "";

			gxTv_SdtWWPContext_Userdisplayname = "";

			gxTv_SdtWWPContext_Userprovidername = "";

			gxTv_SdtWWPContext_Clientip = "";
			return  ;
		}



		#endregion

		#region Declaration

		protected short gxTv_SdtWWPContext_Userid;
		protected String gxTv_SdtWWPContext_Userguid;
		protected String gxTv_SdtWWPContext_Username;
		protected short gxTv_SdtWWPContext_Usertype;
		protected String gxTv_SdtWWPContext_Userdisplayname;
		protected long gxTv_SdtWWPContext_Userproviderid;
		protected String gxTv_SdtWWPContext_Userprovidername;
		protected short gxTv_SdtWWPContext_Currenttnum;
		protected String gxTv_SdtWWPContext_Clientip;



		#endregion
	}
	#region Rest interface
	[DataContract(Name=@"WWPContext", Namespace="DataAnalysisPlatform")]
	public class SdtWWPContext_RESTInterface : GxGenericCollectionItem<SdtWWPContext>, System.Web.SessionState.IRequiresSessionState
	{
		public SdtWWPContext_RESTInterface( ) : base()
		{
		}

		public SdtWWPContext_RESTInterface( SdtWWPContext psdt ) : base(psdt)
		{
		}

		#region Rest Properties
		[DataMember(Name="UserId", Order=0)]
		public  Nullable<short> gxTpr_Userid
		{
			get { 
				return sdt.gxTpr_Userid;
			}
			set { 
				sdt.gxTpr_Userid = (short) (value.HasValue ? value.Value : 0);
			}
		}

		[DataMember(Name="UserGUID", Order=1)]
		public String gxTpr_Userguid
		{
			get { 
				return sdt.gxTpr_Userguid;
			}
			set { 
				sdt.gxTpr_Userguid = value;
			}
		}

		[DataMember(Name="UserName", Order=2)]
		public String gxTpr_Username
		{
			get { 
				return sdt.gxTpr_Username;
			}
			set { 
				sdt.gxTpr_Username = value;
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

		[DataMember(Name="UserDisplayName", Order=4)]
		public String gxTpr_Userdisplayname
		{
			get { 
				return sdt.gxTpr_Userdisplayname;
			}
			set { 
				sdt.gxTpr_Userdisplayname = value;
			}
		}

		[DataMember(Name="UserProviderID", Order=5)]
		public String gxTpr_Userproviderid
		{
			get { 
				return StringUtil.LTrim( StringUtil.Str( (decimal) sdt.gxTpr_Userproviderid, 18, 0));
			}
			set { 
				sdt.gxTpr_Userproviderid = (long) NumberUtil.Val( value, ".");
			}
		}

		[DataMember(Name="UserProviderName", Order=6)]
		public String gxTpr_Userprovidername
		{
			get { 
				return sdt.gxTpr_Userprovidername;
			}
			set { 
				sdt.gxTpr_Userprovidername = value;
			}
		}

		[DataMember(Name="currentTNum", Order=7)]
		public  Nullable<short> gxTpr_Currenttnum
		{
			get { 
				return sdt.gxTpr_Currenttnum;
			}
			set { 
				sdt.gxTpr_Currenttnum = (short) (value.HasValue ? value.Value : 0);
			}
		}

		[DataMember(Name="ClientIP", Order=8)]
		public String gxTpr_Clientip
		{
			get { 
				return sdt.gxTpr_Clientip;
			}
			set { 
				sdt.gxTpr_Clientip = value;
			}
		}


		#endregion

		public SdtWWPContext sdt
		{
			get { 
				return (SdtWWPContext)Sdt;
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
				sdt = new SdtWWPContext() ;
			}
		}
	}
	#endregion
}