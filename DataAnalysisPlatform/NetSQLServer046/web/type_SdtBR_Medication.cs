/*
               File: type_SdtBR_Medication
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:56:58.34
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
   [XmlRoot(ElementName = "BR_Medication" )]
   [XmlType(TypeName =  "BR_Medication" , Namespace = "DataAnalysisPlatform" )]
   [Serializable]
   public class SdtBR_Medication : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtBR_Medication( )
      {
      }

      public SdtBR_Medication( IGxContext context )
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

      public void Load( long AV119BR_MedicationID )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(long)AV119BR_MedicationID});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"BR_MedicationID", typeof(long)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "BR_Medication");
         metadata.Set("BT", "BR_Medication");
         metadata.Set("PK", "[ \"BR_MedicationID\" ]");
         metadata.Set("PKAssigned", "[ \"BR_MedicationID\" ]");
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
         state.Add("gxTpr_Br_medicationid_Z");
         state.Add("gxTpr_Br_encounterid_Z");
         state.Add("gxTpr_Br_information_patientno_Z");
         state.Add("gxTpr_Br_medication_rxid_Z");
         state.Add("gxTpr_Br_medication_rxname_Z");
         state.Add("gxTpr_Br_medication_rxname_code_Z");
         state.Add("gxTpr_Br_medication_rxcode_Z");
         state.Add("gxTpr_Br_medication_rxtype_Z");
         state.Add("gxTpr_Br_medication_rxdose_Z_double");
         state.Add("gxTpr_Br_medication_rxunit_Z");
         state.Add("gxTpr_Br_medication_rxfrequency_Z");
         state.Add("gxTpr_Br_medication_rxfrequency_code_Z");
         state.Add("gxTpr_Br_medication_rxquantity_Z");
         state.Add("gxTpr_Br_medication_rxdayssupply_Z_double");
         state.Add("gxTpr_Br_medication_rxroute_Z");
         state.Add("gxTpr_Br_medication_rxroute_code_Z");
         state.Add("gxTpr_Br_medication_prescriptiondate_Z_Nullable");
         state.Add("gxTpr_Br_medication_admitstartdate_Z_Nullable");
         state.Add("gxTpr_Br_medication_admitenddate_Z_Nullable");
         state.Add("gxTpr_Br_medication_inpatientchemo_Z");
         state.Add("gxTpr_Br_medication_inpatientchemo_code_Z");
         state.Add("gxTpr_Br_medicationid_N");
         state.Add("gxTpr_Br_information_patientno_N");
         state.Add("gxTpr_Br_medication_rxid_N");
         state.Add("gxTpr_Br_medication_rxname_N");
         state.Add("gxTpr_Br_medication_rxname_code_N");
         state.Add("gxTpr_Br_medication_rxcode_N");
         state.Add("gxTpr_Br_medication_rxtype_N");
         state.Add("gxTpr_Br_medication_rxdose_N");
         state.Add("gxTpr_Br_medication_rxunit_N");
         state.Add("gxTpr_Br_medication_rxfrequency_N");
         state.Add("gxTpr_Br_medication_rxfrequency_code_N");
         state.Add("gxTpr_Br_medication_rxquantity_N");
         state.Add("gxTpr_Br_medication_rxdayssupply_N");
         state.Add("gxTpr_Br_medication_rxroute_N");
         state.Add("gxTpr_Br_medication_rxroute_code_N");
         state.Add("gxTpr_Br_medication_prescriptiondate_N");
         state.Add("gxTpr_Br_medication_admitstartdate_N");
         state.Add("gxTpr_Br_medication_admitenddate_N");
         state.Add("gxTpr_Br_medication_inpatientchemo_N");
         state.Add("gxTpr_Br_medication_inpatientchemo_code_N");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtBR_Medication sdt ;
         sdt = (SdtBR_Medication)(source);
         gxTv_SdtBR_Medication_Br_medicationid = sdt.gxTv_SdtBR_Medication_Br_medicationid ;
         gxTv_SdtBR_Medication_Br_encounterid = sdt.gxTv_SdtBR_Medication_Br_encounterid ;
         gxTv_SdtBR_Medication_Br_information_patientno = sdt.gxTv_SdtBR_Medication_Br_information_patientno ;
         gxTv_SdtBR_Medication_Br_medication_rxid = sdt.gxTv_SdtBR_Medication_Br_medication_rxid ;
         gxTv_SdtBR_Medication_Br_medication_rxname = sdt.gxTv_SdtBR_Medication_Br_medication_rxname ;
         gxTv_SdtBR_Medication_Br_medication_rxname_code = sdt.gxTv_SdtBR_Medication_Br_medication_rxname_code ;
         gxTv_SdtBR_Medication_Br_medication_rxcode = sdt.gxTv_SdtBR_Medication_Br_medication_rxcode ;
         gxTv_SdtBR_Medication_Br_medication_rxtype = sdt.gxTv_SdtBR_Medication_Br_medication_rxtype ;
         gxTv_SdtBR_Medication_Br_medication_rxdose = sdt.gxTv_SdtBR_Medication_Br_medication_rxdose ;
         gxTv_SdtBR_Medication_Br_medication_rxunit = sdt.gxTv_SdtBR_Medication_Br_medication_rxunit ;
         gxTv_SdtBR_Medication_Br_medication_rxfrequency = sdt.gxTv_SdtBR_Medication_Br_medication_rxfrequency ;
         gxTv_SdtBR_Medication_Br_medication_rxfrequency_code = sdt.gxTv_SdtBR_Medication_Br_medication_rxfrequency_code ;
         gxTv_SdtBR_Medication_Br_medication_rxquantity = sdt.gxTv_SdtBR_Medication_Br_medication_rxquantity ;
         gxTv_SdtBR_Medication_Br_medication_rxdayssupply = sdt.gxTv_SdtBR_Medication_Br_medication_rxdayssupply ;
         gxTv_SdtBR_Medication_Br_medication_rxroute = sdt.gxTv_SdtBR_Medication_Br_medication_rxroute ;
         gxTv_SdtBR_Medication_Br_medication_rxroute_code = sdt.gxTv_SdtBR_Medication_Br_medication_rxroute_code ;
         gxTv_SdtBR_Medication_Br_medication_prescriptiondate = sdt.gxTv_SdtBR_Medication_Br_medication_prescriptiondate ;
         gxTv_SdtBR_Medication_Br_medication_admitstartdate = sdt.gxTv_SdtBR_Medication_Br_medication_admitstartdate ;
         gxTv_SdtBR_Medication_Br_medication_admitenddate = sdt.gxTv_SdtBR_Medication_Br_medication_admitenddate ;
         gxTv_SdtBR_Medication_Br_medication_inpatientchemo = sdt.gxTv_SdtBR_Medication_Br_medication_inpatientchemo ;
         gxTv_SdtBR_Medication_Br_medication_inpatientchemo_code = sdt.gxTv_SdtBR_Medication_Br_medication_inpatientchemo_code ;
         gxTv_SdtBR_Medication_Mode = sdt.gxTv_SdtBR_Medication_Mode ;
         gxTv_SdtBR_Medication_Initialized = sdt.gxTv_SdtBR_Medication_Initialized ;
         gxTv_SdtBR_Medication_Br_medicationid_Z = sdt.gxTv_SdtBR_Medication_Br_medicationid_Z ;
         gxTv_SdtBR_Medication_Br_encounterid_Z = sdt.gxTv_SdtBR_Medication_Br_encounterid_Z ;
         gxTv_SdtBR_Medication_Br_information_patientno_Z = sdt.gxTv_SdtBR_Medication_Br_information_patientno_Z ;
         gxTv_SdtBR_Medication_Br_medication_rxid_Z = sdt.gxTv_SdtBR_Medication_Br_medication_rxid_Z ;
         gxTv_SdtBR_Medication_Br_medication_rxname_Z = sdt.gxTv_SdtBR_Medication_Br_medication_rxname_Z ;
         gxTv_SdtBR_Medication_Br_medication_rxname_code_Z = sdt.gxTv_SdtBR_Medication_Br_medication_rxname_code_Z ;
         gxTv_SdtBR_Medication_Br_medication_rxcode_Z = sdt.gxTv_SdtBR_Medication_Br_medication_rxcode_Z ;
         gxTv_SdtBR_Medication_Br_medication_rxtype_Z = sdt.gxTv_SdtBR_Medication_Br_medication_rxtype_Z ;
         gxTv_SdtBR_Medication_Br_medication_rxdose_Z = sdt.gxTv_SdtBR_Medication_Br_medication_rxdose_Z ;
         gxTv_SdtBR_Medication_Br_medication_rxunit_Z = sdt.gxTv_SdtBR_Medication_Br_medication_rxunit_Z ;
         gxTv_SdtBR_Medication_Br_medication_rxfrequency_Z = sdt.gxTv_SdtBR_Medication_Br_medication_rxfrequency_Z ;
         gxTv_SdtBR_Medication_Br_medication_rxfrequency_code_Z = sdt.gxTv_SdtBR_Medication_Br_medication_rxfrequency_code_Z ;
         gxTv_SdtBR_Medication_Br_medication_rxquantity_Z = sdt.gxTv_SdtBR_Medication_Br_medication_rxquantity_Z ;
         gxTv_SdtBR_Medication_Br_medication_rxdayssupply_Z = sdt.gxTv_SdtBR_Medication_Br_medication_rxdayssupply_Z ;
         gxTv_SdtBR_Medication_Br_medication_rxroute_Z = sdt.gxTv_SdtBR_Medication_Br_medication_rxroute_Z ;
         gxTv_SdtBR_Medication_Br_medication_rxroute_code_Z = sdt.gxTv_SdtBR_Medication_Br_medication_rxroute_code_Z ;
         gxTv_SdtBR_Medication_Br_medication_prescriptiondate_Z = sdt.gxTv_SdtBR_Medication_Br_medication_prescriptiondate_Z ;
         gxTv_SdtBR_Medication_Br_medication_admitstartdate_Z = sdt.gxTv_SdtBR_Medication_Br_medication_admitstartdate_Z ;
         gxTv_SdtBR_Medication_Br_medication_admitenddate_Z = sdt.gxTv_SdtBR_Medication_Br_medication_admitenddate_Z ;
         gxTv_SdtBR_Medication_Br_medication_inpatientchemo_Z = sdt.gxTv_SdtBR_Medication_Br_medication_inpatientchemo_Z ;
         gxTv_SdtBR_Medication_Br_medication_inpatientchemo_code_Z = sdt.gxTv_SdtBR_Medication_Br_medication_inpatientchemo_code_Z ;
         gxTv_SdtBR_Medication_Br_medicationid_N = sdt.gxTv_SdtBR_Medication_Br_medicationid_N ;
         gxTv_SdtBR_Medication_Br_information_patientno_N = sdt.gxTv_SdtBR_Medication_Br_information_patientno_N ;
         gxTv_SdtBR_Medication_Br_medication_rxid_N = sdt.gxTv_SdtBR_Medication_Br_medication_rxid_N ;
         gxTv_SdtBR_Medication_Br_medication_rxname_N = sdt.gxTv_SdtBR_Medication_Br_medication_rxname_N ;
         gxTv_SdtBR_Medication_Br_medication_rxname_code_N = sdt.gxTv_SdtBR_Medication_Br_medication_rxname_code_N ;
         gxTv_SdtBR_Medication_Br_medication_rxcode_N = sdt.gxTv_SdtBR_Medication_Br_medication_rxcode_N ;
         gxTv_SdtBR_Medication_Br_medication_rxtype_N = sdt.gxTv_SdtBR_Medication_Br_medication_rxtype_N ;
         gxTv_SdtBR_Medication_Br_medication_rxdose_N = sdt.gxTv_SdtBR_Medication_Br_medication_rxdose_N ;
         gxTv_SdtBR_Medication_Br_medication_rxunit_N = sdt.gxTv_SdtBR_Medication_Br_medication_rxunit_N ;
         gxTv_SdtBR_Medication_Br_medication_rxfrequency_N = sdt.gxTv_SdtBR_Medication_Br_medication_rxfrequency_N ;
         gxTv_SdtBR_Medication_Br_medication_rxfrequency_code_N = sdt.gxTv_SdtBR_Medication_Br_medication_rxfrequency_code_N ;
         gxTv_SdtBR_Medication_Br_medication_rxquantity_N = sdt.gxTv_SdtBR_Medication_Br_medication_rxquantity_N ;
         gxTv_SdtBR_Medication_Br_medication_rxdayssupply_N = sdt.gxTv_SdtBR_Medication_Br_medication_rxdayssupply_N ;
         gxTv_SdtBR_Medication_Br_medication_rxroute_N = sdt.gxTv_SdtBR_Medication_Br_medication_rxroute_N ;
         gxTv_SdtBR_Medication_Br_medication_rxroute_code_N = sdt.gxTv_SdtBR_Medication_Br_medication_rxroute_code_N ;
         gxTv_SdtBR_Medication_Br_medication_prescriptiondate_N = sdt.gxTv_SdtBR_Medication_Br_medication_prescriptiondate_N ;
         gxTv_SdtBR_Medication_Br_medication_admitstartdate_N = sdt.gxTv_SdtBR_Medication_Br_medication_admitstartdate_N ;
         gxTv_SdtBR_Medication_Br_medication_admitenddate_N = sdt.gxTv_SdtBR_Medication_Br_medication_admitenddate_N ;
         gxTv_SdtBR_Medication_Br_medication_inpatientchemo_N = sdt.gxTv_SdtBR_Medication_Br_medication_inpatientchemo_N ;
         gxTv_SdtBR_Medication_Br_medication_inpatientchemo_code_N = sdt.gxTv_SdtBR_Medication_Br_medication_inpatientchemo_code_N ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("BR_MedicationID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Medication_Br_medicationid), 18, 0)), false);
         AddObjectProperty("BR_MedicationID_N", gxTv_SdtBR_Medication_Br_medicationid_N, false);
         AddObjectProperty("BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Medication_Br_encounterid), 18, 0)), false);
         AddObjectProperty("BR_Information_PatientNo", gxTv_SdtBR_Medication_Br_information_patientno, false);
         AddObjectProperty("BR_Information_PatientNo_N", gxTv_SdtBR_Medication_Br_information_patientno_N, false);
         AddObjectProperty("BR_Medication_RXID", gxTv_SdtBR_Medication_Br_medication_rxid, false);
         AddObjectProperty("BR_Medication_RXID_N", gxTv_SdtBR_Medication_Br_medication_rxid_N, false);
         AddObjectProperty("BR_Medication_RXName", gxTv_SdtBR_Medication_Br_medication_rxname, false);
         AddObjectProperty("BR_Medication_RXName_N", gxTv_SdtBR_Medication_Br_medication_rxname_N, false);
         AddObjectProperty("BR_Medication_RXName_Code", gxTv_SdtBR_Medication_Br_medication_rxname_code, false);
         AddObjectProperty("BR_Medication_RXName_Code_N", gxTv_SdtBR_Medication_Br_medication_rxname_code_N, false);
         AddObjectProperty("BR_Medication_RXCode", gxTv_SdtBR_Medication_Br_medication_rxcode, false);
         AddObjectProperty("BR_Medication_RXCode_N", gxTv_SdtBR_Medication_Br_medication_rxcode_N, false);
         AddObjectProperty("BR_Medication_RXType", gxTv_SdtBR_Medication_Br_medication_rxtype, false);
         AddObjectProperty("BR_Medication_RXType_N", gxTv_SdtBR_Medication_Br_medication_rxtype_N, false);
         AddObjectProperty("BR_Medication_RXDose", gxTv_SdtBR_Medication_Br_medication_rxdose, false);
         AddObjectProperty("BR_Medication_RXDose_N", gxTv_SdtBR_Medication_Br_medication_rxdose_N, false);
         AddObjectProperty("BR_Medication_RXUnit", gxTv_SdtBR_Medication_Br_medication_rxunit, false);
         AddObjectProperty("BR_Medication_RXUnit_N", gxTv_SdtBR_Medication_Br_medication_rxunit_N, false);
         AddObjectProperty("BR_Medication_RXFrequency", gxTv_SdtBR_Medication_Br_medication_rxfrequency, false);
         AddObjectProperty("BR_Medication_RXFrequency_N", gxTv_SdtBR_Medication_Br_medication_rxfrequency_N, false);
         AddObjectProperty("BR_Medication_RXFrequency_Code", gxTv_SdtBR_Medication_Br_medication_rxfrequency_code, false);
         AddObjectProperty("BR_Medication_RXFrequency_Code_N", gxTv_SdtBR_Medication_Br_medication_rxfrequency_code_N, false);
         AddObjectProperty("BR_Medication_RXQuantity", gxTv_SdtBR_Medication_Br_medication_rxquantity, false);
         AddObjectProperty("BR_Medication_RXQuantity_N", gxTv_SdtBR_Medication_Br_medication_rxquantity_N, false);
         AddObjectProperty("BR_Medication_RXDaysSupply", gxTv_SdtBR_Medication_Br_medication_rxdayssupply, false);
         AddObjectProperty("BR_Medication_RXDaysSupply_N", gxTv_SdtBR_Medication_Br_medication_rxdayssupply_N, false);
         AddObjectProperty("BR_Medication_RXRoute", gxTv_SdtBR_Medication_Br_medication_rxroute, false);
         AddObjectProperty("BR_Medication_RXRoute_N", gxTv_SdtBR_Medication_Br_medication_rxroute_N, false);
         AddObjectProperty("BR_Medication_RXRoute_Code", gxTv_SdtBR_Medication_Br_medication_rxroute_code, false);
         AddObjectProperty("BR_Medication_RXRoute_Code_N", gxTv_SdtBR_Medication_Br_medication_rxroute_code_N, false);
         sDateCnv = "";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtBR_Medication_Br_medication_prescriptiondate)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtBR_Medication_Br_medication_prescriptiondate)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtBR_Medication_Br_medication_prescriptiondate)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         AddObjectProperty("BR_Medication_PrescriptionDate", sDateCnv, false);
         AddObjectProperty("BR_Medication_PrescriptionDate_N", gxTv_SdtBR_Medication_Br_medication_prescriptiondate_N, false);
         sDateCnv = "";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtBR_Medication_Br_medication_admitstartdate)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtBR_Medication_Br_medication_admitstartdate)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtBR_Medication_Br_medication_admitstartdate)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         AddObjectProperty("BR_Medication_AdmitStartDate", sDateCnv, false);
         AddObjectProperty("BR_Medication_AdmitStartDate_N", gxTv_SdtBR_Medication_Br_medication_admitstartdate_N, false);
         sDateCnv = "";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtBR_Medication_Br_medication_admitenddate)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtBR_Medication_Br_medication_admitenddate)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtBR_Medication_Br_medication_admitenddate)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         AddObjectProperty("BR_Medication_AdmitEndDate", sDateCnv, false);
         AddObjectProperty("BR_Medication_AdmitEndDate_N", gxTv_SdtBR_Medication_Br_medication_admitenddate_N, false);
         AddObjectProperty("BR_Medication_InpatientChemo", gxTv_SdtBR_Medication_Br_medication_inpatientchemo, false);
         AddObjectProperty("BR_Medication_InpatientChemo_N", gxTv_SdtBR_Medication_Br_medication_inpatientchemo_N, false);
         AddObjectProperty("BR_Medication_InpatientChemo_Code", gxTv_SdtBR_Medication_Br_medication_inpatientchemo_code, false);
         AddObjectProperty("BR_Medication_InpatientChemo_Code_N", gxTv_SdtBR_Medication_Br_medication_inpatientchemo_code_N, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtBR_Medication_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtBR_Medication_Initialized, false);
            AddObjectProperty("BR_MedicationID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Medication_Br_medicationid_Z), 18, 0)), false);
            AddObjectProperty("BR_EncounterID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Medication_Br_encounterid_Z), 18, 0)), false);
            AddObjectProperty("BR_Information_PatientNo_Z", gxTv_SdtBR_Medication_Br_information_patientno_Z, false);
            AddObjectProperty("BR_Medication_RXID_Z", gxTv_SdtBR_Medication_Br_medication_rxid_Z, false);
            AddObjectProperty("BR_Medication_RXName_Z", gxTv_SdtBR_Medication_Br_medication_rxname_Z, false);
            AddObjectProperty("BR_Medication_RXName_Code_Z", gxTv_SdtBR_Medication_Br_medication_rxname_code_Z, false);
            AddObjectProperty("BR_Medication_RXCode_Z", gxTv_SdtBR_Medication_Br_medication_rxcode_Z, false);
            AddObjectProperty("BR_Medication_RXType_Z", gxTv_SdtBR_Medication_Br_medication_rxtype_Z, false);
            AddObjectProperty("BR_Medication_RXDose_Z", gxTv_SdtBR_Medication_Br_medication_rxdose_Z, false);
            AddObjectProperty("BR_Medication_RXUnit_Z", gxTv_SdtBR_Medication_Br_medication_rxunit_Z, false);
            AddObjectProperty("BR_Medication_RXFrequency_Z", gxTv_SdtBR_Medication_Br_medication_rxfrequency_Z, false);
            AddObjectProperty("BR_Medication_RXFrequency_Code_Z", gxTv_SdtBR_Medication_Br_medication_rxfrequency_code_Z, false);
            AddObjectProperty("BR_Medication_RXQuantity_Z", gxTv_SdtBR_Medication_Br_medication_rxquantity_Z, false);
            AddObjectProperty("BR_Medication_RXDaysSupply_Z", gxTv_SdtBR_Medication_Br_medication_rxdayssupply_Z, false);
            AddObjectProperty("BR_Medication_RXRoute_Z", gxTv_SdtBR_Medication_Br_medication_rxroute_Z, false);
            AddObjectProperty("BR_Medication_RXRoute_Code_Z", gxTv_SdtBR_Medication_Br_medication_rxroute_code_Z, false);
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtBR_Medication_Br_medication_prescriptiondate_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtBR_Medication_Br_medication_prescriptiondate_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtBR_Medication_Br_medication_prescriptiondate_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            AddObjectProperty("BR_Medication_PrescriptionDate_Z", sDateCnv, false);
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtBR_Medication_Br_medication_admitstartdate_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtBR_Medication_Br_medication_admitstartdate_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtBR_Medication_Br_medication_admitstartdate_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            AddObjectProperty("BR_Medication_AdmitStartDate_Z", sDateCnv, false);
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtBR_Medication_Br_medication_admitenddate_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtBR_Medication_Br_medication_admitenddate_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtBR_Medication_Br_medication_admitenddate_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            AddObjectProperty("BR_Medication_AdmitEndDate_Z", sDateCnv, false);
            AddObjectProperty("BR_Medication_InpatientChemo_Z", gxTv_SdtBR_Medication_Br_medication_inpatientchemo_Z, false);
            AddObjectProperty("BR_Medication_InpatientChemo_Code_Z", gxTv_SdtBR_Medication_Br_medication_inpatientchemo_code_Z, false);
            AddObjectProperty("BR_MedicationID_N", gxTv_SdtBR_Medication_Br_medicationid_N, false);
            AddObjectProperty("BR_Information_PatientNo_N", gxTv_SdtBR_Medication_Br_information_patientno_N, false);
            AddObjectProperty("BR_Medication_RXID_N", gxTv_SdtBR_Medication_Br_medication_rxid_N, false);
            AddObjectProperty("BR_Medication_RXName_N", gxTv_SdtBR_Medication_Br_medication_rxname_N, false);
            AddObjectProperty("BR_Medication_RXName_Code_N", gxTv_SdtBR_Medication_Br_medication_rxname_code_N, false);
            AddObjectProperty("BR_Medication_RXCode_N", gxTv_SdtBR_Medication_Br_medication_rxcode_N, false);
            AddObjectProperty("BR_Medication_RXType_N", gxTv_SdtBR_Medication_Br_medication_rxtype_N, false);
            AddObjectProperty("BR_Medication_RXDose_N", gxTv_SdtBR_Medication_Br_medication_rxdose_N, false);
            AddObjectProperty("BR_Medication_RXUnit_N", gxTv_SdtBR_Medication_Br_medication_rxunit_N, false);
            AddObjectProperty("BR_Medication_RXFrequency_N", gxTv_SdtBR_Medication_Br_medication_rxfrequency_N, false);
            AddObjectProperty("BR_Medication_RXFrequency_Code_N", gxTv_SdtBR_Medication_Br_medication_rxfrequency_code_N, false);
            AddObjectProperty("BR_Medication_RXQuantity_N", gxTv_SdtBR_Medication_Br_medication_rxquantity_N, false);
            AddObjectProperty("BR_Medication_RXDaysSupply_N", gxTv_SdtBR_Medication_Br_medication_rxdayssupply_N, false);
            AddObjectProperty("BR_Medication_RXRoute_N", gxTv_SdtBR_Medication_Br_medication_rxroute_N, false);
            AddObjectProperty("BR_Medication_RXRoute_Code_N", gxTv_SdtBR_Medication_Br_medication_rxroute_code_N, false);
            AddObjectProperty("BR_Medication_PrescriptionDate_N", gxTv_SdtBR_Medication_Br_medication_prescriptiondate_N, false);
            AddObjectProperty("BR_Medication_AdmitStartDate_N", gxTv_SdtBR_Medication_Br_medication_admitstartdate_N, false);
            AddObjectProperty("BR_Medication_AdmitEndDate_N", gxTv_SdtBR_Medication_Br_medication_admitenddate_N, false);
            AddObjectProperty("BR_Medication_InpatientChemo_N", gxTv_SdtBR_Medication_Br_medication_inpatientchemo_N, false);
            AddObjectProperty("BR_Medication_InpatientChemo_Code_N", gxTv_SdtBR_Medication_Br_medication_inpatientchemo_code_N, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtBR_Medication sdt )
      {
         if ( sdt.IsDirty("BR_MedicationID") )
         {
            gxTv_SdtBR_Medication_Br_medicationid = sdt.gxTv_SdtBR_Medication_Br_medicationid ;
         }
         if ( sdt.IsDirty("BR_EncounterID") )
         {
            gxTv_SdtBR_Medication_Br_encounterid = sdt.gxTv_SdtBR_Medication_Br_encounterid ;
         }
         if ( sdt.IsDirty("BR_Information_PatientNo") )
         {
            gxTv_SdtBR_Medication_Br_information_patientno = sdt.gxTv_SdtBR_Medication_Br_information_patientno ;
         }
         if ( sdt.IsDirty("BR_Medication_RXID") )
         {
            gxTv_SdtBR_Medication_Br_medication_rxid = sdt.gxTv_SdtBR_Medication_Br_medication_rxid ;
         }
         if ( sdt.IsDirty("BR_Medication_RXName") )
         {
            gxTv_SdtBR_Medication_Br_medication_rxname = sdt.gxTv_SdtBR_Medication_Br_medication_rxname ;
         }
         if ( sdt.IsDirty("BR_Medication_RXName_Code") )
         {
            gxTv_SdtBR_Medication_Br_medication_rxname_code = sdt.gxTv_SdtBR_Medication_Br_medication_rxname_code ;
         }
         if ( sdt.IsDirty("BR_Medication_RXCode") )
         {
            gxTv_SdtBR_Medication_Br_medication_rxcode = sdt.gxTv_SdtBR_Medication_Br_medication_rxcode ;
         }
         if ( sdt.IsDirty("BR_Medication_RXType") )
         {
            gxTv_SdtBR_Medication_Br_medication_rxtype = sdt.gxTv_SdtBR_Medication_Br_medication_rxtype ;
         }
         if ( sdt.IsDirty("BR_Medication_RXDose") )
         {
            gxTv_SdtBR_Medication_Br_medication_rxdose = sdt.gxTv_SdtBR_Medication_Br_medication_rxdose ;
         }
         if ( sdt.IsDirty("BR_Medication_RXUnit") )
         {
            gxTv_SdtBR_Medication_Br_medication_rxunit = sdt.gxTv_SdtBR_Medication_Br_medication_rxunit ;
         }
         if ( sdt.IsDirty("BR_Medication_RXFrequency") )
         {
            gxTv_SdtBR_Medication_Br_medication_rxfrequency = sdt.gxTv_SdtBR_Medication_Br_medication_rxfrequency ;
         }
         if ( sdt.IsDirty("BR_Medication_RXFrequency_Code") )
         {
            gxTv_SdtBR_Medication_Br_medication_rxfrequency_code = sdt.gxTv_SdtBR_Medication_Br_medication_rxfrequency_code ;
         }
         if ( sdt.IsDirty("BR_Medication_RXQuantity") )
         {
            gxTv_SdtBR_Medication_Br_medication_rxquantity = sdt.gxTv_SdtBR_Medication_Br_medication_rxquantity ;
         }
         if ( sdt.IsDirty("BR_Medication_RXDaysSupply") )
         {
            gxTv_SdtBR_Medication_Br_medication_rxdayssupply = sdt.gxTv_SdtBR_Medication_Br_medication_rxdayssupply ;
         }
         if ( sdt.IsDirty("BR_Medication_RXRoute") )
         {
            gxTv_SdtBR_Medication_Br_medication_rxroute = sdt.gxTv_SdtBR_Medication_Br_medication_rxroute ;
         }
         if ( sdt.IsDirty("BR_Medication_RXRoute_Code") )
         {
            gxTv_SdtBR_Medication_Br_medication_rxroute_code = sdt.gxTv_SdtBR_Medication_Br_medication_rxroute_code ;
         }
         if ( sdt.IsDirty("BR_Medication_PrescriptionDate") )
         {
            gxTv_SdtBR_Medication_Br_medication_prescriptiondate = sdt.gxTv_SdtBR_Medication_Br_medication_prescriptiondate ;
         }
         if ( sdt.IsDirty("BR_Medication_AdmitStartDate") )
         {
            gxTv_SdtBR_Medication_Br_medication_admitstartdate = sdt.gxTv_SdtBR_Medication_Br_medication_admitstartdate ;
         }
         if ( sdt.IsDirty("BR_Medication_AdmitEndDate") )
         {
            gxTv_SdtBR_Medication_Br_medication_admitenddate = sdt.gxTv_SdtBR_Medication_Br_medication_admitenddate ;
         }
         if ( sdt.IsDirty("BR_Medication_InpatientChemo") )
         {
            gxTv_SdtBR_Medication_Br_medication_inpatientchemo = sdt.gxTv_SdtBR_Medication_Br_medication_inpatientchemo ;
         }
         if ( sdt.IsDirty("BR_Medication_InpatientChemo_Code") )
         {
            gxTv_SdtBR_Medication_Br_medication_inpatientchemo_code = sdt.gxTv_SdtBR_Medication_Br_medication_inpatientchemo_code ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "BR_MedicationID" )]
      [  XmlElement( ElementName = "BR_MedicationID"   )]
      public long gxTpr_Br_medicationid
      {
         get {
            return gxTv_SdtBR_Medication_Br_medicationid ;
         }

         set {
            if ( gxTv_SdtBR_Medication_Br_medicationid != value )
            {
               gxTv_SdtBR_Medication_Mode = "INS";
               this.gxTv_SdtBR_Medication_Br_medicationid_Z_SetNull( );
               this.gxTv_SdtBR_Medication_Br_encounterid_Z_SetNull( );
               this.gxTv_SdtBR_Medication_Br_information_patientno_Z_SetNull( );
               this.gxTv_SdtBR_Medication_Br_medication_rxid_Z_SetNull( );
               this.gxTv_SdtBR_Medication_Br_medication_rxname_Z_SetNull( );
               this.gxTv_SdtBR_Medication_Br_medication_rxname_code_Z_SetNull( );
               this.gxTv_SdtBR_Medication_Br_medication_rxcode_Z_SetNull( );
               this.gxTv_SdtBR_Medication_Br_medication_rxtype_Z_SetNull( );
               this.gxTv_SdtBR_Medication_Br_medication_rxdose_Z_SetNull( );
               this.gxTv_SdtBR_Medication_Br_medication_rxunit_Z_SetNull( );
               this.gxTv_SdtBR_Medication_Br_medication_rxfrequency_Z_SetNull( );
               this.gxTv_SdtBR_Medication_Br_medication_rxfrequency_code_Z_SetNull( );
               this.gxTv_SdtBR_Medication_Br_medication_rxquantity_Z_SetNull( );
               this.gxTv_SdtBR_Medication_Br_medication_rxdayssupply_Z_SetNull( );
               this.gxTv_SdtBR_Medication_Br_medication_rxroute_Z_SetNull( );
               this.gxTv_SdtBR_Medication_Br_medication_rxroute_code_Z_SetNull( );
               this.gxTv_SdtBR_Medication_Br_medication_prescriptiondate_Z_SetNull( );
               this.gxTv_SdtBR_Medication_Br_medication_admitstartdate_Z_SetNull( );
               this.gxTv_SdtBR_Medication_Br_medication_admitenddate_Z_SetNull( );
               this.gxTv_SdtBR_Medication_Br_medication_inpatientchemo_Z_SetNull( );
               this.gxTv_SdtBR_Medication_Br_medication_inpatientchemo_code_Z_SetNull( );
            }
            gxTv_SdtBR_Medication_Br_medicationid = value;
            SetDirty("Br_medicationid");
         }

      }

      [  SoapElement( ElementName = "BR_EncounterID" )]
      [  XmlElement( ElementName = "BR_EncounterID"   )]
      public long gxTpr_Br_encounterid
      {
         get {
            return gxTv_SdtBR_Medication_Br_encounterid ;
         }

         set {
            gxTv_SdtBR_Medication_Br_encounterid = value;
            SetDirty("Br_encounterid");
         }

      }

      [  SoapElement( ElementName = "BR_Information_PatientNo" )]
      [  XmlElement( ElementName = "BR_Information_PatientNo"   )]
      public String gxTpr_Br_information_patientno
      {
         get {
            return gxTv_SdtBR_Medication_Br_information_patientno ;
         }

         set {
            gxTv_SdtBR_Medication_Br_information_patientno_N = 0;
            gxTv_SdtBR_Medication_Br_information_patientno = value;
            SetDirty("Br_information_patientno");
         }

      }

      public void gxTv_SdtBR_Medication_Br_information_patientno_SetNull( )
      {
         gxTv_SdtBR_Medication_Br_information_patientno_N = 1;
         gxTv_SdtBR_Medication_Br_information_patientno = "";
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Br_information_patientno_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_RXID" )]
      [  XmlElement( ElementName = "BR_Medication_RXID"   )]
      public short gxTpr_Br_medication_rxid
      {
         get {
            return gxTv_SdtBR_Medication_Br_medication_rxid ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medication_rxid_N = 0;
            gxTv_SdtBR_Medication_Br_medication_rxid = value;
            SetDirty("Br_medication_rxid");
         }

      }

      public void gxTv_SdtBR_Medication_Br_medication_rxid_SetNull( )
      {
         gxTv_SdtBR_Medication_Br_medication_rxid_N = 1;
         gxTv_SdtBR_Medication_Br_medication_rxid = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Br_medication_rxid_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_RXName" )]
      [  XmlElement( ElementName = "BR_Medication_RXName"   )]
      public String gxTpr_Br_medication_rxname
      {
         get {
            return gxTv_SdtBR_Medication_Br_medication_rxname ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medication_rxname_N = 0;
            gxTv_SdtBR_Medication_Br_medication_rxname = value;
            SetDirty("Br_medication_rxname");
         }

      }

      public void gxTv_SdtBR_Medication_Br_medication_rxname_SetNull( )
      {
         gxTv_SdtBR_Medication_Br_medication_rxname_N = 1;
         gxTv_SdtBR_Medication_Br_medication_rxname = "";
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Br_medication_rxname_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_RXName_Code" )]
      [  XmlElement( ElementName = "BR_Medication_RXName_Code"   )]
      public String gxTpr_Br_medication_rxname_code
      {
         get {
            return gxTv_SdtBR_Medication_Br_medication_rxname_code ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medication_rxname_code_N = 0;
            gxTv_SdtBR_Medication_Br_medication_rxname_code = value;
            SetDirty("Br_medication_rxname_code");
         }

      }

      public void gxTv_SdtBR_Medication_Br_medication_rxname_code_SetNull( )
      {
         gxTv_SdtBR_Medication_Br_medication_rxname_code_N = 1;
         gxTv_SdtBR_Medication_Br_medication_rxname_code = "";
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Br_medication_rxname_code_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_RXCode" )]
      [  XmlElement( ElementName = "BR_Medication_RXCode"   )]
      public String gxTpr_Br_medication_rxcode
      {
         get {
            return gxTv_SdtBR_Medication_Br_medication_rxcode ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medication_rxcode_N = 0;
            gxTv_SdtBR_Medication_Br_medication_rxcode = value;
            SetDirty("Br_medication_rxcode");
         }

      }

      public void gxTv_SdtBR_Medication_Br_medication_rxcode_SetNull( )
      {
         gxTv_SdtBR_Medication_Br_medication_rxcode_N = 1;
         gxTv_SdtBR_Medication_Br_medication_rxcode = "";
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Br_medication_rxcode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_RXType" )]
      [  XmlElement( ElementName = "BR_Medication_RXType"   )]
      public String gxTpr_Br_medication_rxtype
      {
         get {
            return gxTv_SdtBR_Medication_Br_medication_rxtype ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medication_rxtype_N = 0;
            gxTv_SdtBR_Medication_Br_medication_rxtype = value;
            SetDirty("Br_medication_rxtype");
         }

      }

      public void gxTv_SdtBR_Medication_Br_medication_rxtype_SetNull( )
      {
         gxTv_SdtBR_Medication_Br_medication_rxtype_N = 1;
         gxTv_SdtBR_Medication_Br_medication_rxtype = "";
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Br_medication_rxtype_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_RXDose" )]
      [  XmlElement( ElementName = "BR_Medication_RXDose"   )]
      public double gxTpr_Br_medication_rxdose_double
      {
         get {
            return Convert.ToDouble(gxTv_SdtBR_Medication_Br_medication_rxdose) ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medication_rxdose_N = 0;
            gxTv_SdtBR_Medication_Br_medication_rxdose = (decimal)(Convert.ToDecimal( value));
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public decimal gxTpr_Br_medication_rxdose
      {
         get {
            return gxTv_SdtBR_Medication_Br_medication_rxdose ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medication_rxdose_N = 0;
            gxTv_SdtBR_Medication_Br_medication_rxdose = value;
            SetDirty("Br_medication_rxdose");
         }

      }

      public void gxTv_SdtBR_Medication_Br_medication_rxdose_SetNull( )
      {
         gxTv_SdtBR_Medication_Br_medication_rxdose_N = 1;
         gxTv_SdtBR_Medication_Br_medication_rxdose = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Br_medication_rxdose_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_RXUnit" )]
      [  XmlElement( ElementName = "BR_Medication_RXUnit"   )]
      public String gxTpr_Br_medication_rxunit
      {
         get {
            return gxTv_SdtBR_Medication_Br_medication_rxunit ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medication_rxunit_N = 0;
            gxTv_SdtBR_Medication_Br_medication_rxunit = value;
            SetDirty("Br_medication_rxunit");
         }

      }

      public void gxTv_SdtBR_Medication_Br_medication_rxunit_SetNull( )
      {
         gxTv_SdtBR_Medication_Br_medication_rxunit_N = 1;
         gxTv_SdtBR_Medication_Br_medication_rxunit = "";
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Br_medication_rxunit_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_RXFrequency" )]
      [  XmlElement( ElementName = "BR_Medication_RXFrequency"   )]
      public String gxTpr_Br_medication_rxfrequency
      {
         get {
            return gxTv_SdtBR_Medication_Br_medication_rxfrequency ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medication_rxfrequency_N = 0;
            gxTv_SdtBR_Medication_Br_medication_rxfrequency = value;
            SetDirty("Br_medication_rxfrequency");
         }

      }

      public void gxTv_SdtBR_Medication_Br_medication_rxfrequency_SetNull( )
      {
         gxTv_SdtBR_Medication_Br_medication_rxfrequency_N = 1;
         gxTv_SdtBR_Medication_Br_medication_rxfrequency = "";
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Br_medication_rxfrequency_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_RXFrequency_Code" )]
      [  XmlElement( ElementName = "BR_Medication_RXFrequency_Code"   )]
      public String gxTpr_Br_medication_rxfrequency_code
      {
         get {
            return gxTv_SdtBR_Medication_Br_medication_rxfrequency_code ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medication_rxfrequency_code_N = 0;
            gxTv_SdtBR_Medication_Br_medication_rxfrequency_code = value;
            SetDirty("Br_medication_rxfrequency_code");
         }

      }

      public void gxTv_SdtBR_Medication_Br_medication_rxfrequency_code_SetNull( )
      {
         gxTv_SdtBR_Medication_Br_medication_rxfrequency_code_N = 1;
         gxTv_SdtBR_Medication_Br_medication_rxfrequency_code = "";
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Br_medication_rxfrequency_code_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_RXQuantity" )]
      [  XmlElement( ElementName = "BR_Medication_RXQuantity"   )]
      public String gxTpr_Br_medication_rxquantity
      {
         get {
            return gxTv_SdtBR_Medication_Br_medication_rxquantity ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medication_rxquantity_N = 0;
            gxTv_SdtBR_Medication_Br_medication_rxquantity = value;
            SetDirty("Br_medication_rxquantity");
         }

      }

      public void gxTv_SdtBR_Medication_Br_medication_rxquantity_SetNull( )
      {
         gxTv_SdtBR_Medication_Br_medication_rxquantity_N = 1;
         gxTv_SdtBR_Medication_Br_medication_rxquantity = "";
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Br_medication_rxquantity_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_RXDaysSupply" )]
      [  XmlElement( ElementName = "BR_Medication_RXDaysSupply"   )]
      public double gxTpr_Br_medication_rxdayssupply_double
      {
         get {
            return Convert.ToDouble(gxTv_SdtBR_Medication_Br_medication_rxdayssupply) ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medication_rxdayssupply_N = 0;
            gxTv_SdtBR_Medication_Br_medication_rxdayssupply = (decimal)(Convert.ToDecimal( value));
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public decimal gxTpr_Br_medication_rxdayssupply
      {
         get {
            return gxTv_SdtBR_Medication_Br_medication_rxdayssupply ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medication_rxdayssupply_N = 0;
            gxTv_SdtBR_Medication_Br_medication_rxdayssupply = value;
            SetDirty("Br_medication_rxdayssupply");
         }

      }

      public void gxTv_SdtBR_Medication_Br_medication_rxdayssupply_SetNull( )
      {
         gxTv_SdtBR_Medication_Br_medication_rxdayssupply_N = 1;
         gxTv_SdtBR_Medication_Br_medication_rxdayssupply = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Br_medication_rxdayssupply_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_RXRoute" )]
      [  XmlElement( ElementName = "BR_Medication_RXRoute"   )]
      public String gxTpr_Br_medication_rxroute
      {
         get {
            return gxTv_SdtBR_Medication_Br_medication_rxroute ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medication_rxroute_N = 0;
            gxTv_SdtBR_Medication_Br_medication_rxroute = value;
            SetDirty("Br_medication_rxroute");
         }

      }

      public void gxTv_SdtBR_Medication_Br_medication_rxroute_SetNull( )
      {
         gxTv_SdtBR_Medication_Br_medication_rxroute_N = 1;
         gxTv_SdtBR_Medication_Br_medication_rxroute = "";
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Br_medication_rxroute_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_RXRoute_Code" )]
      [  XmlElement( ElementName = "BR_Medication_RXRoute_Code"   )]
      public String gxTpr_Br_medication_rxroute_code
      {
         get {
            return gxTv_SdtBR_Medication_Br_medication_rxroute_code ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medication_rxroute_code_N = 0;
            gxTv_SdtBR_Medication_Br_medication_rxroute_code = value;
            SetDirty("Br_medication_rxroute_code");
         }

      }

      public void gxTv_SdtBR_Medication_Br_medication_rxroute_code_SetNull( )
      {
         gxTv_SdtBR_Medication_Br_medication_rxroute_code_N = 1;
         gxTv_SdtBR_Medication_Br_medication_rxroute_code = "";
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Br_medication_rxroute_code_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_PrescriptionDate" )]
      [  XmlElement( ElementName = "BR_Medication_PrescriptionDate"  , IsNullable=true )]
      public string gxTpr_Br_medication_prescriptiondate_Nullable
      {
         get {
            if ( gxTv_SdtBR_Medication_Br_medication_prescriptiondate == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_SdtBR_Medication_Br_medication_prescriptiondate).value ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medication_prescriptiondate_N = 0;
            if (String.IsNullOrEmpty(value) || value == GxDateString.NullValue )
               gxTv_SdtBR_Medication_Br_medication_prescriptiondate = DateTime.MinValue;
            else
               gxTv_SdtBR_Medication_Br_medication_prescriptiondate = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Br_medication_prescriptiondate
      {
         get {
            return gxTv_SdtBR_Medication_Br_medication_prescriptiondate ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medication_prescriptiondate_N = 0;
            gxTv_SdtBR_Medication_Br_medication_prescriptiondate = value;
            SetDirty("Br_medication_prescriptiondate");
         }

      }

      public void gxTv_SdtBR_Medication_Br_medication_prescriptiondate_SetNull( )
      {
         gxTv_SdtBR_Medication_Br_medication_prescriptiondate_N = 1;
         gxTv_SdtBR_Medication_Br_medication_prescriptiondate = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Br_medication_prescriptiondate_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_AdmitStartDate" )]
      [  XmlElement( ElementName = "BR_Medication_AdmitStartDate"  , IsNullable=true )]
      public string gxTpr_Br_medication_admitstartdate_Nullable
      {
         get {
            if ( gxTv_SdtBR_Medication_Br_medication_admitstartdate == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_SdtBR_Medication_Br_medication_admitstartdate).value ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medication_admitstartdate_N = 0;
            if (String.IsNullOrEmpty(value) || value == GxDateString.NullValue )
               gxTv_SdtBR_Medication_Br_medication_admitstartdate = DateTime.MinValue;
            else
               gxTv_SdtBR_Medication_Br_medication_admitstartdate = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Br_medication_admitstartdate
      {
         get {
            return gxTv_SdtBR_Medication_Br_medication_admitstartdate ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medication_admitstartdate_N = 0;
            gxTv_SdtBR_Medication_Br_medication_admitstartdate = value;
            SetDirty("Br_medication_admitstartdate");
         }

      }

      public void gxTv_SdtBR_Medication_Br_medication_admitstartdate_SetNull( )
      {
         gxTv_SdtBR_Medication_Br_medication_admitstartdate_N = 1;
         gxTv_SdtBR_Medication_Br_medication_admitstartdate = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Br_medication_admitstartdate_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_AdmitEndDate" )]
      [  XmlElement( ElementName = "BR_Medication_AdmitEndDate"  , IsNullable=true )]
      public string gxTpr_Br_medication_admitenddate_Nullable
      {
         get {
            if ( gxTv_SdtBR_Medication_Br_medication_admitenddate == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_SdtBR_Medication_Br_medication_admitenddate).value ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medication_admitenddate_N = 0;
            if (String.IsNullOrEmpty(value) || value == GxDateString.NullValue )
               gxTv_SdtBR_Medication_Br_medication_admitenddate = DateTime.MinValue;
            else
               gxTv_SdtBR_Medication_Br_medication_admitenddate = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Br_medication_admitenddate
      {
         get {
            return gxTv_SdtBR_Medication_Br_medication_admitenddate ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medication_admitenddate_N = 0;
            gxTv_SdtBR_Medication_Br_medication_admitenddate = value;
            SetDirty("Br_medication_admitenddate");
         }

      }

      public void gxTv_SdtBR_Medication_Br_medication_admitenddate_SetNull( )
      {
         gxTv_SdtBR_Medication_Br_medication_admitenddate_N = 1;
         gxTv_SdtBR_Medication_Br_medication_admitenddate = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Br_medication_admitenddate_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_InpatientChemo" )]
      [  XmlElement( ElementName = "BR_Medication_InpatientChemo"   )]
      public String gxTpr_Br_medication_inpatientchemo
      {
         get {
            return gxTv_SdtBR_Medication_Br_medication_inpatientchemo ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medication_inpatientchemo_N = 0;
            gxTv_SdtBR_Medication_Br_medication_inpatientchemo = value;
            SetDirty("Br_medication_inpatientchemo");
         }

      }

      public void gxTv_SdtBR_Medication_Br_medication_inpatientchemo_SetNull( )
      {
         gxTv_SdtBR_Medication_Br_medication_inpatientchemo_N = 1;
         gxTv_SdtBR_Medication_Br_medication_inpatientchemo = "";
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Br_medication_inpatientchemo_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_InpatientChemo_Code" )]
      [  XmlElement( ElementName = "BR_Medication_InpatientChemo_Code"   )]
      public String gxTpr_Br_medication_inpatientchemo_code
      {
         get {
            return gxTv_SdtBR_Medication_Br_medication_inpatientchemo_code ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medication_inpatientchemo_code_N = 0;
            gxTv_SdtBR_Medication_Br_medication_inpatientchemo_code = value;
            SetDirty("Br_medication_inpatientchemo_code");
         }

      }

      public void gxTv_SdtBR_Medication_Br_medication_inpatientchemo_code_SetNull( )
      {
         gxTv_SdtBR_Medication_Br_medication_inpatientchemo_code_N = 1;
         gxTv_SdtBR_Medication_Br_medication_inpatientchemo_code = "";
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Br_medication_inpatientchemo_code_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtBR_Medication_Mode ;
         }

         set {
            gxTv_SdtBR_Medication_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtBR_Medication_Mode_SetNull( )
      {
         gxTv_SdtBR_Medication_Mode = "";
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtBR_Medication_Initialized ;
         }

         set {
            gxTv_SdtBR_Medication_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtBR_Medication_Initialized_SetNull( )
      {
         gxTv_SdtBR_Medication_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicationID_Z" )]
      [  XmlElement( ElementName = "BR_MedicationID_Z"   )]
      public long gxTpr_Br_medicationid_Z
      {
         get {
            return gxTv_SdtBR_Medication_Br_medicationid_Z ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medicationid_Z = value;
            SetDirty("Br_medicationid_Z");
         }

      }

      public void gxTv_SdtBR_Medication_Br_medicationid_Z_SetNull( )
      {
         gxTv_SdtBR_Medication_Br_medicationid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Br_medicationid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_EncounterID_Z" )]
      [  XmlElement( ElementName = "BR_EncounterID_Z"   )]
      public long gxTpr_Br_encounterid_Z
      {
         get {
            return gxTv_SdtBR_Medication_Br_encounterid_Z ;
         }

         set {
            gxTv_SdtBR_Medication_Br_encounterid_Z = value;
            SetDirty("Br_encounterid_Z");
         }

      }

      public void gxTv_SdtBR_Medication_Br_encounterid_Z_SetNull( )
      {
         gxTv_SdtBR_Medication_Br_encounterid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Br_encounterid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Information_PatientNo_Z" )]
      [  XmlElement( ElementName = "BR_Information_PatientNo_Z"   )]
      public String gxTpr_Br_information_patientno_Z
      {
         get {
            return gxTv_SdtBR_Medication_Br_information_patientno_Z ;
         }

         set {
            gxTv_SdtBR_Medication_Br_information_patientno_Z = value;
            SetDirty("Br_information_patientno_Z");
         }

      }

      public void gxTv_SdtBR_Medication_Br_information_patientno_Z_SetNull( )
      {
         gxTv_SdtBR_Medication_Br_information_patientno_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Br_information_patientno_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_RXID_Z" )]
      [  XmlElement( ElementName = "BR_Medication_RXID_Z"   )]
      public short gxTpr_Br_medication_rxid_Z
      {
         get {
            return gxTv_SdtBR_Medication_Br_medication_rxid_Z ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medication_rxid_Z = value;
            SetDirty("Br_medication_rxid_Z");
         }

      }

      public void gxTv_SdtBR_Medication_Br_medication_rxid_Z_SetNull( )
      {
         gxTv_SdtBR_Medication_Br_medication_rxid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Br_medication_rxid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_RXName_Z" )]
      [  XmlElement( ElementName = "BR_Medication_RXName_Z"   )]
      public String gxTpr_Br_medication_rxname_Z
      {
         get {
            return gxTv_SdtBR_Medication_Br_medication_rxname_Z ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medication_rxname_Z = value;
            SetDirty("Br_medication_rxname_Z");
         }

      }

      public void gxTv_SdtBR_Medication_Br_medication_rxname_Z_SetNull( )
      {
         gxTv_SdtBR_Medication_Br_medication_rxname_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Br_medication_rxname_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_RXName_Code_Z" )]
      [  XmlElement( ElementName = "BR_Medication_RXName_Code_Z"   )]
      public String gxTpr_Br_medication_rxname_code_Z
      {
         get {
            return gxTv_SdtBR_Medication_Br_medication_rxname_code_Z ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medication_rxname_code_Z = value;
            SetDirty("Br_medication_rxname_code_Z");
         }

      }

      public void gxTv_SdtBR_Medication_Br_medication_rxname_code_Z_SetNull( )
      {
         gxTv_SdtBR_Medication_Br_medication_rxname_code_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Br_medication_rxname_code_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_RXCode_Z" )]
      [  XmlElement( ElementName = "BR_Medication_RXCode_Z"   )]
      public String gxTpr_Br_medication_rxcode_Z
      {
         get {
            return gxTv_SdtBR_Medication_Br_medication_rxcode_Z ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medication_rxcode_Z = value;
            SetDirty("Br_medication_rxcode_Z");
         }

      }

      public void gxTv_SdtBR_Medication_Br_medication_rxcode_Z_SetNull( )
      {
         gxTv_SdtBR_Medication_Br_medication_rxcode_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Br_medication_rxcode_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_RXType_Z" )]
      [  XmlElement( ElementName = "BR_Medication_RXType_Z"   )]
      public String gxTpr_Br_medication_rxtype_Z
      {
         get {
            return gxTv_SdtBR_Medication_Br_medication_rxtype_Z ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medication_rxtype_Z = value;
            SetDirty("Br_medication_rxtype_Z");
         }

      }

      public void gxTv_SdtBR_Medication_Br_medication_rxtype_Z_SetNull( )
      {
         gxTv_SdtBR_Medication_Br_medication_rxtype_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Br_medication_rxtype_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_RXDose_Z" )]
      [  XmlElement( ElementName = "BR_Medication_RXDose_Z"   )]
      public double gxTpr_Br_medication_rxdose_Z_double
      {
         get {
            return Convert.ToDouble(gxTv_SdtBR_Medication_Br_medication_rxdose_Z) ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medication_rxdose_Z = (decimal)(Convert.ToDecimal( value));
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public decimal gxTpr_Br_medication_rxdose_Z
      {
         get {
            return gxTv_SdtBR_Medication_Br_medication_rxdose_Z ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medication_rxdose_Z = value;
            SetDirty("Br_medication_rxdose_Z");
         }

      }

      public void gxTv_SdtBR_Medication_Br_medication_rxdose_Z_SetNull( )
      {
         gxTv_SdtBR_Medication_Br_medication_rxdose_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Br_medication_rxdose_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_RXUnit_Z" )]
      [  XmlElement( ElementName = "BR_Medication_RXUnit_Z"   )]
      public String gxTpr_Br_medication_rxunit_Z
      {
         get {
            return gxTv_SdtBR_Medication_Br_medication_rxunit_Z ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medication_rxunit_Z = value;
            SetDirty("Br_medication_rxunit_Z");
         }

      }

      public void gxTv_SdtBR_Medication_Br_medication_rxunit_Z_SetNull( )
      {
         gxTv_SdtBR_Medication_Br_medication_rxunit_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Br_medication_rxunit_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_RXFrequency_Z" )]
      [  XmlElement( ElementName = "BR_Medication_RXFrequency_Z"   )]
      public String gxTpr_Br_medication_rxfrequency_Z
      {
         get {
            return gxTv_SdtBR_Medication_Br_medication_rxfrequency_Z ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medication_rxfrequency_Z = value;
            SetDirty("Br_medication_rxfrequency_Z");
         }

      }

      public void gxTv_SdtBR_Medication_Br_medication_rxfrequency_Z_SetNull( )
      {
         gxTv_SdtBR_Medication_Br_medication_rxfrequency_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Br_medication_rxfrequency_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_RXFrequency_Code_Z" )]
      [  XmlElement( ElementName = "BR_Medication_RXFrequency_Code_Z"   )]
      public String gxTpr_Br_medication_rxfrequency_code_Z
      {
         get {
            return gxTv_SdtBR_Medication_Br_medication_rxfrequency_code_Z ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medication_rxfrequency_code_Z = value;
            SetDirty("Br_medication_rxfrequency_code_Z");
         }

      }

      public void gxTv_SdtBR_Medication_Br_medication_rxfrequency_code_Z_SetNull( )
      {
         gxTv_SdtBR_Medication_Br_medication_rxfrequency_code_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Br_medication_rxfrequency_code_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_RXQuantity_Z" )]
      [  XmlElement( ElementName = "BR_Medication_RXQuantity_Z"   )]
      public String gxTpr_Br_medication_rxquantity_Z
      {
         get {
            return gxTv_SdtBR_Medication_Br_medication_rxquantity_Z ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medication_rxquantity_Z = value;
            SetDirty("Br_medication_rxquantity_Z");
         }

      }

      public void gxTv_SdtBR_Medication_Br_medication_rxquantity_Z_SetNull( )
      {
         gxTv_SdtBR_Medication_Br_medication_rxquantity_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Br_medication_rxquantity_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_RXDaysSupply_Z" )]
      [  XmlElement( ElementName = "BR_Medication_RXDaysSupply_Z"   )]
      public double gxTpr_Br_medication_rxdayssupply_Z_double
      {
         get {
            return Convert.ToDouble(gxTv_SdtBR_Medication_Br_medication_rxdayssupply_Z) ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medication_rxdayssupply_Z = (decimal)(Convert.ToDecimal( value));
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public decimal gxTpr_Br_medication_rxdayssupply_Z
      {
         get {
            return gxTv_SdtBR_Medication_Br_medication_rxdayssupply_Z ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medication_rxdayssupply_Z = value;
            SetDirty("Br_medication_rxdayssupply_Z");
         }

      }

      public void gxTv_SdtBR_Medication_Br_medication_rxdayssupply_Z_SetNull( )
      {
         gxTv_SdtBR_Medication_Br_medication_rxdayssupply_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Br_medication_rxdayssupply_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_RXRoute_Z" )]
      [  XmlElement( ElementName = "BR_Medication_RXRoute_Z"   )]
      public String gxTpr_Br_medication_rxroute_Z
      {
         get {
            return gxTv_SdtBR_Medication_Br_medication_rxroute_Z ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medication_rxroute_Z = value;
            SetDirty("Br_medication_rxroute_Z");
         }

      }

      public void gxTv_SdtBR_Medication_Br_medication_rxroute_Z_SetNull( )
      {
         gxTv_SdtBR_Medication_Br_medication_rxroute_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Br_medication_rxroute_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_RXRoute_Code_Z" )]
      [  XmlElement( ElementName = "BR_Medication_RXRoute_Code_Z"   )]
      public String gxTpr_Br_medication_rxroute_code_Z
      {
         get {
            return gxTv_SdtBR_Medication_Br_medication_rxroute_code_Z ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medication_rxroute_code_Z = value;
            SetDirty("Br_medication_rxroute_code_Z");
         }

      }

      public void gxTv_SdtBR_Medication_Br_medication_rxroute_code_Z_SetNull( )
      {
         gxTv_SdtBR_Medication_Br_medication_rxroute_code_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Br_medication_rxroute_code_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_PrescriptionDate_Z" )]
      [  XmlElement( ElementName = "BR_Medication_PrescriptionDate_Z"  , IsNullable=true )]
      public string gxTpr_Br_medication_prescriptiondate_Z_Nullable
      {
         get {
            if ( gxTv_SdtBR_Medication_Br_medication_prescriptiondate_Z == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_SdtBR_Medication_Br_medication_prescriptiondate_Z).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDateString.NullValue )
               gxTv_SdtBR_Medication_Br_medication_prescriptiondate_Z = DateTime.MinValue;
            else
               gxTv_SdtBR_Medication_Br_medication_prescriptiondate_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Br_medication_prescriptiondate_Z
      {
         get {
            return gxTv_SdtBR_Medication_Br_medication_prescriptiondate_Z ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medication_prescriptiondate_Z = value;
            SetDirty("Br_medication_prescriptiondate_Z");
         }

      }

      public void gxTv_SdtBR_Medication_Br_medication_prescriptiondate_Z_SetNull( )
      {
         gxTv_SdtBR_Medication_Br_medication_prescriptiondate_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Br_medication_prescriptiondate_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_AdmitStartDate_Z" )]
      [  XmlElement( ElementName = "BR_Medication_AdmitStartDate_Z"  , IsNullable=true )]
      public string gxTpr_Br_medication_admitstartdate_Z_Nullable
      {
         get {
            if ( gxTv_SdtBR_Medication_Br_medication_admitstartdate_Z == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_SdtBR_Medication_Br_medication_admitstartdate_Z).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDateString.NullValue )
               gxTv_SdtBR_Medication_Br_medication_admitstartdate_Z = DateTime.MinValue;
            else
               gxTv_SdtBR_Medication_Br_medication_admitstartdate_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Br_medication_admitstartdate_Z
      {
         get {
            return gxTv_SdtBR_Medication_Br_medication_admitstartdate_Z ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medication_admitstartdate_Z = value;
            SetDirty("Br_medication_admitstartdate_Z");
         }

      }

      public void gxTv_SdtBR_Medication_Br_medication_admitstartdate_Z_SetNull( )
      {
         gxTv_SdtBR_Medication_Br_medication_admitstartdate_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Br_medication_admitstartdate_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_AdmitEndDate_Z" )]
      [  XmlElement( ElementName = "BR_Medication_AdmitEndDate_Z"  , IsNullable=true )]
      public string gxTpr_Br_medication_admitenddate_Z_Nullable
      {
         get {
            if ( gxTv_SdtBR_Medication_Br_medication_admitenddate_Z == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_SdtBR_Medication_Br_medication_admitenddate_Z).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDateString.NullValue )
               gxTv_SdtBR_Medication_Br_medication_admitenddate_Z = DateTime.MinValue;
            else
               gxTv_SdtBR_Medication_Br_medication_admitenddate_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Br_medication_admitenddate_Z
      {
         get {
            return gxTv_SdtBR_Medication_Br_medication_admitenddate_Z ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medication_admitenddate_Z = value;
            SetDirty("Br_medication_admitenddate_Z");
         }

      }

      public void gxTv_SdtBR_Medication_Br_medication_admitenddate_Z_SetNull( )
      {
         gxTv_SdtBR_Medication_Br_medication_admitenddate_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Br_medication_admitenddate_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_InpatientChemo_Z" )]
      [  XmlElement( ElementName = "BR_Medication_InpatientChemo_Z"   )]
      public String gxTpr_Br_medication_inpatientchemo_Z
      {
         get {
            return gxTv_SdtBR_Medication_Br_medication_inpatientchemo_Z ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medication_inpatientchemo_Z = value;
            SetDirty("Br_medication_inpatientchemo_Z");
         }

      }

      public void gxTv_SdtBR_Medication_Br_medication_inpatientchemo_Z_SetNull( )
      {
         gxTv_SdtBR_Medication_Br_medication_inpatientchemo_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Br_medication_inpatientchemo_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_InpatientChemo_Code_Z" )]
      [  XmlElement( ElementName = "BR_Medication_InpatientChemo_Code_Z"   )]
      public String gxTpr_Br_medication_inpatientchemo_code_Z
      {
         get {
            return gxTv_SdtBR_Medication_Br_medication_inpatientchemo_code_Z ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medication_inpatientchemo_code_Z = value;
            SetDirty("Br_medication_inpatientchemo_code_Z");
         }

      }

      public void gxTv_SdtBR_Medication_Br_medication_inpatientchemo_code_Z_SetNull( )
      {
         gxTv_SdtBR_Medication_Br_medication_inpatientchemo_code_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Br_medication_inpatientchemo_code_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicationID_N" )]
      [  XmlElement( ElementName = "BR_MedicationID_N"   )]
      public short gxTpr_Br_medicationid_N
      {
         get {
            return gxTv_SdtBR_Medication_Br_medicationid_N ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medicationid_N = value;
            SetDirty("Br_medicationid_N");
         }

      }

      public void gxTv_SdtBR_Medication_Br_medicationid_N_SetNull( )
      {
         gxTv_SdtBR_Medication_Br_medicationid_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Br_medicationid_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Information_PatientNo_N" )]
      [  XmlElement( ElementName = "BR_Information_PatientNo_N"   )]
      public short gxTpr_Br_information_patientno_N
      {
         get {
            return gxTv_SdtBR_Medication_Br_information_patientno_N ;
         }

         set {
            gxTv_SdtBR_Medication_Br_information_patientno_N = value;
            SetDirty("Br_information_patientno_N");
         }

      }

      public void gxTv_SdtBR_Medication_Br_information_patientno_N_SetNull( )
      {
         gxTv_SdtBR_Medication_Br_information_patientno_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Br_information_patientno_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_RXID_N" )]
      [  XmlElement( ElementName = "BR_Medication_RXID_N"   )]
      public short gxTpr_Br_medication_rxid_N
      {
         get {
            return gxTv_SdtBR_Medication_Br_medication_rxid_N ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medication_rxid_N = value;
            SetDirty("Br_medication_rxid_N");
         }

      }

      public void gxTv_SdtBR_Medication_Br_medication_rxid_N_SetNull( )
      {
         gxTv_SdtBR_Medication_Br_medication_rxid_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Br_medication_rxid_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_RXName_N" )]
      [  XmlElement( ElementName = "BR_Medication_RXName_N"   )]
      public short gxTpr_Br_medication_rxname_N
      {
         get {
            return gxTv_SdtBR_Medication_Br_medication_rxname_N ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medication_rxname_N = value;
            SetDirty("Br_medication_rxname_N");
         }

      }

      public void gxTv_SdtBR_Medication_Br_medication_rxname_N_SetNull( )
      {
         gxTv_SdtBR_Medication_Br_medication_rxname_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Br_medication_rxname_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_RXName_Code_N" )]
      [  XmlElement( ElementName = "BR_Medication_RXName_Code_N"   )]
      public short gxTpr_Br_medication_rxname_code_N
      {
         get {
            return gxTv_SdtBR_Medication_Br_medication_rxname_code_N ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medication_rxname_code_N = value;
            SetDirty("Br_medication_rxname_code_N");
         }

      }

      public void gxTv_SdtBR_Medication_Br_medication_rxname_code_N_SetNull( )
      {
         gxTv_SdtBR_Medication_Br_medication_rxname_code_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Br_medication_rxname_code_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_RXCode_N" )]
      [  XmlElement( ElementName = "BR_Medication_RXCode_N"   )]
      public short gxTpr_Br_medication_rxcode_N
      {
         get {
            return gxTv_SdtBR_Medication_Br_medication_rxcode_N ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medication_rxcode_N = value;
            SetDirty("Br_medication_rxcode_N");
         }

      }

      public void gxTv_SdtBR_Medication_Br_medication_rxcode_N_SetNull( )
      {
         gxTv_SdtBR_Medication_Br_medication_rxcode_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Br_medication_rxcode_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_RXType_N" )]
      [  XmlElement( ElementName = "BR_Medication_RXType_N"   )]
      public short gxTpr_Br_medication_rxtype_N
      {
         get {
            return gxTv_SdtBR_Medication_Br_medication_rxtype_N ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medication_rxtype_N = value;
            SetDirty("Br_medication_rxtype_N");
         }

      }

      public void gxTv_SdtBR_Medication_Br_medication_rxtype_N_SetNull( )
      {
         gxTv_SdtBR_Medication_Br_medication_rxtype_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Br_medication_rxtype_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_RXDose_N" )]
      [  XmlElement( ElementName = "BR_Medication_RXDose_N"   )]
      public short gxTpr_Br_medication_rxdose_N
      {
         get {
            return gxTv_SdtBR_Medication_Br_medication_rxdose_N ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medication_rxdose_N = value;
            SetDirty("Br_medication_rxdose_N");
         }

      }

      public void gxTv_SdtBR_Medication_Br_medication_rxdose_N_SetNull( )
      {
         gxTv_SdtBR_Medication_Br_medication_rxdose_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Br_medication_rxdose_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_RXUnit_N" )]
      [  XmlElement( ElementName = "BR_Medication_RXUnit_N"   )]
      public short gxTpr_Br_medication_rxunit_N
      {
         get {
            return gxTv_SdtBR_Medication_Br_medication_rxunit_N ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medication_rxunit_N = value;
            SetDirty("Br_medication_rxunit_N");
         }

      }

      public void gxTv_SdtBR_Medication_Br_medication_rxunit_N_SetNull( )
      {
         gxTv_SdtBR_Medication_Br_medication_rxunit_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Br_medication_rxunit_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_RXFrequency_N" )]
      [  XmlElement( ElementName = "BR_Medication_RXFrequency_N"   )]
      public short gxTpr_Br_medication_rxfrequency_N
      {
         get {
            return gxTv_SdtBR_Medication_Br_medication_rxfrequency_N ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medication_rxfrequency_N = value;
            SetDirty("Br_medication_rxfrequency_N");
         }

      }

      public void gxTv_SdtBR_Medication_Br_medication_rxfrequency_N_SetNull( )
      {
         gxTv_SdtBR_Medication_Br_medication_rxfrequency_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Br_medication_rxfrequency_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_RXFrequency_Code_N" )]
      [  XmlElement( ElementName = "BR_Medication_RXFrequency_Code_N"   )]
      public short gxTpr_Br_medication_rxfrequency_code_N
      {
         get {
            return gxTv_SdtBR_Medication_Br_medication_rxfrequency_code_N ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medication_rxfrequency_code_N = value;
            SetDirty("Br_medication_rxfrequency_code_N");
         }

      }

      public void gxTv_SdtBR_Medication_Br_medication_rxfrequency_code_N_SetNull( )
      {
         gxTv_SdtBR_Medication_Br_medication_rxfrequency_code_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Br_medication_rxfrequency_code_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_RXQuantity_N" )]
      [  XmlElement( ElementName = "BR_Medication_RXQuantity_N"   )]
      public short gxTpr_Br_medication_rxquantity_N
      {
         get {
            return gxTv_SdtBR_Medication_Br_medication_rxquantity_N ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medication_rxquantity_N = value;
            SetDirty("Br_medication_rxquantity_N");
         }

      }

      public void gxTv_SdtBR_Medication_Br_medication_rxquantity_N_SetNull( )
      {
         gxTv_SdtBR_Medication_Br_medication_rxquantity_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Br_medication_rxquantity_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_RXDaysSupply_N" )]
      [  XmlElement( ElementName = "BR_Medication_RXDaysSupply_N"   )]
      public short gxTpr_Br_medication_rxdayssupply_N
      {
         get {
            return gxTv_SdtBR_Medication_Br_medication_rxdayssupply_N ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medication_rxdayssupply_N = value;
            SetDirty("Br_medication_rxdayssupply_N");
         }

      }

      public void gxTv_SdtBR_Medication_Br_medication_rxdayssupply_N_SetNull( )
      {
         gxTv_SdtBR_Medication_Br_medication_rxdayssupply_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Br_medication_rxdayssupply_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_RXRoute_N" )]
      [  XmlElement( ElementName = "BR_Medication_RXRoute_N"   )]
      public short gxTpr_Br_medication_rxroute_N
      {
         get {
            return gxTv_SdtBR_Medication_Br_medication_rxroute_N ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medication_rxroute_N = value;
            SetDirty("Br_medication_rxroute_N");
         }

      }

      public void gxTv_SdtBR_Medication_Br_medication_rxroute_N_SetNull( )
      {
         gxTv_SdtBR_Medication_Br_medication_rxroute_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Br_medication_rxroute_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_RXRoute_Code_N" )]
      [  XmlElement( ElementName = "BR_Medication_RXRoute_Code_N"   )]
      public short gxTpr_Br_medication_rxroute_code_N
      {
         get {
            return gxTv_SdtBR_Medication_Br_medication_rxroute_code_N ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medication_rxroute_code_N = value;
            SetDirty("Br_medication_rxroute_code_N");
         }

      }

      public void gxTv_SdtBR_Medication_Br_medication_rxroute_code_N_SetNull( )
      {
         gxTv_SdtBR_Medication_Br_medication_rxroute_code_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Br_medication_rxroute_code_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_PrescriptionDate_N" )]
      [  XmlElement( ElementName = "BR_Medication_PrescriptionDate_N"   )]
      public short gxTpr_Br_medication_prescriptiondate_N
      {
         get {
            return gxTv_SdtBR_Medication_Br_medication_prescriptiondate_N ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medication_prescriptiondate_N = value;
            SetDirty("Br_medication_prescriptiondate_N");
         }

      }

      public void gxTv_SdtBR_Medication_Br_medication_prescriptiondate_N_SetNull( )
      {
         gxTv_SdtBR_Medication_Br_medication_prescriptiondate_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Br_medication_prescriptiondate_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_AdmitStartDate_N" )]
      [  XmlElement( ElementName = "BR_Medication_AdmitStartDate_N"   )]
      public short gxTpr_Br_medication_admitstartdate_N
      {
         get {
            return gxTv_SdtBR_Medication_Br_medication_admitstartdate_N ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medication_admitstartdate_N = value;
            SetDirty("Br_medication_admitstartdate_N");
         }

      }

      public void gxTv_SdtBR_Medication_Br_medication_admitstartdate_N_SetNull( )
      {
         gxTv_SdtBR_Medication_Br_medication_admitstartdate_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Br_medication_admitstartdate_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_AdmitEndDate_N" )]
      [  XmlElement( ElementName = "BR_Medication_AdmitEndDate_N"   )]
      public short gxTpr_Br_medication_admitenddate_N
      {
         get {
            return gxTv_SdtBR_Medication_Br_medication_admitenddate_N ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medication_admitenddate_N = value;
            SetDirty("Br_medication_admitenddate_N");
         }

      }

      public void gxTv_SdtBR_Medication_Br_medication_admitenddate_N_SetNull( )
      {
         gxTv_SdtBR_Medication_Br_medication_admitenddate_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Br_medication_admitenddate_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_InpatientChemo_N" )]
      [  XmlElement( ElementName = "BR_Medication_InpatientChemo_N"   )]
      public short gxTpr_Br_medication_inpatientchemo_N
      {
         get {
            return gxTv_SdtBR_Medication_Br_medication_inpatientchemo_N ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medication_inpatientchemo_N = value;
            SetDirty("Br_medication_inpatientchemo_N");
         }

      }

      public void gxTv_SdtBR_Medication_Br_medication_inpatientchemo_N_SetNull( )
      {
         gxTv_SdtBR_Medication_Br_medication_inpatientchemo_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Br_medication_inpatientchemo_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Medication_InpatientChemo_Code_N" )]
      [  XmlElement( ElementName = "BR_Medication_InpatientChemo_Code_N"   )]
      public short gxTpr_Br_medication_inpatientchemo_code_N
      {
         get {
            return gxTv_SdtBR_Medication_Br_medication_inpatientchemo_code_N ;
         }

         set {
            gxTv_SdtBR_Medication_Br_medication_inpatientchemo_code_N = value;
            SetDirty("Br_medication_inpatientchemo_code_N");
         }

      }

      public void gxTv_SdtBR_Medication_Br_medication_inpatientchemo_code_N_SetNull( )
      {
         gxTv_SdtBR_Medication_Br_medication_inpatientchemo_code_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Medication_Br_medication_inpatientchemo_code_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtBR_Medication_Br_information_patientno = "";
         gxTv_SdtBR_Medication_Br_medication_rxname = "";
         gxTv_SdtBR_Medication_Br_medication_rxname_code = "";
         gxTv_SdtBR_Medication_Br_medication_rxcode = "";
         gxTv_SdtBR_Medication_Br_medication_rxtype = "";
         gxTv_SdtBR_Medication_Br_medication_rxunit = "";
         gxTv_SdtBR_Medication_Br_medication_rxfrequency = "";
         gxTv_SdtBR_Medication_Br_medication_rxfrequency_code = "";
         gxTv_SdtBR_Medication_Br_medication_rxquantity = "";
         gxTv_SdtBR_Medication_Br_medication_rxroute = "";
         gxTv_SdtBR_Medication_Br_medication_rxroute_code = "";
         gxTv_SdtBR_Medication_Br_medication_prescriptiondate = DateTime.MinValue;
         gxTv_SdtBR_Medication_Br_medication_admitstartdate = DateTime.MinValue;
         gxTv_SdtBR_Medication_Br_medication_admitenddate = DateTime.MinValue;
         gxTv_SdtBR_Medication_Br_medication_inpatientchemo = "";
         gxTv_SdtBR_Medication_Br_medication_inpatientchemo_code = "";
         gxTv_SdtBR_Medication_Mode = "";
         gxTv_SdtBR_Medication_Br_information_patientno_Z = "";
         gxTv_SdtBR_Medication_Br_medication_rxname_Z = "";
         gxTv_SdtBR_Medication_Br_medication_rxname_code_Z = "";
         gxTv_SdtBR_Medication_Br_medication_rxcode_Z = "";
         gxTv_SdtBR_Medication_Br_medication_rxtype_Z = "";
         gxTv_SdtBR_Medication_Br_medication_rxunit_Z = "";
         gxTv_SdtBR_Medication_Br_medication_rxfrequency_Z = "";
         gxTv_SdtBR_Medication_Br_medication_rxfrequency_code_Z = "";
         gxTv_SdtBR_Medication_Br_medication_rxquantity_Z = "";
         gxTv_SdtBR_Medication_Br_medication_rxroute_Z = "";
         gxTv_SdtBR_Medication_Br_medication_rxroute_code_Z = "";
         gxTv_SdtBR_Medication_Br_medication_prescriptiondate_Z = DateTime.MinValue;
         gxTv_SdtBR_Medication_Br_medication_admitstartdate_Z = DateTime.MinValue;
         gxTv_SdtBR_Medication_Br_medication_admitenddate_Z = DateTime.MinValue;
         gxTv_SdtBR_Medication_Br_medication_inpatientchemo_Z = "";
         gxTv_SdtBR_Medication_Br_medication_inpatientchemo_code_Z = "";
         sDateCnv = "";
         sNumToPad = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "br_medication", "GeneXus.Programs.br_medication_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtBR_Medication_Br_medication_rxid ;
      private short gxTv_SdtBR_Medication_Initialized ;
      private short gxTv_SdtBR_Medication_Br_medication_rxid_Z ;
      private short gxTv_SdtBR_Medication_Br_medicationid_N ;
      private short gxTv_SdtBR_Medication_Br_information_patientno_N ;
      private short gxTv_SdtBR_Medication_Br_medication_rxid_N ;
      private short gxTv_SdtBR_Medication_Br_medication_rxname_N ;
      private short gxTv_SdtBR_Medication_Br_medication_rxname_code_N ;
      private short gxTv_SdtBR_Medication_Br_medication_rxcode_N ;
      private short gxTv_SdtBR_Medication_Br_medication_rxtype_N ;
      private short gxTv_SdtBR_Medication_Br_medication_rxdose_N ;
      private short gxTv_SdtBR_Medication_Br_medication_rxunit_N ;
      private short gxTv_SdtBR_Medication_Br_medication_rxfrequency_N ;
      private short gxTv_SdtBR_Medication_Br_medication_rxfrequency_code_N ;
      private short gxTv_SdtBR_Medication_Br_medication_rxquantity_N ;
      private short gxTv_SdtBR_Medication_Br_medication_rxdayssupply_N ;
      private short gxTv_SdtBR_Medication_Br_medication_rxroute_N ;
      private short gxTv_SdtBR_Medication_Br_medication_rxroute_code_N ;
      private short gxTv_SdtBR_Medication_Br_medication_prescriptiondate_N ;
      private short gxTv_SdtBR_Medication_Br_medication_admitstartdate_N ;
      private short gxTv_SdtBR_Medication_Br_medication_admitenddate_N ;
      private short gxTv_SdtBR_Medication_Br_medication_inpatientchemo_N ;
      private short gxTv_SdtBR_Medication_Br_medication_inpatientchemo_code_N ;
      private long gxTv_SdtBR_Medication_Br_medicationid ;
      private long gxTv_SdtBR_Medication_Br_encounterid ;
      private long gxTv_SdtBR_Medication_Br_medicationid_Z ;
      private long gxTv_SdtBR_Medication_Br_encounterid_Z ;
      private decimal gxTv_SdtBR_Medication_Br_medication_rxdose ;
      private decimal gxTv_SdtBR_Medication_Br_medication_rxdayssupply ;
      private decimal gxTv_SdtBR_Medication_Br_medication_rxdose_Z ;
      private decimal gxTv_SdtBR_Medication_Br_medication_rxdayssupply_Z ;
      private String gxTv_SdtBR_Medication_Mode ;
      private String sDateCnv ;
      private String sNumToPad ;
      private DateTime gxTv_SdtBR_Medication_Br_medication_prescriptiondate ;
      private DateTime gxTv_SdtBR_Medication_Br_medication_admitstartdate ;
      private DateTime gxTv_SdtBR_Medication_Br_medication_admitenddate ;
      private DateTime gxTv_SdtBR_Medication_Br_medication_prescriptiondate_Z ;
      private DateTime gxTv_SdtBR_Medication_Br_medication_admitstartdate_Z ;
      private DateTime gxTv_SdtBR_Medication_Br_medication_admitenddate_Z ;
      private String gxTv_SdtBR_Medication_Br_information_patientno ;
      private String gxTv_SdtBR_Medication_Br_medication_rxname ;
      private String gxTv_SdtBR_Medication_Br_medication_rxname_code ;
      private String gxTv_SdtBR_Medication_Br_medication_rxcode ;
      private String gxTv_SdtBR_Medication_Br_medication_rxtype ;
      private String gxTv_SdtBR_Medication_Br_medication_rxunit ;
      private String gxTv_SdtBR_Medication_Br_medication_rxfrequency ;
      private String gxTv_SdtBR_Medication_Br_medication_rxfrequency_code ;
      private String gxTv_SdtBR_Medication_Br_medication_rxquantity ;
      private String gxTv_SdtBR_Medication_Br_medication_rxroute ;
      private String gxTv_SdtBR_Medication_Br_medication_rxroute_code ;
      private String gxTv_SdtBR_Medication_Br_medication_inpatientchemo ;
      private String gxTv_SdtBR_Medication_Br_medication_inpatientchemo_code ;
      private String gxTv_SdtBR_Medication_Br_information_patientno_Z ;
      private String gxTv_SdtBR_Medication_Br_medication_rxname_Z ;
      private String gxTv_SdtBR_Medication_Br_medication_rxname_code_Z ;
      private String gxTv_SdtBR_Medication_Br_medication_rxcode_Z ;
      private String gxTv_SdtBR_Medication_Br_medication_rxtype_Z ;
      private String gxTv_SdtBR_Medication_Br_medication_rxunit_Z ;
      private String gxTv_SdtBR_Medication_Br_medication_rxfrequency_Z ;
      private String gxTv_SdtBR_Medication_Br_medication_rxfrequency_code_Z ;
      private String gxTv_SdtBR_Medication_Br_medication_rxquantity_Z ;
      private String gxTv_SdtBR_Medication_Br_medication_rxroute_Z ;
      private String gxTv_SdtBR_Medication_Br_medication_rxroute_code_Z ;
      private String gxTv_SdtBR_Medication_Br_medication_inpatientchemo_Z ;
      private String gxTv_SdtBR_Medication_Br_medication_inpatientchemo_code_Z ;
   }

   [DataContract(Name = @"BR_Medication", Namespace = "DataAnalysisPlatform")]
   public class SdtBR_Medication_RESTInterface : GxGenericCollectionItem<SdtBR_Medication>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtBR_Medication_RESTInterface( ) : base()
      {
      }

      public SdtBR_Medication_RESTInterface( SdtBR_Medication psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "BR_MedicationID" , Order = 0 )]
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

      [DataMember( Name = "BR_Information_PatientNo" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_Br_information_patientno
      {
         get {
            return sdt.gxTpr_Br_information_patientno ;
         }

         set {
            sdt.gxTpr_Br_information_patientno = value;
         }

      }

      [DataMember( Name = "BR_Medication_RXID" , Order = 3 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Br_medication_rxid
      {
         get {
            return sdt.gxTpr_Br_medication_rxid ;
         }

         set {
            sdt.gxTpr_Br_medication_rxid = (short)(value.HasValue ? value.Value : 0);
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

      [DataMember( Name = "BR_Medication_RXName_Code" , Order = 5 )]
      [GxSeudo()]
      public String gxTpr_Br_medication_rxname_code
      {
         get {
            return sdt.gxTpr_Br_medication_rxname_code ;
         }

         set {
            sdt.gxTpr_Br_medication_rxname_code = value;
         }

      }

      [DataMember( Name = "BR_Medication_RXCode" , Order = 6 )]
      [GxSeudo()]
      public String gxTpr_Br_medication_rxcode
      {
         get {
            return sdt.gxTpr_Br_medication_rxcode ;
         }

         set {
            sdt.gxTpr_Br_medication_rxcode = value;
         }

      }

      [DataMember( Name = "BR_Medication_RXType" , Order = 7 )]
      [GxSeudo()]
      public String gxTpr_Br_medication_rxtype
      {
         get {
            return sdt.gxTpr_Br_medication_rxtype ;
         }

         set {
            sdt.gxTpr_Br_medication_rxtype = value;
         }

      }

      [DataMember( Name = "BR_Medication_RXDose" , Order = 8 )]
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

      [DataMember( Name = "BR_Medication_RXUnit" , Order = 9 )]
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

      [DataMember( Name = "BR_Medication_RXFrequency" , Order = 10 )]
      [GxSeudo()]
      public String gxTpr_Br_medication_rxfrequency
      {
         get {
            return sdt.gxTpr_Br_medication_rxfrequency ;
         }

         set {
            sdt.gxTpr_Br_medication_rxfrequency = value;
         }

      }

      [DataMember( Name = "BR_Medication_RXFrequency_Code" , Order = 11 )]
      [GxSeudo()]
      public String gxTpr_Br_medication_rxfrequency_code
      {
         get {
            return sdt.gxTpr_Br_medication_rxfrequency_code ;
         }

         set {
            sdt.gxTpr_Br_medication_rxfrequency_code = value;
         }

      }

      [DataMember( Name = "BR_Medication_RXQuantity" , Order = 12 )]
      [GxSeudo()]
      public String gxTpr_Br_medication_rxquantity
      {
         get {
            return sdt.gxTpr_Br_medication_rxquantity ;
         }

         set {
            sdt.gxTpr_Br_medication_rxquantity = value;
         }

      }

      [DataMember( Name = "BR_Medication_RXDaysSupply" , Order = 13 )]
      [GxSeudo()]
      public String gxTpr_Br_medication_rxdayssupply
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( sdt.gxTpr_Br_medication_rxdayssupply, 15, 5)) ;
         }

         set {
            sdt.gxTpr_Br_medication_rxdayssupply = NumberUtil.Val( value, ".");
         }

      }

      [DataMember( Name = "BR_Medication_RXRoute" , Order = 14 )]
      [GxSeudo()]
      public String gxTpr_Br_medication_rxroute
      {
         get {
            return sdt.gxTpr_Br_medication_rxroute ;
         }

         set {
            sdt.gxTpr_Br_medication_rxroute = value;
         }

      }

      [DataMember( Name = "BR_Medication_RXRoute_Code" , Order = 15 )]
      [GxSeudo()]
      public String gxTpr_Br_medication_rxroute_code
      {
         get {
            return sdt.gxTpr_Br_medication_rxroute_code ;
         }

         set {
            sdt.gxTpr_Br_medication_rxroute_code = value;
         }

      }

      [DataMember( Name = "BR_Medication_PrescriptionDate" , Order = 16 )]
      [GxSeudo()]
      public String gxTpr_Br_medication_prescriptiondate
      {
         get {
            return DateTimeUtil.DToC2( sdt.gxTpr_Br_medication_prescriptiondate) ;
         }

         set {
            sdt.gxTpr_Br_medication_prescriptiondate = DateTimeUtil.CToD2( value);
         }

      }

      [DataMember( Name = "BR_Medication_AdmitStartDate" , Order = 17 )]
      [GxSeudo()]
      public String gxTpr_Br_medication_admitstartdate
      {
         get {
            return DateTimeUtil.DToC2( sdt.gxTpr_Br_medication_admitstartdate) ;
         }

         set {
            sdt.gxTpr_Br_medication_admitstartdate = DateTimeUtil.CToD2( value);
         }

      }

      [DataMember( Name = "BR_Medication_AdmitEndDate" , Order = 18 )]
      [GxSeudo()]
      public String gxTpr_Br_medication_admitenddate
      {
         get {
            return DateTimeUtil.DToC2( sdt.gxTpr_Br_medication_admitenddate) ;
         }

         set {
            sdt.gxTpr_Br_medication_admitenddate = DateTimeUtil.CToD2( value);
         }

      }

      [DataMember( Name = "BR_Medication_InpatientChemo" , Order = 19 )]
      [GxSeudo()]
      public String gxTpr_Br_medication_inpatientchemo
      {
         get {
            return sdt.gxTpr_Br_medication_inpatientchemo ;
         }

         set {
            sdt.gxTpr_Br_medication_inpatientchemo = value;
         }

      }

      [DataMember( Name = "BR_Medication_InpatientChemo_Code" , Order = 20 )]
      [GxSeudo()]
      public String gxTpr_Br_medication_inpatientchemo_code
      {
         get {
            return sdt.gxTpr_Br_medication_inpatientchemo_code ;
         }

         set {
            sdt.gxTpr_Br_medication_inpatientchemo_code = value;
         }

      }

      public SdtBR_Medication sdt
      {
         get {
            return (SdtBR_Medication)Sdt ;
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
            sdt = new SdtBR_Medication() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 21 )]
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
