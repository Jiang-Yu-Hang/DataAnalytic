/*
               File: SYS_Log_BC
        Description: SYS_Log
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:9:0.66
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
   public class sys_log_bc : GXHttpHandler, IGxSilentTrn
   {
      public sys_log_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public sys_log_bc( IGxContext context )
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
         ReadRow1L60( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey1L60( ) ;
         standaloneModal( ) ;
         AddRow1L60( ) ;
         Gx_mode = "INS";
         return  ;
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               Z442SYS_LogLogID = A442SYS_LogLogID;
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

      protected void CONFIRM_1L0( )
      {
         BeforeValidate1L60( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls1L60( ) ;
            }
            else
            {
               CheckExtendedTable1L60( ) ;
               if ( AnyError == 0 )
               {
               }
               CloseExtendedTableCursors1L60( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void ZM1L60( short GX_JID )
      {
         if ( ( GX_JID == 2 ) || ( GX_JID == 0 ) )
         {
            Z372SYS_LogTenantCode = A372SYS_LogTenantCode;
            Z451SYS_LogTitle = A451SYS_LogTitle;
            Z449SYS_LogClientIP = A449SYS_LogClientIP;
            Z376SYS_LogModuleCode = A376SYS_LogModuleCode;
            Z448SYS_LogLogType = A448SYS_LogLogType;
            Z378SYS_LogCreator = A378SYS_LogCreator;
            Z379SYS_LogCreateTime = A379SYS_LogCreateTime;
         }
         if ( GX_JID == -2 )
         {
            Z442SYS_LogLogID = A442SYS_LogLogID;
            Z372SYS_LogTenantCode = A372SYS_LogTenantCode;
            Z451SYS_LogTitle = A451SYS_LogTitle;
            Z450SYS_LogContent = A450SYS_LogContent;
            Z449SYS_LogClientIP = A449SYS_LogClientIP;
            Z376SYS_LogModuleCode = A376SYS_LogModuleCode;
            Z448SYS_LogLogType = A448SYS_LogLogType;
            Z378SYS_LogCreator = A378SYS_LogCreator;
            Z379SYS_LogCreateTime = A379SYS_LogCreateTime;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load1L60( )
      {
         /* Using cursor BC001L4 */
         pr_datastore1.execute(2, new Object[] {A442SYS_LogLogID});
         if ( (pr_datastore1.getStatus(2) != 101) )
         {
            RcdFound60 = 1;
            A372SYS_LogTenantCode = BC001L4_A372SYS_LogTenantCode[0];
            n372SYS_LogTenantCode = BC001L4_n372SYS_LogTenantCode[0];
            A451SYS_LogTitle = BC001L4_A451SYS_LogTitle[0];
            A450SYS_LogContent = BC001L4_A450SYS_LogContent[0];
            n450SYS_LogContent = BC001L4_n450SYS_LogContent[0];
            A449SYS_LogClientIP = BC001L4_A449SYS_LogClientIP[0];
            n449SYS_LogClientIP = BC001L4_n449SYS_LogClientIP[0];
            A376SYS_LogModuleCode = BC001L4_A376SYS_LogModuleCode[0];
            n376SYS_LogModuleCode = BC001L4_n376SYS_LogModuleCode[0];
            A448SYS_LogLogType = BC001L4_A448SYS_LogLogType[0];
            n448SYS_LogLogType = BC001L4_n448SYS_LogLogType[0];
            A378SYS_LogCreator = BC001L4_A378SYS_LogCreator[0];
            A379SYS_LogCreateTime = BC001L4_A379SYS_LogCreateTime[0];
            ZM1L60( -2) ;
         }
         pr_datastore1.close(2);
         OnLoadActions1L60( ) ;
      }

      protected void OnLoadActions1L60( )
      {
      }

      protected void CheckExtendedTable1L60( )
      {
         standaloneModal( ) ;
         if ( ! ( (DateTime.MinValue==A379SYS_LogCreateTime) || ( A379SYS_LogCreateTime >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("”ÚSYS_Log Create Time≥¨ΩÁ", "OutOfRange", 1, "");
            AnyError = 1;
         }
      }

      protected void CloseExtendedTableCursors1L60( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey1L60( )
      {
         /* Using cursor BC001L5 */
         pr_datastore1.execute(3, new Object[] {A442SYS_LogLogID});
         if ( (pr_datastore1.getStatus(3) != 101) )
         {
            RcdFound60 = 1;
         }
         else
         {
            RcdFound60 = 0;
         }
         pr_datastore1.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC001L3 */
         pr_datastore1.execute(1, new Object[] {A442SYS_LogLogID});
         if ( (pr_datastore1.getStatus(1) != 101) )
         {
            ZM1L60( 2) ;
            RcdFound60 = 1;
            A442SYS_LogLogID = BC001L3_A442SYS_LogLogID[0];
            A372SYS_LogTenantCode = BC001L3_A372SYS_LogTenantCode[0];
            n372SYS_LogTenantCode = BC001L3_n372SYS_LogTenantCode[0];
            A451SYS_LogTitle = BC001L3_A451SYS_LogTitle[0];
            A450SYS_LogContent = BC001L3_A450SYS_LogContent[0];
            n450SYS_LogContent = BC001L3_n450SYS_LogContent[0];
            A449SYS_LogClientIP = BC001L3_A449SYS_LogClientIP[0];
            n449SYS_LogClientIP = BC001L3_n449SYS_LogClientIP[0];
            A376SYS_LogModuleCode = BC001L3_A376SYS_LogModuleCode[0];
            n376SYS_LogModuleCode = BC001L3_n376SYS_LogModuleCode[0];
            A448SYS_LogLogType = BC001L3_A448SYS_LogLogType[0];
            n448SYS_LogLogType = BC001L3_n448SYS_LogLogType[0];
            A378SYS_LogCreator = BC001L3_A378SYS_LogCreator[0];
            A379SYS_LogCreateTime = BC001L3_A379SYS_LogCreateTime[0];
            Z442SYS_LogLogID = A442SYS_LogLogID;
            sMode60 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load1L60( ) ;
            if ( AnyError == 1 )
            {
               RcdFound60 = 0;
               InitializeNonKey1L60( ) ;
            }
            Gx_mode = sMode60;
         }
         else
         {
            RcdFound60 = 0;
            InitializeNonKey1L60( ) ;
            sMode60 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode60;
         }
         pr_datastore1.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1L60( ) ;
         if ( RcdFound60 == 0 )
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
         CONFIRM_1L0( ) ;
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

      protected void CheckOptimisticConcurrency1L60( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC001L2 */
            pr_datastore1.execute(0, new Object[] {A442SYS_LogLogID});
            if ( (pr_datastore1.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SYS_LOG"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_datastore1.getStatus(0) == 101) || ( StringUtil.StrCmp(Z372SYS_LogTenantCode, BC001L2_A372SYS_LogTenantCode[0]) != 0 ) || ( StringUtil.StrCmp(Z451SYS_LogTitle, BC001L2_A451SYS_LogTitle[0]) != 0 ) || ( StringUtil.StrCmp(Z449SYS_LogClientIP, BC001L2_A449SYS_LogClientIP[0]) != 0 ) || ( StringUtil.StrCmp(Z376SYS_LogModuleCode, BC001L2_A376SYS_LogModuleCode[0]) != 0 ) || ( StringUtil.StrCmp(Z448SYS_LogLogType, BC001L2_A448SYS_LogLogType[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z378SYS_LogCreator, BC001L2_A378SYS_LogCreator[0]) != 0 ) || ( Z379SYS_LogCreateTime != BC001L2_A379SYS_LogCreateTime[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"SYS_LOG"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert1L60( )
      {
         BeforeValidate1L60( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1L60( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1L60( 0) ;
            CheckOptimisticConcurrency1L60( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1L60( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1L60( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC001L6 */
                     pr_datastore1.execute(4, new Object[] {n372SYS_LogTenantCode, A372SYS_LogTenantCode, A451SYS_LogTitle, n450SYS_LogContent, A450SYS_LogContent, n449SYS_LogClientIP, A449SYS_LogClientIP, n376SYS_LogModuleCode, A376SYS_LogModuleCode, n448SYS_LogLogType, A448SYS_LogLogType, A378SYS_LogCreator, A379SYS_LogCreateTime});
                     A442SYS_LogLogID = BC001L6_A442SYS_LogLogID[0];
                     pr_datastore1.close(4);
                     dsDataStore1.SmartCacheProvider.SetUpdated("SYS_LOG") ;
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
               Load1L60( ) ;
            }
            EndLevel1L60( ) ;
         }
         CloseExtendedTableCursors1L60( ) ;
      }

      protected void Update1L60( )
      {
         BeforeValidate1L60( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1L60( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1L60( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1L60( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1L60( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC001L7 */
                     pr_datastore1.execute(5, new Object[] {n372SYS_LogTenantCode, A372SYS_LogTenantCode, A451SYS_LogTitle, n450SYS_LogContent, A450SYS_LogContent, n449SYS_LogClientIP, A449SYS_LogClientIP, n376SYS_LogModuleCode, A376SYS_LogModuleCode, n448SYS_LogLogType, A448SYS_LogLogType, A378SYS_LogCreator, A379SYS_LogCreateTime, A442SYS_LogLogID});
                     pr_datastore1.close(5);
                     dsDataStore1.SmartCacheProvider.SetUpdated("SYS_LOG") ;
                     if ( (pr_datastore1.getStatus(5) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SYS_LOG"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate1L60( ) ;
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
            EndLevel1L60( ) ;
         }
         CloseExtendedTableCursors1L60( ) ;
      }

      protected void DeferredUpdate1L60( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate1L60( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1L60( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1L60( ) ;
            AfterConfirm1L60( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1L60( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC001L8 */
                  pr_datastore1.execute(6, new Object[] {A442SYS_LogLogID});
                  pr_datastore1.close(6);
                  dsDataStore1.SmartCacheProvider.SetUpdated("SYS_LOG") ;
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
         sMode60 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel1L60( ) ;
         Gx_mode = sMode60;
      }

      protected void OnDeleteControls1L60( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel1L60( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_datastore1.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1L60( ) ;
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

      public void ScanKeyStart1L60( )
      {
         /* Using cursor BC001L9 */
         pr_datastore1.execute(7, new Object[] {A442SYS_LogLogID});
         RcdFound60 = 0;
         if ( (pr_datastore1.getStatus(7) != 101) )
         {
            RcdFound60 = 1;
            A442SYS_LogLogID = BC001L9_A442SYS_LogLogID[0];
            A372SYS_LogTenantCode = BC001L9_A372SYS_LogTenantCode[0];
            n372SYS_LogTenantCode = BC001L9_n372SYS_LogTenantCode[0];
            A451SYS_LogTitle = BC001L9_A451SYS_LogTitle[0];
            A450SYS_LogContent = BC001L9_A450SYS_LogContent[0];
            n450SYS_LogContent = BC001L9_n450SYS_LogContent[0];
            A449SYS_LogClientIP = BC001L9_A449SYS_LogClientIP[0];
            n449SYS_LogClientIP = BC001L9_n449SYS_LogClientIP[0];
            A376SYS_LogModuleCode = BC001L9_A376SYS_LogModuleCode[0];
            n376SYS_LogModuleCode = BC001L9_n376SYS_LogModuleCode[0];
            A448SYS_LogLogType = BC001L9_A448SYS_LogLogType[0];
            n448SYS_LogLogType = BC001L9_n448SYS_LogLogType[0];
            A378SYS_LogCreator = BC001L9_A378SYS_LogCreator[0];
            A379SYS_LogCreateTime = BC001L9_A379SYS_LogCreateTime[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext1L60( )
      {
         /* Scan next routine */
         pr_datastore1.readNext(7);
         RcdFound60 = 0;
         ScanKeyLoad1L60( ) ;
      }

      protected void ScanKeyLoad1L60( )
      {
         sMode60 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_datastore1.getStatus(7) != 101) )
         {
            RcdFound60 = 1;
            A442SYS_LogLogID = BC001L9_A442SYS_LogLogID[0];
            A372SYS_LogTenantCode = BC001L9_A372SYS_LogTenantCode[0];
            n372SYS_LogTenantCode = BC001L9_n372SYS_LogTenantCode[0];
            A451SYS_LogTitle = BC001L9_A451SYS_LogTitle[0];
            A450SYS_LogContent = BC001L9_A450SYS_LogContent[0];
            n450SYS_LogContent = BC001L9_n450SYS_LogContent[0];
            A449SYS_LogClientIP = BC001L9_A449SYS_LogClientIP[0];
            n449SYS_LogClientIP = BC001L9_n449SYS_LogClientIP[0];
            A376SYS_LogModuleCode = BC001L9_A376SYS_LogModuleCode[0];
            n376SYS_LogModuleCode = BC001L9_n376SYS_LogModuleCode[0];
            A448SYS_LogLogType = BC001L9_A448SYS_LogLogType[0];
            n448SYS_LogLogType = BC001L9_n448SYS_LogLogType[0];
            A378SYS_LogCreator = BC001L9_A378SYS_LogCreator[0];
            A379SYS_LogCreateTime = BC001L9_A379SYS_LogCreateTime[0];
         }
         Gx_mode = sMode60;
      }

      protected void ScanKeyEnd1L60( )
      {
         pr_datastore1.close(7);
      }

      protected void AfterConfirm1L60( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1L60( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1L60( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1L60( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1L60( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1L60( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1L60( )
      {
      }

      protected void send_integrity_lvl_hashes1L60( )
      {
      }

      protected void AddRow1L60( )
      {
         VarsToRow60( bcSYS_Log) ;
      }

      protected void ReadRow1L60( )
      {
         RowToVars60( bcSYS_Log, 1) ;
      }

      protected void InitializeNonKey1L60( )
      {
         A372SYS_LogTenantCode = "";
         n372SYS_LogTenantCode = false;
         A451SYS_LogTitle = "";
         A450SYS_LogContent = "";
         n450SYS_LogContent = false;
         A449SYS_LogClientIP = "";
         n449SYS_LogClientIP = false;
         A376SYS_LogModuleCode = "";
         n376SYS_LogModuleCode = false;
         A448SYS_LogLogType = "";
         n448SYS_LogLogType = false;
         A378SYS_LogCreator = "";
         A379SYS_LogCreateTime = (DateTime)(DateTime.MinValue);
         Z372SYS_LogTenantCode = "";
         Z451SYS_LogTitle = "";
         Z449SYS_LogClientIP = "";
         Z376SYS_LogModuleCode = "";
         Z448SYS_LogLogType = "";
         Z378SYS_LogCreator = "";
         Z379SYS_LogCreateTime = (DateTime)(DateTime.MinValue);
      }

      protected void InitAll1L60( )
      {
         A442SYS_LogLogID = 0;
         InitializeNonKey1L60( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow60( SdtSYS_Log obj60 )
      {
         obj60.gxTpr_Mode = Gx_mode;
         obj60.gxTpr_Sys_logtenantcode = A372SYS_LogTenantCode;
         obj60.gxTpr_Sys_logtitle = A451SYS_LogTitle;
         obj60.gxTpr_Sys_logcontent = A450SYS_LogContent;
         obj60.gxTpr_Sys_logclientip = A449SYS_LogClientIP;
         obj60.gxTpr_Sys_logmodulecode = A376SYS_LogModuleCode;
         obj60.gxTpr_Sys_loglogtype = A448SYS_LogLogType;
         obj60.gxTpr_Sys_logcreator = A378SYS_LogCreator;
         obj60.gxTpr_Sys_logcreatetime = A379SYS_LogCreateTime;
         obj60.gxTpr_Sys_loglogid = A442SYS_LogLogID;
         obj60.gxTpr_Sys_loglogid_Z = Z442SYS_LogLogID;
         obj60.gxTpr_Sys_logtenantcode_Z = Z372SYS_LogTenantCode;
         obj60.gxTpr_Sys_logtitle_Z = Z451SYS_LogTitle;
         obj60.gxTpr_Sys_logclientip_Z = Z449SYS_LogClientIP;
         obj60.gxTpr_Sys_logmodulecode_Z = Z376SYS_LogModuleCode;
         obj60.gxTpr_Sys_loglogtype_Z = Z448SYS_LogLogType;
         obj60.gxTpr_Sys_logcreator_Z = Z378SYS_LogCreator;
         obj60.gxTpr_Sys_logcreatetime_Z = Z379SYS_LogCreateTime;
         obj60.gxTpr_Sys_logtenantcode_N = (short)(Convert.ToInt16(n372SYS_LogTenantCode));
         obj60.gxTpr_Sys_logcontent_N = (short)(Convert.ToInt16(n450SYS_LogContent));
         obj60.gxTpr_Sys_logclientip_N = (short)(Convert.ToInt16(n449SYS_LogClientIP));
         obj60.gxTpr_Sys_logmodulecode_N = (short)(Convert.ToInt16(n376SYS_LogModuleCode));
         obj60.gxTpr_Sys_loglogtype_N = (short)(Convert.ToInt16(n448SYS_LogLogType));
         obj60.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow60( SdtSYS_Log obj60 )
      {
         obj60.gxTpr_Sys_loglogid = A442SYS_LogLogID;
         return  ;
      }

      public void RowToVars60( SdtSYS_Log obj60 ,
                               int forceLoad )
      {
         Gx_mode = obj60.gxTpr_Mode;
         A372SYS_LogTenantCode = obj60.gxTpr_Sys_logtenantcode;
         n372SYS_LogTenantCode = false;
         A451SYS_LogTitle = obj60.gxTpr_Sys_logtitle;
         A450SYS_LogContent = obj60.gxTpr_Sys_logcontent;
         n450SYS_LogContent = false;
         A449SYS_LogClientIP = obj60.gxTpr_Sys_logclientip;
         n449SYS_LogClientIP = false;
         A376SYS_LogModuleCode = obj60.gxTpr_Sys_logmodulecode;
         n376SYS_LogModuleCode = false;
         A448SYS_LogLogType = obj60.gxTpr_Sys_loglogtype;
         n448SYS_LogLogType = false;
         A378SYS_LogCreator = obj60.gxTpr_Sys_logcreator;
         A379SYS_LogCreateTime = obj60.gxTpr_Sys_logcreatetime;
         A442SYS_LogLogID = obj60.gxTpr_Sys_loglogid;
         Z442SYS_LogLogID = obj60.gxTpr_Sys_loglogid_Z;
         Z372SYS_LogTenantCode = obj60.gxTpr_Sys_logtenantcode_Z;
         Z451SYS_LogTitle = obj60.gxTpr_Sys_logtitle_Z;
         Z449SYS_LogClientIP = obj60.gxTpr_Sys_logclientip_Z;
         Z376SYS_LogModuleCode = obj60.gxTpr_Sys_logmodulecode_Z;
         Z448SYS_LogLogType = obj60.gxTpr_Sys_loglogtype_Z;
         Z378SYS_LogCreator = obj60.gxTpr_Sys_logcreator_Z;
         Z379SYS_LogCreateTime = obj60.gxTpr_Sys_logcreatetime_Z;
         n372SYS_LogTenantCode = (bool)(Convert.ToBoolean(obj60.gxTpr_Sys_logtenantcode_N));
         n450SYS_LogContent = (bool)(Convert.ToBoolean(obj60.gxTpr_Sys_logcontent_N));
         n449SYS_LogClientIP = (bool)(Convert.ToBoolean(obj60.gxTpr_Sys_logclientip_N));
         n376SYS_LogModuleCode = (bool)(Convert.ToBoolean(obj60.gxTpr_Sys_logmodulecode_N));
         n448SYS_LogLogType = (bool)(Convert.ToBoolean(obj60.gxTpr_Sys_loglogtype_N));
         Gx_mode = obj60.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A442SYS_LogLogID = (long)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey1L60( ) ;
         ScanKeyStart1L60( ) ;
         if ( RcdFound60 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z442SYS_LogLogID = A442SYS_LogLogID;
         }
         ZM1L60( -2) ;
         OnLoadActions1L60( ) ;
         AddRow1L60( ) ;
         ScanKeyEnd1L60( ) ;
         if ( RcdFound60 == 0 )
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
         RowToVars60( bcSYS_Log, 0) ;
         ScanKeyStart1L60( ) ;
         if ( RcdFound60 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z442SYS_LogLogID = A442SYS_LogLogID;
         }
         ZM1L60( -2) ;
         OnLoadActions1L60( ) ;
         AddRow1L60( ) ;
         ScanKeyEnd1L60( ) ;
         if ( RcdFound60 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey1L60( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert1L60( ) ;
         }
         else
         {
            if ( RcdFound60 == 1 )
            {
               if ( A442SYS_LogLogID != Z442SYS_LogLogID )
               {
                  A442SYS_LogLogID = Z442SYS_LogLogID;
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
                  Update1L60( ) ;
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
                  if ( A442SYS_LogLogID != Z442SYS_LogLogID )
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
                        Insert1L60( ) ;
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
                        Insert1L60( ) ;
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
         RowToVars60( bcSYS_Log, 0) ;
         SaveImpl( ) ;
         VarsToRow60( bcSYS_Log) ;
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
         RowToVars60( bcSYS_Log, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert1L60( ) ;
         AfterTrn( ) ;
         VarsToRow60( bcSYS_Log) ;
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
            SdtSYS_Log auxBC = new SdtSYS_Log(context) ;
            auxBC.Load(A442SYS_LogLogID);
            auxBC.UpdateDirties(bcSYS_Log);
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
         RowToVars60( bcSYS_Log, 0) ;
         UpdateImpl( ) ;
         VarsToRow60( bcSYS_Log) ;
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
         RowToVars60( bcSYS_Log, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert1L60( ) ;
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
         VarsToRow60( bcSYS_Log) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars60( bcSYS_Log, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey1L60( ) ;
         if ( RcdFound60 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A442SYS_LogLogID != Z442SYS_LogLogID )
            {
               A442SYS_LogLogID = Z442SYS_LogLogID;
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
            if ( A442SYS_LogLogID != Z442SYS_LogLogID )
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
         pr_datastore1.close(1);
         context.RollbackDataStores("sys_log_bc",pr_default);
         VarsToRow60( bcSYS_Log) ;
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
         Gx_mode = bcSYS_Log.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcSYS_Log.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcSYS_Log )
         {
            bcSYS_Log = (SdtSYS_Log)(sdt);
            if ( StringUtil.StrCmp(bcSYS_Log.gxTpr_Mode, "") == 0 )
            {
               bcSYS_Log.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow60( bcSYS_Log) ;
            }
            else
            {
               RowToVars60( bcSYS_Log, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcSYS_Log.gxTpr_Mode, "") == 0 )
            {
               bcSYS_Log.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars60( bcSYS_Log, 1) ;
         return  ;
      }

      public SdtSYS_Log SYS_Log_BC
      {
         get {
            return bcSYS_Log ;
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
         pr_datastore1.close(1);
      }

      public override void initialize( )
      {
         scmdbuf = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Gx_mode = "";
         Z372SYS_LogTenantCode = "";
         A372SYS_LogTenantCode = "";
         Z451SYS_LogTitle = "";
         A451SYS_LogTitle = "";
         Z449SYS_LogClientIP = "";
         A449SYS_LogClientIP = "";
         Z376SYS_LogModuleCode = "";
         A376SYS_LogModuleCode = "";
         Z448SYS_LogLogType = "";
         A448SYS_LogLogType = "";
         Z378SYS_LogCreator = "";
         A378SYS_LogCreator = "";
         Z379SYS_LogCreateTime = (DateTime)(DateTime.MinValue);
         A379SYS_LogCreateTime = (DateTime)(DateTime.MinValue);
         Z450SYS_LogContent = "";
         A450SYS_LogContent = "";
         BC001L4_A442SYS_LogLogID = new long[1] ;
         BC001L4_A372SYS_LogTenantCode = new String[] {""} ;
         BC001L4_n372SYS_LogTenantCode = new bool[] {false} ;
         BC001L4_A451SYS_LogTitle = new String[] {""} ;
         BC001L4_A450SYS_LogContent = new String[] {""} ;
         BC001L4_n450SYS_LogContent = new bool[] {false} ;
         BC001L4_A449SYS_LogClientIP = new String[] {""} ;
         BC001L4_n449SYS_LogClientIP = new bool[] {false} ;
         BC001L4_A376SYS_LogModuleCode = new String[] {""} ;
         BC001L4_n376SYS_LogModuleCode = new bool[] {false} ;
         BC001L4_A448SYS_LogLogType = new String[] {""} ;
         BC001L4_n448SYS_LogLogType = new bool[] {false} ;
         BC001L4_A378SYS_LogCreator = new String[] {""} ;
         BC001L4_A379SYS_LogCreateTime = new DateTime[] {DateTime.MinValue} ;
         BC001L5_A442SYS_LogLogID = new long[1] ;
         BC001L3_A442SYS_LogLogID = new long[1] ;
         BC001L3_A372SYS_LogTenantCode = new String[] {""} ;
         BC001L3_n372SYS_LogTenantCode = new bool[] {false} ;
         BC001L3_A451SYS_LogTitle = new String[] {""} ;
         BC001L3_A450SYS_LogContent = new String[] {""} ;
         BC001L3_n450SYS_LogContent = new bool[] {false} ;
         BC001L3_A449SYS_LogClientIP = new String[] {""} ;
         BC001L3_n449SYS_LogClientIP = new bool[] {false} ;
         BC001L3_A376SYS_LogModuleCode = new String[] {""} ;
         BC001L3_n376SYS_LogModuleCode = new bool[] {false} ;
         BC001L3_A448SYS_LogLogType = new String[] {""} ;
         BC001L3_n448SYS_LogLogType = new bool[] {false} ;
         BC001L3_A378SYS_LogCreator = new String[] {""} ;
         BC001L3_A379SYS_LogCreateTime = new DateTime[] {DateTime.MinValue} ;
         sMode60 = "";
         BC001L2_A442SYS_LogLogID = new long[1] ;
         BC001L2_A372SYS_LogTenantCode = new String[] {""} ;
         BC001L2_n372SYS_LogTenantCode = new bool[] {false} ;
         BC001L2_A451SYS_LogTitle = new String[] {""} ;
         BC001L2_A450SYS_LogContent = new String[] {""} ;
         BC001L2_n450SYS_LogContent = new bool[] {false} ;
         BC001L2_A449SYS_LogClientIP = new String[] {""} ;
         BC001L2_n449SYS_LogClientIP = new bool[] {false} ;
         BC001L2_A376SYS_LogModuleCode = new String[] {""} ;
         BC001L2_n376SYS_LogModuleCode = new bool[] {false} ;
         BC001L2_A448SYS_LogLogType = new String[] {""} ;
         BC001L2_n448SYS_LogLogType = new bool[] {false} ;
         BC001L2_A378SYS_LogCreator = new String[] {""} ;
         BC001L2_A379SYS_LogCreateTime = new DateTime[] {DateTime.MinValue} ;
         BC001L6_A442SYS_LogLogID = new long[1] ;
         BC001L9_A442SYS_LogLogID = new long[1] ;
         BC001L9_A372SYS_LogTenantCode = new String[] {""} ;
         BC001L9_n372SYS_LogTenantCode = new bool[] {false} ;
         BC001L9_A451SYS_LogTitle = new String[] {""} ;
         BC001L9_A450SYS_LogContent = new String[] {""} ;
         BC001L9_n450SYS_LogContent = new bool[] {false} ;
         BC001L9_A449SYS_LogClientIP = new String[] {""} ;
         BC001L9_n449SYS_LogClientIP = new bool[] {false} ;
         BC001L9_A376SYS_LogModuleCode = new String[] {""} ;
         BC001L9_n376SYS_LogModuleCode = new bool[] {false} ;
         BC001L9_A448SYS_LogLogType = new String[] {""} ;
         BC001L9_n448SYS_LogLogType = new bool[] {false} ;
         BC001L9_A378SYS_LogCreator = new String[] {""} ;
         BC001L9_A379SYS_LogCreateTime = new DateTime[] {DateTime.MinValue} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.sys_log_bc__datastore1(),
            new Object[][] {
                new Object[] {
               BC001L2_A442SYS_LogLogID, BC001L2_A372SYS_LogTenantCode, BC001L2_n372SYS_LogTenantCode, BC001L2_A451SYS_LogTitle, BC001L2_A450SYS_LogContent, BC001L2_n450SYS_LogContent, BC001L2_A449SYS_LogClientIP, BC001L2_n449SYS_LogClientIP, BC001L2_A376SYS_LogModuleCode, BC001L2_n376SYS_LogModuleCode,
               BC001L2_A448SYS_LogLogType, BC001L2_n448SYS_LogLogType, BC001L2_A378SYS_LogCreator, BC001L2_A379SYS_LogCreateTime
               }
               , new Object[] {
               BC001L3_A442SYS_LogLogID, BC001L3_A372SYS_LogTenantCode, BC001L3_n372SYS_LogTenantCode, BC001L3_A451SYS_LogTitle, BC001L3_A450SYS_LogContent, BC001L3_n450SYS_LogContent, BC001L3_A449SYS_LogClientIP, BC001L3_n449SYS_LogClientIP, BC001L3_A376SYS_LogModuleCode, BC001L3_n376SYS_LogModuleCode,
               BC001L3_A448SYS_LogLogType, BC001L3_n448SYS_LogLogType, BC001L3_A378SYS_LogCreator, BC001L3_A379SYS_LogCreateTime
               }
               , new Object[] {
               BC001L4_A442SYS_LogLogID, BC001L4_A372SYS_LogTenantCode, BC001L4_n372SYS_LogTenantCode, BC001L4_A451SYS_LogTitle, BC001L4_A450SYS_LogContent, BC001L4_n450SYS_LogContent, BC001L4_A449SYS_LogClientIP, BC001L4_n449SYS_LogClientIP, BC001L4_A376SYS_LogModuleCode, BC001L4_n376SYS_LogModuleCode,
               BC001L4_A448SYS_LogLogType, BC001L4_n448SYS_LogLogType, BC001L4_A378SYS_LogCreator, BC001L4_A379SYS_LogCreateTime
               }
               , new Object[] {
               BC001L5_A442SYS_LogLogID
               }
               , new Object[] {
               BC001L6_A442SYS_LogLogID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC001L9_A442SYS_LogLogID, BC001L9_A372SYS_LogTenantCode, BC001L9_n372SYS_LogTenantCode, BC001L9_A451SYS_LogTitle, BC001L9_A450SYS_LogContent, BC001L9_n450SYS_LogContent, BC001L9_A449SYS_LogClientIP, BC001L9_n449SYS_LogClientIP, BC001L9_A376SYS_LogModuleCode, BC001L9_n376SYS_LogModuleCode,
               BC001L9_A448SYS_LogLogType, BC001L9_n448SYS_LogLogType, BC001L9_A378SYS_LogCreator, BC001L9_A379SYS_LogCreateTime
               }
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.sys_log_bc__default(),
            new Object[][] {
            }
         );
         INITTRN();
         /* Execute Start event if defined. */
         standaloneNotModal( ) ;
      }

      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short GX_JID ;
      private short RcdFound60 ;
      private int trnEnded ;
      private long Z442SYS_LogLogID ;
      private long A442SYS_LogLogID ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String sMode60 ;
      private DateTime Z379SYS_LogCreateTime ;
      private DateTime A379SYS_LogCreateTime ;
      private bool n372SYS_LogTenantCode ;
      private bool n450SYS_LogContent ;
      private bool n449SYS_LogClientIP ;
      private bool n376SYS_LogModuleCode ;
      private bool n448SYS_LogLogType ;
      private bool Gx_longc ;
      private String Z450SYS_LogContent ;
      private String A450SYS_LogContent ;
      private String Z372SYS_LogTenantCode ;
      private String A372SYS_LogTenantCode ;
      private String Z451SYS_LogTitle ;
      private String A451SYS_LogTitle ;
      private String Z449SYS_LogClientIP ;
      private String A449SYS_LogClientIP ;
      private String Z376SYS_LogModuleCode ;
      private String A376SYS_LogModuleCode ;
      private String Z448SYS_LogLogType ;
      private String A448SYS_LogLogType ;
      private String Z378SYS_LogCreator ;
      private String A378SYS_LogCreator ;
      private SdtSYS_Log bcSYS_Log ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_datastore1 ;
      private long[] BC001L4_A442SYS_LogLogID ;
      private String[] BC001L4_A372SYS_LogTenantCode ;
      private bool[] BC001L4_n372SYS_LogTenantCode ;
      private String[] BC001L4_A451SYS_LogTitle ;
      private String[] BC001L4_A450SYS_LogContent ;
      private bool[] BC001L4_n450SYS_LogContent ;
      private String[] BC001L4_A449SYS_LogClientIP ;
      private bool[] BC001L4_n449SYS_LogClientIP ;
      private String[] BC001L4_A376SYS_LogModuleCode ;
      private bool[] BC001L4_n376SYS_LogModuleCode ;
      private String[] BC001L4_A448SYS_LogLogType ;
      private bool[] BC001L4_n448SYS_LogLogType ;
      private String[] BC001L4_A378SYS_LogCreator ;
      private DateTime[] BC001L4_A379SYS_LogCreateTime ;
      private long[] BC001L5_A442SYS_LogLogID ;
      private long[] BC001L3_A442SYS_LogLogID ;
      private String[] BC001L3_A372SYS_LogTenantCode ;
      private bool[] BC001L3_n372SYS_LogTenantCode ;
      private String[] BC001L3_A451SYS_LogTitle ;
      private String[] BC001L3_A450SYS_LogContent ;
      private bool[] BC001L3_n450SYS_LogContent ;
      private String[] BC001L3_A449SYS_LogClientIP ;
      private bool[] BC001L3_n449SYS_LogClientIP ;
      private String[] BC001L3_A376SYS_LogModuleCode ;
      private bool[] BC001L3_n376SYS_LogModuleCode ;
      private String[] BC001L3_A448SYS_LogLogType ;
      private bool[] BC001L3_n448SYS_LogLogType ;
      private String[] BC001L3_A378SYS_LogCreator ;
      private DateTime[] BC001L3_A379SYS_LogCreateTime ;
      private long[] BC001L2_A442SYS_LogLogID ;
      private String[] BC001L2_A372SYS_LogTenantCode ;
      private bool[] BC001L2_n372SYS_LogTenantCode ;
      private String[] BC001L2_A451SYS_LogTitle ;
      private String[] BC001L2_A450SYS_LogContent ;
      private bool[] BC001L2_n450SYS_LogContent ;
      private String[] BC001L2_A449SYS_LogClientIP ;
      private bool[] BC001L2_n449SYS_LogClientIP ;
      private String[] BC001L2_A376SYS_LogModuleCode ;
      private bool[] BC001L2_n376SYS_LogModuleCode ;
      private String[] BC001L2_A448SYS_LogLogType ;
      private bool[] BC001L2_n448SYS_LogLogType ;
      private String[] BC001L2_A378SYS_LogCreator ;
      private DateTime[] BC001L2_A379SYS_LogCreateTime ;
      private long[] BC001L6_A442SYS_LogLogID ;
      private long[] BC001L9_A442SYS_LogLogID ;
      private String[] BC001L9_A372SYS_LogTenantCode ;
      private bool[] BC001L9_n372SYS_LogTenantCode ;
      private String[] BC001L9_A451SYS_LogTitle ;
      private String[] BC001L9_A450SYS_LogContent ;
      private bool[] BC001L9_n450SYS_LogContent ;
      private String[] BC001L9_A449SYS_LogClientIP ;
      private bool[] BC001L9_n449SYS_LogClientIP ;
      private String[] BC001L9_A376SYS_LogModuleCode ;
      private bool[] BC001L9_n376SYS_LogModuleCode ;
      private String[] BC001L9_A448SYS_LogLogType ;
      private bool[] BC001L9_n448SYS_LogLogType ;
      private String[] BC001L9_A378SYS_LogCreator ;
      private DateTime[] BC001L9_A379SYS_LogCreateTime ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_default ;
   }

   public class sys_log_bc__datastore1 : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmBC001L4 ;
          prmBC001L4 = new Object[] {
          new Object[] {"@SYS_LogLogID",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmBC001L5 ;
          prmBC001L5 = new Object[] {
          new Object[] {"@SYS_LogLogID",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmBC001L3 ;
          prmBC001L3 = new Object[] {
          new Object[] {"@SYS_LogLogID",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmBC001L2 ;
          prmBC001L2 = new Object[] {
          new Object[] {"@SYS_LogLogID",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmBC001L6 ;
          prmBC001L6 = new Object[] {
          new Object[] {"@SYS_LogTenantCode",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@SYS_LogTitle",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@SYS_LogContent",SqlDbType.NVarChar,2048,0} ,
          new Object[] {"@SYS_LogClientIP",SqlDbType.NVarChar,15,0} ,
          new Object[] {"@SYS_LogModuleCode",SqlDbType.NVarChar,30,0} ,
          new Object[] {"@SYS_LogLogType",SqlDbType.NVarChar,30,0} ,
          new Object[] {"@SYS_LogCreator",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@SYS_LogCreateTime",SqlDbType.DateTime,10,8}
          } ;
          Object[] prmBC001L7 ;
          prmBC001L7 = new Object[] {
          new Object[] {"@SYS_LogTenantCode",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@SYS_LogTitle",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@SYS_LogContent",SqlDbType.NVarChar,2048,0} ,
          new Object[] {"@SYS_LogClientIP",SqlDbType.NVarChar,15,0} ,
          new Object[] {"@SYS_LogModuleCode",SqlDbType.NVarChar,30,0} ,
          new Object[] {"@SYS_LogLogType",SqlDbType.NVarChar,30,0} ,
          new Object[] {"@SYS_LogCreator",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@SYS_LogCreateTime",SqlDbType.DateTime,10,8} ,
          new Object[] {"@SYS_LogLogID",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmBC001L8 ;
          prmBC001L8 = new Object[] {
          new Object[] {"@SYS_LogLogID",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmBC001L9 ;
          prmBC001L9 = new Object[] {
          new Object[] {"@SYS_LogLogID",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("BC001L2", "SELECT [LogID], [TenantCode], [Title], [Content], [ClientIP], [ModuleCode], [LogType], [Creator], [CreateTime] FROM dbo.[SYS_Log] WITH (UPDLOCK) WHERE [LogID] = @SYS_LogLogID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001L2,1,0,true,false )
             ,new CursorDef("BC001L3", "SELECT [LogID], [TenantCode], [Title], [Content], [ClientIP], [ModuleCode], [LogType], [Creator], [CreateTime] FROM dbo.[SYS_Log] WITH (NOLOCK) WHERE [LogID] = @SYS_LogLogID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001L3,1,0,true,false )
             ,new CursorDef("BC001L4", "SELECT TM1.[LogID], TM1.[TenantCode], TM1.[Title], TM1.[Content], TM1.[ClientIP], TM1.[ModuleCode], TM1.[LogType], TM1.[Creator], TM1.[CreateTime] FROM dbo.[SYS_Log] TM1 WITH (NOLOCK) WHERE TM1.[LogID] = @SYS_LogLogID ORDER BY TM1.[LogID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001L4,100,0,true,false )
             ,new CursorDef("BC001L5", "SELECT [LogID] FROM dbo.[SYS_Log] WITH (NOLOCK) WHERE [LogID] = @SYS_LogLogID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001L5,1,0,true,false )
             ,new CursorDef("BC001L6", "INSERT INTO dbo.[SYS_Log]([TenantCode], [Title], [Content], [ClientIP], [ModuleCode], [LogType], [Creator], [CreateTime]) VALUES(@SYS_LogTenantCode, @SYS_LogTitle, @SYS_LogContent, @SYS_LogClientIP, @SYS_LogModuleCode, @SYS_LogLogType, @SYS_LogCreator, @SYS_LogCreateTime); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmBC001L6)
             ,new CursorDef("BC001L7", "UPDATE dbo.[SYS_Log] SET [TenantCode]=@SYS_LogTenantCode, [Title]=@SYS_LogTitle, [Content]=@SYS_LogContent, [ClientIP]=@SYS_LogClientIP, [ModuleCode]=@SYS_LogModuleCode, [LogType]=@SYS_LogLogType, [Creator]=@SYS_LogCreator, [CreateTime]=@SYS_LogCreateTime  WHERE [LogID] = @SYS_LogLogID", GxErrorMask.GX_NOMASK,prmBC001L7)
             ,new CursorDef("BC001L8", "DELETE FROM dbo.[SYS_Log]  WHERE [LogID] = @SYS_LogLogID", GxErrorMask.GX_NOMASK,prmBC001L8)
             ,new CursorDef("BC001L9", "SELECT TM1.[LogID], TM1.[TenantCode], TM1.[Title], TM1.[Content], TM1.[ClientIP], TM1.[ModuleCode], TM1.[LogType], TM1.[Creator], TM1.[CreateTime] FROM dbo.[SYS_Log] TM1 WITH (NOLOCK) WHERE TM1.[LogID] = @SYS_LogLogID ORDER BY TM1.[LogID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001L9,100,0,true,false )
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
                ((String[]) buf[4])[0] = rslt.getLongVarchar(4) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((String[]) buf[6])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(5);
                ((String[]) buf[8])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(6);
                ((String[]) buf[10])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(7);
                ((String[]) buf[12])[0] = rslt.getVarchar(8) ;
                ((DateTime[]) buf[13])[0] = rslt.getGXDateTime(9) ;
                return;
             case 1 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[4])[0] = rslt.getLongVarchar(4) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((String[]) buf[6])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(5);
                ((String[]) buf[8])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(6);
                ((String[]) buf[10])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(7);
                ((String[]) buf[12])[0] = rslt.getVarchar(8) ;
                ((DateTime[]) buf[13])[0] = rslt.getGXDateTime(9) ;
                return;
             case 2 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[4])[0] = rslt.getLongVarchar(4) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((String[]) buf[6])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(5);
                ((String[]) buf[8])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(6);
                ((String[]) buf[10])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(7);
                ((String[]) buf[12])[0] = rslt.getVarchar(8) ;
                ((DateTime[]) buf[13])[0] = rslt.getGXDateTime(9) ;
                return;
             case 3 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                return;
             case 4 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                return;
             case 7 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[4])[0] = rslt.getLongVarchar(4) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((String[]) buf[6])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(5);
                ((String[]) buf[8])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(6);
                ((String[]) buf[10])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(7);
                ((String[]) buf[12])[0] = rslt.getVarchar(8) ;
                ((DateTime[]) buf[13])[0] = rslt.getGXDateTime(9) ;
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
                   stmt.setNull( 1 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                stmt.SetParameter(2, (String)parms[2]);
                if ( (bool)parms[3] )
                {
                   stmt.setNull( 3 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(3, (String)parms[4]);
                }
                if ( (bool)parms[5] )
                {
                   stmt.setNull( 4 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(4, (String)parms[6]);
                }
                if ( (bool)parms[7] )
                {
                   stmt.setNull( 5 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(5, (String)parms[8]);
                }
                if ( (bool)parms[9] )
                {
                   stmt.setNull( 6 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(6, (String)parms[10]);
                }
                stmt.SetParameter(7, (String)parms[11]);
                stmt.SetParameterDatetime(8, (DateTime)parms[12]);
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
                stmt.SetParameter(2, (String)parms[2]);
                if ( (bool)parms[3] )
                {
                   stmt.setNull( 3 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(3, (String)parms[4]);
                }
                if ( (bool)parms[5] )
                {
                   stmt.setNull( 4 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(4, (String)parms[6]);
                }
                if ( (bool)parms[7] )
                {
                   stmt.setNull( 5 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(5, (String)parms[8]);
                }
                if ( (bool)parms[9] )
                {
                   stmt.setNull( 6 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(6, (String)parms[10]);
                }
                stmt.SetParameter(7, (String)parms[11]);
                stmt.SetParameterDatetime(8, (DateTime)parms[12]);
                stmt.SetParameter(9, (long)parms[13]);
                return;
             case 6 :
                stmt.SetParameter(1, (long)parms[0]);
                return;
             case 7 :
                stmt.SetParameter(1, (long)parms[0]);
                return;
       }
    }

    public String getDataStoreName( )
    {
       return "DATASTORE1";
    }

 }

 public class sys_log_bc__default : DataStoreHelperBase, IDataStoreHelper
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

}

}
