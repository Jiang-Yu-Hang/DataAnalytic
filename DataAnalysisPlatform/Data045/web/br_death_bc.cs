/*
               File: BR_Death_BC
        Description: 死亡情况
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:6:29.33
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
   public class br_death_bc : GXHttpHandler, IGxSilentTrn
   {
      public br_death_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_death_bc( IGxContext context )
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
         ReadRow0A11( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey0A11( ) ;
         standaloneModal( ) ;
         AddRow0A11( ) ;
         Gx_mode = "INS";
         return  ;
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E110A2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               Z48BR_DeathID = A48BR_DeathID;
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

      protected void CONFIRM_0A0( )
      {
         BeforeValidate0A11( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0A11( ) ;
            }
            else
            {
               CheckExtendedTable0A11( ) ;
               if ( AnyError == 0 )
               {
                  ZM0A11( 7) ;
                  ZM0A11( 8) ;
               }
               CloseExtendedTableCursors0A11( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void E120A2( )
      {
         /* Start Routine */
      }

      protected void E110A2( )
      {
         /* After Trn Routine */
      }

      protected void ZM0A11( short GX_JID )
      {
         if ( ( GX_JID == 6 ) || ( GX_JID == 0 ) )
         {
            Z501BR_Death_CauseCode_Code = A501BR_Death_CauseCode_Code;
            Z469BR_Death_Sourse_Code = A469BR_Death_Sourse_Code;
            Z49BR_Death_Date = A49BR_Death_Date;
            Z50BR_Death_Cause = A50BR_Death_Cause;
            Z51BR_Death_CauseCode = A51BR_Death_CauseCode;
            Z52BR_Death_Sourse = A52BR_Death_Sourse;
            Z19BR_EncounterID = A19BR_EncounterID;
         }
         if ( ( GX_JID == 7 ) || ( GX_JID == 0 ) )
         {
            Z85BR_Information_ID = A85BR_Information_ID;
         }
         if ( ( GX_JID == 8 ) || ( GX_JID == 0 ) )
         {
            Z36BR_Information_PatientNo = A36BR_Information_PatientNo;
         }
         if ( GX_JID == -6 )
         {
            Z48BR_DeathID = A48BR_DeathID;
            Z501BR_Death_CauseCode_Code = A501BR_Death_CauseCode_Code;
            Z469BR_Death_Sourse_Code = A469BR_Death_Sourse_Code;
            Z49BR_Death_Date = A49BR_Death_Date;
            Z50BR_Death_Cause = A50BR_Death_Cause;
            Z51BR_Death_CauseCode = A51BR_Death_CauseCode;
            Z52BR_Death_Sourse = A52BR_Death_Sourse;
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

      protected void Load0A11( )
      {
         /* Using cursor BC000A6 */
         pr_default.execute(4, new Object[] {A48BR_DeathID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound11 = 1;
            A85BR_Information_ID = BC000A6_A85BR_Information_ID[0];
            n85BR_Information_ID = BC000A6_n85BR_Information_ID[0];
            A501BR_Death_CauseCode_Code = BC000A6_A501BR_Death_CauseCode_Code[0];
            n501BR_Death_CauseCode_Code = BC000A6_n501BR_Death_CauseCode_Code[0];
            A469BR_Death_Sourse_Code = BC000A6_A469BR_Death_Sourse_Code[0];
            n469BR_Death_Sourse_Code = BC000A6_n469BR_Death_Sourse_Code[0];
            A36BR_Information_PatientNo = BC000A6_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = BC000A6_n36BR_Information_PatientNo[0];
            A49BR_Death_Date = BC000A6_A49BR_Death_Date[0];
            n49BR_Death_Date = BC000A6_n49BR_Death_Date[0];
            A50BR_Death_Cause = BC000A6_A50BR_Death_Cause[0];
            n50BR_Death_Cause = BC000A6_n50BR_Death_Cause[0];
            A51BR_Death_CauseCode = BC000A6_A51BR_Death_CauseCode[0];
            n51BR_Death_CauseCode = BC000A6_n51BR_Death_CauseCode[0];
            A52BR_Death_Sourse = BC000A6_A52BR_Death_Sourse[0];
            n52BR_Death_Sourse = BC000A6_n52BR_Death_Sourse[0];
            A19BR_EncounterID = BC000A6_A19BR_EncounterID[0];
            ZM0A11( -6) ;
         }
         pr_default.close(4);
         OnLoadActions0A11( ) ;
      }

      protected void OnLoadActions0A11( )
      {
      }

      protected void CheckExtendedTable0A11( )
      {
         standaloneModal( ) ;
         /* Using cursor BC000A4 */
         pr_default.execute(2, new Object[] {A19BR_EncounterID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("不匹配' T15'", "ForeignKeyNotFound", 1, "BR_ENCOUNTERID");
            AnyError = 1;
         }
         A85BR_Information_ID = BC000A4_A85BR_Information_ID[0];
         n85BR_Information_ID = BC000A4_n85BR_Information_ID[0];
         pr_default.close(2);
         /* Using cursor BC000A5 */
         pr_default.execute(3, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
         if ( (pr_default.getStatus(3) == 101) )
         {
            if ( ! ( (0==A85BR_Information_ID) ) )
            {
               GX_msglist.addItem("不匹配' T16'", "ForeignKeyNotFound", 1, "");
               AnyError = 1;
            }
         }
         A36BR_Information_PatientNo = BC000A5_A36BR_Information_PatientNo[0];
         n36BR_Information_PatientNo = BC000A5_n36BR_Information_PatientNo[0];
         pr_default.close(3);
         if ( ! ( (DateTime.MinValue==A49BR_Death_Date) || ( A49BR_Death_Date >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("域死亡日期超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
      }

      protected void CloseExtendedTableCursors0A11( )
      {
         pr_default.close(2);
         pr_default.close(3);
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0A11( )
      {
         /* Using cursor BC000A7 */
         pr_default.execute(5, new Object[] {A48BR_DeathID});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound11 = 1;
         }
         else
         {
            RcdFound11 = 0;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC000A3 */
         pr_default.execute(1, new Object[] {A48BR_DeathID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0A11( 6) ;
            RcdFound11 = 1;
            A48BR_DeathID = BC000A3_A48BR_DeathID[0];
            A501BR_Death_CauseCode_Code = BC000A3_A501BR_Death_CauseCode_Code[0];
            n501BR_Death_CauseCode_Code = BC000A3_n501BR_Death_CauseCode_Code[0];
            A469BR_Death_Sourse_Code = BC000A3_A469BR_Death_Sourse_Code[0];
            n469BR_Death_Sourse_Code = BC000A3_n469BR_Death_Sourse_Code[0];
            A49BR_Death_Date = BC000A3_A49BR_Death_Date[0];
            n49BR_Death_Date = BC000A3_n49BR_Death_Date[0];
            A50BR_Death_Cause = BC000A3_A50BR_Death_Cause[0];
            n50BR_Death_Cause = BC000A3_n50BR_Death_Cause[0];
            A51BR_Death_CauseCode = BC000A3_A51BR_Death_CauseCode[0];
            n51BR_Death_CauseCode = BC000A3_n51BR_Death_CauseCode[0];
            A52BR_Death_Sourse = BC000A3_A52BR_Death_Sourse[0];
            n52BR_Death_Sourse = BC000A3_n52BR_Death_Sourse[0];
            A19BR_EncounterID = BC000A3_A19BR_EncounterID[0];
            Z48BR_DeathID = A48BR_DeathID;
            sMode11 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load0A11( ) ;
            if ( AnyError == 1 )
            {
               RcdFound11 = 0;
               InitializeNonKey0A11( ) ;
            }
            Gx_mode = sMode11;
         }
         else
         {
            RcdFound11 = 0;
            InitializeNonKey0A11( ) ;
            sMode11 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode11;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0A11( ) ;
         if ( RcdFound11 == 0 )
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
         CONFIRM_0A0( ) ;
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

      protected void CheckOptimisticConcurrency0A11( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC000A2 */
            pr_default.execute(0, new Object[] {A48BR_DeathID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Death"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z501BR_Death_CauseCode_Code, BC000A2_A501BR_Death_CauseCode_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z469BR_Death_Sourse_Code, BC000A2_A469BR_Death_Sourse_Code[0]) != 0 ) || ( Z49BR_Death_Date != BC000A2_A49BR_Death_Date[0] ) || ( StringUtil.StrCmp(Z50BR_Death_Cause, BC000A2_A50BR_Death_Cause[0]) != 0 ) || ( StringUtil.StrCmp(Z51BR_Death_CauseCode, BC000A2_A51BR_Death_CauseCode[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z52BR_Death_Sourse, BC000A2_A52BR_Death_Sourse[0]) != 0 ) || ( Z19BR_EncounterID != BC000A2_A19BR_EncounterID[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"BR_Death"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0A11( )
      {
         BeforeValidate0A11( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0A11( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0A11( 0) ;
            CheckOptimisticConcurrency0A11( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0A11( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0A11( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000A8 */
                     pr_default.execute(6, new Object[] {n501BR_Death_CauseCode_Code, A501BR_Death_CauseCode_Code, n469BR_Death_Sourse_Code, A469BR_Death_Sourse_Code, n49BR_Death_Date, A49BR_Death_Date, n50BR_Death_Cause, A50BR_Death_Cause, n51BR_Death_CauseCode, A51BR_Death_CauseCode, n52BR_Death_Sourse, A52BR_Death_Sourse, A19BR_EncounterID});
                     A48BR_DeathID = BC000A8_A48BR_DeathID[0];
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Death") ;
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
               Load0A11( ) ;
            }
            EndLevel0A11( ) ;
         }
         CloseExtendedTableCursors0A11( ) ;
      }

      protected void Update0A11( )
      {
         BeforeValidate0A11( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0A11( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0A11( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0A11( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0A11( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000A9 */
                     pr_default.execute(7, new Object[] {n501BR_Death_CauseCode_Code, A501BR_Death_CauseCode_Code, n469BR_Death_Sourse_Code, A469BR_Death_Sourse_Code, n49BR_Death_Date, A49BR_Death_Date, n50BR_Death_Cause, A50BR_Death_Cause, n51BR_Death_CauseCode, A51BR_Death_CauseCode, n52BR_Death_Sourse, A52BR_Death_Sourse, A19BR_EncounterID, A48BR_DeathID});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Death") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Death"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0A11( ) ;
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
            EndLevel0A11( ) ;
         }
         CloseExtendedTableCursors0A11( ) ;
      }

      protected void DeferredUpdate0A11( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate0A11( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0A11( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0A11( ) ;
            AfterConfirm0A11( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0A11( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC000A10 */
                  pr_default.execute(8, new Object[] {A48BR_DeathID});
                  pr_default.close(8);
                  dsDefault.SmartCacheProvider.SetUpdated("BR_Death") ;
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
         sMode11 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel0A11( ) ;
         Gx_mode = sMode11;
      }

      protected void OnDeleteControls0A11( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor BC000A11 */
            pr_default.execute(9, new Object[] {A19BR_EncounterID});
            A85BR_Information_ID = BC000A11_A85BR_Information_ID[0];
            n85BR_Information_ID = BC000A11_n85BR_Information_ID[0];
            pr_default.close(9);
            /* Using cursor BC000A12 */
            pr_default.execute(10, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
            A36BR_Information_PatientNo = BC000A12_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = BC000A12_n36BR_Information_PatientNo[0];
            pr_default.close(10);
         }
      }

      protected void EndLevel0A11( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0A11( ) ;
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

      public void ScanKeyStart0A11( )
      {
         /* Scan By routine */
         /* Using cursor BC000A13 */
         pr_default.execute(11, new Object[] {A48BR_DeathID});
         RcdFound11 = 0;
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound11 = 1;
            A85BR_Information_ID = BC000A13_A85BR_Information_ID[0];
            n85BR_Information_ID = BC000A13_n85BR_Information_ID[0];
            A48BR_DeathID = BC000A13_A48BR_DeathID[0];
            A501BR_Death_CauseCode_Code = BC000A13_A501BR_Death_CauseCode_Code[0];
            n501BR_Death_CauseCode_Code = BC000A13_n501BR_Death_CauseCode_Code[0];
            A469BR_Death_Sourse_Code = BC000A13_A469BR_Death_Sourse_Code[0];
            n469BR_Death_Sourse_Code = BC000A13_n469BR_Death_Sourse_Code[0];
            A36BR_Information_PatientNo = BC000A13_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = BC000A13_n36BR_Information_PatientNo[0];
            A49BR_Death_Date = BC000A13_A49BR_Death_Date[0];
            n49BR_Death_Date = BC000A13_n49BR_Death_Date[0];
            A50BR_Death_Cause = BC000A13_A50BR_Death_Cause[0];
            n50BR_Death_Cause = BC000A13_n50BR_Death_Cause[0];
            A51BR_Death_CauseCode = BC000A13_A51BR_Death_CauseCode[0];
            n51BR_Death_CauseCode = BC000A13_n51BR_Death_CauseCode[0];
            A52BR_Death_Sourse = BC000A13_A52BR_Death_Sourse[0];
            n52BR_Death_Sourse = BC000A13_n52BR_Death_Sourse[0];
            A19BR_EncounterID = BC000A13_A19BR_EncounterID[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext0A11( )
      {
         /* Scan next routine */
         pr_default.readNext(11);
         RcdFound11 = 0;
         ScanKeyLoad0A11( ) ;
      }

      protected void ScanKeyLoad0A11( )
      {
         sMode11 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound11 = 1;
            A85BR_Information_ID = BC000A13_A85BR_Information_ID[0];
            n85BR_Information_ID = BC000A13_n85BR_Information_ID[0];
            A48BR_DeathID = BC000A13_A48BR_DeathID[0];
            A501BR_Death_CauseCode_Code = BC000A13_A501BR_Death_CauseCode_Code[0];
            n501BR_Death_CauseCode_Code = BC000A13_n501BR_Death_CauseCode_Code[0];
            A469BR_Death_Sourse_Code = BC000A13_A469BR_Death_Sourse_Code[0];
            n469BR_Death_Sourse_Code = BC000A13_n469BR_Death_Sourse_Code[0];
            A36BR_Information_PatientNo = BC000A13_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = BC000A13_n36BR_Information_PatientNo[0];
            A49BR_Death_Date = BC000A13_A49BR_Death_Date[0];
            n49BR_Death_Date = BC000A13_n49BR_Death_Date[0];
            A50BR_Death_Cause = BC000A13_A50BR_Death_Cause[0];
            n50BR_Death_Cause = BC000A13_n50BR_Death_Cause[0];
            A51BR_Death_CauseCode = BC000A13_A51BR_Death_CauseCode[0];
            n51BR_Death_CauseCode = BC000A13_n51BR_Death_CauseCode[0];
            A52BR_Death_Sourse = BC000A13_A52BR_Death_Sourse[0];
            n52BR_Death_Sourse = BC000A13_n52BR_Death_Sourse[0];
            A19BR_EncounterID = BC000A13_A19BR_EncounterID[0];
         }
         Gx_mode = sMode11;
      }

      protected void ScanKeyEnd0A11( )
      {
         pr_default.close(11);
      }

      protected void AfterConfirm0A11( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0A11( )
      {
         /* Before Insert Rules */
         GXt_char1 = A501BR_Death_CauseCode_Code;
         new zutil_findtargetcode(context ).execute(  18,  A51BR_Death_CauseCode, out  GXt_char1) ;
         A501BR_Death_CauseCode_Code = GXt_char1;
         n501BR_Death_CauseCode_Code = false;
         GXt_char1 = A469BR_Death_Sourse_Code;
         new zutil_findtargetcode(context ).execute(  19,  A52BR_Death_Sourse, out  GXt_char1) ;
         A469BR_Death_Sourse_Code = GXt_char1;
         n469BR_Death_Sourse_Code = false;
      }

      protected void BeforeUpdate0A11( )
      {
         /* Before Update Rules */
         GXt_char1 = A501BR_Death_CauseCode_Code;
         new zutil_findtargetcode(context ).execute(  18,  A51BR_Death_CauseCode, out  GXt_char1) ;
         A501BR_Death_CauseCode_Code = GXt_char1;
         n501BR_Death_CauseCode_Code = false;
         GXt_char1 = A469BR_Death_Sourse_Code;
         new zutil_findtargetcode(context ).execute(  19,  A52BR_Death_Sourse, out  GXt_char1) ;
         A469BR_Death_Sourse_Code = GXt_char1;
         n469BR_Death_Sourse_Code = false;
      }

      protected void BeforeDelete0A11( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0A11( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0A11( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0A11( )
      {
      }

      protected void send_integrity_lvl_hashes0A11( )
      {
      }

      protected void AddRow0A11( )
      {
         VarsToRow11( bcBR_Death) ;
      }

      protected void ReadRow0A11( )
      {
         RowToVars11( bcBR_Death, 1) ;
      }

      protected void InitializeNonKey0A11( )
      {
         A85BR_Information_ID = 0;
         n85BR_Information_ID = false;
         A501BR_Death_CauseCode_Code = "";
         n501BR_Death_CauseCode_Code = false;
         A469BR_Death_Sourse_Code = "";
         n469BR_Death_Sourse_Code = false;
         A19BR_EncounterID = 0;
         A36BR_Information_PatientNo = "";
         n36BR_Information_PatientNo = false;
         A49BR_Death_Date = DateTime.MinValue;
         n49BR_Death_Date = false;
         A50BR_Death_Cause = "";
         n50BR_Death_Cause = false;
         A51BR_Death_CauseCode = "";
         n51BR_Death_CauseCode = false;
         A52BR_Death_Sourse = "";
         n52BR_Death_Sourse = false;
         Z501BR_Death_CauseCode_Code = "";
         Z469BR_Death_Sourse_Code = "";
         Z49BR_Death_Date = DateTime.MinValue;
         Z50BR_Death_Cause = "";
         Z51BR_Death_CauseCode = "";
         Z52BR_Death_Sourse = "";
         Z19BR_EncounterID = 0;
      }

      protected void InitAll0A11( )
      {
         A48BR_DeathID = 0;
         InitializeNonKey0A11( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow11( SdtBR_Death obj11 )
      {
         obj11.gxTpr_Mode = Gx_mode;
         obj11.gxTpr_Br_death_causecode_code = A501BR_Death_CauseCode_Code;
         obj11.gxTpr_Br_death_sourse_code = A469BR_Death_Sourse_Code;
         obj11.gxTpr_Br_encounterid = A19BR_EncounterID;
         obj11.gxTpr_Br_information_patientno = A36BR_Information_PatientNo;
         obj11.gxTpr_Br_death_date = A49BR_Death_Date;
         obj11.gxTpr_Br_death_cause = A50BR_Death_Cause;
         obj11.gxTpr_Br_death_causecode = A51BR_Death_CauseCode;
         obj11.gxTpr_Br_death_sourse = A52BR_Death_Sourse;
         obj11.gxTpr_Br_deathid = A48BR_DeathID;
         obj11.gxTpr_Br_deathid_Z = Z48BR_DeathID;
         obj11.gxTpr_Br_encounterid_Z = Z19BR_EncounterID;
         obj11.gxTpr_Br_information_patientno_Z = Z36BR_Information_PatientNo;
         obj11.gxTpr_Br_death_date_Z = Z49BR_Death_Date;
         obj11.gxTpr_Br_death_cause_Z = Z50BR_Death_Cause;
         obj11.gxTpr_Br_death_causecode_Z = Z51BR_Death_CauseCode;
         obj11.gxTpr_Br_death_causecode_code_Z = Z501BR_Death_CauseCode_Code;
         obj11.gxTpr_Br_death_sourse_Z = Z52BR_Death_Sourse;
         obj11.gxTpr_Br_death_sourse_code_Z = Z469BR_Death_Sourse_Code;
         obj11.gxTpr_Br_information_patientno_N = (short)(Convert.ToInt16(n36BR_Information_PatientNo));
         obj11.gxTpr_Br_death_date_N = (short)(Convert.ToInt16(n49BR_Death_Date));
         obj11.gxTpr_Br_death_cause_N = (short)(Convert.ToInt16(n50BR_Death_Cause));
         obj11.gxTpr_Br_death_causecode_N = (short)(Convert.ToInt16(n51BR_Death_CauseCode));
         obj11.gxTpr_Br_death_causecode_code_N = (short)(Convert.ToInt16(n501BR_Death_CauseCode_Code));
         obj11.gxTpr_Br_death_sourse_N = (short)(Convert.ToInt16(n52BR_Death_Sourse));
         obj11.gxTpr_Br_death_sourse_code_N = (short)(Convert.ToInt16(n469BR_Death_Sourse_Code));
         obj11.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow11( SdtBR_Death obj11 )
      {
         obj11.gxTpr_Br_deathid = A48BR_DeathID;
         return  ;
      }

      public void RowToVars11( SdtBR_Death obj11 ,
                               int forceLoad )
      {
         Gx_mode = obj11.gxTpr_Mode;
         A501BR_Death_CauseCode_Code = obj11.gxTpr_Br_death_causecode_code;
         n501BR_Death_CauseCode_Code = false;
         A469BR_Death_Sourse_Code = obj11.gxTpr_Br_death_sourse_code;
         n469BR_Death_Sourse_Code = false;
         A19BR_EncounterID = obj11.gxTpr_Br_encounterid;
         A36BR_Information_PatientNo = obj11.gxTpr_Br_information_patientno;
         n36BR_Information_PatientNo = false;
         A49BR_Death_Date = obj11.gxTpr_Br_death_date;
         n49BR_Death_Date = false;
         A50BR_Death_Cause = obj11.gxTpr_Br_death_cause;
         n50BR_Death_Cause = false;
         A51BR_Death_CauseCode = obj11.gxTpr_Br_death_causecode;
         n51BR_Death_CauseCode = false;
         A52BR_Death_Sourse = obj11.gxTpr_Br_death_sourse;
         n52BR_Death_Sourse = false;
         A48BR_DeathID = obj11.gxTpr_Br_deathid;
         Z48BR_DeathID = obj11.gxTpr_Br_deathid_Z;
         Z19BR_EncounterID = obj11.gxTpr_Br_encounterid_Z;
         Z36BR_Information_PatientNo = obj11.gxTpr_Br_information_patientno_Z;
         Z49BR_Death_Date = obj11.gxTpr_Br_death_date_Z;
         Z50BR_Death_Cause = obj11.gxTpr_Br_death_cause_Z;
         Z51BR_Death_CauseCode = obj11.gxTpr_Br_death_causecode_Z;
         Z501BR_Death_CauseCode_Code = obj11.gxTpr_Br_death_causecode_code_Z;
         Z52BR_Death_Sourse = obj11.gxTpr_Br_death_sourse_Z;
         Z469BR_Death_Sourse_Code = obj11.gxTpr_Br_death_sourse_code_Z;
         n36BR_Information_PatientNo = (bool)(Convert.ToBoolean(obj11.gxTpr_Br_information_patientno_N));
         n49BR_Death_Date = (bool)(Convert.ToBoolean(obj11.gxTpr_Br_death_date_N));
         n50BR_Death_Cause = (bool)(Convert.ToBoolean(obj11.gxTpr_Br_death_cause_N));
         n51BR_Death_CauseCode = (bool)(Convert.ToBoolean(obj11.gxTpr_Br_death_causecode_N));
         n501BR_Death_CauseCode_Code = (bool)(Convert.ToBoolean(obj11.gxTpr_Br_death_causecode_code_N));
         n52BR_Death_Sourse = (bool)(Convert.ToBoolean(obj11.gxTpr_Br_death_sourse_N));
         n469BR_Death_Sourse_Code = (bool)(Convert.ToBoolean(obj11.gxTpr_Br_death_sourse_code_N));
         Gx_mode = obj11.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A48BR_DeathID = (long)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey0A11( ) ;
         ScanKeyStart0A11( ) ;
         if ( RcdFound11 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z48BR_DeathID = A48BR_DeathID;
         }
         ZM0A11( -6) ;
         OnLoadActions0A11( ) ;
         AddRow0A11( ) ;
         ScanKeyEnd0A11( ) ;
         if ( RcdFound11 == 0 )
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
         RowToVars11( bcBR_Death, 0) ;
         ScanKeyStart0A11( ) ;
         if ( RcdFound11 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z48BR_DeathID = A48BR_DeathID;
         }
         ZM0A11( -6) ;
         OnLoadActions0A11( ) ;
         AddRow0A11( ) ;
         ScanKeyEnd0A11( ) ;
         if ( RcdFound11 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey0A11( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert0A11( ) ;
         }
         else
         {
            if ( RcdFound11 == 1 )
            {
               if ( A48BR_DeathID != Z48BR_DeathID )
               {
                  A48BR_DeathID = Z48BR_DeathID;
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
                  Update0A11( ) ;
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
                  if ( A48BR_DeathID != Z48BR_DeathID )
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
                        Insert0A11( ) ;
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
                        Insert0A11( ) ;
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
         RowToVars11( bcBR_Death, 0) ;
         SaveImpl( ) ;
         VarsToRow11( bcBR_Death) ;
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
         RowToVars11( bcBR_Death, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert0A11( ) ;
         AfterTrn( ) ;
         VarsToRow11( bcBR_Death) ;
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
            SdtBR_Death auxBC = new SdtBR_Death(context) ;
            auxBC.Load(A48BR_DeathID);
            auxBC.UpdateDirties(bcBR_Death);
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
         RowToVars11( bcBR_Death, 0) ;
         UpdateImpl( ) ;
         VarsToRow11( bcBR_Death) ;
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
         RowToVars11( bcBR_Death, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert0A11( ) ;
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
         VarsToRow11( bcBR_Death) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars11( bcBR_Death, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey0A11( ) ;
         if ( RcdFound11 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A48BR_DeathID != Z48BR_DeathID )
            {
               A48BR_DeathID = Z48BR_DeathID;
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
            if ( A48BR_DeathID != Z48BR_DeathID )
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
         context.RollbackDataStores("br_death_bc",pr_default);
         VarsToRow11( bcBR_Death) ;
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
         Gx_mode = bcBR_Death.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcBR_Death.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcBR_Death )
         {
            bcBR_Death = (SdtBR_Death)(sdt);
            if ( StringUtil.StrCmp(bcBR_Death.gxTpr_Mode, "") == 0 )
            {
               bcBR_Death.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow11( bcBR_Death) ;
            }
            else
            {
               RowToVars11( bcBR_Death, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcBR_Death.gxTpr_Mode, "") == 0 )
            {
               bcBR_Death.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars11( bcBR_Death, 1) ;
         return  ;
      }

      public SdtBR_Death BR_Death_BC
      {
         get {
            return bcBR_Death ;
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
         Z501BR_Death_CauseCode_Code = "";
         A501BR_Death_CauseCode_Code = "";
         Z469BR_Death_Sourse_Code = "";
         A469BR_Death_Sourse_Code = "";
         Z49BR_Death_Date = DateTime.MinValue;
         A49BR_Death_Date = DateTime.MinValue;
         Z50BR_Death_Cause = "";
         A50BR_Death_Cause = "";
         Z51BR_Death_CauseCode = "";
         A51BR_Death_CauseCode = "";
         Z52BR_Death_Sourse = "";
         A52BR_Death_Sourse = "";
         Z36BR_Information_PatientNo = "";
         A36BR_Information_PatientNo = "";
         BC000A6_A85BR_Information_ID = new long[1] ;
         BC000A6_n85BR_Information_ID = new bool[] {false} ;
         BC000A6_A48BR_DeathID = new long[1] ;
         BC000A6_A501BR_Death_CauseCode_Code = new String[] {""} ;
         BC000A6_n501BR_Death_CauseCode_Code = new bool[] {false} ;
         BC000A6_A469BR_Death_Sourse_Code = new String[] {""} ;
         BC000A6_n469BR_Death_Sourse_Code = new bool[] {false} ;
         BC000A6_A36BR_Information_PatientNo = new String[] {""} ;
         BC000A6_n36BR_Information_PatientNo = new bool[] {false} ;
         BC000A6_A49BR_Death_Date = new DateTime[] {DateTime.MinValue} ;
         BC000A6_n49BR_Death_Date = new bool[] {false} ;
         BC000A6_A50BR_Death_Cause = new String[] {""} ;
         BC000A6_n50BR_Death_Cause = new bool[] {false} ;
         BC000A6_A51BR_Death_CauseCode = new String[] {""} ;
         BC000A6_n51BR_Death_CauseCode = new bool[] {false} ;
         BC000A6_A52BR_Death_Sourse = new String[] {""} ;
         BC000A6_n52BR_Death_Sourse = new bool[] {false} ;
         BC000A6_A19BR_EncounterID = new long[1] ;
         BC000A4_A85BR_Information_ID = new long[1] ;
         BC000A4_n85BR_Information_ID = new bool[] {false} ;
         BC000A5_A36BR_Information_PatientNo = new String[] {""} ;
         BC000A5_n36BR_Information_PatientNo = new bool[] {false} ;
         BC000A7_A48BR_DeathID = new long[1] ;
         BC000A3_A48BR_DeathID = new long[1] ;
         BC000A3_A501BR_Death_CauseCode_Code = new String[] {""} ;
         BC000A3_n501BR_Death_CauseCode_Code = new bool[] {false} ;
         BC000A3_A469BR_Death_Sourse_Code = new String[] {""} ;
         BC000A3_n469BR_Death_Sourse_Code = new bool[] {false} ;
         BC000A3_A49BR_Death_Date = new DateTime[] {DateTime.MinValue} ;
         BC000A3_n49BR_Death_Date = new bool[] {false} ;
         BC000A3_A50BR_Death_Cause = new String[] {""} ;
         BC000A3_n50BR_Death_Cause = new bool[] {false} ;
         BC000A3_A51BR_Death_CauseCode = new String[] {""} ;
         BC000A3_n51BR_Death_CauseCode = new bool[] {false} ;
         BC000A3_A52BR_Death_Sourse = new String[] {""} ;
         BC000A3_n52BR_Death_Sourse = new bool[] {false} ;
         BC000A3_A19BR_EncounterID = new long[1] ;
         sMode11 = "";
         BC000A2_A48BR_DeathID = new long[1] ;
         BC000A2_A501BR_Death_CauseCode_Code = new String[] {""} ;
         BC000A2_n501BR_Death_CauseCode_Code = new bool[] {false} ;
         BC000A2_A469BR_Death_Sourse_Code = new String[] {""} ;
         BC000A2_n469BR_Death_Sourse_Code = new bool[] {false} ;
         BC000A2_A49BR_Death_Date = new DateTime[] {DateTime.MinValue} ;
         BC000A2_n49BR_Death_Date = new bool[] {false} ;
         BC000A2_A50BR_Death_Cause = new String[] {""} ;
         BC000A2_n50BR_Death_Cause = new bool[] {false} ;
         BC000A2_A51BR_Death_CauseCode = new String[] {""} ;
         BC000A2_n51BR_Death_CauseCode = new bool[] {false} ;
         BC000A2_A52BR_Death_Sourse = new String[] {""} ;
         BC000A2_n52BR_Death_Sourse = new bool[] {false} ;
         BC000A2_A19BR_EncounterID = new long[1] ;
         BC000A8_A48BR_DeathID = new long[1] ;
         BC000A11_A85BR_Information_ID = new long[1] ;
         BC000A11_n85BR_Information_ID = new bool[] {false} ;
         BC000A12_A36BR_Information_PatientNo = new String[] {""} ;
         BC000A12_n36BR_Information_PatientNo = new bool[] {false} ;
         BC000A13_A85BR_Information_ID = new long[1] ;
         BC000A13_n85BR_Information_ID = new bool[] {false} ;
         BC000A13_A48BR_DeathID = new long[1] ;
         BC000A13_A501BR_Death_CauseCode_Code = new String[] {""} ;
         BC000A13_n501BR_Death_CauseCode_Code = new bool[] {false} ;
         BC000A13_A469BR_Death_Sourse_Code = new String[] {""} ;
         BC000A13_n469BR_Death_Sourse_Code = new bool[] {false} ;
         BC000A13_A36BR_Information_PatientNo = new String[] {""} ;
         BC000A13_n36BR_Information_PatientNo = new bool[] {false} ;
         BC000A13_A49BR_Death_Date = new DateTime[] {DateTime.MinValue} ;
         BC000A13_n49BR_Death_Date = new bool[] {false} ;
         BC000A13_A50BR_Death_Cause = new String[] {""} ;
         BC000A13_n50BR_Death_Cause = new bool[] {false} ;
         BC000A13_A51BR_Death_CauseCode = new String[] {""} ;
         BC000A13_n51BR_Death_CauseCode = new bool[] {false} ;
         BC000A13_A52BR_Death_Sourse = new String[] {""} ;
         BC000A13_n52BR_Death_Sourse = new bool[] {false} ;
         BC000A13_A19BR_EncounterID = new long[1] ;
         GXt_char1 = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_death_bc__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_death_bc__default(),
            new Object[][] {
                new Object[] {
               BC000A2_A48BR_DeathID, BC000A2_A501BR_Death_CauseCode_Code, BC000A2_n501BR_Death_CauseCode_Code, BC000A2_A469BR_Death_Sourse_Code, BC000A2_n469BR_Death_Sourse_Code, BC000A2_A49BR_Death_Date, BC000A2_n49BR_Death_Date, BC000A2_A50BR_Death_Cause, BC000A2_n50BR_Death_Cause, BC000A2_A51BR_Death_CauseCode,
               BC000A2_n51BR_Death_CauseCode, BC000A2_A52BR_Death_Sourse, BC000A2_n52BR_Death_Sourse, BC000A2_A19BR_EncounterID
               }
               , new Object[] {
               BC000A3_A48BR_DeathID, BC000A3_A501BR_Death_CauseCode_Code, BC000A3_n501BR_Death_CauseCode_Code, BC000A3_A469BR_Death_Sourse_Code, BC000A3_n469BR_Death_Sourse_Code, BC000A3_A49BR_Death_Date, BC000A3_n49BR_Death_Date, BC000A3_A50BR_Death_Cause, BC000A3_n50BR_Death_Cause, BC000A3_A51BR_Death_CauseCode,
               BC000A3_n51BR_Death_CauseCode, BC000A3_A52BR_Death_Sourse, BC000A3_n52BR_Death_Sourse, BC000A3_A19BR_EncounterID
               }
               , new Object[] {
               BC000A4_A85BR_Information_ID, BC000A4_n85BR_Information_ID
               }
               , new Object[] {
               BC000A5_A36BR_Information_PatientNo, BC000A5_n36BR_Information_PatientNo
               }
               , new Object[] {
               BC000A6_A85BR_Information_ID, BC000A6_n85BR_Information_ID, BC000A6_A48BR_DeathID, BC000A6_A501BR_Death_CauseCode_Code, BC000A6_n501BR_Death_CauseCode_Code, BC000A6_A469BR_Death_Sourse_Code, BC000A6_n469BR_Death_Sourse_Code, BC000A6_A36BR_Information_PatientNo, BC000A6_n36BR_Information_PatientNo, BC000A6_A49BR_Death_Date,
               BC000A6_n49BR_Death_Date, BC000A6_A50BR_Death_Cause, BC000A6_n50BR_Death_Cause, BC000A6_A51BR_Death_CauseCode, BC000A6_n51BR_Death_CauseCode, BC000A6_A52BR_Death_Sourse, BC000A6_n52BR_Death_Sourse, BC000A6_A19BR_EncounterID
               }
               , new Object[] {
               BC000A7_A48BR_DeathID
               }
               , new Object[] {
               BC000A8_A48BR_DeathID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000A11_A85BR_Information_ID, BC000A11_n85BR_Information_ID
               }
               , new Object[] {
               BC000A12_A36BR_Information_PatientNo, BC000A12_n36BR_Information_PatientNo
               }
               , new Object[] {
               BC000A13_A85BR_Information_ID, BC000A13_n85BR_Information_ID, BC000A13_A48BR_DeathID, BC000A13_A501BR_Death_CauseCode_Code, BC000A13_n501BR_Death_CauseCode_Code, BC000A13_A469BR_Death_Sourse_Code, BC000A13_n469BR_Death_Sourse_Code, BC000A13_A36BR_Information_PatientNo, BC000A13_n36BR_Information_PatientNo, BC000A13_A49BR_Death_Date,
               BC000A13_n49BR_Death_Date, BC000A13_A50BR_Death_Cause, BC000A13_n50BR_Death_Cause, BC000A13_A51BR_Death_CauseCode, BC000A13_n51BR_Death_CauseCode, BC000A13_A52BR_Death_Sourse, BC000A13_n52BR_Death_Sourse, BC000A13_A19BR_EncounterID
               }
            }
         );
         INITTRN();
         /* Execute Start event if defined. */
         /* Execute user event: Start */
         E120A2 ();
         standaloneNotModal( ) ;
      }

      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short GX_JID ;
      private short RcdFound11 ;
      private int trnEnded ;
      private long Z48BR_DeathID ;
      private long A48BR_DeathID ;
      private long Z19BR_EncounterID ;
      private long A19BR_EncounterID ;
      private long Z85BR_Information_ID ;
      private long A85BR_Information_ID ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String sMode11 ;
      private String GXt_char1 ;
      private DateTime Z49BR_Death_Date ;
      private DateTime A49BR_Death_Date ;
      private bool n85BR_Information_ID ;
      private bool n501BR_Death_CauseCode_Code ;
      private bool n469BR_Death_Sourse_Code ;
      private bool n36BR_Information_PatientNo ;
      private bool n49BR_Death_Date ;
      private bool n50BR_Death_Cause ;
      private bool n51BR_Death_CauseCode ;
      private bool n52BR_Death_Sourse ;
      private bool Gx_longc ;
      private String Z501BR_Death_CauseCode_Code ;
      private String A501BR_Death_CauseCode_Code ;
      private String Z469BR_Death_Sourse_Code ;
      private String A469BR_Death_Sourse_Code ;
      private String Z50BR_Death_Cause ;
      private String A50BR_Death_Cause ;
      private String Z51BR_Death_CauseCode ;
      private String A51BR_Death_CauseCode ;
      private String Z52BR_Death_Sourse ;
      private String A52BR_Death_Sourse ;
      private String Z36BR_Information_PatientNo ;
      private String A36BR_Information_PatientNo ;
      private SdtBR_Death bcBR_Death ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] BC000A6_A85BR_Information_ID ;
      private bool[] BC000A6_n85BR_Information_ID ;
      private long[] BC000A6_A48BR_DeathID ;
      private String[] BC000A6_A501BR_Death_CauseCode_Code ;
      private bool[] BC000A6_n501BR_Death_CauseCode_Code ;
      private String[] BC000A6_A469BR_Death_Sourse_Code ;
      private bool[] BC000A6_n469BR_Death_Sourse_Code ;
      private String[] BC000A6_A36BR_Information_PatientNo ;
      private bool[] BC000A6_n36BR_Information_PatientNo ;
      private DateTime[] BC000A6_A49BR_Death_Date ;
      private bool[] BC000A6_n49BR_Death_Date ;
      private String[] BC000A6_A50BR_Death_Cause ;
      private bool[] BC000A6_n50BR_Death_Cause ;
      private String[] BC000A6_A51BR_Death_CauseCode ;
      private bool[] BC000A6_n51BR_Death_CauseCode ;
      private String[] BC000A6_A52BR_Death_Sourse ;
      private bool[] BC000A6_n52BR_Death_Sourse ;
      private long[] BC000A6_A19BR_EncounterID ;
      private long[] BC000A4_A85BR_Information_ID ;
      private bool[] BC000A4_n85BR_Information_ID ;
      private String[] BC000A5_A36BR_Information_PatientNo ;
      private bool[] BC000A5_n36BR_Information_PatientNo ;
      private long[] BC000A7_A48BR_DeathID ;
      private long[] BC000A3_A48BR_DeathID ;
      private String[] BC000A3_A501BR_Death_CauseCode_Code ;
      private bool[] BC000A3_n501BR_Death_CauseCode_Code ;
      private String[] BC000A3_A469BR_Death_Sourse_Code ;
      private bool[] BC000A3_n469BR_Death_Sourse_Code ;
      private DateTime[] BC000A3_A49BR_Death_Date ;
      private bool[] BC000A3_n49BR_Death_Date ;
      private String[] BC000A3_A50BR_Death_Cause ;
      private bool[] BC000A3_n50BR_Death_Cause ;
      private String[] BC000A3_A51BR_Death_CauseCode ;
      private bool[] BC000A3_n51BR_Death_CauseCode ;
      private String[] BC000A3_A52BR_Death_Sourse ;
      private bool[] BC000A3_n52BR_Death_Sourse ;
      private long[] BC000A3_A19BR_EncounterID ;
      private long[] BC000A2_A48BR_DeathID ;
      private String[] BC000A2_A501BR_Death_CauseCode_Code ;
      private bool[] BC000A2_n501BR_Death_CauseCode_Code ;
      private String[] BC000A2_A469BR_Death_Sourse_Code ;
      private bool[] BC000A2_n469BR_Death_Sourse_Code ;
      private DateTime[] BC000A2_A49BR_Death_Date ;
      private bool[] BC000A2_n49BR_Death_Date ;
      private String[] BC000A2_A50BR_Death_Cause ;
      private bool[] BC000A2_n50BR_Death_Cause ;
      private String[] BC000A2_A51BR_Death_CauseCode ;
      private bool[] BC000A2_n51BR_Death_CauseCode ;
      private String[] BC000A2_A52BR_Death_Sourse ;
      private bool[] BC000A2_n52BR_Death_Sourse ;
      private long[] BC000A2_A19BR_EncounterID ;
      private long[] BC000A8_A48BR_DeathID ;
      private long[] BC000A11_A85BR_Information_ID ;
      private bool[] BC000A11_n85BR_Information_ID ;
      private String[] BC000A12_A36BR_Information_PatientNo ;
      private bool[] BC000A12_n36BR_Information_PatientNo ;
      private long[] BC000A13_A85BR_Information_ID ;
      private bool[] BC000A13_n85BR_Information_ID ;
      private long[] BC000A13_A48BR_DeathID ;
      private String[] BC000A13_A501BR_Death_CauseCode_Code ;
      private bool[] BC000A13_n501BR_Death_CauseCode_Code ;
      private String[] BC000A13_A469BR_Death_Sourse_Code ;
      private bool[] BC000A13_n469BR_Death_Sourse_Code ;
      private String[] BC000A13_A36BR_Information_PatientNo ;
      private bool[] BC000A13_n36BR_Information_PatientNo ;
      private DateTime[] BC000A13_A49BR_Death_Date ;
      private bool[] BC000A13_n49BR_Death_Date ;
      private String[] BC000A13_A50BR_Death_Cause ;
      private bool[] BC000A13_n50BR_Death_Cause ;
      private String[] BC000A13_A51BR_Death_CauseCode ;
      private bool[] BC000A13_n51BR_Death_CauseCode ;
      private String[] BC000A13_A52BR_Death_Sourse ;
      private bool[] BC000A13_n52BR_Death_Sourse ;
      private long[] BC000A13_A19BR_EncounterID ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_datastore1 ;
   }

   public class br_death_bc__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class br_death_bc__default : DataStoreHelperBase, IDataStoreHelper
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
        Object[] prmBC000A6 ;
        prmBC000A6 = new Object[] {
        new Object[] {"@BR_DeathID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000A4 ;
        prmBC000A4 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000A5 ;
        prmBC000A5 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000A7 ;
        prmBC000A7 = new Object[] {
        new Object[] {"@BR_DeathID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000A3 ;
        prmBC000A3 = new Object[] {
        new Object[] {"@BR_DeathID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000A2 ;
        prmBC000A2 = new Object[] {
        new Object[] {"@BR_DeathID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000A8 ;
        prmBC000A8 = new Object[] {
        new Object[] {"@BR_Death_CauseCode_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Death_Sourse_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Death_Date",SqlDbType.DateTime,8,0} ,
        new Object[] {"@BR_Death_Cause",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Death_CauseCode",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Death_Sourse",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000A9 ;
        prmBC000A9 = new Object[] {
        new Object[] {"@BR_Death_CauseCode_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Death_Sourse_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Death_Date",SqlDbType.DateTime,8,0} ,
        new Object[] {"@BR_Death_Cause",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Death_CauseCode",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Death_Sourse",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_DeathID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000A10 ;
        prmBC000A10 = new Object[] {
        new Object[] {"@BR_DeathID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000A11 ;
        prmBC000A11 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000A12 ;
        prmBC000A12 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000A13 ;
        prmBC000A13 = new Object[] {
        new Object[] {"@BR_DeathID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("BC000A2", "SELECT [BR_DeathID], [BR_Death_CauseCode_Code], [BR_Death_Sourse_Code], [BR_Death_Date], [BR_Death_Cause], [BR_Death_CauseCode], [BR_Death_Sourse], [BR_EncounterID] FROM [BR_Death] WITH (UPDLOCK) WHERE [BR_DeathID] = @BR_DeathID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000A2,1,0,true,false )
           ,new CursorDef("BC000A3", "SELECT [BR_DeathID], [BR_Death_CauseCode_Code], [BR_Death_Sourse_Code], [BR_Death_Date], [BR_Death_Cause], [BR_Death_CauseCode], [BR_Death_Sourse], [BR_EncounterID] FROM [BR_Death] WITH (NOLOCK) WHERE [BR_DeathID] = @BR_DeathID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000A3,1,0,true,false )
           ,new CursorDef("BC000A4", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000A4,1,0,true,false )
           ,new CursorDef("BC000A5", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000A5,1,0,true,false )
           ,new CursorDef("BC000A6", "SELECT T2.[BR_Information_ID], TM1.[BR_DeathID], TM1.[BR_Death_CauseCode_Code], TM1.[BR_Death_Sourse_Code], T3.[BR_Information_PatientNo], TM1.[BR_Death_Date], TM1.[BR_Death_Cause], TM1.[BR_Death_CauseCode], TM1.[BR_Death_Sourse], TM1.[BR_EncounterID] FROM (([BR_Death] TM1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = TM1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID]) WHERE TM1.[BR_DeathID] = @BR_DeathID ORDER BY TM1.[BR_DeathID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000A6,100,0,true,false )
           ,new CursorDef("BC000A7", "SELECT [BR_DeathID] FROM [BR_Death] WITH (NOLOCK) WHERE [BR_DeathID] = @BR_DeathID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000A7,1,0,true,false )
           ,new CursorDef("BC000A8", "INSERT INTO [BR_Death]([BR_Death_CauseCode_Code], [BR_Death_Sourse_Code], [BR_Death_Date], [BR_Death_Cause], [BR_Death_CauseCode], [BR_Death_Sourse], [BR_EncounterID]) VALUES(@BR_Death_CauseCode_Code, @BR_Death_Sourse_Code, @BR_Death_Date, @BR_Death_Cause, @BR_Death_CauseCode, @BR_Death_Sourse, @BR_EncounterID); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmBC000A8)
           ,new CursorDef("BC000A9", "UPDATE [BR_Death] SET [BR_Death_CauseCode_Code]=@BR_Death_CauseCode_Code, [BR_Death_Sourse_Code]=@BR_Death_Sourse_Code, [BR_Death_Date]=@BR_Death_Date, [BR_Death_Cause]=@BR_Death_Cause, [BR_Death_CauseCode]=@BR_Death_CauseCode, [BR_Death_Sourse]=@BR_Death_Sourse, [BR_EncounterID]=@BR_EncounterID  WHERE [BR_DeathID] = @BR_DeathID", GxErrorMask.GX_NOMASK,prmBC000A9)
           ,new CursorDef("BC000A10", "DELETE FROM [BR_Death]  WHERE [BR_DeathID] = @BR_DeathID", GxErrorMask.GX_NOMASK,prmBC000A10)
           ,new CursorDef("BC000A11", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000A11,1,0,true,false )
           ,new CursorDef("BC000A12", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000A12,1,0,true,false )
           ,new CursorDef("BC000A13", "SELECT T2.[BR_Information_ID], TM1.[BR_DeathID], TM1.[BR_Death_CauseCode_Code], TM1.[BR_Death_Sourse_Code], T3.[BR_Information_PatientNo], TM1.[BR_Death_Date], TM1.[BR_Death_Cause], TM1.[BR_Death_CauseCode], TM1.[BR_Death_Sourse], TM1.[BR_EncounterID] FROM (([BR_Death] TM1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = TM1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID]) WHERE TM1.[BR_DeathID] = @BR_DeathID ORDER BY TM1.[BR_DeathID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000A13,100,0,true,false )
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
              ((DateTime[]) buf[5])[0] = rslt.getGXDate(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((long[]) buf[13])[0] = rslt.getLong(8) ;
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((DateTime[]) buf[5])[0] = rslt.getGXDate(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((long[]) buf[13])[0] = rslt.getLong(8) ;
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
              ((DateTime[]) buf[9])[0] = rslt.getGXDate(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((long[]) buf[17])[0] = rslt.getLong(10) ;
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
              ((DateTime[]) buf[9])[0] = rslt.getGXDate(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((long[]) buf[17])[0] = rslt.getLong(10) ;
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
                 stmt.setNull( 3 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameter(3, (DateTime)parms[5]);
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
              stmt.SetParameter(7, (long)parms[12]);
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
                 stmt.setNull( 3 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameter(3, (DateTime)parms[5]);
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
              stmt.SetParameter(7, (long)parms[12]);
              stmt.SetParameter(8, (long)parms[13]);
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
