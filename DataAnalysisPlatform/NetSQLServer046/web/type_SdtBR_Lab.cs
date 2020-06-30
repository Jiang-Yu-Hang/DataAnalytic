/*
               File: type_SdtBR_Lab
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:56:34.62
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
   [XmlRoot(ElementName = "BR_Lab" )]
   [XmlType(TypeName =  "BR_Lab" , Namespace = "DataAnalysisPlatform" )]
   [Serializable]
   public class SdtBR_Lab : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtBR_Lab( )
      {
      }

      public SdtBR_Lab( IGxContext context )
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

      public void Load( long AV101BR_LabID )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(long)AV101BR_LabID});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"BR_LabID", typeof(long)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "BR_Lab");
         metadata.Set("BT", "BR_Lab");
         metadata.Set("PK", "[ \"BR_LabID\" ]");
         metadata.Set("PKAssigned", "[ \"BR_LabID\" ]");
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
         state.Add("gxTpr_Br_labid_Z");
         state.Add("gxTpr_Br_encounterid_Z");
         state.Add("gxTpr_Br_information_patientno_Z");
         state.Add("gxTpr_Br_lab_sampleid_Z");
         state.Add("gxTpr_Br_lab_testid_Z");
         state.Add("gxTpr_Br_lab_testcode_Z");
         state.Add("gxTpr_Br_lab_testname_Z");
         state.Add("gxTpr_Br_lab_testengname_Z");
         state.Add("gxTpr_Br_lab_age_Z");
         state.Add("gxTpr_Br_lab_diag_Z");
         state.Add("gxTpr_Br_lab_specimendate_Z_Nullable");
         state.Add("gxTpr_Br_lab_receivingtime_Z_Nullable");
         state.Add("gxTpr_Br_lab_reporttime_Z_Nullable");
         state.Add("gxTpr_Br_lab_specimensource_Z");
         state.Add("gxTpr_Br_lab_specimensource_code_Z");
         state.Add("gxTpr_Br_lab_resultqual_Z");
         state.Add("gxTpr_Br_lab_resultqual_code_Z");
         state.Add("gxTpr_Br_lab_resultnum_Z");
         state.Add("gxTpr_Br_lab_resultunit_Z");
         state.Add("gxTpr_Br_lab_abnind_Z");
         state.Add("gxTpr_Br_lab_abnind_code_Z");
         state.Add("gxTpr_Br_lab_normrangelow_Z");
         state.Add("gxTpr_Br_lab_normrangehigh_Z");
         state.Add("gxTpr_Br_lab_testmethod_Z");
         state.Add("gxTpr_Br_lab_instrumentname_Z");
         state.Add("gxTpr_Br_lab_instrumentcode_Z");
         state.Add("gxTpr_Br_sampleid_Z");
         state.Add("gxTpr_Br_information_patientno_N");
         state.Add("gxTpr_Br_lab_sampleid_N");
         state.Add("gxTpr_Br_lab_testid_N");
         state.Add("gxTpr_Br_lab_testcode_N");
         state.Add("gxTpr_Br_lab_testname_N");
         state.Add("gxTpr_Br_lab_testengname_N");
         state.Add("gxTpr_Br_lab_age_N");
         state.Add("gxTpr_Br_lab_diag_N");
         state.Add("gxTpr_Br_lab_specimendate_N");
         state.Add("gxTpr_Br_lab_receivingtime_N");
         state.Add("gxTpr_Br_lab_reporttime_N");
         state.Add("gxTpr_Br_lab_specimensource_N");
         state.Add("gxTpr_Br_lab_specimensource_code_N");
         state.Add("gxTpr_Br_lab_resultqual_N");
         state.Add("gxTpr_Br_lab_resultqual_code_N");
         state.Add("gxTpr_Br_lab_resultnum_N");
         state.Add("gxTpr_Br_lab_resultunit_N");
         state.Add("gxTpr_Br_lab_abnind_N");
         state.Add("gxTpr_Br_lab_abnind_code_N");
         state.Add("gxTpr_Br_lab_normrangelow_N");
         state.Add("gxTpr_Br_lab_normrangehigh_N");
         state.Add("gxTpr_Br_lab_testmethod_N");
         state.Add("gxTpr_Br_lab_instrumentname_N");
         state.Add("gxTpr_Br_lab_instrumentcode_N");
         state.Add("gxTpr_Br_sampleid_N");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtBR_Lab sdt ;
         sdt = (SdtBR_Lab)(source);
         gxTv_SdtBR_Lab_Br_labid = sdt.gxTv_SdtBR_Lab_Br_labid ;
         gxTv_SdtBR_Lab_Br_encounterid = sdt.gxTv_SdtBR_Lab_Br_encounterid ;
         gxTv_SdtBR_Lab_Br_information_patientno = sdt.gxTv_SdtBR_Lab_Br_information_patientno ;
         gxTv_SdtBR_Lab_Br_lab_sampleid = sdt.gxTv_SdtBR_Lab_Br_lab_sampleid ;
         gxTv_SdtBR_Lab_Br_lab_testid = sdt.gxTv_SdtBR_Lab_Br_lab_testid ;
         gxTv_SdtBR_Lab_Br_lab_testcode = sdt.gxTv_SdtBR_Lab_Br_lab_testcode ;
         gxTv_SdtBR_Lab_Br_lab_testname = sdt.gxTv_SdtBR_Lab_Br_lab_testname ;
         gxTv_SdtBR_Lab_Br_lab_testengname = sdt.gxTv_SdtBR_Lab_Br_lab_testengname ;
         gxTv_SdtBR_Lab_Br_lab_age = sdt.gxTv_SdtBR_Lab_Br_lab_age ;
         gxTv_SdtBR_Lab_Br_lab_diag = sdt.gxTv_SdtBR_Lab_Br_lab_diag ;
         gxTv_SdtBR_Lab_Br_lab_specimendate = sdt.gxTv_SdtBR_Lab_Br_lab_specimendate ;
         gxTv_SdtBR_Lab_Br_lab_receivingtime = sdt.gxTv_SdtBR_Lab_Br_lab_receivingtime ;
         gxTv_SdtBR_Lab_Br_lab_reporttime = sdt.gxTv_SdtBR_Lab_Br_lab_reporttime ;
         gxTv_SdtBR_Lab_Br_lab_specimensource = sdt.gxTv_SdtBR_Lab_Br_lab_specimensource ;
         gxTv_SdtBR_Lab_Br_lab_specimensource_code = sdt.gxTv_SdtBR_Lab_Br_lab_specimensource_code ;
         gxTv_SdtBR_Lab_Br_lab_resultqual = sdt.gxTv_SdtBR_Lab_Br_lab_resultqual ;
         gxTv_SdtBR_Lab_Br_lab_resultqual_code = sdt.gxTv_SdtBR_Lab_Br_lab_resultqual_code ;
         gxTv_SdtBR_Lab_Br_lab_resultnum = sdt.gxTv_SdtBR_Lab_Br_lab_resultnum ;
         gxTv_SdtBR_Lab_Br_lab_resultunit = sdt.gxTv_SdtBR_Lab_Br_lab_resultunit ;
         gxTv_SdtBR_Lab_Br_lab_abnind = sdt.gxTv_SdtBR_Lab_Br_lab_abnind ;
         gxTv_SdtBR_Lab_Br_lab_abnind_code = sdt.gxTv_SdtBR_Lab_Br_lab_abnind_code ;
         gxTv_SdtBR_Lab_Br_lab_normrangelow = sdt.gxTv_SdtBR_Lab_Br_lab_normrangelow ;
         gxTv_SdtBR_Lab_Br_lab_normrangehigh = sdt.gxTv_SdtBR_Lab_Br_lab_normrangehigh ;
         gxTv_SdtBR_Lab_Br_lab_testmethod = sdt.gxTv_SdtBR_Lab_Br_lab_testmethod ;
         gxTv_SdtBR_Lab_Br_lab_instrumentname = sdt.gxTv_SdtBR_Lab_Br_lab_instrumentname ;
         gxTv_SdtBR_Lab_Br_lab_instrumentcode = sdt.gxTv_SdtBR_Lab_Br_lab_instrumentcode ;
         gxTv_SdtBR_Lab_Br_sampleid = sdt.gxTv_SdtBR_Lab_Br_sampleid ;
         gxTv_SdtBR_Lab_Mode = sdt.gxTv_SdtBR_Lab_Mode ;
         gxTv_SdtBR_Lab_Initialized = sdt.gxTv_SdtBR_Lab_Initialized ;
         gxTv_SdtBR_Lab_Br_labid_Z = sdt.gxTv_SdtBR_Lab_Br_labid_Z ;
         gxTv_SdtBR_Lab_Br_encounterid_Z = sdt.gxTv_SdtBR_Lab_Br_encounterid_Z ;
         gxTv_SdtBR_Lab_Br_information_patientno_Z = sdt.gxTv_SdtBR_Lab_Br_information_patientno_Z ;
         gxTv_SdtBR_Lab_Br_lab_sampleid_Z = sdt.gxTv_SdtBR_Lab_Br_lab_sampleid_Z ;
         gxTv_SdtBR_Lab_Br_lab_testid_Z = sdt.gxTv_SdtBR_Lab_Br_lab_testid_Z ;
         gxTv_SdtBR_Lab_Br_lab_testcode_Z = sdt.gxTv_SdtBR_Lab_Br_lab_testcode_Z ;
         gxTv_SdtBR_Lab_Br_lab_testname_Z = sdt.gxTv_SdtBR_Lab_Br_lab_testname_Z ;
         gxTv_SdtBR_Lab_Br_lab_testengname_Z = sdt.gxTv_SdtBR_Lab_Br_lab_testengname_Z ;
         gxTv_SdtBR_Lab_Br_lab_age_Z = sdt.gxTv_SdtBR_Lab_Br_lab_age_Z ;
         gxTv_SdtBR_Lab_Br_lab_diag_Z = sdt.gxTv_SdtBR_Lab_Br_lab_diag_Z ;
         gxTv_SdtBR_Lab_Br_lab_specimendate_Z = sdt.gxTv_SdtBR_Lab_Br_lab_specimendate_Z ;
         gxTv_SdtBR_Lab_Br_lab_receivingtime_Z = sdt.gxTv_SdtBR_Lab_Br_lab_receivingtime_Z ;
         gxTv_SdtBR_Lab_Br_lab_reporttime_Z = sdt.gxTv_SdtBR_Lab_Br_lab_reporttime_Z ;
         gxTv_SdtBR_Lab_Br_lab_specimensource_Z = sdt.gxTv_SdtBR_Lab_Br_lab_specimensource_Z ;
         gxTv_SdtBR_Lab_Br_lab_specimensource_code_Z = sdt.gxTv_SdtBR_Lab_Br_lab_specimensource_code_Z ;
         gxTv_SdtBR_Lab_Br_lab_resultqual_Z = sdt.gxTv_SdtBR_Lab_Br_lab_resultqual_Z ;
         gxTv_SdtBR_Lab_Br_lab_resultqual_code_Z = sdt.gxTv_SdtBR_Lab_Br_lab_resultqual_code_Z ;
         gxTv_SdtBR_Lab_Br_lab_resultnum_Z = sdt.gxTv_SdtBR_Lab_Br_lab_resultnum_Z ;
         gxTv_SdtBR_Lab_Br_lab_resultunit_Z = sdt.gxTv_SdtBR_Lab_Br_lab_resultunit_Z ;
         gxTv_SdtBR_Lab_Br_lab_abnind_Z = sdt.gxTv_SdtBR_Lab_Br_lab_abnind_Z ;
         gxTv_SdtBR_Lab_Br_lab_abnind_code_Z = sdt.gxTv_SdtBR_Lab_Br_lab_abnind_code_Z ;
         gxTv_SdtBR_Lab_Br_lab_normrangelow_Z = sdt.gxTv_SdtBR_Lab_Br_lab_normrangelow_Z ;
         gxTv_SdtBR_Lab_Br_lab_normrangehigh_Z = sdt.gxTv_SdtBR_Lab_Br_lab_normrangehigh_Z ;
         gxTv_SdtBR_Lab_Br_lab_testmethod_Z = sdt.gxTv_SdtBR_Lab_Br_lab_testmethod_Z ;
         gxTv_SdtBR_Lab_Br_lab_instrumentname_Z = sdt.gxTv_SdtBR_Lab_Br_lab_instrumentname_Z ;
         gxTv_SdtBR_Lab_Br_lab_instrumentcode_Z = sdt.gxTv_SdtBR_Lab_Br_lab_instrumentcode_Z ;
         gxTv_SdtBR_Lab_Br_sampleid_Z = sdt.gxTv_SdtBR_Lab_Br_sampleid_Z ;
         gxTv_SdtBR_Lab_Br_information_patientno_N = sdt.gxTv_SdtBR_Lab_Br_information_patientno_N ;
         gxTv_SdtBR_Lab_Br_lab_sampleid_N = sdt.gxTv_SdtBR_Lab_Br_lab_sampleid_N ;
         gxTv_SdtBR_Lab_Br_lab_testid_N = sdt.gxTv_SdtBR_Lab_Br_lab_testid_N ;
         gxTv_SdtBR_Lab_Br_lab_testcode_N = sdt.gxTv_SdtBR_Lab_Br_lab_testcode_N ;
         gxTv_SdtBR_Lab_Br_lab_testname_N = sdt.gxTv_SdtBR_Lab_Br_lab_testname_N ;
         gxTv_SdtBR_Lab_Br_lab_testengname_N = sdt.gxTv_SdtBR_Lab_Br_lab_testengname_N ;
         gxTv_SdtBR_Lab_Br_lab_age_N = sdt.gxTv_SdtBR_Lab_Br_lab_age_N ;
         gxTv_SdtBR_Lab_Br_lab_diag_N = sdt.gxTv_SdtBR_Lab_Br_lab_diag_N ;
         gxTv_SdtBR_Lab_Br_lab_specimendate_N = sdt.gxTv_SdtBR_Lab_Br_lab_specimendate_N ;
         gxTv_SdtBR_Lab_Br_lab_receivingtime_N = sdt.gxTv_SdtBR_Lab_Br_lab_receivingtime_N ;
         gxTv_SdtBR_Lab_Br_lab_reporttime_N = sdt.gxTv_SdtBR_Lab_Br_lab_reporttime_N ;
         gxTv_SdtBR_Lab_Br_lab_specimensource_N = sdt.gxTv_SdtBR_Lab_Br_lab_specimensource_N ;
         gxTv_SdtBR_Lab_Br_lab_specimensource_code_N = sdt.gxTv_SdtBR_Lab_Br_lab_specimensource_code_N ;
         gxTv_SdtBR_Lab_Br_lab_resultqual_N = sdt.gxTv_SdtBR_Lab_Br_lab_resultqual_N ;
         gxTv_SdtBR_Lab_Br_lab_resultqual_code_N = sdt.gxTv_SdtBR_Lab_Br_lab_resultqual_code_N ;
         gxTv_SdtBR_Lab_Br_lab_resultnum_N = sdt.gxTv_SdtBR_Lab_Br_lab_resultnum_N ;
         gxTv_SdtBR_Lab_Br_lab_resultunit_N = sdt.gxTv_SdtBR_Lab_Br_lab_resultunit_N ;
         gxTv_SdtBR_Lab_Br_lab_abnind_N = sdt.gxTv_SdtBR_Lab_Br_lab_abnind_N ;
         gxTv_SdtBR_Lab_Br_lab_abnind_code_N = sdt.gxTv_SdtBR_Lab_Br_lab_abnind_code_N ;
         gxTv_SdtBR_Lab_Br_lab_normrangelow_N = sdt.gxTv_SdtBR_Lab_Br_lab_normrangelow_N ;
         gxTv_SdtBR_Lab_Br_lab_normrangehigh_N = sdt.gxTv_SdtBR_Lab_Br_lab_normrangehigh_N ;
         gxTv_SdtBR_Lab_Br_lab_testmethod_N = sdt.gxTv_SdtBR_Lab_Br_lab_testmethod_N ;
         gxTv_SdtBR_Lab_Br_lab_instrumentname_N = sdt.gxTv_SdtBR_Lab_Br_lab_instrumentname_N ;
         gxTv_SdtBR_Lab_Br_lab_instrumentcode_N = sdt.gxTv_SdtBR_Lab_Br_lab_instrumentcode_N ;
         gxTv_SdtBR_Lab_Br_sampleid_N = sdt.gxTv_SdtBR_Lab_Br_sampleid_N ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("BR_LabID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Lab_Br_labid), 18, 0)), false);
         AddObjectProperty("BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Lab_Br_encounterid), 18, 0)), false);
         AddObjectProperty("BR_Information_PatientNo", gxTv_SdtBR_Lab_Br_information_patientno, false);
         AddObjectProperty("BR_Information_PatientNo_N", gxTv_SdtBR_Lab_Br_information_patientno_N, false);
         AddObjectProperty("BR_Lab_SampleID", gxTv_SdtBR_Lab_Br_lab_sampleid, false);
         AddObjectProperty("BR_Lab_SampleID_N", gxTv_SdtBR_Lab_Br_lab_sampleid_N, false);
         AddObjectProperty("BR_Lab_TestID", gxTv_SdtBR_Lab_Br_lab_testid, false);
         AddObjectProperty("BR_Lab_TestID_N", gxTv_SdtBR_Lab_Br_lab_testid_N, false);
         AddObjectProperty("BR_Lab_TestCode", gxTv_SdtBR_Lab_Br_lab_testcode, false);
         AddObjectProperty("BR_Lab_TestCode_N", gxTv_SdtBR_Lab_Br_lab_testcode_N, false);
         AddObjectProperty("BR_Lab_TestName", gxTv_SdtBR_Lab_Br_lab_testname, false);
         AddObjectProperty("BR_Lab_TestName_N", gxTv_SdtBR_Lab_Br_lab_testname_N, false);
         AddObjectProperty("BR_Lab_TestEngName", gxTv_SdtBR_Lab_Br_lab_testengname, false);
         AddObjectProperty("BR_Lab_TestEngName_N", gxTv_SdtBR_Lab_Br_lab_testengname_N, false);
         AddObjectProperty("BR_Lab_Age", gxTv_SdtBR_Lab_Br_lab_age, false);
         AddObjectProperty("BR_Lab_Age_N", gxTv_SdtBR_Lab_Br_lab_age_N, false);
         AddObjectProperty("BR_Lab_Diag", gxTv_SdtBR_Lab_Br_lab_diag, false);
         AddObjectProperty("BR_Lab_Diag_N", gxTv_SdtBR_Lab_Br_lab_diag_N, false);
         datetime_STZ = gxTv_SdtBR_Lab_Br_lab_specimendate;
         sDateCnv = "";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "T";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + ":";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + ":";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         AddObjectProperty("BR_Lab_SpecimenDate", sDateCnv, false);
         AddObjectProperty("BR_Lab_SpecimenDate_N", gxTv_SdtBR_Lab_Br_lab_specimendate_N, false);
         datetime_STZ = gxTv_SdtBR_Lab_Br_lab_receivingtime;
         sDateCnv = "";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "T";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + ":";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + ":";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         AddObjectProperty("BR_Lab_ReceivingTime", sDateCnv, false);
         AddObjectProperty("BR_Lab_ReceivingTime_N", gxTv_SdtBR_Lab_Br_lab_receivingtime_N, false);
         datetime_STZ = gxTv_SdtBR_Lab_Br_lab_reporttime;
         sDateCnv = "";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "T";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + ":";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + ":";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         AddObjectProperty("BR_Lab_ReportTime", sDateCnv, false);
         AddObjectProperty("BR_Lab_ReportTime_N", gxTv_SdtBR_Lab_Br_lab_reporttime_N, false);
         AddObjectProperty("BR_Lab_SpecimenSource", gxTv_SdtBR_Lab_Br_lab_specimensource, false);
         AddObjectProperty("BR_Lab_SpecimenSource_N", gxTv_SdtBR_Lab_Br_lab_specimensource_N, false);
         AddObjectProperty("BR_Lab_SpecimenSource_Code", gxTv_SdtBR_Lab_Br_lab_specimensource_code, false);
         AddObjectProperty("BR_Lab_SpecimenSource_Code_N", gxTv_SdtBR_Lab_Br_lab_specimensource_code_N, false);
         AddObjectProperty("BR_Lab_ResultQual", gxTv_SdtBR_Lab_Br_lab_resultqual, false);
         AddObjectProperty("BR_Lab_ResultQual_N", gxTv_SdtBR_Lab_Br_lab_resultqual_N, false);
         AddObjectProperty("BR_Lab_ResultQual_Code", gxTv_SdtBR_Lab_Br_lab_resultqual_code, false);
         AddObjectProperty("BR_Lab_ResultQual_Code_N", gxTv_SdtBR_Lab_Br_lab_resultqual_code_N, false);
         AddObjectProperty("BR_Lab_ResultNum", gxTv_SdtBR_Lab_Br_lab_resultnum, false);
         AddObjectProperty("BR_Lab_ResultNum_N", gxTv_SdtBR_Lab_Br_lab_resultnum_N, false);
         AddObjectProperty("BR_Lab_ResultUnit", gxTv_SdtBR_Lab_Br_lab_resultunit, false);
         AddObjectProperty("BR_Lab_ResultUnit_N", gxTv_SdtBR_Lab_Br_lab_resultunit_N, false);
         AddObjectProperty("BR_Lab_AbnInd", gxTv_SdtBR_Lab_Br_lab_abnind, false);
         AddObjectProperty("BR_Lab_AbnInd_N", gxTv_SdtBR_Lab_Br_lab_abnind_N, false);
         AddObjectProperty("BR_Lab_AbnInd_Code", gxTv_SdtBR_Lab_Br_lab_abnind_code, false);
         AddObjectProperty("BR_Lab_AbnInd_Code_N", gxTv_SdtBR_Lab_Br_lab_abnind_code_N, false);
         AddObjectProperty("BR_Lab_NormRangeLow", gxTv_SdtBR_Lab_Br_lab_normrangelow, false);
         AddObjectProperty("BR_Lab_NormRangeLow_N", gxTv_SdtBR_Lab_Br_lab_normrangelow_N, false);
         AddObjectProperty("BR_Lab_NormRangeHigh", gxTv_SdtBR_Lab_Br_lab_normrangehigh, false);
         AddObjectProperty("BR_Lab_NormRangeHigh_N", gxTv_SdtBR_Lab_Br_lab_normrangehigh_N, false);
         AddObjectProperty("BR_Lab_TestMethod", gxTv_SdtBR_Lab_Br_lab_testmethod, false);
         AddObjectProperty("BR_Lab_TestMethod_N", gxTv_SdtBR_Lab_Br_lab_testmethod_N, false);
         AddObjectProperty("BR_Lab_InstrumentName", gxTv_SdtBR_Lab_Br_lab_instrumentname, false);
         AddObjectProperty("BR_Lab_InstrumentName_N", gxTv_SdtBR_Lab_Br_lab_instrumentname_N, false);
         AddObjectProperty("BR_Lab_InstrumentCode", gxTv_SdtBR_Lab_Br_lab_instrumentcode, false);
         AddObjectProperty("BR_Lab_InstrumentCode_N", gxTv_SdtBR_Lab_Br_lab_instrumentcode_N, false);
         AddObjectProperty("BR_SampleId", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Lab_Br_sampleid), 18, 0)), false);
         AddObjectProperty("BR_SampleId_N", gxTv_SdtBR_Lab_Br_sampleid_N, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtBR_Lab_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtBR_Lab_Initialized, false);
            AddObjectProperty("BR_LabID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Lab_Br_labid_Z), 18, 0)), false);
            AddObjectProperty("BR_EncounterID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Lab_Br_encounterid_Z), 18, 0)), false);
            AddObjectProperty("BR_Information_PatientNo_Z", gxTv_SdtBR_Lab_Br_information_patientno_Z, false);
            AddObjectProperty("BR_Lab_SampleID_Z", gxTv_SdtBR_Lab_Br_lab_sampleid_Z, false);
            AddObjectProperty("BR_Lab_TestID_Z", gxTv_SdtBR_Lab_Br_lab_testid_Z, false);
            AddObjectProperty("BR_Lab_TestCode_Z", gxTv_SdtBR_Lab_Br_lab_testcode_Z, false);
            AddObjectProperty("BR_Lab_TestName_Z", gxTv_SdtBR_Lab_Br_lab_testname_Z, false);
            AddObjectProperty("BR_Lab_TestEngName_Z", gxTv_SdtBR_Lab_Br_lab_testengname_Z, false);
            AddObjectProperty("BR_Lab_Age_Z", gxTv_SdtBR_Lab_Br_lab_age_Z, false);
            AddObjectProperty("BR_Lab_Diag_Z", gxTv_SdtBR_Lab_Br_lab_diag_Z, false);
            datetime_STZ = gxTv_SdtBR_Lab_Br_lab_specimendate_Z;
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "T";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            AddObjectProperty("BR_Lab_SpecimenDate_Z", sDateCnv, false);
            datetime_STZ = gxTv_SdtBR_Lab_Br_lab_receivingtime_Z;
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "T";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            AddObjectProperty("BR_Lab_ReceivingTime_Z", sDateCnv, false);
            datetime_STZ = gxTv_SdtBR_Lab_Br_lab_reporttime_Z;
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "T";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            AddObjectProperty("BR_Lab_ReportTime_Z", sDateCnv, false);
            AddObjectProperty("BR_Lab_SpecimenSource_Z", gxTv_SdtBR_Lab_Br_lab_specimensource_Z, false);
            AddObjectProperty("BR_Lab_SpecimenSource_Code_Z", gxTv_SdtBR_Lab_Br_lab_specimensource_code_Z, false);
            AddObjectProperty("BR_Lab_ResultQual_Z", gxTv_SdtBR_Lab_Br_lab_resultqual_Z, false);
            AddObjectProperty("BR_Lab_ResultQual_Code_Z", gxTv_SdtBR_Lab_Br_lab_resultqual_code_Z, false);
            AddObjectProperty("BR_Lab_ResultNum_Z", gxTv_SdtBR_Lab_Br_lab_resultnum_Z, false);
            AddObjectProperty("BR_Lab_ResultUnit_Z", gxTv_SdtBR_Lab_Br_lab_resultunit_Z, false);
            AddObjectProperty("BR_Lab_AbnInd_Z", gxTv_SdtBR_Lab_Br_lab_abnind_Z, false);
            AddObjectProperty("BR_Lab_AbnInd_Code_Z", gxTv_SdtBR_Lab_Br_lab_abnind_code_Z, false);
            AddObjectProperty("BR_Lab_NormRangeLow_Z", gxTv_SdtBR_Lab_Br_lab_normrangelow_Z, false);
            AddObjectProperty("BR_Lab_NormRangeHigh_Z", gxTv_SdtBR_Lab_Br_lab_normrangehigh_Z, false);
            AddObjectProperty("BR_Lab_TestMethod_Z", gxTv_SdtBR_Lab_Br_lab_testmethod_Z, false);
            AddObjectProperty("BR_Lab_InstrumentName_Z", gxTv_SdtBR_Lab_Br_lab_instrumentname_Z, false);
            AddObjectProperty("BR_Lab_InstrumentCode_Z", gxTv_SdtBR_Lab_Br_lab_instrumentcode_Z, false);
            AddObjectProperty("BR_SampleId_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Lab_Br_sampleid_Z), 18, 0)), false);
            AddObjectProperty("BR_Information_PatientNo_N", gxTv_SdtBR_Lab_Br_information_patientno_N, false);
            AddObjectProperty("BR_Lab_SampleID_N", gxTv_SdtBR_Lab_Br_lab_sampleid_N, false);
            AddObjectProperty("BR_Lab_TestID_N", gxTv_SdtBR_Lab_Br_lab_testid_N, false);
            AddObjectProperty("BR_Lab_TestCode_N", gxTv_SdtBR_Lab_Br_lab_testcode_N, false);
            AddObjectProperty("BR_Lab_TestName_N", gxTv_SdtBR_Lab_Br_lab_testname_N, false);
            AddObjectProperty("BR_Lab_TestEngName_N", gxTv_SdtBR_Lab_Br_lab_testengname_N, false);
            AddObjectProperty("BR_Lab_Age_N", gxTv_SdtBR_Lab_Br_lab_age_N, false);
            AddObjectProperty("BR_Lab_Diag_N", gxTv_SdtBR_Lab_Br_lab_diag_N, false);
            AddObjectProperty("BR_Lab_SpecimenDate_N", gxTv_SdtBR_Lab_Br_lab_specimendate_N, false);
            AddObjectProperty("BR_Lab_ReceivingTime_N", gxTv_SdtBR_Lab_Br_lab_receivingtime_N, false);
            AddObjectProperty("BR_Lab_ReportTime_N", gxTv_SdtBR_Lab_Br_lab_reporttime_N, false);
            AddObjectProperty("BR_Lab_SpecimenSource_N", gxTv_SdtBR_Lab_Br_lab_specimensource_N, false);
            AddObjectProperty("BR_Lab_SpecimenSource_Code_N", gxTv_SdtBR_Lab_Br_lab_specimensource_code_N, false);
            AddObjectProperty("BR_Lab_ResultQual_N", gxTv_SdtBR_Lab_Br_lab_resultqual_N, false);
            AddObjectProperty("BR_Lab_ResultQual_Code_N", gxTv_SdtBR_Lab_Br_lab_resultqual_code_N, false);
            AddObjectProperty("BR_Lab_ResultNum_N", gxTv_SdtBR_Lab_Br_lab_resultnum_N, false);
            AddObjectProperty("BR_Lab_ResultUnit_N", gxTv_SdtBR_Lab_Br_lab_resultunit_N, false);
            AddObjectProperty("BR_Lab_AbnInd_N", gxTv_SdtBR_Lab_Br_lab_abnind_N, false);
            AddObjectProperty("BR_Lab_AbnInd_Code_N", gxTv_SdtBR_Lab_Br_lab_abnind_code_N, false);
            AddObjectProperty("BR_Lab_NormRangeLow_N", gxTv_SdtBR_Lab_Br_lab_normrangelow_N, false);
            AddObjectProperty("BR_Lab_NormRangeHigh_N", gxTv_SdtBR_Lab_Br_lab_normrangehigh_N, false);
            AddObjectProperty("BR_Lab_TestMethod_N", gxTv_SdtBR_Lab_Br_lab_testmethod_N, false);
            AddObjectProperty("BR_Lab_InstrumentName_N", gxTv_SdtBR_Lab_Br_lab_instrumentname_N, false);
            AddObjectProperty("BR_Lab_InstrumentCode_N", gxTv_SdtBR_Lab_Br_lab_instrumentcode_N, false);
            AddObjectProperty("BR_SampleId_N", gxTv_SdtBR_Lab_Br_sampleid_N, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtBR_Lab sdt )
      {
         if ( sdt.IsDirty("BR_LabID") )
         {
            gxTv_SdtBR_Lab_Br_labid = sdt.gxTv_SdtBR_Lab_Br_labid ;
         }
         if ( sdt.IsDirty("BR_EncounterID") )
         {
            gxTv_SdtBR_Lab_Br_encounterid = sdt.gxTv_SdtBR_Lab_Br_encounterid ;
         }
         if ( sdt.IsDirty("BR_Information_PatientNo") )
         {
            gxTv_SdtBR_Lab_Br_information_patientno = sdt.gxTv_SdtBR_Lab_Br_information_patientno ;
         }
         if ( sdt.IsDirty("BR_Lab_SampleID") )
         {
            gxTv_SdtBR_Lab_Br_lab_sampleid = sdt.gxTv_SdtBR_Lab_Br_lab_sampleid ;
         }
         if ( sdt.IsDirty("BR_Lab_TestID") )
         {
            gxTv_SdtBR_Lab_Br_lab_testid = sdt.gxTv_SdtBR_Lab_Br_lab_testid ;
         }
         if ( sdt.IsDirty("BR_Lab_TestCode") )
         {
            gxTv_SdtBR_Lab_Br_lab_testcode = sdt.gxTv_SdtBR_Lab_Br_lab_testcode ;
         }
         if ( sdt.IsDirty("BR_Lab_TestName") )
         {
            gxTv_SdtBR_Lab_Br_lab_testname = sdt.gxTv_SdtBR_Lab_Br_lab_testname ;
         }
         if ( sdt.IsDirty("BR_Lab_TestEngName") )
         {
            gxTv_SdtBR_Lab_Br_lab_testengname = sdt.gxTv_SdtBR_Lab_Br_lab_testengname ;
         }
         if ( sdt.IsDirty("BR_Lab_Age") )
         {
            gxTv_SdtBR_Lab_Br_lab_age = sdt.gxTv_SdtBR_Lab_Br_lab_age ;
         }
         if ( sdt.IsDirty("BR_Lab_Diag") )
         {
            gxTv_SdtBR_Lab_Br_lab_diag = sdt.gxTv_SdtBR_Lab_Br_lab_diag ;
         }
         if ( sdt.IsDirty("BR_Lab_SpecimenDate") )
         {
            gxTv_SdtBR_Lab_Br_lab_specimendate = sdt.gxTv_SdtBR_Lab_Br_lab_specimendate ;
         }
         if ( sdt.IsDirty("BR_Lab_ReceivingTime") )
         {
            gxTv_SdtBR_Lab_Br_lab_receivingtime = sdt.gxTv_SdtBR_Lab_Br_lab_receivingtime ;
         }
         if ( sdt.IsDirty("BR_Lab_ReportTime") )
         {
            gxTv_SdtBR_Lab_Br_lab_reporttime = sdt.gxTv_SdtBR_Lab_Br_lab_reporttime ;
         }
         if ( sdt.IsDirty("BR_Lab_SpecimenSource") )
         {
            gxTv_SdtBR_Lab_Br_lab_specimensource = sdt.gxTv_SdtBR_Lab_Br_lab_specimensource ;
         }
         if ( sdt.IsDirty("BR_Lab_SpecimenSource_Code") )
         {
            gxTv_SdtBR_Lab_Br_lab_specimensource_code = sdt.gxTv_SdtBR_Lab_Br_lab_specimensource_code ;
         }
         if ( sdt.IsDirty("BR_Lab_ResultQual") )
         {
            gxTv_SdtBR_Lab_Br_lab_resultqual = sdt.gxTv_SdtBR_Lab_Br_lab_resultqual ;
         }
         if ( sdt.IsDirty("BR_Lab_ResultQual_Code") )
         {
            gxTv_SdtBR_Lab_Br_lab_resultqual_code = sdt.gxTv_SdtBR_Lab_Br_lab_resultqual_code ;
         }
         if ( sdt.IsDirty("BR_Lab_ResultNum") )
         {
            gxTv_SdtBR_Lab_Br_lab_resultnum = sdt.gxTv_SdtBR_Lab_Br_lab_resultnum ;
         }
         if ( sdt.IsDirty("BR_Lab_ResultUnit") )
         {
            gxTv_SdtBR_Lab_Br_lab_resultunit = sdt.gxTv_SdtBR_Lab_Br_lab_resultunit ;
         }
         if ( sdt.IsDirty("BR_Lab_AbnInd") )
         {
            gxTv_SdtBR_Lab_Br_lab_abnind = sdt.gxTv_SdtBR_Lab_Br_lab_abnind ;
         }
         if ( sdt.IsDirty("BR_Lab_AbnInd_Code") )
         {
            gxTv_SdtBR_Lab_Br_lab_abnind_code = sdt.gxTv_SdtBR_Lab_Br_lab_abnind_code ;
         }
         if ( sdt.IsDirty("BR_Lab_NormRangeLow") )
         {
            gxTv_SdtBR_Lab_Br_lab_normrangelow = sdt.gxTv_SdtBR_Lab_Br_lab_normrangelow ;
         }
         if ( sdt.IsDirty("BR_Lab_NormRangeHigh") )
         {
            gxTv_SdtBR_Lab_Br_lab_normrangehigh = sdt.gxTv_SdtBR_Lab_Br_lab_normrangehigh ;
         }
         if ( sdt.IsDirty("BR_Lab_TestMethod") )
         {
            gxTv_SdtBR_Lab_Br_lab_testmethod = sdt.gxTv_SdtBR_Lab_Br_lab_testmethod ;
         }
         if ( sdt.IsDirty("BR_Lab_InstrumentName") )
         {
            gxTv_SdtBR_Lab_Br_lab_instrumentname = sdt.gxTv_SdtBR_Lab_Br_lab_instrumentname ;
         }
         if ( sdt.IsDirty("BR_Lab_InstrumentCode") )
         {
            gxTv_SdtBR_Lab_Br_lab_instrumentcode = sdt.gxTv_SdtBR_Lab_Br_lab_instrumentcode ;
         }
         if ( sdt.IsDirty("BR_SampleId") )
         {
            gxTv_SdtBR_Lab_Br_sampleid = sdt.gxTv_SdtBR_Lab_Br_sampleid ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "BR_LabID" )]
      [  XmlElement( ElementName = "BR_LabID"   )]
      public long gxTpr_Br_labid
      {
         get {
            return gxTv_SdtBR_Lab_Br_labid ;
         }

         set {
            if ( gxTv_SdtBR_Lab_Br_labid != value )
            {
               gxTv_SdtBR_Lab_Mode = "INS";
               this.gxTv_SdtBR_Lab_Br_labid_Z_SetNull( );
               this.gxTv_SdtBR_Lab_Br_encounterid_Z_SetNull( );
               this.gxTv_SdtBR_Lab_Br_information_patientno_Z_SetNull( );
               this.gxTv_SdtBR_Lab_Br_lab_sampleid_Z_SetNull( );
               this.gxTv_SdtBR_Lab_Br_lab_testid_Z_SetNull( );
               this.gxTv_SdtBR_Lab_Br_lab_testcode_Z_SetNull( );
               this.gxTv_SdtBR_Lab_Br_lab_testname_Z_SetNull( );
               this.gxTv_SdtBR_Lab_Br_lab_testengname_Z_SetNull( );
               this.gxTv_SdtBR_Lab_Br_lab_age_Z_SetNull( );
               this.gxTv_SdtBR_Lab_Br_lab_diag_Z_SetNull( );
               this.gxTv_SdtBR_Lab_Br_lab_specimendate_Z_SetNull( );
               this.gxTv_SdtBR_Lab_Br_lab_receivingtime_Z_SetNull( );
               this.gxTv_SdtBR_Lab_Br_lab_reporttime_Z_SetNull( );
               this.gxTv_SdtBR_Lab_Br_lab_specimensource_Z_SetNull( );
               this.gxTv_SdtBR_Lab_Br_lab_specimensource_code_Z_SetNull( );
               this.gxTv_SdtBR_Lab_Br_lab_resultqual_Z_SetNull( );
               this.gxTv_SdtBR_Lab_Br_lab_resultqual_code_Z_SetNull( );
               this.gxTv_SdtBR_Lab_Br_lab_resultnum_Z_SetNull( );
               this.gxTv_SdtBR_Lab_Br_lab_resultunit_Z_SetNull( );
               this.gxTv_SdtBR_Lab_Br_lab_abnind_Z_SetNull( );
               this.gxTv_SdtBR_Lab_Br_lab_abnind_code_Z_SetNull( );
               this.gxTv_SdtBR_Lab_Br_lab_normrangelow_Z_SetNull( );
               this.gxTv_SdtBR_Lab_Br_lab_normrangehigh_Z_SetNull( );
               this.gxTv_SdtBR_Lab_Br_lab_testmethod_Z_SetNull( );
               this.gxTv_SdtBR_Lab_Br_lab_instrumentname_Z_SetNull( );
               this.gxTv_SdtBR_Lab_Br_lab_instrumentcode_Z_SetNull( );
               this.gxTv_SdtBR_Lab_Br_sampleid_Z_SetNull( );
            }
            gxTv_SdtBR_Lab_Br_labid = value;
            SetDirty("Br_labid");
         }

      }

      [  SoapElement( ElementName = "BR_EncounterID" )]
      [  XmlElement( ElementName = "BR_EncounterID"   )]
      public long gxTpr_Br_encounterid
      {
         get {
            return gxTv_SdtBR_Lab_Br_encounterid ;
         }

         set {
            gxTv_SdtBR_Lab_Br_encounterid = value;
            SetDirty("Br_encounterid");
         }

      }

      [  SoapElement( ElementName = "BR_Information_PatientNo" )]
      [  XmlElement( ElementName = "BR_Information_PatientNo"   )]
      public String gxTpr_Br_information_patientno
      {
         get {
            return gxTv_SdtBR_Lab_Br_information_patientno ;
         }

         set {
            gxTv_SdtBR_Lab_Br_information_patientno_N = 0;
            gxTv_SdtBR_Lab_Br_information_patientno = value;
            SetDirty("Br_information_patientno");
         }

      }

      public void gxTv_SdtBR_Lab_Br_information_patientno_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_information_patientno_N = 1;
         gxTv_SdtBR_Lab_Br_information_patientno = "";
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_information_patientno_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_SampleID" )]
      [  XmlElement( ElementName = "BR_Lab_SampleID"   )]
      public String gxTpr_Br_lab_sampleid
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_sampleid ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_sampleid_N = 0;
            gxTv_SdtBR_Lab_Br_lab_sampleid = value;
            SetDirty("Br_lab_sampleid");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_sampleid_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_sampleid_N = 1;
         gxTv_SdtBR_Lab_Br_lab_sampleid = "";
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_sampleid_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_TestID" )]
      [  XmlElement( ElementName = "BR_Lab_TestID"   )]
      public long gxTpr_Br_lab_testid
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_testid ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_testid_N = 0;
            gxTv_SdtBR_Lab_Br_lab_testid = value;
            SetDirty("Br_lab_testid");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_testid_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_testid_N = 1;
         gxTv_SdtBR_Lab_Br_lab_testid = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_testid_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_TestCode" )]
      [  XmlElement( ElementName = "BR_Lab_TestCode"   )]
      public String gxTpr_Br_lab_testcode
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_testcode ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_testcode_N = 0;
            gxTv_SdtBR_Lab_Br_lab_testcode = value;
            SetDirty("Br_lab_testcode");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_testcode_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_testcode_N = 1;
         gxTv_SdtBR_Lab_Br_lab_testcode = "";
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_testcode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_TestName" )]
      [  XmlElement( ElementName = "BR_Lab_TestName"   )]
      public String gxTpr_Br_lab_testname
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_testname ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_testname_N = 0;
            gxTv_SdtBR_Lab_Br_lab_testname = value;
            SetDirty("Br_lab_testname");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_testname_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_testname_N = 1;
         gxTv_SdtBR_Lab_Br_lab_testname = "";
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_testname_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_TestEngName" )]
      [  XmlElement( ElementName = "BR_Lab_TestEngName"   )]
      public String gxTpr_Br_lab_testengname
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_testengname ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_testengname_N = 0;
            gxTv_SdtBR_Lab_Br_lab_testengname = value;
            SetDirty("Br_lab_testengname");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_testengname_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_testengname_N = 1;
         gxTv_SdtBR_Lab_Br_lab_testengname = "";
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_testengname_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_Age" )]
      [  XmlElement( ElementName = "BR_Lab_Age"   )]
      public short gxTpr_Br_lab_age
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_age ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_age_N = 0;
            gxTv_SdtBR_Lab_Br_lab_age = value;
            SetDirty("Br_lab_age");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_age_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_age_N = 1;
         gxTv_SdtBR_Lab_Br_lab_age = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_age_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_Diag" )]
      [  XmlElement( ElementName = "BR_Lab_Diag"   )]
      public String gxTpr_Br_lab_diag
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_diag ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_diag_N = 0;
            gxTv_SdtBR_Lab_Br_lab_diag = value;
            SetDirty("Br_lab_diag");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_diag_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_diag_N = 1;
         gxTv_SdtBR_Lab_Br_lab_diag = "";
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_diag_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_SpecimenDate" )]
      [  XmlElement( ElementName = "BR_Lab_SpecimenDate"  , IsNullable=true )]
      public string gxTpr_Br_lab_specimendate_Nullable
      {
         get {
            if ( gxTv_SdtBR_Lab_Br_lab_specimendate == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtBR_Lab_Br_lab_specimendate).value ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_specimendate_N = 0;
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtBR_Lab_Br_lab_specimendate = DateTime.MinValue;
            else
               gxTv_SdtBR_Lab_Br_lab_specimendate = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Br_lab_specimendate
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_specimendate ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_specimendate_N = 0;
            gxTv_SdtBR_Lab_Br_lab_specimendate = value;
            SetDirty("Br_lab_specimendate");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_specimendate_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_specimendate_N = 1;
         gxTv_SdtBR_Lab_Br_lab_specimendate = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_specimendate_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_ReceivingTime" )]
      [  XmlElement( ElementName = "BR_Lab_ReceivingTime"  , IsNullable=true )]
      public string gxTpr_Br_lab_receivingtime_Nullable
      {
         get {
            if ( gxTv_SdtBR_Lab_Br_lab_receivingtime == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtBR_Lab_Br_lab_receivingtime).value ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_receivingtime_N = 0;
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtBR_Lab_Br_lab_receivingtime = DateTime.MinValue;
            else
               gxTv_SdtBR_Lab_Br_lab_receivingtime = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Br_lab_receivingtime
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_receivingtime ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_receivingtime_N = 0;
            gxTv_SdtBR_Lab_Br_lab_receivingtime = value;
            SetDirty("Br_lab_receivingtime");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_receivingtime_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_receivingtime_N = 1;
         gxTv_SdtBR_Lab_Br_lab_receivingtime = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_receivingtime_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_ReportTime" )]
      [  XmlElement( ElementName = "BR_Lab_ReportTime"  , IsNullable=true )]
      public string gxTpr_Br_lab_reporttime_Nullable
      {
         get {
            if ( gxTv_SdtBR_Lab_Br_lab_reporttime == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtBR_Lab_Br_lab_reporttime).value ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_reporttime_N = 0;
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtBR_Lab_Br_lab_reporttime = DateTime.MinValue;
            else
               gxTv_SdtBR_Lab_Br_lab_reporttime = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Br_lab_reporttime
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_reporttime ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_reporttime_N = 0;
            gxTv_SdtBR_Lab_Br_lab_reporttime = value;
            SetDirty("Br_lab_reporttime");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_reporttime_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_reporttime_N = 1;
         gxTv_SdtBR_Lab_Br_lab_reporttime = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_reporttime_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_SpecimenSource" )]
      [  XmlElement( ElementName = "BR_Lab_SpecimenSource"   )]
      public String gxTpr_Br_lab_specimensource
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_specimensource ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_specimensource_N = 0;
            gxTv_SdtBR_Lab_Br_lab_specimensource = value;
            SetDirty("Br_lab_specimensource");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_specimensource_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_specimensource_N = 1;
         gxTv_SdtBR_Lab_Br_lab_specimensource = "";
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_specimensource_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_SpecimenSource_Code" )]
      [  XmlElement( ElementName = "BR_Lab_SpecimenSource_Code"   )]
      public String gxTpr_Br_lab_specimensource_code
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_specimensource_code ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_specimensource_code_N = 0;
            gxTv_SdtBR_Lab_Br_lab_specimensource_code = value;
            SetDirty("Br_lab_specimensource_code");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_specimensource_code_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_specimensource_code_N = 1;
         gxTv_SdtBR_Lab_Br_lab_specimensource_code = "";
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_specimensource_code_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_ResultQual" )]
      [  XmlElement( ElementName = "BR_Lab_ResultQual"   )]
      public String gxTpr_Br_lab_resultqual
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_resultqual ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_resultqual_N = 0;
            gxTv_SdtBR_Lab_Br_lab_resultqual = value;
            SetDirty("Br_lab_resultqual");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_resultqual_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_resultqual_N = 1;
         gxTv_SdtBR_Lab_Br_lab_resultqual = "";
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_resultqual_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_ResultQual_Code" )]
      [  XmlElement( ElementName = "BR_Lab_ResultQual_Code"   )]
      public String gxTpr_Br_lab_resultqual_code
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_resultqual_code ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_resultqual_code_N = 0;
            gxTv_SdtBR_Lab_Br_lab_resultqual_code = value;
            SetDirty("Br_lab_resultqual_code");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_resultqual_code_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_resultqual_code_N = 1;
         gxTv_SdtBR_Lab_Br_lab_resultqual_code = "";
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_resultqual_code_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_ResultNum" )]
      [  XmlElement( ElementName = "BR_Lab_ResultNum"   )]
      public String gxTpr_Br_lab_resultnum
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_resultnum ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_resultnum_N = 0;
            gxTv_SdtBR_Lab_Br_lab_resultnum = value;
            SetDirty("Br_lab_resultnum");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_resultnum_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_resultnum_N = 1;
         gxTv_SdtBR_Lab_Br_lab_resultnum = "";
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_resultnum_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_ResultUnit" )]
      [  XmlElement( ElementName = "BR_Lab_ResultUnit"   )]
      public String gxTpr_Br_lab_resultunit
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_resultunit ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_resultunit_N = 0;
            gxTv_SdtBR_Lab_Br_lab_resultunit = value;
            SetDirty("Br_lab_resultunit");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_resultunit_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_resultunit_N = 1;
         gxTv_SdtBR_Lab_Br_lab_resultunit = "";
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_resultunit_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_AbnInd" )]
      [  XmlElement( ElementName = "BR_Lab_AbnInd"   )]
      public String gxTpr_Br_lab_abnind
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_abnind ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_abnind_N = 0;
            gxTv_SdtBR_Lab_Br_lab_abnind = value;
            SetDirty("Br_lab_abnind");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_abnind_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_abnind_N = 1;
         gxTv_SdtBR_Lab_Br_lab_abnind = "";
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_abnind_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_AbnInd_Code" )]
      [  XmlElement( ElementName = "BR_Lab_AbnInd_Code"   )]
      public String gxTpr_Br_lab_abnind_code
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_abnind_code ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_abnind_code_N = 0;
            gxTv_SdtBR_Lab_Br_lab_abnind_code = value;
            SetDirty("Br_lab_abnind_code");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_abnind_code_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_abnind_code_N = 1;
         gxTv_SdtBR_Lab_Br_lab_abnind_code = "";
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_abnind_code_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_NormRangeLow" )]
      [  XmlElement( ElementName = "BR_Lab_NormRangeLow"   )]
      public String gxTpr_Br_lab_normrangelow
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_normrangelow ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_normrangelow_N = 0;
            gxTv_SdtBR_Lab_Br_lab_normrangelow = value;
            SetDirty("Br_lab_normrangelow");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_normrangelow_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_normrangelow_N = 1;
         gxTv_SdtBR_Lab_Br_lab_normrangelow = "";
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_normrangelow_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_NormRangeHigh" )]
      [  XmlElement( ElementName = "BR_Lab_NormRangeHigh"   )]
      public String gxTpr_Br_lab_normrangehigh
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_normrangehigh ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_normrangehigh_N = 0;
            gxTv_SdtBR_Lab_Br_lab_normrangehigh = value;
            SetDirty("Br_lab_normrangehigh");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_normrangehigh_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_normrangehigh_N = 1;
         gxTv_SdtBR_Lab_Br_lab_normrangehigh = "";
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_normrangehigh_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_TestMethod" )]
      [  XmlElement( ElementName = "BR_Lab_TestMethod"   )]
      public String gxTpr_Br_lab_testmethod
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_testmethod ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_testmethod_N = 0;
            gxTv_SdtBR_Lab_Br_lab_testmethod = value;
            SetDirty("Br_lab_testmethod");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_testmethod_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_testmethod_N = 1;
         gxTv_SdtBR_Lab_Br_lab_testmethod = "";
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_testmethod_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_InstrumentName" )]
      [  XmlElement( ElementName = "BR_Lab_InstrumentName"   )]
      public String gxTpr_Br_lab_instrumentname
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_instrumentname ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_instrumentname_N = 0;
            gxTv_SdtBR_Lab_Br_lab_instrumentname = value;
            SetDirty("Br_lab_instrumentname");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_instrumentname_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_instrumentname_N = 1;
         gxTv_SdtBR_Lab_Br_lab_instrumentname = "";
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_instrumentname_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_InstrumentCode" )]
      [  XmlElement( ElementName = "BR_Lab_InstrumentCode"   )]
      public String gxTpr_Br_lab_instrumentcode
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_instrumentcode ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_instrumentcode_N = 0;
            gxTv_SdtBR_Lab_Br_lab_instrumentcode = value;
            SetDirty("Br_lab_instrumentcode");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_instrumentcode_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_instrumentcode_N = 1;
         gxTv_SdtBR_Lab_Br_lab_instrumentcode = "";
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_instrumentcode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_SampleId" )]
      [  XmlElement( ElementName = "BR_SampleId"   )]
      public long gxTpr_Br_sampleid
      {
         get {
            return gxTv_SdtBR_Lab_Br_sampleid ;
         }

         set {
            gxTv_SdtBR_Lab_Br_sampleid_N = 0;
            gxTv_SdtBR_Lab_Br_sampleid = value;
            SetDirty("Br_sampleid");
         }

      }

      public void gxTv_SdtBR_Lab_Br_sampleid_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_sampleid_N = 1;
         gxTv_SdtBR_Lab_Br_sampleid = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_sampleid_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtBR_Lab_Mode ;
         }

         set {
            gxTv_SdtBR_Lab_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtBR_Lab_Mode_SetNull( )
      {
         gxTv_SdtBR_Lab_Mode = "";
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtBR_Lab_Initialized ;
         }

         set {
            gxTv_SdtBR_Lab_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtBR_Lab_Initialized_SetNull( )
      {
         gxTv_SdtBR_Lab_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_LabID_Z" )]
      [  XmlElement( ElementName = "BR_LabID_Z"   )]
      public long gxTpr_Br_labid_Z
      {
         get {
            return gxTv_SdtBR_Lab_Br_labid_Z ;
         }

         set {
            gxTv_SdtBR_Lab_Br_labid_Z = value;
            SetDirty("Br_labid_Z");
         }

      }

      public void gxTv_SdtBR_Lab_Br_labid_Z_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_labid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_labid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_EncounterID_Z" )]
      [  XmlElement( ElementName = "BR_EncounterID_Z"   )]
      public long gxTpr_Br_encounterid_Z
      {
         get {
            return gxTv_SdtBR_Lab_Br_encounterid_Z ;
         }

         set {
            gxTv_SdtBR_Lab_Br_encounterid_Z = value;
            SetDirty("Br_encounterid_Z");
         }

      }

      public void gxTv_SdtBR_Lab_Br_encounterid_Z_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_encounterid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_encounterid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Information_PatientNo_Z" )]
      [  XmlElement( ElementName = "BR_Information_PatientNo_Z"   )]
      public String gxTpr_Br_information_patientno_Z
      {
         get {
            return gxTv_SdtBR_Lab_Br_information_patientno_Z ;
         }

         set {
            gxTv_SdtBR_Lab_Br_information_patientno_Z = value;
            SetDirty("Br_information_patientno_Z");
         }

      }

      public void gxTv_SdtBR_Lab_Br_information_patientno_Z_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_information_patientno_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_information_patientno_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_SampleID_Z" )]
      [  XmlElement( ElementName = "BR_Lab_SampleID_Z"   )]
      public String gxTpr_Br_lab_sampleid_Z
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_sampleid_Z ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_sampleid_Z = value;
            SetDirty("Br_lab_sampleid_Z");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_sampleid_Z_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_sampleid_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_sampleid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_TestID_Z" )]
      [  XmlElement( ElementName = "BR_Lab_TestID_Z"   )]
      public long gxTpr_Br_lab_testid_Z
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_testid_Z ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_testid_Z = value;
            SetDirty("Br_lab_testid_Z");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_testid_Z_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_testid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_testid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_TestCode_Z" )]
      [  XmlElement( ElementName = "BR_Lab_TestCode_Z"   )]
      public String gxTpr_Br_lab_testcode_Z
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_testcode_Z ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_testcode_Z = value;
            SetDirty("Br_lab_testcode_Z");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_testcode_Z_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_testcode_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_testcode_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_TestName_Z" )]
      [  XmlElement( ElementName = "BR_Lab_TestName_Z"   )]
      public String gxTpr_Br_lab_testname_Z
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_testname_Z ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_testname_Z = value;
            SetDirty("Br_lab_testname_Z");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_testname_Z_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_testname_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_testname_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_TestEngName_Z" )]
      [  XmlElement( ElementName = "BR_Lab_TestEngName_Z"   )]
      public String gxTpr_Br_lab_testengname_Z
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_testengname_Z ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_testengname_Z = value;
            SetDirty("Br_lab_testengname_Z");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_testengname_Z_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_testengname_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_testengname_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_Age_Z" )]
      [  XmlElement( ElementName = "BR_Lab_Age_Z"   )]
      public short gxTpr_Br_lab_age_Z
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_age_Z ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_age_Z = value;
            SetDirty("Br_lab_age_Z");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_age_Z_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_age_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_age_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_Diag_Z" )]
      [  XmlElement( ElementName = "BR_Lab_Diag_Z"   )]
      public String gxTpr_Br_lab_diag_Z
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_diag_Z ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_diag_Z = value;
            SetDirty("Br_lab_diag_Z");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_diag_Z_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_diag_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_diag_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_SpecimenDate_Z" )]
      [  XmlElement( ElementName = "BR_Lab_SpecimenDate_Z"  , IsNullable=true )]
      public string gxTpr_Br_lab_specimendate_Z_Nullable
      {
         get {
            if ( gxTv_SdtBR_Lab_Br_lab_specimendate_Z == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtBR_Lab_Br_lab_specimendate_Z).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtBR_Lab_Br_lab_specimendate_Z = DateTime.MinValue;
            else
               gxTv_SdtBR_Lab_Br_lab_specimendate_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Br_lab_specimendate_Z
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_specimendate_Z ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_specimendate_Z = value;
            SetDirty("Br_lab_specimendate_Z");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_specimendate_Z_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_specimendate_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_specimendate_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_ReceivingTime_Z" )]
      [  XmlElement( ElementName = "BR_Lab_ReceivingTime_Z"  , IsNullable=true )]
      public string gxTpr_Br_lab_receivingtime_Z_Nullable
      {
         get {
            if ( gxTv_SdtBR_Lab_Br_lab_receivingtime_Z == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtBR_Lab_Br_lab_receivingtime_Z).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtBR_Lab_Br_lab_receivingtime_Z = DateTime.MinValue;
            else
               gxTv_SdtBR_Lab_Br_lab_receivingtime_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Br_lab_receivingtime_Z
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_receivingtime_Z ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_receivingtime_Z = value;
            SetDirty("Br_lab_receivingtime_Z");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_receivingtime_Z_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_receivingtime_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_receivingtime_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_ReportTime_Z" )]
      [  XmlElement( ElementName = "BR_Lab_ReportTime_Z"  , IsNullable=true )]
      public string gxTpr_Br_lab_reporttime_Z_Nullable
      {
         get {
            if ( gxTv_SdtBR_Lab_Br_lab_reporttime_Z == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtBR_Lab_Br_lab_reporttime_Z).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtBR_Lab_Br_lab_reporttime_Z = DateTime.MinValue;
            else
               gxTv_SdtBR_Lab_Br_lab_reporttime_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Br_lab_reporttime_Z
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_reporttime_Z ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_reporttime_Z = value;
            SetDirty("Br_lab_reporttime_Z");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_reporttime_Z_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_reporttime_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_reporttime_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_SpecimenSource_Z" )]
      [  XmlElement( ElementName = "BR_Lab_SpecimenSource_Z"   )]
      public String gxTpr_Br_lab_specimensource_Z
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_specimensource_Z ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_specimensource_Z = value;
            SetDirty("Br_lab_specimensource_Z");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_specimensource_Z_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_specimensource_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_specimensource_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_SpecimenSource_Code_Z" )]
      [  XmlElement( ElementName = "BR_Lab_SpecimenSource_Code_Z"   )]
      public String gxTpr_Br_lab_specimensource_code_Z
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_specimensource_code_Z ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_specimensource_code_Z = value;
            SetDirty("Br_lab_specimensource_code_Z");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_specimensource_code_Z_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_specimensource_code_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_specimensource_code_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_ResultQual_Z" )]
      [  XmlElement( ElementName = "BR_Lab_ResultQual_Z"   )]
      public String gxTpr_Br_lab_resultqual_Z
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_resultqual_Z ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_resultqual_Z = value;
            SetDirty("Br_lab_resultqual_Z");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_resultqual_Z_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_resultqual_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_resultqual_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_ResultQual_Code_Z" )]
      [  XmlElement( ElementName = "BR_Lab_ResultQual_Code_Z"   )]
      public String gxTpr_Br_lab_resultqual_code_Z
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_resultqual_code_Z ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_resultqual_code_Z = value;
            SetDirty("Br_lab_resultqual_code_Z");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_resultqual_code_Z_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_resultqual_code_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_resultqual_code_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_ResultNum_Z" )]
      [  XmlElement( ElementName = "BR_Lab_ResultNum_Z"   )]
      public String gxTpr_Br_lab_resultnum_Z
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_resultnum_Z ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_resultnum_Z = value;
            SetDirty("Br_lab_resultnum_Z");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_resultnum_Z_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_resultnum_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_resultnum_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_ResultUnit_Z" )]
      [  XmlElement( ElementName = "BR_Lab_ResultUnit_Z"   )]
      public String gxTpr_Br_lab_resultunit_Z
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_resultunit_Z ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_resultunit_Z = value;
            SetDirty("Br_lab_resultunit_Z");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_resultunit_Z_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_resultunit_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_resultunit_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_AbnInd_Z" )]
      [  XmlElement( ElementName = "BR_Lab_AbnInd_Z"   )]
      public String gxTpr_Br_lab_abnind_Z
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_abnind_Z ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_abnind_Z = value;
            SetDirty("Br_lab_abnind_Z");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_abnind_Z_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_abnind_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_abnind_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_AbnInd_Code_Z" )]
      [  XmlElement( ElementName = "BR_Lab_AbnInd_Code_Z"   )]
      public String gxTpr_Br_lab_abnind_code_Z
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_abnind_code_Z ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_abnind_code_Z = value;
            SetDirty("Br_lab_abnind_code_Z");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_abnind_code_Z_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_abnind_code_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_abnind_code_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_NormRangeLow_Z" )]
      [  XmlElement( ElementName = "BR_Lab_NormRangeLow_Z"   )]
      public String gxTpr_Br_lab_normrangelow_Z
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_normrangelow_Z ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_normrangelow_Z = value;
            SetDirty("Br_lab_normrangelow_Z");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_normrangelow_Z_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_normrangelow_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_normrangelow_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_NormRangeHigh_Z" )]
      [  XmlElement( ElementName = "BR_Lab_NormRangeHigh_Z"   )]
      public String gxTpr_Br_lab_normrangehigh_Z
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_normrangehigh_Z ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_normrangehigh_Z = value;
            SetDirty("Br_lab_normrangehigh_Z");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_normrangehigh_Z_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_normrangehigh_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_normrangehigh_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_TestMethod_Z" )]
      [  XmlElement( ElementName = "BR_Lab_TestMethod_Z"   )]
      public String gxTpr_Br_lab_testmethod_Z
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_testmethod_Z ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_testmethod_Z = value;
            SetDirty("Br_lab_testmethod_Z");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_testmethod_Z_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_testmethod_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_testmethod_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_InstrumentName_Z" )]
      [  XmlElement( ElementName = "BR_Lab_InstrumentName_Z"   )]
      public String gxTpr_Br_lab_instrumentname_Z
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_instrumentname_Z ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_instrumentname_Z = value;
            SetDirty("Br_lab_instrumentname_Z");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_instrumentname_Z_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_instrumentname_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_instrumentname_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_InstrumentCode_Z" )]
      [  XmlElement( ElementName = "BR_Lab_InstrumentCode_Z"   )]
      public String gxTpr_Br_lab_instrumentcode_Z
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_instrumentcode_Z ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_instrumentcode_Z = value;
            SetDirty("Br_lab_instrumentcode_Z");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_instrumentcode_Z_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_instrumentcode_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_instrumentcode_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_SampleId_Z" )]
      [  XmlElement( ElementName = "BR_SampleId_Z"   )]
      public long gxTpr_Br_sampleid_Z
      {
         get {
            return gxTv_SdtBR_Lab_Br_sampleid_Z ;
         }

         set {
            gxTv_SdtBR_Lab_Br_sampleid_Z = value;
            SetDirty("Br_sampleid_Z");
         }

      }

      public void gxTv_SdtBR_Lab_Br_sampleid_Z_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_sampleid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_sampleid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Information_PatientNo_N" )]
      [  XmlElement( ElementName = "BR_Information_PatientNo_N"   )]
      public short gxTpr_Br_information_patientno_N
      {
         get {
            return gxTv_SdtBR_Lab_Br_information_patientno_N ;
         }

         set {
            gxTv_SdtBR_Lab_Br_information_patientno_N = value;
            SetDirty("Br_information_patientno_N");
         }

      }

      public void gxTv_SdtBR_Lab_Br_information_patientno_N_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_information_patientno_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_information_patientno_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_SampleID_N" )]
      [  XmlElement( ElementName = "BR_Lab_SampleID_N"   )]
      public short gxTpr_Br_lab_sampleid_N
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_sampleid_N ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_sampleid_N = value;
            SetDirty("Br_lab_sampleid_N");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_sampleid_N_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_sampleid_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_sampleid_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_TestID_N" )]
      [  XmlElement( ElementName = "BR_Lab_TestID_N"   )]
      public short gxTpr_Br_lab_testid_N
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_testid_N ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_testid_N = value;
            SetDirty("Br_lab_testid_N");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_testid_N_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_testid_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_testid_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_TestCode_N" )]
      [  XmlElement( ElementName = "BR_Lab_TestCode_N"   )]
      public short gxTpr_Br_lab_testcode_N
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_testcode_N ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_testcode_N = value;
            SetDirty("Br_lab_testcode_N");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_testcode_N_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_testcode_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_testcode_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_TestName_N" )]
      [  XmlElement( ElementName = "BR_Lab_TestName_N"   )]
      public short gxTpr_Br_lab_testname_N
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_testname_N ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_testname_N = value;
            SetDirty("Br_lab_testname_N");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_testname_N_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_testname_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_testname_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_TestEngName_N" )]
      [  XmlElement( ElementName = "BR_Lab_TestEngName_N"   )]
      public short gxTpr_Br_lab_testengname_N
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_testengname_N ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_testengname_N = value;
            SetDirty("Br_lab_testengname_N");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_testengname_N_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_testengname_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_testengname_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_Age_N" )]
      [  XmlElement( ElementName = "BR_Lab_Age_N"   )]
      public short gxTpr_Br_lab_age_N
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_age_N ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_age_N = value;
            SetDirty("Br_lab_age_N");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_age_N_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_age_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_age_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_Diag_N" )]
      [  XmlElement( ElementName = "BR_Lab_Diag_N"   )]
      public short gxTpr_Br_lab_diag_N
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_diag_N ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_diag_N = value;
            SetDirty("Br_lab_diag_N");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_diag_N_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_diag_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_diag_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_SpecimenDate_N" )]
      [  XmlElement( ElementName = "BR_Lab_SpecimenDate_N"   )]
      public short gxTpr_Br_lab_specimendate_N
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_specimendate_N ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_specimendate_N = value;
            SetDirty("Br_lab_specimendate_N");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_specimendate_N_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_specimendate_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_specimendate_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_ReceivingTime_N" )]
      [  XmlElement( ElementName = "BR_Lab_ReceivingTime_N"   )]
      public short gxTpr_Br_lab_receivingtime_N
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_receivingtime_N ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_receivingtime_N = value;
            SetDirty("Br_lab_receivingtime_N");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_receivingtime_N_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_receivingtime_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_receivingtime_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_ReportTime_N" )]
      [  XmlElement( ElementName = "BR_Lab_ReportTime_N"   )]
      public short gxTpr_Br_lab_reporttime_N
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_reporttime_N ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_reporttime_N = value;
            SetDirty("Br_lab_reporttime_N");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_reporttime_N_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_reporttime_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_reporttime_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_SpecimenSource_N" )]
      [  XmlElement( ElementName = "BR_Lab_SpecimenSource_N"   )]
      public short gxTpr_Br_lab_specimensource_N
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_specimensource_N ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_specimensource_N = value;
            SetDirty("Br_lab_specimensource_N");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_specimensource_N_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_specimensource_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_specimensource_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_SpecimenSource_Code_N" )]
      [  XmlElement( ElementName = "BR_Lab_SpecimenSource_Code_N"   )]
      public short gxTpr_Br_lab_specimensource_code_N
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_specimensource_code_N ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_specimensource_code_N = value;
            SetDirty("Br_lab_specimensource_code_N");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_specimensource_code_N_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_specimensource_code_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_specimensource_code_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_ResultQual_N" )]
      [  XmlElement( ElementName = "BR_Lab_ResultQual_N"   )]
      public short gxTpr_Br_lab_resultqual_N
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_resultqual_N ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_resultqual_N = value;
            SetDirty("Br_lab_resultqual_N");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_resultqual_N_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_resultqual_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_resultqual_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_ResultQual_Code_N" )]
      [  XmlElement( ElementName = "BR_Lab_ResultQual_Code_N"   )]
      public short gxTpr_Br_lab_resultqual_code_N
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_resultqual_code_N ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_resultqual_code_N = value;
            SetDirty("Br_lab_resultqual_code_N");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_resultqual_code_N_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_resultqual_code_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_resultqual_code_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_ResultNum_N" )]
      [  XmlElement( ElementName = "BR_Lab_ResultNum_N"   )]
      public short gxTpr_Br_lab_resultnum_N
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_resultnum_N ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_resultnum_N = value;
            SetDirty("Br_lab_resultnum_N");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_resultnum_N_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_resultnum_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_resultnum_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_ResultUnit_N" )]
      [  XmlElement( ElementName = "BR_Lab_ResultUnit_N"   )]
      public short gxTpr_Br_lab_resultunit_N
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_resultunit_N ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_resultunit_N = value;
            SetDirty("Br_lab_resultunit_N");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_resultunit_N_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_resultunit_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_resultunit_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_AbnInd_N" )]
      [  XmlElement( ElementName = "BR_Lab_AbnInd_N"   )]
      public short gxTpr_Br_lab_abnind_N
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_abnind_N ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_abnind_N = value;
            SetDirty("Br_lab_abnind_N");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_abnind_N_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_abnind_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_abnind_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_AbnInd_Code_N" )]
      [  XmlElement( ElementName = "BR_Lab_AbnInd_Code_N"   )]
      public short gxTpr_Br_lab_abnind_code_N
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_abnind_code_N ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_abnind_code_N = value;
            SetDirty("Br_lab_abnind_code_N");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_abnind_code_N_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_abnind_code_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_abnind_code_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_NormRangeLow_N" )]
      [  XmlElement( ElementName = "BR_Lab_NormRangeLow_N"   )]
      public short gxTpr_Br_lab_normrangelow_N
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_normrangelow_N ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_normrangelow_N = value;
            SetDirty("Br_lab_normrangelow_N");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_normrangelow_N_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_normrangelow_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_normrangelow_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_NormRangeHigh_N" )]
      [  XmlElement( ElementName = "BR_Lab_NormRangeHigh_N"   )]
      public short gxTpr_Br_lab_normrangehigh_N
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_normrangehigh_N ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_normrangehigh_N = value;
            SetDirty("Br_lab_normrangehigh_N");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_normrangehigh_N_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_normrangehigh_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_normrangehigh_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_TestMethod_N" )]
      [  XmlElement( ElementName = "BR_Lab_TestMethod_N"   )]
      public short gxTpr_Br_lab_testmethod_N
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_testmethod_N ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_testmethod_N = value;
            SetDirty("Br_lab_testmethod_N");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_testmethod_N_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_testmethod_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_testmethod_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_InstrumentName_N" )]
      [  XmlElement( ElementName = "BR_Lab_InstrumentName_N"   )]
      public short gxTpr_Br_lab_instrumentname_N
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_instrumentname_N ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_instrumentname_N = value;
            SetDirty("Br_lab_instrumentname_N");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_instrumentname_N_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_instrumentname_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_instrumentname_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Lab_InstrumentCode_N" )]
      [  XmlElement( ElementName = "BR_Lab_InstrumentCode_N"   )]
      public short gxTpr_Br_lab_instrumentcode_N
      {
         get {
            return gxTv_SdtBR_Lab_Br_lab_instrumentcode_N ;
         }

         set {
            gxTv_SdtBR_Lab_Br_lab_instrumentcode_N = value;
            SetDirty("Br_lab_instrumentcode_N");
         }

      }

      public void gxTv_SdtBR_Lab_Br_lab_instrumentcode_N_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_lab_instrumentcode_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_lab_instrumentcode_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_SampleId_N" )]
      [  XmlElement( ElementName = "BR_SampleId_N"   )]
      public short gxTpr_Br_sampleid_N
      {
         get {
            return gxTv_SdtBR_Lab_Br_sampleid_N ;
         }

         set {
            gxTv_SdtBR_Lab_Br_sampleid_N = value;
            SetDirty("Br_sampleid_N");
         }

      }

      public void gxTv_SdtBR_Lab_Br_sampleid_N_SetNull( )
      {
         gxTv_SdtBR_Lab_Br_sampleid_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Lab_Br_sampleid_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtBR_Lab_Br_information_patientno = "";
         gxTv_SdtBR_Lab_Br_lab_sampleid = "";
         gxTv_SdtBR_Lab_Br_lab_testcode = "";
         gxTv_SdtBR_Lab_Br_lab_testname = "";
         gxTv_SdtBR_Lab_Br_lab_testengname = "";
         gxTv_SdtBR_Lab_Br_lab_diag = "";
         gxTv_SdtBR_Lab_Br_lab_specimendate = (DateTime)(DateTime.MinValue);
         gxTv_SdtBR_Lab_Br_lab_receivingtime = (DateTime)(DateTime.MinValue);
         gxTv_SdtBR_Lab_Br_lab_reporttime = (DateTime)(DateTime.MinValue);
         gxTv_SdtBR_Lab_Br_lab_specimensource = "";
         gxTv_SdtBR_Lab_Br_lab_specimensource_code = "";
         gxTv_SdtBR_Lab_Br_lab_resultqual = "";
         gxTv_SdtBR_Lab_Br_lab_resultqual_code = "";
         gxTv_SdtBR_Lab_Br_lab_resultnum = "";
         gxTv_SdtBR_Lab_Br_lab_resultunit = "";
         gxTv_SdtBR_Lab_Br_lab_abnind = "";
         gxTv_SdtBR_Lab_Br_lab_abnind_code = "";
         gxTv_SdtBR_Lab_Br_lab_normrangelow = "";
         gxTv_SdtBR_Lab_Br_lab_normrangehigh = "";
         gxTv_SdtBR_Lab_Br_lab_testmethod = "";
         gxTv_SdtBR_Lab_Br_lab_instrumentname = "";
         gxTv_SdtBR_Lab_Br_lab_instrumentcode = "";
         gxTv_SdtBR_Lab_Mode = "";
         gxTv_SdtBR_Lab_Br_information_patientno_Z = "";
         gxTv_SdtBR_Lab_Br_lab_sampleid_Z = "";
         gxTv_SdtBR_Lab_Br_lab_testcode_Z = "";
         gxTv_SdtBR_Lab_Br_lab_testname_Z = "";
         gxTv_SdtBR_Lab_Br_lab_testengname_Z = "";
         gxTv_SdtBR_Lab_Br_lab_diag_Z = "";
         gxTv_SdtBR_Lab_Br_lab_specimendate_Z = (DateTime)(DateTime.MinValue);
         gxTv_SdtBR_Lab_Br_lab_receivingtime_Z = (DateTime)(DateTime.MinValue);
         gxTv_SdtBR_Lab_Br_lab_reporttime_Z = (DateTime)(DateTime.MinValue);
         gxTv_SdtBR_Lab_Br_lab_specimensource_Z = "";
         gxTv_SdtBR_Lab_Br_lab_specimensource_code_Z = "";
         gxTv_SdtBR_Lab_Br_lab_resultqual_Z = "";
         gxTv_SdtBR_Lab_Br_lab_resultqual_code_Z = "";
         gxTv_SdtBR_Lab_Br_lab_resultnum_Z = "";
         gxTv_SdtBR_Lab_Br_lab_resultunit_Z = "";
         gxTv_SdtBR_Lab_Br_lab_abnind_Z = "";
         gxTv_SdtBR_Lab_Br_lab_abnind_code_Z = "";
         gxTv_SdtBR_Lab_Br_lab_normrangelow_Z = "";
         gxTv_SdtBR_Lab_Br_lab_normrangehigh_Z = "";
         gxTv_SdtBR_Lab_Br_lab_testmethod_Z = "";
         gxTv_SdtBR_Lab_Br_lab_instrumentname_Z = "";
         gxTv_SdtBR_Lab_Br_lab_instrumentcode_Z = "";
         datetime_STZ = (DateTime)(DateTime.MinValue);
         sDateCnv = "";
         sNumToPad = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "br_lab", "GeneXus.Programs.br_lab_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtBR_Lab_Br_lab_age ;
      private short gxTv_SdtBR_Lab_Initialized ;
      private short gxTv_SdtBR_Lab_Br_lab_age_Z ;
      private short gxTv_SdtBR_Lab_Br_information_patientno_N ;
      private short gxTv_SdtBR_Lab_Br_lab_sampleid_N ;
      private short gxTv_SdtBR_Lab_Br_lab_testid_N ;
      private short gxTv_SdtBR_Lab_Br_lab_testcode_N ;
      private short gxTv_SdtBR_Lab_Br_lab_testname_N ;
      private short gxTv_SdtBR_Lab_Br_lab_testengname_N ;
      private short gxTv_SdtBR_Lab_Br_lab_age_N ;
      private short gxTv_SdtBR_Lab_Br_lab_diag_N ;
      private short gxTv_SdtBR_Lab_Br_lab_specimendate_N ;
      private short gxTv_SdtBR_Lab_Br_lab_receivingtime_N ;
      private short gxTv_SdtBR_Lab_Br_lab_reporttime_N ;
      private short gxTv_SdtBR_Lab_Br_lab_specimensource_N ;
      private short gxTv_SdtBR_Lab_Br_lab_specimensource_code_N ;
      private short gxTv_SdtBR_Lab_Br_lab_resultqual_N ;
      private short gxTv_SdtBR_Lab_Br_lab_resultqual_code_N ;
      private short gxTv_SdtBR_Lab_Br_lab_resultnum_N ;
      private short gxTv_SdtBR_Lab_Br_lab_resultunit_N ;
      private short gxTv_SdtBR_Lab_Br_lab_abnind_N ;
      private short gxTv_SdtBR_Lab_Br_lab_abnind_code_N ;
      private short gxTv_SdtBR_Lab_Br_lab_normrangelow_N ;
      private short gxTv_SdtBR_Lab_Br_lab_normrangehigh_N ;
      private short gxTv_SdtBR_Lab_Br_lab_testmethod_N ;
      private short gxTv_SdtBR_Lab_Br_lab_instrumentname_N ;
      private short gxTv_SdtBR_Lab_Br_lab_instrumentcode_N ;
      private short gxTv_SdtBR_Lab_Br_sampleid_N ;
      private long gxTv_SdtBR_Lab_Br_labid ;
      private long gxTv_SdtBR_Lab_Br_encounterid ;
      private long gxTv_SdtBR_Lab_Br_lab_testid ;
      private long gxTv_SdtBR_Lab_Br_sampleid ;
      private long gxTv_SdtBR_Lab_Br_labid_Z ;
      private long gxTv_SdtBR_Lab_Br_encounterid_Z ;
      private long gxTv_SdtBR_Lab_Br_lab_testid_Z ;
      private long gxTv_SdtBR_Lab_Br_sampleid_Z ;
      private String gxTv_SdtBR_Lab_Mode ;
      private String sDateCnv ;
      private String sNumToPad ;
      private DateTime gxTv_SdtBR_Lab_Br_lab_specimendate ;
      private DateTime gxTv_SdtBR_Lab_Br_lab_receivingtime ;
      private DateTime gxTv_SdtBR_Lab_Br_lab_reporttime ;
      private DateTime gxTv_SdtBR_Lab_Br_lab_specimendate_Z ;
      private DateTime gxTv_SdtBR_Lab_Br_lab_receivingtime_Z ;
      private DateTime gxTv_SdtBR_Lab_Br_lab_reporttime_Z ;
      private DateTime datetime_STZ ;
      private String gxTv_SdtBR_Lab_Br_information_patientno ;
      private String gxTv_SdtBR_Lab_Br_lab_sampleid ;
      private String gxTv_SdtBR_Lab_Br_lab_testcode ;
      private String gxTv_SdtBR_Lab_Br_lab_testname ;
      private String gxTv_SdtBR_Lab_Br_lab_testengname ;
      private String gxTv_SdtBR_Lab_Br_lab_diag ;
      private String gxTv_SdtBR_Lab_Br_lab_specimensource ;
      private String gxTv_SdtBR_Lab_Br_lab_specimensource_code ;
      private String gxTv_SdtBR_Lab_Br_lab_resultqual ;
      private String gxTv_SdtBR_Lab_Br_lab_resultqual_code ;
      private String gxTv_SdtBR_Lab_Br_lab_resultnum ;
      private String gxTv_SdtBR_Lab_Br_lab_resultunit ;
      private String gxTv_SdtBR_Lab_Br_lab_abnind ;
      private String gxTv_SdtBR_Lab_Br_lab_abnind_code ;
      private String gxTv_SdtBR_Lab_Br_lab_normrangelow ;
      private String gxTv_SdtBR_Lab_Br_lab_normrangehigh ;
      private String gxTv_SdtBR_Lab_Br_lab_testmethod ;
      private String gxTv_SdtBR_Lab_Br_lab_instrumentname ;
      private String gxTv_SdtBR_Lab_Br_lab_instrumentcode ;
      private String gxTv_SdtBR_Lab_Br_information_patientno_Z ;
      private String gxTv_SdtBR_Lab_Br_lab_sampleid_Z ;
      private String gxTv_SdtBR_Lab_Br_lab_testcode_Z ;
      private String gxTv_SdtBR_Lab_Br_lab_testname_Z ;
      private String gxTv_SdtBR_Lab_Br_lab_testengname_Z ;
      private String gxTv_SdtBR_Lab_Br_lab_diag_Z ;
      private String gxTv_SdtBR_Lab_Br_lab_specimensource_Z ;
      private String gxTv_SdtBR_Lab_Br_lab_specimensource_code_Z ;
      private String gxTv_SdtBR_Lab_Br_lab_resultqual_Z ;
      private String gxTv_SdtBR_Lab_Br_lab_resultqual_code_Z ;
      private String gxTv_SdtBR_Lab_Br_lab_resultnum_Z ;
      private String gxTv_SdtBR_Lab_Br_lab_resultunit_Z ;
      private String gxTv_SdtBR_Lab_Br_lab_abnind_Z ;
      private String gxTv_SdtBR_Lab_Br_lab_abnind_code_Z ;
      private String gxTv_SdtBR_Lab_Br_lab_normrangelow_Z ;
      private String gxTv_SdtBR_Lab_Br_lab_normrangehigh_Z ;
      private String gxTv_SdtBR_Lab_Br_lab_testmethod_Z ;
      private String gxTv_SdtBR_Lab_Br_lab_instrumentname_Z ;
      private String gxTv_SdtBR_Lab_Br_lab_instrumentcode_Z ;
   }

   [DataContract(Name = @"BR_Lab", Namespace = "DataAnalysisPlatform")]
   public class SdtBR_Lab_RESTInterface : GxGenericCollectionItem<SdtBR_Lab>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtBR_Lab_RESTInterface( ) : base()
      {
      }

      public SdtBR_Lab_RESTInterface( SdtBR_Lab psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "BR_LabID" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Br_labid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Br_labid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Br_labid = (long)(NumberUtil.Val( value, "."));
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

      [DataMember( Name = "BR_Lab_SampleID" , Order = 3 )]
      [GxSeudo()]
      public String gxTpr_Br_lab_sampleid
      {
         get {
            return sdt.gxTpr_Br_lab_sampleid ;
         }

         set {
            sdt.gxTpr_Br_lab_sampleid = value;
         }

      }

      [DataMember( Name = "BR_Lab_TestID" , Order = 4 )]
      [GxSeudo()]
      public String gxTpr_Br_lab_testid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Br_lab_testid), 10, 0)) ;
         }

         set {
            sdt.gxTpr_Br_lab_testid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "BR_Lab_TestCode" , Order = 5 )]
      [GxSeudo()]
      public String gxTpr_Br_lab_testcode
      {
         get {
            return sdt.gxTpr_Br_lab_testcode ;
         }

         set {
            sdt.gxTpr_Br_lab_testcode = value;
         }

      }

      [DataMember( Name = "BR_Lab_TestName" , Order = 6 )]
      [GxSeudo()]
      public String gxTpr_Br_lab_testname
      {
         get {
            return sdt.gxTpr_Br_lab_testname ;
         }

         set {
            sdt.gxTpr_Br_lab_testname = value;
         }

      }

      [DataMember( Name = "BR_Lab_TestEngName" , Order = 7 )]
      [GxSeudo()]
      public String gxTpr_Br_lab_testengname
      {
         get {
            return sdt.gxTpr_Br_lab_testengname ;
         }

         set {
            sdt.gxTpr_Br_lab_testengname = value;
         }

      }

      [DataMember( Name = "BR_Lab_Age" , Order = 8 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Br_lab_age
      {
         get {
            return sdt.gxTpr_Br_lab_age ;
         }

         set {
            sdt.gxTpr_Br_lab_age = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "BR_Lab_Diag" , Order = 9 )]
      [GxSeudo()]
      public String gxTpr_Br_lab_diag
      {
         get {
            return sdt.gxTpr_Br_lab_diag ;
         }

         set {
            sdt.gxTpr_Br_lab_diag = value;
         }

      }

      [DataMember( Name = "BR_Lab_SpecimenDate" , Order = 10 )]
      [GxSeudo()]
      public String gxTpr_Br_lab_specimendate
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_Br_lab_specimendate) ;
         }

         set {
            sdt.gxTpr_Br_lab_specimendate = DateTimeUtil.CToT2( value);
         }

      }

      [DataMember( Name = "BR_Lab_ReceivingTime" , Order = 11 )]
      [GxSeudo()]
      public String gxTpr_Br_lab_receivingtime
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_Br_lab_receivingtime) ;
         }

         set {
            sdt.gxTpr_Br_lab_receivingtime = DateTimeUtil.CToT2( value);
         }

      }

      [DataMember( Name = "BR_Lab_ReportTime" , Order = 12 )]
      [GxSeudo()]
      public String gxTpr_Br_lab_reporttime
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_Br_lab_reporttime) ;
         }

         set {
            sdt.gxTpr_Br_lab_reporttime = DateTimeUtil.CToT2( value);
         }

      }

      [DataMember( Name = "BR_Lab_SpecimenSource" , Order = 13 )]
      [GxSeudo()]
      public String gxTpr_Br_lab_specimensource
      {
         get {
            return sdt.gxTpr_Br_lab_specimensource ;
         }

         set {
            sdt.gxTpr_Br_lab_specimensource = value;
         }

      }

      [DataMember( Name = "BR_Lab_SpecimenSource_Code" , Order = 14 )]
      [GxSeudo()]
      public String gxTpr_Br_lab_specimensource_code
      {
         get {
            return sdt.gxTpr_Br_lab_specimensource_code ;
         }

         set {
            sdt.gxTpr_Br_lab_specimensource_code = value;
         }

      }

      [DataMember( Name = "BR_Lab_ResultQual" , Order = 15 )]
      [GxSeudo()]
      public String gxTpr_Br_lab_resultqual
      {
         get {
            return sdt.gxTpr_Br_lab_resultqual ;
         }

         set {
            sdt.gxTpr_Br_lab_resultqual = value;
         }

      }

      [DataMember( Name = "BR_Lab_ResultQual_Code" , Order = 16 )]
      [GxSeudo()]
      public String gxTpr_Br_lab_resultqual_code
      {
         get {
            return sdt.gxTpr_Br_lab_resultqual_code ;
         }

         set {
            sdt.gxTpr_Br_lab_resultqual_code = value;
         }

      }

      [DataMember( Name = "BR_Lab_ResultNum" , Order = 17 )]
      [GxSeudo()]
      public String gxTpr_Br_lab_resultnum
      {
         get {
            return sdt.gxTpr_Br_lab_resultnum ;
         }

         set {
            sdt.gxTpr_Br_lab_resultnum = value;
         }

      }

      [DataMember( Name = "BR_Lab_ResultUnit" , Order = 18 )]
      [GxSeudo()]
      public String gxTpr_Br_lab_resultunit
      {
         get {
            return sdt.gxTpr_Br_lab_resultunit ;
         }

         set {
            sdt.gxTpr_Br_lab_resultunit = value;
         }

      }

      [DataMember( Name = "BR_Lab_AbnInd" , Order = 19 )]
      [GxSeudo()]
      public String gxTpr_Br_lab_abnind
      {
         get {
            return sdt.gxTpr_Br_lab_abnind ;
         }

         set {
            sdt.gxTpr_Br_lab_abnind = value;
         }

      }

      [DataMember( Name = "BR_Lab_AbnInd_Code" , Order = 20 )]
      [GxSeudo()]
      public String gxTpr_Br_lab_abnind_code
      {
         get {
            return sdt.gxTpr_Br_lab_abnind_code ;
         }

         set {
            sdt.gxTpr_Br_lab_abnind_code = value;
         }

      }

      [DataMember( Name = "BR_Lab_NormRangeLow" , Order = 21 )]
      [GxSeudo()]
      public String gxTpr_Br_lab_normrangelow
      {
         get {
            return sdt.gxTpr_Br_lab_normrangelow ;
         }

         set {
            sdt.gxTpr_Br_lab_normrangelow = value;
         }

      }

      [DataMember( Name = "BR_Lab_NormRangeHigh" , Order = 22 )]
      [GxSeudo()]
      public String gxTpr_Br_lab_normrangehigh
      {
         get {
            return sdt.gxTpr_Br_lab_normrangehigh ;
         }

         set {
            sdt.gxTpr_Br_lab_normrangehigh = value;
         }

      }

      [DataMember( Name = "BR_Lab_TestMethod" , Order = 23 )]
      [GxSeudo()]
      public String gxTpr_Br_lab_testmethod
      {
         get {
            return sdt.gxTpr_Br_lab_testmethod ;
         }

         set {
            sdt.gxTpr_Br_lab_testmethod = value;
         }

      }

      [DataMember( Name = "BR_Lab_InstrumentName" , Order = 24 )]
      [GxSeudo()]
      public String gxTpr_Br_lab_instrumentname
      {
         get {
            return sdt.gxTpr_Br_lab_instrumentname ;
         }

         set {
            sdt.gxTpr_Br_lab_instrumentname = value;
         }

      }

      [DataMember( Name = "BR_Lab_InstrumentCode" , Order = 25 )]
      [GxSeudo()]
      public String gxTpr_Br_lab_instrumentcode
      {
         get {
            return sdt.gxTpr_Br_lab_instrumentcode ;
         }

         set {
            sdt.gxTpr_Br_lab_instrumentcode = value;
         }

      }

      [DataMember( Name = "BR_SampleId" , Order = 26 )]
      [GxSeudo()]
      public String gxTpr_Br_sampleid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Br_sampleid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Br_sampleid = (long)(NumberUtil.Val( value, "."));
         }

      }

      public SdtBR_Lab sdt
      {
         get {
            return (SdtBR_Lab)Sdt ;
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
            sdt = new SdtBR_Lab() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 27 )]
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
