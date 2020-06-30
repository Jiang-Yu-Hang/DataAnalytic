/*
				   File: type_SdtSDT_EncounterCount_SDT_EncounterCountItem
			Description: SDT_EncounterCount
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
	[XmlRoot(ElementName="SDT_EncounterCountItem")]
	[XmlType(TypeName="SDT_EncounterCountItem" , Namespace="DataAnalysisPlatform" )]
	[Serializable]
	public class SdtSDT_EncounterCount_SDT_EncounterCountItem : GxUserType
	{
		public SdtSDT_EncounterCount_SDT_EncounterCountItem( )
		{
			/* Constructor for serialization */
			gxTv_SdtSDT_EncounterCount_SDT_EncounterCountItem_Month = "";

			gxTv_SdtSDT_EncounterCount_SDT_EncounterCountItem_Value = "";

		}

		public SdtSDT_EncounterCount_SDT_EncounterCountItem(IGxContext context)
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
			AddObjectProperty("month", gxTpr_Month, false);
			AddObjectProperty("value", gxTpr_Value, false);
			return;
		}
		#endregion

		#region Properties

		[SoapElement(ElementName="month")]
		[XmlElement(ElementName="month")]
		public String gxTpr_Month
		{
			get { 
				return gxTv_SdtSDT_EncounterCount_SDT_EncounterCountItem_Month; 
			}
			set { 
				gxTv_SdtSDT_EncounterCount_SDT_EncounterCountItem_Month = value;
				SetDirty("Month");
			}
		}


		[SoapElement(ElementName="value")]
		[XmlElement(ElementName="value")]
		public String gxTpr_Value
		{
			get { 
				return gxTv_SdtSDT_EncounterCount_SDT_EncounterCountItem_Value; 
			}
			set { 
				gxTv_SdtSDT_EncounterCount_SDT_EncounterCountItem_Value = value;
				SetDirty("Value");
			}
		}


		#endregion

		#region Initialization

		public void initialize( )
		{
			gxTv_SdtSDT_EncounterCount_SDT_EncounterCountItem_Month = "";
			gxTv_SdtSDT_EncounterCount_SDT_EncounterCountItem_Value = "";
			return  ;
		}



		#endregion

		#region Declaration

		protected String gxTv_SdtSDT_EncounterCount_SDT_EncounterCountItem_Month;
		protected String gxTv_SdtSDT_EncounterCount_SDT_EncounterCountItem_Value;



		#endregion
	}
	#region Rest interface
	[DataContract(Name=@"SDT_EncounterCountItem", Namespace="DataAnalysisPlatform")]
	public class SdtSDT_EncounterCount_SDT_EncounterCountItem_RESTInterface : GxGenericCollectionItem<SdtSDT_EncounterCount_SDT_EncounterCountItem>, System.Web.SessionState.IRequiresSessionState
	{
		public SdtSDT_EncounterCount_SDT_EncounterCountItem_RESTInterface( ) : base()
		{
		}

		public SdtSDT_EncounterCount_SDT_EncounterCountItem_RESTInterface( SdtSDT_EncounterCount_SDT_EncounterCountItem psdt ) : base(psdt)
		{
		}

		#region Rest Properties
		[DataMember(Name="month", Order=0)]
		public String gxTpr_Month
		{
			get { 
				return sdt.gxTpr_Month;
			}
			set { 
				sdt.gxTpr_Month = value;
			}
		}

		[DataMember(Name="value", Order=1)]
		public String gxTpr_Value
		{
			get { 
				return sdt.gxTpr_Value;
			}
			set { 
				sdt.gxTpr_Value = value;
			}
		}


		#endregion

		public SdtSDT_EncounterCount_SDT_EncounterCountItem sdt
		{
			get { 
				return (SdtSDT_EncounterCount_SDT_EncounterCountItem)Sdt;
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
				sdt = new SdtSDT_EncounterCount_SDT_EncounterCountItem() ;
			}
		}
	}
	#endregion
}