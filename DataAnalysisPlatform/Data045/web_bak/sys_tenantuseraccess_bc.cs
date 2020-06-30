/*
               File: SYS_TenantUserAccess_BC
        Description: SYS_Tenant User Access
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:38:58.57
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
   public class sys_tenantuseraccess_bc : GXHttpHandler, IGxSilentTrn
   {
      public sys_tenantuseraccess_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public sys_tenantuseraccess_bc( IGxContext context )
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
         ReadRow1A62( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey1A62( ) ;
         standaloneModal( ) ;
         AddRow1A62( ) ;
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
               Z437SYS_TenantUserAccessUserAccessID = (Guid)(A437SYS_TenantUserAccessUserAccessID);
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

      protected void CONFIRM_1A0( )
      {
         BeforeValidate1A62( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls1A62( ) ;
            }
            else
            {
               CheckExtendedTable1A62( ) ;
               if ( AnyError == 0 )
               {
               }
               CloseExtendedTableCursors1A62( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void ZM1A62( short GX_JID )
      {
         if ( ( GX_JID == 5 ) || ( GX_JID == 0 ) )
         {
            Z439SYS_TenantUserAccessUserID = (Guid)(A439SYS_TenantUserAccessUserID);
            Z438SYS_TenantUserAccessTenantCode = A438SYS_TenantUserAccessTenantCode;
            Z440SYS_TenantUserAccessDataPackage = A440SYS_TenantUserAccessDataPackage;
         }
         if ( GX_JID == -5 )
         {
            Z437SYS_TenantUserAccessUserAccessID = (Guid)(A437SYS_TenantUserAccessUserAccessID);
            Z439SYS_TenantUserAccessUserID = (Guid)(A439SYS_TenantUserAccessUserID);
            Z438SYS_TenantUserAccessTenantCode = A438SYS_TenantUserAccessTenantCode;
            Z440SYS_TenantUserAccessDataPackage = A440SYS_TenantUserAccessDataPackage;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (Guid.Empty==A439SYS_TenantUserAccessUserID) )
         {
            A439SYS_TenantUserAccessUserID = (Guid)(Guid.NewGuid( ));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (Guid.Empty==A437SYS_TenantUserAccessUserAccessID) )
         {
            A437SYS_TenantUserAccessUserAccessID = (Guid)(Guid.NewGuid( ));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( Gx_BScreen == 0 ) )
         {
         }
      }

      protected void Load1A62( )
      {
         /* Using cursor BC001A4 */
         pr_datastore1.execute(2, new Object[] {A437SYS_TenantUserAccessUserAccessID});
         if ( (pr_datastore1.getStatus(2) != 101) )
         {
            RcdFound62 = 1;
            A439SYS_TenantUserAccessUserID = (Guid)((Guid)(BC001A4_A439SYS_TenantUserAccessUserID[0]));
            A438SYS_TenantUserAccessTenantCode = BC001A4_A438SYS_TenantUserAccessTenantCode[0];
            A440SYS_TenantUserAccessDataPackage = BC001A4_A440SYS_TenantUserAccessDataPackage[0];
            ZM1A62( -5) ;
         }
         pr_datastore1.close(2);
         OnLoadActions1A62( ) ;
      }

      protected void OnLoadActions1A62( )
      {
      }

      protected void CheckExtendedTable1A62( )
      {
         standaloneModal( ) ;
      }

      protected void CloseExtendedTableCursors1A62( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey1A62( )
      {
         /* Using cursor BC001A5 */
         pr_datastore1.execute(3, new Object[] {A437SYS_TenantUserAccessUserAccessID});
         if ( (pr_datastore1.getStatus(3) != 101) )
         {
            RcdFound62 = 1;
         }
         else
         {
            RcdFound62 = 0;
         }
         pr_datastore1.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC001A3 */
         pr_datastore1.execute(1, new Object[] {A437SYS_TenantUserAccessUserAccessID});
         if ( (pr_datastore1.getStatus(1) != 101) )
         {
            ZM1A62( 5) ;
            RcdFound62 = 1;
            A437SYS_TenantUserAccessUserAccessID = (Guid)((Guid)(BC001A3_A437SYS_TenantUserAccessUserAccessID[0]));
            A439SYS_TenantUserAccessUserID = (Guid)((Guid)(BC001A3_A439SYS_TenantUserAccessUserID[0]));
            A438SYS_TenantUserAccessTenantCode = BC001A3_A438SYS_TenantUserAccessTenantCode[0];
            A440SYS_TenantUserAccessDataPackage = BC001A3_A440SYS_TenantUserAccessDataPackage[0];
            Z437SYS_TenantUserAccessUserAccessID = (Guid)(A437SYS_TenantUserAccessUserAccessID);
            sMode62 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load1A62( ) ;
            if ( AnyError == 1 )
            {
               RcdFound62 = 0;
               InitializeNonKey1A62( ) ;
            }
            Gx_mode = sMode62;
         }
         else
         {
            RcdFound62 = 0;
            InitializeNonKey1A62( ) ;
            sMode62 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode62;
         }
         pr_datastore1.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1A62( ) ;
         if ( RcdFound62 == 0 )
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
         CONFIRM_1A0( ) ;
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

      protected void CheckOptimisticConcurrency1A62( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC001A2 */
            pr_datastore1.execute(0, new Object[] {A437SYS_TenantUserAccessUserAccessID});
            if ( (pr_datastore1.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SYS_TENANTUSERACCESS"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_datastore1.getStatus(0) == 101) || ( Z439SYS_TenantUserAccessUserID != BC001A2_A439SYS_TenantUserAccessUserID[0] ) || ( StringUtil.StrCmp(Z438SYS_TenantUserAccessTenantCode, BC001A2_A438SYS_TenantUserAccessTenantCode[0]) != 0 ) || ( StringUtil.StrCmp(Z440SYS_TenantUserAccessDataPackage, BC001A2_A440SYS_TenantUserAccessDataPackage[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"SYS_TENANTUSERACCESS"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert1A62( )
      {
         BeforeValidate1A62( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1A62( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1A62( 0) ;
            CheckOptimisticConcurrency1A62( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1A62( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1A62( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC001A6 */
                     pr_datastore1.execute(4, new Object[] {A438SYS_TenantUserAccessTenantCode, A440SYS_TenantUserAccessDataPackage, A437SYS_TenantUserAccessUserAccessID, A439SYS_TenantUserAccessUserID});
                     pr_datastore1.close(4);
                     dsDataStore1.SmartCacheProvider.SetUpdated("SYS_TENANTUSERACCESS") ;
                     if ( (pr_datastore1.getStatus(4) == 1) )
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
               Load1A62( ) ;
            }
            EndLevel1A62( ) ;
         }
         CloseExtendedTableCursors1A62( ) ;
      }

      protected void Update1A62( )
      {
         BeforeValidate1A62( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1A62( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1A62( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1A62( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1A62( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC001A7 */
                     pr_datastore1.execute(5, new Object[] {A439SYS_TenantUserAccessUserID, A438SYS_TenantUserAccessTenantCode, A440SYS_TenantUserAccessDataPackage, A437SYS_TenantUserAccessUserAccessID});
                     pr_datastore1.close(5);
                     dsDataStore1.SmartCacheProvider.SetUpdated("SYS_TENANTUSERACCESS") ;
                     if ( (pr_datastore1.getStatus(5) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SYS_TENANTUSERACCESS"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate1A62( ) ;
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
            EndLevel1A62( ) ;
         }
         CloseExtendedTableCursors1A62( ) ;
      }

      protected void DeferredUpdate1A62( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate1A62( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1A62( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1A62( ) ;
            AfterConfirm1A62( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1A62( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC001A8 */
                  pr_datastore1.execute(6, new Object[] {A437SYS_TenantUserAccessUserAccessID});
                  pr_datastore1.close(6);
                  dsDataStore1.SmartCacheProvider.SetUpdated("SYS_TENANTUSERACCESS") ;
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
         sMode62 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel1A62( ) ;
         Gx_mode = sMode62;
      }

      protected void OnDeleteControls1A62( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel1A62( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_datastore1.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1A62( ) ;
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

      public void ScanKeyStart1A62( )
      {
         /* Using cursor BC001A9 */
         pr_datastore1.execute(7, new Object[] {A437SYS_TenantUserAccessUserAccessID});
         RcdFound62 = 0;
         if ( (pr_datastore1.getStatus(7) != 101) )
         {
            RcdFound62 = 1;
            A437SYS_TenantUserAccessUserAccessID = (Guid)((Guid)(BC001A9_A437SYS_TenantUserAccessUserAccessID[0]));
            A439SYS_TenantUserAccessUserID = (Guid)((Guid)(BC001A9_A439SYS_TenantUserAccessUserID[0]));
            A438SYS_TenantUserAccessTenantCode = BC001A9_A438SYS_TenantUserAccessTenantCode[0];
            A440SYS_TenantUserAccessDataPackage = BC001A9_A440SYS_TenantUserAccessDataPackage[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext1A62( )
      {
         /* Scan next routine */
         pr_datastore1.readNext(7);
         RcdFound62 = 0;
         ScanKeyLoad1A62( ) ;
      }

      protected void ScanKeyLoad1A62( )
      {
         sMode62 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_datastore1.getStatus(7) != 101) )
         {
            RcdFound62 = 1;
            A437SYS_TenantUserAccessUserAccessID = (Guid)((Guid)(BC001A9_A437SYS_TenantUserAccessUserAccessID[0]));
            A439SYS_TenantUserAccessUserID = (Guid)((Guid)(BC001A9_A439SYS_TenantUserAccessUserID[0]));
            A438SYS_TenantUserAccessTenantCode = BC001A9_A438SYS_TenantUserAccessTenantCode[0];
            A440SYS_TenantUserAccessDataPackage = BC001A9_A440SYS_TenantUserAccessDataPackage[0];
         }
         Gx_mode = sMode62;
      }

      protected void ScanKeyEnd1A62( )
      {
         pr_datastore1.close(7);
      }

      protected void AfterConfirm1A62( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1A62( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1A62( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1A62( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1A62( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1A62( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1A62( )
      {
      }

      protected void send_integrity_lvl_hashes1A62( )
      {
      }

      protected void AddRow1A62( )
      {
         VarsToRow62( bcSYS_TenantUserAccess) ;
      }

      protected void ReadRow1A62( )
      {
         RowToVars62( bcSYS_TenantUserAccess, 1) ;
      }

      protected void InitializeNonKey1A62( )
      {
         A438SYS_TenantUserAccessTenantCode = "";
         A440SYS_TenantUserAccessDataPackage = "";
         A439SYS_TenantUserAccessUserID = (Guid)(Guid.NewGuid( ));
         Z439SYS_TenantUserAccessUserID = (Guid)(Guid.Empty);
         Z438SYS_TenantUserAccessTenantCode = "";
         Z440SYS_TenantUserAccessDataPackage = "";
      }

      protected void InitAll1A62( )
      {
         A437SYS_TenantUserAccessUserAccessID = (Guid)(Guid.NewGuid( ));
         InitializeNonKey1A62( ) ;
      }

      protected void StandaloneModalInsert( )
      {
         A439SYS_TenantUserAccessUserID = (Guid)(i439SYS_TenantUserAccessUserID);
      }

      public void VarsToRow62( SdtSYS_TenantUserAccess obj62 )
      {
         obj62.gxTpr_Mode = Gx_mode;
         obj62.gxTpr_Sys_tenantuseraccesstenantcode = A438SYS_TenantUserAccessTenantCode;
         obj62.gxTpr_Sys_tenantuseraccessdatapackage = A440SYS_TenantUserAccessDataPackage;
         obj62.gxTpr_Sys_tenantuseraccessuserid = (Guid)(A439SYS_TenantUserAccessUserID);
         obj62.gxTpr_Sys_tenantuseraccessuseraccessid = (Guid)(A437SYS_TenantUserAccessUserAccessID);
         obj62.gxTpr_Sys_tenantuseraccessuseraccessid_Z = (Guid)(Z437SYS_TenantUserAccessUserAccessID);
         obj62.gxTpr_Sys_tenantuseraccessuserid_Z = (Guid)(Z439SYS_TenantUserAccessUserID);
         obj62.gxTpr_Sys_tenantuseraccesstenantcode_Z = Z438SYS_TenantUserAccessTenantCode;
         obj62.gxTpr_Sys_tenantuseraccessdatapackage_Z = Z440SYS_TenantUserAccessDataPackage;
         obj62.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow62( SdtSYS_TenantUserAccess obj62 )
      {
         obj62.gxTpr_Sys_tenantuseraccessuseraccessid = (Guid)(A437SYS_TenantUserAccessUserAccessID);
         return  ;
      }

      public void RowToVars62( SdtSYS_TenantUserAccess obj62 ,
                               int forceLoad )
      {
         Gx_mode = obj62.gxTpr_Mode;
         A438SYS_TenantUserAccessTenantCode = obj62.gxTpr_Sys_tenantuseraccesstenantcode;
         A440SYS_TenantUserAccessDataPackage = obj62.gxTpr_Sys_tenantuseraccessdatapackage;
         A439SYS_TenantUserAccessUserID = (Guid)(obj62.gxTpr_Sys_tenantuseraccessuserid);
         A437SYS_TenantUserAccessUserAccessID = (Guid)(obj62.gxTpr_Sys_tenantuseraccessuseraccessid);
         Z437SYS_TenantUserAccessUserAccessID = (Guid)(obj62.gxTpr_Sys_tenantuseraccessuseraccessid_Z);
         Z439SYS_TenantUserAccessUserID = (Guid)(obj62.gxTpr_Sys_tenantuseraccessuserid_Z);
         Z438SYS_TenantUserAccessTenantCode = obj62.gxTpr_Sys_tenantuseraccesstenantcode_Z;
         Z440SYS_TenantUserAccessDataPackage = obj62.gxTpr_Sys_tenantuseraccessdatapackage_Z;
         Gx_mode = obj62.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A437SYS_TenantUserAccessUserAccessID = (Guid)((Guid)getParm(obj,0));
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey1A62( ) ;
         ScanKeyStart1A62( ) ;
         if ( RcdFound62 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z437SYS_TenantUserAccessUserAccessID = (Guid)(A437SYS_TenantUserAccessUserAccessID);
         }
         ZM1A62( -5) ;
         OnLoadActions1A62( ) ;
         AddRow1A62( ) ;
         ScanKeyEnd1A62( ) ;
         if ( RcdFound62 == 0 )
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
         RowToVars62( bcSYS_TenantUserAccess, 0) ;
         ScanKeyStart1A62( ) ;
         if ( RcdFound62 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z437SYS_TenantUserAccessUserAccessID = (Guid)(A437SYS_TenantUserAccessUserAccessID);
         }
         ZM1A62( -5) ;
         OnLoadActions1A62( ) ;
         AddRow1A62( ) ;
         ScanKeyEnd1A62( ) ;
         if ( RcdFound62 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey1A62( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert1A62( ) ;
         }
         else
         {
            if ( RcdFound62 == 1 )
            {
               if ( A437SYS_TenantUserAccessUserAccessID != Z437SYS_TenantUserAccessUserAccessID )
               {
                  A437SYS_TenantUserAccessUserAccessID = (Guid)(Z437SYS_TenantUserAccessUserAccessID);
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
                  Update1A62( ) ;
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
                  if ( A437SYS_TenantUserAccessUserAccessID != Z437SYS_TenantUserAccessUserAccessID )
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
                        Insert1A62( ) ;
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
                        Insert1A62( ) ;
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
         RowToVars62( bcSYS_TenantUserAccess, 0) ;
         SaveImpl( ) ;
         VarsToRow62( bcSYS_TenantUserAccess) ;
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
         RowToVars62( bcSYS_TenantUserAccess, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert1A62( ) ;
         AfterTrn( ) ;
         VarsToRow62( bcSYS_TenantUserAccess) ;
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
            SdtSYS_TenantUserAccess auxBC = new SdtSYS_TenantUserAccess(context) ;
            auxBC.Load(A437SYS_TenantUserAccessUserAccessID);
            auxBC.UpdateDirties(bcSYS_TenantUserAccess);
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
         RowToVars62( bcSYS_TenantUserAccess, 0) ;
         UpdateImpl( ) ;
         VarsToRow62( bcSYS_TenantUserAccess) ;
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
         RowToVars62( bcSYS_TenantUserAccess, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert1A62( ) ;
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
         VarsToRow62( bcSYS_TenantUserAccess) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars62( bcSYS_TenantUserAccess, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey1A62( ) ;
         if ( RcdFound62 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A437SYS_TenantUserAccessUserAccessID != Z437SYS_TenantUserAccessUserAccessID )
            {
               A437SYS_TenantUserAccessUserAccessID = (Guid)(Z437SYS_TenantUserAccessUserAccessID);
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
            if ( A437SYS_TenantUserAccessUserAccessID != Z437SYS_TenantUserAccessUserAccessID )
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
         context.RollbackDataStores("sys_tenantuseraccess_bc",pr_default);
         VarsToRow62( bcSYS_TenantUserAccess) ;
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
         Gx_mode = bcSYS_TenantUserAccess.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcSYS_TenantUserAccess.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcSYS_TenantUserAccess )
         {
            bcSYS_TenantUserAccess = (SdtSYS_TenantUserAccess)(sdt);
            if ( StringUtil.StrCmp(bcSYS_TenantUserAccess.gxTpr_Mode, "") == 0 )
            {
               bcSYS_TenantUserAccess.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow62( bcSYS_TenantUserAccess) ;
            }
            else
            {
               RowToVars62( bcSYS_TenantUserAccess, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcSYS_TenantUserAccess.gxTpr_Mode, "") == 0 )
            {
               bcSYS_TenantUserAccess.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars62( bcSYS_TenantUserAccess, 1) ;
         return  ;
      }

      public SdtSYS_TenantUserAccess SYS_TenantUserAccess_BC
      {
         get {
            return bcSYS_TenantUserAccess ;
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
         Z437SYS_TenantUserAccessUserAccessID = (Guid)(Guid.Empty);
         A437SYS_TenantUserAccessUserAccessID = (Guid)(Guid.Empty);
         Z439SYS_TenantUserAccessUserID = (Guid)(Guid.Empty);
         A439SYS_TenantUserAccessUserID = (Guid)(Guid.Empty);
         Z438SYS_TenantUserAccessTenantCode = "";
         A438SYS_TenantUserAccessTenantCode = "";
         Z440SYS_TenantUserAccessDataPackage = "";
         A440SYS_TenantUserAccessDataPackage = "";
         BC001A4_A437SYS_TenantUserAccessUserAccessID = new Guid[] {Guid.Empty} ;
         BC001A4_A439SYS_TenantUserAccessUserID = new Guid[] {Guid.Empty} ;
         BC001A4_A438SYS_TenantUserAccessTenantCode = new String[] {""} ;
         BC001A4_A440SYS_TenantUserAccessDataPackage = new String[] {""} ;
         BC001A5_A437SYS_TenantUserAccessUserAccessID = new Guid[] {Guid.Empty} ;
         BC001A3_A437SYS_TenantUserAccessUserAccessID = new Guid[] {Guid.Empty} ;
         BC001A3_A439SYS_TenantUserAccessUserID = new Guid[] {Guid.Empty} ;
         BC001A3_A438SYS_TenantUserAccessTenantCode = new String[] {""} ;
         BC001A3_A440SYS_TenantUserAccessDataPackage = new String[] {""} ;
         sMode62 = "";
         BC001A2_A437SYS_TenantUserAccessUserAccessID = new Guid[] {Guid.Empty} ;
         BC001A2_A439SYS_TenantUserAccessUserID = new Guid[] {Guid.Empty} ;
         BC001A2_A438SYS_TenantUserAccessTenantCode = new String[] {""} ;
         BC001A2_A440SYS_TenantUserAccessDataPackage = new String[] {""} ;
         BC001A9_A437SYS_TenantUserAccessUserAccessID = new Guid[] {Guid.Empty} ;
         BC001A9_A439SYS_TenantUserAccessUserID = new Guid[] {Guid.Empty} ;
         BC001A9_A438SYS_TenantUserAccessTenantCode = new String[] {""} ;
         BC001A9_A440SYS_TenantUserAccessDataPackage = new String[] {""} ;
         i439SYS_TenantUserAccessUserID = (Guid)(Guid.Empty);
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.sys_tenantuseraccess_bc__datastore1(),
            new Object[][] {
                new Object[] {
               BC001A2_A437SYS_TenantUserAccessUserAccessID, BC001A2_A439SYS_TenantUserAccessUserID, BC001A2_A438SYS_TenantUserAccessTenantCode, BC001A2_A440SYS_TenantUserAccessDataPackage
               }
               , new Object[] {
               BC001A3_A437SYS_TenantUserAccessUserAccessID, BC001A3_A439SYS_TenantUserAccessUserID, BC001A3_A438SYS_TenantUserAccessTenantCode, BC001A3_A440SYS_TenantUserAccessDataPackage
               }
               , new Object[] {
               BC001A4_A437SYS_TenantUserAccessUserAccessID, BC001A4_A439SYS_TenantUserAccessUserID, BC001A4_A438SYS_TenantUserAccessTenantCode, BC001A4_A440SYS_TenantUserAccessDataPackage
               }
               , new Object[] {
               BC001A5_A437SYS_TenantUserAccessUserAccessID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC001A9_A437SYS_TenantUserAccessUserAccessID, BC001A9_A439SYS_TenantUserAccessUserID, BC001A9_A438SYS_TenantUserAccessTenantCode, BC001A9_A440SYS_TenantUserAccessDataPackage
               }
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.sys_tenantuseraccess_bc__default(),
            new Object[][] {
            }
         );
         Z439SYS_TenantUserAccessUserID = (Guid)(Guid.NewGuid( ));
         A439SYS_TenantUserAccessUserID = (Guid)(Guid.NewGuid( ));
         i439SYS_TenantUserAccessUserID = (Guid)(Guid.NewGuid( ));
         Z437SYS_TenantUserAccessUserAccessID = (Guid)(Guid.NewGuid( ));
         A437SYS_TenantUserAccessUserAccessID = (Guid)(Guid.NewGuid( ));
         INITTRN();
         /* Execute Start event if defined. */
         standaloneNotModal( ) ;
      }

      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short RcdFound62 ;
      private int trnEnded ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String sMode62 ;
      private String Z438SYS_TenantUserAccessTenantCode ;
      private String A438SYS_TenantUserAccessTenantCode ;
      private String Z440SYS_TenantUserAccessDataPackage ;
      private String A440SYS_TenantUserAccessDataPackage ;
      private Guid Z437SYS_TenantUserAccessUserAccessID ;
      private Guid A437SYS_TenantUserAccessUserAccessID ;
      private Guid Z439SYS_TenantUserAccessUserID ;
      private Guid A439SYS_TenantUserAccessUserID ;
      private Guid i439SYS_TenantUserAccessUserID ;
      private SdtSYS_TenantUserAccess bcSYS_TenantUserAccess ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_datastore1 ;
      private Guid[] BC001A4_A437SYS_TenantUserAccessUserAccessID ;
      private Guid[] BC001A4_A439SYS_TenantUserAccessUserID ;
      private String[] BC001A4_A438SYS_TenantUserAccessTenantCode ;
      private String[] BC001A4_A440SYS_TenantUserAccessDataPackage ;
      private Guid[] BC001A5_A437SYS_TenantUserAccessUserAccessID ;
      private Guid[] BC001A3_A437SYS_TenantUserAccessUserAccessID ;
      private Guid[] BC001A3_A439SYS_TenantUserAccessUserID ;
      private String[] BC001A3_A438SYS_TenantUserAccessTenantCode ;
      private String[] BC001A3_A440SYS_TenantUserAccessDataPackage ;
      private Guid[] BC001A2_A437SYS_TenantUserAccessUserAccessID ;
      private Guid[] BC001A2_A439SYS_TenantUserAccessUserID ;
      private String[] BC001A2_A438SYS_TenantUserAccessTenantCode ;
      private String[] BC001A2_A440SYS_TenantUserAccessDataPackage ;
      private Guid[] BC001A9_A437SYS_TenantUserAccessUserAccessID ;
      private Guid[] BC001A9_A439SYS_TenantUserAccessUserID ;
      private String[] BC001A9_A438SYS_TenantUserAccessTenantCode ;
      private String[] BC001A9_A440SYS_TenantUserAccessDataPackage ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_default ;
   }

   public class sys_tenantuseraccess_bc__datastore1 : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
         ,new UpdateCursor(def[4])
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
          Object[] prmBC001A4 ;
          prmBC001A4 = new Object[] {
          new Object[] {"@SYS_TenantUserAccessUserAccessID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC001A5 ;
          prmBC001A5 = new Object[] {
          new Object[] {"@SYS_TenantUserAccessUserAccessID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC001A3 ;
          prmBC001A3 = new Object[] {
          new Object[] {"@SYS_TenantUserAccessUserAccessID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC001A2 ;
          prmBC001A2 = new Object[] {
          new Object[] {"@SYS_TenantUserAccessUserAccessID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC001A6 ;
          prmBC001A6 = new Object[] {
          new Object[] {"@SYS_TenantUserAccessTenantCode",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@SYS_TenantUserAccessDataPackage",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@SYS_TenantUserAccessUserAccessID",SqlDbType.UniqueIdentifier,16,0} ,
          new Object[] {"@SYS_TenantUserAccessUserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC001A7 ;
          prmBC001A7 = new Object[] {
          new Object[] {"@SYS_TenantUserAccessUserID",SqlDbType.UniqueIdentifier,16,0} ,
          new Object[] {"@SYS_TenantUserAccessTenantCode",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@SYS_TenantUserAccessDataPackage",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@SYS_TenantUserAccessUserAccessID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC001A8 ;
          prmBC001A8 = new Object[] {
          new Object[] {"@SYS_TenantUserAccessUserAccessID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC001A9 ;
          prmBC001A9 = new Object[] {
          new Object[] {"@SYS_TenantUserAccessUserAccessID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("BC001A2", "SELECT [UserAccessID], [UserID], [TenantCode], [DataPackage] FROM [SYS_TenantUserAccess] WITH (UPDLOCK) WHERE [UserAccessID] = @SYS_TenantUserAccessUserAccessID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001A2,1,0,true,false )
             ,new CursorDef("BC001A3", "SELECT [UserAccessID], [UserID], [TenantCode], [DataPackage] FROM [SYS_TenantUserAccess] WITH (NOLOCK) WHERE [UserAccessID] = @SYS_TenantUserAccessUserAccessID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001A3,1,0,true,false )
             ,new CursorDef("BC001A4", "SELECT TM1.[UserAccessID], TM1.[UserID], TM1.[TenantCode], TM1.[DataPackage] FROM [SYS_TenantUserAccess] TM1 WITH (NOLOCK) WHERE TM1.[UserAccessID] = @SYS_TenantUserAccessUserAccessID ORDER BY TM1.[UserAccessID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001A4,100,0,true,false )
             ,new CursorDef("BC001A5", "SELECT [UserAccessID] FROM [SYS_TenantUserAccess] WITH (NOLOCK) WHERE [UserAccessID] = @SYS_TenantUserAccessUserAccessID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001A5,1,0,true,false )
             ,new CursorDef("BC001A6", "INSERT INTO [SYS_TenantUserAccess]([TenantCode], [DataPackage], [UserAccessID], [UserID]) VALUES(@SYS_TenantUserAccessTenantCode, @SYS_TenantUserAccessDataPackage, @SYS_TenantUserAccessUserAccessID, @SYS_TenantUserAccessUserID)", GxErrorMask.GX_NOMASK,prmBC001A6)
             ,new CursorDef("BC001A7", "UPDATE [SYS_TenantUserAccess] SET [UserID]=@SYS_TenantUserAccessUserID, [TenantCode]=@SYS_TenantUserAccessTenantCode, [DataPackage]=@SYS_TenantUserAccessDataPackage  WHERE [UserAccessID] = @SYS_TenantUserAccessUserAccessID", GxErrorMask.GX_NOMASK,prmBC001A7)
             ,new CursorDef("BC001A8", "DELETE FROM [SYS_TenantUserAccess]  WHERE [UserAccessID] = @SYS_TenantUserAccessUserAccessID", GxErrorMask.GX_NOMASK,prmBC001A8)
             ,new CursorDef("BC001A9", "SELECT TM1.[UserAccessID], TM1.[UserID], TM1.[TenantCode], TM1.[DataPackage] FROM [SYS_TenantUserAccess] TM1 WITH (NOLOCK) WHERE TM1.[UserAccessID] = @SYS_TenantUserAccessUserAccessID ORDER BY TM1.[UserAccessID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001A9,100,0,true,false )
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
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                ((Guid[]) buf[1])[0] = rslt.getGuid(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                return;
             case 1 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                ((Guid[]) buf[1])[0] = rslt.getGuid(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                return;
             case 2 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                ((Guid[]) buf[1])[0] = rslt.getGuid(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                return;
             case 3 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                return;
             case 7 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                ((Guid[]) buf[1])[0] = rslt.getGuid(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
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
                stmt.SetParameter(1, (Guid)parms[0]);
                return;
             case 1 :
                stmt.SetParameter(1, (Guid)parms[0]);
                return;
             case 2 :
                stmt.SetParameter(1, (Guid)parms[0]);
                return;
             case 3 :
                stmt.SetParameter(1, (Guid)parms[0]);
                return;
             case 4 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (Guid)parms[2]);
                stmt.SetParameter(4, (Guid)parms[3]);
                return;
             case 5 :
                stmt.SetParameter(1, (Guid)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (Guid)parms[3]);
                return;
             case 6 :
                stmt.SetParameter(1, (Guid)parms[0]);
                return;
             case 7 :
                stmt.SetParameter(1, (Guid)parms[0]);
                return;
       }
    }

    public String getDataStoreName( )
    {
       return "DATASTORE1";
    }

 }

 public class sys_tenantuseraccess_bc__default : DataStoreHelperBase, IDataStoreHelper
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
