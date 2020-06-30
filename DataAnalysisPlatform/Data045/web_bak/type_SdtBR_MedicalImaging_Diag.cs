/*
               File: type_SdtBR_MedicalImaging_Diag
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:37:38.42
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
   [XmlRoot(ElementName = "BR_MedicalImaging_Diag" )]
   [XmlType(TypeName =  "BR_MedicalImaging_Diag" , Namespace = "DataAnalysisPlatform" )]
   [Serializable]
   public class SdtBR_MedicalImaging_Diag : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtBR_MedicalImaging_Diag( )
      {
      }

      public SdtBR_MedicalImaging_Diag( IGxContext context )
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

      public void Load( long AV270BR_MedicalImaging_DiagID )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(long)AV270BR_MedicalImaging_DiagID});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"BR_MedicalImaging_DiagID", typeof(long)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "BR_MedicalImaging_Diag");
         metadata.Set("BT", "BR_MedicalImaging_Diag");
         metadata.Set("PK", "[ \"BR_MedicalImaging_DiagID\" ]");
         metadata.Set("PKAssigned", "[ \"BR_MedicalImaging_DiagID\" ]");
         metadata.Set("FKList", "[ { \"FK\":[ \"BR_MedicalImagingID\" ],\"FKMap\":[  ] } ]");
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
         state.Add("gxTpr_Br_medicalimaging_diagid_Z");
         state.Add("gxTpr_Br_medicalimagingid_Z");
         state.Add("gxTpr_Br_medicalimaging_diag_loc_Z");
         state.Add("gxTpr_Br_medicalimaging_diag_organ_Z");
         state.Add("gxTpr_Br_medicalimaging_diag_dis_Z");
         state.Add("gxTpr_Br_medicalimaging_diag_no_Z");
         state.Add("gxTpr_Br_medicalimagingid_N");
         state.Add("gxTpr_Br_medicalimaging_diag_loc_N");
         state.Add("gxTpr_Br_medicalimaging_diag_organ_N");
         state.Add("gxTpr_Br_medicalimaging_diag_dis_N");
         state.Add("gxTpr_Br_medicalimaging_diag_no_N");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtBR_MedicalImaging_Diag sdt ;
         sdt = (SdtBR_MedicalImaging_Diag)(source);
         gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diagid = sdt.gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diagid ;
         gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimagingid = sdt.gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimagingid ;
         gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_loc = sdt.gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_loc ;
         gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_organ = sdt.gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_organ ;
         gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_dis = sdt.gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_dis ;
         gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_no = sdt.gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_no ;
         gxTv_SdtBR_MedicalImaging_Diag_Mode = sdt.gxTv_SdtBR_MedicalImaging_Diag_Mode ;
         gxTv_SdtBR_MedicalImaging_Diag_Initialized = sdt.gxTv_SdtBR_MedicalImaging_Diag_Initialized ;
         gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diagid_Z = sdt.gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diagid_Z ;
         gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimagingid_Z = sdt.gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimagingid_Z ;
         gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_loc_Z = sdt.gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_loc_Z ;
         gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_organ_Z = sdt.gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_organ_Z ;
         gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_dis_Z = sdt.gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_dis_Z ;
         gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_no_Z = sdt.gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_no_Z ;
         gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimagingid_N = sdt.gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimagingid_N ;
         gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_loc_N = sdt.gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_loc_N ;
         gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_organ_N = sdt.gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_organ_N ;
         gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_dis_N = sdt.gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_dis_N ;
         gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_no_N = sdt.gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_no_N ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("BR_MedicalImaging_DiagID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diagid), 18, 0)), false);
         AddObjectProperty("BR_MedicalImagingID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimagingid), 18, 0)), false);
         AddObjectProperty("BR_MedicalImagingID_N", gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimagingid_N, false);
         AddObjectProperty("BR_MedicalImaging_Diag_Loc", gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_loc, false);
         AddObjectProperty("BR_MedicalImaging_Diag_Loc_N", gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_loc_N, false);
         AddObjectProperty("BR_MedicalImaging_Diag_Organ", gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_organ, false);
         AddObjectProperty("BR_MedicalImaging_Diag_Organ_N", gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_organ_N, false);
         AddObjectProperty("BR_MedicalImaging_Diag_Dis", gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_dis, false);
         AddObjectProperty("BR_MedicalImaging_Diag_Dis_N", gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_dis_N, false);
         AddObjectProperty("BR_MedicalImaging_Diag_No", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_no), 18, 0)), false);
         AddObjectProperty("BR_MedicalImaging_Diag_No_N", gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_no_N, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtBR_MedicalImaging_Diag_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtBR_MedicalImaging_Diag_Initialized, false);
            AddObjectProperty("BR_MedicalImaging_DiagID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diagid_Z), 18, 0)), false);
            AddObjectProperty("BR_MedicalImagingID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimagingid_Z), 18, 0)), false);
            AddObjectProperty("BR_MedicalImaging_Diag_Loc_Z", gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_loc_Z, false);
            AddObjectProperty("BR_MedicalImaging_Diag_Organ_Z", gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_organ_Z, false);
            AddObjectProperty("BR_MedicalImaging_Diag_Dis_Z", gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_dis_Z, false);
            AddObjectProperty("BR_MedicalImaging_Diag_No_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_no_Z), 18, 0)), false);
            AddObjectProperty("BR_MedicalImagingID_N", gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimagingid_N, false);
            AddObjectProperty("BR_MedicalImaging_Diag_Loc_N", gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_loc_N, false);
            AddObjectProperty("BR_MedicalImaging_Diag_Organ_N", gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_organ_N, false);
            AddObjectProperty("BR_MedicalImaging_Diag_Dis_N", gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_dis_N, false);
            AddObjectProperty("BR_MedicalImaging_Diag_No_N", gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_no_N, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtBR_MedicalImaging_Diag sdt )
      {
         if ( sdt.IsDirty("BR_MedicalImaging_DiagID") )
         {
            gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diagid = sdt.gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diagid ;
         }
         if ( sdt.IsDirty("BR_MedicalImagingID") )
         {
            gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimagingid = sdt.gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimagingid ;
         }
         if ( sdt.IsDirty("BR_MedicalImaging_Diag_Loc") )
         {
            gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_loc = sdt.gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_loc ;
         }
         if ( sdt.IsDirty("BR_MedicalImaging_Diag_Organ") )
         {
            gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_organ = sdt.gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_organ ;
         }
         if ( sdt.IsDirty("BR_MedicalImaging_Diag_Dis") )
         {
            gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_dis = sdt.gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_dis ;
         }
         if ( sdt.IsDirty("BR_MedicalImaging_Diag_No") )
         {
            gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_no = sdt.gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_no ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_DiagID" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_DiagID"   )]
      public long gxTpr_Br_medicalimaging_diagid
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diagid ;
         }

         set {
            if ( gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diagid != value )
            {
               gxTv_SdtBR_MedicalImaging_Diag_Mode = "INS";
               this.gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diagid_Z_SetNull( );
               this.gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimagingid_Z_SetNull( );
               this.gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_loc_Z_SetNull( );
               this.gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_organ_Z_SetNull( );
               this.gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_dis_Z_SetNull( );
               this.gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_no_Z_SetNull( );
            }
            gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diagid = value;
            SetDirty("Br_medicalimaging_diagid");
         }

      }

      [  SoapElement( ElementName = "BR_MedicalImagingID" )]
      [  XmlElement( ElementName = "BR_MedicalImagingID"   )]
      public long gxTpr_Br_medicalimagingid
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimagingid ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimagingid_N = 0;
            gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimagingid = value;
            SetDirty("Br_medicalimagingid");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimagingid_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimagingid_N = 1;
         gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimagingid = 0;
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimagingid_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_Diag_Loc" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_Diag_Loc"   )]
      public String gxTpr_Br_medicalimaging_diag_loc
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_loc ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_loc_N = 0;
            gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_loc = value;
            SetDirty("Br_medicalimaging_diag_loc");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_loc_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_loc_N = 1;
         gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_loc = "";
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_loc_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_Diag_Organ" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_Diag_Organ"   )]
      public String gxTpr_Br_medicalimaging_diag_organ
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_organ ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_organ_N = 0;
            gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_organ = value;
            SetDirty("Br_medicalimaging_diag_organ");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_organ_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_organ_N = 1;
         gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_organ = "";
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_organ_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_Diag_Dis" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_Diag_Dis"   )]
      public String gxTpr_Br_medicalimaging_diag_dis
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_dis ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_dis_N = 0;
            gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_dis = value;
            SetDirty("Br_medicalimaging_diag_dis");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_dis_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_dis_N = 1;
         gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_dis = "";
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_dis_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_Diag_No" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_Diag_No"   )]
      public long gxTpr_Br_medicalimaging_diag_no
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_no ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_no_N = 0;
            gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_no = value;
            SetDirty("Br_medicalimaging_diag_no");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_no_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_no_N = 1;
         gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_no = 0;
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_no_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Diag_Mode ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Diag_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Diag_Mode_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Diag_Mode = "";
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Diag_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Diag_Initialized ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Diag_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Diag_Initialized_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Diag_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Diag_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_DiagID_Z" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_DiagID_Z"   )]
      public long gxTpr_Br_medicalimaging_diagid_Z
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diagid_Z ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diagid_Z = value;
            SetDirty("Br_medicalimaging_diagid_Z");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diagid_Z_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diagid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diagid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImagingID_Z" )]
      [  XmlElement( ElementName = "BR_MedicalImagingID_Z"   )]
      public long gxTpr_Br_medicalimagingid_Z
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimagingid_Z ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimagingid_Z = value;
            SetDirty("Br_medicalimagingid_Z");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimagingid_Z_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimagingid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimagingid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_Diag_Loc_Z" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_Diag_Loc_Z"   )]
      public String gxTpr_Br_medicalimaging_diag_loc_Z
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_loc_Z ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_loc_Z = value;
            SetDirty("Br_medicalimaging_diag_loc_Z");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_loc_Z_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_loc_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_loc_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_Diag_Organ_Z" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_Diag_Organ_Z"   )]
      public String gxTpr_Br_medicalimaging_diag_organ_Z
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_organ_Z ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_organ_Z = value;
            SetDirty("Br_medicalimaging_diag_organ_Z");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_organ_Z_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_organ_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_organ_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_Diag_Dis_Z" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_Diag_Dis_Z"   )]
      public String gxTpr_Br_medicalimaging_diag_dis_Z
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_dis_Z ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_dis_Z = value;
            SetDirty("Br_medicalimaging_diag_dis_Z");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_dis_Z_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_dis_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_dis_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_Diag_No_Z" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_Diag_No_Z"   )]
      public long gxTpr_Br_medicalimaging_diag_no_Z
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_no_Z ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_no_Z = value;
            SetDirty("Br_medicalimaging_diag_no_Z");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_no_Z_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_no_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_no_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImagingID_N" )]
      [  XmlElement( ElementName = "BR_MedicalImagingID_N"   )]
      public short gxTpr_Br_medicalimagingid_N
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimagingid_N ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimagingid_N = value;
            SetDirty("Br_medicalimagingid_N");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimagingid_N_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimagingid_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimagingid_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_Diag_Loc_N" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_Diag_Loc_N"   )]
      public short gxTpr_Br_medicalimaging_diag_loc_N
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_loc_N ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_loc_N = value;
            SetDirty("Br_medicalimaging_diag_loc_N");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_loc_N_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_loc_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_loc_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_Diag_Organ_N" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_Diag_Organ_N"   )]
      public short gxTpr_Br_medicalimaging_diag_organ_N
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_organ_N ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_organ_N = value;
            SetDirty("Br_medicalimaging_diag_organ_N");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_organ_N_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_organ_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_organ_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_Diag_Dis_N" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_Diag_Dis_N"   )]
      public short gxTpr_Br_medicalimaging_diag_dis_N
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_dis_N ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_dis_N = value;
            SetDirty("Br_medicalimaging_diag_dis_N");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_dis_N_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_dis_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_dis_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_Diag_No_N" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_Diag_No_N"   )]
      public short gxTpr_Br_medicalimaging_diag_no_N
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_no_N ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_no_N = value;
            SetDirty("Br_medicalimaging_diag_no_N");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_no_N_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_no_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_no_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_loc = "";
         gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_organ = "";
         gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_dis = "";
         gxTv_SdtBR_MedicalImaging_Diag_Mode = "";
         gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_loc_Z = "";
         gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_organ_Z = "";
         gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_dis_Z = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "br_medicalimaging_diag", "GeneXus.Programs.br_medicalimaging_diag_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtBR_MedicalImaging_Diag_Initialized ;
      private short gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimagingid_N ;
      private short gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_loc_N ;
      private short gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_organ_N ;
      private short gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_dis_N ;
      private short gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_no_N ;
      private long gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diagid ;
      private long gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimagingid ;
      private long gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_no ;
      private long gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diagid_Z ;
      private long gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimagingid_Z ;
      private long gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_no_Z ;
      private String gxTv_SdtBR_MedicalImaging_Diag_Mode ;
      private String gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_loc ;
      private String gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_organ ;
      private String gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_dis ;
      private String gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_loc_Z ;
      private String gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_organ_Z ;
      private String gxTv_SdtBR_MedicalImaging_Diag_Br_medicalimaging_diag_dis_Z ;
   }

   [DataContract(Name = @"BR_MedicalImaging_Diag", Namespace = "DataAnalysisPlatform")]
   public class SdtBR_MedicalImaging_Diag_RESTInterface : GxGenericCollectionItem<SdtBR_MedicalImaging_Diag>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtBR_MedicalImaging_Diag_RESTInterface( ) : base()
      {
      }

      public SdtBR_MedicalImaging_Diag_RESTInterface( SdtBR_MedicalImaging_Diag psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "BR_MedicalImaging_DiagID" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Br_medicalimaging_diagid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Br_medicalimaging_diagid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Br_medicalimaging_diagid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "BR_MedicalImagingID" , Order = 1 )]
      [GxSeudo()]
      public String gxTpr_Br_medicalimagingid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Br_medicalimagingid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Br_medicalimagingid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "BR_MedicalImaging_Diag_Loc" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_Br_medicalimaging_diag_loc
      {
         get {
            return sdt.gxTpr_Br_medicalimaging_diag_loc ;
         }

         set {
            sdt.gxTpr_Br_medicalimaging_diag_loc = value;
         }

      }

      [DataMember( Name = "BR_MedicalImaging_Diag_Organ" , Order = 3 )]
      [GxSeudo()]
      public String gxTpr_Br_medicalimaging_diag_organ
      {
         get {
            return sdt.gxTpr_Br_medicalimaging_diag_organ ;
         }

         set {
            sdt.gxTpr_Br_medicalimaging_diag_organ = value;
         }

      }

      [DataMember( Name = "BR_MedicalImaging_Diag_Dis" , Order = 4 )]
      [GxSeudo()]
      public String gxTpr_Br_medicalimaging_diag_dis
      {
         get {
            return sdt.gxTpr_Br_medicalimaging_diag_dis ;
         }

         set {
            sdt.gxTpr_Br_medicalimaging_diag_dis = value;
         }

      }

      [DataMember( Name = "BR_MedicalImaging_Diag_No" , Order = 5 )]
      [GxSeudo()]
      public String gxTpr_Br_medicalimaging_diag_no
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Br_medicalimaging_diag_no), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Br_medicalimaging_diag_no = (long)(NumberUtil.Val( value, "."));
         }

      }

      public SdtBR_MedicalImaging_Diag sdt
      {
         get {
            return (SdtBR_MedicalImaging_Diag)Sdt ;
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
            sdt = new SdtBR_MedicalImaging_Diag() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 6 )]
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
