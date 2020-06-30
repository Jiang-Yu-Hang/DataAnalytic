/*
               File: type_SdtBR_Scheme
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:38:39.34
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
   [XmlRoot(ElementName = "BR_Scheme" )]
   [XmlType(TypeName =  "BR_Scheme" , Namespace = "DataAnalysisPlatform" )]
   [Serializable]
   public class SdtBR_Scheme : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtBR_Scheme( )
      {
      }

      public SdtBR_Scheme( IGxContext context )
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

      public void Load( long AV327BR_SchemeID )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(long)AV327BR_SchemeID});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"BR_SchemeID", typeof(long)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "BR_Scheme");
         metadata.Set("BT", "BR_Scheme");
         metadata.Set("PK", "[ \"BR_SchemeID\" ]");
         metadata.Set("PKAssigned", "[ \"BR_SchemeID\" ]");
         metadata.Set("FKList", "[ { \"FK\":[ \"BR_EncounterID\" ],\"FKMap\":[  ] } ]");
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
         state.Add("gxTpr_Br_schemeid_Z");
         state.Add("gxTpr_Br_encounterid_Z");
         state.Add("gxTpr_Br_scheme_chem_regimens_Z");
         state.Add("gxTpr_Br_scheme_therapy_line_Z");
         state.Add("gxTpr_Br_scheme_therapy_line_code_Z");
         state.Add("gxTpr_Br_scheme_chem_cycle_Z_double");
         state.Add("gxTpr_Br_scheme_chem_detail_Z");
         state.Add("gxTpr_Br_schemeid_N");
         state.Add("gxTpr_Br_scheme_chem_regimens_N");
         state.Add("gxTpr_Br_scheme_therapy_line_N");
         state.Add("gxTpr_Br_scheme_therapy_line_code_N");
         state.Add("gxTpr_Br_scheme_chem_cycle_N");
         state.Add("gxTpr_Br_scheme_chem_detail_N");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtBR_Scheme sdt ;
         sdt = (SdtBR_Scheme)(source);
         gxTv_SdtBR_Scheme_Br_schemeid = sdt.gxTv_SdtBR_Scheme_Br_schemeid ;
         gxTv_SdtBR_Scheme_Br_encounterid = sdt.gxTv_SdtBR_Scheme_Br_encounterid ;
         gxTv_SdtBR_Scheme_Br_scheme_chem_regimens = sdt.gxTv_SdtBR_Scheme_Br_scheme_chem_regimens ;
         gxTv_SdtBR_Scheme_Br_scheme_therapy_line = sdt.gxTv_SdtBR_Scheme_Br_scheme_therapy_line ;
         gxTv_SdtBR_Scheme_Br_scheme_therapy_line_code = sdt.gxTv_SdtBR_Scheme_Br_scheme_therapy_line_code ;
         gxTv_SdtBR_Scheme_Br_scheme_chem_cycle = sdt.gxTv_SdtBR_Scheme_Br_scheme_chem_cycle ;
         gxTv_SdtBR_Scheme_Br_scheme_chem_detail = sdt.gxTv_SdtBR_Scheme_Br_scheme_chem_detail ;
         gxTv_SdtBR_Scheme_Mode = sdt.gxTv_SdtBR_Scheme_Mode ;
         gxTv_SdtBR_Scheme_Initialized = sdt.gxTv_SdtBR_Scheme_Initialized ;
         gxTv_SdtBR_Scheme_Br_schemeid_Z = sdt.gxTv_SdtBR_Scheme_Br_schemeid_Z ;
         gxTv_SdtBR_Scheme_Br_encounterid_Z = sdt.gxTv_SdtBR_Scheme_Br_encounterid_Z ;
         gxTv_SdtBR_Scheme_Br_scheme_chem_regimens_Z = sdt.gxTv_SdtBR_Scheme_Br_scheme_chem_regimens_Z ;
         gxTv_SdtBR_Scheme_Br_scheme_therapy_line_Z = sdt.gxTv_SdtBR_Scheme_Br_scheme_therapy_line_Z ;
         gxTv_SdtBR_Scheme_Br_scheme_therapy_line_code_Z = sdt.gxTv_SdtBR_Scheme_Br_scheme_therapy_line_code_Z ;
         gxTv_SdtBR_Scheme_Br_scheme_chem_cycle_Z = sdt.gxTv_SdtBR_Scheme_Br_scheme_chem_cycle_Z ;
         gxTv_SdtBR_Scheme_Br_scheme_chem_detail_Z = sdt.gxTv_SdtBR_Scheme_Br_scheme_chem_detail_Z ;
         gxTv_SdtBR_Scheme_Br_schemeid_N = sdt.gxTv_SdtBR_Scheme_Br_schemeid_N ;
         gxTv_SdtBR_Scheme_Br_scheme_chem_regimens_N = sdt.gxTv_SdtBR_Scheme_Br_scheme_chem_regimens_N ;
         gxTv_SdtBR_Scheme_Br_scheme_therapy_line_N = sdt.gxTv_SdtBR_Scheme_Br_scheme_therapy_line_N ;
         gxTv_SdtBR_Scheme_Br_scheme_therapy_line_code_N = sdt.gxTv_SdtBR_Scheme_Br_scheme_therapy_line_code_N ;
         gxTv_SdtBR_Scheme_Br_scheme_chem_cycle_N = sdt.gxTv_SdtBR_Scheme_Br_scheme_chem_cycle_N ;
         gxTv_SdtBR_Scheme_Br_scheme_chem_detail_N = sdt.gxTv_SdtBR_Scheme_Br_scheme_chem_detail_N ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("BR_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Scheme_Br_schemeid), 18, 0)), false);
         AddObjectProperty("BR_SchemeID_N", gxTv_SdtBR_Scheme_Br_schemeid_N, false);
         AddObjectProperty("BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Scheme_Br_encounterid), 18, 0)), false);
         AddObjectProperty("BR_Scheme_Chem_Regimens", gxTv_SdtBR_Scheme_Br_scheme_chem_regimens, false);
         AddObjectProperty("BR_Scheme_Chem_Regimens_N", gxTv_SdtBR_Scheme_Br_scheme_chem_regimens_N, false);
         AddObjectProperty("BR_Scheme_Therapy_Line", gxTv_SdtBR_Scheme_Br_scheme_therapy_line, false);
         AddObjectProperty("BR_Scheme_Therapy_Line_N", gxTv_SdtBR_Scheme_Br_scheme_therapy_line_N, false);
         AddObjectProperty("BR_Scheme_Therapy_Line_Code", gxTv_SdtBR_Scheme_Br_scheme_therapy_line_code, false);
         AddObjectProperty("BR_Scheme_Therapy_Line_Code_N", gxTv_SdtBR_Scheme_Br_scheme_therapy_line_code_N, false);
         AddObjectProperty("BR_Scheme_Chem_Cycle", gxTv_SdtBR_Scheme_Br_scheme_chem_cycle, false);
         AddObjectProperty("BR_Scheme_Chem_Cycle_N", gxTv_SdtBR_Scheme_Br_scheme_chem_cycle_N, false);
         AddObjectProperty("BR_Scheme_Chem_Detail", gxTv_SdtBR_Scheme_Br_scheme_chem_detail, false);
         AddObjectProperty("BR_Scheme_Chem_Detail_N", gxTv_SdtBR_Scheme_Br_scheme_chem_detail_N, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtBR_Scheme_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtBR_Scheme_Initialized, false);
            AddObjectProperty("BR_SchemeID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Scheme_Br_schemeid_Z), 18, 0)), false);
            AddObjectProperty("BR_EncounterID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Scheme_Br_encounterid_Z), 18, 0)), false);
            AddObjectProperty("BR_Scheme_Chem_Regimens_Z", gxTv_SdtBR_Scheme_Br_scheme_chem_regimens_Z, false);
            AddObjectProperty("BR_Scheme_Therapy_Line_Z", gxTv_SdtBR_Scheme_Br_scheme_therapy_line_Z, false);
            AddObjectProperty("BR_Scheme_Therapy_Line_Code_Z", gxTv_SdtBR_Scheme_Br_scheme_therapy_line_code_Z, false);
            AddObjectProperty("BR_Scheme_Chem_Cycle_Z", gxTv_SdtBR_Scheme_Br_scheme_chem_cycle_Z, false);
            AddObjectProperty("BR_Scheme_Chem_Detail_Z", gxTv_SdtBR_Scheme_Br_scheme_chem_detail_Z, false);
            AddObjectProperty("BR_SchemeID_N", gxTv_SdtBR_Scheme_Br_schemeid_N, false);
            AddObjectProperty("BR_Scheme_Chem_Regimens_N", gxTv_SdtBR_Scheme_Br_scheme_chem_regimens_N, false);
            AddObjectProperty("BR_Scheme_Therapy_Line_N", gxTv_SdtBR_Scheme_Br_scheme_therapy_line_N, false);
            AddObjectProperty("BR_Scheme_Therapy_Line_Code_N", gxTv_SdtBR_Scheme_Br_scheme_therapy_line_code_N, false);
            AddObjectProperty("BR_Scheme_Chem_Cycle_N", gxTv_SdtBR_Scheme_Br_scheme_chem_cycle_N, false);
            AddObjectProperty("BR_Scheme_Chem_Detail_N", gxTv_SdtBR_Scheme_Br_scheme_chem_detail_N, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtBR_Scheme sdt )
      {
         if ( sdt.IsDirty("BR_SchemeID") )
         {
            gxTv_SdtBR_Scheme_Br_schemeid = sdt.gxTv_SdtBR_Scheme_Br_schemeid ;
         }
         if ( sdt.IsDirty("BR_EncounterID") )
         {
            gxTv_SdtBR_Scheme_Br_encounterid = sdt.gxTv_SdtBR_Scheme_Br_encounterid ;
         }
         if ( sdt.IsDirty("BR_Scheme_Chem_Regimens") )
         {
            gxTv_SdtBR_Scheme_Br_scheme_chem_regimens = sdt.gxTv_SdtBR_Scheme_Br_scheme_chem_regimens ;
         }
         if ( sdt.IsDirty("BR_Scheme_Therapy_Line") )
         {
            gxTv_SdtBR_Scheme_Br_scheme_therapy_line = sdt.gxTv_SdtBR_Scheme_Br_scheme_therapy_line ;
         }
         if ( sdt.IsDirty("BR_Scheme_Therapy_Line_Code") )
         {
            gxTv_SdtBR_Scheme_Br_scheme_therapy_line_code = sdt.gxTv_SdtBR_Scheme_Br_scheme_therapy_line_code ;
         }
         if ( sdt.IsDirty("BR_Scheme_Chem_Cycle") )
         {
            gxTv_SdtBR_Scheme_Br_scheme_chem_cycle = sdt.gxTv_SdtBR_Scheme_Br_scheme_chem_cycle ;
         }
         if ( sdt.IsDirty("BR_Scheme_Chem_Detail") )
         {
            gxTv_SdtBR_Scheme_Br_scheme_chem_detail = sdt.gxTv_SdtBR_Scheme_Br_scheme_chem_detail ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "BR_SchemeID" )]
      [  XmlElement( ElementName = "BR_SchemeID"   )]
      public long gxTpr_Br_schemeid
      {
         get {
            return gxTv_SdtBR_Scheme_Br_schemeid ;
         }

         set {
            if ( gxTv_SdtBR_Scheme_Br_schemeid != value )
            {
               gxTv_SdtBR_Scheme_Mode = "INS";
               this.gxTv_SdtBR_Scheme_Br_schemeid_Z_SetNull( );
               this.gxTv_SdtBR_Scheme_Br_encounterid_Z_SetNull( );
               this.gxTv_SdtBR_Scheme_Br_scheme_chem_regimens_Z_SetNull( );
               this.gxTv_SdtBR_Scheme_Br_scheme_therapy_line_Z_SetNull( );
               this.gxTv_SdtBR_Scheme_Br_scheme_therapy_line_code_Z_SetNull( );
               this.gxTv_SdtBR_Scheme_Br_scheme_chem_cycle_Z_SetNull( );
               this.gxTv_SdtBR_Scheme_Br_scheme_chem_detail_Z_SetNull( );
            }
            gxTv_SdtBR_Scheme_Br_schemeid = value;
            SetDirty("Br_schemeid");
         }

      }

      [  SoapElement( ElementName = "BR_EncounterID" )]
      [  XmlElement( ElementName = "BR_EncounterID"   )]
      public long gxTpr_Br_encounterid
      {
         get {
            return gxTv_SdtBR_Scheme_Br_encounterid ;
         }

         set {
            gxTv_SdtBR_Scheme_Br_encounterid = value;
            SetDirty("Br_encounterid");
         }

      }

      [  SoapElement( ElementName = "BR_Scheme_Chem_Regimens" )]
      [  XmlElement( ElementName = "BR_Scheme_Chem_Regimens"   )]
      public String gxTpr_Br_scheme_chem_regimens
      {
         get {
            return gxTv_SdtBR_Scheme_Br_scheme_chem_regimens ;
         }

         set {
            gxTv_SdtBR_Scheme_Br_scheme_chem_regimens_N = 0;
            gxTv_SdtBR_Scheme_Br_scheme_chem_regimens = value;
            SetDirty("Br_scheme_chem_regimens");
         }

      }

      public void gxTv_SdtBR_Scheme_Br_scheme_chem_regimens_SetNull( )
      {
         gxTv_SdtBR_Scheme_Br_scheme_chem_regimens_N = 1;
         gxTv_SdtBR_Scheme_Br_scheme_chem_regimens = "";
         return  ;
      }

      public bool gxTv_SdtBR_Scheme_Br_scheme_chem_regimens_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Scheme_Therapy_Line" )]
      [  XmlElement( ElementName = "BR_Scheme_Therapy_Line"   )]
      public String gxTpr_Br_scheme_therapy_line
      {
         get {
            return gxTv_SdtBR_Scheme_Br_scheme_therapy_line ;
         }

         set {
            gxTv_SdtBR_Scheme_Br_scheme_therapy_line_N = 0;
            gxTv_SdtBR_Scheme_Br_scheme_therapy_line = value;
            SetDirty("Br_scheme_therapy_line");
         }

      }

      public void gxTv_SdtBR_Scheme_Br_scheme_therapy_line_SetNull( )
      {
         gxTv_SdtBR_Scheme_Br_scheme_therapy_line_N = 1;
         gxTv_SdtBR_Scheme_Br_scheme_therapy_line = "";
         return  ;
      }

      public bool gxTv_SdtBR_Scheme_Br_scheme_therapy_line_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Scheme_Therapy_Line_Code" )]
      [  XmlElement( ElementName = "BR_Scheme_Therapy_Line_Code"   )]
      public String gxTpr_Br_scheme_therapy_line_code
      {
         get {
            return gxTv_SdtBR_Scheme_Br_scheme_therapy_line_code ;
         }

         set {
            gxTv_SdtBR_Scheme_Br_scheme_therapy_line_code_N = 0;
            gxTv_SdtBR_Scheme_Br_scheme_therapy_line_code = value;
            SetDirty("Br_scheme_therapy_line_code");
         }

      }

      public void gxTv_SdtBR_Scheme_Br_scheme_therapy_line_code_SetNull( )
      {
         gxTv_SdtBR_Scheme_Br_scheme_therapy_line_code_N = 1;
         gxTv_SdtBR_Scheme_Br_scheme_therapy_line_code = "";
         return  ;
      }

      public bool gxTv_SdtBR_Scheme_Br_scheme_therapy_line_code_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Scheme_Chem_Cycle" )]
      [  XmlElement( ElementName = "BR_Scheme_Chem_Cycle"   )]
      public double gxTpr_Br_scheme_chem_cycle_double
      {
         get {
            return Convert.ToDouble(gxTv_SdtBR_Scheme_Br_scheme_chem_cycle) ;
         }

         set {
            gxTv_SdtBR_Scheme_Br_scheme_chem_cycle_N = 0;
            gxTv_SdtBR_Scheme_Br_scheme_chem_cycle = (decimal)(Convert.ToDecimal( value));
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public decimal gxTpr_Br_scheme_chem_cycle
      {
         get {
            return gxTv_SdtBR_Scheme_Br_scheme_chem_cycle ;
         }

         set {
            gxTv_SdtBR_Scheme_Br_scheme_chem_cycle_N = 0;
            gxTv_SdtBR_Scheme_Br_scheme_chem_cycle = value;
            SetDirty("Br_scheme_chem_cycle");
         }

      }

      public void gxTv_SdtBR_Scheme_Br_scheme_chem_cycle_SetNull( )
      {
         gxTv_SdtBR_Scheme_Br_scheme_chem_cycle_N = 1;
         gxTv_SdtBR_Scheme_Br_scheme_chem_cycle = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Scheme_Br_scheme_chem_cycle_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Scheme_Chem_Detail" )]
      [  XmlElement( ElementName = "BR_Scheme_Chem_Detail"   )]
      public String gxTpr_Br_scheme_chem_detail
      {
         get {
            return gxTv_SdtBR_Scheme_Br_scheme_chem_detail ;
         }

         set {
            gxTv_SdtBR_Scheme_Br_scheme_chem_detail_N = 0;
            gxTv_SdtBR_Scheme_Br_scheme_chem_detail = value;
            SetDirty("Br_scheme_chem_detail");
         }

      }

      public void gxTv_SdtBR_Scheme_Br_scheme_chem_detail_SetNull( )
      {
         gxTv_SdtBR_Scheme_Br_scheme_chem_detail_N = 1;
         gxTv_SdtBR_Scheme_Br_scheme_chem_detail = "";
         return  ;
      }

      public bool gxTv_SdtBR_Scheme_Br_scheme_chem_detail_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtBR_Scheme_Mode ;
         }

         set {
            gxTv_SdtBR_Scheme_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtBR_Scheme_Mode_SetNull( )
      {
         gxTv_SdtBR_Scheme_Mode = "";
         return  ;
      }

      public bool gxTv_SdtBR_Scheme_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtBR_Scheme_Initialized ;
         }

         set {
            gxTv_SdtBR_Scheme_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtBR_Scheme_Initialized_SetNull( )
      {
         gxTv_SdtBR_Scheme_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Scheme_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_SchemeID_Z" )]
      [  XmlElement( ElementName = "BR_SchemeID_Z"   )]
      public long gxTpr_Br_schemeid_Z
      {
         get {
            return gxTv_SdtBR_Scheme_Br_schemeid_Z ;
         }

         set {
            gxTv_SdtBR_Scheme_Br_schemeid_Z = value;
            SetDirty("Br_schemeid_Z");
         }

      }

      public void gxTv_SdtBR_Scheme_Br_schemeid_Z_SetNull( )
      {
         gxTv_SdtBR_Scheme_Br_schemeid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Scheme_Br_schemeid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_EncounterID_Z" )]
      [  XmlElement( ElementName = "BR_EncounterID_Z"   )]
      public long gxTpr_Br_encounterid_Z
      {
         get {
            return gxTv_SdtBR_Scheme_Br_encounterid_Z ;
         }

         set {
            gxTv_SdtBR_Scheme_Br_encounterid_Z = value;
            SetDirty("Br_encounterid_Z");
         }

      }

      public void gxTv_SdtBR_Scheme_Br_encounterid_Z_SetNull( )
      {
         gxTv_SdtBR_Scheme_Br_encounterid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Scheme_Br_encounterid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Scheme_Chem_Regimens_Z" )]
      [  XmlElement( ElementName = "BR_Scheme_Chem_Regimens_Z"   )]
      public String gxTpr_Br_scheme_chem_regimens_Z
      {
         get {
            return gxTv_SdtBR_Scheme_Br_scheme_chem_regimens_Z ;
         }

         set {
            gxTv_SdtBR_Scheme_Br_scheme_chem_regimens_Z = value;
            SetDirty("Br_scheme_chem_regimens_Z");
         }

      }

      public void gxTv_SdtBR_Scheme_Br_scheme_chem_regimens_Z_SetNull( )
      {
         gxTv_SdtBR_Scheme_Br_scheme_chem_regimens_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Scheme_Br_scheme_chem_regimens_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Scheme_Therapy_Line_Z" )]
      [  XmlElement( ElementName = "BR_Scheme_Therapy_Line_Z"   )]
      public String gxTpr_Br_scheme_therapy_line_Z
      {
         get {
            return gxTv_SdtBR_Scheme_Br_scheme_therapy_line_Z ;
         }

         set {
            gxTv_SdtBR_Scheme_Br_scheme_therapy_line_Z = value;
            SetDirty("Br_scheme_therapy_line_Z");
         }

      }

      public void gxTv_SdtBR_Scheme_Br_scheme_therapy_line_Z_SetNull( )
      {
         gxTv_SdtBR_Scheme_Br_scheme_therapy_line_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Scheme_Br_scheme_therapy_line_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Scheme_Therapy_Line_Code_Z" )]
      [  XmlElement( ElementName = "BR_Scheme_Therapy_Line_Code_Z"   )]
      public String gxTpr_Br_scheme_therapy_line_code_Z
      {
         get {
            return gxTv_SdtBR_Scheme_Br_scheme_therapy_line_code_Z ;
         }

         set {
            gxTv_SdtBR_Scheme_Br_scheme_therapy_line_code_Z = value;
            SetDirty("Br_scheme_therapy_line_code_Z");
         }

      }

      public void gxTv_SdtBR_Scheme_Br_scheme_therapy_line_code_Z_SetNull( )
      {
         gxTv_SdtBR_Scheme_Br_scheme_therapy_line_code_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Scheme_Br_scheme_therapy_line_code_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Scheme_Chem_Cycle_Z" )]
      [  XmlElement( ElementName = "BR_Scheme_Chem_Cycle_Z"   )]
      public double gxTpr_Br_scheme_chem_cycle_Z_double
      {
         get {
            return Convert.ToDouble(gxTv_SdtBR_Scheme_Br_scheme_chem_cycle_Z) ;
         }

         set {
            gxTv_SdtBR_Scheme_Br_scheme_chem_cycle_Z = (decimal)(Convert.ToDecimal( value));
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public decimal gxTpr_Br_scheme_chem_cycle_Z
      {
         get {
            return gxTv_SdtBR_Scheme_Br_scheme_chem_cycle_Z ;
         }

         set {
            gxTv_SdtBR_Scheme_Br_scheme_chem_cycle_Z = value;
            SetDirty("Br_scheme_chem_cycle_Z");
         }

      }

      public void gxTv_SdtBR_Scheme_Br_scheme_chem_cycle_Z_SetNull( )
      {
         gxTv_SdtBR_Scheme_Br_scheme_chem_cycle_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Scheme_Br_scheme_chem_cycle_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Scheme_Chem_Detail_Z" )]
      [  XmlElement( ElementName = "BR_Scheme_Chem_Detail_Z"   )]
      public String gxTpr_Br_scheme_chem_detail_Z
      {
         get {
            return gxTv_SdtBR_Scheme_Br_scheme_chem_detail_Z ;
         }

         set {
            gxTv_SdtBR_Scheme_Br_scheme_chem_detail_Z = value;
            SetDirty("Br_scheme_chem_detail_Z");
         }

      }

      public void gxTv_SdtBR_Scheme_Br_scheme_chem_detail_Z_SetNull( )
      {
         gxTv_SdtBR_Scheme_Br_scheme_chem_detail_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Scheme_Br_scheme_chem_detail_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_SchemeID_N" )]
      [  XmlElement( ElementName = "BR_SchemeID_N"   )]
      public short gxTpr_Br_schemeid_N
      {
         get {
            return gxTv_SdtBR_Scheme_Br_schemeid_N ;
         }

         set {
            gxTv_SdtBR_Scheme_Br_schemeid_N = value;
            SetDirty("Br_schemeid_N");
         }

      }

      public void gxTv_SdtBR_Scheme_Br_schemeid_N_SetNull( )
      {
         gxTv_SdtBR_Scheme_Br_schemeid_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Scheme_Br_schemeid_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Scheme_Chem_Regimens_N" )]
      [  XmlElement( ElementName = "BR_Scheme_Chem_Regimens_N"   )]
      public short gxTpr_Br_scheme_chem_regimens_N
      {
         get {
            return gxTv_SdtBR_Scheme_Br_scheme_chem_regimens_N ;
         }

         set {
            gxTv_SdtBR_Scheme_Br_scheme_chem_regimens_N = value;
            SetDirty("Br_scheme_chem_regimens_N");
         }

      }

      public void gxTv_SdtBR_Scheme_Br_scheme_chem_regimens_N_SetNull( )
      {
         gxTv_SdtBR_Scheme_Br_scheme_chem_regimens_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Scheme_Br_scheme_chem_regimens_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Scheme_Therapy_Line_N" )]
      [  XmlElement( ElementName = "BR_Scheme_Therapy_Line_N"   )]
      public short gxTpr_Br_scheme_therapy_line_N
      {
         get {
            return gxTv_SdtBR_Scheme_Br_scheme_therapy_line_N ;
         }

         set {
            gxTv_SdtBR_Scheme_Br_scheme_therapy_line_N = value;
            SetDirty("Br_scheme_therapy_line_N");
         }

      }

      public void gxTv_SdtBR_Scheme_Br_scheme_therapy_line_N_SetNull( )
      {
         gxTv_SdtBR_Scheme_Br_scheme_therapy_line_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Scheme_Br_scheme_therapy_line_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Scheme_Therapy_Line_Code_N" )]
      [  XmlElement( ElementName = "BR_Scheme_Therapy_Line_Code_N"   )]
      public short gxTpr_Br_scheme_therapy_line_code_N
      {
         get {
            return gxTv_SdtBR_Scheme_Br_scheme_therapy_line_code_N ;
         }

         set {
            gxTv_SdtBR_Scheme_Br_scheme_therapy_line_code_N = value;
            SetDirty("Br_scheme_therapy_line_code_N");
         }

      }

      public void gxTv_SdtBR_Scheme_Br_scheme_therapy_line_code_N_SetNull( )
      {
         gxTv_SdtBR_Scheme_Br_scheme_therapy_line_code_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Scheme_Br_scheme_therapy_line_code_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Scheme_Chem_Cycle_N" )]
      [  XmlElement( ElementName = "BR_Scheme_Chem_Cycle_N"   )]
      public short gxTpr_Br_scheme_chem_cycle_N
      {
         get {
            return gxTv_SdtBR_Scheme_Br_scheme_chem_cycle_N ;
         }

         set {
            gxTv_SdtBR_Scheme_Br_scheme_chem_cycle_N = value;
            SetDirty("Br_scheme_chem_cycle_N");
         }

      }

      public void gxTv_SdtBR_Scheme_Br_scheme_chem_cycle_N_SetNull( )
      {
         gxTv_SdtBR_Scheme_Br_scheme_chem_cycle_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Scheme_Br_scheme_chem_cycle_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Scheme_Chem_Detail_N" )]
      [  XmlElement( ElementName = "BR_Scheme_Chem_Detail_N"   )]
      public short gxTpr_Br_scheme_chem_detail_N
      {
         get {
            return gxTv_SdtBR_Scheme_Br_scheme_chem_detail_N ;
         }

         set {
            gxTv_SdtBR_Scheme_Br_scheme_chem_detail_N = value;
            SetDirty("Br_scheme_chem_detail_N");
         }

      }

      public void gxTv_SdtBR_Scheme_Br_scheme_chem_detail_N_SetNull( )
      {
         gxTv_SdtBR_Scheme_Br_scheme_chem_detail_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Scheme_Br_scheme_chem_detail_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtBR_Scheme_Br_scheme_chem_regimens = "";
         gxTv_SdtBR_Scheme_Br_scheme_therapy_line = "";
         gxTv_SdtBR_Scheme_Br_scheme_therapy_line_code = "";
         gxTv_SdtBR_Scheme_Br_scheme_chem_detail = "";
         gxTv_SdtBR_Scheme_Mode = "";
         gxTv_SdtBR_Scheme_Br_scheme_chem_regimens_Z = "";
         gxTv_SdtBR_Scheme_Br_scheme_therapy_line_Z = "";
         gxTv_SdtBR_Scheme_Br_scheme_therapy_line_code_Z = "";
         gxTv_SdtBR_Scheme_Br_scheme_chem_detail_Z = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "br_scheme", "GeneXus.Programs.br_scheme_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtBR_Scheme_Initialized ;
      private short gxTv_SdtBR_Scheme_Br_schemeid_N ;
      private short gxTv_SdtBR_Scheme_Br_scheme_chem_regimens_N ;
      private short gxTv_SdtBR_Scheme_Br_scheme_therapy_line_N ;
      private short gxTv_SdtBR_Scheme_Br_scheme_therapy_line_code_N ;
      private short gxTv_SdtBR_Scheme_Br_scheme_chem_cycle_N ;
      private short gxTv_SdtBR_Scheme_Br_scheme_chem_detail_N ;
      private long gxTv_SdtBR_Scheme_Br_schemeid ;
      private long gxTv_SdtBR_Scheme_Br_encounterid ;
      private long gxTv_SdtBR_Scheme_Br_schemeid_Z ;
      private long gxTv_SdtBR_Scheme_Br_encounterid_Z ;
      private decimal gxTv_SdtBR_Scheme_Br_scheme_chem_cycle ;
      private decimal gxTv_SdtBR_Scheme_Br_scheme_chem_cycle_Z ;
      private String gxTv_SdtBR_Scheme_Mode ;
      private String gxTv_SdtBR_Scheme_Br_scheme_chem_regimens ;
      private String gxTv_SdtBR_Scheme_Br_scheme_therapy_line ;
      private String gxTv_SdtBR_Scheme_Br_scheme_therapy_line_code ;
      private String gxTv_SdtBR_Scheme_Br_scheme_chem_detail ;
      private String gxTv_SdtBR_Scheme_Br_scheme_chem_regimens_Z ;
      private String gxTv_SdtBR_Scheme_Br_scheme_therapy_line_Z ;
      private String gxTv_SdtBR_Scheme_Br_scheme_therapy_line_code_Z ;
      private String gxTv_SdtBR_Scheme_Br_scheme_chem_detail_Z ;
   }

   [DataContract(Name = @"BR_Scheme", Namespace = "DataAnalysisPlatform")]
   public class SdtBR_Scheme_RESTInterface : GxGenericCollectionItem<SdtBR_Scheme>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtBR_Scheme_RESTInterface( ) : base()
      {
      }

      public SdtBR_Scheme_RESTInterface( SdtBR_Scheme psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "BR_SchemeID" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Br_schemeid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Br_schemeid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Br_schemeid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "BR_EncounterID" , Order = 1 )]
      [GxSeudo()]
      public String gxTpr_Br_encounterid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Br_encounterid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Br_encounterid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "BR_Scheme_Chem_Regimens" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_Br_scheme_chem_regimens
      {
         get {
            return sdt.gxTpr_Br_scheme_chem_regimens ;
         }

         set {
            sdt.gxTpr_Br_scheme_chem_regimens = value;
         }

      }

      [DataMember( Name = "BR_Scheme_Therapy_Line" , Order = 3 )]
      [GxSeudo()]
      public String gxTpr_Br_scheme_therapy_line
      {
         get {
            return sdt.gxTpr_Br_scheme_therapy_line ;
         }

         set {
            sdt.gxTpr_Br_scheme_therapy_line = value;
         }

      }

      [DataMember( Name = "BR_Scheme_Therapy_Line_Code" , Order = 4 )]
      [GxSeudo()]
      public String gxTpr_Br_scheme_therapy_line_code
      {
         get {
            return sdt.gxTpr_Br_scheme_therapy_line_code ;
         }

         set {
            sdt.gxTpr_Br_scheme_therapy_line_code = value;
         }

      }

      [DataMember( Name = "BR_Scheme_Chem_Cycle" , Order = 5 )]
      [GxSeudo()]
      public String gxTpr_Br_scheme_chem_cycle
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( sdt.gxTpr_Br_scheme_chem_cycle, 15, 5)) ;
         }

         set {
            sdt.gxTpr_Br_scheme_chem_cycle = NumberUtil.Val( value, ".");
         }

      }

      [DataMember( Name = "BR_Scheme_Chem_Detail" , Order = 6 )]
      [GxSeudo()]
      public String gxTpr_Br_scheme_chem_detail
      {
         get {
            return sdt.gxTpr_Br_scheme_chem_detail ;
         }

         set {
            sdt.gxTpr_Br_scheme_chem_detail = value;
         }

      }

      public SdtBR_Scheme sdt
      {
         get {
            return (SdtBR_Scheme)Sdt ;
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
            sdt = new SdtBR_Scheme() ;
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
