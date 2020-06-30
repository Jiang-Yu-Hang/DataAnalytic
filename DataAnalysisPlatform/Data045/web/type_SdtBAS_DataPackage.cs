/*
               File: type_SdtBAS_DataPackage
        Description: BAS_Data Package
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:8:58.33
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
using System.Web.Services.Protocols;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Reflection;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   [XmlSerializerFormat]
   [XmlRoot(ElementName = "BAS_DataPackage" )]
   [XmlType(TypeName =  "BAS_DataPackage" , Namespace = "DataAnalysisPlatform" )]
   [Serializable]
   public class SdtBAS_DataPackage : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtBAS_DataPackage( )
      {
      }

      public SdtBAS_DataPackage( IGxContext context )
      {
         this.context = context;
         constructorCallingAssembly = Assembly.GetCallingAssembly();
         initialize();
      }

      private static Hashtable mapper;
      public override String JsonMap( String value )
      {
         if ( mapper == null )
         {
            mapper = new Hashtable();
         }
         return (String)mapper[value]; ;
      }

      public void Load( String AV366DataPackage )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(String)AV366DataPackage});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"DataPackage", typeof(String)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "BAS_DataPackage");
         metadata.Set("BT", "BAS_DATAPACKAGE");
         metadata.Set("PK", "[ \"DataPackage\" ]");
         metadata.Set("AllowInsert", "True");
         metadata.Set("AllowUpdate", "True");
         metadata.Set("AllowDelete", "True");
         return metadata ;
      }

      public override GeneXus.Utils.GxStringCollection StateAttributes( )
      {
         GeneXus.Utils.GxStringCollection state = new GeneXus.Utils.GxStringCollection() ;
         state.Add("gxTpr_Mode");
         state.Add("gxTpr_Initialized");
         state.Add("gxTpr_Datapackage_Z");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtBAS_DataPackage sdt ;
         sdt = (SdtBAS_DataPackage)(source);
         gxTv_SdtBAS_DataPackage_Datapackage = sdt.gxTv_SdtBAS_DataPackage_Datapackage ;
         gxTv_SdtBAS_DataPackage_Mode = sdt.gxTv_SdtBAS_DataPackage_Mode ;
         gxTv_SdtBAS_DataPackage_Initialized = sdt.gxTv_SdtBAS_DataPackage_Initialized ;
         gxTv_SdtBAS_DataPackage_Datapackage_Z = sdt.gxTv_SdtBAS_DataPackage_Datapackage_Z ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("DataPackage", gxTv_SdtBAS_DataPackage_Datapackage, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtBAS_DataPackage_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtBAS_DataPackage_Initialized, false);
            AddObjectProperty("DataPackage_Z", gxTv_SdtBAS_DataPackage_Datapackage_Z, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtBAS_DataPackage sdt )
      {
         if ( sdt.IsDirty("DataPackage") )
         {
            gxTv_SdtBAS_DataPackage_Datapackage = sdt.gxTv_SdtBAS_DataPackage_Datapackage ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "DataPackage" )]
      [  XmlElement( ElementName = "DataPackage"   )]
      public String gxTpr_Datapackage
      {
         get {
            return gxTv_SdtBAS_DataPackage_Datapackage ;
         }

         set {
            if ( StringUtil.StrCmp(gxTv_SdtBAS_DataPackage_Datapackage, value) != 0 )
            {
               gxTv_SdtBAS_DataPackage_Mode = "INS";
               this.gxTv_SdtBAS_DataPackage_Datapackage_Z_SetNull( );
            }
            gxTv_SdtBAS_DataPackage_Datapackage = value;
            SetDirty("Datapackage");
         }

      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtBAS_DataPackage_Mode ;
         }

         set {
            gxTv_SdtBAS_DataPackage_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtBAS_DataPackage_Mode_SetNull( )
      {
         gxTv_SdtBAS_DataPackage_Mode = "";
         return  ;
      }

      public bool gxTv_SdtBAS_DataPackage_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtBAS_DataPackage_Initialized ;
         }

         set {
            gxTv_SdtBAS_DataPackage_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtBAS_DataPackage_Initialized_SetNull( )
      {
         gxTv_SdtBAS_DataPackage_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtBAS_DataPackage_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "DataPackage_Z" )]
      [  XmlElement( ElementName = "DataPackage_Z"   )]
      public String gxTpr_Datapackage_Z
      {
         get {
            return gxTv_SdtBAS_DataPackage_Datapackage_Z ;
         }

         set {
            gxTv_SdtBAS_DataPackage_Datapackage_Z = value;
            SetDirty("Datapackage_Z");
         }

      }

      public void gxTv_SdtBAS_DataPackage_Datapackage_Z_SetNull( )
      {
         gxTv_SdtBAS_DataPackage_Datapackage_Z = "";
         return  ;
      }

      public bool gxTv_SdtBAS_DataPackage_Datapackage_Z_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtBAS_DataPackage_Datapackage = "";
         gxTv_SdtBAS_DataPackage_Mode = "";
         gxTv_SdtBAS_DataPackage_Datapackage_Z = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "bas_datapackage", "GeneXus.Programs.bas_datapackage_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtBAS_DataPackage_Initialized ;
      private String gxTv_SdtBAS_DataPackage_Mode ;
      private String gxTv_SdtBAS_DataPackage_Datapackage ;
      private String gxTv_SdtBAS_DataPackage_Datapackage_Z ;
   }

   [DataContract(Name = @"BAS_DataPackage", Namespace = "DataAnalysisPlatform")]
   public class SdtBAS_DataPackage_RESTInterface : GxGenericCollectionItem<SdtBAS_DataPackage>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtBAS_DataPackage_RESTInterface( ) : base()
      {
      }

      public SdtBAS_DataPackage_RESTInterface( SdtBAS_DataPackage psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "DataPackage" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Datapackage
      {
         get {
            return sdt.gxTpr_Datapackage ;
         }

         set {
            sdt.gxTpr_Datapackage = value;
         }

      }

      public SdtBAS_DataPackage sdt
      {
         get {
            return (SdtBAS_DataPackage)Sdt ;
         }

         set {
            Sdt = value ;
         }

      }

      [OnDeserializing]
      void checkSdt( StreamingContext ctx )
      {
         if ( sdt == null )
         {
            sdt = new SdtBAS_DataPackage() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 1 )]
      public string Hash
      {
         get {
            if ( StringUtil.StrCmp(md5Hash, null) == 0 )
            {
               md5Hash = (String)(getHash());
            }
            return md5Hash ;
         }

         set {
            md5Hash = value ;
         }

      }

      private String md5Hash ;
   }

}
