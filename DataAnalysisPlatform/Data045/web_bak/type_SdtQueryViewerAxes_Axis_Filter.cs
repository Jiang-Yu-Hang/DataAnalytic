/*
				   File: type_SdtQueryViewerAxes_Axis_Filter
			Description: Filter
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
	[XmlRoot(ElementName="QueryViewerAxes.Axis.Filter")]
	[XmlType(TypeName="QueryViewerAxes.Axis.Filter" , Namespace="DataAnalysisPlatform" )]
	[Serializable]
	public class SdtQueryViewerAxes_Axis_Filter : GxUserType
	{
		public SdtQueryViewerAxes_Axis_Filter( )
		{
			/* Constructor for serialization */
			gxTv_SdtQueryViewerAxes_Axis_Filter_Type = "";

		}

		public SdtQueryViewerAxes_Axis_Filter(IGxContext context)
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
			AddObjectProperty("Type", gxTpr_Type, false);
			AddObjectProperty("Values", gxTv_SdtQueryViewerAxes_Axis_Filter_Values, false);  
			return;
		}
		#endregion

		#region Properties

		[SoapElement(ElementName="Type")]
		[XmlElement(ElementName="Type")]
		public String gxTpr_Type
		{
			get { 
				return gxTv_SdtQueryViewerAxes_Axis_Filter_Type; 
			}
			set { 
				gxTv_SdtQueryViewerAxes_Axis_Filter_Type = value;
				SetDirty("Type");
			}
		}


		[SoapElement(ElementName="Values" )]
		[XmlArray(ElementName="Values"  )]
		[XmlArrayItemAttribute(ElementName="Value" , IsNullable=false )]
		public GxSimpleCollection<String> gxTpr_Values_GxSimpleCollection
		{
			get {
				if ( gxTv_SdtQueryViewerAxes_Axis_Filter_Values == null )
				{
					gxTv_SdtQueryViewerAxes_Axis_Filter_Values = new GxSimpleCollection<String>( );
				}
				return gxTv_SdtQueryViewerAxes_Axis_Filter_Values;
			}
			set {
				if ( gxTv_SdtQueryViewerAxes_Axis_Filter_Values == null )
				{
					gxTv_SdtQueryViewerAxes_Axis_Filter_Values = new GxSimpleCollection<String>( );
				}
				gxTv_SdtQueryViewerAxes_Axis_Filter_Values = value;
			}
		}

		[SoapIgnore]
		[XmlIgnore]
		public GxSimpleCollection<String> gxTpr_Values
		{
			get {
				if ( gxTv_SdtQueryViewerAxes_Axis_Filter_Values == null )
				{
					gxTv_SdtQueryViewerAxes_Axis_Filter_Values = new GxSimpleCollection<String>();
				}
				return gxTv_SdtQueryViewerAxes_Axis_Filter_Values ;
			}
			set {
				gxTv_SdtQueryViewerAxes_Axis_Filter_Values = value;
				SetDirty("Values");
			}
		}

		public void gxTv_SdtQueryViewerAxes_Axis_Filter_Values_SetNull()
		{
			gxTv_SdtQueryViewerAxes_Axis_Filter_Values = null;
			return  ;
		}

		public bool gxTv_SdtQueryViewerAxes_Axis_Filter_Values_IsNull()
		{
			if (gxTv_SdtQueryViewerAxes_Axis_Filter_Values == null)
			{
				return true ;
			}
			return false ;
		}



		#endregion

		#region Initialization

		public void initialize( )
		{
			gxTv_SdtQueryViewerAxes_Axis_Filter_Type = "";

			return  ;
		}



		#endregion

		#region Declaration

		protected String gxTv_SdtQueryViewerAxes_Axis_Filter_Type;
		protected GxSimpleCollection<String> gxTv_SdtQueryViewerAxes_Axis_Filter_Values = null; 


		#endregion
	}
	#region Rest interface
	[DataContract(Name=@"QueryViewerAxes.Axis.Filter", Namespace="DataAnalysisPlatform")]
	public class SdtQueryViewerAxes_Axis_Filter_RESTInterface : GxGenericCollectionItem<SdtQueryViewerAxes_Axis_Filter>, System.Web.SessionState.IRequiresSessionState
	{
		public SdtQueryViewerAxes_Axis_Filter_RESTInterface( ) : base()
		{
		}

		public SdtQueryViewerAxes_Axis_Filter_RESTInterface( SdtQueryViewerAxes_Axis_Filter psdt ) : base(psdt)
		{
		}

		#region Rest Properties
		[DataMember(Name="Type", Order=0)]
		public String gxTpr_Type
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Type);
			}
			set { 
				sdt.gxTpr_Type = value;
			}
		}

		[DataMember(Name="Values", Order=1)]
		public  GxSimpleCollection<String> gxTpr_Values
		{
			get { 
				return sdt.gxTpr_Values;
			}
			set { 
				sdt.gxTpr_Values = value;
			}
		}


		#endregion

		public SdtQueryViewerAxes_Axis_Filter sdt
		{
			get { 
				return (SdtQueryViewerAxes_Axis_Filter)Sdt;
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
				sdt = new SdtQueryViewerAxes_Axis_Filter() ;
			}
		}
	}
	#endregion
}