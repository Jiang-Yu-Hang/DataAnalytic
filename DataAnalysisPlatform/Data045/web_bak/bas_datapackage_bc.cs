/*
               File: BAS_DataPackage_BC
        Description: BAS_Data Package
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:38:59.88
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
   public class bas_datapackage_bc : GXHttpHandler, IGxSilentTrn
   {
      public bas_datapackage_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public bas_datapackage_bc( IGxContext context )
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
         ReadRow1I55( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey1I55( ) ;
         standaloneModal( ) ;
         AddRow1I55( ) ;
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
               Z366DataPackage = A366DataPackage;
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

      protected void CONFIRM_1I0( )
      {
         BeforeValidate1I55( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls1I55( ) ;
            }
            else
            {
               CheckExtendedTable1I55( ) ;
               if ( AnyError == 0 )
               {
               }
               CloseExtendedTableCursors1I55( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void ZM1I55( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
         }
         if ( GX_JID == -1 )
         {
            Z366DataPackage = A366DataPackage;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load1I55( )
      {
         /* Using cursor BC001I4 */
         pr_datastore1.execute(2, new Object[] {A366DataPackage});
         if ( (pr_datastore1.getStatus(2) != 101) )
         {
            RcdFound55 = 1;
            ZM1I55( -1) ;
         }
         pr_datastore1.close(2);
         OnLoadActions1I55( ) ;
      }

      protected void OnLoadActions1I55( )
      {
      }

      protected void CheckExtendedTable1I55( )
      {
         standaloneModal( ) ;
      }

      protected void CloseExtendedTableCursors1I55( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey1I55( )
      {
         /* Using cursor BC001I5 */
         pr_datastore1.execute(3, new Object[] {A366DataPackage});
         if ( (pr_datastore1.getStatus(3) != 101) )
         {
            RcdFound55 = 1;
         }
         else
         {
            RcdFound55 = 0;
         }
         pr_datastore1.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC001I3 */
         pr_datastore1.execute(1, new Object[] {A366DataPackage});
         if ( (pr_datastore1.getStatus(1) != 101) )
         {
            ZM1I55( 1) ;
            RcdFound55 = 1;
            A366DataPackage = BC001I3_A366DataPackage[0];
            Z366DataPackage = A366DataPackage;
            sMode55 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load1I55( ) ;
            if ( AnyError == 1 )
            {
               RcdFound55 = 0;
               InitializeNonKey1I55( ) ;
            }
            Gx_mode = sMode55;
         }
         else
         {
            RcdFound55 = 0;
            InitializeNonKey1I55( ) ;
            sMode55 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode55;
         }
         pr_datastore1.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1I55( ) ;
         if ( RcdFound55 == 0 )
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
         CONFIRM_1I0( ) ;
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

      protected void CheckOptimisticConcurrency1I55( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC001I2 */
            pr_datastore1.execute(0, new Object[] {A366DataPackage});
            if ( (pr_datastore1.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BAS_DATAPACKAGE"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_datastore1.getStatus(0) == 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"BAS_DATAPACKAGE"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert1I55( )
      {
         BeforeValidate1I55( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1I55( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1I55( 0) ;
            CheckOptimisticConcurrency1I55( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1I55( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1I55( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC001I6 */
                     pr_datastore1.execute(4, new Object[] {A366DataPackage});
                     pr_datastore1.close(4);
                     dsDataStore1.SmartCacheProvider.SetUpdated("BAS_DATAPACKAGE") ;
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
               Load1I55( ) ;
            }
            EndLevel1I55( ) ;
         }
         CloseExtendedTableCursors1I55( ) ;
      }

      protected void Update1I55( )
      {
         BeforeValidate1I55( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1I55( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1I55( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1I55( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1I55( ) ;
                  if ( AnyError == 0 )
                  {
                     /* No attributes to update on table dbo.[BAS_DataPackage] */
                     DeferredUpdate1I55( ) ;
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
            EndLevel1I55( ) ;
         }
         CloseExtendedTableCursors1I55( ) ;
      }

      protected void DeferredUpdate1I55( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate1I55( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1I55( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1I55( ) ;
            AfterConfirm1I55( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1I55( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC001I7 */
                  pr_datastore1.execute(5, new Object[] {A366DataPackage});
                  pr_datastore1.close(5);
                  dsDataStore1.SmartCacheProvider.SetUpdated("BAS_DATAPACKAGE") ;
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
         sMode55 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel1I55( ) ;
         Gx_mode = sMode55;
      }

      protected void OnDeleteControls1I55( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor BC001I8 */
            pr_default.execute(0, new Object[] {A366DataPackage});
            if ( (pr_default.getStatus(0) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {" T63"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(0);
         }
      }

      protected void EndLevel1I55( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_datastore1.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1I55( ) ;
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

      public void ScanKeyStart1I55( )
      {
         /* Using cursor BC001I9 */
         pr_datastore1.execute(6, new Object[] {A366DataPackage});
         RcdFound55 = 0;
         if ( (pr_datastore1.getStatus(6) != 101) )
         {
            RcdFound55 = 1;
            A366DataPackage = BC001I9_A366DataPackage[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext1I55( )
      {
         /* Scan next routine */
         pr_datastore1.readNext(6);
         RcdFound55 = 0;
         ScanKeyLoad1I55( ) ;
      }

      protected void ScanKeyLoad1I55( )
      {
         sMode55 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_datastore1.getStatus(6) != 101) )
         {
            RcdFound55 = 1;
            A366DataPackage = BC001I9_A366DataPackage[0];
         }
         Gx_mode = sMode55;
      }

      protected void ScanKeyEnd1I55( )
      {
         pr_datastore1.close(6);
      }

      protected void AfterConfirm1I55( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1I55( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1I55( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1I55( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1I55( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1I55( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1I55( )
      {
      }

      protected void send_integrity_lvl_hashes1I55( )
      {
      }

      protected void AddRow1I55( )
      {
         VarsToRow55( bcBAS_DataPackage) ;
      }

      protected void ReadRow1I55( )
      {
         RowToVars55( bcBAS_DataPackage, 1) ;
      }

      protected void InitializeNonKey1I55( )
      {
      }

      protected void InitAll1I55( )
      {
         A366DataPackage = "";
         InitializeNonKey1I55( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow55( SdtBAS_DataPackage obj55 )
      {
         obj55.gxTpr_Mode = Gx_mode;
         obj55.gxTpr_Datapackage = A366DataPackage;
         obj55.gxTpr_Datapackage_Z = Z366DataPackage;
         obj55.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow55( SdtBAS_DataPackage obj55 )
      {
         obj55.gxTpr_Datapackage = A366DataPackage;
         return  ;
      }

      public void RowToVars55( SdtBAS_DataPackage obj55 ,
                               int forceLoad )
      {
         Gx_mode = obj55.gxTpr_Mode;
         A366DataPackage = obj55.gxTpr_Datapackage;
         Z366DataPackage = obj55.gxTpr_Datapackage_Z;
         Gx_mode = obj55.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A366DataPackage = (String)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey1I55( ) ;
         ScanKeyStart1I55( ) ;
         if ( RcdFound55 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z366DataPackage = A366DataPackage;
         }
         ZM1I55( -1) ;
         OnLoadActions1I55( ) ;
         AddRow1I55( ) ;
         ScanKeyEnd1I55( ) ;
         if ( RcdFound55 == 0 )
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
         RowToVars55( bcBAS_DataPackage, 0) ;
         ScanKeyStart1I55( ) ;
         if ( RcdFound55 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z366DataPackage = A366DataPackage;
         }
         ZM1I55( -1) ;
         OnLoadActions1I55( ) ;
         AddRow1I55( ) ;
         ScanKeyEnd1I55( ) ;
         if ( RcdFound55 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey1I55( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert1I55( ) ;
         }
         else
         {
            if ( RcdFound55 == 1 )
            {
               if ( StringUtil.StrCmp(A366DataPackage, Z366DataPackage) != 0 )
               {
                  A366DataPackage = Z366DataPackage;
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
                  Update1I55( ) ;
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
                  if ( StringUtil.StrCmp(A366DataPackage, Z366DataPackage) != 0 )
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
                        Insert1I55( ) ;
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
                        Insert1I55( ) ;
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
         RowToVars55( bcBAS_DataPackage, 0) ;
         SaveImpl( ) ;
         VarsToRow55( bcBAS_DataPackage) ;
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
         RowToVars55( bcBAS_DataPackage, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert1I55( ) ;
         AfterTrn( ) ;
         VarsToRow55( bcBAS_DataPackage) ;
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
            SdtBAS_DataPackage auxBC = new SdtBAS_DataPackage(context) ;
            auxBC.Load(A366DataPackage);
            auxBC.UpdateDirties(bcBAS_DataPackage);
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
         RowToVars55( bcBAS_DataPackage, 0) ;
         UpdateImpl( ) ;
         VarsToRow55( bcBAS_DataPackage) ;
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
         RowToVars55( bcBAS_DataPackage, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert1I55( ) ;
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
         VarsToRow55( bcBAS_DataPackage) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars55( bcBAS_DataPackage, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey1I55( ) ;
         if ( RcdFound55 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( StringUtil.StrCmp(A366DataPackage, Z366DataPackage) != 0 )
            {
               A366DataPackage = Z366DataPackage;
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
            if ( StringUtil.StrCmp(A366DataPackage, Z366DataPackage) != 0 )
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
         context.RollbackDataStores("bas_datapackage_bc",pr_default);
         VarsToRow55( bcBAS_DataPackage) ;
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
         Gx_mode = bcBAS_DataPackage.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcBAS_DataPackage.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcBAS_DataPackage )
         {
            bcBAS_DataPackage = (SdtBAS_DataPackage)(sdt);
            if ( StringUtil.StrCmp(bcBAS_DataPackage.gxTpr_Mode, "") == 0 )
            {
               bcBAS_DataPackage.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow55( bcBAS_DataPackage) ;
            }
            else
            {
               RowToVars55( bcBAS_DataPackage, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcBAS_DataPackage.gxTpr_Mode, "") == 0 )
            {
               bcBAS_DataPackage.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars55( bcBAS_DataPackage, 1) ;
         return  ;
      }

      public SdtBAS_DataPackage BAS_DataPackage_BC
      {
         get {
            return bcBAS_DataPackage ;
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
         Z366DataPackage = "";
         A366DataPackage = "";
         BC001I4_A366DataPackage = new String[] {""} ;
         BC001I5_A366DataPackage = new String[] {""} ;
         BC001I3_A366DataPackage = new String[] {""} ;
         sMode55 = "";
         BC001I2_A366DataPackage = new String[] {""} ;
         BC001I8_A85BR_Information_ID = new long[1] ;
         BC001I8_A366DataPackage = new String[] {""} ;
         BC001I9_A366DataPackage = new String[] {""} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.bas_datapackage_bc__datastore1(),
            new Object[][] {
                new Object[] {
               BC001I2_A366DataPackage
               }
               , new Object[] {
               BC001I3_A366DataPackage
               }
               , new Object[] {
               BC001I4_A366DataPackage
               }
               , new Object[] {
               BC001I5_A366DataPackage
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC001I9_A366DataPackage
               }
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.bas_datapackage_bc__default(),
            new Object[][] {
                new Object[] {
               BC001I8_A85BR_Information_ID, BC001I8_A366DataPackage
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
      private short RcdFound55 ;
      private int trnEnded ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String sMode55 ;
      private String Z366DataPackage ;
      private String A366DataPackage ;
      private SdtBAS_DataPackage bcBAS_DataPackage ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_datastore1 ;
      private String[] BC001I4_A366DataPackage ;
      private String[] BC001I5_A366DataPackage ;
      private String[] BC001I3_A366DataPackage ;
      private String[] BC001I2_A366DataPackage ;
      private IDataStoreProvider pr_default ;
      private long[] BC001I8_A85BR_Information_ID ;
      private String[] BC001I8_A366DataPackage ;
      private String[] BC001I9_A366DataPackage ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
   }

   public class bas_datapackage_bc__datastore1 : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmBC001I4 ;
          prmBC001I4 = new Object[] {
          new Object[] {"@DataPackage",SqlDbType.NVarChar,50,0}
          } ;
          Object[] prmBC001I5 ;
          prmBC001I5 = new Object[] {
          new Object[] {"@DataPackage",SqlDbType.NVarChar,50,0}
          } ;
          Object[] prmBC001I3 ;
          prmBC001I3 = new Object[] {
          new Object[] {"@DataPackage",SqlDbType.NVarChar,50,0}
          } ;
          Object[] prmBC001I2 ;
          prmBC001I2 = new Object[] {
          new Object[] {"@DataPackage",SqlDbType.NVarChar,50,0}
          } ;
          Object[] prmBC001I6 ;
          prmBC001I6 = new Object[] {
          new Object[] {"@DataPackage",SqlDbType.NVarChar,50,0}
          } ;
          Object[] prmBC001I7 ;
          prmBC001I7 = new Object[] {
          new Object[] {"@DataPackage",SqlDbType.NVarChar,50,0}
          } ;
          Object[] prmBC001I9 ;
          prmBC001I9 = new Object[] {
          new Object[] {"@DataPackage",SqlDbType.NVarChar,50,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("BC001I2", "SELECT [DataPackage] FROM dbo.[BAS_DataPackage] WITH (UPDLOCK) WHERE [DataPackage] = @DataPackage ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001I2,1,0,true,false )
             ,new CursorDef("BC001I3", "SELECT [DataPackage] FROM dbo.[BAS_DataPackage] WITH (NOLOCK) WHERE [DataPackage] = @DataPackage ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001I3,1,0,true,false )
             ,new CursorDef("BC001I4", "SELECT TM1.[DataPackage] FROM dbo.[BAS_DataPackage] TM1 WITH (NOLOCK) WHERE TM1.[DataPackage] = @DataPackage ORDER BY TM1.[DataPackage]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001I4,100,0,true,false )
             ,new CursorDef("BC001I5", "SELECT [DataPackage] FROM dbo.[BAS_DataPackage] WITH (NOLOCK) WHERE [DataPackage] = @DataPackage  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001I5,1,0,true,false )
             ,new CursorDef("BC001I6", "INSERT INTO dbo.[BAS_DataPackage]([DataPackage]) VALUES(@DataPackage)", GxErrorMask.GX_NOMASK,prmBC001I6)
             ,new CursorDef("BC001I7", "DELETE FROM dbo.[BAS_DataPackage]  WHERE [DataPackage] = @DataPackage", GxErrorMask.GX_NOMASK,prmBC001I7)
             ,new CursorDef("BC001I9", "SELECT TM1.[DataPackage] FROM dbo.[BAS_DataPackage] TM1 WITH (NOLOCK) WHERE TM1.[DataPackage] = @DataPackage ORDER BY TM1.[DataPackage]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001I9,100,0,true,false )
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
                return;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                return;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                return;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                return;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
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
                return;
             case 5 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
             case 6 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
       }
    }

    public String getDataStoreName( )
    {
       return "DATASTORE1";
    }

 }

 public class bas_datapackage_bc__default : DataStoreHelperBase, IDataStoreHelper
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
        Object[] prmBC001I8 ;
        prmBC001I8 = new Object[] {
        new Object[] {"@DataPackage",SqlDbType.NVarChar,50,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("BC001I8", "SELECT TOP 1 [BR_Information_ID], [DataPackage] FROM [BR_PatientReEntity] WITH (NOLOCK) WHERE [DataPackage] = @DataPackage ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001I8,1,0,true,true )
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
