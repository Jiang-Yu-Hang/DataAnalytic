/*
				   File: type_SdtSDT_EntityCount
			Description: SDT_EntityCount
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
	[XmlRoot(ElementName="SDT_EntityCount")]
	[XmlType(TypeName="SDT_EntityCount" , Namespace="DataAnalysisPlatform" )]
	[Serializable]
	public class SdtSDT_EntityCount : GxUserType
	{
		public SdtSDT_EntityCount( )
		{
			/* Constructor for serialization */
			gxTv_SdtSDT_EntityCount_Entityname = "";

		}

		public SdtSDT_EntityCount(IGxContext context)
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
			AddObjectProperty("entityname", gxTpr_Entityname, false);
			AddObjectProperty("value", gxTpr_Value, false);
			return;
		}
		#endregion

		#region Properties

		[SoapElement(ElementName="entityname")]
		[XmlElement(ElementName="entityname")]
		public String gxTpr_Entityname
		{
			get { 
				return gxTv_SdtSDT_EntityCount_Entityname; 
			}
			set { 
				gxTv_SdtSDT_EntityCount_Entityname = value;
				SetDirty("Entityname");
			}
		}


		[SoapElement(ElementName="value")]
		[XmlElement(ElementName="value")]
		public long gxTpr_Value
		{
			get { 
				return gxTv_SdtSDT_EntityCount_Value; 
			}
			set { 
				gxTv_SdtSDT_EntityCount_Value = value;
				SetDirty("Value");
			}
		}


		#endregion

		#region Initialization

		public void initialize( )
		{
			gxTv_SdtSDT_EntityCount_Entityname = "";

			return  ;
		}



		#endregion

		#region Declaration

		protected String gxTv_SdtSDT_EntityCount_Entityname;
		protected long gxTv_SdtSDT_EntityCount_Value;



		#endregion
	}
	#region Rest interface
	[DataContract(Name=@"SDT_EntityCount", Namespace="DataAnalysisPlatform")]
	public class SdtSDT_EntityCount_RESTInterface : GxGenericCollectionItem<SdtSDT_EntityCount>, System.Web.SessionState.IRequiresSessionState
	{
		public SdtSDT_EntityCount_RESTInterface( ) : base()
		{
		}

		public SdtSDT_EntityCount_RESTInterface( SdtSDT_EntityCount psdt ) : base(psdt)
		{
		}

		#region Rest Properties
		[DataMember(Name="entityname", Order=0)]
		public String gxTpr_Entityname
		{
			get { 
				return sdt.gxTpr_Entityname;
			}
			set { 
				sdt.gxTpr_Entityname = value;
			}
		}

		[DataMember(Name="value", Order=1)]
		public String gxTpr_Value
		{
			get { 
				return StringUtil.LTrim( StringUtil.Str( (decimal) sdt.gxTpr_Value, 15, 0));
			}
			set { 
				sdt.gxTpr_Value = (long) NumberUtil.Val( value, ".");
			}
		}


		#endregion

		public SdtSDT_EntityCount sdt
		{
			get { 
				return (SdtSDT_EntityCount)Sdt;
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
				sdt = new SdtSDT_EntityCount() ;
			}
		}
	}
	#endregion
}