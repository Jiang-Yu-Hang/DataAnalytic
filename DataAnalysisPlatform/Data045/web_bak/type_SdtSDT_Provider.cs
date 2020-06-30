/*
				   File: type_SdtSDT_Provider
			Description: SDT_Provider
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
	[XmlRoot(ElementName="SDT_Provider")]
	[XmlType(TypeName="SDT_Provider" , Namespace="DataAnalysisPlatform" )]
	[Serializable]
	public class SdtSDT_Provider : GxUserType
	{
		public SdtSDT_Provider( )
		{
			/* Constructor for serialization */
			gxTv_SdtSDT_Provider_Jc_providername = "";

		}

		public SdtSDT_Provider(IGxContext context)
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
			AddObjectProperty("JC_ProviderID", StringUtil.LTrim( StringUtil.Str( (decimal)gxTpr_Jc_providerid, 18, 0)), false);
			AddObjectProperty("JC_ProviderName", gxTpr_Jc_providername, false);
			return;
		}
		#endregion

		#region Properties

		[SoapElement(ElementName="JC_ProviderID")]
		[XmlElement(ElementName="JC_ProviderID")]
		public long gxTpr_Jc_providerid
		{
			get { 
				return gxTv_SdtSDT_Provider_Jc_providerid; 
			}
			set { 
				gxTv_SdtSDT_Provider_Jc_providerid = value;
				SetDirty("Jc_providerid");
			}
		}


		[SoapElement(ElementName="JC_ProviderName")]
		[XmlElement(ElementName="JC_ProviderName")]
		public String gxTpr_Jc_providername
		{
			get { 
				return gxTv_SdtSDT_Provider_Jc_providername; 
			}
			set { 
				gxTv_SdtSDT_Provider_Jc_providername = value;
				SetDirty("Jc_providername");
			}
		}


		#endregion

		#region Initialization

		public void initialize( )
		{
			gxTv_SdtSDT_Provider_Jc_providername = "";
			return  ;
		}



		#endregion

		#region Declaration

		protected long gxTv_SdtSDT_Provider_Jc_providerid;
		protected String gxTv_SdtSDT_Provider_Jc_providername;



		#endregion
	}
	#region Rest interface
	[DataContract(Name=@"SDT_Provider", Namespace="DataAnalysisPlatform")]
	public class SdtSDT_Provider_RESTInterface : GxGenericCollectionItem<SdtSDT_Provider>, System.Web.SessionState.IRequiresSessionState
	{
		public SdtSDT_Provider_RESTInterface( ) : base()
		{
		}

		public SdtSDT_Provider_RESTInterface( SdtSDT_Provider psdt ) : base(psdt)
		{
		}

		#region Rest Properties
		[DataMember(Name="JC_ProviderID", Order=0)]
		public String gxTpr_Jc_providerid
		{
			get { 
				return StringUtil.LTrim( StringUtil.Str( (decimal) sdt.gxTpr_Jc_providerid, 18, 0));
			}
			set { 
				sdt.gxTpr_Jc_providerid = (long) NumberUtil.Val( value, ".");
			}
		}

		[DataMember(Name="JC_ProviderName", Order=1)]
		public String gxTpr_Jc_providername
		{
			get { 
				return sdt.gxTpr_Jc_providername;
			}
			set { 
				sdt.gxTpr_Jc_providername = value;
			}
		}


		#endregion

		public SdtSDT_Provider sdt
		{
			get { 
				return (SdtSDT_Provider)Sdt;
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
				sdt = new SdtSDT_Provider() ;
			}
		}
	}
	#endregion
}