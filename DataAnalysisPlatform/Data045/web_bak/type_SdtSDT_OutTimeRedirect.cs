/*
				   File: type_SdtSDT_OutTimeRedirect
			Description: SDT_OutTimeRedirect
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
	[XmlRoot(ElementName="SDT_OutTimeRedirect")]
	[XmlType(TypeName="SDT_OutTimeRedirect" , Namespace="DataAnalysisPlatform" )]
	[Serializable]
	public class SdtSDT_OutTimeRedirect : GxUserType
	{
		public SdtSDT_OutTimeRedirect( )
		{
			/* Constructor for serialization */
			gxTv_SdtSDT_OutTimeRedirect_Outtimeurl = "";

			gxTv_SdtSDT_OutTimeRedirect_Tokencontent = "";

		}

		public SdtSDT_OutTimeRedirect(IGxContext context)
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
			AddObjectProperty("outTimeUrl", gxTpr_Outtimeurl, false);
			AddObjectProperty("tokenContent", gxTpr_Tokencontent, false);
			return;
		}
		#endregion

		#region Properties

		[SoapElement(ElementName="outTimeUrl")]
		[XmlElement(ElementName="outTimeUrl")]
		public String gxTpr_Outtimeurl
		{
			get { 
				return gxTv_SdtSDT_OutTimeRedirect_Outtimeurl; 
			}
			set { 
				gxTv_SdtSDT_OutTimeRedirect_Outtimeurl = value;
				SetDirty("Outtimeurl");
			}
		}


		[SoapElement(ElementName="tokenContent")]
		[XmlElement(ElementName="tokenContent")]
		public String gxTpr_Tokencontent
		{
			get { 
				return gxTv_SdtSDT_OutTimeRedirect_Tokencontent; 
			}
			set { 
				gxTv_SdtSDT_OutTimeRedirect_Tokencontent = value;
				SetDirty("Tokencontent");
			}
		}


		#endregion

		#region Initialization

		public void initialize( )
		{
			gxTv_SdtSDT_OutTimeRedirect_Outtimeurl = "";
			gxTv_SdtSDT_OutTimeRedirect_Tokencontent = "";
			return  ;
		}



		#endregion

		#region Declaration

		protected String gxTv_SdtSDT_OutTimeRedirect_Outtimeurl;
		protected String gxTv_SdtSDT_OutTimeRedirect_Tokencontent;



		#endregion
	}
	#region Rest interface
	[DataContract(Name=@"SDT_OutTimeRedirect", Namespace="DataAnalysisPlatform")]
	public class SdtSDT_OutTimeRedirect_RESTInterface : GxGenericCollectionItem<SdtSDT_OutTimeRedirect>, System.Web.SessionState.IRequiresSessionState
	{
		public SdtSDT_OutTimeRedirect_RESTInterface( ) : base()
		{
		}

		public SdtSDT_OutTimeRedirect_RESTInterface( SdtSDT_OutTimeRedirect psdt ) : base(psdt)
		{
		}

		#region Rest Properties
		[DataMember(Name="outTimeUrl", Order=0)]
		public String gxTpr_Outtimeurl
		{
			get { 
				return sdt.gxTpr_Outtimeurl;
			}
			set { 
				sdt.gxTpr_Outtimeurl = value;
			}
		}

		[DataMember(Name="tokenContent", Order=1)]
		public String gxTpr_Tokencontent
		{
			get { 
				return sdt.gxTpr_Tokencontent;
			}
			set { 
				sdt.gxTpr_Tokencontent = value;
			}
		}


		#endregion

		public SdtSDT_OutTimeRedirect sdt
		{
			get { 
				return (SdtSDT_OutTimeRedirect)Sdt;
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
				sdt = new SdtSDT_OutTimeRedirect() ;
			}
		}
	}
	#endregion
}