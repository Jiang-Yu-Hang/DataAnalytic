/*
               File: type_SdtBR_PatientReEntity
        Description: 患者病种关系图
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:39:6.58
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
   [XmlRoot(ElementName = "BR_PatientReEntity" )]
   [XmlType(TypeName =  "BR_PatientReEntity" , Namespace = "DataAnalysisPlatform" )]
   [Serializable]
   public class SdtBR_PatientReEntity : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtBR_PatientReEntity( )
      {
      }

      public SdtBR_PatientReEntity( IGxContext context )
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

      public void Load( long AV85BR_Information_ID ,
                        String AV366DataPackage )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(long)AV85BR_Information_ID,(String)AV366DataPackage});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"BR_Information_ID", typeof(long)}, new Object[]{"DataPackage", typeof(String)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "BR_PatientReEntity");
         metadata.Set("BT", "BR_PatientReEntity");
         metadata.Set("PK", "[ \"BR_Information_ID\",\"DataPackage\" ]");
         metadata.Set("FKList", "[ { \"FK\":[ \"BR_Information_ID\" ],\"FKMap\":[  ] },{ \"FK\":[ \"DataPackage\" ],\"FKMap\":[  ] } ]");
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
         state.Add("gxTpr_Br_information_id_Z");
         state.Add("gxTpr_Datapackage_Z");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtBR_PatientReEntity sdt ;
         sdt = (SdtBR_PatientReEntity)(source);
         gxTv_SdtBR_PatientReEntity_Br_information_id = sdt.gxTv_SdtBR_PatientReEntity_Br_information_id ;
         gxTv_SdtBR_PatientReEntity_Datapackage = sdt.gxTv_SdtBR_PatientReEntity_Datapackage ;
         gxTv_SdtBR_PatientReEntity_Mode = sdt.gxTv_SdtBR_PatientReEntity_Mode ;
         gxTv_SdtBR_PatientReEntity_Initialized = sdt.gxTv_SdtBR_PatientReEntity_Initialized ;
         gxTv_SdtBR_PatientReEntity_Br_information_id_Z = sdt.gxTv_SdtBR_PatientReEntity_Br_information_id_Z ;
         gxTv_SdtBR_PatientReEntity_Datapackage_Z = sdt.gxTv_SdtBR_PatientReEntity_Datapackage_Z ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_PatientReEntity_Br_information_id), 18, 0)), false);
         AddObjectProperty("DataPackage", gxTv_SdtBR_PatientReEntity_Datapackage, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtBR_PatientReEntity_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtBR_PatientReEntity_Initialized, false);
            AddObjectProperty("BR_Information_ID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_PatientReEntity_Br_information_id_Z), 18, 0)), false);
            AddObjectProperty("DataPackage_Z", gxTv_SdtBR_PatientReEntity_Datapackage_Z, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtBR_PatientReEntity sdt )
      {
         if ( sdt.IsDirty("BR_Information_ID") )
         {
            gxTv_SdtBR_PatientReEntity_Br_information_id = sdt.gxTv_SdtBR_PatientReEntity_Br_information_id ;
         }
         if ( sdt.IsDirty("DataPackage") )
         {
            gxTv_SdtBR_PatientReEntity_Datapackage = sdt.gxTv_SdtBR_PatientReEntity_Datapackage ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "BR_Information_ID" )]
      [  XmlElement( ElementName = "BR_Information_ID"   )]
      public long gxTpr_Br_information_id
      {
         get {
            return gxTv_SdtBR_PatientReEntity_Br_information_id ;
         }

         set {
            if ( gxTv_SdtBR_PatientReEntity_Br_information_id != value )
            {
               gxTv_SdtBR_PatientReEntity_Mode = "INS";
               this.gxTv_SdtBR_PatientReEntity_Br_information_id_Z_SetNull( );
               this.gxTv_SdtBR_PatientReEntity_Datapackage_Z_SetNull( );
            }
            gxTv_SdtBR_PatientReEntity_Br_information_id = value;
            SetDirty("Br_information_id");
         }

      }

      [  SoapElement( ElementName = "DataPackage" )]
      [  XmlElement( ElementName = "DataPackage"   )]
      public String gxTpr_Datapackage
      {
         get {
            return gxTv_SdtBR_PatientReEntity_Datapackage ;
         }

         set {
            if ( StringUtil.StrCmp(gxTv_SdtBR_PatientReEntity_Datapackage, value) != 0 )
            {
               gxTv_SdtBR_PatientReEntity_Mode = "INS";
               this.gxTv_SdtBR_PatientReEntity_Br_information_id_Z_SetNull( );
               this.gxTv_SdtBR_PatientReEntity_Datapackage_Z_SetNull( );
            }
            gxTv_SdtBR_PatientReEntity_Datapackage = value;
            SetDirty("Datapackage");
         }

      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtBR_PatientReEntity_Mode ;
         }

         set {
            gxTv_SdtBR_PatientReEntity_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtBR_PatientReEntity_Mode_SetNull( )
      {
         gxTv_SdtBR_PatientReEntity_Mode = "";
         return  ;
      }

      public bool gxTv_SdtBR_PatientReEntity_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtBR_PatientReEntity_Initialized ;
         }

         set {
            gxTv_SdtBR_PatientReEntity_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtBR_PatientReEntity_Initialized_SetNull( )
      {
         gxTv_SdtBR_PatientReEntity_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtBR_PatientReEntity_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Information_ID_Z" )]
      [  XmlElement( ElementName = "BR_Information_ID_Z"   )]
      public long gxTpr_Br_information_id_Z
      {
         get {
            return gxTv_SdtBR_PatientReEntity_Br_information_id_Z ;
         }

         set {
            gxTv_SdtBR_PatientReEntity_Br_information_id_Z = value;
            SetDirty("Br_information_id_Z");
         }

      }

      public void gxTv_SdtBR_PatientReEntity_Br_information_id_Z_SetNull( )
      {
         gxTv_SdtBR_PatientReEntity_Br_information_id_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_PatientReEntity_Br_information_id_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "DataPackage_Z" )]
      [  XmlElement( ElementName = "DataPackage_Z"   )]
      public String gxTpr_Datapackage_Z
      {
         get {
            return gxTv_SdtBR_PatientReEntity_Datapackage_Z ;
         }

         set {
            gxTv_SdtBR_PatientReEntity_Datapackage_Z = value;
            SetDirty("Datapackage_Z");
         }

      }

      public void gxTv_SdtBR_PatientReEntity_Datapackage_Z_SetNull( )
      {
         gxTv_SdtBR_PatientReEntity_Datapackage_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_PatientReEntity_Datapackage_Z_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtBR_PatientReEntity_Datapackage = "";
         gxTv_SdtBR_PatientReEntity_Mode = "";
         gxTv_SdtBR_PatientReEntity_Datapackage_Z = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "br_patientreentity", "GeneXus.Programs.br_patientreentity_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtBR_PatientReEntity_Initialized ;
      private long gxTv_SdtBR_PatientReEntity_Br_information_id ;
      private long gxTv_SdtBR_PatientReEntity_Br_information_id_Z ;
      private String gxTv_SdtBR_PatientReEntity_Mode ;
      private String gxTv_SdtBR_PatientReEntity_Datapackage ;
      private String gxTv_SdtBR_PatientReEntity_Datapackage_Z ;
   }

   [DataContract(Name = @"BR_PatientReEntity", Namespace = "DataAnalysisPlatform")]
   public class SdtBR_PatientReEntity_RESTInterface : GxGenericCollectionItem<SdtBR_PatientReEntity>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtBR_PatientReEntity_RESTInterface( ) : base()
      {
      }

      public SdtBR_PatientReEntity_RESTInterface( SdtBR_PatientReEntity psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "BR_Information_ID" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Br_information_id
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Br_information_id), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Br_information_id = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "DataPackage" , Order = 1 )]
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

      public SdtBR_PatientReEntity sdt
      {
         get {
            return (SdtBR_PatientReEntity)Sdt ;
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
            sdt = new SdtBR_PatientReEntity() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 2 )]
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
