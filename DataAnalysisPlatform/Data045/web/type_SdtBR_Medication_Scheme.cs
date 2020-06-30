/*
               File: type_SdtBR_Medication_Scheme
        Description: 药物治疗化疗方案0813弃用
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:8:17.13
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
   [XmlRoot(ElementName = "BR_Medication_Scheme" )]
   [XmlType(TypeName =  "BR_Medication_Scheme" , Namespace = "DataAnalysisPlatform" )]
   [Serializable]
   public class SdtBR_Medication_Scheme : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtBR_Medication_Scheme( )
      {
      }

      public SdtBR_Medication_Scheme( IGxContext context )
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

      public void Load( long AV296BR_Medication_SchemeID )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(long)AV296BR_Medication_SchemeID});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"BR_Medication_SchemeID", typeof(long)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "BR_Medication_Scheme");
         metadata.Set("BT", "BR_Medication_Scheme");
         metadata.Set("PK", "[ \"BR_Medication_SchemeID\" ]");
         metadata.Set("PKAssigned", "[ \"BR_Medication_SchemeID\" ]");
         metadata.Set("FKList", "[ { \"FK\":[ \"BR_MedicationID\" ],\"FKMap\":[  ] } ]");
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
         state.Add("gxTpr_Br_medication_schemeid_Z");
         state.Add("gxTpr_Br_medicationid_Z");
         state.Add("gxTpr_Br_medication_chem_name_Z");
         state.Add("gxTpr_Br_medication_chem_cycle_Z_double");
         state.Add("gxTpr_Br_medication_chem_line_Z");
         state.Add("gxTpr_Br_medication_chem_detail_Z");
         state.Add("gxTpr_Br_medication_schemeid_N");
         state.Add("gxTpr_Br_medicationid_N");
         state.Add("gxTpr_Br_medication_chem_name_N");
         state.Add("gxTpr_Br_medication_chem_cycle_N");
         state.Add("gxTpr_Br_medication_chem_line_N");
         state.Add("gxTpr_Br_medication_chem_detail_N");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtBR_Medication_Scheme sdt ;
         sdt = (SdtBR_Medication_Scheme)(source);
         gxTv_SdtBR_Medication_Scheme_Br_medication_schemeid = sdt.gxTv_SdtBR_Medication_Scheme_Br_medication_schemeid ;
         gxTv_SdtBR_Medication_Scheme_Br_medicationid = sdt.gxTv_SdtBR_Medication_Scheme_Br_medicationid ;
         gxTv_SdtBR_Medication_Scheme_Br_medication_chem_name = sdt.gxTv_SdtBR_Medication_Scheme_Br_medication_chem_name ;
         gxTv_SdtBR_Medication_Scheme_Br_medication_chem_cycle = sdt.gxTv_SdtBR_Medication_Scheme_Br_medication_chem_cycle ;
         gxTv_SdtBR_Medication_Scheme_Br_medication_chem_line = sdt.gxTv_SdtBR_Medication_Scheme_Br_medication_chem_line ;
         gxTv_SdtBR_Medication_Scheme_Br_medication_chem_detail = sdt.gxTv_SdtBR_Medication_Scheme_Br_medication_chem_detail ;
         gxTv_SdtBR_Medication_Scheme_Mode = sdt.gxTv_SdtBR_Medication_Scheme_Mode ;
         gxTv_SdtBR_Medication_Scheme_Initialized = sdt.gxTv_SdtBR_Medication_Scheme_Initialized ;
         gxTv_SdtBR_Medication_Scheme_Br_medication_schemeid_Z = sdt.gxTv_SdtBR_Medication_Scheme_Br_medication_schemeid_Z ;
         gxTv_SdtBR_Medication_Scheme_Br_medicationid_Z = sdt.gxTv_SdtBR_Medication_Scheme_Br_medicationid_Z ;
         gxTv_SdtBR_Medication_Scheme_Br_medication_chem_name_Z = sdt.gxTv_SdtBR_Medication_Scheme_Br_medication_chem_name_Z ;
         gxTv_SdtBR_Medication_Scheme_Br_medication_chem_cycle_Z = sdt.gxTv_SdtBR_Medication_Scheme_Br_medication_chem_cycle_Z ;
         gxTv_SdtBR_Medication_Scheme_Br_medication_chem_line_Z = sdt.gxTv_SdtBR_Medication_Scheme_Br_medication_chem_line_Z ;
         gxTv_SdtBR_Medication_Scheme_Br_medication_chem_detail_Z = sdt.gxTv_SdtBR_Medication_Scheme_Br_medication_chem_detail_Z ;
         gxTv_SdtBR_Medication_Scheme_Br_medication_schemeid_N = sdt.gxTv_SdtBR_Medication_Scheme_Br_medication_schemeid_N ;
         gxTv_SdtBR_Medication_Scheme_Br_medicationid_N = sdt.gxTv_SdtBR_Medication_Scheme_Br_medicationid_N ;
         gxTv_SdtBR_Medication_Scheme_Br_medication_chem_name_N = sdt.gxTv_SdtBR_Medication_Scheme_Br_medication_chem_name_N ;
         gxTv_SdtBR_Medication_Scheme_Br_medication_chem_cycle_N = sdt.gxTv_SdtBR_Medication_Scheme_Br_medication_chem_cycle_N ;
         gxTv_SdtBR_Medication_Scheme_Br_medication_chem_line_N = sdt.gxTv_SdtBR_Medication_Scheme_Br_medication_chem_line_N ;
         gxTv_SdtBR_Medication_Scheme_Br_medication_chem_detail_N = sdt.gxTv_SdtBR_Medication_Scheme_Br_medication_chem_detail_N ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("BR_Medication_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Medication_Scheme_Br_medication_schemeid), 18, 0)), false);
         AddObjectProperty("BR_Medication_SchemeID_N", gxTv_SdtBR_Medication_Scheme_Br_medication_schemeid_N, false);
         AddObjectProperty("BR_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Medication_Scheme_Br_medicationid), 18, 0)), false);
         AddObjectProperty("BR_MedicationID_N", gxTv_SdtBR_Medication_Scheme_Br_medicationid_N, false);
         AddObjectProperty("BR_Medication_Chem_Name", gxTv_SdtBR_Medication_Scheme_Br_medication_chem_name, false);
         AddObjectProperty("BR_Medication_Chem_Name_N", gxTv_SdtBR_Medication_Scheme_Br_medication_chem_name_N, false);
         AddObjectProperty("BR_Medication_Chem_Cycle", gxTv_SdtBR_Medication_Scheme_Br_medication_chem_cycle, false);
         AddObjectProperty("BR_Medication_Chem_Cycle_N", gxTv_SdtBR_Medication_Scheme_Br_medication_chem_cycle_N, false);
         AddObjectProperty("BR_Medication_Chem_Line", gxTv_SdtBR_Medication_Scheme_Br_medication_chem_line, false);
         AddObjectProperty("BR_Medication_Chem_Line_N", gxTv_SdtBR_Medication_Scheme_Br_medication_chem_line_N, false);
         AddObjectProperty("BR_Medication_Chem_Detail", gxTv_SdtBR_Medication_Scheme_Br_medication_chem_detail, false);
         AddObjectProperty("BR_Medication_Chem_Detail_N", gxTv_SdtBR_Medication_Scheme_Br_medication_chem_detail_N, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtBR_Medication_Scheme_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtBR_Medication_Scheme_Initialized, false);
            AddObjectProperty("BR_Medication_SchemeID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Medication_Scheme_Br_medication_schemeid_Z), 18, 0)), false);
            AddObjectProperty("BR_MedicationID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Medication_Scheme_Br_medicationid_Z), 18, 0)), false);
            AddObjectProperty("BR_Medication_Chem_Name_Z", gxTv_SdtBR_Medication_Scheme_Br_medication_chem_name_Z, false);
            AddObjectProperty("BR_Medication_Chem_Cycle_Z", gxTv_SdtBR_Medication_Scheme_Br_medication_chem_cycle_Z, false);
            AddObjectProperty("BR_Medication_Chem_Line_Z", gxTv_SdtBR_Medication_Scheme_Br_medication_chem_line_Z, false);
            AddObjectProperty("BR_Medication_Chem_Detail_Z", gxTv_SdtBR_Medication_Scheme_Br_medication_chem_detail_Z, false);
            AddObjectProperty("BR_Medication_SchemeID_N", gxTv_SdtBR_Medication_Scheme_Br_medication_schemeid_N, false);
            AddObjectProperty("BR_MedicationID_N", gxTv_SdtBR_Medication_Scheme_Br_medicationid_N, false);
            AddObjectProperty("BR_Medication_Chem_Name_N", gxTv_SdtBR_Medication_Scheme_Br_medication_chem_name_N, false);
            AddObjectProperty("BR_Medication_Chem_Cycle_N", gxTv_SdtBR_Medication_Scheme_Br_medication_chem_cycle_N, false);
            AddObjectProperty("BR_Medication_Chem_Line_N", gxTv_SdtBR_Medication_Scheme_Br_medication_chem_line_N, false);
            AddObjectProperty("BR_Medication_Chem_Detail_N", gxTv_SdtBR_Medication_Scheme_Br_medication_chem_detail_N, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtBR_Medication_Scheme sdt )
      {
         if ( sdt.IsDirty("BR_Medication_SchemeID") )
         {
            gxTv_SdtBR_Medication_Scheme_Br_medication_schemeid = sdt.gxTv_SdtBR_Medication_Scheme_Br_medication_schemeid ;
         }
         if ( sdt.IsDirty("BR_MedicationID") )
         {
            gxTv_SdtBR_Medication_Scheme_Br_medicationid = sdt.gxTv_SdtBR_Medication_Scheme_Br_medicationid ;
         }
         if ( sdt.IsDirty("BR_Medication_Chem_Name") )
         {
            gxTv_SdtBR_Medication_Scheme_Br_medication_chem_name = sdt.gxTv_SdtBR_Medication_Scheme_Br_medication_chem_name ;
         }
         if ( sdt.IsDirty("BR_Medication_Chem_Cycle") )
         {
            gxTv_SdtBR_Medication_Scheme_Br_medication_chem_cycle = sdt.gxTv_SdtBR_Medication_Scheme_Br_medication_chem_cycle ;
         }
         if ( sdt.IsDirty("BR_Medication_Chem_Line") )
         {
            gxTv_SdtBR_Medication_Scheme_Br_medication_chem_line = sdt.gxTv_SdtBR_Medication_Scheme_Br_medication_chem_line ;
         }
         if ( sdt.IsDirty("BR_Medication_Chem_Detail") )
         {
            gxTv_SdtBR_Medication_Scheme_Br_medication_chem_detail = sdt.gxTv_SdtBR_Medication_Scheme_Br_medication_chem_detail ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "BR_Medication_SchemeID" )]
      [  XmlElement( ElementName = "BR_Medication_SchemeID"   )]
      public long gxTpr_Br_medication_schemeid
      {
         get {
            return gxTv_SdtBR_Medication_Scheme_Br_medication_schemeid ;
         }

         set {
            if ( gxTv_SdtBR_Medication_Scheme_Br_medication_schemeid != value )
            {
               gxTv_SdtBR_Medication_Scheme_Mode = "INS";
               this.gxTv_SdtBR_Medication_Scheme_Br_medication_schemeid_Z_SetNull( );
               this.gxTv_SdtBR_Medication_Scheme_Br_medicationid_Z_SetNull( );
               this.gxTv_SdtBR_Medication_Scheme_Br_medication_chem_name_Z_SetNull( );
               this.gxTv_SdtBR_Medication_Scheme_Br_medication_chem_cycle_Z_SetNull( );
               this.gxTv_SdtBR_Medication_Scheme_Br_medication_chem_line_Z_SetNull( );
               this.gxTv_SdtBR_Medication_Scheme_Br_medication_chem_detail_Z_SetNull( );
            }
            gxTv_SdtBR_Medication_Scheme_Br_medication_schemeid = value;
            SetDirty("Br_medication_schemeid");
         }

      }

      [  SoapElement( ElementName = "BR_MedicationID" )]
      [  XmlElement( ElementName = "BR_MedicationID"   )]
      public long gxTpr_Br_medicationid
      {
         get {
            return gxTv_SdtBR_Medication_Scheme_Br_medicationid ;
         }

         set {
            gxTv_SdtBR_Medication_Scheme_Br_medicationid_N = 0;
            gxTv_SdtBR_Medication_Scheme_Br_medicationid = value;
            SetDirty("Br_medicationid");
         }

      }

      public void gxTv_SdtBR_Medication_Scheme_Br_medicationid_SetNull( )
      {
         gxTv_SdtBR_Medication_Scheme_Br_medicationid_N = 1;
         gxTv_SdtBR_Medication_Scheme_Br_medicationid = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Scheme_Br_medicationid_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_Chem_Name" )]
      [  XmlElement( ElementName = "BR_Medication_Chem_Name"   )]
      public String gxTpr_Br_medication_chem_name
      {
         get {
            return gxTv_SdtBR_Medication_Scheme_Br_medication_chem_name ;
         }

         set {
            gxTv_SdtBR_Medication_Scheme_Br_medication_chem_name_N = 0;
            gxTv_SdtBR_Medication_Scheme_Br_medication_chem_name = value;
            SetDirty("Br_medication_chem_name");
         }

      }

      public void gxTv_SdtBR_Medication_Scheme_Br_medication_chem_name_SetNull( )
      {
         gxTv_SdtBR_Medication_Scheme_Br_medication_chem_name_N = 1;
         gxTv_SdtBR_Medication_Scheme_Br_medication_chem_name = "";
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Scheme_Br_medication_chem_name_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_Chem_Cycle" )]
      [  XmlElement( ElementName = "BR_Medication_Chem_Cycle"   )]
      public double gxTpr_Br_medication_chem_cycle_double
      {
         get {
            return Convert.ToDouble(gxTv_SdtBR_Medication_Scheme_Br_medication_chem_cycle) ;
         }

         set {
            gxTv_SdtBR_Medication_Scheme_Br_medication_chem_cycle_N = 0;
            gxTv_SdtBR_Medication_Scheme_Br_medication_chem_cycle = (decimal)(Convert.ToDecimal( value));
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public decimal gxTpr_Br_medication_chem_cycle
      {
         get {
            return gxTv_SdtBR_Medication_Scheme_Br_medication_chem_cycle ;
         }

         set {
            gxTv_SdtBR_Medication_Scheme_Br_medication_chem_cycle_N = 0;
            gxTv_SdtBR_Medication_Scheme_Br_medication_chem_cycle = value;
            SetDirty("Br_medication_chem_cycle");
         }

      }

      public void gxTv_SdtBR_Medication_Scheme_Br_medication_chem_cycle_SetNull( )
      {
         gxTv_SdtBR_Medication_Scheme_Br_medication_chem_cycle_N = 1;
         gxTv_SdtBR_Medication_Scheme_Br_medication_chem_cycle = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Scheme_Br_medication_chem_cycle_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_Chem_Line" )]
      [  XmlElement( ElementName = "BR_Medication_Chem_Line"   )]
      public String gxTpr_Br_medication_chem_line
      {
         get {
            return gxTv_SdtBR_Medication_Scheme_Br_medication_chem_line ;
         }

         set {
            gxTv_SdtBR_Medication_Scheme_Br_medication_chem_line_N = 0;
            gxTv_SdtBR_Medication_Scheme_Br_medication_chem_line = value;
            SetDirty("Br_medication_chem_line");
         }

      }

      public void gxTv_SdtBR_Medication_Scheme_Br_medication_chem_line_SetNull( )
      {
         gxTv_SdtBR_Medication_Scheme_Br_medication_chem_line_N = 1;
         gxTv_SdtBR_Medication_Scheme_Br_medication_chem_line = "";
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Scheme_Br_medication_chem_line_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_Chem_Detail" )]
      [  XmlElement( ElementName = "BR_Medication_Chem_Detail"   )]
      public String gxTpr_Br_medication_chem_detail
      {
         get {
            return gxTv_SdtBR_Medication_Scheme_Br_medication_chem_detail ;
         }

         set {
            gxTv_SdtBR_Medication_Scheme_Br_medication_chem_detail_N = 0;
            gxTv_SdtBR_Medication_Scheme_Br_medication_chem_detail = value;
            SetDirty("Br_medication_chem_detail");
         }

      }

      public void gxTv_SdtBR_Medication_Scheme_Br_medication_chem_detail_SetNull( )
      {
         gxTv_SdtBR_Medication_Scheme_Br_medication_chem_detail_N = 1;
         gxTv_SdtBR_Medication_Scheme_Br_medication_chem_detail = "";
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Scheme_Br_medication_chem_detail_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtBR_Medication_Scheme_Mode ;
         }

         set {
            gxTv_SdtBR_Medication_Scheme_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtBR_Medication_Scheme_Mode_SetNull( )
      {
         gxTv_SdtBR_Medication_Scheme_Mode = "";
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Scheme_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtBR_Medication_Scheme_Initialized ;
         }

         set {
            gxTv_SdtBR_Medication_Scheme_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtBR_Medication_Scheme_Initialized_SetNull( )
      {
         gxTv_SdtBR_Medication_Scheme_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Scheme_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_SchemeID_Z" )]
      [  XmlElement( ElementName = "BR_Medication_SchemeID_Z"   )]
      public long gxTpr_Br_medication_schemeid_Z
      {
         get {
            return gxTv_SdtBR_Medication_Scheme_Br_medication_schemeid_Z ;
         }

         set {
            gxTv_SdtBR_Medication_Scheme_Br_medication_schemeid_Z = value;
            SetDirty("Br_medication_schemeid_Z");
         }

      }

      public void gxTv_SdtBR_Medication_Scheme_Br_medication_schemeid_Z_SetNull( )
      {
         gxTv_SdtBR_Medication_Scheme_Br_medication_schemeid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Scheme_Br_medication_schemeid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicationID_Z" )]
      [  XmlElement( ElementName = "BR_MedicationID_Z"   )]
      public long gxTpr_Br_medicationid_Z
      {
         get {
            return gxTv_SdtBR_Medication_Scheme_Br_medicationid_Z ;
         }

         set {
            gxTv_SdtBR_Medication_Scheme_Br_medicationid_Z = value;
            SetDirty("Br_medicationid_Z");
         }

      }

      public void gxTv_SdtBR_Medication_Scheme_Br_medicationid_Z_SetNull( )
      {
         gxTv_SdtBR_Medication_Scheme_Br_medicationid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Scheme_Br_medicationid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_Chem_Name_Z" )]
      [  XmlElement( ElementName = "BR_Medication_Chem_Name_Z"   )]
      public String gxTpr_Br_medication_chem_name_Z
      {
         get {
            return gxTv_SdtBR_Medication_Scheme_Br_medication_chem_name_Z ;
         }

         set {
            gxTv_SdtBR_Medication_Scheme_Br_medication_chem_name_Z = value;
            SetDirty("Br_medication_chem_name_Z");
         }

      }

      public void gxTv_SdtBR_Medication_Scheme_Br_medication_chem_name_Z_SetNull( )
      {
         gxTv_SdtBR_Medication_Scheme_Br_medication_chem_name_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Scheme_Br_medication_chem_name_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_Chem_Cycle_Z" )]
      [  XmlElement( ElementName = "BR_Medication_Chem_Cycle_Z"   )]
      public double gxTpr_Br_medication_chem_cycle_Z_double
      {
         get {
            return Convert.ToDouble(gxTv_SdtBR_Medication_Scheme_Br_medication_chem_cycle_Z) ;
         }

         set {
            gxTv_SdtBR_Medication_Scheme_Br_medication_chem_cycle_Z = (decimal)(Convert.ToDecimal( value));
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public decimal gxTpr_Br_medication_chem_cycle_Z
      {
         get {
            return gxTv_SdtBR_Medication_Scheme_Br_medication_chem_cycle_Z ;
         }

         set {
            gxTv_SdtBR_Medication_Scheme_Br_medication_chem_cycle_Z = value;
            SetDirty("Br_medication_chem_cycle_Z");
         }

      }

      public void gxTv_SdtBR_Medication_Scheme_Br_medication_chem_cycle_Z_SetNull( )
      {
         gxTv_SdtBR_Medication_Scheme_Br_medication_chem_cycle_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Scheme_Br_medication_chem_cycle_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_Chem_Line_Z" )]
      [  XmlElement( ElementName = "BR_Medication_Chem_Line_Z"   )]
      public String gxTpr_Br_medication_chem_line_Z
      {
         get {
            return gxTv_SdtBR_Medication_Scheme_Br_medication_chem_line_Z ;
         }

         set {
            gxTv_SdtBR_Medication_Scheme_Br_medication_chem_line_Z = value;
            SetDirty("Br_medication_chem_line_Z");
         }

      }

      public void gxTv_SdtBR_Medication_Scheme_Br_medication_chem_line_Z_SetNull( )
      {
         gxTv_SdtBR_Medication_Scheme_Br_medication_chem_line_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Scheme_Br_medication_chem_line_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_Chem_Detail_Z" )]
      [  XmlElement( ElementName = "BR_Medication_Chem_Detail_Z"   )]
      public String gxTpr_Br_medication_chem_detail_Z
      {
         get {
            return gxTv_SdtBR_Medication_Scheme_Br_medication_chem_detail_Z ;
         }

         set {
            gxTv_SdtBR_Medication_Scheme_Br_medication_chem_detail_Z = value;
            SetDirty("Br_medication_chem_detail_Z");
         }

      }

      public void gxTv_SdtBR_Medication_Scheme_Br_medication_chem_detail_Z_SetNull( )
      {
         gxTv_SdtBR_Medication_Scheme_Br_medication_chem_detail_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Scheme_Br_medication_chem_detail_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_SchemeID_N" )]
      [  XmlElement( ElementName = "BR_Medication_SchemeID_N"   )]
      public short gxTpr_Br_medication_schemeid_N
      {
         get {
            return gxTv_SdtBR_Medication_Scheme_Br_medication_schemeid_N ;
         }

         set {
            gxTv_SdtBR_Medication_Scheme_Br_medication_schemeid_N = value;
            SetDirty("Br_medication_schemeid_N");
         }

      }

      public void gxTv_SdtBR_Medication_Scheme_Br_medication_schemeid_N_SetNull( )
      {
         gxTv_SdtBR_Medication_Scheme_Br_medication_schemeid_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Scheme_Br_medication_schemeid_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicationID_N" )]
      [  XmlElement( ElementName = "BR_MedicationID_N"   )]
      public short gxTpr_Br_medicationid_N
      {
         get {
            return gxTv_SdtBR_Medication_Scheme_Br_medicationid_N ;
         }

         set {
            gxTv_SdtBR_Medication_Scheme_Br_medicationid_N = value;
            SetDirty("Br_medicationid_N");
         }

      }

      public void gxTv_SdtBR_Medication_Scheme_Br_medicationid_N_SetNull( )
      {
         gxTv_SdtBR_Medication_Scheme_Br_medicationid_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Scheme_Br_medicationid_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_Chem_Name_N" )]
      [  XmlElement( ElementName = "BR_Medication_Chem_Name_N"   )]
      public short gxTpr_Br_medication_chem_name_N
      {
         get {
            return gxTv_SdtBR_Medication_Scheme_Br_medication_chem_name_N ;
         }

         set {
            gxTv_SdtBR_Medication_Scheme_Br_medication_chem_name_N = value;
            SetDirty("Br_medication_chem_name_N");
         }

      }

      public void gxTv_SdtBR_Medication_Scheme_Br_medication_chem_name_N_SetNull( )
      {
         gxTv_SdtBR_Medication_Scheme_Br_medication_chem_name_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Scheme_Br_medication_chem_name_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_Chem_Cycle_N" )]
      [  XmlElement( ElementName = "BR_Medication_Chem_Cycle_N"   )]
      public short gxTpr_Br_medication_chem_cycle_N
      {
         get {
            return gxTv_SdtBR_Medication_Scheme_Br_medication_chem_cycle_N ;
         }

         set {
            gxTv_SdtBR_Medication_Scheme_Br_medication_chem_cycle_N = value;
            SetDirty("Br_medication_chem_cycle_N");
         }

      }

      public void gxTv_SdtBR_Medication_Scheme_Br_medication_chem_cycle_N_SetNull( )
      {
         gxTv_SdtBR_Medication_Scheme_Br_medication_chem_cycle_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Scheme_Br_medication_chem_cycle_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_Chem_Line_N" )]
      [  XmlElement( ElementName = "BR_Medication_Chem_Line_N"   )]
      public short gxTpr_Br_medication_chem_line_N
      {
         get {
            return gxTv_SdtBR_Medication_Scheme_Br_medication_chem_line_N ;
         }

         set {
            gxTv_SdtBR_Medication_Scheme_Br_medication_chem_line_N = value;
            SetDirty("Br_medication_chem_line_N");
         }

      }

      public void gxTv_SdtBR_Medication_Scheme_Br_medication_chem_line_N_SetNull( )
      {
         gxTv_SdtBR_Medication_Scheme_Br_medication_chem_line_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Scheme_Br_medication_chem_line_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_Chem_Detail_N" )]
      [  XmlElement( ElementName = "BR_Medication_Chem_Detail_N"   )]
      public short gxTpr_Br_medication_chem_detail_N
      {
         get {
            return gxTv_SdtBR_Medication_Scheme_Br_medication_chem_detail_N ;
         }

         set {
            gxTv_SdtBR_Medication_Scheme_Br_medication_chem_detail_N = value;
            SetDirty("Br_medication_chem_detail_N");
         }

      }

      public void gxTv_SdtBR_Medication_Scheme_Br_medication_chem_detail_N_SetNull( )
      {
         gxTv_SdtBR_Medication_Scheme_Br_medication_chem_detail_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Scheme_Br_medication_chem_detail_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtBR_Medication_Scheme_Br_medication_chem_name = "";
         gxTv_SdtBR_Medication_Scheme_Br_medication_chem_line = "";
         gxTv_SdtBR_Medication_Scheme_Br_medication_chem_detail = "";
         gxTv_SdtBR_Medication_Scheme_Mode = "";
         gxTv_SdtBR_Medication_Scheme_Br_medication_chem_name_Z = "";
         gxTv_SdtBR_Medication_Scheme_Br_medication_chem_line_Z = "";
         gxTv_SdtBR_Medication_Scheme_Br_medication_chem_detail_Z = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "br_medication_scheme", "GeneXus.Programs.br_medication_scheme_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtBR_Medication_Scheme_Initialized ;
      private short gxTv_SdtBR_Medication_Scheme_Br_medication_schemeid_N ;
      private short gxTv_SdtBR_Medication_Scheme_Br_medicationid_N ;
      private short gxTv_SdtBR_Medication_Scheme_Br_medication_chem_name_N ;
      private short gxTv_SdtBR_Medication_Scheme_Br_medication_chem_cycle_N ;
      private short gxTv_SdtBR_Medication_Scheme_Br_medication_chem_line_N ;
      private short gxTv_SdtBR_Medication_Scheme_Br_medication_chem_detail_N ;
      private long gxTv_SdtBR_Medication_Scheme_Br_medication_schemeid ;
      private long gxTv_SdtBR_Medication_Scheme_Br_medicationid ;
      private long gxTv_SdtBR_Medication_Scheme_Br_medication_schemeid_Z ;
      private long gxTv_SdtBR_Medication_Scheme_Br_medicationid_Z ;
      private decimal gxTv_SdtBR_Medication_Scheme_Br_medication_chem_cycle ;
      private decimal gxTv_SdtBR_Medication_Scheme_Br_medication_chem_cycle_Z ;
      private String gxTv_SdtBR_Medication_Scheme_Mode ;
      private String gxTv_SdtBR_Medication_Scheme_Br_medication_chem_name ;
      private String gxTv_SdtBR_Medication_Scheme_Br_medication_chem_line ;
      private String gxTv_SdtBR_Medication_Scheme_Br_medication_chem_detail ;
      private String gxTv_SdtBR_Medication_Scheme_Br_medication_chem_name_Z ;
      private String gxTv_SdtBR_Medication_Scheme_Br_medication_chem_line_Z ;
      private String gxTv_SdtBR_Medication_Scheme_Br_medication_chem_detail_Z ;
   }

   [DataContract(Name = @"BR_Medication_Scheme", Namespace = "DataAnalysisPlatform")]
   public class SdtBR_Medication_Scheme_RESTInterface : GxGenericCollectionItem<SdtBR_Medication_Scheme>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtBR_Medication_Scheme_RESTInterface( ) : base()
      {
      }

      public SdtBR_Medication_Scheme_RESTInterface( SdtBR_Medication_Scheme psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "BR_Medication_SchemeID" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Br_medication_schemeid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Br_medication_schemeid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Br_medication_schemeid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "BR_MedicationID" , Order = 1 )]
      [GxSeudo()]
      public String gxTpr_Br_medicationid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Br_medicationid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Br_medicationid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "BR_Medication_Chem_Name" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_Br_medication_chem_name
      {
         get {
            return sdt.gxTpr_Br_medication_chem_name ;
         }

         set {
            sdt.gxTpr_Br_medication_chem_name = value;
         }

      }

      [DataMember( Name = "BR_Medication_Chem_Cycle" , Order = 3 )]
      [GxSeudo()]
      public String gxTpr_Br_medication_chem_cycle
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( sdt.gxTpr_Br_medication_chem_cycle, 15, 5)) ;
         }

         set {
            sdt.gxTpr_Br_medication_chem_cycle = NumberUtil.Val( value, ".");
         }

      }

      [DataMember( Name = "BR_Medication_Chem_Line" , Order = 4 )]
      [GxSeudo()]
      public String gxTpr_Br_medication_chem_line
      {
         get {
            return sdt.gxTpr_Br_medication_chem_line ;
         }

         set {
            sdt.gxTpr_Br_medication_chem_line = value;
         }

      }

      [DataMember( Name = "BR_Medication_Chem_Detail" , Order = 5 )]
      [GxSeudo()]
      public String gxTpr_Br_medication_chem_detail
      {
         get {
            return sdt.gxTpr_Br_medication_chem_detail ;
         }

         set {
            sdt.gxTpr_Br_medication_chem_detail = value;
         }

      }

      public SdtBR_Medication_Scheme sdt
      {
         get {
            return (SdtBR_Medication_Scheme)Sdt ;
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
            sdt = new SdtBR_Medication_Scheme() ;
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
