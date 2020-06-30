/*
               File: SYS_Permission_BC
        Description: SYS_Permission
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:8:52.79
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
   public class sys_permission_bc : GXHttpHandler, IGxSilentTrn
   {
      public sys_permission_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public sys_permission_bc( IGxContext context )
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
         ReadRow1946( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey1946( ) ;
         standaloneModal( ) ;
         AddRow1946( ) ;
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
               Z362PermissionCode = A362PermissionCode;
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

      protected void CONFIRM_190( )
      {
         BeforeValidate1946( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls1946( ) ;
            }
            else
            {
               CheckExtendedTable1946( ) ;
               if ( AnyError == 0 )
               {
               }
               CloseExtendedTableCursors1946( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void ZM1946( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            Z403PermissionName = A403PermissionName;
            Z404OrderIndex = A404OrderIndex;
            Z406SYS_PermissionModuleCode = A406SYS_PermissionModuleCode;
            Z407SYS_PermissionIsDeleted = A407SYS_PermissionIsDeleted;
         }
         if ( GX_JID == -1 )
         {
            Z362PermissionCode = A362PermissionCode;
            Z403PermissionName = A403PermissionName;
            Z404OrderIndex = A404OrderIndex;
            Z405SYS_PermissionDescription = A405SYS_PermissionDescription;
            Z406SYS_PermissionModuleCode = A406SYS_PermissionModuleCode;
            Z407SYS_PermissionIsDeleted = A407SYS_PermissionIsDeleted;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load1946( )
      {
         /* Using cursor BC00194 */
         pr_datastore1.execute(2, new Object[] {A362PermissionCode});
         if ( (pr_datastore1.getStatus(2) != 101) )
         {
            RcdFound46 = 1;
            A403PermissionName = BC00194_A403PermissionName[0];
            A404OrderIndex = BC00194_A404OrderIndex[0];
            A405SYS_PermissionDescription = BC00194_A405SYS_PermissionDescription[0];
            n405SYS_PermissionDescription = BC00194_n405SYS_PermissionDescription[0];
            A406SYS_PermissionModuleCode = BC00194_A406SYS_PermissionModuleCode[0];
            n406SYS_PermissionModuleCode = BC00194_n406SYS_PermissionModuleCode[0];
            A407SYS_PermissionIsDeleted = BC00194_A407SYS_PermissionIsDeleted[0];
            ZM1946( -1) ;
         }
         pr_datastore1.close(2);
         OnLoadActions1946( ) ;
      }

      protected void OnLoadActions1946( )
      {
      }

      protected void CheckExtendedTable1946( )
      {
         standaloneModal( ) ;
      }

      protected void CloseExtendedTableCursors1946( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey1946( )
      {
         /* Using cursor BC00195 */
         pr_datastore1.execute(3, new Object[] {A362PermissionCode});
         if ( (pr_datastore1.getStatus(3) != 101) )
         {
            RcdFound46 = 1;
         }
         else
         {
            RcdFound46 = 0;
         }
         pr_datastore1.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC00193 */
         pr_datastore1.execute(1, new Object[] {A362PermissionCode});
         if ( (pr_datastore1.getStatus(1) != 101) )
         {
            ZM1946( 1) ;
            RcdFound46 = 1;
            A362PermissionCode = BC00193_A362PermissionCode[0];
            A403PermissionName = BC00193_A403PermissionName[0];
            A404OrderIndex = BC00193_A404OrderIndex[0];
            A405SYS_PermissionDescription = BC00193_A405SYS_PermissionDescription[0];
            n405SYS_PermissionDescription = BC00193_n405SYS_PermissionDescription[0];
            A406SYS_PermissionModuleCode = BC00193_A406SYS_PermissionModuleCode[0];
            n406SYS_PermissionModuleCode = BC00193_n406SYS_PermissionModuleCode[0];
            A407SYS_PermissionIsDeleted = BC00193_A407SYS_PermissionIsDeleted[0];
            Z362PermissionCode = A362PermissionCode;
            sMode46 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load1946( ) ;
            if ( AnyError == 1 )
            {
               RcdFound46 = 0;
               InitializeNonKey1946( ) ;
            }
            Gx_mode = sMode46;
         }
         else
         {
            RcdFound46 = 0;
            InitializeNonKey1946( ) ;
            sMode46 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode46;
         }
         pr_datastore1.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1946( ) ;
         if ( RcdFound46 == 0 )
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
         CONFIRM_190( ) ;
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

      protected void CheckOptimisticConcurrency1946( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC00192 */
            pr_datastore1.execute(0, new Object[] {A362PermissionCode});
            if ( (pr_datastore1.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SYS_PERMISSION"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_datastore1.getStatus(0) == 101) || ( StringUtil.StrCmp(Z403PermissionName, BC00192_A403PermissionName[0]) != 0 ) || ( Z404OrderIndex != BC00192_A404OrderIndex[0] ) || ( StringUtil.StrCmp(Z406SYS_PermissionModuleCode, BC00192_A406SYS_PermissionModuleCode[0]) != 0 ) || ( Z407SYS_PermissionIsDeleted != BC00192_A407SYS_PermissionIsDeleted[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"SYS_PERMISSION"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert1946( )
      {
         BeforeValidate1946( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1946( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1946( 0) ;
            CheckOptimisticConcurrency1946( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1946( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1946( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00196 */
                     pr_datastore1.execute(4, new Object[] {A362PermissionCode, A403PermissionName, A404OrderIndex, n405SYS_PermissionDescription, A405SYS_PermissionDescription, n406SYS_PermissionModuleCode, A406SYS_PermissionModuleCode, A407SYS_PermissionIsDeleted});
                     pr_datastore1.close(4);
                     dsDataStore1.SmartCacheProvider.SetUpdated("SYS_PERMISSION") ;
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
               Load1946( ) ;
            }
            EndLevel1946( ) ;
         }
         CloseExtendedTableCursors1946( ) ;
      }

      protected void Update1946( )
      {
         BeforeValidate1946( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1946( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1946( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1946( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1946( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00197 */
                     pr_datastore1.execute(5, new Object[] {A403PermissionName, A404OrderIndex, n405SYS_PermissionDescription, A405SYS_PermissionDescription, n406SYS_PermissionModuleCode, A406SYS_PermissionModuleCode, A407SYS_PermissionIsDeleted, A362PermissionCode});
                     pr_datastore1.close(5);
                     dsDataStore1.SmartCacheProvider.SetUpdated("SYS_PERMISSION") ;
                     if ( (pr_datastore1.getStatus(5) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SYS_PERMISSION"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate1946( ) ;
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
            EndLevel1946( ) ;
         }
         CloseExtendedTableCursors1946( ) ;
      }

      protected void DeferredUpdate1946( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate1946( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1946( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1946( ) ;
            AfterConfirm1946( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1946( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC00198 */
                  pr_datastore1.execute(6, new Object[] {A362PermissionCode});
                  pr_datastore1.close(6);
                  dsDataStore1.SmartCacheProvider.SetUpdated("SYS_PERMISSION") ;
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
         sMode46 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel1946( ) ;
         Gx_mode = sMode46;
      }

      protected void OnDeleteControls1946( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel1946( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_datastore1.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1946( ) ;
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

      public void ScanKeyStart1946( )
      {
         /* Using cursor BC00199 */
         pr_datastore1.execute(7, new Object[] {A362PermissionCode});
         RcdFound46 = 0;
         if ( (pr_datastore1.getStatus(7) != 101) )
         {
            RcdFound46 = 1;
            A362PermissionCode = BC00199_A362PermissionCode[0];
            A403PermissionName = BC00199_A403PermissionName[0];
            A404OrderIndex = BC00199_A404OrderIndex[0];
            A405SYS_PermissionDescription = BC00199_A405SYS_PermissionDescription[0];
            n405SYS_PermissionDescription = BC00199_n405SYS_PermissionDescription[0];
            A406SYS_PermissionModuleCode = BC00199_A406SYS_PermissionModuleCode[0];
            n406SYS_PermissionModuleCode = BC00199_n406SYS_PermissionModuleCode[0];
            A407SYS_PermissionIsDeleted = BC00199_A407SYS_PermissionIsDeleted[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext1946( )
      {
         /* Scan next routine */
         pr_datastore1.readNext(7);
         RcdFound46 = 0;
         ScanKeyLoad1946( ) ;
      }

      protected void ScanKeyLoad1946( )
      {
         sMode46 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_datastore1.getStatus(7) != 101) )
         {
            RcdFound46 = 1;
            A362PermissionCode = BC00199_A362PermissionCode[0];
            A403PermissionName = BC00199_A403PermissionName[0];
            A404OrderIndex = BC00199_A404OrderIndex[0];
            A405SYS_PermissionDescription = BC00199_A405SYS_PermissionDescription[0];
            n405SYS_PermissionDescription = BC00199_n405SYS_PermissionDescription[0];
            A406SYS_PermissionModuleCode = BC00199_A406SYS_PermissionModuleCode[0];
            n406SYS_PermissionModuleCode = BC00199_n406SYS_PermissionModuleCode[0];
            A407SYS_PermissionIsDeleted = BC00199_A407SYS_PermissionIsDeleted[0];
         }
         Gx_mode = sMode46;
      }

      protected void ScanKeyEnd1946( )
      {
         pr_datastore1.close(7);
      }

      protected void AfterConfirm1946( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1946( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1946( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1946( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1946( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1946( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1946( )
      {
      }

      protected void send_integrity_lvl_hashes1946( )
      {
      }

      protected void AddRow1946( )
      {
         VarsToRow46( bcSYS_Permission) ;
      }

      protected void ReadRow1946( )
      {
         RowToVars46( bcSYS_Permission, 1) ;
      }

      protected void InitializeNonKey1946( )
      {
         A403PermissionName = "";
         A404OrderIndex = 0;
         A405SYS_PermissionDescription = "";
         n405SYS_PermissionDescription = false;
         A406SYS_PermissionModuleCode = "";
         n406SYS_PermissionModuleCode = false;
         A407SYS_PermissionIsDeleted = 0;
         Z403PermissionName = "";
         Z404OrderIndex = 0;
         Z406SYS_PermissionModuleCode = "";
         Z407SYS_PermissionIsDeleted = 0;
      }

      protected void InitAll1946( )
      {
         A362PermissionCode = "";
         InitializeNonKey1946( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow46( SdtSYS_Permission obj46 )
      {
         obj46.gxTpr_Mode = Gx_mode;
         obj46.gxTpr_Permissionname = A403PermissionName;
         obj46.gxTpr_Orderindex = A404OrderIndex;
         obj46.gxTpr_Sys_permissiondescription = A405SYS_PermissionDescription;
         obj46.gxTpr_Sys_permissionmodulecode = A406SYS_PermissionModuleCode;
         obj46.gxTpr_Sys_permissionisdeleted = A407SYS_PermissionIsDeleted;
         obj46.gxTpr_Permissioncode = A362PermissionCode;
         obj46.gxTpr_Permissioncode_Z = Z362PermissionCode;
         obj46.gxTpr_Permissionname_Z = Z403PermissionName;
         obj46.gxTpr_Orderindex_Z = Z404OrderIndex;
         obj46.gxTpr_Sys_permissionmodulecode_Z = Z406SYS_PermissionModuleCode;
         obj46.gxTpr_Sys_permissionisdeleted_Z = Z407SYS_PermissionIsDeleted;
         obj46.gxTpr_Sys_permissiondescription_N = (short)(Convert.ToInt16(n405SYS_PermissionDescription));
         obj46.gxTpr_Sys_permissionmodulecode_N = (short)(Convert.ToInt16(n406SYS_PermissionModuleCode));
         obj46.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow46( SdtSYS_Permission obj46 )
      {
         obj46.gxTpr_Permissioncode = A362PermissionCode;
         return  ;
      }

      public void RowToVars46( SdtSYS_Permission obj46 ,
                               int forceLoad )
      {
         Gx_mode = obj46.gxTpr_Mode;
         A403PermissionName = obj46.gxTpr_Permissionname;
         A404OrderIndex = obj46.gxTpr_Orderindex;
         A405SYS_PermissionDescription = obj46.gxTpr_Sys_permissiondescription;
         n405SYS_PermissionDescription = false;
         A406SYS_PermissionModuleCode = obj46.gxTpr_Sys_permissionmodulecode;
         n406SYS_PermissionModuleCode = false;
         A407SYS_PermissionIsDeleted = obj46.gxTpr_Sys_permissionisdeleted;
         A362PermissionCode = obj46.gxTpr_Permissioncode;
         Z362PermissionCode = obj46.gxTpr_Permissioncode_Z;
         Z403PermissionName = obj46.gxTpr_Permissionname_Z;
         Z404OrderIndex = obj46.gxTpr_Orderindex_Z;
         Z406SYS_PermissionModuleCode = obj46.gxTpr_Sys_permissionmodulecode_Z;
         Z407SYS_PermissionIsDeleted = obj46.gxTpr_Sys_permissionisdeleted_Z;
         n405SYS_PermissionDescription = (bool)(Convert.ToBoolean(obj46.gxTpr_Sys_permissiondescription_N));
         n406SYS_PermissionModuleCode = (bool)(Convert.ToBoolean(obj46.gxTpr_Sys_permissionmodulecode_N));
         Gx_mode = obj46.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A362PermissionCode = (String)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey1946( ) ;
         ScanKeyStart1946( ) ;
         if ( RcdFound46 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z362PermissionCode = A362PermissionCode;
         }
         ZM1946( -1) ;
         OnLoadActions1946( ) ;
         AddRow1946( ) ;
         ScanKeyEnd1946( ) ;
         if ( RcdFound46 == 0 )
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
         RowToVars46( bcSYS_Permission, 0) ;
         ScanKeyStart1946( ) ;
         if ( RcdFound46 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z362PermissionCode = A362PermissionCode;
         }
         ZM1946( -1) ;
         OnLoadActions1946( ) ;
         AddRow1946( ) ;
         ScanKeyEnd1946( ) ;
         if ( RcdFound46 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey1946( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert1946( ) ;
         }
         else
         {
            if ( RcdFound46 == 1 )
            {
               if ( StringUtil.StrCmp(A362PermissionCode, Z362PermissionCode) != 0 )
               {
                  A362PermissionCode = Z362PermissionCode;
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
                  Update1946( ) ;
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
                  if ( StringUtil.StrCmp(A362PermissionCode, Z362PermissionCode) != 0 )
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
                        Insert1946( ) ;
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
                        Insert1946( ) ;
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
         RowToVars46( bcSYS_Permission, 0) ;
         SaveImpl( ) ;
         VarsToRow46( bcSYS_Permission) ;
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
         RowToVars46( bcSYS_Permission, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert1946( ) ;
         AfterTrn( ) ;
         VarsToRow46( bcSYS_Permission) ;
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
            SdtSYS_Permission auxBC = new SdtSYS_Permission(context) ;
            auxBC.Load(A362PermissionCode);
            auxBC.UpdateDirties(bcSYS_Permission);
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
         RowToVars46( bcSYS_Permission, 0) ;
         UpdateImpl( ) ;
         VarsToRow46( bcSYS_Permission) ;
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
         RowToVars46( bcSYS_Permission, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert1946( ) ;
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
         VarsToRow46( bcSYS_Permission) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars46( bcSYS_Permission, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey1946( ) ;
         if ( RcdFound46 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( StringUtil.StrCmp(A362PermissionCode, Z362PermissionCode) != 0 )
            {
               A362PermissionCode = Z362PermissionCode;
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
            if ( StringUtil.StrCmp(A362PermissionCode, Z362PermissionCode) != 0 )
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
         context.RollbackDataStores("sys_permission_bc",pr_default);
         VarsToRow46( bcSYS_Permission) ;
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
         Gx_mode = bcSYS_Permission.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcSYS_Permission.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcSYS_Permission )
         {
            bcSYS_Permission = (SdtSYS_Permission)(sdt);
            if ( StringUtil.StrCmp(bcSYS_Permission.gxTpr_Mode, "") == 0 )
            {
               bcSYS_Permission.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow46( bcSYS_Permission) ;
            }
            else
            {
               RowToVars46( bcSYS_Permission, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcSYS_Permission.gxTpr_Mode, "") == 0 )
            {
               bcSYS_Permission.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars46( bcSYS_Permission, 1) ;
         return  ;
      }

      public SdtSYS_Permission SYS_Permission_BC
      {
         get {
            return bcSYS_Permission ;
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
         Z362PermissionCode = "";
         A362PermissionCode = "";
         Z403PermissionName = "";
         A403PermissionName = "";
         Z406SYS_PermissionModuleCode = "";
         A406SYS_PermissionModuleCode = "";
         Z405SYS_PermissionDescription = "";
         A405SYS_PermissionDescription = "";
         BC00194_A362PermissionCode = new String[] {""} ;
         BC00194_A403PermissionName = new String[] {""} ;
         BC00194_A404OrderIndex = new int[1] ;
         BC00194_A405SYS_PermissionDescription = new String[] {""} ;
         BC00194_n405SYS_PermissionDescription = new bool[] {false} ;
         BC00194_A406SYS_PermissionModuleCode = new String[] {""} ;
         BC00194_n406SYS_PermissionModuleCode = new bool[] {false} ;
         BC00194_A407SYS_PermissionIsDeleted = new short[1] ;
         BC00195_A362PermissionCode = new String[] {""} ;
         BC00193_A362PermissionCode = new String[] {""} ;
         BC00193_A403PermissionName = new String[] {""} ;
         BC00193_A404OrderIndex = new int[1] ;
         BC00193_A405SYS_PermissionDescription = new String[] {""} ;
         BC00193_n405SYS_PermissionDescription = new bool[] {false} ;
         BC00193_A406SYS_PermissionModuleCode = new String[] {""} ;
         BC00193_n406SYS_PermissionModuleCode = new bool[] {false} ;
         BC00193_A407SYS_PermissionIsDeleted = new short[1] ;
         sMode46 = "";
         BC00192_A362PermissionCode = new String[] {""} ;
         BC00192_A403PermissionName = new String[] {""} ;
         BC00192_A404OrderIndex = new int[1] ;
         BC00192_A405SYS_PermissionDescription = new String[] {""} ;
         BC00192_n405SYS_PermissionDescription = new bool[] {false} ;
         BC00192_A406SYS_PermissionModuleCode = new String[] {""} ;
         BC00192_n406SYS_PermissionModuleCode = new bool[] {false} ;
         BC00192_A407SYS_PermissionIsDeleted = new short[1] ;
         BC00199_A362PermissionCode = new String[] {""} ;
         BC00199_A403PermissionName = new String[] {""} ;
         BC00199_A404OrderIndex = new int[1] ;
         BC00199_A405SYS_PermissionDescription = new String[] {""} ;
         BC00199_n405SYS_PermissionDescription = new bool[] {false} ;
         BC00199_A406SYS_PermissionModuleCode = new String[] {""} ;
         BC00199_n406SYS_PermissionModuleCode = new bool[] {false} ;
         BC00199_A407SYS_PermissionIsDeleted = new short[1] ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.sys_permission_bc__datastore1(),
            new Object[][] {
                new Object[] {
               BC00192_A362PermissionCode, BC00192_A403PermissionName, BC00192_A404OrderIndex, BC00192_A405SYS_PermissionDescription, BC00192_n405SYS_PermissionDescription, BC00192_A406SYS_PermissionModuleCode, BC00192_n406SYS_PermissionModuleCode, BC00192_A407SYS_PermissionIsDeleted
               }
               , new Object[] {
               BC00193_A362PermissionCode, BC00193_A403PermissionName, BC00193_A404OrderIndex, BC00193_A405SYS_PermissionDescription, BC00193_n405SYS_PermissionDescription, BC00193_A406SYS_PermissionModuleCode, BC00193_n406SYS_PermissionModuleCode, BC00193_A407SYS_PermissionIsDeleted
               }
               , new Object[] {
               BC00194_A362PermissionCode, BC00194_A403PermissionName, BC00194_A404OrderIndex, BC00194_A405SYS_PermissionDescription, BC00194_n405SYS_PermissionDescription, BC00194_A406SYS_PermissionModuleCode, BC00194_n406SYS_PermissionModuleCode, BC00194_A407SYS_PermissionIsDeleted
               }
               , new Object[] {
               BC00195_A362PermissionCode
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC00199_A362PermissionCode, BC00199_A403PermissionName, BC00199_A404OrderIndex, BC00199_A405SYS_PermissionDescription, BC00199_n405SYS_PermissionDescription, BC00199_A406SYS_PermissionModuleCode, BC00199_n406SYS_PermissionModuleCode, BC00199_A407SYS_PermissionIsDeleted
               }
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.sys_permission_bc__default(),
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
      private short Z407SYS_PermissionIsDeleted ;
      private short A407SYS_PermissionIsDeleted ;
      private short RcdFound46 ;
      private int trnEnded ;
      private int Z404OrderIndex ;
      private int A404OrderIndex ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String sMode46 ;
      private bool n405SYS_PermissionDescription ;
      private bool n406SYS_PermissionModuleCode ;
      private String Z405SYS_PermissionDescription ;
      private String A405SYS_PermissionDescription ;
      private String Z362PermissionCode ;
      private String A362PermissionCode ;
      private String Z403PermissionName ;
      private String A403PermissionName ;
      private String Z406SYS_PermissionModuleCode ;
      private String A406SYS_PermissionModuleCode ;
      private SdtSYS_Permission bcSYS_Permission ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_datastore1 ;
      private String[] BC00194_A362PermissionCode ;
      private String[] BC00194_A403PermissionName ;
      private int[] BC00194_A404OrderIndex ;
      private String[] BC00194_A405SYS_PermissionDescription ;
      private bool[] BC00194_n405SYS_PermissionDescription ;
      private String[] BC00194_A406SYS_PermissionModuleCode ;
      private bool[] BC00194_n406SYS_PermissionModuleCode ;
      private short[] BC00194_A407SYS_PermissionIsDeleted ;
      private String[] BC00195_A362PermissionCode ;
      private String[] BC00193_A362PermissionCode ;
      private String[] BC00193_A403PermissionName ;
      private int[] BC00193_A404OrderIndex ;
      private String[] BC00193_A405SYS_PermissionDescription ;
      private bool[] BC00193_n405SYS_PermissionDescription ;
      private String[] BC00193_A406SYS_PermissionModuleCode ;
      private bool[] BC00193_n406SYS_PermissionModuleCode ;
      private short[] BC00193_A407SYS_PermissionIsDeleted ;
      private String[] BC00192_A362PermissionCode ;
      private String[] BC00192_A403PermissionName ;
      private int[] BC00192_A404OrderIndex ;
      private String[] BC00192_A405SYS_PermissionDescription ;
      private bool[] BC00192_n405SYS_PermissionDescription ;
      private String[] BC00192_A406SYS_PermissionModuleCode ;
      private bool[] BC00192_n406SYS_PermissionModuleCode ;
      private short[] BC00192_A407SYS_PermissionIsDeleted ;
      private String[] BC00199_A362PermissionCode ;
      private String[] BC00199_A403PermissionName ;
      private int[] BC00199_A404OrderIndex ;
      private String[] BC00199_A405SYS_PermissionDescription ;
      private bool[] BC00199_n405SYS_PermissionDescription ;
      private String[] BC00199_A406SYS_PermissionModuleCode ;
      private bool[] BC00199_n406SYS_PermissionModuleCode ;
      private short[] BC00199_A407SYS_PermissionIsDeleted ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_default ;
   }

   public class sys_permission_bc__datastore1 : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmBC00194 ;
          prmBC00194 = new Object[] {
          new Object[] {"@PermissionCode",SqlDbType.NVarChar,64,0}
          } ;
          Object[] prmBC00195 ;
          prmBC00195 = new Object[] {
          new Object[] {"@PermissionCode",SqlDbType.NVarChar,64,0}
          } ;
          Object[] prmBC00193 ;
          prmBC00193 = new Object[] {
          new Object[] {"@PermissionCode",SqlDbType.NVarChar,64,0}
          } ;
          Object[] prmBC00192 ;
          prmBC00192 = new Object[] {
          new Object[] {"@PermissionCode",SqlDbType.NVarChar,64,0}
          } ;
          Object[] prmBC00196 ;
          prmBC00196 = new Object[] {
          new Object[] {"@PermissionCode",SqlDbType.NVarChar,64,0} ,
          new Object[] {"@PermissionName",SqlDbType.NVarChar,64,0} ,
          new Object[] {"@OrderIndex",SqlDbType.Int,9,0} ,
          new Object[] {"@SYS_PermissionDescription",SqlDbType.NVarChar,2048,0} ,
          new Object[] {"@SYS_PermissionModuleCode",SqlDbType.NVarChar,32,0} ,
          new Object[] {"@SYS_PermissionIsDeleted",SqlDbType.SmallInt,1,0}
          } ;
          Object[] prmBC00197 ;
          prmBC00197 = new Object[] {
          new Object[] {"@PermissionName",SqlDbType.NVarChar,64,0} ,
          new Object[] {"@OrderIndex",SqlDbType.Int,9,0} ,
          new Object[] {"@SYS_PermissionDescription",SqlDbType.NVarChar,2048,0} ,
          new Object[] {"@SYS_PermissionModuleCode",SqlDbType.NVarChar,32,0} ,
          new Object[] {"@SYS_PermissionIsDeleted",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@PermissionCode",SqlDbType.NVarChar,64,0}
          } ;
          Object[] prmBC00198 ;
          prmBC00198 = new Object[] {
          new Object[] {"@PermissionCode",SqlDbType.NVarChar,64,0}
          } ;
          Object[] prmBC00199 ;
          prmBC00199 = new Object[] {
          new Object[] {"@PermissionCode",SqlDbType.NVarChar,64,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("BC00192", "SELECT [PermissionCode], [PermissionName], [OrderIndex], [SYS_PermissionDescription], [SYS_PermissionModuleCode], [SYS_PermissionIsDeleted] FROM dbo.[SYS_Permission] WITH (UPDLOCK) WHERE [PermissionCode] = @PermissionCode ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00192,1,0,true,false )
             ,new CursorDef("BC00193", "SELECT [PermissionCode], [PermissionName], [OrderIndex], [SYS_PermissionDescription], [SYS_PermissionModuleCode], [SYS_PermissionIsDeleted] FROM dbo.[SYS_Permission] WITH (NOLOCK) WHERE [PermissionCode] = @PermissionCode ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00193,1,0,true,false )
             ,new CursorDef("BC00194", "SELECT TM1.[PermissionCode], TM1.[PermissionName], TM1.[OrderIndex], TM1.[SYS_PermissionDescription], TM1.[SYS_PermissionModuleCode], TM1.[SYS_PermissionIsDeleted] FROM dbo.[SYS_Permission] TM1 WITH (NOLOCK) WHERE TM1.[PermissionCode] = @PermissionCode ORDER BY TM1.[PermissionCode]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00194,100,0,true,false )
             ,new CursorDef("BC00195", "SELECT [PermissionCode] FROM dbo.[SYS_Permission] WITH (NOLOCK) WHERE [PermissionCode] = @PermissionCode  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00195,1,0,true,false )
             ,new CursorDef("BC00196", "INSERT INTO dbo.[SYS_Permission]([PermissionCode], [PermissionName], [OrderIndex], [SYS_PermissionDescription], [SYS_PermissionModuleCode], [SYS_PermissionIsDeleted]) VALUES(@PermissionCode, @PermissionName, @OrderIndex, @SYS_PermissionDescription, @SYS_PermissionModuleCode, @SYS_PermissionIsDeleted)", GxErrorMask.GX_NOMASK,prmBC00196)
             ,new CursorDef("BC00197", "UPDATE dbo.[SYS_Permission] SET [PermissionName]=@PermissionName, [OrderIndex]=@OrderIndex, [SYS_PermissionDescription]=@SYS_PermissionDescription, [SYS_PermissionModuleCode]=@SYS_PermissionModuleCode, [SYS_PermissionIsDeleted]=@SYS_PermissionIsDeleted  WHERE [PermissionCode] = @PermissionCode", GxErrorMask.GX_NOMASK,prmBC00197)
             ,new CursorDef("BC00198", "DELETE FROM dbo.[SYS_Permission]  WHERE [PermissionCode] = @PermissionCode", GxErrorMask.GX_NOMASK,prmBC00198)
             ,new CursorDef("BC00199", "SELECT TM1.[PermissionCode], TM1.[PermissionName], TM1.[OrderIndex], TM1.[SYS_PermissionDescription], TM1.[SYS_PermissionModuleCode], TM1.[SYS_PermissionIsDeleted] FROM dbo.[SYS_Permission] TM1 WITH (NOLOCK) WHERE TM1.[PermissionCode] = @PermissionCode ORDER BY TM1.[PermissionCode]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00199,100,0,true,false )
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
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((String[]) buf[3])[0] = rslt.getLongVarchar(4) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                ((short[]) buf[7])[0] = rslt.getShort(6) ;
                return;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((String[]) buf[3])[0] = rslt.getLongVarchar(4) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                ((short[]) buf[7])[0] = rslt.getShort(6) ;
                return;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((String[]) buf[3])[0] = rslt.getLongVarchar(4) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                ((short[]) buf[7])[0] = rslt.getShort(6) ;
                return;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                return;
             case 7 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((String[]) buf[3])[0] = rslt.getLongVarchar(4) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                ((short[]) buf[7])[0] = rslt.getShort(6) ;
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
                return;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 3 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 4 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                if ( (bool)parms[3] )
                {
                   stmt.setNull( 4 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(4, (String)parms[4]);
                }
                if ( (bool)parms[5] )
                {
                   stmt.setNull( 5 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(5, (String)parms[6]);
                }
                stmt.SetParameter(6, (short)parms[7]);
                return;
             case 5 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                if ( (bool)parms[2] )
                {
                   stmt.setNull( 3 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(3, (String)parms[3]);
                }
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 4 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(4, (String)parms[5]);
                }
                stmt.SetParameter(5, (short)parms[6]);
                stmt.SetParameter(6, (String)parms[7]);
                return;
             case 6 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 7 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
       }
    }

    public String getDataStoreName( )
    {
       return "DATASTORE1";
    }

 }

 public class sys_permission_bc__default : DataStoreHelperBase, IDataStoreHelper
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
