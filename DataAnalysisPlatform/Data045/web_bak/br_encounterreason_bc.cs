/*
               File: BR_EncounterReason_BC
        Description: 初审不通过原因
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:38:44.55
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
   public class br_encounterreason_bc : GXHttpHandler, IGxSilentTrn
   {
      public br_encounterreason_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_encounterreason_bc( IGxContext context )
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
         ReadRow1441( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey1441( ) ;
         standaloneModal( ) ;
         AddRow1441( ) ;
         Gx_mode = "INS";
         return  ;
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E11142 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               Z347BR_Encounter_ID = A347BR_Encounter_ID;
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

      protected void CONFIRM_140( )
      {
         BeforeValidate1441( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls1441( ) ;
            }
            else
            {
               CheckExtendedTable1441( ) ;
               if ( AnyError == 0 )
               {
                  ZM1441( 7) ;
               }
               CloseExtendedTableCursors1441( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void E12142( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV7WWPContext) ;
         AV8IsAuthorized = true;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            GXt_boolean1 = AV8IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWBR_EncounterReason_Insert", out  GXt_boolean1) ;
            AV8IsAuthorized = GXt_boolean1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            GXt_boolean1 = AV8IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWBR_EncounterReason_Update", out  GXt_boolean1) ;
            AV8IsAuthorized = GXt_boolean1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            GXt_boolean1 = AV8IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWBR_EncounterReason_Delete", out  GXt_boolean1) ;
            AV8IsAuthorized = GXt_boolean1;
         }
         if ( ! AV8IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV17Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV10TrnContext.FromXml(AV11WebSession.Get("TrnContext"), null, "WWPTransactionContext", "DataAnalysisPlatform");
         if ( ( StringUtil.StrCmp(AV10TrnContext.gxTpr_Transactionname, AV17Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV18GXV1 = 1;
            while ( AV18GXV1 <= AV10TrnContext.gxTpr_Attributes.Count )
            {
               AV14TrnContextAtt = ((GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute)AV10TrnContext.gxTpr_Attributes.Item(AV18GXV1));
               if ( StringUtil.StrCmp(AV14TrnContextAtt.gxTpr_Attributename, "BR_EncounterID") == 0 )
               {
                  AV15Insert_BR_EncounterID = (long)(NumberUtil.Val( AV14TrnContextAtt.gxTpr_Attributevalue, "."));
               }
               AV18GXV1 = (int)(AV18GXV1+1);
            }
         }
      }

      protected void E11142( )
      {
         /* After Trn Routine */
      }

      protected void ZM1441( short GX_JID )
      {
         if ( ( GX_JID == 6 ) || ( GX_JID == 0 ) )
         {
            Z340BR_EncounterReason_Reason = A340BR_EncounterReason_Reason;
            Z341BR_EncounterReason_IsRandNoApproveDate = A341BR_EncounterReason_IsRandNoApproveDate;
            Z342BR_EncounterReason_IsRandApprove = A342BR_EncounterReason_IsRandApprove;
            Z343BR_EncounterReason_Status = A343BR_EncounterReason_Status;
            Z344BR_EncounterReason_IsRandApprover = A344BR_EncounterReason_IsRandApprover;
            Z19BR_EncounterID = A19BR_EncounterID;
         }
         if ( ( GX_JID == 7 ) || ( GX_JID == 0 ) )
         {
         }
         if ( GX_JID == -6 )
         {
            Z347BR_Encounter_ID = A347BR_Encounter_ID;
            Z340BR_EncounterReason_Reason = A340BR_EncounterReason_Reason;
            Z341BR_EncounterReason_IsRandNoApproveDate = A341BR_EncounterReason_IsRandNoApproveDate;
            Z342BR_EncounterReason_IsRandApprove = A342BR_EncounterReason_IsRandApprove;
            Z343BR_EncounterReason_Status = A343BR_EncounterReason_Status;
            Z344BR_EncounterReason_IsRandApprover = A344BR_EncounterReason_IsRandApprover;
            Z19BR_EncounterID = A19BR_EncounterID;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load1441( )
      {
         /* Using cursor BC00145 */
         pr_default.execute(3, new Object[] {A347BR_Encounter_ID});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound41 = 1;
            A340BR_EncounterReason_Reason = BC00145_A340BR_EncounterReason_Reason[0];
            n340BR_EncounterReason_Reason = BC00145_n340BR_EncounterReason_Reason[0];
            A341BR_EncounterReason_IsRandNoApproveDate = BC00145_A341BR_EncounterReason_IsRandNoApproveDate[0];
            n341BR_EncounterReason_IsRandNoApproveDate = BC00145_n341BR_EncounterReason_IsRandNoApproveDate[0];
            A342BR_EncounterReason_IsRandApprove = BC00145_A342BR_EncounterReason_IsRandApprove[0];
            n342BR_EncounterReason_IsRandApprove = BC00145_n342BR_EncounterReason_IsRandApprove[0];
            A343BR_EncounterReason_Status = BC00145_A343BR_EncounterReason_Status[0];
            n343BR_EncounterReason_Status = BC00145_n343BR_EncounterReason_Status[0];
            A344BR_EncounterReason_IsRandApprover = BC00145_A344BR_EncounterReason_IsRandApprover[0];
            n344BR_EncounterReason_IsRandApprover = BC00145_n344BR_EncounterReason_IsRandApprover[0];
            A19BR_EncounterID = BC00145_A19BR_EncounterID[0];
            ZM1441( -6) ;
         }
         pr_default.close(3);
         OnLoadActions1441( ) ;
      }

      protected void OnLoadActions1441( )
      {
         AV17Pgmname = "BR_EncounterReason_BC";
      }

      protected void CheckExtendedTable1441( )
      {
         standaloneModal( ) ;
         AV17Pgmname = "BR_EncounterReason_BC";
         if ( (0==A347BR_Encounter_ID) )
         {
            GX_msglist.addItem("主键是必须填写的。", 1, "");
            AnyError = 1;
         }
         /* Using cursor BC00144 */
         pr_default.execute(2, new Object[] {A19BR_EncounterID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("不匹配' T15'", "ForeignKeyNotFound", 1, "BR_ENCOUNTERID");
            AnyError = 1;
         }
         pr_default.close(2);
         if ( ! ( (DateTime.MinValue==A341BR_EncounterReason_IsRandNoApproveDate) || ( A341BR_EncounterReason_IsRandNoApproveDate >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("域���������������������超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
         if ( ! ( ( A343BR_EncounterReason_Status == 1 ) || ( A343BR_EncounterReason_Status == 2 ) || (0==A343BR_EncounterReason_Status) ) )
         {
            GX_msglist.addItem("域������������超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
      }

      protected void CloseExtendedTableCursors1441( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey1441( )
      {
         /* Using cursor BC00146 */
         pr_default.execute(4, new Object[] {A347BR_Encounter_ID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound41 = 1;
         }
         else
         {
            RcdFound41 = 0;
         }
         pr_default.close(4);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC00143 */
         pr_default.execute(1, new Object[] {A347BR_Encounter_ID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM1441( 6) ;
            RcdFound41 = 1;
            A347BR_Encounter_ID = BC00143_A347BR_Encounter_ID[0];
            A340BR_EncounterReason_Reason = BC00143_A340BR_EncounterReason_Reason[0];
            n340BR_EncounterReason_Reason = BC00143_n340BR_EncounterReason_Reason[0];
            A341BR_EncounterReason_IsRandNoApproveDate = BC00143_A341BR_EncounterReason_IsRandNoApproveDate[0];
            n341BR_EncounterReason_IsRandNoApproveDate = BC00143_n341BR_EncounterReason_IsRandNoApproveDate[0];
            A342BR_EncounterReason_IsRandApprove = BC00143_A342BR_EncounterReason_IsRandApprove[0];
            n342BR_EncounterReason_IsRandApprove = BC00143_n342BR_EncounterReason_IsRandApprove[0];
            A343BR_EncounterReason_Status = BC00143_A343BR_EncounterReason_Status[0];
            n343BR_EncounterReason_Status = BC00143_n343BR_EncounterReason_Status[0];
            A344BR_EncounterReason_IsRandApprover = BC00143_A344BR_EncounterReason_IsRandApprover[0];
            n344BR_EncounterReason_IsRandApprover = BC00143_n344BR_EncounterReason_IsRandApprover[0];
            A19BR_EncounterID = BC00143_A19BR_EncounterID[0];
            Z347BR_Encounter_ID = A347BR_Encounter_ID;
            sMode41 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load1441( ) ;
            if ( AnyError == 1 )
            {
               RcdFound41 = 0;
               InitializeNonKey1441( ) ;
            }
            Gx_mode = sMode41;
         }
         else
         {
            RcdFound41 = 0;
            InitializeNonKey1441( ) ;
            sMode41 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode41;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1441( ) ;
         if ( RcdFound41 == 0 )
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
         CONFIRM_140( ) ;
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

      protected void CheckOptimisticConcurrency1441( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC00142 */
            pr_default.execute(0, new Object[] {A347BR_Encounter_ID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_EncounterReason"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z340BR_EncounterReason_Reason, BC00142_A340BR_EncounterReason_Reason[0]) != 0 ) || ( Z341BR_EncounterReason_IsRandNoApproveDate != BC00142_A341BR_EncounterReason_IsRandNoApproveDate[0] ) || ( Z342BR_EncounterReason_IsRandApprove != BC00142_A342BR_EncounterReason_IsRandApprove[0] ) || ( Z343BR_EncounterReason_Status != BC00142_A343BR_EncounterReason_Status[0] ) || ( StringUtil.StrCmp(Z344BR_EncounterReason_IsRandApprover, BC00142_A344BR_EncounterReason_IsRandApprover[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z19BR_EncounterID != BC00142_A19BR_EncounterID[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"BR_EncounterReason"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert1441( )
      {
         BeforeValidate1441( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1441( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1441( 0) ;
            CheckOptimisticConcurrency1441( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1441( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1441( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00147 */
                     pr_default.execute(5, new Object[] {n340BR_EncounterReason_Reason, A340BR_EncounterReason_Reason, n341BR_EncounterReason_IsRandNoApproveDate, A341BR_EncounterReason_IsRandNoApproveDate, n342BR_EncounterReason_IsRandApprove, A342BR_EncounterReason_IsRandApprove, n343BR_EncounterReason_Status, A343BR_EncounterReason_Status, n344BR_EncounterReason_IsRandApprover, A344BR_EncounterReason_IsRandApprover, A19BR_EncounterID});
                     A347BR_Encounter_ID = BC00147_A347BR_Encounter_ID[0];
                     pr_default.close(5);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_EncounterReason") ;
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
               Load1441( ) ;
            }
            EndLevel1441( ) ;
         }
         CloseExtendedTableCursors1441( ) ;
      }

      protected void Update1441( )
      {
         BeforeValidate1441( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1441( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1441( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1441( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1441( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00148 */
                     pr_default.execute(6, new Object[] {n340BR_EncounterReason_Reason, A340BR_EncounterReason_Reason, n341BR_EncounterReason_IsRandNoApproveDate, A341BR_EncounterReason_IsRandNoApproveDate, n342BR_EncounterReason_IsRandApprove, A342BR_EncounterReason_IsRandApprove, n343BR_EncounterReason_Status, A343BR_EncounterReason_Status, n344BR_EncounterReason_IsRandApprover, A344BR_EncounterReason_IsRandApprover, A19BR_EncounterID, A347BR_Encounter_ID});
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_EncounterReason") ;
                     if ( (pr_default.getStatus(6) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_EncounterReason"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate1441( ) ;
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
            EndLevel1441( ) ;
         }
         CloseExtendedTableCursors1441( ) ;
      }

      protected void DeferredUpdate1441( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate1441( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1441( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1441( ) ;
            AfterConfirm1441( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1441( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC00149 */
                  pr_default.execute(7, new Object[] {A347BR_Encounter_ID});
                  pr_default.close(7);
                  dsDefault.SmartCacheProvider.SetUpdated("BR_EncounterReason") ;
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
         sMode41 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel1441( ) ;
         Gx_mode = sMode41;
      }

      protected void OnDeleteControls1441( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV17Pgmname = "BR_EncounterReason_BC";
         }
      }

      protected void EndLevel1441( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1441( ) ;
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

      public void ScanKeyStart1441( )
      {
         /* Scan By routine */
         /* Using cursor BC001410 */
         pr_default.execute(8, new Object[] {A347BR_Encounter_ID});
         RcdFound41 = 0;
         if ( (pr_default.getStatus(8) != 101) )
         {
            RcdFound41 = 1;
            A347BR_Encounter_ID = BC001410_A347BR_Encounter_ID[0];
            A340BR_EncounterReason_Reason = BC001410_A340BR_EncounterReason_Reason[0];
            n340BR_EncounterReason_Reason = BC001410_n340BR_EncounterReason_Reason[0];
            A341BR_EncounterReason_IsRandNoApproveDate = BC001410_A341BR_EncounterReason_IsRandNoApproveDate[0];
            n341BR_EncounterReason_IsRandNoApproveDate = BC001410_n341BR_EncounterReason_IsRandNoApproveDate[0];
            A342BR_EncounterReason_IsRandApprove = BC001410_A342BR_EncounterReason_IsRandApprove[0];
            n342BR_EncounterReason_IsRandApprove = BC001410_n342BR_EncounterReason_IsRandApprove[0];
            A343BR_EncounterReason_Status = BC001410_A343BR_EncounterReason_Status[0];
            n343BR_EncounterReason_Status = BC001410_n343BR_EncounterReason_Status[0];
            A344BR_EncounterReason_IsRandApprover = BC001410_A344BR_EncounterReason_IsRandApprover[0];
            n344BR_EncounterReason_IsRandApprover = BC001410_n344BR_EncounterReason_IsRandApprover[0];
            A19BR_EncounterID = BC001410_A19BR_EncounterID[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext1441( )
      {
         /* Scan next routine */
         pr_default.readNext(8);
         RcdFound41 = 0;
         ScanKeyLoad1441( ) ;
      }

      protected void ScanKeyLoad1441( )
      {
         sMode41 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(8) != 101) )
         {
            RcdFound41 = 1;
            A347BR_Encounter_ID = BC001410_A347BR_Encounter_ID[0];
            A340BR_EncounterReason_Reason = BC001410_A340BR_EncounterReason_Reason[0];
            n340BR_EncounterReason_Reason = BC001410_n340BR_EncounterReason_Reason[0];
            A341BR_EncounterReason_IsRandNoApproveDate = BC001410_A341BR_EncounterReason_IsRandNoApproveDate[0];
            n341BR_EncounterReason_IsRandNoApproveDate = BC001410_n341BR_EncounterReason_IsRandNoApproveDate[0];
            A342BR_EncounterReason_IsRandApprove = BC001410_A342BR_EncounterReason_IsRandApprove[0];
            n342BR_EncounterReason_IsRandApprove = BC001410_n342BR_EncounterReason_IsRandApprove[0];
            A343BR_EncounterReason_Status = BC001410_A343BR_EncounterReason_Status[0];
            n343BR_EncounterReason_Status = BC001410_n343BR_EncounterReason_Status[0];
            A344BR_EncounterReason_IsRandApprover = BC001410_A344BR_EncounterReason_IsRandApprover[0];
            n344BR_EncounterReason_IsRandApprover = BC001410_n344BR_EncounterReason_IsRandApprover[0];
            A19BR_EncounterID = BC001410_A19BR_EncounterID[0];
         }
         Gx_mode = sMode41;
      }

      protected void ScanKeyEnd1441( )
      {
         pr_default.close(8);
      }

      protected void AfterConfirm1441( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1441( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1441( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1441( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1441( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1441( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1441( )
      {
      }

      protected void send_integrity_lvl_hashes1441( )
      {
      }

      protected void AddRow1441( )
      {
         VarsToRow41( bcBR_EncounterReason) ;
      }

      protected void ReadRow1441( )
      {
         RowToVars41( bcBR_EncounterReason, 1) ;
      }

      protected void InitializeNonKey1441( )
      {
         A19BR_EncounterID = 0;
         A340BR_EncounterReason_Reason = "";
         n340BR_EncounterReason_Reason = false;
         A341BR_EncounterReason_IsRandNoApproveDate = (DateTime)(DateTime.MinValue);
         n341BR_EncounterReason_IsRandNoApproveDate = false;
         A342BR_EncounterReason_IsRandApprove = false;
         n342BR_EncounterReason_IsRandApprove = false;
         A343BR_EncounterReason_Status = 0;
         n343BR_EncounterReason_Status = false;
         A344BR_EncounterReason_IsRandApprover = "";
         n344BR_EncounterReason_IsRandApprover = false;
         Z340BR_EncounterReason_Reason = "";
         Z341BR_EncounterReason_IsRandNoApproveDate = (DateTime)(DateTime.MinValue);
         Z342BR_EncounterReason_IsRandApprove = false;
         Z343BR_EncounterReason_Status = 0;
         Z344BR_EncounterReason_IsRandApprover = "";
         Z19BR_EncounterID = 0;
      }

      protected void InitAll1441( )
      {
         A347BR_Encounter_ID = 0;
         InitializeNonKey1441( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow41( SdtBR_EncounterReason obj41 )
      {
         obj41.gxTpr_Mode = Gx_mode;
         obj41.gxTpr_Br_encounterid = A19BR_EncounterID;
         obj41.gxTpr_Br_encounterreason_reason = A340BR_EncounterReason_Reason;
         obj41.gxTpr_Br_encounterreason_israndnoapprovedate = A341BR_EncounterReason_IsRandNoApproveDate;
         obj41.gxTpr_Br_encounterreason_israndapprove = A342BR_EncounterReason_IsRandApprove;
         obj41.gxTpr_Br_encounterreason_status = A343BR_EncounterReason_Status;
         obj41.gxTpr_Br_encounterreason_israndapprover = A344BR_EncounterReason_IsRandApprover;
         obj41.gxTpr_Br_encounter_id = A347BR_Encounter_ID;
         obj41.gxTpr_Br_encounter_id_Z = Z347BR_Encounter_ID;
         obj41.gxTpr_Br_encounterid_Z = Z19BR_EncounterID;
         obj41.gxTpr_Br_encounterreason_reason_Z = Z340BR_EncounterReason_Reason;
         obj41.gxTpr_Br_encounterreason_israndnoapprovedate_Z = Z341BR_EncounterReason_IsRandNoApproveDate;
         obj41.gxTpr_Br_encounterreason_israndapprove_Z = Z342BR_EncounterReason_IsRandApprove;
         obj41.gxTpr_Br_encounterreason_status_Z = Z343BR_EncounterReason_Status;
         obj41.gxTpr_Br_encounterreason_israndapprover_Z = Z344BR_EncounterReason_IsRandApprover;
         obj41.gxTpr_Br_encounterreason_reason_N = (short)(Convert.ToInt16(n340BR_EncounterReason_Reason));
         obj41.gxTpr_Br_encounterreason_israndnoapprovedate_N = (short)(Convert.ToInt16(n341BR_EncounterReason_IsRandNoApproveDate));
         obj41.gxTpr_Br_encounterreason_israndapprove_N = (short)(Convert.ToInt16(n342BR_EncounterReason_IsRandApprove));
         obj41.gxTpr_Br_encounterreason_status_N = (short)(Convert.ToInt16(n343BR_EncounterReason_Status));
         obj41.gxTpr_Br_encounterreason_israndapprover_N = (short)(Convert.ToInt16(n344BR_EncounterReason_IsRandApprover));
         obj41.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow41( SdtBR_EncounterReason obj41 )
      {
         obj41.gxTpr_Br_encounter_id = A347BR_Encounter_ID;
         return  ;
      }

      public void RowToVars41( SdtBR_EncounterReason obj41 ,
                               int forceLoad )
      {
         Gx_mode = obj41.gxTpr_Mode;
         A19BR_EncounterID = obj41.gxTpr_Br_encounterid;
         A340BR_EncounterReason_Reason = obj41.gxTpr_Br_encounterreason_reason;
         n340BR_EncounterReason_Reason = false;
         A341BR_EncounterReason_IsRandNoApproveDate = obj41.gxTpr_Br_encounterreason_israndnoapprovedate;
         n341BR_EncounterReason_IsRandNoApproveDate = false;
         A342BR_EncounterReason_IsRandApprove = obj41.gxTpr_Br_encounterreason_israndapprove;
         n342BR_EncounterReason_IsRandApprove = false;
         A343BR_EncounterReason_Status = obj41.gxTpr_Br_encounterreason_status;
         n343BR_EncounterReason_Status = false;
         A344BR_EncounterReason_IsRandApprover = obj41.gxTpr_Br_encounterreason_israndapprover;
         n344BR_EncounterReason_IsRandApprover = false;
         A347BR_Encounter_ID = obj41.gxTpr_Br_encounter_id;
         Z347BR_Encounter_ID = obj41.gxTpr_Br_encounter_id_Z;
         Z19BR_EncounterID = obj41.gxTpr_Br_encounterid_Z;
         Z340BR_EncounterReason_Reason = obj41.gxTpr_Br_encounterreason_reason_Z;
         Z341BR_EncounterReason_IsRandNoApproveDate = obj41.gxTpr_Br_encounterreason_israndnoapprovedate_Z;
         Z342BR_EncounterReason_IsRandApprove = obj41.gxTpr_Br_encounterreason_israndapprove_Z;
         Z343BR_EncounterReason_Status = obj41.gxTpr_Br_encounterreason_status_Z;
         Z344BR_EncounterReason_IsRandApprover = obj41.gxTpr_Br_encounterreason_israndapprover_Z;
         n340BR_EncounterReason_Reason = (bool)(Convert.ToBoolean(obj41.gxTpr_Br_encounterreason_reason_N));
         n341BR_EncounterReason_IsRandNoApproveDate = (bool)(Convert.ToBoolean(obj41.gxTpr_Br_encounterreason_israndnoapprovedate_N));
         n342BR_EncounterReason_IsRandApprove = (bool)(Convert.ToBoolean(obj41.gxTpr_Br_encounterreason_israndapprove_N));
         n343BR_EncounterReason_Status = (bool)(Convert.ToBoolean(obj41.gxTpr_Br_encounterreason_status_N));
         n344BR_EncounterReason_IsRandApprover = (bool)(Convert.ToBoolean(obj41.gxTpr_Br_encounterreason_israndapprover_N));
         Gx_mode = obj41.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A347BR_Encounter_ID = (long)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey1441( ) ;
         ScanKeyStart1441( ) ;
         if ( RcdFound41 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z347BR_Encounter_ID = A347BR_Encounter_ID;
         }
         ZM1441( -6) ;
         OnLoadActions1441( ) ;
         AddRow1441( ) ;
         ScanKeyEnd1441( ) ;
         if ( RcdFound41 == 0 )
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
         RowToVars41( bcBR_EncounterReason, 0) ;
         ScanKeyStart1441( ) ;
         if ( RcdFound41 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z347BR_Encounter_ID = A347BR_Encounter_ID;
         }
         ZM1441( -6) ;
         OnLoadActions1441( ) ;
         AddRow1441( ) ;
         ScanKeyEnd1441( ) ;
         if ( RcdFound41 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey1441( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert1441( ) ;
         }
         else
         {
            if ( RcdFound41 == 1 )
            {
               if ( A347BR_Encounter_ID != Z347BR_Encounter_ID )
               {
                  A347BR_Encounter_ID = Z347BR_Encounter_ID;
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
                  Update1441( ) ;
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
                  if ( A347BR_Encounter_ID != Z347BR_Encounter_ID )
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
                        Insert1441( ) ;
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
                        Insert1441( ) ;
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
         RowToVars41( bcBR_EncounterReason, 0) ;
         SaveImpl( ) ;
         VarsToRow41( bcBR_EncounterReason) ;
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
         RowToVars41( bcBR_EncounterReason, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert1441( ) ;
         AfterTrn( ) ;
         VarsToRow41( bcBR_EncounterReason) ;
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
            SdtBR_EncounterReason auxBC = new SdtBR_EncounterReason(context) ;
            auxBC.Load(A347BR_Encounter_ID);
            auxBC.UpdateDirties(bcBR_EncounterReason);
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
         RowToVars41( bcBR_EncounterReason, 0) ;
         UpdateImpl( ) ;
         VarsToRow41( bcBR_EncounterReason) ;
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
         RowToVars41( bcBR_EncounterReason, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert1441( ) ;
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
         VarsToRow41( bcBR_EncounterReason) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars41( bcBR_EncounterReason, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey1441( ) ;
         if ( RcdFound41 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A347BR_Encounter_ID != Z347BR_Encounter_ID )
            {
               A347BR_Encounter_ID = Z347BR_Encounter_ID;
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
            if ( A347BR_Encounter_ID != Z347BR_Encounter_ID )
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
         context.RollbackDataStores("br_encounterreason_bc",pr_default);
         VarsToRow41( bcBR_EncounterReason) ;
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
         Gx_mode = bcBR_EncounterReason.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcBR_EncounterReason.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcBR_EncounterReason )
         {
            bcBR_EncounterReason = (SdtBR_EncounterReason)(sdt);
            if ( StringUtil.StrCmp(bcBR_EncounterReason.gxTpr_Mode, "") == 0 )
            {
               bcBR_EncounterReason.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow41( bcBR_EncounterReason) ;
            }
            else
            {
               RowToVars41( bcBR_EncounterReason, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcBR_EncounterReason.gxTpr_Mode, "") == 0 )
            {
               bcBR_EncounterReason.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars41( bcBR_EncounterReason, 1) ;
         return  ;
      }

      public SdtBR_EncounterReason BR_EncounterReason_BC
      {
         get {
            return bcBR_EncounterReason ;
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
      }

      public override void initialize( )
      {
         scmdbuf = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Gx_mode = "";
         AV7WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV17Pgmname = "";
         AV10TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV11WebSession = context.GetSession();
         AV14TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         Z340BR_EncounterReason_Reason = "";
         A340BR_EncounterReason_Reason = "";
         Z341BR_EncounterReason_IsRandNoApproveDate = (DateTime)(DateTime.MinValue);
         A341BR_EncounterReason_IsRandNoApproveDate = (DateTime)(DateTime.MinValue);
         Z344BR_EncounterReason_IsRandApprover = "";
         A344BR_EncounterReason_IsRandApprover = "";
         BC00145_A347BR_Encounter_ID = new long[1] ;
         BC00145_A340BR_EncounterReason_Reason = new String[] {""} ;
         BC00145_n340BR_EncounterReason_Reason = new bool[] {false} ;
         BC00145_A341BR_EncounterReason_IsRandNoApproveDate = new DateTime[] {DateTime.MinValue} ;
         BC00145_n341BR_EncounterReason_IsRandNoApproveDate = new bool[] {false} ;
         BC00145_A342BR_EncounterReason_IsRandApprove = new bool[] {false} ;
         BC00145_n342BR_EncounterReason_IsRandApprove = new bool[] {false} ;
         BC00145_A343BR_EncounterReason_Status = new short[1] ;
         BC00145_n343BR_EncounterReason_Status = new bool[] {false} ;
         BC00145_A344BR_EncounterReason_IsRandApprover = new String[] {""} ;
         BC00145_n344BR_EncounterReason_IsRandApprover = new bool[] {false} ;
         BC00145_A19BR_EncounterID = new long[1] ;
         BC00144_A19BR_EncounterID = new long[1] ;
         BC00146_A347BR_Encounter_ID = new long[1] ;
         BC00143_A347BR_Encounter_ID = new long[1] ;
         BC00143_A340BR_EncounterReason_Reason = new String[] {""} ;
         BC00143_n340BR_EncounterReason_Reason = new bool[] {false} ;
         BC00143_A341BR_EncounterReason_IsRandNoApproveDate = new DateTime[] {DateTime.MinValue} ;
         BC00143_n341BR_EncounterReason_IsRandNoApproveDate = new bool[] {false} ;
         BC00143_A342BR_EncounterReason_IsRandApprove = new bool[] {false} ;
         BC00143_n342BR_EncounterReason_IsRandApprove = new bool[] {false} ;
         BC00143_A343BR_EncounterReason_Status = new short[1] ;
         BC00143_n343BR_EncounterReason_Status = new bool[] {false} ;
         BC00143_A344BR_EncounterReason_IsRandApprover = new String[] {""} ;
         BC00143_n344BR_EncounterReason_IsRandApprover = new bool[] {false} ;
         BC00143_A19BR_EncounterID = new long[1] ;
         sMode41 = "";
         BC00142_A347BR_Encounter_ID = new long[1] ;
         BC00142_A340BR_EncounterReason_Reason = new String[] {""} ;
         BC00142_n340BR_EncounterReason_Reason = new bool[] {false} ;
         BC00142_A341BR_EncounterReason_IsRandNoApproveDate = new DateTime[] {DateTime.MinValue} ;
         BC00142_n341BR_EncounterReason_IsRandNoApproveDate = new bool[] {false} ;
         BC00142_A342BR_EncounterReason_IsRandApprove = new bool[] {false} ;
         BC00142_n342BR_EncounterReason_IsRandApprove = new bool[] {false} ;
         BC00142_A343BR_EncounterReason_Status = new short[1] ;
         BC00142_n343BR_EncounterReason_Status = new bool[] {false} ;
         BC00142_A344BR_EncounterReason_IsRandApprover = new String[] {""} ;
         BC00142_n344BR_EncounterReason_IsRandApprover = new bool[] {false} ;
         BC00142_A19BR_EncounterID = new long[1] ;
         BC00147_A347BR_Encounter_ID = new long[1] ;
         BC001410_A347BR_Encounter_ID = new long[1] ;
         BC001410_A340BR_EncounterReason_Reason = new String[] {""} ;
         BC001410_n340BR_EncounterReason_Reason = new bool[] {false} ;
         BC001410_A341BR_EncounterReason_IsRandNoApproveDate = new DateTime[] {DateTime.MinValue} ;
         BC001410_n341BR_EncounterReason_IsRandNoApproveDate = new bool[] {false} ;
         BC001410_A342BR_EncounterReason_IsRandApprove = new bool[] {false} ;
         BC001410_n342BR_EncounterReason_IsRandApprove = new bool[] {false} ;
         BC001410_A343BR_EncounterReason_Status = new short[1] ;
         BC001410_n343BR_EncounterReason_Status = new bool[] {false} ;
         BC001410_A344BR_EncounterReason_IsRandApprover = new String[] {""} ;
         BC001410_n344BR_EncounterReason_IsRandApprover = new bool[] {false} ;
         BC001410_A19BR_EncounterID = new long[1] ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_encounterreason_bc__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_encounterreason_bc__default(),
            new Object[][] {
                new Object[] {
               BC00142_A347BR_Encounter_ID, BC00142_A340BR_EncounterReason_Reason, BC00142_n340BR_EncounterReason_Reason, BC00142_A341BR_EncounterReason_IsRandNoApproveDate, BC00142_n341BR_EncounterReason_IsRandNoApproveDate, BC00142_A342BR_EncounterReason_IsRandApprove, BC00142_n342BR_EncounterReason_IsRandApprove, BC00142_A343BR_EncounterReason_Status, BC00142_n343BR_EncounterReason_Status, BC00142_A344BR_EncounterReason_IsRandApprover,
               BC00142_n344BR_EncounterReason_IsRandApprover, BC00142_A19BR_EncounterID
               }
               , new Object[] {
               BC00143_A347BR_Encounter_ID, BC00143_A340BR_EncounterReason_Reason, BC00143_n340BR_EncounterReason_Reason, BC00143_A341BR_EncounterReason_IsRandNoApproveDate, BC00143_n341BR_EncounterReason_IsRandNoApproveDate, BC00143_A342BR_EncounterReason_IsRandApprove, BC00143_n342BR_EncounterReason_IsRandApprove, BC00143_A343BR_EncounterReason_Status, BC00143_n343BR_EncounterReason_Status, BC00143_A344BR_EncounterReason_IsRandApprover,
               BC00143_n344BR_EncounterReason_IsRandApprover, BC00143_A19BR_EncounterID
               }
               , new Object[] {
               BC00144_A19BR_EncounterID
               }
               , new Object[] {
               BC00145_A347BR_Encounter_ID, BC00145_A340BR_EncounterReason_Reason, BC00145_n340BR_EncounterReason_Reason, BC00145_A341BR_EncounterReason_IsRandNoApproveDate, BC00145_n341BR_EncounterReason_IsRandNoApproveDate, BC00145_A342BR_EncounterReason_IsRandApprove, BC00145_n342BR_EncounterReason_IsRandApprove, BC00145_A343BR_EncounterReason_Status, BC00145_n343BR_EncounterReason_Status, BC00145_A344BR_EncounterReason_IsRandApprover,
               BC00145_n344BR_EncounterReason_IsRandApprover, BC00145_A19BR_EncounterID
               }
               , new Object[] {
               BC00146_A347BR_Encounter_ID
               }
               , new Object[] {
               BC00147_A347BR_Encounter_ID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC001410_A347BR_Encounter_ID, BC001410_A340BR_EncounterReason_Reason, BC001410_n340BR_EncounterReason_Reason, BC001410_A341BR_EncounterReason_IsRandNoApproveDate, BC001410_n341BR_EncounterReason_IsRandNoApproveDate, BC001410_A342BR_EncounterReason_IsRandApprove, BC001410_n342BR_EncounterReason_IsRandApprove, BC001410_A343BR_EncounterReason_Status, BC001410_n343BR_EncounterReason_Status, BC001410_A344BR_EncounterReason_IsRandApprover,
               BC001410_n344BR_EncounterReason_IsRandApprover, BC001410_A19BR_EncounterID
               }
            }
         );
         AV17Pgmname = "BR_EncounterReason_BC";
         INITTRN();
         /* Execute Start event if defined. */
         /* Execute user event: Start */
         E12142 ();
         standaloneNotModal( ) ;
      }

      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short GX_JID ;
      private short Z343BR_EncounterReason_Status ;
      private short A343BR_EncounterReason_Status ;
      private short RcdFound41 ;
      private int trnEnded ;
      private int AV18GXV1 ;
      private long Z347BR_Encounter_ID ;
      private long A347BR_Encounter_ID ;
      private long AV15Insert_BR_EncounterID ;
      private long Z19BR_EncounterID ;
      private long A19BR_EncounterID ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String AV17Pgmname ;
      private String sMode41 ;
      private DateTime Z341BR_EncounterReason_IsRandNoApproveDate ;
      private DateTime A341BR_EncounterReason_IsRandNoApproveDate ;
      private bool AV8IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool Z342BR_EncounterReason_IsRandApprove ;
      private bool A342BR_EncounterReason_IsRandApprove ;
      private bool n340BR_EncounterReason_Reason ;
      private bool n341BR_EncounterReason_IsRandNoApproveDate ;
      private bool n342BR_EncounterReason_IsRandApprove ;
      private bool n343BR_EncounterReason_Status ;
      private bool n344BR_EncounterReason_IsRandApprover ;
      private bool Gx_longc ;
      private String Z340BR_EncounterReason_Reason ;
      private String A340BR_EncounterReason_Reason ;
      private String Z344BR_EncounterReason_IsRandApprover ;
      private String A344BR_EncounterReason_IsRandApprover ;
      private IGxSession AV11WebSession ;
      private SdtBR_EncounterReason bcBR_EncounterReason ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] BC00145_A347BR_Encounter_ID ;
      private String[] BC00145_A340BR_EncounterReason_Reason ;
      private bool[] BC00145_n340BR_EncounterReason_Reason ;
      private DateTime[] BC00145_A341BR_EncounterReason_IsRandNoApproveDate ;
      private bool[] BC00145_n341BR_EncounterReason_IsRandNoApproveDate ;
      private bool[] BC00145_A342BR_EncounterReason_IsRandApprove ;
      private bool[] BC00145_n342BR_EncounterReason_IsRandApprove ;
      private short[] BC00145_A343BR_EncounterReason_Status ;
      private bool[] BC00145_n343BR_EncounterReason_Status ;
      private String[] BC00145_A344BR_EncounterReason_IsRandApprover ;
      private bool[] BC00145_n344BR_EncounterReason_IsRandApprover ;
      private long[] BC00145_A19BR_EncounterID ;
      private long[] BC00144_A19BR_EncounterID ;
      private long[] BC00146_A347BR_Encounter_ID ;
      private long[] BC00143_A347BR_Encounter_ID ;
      private String[] BC00143_A340BR_EncounterReason_Reason ;
      private bool[] BC00143_n340BR_EncounterReason_Reason ;
      private DateTime[] BC00143_A341BR_EncounterReason_IsRandNoApproveDate ;
      private bool[] BC00143_n341BR_EncounterReason_IsRandNoApproveDate ;
      private bool[] BC00143_A342BR_EncounterReason_IsRandApprove ;
      private bool[] BC00143_n342BR_EncounterReason_IsRandApprove ;
      private short[] BC00143_A343BR_EncounterReason_Status ;
      private bool[] BC00143_n343BR_EncounterReason_Status ;
      private String[] BC00143_A344BR_EncounterReason_IsRandApprover ;
      private bool[] BC00143_n344BR_EncounterReason_IsRandApprover ;
      private long[] BC00143_A19BR_EncounterID ;
      private long[] BC00142_A347BR_Encounter_ID ;
      private String[] BC00142_A340BR_EncounterReason_Reason ;
      private bool[] BC00142_n340BR_EncounterReason_Reason ;
      private DateTime[] BC00142_A341BR_EncounterReason_IsRandNoApproveDate ;
      private bool[] BC00142_n341BR_EncounterReason_IsRandNoApproveDate ;
      private bool[] BC00142_A342BR_EncounterReason_IsRandApprove ;
      private bool[] BC00142_n342BR_EncounterReason_IsRandApprove ;
      private short[] BC00142_A343BR_EncounterReason_Status ;
      private bool[] BC00142_n343BR_EncounterReason_Status ;
      private String[] BC00142_A344BR_EncounterReason_IsRandApprover ;
      private bool[] BC00142_n344BR_EncounterReason_IsRandApprover ;
      private long[] BC00142_A19BR_EncounterID ;
      private long[] BC00147_A347BR_Encounter_ID ;
      private long[] BC001410_A347BR_Encounter_ID ;
      private String[] BC001410_A340BR_EncounterReason_Reason ;
      private bool[] BC001410_n340BR_EncounterReason_Reason ;
      private DateTime[] BC001410_A341BR_EncounterReason_IsRandNoApproveDate ;
      private bool[] BC001410_n341BR_EncounterReason_IsRandNoApproveDate ;
      private bool[] BC001410_A342BR_EncounterReason_IsRandApprove ;
      private bool[] BC001410_n342BR_EncounterReason_IsRandApprove ;
      private short[] BC001410_A343BR_EncounterReason_Status ;
      private bool[] BC001410_n343BR_EncounterReason_Status ;
      private String[] BC001410_A344BR_EncounterReason_IsRandApprover ;
      private bool[] BC001410_n344BR_EncounterReason_IsRandApprover ;
      private long[] BC001410_A19BR_EncounterID ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_datastore1 ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV7WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV10TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV14TrnContextAtt ;
   }

   public class br_encounterreason_bc__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class br_encounterreason_bc__default : DataStoreHelperBase, IDataStoreHelper
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
       ,new UpdateCursor(def[6])
       ,new UpdateCursor(def[7])
       ,new ForEachCursor(def[8])
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmBC00145 ;
        prmBC00145 = new Object[] {
        new Object[] {"@BR_Encounter_ID",SqlDbType.Decimal,15,0}
        } ;
        Object[] prmBC00144 ;
        prmBC00144 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00146 ;
        prmBC00146 = new Object[] {
        new Object[] {"@BR_Encounter_ID",SqlDbType.Decimal,15,0}
        } ;
        Object[] prmBC00143 ;
        prmBC00143 = new Object[] {
        new Object[] {"@BR_Encounter_ID",SqlDbType.Decimal,15,0}
        } ;
        Object[] prmBC00142 ;
        prmBC00142 = new Object[] {
        new Object[] {"@BR_Encounter_ID",SqlDbType.Decimal,15,0}
        } ;
        Object[] prmBC00147 ;
        prmBC00147 = new Object[] {
        new Object[] {"@BR_EncounterReason_Reason",SqlDbType.NVarChar,300,0} ,
        new Object[] {"@BR_EncounterReason_IsRandNoApproveDate",SqlDbType.DateTime,10,8} ,
        new Object[] {"@BR_EncounterReason_IsRandApprove",SqlDbType.Bit,4,0} ,
        new Object[] {"@BR_EncounterReason_Status",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@BR_EncounterReason_IsRandApprover",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00148 ;
        prmBC00148 = new Object[] {
        new Object[] {"@BR_EncounterReason_Reason",SqlDbType.NVarChar,300,0} ,
        new Object[] {"@BR_EncounterReason_IsRandNoApproveDate",SqlDbType.DateTime,10,8} ,
        new Object[] {"@BR_EncounterReason_IsRandApprove",SqlDbType.Bit,4,0} ,
        new Object[] {"@BR_EncounterReason_Status",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@BR_EncounterReason_IsRandApprover",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_Encounter_ID",SqlDbType.Decimal,15,0}
        } ;
        Object[] prmBC00149 ;
        prmBC00149 = new Object[] {
        new Object[] {"@BR_Encounter_ID",SqlDbType.Decimal,15,0}
        } ;
        Object[] prmBC001410 ;
        prmBC001410 = new Object[] {
        new Object[] {"@BR_Encounter_ID",SqlDbType.Decimal,15,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("BC00142", "SELECT [BR_Encounter_ID], [BR_EncounterReason_Reason], [BR_EncounterReason_IsRandNoApproveDate], [BR_EncounterReason_IsRandApprove], [BR_EncounterReason_Status], [BR_EncounterReason_IsRandApprover], [BR_EncounterID] FROM [BR_EncounterReason] WITH (UPDLOCK) WHERE [BR_Encounter_ID] = @BR_Encounter_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00142,1,0,true,false )
           ,new CursorDef("BC00143", "SELECT [BR_Encounter_ID], [BR_EncounterReason_Reason], [BR_EncounterReason_IsRandNoApproveDate], [BR_EncounterReason_IsRandApprove], [BR_EncounterReason_Status], [BR_EncounterReason_IsRandApprover], [BR_EncounterID] FROM [BR_EncounterReason] WITH (NOLOCK) WHERE [BR_Encounter_ID] = @BR_Encounter_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00143,1,0,true,false )
           ,new CursorDef("BC00144", "SELECT [BR_EncounterID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00144,1,0,true,false )
           ,new CursorDef("BC00145", "SELECT TM1.[BR_Encounter_ID], TM1.[BR_EncounterReason_Reason], TM1.[BR_EncounterReason_IsRandNoApproveDate], TM1.[BR_EncounterReason_IsRandApprove], TM1.[BR_EncounterReason_Status], TM1.[BR_EncounterReason_IsRandApprover], TM1.[BR_EncounterID] FROM [BR_EncounterReason] TM1 WITH (NOLOCK) WHERE TM1.[BR_Encounter_ID] = @BR_Encounter_ID ORDER BY TM1.[BR_Encounter_ID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00145,100,0,true,false )
           ,new CursorDef("BC00146", "SELECT [BR_Encounter_ID] FROM [BR_EncounterReason] WITH (NOLOCK) WHERE [BR_Encounter_ID] = @BR_Encounter_ID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00146,1,0,true,false )
           ,new CursorDef("BC00147", "INSERT INTO [BR_EncounterReason]([BR_EncounterReason_Reason], [BR_EncounterReason_IsRandNoApproveDate], [BR_EncounterReason_IsRandApprove], [BR_EncounterReason_Status], [BR_EncounterReason_IsRandApprover], [BR_EncounterID]) VALUES(@BR_EncounterReason_Reason, @BR_EncounterReason_IsRandNoApproveDate, @BR_EncounterReason_IsRandApprove, @BR_EncounterReason_Status, @BR_EncounterReason_IsRandApprover, @BR_EncounterID); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmBC00147)
           ,new CursorDef("BC00148", "UPDATE [BR_EncounterReason] SET [BR_EncounterReason_Reason]=@BR_EncounterReason_Reason, [BR_EncounterReason_IsRandNoApproveDate]=@BR_EncounterReason_IsRandNoApproveDate, [BR_EncounterReason_IsRandApprove]=@BR_EncounterReason_IsRandApprove, [BR_EncounterReason_Status]=@BR_EncounterReason_Status, [BR_EncounterReason_IsRandApprover]=@BR_EncounterReason_IsRandApprover, [BR_EncounterID]=@BR_EncounterID  WHERE [BR_Encounter_ID] = @BR_Encounter_ID", GxErrorMask.GX_NOMASK,prmBC00148)
           ,new CursorDef("BC00149", "DELETE FROM [BR_EncounterReason]  WHERE [BR_Encounter_ID] = @BR_Encounter_ID", GxErrorMask.GX_NOMASK,prmBC00149)
           ,new CursorDef("BC001410", "SELECT TM1.[BR_Encounter_ID], TM1.[BR_EncounterReason_Reason], TM1.[BR_EncounterReason_IsRandNoApproveDate], TM1.[BR_EncounterReason_IsRandApprove], TM1.[BR_EncounterReason_Status], TM1.[BR_EncounterReason_IsRandApprover], TM1.[BR_EncounterID] FROM [BR_EncounterReason] TM1 WITH (NOLOCK) WHERE TM1.[BR_Encounter_ID] = @BR_Encounter_ID ORDER BY TM1.[BR_Encounter_ID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001410,100,0,true,false )
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
              ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((bool[]) buf[5])[0] = rslt.getBool(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((short[]) buf[7])[0] = rslt.getShort(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((long[]) buf[11])[0] = rslt.getLong(7) ;
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((bool[]) buf[5])[0] = rslt.getBool(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((short[]) buf[7])[0] = rslt.getShort(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((long[]) buf[11])[0] = rslt.getLong(7) ;
              return;
           case 2 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 3 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((bool[]) buf[5])[0] = rslt.getBool(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((short[]) buf[7])[0] = rslt.getShort(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((long[]) buf[11])[0] = rslt.getLong(7) ;
              return;
           case 4 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 5 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 8 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((bool[]) buf[5])[0] = rslt.getBool(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((short[]) buf[7])[0] = rslt.getShort(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((long[]) buf[11])[0] = rslt.getLong(7) ;
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
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 4 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 5 :
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
                 stmt.setNull( 2 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(2, (DateTime)parms[3]);
              }
              if ( (bool)parms[4] )
              {
                 stmt.setNull( 3 , SqlDbType.Bit );
              }
              else
              {
                 stmt.SetParameter(3, (bool)parms[5]);
              }
              if ( (bool)parms[6] )
              {
                 stmt.setNull( 4 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(4, (short)parms[7]);
              }
              if ( (bool)parms[8] )
              {
                 stmt.setNull( 5 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(5, (String)parms[9]);
              }
              stmt.SetParameter(6, (long)parms[10]);
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
                 stmt.setNull( 2 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(2, (DateTime)parms[3]);
              }
              if ( (bool)parms[4] )
              {
                 stmt.setNull( 3 , SqlDbType.Bit );
              }
              else
              {
                 stmt.SetParameter(3, (bool)parms[5]);
              }
              if ( (bool)parms[6] )
              {
                 stmt.setNull( 4 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(4, (short)parms[7]);
              }
              if ( (bool)parms[8] )
              {
                 stmt.setNull( 5 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(5, (String)parms[9]);
              }
              stmt.SetParameter(6, (long)parms[10]);
              stmt.SetParameter(7, (long)parms[11]);
              return;
           case 7 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 8 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
     }
  }

}

}
