/*
               File: type_SdtBR_Scheme_Medication
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:8:42.84
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
   [XmlRoot(ElementName = "BR_Scheme_Medication" )]
   [XmlType(TypeName =  "BR_Scheme_Medication" , Namespace = "DataAnalysisPlatform" )]
   [Serializable]
   public class SdtBR_Scheme_Medication : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtBR_Scheme_Medication( )
      {
      }

      public SdtBR_Scheme_Medication( IGxContext context )
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

      public void Load( long AV332BR_Scheme_MedicationID )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(long)AV332BR_Scheme_MedicationID});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"BR_Scheme_MedicationID", typeof(long)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "BR_Scheme_Medication");
         metadata.Set("BT", "BR_Scheme_Medication");
         metadata.Set("PK", "[ \"BR_Scheme_MedicationID\" ]");
         metadata.Set("PKAssigned", "[ \"BR_Scheme_MedicationID\" ]");
         metadata.Set("FKList", "[ { \"FK\":[ \"BR_MedicationID\" ],\"FKMap\":[  ] },{ \"FK\":[ \"BR_SchemeID\" ],\"FKMap\":[  ] } ]");
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
         state.Add("gxTpr_Br_scheme_medicationid_Z");
         state.Add("gxTpr_Br_schemeid_Z");
         state.Add("gxTpr_Br_medicationid_Z");
         state.Add("gxTpr_Br_scheme_chem_regimens_Z");
         state.Add("gxTpr_Br_medication_rxname_Z");
         state.Add("gxTpr_Br_medication_rxdose_Z_double");
         state.Add("gxTpr_Br_medication_rxunit_Z");
         state.Add("gxTpr_Br_schemeid_N");
         state.Add("gxTpr_Br_medicationid_N");
         state.Add("gxTpr_Br_scheme_chem_regimens_N");
         state.Add("gxTpr_Br_medication_rxname_N");
         state.Add("gxTpr_Br_medication_rxdose_N");
         state.Add("gxTpr_Br_medication_rxunit_N");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtBR_Scheme_Medication sdt ;
         sdt = (SdtBR_Scheme_Medication)(source);
         gxTv_SdtBR_Scheme_Medication_Br_scheme_medicationid = sdt.gxTv_SdtBR_Scheme_Medication_Br_scheme_medicationid ;
         gxTv_SdtBR_Scheme_Medication_Br_schemeid = sdt.gxTv_SdtBR_Scheme_Medication_Br_schemeid ;
         gxTv_SdtBR_Scheme_Medication_Br_medicationid = sdt.gxTv_SdtBR_Scheme_Medication_Br_medicationid ;
         gxTv_SdtBR_Scheme_Medication_Br_scheme_chem_regimens = sdt.gxTv_SdtBR_Scheme_Medication_Br_scheme_chem_regimens ;
         gxTv_SdtBR_Scheme_Medication_Br_medication_rxname = sdt.gxTv_SdtBR_Scheme_Medication_Br_medication_rxname ;
         gxTv_SdtBR_Scheme_Medication_Br_medication_rxdose = sdt.gxTv_SdtBR_Scheme_Medication_Br_medication_rxdose ;
         gxTv_SdtBR_Scheme_Medication_Br_medication_rxunit = sdt.gxTv_SdtBR_Scheme_Medication_Br_medication_rxunit ;
         gxTv_SdtBR_Scheme_Medication_Mode = sdt.gxTv_SdtBR_Scheme_Medication_Mode ;
         gxTv_SdtBR_Scheme_Medication_Initialized = sdt.gxTv_SdtBR_Scheme_Medication_Initialized ;
         gxTv_SdtBR_Scheme_Medication_Br_scheme_medicationid_Z = sdt.gxTv_SdtBR_Scheme_Medication_Br_scheme_medicationid_Z ;
         gxTv_SdtBR_Scheme_Medication_Br_schemeid_Z = sdt.gxTv_SdtBR_Scheme_Medication_Br_schemeid_Z ;
         gxTv_SdtBR_Scheme_Medication_Br_medicationid_Z = sdt.gxTv_SdtBR_Scheme_Medication_Br_medicationid_Z ;
         gxTv_SdtBR_Scheme_Medication_Br_scheme_chem_regimens_Z = sdt.gxTv_SdtBR_Scheme_Medication_Br_scheme_chem_regimens_Z ;
         gxTv_SdtBR_Scheme_Medication_Br_medication_rxname_Z = sdt.gxTv_SdtBR_Scheme_Medication_Br_medication_rxname_Z ;
         gxTv_SdtBR_Scheme_Medication_Br_medication_rxdose_Z = sdt.gxTv_SdtBR_Scheme_Medication_Br_medication_rxdose_Z ;
         gxTv_SdtBR_Scheme_Medication_Br_medication_rxunit_Z = sdt.gxTv_SdtBR_Scheme_Medication_Br_medication_rxunit_Z ;
         gxTv_SdtBR_Scheme_Medication_Br_schemeid_N = sdt.gxTv_SdtBR_Scheme_Medication_Br_schemeid_N ;
         gxTv_SdtBR_Scheme_Medication_Br_medicationid_N = sdt.gxTv_SdtBR_Scheme_Medication_Br_medicationid_N ;
         gxTv_SdtBR_Scheme_Medication_Br_scheme_chem_regimens_N = sdt.gxTv_SdtBR_Scheme_Medication_Br_scheme_chem_regimens_N ;
         gxTv_SdtBR_Scheme_Medication_Br_medication_rxname_N = sdt.gxTv_SdtBR_Scheme_Medication_Br_medication_rxname_N ;
         gxTv_SdtBR_Scheme_Medication_Br_medication_rxdose_N = sdt.gxTv_SdtBR_Scheme_Medication_Br_medication_rxdose_N ;
         gxTv_SdtBR_Scheme_Medication_Br_medication_rxunit_N = sdt.gxTv_SdtBR_Scheme_Medication_Br_medication_rxunit_N ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("BR_Scheme_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Scheme_Medication_Br_scheme_medicationid), 18, 0)), false);
         AddObjectProperty("BR_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Scheme_Medication_Br_schemeid), 18, 0)), false);
         AddObjectProperty("BR_SchemeID_N", gxTv_SdtBR_Scheme_Medication_Br_schemeid_N, false);
         AddObjectProperty("BR_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Scheme_Medication_Br_medicationid), 18, 0)), false);
         AddObjectProperty("BR_MedicationID_N", gxTv_SdtBR_Scheme_Medication_Br_medicationid_N, false);
         AddObjectProperty("BR_Scheme_Chem_Regimens", gxTv_SdtBR_Scheme_Medication_Br_scheme_chem_regimens, false);
         AddObjectProperty("BR_Scheme_Chem_Regimens_N", gxTv_SdtBR_Scheme_Medication_Br_scheme_chem_regimens_N, false);
         AddObjectProperty("BR_Medication_RXName", gxTv_SdtBR_Scheme_Medication_Br_medication_rxname, false);
         AddObjectProperty("BR_Medication_RXName_N", gxTv_SdtBR_Scheme_Medication_Br_medication_rxname_N, false);
         AddObjectProperty("BR_Medication_RXDose", gxTv_SdtBR_Scheme_Medication_Br_medication_rxdose, false);
         AddObjectProperty("BR_Medication_RXDose_N", gxTv_SdtBR_Scheme_Medication_Br_medication_rxdose_N, false);
         AddObjectProperty("BR_Medication_RXUnit", gxTv_SdtBR_Scheme_Medication_Br_medication_rxunit, false);
         AddObjectProperty("BR_Medication_RXUnit_N", gxTv_SdtBR_Scheme_Medication_Br_medication_rxunit_N, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtBR_Scheme_Medication_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtBR_Scheme_Medication_Initialized, false);
            AddObjectProperty("BR_Scheme_MedicationID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Scheme_Medication_Br_scheme_medicationid_Z), 18, 0)), false);
            AddObjectProperty("BR_SchemeID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Scheme_Medication_Br_schemeid_Z), 18, 0)), false);
            AddObjectProperty("BR_MedicationID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Scheme_Medication_Br_medicationid_Z), 18, 0)), false);
            AddObjectProperty("BR_Scheme_Chem_Regimens_Z", gxTv_SdtBR_Scheme_Medication_Br_scheme_chem_regimens_Z, false);
            AddObjectProperty("BR_Medication_RXName_Z", gxTv_SdtBR_Scheme_Medication_Br_medication_rxname_Z, false);
            AddObjectProperty("BR_Medication_RXDose_Z", gxTv_SdtBR_Scheme_Medication_Br_medication_rxdose_Z, false);
            AddObjectProperty("BR_Medication_RXUnit_Z", gxTv_SdtBR_Scheme_Medication_Br_medication_rxunit_Z, false);
            AddObjectProperty("BR_SchemeID_N", gxTv_SdtBR_Scheme_Medication_Br_schemeid_N, false);
            AddObjectProperty("BR_MedicationID_N", gxTv_SdtBR_Scheme_Medication_Br_medicationid_N, false);
            AddObjectProperty("BR_Scheme_Chem_Regimens_N", gxTv_SdtBR_Scheme_Medication_Br_scheme_chem_regimens_N, false);
            AddObjectProperty("BR_Medication_RXName_N", gxTv_SdtBR_Scheme_Medication_Br_medication_rxname_N, false);
            AddObjectProperty("BR_Medication_RXDose_N", gxTv_SdtBR_Scheme_Medication_Br_medication_rxdose_N, false);
            AddObjectProperty("BR_Medication_RXUnit_N", gxTv_SdtBR_Scheme_Medication_Br_medication_rxunit_N, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtBR_Scheme_Medication sdt )
      {
         if ( sdt.IsDirty("BR_Scheme_MedicationID") )
         {
            gxTv_SdtBR_Scheme_Medication_Br_scheme_medicationid = sdt.gxTv_SdtBR_Scheme_Medication_Br_scheme_medicationid ;
         }
         if ( sdt.IsDirty("BR_SchemeID") )
         {
            gxTv_SdtBR_Scheme_Medication_Br_schemeid = sdt.gxTv_SdtBR_Scheme_Medication_Br_schemeid ;
         }
         if ( sdt.IsDirty("BR_MedicationID") )
         {
            gxTv_SdtBR_Scheme_Medication_Br_medicationid = sdt.gxTv_SdtBR_Scheme_Medication_Br_medicationid ;
         }
         if ( sdt.IsDirty("BR_Scheme_Chem_Regimens") )
         {
            gxTv_SdtBR_Scheme_Medication_Br_scheme_chem_regimens = sdt.gxTv_SdtBR_Scheme_Medication_Br_scheme_chem_regimens ;
         }
         if ( sdt.IsDirty("BR_Medication_RXName") )
         {
            gxTv_SdtBR_Scheme_Medication_Br_medication_rxname = sdt.gxTv_SdtBR_Scheme_Medication_Br_medication_rxname ;
         }
         if ( sdt.IsDirty("BR_Medication_RXDose") )
         {
            gxTv_SdtBR_Scheme_Medication_Br_medication_rxdose = sdt.gxTv_SdtBR_Scheme_Medication_Br_medication_rxdose ;
         }
         if ( sdt.IsDirty("BR_Medication_RXUnit") )
         {
            gxTv_SdtBR_Scheme_Medication_Br_medication_rxunit = sdt.gxTv_SdtBR_Scheme_Medication_Br_medication_rxunit ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "BR_Scheme_MedicationID" )]
      [  XmlElement( ElementName = "BR_Scheme_MedicationID"   )]
      public long gxTpr_Br_scheme_medicationid
      {
         get {
            return gxTv_SdtBR_Scheme_Medication_Br_scheme_medicationid ;
         }

         set {
            if ( gxTv_SdtBR_Scheme_Medication_Br_scheme_medicationid != value )
            {
               gxTv_SdtBR_Scheme_Medication_Mode = "INS";
               this.gxTv_SdtBR_Scheme_Medication_Br_scheme_medicationid_Z_SetNull( );
               this.gxTv_SdtBR_Scheme_Medication_Br_schemeid_Z_SetNull( );
               this.gxTv_SdtBR_Scheme_Medication_Br_medicationid_Z_SetNull( );
               this.gxTv_SdtBR_Scheme_Medication_Br_scheme_chem_regimens_Z_SetNull( );
               this.gxTv_SdtBR_Scheme_Medication_Br_medication_rxname_Z_SetNull( );
               this.gxTv_SdtBR_Scheme_Medication_Br_medication_rxdose_Z_SetNull( );
               this.gxTv_SdtBR_Scheme_Medication_Br_medication_rxunit_Z_SetNull( );
            }
            gxTv_SdtBR_Scheme_Medication_Br_scheme_medicationid = value;
            SetDirty("Br_scheme_medicationid");
         }

      }

      [  SoapElement( ElementName = "BR_SchemeID" )]
      [  XmlElement( ElementName = "BR_SchemeID"   )]
      public long gxTpr_Br_schemeid
      {
         get {
            return gxTv_SdtBR_Scheme_Medication_Br_schemeid ;
         }

         set {
            gxTv_SdtBR_Scheme_Medication_Br_schemeid_N = 0;
            gxTv_SdtBR_Scheme_Medication_Br_schemeid = value;
            SetDirty("Br_schemeid");
         }

      }

      public void gxTv_SdtBR_Scheme_Medication_Br_schemeid_SetNull( )
      {
         gxTv_SdtBR_Scheme_Medication_Br_schemeid_N = 1;
         gxTv_SdtBR_Scheme_Medication_Br_schemeid = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Scheme_Medication_Br_schemeid_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicationID" )]
      [  XmlElement( ElementName = "BR_MedicationID"   )]
      public long gxTpr_Br_medicationid
      {
         get {
            return gxTv_SdtBR_Scheme_Medication_Br_medicationid ;
         }

         set {
            gxTv_SdtBR_Scheme_Medication_Br_medicationid_N = 0;
            gxTv_SdtBR_Scheme_Medication_Br_medicationid = value;
            SetDirty("Br_medicationid");
         }

      }

      public void gxTv_SdtBR_Scheme_Medication_Br_medicationid_SetNull( )
      {
         gxTv_SdtBR_Scheme_Medication_Br_medicationid_N = 1;
         gxTv_SdtBR_Scheme_Medication_Br_medicationid = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Scheme_Medication_Br_medicationid_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Scheme_Chem_Regimens" )]
      [  XmlElement( ElementName = "BR_Scheme_Chem_Regimens"   )]
      public String gxTpr_Br_scheme_chem_regimens
      {
         get {
            return gxTv_SdtBR_Scheme_Medication_Br_scheme_chem_regimens ;
         }

         set {
            gxTv_SdtBR_Scheme_Medication_Br_scheme_chem_regimens_N = 0;
            gxTv_SdtBR_Scheme_Medication_Br_scheme_chem_regimens = value;
            SetDirty("Br_scheme_chem_regimens");
         }

      }

      public void gxTv_SdtBR_Scheme_Medication_Br_scheme_chem_regimens_SetNull( )
      {
         gxTv_SdtBR_Scheme_Medication_Br_scheme_chem_regimens_N = 1;
         gxTv_SdtBR_Scheme_Medication_Br_scheme_chem_regimens = "";
         return  ;
      }

      public bool gxTv_SdtBR_Scheme_Medication_Br_scheme_chem_regimens_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_RXName" )]
      [  XmlElement( ElementName = "BR_Medication_RXName"   )]
      public String gxTpr_Br_medication_rxname
      {
         get {
            return gxTv_SdtBR_Scheme_Medication_Br_medication_rxname ;
         }

         set {
            gxTv_SdtBR_Scheme_Medication_Br_medication_rxname_N = 0;
            gxTv_SdtBR_Scheme_Medication_Br_medication_rxname = value;
            SetDirty("Br_medication_rxname");
         }

      }

      public void gxTv_SdtBR_Scheme_Medication_Br_medication_rxname_SetNull( )
      {
         gxTv_SdtBR_Scheme_Medication_Br_medication_rxname_N = 1;
         gxTv_SdtBR_Scheme_Medication_Br_medication_rxname = "";
         return  ;
      }

      public bool gxTv_SdtBR_Scheme_Medication_Br_medication_rxname_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_RXDose" )]
      [  XmlElement( ElementName = "BR_Medication_RXDose"   )]
      public double gxTpr_Br_medication_rxdose_double
      {
         get {
            return Convert.ToDouble(gxTv_SdtBR_Scheme_Medication_Br_medication_rxdose) ;
         }

         set {
            gxTv_SdtBR_Scheme_Medication_Br_medication_rxdose_N = 0;
            gxTv_SdtBR_Scheme_Medication_Br_medication_rxdose = (decimal)(Convert.ToDecimal( value));
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public decimal gxTpr_Br_medication_rxdose
      {
         get {
            return gxTv_SdtBR_Scheme_Medication_Br_medication_rxdose ;
         }

         set {
            gxTv_SdtBR_Scheme_Medication_Br_medication_rxdose_N = 0;
            gxTv_SdtBR_Scheme_Medication_Br_medication_rxdose = value;
            SetDirty("Br_medication_rxdose");
         }

      }

      public void gxTv_SdtBR_Scheme_Medication_Br_medication_rxdose_SetNull( )
      {
         gxTv_SdtBR_Scheme_Medication_Br_medication_rxdose_N = 1;
         gxTv_SdtBR_Scheme_Medication_Br_medication_rxdose = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Scheme_Medication_Br_medication_rxdose_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_RXUnit" )]
      [  XmlElement( ElementName = "BR_Medication_RXUnit"   )]
      public String gxTpr_Br_medication_rxunit
      {
         get {
            return gxTv_SdtBR_Scheme_Medication_Br_medication_rxunit ;
         }

         set {
            gxTv_SdtBR_Scheme_Medication_Br_medication_rxunit_N = 0;
            gxTv_SdtBR_Scheme_Medication_Br_medication_rxunit = value;
            SetDirty("Br_medication_rxunit");
         }

      }

      public void gxTv_SdtBR_Scheme_Medication_Br_medication_rxunit_SetNull( )
      {
         gxTv_SdtBR_Scheme_Medication_Br_medication_rxunit_N = 1;
         gxTv_SdtBR_Scheme_Medication_Br_medication_rxunit = "";
         return  ;
      }

      public bool gxTv_SdtBR_Scheme_Medication_Br_medication_rxunit_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtBR_Scheme_Medication_Mode ;
         }

         set {
            gxTv_SdtBR_Scheme_Medication_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtBR_Scheme_Medication_Mode_SetNull( )
      {
         gxTv_SdtBR_Scheme_Medication_Mode = "";
         return  ;
      }

      public bool gxTv_SdtBR_Scheme_Medication_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtBR_Scheme_Medication_Initialized ;
         }

         set {
            gxTv_SdtBR_Scheme_Medication_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtBR_Scheme_Medication_Initialized_SetNull( )
      {
         gxTv_SdtBR_Scheme_Medication_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Scheme_Medication_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Scheme_MedicationID_Z" )]
      [  XmlElement( ElementName = "BR_Scheme_MedicationID_Z"   )]
      public long gxTpr_Br_scheme_medicationid_Z
      {
         get {
            return gxTv_SdtBR_Scheme_Medication_Br_scheme_medicationid_Z ;
         }

         set {
            gxTv_SdtBR_Scheme_Medication_Br_scheme_medicationid_Z = value;
            SetDirty("Br_scheme_medicationid_Z");
         }

      }

      public void gxTv_SdtBR_Scheme_Medication_Br_scheme_medicationid_Z_SetNull( )
      {
         gxTv_SdtBR_Scheme_Medication_Br_scheme_medicationid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Scheme_Medication_Br_scheme_medicationid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_SchemeID_Z" )]
      [  XmlElement( ElementName = "BR_SchemeID_Z"   )]
      public long gxTpr_Br_schemeid_Z
      {
         get {
            return gxTv_SdtBR_Scheme_Medication_Br_schemeid_Z ;
         }

         set {
            gxTv_SdtBR_Scheme_Medication_Br_schemeid_Z = value;
            SetDirty("Br_schemeid_Z");
         }

      }

      public void gxTv_SdtBR_Scheme_Medication_Br_schemeid_Z_SetNull( )
      {
         gxTv_SdtBR_Scheme_Medication_Br_schemeid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Scheme_Medication_Br_schemeid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicationID_Z" )]
      [  XmlElement( ElementName = "BR_MedicationID_Z"   )]
      public long gxTpr_Br_medicationid_Z
      {
         get {
            return gxTv_SdtBR_Scheme_Medication_Br_medicationid_Z ;
         }

         set {
            gxTv_SdtBR_Scheme_Medication_Br_medicationid_Z = value;
            SetDirty("Br_medicationid_Z");
         }

      }

      public void gxTv_SdtBR_Scheme_Medication_Br_medicationid_Z_SetNull( )
      {
         gxTv_SdtBR_Scheme_Medication_Br_medicationid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Scheme_Medication_Br_medicationid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Scheme_Chem_Regimens_Z" )]
      [  XmlElement( ElementName = "BR_Scheme_Chem_Regimens_Z"   )]
      public String gxTpr_Br_scheme_chem_regimens_Z
      {
         get {
            return gxTv_SdtBR_Scheme_Medication_Br_scheme_chem_regimens_Z ;
         }

         set {
            gxTv_SdtBR_Scheme_Medication_Br_scheme_chem_regimens_Z = value;
            SetDirty("Br_scheme_chem_regimens_Z");
         }

      }

      public void gxTv_SdtBR_Scheme_Medication_Br_scheme_chem_regimens_Z_SetNull( )
      {
         gxTv_SdtBR_Scheme_Medication_Br_scheme_chem_regimens_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Scheme_Medication_Br_scheme_chem_regimens_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_RXName_Z" )]
      [  XmlElement( ElementName = "BR_Medication_RXName_Z"   )]
      public String gxTpr_Br_medication_rxname_Z
      {
         get {
            return gxTv_SdtBR_Scheme_Medication_Br_medication_rxname_Z ;
         }

         set {
            gxTv_SdtBR_Scheme_Medication_Br_medication_rxname_Z = value;
            SetDirty("Br_medication_rxname_Z");
         }

      }

      public void gxTv_SdtBR_Scheme_Medication_Br_medication_rxname_Z_SetNull( )
      {
         gxTv_SdtBR_Scheme_Medication_Br_medication_rxname_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Scheme_Medication_Br_medication_rxname_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_RXDose_Z" )]
      [  XmlElement( ElementName = "BR_Medication_RXDose_Z"   )]
      public double gxTpr_Br_medication_rxdose_Z_double
      {
         get {
            return Convert.ToDouble(gxTv_SdtBR_Scheme_Medication_Br_medication_rxdose_Z) ;
         }

         set {
            gxTv_SdtBR_Scheme_Medication_Br_medication_rxdose_Z = (decimal)(Convert.ToDecimal( value));
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public decimal gxTpr_Br_medication_rxdose_Z
      {
         get {
            return gxTv_SdtBR_Scheme_Medication_Br_medication_rxdose_Z ;
         }

         set {
            gxTv_SdtBR_Scheme_Medication_Br_medication_rxdose_Z = value;
            SetDirty("Br_medication_rxdose_Z");
         }

      }

      public void gxTv_SdtBR_Scheme_Medication_Br_medication_rxdose_Z_SetNull( )
      {
         gxTv_SdtBR_Scheme_Medication_Br_medication_rxdose_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Scheme_Medication_Br_medication_rxdose_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_RXUnit_Z" )]
      [  XmlElement( ElementName = "BR_Medication_RXUnit_Z"   )]
      public String gxTpr_Br_medication_rxunit_Z
      {
         get {
            return gxTv_SdtBR_Scheme_Medication_Br_medication_rxunit_Z ;
         }

         set {
            gxTv_SdtBR_Scheme_Medication_Br_medication_rxunit_Z = value;
            SetDirty("Br_medication_rxunit_Z");
         }

      }

      public void gxTv_SdtBR_Scheme_Medication_Br_medication_rxunit_Z_SetNull( )
      {
         gxTv_SdtBR_Scheme_Medication_Br_medication_rxunit_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Scheme_Medication_Br_medication_rxunit_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_SchemeID_N" )]
      [  XmlElement( ElementName = "BR_SchemeID_N"   )]
      public short gxTpr_Br_schemeid_N
      {
         get {
            return gxTv_SdtBR_Scheme_Medication_Br_schemeid_N ;
         }

         set {
            gxTv_SdtBR_Scheme_Medication_Br_schemeid_N = value;
            SetDirty("Br_schemeid_N");
         }

      }

      public void gxTv_SdtBR_Scheme_Medication_Br_schemeid_N_SetNull( )
      {
         gxTv_SdtBR_Scheme_Medication_Br_schemeid_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Scheme_Medication_Br_schemeid_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicationID_N" )]
      [  XmlElement( ElementName = "BR_MedicationID_N"   )]
      public short gxTpr_Br_medicationid_N
      {
         get {
            return gxTv_SdtBR_Scheme_Medication_Br_medicationid_N ;
         }

         set {
            gxTv_SdtBR_Scheme_Medication_Br_medicationid_N = value;
            SetDirty("Br_medicationid_N");
         }

      }

      public void gxTv_SdtBR_Scheme_Medication_Br_medicationid_N_SetNull( )
      {
         gxTv_SdtBR_Scheme_Medication_Br_medicationid_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Scheme_Medication_Br_medicationid_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Scheme_Chem_Regimens_N" )]
      [  XmlElement( ElementName = "BR_Scheme_Chem_Regimens_N"   )]
      public short gxTpr_Br_scheme_chem_regimens_N
      {
         get {
            return gxTv_SdtBR_Scheme_Medication_Br_scheme_chem_regimens_N ;
         }

         set {
            gxTv_SdtBR_Scheme_Medication_Br_scheme_chem_regimens_N = value;
            SetDirty("Br_scheme_chem_regimens_N");
         }

      }

      public void gxTv_SdtBR_Scheme_Medication_Br_scheme_chem_regimens_N_SetNull( )
      {
         gxTv_SdtBR_Scheme_Medication_Br_scheme_chem_regimens_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Scheme_Medication_Br_scheme_chem_regimens_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_RXName_N" )]
      [  XmlElement( ElementName = "BR_Medication_RXName_N"   )]
      public short gxTpr_Br_medication_rxname_N
      {
         get {
            return gxTv_SdtBR_Scheme_Medication_Br_medication_rxname_N ;
         }

         set {
            gxTv_SdtBR_Scheme_Medication_Br_medication_rxname_N = value;
            SetDirty("Br_medication_rxname_N");
         }

      }

      public void gxTv_SdtBR_Scheme_Medication_Br_medication_rxname_N_SetNull( )
      {
         gxTv_SdtBR_Scheme_Medication_Br_medication_rxname_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Scheme_Medication_Br_medication_rxname_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_RXDose_N" )]
      [  XmlElement( ElementName = "BR_Medication_RXDose_N"   )]
      public short gxTpr_Br_medication_rxdose_N
      {
         get {
            return gxTv_SdtBR_Scheme_Medication_Br_medication_rxdose_N ;
         }

         set {
            gxTv_SdtBR_Scheme_Medication_Br_medication_rxdose_N = value;
            SetDirty("Br_medication_rxdose_N");
         }

      }

      public void gxTv_SdtBR_Scheme_Medication_Br_medication_rxdose_N_SetNull( )
      {
         gxTv_SdtBR_Scheme_Medication_Br_medication_rxdose_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Scheme_Medication_Br_medication_rxdose_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_RXUnit_N" )]
      [  XmlElement( ElementName = "BR_Medication_RXUnit_N"   )]
      public short gxTpr_Br_medication_rxunit_N
      {
         get {
            return gxTv_SdtBR_Scheme_Medication_Br_medication_rxunit_N ;
         }

         set {
            gxTv_SdtBR_Scheme_Medication_Br_medication_rxunit_N = value;
            SetDirty("Br_medication_rxunit_N");
         }

      }

      public void gxTv_SdtBR_Scheme_Medication_Br_medication_rxunit_N_SetNull( )
      {
         gxTv_SdtBR_Scheme_Medication_Br_medication_rxunit_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Scheme_Medication_Br_medication_rxunit_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtBR_Scheme_Medication_Br_scheme_chem_regimens = "";
         gxTv_SdtBR_Scheme_Medication_Br_medication_rxname = "";
         gxTv_SdtBR_Scheme_Medication_Br_medication_rxunit = "";
         gxTv_SdtBR_Scheme_Medication_Mode = "";
         gxTv_SdtBR_Scheme_Medication_Br_scheme_chem_regimens_Z = "";
         gxTv_SdtBR_Scheme_Medication_Br_medication_rxname_Z = "";
         gxTv_SdtBR_Scheme_Medication_Br_medication_rxunit_Z = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "br_scheme_medication", "GeneXus.Programs.br_scheme_medication_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtBR_Scheme_Medication_Initialized ;
      private short gxTv_SdtBR_Scheme_Medication_Br_schemeid_N ;
      private short gxTv_SdtBR_Scheme_Medication_Br_medicationid_N ;
      private short gxTv_SdtBR_Scheme_Medication_Br_scheme_chem_regimens_N ;
      private short gxTv_SdtBR_Scheme_Medication_Br_medication_rxname_N ;
      private short gxTv_SdtBR_Scheme_Medication_Br_medication_rxdose_N ;
      private short gxTv_SdtBR_Scheme_Medication_Br_medication_rxunit_N ;
      private long gxTv_SdtBR_Scheme_Medication_Br_scheme_medicationid ;
      private long gxTv_SdtBR_Scheme_Medication_Br_schemeid ;
      private long gxTv_SdtBR_Scheme_Medication_Br_medicationid ;
      private long gxTv_SdtBR_Scheme_Medication_Br_scheme_medicationid_Z ;
      private long gxTv_SdtBR_Scheme_Medication_Br_schemeid_Z ;
      private long gxTv_SdtBR_Scheme_Medication_Br_medicationid_Z ;
      private decimal gxTv_SdtBR_Scheme_Medication_Br_medication_rxdose ;
      private decimal gxTv_SdtBR_Scheme_Medication_Br_medication_rxdose_Z ;
      private String gxTv_SdtBR_Scheme_Medication_Mode ;
      private String gxTv_SdtBR_Scheme_Medication_Br_scheme_chem_regimens ;
      private String gxTv_SdtBR_Scheme_Medication_Br_medication_rxname ;
      private String gxTv_SdtBR_Scheme_Medication_Br_medication_rxunit ;
      private String gxTv_SdtBR_Scheme_Medication_Br_scheme_chem_regimens_Z ;
      private String gxTv_SdtBR_Scheme_Medication_Br_medication_rxname_Z ;
      private String gxTv_SdtBR_Scheme_Medication_Br_medication_rxunit_Z ;
   }

   [DataContract(Name = @"BR_Scheme_Medication", Namespace = "DataAnalysisPlatform")]
   public class SdtBR_Scheme_Medication_RESTInterface : GxGenericCollectionItem<SdtBR_Scheme_Medication>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtBR_Scheme_Medication_RESTInterface( ) : base()
      {
      }

      public SdtBR_Scheme_Medication_RESTInterface( SdtBR_Scheme_Medication psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "BR_Scheme_MedicationID" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Br_scheme_medicationid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Br_scheme_medicationid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Br_scheme_medicationid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "BR_SchemeID" , Order = 1 )]
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

      [DataMember( Name = "BR_MedicationID" , Order = 2 )]
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

      [DataMember( Name = "BR_Scheme_Chem_Regimens" , Order = 3 )]
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

      [DataMember( Name = "BR_Medication_RXName" , Order = 4 )]
      [GxSeudo()]
      public String gxTpr_Br_medication_rxname
      {
         get {
            return sdt.gxTpr_Br_medication_rxname ;
         }

         set {
            sdt.gxTpr_Br_medication_rxname = value;
         }

      }

      [DataMember( Name = "BR_Medication_RXDose" , Order = 5 )]
      [GxSeudo()]
      public String gxTpr_Br_medication_rxdose
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( sdt.gxTpr_Br_medication_rxdose, 15, 5)) ;
         }

         set {
            sdt.gxTpr_Br_medication_rxdose = NumberUtil.Val( value, ".");
         }

      }

      [DataMember( Name = "BR_Medication_RXUnit" , Order = 6 )]
      [GxSeudo()]
      public String gxTpr_Br_medication_rxunit
      {
         get {
            return sdt.gxTpr_Br_medication_rxunit ;
         }

         set {
            sdt.gxTpr_Br_medication_rxunit = value;
         }

      }

      public SdtBR_Scheme_Medication sdt
      {
         get {
            return (SdtBR_Scheme_Medication)Sdt ;
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
            sdt = new SdtBR_Scheme_Medication() ;
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
