/*
               File: type_SdtBR_Pathology_Diag
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:8:18.30
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
   [XmlRoot(ElementName = "BR_Pathology_Diag" )]
   [XmlType(TypeName =  "BR_Pathology_Diag" , Namespace = "DataAnalysisPlatform" )]
   [Serializable]
   public class SdtBR_Pathology_Diag : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtBR_Pathology_Diag( )
      {
      }

      public SdtBR_Pathology_Diag( IGxContext context )
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

      public void Load( long AV276BR_Pathology_DiagID )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(long)AV276BR_Pathology_DiagID});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"BR_Pathology_DiagID", typeof(long)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "BR_Pathology_Diag");
         metadata.Set("BT", "BR_Pathology_Diag");
         metadata.Set("PK", "[ \"BR_Pathology_DiagID\" ]");
         metadata.Set("PKAssigned", "[ \"BR_Pathology_DiagID\" ]");
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
         state.Add("gxTpr_Br_pathology_diagid_Z");
         state.Add("gxTpr_Br_pathologyid_Z");
         state.Add("gxTpr_Br_pathology_diag_loc_Z");
         state.Add("gxTpr_Br_pathology_diag_organ_Z");
         state.Add("gxTpr_Br_pathology_diag_tumortype_Z");
         state.Add("gxTpr_Br_pathology_diag_tumorstage_Z");
         state.Add("gxTpr_Br_pathology_diag_tumorgrade_Z");
         state.Add("gxTpr_Br_pathologyid_N");
         state.Add("gxTpr_Br_pathology_diag_loc_N");
         state.Add("gxTpr_Br_pathology_diag_organ_N");
         state.Add("gxTpr_Br_pathology_diag_tumortype_N");
         state.Add("gxTpr_Br_pathology_diag_tumorstage_N");
         state.Add("gxTpr_Br_pathology_diag_tumorgrade_N");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtBR_Pathology_Diag sdt ;
         sdt = (SdtBR_Pathology_Diag)(source);
         gxTv_SdtBR_Pathology_Diag_Br_pathology_diagid = sdt.gxTv_SdtBR_Pathology_Diag_Br_pathology_diagid ;
         gxTv_SdtBR_Pathology_Diag_Br_pathologyid = sdt.gxTv_SdtBR_Pathology_Diag_Br_pathologyid ;
         gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_loc = sdt.gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_loc ;
         gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_organ = sdt.gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_organ ;
         gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumortype = sdt.gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumortype ;
         gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorstage = sdt.gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorstage ;
         gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorgrade = sdt.gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorgrade ;
         gxTv_SdtBR_Pathology_Diag_Mode = sdt.gxTv_SdtBR_Pathology_Diag_Mode ;
         gxTv_SdtBR_Pathology_Diag_Initialized = sdt.gxTv_SdtBR_Pathology_Diag_Initialized ;
         gxTv_SdtBR_Pathology_Diag_Br_pathology_diagid_Z = sdt.gxTv_SdtBR_Pathology_Diag_Br_pathology_diagid_Z ;
         gxTv_SdtBR_Pathology_Diag_Br_pathologyid_Z = sdt.gxTv_SdtBR_Pathology_Diag_Br_pathologyid_Z ;
         gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_loc_Z = sdt.gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_loc_Z ;
         gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_organ_Z = sdt.gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_organ_Z ;
         gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumortype_Z = sdt.gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumortype_Z ;
         gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorstage_Z = sdt.gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorstage_Z ;
         gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorgrade_Z = sdt.gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorgrade_Z ;
         gxTv_SdtBR_Pathology_Diag_Br_pathologyid_N = sdt.gxTv_SdtBR_Pathology_Diag_Br_pathologyid_N ;
         gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_loc_N = sdt.gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_loc_N ;
         gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_organ_N = sdt.gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_organ_N ;
         gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumortype_N = sdt.gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumortype_N ;
         gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorstage_N = sdt.gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorstage_N ;
         gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorgrade_N = sdt.gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorgrade_N ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("BR_Pathology_DiagID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Pathology_Diag_Br_pathology_diagid), 18, 0)), false);
         AddObjectProperty("BR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Pathology_Diag_Br_pathologyid), 18, 0)), false);
         AddObjectProperty("BR_PathologyID_N", gxTv_SdtBR_Pathology_Diag_Br_pathologyid_N, false);
         AddObjectProperty("BR_Pathology_Diag_Loc", gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_loc, false);
         AddObjectProperty("BR_Pathology_Diag_Loc_N", gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_loc_N, false);
         AddObjectProperty("BR_Pathology_Diag_Organ", gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_organ, false);
         AddObjectProperty("BR_Pathology_Diag_Organ_N", gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_organ_N, false);
         AddObjectProperty("BR_Pathology_Diag_TumorType", gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumortype, false);
         AddObjectProperty("BR_Pathology_Diag_TumorType_N", gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumortype_N, false);
         AddObjectProperty("BR_Pathology_Diag_TumorStage", gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorstage, false);
         AddObjectProperty("BR_Pathology_Diag_TumorStage_N", gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorstage_N, false);
         AddObjectProperty("BR_Pathology_Diag_TumorGrade", gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorgrade, false);
         AddObjectProperty("BR_Pathology_Diag_TumorGrade_N", gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorgrade_N, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtBR_Pathology_Diag_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtBR_Pathology_Diag_Initialized, false);
            AddObjectProperty("BR_Pathology_DiagID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Pathology_Diag_Br_pathology_diagid_Z), 18, 0)), false);
            AddObjectProperty("BR_PathologyID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Pathology_Diag_Br_pathologyid_Z), 18, 0)), false);
            AddObjectProperty("BR_Pathology_Diag_Loc_Z", gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_loc_Z, false);
            AddObjectProperty("BR_Pathology_Diag_Organ_Z", gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_organ_Z, false);
            AddObjectProperty("BR_Pathology_Diag_TumorType_Z", gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumortype_Z, false);
            AddObjectProperty("BR_Pathology_Diag_TumorStage_Z", gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorstage_Z, false);
            AddObjectProperty("BR_Pathology_Diag_TumorGrade_Z", gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorgrade_Z, false);
            AddObjectProperty("BR_PathologyID_N", gxTv_SdtBR_Pathology_Diag_Br_pathologyid_N, false);
            AddObjectProperty("BR_Pathology_Diag_Loc_N", gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_loc_N, false);
            AddObjectProperty("BR_Pathology_Diag_Organ_N", gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_organ_N, false);
            AddObjectProperty("BR_Pathology_Diag_TumorType_N", gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumortype_N, false);
            AddObjectProperty("BR_Pathology_Diag_TumorStage_N", gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorstage_N, false);
            AddObjectProperty("BR_Pathology_Diag_TumorGrade_N", gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorgrade_N, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtBR_Pathology_Diag sdt )
      {
         if ( sdt.IsDirty("BR_Pathology_DiagID") )
         {
            gxTv_SdtBR_Pathology_Diag_Br_pathology_diagid = sdt.gxTv_SdtBR_Pathology_Diag_Br_pathology_diagid ;
         }
         if ( sdt.IsDirty("BR_PathologyID") )
         {
            gxTv_SdtBR_Pathology_Diag_Br_pathologyid = sdt.gxTv_SdtBR_Pathology_Diag_Br_pathologyid ;
         }
         if ( sdt.IsDirty("BR_Pathology_Diag_Loc") )
         {
            gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_loc = sdt.gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_loc ;
         }
         if ( sdt.IsDirty("BR_Pathology_Diag_Organ") )
         {
            gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_organ = sdt.gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_organ ;
         }
         if ( sdt.IsDirty("BR_Pathology_Diag_TumorType") )
         {
            gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumortype = sdt.gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumortype ;
         }
         if ( sdt.IsDirty("BR_Pathology_Diag_TumorStage") )
         {
            gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorstage = sdt.gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorstage ;
         }
         if ( sdt.IsDirty("BR_Pathology_Diag_TumorGrade") )
         {
            gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorgrade = sdt.gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorgrade ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "BR_Pathology_DiagID" )]
      [  XmlElement( ElementName = "BR_Pathology_DiagID"   )]
      public long gxTpr_Br_pathology_diagid
      {
         get {
            return gxTv_SdtBR_Pathology_Diag_Br_pathology_diagid ;
         }

         set {
            if ( gxTv_SdtBR_Pathology_Diag_Br_pathology_diagid != value )
            {
               gxTv_SdtBR_Pathology_Diag_Mode = "INS";
               this.gxTv_SdtBR_Pathology_Diag_Br_pathology_diagid_Z_SetNull( );
               this.gxTv_SdtBR_Pathology_Diag_Br_pathologyid_Z_SetNull( );
               this.gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_loc_Z_SetNull( );
               this.gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_organ_Z_SetNull( );
               this.gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumortype_Z_SetNull( );
               this.gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorstage_Z_SetNull( );
               this.gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorgrade_Z_SetNull( );
            }
            gxTv_SdtBR_Pathology_Diag_Br_pathology_diagid = value;
            SetDirty("Br_pathology_diagid");
         }

      }

      [  SoapElement( ElementName = "BR_PathologyID" )]
      [  XmlElement( ElementName = "BR_PathologyID"   )]
      public long gxTpr_Br_pathologyid
      {
         get {
            return gxTv_SdtBR_Pathology_Diag_Br_pathologyid ;
         }

         set {
            gxTv_SdtBR_Pathology_Diag_Br_pathologyid_N = 0;
            gxTv_SdtBR_Pathology_Diag_Br_pathologyid = value;
            SetDirty("Br_pathologyid");
         }

      }

      public void gxTv_SdtBR_Pathology_Diag_Br_pathologyid_SetNull( )
      {
         gxTv_SdtBR_Pathology_Diag_Br_pathologyid_N = 1;
         gxTv_SdtBR_Pathology_Diag_Br_pathologyid = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Diag_Br_pathologyid_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_Diag_Loc" )]
      [  XmlElement( ElementName = "BR_Pathology_Diag_Loc"   )]
      public String gxTpr_Br_pathology_diag_loc
      {
         get {
            return gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_loc ;
         }

         set {
            gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_loc_N = 0;
            gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_loc = value;
            SetDirty("Br_pathology_diag_loc");
         }

      }

      public void gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_loc_SetNull( )
      {
         gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_loc_N = 1;
         gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_loc = "";
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_loc_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_Diag_Organ" )]
      [  XmlElement( ElementName = "BR_Pathology_Diag_Organ"   )]
      public String gxTpr_Br_pathology_diag_organ
      {
         get {
            return gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_organ ;
         }

         set {
            gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_organ_N = 0;
            gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_organ = value;
            SetDirty("Br_pathology_diag_organ");
         }

      }

      public void gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_organ_SetNull( )
      {
         gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_organ_N = 1;
         gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_organ = "";
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_organ_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_Diag_TumorType" )]
      [  XmlElement( ElementName = "BR_Pathology_Diag_TumorType"   )]
      public String gxTpr_Br_pathology_diag_tumortype
      {
         get {
            return gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumortype ;
         }

         set {
            gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumortype_N = 0;
            gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumortype = value;
            SetDirty("Br_pathology_diag_tumortype");
         }

      }

      public void gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumortype_SetNull( )
      {
         gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumortype_N = 1;
         gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumortype = "";
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumortype_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_Diag_TumorStage" )]
      [  XmlElement( ElementName = "BR_Pathology_Diag_TumorStage"   )]
      public String gxTpr_Br_pathology_diag_tumorstage
      {
         get {
            return gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorstage ;
         }

         set {
            gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorstage_N = 0;
            gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorstage = value;
            SetDirty("Br_pathology_diag_tumorstage");
         }

      }

      public void gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorstage_SetNull( )
      {
         gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorstage_N = 1;
         gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorstage = "";
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorstage_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_Diag_TumorGrade" )]
      [  XmlElement( ElementName = "BR_Pathology_Diag_TumorGrade"   )]
      public String gxTpr_Br_pathology_diag_tumorgrade
      {
         get {
            return gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorgrade ;
         }

         set {
            gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorgrade_N = 0;
            gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorgrade = value;
            SetDirty("Br_pathology_diag_tumorgrade");
         }

      }

      public void gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorgrade_SetNull( )
      {
         gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorgrade_N = 1;
         gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorgrade = "";
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorgrade_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtBR_Pathology_Diag_Mode ;
         }

         set {
            gxTv_SdtBR_Pathology_Diag_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtBR_Pathology_Diag_Mode_SetNull( )
      {
         gxTv_SdtBR_Pathology_Diag_Mode = "";
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Diag_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtBR_Pathology_Diag_Initialized ;
         }

         set {
            gxTv_SdtBR_Pathology_Diag_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtBR_Pathology_Diag_Initialized_SetNull( )
      {
         gxTv_SdtBR_Pathology_Diag_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Diag_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_DiagID_Z" )]
      [  XmlElement( ElementName = "BR_Pathology_DiagID_Z"   )]
      public long gxTpr_Br_pathology_diagid_Z
      {
         get {
            return gxTv_SdtBR_Pathology_Diag_Br_pathology_diagid_Z ;
         }

         set {
            gxTv_SdtBR_Pathology_Diag_Br_pathology_diagid_Z = value;
            SetDirty("Br_pathology_diagid_Z");
         }

      }

      public void gxTv_SdtBR_Pathology_Diag_Br_pathology_diagid_Z_SetNull( )
      {
         gxTv_SdtBR_Pathology_Diag_Br_pathology_diagid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Diag_Br_pathology_diagid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_PathologyID_Z" )]
      [  XmlElement( ElementName = "BR_PathologyID_Z"   )]
      public long gxTpr_Br_pathologyid_Z
      {
         get {
            return gxTv_SdtBR_Pathology_Diag_Br_pathologyid_Z ;
         }

         set {
            gxTv_SdtBR_Pathology_Diag_Br_pathologyid_Z = value;
            SetDirty("Br_pathologyid_Z");
         }

      }

      public void gxTv_SdtBR_Pathology_Diag_Br_pathologyid_Z_SetNull( )
      {
         gxTv_SdtBR_Pathology_Diag_Br_pathologyid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Diag_Br_pathologyid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_Diag_Loc_Z" )]
      [  XmlElement( ElementName = "BR_Pathology_Diag_Loc_Z"   )]
      public String gxTpr_Br_pathology_diag_loc_Z
      {
         get {
            return gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_loc_Z ;
         }

         set {
            gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_loc_Z = value;
            SetDirty("Br_pathology_diag_loc_Z");
         }

      }

      public void gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_loc_Z_SetNull( )
      {
         gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_loc_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_loc_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_Diag_Organ_Z" )]
      [  XmlElement( ElementName = "BR_Pathology_Diag_Organ_Z"   )]
      public String gxTpr_Br_pathology_diag_organ_Z
      {
         get {
            return gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_organ_Z ;
         }

         set {
            gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_organ_Z = value;
            SetDirty("Br_pathology_diag_organ_Z");
         }

      }

      public void gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_organ_Z_SetNull( )
      {
         gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_organ_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_organ_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_Diag_TumorType_Z" )]
      [  XmlElement( ElementName = "BR_Pathology_Diag_TumorType_Z"   )]
      public String gxTpr_Br_pathology_diag_tumortype_Z
      {
         get {
            return gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumortype_Z ;
         }

         set {
            gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumortype_Z = value;
            SetDirty("Br_pathology_diag_tumortype_Z");
         }

      }

      public void gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumortype_Z_SetNull( )
      {
         gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumortype_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumortype_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_Diag_TumorStage_Z" )]
      [  XmlElement( ElementName = "BR_Pathology_Diag_TumorStage_Z"   )]
      public String gxTpr_Br_pathology_diag_tumorstage_Z
      {
         get {
            return gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorstage_Z ;
         }

         set {
            gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorstage_Z = value;
            SetDirty("Br_pathology_diag_tumorstage_Z");
         }

      }

      public void gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorstage_Z_SetNull( )
      {
         gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorstage_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorstage_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_Diag_TumorGrade_Z" )]
      [  XmlElement( ElementName = "BR_Pathology_Diag_TumorGrade_Z"   )]
      public String gxTpr_Br_pathology_diag_tumorgrade_Z
      {
         get {
            return gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorgrade_Z ;
         }

         set {
            gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorgrade_Z = value;
            SetDirty("Br_pathology_diag_tumorgrade_Z");
         }

      }

      public void gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorgrade_Z_SetNull( )
      {
         gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorgrade_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorgrade_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_PathologyID_N" )]
      [  XmlElement( ElementName = "BR_PathologyID_N"   )]
      public short gxTpr_Br_pathologyid_N
      {
         get {
            return gxTv_SdtBR_Pathology_Diag_Br_pathologyid_N ;
         }

         set {
            gxTv_SdtBR_Pathology_Diag_Br_pathologyid_N = value;
            SetDirty("Br_pathologyid_N");
         }

      }

      public void gxTv_SdtBR_Pathology_Diag_Br_pathologyid_N_SetNull( )
      {
         gxTv_SdtBR_Pathology_Diag_Br_pathologyid_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Diag_Br_pathologyid_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_Diag_Loc_N" )]
      [  XmlElement( ElementName = "BR_Pathology_Diag_Loc_N"   )]
      public short gxTpr_Br_pathology_diag_loc_N
      {
         get {
            return gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_loc_N ;
         }

         set {
            gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_loc_N = value;
            SetDirty("Br_pathology_diag_loc_N");
         }

      }

      public void gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_loc_N_SetNull( )
      {
         gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_loc_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_loc_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_Diag_Organ_N" )]
      [  XmlElement( ElementName = "BR_Pathology_Diag_Organ_N"   )]
      public short gxTpr_Br_pathology_diag_organ_N
      {
         get {
            return gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_organ_N ;
         }

         set {
            gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_organ_N = value;
            SetDirty("Br_pathology_diag_organ_N");
         }

      }

      public void gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_organ_N_SetNull( )
      {
         gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_organ_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_organ_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_Diag_TumorType_N" )]
      [  XmlElement( ElementName = "BR_Pathology_Diag_TumorType_N"   )]
      public short gxTpr_Br_pathology_diag_tumortype_N
      {
         get {
            return gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumortype_N ;
         }

         set {
            gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumortype_N = value;
            SetDirty("Br_pathology_diag_tumortype_N");
         }

      }

      public void gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumortype_N_SetNull( )
      {
         gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumortype_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumortype_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_Diag_TumorStage_N" )]
      [  XmlElement( ElementName = "BR_Pathology_Diag_TumorStage_N"   )]
      public short gxTpr_Br_pathology_diag_tumorstage_N
      {
         get {
            return gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorstage_N ;
         }

         set {
            gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorstage_N = value;
            SetDirty("Br_pathology_diag_tumorstage_N");
         }

      }

      public void gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorstage_N_SetNull( )
      {
         gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorstage_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorstage_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_Diag_TumorGrade_N" )]
      [  XmlElement( ElementName = "BR_Pathology_Diag_TumorGrade_N"   )]
      public short gxTpr_Br_pathology_diag_tumorgrade_N
      {
         get {
            return gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorgrade_N ;
         }

         set {
            gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorgrade_N = value;
            SetDirty("Br_pathology_diag_tumorgrade_N");
         }

      }

      public void gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorgrade_N_SetNull( )
      {
         gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorgrade_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorgrade_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_loc = "";
         gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_organ = "";
         gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumortype = "";
         gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorstage = "";
         gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorgrade = "";
         gxTv_SdtBR_Pathology_Diag_Mode = "";
         gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_loc_Z = "";
         gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_organ_Z = "";
         gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumortype_Z = "";
         gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorstage_Z = "";
         gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorgrade_Z = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "br_pathology_diag", "GeneXus.Programs.br_pathology_diag_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtBR_Pathology_Diag_Initialized ;
      private short gxTv_SdtBR_Pathology_Diag_Br_pathologyid_N ;
      private short gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_loc_N ;
      private short gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_organ_N ;
      private short gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumortype_N ;
      private short gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorstage_N ;
      private short gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorgrade_N ;
      private long gxTv_SdtBR_Pathology_Diag_Br_pathology_diagid ;
      private long gxTv_SdtBR_Pathology_Diag_Br_pathologyid ;
      private long gxTv_SdtBR_Pathology_Diag_Br_pathology_diagid_Z ;
      private long gxTv_SdtBR_Pathology_Diag_Br_pathologyid_Z ;
      private String gxTv_SdtBR_Pathology_Diag_Mode ;
      private String gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_loc ;
      private String gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_organ ;
      private String gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumortype ;
      private String gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorstage ;
      private String gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorgrade ;
      private String gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_loc_Z ;
      private String gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_organ_Z ;
      private String gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumortype_Z ;
      private String gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorstage_Z ;
      private String gxTv_SdtBR_Pathology_Diag_Br_pathology_diag_tumorgrade_Z ;
   }

   [DataContract(Name = @"BR_Pathology_Diag", Namespace = "DataAnalysisPlatform")]
   public class SdtBR_Pathology_Diag_RESTInterface : GxGenericCollectionItem<SdtBR_Pathology_Diag>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtBR_Pathology_Diag_RESTInterface( ) : base()
      {
      }

      public SdtBR_Pathology_Diag_RESTInterface( SdtBR_Pathology_Diag psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "BR_Pathology_DiagID" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Br_pathology_diagid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Br_pathology_diagid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Br_pathology_diagid = (long)(NumberUtil.Val( value, "."));
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

      [DataMember( Name = "BR_Pathology_Diag_Loc" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_Br_pathology_diag_loc
      {
         get {
            return sdt.gxTpr_Br_pathology_diag_loc ;
         }

         set {
            sdt.gxTpr_Br_pathology_diag_loc = value;
         }

      }

      [DataMember( Name = "BR_Pathology_Diag_Organ" , Order = 3 )]
      [GxSeudo()]
      public String gxTpr_Br_pathology_diag_organ
      {
         get {
            return sdt.gxTpr_Br_pathology_diag_organ ;
         }

         set {
            sdt.gxTpr_Br_pathology_diag_organ = value;
         }

      }

      [DataMember( Name = "BR_Pathology_Diag_TumorType" , Order = 4 )]
      [GxSeudo()]
      public String gxTpr_Br_pathology_diag_tumortype
      {
         get {
            return sdt.gxTpr_Br_pathology_diag_tumortype ;
         }

         set {
            sdt.gxTpr_Br_pathology_diag_tumortype = value;
         }

      }

      [DataMember( Name = "BR_Pathology_Diag_TumorStage" , Order = 5 )]
      [GxSeudo()]
      public String gxTpr_Br_pathology_diag_tumorstage
      {
         get {
            return sdt.gxTpr_Br_pathology_diag_tumorstage ;
         }

         set {
            sdt.gxTpr_Br_pathology_diag_tumorstage = value;
         }

      }

      [DataMember( Name = "BR_Pathology_Diag_TumorGrade" , Order = 6 )]
      [GxSeudo()]
      public String gxTpr_Br_pathology_diag_tumorgrade
      {
         get {
            return sdt.gxTpr_Br_pathology_diag_tumorgrade ;
         }

         set {
            sdt.gxTpr_Br_pathology_diag_tumorgrade = value;
         }

      }

      public SdtBR_Pathology_Diag sdt
      {
         get {
            return (SdtBR_Pathology_Diag)Sdt ;
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
            sdt = new SdtBR_Pathology_Diag() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 7 )]
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
