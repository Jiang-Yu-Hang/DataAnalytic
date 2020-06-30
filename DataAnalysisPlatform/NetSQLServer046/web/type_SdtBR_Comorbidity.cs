/*
               File: type_SdtBR_Comorbidity
        Description: 既往病史
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 13:20:19.3
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
   [XmlRoot(ElementName = "BR_Comorbidity" )]
   [XmlType(TypeName =  "BR_Comorbidity" , Namespace = "DataAnalysisPlatform" )]
   [Serializable]
   public class SdtBR_Comorbidity : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtBR_Comorbidity( )
      {
      }

      public SdtBR_Comorbidity( IGxContext context )
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

      public void Load( long AV37BR_ComorbidityID )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(long)AV37BR_ComorbidityID});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"BR_ComorbidityID", typeof(long)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "BR_Comorbidity");
         metadata.Set("BT", "BR_Comorbidity");
         metadata.Set("PK", "[ \"BR_ComorbidityID\" ]");
         metadata.Set("PKAssigned", "[ \"BR_ComorbidityID\" ]");
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
         state.Add("gxTpr_Br_comorbidityid_Z");
         state.Add("gxTpr_Br_encounterid_Z");
         state.Add("gxTpr_Br_information_patientno_Z");
         state.Add("gxTpr_Br_comorbidity_hypertension_Z");
         state.Add("gxTpr_Br_comorbidity_hypertension_code_Z");
         state.Add("gxTpr_Br_comorbidity_diabetes_Z");
         state.Add("gxTpr_Br_comorbidity_diabetes_code_Z");
         state.Add("gxTpr_Br_comorbidity_chd_Z");
         state.Add("gxTpr_Br_comorbidity_chd_code_Z");
         state.Add("gxTpr_Br_comorbidity_hapetitis_Z");
         state.Add("gxTpr_Br_comorbidity_hapetitis_code_Z");
         state.Add("gxTpr_Br_comorbidity_tb_Z");
         state.Add("gxTpr_Br_comorbidity_tb_code_Z");
         state.Add("gxTpr_Br_comorbidity_kidneydisease_Z");
         state.Add("gxTpr_Br_comorbidity_kidneydisease_code_Z");
         state.Add("gxTpr_Br_comorbidity_surgeryhistory_Z");
         state.Add("gxTpr_Br_comorbidity_surgeryhistory_code_Z");
         state.Add("gxTpr_Br_comorbidity_injuryhistory_Z");
         state.Add("gxTpr_Br_comorbidity_injuryhistory_code_Z");
         state.Add("gxTpr_Br_comorbidity_bloodhistory_Z");
         state.Add("gxTpr_Br_comorbidity_bloodhistory_code_Z");
         state.Add("gxTpr_Br_comorbidity_allergy_Z");
         state.Add("gxTpr_Br_comorbidity_allergy_code_Z");
         state.Add("gxTpr_Br_comorbidity_others_Z");
         state.Add("gxTpr_Br_comorbidity_hapetitisb_Z");
         state.Add("gxTpr_Br_comorbidity_hapetitisb_code_Z");
         state.Add("gxTpr_Br_comorbidity_hapetitisc_Z");
         state.Add("gxTpr_Br_comorbidity_hapetitisc_code_Z");
         state.Add("gxTpr_Br_comorbidity_livercirrhosis_Z");
         state.Add("gxTpr_Br_comorbidity_livercirrhosis_code_Z");
         state.Add("gxTpr_Br_comorbidity_druginducedliverinjury_Z");
         state.Add("gxTpr_Br_comorbidity_druginducedliverinjury_code_Z");
         state.Add("gxTpr_Br_information_patientno_N");
         state.Add("gxTpr_Br_comorbidity_hypertension_N");
         state.Add("gxTpr_Br_comorbidity_hypertension_code_N");
         state.Add("gxTpr_Br_comorbidity_diabetes_N");
         state.Add("gxTpr_Br_comorbidity_diabetes_code_N");
         state.Add("gxTpr_Br_comorbidity_chd_N");
         state.Add("gxTpr_Br_comorbidity_chd_code_N");
         state.Add("gxTpr_Br_comorbidity_hapetitis_N");
         state.Add("gxTpr_Br_comorbidity_hapetitis_code_N");
         state.Add("gxTpr_Br_comorbidity_tb_N");
         state.Add("gxTpr_Br_comorbidity_tb_code_N");
         state.Add("gxTpr_Br_comorbidity_kidneydisease_N");
         state.Add("gxTpr_Br_comorbidity_kidneydisease_code_N");
         state.Add("gxTpr_Br_comorbidity_surgeryhistory_N");
         state.Add("gxTpr_Br_comorbidity_surgeryhistory_code_N");
         state.Add("gxTpr_Br_comorbidity_injuryhistory_N");
         state.Add("gxTpr_Br_comorbidity_injuryhistory_code_N");
         state.Add("gxTpr_Br_comorbidity_bloodhistory_N");
         state.Add("gxTpr_Br_comorbidity_bloodhistory_code_N");
         state.Add("gxTpr_Br_comorbidity_allergy_N");
         state.Add("gxTpr_Br_comorbidity_allergy_code_N");
         state.Add("gxTpr_Br_comorbidity_others_N");
         state.Add("gxTpr_Br_comorbidity_hapetitisb_N");
         state.Add("gxTpr_Br_comorbidity_hapetitisb_code_N");
         state.Add("gxTpr_Br_comorbidity_hapetitisc_N");
         state.Add("gxTpr_Br_comorbidity_hapetitisc_code_N");
         state.Add("gxTpr_Br_comorbidity_livercirrhosis_N");
         state.Add("gxTpr_Br_comorbidity_livercirrhosis_code_N");
         state.Add("gxTpr_Br_comorbidity_druginducedliverinjury_N");
         state.Add("gxTpr_Br_comorbidity_druginducedliverinjury_code_N");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtBR_Comorbidity sdt ;
         sdt = (SdtBR_Comorbidity)(source);
         gxTv_SdtBR_Comorbidity_Br_comorbidityid = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidityid ;
         gxTv_SdtBR_Comorbidity_Br_encounterid = sdt.gxTv_SdtBR_Comorbidity_Br_encounterid ;
         gxTv_SdtBR_Comorbidity_Br_information_patientno = sdt.gxTv_SdtBR_Comorbidity_Br_information_patientno ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension_code = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension_code ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes_code = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes_code ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_chd = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_chd ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_chd_code = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_chd_code ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis_code = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis_code ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_tb = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_tb ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_tb_code = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_tb_code ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease_code = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease_code ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory_code = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory_code ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory_code = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory_code ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory_code = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory_code ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy_code = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy_code ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_others = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_others ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb_code = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb_code ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc_code = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc_code ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis_code = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis_code ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury_code = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury_code ;
         gxTv_SdtBR_Comorbidity_Mode = sdt.gxTv_SdtBR_Comorbidity_Mode ;
         gxTv_SdtBR_Comorbidity_Initialized = sdt.gxTv_SdtBR_Comorbidity_Initialized ;
         gxTv_SdtBR_Comorbidity_Br_comorbidityid_Z = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidityid_Z ;
         gxTv_SdtBR_Comorbidity_Br_encounterid_Z = sdt.gxTv_SdtBR_Comorbidity_Br_encounterid_Z ;
         gxTv_SdtBR_Comorbidity_Br_information_patientno_Z = sdt.gxTv_SdtBR_Comorbidity_Br_information_patientno_Z ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension_Z = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension_Z ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension_code_Z = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension_code_Z ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes_Z = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes_Z ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes_code_Z = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes_code_Z ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_chd_Z = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_chd_Z ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_chd_code_Z = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_chd_code_Z ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis_Z = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis_Z ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis_code_Z = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis_code_Z ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_tb_Z = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_tb_Z ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_tb_code_Z = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_tb_code_Z ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease_Z = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease_Z ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease_code_Z = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease_code_Z ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory_Z = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory_Z ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory_code_Z = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory_code_Z ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory_Z = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory_Z ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory_code_Z = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory_code_Z ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory_Z = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory_Z ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory_code_Z = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory_code_Z ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy_Z = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy_Z ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy_code_Z = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy_code_Z ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_others_Z = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_others_Z ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb_Z = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb_Z ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb_code_Z = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb_code_Z ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc_Z = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc_Z ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc_code_Z = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc_code_Z ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis_Z = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis_Z ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis_code_Z = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis_code_Z ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury_Z = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury_Z ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury_code_Z = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury_code_Z ;
         gxTv_SdtBR_Comorbidity_Br_information_patientno_N = sdt.gxTv_SdtBR_Comorbidity_Br_information_patientno_N ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension_N = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension_N ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension_code_N = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension_code_N ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes_N = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes_N ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes_code_N = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes_code_N ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_chd_N = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_chd_N ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_chd_code_N = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_chd_code_N ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis_N = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis_N ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis_code_N = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis_code_N ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_tb_N = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_tb_N ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_tb_code_N = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_tb_code_N ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease_N = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease_N ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease_code_N = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease_code_N ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory_N = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory_N ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory_code_N = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory_code_N ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory_N = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory_N ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory_code_N = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory_code_N ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory_N = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory_N ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory_code_N = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory_code_N ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy_N = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy_N ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy_code_N = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy_code_N ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_others_N = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_others_N ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb_N = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb_N ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb_code_N = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb_code_N ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc_N = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc_N ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc_code_N = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc_code_N ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis_N = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis_N ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis_code_N = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis_code_N ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury_N = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury_N ;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury_code_N = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury_code_N ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("BR_ComorbidityID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Comorbidity_Br_comorbidityid), 18, 0)), false);
         AddObjectProperty("BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Comorbidity_Br_encounterid), 18, 0)), false);
         AddObjectProperty("BR_Information_PatientNo", gxTv_SdtBR_Comorbidity_Br_information_patientno, false);
         AddObjectProperty("BR_Information_PatientNo_N", gxTv_SdtBR_Comorbidity_Br_information_patientno_N, false);
         AddObjectProperty("BR_Comorbidity_Hypertension", gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension, false);
         AddObjectProperty("BR_Comorbidity_Hypertension_N", gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension_N, false);
         AddObjectProperty("BR_Comorbidity_Hypertension_Code", gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension_code, false);
         AddObjectProperty("BR_Comorbidity_Hypertension_Code_N", gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension_code_N, false);
         AddObjectProperty("BR_Comorbidity_Diabetes", gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes, false);
         AddObjectProperty("BR_Comorbidity_Diabetes_N", gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes_N, false);
         AddObjectProperty("BR_Comorbidity_Diabetes_Code", gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes_code, false);
         AddObjectProperty("BR_Comorbidity_Diabetes_Code_N", gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes_code_N, false);
         AddObjectProperty("BR_Comorbidity_CHD", gxTv_SdtBR_Comorbidity_Br_comorbidity_chd, false);
         AddObjectProperty("BR_Comorbidity_CHD_N", gxTv_SdtBR_Comorbidity_Br_comorbidity_chd_N, false);
         AddObjectProperty("BR_Comorbidity_CHD_Code", gxTv_SdtBR_Comorbidity_Br_comorbidity_chd_code, false);
         AddObjectProperty("BR_Comorbidity_CHD_Code_N", gxTv_SdtBR_Comorbidity_Br_comorbidity_chd_code_N, false);
         AddObjectProperty("BR_Comorbidity_Hapetitis", gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis, false);
         AddObjectProperty("BR_Comorbidity_Hapetitis_N", gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis_N, false);
         AddObjectProperty("BR_Comorbidity_Hapetitis_Code", gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis_code, false);
         AddObjectProperty("BR_Comorbidity_Hapetitis_Code_N", gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis_code_N, false);
         AddObjectProperty("BR_Comorbidity_TB", gxTv_SdtBR_Comorbidity_Br_comorbidity_tb, false);
         AddObjectProperty("BR_Comorbidity_TB_N", gxTv_SdtBR_Comorbidity_Br_comorbidity_tb_N, false);
         AddObjectProperty("BR_Comorbidity_TB_Code", gxTv_SdtBR_Comorbidity_Br_comorbidity_tb_code, false);
         AddObjectProperty("BR_Comorbidity_TB_Code_N", gxTv_SdtBR_Comorbidity_Br_comorbidity_tb_code_N, false);
         AddObjectProperty("BR_Comorbidity_KidneyDisease", gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease, false);
         AddObjectProperty("BR_Comorbidity_KidneyDisease_N", gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease_N, false);
         AddObjectProperty("BR_Comorbidity_KidneyDisease_Code", gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease_code, false);
         AddObjectProperty("BR_Comorbidity_KidneyDisease_Code_N", gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease_code_N, false);
         AddObjectProperty("BR_Comorbidity_SurgeryHistory", gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory, false);
         AddObjectProperty("BR_Comorbidity_SurgeryHistory_N", gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory_N, false);
         AddObjectProperty("BR_Comorbidity_SurgeryHistory_Code", gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory_code, false);
         AddObjectProperty("BR_Comorbidity_SurgeryHistory_Code_N", gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory_code_N, false);
         AddObjectProperty("BR_Comorbidity_InjuryHistory", gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory, false);
         AddObjectProperty("BR_Comorbidity_InjuryHistory_N", gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory_N, false);
         AddObjectProperty("BR_Comorbidity_InjuryHistory_Code", gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory_code, false);
         AddObjectProperty("BR_Comorbidity_InjuryHistory_Code_N", gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory_code_N, false);
         AddObjectProperty("BR_Comorbidity_BloodHistory", gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory, false);
         AddObjectProperty("BR_Comorbidity_BloodHistory_N", gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory_N, false);
         AddObjectProperty("BR_Comorbidity_BloodHistory_Code", gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory_code, false);
         AddObjectProperty("BR_Comorbidity_BloodHistory_Code_N", gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory_code_N, false);
         AddObjectProperty("BR_Comorbidity_allergy", gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy, false);
         AddObjectProperty("BR_Comorbidity_allergy_N", gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy_N, false);
         AddObjectProperty("BR_Comorbidity_allergy_Code", gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy_code, false);
         AddObjectProperty("BR_Comorbidity_allergy_Code_N", gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy_code_N, false);
         AddObjectProperty("BR_Comorbidity_Others", gxTv_SdtBR_Comorbidity_Br_comorbidity_others, false);
         AddObjectProperty("BR_Comorbidity_Others_N", gxTv_SdtBR_Comorbidity_Br_comorbidity_others_N, false);
         AddObjectProperty("BR_Comorbidity_HapetitisB", gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb, false);
         AddObjectProperty("BR_Comorbidity_HapetitisB_N", gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb_N, false);
         AddObjectProperty("BR_Comorbidity_HapetitisB_Code", gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb_code, false);
         AddObjectProperty("BR_Comorbidity_HapetitisB_Code_N", gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb_code_N, false);
         AddObjectProperty("BR_Comorbidity_HapetitisC", gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc, false);
         AddObjectProperty("BR_Comorbidity_HapetitisC_N", gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc_N, false);
         AddObjectProperty("BR_Comorbidity_HapetitisC_Code", gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc_code, false);
         AddObjectProperty("BR_Comorbidity_HapetitisC_Code_N", gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc_code_N, false);
         AddObjectProperty("BR_Comorbidity_LiverCirrhosis", gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis, false);
         AddObjectProperty("BR_Comorbidity_LiverCirrhosis_N", gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis_N, false);
         AddObjectProperty("BR_Comorbidity_LiverCirrhosis_Code", gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis_code, false);
         AddObjectProperty("BR_Comorbidity_LiverCirrhosis_Code_N", gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis_code_N, false);
         AddObjectProperty("BR_Comorbidity_Druginducedliverinjury", gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury, false);
         AddObjectProperty("BR_Comorbidity_Druginducedliverinjury_N", gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury_N, false);
         AddObjectProperty("BR_Comorbidity_Druginducedliverinjury_Code", gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury_code, false);
         AddObjectProperty("BR_Comorbidity_Druginducedliverinjury_Code_N", gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury_code_N, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtBR_Comorbidity_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtBR_Comorbidity_Initialized, false);
            AddObjectProperty("BR_ComorbidityID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Comorbidity_Br_comorbidityid_Z), 18, 0)), false);
            AddObjectProperty("BR_EncounterID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Comorbidity_Br_encounterid_Z), 18, 0)), false);
            AddObjectProperty("BR_Information_PatientNo_Z", gxTv_SdtBR_Comorbidity_Br_information_patientno_Z, false);
            AddObjectProperty("BR_Comorbidity_Hypertension_Z", gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension_Z, false);
            AddObjectProperty("BR_Comorbidity_Hypertension_Code_Z", gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension_code_Z, false);
            AddObjectProperty("BR_Comorbidity_Diabetes_Z", gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes_Z, false);
            AddObjectProperty("BR_Comorbidity_Diabetes_Code_Z", gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes_code_Z, false);
            AddObjectProperty("BR_Comorbidity_CHD_Z", gxTv_SdtBR_Comorbidity_Br_comorbidity_chd_Z, false);
            AddObjectProperty("BR_Comorbidity_CHD_Code_Z", gxTv_SdtBR_Comorbidity_Br_comorbidity_chd_code_Z, false);
            AddObjectProperty("BR_Comorbidity_Hapetitis_Z", gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis_Z, false);
            AddObjectProperty("BR_Comorbidity_Hapetitis_Code_Z", gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis_code_Z, false);
            AddObjectProperty("BR_Comorbidity_TB_Z", gxTv_SdtBR_Comorbidity_Br_comorbidity_tb_Z, false);
            AddObjectProperty("BR_Comorbidity_TB_Code_Z", gxTv_SdtBR_Comorbidity_Br_comorbidity_tb_code_Z, false);
            AddObjectProperty("BR_Comorbidity_KidneyDisease_Z", gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease_Z, false);
            AddObjectProperty("BR_Comorbidity_KidneyDisease_Code_Z", gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease_code_Z, false);
            AddObjectProperty("BR_Comorbidity_SurgeryHistory_Z", gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory_Z, false);
            AddObjectProperty("BR_Comorbidity_SurgeryHistory_Code_Z", gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory_code_Z, false);
            AddObjectProperty("BR_Comorbidity_InjuryHistory_Z", gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory_Z, false);
            AddObjectProperty("BR_Comorbidity_InjuryHistory_Code_Z", gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory_code_Z, false);
            AddObjectProperty("BR_Comorbidity_BloodHistory_Z", gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory_Z, false);
            AddObjectProperty("BR_Comorbidity_BloodHistory_Code_Z", gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory_code_Z, false);
            AddObjectProperty("BR_Comorbidity_allergy_Z", gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy_Z, false);
            AddObjectProperty("BR_Comorbidity_allergy_Code_Z", gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy_code_Z, false);
            AddObjectProperty("BR_Comorbidity_Others_Z", gxTv_SdtBR_Comorbidity_Br_comorbidity_others_Z, false);
            AddObjectProperty("BR_Comorbidity_HapetitisB_Z", gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb_Z, false);
            AddObjectProperty("BR_Comorbidity_HapetitisB_Code_Z", gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb_code_Z, false);
            AddObjectProperty("BR_Comorbidity_HapetitisC_Z", gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc_Z, false);
            AddObjectProperty("BR_Comorbidity_HapetitisC_Code_Z", gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc_code_Z, false);
            AddObjectProperty("BR_Comorbidity_LiverCirrhosis_Z", gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis_Z, false);
            AddObjectProperty("BR_Comorbidity_LiverCirrhosis_Code_Z", gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis_code_Z, false);
            AddObjectProperty("BR_Comorbidity_Druginducedliverinjury_Z", gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury_Z, false);
            AddObjectProperty("BR_Comorbidity_Druginducedliverinjury_Code_Z", gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury_code_Z, false);
            AddObjectProperty("BR_Information_PatientNo_N", gxTv_SdtBR_Comorbidity_Br_information_patientno_N, false);
            AddObjectProperty("BR_Comorbidity_Hypertension_N", gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension_N, false);
            AddObjectProperty("BR_Comorbidity_Hypertension_Code_N", gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension_code_N, false);
            AddObjectProperty("BR_Comorbidity_Diabetes_N", gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes_N, false);
            AddObjectProperty("BR_Comorbidity_Diabetes_Code_N", gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes_code_N, false);
            AddObjectProperty("BR_Comorbidity_CHD_N", gxTv_SdtBR_Comorbidity_Br_comorbidity_chd_N, false);
            AddObjectProperty("BR_Comorbidity_CHD_Code_N", gxTv_SdtBR_Comorbidity_Br_comorbidity_chd_code_N, false);
            AddObjectProperty("BR_Comorbidity_Hapetitis_N", gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis_N, false);
            AddObjectProperty("BR_Comorbidity_Hapetitis_Code_N", gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis_code_N, false);
            AddObjectProperty("BR_Comorbidity_TB_N", gxTv_SdtBR_Comorbidity_Br_comorbidity_tb_N, false);
            AddObjectProperty("BR_Comorbidity_TB_Code_N", gxTv_SdtBR_Comorbidity_Br_comorbidity_tb_code_N, false);
            AddObjectProperty("BR_Comorbidity_KidneyDisease_N", gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease_N, false);
            AddObjectProperty("BR_Comorbidity_KidneyDisease_Code_N", gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease_code_N, false);
            AddObjectProperty("BR_Comorbidity_SurgeryHistory_N", gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory_N, false);
            AddObjectProperty("BR_Comorbidity_SurgeryHistory_Code_N", gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory_code_N, false);
            AddObjectProperty("BR_Comorbidity_InjuryHistory_N", gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory_N, false);
            AddObjectProperty("BR_Comorbidity_InjuryHistory_Code_N", gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory_code_N, false);
            AddObjectProperty("BR_Comorbidity_BloodHistory_N", gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory_N, false);
            AddObjectProperty("BR_Comorbidity_BloodHistory_Code_N", gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory_code_N, false);
            AddObjectProperty("BR_Comorbidity_allergy_N", gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy_N, false);
            AddObjectProperty("BR_Comorbidity_allergy_Code_N", gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy_code_N, false);
            AddObjectProperty("BR_Comorbidity_Others_N", gxTv_SdtBR_Comorbidity_Br_comorbidity_others_N, false);
            AddObjectProperty("BR_Comorbidity_HapetitisB_N", gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb_N, false);
            AddObjectProperty("BR_Comorbidity_HapetitisB_Code_N", gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb_code_N, false);
            AddObjectProperty("BR_Comorbidity_HapetitisC_N", gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc_N, false);
            AddObjectProperty("BR_Comorbidity_HapetitisC_Code_N", gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc_code_N, false);
            AddObjectProperty("BR_Comorbidity_LiverCirrhosis_N", gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis_N, false);
            AddObjectProperty("BR_Comorbidity_LiverCirrhosis_Code_N", gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis_code_N, false);
            AddObjectProperty("BR_Comorbidity_Druginducedliverinjury_N", gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury_N, false);
            AddObjectProperty("BR_Comorbidity_Druginducedliverinjury_Code_N", gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury_code_N, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtBR_Comorbidity sdt )
      {
         if ( sdt.IsDirty("BR_ComorbidityID") )
         {
            gxTv_SdtBR_Comorbidity_Br_comorbidityid = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidityid ;
         }
         if ( sdt.IsDirty("BR_EncounterID") )
         {
            gxTv_SdtBR_Comorbidity_Br_encounterid = sdt.gxTv_SdtBR_Comorbidity_Br_encounterid ;
         }
         if ( sdt.IsDirty("BR_Information_PatientNo") )
         {
            gxTv_SdtBR_Comorbidity_Br_information_patientno = sdt.gxTv_SdtBR_Comorbidity_Br_information_patientno ;
         }
         if ( sdt.IsDirty("BR_Comorbidity_Hypertension") )
         {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension ;
         }
         if ( sdt.IsDirty("BR_Comorbidity_Hypertension_Code") )
         {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension_code = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension_code ;
         }
         if ( sdt.IsDirty("BR_Comorbidity_Diabetes") )
         {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes ;
         }
         if ( sdt.IsDirty("BR_Comorbidity_Diabetes_Code") )
         {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes_code = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes_code ;
         }
         if ( sdt.IsDirty("BR_Comorbidity_CHD") )
         {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_chd = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_chd ;
         }
         if ( sdt.IsDirty("BR_Comorbidity_CHD_Code") )
         {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_chd_code = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_chd_code ;
         }
         if ( sdt.IsDirty("BR_Comorbidity_Hapetitis") )
         {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis ;
         }
         if ( sdt.IsDirty("BR_Comorbidity_Hapetitis_Code") )
         {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis_code = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis_code ;
         }
         if ( sdt.IsDirty("BR_Comorbidity_TB") )
         {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_tb = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_tb ;
         }
         if ( sdt.IsDirty("BR_Comorbidity_TB_Code") )
         {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_tb_code = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_tb_code ;
         }
         if ( sdt.IsDirty("BR_Comorbidity_KidneyDisease") )
         {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease ;
         }
         if ( sdt.IsDirty("BR_Comorbidity_KidneyDisease_Code") )
         {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease_code = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease_code ;
         }
         if ( sdt.IsDirty("BR_Comorbidity_SurgeryHistory") )
         {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory ;
         }
         if ( sdt.IsDirty("BR_Comorbidity_SurgeryHistory_Code") )
         {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory_code = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory_code ;
         }
         if ( sdt.IsDirty("BR_Comorbidity_InjuryHistory") )
         {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory ;
         }
         if ( sdt.IsDirty("BR_Comorbidity_InjuryHistory_Code") )
         {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory_code = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory_code ;
         }
         if ( sdt.IsDirty("BR_Comorbidity_BloodHistory") )
         {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory ;
         }
         if ( sdt.IsDirty("BR_Comorbidity_BloodHistory_Code") )
         {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory_code = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory_code ;
         }
         if ( sdt.IsDirty("BR_Comorbidity_allergy") )
         {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy ;
         }
         if ( sdt.IsDirty("BR_Comorbidity_allergy_Code") )
         {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy_code = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy_code ;
         }
         if ( sdt.IsDirty("BR_Comorbidity_Others") )
         {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_others = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_others ;
         }
         if ( sdt.IsDirty("BR_Comorbidity_HapetitisB") )
         {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb ;
         }
         if ( sdt.IsDirty("BR_Comorbidity_HapetitisB_Code") )
         {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb_code = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb_code ;
         }
         if ( sdt.IsDirty("BR_Comorbidity_HapetitisC") )
         {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc ;
         }
         if ( sdt.IsDirty("BR_Comorbidity_HapetitisC_Code") )
         {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc_code = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc_code ;
         }
         if ( sdt.IsDirty("BR_Comorbidity_LiverCirrhosis") )
         {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis ;
         }
         if ( sdt.IsDirty("BR_Comorbidity_LiverCirrhosis_Code") )
         {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis_code = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis_code ;
         }
         if ( sdt.IsDirty("BR_Comorbidity_Druginducedliverinjury") )
         {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury ;
         }
         if ( sdt.IsDirty("BR_Comorbidity_Druginducedliverinjury_Code") )
         {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury_code = sdt.gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury_code ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "BR_ComorbidityID" )]
      [  XmlElement( ElementName = "BR_ComorbidityID"   )]
      public long gxTpr_Br_comorbidityid
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidityid ;
         }

         set {
            if ( gxTv_SdtBR_Comorbidity_Br_comorbidityid != value )
            {
               gxTv_SdtBR_Comorbidity_Mode = "INS";
               this.gxTv_SdtBR_Comorbidity_Br_comorbidityid_Z_SetNull( );
               this.gxTv_SdtBR_Comorbidity_Br_encounterid_Z_SetNull( );
               this.gxTv_SdtBR_Comorbidity_Br_information_patientno_Z_SetNull( );
               this.gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension_Z_SetNull( );
               this.gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension_code_Z_SetNull( );
               this.gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes_Z_SetNull( );
               this.gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes_code_Z_SetNull( );
               this.gxTv_SdtBR_Comorbidity_Br_comorbidity_chd_Z_SetNull( );
               this.gxTv_SdtBR_Comorbidity_Br_comorbidity_chd_code_Z_SetNull( );
               this.gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis_Z_SetNull( );
               this.gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis_code_Z_SetNull( );
               this.gxTv_SdtBR_Comorbidity_Br_comorbidity_tb_Z_SetNull( );
               this.gxTv_SdtBR_Comorbidity_Br_comorbidity_tb_code_Z_SetNull( );
               this.gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease_Z_SetNull( );
               this.gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease_code_Z_SetNull( );
               this.gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory_Z_SetNull( );
               this.gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory_code_Z_SetNull( );
               this.gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory_Z_SetNull( );
               this.gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory_code_Z_SetNull( );
               this.gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory_Z_SetNull( );
               this.gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory_code_Z_SetNull( );
               this.gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy_Z_SetNull( );
               this.gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy_code_Z_SetNull( );
               this.gxTv_SdtBR_Comorbidity_Br_comorbidity_others_Z_SetNull( );
               this.gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb_Z_SetNull( );
               this.gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb_code_Z_SetNull( );
               this.gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc_Z_SetNull( );
               this.gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc_code_Z_SetNull( );
               this.gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis_Z_SetNull( );
               this.gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis_code_Z_SetNull( );
               this.gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury_Z_SetNull( );
               this.gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury_code_Z_SetNull( );
            }
            gxTv_SdtBR_Comorbidity_Br_comorbidityid = value;
            SetDirty("Br_comorbidityid");
         }

      }

      [  SoapElement( ElementName = "BR_EncounterID" )]
      [  XmlElement( ElementName = "BR_EncounterID"   )]
      public long gxTpr_Br_encounterid
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_encounterid ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_encounterid = value;
            SetDirty("Br_encounterid");
         }

      }

      [  SoapElement( ElementName = "BR_Information_PatientNo" )]
      [  XmlElement( ElementName = "BR_Information_PatientNo"   )]
      public String gxTpr_Br_information_patientno
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_information_patientno ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_information_patientno_N = 0;
            gxTv_SdtBR_Comorbidity_Br_information_patientno = value;
            SetDirty("Br_information_patientno");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_information_patientno_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_information_patientno_N = 1;
         gxTv_SdtBR_Comorbidity_Br_information_patientno = "";
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_information_patientno_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_Hypertension" )]
      [  XmlElement( ElementName = "BR_Comorbidity_Hypertension"   )]
      public String gxTpr_Br_comorbidity_hypertension
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension_N = 0;
            gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension = value;
            SetDirty("Br_comorbidity_hypertension");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension_N = 1;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension = "";
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_Hypertension_Code" )]
      [  XmlElement( ElementName = "BR_Comorbidity_Hypertension_Code"   )]
      public String gxTpr_Br_comorbidity_hypertension_code
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension_code ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension_code_N = 0;
            gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension_code = value;
            SetDirty("Br_comorbidity_hypertension_code");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension_code_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension_code_N = 1;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension_code = "";
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension_code_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_Diabetes" )]
      [  XmlElement( ElementName = "BR_Comorbidity_Diabetes"   )]
      public String gxTpr_Br_comorbidity_diabetes
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes_N = 0;
            gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes = value;
            SetDirty("Br_comorbidity_diabetes");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes_N = 1;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes = "";
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_Diabetes_Code" )]
      [  XmlElement( ElementName = "BR_Comorbidity_Diabetes_Code"   )]
      public String gxTpr_Br_comorbidity_diabetes_code
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes_code ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes_code_N = 0;
            gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes_code = value;
            SetDirty("Br_comorbidity_diabetes_code");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes_code_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes_code_N = 1;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes_code = "";
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes_code_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_CHD" )]
      [  XmlElement( ElementName = "BR_Comorbidity_CHD"   )]
      public String gxTpr_Br_comorbidity_chd
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_chd ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_chd_N = 0;
            gxTv_SdtBR_Comorbidity_Br_comorbidity_chd = value;
            SetDirty("Br_comorbidity_chd");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_chd_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_chd_N = 1;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_chd = "";
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_chd_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_CHD_Code" )]
      [  XmlElement( ElementName = "BR_Comorbidity_CHD_Code"   )]
      public String gxTpr_Br_comorbidity_chd_code
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_chd_code ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_chd_code_N = 0;
            gxTv_SdtBR_Comorbidity_Br_comorbidity_chd_code = value;
            SetDirty("Br_comorbidity_chd_code");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_chd_code_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_chd_code_N = 1;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_chd_code = "";
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_chd_code_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_Hapetitis" )]
      [  XmlElement( ElementName = "BR_Comorbidity_Hapetitis"   )]
      public String gxTpr_Br_comorbidity_hapetitis
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis_N = 0;
            gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis = value;
            SetDirty("Br_comorbidity_hapetitis");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis_N = 1;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis = "";
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_Hapetitis_Code" )]
      [  XmlElement( ElementName = "BR_Comorbidity_Hapetitis_Code"   )]
      public String gxTpr_Br_comorbidity_hapetitis_code
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis_code ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis_code_N = 0;
            gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis_code = value;
            SetDirty("Br_comorbidity_hapetitis_code");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis_code_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis_code_N = 1;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis_code = "";
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis_code_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_TB" )]
      [  XmlElement( ElementName = "BR_Comorbidity_TB"   )]
      public String gxTpr_Br_comorbidity_tb
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_tb ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_tb_N = 0;
            gxTv_SdtBR_Comorbidity_Br_comorbidity_tb = value;
            SetDirty("Br_comorbidity_tb");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_tb_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_tb_N = 1;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_tb = "";
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_tb_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_TB_Code" )]
      [  XmlElement( ElementName = "BR_Comorbidity_TB_Code"   )]
      public String gxTpr_Br_comorbidity_tb_code
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_tb_code ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_tb_code_N = 0;
            gxTv_SdtBR_Comorbidity_Br_comorbidity_tb_code = value;
            SetDirty("Br_comorbidity_tb_code");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_tb_code_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_tb_code_N = 1;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_tb_code = "";
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_tb_code_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_KidneyDisease" )]
      [  XmlElement( ElementName = "BR_Comorbidity_KidneyDisease"   )]
      public String gxTpr_Br_comorbidity_kidneydisease
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease_N = 0;
            gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease = value;
            SetDirty("Br_comorbidity_kidneydisease");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease_N = 1;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease = "";
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_KidneyDisease_Code" )]
      [  XmlElement( ElementName = "BR_Comorbidity_KidneyDisease_Code"   )]
      public String gxTpr_Br_comorbidity_kidneydisease_code
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease_code ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease_code_N = 0;
            gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease_code = value;
            SetDirty("Br_comorbidity_kidneydisease_code");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease_code_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease_code_N = 1;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease_code = "";
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease_code_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_SurgeryHistory" )]
      [  XmlElement( ElementName = "BR_Comorbidity_SurgeryHistory"   )]
      public String gxTpr_Br_comorbidity_surgeryhistory
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory_N = 0;
            gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory = value;
            SetDirty("Br_comorbidity_surgeryhistory");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory_N = 1;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory = "";
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_SurgeryHistory_Code" )]
      [  XmlElement( ElementName = "BR_Comorbidity_SurgeryHistory_Code"   )]
      public String gxTpr_Br_comorbidity_surgeryhistory_code
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory_code ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory_code_N = 0;
            gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory_code = value;
            SetDirty("Br_comorbidity_surgeryhistory_code");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory_code_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory_code_N = 1;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory_code = "";
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory_code_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_InjuryHistory" )]
      [  XmlElement( ElementName = "BR_Comorbidity_InjuryHistory"   )]
      public String gxTpr_Br_comorbidity_injuryhistory
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory_N = 0;
            gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory = value;
            SetDirty("Br_comorbidity_injuryhistory");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory_N = 1;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory = "";
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_InjuryHistory_Code" )]
      [  XmlElement( ElementName = "BR_Comorbidity_InjuryHistory_Code"   )]
      public String gxTpr_Br_comorbidity_injuryhistory_code
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory_code ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory_code_N = 0;
            gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory_code = value;
            SetDirty("Br_comorbidity_injuryhistory_code");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory_code_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory_code_N = 1;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory_code = "";
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory_code_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_BloodHistory" )]
      [  XmlElement( ElementName = "BR_Comorbidity_BloodHistory"   )]
      public String gxTpr_Br_comorbidity_bloodhistory
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory_N = 0;
            gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory = value;
            SetDirty("Br_comorbidity_bloodhistory");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory_N = 1;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory = "";
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_BloodHistory_Code" )]
      [  XmlElement( ElementName = "BR_Comorbidity_BloodHistory_Code"   )]
      public String gxTpr_Br_comorbidity_bloodhistory_code
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory_code ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory_code_N = 0;
            gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory_code = value;
            SetDirty("Br_comorbidity_bloodhistory_code");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory_code_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory_code_N = 1;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory_code = "";
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory_code_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_allergy" )]
      [  XmlElement( ElementName = "BR_Comorbidity_allergy"   )]
      public String gxTpr_Br_comorbidity_allergy
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy_N = 0;
            gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy = value;
            SetDirty("Br_comorbidity_allergy");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy_N = 1;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy = "";
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_allergy_Code" )]
      [  XmlElement( ElementName = "BR_Comorbidity_allergy_Code"   )]
      public String gxTpr_Br_comorbidity_allergy_code
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy_code ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy_code_N = 0;
            gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy_code = value;
            SetDirty("Br_comorbidity_allergy_code");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy_code_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy_code_N = 1;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy_code = "";
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy_code_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_Others" )]
      [  XmlElement( ElementName = "BR_Comorbidity_Others"   )]
      public String gxTpr_Br_comorbidity_others
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_others ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_others_N = 0;
            gxTv_SdtBR_Comorbidity_Br_comorbidity_others = value;
            SetDirty("Br_comorbidity_others");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_others_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_others_N = 1;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_others = "";
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_others_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_HapetitisB" )]
      [  XmlElement( ElementName = "BR_Comorbidity_HapetitisB"   )]
      public String gxTpr_Br_comorbidity_hapetitisb
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb_N = 0;
            gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb = value;
            SetDirty("Br_comorbidity_hapetitisb");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb_N = 1;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb = "";
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_HapetitisB_Code" )]
      [  XmlElement( ElementName = "BR_Comorbidity_HapetitisB_Code"   )]
      public String gxTpr_Br_comorbidity_hapetitisb_code
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb_code ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb_code_N = 0;
            gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb_code = value;
            SetDirty("Br_comorbidity_hapetitisb_code");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb_code_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb_code_N = 1;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb_code = "";
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb_code_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_HapetitisC" )]
      [  XmlElement( ElementName = "BR_Comorbidity_HapetitisC"   )]
      public String gxTpr_Br_comorbidity_hapetitisc
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc_N = 0;
            gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc = value;
            SetDirty("Br_comorbidity_hapetitisc");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc_N = 1;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc = "";
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_HapetitisC_Code" )]
      [  XmlElement( ElementName = "BR_Comorbidity_HapetitisC_Code"   )]
      public String gxTpr_Br_comorbidity_hapetitisc_code
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc_code ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc_code_N = 0;
            gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc_code = value;
            SetDirty("Br_comorbidity_hapetitisc_code");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc_code_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc_code_N = 1;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc_code = "";
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc_code_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_LiverCirrhosis" )]
      [  XmlElement( ElementName = "BR_Comorbidity_LiverCirrhosis"   )]
      public String gxTpr_Br_comorbidity_livercirrhosis
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis_N = 0;
            gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis = value;
            SetDirty("Br_comorbidity_livercirrhosis");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis_N = 1;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis = "";
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_LiverCirrhosis_Code" )]
      [  XmlElement( ElementName = "BR_Comorbidity_LiverCirrhosis_Code"   )]
      public String gxTpr_Br_comorbidity_livercirrhosis_code
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis_code ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis_code_N = 0;
            gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis_code = value;
            SetDirty("Br_comorbidity_livercirrhosis_code");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis_code_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis_code_N = 1;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis_code = "";
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis_code_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_Druginducedliverinjury" )]
      [  XmlElement( ElementName = "BR_Comorbidity_Druginducedliverinjury"   )]
      public String gxTpr_Br_comorbidity_druginducedliverinjury
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury_N = 0;
            gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury = value;
            SetDirty("Br_comorbidity_druginducedliverinjury");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury_N = 1;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury = "";
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_Druginducedliverinjury_Code" )]
      [  XmlElement( ElementName = "BR_Comorbidity_Druginducedliverinjury_Code"   )]
      public String gxTpr_Br_comorbidity_druginducedliverinjury_code
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury_code ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury_code_N = 0;
            gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury_code = value;
            SetDirty("Br_comorbidity_druginducedliverinjury_code");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury_code_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury_code_N = 1;
         gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury_code = "";
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury_code_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtBR_Comorbidity_Mode ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Mode_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Mode = "";
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtBR_Comorbidity_Initialized ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Initialized_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_ComorbidityID_Z" )]
      [  XmlElement( ElementName = "BR_ComorbidityID_Z"   )]
      public long gxTpr_Br_comorbidityid_Z
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidityid_Z ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidityid_Z = value;
            SetDirty("Br_comorbidityid_Z");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidityid_Z_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidityid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidityid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_EncounterID_Z" )]
      [  XmlElement( ElementName = "BR_EncounterID_Z"   )]
      public long gxTpr_Br_encounterid_Z
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_encounterid_Z ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_encounterid_Z = value;
            SetDirty("Br_encounterid_Z");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_encounterid_Z_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_encounterid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_encounterid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Information_PatientNo_Z" )]
      [  XmlElement( ElementName = "BR_Information_PatientNo_Z"   )]
      public String gxTpr_Br_information_patientno_Z
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_information_patientno_Z ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_information_patientno_Z = value;
            SetDirty("Br_information_patientno_Z");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_information_patientno_Z_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_information_patientno_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_information_patientno_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_Hypertension_Z" )]
      [  XmlElement( ElementName = "BR_Comorbidity_Hypertension_Z"   )]
      public String gxTpr_Br_comorbidity_hypertension_Z
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension_Z ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension_Z = value;
            SetDirty("Br_comorbidity_hypertension_Z");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension_Z_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_Hypertension_Code_Z" )]
      [  XmlElement( ElementName = "BR_Comorbidity_Hypertension_Code_Z"   )]
      public String gxTpr_Br_comorbidity_hypertension_code_Z
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension_code_Z ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension_code_Z = value;
            SetDirty("Br_comorbidity_hypertension_code_Z");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension_code_Z_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension_code_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension_code_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_Diabetes_Z" )]
      [  XmlElement( ElementName = "BR_Comorbidity_Diabetes_Z"   )]
      public String gxTpr_Br_comorbidity_diabetes_Z
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes_Z ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes_Z = value;
            SetDirty("Br_comorbidity_diabetes_Z");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes_Z_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_Diabetes_Code_Z" )]
      [  XmlElement( ElementName = "BR_Comorbidity_Diabetes_Code_Z"   )]
      public String gxTpr_Br_comorbidity_diabetes_code_Z
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes_code_Z ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes_code_Z = value;
            SetDirty("Br_comorbidity_diabetes_code_Z");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes_code_Z_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes_code_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes_code_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_CHD_Z" )]
      [  XmlElement( ElementName = "BR_Comorbidity_CHD_Z"   )]
      public String gxTpr_Br_comorbidity_chd_Z
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_chd_Z ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_chd_Z = value;
            SetDirty("Br_comorbidity_chd_Z");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_chd_Z_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_chd_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_chd_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_CHD_Code_Z" )]
      [  XmlElement( ElementName = "BR_Comorbidity_CHD_Code_Z"   )]
      public String gxTpr_Br_comorbidity_chd_code_Z
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_chd_code_Z ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_chd_code_Z = value;
            SetDirty("Br_comorbidity_chd_code_Z");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_chd_code_Z_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_chd_code_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_chd_code_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_Hapetitis_Z" )]
      [  XmlElement( ElementName = "BR_Comorbidity_Hapetitis_Z"   )]
      public String gxTpr_Br_comorbidity_hapetitis_Z
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis_Z ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis_Z = value;
            SetDirty("Br_comorbidity_hapetitis_Z");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis_Z_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_Hapetitis_Code_Z" )]
      [  XmlElement( ElementName = "BR_Comorbidity_Hapetitis_Code_Z"   )]
      public String gxTpr_Br_comorbidity_hapetitis_code_Z
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis_code_Z ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis_code_Z = value;
            SetDirty("Br_comorbidity_hapetitis_code_Z");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis_code_Z_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis_code_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis_code_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_TB_Z" )]
      [  XmlElement( ElementName = "BR_Comorbidity_TB_Z"   )]
      public String gxTpr_Br_comorbidity_tb_Z
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_tb_Z ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_tb_Z = value;
            SetDirty("Br_comorbidity_tb_Z");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_tb_Z_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_tb_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_tb_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_TB_Code_Z" )]
      [  XmlElement( ElementName = "BR_Comorbidity_TB_Code_Z"   )]
      public String gxTpr_Br_comorbidity_tb_code_Z
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_tb_code_Z ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_tb_code_Z = value;
            SetDirty("Br_comorbidity_tb_code_Z");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_tb_code_Z_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_tb_code_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_tb_code_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_KidneyDisease_Z" )]
      [  XmlElement( ElementName = "BR_Comorbidity_KidneyDisease_Z"   )]
      public String gxTpr_Br_comorbidity_kidneydisease_Z
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease_Z ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease_Z = value;
            SetDirty("Br_comorbidity_kidneydisease_Z");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease_Z_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_KidneyDisease_Code_Z" )]
      [  XmlElement( ElementName = "BR_Comorbidity_KidneyDisease_Code_Z"   )]
      public String gxTpr_Br_comorbidity_kidneydisease_code_Z
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease_code_Z ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease_code_Z = value;
            SetDirty("Br_comorbidity_kidneydisease_code_Z");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease_code_Z_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease_code_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease_code_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_SurgeryHistory_Z" )]
      [  XmlElement( ElementName = "BR_Comorbidity_SurgeryHistory_Z"   )]
      public String gxTpr_Br_comorbidity_surgeryhistory_Z
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory_Z ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory_Z = value;
            SetDirty("Br_comorbidity_surgeryhistory_Z");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory_Z_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_SurgeryHistory_Code_Z" )]
      [  XmlElement( ElementName = "BR_Comorbidity_SurgeryHistory_Code_Z"   )]
      public String gxTpr_Br_comorbidity_surgeryhistory_code_Z
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory_code_Z ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory_code_Z = value;
            SetDirty("Br_comorbidity_surgeryhistory_code_Z");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory_code_Z_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory_code_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory_code_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_InjuryHistory_Z" )]
      [  XmlElement( ElementName = "BR_Comorbidity_InjuryHistory_Z"   )]
      public String gxTpr_Br_comorbidity_injuryhistory_Z
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory_Z ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory_Z = value;
            SetDirty("Br_comorbidity_injuryhistory_Z");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory_Z_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_InjuryHistory_Code_Z" )]
      [  XmlElement( ElementName = "BR_Comorbidity_InjuryHistory_Code_Z"   )]
      public String gxTpr_Br_comorbidity_injuryhistory_code_Z
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory_code_Z ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory_code_Z = value;
            SetDirty("Br_comorbidity_injuryhistory_code_Z");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory_code_Z_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory_code_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory_code_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_BloodHistory_Z" )]
      [  XmlElement( ElementName = "BR_Comorbidity_BloodHistory_Z"   )]
      public String gxTpr_Br_comorbidity_bloodhistory_Z
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory_Z ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory_Z = value;
            SetDirty("Br_comorbidity_bloodhistory_Z");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory_Z_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_BloodHistory_Code_Z" )]
      [  XmlElement( ElementName = "BR_Comorbidity_BloodHistory_Code_Z"   )]
      public String gxTpr_Br_comorbidity_bloodhistory_code_Z
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory_code_Z ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory_code_Z = value;
            SetDirty("Br_comorbidity_bloodhistory_code_Z");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory_code_Z_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory_code_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory_code_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_allergy_Z" )]
      [  XmlElement( ElementName = "BR_Comorbidity_allergy_Z"   )]
      public String gxTpr_Br_comorbidity_allergy_Z
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy_Z ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy_Z = value;
            SetDirty("Br_comorbidity_allergy_Z");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy_Z_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_allergy_Code_Z" )]
      [  XmlElement( ElementName = "BR_Comorbidity_allergy_Code_Z"   )]
      public String gxTpr_Br_comorbidity_allergy_code_Z
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy_code_Z ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy_code_Z = value;
            SetDirty("Br_comorbidity_allergy_code_Z");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy_code_Z_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy_code_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy_code_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_Others_Z" )]
      [  XmlElement( ElementName = "BR_Comorbidity_Others_Z"   )]
      public String gxTpr_Br_comorbidity_others_Z
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_others_Z ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_others_Z = value;
            SetDirty("Br_comorbidity_others_Z");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_others_Z_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_others_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_others_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_HapetitisB_Z" )]
      [  XmlElement( ElementName = "BR_Comorbidity_HapetitisB_Z"   )]
      public String gxTpr_Br_comorbidity_hapetitisb_Z
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb_Z ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb_Z = value;
            SetDirty("Br_comorbidity_hapetitisb_Z");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb_Z_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_HapetitisB_Code_Z" )]
      [  XmlElement( ElementName = "BR_Comorbidity_HapetitisB_Code_Z"   )]
      public String gxTpr_Br_comorbidity_hapetitisb_code_Z
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb_code_Z ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb_code_Z = value;
            SetDirty("Br_comorbidity_hapetitisb_code_Z");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb_code_Z_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb_code_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb_code_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_HapetitisC_Z" )]
      [  XmlElement( ElementName = "BR_Comorbidity_HapetitisC_Z"   )]
      public String gxTpr_Br_comorbidity_hapetitisc_Z
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc_Z ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc_Z = value;
            SetDirty("Br_comorbidity_hapetitisc_Z");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc_Z_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_HapetitisC_Code_Z" )]
      [  XmlElement( ElementName = "BR_Comorbidity_HapetitisC_Code_Z"   )]
      public String gxTpr_Br_comorbidity_hapetitisc_code_Z
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc_code_Z ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc_code_Z = value;
            SetDirty("Br_comorbidity_hapetitisc_code_Z");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc_code_Z_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc_code_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc_code_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_LiverCirrhosis_Z" )]
      [  XmlElement( ElementName = "BR_Comorbidity_LiverCirrhosis_Z"   )]
      public String gxTpr_Br_comorbidity_livercirrhosis_Z
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis_Z ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis_Z = value;
            SetDirty("Br_comorbidity_livercirrhosis_Z");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis_Z_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_LiverCirrhosis_Code_Z" )]
      [  XmlElement( ElementName = "BR_Comorbidity_LiverCirrhosis_Code_Z"   )]
      public String gxTpr_Br_comorbidity_livercirrhosis_code_Z
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis_code_Z ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis_code_Z = value;
            SetDirty("Br_comorbidity_livercirrhosis_code_Z");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis_code_Z_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis_code_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis_code_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_Druginducedliverinjury_Z" )]
      [  XmlElement( ElementName = "BR_Comorbidity_Druginducedliverinjury_Z"   )]
      public String gxTpr_Br_comorbidity_druginducedliverinjury_Z
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury_Z ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury_Z = value;
            SetDirty("Br_comorbidity_druginducedliverinjury_Z");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury_Z_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_Druginducedliverinjury_Code_Z" )]
      [  XmlElement( ElementName = "BR_Comorbidity_Druginducedliverinjury_Code_Z"   )]
      public String gxTpr_Br_comorbidity_druginducedliverinjury_code_Z
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury_code_Z ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury_code_Z = value;
            SetDirty("Br_comorbidity_druginducedliverinjury_code_Z");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury_code_Z_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury_code_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury_code_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Information_PatientNo_N" )]
      [  XmlElement( ElementName = "BR_Information_PatientNo_N"   )]
      public short gxTpr_Br_information_patientno_N
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_information_patientno_N ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_information_patientno_N = value;
            SetDirty("Br_information_patientno_N");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_information_patientno_N_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_information_patientno_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_information_patientno_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_Hypertension_N" )]
      [  XmlElement( ElementName = "BR_Comorbidity_Hypertension_N"   )]
      public short gxTpr_Br_comorbidity_hypertension_N
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension_N ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension_N = value;
            SetDirty("Br_comorbidity_hypertension_N");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension_N_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_Hypertension_Code_N" )]
      [  XmlElement( ElementName = "BR_Comorbidity_Hypertension_Code_N"   )]
      public short gxTpr_Br_comorbidity_hypertension_code_N
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension_code_N ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension_code_N = value;
            SetDirty("Br_comorbidity_hypertension_code_N");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension_code_N_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension_code_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension_code_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_Diabetes_N" )]
      [  XmlElement( ElementName = "BR_Comorbidity_Diabetes_N"   )]
      public short gxTpr_Br_comorbidity_diabetes_N
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes_N ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes_N = value;
            SetDirty("Br_comorbidity_diabetes_N");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes_N_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_Diabetes_Code_N" )]
      [  XmlElement( ElementName = "BR_Comorbidity_Diabetes_Code_N"   )]
      public short gxTpr_Br_comorbidity_diabetes_code_N
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes_code_N ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes_code_N = value;
            SetDirty("Br_comorbidity_diabetes_code_N");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes_code_N_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes_code_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes_code_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_CHD_N" )]
      [  XmlElement( ElementName = "BR_Comorbidity_CHD_N"   )]
      public short gxTpr_Br_comorbidity_chd_N
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_chd_N ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_chd_N = value;
            SetDirty("Br_comorbidity_chd_N");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_chd_N_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_chd_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_chd_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_CHD_Code_N" )]
      [  XmlElement( ElementName = "BR_Comorbidity_CHD_Code_N"   )]
      public short gxTpr_Br_comorbidity_chd_code_N
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_chd_code_N ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_chd_code_N = value;
            SetDirty("Br_comorbidity_chd_code_N");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_chd_code_N_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_chd_code_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_chd_code_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_Hapetitis_N" )]
      [  XmlElement( ElementName = "BR_Comorbidity_Hapetitis_N"   )]
      public short gxTpr_Br_comorbidity_hapetitis_N
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis_N ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis_N = value;
            SetDirty("Br_comorbidity_hapetitis_N");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis_N_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_Hapetitis_Code_N" )]
      [  XmlElement( ElementName = "BR_Comorbidity_Hapetitis_Code_N"   )]
      public short gxTpr_Br_comorbidity_hapetitis_code_N
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis_code_N ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis_code_N = value;
            SetDirty("Br_comorbidity_hapetitis_code_N");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis_code_N_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis_code_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis_code_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_TB_N" )]
      [  XmlElement( ElementName = "BR_Comorbidity_TB_N"   )]
      public short gxTpr_Br_comorbidity_tb_N
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_tb_N ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_tb_N = value;
            SetDirty("Br_comorbidity_tb_N");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_tb_N_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_tb_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_tb_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_TB_Code_N" )]
      [  XmlElement( ElementName = "BR_Comorbidity_TB_Code_N"   )]
      public short gxTpr_Br_comorbidity_tb_code_N
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_tb_code_N ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_tb_code_N = value;
            SetDirty("Br_comorbidity_tb_code_N");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_tb_code_N_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_tb_code_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_tb_code_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_KidneyDisease_N" )]
      [  XmlElement( ElementName = "BR_Comorbidity_KidneyDisease_N"   )]
      public short gxTpr_Br_comorbidity_kidneydisease_N
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease_N ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease_N = value;
            SetDirty("Br_comorbidity_kidneydisease_N");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease_N_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_KidneyDisease_Code_N" )]
      [  XmlElement( ElementName = "BR_Comorbidity_KidneyDisease_Code_N"   )]
      public short gxTpr_Br_comorbidity_kidneydisease_code_N
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease_code_N ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease_code_N = value;
            SetDirty("Br_comorbidity_kidneydisease_code_N");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease_code_N_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease_code_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease_code_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_SurgeryHistory_N" )]
      [  XmlElement( ElementName = "BR_Comorbidity_SurgeryHistory_N"   )]
      public short gxTpr_Br_comorbidity_surgeryhistory_N
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory_N ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory_N = value;
            SetDirty("Br_comorbidity_surgeryhistory_N");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory_N_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_SurgeryHistory_Code_N" )]
      [  XmlElement( ElementName = "BR_Comorbidity_SurgeryHistory_Code_N"   )]
      public short gxTpr_Br_comorbidity_surgeryhistory_code_N
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory_code_N ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory_code_N = value;
            SetDirty("Br_comorbidity_surgeryhistory_code_N");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory_code_N_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory_code_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory_code_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_InjuryHistory_N" )]
      [  XmlElement( ElementName = "BR_Comorbidity_InjuryHistory_N"   )]
      public short gxTpr_Br_comorbidity_injuryhistory_N
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory_N ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory_N = value;
            SetDirty("Br_comorbidity_injuryhistory_N");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory_N_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_InjuryHistory_Code_N" )]
      [  XmlElement( ElementName = "BR_Comorbidity_InjuryHistory_Code_N"   )]
      public short gxTpr_Br_comorbidity_injuryhistory_code_N
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory_code_N ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory_code_N = value;
            SetDirty("Br_comorbidity_injuryhistory_code_N");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory_code_N_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory_code_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory_code_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_BloodHistory_N" )]
      [  XmlElement( ElementName = "BR_Comorbidity_BloodHistory_N"   )]
      public short gxTpr_Br_comorbidity_bloodhistory_N
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory_N ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory_N = value;
            SetDirty("Br_comorbidity_bloodhistory_N");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory_N_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_BloodHistory_Code_N" )]
      [  XmlElement( ElementName = "BR_Comorbidity_BloodHistory_Code_N"   )]
      public short gxTpr_Br_comorbidity_bloodhistory_code_N
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory_code_N ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory_code_N = value;
            SetDirty("Br_comorbidity_bloodhistory_code_N");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory_code_N_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory_code_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory_code_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_allergy_N" )]
      [  XmlElement( ElementName = "BR_Comorbidity_allergy_N"   )]
      public short gxTpr_Br_comorbidity_allergy_N
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy_N ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy_N = value;
            SetDirty("Br_comorbidity_allergy_N");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy_N_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_allergy_Code_N" )]
      [  XmlElement( ElementName = "BR_Comorbidity_allergy_Code_N"   )]
      public short gxTpr_Br_comorbidity_allergy_code_N
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy_code_N ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy_code_N = value;
            SetDirty("Br_comorbidity_allergy_code_N");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy_code_N_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy_code_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy_code_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_Others_N" )]
      [  XmlElement( ElementName = "BR_Comorbidity_Others_N"   )]
      public short gxTpr_Br_comorbidity_others_N
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_others_N ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_others_N = value;
            SetDirty("Br_comorbidity_others_N");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_others_N_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_others_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_others_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_HapetitisB_N" )]
      [  XmlElement( ElementName = "BR_Comorbidity_HapetitisB_N"   )]
      public short gxTpr_Br_comorbidity_hapetitisb_N
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb_N ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb_N = value;
            SetDirty("Br_comorbidity_hapetitisb_N");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb_N_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_HapetitisB_Code_N" )]
      [  XmlElement( ElementName = "BR_Comorbidity_HapetitisB_Code_N"   )]
      public short gxTpr_Br_comorbidity_hapetitisb_code_N
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb_code_N ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb_code_N = value;
            SetDirty("Br_comorbidity_hapetitisb_code_N");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb_code_N_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb_code_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb_code_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_HapetitisC_N" )]
      [  XmlElement( ElementName = "BR_Comorbidity_HapetitisC_N"   )]
      public short gxTpr_Br_comorbidity_hapetitisc_N
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc_N ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc_N = value;
            SetDirty("Br_comorbidity_hapetitisc_N");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc_N_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_HapetitisC_Code_N" )]
      [  XmlElement( ElementName = "BR_Comorbidity_HapetitisC_Code_N"   )]
      public short gxTpr_Br_comorbidity_hapetitisc_code_N
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc_code_N ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc_code_N = value;
            SetDirty("Br_comorbidity_hapetitisc_code_N");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc_code_N_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc_code_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc_code_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_LiverCirrhosis_N" )]
      [  XmlElement( ElementName = "BR_Comorbidity_LiverCirrhosis_N"   )]
      public short gxTpr_Br_comorbidity_livercirrhosis_N
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis_N ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis_N = value;
            SetDirty("Br_comorbidity_livercirrhosis_N");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis_N_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_LiverCirrhosis_Code_N" )]
      [  XmlElement( ElementName = "BR_Comorbidity_LiverCirrhosis_Code_N"   )]
      public short gxTpr_Br_comorbidity_livercirrhosis_code_N
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis_code_N ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis_code_N = value;
            SetDirty("Br_comorbidity_livercirrhosis_code_N");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis_code_N_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis_code_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis_code_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_Druginducedliverinjury_N" )]
      [  XmlElement( ElementName = "BR_Comorbidity_Druginducedliverinjury_N"   )]
      public short gxTpr_Br_comorbidity_druginducedliverinjury_N
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury_N ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury_N = value;
            SetDirty("Br_comorbidity_druginducedliverinjury_N");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury_N_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Comorbidity_Druginducedliverinjury_Code_N" )]
      [  XmlElement( ElementName = "BR_Comorbidity_Druginducedliverinjury_Code_N"   )]
      public short gxTpr_Br_comorbidity_druginducedliverinjury_code_N
      {
         get {
            return gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury_code_N ;
         }

         set {
            gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury_code_N = value;
            SetDirty("Br_comorbidity_druginducedliverinjury_code_N");
         }

      }

      public void gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury_code_N_SetNull( )
      {
         gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury_code_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury_code_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtBR_Comorbidity_Br_information_patientno = "";
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension = "";
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension_code = "";
         gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes = "";
         gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes_code = "";
         gxTv_SdtBR_Comorbidity_Br_comorbidity_chd = "";
         gxTv_SdtBR_Comorbidity_Br_comorbidity_chd_code = "";
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis = "";
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis_code = "";
         gxTv_SdtBR_Comorbidity_Br_comorbidity_tb = "";
         gxTv_SdtBR_Comorbidity_Br_comorbidity_tb_code = "";
         gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease = "";
         gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease_code = "";
         gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory = "";
         gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory_code = "";
         gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory = "";
         gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory_code = "";
         gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory = "";
         gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory_code = "";
         gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy = "";
         gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy_code = "";
         gxTv_SdtBR_Comorbidity_Br_comorbidity_others = "";
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb = "";
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb_code = "";
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc = "";
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc_code = "";
         gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis = "";
         gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis_code = "";
         gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury = "";
         gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury_code = "";
         gxTv_SdtBR_Comorbidity_Mode = "";
         gxTv_SdtBR_Comorbidity_Br_information_patientno_Z = "";
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension_Z = "";
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension_code_Z = "";
         gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes_Z = "";
         gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes_code_Z = "";
         gxTv_SdtBR_Comorbidity_Br_comorbidity_chd_Z = "";
         gxTv_SdtBR_Comorbidity_Br_comorbidity_chd_code_Z = "";
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis_Z = "";
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis_code_Z = "";
         gxTv_SdtBR_Comorbidity_Br_comorbidity_tb_Z = "";
         gxTv_SdtBR_Comorbidity_Br_comorbidity_tb_code_Z = "";
         gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease_Z = "";
         gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease_code_Z = "";
         gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory_Z = "";
         gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory_code_Z = "";
         gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory_Z = "";
         gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory_code_Z = "";
         gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory_Z = "";
         gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory_code_Z = "";
         gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy_Z = "";
         gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy_code_Z = "";
         gxTv_SdtBR_Comorbidity_Br_comorbidity_others_Z = "";
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb_Z = "";
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb_code_Z = "";
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc_Z = "";
         gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc_code_Z = "";
         gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis_Z = "";
         gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis_code_Z = "";
         gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury_Z = "";
         gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury_code_Z = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "br_comorbidity", "GeneXus.Programs.br_comorbidity_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtBR_Comorbidity_Initialized ;
      private short gxTv_SdtBR_Comorbidity_Br_information_patientno_N ;
      private short gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension_N ;
      private short gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension_code_N ;
      private short gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes_N ;
      private short gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes_code_N ;
      private short gxTv_SdtBR_Comorbidity_Br_comorbidity_chd_N ;
      private short gxTv_SdtBR_Comorbidity_Br_comorbidity_chd_code_N ;
      private short gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis_N ;
      private short gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis_code_N ;
      private short gxTv_SdtBR_Comorbidity_Br_comorbidity_tb_N ;
      private short gxTv_SdtBR_Comorbidity_Br_comorbidity_tb_code_N ;
      private short gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease_N ;
      private short gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease_code_N ;
      private short gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory_N ;
      private short gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory_code_N ;
      private short gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory_N ;
      private short gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory_code_N ;
      private short gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory_N ;
      private short gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory_code_N ;
      private short gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy_N ;
      private short gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy_code_N ;
      private short gxTv_SdtBR_Comorbidity_Br_comorbidity_others_N ;
      private short gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb_N ;
      private short gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb_code_N ;
      private short gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc_N ;
      private short gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc_code_N ;
      private short gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis_N ;
      private short gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis_code_N ;
      private short gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury_N ;
      private short gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury_code_N ;
      private long gxTv_SdtBR_Comorbidity_Br_comorbidityid ;
      private long gxTv_SdtBR_Comorbidity_Br_encounterid ;
      private long gxTv_SdtBR_Comorbidity_Br_comorbidityid_Z ;
      private long gxTv_SdtBR_Comorbidity_Br_encounterid_Z ;
      private String gxTv_SdtBR_Comorbidity_Mode ;
      private String gxTv_SdtBR_Comorbidity_Br_information_patientno ;
      private String gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension ;
      private String gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension_code ;
      private String gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes ;
      private String gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes_code ;
      private String gxTv_SdtBR_Comorbidity_Br_comorbidity_chd ;
      private String gxTv_SdtBR_Comorbidity_Br_comorbidity_chd_code ;
      private String gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis ;
      private String gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis_code ;
      private String gxTv_SdtBR_Comorbidity_Br_comorbidity_tb ;
      private String gxTv_SdtBR_Comorbidity_Br_comorbidity_tb_code ;
      private String gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease ;
      private String gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease_code ;
      private String gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory ;
      private String gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory_code ;
      private String gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory ;
      private String gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory_code ;
      private String gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory ;
      private String gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory_code ;
      private String gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy ;
      private String gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy_code ;
      private String gxTv_SdtBR_Comorbidity_Br_comorbidity_others ;
      private String gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb ;
      private String gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb_code ;
      private String gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc ;
      private String gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc_code ;
      private String gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis ;
      private String gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis_code ;
      private String gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury ;
      private String gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury_code ;
      private String gxTv_SdtBR_Comorbidity_Br_information_patientno_Z ;
      private String gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension_Z ;
      private String gxTv_SdtBR_Comorbidity_Br_comorbidity_hypertension_code_Z ;
      private String gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes_Z ;
      private String gxTv_SdtBR_Comorbidity_Br_comorbidity_diabetes_code_Z ;
      private String gxTv_SdtBR_Comorbidity_Br_comorbidity_chd_Z ;
      private String gxTv_SdtBR_Comorbidity_Br_comorbidity_chd_code_Z ;
      private String gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis_Z ;
      private String gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitis_code_Z ;
      private String gxTv_SdtBR_Comorbidity_Br_comorbidity_tb_Z ;
      private String gxTv_SdtBR_Comorbidity_Br_comorbidity_tb_code_Z ;
      private String gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease_Z ;
      private String gxTv_SdtBR_Comorbidity_Br_comorbidity_kidneydisease_code_Z ;
      private String gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory_Z ;
      private String gxTv_SdtBR_Comorbidity_Br_comorbidity_surgeryhistory_code_Z ;
      private String gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory_Z ;
      private String gxTv_SdtBR_Comorbidity_Br_comorbidity_injuryhistory_code_Z ;
      private String gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory_Z ;
      private String gxTv_SdtBR_Comorbidity_Br_comorbidity_bloodhistory_code_Z ;
      private String gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy_Z ;
      private String gxTv_SdtBR_Comorbidity_Br_comorbidity_allergy_code_Z ;
      private String gxTv_SdtBR_Comorbidity_Br_comorbidity_others_Z ;
      private String gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb_Z ;
      private String gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisb_code_Z ;
      private String gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc_Z ;
      private String gxTv_SdtBR_Comorbidity_Br_comorbidity_hapetitisc_code_Z ;
      private String gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis_Z ;
      private String gxTv_SdtBR_Comorbidity_Br_comorbidity_livercirrhosis_code_Z ;
      private String gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury_Z ;
      private String gxTv_SdtBR_Comorbidity_Br_comorbidity_druginducedliverinjury_code_Z ;
   }

   [DataContract(Name = @"BR_Comorbidity", Namespace = "DataAnalysisPlatform")]
   public class SdtBR_Comorbidity_RESTInterface : GxGenericCollectionItem<SdtBR_Comorbidity>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtBR_Comorbidity_RESTInterface( ) : base()
      {
      }

      public SdtBR_Comorbidity_RESTInterface( SdtBR_Comorbidity psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "BR_ComorbidityID" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Br_comorbidityid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Br_comorbidityid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Br_comorbidityid = (long)(NumberUtil.Val( value, "."));
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

      [DataMember( Name = "BR_Comorbidity_Hypertension" , Order = 3 )]
      [GxSeudo()]
      public String gxTpr_Br_comorbidity_hypertension
      {
         get {
            return sdt.gxTpr_Br_comorbidity_hypertension ;
         }

         set {
            sdt.gxTpr_Br_comorbidity_hypertension = value;
         }

      }

      [DataMember( Name = "BR_Comorbidity_Hypertension_Code" , Order = 4 )]
      [GxSeudo()]
      public String gxTpr_Br_comorbidity_hypertension_code
      {
         get {
            return sdt.gxTpr_Br_comorbidity_hypertension_code ;
         }

         set {
            sdt.gxTpr_Br_comorbidity_hypertension_code = value;
         }

      }

      [DataMember( Name = "BR_Comorbidity_Diabetes" , Order = 5 )]
      [GxSeudo()]
      public String gxTpr_Br_comorbidity_diabetes
      {
         get {
            return sdt.gxTpr_Br_comorbidity_diabetes ;
         }

         set {
            sdt.gxTpr_Br_comorbidity_diabetes = value;
         }

      }

      [DataMember( Name = "BR_Comorbidity_Diabetes_Code" , Order = 6 )]
      [GxSeudo()]
      public String gxTpr_Br_comorbidity_diabetes_code
      {
         get {
            return sdt.gxTpr_Br_comorbidity_diabetes_code ;
         }

         set {
            sdt.gxTpr_Br_comorbidity_diabetes_code = value;
         }

      }

      [DataMember( Name = "BR_Comorbidity_CHD" , Order = 7 )]
      [GxSeudo()]
      public String gxTpr_Br_comorbidity_chd
      {
         get {
            return sdt.gxTpr_Br_comorbidity_chd ;
         }

         set {
            sdt.gxTpr_Br_comorbidity_chd = value;
         }

      }

      [DataMember( Name = "BR_Comorbidity_CHD_Code" , Order = 8 )]
      [GxSeudo()]
      public String gxTpr_Br_comorbidity_chd_code
      {
         get {
            return sdt.gxTpr_Br_comorbidity_chd_code ;
         }

         set {
            sdt.gxTpr_Br_comorbidity_chd_code = value;
         }

      }

      [DataMember( Name = "BR_Comorbidity_Hapetitis" , Order = 9 )]
      [GxSeudo()]
      public String gxTpr_Br_comorbidity_hapetitis
      {
         get {
            return sdt.gxTpr_Br_comorbidity_hapetitis ;
         }

         set {
            sdt.gxTpr_Br_comorbidity_hapetitis = value;
         }

      }

      [DataMember( Name = "BR_Comorbidity_Hapetitis_Code" , Order = 10 )]
      [GxSeudo()]
      public String gxTpr_Br_comorbidity_hapetitis_code
      {
         get {
            return sdt.gxTpr_Br_comorbidity_hapetitis_code ;
         }

         set {
            sdt.gxTpr_Br_comorbidity_hapetitis_code = value;
         }

      }

      [DataMember( Name = "BR_Comorbidity_TB" , Order = 11 )]
      [GxSeudo()]
      public String gxTpr_Br_comorbidity_tb
      {
         get {
            return sdt.gxTpr_Br_comorbidity_tb ;
         }

         set {
            sdt.gxTpr_Br_comorbidity_tb = value;
         }

      }

      [DataMember( Name = "BR_Comorbidity_TB_Code" , Order = 12 )]
      [GxSeudo()]
      public String gxTpr_Br_comorbidity_tb_code
      {
         get {
            return sdt.gxTpr_Br_comorbidity_tb_code ;
         }

         set {
            sdt.gxTpr_Br_comorbidity_tb_code = value;
         }

      }

      [DataMember( Name = "BR_Comorbidity_KidneyDisease" , Order = 13 )]
      [GxSeudo()]
      public String gxTpr_Br_comorbidity_kidneydisease
      {
         get {
            return sdt.gxTpr_Br_comorbidity_kidneydisease ;
         }

         set {
            sdt.gxTpr_Br_comorbidity_kidneydisease = value;
         }

      }

      [DataMember( Name = "BR_Comorbidity_KidneyDisease_Code" , Order = 14 )]
      [GxSeudo()]
      public String gxTpr_Br_comorbidity_kidneydisease_code
      {
         get {
            return sdt.gxTpr_Br_comorbidity_kidneydisease_code ;
         }

         set {
            sdt.gxTpr_Br_comorbidity_kidneydisease_code = value;
         }

      }

      [DataMember( Name = "BR_Comorbidity_SurgeryHistory" , Order = 15 )]
      [GxSeudo()]
      public String gxTpr_Br_comorbidity_surgeryhistory
      {
         get {
            return sdt.gxTpr_Br_comorbidity_surgeryhistory ;
         }

         set {
            sdt.gxTpr_Br_comorbidity_surgeryhistory = value;
         }

      }

      [DataMember( Name = "BR_Comorbidity_SurgeryHistory_Code" , Order = 16 )]
      [GxSeudo()]
      public String gxTpr_Br_comorbidity_surgeryhistory_code
      {
         get {
            return sdt.gxTpr_Br_comorbidity_surgeryhistory_code ;
         }

         set {
            sdt.gxTpr_Br_comorbidity_surgeryhistory_code = value;
         }

      }

      [DataMember( Name = "BR_Comorbidity_InjuryHistory" , Order = 17 )]
      [GxSeudo()]
      public String gxTpr_Br_comorbidity_injuryhistory
      {
         get {
            return sdt.gxTpr_Br_comorbidity_injuryhistory ;
         }

         set {
            sdt.gxTpr_Br_comorbidity_injuryhistory = value;
         }

      }

      [DataMember( Name = "BR_Comorbidity_InjuryHistory_Code" , Order = 18 )]
      [GxSeudo()]
      public String gxTpr_Br_comorbidity_injuryhistory_code
      {
         get {
            return sdt.gxTpr_Br_comorbidity_injuryhistory_code ;
         }

         set {
            sdt.gxTpr_Br_comorbidity_injuryhistory_code = value;
         }

      }

      [DataMember( Name = "BR_Comorbidity_BloodHistory" , Order = 19 )]
      [GxSeudo()]
      public String gxTpr_Br_comorbidity_bloodhistory
      {
         get {
            return sdt.gxTpr_Br_comorbidity_bloodhistory ;
         }

         set {
            sdt.gxTpr_Br_comorbidity_bloodhistory = value;
         }

      }

      [DataMember( Name = "BR_Comorbidity_BloodHistory_Code" , Order = 20 )]
      [GxSeudo()]
      public String gxTpr_Br_comorbidity_bloodhistory_code
      {
         get {
            return sdt.gxTpr_Br_comorbidity_bloodhistory_code ;
         }

         set {
            sdt.gxTpr_Br_comorbidity_bloodhistory_code = value;
         }

      }

      [DataMember( Name = "BR_Comorbidity_allergy" , Order = 21 )]
      [GxSeudo()]
      public String gxTpr_Br_comorbidity_allergy
      {
         get {
            return sdt.gxTpr_Br_comorbidity_allergy ;
         }

         set {
            sdt.gxTpr_Br_comorbidity_allergy = value;
         }

      }

      [DataMember( Name = "BR_Comorbidity_allergy_Code" , Order = 22 )]
      [GxSeudo()]
      public String gxTpr_Br_comorbidity_allergy_code
      {
         get {
            return sdt.gxTpr_Br_comorbidity_allergy_code ;
         }

         set {
            sdt.gxTpr_Br_comorbidity_allergy_code = value;
         }

      }

      [DataMember( Name = "BR_Comorbidity_Others" , Order = 23 )]
      [GxSeudo()]
      public String gxTpr_Br_comorbidity_others
      {
         get {
            return sdt.gxTpr_Br_comorbidity_others ;
         }

         set {
            sdt.gxTpr_Br_comorbidity_others = value;
         }

      }

      [DataMember( Name = "BR_Comorbidity_HapetitisB" , Order = 24 )]
      [GxSeudo()]
      public String gxTpr_Br_comorbidity_hapetitisb
      {
         get {
            return sdt.gxTpr_Br_comorbidity_hapetitisb ;
         }

         set {
            sdt.gxTpr_Br_comorbidity_hapetitisb = value;
         }

      }

      [DataMember( Name = "BR_Comorbidity_HapetitisB_Code" , Order = 25 )]
      [GxSeudo()]
      public String gxTpr_Br_comorbidity_hapetitisb_code
      {
         get {
            return sdt.gxTpr_Br_comorbidity_hapetitisb_code ;
         }

         set {
            sdt.gxTpr_Br_comorbidity_hapetitisb_code = value;
         }

      }

      [DataMember( Name = "BR_Comorbidity_HapetitisC" , Order = 26 )]
      [GxSeudo()]
      public String gxTpr_Br_comorbidity_hapetitisc
      {
         get {
            return sdt.gxTpr_Br_comorbidity_hapetitisc ;
         }

         set {
            sdt.gxTpr_Br_comorbidity_hapetitisc = value;
         }

      }

      [DataMember( Name = "BR_Comorbidity_HapetitisC_Code" , Order = 27 )]
      [GxSeudo()]
      public String gxTpr_Br_comorbidity_hapetitisc_code
      {
         get {
            return sdt.gxTpr_Br_comorbidity_hapetitisc_code ;
         }

         set {
            sdt.gxTpr_Br_comorbidity_hapetitisc_code = value;
         }

      }

      [DataMember( Name = "BR_Comorbidity_LiverCirrhosis" , Order = 28 )]
      [GxSeudo()]
      public String gxTpr_Br_comorbidity_livercirrhosis
      {
         get {
            return sdt.gxTpr_Br_comorbidity_livercirrhosis ;
         }

         set {
            sdt.gxTpr_Br_comorbidity_livercirrhosis = value;
         }

      }

      [DataMember( Name = "BR_Comorbidity_LiverCirrhosis_Code" , Order = 29 )]
      [GxSeudo()]
      public String gxTpr_Br_comorbidity_livercirrhosis_code
      {
         get {
            return sdt.gxTpr_Br_comorbidity_livercirrhosis_code ;
         }

         set {
            sdt.gxTpr_Br_comorbidity_livercirrhosis_code = value;
         }

      }

      [DataMember( Name = "BR_Comorbidity_Druginducedliverinjury" , Order = 30 )]
      [GxSeudo()]
      public String gxTpr_Br_comorbidity_druginducedliverinjury
      {
         get {
            return sdt.gxTpr_Br_comorbidity_druginducedliverinjury ;
         }

         set {
            sdt.gxTpr_Br_comorbidity_druginducedliverinjury = value;
         }

      }

      [DataMember( Name = "BR_Comorbidity_Druginducedliverinjury_Code" , Order = 31 )]
      [GxSeudo()]
      public String gxTpr_Br_comorbidity_druginducedliverinjury_code
      {
         get {
            return sdt.gxTpr_Br_comorbidity_druginducedliverinjury_code ;
         }

         set {
            sdt.gxTpr_Br_comorbidity_druginducedliverinjury_code = value;
         }

      }

      public SdtBR_Comorbidity sdt
      {
         get {
            return (SdtBR_Comorbidity)Sdt ;
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
            sdt = new SdtBR_Comorbidity() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 32 )]
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
