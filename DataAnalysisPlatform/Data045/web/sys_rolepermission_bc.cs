/*
               File: SYS_RolePermission_BC
        Description: SYS_Role Permission
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:8:58.44
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
   public class sys_rolepermission_bc : GXHttpHandler, IGxSilentTrn
   {
      public sys_rolepermission_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public sys_rolepermission_bc( IGxContext context )
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
         ReadRow1G61( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey1G61( ) ;
         standaloneModal( ) ;
         AddRow1G61( ) ;
         Gx_mode = "INS";
         return  ;
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E111G2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               Z444SYS_RolePermissionRoleID = (Guid)(A444SYS_RolePermissionRoleID);
               Z445SYS_RolePermissionPermissionCode = A445SYS_RolePermissionPermissionCode;
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

      protected void CONFIRM_1G0( )
      {
         BeforeValidate1G61( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls1G61( ) ;
            }
            else
            {
               CheckExtendedTable1G61( ) ;
               if ( AnyError == 0 )
               {
               }
               CloseExtendedTableCursors1G61( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void E121G2( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV9WWPContext) ;
         AV10IsAuthorized = true;
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            GXt_boolean1 = AV10IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Role_Manager", out  GXt_boolean1) ;
            AV10IsAuthorized = GXt_boolean1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            GXt_boolean1 = AV10IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Role_Manager", out  GXt_boolean1) ;
            AV10IsAuthorized = GXt_boolean1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            GXt_boolean1 = AV10IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Role_Manager", out  GXt_boolean1) ;
            AV10IsAuthorized = GXt_boolean1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            GXt_boolean1 = AV10IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Role_Manager", out  GXt_boolean1) ;
            AV10IsAuthorized = GXt_boolean1;
         }
         if ( ! AV10IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV14Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV12TrnContext.FromXml(AV13WebSession.Get("TrnContext"), null, "WWPTransactionContext", "DataAnalysisPlatform");
      }

      protected void E111G2( )
      {
         /* After Trn Routine */
      }

      protected void ZM1G61( short GX_JID )
      {
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
         }
         if ( GX_JID == -3 )
         {
            Z444SYS_RolePermissionRoleID = (Guid)(A444SYS_RolePermissionRoleID);
            Z445SYS_RolePermissionPermissionCode = A445SYS_RolePermissionPermissionCode;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (Guid.Empty==A444SYS_RolePermissionRoleID) )
         {
            A444SYS_RolePermissionRoleID = (Guid)(Guid.NewGuid( ));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( Gx_BScreen == 0 ) )
         {
         }
      }

      protected void Load1G61( )
      {
         /* Using cursor BC001G4 */
         pr_datastore1.execute(2, new Object[] {A444SYS_RolePermissionRoleID, A445SYS_RolePermissionPermissionCode});
         if ( (pr_datastore1.getStatus(2) != 101) )
         {
            RcdFound61 = 1;
            ZM1G61( -3) ;
         }
         pr_datastore1.close(2);
         OnLoadActions1G61( ) ;
      }

      protected void OnLoadActions1G61( )
      {
         AV14Pgmname = "SYS_RolePermission_BC";
      }

      protected void CheckExtendedTable1G61( )
      {
         standaloneModal( ) ;
         AV14Pgmname = "SYS_RolePermission_BC";
      }

      protected void CloseExtendedTableCursors1G61( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey1G61( )
      {
         /* Using cursor BC001G5 */
         pr_datastore1.execute(3, new Object[] {A444SYS_RolePermissionRoleID, A445SYS_RolePermissionPermissionCode});
         if ( (pr_datastore1.getStatus(3) != 101) )
         {
            RcdFound61 = 1;
         }
         else
         {
            RcdFound61 = 0;
         }
         pr_datastore1.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC001G3 */
         pr_datastore1.execute(1, new Object[] {A444SYS_RolePermissionRoleID, A445SYS_RolePermissionPermissionCode});
         if ( (pr_datastore1.getStatus(1) != 101) )
         {
            ZM1G61( 3) ;
            RcdFound61 = 1;
            A444SYS_RolePermissionRoleID = (Guid)((Guid)(BC001G3_A444SYS_RolePermissionRoleID[0]));
            A445SYS_RolePermissionPermissionCode = BC001G3_A445SYS_RolePermissionPermissionCode[0];
            Z444SYS_RolePermissionRoleID = (Guid)(A444SYS_RolePermissionRoleID);
            Z445SYS_RolePermissionPermissionCode = A445SYS_RolePermissionPermissionCode;
            sMode61 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load1G61( ) ;
            if ( AnyError == 1 )
            {
               RcdFound61 = 0;
               InitializeNonKey1G61( ) ;
            }
            Gx_mode = sMode61;
         }
         else
         {
            RcdFound61 = 0;
            InitializeNonKey1G61( ) ;
            sMode61 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode61;
         }
         pr_datastore1.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1G61( ) ;
         if ( RcdFound61 == 0 )
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
         CONFIRM_1G0( ) ;
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

      protected void CheckOptimisticConcurrency1G61( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC001G2 */
            pr_datastore1.execute(0, new Object[] {A444SYS_RolePermissionRoleID, A445SYS_RolePermissionPermissionCode});
            if ( (pr_datastore1.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SYS_ROLEPERMISSION"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_datastore1.getStatus(0) == 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"SYS_ROLEPERMISSION"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert1G61( )
      {
         BeforeValidate1G61( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1G61( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1G61( 0) ;
            CheckOptimisticConcurrency1G61( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1G61( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1G61( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC001G6 */
                     pr_datastore1.execute(4, new Object[] {A445SYS_RolePermissionPermissionCode, A444SYS_RolePermissionRoleID});
                     pr_datastore1.close(4);
                     dsDataStore1.SmartCacheProvider.SetUpdated("SYS_ROLEPERMISSION") ;
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
               Load1G61( ) ;
            }
            EndLevel1G61( ) ;
         }
         CloseExtendedTableCursors1G61( ) ;
      }

      protected void Update1G61( )
      {
         BeforeValidate1G61( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1G61( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1G61( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1G61( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1G61( ) ;
                  if ( AnyError == 0 )
                  {
                     /* No attributes to update on table [SYS_RolePermission] */
                     DeferredUpdate1G61( ) ;
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
            EndLevel1G61( ) ;
         }
         CloseExtendedTableCursors1G61( ) ;
      }

      protected void DeferredUpdate1G61( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate1G61( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1G61( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1G61( ) ;
            AfterConfirm1G61( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1G61( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC001G7 */
                  pr_datastore1.execute(5, new Object[] {A444SYS_RolePermissionRoleID, A445SYS_RolePermissionPermissionCode});
                  pr_datastore1.close(5);
                  dsDataStore1.SmartCacheProvider.SetUpdated("SYS_ROLEPERMISSION") ;
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
         sMode61 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel1G61( ) ;
         Gx_mode = sMode61;
      }

      protected void OnDeleteControls1G61( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV14Pgmname = "SYS_RolePermission_BC";
         }
      }

      protected void EndLevel1G61( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_datastore1.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1G61( ) ;
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

      public void ScanKeyStart1G61( )
      {
         /* Scan By routine */
         /* Using cursor BC001G8 */
         pr_datastore1.execute(6, new Object[] {A444SYS_RolePermissionRoleID, A445SYS_RolePermissionPermissionCode});
         RcdFound61 = 0;
         if ( (pr_datastore1.getStatus(6) != 101) )
         {
            RcdFound61 = 1;
            A444SYS_RolePermissionRoleID = (Guid)((Guid)(BC001G8_A444SYS_RolePermissionRoleID[0]));
            A445SYS_RolePermissionPermissionCode = BC001G8_A445SYS_RolePermissionPermissionCode[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext1G61( )
      {
         /* Scan next routine */
         pr_datastore1.readNext(6);
         RcdFound61 = 0;
         ScanKeyLoad1G61( ) ;
      }

      protected void ScanKeyLoad1G61( )
      {
         sMode61 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_datastore1.getStatus(6) != 101) )
         {
            RcdFound61 = 1;
            A444SYS_RolePermissionRoleID = (Guid)((Guid)(BC001G8_A444SYS_RolePermissionRoleID[0]));
            A445SYS_RolePermissionPermissionCode = BC001G8_A445SYS_RolePermissionPermissionCode[0];
         }
         Gx_mode = sMode61;
      }

      protected void ScanKeyEnd1G61( )
      {
         pr_datastore1.close(6);
      }

      protected void AfterConfirm1G61( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1G61( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1G61( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1G61( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1G61( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1G61( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1G61( )
      {
      }

      protected void send_integrity_lvl_hashes1G61( )
      {
      }

      protected void AddRow1G61( )
      {
         VarsToRow61( bcSYS_RolePermission) ;
      }

      protected void ReadRow1G61( )
      {
         RowToVars61( bcSYS_RolePermission, 1) ;
      }

      protected void InitializeNonKey1G61( )
      {
      }

      protected void InitAll1G61( )
      {
         A444SYS_RolePermissionRoleID = (Guid)(Guid.NewGuid( ));
         A445SYS_RolePermissionPermissionCode = "";
         InitializeNonKey1G61( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow61( SdtSYS_RolePermission obj61 )
      {
         obj61.gxTpr_Mode = Gx_mode;
         obj61.gxTpr_Sys_rolepermissionroleid = (Guid)(A444SYS_RolePermissionRoleID);
         obj61.gxTpr_Sys_rolepermissionpermissioncode = A445SYS_RolePermissionPermissionCode;
         obj61.gxTpr_Sys_rolepermissionroleid_Z = (Guid)(Z444SYS_RolePermissionRoleID);
         obj61.gxTpr_Sys_rolepermissionpermissioncode_Z = Z445SYS_RolePermissionPermissionCode;
         obj61.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow61( SdtSYS_RolePermission obj61 )
      {
         obj61.gxTpr_Sys_rolepermissionroleid = (Guid)(A444SYS_RolePermissionRoleID);
         obj61.gxTpr_Sys_rolepermissionpermissioncode = A445SYS_RolePermissionPermissionCode;
         return  ;
      }

      public void RowToVars61( SdtSYS_RolePermission obj61 ,
                               int forceLoad )
      {
         Gx_mode = obj61.gxTpr_Mode;
         A444SYS_RolePermissionRoleID = (Guid)(obj61.gxTpr_Sys_rolepermissionroleid);
         A445SYS_RolePermissionPermissionCode = obj61.gxTpr_Sys_rolepermissionpermissioncode;
         Z444SYS_RolePermissionRoleID = (Guid)(obj61.gxTpr_Sys_rolepermissionroleid_Z);
         Z445SYS_RolePermissionPermissionCode = obj61.gxTpr_Sys_rolepermissionpermissioncode_Z;
         Gx_mode = obj61.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A444SYS_RolePermissionRoleID = (Guid)((Guid)getParm(obj,0));
         A445SYS_RolePermissionPermissionCode = (String)getParm(obj,1);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey1G61( ) ;
         ScanKeyStart1G61( ) ;
         if ( RcdFound61 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z444SYS_RolePermissionRoleID = (Guid)(A444SYS_RolePermissionRoleID);
            Z445SYS_RolePermissionPermissionCode = A445SYS_RolePermissionPermissionCode;
         }
         ZM1G61( -3) ;
         OnLoadActions1G61( ) ;
         AddRow1G61( ) ;
         ScanKeyEnd1G61( ) ;
         if ( RcdFound61 == 0 )
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
         RowToVars61( bcSYS_RolePermission, 0) ;
         ScanKeyStart1G61( ) ;
         if ( RcdFound61 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z444SYS_RolePermissionRoleID = (Guid)(A444SYS_RolePermissionRoleID);
            Z445SYS_RolePermissionPermissionCode = A445SYS_RolePermissionPermissionCode;
         }
         ZM1G61( -3) ;
         OnLoadActions1G61( ) ;
         AddRow1G61( ) ;
         ScanKeyEnd1G61( ) ;
         if ( RcdFound61 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey1G61( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert1G61( ) ;
         }
         else
         {
            if ( RcdFound61 == 1 )
            {
               if ( ( A444SYS_RolePermissionRoleID != Z444SYS_RolePermissionRoleID ) || ( StringUtil.StrCmp(A445SYS_RolePermissionPermissionCode, Z445SYS_RolePermissionPermissionCode) != 0 ) )
               {
                  A444SYS_RolePermissionRoleID = (Guid)(Z444SYS_RolePermissionRoleID);
                  A445SYS_RolePermissionPermissionCode = Z445SYS_RolePermissionPermissionCode;
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
                  Update1G61( ) ;
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
                  if ( ( A444SYS_RolePermissionRoleID != Z444SYS_RolePermissionRoleID ) || ( StringUtil.StrCmp(A445SYS_RolePermissionPermissionCode, Z445SYS_RolePermissionPermissionCode) != 0 ) )
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
                        Insert1G61( ) ;
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
                        Insert1G61( ) ;
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
         RowToVars61( bcSYS_RolePermission, 0) ;
         SaveImpl( ) ;
         VarsToRow61( bcSYS_RolePermission) ;
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
         RowToVars61( bcSYS_RolePermission, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert1G61( ) ;
         AfterTrn( ) ;
         VarsToRow61( bcSYS_RolePermission) ;
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
            SdtSYS_RolePermission auxBC = new SdtSYS_RolePermission(context) ;
            auxBC.Load(A444SYS_RolePermissionRoleID, A445SYS_RolePermissionPermissionCode);
            auxBC.UpdateDirties(bcSYS_RolePermission);
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
         RowToVars61( bcSYS_RolePermission, 0) ;
         UpdateImpl( ) ;
         VarsToRow61( bcSYS_RolePermission) ;
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
         RowToVars61( bcSYS_RolePermission, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert1G61( ) ;
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
         VarsToRow61( bcSYS_RolePermission) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars61( bcSYS_RolePermission, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey1G61( ) ;
         if ( RcdFound61 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( ( A444SYS_RolePermissionRoleID != Z444SYS_RolePermissionRoleID ) || ( StringUtil.StrCmp(A445SYS_RolePermissionPermissionCode, Z445SYS_RolePermissionPermissionCode) != 0 ) )
            {
               A444SYS_RolePermissionRoleID = (Guid)(Z444SYS_RolePermissionRoleID);
               A445SYS_RolePermissionPermissionCode = Z445SYS_RolePermissionPermissionCode;
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
            if ( ( A444SYS_RolePermissionRoleID != Z444SYS_RolePermissionRoleID ) || ( StringUtil.StrCmp(A445SYS_RolePermissionPermissionCode, Z445SYS_RolePermissionPermissionCode) != 0 ) )
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
         context.RollbackDataStores("sys_rolepermission_bc",pr_default);
         VarsToRow61( bcSYS_RolePermission) ;
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
         Gx_mode = bcSYS_RolePermission.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcSYS_RolePermission.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcSYS_RolePermission )
         {
            bcSYS_RolePermission = (SdtSYS_RolePermission)(sdt);
            if ( StringUtil.StrCmp(bcSYS_RolePermission.gxTpr_Mode, "") == 0 )
            {
               bcSYS_RolePermission.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow61( bcSYS_RolePermission) ;
            }
            else
            {
               RowToVars61( bcSYS_RolePermission, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcSYS_RolePermission.gxTpr_Mode, "") == 0 )
            {
               bcSYS_RolePermission.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars61( bcSYS_RolePermission, 1) ;
         return  ;
      }

      public SdtSYS_RolePermission SYS_RolePermission_BC
      {
         get {
            return bcSYS_RolePermission ;
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
         Z444SYS_RolePermissionRoleID = (Guid)(Guid.Empty);
         A444SYS_RolePermissionRoleID = (Guid)(Guid.Empty);
         Z445SYS_RolePermissionPermissionCode = "";
         A445SYS_RolePermissionPermissionCode = "";
         AV9WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV14Pgmname = "";
         AV12TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV13WebSession = context.GetSession();
         BC001G4_A444SYS_RolePermissionRoleID = new Guid[] {Guid.Empty} ;
         BC001G4_A445SYS_RolePermissionPermissionCode = new String[] {""} ;
         BC001G5_A444SYS_RolePermissionRoleID = new Guid[] {Guid.Empty} ;
         BC001G5_A445SYS_RolePermissionPermissionCode = new String[] {""} ;
         BC001G3_A444SYS_RolePermissionRoleID = new Guid[] {Guid.Empty} ;
         BC001G3_A445SYS_RolePermissionPermissionCode = new String[] {""} ;
         sMode61 = "";
         BC001G2_A444SYS_RolePermissionRoleID = new Guid[] {Guid.Empty} ;
         BC001G2_A445SYS_RolePermissionPermissionCode = new String[] {""} ;
         BC001G8_A444SYS_RolePermissionRoleID = new Guid[] {Guid.Empty} ;
         BC001G8_A445SYS_RolePermissionPermissionCode = new String[] {""} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.sys_rolepermission_bc__datastore1(),
            new Object[][] {
                new Object[] {
               BC001G2_A444SYS_RolePermissionRoleID, BC001G2_A445SYS_RolePermissionPermissionCode
               }
               , new Object[] {
               BC001G3_A444SYS_RolePermissionRoleID, BC001G3_A445SYS_RolePermissionPermissionCode
               }
               , new Object[] {
               BC001G4_A444SYS_RolePermissionRoleID, BC001G4_A445SYS_RolePermissionPermissionCode
               }
               , new Object[] {
               BC001G5_A444SYS_RolePermissionRoleID, BC001G5_A445SYS_RolePermissionPermissionCode
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC001G8_A444SYS_RolePermissionRoleID, BC001G8_A445SYS_RolePermissionPermissionCode
               }
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.sys_rolepermission_bc__default(),
            new Object[][] {
            }
         );
         Z444SYS_RolePermissionRoleID = (Guid)(Guid.NewGuid( ));
         A444SYS_RolePermissionRoleID = (Guid)(Guid.NewGuid( ));
         AV14Pgmname = "SYS_RolePermission_BC";
         INITTRN();
         /* Execute Start event if defined. */
         /* Execute user event: Start */
         E121G2 ();
         standaloneNotModal( ) ;
      }

      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short RcdFound61 ;
      private int trnEnded ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String AV14Pgmname ;
      private String sMode61 ;
      private bool AV10IsAuthorized ;
      private bool GXt_boolean1 ;
      private String Z445SYS_RolePermissionPermissionCode ;
      private String A445SYS_RolePermissionPermissionCode ;
      private Guid Z444SYS_RolePermissionRoleID ;
      private Guid A444SYS_RolePermissionRoleID ;
      private IGxSession AV13WebSession ;
      private SdtSYS_RolePermission bcSYS_RolePermission ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_datastore1 ;
      private Guid[] BC001G4_A444SYS_RolePermissionRoleID ;
      private String[] BC001G4_A445SYS_RolePermissionPermissionCode ;
      private Guid[] BC001G5_A444SYS_RolePermissionRoleID ;
      private String[] BC001G5_A445SYS_RolePermissionPermissionCode ;
      private Guid[] BC001G3_A444SYS_RolePermissionRoleID ;
      private String[] BC001G3_A445SYS_RolePermissionPermissionCode ;
      private Guid[] BC001G2_A444SYS_RolePermissionRoleID ;
      private String[] BC001G2_A445SYS_RolePermissionPermissionCode ;
      private Guid[] BC001G8_A444SYS_RolePermissionRoleID ;
      private String[] BC001G8_A445SYS_RolePermissionPermissionCode ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_default ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV9WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV12TrnContext ;
   }

   public class sys_rolepermission_bc__datastore1 : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[6])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmBC001G4 ;
          prmBC001G4 = new Object[] {
          new Object[] {"@SYS_RolePermissionRoleID",SqlDbType.UniqueIdentifier,16,0} ,
          new Object[] {"@SYS_RolePermissionPermissionCode",SqlDbType.NVarChar,64,0}
          } ;
          Object[] prmBC001G5 ;
          prmBC001G5 = new Object[] {
          new Object[] {"@SYS_RolePermissionRoleID",SqlDbType.UniqueIdentifier,16,0} ,
          new Object[] {"@SYS_RolePermissionPermissionCode",SqlDbType.NVarChar,64,0}
          } ;
          Object[] prmBC001G3 ;
          prmBC001G3 = new Object[] {
          new Object[] {"@SYS_RolePermissionRoleID",SqlDbType.UniqueIdentifier,16,0} ,
          new Object[] {"@SYS_RolePermissionPermissionCode",SqlDbType.NVarChar,64,0}
          } ;
          Object[] prmBC001G2 ;
          prmBC001G2 = new Object[] {
          new Object[] {"@SYS_RolePermissionRoleID",SqlDbType.UniqueIdentifier,16,0} ,
          new Object[] {"@SYS_RolePermissionPermissionCode",SqlDbType.NVarChar,64,0}
          } ;
          Object[] prmBC001G6 ;
          prmBC001G6 = new Object[] {
          new Object[] {"@SYS_RolePermissionPermissionCode",SqlDbType.NVarChar,64,0} ,
          new Object[] {"@SYS_RolePermissionRoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC001G7 ;
          prmBC001G7 = new Object[] {
          new Object[] {"@SYS_RolePermissionRoleID",SqlDbType.UniqueIdentifier,16,0} ,
          new Object[] {"@SYS_RolePermissionPermissionCode",SqlDbType.NVarChar,64,0}
          } ;
          Object[] prmBC001G8 ;
          prmBC001G8 = new Object[] {
          new Object[] {"@SYS_RolePermissionRoleID",SqlDbType.UniqueIdentifier,16,0} ,
          new Object[] {"@SYS_RolePermissionPermissionCode",SqlDbType.NVarChar,64,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("BC001G2", "SELECT [RoleID], [PermissionCode] FROM [SYS_RolePermission] WITH (UPDLOCK) WHERE [RoleID] = @SYS_RolePermissionRoleID AND [PermissionCode] = @SYS_RolePermissionPermissionCode ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001G2,1,0,true,false )
             ,new CursorDef("BC001G3", "SELECT [RoleID], [PermissionCode] FROM [SYS_RolePermission] WITH (NOLOCK) WHERE [RoleID] = @SYS_RolePermissionRoleID AND [PermissionCode] = @SYS_RolePermissionPermissionCode ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001G3,1,0,true,false )
             ,new CursorDef("BC001G4", "SELECT TM1.[RoleID], TM1.[PermissionCode] FROM [SYS_RolePermission] TM1 WITH (NOLOCK) WHERE TM1.[RoleID] = @SYS_RolePermissionRoleID and TM1.[PermissionCode] = @SYS_RolePermissionPermissionCode ORDER BY TM1.[RoleID], TM1.[PermissionCode]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001G4,100,0,true,false )
             ,new CursorDef("BC001G5", "SELECT [RoleID], [PermissionCode] FROM [SYS_RolePermission] WITH (NOLOCK) WHERE [RoleID] = @SYS_RolePermissionRoleID AND [PermissionCode] = @SYS_RolePermissionPermissionCode  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001G5,1,0,true,false )
             ,new CursorDef("BC001G6", "INSERT INTO [SYS_RolePermission]([PermissionCode], [RoleID]) VALUES(@SYS_RolePermissionPermissionCode, @SYS_RolePermissionRoleID)", GxErrorMask.GX_NOMASK,prmBC001G6)
             ,new CursorDef("BC001G7", "DELETE FROM [SYS_RolePermission]  WHERE [RoleID] = @SYS_RolePermissionRoleID AND [PermissionCode] = @SYS_RolePermissionPermissionCode", GxErrorMask.GX_NOMASK,prmBC001G7)
             ,new CursorDef("BC001G8", "SELECT TM1.[RoleID], TM1.[PermissionCode] FROM [SYS_RolePermission] TM1 WITH (NOLOCK) WHERE TM1.[RoleID] = @SYS_RolePermissionRoleID and TM1.[PermissionCode] = @SYS_RolePermissionPermissionCode ORDER BY TM1.[RoleID], TM1.[PermissionCode]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001G8,100,0,true,false )
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
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                return;
             case 1 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                return;
             case 2 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                return;
             case 3 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                return;
             case 6 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
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
                stmt.SetParameter(2, (String)parms[1]);
                return;
             case 1 :
                stmt.SetParameter(1, (Guid)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
             case 2 :
                stmt.SetParameter(1, (Guid)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
             case 3 :
                stmt.SetParameter(1, (Guid)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
             case 4 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (Guid)parms[1]);
                return;
             case 5 :
                stmt.SetParameter(1, (Guid)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
             case 6 :
                stmt.SetParameter(1, (Guid)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
       }
    }

    public String getDataStoreName( )
    {
       return "DATASTORE1";
    }

 }

 public class sys_rolepermission_bc__default : DataStoreHelperBase, IDataStoreHelper
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
