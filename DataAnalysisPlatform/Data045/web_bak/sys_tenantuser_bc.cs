/*
               File: SYS_TenantUser_BC
        Description: SYS_Tenant User
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:38:50.68
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
   public class sys_tenantuser_bc : GXHttpHandler, IGxSilentTrn
   {
      public sys_tenantuser_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public sys_tenantuser_bc( IGxContext context )
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
         ReadRow1845( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey1845( ) ;
         standaloneModal( ) ;
         AddRow1845( ) ;
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
               Z360BAS_TenantTenantCode = A360BAS_TenantTenantCode;
               Z359UserID = (Guid)(A359UserID);
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

      protected void CONFIRM_180( )
      {
         BeforeValidate1845( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls1845( ) ;
            }
            else
            {
               CheckExtendedTable1845( ) ;
               if ( AnyError == 0 )
               {
                  ZM1845( 3) ;
                  ZM1845( 4) ;
               }
               CloseExtendedTableCursors1845( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void ZM1845( short GX_JID )
      {
         if ( ( GX_JID == 2 ) || ( GX_JID == 0 ) )
         {
         }
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
         }
         if ( ( GX_JID == 4 ) || ( GX_JID == 0 ) )
         {
         }
         if ( GX_JID == -2 )
         {
            Z360BAS_TenantTenantCode = A360BAS_TenantTenantCode;
            Z359UserID = (Guid)(A359UserID);
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load1845( )
      {
         /* Using cursor BC00186 */
         pr_datastore1.execute(4, new Object[] {A360BAS_TenantTenantCode, A359UserID});
         if ( (pr_datastore1.getStatus(4) != 101) )
         {
            RcdFound45 = 1;
            ZM1845( -2) ;
         }
         pr_datastore1.close(4);
         OnLoadActions1845( ) ;
      }

      protected void OnLoadActions1845( )
      {
      }

      protected void CheckExtendedTable1845( )
      {
         standaloneModal( ) ;
         /* Using cursor BC00184 */
         pr_datastore1.execute(2, new Object[] {A360BAS_TenantTenantCode});
         if ( (pr_datastore1.getStatus(2) == 101) )
         {
            GX_msglist.addItem("不匹配'BAS_Tenant'", "ForeignKeyNotFound", 1, "BAS_TENANTTENANTCODE");
            AnyError = 1;
         }
         pr_datastore1.close(2);
         /* Using cursor BC00185 */
         pr_datastore1.execute(3, new Object[] {A359UserID});
         if ( (pr_datastore1.getStatus(3) == 101) )
         {
            GX_msglist.addItem("不匹配'SYS_User'", "ForeignKeyNotFound", 1, "USERID");
            AnyError = 1;
         }
         pr_datastore1.close(3);
      }

      protected void CloseExtendedTableCursors1845( )
      {
         pr_datastore1.close(2);
         pr_datastore1.close(3);
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey1845( )
      {
         /* Using cursor BC00187 */
         pr_datastore1.execute(5, new Object[] {A360BAS_TenantTenantCode, A359UserID});
         if ( (pr_datastore1.getStatus(5) != 101) )
         {
            RcdFound45 = 1;
         }
         else
         {
            RcdFound45 = 0;
         }
         pr_datastore1.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC00183 */
         pr_datastore1.execute(1, new Object[] {A360BAS_TenantTenantCode, A359UserID});
         if ( (pr_datastore1.getStatus(1) != 101) )
         {
            ZM1845( 2) ;
            RcdFound45 = 1;
            A360BAS_TenantTenantCode = BC00183_A360BAS_TenantTenantCode[0];
            A359UserID = (Guid)((Guid)(BC00183_A359UserID[0]));
            Z360BAS_TenantTenantCode = A360BAS_TenantTenantCode;
            Z359UserID = (Guid)(A359UserID);
            sMode45 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load1845( ) ;
            if ( AnyError == 1 )
            {
               RcdFound45 = 0;
               InitializeNonKey1845( ) ;
            }
            Gx_mode = sMode45;
         }
         else
         {
            RcdFound45 = 0;
            InitializeNonKey1845( ) ;
            sMode45 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode45;
         }
         pr_datastore1.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1845( ) ;
         if ( RcdFound45 == 0 )
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
         CONFIRM_180( ) ;
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

      protected void CheckOptimisticConcurrency1845( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC00182 */
            pr_datastore1.execute(0, new Object[] {A360BAS_TenantTenantCode, A359UserID});
            if ( (pr_datastore1.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SYS_TENANTUSER"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_datastore1.getStatus(0) == 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"SYS_TENANTUSER"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert1845( )
      {
         BeforeValidate1845( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1845( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1845( 0) ;
            CheckOptimisticConcurrency1845( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1845( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1845( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00188 */
                     pr_datastore1.execute(6, new Object[] {A360BAS_TenantTenantCode, A359UserID});
                     pr_datastore1.close(6);
                     dsDataStore1.SmartCacheProvider.SetUpdated("SYS_TENANTUSER") ;
                     if ( (pr_datastore1.getStatus(6) == 1) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
                        AnyError = 1;
                     }
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
               Load1845( ) ;
            }
            EndLevel1845( ) ;
         }
         CloseExtendedTableCursors1845( ) ;
      }

      protected void Update1845( )
      {
         BeforeValidate1845( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1845( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1845( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1845( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1845( ) ;
                  if ( AnyError == 0 )
                  {
                     /* No attributes to update on table dbo.[SYS_TenantUser] */
                     DeferredUpdate1845( ) ;
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
            EndLevel1845( ) ;
         }
         CloseExtendedTableCursors1845( ) ;
      }

      protected void DeferredUpdate1845( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate1845( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1845( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1845( ) ;
            AfterConfirm1845( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1845( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC00189 */
                  pr_datastore1.execute(7, new Object[] {A360BAS_TenantTenantCode, A359UserID});
                  pr_datastore1.close(7);
                  dsDataStore1.SmartCacheProvider.SetUpdated("SYS_TENANTUSER") ;
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
         sMode45 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel1845( ) ;
         Gx_mode = sMode45;
      }

      protected void OnDeleteControls1845( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel1845( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_datastore1.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1845( ) ;
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

      public void ScanKeyStart1845( )
      {
         /* Using cursor BC001810 */
         pr_datastore1.execute(8, new Object[] {A360BAS_TenantTenantCode, A359UserID});
         RcdFound45 = 0;
         if ( (pr_datastore1.getStatus(8) != 101) )
         {
            RcdFound45 = 1;
            A360BAS_TenantTenantCode = BC001810_A360BAS_TenantTenantCode[0];
            A359UserID = (Guid)((Guid)(BC001810_A359UserID[0]));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext1845( )
      {
         /* Scan next routine */
         pr_datastore1.readNext(8);
         RcdFound45 = 0;
         ScanKeyLoad1845( ) ;
      }

      protected void ScanKeyLoad1845( )
      {
         sMode45 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_datastore1.getStatus(8) != 101) )
         {
            RcdFound45 = 1;
            A360BAS_TenantTenantCode = BC001810_A360BAS_TenantTenantCode[0];
            A359UserID = (Guid)((Guid)(BC001810_A359UserID[0]));
         }
         Gx_mode = sMode45;
      }

      protected void ScanKeyEnd1845( )
      {
         pr_datastore1.close(8);
      }

      protected void AfterConfirm1845( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1845( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1845( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1845( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1845( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1845( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1845( )
      {
      }

      protected void send_integrity_lvl_hashes1845( )
      {
      }

      protected void AddRow1845( )
      {
         VarsToRow45( bcSYS_TenantUser) ;
      }

      protected void ReadRow1845( )
      {
         RowToVars45( bcSYS_TenantUser, 1) ;
      }

      protected void InitializeNonKey1845( )
      {
      }

      protected void InitAll1845( )
      {
         A360BAS_TenantTenantCode = "";
         A359UserID = (Guid)(Guid.Empty);
         InitializeNonKey1845( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow45( SdtSYS_TenantUser obj45 )
      {
         obj45.gxTpr_Mode = Gx_mode;
         obj45.gxTpr_Bas_tenanttenantcode = A360BAS_TenantTenantCode;
         obj45.gxTpr_Userid = (Guid)(A359UserID);
         obj45.gxTpr_Bas_tenanttenantcode_Z = Z360BAS_TenantTenantCode;
         obj45.gxTpr_Userid_Z = (Guid)(Z359UserID);
         obj45.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow45( SdtSYS_TenantUser obj45 )
      {
         obj45.gxTpr_Bas_tenanttenantcode = A360BAS_TenantTenantCode;
         obj45.gxTpr_Userid = (Guid)(A359UserID);
         return  ;
      }

      public void RowToVars45( SdtSYS_TenantUser obj45 ,
                               int forceLoad )
      {
         Gx_mode = obj45.gxTpr_Mode;
         A360BAS_TenantTenantCode = obj45.gxTpr_Bas_tenanttenantcode;
         A359UserID = (Guid)(obj45.gxTpr_Userid);
         Z360BAS_TenantTenantCode = obj45.gxTpr_Bas_tenanttenantcode_Z;
         Z359UserID = (Guid)(obj45.gxTpr_Userid_Z);
         Gx_mode = obj45.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A360BAS_TenantTenantCode = (String)getParm(obj,0);
         A359UserID = (Guid)((Guid)getParm(obj,1));
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey1845( ) ;
         ScanKeyStart1845( ) ;
         if ( RcdFound45 == 0 )
         {
            Gx_mode = "INS";
            /* Using cursor BC001811 */
            pr_datastore1.execute(9, new Object[] {A360BAS_TenantTenantCode});
            if ( (pr_datastore1.getStatus(9) == 101) )
            {
               GX_msglist.addItem("不匹配'BAS_Tenant'", "ForeignKeyNotFound", 1, "BAS_TENANTTENANTCODE");
               AnyError = 1;
            }
            pr_datastore1.close(9);
            /* Using cursor BC001812 */
            pr_datastore1.execute(10, new Object[] {A359UserID});
            if ( (pr_datastore1.getStatus(10) == 101) )
            {
               GX_msglist.addItem("不匹配'SYS_User'", "ForeignKeyNotFound", 1, "USERID");
               AnyError = 1;
            }
            pr_datastore1.close(10);
         }
         else
         {
            Gx_mode = "UPD";
            Z360BAS_TenantTenantCode = A360BAS_TenantTenantCode;
            Z359UserID = (Guid)(A359UserID);
         }
         ZM1845( -2) ;
         OnLoadActions1845( ) ;
         AddRow1845( ) ;
         ScanKeyEnd1845( ) ;
         if ( RcdFound45 == 0 )
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
         RowToVars45( bcSYS_TenantUser, 0) ;
         ScanKeyStart1845( ) ;
         if ( RcdFound45 == 0 )
         {
            Gx_mode = "INS";
            /* Using cursor BC001811 */
            pr_datastore1.execute(9, new Object[] {A360BAS_TenantTenantCode});
            if ( (pr_datastore1.getStatus(9) == 101) )
            {
               GX_msglist.addItem("不匹配'BAS_Tenant'", "ForeignKeyNotFound", 1, "BAS_TENANTTENANTCODE");
               AnyError = 1;
            }
            pr_datastore1.close(9);
            /* Using cursor BC001812 */
            pr_datastore1.execute(10, new Object[] {A359UserID});
            if ( (pr_datastore1.getStatus(10) == 101) )
            {
               GX_msglist.addItem("不匹配'SYS_User'", "ForeignKeyNotFound", 1, "USERID");
               AnyError = 1;
            }
            pr_datastore1.close(10);
         }
         else
         {
            Gx_mode = "UPD";
            Z360BAS_TenantTenantCode = A360BAS_TenantTenantCode;
            Z359UserID = (Guid)(A359UserID);
         }
         ZM1845( -2) ;
         OnLoadActions1845( ) ;
         AddRow1845( ) ;
         ScanKeyEnd1845( ) ;
         if ( RcdFound45 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey1845( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert1845( ) ;
         }
         else
         {
            if ( RcdFound45 == 1 )
            {
               if ( ( StringUtil.StrCmp(A360BAS_TenantTenantCode, Z360BAS_TenantTenantCode) != 0 ) || ( A359UserID != Z359UserID ) )
               {
                  A360BAS_TenantTenantCode = Z360BAS_TenantTenantCode;
                  A359UserID = (Guid)(Z359UserID);
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
                  Update1845( ) ;
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
                  if ( ( StringUtil.StrCmp(A360BAS_TenantTenantCode, Z360BAS_TenantTenantCode) != 0 ) || ( A359UserID != Z359UserID ) )
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
                        Insert1845( ) ;
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
                        Insert1845( ) ;
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
         RowToVars45( bcSYS_TenantUser, 0) ;
         SaveImpl( ) ;
         VarsToRow45( bcSYS_TenantUser) ;
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
         RowToVars45( bcSYS_TenantUser, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert1845( ) ;
         AfterTrn( ) ;
         VarsToRow45( bcSYS_TenantUser) ;
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
            SdtSYS_TenantUser auxBC = new SdtSYS_TenantUser(context) ;
            auxBC.Load(A360BAS_TenantTenantCode, A359UserID);
            auxBC.UpdateDirties(bcSYS_TenantUser);
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
         RowToVars45( bcSYS_TenantUser, 0) ;
         UpdateImpl( ) ;
         VarsToRow45( bcSYS_TenantUser) ;
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
         RowToVars45( bcSYS_TenantUser, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert1845( ) ;
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
         VarsToRow45( bcSYS_TenantUser) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars45( bcSYS_TenantUser, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey1845( ) ;
         if ( RcdFound45 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( ( StringUtil.StrCmp(A360BAS_TenantTenantCode, Z360BAS_TenantTenantCode) != 0 ) || ( A359UserID != Z359UserID ) )
            {
               A360BAS_TenantTenantCode = Z360BAS_TenantTenantCode;
               A359UserID = (Guid)(Z359UserID);
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
            if ( ( StringUtil.StrCmp(A360BAS_TenantTenantCode, Z360BAS_TenantTenantCode) != 0 ) || ( A359UserID != Z359UserID ) )
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
         pr_datastore1.close(9);
         pr_datastore1.close(10);
         context.RollbackDataStores("sys_tenantuser_bc",pr_default);
         VarsToRow45( bcSYS_TenantUser) ;
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
         Gx_mode = bcSYS_TenantUser.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcSYS_TenantUser.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcSYS_TenantUser )
         {
            bcSYS_TenantUser = (SdtSYS_TenantUser)(sdt);
            if ( StringUtil.StrCmp(bcSYS_TenantUser.gxTpr_Mode, "") == 0 )
            {
               bcSYS_TenantUser.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow45( bcSYS_TenantUser) ;
            }
            else
            {
               RowToVars45( bcSYS_TenantUser, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcSYS_TenantUser.gxTpr_Mode, "") == 0 )
            {
               bcSYS_TenantUser.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars45( bcSYS_TenantUser, 1) ;
         return  ;
      }

      public SdtSYS_TenantUser SYS_TenantUser_BC
      {
         get {
            return bcSYS_TenantUser ;
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
         pr_datastore1.close(9);
         pr_datastore1.close(10);
      }

      public override void initialize( )
      {
         scmdbuf = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Gx_mode = "";
         Z360BAS_TenantTenantCode = "";
         A360BAS_TenantTenantCode = "";
         Z359UserID = (Guid)(Guid.Empty);
         A359UserID = (Guid)(Guid.Empty);
         BC00186_A360BAS_TenantTenantCode = new String[] {""} ;
         BC00186_A359UserID = new Guid[] {Guid.Empty} ;
         BC00184_A360BAS_TenantTenantCode = new String[] {""} ;
         BC00185_A359UserID = new Guid[] {Guid.Empty} ;
         BC00187_A360BAS_TenantTenantCode = new String[] {""} ;
         BC00187_A359UserID = new Guid[] {Guid.Empty} ;
         BC00183_A360BAS_TenantTenantCode = new String[] {""} ;
         BC00183_A359UserID = new Guid[] {Guid.Empty} ;
         sMode45 = "";
         BC00182_A360BAS_TenantTenantCode = new String[] {""} ;
         BC00182_A359UserID = new Guid[] {Guid.Empty} ;
         BC001810_A360BAS_TenantTenantCode = new String[] {""} ;
         BC001810_A359UserID = new Guid[] {Guid.Empty} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         BC001811_A360BAS_TenantTenantCode = new String[] {""} ;
         BC001812_A359UserID = new Guid[] {Guid.Empty} ;
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.sys_tenantuser_bc__datastore1(),
            new Object[][] {
                new Object[] {
               BC00182_A360BAS_TenantTenantCode, BC00182_A359UserID
               }
               , new Object[] {
               BC00183_A360BAS_TenantTenantCode, BC00183_A359UserID
               }
               , new Object[] {
               BC00184_A360BAS_TenantTenantCode
               }
               , new Object[] {
               BC00185_A359UserID
               }
               , new Object[] {
               BC00186_A360BAS_TenantTenantCode, BC00186_A359UserID
               }
               , new Object[] {
               BC00187_A360BAS_TenantTenantCode, BC00187_A359UserID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC001810_A360BAS_TenantTenantCode, BC001810_A359UserID
               }
               , new Object[] {
               BC001811_A360BAS_TenantTenantCode
               }
               , new Object[] {
               BC001812_A359UserID
               }
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.sys_tenantuser_bc__default(),
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
      private short RcdFound45 ;
      private int trnEnded ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String sMode45 ;
      private String Z360BAS_TenantTenantCode ;
      private String A360BAS_TenantTenantCode ;
      private Guid Z359UserID ;
      private Guid A359UserID ;
      private SdtSYS_TenantUser bcSYS_TenantUser ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_datastore1 ;
      private String[] BC00186_A360BAS_TenantTenantCode ;
      private Guid[] BC00186_A359UserID ;
      private String[] BC00184_A360BAS_TenantTenantCode ;
      private Guid[] BC00185_A359UserID ;
      private String[] BC00187_A360BAS_TenantTenantCode ;
      private Guid[] BC00187_A359UserID ;
      private String[] BC00183_A360BAS_TenantTenantCode ;
      private Guid[] BC00183_A359UserID ;
      private String[] BC00182_A360BAS_TenantTenantCode ;
      private Guid[] BC00182_A359UserID ;
      private String[] BC001810_A360BAS_TenantTenantCode ;
      private Guid[] BC001810_A359UserID ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private String[] BC001811_A360BAS_TenantTenantCode ;
      private Guid[] BC001812_A359UserID ;
      private IDataStoreProvider pr_default ;
   }

   public class sys_tenantuser_bc__datastore1 : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[9])
         ,new ForEachCursor(def[10])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmBC00186 ;
          prmBC00186 = new Object[] {
          new Object[] {"@BAS_TenantTenantCode",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC00184 ;
          prmBC00184 = new Object[] {
          new Object[] {"@BAS_TenantTenantCode",SqlDbType.NVarChar,20,0}
          } ;
          Object[] prmBC00185 ;
          prmBC00185 = new Object[] {
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC00187 ;
          prmBC00187 = new Object[] {
          new Object[] {"@BAS_TenantTenantCode",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC00183 ;
          prmBC00183 = new Object[] {
          new Object[] {"@BAS_TenantTenantCode",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC00182 ;
          prmBC00182 = new Object[] {
          new Object[] {"@BAS_TenantTenantCode",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC00188 ;
          prmBC00188 = new Object[] {
          new Object[] {"@BAS_TenantTenantCode",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC00189 ;
          prmBC00189 = new Object[] {
          new Object[] {"@BAS_TenantTenantCode",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC001810 ;
          prmBC001810 = new Object[] {
          new Object[] {"@BAS_TenantTenantCode",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC001811 ;
          prmBC001811 = new Object[] {
          new Object[] {"@BAS_TenantTenantCode",SqlDbType.NVarChar,20,0}
          } ;
          Object[] prmBC001812 ;
          prmBC001812 = new Object[] {
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("BC00182", "SELECT [TenantCode] AS BAS_TenantTenantCode, [UserID] FROM dbo.[SYS_TenantUser] WITH (UPDLOCK) WHERE [TenantCode] = @BAS_TenantTenantCode AND [UserID] = @UserID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00182,1,0,true,false )
             ,new CursorDef("BC00183", "SELECT [TenantCode] AS BAS_TenantTenantCode, [UserID] FROM dbo.[SYS_TenantUser] WITH (NOLOCK) WHERE [TenantCode] = @BAS_TenantTenantCode AND [UserID] = @UserID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00183,1,0,true,false )
             ,new CursorDef("BC00184", "SELECT [TenantCode] AS BAS_TenantTenantCode FROM dbo.[BAS_Tenant] WITH (NOLOCK) WHERE [TenantCode] = @BAS_TenantTenantCode ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00184,1,0,true,false )
             ,new CursorDef("BC00185", "SELECT [UserID] FROM dbo.[SYS_User] WITH (NOLOCK) WHERE [UserID] = @UserID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00185,1,0,true,false )
             ,new CursorDef("BC00186", "SELECT TM1.[TenantCode] AS BAS_TenantTenantCode, TM1.[UserID] FROM dbo.[SYS_TenantUser] TM1 WITH (NOLOCK) WHERE TM1.[TenantCode] = @BAS_TenantTenantCode and TM1.[UserID] = @UserID ORDER BY TM1.[TenantCode], TM1.[UserID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00186,100,0,true,false )
             ,new CursorDef("BC00187", "SELECT [TenantCode] AS BAS_TenantTenantCode, [UserID] FROM dbo.[SYS_TenantUser] WITH (NOLOCK) WHERE [TenantCode] = @BAS_TenantTenantCode AND [UserID] = @UserID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00187,1,0,true,false )
             ,new CursorDef("BC00188", "INSERT INTO dbo.[SYS_TenantUser]([TenantCode], [UserID]) VALUES(@BAS_TenantTenantCode, @UserID)", GxErrorMask.GX_NOMASK,prmBC00188)
             ,new CursorDef("BC00189", "DELETE FROM dbo.[SYS_TenantUser]  WHERE [TenantCode] = @BAS_TenantTenantCode AND [UserID] = @UserID", GxErrorMask.GX_NOMASK,prmBC00189)
             ,new CursorDef("BC001810", "SELECT TM1.[TenantCode] AS BAS_TenantTenantCode, TM1.[UserID] FROM dbo.[SYS_TenantUser] TM1 WITH (NOLOCK) WHERE TM1.[TenantCode] = @BAS_TenantTenantCode and TM1.[UserID] = @UserID ORDER BY TM1.[TenantCode], TM1.[UserID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001810,100,0,true,false )
             ,new CursorDef("BC001811", "SELECT [TenantCode] AS BAS_TenantTenantCode FROM dbo.[BAS_Tenant] WITH (NOLOCK) WHERE [TenantCode] = @BAS_TenantTenantCode ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001811,1,0,true,false )
             ,new CursorDef("BC001812", "SELECT [UserID] FROM dbo.[SYS_User] WITH (NOLOCK) WHERE [UserID] = @UserID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001812,1,0,true,false )
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
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((Guid[]) buf[1])[0] = rslt.getGuid(2) ;
                return;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((Guid[]) buf[1])[0] = rslt.getGuid(2) ;
                return;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                return;
             case 3 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                return;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((Guid[]) buf[1])[0] = rslt.getGuid(2) ;
                return;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((Guid[]) buf[1])[0] = rslt.getGuid(2) ;
                return;
             case 8 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((Guid[]) buf[1])[0] = rslt.getGuid(2) ;
                return;
             case 9 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                return;
             case 10 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
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
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (Guid)parms[1]);
                return;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (Guid)parms[1]);
                return;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 3 :
                stmt.SetParameter(1, (Guid)parms[0]);
                return;
             case 4 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (Guid)parms[1]);
                return;
             case 5 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (Guid)parms[1]);
                return;
             case 6 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (Guid)parms[1]);
                return;
             case 7 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (Guid)parms[1]);
                return;
             case 8 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (Guid)parms[1]);
                return;
             case 9 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 10 :
                stmt.SetParameter(1, (Guid)parms[0]);
                return;
       }
    }

    public String getDataStoreName( )
    {
       return "DATASTORE1";
    }

 }

 public class sys_tenantuser_bc__default : DataStoreHelperBase, IDataStoreHelper
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
