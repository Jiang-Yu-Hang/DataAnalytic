/*
               File: type_SdtBR_Pathology_Specimen
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:37:45.26
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
   [XmlRoot(ElementName = "BR_Pathology_Specimen" )]
   [XmlType(TypeName =  "BR_Pathology_Specimen" , Namespace = "DataAnalysisPlatform" )]
   [Serializable]
   public class SdtBR_Pathology_Specimen : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtBR_Pathology_Specimen( )
      {
      }

      public SdtBR_Pathology_Specimen( IGxContext context )
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

      public void Load( long AV274BR_Pathology_SpecimenID )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(long)AV274BR_Pathology_SpecimenID});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"BR_Pathology_SpecimenID", typeof(long)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "BR_Pathology_Specimen");
         metadata.Set("BT", "BR_Pathology_Specimen");
         metadata.Set("PK", "[ \"BR_Pathology_SpecimenID\" ]");
         metadata.Set("PKAssigned", "[ \"BR_Pathology_SpecimenID\" ]");
         metadata.Set("FKList", "[ { \"FK\":[ \"BR_PathologyID\" ],\"FKMap\":[  ] } ]");
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
         state.Add("gxTpr_Br_pathology_specimenid_Z");
         state.Add("gxTpr_Br_pathologyid_Z");
         state.Add("gxTpr_Br_pathology_specimen_name_Z");
         state.Add("gxTpr_Br_pathologyid_N");
         state.Add("gxTpr_Br_pathology_specimen_name_N");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtBR_Pathology_Specimen sdt ;
         sdt = (SdtBR_Pathology_Specimen)(source);
         gxTv_SdtBR_Pathology_Specimen_Br_pathology_specimenid = sdt.gxTv_SdtBR_Pathology_Specimen_Br_pathology_specimenid ;
         gxTv_SdtBR_Pathology_Specimen_Br_pathologyid = sdt.gxTv_SdtBR_Pathology_Specimen_Br_pathologyid ;
         gxTv_SdtBR_Pathology_Specimen_Br_pathology_specimen_name = sdt.gxTv_SdtBR_Pathology_Specimen_Br_pathology_specimen_name ;
         gxTv_SdtBR_Pathology_Specimen_Mode = sdt.gxTv_SdtBR_Pathology_Specimen_Mode ;
         gxTv_SdtBR_Pathology_Specimen_Initialized = sdt.gxTv_SdtBR_Pathology_Specimen_Initialized ;
         gxTv_SdtBR_Pathology_Specimen_Br_pathology_specimenid_Z = sdt.gxTv_SdtBR_Pathology_Specimen_Br_pathology_specimenid_Z ;
         gxTv_SdtBR_Pathology_Specimen_Br_pathologyid_Z = sdt.gxTv_SdtBR_Pathology_Specimen_Br_pathologyid_Z ;
         gxTv_SdtBR_Pathology_Specimen_Br_pathology_specimen_name_Z = sdt.gxTv_SdtBR_Pathology_Specimen_Br_pathology_specimen_name_Z ;
         gxTv_SdtBR_Pathology_Specimen_Br_pathologyid_N = sdt.gxTv_SdtBR_Pathology_Specimen_Br_pathologyid_N ;
         gxTv_SdtBR_Pathology_Specimen_Br_pathology_specimen_name_N = sdt.gxTv_SdtBR_Pathology_Specimen_Br_pathology_specimen_name_N ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("BR_Pathology_SpecimenID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Pathology_Specimen_Br_pathology_specimenid), 18, 0)), false);
         AddObjectProperty("BR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Pathology_Specimen_Br_pathologyid), 18, 0)), false);
         AddObjectProperty("BR_PathologyID_N", gxTv_SdtBR_Pathology_Specimen_Br_pathologyid_N, false);
         AddObjectProperty("BR_Pathology_Specimen_Name", gxTv_SdtBR_Pathology_Specimen_Br_pathology_specimen_name, false);
         AddObjectProperty("BR_Pathology_Specimen_Name_N", gxTv_SdtBR_Pathology_Specimen_Br_pathology_specimen_name_N, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtBR_Pathology_Specimen_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtBR_Pathology_Specimen_Initialized, false);
            AddObjectProperty("BR_Pathology_SpecimenID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Pathology_Specimen_Br_pathology_specimenid_Z), 18, 0)), false);
            AddObjectProperty("BR_PathologyID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Pathology_Specimen_Br_pathologyid_Z), 18, 0)), false);
            AddObjectProperty("BR_Pathology_Specimen_Name_Z", gxTv_SdtBR_Pathology_Specimen_Br_pathology_specimen_name_Z, false);
            AddObjectProperty("BR_PathologyID_N", gxTv_SdtBR_Pathology_Specimen_Br_pathologyid_N, false);
            AddObjectProperty("BR_Pathology_Specimen_Name_N", gxTv_SdtBR_Pathology_Specimen_Br_pathology_specimen_name_N, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtBR_Pathology_Specimen sdt )
      {
         if ( sdt.IsDirty("BR_Pathology_SpecimenID") )
         {
            gxTv_SdtBR_Pathology_Specimen_Br_pathology_specimenid = sdt.gxTv_SdtBR_Pathology_Specimen_Br_pathology_specimenid ;
         }
         if ( sdt.IsDirty("BR_PathologyID") )
         {
            gxTv_SdtBR_Pathology_Specimen_Br_pathologyid = sdt.gxTv_SdtBR_Pathology_Specimen_Br_pathologyid ;
         }
         if ( sdt.IsDirty("BR_Pathology_Specimen_Name") )
         {
            gxTv_SdtBR_Pathology_Specimen_Br_pathology_specimen_name = sdt.gxTv_SdtBR_Pathology_Specimen_Br_pathology_specimen_name ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "BR_Pathology_SpecimenID" )]
      [  XmlElement( ElementName = "BR_Pathology_SpecimenID"   )]
      public long gxTpr_Br_pathology_specimenid
      {
         get {
            return gxTv_SdtBR_Pathology_Specimen_Br_pathology_specimenid ;
         }

         set {
            if ( gxTv_SdtBR_Pathology_Specimen_Br_pathology_specimenid != value )
            {
               gxTv_SdtBR_Pathology_Specimen_Mode = "INS";
               this.gxTv_SdtBR_Pathology_Specimen_Br_pathology_specimenid_Z_SetNull( );
               this.gxTv_SdtBR_Pathology_Specimen_Br_pathologyid_Z_SetNull( );
               this.gxTv_SdtBR_Pathology_Specimen_Br_pathology_specimen_name_Z_SetNull( );
            }
            gxTv_SdtBR_Pathology_Specimen_Br_pathology_specimenid = value;
            SetDirty("Br_pathology_specimenid");
         }

      }

      [  SoapElement( ElementName = "BR_PathologyID" )]
      [  XmlElement( ElementName = "BR_PathologyID"   )]
      public long gxTpr_Br_pathologyid
      {
         get {
            return gxTv_SdtBR_Pathology_Specimen_Br_pathologyid ;
         }

         set {
            gxTv_SdtBR_Pathology_Specimen_Br_pathologyid_N = 0;
            gxTv_SdtBR_Pathology_Specimen_Br_pathologyid = value;
            SetDirty("Br_pathologyid");
         }

      }

      public void gxTv_SdtBR_Pathology_Specimen_Br_pathologyid_SetNull( )
      {
         gxTv_SdtBR_Pathology_Specimen_Br_pathologyid_N = 1;
         gxTv_SdtBR_Pathology_Specimen_Br_pathologyid = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Specimen_Br_pathologyid_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_Specimen_Name" )]
      [  XmlElement( ElementName = "BR_Pathology_Specimen_Name"   )]
      public String gxTpr_Br_pathology_specimen_name
      {
         get {
            return gxTv_SdtBR_Pathology_Specimen_Br_pathology_specimen_name ;
         }

         set {
            gxTv_SdtBR_Pathology_Specimen_Br_pathology_specimen_name_N = 0;
            gxTv_SdtBR_Pathology_Specimen_Br_pathology_specimen_name = value;
            SetDirty("Br_pathology_specimen_name");
         }

      }

      public void gxTv_SdtBR_Pathology_Specimen_Br_pathology_specimen_name_SetNull( )
      {
         gxTv_SdtBR_Pathology_Specimen_Br_pathology_specimen_name_N = 1;
         gxTv_SdtBR_Pathology_Specimen_Br_pathology_specimen_name = "";
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Specimen_Br_pathology_specimen_name_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtBR_Pathology_Specimen_Mode ;
         }

         set {
            gxTv_SdtBR_Pathology_Specimen_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtBR_Pathology_Specimen_Mode_SetNull( )
      {
         gxTv_SdtBR_Pathology_Specimen_Mode = "";
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Specimen_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtBR_Pathology_Specimen_Initialized ;
         }

         set {
            gxTv_SdtBR_Pathology_Specimen_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtBR_Pathology_Specimen_Initialized_SetNull( )
      {
         gxTv_SdtBR_Pathology_Specimen_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Specimen_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_SpecimenID_Z" )]
      [  XmlElement( ElementName = "BR_Pathology_SpecimenID_Z"   )]
      public long gxTpr_Br_pathology_specimenid_Z
      {
         get {
            return gxTv_SdtBR_Pathology_Specimen_Br_pathology_specimenid_Z ;
         }

         set {
            gxTv_SdtBR_Pathology_Specimen_Br_pathology_specimenid_Z = value;
            SetDirty("Br_pathology_specimenid_Z");
         }

      }

      public void gxTv_SdtBR_Pathology_Specimen_Br_pathology_specimenid_Z_SetNull( )
      {
         gxTv_SdtBR_Pathology_Specimen_Br_pathology_specimenid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Specimen_Br_pathology_specimenid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_PathologyID_Z" )]
      [  XmlElement( ElementName = "BR_PathologyID_Z"   )]
      public long gxTpr_Br_pathologyid_Z
      {
         get {
            return gxTv_SdtBR_Pathology_Specimen_Br_pathologyid_Z ;
         }

         set {
            gxTv_SdtBR_Pathology_Specimen_Br_pathologyid_Z = value;
            SetDirty("Br_pathologyid_Z");
         }

      }

      public void gxTv_SdtBR_Pathology_Specimen_Br_pathologyid_Z_SetNull( )
      {
         gxTv_SdtBR_Pathology_Specimen_Br_pathologyid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Specimen_Br_pathologyid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_Specimen_Name_Z" )]
      [  XmlElement( ElementName = "BR_Pathology_Specimen_Name_Z"   )]
      public String gxTpr_Br_pathology_specimen_name_Z
      {
         get {
            return gxTv_SdtBR_Pathology_Specimen_Br_pathology_specimen_name_Z ;
         }

         set {
            gxTv_SdtBR_Pathology_Specimen_Br_pathology_specimen_name_Z = value;
            SetDirty("Br_pathology_specimen_name_Z");
         }

      }

      public void gxTv_SdtBR_Pathology_Specimen_Br_pathology_specimen_name_Z_SetNull( )
      {
         gxTv_SdtBR_Pathology_Specimen_Br_pathology_specimen_name_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Specimen_Br_pathology_specimen_name_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_PathologyID_N" )]
      [  XmlElement( ElementName = "BR_PathologyID_N"   )]
      public short gxTpr_Br_pathologyid_N
      {
         get {
            return gxTv_SdtBR_Pathology_Specimen_Br_pathologyid_N ;
         }

         set {
            gxTv_SdtBR_Pathology_Specimen_Br_pathologyid_N = value;
            SetDirty("Br_pathologyid_N");
         }

      }

      public void gxTv_SdtBR_Pathology_Specimen_Br_pathologyid_N_SetNull( )
      {
         gxTv_SdtBR_Pathology_Specimen_Br_pathologyid_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Specimen_Br_pathologyid_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_Specimen_Name_N" )]
      [  XmlElement( ElementName = "BR_Pathology_Specimen_Name_N"   )]
      public short gxTpr_Br_pathology_specimen_name_N
      {
         get {
            return gxTv_SdtBR_Pathology_Specimen_Br_pathology_specimen_name_N ;
         }

         set {
            gxTv_SdtBR_Pathology_Specimen_Br_pathology_specimen_name_N = value;
            SetDirty("Br_pathology_specimen_name_N");
         }

      }

      public void gxTv_SdtBR_Pathology_Specimen_Br_pathology_specimen_name_N_SetNull( )
      {
         gxTv_SdtBR_Pathology_Specimen_Br_pathology_specimen_name_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Specimen_Br_pathology_specimen_name_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtBR_Pathology_Specimen_Br_pathology_specimen_name = "";
         gxTv_SdtBR_Pathology_Specimen_Mode = "";
         gxTv_SdtBR_Pathology_Specimen_Br_pathology_specimen_name_Z = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "br_pathology_specimen", "GeneXus.Programs.br_pathology_specimen_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtBR_Pathology_Specimen_Initialized ;
      private short gxTv_SdtBR_Pathology_Specimen_Br_pathologyid_N ;
      private short gxTv_SdtBR_Pathology_Specimen_Br_pathology_specimen_name_N ;
      private long gxTv_SdtBR_Pathology_Specimen_Br_pathology_specimenid ;
      private long gxTv_SdtBR_Pathology_Specimen_Br_pathologyid ;
      private long gxTv_SdtBR_Pathology_Specimen_Br_pathology_specimenid_Z ;
      private long gxTv_SdtBR_Pathology_Specimen_Br_pathologyid_Z ;
      private String gxTv_SdtBR_Pathology_Specimen_Mode ;
      private String gxTv_SdtBR_Pathology_Specimen_Br_pathology_specimen_name ;
      private String gxTv_SdtBR_Pathology_Specimen_Br_pathology_specimen_name_Z ;
   }

   [DataContract(Name = @"BR_Pathology_Specimen", Namespace = "DataAnalysisPlatform")]
   public class SdtBR_Pathology_Specimen_RESTInterface : GxGenericCollectionItem<SdtBR_Pathology_Specimen>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtBR_Pathology_Specimen_RESTInterface( ) : base()
      {
      }

      public SdtBR_Pathology_Specimen_RESTInterface( SdtBR_Pathology_Specimen psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "BR_Pathology_SpecimenID" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Br_pathology_specimenid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Br_pathology_specimenid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Br_pathology_specimenid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "BR_PathologyID" , Order = 1 )]
      [GxSeudo()]
      public String gxTpr_Br_pathologyid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Br_pathologyid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Br_pathologyid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "BR_Pathology_Specimen_Name" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_Br_pathology_specimen_name
      {
         get {
            return sdt.gxTpr_Br_pathology_specimen_name ;
         }

         set {
            sdt.gxTpr_Br_pathology_specimen_name = value;
         }

      }

      public SdtBR_Pathology_Specimen sdt
      {
         get {
            return (SdtBR_Pathology_Specimen)Sdt ;
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
            sdt = new SdtBR_Pathology_Specimen() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 3 )]
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
