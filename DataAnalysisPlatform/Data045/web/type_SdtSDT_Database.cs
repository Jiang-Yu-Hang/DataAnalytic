/*
				   File: type_SdtSDT_Database
			Description: SDT_Database
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
	[XmlRoot(ElementName="SDT_Database")]
	[XmlType(TypeName="SDT_Database" , Namespace="DataAnalysisPlatform" )]
	[Serializable]
	public class SdtSDT_Database : GxUserType
	{
		public SdtSDT_Database( )
		{
			/* Constructor for serialization */
			gxTv_SdtSDT_Database_Databasename = "";

			gxTv_SdtSDT_Database_Dataaddress = "";

			gxTv_SdtSDT_Database_Username = "";

			gxTv_SdtSDT_Database_Userpwd = "";

		}

		public SdtSDT_Database(IGxContext context)
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
			AddObjectProperty("DatabaseName", gxTpr_Databasename, false);
			AddObjectProperty("DataAddress", gxTpr_Dataaddress, false);
			AddObjectProperty("username", gxTpr_Username, false);
			AddObjectProperty("userpwd", gxTpr_Userpwd, false);
			return;
		}
		#endregion

		#region Properties

		[SoapElement(ElementName="DatabaseName")]
		[XmlElement(ElementName="DatabaseName")]
		public String gxTpr_Databasename
		{
			get { 
				return gxTv_SdtSDT_Database_Databasename; 
			}
			set { 
				gxTv_SdtSDT_Database_Databasename = value;
				SetDirty("Databasename");
			}
		}


		[SoapElement(ElementName="DataAddress")]
		[XmlElement(ElementName="DataAddress")]
		public String gxTpr_Dataaddress
		{
			get { 
				return gxTv_SdtSDT_Database_Dataaddress; 
			}
			set { 
				gxTv_SdtSDT_Database_Dataaddress = value;
				SetDirty("Dataaddress");
			}
		}


		[SoapElement(ElementName="username")]
		[XmlElement(ElementName="username")]
		public String gxTpr_Username
		{
			get { 
				return gxTv_SdtSDT_Database_Username; 
			}
			set { 
				gxTv_SdtSDT_Database_Username = value;
				SetDirty("Username");
			}
		}


		[SoapElement(ElementName="userpwd")]
		[XmlElement(ElementName="userpwd")]
		public String gxTpr_Userpwd
		{
			get { 
				return gxTv_SdtSDT_Database_Userpwd; 
			}
			set { 
				gxTv_SdtSDT_Database_Userpwd = value;
				SetDirty("Userpwd");
			}
		}


		#endregion

		#region Initialization

		public void initialize( )
		{
			gxTv_SdtSDT_Database_Databasename = "";
			gxTv_SdtSDT_Database_Dataaddress = "";
			gxTv_SdtSDT_Database_Username = "";
			gxTv_SdtSDT_Database_Userpwd = "";
			return  ;
		}



		#endregion

		#region Declaration

		protected String gxTv_SdtSDT_Database_Databasename;
		protected String gxTv_SdtSDT_Database_Dataaddress;
		protected String gxTv_SdtSDT_Database_Username;
		protected String gxTv_SdtSDT_Database_Userpwd;



		#endregion
	}
	#region Rest interface
	[DataContract(Name=@"SDT_Database", Namespace="DataAnalysisPlatform")]
	public class SdtSDT_Database_RESTInterface : GxGenericCollectionItem<SdtSDT_Database>, System.Web.SessionState.IRequiresSessionState
	{
		public SdtSDT_Database_RESTInterface( ) : base()
		{
		}

		public SdtSDT_Database_RESTInterface( SdtSDT_Database psdt ) : base(psdt)
		{
		}

		#region Rest Properties
		[DataMember(Name="DatabaseName", Order=0)]
		public String gxTpr_Databasename
		{
			get { 
				return sdt.gxTpr_Databasename;
			}
			set { 
				sdt.gxTpr_Databasename = value;
			}
		}

		[DataMember(Name="DataAddress", Order=1)]
		public String gxTpr_Dataaddress
		{
			get { 
				return sdt.gxTpr_Dataaddress;
			}
			set { 
				sdt.gxTpr_Dataaddress = value;
			}
		}

		[DataMember(Name="username", Order=2)]
		public String gxTpr_Username
		{
			get { 
				return sdt.gxTpr_Username;
			}
			set { 
				sdt.gxTpr_Username = value;
			}
		}

		[DataMember(Name="userpwd", Order=3)]
		public String gxTpr_Userpwd
		{
			get { 
				return sdt.gxTpr_Userpwd;
			}
			set { 
				sdt.gxTpr_Userpwd = value;
			}
		}


		#endregion

		public SdtSDT_Database sdt
		{
			get { 
				return (SdtSDT_Database)Sdt;
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
				sdt = new SdtSDT_Database() ;
			}
		}
	}
	#endregion
}