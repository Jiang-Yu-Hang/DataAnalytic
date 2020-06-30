/*
               File: SYS_User_BC
        Description: SYS_User
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:38:55.85
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
   public class sys_user_bc : GXHttpHandler, IGxSilentTrn
   {
      public sys_user_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public sys_user_bc( IGxContext context )
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
         ReadRow1D50( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey1D50( ) ;
         standaloneModal( ) ;
         AddRow1D50( ) ;
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

      protected void CONFIRM_1D0( )
      {
         BeforeValidate1D50( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls1D50( ) ;
            }
            else
            {
               CheckExtendedTable1D50( ) ;
               if ( AnyError == 0 )
               {
               }
               CloseExtendedTableCursors1D50( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void ZM1D50( short GX_JID )
      {
         if ( ( GX_JID == 6 ) || ( GX_JID == 0 ) )
         {
            Z416DisplayName = A416DisplayName;
            Z417UserType = A417UserType;
            Z364Account = A364Account;
            Z418PasswordHash = A418PasswordHash;
            Z419LoginIP = A419LoginIP;
            Z420LoginTime = A420LoginTime;
            Z421SYS_UserCreator = A421SYS_UserCreator;
            Z422SYS_UserCreateTime = A422SYS_UserCreateTime;
            Z423SYS_UserModifier = A423SYS_UserModifier;
            Z424SYS_UserModifyTime = A424SYS_UserModifyTime;
            Z425SYS_UserIsDeleted = A425SYS_UserIsDeleted;
            Z426Email = A426Email;
            Z428RocheAccount = A428RocheAccount;
         }
         if ( GX_JID == -6 )
         {
            Z359UserID = (Guid)(A359UserID);
            Z416DisplayName = A416DisplayName;
            Z417UserType = A417UserType;
            Z364Account = A364Account;
            Z418PasswordHash = A418PasswordHash;
            Z419LoginIP = A419LoginIP;
            Z420LoginTime = A420LoginTime;
            Z421SYS_UserCreator = A421SYS_UserCreator;
            Z422SYS_UserCreateTime = A422SYS_UserCreateTime;
            Z423SYS_UserModifier = A423SYS_UserModifier;
            Z424SYS_UserModifyTime = A424SYS_UserModifyTime;
            Z425SYS_UserIsDeleted = A425SYS_UserIsDeleted;
            Z426Email = A426Email;
            Z427SYS_UserDescription = A427SYS_UserDescription;
            Z428RocheAccount = A428RocheAccount;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (Guid.Empty==A359UserID) )
         {
            A359UserID = (Guid)(Guid.NewGuid( ));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( Gx_BScreen == 0 ) )
         {
         }
      }

      protected void Load1D50( )
      {
         /* Using cursor BC001D4 */
         pr_datastore1.execute(2, new Object[] {A359UserID});
         if ( (pr_datastore1.getStatus(2) != 101) )
         {
            RcdFound50 = 1;
            A416DisplayName = BC001D4_A416DisplayName[0];
            A417UserType = BC001D4_A417UserType[0];
            A364Account = BC001D4_A364Account[0];
            A418PasswordHash = BC001D4_A418PasswordHash[0];
            A419LoginIP = BC001D4_A419LoginIP[0];
            n419LoginIP = BC001D4_n419LoginIP[0];
            A420LoginTime = BC001D4_A420LoginTime[0];
            n420LoginTime = BC001D4_n420LoginTime[0];
            A421SYS_UserCreator = BC001D4_A421SYS_UserCreator[0];
            A422SYS_UserCreateTime = BC001D4_A422SYS_UserCreateTime[0];
            A423SYS_UserModifier = BC001D4_A423SYS_UserModifier[0];
            n423SYS_UserModifier = BC001D4_n423SYS_UserModifier[0];
            A424SYS_UserModifyTime = BC001D4_A424SYS_UserModifyTime[0];
            n424SYS_UserModifyTime = BC001D4_n424SYS_UserModifyTime[0];
            A425SYS_UserIsDeleted = BC001D4_A425SYS_UserIsDeleted[0];
            A426Email = BC001D4_A426Email[0];
            n426Email = BC001D4_n426Email[0];
            A427SYS_UserDescription = BC001D4_A427SYS_UserDescription[0];
            n427SYS_UserDescription = BC001D4_n427SYS_UserDescription[0];
            A428RocheAccount = BC001D4_A428RocheAccount[0];
            n428RocheAccount = BC001D4_n428RocheAccount[0];
            ZM1D50( -6) ;
         }
         pr_datastore1.close(2);
         OnLoadActions1D50( ) ;
      }

      protected void OnLoadActions1D50( )
      {
      }

      protected void CheckExtendedTable1D50( )
      {
         standaloneModal( ) ;
         /* Using cursor BC001D5 */
         pr_datastore1.execute(3, new Object[] {A364Account, A359UserID});
         if ( (pr_datastore1.getStatus(3) != 101) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_1004", new   object[]  {"Account"}), 1, "");
            AnyError = 1;
         }
         pr_datastore1.close(3);
         if ( ! ( (DateTime.MinValue==A420LoginTime) || ( A420LoginTime >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("域Login Time超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
         if ( ! ( (DateTime.MinValue==A422SYS_UserCreateTime) || ( A422SYS_UserCreateTime >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("域SYS_User Create Time超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
         if ( ! ( (DateTime.MinValue==A424SYS_UserModifyTime) || ( A424SYS_UserModifyTime >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("域SYS_User Modify Time超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
      }

      protected void CloseExtendedTableCursors1D50( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey1D50( )
      {
         /* Using cursor BC001D6 */
         pr_datastore1.execute(4, new Object[] {A359UserID});
         if ( (pr_datastore1.getStatus(4) != 101) )
         {
            RcdFound50 = 1;
         }
         else
         {
            RcdFound50 = 0;
         }
         pr_datastore1.close(4);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC001D3 */
         pr_datastore1.execute(1, new Object[] {A359UserID});
         if ( (pr_datastore1.getStatus(1) != 101) )
         {
            ZM1D50( 6) ;
            RcdFound50 = 1;
            A359UserID = (Guid)((Guid)(BC001D3_A359UserID[0]));
            A416DisplayName = BC001D3_A416DisplayName[0];
            A417UserType = BC001D3_A417UserType[0];
            A364Account = BC001D3_A364Account[0];
            A418PasswordHash = BC001D3_A418PasswordHash[0];
            A419LoginIP = BC001D3_A419LoginIP[0];
            n419LoginIP = BC001D3_n419LoginIP[0];
            A420LoginTime = BC001D3_A420LoginTime[0];
            n420LoginTime = BC001D3_n420LoginTime[0];
            A421SYS_UserCreator = BC001D3_A421SYS_UserCreator[0];
            A422SYS_UserCreateTime = BC001D3_A422SYS_UserCreateTime[0];
            A423SYS_UserModifier = BC001D3_A423SYS_UserModifier[0];
            n423SYS_UserModifier = BC001D3_n423SYS_UserModifier[0];
            A424SYS_UserModifyTime = BC001D3_A424SYS_UserModifyTime[0];
            n424SYS_UserModifyTime = BC001D3_n424SYS_UserModifyTime[0];
            A425SYS_UserIsDeleted = BC001D3_A425SYS_UserIsDeleted[0];
            A426Email = BC001D3_A426Email[0];
            n426Email = BC001D3_n426Email[0];
            A427SYS_UserDescription = BC001D3_A427SYS_UserDescription[0];
            n427SYS_UserDescription = BC001D3_n427SYS_UserDescription[0];
            A428RocheAccount = BC001D3_A428RocheAccount[0];
            n428RocheAccount = BC001D3_n428RocheAccount[0];
            Z359UserID = (Guid)(A359UserID);
            sMode50 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load1D50( ) ;
            if ( AnyError == 1 )
            {
               RcdFound50 = 0;
               InitializeNonKey1D50( ) ;
            }
            Gx_mode = sMode50;
         }
         else
         {
            RcdFound50 = 0;
            InitializeNonKey1D50( ) ;
            sMode50 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode50;
         }
         pr_datastore1.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1D50( ) ;
         if ( RcdFound50 == 0 )
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
         CONFIRM_1D0( ) ;
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

      protected void CheckOptimisticConcurrency1D50( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC001D2 */
            pr_datastore1.execute(0, new Object[] {A359UserID});
            if ( (pr_datastore1.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SYS_USER"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_datastore1.getStatus(0) == 101) || ( StringUtil.StrCmp(Z416DisplayName, BC001D2_A416DisplayName[0]) != 0 ) || ( Z417UserType != BC001D2_A417UserType[0] ) || ( StringUtil.StrCmp(Z364Account, BC001D2_A364Account[0]) != 0 ) || ( StringUtil.StrCmp(Z418PasswordHash, BC001D2_A418PasswordHash[0]) != 0 ) || ( StringUtil.StrCmp(Z419LoginIP, BC001D2_A419LoginIP[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z420LoginTime != BC001D2_A420LoginTime[0] ) || ( StringUtil.StrCmp(Z421SYS_UserCreator, BC001D2_A421SYS_UserCreator[0]) != 0 ) || ( Z422SYS_UserCreateTime != BC001D2_A422SYS_UserCreateTime[0] ) || ( StringUtil.StrCmp(Z423SYS_UserModifier, BC001D2_A423SYS_UserModifier[0]) != 0 ) || ( Z424SYS_UserModifyTime != BC001D2_A424SYS_UserModifyTime[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z425SYS_UserIsDeleted != BC001D2_A425SYS_UserIsDeleted[0] ) || ( StringUtil.StrCmp(Z426Email, BC001D2_A426Email[0]) != 0 ) || ( StringUtil.StrCmp(Z428RocheAccount, BC001D2_A428RocheAccount[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"SYS_USER"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert1D50( )
      {
         BeforeValidate1D50( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1D50( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1D50( 0) ;
            CheckOptimisticConcurrency1D50( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1D50( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1D50( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC001D7 */
                     pr_datastore1.execute(5, new Object[] {A416DisplayName, A417UserType, A364Account, A418PasswordHash, n419LoginIP, A419LoginIP, n420LoginTime, A420LoginTime, A421SYS_UserCreator, A422SYS_UserCreateTime, n423SYS_UserModifier, A423SYS_UserModifier, n424SYS_UserModifyTime, A424SYS_UserModifyTime, A425SYS_UserIsDeleted, n426Email, A426Email, n427SYS_UserDescription, A427SYS_UserDescription, n428RocheAccount, A428RocheAccount, A359UserID});
                     pr_datastore1.close(5);
                     dsDataStore1.SmartCacheProvider.SetUpdated("SYS_USER") ;
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
               Load1D50( ) ;
            }
            EndLevel1D50( ) ;
         }
         CloseExtendedTableCursors1D50( ) ;
      }

      protected void Update1D50( )
      {
         BeforeValidate1D50( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1D50( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1D50( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1D50( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1D50( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC001D8 */
                     pr_datastore1.execute(6, new Object[] {A416DisplayName, A417UserType, A364Account, A418PasswordHash, n419LoginIP, A419LoginIP, n420LoginTime, A420LoginTime, A421SYS_UserCreator, A422SYS_UserCreateTime, n423SYS_UserModifier, A423SYS_UserModifier, n424SYS_UserModifyTime, A424SYS_UserModifyTime, A425SYS_UserIsDeleted, n426Email, A426Email, n427SYS_UserDescription, A427SYS_UserDescription, n428RocheAccount, A428RocheAccount, A359UserID});
                     pr_datastore1.close(6);
                     dsDataStore1.SmartCacheProvider.SetUpdated("SYS_USER") ;
                     if ( (pr_datastore1.getStatus(6) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SYS_USER"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate1D50( ) ;
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
            EndLevel1D50( ) ;
         }
         CloseExtendedTableCursors1D50( ) ;
      }

      protected void DeferredUpdate1D50( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate1D50( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1D50( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1D50( ) ;
            AfterConfirm1D50( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1D50( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC001D9 */
                  pr_datastore1.execute(7, new Object[] {A359UserID});
                  pr_datastore1.close(7);
                  dsDataStore1.SmartCacheProvider.SetUpdated("SYS_USER") ;
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
         sMode50 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel1D50( ) ;
         Gx_mode = sMode50;
      }

      protected void OnDeleteControls1D50( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor BC001D10 */
            pr_datastore1.execute(8, new Object[] {A359UserID});
            if ( (pr_datastore1.getStatus(8) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"SYS_Institute User"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_datastore1.close(8);
            /* Using cursor BC001D11 */
            pr_datastore1.execute(9, new Object[] {A359UserID});
            if ( (pr_datastore1.getStatus(9) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"SYS_Tenant User"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_datastore1.close(9);
            /* Using cursor BC001D12 */
            pr_datastore1.execute(10, new Object[] {A359UserID});
            if ( (pr_datastore1.getStatus(10) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"SYS_User Role"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_datastore1.close(10);
         }
      }

      protected void EndLevel1D50( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_datastore1.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1D50( ) ;
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

      public void ScanKeyStart1D50( )
      {
         /* Using cursor BC001D13 */
         pr_datastore1.execute(11, new Object[] {A359UserID});
         RcdFound50 = 0;
         if ( (pr_datastore1.getStatus(11) != 101) )
         {
            RcdFound50 = 1;
            A359UserID = (Guid)((Guid)(BC001D13_A359UserID[0]));
            A416DisplayName = BC001D13_A416DisplayName[0];
            A417UserType = BC001D13_A417UserType[0];
            A364Account = BC001D13_A364Account[0];
            A418PasswordHash = BC001D13_A418PasswordHash[0];
            A419LoginIP = BC001D13_A419LoginIP[0];
            n419LoginIP = BC001D13_n419LoginIP[0];
            A420LoginTime = BC001D13_A420LoginTime[0];
            n420LoginTime = BC001D13_n420LoginTime[0];
            A421SYS_UserCreator = BC001D13_A421SYS_UserCreator[0];
            A422SYS_UserCreateTime = BC001D13_A422SYS_UserCreateTime[0];
            A423SYS_UserModifier = BC001D13_A423SYS_UserModifier[0];
            n423SYS_UserModifier = BC001D13_n423SYS_UserModifier[0];
            A424SYS_UserModifyTime = BC001D13_A424SYS_UserModifyTime[0];
            n424SYS_UserModifyTime = BC001D13_n424SYS_UserModifyTime[0];
            A425SYS_UserIsDeleted = BC001D13_A425SYS_UserIsDeleted[0];
            A426Email = BC001D13_A426Email[0];
            n426Email = BC001D13_n426Email[0];
            A427SYS_UserDescription = BC001D13_A427SYS_UserDescription[0];
            n427SYS_UserDescription = BC001D13_n427SYS_UserDescription[0];
            A428RocheAccount = BC001D13_A428RocheAccount[0];
            n428RocheAccount = BC001D13_n428RocheAccount[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext1D50( )
      {
         /* Scan next routine */
         pr_datastore1.readNext(11);
         RcdFound50 = 0;
         ScanKeyLoad1D50( ) ;
      }

      protected void ScanKeyLoad1D50( )
      {
         sMode50 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_datastore1.getStatus(11) != 101) )
         {
            RcdFound50 = 1;
            A359UserID = (Guid)((Guid)(BC001D13_A359UserID[0]));
            A416DisplayName = BC001D13_A416DisplayName[0];
            A417UserType = BC001D13_A417UserType[0];
            A364Account = BC001D13_A364Account[0];
            A418PasswordHash = BC001D13_A418PasswordHash[0];
            A419LoginIP = BC001D13_A419LoginIP[0];
            n419LoginIP = BC001D13_n419LoginIP[0];
            A420LoginTime = BC001D13_A420LoginTime[0];
            n420LoginTime = BC001D13_n420LoginTime[0];
            A421SYS_UserCreator = BC001D13_A421SYS_UserCreator[0];
            A422SYS_UserCreateTime = BC001D13_A422SYS_UserCreateTime[0];
            A423SYS_UserModifier = BC001D13_A423SYS_UserModifier[0];
            n423SYS_UserModifier = BC001D13_n423SYS_UserModifier[0];
            A424SYS_UserModifyTime = BC001D13_A424SYS_UserModifyTime[0];
            n424SYS_UserModifyTime = BC001D13_n424SYS_UserModifyTime[0];
            A425SYS_UserIsDeleted = BC001D13_A425SYS_UserIsDeleted[0];
            A426Email = BC001D13_A426Email[0];
            n426Email = BC001D13_n426Email[0];
            A427SYS_UserDescription = BC001D13_A427SYS_UserDescription[0];
            n427SYS_UserDescription = BC001D13_n427SYS_UserDescription[0];
            A428RocheAccount = BC001D13_A428RocheAccount[0];
            n428RocheAccount = BC001D13_n428RocheAccount[0];
         }
         Gx_mode = sMode50;
      }

      protected void ScanKeyEnd1D50( )
      {
         pr_datastore1.close(11);
      }

      protected void AfterConfirm1D50( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1D50( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1D50( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1D50( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1D50( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1D50( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1D50( )
      {
      }

      protected void send_integrity_lvl_hashes1D50( )
      {
      }

      protected void AddRow1D50( )
      {
         VarsToRow50( bcSYS_User) ;
      }

      protected void ReadRow1D50( )
      {
         RowToVars50( bcSYS_User, 1) ;
      }

      protected void InitializeNonKey1D50( )
      {
         A416DisplayName = "";
         A417UserType = 0;
         A364Account = "";
         A418PasswordHash = "";
         A419LoginIP = "";
         n419LoginIP = false;
         A420LoginTime = (DateTime)(DateTime.MinValue);
         n420LoginTime = false;
         A421SYS_UserCreator = "";
         A422SYS_UserCreateTime = (DateTime)(DateTime.MinValue);
         A423SYS_UserModifier = "";
         n423SYS_UserModifier = false;
         A424SYS_UserModifyTime = (DateTime)(DateTime.MinValue);
         n424SYS_UserModifyTime = false;
         A425SYS_UserIsDeleted = 0;
         A426Email = "";
         n426Email = false;
         A427SYS_UserDescription = "";
         n427SYS_UserDescription = false;
         A428RocheAccount = "";
         n428RocheAccount = false;
         Z416DisplayName = "";
         Z417UserType = 0;
         Z364Account = "";
         Z418PasswordHash = "";
         Z419LoginIP = "";
         Z420LoginTime = (DateTime)(DateTime.MinValue);
         Z421SYS_UserCreator = "";
         Z422SYS_UserCreateTime = (DateTime)(DateTime.MinValue);
         Z423SYS_UserModifier = "";
         Z424SYS_UserModifyTime = (DateTime)(DateTime.MinValue);
         Z425SYS_UserIsDeleted = 0;
         Z426Email = "";
         Z428RocheAccount = "";
      }

      protected void InitAll1D50( )
      {
         A359UserID = (Guid)(Guid.NewGuid( ));
         InitializeNonKey1D50( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow50( SdtSYS_User obj50 )
      {
         obj50.gxTpr_Mode = Gx_mode;
         obj50.gxTpr_Displayname = A416DisplayName;
         obj50.gxTpr_Usertype = A417UserType;
         obj50.gxTpr_Account = A364Account;
         obj50.gxTpr_Passwordhash = A418PasswordHash;
         obj50.gxTpr_Loginip = A419LoginIP;
         obj50.gxTpr_Logintime = A420LoginTime;
         obj50.gxTpr_Sys_usercreator = A421SYS_UserCreator;
         obj50.gxTpr_Sys_usercreatetime = A422SYS_UserCreateTime;
         obj50.gxTpr_Sys_usermodifier = A423SYS_UserModifier;
         obj50.gxTpr_Sys_usermodifytime = A424SYS_UserModifyTime;
         obj50.gxTpr_Sys_userisdeleted = A425SYS_UserIsDeleted;
         obj50.gxTpr_Email = A426Email;
         obj50.gxTpr_Sys_userdescription = A427SYS_UserDescription;
         obj50.gxTpr_Rocheaccount = A428RocheAccount;
         obj50.gxTpr_Userid = (Guid)(A359UserID);
         obj50.gxTpr_Userid_Z = (Guid)(Z359UserID);
         obj50.gxTpr_Displayname_Z = Z416DisplayName;
         obj50.gxTpr_Usertype_Z = Z417UserType;
         obj50.gxTpr_Account_Z = Z364Account;
         obj50.gxTpr_Passwordhash_Z = Z418PasswordHash;
         obj50.gxTpr_Loginip_Z = Z419LoginIP;
         obj50.gxTpr_Logintime_Z = Z420LoginTime;
         obj50.gxTpr_Sys_usercreator_Z = Z421SYS_UserCreator;
         obj50.gxTpr_Sys_usercreatetime_Z = Z422SYS_UserCreateTime;
         obj50.gxTpr_Sys_usermodifier_Z = Z423SYS_UserModifier;
         obj50.gxTpr_Sys_usermodifytime_Z = Z424SYS_UserModifyTime;
         obj50.gxTpr_Sys_userisdeleted_Z = Z425SYS_UserIsDeleted;
         obj50.gxTpr_Email_Z = Z426Email;
         obj50.gxTpr_Rocheaccount_Z = Z428RocheAccount;
         obj50.gxTpr_Loginip_N = (short)(Convert.ToInt16(n419LoginIP));
         obj50.gxTpr_Logintime_N = (short)(Convert.ToInt16(n420LoginTime));
         obj50.gxTpr_Sys_usermodifier_N = (short)(Convert.ToInt16(n423SYS_UserModifier));
         obj50.gxTpr_Sys_usermodifytime_N = (short)(Convert.ToInt16(n424SYS_UserModifyTime));
         obj50.gxTpr_Email_N = (short)(Convert.ToInt16(n426Email));
         obj50.gxTpr_Sys_userdescription_N = (short)(Convert.ToInt16(n427SYS_UserDescription));
         obj50.gxTpr_Rocheaccount_N = (short)(Convert.ToInt16(n428RocheAccount));
         obj50.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow50( SdtSYS_User obj50 )
      {
         obj50.gxTpr_Userid = (Guid)(A359UserID);
         return  ;
      }

      public void RowToVars50( SdtSYS_User obj50 ,
                               int forceLoad )
      {
         Gx_mode = obj50.gxTpr_Mode;
         A416DisplayName = obj50.gxTpr_Displayname;
         A417UserType = obj50.gxTpr_Usertype;
         A364Account = obj50.gxTpr_Account;
         A418PasswordHash = obj50.gxTpr_Passwordhash;
         A419LoginIP = obj50.gxTpr_Loginip;
         n419LoginIP = false;
         A420LoginTime = obj50.gxTpr_Logintime;
         n420LoginTime = false;
         A421SYS_UserCreator = obj50.gxTpr_Sys_usercreator;
         A422SYS_UserCreateTime = obj50.gxTpr_Sys_usercreatetime;
         A423SYS_UserModifier = obj50.gxTpr_Sys_usermodifier;
         n423SYS_UserModifier = false;
         A424SYS_UserModifyTime = obj50.gxTpr_Sys_usermodifytime;
         n424SYS_UserModifyTime = false;
         A425SYS_UserIsDeleted = obj50.gxTpr_Sys_userisdeleted;
         A426Email = obj50.gxTpr_Email;
         n426Email = false;
         A427SYS_UserDescription = obj50.gxTpr_Sys_userdescription;
         n427SYS_UserDescription = false;
         A428RocheAccount = obj50.gxTpr_Rocheaccount;
         n428RocheAccount = false;
         A359UserID = (Guid)(obj50.gxTpr_Userid);
         Z359UserID = (Guid)(obj50.gxTpr_Userid_Z);
         Z416DisplayName = obj50.gxTpr_Displayname_Z;
         Z417UserType = obj50.gxTpr_Usertype_Z;
         Z364Account = obj50.gxTpr_Account_Z;
         Z418PasswordHash = obj50.gxTpr_Passwordhash_Z;
         Z419LoginIP = obj50.gxTpr_Loginip_Z;
         Z420LoginTime = obj50.gxTpr_Logintime_Z;
         Z421SYS_UserCreator = obj50.gxTpr_Sys_usercreator_Z;
         Z422SYS_UserCreateTime = obj50.gxTpr_Sys_usercreatetime_Z;
         Z423SYS_UserModifier = obj50.gxTpr_Sys_usermodifier_Z;
         Z424SYS_UserModifyTime = obj50.gxTpr_Sys_usermodifytime_Z;
         Z425SYS_UserIsDeleted = obj50.gxTpr_Sys_userisdeleted_Z;
         Z426Email = obj50.gxTpr_Email_Z;
         Z428RocheAccount = obj50.gxTpr_Rocheaccount_Z;
         n419LoginIP = (bool)(Convert.ToBoolean(obj50.gxTpr_Loginip_N));
         n420LoginTime = (bool)(Convert.ToBoolean(obj50.gxTpr_Logintime_N));
         n423SYS_UserModifier = (bool)(Convert.ToBoolean(obj50.gxTpr_Sys_usermodifier_N));
         n424SYS_UserModifyTime = (bool)(Convert.ToBoolean(obj50.gxTpr_Sys_usermodifytime_N));
         n426Email = (bool)(Convert.ToBoolean(obj50.gxTpr_Email_N));
         n427SYS_UserDescription = (bool)(Convert.ToBoolean(obj50.gxTpr_Sys_userdescription_N));
         n428RocheAccount = (bool)(Convert.ToBoolean(obj50.gxTpr_Rocheaccount_N));
         Gx_mode = obj50.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A359UserID = (Guid)((Guid)getParm(obj,0));
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey1D50( ) ;
         ScanKeyStart1D50( ) ;
         if ( RcdFound50 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z359UserID = (Guid)(A359UserID);
         }
         ZM1D50( -6) ;
         OnLoadActions1D50( ) ;
         AddRow1D50( ) ;
         ScanKeyEnd1D50( ) ;
         if ( RcdFound50 == 0 )
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
         RowToVars50( bcSYS_User, 0) ;
         ScanKeyStart1D50( ) ;
         if ( RcdFound50 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z359UserID = (Guid)(A359UserID);
         }
         ZM1D50( -6) ;
         OnLoadActions1D50( ) ;
         AddRow1D50( ) ;
         ScanKeyEnd1D50( ) ;
         if ( RcdFound50 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey1D50( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert1D50( ) ;
         }
         else
         {
            if ( RcdFound50 == 1 )
            {
               if ( A359UserID != Z359UserID )
               {
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
                  Update1D50( ) ;
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
                  if ( A359UserID != Z359UserID )
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
                        Insert1D50( ) ;
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
                        Insert1D50( ) ;
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
         RowToVars50( bcSYS_User, 0) ;
         SaveImpl( ) ;
         VarsToRow50( bcSYS_User) ;
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
         RowToVars50( bcSYS_User, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert1D50( ) ;
         AfterTrn( ) ;
         VarsToRow50( bcSYS_User) ;
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
            SdtSYS_User auxBC = new SdtSYS_User(context) ;
            auxBC.Load(A359UserID);
            auxBC.UpdateDirties(bcSYS_User);
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
         RowToVars50( bcSYS_User, 0) ;
         UpdateImpl( ) ;
         VarsToRow50( bcSYS_User) ;
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
         RowToVars50( bcSYS_User, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert1D50( ) ;
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
         VarsToRow50( bcSYS_User) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars50( bcSYS_User, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey1D50( ) ;
         if ( RcdFound50 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A359UserID != Z359UserID )
            {
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
            if ( A359UserID != Z359UserID )
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
         context.RollbackDataStores("sys_user_bc",pr_default);
         VarsToRow50( bcSYS_User) ;
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
         Gx_mode = bcSYS_User.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcSYS_User.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcSYS_User )
         {
            bcSYS_User = (SdtSYS_User)(sdt);
            if ( StringUtil.StrCmp(bcSYS_User.gxTpr_Mode, "") == 0 )
            {
               bcSYS_User.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow50( bcSYS_User) ;
            }
            else
            {
               RowToVars50( bcSYS_User, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcSYS_User.gxTpr_Mode, "") == 0 )
            {
               bcSYS_User.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars50( bcSYS_User, 1) ;
         return  ;
      }

      public SdtSYS_User SYS_User_BC
      {
         get {
            return bcSYS_User ;
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
         Z359UserID = (Guid)(Guid.Empty);
         A359UserID = (Guid)(Guid.Empty);
         Z416DisplayName = "";
         A416DisplayName = "";
         Z364Account = "";
         A364Account = "";
         Z418PasswordHash = "";
         A418PasswordHash = "";
         Z419LoginIP = "";
         A419LoginIP = "";
         Z420LoginTime = (DateTime)(DateTime.MinValue);
         A420LoginTime = (DateTime)(DateTime.MinValue);
         Z421SYS_UserCreator = "";
         A421SYS_UserCreator = "";
         Z422SYS_UserCreateTime = (DateTime)(DateTime.MinValue);
         A422SYS_UserCreateTime = (DateTime)(DateTime.MinValue);
         Z423SYS_UserModifier = "";
         A423SYS_UserModifier = "";
         Z424SYS_UserModifyTime = (DateTime)(DateTime.MinValue);
         A424SYS_UserModifyTime = (DateTime)(DateTime.MinValue);
         Z426Email = "";
         A426Email = "";
         Z428RocheAccount = "";
         A428RocheAccount = "";
         Z427SYS_UserDescription = "";
         A427SYS_UserDescription = "";
         BC001D4_A359UserID = new Guid[] {Guid.Empty} ;
         BC001D4_A416DisplayName = new String[] {""} ;
         BC001D4_A417UserType = new int[1] ;
         BC001D4_A364Account = new String[] {""} ;
         BC001D4_A418PasswordHash = new String[] {""} ;
         BC001D4_A419LoginIP = new String[] {""} ;
         BC001D4_n419LoginIP = new bool[] {false} ;
         BC001D4_A420LoginTime = new DateTime[] {DateTime.MinValue} ;
         BC001D4_n420LoginTime = new bool[] {false} ;
         BC001D4_A421SYS_UserCreator = new String[] {""} ;
         BC001D4_A422SYS_UserCreateTime = new DateTime[] {DateTime.MinValue} ;
         BC001D4_A423SYS_UserModifier = new String[] {""} ;
         BC001D4_n423SYS_UserModifier = new bool[] {false} ;
         BC001D4_A424SYS_UserModifyTime = new DateTime[] {DateTime.MinValue} ;
         BC001D4_n424SYS_UserModifyTime = new bool[] {false} ;
         BC001D4_A425SYS_UserIsDeleted = new short[1] ;
         BC001D4_A426Email = new String[] {""} ;
         BC001D4_n426Email = new bool[] {false} ;
         BC001D4_A427SYS_UserDescription = new String[] {""} ;
         BC001D4_n427SYS_UserDescription = new bool[] {false} ;
         BC001D4_A428RocheAccount = new String[] {""} ;
         BC001D4_n428RocheAccount = new bool[] {false} ;
         BC001D5_A364Account = new String[] {""} ;
         BC001D6_A359UserID = new Guid[] {Guid.Empty} ;
         BC001D3_A359UserID = new Guid[] {Guid.Empty} ;
         BC001D3_A416DisplayName = new String[] {""} ;
         BC001D3_A417UserType = new int[1] ;
         BC001D3_A364Account = new String[] {""} ;
         BC001D3_A418PasswordHash = new String[] {""} ;
         BC001D3_A419LoginIP = new String[] {""} ;
         BC001D3_n419LoginIP = new bool[] {false} ;
         BC001D3_A420LoginTime = new DateTime[] {DateTime.MinValue} ;
         BC001D3_n420LoginTime = new bool[] {false} ;
         BC001D3_A421SYS_UserCreator = new String[] {""} ;
         BC001D3_A422SYS_UserCreateTime = new DateTime[] {DateTime.MinValue} ;
         BC001D3_A423SYS_UserModifier = new String[] {""} ;
         BC001D3_n423SYS_UserModifier = new bool[] {false} ;
         BC001D3_A424SYS_UserModifyTime = new DateTime[] {DateTime.MinValue} ;
         BC001D3_n424SYS_UserModifyTime = new bool[] {false} ;
         BC001D3_A425SYS_UserIsDeleted = new short[1] ;
         BC001D3_A426Email = new String[] {""} ;
         BC001D3_n426Email = new bool[] {false} ;
         BC001D3_A427SYS_UserDescription = new String[] {""} ;
         BC001D3_n427SYS_UserDescription = new bool[] {false} ;
         BC001D3_A428RocheAccount = new String[] {""} ;
         BC001D3_n428RocheAccount = new bool[] {false} ;
         sMode50 = "";
         BC001D2_A359UserID = new Guid[] {Guid.Empty} ;
         BC001D2_A416DisplayName = new String[] {""} ;
         BC001D2_A417UserType = new int[1] ;
         BC001D2_A364Account = new String[] {""} ;
         BC001D2_A418PasswordHash = new String[] {""} ;
         BC001D2_A419LoginIP = new String[] {""} ;
         BC001D2_n419LoginIP = new bool[] {false} ;
         BC001D2_A420LoginTime = new DateTime[] {DateTime.MinValue} ;
         BC001D2_n420LoginTime = new bool[] {false} ;
         BC001D2_A421SYS_UserCreator = new String[] {""} ;
         BC001D2_A422SYS_UserCreateTime = new DateTime[] {DateTime.MinValue} ;
         BC001D2_A423SYS_UserModifier = new String[] {""} ;
         BC001D2_n423SYS_UserModifier = new bool[] {false} ;
         BC001D2_A424SYS_UserModifyTime = new DateTime[] {DateTime.MinValue} ;
         BC001D2_n424SYS_UserModifyTime = new bool[] {false} ;
         BC001D2_A425SYS_UserIsDeleted = new short[1] ;
         BC001D2_A426Email = new String[] {""} ;
         BC001D2_n426Email = new bool[] {false} ;
         BC001D2_A427SYS_UserDescription = new String[] {""} ;
         BC001D2_n427SYS_UserDescription = new bool[] {false} ;
         BC001D2_A428RocheAccount = new String[] {""} ;
         BC001D2_n428RocheAccount = new bool[] {false} ;
         BC001D10_A358InstituteCode = new String[] {""} ;
         BC001D10_A359UserID = new Guid[] {Guid.Empty} ;
         BC001D11_A360BAS_TenantTenantCode = new String[] {""} ;
         BC001D11_A359UserID = new Guid[] {Guid.Empty} ;
         BC001D12_A359UserID = new Guid[] {Guid.Empty} ;
         BC001D12_A361RoleID = new Guid[] {Guid.Empty} ;
         BC001D13_A359UserID = new Guid[] {Guid.Empty} ;
         BC001D13_A416DisplayName = new String[] {""} ;
         BC001D13_A417UserType = new int[1] ;
         BC001D13_A364Account = new String[] {""} ;
         BC001D13_A418PasswordHash = new String[] {""} ;
         BC001D13_A419LoginIP = new String[] {""} ;
         BC001D13_n419LoginIP = new bool[] {false} ;
         BC001D13_A420LoginTime = new DateTime[] {DateTime.MinValue} ;
         BC001D13_n420LoginTime = new bool[] {false} ;
         BC001D13_A421SYS_UserCreator = new String[] {""} ;
         BC001D13_A422SYS_UserCreateTime = new DateTime[] {DateTime.MinValue} ;
         BC001D13_A423SYS_UserModifier = new String[] {""} ;
         BC001D13_n423SYS_UserModifier = new bool[] {false} ;
         BC001D13_A424SYS_UserModifyTime = new DateTime[] {DateTime.MinValue} ;
         BC001D13_n424SYS_UserModifyTime = new bool[] {false} ;
         BC001D13_A425SYS_UserIsDeleted = new short[1] ;
         BC001D13_A426Email = new String[] {""} ;
         BC001D13_n426Email = new bool[] {false} ;
         BC001D13_A427SYS_UserDescription = new String[] {""} ;
         BC001D13_n427SYS_UserDescription = new bool[] {false} ;
         BC001D13_A428RocheAccount = new String[] {""} ;
         BC001D13_n428RocheAccount = new bool[] {false} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.sys_user_bc__datastore1(),
            new Object[][] {
                new Object[] {
               BC001D2_A359UserID, BC001D2_A416DisplayName, BC001D2_A417UserType, BC001D2_A364Account, BC001D2_A418PasswordHash, BC001D2_A419LoginIP, BC001D2_n419LoginIP, BC001D2_A420LoginTime, BC001D2_n420LoginTime, BC001D2_A421SYS_UserCreator,
               BC001D2_A422SYS_UserCreateTime, BC001D2_A423SYS_UserModifier, BC001D2_n423SYS_UserModifier, BC001D2_A424SYS_UserModifyTime, BC001D2_n424SYS_UserModifyTime, BC001D2_A425SYS_UserIsDeleted, BC001D2_A426Email, BC001D2_n426Email, BC001D2_A427SYS_UserDescription, BC001D2_n427SYS_UserDescription,
               BC001D2_A428RocheAccount, BC001D2_n428RocheAccount
               }
               , new Object[] {
               BC001D3_A359UserID, BC001D3_A416DisplayName, BC001D3_A417UserType, BC001D3_A364Account, BC001D3_A418PasswordHash, BC001D3_A419LoginIP, BC001D3_n419LoginIP, BC001D3_A420LoginTime, BC001D3_n420LoginTime, BC001D3_A421SYS_UserCreator,
               BC001D3_A422SYS_UserCreateTime, BC001D3_A423SYS_UserModifier, BC001D3_n423SYS_UserModifier, BC001D3_A424SYS_UserModifyTime, BC001D3_n424SYS_UserModifyTime, BC001D3_A425SYS_UserIsDeleted, BC001D3_A426Email, BC001D3_n426Email, BC001D3_A427SYS_UserDescription, BC001D3_n427SYS_UserDescription,
               BC001D3_A428RocheAccount, BC001D3_n428RocheAccount
               }
               , new Object[] {
               BC001D4_A359UserID, BC001D4_A416DisplayName, BC001D4_A417UserType, BC001D4_A364Account, BC001D4_A418PasswordHash, BC001D4_A419LoginIP, BC001D4_n419LoginIP, BC001D4_A420LoginTime, BC001D4_n420LoginTime, BC001D4_A421SYS_UserCreator,
               BC001D4_A422SYS_UserCreateTime, BC001D4_A423SYS_UserModifier, BC001D4_n423SYS_UserModifier, BC001D4_A424SYS_UserModifyTime, BC001D4_n424SYS_UserModifyTime, BC001D4_A425SYS_UserIsDeleted, BC001D4_A426Email, BC001D4_n426Email, BC001D4_A427SYS_UserDescription, BC001D4_n427SYS_UserDescription,
               BC001D4_A428RocheAccount, BC001D4_n428RocheAccount
               }
               , new Object[] {
               BC001D5_A364Account
               }
               , new Object[] {
               BC001D6_A359UserID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC001D10_A358InstituteCode, BC001D10_A359UserID
               }
               , new Object[] {
               BC001D11_A360BAS_TenantTenantCode, BC001D11_A359UserID
               }
               , new Object[] {
               BC001D12_A359UserID, BC001D12_A361RoleID
               }
               , new Object[] {
               BC001D13_A359UserID, BC001D13_A416DisplayName, BC001D13_A417UserType, BC001D13_A364Account, BC001D13_A418PasswordHash, BC001D13_A419LoginIP, BC001D13_n419LoginIP, BC001D13_A420LoginTime, BC001D13_n420LoginTime, BC001D13_A421SYS_UserCreator,
               BC001D13_A422SYS_UserCreateTime, BC001D13_A423SYS_UserModifier, BC001D13_n423SYS_UserModifier, BC001D13_A424SYS_UserModifyTime, BC001D13_n424SYS_UserModifyTime, BC001D13_A425SYS_UserIsDeleted, BC001D13_A426Email, BC001D13_n426Email, BC001D13_A427SYS_UserDescription, BC001D13_n427SYS_UserDescription,
               BC001D13_A428RocheAccount, BC001D13_n428RocheAccount
               }
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.sys_user_bc__default(),
            new Object[][] {
            }
         );
         Z359UserID = (Guid)(Guid.NewGuid( ));
         A359UserID = (Guid)(Guid.NewGuid( ));
         INITTRN();
         /* Execute Start event if defined. */
         standaloneNotModal( ) ;
      }

      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short GX_JID ;
      private short Z425SYS_UserIsDeleted ;
      private short A425SYS_UserIsDeleted ;
      private short Gx_BScreen ;
      private short RcdFound50 ;
      private int trnEnded ;
      private int Z417UserType ;
      private int A417UserType ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String sMode50 ;
      private DateTime Z420LoginTime ;
      private DateTime A420LoginTime ;
      private DateTime Z422SYS_UserCreateTime ;
      private DateTime A422SYS_UserCreateTime ;
      private DateTime Z424SYS_UserModifyTime ;
      private DateTime A424SYS_UserModifyTime ;
      private bool n419LoginIP ;
      private bool n420LoginTime ;
      private bool n423SYS_UserModifier ;
      private bool n424SYS_UserModifyTime ;
      private bool n426Email ;
      private bool n427SYS_UserDescription ;
      private bool n428RocheAccount ;
      private bool Gx_longc ;
      private String Z427SYS_UserDescription ;
      private String A427SYS_UserDescription ;
      private String Z416DisplayName ;
      private String A416DisplayName ;
      private String Z364Account ;
      private String A364Account ;
      private String Z418PasswordHash ;
      private String A418PasswordHash ;
      private String Z419LoginIP ;
      private String A419LoginIP ;
      private String Z421SYS_UserCreator ;
      private String A421SYS_UserCreator ;
      private String Z423SYS_UserModifier ;
      private String A423SYS_UserModifier ;
      private String Z426Email ;
      private String A426Email ;
      private String Z428RocheAccount ;
      private String A428RocheAccount ;
      private Guid Z359UserID ;
      private Guid A359UserID ;
      private SdtSYS_User bcSYS_User ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_datastore1 ;
      private Guid[] BC001D4_A359UserID ;
      private String[] BC001D4_A416DisplayName ;
      private int[] BC001D4_A417UserType ;
      private String[] BC001D4_A364Account ;
      private String[] BC001D4_A418PasswordHash ;
      private String[] BC001D4_A419LoginIP ;
      private bool[] BC001D4_n419LoginIP ;
      private DateTime[] BC001D4_A420LoginTime ;
      private bool[] BC001D4_n420LoginTime ;
      private String[] BC001D4_A421SYS_UserCreator ;
      private DateTime[] BC001D4_A422SYS_UserCreateTime ;
      private String[] BC001D4_A423SYS_UserModifier ;
      private bool[] BC001D4_n423SYS_UserModifier ;
      private DateTime[] BC001D4_A424SYS_UserModifyTime ;
      private bool[] BC001D4_n424SYS_UserModifyTime ;
      private short[] BC001D4_A425SYS_UserIsDeleted ;
      private String[] BC001D4_A426Email ;
      private bool[] BC001D4_n426Email ;
      private String[] BC001D4_A427SYS_UserDescription ;
      private bool[] BC001D4_n427SYS_UserDescription ;
      private String[] BC001D4_A428RocheAccount ;
      private bool[] BC001D4_n428RocheAccount ;
      private String[] BC001D5_A364Account ;
      private Guid[] BC001D6_A359UserID ;
      private Guid[] BC001D3_A359UserID ;
      private String[] BC001D3_A416DisplayName ;
      private int[] BC001D3_A417UserType ;
      private String[] BC001D3_A364Account ;
      private String[] BC001D3_A418PasswordHash ;
      private String[] BC001D3_A419LoginIP ;
      private bool[] BC001D3_n419LoginIP ;
      private DateTime[] BC001D3_A420LoginTime ;
      private bool[] BC001D3_n420LoginTime ;
      private String[] BC001D3_A421SYS_UserCreator ;
      private DateTime[] BC001D3_A422SYS_UserCreateTime ;
      private String[] BC001D3_A423SYS_UserModifier ;
      private bool[] BC001D3_n423SYS_UserModifier ;
      private DateTime[] BC001D3_A424SYS_UserModifyTime ;
      private bool[] BC001D3_n424SYS_UserModifyTime ;
      private short[] BC001D3_A425SYS_UserIsDeleted ;
      private String[] BC001D3_A426Email ;
      private bool[] BC001D3_n426Email ;
      private String[] BC001D3_A427SYS_UserDescription ;
      private bool[] BC001D3_n427SYS_UserDescription ;
      private String[] BC001D3_A428RocheAccount ;
      private bool[] BC001D3_n428RocheAccount ;
      private Guid[] BC001D2_A359UserID ;
      private String[] BC001D2_A416DisplayName ;
      private int[] BC001D2_A417UserType ;
      private String[] BC001D2_A364Account ;
      private String[] BC001D2_A418PasswordHash ;
      private String[] BC001D2_A419LoginIP ;
      private bool[] BC001D2_n419LoginIP ;
      private DateTime[] BC001D2_A420LoginTime ;
      private bool[] BC001D2_n420LoginTime ;
      private String[] BC001D2_A421SYS_UserCreator ;
      private DateTime[] BC001D2_A422SYS_UserCreateTime ;
      private String[] BC001D2_A423SYS_UserModifier ;
      private bool[] BC001D2_n423SYS_UserModifier ;
      private DateTime[] BC001D2_A424SYS_UserModifyTime ;
      private bool[] BC001D2_n424SYS_UserModifyTime ;
      private short[] BC001D2_A425SYS_UserIsDeleted ;
      private String[] BC001D2_A426Email ;
      private bool[] BC001D2_n426Email ;
      private String[] BC001D2_A427SYS_UserDescription ;
      private bool[] BC001D2_n427SYS_UserDescription ;
      private String[] BC001D2_A428RocheAccount ;
      private bool[] BC001D2_n428RocheAccount ;
      private String[] BC001D10_A358InstituteCode ;
      private Guid[] BC001D10_A359UserID ;
      private String[] BC001D11_A360BAS_TenantTenantCode ;
      private Guid[] BC001D11_A359UserID ;
      private Guid[] BC001D12_A359UserID ;
      private Guid[] BC001D12_A361RoleID ;
      private Guid[] BC001D13_A359UserID ;
      private String[] BC001D13_A416DisplayName ;
      private int[] BC001D13_A417UserType ;
      private String[] BC001D13_A364Account ;
      private String[] BC001D13_A418PasswordHash ;
      private String[] BC001D13_A419LoginIP ;
      private bool[] BC001D13_n419LoginIP ;
      private DateTime[] BC001D13_A420LoginTime ;
      private bool[] BC001D13_n420LoginTime ;
      private String[] BC001D13_A421SYS_UserCreator ;
      private DateTime[] BC001D13_A422SYS_UserCreateTime ;
      private String[] BC001D13_A423SYS_UserModifier ;
      private bool[] BC001D13_n423SYS_UserModifier ;
      private DateTime[] BC001D13_A424SYS_UserModifyTime ;
      private bool[] BC001D13_n424SYS_UserModifyTime ;
      private short[] BC001D13_A425SYS_UserIsDeleted ;
      private String[] BC001D13_A426Email ;
      private bool[] BC001D13_n426Email ;
      private String[] BC001D13_A427SYS_UserDescription ;
      private bool[] BC001D13_n427SYS_UserDescription ;
      private String[] BC001D13_A428RocheAccount ;
      private bool[] BC001D13_n428RocheAccount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_default ;
   }

   public class sys_user_bc__datastore1 : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[10])
         ,new ForEachCursor(def[11])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmBC001D4 ;
          prmBC001D4 = new Object[] {
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC001D5 ;
          prmBC001D5 = new Object[] {
          new Object[] {"@Account",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC001D6 ;
          prmBC001D6 = new Object[] {
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC001D3 ;
          prmBC001D3 = new Object[] {
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC001D2 ;
          prmBC001D2 = new Object[] {
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC001D7 ;
          prmBC001D7 = new Object[] {
          new Object[] {"@DisplayName",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@UserType",SqlDbType.Int,9,0} ,
          new Object[] {"@Account",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@PasswordHash",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@LoginIP",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@LoginTime",SqlDbType.DateTime,10,8} ,
          new Object[] {"@SYS_UserCreator",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@SYS_UserCreateTime",SqlDbType.DateTime,10,8} ,
          new Object[] {"@SYS_UserModifier",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@SYS_UserModifyTime",SqlDbType.DateTime,10,8} ,
          new Object[] {"@SYS_UserIsDeleted",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@Email",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@SYS_UserDescription",SqlDbType.NVarChar,2048,0} ,
          new Object[] {"@RocheAccount",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC001D8 ;
          prmBC001D8 = new Object[] {
          new Object[] {"@DisplayName",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@UserType",SqlDbType.Int,9,0} ,
          new Object[] {"@Account",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@PasswordHash",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@LoginIP",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@LoginTime",SqlDbType.DateTime,10,8} ,
          new Object[] {"@SYS_UserCreator",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@SYS_UserCreateTime",SqlDbType.DateTime,10,8} ,
          new Object[] {"@SYS_UserModifier",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@SYS_UserModifyTime",SqlDbType.DateTime,10,8} ,
          new Object[] {"@SYS_UserIsDeleted",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@Email",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@SYS_UserDescription",SqlDbType.NVarChar,2048,0} ,
          new Object[] {"@RocheAccount",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC001D9 ;
          prmBC001D9 = new Object[] {
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC001D10 ;
          prmBC001D10 = new Object[] {
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC001D11 ;
          prmBC001D11 = new Object[] {
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC001D12 ;
          prmBC001D12 = new Object[] {
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC001D13 ;
          prmBC001D13 = new Object[] {
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("BC001D2", "SELECT [UserID], [DisplayName], [UserType], [Account], [PasswordHash], [LoginIP], [LoginTime], [Creator], [CreateTime], [Modifier], [ModifyTime], [IsDeleted], [Email], [Description], [RocheAccount] FROM dbo.[SYS_User] WITH (UPDLOCK) WHERE [UserID] = @UserID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001D2,1,0,true,false )
             ,new CursorDef("BC001D3", "SELECT [UserID], [DisplayName], [UserType], [Account], [PasswordHash], [LoginIP], [LoginTime], [Creator], [CreateTime], [Modifier], [ModifyTime], [IsDeleted], [Email], [Description], [RocheAccount] FROM dbo.[SYS_User] WITH (NOLOCK) WHERE [UserID] = @UserID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001D3,1,0,true,false )
             ,new CursorDef("BC001D4", "SELECT TM1.[UserID], TM1.[DisplayName], TM1.[UserType], TM1.[Account], TM1.[PasswordHash], TM1.[LoginIP], TM1.[LoginTime], TM1.[Creator], TM1.[CreateTime], TM1.[Modifier], TM1.[ModifyTime], TM1.[IsDeleted], TM1.[Email], TM1.[Description], TM1.[RocheAccount] FROM dbo.[SYS_User] TM1 WITH (NOLOCK) WHERE TM1.[UserID] = @UserID ORDER BY TM1.[UserID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001D4,100,0,true,false )
             ,new CursorDef("BC001D5", "SELECT [Account] FROM dbo.[SYS_User] WITH (NOLOCK) WHERE ([Account] = @Account) AND (Not ( [UserID] = @UserID)) ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001D5,1,0,true,false )
             ,new CursorDef("BC001D6", "SELECT [UserID] FROM dbo.[SYS_User] WITH (NOLOCK) WHERE [UserID] = @UserID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001D6,1,0,true,false )
             ,new CursorDef("BC001D7", "INSERT INTO dbo.[SYS_User]([DisplayName], [UserType], [Account], [PasswordHash], [LoginIP], [LoginTime], [Creator], [CreateTime], [Modifier], [ModifyTime], [IsDeleted], [Email], [Description], [RocheAccount], [UserID]) VALUES(@DisplayName, @UserType, @Account, @PasswordHash, @LoginIP, @LoginTime, @SYS_UserCreator, @SYS_UserCreateTime, @SYS_UserModifier, @SYS_UserModifyTime, @SYS_UserIsDeleted, @Email, @SYS_UserDescription, @RocheAccount, @UserID)", GxErrorMask.GX_NOMASK,prmBC001D7)
             ,new CursorDef("BC001D8", "UPDATE dbo.[SYS_User] SET [DisplayName]=@DisplayName, [UserType]=@UserType, [Account]=@Account, [PasswordHash]=@PasswordHash, [LoginIP]=@LoginIP, [LoginTime]=@LoginTime, [Creator]=@SYS_UserCreator, [CreateTime]=@SYS_UserCreateTime, [Modifier]=@SYS_UserModifier, [ModifyTime]=@SYS_UserModifyTime, [IsDeleted]=@SYS_UserIsDeleted, [Email]=@Email, [Description]=@SYS_UserDescription, [RocheAccount]=@RocheAccount  WHERE [UserID] = @UserID", GxErrorMask.GX_NOMASK,prmBC001D8)
             ,new CursorDef("BC001D9", "DELETE FROM dbo.[SYS_User]  WHERE [UserID] = @UserID", GxErrorMask.GX_NOMASK,prmBC001D9)
             ,new CursorDef("BC001D10", "SELECT TOP 1 [InstituteCode], [UserID] FROM dbo.[SYS_InstituteUser] WITH (NOLOCK) WHERE [UserID] = @UserID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001D10,1,0,true,true )
             ,new CursorDef("BC001D11", "SELECT TOP 1 [TenantCode], [UserID] FROM dbo.[SYS_TenantUser] WITH (NOLOCK) WHERE [UserID] = @UserID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001D11,1,0,true,true )
             ,new CursorDef("BC001D12", "SELECT TOP 1 [UserID], [RoleID] FROM dbo.[SYS_UserRole] WITH (NOLOCK) WHERE [UserID] = @UserID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001D12,1,0,true,true )
             ,new CursorDef("BC001D13", "SELECT TM1.[UserID], TM1.[DisplayName], TM1.[UserType], TM1.[Account], TM1.[PasswordHash], TM1.[LoginIP], TM1.[LoginTime], TM1.[Creator], TM1.[CreateTime], TM1.[Modifier], TM1.[ModifyTime], TM1.[IsDeleted], TM1.[Email], TM1.[Description], TM1.[RocheAccount] FROM dbo.[SYS_User] TM1 WITH (NOLOCK) WHERE TM1.[UserID] = @UserID ORDER BY TM1.[UserID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001D13,100,0,true,false )
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
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[7])[0] = rslt.getGXDateTime(7) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(7);
                ((String[]) buf[9])[0] = rslt.getVarchar(8) ;
                ((DateTime[]) buf[10])[0] = rslt.getGXDateTime(9) ;
                ((String[]) buf[11])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(10);
                ((DateTime[]) buf[13])[0] = rslt.getGXDateTime(11) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(11);
                ((short[]) buf[15])[0] = rslt.getShort(12) ;
                ((String[]) buf[16])[0] = rslt.getVarchar(13) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(13);
                ((String[]) buf[18])[0] = rslt.getLongVarchar(14) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(14);
                ((String[]) buf[20])[0] = rslt.getVarchar(15) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(15);
                return;
             case 1 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[7])[0] = rslt.getGXDateTime(7) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(7);
                ((String[]) buf[9])[0] = rslt.getVarchar(8) ;
                ((DateTime[]) buf[10])[0] = rslt.getGXDateTime(9) ;
                ((String[]) buf[11])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(10);
                ((DateTime[]) buf[13])[0] = rslt.getGXDateTime(11) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(11);
                ((short[]) buf[15])[0] = rslt.getShort(12) ;
                ((String[]) buf[16])[0] = rslt.getVarchar(13) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(13);
                ((String[]) buf[18])[0] = rslt.getLongVarchar(14) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(14);
                ((String[]) buf[20])[0] = rslt.getVarchar(15) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(15);
                return;
             case 2 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[7])[0] = rslt.getGXDateTime(7) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(7);
                ((String[]) buf[9])[0] = rslt.getVarchar(8) ;
                ((DateTime[]) buf[10])[0] = rslt.getGXDateTime(9) ;
                ((String[]) buf[11])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(10);
                ((DateTime[]) buf[13])[0] = rslt.getGXDateTime(11) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(11);
                ((short[]) buf[15])[0] = rslt.getShort(12) ;
                ((String[]) buf[16])[0] = rslt.getVarchar(13) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(13);
                ((String[]) buf[18])[0] = rslt.getLongVarchar(14) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(14);
                ((String[]) buf[20])[0] = rslt.getVarchar(15) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(15);
                return;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                return;
             case 4 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                return;
             case 8 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((Guid[]) buf[1])[0] = rslt.getGuid(2) ;
                return;
             case 9 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((Guid[]) buf[1])[0] = rslt.getGuid(2) ;
                return;
             case 10 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                ((Guid[]) buf[1])[0] = rslt.getGuid(2) ;
                return;
             case 11 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[7])[0] = rslt.getGXDateTime(7) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(7);
                ((String[]) buf[9])[0] = rslt.getVarchar(8) ;
                ((DateTime[]) buf[10])[0] = rslt.getGXDateTime(9) ;
                ((String[]) buf[11])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(10);
                ((DateTime[]) buf[13])[0] = rslt.getGXDateTime(11) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(11);
                ((short[]) buf[15])[0] = rslt.getShort(12) ;
                ((String[]) buf[16])[0] = rslt.getVarchar(13) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(13);
                ((String[]) buf[18])[0] = rslt.getLongVarchar(14) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(14);
                ((String[]) buf[20])[0] = rslt.getVarchar(15) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(15);
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
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (Guid)parms[1]);
                return;
             case 4 :
                stmt.SetParameter(1, (Guid)parms[0]);
                return;
             case 5 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
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
                stmt.SetParameter(7, (String)parms[8]);
                stmt.SetParameterDatetime(8, (DateTime)parms[9]);
                if ( (bool)parms[10] )
                {
                   stmt.setNull( 9 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(9, (String)parms[11]);
                }
                if ( (bool)parms[12] )
                {
                   stmt.setNull( 10 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(10, (DateTime)parms[13]);
                }
                stmt.SetParameter(11, (short)parms[14]);
                if ( (bool)parms[15] )
                {
                   stmt.setNull( 12 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(12, (String)parms[16]);
                }
                if ( (bool)parms[17] )
                {
                   stmt.setNull( 13 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(13, (String)parms[18]);
                }
                if ( (bool)parms[19] )
                {
                   stmt.setNull( 14 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(14, (String)parms[20]);
                }
                stmt.SetParameter(15, (Guid)parms[21]);
                return;
             case 6 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
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
                stmt.SetParameter(7, (String)parms[8]);
                stmt.SetParameterDatetime(8, (DateTime)parms[9]);
                if ( (bool)parms[10] )
                {
                   stmt.setNull( 9 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(9, (String)parms[11]);
                }
                if ( (bool)parms[12] )
                {
                   stmt.setNull( 10 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(10, (DateTime)parms[13]);
                }
                stmt.SetParameter(11, (short)parms[14]);
                if ( (bool)parms[15] )
                {
                   stmt.setNull( 12 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(12, (String)parms[16]);
                }
                if ( (bool)parms[17] )
                {
                   stmt.setNull( 13 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(13, (String)parms[18]);
                }
                if ( (bool)parms[19] )
                {
                   stmt.setNull( 14 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(14, (String)parms[20]);
                }
                stmt.SetParameter(15, (Guid)parms[21]);
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
             case 10 :
                stmt.SetParameter(1, (Guid)parms[0]);
                return;
             case 11 :
                stmt.SetParameter(1, (Guid)parms[0]);
                return;
       }
    }

    public String getDataStoreName( )
    {
       return "DATASTORE1";
    }

 }

 public class sys_user_bc__default : DataStoreHelperBase, IDataStoreHelper
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
