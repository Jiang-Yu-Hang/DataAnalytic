/*
               File: SYS_SerialNumber_BC
        Description: SYS_Serial Number
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:8:49.20
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
   public class sys_serialnumber_bc : GXHttpHandler, IGxSilentTrn
   {
      public sys_serialnumber_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public sys_serialnumber_bc( IGxContext context )
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
         ReadRow1744( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey1744( ) ;
         standaloneModal( ) ;
         AddRow1744( ) ;
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
               Z357SerialKey = A357SerialKey;
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

      protected void CONFIRM_170( )
      {
         BeforeValidate1744( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls1744( ) ;
            }
            else
            {
               CheckExtendedTable1744( ) ;
               if ( AnyError == 0 )
               {
               }
               CloseExtendedTableCursors1744( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void ZM1744( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            Z415CurrentValue = A415CurrentValue;
         }
         if ( GX_JID == -1 )
         {
            Z357SerialKey = A357SerialKey;
            Z415CurrentValue = A415CurrentValue;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load1744( )
      {
         /* Using cursor BC00174 */
         pr_datastore1.execute(2, new Object[] {A357SerialKey});
         if ( (pr_datastore1.getStatus(2) != 101) )
         {
            RcdFound44 = 1;
            A415CurrentValue = BC00174_A415CurrentValue[0];
            ZM1744( -1) ;
         }
         pr_datastore1.close(2);
         OnLoadActions1744( ) ;
      }

      protected void OnLoadActions1744( )
      {
      }

      protected void CheckExtendedTable1744( )
      {
         standaloneModal( ) ;
      }

      protected void CloseExtendedTableCursors1744( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey1744( )
      {
         /* Using cursor BC00175 */
         pr_datastore1.execute(3, new Object[] {A357SerialKey});
         if ( (pr_datastore1.getStatus(3) != 101) )
         {
            RcdFound44 = 1;
         }
         else
         {
            RcdFound44 = 0;
         }
         pr_datastore1.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC00173 */
         pr_datastore1.execute(1, new Object[] {A357SerialKey});
         if ( (pr_datastore1.getStatus(1) != 101) )
         {
            ZM1744( 1) ;
            RcdFound44 = 1;
            A357SerialKey = BC00173_A357SerialKey[0];
            A415CurrentValue = BC00173_A415CurrentValue[0];
            Z357SerialKey = A357SerialKey;
            sMode44 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load1744( ) ;
            if ( AnyError == 1 )
            {
               RcdFound44 = 0;
               InitializeNonKey1744( ) ;
            }
            Gx_mode = sMode44;
         }
         else
         {
            RcdFound44 = 0;
            InitializeNonKey1744( ) ;
            sMode44 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode44;
         }
         pr_datastore1.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1744( ) ;
         if ( RcdFound44 == 0 )
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
         CONFIRM_170( ) ;
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

      protected void CheckOptimisticConcurrency1744( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC00172 */
            pr_datastore1.execute(0, new Object[] {A357SerialKey});
            if ( (pr_datastore1.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SYS_SERIALNUMBER"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_datastore1.getStatus(0) == 101) || ( Z415CurrentValue != BC00172_A415CurrentValue[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"SYS_SERIALNUMBER"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert1744( )
      {
         BeforeValidate1744( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1744( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1744( 0) ;
            CheckOptimisticConcurrency1744( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1744( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1744( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00176 */
                     pr_datastore1.execute(4, new Object[] {A357SerialKey, A415CurrentValue});
                     pr_datastore1.close(4);
                     dsDataStore1.SmartCacheProvider.SetUpdated("SYS_SERIALNUMBER") ;
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
               Load1744( ) ;
            }
            EndLevel1744( ) ;
         }
         CloseExtendedTableCursors1744( ) ;
      }

      protected void Update1744( )
      {
         BeforeValidate1744( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1744( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1744( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1744( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1744( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00177 */
                     pr_datastore1.execute(5, new Object[] {A415CurrentValue, A357SerialKey});
                     pr_datastore1.close(5);
                     dsDataStore1.SmartCacheProvider.SetUpdated("SYS_SERIALNUMBER") ;
                     if ( (pr_datastore1.getStatus(5) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SYS_SERIALNUMBER"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate1744( ) ;
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
            EndLevel1744( ) ;
         }
         CloseExtendedTableCursors1744( ) ;
      }

      protected void DeferredUpdate1744( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate1744( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1744( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1744( ) ;
            AfterConfirm1744( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1744( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC00178 */
                  pr_datastore1.execute(6, new Object[] {A357SerialKey});
                  pr_datastore1.close(6);
                  dsDataStore1.SmartCacheProvider.SetUpdated("SYS_SERIALNUMBER") ;
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
         sMode44 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel1744( ) ;
         Gx_mode = sMode44;
      }

      protected void OnDeleteControls1744( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel1744( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_datastore1.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1744( ) ;
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

      public void ScanKeyStart1744( )
      {
         /* Using cursor BC00179 */
         pr_datastore1.execute(7, new Object[] {A357SerialKey});
         RcdFound44 = 0;
         if ( (pr_datastore1.getStatus(7) != 101) )
         {
            RcdFound44 = 1;
            A357SerialKey = BC00179_A357SerialKey[0];
            A415CurrentValue = BC00179_A415CurrentValue[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext1744( )
      {
         /* Scan next routine */
         pr_datastore1.readNext(7);
         RcdFound44 = 0;
         ScanKeyLoad1744( ) ;
      }

      protected void ScanKeyLoad1744( )
      {
         sMode44 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_datastore1.getStatus(7) != 101) )
         {
            RcdFound44 = 1;
            A357SerialKey = BC00179_A357SerialKey[0];
            A415CurrentValue = BC00179_A415CurrentValue[0];
         }
         Gx_mode = sMode44;
      }

      protected void ScanKeyEnd1744( )
      {
         pr_datastore1.close(7);
      }

      protected void AfterConfirm1744( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1744( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1744( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1744( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1744( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1744( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1744( )
      {
      }

      protected void send_integrity_lvl_hashes1744( )
      {
      }

      protected void AddRow1744( )
      {
         VarsToRow44( bcSYS_SerialNumber) ;
      }

      protected void ReadRow1744( )
      {
         RowToVars44( bcSYS_SerialNumber, 1) ;
      }

      protected void InitializeNonKey1744( )
      {
         A415CurrentValue = 0;
         Z415CurrentValue = 0;
      }

      protected void InitAll1744( )
      {
         A357SerialKey = "";
         InitializeNonKey1744( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow44( SdtSYS_SerialNumber obj44 )
      {
         obj44.gxTpr_Mode = Gx_mode;
         obj44.gxTpr_Currentvalue = A415CurrentValue;
         obj44.gxTpr_Serialkey = A357SerialKey;
         obj44.gxTpr_Serialkey_Z = Z357SerialKey;
         obj44.gxTpr_Currentvalue_Z = Z415CurrentValue;
         obj44.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow44( SdtSYS_SerialNumber obj44 )
      {
         obj44.gxTpr_Serialkey = A357SerialKey;
         return  ;
      }

      public void RowToVars44( SdtSYS_SerialNumber obj44 ,
                               int forceLoad )
      {
         Gx_mode = obj44.gxTpr_Mode;
         A415CurrentValue = obj44.gxTpr_Currentvalue;
         A357SerialKey = obj44.gxTpr_Serialkey;
         Z357SerialKey = obj44.gxTpr_Serialkey_Z;
         Z415CurrentValue = obj44.gxTpr_Currentvalue_Z;
         Gx_mode = obj44.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A357SerialKey = (String)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey1744( ) ;
         ScanKeyStart1744( ) ;
         if ( RcdFound44 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z357SerialKey = A357SerialKey;
         }
         ZM1744( -1) ;
         OnLoadActions1744( ) ;
         AddRow1744( ) ;
         ScanKeyEnd1744( ) ;
         if ( RcdFound44 == 0 )
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
         RowToVars44( bcSYS_SerialNumber, 0) ;
         ScanKeyStart1744( ) ;
         if ( RcdFound44 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z357SerialKey = A357SerialKey;
         }
         ZM1744( -1) ;
         OnLoadActions1744( ) ;
         AddRow1744( ) ;
         ScanKeyEnd1744( ) ;
         if ( RcdFound44 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey1744( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert1744( ) ;
         }
         else
         {
            if ( RcdFound44 == 1 )
            {
               if ( StringUtil.StrCmp(A357SerialKey, Z357SerialKey) != 0 )
               {
                  A357SerialKey = Z357SerialKey;
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
                  Update1744( ) ;
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
                  if ( StringUtil.StrCmp(A357SerialKey, Z357SerialKey) != 0 )
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
                        Insert1744( ) ;
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
                        Insert1744( ) ;
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
         RowToVars44( bcSYS_SerialNumber, 0) ;
         SaveImpl( ) ;
         VarsToRow44( bcSYS_SerialNumber) ;
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
         RowToVars44( bcSYS_SerialNumber, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert1744( ) ;
         AfterTrn( ) ;
         VarsToRow44( bcSYS_SerialNumber) ;
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
            SdtSYS_SerialNumber auxBC = new SdtSYS_SerialNumber(context) ;
            auxBC.Load(A357SerialKey);
            auxBC.UpdateDirties(bcSYS_SerialNumber);
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
         RowToVars44( bcSYS_SerialNumber, 0) ;
         UpdateImpl( ) ;
         VarsToRow44( bcSYS_SerialNumber) ;
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
         RowToVars44( bcSYS_SerialNumber, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert1744( ) ;
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
         VarsToRow44( bcSYS_SerialNumber) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars44( bcSYS_SerialNumber, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey1744( ) ;
         if ( RcdFound44 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( StringUtil.StrCmp(A357SerialKey, Z357SerialKey) != 0 )
            {
               A357SerialKey = Z357SerialKey;
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
            if ( StringUtil.StrCmp(A357SerialKey, Z357SerialKey) != 0 )
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
         context.RollbackDataStores("sys_serialnumber_bc",pr_default);
         VarsToRow44( bcSYS_SerialNumber) ;
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
         Gx_mode = bcSYS_SerialNumber.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcSYS_SerialNumber.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcSYS_SerialNumber )
         {
            bcSYS_SerialNumber = (SdtSYS_SerialNumber)(sdt);
            if ( StringUtil.StrCmp(bcSYS_SerialNumber.gxTpr_Mode, "") == 0 )
            {
               bcSYS_SerialNumber.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow44( bcSYS_SerialNumber) ;
            }
            else
            {
               RowToVars44( bcSYS_SerialNumber, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcSYS_SerialNumber.gxTpr_Mode, "") == 0 )
            {
               bcSYS_SerialNumber.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars44( bcSYS_SerialNumber, 1) ;
         return  ;
      }

      public SdtSYS_SerialNumber SYS_SerialNumber_BC
      {
         get {
            return bcSYS_SerialNumber ;
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
         Z357SerialKey = "";
         A357SerialKey = "";
         BC00174_A357SerialKey = new String[] {""} ;
         BC00174_A415CurrentValue = new long[1] ;
         BC00175_A357SerialKey = new String[] {""} ;
         BC00173_A357SerialKey = new String[] {""} ;
         BC00173_A415CurrentValue = new long[1] ;
         sMode44 = "";
         BC00172_A357SerialKey = new String[] {""} ;
         BC00172_A415CurrentValue = new long[1] ;
         BC00179_A357SerialKey = new String[] {""} ;
         BC00179_A415CurrentValue = new long[1] ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.sys_serialnumber_bc__datastore1(),
            new Object[][] {
                new Object[] {
               BC00172_A357SerialKey, BC00172_A415CurrentValue
               }
               , new Object[] {
               BC00173_A357SerialKey, BC00173_A415CurrentValue
               }
               , new Object[] {
               BC00174_A357SerialKey, BC00174_A415CurrentValue
               }
               , new Object[] {
               BC00175_A357SerialKey
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC00179_A357SerialKey, BC00179_A415CurrentValue
               }
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.sys_serialnumber_bc__default(),
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
      private short RcdFound44 ;
      private int trnEnded ;
      private long Z415CurrentValue ;
      private long A415CurrentValue ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String sMode44 ;
      private String Z357SerialKey ;
      private String A357SerialKey ;
      private SdtSYS_SerialNumber bcSYS_SerialNumber ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_datastore1 ;
      private String[] BC00174_A357SerialKey ;
      private long[] BC00174_A415CurrentValue ;
      private String[] BC00175_A357SerialKey ;
      private String[] BC00173_A357SerialKey ;
      private long[] BC00173_A415CurrentValue ;
      private String[] BC00172_A357SerialKey ;
      private long[] BC00172_A415CurrentValue ;
      private String[] BC00179_A357SerialKey ;
      private long[] BC00179_A415CurrentValue ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_default ;
   }

   public class sys_serialnumber_bc__datastore1 : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmBC00174 ;
          prmBC00174 = new Object[] {
          new Object[] {"@SerialKey",SqlDbType.NVarChar,64,0}
          } ;
          Object[] prmBC00175 ;
          prmBC00175 = new Object[] {
          new Object[] {"@SerialKey",SqlDbType.NVarChar,64,0}
          } ;
          Object[] prmBC00173 ;
          prmBC00173 = new Object[] {
          new Object[] {"@SerialKey",SqlDbType.NVarChar,64,0}
          } ;
          Object[] prmBC00172 ;
          prmBC00172 = new Object[] {
          new Object[] {"@SerialKey",SqlDbType.NVarChar,64,0}
          } ;
          Object[] prmBC00176 ;
          prmBC00176 = new Object[] {
          new Object[] {"@SerialKey",SqlDbType.NVarChar,64,0} ,
          new Object[] {"@CurrentValue",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmBC00177 ;
          prmBC00177 = new Object[] {
          new Object[] {"@CurrentValue",SqlDbType.Decimal,18,0} ,
          new Object[] {"@SerialKey",SqlDbType.NVarChar,64,0}
          } ;
          Object[] prmBC00178 ;
          prmBC00178 = new Object[] {
          new Object[] {"@SerialKey",SqlDbType.NVarChar,64,0}
          } ;
          Object[] prmBC00179 ;
          prmBC00179 = new Object[] {
          new Object[] {"@SerialKey",SqlDbType.NVarChar,64,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("BC00172", "SELECT [SerialKey], [CurrentValue] FROM dbo.[SYS_SerialNumber] WITH (UPDLOCK) WHERE [SerialKey] = @SerialKey ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00172,1,0,true,false )
             ,new CursorDef("BC00173", "SELECT [SerialKey], [CurrentValue] FROM dbo.[SYS_SerialNumber] WITH (NOLOCK) WHERE [SerialKey] = @SerialKey ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00173,1,0,true,false )
             ,new CursorDef("BC00174", "SELECT TM1.[SerialKey], TM1.[CurrentValue] FROM dbo.[SYS_SerialNumber] TM1 WITH (NOLOCK) WHERE TM1.[SerialKey] = @SerialKey ORDER BY TM1.[SerialKey]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00174,100,0,true,false )
             ,new CursorDef("BC00175", "SELECT [SerialKey] FROM dbo.[SYS_SerialNumber] WITH (NOLOCK) WHERE [SerialKey] = @SerialKey  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00175,1,0,true,false )
             ,new CursorDef("BC00176", "INSERT INTO dbo.[SYS_SerialNumber]([SerialKey], [CurrentValue]) VALUES(@SerialKey, @CurrentValue)", GxErrorMask.GX_NOMASK,prmBC00176)
             ,new CursorDef("BC00177", "UPDATE dbo.[SYS_SerialNumber] SET [CurrentValue]=@CurrentValue  WHERE [SerialKey] = @SerialKey", GxErrorMask.GX_NOMASK,prmBC00177)
             ,new CursorDef("BC00178", "DELETE FROM dbo.[SYS_SerialNumber]  WHERE [SerialKey] = @SerialKey", GxErrorMask.GX_NOMASK,prmBC00178)
             ,new CursorDef("BC00179", "SELECT TM1.[SerialKey], TM1.[CurrentValue] FROM dbo.[SYS_SerialNumber] TM1 WITH (NOLOCK) WHERE TM1.[SerialKey] = @SerialKey ORDER BY TM1.[SerialKey]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00179,100,0,true,false )
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
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                return;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                return;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                return;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                return;
             case 7 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
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
                stmt.SetParameter(2, (long)parms[1]);
                return;
             case 5 :
                stmt.SetParameter(1, (long)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
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

 public class sys_serialnumber_bc__default : DataStoreHelperBase, IDataStoreHelper
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
