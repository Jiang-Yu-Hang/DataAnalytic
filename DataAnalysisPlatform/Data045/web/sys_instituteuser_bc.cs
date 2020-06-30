/*
               File: SYS_InstituteUser_BC
        Description: SYS_Institute User
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:8:59.52
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
   public class sys_instituteuser_bc : GXHttpHandler, IGxSilentTrn
   {
      public sys_instituteuser_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public sys_instituteuser_bc( IGxContext context )
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
         ReadRow1C49( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey1C49( ) ;
         standaloneModal( ) ;
         AddRow1C49( ) ;
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
               Z358InstituteCode = A358InstituteCode;
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

      protected void CONFIRM_1C0( )
      {
         BeforeValidate1C49( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls1C49( ) ;
            }
            else
            {
               CheckExtendedTable1C49( ) ;
               if ( AnyError == 0 )
               {
                  ZM1C49( 3) ;
                  ZM1C49( 4) ;
               }
               CloseExtendedTableCursors1C49( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void ZM1C49( short GX_JID )
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
            Z358InstituteCode = A358InstituteCode;
            Z359UserID = (Guid)(A359UserID);
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load1C49( )
      {
         /* Using cursor BC001C6 */
         pr_datastore1.execute(4, new Object[] {A358InstituteCode, A359UserID});
         if ( (pr_datastore1.getStatus(4) != 101) )
         {
            RcdFound49 = 1;
            ZM1C49( -2) ;
         }
         pr_datastore1.close(4);
         OnLoadActions1C49( ) ;
      }

      protected void OnLoadActions1C49( )
      {
      }

      protected void CheckExtendedTable1C49( )
      {
         standaloneModal( ) ;
         /* Using cursor BC001C4 */
         pr_datastore1.execute(2, new Object[] {A358InstituteCode});
         if ( (pr_datastore1.getStatus(2) == 101) )
         {
            GX_msglist.addItem("≤ª∆•≈‰'BAS_Institute'", "ForeignKeyNotFound", 1, "INSTITUTECODE");
            AnyError = 1;
         }
         pr_datastore1.close(2);
         /* Using cursor BC001C5 */
         pr_datastore1.execute(3, new Object[] {A359UserID});
         if ( (pr_datastore1.getStatus(3) == 101) )
         {
            GX_msglist.addItem("≤ª∆•≈‰'SYS_User'", "ForeignKeyNotFound", 1, "USERID");
            AnyError = 1;
         }
         pr_datastore1.close(3);
      }

      protected void CloseExtendedTableCursors1C49( )
      {
         pr_datastore1.close(2);
         pr_datastore1.close(3);
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey1C49( )
      {
         /* Using cursor BC001C7 */
         pr_datastore1.execute(5, new Object[] {A358InstituteCode, A359UserID});
         if ( (pr_datastore1.getStatus(5) != 101) )
         {
            RcdFound49 = 1;
         }
         else
         {
            RcdFound49 = 0;
         }
         pr_datastore1.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC001C3 */
         pr_datastore1.execute(1, new Object[] {A358InstituteCode, A359UserID});
         if ( (pr_datastore1.getStatus(1) != 101) )
         {
            ZM1C49( 2) ;
            RcdFound49 = 1;
            A358InstituteCode = BC001C3_A358InstituteCode[0];
            A359UserID = (Guid)((Guid)(BC001C3_A359UserID[0]));
            Z358InstituteCode = A358InstituteCode;
            Z359UserID = (Guid)(A359UserID);
            sMode49 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load1C49( ) ;
            if ( AnyError == 1 )
            {
               RcdFound49 = 0;
               InitializeNonKey1C49( ) ;
            }
            Gx_mode = sMode49;
         }
         else
         {
            RcdFound49 = 0;
            InitializeNonKey1C49( ) ;
            sMode49 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode49;
         }
         pr_datastore1.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1C49( ) ;
         if ( RcdFound49 == 0 )
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
         CONFIRM_1C0( ) ;
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

      protected void CheckOptimisticConcurrency1C49( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC001C2 */
            pr_datastore1.execute(0, new Object[] {A358InstituteCode, A359UserID});
            if ( (pr_datastore1.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SYS_INSTITUTEUSER"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_datastore1.getStatus(0) == 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"SYS_INSTITUTEUSER"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert1C49( )
      {
         BeforeValidate1C49( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1C49( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1C49( 0) ;
            CheckOptimisticConcurrency1C49( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1C49( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1C49( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC001C8 */
                     pr_datastore1.execute(6, new Object[] {A358InstituteCode, A359UserID});
                     pr_datastore1.close(6);
                     dsDataStore1.SmartCacheProvider.SetUpdated("SYS_INSTITUTEUSER") ;
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
               Load1C49( ) ;
            }
            EndLevel1C49( ) ;
         }
         CloseExtendedTableCursors1C49( ) ;
      }

      protected void Update1C49( )
      {
         BeforeValidate1C49( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1C49( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1C49( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1C49( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1C49( ) ;
                  if ( AnyError == 0 )
                  {
                     /* No attributes to update on table dbo.[SYS_InstituteUser] */
                     DeferredUpdate1C49( ) ;
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
            EndLevel1C49( ) ;
         }
         CloseExtendedTableCursors1C49( ) ;
      }

      protected void DeferredUpdate1C49( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate1C49( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1C49( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1C49( ) ;
            AfterConfirm1C49( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1C49( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC001C9 */
                  pr_datastore1.execute(7, new Object[] {A358InstituteCode, A359UserID});
                  pr_datastore1.close(7);
                  dsDataStore1.SmartCacheProvider.SetUpdated("SYS_INSTITUTEUSER") ;
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
         sMode49 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel1C49( ) ;
         Gx_mode = sMode49;
      }

      protected void OnDeleteControls1C49( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel1C49( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_datastore1.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1C49( ) ;
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

      public void ScanKeyStart1C49( )
      {
         /* Using cursor BC001C10 */
         pr_datastore1.execute(8, new Object[] {A358InstituteCode, A359UserID});
         RcdFound49 = 0;
         if ( (pr_datastore1.getStatus(8) != 101) )
         {
            RcdFound49 = 1;
            A358InstituteCode = BC001C10_A358InstituteCode[0];
            A359UserID = (Guid)((Guid)(BC001C10_A359UserID[0]));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext1C49( )
      {
         /* Scan next routine */
         pr_datastore1.readNext(8);
         RcdFound49 = 0;
         ScanKeyLoad1C49( ) ;
      }

      protected void ScanKeyLoad1C49( )
      {
         sMode49 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_datastore1.getStatus(8) != 101) )
         {
            RcdFound49 = 1;
            A358InstituteCode = BC001C10_A358InstituteCode[0];
            A359UserID = (Guid)((Guid)(BC001C10_A359UserID[0]));
         }
         Gx_mode = sMode49;
      }

      protected void ScanKeyEnd1C49( )
      {
         pr_datastore1.close(8);
      }

      protected void AfterConfirm1C49( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1C49( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1C49( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1C49( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1C49( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1C49( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1C49( )
      {
      }

      protected void send_integrity_lvl_hashes1C49( )
      {
      }

      protected void AddRow1C49( )
      {
         VarsToRow49( bcSYS_InstituteUser) ;
      }

      protected void ReadRow1C49( )
      {
         RowToVars49( bcSYS_InstituteUser, 1) ;
      }

      protected void InitializeNonKey1C49( )
      {
      }

      protected void InitAll1C49( )
      {
         A358InstituteCode = "";
         A359UserID = (Guid)(Guid.Empty);
         InitializeNonKey1C49( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow49( SdtSYS_InstituteUser obj49 )
      {
         obj49.gxTpr_Mode = Gx_mode;
         obj49.gxTpr_Institutecode = A358InstituteCode;
         obj49.gxTpr_Userid = (Guid)(A359UserID);
         obj49.gxTpr_Institutecode_Z = Z358InstituteCode;
         obj49.gxTpr_Userid_Z = (Guid)(Z359UserID);
         obj49.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow49( SdtSYS_InstituteUser obj49 )
      {
         obj49.gxTpr_Institutecode = A358InstituteCode;
         obj49.gxTpr_Userid = (Guid)(A359UserID);
         return  ;
      }

      public void RowToVars49( SdtSYS_InstituteUser obj49 ,
                               int forceLoad )
      {
         Gx_mode = obj49.gxTpr_Mode;
         A358InstituteCode = obj49.gxTpr_Institutecode;
         A359UserID = (Guid)(obj49.gxTpr_Userid);
         Z358InstituteCode = obj49.gxTpr_Institutecode_Z;
         Z359UserID = (Guid)(obj49.gxTpr_Userid_Z);
         Gx_mode = obj49.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A358InstituteCode = (String)getParm(obj,0);
         A359UserID = (Guid)((Guid)getParm(obj,1));
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey1C49( ) ;
         ScanKeyStart1C49( ) ;
         if ( RcdFound49 == 0 )
         {
            Gx_mode = "INS";
            /* Using cursor BC001C11 */
            pr_datastore1.execute(9, new Object[] {A358InstituteCode});
            if ( (pr_datastore1.getStatus(9) == 101) )
            {
               GX_msglist.addItem("≤ª∆•≈‰'BAS_Institute'", "ForeignKeyNotFound", 1, "INSTITUTECODE");
               AnyError = 1;
            }
            pr_datastore1.close(9);
            /* Using cursor BC001C12 */
            pr_datastore1.execute(10, new Object[] {A359UserID});
            if ( (pr_datastore1.getStatus(10) == 101) )
            {
               GX_msglist.addItem("≤ª∆•≈‰'SYS_User'", "ForeignKeyNotFound", 1, "USERID");
               AnyError = 1;
            }
            pr_datastore1.close(10);
         }
         else
         {
            Gx_mode = "UPD";
            Z358InstituteCode = A358InstituteCode;
            Z359UserID = (Guid)(A359UserID);
         }
         ZM1C49( -2) ;
         OnLoadActions1C49( ) ;
         AddRow1C49( ) ;
         ScanKeyEnd1C49( ) ;
         if ( RcdFound49 == 0 )
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
         RowToVars49( bcSYS_InstituteUser, 0) ;
         ScanKeyStart1C49( ) ;
         if ( RcdFound49 == 0 )
         {
            Gx_mode = "INS";
            /* Using cursor BC001C11 */
            pr_datastore1.execute(9, new Object[] {A358InstituteCode});
            if ( (pr_datastore1.getStatus(9) == 101) )
            {
               GX_msglist.addItem("≤ª∆•≈‰'BAS_Institute'", "ForeignKeyNotFound", 1, "INSTITUTECODE");
               AnyError = 1;
            }
            pr_datastore1.close(9);
            /* Using cursor BC001C12 */
            pr_datastore1.execute(10, new Object[] {A359UserID});
            if ( (pr_datastore1.getStatus(10) == 101) )
            {
               GX_msglist.addItem("≤ª∆•≈‰'SYS_User'", "ForeignKeyNotFound", 1, "USERID");
               AnyError = 1;
            }
            pr_datastore1.close(10);
         }
         else
         {
            Gx_mode = "UPD";
            Z358InstituteCode = A358InstituteCode;
            Z359UserID = (Guid)(A359UserID);
         }
         ZM1C49( -2) ;
         OnLoadActions1C49( ) ;
         AddRow1C49( ) ;
         ScanKeyEnd1C49( ) ;
         if ( RcdFound49 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey1C49( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert1C49( ) ;
         }
         else
         {
            if ( RcdFound49 == 1 )
            {
               if ( ( StringUtil.StrCmp(A358InstituteCode, Z358InstituteCode) != 0 ) || ( A359UserID != Z359UserID ) )
               {
                  A358InstituteCode = Z358InstituteCode;
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
                  Update1C49( ) ;
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
                  if ( ( StringUtil.StrCmp(A358InstituteCode, Z358InstituteCode) != 0 ) || ( A359UserID != Z359UserID ) )
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
                        Insert1C49( ) ;
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
                        Insert1C49( ) ;
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
         RowToVars49( bcSYS_InstituteUser, 0) ;
         SaveImpl( ) ;
         VarsToRow49( bcSYS_InstituteUser) ;
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
         RowToVars49( bcSYS_InstituteUser, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert1C49( ) ;
         AfterTrn( ) ;
         VarsToRow49( bcSYS_InstituteUser) ;
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
            SdtSYS_InstituteUser auxBC = new SdtSYS_InstituteUser(context) ;
            auxBC.Load(A358InstituteCode, A359UserID);
            auxBC.UpdateDirties(bcSYS_InstituteUser);
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
         RowToVars49( bcSYS_InstituteUser, 0) ;
         UpdateImpl( ) ;
         VarsToRow49( bcSYS_InstituteUser) ;
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
         RowToVars49( bcSYS_InstituteUser, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert1C49( ) ;
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
         VarsToRow49( bcSYS_InstituteUser) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars49( bcSYS_InstituteUser, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey1C49( ) ;
         if ( RcdFound49 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( ( StringUtil.StrCmp(A358InstituteCode, Z358InstituteCode) != 0 ) || ( A359UserID != Z359UserID ) )
            {
               A358InstituteCode = Z358InstituteCode;
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
            if ( ( StringUtil.StrCmp(A358InstituteCode, Z358InstituteCode) != 0 ) || ( A359UserID != Z359UserID ) )
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
         context.RollbackDataStores("sys_instituteuser_bc",pr_default);
         VarsToRow49( bcSYS_InstituteUser) ;
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
         Gx_mode = bcSYS_InstituteUser.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcSYS_InstituteUser.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcSYS_InstituteUser )
         {
            bcSYS_InstituteUser = (SdtSYS_InstituteUser)(sdt);
            if ( StringUtil.StrCmp(bcSYS_InstituteUser.gxTpr_Mode, "") == 0 )
            {
               bcSYS_InstituteUser.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow49( bcSYS_InstituteUser) ;
            }
            else
            {
               RowToVars49( bcSYS_InstituteUser, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcSYS_InstituteUser.gxTpr_Mode, "") == 0 )
            {
               bcSYS_InstituteUser.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars49( bcSYS_InstituteUser, 1) ;
         return  ;
      }

      public SdtSYS_InstituteUser SYS_InstituteUser_BC
      {
         get {
            return bcSYS_InstituteUser ;
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
         Z358InstituteCode = "";
         A358InstituteCode = "";
         Z359UserID = (Guid)(Guid.Empty);
         A359UserID = (Guid)(Guid.Empty);
         BC001C6_A358InstituteCode = new String[] {""} ;
         BC001C6_A359UserID = new Guid[] {Guid.Empty} ;
         BC001C4_A358InstituteCode = new String[] {""} ;
         BC001C5_A359UserID = new Guid[] {Guid.Empty} ;
         BC001C7_A358InstituteCode = new String[] {""} ;
         BC001C7_A359UserID = new Guid[] {Guid.Empty} ;
         BC001C3_A358InstituteCode = new String[] {""} ;
         BC001C3_A359UserID = new Guid[] {Guid.Empty} ;
         sMode49 = "";
         BC001C2_A358InstituteCode = new String[] {""} ;
         BC001C2_A359UserID = new Guid[] {Guid.Empty} ;
         BC001C10_A358InstituteCode = new String[] {""} ;
         BC001C10_A359UserID = new Guid[] {Guid.Empty} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         BC001C11_A358InstituteCode = new String[] {""} ;
         BC001C12_A359UserID = new Guid[] {Guid.Empty} ;
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.sys_instituteuser_bc__datastore1(),
            new Object[][] {
                new Object[] {
               BC001C2_A358InstituteCode, BC001C2_A359UserID
               }
               , new Object[] {
               BC001C3_A358InstituteCode, BC001C3_A359UserID
               }
               , new Object[] {
               BC001C4_A358InstituteCode
               }
               , new Object[] {
               BC001C5_A359UserID
               }
               , new Object[] {
               BC001C6_A358InstituteCode, BC001C6_A359UserID
               }
               , new Object[] {
               BC001C7_A358InstituteCode, BC001C7_A359UserID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC001C10_A358InstituteCode, BC001C10_A359UserID
               }
               , new Object[] {
               BC001C11_A358InstituteCode
               }
               , new Object[] {
               BC001C12_A359UserID
               }
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.sys_instituteuser_bc__default(),
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
      private short RcdFound49 ;
      private int trnEnded ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String sMode49 ;
      private String Z358InstituteCode ;
      private String A358InstituteCode ;
      private Guid Z359UserID ;
      private Guid A359UserID ;
      private SdtSYS_InstituteUser bcSYS_InstituteUser ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_datastore1 ;
      private String[] BC001C6_A358InstituteCode ;
      private Guid[] BC001C6_A359UserID ;
      private String[] BC001C4_A358InstituteCode ;
      private Guid[] BC001C5_A359UserID ;
      private String[] BC001C7_A358InstituteCode ;
      private Guid[] BC001C7_A359UserID ;
      private String[] BC001C3_A358InstituteCode ;
      private Guid[] BC001C3_A359UserID ;
      private String[] BC001C2_A358InstituteCode ;
      private Guid[] BC001C2_A359UserID ;
      private String[] BC001C10_A358InstituteCode ;
      private Guid[] BC001C10_A359UserID ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private String[] BC001C11_A358InstituteCode ;
      private Guid[] BC001C12_A359UserID ;
      private IDataStoreProvider pr_default ;
   }

   public class sys_instituteuser_bc__datastore1 : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmBC001C6 ;
          prmBC001C6 = new Object[] {
          new Object[] {"@InstituteCode",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC001C4 ;
          prmBC001C4 = new Object[] {
          new Object[] {"@InstituteCode",SqlDbType.NVarChar,20,0}
          } ;
          Object[] prmBC001C5 ;
          prmBC001C5 = new Object[] {
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC001C7 ;
          prmBC001C7 = new Object[] {
          new Object[] {"@InstituteCode",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC001C3 ;
          prmBC001C3 = new Object[] {
          new Object[] {"@InstituteCode",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC001C2 ;
          prmBC001C2 = new Object[] {
          new Object[] {"@InstituteCode",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC001C8 ;
          prmBC001C8 = new Object[] {
          new Object[] {"@InstituteCode",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC001C9 ;
          prmBC001C9 = new Object[] {
          new Object[] {"@InstituteCode",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC001C10 ;
          prmBC001C10 = new Object[] {
          new Object[] {"@InstituteCode",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC001C11 ;
          prmBC001C11 = new Object[] {
          new Object[] {"@InstituteCode",SqlDbType.NVarChar,20,0}
          } ;
          Object[] prmBC001C12 ;
          prmBC001C12 = new Object[] {
          new Object[] {"@UserID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("BC001C2", "SELECT [InstituteCode], [UserID] FROM dbo.[SYS_InstituteUser] WITH (UPDLOCK) WHERE [InstituteCode] = @InstituteCode AND [UserID] = @UserID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001C2,1,0,true,false )
             ,new CursorDef("BC001C3", "SELECT [InstituteCode], [UserID] FROM dbo.[SYS_InstituteUser] WITH (NOLOCK) WHERE [InstituteCode] = @InstituteCode AND [UserID] = @UserID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001C3,1,0,true,false )
             ,new CursorDef("BC001C4", "SELECT [InstituteCode] FROM dbo.[BAS_Institute] WITH (NOLOCK) WHERE [InstituteCode] = @InstituteCode ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001C4,1,0,true,false )
             ,new CursorDef("BC001C5", "SELECT [UserID] FROM dbo.[SYS_User] WITH (NOLOCK) WHERE [UserID] = @UserID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001C5,1,0,true,false )
             ,new CursorDef("BC001C6", "SELECT TM1.[InstituteCode], TM1.[UserID] FROM dbo.[SYS_InstituteUser] TM1 WITH (NOLOCK) WHERE TM1.[InstituteCode] = @InstituteCode and TM1.[UserID] = @UserID ORDER BY TM1.[InstituteCode], TM1.[UserID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001C6,100,0,true,false )
             ,new CursorDef("BC001C7", "SELECT [InstituteCode], [UserID] FROM dbo.[SYS_InstituteUser] WITH (NOLOCK) WHERE [InstituteCode] = @InstituteCode AND [UserID] = @UserID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001C7,1,0,true,false )
             ,new CursorDef("BC001C8", "INSERT INTO dbo.[SYS_InstituteUser]([InstituteCode], [UserID]) VALUES(@InstituteCode, @UserID)", GxErrorMask.GX_NOMASK,prmBC001C8)
             ,new CursorDef("BC001C9", "DELETE FROM dbo.[SYS_InstituteUser]  WHERE [InstituteCode] = @InstituteCode AND [UserID] = @UserID", GxErrorMask.GX_NOMASK,prmBC001C9)
             ,new CursorDef("BC001C10", "SELECT TM1.[InstituteCode], TM1.[UserID] FROM dbo.[SYS_InstituteUser] TM1 WITH (NOLOCK) WHERE TM1.[InstituteCode] = @InstituteCode and TM1.[UserID] = @UserID ORDER BY TM1.[InstituteCode], TM1.[UserID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001C10,100,0,true,false )
             ,new CursorDef("BC001C11", "SELECT [InstituteCode] FROM dbo.[BAS_Institute] WITH (NOLOCK) WHERE [InstituteCode] = @InstituteCode ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001C11,1,0,true,false )
             ,new CursorDef("BC001C12", "SELECT [UserID] FROM dbo.[SYS_User] WITH (NOLOCK) WHERE [UserID] = @UserID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001C12,1,0,true,false )
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

 public class sys_instituteuser_bc__default : DataStoreHelperBase, IDataStoreHelper
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
