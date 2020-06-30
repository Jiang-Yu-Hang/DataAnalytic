/*
               File: BR_Comorbidity_BC
        Description: 既往病史
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:6:28.77
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
using System.Data;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class br_comorbidity_bc : GXHttpHandler, IGxSilentTrn
   {
      public br_comorbidity_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_comorbidity_bc( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      protected void INITTRN( )
      {
      }

      public void GetInsDefault( )
      {
         ReadRow0910( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey0910( ) ;
         standaloneModal( ) ;
         AddRow0910( ) ;
         Gx_mode = "INS";
         return  ;
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E11092 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               Z37BR_ComorbidityID = A37BR_ComorbidityID;
               SetMode( "UPD") ;
            }
         }
      }

      public override String ToString( )
      {
         return "" ;
      }

      public GxContentInfo GetContentInfo( )
      {
         return (GxContentInfo)(null) ;
      }

      public bool Reindex( )
      {
         return true ;
      }

      protected void CONFIRM_090( )
      {
         BeforeValidate0910( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0910( ) ;
            }
            else
            {
               CheckExtendedTable0910( ) ;
               if ( AnyError == 0 )
               {
                  ZM0910( 36) ;
                  ZM0910( 37) ;
               }
               CloseExtendedTableCursors0910( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void E12092( )
      {
         /* Start Routine */
      }

      protected void E11092( )
      {
         /* After Trn Routine */
      }

      protected void ZM0910( short GX_JID )
      {
         if ( ( GX_JID == 35 ) || ( GX_JID == 0 ) )
         {
            Z487BR_Comorbidity_Hypertension_Code = A487BR_Comorbidity_Hypertension_Code;
            Z488BR_Comorbidity_Diabetes_Code = A488BR_Comorbidity_Diabetes_Code;
            Z489BR_Comorbidity_CHD_Code = A489BR_Comorbidity_CHD_Code;
            Z490BR_Comorbidity_Hapetitis_Code = A490BR_Comorbidity_Hapetitis_Code;
            Z491BR_Comorbidity_TB_Code = A491BR_Comorbidity_TB_Code;
            Z492BR_Comorbidity_KidneyDisease_Code = A492BR_Comorbidity_KidneyDisease_Code;
            Z493BR_Comorbidity_SurgeryHistory_Code = A493BR_Comorbidity_SurgeryHistory_Code;
            Z494BR_Comorbidity_InjuryHistory_Code = A494BR_Comorbidity_InjuryHistory_Code;
            Z495BR_Comorbidity_BloodHistory_Code = A495BR_Comorbidity_BloodHistory_Code;
            Z496BR_Comorbidity_allergy_Code = A496BR_Comorbidity_allergy_Code;
            Z38BR_Comorbidity_Hypertension = A38BR_Comorbidity_Hypertension;
            Z39BR_Comorbidity_Diabetes = A39BR_Comorbidity_Diabetes;
            Z40BR_Comorbidity_CHD = A40BR_Comorbidity_CHD;
            Z41BR_Comorbidity_Hapetitis = A41BR_Comorbidity_Hapetitis;
            Z42BR_Comorbidity_TB = A42BR_Comorbidity_TB;
            Z43BR_Comorbidity_KidneyDisease = A43BR_Comorbidity_KidneyDisease;
            Z44BR_Comorbidity_SurgeryHistory = A44BR_Comorbidity_SurgeryHistory;
            Z45BR_Comorbidity_InjuryHistory = A45BR_Comorbidity_InjuryHistory;
            Z46BR_Comorbidity_BloodHistory = A46BR_Comorbidity_BloodHistory;
            Z47BR_Comorbidity_allergy = A47BR_Comorbidity_allergy;
            Z259BR_Comorbidity_Others = A259BR_Comorbidity_Others;
            Z561BR_Comorbidity_HapetitisB = A561BR_Comorbidity_HapetitisB;
            Z562BR_Comorbidity_HapetitisB_Code = A562BR_Comorbidity_HapetitisB_Code;
            Z563BR_Comorbidity_HapetitisC = A563BR_Comorbidity_HapetitisC;
            Z564BR_Comorbidity_HapetitisC_Code = A564BR_Comorbidity_HapetitisC_Code;
            Z565BR_Comorbidity_LiverCirrhosis = A565BR_Comorbidity_LiverCirrhosis;
            Z566BR_Comorbidity_LiverCirrhosis_Code = A566BR_Comorbidity_LiverCirrhosis_Code;
            Z567BR_Comorbidity_Druginducedliverinjury = A567BR_Comorbidity_Druginducedliverinjury;
            Z568BR_Comorbidity_Druginducedliverinjury_Code = A568BR_Comorbidity_Druginducedliverinjury_Code;
            Z19BR_EncounterID = A19BR_EncounterID;
         }
         if ( ( GX_JID == 36 ) || ( GX_JID == 0 ) )
         {
            Z85BR_Information_ID = A85BR_Information_ID;
         }
         if ( ( GX_JID == 37 ) || ( GX_JID == 0 ) )
         {
            Z36BR_Information_PatientNo = A36BR_Information_PatientNo;
         }
         if ( GX_JID == -35 )
         {
            Z37BR_ComorbidityID = A37BR_ComorbidityID;
            Z487BR_Comorbidity_Hypertension_Code = A487BR_Comorbidity_Hypertension_Code;
            Z488BR_Comorbidity_Diabetes_Code = A488BR_Comorbidity_Diabetes_Code;
            Z489BR_Comorbidity_CHD_Code = A489BR_Comorbidity_CHD_Code;
            Z490BR_Comorbidity_Hapetitis_Code = A490BR_Comorbidity_Hapetitis_Code;
            Z491BR_Comorbidity_TB_Code = A491BR_Comorbidity_TB_Code;
            Z492BR_Comorbidity_KidneyDisease_Code = A492BR_Comorbidity_KidneyDisease_Code;
            Z493BR_Comorbidity_SurgeryHistory_Code = A493BR_Comorbidity_SurgeryHistory_Code;
            Z494BR_Comorbidity_InjuryHistory_Code = A494BR_Comorbidity_InjuryHistory_Code;
            Z495BR_Comorbidity_BloodHistory_Code = A495BR_Comorbidity_BloodHistory_Code;
            Z496BR_Comorbidity_allergy_Code = A496BR_Comorbidity_allergy_Code;
            Z38BR_Comorbidity_Hypertension = A38BR_Comorbidity_Hypertension;
            Z39BR_Comorbidity_Diabetes = A39BR_Comorbidity_Diabetes;
            Z40BR_Comorbidity_CHD = A40BR_Comorbidity_CHD;
            Z41BR_Comorbidity_Hapetitis = A41BR_Comorbidity_Hapetitis;
            Z42BR_Comorbidity_TB = A42BR_Comorbidity_TB;
            Z43BR_Comorbidity_KidneyDisease = A43BR_Comorbidity_KidneyDisease;
            Z44BR_Comorbidity_SurgeryHistory = A44BR_Comorbidity_SurgeryHistory;
            Z45BR_Comorbidity_InjuryHistory = A45BR_Comorbidity_InjuryHistory;
            Z46BR_Comorbidity_BloodHistory = A46BR_Comorbidity_BloodHistory;
            Z47BR_Comorbidity_allergy = A47BR_Comorbidity_allergy;
            Z259BR_Comorbidity_Others = A259BR_Comorbidity_Others;
            Z561BR_Comorbidity_HapetitisB = A561BR_Comorbidity_HapetitisB;
            Z562BR_Comorbidity_HapetitisB_Code = A562BR_Comorbidity_HapetitisB_Code;
            Z563BR_Comorbidity_HapetitisC = A563BR_Comorbidity_HapetitisC;
            Z564BR_Comorbidity_HapetitisC_Code = A564BR_Comorbidity_HapetitisC_Code;
            Z565BR_Comorbidity_LiverCirrhosis = A565BR_Comorbidity_LiverCirrhosis;
            Z566BR_Comorbidity_LiverCirrhosis_Code = A566BR_Comorbidity_LiverCirrhosis_Code;
            Z567BR_Comorbidity_Druginducedliverinjury = A567BR_Comorbidity_Druginducedliverinjury;
            Z568BR_Comorbidity_Druginducedliverinjury_Code = A568BR_Comorbidity_Druginducedliverinjury_Code;
            Z19BR_EncounterID = A19BR_EncounterID;
            Z85BR_Information_ID = A85BR_Information_ID;
            Z36BR_Information_PatientNo = A36BR_Information_PatientNo;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load0910( )
      {
         /* Using cursor BC00096 */
         pr_default.execute(4, new Object[] {A37BR_ComorbidityID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound10 = 1;
            A85BR_Information_ID = BC00096_A85BR_Information_ID[0];
            n85BR_Information_ID = BC00096_n85BR_Information_ID[0];
            A487BR_Comorbidity_Hypertension_Code = BC00096_A487BR_Comorbidity_Hypertension_Code[0];
            n487BR_Comorbidity_Hypertension_Code = BC00096_n487BR_Comorbidity_Hypertension_Code[0];
            A488BR_Comorbidity_Diabetes_Code = BC00096_A488BR_Comorbidity_Diabetes_Code[0];
            n488BR_Comorbidity_Diabetes_Code = BC00096_n488BR_Comorbidity_Diabetes_Code[0];
            A489BR_Comorbidity_CHD_Code = BC00096_A489BR_Comorbidity_CHD_Code[0];
            n489BR_Comorbidity_CHD_Code = BC00096_n489BR_Comorbidity_CHD_Code[0];
            A490BR_Comorbidity_Hapetitis_Code = BC00096_A490BR_Comorbidity_Hapetitis_Code[0];
            n490BR_Comorbidity_Hapetitis_Code = BC00096_n490BR_Comorbidity_Hapetitis_Code[0];
            A491BR_Comorbidity_TB_Code = BC00096_A491BR_Comorbidity_TB_Code[0];
            n491BR_Comorbidity_TB_Code = BC00096_n491BR_Comorbidity_TB_Code[0];
            A492BR_Comorbidity_KidneyDisease_Code = BC00096_A492BR_Comorbidity_KidneyDisease_Code[0];
            n492BR_Comorbidity_KidneyDisease_Code = BC00096_n492BR_Comorbidity_KidneyDisease_Code[0];
            A493BR_Comorbidity_SurgeryHistory_Code = BC00096_A493BR_Comorbidity_SurgeryHistory_Code[0];
            n493BR_Comorbidity_SurgeryHistory_Code = BC00096_n493BR_Comorbidity_SurgeryHistory_Code[0];
            A494BR_Comorbidity_InjuryHistory_Code = BC00096_A494BR_Comorbidity_InjuryHistory_Code[0];
            n494BR_Comorbidity_InjuryHistory_Code = BC00096_n494BR_Comorbidity_InjuryHistory_Code[0];
            A495BR_Comorbidity_BloodHistory_Code = BC00096_A495BR_Comorbidity_BloodHistory_Code[0];
            n495BR_Comorbidity_BloodHistory_Code = BC00096_n495BR_Comorbidity_BloodHistory_Code[0];
            A496BR_Comorbidity_allergy_Code = BC00096_A496BR_Comorbidity_allergy_Code[0];
            n496BR_Comorbidity_allergy_Code = BC00096_n496BR_Comorbidity_allergy_Code[0];
            A36BR_Information_PatientNo = BC00096_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = BC00096_n36BR_Information_PatientNo[0];
            A38BR_Comorbidity_Hypertension = BC00096_A38BR_Comorbidity_Hypertension[0];
            n38BR_Comorbidity_Hypertension = BC00096_n38BR_Comorbidity_Hypertension[0];
            A39BR_Comorbidity_Diabetes = BC00096_A39BR_Comorbidity_Diabetes[0];
            n39BR_Comorbidity_Diabetes = BC00096_n39BR_Comorbidity_Diabetes[0];
            A40BR_Comorbidity_CHD = BC00096_A40BR_Comorbidity_CHD[0];
            n40BR_Comorbidity_CHD = BC00096_n40BR_Comorbidity_CHD[0];
            A41BR_Comorbidity_Hapetitis = BC00096_A41BR_Comorbidity_Hapetitis[0];
            n41BR_Comorbidity_Hapetitis = BC00096_n41BR_Comorbidity_Hapetitis[0];
            A42BR_Comorbidity_TB = BC00096_A42BR_Comorbidity_TB[0];
            n42BR_Comorbidity_TB = BC00096_n42BR_Comorbidity_TB[0];
            A43BR_Comorbidity_KidneyDisease = BC00096_A43BR_Comorbidity_KidneyDisease[0];
            n43BR_Comorbidity_KidneyDisease = BC00096_n43BR_Comorbidity_KidneyDisease[0];
            A44BR_Comorbidity_SurgeryHistory = BC00096_A44BR_Comorbidity_SurgeryHistory[0];
            n44BR_Comorbidity_SurgeryHistory = BC00096_n44BR_Comorbidity_SurgeryHistory[0];
            A45BR_Comorbidity_InjuryHistory = BC00096_A45BR_Comorbidity_InjuryHistory[0];
            n45BR_Comorbidity_InjuryHistory = BC00096_n45BR_Comorbidity_InjuryHistory[0];
            A46BR_Comorbidity_BloodHistory = BC00096_A46BR_Comorbidity_BloodHistory[0];
            n46BR_Comorbidity_BloodHistory = BC00096_n46BR_Comorbidity_BloodHistory[0];
            A47BR_Comorbidity_allergy = BC00096_A47BR_Comorbidity_allergy[0];
            n47BR_Comorbidity_allergy = BC00096_n47BR_Comorbidity_allergy[0];
            A259BR_Comorbidity_Others = BC00096_A259BR_Comorbidity_Others[0];
            n259BR_Comorbidity_Others = BC00096_n259BR_Comorbidity_Others[0];
            A561BR_Comorbidity_HapetitisB = BC00096_A561BR_Comorbidity_HapetitisB[0];
            n561BR_Comorbidity_HapetitisB = BC00096_n561BR_Comorbidity_HapetitisB[0];
            A562BR_Comorbidity_HapetitisB_Code = BC00096_A562BR_Comorbidity_HapetitisB_Code[0];
            n562BR_Comorbidity_HapetitisB_Code = BC00096_n562BR_Comorbidity_HapetitisB_Code[0];
            A563BR_Comorbidity_HapetitisC = BC00096_A563BR_Comorbidity_HapetitisC[0];
            n563BR_Comorbidity_HapetitisC = BC00096_n563BR_Comorbidity_HapetitisC[0];
            A564BR_Comorbidity_HapetitisC_Code = BC00096_A564BR_Comorbidity_HapetitisC_Code[0];
            n564BR_Comorbidity_HapetitisC_Code = BC00096_n564BR_Comorbidity_HapetitisC_Code[0];
            A565BR_Comorbidity_LiverCirrhosis = BC00096_A565BR_Comorbidity_LiverCirrhosis[0];
            n565BR_Comorbidity_LiverCirrhosis = BC00096_n565BR_Comorbidity_LiverCirrhosis[0];
            A566BR_Comorbidity_LiverCirrhosis_Code = BC00096_A566BR_Comorbidity_LiverCirrhosis_Code[0];
            n566BR_Comorbidity_LiverCirrhosis_Code = BC00096_n566BR_Comorbidity_LiverCirrhosis_Code[0];
            A567BR_Comorbidity_Druginducedliverinjury = BC00096_A567BR_Comorbidity_Druginducedliverinjury[0];
            n567BR_Comorbidity_Druginducedliverinjury = BC00096_n567BR_Comorbidity_Druginducedliverinjury[0];
            A568BR_Comorbidity_Druginducedliverinjury_Code = BC00096_A568BR_Comorbidity_Druginducedliverinjury_Code[0];
            n568BR_Comorbidity_Druginducedliverinjury_Code = BC00096_n568BR_Comorbidity_Druginducedliverinjury_Code[0];
            A19BR_EncounterID = BC00096_A19BR_EncounterID[0];
            ZM0910( -35) ;
         }
         pr_default.close(4);
         OnLoadActions0910( ) ;
      }

      protected void OnLoadActions0910( )
      {
      }

      protected void CheckExtendedTable0910( )
      {
         standaloneModal( ) ;
         /* Using cursor BC00094 */
         pr_default.execute(2, new Object[] {A19BR_EncounterID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("不匹配' T15'", "ForeignKeyNotFound", 1, "BR_ENCOUNTERID");
            AnyError = 1;
         }
         A85BR_Information_ID = BC00094_A85BR_Information_ID[0];
         n85BR_Information_ID = BC00094_n85BR_Information_ID[0];
         pr_default.close(2);
         /* Using cursor BC00095 */
         pr_default.execute(3, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
         if ( (pr_default.getStatus(3) == 101) )
         {
            if ( ! ( (0==A85BR_Information_ID) ) )
            {
               GX_msglist.addItem("不匹配' T16'", "ForeignKeyNotFound", 1, "");
               AnyError = 1;
            }
         }
         A36BR_Information_PatientNo = BC00095_A36BR_Information_PatientNo[0];
         n36BR_Information_PatientNo = BC00095_n36BR_Information_PatientNo[0];
         pr_default.close(3);
         if ( ! ( ( StringUtil.StrCmp(A38BR_Comorbidity_Hypertension, "否") == 0 ) || ( StringUtil.StrCmp(A38BR_Comorbidity_Hypertension, "是") == 0 ) || ( StringUtil.StrCmp(A38BR_Comorbidity_Hypertension, "不详") == 0 ) || String.IsNullOrEmpty(StringUtil.RTrim( A38BR_Comorbidity_Hypertension)) ) )
         {
            GX_msglist.addItem("域高血压超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
         if ( ! ( ( StringUtil.StrCmp(A39BR_Comorbidity_Diabetes, "否") == 0 ) || ( StringUtil.StrCmp(A39BR_Comorbidity_Diabetes, "是") == 0 ) || ( StringUtil.StrCmp(A39BR_Comorbidity_Diabetes, "不详") == 0 ) || String.IsNullOrEmpty(StringUtil.RTrim( A39BR_Comorbidity_Diabetes)) ) )
         {
            GX_msglist.addItem("域糖尿病超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
         if ( ! ( ( StringUtil.StrCmp(A40BR_Comorbidity_CHD, "否") == 0 ) || ( StringUtil.StrCmp(A40BR_Comorbidity_CHD, "是") == 0 ) || ( StringUtil.StrCmp(A40BR_Comorbidity_CHD, "不详") == 0 ) || String.IsNullOrEmpty(StringUtil.RTrim( A40BR_Comorbidity_CHD)) ) )
         {
            GX_msglist.addItem("域冠心病超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
         if ( ! ( ( StringUtil.StrCmp(A41BR_Comorbidity_Hapetitis, "否") == 0 ) || ( StringUtil.StrCmp(A41BR_Comorbidity_Hapetitis, "是") == 0 ) || ( StringUtil.StrCmp(A41BR_Comorbidity_Hapetitis, "不详") == 0 ) || String.IsNullOrEmpty(StringUtil.RTrim( A41BR_Comorbidity_Hapetitis)) ) )
         {
            GX_msglist.addItem("域肝炎超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
         if ( ! ( ( StringUtil.StrCmp(A42BR_Comorbidity_TB, "否") == 0 ) || ( StringUtil.StrCmp(A42BR_Comorbidity_TB, "是") == 0 ) || ( StringUtil.StrCmp(A42BR_Comorbidity_TB, "不详") == 0 ) || String.IsNullOrEmpty(StringUtil.RTrim( A42BR_Comorbidity_TB)) ) )
         {
            GX_msglist.addItem("域结核病超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
         if ( ! ( ( StringUtil.StrCmp(A43BR_Comorbidity_KidneyDisease, "否") == 0 ) || ( StringUtil.StrCmp(A43BR_Comorbidity_KidneyDisease, "是") == 0 ) || ( StringUtil.StrCmp(A43BR_Comorbidity_KidneyDisease, "不详") == 0 ) || String.IsNullOrEmpty(StringUtil.RTrim( A43BR_Comorbidity_KidneyDisease)) ) )
         {
            GX_msglist.addItem("域肾病超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
         if ( ! ( ( StringUtil.StrCmp(A44BR_Comorbidity_SurgeryHistory, "否") == 0 ) || ( StringUtil.StrCmp(A44BR_Comorbidity_SurgeryHistory, "是") == 0 ) || ( StringUtil.StrCmp(A44BR_Comorbidity_SurgeryHistory, "不详") == 0 ) || String.IsNullOrEmpty(StringUtil.RTrim( A44BR_Comorbidity_SurgeryHistory)) ) )
         {
            GX_msglist.addItem("域手术史超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
         if ( ! ( ( StringUtil.StrCmp(A45BR_Comorbidity_InjuryHistory, "否") == 0 ) || ( StringUtil.StrCmp(A45BR_Comorbidity_InjuryHistory, "是") == 0 ) || ( StringUtil.StrCmp(A45BR_Comorbidity_InjuryHistory, "不详") == 0 ) || String.IsNullOrEmpty(StringUtil.RTrim( A45BR_Comorbidity_InjuryHistory)) ) )
         {
            GX_msglist.addItem("域外伤史超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
         if ( ! ( ( StringUtil.StrCmp(A46BR_Comorbidity_BloodHistory, "否") == 0 ) || ( StringUtil.StrCmp(A46BR_Comorbidity_BloodHistory, "是") == 0 ) || ( StringUtil.StrCmp(A46BR_Comorbidity_BloodHistory, "不详") == 0 ) || String.IsNullOrEmpty(StringUtil.RTrim( A46BR_Comorbidity_BloodHistory)) ) )
         {
            GX_msglist.addItem("域输血史超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
         if ( ! ( ( StringUtil.StrCmp(A47BR_Comorbidity_allergy, "否") == 0 ) || ( StringUtil.StrCmp(A47BR_Comorbidity_allergy, "是") == 0 ) || ( StringUtil.StrCmp(A47BR_Comorbidity_allergy, "不详") == 0 ) || String.IsNullOrEmpty(StringUtil.RTrim( A47BR_Comorbidity_allergy)) ) )
         {
            GX_msglist.addItem("域过敏史超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
         if ( ! ( ( StringUtil.StrCmp(A561BR_Comorbidity_HapetitisB, "否") == 0 ) || ( StringUtil.StrCmp(A561BR_Comorbidity_HapetitisB, "是") == 0 ) || ( StringUtil.StrCmp(A561BR_Comorbidity_HapetitisB, "不详") == 0 ) || String.IsNullOrEmpty(StringUtil.RTrim( A561BR_Comorbidity_HapetitisB)) ) )
         {
            GX_msglist.addItem("域乙肝超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
         if ( ! ( ( StringUtil.StrCmp(A563BR_Comorbidity_HapetitisC, "否") == 0 ) || ( StringUtil.StrCmp(A563BR_Comorbidity_HapetitisC, "是") == 0 ) || ( StringUtil.StrCmp(A563BR_Comorbidity_HapetitisC, "不详") == 0 ) || String.IsNullOrEmpty(StringUtil.RTrim( A563BR_Comorbidity_HapetitisC)) ) )
         {
            GX_msglist.addItem("域丙肝超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
         if ( ! ( ( StringUtil.StrCmp(A565BR_Comorbidity_LiverCirrhosis, "否") == 0 ) || ( StringUtil.StrCmp(A565BR_Comorbidity_LiverCirrhosis, "是") == 0 ) || ( StringUtil.StrCmp(A565BR_Comorbidity_LiverCirrhosis, "不详") == 0 ) || String.IsNullOrEmpty(StringUtil.RTrim( A565BR_Comorbidity_LiverCirrhosis)) ) )
         {
            GX_msglist.addItem("域肝硬化超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
         if ( ! ( ( StringUtil.StrCmp(A567BR_Comorbidity_Druginducedliverinjury, "否") == 0 ) || ( StringUtil.StrCmp(A567BR_Comorbidity_Druginducedliverinjury, "是") == 0 ) || ( StringUtil.StrCmp(A567BR_Comorbidity_Druginducedliverinjury, "不详") == 0 ) || String.IsNullOrEmpty(StringUtil.RTrim( A567BR_Comorbidity_Druginducedliverinjury)) ) )
         {
            GX_msglist.addItem("域药物性肝损伤超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
      }

      protected void CloseExtendedTableCursors0910( )
      {
         pr_default.close(2);
         pr_default.close(3);
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0910( )
      {
         /* Using cursor BC00097 */
         pr_default.execute(5, new Object[] {A37BR_ComorbidityID});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound10 = 1;
         }
         else
         {
            RcdFound10 = 0;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC00093 */
         pr_default.execute(1, new Object[] {A37BR_ComorbidityID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0910( 35) ;
            RcdFound10 = 1;
            A37BR_ComorbidityID = BC00093_A37BR_ComorbidityID[0];
            A487BR_Comorbidity_Hypertension_Code = BC00093_A487BR_Comorbidity_Hypertension_Code[0];
            n487BR_Comorbidity_Hypertension_Code = BC00093_n487BR_Comorbidity_Hypertension_Code[0];
            A488BR_Comorbidity_Diabetes_Code = BC00093_A488BR_Comorbidity_Diabetes_Code[0];
            n488BR_Comorbidity_Diabetes_Code = BC00093_n488BR_Comorbidity_Diabetes_Code[0];
            A489BR_Comorbidity_CHD_Code = BC00093_A489BR_Comorbidity_CHD_Code[0];
            n489BR_Comorbidity_CHD_Code = BC00093_n489BR_Comorbidity_CHD_Code[0];
            A490BR_Comorbidity_Hapetitis_Code = BC00093_A490BR_Comorbidity_Hapetitis_Code[0];
            n490BR_Comorbidity_Hapetitis_Code = BC00093_n490BR_Comorbidity_Hapetitis_Code[0];
            A491BR_Comorbidity_TB_Code = BC00093_A491BR_Comorbidity_TB_Code[0];
            n491BR_Comorbidity_TB_Code = BC00093_n491BR_Comorbidity_TB_Code[0];
            A492BR_Comorbidity_KidneyDisease_Code = BC00093_A492BR_Comorbidity_KidneyDisease_Code[0];
            n492BR_Comorbidity_KidneyDisease_Code = BC00093_n492BR_Comorbidity_KidneyDisease_Code[0];
            A493BR_Comorbidity_SurgeryHistory_Code = BC00093_A493BR_Comorbidity_SurgeryHistory_Code[0];
            n493BR_Comorbidity_SurgeryHistory_Code = BC00093_n493BR_Comorbidity_SurgeryHistory_Code[0];
            A494BR_Comorbidity_InjuryHistory_Code = BC00093_A494BR_Comorbidity_InjuryHistory_Code[0];
            n494BR_Comorbidity_InjuryHistory_Code = BC00093_n494BR_Comorbidity_InjuryHistory_Code[0];
            A495BR_Comorbidity_BloodHistory_Code = BC00093_A495BR_Comorbidity_BloodHistory_Code[0];
            n495BR_Comorbidity_BloodHistory_Code = BC00093_n495BR_Comorbidity_BloodHistory_Code[0];
            A496BR_Comorbidity_allergy_Code = BC00093_A496BR_Comorbidity_allergy_Code[0];
            n496BR_Comorbidity_allergy_Code = BC00093_n496BR_Comorbidity_allergy_Code[0];
            A38BR_Comorbidity_Hypertension = BC00093_A38BR_Comorbidity_Hypertension[0];
            n38BR_Comorbidity_Hypertension = BC00093_n38BR_Comorbidity_Hypertension[0];
            A39BR_Comorbidity_Diabetes = BC00093_A39BR_Comorbidity_Diabetes[0];
            n39BR_Comorbidity_Diabetes = BC00093_n39BR_Comorbidity_Diabetes[0];
            A40BR_Comorbidity_CHD = BC00093_A40BR_Comorbidity_CHD[0];
            n40BR_Comorbidity_CHD = BC00093_n40BR_Comorbidity_CHD[0];
            A41BR_Comorbidity_Hapetitis = BC00093_A41BR_Comorbidity_Hapetitis[0];
            n41BR_Comorbidity_Hapetitis = BC00093_n41BR_Comorbidity_Hapetitis[0];
            A42BR_Comorbidity_TB = BC00093_A42BR_Comorbidity_TB[0];
            n42BR_Comorbidity_TB = BC00093_n42BR_Comorbidity_TB[0];
            A43BR_Comorbidity_KidneyDisease = BC00093_A43BR_Comorbidity_KidneyDisease[0];
            n43BR_Comorbidity_KidneyDisease = BC00093_n43BR_Comorbidity_KidneyDisease[0];
            A44BR_Comorbidity_SurgeryHistory = BC00093_A44BR_Comorbidity_SurgeryHistory[0];
            n44BR_Comorbidity_SurgeryHistory = BC00093_n44BR_Comorbidity_SurgeryHistory[0];
            A45BR_Comorbidity_InjuryHistory = BC00093_A45BR_Comorbidity_InjuryHistory[0];
            n45BR_Comorbidity_InjuryHistory = BC00093_n45BR_Comorbidity_InjuryHistory[0];
            A46BR_Comorbidity_BloodHistory = BC00093_A46BR_Comorbidity_BloodHistory[0];
            n46BR_Comorbidity_BloodHistory = BC00093_n46BR_Comorbidity_BloodHistory[0];
            A47BR_Comorbidity_allergy = BC00093_A47BR_Comorbidity_allergy[0];
            n47BR_Comorbidity_allergy = BC00093_n47BR_Comorbidity_allergy[0];
            A259BR_Comorbidity_Others = BC00093_A259BR_Comorbidity_Others[0];
            n259BR_Comorbidity_Others = BC00093_n259BR_Comorbidity_Others[0];
            A561BR_Comorbidity_HapetitisB = BC00093_A561BR_Comorbidity_HapetitisB[0];
            n561BR_Comorbidity_HapetitisB = BC00093_n561BR_Comorbidity_HapetitisB[0];
            A562BR_Comorbidity_HapetitisB_Code = BC00093_A562BR_Comorbidity_HapetitisB_Code[0];
            n562BR_Comorbidity_HapetitisB_Code = BC00093_n562BR_Comorbidity_HapetitisB_Code[0];
            A563BR_Comorbidity_HapetitisC = BC00093_A563BR_Comorbidity_HapetitisC[0];
            n563BR_Comorbidity_HapetitisC = BC00093_n563BR_Comorbidity_HapetitisC[0];
            A564BR_Comorbidity_HapetitisC_Code = BC00093_A564BR_Comorbidity_HapetitisC_Code[0];
            n564BR_Comorbidity_HapetitisC_Code = BC00093_n564BR_Comorbidity_HapetitisC_Code[0];
            A565BR_Comorbidity_LiverCirrhosis = BC00093_A565BR_Comorbidity_LiverCirrhosis[0];
            n565BR_Comorbidity_LiverCirrhosis = BC00093_n565BR_Comorbidity_LiverCirrhosis[0];
            A566BR_Comorbidity_LiverCirrhosis_Code = BC00093_A566BR_Comorbidity_LiverCirrhosis_Code[0];
            n566BR_Comorbidity_LiverCirrhosis_Code = BC00093_n566BR_Comorbidity_LiverCirrhosis_Code[0];
            A567BR_Comorbidity_Druginducedliverinjury = BC00093_A567BR_Comorbidity_Druginducedliverinjury[0];
            n567BR_Comorbidity_Druginducedliverinjury = BC00093_n567BR_Comorbidity_Druginducedliverinjury[0];
            A568BR_Comorbidity_Druginducedliverinjury_Code = BC00093_A568BR_Comorbidity_Druginducedliverinjury_Code[0];
            n568BR_Comorbidity_Druginducedliverinjury_Code = BC00093_n568BR_Comorbidity_Druginducedliverinjury_Code[0];
            A19BR_EncounterID = BC00093_A19BR_EncounterID[0];
            Z37BR_ComorbidityID = A37BR_ComorbidityID;
            sMode10 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load0910( ) ;
            if ( AnyError == 1 )
            {
               RcdFound10 = 0;
               InitializeNonKey0910( ) ;
            }
            Gx_mode = sMode10;
         }
         else
         {
            RcdFound10 = 0;
            InitializeNonKey0910( ) ;
            sMode10 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode10;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0910( ) ;
         if ( RcdFound10 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
         }
         getByPrimaryKey( ) ;
      }

      protected void insert_Check( )
      {
         CONFIRM_090( ) ;
         IsConfirmed = 0;
      }

      protected void update_Check( )
      {
         insert_Check( ) ;
      }

      protected void delete_Check( )
      {
         insert_Check( ) ;
      }

      protected void CheckOptimisticConcurrency0910( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC00092 */
            pr_default.execute(0, new Object[] {A37BR_ComorbidityID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Comorbidity"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z487BR_Comorbidity_Hypertension_Code, BC00092_A487BR_Comorbidity_Hypertension_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z488BR_Comorbidity_Diabetes_Code, BC00092_A488BR_Comorbidity_Diabetes_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z489BR_Comorbidity_CHD_Code, BC00092_A489BR_Comorbidity_CHD_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z490BR_Comorbidity_Hapetitis_Code, BC00092_A490BR_Comorbidity_Hapetitis_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z491BR_Comorbidity_TB_Code, BC00092_A491BR_Comorbidity_TB_Code[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z492BR_Comorbidity_KidneyDisease_Code, BC00092_A492BR_Comorbidity_KidneyDisease_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z493BR_Comorbidity_SurgeryHistory_Code, BC00092_A493BR_Comorbidity_SurgeryHistory_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z494BR_Comorbidity_InjuryHistory_Code, BC00092_A494BR_Comorbidity_InjuryHistory_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z495BR_Comorbidity_BloodHistory_Code, BC00092_A495BR_Comorbidity_BloodHistory_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z496BR_Comorbidity_allergy_Code, BC00092_A496BR_Comorbidity_allergy_Code[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z38BR_Comorbidity_Hypertension, BC00092_A38BR_Comorbidity_Hypertension[0]) != 0 ) || ( StringUtil.StrCmp(Z39BR_Comorbidity_Diabetes, BC00092_A39BR_Comorbidity_Diabetes[0]) != 0 ) || ( StringUtil.StrCmp(Z40BR_Comorbidity_CHD, BC00092_A40BR_Comorbidity_CHD[0]) != 0 ) || ( StringUtil.StrCmp(Z41BR_Comorbidity_Hapetitis, BC00092_A41BR_Comorbidity_Hapetitis[0]) != 0 ) || ( StringUtil.StrCmp(Z42BR_Comorbidity_TB, BC00092_A42BR_Comorbidity_TB[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z43BR_Comorbidity_KidneyDisease, BC00092_A43BR_Comorbidity_KidneyDisease[0]) != 0 ) || ( StringUtil.StrCmp(Z44BR_Comorbidity_SurgeryHistory, BC00092_A44BR_Comorbidity_SurgeryHistory[0]) != 0 ) || ( StringUtil.StrCmp(Z45BR_Comorbidity_InjuryHistory, BC00092_A45BR_Comorbidity_InjuryHistory[0]) != 0 ) || ( StringUtil.StrCmp(Z46BR_Comorbidity_BloodHistory, BC00092_A46BR_Comorbidity_BloodHistory[0]) != 0 ) || ( StringUtil.StrCmp(Z47BR_Comorbidity_allergy, BC00092_A47BR_Comorbidity_allergy[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z259BR_Comorbidity_Others, BC00092_A259BR_Comorbidity_Others[0]) != 0 ) || ( StringUtil.StrCmp(Z561BR_Comorbidity_HapetitisB, BC00092_A561BR_Comorbidity_HapetitisB[0]) != 0 ) || ( StringUtil.StrCmp(Z562BR_Comorbidity_HapetitisB_Code, BC00092_A562BR_Comorbidity_HapetitisB_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z563BR_Comorbidity_HapetitisC, BC00092_A563BR_Comorbidity_HapetitisC[0]) != 0 ) || ( StringUtil.StrCmp(Z564BR_Comorbidity_HapetitisC_Code, BC00092_A564BR_Comorbidity_HapetitisC_Code[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z565BR_Comorbidity_LiverCirrhosis, BC00092_A565BR_Comorbidity_LiverCirrhosis[0]) != 0 ) || ( StringUtil.StrCmp(Z566BR_Comorbidity_LiverCirrhosis_Code, BC00092_A566BR_Comorbidity_LiverCirrhosis_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z567BR_Comorbidity_Druginducedliverinjury, BC00092_A567BR_Comorbidity_Druginducedliverinjury[0]) != 0 ) || ( StringUtil.StrCmp(Z568BR_Comorbidity_Druginducedliverinjury_Code, BC00092_A568BR_Comorbidity_Druginducedliverinjury_Code[0]) != 0 ) || ( Z19BR_EncounterID != BC00092_A19BR_EncounterID[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"BR_Comorbidity"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0910( )
      {
         BeforeValidate0910( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0910( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0910( 0) ;
            CheckOptimisticConcurrency0910( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0910( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0910( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00098 */
                     pr_default.execute(6, new Object[] {n487BR_Comorbidity_Hypertension_Code, A487BR_Comorbidity_Hypertension_Code, n488BR_Comorbidity_Diabetes_Code, A488BR_Comorbidity_Diabetes_Code, n489BR_Comorbidity_CHD_Code, A489BR_Comorbidity_CHD_Code, n490BR_Comorbidity_Hapetitis_Code, A490BR_Comorbidity_Hapetitis_Code, n491BR_Comorbidity_TB_Code, A491BR_Comorbidity_TB_Code, n492BR_Comorbidity_KidneyDisease_Code, A492BR_Comorbidity_KidneyDisease_Code, n493BR_Comorbidity_SurgeryHistory_Code, A493BR_Comorbidity_SurgeryHistory_Code, n494BR_Comorbidity_InjuryHistory_Code, A494BR_Comorbidity_InjuryHistory_Code, n495BR_Comorbidity_BloodHistory_Code, A495BR_Comorbidity_BloodHistory_Code, n496BR_Comorbidity_allergy_Code, A496BR_Comorbidity_allergy_Code, n38BR_Comorbidity_Hypertension, A38BR_Comorbidity_Hypertension, n39BR_Comorbidity_Diabetes, A39BR_Comorbidity_Diabetes, n40BR_Comorbidity_CHD, A40BR_Comorbidity_CHD, n41BR_Comorbidity_Hapetitis, A41BR_Comorbidity_Hapetitis, n42BR_Comorbidity_TB, A42BR_Comorbidity_TB, n43BR_Comorbidity_KidneyDisease, A43BR_Comorbidity_KidneyDisease, n44BR_Comorbidity_SurgeryHistory, A44BR_Comorbidity_SurgeryHistory, n45BR_Comorbidity_InjuryHistory, A45BR_Comorbidity_InjuryHistory, n46BR_Comorbidity_BloodHistory, A46BR_Comorbidity_BloodHistory, n47BR_Comorbidity_allergy, A47BR_Comorbidity_allergy, n259BR_Comorbidity_Others, A259BR_Comorbidity_Others, n561BR_Comorbidity_HapetitisB, A561BR_Comorbidity_HapetitisB, n562BR_Comorbidity_HapetitisB_Code, A562BR_Comorbidity_HapetitisB_Code, n563BR_Comorbidity_HapetitisC, A563BR_Comorbidity_HapetitisC, n564BR_Comorbidity_HapetitisC_Code, A564BR_Comorbidity_HapetitisC_Code, n565BR_Comorbidity_LiverCirrhosis, A565BR_Comorbidity_LiverCirrhosis, n566BR_Comorbidity_LiverCirrhosis_Code, A566BR_Comorbidity_LiverCirrhosis_Code, n567BR_Comorbidity_Druginducedliverinjury, A567BR_Comorbidity_Druginducedliverinjury, n568BR_Comorbidity_Druginducedliverinjury_Code, A568BR_Comorbidity_Druginducedliverinjury_Code, A19BR_EncounterID});
                     A37BR_ComorbidityID = BC00098_A37BR_ComorbidityID[0];
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Comorbidity") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
            else
            {
               Load0910( ) ;
            }
            EndLevel0910( ) ;
         }
         CloseExtendedTableCursors0910( ) ;
      }

      protected void Update0910( )
      {
         BeforeValidate0910( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0910( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0910( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0910( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0910( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00099 */
                     pr_default.execute(7, new Object[] {n487BR_Comorbidity_Hypertension_Code, A487BR_Comorbidity_Hypertension_Code, n488BR_Comorbidity_Diabetes_Code, A488BR_Comorbidity_Diabetes_Code, n489BR_Comorbidity_CHD_Code, A489BR_Comorbidity_CHD_Code, n490BR_Comorbidity_Hapetitis_Code, A490BR_Comorbidity_Hapetitis_Code, n491BR_Comorbidity_TB_Code, A491BR_Comorbidity_TB_Code, n492BR_Comorbidity_KidneyDisease_Code, A492BR_Comorbidity_KidneyDisease_Code, n493BR_Comorbidity_SurgeryHistory_Code, A493BR_Comorbidity_SurgeryHistory_Code, n494BR_Comorbidity_InjuryHistory_Code, A494BR_Comorbidity_InjuryHistory_Code, n495BR_Comorbidity_BloodHistory_Code, A495BR_Comorbidity_BloodHistory_Code, n496BR_Comorbidity_allergy_Code, A496BR_Comorbidity_allergy_Code, n38BR_Comorbidity_Hypertension, A38BR_Comorbidity_Hypertension, n39BR_Comorbidity_Diabetes, A39BR_Comorbidity_Diabetes, n40BR_Comorbidity_CHD, A40BR_Comorbidity_CHD, n41BR_Comorbidity_Hapetitis, A41BR_Comorbidity_Hapetitis, n42BR_Comorbidity_TB, A42BR_Comorbidity_TB, n43BR_Comorbidity_KidneyDisease, A43BR_Comorbidity_KidneyDisease, n44BR_Comorbidity_SurgeryHistory, A44BR_Comorbidity_SurgeryHistory, n45BR_Comorbidity_InjuryHistory, A45BR_Comorbidity_InjuryHistory, n46BR_Comorbidity_BloodHistory, A46BR_Comorbidity_BloodHistory, n47BR_Comorbidity_allergy, A47BR_Comorbidity_allergy, n259BR_Comorbidity_Others, A259BR_Comorbidity_Others, n561BR_Comorbidity_HapetitisB, A561BR_Comorbidity_HapetitisB, n562BR_Comorbidity_HapetitisB_Code, A562BR_Comorbidity_HapetitisB_Code, n563BR_Comorbidity_HapetitisC, A563BR_Comorbidity_HapetitisC, n564BR_Comorbidity_HapetitisC_Code, A564BR_Comorbidity_HapetitisC_Code, n565BR_Comorbidity_LiverCirrhosis, A565BR_Comorbidity_LiverCirrhosis, n566BR_Comorbidity_LiverCirrhosis_Code, A566BR_Comorbidity_LiverCirrhosis_Code, n567BR_Comorbidity_Druginducedliverinjury, A567BR_Comorbidity_Druginducedliverinjury, n568BR_Comorbidity_Druginducedliverinjury_Code, A568BR_Comorbidity_Druginducedliverinjury_Code, A19BR_EncounterID, A37BR_ComorbidityID});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Comorbidity") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Comorbidity"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0910( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), "SuccessfullyUpdated", 0, "", true);
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                        AnyError = 1;
                     }
                  }
               }
            }
            EndLevel0910( ) ;
         }
         CloseExtendedTableCursors0910( ) ;
      }

      protected void DeferredUpdate0910( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate0910( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0910( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0910( ) ;
            AfterConfirm0910( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0910( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC000910 */
                  pr_default.execute(8, new Object[] {A37BR_ComorbidityID});
                  pr_default.close(8);
                  dsDefault.SmartCacheProvider.SetUpdated("BR_Comorbidity") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_sucdeleted", ""), "SuccessfullyDeleted", 0, "", true);
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
         }
         sMode10 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel0910( ) ;
         Gx_mode = sMode10;
      }

      protected void OnDeleteControls0910( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor BC000911 */
            pr_default.execute(9, new Object[] {A19BR_EncounterID});
            A85BR_Information_ID = BC000911_A85BR_Information_ID[0];
            n85BR_Information_ID = BC000911_n85BR_Information_ID[0];
            pr_default.close(9);
            /* Using cursor BC000912 */
            pr_default.execute(10, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
            A36BR_Information_PatientNo = BC000912_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = BC000912_n36BR_Information_PatientNo[0];
            pr_default.close(10);
         }
      }

      protected void EndLevel0910( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0910( ) ;
         }
         if ( AnyError == 0 )
         {
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanKeyStart0910( )
      {
         /* Scan By routine */
         /* Using cursor BC000913 */
         pr_default.execute(11, new Object[] {A37BR_ComorbidityID});
         RcdFound10 = 0;
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound10 = 1;
            A85BR_Information_ID = BC000913_A85BR_Information_ID[0];
            n85BR_Information_ID = BC000913_n85BR_Information_ID[0];
            A37BR_ComorbidityID = BC000913_A37BR_ComorbidityID[0];
            A487BR_Comorbidity_Hypertension_Code = BC000913_A487BR_Comorbidity_Hypertension_Code[0];
            n487BR_Comorbidity_Hypertension_Code = BC000913_n487BR_Comorbidity_Hypertension_Code[0];
            A488BR_Comorbidity_Diabetes_Code = BC000913_A488BR_Comorbidity_Diabetes_Code[0];
            n488BR_Comorbidity_Diabetes_Code = BC000913_n488BR_Comorbidity_Diabetes_Code[0];
            A489BR_Comorbidity_CHD_Code = BC000913_A489BR_Comorbidity_CHD_Code[0];
            n489BR_Comorbidity_CHD_Code = BC000913_n489BR_Comorbidity_CHD_Code[0];
            A490BR_Comorbidity_Hapetitis_Code = BC000913_A490BR_Comorbidity_Hapetitis_Code[0];
            n490BR_Comorbidity_Hapetitis_Code = BC000913_n490BR_Comorbidity_Hapetitis_Code[0];
            A491BR_Comorbidity_TB_Code = BC000913_A491BR_Comorbidity_TB_Code[0];
            n491BR_Comorbidity_TB_Code = BC000913_n491BR_Comorbidity_TB_Code[0];
            A492BR_Comorbidity_KidneyDisease_Code = BC000913_A492BR_Comorbidity_KidneyDisease_Code[0];
            n492BR_Comorbidity_KidneyDisease_Code = BC000913_n492BR_Comorbidity_KidneyDisease_Code[0];
            A493BR_Comorbidity_SurgeryHistory_Code = BC000913_A493BR_Comorbidity_SurgeryHistory_Code[0];
            n493BR_Comorbidity_SurgeryHistory_Code = BC000913_n493BR_Comorbidity_SurgeryHistory_Code[0];
            A494BR_Comorbidity_InjuryHistory_Code = BC000913_A494BR_Comorbidity_InjuryHistory_Code[0];
            n494BR_Comorbidity_InjuryHistory_Code = BC000913_n494BR_Comorbidity_InjuryHistory_Code[0];
            A495BR_Comorbidity_BloodHistory_Code = BC000913_A495BR_Comorbidity_BloodHistory_Code[0];
            n495BR_Comorbidity_BloodHistory_Code = BC000913_n495BR_Comorbidity_BloodHistory_Code[0];
            A496BR_Comorbidity_allergy_Code = BC000913_A496BR_Comorbidity_allergy_Code[0];
            n496BR_Comorbidity_allergy_Code = BC000913_n496BR_Comorbidity_allergy_Code[0];
            A36BR_Information_PatientNo = BC000913_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = BC000913_n36BR_Information_PatientNo[0];
            A38BR_Comorbidity_Hypertension = BC000913_A38BR_Comorbidity_Hypertension[0];
            n38BR_Comorbidity_Hypertension = BC000913_n38BR_Comorbidity_Hypertension[0];
            A39BR_Comorbidity_Diabetes = BC000913_A39BR_Comorbidity_Diabetes[0];
            n39BR_Comorbidity_Diabetes = BC000913_n39BR_Comorbidity_Diabetes[0];
            A40BR_Comorbidity_CHD = BC000913_A40BR_Comorbidity_CHD[0];
            n40BR_Comorbidity_CHD = BC000913_n40BR_Comorbidity_CHD[0];
            A41BR_Comorbidity_Hapetitis = BC000913_A41BR_Comorbidity_Hapetitis[0];
            n41BR_Comorbidity_Hapetitis = BC000913_n41BR_Comorbidity_Hapetitis[0];
            A42BR_Comorbidity_TB = BC000913_A42BR_Comorbidity_TB[0];
            n42BR_Comorbidity_TB = BC000913_n42BR_Comorbidity_TB[0];
            A43BR_Comorbidity_KidneyDisease = BC000913_A43BR_Comorbidity_KidneyDisease[0];
            n43BR_Comorbidity_KidneyDisease = BC000913_n43BR_Comorbidity_KidneyDisease[0];
            A44BR_Comorbidity_SurgeryHistory = BC000913_A44BR_Comorbidity_SurgeryHistory[0];
            n44BR_Comorbidity_SurgeryHistory = BC000913_n44BR_Comorbidity_SurgeryHistory[0];
            A45BR_Comorbidity_InjuryHistory = BC000913_A45BR_Comorbidity_InjuryHistory[0];
            n45BR_Comorbidity_InjuryHistory = BC000913_n45BR_Comorbidity_InjuryHistory[0];
            A46BR_Comorbidity_BloodHistory = BC000913_A46BR_Comorbidity_BloodHistory[0];
            n46BR_Comorbidity_BloodHistory = BC000913_n46BR_Comorbidity_BloodHistory[0];
            A47BR_Comorbidity_allergy = BC000913_A47BR_Comorbidity_allergy[0];
            n47BR_Comorbidity_allergy = BC000913_n47BR_Comorbidity_allergy[0];
            A259BR_Comorbidity_Others = BC000913_A259BR_Comorbidity_Others[0];
            n259BR_Comorbidity_Others = BC000913_n259BR_Comorbidity_Others[0];
            A561BR_Comorbidity_HapetitisB = BC000913_A561BR_Comorbidity_HapetitisB[0];
            n561BR_Comorbidity_HapetitisB = BC000913_n561BR_Comorbidity_HapetitisB[0];
            A562BR_Comorbidity_HapetitisB_Code = BC000913_A562BR_Comorbidity_HapetitisB_Code[0];
            n562BR_Comorbidity_HapetitisB_Code = BC000913_n562BR_Comorbidity_HapetitisB_Code[0];
            A563BR_Comorbidity_HapetitisC = BC000913_A563BR_Comorbidity_HapetitisC[0];
            n563BR_Comorbidity_HapetitisC = BC000913_n563BR_Comorbidity_HapetitisC[0];
            A564BR_Comorbidity_HapetitisC_Code = BC000913_A564BR_Comorbidity_HapetitisC_Code[0];
            n564BR_Comorbidity_HapetitisC_Code = BC000913_n564BR_Comorbidity_HapetitisC_Code[0];
            A565BR_Comorbidity_LiverCirrhosis = BC000913_A565BR_Comorbidity_LiverCirrhosis[0];
            n565BR_Comorbidity_LiverCirrhosis = BC000913_n565BR_Comorbidity_LiverCirrhosis[0];
            A566BR_Comorbidity_LiverCirrhosis_Code = BC000913_A566BR_Comorbidity_LiverCirrhosis_Code[0];
            n566BR_Comorbidity_LiverCirrhosis_Code = BC000913_n566BR_Comorbidity_LiverCirrhosis_Code[0];
            A567BR_Comorbidity_Druginducedliverinjury = BC000913_A567BR_Comorbidity_Druginducedliverinjury[0];
            n567BR_Comorbidity_Druginducedliverinjury = BC000913_n567BR_Comorbidity_Druginducedliverinjury[0];
            A568BR_Comorbidity_Druginducedliverinjury_Code = BC000913_A568BR_Comorbidity_Druginducedliverinjury_Code[0];
            n568BR_Comorbidity_Druginducedliverinjury_Code = BC000913_n568BR_Comorbidity_Druginducedliverinjury_Code[0];
            A19BR_EncounterID = BC000913_A19BR_EncounterID[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext0910( )
      {
         /* Scan next routine */
         pr_default.readNext(11);
         RcdFound10 = 0;
         ScanKeyLoad0910( ) ;
      }

      protected void ScanKeyLoad0910( )
      {
         sMode10 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound10 = 1;
            A85BR_Information_ID = BC000913_A85BR_Information_ID[0];
            n85BR_Information_ID = BC000913_n85BR_Information_ID[0];
            A37BR_ComorbidityID = BC000913_A37BR_ComorbidityID[0];
            A487BR_Comorbidity_Hypertension_Code = BC000913_A487BR_Comorbidity_Hypertension_Code[0];
            n487BR_Comorbidity_Hypertension_Code = BC000913_n487BR_Comorbidity_Hypertension_Code[0];
            A488BR_Comorbidity_Diabetes_Code = BC000913_A488BR_Comorbidity_Diabetes_Code[0];
            n488BR_Comorbidity_Diabetes_Code = BC000913_n488BR_Comorbidity_Diabetes_Code[0];
            A489BR_Comorbidity_CHD_Code = BC000913_A489BR_Comorbidity_CHD_Code[0];
            n489BR_Comorbidity_CHD_Code = BC000913_n489BR_Comorbidity_CHD_Code[0];
            A490BR_Comorbidity_Hapetitis_Code = BC000913_A490BR_Comorbidity_Hapetitis_Code[0];
            n490BR_Comorbidity_Hapetitis_Code = BC000913_n490BR_Comorbidity_Hapetitis_Code[0];
            A491BR_Comorbidity_TB_Code = BC000913_A491BR_Comorbidity_TB_Code[0];
            n491BR_Comorbidity_TB_Code = BC000913_n491BR_Comorbidity_TB_Code[0];
            A492BR_Comorbidity_KidneyDisease_Code = BC000913_A492BR_Comorbidity_KidneyDisease_Code[0];
            n492BR_Comorbidity_KidneyDisease_Code = BC000913_n492BR_Comorbidity_KidneyDisease_Code[0];
            A493BR_Comorbidity_SurgeryHistory_Code = BC000913_A493BR_Comorbidity_SurgeryHistory_Code[0];
            n493BR_Comorbidity_SurgeryHistory_Code = BC000913_n493BR_Comorbidity_SurgeryHistory_Code[0];
            A494BR_Comorbidity_InjuryHistory_Code = BC000913_A494BR_Comorbidity_InjuryHistory_Code[0];
            n494BR_Comorbidity_InjuryHistory_Code = BC000913_n494BR_Comorbidity_InjuryHistory_Code[0];
            A495BR_Comorbidity_BloodHistory_Code = BC000913_A495BR_Comorbidity_BloodHistory_Code[0];
            n495BR_Comorbidity_BloodHistory_Code = BC000913_n495BR_Comorbidity_BloodHistory_Code[0];
            A496BR_Comorbidity_allergy_Code = BC000913_A496BR_Comorbidity_allergy_Code[0];
            n496BR_Comorbidity_allergy_Code = BC000913_n496BR_Comorbidity_allergy_Code[0];
            A36BR_Information_PatientNo = BC000913_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = BC000913_n36BR_Information_PatientNo[0];
            A38BR_Comorbidity_Hypertension = BC000913_A38BR_Comorbidity_Hypertension[0];
            n38BR_Comorbidity_Hypertension = BC000913_n38BR_Comorbidity_Hypertension[0];
            A39BR_Comorbidity_Diabetes = BC000913_A39BR_Comorbidity_Diabetes[0];
            n39BR_Comorbidity_Diabetes = BC000913_n39BR_Comorbidity_Diabetes[0];
            A40BR_Comorbidity_CHD = BC000913_A40BR_Comorbidity_CHD[0];
            n40BR_Comorbidity_CHD = BC000913_n40BR_Comorbidity_CHD[0];
            A41BR_Comorbidity_Hapetitis = BC000913_A41BR_Comorbidity_Hapetitis[0];
            n41BR_Comorbidity_Hapetitis = BC000913_n41BR_Comorbidity_Hapetitis[0];
            A42BR_Comorbidity_TB = BC000913_A42BR_Comorbidity_TB[0];
            n42BR_Comorbidity_TB = BC000913_n42BR_Comorbidity_TB[0];
            A43BR_Comorbidity_KidneyDisease = BC000913_A43BR_Comorbidity_KidneyDisease[0];
            n43BR_Comorbidity_KidneyDisease = BC000913_n43BR_Comorbidity_KidneyDisease[0];
            A44BR_Comorbidity_SurgeryHistory = BC000913_A44BR_Comorbidity_SurgeryHistory[0];
            n44BR_Comorbidity_SurgeryHistory = BC000913_n44BR_Comorbidity_SurgeryHistory[0];
            A45BR_Comorbidity_InjuryHistory = BC000913_A45BR_Comorbidity_InjuryHistory[0];
            n45BR_Comorbidity_InjuryHistory = BC000913_n45BR_Comorbidity_InjuryHistory[0];
            A46BR_Comorbidity_BloodHistory = BC000913_A46BR_Comorbidity_BloodHistory[0];
            n46BR_Comorbidity_BloodHistory = BC000913_n46BR_Comorbidity_BloodHistory[0];
            A47BR_Comorbidity_allergy = BC000913_A47BR_Comorbidity_allergy[0];
            n47BR_Comorbidity_allergy = BC000913_n47BR_Comorbidity_allergy[0];
            A259BR_Comorbidity_Others = BC000913_A259BR_Comorbidity_Others[0];
            n259BR_Comorbidity_Others = BC000913_n259BR_Comorbidity_Others[0];
            A561BR_Comorbidity_HapetitisB = BC000913_A561BR_Comorbidity_HapetitisB[0];
            n561BR_Comorbidity_HapetitisB = BC000913_n561BR_Comorbidity_HapetitisB[0];
            A562BR_Comorbidity_HapetitisB_Code = BC000913_A562BR_Comorbidity_HapetitisB_Code[0];
            n562BR_Comorbidity_HapetitisB_Code = BC000913_n562BR_Comorbidity_HapetitisB_Code[0];
            A563BR_Comorbidity_HapetitisC = BC000913_A563BR_Comorbidity_HapetitisC[0];
            n563BR_Comorbidity_HapetitisC = BC000913_n563BR_Comorbidity_HapetitisC[0];
            A564BR_Comorbidity_HapetitisC_Code = BC000913_A564BR_Comorbidity_HapetitisC_Code[0];
            n564BR_Comorbidity_HapetitisC_Code = BC000913_n564BR_Comorbidity_HapetitisC_Code[0];
            A565BR_Comorbidity_LiverCirrhosis = BC000913_A565BR_Comorbidity_LiverCirrhosis[0];
            n565BR_Comorbidity_LiverCirrhosis = BC000913_n565BR_Comorbidity_LiverCirrhosis[0];
            A566BR_Comorbidity_LiverCirrhosis_Code = BC000913_A566BR_Comorbidity_LiverCirrhosis_Code[0];
            n566BR_Comorbidity_LiverCirrhosis_Code = BC000913_n566BR_Comorbidity_LiverCirrhosis_Code[0];
            A567BR_Comorbidity_Druginducedliverinjury = BC000913_A567BR_Comorbidity_Druginducedliverinjury[0];
            n567BR_Comorbidity_Druginducedliverinjury = BC000913_n567BR_Comorbidity_Druginducedliverinjury[0];
            A568BR_Comorbidity_Druginducedliverinjury_Code = BC000913_A568BR_Comorbidity_Druginducedliverinjury_Code[0];
            n568BR_Comorbidity_Druginducedliverinjury_Code = BC000913_n568BR_Comorbidity_Druginducedliverinjury_Code[0];
            A19BR_EncounterID = BC000913_A19BR_EncounterID[0];
         }
         Gx_mode = sMode10;
      }

      protected void ScanKeyEnd0910( )
      {
         pr_default.close(11);
      }

      protected void AfterConfirm0910( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0910( )
      {
         /* Before Insert Rules */
         GXt_char1 = A487BR_Comorbidity_Hypertension_Code;
         new zutil_findtargetcode(context ).execute(  37,  A38BR_Comorbidity_Hypertension, out  GXt_char1) ;
         A487BR_Comorbidity_Hypertension_Code = GXt_char1;
         n487BR_Comorbidity_Hypertension_Code = false;
         GXt_char1 = A488BR_Comorbidity_Diabetes_Code;
         new zutil_findtargetcode(context ).execute(  37,  A39BR_Comorbidity_Diabetes, out  GXt_char1) ;
         A488BR_Comorbidity_Diabetes_Code = GXt_char1;
         n488BR_Comorbidity_Diabetes_Code = false;
         GXt_char1 = A489BR_Comorbidity_CHD_Code;
         new zutil_findtargetcode(context ).execute(  37,  A40BR_Comorbidity_CHD, out  GXt_char1) ;
         A489BR_Comorbidity_CHD_Code = GXt_char1;
         n489BR_Comorbidity_CHD_Code = false;
         GXt_char1 = A490BR_Comorbidity_Hapetitis_Code;
         new zutil_findtargetcode(context ).execute(  37,  A41BR_Comorbidity_Hapetitis, out  GXt_char1) ;
         A490BR_Comorbidity_Hapetitis_Code = GXt_char1;
         n490BR_Comorbidity_Hapetitis_Code = false;
         GXt_char1 = A491BR_Comorbidity_TB_Code;
         new zutil_findtargetcode(context ).execute(  37,  A42BR_Comorbidity_TB, out  GXt_char1) ;
         A491BR_Comorbidity_TB_Code = GXt_char1;
         n491BR_Comorbidity_TB_Code = false;
         GXt_char1 = A492BR_Comorbidity_KidneyDisease_Code;
         new zutil_findtargetcode(context ).execute(  37,  A43BR_Comorbidity_KidneyDisease, out  GXt_char1) ;
         A492BR_Comorbidity_KidneyDisease_Code = GXt_char1;
         n492BR_Comorbidity_KidneyDisease_Code = false;
         GXt_char1 = A493BR_Comorbidity_SurgeryHistory_Code;
         new zutil_findtargetcode(context ).execute(  37,  A44BR_Comorbidity_SurgeryHistory, out  GXt_char1) ;
         A493BR_Comorbidity_SurgeryHistory_Code = GXt_char1;
         n493BR_Comorbidity_SurgeryHistory_Code = false;
         GXt_char1 = A494BR_Comorbidity_InjuryHistory_Code;
         new zutil_findtargetcode(context ).execute(  37,  A45BR_Comorbidity_InjuryHistory, out  GXt_char1) ;
         A494BR_Comorbidity_InjuryHistory_Code = GXt_char1;
         n494BR_Comorbidity_InjuryHistory_Code = false;
         GXt_char1 = A495BR_Comorbidity_BloodHistory_Code;
         new zutil_findtargetcode(context ).execute(  37,  A46BR_Comorbidity_BloodHistory, out  GXt_char1) ;
         A495BR_Comorbidity_BloodHistory_Code = GXt_char1;
         n495BR_Comorbidity_BloodHistory_Code = false;
         GXt_char1 = A496BR_Comorbidity_allergy_Code;
         new zutil_findtargetcode(context ).execute(  37,  A47BR_Comorbidity_allergy, out  GXt_char1) ;
         A496BR_Comorbidity_allergy_Code = GXt_char1;
         n496BR_Comorbidity_allergy_Code = false;
      }

      protected void BeforeUpdate0910( )
      {
         /* Before Update Rules */
         GXt_char1 = A487BR_Comorbidity_Hypertension_Code;
         new zutil_findtargetcode(context ).execute(  37,  A38BR_Comorbidity_Hypertension, out  GXt_char1) ;
         A487BR_Comorbidity_Hypertension_Code = GXt_char1;
         n487BR_Comorbidity_Hypertension_Code = false;
         GXt_char1 = A488BR_Comorbidity_Diabetes_Code;
         new zutil_findtargetcode(context ).execute(  37,  A39BR_Comorbidity_Diabetes, out  GXt_char1) ;
         A488BR_Comorbidity_Diabetes_Code = GXt_char1;
         n488BR_Comorbidity_Diabetes_Code = false;
         GXt_char1 = A489BR_Comorbidity_CHD_Code;
         new zutil_findtargetcode(context ).execute(  37,  A40BR_Comorbidity_CHD, out  GXt_char1) ;
         A489BR_Comorbidity_CHD_Code = GXt_char1;
         n489BR_Comorbidity_CHD_Code = false;
         GXt_char1 = A490BR_Comorbidity_Hapetitis_Code;
         new zutil_findtargetcode(context ).execute(  37,  A41BR_Comorbidity_Hapetitis, out  GXt_char1) ;
         A490BR_Comorbidity_Hapetitis_Code = GXt_char1;
         n490BR_Comorbidity_Hapetitis_Code = false;
         GXt_char1 = A491BR_Comorbidity_TB_Code;
         new zutil_findtargetcode(context ).execute(  37,  A42BR_Comorbidity_TB, out  GXt_char1) ;
         A491BR_Comorbidity_TB_Code = GXt_char1;
         n491BR_Comorbidity_TB_Code = false;
         GXt_char1 = A492BR_Comorbidity_KidneyDisease_Code;
         new zutil_findtargetcode(context ).execute(  37,  A43BR_Comorbidity_KidneyDisease, out  GXt_char1) ;
         A492BR_Comorbidity_KidneyDisease_Code = GXt_char1;
         n492BR_Comorbidity_KidneyDisease_Code = false;
         GXt_char1 = A493BR_Comorbidity_SurgeryHistory_Code;
         new zutil_findtargetcode(context ).execute(  37,  A44BR_Comorbidity_SurgeryHistory, out  GXt_char1) ;
         A493BR_Comorbidity_SurgeryHistory_Code = GXt_char1;
         n493BR_Comorbidity_SurgeryHistory_Code = false;
         GXt_char1 = A494BR_Comorbidity_InjuryHistory_Code;
         new zutil_findtargetcode(context ).execute(  37,  A45BR_Comorbidity_InjuryHistory, out  GXt_char1) ;
         A494BR_Comorbidity_InjuryHistory_Code = GXt_char1;
         n494BR_Comorbidity_InjuryHistory_Code = false;
         GXt_char1 = A495BR_Comorbidity_BloodHistory_Code;
         new zutil_findtargetcode(context ).execute(  37,  A46BR_Comorbidity_BloodHistory, out  GXt_char1) ;
         A495BR_Comorbidity_BloodHistory_Code = GXt_char1;
         n495BR_Comorbidity_BloodHistory_Code = false;
         GXt_char1 = A496BR_Comorbidity_allergy_Code;
         new zutil_findtargetcode(context ).execute(  37,  A47BR_Comorbidity_allergy, out  GXt_char1) ;
         A496BR_Comorbidity_allergy_Code = GXt_char1;
         n496BR_Comorbidity_allergy_Code = false;
      }

      protected void BeforeDelete0910( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0910( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0910( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0910( )
      {
      }

      protected void send_integrity_lvl_hashes0910( )
      {
      }

      protected void AddRow0910( )
      {
         VarsToRow10( bcBR_Comorbidity) ;
      }

      protected void ReadRow0910( )
      {
         RowToVars10( bcBR_Comorbidity, 1) ;
      }

      protected void InitializeNonKey0910( )
      {
         A85BR_Information_ID = 0;
         n85BR_Information_ID = false;
         A487BR_Comorbidity_Hypertension_Code = "";
         n487BR_Comorbidity_Hypertension_Code = false;
         A488BR_Comorbidity_Diabetes_Code = "";
         n488BR_Comorbidity_Diabetes_Code = false;
         A489BR_Comorbidity_CHD_Code = "";
         n489BR_Comorbidity_CHD_Code = false;
         A490BR_Comorbidity_Hapetitis_Code = "";
         n490BR_Comorbidity_Hapetitis_Code = false;
         A491BR_Comorbidity_TB_Code = "";
         n491BR_Comorbidity_TB_Code = false;
         A492BR_Comorbidity_KidneyDisease_Code = "";
         n492BR_Comorbidity_KidneyDisease_Code = false;
         A493BR_Comorbidity_SurgeryHistory_Code = "";
         n493BR_Comorbidity_SurgeryHistory_Code = false;
         A494BR_Comorbidity_InjuryHistory_Code = "";
         n494BR_Comorbidity_InjuryHistory_Code = false;
         A495BR_Comorbidity_BloodHistory_Code = "";
         n495BR_Comorbidity_BloodHistory_Code = false;
         A496BR_Comorbidity_allergy_Code = "";
         n496BR_Comorbidity_allergy_Code = false;
         A19BR_EncounterID = 0;
         A36BR_Information_PatientNo = "";
         n36BR_Information_PatientNo = false;
         A38BR_Comorbidity_Hypertension = "";
         n38BR_Comorbidity_Hypertension = false;
         A39BR_Comorbidity_Diabetes = "";
         n39BR_Comorbidity_Diabetes = false;
         A40BR_Comorbidity_CHD = "";
         n40BR_Comorbidity_CHD = false;
         A41BR_Comorbidity_Hapetitis = "";
         n41BR_Comorbidity_Hapetitis = false;
         A42BR_Comorbidity_TB = "";
         n42BR_Comorbidity_TB = false;
         A43BR_Comorbidity_KidneyDisease = "";
         n43BR_Comorbidity_KidneyDisease = false;
         A44BR_Comorbidity_SurgeryHistory = "";
         n44BR_Comorbidity_SurgeryHistory = false;
         A45BR_Comorbidity_InjuryHistory = "";
         n45BR_Comorbidity_InjuryHistory = false;
         A46BR_Comorbidity_BloodHistory = "";
         n46BR_Comorbidity_BloodHistory = false;
         A47BR_Comorbidity_allergy = "";
         n47BR_Comorbidity_allergy = false;
         A259BR_Comorbidity_Others = "";
         n259BR_Comorbidity_Others = false;
         A561BR_Comorbidity_HapetitisB = "";
         n561BR_Comorbidity_HapetitisB = false;
         A562BR_Comorbidity_HapetitisB_Code = "";
         n562BR_Comorbidity_HapetitisB_Code = false;
         A563BR_Comorbidity_HapetitisC = "";
         n563BR_Comorbidity_HapetitisC = false;
         A564BR_Comorbidity_HapetitisC_Code = "";
         n564BR_Comorbidity_HapetitisC_Code = false;
         A565BR_Comorbidity_LiverCirrhosis = "";
         n565BR_Comorbidity_LiverCirrhosis = false;
         A566BR_Comorbidity_LiverCirrhosis_Code = "";
         n566BR_Comorbidity_LiverCirrhosis_Code = false;
         A567BR_Comorbidity_Druginducedliverinjury = "";
         n567BR_Comorbidity_Druginducedliverinjury = false;
         A568BR_Comorbidity_Druginducedliverinjury_Code = "";
         n568BR_Comorbidity_Druginducedliverinjury_Code = false;
         Z487BR_Comorbidity_Hypertension_Code = "";
         Z488BR_Comorbidity_Diabetes_Code = "";
         Z489BR_Comorbidity_CHD_Code = "";
         Z490BR_Comorbidity_Hapetitis_Code = "";
         Z491BR_Comorbidity_TB_Code = "";
         Z492BR_Comorbidity_KidneyDisease_Code = "";
         Z493BR_Comorbidity_SurgeryHistory_Code = "";
         Z494BR_Comorbidity_InjuryHistory_Code = "";
         Z495BR_Comorbidity_BloodHistory_Code = "";
         Z496BR_Comorbidity_allergy_Code = "";
         Z38BR_Comorbidity_Hypertension = "";
         Z39BR_Comorbidity_Diabetes = "";
         Z40BR_Comorbidity_CHD = "";
         Z41BR_Comorbidity_Hapetitis = "";
         Z42BR_Comorbidity_TB = "";
         Z43BR_Comorbidity_KidneyDisease = "";
         Z44BR_Comorbidity_SurgeryHistory = "";
         Z45BR_Comorbidity_InjuryHistory = "";
         Z46BR_Comorbidity_BloodHistory = "";
         Z47BR_Comorbidity_allergy = "";
         Z259BR_Comorbidity_Others = "";
         Z561BR_Comorbidity_HapetitisB = "";
         Z562BR_Comorbidity_HapetitisB_Code = "";
         Z563BR_Comorbidity_HapetitisC = "";
         Z564BR_Comorbidity_HapetitisC_Code = "";
         Z565BR_Comorbidity_LiverCirrhosis = "";
         Z566BR_Comorbidity_LiverCirrhosis_Code = "";
         Z567BR_Comorbidity_Druginducedliverinjury = "";
         Z568BR_Comorbidity_Druginducedliverinjury_Code = "";
         Z19BR_EncounterID = 0;
      }

      protected void InitAll0910( )
      {
         A37BR_ComorbidityID = 0;
         InitializeNonKey0910( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow10( SdtBR_Comorbidity obj10 )
      {
         obj10.gxTpr_Mode = Gx_mode;
         obj10.gxTpr_Br_comorbidity_hypertension_code = A487BR_Comorbidity_Hypertension_Code;
         obj10.gxTpr_Br_comorbidity_diabetes_code = A488BR_Comorbidity_Diabetes_Code;
         obj10.gxTpr_Br_comorbidity_chd_code = A489BR_Comorbidity_CHD_Code;
         obj10.gxTpr_Br_comorbidity_hapetitis_code = A490BR_Comorbidity_Hapetitis_Code;
         obj10.gxTpr_Br_comorbidity_tb_code = A491BR_Comorbidity_TB_Code;
         obj10.gxTpr_Br_comorbidity_kidneydisease_code = A492BR_Comorbidity_KidneyDisease_Code;
         obj10.gxTpr_Br_comorbidity_surgeryhistory_code = A493BR_Comorbidity_SurgeryHistory_Code;
         obj10.gxTpr_Br_comorbidity_injuryhistory_code = A494BR_Comorbidity_InjuryHistory_Code;
         obj10.gxTpr_Br_comorbidity_bloodhistory_code = A495BR_Comorbidity_BloodHistory_Code;
         obj10.gxTpr_Br_comorbidity_allergy_code = A496BR_Comorbidity_allergy_Code;
         obj10.gxTpr_Br_encounterid = A19BR_EncounterID;
         obj10.gxTpr_Br_information_patientno = A36BR_Information_PatientNo;
         obj10.gxTpr_Br_comorbidity_hypertension = A38BR_Comorbidity_Hypertension;
         obj10.gxTpr_Br_comorbidity_diabetes = A39BR_Comorbidity_Diabetes;
         obj10.gxTpr_Br_comorbidity_chd = A40BR_Comorbidity_CHD;
         obj10.gxTpr_Br_comorbidity_hapetitis = A41BR_Comorbidity_Hapetitis;
         obj10.gxTpr_Br_comorbidity_tb = A42BR_Comorbidity_TB;
         obj10.gxTpr_Br_comorbidity_kidneydisease = A43BR_Comorbidity_KidneyDisease;
         obj10.gxTpr_Br_comorbidity_surgeryhistory = A44BR_Comorbidity_SurgeryHistory;
         obj10.gxTpr_Br_comorbidity_injuryhistory = A45BR_Comorbidity_InjuryHistory;
         obj10.gxTpr_Br_comorbidity_bloodhistory = A46BR_Comorbidity_BloodHistory;
         obj10.gxTpr_Br_comorbidity_allergy = A47BR_Comorbidity_allergy;
         obj10.gxTpr_Br_comorbidity_others = A259BR_Comorbidity_Others;
         obj10.gxTpr_Br_comorbidity_hapetitisb = A561BR_Comorbidity_HapetitisB;
         obj10.gxTpr_Br_comorbidity_hapetitisb_code = A562BR_Comorbidity_HapetitisB_Code;
         obj10.gxTpr_Br_comorbidity_hapetitisc = A563BR_Comorbidity_HapetitisC;
         obj10.gxTpr_Br_comorbidity_hapetitisc_code = A564BR_Comorbidity_HapetitisC_Code;
         obj10.gxTpr_Br_comorbidity_livercirrhosis = A565BR_Comorbidity_LiverCirrhosis;
         obj10.gxTpr_Br_comorbidity_livercirrhosis_code = A566BR_Comorbidity_LiverCirrhosis_Code;
         obj10.gxTpr_Br_comorbidity_druginducedliverinjury = A567BR_Comorbidity_Druginducedliverinjury;
         obj10.gxTpr_Br_comorbidity_druginducedliverinjury_code = A568BR_Comorbidity_Druginducedliverinjury_Code;
         obj10.gxTpr_Br_comorbidityid = A37BR_ComorbidityID;
         obj10.gxTpr_Br_comorbidityid_Z = Z37BR_ComorbidityID;
         obj10.gxTpr_Br_encounterid_Z = Z19BR_EncounterID;
         obj10.gxTpr_Br_information_patientno_Z = Z36BR_Information_PatientNo;
         obj10.gxTpr_Br_comorbidity_hypertension_Z = Z38BR_Comorbidity_Hypertension;
         obj10.gxTpr_Br_comorbidity_hypertension_code_Z = Z487BR_Comorbidity_Hypertension_Code;
         obj10.gxTpr_Br_comorbidity_diabetes_Z = Z39BR_Comorbidity_Diabetes;
         obj10.gxTpr_Br_comorbidity_diabetes_code_Z = Z488BR_Comorbidity_Diabetes_Code;
         obj10.gxTpr_Br_comorbidity_chd_Z = Z40BR_Comorbidity_CHD;
         obj10.gxTpr_Br_comorbidity_chd_code_Z = Z489BR_Comorbidity_CHD_Code;
         obj10.gxTpr_Br_comorbidity_hapetitis_Z = Z41BR_Comorbidity_Hapetitis;
         obj10.gxTpr_Br_comorbidity_hapetitis_code_Z = Z490BR_Comorbidity_Hapetitis_Code;
         obj10.gxTpr_Br_comorbidity_tb_Z = Z42BR_Comorbidity_TB;
         obj10.gxTpr_Br_comorbidity_tb_code_Z = Z491BR_Comorbidity_TB_Code;
         obj10.gxTpr_Br_comorbidity_kidneydisease_Z = Z43BR_Comorbidity_KidneyDisease;
         obj10.gxTpr_Br_comorbidity_kidneydisease_code_Z = Z492BR_Comorbidity_KidneyDisease_Code;
         obj10.gxTpr_Br_comorbidity_surgeryhistory_Z = Z44BR_Comorbidity_SurgeryHistory;
         obj10.gxTpr_Br_comorbidity_surgeryhistory_code_Z = Z493BR_Comorbidity_SurgeryHistory_Code;
         obj10.gxTpr_Br_comorbidity_injuryhistory_Z = Z45BR_Comorbidity_InjuryHistory;
         obj10.gxTpr_Br_comorbidity_injuryhistory_code_Z = Z494BR_Comorbidity_InjuryHistory_Code;
         obj10.gxTpr_Br_comorbidity_bloodhistory_Z = Z46BR_Comorbidity_BloodHistory;
         obj10.gxTpr_Br_comorbidity_bloodhistory_code_Z = Z495BR_Comorbidity_BloodHistory_Code;
         obj10.gxTpr_Br_comorbidity_allergy_Z = Z47BR_Comorbidity_allergy;
         obj10.gxTpr_Br_comorbidity_allergy_code_Z = Z496BR_Comorbidity_allergy_Code;
         obj10.gxTpr_Br_comorbidity_others_Z = Z259BR_Comorbidity_Others;
         obj10.gxTpr_Br_comorbidity_hapetitisb_Z = Z561BR_Comorbidity_HapetitisB;
         obj10.gxTpr_Br_comorbidity_hapetitisb_code_Z = Z562BR_Comorbidity_HapetitisB_Code;
         obj10.gxTpr_Br_comorbidity_hapetitisc_Z = Z563BR_Comorbidity_HapetitisC;
         obj10.gxTpr_Br_comorbidity_hapetitisc_code_Z = Z564BR_Comorbidity_HapetitisC_Code;
         obj10.gxTpr_Br_comorbidity_livercirrhosis_Z = Z565BR_Comorbidity_LiverCirrhosis;
         obj10.gxTpr_Br_comorbidity_livercirrhosis_code_Z = Z566BR_Comorbidity_LiverCirrhosis_Code;
         obj10.gxTpr_Br_comorbidity_druginducedliverinjury_Z = Z567BR_Comorbidity_Druginducedliverinjury;
         obj10.gxTpr_Br_comorbidity_druginducedliverinjury_code_Z = Z568BR_Comorbidity_Druginducedliverinjury_Code;
         obj10.gxTpr_Br_information_patientno_N = (short)(Convert.ToInt16(n36BR_Information_PatientNo));
         obj10.gxTpr_Br_comorbidity_hypertension_N = (short)(Convert.ToInt16(n38BR_Comorbidity_Hypertension));
         obj10.gxTpr_Br_comorbidity_hypertension_code_N = (short)(Convert.ToInt16(n487BR_Comorbidity_Hypertension_Code));
         obj10.gxTpr_Br_comorbidity_diabetes_N = (short)(Convert.ToInt16(n39BR_Comorbidity_Diabetes));
         obj10.gxTpr_Br_comorbidity_diabetes_code_N = (short)(Convert.ToInt16(n488BR_Comorbidity_Diabetes_Code));
         obj10.gxTpr_Br_comorbidity_chd_N = (short)(Convert.ToInt16(n40BR_Comorbidity_CHD));
         obj10.gxTpr_Br_comorbidity_chd_code_N = (short)(Convert.ToInt16(n489BR_Comorbidity_CHD_Code));
         obj10.gxTpr_Br_comorbidity_hapetitis_N = (short)(Convert.ToInt16(n41BR_Comorbidity_Hapetitis));
         obj10.gxTpr_Br_comorbidity_hapetitis_code_N = (short)(Convert.ToInt16(n490BR_Comorbidity_Hapetitis_Code));
         obj10.gxTpr_Br_comorbidity_tb_N = (short)(Convert.ToInt16(n42BR_Comorbidity_TB));
         obj10.gxTpr_Br_comorbidity_tb_code_N = (short)(Convert.ToInt16(n491BR_Comorbidity_TB_Code));
         obj10.gxTpr_Br_comorbidity_kidneydisease_N = (short)(Convert.ToInt16(n43BR_Comorbidity_KidneyDisease));
         obj10.gxTpr_Br_comorbidity_kidneydisease_code_N = (short)(Convert.ToInt16(n492BR_Comorbidity_KidneyDisease_Code));
         obj10.gxTpr_Br_comorbidity_surgeryhistory_N = (short)(Convert.ToInt16(n44BR_Comorbidity_SurgeryHistory));
         obj10.gxTpr_Br_comorbidity_surgeryhistory_code_N = (short)(Convert.ToInt16(n493BR_Comorbidity_SurgeryHistory_Code));
         obj10.gxTpr_Br_comorbidity_injuryhistory_N = (short)(Convert.ToInt16(n45BR_Comorbidity_InjuryHistory));
         obj10.gxTpr_Br_comorbidity_injuryhistory_code_N = (short)(Convert.ToInt16(n494BR_Comorbidity_InjuryHistory_Code));
         obj10.gxTpr_Br_comorbidity_bloodhistory_N = (short)(Convert.ToInt16(n46BR_Comorbidity_BloodHistory));
         obj10.gxTpr_Br_comorbidity_bloodhistory_code_N = (short)(Convert.ToInt16(n495BR_Comorbidity_BloodHistory_Code));
         obj10.gxTpr_Br_comorbidity_allergy_N = (short)(Convert.ToInt16(n47BR_Comorbidity_allergy));
         obj10.gxTpr_Br_comorbidity_allergy_code_N = (short)(Convert.ToInt16(n496BR_Comorbidity_allergy_Code));
         obj10.gxTpr_Br_comorbidity_others_N = (short)(Convert.ToInt16(n259BR_Comorbidity_Others));
         obj10.gxTpr_Br_comorbidity_hapetitisb_N = (short)(Convert.ToInt16(n561BR_Comorbidity_HapetitisB));
         obj10.gxTpr_Br_comorbidity_hapetitisb_code_N = (short)(Convert.ToInt16(n562BR_Comorbidity_HapetitisB_Code));
         obj10.gxTpr_Br_comorbidity_hapetitisc_N = (short)(Convert.ToInt16(n563BR_Comorbidity_HapetitisC));
         obj10.gxTpr_Br_comorbidity_hapetitisc_code_N = (short)(Convert.ToInt16(n564BR_Comorbidity_HapetitisC_Code));
         obj10.gxTpr_Br_comorbidity_livercirrhosis_N = (short)(Convert.ToInt16(n565BR_Comorbidity_LiverCirrhosis));
         obj10.gxTpr_Br_comorbidity_livercirrhosis_code_N = (short)(Convert.ToInt16(n566BR_Comorbidity_LiverCirrhosis_Code));
         obj10.gxTpr_Br_comorbidity_druginducedliverinjury_N = (short)(Convert.ToInt16(n567BR_Comorbidity_Druginducedliverinjury));
         obj10.gxTpr_Br_comorbidity_druginducedliverinjury_code_N = (short)(Convert.ToInt16(n568BR_Comorbidity_Druginducedliverinjury_Code));
         obj10.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow10( SdtBR_Comorbidity obj10 )
      {
         obj10.gxTpr_Br_comorbidityid = A37BR_ComorbidityID;
         return  ;
      }

      public void RowToVars10( SdtBR_Comorbidity obj10 ,
                               int forceLoad )
      {
         Gx_mode = obj10.gxTpr_Mode;
         A487BR_Comorbidity_Hypertension_Code = obj10.gxTpr_Br_comorbidity_hypertension_code;
         n487BR_Comorbidity_Hypertension_Code = false;
         A488BR_Comorbidity_Diabetes_Code = obj10.gxTpr_Br_comorbidity_diabetes_code;
         n488BR_Comorbidity_Diabetes_Code = false;
         A489BR_Comorbidity_CHD_Code = obj10.gxTpr_Br_comorbidity_chd_code;
         n489BR_Comorbidity_CHD_Code = false;
         A490BR_Comorbidity_Hapetitis_Code = obj10.gxTpr_Br_comorbidity_hapetitis_code;
         n490BR_Comorbidity_Hapetitis_Code = false;
         A491BR_Comorbidity_TB_Code = obj10.gxTpr_Br_comorbidity_tb_code;
         n491BR_Comorbidity_TB_Code = false;
         A492BR_Comorbidity_KidneyDisease_Code = obj10.gxTpr_Br_comorbidity_kidneydisease_code;
         n492BR_Comorbidity_KidneyDisease_Code = false;
         A493BR_Comorbidity_SurgeryHistory_Code = obj10.gxTpr_Br_comorbidity_surgeryhistory_code;
         n493BR_Comorbidity_SurgeryHistory_Code = false;
         A494BR_Comorbidity_InjuryHistory_Code = obj10.gxTpr_Br_comorbidity_injuryhistory_code;
         n494BR_Comorbidity_InjuryHistory_Code = false;
         A495BR_Comorbidity_BloodHistory_Code = obj10.gxTpr_Br_comorbidity_bloodhistory_code;
         n495BR_Comorbidity_BloodHistory_Code = false;
         A496BR_Comorbidity_allergy_Code = obj10.gxTpr_Br_comorbidity_allergy_code;
         n496BR_Comorbidity_allergy_Code = false;
         A19BR_EncounterID = obj10.gxTpr_Br_encounterid;
         A36BR_Information_PatientNo = obj10.gxTpr_Br_information_patientno;
         n36BR_Information_PatientNo = false;
         A38BR_Comorbidity_Hypertension = obj10.gxTpr_Br_comorbidity_hypertension;
         n38BR_Comorbidity_Hypertension = false;
         A39BR_Comorbidity_Diabetes = obj10.gxTpr_Br_comorbidity_diabetes;
         n39BR_Comorbidity_Diabetes = false;
         A40BR_Comorbidity_CHD = obj10.gxTpr_Br_comorbidity_chd;
         n40BR_Comorbidity_CHD = false;
         A41BR_Comorbidity_Hapetitis = obj10.gxTpr_Br_comorbidity_hapetitis;
         n41BR_Comorbidity_Hapetitis = false;
         A42BR_Comorbidity_TB = obj10.gxTpr_Br_comorbidity_tb;
         n42BR_Comorbidity_TB = false;
         A43BR_Comorbidity_KidneyDisease = obj10.gxTpr_Br_comorbidity_kidneydisease;
         n43BR_Comorbidity_KidneyDisease = false;
         A44BR_Comorbidity_SurgeryHistory = obj10.gxTpr_Br_comorbidity_surgeryhistory;
         n44BR_Comorbidity_SurgeryHistory = false;
         A45BR_Comorbidity_InjuryHistory = obj10.gxTpr_Br_comorbidity_injuryhistory;
         n45BR_Comorbidity_InjuryHistory = false;
         A46BR_Comorbidity_BloodHistory = obj10.gxTpr_Br_comorbidity_bloodhistory;
         n46BR_Comorbidity_BloodHistory = false;
         A47BR_Comorbidity_allergy = obj10.gxTpr_Br_comorbidity_allergy;
         n47BR_Comorbidity_allergy = false;
         A259BR_Comorbidity_Others = obj10.gxTpr_Br_comorbidity_others;
         n259BR_Comorbidity_Others = false;
         A561BR_Comorbidity_HapetitisB = obj10.gxTpr_Br_comorbidity_hapetitisb;
         n561BR_Comorbidity_HapetitisB = false;
         A562BR_Comorbidity_HapetitisB_Code = obj10.gxTpr_Br_comorbidity_hapetitisb_code;
         n562BR_Comorbidity_HapetitisB_Code = false;
         A563BR_Comorbidity_HapetitisC = obj10.gxTpr_Br_comorbidity_hapetitisc;
         n563BR_Comorbidity_HapetitisC = false;
         A564BR_Comorbidity_HapetitisC_Code = obj10.gxTpr_Br_comorbidity_hapetitisc_code;
         n564BR_Comorbidity_HapetitisC_Code = false;
         A565BR_Comorbidity_LiverCirrhosis = obj10.gxTpr_Br_comorbidity_livercirrhosis;
         n565BR_Comorbidity_LiverCirrhosis = false;
         A566BR_Comorbidity_LiverCirrhosis_Code = obj10.gxTpr_Br_comorbidity_livercirrhosis_code;
         n566BR_Comorbidity_LiverCirrhosis_Code = false;
         A567BR_Comorbidity_Druginducedliverinjury = obj10.gxTpr_Br_comorbidity_druginducedliverinjury;
         n567BR_Comorbidity_Druginducedliverinjury = false;
         A568BR_Comorbidity_Druginducedliverinjury_Code = obj10.gxTpr_Br_comorbidity_druginducedliverinjury_code;
         n568BR_Comorbidity_Druginducedliverinjury_Code = false;
         A37BR_ComorbidityID = obj10.gxTpr_Br_comorbidityid;
         Z37BR_ComorbidityID = obj10.gxTpr_Br_comorbidityid_Z;
         Z19BR_EncounterID = obj10.gxTpr_Br_encounterid_Z;
         Z36BR_Information_PatientNo = obj10.gxTpr_Br_information_patientno_Z;
         Z38BR_Comorbidity_Hypertension = obj10.gxTpr_Br_comorbidity_hypertension_Z;
         Z487BR_Comorbidity_Hypertension_Code = obj10.gxTpr_Br_comorbidity_hypertension_code_Z;
         Z39BR_Comorbidity_Diabetes = obj10.gxTpr_Br_comorbidity_diabetes_Z;
         Z488BR_Comorbidity_Diabetes_Code = obj10.gxTpr_Br_comorbidity_diabetes_code_Z;
         Z40BR_Comorbidity_CHD = obj10.gxTpr_Br_comorbidity_chd_Z;
         Z489BR_Comorbidity_CHD_Code = obj10.gxTpr_Br_comorbidity_chd_code_Z;
         Z41BR_Comorbidity_Hapetitis = obj10.gxTpr_Br_comorbidity_hapetitis_Z;
         Z490BR_Comorbidity_Hapetitis_Code = obj10.gxTpr_Br_comorbidity_hapetitis_code_Z;
         Z42BR_Comorbidity_TB = obj10.gxTpr_Br_comorbidity_tb_Z;
         Z491BR_Comorbidity_TB_Code = obj10.gxTpr_Br_comorbidity_tb_code_Z;
         Z43BR_Comorbidity_KidneyDisease = obj10.gxTpr_Br_comorbidity_kidneydisease_Z;
         Z492BR_Comorbidity_KidneyDisease_Code = obj10.gxTpr_Br_comorbidity_kidneydisease_code_Z;
         Z44BR_Comorbidity_SurgeryHistory = obj10.gxTpr_Br_comorbidity_surgeryhistory_Z;
         Z493BR_Comorbidity_SurgeryHistory_Code = obj10.gxTpr_Br_comorbidity_surgeryhistory_code_Z;
         Z45BR_Comorbidity_InjuryHistory = obj10.gxTpr_Br_comorbidity_injuryhistory_Z;
         Z494BR_Comorbidity_InjuryHistory_Code = obj10.gxTpr_Br_comorbidity_injuryhistory_code_Z;
         Z46BR_Comorbidity_BloodHistory = obj10.gxTpr_Br_comorbidity_bloodhistory_Z;
         Z495BR_Comorbidity_BloodHistory_Code = obj10.gxTpr_Br_comorbidity_bloodhistory_code_Z;
         Z47BR_Comorbidity_allergy = obj10.gxTpr_Br_comorbidity_allergy_Z;
         Z496BR_Comorbidity_allergy_Code = obj10.gxTpr_Br_comorbidity_allergy_code_Z;
         Z259BR_Comorbidity_Others = obj10.gxTpr_Br_comorbidity_others_Z;
         Z561BR_Comorbidity_HapetitisB = obj10.gxTpr_Br_comorbidity_hapetitisb_Z;
         Z562BR_Comorbidity_HapetitisB_Code = obj10.gxTpr_Br_comorbidity_hapetitisb_code_Z;
         Z563BR_Comorbidity_HapetitisC = obj10.gxTpr_Br_comorbidity_hapetitisc_Z;
         Z564BR_Comorbidity_HapetitisC_Code = obj10.gxTpr_Br_comorbidity_hapetitisc_code_Z;
         Z565BR_Comorbidity_LiverCirrhosis = obj10.gxTpr_Br_comorbidity_livercirrhosis_Z;
         Z566BR_Comorbidity_LiverCirrhosis_Code = obj10.gxTpr_Br_comorbidity_livercirrhosis_code_Z;
         Z567BR_Comorbidity_Druginducedliverinjury = obj10.gxTpr_Br_comorbidity_druginducedliverinjury_Z;
         Z568BR_Comorbidity_Druginducedliverinjury_Code = obj10.gxTpr_Br_comorbidity_druginducedliverinjury_code_Z;
         n36BR_Information_PatientNo = (bool)(Convert.ToBoolean(obj10.gxTpr_Br_information_patientno_N));
         n38BR_Comorbidity_Hypertension = (bool)(Convert.ToBoolean(obj10.gxTpr_Br_comorbidity_hypertension_N));
         n487BR_Comorbidity_Hypertension_Code = (bool)(Convert.ToBoolean(obj10.gxTpr_Br_comorbidity_hypertension_code_N));
         n39BR_Comorbidity_Diabetes = (bool)(Convert.ToBoolean(obj10.gxTpr_Br_comorbidity_diabetes_N));
         n488BR_Comorbidity_Diabetes_Code = (bool)(Convert.ToBoolean(obj10.gxTpr_Br_comorbidity_diabetes_code_N));
         n40BR_Comorbidity_CHD = (bool)(Convert.ToBoolean(obj10.gxTpr_Br_comorbidity_chd_N));
         n489BR_Comorbidity_CHD_Code = (bool)(Convert.ToBoolean(obj10.gxTpr_Br_comorbidity_chd_code_N));
         n41BR_Comorbidity_Hapetitis = (bool)(Convert.ToBoolean(obj10.gxTpr_Br_comorbidity_hapetitis_N));
         n490BR_Comorbidity_Hapetitis_Code = (bool)(Convert.ToBoolean(obj10.gxTpr_Br_comorbidity_hapetitis_code_N));
         n42BR_Comorbidity_TB = (bool)(Convert.ToBoolean(obj10.gxTpr_Br_comorbidity_tb_N));
         n491BR_Comorbidity_TB_Code = (bool)(Convert.ToBoolean(obj10.gxTpr_Br_comorbidity_tb_code_N));
         n43BR_Comorbidity_KidneyDisease = (bool)(Convert.ToBoolean(obj10.gxTpr_Br_comorbidity_kidneydisease_N));
         n492BR_Comorbidity_KidneyDisease_Code = (bool)(Convert.ToBoolean(obj10.gxTpr_Br_comorbidity_kidneydisease_code_N));
         n44BR_Comorbidity_SurgeryHistory = (bool)(Convert.ToBoolean(obj10.gxTpr_Br_comorbidity_surgeryhistory_N));
         n493BR_Comorbidity_SurgeryHistory_Code = (bool)(Convert.ToBoolean(obj10.gxTpr_Br_comorbidity_surgeryhistory_code_N));
         n45BR_Comorbidity_InjuryHistory = (bool)(Convert.ToBoolean(obj10.gxTpr_Br_comorbidity_injuryhistory_N));
         n494BR_Comorbidity_InjuryHistory_Code = (bool)(Convert.ToBoolean(obj10.gxTpr_Br_comorbidity_injuryhistory_code_N));
         n46BR_Comorbidity_BloodHistory = (bool)(Convert.ToBoolean(obj10.gxTpr_Br_comorbidity_bloodhistory_N));
         n495BR_Comorbidity_BloodHistory_Code = (bool)(Convert.ToBoolean(obj10.gxTpr_Br_comorbidity_bloodhistory_code_N));
         n47BR_Comorbidity_allergy = (bool)(Convert.ToBoolean(obj10.gxTpr_Br_comorbidity_allergy_N));
         n496BR_Comorbidity_allergy_Code = (bool)(Convert.ToBoolean(obj10.gxTpr_Br_comorbidity_allergy_code_N));
         n259BR_Comorbidity_Others = (bool)(Convert.ToBoolean(obj10.gxTpr_Br_comorbidity_others_N));
         n561BR_Comorbidity_HapetitisB = (bool)(Convert.ToBoolean(obj10.gxTpr_Br_comorbidity_hapetitisb_N));
         n562BR_Comorbidity_HapetitisB_Code = (bool)(Convert.ToBoolean(obj10.gxTpr_Br_comorbidity_hapetitisb_code_N));
         n563BR_Comorbidity_HapetitisC = (bool)(Convert.ToBoolean(obj10.gxTpr_Br_comorbidity_hapetitisc_N));
         n564BR_Comorbidity_HapetitisC_Code = (bool)(Convert.ToBoolean(obj10.gxTpr_Br_comorbidity_hapetitisc_code_N));
         n565BR_Comorbidity_LiverCirrhosis = (bool)(Convert.ToBoolean(obj10.gxTpr_Br_comorbidity_livercirrhosis_N));
         n566BR_Comorbidity_LiverCirrhosis_Code = (bool)(Convert.ToBoolean(obj10.gxTpr_Br_comorbidity_livercirrhosis_code_N));
         n567BR_Comorbidity_Druginducedliverinjury = (bool)(Convert.ToBoolean(obj10.gxTpr_Br_comorbidity_druginducedliverinjury_N));
         n568BR_Comorbidity_Druginducedliverinjury_Code = (bool)(Convert.ToBoolean(obj10.gxTpr_Br_comorbidity_druginducedliverinjury_code_N));
         Gx_mode = obj10.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A37BR_ComorbidityID = (long)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey0910( ) ;
         ScanKeyStart0910( ) ;
         if ( RcdFound10 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z37BR_ComorbidityID = A37BR_ComorbidityID;
         }
         ZM0910( -35) ;
         OnLoadActions0910( ) ;
         AddRow0910( ) ;
         ScanKeyEnd0910( ) ;
         if ( RcdFound10 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      public void Load( )
      {
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         RowToVars10( bcBR_Comorbidity, 0) ;
         ScanKeyStart0910( ) ;
         if ( RcdFound10 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z37BR_ComorbidityID = A37BR_ComorbidityID;
         }
         ZM0910( -35) ;
         OnLoadActions0910( ) ;
         AddRow0910( ) ;
         ScanKeyEnd0910( ) ;
         if ( RcdFound10 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey0910( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert0910( ) ;
         }
         else
         {
            if ( RcdFound10 == 1 )
            {
               if ( A37BR_ComorbidityID != Z37BR_ComorbidityID )
               {
                  A37BR_ComorbidityID = Z37BR_ComorbidityID;
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "");
                  AnyError = 1;
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
               }
               else
               {
                  Gx_mode = "UPD";
                  /* Update record */
                  Update0910( ) ;
               }
            }
            else
            {
               if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "");
                  AnyError = 1;
               }
               else
               {
                  if ( A37BR_ComorbidityID != Z37BR_ComorbidityID )
                  {
                     if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "DuplicatePrimaryKey", 1, "");
                        AnyError = 1;
                     }
                     else
                     {
                        Gx_mode = "INS";
                        /* Insert record */
                        Insert0910( ) ;
                     }
                  }
                  else
                  {
                     if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                        AnyError = 1;
                     }
                     else
                     {
                        Gx_mode = "INS";
                        /* Insert record */
                        Insert0910( ) ;
                     }
                  }
               }
            }
         }
         AfterTrn( ) ;
      }

      public void Save( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         IsConfirmed = 1;
         RowToVars10( bcBR_Comorbidity, 0) ;
         SaveImpl( ) ;
         VarsToRow10( bcBR_Comorbidity) ;
         context.GX_msglist = BackMsgLst;
         return  ;
      }

      public bool Insert( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         IsConfirmed = 1;
         RowToVars10( bcBR_Comorbidity, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert0910( ) ;
         AfterTrn( ) ;
         VarsToRow10( bcBR_Comorbidity) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      protected void UpdateImpl( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            SaveImpl( ) ;
         }
         else
         {
            SdtBR_Comorbidity auxBC = new SdtBR_Comorbidity(context) ;
            auxBC.Load(A37BR_ComorbidityID);
            auxBC.UpdateDirties(bcBR_Comorbidity);
            auxBC.Save();
            IGxSilentTrn auxTrn = auxBC.getTransaction() ;
            LclMsgLst = (msglist)(auxTrn.GetMessages());
            AnyError = (short)(auxTrn.Errors());
            Gx_mode = auxTrn.GetMode();
            context.GX_msglist = LclMsgLst;
            AfterTrn( ) ;
         }
      }

      public bool Update( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         IsConfirmed = 1;
         RowToVars10( bcBR_Comorbidity, 0) ;
         UpdateImpl( ) ;
         VarsToRow10( bcBR_Comorbidity) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public bool InsertOrUpdate( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         IsConfirmed = 1;
         RowToVars10( bcBR_Comorbidity, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert0910( ) ;
         if ( AnyError == 1 )
         {
            AnyError = 0;
            context.GX_msglist.removeAllItems();
            UpdateImpl( ) ;
         }
         else
         {
            AfterTrn( ) ;
         }
         VarsToRow10( bcBR_Comorbidity) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars10( bcBR_Comorbidity, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey0910( ) ;
         if ( RcdFound10 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A37BR_ComorbidityID != Z37BR_ComorbidityID )
            {
               A37BR_ComorbidityID = Z37BR_ComorbidityID;
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               delete_Check( ) ;
            }
            else
            {
               Gx_mode = "UPD";
               update_Check( ) ;
            }
         }
         else
         {
            if ( A37BR_ComorbidityID != Z37BR_ComorbidityID )
            {
               Gx_mode = "INS";
               insert_Check( ) ;
            }
            else
            {
               if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                  AnyError = 1;
               }
               else
               {
                  Gx_mode = "INS";
                  insert_Check( ) ;
               }
            }
         }
         pr_default.close(1);
         pr_default.close(9);
         pr_default.close(10);
         context.RollbackDataStores("br_comorbidity_bc",pr_default);
         VarsToRow10( bcBR_Comorbidity) ;
         context.GX_msglist = BackMsgLst;
         return  ;
      }

      public int Errors( )
      {
         if ( AnyError == 0 )
         {
            return (int)(0) ;
         }
         return (int)(1) ;
      }

      public msglist GetMessages( )
      {
         return LclMsgLst ;
      }

      public String GetMode( )
      {
         Gx_mode = bcBR_Comorbidity.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcBR_Comorbidity.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcBR_Comorbidity )
         {
            bcBR_Comorbidity = (SdtBR_Comorbidity)(sdt);
            if ( StringUtil.StrCmp(bcBR_Comorbidity.gxTpr_Mode, "") == 0 )
            {
               bcBR_Comorbidity.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow10( bcBR_Comorbidity) ;
            }
            else
            {
               RowToVars10( bcBR_Comorbidity, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcBR_Comorbidity.gxTpr_Mode, "") == 0 )
            {
               bcBR_Comorbidity.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars10( bcBR_Comorbidity, 1) ;
         return  ;
      }

      public SdtBR_Comorbidity BR_Comorbidity_BC
      {
         get {
            return bcBR_Comorbidity ;
         }

      }

      public override void webExecute( )
      {
         createObjects();
         initialize();
      }

      protected override void createObjects( )
      {
      }

      protected void Process( )
      {
      }

      public override void cleanup( )
      {
         flushBuffer();
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
      }

      protected void CloseOpenCursors( )
      {
         pr_default.close(1);
         pr_default.close(9);
         pr_default.close(10);
      }

      public override void initialize( )
      {
         scmdbuf = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Gx_mode = "";
         Z487BR_Comorbidity_Hypertension_Code = "";
         A487BR_Comorbidity_Hypertension_Code = "";
         Z488BR_Comorbidity_Diabetes_Code = "";
         A488BR_Comorbidity_Diabetes_Code = "";
         Z489BR_Comorbidity_CHD_Code = "";
         A489BR_Comorbidity_CHD_Code = "";
         Z490BR_Comorbidity_Hapetitis_Code = "";
         A490BR_Comorbidity_Hapetitis_Code = "";
         Z491BR_Comorbidity_TB_Code = "";
         A491BR_Comorbidity_TB_Code = "";
         Z492BR_Comorbidity_KidneyDisease_Code = "";
         A492BR_Comorbidity_KidneyDisease_Code = "";
         Z493BR_Comorbidity_SurgeryHistory_Code = "";
         A493BR_Comorbidity_SurgeryHistory_Code = "";
         Z494BR_Comorbidity_InjuryHistory_Code = "";
         A494BR_Comorbidity_InjuryHistory_Code = "";
         Z495BR_Comorbidity_BloodHistory_Code = "";
         A495BR_Comorbidity_BloodHistory_Code = "";
         Z496BR_Comorbidity_allergy_Code = "";
         A496BR_Comorbidity_allergy_Code = "";
         Z38BR_Comorbidity_Hypertension = "";
         A38BR_Comorbidity_Hypertension = "";
         Z39BR_Comorbidity_Diabetes = "";
         A39BR_Comorbidity_Diabetes = "";
         Z40BR_Comorbidity_CHD = "";
         A40BR_Comorbidity_CHD = "";
         Z41BR_Comorbidity_Hapetitis = "";
         A41BR_Comorbidity_Hapetitis = "";
         Z42BR_Comorbidity_TB = "";
         A42BR_Comorbidity_TB = "";
         Z43BR_Comorbidity_KidneyDisease = "";
         A43BR_Comorbidity_KidneyDisease = "";
         Z44BR_Comorbidity_SurgeryHistory = "";
         A44BR_Comorbidity_SurgeryHistory = "";
         Z45BR_Comorbidity_InjuryHistory = "";
         A45BR_Comorbidity_InjuryHistory = "";
         Z46BR_Comorbidity_BloodHistory = "";
         A46BR_Comorbidity_BloodHistory = "";
         Z47BR_Comorbidity_allergy = "";
         A47BR_Comorbidity_allergy = "";
         Z259BR_Comorbidity_Others = "";
         A259BR_Comorbidity_Others = "";
         Z561BR_Comorbidity_HapetitisB = "";
         A561BR_Comorbidity_HapetitisB = "";
         Z562BR_Comorbidity_HapetitisB_Code = "";
         A562BR_Comorbidity_HapetitisB_Code = "";
         Z563BR_Comorbidity_HapetitisC = "";
         A563BR_Comorbidity_HapetitisC = "";
         Z564BR_Comorbidity_HapetitisC_Code = "";
         A564BR_Comorbidity_HapetitisC_Code = "";
         Z565BR_Comorbidity_LiverCirrhosis = "";
         A565BR_Comorbidity_LiverCirrhosis = "";
         Z566BR_Comorbidity_LiverCirrhosis_Code = "";
         A566BR_Comorbidity_LiverCirrhosis_Code = "";
         Z567BR_Comorbidity_Druginducedliverinjury = "";
         A567BR_Comorbidity_Druginducedliverinjury = "";
         Z568BR_Comorbidity_Druginducedliverinjury_Code = "";
         A568BR_Comorbidity_Druginducedliverinjury_Code = "";
         Z36BR_Information_PatientNo = "";
         A36BR_Information_PatientNo = "";
         BC00096_A85BR_Information_ID = new long[1] ;
         BC00096_n85BR_Information_ID = new bool[] {false} ;
         BC00096_A37BR_ComorbidityID = new long[1] ;
         BC00096_A487BR_Comorbidity_Hypertension_Code = new String[] {""} ;
         BC00096_n487BR_Comorbidity_Hypertension_Code = new bool[] {false} ;
         BC00096_A488BR_Comorbidity_Diabetes_Code = new String[] {""} ;
         BC00096_n488BR_Comorbidity_Diabetes_Code = new bool[] {false} ;
         BC00096_A489BR_Comorbidity_CHD_Code = new String[] {""} ;
         BC00096_n489BR_Comorbidity_CHD_Code = new bool[] {false} ;
         BC00096_A490BR_Comorbidity_Hapetitis_Code = new String[] {""} ;
         BC00096_n490BR_Comorbidity_Hapetitis_Code = new bool[] {false} ;
         BC00096_A491BR_Comorbidity_TB_Code = new String[] {""} ;
         BC00096_n491BR_Comorbidity_TB_Code = new bool[] {false} ;
         BC00096_A492BR_Comorbidity_KidneyDisease_Code = new String[] {""} ;
         BC00096_n492BR_Comorbidity_KidneyDisease_Code = new bool[] {false} ;
         BC00096_A493BR_Comorbidity_SurgeryHistory_Code = new String[] {""} ;
         BC00096_n493BR_Comorbidity_SurgeryHistory_Code = new bool[] {false} ;
         BC00096_A494BR_Comorbidity_InjuryHistory_Code = new String[] {""} ;
         BC00096_n494BR_Comorbidity_InjuryHistory_Code = new bool[] {false} ;
         BC00096_A495BR_Comorbidity_BloodHistory_Code = new String[] {""} ;
         BC00096_n495BR_Comorbidity_BloodHistory_Code = new bool[] {false} ;
         BC00096_A496BR_Comorbidity_allergy_Code = new String[] {""} ;
         BC00096_n496BR_Comorbidity_allergy_Code = new bool[] {false} ;
         BC00096_A36BR_Information_PatientNo = new String[] {""} ;
         BC00096_n36BR_Information_PatientNo = new bool[] {false} ;
         BC00096_A38BR_Comorbidity_Hypertension = new String[] {""} ;
         BC00096_n38BR_Comorbidity_Hypertension = new bool[] {false} ;
         BC00096_A39BR_Comorbidity_Diabetes = new String[] {""} ;
         BC00096_n39BR_Comorbidity_Diabetes = new bool[] {false} ;
         BC00096_A40BR_Comorbidity_CHD = new String[] {""} ;
         BC00096_n40BR_Comorbidity_CHD = new bool[] {false} ;
         BC00096_A41BR_Comorbidity_Hapetitis = new String[] {""} ;
         BC00096_n41BR_Comorbidity_Hapetitis = new bool[] {false} ;
         BC00096_A42BR_Comorbidity_TB = new String[] {""} ;
         BC00096_n42BR_Comorbidity_TB = new bool[] {false} ;
         BC00096_A43BR_Comorbidity_KidneyDisease = new String[] {""} ;
         BC00096_n43BR_Comorbidity_KidneyDisease = new bool[] {false} ;
         BC00096_A44BR_Comorbidity_SurgeryHistory = new String[] {""} ;
         BC00096_n44BR_Comorbidity_SurgeryHistory = new bool[] {false} ;
         BC00096_A45BR_Comorbidity_InjuryHistory = new String[] {""} ;
         BC00096_n45BR_Comorbidity_InjuryHistory = new bool[] {false} ;
         BC00096_A46BR_Comorbidity_BloodHistory = new String[] {""} ;
         BC00096_n46BR_Comorbidity_BloodHistory = new bool[] {false} ;
         BC00096_A47BR_Comorbidity_allergy = new String[] {""} ;
         BC00096_n47BR_Comorbidity_allergy = new bool[] {false} ;
         BC00096_A259BR_Comorbidity_Others = new String[] {""} ;
         BC00096_n259BR_Comorbidity_Others = new bool[] {false} ;
         BC00096_A561BR_Comorbidity_HapetitisB = new String[] {""} ;
         BC00096_n561BR_Comorbidity_HapetitisB = new bool[] {false} ;
         BC00096_A562BR_Comorbidity_HapetitisB_Code = new String[] {""} ;
         BC00096_n562BR_Comorbidity_HapetitisB_Code = new bool[] {false} ;
         BC00096_A563BR_Comorbidity_HapetitisC = new String[] {""} ;
         BC00096_n563BR_Comorbidity_HapetitisC = new bool[] {false} ;
         BC00096_A564BR_Comorbidity_HapetitisC_Code = new String[] {""} ;
         BC00096_n564BR_Comorbidity_HapetitisC_Code = new bool[] {false} ;
         BC00096_A565BR_Comorbidity_LiverCirrhosis = new String[] {""} ;
         BC00096_n565BR_Comorbidity_LiverCirrhosis = new bool[] {false} ;
         BC00096_A566BR_Comorbidity_LiverCirrhosis_Code = new String[] {""} ;
         BC00096_n566BR_Comorbidity_LiverCirrhosis_Code = new bool[] {false} ;
         BC00096_A567BR_Comorbidity_Druginducedliverinjury = new String[] {""} ;
         BC00096_n567BR_Comorbidity_Druginducedliverinjury = new bool[] {false} ;
         BC00096_A568BR_Comorbidity_Druginducedliverinjury_Code = new String[] {""} ;
         BC00096_n568BR_Comorbidity_Druginducedliverinjury_Code = new bool[] {false} ;
         BC00096_A19BR_EncounterID = new long[1] ;
         BC00094_A85BR_Information_ID = new long[1] ;
         BC00094_n85BR_Information_ID = new bool[] {false} ;
         BC00095_A36BR_Information_PatientNo = new String[] {""} ;
         BC00095_n36BR_Information_PatientNo = new bool[] {false} ;
         BC00097_A37BR_ComorbidityID = new long[1] ;
         BC00093_A37BR_ComorbidityID = new long[1] ;
         BC00093_A487BR_Comorbidity_Hypertension_Code = new String[] {""} ;
         BC00093_n487BR_Comorbidity_Hypertension_Code = new bool[] {false} ;
         BC00093_A488BR_Comorbidity_Diabetes_Code = new String[] {""} ;
         BC00093_n488BR_Comorbidity_Diabetes_Code = new bool[] {false} ;
         BC00093_A489BR_Comorbidity_CHD_Code = new String[] {""} ;
         BC00093_n489BR_Comorbidity_CHD_Code = new bool[] {false} ;
         BC00093_A490BR_Comorbidity_Hapetitis_Code = new String[] {""} ;
         BC00093_n490BR_Comorbidity_Hapetitis_Code = new bool[] {false} ;
         BC00093_A491BR_Comorbidity_TB_Code = new String[] {""} ;
         BC00093_n491BR_Comorbidity_TB_Code = new bool[] {false} ;
         BC00093_A492BR_Comorbidity_KidneyDisease_Code = new String[] {""} ;
         BC00093_n492BR_Comorbidity_KidneyDisease_Code = new bool[] {false} ;
         BC00093_A493BR_Comorbidity_SurgeryHistory_Code = new String[] {""} ;
         BC00093_n493BR_Comorbidity_SurgeryHistory_Code = new bool[] {false} ;
         BC00093_A494BR_Comorbidity_InjuryHistory_Code = new String[] {""} ;
         BC00093_n494BR_Comorbidity_InjuryHistory_Code = new bool[] {false} ;
         BC00093_A495BR_Comorbidity_BloodHistory_Code = new String[] {""} ;
         BC00093_n495BR_Comorbidity_BloodHistory_Code = new bool[] {false} ;
         BC00093_A496BR_Comorbidity_allergy_Code = new String[] {""} ;
         BC00093_n496BR_Comorbidity_allergy_Code = new bool[] {false} ;
         BC00093_A38BR_Comorbidity_Hypertension = new String[] {""} ;
         BC00093_n38BR_Comorbidity_Hypertension = new bool[] {false} ;
         BC00093_A39BR_Comorbidity_Diabetes = new String[] {""} ;
         BC00093_n39BR_Comorbidity_Diabetes = new bool[] {false} ;
         BC00093_A40BR_Comorbidity_CHD = new String[] {""} ;
         BC00093_n40BR_Comorbidity_CHD = new bool[] {false} ;
         BC00093_A41BR_Comorbidity_Hapetitis = new String[] {""} ;
         BC00093_n41BR_Comorbidity_Hapetitis = new bool[] {false} ;
         BC00093_A42BR_Comorbidity_TB = new String[] {""} ;
         BC00093_n42BR_Comorbidity_TB = new bool[] {false} ;
         BC00093_A43BR_Comorbidity_KidneyDisease = new String[] {""} ;
         BC00093_n43BR_Comorbidity_KidneyDisease = new bool[] {false} ;
         BC00093_A44BR_Comorbidity_SurgeryHistory = new String[] {""} ;
         BC00093_n44BR_Comorbidity_SurgeryHistory = new bool[] {false} ;
         BC00093_A45BR_Comorbidity_InjuryHistory = new String[] {""} ;
         BC00093_n45BR_Comorbidity_InjuryHistory = new bool[] {false} ;
         BC00093_A46BR_Comorbidity_BloodHistory = new String[] {""} ;
         BC00093_n46BR_Comorbidity_BloodHistory = new bool[] {false} ;
         BC00093_A47BR_Comorbidity_allergy = new String[] {""} ;
         BC00093_n47BR_Comorbidity_allergy = new bool[] {false} ;
         BC00093_A259BR_Comorbidity_Others = new String[] {""} ;
         BC00093_n259BR_Comorbidity_Others = new bool[] {false} ;
         BC00093_A561BR_Comorbidity_HapetitisB = new String[] {""} ;
         BC00093_n561BR_Comorbidity_HapetitisB = new bool[] {false} ;
         BC00093_A562BR_Comorbidity_HapetitisB_Code = new String[] {""} ;
         BC00093_n562BR_Comorbidity_HapetitisB_Code = new bool[] {false} ;
         BC00093_A563BR_Comorbidity_HapetitisC = new String[] {""} ;
         BC00093_n563BR_Comorbidity_HapetitisC = new bool[] {false} ;
         BC00093_A564BR_Comorbidity_HapetitisC_Code = new String[] {""} ;
         BC00093_n564BR_Comorbidity_HapetitisC_Code = new bool[] {false} ;
         BC00093_A565BR_Comorbidity_LiverCirrhosis = new String[] {""} ;
         BC00093_n565BR_Comorbidity_LiverCirrhosis = new bool[] {false} ;
         BC00093_A566BR_Comorbidity_LiverCirrhosis_Code = new String[] {""} ;
         BC00093_n566BR_Comorbidity_LiverCirrhosis_Code = new bool[] {false} ;
         BC00093_A567BR_Comorbidity_Druginducedliverinjury = new String[] {""} ;
         BC00093_n567BR_Comorbidity_Druginducedliverinjury = new bool[] {false} ;
         BC00093_A568BR_Comorbidity_Druginducedliverinjury_Code = new String[] {""} ;
         BC00093_n568BR_Comorbidity_Druginducedliverinjury_Code = new bool[] {false} ;
         BC00093_A19BR_EncounterID = new long[1] ;
         sMode10 = "";
         BC00092_A37BR_ComorbidityID = new long[1] ;
         BC00092_A487BR_Comorbidity_Hypertension_Code = new String[] {""} ;
         BC00092_n487BR_Comorbidity_Hypertension_Code = new bool[] {false} ;
         BC00092_A488BR_Comorbidity_Diabetes_Code = new String[] {""} ;
         BC00092_n488BR_Comorbidity_Diabetes_Code = new bool[] {false} ;
         BC00092_A489BR_Comorbidity_CHD_Code = new String[] {""} ;
         BC00092_n489BR_Comorbidity_CHD_Code = new bool[] {false} ;
         BC00092_A490BR_Comorbidity_Hapetitis_Code = new String[] {""} ;
         BC00092_n490BR_Comorbidity_Hapetitis_Code = new bool[] {false} ;
         BC00092_A491BR_Comorbidity_TB_Code = new String[] {""} ;
         BC00092_n491BR_Comorbidity_TB_Code = new bool[] {false} ;
         BC00092_A492BR_Comorbidity_KidneyDisease_Code = new String[] {""} ;
         BC00092_n492BR_Comorbidity_KidneyDisease_Code = new bool[] {false} ;
         BC00092_A493BR_Comorbidity_SurgeryHistory_Code = new String[] {""} ;
         BC00092_n493BR_Comorbidity_SurgeryHistory_Code = new bool[] {false} ;
         BC00092_A494BR_Comorbidity_InjuryHistory_Code = new String[] {""} ;
         BC00092_n494BR_Comorbidity_InjuryHistory_Code = new bool[] {false} ;
         BC00092_A495BR_Comorbidity_BloodHistory_Code = new String[] {""} ;
         BC00092_n495BR_Comorbidity_BloodHistory_Code = new bool[] {false} ;
         BC00092_A496BR_Comorbidity_allergy_Code = new String[] {""} ;
         BC00092_n496BR_Comorbidity_allergy_Code = new bool[] {false} ;
         BC00092_A38BR_Comorbidity_Hypertension = new String[] {""} ;
         BC00092_n38BR_Comorbidity_Hypertension = new bool[] {false} ;
         BC00092_A39BR_Comorbidity_Diabetes = new String[] {""} ;
         BC00092_n39BR_Comorbidity_Diabetes = new bool[] {false} ;
         BC00092_A40BR_Comorbidity_CHD = new String[] {""} ;
         BC00092_n40BR_Comorbidity_CHD = new bool[] {false} ;
         BC00092_A41BR_Comorbidity_Hapetitis = new String[] {""} ;
         BC00092_n41BR_Comorbidity_Hapetitis = new bool[] {false} ;
         BC00092_A42BR_Comorbidity_TB = new String[] {""} ;
         BC00092_n42BR_Comorbidity_TB = new bool[] {false} ;
         BC00092_A43BR_Comorbidity_KidneyDisease = new String[] {""} ;
         BC00092_n43BR_Comorbidity_KidneyDisease = new bool[] {false} ;
         BC00092_A44BR_Comorbidity_SurgeryHistory = new String[] {""} ;
         BC00092_n44BR_Comorbidity_SurgeryHistory = new bool[] {false} ;
         BC00092_A45BR_Comorbidity_InjuryHistory = new String[] {""} ;
         BC00092_n45BR_Comorbidity_InjuryHistory = new bool[] {false} ;
         BC00092_A46BR_Comorbidity_BloodHistory = new String[] {""} ;
         BC00092_n46BR_Comorbidity_BloodHistory = new bool[] {false} ;
         BC00092_A47BR_Comorbidity_allergy = new String[] {""} ;
         BC00092_n47BR_Comorbidity_allergy = new bool[] {false} ;
         BC00092_A259BR_Comorbidity_Others = new String[] {""} ;
         BC00092_n259BR_Comorbidity_Others = new bool[] {false} ;
         BC00092_A561BR_Comorbidity_HapetitisB = new String[] {""} ;
         BC00092_n561BR_Comorbidity_HapetitisB = new bool[] {false} ;
         BC00092_A562BR_Comorbidity_HapetitisB_Code = new String[] {""} ;
         BC00092_n562BR_Comorbidity_HapetitisB_Code = new bool[] {false} ;
         BC00092_A563BR_Comorbidity_HapetitisC = new String[] {""} ;
         BC00092_n563BR_Comorbidity_HapetitisC = new bool[] {false} ;
         BC00092_A564BR_Comorbidity_HapetitisC_Code = new String[] {""} ;
         BC00092_n564BR_Comorbidity_HapetitisC_Code = new bool[] {false} ;
         BC00092_A565BR_Comorbidity_LiverCirrhosis = new String[] {""} ;
         BC00092_n565BR_Comorbidity_LiverCirrhosis = new bool[] {false} ;
         BC00092_A566BR_Comorbidity_LiverCirrhosis_Code = new String[] {""} ;
         BC00092_n566BR_Comorbidity_LiverCirrhosis_Code = new bool[] {false} ;
         BC00092_A567BR_Comorbidity_Druginducedliverinjury = new String[] {""} ;
         BC00092_n567BR_Comorbidity_Druginducedliverinjury = new bool[] {false} ;
         BC00092_A568BR_Comorbidity_Druginducedliverinjury_Code = new String[] {""} ;
         BC00092_n568BR_Comorbidity_Druginducedliverinjury_Code = new bool[] {false} ;
         BC00092_A19BR_EncounterID = new long[1] ;
         BC00098_A37BR_ComorbidityID = new long[1] ;
         BC000911_A85BR_Information_ID = new long[1] ;
         BC000911_n85BR_Information_ID = new bool[] {false} ;
         BC000912_A36BR_Information_PatientNo = new String[] {""} ;
         BC000912_n36BR_Information_PatientNo = new bool[] {false} ;
         BC000913_A85BR_Information_ID = new long[1] ;
         BC000913_n85BR_Information_ID = new bool[] {false} ;
         BC000913_A37BR_ComorbidityID = new long[1] ;
         BC000913_A487BR_Comorbidity_Hypertension_Code = new String[] {""} ;
         BC000913_n487BR_Comorbidity_Hypertension_Code = new bool[] {false} ;
         BC000913_A488BR_Comorbidity_Diabetes_Code = new String[] {""} ;
         BC000913_n488BR_Comorbidity_Diabetes_Code = new bool[] {false} ;
         BC000913_A489BR_Comorbidity_CHD_Code = new String[] {""} ;
         BC000913_n489BR_Comorbidity_CHD_Code = new bool[] {false} ;
         BC000913_A490BR_Comorbidity_Hapetitis_Code = new String[] {""} ;
         BC000913_n490BR_Comorbidity_Hapetitis_Code = new bool[] {false} ;
         BC000913_A491BR_Comorbidity_TB_Code = new String[] {""} ;
         BC000913_n491BR_Comorbidity_TB_Code = new bool[] {false} ;
         BC000913_A492BR_Comorbidity_KidneyDisease_Code = new String[] {""} ;
         BC000913_n492BR_Comorbidity_KidneyDisease_Code = new bool[] {false} ;
         BC000913_A493BR_Comorbidity_SurgeryHistory_Code = new String[] {""} ;
         BC000913_n493BR_Comorbidity_SurgeryHistory_Code = new bool[] {false} ;
         BC000913_A494BR_Comorbidity_InjuryHistory_Code = new String[] {""} ;
         BC000913_n494BR_Comorbidity_InjuryHistory_Code = new bool[] {false} ;
         BC000913_A495BR_Comorbidity_BloodHistory_Code = new String[] {""} ;
         BC000913_n495BR_Comorbidity_BloodHistory_Code = new bool[] {false} ;
         BC000913_A496BR_Comorbidity_allergy_Code = new String[] {""} ;
         BC000913_n496BR_Comorbidity_allergy_Code = new bool[] {false} ;
         BC000913_A36BR_Information_PatientNo = new String[] {""} ;
         BC000913_n36BR_Information_PatientNo = new bool[] {false} ;
         BC000913_A38BR_Comorbidity_Hypertension = new String[] {""} ;
         BC000913_n38BR_Comorbidity_Hypertension = new bool[] {false} ;
         BC000913_A39BR_Comorbidity_Diabetes = new String[] {""} ;
         BC000913_n39BR_Comorbidity_Diabetes = new bool[] {false} ;
         BC000913_A40BR_Comorbidity_CHD = new String[] {""} ;
         BC000913_n40BR_Comorbidity_CHD = new bool[] {false} ;
         BC000913_A41BR_Comorbidity_Hapetitis = new String[] {""} ;
         BC000913_n41BR_Comorbidity_Hapetitis = new bool[] {false} ;
         BC000913_A42BR_Comorbidity_TB = new String[] {""} ;
         BC000913_n42BR_Comorbidity_TB = new bool[] {false} ;
         BC000913_A43BR_Comorbidity_KidneyDisease = new String[] {""} ;
         BC000913_n43BR_Comorbidity_KidneyDisease = new bool[] {false} ;
         BC000913_A44BR_Comorbidity_SurgeryHistory = new String[] {""} ;
         BC000913_n44BR_Comorbidity_SurgeryHistory = new bool[] {false} ;
         BC000913_A45BR_Comorbidity_InjuryHistory = new String[] {""} ;
         BC000913_n45BR_Comorbidity_InjuryHistory = new bool[] {false} ;
         BC000913_A46BR_Comorbidity_BloodHistory = new String[] {""} ;
         BC000913_n46BR_Comorbidity_BloodHistory = new bool[] {false} ;
         BC000913_A47BR_Comorbidity_allergy = new String[] {""} ;
         BC000913_n47BR_Comorbidity_allergy = new bool[] {false} ;
         BC000913_A259BR_Comorbidity_Others = new String[] {""} ;
         BC000913_n259BR_Comorbidity_Others = new bool[] {false} ;
         BC000913_A561BR_Comorbidity_HapetitisB = new String[] {""} ;
         BC000913_n561BR_Comorbidity_HapetitisB = new bool[] {false} ;
         BC000913_A562BR_Comorbidity_HapetitisB_Code = new String[] {""} ;
         BC000913_n562BR_Comorbidity_HapetitisB_Code = new bool[] {false} ;
         BC000913_A563BR_Comorbidity_HapetitisC = new String[] {""} ;
         BC000913_n563BR_Comorbidity_HapetitisC = new bool[] {false} ;
         BC000913_A564BR_Comorbidity_HapetitisC_Code = new String[] {""} ;
         BC000913_n564BR_Comorbidity_HapetitisC_Code = new bool[] {false} ;
         BC000913_A565BR_Comorbidity_LiverCirrhosis = new String[] {""} ;
         BC000913_n565BR_Comorbidity_LiverCirrhosis = new bool[] {false} ;
         BC000913_A566BR_Comorbidity_LiverCirrhosis_Code = new String[] {""} ;
         BC000913_n566BR_Comorbidity_LiverCirrhosis_Code = new bool[] {false} ;
         BC000913_A567BR_Comorbidity_Druginducedliverinjury = new String[] {""} ;
         BC000913_n567BR_Comorbidity_Druginducedliverinjury = new bool[] {false} ;
         BC000913_A568BR_Comorbidity_Druginducedliverinjury_Code = new String[] {""} ;
         BC000913_n568BR_Comorbidity_Druginducedliverinjury_Code = new bool[] {false} ;
         BC000913_A19BR_EncounterID = new long[1] ;
         GXt_char1 = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_comorbidity_bc__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_comorbidity_bc__default(),
            new Object[][] {
                new Object[] {
               BC00092_A37BR_ComorbidityID, BC00092_A487BR_Comorbidity_Hypertension_Code, BC00092_n487BR_Comorbidity_Hypertension_Code, BC00092_A488BR_Comorbidity_Diabetes_Code, BC00092_n488BR_Comorbidity_Diabetes_Code, BC00092_A489BR_Comorbidity_CHD_Code, BC00092_n489BR_Comorbidity_CHD_Code, BC00092_A490BR_Comorbidity_Hapetitis_Code, BC00092_n490BR_Comorbidity_Hapetitis_Code, BC00092_A491BR_Comorbidity_TB_Code,
               BC00092_n491BR_Comorbidity_TB_Code, BC00092_A492BR_Comorbidity_KidneyDisease_Code, BC00092_n492BR_Comorbidity_KidneyDisease_Code, BC00092_A493BR_Comorbidity_SurgeryHistory_Code, BC00092_n493BR_Comorbidity_SurgeryHistory_Code, BC00092_A494BR_Comorbidity_InjuryHistory_Code, BC00092_n494BR_Comorbidity_InjuryHistory_Code, BC00092_A495BR_Comorbidity_BloodHistory_Code, BC00092_n495BR_Comorbidity_BloodHistory_Code, BC00092_A496BR_Comorbidity_allergy_Code,
               BC00092_n496BR_Comorbidity_allergy_Code, BC00092_A38BR_Comorbidity_Hypertension, BC00092_n38BR_Comorbidity_Hypertension, BC00092_A39BR_Comorbidity_Diabetes, BC00092_n39BR_Comorbidity_Diabetes, BC00092_A40BR_Comorbidity_CHD, BC00092_n40BR_Comorbidity_CHD, BC00092_A41BR_Comorbidity_Hapetitis, BC00092_n41BR_Comorbidity_Hapetitis, BC00092_A42BR_Comorbidity_TB,
               BC00092_n42BR_Comorbidity_TB, BC00092_A43BR_Comorbidity_KidneyDisease, BC00092_n43BR_Comorbidity_KidneyDisease, BC00092_A44BR_Comorbidity_SurgeryHistory, BC00092_n44BR_Comorbidity_SurgeryHistory, BC00092_A45BR_Comorbidity_InjuryHistory, BC00092_n45BR_Comorbidity_InjuryHistory, BC00092_A46BR_Comorbidity_BloodHistory, BC00092_n46BR_Comorbidity_BloodHistory, BC00092_A47BR_Comorbidity_allergy,
               BC00092_n47BR_Comorbidity_allergy, BC00092_A259BR_Comorbidity_Others, BC00092_n259BR_Comorbidity_Others, BC00092_A561BR_Comorbidity_HapetitisB, BC00092_n561BR_Comorbidity_HapetitisB, BC00092_A562BR_Comorbidity_HapetitisB_Code, BC00092_n562BR_Comorbidity_HapetitisB_Code, BC00092_A563BR_Comorbidity_HapetitisC, BC00092_n563BR_Comorbidity_HapetitisC, BC00092_A564BR_Comorbidity_HapetitisC_Code,
               BC00092_n564BR_Comorbidity_HapetitisC_Code, BC00092_A565BR_Comorbidity_LiverCirrhosis, BC00092_n565BR_Comorbidity_LiverCirrhosis, BC00092_A566BR_Comorbidity_LiverCirrhosis_Code, BC00092_n566BR_Comorbidity_LiverCirrhosis_Code, BC00092_A567BR_Comorbidity_Druginducedliverinjury, BC00092_n567BR_Comorbidity_Druginducedliverinjury, BC00092_A568BR_Comorbidity_Druginducedliverinjury_Code, BC00092_n568BR_Comorbidity_Druginducedliverinjury_Code, BC00092_A19BR_EncounterID
               }
               , new Object[] {
               BC00093_A37BR_ComorbidityID, BC00093_A487BR_Comorbidity_Hypertension_Code, BC00093_n487BR_Comorbidity_Hypertension_Code, BC00093_A488BR_Comorbidity_Diabetes_Code, BC00093_n488BR_Comorbidity_Diabetes_Code, BC00093_A489BR_Comorbidity_CHD_Code, BC00093_n489BR_Comorbidity_CHD_Code, BC00093_A490BR_Comorbidity_Hapetitis_Code, BC00093_n490BR_Comorbidity_Hapetitis_Code, BC00093_A491BR_Comorbidity_TB_Code,
               BC00093_n491BR_Comorbidity_TB_Code, BC00093_A492BR_Comorbidity_KidneyDisease_Code, BC00093_n492BR_Comorbidity_KidneyDisease_Code, BC00093_A493BR_Comorbidity_SurgeryHistory_Code, BC00093_n493BR_Comorbidity_SurgeryHistory_Code, BC00093_A494BR_Comorbidity_InjuryHistory_Code, BC00093_n494BR_Comorbidity_InjuryHistory_Code, BC00093_A495BR_Comorbidity_BloodHistory_Code, BC00093_n495BR_Comorbidity_BloodHistory_Code, BC00093_A496BR_Comorbidity_allergy_Code,
               BC00093_n496BR_Comorbidity_allergy_Code, BC00093_A38BR_Comorbidity_Hypertension, BC00093_n38BR_Comorbidity_Hypertension, BC00093_A39BR_Comorbidity_Diabetes, BC00093_n39BR_Comorbidity_Diabetes, BC00093_A40BR_Comorbidity_CHD, BC00093_n40BR_Comorbidity_CHD, BC00093_A41BR_Comorbidity_Hapetitis, BC00093_n41BR_Comorbidity_Hapetitis, BC00093_A42BR_Comorbidity_TB,
               BC00093_n42BR_Comorbidity_TB, BC00093_A43BR_Comorbidity_KidneyDisease, BC00093_n43BR_Comorbidity_KidneyDisease, BC00093_A44BR_Comorbidity_SurgeryHistory, BC00093_n44BR_Comorbidity_SurgeryHistory, BC00093_A45BR_Comorbidity_InjuryHistory, BC00093_n45BR_Comorbidity_InjuryHistory, BC00093_A46BR_Comorbidity_BloodHistory, BC00093_n46BR_Comorbidity_BloodHistory, BC00093_A47BR_Comorbidity_allergy,
               BC00093_n47BR_Comorbidity_allergy, BC00093_A259BR_Comorbidity_Others, BC00093_n259BR_Comorbidity_Others, BC00093_A561BR_Comorbidity_HapetitisB, BC00093_n561BR_Comorbidity_HapetitisB, BC00093_A562BR_Comorbidity_HapetitisB_Code, BC00093_n562BR_Comorbidity_HapetitisB_Code, BC00093_A563BR_Comorbidity_HapetitisC, BC00093_n563BR_Comorbidity_HapetitisC, BC00093_A564BR_Comorbidity_HapetitisC_Code,
               BC00093_n564BR_Comorbidity_HapetitisC_Code, BC00093_A565BR_Comorbidity_LiverCirrhosis, BC00093_n565BR_Comorbidity_LiverCirrhosis, BC00093_A566BR_Comorbidity_LiverCirrhosis_Code, BC00093_n566BR_Comorbidity_LiverCirrhosis_Code, BC00093_A567BR_Comorbidity_Druginducedliverinjury, BC00093_n567BR_Comorbidity_Druginducedliverinjury, BC00093_A568BR_Comorbidity_Druginducedliverinjury_Code, BC00093_n568BR_Comorbidity_Druginducedliverinjury_Code, BC00093_A19BR_EncounterID
               }
               , new Object[] {
               BC00094_A85BR_Information_ID, BC00094_n85BR_Information_ID
               }
               , new Object[] {
               BC00095_A36BR_Information_PatientNo, BC00095_n36BR_Information_PatientNo
               }
               , new Object[] {
               BC00096_A85BR_Information_ID, BC00096_n85BR_Information_ID, BC00096_A37BR_ComorbidityID, BC00096_A487BR_Comorbidity_Hypertension_Code, BC00096_n487BR_Comorbidity_Hypertension_Code, BC00096_A488BR_Comorbidity_Diabetes_Code, BC00096_n488BR_Comorbidity_Diabetes_Code, BC00096_A489BR_Comorbidity_CHD_Code, BC00096_n489BR_Comorbidity_CHD_Code, BC00096_A490BR_Comorbidity_Hapetitis_Code,
               BC00096_n490BR_Comorbidity_Hapetitis_Code, BC00096_A491BR_Comorbidity_TB_Code, BC00096_n491BR_Comorbidity_TB_Code, BC00096_A492BR_Comorbidity_KidneyDisease_Code, BC00096_n492BR_Comorbidity_KidneyDisease_Code, BC00096_A493BR_Comorbidity_SurgeryHistory_Code, BC00096_n493BR_Comorbidity_SurgeryHistory_Code, BC00096_A494BR_Comorbidity_InjuryHistory_Code, BC00096_n494BR_Comorbidity_InjuryHistory_Code, BC00096_A495BR_Comorbidity_BloodHistory_Code,
               BC00096_n495BR_Comorbidity_BloodHistory_Code, BC00096_A496BR_Comorbidity_allergy_Code, BC00096_n496BR_Comorbidity_allergy_Code, BC00096_A36BR_Information_PatientNo, BC00096_n36BR_Information_PatientNo, BC00096_A38BR_Comorbidity_Hypertension, BC00096_n38BR_Comorbidity_Hypertension, BC00096_A39BR_Comorbidity_Diabetes, BC00096_n39BR_Comorbidity_Diabetes, BC00096_A40BR_Comorbidity_CHD,
               BC00096_n40BR_Comorbidity_CHD, BC00096_A41BR_Comorbidity_Hapetitis, BC00096_n41BR_Comorbidity_Hapetitis, BC00096_A42BR_Comorbidity_TB, BC00096_n42BR_Comorbidity_TB, BC00096_A43BR_Comorbidity_KidneyDisease, BC00096_n43BR_Comorbidity_KidneyDisease, BC00096_A44BR_Comorbidity_SurgeryHistory, BC00096_n44BR_Comorbidity_SurgeryHistory, BC00096_A45BR_Comorbidity_InjuryHistory,
               BC00096_n45BR_Comorbidity_InjuryHistory, BC00096_A46BR_Comorbidity_BloodHistory, BC00096_n46BR_Comorbidity_BloodHistory, BC00096_A47BR_Comorbidity_allergy, BC00096_n47BR_Comorbidity_allergy, BC00096_A259BR_Comorbidity_Others, BC00096_n259BR_Comorbidity_Others, BC00096_A561BR_Comorbidity_HapetitisB, BC00096_n561BR_Comorbidity_HapetitisB, BC00096_A562BR_Comorbidity_HapetitisB_Code,
               BC00096_n562BR_Comorbidity_HapetitisB_Code, BC00096_A563BR_Comorbidity_HapetitisC, BC00096_n563BR_Comorbidity_HapetitisC, BC00096_A564BR_Comorbidity_HapetitisC_Code, BC00096_n564BR_Comorbidity_HapetitisC_Code, BC00096_A565BR_Comorbidity_LiverCirrhosis, BC00096_n565BR_Comorbidity_LiverCirrhosis, BC00096_A566BR_Comorbidity_LiverCirrhosis_Code, BC00096_n566BR_Comorbidity_LiverCirrhosis_Code, BC00096_A567BR_Comorbidity_Druginducedliverinjury,
               BC00096_n567BR_Comorbidity_Druginducedliverinjury, BC00096_A568BR_Comorbidity_Druginducedliverinjury_Code, BC00096_n568BR_Comorbidity_Druginducedliverinjury_Code, BC00096_A19BR_EncounterID
               }
               , new Object[] {
               BC00097_A37BR_ComorbidityID
               }
               , new Object[] {
               BC00098_A37BR_ComorbidityID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000911_A85BR_Information_ID, BC000911_n85BR_Information_ID
               }
               , new Object[] {
               BC000912_A36BR_Information_PatientNo, BC000912_n36BR_Information_PatientNo
               }
               , new Object[] {
               BC000913_A85BR_Information_ID, BC000913_n85BR_Information_ID, BC000913_A37BR_ComorbidityID, BC000913_A487BR_Comorbidity_Hypertension_Code, BC000913_n487BR_Comorbidity_Hypertension_Code, BC000913_A488BR_Comorbidity_Diabetes_Code, BC000913_n488BR_Comorbidity_Diabetes_Code, BC000913_A489BR_Comorbidity_CHD_Code, BC000913_n489BR_Comorbidity_CHD_Code, BC000913_A490BR_Comorbidity_Hapetitis_Code,
               BC000913_n490BR_Comorbidity_Hapetitis_Code, BC000913_A491BR_Comorbidity_TB_Code, BC000913_n491BR_Comorbidity_TB_Code, BC000913_A492BR_Comorbidity_KidneyDisease_Code, BC000913_n492BR_Comorbidity_KidneyDisease_Code, BC000913_A493BR_Comorbidity_SurgeryHistory_Code, BC000913_n493BR_Comorbidity_SurgeryHistory_Code, BC000913_A494BR_Comorbidity_InjuryHistory_Code, BC000913_n494BR_Comorbidity_InjuryHistory_Code, BC000913_A495BR_Comorbidity_BloodHistory_Code,
               BC000913_n495BR_Comorbidity_BloodHistory_Code, BC000913_A496BR_Comorbidity_allergy_Code, BC000913_n496BR_Comorbidity_allergy_Code, BC000913_A36BR_Information_PatientNo, BC000913_n36BR_Information_PatientNo, BC000913_A38BR_Comorbidity_Hypertension, BC000913_n38BR_Comorbidity_Hypertension, BC000913_A39BR_Comorbidity_Diabetes, BC000913_n39BR_Comorbidity_Diabetes, BC000913_A40BR_Comorbidity_CHD,
               BC000913_n40BR_Comorbidity_CHD, BC000913_A41BR_Comorbidity_Hapetitis, BC000913_n41BR_Comorbidity_Hapetitis, BC000913_A42BR_Comorbidity_TB, BC000913_n42BR_Comorbidity_TB, BC000913_A43BR_Comorbidity_KidneyDisease, BC000913_n43BR_Comorbidity_KidneyDisease, BC000913_A44BR_Comorbidity_SurgeryHistory, BC000913_n44BR_Comorbidity_SurgeryHistory, BC000913_A45BR_Comorbidity_InjuryHistory,
               BC000913_n45BR_Comorbidity_InjuryHistory, BC000913_A46BR_Comorbidity_BloodHistory, BC000913_n46BR_Comorbidity_BloodHistory, BC000913_A47BR_Comorbidity_allergy, BC000913_n47BR_Comorbidity_allergy, BC000913_A259BR_Comorbidity_Others, BC000913_n259BR_Comorbidity_Others, BC000913_A561BR_Comorbidity_HapetitisB, BC000913_n561BR_Comorbidity_HapetitisB, BC000913_A562BR_Comorbidity_HapetitisB_Code,
               BC000913_n562BR_Comorbidity_HapetitisB_Code, BC000913_A563BR_Comorbidity_HapetitisC, BC000913_n563BR_Comorbidity_HapetitisC, BC000913_A564BR_Comorbidity_HapetitisC_Code, BC000913_n564BR_Comorbidity_HapetitisC_Code, BC000913_A565BR_Comorbidity_LiverCirrhosis, BC000913_n565BR_Comorbidity_LiverCirrhosis, BC000913_A566BR_Comorbidity_LiverCirrhosis_Code, BC000913_n566BR_Comorbidity_LiverCirrhosis_Code, BC000913_A567BR_Comorbidity_Druginducedliverinjury,
               BC000913_n567BR_Comorbidity_Druginducedliverinjury, BC000913_A568BR_Comorbidity_Druginducedliverinjury_Code, BC000913_n568BR_Comorbidity_Druginducedliverinjury_Code, BC000913_A19BR_EncounterID
               }
            }
         );
         INITTRN();
         /* Execute Start event if defined. */
         /* Execute user event: Start */
         E12092 ();
         standaloneNotModal( ) ;
      }

      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short GX_JID ;
      private short RcdFound10 ;
      private int trnEnded ;
      private long Z37BR_ComorbidityID ;
      private long A37BR_ComorbidityID ;
      private long Z19BR_EncounterID ;
      private long A19BR_EncounterID ;
      private long Z85BR_Information_ID ;
      private long A85BR_Information_ID ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String sMode10 ;
      private String GXt_char1 ;
      private bool n85BR_Information_ID ;
      private bool n487BR_Comorbidity_Hypertension_Code ;
      private bool n488BR_Comorbidity_Diabetes_Code ;
      private bool n489BR_Comorbidity_CHD_Code ;
      private bool n490BR_Comorbidity_Hapetitis_Code ;
      private bool n491BR_Comorbidity_TB_Code ;
      private bool n492BR_Comorbidity_KidneyDisease_Code ;
      private bool n493BR_Comorbidity_SurgeryHistory_Code ;
      private bool n494BR_Comorbidity_InjuryHistory_Code ;
      private bool n495BR_Comorbidity_BloodHistory_Code ;
      private bool n496BR_Comorbidity_allergy_Code ;
      private bool n36BR_Information_PatientNo ;
      private bool n38BR_Comorbidity_Hypertension ;
      private bool n39BR_Comorbidity_Diabetes ;
      private bool n40BR_Comorbidity_CHD ;
      private bool n41BR_Comorbidity_Hapetitis ;
      private bool n42BR_Comorbidity_TB ;
      private bool n43BR_Comorbidity_KidneyDisease ;
      private bool n44BR_Comorbidity_SurgeryHistory ;
      private bool n45BR_Comorbidity_InjuryHistory ;
      private bool n46BR_Comorbidity_BloodHistory ;
      private bool n47BR_Comorbidity_allergy ;
      private bool n259BR_Comorbidity_Others ;
      private bool n561BR_Comorbidity_HapetitisB ;
      private bool n562BR_Comorbidity_HapetitisB_Code ;
      private bool n563BR_Comorbidity_HapetitisC ;
      private bool n564BR_Comorbidity_HapetitisC_Code ;
      private bool n565BR_Comorbidity_LiverCirrhosis ;
      private bool n566BR_Comorbidity_LiverCirrhosis_Code ;
      private bool n567BR_Comorbidity_Druginducedliverinjury ;
      private bool n568BR_Comorbidity_Druginducedliverinjury_Code ;
      private bool Gx_longc ;
      private String Z487BR_Comorbidity_Hypertension_Code ;
      private String A487BR_Comorbidity_Hypertension_Code ;
      private String Z488BR_Comorbidity_Diabetes_Code ;
      private String A488BR_Comorbidity_Diabetes_Code ;
      private String Z489BR_Comorbidity_CHD_Code ;
      private String A489BR_Comorbidity_CHD_Code ;
      private String Z490BR_Comorbidity_Hapetitis_Code ;
      private String A490BR_Comorbidity_Hapetitis_Code ;
      private String Z491BR_Comorbidity_TB_Code ;
      private String A491BR_Comorbidity_TB_Code ;
      private String Z492BR_Comorbidity_KidneyDisease_Code ;
      private String A492BR_Comorbidity_KidneyDisease_Code ;
      private String Z493BR_Comorbidity_SurgeryHistory_Code ;
      private String A493BR_Comorbidity_SurgeryHistory_Code ;
      private String Z494BR_Comorbidity_InjuryHistory_Code ;
      private String A494BR_Comorbidity_InjuryHistory_Code ;
      private String Z495BR_Comorbidity_BloodHistory_Code ;
      private String A495BR_Comorbidity_BloodHistory_Code ;
      private String Z496BR_Comorbidity_allergy_Code ;
      private String A496BR_Comorbidity_allergy_Code ;
      private String Z38BR_Comorbidity_Hypertension ;
      private String A38BR_Comorbidity_Hypertension ;
      private String Z39BR_Comorbidity_Diabetes ;
      private String A39BR_Comorbidity_Diabetes ;
      private String Z40BR_Comorbidity_CHD ;
      private String A40BR_Comorbidity_CHD ;
      private String Z41BR_Comorbidity_Hapetitis ;
      private String A41BR_Comorbidity_Hapetitis ;
      private String Z42BR_Comorbidity_TB ;
      private String A42BR_Comorbidity_TB ;
      private String Z43BR_Comorbidity_KidneyDisease ;
      private String A43BR_Comorbidity_KidneyDisease ;
      private String Z44BR_Comorbidity_SurgeryHistory ;
      private String A44BR_Comorbidity_SurgeryHistory ;
      private String Z45BR_Comorbidity_InjuryHistory ;
      private String A45BR_Comorbidity_InjuryHistory ;
      private String Z46BR_Comorbidity_BloodHistory ;
      private String A46BR_Comorbidity_BloodHistory ;
      private String Z47BR_Comorbidity_allergy ;
      private String A47BR_Comorbidity_allergy ;
      private String Z259BR_Comorbidity_Others ;
      private String A259BR_Comorbidity_Others ;
      private String Z561BR_Comorbidity_HapetitisB ;
      private String A561BR_Comorbidity_HapetitisB ;
      private String Z562BR_Comorbidity_HapetitisB_Code ;
      private String A562BR_Comorbidity_HapetitisB_Code ;
      private String Z563BR_Comorbidity_HapetitisC ;
      private String A563BR_Comorbidity_HapetitisC ;
      private String Z564BR_Comorbidity_HapetitisC_Code ;
      private String A564BR_Comorbidity_HapetitisC_Code ;
      private String Z565BR_Comorbidity_LiverCirrhosis ;
      private String A565BR_Comorbidity_LiverCirrhosis ;
      private String Z566BR_Comorbidity_LiverCirrhosis_Code ;
      private String A566BR_Comorbidity_LiverCirrhosis_Code ;
      private String Z567BR_Comorbidity_Druginducedliverinjury ;
      private String A567BR_Comorbidity_Druginducedliverinjury ;
      private String Z568BR_Comorbidity_Druginducedliverinjury_Code ;
      private String A568BR_Comorbidity_Druginducedliverinjury_Code ;
      private String Z36BR_Information_PatientNo ;
      private String A36BR_Information_PatientNo ;
      private SdtBR_Comorbidity bcBR_Comorbidity ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] BC00096_A85BR_Information_ID ;
      private bool[] BC00096_n85BR_Information_ID ;
      private long[] BC00096_A37BR_ComorbidityID ;
      private String[] BC00096_A487BR_Comorbidity_Hypertension_Code ;
      private bool[] BC00096_n487BR_Comorbidity_Hypertension_Code ;
      private String[] BC00096_A488BR_Comorbidity_Diabetes_Code ;
      private bool[] BC00096_n488BR_Comorbidity_Diabetes_Code ;
      private String[] BC00096_A489BR_Comorbidity_CHD_Code ;
      private bool[] BC00096_n489BR_Comorbidity_CHD_Code ;
      private String[] BC00096_A490BR_Comorbidity_Hapetitis_Code ;
      private bool[] BC00096_n490BR_Comorbidity_Hapetitis_Code ;
      private String[] BC00096_A491BR_Comorbidity_TB_Code ;
      private bool[] BC00096_n491BR_Comorbidity_TB_Code ;
      private String[] BC00096_A492BR_Comorbidity_KidneyDisease_Code ;
      private bool[] BC00096_n492BR_Comorbidity_KidneyDisease_Code ;
      private String[] BC00096_A493BR_Comorbidity_SurgeryHistory_Code ;
      private bool[] BC00096_n493BR_Comorbidity_SurgeryHistory_Code ;
      private String[] BC00096_A494BR_Comorbidity_InjuryHistory_Code ;
      private bool[] BC00096_n494BR_Comorbidity_InjuryHistory_Code ;
      private String[] BC00096_A495BR_Comorbidity_BloodHistory_Code ;
      private bool[] BC00096_n495BR_Comorbidity_BloodHistory_Code ;
      private String[] BC00096_A496BR_Comorbidity_allergy_Code ;
      private bool[] BC00096_n496BR_Comorbidity_allergy_Code ;
      private String[] BC00096_A36BR_Information_PatientNo ;
      private bool[] BC00096_n36BR_Information_PatientNo ;
      private String[] BC00096_A38BR_Comorbidity_Hypertension ;
      private bool[] BC00096_n38BR_Comorbidity_Hypertension ;
      private String[] BC00096_A39BR_Comorbidity_Diabetes ;
      private bool[] BC00096_n39BR_Comorbidity_Diabetes ;
      private String[] BC00096_A40BR_Comorbidity_CHD ;
      private bool[] BC00096_n40BR_Comorbidity_CHD ;
      private String[] BC00096_A41BR_Comorbidity_Hapetitis ;
      private bool[] BC00096_n41BR_Comorbidity_Hapetitis ;
      private String[] BC00096_A42BR_Comorbidity_TB ;
      private bool[] BC00096_n42BR_Comorbidity_TB ;
      private String[] BC00096_A43BR_Comorbidity_KidneyDisease ;
      private bool[] BC00096_n43BR_Comorbidity_KidneyDisease ;
      private String[] BC00096_A44BR_Comorbidity_SurgeryHistory ;
      private bool[] BC00096_n44BR_Comorbidity_SurgeryHistory ;
      private String[] BC00096_A45BR_Comorbidity_InjuryHistory ;
      private bool[] BC00096_n45BR_Comorbidity_InjuryHistory ;
      private String[] BC00096_A46BR_Comorbidity_BloodHistory ;
      private bool[] BC00096_n46BR_Comorbidity_BloodHistory ;
      private String[] BC00096_A47BR_Comorbidity_allergy ;
      private bool[] BC00096_n47BR_Comorbidity_allergy ;
      private String[] BC00096_A259BR_Comorbidity_Others ;
      private bool[] BC00096_n259BR_Comorbidity_Others ;
      private String[] BC00096_A561BR_Comorbidity_HapetitisB ;
      private bool[] BC00096_n561BR_Comorbidity_HapetitisB ;
      private String[] BC00096_A562BR_Comorbidity_HapetitisB_Code ;
      private bool[] BC00096_n562BR_Comorbidity_HapetitisB_Code ;
      private String[] BC00096_A563BR_Comorbidity_HapetitisC ;
      private bool[] BC00096_n563BR_Comorbidity_HapetitisC ;
      private String[] BC00096_A564BR_Comorbidity_HapetitisC_Code ;
      private bool[] BC00096_n564BR_Comorbidity_HapetitisC_Code ;
      private String[] BC00096_A565BR_Comorbidity_LiverCirrhosis ;
      private bool[] BC00096_n565BR_Comorbidity_LiverCirrhosis ;
      private String[] BC00096_A566BR_Comorbidity_LiverCirrhosis_Code ;
      private bool[] BC00096_n566BR_Comorbidity_LiverCirrhosis_Code ;
      private String[] BC00096_A567BR_Comorbidity_Druginducedliverinjury ;
      private bool[] BC00096_n567BR_Comorbidity_Druginducedliverinjury ;
      private String[] BC00096_A568BR_Comorbidity_Druginducedliverinjury_Code ;
      private bool[] BC00096_n568BR_Comorbidity_Druginducedliverinjury_Code ;
      private long[] BC00096_A19BR_EncounterID ;
      private long[] BC00094_A85BR_Information_ID ;
      private bool[] BC00094_n85BR_Information_ID ;
      private String[] BC00095_A36BR_Information_PatientNo ;
      private bool[] BC00095_n36BR_Information_PatientNo ;
      private long[] BC00097_A37BR_ComorbidityID ;
      private long[] BC00093_A37BR_ComorbidityID ;
      private String[] BC00093_A487BR_Comorbidity_Hypertension_Code ;
      private bool[] BC00093_n487BR_Comorbidity_Hypertension_Code ;
      private String[] BC00093_A488BR_Comorbidity_Diabetes_Code ;
      private bool[] BC00093_n488BR_Comorbidity_Diabetes_Code ;
      private String[] BC00093_A489BR_Comorbidity_CHD_Code ;
      private bool[] BC00093_n489BR_Comorbidity_CHD_Code ;
      private String[] BC00093_A490BR_Comorbidity_Hapetitis_Code ;
      private bool[] BC00093_n490BR_Comorbidity_Hapetitis_Code ;
      private String[] BC00093_A491BR_Comorbidity_TB_Code ;
      private bool[] BC00093_n491BR_Comorbidity_TB_Code ;
      private String[] BC00093_A492BR_Comorbidity_KidneyDisease_Code ;
      private bool[] BC00093_n492BR_Comorbidity_KidneyDisease_Code ;
      private String[] BC00093_A493BR_Comorbidity_SurgeryHistory_Code ;
      private bool[] BC00093_n493BR_Comorbidity_SurgeryHistory_Code ;
      private String[] BC00093_A494BR_Comorbidity_InjuryHistory_Code ;
      private bool[] BC00093_n494BR_Comorbidity_InjuryHistory_Code ;
      private String[] BC00093_A495BR_Comorbidity_BloodHistory_Code ;
      private bool[] BC00093_n495BR_Comorbidity_BloodHistory_Code ;
      private String[] BC00093_A496BR_Comorbidity_allergy_Code ;
      private bool[] BC00093_n496BR_Comorbidity_allergy_Code ;
      private String[] BC00093_A38BR_Comorbidity_Hypertension ;
      private bool[] BC00093_n38BR_Comorbidity_Hypertension ;
      private String[] BC00093_A39BR_Comorbidity_Diabetes ;
      private bool[] BC00093_n39BR_Comorbidity_Diabetes ;
      private String[] BC00093_A40BR_Comorbidity_CHD ;
      private bool[] BC00093_n40BR_Comorbidity_CHD ;
      private String[] BC00093_A41BR_Comorbidity_Hapetitis ;
      private bool[] BC00093_n41BR_Comorbidity_Hapetitis ;
      private String[] BC00093_A42BR_Comorbidity_TB ;
      private bool[] BC00093_n42BR_Comorbidity_TB ;
      private String[] BC00093_A43BR_Comorbidity_KidneyDisease ;
      private bool[] BC00093_n43BR_Comorbidity_KidneyDisease ;
      private String[] BC00093_A44BR_Comorbidity_SurgeryHistory ;
      private bool[] BC00093_n44BR_Comorbidity_SurgeryHistory ;
      private String[] BC00093_A45BR_Comorbidity_InjuryHistory ;
      private bool[] BC00093_n45BR_Comorbidity_InjuryHistory ;
      private String[] BC00093_A46BR_Comorbidity_BloodHistory ;
      private bool[] BC00093_n46BR_Comorbidity_BloodHistory ;
      private String[] BC00093_A47BR_Comorbidity_allergy ;
      private bool[] BC00093_n47BR_Comorbidity_allergy ;
      private String[] BC00093_A259BR_Comorbidity_Others ;
      private bool[] BC00093_n259BR_Comorbidity_Others ;
      private String[] BC00093_A561BR_Comorbidity_HapetitisB ;
      private bool[] BC00093_n561BR_Comorbidity_HapetitisB ;
      private String[] BC00093_A562BR_Comorbidity_HapetitisB_Code ;
      private bool[] BC00093_n562BR_Comorbidity_HapetitisB_Code ;
      private String[] BC00093_A563BR_Comorbidity_HapetitisC ;
      private bool[] BC00093_n563BR_Comorbidity_HapetitisC ;
      private String[] BC00093_A564BR_Comorbidity_HapetitisC_Code ;
      private bool[] BC00093_n564BR_Comorbidity_HapetitisC_Code ;
      private String[] BC00093_A565BR_Comorbidity_LiverCirrhosis ;
      private bool[] BC00093_n565BR_Comorbidity_LiverCirrhosis ;
      private String[] BC00093_A566BR_Comorbidity_LiverCirrhosis_Code ;
      private bool[] BC00093_n566BR_Comorbidity_LiverCirrhosis_Code ;
      private String[] BC00093_A567BR_Comorbidity_Druginducedliverinjury ;
      private bool[] BC00093_n567BR_Comorbidity_Druginducedliverinjury ;
      private String[] BC00093_A568BR_Comorbidity_Druginducedliverinjury_Code ;
      private bool[] BC00093_n568BR_Comorbidity_Druginducedliverinjury_Code ;
      private long[] BC00093_A19BR_EncounterID ;
      private long[] BC00092_A37BR_ComorbidityID ;
      private String[] BC00092_A487BR_Comorbidity_Hypertension_Code ;
      private bool[] BC00092_n487BR_Comorbidity_Hypertension_Code ;
      private String[] BC00092_A488BR_Comorbidity_Diabetes_Code ;
      private bool[] BC00092_n488BR_Comorbidity_Diabetes_Code ;
      private String[] BC00092_A489BR_Comorbidity_CHD_Code ;
      private bool[] BC00092_n489BR_Comorbidity_CHD_Code ;
      private String[] BC00092_A490BR_Comorbidity_Hapetitis_Code ;
      private bool[] BC00092_n490BR_Comorbidity_Hapetitis_Code ;
      private String[] BC00092_A491BR_Comorbidity_TB_Code ;
      private bool[] BC00092_n491BR_Comorbidity_TB_Code ;
      private String[] BC00092_A492BR_Comorbidity_KidneyDisease_Code ;
      private bool[] BC00092_n492BR_Comorbidity_KidneyDisease_Code ;
      private String[] BC00092_A493BR_Comorbidity_SurgeryHistory_Code ;
      private bool[] BC00092_n493BR_Comorbidity_SurgeryHistory_Code ;
      private String[] BC00092_A494BR_Comorbidity_InjuryHistory_Code ;
      private bool[] BC00092_n494BR_Comorbidity_InjuryHistory_Code ;
      private String[] BC00092_A495BR_Comorbidity_BloodHistory_Code ;
      private bool[] BC00092_n495BR_Comorbidity_BloodHistory_Code ;
      private String[] BC00092_A496BR_Comorbidity_allergy_Code ;
      private bool[] BC00092_n496BR_Comorbidity_allergy_Code ;
      private String[] BC00092_A38BR_Comorbidity_Hypertension ;
      private bool[] BC00092_n38BR_Comorbidity_Hypertension ;
      private String[] BC00092_A39BR_Comorbidity_Diabetes ;
      private bool[] BC00092_n39BR_Comorbidity_Diabetes ;
      private String[] BC00092_A40BR_Comorbidity_CHD ;
      private bool[] BC00092_n40BR_Comorbidity_CHD ;
      private String[] BC00092_A41BR_Comorbidity_Hapetitis ;
      private bool[] BC00092_n41BR_Comorbidity_Hapetitis ;
      private String[] BC00092_A42BR_Comorbidity_TB ;
      private bool[] BC00092_n42BR_Comorbidity_TB ;
      private String[] BC00092_A43BR_Comorbidity_KidneyDisease ;
      private bool[] BC00092_n43BR_Comorbidity_KidneyDisease ;
      private String[] BC00092_A44BR_Comorbidity_SurgeryHistory ;
      private bool[] BC00092_n44BR_Comorbidity_SurgeryHistory ;
      private String[] BC00092_A45BR_Comorbidity_InjuryHistory ;
      private bool[] BC00092_n45BR_Comorbidity_InjuryHistory ;
      private String[] BC00092_A46BR_Comorbidity_BloodHistory ;
      private bool[] BC00092_n46BR_Comorbidity_BloodHistory ;
      private String[] BC00092_A47BR_Comorbidity_allergy ;
      private bool[] BC00092_n47BR_Comorbidity_allergy ;
      private String[] BC00092_A259BR_Comorbidity_Others ;
      private bool[] BC00092_n259BR_Comorbidity_Others ;
      private String[] BC00092_A561BR_Comorbidity_HapetitisB ;
      private bool[] BC00092_n561BR_Comorbidity_HapetitisB ;
      private String[] BC00092_A562BR_Comorbidity_HapetitisB_Code ;
      private bool[] BC00092_n562BR_Comorbidity_HapetitisB_Code ;
      private String[] BC00092_A563BR_Comorbidity_HapetitisC ;
      private bool[] BC00092_n563BR_Comorbidity_HapetitisC ;
      private String[] BC00092_A564BR_Comorbidity_HapetitisC_Code ;
      private bool[] BC00092_n564BR_Comorbidity_HapetitisC_Code ;
      private String[] BC00092_A565BR_Comorbidity_LiverCirrhosis ;
      private bool[] BC00092_n565BR_Comorbidity_LiverCirrhosis ;
      private String[] BC00092_A566BR_Comorbidity_LiverCirrhosis_Code ;
      private bool[] BC00092_n566BR_Comorbidity_LiverCirrhosis_Code ;
      private String[] BC00092_A567BR_Comorbidity_Druginducedliverinjury ;
      private bool[] BC00092_n567BR_Comorbidity_Druginducedliverinjury ;
      private String[] BC00092_A568BR_Comorbidity_Druginducedliverinjury_Code ;
      private bool[] BC00092_n568BR_Comorbidity_Druginducedliverinjury_Code ;
      private long[] BC00092_A19BR_EncounterID ;
      private long[] BC00098_A37BR_ComorbidityID ;
      private long[] BC000911_A85BR_Information_ID ;
      private bool[] BC000911_n85BR_Information_ID ;
      private String[] BC000912_A36BR_Information_PatientNo ;
      private bool[] BC000912_n36BR_Information_PatientNo ;
      private long[] BC000913_A85BR_Information_ID ;
      private bool[] BC000913_n85BR_Information_ID ;
      private long[] BC000913_A37BR_ComorbidityID ;
      private String[] BC000913_A487BR_Comorbidity_Hypertension_Code ;
      private bool[] BC000913_n487BR_Comorbidity_Hypertension_Code ;
      private String[] BC000913_A488BR_Comorbidity_Diabetes_Code ;
      private bool[] BC000913_n488BR_Comorbidity_Diabetes_Code ;
      private String[] BC000913_A489BR_Comorbidity_CHD_Code ;
      private bool[] BC000913_n489BR_Comorbidity_CHD_Code ;
      private String[] BC000913_A490BR_Comorbidity_Hapetitis_Code ;
      private bool[] BC000913_n490BR_Comorbidity_Hapetitis_Code ;
      private String[] BC000913_A491BR_Comorbidity_TB_Code ;
      private bool[] BC000913_n491BR_Comorbidity_TB_Code ;
      private String[] BC000913_A492BR_Comorbidity_KidneyDisease_Code ;
      private bool[] BC000913_n492BR_Comorbidity_KidneyDisease_Code ;
      private String[] BC000913_A493BR_Comorbidity_SurgeryHistory_Code ;
      private bool[] BC000913_n493BR_Comorbidity_SurgeryHistory_Code ;
      private String[] BC000913_A494BR_Comorbidity_InjuryHistory_Code ;
      private bool[] BC000913_n494BR_Comorbidity_InjuryHistory_Code ;
      private String[] BC000913_A495BR_Comorbidity_BloodHistory_Code ;
      private bool[] BC000913_n495BR_Comorbidity_BloodHistory_Code ;
      private String[] BC000913_A496BR_Comorbidity_allergy_Code ;
      private bool[] BC000913_n496BR_Comorbidity_allergy_Code ;
      private String[] BC000913_A36BR_Information_PatientNo ;
      private bool[] BC000913_n36BR_Information_PatientNo ;
      private String[] BC000913_A38BR_Comorbidity_Hypertension ;
      private bool[] BC000913_n38BR_Comorbidity_Hypertension ;
      private String[] BC000913_A39BR_Comorbidity_Diabetes ;
      private bool[] BC000913_n39BR_Comorbidity_Diabetes ;
      private String[] BC000913_A40BR_Comorbidity_CHD ;
      private bool[] BC000913_n40BR_Comorbidity_CHD ;
      private String[] BC000913_A41BR_Comorbidity_Hapetitis ;
      private bool[] BC000913_n41BR_Comorbidity_Hapetitis ;
      private String[] BC000913_A42BR_Comorbidity_TB ;
      private bool[] BC000913_n42BR_Comorbidity_TB ;
      private String[] BC000913_A43BR_Comorbidity_KidneyDisease ;
      private bool[] BC000913_n43BR_Comorbidity_KidneyDisease ;
      private String[] BC000913_A44BR_Comorbidity_SurgeryHistory ;
      private bool[] BC000913_n44BR_Comorbidity_SurgeryHistory ;
      private String[] BC000913_A45BR_Comorbidity_InjuryHistory ;
      private bool[] BC000913_n45BR_Comorbidity_InjuryHistory ;
      private String[] BC000913_A46BR_Comorbidity_BloodHistory ;
      private bool[] BC000913_n46BR_Comorbidity_BloodHistory ;
      private String[] BC000913_A47BR_Comorbidity_allergy ;
      private bool[] BC000913_n47BR_Comorbidity_allergy ;
      private String[] BC000913_A259BR_Comorbidity_Others ;
      private bool[] BC000913_n259BR_Comorbidity_Others ;
      private String[] BC000913_A561BR_Comorbidity_HapetitisB ;
      private bool[] BC000913_n561BR_Comorbidity_HapetitisB ;
      private String[] BC000913_A562BR_Comorbidity_HapetitisB_Code ;
      private bool[] BC000913_n562BR_Comorbidity_HapetitisB_Code ;
      private String[] BC000913_A563BR_Comorbidity_HapetitisC ;
      private bool[] BC000913_n563BR_Comorbidity_HapetitisC ;
      private String[] BC000913_A564BR_Comorbidity_HapetitisC_Code ;
      private bool[] BC000913_n564BR_Comorbidity_HapetitisC_Code ;
      private String[] BC000913_A565BR_Comorbidity_LiverCirrhosis ;
      private bool[] BC000913_n565BR_Comorbidity_LiverCirrhosis ;
      private String[] BC000913_A566BR_Comorbidity_LiverCirrhosis_Code ;
      private bool[] BC000913_n566BR_Comorbidity_LiverCirrhosis_Code ;
      private String[] BC000913_A567BR_Comorbidity_Druginducedliverinjury ;
      private bool[] BC000913_n567BR_Comorbidity_Druginducedliverinjury ;
      private String[] BC000913_A568BR_Comorbidity_Druginducedliverinjury_Code ;
      private bool[] BC000913_n568BR_Comorbidity_Druginducedliverinjury_Code ;
      private long[] BC000913_A19BR_EncounterID ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_datastore1 ;
   }

   public class br_comorbidity_bc__datastore1 : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          def= new CursorDef[] {
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
       }
    }

    public String getDataStoreName( )
    {
       return "DATASTORE1";
    }

 }

 public class br_comorbidity_bc__default : DataStoreHelperBase, IDataStoreHelper
 {
    public ICursor[] getCursors( )
    {
       cursorDefinitions();
       return new Cursor[] {
        new ForEachCursor(def[0])
       ,new ForEachCursor(def[1])
       ,new ForEachCursor(def[2])
       ,new ForEachCursor(def[3])
       ,new ForEachCursor(def[4])
       ,new ForEachCursor(def[5])
       ,new ForEachCursor(def[6])
       ,new UpdateCursor(def[7])
       ,new UpdateCursor(def[8])
       ,new ForEachCursor(def[9])
       ,new ForEachCursor(def[10])
       ,new ForEachCursor(def[11])
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmBC00096 ;
        prmBC00096 = new Object[] {
        new Object[] {"@BR_ComorbidityID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00094 ;
        prmBC00094 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00095 ;
        prmBC00095 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00097 ;
        prmBC00097 = new Object[] {
        new Object[] {"@BR_ComorbidityID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00093 ;
        prmBC00093 = new Object[] {
        new Object[] {"@BR_ComorbidityID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00092 ;
        prmBC00092 = new Object[] {
        new Object[] {"@BR_ComorbidityID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00098 ;
        prmBC00098 = new Object[] {
        new Object[] {"@BR_Comorbidity_Hypertension_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_Diabetes_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_CHD_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_Hapetitis_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_TB_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_KidneyDisease_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_SurgeryHistory_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_InjuryHistory_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_BloodHistory_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_allergy_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_Hypertension",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_Diabetes",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_CHD",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_Hapetitis",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_TB",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_KidneyDisease",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_SurgeryHistory",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_InjuryHistory",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_BloodHistory",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_allergy",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_Others",SqlDbType.NVarChar,255,0} ,
        new Object[] {"@BR_Comorbidity_HapetitisB",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_HapetitisB_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_HapetitisC",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_HapetitisC_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_LiverCirrhosis",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_LiverCirrhosis_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_Druginducedliverinjury",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_Druginducedliverinjury_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        String cmdBufferBC00098 ;
        cmdBufferBC00098=" INSERT INTO [BR_Comorbidity]([BR_Comorbidity_Hypertension_Code], [BR_Comorbidity_Diabetes_Code], [BR_Comorbidity_CHD_Code], [BR_Comorbidity_Hapetitis_Code], [BR_Comorbidity_TB_Code], [BR_Comorbidity_KidneyDisease_Code], [BR_Comorbidity_SurgeryHistory_Code], [BR_Comorbidity_InjuryHistory_Code], [BR_Comorbidity_BloodHistory_Code], [BR_Comorbidity_allergy_Code], [BR_Comorbidity_Hypertension], [BR_Comorbidity_Diabetes], [BR_Comorbidity_CHD], [BR_Comorbidity_Hapetitis], [BR_Comorbidity_TB], [BR_Comorbidity_KidneyDisease], [BR_Comorbidity_SurgeryHistory], [BR_Comorbidity_InjuryHistory], [BR_Comorbidity_BloodHistory], [BR_Comorbidity_allergy], [BR_Comorbidity_Others], [BR_Comorbidity_HapetitisB], [BR_Comorbidity_HapetitisB_Code], [BR_Comorbidity_HapetitisC], [BR_Comorbidity_HapetitisC_Code], [BR_Comorbidity_LiverCirrhosis], [BR_Comorbidity_LiverCirrhosis_Code], [BR_Comorbidity_Druginducedliverinjury], [BR_Comorbidity_Druginducedliverinjury_Code], [BR_EncounterID]) VALUES(@BR_Comorbidity_Hypertension_Code, @BR_Comorbidity_Diabetes_Code, @BR_Comorbidity_CHD_Code, @BR_Comorbidity_Hapetitis_Code, @BR_Comorbidity_TB_Code, @BR_Comorbidity_KidneyDisease_Code, @BR_Comorbidity_SurgeryHistory_Code, @BR_Comorbidity_InjuryHistory_Code, @BR_Comorbidity_BloodHistory_Code, @BR_Comorbidity_allergy_Code, @BR_Comorbidity_Hypertension, @BR_Comorbidity_Diabetes, @BR_Comorbidity_CHD, @BR_Comorbidity_Hapetitis, @BR_Comorbidity_TB, @BR_Comorbidity_KidneyDisease, @BR_Comorbidity_SurgeryHistory, @BR_Comorbidity_InjuryHistory, @BR_Comorbidity_BloodHistory, @BR_Comorbidity_allergy, @BR_Comorbidity_Others, @BR_Comorbidity_HapetitisB, @BR_Comorbidity_HapetitisB_Code, @BR_Comorbidity_HapetitisC, @BR_Comorbidity_HapetitisC_Code, @BR_Comorbidity_LiverCirrhosis, @BR_Comorbidity_LiverCirrhosis_Code, @BR_Comorbidity_Druginducedliverinjury, "
        + " @BR_Comorbidity_Druginducedliverinjury_Code, @BR_EncounterID); SELECT SCOPE_IDENTITY()" ;
        Object[] prmBC00099 ;
        prmBC00099 = new Object[] {
        new Object[] {"@BR_Comorbidity_Hypertension_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_Diabetes_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_CHD_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_Hapetitis_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_TB_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_KidneyDisease_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_SurgeryHistory_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_InjuryHistory_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_BloodHistory_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_allergy_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_Hypertension",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_Diabetes",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_CHD",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_Hapetitis",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_TB",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_KidneyDisease",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_SurgeryHistory",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_InjuryHistory",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_BloodHistory",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_allergy",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_Others",SqlDbType.NVarChar,255,0} ,
        new Object[] {"@BR_Comorbidity_HapetitisB",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_HapetitisB_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_HapetitisC",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_HapetitisC_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_LiverCirrhosis",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_LiverCirrhosis_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_Druginducedliverinjury",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_Druginducedliverinjury_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_ComorbidityID",SqlDbType.Decimal,18,0}
        } ;
        String cmdBufferBC00099 ;
        cmdBufferBC00099=" UPDATE [BR_Comorbidity] SET [BR_Comorbidity_Hypertension_Code]=@BR_Comorbidity_Hypertension_Code, [BR_Comorbidity_Diabetes_Code]=@BR_Comorbidity_Diabetes_Code, [BR_Comorbidity_CHD_Code]=@BR_Comorbidity_CHD_Code, [BR_Comorbidity_Hapetitis_Code]=@BR_Comorbidity_Hapetitis_Code, [BR_Comorbidity_TB_Code]=@BR_Comorbidity_TB_Code, [BR_Comorbidity_KidneyDisease_Code]=@BR_Comorbidity_KidneyDisease_Code, [BR_Comorbidity_SurgeryHistory_Code]=@BR_Comorbidity_SurgeryHistory_Code, [BR_Comorbidity_InjuryHistory_Code]=@BR_Comorbidity_InjuryHistory_Code, [BR_Comorbidity_BloodHistory_Code]=@BR_Comorbidity_BloodHistory_Code, [BR_Comorbidity_allergy_Code]=@BR_Comorbidity_allergy_Code, [BR_Comorbidity_Hypertension]=@BR_Comorbidity_Hypertension, [BR_Comorbidity_Diabetes]=@BR_Comorbidity_Diabetes, [BR_Comorbidity_CHD]=@BR_Comorbidity_CHD, [BR_Comorbidity_Hapetitis]=@BR_Comorbidity_Hapetitis, [BR_Comorbidity_TB]=@BR_Comorbidity_TB, [BR_Comorbidity_KidneyDisease]=@BR_Comorbidity_KidneyDisease, [BR_Comorbidity_SurgeryHistory]=@BR_Comorbidity_SurgeryHistory, [BR_Comorbidity_InjuryHistory]=@BR_Comorbidity_InjuryHistory, [BR_Comorbidity_BloodHistory]=@BR_Comorbidity_BloodHistory, [BR_Comorbidity_allergy]=@BR_Comorbidity_allergy, [BR_Comorbidity_Others]=@BR_Comorbidity_Others, [BR_Comorbidity_HapetitisB]=@BR_Comorbidity_HapetitisB, [BR_Comorbidity_HapetitisB_Code]=@BR_Comorbidity_HapetitisB_Code, [BR_Comorbidity_HapetitisC]=@BR_Comorbidity_HapetitisC, [BR_Comorbidity_HapetitisC_Code]=@BR_Comorbidity_HapetitisC_Code, [BR_Comorbidity_LiverCirrhosis]=@BR_Comorbidity_LiverCirrhosis, [BR_Comorbidity_LiverCirrhosis_Code]=@BR_Comorbidity_LiverCirrhosis_Code, [BR_Comorbidity_Druginducedliverinjury]=@BR_Comorbidity_Druginducedliverinjury, [BR_Comorbidity_Druginducedliverinjury_Code]=@BR_Comorbidity_Druginducedliverinjury_Code, "
        + " [BR_EncounterID]=@BR_EncounterID  WHERE [BR_ComorbidityID] = @BR_ComorbidityID" ;
        Object[] prmBC000910 ;
        prmBC000910 = new Object[] {
        new Object[] {"@BR_ComorbidityID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000911 ;
        prmBC000911 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000912 ;
        prmBC000912 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000913 ;
        prmBC000913 = new Object[] {
        new Object[] {"@BR_ComorbidityID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("BC00092", "SELECT [BR_ComorbidityID], [BR_Comorbidity_Hypertension_Code], [BR_Comorbidity_Diabetes_Code], [BR_Comorbidity_CHD_Code], [BR_Comorbidity_Hapetitis_Code], [BR_Comorbidity_TB_Code], [BR_Comorbidity_KidneyDisease_Code], [BR_Comorbidity_SurgeryHistory_Code], [BR_Comorbidity_InjuryHistory_Code], [BR_Comorbidity_BloodHistory_Code], [BR_Comorbidity_allergy_Code], [BR_Comorbidity_Hypertension], [BR_Comorbidity_Diabetes], [BR_Comorbidity_CHD], [BR_Comorbidity_Hapetitis], [BR_Comorbidity_TB], [BR_Comorbidity_KidneyDisease], [BR_Comorbidity_SurgeryHistory], [BR_Comorbidity_InjuryHistory], [BR_Comorbidity_BloodHistory], [BR_Comorbidity_allergy], [BR_Comorbidity_Others], [BR_Comorbidity_HapetitisB], [BR_Comorbidity_HapetitisB_Code], [BR_Comorbidity_HapetitisC], [BR_Comorbidity_HapetitisC_Code], [BR_Comorbidity_LiverCirrhosis], [BR_Comorbidity_LiverCirrhosis_Code], [BR_Comorbidity_Druginducedliverinjury], [BR_Comorbidity_Druginducedliverinjury_Code], [BR_EncounterID] FROM [BR_Comorbidity] WITH (UPDLOCK) WHERE [BR_ComorbidityID] = @BR_ComorbidityID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00092,1,0,true,false )
           ,new CursorDef("BC00093", "SELECT [BR_ComorbidityID], [BR_Comorbidity_Hypertension_Code], [BR_Comorbidity_Diabetes_Code], [BR_Comorbidity_CHD_Code], [BR_Comorbidity_Hapetitis_Code], [BR_Comorbidity_TB_Code], [BR_Comorbidity_KidneyDisease_Code], [BR_Comorbidity_SurgeryHistory_Code], [BR_Comorbidity_InjuryHistory_Code], [BR_Comorbidity_BloodHistory_Code], [BR_Comorbidity_allergy_Code], [BR_Comorbidity_Hypertension], [BR_Comorbidity_Diabetes], [BR_Comorbidity_CHD], [BR_Comorbidity_Hapetitis], [BR_Comorbidity_TB], [BR_Comorbidity_KidneyDisease], [BR_Comorbidity_SurgeryHistory], [BR_Comorbidity_InjuryHistory], [BR_Comorbidity_BloodHistory], [BR_Comorbidity_allergy], [BR_Comorbidity_Others], [BR_Comorbidity_HapetitisB], [BR_Comorbidity_HapetitisB_Code], [BR_Comorbidity_HapetitisC], [BR_Comorbidity_HapetitisC_Code], [BR_Comorbidity_LiverCirrhosis], [BR_Comorbidity_LiverCirrhosis_Code], [BR_Comorbidity_Druginducedliverinjury], [BR_Comorbidity_Druginducedliverinjury_Code], [BR_EncounterID] FROM [BR_Comorbidity] WITH (NOLOCK) WHERE [BR_ComorbidityID] = @BR_ComorbidityID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00093,1,0,true,false )
           ,new CursorDef("BC00094", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00094,1,0,true,false )
           ,new CursorDef("BC00095", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00095,1,0,true,false )
           ,new CursorDef("BC00096", "SELECT T2.[BR_Information_ID], TM1.[BR_ComorbidityID], TM1.[BR_Comorbidity_Hypertension_Code], TM1.[BR_Comorbidity_Diabetes_Code], TM1.[BR_Comorbidity_CHD_Code], TM1.[BR_Comorbidity_Hapetitis_Code], TM1.[BR_Comorbidity_TB_Code], TM1.[BR_Comorbidity_KidneyDisease_Code], TM1.[BR_Comorbidity_SurgeryHistory_Code], TM1.[BR_Comorbidity_InjuryHistory_Code], TM1.[BR_Comorbidity_BloodHistory_Code], TM1.[BR_Comorbidity_allergy_Code], T3.[BR_Information_PatientNo], TM1.[BR_Comorbidity_Hypertension], TM1.[BR_Comorbidity_Diabetes], TM1.[BR_Comorbidity_CHD], TM1.[BR_Comorbidity_Hapetitis], TM1.[BR_Comorbidity_TB], TM1.[BR_Comorbidity_KidneyDisease], TM1.[BR_Comorbidity_SurgeryHistory], TM1.[BR_Comorbidity_InjuryHistory], TM1.[BR_Comorbidity_BloodHistory], TM1.[BR_Comorbidity_allergy], TM1.[BR_Comorbidity_Others], TM1.[BR_Comorbidity_HapetitisB], TM1.[BR_Comorbidity_HapetitisB_Code], TM1.[BR_Comorbidity_HapetitisC], TM1.[BR_Comorbidity_HapetitisC_Code], TM1.[BR_Comorbidity_LiverCirrhosis], TM1.[BR_Comorbidity_LiverCirrhosis_Code], TM1.[BR_Comorbidity_Druginducedliverinjury], TM1.[BR_Comorbidity_Druginducedliverinjury_Code], TM1.[BR_EncounterID] FROM (([BR_Comorbidity] TM1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = TM1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID]) WHERE TM1.[BR_ComorbidityID] = @BR_ComorbidityID ORDER BY TM1.[BR_ComorbidityID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00096,100,0,true,false )
           ,new CursorDef("BC00097", "SELECT [BR_ComorbidityID] FROM [BR_Comorbidity] WITH (NOLOCK) WHERE [BR_ComorbidityID] = @BR_ComorbidityID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00097,1,0,true,false )
           ,new CursorDef("BC00098", cmdBufferBC00098, GxErrorMask.GX_NOMASK,prmBC00098)
           ,new CursorDef("BC00099", cmdBufferBC00099, GxErrorMask.GX_NOMASK,prmBC00099)
           ,new CursorDef("BC000910", "DELETE FROM [BR_Comorbidity]  WHERE [BR_ComorbidityID] = @BR_ComorbidityID", GxErrorMask.GX_NOMASK,prmBC000910)
           ,new CursorDef("BC000911", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000911,1,0,true,false )
           ,new CursorDef("BC000912", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000912,1,0,true,false )
           ,new CursorDef("BC000913", "SELECT T2.[BR_Information_ID], TM1.[BR_ComorbidityID], TM1.[BR_Comorbidity_Hypertension_Code], TM1.[BR_Comorbidity_Diabetes_Code], TM1.[BR_Comorbidity_CHD_Code], TM1.[BR_Comorbidity_Hapetitis_Code], TM1.[BR_Comorbidity_TB_Code], TM1.[BR_Comorbidity_KidneyDisease_Code], TM1.[BR_Comorbidity_SurgeryHistory_Code], TM1.[BR_Comorbidity_InjuryHistory_Code], TM1.[BR_Comorbidity_BloodHistory_Code], TM1.[BR_Comorbidity_allergy_Code], T3.[BR_Information_PatientNo], TM1.[BR_Comorbidity_Hypertension], TM1.[BR_Comorbidity_Diabetes], TM1.[BR_Comorbidity_CHD], TM1.[BR_Comorbidity_Hapetitis], TM1.[BR_Comorbidity_TB], TM1.[BR_Comorbidity_KidneyDisease], TM1.[BR_Comorbidity_SurgeryHistory], TM1.[BR_Comorbidity_InjuryHistory], TM1.[BR_Comorbidity_BloodHistory], TM1.[BR_Comorbidity_allergy], TM1.[BR_Comorbidity_Others], TM1.[BR_Comorbidity_HapetitisB], TM1.[BR_Comorbidity_HapetitisB_Code], TM1.[BR_Comorbidity_HapetitisC], TM1.[BR_Comorbidity_HapetitisC_Code], TM1.[BR_Comorbidity_LiverCirrhosis], TM1.[BR_Comorbidity_LiverCirrhosis_Code], TM1.[BR_Comorbidity_Druginducedliverinjury], TM1.[BR_Comorbidity_Druginducedliverinjury_Code], TM1.[BR_EncounterID] FROM (([BR_Comorbidity] TM1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = TM1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID]) WHERE TM1.[BR_ComorbidityID] = @BR_ComorbidityID ORDER BY TM1.[BR_ComorbidityID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000913,100,0,true,false )
        };
     }
  }

  public void getResults( int cursor ,
                          IFieldGetter rslt ,
                          Object[] buf )
  {
     switch ( cursor )
     {
           case 0 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((String[]) buf[17])[0] = rslt.getVarchar(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              ((String[]) buf[19])[0] = rslt.getVarchar(11) ;
              ((bool[]) buf[20])[0] = rslt.wasNull(11);
              ((String[]) buf[21])[0] = rslt.getVarchar(12) ;
              ((bool[]) buf[22])[0] = rslt.wasNull(12);
              ((String[]) buf[23])[0] = rslt.getVarchar(13) ;
              ((bool[]) buf[24])[0] = rslt.wasNull(13);
              ((String[]) buf[25])[0] = rslt.getVarchar(14) ;
              ((bool[]) buf[26])[0] = rslt.wasNull(14);
              ((String[]) buf[27])[0] = rslt.getVarchar(15) ;
              ((bool[]) buf[28])[0] = rslt.wasNull(15);
              ((String[]) buf[29])[0] = rslt.getVarchar(16) ;
              ((bool[]) buf[30])[0] = rslt.wasNull(16);
              ((String[]) buf[31])[0] = rslt.getVarchar(17) ;
              ((bool[]) buf[32])[0] = rslt.wasNull(17);
              ((String[]) buf[33])[0] = rslt.getVarchar(18) ;
              ((bool[]) buf[34])[0] = rslt.wasNull(18);
              ((String[]) buf[35])[0] = rslt.getVarchar(19) ;
              ((bool[]) buf[36])[0] = rslt.wasNull(19);
              ((String[]) buf[37])[0] = rslt.getVarchar(20) ;
              ((bool[]) buf[38])[0] = rslt.wasNull(20);
              ((String[]) buf[39])[0] = rslt.getVarchar(21) ;
              ((bool[]) buf[40])[0] = rslt.wasNull(21);
              ((String[]) buf[41])[0] = rslt.getVarchar(22) ;
              ((bool[]) buf[42])[0] = rslt.wasNull(22);
              ((String[]) buf[43])[0] = rslt.getVarchar(23) ;
              ((bool[]) buf[44])[0] = rslt.wasNull(23);
              ((String[]) buf[45])[0] = rslt.getVarchar(24) ;
              ((bool[]) buf[46])[0] = rslt.wasNull(24);
              ((String[]) buf[47])[0] = rslt.getVarchar(25) ;
              ((bool[]) buf[48])[0] = rslt.wasNull(25);
              ((String[]) buf[49])[0] = rslt.getVarchar(26) ;
              ((bool[]) buf[50])[0] = rslt.wasNull(26);
              ((String[]) buf[51])[0] = rslt.getVarchar(27) ;
              ((bool[]) buf[52])[0] = rslt.wasNull(27);
              ((String[]) buf[53])[0] = rslt.getVarchar(28) ;
              ((bool[]) buf[54])[0] = rslt.wasNull(28);
              ((String[]) buf[55])[0] = rslt.getVarchar(29) ;
              ((bool[]) buf[56])[0] = rslt.wasNull(29);
              ((String[]) buf[57])[0] = rslt.getVarchar(30) ;
              ((bool[]) buf[58])[0] = rslt.wasNull(30);
              ((long[]) buf[59])[0] = rslt.getLong(31) ;
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((String[]) buf[17])[0] = rslt.getVarchar(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              ((String[]) buf[19])[0] = rslt.getVarchar(11) ;
              ((bool[]) buf[20])[0] = rslt.wasNull(11);
              ((String[]) buf[21])[0] = rslt.getVarchar(12) ;
              ((bool[]) buf[22])[0] = rslt.wasNull(12);
              ((String[]) buf[23])[0] = rslt.getVarchar(13) ;
              ((bool[]) buf[24])[0] = rslt.wasNull(13);
              ((String[]) buf[25])[0] = rslt.getVarchar(14) ;
              ((bool[]) buf[26])[0] = rslt.wasNull(14);
              ((String[]) buf[27])[0] = rslt.getVarchar(15) ;
              ((bool[]) buf[28])[0] = rslt.wasNull(15);
              ((String[]) buf[29])[0] = rslt.getVarchar(16) ;
              ((bool[]) buf[30])[0] = rslt.wasNull(16);
              ((String[]) buf[31])[0] = rslt.getVarchar(17) ;
              ((bool[]) buf[32])[0] = rslt.wasNull(17);
              ((String[]) buf[33])[0] = rslt.getVarchar(18) ;
              ((bool[]) buf[34])[0] = rslt.wasNull(18);
              ((String[]) buf[35])[0] = rslt.getVarchar(19) ;
              ((bool[]) buf[36])[0] = rslt.wasNull(19);
              ((String[]) buf[37])[0] = rslt.getVarchar(20) ;
              ((bool[]) buf[38])[0] = rslt.wasNull(20);
              ((String[]) buf[39])[0] = rslt.getVarchar(21) ;
              ((bool[]) buf[40])[0] = rslt.wasNull(21);
              ((String[]) buf[41])[0] = rslt.getVarchar(22) ;
              ((bool[]) buf[42])[0] = rslt.wasNull(22);
              ((String[]) buf[43])[0] = rslt.getVarchar(23) ;
              ((bool[]) buf[44])[0] = rslt.wasNull(23);
              ((String[]) buf[45])[0] = rslt.getVarchar(24) ;
              ((bool[]) buf[46])[0] = rslt.wasNull(24);
              ((String[]) buf[47])[0] = rslt.getVarchar(25) ;
              ((bool[]) buf[48])[0] = rslt.wasNull(25);
              ((String[]) buf[49])[0] = rslt.getVarchar(26) ;
              ((bool[]) buf[50])[0] = rslt.wasNull(26);
              ((String[]) buf[51])[0] = rslt.getVarchar(27) ;
              ((bool[]) buf[52])[0] = rslt.wasNull(27);
              ((String[]) buf[53])[0] = rslt.getVarchar(28) ;
              ((bool[]) buf[54])[0] = rslt.wasNull(28);
              ((String[]) buf[55])[0] = rslt.getVarchar(29) ;
              ((bool[]) buf[56])[0] = rslt.wasNull(29);
              ((String[]) buf[57])[0] = rslt.getVarchar(30) ;
              ((bool[]) buf[58])[0] = rslt.wasNull(30);
              ((long[]) buf[59])[0] = rslt.getLong(31) ;
              return;
           case 2 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              return;
           case 3 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              return;
           case 4 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              ((long[]) buf[2])[0] = rslt.getLong(2) ;
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((String[]) buf[17])[0] = rslt.getVarchar(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              ((String[]) buf[19])[0] = rslt.getVarchar(11) ;
              ((bool[]) buf[20])[0] = rslt.wasNull(11);
              ((String[]) buf[21])[0] = rslt.getVarchar(12) ;
              ((bool[]) buf[22])[0] = rslt.wasNull(12);
              ((String[]) buf[23])[0] = rslt.getVarchar(13) ;
              ((bool[]) buf[24])[0] = rslt.wasNull(13);
              ((String[]) buf[25])[0] = rslt.getVarchar(14) ;
              ((bool[]) buf[26])[0] = rslt.wasNull(14);
              ((String[]) buf[27])[0] = rslt.getVarchar(15) ;
              ((bool[]) buf[28])[0] = rslt.wasNull(15);
              ((String[]) buf[29])[0] = rslt.getVarchar(16) ;
              ((bool[]) buf[30])[0] = rslt.wasNull(16);
              ((String[]) buf[31])[0] = rslt.getVarchar(17) ;
              ((bool[]) buf[32])[0] = rslt.wasNull(17);
              ((String[]) buf[33])[0] = rslt.getVarchar(18) ;
              ((bool[]) buf[34])[0] = rslt.wasNull(18);
              ((String[]) buf[35])[0] = rslt.getVarchar(19) ;
              ((bool[]) buf[36])[0] = rslt.wasNull(19);
              ((String[]) buf[37])[0] = rslt.getVarchar(20) ;
              ((bool[]) buf[38])[0] = rslt.wasNull(20);
              ((String[]) buf[39])[0] = rslt.getVarchar(21) ;
              ((bool[]) buf[40])[0] = rslt.wasNull(21);
              ((String[]) buf[41])[0] = rslt.getVarchar(22) ;
              ((bool[]) buf[42])[0] = rslt.wasNull(22);
              ((String[]) buf[43])[0] = rslt.getVarchar(23) ;
              ((bool[]) buf[44])[0] = rslt.wasNull(23);
              ((String[]) buf[45])[0] = rslt.getVarchar(24) ;
              ((bool[]) buf[46])[0] = rslt.wasNull(24);
              ((String[]) buf[47])[0] = rslt.getVarchar(25) ;
              ((bool[]) buf[48])[0] = rslt.wasNull(25);
              ((String[]) buf[49])[0] = rslt.getVarchar(26) ;
              ((bool[]) buf[50])[0] = rslt.wasNull(26);
              ((String[]) buf[51])[0] = rslt.getVarchar(27) ;
              ((bool[]) buf[52])[0] = rslt.wasNull(27);
              ((String[]) buf[53])[0] = rslt.getVarchar(28) ;
              ((bool[]) buf[54])[0] = rslt.wasNull(28);
              ((String[]) buf[55])[0] = rslt.getVarchar(29) ;
              ((bool[]) buf[56])[0] = rslt.wasNull(29);
              ((String[]) buf[57])[0] = rslt.getVarchar(30) ;
              ((bool[]) buf[58])[0] = rslt.wasNull(30);
              ((String[]) buf[59])[0] = rslt.getVarchar(31) ;
              ((bool[]) buf[60])[0] = rslt.wasNull(31);
              ((String[]) buf[61])[0] = rslt.getVarchar(32) ;
              ((bool[]) buf[62])[0] = rslt.wasNull(32);
              ((long[]) buf[63])[0] = rslt.getLong(33) ;
              return;
           case 5 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 6 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 9 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              return;
           case 10 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              return;
           case 11 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              ((long[]) buf[2])[0] = rslt.getLong(2) ;
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((String[]) buf[17])[0] = rslt.getVarchar(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              ((String[]) buf[19])[0] = rslt.getVarchar(11) ;
              ((bool[]) buf[20])[0] = rslt.wasNull(11);
              ((String[]) buf[21])[0] = rslt.getVarchar(12) ;
              ((bool[]) buf[22])[0] = rslt.wasNull(12);
              ((String[]) buf[23])[0] = rslt.getVarchar(13) ;
              ((bool[]) buf[24])[0] = rslt.wasNull(13);
              ((String[]) buf[25])[0] = rslt.getVarchar(14) ;
              ((bool[]) buf[26])[0] = rslt.wasNull(14);
              ((String[]) buf[27])[0] = rslt.getVarchar(15) ;
              ((bool[]) buf[28])[0] = rslt.wasNull(15);
              ((String[]) buf[29])[0] = rslt.getVarchar(16) ;
              ((bool[]) buf[30])[0] = rslt.wasNull(16);
              ((String[]) buf[31])[0] = rslt.getVarchar(17) ;
              ((bool[]) buf[32])[0] = rslt.wasNull(17);
              ((String[]) buf[33])[0] = rslt.getVarchar(18) ;
              ((bool[]) buf[34])[0] = rslt.wasNull(18);
              ((String[]) buf[35])[0] = rslt.getVarchar(19) ;
              ((bool[]) buf[36])[0] = rslt.wasNull(19);
              ((String[]) buf[37])[0] = rslt.getVarchar(20) ;
              ((bool[]) buf[38])[0] = rslt.wasNull(20);
              ((String[]) buf[39])[0] = rslt.getVarchar(21) ;
              ((bool[]) buf[40])[0] = rslt.wasNull(21);
              ((String[]) buf[41])[0] = rslt.getVarchar(22) ;
              ((bool[]) buf[42])[0] = rslt.wasNull(22);
              ((String[]) buf[43])[0] = rslt.getVarchar(23) ;
              ((bool[]) buf[44])[0] = rslt.wasNull(23);
              ((String[]) buf[45])[0] = rslt.getVarchar(24) ;
              ((bool[]) buf[46])[0] = rslt.wasNull(24);
              ((String[]) buf[47])[0] = rslt.getVarchar(25) ;
              ((bool[]) buf[48])[0] = rslt.wasNull(25);
              ((String[]) buf[49])[0] = rslt.getVarchar(26) ;
              ((bool[]) buf[50])[0] = rslt.wasNull(26);
              ((String[]) buf[51])[0] = rslt.getVarchar(27) ;
              ((bool[]) buf[52])[0] = rslt.wasNull(27);
              ((String[]) buf[53])[0] = rslt.getVarchar(28) ;
              ((bool[]) buf[54])[0] = rslt.wasNull(28);
              ((String[]) buf[55])[0] = rslt.getVarchar(29) ;
              ((bool[]) buf[56])[0] = rslt.wasNull(29);
              ((String[]) buf[57])[0] = rslt.getVarchar(30) ;
              ((bool[]) buf[58])[0] = rslt.wasNull(30);
              ((String[]) buf[59])[0] = rslt.getVarchar(31) ;
              ((bool[]) buf[60])[0] = rslt.wasNull(31);
              ((String[]) buf[61])[0] = rslt.getVarchar(32) ;
              ((bool[]) buf[62])[0] = rslt.wasNull(32);
              ((long[]) buf[63])[0] = rslt.getLong(33) ;
              return;
     }
  }

  public void setParameters( int cursor ,
                             IFieldSetter stmt ,
                             Object[] parms )
  {
     switch ( cursor )
     {
           case 0 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 1 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 2 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 3 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 4 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 5 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 6 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(1, (String)parms[1]);
              }
              if ( (bool)parms[2] )
              {
                 stmt.setNull( 2 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(2, (String)parms[3]);
              }
              if ( (bool)parms[4] )
              {
                 stmt.setNull( 3 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(3, (String)parms[5]);
              }
              if ( (bool)parms[6] )
              {
                 stmt.setNull( 4 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(4, (String)parms[7]);
              }
              if ( (bool)parms[8] )
              {
                 stmt.setNull( 5 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(5, (String)parms[9]);
              }
              if ( (bool)parms[10] )
              {
                 stmt.setNull( 6 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(6, (String)parms[11]);
              }
              if ( (bool)parms[12] )
              {
                 stmt.setNull( 7 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(7, (String)parms[13]);
              }
              if ( (bool)parms[14] )
              {
                 stmt.setNull( 8 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(8, (String)parms[15]);
              }
              if ( (bool)parms[16] )
              {
                 stmt.setNull( 9 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(9, (String)parms[17]);
              }
              if ( (bool)parms[18] )
              {
                 stmt.setNull( 10 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(10, (String)parms[19]);
              }
              if ( (bool)parms[20] )
              {
                 stmt.setNull( 11 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(11, (String)parms[21]);
              }
              if ( (bool)parms[22] )
              {
                 stmt.setNull( 12 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(12, (String)parms[23]);
              }
              if ( (bool)parms[24] )
              {
                 stmt.setNull( 13 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(13, (String)parms[25]);
              }
              if ( (bool)parms[26] )
              {
                 stmt.setNull( 14 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(14, (String)parms[27]);
              }
              if ( (bool)parms[28] )
              {
                 stmt.setNull( 15 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(15, (String)parms[29]);
              }
              if ( (bool)parms[30] )
              {
                 stmt.setNull( 16 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(16, (String)parms[31]);
              }
              if ( (bool)parms[32] )
              {
                 stmt.setNull( 17 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(17, (String)parms[33]);
              }
              if ( (bool)parms[34] )
              {
                 stmt.setNull( 18 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(18, (String)parms[35]);
              }
              if ( (bool)parms[36] )
              {
                 stmt.setNull( 19 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(19, (String)parms[37]);
              }
              if ( (bool)parms[38] )
              {
                 stmt.setNull( 20 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(20, (String)parms[39]);
              }
              if ( (bool)parms[40] )
              {
                 stmt.setNull( 21 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(21, (String)parms[41]);
              }
              if ( (bool)parms[42] )
              {
                 stmt.setNull( 22 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(22, (String)parms[43]);
              }
              if ( (bool)parms[44] )
              {
                 stmt.setNull( 23 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(23, (String)parms[45]);
              }
              if ( (bool)parms[46] )
              {
                 stmt.setNull( 24 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(24, (String)parms[47]);
              }
              if ( (bool)parms[48] )
              {
                 stmt.setNull( 25 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(25, (String)parms[49]);
              }
              if ( (bool)parms[50] )
              {
                 stmt.setNull( 26 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(26, (String)parms[51]);
              }
              if ( (bool)parms[52] )
              {
                 stmt.setNull( 27 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(27, (String)parms[53]);
              }
              if ( (bool)parms[54] )
              {
                 stmt.setNull( 28 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(28, (String)parms[55]);
              }
              if ( (bool)parms[56] )
              {
                 stmt.setNull( 29 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(29, (String)parms[57]);
              }
              stmt.SetParameter(30, (long)parms[58]);
              return;
           case 7 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(1, (String)parms[1]);
              }
              if ( (bool)parms[2] )
              {
                 stmt.setNull( 2 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(2, (String)parms[3]);
              }
              if ( (bool)parms[4] )
              {
                 stmt.setNull( 3 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(3, (String)parms[5]);
              }
              if ( (bool)parms[6] )
              {
                 stmt.setNull( 4 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(4, (String)parms[7]);
              }
              if ( (bool)parms[8] )
              {
                 stmt.setNull( 5 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(5, (String)parms[9]);
              }
              if ( (bool)parms[10] )
              {
                 stmt.setNull( 6 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(6, (String)parms[11]);
              }
              if ( (bool)parms[12] )
              {
                 stmt.setNull( 7 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(7, (String)parms[13]);
              }
              if ( (bool)parms[14] )
              {
                 stmt.setNull( 8 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(8, (String)parms[15]);
              }
              if ( (bool)parms[16] )
              {
                 stmt.setNull( 9 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(9, (String)parms[17]);
              }
              if ( (bool)parms[18] )
              {
                 stmt.setNull( 10 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(10, (String)parms[19]);
              }
              if ( (bool)parms[20] )
              {
                 stmt.setNull( 11 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(11, (String)parms[21]);
              }
              if ( (bool)parms[22] )
              {
                 stmt.setNull( 12 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(12, (String)parms[23]);
              }
              if ( (bool)parms[24] )
              {
                 stmt.setNull( 13 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(13, (String)parms[25]);
              }
              if ( (bool)parms[26] )
              {
                 stmt.setNull( 14 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(14, (String)parms[27]);
              }
              if ( (bool)parms[28] )
              {
                 stmt.setNull( 15 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(15, (String)parms[29]);
              }
              if ( (bool)parms[30] )
              {
                 stmt.setNull( 16 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(16, (String)parms[31]);
              }
              if ( (bool)parms[32] )
              {
                 stmt.setNull( 17 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(17, (String)parms[33]);
              }
              if ( (bool)parms[34] )
              {
                 stmt.setNull( 18 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(18, (String)parms[35]);
              }
              if ( (bool)parms[36] )
              {
                 stmt.setNull( 19 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(19, (String)parms[37]);
              }
              if ( (bool)parms[38] )
              {
                 stmt.setNull( 20 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(20, (String)parms[39]);
              }
              if ( (bool)parms[40] )
              {
                 stmt.setNull( 21 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(21, (String)parms[41]);
              }
              if ( (bool)parms[42] )
              {
                 stmt.setNull( 22 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(22, (String)parms[43]);
              }
              if ( (bool)parms[44] )
              {
                 stmt.setNull( 23 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(23, (String)parms[45]);
              }
              if ( (bool)parms[46] )
              {
                 stmt.setNull( 24 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(24, (String)parms[47]);
              }
              if ( (bool)parms[48] )
              {
                 stmt.setNull( 25 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(25, (String)parms[49]);
              }
              if ( (bool)parms[50] )
              {
                 stmt.setNull( 26 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(26, (String)parms[51]);
              }
              if ( (bool)parms[52] )
              {
                 stmt.setNull( 27 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(27, (String)parms[53]);
              }
              if ( (bool)parms[54] )
              {
                 stmt.setNull( 28 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(28, (String)parms[55]);
              }
              if ( (bool)parms[56] )
              {
                 stmt.setNull( 29 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(29, (String)parms[57]);
              }
              stmt.SetParameter(30, (long)parms[58]);
              stmt.SetParameter(31, (long)parms[59]);
              return;
           case 8 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 9 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 10 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 11 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
     }
  }

}

}
