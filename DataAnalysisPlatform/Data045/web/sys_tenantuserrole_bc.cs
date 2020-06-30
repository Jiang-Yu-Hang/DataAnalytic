/*
               File: SYS_TenantUserRole_BC
        Description: SYS_Tenant User Role
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:9:0.3
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
   public class sys_tenantuserrole_bc : GXHttpHandler, IGxSilentTrn
   {
      public sys_tenantuserrole_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public sys_tenantuserrole_bc( IGxContext context )
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
         ReadRow1J56( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey1J56( ) ;
         standaloneModal( ) ;
         AddRow1J56( ) ;
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
               Z370SYS_TenantUserRoleUserRoleID = (Guid)(A370SYS_TenantUserRoleUserRoleID);
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

      protected void CONFIRM_1J0( )
      {
         BeforeValidate1J56( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls1J56( ) ;
            }
            else
            {
               CheckExtendedTable1J56( ) ;
               if ( AnyError == 0 )
               {
               }
               CloseExtendedTableCursors1J56( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void ZM1J56( short GX_JID )
      {
         if ( ( GX_JID == 7 ) || ( GX_JID == 0 ) )
         {
            Z434SYS_TenantUserRoleRoleID = (Guid)(A434SYS_TenantUserRoleRoleID);
            Z433SYS_TenantUserRoleUserID = (Guid)(A433SYS_TenantUserRoleUserID);
            Z441SYS_TenantUserRoleTenantCode = A441SYS_TenantUserRoleTenantCode;
         }
         if ( GX_JID == -7 )
         {
            Z370SYS_TenantUserRoleUserRoleID = (Guid)(A370SYS_TenantUserRoleUserRoleID);
            Z434SYS_TenantUserRoleRoleID = (Guid)(A434SYS_TenantUserRoleRoleID);
            Z433SYS_TenantUserRoleUserID = (Guid)(A433SYS_TenantUserRoleUserID);
            Z441SYS_TenantUserRoleTenantCode = A441SYS_TenantUserRoleTenantCode;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (Guid.Empty==A434SYS_TenantUserRoleRoleID) )
         {
            A434SYS_TenantUserRoleRoleID = (Guid)(Guid.NewGuid( ));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (Guid.Empty==A433SYS_TenantUserRoleUserID) )
         {
            A433SYS_TenantUserRoleUserID = (Guid)(Guid.NewGuid( ));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (Guid.Empty==A370SYS_TenantUserRoleUserRoleID) )
         {
            A370SYS_TenantUserRoleUserRoleID = (Guid)(Guid.NewGuid( ));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( Gx_BScreen == 0 ) )
         {
         }
      }

      protected void Load1J56( )
      {
         /* Using cursor BC001J4 */
         pr_datastore1.execute(2, new Object[] {A370SYS_TenantUserRoleUserRoleID});
         if ( (pr_datastore1.getStatus(2) != 101) )
         {
            RcdFound56 = 1;
            A434SYS_TenantUserRoleRoleID = (Guid)((Guid)(BC001J4_A434SYS_TenantUserRoleRoleID[0]));
            A433SYS_TenantUserRoleUserID = (Guid)((Guid)(BC001J4_A433SYS_TenantUserRoleUserID[0]));
            A441SYS_TenantUserRoleTenantCode = BC001J4_A441SYS_TenantUserRoleTenantCode[0];
            ZM1J56( -7) ;
         }
         pr_datastore1.close(2);
         OnLoadActions1J56( ) ;
      }

      protected void OnLoadActions1J56( )
      {
      }

      protected void CheckExtendedTable1J56( )
      {
         standaloneModal( ) ;
      }

      protected void CloseExtendedTableCursors1J56( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey1J56( )
      {
         /* Using cursor BC001J5 */
         pr_datastore1.execute(3, new Object[] {A370SYS_TenantUserRoleUserRoleID});
         if ( (pr_datastore1.getStatus(3) != 101) )
         {
            RcdFound56 = 1;
         }
         else
         {
            RcdFound56 = 0;
         }
         pr_datastore1.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC001J3 */
         pr_datastore1.execute(1, new Object[] {A370SYS_TenantUserRoleUserRoleID});
         if ( (pr_datastore1.getStatus(1) != 101) )
         {
            ZM1J56( 7) ;
            RcdFound56 = 1;
            A370SYS_TenantUserRoleUserRoleID = (Guid)((Guid)(BC001J3_A370SYS_TenantUserRoleUserRoleID[0]));
            A434SYS_TenantUserRoleRoleID = (Guid)((Guid)(BC001J3_A434SYS_TenantUserRoleRoleID[0]));
            A433SYS_TenantUserRoleUserID = (Guid)((Guid)(BC001J3_A433SYS_TenantUserRoleUserID[0]));
            A441SYS_TenantUserRoleTenantCode = BC001J3_A441SYS_TenantUserRoleTenantCode[0];
            Z370SYS_TenantUserRoleUserRoleID = (Guid)(A370SYS_TenantUserRoleUserRoleID);
            sMode56 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load1J56( ) ;
            if ( AnyError == 1 )
            {
               RcdFound56 = 0;
               InitializeNonKey1J56( ) ;
            }
            Gx_mode = sMode56;
         }
         else
         {
            RcdFound56 = 0;
            InitializeNonKey1J56( ) ;
            sMode56 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode56;
         }
         pr_datastore1.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1J56( ) ;
         if ( RcdFound56 == 0 )
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
         CONFIRM_1J0( ) ;
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

      protected void CheckOptimisticConcurrency1J56( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC001J2 */
            pr_datastore1.execute(0, new Object[] {A370SYS_TenantUserRoleUserRoleID});
            if ( (pr_datastore1.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SYS_TENANTUSERROLE"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_datastore1.getStatus(0) == 101) || ( Z434SYS_TenantUserRoleRoleID != BC001J2_A434SYS_TenantUserRoleRoleID[0] ) || ( Z433SYS_TenantUserRoleUserID != BC001J2_A433SYS_TenantUserRoleUserID[0] ) || ( StringUtil.StrCmp(Z441SYS_TenantUserRoleTenantCode, BC001J2_A441SYS_TenantUserRoleTenantCode[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"SYS_TENANTUSERROLE"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert1J56( )
      {
         BeforeValidate1J56( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1J56( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1J56( 0) ;
            CheckOptimisticConcurrency1J56( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1J56( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1J56( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC001J6 */
                     pr_datastore1.execute(4, new Object[] {A441SYS_TenantUserRoleTenantCode, A370SYS_TenantUserRoleUserRoleID, A434SYS_TenantUserRoleRoleID, A433SYS_TenantUserRoleUserID});
                     pr_datastore1.close(4);
                     dsDataStore1.SmartCacheProvider.SetUpdated("SYS_TENANTUSERROLE") ;
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
               Load1J56( ) ;
            }
            EndLevel1J56( ) ;
         }
         CloseExtendedTableCursors1J56( ) ;
      }

      protected void Update1J56( )
      {
         BeforeValidate1J56( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1J56( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1J56( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1J56( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1J56( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC001J7 */
                     pr_datastore1.execute(5, new Object[] {A434SYS_TenantUserRoleRoleID, A433SYS_TenantUserRoleUserID, A441SYS_TenantUserRoleTenantCode, A370SYS_TenantUserRoleUserRoleID});
                     pr_datastore1.close(5);
                     dsDataStore1.SmartCacheProvider.SetUpdated("SYS_TENANTUSERROLE") ;
                     if ( (pr_datastore1.getStatus(5) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SYS_TENANTUSERROLE"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate1J56( ) ;
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
            EndLevel1J56( ) ;
         }
         CloseExtendedTableCursors1J56( ) ;
      }

      protected void DeferredUpdate1J56( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate1J56( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1J56( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1J56( ) ;
            AfterConfirm1J56( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1J56( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC001J8 */
                  pr_datastore1.execute(6, new Object[] {A370SYS_TenantUserRoleUserRoleID});
                  pr_datastore1.close(6);
                  dsDataStore1.SmartCacheProvider.SetUpdated("SYS_TENANTUSERROLE") ;
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
         sMode56 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel1J56( ) ;
         Gx_mode = sMode56;
      }

      protected void OnDeleteControls1J56( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel1J56( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_datastore1.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1J56( ) ;
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

      public void ScanKeyStart1J56( )
      {
         /* Using cursor BC001J9 */
         pr_datastore1.execute(7, new Object[] {A370SYS_TenantUserRoleUserRoleID});
         RcdFound56 = 0;
         if ( (pr_datastore1.getStatus(7) != 101) )
         {
            RcdFound56 = 1;
            A370SYS_TenantUserRoleUserRoleID = (Guid)((Guid)(BC001J9_A370SYS_TenantUserRoleUserRoleID[0]));
            A434SYS_TenantUserRoleRoleID = (Guid)((Guid)(BC001J9_A434SYS_TenantUserRoleRoleID[0]));
            A433SYS_TenantUserRoleUserID = (Guid)((Guid)(BC001J9_A433SYS_TenantUserRoleUserID[0]));
            A441SYS_TenantUserRoleTenantCode = BC001J9_A441SYS_TenantUserRoleTenantCode[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext1J56( )
      {
         /* Scan next routine */
         pr_datastore1.readNext(7);
         RcdFound56 = 0;
         ScanKeyLoad1J56( ) ;
      }

      protected void ScanKeyLoad1J56( )
      {
         sMode56 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_datastore1.getStatus(7) != 101) )
         {
            RcdFound56 = 1;
            A370SYS_TenantUserRoleUserRoleID = (Guid)((Guid)(BC001J9_A370SYS_TenantUserRoleUserRoleID[0]));
            A434SYS_TenantUserRoleRoleID = (Guid)((Guid)(BC001J9_A434SYS_TenantUserRoleRoleID[0]));
            A433SYS_TenantUserRoleUserID = (Guid)((Guid)(BC001J9_A433SYS_TenantUserRoleUserID[0]));
            A441SYS_TenantUserRoleTenantCode = BC001J9_A441SYS_TenantUserRoleTenantCode[0];
         }
         Gx_mode = sMode56;
      }

      protected void ScanKeyEnd1J56( )
      {
         pr_datastore1.close(7);
      }

      protected void AfterConfirm1J56( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1J56( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1J56( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1J56( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1J56( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1J56( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1J56( )
      {
      }

      protected void send_integrity_lvl_hashes1J56( )
      {
      }

      protected void AddRow1J56( )
      {
         VarsToRow56( bcSYS_TenantUserRole) ;
      }

      protected void ReadRow1J56( )
      {
         RowToVars56( bcSYS_TenantUserRole, 1) ;
      }

      protected void InitializeNonKey1J56( )
      {
         A441SYS_TenantUserRoleTenantCode = "";
         A434SYS_TenantUserRoleRoleID = (Guid)(Guid.NewGuid( ));
         A433SYS_TenantUserRoleUserID = (Guid)(Guid.NewGuid( ));
         Z434SYS_TenantUserRoleRoleID = (Guid)(Guid.Empty);
         Z433SYS_TenantUserRoleUserID = (Guid)(Guid.Empty);
         Z441SYS_TenantUserRoleTenantCode = "";
      }

      protected void InitAll1J56( )
      {
         A370SYS_TenantUserRoleUserRoleID = (Guid)(Guid.NewGuid( ));
         InitializeNonKey1J56( ) ;
      }

      protected void StandaloneModalInsert( )
      {
         A434SYS_TenantUserRoleRoleID = (Guid)(i434SYS_TenantUserRoleRoleID);
         A433SYS_TenantUserRoleUserID = (Guid)(i433SYS_TenantUserRoleUserID);
      }

      public void VarsToRow56( SdtSYS_TenantUserRole obj56 )
      {
         obj56.gxTpr_Mode = Gx_mode;
         obj56.gxTpr_Sys_tenantuserroletenantcode = A441SYS_TenantUserRoleTenantCode;
         obj56.gxTpr_Sys_tenantuserroleroleid = (Guid)(A434SYS_TenantUserRoleRoleID);
         obj56.gxTpr_Sys_tenantuserroleuserid = (Guid)(A433SYS_TenantUserRoleUserID);
         obj56.gxTpr_Sys_tenantuserroleuserroleid = (Guid)(A370SYS_TenantUserRoleUserRoleID);
         obj56.gxTpr_Sys_tenantuserroleuserroleid_Z = (Guid)(Z370SYS_TenantUserRoleUserRoleID);
         obj56.gxTpr_Sys_tenantuserroleuserid_Z = (Guid)(Z433SYS_TenantUserRoleUserID);
         obj56.gxTpr_Sys_tenantuserroletenantcode_Z = Z441SYS_TenantUserRoleTenantCode;
         obj56.gxTpr_Sys_tenantuserroleroleid_Z = (Guid)(Z434SYS_TenantUserRoleRoleID);
         obj56.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow56( SdtSYS_TenantUserRole obj56 )
      {
         obj56.gxTpr_Sys_tenantuserroleuserroleid = (Guid)(A370SYS_TenantUserRoleUserRoleID);
         return  ;
      }

      public void RowToVars56( SdtSYS_TenantUserRole obj56 ,
                               int forceLoad )
      {
         Gx_mode = obj56.gxTpr_Mode;
         A441SYS_TenantUserRoleTenantCode = obj56.gxTpr_Sys_tenantuserroletenantcode;
         A434SYS_TenantUserRoleRoleID = (Guid)(obj56.gxTpr_Sys_tenantuserroleroleid);
         A433SYS_TenantUserRoleUserID = (Guid)(obj56.gxTpr_Sys_tenantuserroleuserid);
         A370SYS_TenantUserRoleUserRoleID = (Guid)(obj56.gxTpr_Sys_tenantuserroleuserroleid);
         Z370SYS_TenantUserRoleUserRoleID = (Guid)(obj56.gxTpr_Sys_tenantuserroleuserroleid_Z);
         Z433SYS_TenantUserRoleUserID = (Guid)(obj56.gxTpr_Sys_tenantuserroleuserid_Z);
         Z441SYS_TenantUserRoleTenantCode = obj56.gxTpr_Sys_tenantuserroletenantcode_Z;
         Z434SYS_TenantUserRoleRoleID = (Guid)(obj56.gxTpr_Sys_tenantuserroleroleid_Z);
         Gx_mode = obj56.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A370SYS_TenantUserRoleUserRoleID = (Guid)((Guid)getParm(obj,0));
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey1J56( ) ;
         ScanKeyStart1J56( ) ;
         if ( RcdFound56 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z370SYS_TenantUserRoleUserRoleID = (Guid)(A370SYS_TenantUserRoleUserRoleID);
         }
         ZM1J56( -7) ;
         OnLoadActions1J56( ) ;
         AddRow1J56( ) ;
         ScanKeyEnd1J56( ) ;
         if ( RcdFound56 == 0 )
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
         RowToVars56( bcSYS_TenantUserRole, 0) ;
         ScanKeyStart1J56( ) ;
         if ( RcdFound56 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z370SYS_TenantUserRoleUserRoleID = (Guid)(A370SYS_TenantUserRoleUserRoleID);
         }
         ZM1J56( -7) ;
         OnLoadActions1J56( ) ;
         AddRow1J56( ) ;
         ScanKeyEnd1J56( ) ;
         if ( RcdFound56 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey1J56( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert1J56( ) ;
         }
         else
         {
            if ( RcdFound56 == 1 )
            {
               if ( A370SYS_TenantUserRoleUserRoleID != Z370SYS_TenantUserRoleUserRoleID )
               {
                  A370SYS_TenantUserRoleUserRoleID = (Guid)(Z370SYS_TenantUserRoleUserRoleID);
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
                  Update1J56( ) ;
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
                  if ( A370SYS_TenantUserRoleUserRoleID != Z370SYS_TenantUserRoleUserRoleID )
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
                        Insert1J56( ) ;
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
                        Insert1J56( ) ;
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
         RowToVars56( bcSYS_TenantUserRole, 0) ;
         SaveImpl( ) ;
         VarsToRow56( bcSYS_TenantUserRole) ;
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
         RowToVars56( bcSYS_TenantUserRole, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert1J56( ) ;
         AfterTrn( ) ;
         VarsToRow56( bcSYS_TenantUserRole) ;
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
            SdtSYS_TenantUserRole auxBC = new SdtSYS_TenantUserRole(context) ;
            auxBC.Load(A370SYS_TenantUserRoleUserRoleID);
            auxBC.UpdateDirties(bcSYS_TenantUserRole);
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
         RowToVars56( bcSYS_TenantUserRole, 0) ;
         UpdateImpl( ) ;
         VarsToRow56( bcSYS_TenantUserRole) ;
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
         RowToVars56( bcSYS_TenantUserRole, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert1J56( ) ;
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
         VarsToRow56( bcSYS_TenantUserRole) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars56( bcSYS_TenantUserRole, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey1J56( ) ;
         if ( RcdFound56 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A370SYS_TenantUserRoleUserRoleID != Z370SYS_TenantUserRoleUserRoleID )
            {
               A370SYS_TenantUserRoleUserRoleID = (Guid)(Z370SYS_TenantUserRoleUserRoleID);
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
            if ( A370SYS_TenantUserRoleUserRoleID != Z370SYS_TenantUserRoleUserRoleID )
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
         context.RollbackDataStores("sys_tenantuserrole_bc",pr_default);
         VarsToRow56( bcSYS_TenantUserRole) ;
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
         Gx_mode = bcSYS_TenantUserRole.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcSYS_TenantUserRole.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcSYS_TenantUserRole )
         {
            bcSYS_TenantUserRole = (SdtSYS_TenantUserRole)(sdt);
            if ( StringUtil.StrCmp(bcSYS_TenantUserRole.gxTpr_Mode, "") == 0 )
            {
               bcSYS_TenantUserRole.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow56( bcSYS_TenantUserRole) ;
            }
            else
            {
               RowToVars56( bcSYS_TenantUserRole, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcSYS_TenantUserRole.gxTpr_Mode, "") == 0 )
            {
               bcSYS_TenantUserRole.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars56( bcSYS_TenantUserRole, 1) ;
         return  ;
      }

      public SdtSYS_TenantUserRole SYS_TenantUserRole_BC
      {
         get {
            return bcSYS_TenantUserRole ;
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
         Z370SYS_TenantUserRoleUserRoleID = (Guid)(Guid.Empty);
         A370SYS_TenantUserRoleUserRoleID = (Guid)(Guid.Empty);
         Z434SYS_TenantUserRoleRoleID = (Guid)(Guid.Empty);
         A434SYS_TenantUserRoleRoleID = (Guid)(Guid.Empty);
         Z433SYS_TenantUserRoleUserID = (Guid)(Guid.Empty);
         A433SYS_TenantUserRoleUserID = (Guid)(Guid.Empty);
         Z441SYS_TenantUserRoleTenantCode = "";
         A441SYS_TenantUserRoleTenantCode = "";
         BC001J4_A370SYS_TenantUserRoleUserRoleID = new Guid[] {Guid.Empty} ;
         BC001J4_A434SYS_TenantUserRoleRoleID = new Guid[] {Guid.Empty} ;
         BC001J4_A433SYS_TenantUserRoleUserID = new Guid[] {Guid.Empty} ;
         BC001J4_A441SYS_TenantUserRoleTenantCode = new String[] {""} ;
         BC001J5_A370SYS_TenantUserRoleUserRoleID = new Guid[] {Guid.Empty} ;
         BC001J3_A370SYS_TenantUserRoleUserRoleID = new Guid[] {Guid.Empty} ;
         BC001J3_A434SYS_TenantUserRoleRoleID = new Guid[] {Guid.Empty} ;
         BC001J3_A433SYS_TenantUserRoleUserID = new Guid[] {Guid.Empty} ;
         BC001J3_A441SYS_TenantUserRoleTenantCode = new String[] {""} ;
         sMode56 = "";
         BC001J2_A370SYS_TenantUserRoleUserRoleID = new Guid[] {Guid.Empty} ;
         BC001J2_A434SYS_TenantUserRoleRoleID = new Guid[] {Guid.Empty} ;
         BC001J2_A433SYS_TenantUserRoleUserID = new Guid[] {Guid.Empty} ;
         BC001J2_A441SYS_TenantUserRoleTenantCode = new String[] {""} ;
         BC001J9_A370SYS_TenantUserRoleUserRoleID = new Guid[] {Guid.Empty} ;
         BC001J9_A434SYS_TenantUserRoleRoleID = new Guid[] {Guid.Empty} ;
         BC001J9_A433SYS_TenantUserRoleUserID = new Guid[] {Guid.Empty} ;
         BC001J9_A441SYS_TenantUserRoleTenantCode = new String[] {""} ;
         i434SYS_TenantUserRoleRoleID = (Guid)(Guid.Empty);
         i433SYS_TenantUserRoleUserID = (Guid)(Guid.Empty);
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.sys_tenantuserrole_bc__datastore1(),
            new Object[][] {
                new Object[] {
               BC001J2_A370SYS_TenantUserRoleUserRoleID, BC001J2_A434SYS_TenantUserRoleRoleID, BC001J2_A433SYS_TenantUserRoleUserID, BC001J2_A441SYS_TenantUserRoleTenantCode
               }
               , new Object[] {
               BC001J3_A370SYS_TenantUserRoleUserRoleID, BC001J3_A434SYS_TenantUserRoleRoleID, BC001J3_A433SYS_TenantUserRoleUserID, BC001J3_A441SYS_TenantUserRoleTenantCode
               }
               , new Object[] {
               BC001J4_A370SYS_TenantUserRoleUserRoleID, BC001J4_A434SYS_TenantUserRoleRoleID, BC001J4_A433SYS_TenantUserRoleUserID, BC001J4_A441SYS_TenantUserRoleTenantCode
               }
               , new Object[] {
               BC001J5_A370SYS_TenantUserRoleUserRoleID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC001J9_A370SYS_TenantUserRoleUserRoleID, BC001J9_A434SYS_TenantUserRoleRoleID, BC001J9_A433SYS_TenantUserRoleUserID, BC001J9_A441SYS_TenantUserRoleTenantCode
               }
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.sys_tenantuserrole_bc__default(),
            new Object[][] {
            }
         );
         Z434SYS_TenantUserRoleRoleID = (Guid)(Guid.NewGuid( ));
         A434SYS_TenantUserRoleRoleID = (Guid)(Guid.NewGuid( ));
         i434SYS_TenantUserRoleRoleID = (Guid)(Guid.NewGuid( ));
         Z433SYS_TenantUserRoleUserID = (Guid)(Guid.NewGuid( ));
         A433SYS_TenantUserRoleUserID = (Guid)(Guid.NewGuid( ));
         i433SYS_TenantUserRoleUserID = (Guid)(Guid.NewGuid( ));
         Z370SYS_TenantUserRoleUserRoleID = (Guid)(Guid.NewGuid( ));
         A370SYS_TenantUserRoleUserRoleID = (Guid)(Guid.NewGuid( ));
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
      private short RcdFound56 ;
      private int trnEnded ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String sMode56 ;
      private String Z441SYS_TenantUserRoleTenantCode ;
      private String A441SYS_TenantUserRoleTenantCode ;
      private Guid Z370SYS_TenantUserRoleUserRoleID ;
      private Guid A370SYS_TenantUserRoleUserRoleID ;
      private Guid Z434SYS_TenantUserRoleRoleID ;
      private Guid A434SYS_TenantUserRoleRoleID ;
      private Guid Z433SYS_TenantUserRoleUserID ;
      private Guid A433SYS_TenantUserRoleUserID ;
      private Guid i434SYS_TenantUserRoleRoleID ;
      private Guid i433SYS_TenantUserRoleUserID ;
      private SdtSYS_TenantUserRole bcSYS_TenantUserRole ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_datastore1 ;
      private Guid[] BC001J4_A370SYS_TenantUserRoleUserRoleID ;
      private Guid[] BC001J4_A434SYS_TenantUserRoleRoleID ;
      private Guid[] BC001J4_A433SYS_TenantUserRoleUserID ;
      private String[] BC001J4_A441SYS_TenantUserRoleTenantCode ;
      private Guid[] BC001J5_A370SYS_TenantUserRoleUserRoleID ;
      private Guid[] BC001J3_A370SYS_TenantUserRoleUserRoleID ;
      private Guid[] BC001J3_A434SYS_TenantUserRoleRoleID ;
      private Guid[] BC001J3_A433SYS_TenantUserRoleUserID ;
      private String[] BC001J3_A441SYS_TenantUserRoleTenantCode ;
      private Guid[] BC001J2_A370SYS_TenantUserRoleUserRoleID ;
      private Guid[] BC001J2_A434SYS_TenantUserRoleRoleID ;
      private Guid[] BC001J2_A433SYS_TenantUserRoleUserID ;
      private String[] BC001J2_A441SYS_TenantUserRoleTenantCode ;
      private Guid[] BC001J9_A370SYS_TenantUserRoleUserRoleID ;
      private Guid[] BC001J9_A434SYS_TenantUserRoleRoleID ;
      private Guid[] BC001J9_A433SYS_TenantUserRoleUserID ;
      private String[] BC001J9_A441SYS_TenantUserRoleTenantCode ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_default ;
   }

   public class sys_tenantuserrole_bc__datastore1 : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmBC001J4 ;
          prmBC001J4 = new Object[] {
          new Object[] {"@SYS_TenantUserRoleUserRoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC001J5 ;
          prmBC001J5 = new Object[] {
          new Object[] {"@SYS_TenantUserRoleUserRoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC001J3 ;
          prmBC001J3 = new Object[] {
          new Object[] {"@SYS_TenantUserRoleUserRoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC001J2 ;
          prmBC001J2 = new Object[] {
          new Object[] {"@SYS_TenantUserRoleUserRoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC001J6 ;
          prmBC001J6 = new Object[] {
          new Object[] {"@SYS_TenantUserRoleTenantCode",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@SYS_TenantUserRoleUserRoleID",SqlDbType.UniqueIdentifier,16,0} ,
          new Object[] {"@SYS_TenantUserRoleRoleID",SqlDbType.UniqueIdentifier,16,0} ,
          new Object[] {"@SYS_TenantUserRoleUserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC001J7 ;
          prmBC001J7 = new Object[] {
          new Object[] {"@SYS_TenantUserRoleRoleID",SqlDbType.UniqueIdentifier,16,0} ,
          new Object[] {"@SYS_TenantUserRoleUserID",SqlDbType.UniqueIdentifier,16,0} ,
          new Object[] {"@SYS_TenantUserRoleTenantCode",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@SYS_TenantUserRoleUserRoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC001J8 ;
          prmBC001J8 = new Object[] {
          new Object[] {"@SYS_TenantUserRoleUserRoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC001J9 ;
          prmBC001J9 = new Object[] {
          new Object[] {"@SYS_TenantUserRoleUserRoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("BC001J2", "SELECT [UserRoleID], [RoleID], [UserID], [TenantCode] FROM [SYS_TenantUserRole] WITH (UPDLOCK) WHERE [UserRoleID] = @SYS_TenantUserRoleUserRoleID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001J2,1,0,true,false )
             ,new CursorDef("BC001J3", "SELECT [UserRoleID], [RoleID], [UserID], [TenantCode] FROM [SYS_TenantUserRole] WITH (NOLOCK) WHERE [UserRoleID] = @SYS_TenantUserRoleUserRoleID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001J3,1,0,true,false )
             ,new CursorDef("BC001J4", "SELECT TM1.[UserRoleID], TM1.[RoleID], TM1.[UserID], TM1.[TenantCode] FROM [SYS_TenantUserRole] TM1 WITH (NOLOCK) WHERE TM1.[UserRoleID] = @SYS_TenantUserRoleUserRoleID ORDER BY TM1.[UserRoleID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001J4,100,0,true,false )
             ,new CursorDef("BC001J5", "SELECT [UserRoleID] FROM [SYS_TenantUserRole] WITH (NOLOCK) WHERE [UserRoleID] = @SYS_TenantUserRoleUserRoleID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001J5,1,0,true,false )
             ,new CursorDef("BC001J6", "INSERT INTO [SYS_TenantUserRole]([TenantCode], [UserRoleID], [RoleID], [UserID]) VALUES(@SYS_TenantUserRoleTenantCode, @SYS_TenantUserRoleUserRoleID, @SYS_TenantUserRoleRoleID, @SYS_TenantUserRoleUserID)", GxErrorMask.GX_NOMASK,prmBC001J6)
             ,new CursorDef("BC001J7", "UPDATE [SYS_TenantUserRole] SET [RoleID]=@SYS_TenantUserRoleRoleID, [UserID]=@SYS_TenantUserRoleUserID, [TenantCode]=@SYS_TenantUserRoleTenantCode  WHERE [UserRoleID] = @SYS_TenantUserRoleUserRoleID", GxErrorMask.GX_NOMASK,prmBC001J7)
             ,new CursorDef("BC001J8", "DELETE FROM [SYS_TenantUserRole]  WHERE [UserRoleID] = @SYS_TenantUserRoleUserRoleID", GxErrorMask.GX_NOMASK,prmBC001J8)
             ,new CursorDef("BC001J9", "SELECT TM1.[UserRoleID], TM1.[RoleID], TM1.[UserID], TM1.[TenantCode] FROM [SYS_TenantUserRole] TM1 WITH (NOLOCK) WHERE TM1.[UserRoleID] = @SYS_TenantUserRoleUserRoleID ORDER BY TM1.[UserRoleID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001J9,100,0,true,false )
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
                ((Guid[]) buf[2])[0] = rslt.getGuid(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                return;
             case 1 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                ((Guid[]) buf[1])[0] = rslt.getGuid(2) ;
                ((Guid[]) buf[2])[0] = rslt.getGuid(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                return;
             case 2 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                ((Guid[]) buf[1])[0] = rslt.getGuid(2) ;
                ((Guid[]) buf[2])[0] = rslt.getGuid(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                return;
             case 3 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                return;
             case 7 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                ((Guid[]) buf[1])[0] = rslt.getGuid(2) ;
                ((Guid[]) buf[2])[0] = rslt.getGuid(3) ;
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
                stmt.SetParameter(2, (Guid)parms[1]);
                stmt.SetParameter(3, (Guid)parms[2]);
                stmt.SetParameter(4, (Guid)parms[3]);
                return;
             case 5 :
                stmt.SetParameter(1, (Guid)parms[0]);
                stmt.SetParameter(2, (Guid)parms[1]);
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

 public class sys_tenantuserrole_bc__default : DataStoreHelperBase, IDataStoreHelper
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
