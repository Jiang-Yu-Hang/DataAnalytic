/*
				   File: type_SdtSDT_JWT
			Description: SDT_JWT
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
	[XmlRoot(ElementName="SDT_JWT")]
	[XmlType(TypeName="SDT_JWT" , Namespace="DataAnalysisPlatform" )]
	[Serializable]
	public class SdtSDT_JWT : GxUserType
	{
		public SdtSDT_JWT( )
		{
			/* Constructor for serialization */
			gxTv_SdtSDT_JWT_Name = "";

			gxTv_SdtSDT_JWT_Userid = "";

			gxTv_SdtSDT_JWT_Sessionid = "";

			gxTv_SdtSDT_JWT_Ip = "";

			gxTv_SdtSDT_JWT_Nbf = "";

			gxTv_SdtSDT_JWT_Exp = "";

			gxTv_SdtSDT_JWT_Iss = "";

			gxTv_SdtSDT_JWT_Aud = "";

			gxTv_SdtSDT_JWT_Iat = "";

			gxTv_SdtSDT_JWT_Currenttcode = "";

			gxTv_SdtSDT_JWT_Currenttnum = "";

		}

		public SdtSDT_JWT(IGxContext context)
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
			AddObjectProperty("name", gxTpr_Name, false);
			AddObjectProperty("userID", gxTpr_Userid, false);
			AddObjectProperty("sessionID", gxTpr_Sessionid, false);
			AddObjectProperty("IP", gxTpr_Ip, false);
			AddObjectProperty("nbf", gxTpr_Nbf, false);
			AddObjectProperty("exp", gxTpr_Exp, false);
			AddObjectProperty("iss", gxTpr_Iss, false);
			AddObjectProperty("aud", gxTpr_Aud, false);
			AddObjectProperty("iat", gxTpr_Iat, false);
			AddObjectProperty("currentTCode", gxTpr_Currenttcode, false);
			AddObjectProperty("currentTNum", gxTpr_Currenttnum, false);
			return;
		}
		#endregion

		#region Properties

		[SoapElement(ElementName="name")]
		[XmlElement(ElementName="name")]
		public String gxTpr_Name
		{
			get { 
				return gxTv_SdtSDT_JWT_Name; 
			}
			set { 
				gxTv_SdtSDT_JWT_Name = value;
				SetDirty("Name");
			}
		}


		[SoapElement(ElementName="userID")]
		[XmlElement(ElementName="userID")]
		public String gxTpr_Userid
		{
			get { 
				return gxTv_SdtSDT_JWT_Userid; 
			}
			set { 
				gxTv_SdtSDT_JWT_Userid = value;
				SetDirty("Userid");
			}
		}


		[SoapElement(ElementName="sessionID")]
		[XmlElement(ElementName="sessionID")]
		public String gxTpr_Sessionid
		{
			get { 
				return gxTv_SdtSDT_JWT_Sessionid; 
			}
			set { 
				gxTv_SdtSDT_JWT_Sessionid = value;
				SetDirty("Sessionid");
			}
		}


		[SoapElement(ElementName="IP")]
		[XmlElement(ElementName="IP")]
		public String gxTpr_Ip
		{
			get { 
				return gxTv_SdtSDT_JWT_Ip; 
			}
			set { 
				gxTv_SdtSDT_JWT_Ip = value;
				SetDirty("Ip");
			}
		}


		[SoapElement(ElementName="nbf")]
		[XmlElement(ElementName="nbf")]
		public String gxTpr_Nbf
		{
			get { 
				return gxTv_SdtSDT_JWT_Nbf; 
			}
			set { 
				gxTv_SdtSDT_JWT_Nbf = value;
				SetDirty("Nbf");
			}
		}


		[SoapElement(ElementName="exp")]
		[XmlElement(ElementName="exp")]
		public String gxTpr_Exp
		{
			get { 
				return gxTv_SdtSDT_JWT_Exp; 
			}
			set { 
				gxTv_SdtSDT_JWT_Exp = value;
				SetDirty("Exp");
			}
		}


		[SoapElement(ElementName="iss")]
		[XmlElement(ElementName="iss")]
		public String gxTpr_Iss
		{
			get { 
				return gxTv_SdtSDT_JWT_Iss; 
			}
			set { 
				gxTv_SdtSDT_JWT_Iss = value;
				SetDirty("Iss");
			}
		}


		[SoapElement(ElementName="aud")]
		[XmlElement(ElementName="aud")]
		public String gxTpr_Aud
		{
			get { 
				return gxTv_SdtSDT_JWT_Aud; 
			}
			set { 
				gxTv_SdtSDT_JWT_Aud = value;
				SetDirty("Aud");
			}
		}


		[SoapElement(ElementName="iat")]
		[XmlElement(ElementName="iat")]
		public String gxTpr_Iat
		{
			get { 
				return gxTv_SdtSDT_JWT_Iat; 
			}
			set { 
				gxTv_SdtSDT_JWT_Iat = value;
				SetDirty("Iat");
			}
		}


		[SoapElement(ElementName="currentTCode")]
		[XmlElement(ElementName="currentTCode")]
		public String gxTpr_Currenttcode
		{
			get { 
				return gxTv_SdtSDT_JWT_Currenttcode; 
			}
			set { 
				gxTv_SdtSDT_JWT_Currenttcode = value;
				SetDirty("Currenttcode");
			}
		}


		[SoapElement(ElementName="currentTNum")]
		[XmlElement(ElementName="currentTNum")]
		public String gxTpr_Currenttnum
		{
			get { 
				return gxTv_SdtSDT_JWT_Currenttnum; 
			}
			set { 
				gxTv_SdtSDT_JWT_Currenttnum = value;
				SetDirty("Currenttnum");
			}
		}


		#endregion

		#region Initialization

		public void initialize( )
		{
			gxTv_SdtSDT_JWT_Name = "";
			gxTv_SdtSDT_JWT_Userid = "";
			gxTv_SdtSDT_JWT_Sessionid = "";
			gxTv_SdtSDT_JWT_Ip = "";
			gxTv_SdtSDT_JWT_Nbf = "";
			gxTv_SdtSDT_JWT_Exp = "";
			gxTv_SdtSDT_JWT_Iss = "";
			gxTv_SdtSDT_JWT_Aud = "";
			gxTv_SdtSDT_JWT_Iat = "";
			gxTv_SdtSDT_JWT_Currenttcode = "";
			gxTv_SdtSDT_JWT_Currenttnum = "";
			return  ;
		}



		#endregion

		#region Declaration

		protected String gxTv_SdtSDT_JWT_Name;
		protected String gxTv_SdtSDT_JWT_Userid;
		protected String gxTv_SdtSDT_JWT_Sessionid;
		protected String gxTv_SdtSDT_JWT_Ip;
		protected String gxTv_SdtSDT_JWT_Nbf;
		protected String gxTv_SdtSDT_JWT_Exp;
		protected String gxTv_SdtSDT_JWT_Iss;
		protected String gxTv_SdtSDT_JWT_Aud;
		protected String gxTv_SdtSDT_JWT_Iat;
		protected String gxTv_SdtSDT_JWT_Currenttcode;
		protected String gxTv_SdtSDT_JWT_Currenttnum;



		#endregion
	}
	#region Rest interface
	[DataContract(Name=@"SDT_JWT", Namespace="DataAnalysisPlatform")]
	public class SdtSDT_JWT_RESTInterface : GxGenericCollectionItem<SdtSDT_JWT>, System.Web.SessionState.IRequiresSessionState
	{
		public SdtSDT_JWT_RESTInterface( ) : base()
		{
		}

		public SdtSDT_JWT_RESTInterface( SdtSDT_JWT psdt ) : base(psdt)
		{
		}

		#region Rest Properties
		[DataMember(Name="name", Order=0)]
		public String gxTpr_Name
		{
			get { 
				return sdt.gxTpr_Name;
			}
			set { 
				sdt.gxTpr_Name = value;
			}
		}

		[DataMember(Name="userID", Order=1)]
		public String gxTpr_Userid
		{
			get { 
				return sdt.gxTpr_Userid;
			}
			set { 
				sdt.gxTpr_Userid = value;
			}
		}

		[DataMember(Name="sessionID", Order=2)]
		public String gxTpr_Sessionid
		{
			get { 
				return sdt.gxTpr_Sessionid;
			}
			set { 
				sdt.gxTpr_Sessionid = value;
			}
		}

		[DataMember(Name="IP", Order=3)]
		public String gxTpr_Ip
		{
			get { 
				return sdt.gxTpr_Ip;
			}
			set { 
				sdt.gxTpr_Ip = value;
			}
		}

		[DataMember(Name="nbf", Order=4)]
		public String gxTpr_Nbf
		{
			get { 
				return sdt.gxTpr_Nbf;
			}
			set { 
				sdt.gxTpr_Nbf = value;
			}
		}

		[DataMember(Name="exp", Order=5)]
		public String gxTpr_Exp
		{
			get { 
				return sdt.gxTpr_Exp;
			}
			set { 
				sdt.gxTpr_Exp = value;
			}
		}

		[DataMember(Name="iss", Order=6)]
		public String gxTpr_Iss
		{
			get { 
				return sdt.gxTpr_Iss;
			}
			set { 
				sdt.gxTpr_Iss = value;
			}
		}

		[DataMember(Name="aud", Order=7)]
		public String gxTpr_Aud
		{
			get { 
				return sdt.gxTpr_Aud;
			}
			set { 
				sdt.gxTpr_Aud = value;
			}
		}

		[DataMember(Name="iat", Order=8)]
		public String gxTpr_Iat
		{
			get { 
				return sdt.gxTpr_Iat;
			}
			set { 
				sdt.gxTpr_Iat = value;
			}
		}

		[DataMember(Name="currentTCode", Order=9)]
		public String gxTpr_Currenttcode
		{
			get { 
				return sdt.gxTpr_Currenttcode;
			}
			set { 
				sdt.gxTpr_Currenttcode = value;
			}
		}

		[DataMember(Name="currentTNum", Order=10)]
		public String gxTpr_Currenttnum
		{
			get { 
				return sdt.gxTpr_Currenttnum;
			}
			set { 
				sdt.gxTpr_Currenttnum = value;
			}
		}


		#endregion

		public SdtSDT_JWT sdt
		{
			get { 
				return (SdtSDT_JWT)Sdt;
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
				sdt = new SdtSDT_JWT() ;
			}
		}
	}
	#endregion
}