/*
               File: BR_PatientReEntity_BC
        Description: 患者病种关系图
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:39:6.1
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
   public class br_patientreentity_bc : GXHttpHandler, IGxSilentTrn
   {
      public br_patientreentity_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_patientreentity_bc( IGxContext context )
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
         ReadRow1N63( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey1N63( ) ;
         standaloneModal( ) ;
         AddRow1N63( ) ;
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
               Z85BR_Information_ID = A85BR_Information_ID;
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

      protected void CONFIRM_1N0( )
      {
         BeforeValidate1N63( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls1N63( ) ;
            }
            else
            {
               CheckExtendedTable1N63( ) ;
               if ( AnyError == 0 )
               {
                  ZM1N63( 2) ;
                  ZM1N63( 3) ;
               }
               CloseExtendedTableCursors1N63( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void ZM1N63( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
         }
         if ( ( GX_JID == 2 ) || ( GX_JID == 0 ) )
         {
         }
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
         }
         if ( GX_JID == -1 )
         {
            Z85BR_Information_ID = A85BR_Information_ID;
            Z366DataPackage = A366DataPackage;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load1N63( )
      {
         /* Using cursor BC001N6 */
         pr_default.execute(3, new Object[] {A85BR_Information_ID, A366DataPackage});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound63 = 1;
            ZM1N63( -1) ;
         }
         pr_default.close(3);
         OnLoadActions1N63( ) ;
      }

      protected void OnLoadActions1N63( )
      {
      }

      protected void CheckExtendedTable1N63( )
      {
         standaloneModal( ) ;
         /* Using cursor BC001N4 */
         pr_default.execute(2, new Object[] {A85BR_Information_ID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("不匹配' T16'", "ForeignKeyNotFound", 1, "BR_INFORMATION_ID");
            AnyError = 1;
         }
         pr_default.close(2);
         /* Using cursor BC001N5 */
         pr_datastore1.execute(0, new Object[] {A366DataPackage});
         if ( (pr_datastore1.getStatus(0) == 101) )
         {
            GX_msglist.addItem("不匹配'BAS_Data Package'", "ForeignKeyNotFound", 1, "DATAPACKAGE");
            AnyError = 1;
         }
         pr_datastore1.close(0);
      }

      protected void CloseExtendedTableCursors1N63( )
      {
         pr_default.close(2);
         pr_datastore1.close(0);
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey1N63( )
      {
         /* Using cursor BC001N7 */
         pr_default.execute(4, new Object[] {A85BR_Information_ID, A366DataPackage});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound63 = 1;
         }
         else
         {
            RcdFound63 = 0;
         }
         pr_default.close(4);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC001N3 */
         pr_default.execute(1, new Object[] {A85BR_Information_ID, A366DataPackage});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM1N63( 1) ;
            RcdFound63 = 1;
            A85BR_Information_ID = BC001N3_A85BR_Information_ID[0];
            A366DataPackage = BC001N3_A366DataPackage[0];
            Z85BR_Information_ID = A85BR_Information_ID;
            Z366DataPackage = A366DataPackage;
            sMode63 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load1N63( ) ;
            if ( AnyError == 1 )
            {
               RcdFound63 = 0;
               InitializeNonKey1N63( ) ;
            }
            Gx_mode = sMode63;
         }
         else
         {
            RcdFound63 = 0;
            InitializeNonKey1N63( ) ;
            sMode63 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode63;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1N63( ) ;
         if ( RcdFound63 == 0 )
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
         CONFIRM_1N0( ) ;
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

      protected void CheckOptimisticConcurrency1N63( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC001N2 */
            pr_default.execute(0, new Object[] {A85BR_Information_ID, A366DataPackage});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_PatientReEntity"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"BR_PatientReEntity"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert1N63( )
      {
         BeforeValidate1N63( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1N63( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1N63( 0) ;
            CheckOptimisticConcurrency1N63( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1N63( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1N63( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC001N8 */
                     pr_default.execute(5, new Object[] {A85BR_Information_ID, A366DataPackage});
                     pr_default.close(5);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_PatientReEntity") ;
                     if ( (pr_default.getStatus(5) == 1) )
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
               Load1N63( ) ;
            }
            EndLevel1N63( ) ;
         }
         CloseExtendedTableCursors1N63( ) ;
      }

      protected void Update1N63( )
      {
         BeforeValidate1N63( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1N63( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1N63( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1N63( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1N63( ) ;
                  if ( AnyError == 0 )
                  {
                     /* No attributes to update on table [BR_PatientReEntity] */
                     DeferredUpdate1N63( ) ;
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
            EndLevel1N63( ) ;
         }
         CloseExtendedTableCursors1N63( ) ;
      }

      protected void DeferredUpdate1N63( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate1N63( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1N63( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1N63( ) ;
            AfterConfirm1N63( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1N63( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC001N9 */
                  pr_default.execute(6, new Object[] {A85BR_Information_ID, A366DataPackage});
                  pr_default.close(6);
                  dsDefault.SmartCacheProvider.SetUpdated("BR_PatientReEntity") ;
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
         sMode63 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel1N63( ) ;
         Gx_mode = sMode63;
      }

      protected void OnDeleteControls1N63( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel1N63( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1N63( ) ;
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

      public void ScanKeyStart1N63( )
      {
         /* Using cursor BC001N10 */
         pr_default.execute(7, new Object[] {A85BR_Information_ID, A366DataPackage});
         RcdFound63 = 0;
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound63 = 1;
            A85BR_Information_ID = BC001N10_A85BR_Information_ID[0];
            A366DataPackage = BC001N10_A366DataPackage[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext1N63( )
      {
         /* Scan next routine */
         pr_default.readNext(7);
         RcdFound63 = 0;
         ScanKeyLoad1N63( ) ;
      }

      protected void ScanKeyLoad1N63( )
      {
         sMode63 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound63 = 1;
            A85BR_Information_ID = BC001N10_A85BR_Information_ID[0];
            A366DataPackage = BC001N10_A366DataPackage[0];
         }
         Gx_mode = sMode63;
      }

      protected void ScanKeyEnd1N63( )
      {
         pr_default.close(7);
      }

      protected void AfterConfirm1N63( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1N63( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1N63( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1N63( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1N63( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1N63( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1N63( )
      {
      }

      protected void send_integrity_lvl_hashes1N63( )
      {
      }

      protected void AddRow1N63( )
      {
         VarsToRow63( bcBR_PatientReEntity) ;
      }

      protected void ReadRow1N63( )
      {
         RowToVars63( bcBR_PatientReEntity, 1) ;
      }

      protected void InitializeNonKey1N63( )
      {
      }

      protected void InitAll1N63( )
      {
         A85BR_Information_ID = 0;
         A366DataPackage = "";
         InitializeNonKey1N63( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow63( SdtBR_PatientReEntity obj63 )
      {
         obj63.gxTpr_Mode = Gx_mode;
         obj63.gxTpr_Br_information_id = A85BR_Information_ID;
         obj63.gxTpr_Datapackage = A366DataPackage;
         obj63.gxTpr_Br_information_id_Z = Z85BR_Information_ID;
         obj63.gxTpr_Datapackage_Z = Z366DataPackage;
         obj63.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow63( SdtBR_PatientReEntity obj63 )
      {
         obj63.gxTpr_Br_information_id = A85BR_Information_ID;
         obj63.gxTpr_Datapackage = A366DataPackage;
         return  ;
      }

      public void RowToVars63( SdtBR_PatientReEntity obj63 ,
                               int forceLoad )
      {
         Gx_mode = obj63.gxTpr_Mode;
         A85BR_Information_ID = obj63.gxTpr_Br_information_id;
         A366DataPackage = obj63.gxTpr_Datapackage;
         Z85BR_Information_ID = obj63.gxTpr_Br_information_id_Z;
         Z366DataPackage = obj63.gxTpr_Datapackage_Z;
         Gx_mode = obj63.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A85BR_Information_ID = (long)getParm(obj,0);
         A366DataPackage = (String)getParm(obj,1);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey1N63( ) ;
         ScanKeyStart1N63( ) ;
         if ( RcdFound63 == 0 )
         {
            Gx_mode = "INS";
            /* Using cursor BC001N11 */
            pr_default.execute(8, new Object[] {A85BR_Information_ID});
            if ( (pr_default.getStatus(8) == 101) )
            {
               GX_msglist.addItem("不匹配' T16'", "ForeignKeyNotFound", 1, "BR_INFORMATION_ID");
               AnyError = 1;
            }
            pr_default.close(8);
            /* Using cursor BC001N12 */
            pr_datastore1.execute(1, new Object[] {A366DataPackage});
            if ( (pr_datastore1.getStatus(1) == 101) )
            {
               GX_msglist.addItem("不匹配'BAS_Data Package'", "ForeignKeyNotFound", 1, "DATAPACKAGE");
               AnyError = 1;
            }
            pr_datastore1.close(1);
         }
         else
         {
            Gx_mode = "UPD";
            Z85BR_Information_ID = A85BR_Information_ID;
            Z366DataPackage = A366DataPackage;
         }
         ZM1N63( -1) ;
         OnLoadActions1N63( ) ;
         AddRow1N63( ) ;
         ScanKeyEnd1N63( ) ;
         if ( RcdFound63 == 0 )
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
         RowToVars63( bcBR_PatientReEntity, 0) ;
         ScanKeyStart1N63( ) ;
         if ( RcdFound63 == 0 )
         {
            Gx_mode = "INS";
            /* Using cursor BC001N11 */
            pr_default.execute(8, new Object[] {A85BR_Information_ID});
            if ( (pr_default.getStatus(8) == 101) )
            {
               GX_msglist.addItem("不匹配' T16'", "ForeignKeyNotFound", 1, "BR_INFORMATION_ID");
               AnyError = 1;
            }
            pr_default.close(8);
            /* Using cursor BC001N12 */
            pr_datastore1.execute(1, new Object[] {A366DataPackage});
            if ( (pr_datastore1.getStatus(1) == 101) )
            {
               GX_msglist.addItem("不匹配'BAS_Data Package'", "ForeignKeyNotFound", 1, "DATAPACKAGE");
               AnyError = 1;
            }
            pr_datastore1.close(1);
         }
         else
         {
            Gx_mode = "UPD";
            Z85BR_Information_ID = A85BR_Information_ID;
            Z366DataPackage = A366DataPackage;
         }
         ZM1N63( -1) ;
         OnLoadActions1N63( ) ;
         AddRow1N63( ) ;
         ScanKeyEnd1N63( ) ;
         if ( RcdFound63 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey1N63( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert1N63( ) ;
         }
         else
         {
            if ( RcdFound63 == 1 )
            {
               if ( ( A85BR_Information_ID != Z85BR_Information_ID ) || ( StringUtil.StrCmp(A366DataPackage, Z366DataPackage) != 0 ) )
               {
                  A85BR_Information_ID = Z85BR_Information_ID;
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
                  Update1N63( ) ;
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
                  if ( ( A85BR_Information_ID != Z85BR_Information_ID ) || ( StringUtil.StrCmp(A366DataPackage, Z366DataPackage) != 0 ) )
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
                        Insert1N63( ) ;
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
                        Insert1N63( ) ;
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
         RowToVars63( bcBR_PatientReEntity, 0) ;
         SaveImpl( ) ;
         VarsToRow63( bcBR_PatientReEntity) ;
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
         RowToVars63( bcBR_PatientReEntity, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert1N63( ) ;
         AfterTrn( ) ;
         VarsToRow63( bcBR_PatientReEntity) ;
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
            SdtBR_PatientReEntity auxBC = new SdtBR_PatientReEntity(context) ;
            auxBC.Load(A85BR_Information_ID, A366DataPackage);
            auxBC.UpdateDirties(bcBR_PatientReEntity);
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
         RowToVars63( bcBR_PatientReEntity, 0) ;
         UpdateImpl( ) ;
         VarsToRow63( bcBR_PatientReEntity) ;
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
         RowToVars63( bcBR_PatientReEntity, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert1N63( ) ;
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
         VarsToRow63( bcBR_PatientReEntity) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars63( bcBR_PatientReEntity, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey1N63( ) ;
         if ( RcdFound63 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( ( A85BR_Information_ID != Z85BR_Information_ID ) || ( StringUtil.StrCmp(A366DataPackage, Z366DataPackage) != 0 ) )
            {
               A85BR_Information_ID = Z85BR_Information_ID;
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
            if ( ( A85BR_Information_ID != Z85BR_Information_ID ) || ( StringUtil.StrCmp(A366DataPackage, Z366DataPackage) != 0 ) )
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
         pr_default.close(1);
         pr_default.close(8);
         pr_datastore1.close(1);
         context.RollbackDataStores("br_patientreentity_bc",pr_default);
         VarsToRow63( bcBR_PatientReEntity) ;
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
         Gx_mode = bcBR_PatientReEntity.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcBR_PatientReEntity.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcBR_PatientReEntity )
         {
            bcBR_PatientReEntity = (SdtBR_PatientReEntity)(sdt);
            if ( StringUtil.StrCmp(bcBR_PatientReEntity.gxTpr_Mode, "") == 0 )
            {
               bcBR_PatientReEntity.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow63( bcBR_PatientReEntity) ;
            }
            else
            {
               RowToVars63( bcBR_PatientReEntity, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcBR_PatientReEntity.gxTpr_Mode, "") == 0 )
            {
               bcBR_PatientReEntity.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars63( bcBR_PatientReEntity, 1) ;
         return  ;
      }

      public SdtBR_PatientReEntity BR_PatientReEntity_BC
      {
         get {
            return bcBR_PatientReEntity ;
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
         pr_default.close(1);
         pr_default.close(8);
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
         BC001N6_A85BR_Information_ID = new long[1] ;
         BC001N6_A366DataPackage = new String[] {""} ;
         BC001N4_A85BR_Information_ID = new long[1] ;
         BC001N5_A366DataPackage = new String[] {""} ;
         BC001N7_A85BR_Information_ID = new long[1] ;
         BC001N7_A366DataPackage = new String[] {""} ;
         BC001N3_A85BR_Information_ID = new long[1] ;
         BC001N3_A366DataPackage = new String[] {""} ;
         sMode63 = "";
         BC001N2_A85BR_Information_ID = new long[1] ;
         BC001N2_A366DataPackage = new String[] {""} ;
         BC001N10_A85BR_Information_ID = new long[1] ;
         BC001N10_A366DataPackage = new String[] {""} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         BC001N11_A85BR_Information_ID = new long[1] ;
         BC001N12_A366DataPackage = new String[] {""} ;
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_patientreentity_bc__datastore1(),
            new Object[][] {
                new Object[] {
               BC001N5_A366DataPackage
               }
               , new Object[] {
               BC001N12_A366DataPackage
               }
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_patientreentity_bc__default(),
            new Object[][] {
                new Object[] {
               BC001N2_A85BR_Information_ID, BC001N2_A366DataPackage
               }
               , new Object[] {
               BC001N3_A85BR_Information_ID, BC001N3_A366DataPackage
               }
               , new Object[] {
               BC001N4_A85BR_Information_ID
               }
               , new Object[] {
               BC001N6_A85BR_Information_ID, BC001N6_A366DataPackage
               }
               , new Object[] {
               BC001N7_A85BR_Information_ID, BC001N7_A366DataPackage
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC001N10_A85BR_Information_ID, BC001N10_A366DataPackage
               }
               , new Object[] {
               BC001N11_A85BR_Information_ID
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
      private short RcdFound63 ;
      private int trnEnded ;
      private long Z85BR_Information_ID ;
      private long A85BR_Information_ID ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String sMode63 ;
      private String Z366DataPackage ;
      private String A366DataPackage ;
      private SdtBR_PatientReEntity bcBR_PatientReEntity ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] BC001N6_A85BR_Information_ID ;
      private String[] BC001N6_A366DataPackage ;
      private long[] BC001N4_A85BR_Information_ID ;
      private IDataStoreProvider pr_datastore1 ;
      private String[] BC001N5_A366DataPackage ;
      private long[] BC001N7_A85BR_Information_ID ;
      private String[] BC001N7_A366DataPackage ;
      private long[] BC001N3_A85BR_Information_ID ;
      private String[] BC001N3_A366DataPackage ;
      private long[] BC001N2_A85BR_Information_ID ;
      private String[] BC001N2_A366DataPackage ;
      private long[] BC001N10_A85BR_Information_ID ;
      private String[] BC001N10_A366DataPackage ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private long[] BC001N11_A85BR_Information_ID ;
      private String[] BC001N12_A366DataPackage ;
   }

   public class br_patientreentity_bc__datastore1 : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmBC001N5 ;
          prmBC001N5 = new Object[] {
          new Object[] {"@DataPackage",SqlDbType.NVarChar,50,0}
          } ;
          Object[] prmBC001N12 ;
          prmBC001N12 = new Object[] {
          new Object[] {"@DataPackage",SqlDbType.NVarChar,50,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("BC001N5", "SELECT [DataPackage] FROM dbo.[BAS_DataPackage] WITH (NOLOCK) WHERE [DataPackage] = @DataPackage ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001N5,1,0,true,false )
             ,new CursorDef("BC001N12", "SELECT [DataPackage] FROM dbo.[BAS_DataPackage] WITH (NOLOCK) WHERE [DataPackage] = @DataPackage ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001N12,1,0,true,false )
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
       }
    }

    public String getDataStoreName( )
    {
       return "DATASTORE1";
    }

 }

 public class br_patientreentity_bc__default : DataStoreHelperBase, IDataStoreHelper
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
       ,new ForEachCursor(def[7])
       ,new ForEachCursor(def[8])
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmBC001N6 ;
        prmBC001N6 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@DataPackage",SqlDbType.NVarChar,50,0}
        } ;
        Object[] prmBC001N4 ;
        prmBC001N4 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC001N7 ;
        prmBC001N7 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@DataPackage",SqlDbType.NVarChar,50,0}
        } ;
        Object[] prmBC001N3 ;
        prmBC001N3 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@DataPackage",SqlDbType.NVarChar,50,0}
        } ;
        Object[] prmBC001N2 ;
        prmBC001N2 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@DataPackage",SqlDbType.NVarChar,50,0}
        } ;
        Object[] prmBC001N8 ;
        prmBC001N8 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@DataPackage",SqlDbType.NVarChar,50,0}
        } ;
        Object[] prmBC001N9 ;
        prmBC001N9 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@DataPackage",SqlDbType.NVarChar,50,0}
        } ;
        Object[] prmBC001N10 ;
        prmBC001N10 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@DataPackage",SqlDbType.NVarChar,50,0}
        } ;
        Object[] prmBC001N11 ;
        prmBC001N11 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("BC001N2", "SELECT [BR_Information_ID], [DataPackage] FROM [BR_PatientReEntity] WITH (UPDLOCK) WHERE [BR_Information_ID] = @BR_Information_ID AND [DataPackage] = @DataPackage ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001N2,1,0,true,false )
           ,new CursorDef("BC001N3", "SELECT [BR_Information_ID], [DataPackage] FROM [BR_PatientReEntity] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID AND [DataPackage] = @DataPackage ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001N3,1,0,true,false )
           ,new CursorDef("BC001N4", "SELECT [BR_Information_ID] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001N4,1,0,true,false )
           ,new CursorDef("BC001N6", "SELECT TM1.[BR_Information_ID], TM1.[DataPackage] FROM [BR_PatientReEntity] TM1 WITH (NOLOCK) WHERE TM1.[BR_Information_ID] = @BR_Information_ID and TM1.[DataPackage] = @DataPackage ORDER BY TM1.[BR_Information_ID], TM1.[DataPackage]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001N6,100,0,true,false )
           ,new CursorDef("BC001N7", "SELECT [BR_Information_ID], [DataPackage] FROM [BR_PatientReEntity] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID AND [DataPackage] = @DataPackage  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001N7,1,0,true,false )
           ,new CursorDef("BC001N8", "INSERT INTO [BR_PatientReEntity]([BR_Information_ID], [DataPackage]) VALUES(@BR_Information_ID, @DataPackage)", GxErrorMask.GX_NOMASK,prmBC001N8)
           ,new CursorDef("BC001N9", "DELETE FROM [BR_PatientReEntity]  WHERE [BR_Information_ID] = @BR_Information_ID AND [DataPackage] = @DataPackage", GxErrorMask.GX_NOMASK,prmBC001N9)
           ,new CursorDef("BC001N10", "SELECT TM1.[BR_Information_ID], TM1.[DataPackage] FROM [BR_PatientReEntity] TM1 WITH (NOLOCK) WHERE TM1.[BR_Information_ID] = @BR_Information_ID and TM1.[DataPackage] = @DataPackage ORDER BY TM1.[BR_Information_ID], TM1.[DataPackage]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001N10,100,0,true,false )
           ,new CursorDef("BC001N11", "SELECT [BR_Information_ID] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001N11,1,0,true,false )
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
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              return;
           case 2 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 3 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              return;
           case 4 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              return;
           case 7 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              return;
           case 8 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
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
              stmt.SetParameter(1, (long)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              return;
           case 1 :
              stmt.SetParameter(1, (long)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              return;
           case 2 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 3 :
              stmt.SetParameter(1, (long)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              return;
           case 4 :
              stmt.SetParameter(1, (long)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              return;
           case 5 :
              stmt.SetParameter(1, (long)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              return;
           case 6 :
              stmt.SetParameter(1, (long)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              return;
           case 7 :
              stmt.SetParameter(1, (long)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              return;
           case 8 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
     }
  }

}

}
