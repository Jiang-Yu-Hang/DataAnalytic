/*
               File: SYS_Role_BC
        Description: SYS_Role
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:39:2.6
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
   public class sys_role_bc : GXHttpHandler, IGxSilentTrn
   {
      public sys_role_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public sys_role_bc( IGxContext context )
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
         ReadRow1H54( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey1H54( ) ;
         standaloneModal( ) ;
         AddRow1H54( ) ;
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
               Z361RoleID = (Guid)(A361RoleID);
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

      protected void CONFIRM_1H0( )
      {
         BeforeValidate1H54( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls1H54( ) ;
            }
            else
            {
               CheckExtendedTable1H54( ) ;
               if ( AnyError == 0 )
               {
               }
               CloseExtendedTableCursors1H54( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void ZM1H54( short GX_JID )
      {
         if ( ( GX_JID == 5 ) || ( GX_JID == 0 ) )
         {
            Z367SYS_RoleTenantCode = A367SYS_RoleTenantCode;
            Z368RoleName = A368RoleName;
            Z408RoleType = A408RoleType;
            Z410SYS_RoleCreator = A410SYS_RoleCreator;
            Z411SYS_RoleCreateTime = A411SYS_RoleCreateTime;
            Z412SYS_RoleModifier = A412SYS_RoleModifier;
            Z413SYS_RoleModifyTime = A413SYS_RoleModifyTime;
            Z414SYS_RoleIsDeleted = A414SYS_RoleIsDeleted;
         }
         if ( GX_JID == -5 )
         {
            Z361RoleID = (Guid)(A361RoleID);
            Z367SYS_RoleTenantCode = A367SYS_RoleTenantCode;
            Z368RoleName = A368RoleName;
            Z408RoleType = A408RoleType;
            Z409SYS_RoleDescription = A409SYS_RoleDescription;
            Z410SYS_RoleCreator = A410SYS_RoleCreator;
            Z411SYS_RoleCreateTime = A411SYS_RoleCreateTime;
            Z412SYS_RoleModifier = A412SYS_RoleModifier;
            Z413SYS_RoleModifyTime = A413SYS_RoleModifyTime;
            Z414SYS_RoleIsDeleted = A414SYS_RoleIsDeleted;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (Guid.Empty==A361RoleID) )
         {
            A361RoleID = (Guid)(Guid.NewGuid( ));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( Gx_BScreen == 0 ) )
         {
         }
      }

      protected void Load1H54( )
      {
         /* Using cursor BC001H4 */
         pr_datastore1.execute(2, new Object[] {A361RoleID});
         if ( (pr_datastore1.getStatus(2) != 101) )
         {
            RcdFound54 = 1;
            A367SYS_RoleTenantCode = BC001H4_A367SYS_RoleTenantCode[0];
            n367SYS_RoleTenantCode = BC001H4_n367SYS_RoleTenantCode[0];
            A368RoleName = BC001H4_A368RoleName[0];
            A408RoleType = BC001H4_A408RoleType[0];
            A409SYS_RoleDescription = BC001H4_A409SYS_RoleDescription[0];
            n409SYS_RoleDescription = BC001H4_n409SYS_RoleDescription[0];
            A410SYS_RoleCreator = BC001H4_A410SYS_RoleCreator[0];
            A411SYS_RoleCreateTime = BC001H4_A411SYS_RoleCreateTime[0];
            A412SYS_RoleModifier = BC001H4_A412SYS_RoleModifier[0];
            n412SYS_RoleModifier = BC001H4_n412SYS_RoleModifier[0];
            A413SYS_RoleModifyTime = BC001H4_A413SYS_RoleModifyTime[0];
            n413SYS_RoleModifyTime = BC001H4_n413SYS_RoleModifyTime[0];
            A414SYS_RoleIsDeleted = BC001H4_A414SYS_RoleIsDeleted[0];
            ZM1H54( -5) ;
         }
         pr_datastore1.close(2);
         OnLoadActions1H54( ) ;
      }

      protected void OnLoadActions1H54( )
      {
      }

      protected void CheckExtendedTable1H54( )
      {
         standaloneModal( ) ;
         /* Using cursor BC001H5 */
         pr_datastore1.execute(3, new Object[] {n367SYS_RoleTenantCode, A367SYS_RoleTenantCode, A368RoleName, A361RoleID});
         if ( (pr_datastore1.getStatus(3) != 101) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_1004", new   object[]  {"SYS_Role Tenant Code"+","+"Role Name"}), 1, "");
            AnyError = 1;
         }
         pr_datastore1.close(3);
         if ( ! ( (DateTime.MinValue==A411SYS_RoleCreateTime) || ( A411SYS_RoleCreateTime >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("域SYS_Role Create Time超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
         if ( ! ( (DateTime.MinValue==A413SYS_RoleModifyTime) || ( A413SYS_RoleModifyTime >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("域SYS_Role Modify Time超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
      }

      protected void CloseExtendedTableCursors1H54( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey1H54( )
      {
         /* Using cursor BC001H6 */
         pr_datastore1.execute(4, new Object[] {A361RoleID});
         if ( (pr_datastore1.getStatus(4) != 101) )
         {
            RcdFound54 = 1;
         }
         else
         {
            RcdFound54 = 0;
         }
         pr_datastore1.close(4);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC001H3 */
         pr_datastore1.execute(1, new Object[] {A361RoleID});
         if ( (pr_datastore1.getStatus(1) != 101) )
         {
            ZM1H54( 5) ;
            RcdFound54 = 1;
            A361RoleID = (Guid)((Guid)(BC001H3_A361RoleID[0]));
            A367SYS_RoleTenantCode = BC001H3_A367SYS_RoleTenantCode[0];
            n367SYS_RoleTenantCode = BC001H3_n367SYS_RoleTenantCode[0];
            A368RoleName = BC001H3_A368RoleName[0];
            A408RoleType = BC001H3_A408RoleType[0];
            A409SYS_RoleDescription = BC001H3_A409SYS_RoleDescription[0];
            n409SYS_RoleDescription = BC001H3_n409SYS_RoleDescription[0];
            A410SYS_RoleCreator = BC001H3_A410SYS_RoleCreator[0];
            A411SYS_RoleCreateTime = BC001H3_A411SYS_RoleCreateTime[0];
            A412SYS_RoleModifier = BC001H3_A412SYS_RoleModifier[0];
            n412SYS_RoleModifier = BC001H3_n412SYS_RoleModifier[0];
            A413SYS_RoleModifyTime = BC001H3_A413SYS_RoleModifyTime[0];
            n413SYS_RoleModifyTime = BC001H3_n413SYS_RoleModifyTime[0];
            A414SYS_RoleIsDeleted = BC001H3_A414SYS_RoleIsDeleted[0];
            Z361RoleID = (Guid)(A361RoleID);
            sMode54 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load1H54( ) ;
            if ( AnyError == 1 )
            {
               RcdFound54 = 0;
               InitializeNonKey1H54( ) ;
            }
            Gx_mode = sMode54;
         }
         else
         {
            RcdFound54 = 0;
            InitializeNonKey1H54( ) ;
            sMode54 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode54;
         }
         pr_datastore1.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1H54( ) ;
         if ( RcdFound54 == 0 )
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
         CONFIRM_1H0( ) ;
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

      protected void CheckOptimisticConcurrency1H54( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC001H2 */
            pr_datastore1.execute(0, new Object[] {A361RoleID});
            if ( (pr_datastore1.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SYS_ROLE"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_datastore1.getStatus(0) == 101) || ( StringUtil.StrCmp(Z367SYS_RoleTenantCode, BC001H2_A367SYS_RoleTenantCode[0]) != 0 ) || ( StringUtil.StrCmp(Z368RoleName, BC001H2_A368RoleName[0]) != 0 ) || ( Z408RoleType != BC001H2_A408RoleType[0] ) || ( StringUtil.StrCmp(Z410SYS_RoleCreator, BC001H2_A410SYS_RoleCreator[0]) != 0 ) || ( Z411SYS_RoleCreateTime != BC001H2_A411SYS_RoleCreateTime[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z412SYS_RoleModifier, BC001H2_A412SYS_RoleModifier[0]) != 0 ) || ( Z413SYS_RoleModifyTime != BC001H2_A413SYS_RoleModifyTime[0] ) || ( Z414SYS_RoleIsDeleted != BC001H2_A414SYS_RoleIsDeleted[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"SYS_ROLE"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert1H54( )
      {
         BeforeValidate1H54( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1H54( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1H54( 0) ;
            CheckOptimisticConcurrency1H54( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1H54( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1H54( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC001H7 */
                     pr_datastore1.execute(5, new Object[] {n367SYS_RoleTenantCode, A367SYS_RoleTenantCode, A368RoleName, A408RoleType, n409SYS_RoleDescription, A409SYS_RoleDescription, A410SYS_RoleCreator, A411SYS_RoleCreateTime, n412SYS_RoleModifier, A412SYS_RoleModifier, n413SYS_RoleModifyTime, A413SYS_RoleModifyTime, A414SYS_RoleIsDeleted, A361RoleID});
                     pr_datastore1.close(5);
                     dsDataStore1.SmartCacheProvider.SetUpdated("SYS_ROLE") ;
                     if ( (pr_datastore1.getStatus(5) == 1) )
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
               Load1H54( ) ;
            }
            EndLevel1H54( ) ;
         }
         CloseExtendedTableCursors1H54( ) ;
      }

      protected void Update1H54( )
      {
         BeforeValidate1H54( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1H54( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1H54( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1H54( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1H54( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC001H8 */
                     pr_datastore1.execute(6, new Object[] {n367SYS_RoleTenantCode, A367SYS_RoleTenantCode, A368RoleName, A408RoleType, n409SYS_RoleDescription, A409SYS_RoleDescription, A410SYS_RoleCreator, A411SYS_RoleCreateTime, n412SYS_RoleModifier, A412SYS_RoleModifier, n413SYS_RoleModifyTime, A413SYS_RoleModifyTime, A414SYS_RoleIsDeleted, A361RoleID});
                     pr_datastore1.close(6);
                     dsDataStore1.SmartCacheProvider.SetUpdated("SYS_ROLE") ;
                     if ( (pr_datastore1.getStatus(6) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SYS_ROLE"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate1H54( ) ;
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
            EndLevel1H54( ) ;
         }
         CloseExtendedTableCursors1H54( ) ;
      }

      protected void DeferredUpdate1H54( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate1H54( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1H54( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1H54( ) ;
            AfterConfirm1H54( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1H54( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC001H9 */
                  pr_datastore1.execute(7, new Object[] {A361RoleID});
                  pr_datastore1.close(7);
                  dsDataStore1.SmartCacheProvider.SetUpdated("SYS_ROLE") ;
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
         sMode54 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel1H54( ) ;
         Gx_mode = sMode54;
      }

      protected void OnDeleteControls1H54( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor BC001H10 */
            pr_datastore1.execute(8, new Object[] {A361RoleID});
            if ( (pr_datastore1.getStatus(8) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"SYS_User Role"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_datastore1.close(8);
         }
      }

      protected void EndLevel1H54( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_datastore1.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1H54( ) ;
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

      public void ScanKeyStart1H54( )
      {
         /* Using cursor BC001H11 */
         pr_datastore1.execute(9, new Object[] {A361RoleID});
         RcdFound54 = 0;
         if ( (pr_datastore1.getStatus(9) != 101) )
         {
            RcdFound54 = 1;
            A361RoleID = (Guid)((Guid)(BC001H11_A361RoleID[0]));
            A367SYS_RoleTenantCode = BC001H11_A367SYS_RoleTenantCode[0];
            n367SYS_RoleTenantCode = BC001H11_n367SYS_RoleTenantCode[0];
            A368RoleName = BC001H11_A368RoleName[0];
            A408RoleType = BC001H11_A408RoleType[0];
            A409SYS_RoleDescription = BC001H11_A409SYS_RoleDescription[0];
            n409SYS_RoleDescription = BC001H11_n409SYS_RoleDescription[0];
            A410SYS_RoleCreator = BC001H11_A410SYS_RoleCreator[0];
            A411SYS_RoleCreateTime = BC001H11_A411SYS_RoleCreateTime[0];
            A412SYS_RoleModifier = BC001H11_A412SYS_RoleModifier[0];
            n412SYS_RoleModifier = BC001H11_n412SYS_RoleModifier[0];
            A413SYS_RoleModifyTime = BC001H11_A413SYS_RoleModifyTime[0];
            n413SYS_RoleModifyTime = BC001H11_n413SYS_RoleModifyTime[0];
            A414SYS_RoleIsDeleted = BC001H11_A414SYS_RoleIsDeleted[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext1H54( )
      {
         /* Scan next routine */
         pr_datastore1.readNext(9);
         RcdFound54 = 0;
         ScanKeyLoad1H54( ) ;
      }

      protected void ScanKeyLoad1H54( )
      {
         sMode54 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_datastore1.getStatus(9) != 101) )
         {
            RcdFound54 = 1;
            A361RoleID = (Guid)((Guid)(BC001H11_A361RoleID[0]));
            A367SYS_RoleTenantCode = BC001H11_A367SYS_RoleTenantCode[0];
            n367SYS_RoleTenantCode = BC001H11_n367SYS_RoleTenantCode[0];
            A368RoleName = BC001H11_A368RoleName[0];
            A408RoleType = BC001H11_A408RoleType[0];
            A409SYS_RoleDescription = BC001H11_A409SYS_RoleDescription[0];
            n409SYS_RoleDescription = BC001H11_n409SYS_RoleDescription[0];
            A410SYS_RoleCreator = BC001H11_A410SYS_RoleCreator[0];
            A411SYS_RoleCreateTime = BC001H11_A411SYS_RoleCreateTime[0];
            A412SYS_RoleModifier = BC001H11_A412SYS_RoleModifier[0];
            n412SYS_RoleModifier = BC001H11_n412SYS_RoleModifier[0];
            A413SYS_RoleModifyTime = BC001H11_A413SYS_RoleModifyTime[0];
            n413SYS_RoleModifyTime = BC001H11_n413SYS_RoleModifyTime[0];
            A414SYS_RoleIsDeleted = BC001H11_A414SYS_RoleIsDeleted[0];
         }
         Gx_mode = sMode54;
      }

      protected void ScanKeyEnd1H54( )
      {
         pr_datastore1.close(9);
      }

      protected void AfterConfirm1H54( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1H54( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1H54( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1H54( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1H54( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1H54( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1H54( )
      {
      }

      protected void send_integrity_lvl_hashes1H54( )
      {
      }

      protected void AddRow1H54( )
      {
         VarsToRow54( bcSYS_Role) ;
      }

      protected void ReadRow1H54( )
      {
         RowToVars54( bcSYS_Role, 1) ;
      }

      protected void InitializeNonKey1H54( )
      {
         A367SYS_RoleTenantCode = "";
         n367SYS_RoleTenantCode = false;
         A368RoleName = "";
         A408RoleType = 0;
         A409SYS_RoleDescription = "";
         n409SYS_RoleDescription = false;
         A410SYS_RoleCreator = "";
         A411SYS_RoleCreateTime = (DateTime)(DateTime.MinValue);
         A412SYS_RoleModifier = "";
         n412SYS_RoleModifier = false;
         A413SYS_RoleModifyTime = (DateTime)(DateTime.MinValue);
         n413SYS_RoleModifyTime = false;
         A414SYS_RoleIsDeleted = 0;
         Z367SYS_RoleTenantCode = "";
         Z368RoleName = "";
         Z408RoleType = 0;
         Z410SYS_RoleCreator = "";
         Z411SYS_RoleCreateTime = (DateTime)(DateTime.MinValue);
         Z412SYS_RoleModifier = "";
         Z413SYS_RoleModifyTime = (DateTime)(DateTime.MinValue);
         Z414SYS_RoleIsDeleted = 0;
      }

      protected void InitAll1H54( )
      {
         A361RoleID = (Guid)(Guid.NewGuid( ));
         InitializeNonKey1H54( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow54( SdtSYS_Role obj54 )
      {
         obj54.gxTpr_Mode = Gx_mode;
         obj54.gxTpr_Sys_roletenantcode = A367SYS_RoleTenantCode;
         obj54.gxTpr_Rolename = A368RoleName;
         obj54.gxTpr_Roletype = A408RoleType;
         obj54.gxTpr_Sys_roledescription = A409SYS_RoleDescription;
         obj54.gxTpr_Sys_rolecreator = A410SYS_RoleCreator;
         obj54.gxTpr_Sys_rolecreatetime = A411SYS_RoleCreateTime;
         obj54.gxTpr_Sys_rolemodifier = A412SYS_RoleModifier;
         obj54.gxTpr_Sys_rolemodifytime = A413SYS_RoleModifyTime;
         obj54.gxTpr_Sys_roleisdeleted = A414SYS_RoleIsDeleted;
         obj54.gxTpr_Roleid = (Guid)(A361RoleID);
         obj54.gxTpr_Roleid_Z = (Guid)(Z361RoleID);
         obj54.gxTpr_Sys_roletenantcode_Z = Z367SYS_RoleTenantCode;
         obj54.gxTpr_Rolename_Z = Z368RoleName;
         obj54.gxTpr_Roletype_Z = Z408RoleType;
         obj54.gxTpr_Sys_rolecreator_Z = Z410SYS_RoleCreator;
         obj54.gxTpr_Sys_rolecreatetime_Z = Z411SYS_RoleCreateTime;
         obj54.gxTpr_Sys_rolemodifier_Z = Z412SYS_RoleModifier;
         obj54.gxTpr_Sys_rolemodifytime_Z = Z413SYS_RoleModifyTime;
         obj54.gxTpr_Sys_roleisdeleted_Z = Z414SYS_RoleIsDeleted;
         obj54.gxTpr_Sys_roletenantcode_N = (short)(Convert.ToInt16(n367SYS_RoleTenantCode));
         obj54.gxTpr_Sys_roledescription_N = (short)(Convert.ToInt16(n409SYS_RoleDescription));
         obj54.gxTpr_Sys_rolemodifier_N = (short)(Convert.ToInt16(n412SYS_RoleModifier));
         obj54.gxTpr_Sys_rolemodifytime_N = (short)(Convert.ToInt16(n413SYS_RoleModifyTime));
         obj54.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow54( SdtSYS_Role obj54 )
      {
         obj54.gxTpr_Roleid = (Guid)(A361RoleID);
         return  ;
      }

      public void RowToVars54( SdtSYS_Role obj54 ,
                               int forceLoad )
      {
         Gx_mode = obj54.gxTpr_Mode;
         A367SYS_RoleTenantCode = obj54.gxTpr_Sys_roletenantcode;
         n367SYS_RoleTenantCode = false;
         A368RoleName = obj54.gxTpr_Rolename;
         A408RoleType = obj54.gxTpr_Roletype;
         A409SYS_RoleDescription = obj54.gxTpr_Sys_roledescription;
         n409SYS_RoleDescription = false;
         A410SYS_RoleCreator = obj54.gxTpr_Sys_rolecreator;
         A411SYS_RoleCreateTime = obj54.gxTpr_Sys_rolecreatetime;
         A412SYS_RoleModifier = obj54.gxTpr_Sys_rolemodifier;
         n412SYS_RoleModifier = false;
         A413SYS_RoleModifyTime = obj54.gxTpr_Sys_rolemodifytime;
         n413SYS_RoleModifyTime = false;
         A414SYS_RoleIsDeleted = obj54.gxTpr_Sys_roleisdeleted;
         A361RoleID = (Guid)(obj54.gxTpr_Roleid);
         Z361RoleID = (Guid)(obj54.gxTpr_Roleid_Z);
         Z367SYS_RoleTenantCode = obj54.gxTpr_Sys_roletenantcode_Z;
         Z368RoleName = obj54.gxTpr_Rolename_Z;
         Z408RoleType = obj54.gxTpr_Roletype_Z;
         Z410SYS_RoleCreator = obj54.gxTpr_Sys_rolecreator_Z;
         Z411SYS_RoleCreateTime = obj54.gxTpr_Sys_rolecreatetime_Z;
         Z412SYS_RoleModifier = obj54.gxTpr_Sys_rolemodifier_Z;
         Z413SYS_RoleModifyTime = obj54.gxTpr_Sys_rolemodifytime_Z;
         Z414SYS_RoleIsDeleted = obj54.gxTpr_Sys_roleisdeleted_Z;
         n367SYS_RoleTenantCode = (bool)(Convert.ToBoolean(obj54.gxTpr_Sys_roletenantcode_N));
         n409SYS_RoleDescription = (bool)(Convert.ToBoolean(obj54.gxTpr_Sys_roledescription_N));
         n412SYS_RoleModifier = (bool)(Convert.ToBoolean(obj54.gxTpr_Sys_rolemodifier_N));
         n413SYS_RoleModifyTime = (bool)(Convert.ToBoolean(obj54.gxTpr_Sys_rolemodifytime_N));
         Gx_mode = obj54.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A361RoleID = (Guid)((Guid)getParm(obj,0));
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey1H54( ) ;
         ScanKeyStart1H54( ) ;
         if ( RcdFound54 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z361RoleID = (Guid)(A361RoleID);
         }
         ZM1H54( -5) ;
         OnLoadActions1H54( ) ;
         AddRow1H54( ) ;
         ScanKeyEnd1H54( ) ;
         if ( RcdFound54 == 0 )
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
         RowToVars54( bcSYS_Role, 0) ;
         ScanKeyStart1H54( ) ;
         if ( RcdFound54 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z361RoleID = (Guid)(A361RoleID);
         }
         ZM1H54( -5) ;
         OnLoadActions1H54( ) ;
         AddRow1H54( ) ;
         ScanKeyEnd1H54( ) ;
         if ( RcdFound54 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey1H54( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert1H54( ) ;
         }
         else
         {
            if ( RcdFound54 == 1 )
            {
               if ( A361RoleID != Z361RoleID )
               {
                  A361RoleID = (Guid)(Z361RoleID);
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
                  Update1H54( ) ;
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
                  if ( A361RoleID != Z361RoleID )
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
                        Insert1H54( ) ;
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
                        Insert1H54( ) ;
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
         RowToVars54( bcSYS_Role, 0) ;
         SaveImpl( ) ;
         VarsToRow54( bcSYS_Role) ;
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
         RowToVars54( bcSYS_Role, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert1H54( ) ;
         AfterTrn( ) ;
         VarsToRow54( bcSYS_Role) ;
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
            SdtSYS_Role auxBC = new SdtSYS_Role(context) ;
            auxBC.Load(A361RoleID);
            auxBC.UpdateDirties(bcSYS_Role);
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
         RowToVars54( bcSYS_Role, 0) ;
         UpdateImpl( ) ;
         VarsToRow54( bcSYS_Role) ;
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
         RowToVars54( bcSYS_Role, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert1H54( ) ;
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
         VarsToRow54( bcSYS_Role) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars54( bcSYS_Role, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey1H54( ) ;
         if ( RcdFound54 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A361RoleID != Z361RoleID )
            {
               A361RoleID = (Guid)(Z361RoleID);
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
            if ( A361RoleID != Z361RoleID )
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
         context.RollbackDataStores("sys_role_bc",pr_default);
         VarsToRow54( bcSYS_Role) ;
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
         Gx_mode = bcSYS_Role.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcSYS_Role.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcSYS_Role )
         {
            bcSYS_Role = (SdtSYS_Role)(sdt);
            if ( StringUtil.StrCmp(bcSYS_Role.gxTpr_Mode, "") == 0 )
            {
               bcSYS_Role.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow54( bcSYS_Role) ;
            }
            else
            {
               RowToVars54( bcSYS_Role, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcSYS_Role.gxTpr_Mode, "") == 0 )
            {
               bcSYS_Role.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars54( bcSYS_Role, 1) ;
         return  ;
      }

      public SdtSYS_Role SYS_Role_BC
      {
         get {
            return bcSYS_Role ;
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
         Z361RoleID = (Guid)(Guid.Empty);
         A361RoleID = (Guid)(Guid.Empty);
         Z367SYS_RoleTenantCode = "";
         A367SYS_RoleTenantCode = "";
         Z368RoleName = "";
         A368RoleName = "";
         Z410SYS_RoleCreator = "";
         A410SYS_RoleCreator = "";
         Z411SYS_RoleCreateTime = (DateTime)(DateTime.MinValue);
         A411SYS_RoleCreateTime = (DateTime)(DateTime.MinValue);
         Z412SYS_RoleModifier = "";
         A412SYS_RoleModifier = "";
         Z413SYS_RoleModifyTime = (DateTime)(DateTime.MinValue);
         A413SYS_RoleModifyTime = (DateTime)(DateTime.MinValue);
         Z409SYS_RoleDescription = "";
         A409SYS_RoleDescription = "";
         BC001H4_A361RoleID = new Guid[] {Guid.Empty} ;
         BC001H4_A367SYS_RoleTenantCode = new String[] {""} ;
         BC001H4_n367SYS_RoleTenantCode = new bool[] {false} ;
         BC001H4_A368RoleName = new String[] {""} ;
         BC001H4_A408RoleType = new int[1] ;
         BC001H4_A409SYS_RoleDescription = new String[] {""} ;
         BC001H4_n409SYS_RoleDescription = new bool[] {false} ;
         BC001H4_A410SYS_RoleCreator = new String[] {""} ;
         BC001H4_A411SYS_RoleCreateTime = new DateTime[] {DateTime.MinValue} ;
         BC001H4_A412SYS_RoleModifier = new String[] {""} ;
         BC001H4_n412SYS_RoleModifier = new bool[] {false} ;
         BC001H4_A413SYS_RoleModifyTime = new DateTime[] {DateTime.MinValue} ;
         BC001H4_n413SYS_RoleModifyTime = new bool[] {false} ;
         BC001H4_A414SYS_RoleIsDeleted = new short[1] ;
         BC001H5_A367SYS_RoleTenantCode = new String[] {""} ;
         BC001H5_n367SYS_RoleTenantCode = new bool[] {false} ;
         BC001H6_A361RoleID = new Guid[] {Guid.Empty} ;
         BC001H3_A361RoleID = new Guid[] {Guid.Empty} ;
         BC001H3_A367SYS_RoleTenantCode = new String[] {""} ;
         BC001H3_n367SYS_RoleTenantCode = new bool[] {false} ;
         BC001H3_A368RoleName = new String[] {""} ;
         BC001H3_A408RoleType = new int[1] ;
         BC001H3_A409SYS_RoleDescription = new String[] {""} ;
         BC001H3_n409SYS_RoleDescription = new bool[] {false} ;
         BC001H3_A410SYS_RoleCreator = new String[] {""} ;
         BC001H3_A411SYS_RoleCreateTime = new DateTime[] {DateTime.MinValue} ;
         BC001H3_A412SYS_RoleModifier = new String[] {""} ;
         BC001H3_n412SYS_RoleModifier = new bool[] {false} ;
         BC001H3_A413SYS_RoleModifyTime = new DateTime[] {DateTime.MinValue} ;
         BC001H3_n413SYS_RoleModifyTime = new bool[] {false} ;
         BC001H3_A414SYS_RoleIsDeleted = new short[1] ;
         sMode54 = "";
         BC001H2_A361RoleID = new Guid[] {Guid.Empty} ;
         BC001H2_A367SYS_RoleTenantCode = new String[] {""} ;
         BC001H2_n367SYS_RoleTenantCode = new bool[] {false} ;
         BC001H2_A368RoleName = new String[] {""} ;
         BC001H2_A408RoleType = new int[1] ;
         BC001H2_A409SYS_RoleDescription = new String[] {""} ;
         BC001H2_n409SYS_RoleDescription = new bool[] {false} ;
         BC001H2_A410SYS_RoleCreator = new String[] {""} ;
         BC001H2_A411SYS_RoleCreateTime = new DateTime[] {DateTime.MinValue} ;
         BC001H2_A412SYS_RoleModifier = new String[] {""} ;
         BC001H2_n412SYS_RoleModifier = new bool[] {false} ;
         BC001H2_A413SYS_RoleModifyTime = new DateTime[] {DateTime.MinValue} ;
         BC001H2_n413SYS_RoleModifyTime = new bool[] {false} ;
         BC001H2_A414SYS_RoleIsDeleted = new short[1] ;
         BC001H10_A359UserID = new Guid[] {Guid.Empty} ;
         BC001H10_A361RoleID = new Guid[] {Guid.Empty} ;
         BC001H11_A361RoleID = new Guid[] {Guid.Empty} ;
         BC001H11_A367SYS_RoleTenantCode = new String[] {""} ;
         BC001H11_n367SYS_RoleTenantCode = new bool[] {false} ;
         BC001H11_A368RoleName = new String[] {""} ;
         BC001H11_A408RoleType = new int[1] ;
         BC001H11_A409SYS_RoleDescription = new String[] {""} ;
         BC001H11_n409SYS_RoleDescription = new bool[] {false} ;
         BC001H11_A410SYS_RoleCreator = new String[] {""} ;
         BC001H11_A411SYS_RoleCreateTime = new DateTime[] {DateTime.MinValue} ;
         BC001H11_A412SYS_RoleModifier = new String[] {""} ;
         BC001H11_n412SYS_RoleModifier = new bool[] {false} ;
         BC001H11_A413SYS_RoleModifyTime = new DateTime[] {DateTime.MinValue} ;
         BC001H11_n413SYS_RoleModifyTime = new bool[] {false} ;
         BC001H11_A414SYS_RoleIsDeleted = new short[1] ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.sys_role_bc__datastore1(),
            new Object[][] {
                new Object[] {
               BC001H2_A361RoleID, BC001H2_A367SYS_RoleTenantCode, BC001H2_n367SYS_RoleTenantCode, BC001H2_A368RoleName, BC001H2_A408RoleType, BC001H2_A409SYS_RoleDescription, BC001H2_n409SYS_RoleDescription, BC001H2_A410SYS_RoleCreator, BC001H2_A411SYS_RoleCreateTime, BC001H2_A412SYS_RoleModifier,
               BC001H2_n412SYS_RoleModifier, BC001H2_A413SYS_RoleModifyTime, BC001H2_n413SYS_RoleModifyTime, BC001H2_A414SYS_RoleIsDeleted
               }
               , new Object[] {
               BC001H3_A361RoleID, BC001H3_A367SYS_RoleTenantCode, BC001H3_n367SYS_RoleTenantCode, BC001H3_A368RoleName, BC001H3_A408RoleType, BC001H3_A409SYS_RoleDescription, BC001H3_n409SYS_RoleDescription, BC001H3_A410SYS_RoleCreator, BC001H3_A411SYS_RoleCreateTime, BC001H3_A412SYS_RoleModifier,
               BC001H3_n412SYS_RoleModifier, BC001H3_A413SYS_RoleModifyTime, BC001H3_n413SYS_RoleModifyTime, BC001H3_A414SYS_RoleIsDeleted
               }
               , new Object[] {
               BC001H4_A361RoleID, BC001H4_A367SYS_RoleTenantCode, BC001H4_n367SYS_RoleTenantCode, BC001H4_A368RoleName, BC001H4_A408RoleType, BC001H4_A409SYS_RoleDescription, BC001H4_n409SYS_RoleDescription, BC001H4_A410SYS_RoleCreator, BC001H4_A411SYS_RoleCreateTime, BC001H4_A412SYS_RoleModifier,
               BC001H4_n412SYS_RoleModifier, BC001H4_A413SYS_RoleModifyTime, BC001H4_n413SYS_RoleModifyTime, BC001H4_A414SYS_RoleIsDeleted
               }
               , new Object[] {
               BC001H5_A367SYS_RoleTenantCode, BC001H5_n367SYS_RoleTenantCode
               }
               , new Object[] {
               BC001H6_A361RoleID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC001H10_A359UserID, BC001H10_A361RoleID
               }
               , new Object[] {
               BC001H11_A361RoleID, BC001H11_A367SYS_RoleTenantCode, BC001H11_n367SYS_RoleTenantCode, BC001H11_A368RoleName, BC001H11_A408RoleType, BC001H11_A409SYS_RoleDescription, BC001H11_n409SYS_RoleDescription, BC001H11_A410SYS_RoleCreator, BC001H11_A411SYS_RoleCreateTime, BC001H11_A412SYS_RoleModifier,
               BC001H11_n412SYS_RoleModifier, BC001H11_A413SYS_RoleModifyTime, BC001H11_n413SYS_RoleModifyTime, BC001H11_A414SYS_RoleIsDeleted
               }
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.sys_role_bc__default(),
            new Object[][] {
            }
         );
         Z361RoleID = (Guid)(Guid.NewGuid( ));
         A361RoleID = (Guid)(Guid.NewGuid( ));
         INITTRN();
         /* Execute Start event if defined. */
         standaloneNotModal( ) ;
      }

      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short GX_JID ;
      private short Z414SYS_RoleIsDeleted ;
      private short A414SYS_RoleIsDeleted ;
      private short Gx_BScreen ;
      private short RcdFound54 ;
      private int trnEnded ;
      private int Z408RoleType ;
      private int A408RoleType ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String sMode54 ;
      private DateTime Z411SYS_RoleCreateTime ;
      private DateTime A411SYS_RoleCreateTime ;
      private DateTime Z413SYS_RoleModifyTime ;
      private DateTime A413SYS_RoleModifyTime ;
      private bool n367SYS_RoleTenantCode ;
      private bool n409SYS_RoleDescription ;
      private bool n412SYS_RoleModifier ;
      private bool n413SYS_RoleModifyTime ;
      private bool Gx_longc ;
      private String Z409SYS_RoleDescription ;
      private String A409SYS_RoleDescription ;
      private String Z367SYS_RoleTenantCode ;
      private String A367SYS_RoleTenantCode ;
      private String Z368RoleName ;
      private String A368RoleName ;
      private String Z410SYS_RoleCreator ;
      private String A410SYS_RoleCreator ;
      private String Z412SYS_RoleModifier ;
      private String A412SYS_RoleModifier ;
      private Guid Z361RoleID ;
      private Guid A361RoleID ;
      private SdtSYS_Role bcSYS_Role ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_datastore1 ;
      private Guid[] BC001H4_A361RoleID ;
      private String[] BC001H4_A367SYS_RoleTenantCode ;
      private bool[] BC001H4_n367SYS_RoleTenantCode ;
      private String[] BC001H4_A368RoleName ;
      private int[] BC001H4_A408RoleType ;
      private String[] BC001H4_A409SYS_RoleDescription ;
      private bool[] BC001H4_n409SYS_RoleDescription ;
      private String[] BC001H4_A410SYS_RoleCreator ;
      private DateTime[] BC001H4_A411SYS_RoleCreateTime ;
      private String[] BC001H4_A412SYS_RoleModifier ;
      private bool[] BC001H4_n412SYS_RoleModifier ;
      private DateTime[] BC001H4_A413SYS_RoleModifyTime ;
      private bool[] BC001H4_n413SYS_RoleModifyTime ;
      private short[] BC001H4_A414SYS_RoleIsDeleted ;
      private String[] BC001H5_A367SYS_RoleTenantCode ;
      private bool[] BC001H5_n367SYS_RoleTenantCode ;
      private Guid[] BC001H6_A361RoleID ;
      private Guid[] BC001H3_A361RoleID ;
      private String[] BC001H3_A367SYS_RoleTenantCode ;
      private bool[] BC001H3_n367SYS_RoleTenantCode ;
      private String[] BC001H3_A368RoleName ;
      private int[] BC001H3_A408RoleType ;
      private String[] BC001H3_A409SYS_RoleDescription ;
      private bool[] BC001H3_n409SYS_RoleDescription ;
      private String[] BC001H3_A410SYS_RoleCreator ;
      private DateTime[] BC001H3_A411SYS_RoleCreateTime ;
      private String[] BC001H3_A412SYS_RoleModifier ;
      private bool[] BC001H3_n412SYS_RoleModifier ;
      private DateTime[] BC001H3_A413SYS_RoleModifyTime ;
      private bool[] BC001H3_n413SYS_RoleModifyTime ;
      private short[] BC001H3_A414SYS_RoleIsDeleted ;
      private Guid[] BC001H2_A361RoleID ;
      private String[] BC001H2_A367SYS_RoleTenantCode ;
      private bool[] BC001H2_n367SYS_RoleTenantCode ;
      private String[] BC001H2_A368RoleName ;
      private int[] BC001H2_A408RoleType ;
      private String[] BC001H2_A409SYS_RoleDescription ;
      private bool[] BC001H2_n409SYS_RoleDescription ;
      private String[] BC001H2_A410SYS_RoleCreator ;
      private DateTime[] BC001H2_A411SYS_RoleCreateTime ;
      private String[] BC001H2_A412SYS_RoleModifier ;
      private bool[] BC001H2_n412SYS_RoleModifier ;
      private DateTime[] BC001H2_A413SYS_RoleModifyTime ;
      private bool[] BC001H2_n413SYS_RoleModifyTime ;
      private short[] BC001H2_A414SYS_RoleIsDeleted ;
      private Guid[] BC001H10_A359UserID ;
      private Guid[] BC001H10_A361RoleID ;
      private Guid[] BC001H11_A361RoleID ;
      private String[] BC001H11_A367SYS_RoleTenantCode ;
      private bool[] BC001H11_n367SYS_RoleTenantCode ;
      private String[] BC001H11_A368RoleName ;
      private int[] BC001H11_A408RoleType ;
      private String[] BC001H11_A409SYS_RoleDescription ;
      private bool[] BC001H11_n409SYS_RoleDescription ;
      private String[] BC001H11_A410SYS_RoleCreator ;
      private DateTime[] BC001H11_A411SYS_RoleCreateTime ;
      private String[] BC001H11_A412SYS_RoleModifier ;
      private bool[] BC001H11_n412SYS_RoleModifier ;
      private DateTime[] BC001H11_A413SYS_RoleModifyTime ;
      private bool[] BC001H11_n413SYS_RoleModifyTime ;
      private short[] BC001H11_A414SYS_RoleIsDeleted ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_default ;
   }

   public class sys_role_bc__datastore1 : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[7])
         ,new ForEachCursor(def[8])
         ,new ForEachCursor(def[9])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmBC001H4 ;
          prmBC001H4 = new Object[] {
          new Object[] {"@RoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC001H5 ;
          prmBC001H5 = new Object[] {
          new Object[] {"@SYS_RoleTenantCode",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@RoleName",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@RoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC001H6 ;
          prmBC001H6 = new Object[] {
          new Object[] {"@RoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC001H3 ;
          prmBC001H3 = new Object[] {
          new Object[] {"@RoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC001H2 ;
          prmBC001H2 = new Object[] {
          new Object[] {"@RoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC001H7 ;
          prmBC001H7 = new Object[] {
          new Object[] {"@SYS_RoleTenantCode",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@RoleName",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@RoleType",SqlDbType.Int,9,0} ,
          new Object[] {"@SYS_RoleDescription",SqlDbType.NVarChar,2048,0} ,
          new Object[] {"@SYS_RoleCreator",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@SYS_RoleCreateTime",SqlDbType.DateTime,10,8} ,
          new Object[] {"@SYS_RoleModifier",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@SYS_RoleModifyTime",SqlDbType.DateTime,10,8} ,
          new Object[] {"@SYS_RoleIsDeleted",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@RoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC001H8 ;
          prmBC001H8 = new Object[] {
          new Object[] {"@SYS_RoleTenantCode",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@RoleName",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@RoleType",SqlDbType.Int,9,0} ,
          new Object[] {"@SYS_RoleDescription",SqlDbType.NVarChar,2048,0} ,
          new Object[] {"@SYS_RoleCreator",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@SYS_RoleCreateTime",SqlDbType.DateTime,10,8} ,
          new Object[] {"@SYS_RoleModifier",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@SYS_RoleModifyTime",SqlDbType.DateTime,10,8} ,
          new Object[] {"@SYS_RoleIsDeleted",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@RoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC001H9 ;
          prmBC001H9 = new Object[] {
          new Object[] {"@RoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC001H10 ;
          prmBC001H10 = new Object[] {
          new Object[] {"@RoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC001H11 ;
          prmBC001H11 = new Object[] {
          new Object[] {"@RoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("BC001H2", "SELECT [RoleID], [SYS_RoleTenantCode], [RoleName], [RoleType], [SYS_RoleDescription], [SYS_RoleCreator], [SYS_RoleCreateTime], [SYS_RoleModifier], [SYS_RoleModifyTime], [SYS_RoleIsDeleted] FROM dbo.[SYS_Role] WITH (UPDLOCK) WHERE [RoleID] = @RoleID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001H2,1,0,true,false )
             ,new CursorDef("BC001H3", "SELECT [RoleID], [SYS_RoleTenantCode], [RoleName], [RoleType], [SYS_RoleDescription], [SYS_RoleCreator], [SYS_RoleCreateTime], [SYS_RoleModifier], [SYS_RoleModifyTime], [SYS_RoleIsDeleted] FROM dbo.[SYS_Role] WITH (NOLOCK) WHERE [RoleID] = @RoleID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001H3,1,0,true,false )
             ,new CursorDef("BC001H4", "SELECT TM1.[RoleID], TM1.[SYS_RoleTenantCode], TM1.[RoleName], TM1.[RoleType], TM1.[SYS_RoleDescription], TM1.[SYS_RoleCreator], TM1.[SYS_RoleCreateTime], TM1.[SYS_RoleModifier], TM1.[SYS_RoleModifyTime], TM1.[SYS_RoleIsDeleted] FROM dbo.[SYS_Role] TM1 WITH (NOLOCK) WHERE TM1.[RoleID] = @RoleID ORDER BY TM1.[RoleID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001H4,100,0,true,false )
             ,new CursorDef("BC001H5", "SELECT [SYS_RoleTenantCode] FROM dbo.[SYS_Role] WITH (NOLOCK) WHERE ([SYS_RoleTenantCode] = @SYS_RoleTenantCode AND [RoleName] = @RoleName) AND (Not ( [RoleID] = @RoleID)) ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001H5,1,0,true,false )
             ,new CursorDef("BC001H6", "SELECT [RoleID] FROM dbo.[SYS_Role] WITH (NOLOCK) WHERE [RoleID] = @RoleID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001H6,1,0,true,false )
             ,new CursorDef("BC001H7", "INSERT INTO dbo.[SYS_Role]([SYS_RoleTenantCode], [RoleName], [RoleType], [SYS_RoleDescription], [SYS_RoleCreator], [SYS_RoleCreateTime], [SYS_RoleModifier], [SYS_RoleModifyTime], [SYS_RoleIsDeleted], [RoleID]) VALUES(@SYS_RoleTenantCode, @RoleName, @RoleType, @SYS_RoleDescription, @SYS_RoleCreator, @SYS_RoleCreateTime, @SYS_RoleModifier, @SYS_RoleModifyTime, @SYS_RoleIsDeleted, @RoleID)", GxErrorMask.GX_NOMASK,prmBC001H7)
             ,new CursorDef("BC001H8", "UPDATE dbo.[SYS_Role] SET [SYS_RoleTenantCode]=@SYS_RoleTenantCode, [RoleName]=@RoleName, [RoleType]=@RoleType, [SYS_RoleDescription]=@SYS_RoleDescription, [SYS_RoleCreator]=@SYS_RoleCreator, [SYS_RoleCreateTime]=@SYS_RoleCreateTime, [SYS_RoleModifier]=@SYS_RoleModifier, [SYS_RoleModifyTime]=@SYS_RoleModifyTime, [SYS_RoleIsDeleted]=@SYS_RoleIsDeleted  WHERE [RoleID] = @RoleID", GxErrorMask.GX_NOMASK,prmBC001H8)
             ,new CursorDef("BC001H9", "DELETE FROM dbo.[SYS_Role]  WHERE [RoleID] = @RoleID", GxErrorMask.GX_NOMASK,prmBC001H9)
             ,new CursorDef("BC001H10", "SELECT TOP 1 [UserID], [RoleID] FROM dbo.[SYS_UserRole] WITH (NOLOCK) WHERE [RoleID] = @RoleID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001H10,1,0,true,true )
             ,new CursorDef("BC001H11", "SELECT TM1.[RoleID], TM1.[SYS_RoleTenantCode], TM1.[RoleName], TM1.[RoleType], TM1.[SYS_RoleDescription], TM1.[SYS_RoleCreator], TM1.[SYS_RoleCreateTime], TM1.[SYS_RoleModifier], TM1.[SYS_RoleModifyTime], TM1.[SYS_RoleIsDeleted] FROM dbo.[SYS_Role] TM1 WITH (NOLOCK) WHERE TM1.[RoleID] = @RoleID ORDER BY TM1.[RoleID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001H11,100,0,true,false )
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
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((int[]) buf[4])[0] = rslt.getInt(4) ;
                ((String[]) buf[5])[0] = rslt.getLongVarchar(5) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                ((String[]) buf[7])[0] = rslt.getVarchar(6) ;
                ((DateTime[]) buf[8])[0] = rslt.getGXDateTime(7) ;
                ((String[]) buf[9])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(8);
                ((DateTime[]) buf[11])[0] = rslt.getGXDateTime(9) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(9);
                ((short[]) buf[13])[0] = rslt.getShort(10) ;
                return;
             case 1 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((int[]) buf[4])[0] = rslt.getInt(4) ;
                ((String[]) buf[5])[0] = rslt.getLongVarchar(5) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                ((String[]) buf[7])[0] = rslt.getVarchar(6) ;
                ((DateTime[]) buf[8])[0] = rslt.getGXDateTime(7) ;
                ((String[]) buf[9])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(8);
                ((DateTime[]) buf[11])[0] = rslt.getGXDateTime(9) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(9);
                ((short[]) buf[13])[0] = rslt.getShort(10) ;
                return;
             case 2 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((int[]) buf[4])[0] = rslt.getInt(4) ;
                ((String[]) buf[5])[0] = rslt.getLongVarchar(5) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                ((String[]) buf[7])[0] = rslt.getVarchar(6) ;
                ((DateTime[]) buf[8])[0] = rslt.getGXDateTime(7) ;
                ((String[]) buf[9])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(8);
                ((DateTime[]) buf[11])[0] = rslt.getGXDateTime(9) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(9);
                ((short[]) buf[13])[0] = rslt.getShort(10) ;
                return;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                return;
             case 4 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                return;
             case 8 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                ((Guid[]) buf[1])[0] = rslt.getGuid(2) ;
                return;
             case 9 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((int[]) buf[4])[0] = rslt.getInt(4) ;
                ((String[]) buf[5])[0] = rslt.getLongVarchar(5) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(5);
                ((String[]) buf[7])[0] = rslt.getVarchar(6) ;
                ((DateTime[]) buf[8])[0] = rslt.getGXDateTime(7) ;
                ((String[]) buf[9])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(8);
                ((DateTime[]) buf[11])[0] = rslt.getGXDateTime(9) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(9);
                ((short[]) buf[13])[0] = rslt.getShort(10) ;
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
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                stmt.SetParameter(2, (String)parms[2]);
                stmt.SetParameter(3, (Guid)parms[3]);
                return;
             case 4 :
                stmt.SetParameter(1, (Guid)parms[0]);
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
                stmt.SetParameter(3, (int)parms[3]);
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 4 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(4, (String)parms[5]);
                }
                stmt.SetParameter(5, (String)parms[6]);
                stmt.SetParameterDatetime(6, (DateTime)parms[7]);
                if ( (bool)parms[8] )
                {
                   stmt.setNull( 7 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(7, (String)parms[9]);
                }
                if ( (bool)parms[10] )
                {
                   stmt.setNull( 8 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(8, (DateTime)parms[11]);
                }
                stmt.SetParameter(9, (short)parms[12]);
                stmt.SetParameter(10, (Guid)parms[13]);
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
                stmt.SetParameter(2, (String)parms[2]);
                stmt.SetParameter(3, (int)parms[3]);
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 4 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(4, (String)parms[5]);
                }
                stmt.SetParameter(5, (String)parms[6]);
                stmt.SetParameterDatetime(6, (DateTime)parms[7]);
                if ( (bool)parms[8] )
                {
                   stmt.setNull( 7 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(7, (String)parms[9]);
                }
                if ( (bool)parms[10] )
                {
                   stmt.setNull( 8 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(8, (DateTime)parms[11]);
                }
                stmt.SetParameter(9, (short)parms[12]);
                stmt.SetParameter(10, (Guid)parms[13]);
                return;
             case 7 :
                stmt.SetParameter(1, (Guid)parms[0]);
                return;
             case 8 :
                stmt.SetParameter(1, (Guid)parms[0]);
                return;
             case 9 :
                stmt.SetParameter(1, (Guid)parms[0]);
                return;
       }
    }

    public String getDataStoreName( )
    {
       return "DATASTORE1";
    }

 }

 public class sys_role_bc__default : DataStoreHelperBase, IDataStoreHelper
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
