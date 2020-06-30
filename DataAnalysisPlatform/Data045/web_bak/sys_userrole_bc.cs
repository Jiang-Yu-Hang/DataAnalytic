/*
               File: SYS_UserRole_BC
        Description: SYS_User Role
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:38:51.21
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
   public class sys_userrole_bc : GXHttpHandler, IGxSilentTrn
   {
      public sys_userrole_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public sys_userrole_bc( IGxContext context )
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
         ReadRow1643( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey1643( ) ;
         standaloneModal( ) ;
         AddRow1643( ) ;
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

      protected void CONFIRM_160( )
      {
         BeforeValidate1643( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls1643( ) ;
            }
            else
            {
               CheckExtendedTable1643( ) ;
               if ( AnyError == 0 )
               {
                  ZM1643( 4) ;
                  ZM1643( 5) ;
               }
               CloseExtendedTableCursors1643( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void ZM1643( short GX_JID )
      {
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
         }
         if ( ( GX_JID == 4 ) || ( GX_JID == 0 ) )
         {
         }
         if ( ( GX_JID == 5 ) || ( GX_JID == 0 ) )
         {
         }
         if ( GX_JID == -3 )
         {
            Z359UserID = (Guid)(A359UserID);
            Z361RoleID = (Guid)(A361RoleID);
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load1643( )
      {
         /* Using cursor BC00166 */
         pr_datastore1.execute(4, new Object[] {A359UserID, A361RoleID});
         if ( (pr_datastore1.getStatus(4) != 101) )
         {
            RcdFound43 = 1;
            ZM1643( -3) ;
         }
         pr_datastore1.close(4);
         OnLoadActions1643( ) ;
      }

      protected void OnLoadActions1643( )
      {
      }

      protected void CheckExtendedTable1643( )
      {
         standaloneModal( ) ;
         /* Using cursor BC00164 */
         pr_datastore1.execute(2, new Object[] {A359UserID});
         if ( (pr_datastore1.getStatus(2) == 101) )
         {
            GX_msglist.addItem("不匹配'SYS_User'", "ForeignKeyNotFound", 1, "USERID");
            AnyError = 1;
         }
         pr_datastore1.close(2);
         /* Using cursor BC00165 */
         pr_datastore1.execute(3, new Object[] {A361RoleID});
         if ( (pr_datastore1.getStatus(3) == 101) )
         {
            GX_msglist.addItem("不匹配'SYS_Role'", "ForeignKeyNotFound", 1, "ROLEID");
            AnyError = 1;
         }
         pr_datastore1.close(3);
      }

      protected void CloseExtendedTableCursors1643( )
      {
         pr_datastore1.close(2);
         pr_datastore1.close(3);
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey1643( )
      {
         /* Using cursor BC00167 */
         pr_datastore1.execute(5, new Object[] {A359UserID, A361RoleID});
         if ( (pr_datastore1.getStatus(5) != 101) )
         {
            RcdFound43 = 1;
         }
         else
         {
            RcdFound43 = 0;
         }
         pr_datastore1.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC00163 */
         pr_datastore1.execute(1, new Object[] {A359UserID, A361RoleID});
         if ( (pr_datastore1.getStatus(1) != 101) )
         {
            ZM1643( 3) ;
            RcdFound43 = 1;
            A359UserID = (Guid)((Guid)(BC00163_A359UserID[0]));
            A361RoleID = (Guid)((Guid)(BC00163_A361RoleID[0]));
            Z359UserID = (Guid)(A359UserID);
            Z361RoleID = (Guid)(A361RoleID);
            sMode43 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load1643( ) ;
            if ( AnyError == 1 )
            {
               RcdFound43 = 0;
               InitializeNonKey1643( ) ;
            }
            Gx_mode = sMode43;
         }
         else
         {
            RcdFound43 = 0;
            InitializeNonKey1643( ) ;
            sMode43 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode43;
         }
         pr_datastore1.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1643( ) ;
         if ( RcdFound43 == 0 )
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
         CONFIRM_160( ) ;
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

      protected void CheckOptimisticConcurrency1643( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC00162 */
            pr_datastore1.execute(0, new Object[] {A359UserID, A361RoleID});
            if ( (pr_datastore1.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SYS_USERROLE"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_datastore1.getStatus(0) == 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"SYS_USERROLE"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert1643( )
      {
         BeforeValidate1643( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1643( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1643( 0) ;
            CheckOptimisticConcurrency1643( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1643( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1643( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00168 */
                     pr_datastore1.execute(6, new Object[] {A359UserID, A361RoleID});
                     pr_datastore1.close(6);
                     dsDataStore1.SmartCacheProvider.SetUpdated("SYS_USERROLE") ;
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
               Load1643( ) ;
            }
            EndLevel1643( ) ;
         }
         CloseExtendedTableCursors1643( ) ;
      }

      protected void Update1643( )
      {
         BeforeValidate1643( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1643( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1643( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1643( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1643( ) ;
                  if ( AnyError == 0 )
                  {
                     /* No attributes to update on table dbo.[SYS_UserRole] */
                     DeferredUpdate1643( ) ;
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
            EndLevel1643( ) ;
         }
         CloseExtendedTableCursors1643( ) ;
      }

      protected void DeferredUpdate1643( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate1643( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1643( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1643( ) ;
            AfterConfirm1643( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1643( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC00169 */
                  pr_datastore1.execute(7, new Object[] {A359UserID, A361RoleID});
                  pr_datastore1.close(7);
                  dsDataStore1.SmartCacheProvider.SetUpdated("SYS_USERROLE") ;
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
         sMode43 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel1643( ) ;
         Gx_mode = sMode43;
      }

      protected void OnDeleteControls1643( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel1643( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_datastore1.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1643( ) ;
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

      public void ScanKeyStart1643( )
      {
         /* Using cursor BC001610 */
         pr_datastore1.execute(8, new Object[] {A359UserID, A361RoleID});
         RcdFound43 = 0;
         if ( (pr_datastore1.getStatus(8) != 101) )
         {
            RcdFound43 = 1;
            A359UserID = (Guid)((Guid)(BC001610_A359UserID[0]));
            A361RoleID = (Guid)((Guid)(BC001610_A361RoleID[0]));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext1643( )
      {
         /* Scan next routine */
         pr_datastore1.readNext(8);
         RcdFound43 = 0;
         ScanKeyLoad1643( ) ;
      }

      protected void ScanKeyLoad1643( )
      {
         sMode43 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_datastore1.getStatus(8) != 101) )
         {
            RcdFound43 = 1;
            A359UserID = (Guid)((Guid)(BC001610_A359UserID[0]));
            A361RoleID = (Guid)((Guid)(BC001610_A361RoleID[0]));
         }
         Gx_mode = sMode43;
      }

      protected void ScanKeyEnd1643( )
      {
         pr_datastore1.close(8);
      }

      protected void AfterConfirm1643( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1643( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1643( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1643( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1643( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1643( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1643( )
      {
      }

      protected void send_integrity_lvl_hashes1643( )
      {
      }

      protected void AddRow1643( )
      {
         VarsToRow43( bcSYS_UserRole) ;
      }

      protected void ReadRow1643( )
      {
         RowToVars43( bcSYS_UserRole, 1) ;
      }

      protected void InitializeNonKey1643( )
      {
      }

      protected void InitAll1643( )
      {
         A359UserID = (Guid)(Guid.Empty);
         A361RoleID = (Guid)(Guid.Empty);
         InitializeNonKey1643( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow43( SdtSYS_UserRole obj43 )
      {
         obj43.gxTpr_Mode = Gx_mode;
         obj43.gxTpr_Userid = (Guid)(A359UserID);
         obj43.gxTpr_Roleid = (Guid)(A361RoleID);
         obj43.gxTpr_Userid_Z = (Guid)(Z359UserID);
         obj43.gxTpr_Roleid_Z = (Guid)(Z361RoleID);
         obj43.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow43( SdtSYS_UserRole obj43 )
      {
         obj43.gxTpr_Userid = (Guid)(A359UserID);
         obj43.gxTpr_Roleid = (Guid)(A361RoleID);
         return  ;
      }

      public void RowToVars43( SdtSYS_UserRole obj43 ,
                               int forceLoad )
      {
         Gx_mode = obj43.gxTpr_Mode;
         A359UserID = (Guid)(obj43.gxTpr_Userid);
         A361RoleID = (Guid)(obj43.gxTpr_Roleid);
         Z359UserID = (Guid)(obj43.gxTpr_Userid_Z);
         Z361RoleID = (Guid)(obj43.gxTpr_Roleid_Z);
         Gx_mode = obj43.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A359UserID = (Guid)((Guid)getParm(obj,0));
         A361RoleID = (Guid)((Guid)getParm(obj,1));
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey1643( ) ;
         ScanKeyStart1643( ) ;
         if ( RcdFound43 == 0 )
         {
            Gx_mode = "INS";
            /* Using cursor BC001611 */
            pr_datastore1.execute(9, new Object[] {A359UserID});
            if ( (pr_datastore1.getStatus(9) == 101) )
            {
               GX_msglist.addItem("不匹配'SYS_User'", "ForeignKeyNotFound", 1, "USERID");
               AnyError = 1;
            }
            pr_datastore1.close(9);
            /* Using cursor BC001612 */
            pr_datastore1.execute(10, new Object[] {A361RoleID});
            if ( (pr_datastore1.getStatus(10) == 101) )
            {
               GX_msglist.addItem("不匹配'SYS_Role'", "ForeignKeyNotFound", 1, "ROLEID");
               AnyError = 1;
            }
            pr_datastore1.close(10);
         }
         else
         {
            Gx_mode = "UPD";
            Z359UserID = (Guid)(A359UserID);
            Z361RoleID = (Guid)(A361RoleID);
         }
         ZM1643( -3) ;
         OnLoadActions1643( ) ;
         AddRow1643( ) ;
         ScanKeyEnd1643( ) ;
         if ( RcdFound43 == 0 )
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
         RowToVars43( bcSYS_UserRole, 0) ;
         ScanKeyStart1643( ) ;
         if ( RcdFound43 == 0 )
         {
            Gx_mode = "INS";
            /* Using cursor BC001611 */
            pr_datastore1.execute(9, new Object[] {A359UserID});
            if ( (pr_datastore1.getStatus(9) == 101) )
            {
               GX_msglist.addItem("不匹配'SYS_User'", "ForeignKeyNotFound", 1, "USERID");
               AnyError = 1;
            }
            pr_datastore1.close(9);
            /* Using cursor BC001612 */
            pr_datastore1.execute(10, new Object[] {A361RoleID});
            if ( (pr_datastore1.getStatus(10) == 101) )
            {
               GX_msglist.addItem("不匹配'SYS_Role'", "ForeignKeyNotFound", 1, "ROLEID");
               AnyError = 1;
            }
            pr_datastore1.close(10);
         }
         else
         {
            Gx_mode = "UPD";
            Z359UserID = (Guid)(A359UserID);
            Z361RoleID = (Guid)(A361RoleID);
         }
         ZM1643( -3) ;
         OnLoadActions1643( ) ;
         AddRow1643( ) ;
         ScanKeyEnd1643( ) ;
         if ( RcdFound43 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey1643( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert1643( ) ;
         }
         else
         {
            if ( RcdFound43 == 1 )
            {
               if ( ( A359UserID != Z359UserID ) || ( A361RoleID != Z361RoleID ) )
               {
                  A359UserID = (Guid)(Z359UserID);
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
                  Update1643( ) ;
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
                  if ( ( A359UserID != Z359UserID ) || ( A361RoleID != Z361RoleID ) )
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
                        Insert1643( ) ;
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
                        Insert1643( ) ;
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
         RowToVars43( bcSYS_UserRole, 0) ;
         SaveImpl( ) ;
         VarsToRow43( bcSYS_UserRole) ;
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
         RowToVars43( bcSYS_UserRole, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert1643( ) ;
         AfterTrn( ) ;
         VarsToRow43( bcSYS_UserRole) ;
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
            SdtSYS_UserRole auxBC = new SdtSYS_UserRole(context) ;
            auxBC.Load(A359UserID, A361RoleID);
            auxBC.UpdateDirties(bcSYS_UserRole);
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
         RowToVars43( bcSYS_UserRole, 0) ;
         UpdateImpl( ) ;
         VarsToRow43( bcSYS_UserRole) ;
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
         RowToVars43( bcSYS_UserRole, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert1643( ) ;
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
         VarsToRow43( bcSYS_UserRole) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars43( bcSYS_UserRole, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey1643( ) ;
         if ( RcdFound43 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( ( A359UserID != Z359UserID ) || ( A361RoleID != Z361RoleID ) )
            {
               A359UserID = (Guid)(Z359UserID);
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
            if ( ( A359UserID != Z359UserID ) || ( A361RoleID != Z361RoleID ) )
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
         context.RollbackDataStores("sys_userrole_bc",pr_default);
         VarsToRow43( bcSYS_UserRole) ;
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
         Gx_mode = bcSYS_UserRole.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcSYS_UserRole.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcSYS_UserRole )
         {
            bcSYS_UserRole = (SdtSYS_UserRole)(sdt);
            if ( StringUtil.StrCmp(bcSYS_UserRole.gxTpr_Mode, "") == 0 )
            {
               bcSYS_UserRole.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow43( bcSYS_UserRole) ;
            }
            else
            {
               RowToVars43( bcSYS_UserRole, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcSYS_UserRole.gxTpr_Mode, "") == 0 )
            {
               bcSYS_UserRole.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars43( bcSYS_UserRole, 1) ;
         return  ;
      }

      public SdtSYS_UserRole SYS_UserRole_BC
      {
         get {
            return bcSYS_UserRole ;
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
         Z359UserID = (Guid)(Guid.Empty);
         A359UserID = (Guid)(Guid.Empty);
         Z361RoleID = (Guid)(Guid.Empty);
         A361RoleID = (Guid)(Guid.Empty);
         BC00166_A359UserID = new Guid[] {Guid.Empty} ;
         BC00166_A361RoleID = new Guid[] {Guid.Empty} ;
         BC00164_A359UserID = new Guid[] {Guid.Empty} ;
         BC00165_A361RoleID = new Guid[] {Guid.Empty} ;
         BC00167_A359UserID = new Guid[] {Guid.Empty} ;
         BC00167_A361RoleID = new Guid[] {Guid.Empty} ;
         BC00163_A359UserID = new Guid[] {Guid.Empty} ;
         BC00163_A361RoleID = new Guid[] {Guid.Empty} ;
         sMode43 = "";
         BC00162_A359UserID = new Guid[] {Guid.Empty} ;
         BC00162_A361RoleID = new Guid[] {Guid.Empty} ;
         BC001610_A359UserID = new Guid[] {Guid.Empty} ;
         BC001610_A361RoleID = new Guid[] {Guid.Empty} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         BC001611_A359UserID = new Guid[] {Guid.Empty} ;
         BC001612_A361RoleID = new Guid[] {Guid.Empty} ;
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.sys_userrole_bc__datastore1(),
            new Object[][] {
                new Object[] {
               BC00162_A359UserID, BC00162_A361RoleID
               }
               , new Object[] {
               BC00163_A359UserID, BC00163_A361RoleID
               }
               , new Object[] {
               BC00164_A359UserID
               }
               , new Object[] {
               BC00165_A361RoleID
               }
               , new Object[] {
               BC00166_A359UserID, BC00166_A361RoleID
               }
               , new Object[] {
               BC00167_A359UserID, BC00167_A361RoleID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC001610_A359UserID, BC001610_A361RoleID
               }
               , new Object[] {
               BC001611_A359UserID
               }
               , new Object[] {
               BC001612_A361RoleID
               }
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.sys_userrole_bc__default(),
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
      private short RcdFound43 ;
      private int trnEnded ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String sMode43 ;
      private Guid Z359UserID ;
      private Guid A359UserID ;
      private Guid Z361RoleID ;
      private Guid A361RoleID ;
      private SdtSYS_UserRole bcSYS_UserRole ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_datastore1 ;
      private Guid[] BC00166_A359UserID ;
      private Guid[] BC00166_A361RoleID ;
      private Guid[] BC00164_A359UserID ;
      private Guid[] BC00165_A361RoleID ;
      private Guid[] BC00167_A359UserID ;
      private Guid[] BC00167_A361RoleID ;
      private Guid[] BC00163_A359UserID ;
      private Guid[] BC00163_A361RoleID ;
      private Guid[] BC00162_A359UserID ;
      private Guid[] BC00162_A361RoleID ;
      private Guid[] BC001610_A359UserID ;
      private Guid[] BC001610_A361RoleID ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private Guid[] BC001611_A359UserID ;
      private Guid[] BC001612_A361RoleID ;
      private IDataStoreProvider pr_default ;
   }

   public class sys_userrole_bc__datastore1 : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmBC00166 ;
          prmBC00166 = new Object[] {
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0} ,
          new Object[] {"@RoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC00164 ;
          prmBC00164 = new Object[] {
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC00165 ;
          prmBC00165 = new Object[] {
          new Object[] {"@RoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC00167 ;
          prmBC00167 = new Object[] {
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0} ,
          new Object[] {"@RoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC00163 ;
          prmBC00163 = new Object[] {
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0} ,
          new Object[] {"@RoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC00162 ;
          prmBC00162 = new Object[] {
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0} ,
          new Object[] {"@RoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC00168 ;
          prmBC00168 = new Object[] {
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0} ,
          new Object[] {"@RoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC00169 ;
          prmBC00169 = new Object[] {
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0} ,
          new Object[] {"@RoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC001610 ;
          prmBC001610 = new Object[] {
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0} ,
          new Object[] {"@RoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC001611 ;
          prmBC001611 = new Object[] {
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC001612 ;
          prmBC001612 = new Object[] {
          new Object[] {"@RoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("BC00162", "SELECT [UserID], [RoleID] FROM dbo.[SYS_UserRole] WITH (UPDLOCK) WHERE [UserID] = @UserID AND [RoleID] = @RoleID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00162,1,0,true,false )
             ,new CursorDef("BC00163", "SELECT [UserID], [RoleID] FROM dbo.[SYS_UserRole] WITH (NOLOCK) WHERE [UserID] = @UserID AND [RoleID] = @RoleID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00163,1,0,true,false )
             ,new CursorDef("BC00164", "SELECT [UserID] FROM dbo.[SYS_User] WITH (NOLOCK) WHERE [UserID] = @UserID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00164,1,0,true,false )
             ,new CursorDef("BC00165", "SELECT [RoleID] FROM dbo.[SYS_Role] WITH (NOLOCK) WHERE [RoleID] = @RoleID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00165,1,0,true,false )
             ,new CursorDef("BC00166", "SELECT TM1.[UserID], TM1.[RoleID] FROM dbo.[SYS_UserRole] TM1 WITH (NOLOCK) WHERE TM1.[UserID] = @UserID and TM1.[RoleID] = @RoleID ORDER BY TM1.[UserID], TM1.[RoleID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00166,100,0,true,false )
             ,new CursorDef("BC00167", "SELECT [UserID], [RoleID] FROM dbo.[SYS_UserRole] WITH (NOLOCK) WHERE [UserID] = @UserID AND [RoleID] = @RoleID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00167,1,0,true,false )
             ,new CursorDef("BC00168", "INSERT INTO dbo.[SYS_UserRole]([UserID], [RoleID]) VALUES(@UserID, @RoleID)", GxErrorMask.GX_NOMASK,prmBC00168)
             ,new CursorDef("BC00169", "DELETE FROM dbo.[SYS_UserRole]  WHERE [UserID] = @UserID AND [RoleID] = @RoleID", GxErrorMask.GX_NOMASK,prmBC00169)
             ,new CursorDef("BC001610", "SELECT TM1.[UserID], TM1.[RoleID] FROM dbo.[SYS_UserRole] TM1 WITH (NOLOCK) WHERE TM1.[UserID] = @UserID and TM1.[RoleID] = @RoleID ORDER BY TM1.[UserID], TM1.[RoleID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001610,100,0,true,false )
             ,new CursorDef("BC001611", "SELECT [UserID] FROM dbo.[SYS_User] WITH (NOLOCK) WHERE [UserID] = @UserID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001611,1,0,true,false )
             ,new CursorDef("BC001612", "SELECT [RoleID] FROM dbo.[SYS_Role] WITH (NOLOCK) WHERE [RoleID] = @RoleID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001612,1,0,true,false )
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
                return;
             case 1 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                ((Guid[]) buf[1])[0] = rslt.getGuid(2) ;
                return;
             case 2 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                return;
             case 3 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                return;
             case 4 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                ((Guid[]) buf[1])[0] = rslt.getGuid(2) ;
                return;
             case 5 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                ((Guid[]) buf[1])[0] = rslt.getGuid(2) ;
                return;
             case 8 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                ((Guid[]) buf[1])[0] = rslt.getGuid(2) ;
                return;
             case 9 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
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
                stmt.SetParameter(1, (Guid)parms[0]);
                stmt.SetParameter(2, (Guid)parms[1]);
                return;
             case 1 :
                stmt.SetParameter(1, (Guid)parms[0]);
                stmt.SetParameter(2, (Guid)parms[1]);
                return;
             case 2 :
                stmt.SetParameter(1, (Guid)parms[0]);
                return;
             case 3 :
                stmt.SetParameter(1, (Guid)parms[0]);
                return;
             case 4 :
                stmt.SetParameter(1, (Guid)parms[0]);
                stmt.SetParameter(2, (Guid)parms[1]);
                return;
             case 5 :
                stmt.SetParameter(1, (Guid)parms[0]);
                stmt.SetParameter(2, (Guid)parms[1]);
                return;
             case 6 :
                stmt.SetParameter(1, (Guid)parms[0]);
                stmt.SetParameter(2, (Guid)parms[1]);
                return;
             case 7 :
                stmt.SetParameter(1, (Guid)parms[0]);
                stmt.SetParameter(2, (Guid)parms[1]);
                return;
             case 8 :
                stmt.SetParameter(1, (Guid)parms[0]);
                stmt.SetParameter(2, (Guid)parms[1]);
                return;
             case 9 :
                stmt.SetParameter(1, (Guid)parms[0]);
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

 public class sys_userrole_bc__default : DataStoreHelperBase, IDataStoreHelper
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
