/*
               File: type_SdtBR_Pathology
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:8:29.10
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
   [XmlRoot(ElementName = "BR_Pathology" )]
   [XmlType(TypeName =  "BR_Pathology" , Namespace = "DataAnalysisPlatform" )]
   [Serializable]
   public class SdtBR_Pathology : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtBR_Pathology( )
      {
      }

      public SdtBR_Pathology( IGxContext context )
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

      public void Load( long AV226BR_PathologyID )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(long)AV226BR_PathologyID});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"BR_PathologyID", typeof(long)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "BR_Pathology");
         metadata.Set("BT", "BR_Pathology");
         metadata.Set("PK", "[ \"BR_PathologyID\" ]");
         metadata.Set("PKAssigned", "[ \"BR_PathologyID\" ]");
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
         state.Add("gxTpr_Br_pathologyid_Z");
         state.Add("gxTpr_Br_encounterid_Z");
         state.Add("gxTpr_Br_information_patientno_Z");
         state.Add("gxTpr_Br_pathologyid_testid_Z");
         state.Add("gxTpr_Br_pathologyid_padate_Z_Nullable");
         state.Add("gxTpr_Br_pathologyid_pahosp_Z");
         state.Add("gxTpr_Br_pathologyid_pahosp_code_Z");
         state.Add("gxTpr_Br_pathologyid_paage_Z");
         state.Add("gxTpr_Br_pathologyid_prepadia_Z");
         state.Add("gxTpr_Br_pathologyid_paresult_Z");
         state.Add("gxTpr_Br_pathology_dia_name_Z");
         state.Add("gxTpr_Br_pathology_t_Z_double");
         state.Add("gxTpr_Br_pathology_n_Z");
         state.Add("gxTpr_Br_pathology_n_code_Z");
         state.Add("gxTpr_Br_pathology_lymphnum_Z_double");
         state.Add("gxTpr_Br_pathology_lymphrate_Z");
         state.Add("gxTpr_Br_pathology_m_Z");
         state.Add("gxTpr_Br_pathology_m_code_Z");
         state.Add("gxTpr_Br_pathology_metaloc_Z");
         state.Add("gxTpr_Br_pathologyid_N");
         state.Add("gxTpr_Br_encounterid_N");
         state.Add("gxTpr_Br_information_patientno_N");
         state.Add("gxTpr_Br_pathologyid_testid_N");
         state.Add("gxTpr_Br_pathologyid_padate_N");
         state.Add("gxTpr_Br_pathologyid_pahosp_N");
         state.Add("gxTpr_Br_pathologyid_pahosp_code_N");
         state.Add("gxTpr_Br_pathologyid_paage_N");
         state.Add("gxTpr_Br_pathologyid_prepadia_N");
         state.Add("gxTpr_Br_pathologyid_paresult_N");
         state.Add("gxTpr_Br_pathology_dia_name_N");
         state.Add("gxTpr_Br_pathology_t_N");
         state.Add("gxTpr_Br_pathology_n_N");
         state.Add("gxTpr_Br_pathology_n_code_N");
         state.Add("gxTpr_Br_pathology_lymphnum_N");
         state.Add("gxTpr_Br_pathology_lymphrate_N");
         state.Add("gxTpr_Br_pathology_m_N");
         state.Add("gxTpr_Br_pathology_m_code_N");
         state.Add("gxTpr_Br_pathology_metaloc_N");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtBR_Pathology sdt ;
         sdt = (SdtBR_Pathology)(source);
         gxTv_SdtBR_Pathology_Br_pathologyid = sdt.gxTv_SdtBR_Pathology_Br_pathologyid ;
         gxTv_SdtBR_Pathology_Br_encounterid = sdt.gxTv_SdtBR_Pathology_Br_encounterid ;
         gxTv_SdtBR_Pathology_Br_information_patientno = sdt.gxTv_SdtBR_Pathology_Br_information_patientno ;
         gxTv_SdtBR_Pathology_Br_pathologyid_testid = sdt.gxTv_SdtBR_Pathology_Br_pathologyid_testid ;
         gxTv_SdtBR_Pathology_Br_pathologyid_padate = sdt.gxTv_SdtBR_Pathology_Br_pathologyid_padate ;
         gxTv_SdtBR_Pathology_Br_pathologyid_pahosp = sdt.gxTv_SdtBR_Pathology_Br_pathologyid_pahosp ;
         gxTv_SdtBR_Pathology_Br_pathologyid_pahosp_code = sdt.gxTv_SdtBR_Pathology_Br_pathologyid_pahosp_code ;
         gxTv_SdtBR_Pathology_Br_pathologyid_paage = sdt.gxTv_SdtBR_Pathology_Br_pathologyid_paage ;
         gxTv_SdtBR_Pathology_Br_pathologyid_prepadia = sdt.gxTv_SdtBR_Pathology_Br_pathologyid_prepadia ;
         gxTv_SdtBR_Pathology_Br_pathologyid_paresult = sdt.gxTv_SdtBR_Pathology_Br_pathologyid_paresult ;
         gxTv_SdtBR_Pathology_Br_pathology_dia_name = sdt.gxTv_SdtBR_Pathology_Br_pathology_dia_name ;
         gxTv_SdtBR_Pathology_Br_pathology_t = sdt.gxTv_SdtBR_Pathology_Br_pathology_t ;
         gxTv_SdtBR_Pathology_Br_pathology_n = sdt.gxTv_SdtBR_Pathology_Br_pathology_n ;
         gxTv_SdtBR_Pathology_Br_pathology_n_code = sdt.gxTv_SdtBR_Pathology_Br_pathology_n_code ;
         gxTv_SdtBR_Pathology_Br_pathology_lymphnum = sdt.gxTv_SdtBR_Pathology_Br_pathology_lymphnum ;
         gxTv_SdtBR_Pathology_Br_pathology_lymphrate = sdt.gxTv_SdtBR_Pathology_Br_pathology_lymphrate ;
         gxTv_SdtBR_Pathology_Br_pathology_m = sdt.gxTv_SdtBR_Pathology_Br_pathology_m ;
         gxTv_SdtBR_Pathology_Br_pathology_m_code = sdt.gxTv_SdtBR_Pathology_Br_pathology_m_code ;
         gxTv_SdtBR_Pathology_Br_pathology_metaloc = sdt.gxTv_SdtBR_Pathology_Br_pathology_metaloc ;
         gxTv_SdtBR_Pathology_Mode = sdt.gxTv_SdtBR_Pathology_Mode ;
         gxTv_SdtBR_Pathology_Initialized = sdt.gxTv_SdtBR_Pathology_Initialized ;
         gxTv_SdtBR_Pathology_Br_pathologyid_Z = sdt.gxTv_SdtBR_Pathology_Br_pathologyid_Z ;
         gxTv_SdtBR_Pathology_Br_encounterid_Z = sdt.gxTv_SdtBR_Pathology_Br_encounterid_Z ;
         gxTv_SdtBR_Pathology_Br_information_patientno_Z = sdt.gxTv_SdtBR_Pathology_Br_information_patientno_Z ;
         gxTv_SdtBR_Pathology_Br_pathologyid_testid_Z = sdt.gxTv_SdtBR_Pathology_Br_pathologyid_testid_Z ;
         gxTv_SdtBR_Pathology_Br_pathologyid_padate_Z = sdt.gxTv_SdtBR_Pathology_Br_pathologyid_padate_Z ;
         gxTv_SdtBR_Pathology_Br_pathologyid_pahosp_Z = sdt.gxTv_SdtBR_Pathology_Br_pathologyid_pahosp_Z ;
         gxTv_SdtBR_Pathology_Br_pathologyid_pahosp_code_Z = sdt.gxTv_SdtBR_Pathology_Br_pathologyid_pahosp_code_Z ;
         gxTv_SdtBR_Pathology_Br_pathologyid_paage_Z = sdt.gxTv_SdtBR_Pathology_Br_pathologyid_paage_Z ;
         gxTv_SdtBR_Pathology_Br_pathologyid_prepadia_Z = sdt.gxTv_SdtBR_Pathology_Br_pathologyid_prepadia_Z ;
         gxTv_SdtBR_Pathology_Br_pathologyid_paresult_Z = sdt.gxTv_SdtBR_Pathology_Br_pathologyid_paresult_Z ;
         gxTv_SdtBR_Pathology_Br_pathology_dia_name_Z = sdt.gxTv_SdtBR_Pathology_Br_pathology_dia_name_Z ;
         gxTv_SdtBR_Pathology_Br_pathology_t_Z = sdt.gxTv_SdtBR_Pathology_Br_pathology_t_Z ;
         gxTv_SdtBR_Pathology_Br_pathology_n_Z = sdt.gxTv_SdtBR_Pathology_Br_pathology_n_Z ;
         gxTv_SdtBR_Pathology_Br_pathology_n_code_Z = sdt.gxTv_SdtBR_Pathology_Br_pathology_n_code_Z ;
         gxTv_SdtBR_Pathology_Br_pathology_lymphnum_Z = sdt.gxTv_SdtBR_Pathology_Br_pathology_lymphnum_Z ;
         gxTv_SdtBR_Pathology_Br_pathology_lymphrate_Z = sdt.gxTv_SdtBR_Pathology_Br_pathology_lymphrate_Z ;
         gxTv_SdtBR_Pathology_Br_pathology_m_Z = sdt.gxTv_SdtBR_Pathology_Br_pathology_m_Z ;
         gxTv_SdtBR_Pathology_Br_pathology_m_code_Z = sdt.gxTv_SdtBR_Pathology_Br_pathology_m_code_Z ;
         gxTv_SdtBR_Pathology_Br_pathology_metaloc_Z = sdt.gxTv_SdtBR_Pathology_Br_pathology_metaloc_Z ;
         gxTv_SdtBR_Pathology_Br_pathologyid_N = sdt.gxTv_SdtBR_Pathology_Br_pathologyid_N ;
         gxTv_SdtBR_Pathology_Br_encounterid_N = sdt.gxTv_SdtBR_Pathology_Br_encounterid_N ;
         gxTv_SdtBR_Pathology_Br_information_patientno_N = sdt.gxTv_SdtBR_Pathology_Br_information_patientno_N ;
         gxTv_SdtBR_Pathology_Br_pathologyid_testid_N = sdt.gxTv_SdtBR_Pathology_Br_pathologyid_testid_N ;
         gxTv_SdtBR_Pathology_Br_pathologyid_padate_N = sdt.gxTv_SdtBR_Pathology_Br_pathologyid_padate_N ;
         gxTv_SdtBR_Pathology_Br_pathologyid_pahosp_N = sdt.gxTv_SdtBR_Pathology_Br_pathologyid_pahosp_N ;
         gxTv_SdtBR_Pathology_Br_pathologyid_pahosp_code_N = sdt.gxTv_SdtBR_Pathology_Br_pathologyid_pahosp_code_N ;
         gxTv_SdtBR_Pathology_Br_pathologyid_paage_N = sdt.gxTv_SdtBR_Pathology_Br_pathologyid_paage_N ;
         gxTv_SdtBR_Pathology_Br_pathologyid_prepadia_N = sdt.gxTv_SdtBR_Pathology_Br_pathologyid_prepadia_N ;
         gxTv_SdtBR_Pathology_Br_pathologyid_paresult_N = sdt.gxTv_SdtBR_Pathology_Br_pathologyid_paresult_N ;
         gxTv_SdtBR_Pathology_Br_pathology_dia_name_N = sdt.gxTv_SdtBR_Pathology_Br_pathology_dia_name_N ;
         gxTv_SdtBR_Pathology_Br_pathology_t_N = sdt.gxTv_SdtBR_Pathology_Br_pathology_t_N ;
         gxTv_SdtBR_Pathology_Br_pathology_n_N = sdt.gxTv_SdtBR_Pathology_Br_pathology_n_N ;
         gxTv_SdtBR_Pathology_Br_pathology_n_code_N = sdt.gxTv_SdtBR_Pathology_Br_pathology_n_code_N ;
         gxTv_SdtBR_Pathology_Br_pathology_lymphnum_N = sdt.gxTv_SdtBR_Pathology_Br_pathology_lymphnum_N ;
         gxTv_SdtBR_Pathology_Br_pathology_lymphrate_N = sdt.gxTv_SdtBR_Pathology_Br_pathology_lymphrate_N ;
         gxTv_SdtBR_Pathology_Br_pathology_m_N = sdt.gxTv_SdtBR_Pathology_Br_pathology_m_N ;
         gxTv_SdtBR_Pathology_Br_pathology_m_code_N = sdt.gxTv_SdtBR_Pathology_Br_pathology_m_code_N ;
         gxTv_SdtBR_Pathology_Br_pathology_metaloc_N = sdt.gxTv_SdtBR_Pathology_Br_pathology_metaloc_N ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("BR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Pathology_Br_pathologyid), 18, 0)), false);
         AddObjectProperty("BR_PathologyID_N", gxTv_SdtBR_Pathology_Br_pathologyid_N, false);
         AddObjectProperty("BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Pathology_Br_encounterid), 18, 0)), false);
         AddObjectProperty("BR_EncounterID_N", gxTv_SdtBR_Pathology_Br_encounterid_N, false);
         AddObjectProperty("BR_Information_PatientNo", gxTv_SdtBR_Pathology_Br_information_patientno, false);
         AddObjectProperty("BR_Information_PatientNo_N", gxTv_SdtBR_Pathology_Br_information_patientno_N, false);
         AddObjectProperty("BR_PathologyID_TestID", gxTv_SdtBR_Pathology_Br_pathologyid_testid, false);
         AddObjectProperty("BR_PathologyID_TestID_N", gxTv_SdtBR_Pathology_Br_pathologyid_testid_N, false);
         sDateCnv = "";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtBR_Pathology_Br_pathologyid_padate)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtBR_Pathology_Br_pathologyid_padate)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtBR_Pathology_Br_pathologyid_padate)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         AddObjectProperty("BR_PathologyID_PADate", sDateCnv, false);
         AddObjectProperty("BR_PathologyID_PADate_N", gxTv_SdtBR_Pathology_Br_pathologyid_padate_N, false);
         AddObjectProperty("BR_PathologyID_PAHosp", gxTv_SdtBR_Pathology_Br_pathologyid_pahosp, false);
         AddObjectProperty("BR_PathologyID_PAHosp_N", gxTv_SdtBR_Pathology_Br_pathologyid_pahosp_N, false);
         AddObjectProperty("BR_PathologyID_PAHosp_Code", gxTv_SdtBR_Pathology_Br_pathologyid_pahosp_code, false);
         AddObjectProperty("BR_PathologyID_PAHosp_Code_N", gxTv_SdtBR_Pathology_Br_pathologyid_pahosp_code_N, false);
         AddObjectProperty("BR_PathologyID_PAAge", gxTv_SdtBR_Pathology_Br_pathologyid_paage, false);
         AddObjectProperty("BR_PathologyID_PAAge_N", gxTv_SdtBR_Pathology_Br_pathologyid_paage_N, false);
         AddObjectProperty("BR_PathologyID_PrePaDia", gxTv_SdtBR_Pathology_Br_pathologyid_prepadia, false);
         AddObjectProperty("BR_PathologyID_PrePaDia_N", gxTv_SdtBR_Pathology_Br_pathologyid_prepadia_N, false);
         AddObjectProperty("BR_PathologyID_PAResult", gxTv_SdtBR_Pathology_Br_pathologyid_paresult, false);
         AddObjectProperty("BR_PathologyID_PAResult_N", gxTv_SdtBR_Pathology_Br_pathologyid_paresult_N, false);
         AddObjectProperty("BR_Pathology_Dia_Name", gxTv_SdtBR_Pathology_Br_pathology_dia_name, false);
         AddObjectProperty("BR_Pathology_Dia_Name_N", gxTv_SdtBR_Pathology_Br_pathology_dia_name_N, false);
         AddObjectProperty("BR_Pathology_T", gxTv_SdtBR_Pathology_Br_pathology_t, false);
         AddObjectProperty("BR_Pathology_T_N", gxTv_SdtBR_Pathology_Br_pathology_t_N, false);
         AddObjectProperty("BR_Pathology_N", gxTv_SdtBR_Pathology_Br_pathology_n, false);
         AddObjectProperty("BR_Pathology_N_N", gxTv_SdtBR_Pathology_Br_pathology_n_N, false);
         AddObjectProperty("BR_Pathology_N_Code", gxTv_SdtBR_Pathology_Br_pathology_n_code, false);
         AddObjectProperty("BR_Pathology_N_Code_N", gxTv_SdtBR_Pathology_Br_pathology_n_code_N, false);
         AddObjectProperty("BR_Pathology_LymphNum", gxTv_SdtBR_Pathology_Br_pathology_lymphnum, false);
         AddObjectProperty("BR_Pathology_LymphNum_N", gxTv_SdtBR_Pathology_Br_pathology_lymphnum_N, false);
         AddObjectProperty("BR_Pathology_LymphRate", gxTv_SdtBR_Pathology_Br_pathology_lymphrate, false);
         AddObjectProperty("BR_Pathology_LymphRate_N", gxTv_SdtBR_Pathology_Br_pathology_lymphrate_N, false);
         AddObjectProperty("BR_Pathology_M", gxTv_SdtBR_Pathology_Br_pathology_m, false);
         AddObjectProperty("BR_Pathology_M_N", gxTv_SdtBR_Pathology_Br_pathology_m_N, false);
         AddObjectProperty("BR_Pathology_M_Code", gxTv_SdtBR_Pathology_Br_pathology_m_code, false);
         AddObjectProperty("BR_Pathology_M_Code_N", gxTv_SdtBR_Pathology_Br_pathology_m_code_N, false);
         AddObjectProperty("BR_Pathology_MetaLoc", gxTv_SdtBR_Pathology_Br_pathology_metaloc, false);
         AddObjectProperty("BR_Pathology_MetaLoc_N", gxTv_SdtBR_Pathology_Br_pathology_metaloc_N, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtBR_Pathology_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtBR_Pathology_Initialized, false);
            AddObjectProperty("BR_PathologyID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Pathology_Br_pathologyid_Z), 18, 0)), false);
            AddObjectProperty("BR_EncounterID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Pathology_Br_encounterid_Z), 18, 0)), false);
            AddObjectProperty("BR_Information_PatientNo_Z", gxTv_SdtBR_Pathology_Br_information_patientno_Z, false);
            AddObjectProperty("BR_PathologyID_TestID_Z", gxTv_SdtBR_Pathology_Br_pathologyid_testid_Z, false);
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtBR_Pathology_Br_pathologyid_padate_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtBR_Pathology_Br_pathologyid_padate_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtBR_Pathology_Br_pathologyid_padate_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            AddObjectProperty("BR_PathologyID_PADate_Z", sDateCnv, false);
            AddObjectProperty("BR_PathologyID_PAHosp_Z", gxTv_SdtBR_Pathology_Br_pathologyid_pahosp_Z, false);
            AddObjectProperty("BR_PathologyID_PAHosp_Code_Z", gxTv_SdtBR_Pathology_Br_pathologyid_pahosp_code_Z, false);
            AddObjectProperty("BR_PathologyID_PAAge_Z", gxTv_SdtBR_Pathology_Br_pathologyid_paage_Z, false);
            AddObjectProperty("BR_PathologyID_PrePaDia_Z", gxTv_SdtBR_Pathology_Br_pathologyid_prepadia_Z, false);
            AddObjectProperty("BR_PathologyID_PAResult_Z", gxTv_SdtBR_Pathology_Br_pathologyid_paresult_Z, false);
            AddObjectProperty("BR_Pathology_Dia_Name_Z", gxTv_SdtBR_Pathology_Br_pathology_dia_name_Z, false);
            AddObjectProperty("BR_Pathology_T_Z", gxTv_SdtBR_Pathology_Br_pathology_t_Z, false);
            AddObjectProperty("BR_Pathology_N_Z", gxTv_SdtBR_Pathology_Br_pathology_n_Z, false);
            AddObjectProperty("BR_Pathology_N_Code_Z", gxTv_SdtBR_Pathology_Br_pathology_n_code_Z, false);
            AddObjectProperty("BR_Pathology_LymphNum_Z", gxTv_SdtBR_Pathology_Br_pathology_lymphnum_Z, false);
            AddObjectProperty("BR_Pathology_LymphRate_Z", gxTv_SdtBR_Pathology_Br_pathology_lymphrate_Z, false);
            AddObjectProperty("BR_Pathology_M_Z", gxTv_SdtBR_Pathology_Br_pathology_m_Z, false);
            AddObjectProperty("BR_Pathology_M_Code_Z", gxTv_SdtBR_Pathology_Br_pathology_m_code_Z, false);
            AddObjectProperty("BR_Pathology_MetaLoc_Z", gxTv_SdtBR_Pathology_Br_pathology_metaloc_Z, false);
            AddObjectProperty("BR_PathologyID_N", gxTv_SdtBR_Pathology_Br_pathologyid_N, false);
            AddObjectProperty("BR_EncounterID_N", gxTv_SdtBR_Pathology_Br_encounterid_N, false);
            AddObjectProperty("BR_Information_PatientNo_N", gxTv_SdtBR_Pathology_Br_information_patientno_N, false);
            AddObjectProperty("BR_PathologyID_TestID_N", gxTv_SdtBR_Pathology_Br_pathologyid_testid_N, false);
            AddObjectProperty("BR_PathologyID_PADate_N", gxTv_SdtBR_Pathology_Br_pathologyid_padate_N, false);
            AddObjectProperty("BR_PathologyID_PAHosp_N", gxTv_SdtBR_Pathology_Br_pathologyid_pahosp_N, false);
            AddObjectProperty("BR_PathologyID_PAHosp_Code_N", gxTv_SdtBR_Pathology_Br_pathologyid_pahosp_code_N, false);
            AddObjectProperty("BR_PathologyID_PAAge_N", gxTv_SdtBR_Pathology_Br_pathologyid_paage_N, false);
            AddObjectProperty("BR_PathologyID_PrePaDia_N", gxTv_SdtBR_Pathology_Br_pathologyid_prepadia_N, false);
            AddObjectProperty("BR_PathologyID_PAResult_N", gxTv_SdtBR_Pathology_Br_pathologyid_paresult_N, false);
            AddObjectProperty("BR_Pathology_Dia_Name_N", gxTv_SdtBR_Pathology_Br_pathology_dia_name_N, false);
            AddObjectProperty("BR_Pathology_T_N", gxTv_SdtBR_Pathology_Br_pathology_t_N, false);
            AddObjectProperty("BR_Pathology_N_N", gxTv_SdtBR_Pathology_Br_pathology_n_N, false);
            AddObjectProperty("BR_Pathology_N_Code_N", gxTv_SdtBR_Pathology_Br_pathology_n_code_N, false);
            AddObjectProperty("BR_Pathology_LymphNum_N", gxTv_SdtBR_Pathology_Br_pathology_lymphnum_N, false);
            AddObjectProperty("BR_Pathology_LymphRate_N", gxTv_SdtBR_Pathology_Br_pathology_lymphrate_N, false);
            AddObjectProperty("BR_Pathology_M_N", gxTv_SdtBR_Pathology_Br_pathology_m_N, false);
            AddObjectProperty("BR_Pathology_M_Code_N", gxTv_SdtBR_Pathology_Br_pathology_m_code_N, false);
            AddObjectProperty("BR_Pathology_MetaLoc_N", gxTv_SdtBR_Pathology_Br_pathology_metaloc_N, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtBR_Pathology sdt )
      {
         if ( sdt.IsDirty("BR_PathologyID") )
         {
            gxTv_SdtBR_Pathology_Br_pathologyid = sdt.gxTv_SdtBR_Pathology_Br_pathologyid ;
         }
         if ( sdt.IsDirty("BR_EncounterID") )
         {
            gxTv_SdtBR_Pathology_Br_encounterid = sdt.gxTv_SdtBR_Pathology_Br_encounterid ;
         }
         if ( sdt.IsDirty("BR_Information_PatientNo") )
         {
            gxTv_SdtBR_Pathology_Br_information_patientno = sdt.gxTv_SdtBR_Pathology_Br_information_patientno ;
         }
         if ( sdt.IsDirty("BR_PathologyID_TestID") )
         {
            gxTv_SdtBR_Pathology_Br_pathologyid_testid = sdt.gxTv_SdtBR_Pathology_Br_pathologyid_testid ;
         }
         if ( sdt.IsDirty("BR_PathologyID_PADate") )
         {
            gxTv_SdtBR_Pathology_Br_pathologyid_padate = sdt.gxTv_SdtBR_Pathology_Br_pathologyid_padate ;
         }
         if ( sdt.IsDirty("BR_PathologyID_PAHosp") )
         {
            gxTv_SdtBR_Pathology_Br_pathologyid_pahosp = sdt.gxTv_SdtBR_Pathology_Br_pathologyid_pahosp ;
         }
         if ( sdt.IsDirty("BR_PathologyID_PAHosp_Code") )
         {
            gxTv_SdtBR_Pathology_Br_pathologyid_pahosp_code = sdt.gxTv_SdtBR_Pathology_Br_pathologyid_pahosp_code ;
         }
         if ( sdt.IsDirty("BR_PathologyID_PAAge") )
         {
            gxTv_SdtBR_Pathology_Br_pathologyid_paage = sdt.gxTv_SdtBR_Pathology_Br_pathologyid_paage ;
         }
         if ( sdt.IsDirty("BR_PathologyID_PrePaDia") )
         {
            gxTv_SdtBR_Pathology_Br_pathologyid_prepadia = sdt.gxTv_SdtBR_Pathology_Br_pathologyid_prepadia ;
         }
         if ( sdt.IsDirty("BR_PathologyID_PAResult") )
         {
            gxTv_SdtBR_Pathology_Br_pathologyid_paresult = sdt.gxTv_SdtBR_Pathology_Br_pathologyid_paresult ;
         }
         if ( sdt.IsDirty("BR_Pathology_Dia_Name") )
         {
            gxTv_SdtBR_Pathology_Br_pathology_dia_name = sdt.gxTv_SdtBR_Pathology_Br_pathology_dia_name ;
         }
         if ( sdt.IsDirty("BR_Pathology_T") )
         {
            gxTv_SdtBR_Pathology_Br_pathology_t = sdt.gxTv_SdtBR_Pathology_Br_pathology_t ;
         }
         if ( sdt.IsDirty("BR_Pathology_N") )
         {
            gxTv_SdtBR_Pathology_Br_pathology_n = sdt.gxTv_SdtBR_Pathology_Br_pathology_n ;
         }
         if ( sdt.IsDirty("BR_Pathology_N_Code") )
         {
            gxTv_SdtBR_Pathology_Br_pathology_n_code = sdt.gxTv_SdtBR_Pathology_Br_pathology_n_code ;
         }
         if ( sdt.IsDirty("BR_Pathology_LymphNum") )
         {
            gxTv_SdtBR_Pathology_Br_pathology_lymphnum = sdt.gxTv_SdtBR_Pathology_Br_pathology_lymphnum ;
         }
         if ( sdt.IsDirty("BR_Pathology_LymphRate") )
         {
            gxTv_SdtBR_Pathology_Br_pathology_lymphrate = sdt.gxTv_SdtBR_Pathology_Br_pathology_lymphrate ;
         }
         if ( sdt.IsDirty("BR_Pathology_M") )
         {
            gxTv_SdtBR_Pathology_Br_pathology_m = sdt.gxTv_SdtBR_Pathology_Br_pathology_m ;
         }
         if ( sdt.IsDirty("BR_Pathology_M_Code") )
         {
            gxTv_SdtBR_Pathology_Br_pathology_m_code = sdt.gxTv_SdtBR_Pathology_Br_pathology_m_code ;
         }
         if ( sdt.IsDirty("BR_Pathology_MetaLoc") )
         {
            gxTv_SdtBR_Pathology_Br_pathology_metaloc = sdt.gxTv_SdtBR_Pathology_Br_pathology_metaloc ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "BR_PathologyID" )]
      [  XmlElement( ElementName = "BR_PathologyID"   )]
      public long gxTpr_Br_pathologyid
      {
         get {
            return gxTv_SdtBR_Pathology_Br_pathologyid ;
         }

         set {
            if ( gxTv_SdtBR_Pathology_Br_pathologyid != value )
            {
               gxTv_SdtBR_Pathology_Mode = "INS";
               this.gxTv_SdtBR_Pathology_Br_pathologyid_Z_SetNull( );
               this.gxTv_SdtBR_Pathology_Br_encounterid_Z_SetNull( );
               this.gxTv_SdtBR_Pathology_Br_information_patientno_Z_SetNull( );
               this.gxTv_SdtBR_Pathology_Br_pathologyid_testid_Z_SetNull( );
               this.gxTv_SdtBR_Pathology_Br_pathologyid_padate_Z_SetNull( );
               this.gxTv_SdtBR_Pathology_Br_pathologyid_pahosp_Z_SetNull( );
               this.gxTv_SdtBR_Pathology_Br_pathologyid_pahosp_code_Z_SetNull( );
               this.gxTv_SdtBR_Pathology_Br_pathologyid_paage_Z_SetNull( );
               this.gxTv_SdtBR_Pathology_Br_pathologyid_prepadia_Z_SetNull( );
               this.gxTv_SdtBR_Pathology_Br_pathologyid_paresult_Z_SetNull( );
               this.gxTv_SdtBR_Pathology_Br_pathology_dia_name_Z_SetNull( );
               this.gxTv_SdtBR_Pathology_Br_pathology_t_Z_SetNull( );
               this.gxTv_SdtBR_Pathology_Br_pathology_n_Z_SetNull( );
               this.gxTv_SdtBR_Pathology_Br_pathology_n_code_Z_SetNull( );
               this.gxTv_SdtBR_Pathology_Br_pathology_lymphnum_Z_SetNull( );
               this.gxTv_SdtBR_Pathology_Br_pathology_lymphrate_Z_SetNull( );
               this.gxTv_SdtBR_Pathology_Br_pathology_m_Z_SetNull( );
               this.gxTv_SdtBR_Pathology_Br_pathology_m_code_Z_SetNull( );
               this.gxTv_SdtBR_Pathology_Br_pathology_metaloc_Z_SetNull( );
            }
            gxTv_SdtBR_Pathology_Br_pathologyid = value;
            SetDirty("Br_pathologyid");
         }

      }

      [  SoapElement( ElementName = "BR_EncounterID" )]
      [  XmlElement( ElementName = "BR_EncounterID"   )]
      public long gxTpr_Br_encounterid
      {
         get {
            return gxTv_SdtBR_Pathology_Br_encounterid ;
         }

         set {
            gxTv_SdtBR_Pathology_Br_encounterid_N = 0;
            gxTv_SdtBR_Pathology_Br_encounterid = value;
            SetDirty("Br_encounterid");
         }

      }

      public void gxTv_SdtBR_Pathology_Br_encounterid_SetNull( )
      {
         gxTv_SdtBR_Pathology_Br_encounterid_N = 1;
         gxTv_SdtBR_Pathology_Br_encounterid = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Br_encounterid_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Information_PatientNo" )]
      [  XmlElement( ElementName = "BR_Information_PatientNo"   )]
      public String gxTpr_Br_information_patientno
      {
         get {
            return gxTv_SdtBR_Pathology_Br_information_patientno ;
         }

         set {
            gxTv_SdtBR_Pathology_Br_information_patientno_N = 0;
            gxTv_SdtBR_Pathology_Br_information_patientno = value;
            SetDirty("Br_information_patientno");
         }

      }

      public void gxTv_SdtBR_Pathology_Br_information_patientno_SetNull( )
      {
         gxTv_SdtBR_Pathology_Br_information_patientno_N = 1;
         gxTv_SdtBR_Pathology_Br_information_patientno = "";
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Br_information_patientno_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_PathologyID_TestID" )]
      [  XmlElement( ElementName = "BR_PathologyID_TestID"   )]
      public long gxTpr_Br_pathologyid_testid
      {
         get {
            return gxTv_SdtBR_Pathology_Br_pathologyid_testid ;
         }

         set {
            gxTv_SdtBR_Pathology_Br_pathologyid_testid_N = 0;
            gxTv_SdtBR_Pathology_Br_pathologyid_testid = value;
            SetDirty("Br_pathologyid_testid");
         }

      }

      public void gxTv_SdtBR_Pathology_Br_pathologyid_testid_SetNull( )
      {
         gxTv_SdtBR_Pathology_Br_pathologyid_testid_N = 1;
         gxTv_SdtBR_Pathology_Br_pathologyid_testid = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Br_pathologyid_testid_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_PathologyID_PADate" )]
      [  XmlElement( ElementName = "BR_PathologyID_PADate"  , IsNullable=true )]
      public string gxTpr_Br_pathologyid_padate_Nullable
      {
         get {
            if ( gxTv_SdtBR_Pathology_Br_pathologyid_padate == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_SdtBR_Pathology_Br_pathologyid_padate).value ;
         }

         set {
            gxTv_SdtBR_Pathology_Br_pathologyid_padate_N = 0;
            if (String.IsNullOrEmpty(value) || value == GxDateString.NullValue )
               gxTv_SdtBR_Pathology_Br_pathologyid_padate = DateTime.MinValue;
            else
               gxTv_SdtBR_Pathology_Br_pathologyid_padate = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Br_pathologyid_padate
      {
         get {
            return gxTv_SdtBR_Pathology_Br_pathologyid_padate ;
         }

         set {
            gxTv_SdtBR_Pathology_Br_pathologyid_padate_N = 0;
            gxTv_SdtBR_Pathology_Br_pathologyid_padate = value;
            SetDirty("Br_pathologyid_padate");
         }

      }

      public void gxTv_SdtBR_Pathology_Br_pathologyid_padate_SetNull( )
      {
         gxTv_SdtBR_Pathology_Br_pathologyid_padate_N = 1;
         gxTv_SdtBR_Pathology_Br_pathologyid_padate = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Br_pathologyid_padate_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_PathologyID_PAHosp" )]
      [  XmlElement( ElementName = "BR_PathologyID_PAHosp"   )]
      public String gxTpr_Br_pathologyid_pahosp
      {
         get {
            return gxTv_SdtBR_Pathology_Br_pathologyid_pahosp ;
         }

         set {
            gxTv_SdtBR_Pathology_Br_pathologyid_pahosp_N = 0;
            gxTv_SdtBR_Pathology_Br_pathologyid_pahosp = value;
            SetDirty("Br_pathologyid_pahosp");
         }

      }

      public void gxTv_SdtBR_Pathology_Br_pathologyid_pahosp_SetNull( )
      {
         gxTv_SdtBR_Pathology_Br_pathologyid_pahosp_N = 1;
         gxTv_SdtBR_Pathology_Br_pathologyid_pahosp = "";
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Br_pathologyid_pahosp_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_PathologyID_PAHosp_Code" )]
      [  XmlElement( ElementName = "BR_PathologyID_PAHosp_Code"   )]
      public String gxTpr_Br_pathologyid_pahosp_code
      {
         get {
            return gxTv_SdtBR_Pathology_Br_pathologyid_pahosp_code ;
         }

         set {
            gxTv_SdtBR_Pathology_Br_pathologyid_pahosp_code_N = 0;
            gxTv_SdtBR_Pathology_Br_pathologyid_pahosp_code = value;
            SetDirty("Br_pathologyid_pahosp_code");
         }

      }

      public void gxTv_SdtBR_Pathology_Br_pathologyid_pahosp_code_SetNull( )
      {
         gxTv_SdtBR_Pathology_Br_pathologyid_pahosp_code_N = 1;
         gxTv_SdtBR_Pathology_Br_pathologyid_pahosp_code = "";
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Br_pathologyid_pahosp_code_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_PathologyID_PAAge" )]
      [  XmlElement( ElementName = "BR_PathologyID_PAAge"   )]
      public short gxTpr_Br_pathologyid_paage
      {
         get {
            return gxTv_SdtBR_Pathology_Br_pathologyid_paage ;
         }

         set {
            gxTv_SdtBR_Pathology_Br_pathologyid_paage_N = 0;
            gxTv_SdtBR_Pathology_Br_pathologyid_paage = value;
            SetDirty("Br_pathologyid_paage");
         }

      }

      public void gxTv_SdtBR_Pathology_Br_pathologyid_paage_SetNull( )
      {
         gxTv_SdtBR_Pathology_Br_pathologyid_paage_N = 1;
         gxTv_SdtBR_Pathology_Br_pathologyid_paage = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Br_pathologyid_paage_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_PathologyID_PrePaDia" )]
      [  XmlElement( ElementName = "BR_PathologyID_PrePaDia"   )]
      public String gxTpr_Br_pathologyid_prepadia
      {
         get {
            return gxTv_SdtBR_Pathology_Br_pathologyid_prepadia ;
         }

         set {
            gxTv_SdtBR_Pathology_Br_pathologyid_prepadia_N = 0;
            gxTv_SdtBR_Pathology_Br_pathologyid_prepadia = value;
            SetDirty("Br_pathologyid_prepadia");
         }

      }

      public void gxTv_SdtBR_Pathology_Br_pathologyid_prepadia_SetNull( )
      {
         gxTv_SdtBR_Pathology_Br_pathologyid_prepadia_N = 1;
         gxTv_SdtBR_Pathology_Br_pathologyid_prepadia = "";
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Br_pathologyid_prepadia_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_PathologyID_PAResult" )]
      [  XmlElement( ElementName = "BR_PathologyID_PAResult"   )]
      public String gxTpr_Br_pathologyid_paresult
      {
         get {
            return gxTv_SdtBR_Pathology_Br_pathologyid_paresult ;
         }

         set {
            gxTv_SdtBR_Pathology_Br_pathologyid_paresult_N = 0;
            gxTv_SdtBR_Pathology_Br_pathologyid_paresult = value;
            SetDirty("Br_pathologyid_paresult");
         }

      }

      public void gxTv_SdtBR_Pathology_Br_pathologyid_paresult_SetNull( )
      {
         gxTv_SdtBR_Pathology_Br_pathologyid_paresult_N = 1;
         gxTv_SdtBR_Pathology_Br_pathologyid_paresult = "";
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Br_pathologyid_paresult_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_Dia_Name" )]
      [  XmlElement( ElementName = "BR_Pathology_Dia_Name"   )]
      public String gxTpr_Br_pathology_dia_name
      {
         get {
            return gxTv_SdtBR_Pathology_Br_pathology_dia_name ;
         }

         set {
            gxTv_SdtBR_Pathology_Br_pathology_dia_name_N = 0;
            gxTv_SdtBR_Pathology_Br_pathology_dia_name = value;
            SetDirty("Br_pathology_dia_name");
         }

      }

      public void gxTv_SdtBR_Pathology_Br_pathology_dia_name_SetNull( )
      {
         gxTv_SdtBR_Pathology_Br_pathology_dia_name_N = 1;
         gxTv_SdtBR_Pathology_Br_pathology_dia_name = "";
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Br_pathology_dia_name_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_T" )]
      [  XmlElement( ElementName = "BR_Pathology_T"   )]
      public double gxTpr_Br_pathology_t_double
      {
         get {
            return Convert.ToDouble(gxTv_SdtBR_Pathology_Br_pathology_t) ;
         }

         set {
            gxTv_SdtBR_Pathology_Br_pathology_t_N = 0;
            gxTv_SdtBR_Pathology_Br_pathology_t = (decimal)(Convert.ToDecimal( value));
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public decimal gxTpr_Br_pathology_t
      {
         get {
            return gxTv_SdtBR_Pathology_Br_pathology_t ;
         }

         set {
            gxTv_SdtBR_Pathology_Br_pathology_t_N = 0;
            gxTv_SdtBR_Pathology_Br_pathology_t = value;
            SetDirty("Br_pathology_t");
         }

      }

      public void gxTv_SdtBR_Pathology_Br_pathology_t_SetNull( )
      {
         gxTv_SdtBR_Pathology_Br_pathology_t_N = 1;
         gxTv_SdtBR_Pathology_Br_pathology_t = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Br_pathology_t_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_N" )]
      [  XmlElement( ElementName = "BR_Pathology_N"   )]
      public String gxTpr_Br_pathology_n
      {
         get {
            return gxTv_SdtBR_Pathology_Br_pathology_n ;
         }

         set {
            gxTv_SdtBR_Pathology_Br_pathology_n_N = 0;
            gxTv_SdtBR_Pathology_Br_pathology_n = value;
            SetDirty("Br_pathology_n");
         }

      }

      public void gxTv_SdtBR_Pathology_Br_pathology_n_SetNull( )
      {
         gxTv_SdtBR_Pathology_Br_pathology_n_N = 1;
         gxTv_SdtBR_Pathology_Br_pathology_n = "";
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Br_pathology_n_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_N_Code" )]
      [  XmlElement( ElementName = "BR_Pathology_N_Code"   )]
      public String gxTpr_Br_pathology_n_code
      {
         get {
            return gxTv_SdtBR_Pathology_Br_pathology_n_code ;
         }

         set {
            gxTv_SdtBR_Pathology_Br_pathology_n_code_N = 0;
            gxTv_SdtBR_Pathology_Br_pathology_n_code = value;
            SetDirty("Br_pathology_n_code");
         }

      }

      public void gxTv_SdtBR_Pathology_Br_pathology_n_code_SetNull( )
      {
         gxTv_SdtBR_Pathology_Br_pathology_n_code_N = 1;
         gxTv_SdtBR_Pathology_Br_pathology_n_code = "";
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Br_pathology_n_code_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_LymphNum" )]
      [  XmlElement( ElementName = "BR_Pathology_LymphNum"   )]
      public double gxTpr_Br_pathology_lymphnum_double
      {
         get {
            return Convert.ToDouble(gxTv_SdtBR_Pathology_Br_pathology_lymphnum) ;
         }

         set {
            gxTv_SdtBR_Pathology_Br_pathology_lymphnum_N = 0;
            gxTv_SdtBR_Pathology_Br_pathology_lymphnum = (decimal)(Convert.ToDecimal( value));
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public decimal gxTpr_Br_pathology_lymphnum
      {
         get {
            return gxTv_SdtBR_Pathology_Br_pathology_lymphnum ;
         }

         set {
            gxTv_SdtBR_Pathology_Br_pathology_lymphnum_N = 0;
            gxTv_SdtBR_Pathology_Br_pathology_lymphnum = value;
            SetDirty("Br_pathology_lymphnum");
         }

      }

      public void gxTv_SdtBR_Pathology_Br_pathology_lymphnum_SetNull( )
      {
         gxTv_SdtBR_Pathology_Br_pathology_lymphnum_N = 1;
         gxTv_SdtBR_Pathology_Br_pathology_lymphnum = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Br_pathology_lymphnum_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_LymphRate" )]
      [  XmlElement( ElementName = "BR_Pathology_LymphRate"   )]
      public String gxTpr_Br_pathology_lymphrate
      {
         get {
            return gxTv_SdtBR_Pathology_Br_pathology_lymphrate ;
         }

         set {
            gxTv_SdtBR_Pathology_Br_pathology_lymphrate_N = 0;
            gxTv_SdtBR_Pathology_Br_pathology_lymphrate = value;
            SetDirty("Br_pathology_lymphrate");
         }

      }

      public void gxTv_SdtBR_Pathology_Br_pathology_lymphrate_SetNull( )
      {
         gxTv_SdtBR_Pathology_Br_pathology_lymphrate_N = 1;
         gxTv_SdtBR_Pathology_Br_pathology_lymphrate = "";
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Br_pathology_lymphrate_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_M" )]
      [  XmlElement( ElementName = "BR_Pathology_M"   )]
      public String gxTpr_Br_pathology_m
      {
         get {
            return gxTv_SdtBR_Pathology_Br_pathology_m ;
         }

         set {
            gxTv_SdtBR_Pathology_Br_pathology_m_N = 0;
            gxTv_SdtBR_Pathology_Br_pathology_m = value;
            SetDirty("Br_pathology_m");
         }

      }

      public void gxTv_SdtBR_Pathology_Br_pathology_m_SetNull( )
      {
         gxTv_SdtBR_Pathology_Br_pathology_m_N = 1;
         gxTv_SdtBR_Pathology_Br_pathology_m = "";
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Br_pathology_m_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_M_Code" )]
      [  XmlElement( ElementName = "BR_Pathology_M_Code"   )]
      public String gxTpr_Br_pathology_m_code
      {
         get {
            return gxTv_SdtBR_Pathology_Br_pathology_m_code ;
         }

         set {
            gxTv_SdtBR_Pathology_Br_pathology_m_code_N = 0;
            gxTv_SdtBR_Pathology_Br_pathology_m_code = value;
            SetDirty("Br_pathology_m_code");
         }

      }

      public void gxTv_SdtBR_Pathology_Br_pathology_m_code_SetNull( )
      {
         gxTv_SdtBR_Pathology_Br_pathology_m_code_N = 1;
         gxTv_SdtBR_Pathology_Br_pathology_m_code = "";
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Br_pathology_m_code_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_MetaLoc" )]
      [  XmlElement( ElementName = "BR_Pathology_MetaLoc"   )]
      public String gxTpr_Br_pathology_metaloc
      {
         get {
            return gxTv_SdtBR_Pathology_Br_pathology_metaloc ;
         }

         set {
            gxTv_SdtBR_Pathology_Br_pathology_metaloc_N = 0;
            gxTv_SdtBR_Pathology_Br_pathology_metaloc = value;
            SetDirty("Br_pathology_metaloc");
         }

      }

      public void gxTv_SdtBR_Pathology_Br_pathology_metaloc_SetNull( )
      {
         gxTv_SdtBR_Pathology_Br_pathology_metaloc_N = 1;
         gxTv_SdtBR_Pathology_Br_pathology_metaloc = "";
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Br_pathology_metaloc_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtBR_Pathology_Mode ;
         }

         set {
            gxTv_SdtBR_Pathology_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtBR_Pathology_Mode_SetNull( )
      {
         gxTv_SdtBR_Pathology_Mode = "";
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtBR_Pathology_Initialized ;
         }

         set {
            gxTv_SdtBR_Pathology_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtBR_Pathology_Initialized_SetNull( )
      {
         gxTv_SdtBR_Pathology_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_PathologyID_Z" )]
      [  XmlElement( ElementName = "BR_PathologyID_Z"   )]
      public long gxTpr_Br_pathologyid_Z
      {
         get {
            return gxTv_SdtBR_Pathology_Br_pathologyid_Z ;
         }

         set {
            gxTv_SdtBR_Pathology_Br_pathologyid_Z = value;
            SetDirty("Br_pathologyid_Z");
         }

      }

      public void gxTv_SdtBR_Pathology_Br_pathologyid_Z_SetNull( )
      {
         gxTv_SdtBR_Pathology_Br_pathologyid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Br_pathologyid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_EncounterID_Z" )]
      [  XmlElement( ElementName = "BR_EncounterID_Z"   )]
      public long gxTpr_Br_encounterid_Z
      {
         get {
            return gxTv_SdtBR_Pathology_Br_encounterid_Z ;
         }

         set {
            gxTv_SdtBR_Pathology_Br_encounterid_Z = value;
            SetDirty("Br_encounterid_Z");
         }

      }

      public void gxTv_SdtBR_Pathology_Br_encounterid_Z_SetNull( )
      {
         gxTv_SdtBR_Pathology_Br_encounterid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Br_encounterid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Information_PatientNo_Z" )]
      [  XmlElement( ElementName = "BR_Information_PatientNo_Z"   )]
      public String gxTpr_Br_information_patientno_Z
      {
         get {
            return gxTv_SdtBR_Pathology_Br_information_patientno_Z ;
         }

         set {
            gxTv_SdtBR_Pathology_Br_information_patientno_Z = value;
            SetDirty("Br_information_patientno_Z");
         }

      }

      public void gxTv_SdtBR_Pathology_Br_information_patientno_Z_SetNull( )
      {
         gxTv_SdtBR_Pathology_Br_information_patientno_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Br_information_patientno_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_PathologyID_TestID_Z" )]
      [  XmlElement( ElementName = "BR_PathologyID_TestID_Z"   )]
      public long gxTpr_Br_pathologyid_testid_Z
      {
         get {
            return gxTv_SdtBR_Pathology_Br_pathologyid_testid_Z ;
         }

         set {
            gxTv_SdtBR_Pathology_Br_pathologyid_testid_Z = value;
            SetDirty("Br_pathologyid_testid_Z");
         }

      }

      public void gxTv_SdtBR_Pathology_Br_pathologyid_testid_Z_SetNull( )
      {
         gxTv_SdtBR_Pathology_Br_pathologyid_testid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Br_pathologyid_testid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_PathologyID_PADate_Z" )]
      [  XmlElement( ElementName = "BR_PathologyID_PADate_Z"  , IsNullable=true )]
      public string gxTpr_Br_pathologyid_padate_Z_Nullable
      {
         get {
            if ( gxTv_SdtBR_Pathology_Br_pathologyid_padate_Z == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_SdtBR_Pathology_Br_pathologyid_padate_Z).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDateString.NullValue )
               gxTv_SdtBR_Pathology_Br_pathologyid_padate_Z = DateTime.MinValue;
            else
               gxTv_SdtBR_Pathology_Br_pathologyid_padate_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Br_pathologyid_padate_Z
      {
         get {
            return gxTv_SdtBR_Pathology_Br_pathologyid_padate_Z ;
         }

         set {
            gxTv_SdtBR_Pathology_Br_pathologyid_padate_Z = value;
            SetDirty("Br_pathologyid_padate_Z");
         }

      }

      public void gxTv_SdtBR_Pathology_Br_pathologyid_padate_Z_SetNull( )
      {
         gxTv_SdtBR_Pathology_Br_pathologyid_padate_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Br_pathologyid_padate_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_PathologyID_PAHosp_Z" )]
      [  XmlElement( ElementName = "BR_PathologyID_PAHosp_Z"   )]
      public String gxTpr_Br_pathologyid_pahosp_Z
      {
         get {
            return gxTv_SdtBR_Pathology_Br_pathologyid_pahosp_Z ;
         }

         set {
            gxTv_SdtBR_Pathology_Br_pathologyid_pahosp_Z = value;
            SetDirty("Br_pathologyid_pahosp_Z");
         }

      }

      public void gxTv_SdtBR_Pathology_Br_pathologyid_pahosp_Z_SetNull( )
      {
         gxTv_SdtBR_Pathology_Br_pathologyid_pahosp_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Br_pathologyid_pahosp_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_PathologyID_PAHosp_Code_Z" )]
      [  XmlElement( ElementName = "BR_PathologyID_PAHosp_Code_Z"   )]
      public String gxTpr_Br_pathologyid_pahosp_code_Z
      {
         get {
            return gxTv_SdtBR_Pathology_Br_pathologyid_pahosp_code_Z ;
         }

         set {
            gxTv_SdtBR_Pathology_Br_pathologyid_pahosp_code_Z = value;
            SetDirty("Br_pathologyid_pahosp_code_Z");
         }

      }

      public void gxTv_SdtBR_Pathology_Br_pathologyid_pahosp_code_Z_SetNull( )
      {
         gxTv_SdtBR_Pathology_Br_pathologyid_pahosp_code_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Br_pathologyid_pahosp_code_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_PathologyID_PAAge_Z" )]
      [  XmlElement( ElementName = "BR_PathologyID_PAAge_Z"   )]
      public short gxTpr_Br_pathologyid_paage_Z
      {
         get {
            return gxTv_SdtBR_Pathology_Br_pathologyid_paage_Z ;
         }

         set {
            gxTv_SdtBR_Pathology_Br_pathologyid_paage_Z = value;
            SetDirty("Br_pathologyid_paage_Z");
         }

      }

      public void gxTv_SdtBR_Pathology_Br_pathologyid_paage_Z_SetNull( )
      {
         gxTv_SdtBR_Pathology_Br_pathologyid_paage_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Br_pathologyid_paage_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_PathologyID_PrePaDia_Z" )]
      [  XmlElement( ElementName = "BR_PathologyID_PrePaDia_Z"   )]
      public String gxTpr_Br_pathologyid_prepadia_Z
      {
         get {
            return gxTv_SdtBR_Pathology_Br_pathologyid_prepadia_Z ;
         }

         set {
            gxTv_SdtBR_Pathology_Br_pathologyid_prepadia_Z = value;
            SetDirty("Br_pathologyid_prepadia_Z");
         }

      }

      public void gxTv_SdtBR_Pathology_Br_pathologyid_prepadia_Z_SetNull( )
      {
         gxTv_SdtBR_Pathology_Br_pathologyid_prepadia_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Br_pathologyid_prepadia_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_PathologyID_PAResult_Z" )]
      [  XmlElement( ElementName = "BR_PathologyID_PAResult_Z"   )]
      public String gxTpr_Br_pathologyid_paresult_Z
      {
         get {
            return gxTv_SdtBR_Pathology_Br_pathologyid_paresult_Z ;
         }

         set {
            gxTv_SdtBR_Pathology_Br_pathologyid_paresult_Z = value;
            SetDirty("Br_pathologyid_paresult_Z");
         }

      }

      public void gxTv_SdtBR_Pathology_Br_pathologyid_paresult_Z_SetNull( )
      {
         gxTv_SdtBR_Pathology_Br_pathologyid_paresult_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Br_pathologyid_paresult_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_Dia_Name_Z" )]
      [  XmlElement( ElementName = "BR_Pathology_Dia_Name_Z"   )]
      public String gxTpr_Br_pathology_dia_name_Z
      {
         get {
            return gxTv_SdtBR_Pathology_Br_pathology_dia_name_Z ;
         }

         set {
            gxTv_SdtBR_Pathology_Br_pathology_dia_name_Z = value;
            SetDirty("Br_pathology_dia_name_Z");
         }

      }

      public void gxTv_SdtBR_Pathology_Br_pathology_dia_name_Z_SetNull( )
      {
         gxTv_SdtBR_Pathology_Br_pathology_dia_name_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Br_pathology_dia_name_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_T_Z" )]
      [  XmlElement( ElementName = "BR_Pathology_T_Z"   )]
      public double gxTpr_Br_pathology_t_Z_double
      {
         get {
            return Convert.ToDouble(gxTv_SdtBR_Pathology_Br_pathology_t_Z) ;
         }

         set {
            gxTv_SdtBR_Pathology_Br_pathology_t_Z = (decimal)(Convert.ToDecimal( value));
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public decimal gxTpr_Br_pathology_t_Z
      {
         get {
            return gxTv_SdtBR_Pathology_Br_pathology_t_Z ;
         }

         set {
            gxTv_SdtBR_Pathology_Br_pathology_t_Z = value;
            SetDirty("Br_pathology_t_Z");
         }

      }

      public void gxTv_SdtBR_Pathology_Br_pathology_t_Z_SetNull( )
      {
         gxTv_SdtBR_Pathology_Br_pathology_t_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Br_pathology_t_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_N_Z" )]
      [  XmlElement( ElementName = "BR_Pathology_N_Z"   )]
      public String gxTpr_Br_pathology_n_Z
      {
         get {
            return gxTv_SdtBR_Pathology_Br_pathology_n_Z ;
         }

         set {
            gxTv_SdtBR_Pathology_Br_pathology_n_Z = value;
            SetDirty("Br_pathology_n_Z");
         }

      }

      public void gxTv_SdtBR_Pathology_Br_pathology_n_Z_SetNull( )
      {
         gxTv_SdtBR_Pathology_Br_pathology_n_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Br_pathology_n_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_N_Code_Z" )]
      [  XmlElement( ElementName = "BR_Pathology_N_Code_Z"   )]
      public String gxTpr_Br_pathology_n_code_Z
      {
         get {
            return gxTv_SdtBR_Pathology_Br_pathology_n_code_Z ;
         }

         set {
            gxTv_SdtBR_Pathology_Br_pathology_n_code_Z = value;
            SetDirty("Br_pathology_n_code_Z");
         }

      }

      public void gxTv_SdtBR_Pathology_Br_pathology_n_code_Z_SetNull( )
      {
         gxTv_SdtBR_Pathology_Br_pathology_n_code_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Br_pathology_n_code_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_LymphNum_Z" )]
      [  XmlElement( ElementName = "BR_Pathology_LymphNum_Z"   )]
      public double gxTpr_Br_pathology_lymphnum_Z_double
      {
         get {
            return Convert.ToDouble(gxTv_SdtBR_Pathology_Br_pathology_lymphnum_Z) ;
         }

         set {
            gxTv_SdtBR_Pathology_Br_pathology_lymphnum_Z = (decimal)(Convert.ToDecimal( value));
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public decimal gxTpr_Br_pathology_lymphnum_Z
      {
         get {
            return gxTv_SdtBR_Pathology_Br_pathology_lymphnum_Z ;
         }

         set {
            gxTv_SdtBR_Pathology_Br_pathology_lymphnum_Z = value;
            SetDirty("Br_pathology_lymphnum_Z");
         }

      }

      public void gxTv_SdtBR_Pathology_Br_pathology_lymphnum_Z_SetNull( )
      {
         gxTv_SdtBR_Pathology_Br_pathology_lymphnum_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Br_pathology_lymphnum_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_LymphRate_Z" )]
      [  XmlElement( ElementName = "BR_Pathology_LymphRate_Z"   )]
      public String gxTpr_Br_pathology_lymphrate_Z
      {
         get {
            return gxTv_SdtBR_Pathology_Br_pathology_lymphrate_Z ;
         }

         set {
            gxTv_SdtBR_Pathology_Br_pathology_lymphrate_Z = value;
            SetDirty("Br_pathology_lymphrate_Z");
         }

      }

      public void gxTv_SdtBR_Pathology_Br_pathology_lymphrate_Z_SetNull( )
      {
         gxTv_SdtBR_Pathology_Br_pathology_lymphrate_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Br_pathology_lymphrate_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_M_Z" )]
      [  XmlElement( ElementName = "BR_Pathology_M_Z"   )]
      public String gxTpr_Br_pathology_m_Z
      {
         get {
            return gxTv_SdtBR_Pathology_Br_pathology_m_Z ;
         }

         set {
            gxTv_SdtBR_Pathology_Br_pathology_m_Z = value;
            SetDirty("Br_pathology_m_Z");
         }

      }

      public void gxTv_SdtBR_Pathology_Br_pathology_m_Z_SetNull( )
      {
         gxTv_SdtBR_Pathology_Br_pathology_m_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Br_pathology_m_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_M_Code_Z" )]
      [  XmlElement( ElementName = "BR_Pathology_M_Code_Z"   )]
      public String gxTpr_Br_pathology_m_code_Z
      {
         get {
            return gxTv_SdtBR_Pathology_Br_pathology_m_code_Z ;
         }

         set {
            gxTv_SdtBR_Pathology_Br_pathology_m_code_Z = value;
            SetDirty("Br_pathology_m_code_Z");
         }

      }

      public void gxTv_SdtBR_Pathology_Br_pathology_m_code_Z_SetNull( )
      {
         gxTv_SdtBR_Pathology_Br_pathology_m_code_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Br_pathology_m_code_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_MetaLoc_Z" )]
      [  XmlElement( ElementName = "BR_Pathology_MetaLoc_Z"   )]
      public String gxTpr_Br_pathology_metaloc_Z
      {
         get {
            return gxTv_SdtBR_Pathology_Br_pathology_metaloc_Z ;
         }

         set {
            gxTv_SdtBR_Pathology_Br_pathology_metaloc_Z = value;
            SetDirty("Br_pathology_metaloc_Z");
         }

      }

      public void gxTv_SdtBR_Pathology_Br_pathology_metaloc_Z_SetNull( )
      {
         gxTv_SdtBR_Pathology_Br_pathology_metaloc_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Br_pathology_metaloc_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_PathologyID_N" )]
      [  XmlElement( ElementName = "BR_PathologyID_N"   )]
      public short gxTpr_Br_pathologyid_N
      {
         get {
            return gxTv_SdtBR_Pathology_Br_pathologyid_N ;
         }

         set {
            gxTv_SdtBR_Pathology_Br_pathologyid_N = value;
            SetDirty("Br_pathologyid_N");
         }

      }

      public void gxTv_SdtBR_Pathology_Br_pathologyid_N_SetNull( )
      {
         gxTv_SdtBR_Pathology_Br_pathologyid_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Br_pathologyid_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_EncounterID_N" )]
      [  XmlElement( ElementName = "BR_EncounterID_N"   )]
      public short gxTpr_Br_encounterid_N
      {
         get {
            return gxTv_SdtBR_Pathology_Br_encounterid_N ;
         }

         set {
            gxTv_SdtBR_Pathology_Br_encounterid_N = value;
            SetDirty("Br_encounterid_N");
         }

      }

      public void gxTv_SdtBR_Pathology_Br_encounterid_N_SetNull( )
      {
         gxTv_SdtBR_Pathology_Br_encounterid_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Br_encounterid_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Information_PatientNo_N" )]
      [  XmlElement( ElementName = "BR_Information_PatientNo_N"   )]
      public short gxTpr_Br_information_patientno_N
      {
         get {
            return gxTv_SdtBR_Pathology_Br_information_patientno_N ;
         }

         set {
            gxTv_SdtBR_Pathology_Br_information_patientno_N = value;
            SetDirty("Br_information_patientno_N");
         }

      }

      public void gxTv_SdtBR_Pathology_Br_information_patientno_N_SetNull( )
      {
         gxTv_SdtBR_Pathology_Br_information_patientno_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Br_information_patientno_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_PathologyID_TestID_N" )]
      [  XmlElement( ElementName = "BR_PathologyID_TestID_N"   )]
      public short gxTpr_Br_pathologyid_testid_N
      {
         get {
            return gxTv_SdtBR_Pathology_Br_pathologyid_testid_N ;
         }

         set {
            gxTv_SdtBR_Pathology_Br_pathologyid_testid_N = value;
            SetDirty("Br_pathologyid_testid_N");
         }

      }

      public void gxTv_SdtBR_Pathology_Br_pathologyid_testid_N_SetNull( )
      {
         gxTv_SdtBR_Pathology_Br_pathologyid_testid_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Br_pathologyid_testid_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_PathologyID_PADate_N" )]
      [  XmlElement( ElementName = "BR_PathologyID_PADate_N"   )]
      public short gxTpr_Br_pathologyid_padate_N
      {
         get {
            return gxTv_SdtBR_Pathology_Br_pathologyid_padate_N ;
         }

         set {
            gxTv_SdtBR_Pathology_Br_pathologyid_padate_N = value;
            SetDirty("Br_pathologyid_padate_N");
         }

      }

      public void gxTv_SdtBR_Pathology_Br_pathologyid_padate_N_SetNull( )
      {
         gxTv_SdtBR_Pathology_Br_pathologyid_padate_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Br_pathologyid_padate_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_PathologyID_PAHosp_N" )]
      [  XmlElement( ElementName = "BR_PathologyID_PAHosp_N"   )]
      public short gxTpr_Br_pathologyid_pahosp_N
      {
         get {
            return gxTv_SdtBR_Pathology_Br_pathologyid_pahosp_N ;
         }

         set {
            gxTv_SdtBR_Pathology_Br_pathologyid_pahosp_N = value;
            SetDirty("Br_pathologyid_pahosp_N");
         }

      }

      public void gxTv_SdtBR_Pathology_Br_pathologyid_pahosp_N_SetNull( )
      {
         gxTv_SdtBR_Pathology_Br_pathologyid_pahosp_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Br_pathologyid_pahosp_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_PathologyID_PAHosp_Code_N" )]
      [  XmlElement( ElementName = "BR_PathologyID_PAHosp_Code_N"   )]
      public short gxTpr_Br_pathologyid_pahosp_code_N
      {
         get {
            return gxTv_SdtBR_Pathology_Br_pathologyid_pahosp_code_N ;
         }

         set {
            gxTv_SdtBR_Pathology_Br_pathologyid_pahosp_code_N = value;
            SetDirty("Br_pathologyid_pahosp_code_N");
         }

      }

      public void gxTv_SdtBR_Pathology_Br_pathologyid_pahosp_code_N_SetNull( )
      {
         gxTv_SdtBR_Pathology_Br_pathologyid_pahosp_code_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Br_pathologyid_pahosp_code_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_PathologyID_PAAge_N" )]
      [  XmlElement( ElementName = "BR_PathologyID_PAAge_N"   )]
      public short gxTpr_Br_pathologyid_paage_N
      {
         get {
            return gxTv_SdtBR_Pathology_Br_pathologyid_paage_N ;
         }

         set {
            gxTv_SdtBR_Pathology_Br_pathologyid_paage_N = value;
            SetDirty("Br_pathologyid_paage_N");
         }

      }

      public void gxTv_SdtBR_Pathology_Br_pathologyid_paage_N_SetNull( )
      {
         gxTv_SdtBR_Pathology_Br_pathologyid_paage_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Br_pathologyid_paage_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_PathologyID_PrePaDia_N" )]
      [  XmlElement( ElementName = "BR_PathologyID_PrePaDia_N"   )]
      public short gxTpr_Br_pathologyid_prepadia_N
      {
         get {
            return gxTv_SdtBR_Pathology_Br_pathologyid_prepadia_N ;
         }

         set {
            gxTv_SdtBR_Pathology_Br_pathologyid_prepadia_N = value;
            SetDirty("Br_pathologyid_prepadia_N");
         }

      }

      public void gxTv_SdtBR_Pathology_Br_pathologyid_prepadia_N_SetNull( )
      {
         gxTv_SdtBR_Pathology_Br_pathologyid_prepadia_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Br_pathologyid_prepadia_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_PathologyID_PAResult_N" )]
      [  XmlElement( ElementName = "BR_PathologyID_PAResult_N"   )]
      public short gxTpr_Br_pathologyid_paresult_N
      {
         get {
            return gxTv_SdtBR_Pathology_Br_pathologyid_paresult_N ;
         }

         set {
            gxTv_SdtBR_Pathology_Br_pathologyid_paresult_N = value;
            SetDirty("Br_pathologyid_paresult_N");
         }

      }

      public void gxTv_SdtBR_Pathology_Br_pathologyid_paresult_N_SetNull( )
      {
         gxTv_SdtBR_Pathology_Br_pathologyid_paresult_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Br_pathologyid_paresult_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_Dia_Name_N" )]
      [  XmlElement( ElementName = "BR_Pathology_Dia_Name_N"   )]
      public short gxTpr_Br_pathology_dia_name_N
      {
         get {
            return gxTv_SdtBR_Pathology_Br_pathology_dia_name_N ;
         }

         set {
            gxTv_SdtBR_Pathology_Br_pathology_dia_name_N = value;
            SetDirty("Br_pathology_dia_name_N");
         }

      }

      public void gxTv_SdtBR_Pathology_Br_pathology_dia_name_N_SetNull( )
      {
         gxTv_SdtBR_Pathology_Br_pathology_dia_name_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Br_pathology_dia_name_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_T_N" )]
      [  XmlElement( ElementName = "BR_Pathology_T_N"   )]
      public short gxTpr_Br_pathology_t_N
      {
         get {
            return gxTv_SdtBR_Pathology_Br_pathology_t_N ;
         }

         set {
            gxTv_SdtBR_Pathology_Br_pathology_t_N = value;
            SetDirty("Br_pathology_t_N");
         }

      }

      public void gxTv_SdtBR_Pathology_Br_pathology_t_N_SetNull( )
      {
         gxTv_SdtBR_Pathology_Br_pathology_t_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Br_pathology_t_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_N_N" )]
      [  XmlElement( ElementName = "BR_Pathology_N_N"   )]
      public short gxTpr_Br_pathology_n_N
      {
         get {
            return gxTv_SdtBR_Pathology_Br_pathology_n_N ;
         }

         set {
            gxTv_SdtBR_Pathology_Br_pathology_n_N = value;
            SetDirty("Br_pathology_n_N");
         }

      }

      public void gxTv_SdtBR_Pathology_Br_pathology_n_N_SetNull( )
      {
         gxTv_SdtBR_Pathology_Br_pathology_n_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Br_pathology_n_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_N_Code_N" )]
      [  XmlElement( ElementName = "BR_Pathology_N_Code_N"   )]
      public short gxTpr_Br_pathology_n_code_N
      {
         get {
            return gxTv_SdtBR_Pathology_Br_pathology_n_code_N ;
         }

         set {
            gxTv_SdtBR_Pathology_Br_pathology_n_code_N = value;
            SetDirty("Br_pathology_n_code_N");
         }

      }

      public void gxTv_SdtBR_Pathology_Br_pathology_n_code_N_SetNull( )
      {
         gxTv_SdtBR_Pathology_Br_pathology_n_code_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Br_pathology_n_code_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_LymphNum_N" )]
      [  XmlElement( ElementName = "BR_Pathology_LymphNum_N"   )]
      public short gxTpr_Br_pathology_lymphnum_N
      {
         get {
            return gxTv_SdtBR_Pathology_Br_pathology_lymphnum_N ;
         }

         set {
            gxTv_SdtBR_Pathology_Br_pathology_lymphnum_N = value;
            SetDirty("Br_pathology_lymphnum_N");
         }

      }

      public void gxTv_SdtBR_Pathology_Br_pathology_lymphnum_N_SetNull( )
      {
         gxTv_SdtBR_Pathology_Br_pathology_lymphnum_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Br_pathology_lymphnum_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_LymphRate_N" )]
      [  XmlElement( ElementName = "BR_Pathology_LymphRate_N"   )]
      public short gxTpr_Br_pathology_lymphrate_N
      {
         get {
            return gxTv_SdtBR_Pathology_Br_pathology_lymphrate_N ;
         }

         set {
            gxTv_SdtBR_Pathology_Br_pathology_lymphrate_N = value;
            SetDirty("Br_pathology_lymphrate_N");
         }

      }

      public void gxTv_SdtBR_Pathology_Br_pathology_lymphrate_N_SetNull( )
      {
         gxTv_SdtBR_Pathology_Br_pathology_lymphrate_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Br_pathology_lymphrate_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_M_N" )]
      [  XmlElement( ElementName = "BR_Pathology_M_N"   )]
      public short gxTpr_Br_pathology_m_N
      {
         get {
            return gxTv_SdtBR_Pathology_Br_pathology_m_N ;
         }

         set {
            gxTv_SdtBR_Pathology_Br_pathology_m_N = value;
            SetDirty("Br_pathology_m_N");
         }

      }

      public void gxTv_SdtBR_Pathology_Br_pathology_m_N_SetNull( )
      {
         gxTv_SdtBR_Pathology_Br_pathology_m_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Br_pathology_m_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_M_Code_N" )]
      [  XmlElement( ElementName = "BR_Pathology_M_Code_N"   )]
      public short gxTpr_Br_pathology_m_code_N
      {
         get {
            return gxTv_SdtBR_Pathology_Br_pathology_m_code_N ;
         }

         set {
            gxTv_SdtBR_Pathology_Br_pathology_m_code_N = value;
            SetDirty("Br_pathology_m_code_N");
         }

      }

      public void gxTv_SdtBR_Pathology_Br_pathology_m_code_N_SetNull( )
      {
         gxTv_SdtBR_Pathology_Br_pathology_m_code_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Br_pathology_m_code_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_MetaLoc_N" )]
      [  XmlElement( ElementName = "BR_Pathology_MetaLoc_N"   )]
      public short gxTpr_Br_pathology_metaloc_N
      {
         get {
            return gxTv_SdtBR_Pathology_Br_pathology_metaloc_N ;
         }

         set {
            gxTv_SdtBR_Pathology_Br_pathology_metaloc_N = value;
            SetDirty("Br_pathology_metaloc_N");
         }

      }

      public void gxTv_SdtBR_Pathology_Br_pathology_metaloc_N_SetNull( )
      {
         gxTv_SdtBR_Pathology_Br_pathology_metaloc_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Br_pathology_metaloc_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtBR_Pathology_Br_information_patientno = "";
         gxTv_SdtBR_Pathology_Br_pathologyid_padate = DateTime.MinValue;
         gxTv_SdtBR_Pathology_Br_pathologyid_pahosp = "";
         gxTv_SdtBR_Pathology_Br_pathologyid_pahosp_code = "";
         gxTv_SdtBR_Pathology_Br_pathologyid_prepadia = "";
         gxTv_SdtBR_Pathology_Br_pathologyid_paresult = "";
         gxTv_SdtBR_Pathology_Br_pathology_dia_name = "";
         gxTv_SdtBR_Pathology_Br_pathology_n = "";
         gxTv_SdtBR_Pathology_Br_pathology_n_code = "";
         gxTv_SdtBR_Pathology_Br_pathology_lymphrate = "";
         gxTv_SdtBR_Pathology_Br_pathology_m = "";
         gxTv_SdtBR_Pathology_Br_pathology_m_code = "";
         gxTv_SdtBR_Pathology_Br_pathology_metaloc = "";
         gxTv_SdtBR_Pathology_Mode = "";
         gxTv_SdtBR_Pathology_Br_information_patientno_Z = "";
         gxTv_SdtBR_Pathology_Br_pathologyid_padate_Z = DateTime.MinValue;
         gxTv_SdtBR_Pathology_Br_pathologyid_pahosp_Z = "";
         gxTv_SdtBR_Pathology_Br_pathologyid_pahosp_code_Z = "";
         gxTv_SdtBR_Pathology_Br_pathologyid_prepadia_Z = "";
         gxTv_SdtBR_Pathology_Br_pathologyid_paresult_Z = "";
         gxTv_SdtBR_Pathology_Br_pathology_dia_name_Z = "";
         gxTv_SdtBR_Pathology_Br_pathology_n_Z = "";
         gxTv_SdtBR_Pathology_Br_pathology_n_code_Z = "";
         gxTv_SdtBR_Pathology_Br_pathology_lymphrate_Z = "";
         gxTv_SdtBR_Pathology_Br_pathology_m_Z = "";
         gxTv_SdtBR_Pathology_Br_pathology_m_code_Z = "";
         gxTv_SdtBR_Pathology_Br_pathology_metaloc_Z = "";
         sDateCnv = "";
         sNumToPad = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "br_pathology", "GeneXus.Programs.br_pathology_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtBR_Pathology_Br_pathologyid_paage ;
      private short gxTv_SdtBR_Pathology_Initialized ;
      private short gxTv_SdtBR_Pathology_Br_pathologyid_paage_Z ;
      private short gxTv_SdtBR_Pathology_Br_pathologyid_N ;
      private short gxTv_SdtBR_Pathology_Br_encounterid_N ;
      private short gxTv_SdtBR_Pathology_Br_information_patientno_N ;
      private short gxTv_SdtBR_Pathology_Br_pathologyid_testid_N ;
      private short gxTv_SdtBR_Pathology_Br_pathologyid_padate_N ;
      private short gxTv_SdtBR_Pathology_Br_pathologyid_pahosp_N ;
      private short gxTv_SdtBR_Pathology_Br_pathologyid_pahosp_code_N ;
      private short gxTv_SdtBR_Pathology_Br_pathologyid_paage_N ;
      private short gxTv_SdtBR_Pathology_Br_pathologyid_prepadia_N ;
      private short gxTv_SdtBR_Pathology_Br_pathologyid_paresult_N ;
      private short gxTv_SdtBR_Pathology_Br_pathology_dia_name_N ;
      private short gxTv_SdtBR_Pathology_Br_pathology_t_N ;
      private short gxTv_SdtBR_Pathology_Br_pathology_n_N ;
      private short gxTv_SdtBR_Pathology_Br_pathology_n_code_N ;
      private short gxTv_SdtBR_Pathology_Br_pathology_lymphnum_N ;
      private short gxTv_SdtBR_Pathology_Br_pathology_lymphrate_N ;
      private short gxTv_SdtBR_Pathology_Br_pathology_m_N ;
      private short gxTv_SdtBR_Pathology_Br_pathology_m_code_N ;
      private short gxTv_SdtBR_Pathology_Br_pathology_metaloc_N ;
      private long gxTv_SdtBR_Pathology_Br_pathologyid ;
      private long gxTv_SdtBR_Pathology_Br_encounterid ;
      private long gxTv_SdtBR_Pathology_Br_pathologyid_testid ;
      private long gxTv_SdtBR_Pathology_Br_pathologyid_Z ;
      private long gxTv_SdtBR_Pathology_Br_encounterid_Z ;
      private long gxTv_SdtBR_Pathology_Br_pathologyid_testid_Z ;
      private decimal gxTv_SdtBR_Pathology_Br_pathology_t ;
      private decimal gxTv_SdtBR_Pathology_Br_pathology_lymphnum ;
      private decimal gxTv_SdtBR_Pathology_Br_pathology_t_Z ;
      private decimal gxTv_SdtBR_Pathology_Br_pathology_lymphnum_Z ;
      private String gxTv_SdtBR_Pathology_Mode ;
      private String sDateCnv ;
      private String sNumToPad ;
      private DateTime gxTv_SdtBR_Pathology_Br_pathologyid_padate ;
      private DateTime gxTv_SdtBR_Pathology_Br_pathologyid_padate_Z ;
      private String gxTv_SdtBR_Pathology_Br_information_patientno ;
      private String gxTv_SdtBR_Pathology_Br_pathologyid_pahosp ;
      private String gxTv_SdtBR_Pathology_Br_pathologyid_pahosp_code ;
      private String gxTv_SdtBR_Pathology_Br_pathologyid_prepadia ;
      private String gxTv_SdtBR_Pathology_Br_pathologyid_paresult ;
      private String gxTv_SdtBR_Pathology_Br_pathology_dia_name ;
      private String gxTv_SdtBR_Pathology_Br_pathology_n ;
      private String gxTv_SdtBR_Pathology_Br_pathology_n_code ;
      private String gxTv_SdtBR_Pathology_Br_pathology_lymphrate ;
      private String gxTv_SdtBR_Pathology_Br_pathology_m ;
      private String gxTv_SdtBR_Pathology_Br_pathology_m_code ;
      private String gxTv_SdtBR_Pathology_Br_pathology_metaloc ;
      private String gxTv_SdtBR_Pathology_Br_information_patientno_Z ;
      private String gxTv_SdtBR_Pathology_Br_pathologyid_pahosp_Z ;
      private String gxTv_SdtBR_Pathology_Br_pathologyid_pahosp_code_Z ;
      private String gxTv_SdtBR_Pathology_Br_pathologyid_prepadia_Z ;
      private String gxTv_SdtBR_Pathology_Br_pathologyid_paresult_Z ;
      private String gxTv_SdtBR_Pathology_Br_pathology_dia_name_Z ;
      private String gxTv_SdtBR_Pathology_Br_pathology_n_Z ;
      private String gxTv_SdtBR_Pathology_Br_pathology_n_code_Z ;
      private String gxTv_SdtBR_Pathology_Br_pathology_lymphrate_Z ;
      private String gxTv_SdtBR_Pathology_Br_pathology_m_Z ;
      private String gxTv_SdtBR_Pathology_Br_pathology_m_code_Z ;
      private String gxTv_SdtBR_Pathology_Br_pathology_metaloc_Z ;
   }

   [DataContract(Name = @"BR_Pathology", Namespace = "DataAnalysisPlatform")]
   public class SdtBR_Pathology_RESTInterface : GxGenericCollectionItem<SdtBR_Pathology>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtBR_Pathology_RESTInterface( ) : base()
      {
      }

      public SdtBR_Pathology_RESTInterface( SdtBR_Pathology psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "BR_PathologyID" , Order = 0 )]
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

      [DataMember( Name = "BR_PathologyID_TestID" , Order = 3 )]
      [GxSeudo()]
      public String gxTpr_Br_pathologyid_testid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Br_pathologyid_testid), 10, 0)) ;
         }

         set {
            sdt.gxTpr_Br_pathologyid_testid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "BR_PathologyID_PADate" , Order = 4 )]
      [GxSeudo()]
      public String gxTpr_Br_pathologyid_padate
      {
         get {
            return DateTimeUtil.DToC2( sdt.gxTpr_Br_pathologyid_padate) ;
         }

         set {
            sdt.gxTpr_Br_pathologyid_padate = DateTimeUtil.CToD2( value);
         }

      }

      [DataMember( Name = "BR_PathologyID_PAHosp" , Order = 5 )]
      [GxSeudo()]
      public String gxTpr_Br_pathologyid_pahosp
      {
         get {
            return sdt.gxTpr_Br_pathologyid_pahosp ;
         }

         set {
            sdt.gxTpr_Br_pathologyid_pahosp = value;
         }

      }

      [DataMember( Name = "BR_PathologyID_PAHosp_Code" , Order = 6 )]
      [GxSeudo()]
      public String gxTpr_Br_pathologyid_pahosp_code
      {
         get {
            return sdt.gxTpr_Br_pathologyid_pahosp_code ;
         }

         set {
            sdt.gxTpr_Br_pathologyid_pahosp_code = value;
         }

      }

      [DataMember( Name = "BR_PathologyID_PAAge" , Order = 7 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Br_pathologyid_paage
      {
         get {
            return sdt.gxTpr_Br_pathologyid_paage ;
         }

         set {
            sdt.gxTpr_Br_pathologyid_paage = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "BR_PathologyID_PrePaDia" , Order = 8 )]
      [GxSeudo()]
      public String gxTpr_Br_pathologyid_prepadia
      {
         get {
            return sdt.gxTpr_Br_pathologyid_prepadia ;
         }

         set {
            sdt.gxTpr_Br_pathologyid_prepadia = value;
         }

      }

      [DataMember( Name = "BR_PathologyID_PAResult" , Order = 9 )]
      [GxSeudo()]
      public String gxTpr_Br_pathologyid_paresult
      {
         get {
            return sdt.gxTpr_Br_pathologyid_paresult ;
         }

         set {
            sdt.gxTpr_Br_pathologyid_paresult = value;
         }

      }

      [DataMember( Name = "BR_Pathology_Dia_Name" , Order = 10 )]
      [GxSeudo()]
      public String gxTpr_Br_pathology_dia_name
      {
         get {
            return sdt.gxTpr_Br_pathology_dia_name ;
         }

         set {
            sdt.gxTpr_Br_pathology_dia_name = value;
         }

      }

      [DataMember( Name = "BR_Pathology_T" , Order = 11 )]
      [GxSeudo()]
      public String gxTpr_Br_pathology_t
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( sdt.gxTpr_Br_pathology_t, 15, 5)) ;
         }

         set {
            sdt.gxTpr_Br_pathology_t = NumberUtil.Val( value, ".");
         }

      }

      [DataMember( Name = "BR_Pathology_N" , Order = 12 )]
      [GxSeudo()]
      public String gxTpr_Br_pathology_n
      {
         get {
            return sdt.gxTpr_Br_pathology_n ;
         }

         set {
            sdt.gxTpr_Br_pathology_n = value;
         }

      }

      [DataMember( Name = "BR_Pathology_N_Code" , Order = 13 )]
      [GxSeudo()]
      public String gxTpr_Br_pathology_n_code
      {
         get {
            return sdt.gxTpr_Br_pathology_n_code ;
         }

         set {
            sdt.gxTpr_Br_pathology_n_code = value;
         }

      }

      [DataMember( Name = "BR_Pathology_LymphNum" , Order = 14 )]
      [GxSeudo()]
      public String gxTpr_Br_pathology_lymphnum
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( sdt.gxTpr_Br_pathology_lymphnum, 15, 5)) ;
         }

         set {
            sdt.gxTpr_Br_pathology_lymphnum = NumberUtil.Val( value, ".");
         }

      }

      [DataMember( Name = "BR_Pathology_LymphRate" , Order = 15 )]
      [GxSeudo()]
      public String gxTpr_Br_pathology_lymphrate
      {
         get {
            return sdt.gxTpr_Br_pathology_lymphrate ;
         }

         set {
            sdt.gxTpr_Br_pathology_lymphrate = value;
         }

      }

      [DataMember( Name = "BR_Pathology_M" , Order = 16 )]
      [GxSeudo()]
      public String gxTpr_Br_pathology_m
      {
         get {
            return sdt.gxTpr_Br_pathology_m ;
         }

         set {
            sdt.gxTpr_Br_pathology_m = value;
         }

      }

      [DataMember( Name = "BR_Pathology_M_Code" , Order = 17 )]
      [GxSeudo()]
      public String gxTpr_Br_pathology_m_code
      {
         get {
            return sdt.gxTpr_Br_pathology_m_code ;
         }

         set {
            sdt.gxTpr_Br_pathology_m_code = value;
         }

      }

      [DataMember( Name = "BR_Pathology_MetaLoc" , Order = 18 )]
      [GxSeudo()]
      public String gxTpr_Br_pathology_metaloc
      {
         get {
            return sdt.gxTpr_Br_pathology_metaloc ;
         }

         set {
            sdt.gxTpr_Br_pathology_metaloc = value;
         }

      }

      public SdtBR_Pathology sdt
      {
         get {
            return (SdtBR_Pathology)Sdt ;
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
            sdt = new SdtBR_Pathology() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 19 )]
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
