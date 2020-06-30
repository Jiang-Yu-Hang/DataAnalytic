/*
               File: BR_Behavior_BC
        Description: 个人史
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:6:37.94
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
   public class br_behavior_bc : GXHttpHandler, IGxSilentTrn
   {
      public br_behavior_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_behavior_bc( IGxContext context )
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
         ReadRow089( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey089( ) ;
         standaloneModal( ) ;
         AddRow089( ) ;
         Gx_mode = "INS";
         return  ;
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E11082 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               Z20BR_BehaviorID = A20BR_BehaviorID;
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

      protected void CONFIRM_080( )
      {
         BeforeValidate089( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls089( ) ;
            }
            else
            {
               CheckExtendedTable089( ) ;
               if ( AnyError == 0 )
               {
                  ZM089( 12) ;
                  ZM089( 13) ;
               }
               CloseExtendedTableCursors089( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void E12082( )
      {
         /* Start Routine */
      }

      protected void E11082( )
      {
         /* After Trn Routine */
      }

      protected void ZM089( short GX_JID )
      {
         if ( ( GX_JID == 11 ) || ( GX_JID == 0 ) )
         {
            Z460BR_Behavior_Smoking_Code = A460BR_Behavior_Smoking_Code;
            Z462BR_Behavior_Achohol_Code = A462BR_Behavior_Achohol_Code;
            Z464BR_Behavior_FamilyCaHistory_Code = A464BR_Behavior_FamilyCaHistory_Code;
            Z465BR_Behavior_Menopause_Code = A465BR_Behavior_Menopause_Code;
            Z21BR_Behavior_Smoking = A21BR_Behavior_Smoking;
            Z22BR_Behavior_SmokingTime = A22BR_Behavior_SmokingTime;
            Z23BR_Behavior_SmokingAmount = A23BR_Behavior_SmokingAmount;
            Z24BR_Behavior_RawSmokingAmount = A24BR_Behavior_RawSmokingAmount;
            Z461BR_Behavior_RawSmokingAmount_Code = A461BR_Behavior_RawSmokingAmount_Code;
            Z25BR_Behavior_Achohol = A25BR_Behavior_Achohol;
            Z26BR_Behavior_AchoholTime = A26BR_Behavior_AchoholTime;
            Z27BR_Behavior_AchoholAmount = A27BR_Behavior_AchoholAmount;
            Z28BR_Behavior_RawAchoholAmount = A28BR_Behavior_RawAchoholAmount;
            Z463BR_Behavior_RawAchoholAmount_Code = A463BR_Behavior_RawAchoholAmount_Code;
            Z29BR_Behavior_FamilyCaHistory = A29BR_Behavior_FamilyCaHistory;
            Z30BR_Behavior_FamilyCancer = A30BR_Behavior_FamilyCancer;
            Z31BR_Behavior_Menopause = A31BR_Behavior_Menopause;
            Z32BR_Behavior_MenopauseAge = A32BR_Behavior_MenopauseAge;
            Z33BR_Behavior_RawMenopauseAge = A33BR_Behavior_RawMenopauseAge;
            Z34BR_Behavior_ChildNum = A34BR_Behavior_ChildNum;
            Z19BR_EncounterID = A19BR_EncounterID;
         }
         if ( ( GX_JID == 12 ) || ( GX_JID == 0 ) )
         {
            Z85BR_Information_ID = A85BR_Information_ID;
         }
         if ( ( GX_JID == 13 ) || ( GX_JID == 0 ) )
         {
            Z36BR_Information_PatientNo = A36BR_Information_PatientNo;
         }
         if ( GX_JID == -11 )
         {
            Z20BR_BehaviorID = A20BR_BehaviorID;
            Z460BR_Behavior_Smoking_Code = A460BR_Behavior_Smoking_Code;
            Z462BR_Behavior_Achohol_Code = A462BR_Behavior_Achohol_Code;
            Z464BR_Behavior_FamilyCaHistory_Code = A464BR_Behavior_FamilyCaHistory_Code;
            Z465BR_Behavior_Menopause_Code = A465BR_Behavior_Menopause_Code;
            Z21BR_Behavior_Smoking = A21BR_Behavior_Smoking;
            Z22BR_Behavior_SmokingTime = A22BR_Behavior_SmokingTime;
            Z23BR_Behavior_SmokingAmount = A23BR_Behavior_SmokingAmount;
            Z24BR_Behavior_RawSmokingAmount = A24BR_Behavior_RawSmokingAmount;
            Z461BR_Behavior_RawSmokingAmount_Code = A461BR_Behavior_RawSmokingAmount_Code;
            Z25BR_Behavior_Achohol = A25BR_Behavior_Achohol;
            Z26BR_Behavior_AchoholTime = A26BR_Behavior_AchoholTime;
            Z27BR_Behavior_AchoholAmount = A27BR_Behavior_AchoholAmount;
            Z28BR_Behavior_RawAchoholAmount = A28BR_Behavior_RawAchoholAmount;
            Z463BR_Behavior_RawAchoholAmount_Code = A463BR_Behavior_RawAchoholAmount_Code;
            Z29BR_Behavior_FamilyCaHistory = A29BR_Behavior_FamilyCaHistory;
            Z30BR_Behavior_FamilyCancer = A30BR_Behavior_FamilyCancer;
            Z31BR_Behavior_Menopause = A31BR_Behavior_Menopause;
            Z32BR_Behavior_MenopauseAge = A32BR_Behavior_MenopauseAge;
            Z33BR_Behavior_RawMenopauseAge = A33BR_Behavior_RawMenopauseAge;
            Z34BR_Behavior_ChildNum = A34BR_Behavior_ChildNum;
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

      protected void Load089( )
      {
         /* Using cursor BC00086 */
         pr_default.execute(4, new Object[] {A20BR_BehaviorID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound9 = 1;
            A85BR_Information_ID = BC00086_A85BR_Information_ID[0];
            n85BR_Information_ID = BC00086_n85BR_Information_ID[0];
            A460BR_Behavior_Smoking_Code = BC00086_A460BR_Behavior_Smoking_Code[0];
            n460BR_Behavior_Smoking_Code = BC00086_n460BR_Behavior_Smoking_Code[0];
            A462BR_Behavior_Achohol_Code = BC00086_A462BR_Behavior_Achohol_Code[0];
            n462BR_Behavior_Achohol_Code = BC00086_n462BR_Behavior_Achohol_Code[0];
            A464BR_Behavior_FamilyCaHistory_Code = BC00086_A464BR_Behavior_FamilyCaHistory_Code[0];
            n464BR_Behavior_FamilyCaHistory_Code = BC00086_n464BR_Behavior_FamilyCaHistory_Code[0];
            A465BR_Behavior_Menopause_Code = BC00086_A465BR_Behavior_Menopause_Code[0];
            n465BR_Behavior_Menopause_Code = BC00086_n465BR_Behavior_Menopause_Code[0];
            A36BR_Information_PatientNo = BC00086_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = BC00086_n36BR_Information_PatientNo[0];
            A21BR_Behavior_Smoking = BC00086_A21BR_Behavior_Smoking[0];
            n21BR_Behavior_Smoking = BC00086_n21BR_Behavior_Smoking[0];
            A22BR_Behavior_SmokingTime = BC00086_A22BR_Behavior_SmokingTime[0];
            n22BR_Behavior_SmokingTime = BC00086_n22BR_Behavior_SmokingTime[0];
            A23BR_Behavior_SmokingAmount = BC00086_A23BR_Behavior_SmokingAmount[0];
            n23BR_Behavior_SmokingAmount = BC00086_n23BR_Behavior_SmokingAmount[0];
            A24BR_Behavior_RawSmokingAmount = BC00086_A24BR_Behavior_RawSmokingAmount[0];
            n24BR_Behavior_RawSmokingAmount = BC00086_n24BR_Behavior_RawSmokingAmount[0];
            A461BR_Behavior_RawSmokingAmount_Code = BC00086_A461BR_Behavior_RawSmokingAmount_Code[0];
            n461BR_Behavior_RawSmokingAmount_Code = BC00086_n461BR_Behavior_RawSmokingAmount_Code[0];
            A25BR_Behavior_Achohol = BC00086_A25BR_Behavior_Achohol[0];
            n25BR_Behavior_Achohol = BC00086_n25BR_Behavior_Achohol[0];
            A26BR_Behavior_AchoholTime = BC00086_A26BR_Behavior_AchoholTime[0];
            n26BR_Behavior_AchoholTime = BC00086_n26BR_Behavior_AchoholTime[0];
            A27BR_Behavior_AchoholAmount = BC00086_A27BR_Behavior_AchoholAmount[0];
            n27BR_Behavior_AchoholAmount = BC00086_n27BR_Behavior_AchoholAmount[0];
            A28BR_Behavior_RawAchoholAmount = BC00086_A28BR_Behavior_RawAchoholAmount[0];
            n28BR_Behavior_RawAchoholAmount = BC00086_n28BR_Behavior_RawAchoholAmount[0];
            A463BR_Behavior_RawAchoholAmount_Code = BC00086_A463BR_Behavior_RawAchoholAmount_Code[0];
            n463BR_Behavior_RawAchoholAmount_Code = BC00086_n463BR_Behavior_RawAchoholAmount_Code[0];
            A29BR_Behavior_FamilyCaHistory = BC00086_A29BR_Behavior_FamilyCaHistory[0];
            n29BR_Behavior_FamilyCaHistory = BC00086_n29BR_Behavior_FamilyCaHistory[0];
            A30BR_Behavior_FamilyCancer = BC00086_A30BR_Behavior_FamilyCancer[0];
            n30BR_Behavior_FamilyCancer = BC00086_n30BR_Behavior_FamilyCancer[0];
            A31BR_Behavior_Menopause = BC00086_A31BR_Behavior_Menopause[0];
            n31BR_Behavior_Menopause = BC00086_n31BR_Behavior_Menopause[0];
            A32BR_Behavior_MenopauseAge = BC00086_A32BR_Behavior_MenopauseAge[0];
            n32BR_Behavior_MenopauseAge = BC00086_n32BR_Behavior_MenopauseAge[0];
            A33BR_Behavior_RawMenopauseAge = BC00086_A33BR_Behavior_RawMenopauseAge[0];
            n33BR_Behavior_RawMenopauseAge = BC00086_n33BR_Behavior_RawMenopauseAge[0];
            A34BR_Behavior_ChildNum = BC00086_A34BR_Behavior_ChildNum[0];
            n34BR_Behavior_ChildNum = BC00086_n34BR_Behavior_ChildNum[0];
            A19BR_EncounterID = BC00086_A19BR_EncounterID[0];
            ZM089( -11) ;
         }
         pr_default.close(4);
         OnLoadActions089( ) ;
      }

      protected void OnLoadActions089( )
      {
      }

      protected void CheckExtendedTable089( )
      {
         standaloneModal( ) ;
         /* Using cursor BC00084 */
         pr_default.execute(2, new Object[] {A19BR_EncounterID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("不匹配' T15'", "ForeignKeyNotFound", 1, "BR_ENCOUNTERID");
            AnyError = 1;
         }
         A85BR_Information_ID = BC00084_A85BR_Information_ID[0];
         n85BR_Information_ID = BC00084_n85BR_Information_ID[0];
         pr_default.close(2);
         /* Using cursor BC00085 */
         pr_default.execute(3, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
         if ( (pr_default.getStatus(3) == 101) )
         {
            if ( ! ( (0==A85BR_Information_ID) ) )
            {
               GX_msglist.addItem("不匹配' T16'", "ForeignKeyNotFound", 1, "");
               AnyError = 1;
            }
         }
         A36BR_Information_PatientNo = BC00085_A36BR_Information_PatientNo[0];
         n36BR_Information_PatientNo = BC00085_n36BR_Information_PatientNo[0];
         pr_default.close(3);
         if ( ! ( ( StringUtil.StrCmp(A29BR_Behavior_FamilyCaHistory, "否") == 0 ) || ( StringUtil.StrCmp(A29BR_Behavior_FamilyCaHistory, "是") == 0 ) || ( StringUtil.StrCmp(A29BR_Behavior_FamilyCaHistory, "不详") == 0 ) || String.IsNullOrEmpty(StringUtil.RTrim( A29BR_Behavior_FamilyCaHistory)) ) )
         {
            GX_msglist.addItem("域是否有家族肿瘤史超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
         if ( ! ( ( StringUtil.StrCmp(A31BR_Behavior_Menopause, "否") == 0 ) || ( StringUtil.StrCmp(A31BR_Behavior_Menopause, "是") == 0 ) || ( StringUtil.StrCmp(A31BR_Behavior_Menopause, "不详") == 0 ) || String.IsNullOrEmpty(StringUtil.RTrim( A31BR_Behavior_Menopause)) ) )
         {
            GX_msglist.addItem("域是否绝经超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
      }

      protected void CloseExtendedTableCursors089( )
      {
         pr_default.close(2);
         pr_default.close(3);
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey089( )
      {
         /* Using cursor BC00087 */
         pr_default.execute(5, new Object[] {A20BR_BehaviorID});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound9 = 1;
         }
         else
         {
            RcdFound9 = 0;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC00083 */
         pr_default.execute(1, new Object[] {A20BR_BehaviorID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM089( 11) ;
            RcdFound9 = 1;
            A20BR_BehaviorID = BC00083_A20BR_BehaviorID[0];
            A460BR_Behavior_Smoking_Code = BC00083_A460BR_Behavior_Smoking_Code[0];
            n460BR_Behavior_Smoking_Code = BC00083_n460BR_Behavior_Smoking_Code[0];
            A462BR_Behavior_Achohol_Code = BC00083_A462BR_Behavior_Achohol_Code[0];
            n462BR_Behavior_Achohol_Code = BC00083_n462BR_Behavior_Achohol_Code[0];
            A464BR_Behavior_FamilyCaHistory_Code = BC00083_A464BR_Behavior_FamilyCaHistory_Code[0];
            n464BR_Behavior_FamilyCaHistory_Code = BC00083_n464BR_Behavior_FamilyCaHistory_Code[0];
            A465BR_Behavior_Menopause_Code = BC00083_A465BR_Behavior_Menopause_Code[0];
            n465BR_Behavior_Menopause_Code = BC00083_n465BR_Behavior_Menopause_Code[0];
            A21BR_Behavior_Smoking = BC00083_A21BR_Behavior_Smoking[0];
            n21BR_Behavior_Smoking = BC00083_n21BR_Behavior_Smoking[0];
            A22BR_Behavior_SmokingTime = BC00083_A22BR_Behavior_SmokingTime[0];
            n22BR_Behavior_SmokingTime = BC00083_n22BR_Behavior_SmokingTime[0];
            A23BR_Behavior_SmokingAmount = BC00083_A23BR_Behavior_SmokingAmount[0];
            n23BR_Behavior_SmokingAmount = BC00083_n23BR_Behavior_SmokingAmount[0];
            A24BR_Behavior_RawSmokingAmount = BC00083_A24BR_Behavior_RawSmokingAmount[0];
            n24BR_Behavior_RawSmokingAmount = BC00083_n24BR_Behavior_RawSmokingAmount[0];
            A461BR_Behavior_RawSmokingAmount_Code = BC00083_A461BR_Behavior_RawSmokingAmount_Code[0];
            n461BR_Behavior_RawSmokingAmount_Code = BC00083_n461BR_Behavior_RawSmokingAmount_Code[0];
            A25BR_Behavior_Achohol = BC00083_A25BR_Behavior_Achohol[0];
            n25BR_Behavior_Achohol = BC00083_n25BR_Behavior_Achohol[0];
            A26BR_Behavior_AchoholTime = BC00083_A26BR_Behavior_AchoholTime[0];
            n26BR_Behavior_AchoholTime = BC00083_n26BR_Behavior_AchoholTime[0];
            A27BR_Behavior_AchoholAmount = BC00083_A27BR_Behavior_AchoholAmount[0];
            n27BR_Behavior_AchoholAmount = BC00083_n27BR_Behavior_AchoholAmount[0];
            A28BR_Behavior_RawAchoholAmount = BC00083_A28BR_Behavior_RawAchoholAmount[0];
            n28BR_Behavior_RawAchoholAmount = BC00083_n28BR_Behavior_RawAchoholAmount[0];
            A463BR_Behavior_RawAchoholAmount_Code = BC00083_A463BR_Behavior_RawAchoholAmount_Code[0];
            n463BR_Behavior_RawAchoholAmount_Code = BC00083_n463BR_Behavior_RawAchoholAmount_Code[0];
            A29BR_Behavior_FamilyCaHistory = BC00083_A29BR_Behavior_FamilyCaHistory[0];
            n29BR_Behavior_FamilyCaHistory = BC00083_n29BR_Behavior_FamilyCaHistory[0];
            A30BR_Behavior_FamilyCancer = BC00083_A30BR_Behavior_FamilyCancer[0];
            n30BR_Behavior_FamilyCancer = BC00083_n30BR_Behavior_FamilyCancer[0];
            A31BR_Behavior_Menopause = BC00083_A31BR_Behavior_Menopause[0];
            n31BR_Behavior_Menopause = BC00083_n31BR_Behavior_Menopause[0];
            A32BR_Behavior_MenopauseAge = BC00083_A32BR_Behavior_MenopauseAge[0];
            n32BR_Behavior_MenopauseAge = BC00083_n32BR_Behavior_MenopauseAge[0];
            A33BR_Behavior_RawMenopauseAge = BC00083_A33BR_Behavior_RawMenopauseAge[0];
            n33BR_Behavior_RawMenopauseAge = BC00083_n33BR_Behavior_RawMenopauseAge[0];
            A34BR_Behavior_ChildNum = BC00083_A34BR_Behavior_ChildNum[0];
            n34BR_Behavior_ChildNum = BC00083_n34BR_Behavior_ChildNum[0];
            A19BR_EncounterID = BC00083_A19BR_EncounterID[0];
            Z20BR_BehaviorID = A20BR_BehaviorID;
            sMode9 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load089( ) ;
            if ( AnyError == 1 )
            {
               RcdFound9 = 0;
               InitializeNonKey089( ) ;
            }
            Gx_mode = sMode9;
         }
         else
         {
            RcdFound9 = 0;
            InitializeNonKey089( ) ;
            sMode9 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode9;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey089( ) ;
         if ( RcdFound9 == 0 )
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
         CONFIRM_080( ) ;
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

      protected void CheckOptimisticConcurrency089( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC00082 */
            pr_default.execute(0, new Object[] {A20BR_BehaviorID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Behavior"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z460BR_Behavior_Smoking_Code, BC00082_A460BR_Behavior_Smoking_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z462BR_Behavior_Achohol_Code, BC00082_A462BR_Behavior_Achohol_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z464BR_Behavior_FamilyCaHistory_Code, BC00082_A464BR_Behavior_FamilyCaHistory_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z465BR_Behavior_Menopause_Code, BC00082_A465BR_Behavior_Menopause_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z21BR_Behavior_Smoking, BC00082_A21BR_Behavior_Smoking[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z22BR_Behavior_SmokingTime, BC00082_A22BR_Behavior_SmokingTime[0]) != 0 ) || ( StringUtil.StrCmp(Z23BR_Behavior_SmokingAmount, BC00082_A23BR_Behavior_SmokingAmount[0]) != 0 ) || ( StringUtil.StrCmp(Z24BR_Behavior_RawSmokingAmount, BC00082_A24BR_Behavior_RawSmokingAmount[0]) != 0 ) || ( StringUtil.StrCmp(Z461BR_Behavior_RawSmokingAmount_Code, BC00082_A461BR_Behavior_RawSmokingAmount_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z25BR_Behavior_Achohol, BC00082_A25BR_Behavior_Achohol[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z26BR_Behavior_AchoholTime, BC00082_A26BR_Behavior_AchoholTime[0]) != 0 ) || ( StringUtil.StrCmp(Z27BR_Behavior_AchoholAmount, BC00082_A27BR_Behavior_AchoholAmount[0]) != 0 ) || ( StringUtil.StrCmp(Z28BR_Behavior_RawAchoholAmount, BC00082_A28BR_Behavior_RawAchoholAmount[0]) != 0 ) || ( StringUtil.StrCmp(Z463BR_Behavior_RawAchoholAmount_Code, BC00082_A463BR_Behavior_RawAchoholAmount_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z29BR_Behavior_FamilyCaHistory, BC00082_A29BR_Behavior_FamilyCaHistory[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z30BR_Behavior_FamilyCancer, BC00082_A30BR_Behavior_FamilyCancer[0]) != 0 ) || ( StringUtil.StrCmp(Z31BR_Behavior_Menopause, BC00082_A31BR_Behavior_Menopause[0]) != 0 ) || ( Z32BR_Behavior_MenopauseAge != BC00082_A32BR_Behavior_MenopauseAge[0] ) || ( StringUtil.StrCmp(Z33BR_Behavior_RawMenopauseAge, BC00082_A33BR_Behavior_RawMenopauseAge[0]) != 0 ) || ( StringUtil.StrCmp(Z34BR_Behavior_ChildNum, BC00082_A34BR_Behavior_ChildNum[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z19BR_EncounterID != BC00082_A19BR_EncounterID[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"BR_Behavior"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert089( )
      {
         BeforeValidate089( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable089( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM089( 0) ;
            CheckOptimisticConcurrency089( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm089( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert089( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00088 */
                     pr_default.execute(6, new Object[] {n460BR_Behavior_Smoking_Code, A460BR_Behavior_Smoking_Code, n462BR_Behavior_Achohol_Code, A462BR_Behavior_Achohol_Code, n464BR_Behavior_FamilyCaHistory_Code, A464BR_Behavior_FamilyCaHistory_Code, n465BR_Behavior_Menopause_Code, A465BR_Behavior_Menopause_Code, n21BR_Behavior_Smoking, A21BR_Behavior_Smoking, n22BR_Behavior_SmokingTime, A22BR_Behavior_SmokingTime, n23BR_Behavior_SmokingAmount, A23BR_Behavior_SmokingAmount, n24BR_Behavior_RawSmokingAmount, A24BR_Behavior_RawSmokingAmount, n461BR_Behavior_RawSmokingAmount_Code, A461BR_Behavior_RawSmokingAmount_Code, n25BR_Behavior_Achohol, A25BR_Behavior_Achohol, n26BR_Behavior_AchoholTime, A26BR_Behavior_AchoholTime, n27BR_Behavior_AchoholAmount, A27BR_Behavior_AchoholAmount, n28BR_Behavior_RawAchoholAmount, A28BR_Behavior_RawAchoholAmount, n463BR_Behavior_RawAchoholAmount_Code, A463BR_Behavior_RawAchoholAmount_Code, n29BR_Behavior_FamilyCaHistory, A29BR_Behavior_FamilyCaHistory, n30BR_Behavior_FamilyCancer, A30BR_Behavior_FamilyCancer, n31BR_Behavior_Menopause, A31BR_Behavior_Menopause, n32BR_Behavior_MenopauseAge, A32BR_Behavior_MenopauseAge, n33BR_Behavior_RawMenopauseAge, A33BR_Behavior_RawMenopauseAge, n34BR_Behavior_ChildNum, A34BR_Behavior_ChildNum, A19BR_EncounterID});
                     A20BR_BehaviorID = BC00088_A20BR_BehaviorID[0];
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Behavior") ;
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
               Load089( ) ;
            }
            EndLevel089( ) ;
         }
         CloseExtendedTableCursors089( ) ;
      }

      protected void Update089( )
      {
         BeforeValidate089( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable089( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency089( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm089( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate089( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00089 */
                     pr_default.execute(7, new Object[] {n460BR_Behavior_Smoking_Code, A460BR_Behavior_Smoking_Code, n462BR_Behavior_Achohol_Code, A462BR_Behavior_Achohol_Code, n464BR_Behavior_FamilyCaHistory_Code, A464BR_Behavior_FamilyCaHistory_Code, n465BR_Behavior_Menopause_Code, A465BR_Behavior_Menopause_Code, n21BR_Behavior_Smoking, A21BR_Behavior_Smoking, n22BR_Behavior_SmokingTime, A22BR_Behavior_SmokingTime, n23BR_Behavior_SmokingAmount, A23BR_Behavior_SmokingAmount, n24BR_Behavior_RawSmokingAmount, A24BR_Behavior_RawSmokingAmount, n461BR_Behavior_RawSmokingAmount_Code, A461BR_Behavior_RawSmokingAmount_Code, n25BR_Behavior_Achohol, A25BR_Behavior_Achohol, n26BR_Behavior_AchoholTime, A26BR_Behavior_AchoholTime, n27BR_Behavior_AchoholAmount, A27BR_Behavior_AchoholAmount, n28BR_Behavior_RawAchoholAmount, A28BR_Behavior_RawAchoholAmount, n463BR_Behavior_RawAchoholAmount_Code, A463BR_Behavior_RawAchoholAmount_Code, n29BR_Behavior_FamilyCaHistory, A29BR_Behavior_FamilyCaHistory, n30BR_Behavior_FamilyCancer, A30BR_Behavior_FamilyCancer, n31BR_Behavior_Menopause, A31BR_Behavior_Menopause, n32BR_Behavior_MenopauseAge, A32BR_Behavior_MenopauseAge, n33BR_Behavior_RawMenopauseAge, A33BR_Behavior_RawMenopauseAge, n34BR_Behavior_ChildNum, A34BR_Behavior_ChildNum, A19BR_EncounterID, A20BR_BehaviorID});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Behavior") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Behavior"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate089( ) ;
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
            EndLevel089( ) ;
         }
         CloseExtendedTableCursors089( ) ;
      }

      protected void DeferredUpdate089( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate089( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency089( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls089( ) ;
            AfterConfirm089( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete089( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC000810 */
                  pr_default.execute(8, new Object[] {A20BR_BehaviorID});
                  pr_default.close(8);
                  dsDefault.SmartCacheProvider.SetUpdated("BR_Behavior") ;
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
         sMode9 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel089( ) ;
         Gx_mode = sMode9;
      }

      protected void OnDeleteControls089( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor BC000811 */
            pr_default.execute(9, new Object[] {A19BR_EncounterID});
            A85BR_Information_ID = BC000811_A85BR_Information_ID[0];
            n85BR_Information_ID = BC000811_n85BR_Information_ID[0];
            pr_default.close(9);
            /* Using cursor BC000812 */
            pr_default.execute(10, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
            A36BR_Information_PatientNo = BC000812_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = BC000812_n36BR_Information_PatientNo[0];
            pr_default.close(10);
         }
      }

      protected void EndLevel089( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete089( ) ;
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

      public void ScanKeyStart089( )
      {
         /* Scan By routine */
         /* Using cursor BC000813 */
         pr_default.execute(11, new Object[] {A20BR_BehaviorID});
         RcdFound9 = 0;
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound9 = 1;
            A85BR_Information_ID = BC000813_A85BR_Information_ID[0];
            n85BR_Information_ID = BC000813_n85BR_Information_ID[0];
            A20BR_BehaviorID = BC000813_A20BR_BehaviorID[0];
            A460BR_Behavior_Smoking_Code = BC000813_A460BR_Behavior_Smoking_Code[0];
            n460BR_Behavior_Smoking_Code = BC000813_n460BR_Behavior_Smoking_Code[0];
            A462BR_Behavior_Achohol_Code = BC000813_A462BR_Behavior_Achohol_Code[0];
            n462BR_Behavior_Achohol_Code = BC000813_n462BR_Behavior_Achohol_Code[0];
            A464BR_Behavior_FamilyCaHistory_Code = BC000813_A464BR_Behavior_FamilyCaHistory_Code[0];
            n464BR_Behavior_FamilyCaHistory_Code = BC000813_n464BR_Behavior_FamilyCaHistory_Code[0];
            A465BR_Behavior_Menopause_Code = BC000813_A465BR_Behavior_Menopause_Code[0];
            n465BR_Behavior_Menopause_Code = BC000813_n465BR_Behavior_Menopause_Code[0];
            A36BR_Information_PatientNo = BC000813_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = BC000813_n36BR_Information_PatientNo[0];
            A21BR_Behavior_Smoking = BC000813_A21BR_Behavior_Smoking[0];
            n21BR_Behavior_Smoking = BC000813_n21BR_Behavior_Smoking[0];
            A22BR_Behavior_SmokingTime = BC000813_A22BR_Behavior_SmokingTime[0];
            n22BR_Behavior_SmokingTime = BC000813_n22BR_Behavior_SmokingTime[0];
            A23BR_Behavior_SmokingAmount = BC000813_A23BR_Behavior_SmokingAmount[0];
            n23BR_Behavior_SmokingAmount = BC000813_n23BR_Behavior_SmokingAmount[0];
            A24BR_Behavior_RawSmokingAmount = BC000813_A24BR_Behavior_RawSmokingAmount[0];
            n24BR_Behavior_RawSmokingAmount = BC000813_n24BR_Behavior_RawSmokingAmount[0];
            A461BR_Behavior_RawSmokingAmount_Code = BC000813_A461BR_Behavior_RawSmokingAmount_Code[0];
            n461BR_Behavior_RawSmokingAmount_Code = BC000813_n461BR_Behavior_RawSmokingAmount_Code[0];
            A25BR_Behavior_Achohol = BC000813_A25BR_Behavior_Achohol[0];
            n25BR_Behavior_Achohol = BC000813_n25BR_Behavior_Achohol[0];
            A26BR_Behavior_AchoholTime = BC000813_A26BR_Behavior_AchoholTime[0];
            n26BR_Behavior_AchoholTime = BC000813_n26BR_Behavior_AchoholTime[0];
            A27BR_Behavior_AchoholAmount = BC000813_A27BR_Behavior_AchoholAmount[0];
            n27BR_Behavior_AchoholAmount = BC000813_n27BR_Behavior_AchoholAmount[0];
            A28BR_Behavior_RawAchoholAmount = BC000813_A28BR_Behavior_RawAchoholAmount[0];
            n28BR_Behavior_RawAchoholAmount = BC000813_n28BR_Behavior_RawAchoholAmount[0];
            A463BR_Behavior_RawAchoholAmount_Code = BC000813_A463BR_Behavior_RawAchoholAmount_Code[0];
            n463BR_Behavior_RawAchoholAmount_Code = BC000813_n463BR_Behavior_RawAchoholAmount_Code[0];
            A29BR_Behavior_FamilyCaHistory = BC000813_A29BR_Behavior_FamilyCaHistory[0];
            n29BR_Behavior_FamilyCaHistory = BC000813_n29BR_Behavior_FamilyCaHistory[0];
            A30BR_Behavior_FamilyCancer = BC000813_A30BR_Behavior_FamilyCancer[0];
            n30BR_Behavior_FamilyCancer = BC000813_n30BR_Behavior_FamilyCancer[0];
            A31BR_Behavior_Menopause = BC000813_A31BR_Behavior_Menopause[0];
            n31BR_Behavior_Menopause = BC000813_n31BR_Behavior_Menopause[0];
            A32BR_Behavior_MenopauseAge = BC000813_A32BR_Behavior_MenopauseAge[0];
            n32BR_Behavior_MenopauseAge = BC000813_n32BR_Behavior_MenopauseAge[0];
            A33BR_Behavior_RawMenopauseAge = BC000813_A33BR_Behavior_RawMenopauseAge[0];
            n33BR_Behavior_RawMenopauseAge = BC000813_n33BR_Behavior_RawMenopauseAge[0];
            A34BR_Behavior_ChildNum = BC000813_A34BR_Behavior_ChildNum[0];
            n34BR_Behavior_ChildNum = BC000813_n34BR_Behavior_ChildNum[0];
            A19BR_EncounterID = BC000813_A19BR_EncounterID[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext089( )
      {
         /* Scan next routine */
         pr_default.readNext(11);
         RcdFound9 = 0;
         ScanKeyLoad089( ) ;
      }

      protected void ScanKeyLoad089( )
      {
         sMode9 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound9 = 1;
            A85BR_Information_ID = BC000813_A85BR_Information_ID[0];
            n85BR_Information_ID = BC000813_n85BR_Information_ID[0];
            A20BR_BehaviorID = BC000813_A20BR_BehaviorID[0];
            A460BR_Behavior_Smoking_Code = BC000813_A460BR_Behavior_Smoking_Code[0];
            n460BR_Behavior_Smoking_Code = BC000813_n460BR_Behavior_Smoking_Code[0];
            A462BR_Behavior_Achohol_Code = BC000813_A462BR_Behavior_Achohol_Code[0];
            n462BR_Behavior_Achohol_Code = BC000813_n462BR_Behavior_Achohol_Code[0];
            A464BR_Behavior_FamilyCaHistory_Code = BC000813_A464BR_Behavior_FamilyCaHistory_Code[0];
            n464BR_Behavior_FamilyCaHistory_Code = BC000813_n464BR_Behavior_FamilyCaHistory_Code[0];
            A465BR_Behavior_Menopause_Code = BC000813_A465BR_Behavior_Menopause_Code[0];
            n465BR_Behavior_Menopause_Code = BC000813_n465BR_Behavior_Menopause_Code[0];
            A36BR_Information_PatientNo = BC000813_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = BC000813_n36BR_Information_PatientNo[0];
            A21BR_Behavior_Smoking = BC000813_A21BR_Behavior_Smoking[0];
            n21BR_Behavior_Smoking = BC000813_n21BR_Behavior_Smoking[0];
            A22BR_Behavior_SmokingTime = BC000813_A22BR_Behavior_SmokingTime[0];
            n22BR_Behavior_SmokingTime = BC000813_n22BR_Behavior_SmokingTime[0];
            A23BR_Behavior_SmokingAmount = BC000813_A23BR_Behavior_SmokingAmount[0];
            n23BR_Behavior_SmokingAmount = BC000813_n23BR_Behavior_SmokingAmount[0];
            A24BR_Behavior_RawSmokingAmount = BC000813_A24BR_Behavior_RawSmokingAmount[0];
            n24BR_Behavior_RawSmokingAmount = BC000813_n24BR_Behavior_RawSmokingAmount[0];
            A461BR_Behavior_RawSmokingAmount_Code = BC000813_A461BR_Behavior_RawSmokingAmount_Code[0];
            n461BR_Behavior_RawSmokingAmount_Code = BC000813_n461BR_Behavior_RawSmokingAmount_Code[0];
            A25BR_Behavior_Achohol = BC000813_A25BR_Behavior_Achohol[0];
            n25BR_Behavior_Achohol = BC000813_n25BR_Behavior_Achohol[0];
            A26BR_Behavior_AchoholTime = BC000813_A26BR_Behavior_AchoholTime[0];
            n26BR_Behavior_AchoholTime = BC000813_n26BR_Behavior_AchoholTime[0];
            A27BR_Behavior_AchoholAmount = BC000813_A27BR_Behavior_AchoholAmount[0];
            n27BR_Behavior_AchoholAmount = BC000813_n27BR_Behavior_AchoholAmount[0];
            A28BR_Behavior_RawAchoholAmount = BC000813_A28BR_Behavior_RawAchoholAmount[0];
            n28BR_Behavior_RawAchoholAmount = BC000813_n28BR_Behavior_RawAchoholAmount[0];
            A463BR_Behavior_RawAchoholAmount_Code = BC000813_A463BR_Behavior_RawAchoholAmount_Code[0];
            n463BR_Behavior_RawAchoholAmount_Code = BC000813_n463BR_Behavior_RawAchoholAmount_Code[0];
            A29BR_Behavior_FamilyCaHistory = BC000813_A29BR_Behavior_FamilyCaHistory[0];
            n29BR_Behavior_FamilyCaHistory = BC000813_n29BR_Behavior_FamilyCaHistory[0];
            A30BR_Behavior_FamilyCancer = BC000813_A30BR_Behavior_FamilyCancer[0];
            n30BR_Behavior_FamilyCancer = BC000813_n30BR_Behavior_FamilyCancer[0];
            A31BR_Behavior_Menopause = BC000813_A31BR_Behavior_Menopause[0];
            n31BR_Behavior_Menopause = BC000813_n31BR_Behavior_Menopause[0];
            A32BR_Behavior_MenopauseAge = BC000813_A32BR_Behavior_MenopauseAge[0];
            n32BR_Behavior_MenopauseAge = BC000813_n32BR_Behavior_MenopauseAge[0];
            A33BR_Behavior_RawMenopauseAge = BC000813_A33BR_Behavior_RawMenopauseAge[0];
            n33BR_Behavior_RawMenopauseAge = BC000813_n33BR_Behavior_RawMenopauseAge[0];
            A34BR_Behavior_ChildNum = BC000813_A34BR_Behavior_ChildNum[0];
            n34BR_Behavior_ChildNum = BC000813_n34BR_Behavior_ChildNum[0];
            A19BR_EncounterID = BC000813_A19BR_EncounterID[0];
         }
         Gx_mode = sMode9;
      }

      protected void ScanKeyEnd089( )
      {
         pr_default.close(11);
      }

      protected void AfterConfirm089( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert089( )
      {
         /* Before Insert Rules */
         GXt_char1 = A460BR_Behavior_Smoking_Code;
         new zutil_findtargetcode(context ).execute(  12,  A21BR_Behavior_Smoking, out  GXt_char1) ;
         A460BR_Behavior_Smoking_Code = GXt_char1;
         n460BR_Behavior_Smoking_Code = false;
         GXt_char1 = A462BR_Behavior_Achohol_Code;
         new zutil_findtargetcode(context ).execute(  14,  A25BR_Behavior_Achohol, out  GXt_char1) ;
         A462BR_Behavior_Achohol_Code = GXt_char1;
         n462BR_Behavior_Achohol_Code = false;
         GXt_char1 = A464BR_Behavior_FamilyCaHistory_Code;
         new zutil_findtargetcode(context ).execute(  37,  A29BR_Behavior_FamilyCaHistory, out  GXt_char1) ;
         A464BR_Behavior_FamilyCaHistory_Code = GXt_char1;
         n464BR_Behavior_FamilyCaHistory_Code = false;
         GXt_char1 = A465BR_Behavior_Menopause_Code;
         new zutil_findtargetcode(context ).execute(  37,  A31BR_Behavior_Menopause, out  GXt_char1) ;
         A465BR_Behavior_Menopause_Code = GXt_char1;
         n465BR_Behavior_Menopause_Code = false;
      }

      protected void BeforeUpdate089( )
      {
         /* Before Update Rules */
         GXt_char1 = A460BR_Behavior_Smoking_Code;
         new zutil_findtargetcode(context ).execute(  12,  A21BR_Behavior_Smoking, out  GXt_char1) ;
         A460BR_Behavior_Smoking_Code = GXt_char1;
         n460BR_Behavior_Smoking_Code = false;
         GXt_char1 = A462BR_Behavior_Achohol_Code;
         new zutil_findtargetcode(context ).execute(  14,  A25BR_Behavior_Achohol, out  GXt_char1) ;
         A462BR_Behavior_Achohol_Code = GXt_char1;
         n462BR_Behavior_Achohol_Code = false;
         GXt_char1 = A464BR_Behavior_FamilyCaHistory_Code;
         new zutil_findtargetcode(context ).execute(  37,  A29BR_Behavior_FamilyCaHistory, out  GXt_char1) ;
         A464BR_Behavior_FamilyCaHistory_Code = GXt_char1;
         n464BR_Behavior_FamilyCaHistory_Code = false;
         GXt_char1 = A465BR_Behavior_Menopause_Code;
         new zutil_findtargetcode(context ).execute(  37,  A31BR_Behavior_Menopause, out  GXt_char1) ;
         A465BR_Behavior_Menopause_Code = GXt_char1;
         n465BR_Behavior_Menopause_Code = false;
      }

      protected void BeforeDelete089( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete089( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate089( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes089( )
      {
      }

      protected void send_integrity_lvl_hashes089( )
      {
      }

      protected void AddRow089( )
      {
         VarsToRow9( bcBR_Behavior) ;
      }

      protected void ReadRow089( )
      {
         RowToVars9( bcBR_Behavior, 1) ;
      }

      protected void InitializeNonKey089( )
      {
         A85BR_Information_ID = 0;
         n85BR_Information_ID = false;
         A460BR_Behavior_Smoking_Code = "";
         n460BR_Behavior_Smoking_Code = false;
         A462BR_Behavior_Achohol_Code = "";
         n462BR_Behavior_Achohol_Code = false;
         A464BR_Behavior_FamilyCaHistory_Code = "";
         n464BR_Behavior_FamilyCaHistory_Code = false;
         A465BR_Behavior_Menopause_Code = "";
         n465BR_Behavior_Menopause_Code = false;
         A19BR_EncounterID = 0;
         A36BR_Information_PatientNo = "";
         n36BR_Information_PatientNo = false;
         A21BR_Behavior_Smoking = "";
         n21BR_Behavior_Smoking = false;
         A22BR_Behavior_SmokingTime = "";
         n22BR_Behavior_SmokingTime = false;
         A23BR_Behavior_SmokingAmount = "";
         n23BR_Behavior_SmokingAmount = false;
         A24BR_Behavior_RawSmokingAmount = "";
         n24BR_Behavior_RawSmokingAmount = false;
         A461BR_Behavior_RawSmokingAmount_Code = "";
         n461BR_Behavior_RawSmokingAmount_Code = false;
         A25BR_Behavior_Achohol = "";
         n25BR_Behavior_Achohol = false;
         A26BR_Behavior_AchoholTime = "";
         n26BR_Behavior_AchoholTime = false;
         A27BR_Behavior_AchoholAmount = "";
         n27BR_Behavior_AchoholAmount = false;
         A28BR_Behavior_RawAchoholAmount = "";
         n28BR_Behavior_RawAchoholAmount = false;
         A463BR_Behavior_RawAchoholAmount_Code = "";
         n463BR_Behavior_RawAchoholAmount_Code = false;
         A29BR_Behavior_FamilyCaHistory = "";
         n29BR_Behavior_FamilyCaHistory = false;
         A30BR_Behavior_FamilyCancer = "";
         n30BR_Behavior_FamilyCancer = false;
         A31BR_Behavior_Menopause = "";
         n31BR_Behavior_Menopause = false;
         A32BR_Behavior_MenopauseAge = 0;
         n32BR_Behavior_MenopauseAge = false;
         A33BR_Behavior_RawMenopauseAge = "";
         n33BR_Behavior_RawMenopauseAge = false;
         A34BR_Behavior_ChildNum = "";
         n34BR_Behavior_ChildNum = false;
         Z460BR_Behavior_Smoking_Code = "";
         Z462BR_Behavior_Achohol_Code = "";
         Z464BR_Behavior_FamilyCaHistory_Code = "";
         Z465BR_Behavior_Menopause_Code = "";
         Z21BR_Behavior_Smoking = "";
         Z22BR_Behavior_SmokingTime = "";
         Z23BR_Behavior_SmokingAmount = "";
         Z24BR_Behavior_RawSmokingAmount = "";
         Z461BR_Behavior_RawSmokingAmount_Code = "";
         Z25BR_Behavior_Achohol = "";
         Z26BR_Behavior_AchoholTime = "";
         Z27BR_Behavior_AchoholAmount = "";
         Z28BR_Behavior_RawAchoholAmount = "";
         Z463BR_Behavior_RawAchoholAmount_Code = "";
         Z29BR_Behavior_FamilyCaHistory = "";
         Z30BR_Behavior_FamilyCancer = "";
         Z31BR_Behavior_Menopause = "";
         Z32BR_Behavior_MenopauseAge = 0;
         Z33BR_Behavior_RawMenopauseAge = "";
         Z34BR_Behavior_ChildNum = "";
         Z19BR_EncounterID = 0;
      }

      protected void InitAll089( )
      {
         A20BR_BehaviorID = 0;
         InitializeNonKey089( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow9( SdtBR_Behavior obj9 )
      {
         obj9.gxTpr_Mode = Gx_mode;
         obj9.gxTpr_Br_behavior_smoking_code = A460BR_Behavior_Smoking_Code;
         obj9.gxTpr_Br_behavior_achohol_code = A462BR_Behavior_Achohol_Code;
         obj9.gxTpr_Br_behavior_familycahistory_code = A464BR_Behavior_FamilyCaHistory_Code;
         obj9.gxTpr_Br_behavior_menopause_code = A465BR_Behavior_Menopause_Code;
         obj9.gxTpr_Br_encounterid = A19BR_EncounterID;
         obj9.gxTpr_Br_information_patientno = A36BR_Information_PatientNo;
         obj9.gxTpr_Br_behavior_smoking = A21BR_Behavior_Smoking;
         obj9.gxTpr_Br_behavior_smokingtime = A22BR_Behavior_SmokingTime;
         obj9.gxTpr_Br_behavior_smokingamount = A23BR_Behavior_SmokingAmount;
         obj9.gxTpr_Br_behavior_rawsmokingamount = A24BR_Behavior_RawSmokingAmount;
         obj9.gxTpr_Br_behavior_rawsmokingamount_code = A461BR_Behavior_RawSmokingAmount_Code;
         obj9.gxTpr_Br_behavior_achohol = A25BR_Behavior_Achohol;
         obj9.gxTpr_Br_behavior_achoholtime = A26BR_Behavior_AchoholTime;
         obj9.gxTpr_Br_behavior_achoholamount = A27BR_Behavior_AchoholAmount;
         obj9.gxTpr_Br_behavior_rawachoholamount = A28BR_Behavior_RawAchoholAmount;
         obj9.gxTpr_Br_behavior_rawachoholamount_code = A463BR_Behavior_RawAchoholAmount_Code;
         obj9.gxTpr_Br_behavior_familycahistory = A29BR_Behavior_FamilyCaHistory;
         obj9.gxTpr_Br_behavior_familycancer = A30BR_Behavior_FamilyCancer;
         obj9.gxTpr_Br_behavior_menopause = A31BR_Behavior_Menopause;
         obj9.gxTpr_Br_behavior_menopauseage = A32BR_Behavior_MenopauseAge;
         obj9.gxTpr_Br_behavior_rawmenopauseage = A33BR_Behavior_RawMenopauseAge;
         obj9.gxTpr_Br_behavior_childnum = A34BR_Behavior_ChildNum;
         obj9.gxTpr_Br_behaviorid = A20BR_BehaviorID;
         obj9.gxTpr_Br_behaviorid_Z = Z20BR_BehaviorID;
         obj9.gxTpr_Br_encounterid_Z = Z19BR_EncounterID;
         obj9.gxTpr_Br_information_patientno_Z = Z36BR_Information_PatientNo;
         obj9.gxTpr_Br_behavior_smoking_Z = Z21BR_Behavior_Smoking;
         obj9.gxTpr_Br_behavior_smoking_code_Z = Z460BR_Behavior_Smoking_Code;
         obj9.gxTpr_Br_behavior_smokingtime_Z = Z22BR_Behavior_SmokingTime;
         obj9.gxTpr_Br_behavior_smokingamount_Z = Z23BR_Behavior_SmokingAmount;
         obj9.gxTpr_Br_behavior_rawsmokingamount_Z = Z24BR_Behavior_RawSmokingAmount;
         obj9.gxTpr_Br_behavior_rawsmokingamount_code_Z = Z461BR_Behavior_RawSmokingAmount_Code;
         obj9.gxTpr_Br_behavior_achohol_Z = Z25BR_Behavior_Achohol;
         obj9.gxTpr_Br_behavior_achohol_code_Z = Z462BR_Behavior_Achohol_Code;
         obj9.gxTpr_Br_behavior_achoholtime_Z = Z26BR_Behavior_AchoholTime;
         obj9.gxTpr_Br_behavior_achoholamount_Z = Z27BR_Behavior_AchoholAmount;
         obj9.gxTpr_Br_behavior_rawachoholamount_Z = Z28BR_Behavior_RawAchoholAmount;
         obj9.gxTpr_Br_behavior_rawachoholamount_code_Z = Z463BR_Behavior_RawAchoholAmount_Code;
         obj9.gxTpr_Br_behavior_familycahistory_Z = Z29BR_Behavior_FamilyCaHistory;
         obj9.gxTpr_Br_behavior_familycahistory_code_Z = Z464BR_Behavior_FamilyCaHistory_Code;
         obj9.gxTpr_Br_behavior_familycancer_Z = Z30BR_Behavior_FamilyCancer;
         obj9.gxTpr_Br_behavior_menopause_Z = Z31BR_Behavior_Menopause;
         obj9.gxTpr_Br_behavior_menopause_code_Z = Z465BR_Behavior_Menopause_Code;
         obj9.gxTpr_Br_behavior_menopauseage_Z = Z32BR_Behavior_MenopauseAge;
         obj9.gxTpr_Br_behavior_rawmenopauseage_Z = Z33BR_Behavior_RawMenopauseAge;
         obj9.gxTpr_Br_behavior_childnum_Z = Z34BR_Behavior_ChildNum;
         obj9.gxTpr_Br_information_patientno_N = (short)(Convert.ToInt16(n36BR_Information_PatientNo));
         obj9.gxTpr_Br_behavior_smoking_N = (short)(Convert.ToInt16(n21BR_Behavior_Smoking));
         obj9.gxTpr_Br_behavior_smoking_code_N = (short)(Convert.ToInt16(n460BR_Behavior_Smoking_Code));
         obj9.gxTpr_Br_behavior_smokingtime_N = (short)(Convert.ToInt16(n22BR_Behavior_SmokingTime));
         obj9.gxTpr_Br_behavior_smokingamount_N = (short)(Convert.ToInt16(n23BR_Behavior_SmokingAmount));
         obj9.gxTpr_Br_behavior_rawsmokingamount_N = (short)(Convert.ToInt16(n24BR_Behavior_RawSmokingAmount));
         obj9.gxTpr_Br_behavior_rawsmokingamount_code_N = (short)(Convert.ToInt16(n461BR_Behavior_RawSmokingAmount_Code));
         obj9.gxTpr_Br_behavior_achohol_N = (short)(Convert.ToInt16(n25BR_Behavior_Achohol));
         obj9.gxTpr_Br_behavior_achohol_code_N = (short)(Convert.ToInt16(n462BR_Behavior_Achohol_Code));
         obj9.gxTpr_Br_behavior_achoholtime_N = (short)(Convert.ToInt16(n26BR_Behavior_AchoholTime));
         obj9.gxTpr_Br_behavior_achoholamount_N = (short)(Convert.ToInt16(n27BR_Behavior_AchoholAmount));
         obj9.gxTpr_Br_behavior_rawachoholamount_N = (short)(Convert.ToInt16(n28BR_Behavior_RawAchoholAmount));
         obj9.gxTpr_Br_behavior_rawachoholamount_code_N = (short)(Convert.ToInt16(n463BR_Behavior_RawAchoholAmount_Code));
         obj9.gxTpr_Br_behavior_familycahistory_N = (short)(Convert.ToInt16(n29BR_Behavior_FamilyCaHistory));
         obj9.gxTpr_Br_behavior_familycahistory_code_N = (short)(Convert.ToInt16(n464BR_Behavior_FamilyCaHistory_Code));
         obj9.gxTpr_Br_behavior_familycancer_N = (short)(Convert.ToInt16(n30BR_Behavior_FamilyCancer));
         obj9.gxTpr_Br_behavior_menopause_N = (short)(Convert.ToInt16(n31BR_Behavior_Menopause));
         obj9.gxTpr_Br_behavior_menopause_code_N = (short)(Convert.ToInt16(n465BR_Behavior_Menopause_Code));
         obj9.gxTpr_Br_behavior_menopauseage_N = (short)(Convert.ToInt16(n32BR_Behavior_MenopauseAge));
         obj9.gxTpr_Br_behavior_rawmenopauseage_N = (short)(Convert.ToInt16(n33BR_Behavior_RawMenopauseAge));
         obj9.gxTpr_Br_behavior_childnum_N = (short)(Convert.ToInt16(n34BR_Behavior_ChildNum));
         obj9.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow9( SdtBR_Behavior obj9 )
      {
         obj9.gxTpr_Br_behaviorid = A20BR_BehaviorID;
         return  ;
      }

      public void RowToVars9( SdtBR_Behavior obj9 ,
                              int forceLoad )
      {
         Gx_mode = obj9.gxTpr_Mode;
         A460BR_Behavior_Smoking_Code = obj9.gxTpr_Br_behavior_smoking_code;
         n460BR_Behavior_Smoking_Code = false;
         A462BR_Behavior_Achohol_Code = obj9.gxTpr_Br_behavior_achohol_code;
         n462BR_Behavior_Achohol_Code = false;
         A464BR_Behavior_FamilyCaHistory_Code = obj9.gxTpr_Br_behavior_familycahistory_code;
         n464BR_Behavior_FamilyCaHistory_Code = false;
         A465BR_Behavior_Menopause_Code = obj9.gxTpr_Br_behavior_menopause_code;
         n465BR_Behavior_Menopause_Code = false;
         A19BR_EncounterID = obj9.gxTpr_Br_encounterid;
         A36BR_Information_PatientNo = obj9.gxTpr_Br_information_patientno;
         n36BR_Information_PatientNo = false;
         A21BR_Behavior_Smoking = obj9.gxTpr_Br_behavior_smoking;
         n21BR_Behavior_Smoking = false;
         A22BR_Behavior_SmokingTime = obj9.gxTpr_Br_behavior_smokingtime;
         n22BR_Behavior_SmokingTime = false;
         A23BR_Behavior_SmokingAmount = obj9.gxTpr_Br_behavior_smokingamount;
         n23BR_Behavior_SmokingAmount = false;
         A24BR_Behavior_RawSmokingAmount = obj9.gxTpr_Br_behavior_rawsmokingamount;
         n24BR_Behavior_RawSmokingAmount = false;
         A461BR_Behavior_RawSmokingAmount_Code = obj9.gxTpr_Br_behavior_rawsmokingamount_code;
         n461BR_Behavior_RawSmokingAmount_Code = false;
         A25BR_Behavior_Achohol = obj9.gxTpr_Br_behavior_achohol;
         n25BR_Behavior_Achohol = false;
         A26BR_Behavior_AchoholTime = obj9.gxTpr_Br_behavior_achoholtime;
         n26BR_Behavior_AchoholTime = false;
         A27BR_Behavior_AchoholAmount = obj9.gxTpr_Br_behavior_achoholamount;
         n27BR_Behavior_AchoholAmount = false;
         A28BR_Behavior_RawAchoholAmount = obj9.gxTpr_Br_behavior_rawachoholamount;
         n28BR_Behavior_RawAchoholAmount = false;
         A463BR_Behavior_RawAchoholAmount_Code = obj9.gxTpr_Br_behavior_rawachoholamount_code;
         n463BR_Behavior_RawAchoholAmount_Code = false;
         A29BR_Behavior_FamilyCaHistory = obj9.gxTpr_Br_behavior_familycahistory;
         n29BR_Behavior_FamilyCaHistory = false;
         A30BR_Behavior_FamilyCancer = obj9.gxTpr_Br_behavior_familycancer;
         n30BR_Behavior_FamilyCancer = false;
         A31BR_Behavior_Menopause = obj9.gxTpr_Br_behavior_menopause;
         n31BR_Behavior_Menopause = false;
         A32BR_Behavior_MenopauseAge = obj9.gxTpr_Br_behavior_menopauseage;
         n32BR_Behavior_MenopauseAge = false;
         A33BR_Behavior_RawMenopauseAge = obj9.gxTpr_Br_behavior_rawmenopauseage;
         n33BR_Behavior_RawMenopauseAge = false;
         A34BR_Behavior_ChildNum = obj9.gxTpr_Br_behavior_childnum;
         n34BR_Behavior_ChildNum = false;
         A20BR_BehaviorID = obj9.gxTpr_Br_behaviorid;
         Z20BR_BehaviorID = obj9.gxTpr_Br_behaviorid_Z;
         Z19BR_EncounterID = obj9.gxTpr_Br_encounterid_Z;
         Z36BR_Information_PatientNo = obj9.gxTpr_Br_information_patientno_Z;
         Z21BR_Behavior_Smoking = obj9.gxTpr_Br_behavior_smoking_Z;
         Z460BR_Behavior_Smoking_Code = obj9.gxTpr_Br_behavior_smoking_code_Z;
         Z22BR_Behavior_SmokingTime = obj9.gxTpr_Br_behavior_smokingtime_Z;
         Z23BR_Behavior_SmokingAmount = obj9.gxTpr_Br_behavior_smokingamount_Z;
         Z24BR_Behavior_RawSmokingAmount = obj9.gxTpr_Br_behavior_rawsmokingamount_Z;
         Z461BR_Behavior_RawSmokingAmount_Code = obj9.gxTpr_Br_behavior_rawsmokingamount_code_Z;
         Z25BR_Behavior_Achohol = obj9.gxTpr_Br_behavior_achohol_Z;
         Z462BR_Behavior_Achohol_Code = obj9.gxTpr_Br_behavior_achohol_code_Z;
         Z26BR_Behavior_AchoholTime = obj9.gxTpr_Br_behavior_achoholtime_Z;
         Z27BR_Behavior_AchoholAmount = obj9.gxTpr_Br_behavior_achoholamount_Z;
         Z28BR_Behavior_RawAchoholAmount = obj9.gxTpr_Br_behavior_rawachoholamount_Z;
         Z463BR_Behavior_RawAchoholAmount_Code = obj9.gxTpr_Br_behavior_rawachoholamount_code_Z;
         Z29BR_Behavior_FamilyCaHistory = obj9.gxTpr_Br_behavior_familycahistory_Z;
         Z464BR_Behavior_FamilyCaHistory_Code = obj9.gxTpr_Br_behavior_familycahistory_code_Z;
         Z30BR_Behavior_FamilyCancer = obj9.gxTpr_Br_behavior_familycancer_Z;
         Z31BR_Behavior_Menopause = obj9.gxTpr_Br_behavior_menopause_Z;
         Z465BR_Behavior_Menopause_Code = obj9.gxTpr_Br_behavior_menopause_code_Z;
         Z32BR_Behavior_MenopauseAge = obj9.gxTpr_Br_behavior_menopauseage_Z;
         Z33BR_Behavior_RawMenopauseAge = obj9.gxTpr_Br_behavior_rawmenopauseage_Z;
         Z34BR_Behavior_ChildNum = obj9.gxTpr_Br_behavior_childnum_Z;
         n36BR_Information_PatientNo = (bool)(Convert.ToBoolean(obj9.gxTpr_Br_information_patientno_N));
         n21BR_Behavior_Smoking = (bool)(Convert.ToBoolean(obj9.gxTpr_Br_behavior_smoking_N));
         n460BR_Behavior_Smoking_Code = (bool)(Convert.ToBoolean(obj9.gxTpr_Br_behavior_smoking_code_N));
         n22BR_Behavior_SmokingTime = (bool)(Convert.ToBoolean(obj9.gxTpr_Br_behavior_smokingtime_N));
         n23BR_Behavior_SmokingAmount = (bool)(Convert.ToBoolean(obj9.gxTpr_Br_behavior_smokingamount_N));
         n24BR_Behavior_RawSmokingAmount = (bool)(Convert.ToBoolean(obj9.gxTpr_Br_behavior_rawsmokingamount_N));
         n461BR_Behavior_RawSmokingAmount_Code = (bool)(Convert.ToBoolean(obj9.gxTpr_Br_behavior_rawsmokingamount_code_N));
         n25BR_Behavior_Achohol = (bool)(Convert.ToBoolean(obj9.gxTpr_Br_behavior_achohol_N));
         n462BR_Behavior_Achohol_Code = (bool)(Convert.ToBoolean(obj9.gxTpr_Br_behavior_achohol_code_N));
         n26BR_Behavior_AchoholTime = (bool)(Convert.ToBoolean(obj9.gxTpr_Br_behavior_achoholtime_N));
         n27BR_Behavior_AchoholAmount = (bool)(Convert.ToBoolean(obj9.gxTpr_Br_behavior_achoholamount_N));
         n28BR_Behavior_RawAchoholAmount = (bool)(Convert.ToBoolean(obj9.gxTpr_Br_behavior_rawachoholamount_N));
         n463BR_Behavior_RawAchoholAmount_Code = (bool)(Convert.ToBoolean(obj9.gxTpr_Br_behavior_rawachoholamount_code_N));
         n29BR_Behavior_FamilyCaHistory = (bool)(Convert.ToBoolean(obj9.gxTpr_Br_behavior_familycahistory_N));
         n464BR_Behavior_FamilyCaHistory_Code = (bool)(Convert.ToBoolean(obj9.gxTpr_Br_behavior_familycahistory_code_N));
         n30BR_Behavior_FamilyCancer = (bool)(Convert.ToBoolean(obj9.gxTpr_Br_behavior_familycancer_N));
         n31BR_Behavior_Menopause = (bool)(Convert.ToBoolean(obj9.gxTpr_Br_behavior_menopause_N));
         n465BR_Behavior_Menopause_Code = (bool)(Convert.ToBoolean(obj9.gxTpr_Br_behavior_menopause_code_N));
         n32BR_Behavior_MenopauseAge = (bool)(Convert.ToBoolean(obj9.gxTpr_Br_behavior_menopauseage_N));
         n33BR_Behavior_RawMenopauseAge = (bool)(Convert.ToBoolean(obj9.gxTpr_Br_behavior_rawmenopauseage_N));
         n34BR_Behavior_ChildNum = (bool)(Convert.ToBoolean(obj9.gxTpr_Br_behavior_childnum_N));
         Gx_mode = obj9.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A20BR_BehaviorID = (long)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey089( ) ;
         ScanKeyStart089( ) ;
         if ( RcdFound9 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z20BR_BehaviorID = A20BR_BehaviorID;
         }
         ZM089( -11) ;
         OnLoadActions089( ) ;
         AddRow089( ) ;
         ScanKeyEnd089( ) ;
         if ( RcdFound9 == 0 )
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
         RowToVars9( bcBR_Behavior, 0) ;
         ScanKeyStart089( ) ;
         if ( RcdFound9 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z20BR_BehaviorID = A20BR_BehaviorID;
         }
         ZM089( -11) ;
         OnLoadActions089( ) ;
         AddRow089( ) ;
         ScanKeyEnd089( ) ;
         if ( RcdFound9 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey089( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert089( ) ;
         }
         else
         {
            if ( RcdFound9 == 1 )
            {
               if ( A20BR_BehaviorID != Z20BR_BehaviorID )
               {
                  A20BR_BehaviorID = Z20BR_BehaviorID;
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
                  Update089( ) ;
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
                  if ( A20BR_BehaviorID != Z20BR_BehaviorID )
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
                        Insert089( ) ;
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
                        Insert089( ) ;
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
         RowToVars9( bcBR_Behavior, 0) ;
         SaveImpl( ) ;
         VarsToRow9( bcBR_Behavior) ;
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
         RowToVars9( bcBR_Behavior, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert089( ) ;
         AfterTrn( ) ;
         VarsToRow9( bcBR_Behavior) ;
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
            SdtBR_Behavior auxBC = new SdtBR_Behavior(context) ;
            auxBC.Load(A20BR_BehaviorID);
            auxBC.UpdateDirties(bcBR_Behavior);
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
         RowToVars9( bcBR_Behavior, 0) ;
         UpdateImpl( ) ;
         VarsToRow9( bcBR_Behavior) ;
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
         RowToVars9( bcBR_Behavior, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert089( ) ;
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
         VarsToRow9( bcBR_Behavior) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars9( bcBR_Behavior, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey089( ) ;
         if ( RcdFound9 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A20BR_BehaviorID != Z20BR_BehaviorID )
            {
               A20BR_BehaviorID = Z20BR_BehaviorID;
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
            if ( A20BR_BehaviorID != Z20BR_BehaviorID )
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
         context.RollbackDataStores("br_behavior_bc",pr_default);
         VarsToRow9( bcBR_Behavior) ;
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
         Gx_mode = bcBR_Behavior.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcBR_Behavior.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcBR_Behavior )
         {
            bcBR_Behavior = (SdtBR_Behavior)(sdt);
            if ( StringUtil.StrCmp(bcBR_Behavior.gxTpr_Mode, "") == 0 )
            {
               bcBR_Behavior.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow9( bcBR_Behavior) ;
            }
            else
            {
               RowToVars9( bcBR_Behavior, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcBR_Behavior.gxTpr_Mode, "") == 0 )
            {
               bcBR_Behavior.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars9( bcBR_Behavior, 1) ;
         return  ;
      }

      public SdtBR_Behavior BR_Behavior_BC
      {
         get {
            return bcBR_Behavior ;
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
         Z460BR_Behavior_Smoking_Code = "";
         A460BR_Behavior_Smoking_Code = "";
         Z462BR_Behavior_Achohol_Code = "";
         A462BR_Behavior_Achohol_Code = "";
         Z464BR_Behavior_FamilyCaHistory_Code = "";
         A464BR_Behavior_FamilyCaHistory_Code = "";
         Z465BR_Behavior_Menopause_Code = "";
         A465BR_Behavior_Menopause_Code = "";
         Z21BR_Behavior_Smoking = "";
         A21BR_Behavior_Smoking = "";
         Z22BR_Behavior_SmokingTime = "";
         A22BR_Behavior_SmokingTime = "";
         Z23BR_Behavior_SmokingAmount = "";
         A23BR_Behavior_SmokingAmount = "";
         Z24BR_Behavior_RawSmokingAmount = "";
         A24BR_Behavior_RawSmokingAmount = "";
         Z461BR_Behavior_RawSmokingAmount_Code = "";
         A461BR_Behavior_RawSmokingAmount_Code = "";
         Z25BR_Behavior_Achohol = "";
         A25BR_Behavior_Achohol = "";
         Z26BR_Behavior_AchoholTime = "";
         A26BR_Behavior_AchoholTime = "";
         Z27BR_Behavior_AchoholAmount = "";
         A27BR_Behavior_AchoholAmount = "";
         Z28BR_Behavior_RawAchoholAmount = "";
         A28BR_Behavior_RawAchoholAmount = "";
         Z463BR_Behavior_RawAchoholAmount_Code = "";
         A463BR_Behavior_RawAchoholAmount_Code = "";
         Z29BR_Behavior_FamilyCaHistory = "";
         A29BR_Behavior_FamilyCaHistory = "";
         Z30BR_Behavior_FamilyCancer = "";
         A30BR_Behavior_FamilyCancer = "";
         Z31BR_Behavior_Menopause = "";
         A31BR_Behavior_Menopause = "";
         Z33BR_Behavior_RawMenopauseAge = "";
         A33BR_Behavior_RawMenopauseAge = "";
         Z34BR_Behavior_ChildNum = "";
         A34BR_Behavior_ChildNum = "";
         Z36BR_Information_PatientNo = "";
         A36BR_Information_PatientNo = "";
         BC00086_A85BR_Information_ID = new long[1] ;
         BC00086_n85BR_Information_ID = new bool[] {false} ;
         BC00086_A20BR_BehaviorID = new long[1] ;
         BC00086_A460BR_Behavior_Smoking_Code = new String[] {""} ;
         BC00086_n460BR_Behavior_Smoking_Code = new bool[] {false} ;
         BC00086_A462BR_Behavior_Achohol_Code = new String[] {""} ;
         BC00086_n462BR_Behavior_Achohol_Code = new bool[] {false} ;
         BC00086_A464BR_Behavior_FamilyCaHistory_Code = new String[] {""} ;
         BC00086_n464BR_Behavior_FamilyCaHistory_Code = new bool[] {false} ;
         BC00086_A465BR_Behavior_Menopause_Code = new String[] {""} ;
         BC00086_n465BR_Behavior_Menopause_Code = new bool[] {false} ;
         BC00086_A36BR_Information_PatientNo = new String[] {""} ;
         BC00086_n36BR_Information_PatientNo = new bool[] {false} ;
         BC00086_A21BR_Behavior_Smoking = new String[] {""} ;
         BC00086_n21BR_Behavior_Smoking = new bool[] {false} ;
         BC00086_A22BR_Behavior_SmokingTime = new String[] {""} ;
         BC00086_n22BR_Behavior_SmokingTime = new bool[] {false} ;
         BC00086_A23BR_Behavior_SmokingAmount = new String[] {""} ;
         BC00086_n23BR_Behavior_SmokingAmount = new bool[] {false} ;
         BC00086_A24BR_Behavior_RawSmokingAmount = new String[] {""} ;
         BC00086_n24BR_Behavior_RawSmokingAmount = new bool[] {false} ;
         BC00086_A461BR_Behavior_RawSmokingAmount_Code = new String[] {""} ;
         BC00086_n461BR_Behavior_RawSmokingAmount_Code = new bool[] {false} ;
         BC00086_A25BR_Behavior_Achohol = new String[] {""} ;
         BC00086_n25BR_Behavior_Achohol = new bool[] {false} ;
         BC00086_A26BR_Behavior_AchoholTime = new String[] {""} ;
         BC00086_n26BR_Behavior_AchoholTime = new bool[] {false} ;
         BC00086_A27BR_Behavior_AchoholAmount = new String[] {""} ;
         BC00086_n27BR_Behavior_AchoholAmount = new bool[] {false} ;
         BC00086_A28BR_Behavior_RawAchoholAmount = new String[] {""} ;
         BC00086_n28BR_Behavior_RawAchoholAmount = new bool[] {false} ;
         BC00086_A463BR_Behavior_RawAchoholAmount_Code = new String[] {""} ;
         BC00086_n463BR_Behavior_RawAchoholAmount_Code = new bool[] {false} ;
         BC00086_A29BR_Behavior_FamilyCaHistory = new String[] {""} ;
         BC00086_n29BR_Behavior_FamilyCaHistory = new bool[] {false} ;
         BC00086_A30BR_Behavior_FamilyCancer = new String[] {""} ;
         BC00086_n30BR_Behavior_FamilyCancer = new bool[] {false} ;
         BC00086_A31BR_Behavior_Menopause = new String[] {""} ;
         BC00086_n31BR_Behavior_Menopause = new bool[] {false} ;
         BC00086_A32BR_Behavior_MenopauseAge = new short[1] ;
         BC00086_n32BR_Behavior_MenopauseAge = new bool[] {false} ;
         BC00086_A33BR_Behavior_RawMenopauseAge = new String[] {""} ;
         BC00086_n33BR_Behavior_RawMenopauseAge = new bool[] {false} ;
         BC00086_A34BR_Behavior_ChildNum = new String[] {""} ;
         BC00086_n34BR_Behavior_ChildNum = new bool[] {false} ;
         BC00086_A19BR_EncounterID = new long[1] ;
         BC00084_A85BR_Information_ID = new long[1] ;
         BC00084_n85BR_Information_ID = new bool[] {false} ;
         BC00085_A36BR_Information_PatientNo = new String[] {""} ;
         BC00085_n36BR_Information_PatientNo = new bool[] {false} ;
         BC00087_A20BR_BehaviorID = new long[1] ;
         BC00083_A20BR_BehaviorID = new long[1] ;
         BC00083_A460BR_Behavior_Smoking_Code = new String[] {""} ;
         BC00083_n460BR_Behavior_Smoking_Code = new bool[] {false} ;
         BC00083_A462BR_Behavior_Achohol_Code = new String[] {""} ;
         BC00083_n462BR_Behavior_Achohol_Code = new bool[] {false} ;
         BC00083_A464BR_Behavior_FamilyCaHistory_Code = new String[] {""} ;
         BC00083_n464BR_Behavior_FamilyCaHistory_Code = new bool[] {false} ;
         BC00083_A465BR_Behavior_Menopause_Code = new String[] {""} ;
         BC00083_n465BR_Behavior_Menopause_Code = new bool[] {false} ;
         BC00083_A21BR_Behavior_Smoking = new String[] {""} ;
         BC00083_n21BR_Behavior_Smoking = new bool[] {false} ;
         BC00083_A22BR_Behavior_SmokingTime = new String[] {""} ;
         BC00083_n22BR_Behavior_SmokingTime = new bool[] {false} ;
         BC00083_A23BR_Behavior_SmokingAmount = new String[] {""} ;
         BC00083_n23BR_Behavior_SmokingAmount = new bool[] {false} ;
         BC00083_A24BR_Behavior_RawSmokingAmount = new String[] {""} ;
         BC00083_n24BR_Behavior_RawSmokingAmount = new bool[] {false} ;
         BC00083_A461BR_Behavior_RawSmokingAmount_Code = new String[] {""} ;
         BC00083_n461BR_Behavior_RawSmokingAmount_Code = new bool[] {false} ;
         BC00083_A25BR_Behavior_Achohol = new String[] {""} ;
         BC00083_n25BR_Behavior_Achohol = new bool[] {false} ;
         BC00083_A26BR_Behavior_AchoholTime = new String[] {""} ;
         BC00083_n26BR_Behavior_AchoholTime = new bool[] {false} ;
         BC00083_A27BR_Behavior_AchoholAmount = new String[] {""} ;
         BC00083_n27BR_Behavior_AchoholAmount = new bool[] {false} ;
         BC00083_A28BR_Behavior_RawAchoholAmount = new String[] {""} ;
         BC00083_n28BR_Behavior_RawAchoholAmount = new bool[] {false} ;
         BC00083_A463BR_Behavior_RawAchoholAmount_Code = new String[] {""} ;
         BC00083_n463BR_Behavior_RawAchoholAmount_Code = new bool[] {false} ;
         BC00083_A29BR_Behavior_FamilyCaHistory = new String[] {""} ;
         BC00083_n29BR_Behavior_FamilyCaHistory = new bool[] {false} ;
         BC00083_A30BR_Behavior_FamilyCancer = new String[] {""} ;
         BC00083_n30BR_Behavior_FamilyCancer = new bool[] {false} ;
         BC00083_A31BR_Behavior_Menopause = new String[] {""} ;
         BC00083_n31BR_Behavior_Menopause = new bool[] {false} ;
         BC00083_A32BR_Behavior_MenopauseAge = new short[1] ;
         BC00083_n32BR_Behavior_MenopauseAge = new bool[] {false} ;
         BC00083_A33BR_Behavior_RawMenopauseAge = new String[] {""} ;
         BC00083_n33BR_Behavior_RawMenopauseAge = new bool[] {false} ;
         BC00083_A34BR_Behavior_ChildNum = new String[] {""} ;
         BC00083_n34BR_Behavior_ChildNum = new bool[] {false} ;
         BC00083_A19BR_EncounterID = new long[1] ;
         sMode9 = "";
         BC00082_A20BR_BehaviorID = new long[1] ;
         BC00082_A460BR_Behavior_Smoking_Code = new String[] {""} ;
         BC00082_n460BR_Behavior_Smoking_Code = new bool[] {false} ;
         BC00082_A462BR_Behavior_Achohol_Code = new String[] {""} ;
         BC00082_n462BR_Behavior_Achohol_Code = new bool[] {false} ;
         BC00082_A464BR_Behavior_FamilyCaHistory_Code = new String[] {""} ;
         BC00082_n464BR_Behavior_FamilyCaHistory_Code = new bool[] {false} ;
         BC00082_A465BR_Behavior_Menopause_Code = new String[] {""} ;
         BC00082_n465BR_Behavior_Menopause_Code = new bool[] {false} ;
         BC00082_A21BR_Behavior_Smoking = new String[] {""} ;
         BC00082_n21BR_Behavior_Smoking = new bool[] {false} ;
         BC00082_A22BR_Behavior_SmokingTime = new String[] {""} ;
         BC00082_n22BR_Behavior_SmokingTime = new bool[] {false} ;
         BC00082_A23BR_Behavior_SmokingAmount = new String[] {""} ;
         BC00082_n23BR_Behavior_SmokingAmount = new bool[] {false} ;
         BC00082_A24BR_Behavior_RawSmokingAmount = new String[] {""} ;
         BC00082_n24BR_Behavior_RawSmokingAmount = new bool[] {false} ;
         BC00082_A461BR_Behavior_RawSmokingAmount_Code = new String[] {""} ;
         BC00082_n461BR_Behavior_RawSmokingAmount_Code = new bool[] {false} ;
         BC00082_A25BR_Behavior_Achohol = new String[] {""} ;
         BC00082_n25BR_Behavior_Achohol = new bool[] {false} ;
         BC00082_A26BR_Behavior_AchoholTime = new String[] {""} ;
         BC00082_n26BR_Behavior_AchoholTime = new bool[] {false} ;
         BC00082_A27BR_Behavior_AchoholAmount = new String[] {""} ;
         BC00082_n27BR_Behavior_AchoholAmount = new bool[] {false} ;
         BC00082_A28BR_Behavior_RawAchoholAmount = new String[] {""} ;
         BC00082_n28BR_Behavior_RawAchoholAmount = new bool[] {false} ;
         BC00082_A463BR_Behavior_RawAchoholAmount_Code = new String[] {""} ;
         BC00082_n463BR_Behavior_RawAchoholAmount_Code = new bool[] {false} ;
         BC00082_A29BR_Behavior_FamilyCaHistory = new String[] {""} ;
         BC00082_n29BR_Behavior_FamilyCaHistory = new bool[] {false} ;
         BC00082_A30BR_Behavior_FamilyCancer = new String[] {""} ;
         BC00082_n30BR_Behavior_FamilyCancer = new bool[] {false} ;
         BC00082_A31BR_Behavior_Menopause = new String[] {""} ;
         BC00082_n31BR_Behavior_Menopause = new bool[] {false} ;
         BC00082_A32BR_Behavior_MenopauseAge = new short[1] ;
         BC00082_n32BR_Behavior_MenopauseAge = new bool[] {false} ;
         BC00082_A33BR_Behavior_RawMenopauseAge = new String[] {""} ;
         BC00082_n33BR_Behavior_RawMenopauseAge = new bool[] {false} ;
         BC00082_A34BR_Behavior_ChildNum = new String[] {""} ;
         BC00082_n34BR_Behavior_ChildNum = new bool[] {false} ;
         BC00082_A19BR_EncounterID = new long[1] ;
         BC00088_A20BR_BehaviorID = new long[1] ;
         BC000811_A85BR_Information_ID = new long[1] ;
         BC000811_n85BR_Information_ID = new bool[] {false} ;
         BC000812_A36BR_Information_PatientNo = new String[] {""} ;
         BC000812_n36BR_Information_PatientNo = new bool[] {false} ;
         BC000813_A85BR_Information_ID = new long[1] ;
         BC000813_n85BR_Information_ID = new bool[] {false} ;
         BC000813_A20BR_BehaviorID = new long[1] ;
         BC000813_A460BR_Behavior_Smoking_Code = new String[] {""} ;
         BC000813_n460BR_Behavior_Smoking_Code = new bool[] {false} ;
         BC000813_A462BR_Behavior_Achohol_Code = new String[] {""} ;
         BC000813_n462BR_Behavior_Achohol_Code = new bool[] {false} ;
         BC000813_A464BR_Behavior_FamilyCaHistory_Code = new String[] {""} ;
         BC000813_n464BR_Behavior_FamilyCaHistory_Code = new bool[] {false} ;
         BC000813_A465BR_Behavior_Menopause_Code = new String[] {""} ;
         BC000813_n465BR_Behavior_Menopause_Code = new bool[] {false} ;
         BC000813_A36BR_Information_PatientNo = new String[] {""} ;
         BC000813_n36BR_Information_PatientNo = new bool[] {false} ;
         BC000813_A21BR_Behavior_Smoking = new String[] {""} ;
         BC000813_n21BR_Behavior_Smoking = new bool[] {false} ;
         BC000813_A22BR_Behavior_SmokingTime = new String[] {""} ;
         BC000813_n22BR_Behavior_SmokingTime = new bool[] {false} ;
         BC000813_A23BR_Behavior_SmokingAmount = new String[] {""} ;
         BC000813_n23BR_Behavior_SmokingAmount = new bool[] {false} ;
         BC000813_A24BR_Behavior_RawSmokingAmount = new String[] {""} ;
         BC000813_n24BR_Behavior_RawSmokingAmount = new bool[] {false} ;
         BC000813_A461BR_Behavior_RawSmokingAmount_Code = new String[] {""} ;
         BC000813_n461BR_Behavior_RawSmokingAmount_Code = new bool[] {false} ;
         BC000813_A25BR_Behavior_Achohol = new String[] {""} ;
         BC000813_n25BR_Behavior_Achohol = new bool[] {false} ;
         BC000813_A26BR_Behavior_AchoholTime = new String[] {""} ;
         BC000813_n26BR_Behavior_AchoholTime = new bool[] {false} ;
         BC000813_A27BR_Behavior_AchoholAmount = new String[] {""} ;
         BC000813_n27BR_Behavior_AchoholAmount = new bool[] {false} ;
         BC000813_A28BR_Behavior_RawAchoholAmount = new String[] {""} ;
         BC000813_n28BR_Behavior_RawAchoholAmount = new bool[] {false} ;
         BC000813_A463BR_Behavior_RawAchoholAmount_Code = new String[] {""} ;
         BC000813_n463BR_Behavior_RawAchoholAmount_Code = new bool[] {false} ;
         BC000813_A29BR_Behavior_FamilyCaHistory = new String[] {""} ;
         BC000813_n29BR_Behavior_FamilyCaHistory = new bool[] {false} ;
         BC000813_A30BR_Behavior_FamilyCancer = new String[] {""} ;
         BC000813_n30BR_Behavior_FamilyCancer = new bool[] {false} ;
         BC000813_A31BR_Behavior_Menopause = new String[] {""} ;
         BC000813_n31BR_Behavior_Menopause = new bool[] {false} ;
         BC000813_A32BR_Behavior_MenopauseAge = new short[1] ;
         BC000813_n32BR_Behavior_MenopauseAge = new bool[] {false} ;
         BC000813_A33BR_Behavior_RawMenopauseAge = new String[] {""} ;
         BC000813_n33BR_Behavior_RawMenopauseAge = new bool[] {false} ;
         BC000813_A34BR_Behavior_ChildNum = new String[] {""} ;
         BC000813_n34BR_Behavior_ChildNum = new bool[] {false} ;
         BC000813_A19BR_EncounterID = new long[1] ;
         GXt_char1 = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_behavior_bc__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_behavior_bc__default(),
            new Object[][] {
                new Object[] {
               BC00082_A20BR_BehaviorID, BC00082_A460BR_Behavior_Smoking_Code, BC00082_n460BR_Behavior_Smoking_Code, BC00082_A462BR_Behavior_Achohol_Code, BC00082_n462BR_Behavior_Achohol_Code, BC00082_A464BR_Behavior_FamilyCaHistory_Code, BC00082_n464BR_Behavior_FamilyCaHistory_Code, BC00082_A465BR_Behavior_Menopause_Code, BC00082_n465BR_Behavior_Menopause_Code, BC00082_A21BR_Behavior_Smoking,
               BC00082_n21BR_Behavior_Smoking, BC00082_A22BR_Behavior_SmokingTime, BC00082_n22BR_Behavior_SmokingTime, BC00082_A23BR_Behavior_SmokingAmount, BC00082_n23BR_Behavior_SmokingAmount, BC00082_A24BR_Behavior_RawSmokingAmount, BC00082_n24BR_Behavior_RawSmokingAmount, BC00082_A461BR_Behavior_RawSmokingAmount_Code, BC00082_n461BR_Behavior_RawSmokingAmount_Code, BC00082_A25BR_Behavior_Achohol,
               BC00082_n25BR_Behavior_Achohol, BC00082_A26BR_Behavior_AchoholTime, BC00082_n26BR_Behavior_AchoholTime, BC00082_A27BR_Behavior_AchoholAmount, BC00082_n27BR_Behavior_AchoholAmount, BC00082_A28BR_Behavior_RawAchoholAmount, BC00082_n28BR_Behavior_RawAchoholAmount, BC00082_A463BR_Behavior_RawAchoholAmount_Code, BC00082_n463BR_Behavior_RawAchoholAmount_Code, BC00082_A29BR_Behavior_FamilyCaHistory,
               BC00082_n29BR_Behavior_FamilyCaHistory, BC00082_A30BR_Behavior_FamilyCancer, BC00082_n30BR_Behavior_FamilyCancer, BC00082_A31BR_Behavior_Menopause, BC00082_n31BR_Behavior_Menopause, BC00082_A32BR_Behavior_MenopauseAge, BC00082_n32BR_Behavior_MenopauseAge, BC00082_A33BR_Behavior_RawMenopauseAge, BC00082_n33BR_Behavior_RawMenopauseAge, BC00082_A34BR_Behavior_ChildNum,
               BC00082_n34BR_Behavior_ChildNum, BC00082_A19BR_EncounterID
               }
               , new Object[] {
               BC00083_A20BR_BehaviorID, BC00083_A460BR_Behavior_Smoking_Code, BC00083_n460BR_Behavior_Smoking_Code, BC00083_A462BR_Behavior_Achohol_Code, BC00083_n462BR_Behavior_Achohol_Code, BC00083_A464BR_Behavior_FamilyCaHistory_Code, BC00083_n464BR_Behavior_FamilyCaHistory_Code, BC00083_A465BR_Behavior_Menopause_Code, BC00083_n465BR_Behavior_Menopause_Code, BC00083_A21BR_Behavior_Smoking,
               BC00083_n21BR_Behavior_Smoking, BC00083_A22BR_Behavior_SmokingTime, BC00083_n22BR_Behavior_SmokingTime, BC00083_A23BR_Behavior_SmokingAmount, BC00083_n23BR_Behavior_SmokingAmount, BC00083_A24BR_Behavior_RawSmokingAmount, BC00083_n24BR_Behavior_RawSmokingAmount, BC00083_A461BR_Behavior_RawSmokingAmount_Code, BC00083_n461BR_Behavior_RawSmokingAmount_Code, BC00083_A25BR_Behavior_Achohol,
               BC00083_n25BR_Behavior_Achohol, BC00083_A26BR_Behavior_AchoholTime, BC00083_n26BR_Behavior_AchoholTime, BC00083_A27BR_Behavior_AchoholAmount, BC00083_n27BR_Behavior_AchoholAmount, BC00083_A28BR_Behavior_RawAchoholAmount, BC00083_n28BR_Behavior_RawAchoholAmount, BC00083_A463BR_Behavior_RawAchoholAmount_Code, BC00083_n463BR_Behavior_RawAchoholAmount_Code, BC00083_A29BR_Behavior_FamilyCaHistory,
               BC00083_n29BR_Behavior_FamilyCaHistory, BC00083_A30BR_Behavior_FamilyCancer, BC00083_n30BR_Behavior_FamilyCancer, BC00083_A31BR_Behavior_Menopause, BC00083_n31BR_Behavior_Menopause, BC00083_A32BR_Behavior_MenopauseAge, BC00083_n32BR_Behavior_MenopauseAge, BC00083_A33BR_Behavior_RawMenopauseAge, BC00083_n33BR_Behavior_RawMenopauseAge, BC00083_A34BR_Behavior_ChildNum,
               BC00083_n34BR_Behavior_ChildNum, BC00083_A19BR_EncounterID
               }
               , new Object[] {
               BC00084_A85BR_Information_ID, BC00084_n85BR_Information_ID
               }
               , new Object[] {
               BC00085_A36BR_Information_PatientNo, BC00085_n36BR_Information_PatientNo
               }
               , new Object[] {
               BC00086_A85BR_Information_ID, BC00086_n85BR_Information_ID, BC00086_A20BR_BehaviorID, BC00086_A460BR_Behavior_Smoking_Code, BC00086_n460BR_Behavior_Smoking_Code, BC00086_A462BR_Behavior_Achohol_Code, BC00086_n462BR_Behavior_Achohol_Code, BC00086_A464BR_Behavior_FamilyCaHistory_Code, BC00086_n464BR_Behavior_FamilyCaHistory_Code, BC00086_A465BR_Behavior_Menopause_Code,
               BC00086_n465BR_Behavior_Menopause_Code, BC00086_A36BR_Information_PatientNo, BC00086_n36BR_Information_PatientNo, BC00086_A21BR_Behavior_Smoking, BC00086_n21BR_Behavior_Smoking, BC00086_A22BR_Behavior_SmokingTime, BC00086_n22BR_Behavior_SmokingTime, BC00086_A23BR_Behavior_SmokingAmount, BC00086_n23BR_Behavior_SmokingAmount, BC00086_A24BR_Behavior_RawSmokingAmount,
               BC00086_n24BR_Behavior_RawSmokingAmount, BC00086_A461BR_Behavior_RawSmokingAmount_Code, BC00086_n461BR_Behavior_RawSmokingAmount_Code, BC00086_A25BR_Behavior_Achohol, BC00086_n25BR_Behavior_Achohol, BC00086_A26BR_Behavior_AchoholTime, BC00086_n26BR_Behavior_AchoholTime, BC00086_A27BR_Behavior_AchoholAmount, BC00086_n27BR_Behavior_AchoholAmount, BC00086_A28BR_Behavior_RawAchoholAmount,
               BC00086_n28BR_Behavior_RawAchoholAmount, BC00086_A463BR_Behavior_RawAchoholAmount_Code, BC00086_n463BR_Behavior_RawAchoholAmount_Code, BC00086_A29BR_Behavior_FamilyCaHistory, BC00086_n29BR_Behavior_FamilyCaHistory, BC00086_A30BR_Behavior_FamilyCancer, BC00086_n30BR_Behavior_FamilyCancer, BC00086_A31BR_Behavior_Menopause, BC00086_n31BR_Behavior_Menopause, BC00086_A32BR_Behavior_MenopauseAge,
               BC00086_n32BR_Behavior_MenopauseAge, BC00086_A33BR_Behavior_RawMenopauseAge, BC00086_n33BR_Behavior_RawMenopauseAge, BC00086_A34BR_Behavior_ChildNum, BC00086_n34BR_Behavior_ChildNum, BC00086_A19BR_EncounterID
               }
               , new Object[] {
               BC00087_A20BR_BehaviorID
               }
               , new Object[] {
               BC00088_A20BR_BehaviorID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000811_A85BR_Information_ID, BC000811_n85BR_Information_ID
               }
               , new Object[] {
               BC000812_A36BR_Information_PatientNo, BC000812_n36BR_Information_PatientNo
               }
               , new Object[] {
               BC000813_A85BR_Information_ID, BC000813_n85BR_Information_ID, BC000813_A20BR_BehaviorID, BC000813_A460BR_Behavior_Smoking_Code, BC000813_n460BR_Behavior_Smoking_Code, BC000813_A462BR_Behavior_Achohol_Code, BC000813_n462BR_Behavior_Achohol_Code, BC000813_A464BR_Behavior_FamilyCaHistory_Code, BC000813_n464BR_Behavior_FamilyCaHistory_Code, BC000813_A465BR_Behavior_Menopause_Code,
               BC000813_n465BR_Behavior_Menopause_Code, BC000813_A36BR_Information_PatientNo, BC000813_n36BR_Information_PatientNo, BC000813_A21BR_Behavior_Smoking, BC000813_n21BR_Behavior_Smoking, BC000813_A22BR_Behavior_SmokingTime, BC000813_n22BR_Behavior_SmokingTime, BC000813_A23BR_Behavior_SmokingAmount, BC000813_n23BR_Behavior_SmokingAmount, BC000813_A24BR_Behavior_RawSmokingAmount,
               BC000813_n24BR_Behavior_RawSmokingAmount, BC000813_A461BR_Behavior_RawSmokingAmount_Code, BC000813_n461BR_Behavior_RawSmokingAmount_Code, BC000813_A25BR_Behavior_Achohol, BC000813_n25BR_Behavior_Achohol, BC000813_A26BR_Behavior_AchoholTime, BC000813_n26BR_Behavior_AchoholTime, BC000813_A27BR_Behavior_AchoholAmount, BC000813_n27BR_Behavior_AchoholAmount, BC000813_A28BR_Behavior_RawAchoholAmount,
               BC000813_n28BR_Behavior_RawAchoholAmount, BC000813_A463BR_Behavior_RawAchoholAmount_Code, BC000813_n463BR_Behavior_RawAchoholAmount_Code, BC000813_A29BR_Behavior_FamilyCaHistory, BC000813_n29BR_Behavior_FamilyCaHistory, BC000813_A30BR_Behavior_FamilyCancer, BC000813_n30BR_Behavior_FamilyCancer, BC000813_A31BR_Behavior_Menopause, BC000813_n31BR_Behavior_Menopause, BC000813_A32BR_Behavior_MenopauseAge,
               BC000813_n32BR_Behavior_MenopauseAge, BC000813_A33BR_Behavior_RawMenopauseAge, BC000813_n33BR_Behavior_RawMenopauseAge, BC000813_A34BR_Behavior_ChildNum, BC000813_n34BR_Behavior_ChildNum, BC000813_A19BR_EncounterID
               }
            }
         );
         INITTRN();
         /* Execute Start event if defined. */
         /* Execute user event: Start */
         E12082 ();
         standaloneNotModal( ) ;
      }

      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short GX_JID ;
      private short Z32BR_Behavior_MenopauseAge ;
      private short A32BR_Behavior_MenopauseAge ;
      private short RcdFound9 ;
      private int trnEnded ;
      private long Z20BR_BehaviorID ;
      private long A20BR_BehaviorID ;
      private long Z19BR_EncounterID ;
      private long A19BR_EncounterID ;
      private long Z85BR_Information_ID ;
      private long A85BR_Information_ID ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String sMode9 ;
      private String GXt_char1 ;
      private bool n85BR_Information_ID ;
      private bool n460BR_Behavior_Smoking_Code ;
      private bool n462BR_Behavior_Achohol_Code ;
      private bool n464BR_Behavior_FamilyCaHistory_Code ;
      private bool n465BR_Behavior_Menopause_Code ;
      private bool n36BR_Information_PatientNo ;
      private bool n21BR_Behavior_Smoking ;
      private bool n22BR_Behavior_SmokingTime ;
      private bool n23BR_Behavior_SmokingAmount ;
      private bool n24BR_Behavior_RawSmokingAmount ;
      private bool n461BR_Behavior_RawSmokingAmount_Code ;
      private bool n25BR_Behavior_Achohol ;
      private bool n26BR_Behavior_AchoholTime ;
      private bool n27BR_Behavior_AchoholAmount ;
      private bool n28BR_Behavior_RawAchoholAmount ;
      private bool n463BR_Behavior_RawAchoholAmount_Code ;
      private bool n29BR_Behavior_FamilyCaHistory ;
      private bool n30BR_Behavior_FamilyCancer ;
      private bool n31BR_Behavior_Menopause ;
      private bool n32BR_Behavior_MenopauseAge ;
      private bool n33BR_Behavior_RawMenopauseAge ;
      private bool n34BR_Behavior_ChildNum ;
      private bool Gx_longc ;
      private String Z460BR_Behavior_Smoking_Code ;
      private String A460BR_Behavior_Smoking_Code ;
      private String Z462BR_Behavior_Achohol_Code ;
      private String A462BR_Behavior_Achohol_Code ;
      private String Z464BR_Behavior_FamilyCaHistory_Code ;
      private String A464BR_Behavior_FamilyCaHistory_Code ;
      private String Z465BR_Behavior_Menopause_Code ;
      private String A465BR_Behavior_Menopause_Code ;
      private String Z21BR_Behavior_Smoking ;
      private String A21BR_Behavior_Smoking ;
      private String Z22BR_Behavior_SmokingTime ;
      private String A22BR_Behavior_SmokingTime ;
      private String Z23BR_Behavior_SmokingAmount ;
      private String A23BR_Behavior_SmokingAmount ;
      private String Z24BR_Behavior_RawSmokingAmount ;
      private String A24BR_Behavior_RawSmokingAmount ;
      private String Z461BR_Behavior_RawSmokingAmount_Code ;
      private String A461BR_Behavior_RawSmokingAmount_Code ;
      private String Z25BR_Behavior_Achohol ;
      private String A25BR_Behavior_Achohol ;
      private String Z26BR_Behavior_AchoholTime ;
      private String A26BR_Behavior_AchoholTime ;
      private String Z27BR_Behavior_AchoholAmount ;
      private String A27BR_Behavior_AchoholAmount ;
      private String Z28BR_Behavior_RawAchoholAmount ;
      private String A28BR_Behavior_RawAchoholAmount ;
      private String Z463BR_Behavior_RawAchoholAmount_Code ;
      private String A463BR_Behavior_RawAchoholAmount_Code ;
      private String Z29BR_Behavior_FamilyCaHistory ;
      private String A29BR_Behavior_FamilyCaHistory ;
      private String Z30BR_Behavior_FamilyCancer ;
      private String A30BR_Behavior_FamilyCancer ;
      private String Z31BR_Behavior_Menopause ;
      private String A31BR_Behavior_Menopause ;
      private String Z33BR_Behavior_RawMenopauseAge ;
      private String A33BR_Behavior_RawMenopauseAge ;
      private String Z34BR_Behavior_ChildNum ;
      private String A34BR_Behavior_ChildNum ;
      private String Z36BR_Information_PatientNo ;
      private String A36BR_Information_PatientNo ;
      private SdtBR_Behavior bcBR_Behavior ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] BC00086_A85BR_Information_ID ;
      private bool[] BC00086_n85BR_Information_ID ;
      private long[] BC00086_A20BR_BehaviorID ;
      private String[] BC00086_A460BR_Behavior_Smoking_Code ;
      private bool[] BC00086_n460BR_Behavior_Smoking_Code ;
      private String[] BC00086_A462BR_Behavior_Achohol_Code ;
      private bool[] BC00086_n462BR_Behavior_Achohol_Code ;
      private String[] BC00086_A464BR_Behavior_FamilyCaHistory_Code ;
      private bool[] BC00086_n464BR_Behavior_FamilyCaHistory_Code ;
      private String[] BC00086_A465BR_Behavior_Menopause_Code ;
      private bool[] BC00086_n465BR_Behavior_Menopause_Code ;
      private String[] BC00086_A36BR_Information_PatientNo ;
      private bool[] BC00086_n36BR_Information_PatientNo ;
      private String[] BC00086_A21BR_Behavior_Smoking ;
      private bool[] BC00086_n21BR_Behavior_Smoking ;
      private String[] BC00086_A22BR_Behavior_SmokingTime ;
      private bool[] BC00086_n22BR_Behavior_SmokingTime ;
      private String[] BC00086_A23BR_Behavior_SmokingAmount ;
      private bool[] BC00086_n23BR_Behavior_SmokingAmount ;
      private String[] BC00086_A24BR_Behavior_RawSmokingAmount ;
      private bool[] BC00086_n24BR_Behavior_RawSmokingAmount ;
      private String[] BC00086_A461BR_Behavior_RawSmokingAmount_Code ;
      private bool[] BC00086_n461BR_Behavior_RawSmokingAmount_Code ;
      private String[] BC00086_A25BR_Behavior_Achohol ;
      private bool[] BC00086_n25BR_Behavior_Achohol ;
      private String[] BC00086_A26BR_Behavior_AchoholTime ;
      private bool[] BC00086_n26BR_Behavior_AchoholTime ;
      private String[] BC00086_A27BR_Behavior_AchoholAmount ;
      private bool[] BC00086_n27BR_Behavior_AchoholAmount ;
      private String[] BC00086_A28BR_Behavior_RawAchoholAmount ;
      private bool[] BC00086_n28BR_Behavior_RawAchoholAmount ;
      private String[] BC00086_A463BR_Behavior_RawAchoholAmount_Code ;
      private bool[] BC00086_n463BR_Behavior_RawAchoholAmount_Code ;
      private String[] BC00086_A29BR_Behavior_FamilyCaHistory ;
      private bool[] BC00086_n29BR_Behavior_FamilyCaHistory ;
      private String[] BC00086_A30BR_Behavior_FamilyCancer ;
      private bool[] BC00086_n30BR_Behavior_FamilyCancer ;
      private String[] BC00086_A31BR_Behavior_Menopause ;
      private bool[] BC00086_n31BR_Behavior_Menopause ;
      private short[] BC00086_A32BR_Behavior_MenopauseAge ;
      private bool[] BC00086_n32BR_Behavior_MenopauseAge ;
      private String[] BC00086_A33BR_Behavior_RawMenopauseAge ;
      private bool[] BC00086_n33BR_Behavior_RawMenopauseAge ;
      private String[] BC00086_A34BR_Behavior_ChildNum ;
      private bool[] BC00086_n34BR_Behavior_ChildNum ;
      private long[] BC00086_A19BR_EncounterID ;
      private long[] BC00084_A85BR_Information_ID ;
      private bool[] BC00084_n85BR_Information_ID ;
      private String[] BC00085_A36BR_Information_PatientNo ;
      private bool[] BC00085_n36BR_Information_PatientNo ;
      private long[] BC00087_A20BR_BehaviorID ;
      private long[] BC00083_A20BR_BehaviorID ;
      private String[] BC00083_A460BR_Behavior_Smoking_Code ;
      private bool[] BC00083_n460BR_Behavior_Smoking_Code ;
      private String[] BC00083_A462BR_Behavior_Achohol_Code ;
      private bool[] BC00083_n462BR_Behavior_Achohol_Code ;
      private String[] BC00083_A464BR_Behavior_FamilyCaHistory_Code ;
      private bool[] BC00083_n464BR_Behavior_FamilyCaHistory_Code ;
      private String[] BC00083_A465BR_Behavior_Menopause_Code ;
      private bool[] BC00083_n465BR_Behavior_Menopause_Code ;
      private String[] BC00083_A21BR_Behavior_Smoking ;
      private bool[] BC00083_n21BR_Behavior_Smoking ;
      private String[] BC00083_A22BR_Behavior_SmokingTime ;
      private bool[] BC00083_n22BR_Behavior_SmokingTime ;
      private String[] BC00083_A23BR_Behavior_SmokingAmount ;
      private bool[] BC00083_n23BR_Behavior_SmokingAmount ;
      private String[] BC00083_A24BR_Behavior_RawSmokingAmount ;
      private bool[] BC00083_n24BR_Behavior_RawSmokingAmount ;
      private String[] BC00083_A461BR_Behavior_RawSmokingAmount_Code ;
      private bool[] BC00083_n461BR_Behavior_RawSmokingAmount_Code ;
      private String[] BC00083_A25BR_Behavior_Achohol ;
      private bool[] BC00083_n25BR_Behavior_Achohol ;
      private String[] BC00083_A26BR_Behavior_AchoholTime ;
      private bool[] BC00083_n26BR_Behavior_AchoholTime ;
      private String[] BC00083_A27BR_Behavior_AchoholAmount ;
      private bool[] BC00083_n27BR_Behavior_AchoholAmount ;
      private String[] BC00083_A28BR_Behavior_RawAchoholAmount ;
      private bool[] BC00083_n28BR_Behavior_RawAchoholAmount ;
      private String[] BC00083_A463BR_Behavior_RawAchoholAmount_Code ;
      private bool[] BC00083_n463BR_Behavior_RawAchoholAmount_Code ;
      private String[] BC00083_A29BR_Behavior_FamilyCaHistory ;
      private bool[] BC00083_n29BR_Behavior_FamilyCaHistory ;
      private String[] BC00083_A30BR_Behavior_FamilyCancer ;
      private bool[] BC00083_n30BR_Behavior_FamilyCancer ;
      private String[] BC00083_A31BR_Behavior_Menopause ;
      private bool[] BC00083_n31BR_Behavior_Menopause ;
      private short[] BC00083_A32BR_Behavior_MenopauseAge ;
      private bool[] BC00083_n32BR_Behavior_MenopauseAge ;
      private String[] BC00083_A33BR_Behavior_RawMenopauseAge ;
      private bool[] BC00083_n33BR_Behavior_RawMenopauseAge ;
      private String[] BC00083_A34BR_Behavior_ChildNum ;
      private bool[] BC00083_n34BR_Behavior_ChildNum ;
      private long[] BC00083_A19BR_EncounterID ;
      private long[] BC00082_A20BR_BehaviorID ;
      private String[] BC00082_A460BR_Behavior_Smoking_Code ;
      private bool[] BC00082_n460BR_Behavior_Smoking_Code ;
      private String[] BC00082_A462BR_Behavior_Achohol_Code ;
      private bool[] BC00082_n462BR_Behavior_Achohol_Code ;
      private String[] BC00082_A464BR_Behavior_FamilyCaHistory_Code ;
      private bool[] BC00082_n464BR_Behavior_FamilyCaHistory_Code ;
      private String[] BC00082_A465BR_Behavior_Menopause_Code ;
      private bool[] BC00082_n465BR_Behavior_Menopause_Code ;
      private String[] BC00082_A21BR_Behavior_Smoking ;
      private bool[] BC00082_n21BR_Behavior_Smoking ;
      private String[] BC00082_A22BR_Behavior_SmokingTime ;
      private bool[] BC00082_n22BR_Behavior_SmokingTime ;
      private String[] BC00082_A23BR_Behavior_SmokingAmount ;
      private bool[] BC00082_n23BR_Behavior_SmokingAmount ;
      private String[] BC00082_A24BR_Behavior_RawSmokingAmount ;
      private bool[] BC00082_n24BR_Behavior_RawSmokingAmount ;
      private String[] BC00082_A461BR_Behavior_RawSmokingAmount_Code ;
      private bool[] BC00082_n461BR_Behavior_RawSmokingAmount_Code ;
      private String[] BC00082_A25BR_Behavior_Achohol ;
      private bool[] BC00082_n25BR_Behavior_Achohol ;
      private String[] BC00082_A26BR_Behavior_AchoholTime ;
      private bool[] BC00082_n26BR_Behavior_AchoholTime ;
      private String[] BC00082_A27BR_Behavior_AchoholAmount ;
      private bool[] BC00082_n27BR_Behavior_AchoholAmount ;
      private String[] BC00082_A28BR_Behavior_RawAchoholAmount ;
      private bool[] BC00082_n28BR_Behavior_RawAchoholAmount ;
      private String[] BC00082_A463BR_Behavior_RawAchoholAmount_Code ;
      private bool[] BC00082_n463BR_Behavior_RawAchoholAmount_Code ;
      private String[] BC00082_A29BR_Behavior_FamilyCaHistory ;
      private bool[] BC00082_n29BR_Behavior_FamilyCaHistory ;
      private String[] BC00082_A30BR_Behavior_FamilyCancer ;
      private bool[] BC00082_n30BR_Behavior_FamilyCancer ;
      private String[] BC00082_A31BR_Behavior_Menopause ;
      private bool[] BC00082_n31BR_Behavior_Menopause ;
      private short[] BC00082_A32BR_Behavior_MenopauseAge ;
      private bool[] BC00082_n32BR_Behavior_MenopauseAge ;
      private String[] BC00082_A33BR_Behavior_RawMenopauseAge ;
      private bool[] BC00082_n33BR_Behavior_RawMenopauseAge ;
      private String[] BC00082_A34BR_Behavior_ChildNum ;
      private bool[] BC00082_n34BR_Behavior_ChildNum ;
      private long[] BC00082_A19BR_EncounterID ;
      private long[] BC00088_A20BR_BehaviorID ;
      private long[] BC000811_A85BR_Information_ID ;
      private bool[] BC000811_n85BR_Information_ID ;
      private String[] BC000812_A36BR_Information_PatientNo ;
      private bool[] BC000812_n36BR_Information_PatientNo ;
      private long[] BC000813_A85BR_Information_ID ;
      private bool[] BC000813_n85BR_Information_ID ;
      private long[] BC000813_A20BR_BehaviorID ;
      private String[] BC000813_A460BR_Behavior_Smoking_Code ;
      private bool[] BC000813_n460BR_Behavior_Smoking_Code ;
      private String[] BC000813_A462BR_Behavior_Achohol_Code ;
      private bool[] BC000813_n462BR_Behavior_Achohol_Code ;
      private String[] BC000813_A464BR_Behavior_FamilyCaHistory_Code ;
      private bool[] BC000813_n464BR_Behavior_FamilyCaHistory_Code ;
      private String[] BC000813_A465BR_Behavior_Menopause_Code ;
      private bool[] BC000813_n465BR_Behavior_Menopause_Code ;
      private String[] BC000813_A36BR_Information_PatientNo ;
      private bool[] BC000813_n36BR_Information_PatientNo ;
      private String[] BC000813_A21BR_Behavior_Smoking ;
      private bool[] BC000813_n21BR_Behavior_Smoking ;
      private String[] BC000813_A22BR_Behavior_SmokingTime ;
      private bool[] BC000813_n22BR_Behavior_SmokingTime ;
      private String[] BC000813_A23BR_Behavior_SmokingAmount ;
      private bool[] BC000813_n23BR_Behavior_SmokingAmount ;
      private String[] BC000813_A24BR_Behavior_RawSmokingAmount ;
      private bool[] BC000813_n24BR_Behavior_RawSmokingAmount ;
      private String[] BC000813_A461BR_Behavior_RawSmokingAmount_Code ;
      private bool[] BC000813_n461BR_Behavior_RawSmokingAmount_Code ;
      private String[] BC000813_A25BR_Behavior_Achohol ;
      private bool[] BC000813_n25BR_Behavior_Achohol ;
      private String[] BC000813_A26BR_Behavior_AchoholTime ;
      private bool[] BC000813_n26BR_Behavior_AchoholTime ;
      private String[] BC000813_A27BR_Behavior_AchoholAmount ;
      private bool[] BC000813_n27BR_Behavior_AchoholAmount ;
      private String[] BC000813_A28BR_Behavior_RawAchoholAmount ;
      private bool[] BC000813_n28BR_Behavior_RawAchoholAmount ;
      private String[] BC000813_A463BR_Behavior_RawAchoholAmount_Code ;
      private bool[] BC000813_n463BR_Behavior_RawAchoholAmount_Code ;
      private String[] BC000813_A29BR_Behavior_FamilyCaHistory ;
      private bool[] BC000813_n29BR_Behavior_FamilyCaHistory ;
      private String[] BC000813_A30BR_Behavior_FamilyCancer ;
      private bool[] BC000813_n30BR_Behavior_FamilyCancer ;
      private String[] BC000813_A31BR_Behavior_Menopause ;
      private bool[] BC000813_n31BR_Behavior_Menopause ;
      private short[] BC000813_A32BR_Behavior_MenopauseAge ;
      private bool[] BC000813_n32BR_Behavior_MenopauseAge ;
      private String[] BC000813_A33BR_Behavior_RawMenopauseAge ;
      private bool[] BC000813_n33BR_Behavior_RawMenopauseAge ;
      private String[] BC000813_A34BR_Behavior_ChildNum ;
      private bool[] BC000813_n34BR_Behavior_ChildNum ;
      private long[] BC000813_A19BR_EncounterID ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_datastore1 ;
   }

   public class br_behavior_bc__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class br_behavior_bc__default : DataStoreHelperBase, IDataStoreHelper
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
        Object[] prmBC00086 ;
        prmBC00086 = new Object[] {
        new Object[] {"@BR_BehaviorID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00084 ;
        prmBC00084 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00085 ;
        prmBC00085 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00087 ;
        prmBC00087 = new Object[] {
        new Object[] {"@BR_BehaviorID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00083 ;
        prmBC00083 = new Object[] {
        new Object[] {"@BR_BehaviorID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00082 ;
        prmBC00082 = new Object[] {
        new Object[] {"@BR_BehaviorID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00088 ;
        prmBC00088 = new Object[] {
        new Object[] {"@BR_Behavior_Smoking_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Behavior_Achohol_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Behavior_FamilyCaHistory_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Behavior_Menopause_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Behavior_Smoking",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Behavior_SmokingTime",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Behavior_SmokingAmount",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Behavior_RawSmokingAmount",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Behavior_RawSmokingAmount_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Behavior_Achohol",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Behavior_AchoholTime",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Behavior_AchoholAmount",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Behavior_RawAchoholAmount",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Behavior_RawAchoholAmount_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Behavior_FamilyCaHistory",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Behavior_FamilyCancer",SqlDbType.NVarChar,200,0} ,
        new Object[] {"@BR_Behavior_Menopause",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Behavior_MenopauseAge",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@BR_Behavior_RawMenopauseAge",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Behavior_ChildNum",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00089 ;
        prmBC00089 = new Object[] {
        new Object[] {"@BR_Behavior_Smoking_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Behavior_Achohol_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Behavior_FamilyCaHistory_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Behavior_Menopause_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Behavior_Smoking",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Behavior_SmokingTime",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Behavior_SmokingAmount",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Behavior_RawSmokingAmount",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Behavior_RawSmokingAmount_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Behavior_Achohol",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Behavior_AchoholTime",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Behavior_AchoholAmount",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Behavior_RawAchoholAmount",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Behavior_RawAchoholAmount_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Behavior_FamilyCaHistory",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Behavior_FamilyCancer",SqlDbType.NVarChar,200,0} ,
        new Object[] {"@BR_Behavior_Menopause",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Behavior_MenopauseAge",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@BR_Behavior_RawMenopauseAge",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Behavior_ChildNum",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_BehaviorID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000810 ;
        prmBC000810 = new Object[] {
        new Object[] {"@BR_BehaviorID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000811 ;
        prmBC000811 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000812 ;
        prmBC000812 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000813 ;
        prmBC000813 = new Object[] {
        new Object[] {"@BR_BehaviorID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("BC00082", "SELECT [BR_BehaviorID], [BR_Behavior_Smoking_Code], [BR_Behavior_Achohol_Code], [BR_Behavior_FamilyCaHistory_Code], [BR_Behavior_Menopause_Code], [BR_Behavior_Smoking], [BR_Behavior_SmokingTime], [BR_Behavior_SmokingAmount], [BR_Behavior_RawSmokingAmount], [BR_Behavior_RawSmokingAmount_Code], [BR_Behavior_Achohol], [BR_Behavior_AchoholTime], [BR_Behavior_AchoholAmount], [BR_Behavior_RawAchoholAmount], [BR_Behavior_RawAchoholAmount_Code], [BR_Behavior_FamilyCaHistory], [BR_Behavior_FamilyCancer], [BR_Behavior_Menopause], [BR_Behavior_MenopauseAge], [BR_Behavior_RawMenopauseAge], [BR_Behavior_ChildNum], [BR_EncounterID] FROM [BR_Behavior] WITH (UPDLOCK) WHERE [BR_BehaviorID] = @BR_BehaviorID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00082,1,0,true,false )
           ,new CursorDef("BC00083", "SELECT [BR_BehaviorID], [BR_Behavior_Smoking_Code], [BR_Behavior_Achohol_Code], [BR_Behavior_FamilyCaHistory_Code], [BR_Behavior_Menopause_Code], [BR_Behavior_Smoking], [BR_Behavior_SmokingTime], [BR_Behavior_SmokingAmount], [BR_Behavior_RawSmokingAmount], [BR_Behavior_RawSmokingAmount_Code], [BR_Behavior_Achohol], [BR_Behavior_AchoholTime], [BR_Behavior_AchoholAmount], [BR_Behavior_RawAchoholAmount], [BR_Behavior_RawAchoholAmount_Code], [BR_Behavior_FamilyCaHistory], [BR_Behavior_FamilyCancer], [BR_Behavior_Menopause], [BR_Behavior_MenopauseAge], [BR_Behavior_RawMenopauseAge], [BR_Behavior_ChildNum], [BR_EncounterID] FROM [BR_Behavior] WITH (NOLOCK) WHERE [BR_BehaviorID] = @BR_BehaviorID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00083,1,0,true,false )
           ,new CursorDef("BC00084", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00084,1,0,true,false )
           ,new CursorDef("BC00085", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00085,1,0,true,false )
           ,new CursorDef("BC00086", "SELECT T2.[BR_Information_ID], TM1.[BR_BehaviorID], TM1.[BR_Behavior_Smoking_Code], TM1.[BR_Behavior_Achohol_Code], TM1.[BR_Behavior_FamilyCaHistory_Code], TM1.[BR_Behavior_Menopause_Code], T3.[BR_Information_PatientNo], TM1.[BR_Behavior_Smoking], TM1.[BR_Behavior_SmokingTime], TM1.[BR_Behavior_SmokingAmount], TM1.[BR_Behavior_RawSmokingAmount], TM1.[BR_Behavior_RawSmokingAmount_Code], TM1.[BR_Behavior_Achohol], TM1.[BR_Behavior_AchoholTime], TM1.[BR_Behavior_AchoholAmount], TM1.[BR_Behavior_RawAchoholAmount], TM1.[BR_Behavior_RawAchoholAmount_Code], TM1.[BR_Behavior_FamilyCaHistory], TM1.[BR_Behavior_FamilyCancer], TM1.[BR_Behavior_Menopause], TM1.[BR_Behavior_MenopauseAge], TM1.[BR_Behavior_RawMenopauseAge], TM1.[BR_Behavior_ChildNum], TM1.[BR_EncounterID] FROM (([BR_Behavior] TM1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = TM1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID]) WHERE TM1.[BR_BehaviorID] = @BR_BehaviorID ORDER BY TM1.[BR_BehaviorID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00086,100,0,true,false )
           ,new CursorDef("BC00087", "SELECT [BR_BehaviorID] FROM [BR_Behavior] WITH (NOLOCK) WHERE [BR_BehaviorID] = @BR_BehaviorID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00087,1,0,true,false )
           ,new CursorDef("BC00088", "INSERT INTO [BR_Behavior]([BR_Behavior_Smoking_Code], [BR_Behavior_Achohol_Code], [BR_Behavior_FamilyCaHistory_Code], [BR_Behavior_Menopause_Code], [BR_Behavior_Smoking], [BR_Behavior_SmokingTime], [BR_Behavior_SmokingAmount], [BR_Behavior_RawSmokingAmount], [BR_Behavior_RawSmokingAmount_Code], [BR_Behavior_Achohol], [BR_Behavior_AchoholTime], [BR_Behavior_AchoholAmount], [BR_Behavior_RawAchoholAmount], [BR_Behavior_RawAchoholAmount_Code], [BR_Behavior_FamilyCaHistory], [BR_Behavior_FamilyCancer], [BR_Behavior_Menopause], [BR_Behavior_MenopauseAge], [BR_Behavior_RawMenopauseAge], [BR_Behavior_ChildNum], [BR_EncounterID]) VALUES(@BR_Behavior_Smoking_Code, @BR_Behavior_Achohol_Code, @BR_Behavior_FamilyCaHistory_Code, @BR_Behavior_Menopause_Code, @BR_Behavior_Smoking, @BR_Behavior_SmokingTime, @BR_Behavior_SmokingAmount, @BR_Behavior_RawSmokingAmount, @BR_Behavior_RawSmokingAmount_Code, @BR_Behavior_Achohol, @BR_Behavior_AchoholTime, @BR_Behavior_AchoholAmount, @BR_Behavior_RawAchoholAmount, @BR_Behavior_RawAchoholAmount_Code, @BR_Behavior_FamilyCaHistory, @BR_Behavior_FamilyCancer, @BR_Behavior_Menopause, @BR_Behavior_MenopauseAge, @BR_Behavior_RawMenopauseAge, @BR_Behavior_ChildNum, @BR_EncounterID); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmBC00088)
           ,new CursorDef("BC00089", "UPDATE [BR_Behavior] SET [BR_Behavior_Smoking_Code]=@BR_Behavior_Smoking_Code, [BR_Behavior_Achohol_Code]=@BR_Behavior_Achohol_Code, [BR_Behavior_FamilyCaHistory_Code]=@BR_Behavior_FamilyCaHistory_Code, [BR_Behavior_Menopause_Code]=@BR_Behavior_Menopause_Code, [BR_Behavior_Smoking]=@BR_Behavior_Smoking, [BR_Behavior_SmokingTime]=@BR_Behavior_SmokingTime, [BR_Behavior_SmokingAmount]=@BR_Behavior_SmokingAmount, [BR_Behavior_RawSmokingAmount]=@BR_Behavior_RawSmokingAmount, [BR_Behavior_RawSmokingAmount_Code]=@BR_Behavior_RawSmokingAmount_Code, [BR_Behavior_Achohol]=@BR_Behavior_Achohol, [BR_Behavior_AchoholTime]=@BR_Behavior_AchoholTime, [BR_Behavior_AchoholAmount]=@BR_Behavior_AchoholAmount, [BR_Behavior_RawAchoholAmount]=@BR_Behavior_RawAchoholAmount, [BR_Behavior_RawAchoholAmount_Code]=@BR_Behavior_RawAchoholAmount_Code, [BR_Behavior_FamilyCaHistory]=@BR_Behavior_FamilyCaHistory, [BR_Behavior_FamilyCancer]=@BR_Behavior_FamilyCancer, [BR_Behavior_Menopause]=@BR_Behavior_Menopause, [BR_Behavior_MenopauseAge]=@BR_Behavior_MenopauseAge, [BR_Behavior_RawMenopauseAge]=@BR_Behavior_RawMenopauseAge, [BR_Behavior_ChildNum]=@BR_Behavior_ChildNum, [BR_EncounterID]=@BR_EncounterID  WHERE [BR_BehaviorID] = @BR_BehaviorID", GxErrorMask.GX_NOMASK,prmBC00089)
           ,new CursorDef("BC000810", "DELETE FROM [BR_Behavior]  WHERE [BR_BehaviorID] = @BR_BehaviorID", GxErrorMask.GX_NOMASK,prmBC000810)
           ,new CursorDef("BC000811", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000811,1,0,true,false )
           ,new CursorDef("BC000812", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000812,1,0,true,false )
           ,new CursorDef("BC000813", "SELECT T2.[BR_Information_ID], TM1.[BR_BehaviorID], TM1.[BR_Behavior_Smoking_Code], TM1.[BR_Behavior_Achohol_Code], TM1.[BR_Behavior_FamilyCaHistory_Code], TM1.[BR_Behavior_Menopause_Code], T3.[BR_Information_PatientNo], TM1.[BR_Behavior_Smoking], TM1.[BR_Behavior_SmokingTime], TM1.[BR_Behavior_SmokingAmount], TM1.[BR_Behavior_RawSmokingAmount], TM1.[BR_Behavior_RawSmokingAmount_Code], TM1.[BR_Behavior_Achohol], TM1.[BR_Behavior_AchoholTime], TM1.[BR_Behavior_AchoholAmount], TM1.[BR_Behavior_RawAchoholAmount], TM1.[BR_Behavior_RawAchoholAmount_Code], TM1.[BR_Behavior_FamilyCaHistory], TM1.[BR_Behavior_FamilyCancer], TM1.[BR_Behavior_Menopause], TM1.[BR_Behavior_MenopauseAge], TM1.[BR_Behavior_RawMenopauseAge], TM1.[BR_Behavior_ChildNum], TM1.[BR_EncounterID] FROM (([BR_Behavior] TM1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = TM1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID]) WHERE TM1.[BR_BehaviorID] = @BR_BehaviorID ORDER BY TM1.[BR_BehaviorID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000813,100,0,true,false )
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
              ((short[]) buf[35])[0] = rslt.getShort(19) ;
              ((bool[]) buf[36])[0] = rslt.wasNull(19);
              ((String[]) buf[37])[0] = rslt.getVarchar(20) ;
              ((bool[]) buf[38])[0] = rslt.wasNull(20);
              ((String[]) buf[39])[0] = rslt.getVarchar(21) ;
              ((bool[]) buf[40])[0] = rslt.wasNull(21);
              ((long[]) buf[41])[0] = rslt.getLong(22) ;
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
              ((short[]) buf[35])[0] = rslt.getShort(19) ;
              ((bool[]) buf[36])[0] = rslt.wasNull(19);
              ((String[]) buf[37])[0] = rslt.getVarchar(20) ;
              ((bool[]) buf[38])[0] = rslt.wasNull(20);
              ((String[]) buf[39])[0] = rslt.getVarchar(21) ;
              ((bool[]) buf[40])[0] = rslt.wasNull(21);
              ((long[]) buf[41])[0] = rslt.getLong(22) ;
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
              ((short[]) buf[39])[0] = rslt.getShort(21) ;
              ((bool[]) buf[40])[0] = rslt.wasNull(21);
              ((String[]) buf[41])[0] = rslt.getVarchar(22) ;
              ((bool[]) buf[42])[0] = rslt.wasNull(22);
              ((String[]) buf[43])[0] = rslt.getVarchar(23) ;
              ((bool[]) buf[44])[0] = rslt.wasNull(23);
              ((long[]) buf[45])[0] = rslt.getLong(24) ;
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
              ((short[]) buf[39])[0] = rslt.getShort(21) ;
              ((bool[]) buf[40])[0] = rslt.wasNull(21);
              ((String[]) buf[41])[0] = rslt.getVarchar(22) ;
              ((bool[]) buf[42])[0] = rslt.wasNull(22);
              ((String[]) buf[43])[0] = rslt.getVarchar(23) ;
              ((bool[]) buf[44])[0] = rslt.wasNull(23);
              ((long[]) buf[45])[0] = rslt.getLong(24) ;
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
                 stmt.setNull( 18 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(18, (short)parms[35]);
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
              stmt.SetParameter(21, (long)parms[40]);
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
                 stmt.setNull( 18 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(18, (short)parms[35]);
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
              stmt.SetParameter(21, (long)parms[40]);
              stmt.SetParameter(22, (long)parms[41]);
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
