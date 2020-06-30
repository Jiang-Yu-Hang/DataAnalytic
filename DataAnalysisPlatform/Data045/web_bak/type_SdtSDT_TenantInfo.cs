/*
				   File: type_SdtSDT_TenantInfo
			Description: SDT_TenantInfo
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
	[XmlRoot(ElementName="SDT_TenantInfo")]
	[XmlType(TypeName="SDT_TenantInfo" , Namespace="DataAnalysisPlatform" )]
	[Serializable]
	public class SdtSDT_TenantInfo : GxUserType
	{
		public SdtSDT_TenantInfo( )
		{
			/* Constructor for serialization */
			gxTv_SdtSDT_TenantInfo_Currenttcode = "";

		}

		public SdtSDT_TenantInfo(IGxContext context)
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
			AddObjectProperty("currentTCode", gxTpr_Currenttcode, false);
			AddObjectProperty("currentTNum", gxTpr_Currenttnum, false);
			return;
		}
		#endregion

		#region Properties

		[SoapElement(ElementName="currentTCode")]
		[XmlElement(ElementName="currentTCode")]
		public String gxTpr_Currenttcode
		{
			get { 
				return gxTv_SdtSDT_TenantInfo_Currenttcode; 
			}
			set { 
				gxTv_SdtSDT_TenantInfo_Currenttcode = value;
				SetDirty("Currenttcode");
			}
		}


		[SoapElement(ElementName="currentTNum")]
		[XmlElement(ElementName="currentTNum")]
		public short gxTpr_Currenttnum
		{
			get { 
				return gxTv_SdtSDT_TenantInfo_Currenttnum; 
			}
			set { 
				gxTv_SdtSDT_TenantInfo_Currenttnum = value;
				SetDirty("Currenttnum");
			}
		}


		#endregion

		#region Initialization

		public void initialize( )
		{
			gxTv_SdtSDT_TenantInfo_Currenttcode = "";

			return  ;
		}



		#endregion

		#region Declaration

		protected String gxTv_SdtSDT_TenantInfo_Currenttcode;
		protected short gxTv_SdtSDT_TenantInfo_Currenttnum;



		#endregion
	}
	#region Rest interface
	[DataContract(Name=@"SDT_TenantInfo", Namespace="DataAnalysisPlatform")]
	public class SdtSDT_TenantInfo_RESTInterface : GxGenericCollectionItem<SdtSDT_TenantInfo>, System.Web.SessionState.IRequiresSessionState
	{
		public SdtSDT_TenantInfo_RESTInterface( ) : base()
		{
		}

		public SdtSDT_TenantInfo_RESTInterface( SdtSDT_TenantInfo psdt ) : base(psdt)
		{
		}

		#region Rest Properties
		[DataMember(Name="currentTCode", Order=0)]
		public String gxTpr_Currenttcode
		{
			get { 
				return sdt.gxTpr_Currenttcode;
			}
			set { 
				sdt.gxTpr_Currenttcode = value;
			}
		}

		[DataMember(Name="currentTNum", Order=1)]
		public  Nullable<short> gxTpr_Currenttnum
		{
			get { 
				return sdt.gxTpr_Currenttnum;
			}
			set { 
				sdt.gxTpr_Currenttnum = (short) (value.HasValue ? value.Value : 0);
			}
		}


		#endregion

		public SdtSDT_TenantInfo sdt
		{
			get { 
				return (SdtSDT_TenantInfo)Sdt;
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
				sdt = new SdtSDT_TenantInfo() ;
			}
		}
	}
	#endregion
}