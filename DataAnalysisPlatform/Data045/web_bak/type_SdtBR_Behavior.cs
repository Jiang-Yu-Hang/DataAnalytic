/*
               File: type_SdtBR_Behavior
        Description: 个人史
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:36:4.34
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
   [XmlRoot(ElementName = "BR_Behavior" )]
   [XmlType(TypeName =  "BR_Behavior" , Namespace = "DataAnalysisPlatform" )]
   [Serializable]
   public class SdtBR_Behavior : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtBR_Behavior( )
      {
      }

      public SdtBR_Behavior( IGxContext context )
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

      public void Load( long AV20BR_BehaviorID )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(long)AV20BR_BehaviorID});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"BR_BehaviorID", typeof(long)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "BR_Behavior");
         metadata.Set("BT", "BR_Behavior");
         metadata.Set("PK", "[ \"BR_BehaviorID\" ]");
         metadata.Set("PKAssigned", "[ \"BR_BehaviorID\" ]");
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
         state.Add("gxTpr_Br_behaviorid_Z");
         state.Add("gxTpr_Br_encounterid_Z");
         state.Add("gxTpr_Br_information_patientno_Z");
         state.Add("gxTpr_Br_behavior_smoking_Z");
         state.Add("gxTpr_Br_behavior_smoking_code_Z");
         state.Add("gxTpr_Br_behavior_smokingtime_Z");
         state.Add("gxTpr_Br_behavior_smokingamount_Z");
         state.Add("gxTpr_Br_behavior_rawsmokingamount_Z");
         state.Add("gxTpr_Br_behavior_rawsmokingamount_code_Z");
         state.Add("gxTpr_Br_behavior_achohol_Z");
         state.Add("gxTpr_Br_behavior_achohol_code_Z");
         state.Add("gxTpr_Br_behavior_achoholtime_Z");
         state.Add("gxTpr_Br_behavior_achoholamount_Z");
         state.Add("gxTpr_Br_behavior_rawachoholamount_Z");
         state.Add("gxTpr_Br_behavior_rawachoholamount_code_Z");
         state.Add("gxTpr_Br_behavior_familycahistory_Z");
         state.Add("gxTpr_Br_behavior_familycahistory_code_Z");
         state.Add("gxTpr_Br_behavior_familycancer_Z");
         state.Add("gxTpr_Br_behavior_menopause_Z");
         state.Add("gxTpr_Br_behavior_menopause_code_Z");
         state.Add("gxTpr_Br_behavior_menopauseage_Z");
         state.Add("gxTpr_Br_behavior_rawmenopauseage_Z");
         state.Add("gxTpr_Br_behavior_childnum_Z");
         state.Add("gxTpr_Br_information_patientno_N");
         state.Add("gxTpr_Br_behavior_smoking_N");
         state.Add("gxTpr_Br_behavior_smoking_code_N");
         state.Add("gxTpr_Br_behavior_smokingtime_N");
         state.Add("gxTpr_Br_behavior_smokingamount_N");
         state.Add("gxTpr_Br_behavior_rawsmokingamount_N");
         state.Add("gxTpr_Br_behavior_rawsmokingamount_code_N");
         state.Add("gxTpr_Br_behavior_achohol_N");
         state.Add("gxTpr_Br_behavior_achohol_code_N");
         state.Add("gxTpr_Br_behavior_achoholtime_N");
         state.Add("gxTpr_Br_behavior_achoholamount_N");
         state.Add("gxTpr_Br_behavior_rawachoholamount_N");
         state.Add("gxTpr_Br_behavior_rawachoholamount_code_N");
         state.Add("gxTpr_Br_behavior_familycahistory_N");
         state.Add("gxTpr_Br_behavior_familycahistory_code_N");
         state.Add("gxTpr_Br_behavior_familycancer_N");
         state.Add("gxTpr_Br_behavior_menopause_N");
         state.Add("gxTpr_Br_behavior_menopause_code_N");
         state.Add("gxTpr_Br_behavior_menopauseage_N");
         state.Add("gxTpr_Br_behavior_rawmenopauseage_N");
         state.Add("gxTpr_Br_behavior_childnum_N");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtBR_Behavior sdt ;
         sdt = (SdtBR_Behavior)(source);
         gxTv_SdtBR_Behavior_Br_behaviorid = sdt.gxTv_SdtBR_Behavior_Br_behaviorid ;
         gxTv_SdtBR_Behavior_Br_encounterid = sdt.gxTv_SdtBR_Behavior_Br_encounterid ;
         gxTv_SdtBR_Behavior_Br_information_patientno = sdt.gxTv_SdtBR_Behavior_Br_information_patientno ;
         gxTv_SdtBR_Behavior_Br_behavior_smoking = sdt.gxTv_SdtBR_Behavior_Br_behavior_smoking ;
         gxTv_SdtBR_Behavior_Br_behavior_smoking_code = sdt.gxTv_SdtBR_Behavior_Br_behavior_smoking_code ;
         gxTv_SdtBR_Behavior_Br_behavior_smokingtime = sdt.gxTv_SdtBR_Behavior_Br_behavior_smokingtime ;
         gxTv_SdtBR_Behavior_Br_behavior_smokingamount = sdt.gxTv_SdtBR_Behavior_Br_behavior_smokingamount ;
         gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount = sdt.gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount ;
         gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount_code = sdt.gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount_code ;
         gxTv_SdtBR_Behavior_Br_behavior_achohol = sdt.gxTv_SdtBR_Behavior_Br_behavior_achohol ;
         gxTv_SdtBR_Behavior_Br_behavior_achohol_code = sdt.gxTv_SdtBR_Behavior_Br_behavior_achohol_code ;
         gxTv_SdtBR_Behavior_Br_behavior_achoholtime = sdt.gxTv_SdtBR_Behavior_Br_behavior_achoholtime ;
         gxTv_SdtBR_Behavior_Br_behavior_achoholamount = sdt.gxTv_SdtBR_Behavior_Br_behavior_achoholamount ;
         gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount = sdt.gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount ;
         gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount_code = sdt.gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount_code ;
         gxTv_SdtBR_Behavior_Br_behavior_familycahistory = sdt.gxTv_SdtBR_Behavior_Br_behavior_familycahistory ;
         gxTv_SdtBR_Behavior_Br_behavior_familycahistory_code = sdt.gxTv_SdtBR_Behavior_Br_behavior_familycahistory_code ;
         gxTv_SdtBR_Behavior_Br_behavior_familycancer = sdt.gxTv_SdtBR_Behavior_Br_behavior_familycancer ;
         gxTv_SdtBR_Behavior_Br_behavior_menopause = sdt.gxTv_SdtBR_Behavior_Br_behavior_menopause ;
         gxTv_SdtBR_Behavior_Br_behavior_menopause_code = sdt.gxTv_SdtBR_Behavior_Br_behavior_menopause_code ;
         gxTv_SdtBR_Behavior_Br_behavior_menopauseage = sdt.gxTv_SdtBR_Behavior_Br_behavior_menopauseage ;
         gxTv_SdtBR_Behavior_Br_behavior_rawmenopauseage = sdt.gxTv_SdtBR_Behavior_Br_behavior_rawmenopauseage ;
         gxTv_SdtBR_Behavior_Br_behavior_childnum = sdt.gxTv_SdtBR_Behavior_Br_behavior_childnum ;
         gxTv_SdtBR_Behavior_Mode = sdt.gxTv_SdtBR_Behavior_Mode ;
         gxTv_SdtBR_Behavior_Initialized = sdt.gxTv_SdtBR_Behavior_Initialized ;
         gxTv_SdtBR_Behavior_Br_behaviorid_Z = sdt.gxTv_SdtBR_Behavior_Br_behaviorid_Z ;
         gxTv_SdtBR_Behavior_Br_encounterid_Z = sdt.gxTv_SdtBR_Behavior_Br_encounterid_Z ;
         gxTv_SdtBR_Behavior_Br_information_patientno_Z = sdt.gxTv_SdtBR_Behavior_Br_information_patientno_Z ;
         gxTv_SdtBR_Behavior_Br_behavior_smoking_Z = sdt.gxTv_SdtBR_Behavior_Br_behavior_smoking_Z ;
         gxTv_SdtBR_Behavior_Br_behavior_smoking_code_Z = sdt.gxTv_SdtBR_Behavior_Br_behavior_smoking_code_Z ;
         gxTv_SdtBR_Behavior_Br_behavior_smokingtime_Z = sdt.gxTv_SdtBR_Behavior_Br_behavior_smokingtime_Z ;
         gxTv_SdtBR_Behavior_Br_behavior_smokingamount_Z = sdt.gxTv_SdtBR_Behavior_Br_behavior_smokingamount_Z ;
         gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount_Z = sdt.gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount_Z ;
         gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount_code_Z = sdt.gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount_code_Z ;
         gxTv_SdtBR_Behavior_Br_behavior_achohol_Z = sdt.gxTv_SdtBR_Behavior_Br_behavior_achohol_Z ;
         gxTv_SdtBR_Behavior_Br_behavior_achohol_code_Z = sdt.gxTv_SdtBR_Behavior_Br_behavior_achohol_code_Z ;
         gxTv_SdtBR_Behavior_Br_behavior_achoholtime_Z = sdt.gxTv_SdtBR_Behavior_Br_behavior_achoholtime_Z ;
         gxTv_SdtBR_Behavior_Br_behavior_achoholamount_Z = sdt.gxTv_SdtBR_Behavior_Br_behavior_achoholamount_Z ;
         gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount_Z = sdt.gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount_Z ;
         gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount_code_Z = sdt.gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount_code_Z ;
         gxTv_SdtBR_Behavior_Br_behavior_familycahistory_Z = sdt.gxTv_SdtBR_Behavior_Br_behavior_familycahistory_Z ;
         gxTv_SdtBR_Behavior_Br_behavior_familycahistory_code_Z = sdt.gxTv_SdtBR_Behavior_Br_behavior_familycahistory_code_Z ;
         gxTv_SdtBR_Behavior_Br_behavior_familycancer_Z = sdt.gxTv_SdtBR_Behavior_Br_behavior_familycancer_Z ;
         gxTv_SdtBR_Behavior_Br_behavior_menopause_Z = sdt.gxTv_SdtBR_Behavior_Br_behavior_menopause_Z ;
         gxTv_SdtBR_Behavior_Br_behavior_menopause_code_Z = sdt.gxTv_SdtBR_Behavior_Br_behavior_menopause_code_Z ;
         gxTv_SdtBR_Behavior_Br_behavior_menopauseage_Z = sdt.gxTv_SdtBR_Behavior_Br_behavior_menopauseage_Z ;
         gxTv_SdtBR_Behavior_Br_behavior_rawmenopauseage_Z = sdt.gxTv_SdtBR_Behavior_Br_behavior_rawmenopauseage_Z ;
         gxTv_SdtBR_Behavior_Br_behavior_childnum_Z = sdt.gxTv_SdtBR_Behavior_Br_behavior_childnum_Z ;
         gxTv_SdtBR_Behavior_Br_information_patientno_N = sdt.gxTv_SdtBR_Behavior_Br_information_patientno_N ;
         gxTv_SdtBR_Behavior_Br_behavior_smoking_N = sdt.gxTv_SdtBR_Behavior_Br_behavior_smoking_N ;
         gxTv_SdtBR_Behavior_Br_behavior_smoking_code_N = sdt.gxTv_SdtBR_Behavior_Br_behavior_smoking_code_N ;
         gxTv_SdtBR_Behavior_Br_behavior_smokingtime_N = sdt.gxTv_SdtBR_Behavior_Br_behavior_smokingtime_N ;
         gxTv_SdtBR_Behavior_Br_behavior_smokingamount_N = sdt.gxTv_SdtBR_Behavior_Br_behavior_smokingamount_N ;
         gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount_N = sdt.gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount_N ;
         gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount_code_N = sdt.gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount_code_N ;
         gxTv_SdtBR_Behavior_Br_behavior_achohol_N = sdt.gxTv_SdtBR_Behavior_Br_behavior_achohol_N ;
         gxTv_SdtBR_Behavior_Br_behavior_achohol_code_N = sdt.gxTv_SdtBR_Behavior_Br_behavior_achohol_code_N ;
         gxTv_SdtBR_Behavior_Br_behavior_achoholtime_N = sdt.gxTv_SdtBR_Behavior_Br_behavior_achoholtime_N ;
         gxTv_SdtBR_Behavior_Br_behavior_achoholamount_N = sdt.gxTv_SdtBR_Behavior_Br_behavior_achoholamount_N ;
         gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount_N = sdt.gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount_N ;
         gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount_code_N = sdt.gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount_code_N ;
         gxTv_SdtBR_Behavior_Br_behavior_familycahistory_N = sdt.gxTv_SdtBR_Behavior_Br_behavior_familycahistory_N ;
         gxTv_SdtBR_Behavior_Br_behavior_familycahistory_code_N = sdt.gxTv_SdtBR_Behavior_Br_behavior_familycahistory_code_N ;
         gxTv_SdtBR_Behavior_Br_behavior_familycancer_N = sdt.gxTv_SdtBR_Behavior_Br_behavior_familycancer_N ;
         gxTv_SdtBR_Behavior_Br_behavior_menopause_N = sdt.gxTv_SdtBR_Behavior_Br_behavior_menopause_N ;
         gxTv_SdtBR_Behavior_Br_behavior_menopause_code_N = sdt.gxTv_SdtBR_Behavior_Br_behavior_menopause_code_N ;
         gxTv_SdtBR_Behavior_Br_behavior_menopauseage_N = sdt.gxTv_SdtBR_Behavior_Br_behavior_menopauseage_N ;
         gxTv_SdtBR_Behavior_Br_behavior_rawmenopauseage_N = sdt.gxTv_SdtBR_Behavior_Br_behavior_rawmenopauseage_N ;
         gxTv_SdtBR_Behavior_Br_behavior_childnum_N = sdt.gxTv_SdtBR_Behavior_Br_behavior_childnum_N ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("BR_BehaviorID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Behavior_Br_behaviorid), 18, 0)), false);
         AddObjectProperty("BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Behavior_Br_encounterid), 18, 0)), false);
         AddObjectProperty("BR_Information_PatientNo", gxTv_SdtBR_Behavior_Br_information_patientno, false);
         AddObjectProperty("BR_Information_PatientNo_N", gxTv_SdtBR_Behavior_Br_information_patientno_N, false);
         AddObjectProperty("BR_Behavior_Smoking", gxTv_SdtBR_Behavior_Br_behavior_smoking, false);
         AddObjectProperty("BR_Behavior_Smoking_N", gxTv_SdtBR_Behavior_Br_behavior_smoking_N, false);
         AddObjectProperty("BR_Behavior_Smoking_Code", gxTv_SdtBR_Behavior_Br_behavior_smoking_code, false);
         AddObjectProperty("BR_Behavior_Smoking_Code_N", gxTv_SdtBR_Behavior_Br_behavior_smoking_code_N, false);
         AddObjectProperty("BR_Behavior_SmokingTime", gxTv_SdtBR_Behavior_Br_behavior_smokingtime, false);
         AddObjectProperty("BR_Behavior_SmokingTime_N", gxTv_SdtBR_Behavior_Br_behavior_smokingtime_N, false);
         AddObjectProperty("BR_Behavior_SmokingAmount", gxTv_SdtBR_Behavior_Br_behavior_smokingamount, false);
         AddObjectProperty("BR_Behavior_SmokingAmount_N", gxTv_SdtBR_Behavior_Br_behavior_smokingamount_N, false);
         AddObjectProperty("BR_Behavior_RawSmokingAmount", gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount, false);
         AddObjectProperty("BR_Behavior_RawSmokingAmount_N", gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount_N, false);
         AddObjectProperty("BR_Behavior_RawSmokingAmount_Code", gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount_code, false);
         AddObjectProperty("BR_Behavior_RawSmokingAmount_Code_N", gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount_code_N, false);
         AddObjectProperty("BR_Behavior_Achohol", gxTv_SdtBR_Behavior_Br_behavior_achohol, false);
         AddObjectProperty("BR_Behavior_Achohol_N", gxTv_SdtBR_Behavior_Br_behavior_achohol_N, false);
         AddObjectProperty("BR_Behavior_Achohol_Code", gxTv_SdtBR_Behavior_Br_behavior_achohol_code, false);
         AddObjectProperty("BR_Behavior_Achohol_Code_N", gxTv_SdtBR_Behavior_Br_behavior_achohol_code_N, false);
         AddObjectProperty("BR_Behavior_AchoholTime", gxTv_SdtBR_Behavior_Br_behavior_achoholtime, false);
         AddObjectProperty("BR_Behavior_AchoholTime_N", gxTv_SdtBR_Behavior_Br_behavior_achoholtime_N, false);
         AddObjectProperty("BR_Behavior_AchoholAmount", gxTv_SdtBR_Behavior_Br_behavior_achoholamount, false);
         AddObjectProperty("BR_Behavior_AchoholAmount_N", gxTv_SdtBR_Behavior_Br_behavior_achoholamount_N, false);
         AddObjectProperty("BR_Behavior_RawAchoholAmount", gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount, false);
         AddObjectProperty("BR_Behavior_RawAchoholAmount_N", gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount_N, false);
         AddObjectProperty("BR_Behavior_RawAchoholAmount_Code", gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount_code, false);
         AddObjectProperty("BR_Behavior_RawAchoholAmount_Code_N", gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount_code_N, false);
         AddObjectProperty("BR_Behavior_FamilyCaHistory", gxTv_SdtBR_Behavior_Br_behavior_familycahistory, false);
         AddObjectProperty("BR_Behavior_FamilyCaHistory_N", gxTv_SdtBR_Behavior_Br_behavior_familycahistory_N, false);
         AddObjectProperty("BR_Behavior_FamilyCaHistory_Code", gxTv_SdtBR_Behavior_Br_behavior_familycahistory_code, false);
         AddObjectProperty("BR_Behavior_FamilyCaHistory_Code_N", gxTv_SdtBR_Behavior_Br_behavior_familycahistory_code_N, false);
         AddObjectProperty("BR_Behavior_FamilyCancer", gxTv_SdtBR_Behavior_Br_behavior_familycancer, false);
         AddObjectProperty("BR_Behavior_FamilyCancer_N", gxTv_SdtBR_Behavior_Br_behavior_familycancer_N, false);
         AddObjectProperty("BR_Behavior_Menopause", gxTv_SdtBR_Behavior_Br_behavior_menopause, false);
         AddObjectProperty("BR_Behavior_Menopause_N", gxTv_SdtBR_Behavior_Br_behavior_menopause_N, false);
         AddObjectProperty("BR_Behavior_Menopause_Code", gxTv_SdtBR_Behavior_Br_behavior_menopause_code, false);
         AddObjectProperty("BR_Behavior_Menopause_Code_N", gxTv_SdtBR_Behavior_Br_behavior_menopause_code_N, false);
         AddObjectProperty("BR_Behavior_MenopauseAge", gxTv_SdtBR_Behavior_Br_behavior_menopauseage, false);
         AddObjectProperty("BR_Behavior_MenopauseAge_N", gxTv_SdtBR_Behavior_Br_behavior_menopauseage_N, false);
         AddObjectProperty("BR_Behavior_RawMenopauseAge", gxTv_SdtBR_Behavior_Br_behavior_rawmenopauseage, false);
         AddObjectProperty("BR_Behavior_RawMenopauseAge_N", gxTv_SdtBR_Behavior_Br_behavior_rawmenopauseage_N, false);
         AddObjectProperty("BR_Behavior_ChildNum", gxTv_SdtBR_Behavior_Br_behavior_childnum, false);
         AddObjectProperty("BR_Behavior_ChildNum_N", gxTv_SdtBR_Behavior_Br_behavior_childnum_N, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtBR_Behavior_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtBR_Behavior_Initialized, false);
            AddObjectProperty("BR_BehaviorID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Behavior_Br_behaviorid_Z), 18, 0)), false);
            AddObjectProperty("BR_EncounterID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Behavior_Br_encounterid_Z), 18, 0)), false);
            AddObjectProperty("BR_Information_PatientNo_Z", gxTv_SdtBR_Behavior_Br_information_patientno_Z, false);
            AddObjectProperty("BR_Behavior_Smoking_Z", gxTv_SdtBR_Behavior_Br_behavior_smoking_Z, false);
            AddObjectProperty("BR_Behavior_Smoking_Code_Z", gxTv_SdtBR_Behavior_Br_behavior_smoking_code_Z, false);
            AddObjectProperty("BR_Behavior_SmokingTime_Z", gxTv_SdtBR_Behavior_Br_behavior_smokingtime_Z, false);
            AddObjectProperty("BR_Behavior_SmokingAmount_Z", gxTv_SdtBR_Behavior_Br_behavior_smokingamount_Z, false);
            AddObjectProperty("BR_Behavior_RawSmokingAmount_Z", gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount_Z, false);
            AddObjectProperty("BR_Behavior_RawSmokingAmount_Code_Z", gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount_code_Z, false);
            AddObjectProperty("BR_Behavior_Achohol_Z", gxTv_SdtBR_Behavior_Br_behavior_achohol_Z, false);
            AddObjectProperty("BR_Behavior_Achohol_Code_Z", gxTv_SdtBR_Behavior_Br_behavior_achohol_code_Z, false);
            AddObjectProperty("BR_Behavior_AchoholTime_Z", gxTv_SdtBR_Behavior_Br_behavior_achoholtime_Z, false);
            AddObjectProperty("BR_Behavior_AchoholAmount_Z", gxTv_SdtBR_Behavior_Br_behavior_achoholamount_Z, false);
            AddObjectProperty("BR_Behavior_RawAchoholAmount_Z", gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount_Z, false);
            AddObjectProperty("BR_Behavior_RawAchoholAmount_Code_Z", gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount_code_Z, false);
            AddObjectProperty("BR_Behavior_FamilyCaHistory_Z", gxTv_SdtBR_Behavior_Br_behavior_familycahistory_Z, false);
            AddObjectProperty("BR_Behavior_FamilyCaHistory_Code_Z", gxTv_SdtBR_Behavior_Br_behavior_familycahistory_code_Z, false);
            AddObjectProperty("BR_Behavior_FamilyCancer_Z", gxTv_SdtBR_Behavior_Br_behavior_familycancer_Z, false);
            AddObjectProperty("BR_Behavior_Menopause_Z", gxTv_SdtBR_Behavior_Br_behavior_menopause_Z, false);
            AddObjectProperty("BR_Behavior_Menopause_Code_Z", gxTv_SdtBR_Behavior_Br_behavior_menopause_code_Z, false);
            AddObjectProperty("BR_Behavior_MenopauseAge_Z", gxTv_SdtBR_Behavior_Br_behavior_menopauseage_Z, false);
            AddObjectProperty("BR_Behavior_RawMenopauseAge_Z", gxTv_SdtBR_Behavior_Br_behavior_rawmenopauseage_Z, false);
            AddObjectProperty("BR_Behavior_ChildNum_Z", gxTv_SdtBR_Behavior_Br_behavior_childnum_Z, false);
            AddObjectProperty("BR_Information_PatientNo_N", gxTv_SdtBR_Behavior_Br_information_patientno_N, false);
            AddObjectProperty("BR_Behavior_Smoking_N", gxTv_SdtBR_Behavior_Br_behavior_smoking_N, false);
            AddObjectProperty("BR_Behavior_Smoking_Code_N", gxTv_SdtBR_Behavior_Br_behavior_smoking_code_N, false);
            AddObjectProperty("BR_Behavior_SmokingTime_N", gxTv_SdtBR_Behavior_Br_behavior_smokingtime_N, false);
            AddObjectProperty("BR_Behavior_SmokingAmount_N", gxTv_SdtBR_Behavior_Br_behavior_smokingamount_N, false);
            AddObjectProperty("BR_Behavior_RawSmokingAmount_N", gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount_N, false);
            AddObjectProperty("BR_Behavior_RawSmokingAmount_Code_N", gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount_code_N, false);
            AddObjectProperty("BR_Behavior_Achohol_N", gxTv_SdtBR_Behavior_Br_behavior_achohol_N, false);
            AddObjectProperty("BR_Behavior_Achohol_Code_N", gxTv_SdtBR_Behavior_Br_behavior_achohol_code_N, false);
            AddObjectProperty("BR_Behavior_AchoholTime_N", gxTv_SdtBR_Behavior_Br_behavior_achoholtime_N, false);
            AddObjectProperty("BR_Behavior_AchoholAmount_N", gxTv_SdtBR_Behavior_Br_behavior_achoholamount_N, false);
            AddObjectProperty("BR_Behavior_RawAchoholAmount_N", gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount_N, false);
            AddObjectProperty("BR_Behavior_RawAchoholAmount_Code_N", gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount_code_N, false);
            AddObjectProperty("BR_Behavior_FamilyCaHistory_N", gxTv_SdtBR_Behavior_Br_behavior_familycahistory_N, false);
            AddObjectProperty("BR_Behavior_FamilyCaHistory_Code_N", gxTv_SdtBR_Behavior_Br_behavior_familycahistory_code_N, false);
            AddObjectProperty("BR_Behavior_FamilyCancer_N", gxTv_SdtBR_Behavior_Br_behavior_familycancer_N, false);
            AddObjectProperty("BR_Behavior_Menopause_N", gxTv_SdtBR_Behavior_Br_behavior_menopause_N, false);
            AddObjectProperty("BR_Behavior_Menopause_Code_N", gxTv_SdtBR_Behavior_Br_behavior_menopause_code_N, false);
            AddObjectProperty("BR_Behavior_MenopauseAge_N", gxTv_SdtBR_Behavior_Br_behavior_menopauseage_N, false);
            AddObjectProperty("BR_Behavior_RawMenopauseAge_N", gxTv_SdtBR_Behavior_Br_behavior_rawmenopauseage_N, false);
            AddObjectProperty("BR_Behavior_ChildNum_N", gxTv_SdtBR_Behavior_Br_behavior_childnum_N, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtBR_Behavior sdt )
      {
         if ( sdt.IsDirty("BR_BehaviorID") )
         {
            gxTv_SdtBR_Behavior_Br_behaviorid = sdt.gxTv_SdtBR_Behavior_Br_behaviorid ;
         }
         if ( sdt.IsDirty("BR_EncounterID") )
         {
            gxTv_SdtBR_Behavior_Br_encounterid = sdt.gxTv_SdtBR_Behavior_Br_encounterid ;
         }
         if ( sdt.IsDirty("BR_Information_PatientNo") )
         {
            gxTv_SdtBR_Behavior_Br_information_patientno = sdt.gxTv_SdtBR_Behavior_Br_information_patientno ;
         }
         if ( sdt.IsDirty("BR_Behavior_Smoking") )
         {
            gxTv_SdtBR_Behavior_Br_behavior_smoking = sdt.gxTv_SdtBR_Behavior_Br_behavior_smoking ;
         }
         if ( sdt.IsDirty("BR_Behavior_Smoking_Code") )
         {
            gxTv_SdtBR_Behavior_Br_behavior_smoking_code = sdt.gxTv_SdtBR_Behavior_Br_behavior_smoking_code ;
         }
         if ( sdt.IsDirty("BR_Behavior_SmokingTime") )
         {
            gxTv_SdtBR_Behavior_Br_behavior_smokingtime = sdt.gxTv_SdtBR_Behavior_Br_behavior_smokingtime ;
         }
         if ( sdt.IsDirty("BR_Behavior_SmokingAmount") )
         {
            gxTv_SdtBR_Behavior_Br_behavior_smokingamount = sdt.gxTv_SdtBR_Behavior_Br_behavior_smokingamount ;
         }
         if ( sdt.IsDirty("BR_Behavior_RawSmokingAmount") )
         {
            gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount = sdt.gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount ;
         }
         if ( sdt.IsDirty("BR_Behavior_RawSmokingAmount_Code") )
         {
            gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount_code = sdt.gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount_code ;
         }
         if ( sdt.IsDirty("BR_Behavior_Achohol") )
         {
            gxTv_SdtBR_Behavior_Br_behavior_achohol = sdt.gxTv_SdtBR_Behavior_Br_behavior_achohol ;
         }
         if ( sdt.IsDirty("BR_Behavior_Achohol_Code") )
         {
            gxTv_SdtBR_Behavior_Br_behavior_achohol_code = sdt.gxTv_SdtBR_Behavior_Br_behavior_achohol_code ;
         }
         if ( sdt.IsDirty("BR_Behavior_AchoholTime") )
         {
            gxTv_SdtBR_Behavior_Br_behavior_achoholtime = sdt.gxTv_SdtBR_Behavior_Br_behavior_achoholtime ;
         }
         if ( sdt.IsDirty("BR_Behavior_AchoholAmount") )
         {
            gxTv_SdtBR_Behavior_Br_behavior_achoholamount = sdt.gxTv_SdtBR_Behavior_Br_behavior_achoholamount ;
         }
         if ( sdt.IsDirty("BR_Behavior_RawAchoholAmount") )
         {
            gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount = sdt.gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount ;
         }
         if ( sdt.IsDirty("BR_Behavior_RawAchoholAmount_Code") )
         {
            gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount_code = sdt.gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount_code ;
         }
         if ( sdt.IsDirty("BR_Behavior_FamilyCaHistory") )
         {
            gxTv_SdtBR_Behavior_Br_behavior_familycahistory = sdt.gxTv_SdtBR_Behavior_Br_behavior_familycahistory ;
         }
         if ( sdt.IsDirty("BR_Behavior_FamilyCaHistory_Code") )
         {
            gxTv_SdtBR_Behavior_Br_behavior_familycahistory_code = sdt.gxTv_SdtBR_Behavior_Br_behavior_familycahistory_code ;
         }
         if ( sdt.IsDirty("BR_Behavior_FamilyCancer") )
         {
            gxTv_SdtBR_Behavior_Br_behavior_familycancer = sdt.gxTv_SdtBR_Behavior_Br_behavior_familycancer ;
         }
         if ( sdt.IsDirty("BR_Behavior_Menopause") )
         {
            gxTv_SdtBR_Behavior_Br_behavior_menopause = sdt.gxTv_SdtBR_Behavior_Br_behavior_menopause ;
         }
         if ( sdt.IsDirty("BR_Behavior_Menopause_Code") )
         {
            gxTv_SdtBR_Behavior_Br_behavior_menopause_code = sdt.gxTv_SdtBR_Behavior_Br_behavior_menopause_code ;
         }
         if ( sdt.IsDirty("BR_Behavior_MenopauseAge") )
         {
            gxTv_SdtBR_Behavior_Br_behavior_menopauseage = sdt.gxTv_SdtBR_Behavior_Br_behavior_menopauseage ;
         }
         if ( sdt.IsDirty("BR_Behavior_RawMenopauseAge") )
         {
            gxTv_SdtBR_Behavior_Br_behavior_rawmenopauseage = sdt.gxTv_SdtBR_Behavior_Br_behavior_rawmenopauseage ;
         }
         if ( sdt.IsDirty("BR_Behavior_ChildNum") )
         {
            gxTv_SdtBR_Behavior_Br_behavior_childnum = sdt.gxTv_SdtBR_Behavior_Br_behavior_childnum ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "BR_BehaviorID" )]
      [  XmlElement( ElementName = "BR_BehaviorID"   )]
      public long gxTpr_Br_behaviorid
      {
         get {
            return gxTv_SdtBR_Behavior_Br_behaviorid ;
         }

         set {
            if ( gxTv_SdtBR_Behavior_Br_behaviorid != value )
            {
               gxTv_SdtBR_Behavior_Mode = "INS";
               this.gxTv_SdtBR_Behavior_Br_behaviorid_Z_SetNull( );
               this.gxTv_SdtBR_Behavior_Br_encounterid_Z_SetNull( );
               this.gxTv_SdtBR_Behavior_Br_information_patientno_Z_SetNull( );
               this.gxTv_SdtBR_Behavior_Br_behavior_smoking_Z_SetNull( );
               this.gxTv_SdtBR_Behavior_Br_behavior_smoking_code_Z_SetNull( );
               this.gxTv_SdtBR_Behavior_Br_behavior_smokingtime_Z_SetNull( );
               this.gxTv_SdtBR_Behavior_Br_behavior_smokingamount_Z_SetNull( );
               this.gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount_Z_SetNull( );
               this.gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount_code_Z_SetNull( );
               this.gxTv_SdtBR_Behavior_Br_behavior_achohol_Z_SetNull( );
               this.gxTv_SdtBR_Behavior_Br_behavior_achohol_code_Z_SetNull( );
               this.gxTv_SdtBR_Behavior_Br_behavior_achoholtime_Z_SetNull( );
               this.gxTv_SdtBR_Behavior_Br_behavior_achoholamount_Z_SetNull( );
               this.gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount_Z_SetNull( );
               this.gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount_code_Z_SetNull( );
               this.gxTv_SdtBR_Behavior_Br_behavior_familycahistory_Z_SetNull( );
               this.gxTv_SdtBR_Behavior_Br_behavior_familycahistory_code_Z_SetNull( );
               this.gxTv_SdtBR_Behavior_Br_behavior_familycancer_Z_SetNull( );
               this.gxTv_SdtBR_Behavior_Br_behavior_menopause_Z_SetNull( );
               this.gxTv_SdtBR_Behavior_Br_behavior_menopause_code_Z_SetNull( );
               this.gxTv_SdtBR_Behavior_Br_behavior_menopauseage_Z_SetNull( );
               this.gxTv_SdtBR_Behavior_Br_behavior_rawmenopauseage_Z_SetNull( );
               this.gxTv_SdtBR_Behavior_Br_behavior_childnum_Z_SetNull( );
            }
            gxTv_SdtBR_Behavior_Br_behaviorid = value;
            SetDirty("Br_behaviorid");
         }

      }

      [  SoapElement( ElementName = "BR_EncounterID" )]
      [  XmlElement( ElementName = "BR_EncounterID"   )]
      public long gxTpr_Br_encounterid
      {
         get {
            return gxTv_SdtBR_Behavior_Br_encounterid ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_encounterid = value;
            SetDirty("Br_encounterid");
         }

      }

      [  SoapElement( ElementName = "BR_Information_PatientNo" )]
      [  XmlElement( ElementName = "BR_Information_PatientNo"   )]
      public String gxTpr_Br_information_patientno
      {
         get {
            return gxTv_SdtBR_Behavior_Br_information_patientno ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_information_patientno_N = 0;
            gxTv_SdtBR_Behavior_Br_information_patientno = value;
            SetDirty("Br_information_patientno");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_information_patientno_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_information_patientno_N = 1;
         gxTv_SdtBR_Behavior_Br_information_patientno = "";
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_information_patientno_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Behavior_Smoking" )]
      [  XmlElement( ElementName = "BR_Behavior_Smoking"   )]
      public String gxTpr_Br_behavior_smoking
      {
         get {
            return gxTv_SdtBR_Behavior_Br_behavior_smoking ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_behavior_smoking_N = 0;
            gxTv_SdtBR_Behavior_Br_behavior_smoking = value;
            SetDirty("Br_behavior_smoking");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_behavior_smoking_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_behavior_smoking_N = 1;
         gxTv_SdtBR_Behavior_Br_behavior_smoking = "";
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_behavior_smoking_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Behavior_Smoking_Code" )]
      [  XmlElement( ElementName = "BR_Behavior_Smoking_Code"   )]
      public String gxTpr_Br_behavior_smoking_code
      {
         get {
            return gxTv_SdtBR_Behavior_Br_behavior_smoking_code ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_behavior_smoking_code_N = 0;
            gxTv_SdtBR_Behavior_Br_behavior_smoking_code = value;
            SetDirty("Br_behavior_smoking_code");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_behavior_smoking_code_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_behavior_smoking_code_N = 1;
         gxTv_SdtBR_Behavior_Br_behavior_smoking_code = "";
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_behavior_smoking_code_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Behavior_SmokingTime" )]
      [  XmlElement( ElementName = "BR_Behavior_SmokingTime"   )]
      public String gxTpr_Br_behavior_smokingtime
      {
         get {
            return gxTv_SdtBR_Behavior_Br_behavior_smokingtime ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_behavior_smokingtime_N = 0;
            gxTv_SdtBR_Behavior_Br_behavior_smokingtime = value;
            SetDirty("Br_behavior_smokingtime");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_behavior_smokingtime_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_behavior_smokingtime_N = 1;
         gxTv_SdtBR_Behavior_Br_behavior_smokingtime = "";
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_behavior_smokingtime_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Behavior_SmokingAmount" )]
      [  XmlElement( ElementName = "BR_Behavior_SmokingAmount"   )]
      public String gxTpr_Br_behavior_smokingamount
      {
         get {
            return gxTv_SdtBR_Behavior_Br_behavior_smokingamount ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_behavior_smokingamount_N = 0;
            gxTv_SdtBR_Behavior_Br_behavior_smokingamount = value;
            SetDirty("Br_behavior_smokingamount");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_behavior_smokingamount_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_behavior_smokingamount_N = 1;
         gxTv_SdtBR_Behavior_Br_behavior_smokingamount = "";
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_behavior_smokingamount_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Behavior_RawSmokingAmount" )]
      [  XmlElement( ElementName = "BR_Behavior_RawSmokingAmount"   )]
      public String gxTpr_Br_behavior_rawsmokingamount
      {
         get {
            return gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount_N = 0;
            gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount = value;
            SetDirty("Br_behavior_rawsmokingamount");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount_N = 1;
         gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount = "";
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Behavior_RawSmokingAmount_Code" )]
      [  XmlElement( ElementName = "BR_Behavior_RawSmokingAmount_Code"   )]
      public String gxTpr_Br_behavior_rawsmokingamount_code
      {
         get {
            return gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount_code ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount_code_N = 0;
            gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount_code = value;
            SetDirty("Br_behavior_rawsmokingamount_code");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount_code_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount_code_N = 1;
         gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount_code = "";
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount_code_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Behavior_Achohol" )]
      [  XmlElement( ElementName = "BR_Behavior_Achohol"   )]
      public String gxTpr_Br_behavior_achohol
      {
         get {
            return gxTv_SdtBR_Behavior_Br_behavior_achohol ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_behavior_achohol_N = 0;
            gxTv_SdtBR_Behavior_Br_behavior_achohol = value;
            SetDirty("Br_behavior_achohol");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_behavior_achohol_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_behavior_achohol_N = 1;
         gxTv_SdtBR_Behavior_Br_behavior_achohol = "";
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_behavior_achohol_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Behavior_Achohol_Code" )]
      [  XmlElement( ElementName = "BR_Behavior_Achohol_Code"   )]
      public String gxTpr_Br_behavior_achohol_code
      {
         get {
            return gxTv_SdtBR_Behavior_Br_behavior_achohol_code ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_behavior_achohol_code_N = 0;
            gxTv_SdtBR_Behavior_Br_behavior_achohol_code = value;
            SetDirty("Br_behavior_achohol_code");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_behavior_achohol_code_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_behavior_achohol_code_N = 1;
         gxTv_SdtBR_Behavior_Br_behavior_achohol_code = "";
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_behavior_achohol_code_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Behavior_AchoholTime" )]
      [  XmlElement( ElementName = "BR_Behavior_AchoholTime"   )]
      public String gxTpr_Br_behavior_achoholtime
      {
         get {
            return gxTv_SdtBR_Behavior_Br_behavior_achoholtime ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_behavior_achoholtime_N = 0;
            gxTv_SdtBR_Behavior_Br_behavior_achoholtime = value;
            SetDirty("Br_behavior_achoholtime");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_behavior_achoholtime_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_behavior_achoholtime_N = 1;
         gxTv_SdtBR_Behavior_Br_behavior_achoholtime = "";
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_behavior_achoholtime_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Behavior_AchoholAmount" )]
      [  XmlElement( ElementName = "BR_Behavior_AchoholAmount"   )]
      public String gxTpr_Br_behavior_achoholamount
      {
         get {
            return gxTv_SdtBR_Behavior_Br_behavior_achoholamount ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_behavior_achoholamount_N = 0;
            gxTv_SdtBR_Behavior_Br_behavior_achoholamount = value;
            SetDirty("Br_behavior_achoholamount");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_behavior_achoholamount_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_behavior_achoholamount_N = 1;
         gxTv_SdtBR_Behavior_Br_behavior_achoholamount = "";
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_behavior_achoholamount_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Behavior_RawAchoholAmount" )]
      [  XmlElement( ElementName = "BR_Behavior_RawAchoholAmount"   )]
      public String gxTpr_Br_behavior_rawachoholamount
      {
         get {
            return gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount_N = 0;
            gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount = value;
            SetDirty("Br_behavior_rawachoholamount");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount_N = 1;
         gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount = "";
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Behavior_RawAchoholAmount_Code" )]
      [  XmlElement( ElementName = "BR_Behavior_RawAchoholAmount_Code"   )]
      public String gxTpr_Br_behavior_rawachoholamount_code
      {
         get {
            return gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount_code ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount_code_N = 0;
            gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount_code = value;
            SetDirty("Br_behavior_rawachoholamount_code");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount_code_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount_code_N = 1;
         gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount_code = "";
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount_code_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Behavior_FamilyCaHistory" )]
      [  XmlElement( ElementName = "BR_Behavior_FamilyCaHistory"   )]
      public String gxTpr_Br_behavior_familycahistory
      {
         get {
            return gxTv_SdtBR_Behavior_Br_behavior_familycahistory ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_behavior_familycahistory_N = 0;
            gxTv_SdtBR_Behavior_Br_behavior_familycahistory = value;
            SetDirty("Br_behavior_familycahistory");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_behavior_familycahistory_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_behavior_familycahistory_N = 1;
         gxTv_SdtBR_Behavior_Br_behavior_familycahistory = "";
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_behavior_familycahistory_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Behavior_FamilyCaHistory_Code" )]
      [  XmlElement( ElementName = "BR_Behavior_FamilyCaHistory_Code"   )]
      public String gxTpr_Br_behavior_familycahistory_code
      {
         get {
            return gxTv_SdtBR_Behavior_Br_behavior_familycahistory_code ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_behavior_familycahistory_code_N = 0;
            gxTv_SdtBR_Behavior_Br_behavior_familycahistory_code = value;
            SetDirty("Br_behavior_familycahistory_code");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_behavior_familycahistory_code_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_behavior_familycahistory_code_N = 1;
         gxTv_SdtBR_Behavior_Br_behavior_familycahistory_code = "";
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_behavior_familycahistory_code_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Behavior_FamilyCancer" )]
      [  XmlElement( ElementName = "BR_Behavior_FamilyCancer"   )]
      public String gxTpr_Br_behavior_familycancer
      {
         get {
            return gxTv_SdtBR_Behavior_Br_behavior_familycancer ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_behavior_familycancer_N = 0;
            gxTv_SdtBR_Behavior_Br_behavior_familycancer = value;
            SetDirty("Br_behavior_familycancer");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_behavior_familycancer_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_behavior_familycancer_N = 1;
         gxTv_SdtBR_Behavior_Br_behavior_familycancer = "";
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_behavior_familycancer_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Behavior_Menopause" )]
      [  XmlElement( ElementName = "BR_Behavior_Menopause"   )]
      public String gxTpr_Br_behavior_menopause
      {
         get {
            return gxTv_SdtBR_Behavior_Br_behavior_menopause ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_behavior_menopause_N = 0;
            gxTv_SdtBR_Behavior_Br_behavior_menopause = value;
            SetDirty("Br_behavior_menopause");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_behavior_menopause_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_behavior_menopause_N = 1;
         gxTv_SdtBR_Behavior_Br_behavior_menopause = "";
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_behavior_menopause_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Behavior_Menopause_Code" )]
      [  XmlElement( ElementName = "BR_Behavior_Menopause_Code"   )]
      public String gxTpr_Br_behavior_menopause_code
      {
         get {
            return gxTv_SdtBR_Behavior_Br_behavior_menopause_code ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_behavior_menopause_code_N = 0;
            gxTv_SdtBR_Behavior_Br_behavior_menopause_code = value;
            SetDirty("Br_behavior_menopause_code");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_behavior_menopause_code_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_behavior_menopause_code_N = 1;
         gxTv_SdtBR_Behavior_Br_behavior_menopause_code = "";
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_behavior_menopause_code_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Behavior_MenopauseAge" )]
      [  XmlElement( ElementName = "BR_Behavior_MenopauseAge"   )]
      public short gxTpr_Br_behavior_menopauseage
      {
         get {
            return gxTv_SdtBR_Behavior_Br_behavior_menopauseage ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_behavior_menopauseage_N = 0;
            gxTv_SdtBR_Behavior_Br_behavior_menopauseage = value;
            SetDirty("Br_behavior_menopauseage");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_behavior_menopauseage_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_behavior_menopauseage_N = 1;
         gxTv_SdtBR_Behavior_Br_behavior_menopauseage = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_behavior_menopauseage_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Behavior_RawMenopauseAge" )]
      [  XmlElement( ElementName = "BR_Behavior_RawMenopauseAge"   )]
      public String gxTpr_Br_behavior_rawmenopauseage
      {
         get {
            return gxTv_SdtBR_Behavior_Br_behavior_rawmenopauseage ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_behavior_rawmenopauseage_N = 0;
            gxTv_SdtBR_Behavior_Br_behavior_rawmenopauseage = value;
            SetDirty("Br_behavior_rawmenopauseage");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_behavior_rawmenopauseage_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_behavior_rawmenopauseage_N = 1;
         gxTv_SdtBR_Behavior_Br_behavior_rawmenopauseage = "";
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_behavior_rawmenopauseage_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Behavior_ChildNum" )]
      [  XmlElement( ElementName = "BR_Behavior_ChildNum"   )]
      public String gxTpr_Br_behavior_childnum
      {
         get {
            return gxTv_SdtBR_Behavior_Br_behavior_childnum ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_behavior_childnum_N = 0;
            gxTv_SdtBR_Behavior_Br_behavior_childnum = value;
            SetDirty("Br_behavior_childnum");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_behavior_childnum_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_behavior_childnum_N = 1;
         gxTv_SdtBR_Behavior_Br_behavior_childnum = "";
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_behavior_childnum_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtBR_Behavior_Mode ;
         }

         set {
            gxTv_SdtBR_Behavior_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtBR_Behavior_Mode_SetNull( )
      {
         gxTv_SdtBR_Behavior_Mode = "";
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtBR_Behavior_Initialized ;
         }

         set {
            gxTv_SdtBR_Behavior_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtBR_Behavior_Initialized_SetNull( )
      {
         gxTv_SdtBR_Behavior_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_BehaviorID_Z" )]
      [  XmlElement( ElementName = "BR_BehaviorID_Z"   )]
      public long gxTpr_Br_behaviorid_Z
      {
         get {
            return gxTv_SdtBR_Behavior_Br_behaviorid_Z ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_behaviorid_Z = value;
            SetDirty("Br_behaviorid_Z");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_behaviorid_Z_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_behaviorid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_behaviorid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_EncounterID_Z" )]
      [  XmlElement( ElementName = "BR_EncounterID_Z"   )]
      public long gxTpr_Br_encounterid_Z
      {
         get {
            return gxTv_SdtBR_Behavior_Br_encounterid_Z ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_encounterid_Z = value;
            SetDirty("Br_encounterid_Z");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_encounterid_Z_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_encounterid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_encounterid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Information_PatientNo_Z" )]
      [  XmlElement( ElementName = "BR_Information_PatientNo_Z"   )]
      public String gxTpr_Br_information_patientno_Z
      {
         get {
            return gxTv_SdtBR_Behavior_Br_information_patientno_Z ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_information_patientno_Z = value;
            SetDirty("Br_information_patientno_Z");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_information_patientno_Z_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_information_patientno_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_information_patientno_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Behavior_Smoking_Z" )]
      [  XmlElement( ElementName = "BR_Behavior_Smoking_Z"   )]
      public String gxTpr_Br_behavior_smoking_Z
      {
         get {
            return gxTv_SdtBR_Behavior_Br_behavior_smoking_Z ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_behavior_smoking_Z = value;
            SetDirty("Br_behavior_smoking_Z");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_behavior_smoking_Z_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_behavior_smoking_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_behavior_smoking_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Behavior_Smoking_Code_Z" )]
      [  XmlElement( ElementName = "BR_Behavior_Smoking_Code_Z"   )]
      public String gxTpr_Br_behavior_smoking_code_Z
      {
         get {
            return gxTv_SdtBR_Behavior_Br_behavior_smoking_code_Z ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_behavior_smoking_code_Z = value;
            SetDirty("Br_behavior_smoking_code_Z");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_behavior_smoking_code_Z_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_behavior_smoking_code_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_behavior_smoking_code_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Behavior_SmokingTime_Z" )]
      [  XmlElement( ElementName = "BR_Behavior_SmokingTime_Z"   )]
      public String gxTpr_Br_behavior_smokingtime_Z
      {
         get {
            return gxTv_SdtBR_Behavior_Br_behavior_smokingtime_Z ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_behavior_smokingtime_Z = value;
            SetDirty("Br_behavior_smokingtime_Z");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_behavior_smokingtime_Z_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_behavior_smokingtime_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_behavior_smokingtime_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Behavior_SmokingAmount_Z" )]
      [  XmlElement( ElementName = "BR_Behavior_SmokingAmount_Z"   )]
      public String gxTpr_Br_behavior_smokingamount_Z
      {
         get {
            return gxTv_SdtBR_Behavior_Br_behavior_smokingamount_Z ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_behavior_smokingamount_Z = value;
            SetDirty("Br_behavior_smokingamount_Z");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_behavior_smokingamount_Z_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_behavior_smokingamount_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_behavior_smokingamount_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Behavior_RawSmokingAmount_Z" )]
      [  XmlElement( ElementName = "BR_Behavior_RawSmokingAmount_Z"   )]
      public String gxTpr_Br_behavior_rawsmokingamount_Z
      {
         get {
            return gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount_Z ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount_Z = value;
            SetDirty("Br_behavior_rawsmokingamount_Z");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount_Z_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Behavior_RawSmokingAmount_Code_Z" )]
      [  XmlElement( ElementName = "BR_Behavior_RawSmokingAmount_Code_Z"   )]
      public String gxTpr_Br_behavior_rawsmokingamount_code_Z
      {
         get {
            return gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount_code_Z ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount_code_Z = value;
            SetDirty("Br_behavior_rawsmokingamount_code_Z");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount_code_Z_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount_code_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount_code_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Behavior_Achohol_Z" )]
      [  XmlElement( ElementName = "BR_Behavior_Achohol_Z"   )]
      public String gxTpr_Br_behavior_achohol_Z
      {
         get {
            return gxTv_SdtBR_Behavior_Br_behavior_achohol_Z ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_behavior_achohol_Z = value;
            SetDirty("Br_behavior_achohol_Z");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_behavior_achohol_Z_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_behavior_achohol_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_behavior_achohol_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Behavior_Achohol_Code_Z" )]
      [  XmlElement( ElementName = "BR_Behavior_Achohol_Code_Z"   )]
      public String gxTpr_Br_behavior_achohol_code_Z
      {
         get {
            return gxTv_SdtBR_Behavior_Br_behavior_achohol_code_Z ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_behavior_achohol_code_Z = value;
            SetDirty("Br_behavior_achohol_code_Z");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_behavior_achohol_code_Z_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_behavior_achohol_code_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_behavior_achohol_code_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Behavior_AchoholTime_Z" )]
      [  XmlElement( ElementName = "BR_Behavior_AchoholTime_Z"   )]
      public String gxTpr_Br_behavior_achoholtime_Z
      {
         get {
            return gxTv_SdtBR_Behavior_Br_behavior_achoholtime_Z ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_behavior_achoholtime_Z = value;
            SetDirty("Br_behavior_achoholtime_Z");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_behavior_achoholtime_Z_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_behavior_achoholtime_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_behavior_achoholtime_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Behavior_AchoholAmount_Z" )]
      [  XmlElement( ElementName = "BR_Behavior_AchoholAmount_Z"   )]
      public String gxTpr_Br_behavior_achoholamount_Z
      {
         get {
            return gxTv_SdtBR_Behavior_Br_behavior_achoholamount_Z ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_behavior_achoholamount_Z = value;
            SetDirty("Br_behavior_achoholamount_Z");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_behavior_achoholamount_Z_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_behavior_achoholamount_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_behavior_achoholamount_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Behavior_RawAchoholAmount_Z" )]
      [  XmlElement( ElementName = "BR_Behavior_RawAchoholAmount_Z"   )]
      public String gxTpr_Br_behavior_rawachoholamount_Z
      {
         get {
            return gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount_Z ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount_Z = value;
            SetDirty("Br_behavior_rawachoholamount_Z");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount_Z_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Behavior_RawAchoholAmount_Code_Z" )]
      [  XmlElement( ElementName = "BR_Behavior_RawAchoholAmount_Code_Z"   )]
      public String gxTpr_Br_behavior_rawachoholamount_code_Z
      {
         get {
            return gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount_code_Z ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount_code_Z = value;
            SetDirty("Br_behavior_rawachoholamount_code_Z");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount_code_Z_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount_code_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount_code_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Behavior_FamilyCaHistory_Z" )]
      [  XmlElement( ElementName = "BR_Behavior_FamilyCaHistory_Z"   )]
      public String gxTpr_Br_behavior_familycahistory_Z
      {
         get {
            return gxTv_SdtBR_Behavior_Br_behavior_familycahistory_Z ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_behavior_familycahistory_Z = value;
            SetDirty("Br_behavior_familycahistory_Z");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_behavior_familycahistory_Z_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_behavior_familycahistory_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_behavior_familycahistory_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Behavior_FamilyCaHistory_Code_Z" )]
      [  XmlElement( ElementName = "BR_Behavior_FamilyCaHistory_Code_Z"   )]
      public String gxTpr_Br_behavior_familycahistory_code_Z
      {
         get {
            return gxTv_SdtBR_Behavior_Br_behavior_familycahistory_code_Z ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_behavior_familycahistory_code_Z = value;
            SetDirty("Br_behavior_familycahistory_code_Z");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_behavior_familycahistory_code_Z_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_behavior_familycahistory_code_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_behavior_familycahistory_code_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Behavior_FamilyCancer_Z" )]
      [  XmlElement( ElementName = "BR_Behavior_FamilyCancer_Z"   )]
      public String gxTpr_Br_behavior_familycancer_Z
      {
         get {
            return gxTv_SdtBR_Behavior_Br_behavior_familycancer_Z ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_behavior_familycancer_Z = value;
            SetDirty("Br_behavior_familycancer_Z");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_behavior_familycancer_Z_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_behavior_familycancer_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_behavior_familycancer_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Behavior_Menopause_Z" )]
      [  XmlElement( ElementName = "BR_Behavior_Menopause_Z"   )]
      public String gxTpr_Br_behavior_menopause_Z
      {
         get {
            return gxTv_SdtBR_Behavior_Br_behavior_menopause_Z ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_behavior_menopause_Z = value;
            SetDirty("Br_behavior_menopause_Z");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_behavior_menopause_Z_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_behavior_menopause_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_behavior_menopause_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Behavior_Menopause_Code_Z" )]
      [  XmlElement( ElementName = "BR_Behavior_Menopause_Code_Z"   )]
      public String gxTpr_Br_behavior_menopause_code_Z
      {
         get {
            return gxTv_SdtBR_Behavior_Br_behavior_menopause_code_Z ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_behavior_menopause_code_Z = value;
            SetDirty("Br_behavior_menopause_code_Z");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_behavior_menopause_code_Z_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_behavior_menopause_code_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_behavior_menopause_code_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Behavior_MenopauseAge_Z" )]
      [  XmlElement( ElementName = "BR_Behavior_MenopauseAge_Z"   )]
      public short gxTpr_Br_behavior_menopauseage_Z
      {
         get {
            return gxTv_SdtBR_Behavior_Br_behavior_menopauseage_Z ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_behavior_menopauseage_Z = value;
            SetDirty("Br_behavior_menopauseage_Z");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_behavior_menopauseage_Z_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_behavior_menopauseage_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_behavior_menopauseage_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Behavior_RawMenopauseAge_Z" )]
      [  XmlElement( ElementName = "BR_Behavior_RawMenopauseAge_Z"   )]
      public String gxTpr_Br_behavior_rawmenopauseage_Z
      {
         get {
            return gxTv_SdtBR_Behavior_Br_behavior_rawmenopauseage_Z ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_behavior_rawmenopauseage_Z = value;
            SetDirty("Br_behavior_rawmenopauseage_Z");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_behavior_rawmenopauseage_Z_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_behavior_rawmenopauseage_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_behavior_rawmenopauseage_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Behavior_ChildNum_Z" )]
      [  XmlElement( ElementName = "BR_Behavior_ChildNum_Z"   )]
      public String gxTpr_Br_behavior_childnum_Z
      {
         get {
            return gxTv_SdtBR_Behavior_Br_behavior_childnum_Z ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_behavior_childnum_Z = value;
            SetDirty("Br_behavior_childnum_Z");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_behavior_childnum_Z_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_behavior_childnum_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_behavior_childnum_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Information_PatientNo_N" )]
      [  XmlElement( ElementName = "BR_Information_PatientNo_N"   )]
      public short gxTpr_Br_information_patientno_N
      {
         get {
            return gxTv_SdtBR_Behavior_Br_information_patientno_N ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_information_patientno_N = value;
            SetDirty("Br_information_patientno_N");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_information_patientno_N_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_information_patientno_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_information_patientno_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Behavior_Smoking_N" )]
      [  XmlElement( ElementName = "BR_Behavior_Smoking_N"   )]
      public short gxTpr_Br_behavior_smoking_N
      {
         get {
            return gxTv_SdtBR_Behavior_Br_behavior_smoking_N ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_behavior_smoking_N = value;
            SetDirty("Br_behavior_smoking_N");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_behavior_smoking_N_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_behavior_smoking_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_behavior_smoking_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Behavior_Smoking_Code_N" )]
      [  XmlElement( ElementName = "BR_Behavior_Smoking_Code_N"   )]
      public short gxTpr_Br_behavior_smoking_code_N
      {
         get {
            return gxTv_SdtBR_Behavior_Br_behavior_smoking_code_N ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_behavior_smoking_code_N = value;
            SetDirty("Br_behavior_smoking_code_N");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_behavior_smoking_code_N_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_behavior_smoking_code_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_behavior_smoking_code_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Behavior_SmokingTime_N" )]
      [  XmlElement( ElementName = "BR_Behavior_SmokingTime_N"   )]
      public short gxTpr_Br_behavior_smokingtime_N
      {
         get {
            return gxTv_SdtBR_Behavior_Br_behavior_smokingtime_N ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_behavior_smokingtime_N = value;
            SetDirty("Br_behavior_smokingtime_N");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_behavior_smokingtime_N_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_behavior_smokingtime_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_behavior_smokingtime_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Behavior_SmokingAmount_N" )]
      [  XmlElement( ElementName = "BR_Behavior_SmokingAmount_N"   )]
      public short gxTpr_Br_behavior_smokingamount_N
      {
         get {
            return gxTv_SdtBR_Behavior_Br_behavior_smokingamount_N ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_behavior_smokingamount_N = value;
            SetDirty("Br_behavior_smokingamount_N");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_behavior_smokingamount_N_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_behavior_smokingamount_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_behavior_smokingamount_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Behavior_RawSmokingAmount_N" )]
      [  XmlElement( ElementName = "BR_Behavior_RawSmokingAmount_N"   )]
      public short gxTpr_Br_behavior_rawsmokingamount_N
      {
         get {
            return gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount_N ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount_N = value;
            SetDirty("Br_behavior_rawsmokingamount_N");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount_N_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Behavior_RawSmokingAmount_Code_N" )]
      [  XmlElement( ElementName = "BR_Behavior_RawSmokingAmount_Code_N"   )]
      public short gxTpr_Br_behavior_rawsmokingamount_code_N
      {
         get {
            return gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount_code_N ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount_code_N = value;
            SetDirty("Br_behavior_rawsmokingamount_code_N");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount_code_N_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount_code_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount_code_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Behavior_Achohol_N" )]
      [  XmlElement( ElementName = "BR_Behavior_Achohol_N"   )]
      public short gxTpr_Br_behavior_achohol_N
      {
         get {
            return gxTv_SdtBR_Behavior_Br_behavior_achohol_N ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_behavior_achohol_N = value;
            SetDirty("Br_behavior_achohol_N");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_behavior_achohol_N_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_behavior_achohol_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_behavior_achohol_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Behavior_Achohol_Code_N" )]
      [  XmlElement( ElementName = "BR_Behavior_Achohol_Code_N"   )]
      public short gxTpr_Br_behavior_achohol_code_N
      {
         get {
            return gxTv_SdtBR_Behavior_Br_behavior_achohol_code_N ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_behavior_achohol_code_N = value;
            SetDirty("Br_behavior_achohol_code_N");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_behavior_achohol_code_N_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_behavior_achohol_code_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_behavior_achohol_code_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Behavior_AchoholTime_N" )]
      [  XmlElement( ElementName = "BR_Behavior_AchoholTime_N"   )]
      public short gxTpr_Br_behavior_achoholtime_N
      {
         get {
            return gxTv_SdtBR_Behavior_Br_behavior_achoholtime_N ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_behavior_achoholtime_N = value;
            SetDirty("Br_behavior_achoholtime_N");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_behavior_achoholtime_N_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_behavior_achoholtime_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_behavior_achoholtime_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Behavior_AchoholAmount_N" )]
      [  XmlElement( ElementName = "BR_Behavior_AchoholAmount_N"   )]
      public short gxTpr_Br_behavior_achoholamount_N
      {
         get {
            return gxTv_SdtBR_Behavior_Br_behavior_achoholamount_N ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_behavior_achoholamount_N = value;
            SetDirty("Br_behavior_achoholamount_N");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_behavior_achoholamount_N_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_behavior_achoholamount_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_behavior_achoholamount_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Behavior_RawAchoholAmount_N" )]
      [  XmlElement( ElementName = "BR_Behavior_RawAchoholAmount_N"   )]
      public short gxTpr_Br_behavior_rawachoholamount_N
      {
         get {
            return gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount_N ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount_N = value;
            SetDirty("Br_behavior_rawachoholamount_N");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount_N_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Behavior_RawAchoholAmount_Code_N" )]
      [  XmlElement( ElementName = "BR_Behavior_RawAchoholAmount_Code_N"   )]
      public short gxTpr_Br_behavior_rawachoholamount_code_N
      {
         get {
            return gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount_code_N ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount_code_N = value;
            SetDirty("Br_behavior_rawachoholamount_code_N");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount_code_N_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount_code_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount_code_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Behavior_FamilyCaHistory_N" )]
      [  XmlElement( ElementName = "BR_Behavior_FamilyCaHistory_N"   )]
      public short gxTpr_Br_behavior_familycahistory_N
      {
         get {
            return gxTv_SdtBR_Behavior_Br_behavior_familycahistory_N ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_behavior_familycahistory_N = value;
            SetDirty("Br_behavior_familycahistory_N");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_behavior_familycahistory_N_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_behavior_familycahistory_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_behavior_familycahistory_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Behavior_FamilyCaHistory_Code_N" )]
      [  XmlElement( ElementName = "BR_Behavior_FamilyCaHistory_Code_N"   )]
      public short gxTpr_Br_behavior_familycahistory_code_N
      {
         get {
            return gxTv_SdtBR_Behavior_Br_behavior_familycahistory_code_N ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_behavior_familycahistory_code_N = value;
            SetDirty("Br_behavior_familycahistory_code_N");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_behavior_familycahistory_code_N_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_behavior_familycahistory_code_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_behavior_familycahistory_code_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Behavior_FamilyCancer_N" )]
      [  XmlElement( ElementName = "BR_Behavior_FamilyCancer_N"   )]
      public short gxTpr_Br_behavior_familycancer_N
      {
         get {
            return gxTv_SdtBR_Behavior_Br_behavior_familycancer_N ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_behavior_familycancer_N = value;
            SetDirty("Br_behavior_familycancer_N");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_behavior_familycancer_N_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_behavior_familycancer_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_behavior_familycancer_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Behavior_Menopause_N" )]
      [  XmlElement( ElementName = "BR_Behavior_Menopause_N"   )]
      public short gxTpr_Br_behavior_menopause_N
      {
         get {
            return gxTv_SdtBR_Behavior_Br_behavior_menopause_N ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_behavior_menopause_N = value;
            SetDirty("Br_behavior_menopause_N");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_behavior_menopause_N_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_behavior_menopause_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_behavior_menopause_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Behavior_Menopause_Code_N" )]
      [  XmlElement( ElementName = "BR_Behavior_Menopause_Code_N"   )]
      public short gxTpr_Br_behavior_menopause_code_N
      {
         get {
            return gxTv_SdtBR_Behavior_Br_behavior_menopause_code_N ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_behavior_menopause_code_N = value;
            SetDirty("Br_behavior_menopause_code_N");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_behavior_menopause_code_N_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_behavior_menopause_code_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_behavior_menopause_code_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Behavior_MenopauseAge_N" )]
      [  XmlElement( ElementName = "BR_Behavior_MenopauseAge_N"   )]
      public short gxTpr_Br_behavior_menopauseage_N
      {
         get {
            return gxTv_SdtBR_Behavior_Br_behavior_menopauseage_N ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_behavior_menopauseage_N = value;
            SetDirty("Br_behavior_menopauseage_N");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_behavior_menopauseage_N_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_behavior_menopauseage_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_behavior_menopauseage_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Behavior_RawMenopauseAge_N" )]
      [  XmlElement( ElementName = "BR_Behavior_RawMenopauseAge_N"   )]
      public short gxTpr_Br_behavior_rawmenopauseage_N
      {
         get {
            return gxTv_SdtBR_Behavior_Br_behavior_rawmenopauseage_N ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_behavior_rawmenopauseage_N = value;
            SetDirty("Br_behavior_rawmenopauseage_N");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_behavior_rawmenopauseage_N_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_behavior_rawmenopauseage_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_behavior_rawmenopauseage_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Behavior_ChildNum_N" )]
      [  XmlElement( ElementName = "BR_Behavior_ChildNum_N"   )]
      public short gxTpr_Br_behavior_childnum_N
      {
         get {
            return gxTv_SdtBR_Behavior_Br_behavior_childnum_N ;
         }

         set {
            gxTv_SdtBR_Behavior_Br_behavior_childnum_N = value;
            SetDirty("Br_behavior_childnum_N");
         }

      }

      public void gxTv_SdtBR_Behavior_Br_behavior_childnum_N_SetNull( )
      {
         gxTv_SdtBR_Behavior_Br_behavior_childnum_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Behavior_Br_behavior_childnum_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtBR_Behavior_Br_information_patientno = "";
         gxTv_SdtBR_Behavior_Br_behavior_smoking = "";
         gxTv_SdtBR_Behavior_Br_behavior_smoking_code = "";
         gxTv_SdtBR_Behavior_Br_behavior_smokingtime = "";
         gxTv_SdtBR_Behavior_Br_behavior_smokingamount = "";
         gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount = "";
         gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount_code = "";
         gxTv_SdtBR_Behavior_Br_behavior_achohol = "";
         gxTv_SdtBR_Behavior_Br_behavior_achohol_code = "";
         gxTv_SdtBR_Behavior_Br_behavior_achoholtime = "";
         gxTv_SdtBR_Behavior_Br_behavior_achoholamount = "";
         gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount = "";
         gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount_code = "";
         gxTv_SdtBR_Behavior_Br_behavior_familycahistory = "";
         gxTv_SdtBR_Behavior_Br_behavior_familycahistory_code = "";
         gxTv_SdtBR_Behavior_Br_behavior_familycancer = "";
         gxTv_SdtBR_Behavior_Br_behavior_menopause = "";
         gxTv_SdtBR_Behavior_Br_behavior_menopause_code = "";
         gxTv_SdtBR_Behavior_Br_behavior_rawmenopauseage = "";
         gxTv_SdtBR_Behavior_Br_behavior_childnum = "";
         gxTv_SdtBR_Behavior_Mode = "";
         gxTv_SdtBR_Behavior_Br_information_patientno_Z = "";
         gxTv_SdtBR_Behavior_Br_behavior_smoking_Z = "";
         gxTv_SdtBR_Behavior_Br_behavior_smoking_code_Z = "";
         gxTv_SdtBR_Behavior_Br_behavior_smokingtime_Z = "";
         gxTv_SdtBR_Behavior_Br_behavior_smokingamount_Z = "";
         gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount_Z = "";
         gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount_code_Z = "";
         gxTv_SdtBR_Behavior_Br_behavior_achohol_Z = "";
         gxTv_SdtBR_Behavior_Br_behavior_achohol_code_Z = "";
         gxTv_SdtBR_Behavior_Br_behavior_achoholtime_Z = "";
         gxTv_SdtBR_Behavior_Br_behavior_achoholamount_Z = "";
         gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount_Z = "";
         gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount_code_Z = "";
         gxTv_SdtBR_Behavior_Br_behavior_familycahistory_Z = "";
         gxTv_SdtBR_Behavior_Br_behavior_familycahistory_code_Z = "";
         gxTv_SdtBR_Behavior_Br_behavior_familycancer_Z = "";
         gxTv_SdtBR_Behavior_Br_behavior_menopause_Z = "";
         gxTv_SdtBR_Behavior_Br_behavior_menopause_code_Z = "";
         gxTv_SdtBR_Behavior_Br_behavior_rawmenopauseage_Z = "";
         gxTv_SdtBR_Behavior_Br_behavior_childnum_Z = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "br_behavior", "GeneXus.Programs.br_behavior_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtBR_Behavior_Br_behavior_menopauseage ;
      private short gxTv_SdtBR_Behavior_Initialized ;
      private short gxTv_SdtBR_Behavior_Br_behavior_menopauseage_Z ;
      private short gxTv_SdtBR_Behavior_Br_information_patientno_N ;
      private short gxTv_SdtBR_Behavior_Br_behavior_smoking_N ;
      private short gxTv_SdtBR_Behavior_Br_behavior_smoking_code_N ;
      private short gxTv_SdtBR_Behavior_Br_behavior_smokingtime_N ;
      private short gxTv_SdtBR_Behavior_Br_behavior_smokingamount_N ;
      private short gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount_N ;
      private short gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount_code_N ;
      private short gxTv_SdtBR_Behavior_Br_behavior_achohol_N ;
      private short gxTv_SdtBR_Behavior_Br_behavior_achohol_code_N ;
      private short gxTv_SdtBR_Behavior_Br_behavior_achoholtime_N ;
      private short gxTv_SdtBR_Behavior_Br_behavior_achoholamount_N ;
      private short gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount_N ;
      private short gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount_code_N ;
      private short gxTv_SdtBR_Behavior_Br_behavior_familycahistory_N ;
      private short gxTv_SdtBR_Behavior_Br_behavior_familycahistory_code_N ;
      private short gxTv_SdtBR_Behavior_Br_behavior_familycancer_N ;
      private short gxTv_SdtBR_Behavior_Br_behavior_menopause_N ;
      private short gxTv_SdtBR_Behavior_Br_behavior_menopause_code_N ;
      private short gxTv_SdtBR_Behavior_Br_behavior_menopauseage_N ;
      private short gxTv_SdtBR_Behavior_Br_behavior_rawmenopauseage_N ;
      private short gxTv_SdtBR_Behavior_Br_behavior_childnum_N ;
      private long gxTv_SdtBR_Behavior_Br_behaviorid ;
      private long gxTv_SdtBR_Behavior_Br_encounterid ;
      private long gxTv_SdtBR_Behavior_Br_behaviorid_Z ;
      private long gxTv_SdtBR_Behavior_Br_encounterid_Z ;
      private String gxTv_SdtBR_Behavior_Mode ;
      private String gxTv_SdtBR_Behavior_Br_information_patientno ;
      private String gxTv_SdtBR_Behavior_Br_behavior_smoking ;
      private String gxTv_SdtBR_Behavior_Br_behavior_smoking_code ;
      private String gxTv_SdtBR_Behavior_Br_behavior_smokingtime ;
      private String gxTv_SdtBR_Behavior_Br_behavior_smokingamount ;
      private String gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount ;
      private String gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount_code ;
      private String gxTv_SdtBR_Behavior_Br_behavior_achohol ;
      private String gxTv_SdtBR_Behavior_Br_behavior_achohol_code ;
      private String gxTv_SdtBR_Behavior_Br_behavior_achoholtime ;
      private String gxTv_SdtBR_Behavior_Br_behavior_achoholamount ;
      private String gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount ;
      private String gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount_code ;
      private String gxTv_SdtBR_Behavior_Br_behavior_familycahistory ;
      private String gxTv_SdtBR_Behavior_Br_behavior_familycahistory_code ;
      private String gxTv_SdtBR_Behavior_Br_behavior_familycancer ;
      private String gxTv_SdtBR_Behavior_Br_behavior_menopause ;
      private String gxTv_SdtBR_Behavior_Br_behavior_menopause_code ;
      private String gxTv_SdtBR_Behavior_Br_behavior_rawmenopauseage ;
      private String gxTv_SdtBR_Behavior_Br_behavior_childnum ;
      private String gxTv_SdtBR_Behavior_Br_information_patientno_Z ;
      private String gxTv_SdtBR_Behavior_Br_behavior_smoking_Z ;
      private String gxTv_SdtBR_Behavior_Br_behavior_smoking_code_Z ;
      private String gxTv_SdtBR_Behavior_Br_behavior_smokingtime_Z ;
      private String gxTv_SdtBR_Behavior_Br_behavior_smokingamount_Z ;
      private String gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount_Z ;
      private String gxTv_SdtBR_Behavior_Br_behavior_rawsmokingamount_code_Z ;
      private String gxTv_SdtBR_Behavior_Br_behavior_achohol_Z ;
      private String gxTv_SdtBR_Behavior_Br_behavior_achohol_code_Z ;
      private String gxTv_SdtBR_Behavior_Br_behavior_achoholtime_Z ;
      private String gxTv_SdtBR_Behavior_Br_behavior_achoholamount_Z ;
      private String gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount_Z ;
      private String gxTv_SdtBR_Behavior_Br_behavior_rawachoholamount_code_Z ;
      private String gxTv_SdtBR_Behavior_Br_behavior_familycahistory_Z ;
      private String gxTv_SdtBR_Behavior_Br_behavior_familycahistory_code_Z ;
      private String gxTv_SdtBR_Behavior_Br_behavior_familycancer_Z ;
      private String gxTv_SdtBR_Behavior_Br_behavior_menopause_Z ;
      private String gxTv_SdtBR_Behavior_Br_behavior_menopause_code_Z ;
      private String gxTv_SdtBR_Behavior_Br_behavior_rawmenopauseage_Z ;
      private String gxTv_SdtBR_Behavior_Br_behavior_childnum_Z ;
   }

   [DataContract(Name = @"BR_Behavior", Namespace = "DataAnalysisPlatform")]
   public class SdtBR_Behavior_RESTInterface : GxGenericCollectionItem<SdtBR_Behavior>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtBR_Behavior_RESTInterface( ) : base()
      {
      }

      public SdtBR_Behavior_RESTInterface( SdtBR_Behavior psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "BR_BehaviorID" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Br_behaviorid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Br_behaviorid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Br_behaviorid = (long)(NumberUtil.Val( value, "."));
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

      [DataMember( Name = "BR_Behavior_Smoking" , Order = 3 )]
      [GxSeudo()]
      public String gxTpr_Br_behavior_smoking
      {
         get {
            return sdt.gxTpr_Br_behavior_smoking ;
         }

         set {
            sdt.gxTpr_Br_behavior_smoking = value;
         }

      }

      [DataMember( Name = "BR_Behavior_Smoking_Code" , Order = 4 )]
      [GxSeudo()]
      public String gxTpr_Br_behavior_smoking_code
      {
         get {
            return sdt.gxTpr_Br_behavior_smoking_code ;
         }

         set {
            sdt.gxTpr_Br_behavior_smoking_code = value;
         }

      }

      [DataMember( Name = "BR_Behavior_SmokingTime" , Order = 5 )]
      [GxSeudo()]
      public String gxTpr_Br_behavior_smokingtime
      {
         get {
            return sdt.gxTpr_Br_behavior_smokingtime ;
         }

         set {
            sdt.gxTpr_Br_behavior_smokingtime = value;
         }

      }

      [DataMember( Name = "BR_Behavior_SmokingAmount" , Order = 6 )]
      [GxSeudo()]
      public String gxTpr_Br_behavior_smokingamount
      {
         get {
            return sdt.gxTpr_Br_behavior_smokingamount ;
         }

         set {
            sdt.gxTpr_Br_behavior_smokingamount = value;
         }

      }

      [DataMember( Name = "BR_Behavior_RawSmokingAmount" , Order = 7 )]
      [GxSeudo()]
      public String gxTpr_Br_behavior_rawsmokingamount
      {
         get {
            return sdt.gxTpr_Br_behavior_rawsmokingamount ;
         }

         set {
            sdt.gxTpr_Br_behavior_rawsmokingamount = value;
         }

      }

      [DataMember( Name = "BR_Behavior_RawSmokingAmount_Code" , Order = 8 )]
      [GxSeudo()]
      public String gxTpr_Br_behavior_rawsmokingamount_code
      {
         get {
            return sdt.gxTpr_Br_behavior_rawsmokingamount_code ;
         }

         set {
            sdt.gxTpr_Br_behavior_rawsmokingamount_code = value;
         }

      }

      [DataMember( Name = "BR_Behavior_Achohol" , Order = 9 )]
      [GxSeudo()]
      public String gxTpr_Br_behavior_achohol
      {
         get {
            return sdt.gxTpr_Br_behavior_achohol ;
         }

         set {
            sdt.gxTpr_Br_behavior_achohol = value;
         }

      }

      [DataMember( Name = "BR_Behavior_Achohol_Code" , Order = 10 )]
      [GxSeudo()]
      public String gxTpr_Br_behavior_achohol_code
      {
         get {
            return sdt.gxTpr_Br_behavior_achohol_code ;
         }

         set {
            sdt.gxTpr_Br_behavior_achohol_code = value;
         }

      }

      [DataMember( Name = "BR_Behavior_AchoholTime" , Order = 11 )]
      [GxSeudo()]
      public String gxTpr_Br_behavior_achoholtime
      {
         get {
            return sdt.gxTpr_Br_behavior_achoholtime ;
         }

         set {
            sdt.gxTpr_Br_behavior_achoholtime = value;
         }

      }

      [DataMember( Name = "BR_Behavior_AchoholAmount" , Order = 12 )]
      [GxSeudo()]
      public String gxTpr_Br_behavior_achoholamount
      {
         get {
            return sdt.gxTpr_Br_behavior_achoholamount ;
         }

         set {
            sdt.gxTpr_Br_behavior_achoholamount = value;
         }

      }

      [DataMember( Name = "BR_Behavior_RawAchoholAmount" , Order = 13 )]
      [GxSeudo()]
      public String gxTpr_Br_behavior_rawachoholamount
      {
         get {
            return sdt.gxTpr_Br_behavior_rawachoholamount ;
         }

         set {
            sdt.gxTpr_Br_behavior_rawachoholamount = value;
         }

      }

      [DataMember( Name = "BR_Behavior_RawAchoholAmount_Code" , Order = 14 )]
      [GxSeudo()]
      public String gxTpr_Br_behavior_rawachoholamount_code
      {
         get {
            return sdt.gxTpr_Br_behavior_rawachoholamount_code ;
         }

         set {
            sdt.gxTpr_Br_behavior_rawachoholamount_code = value;
         }

      }

      [DataMember( Name = "BR_Behavior_FamilyCaHistory" , Order = 15 )]
      [GxSeudo()]
      public String gxTpr_Br_behavior_familycahistory
      {
         get {
            return sdt.gxTpr_Br_behavior_familycahistory ;
         }

         set {
            sdt.gxTpr_Br_behavior_familycahistory = value;
         }

      }

      [DataMember( Name = "BR_Behavior_FamilyCaHistory_Code" , Order = 16 )]
      [GxSeudo()]
      public String gxTpr_Br_behavior_familycahistory_code
      {
         get {
            return sdt.gxTpr_Br_behavior_familycahistory_code ;
         }

         set {
            sdt.gxTpr_Br_behavior_familycahistory_code = value;
         }

      }

      [DataMember( Name = "BR_Behavior_FamilyCancer" , Order = 17 )]
      [GxSeudo()]
      public String gxTpr_Br_behavior_familycancer
      {
         get {
            return sdt.gxTpr_Br_behavior_familycancer ;
         }

         set {
            sdt.gxTpr_Br_behavior_familycancer = value;
         }

      }

      [DataMember( Name = "BR_Behavior_Menopause" , Order = 18 )]
      [GxSeudo()]
      public String gxTpr_Br_behavior_menopause
      {
         get {
            return sdt.gxTpr_Br_behavior_menopause ;
         }

         set {
            sdt.gxTpr_Br_behavior_menopause = value;
         }

      }

      [DataMember( Name = "BR_Behavior_Menopause_Code" , Order = 19 )]
      [GxSeudo()]
      public String gxTpr_Br_behavior_menopause_code
      {
         get {
            return sdt.gxTpr_Br_behavior_menopause_code ;
         }

         set {
            sdt.gxTpr_Br_behavior_menopause_code = value;
         }

      }

      [DataMember( Name = "BR_Behavior_MenopauseAge" , Order = 20 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Br_behavior_menopauseage
      {
         get {
            return sdt.gxTpr_Br_behavior_menopauseage ;
         }

         set {
            sdt.gxTpr_Br_behavior_menopauseage = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "BR_Behavior_RawMenopauseAge" , Order = 21 )]
      [GxSeudo()]
      public String gxTpr_Br_behavior_rawmenopauseage
      {
         get {
            return sdt.gxTpr_Br_behavior_rawmenopauseage ;
         }

         set {
            sdt.gxTpr_Br_behavior_rawmenopauseage = value;
         }

      }

      [DataMember( Name = "BR_Behavior_ChildNum" , Order = 22 )]
      [GxSeudo()]
      public String gxTpr_Br_behavior_childnum
      {
         get {
            return sdt.gxTpr_Br_behavior_childnum ;
         }

         set {
            sdt.gxTpr_Br_behavior_childnum = value;
         }

      }

      public SdtBR_Behavior sdt
      {
         get {
            return (SdtBR_Behavior)Sdt ;
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
            sdt = new SdtBR_Behavior() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 23 )]
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
