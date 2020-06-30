/*
               File: XT_Log_BC
        Description: 系统日志
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:57:7.71
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
   public class xt_log_bc : GXHttpHandler, IGxSilentTrn
   {
      public xt_log_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public xt_log_bc( IGxContext context )
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
         ReadRow0O25( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey0O25( ) ;
         standaloneModal( ) ;
         AddRow0O25( ) ;
         Gx_mode = "INS";
         return  ;
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E110O2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               Z173XT_LogID = A173XT_LogID;
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

      protected void CONFIRM_0O0( )
      {
         BeforeValidate0O25( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0O25( ) ;
            }
            else
            {
               CheckExtendedTable0O25( ) ;
               if ( AnyError == 0 )
               {
               }
               CloseExtendedTableCursors0O25( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void E120O2( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV8WWPContext) ;
         AV9IsAuthorized = true;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWXT_Log_Insert", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWXT_Log_Update", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWXT_Log_Delete", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
         }
         if ( ! AV9IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV13Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV11TrnContext.FromXml(AV12WebSession.Get("TrnContext"), null, "WWPTransactionContext", "DataAnalysisPlatform");
      }

      protected void E110O2( )
      {
         /* After Trn Routine */
      }

      protected void ZM0O25( short GX_JID )
      {
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            Z214XT_LogUserID = A214XT_LogUserID;
            Z174XT_LogSecUserName = A174XT_LogSecUserName;
            Z220XT_LogTime = A220XT_LogTime;
            Z176XT_LogPage = A176XT_LogPage;
            Z177XT_LogButtonName = A177XT_LogButtonName;
            Z213XT_LogType = A213XT_LogType;
            Z215XT_LogProviderID = A215XT_LogProviderID;
            Z219XT_LogProviderName = A219XT_LogProviderName;
            Z216XT_LogTarget = A216XT_LogTarget;
            Z223XT_LogSonTarget = A223XT_LogSonTarget;
            Z217XT_LogTargetModule = A217XT_LogTargetModule;
            Z222XT_LogTargetSonModule = A222XT_LogTargetSonModule;
            Z218XT_LogTargetOperate = A218XT_LogTargetOperate;
            Z221XT_LogDescription = A221XT_LogDescription;
         }
         if ( GX_JID == -3 )
         {
            Z173XT_LogID = A173XT_LogID;
            Z214XT_LogUserID = A214XT_LogUserID;
            Z174XT_LogSecUserName = A174XT_LogSecUserName;
            Z220XT_LogTime = A220XT_LogTime;
            Z176XT_LogPage = A176XT_LogPage;
            Z177XT_LogButtonName = A177XT_LogButtonName;
            Z213XT_LogType = A213XT_LogType;
            Z215XT_LogProviderID = A215XT_LogProviderID;
            Z219XT_LogProviderName = A219XT_LogProviderName;
            Z216XT_LogTarget = A216XT_LogTarget;
            Z223XT_LogSonTarget = A223XT_LogSonTarget;
            Z217XT_LogTargetModule = A217XT_LogTargetModule;
            Z222XT_LogTargetSonModule = A222XT_LogTargetSonModule;
            Z218XT_LogTargetOperate = A218XT_LogTargetOperate;
            Z221XT_LogDescription = A221XT_LogDescription;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load0O25( )
      {
         /* Using cursor BC000O4 */
         pr_default.execute(2, new Object[] {A173XT_LogID});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound25 = 1;
            A214XT_LogUserID = BC000O4_A214XT_LogUserID[0];
            n214XT_LogUserID = BC000O4_n214XT_LogUserID[0];
            A174XT_LogSecUserName = BC000O4_A174XT_LogSecUserName[0];
            n174XT_LogSecUserName = BC000O4_n174XT_LogSecUserName[0];
            A220XT_LogTime = BC000O4_A220XT_LogTime[0];
            n220XT_LogTime = BC000O4_n220XT_LogTime[0];
            A176XT_LogPage = BC000O4_A176XT_LogPage[0];
            n176XT_LogPage = BC000O4_n176XT_LogPage[0];
            A177XT_LogButtonName = BC000O4_A177XT_LogButtonName[0];
            n177XT_LogButtonName = BC000O4_n177XT_LogButtonName[0];
            A213XT_LogType = BC000O4_A213XT_LogType[0];
            n213XT_LogType = BC000O4_n213XT_LogType[0];
            A215XT_LogProviderID = BC000O4_A215XT_LogProviderID[0];
            n215XT_LogProviderID = BC000O4_n215XT_LogProviderID[0];
            A219XT_LogProviderName = BC000O4_A219XT_LogProviderName[0];
            n219XT_LogProviderName = BC000O4_n219XT_LogProviderName[0];
            A216XT_LogTarget = BC000O4_A216XT_LogTarget[0];
            n216XT_LogTarget = BC000O4_n216XT_LogTarget[0];
            A223XT_LogSonTarget = BC000O4_A223XT_LogSonTarget[0];
            n223XT_LogSonTarget = BC000O4_n223XT_LogSonTarget[0];
            A217XT_LogTargetModule = BC000O4_A217XT_LogTargetModule[0];
            n217XT_LogTargetModule = BC000O4_n217XT_LogTargetModule[0];
            A222XT_LogTargetSonModule = BC000O4_A222XT_LogTargetSonModule[0];
            n222XT_LogTargetSonModule = BC000O4_n222XT_LogTargetSonModule[0];
            A218XT_LogTargetOperate = BC000O4_A218XT_LogTargetOperate[0];
            n218XT_LogTargetOperate = BC000O4_n218XT_LogTargetOperate[0];
            A221XT_LogDescription = BC000O4_A221XT_LogDescription[0];
            n221XT_LogDescription = BC000O4_n221XT_LogDescription[0];
            ZM0O25( -3) ;
         }
         pr_default.close(2);
         OnLoadActions0O25( ) ;
      }

      protected void OnLoadActions0O25( )
      {
         AV13Pgmname = "XT_Log_BC";
      }

      protected void CheckExtendedTable0O25( )
      {
         standaloneModal( ) ;
         AV13Pgmname = "XT_Log_BC";
         if ( ! ( (DateTime.MinValue==A220XT_LogTime) || ( A220XT_LogTime >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("域������������超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
         if ( ! ( ( StringUtil.StrCmp(A218XT_LogTargetOperate, "Create") == 0 ) || ( StringUtil.StrCmp(A218XT_LogTargetOperate, "Update") == 0 ) || ( StringUtil.StrCmp(A218XT_LogTargetOperate, "Delete") == 0 ) || ( StringUtil.StrCmp(A218XT_LogTargetOperate, "Create") == 0 ) || ( StringUtil.StrCmp(A218XT_LogTargetOperate, "Submit") == 0 ) || ( StringUtil.StrCmp(A218XT_LogTargetOperate, "Batchcheck") == 0 ) || ( StringUtil.StrCmp(A218XT_LogTargetOperate, "Batchapprove") == 0 ) || ( StringUtil.StrCmp(A218XT_LogTargetOperate, "Randomcheckpass") == 0 ) || ( StringUtil.StrCmp(A218XT_LogTargetOperate, "Randomcheckrefuse") == 0 ) || ( StringUtil.StrCmp(A218XT_LogTargetOperate, "Randomapprovepass") == 0 ) || ( StringUtil.StrCmp(A218XT_LogTargetOperate, "Randomapproverefuse") == 0 ) || ( StringUtil.StrCmp(A218XT_LogTargetOperate, "Check") == 0 ) || ( StringUtil.StrCmp(A218XT_LogTargetOperate, "Approve") == 0 ) || ( StringUtil.StrCmp(A218XT_LogTargetOperate, "Reupdate") == 0 ) || ( StringUtil.StrCmp(A218XT_LogTargetOperate, "Login") == 0 ) || String.IsNullOrEmpty(StringUtil.RTrim( A218XT_LogTargetOperate)) ) )
         {
            GX_msglist.addItem("域������������������������超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
      }

      protected void CloseExtendedTableCursors0O25( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0O25( )
      {
         /* Using cursor BC000O5 */
         pr_default.execute(3, new Object[] {A173XT_LogID});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound25 = 1;
         }
         else
         {
            RcdFound25 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC000O3 */
         pr_default.execute(1, new Object[] {A173XT_LogID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0O25( 3) ;
            RcdFound25 = 1;
            A173XT_LogID = BC000O3_A173XT_LogID[0];
            A214XT_LogUserID = BC000O3_A214XT_LogUserID[0];
            n214XT_LogUserID = BC000O3_n214XT_LogUserID[0];
            A174XT_LogSecUserName = BC000O3_A174XT_LogSecUserName[0];
            n174XT_LogSecUserName = BC000O3_n174XT_LogSecUserName[0];
            A220XT_LogTime = BC000O3_A220XT_LogTime[0];
            n220XT_LogTime = BC000O3_n220XT_LogTime[0];
            A176XT_LogPage = BC000O3_A176XT_LogPage[0];
            n176XT_LogPage = BC000O3_n176XT_LogPage[0];
            A177XT_LogButtonName = BC000O3_A177XT_LogButtonName[0];
            n177XT_LogButtonName = BC000O3_n177XT_LogButtonName[0];
            A213XT_LogType = BC000O3_A213XT_LogType[0];
            n213XT_LogType = BC000O3_n213XT_LogType[0];
            A215XT_LogProviderID = BC000O3_A215XT_LogProviderID[0];
            n215XT_LogProviderID = BC000O3_n215XT_LogProviderID[0];
            A219XT_LogProviderName = BC000O3_A219XT_LogProviderName[0];
            n219XT_LogProviderName = BC000O3_n219XT_LogProviderName[0];
            A216XT_LogTarget = BC000O3_A216XT_LogTarget[0];
            n216XT_LogTarget = BC000O3_n216XT_LogTarget[0];
            A223XT_LogSonTarget = BC000O3_A223XT_LogSonTarget[0];
            n223XT_LogSonTarget = BC000O3_n223XT_LogSonTarget[0];
            A217XT_LogTargetModule = BC000O3_A217XT_LogTargetModule[0];
            n217XT_LogTargetModule = BC000O3_n217XT_LogTargetModule[0];
            A222XT_LogTargetSonModule = BC000O3_A222XT_LogTargetSonModule[0];
            n222XT_LogTargetSonModule = BC000O3_n222XT_LogTargetSonModule[0];
            A218XT_LogTargetOperate = BC000O3_A218XT_LogTargetOperate[0];
            n218XT_LogTargetOperate = BC000O3_n218XT_LogTargetOperate[0];
            A221XT_LogDescription = BC000O3_A221XT_LogDescription[0];
            n221XT_LogDescription = BC000O3_n221XT_LogDescription[0];
            Z173XT_LogID = A173XT_LogID;
            sMode25 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load0O25( ) ;
            if ( AnyError == 1 )
            {
               RcdFound25 = 0;
               InitializeNonKey0O25( ) ;
            }
            Gx_mode = sMode25;
         }
         else
         {
            RcdFound25 = 0;
            InitializeNonKey0O25( ) ;
            sMode25 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode25;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0O25( ) ;
         if ( RcdFound25 == 0 )
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
         CONFIRM_0O0( ) ;
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

      protected void CheckOptimisticConcurrency0O25( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC000O2 */
            pr_default.execute(0, new Object[] {A173XT_LogID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"XT_Log"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( Z214XT_LogUserID != BC000O2_A214XT_LogUserID[0] ) || ( StringUtil.StrCmp(Z174XT_LogSecUserName, BC000O2_A174XT_LogSecUserName[0]) != 0 ) || ( Z220XT_LogTime != BC000O2_A220XT_LogTime[0] ) || ( StringUtil.StrCmp(Z176XT_LogPage, BC000O2_A176XT_LogPage[0]) != 0 ) || ( StringUtil.StrCmp(Z177XT_LogButtonName, BC000O2_A177XT_LogButtonName[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z213XT_LogType, BC000O2_A213XT_LogType[0]) != 0 ) || ( Z215XT_LogProviderID != BC000O2_A215XT_LogProviderID[0] ) || ( StringUtil.StrCmp(Z219XT_LogProviderName, BC000O2_A219XT_LogProviderName[0]) != 0 ) || ( StringUtil.StrCmp(Z216XT_LogTarget, BC000O2_A216XT_LogTarget[0]) != 0 ) || ( StringUtil.StrCmp(Z223XT_LogSonTarget, BC000O2_A223XT_LogSonTarget[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z217XT_LogTargetModule, BC000O2_A217XT_LogTargetModule[0]) != 0 ) || ( StringUtil.StrCmp(Z222XT_LogTargetSonModule, BC000O2_A222XT_LogTargetSonModule[0]) != 0 ) || ( StringUtil.StrCmp(Z218XT_LogTargetOperate, BC000O2_A218XT_LogTargetOperate[0]) != 0 ) || ( StringUtil.StrCmp(Z221XT_LogDescription, BC000O2_A221XT_LogDescription[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"XT_Log"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0O25( )
      {
         BeforeValidate0O25( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0O25( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0O25( 0) ;
            CheckOptimisticConcurrency0O25( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0O25( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0O25( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000O6 */
                     pr_default.execute(4, new Object[] {n214XT_LogUserID, A214XT_LogUserID, n174XT_LogSecUserName, A174XT_LogSecUserName, n220XT_LogTime, A220XT_LogTime, n176XT_LogPage, A176XT_LogPage, n177XT_LogButtonName, A177XT_LogButtonName, n213XT_LogType, A213XT_LogType, n215XT_LogProviderID, A215XT_LogProviderID, n219XT_LogProviderName, A219XT_LogProviderName, n216XT_LogTarget, A216XT_LogTarget, n223XT_LogSonTarget, A223XT_LogSonTarget, n217XT_LogTargetModule, A217XT_LogTargetModule, n222XT_LogTargetSonModule, A222XT_LogTargetSonModule, n218XT_LogTargetOperate, A218XT_LogTargetOperate, n221XT_LogDescription, A221XT_LogDescription});
                     A173XT_LogID = BC000O6_A173XT_LogID[0];
                     pr_default.close(4);
                     dsDefault.SmartCacheProvider.SetUpdated("XT_Log") ;
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
               Load0O25( ) ;
            }
            EndLevel0O25( ) ;
         }
         CloseExtendedTableCursors0O25( ) ;
      }

      protected void Update0O25( )
      {
         BeforeValidate0O25( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0O25( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0O25( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0O25( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0O25( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000O7 */
                     pr_default.execute(5, new Object[] {n214XT_LogUserID, A214XT_LogUserID, n174XT_LogSecUserName, A174XT_LogSecUserName, n220XT_LogTime, A220XT_LogTime, n176XT_LogPage, A176XT_LogPage, n177XT_LogButtonName, A177XT_LogButtonName, n213XT_LogType, A213XT_LogType, n215XT_LogProviderID, A215XT_LogProviderID, n219XT_LogProviderName, A219XT_LogProviderName, n216XT_LogTarget, A216XT_LogTarget, n223XT_LogSonTarget, A223XT_LogSonTarget, n217XT_LogTargetModule, A217XT_LogTargetModule, n222XT_LogTargetSonModule, A222XT_LogTargetSonModule, n218XT_LogTargetOperate, A218XT_LogTargetOperate, n221XT_LogDescription, A221XT_LogDescription, A173XT_LogID});
                     pr_default.close(5);
                     dsDefault.SmartCacheProvider.SetUpdated("XT_Log") ;
                     if ( (pr_default.getStatus(5) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"XT_Log"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0O25( ) ;
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
            EndLevel0O25( ) ;
         }
         CloseExtendedTableCursors0O25( ) ;
      }

      protected void DeferredUpdate0O25( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate0O25( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0O25( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0O25( ) ;
            AfterConfirm0O25( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0O25( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC000O8 */
                  pr_default.execute(6, new Object[] {A173XT_LogID});
                  pr_default.close(6);
                  dsDefault.SmartCacheProvider.SetUpdated("XT_Log") ;
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
         sMode25 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel0O25( ) ;
         Gx_mode = sMode25;
      }

      protected void OnDeleteControls0O25( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV13Pgmname = "XT_Log_BC";
         }
      }

      protected void EndLevel0O25( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0O25( ) ;
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

      public void ScanKeyStart0O25( )
      {
         /* Scan By routine */
         /* Using cursor BC000O9 */
         pr_default.execute(7, new Object[] {A173XT_LogID});
         RcdFound25 = 0;
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound25 = 1;
            A173XT_LogID = BC000O9_A173XT_LogID[0];
            A214XT_LogUserID = BC000O9_A214XT_LogUserID[0];
            n214XT_LogUserID = BC000O9_n214XT_LogUserID[0];
            A174XT_LogSecUserName = BC000O9_A174XT_LogSecUserName[0];
            n174XT_LogSecUserName = BC000O9_n174XT_LogSecUserName[0];
            A220XT_LogTime = BC000O9_A220XT_LogTime[0];
            n220XT_LogTime = BC000O9_n220XT_LogTime[0];
            A176XT_LogPage = BC000O9_A176XT_LogPage[0];
            n176XT_LogPage = BC000O9_n176XT_LogPage[0];
            A177XT_LogButtonName = BC000O9_A177XT_LogButtonName[0];
            n177XT_LogButtonName = BC000O9_n177XT_LogButtonName[0];
            A213XT_LogType = BC000O9_A213XT_LogType[0];
            n213XT_LogType = BC000O9_n213XT_LogType[0];
            A215XT_LogProviderID = BC000O9_A215XT_LogProviderID[0];
            n215XT_LogProviderID = BC000O9_n215XT_LogProviderID[0];
            A219XT_LogProviderName = BC000O9_A219XT_LogProviderName[0];
            n219XT_LogProviderName = BC000O9_n219XT_LogProviderName[0];
            A216XT_LogTarget = BC000O9_A216XT_LogTarget[0];
            n216XT_LogTarget = BC000O9_n216XT_LogTarget[0];
            A223XT_LogSonTarget = BC000O9_A223XT_LogSonTarget[0];
            n223XT_LogSonTarget = BC000O9_n223XT_LogSonTarget[0];
            A217XT_LogTargetModule = BC000O9_A217XT_LogTargetModule[0];
            n217XT_LogTargetModule = BC000O9_n217XT_LogTargetModule[0];
            A222XT_LogTargetSonModule = BC000O9_A222XT_LogTargetSonModule[0];
            n222XT_LogTargetSonModule = BC000O9_n222XT_LogTargetSonModule[0];
            A218XT_LogTargetOperate = BC000O9_A218XT_LogTargetOperate[0];
            n218XT_LogTargetOperate = BC000O9_n218XT_LogTargetOperate[0];
            A221XT_LogDescription = BC000O9_A221XT_LogDescription[0];
            n221XT_LogDescription = BC000O9_n221XT_LogDescription[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext0O25( )
      {
         /* Scan next routine */
         pr_default.readNext(7);
         RcdFound25 = 0;
         ScanKeyLoad0O25( ) ;
      }

      protected void ScanKeyLoad0O25( )
      {
         sMode25 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound25 = 1;
            A173XT_LogID = BC000O9_A173XT_LogID[0];
            A214XT_LogUserID = BC000O9_A214XT_LogUserID[0];
            n214XT_LogUserID = BC000O9_n214XT_LogUserID[0];
            A174XT_LogSecUserName = BC000O9_A174XT_LogSecUserName[0];
            n174XT_LogSecUserName = BC000O9_n174XT_LogSecUserName[0];
            A220XT_LogTime = BC000O9_A220XT_LogTime[0];
            n220XT_LogTime = BC000O9_n220XT_LogTime[0];
            A176XT_LogPage = BC000O9_A176XT_LogPage[0];
            n176XT_LogPage = BC000O9_n176XT_LogPage[0];
            A177XT_LogButtonName = BC000O9_A177XT_LogButtonName[0];
            n177XT_LogButtonName = BC000O9_n177XT_LogButtonName[0];
            A213XT_LogType = BC000O9_A213XT_LogType[0];
            n213XT_LogType = BC000O9_n213XT_LogType[0];
            A215XT_LogProviderID = BC000O9_A215XT_LogProviderID[0];
            n215XT_LogProviderID = BC000O9_n215XT_LogProviderID[0];
            A219XT_LogProviderName = BC000O9_A219XT_LogProviderName[0];
            n219XT_LogProviderName = BC000O9_n219XT_LogProviderName[0];
            A216XT_LogTarget = BC000O9_A216XT_LogTarget[0];
            n216XT_LogTarget = BC000O9_n216XT_LogTarget[0];
            A223XT_LogSonTarget = BC000O9_A223XT_LogSonTarget[0];
            n223XT_LogSonTarget = BC000O9_n223XT_LogSonTarget[0];
            A217XT_LogTargetModule = BC000O9_A217XT_LogTargetModule[0];
            n217XT_LogTargetModule = BC000O9_n217XT_LogTargetModule[0];
            A222XT_LogTargetSonModule = BC000O9_A222XT_LogTargetSonModule[0];
            n222XT_LogTargetSonModule = BC000O9_n222XT_LogTargetSonModule[0];
            A218XT_LogTargetOperate = BC000O9_A218XT_LogTargetOperate[0];
            n218XT_LogTargetOperate = BC000O9_n218XT_LogTargetOperate[0];
            A221XT_LogDescription = BC000O9_A221XT_LogDescription[0];
            n221XT_LogDescription = BC000O9_n221XT_LogDescription[0];
         }
         Gx_mode = sMode25;
      }

      protected void ScanKeyEnd0O25( )
      {
         pr_default.close(7);
      }

      protected void AfterConfirm0O25( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0O25( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0O25( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0O25( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0O25( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0O25( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0O25( )
      {
      }

      protected void send_integrity_lvl_hashes0O25( )
      {
      }

      protected void AddRow0O25( )
      {
         VarsToRow25( bcXT_Log) ;
      }

      protected void ReadRow0O25( )
      {
         RowToVars25( bcXT_Log, 1) ;
      }

      protected void InitializeNonKey0O25( )
      {
         A214XT_LogUserID = 0;
         n214XT_LogUserID = false;
         A174XT_LogSecUserName = "";
         n174XT_LogSecUserName = false;
         A220XT_LogTime = (DateTime)(DateTime.MinValue);
         n220XT_LogTime = false;
         A176XT_LogPage = "";
         n176XT_LogPage = false;
         A177XT_LogButtonName = "";
         n177XT_LogButtonName = false;
         A213XT_LogType = "";
         n213XT_LogType = false;
         A215XT_LogProviderID = 0;
         n215XT_LogProviderID = false;
         A219XT_LogProviderName = "";
         n219XT_LogProviderName = false;
         A216XT_LogTarget = "";
         n216XT_LogTarget = false;
         A223XT_LogSonTarget = "";
         n223XT_LogSonTarget = false;
         A217XT_LogTargetModule = "";
         n217XT_LogTargetModule = false;
         A222XT_LogTargetSonModule = "";
         n222XT_LogTargetSonModule = false;
         A218XT_LogTargetOperate = "";
         n218XT_LogTargetOperate = false;
         A221XT_LogDescription = "";
         n221XT_LogDescription = false;
         Z214XT_LogUserID = 0;
         Z174XT_LogSecUserName = "";
         Z220XT_LogTime = (DateTime)(DateTime.MinValue);
         Z176XT_LogPage = "";
         Z177XT_LogButtonName = "";
         Z213XT_LogType = "";
         Z215XT_LogProviderID = 0;
         Z219XT_LogProviderName = "";
         Z216XT_LogTarget = "";
         Z223XT_LogSonTarget = "";
         Z217XT_LogTargetModule = "";
         Z222XT_LogTargetSonModule = "";
         Z218XT_LogTargetOperate = "";
         Z221XT_LogDescription = "";
      }

      protected void InitAll0O25( )
      {
         A173XT_LogID = 0;
         InitializeNonKey0O25( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow25( SdtXT_Log obj25 )
      {
         obj25.gxTpr_Mode = Gx_mode;
         obj25.gxTpr_Xt_loguserid = A214XT_LogUserID;
         obj25.gxTpr_Xt_logsecusername = A174XT_LogSecUserName;
         obj25.gxTpr_Xt_logtime = A220XT_LogTime;
         obj25.gxTpr_Xt_logpage = A176XT_LogPage;
         obj25.gxTpr_Xt_logbuttonname = A177XT_LogButtonName;
         obj25.gxTpr_Xt_logtype = A213XT_LogType;
         obj25.gxTpr_Xt_logproviderid = A215XT_LogProviderID;
         obj25.gxTpr_Xt_logprovidername = A219XT_LogProviderName;
         obj25.gxTpr_Xt_logtarget = A216XT_LogTarget;
         obj25.gxTpr_Xt_logsontarget = A223XT_LogSonTarget;
         obj25.gxTpr_Xt_logtargetmodule = A217XT_LogTargetModule;
         obj25.gxTpr_Xt_logtargetsonmodule = A222XT_LogTargetSonModule;
         obj25.gxTpr_Xt_logtargetoperate = A218XT_LogTargetOperate;
         obj25.gxTpr_Xt_logdescription = A221XT_LogDescription;
         obj25.gxTpr_Xt_logid = A173XT_LogID;
         obj25.gxTpr_Xt_logid_Z = Z173XT_LogID;
         obj25.gxTpr_Xt_loguserid_Z = Z214XT_LogUserID;
         obj25.gxTpr_Xt_logsecusername_Z = Z174XT_LogSecUserName;
         obj25.gxTpr_Xt_logtime_Z = Z220XT_LogTime;
         obj25.gxTpr_Xt_logpage_Z = Z176XT_LogPage;
         obj25.gxTpr_Xt_logbuttonname_Z = Z177XT_LogButtonName;
         obj25.gxTpr_Xt_logtype_Z = Z213XT_LogType;
         obj25.gxTpr_Xt_logproviderid_Z = Z215XT_LogProviderID;
         obj25.gxTpr_Xt_logprovidername_Z = Z219XT_LogProviderName;
         obj25.gxTpr_Xt_logtarget_Z = Z216XT_LogTarget;
         obj25.gxTpr_Xt_logsontarget_Z = Z223XT_LogSonTarget;
         obj25.gxTpr_Xt_logtargetmodule_Z = Z217XT_LogTargetModule;
         obj25.gxTpr_Xt_logtargetsonmodule_Z = Z222XT_LogTargetSonModule;
         obj25.gxTpr_Xt_logtargetoperate_Z = Z218XT_LogTargetOperate;
         obj25.gxTpr_Xt_logdescription_Z = Z221XT_LogDescription;
         obj25.gxTpr_Xt_loguserid_N = (short)(Convert.ToInt16(n214XT_LogUserID));
         obj25.gxTpr_Xt_logsecusername_N = (short)(Convert.ToInt16(n174XT_LogSecUserName));
         obj25.gxTpr_Xt_logtime_N = (short)(Convert.ToInt16(n220XT_LogTime));
         obj25.gxTpr_Xt_logpage_N = (short)(Convert.ToInt16(n176XT_LogPage));
         obj25.gxTpr_Xt_logbuttonname_N = (short)(Convert.ToInt16(n177XT_LogButtonName));
         obj25.gxTpr_Xt_logtype_N = (short)(Convert.ToInt16(n213XT_LogType));
         obj25.gxTpr_Xt_logproviderid_N = (short)(Convert.ToInt16(n215XT_LogProviderID));
         obj25.gxTpr_Xt_logprovidername_N = (short)(Convert.ToInt16(n219XT_LogProviderName));
         obj25.gxTpr_Xt_logtarget_N = (short)(Convert.ToInt16(n216XT_LogTarget));
         obj25.gxTpr_Xt_logsontarget_N = (short)(Convert.ToInt16(n223XT_LogSonTarget));
         obj25.gxTpr_Xt_logtargetmodule_N = (short)(Convert.ToInt16(n217XT_LogTargetModule));
         obj25.gxTpr_Xt_logtargetsonmodule_N = (short)(Convert.ToInt16(n222XT_LogTargetSonModule));
         obj25.gxTpr_Xt_logtargetoperate_N = (short)(Convert.ToInt16(n218XT_LogTargetOperate));
         obj25.gxTpr_Xt_logdescription_N = (short)(Convert.ToInt16(n221XT_LogDescription));
         obj25.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow25( SdtXT_Log obj25 )
      {
         obj25.gxTpr_Xt_logid = A173XT_LogID;
         return  ;
      }

      public void RowToVars25( SdtXT_Log obj25 ,
                               int forceLoad )
      {
         Gx_mode = obj25.gxTpr_Mode;
         A214XT_LogUserID = obj25.gxTpr_Xt_loguserid;
         n214XT_LogUserID = false;
         A174XT_LogSecUserName = obj25.gxTpr_Xt_logsecusername;
         n174XT_LogSecUserName = false;
         A220XT_LogTime = obj25.gxTpr_Xt_logtime;
         n220XT_LogTime = false;
         A176XT_LogPage = obj25.gxTpr_Xt_logpage;
         n176XT_LogPage = false;
         A177XT_LogButtonName = obj25.gxTpr_Xt_logbuttonname;
         n177XT_LogButtonName = false;
         A213XT_LogType = obj25.gxTpr_Xt_logtype;
         n213XT_LogType = false;
         A215XT_LogProviderID = obj25.gxTpr_Xt_logproviderid;
         n215XT_LogProviderID = false;
         A219XT_LogProviderName = obj25.gxTpr_Xt_logprovidername;
         n219XT_LogProviderName = false;
         A216XT_LogTarget = obj25.gxTpr_Xt_logtarget;
         n216XT_LogTarget = false;
         A223XT_LogSonTarget = obj25.gxTpr_Xt_logsontarget;
         n223XT_LogSonTarget = false;
         A217XT_LogTargetModule = obj25.gxTpr_Xt_logtargetmodule;
         n217XT_LogTargetModule = false;
         A222XT_LogTargetSonModule = obj25.gxTpr_Xt_logtargetsonmodule;
         n222XT_LogTargetSonModule = false;
         A218XT_LogTargetOperate = obj25.gxTpr_Xt_logtargetoperate;
         n218XT_LogTargetOperate = false;
         A221XT_LogDescription = obj25.gxTpr_Xt_logdescription;
         n221XT_LogDescription = false;
         A173XT_LogID = obj25.gxTpr_Xt_logid;
         Z173XT_LogID = obj25.gxTpr_Xt_logid_Z;
         Z214XT_LogUserID = obj25.gxTpr_Xt_loguserid_Z;
         Z174XT_LogSecUserName = obj25.gxTpr_Xt_logsecusername_Z;
         Z220XT_LogTime = obj25.gxTpr_Xt_logtime_Z;
         Z176XT_LogPage = obj25.gxTpr_Xt_logpage_Z;
         Z177XT_LogButtonName = obj25.gxTpr_Xt_logbuttonname_Z;
         Z213XT_LogType = obj25.gxTpr_Xt_logtype_Z;
         Z215XT_LogProviderID = obj25.gxTpr_Xt_logproviderid_Z;
         Z219XT_LogProviderName = obj25.gxTpr_Xt_logprovidername_Z;
         Z216XT_LogTarget = obj25.gxTpr_Xt_logtarget_Z;
         Z223XT_LogSonTarget = obj25.gxTpr_Xt_logsontarget_Z;
         Z217XT_LogTargetModule = obj25.gxTpr_Xt_logtargetmodule_Z;
         Z222XT_LogTargetSonModule = obj25.gxTpr_Xt_logtargetsonmodule_Z;
         Z218XT_LogTargetOperate = obj25.gxTpr_Xt_logtargetoperate_Z;
         Z221XT_LogDescription = obj25.gxTpr_Xt_logdescription_Z;
         n214XT_LogUserID = (bool)(Convert.ToBoolean(obj25.gxTpr_Xt_loguserid_N));
         n174XT_LogSecUserName = (bool)(Convert.ToBoolean(obj25.gxTpr_Xt_logsecusername_N));
         n220XT_LogTime = (bool)(Convert.ToBoolean(obj25.gxTpr_Xt_logtime_N));
         n176XT_LogPage = (bool)(Convert.ToBoolean(obj25.gxTpr_Xt_logpage_N));
         n177XT_LogButtonName = (bool)(Convert.ToBoolean(obj25.gxTpr_Xt_logbuttonname_N));
         n213XT_LogType = (bool)(Convert.ToBoolean(obj25.gxTpr_Xt_logtype_N));
         n215XT_LogProviderID = (bool)(Convert.ToBoolean(obj25.gxTpr_Xt_logproviderid_N));
         n219XT_LogProviderName = (bool)(Convert.ToBoolean(obj25.gxTpr_Xt_logprovidername_N));
         n216XT_LogTarget = (bool)(Convert.ToBoolean(obj25.gxTpr_Xt_logtarget_N));
         n223XT_LogSonTarget = (bool)(Convert.ToBoolean(obj25.gxTpr_Xt_logsontarget_N));
         n217XT_LogTargetModule = (bool)(Convert.ToBoolean(obj25.gxTpr_Xt_logtargetmodule_N));
         n222XT_LogTargetSonModule = (bool)(Convert.ToBoolean(obj25.gxTpr_Xt_logtargetsonmodule_N));
         n218XT_LogTargetOperate = (bool)(Convert.ToBoolean(obj25.gxTpr_Xt_logtargetoperate_N));
         n221XT_LogDescription = (bool)(Convert.ToBoolean(obj25.gxTpr_Xt_logdescription_N));
         Gx_mode = obj25.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A173XT_LogID = (long)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey0O25( ) ;
         ScanKeyStart0O25( ) ;
         if ( RcdFound25 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z173XT_LogID = A173XT_LogID;
         }
         ZM0O25( -3) ;
         OnLoadActions0O25( ) ;
         AddRow0O25( ) ;
         ScanKeyEnd0O25( ) ;
         if ( RcdFound25 == 0 )
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
         RowToVars25( bcXT_Log, 0) ;
         ScanKeyStart0O25( ) ;
         if ( RcdFound25 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z173XT_LogID = A173XT_LogID;
         }
         ZM0O25( -3) ;
         OnLoadActions0O25( ) ;
         AddRow0O25( ) ;
         ScanKeyEnd0O25( ) ;
         if ( RcdFound25 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey0O25( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert0O25( ) ;
         }
         else
         {
            if ( RcdFound25 == 1 )
            {
               if ( A173XT_LogID != Z173XT_LogID )
               {
                  A173XT_LogID = Z173XT_LogID;
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
                  Update0O25( ) ;
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
                  if ( A173XT_LogID != Z173XT_LogID )
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
                        Insert0O25( ) ;
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
                        Insert0O25( ) ;
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
         RowToVars25( bcXT_Log, 0) ;
         SaveImpl( ) ;
         VarsToRow25( bcXT_Log) ;
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
         RowToVars25( bcXT_Log, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert0O25( ) ;
         AfterTrn( ) ;
         VarsToRow25( bcXT_Log) ;
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
            SdtXT_Log auxBC = new SdtXT_Log(context) ;
            auxBC.Load(A173XT_LogID);
            auxBC.UpdateDirties(bcXT_Log);
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
         RowToVars25( bcXT_Log, 0) ;
         UpdateImpl( ) ;
         VarsToRow25( bcXT_Log) ;
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
         RowToVars25( bcXT_Log, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert0O25( ) ;
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
         VarsToRow25( bcXT_Log) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars25( bcXT_Log, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey0O25( ) ;
         if ( RcdFound25 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A173XT_LogID != Z173XT_LogID )
            {
               A173XT_LogID = Z173XT_LogID;
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
            if ( A173XT_LogID != Z173XT_LogID )
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
         context.RollbackDataStores("xt_log_bc",pr_default);
         VarsToRow25( bcXT_Log) ;
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
         Gx_mode = bcXT_Log.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcXT_Log.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcXT_Log )
         {
            bcXT_Log = (SdtXT_Log)(sdt);
            if ( StringUtil.StrCmp(bcXT_Log.gxTpr_Mode, "") == 0 )
            {
               bcXT_Log.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow25( bcXT_Log) ;
            }
            else
            {
               RowToVars25( bcXT_Log, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcXT_Log.gxTpr_Mode, "") == 0 )
            {
               bcXT_Log.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars25( bcXT_Log, 1) ;
         return  ;
      }

      public SdtXT_Log XT_Log_BC
      {
         get {
            return bcXT_Log ;
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
         AV8WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV13Pgmname = "";
         AV11TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV12WebSession = context.GetSession();
         Z174XT_LogSecUserName = "";
         A174XT_LogSecUserName = "";
         Z220XT_LogTime = (DateTime)(DateTime.MinValue);
         A220XT_LogTime = (DateTime)(DateTime.MinValue);
         Z176XT_LogPage = "";
         A176XT_LogPage = "";
         Z177XT_LogButtonName = "";
         A177XT_LogButtonName = "";
         Z213XT_LogType = "";
         A213XT_LogType = "";
         Z219XT_LogProviderName = "";
         A219XT_LogProviderName = "";
         Z216XT_LogTarget = "";
         A216XT_LogTarget = "";
         Z223XT_LogSonTarget = "";
         A223XT_LogSonTarget = "";
         Z217XT_LogTargetModule = "";
         A217XT_LogTargetModule = "";
         Z222XT_LogTargetSonModule = "";
         A222XT_LogTargetSonModule = "";
         Z218XT_LogTargetOperate = "";
         A218XT_LogTargetOperate = "";
         Z221XT_LogDescription = "";
         A221XT_LogDescription = "";
         BC000O4_A173XT_LogID = new long[1] ;
         BC000O4_A214XT_LogUserID = new long[1] ;
         BC000O4_n214XT_LogUserID = new bool[] {false} ;
         BC000O4_A174XT_LogSecUserName = new String[] {""} ;
         BC000O4_n174XT_LogSecUserName = new bool[] {false} ;
         BC000O4_A220XT_LogTime = new DateTime[] {DateTime.MinValue} ;
         BC000O4_n220XT_LogTime = new bool[] {false} ;
         BC000O4_A176XT_LogPage = new String[] {""} ;
         BC000O4_n176XT_LogPage = new bool[] {false} ;
         BC000O4_A177XT_LogButtonName = new String[] {""} ;
         BC000O4_n177XT_LogButtonName = new bool[] {false} ;
         BC000O4_A213XT_LogType = new String[] {""} ;
         BC000O4_n213XT_LogType = new bool[] {false} ;
         BC000O4_A215XT_LogProviderID = new long[1] ;
         BC000O4_n215XT_LogProviderID = new bool[] {false} ;
         BC000O4_A219XT_LogProviderName = new String[] {""} ;
         BC000O4_n219XT_LogProviderName = new bool[] {false} ;
         BC000O4_A216XT_LogTarget = new String[] {""} ;
         BC000O4_n216XT_LogTarget = new bool[] {false} ;
         BC000O4_A223XT_LogSonTarget = new String[] {""} ;
         BC000O4_n223XT_LogSonTarget = new bool[] {false} ;
         BC000O4_A217XT_LogTargetModule = new String[] {""} ;
         BC000O4_n217XT_LogTargetModule = new bool[] {false} ;
         BC000O4_A222XT_LogTargetSonModule = new String[] {""} ;
         BC000O4_n222XT_LogTargetSonModule = new bool[] {false} ;
         BC000O4_A218XT_LogTargetOperate = new String[] {""} ;
         BC000O4_n218XT_LogTargetOperate = new bool[] {false} ;
         BC000O4_A221XT_LogDescription = new String[] {""} ;
         BC000O4_n221XT_LogDescription = new bool[] {false} ;
         BC000O5_A173XT_LogID = new long[1] ;
         BC000O3_A173XT_LogID = new long[1] ;
         BC000O3_A214XT_LogUserID = new long[1] ;
         BC000O3_n214XT_LogUserID = new bool[] {false} ;
         BC000O3_A174XT_LogSecUserName = new String[] {""} ;
         BC000O3_n174XT_LogSecUserName = new bool[] {false} ;
         BC000O3_A220XT_LogTime = new DateTime[] {DateTime.MinValue} ;
         BC000O3_n220XT_LogTime = new bool[] {false} ;
         BC000O3_A176XT_LogPage = new String[] {""} ;
         BC000O3_n176XT_LogPage = new bool[] {false} ;
         BC000O3_A177XT_LogButtonName = new String[] {""} ;
         BC000O3_n177XT_LogButtonName = new bool[] {false} ;
         BC000O3_A213XT_LogType = new String[] {""} ;
         BC000O3_n213XT_LogType = new bool[] {false} ;
         BC000O3_A215XT_LogProviderID = new long[1] ;
         BC000O3_n215XT_LogProviderID = new bool[] {false} ;
         BC000O3_A219XT_LogProviderName = new String[] {""} ;
         BC000O3_n219XT_LogProviderName = new bool[] {false} ;
         BC000O3_A216XT_LogTarget = new String[] {""} ;
         BC000O3_n216XT_LogTarget = new bool[] {false} ;
         BC000O3_A223XT_LogSonTarget = new String[] {""} ;
         BC000O3_n223XT_LogSonTarget = new bool[] {false} ;
         BC000O3_A217XT_LogTargetModule = new String[] {""} ;
         BC000O3_n217XT_LogTargetModule = new bool[] {false} ;
         BC000O3_A222XT_LogTargetSonModule = new String[] {""} ;
         BC000O3_n222XT_LogTargetSonModule = new bool[] {false} ;
         BC000O3_A218XT_LogTargetOperate = new String[] {""} ;
         BC000O3_n218XT_LogTargetOperate = new bool[] {false} ;
         BC000O3_A221XT_LogDescription = new String[] {""} ;
         BC000O3_n221XT_LogDescription = new bool[] {false} ;
         sMode25 = "";
         BC000O2_A173XT_LogID = new long[1] ;
         BC000O2_A214XT_LogUserID = new long[1] ;
         BC000O2_n214XT_LogUserID = new bool[] {false} ;
         BC000O2_A174XT_LogSecUserName = new String[] {""} ;
         BC000O2_n174XT_LogSecUserName = new bool[] {false} ;
         BC000O2_A220XT_LogTime = new DateTime[] {DateTime.MinValue} ;
         BC000O2_n220XT_LogTime = new bool[] {false} ;
         BC000O2_A176XT_LogPage = new String[] {""} ;
         BC000O2_n176XT_LogPage = new bool[] {false} ;
         BC000O2_A177XT_LogButtonName = new String[] {""} ;
         BC000O2_n177XT_LogButtonName = new bool[] {false} ;
         BC000O2_A213XT_LogType = new String[] {""} ;
         BC000O2_n213XT_LogType = new bool[] {false} ;
         BC000O2_A215XT_LogProviderID = new long[1] ;
         BC000O2_n215XT_LogProviderID = new bool[] {false} ;
         BC000O2_A219XT_LogProviderName = new String[] {""} ;
         BC000O2_n219XT_LogProviderName = new bool[] {false} ;
         BC000O2_A216XT_LogTarget = new String[] {""} ;
         BC000O2_n216XT_LogTarget = new bool[] {false} ;
         BC000O2_A223XT_LogSonTarget = new String[] {""} ;
         BC000O2_n223XT_LogSonTarget = new bool[] {false} ;
         BC000O2_A217XT_LogTargetModule = new String[] {""} ;
         BC000O2_n217XT_LogTargetModule = new bool[] {false} ;
         BC000O2_A222XT_LogTargetSonModule = new String[] {""} ;
         BC000O2_n222XT_LogTargetSonModule = new bool[] {false} ;
         BC000O2_A218XT_LogTargetOperate = new String[] {""} ;
         BC000O2_n218XT_LogTargetOperate = new bool[] {false} ;
         BC000O2_A221XT_LogDescription = new String[] {""} ;
         BC000O2_n221XT_LogDescription = new bool[] {false} ;
         BC000O6_A173XT_LogID = new long[1] ;
         BC000O9_A173XT_LogID = new long[1] ;
         BC000O9_A214XT_LogUserID = new long[1] ;
         BC000O9_n214XT_LogUserID = new bool[] {false} ;
         BC000O9_A174XT_LogSecUserName = new String[] {""} ;
         BC000O9_n174XT_LogSecUserName = new bool[] {false} ;
         BC000O9_A220XT_LogTime = new DateTime[] {DateTime.MinValue} ;
         BC000O9_n220XT_LogTime = new bool[] {false} ;
         BC000O9_A176XT_LogPage = new String[] {""} ;
         BC000O9_n176XT_LogPage = new bool[] {false} ;
         BC000O9_A177XT_LogButtonName = new String[] {""} ;
         BC000O9_n177XT_LogButtonName = new bool[] {false} ;
         BC000O9_A213XT_LogType = new String[] {""} ;
         BC000O9_n213XT_LogType = new bool[] {false} ;
         BC000O9_A215XT_LogProviderID = new long[1] ;
         BC000O9_n215XT_LogProviderID = new bool[] {false} ;
         BC000O9_A219XT_LogProviderName = new String[] {""} ;
         BC000O9_n219XT_LogProviderName = new bool[] {false} ;
         BC000O9_A216XT_LogTarget = new String[] {""} ;
         BC000O9_n216XT_LogTarget = new bool[] {false} ;
         BC000O9_A223XT_LogSonTarget = new String[] {""} ;
         BC000O9_n223XT_LogSonTarget = new bool[] {false} ;
         BC000O9_A217XT_LogTargetModule = new String[] {""} ;
         BC000O9_n217XT_LogTargetModule = new bool[] {false} ;
         BC000O9_A222XT_LogTargetSonModule = new String[] {""} ;
         BC000O9_n222XT_LogTargetSonModule = new bool[] {false} ;
         BC000O9_A218XT_LogTargetOperate = new String[] {""} ;
         BC000O9_n218XT_LogTargetOperate = new bool[] {false} ;
         BC000O9_A221XT_LogDescription = new String[] {""} ;
         BC000O9_n221XT_LogDescription = new bool[] {false} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.xt_log_bc__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.xt_log_bc__default(),
            new Object[][] {
                new Object[] {
               BC000O2_A173XT_LogID, BC000O2_A214XT_LogUserID, BC000O2_n214XT_LogUserID, BC000O2_A174XT_LogSecUserName, BC000O2_n174XT_LogSecUserName, BC000O2_A220XT_LogTime, BC000O2_n220XT_LogTime, BC000O2_A176XT_LogPage, BC000O2_n176XT_LogPage, BC000O2_A177XT_LogButtonName,
               BC000O2_n177XT_LogButtonName, BC000O2_A213XT_LogType, BC000O2_n213XT_LogType, BC000O2_A215XT_LogProviderID, BC000O2_n215XT_LogProviderID, BC000O2_A219XT_LogProviderName, BC000O2_n219XT_LogProviderName, BC000O2_A216XT_LogTarget, BC000O2_n216XT_LogTarget, BC000O2_A223XT_LogSonTarget,
               BC000O2_n223XT_LogSonTarget, BC000O2_A217XT_LogTargetModule, BC000O2_n217XT_LogTargetModule, BC000O2_A222XT_LogTargetSonModule, BC000O2_n222XT_LogTargetSonModule, BC000O2_A218XT_LogTargetOperate, BC000O2_n218XT_LogTargetOperate, BC000O2_A221XT_LogDescription, BC000O2_n221XT_LogDescription
               }
               , new Object[] {
               BC000O3_A173XT_LogID, BC000O3_A214XT_LogUserID, BC000O3_n214XT_LogUserID, BC000O3_A174XT_LogSecUserName, BC000O3_n174XT_LogSecUserName, BC000O3_A220XT_LogTime, BC000O3_n220XT_LogTime, BC000O3_A176XT_LogPage, BC000O3_n176XT_LogPage, BC000O3_A177XT_LogButtonName,
               BC000O3_n177XT_LogButtonName, BC000O3_A213XT_LogType, BC000O3_n213XT_LogType, BC000O3_A215XT_LogProviderID, BC000O3_n215XT_LogProviderID, BC000O3_A219XT_LogProviderName, BC000O3_n219XT_LogProviderName, BC000O3_A216XT_LogTarget, BC000O3_n216XT_LogTarget, BC000O3_A223XT_LogSonTarget,
               BC000O3_n223XT_LogSonTarget, BC000O3_A217XT_LogTargetModule, BC000O3_n217XT_LogTargetModule, BC000O3_A222XT_LogTargetSonModule, BC000O3_n222XT_LogTargetSonModule, BC000O3_A218XT_LogTargetOperate, BC000O3_n218XT_LogTargetOperate, BC000O3_A221XT_LogDescription, BC000O3_n221XT_LogDescription
               }
               , new Object[] {
               BC000O4_A173XT_LogID, BC000O4_A214XT_LogUserID, BC000O4_n214XT_LogUserID, BC000O4_A174XT_LogSecUserName, BC000O4_n174XT_LogSecUserName, BC000O4_A220XT_LogTime, BC000O4_n220XT_LogTime, BC000O4_A176XT_LogPage, BC000O4_n176XT_LogPage, BC000O4_A177XT_LogButtonName,
               BC000O4_n177XT_LogButtonName, BC000O4_A213XT_LogType, BC000O4_n213XT_LogType, BC000O4_A215XT_LogProviderID, BC000O4_n215XT_LogProviderID, BC000O4_A219XT_LogProviderName, BC000O4_n219XT_LogProviderName, BC000O4_A216XT_LogTarget, BC000O4_n216XT_LogTarget, BC000O4_A223XT_LogSonTarget,
               BC000O4_n223XT_LogSonTarget, BC000O4_A217XT_LogTargetModule, BC000O4_n217XT_LogTargetModule, BC000O4_A222XT_LogTargetSonModule, BC000O4_n222XT_LogTargetSonModule, BC000O4_A218XT_LogTargetOperate, BC000O4_n218XT_LogTargetOperate, BC000O4_A221XT_LogDescription, BC000O4_n221XT_LogDescription
               }
               , new Object[] {
               BC000O5_A173XT_LogID
               }
               , new Object[] {
               BC000O6_A173XT_LogID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000O9_A173XT_LogID, BC000O9_A214XT_LogUserID, BC000O9_n214XT_LogUserID, BC000O9_A174XT_LogSecUserName, BC000O9_n174XT_LogSecUserName, BC000O9_A220XT_LogTime, BC000O9_n220XT_LogTime, BC000O9_A176XT_LogPage, BC000O9_n176XT_LogPage, BC000O9_A177XT_LogButtonName,
               BC000O9_n177XT_LogButtonName, BC000O9_A213XT_LogType, BC000O9_n213XT_LogType, BC000O9_A215XT_LogProviderID, BC000O9_n215XT_LogProviderID, BC000O9_A219XT_LogProviderName, BC000O9_n219XT_LogProviderName, BC000O9_A216XT_LogTarget, BC000O9_n216XT_LogTarget, BC000O9_A223XT_LogSonTarget,
               BC000O9_n223XT_LogSonTarget, BC000O9_A217XT_LogTargetModule, BC000O9_n217XT_LogTargetModule, BC000O9_A222XT_LogTargetSonModule, BC000O9_n222XT_LogTargetSonModule, BC000O9_A218XT_LogTargetOperate, BC000O9_n218XT_LogTargetOperate, BC000O9_A221XT_LogDescription, BC000O9_n221XT_LogDescription
               }
            }
         );
         AV13Pgmname = "XT_Log_BC";
         INITTRN();
         /* Execute Start event if defined. */
         /* Execute user event: Start */
         E120O2 ();
         standaloneNotModal( ) ;
      }

      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short GX_JID ;
      private short RcdFound25 ;
      private int trnEnded ;
      private long Z173XT_LogID ;
      private long A173XT_LogID ;
      private long Z214XT_LogUserID ;
      private long A214XT_LogUserID ;
      private long Z215XT_LogProviderID ;
      private long A215XT_LogProviderID ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String AV13Pgmname ;
      private String sMode25 ;
      private DateTime Z220XT_LogTime ;
      private DateTime A220XT_LogTime ;
      private bool AV9IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool n214XT_LogUserID ;
      private bool n174XT_LogSecUserName ;
      private bool n220XT_LogTime ;
      private bool n176XT_LogPage ;
      private bool n177XT_LogButtonName ;
      private bool n213XT_LogType ;
      private bool n215XT_LogProviderID ;
      private bool n219XT_LogProviderName ;
      private bool n216XT_LogTarget ;
      private bool n223XT_LogSonTarget ;
      private bool n217XT_LogTargetModule ;
      private bool n222XT_LogTargetSonModule ;
      private bool n218XT_LogTargetOperate ;
      private bool n221XT_LogDescription ;
      private bool Gx_longc ;
      private String Z174XT_LogSecUserName ;
      private String A174XT_LogSecUserName ;
      private String Z176XT_LogPage ;
      private String A176XT_LogPage ;
      private String Z177XT_LogButtonName ;
      private String A177XT_LogButtonName ;
      private String Z213XT_LogType ;
      private String A213XT_LogType ;
      private String Z219XT_LogProviderName ;
      private String A219XT_LogProviderName ;
      private String Z216XT_LogTarget ;
      private String A216XT_LogTarget ;
      private String Z223XT_LogSonTarget ;
      private String A223XT_LogSonTarget ;
      private String Z217XT_LogTargetModule ;
      private String A217XT_LogTargetModule ;
      private String Z222XT_LogTargetSonModule ;
      private String A222XT_LogTargetSonModule ;
      private String Z218XT_LogTargetOperate ;
      private String A218XT_LogTargetOperate ;
      private String Z221XT_LogDescription ;
      private String A221XT_LogDescription ;
      private IGxSession AV12WebSession ;
      private SdtXT_Log bcXT_Log ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] BC000O4_A173XT_LogID ;
      private long[] BC000O4_A214XT_LogUserID ;
      private bool[] BC000O4_n214XT_LogUserID ;
      private String[] BC000O4_A174XT_LogSecUserName ;
      private bool[] BC000O4_n174XT_LogSecUserName ;
      private DateTime[] BC000O4_A220XT_LogTime ;
      private bool[] BC000O4_n220XT_LogTime ;
      private String[] BC000O4_A176XT_LogPage ;
      private bool[] BC000O4_n176XT_LogPage ;
      private String[] BC000O4_A177XT_LogButtonName ;
      private bool[] BC000O4_n177XT_LogButtonName ;
      private String[] BC000O4_A213XT_LogType ;
      private bool[] BC000O4_n213XT_LogType ;
      private long[] BC000O4_A215XT_LogProviderID ;
      private bool[] BC000O4_n215XT_LogProviderID ;
      private String[] BC000O4_A219XT_LogProviderName ;
      private bool[] BC000O4_n219XT_LogProviderName ;
      private String[] BC000O4_A216XT_LogTarget ;
      private bool[] BC000O4_n216XT_LogTarget ;
      private String[] BC000O4_A223XT_LogSonTarget ;
      private bool[] BC000O4_n223XT_LogSonTarget ;
      private String[] BC000O4_A217XT_LogTargetModule ;
      private bool[] BC000O4_n217XT_LogTargetModule ;
      private String[] BC000O4_A222XT_LogTargetSonModule ;
      private bool[] BC000O4_n222XT_LogTargetSonModule ;
      private String[] BC000O4_A218XT_LogTargetOperate ;
      private bool[] BC000O4_n218XT_LogTargetOperate ;
      private String[] BC000O4_A221XT_LogDescription ;
      private bool[] BC000O4_n221XT_LogDescription ;
      private long[] BC000O5_A173XT_LogID ;
      private long[] BC000O3_A173XT_LogID ;
      private long[] BC000O3_A214XT_LogUserID ;
      private bool[] BC000O3_n214XT_LogUserID ;
      private String[] BC000O3_A174XT_LogSecUserName ;
      private bool[] BC000O3_n174XT_LogSecUserName ;
      private DateTime[] BC000O3_A220XT_LogTime ;
      private bool[] BC000O3_n220XT_LogTime ;
      private String[] BC000O3_A176XT_LogPage ;
      private bool[] BC000O3_n176XT_LogPage ;
      private String[] BC000O3_A177XT_LogButtonName ;
      private bool[] BC000O3_n177XT_LogButtonName ;
      private String[] BC000O3_A213XT_LogType ;
      private bool[] BC000O3_n213XT_LogType ;
      private long[] BC000O3_A215XT_LogProviderID ;
      private bool[] BC000O3_n215XT_LogProviderID ;
      private String[] BC000O3_A219XT_LogProviderName ;
      private bool[] BC000O3_n219XT_LogProviderName ;
      private String[] BC000O3_A216XT_LogTarget ;
      private bool[] BC000O3_n216XT_LogTarget ;
      private String[] BC000O3_A223XT_LogSonTarget ;
      private bool[] BC000O3_n223XT_LogSonTarget ;
      private String[] BC000O3_A217XT_LogTargetModule ;
      private bool[] BC000O3_n217XT_LogTargetModule ;
      private String[] BC000O3_A222XT_LogTargetSonModule ;
      private bool[] BC000O3_n222XT_LogTargetSonModule ;
      private String[] BC000O3_A218XT_LogTargetOperate ;
      private bool[] BC000O3_n218XT_LogTargetOperate ;
      private String[] BC000O3_A221XT_LogDescription ;
      private bool[] BC000O3_n221XT_LogDescription ;
      private long[] BC000O2_A173XT_LogID ;
      private long[] BC000O2_A214XT_LogUserID ;
      private bool[] BC000O2_n214XT_LogUserID ;
      private String[] BC000O2_A174XT_LogSecUserName ;
      private bool[] BC000O2_n174XT_LogSecUserName ;
      private DateTime[] BC000O2_A220XT_LogTime ;
      private bool[] BC000O2_n220XT_LogTime ;
      private String[] BC000O2_A176XT_LogPage ;
      private bool[] BC000O2_n176XT_LogPage ;
      private String[] BC000O2_A177XT_LogButtonName ;
      private bool[] BC000O2_n177XT_LogButtonName ;
      private String[] BC000O2_A213XT_LogType ;
      private bool[] BC000O2_n213XT_LogType ;
      private long[] BC000O2_A215XT_LogProviderID ;
      private bool[] BC000O2_n215XT_LogProviderID ;
      private String[] BC000O2_A219XT_LogProviderName ;
      private bool[] BC000O2_n219XT_LogProviderName ;
      private String[] BC000O2_A216XT_LogTarget ;
      private bool[] BC000O2_n216XT_LogTarget ;
      private String[] BC000O2_A223XT_LogSonTarget ;
      private bool[] BC000O2_n223XT_LogSonTarget ;
      private String[] BC000O2_A217XT_LogTargetModule ;
      private bool[] BC000O2_n217XT_LogTargetModule ;
      private String[] BC000O2_A222XT_LogTargetSonModule ;
      private bool[] BC000O2_n222XT_LogTargetSonModule ;
      private String[] BC000O2_A218XT_LogTargetOperate ;
      private bool[] BC000O2_n218XT_LogTargetOperate ;
      private String[] BC000O2_A221XT_LogDescription ;
      private bool[] BC000O2_n221XT_LogDescription ;
      private long[] BC000O6_A173XT_LogID ;
      private long[] BC000O9_A173XT_LogID ;
      private long[] BC000O9_A214XT_LogUserID ;
      private bool[] BC000O9_n214XT_LogUserID ;
      private String[] BC000O9_A174XT_LogSecUserName ;
      private bool[] BC000O9_n174XT_LogSecUserName ;
      private DateTime[] BC000O9_A220XT_LogTime ;
      private bool[] BC000O9_n220XT_LogTime ;
      private String[] BC000O9_A176XT_LogPage ;
      private bool[] BC000O9_n176XT_LogPage ;
      private String[] BC000O9_A177XT_LogButtonName ;
      private bool[] BC000O9_n177XT_LogButtonName ;
      private String[] BC000O9_A213XT_LogType ;
      private bool[] BC000O9_n213XT_LogType ;
      private long[] BC000O9_A215XT_LogProviderID ;
      private bool[] BC000O9_n215XT_LogProviderID ;
      private String[] BC000O9_A219XT_LogProviderName ;
      private bool[] BC000O9_n219XT_LogProviderName ;
      private String[] BC000O9_A216XT_LogTarget ;
      private bool[] BC000O9_n216XT_LogTarget ;
      private String[] BC000O9_A223XT_LogSonTarget ;
      private bool[] BC000O9_n223XT_LogSonTarget ;
      private String[] BC000O9_A217XT_LogTargetModule ;
      private bool[] BC000O9_n217XT_LogTargetModule ;
      private String[] BC000O9_A222XT_LogTargetSonModule ;
      private bool[] BC000O9_n222XT_LogTargetSonModule ;
      private String[] BC000O9_A218XT_LogTargetOperate ;
      private bool[] BC000O9_n218XT_LogTargetOperate ;
      private String[] BC000O9_A221XT_LogDescription ;
      private bool[] BC000O9_n221XT_LogDescription ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_datastore1 ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV8WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV11TrnContext ;
   }

   public class xt_log_bc__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class xt_log_bc__default : DataStoreHelperBase, IDataStoreHelper
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
       ,new UpdateCursor(def[5])
       ,new UpdateCursor(def[6])
       ,new ForEachCursor(def[7])
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmBC000O4 ;
        prmBC000O4 = new Object[] {
        new Object[] {"@XT_LogID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000O5 ;
        prmBC000O5 = new Object[] {
        new Object[] {"@XT_LogID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000O3 ;
        prmBC000O3 = new Object[] {
        new Object[] {"@XT_LogID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000O2 ;
        prmBC000O2 = new Object[] {
        new Object[] {"@XT_LogID",SqlDbType.Decimal,18,0}
        } ;
        /* Definition of XT_LogTarget changed to svchar length 4000 decimals 0 */
        /* Definition of XT_LogDescription changed to svchar length 4000 decimals 0 */
        Object[] prmBC000O6 ;
        prmBC000O6 = new Object[] {
        new Object[] {"@XT_LogUserID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@XT_LogSecUserName",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@XT_LogTime",SqlDbType.DateTime,10,8} ,
        new Object[] {"@XT_LogPage",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@XT_LogButtonName",SqlDbType.NVarChar,50,0} ,
        new Object[] {"@XT_LogType",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@XT_LogProviderID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@XT_LogProviderName",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@XT_LogTarget",SqlDbType.NVarChar,4000,0} ,
        new Object[] {"@XT_LogSonTarget",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@XT_LogTargetModule",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@XT_LogTargetSonModule",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@XT_LogTargetOperate",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@XT_LogDescription",SqlDbType.NVarChar,4000,0}
        } ;
        /* Definition of XT_LogTarget changed to svchar length 4000 decimals 0 */
        /* Definition of XT_LogDescription changed to svchar length 4000 decimals 0 */
        Object[] prmBC000O7 ;
        prmBC000O7 = new Object[] {
        new Object[] {"@XT_LogUserID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@XT_LogSecUserName",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@XT_LogTime",SqlDbType.DateTime,10,8} ,
        new Object[] {"@XT_LogPage",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@XT_LogButtonName",SqlDbType.NVarChar,50,0} ,
        new Object[] {"@XT_LogType",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@XT_LogProviderID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@XT_LogProviderName",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@XT_LogTarget",SqlDbType.NVarChar,4000,0} ,
        new Object[] {"@XT_LogSonTarget",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@XT_LogTargetModule",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@XT_LogTargetSonModule",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@XT_LogTargetOperate",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@XT_LogDescription",SqlDbType.NVarChar,4000,0} ,
        new Object[] {"@XT_LogID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000O8 ;
        prmBC000O8 = new Object[] {
        new Object[] {"@XT_LogID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000O9 ;
        prmBC000O9 = new Object[] {
        new Object[] {"@XT_LogID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("BC000O2", "SELECT [XT_LogID], [XT_LogUserID], [XT_LogSecUserName], [XT_LogTime], [XT_LogPage], [XT_LogButtonName], [XT_LogType], [XT_LogProviderID], [XT_LogProviderName], [XT_LogTarget], [XT_LogSonTarget], [XT_LogTargetModule], [XT_LogTargetSonModule], [XT_LogTargetOperate], [XT_LogDescription] FROM [XT_Log] WITH (UPDLOCK) WHERE [XT_LogID] = @XT_LogID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000O2,1,0,true,false )
           ,new CursorDef("BC000O3", "SELECT [XT_LogID], [XT_LogUserID], [XT_LogSecUserName], [XT_LogTime], [XT_LogPage], [XT_LogButtonName], [XT_LogType], [XT_LogProviderID], [XT_LogProviderName], [XT_LogTarget], [XT_LogSonTarget], [XT_LogTargetModule], [XT_LogTargetSonModule], [XT_LogTargetOperate], [XT_LogDescription] FROM [XT_Log] WITH (NOLOCK) WHERE [XT_LogID] = @XT_LogID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000O3,1,0,true,false )
           ,new CursorDef("BC000O4", "SELECT TM1.[XT_LogID], TM1.[XT_LogUserID], TM1.[XT_LogSecUserName], TM1.[XT_LogTime], TM1.[XT_LogPage], TM1.[XT_LogButtonName], TM1.[XT_LogType], TM1.[XT_LogProviderID], TM1.[XT_LogProviderName], TM1.[XT_LogTarget], TM1.[XT_LogSonTarget], TM1.[XT_LogTargetModule], TM1.[XT_LogTargetSonModule], TM1.[XT_LogTargetOperate], TM1.[XT_LogDescription] FROM [XT_Log] TM1 WITH (NOLOCK) WHERE TM1.[XT_LogID] = @XT_LogID ORDER BY TM1.[XT_LogID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000O4,100,0,true,false )
           ,new CursorDef("BC000O5", "SELECT [XT_LogID] FROM [XT_Log] WITH (NOLOCK) WHERE [XT_LogID] = @XT_LogID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000O5,1,0,true,false )
           ,new CursorDef("BC000O6", "INSERT INTO [XT_Log]([XT_LogUserID], [XT_LogSecUserName], [XT_LogTime], [XT_LogPage], [XT_LogButtonName], [XT_LogType], [XT_LogProviderID], [XT_LogProviderName], [XT_LogTarget], [XT_LogSonTarget], [XT_LogTargetModule], [XT_LogTargetSonModule], [XT_LogTargetOperate], [XT_LogDescription]) VALUES(@XT_LogUserID, @XT_LogSecUserName, @XT_LogTime, @XT_LogPage, @XT_LogButtonName, @XT_LogType, @XT_LogProviderID, @XT_LogProviderName, @XT_LogTarget, @XT_LogSonTarget, @XT_LogTargetModule, @XT_LogTargetSonModule, @XT_LogTargetOperate, @XT_LogDescription); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmBC000O6)
           ,new CursorDef("BC000O7", "UPDATE [XT_Log] SET [XT_LogUserID]=@XT_LogUserID, [XT_LogSecUserName]=@XT_LogSecUserName, [XT_LogTime]=@XT_LogTime, [XT_LogPage]=@XT_LogPage, [XT_LogButtonName]=@XT_LogButtonName, [XT_LogType]=@XT_LogType, [XT_LogProviderID]=@XT_LogProviderID, [XT_LogProviderName]=@XT_LogProviderName, [XT_LogTarget]=@XT_LogTarget, [XT_LogSonTarget]=@XT_LogSonTarget, [XT_LogTargetModule]=@XT_LogTargetModule, [XT_LogTargetSonModule]=@XT_LogTargetSonModule, [XT_LogTargetOperate]=@XT_LogTargetOperate, [XT_LogDescription]=@XT_LogDescription  WHERE [XT_LogID] = @XT_LogID", GxErrorMask.GX_NOMASK,prmBC000O7)
           ,new CursorDef("BC000O8", "DELETE FROM [XT_Log]  WHERE [XT_LogID] = @XT_LogID", GxErrorMask.GX_NOMASK,prmBC000O8)
           ,new CursorDef("BC000O9", "SELECT TM1.[XT_LogID], TM1.[XT_LogUserID], TM1.[XT_LogSecUserName], TM1.[XT_LogTime], TM1.[XT_LogPage], TM1.[XT_LogButtonName], TM1.[XT_LogType], TM1.[XT_LogProviderID], TM1.[XT_LogProviderName], TM1.[XT_LogTarget], TM1.[XT_LogSonTarget], TM1.[XT_LogTargetModule], TM1.[XT_LogTargetSonModule], TM1.[XT_LogTargetOperate], TM1.[XT_LogDescription] FROM [XT_Log] TM1 WITH (NOLOCK) WHERE TM1.[XT_LogID] = @XT_LogID ORDER BY TM1.[XT_LogID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000O9,100,0,true,false )
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
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((DateTime[]) buf[5])[0] = rslt.getGXDateTime(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((long[]) buf[13])[0] = rslt.getLong(8) ;
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
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((DateTime[]) buf[5])[0] = rslt.getGXDateTime(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((long[]) buf[13])[0] = rslt.getLong(8) ;
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
              return;
           case 2 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((DateTime[]) buf[5])[0] = rslt.getGXDateTime(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((long[]) buf[13])[0] = rslt.getLong(8) ;
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
              return;
           case 3 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 4 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 7 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((DateTime[]) buf[5])[0] = rslt.getGXDateTime(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((long[]) buf[13])[0] = rslt.getLong(8) ;
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
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
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
                 stmt.SetParameterDatetime(3, (DateTime)parms[5]);
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
                 stmt.setNull( 7 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(7, (long)parms[13]);
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
              return;
           case 5 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
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
                 stmt.SetParameterDatetime(3, (DateTime)parms[5]);
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
                 stmt.setNull( 7 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(7, (long)parms[13]);
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
              stmt.SetParameter(15, (long)parms[28]);
              return;
           case 6 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 7 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
     }
  }

}

}
