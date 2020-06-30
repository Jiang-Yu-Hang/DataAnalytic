/*
               File: BR_PatientReTenant_BC
        Description: 患者租户关系表
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:39:4.16
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
   public class br_patientretenant_bc : GXHttpHandler, IGxSilentTrn
   {
      public br_patientretenant_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_patientretenant_bc( IGxContext context )
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
         ReadRow1M64( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey1M64( ) ;
         standaloneModal( ) ;
         AddRow1M64( ) ;
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

      protected void CONFIRM_1M0( )
      {
         BeforeValidate1M64( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls1M64( ) ;
            }
            else
            {
               CheckExtendedTable1M64( ) ;
               if ( AnyError == 0 )
               {
                  ZM1M64( 2) ;
                  ZM1M64( 3) ;
               }
               CloseExtendedTableCursors1M64( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void ZM1M64( short GX_JID )
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
            Z360BAS_TenantTenantCode = A360BAS_TenantTenantCode;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load1M64( )
      {
         /* Using cursor BC001M6 */
         pr_default.execute(3, new Object[] {n85BR_Information_ID, A85BR_Information_ID, n360BAS_TenantTenantCode, A360BAS_TenantTenantCode});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound64 = 1;
            ZM1M64( -1) ;
         }
         pr_default.close(3);
         OnLoadActions1M64( ) ;
      }

      protected void OnLoadActions1M64( )
      {
      }

      protected void CheckExtendedTable1M64( )
      {
         standaloneModal( ) ;
         /* Using cursor BC001M4 */
         pr_default.execute(2, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("不匹配' T16'", "ForeignKeyNotFound", 1, "BR_INFORMATION_ID");
            AnyError = 1;
         }
         pr_default.close(2);
         /* Using cursor BC001M5 */
         pr_datastore1.execute(0, new Object[] {n360BAS_TenantTenantCode, A360BAS_TenantTenantCode});
         if ( (pr_datastore1.getStatus(0) == 101) )
         {
            GX_msglist.addItem("不匹配'BAS_Tenant'", "ForeignKeyNotFound", 1, "BAS_TENANTTENANTCODE");
            AnyError = 1;
         }
         pr_datastore1.close(0);
      }

      protected void CloseExtendedTableCursors1M64( )
      {
         pr_default.close(2);
         pr_datastore1.close(0);
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey1M64( )
      {
         /* Using cursor BC001M7 */
         pr_default.execute(4, new Object[] {n85BR_Information_ID, A85BR_Information_ID, n360BAS_TenantTenantCode, A360BAS_TenantTenantCode});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound64 = 1;
         }
         else
         {
            RcdFound64 = 0;
         }
         pr_default.close(4);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC001M3 */
         pr_default.execute(1, new Object[] {n85BR_Information_ID, A85BR_Information_ID, n360BAS_TenantTenantCode, A360BAS_TenantTenantCode});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM1M64( 1) ;
            RcdFound64 = 1;
            A85BR_Information_ID = BC001M3_A85BR_Information_ID[0];
            n85BR_Information_ID = BC001M3_n85BR_Information_ID[0];
            A360BAS_TenantTenantCode = BC001M3_A360BAS_TenantTenantCode[0];
            n360BAS_TenantTenantCode = BC001M3_n360BAS_TenantTenantCode[0];
            Z85BR_Information_ID = A85BR_Information_ID;
            Z360BAS_TenantTenantCode = A360BAS_TenantTenantCode;
            sMode64 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load1M64( ) ;
            if ( AnyError == 1 )
            {
               RcdFound64 = 0;
               InitializeNonKey1M64( ) ;
            }
            Gx_mode = sMode64;
         }
         else
         {
            RcdFound64 = 0;
            InitializeNonKey1M64( ) ;
            sMode64 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode64;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1M64( ) ;
         if ( RcdFound64 == 0 )
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
         CONFIRM_1M0( ) ;
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

      protected void CheckOptimisticConcurrency1M64( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC001M2 */
            pr_default.execute(0, new Object[] {n85BR_Information_ID, A85BR_Information_ID, n360BAS_TenantTenantCode, A360BAS_TenantTenantCode});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_PatientReTenant"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"BR_PatientReTenant"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert1M64( )
      {
         BeforeValidate1M64( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1M64( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1M64( 0) ;
            CheckOptimisticConcurrency1M64( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1M64( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1M64( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC001M8 */
                     pr_default.execute(5, new Object[] {n85BR_Information_ID, A85BR_Information_ID, n360BAS_TenantTenantCode, A360BAS_TenantTenantCode});
                     pr_default.close(5);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_PatientReTenant") ;
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
               Load1M64( ) ;
            }
            EndLevel1M64( ) ;
         }
         CloseExtendedTableCursors1M64( ) ;
      }

      protected void Update1M64( )
      {
         BeforeValidate1M64( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1M64( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1M64( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1M64( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1M64( ) ;
                  if ( AnyError == 0 )
                  {
                     /* No attributes to update on table [BR_PatientReTenant] */
                     DeferredUpdate1M64( ) ;
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
            EndLevel1M64( ) ;
         }
         CloseExtendedTableCursors1M64( ) ;
      }

      protected void DeferredUpdate1M64( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate1M64( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1M64( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1M64( ) ;
            AfterConfirm1M64( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1M64( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC001M9 */
                  pr_default.execute(6, new Object[] {n85BR_Information_ID, A85BR_Information_ID, n360BAS_TenantTenantCode, A360BAS_TenantTenantCode});
                  pr_default.close(6);
                  dsDefault.SmartCacheProvider.SetUpdated("BR_PatientReTenant") ;
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
         sMode64 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel1M64( ) ;
         Gx_mode = sMode64;
      }

      protected void OnDeleteControls1M64( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor BC001M10 */
            pr_default.execute(7, new Object[] {n85BR_Information_ID, A85BR_Information_ID, n360BAS_TenantTenantCode, A360BAS_TenantTenantCode});
            if ( (pr_default.getStatus(7) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {" T15"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(7);
         }
      }

      protected void EndLevel1M64( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1M64( ) ;
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

      public void ScanKeyStart1M64( )
      {
         /* Using cursor BC001M11 */
         pr_default.execute(8, new Object[] {n85BR_Information_ID, A85BR_Information_ID, n360BAS_TenantTenantCode, A360BAS_TenantTenantCode});
         RcdFound64 = 0;
         if ( (pr_default.getStatus(8) != 101) )
         {
            RcdFound64 = 1;
            A85BR_Information_ID = BC001M11_A85BR_Information_ID[0];
            n85BR_Information_ID = BC001M11_n85BR_Information_ID[0];
            A360BAS_TenantTenantCode = BC001M11_A360BAS_TenantTenantCode[0];
            n360BAS_TenantTenantCode = BC001M11_n360BAS_TenantTenantCode[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext1M64( )
      {
         /* Scan next routine */
         pr_default.readNext(8);
         RcdFound64 = 0;
         ScanKeyLoad1M64( ) ;
      }

      protected void ScanKeyLoad1M64( )
      {
         sMode64 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(8) != 101) )
         {
            RcdFound64 = 1;
            A85BR_Information_ID = BC001M11_A85BR_Information_ID[0];
            n85BR_Information_ID = BC001M11_n85BR_Information_ID[0];
            A360BAS_TenantTenantCode = BC001M11_A360BAS_TenantTenantCode[0];
            n360BAS_TenantTenantCode = BC001M11_n360BAS_TenantTenantCode[0];
         }
         Gx_mode = sMode64;
      }

      protected void ScanKeyEnd1M64( )
      {
         pr_default.close(8);
      }

      protected void AfterConfirm1M64( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1M64( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1M64( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1M64( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1M64( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1M64( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1M64( )
      {
      }

      protected void send_integrity_lvl_hashes1M64( )
      {
      }

      protected void AddRow1M64( )
      {
         VarsToRow64( bcBR_PatientReTenant) ;
      }

      protected void ReadRow1M64( )
      {
         RowToVars64( bcBR_PatientReTenant, 1) ;
      }

      protected void InitializeNonKey1M64( )
      {
      }

      protected void InitAll1M64( )
      {
         A85BR_Information_ID = 0;
         n85BR_Information_ID = false;
         A360BAS_TenantTenantCode = "";
         n360BAS_TenantTenantCode = false;
         InitializeNonKey1M64( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow64( SdtBR_PatientReTenant obj64 )
      {
         obj64.gxTpr_Mode = Gx_mode;
         obj64.gxTpr_Br_information_id = A85BR_Information_ID;
         obj64.gxTpr_Bas_tenanttenantcode = A360BAS_TenantTenantCode;
         obj64.gxTpr_Br_information_id_Z = Z85BR_Information_ID;
         obj64.gxTpr_Bas_tenanttenantcode_Z = Z360BAS_TenantTenantCode;
         obj64.gxTpr_Br_information_id_N = (short)(Convert.ToInt16(n85BR_Information_ID));
         obj64.gxTpr_Bas_tenanttenantcode_N = (short)(Convert.ToInt16(n360BAS_TenantTenantCode));
         obj64.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow64( SdtBR_PatientReTenant obj64 )
      {
         obj64.gxTpr_Br_information_id = A85BR_Information_ID;
         obj64.gxTpr_Bas_tenanttenantcode = A360BAS_TenantTenantCode;
         return  ;
      }

      public void RowToVars64( SdtBR_PatientReTenant obj64 ,
                               int forceLoad )
      {
         Gx_mode = obj64.gxTpr_Mode;
         A85BR_Information_ID = obj64.gxTpr_Br_information_id;
         n85BR_Information_ID = false;
         A360BAS_TenantTenantCode = obj64.gxTpr_Bas_tenanttenantcode;
         n360BAS_TenantTenantCode = false;
         Z85BR_Information_ID = obj64.gxTpr_Br_information_id_Z;
         Z360BAS_TenantTenantCode = obj64.gxTpr_Bas_tenanttenantcode_Z;
         n85BR_Information_ID = (bool)(Convert.ToBoolean(obj64.gxTpr_Br_information_id_N));
         n360BAS_TenantTenantCode = (bool)(Convert.ToBoolean(obj64.gxTpr_Bas_tenanttenantcode_N));
         Gx_mode = obj64.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A85BR_Information_ID = (long)getParm(obj,0);
         n85BR_Information_ID = false;
         A360BAS_TenantTenantCode = (String)getParm(obj,1);
         n360BAS_TenantTenantCode = false;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey1M64( ) ;
         ScanKeyStart1M64( ) ;
         if ( RcdFound64 == 0 )
         {
            Gx_mode = "INS";
            /* Using cursor BC001M12 */
            pr_default.execute(9, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
            if ( (pr_default.getStatus(9) == 101) )
            {
               GX_msglist.addItem("不匹配' T16'", "ForeignKeyNotFound", 1, "BR_INFORMATION_ID");
               AnyError = 1;
            }
            pr_default.close(9);
            /* Using cursor BC001M13 */
            pr_datastore1.execute(1, new Object[] {n360BAS_TenantTenantCode, A360BAS_TenantTenantCode});
            if ( (pr_datastore1.getStatus(1) == 101) )
            {
               GX_msglist.addItem("不匹配'BAS_Tenant'", "ForeignKeyNotFound", 1, "BAS_TENANTTENANTCODE");
               AnyError = 1;
            }
            pr_datastore1.close(1);
         }
         else
         {
            Gx_mode = "UPD";
            Z85BR_Information_ID = A85BR_Information_ID;
            Z360BAS_TenantTenantCode = A360BAS_TenantTenantCode;
         }
         ZM1M64( -1) ;
         OnLoadActions1M64( ) ;
         AddRow1M64( ) ;
         ScanKeyEnd1M64( ) ;
         if ( RcdFound64 == 0 )
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
         RowToVars64( bcBR_PatientReTenant, 0) ;
         ScanKeyStart1M64( ) ;
         if ( RcdFound64 == 0 )
         {
            Gx_mode = "INS";
            /* Using cursor BC001M12 */
            pr_default.execute(9, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
            if ( (pr_default.getStatus(9) == 101) )
            {
               GX_msglist.addItem("不匹配' T16'", "ForeignKeyNotFound", 1, "BR_INFORMATION_ID");
               AnyError = 1;
            }
            pr_default.close(9);
            /* Using cursor BC001M13 */
            pr_datastore1.execute(1, new Object[] {n360BAS_TenantTenantCode, A360BAS_TenantTenantCode});
            if ( (pr_datastore1.getStatus(1) == 101) )
            {
               GX_msglist.addItem("不匹配'BAS_Tenant'", "ForeignKeyNotFound", 1, "BAS_TENANTTENANTCODE");
               AnyError = 1;
            }
            pr_datastore1.close(1);
         }
         else
         {
            Gx_mode = "UPD";
            Z85BR_Information_ID = A85BR_Information_ID;
            Z360BAS_TenantTenantCode = A360BAS_TenantTenantCode;
         }
         ZM1M64( -1) ;
         OnLoadActions1M64( ) ;
         AddRow1M64( ) ;
         ScanKeyEnd1M64( ) ;
         if ( RcdFound64 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey1M64( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert1M64( ) ;
         }
         else
         {
            if ( RcdFound64 == 1 )
            {
               if ( ( A85BR_Information_ID != Z85BR_Information_ID ) || ( StringUtil.StrCmp(A360BAS_TenantTenantCode, Z360BAS_TenantTenantCode) != 0 ) )
               {
                  A85BR_Information_ID = Z85BR_Information_ID;
                  n85BR_Information_ID = false;
                  A360BAS_TenantTenantCode = Z360BAS_TenantTenantCode;
                  n360BAS_TenantTenantCode = false;
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
                  Update1M64( ) ;
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
                  if ( ( A85BR_Information_ID != Z85BR_Information_ID ) || ( StringUtil.StrCmp(A360BAS_TenantTenantCode, Z360BAS_TenantTenantCode) != 0 ) )
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
                        Insert1M64( ) ;
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
                        Insert1M64( ) ;
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
         RowToVars64( bcBR_PatientReTenant, 0) ;
         SaveImpl( ) ;
         VarsToRow64( bcBR_PatientReTenant) ;
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
         RowToVars64( bcBR_PatientReTenant, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert1M64( ) ;
         AfterTrn( ) ;
         VarsToRow64( bcBR_PatientReTenant) ;
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
            SdtBR_PatientReTenant auxBC = new SdtBR_PatientReTenant(context) ;
            auxBC.Load(A85BR_Information_ID, A360BAS_TenantTenantCode);
            auxBC.UpdateDirties(bcBR_PatientReTenant);
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
         RowToVars64( bcBR_PatientReTenant, 0) ;
         UpdateImpl( ) ;
         VarsToRow64( bcBR_PatientReTenant) ;
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
         RowToVars64( bcBR_PatientReTenant, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert1M64( ) ;
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
         VarsToRow64( bcBR_PatientReTenant) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars64( bcBR_PatientReTenant, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey1M64( ) ;
         if ( RcdFound64 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( ( A85BR_Information_ID != Z85BR_Information_ID ) || ( StringUtil.StrCmp(A360BAS_TenantTenantCode, Z360BAS_TenantTenantCode) != 0 ) )
            {
               A85BR_Information_ID = Z85BR_Information_ID;
               n85BR_Information_ID = false;
               A360BAS_TenantTenantCode = Z360BAS_TenantTenantCode;
               n360BAS_TenantTenantCode = false;
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
            if ( ( A85BR_Information_ID != Z85BR_Information_ID ) || ( StringUtil.StrCmp(A360BAS_TenantTenantCode, Z360BAS_TenantTenantCode) != 0 ) )
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
         pr_default.close(9);
         pr_datastore1.close(1);
         context.RollbackDataStores("br_patientretenant_bc",pr_default);
         VarsToRow64( bcBR_PatientReTenant) ;
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
         Gx_mode = bcBR_PatientReTenant.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcBR_PatientReTenant.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcBR_PatientReTenant )
         {
            bcBR_PatientReTenant = (SdtBR_PatientReTenant)(sdt);
            if ( StringUtil.StrCmp(bcBR_PatientReTenant.gxTpr_Mode, "") == 0 )
            {
               bcBR_PatientReTenant.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow64( bcBR_PatientReTenant) ;
            }
            else
            {
               RowToVars64( bcBR_PatientReTenant, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcBR_PatientReTenant.gxTpr_Mode, "") == 0 )
            {
               bcBR_PatientReTenant.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars64( bcBR_PatientReTenant, 1) ;
         return  ;
      }

      public SdtBR_PatientReTenant BR_PatientReTenant_BC
      {
         get {
            return bcBR_PatientReTenant ;
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
         pr_default.close(9);
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
         BC001M6_A85BR_Information_ID = new long[1] ;
         BC001M6_n85BR_Information_ID = new bool[] {false} ;
         BC001M6_A360BAS_TenantTenantCode = new String[] {""} ;
         BC001M6_n360BAS_TenantTenantCode = new bool[] {false} ;
         BC001M4_A85BR_Information_ID = new long[1] ;
         BC001M4_n85BR_Information_ID = new bool[] {false} ;
         BC001M5_A360BAS_TenantTenantCode = new String[] {""} ;
         BC001M5_n360BAS_TenantTenantCode = new bool[] {false} ;
         BC001M7_A85BR_Information_ID = new long[1] ;
         BC001M7_n85BR_Information_ID = new bool[] {false} ;
         BC001M7_A360BAS_TenantTenantCode = new String[] {""} ;
         BC001M7_n360BAS_TenantTenantCode = new bool[] {false} ;
         BC001M3_A85BR_Information_ID = new long[1] ;
         BC001M3_n85BR_Information_ID = new bool[] {false} ;
         BC001M3_A360BAS_TenantTenantCode = new String[] {""} ;
         BC001M3_n360BAS_TenantTenantCode = new bool[] {false} ;
         sMode64 = "";
         BC001M2_A85BR_Information_ID = new long[1] ;
         BC001M2_n85BR_Information_ID = new bool[] {false} ;
         BC001M2_A360BAS_TenantTenantCode = new String[] {""} ;
         BC001M2_n360BAS_TenantTenantCode = new bool[] {false} ;
         BC001M10_A19BR_EncounterID = new long[1] ;
         BC001M11_A85BR_Information_ID = new long[1] ;
         BC001M11_n85BR_Information_ID = new bool[] {false} ;
         BC001M11_A360BAS_TenantTenantCode = new String[] {""} ;
         BC001M11_n360BAS_TenantTenantCode = new bool[] {false} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         BC001M12_A85BR_Information_ID = new long[1] ;
         BC001M12_n85BR_Information_ID = new bool[] {false} ;
         BC001M13_A360BAS_TenantTenantCode = new String[] {""} ;
         BC001M13_n360BAS_TenantTenantCode = new bool[] {false} ;
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_patientretenant_bc__datastore1(),
            new Object[][] {
                new Object[] {
               BC001M5_A360BAS_TenantTenantCode
               }
               , new Object[] {
               BC001M13_A360BAS_TenantTenantCode
               }
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_patientretenant_bc__default(),
            new Object[][] {
                new Object[] {
               BC001M2_A85BR_Information_ID, BC001M2_A360BAS_TenantTenantCode
               }
               , new Object[] {
               BC001M3_A85BR_Information_ID, BC001M3_A360BAS_TenantTenantCode
               }
               , new Object[] {
               BC001M4_A85BR_Information_ID
               }
               , new Object[] {
               BC001M6_A85BR_Information_ID, BC001M6_A360BAS_TenantTenantCode
               }
               , new Object[] {
               BC001M7_A85BR_Information_ID, BC001M7_A360BAS_TenantTenantCode
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC001M10_A19BR_EncounterID
               }
               , new Object[] {
               BC001M11_A85BR_Information_ID, BC001M11_A360BAS_TenantTenantCode
               }
               , new Object[] {
               BC001M12_A85BR_Information_ID
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
      private short RcdFound64 ;
      private int trnEnded ;
      private long Z85BR_Information_ID ;
      private long A85BR_Information_ID ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String sMode64 ;
      private bool n85BR_Information_ID ;
      private bool n360BAS_TenantTenantCode ;
      private String Z360BAS_TenantTenantCode ;
      private String A360BAS_TenantTenantCode ;
      private SdtBR_PatientReTenant bcBR_PatientReTenant ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] BC001M6_A85BR_Information_ID ;
      private bool[] BC001M6_n85BR_Information_ID ;
      private String[] BC001M6_A360BAS_TenantTenantCode ;
      private bool[] BC001M6_n360BAS_TenantTenantCode ;
      private long[] BC001M4_A85BR_Information_ID ;
      private bool[] BC001M4_n85BR_Information_ID ;
      private IDataStoreProvider pr_datastore1 ;
      private String[] BC001M5_A360BAS_TenantTenantCode ;
      private bool[] BC001M5_n360BAS_TenantTenantCode ;
      private long[] BC001M7_A85BR_Information_ID ;
      private bool[] BC001M7_n85BR_Information_ID ;
      private String[] BC001M7_A360BAS_TenantTenantCode ;
      private bool[] BC001M7_n360BAS_TenantTenantCode ;
      private long[] BC001M3_A85BR_Information_ID ;
      private bool[] BC001M3_n85BR_Information_ID ;
      private String[] BC001M3_A360BAS_TenantTenantCode ;
      private bool[] BC001M3_n360BAS_TenantTenantCode ;
      private long[] BC001M2_A85BR_Information_ID ;
      private bool[] BC001M2_n85BR_Information_ID ;
      private String[] BC001M2_A360BAS_TenantTenantCode ;
      private bool[] BC001M2_n360BAS_TenantTenantCode ;
      private long[] BC001M10_A19BR_EncounterID ;
      private long[] BC001M11_A85BR_Information_ID ;
      private bool[] BC001M11_n85BR_Information_ID ;
      private String[] BC001M11_A360BAS_TenantTenantCode ;
      private bool[] BC001M11_n360BAS_TenantTenantCode ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private long[] BC001M12_A85BR_Information_ID ;
      private bool[] BC001M12_n85BR_Information_ID ;
      private String[] BC001M13_A360BAS_TenantTenantCode ;
      private bool[] BC001M13_n360BAS_TenantTenantCode ;
   }

   public class br_patientretenant_bc__datastore1 : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmBC001M5 ;
          prmBC001M5 = new Object[] {
          new Object[] {"@BAS_TenantTenantCode",SqlDbType.NVarChar,20,0}
          } ;
          Object[] prmBC001M13 ;
          prmBC001M13 = new Object[] {
          new Object[] {"@BAS_TenantTenantCode",SqlDbType.NVarChar,20,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("BC001M5", "SELECT [TenantCode] FROM dbo.[BAS_Tenant] WITH (NOLOCK) WHERE [TenantCode] = @BAS_TenantTenantCode ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001M5,1,0,true,false )
             ,new CursorDef("BC001M13", "SELECT [TenantCode] FROM dbo.[BAS_Tenant] WITH (NOLOCK) WHERE [TenantCode] = @BAS_TenantTenantCode ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001M13,1,0,true,false )
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
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                return;
             case 1 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                return;
       }
    }

    public String getDataStoreName( )
    {
       return "DATASTORE1";
    }

 }

 public class br_patientretenant_bc__default : DataStoreHelperBase, IDataStoreHelper
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
       ,new ForEachCursor(def[9])
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmBC001M6 ;
        prmBC001M6 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BAS_TenantTenantCode",SqlDbType.NVarChar,20,0}
        } ;
        Object[] prmBC001M4 ;
        prmBC001M4 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC001M7 ;
        prmBC001M7 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BAS_TenantTenantCode",SqlDbType.NVarChar,20,0}
        } ;
        Object[] prmBC001M3 ;
        prmBC001M3 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BAS_TenantTenantCode",SqlDbType.NVarChar,20,0}
        } ;
        Object[] prmBC001M2 ;
        prmBC001M2 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BAS_TenantTenantCode",SqlDbType.NVarChar,20,0}
        } ;
        Object[] prmBC001M8 ;
        prmBC001M8 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BAS_TenantTenantCode",SqlDbType.NVarChar,20,0}
        } ;
        Object[] prmBC001M9 ;
        prmBC001M9 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BAS_TenantTenantCode",SqlDbType.NVarChar,20,0}
        } ;
        Object[] prmBC001M10 ;
        prmBC001M10 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BAS_TenantTenantCode",SqlDbType.NVarChar,20,0}
        } ;
        Object[] prmBC001M11 ;
        prmBC001M11 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BAS_TenantTenantCode",SqlDbType.NVarChar,20,0}
        } ;
        Object[] prmBC001M12 ;
        prmBC001M12 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("BC001M2", "SELECT [BR_Information_ID], [BAS_TenantTenantCode] FROM [BR_PatientReTenant] WITH (UPDLOCK) WHERE [BR_Information_ID] = @BR_Information_ID AND [BAS_TenantTenantCode] = @BAS_TenantTenantCode ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001M2,1,0,true,false )
           ,new CursorDef("BC001M3", "SELECT [BR_Information_ID], [BAS_TenantTenantCode] FROM [BR_PatientReTenant] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID AND [BAS_TenantTenantCode] = @BAS_TenantTenantCode ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001M3,1,0,true,false )
           ,new CursorDef("BC001M4", "SELECT [BR_Information_ID] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001M4,1,0,true,false )
           ,new CursorDef("BC001M6", "SELECT TM1.[BR_Information_ID], TM1.[BAS_TenantTenantCode] FROM [BR_PatientReTenant] TM1 WITH (NOLOCK) WHERE TM1.[BR_Information_ID] = @BR_Information_ID and TM1.[BAS_TenantTenantCode] = @BAS_TenantTenantCode ORDER BY TM1.[BR_Information_ID], TM1.[BAS_TenantTenantCode]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001M6,100,0,true,false )
           ,new CursorDef("BC001M7", "SELECT [BR_Information_ID], [BAS_TenantTenantCode] FROM [BR_PatientReTenant] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID AND [BAS_TenantTenantCode] = @BAS_TenantTenantCode  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001M7,1,0,true,false )
           ,new CursorDef("BC001M8", "INSERT INTO [BR_PatientReTenant]([BR_Information_ID], [BAS_TenantTenantCode]) VALUES(@BR_Information_ID, @BAS_TenantTenantCode)", GxErrorMask.GX_NOMASK,prmBC001M8)
           ,new CursorDef("BC001M9", "DELETE FROM [BR_PatientReTenant]  WHERE [BR_Information_ID] = @BR_Information_ID AND [BAS_TenantTenantCode] = @BAS_TenantTenantCode", GxErrorMask.GX_NOMASK,prmBC001M9)
           ,new CursorDef("BC001M10", "SELECT TOP 1 [BR_EncounterID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID AND [BAS_TenantTenantCode] = @BAS_TenantTenantCode ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001M10,1,0,true,true )
           ,new CursorDef("BC001M11", "SELECT TM1.[BR_Information_ID], TM1.[BAS_TenantTenantCode] FROM [BR_PatientReTenant] TM1 WITH (NOLOCK) WHERE TM1.[BR_Information_ID] = @BR_Information_ID and TM1.[BAS_TenantTenantCode] = @BAS_TenantTenantCode ORDER BY TM1.[BR_Information_ID], TM1.[BAS_TenantTenantCode]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001M11,100,0,true,false )
           ,new CursorDef("BC001M12", "SELECT [BR_Information_ID] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001M12,1,0,true,false )
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
              return;
           case 8 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              return;
           case 9 :
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
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              if ( (bool)parms[2] )
              {
                 stmt.setNull( 2 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(2, (String)parms[3]);
              }
              return;
           case 1 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              if ( (bool)parms[2] )
              {
                 stmt.setNull( 2 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(2, (String)parms[3]);
              }
              return;
           case 2 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 3 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              if ( (bool)parms[2] )
              {
                 stmt.setNull( 2 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(2, (String)parms[3]);
              }
              return;
           case 4 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              if ( (bool)parms[2] )
              {
                 stmt.setNull( 2 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(2, (String)parms[3]);
              }
              return;
           case 5 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              if ( (bool)parms[2] )
              {
                 stmt.setNull( 2 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(2, (String)parms[3]);
              }
              return;
           case 6 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              if ( (bool)parms[2] )
              {
                 stmt.setNull( 2 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(2, (String)parms[3]);
              }
              return;
           case 7 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              if ( (bool)parms[2] )
              {
                 stmt.setNull( 2 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(2, (String)parms[3]);
              }
              return;
           case 8 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              if ( (bool)parms[2] )
              {
                 stmt.setNull( 2 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(2, (String)parms[3]);
              }
              return;
           case 9 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
     }
  }

}

}
