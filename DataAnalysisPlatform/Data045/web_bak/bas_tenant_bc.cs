/*
               File: BAS_Tenant_BC
        Description: BAS_Tenant
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:38:58.78
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
   public class bas_tenant_bc : GXHttpHandler, IGxSilentTrn
   {
      public bas_tenant_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public bas_tenant_bc( IGxContext context )
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
         ReadRow1F52( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey1F52( ) ;
         standaloneModal( ) ;
         AddRow1F52( ) ;
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

      protected void CONFIRM_1F0( )
      {
         BeforeValidate1F52( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls1F52( ) ;
            }
            else
            {
               CheckExtendedTable1F52( ) ;
               if ( AnyError == 0 )
               {
                  ZM1F52( 4) ;
                  ZM1F52( 5) ;
               }
               CloseExtendedTableCursors1F52( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void ZM1F52( short GX_JID )
      {
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            Z394TenantName = A394TenantName;
            Z395HospitalName = A395HospitalName;
            Z397BAS_TenantCreator = A397BAS_TenantCreator;
            Z398BAS_TenantCreateTime = A398BAS_TenantCreateTime;
            Z399BAS_TenantModifier = A399BAS_TenantModifier;
            Z400BAS_TenantModifyTime = A400BAS_TenantModifyTime;
            Z401BAS_TenantIsDeleted = A401BAS_TenantIsDeleted;
            Z358InstituteCode = A358InstituteCode;
            Z365DatabaseID = A365DatabaseID;
         }
         if ( ( GX_JID == 4 ) || ( GX_JID == 0 ) )
         {
         }
         if ( ( GX_JID == 5 ) || ( GX_JID == 0 ) )
         {
         }
         if ( GX_JID == -3 )
         {
            Z360BAS_TenantTenantCode = A360BAS_TenantTenantCode;
            Z394TenantName = A394TenantName;
            Z395HospitalName = A395HospitalName;
            Z396BAS_TenantLogo = A396BAS_TenantLogo;
            Z397BAS_TenantCreator = A397BAS_TenantCreator;
            Z398BAS_TenantCreateTime = A398BAS_TenantCreateTime;
            Z399BAS_TenantModifier = A399BAS_TenantModifier;
            Z400BAS_TenantModifyTime = A400BAS_TenantModifyTime;
            Z401BAS_TenantIsDeleted = A401BAS_TenantIsDeleted;
            Z402BAS_TenantDescription = A402BAS_TenantDescription;
            Z358InstituteCode = A358InstituteCode;
            Z365DatabaseID = A365DatabaseID;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load1F52( )
      {
         /* Using cursor BC001F6 */
         pr_datastore1.execute(4, new Object[] {A360BAS_TenantTenantCode});
         if ( (pr_datastore1.getStatus(4) != 101) )
         {
            RcdFound52 = 1;
            A394TenantName = BC001F6_A394TenantName[0];
            A395HospitalName = BC001F6_A395HospitalName[0];
            A397BAS_TenantCreator = BC001F6_A397BAS_TenantCreator[0];
            A398BAS_TenantCreateTime = BC001F6_A398BAS_TenantCreateTime[0];
            A399BAS_TenantModifier = BC001F6_A399BAS_TenantModifier[0];
            n399BAS_TenantModifier = BC001F6_n399BAS_TenantModifier[0];
            A400BAS_TenantModifyTime = BC001F6_A400BAS_TenantModifyTime[0];
            n400BAS_TenantModifyTime = BC001F6_n400BAS_TenantModifyTime[0];
            A401BAS_TenantIsDeleted = BC001F6_A401BAS_TenantIsDeleted[0];
            A402BAS_TenantDescription = BC001F6_A402BAS_TenantDescription[0];
            n402BAS_TenantDescription = BC001F6_n402BAS_TenantDescription[0];
            A358InstituteCode = BC001F6_A358InstituteCode[0];
            n358InstituteCode = BC001F6_n358InstituteCode[0];
            A365DatabaseID = BC001F6_A365DatabaseID[0];
            A396BAS_TenantLogo = BC001F6_A396BAS_TenantLogo[0];
            n396BAS_TenantLogo = BC001F6_n396BAS_TenantLogo[0];
            ZM1F52( -3) ;
         }
         pr_datastore1.close(4);
         OnLoadActions1F52( ) ;
      }

      protected void OnLoadActions1F52( )
      {
      }

      protected void CheckExtendedTable1F52( )
      {
         standaloneModal( ) ;
         /* Using cursor BC001F4 */
         pr_datastore1.execute(2, new Object[] {n358InstituteCode, A358InstituteCode});
         if ( (pr_datastore1.getStatus(2) == 101) )
         {
            if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( A358InstituteCode)) ) )
            {
               GX_msglist.addItem("不匹配'BAS_Institute'", "ForeignKeyNotFound", 1, "INSTITUTECODE");
               AnyError = 1;
            }
         }
         pr_datastore1.close(2);
         /* Using cursor BC001F5 */
         pr_datastore1.execute(3, new Object[] {A365DatabaseID});
         if ( (pr_datastore1.getStatus(3) == 101) )
         {
            GX_msglist.addItem("不匹配'SYS_Database'", "ForeignKeyNotFound", 1, "DATABASEID");
            AnyError = 1;
         }
         pr_datastore1.close(3);
         if ( ! ( (DateTime.MinValue==A398BAS_TenantCreateTime) || ( A398BAS_TenantCreateTime >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("域BAS_Tenant Create Time超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
         if ( ! ( (DateTime.MinValue==A400BAS_TenantModifyTime) || ( A400BAS_TenantModifyTime >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("域BAS_Tenant Modify Time超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
      }

      protected void CloseExtendedTableCursors1F52( )
      {
         pr_datastore1.close(2);
         pr_datastore1.close(3);
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey1F52( )
      {
         /* Using cursor BC001F7 */
         pr_datastore1.execute(5, new Object[] {A360BAS_TenantTenantCode});
         if ( (pr_datastore1.getStatus(5) != 101) )
         {
            RcdFound52 = 1;
         }
         else
         {
            RcdFound52 = 0;
         }
         pr_datastore1.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC001F3 */
         pr_datastore1.execute(1, new Object[] {A360BAS_TenantTenantCode});
         if ( (pr_datastore1.getStatus(1) != 101) )
         {
            ZM1F52( 3) ;
            RcdFound52 = 1;
            A360BAS_TenantTenantCode = BC001F3_A360BAS_TenantTenantCode[0];
            A394TenantName = BC001F3_A394TenantName[0];
            A395HospitalName = BC001F3_A395HospitalName[0];
            A397BAS_TenantCreator = BC001F3_A397BAS_TenantCreator[0];
            A398BAS_TenantCreateTime = BC001F3_A398BAS_TenantCreateTime[0];
            A399BAS_TenantModifier = BC001F3_A399BAS_TenantModifier[0];
            n399BAS_TenantModifier = BC001F3_n399BAS_TenantModifier[0];
            A400BAS_TenantModifyTime = BC001F3_A400BAS_TenantModifyTime[0];
            n400BAS_TenantModifyTime = BC001F3_n400BAS_TenantModifyTime[0];
            A401BAS_TenantIsDeleted = BC001F3_A401BAS_TenantIsDeleted[0];
            A402BAS_TenantDescription = BC001F3_A402BAS_TenantDescription[0];
            n402BAS_TenantDescription = BC001F3_n402BAS_TenantDescription[0];
            A358InstituteCode = BC001F3_A358InstituteCode[0];
            n358InstituteCode = BC001F3_n358InstituteCode[0];
            A365DatabaseID = BC001F3_A365DatabaseID[0];
            A396BAS_TenantLogo = BC001F3_A396BAS_TenantLogo[0];
            n396BAS_TenantLogo = BC001F3_n396BAS_TenantLogo[0];
            Z360BAS_TenantTenantCode = A360BAS_TenantTenantCode;
            sMode52 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load1F52( ) ;
            if ( AnyError == 1 )
            {
               RcdFound52 = 0;
               InitializeNonKey1F52( ) ;
            }
            Gx_mode = sMode52;
         }
         else
         {
            RcdFound52 = 0;
            InitializeNonKey1F52( ) ;
            sMode52 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode52;
         }
         pr_datastore1.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1F52( ) ;
         if ( RcdFound52 == 0 )
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
         CONFIRM_1F0( ) ;
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

      protected void CheckOptimisticConcurrency1F52( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC001F2 */
            pr_datastore1.execute(0, new Object[] {A360BAS_TenantTenantCode});
            if ( (pr_datastore1.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BAS_TENANT"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_datastore1.getStatus(0) == 101) || ( StringUtil.StrCmp(Z394TenantName, BC001F2_A394TenantName[0]) != 0 ) || ( StringUtil.StrCmp(Z395HospitalName, BC001F2_A395HospitalName[0]) != 0 ) || ( StringUtil.StrCmp(Z397BAS_TenantCreator, BC001F2_A397BAS_TenantCreator[0]) != 0 ) || ( Z398BAS_TenantCreateTime != BC001F2_A398BAS_TenantCreateTime[0] ) || ( StringUtil.StrCmp(Z399BAS_TenantModifier, BC001F2_A399BAS_TenantModifier[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z400BAS_TenantModifyTime != BC001F2_A400BAS_TenantModifyTime[0] ) || ( Z401BAS_TenantIsDeleted != BC001F2_A401BAS_TenantIsDeleted[0] ) || ( StringUtil.StrCmp(Z358InstituteCode, BC001F2_A358InstituteCode[0]) != 0 ) || ( Z365DatabaseID != BC001F2_A365DatabaseID[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"BAS_TENANT"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert1F52( )
      {
         BeforeValidate1F52( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1F52( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1F52( 0) ;
            CheckOptimisticConcurrency1F52( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1F52( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1F52( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC001F8 */
                     pr_datastore1.execute(6, new Object[] {A360BAS_TenantTenantCode, A394TenantName, A395HospitalName, n396BAS_TenantLogo, A396BAS_TenantLogo, A397BAS_TenantCreator, A398BAS_TenantCreateTime, n399BAS_TenantModifier, A399BAS_TenantModifier, n400BAS_TenantModifyTime, A400BAS_TenantModifyTime, A401BAS_TenantIsDeleted, n402BAS_TenantDescription, A402BAS_TenantDescription, n358InstituteCode, A358InstituteCode, A365DatabaseID});
                     pr_datastore1.close(6);
                     dsDataStore1.SmartCacheProvider.SetUpdated("BAS_TENANT") ;
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
               Load1F52( ) ;
            }
            EndLevel1F52( ) ;
         }
         CloseExtendedTableCursors1F52( ) ;
      }

      protected void Update1F52( )
      {
         BeforeValidate1F52( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1F52( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1F52( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1F52( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1F52( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC001F9 */
                     pr_datastore1.execute(7, new Object[] {A394TenantName, A395HospitalName, A397BAS_TenantCreator, A398BAS_TenantCreateTime, n399BAS_TenantModifier, A399BAS_TenantModifier, n400BAS_TenantModifyTime, A400BAS_TenantModifyTime, A401BAS_TenantIsDeleted, n402BAS_TenantDescription, A402BAS_TenantDescription, n358InstituteCode, A358InstituteCode, A365DatabaseID, A360BAS_TenantTenantCode});
                     pr_datastore1.close(7);
                     dsDataStore1.SmartCacheProvider.SetUpdated("BAS_TENANT") ;
                     if ( (pr_datastore1.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BAS_TENANT"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate1F52( ) ;
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
            EndLevel1F52( ) ;
         }
         CloseExtendedTableCursors1F52( ) ;
      }

      protected void DeferredUpdate1F52( )
      {
         if ( AnyError == 0 )
         {
            /* Using cursor BC001F10 */
            pr_datastore1.execute(8, new Object[] {n396BAS_TenantLogo, A396BAS_TenantLogo, A360BAS_TenantTenantCode});
            pr_datastore1.close(8);
            dsDataStore1.SmartCacheProvider.SetUpdated("BAS_TENANT") ;
         }
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate1F52( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1F52( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1F52( ) ;
            AfterConfirm1F52( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1F52( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC001F11 */
                  pr_datastore1.execute(9, new Object[] {A360BAS_TenantTenantCode});
                  pr_datastore1.close(9);
                  dsDataStore1.SmartCacheProvider.SetUpdated("BAS_TENANT") ;
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
         sMode52 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel1F52( ) ;
         Gx_mode = sMode52;
      }

      protected void OnDeleteControls1F52( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor BC001F12 */
            pr_default.execute(0, new Object[] {A360BAS_TenantTenantCode});
            if ( (pr_default.getStatus(0) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {" T64"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(0);
            /* Using cursor BC001F13 */
            pr_datastore1.execute(10, new Object[] {A360BAS_TenantTenantCode});
            if ( (pr_datastore1.getStatus(10) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"SYS_Tenant User"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_datastore1.close(10);
         }
      }

      protected void EndLevel1F52( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_datastore1.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1F52( ) ;
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

      public void ScanKeyStart1F52( )
      {
         /* Using cursor BC001F14 */
         pr_datastore1.execute(11, new Object[] {A360BAS_TenantTenantCode});
         RcdFound52 = 0;
         if ( (pr_datastore1.getStatus(11) != 101) )
         {
            RcdFound52 = 1;
            A360BAS_TenantTenantCode = BC001F14_A360BAS_TenantTenantCode[0];
            A394TenantName = BC001F14_A394TenantName[0];
            A395HospitalName = BC001F14_A395HospitalName[0];
            A397BAS_TenantCreator = BC001F14_A397BAS_TenantCreator[0];
            A398BAS_TenantCreateTime = BC001F14_A398BAS_TenantCreateTime[0];
            A399BAS_TenantModifier = BC001F14_A399BAS_TenantModifier[0];
            n399BAS_TenantModifier = BC001F14_n399BAS_TenantModifier[0];
            A400BAS_TenantModifyTime = BC001F14_A400BAS_TenantModifyTime[0];
            n400BAS_TenantModifyTime = BC001F14_n400BAS_TenantModifyTime[0];
            A401BAS_TenantIsDeleted = BC001F14_A401BAS_TenantIsDeleted[0];
            A402BAS_TenantDescription = BC001F14_A402BAS_TenantDescription[0];
            n402BAS_TenantDescription = BC001F14_n402BAS_TenantDescription[0];
            A358InstituteCode = BC001F14_A358InstituteCode[0];
            n358InstituteCode = BC001F14_n358InstituteCode[0];
            A365DatabaseID = BC001F14_A365DatabaseID[0];
            A396BAS_TenantLogo = BC001F14_A396BAS_TenantLogo[0];
            n396BAS_TenantLogo = BC001F14_n396BAS_TenantLogo[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext1F52( )
      {
         /* Scan next routine */
         pr_datastore1.readNext(11);
         RcdFound52 = 0;
         ScanKeyLoad1F52( ) ;
      }

      protected void ScanKeyLoad1F52( )
      {
         sMode52 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_datastore1.getStatus(11) != 101) )
         {
            RcdFound52 = 1;
            A360BAS_TenantTenantCode = BC001F14_A360BAS_TenantTenantCode[0];
            A394TenantName = BC001F14_A394TenantName[0];
            A395HospitalName = BC001F14_A395HospitalName[0];
            A397BAS_TenantCreator = BC001F14_A397BAS_TenantCreator[0];
            A398BAS_TenantCreateTime = BC001F14_A398BAS_TenantCreateTime[0];
            A399BAS_TenantModifier = BC001F14_A399BAS_TenantModifier[0];
            n399BAS_TenantModifier = BC001F14_n399BAS_TenantModifier[0];
            A400BAS_TenantModifyTime = BC001F14_A400BAS_TenantModifyTime[0];
            n400BAS_TenantModifyTime = BC001F14_n400BAS_TenantModifyTime[0];
            A401BAS_TenantIsDeleted = BC001F14_A401BAS_TenantIsDeleted[0];
            A402BAS_TenantDescription = BC001F14_A402BAS_TenantDescription[0];
            n402BAS_TenantDescription = BC001F14_n402BAS_TenantDescription[0];
            A358InstituteCode = BC001F14_A358InstituteCode[0];
            n358InstituteCode = BC001F14_n358InstituteCode[0];
            A365DatabaseID = BC001F14_A365DatabaseID[0];
            A396BAS_TenantLogo = BC001F14_A396BAS_TenantLogo[0];
            n396BAS_TenantLogo = BC001F14_n396BAS_TenantLogo[0];
         }
         Gx_mode = sMode52;
      }

      protected void ScanKeyEnd1F52( )
      {
         pr_datastore1.close(11);
      }

      protected void AfterConfirm1F52( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1F52( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1F52( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1F52( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1F52( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1F52( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1F52( )
      {
      }

      protected void send_integrity_lvl_hashes1F52( )
      {
      }

      protected void AddRow1F52( )
      {
         VarsToRow52( bcBAS_Tenant) ;
      }

      protected void ReadRow1F52( )
      {
         RowToVars52( bcBAS_Tenant, 1) ;
      }

      protected void InitializeNonKey1F52( )
      {
         A394TenantName = "";
         A358InstituteCode = "";
         n358InstituteCode = false;
         A395HospitalName = "";
         A365DatabaseID = 0;
         A396BAS_TenantLogo = "";
         n396BAS_TenantLogo = false;
         A397BAS_TenantCreator = "";
         A398BAS_TenantCreateTime = (DateTime)(DateTime.MinValue);
         A399BAS_TenantModifier = "";
         n399BAS_TenantModifier = false;
         A400BAS_TenantModifyTime = (DateTime)(DateTime.MinValue);
         n400BAS_TenantModifyTime = false;
         A401BAS_TenantIsDeleted = 0;
         A402BAS_TenantDescription = "";
         n402BAS_TenantDescription = false;
         Z394TenantName = "";
         Z395HospitalName = "";
         Z397BAS_TenantCreator = "";
         Z398BAS_TenantCreateTime = (DateTime)(DateTime.MinValue);
         Z399BAS_TenantModifier = "";
         Z400BAS_TenantModifyTime = (DateTime)(DateTime.MinValue);
         Z401BAS_TenantIsDeleted = 0;
         Z358InstituteCode = "";
         Z365DatabaseID = 0;
      }

      protected void InitAll1F52( )
      {
         A360BAS_TenantTenantCode = "";
         InitializeNonKey1F52( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow52( SdtBAS_Tenant obj52 )
      {
         obj52.gxTpr_Mode = Gx_mode;
         obj52.gxTpr_Tenantname = A394TenantName;
         obj52.gxTpr_Institutecode = A358InstituteCode;
         obj52.gxTpr_Hospitalname = A395HospitalName;
         obj52.gxTpr_Databaseid = A365DatabaseID;
         obj52.gxTpr_Bas_tenantlogo = A396BAS_TenantLogo;
         obj52.gxTpr_Bas_tenantcreator = A397BAS_TenantCreator;
         obj52.gxTpr_Bas_tenantcreatetime = A398BAS_TenantCreateTime;
         obj52.gxTpr_Bas_tenantmodifier = A399BAS_TenantModifier;
         obj52.gxTpr_Bas_tenantmodifytime = A400BAS_TenantModifyTime;
         obj52.gxTpr_Bas_tenantisdeleted = A401BAS_TenantIsDeleted;
         obj52.gxTpr_Bas_tenantdescription = A402BAS_TenantDescription;
         obj52.gxTpr_Bas_tenanttenantcode = A360BAS_TenantTenantCode;
         obj52.gxTpr_Bas_tenanttenantcode_Z = Z360BAS_TenantTenantCode;
         obj52.gxTpr_Tenantname_Z = Z394TenantName;
         obj52.gxTpr_Institutecode_Z = Z358InstituteCode;
         obj52.gxTpr_Hospitalname_Z = Z395HospitalName;
         obj52.gxTpr_Databaseid_Z = Z365DatabaseID;
         obj52.gxTpr_Bas_tenantcreator_Z = Z397BAS_TenantCreator;
         obj52.gxTpr_Bas_tenantcreatetime_Z = Z398BAS_TenantCreateTime;
         obj52.gxTpr_Bas_tenantmodifier_Z = Z399BAS_TenantModifier;
         obj52.gxTpr_Bas_tenantmodifytime_Z = Z400BAS_TenantModifyTime;
         obj52.gxTpr_Bas_tenantisdeleted_Z = Z401BAS_TenantIsDeleted;
         obj52.gxTpr_Institutecode_N = (short)(Convert.ToInt16(n358InstituteCode));
         obj52.gxTpr_Bas_tenantlogo_N = (short)(Convert.ToInt16(n396BAS_TenantLogo));
         obj52.gxTpr_Bas_tenantmodifier_N = (short)(Convert.ToInt16(n399BAS_TenantModifier));
         obj52.gxTpr_Bas_tenantmodifytime_N = (short)(Convert.ToInt16(n400BAS_TenantModifyTime));
         obj52.gxTpr_Bas_tenantdescription_N = (short)(Convert.ToInt16(n402BAS_TenantDescription));
         obj52.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow52( SdtBAS_Tenant obj52 )
      {
         obj52.gxTpr_Bas_tenanttenantcode = A360BAS_TenantTenantCode;
         return  ;
      }

      public void RowToVars52( SdtBAS_Tenant obj52 ,
                               int forceLoad )
      {
         Gx_mode = obj52.gxTpr_Mode;
         A394TenantName = obj52.gxTpr_Tenantname;
         A358InstituteCode = obj52.gxTpr_Institutecode;
         n358InstituteCode = false;
         A395HospitalName = obj52.gxTpr_Hospitalname;
         A365DatabaseID = obj52.gxTpr_Databaseid;
         A396BAS_TenantLogo = obj52.gxTpr_Bas_tenantlogo;
         n396BAS_TenantLogo = false;
         A397BAS_TenantCreator = obj52.gxTpr_Bas_tenantcreator;
         A398BAS_TenantCreateTime = obj52.gxTpr_Bas_tenantcreatetime;
         A399BAS_TenantModifier = obj52.gxTpr_Bas_tenantmodifier;
         n399BAS_TenantModifier = false;
         A400BAS_TenantModifyTime = obj52.gxTpr_Bas_tenantmodifytime;
         n400BAS_TenantModifyTime = false;
         A401BAS_TenantIsDeleted = obj52.gxTpr_Bas_tenantisdeleted;
         A402BAS_TenantDescription = obj52.gxTpr_Bas_tenantdescription;
         n402BAS_TenantDescription = false;
         A360BAS_TenantTenantCode = obj52.gxTpr_Bas_tenanttenantcode;
         Z360BAS_TenantTenantCode = obj52.gxTpr_Bas_tenanttenantcode_Z;
         Z394TenantName = obj52.gxTpr_Tenantname_Z;
         Z358InstituteCode = obj52.gxTpr_Institutecode_Z;
         Z395HospitalName = obj52.gxTpr_Hospitalname_Z;
         Z365DatabaseID = obj52.gxTpr_Databaseid_Z;
         Z397BAS_TenantCreator = obj52.gxTpr_Bas_tenantcreator_Z;
         Z398BAS_TenantCreateTime = obj52.gxTpr_Bas_tenantcreatetime_Z;
         Z399BAS_TenantModifier = obj52.gxTpr_Bas_tenantmodifier_Z;
         Z400BAS_TenantModifyTime = obj52.gxTpr_Bas_tenantmodifytime_Z;
         Z401BAS_TenantIsDeleted = obj52.gxTpr_Bas_tenantisdeleted_Z;
         n358InstituteCode = (bool)(Convert.ToBoolean(obj52.gxTpr_Institutecode_N));
         n396BAS_TenantLogo = (bool)(Convert.ToBoolean(obj52.gxTpr_Bas_tenantlogo_N));
         n399BAS_TenantModifier = (bool)(Convert.ToBoolean(obj52.gxTpr_Bas_tenantmodifier_N));
         n400BAS_TenantModifyTime = (bool)(Convert.ToBoolean(obj52.gxTpr_Bas_tenantmodifytime_N));
         n402BAS_TenantDescription = (bool)(Convert.ToBoolean(obj52.gxTpr_Bas_tenantdescription_N));
         Gx_mode = obj52.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A360BAS_TenantTenantCode = (String)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey1F52( ) ;
         ScanKeyStart1F52( ) ;
         if ( RcdFound52 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z360BAS_TenantTenantCode = A360BAS_TenantTenantCode;
         }
         ZM1F52( -3) ;
         OnLoadActions1F52( ) ;
         AddRow1F52( ) ;
         ScanKeyEnd1F52( ) ;
         if ( RcdFound52 == 0 )
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
         RowToVars52( bcBAS_Tenant, 0) ;
         ScanKeyStart1F52( ) ;
         if ( RcdFound52 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z360BAS_TenantTenantCode = A360BAS_TenantTenantCode;
         }
         ZM1F52( -3) ;
         OnLoadActions1F52( ) ;
         AddRow1F52( ) ;
         ScanKeyEnd1F52( ) ;
         if ( RcdFound52 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey1F52( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert1F52( ) ;
         }
         else
         {
            if ( RcdFound52 == 1 )
            {
               if ( StringUtil.StrCmp(A360BAS_TenantTenantCode, Z360BAS_TenantTenantCode) != 0 )
               {
                  A360BAS_TenantTenantCode = Z360BAS_TenantTenantCode;
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
                  Update1F52( ) ;
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
                  if ( StringUtil.StrCmp(A360BAS_TenantTenantCode, Z360BAS_TenantTenantCode) != 0 )
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
                        Insert1F52( ) ;
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
                        Insert1F52( ) ;
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
         RowToVars52( bcBAS_Tenant, 0) ;
         SaveImpl( ) ;
         VarsToRow52( bcBAS_Tenant) ;
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
         RowToVars52( bcBAS_Tenant, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert1F52( ) ;
         AfterTrn( ) ;
         VarsToRow52( bcBAS_Tenant) ;
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
            SdtBAS_Tenant auxBC = new SdtBAS_Tenant(context) ;
            auxBC.Load(A360BAS_TenantTenantCode);
            auxBC.UpdateDirties(bcBAS_Tenant);
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
         RowToVars52( bcBAS_Tenant, 0) ;
         UpdateImpl( ) ;
         VarsToRow52( bcBAS_Tenant) ;
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
         RowToVars52( bcBAS_Tenant, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert1F52( ) ;
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
         VarsToRow52( bcBAS_Tenant) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars52( bcBAS_Tenant, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey1F52( ) ;
         if ( RcdFound52 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( StringUtil.StrCmp(A360BAS_TenantTenantCode, Z360BAS_TenantTenantCode) != 0 )
            {
               A360BAS_TenantTenantCode = Z360BAS_TenantTenantCode;
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
            if ( StringUtil.StrCmp(A360BAS_TenantTenantCode, Z360BAS_TenantTenantCode) != 0 )
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
         context.RollbackDataStores("bas_tenant_bc",pr_default);
         VarsToRow52( bcBAS_Tenant) ;
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
         Gx_mode = bcBAS_Tenant.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcBAS_Tenant.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcBAS_Tenant )
         {
            bcBAS_Tenant = (SdtBAS_Tenant)(sdt);
            if ( StringUtil.StrCmp(bcBAS_Tenant.gxTpr_Mode, "") == 0 )
            {
               bcBAS_Tenant.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow52( bcBAS_Tenant) ;
            }
            else
            {
               RowToVars52( bcBAS_Tenant, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcBAS_Tenant.gxTpr_Mode, "") == 0 )
            {
               bcBAS_Tenant.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars52( bcBAS_Tenant, 1) ;
         return  ;
      }

      public SdtBAS_Tenant BAS_Tenant_BC
      {
         get {
            return bcBAS_Tenant ;
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
         Z360BAS_TenantTenantCode = "";
         A360BAS_TenantTenantCode = "";
         Z394TenantName = "";
         A394TenantName = "";
         Z395HospitalName = "";
         A395HospitalName = "";
         Z397BAS_TenantCreator = "";
         A397BAS_TenantCreator = "";
         Z398BAS_TenantCreateTime = (DateTime)(DateTime.MinValue);
         A398BAS_TenantCreateTime = (DateTime)(DateTime.MinValue);
         Z399BAS_TenantModifier = "";
         A399BAS_TenantModifier = "";
         Z400BAS_TenantModifyTime = (DateTime)(DateTime.MinValue);
         A400BAS_TenantModifyTime = (DateTime)(DateTime.MinValue);
         Z358InstituteCode = "";
         A358InstituteCode = "";
         Z396BAS_TenantLogo = "";
         A396BAS_TenantLogo = "";
         Z402BAS_TenantDescription = "";
         A402BAS_TenantDescription = "";
         BC001F6_A360BAS_TenantTenantCode = new String[] {""} ;
         BC001F6_A394TenantName = new String[] {""} ;
         BC001F6_A395HospitalName = new String[] {""} ;
         BC001F6_A397BAS_TenantCreator = new String[] {""} ;
         BC001F6_A398BAS_TenantCreateTime = new DateTime[] {DateTime.MinValue} ;
         BC001F6_A399BAS_TenantModifier = new String[] {""} ;
         BC001F6_n399BAS_TenantModifier = new bool[] {false} ;
         BC001F6_A400BAS_TenantModifyTime = new DateTime[] {DateTime.MinValue} ;
         BC001F6_n400BAS_TenantModifyTime = new bool[] {false} ;
         BC001F6_A401BAS_TenantIsDeleted = new short[1] ;
         BC001F6_A402BAS_TenantDescription = new String[] {""} ;
         BC001F6_n402BAS_TenantDescription = new bool[] {false} ;
         BC001F6_A358InstituteCode = new String[] {""} ;
         BC001F6_n358InstituteCode = new bool[] {false} ;
         BC001F6_A365DatabaseID = new int[1] ;
         BC001F6_A396BAS_TenantLogo = new String[] {""} ;
         BC001F6_n396BAS_TenantLogo = new bool[] {false} ;
         BC001F4_A358InstituteCode = new String[] {""} ;
         BC001F4_n358InstituteCode = new bool[] {false} ;
         BC001F5_A365DatabaseID = new int[1] ;
         BC001F7_A360BAS_TenantTenantCode = new String[] {""} ;
         BC001F3_A360BAS_TenantTenantCode = new String[] {""} ;
         BC001F3_A394TenantName = new String[] {""} ;
         BC001F3_A395HospitalName = new String[] {""} ;
         BC001F3_A397BAS_TenantCreator = new String[] {""} ;
         BC001F3_A398BAS_TenantCreateTime = new DateTime[] {DateTime.MinValue} ;
         BC001F3_A399BAS_TenantModifier = new String[] {""} ;
         BC001F3_n399BAS_TenantModifier = new bool[] {false} ;
         BC001F3_A400BAS_TenantModifyTime = new DateTime[] {DateTime.MinValue} ;
         BC001F3_n400BAS_TenantModifyTime = new bool[] {false} ;
         BC001F3_A401BAS_TenantIsDeleted = new short[1] ;
         BC001F3_A402BAS_TenantDescription = new String[] {""} ;
         BC001F3_n402BAS_TenantDescription = new bool[] {false} ;
         BC001F3_A358InstituteCode = new String[] {""} ;
         BC001F3_n358InstituteCode = new bool[] {false} ;
         BC001F3_A365DatabaseID = new int[1] ;
         BC001F3_A396BAS_TenantLogo = new String[] {""} ;
         BC001F3_n396BAS_TenantLogo = new bool[] {false} ;
         sMode52 = "";
         BC001F2_A360BAS_TenantTenantCode = new String[] {""} ;
         BC001F2_A394TenantName = new String[] {""} ;
         BC001F2_A395HospitalName = new String[] {""} ;
         BC001F2_A397BAS_TenantCreator = new String[] {""} ;
         BC001F2_A398BAS_TenantCreateTime = new DateTime[] {DateTime.MinValue} ;
         BC001F2_A399BAS_TenantModifier = new String[] {""} ;
         BC001F2_n399BAS_TenantModifier = new bool[] {false} ;
         BC001F2_A400BAS_TenantModifyTime = new DateTime[] {DateTime.MinValue} ;
         BC001F2_n400BAS_TenantModifyTime = new bool[] {false} ;
         BC001F2_A401BAS_TenantIsDeleted = new short[1] ;
         BC001F2_A402BAS_TenantDescription = new String[] {""} ;
         BC001F2_n402BAS_TenantDescription = new bool[] {false} ;
         BC001F2_A358InstituteCode = new String[] {""} ;
         BC001F2_n358InstituteCode = new bool[] {false} ;
         BC001F2_A365DatabaseID = new int[1] ;
         BC001F2_A396BAS_TenantLogo = new String[] {""} ;
         BC001F2_n396BAS_TenantLogo = new bool[] {false} ;
         BC001F12_A85BR_Information_ID = new long[1] ;
         BC001F12_A360BAS_TenantTenantCode = new String[] {""} ;
         BC001F13_A360BAS_TenantTenantCode = new String[] {""} ;
         BC001F13_A359UserID = new Guid[] {Guid.Empty} ;
         BC001F14_A360BAS_TenantTenantCode = new String[] {""} ;
         BC001F14_A394TenantName = new String[] {""} ;
         BC001F14_A395HospitalName = new String[] {""} ;
         BC001F14_A397BAS_TenantCreator = new String[] {""} ;
         BC001F14_A398BAS_TenantCreateTime = new DateTime[] {DateTime.MinValue} ;
         BC001F14_A399BAS_TenantModifier = new String[] {""} ;
         BC001F14_n399BAS_TenantModifier = new bool[] {false} ;
         BC001F14_A400BAS_TenantModifyTime = new DateTime[] {DateTime.MinValue} ;
         BC001F14_n400BAS_TenantModifyTime = new bool[] {false} ;
         BC001F14_A401BAS_TenantIsDeleted = new short[1] ;
         BC001F14_A402BAS_TenantDescription = new String[] {""} ;
         BC001F14_n402BAS_TenantDescription = new bool[] {false} ;
         BC001F14_A358InstituteCode = new String[] {""} ;
         BC001F14_n358InstituteCode = new bool[] {false} ;
         BC001F14_A365DatabaseID = new int[1] ;
         BC001F14_A396BAS_TenantLogo = new String[] {""} ;
         BC001F14_n396BAS_TenantLogo = new bool[] {false} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.bas_tenant_bc__datastore1(),
            new Object[][] {
                new Object[] {
               BC001F2_A360BAS_TenantTenantCode, BC001F2_A394TenantName, BC001F2_A395HospitalName, BC001F2_A397BAS_TenantCreator, BC001F2_A398BAS_TenantCreateTime, BC001F2_A399BAS_TenantModifier, BC001F2_n399BAS_TenantModifier, BC001F2_A400BAS_TenantModifyTime, BC001F2_n400BAS_TenantModifyTime, BC001F2_A401BAS_TenantIsDeleted,
               BC001F2_A402BAS_TenantDescription, BC001F2_n402BAS_TenantDescription, BC001F2_A358InstituteCode, BC001F2_n358InstituteCode, BC001F2_A365DatabaseID, BC001F2_A396BAS_TenantLogo, BC001F2_n396BAS_TenantLogo
               }
               , new Object[] {
               BC001F3_A360BAS_TenantTenantCode, BC001F3_A394TenantName, BC001F3_A395HospitalName, BC001F3_A397BAS_TenantCreator, BC001F3_A398BAS_TenantCreateTime, BC001F3_A399BAS_TenantModifier, BC001F3_n399BAS_TenantModifier, BC001F3_A400BAS_TenantModifyTime, BC001F3_n400BAS_TenantModifyTime, BC001F3_A401BAS_TenantIsDeleted,
               BC001F3_A402BAS_TenantDescription, BC001F3_n402BAS_TenantDescription, BC001F3_A358InstituteCode, BC001F3_n358InstituteCode, BC001F3_A365DatabaseID, BC001F3_A396BAS_TenantLogo, BC001F3_n396BAS_TenantLogo
               }
               , new Object[] {
               BC001F4_A358InstituteCode
               }
               , new Object[] {
               BC001F5_A365DatabaseID
               }
               , new Object[] {
               BC001F6_A360BAS_TenantTenantCode, BC001F6_A394TenantName, BC001F6_A395HospitalName, BC001F6_A397BAS_TenantCreator, BC001F6_A398BAS_TenantCreateTime, BC001F6_A399BAS_TenantModifier, BC001F6_n399BAS_TenantModifier, BC001F6_A400BAS_TenantModifyTime, BC001F6_n400BAS_TenantModifyTime, BC001F6_A401BAS_TenantIsDeleted,
               BC001F6_A402BAS_TenantDescription, BC001F6_n402BAS_TenantDescription, BC001F6_A358InstituteCode, BC001F6_n358InstituteCode, BC001F6_A365DatabaseID, BC001F6_A396BAS_TenantLogo, BC001F6_n396BAS_TenantLogo
               }
               , new Object[] {
               BC001F7_A360BAS_TenantTenantCode
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC001F13_A360BAS_TenantTenantCode, BC001F13_A359UserID
               }
               , new Object[] {
               BC001F14_A360BAS_TenantTenantCode, BC001F14_A394TenantName, BC001F14_A395HospitalName, BC001F14_A397BAS_TenantCreator, BC001F14_A398BAS_TenantCreateTime, BC001F14_A399BAS_TenantModifier, BC001F14_n399BAS_TenantModifier, BC001F14_A400BAS_TenantModifyTime, BC001F14_n400BAS_TenantModifyTime, BC001F14_A401BAS_TenantIsDeleted,
               BC001F14_A402BAS_TenantDescription, BC001F14_n402BAS_TenantDescription, BC001F14_A358InstituteCode, BC001F14_n358InstituteCode, BC001F14_A365DatabaseID, BC001F14_A396BAS_TenantLogo, BC001F14_n396BAS_TenantLogo
               }
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.bas_tenant_bc__default(),
            new Object[][] {
                new Object[] {
               BC001F12_A85BR_Information_ID, BC001F12_A360BAS_TenantTenantCode
               }
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
      private short Z401BAS_TenantIsDeleted ;
      private short A401BAS_TenantIsDeleted ;
      private short RcdFound52 ;
      private int trnEnded ;
      private int Z365DatabaseID ;
      private int A365DatabaseID ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String sMode52 ;
      private DateTime Z398BAS_TenantCreateTime ;
      private DateTime A398BAS_TenantCreateTime ;
      private DateTime Z400BAS_TenantModifyTime ;
      private DateTime A400BAS_TenantModifyTime ;
      private bool n399BAS_TenantModifier ;
      private bool n400BAS_TenantModifyTime ;
      private bool n402BAS_TenantDescription ;
      private bool n358InstituteCode ;
      private bool n396BAS_TenantLogo ;
      private bool Gx_longc ;
      private String Z402BAS_TenantDescription ;
      private String A402BAS_TenantDescription ;
      private String Z360BAS_TenantTenantCode ;
      private String A360BAS_TenantTenantCode ;
      private String Z394TenantName ;
      private String A394TenantName ;
      private String Z395HospitalName ;
      private String A395HospitalName ;
      private String Z397BAS_TenantCreator ;
      private String A397BAS_TenantCreator ;
      private String Z399BAS_TenantModifier ;
      private String A399BAS_TenantModifier ;
      private String Z358InstituteCode ;
      private String A358InstituteCode ;
      private String Z396BAS_TenantLogo ;
      private String A396BAS_TenantLogo ;
      private SdtBAS_Tenant bcBAS_Tenant ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_datastore1 ;
      private String[] BC001F6_A360BAS_TenantTenantCode ;
      private String[] BC001F6_A394TenantName ;
      private String[] BC001F6_A395HospitalName ;
      private String[] BC001F6_A397BAS_TenantCreator ;
      private DateTime[] BC001F6_A398BAS_TenantCreateTime ;
      private String[] BC001F6_A399BAS_TenantModifier ;
      private bool[] BC001F6_n399BAS_TenantModifier ;
      private DateTime[] BC001F6_A400BAS_TenantModifyTime ;
      private bool[] BC001F6_n400BAS_TenantModifyTime ;
      private short[] BC001F6_A401BAS_TenantIsDeleted ;
      private String[] BC001F6_A402BAS_TenantDescription ;
      private bool[] BC001F6_n402BAS_TenantDescription ;
      private String[] BC001F6_A358InstituteCode ;
      private bool[] BC001F6_n358InstituteCode ;
      private int[] BC001F6_A365DatabaseID ;
      private String[] BC001F6_A396BAS_TenantLogo ;
      private bool[] BC001F6_n396BAS_TenantLogo ;
      private String[] BC001F4_A358InstituteCode ;
      private bool[] BC001F4_n358InstituteCode ;
      private int[] BC001F5_A365DatabaseID ;
      private String[] BC001F7_A360BAS_TenantTenantCode ;
      private String[] BC001F3_A360BAS_TenantTenantCode ;
      private String[] BC001F3_A394TenantName ;
      private String[] BC001F3_A395HospitalName ;
      private String[] BC001F3_A397BAS_TenantCreator ;
      private DateTime[] BC001F3_A398BAS_TenantCreateTime ;
      private String[] BC001F3_A399BAS_TenantModifier ;
      private bool[] BC001F3_n399BAS_TenantModifier ;
      private DateTime[] BC001F3_A400BAS_TenantModifyTime ;
      private bool[] BC001F3_n400BAS_TenantModifyTime ;
      private short[] BC001F3_A401BAS_TenantIsDeleted ;
      private String[] BC001F3_A402BAS_TenantDescription ;
      private bool[] BC001F3_n402BAS_TenantDescription ;
      private String[] BC001F3_A358InstituteCode ;
      private bool[] BC001F3_n358InstituteCode ;
      private int[] BC001F3_A365DatabaseID ;
      private String[] BC001F3_A396BAS_TenantLogo ;
      private bool[] BC001F3_n396BAS_TenantLogo ;
      private String[] BC001F2_A360BAS_TenantTenantCode ;
      private String[] BC001F2_A394TenantName ;
      private String[] BC001F2_A395HospitalName ;
      private String[] BC001F2_A397BAS_TenantCreator ;
      private DateTime[] BC001F2_A398BAS_TenantCreateTime ;
      private String[] BC001F2_A399BAS_TenantModifier ;
      private bool[] BC001F2_n399BAS_TenantModifier ;
      private DateTime[] BC001F2_A400BAS_TenantModifyTime ;
      private bool[] BC001F2_n400BAS_TenantModifyTime ;
      private short[] BC001F2_A401BAS_TenantIsDeleted ;
      private String[] BC001F2_A402BAS_TenantDescription ;
      private bool[] BC001F2_n402BAS_TenantDescription ;
      private String[] BC001F2_A358InstituteCode ;
      private bool[] BC001F2_n358InstituteCode ;
      private int[] BC001F2_A365DatabaseID ;
      private String[] BC001F2_A396BAS_TenantLogo ;
      private bool[] BC001F2_n396BAS_TenantLogo ;
      private IDataStoreProvider pr_default ;
      private long[] BC001F12_A85BR_Information_ID ;
      private String[] BC001F12_A360BAS_TenantTenantCode ;
      private String[] BC001F13_A360BAS_TenantTenantCode ;
      private Guid[] BC001F13_A359UserID ;
      private String[] BC001F14_A360BAS_TenantTenantCode ;
      private String[] BC001F14_A394TenantName ;
      private String[] BC001F14_A395HospitalName ;
      private String[] BC001F14_A397BAS_TenantCreator ;
      private DateTime[] BC001F14_A398BAS_TenantCreateTime ;
      private String[] BC001F14_A399BAS_TenantModifier ;
      private bool[] BC001F14_n399BAS_TenantModifier ;
      private DateTime[] BC001F14_A400BAS_TenantModifyTime ;
      private bool[] BC001F14_n400BAS_TenantModifyTime ;
      private short[] BC001F14_A401BAS_TenantIsDeleted ;
      private String[] BC001F14_A402BAS_TenantDescription ;
      private bool[] BC001F14_n402BAS_TenantDescription ;
      private String[] BC001F14_A358InstituteCode ;
      private bool[] BC001F14_n358InstituteCode ;
      private int[] BC001F14_A365DatabaseID ;
      private String[] BC001F14_A396BAS_TenantLogo ;
      private bool[] BC001F14_n396BAS_TenantLogo ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
   }

   public class bas_tenant_bc__datastore1 : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[8])
         ,new UpdateCursor(def[9])
         ,new ForEachCursor(def[10])
         ,new ForEachCursor(def[11])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmBC001F6 ;
          prmBC001F6 = new Object[] {
          new Object[] {"@BAS_TenantTenantCode",SqlDbType.NVarChar,20,0}
          } ;
          Object[] prmBC001F4 ;
          prmBC001F4 = new Object[] {
          new Object[] {"@InstituteCode",SqlDbType.NVarChar,20,0}
          } ;
          Object[] prmBC001F5 ;
          prmBC001F5 = new Object[] {
          new Object[] {"@DatabaseID",SqlDbType.Int,9,0}
          } ;
          Object[] prmBC001F7 ;
          prmBC001F7 = new Object[] {
          new Object[] {"@BAS_TenantTenantCode",SqlDbType.NVarChar,20,0}
          } ;
          Object[] prmBC001F3 ;
          prmBC001F3 = new Object[] {
          new Object[] {"@BAS_TenantTenantCode",SqlDbType.NVarChar,20,0}
          } ;
          Object[] prmBC001F2 ;
          prmBC001F2 = new Object[] {
          new Object[] {"@BAS_TenantTenantCode",SqlDbType.NVarChar,20,0}
          } ;
          Object[] prmBC001F8 ;
          prmBC001F8 = new Object[] {
          new Object[] {"@BAS_TenantTenantCode",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@TenantName",SqlDbType.NVarChar,200,0} ,
          new Object[] {"@HospitalName",SqlDbType.NVarChar,200,0} ,
          new Object[] {"@BAS_TenantLogo",SqlDbType.VarBinary,1024,0} ,
          new Object[] {"@BAS_TenantCreator",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@BAS_TenantCreateTime",SqlDbType.DateTime,10,8} ,
          new Object[] {"@BAS_TenantModifier",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@BAS_TenantModifyTime",SqlDbType.DateTime,10,8} ,
          new Object[] {"@BAS_TenantIsDeleted",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@BAS_TenantDescription",SqlDbType.NVarChar,2048,0} ,
          new Object[] {"@InstituteCode",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@DatabaseID",SqlDbType.Int,9,0}
          } ;
          Object[] prmBC001F9 ;
          prmBC001F9 = new Object[] {
          new Object[] {"@TenantName",SqlDbType.NVarChar,200,0} ,
          new Object[] {"@HospitalName",SqlDbType.NVarChar,200,0} ,
          new Object[] {"@BAS_TenantCreator",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@BAS_TenantCreateTime",SqlDbType.DateTime,10,8} ,
          new Object[] {"@BAS_TenantModifier",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@BAS_TenantModifyTime",SqlDbType.DateTime,10,8} ,
          new Object[] {"@BAS_TenantIsDeleted",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@BAS_TenantDescription",SqlDbType.NVarChar,2048,0} ,
          new Object[] {"@InstituteCode",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@DatabaseID",SqlDbType.Int,9,0} ,
          new Object[] {"@BAS_TenantTenantCode",SqlDbType.NVarChar,20,0}
          } ;
          Object[] prmBC001F10 ;
          prmBC001F10 = new Object[] {
          new Object[] {"@BAS_TenantLogo",SqlDbType.VarBinary,1024,0} ,
          new Object[] {"@BAS_TenantTenantCode",SqlDbType.NVarChar,20,0}
          } ;
          Object[] prmBC001F11 ;
          prmBC001F11 = new Object[] {
          new Object[] {"@BAS_TenantTenantCode",SqlDbType.NVarChar,20,0}
          } ;
          Object[] prmBC001F13 ;
          prmBC001F13 = new Object[] {
          new Object[] {"@BAS_TenantTenantCode",SqlDbType.NVarChar,20,0}
          } ;
          Object[] prmBC001F14 ;
          prmBC001F14 = new Object[] {
          new Object[] {"@BAS_TenantTenantCode",SqlDbType.NVarChar,20,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("BC001F2", "SELECT [TenantCode] AS BAS_TenantTenantCode, [TenantName], [HospitalName], [Creator] AS BAS_TenantCreator, [CreateTime] AS BAS_TenantCreateTime, [Modifier] AS BAS_TenantModifier, [ModifyTime] AS BAS_TenantModifyTime, [IsDeleted] AS BAS_TenantIsDeleted, [Description] AS BAS_TenantDescription, [InstituteCode], [DatabaseID], [Logo] AS BAS_TenantLogo FROM dbo.[BAS_Tenant] WITH (UPDLOCK) WHERE [TenantCode] = @BAS_TenantTenantCode ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001F2,1,0,true,false )
             ,new CursorDef("BC001F3", "SELECT [TenantCode] AS BAS_TenantTenantCode, [TenantName], [HospitalName], [Creator] AS BAS_TenantCreator, [CreateTime] AS BAS_TenantCreateTime, [Modifier] AS BAS_TenantModifier, [ModifyTime] AS BAS_TenantModifyTime, [IsDeleted] AS BAS_TenantIsDeleted, [Description] AS BAS_TenantDescription, [InstituteCode], [DatabaseID], [Logo] AS BAS_TenantLogo FROM dbo.[BAS_Tenant] WITH (NOLOCK) WHERE [TenantCode] = @BAS_TenantTenantCode ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001F3,1,0,true,false )
             ,new CursorDef("BC001F4", "SELECT [InstituteCode] FROM dbo.[BAS_Institute] WITH (NOLOCK) WHERE [InstituteCode] = @InstituteCode ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001F4,1,0,true,false )
             ,new CursorDef("BC001F5", "SELECT [DatabaseID] FROM dbo.[SYS_Database] WITH (NOLOCK) WHERE [DatabaseID] = @DatabaseID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001F5,1,0,true,false )
             ,new CursorDef("BC001F6", "SELECT TM1.[TenantCode] AS BAS_TenantTenantCode, TM1.[TenantName], TM1.[HospitalName], TM1.[Creator] AS BAS_TenantCreator, TM1.[CreateTime] AS BAS_TenantCreateTime, TM1.[Modifier] AS BAS_TenantModifier, TM1.[ModifyTime] AS BAS_TenantModifyTime, TM1.[IsDeleted] AS BAS_TenantIsDeleted, TM1.[Description] AS BAS_TenantDescription, TM1.[InstituteCode], TM1.[DatabaseID], TM1.[Logo] AS BAS_TenantLogo FROM dbo.[BAS_Tenant] TM1 WITH (NOLOCK) WHERE TM1.[TenantCode] = @BAS_TenantTenantCode ORDER BY TM1.[TenantCode]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001F6,100,0,true,false )
             ,new CursorDef("BC001F7", "SELECT [TenantCode] AS BAS_TenantTenantCode FROM dbo.[BAS_Tenant] WITH (NOLOCK) WHERE [TenantCode] = @BAS_TenantTenantCode  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001F7,1,0,true,false )
             ,new CursorDef("BC001F8", "INSERT INTO dbo.[BAS_Tenant]([TenantCode], [TenantName], [HospitalName], [Logo], [Creator], [CreateTime], [Modifier], [ModifyTime], [IsDeleted], [Description], [InstituteCode], [DatabaseID]) VALUES(@BAS_TenantTenantCode, @TenantName, @HospitalName, @BAS_TenantLogo, @BAS_TenantCreator, @BAS_TenantCreateTime, @BAS_TenantModifier, @BAS_TenantModifyTime, @BAS_TenantIsDeleted, @BAS_TenantDescription, @InstituteCode, @DatabaseID)", GxErrorMask.GX_NOMASK,prmBC001F8)
             ,new CursorDef("BC001F9", "UPDATE dbo.[BAS_Tenant] SET [TenantName]=@TenantName, [HospitalName]=@HospitalName, [Creator]=@BAS_TenantCreator, [CreateTime]=@BAS_TenantCreateTime, [Modifier]=@BAS_TenantModifier, [ModifyTime]=@BAS_TenantModifyTime, [IsDeleted]=@BAS_TenantIsDeleted, [Description]=@BAS_TenantDescription, [InstituteCode]=@InstituteCode, [DatabaseID]=@DatabaseID  WHERE [TenantCode] = @BAS_TenantTenantCode", GxErrorMask.GX_NOMASK,prmBC001F9)
             ,new CursorDef("BC001F10", "UPDATE dbo.[BAS_Tenant] SET [Logo]=@BAS_TenantLogo  WHERE [TenantCode] = @BAS_TenantTenantCode", GxErrorMask.GX_NOMASK,prmBC001F10)
             ,new CursorDef("BC001F11", "DELETE FROM dbo.[BAS_Tenant]  WHERE [TenantCode] = @BAS_TenantTenantCode", GxErrorMask.GX_NOMASK,prmBC001F11)
             ,new CursorDef("BC001F13", "SELECT TOP 1 [TenantCode] AS BAS_TenantTenantCode, [UserID] FROM dbo.[SYS_TenantUser] WITH (NOLOCK) WHERE [TenantCode] = @BAS_TenantTenantCode ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001F13,1,0,true,true )
             ,new CursorDef("BC001F14", "SELECT TM1.[TenantCode] AS BAS_TenantTenantCode, TM1.[TenantName], TM1.[HospitalName], TM1.[Creator] AS BAS_TenantCreator, TM1.[CreateTime] AS BAS_TenantCreateTime, TM1.[Modifier] AS BAS_TenantModifier, TM1.[ModifyTime] AS BAS_TenantModifyTime, TM1.[IsDeleted] AS BAS_TenantIsDeleted, TM1.[Description] AS BAS_TenantDescription, TM1.[InstituteCode], TM1.[DatabaseID], TM1.[Logo] AS BAS_TenantLogo FROM dbo.[BAS_Tenant] TM1 WITH (NOLOCK) WHERE TM1.[TenantCode] = @BAS_TenantTenantCode ORDER BY TM1.[TenantCode]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001F14,100,0,true,false )
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
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((DateTime[]) buf[4])[0] = rslt.getGXDateTime(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[7])[0] = rslt.getGXDateTime(7) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(7);
                ((short[]) buf[9])[0] = rslt.getShort(8) ;
                ((String[]) buf[10])[0] = rslt.getLongVarchar(9) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(9);
                ((String[]) buf[12])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(10);
                ((int[]) buf[14])[0] = rslt.getInt(11) ;
                ((String[]) buf[15])[0] = rslt.getBLOBFile(12, "tmp", "") ;
                ((bool[]) buf[16])[0] = rslt.wasNull(12);
                return;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((DateTime[]) buf[4])[0] = rslt.getGXDateTime(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[7])[0] = rslt.getGXDateTime(7) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(7);
                ((short[]) buf[9])[0] = rslt.getShort(8) ;
                ((String[]) buf[10])[0] = rslt.getLongVarchar(9) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(9);
                ((String[]) buf[12])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(10);
                ((int[]) buf[14])[0] = rslt.getInt(11) ;
                ((String[]) buf[15])[0] = rslt.getBLOBFile(12, "tmp", "") ;
                ((bool[]) buf[16])[0] = rslt.wasNull(12);
                return;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                return;
             case 3 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((DateTime[]) buf[4])[0] = rslt.getGXDateTime(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[7])[0] = rslt.getGXDateTime(7) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(7);
                ((short[]) buf[9])[0] = rslt.getShort(8) ;
                ((String[]) buf[10])[0] = rslt.getLongVarchar(9) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(9);
                ((String[]) buf[12])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(10);
                ((int[]) buf[14])[0] = rslt.getInt(11) ;
                ((String[]) buf[15])[0] = rslt.getBLOBFile(12, "tmp", "") ;
                ((bool[]) buf[16])[0] = rslt.wasNull(12);
                return;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                return;
             case 10 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((Guid[]) buf[1])[0] = rslt.getGuid(2) ;
                return;
             case 11 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((DateTime[]) buf[4])[0] = rslt.getGXDateTime(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[7])[0] = rslt.getGXDateTime(7) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(7);
                ((short[]) buf[9])[0] = rslt.getShort(8) ;
                ((String[]) buf[10])[0] = rslt.getLongVarchar(9) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(9);
                ((String[]) buf[12])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(10);
                ((int[]) buf[14])[0] = rslt.getInt(11) ;
                ((String[]) buf[15])[0] = rslt.getBLOBFile(12, "tmp", "") ;
                ((bool[]) buf[16])[0] = rslt.wasNull(12);
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
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                return;
             case 3 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 4 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 5 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 6 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                if ( (bool)parms[3] )
                {
                   stmt.setNull( 4 , SqlDbType.VarBinary );
                }
                else
                {
                   stmt.SetParameterBlob(4, (String)parms[4], true);
                }
                stmt.SetParameter(5, (String)parms[5]);
                stmt.SetParameterDatetime(6, (DateTime)parms[6]);
                if ( (bool)parms[7] )
                {
                   stmt.setNull( 7 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(7, (String)parms[8]);
                }
                if ( (bool)parms[9] )
                {
                   stmt.setNull( 8 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(8, (DateTime)parms[10]);
                }
                stmt.SetParameter(9, (short)parms[11]);
                if ( (bool)parms[12] )
                {
                   stmt.setNull( 10 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(10, (String)parms[13]);
                }
                if ( (bool)parms[14] )
                {
                   stmt.setNull( 11 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(11, (String)parms[15]);
                }
                stmt.SetParameter(12, (int)parms[16]);
                return;
             case 7 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameterDatetime(4, (DateTime)parms[3]);
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 5 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(5, (String)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 6 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(6, (DateTime)parms[7]);
                }
                stmt.SetParameter(7, (short)parms[8]);
                if ( (bool)parms[9] )
                {
                   stmt.setNull( 8 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(8, (String)parms[10]);
                }
                if ( (bool)parms[11] )
                {
                   stmt.setNull( 9 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(9, (String)parms[12]);
                }
                stmt.SetParameter(10, (int)parms[13]);
                stmt.SetParameter(11, (String)parms[14]);
                return;
             case 8 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.VarBinary );
                }
                else
                {
                   stmt.SetParameterBlob(1, (String)parms[1], true);
                }
                stmt.SetParameter(2, (String)parms[2]);
                return;
             case 9 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 10 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 11 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
       }
    }

    public String getDataStoreName( )
    {
       return "DATASTORE1";
    }

 }

 public class bas_tenant_bc__default : DataStoreHelperBase, IDataStoreHelper
 {
    public ICursor[] getCursors( )
    {
       cursorDefinitions();
       return new Cursor[] {
        new ForEachCursor(def[0])
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmBC001F12 ;
        prmBC001F12 = new Object[] {
        new Object[] {"@BAS_TenantTenantCode",SqlDbType.NVarChar,20,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("BC001F12", "SELECT TOP 1 [BR_Information_ID], [BAS_TenantTenantCode] AS BAS_TenantTenantCode FROM [BR_PatientReTenant] WITH (NOLOCK) WHERE [BAS_TenantTenantCode] = @BAS_TenantTenantCode ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001F12,1,0,true,true )
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
     }
  }

}

}
