/*
               File: BAS_Institute_BC
        Description: BAS_Institute
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:9:1.53
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
   public class bas_institute_bc : GXHttpHandler, IGxSilentTrn
   {
      public bas_institute_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public bas_institute_bc( IGxContext context )
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
         ReadRow1K57( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey1K57( ) ;
         standaloneModal( ) ;
         AddRow1K57( ) ;
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

      protected void CONFIRM_1K0( )
      {
         BeforeValidate1K57( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls1K57( ) ;
            }
            else
            {
               CheckExtendedTable1K57( ) ;
               if ( AnyError == 0 )
               {
               }
               CloseExtendedTableCursors1K57( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void ZM1K57( short GX_JID )
      {
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            Z386InstituteName = A386InstituteName;
            Z388BAS_InstituteCreator = A388BAS_InstituteCreator;
            Z389BAS_InstituteCreateTime = A389BAS_InstituteCreateTime;
            Z390BAS_InstituteModifier = A390BAS_InstituteModifier;
            Z391BAS_InstituteModifyTime = A391BAS_InstituteModifyTime;
            Z392BAS_InstituteIsDeleted = A392BAS_InstituteIsDeleted;
         }
         if ( GX_JID == -3 )
         {
            Z358InstituteCode = A358InstituteCode;
            Z386InstituteName = A386InstituteName;
            Z387BAS_InstituteLogo = A387BAS_InstituteLogo;
            Z388BAS_InstituteCreator = A388BAS_InstituteCreator;
            Z389BAS_InstituteCreateTime = A389BAS_InstituteCreateTime;
            Z390BAS_InstituteModifier = A390BAS_InstituteModifier;
            Z391BAS_InstituteModifyTime = A391BAS_InstituteModifyTime;
            Z392BAS_InstituteIsDeleted = A392BAS_InstituteIsDeleted;
            Z393BAS_InstituteDescription = A393BAS_InstituteDescription;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load1K57( )
      {
         /* Using cursor BC001K4 */
         pr_datastore1.execute(2, new Object[] {n358InstituteCode, A358InstituteCode});
         if ( (pr_datastore1.getStatus(2) != 101) )
         {
            RcdFound57 = 1;
            A386InstituteName = BC001K4_A386InstituteName[0];
            A388BAS_InstituteCreator = BC001K4_A388BAS_InstituteCreator[0];
            A389BAS_InstituteCreateTime = BC001K4_A389BAS_InstituteCreateTime[0];
            A390BAS_InstituteModifier = BC001K4_A390BAS_InstituteModifier[0];
            n390BAS_InstituteModifier = BC001K4_n390BAS_InstituteModifier[0];
            A391BAS_InstituteModifyTime = BC001K4_A391BAS_InstituteModifyTime[0];
            n391BAS_InstituteModifyTime = BC001K4_n391BAS_InstituteModifyTime[0];
            A392BAS_InstituteIsDeleted = BC001K4_A392BAS_InstituteIsDeleted[0];
            A393BAS_InstituteDescription = BC001K4_A393BAS_InstituteDescription[0];
            n393BAS_InstituteDescription = BC001K4_n393BAS_InstituteDescription[0];
            A387BAS_InstituteLogo = BC001K4_A387BAS_InstituteLogo[0];
            n387BAS_InstituteLogo = BC001K4_n387BAS_InstituteLogo[0];
            ZM1K57( -3) ;
         }
         pr_datastore1.close(2);
         OnLoadActions1K57( ) ;
      }

      protected void OnLoadActions1K57( )
      {
      }

      protected void CheckExtendedTable1K57( )
      {
         standaloneModal( ) ;
         if ( ! ( (DateTime.MinValue==A389BAS_InstituteCreateTime) || ( A389BAS_InstituteCreateTime >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("”ÚBAS_Institute Create Time≥¨ΩÁ", "OutOfRange", 1, "");
            AnyError = 1;
         }
         if ( ! ( (DateTime.MinValue==A391BAS_InstituteModifyTime) || ( A391BAS_InstituteModifyTime >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("”ÚBAS_Institute Modify Time≥¨ΩÁ", "OutOfRange", 1, "");
            AnyError = 1;
         }
      }

      protected void CloseExtendedTableCursors1K57( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey1K57( )
      {
         /* Using cursor BC001K5 */
         pr_datastore1.execute(3, new Object[] {n358InstituteCode, A358InstituteCode});
         if ( (pr_datastore1.getStatus(3) != 101) )
         {
            RcdFound57 = 1;
         }
         else
         {
            RcdFound57 = 0;
         }
         pr_datastore1.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC001K3 */
         pr_datastore1.execute(1, new Object[] {n358InstituteCode, A358InstituteCode});
         if ( (pr_datastore1.getStatus(1) != 101) )
         {
            ZM1K57( 3) ;
            RcdFound57 = 1;
            A358InstituteCode = BC001K3_A358InstituteCode[0];
            n358InstituteCode = BC001K3_n358InstituteCode[0];
            A386InstituteName = BC001K3_A386InstituteName[0];
            A388BAS_InstituteCreator = BC001K3_A388BAS_InstituteCreator[0];
            A389BAS_InstituteCreateTime = BC001K3_A389BAS_InstituteCreateTime[0];
            A390BAS_InstituteModifier = BC001K3_A390BAS_InstituteModifier[0];
            n390BAS_InstituteModifier = BC001K3_n390BAS_InstituteModifier[0];
            A391BAS_InstituteModifyTime = BC001K3_A391BAS_InstituteModifyTime[0];
            n391BAS_InstituteModifyTime = BC001K3_n391BAS_InstituteModifyTime[0];
            A392BAS_InstituteIsDeleted = BC001K3_A392BAS_InstituteIsDeleted[0];
            A393BAS_InstituteDescription = BC001K3_A393BAS_InstituteDescription[0];
            n393BAS_InstituteDescription = BC001K3_n393BAS_InstituteDescription[0];
            A387BAS_InstituteLogo = BC001K3_A387BAS_InstituteLogo[0];
            n387BAS_InstituteLogo = BC001K3_n387BAS_InstituteLogo[0];
            Z358InstituteCode = A358InstituteCode;
            sMode57 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load1K57( ) ;
            if ( AnyError == 1 )
            {
               RcdFound57 = 0;
               InitializeNonKey1K57( ) ;
            }
            Gx_mode = sMode57;
         }
         else
         {
            RcdFound57 = 0;
            InitializeNonKey1K57( ) ;
            sMode57 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode57;
         }
         pr_datastore1.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1K57( ) ;
         if ( RcdFound57 == 0 )
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
         CONFIRM_1K0( ) ;
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

      protected void CheckOptimisticConcurrency1K57( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC001K2 */
            pr_datastore1.execute(0, new Object[] {n358InstituteCode, A358InstituteCode});
            if ( (pr_datastore1.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BAS_INSTITUTE"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_datastore1.getStatus(0) == 101) || ( StringUtil.StrCmp(Z386InstituteName, BC001K2_A386InstituteName[0]) != 0 ) || ( StringUtil.StrCmp(Z388BAS_InstituteCreator, BC001K2_A388BAS_InstituteCreator[0]) != 0 ) || ( Z389BAS_InstituteCreateTime != BC001K2_A389BAS_InstituteCreateTime[0] ) || ( StringUtil.StrCmp(Z390BAS_InstituteModifier, BC001K2_A390BAS_InstituteModifier[0]) != 0 ) || ( Z391BAS_InstituteModifyTime != BC001K2_A391BAS_InstituteModifyTime[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z392BAS_InstituteIsDeleted != BC001K2_A392BAS_InstituteIsDeleted[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"BAS_INSTITUTE"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert1K57( )
      {
         BeforeValidate1K57( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1K57( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1K57( 0) ;
            CheckOptimisticConcurrency1K57( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1K57( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1K57( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC001K6 */
                     pr_datastore1.execute(4, new Object[] {n358InstituteCode, A358InstituteCode, A386InstituteName, n387BAS_InstituteLogo, A387BAS_InstituteLogo, A388BAS_InstituteCreator, A389BAS_InstituteCreateTime, n390BAS_InstituteModifier, A390BAS_InstituteModifier, n391BAS_InstituteModifyTime, A391BAS_InstituteModifyTime, A392BAS_InstituteIsDeleted, n393BAS_InstituteDescription, A393BAS_InstituteDescription});
                     pr_datastore1.close(4);
                     dsDataStore1.SmartCacheProvider.SetUpdated("BAS_INSTITUTE") ;
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
               Load1K57( ) ;
            }
            EndLevel1K57( ) ;
         }
         CloseExtendedTableCursors1K57( ) ;
      }

      protected void Update1K57( )
      {
         BeforeValidate1K57( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1K57( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1K57( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1K57( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1K57( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC001K7 */
                     pr_datastore1.execute(5, new Object[] {A386InstituteName, A388BAS_InstituteCreator, A389BAS_InstituteCreateTime, n390BAS_InstituteModifier, A390BAS_InstituteModifier, n391BAS_InstituteModifyTime, A391BAS_InstituteModifyTime, A392BAS_InstituteIsDeleted, n393BAS_InstituteDescription, A393BAS_InstituteDescription, n358InstituteCode, A358InstituteCode});
                     pr_datastore1.close(5);
                     dsDataStore1.SmartCacheProvider.SetUpdated("BAS_INSTITUTE") ;
                     if ( (pr_datastore1.getStatus(5) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BAS_INSTITUTE"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate1K57( ) ;
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
            EndLevel1K57( ) ;
         }
         CloseExtendedTableCursors1K57( ) ;
      }

      protected void DeferredUpdate1K57( )
      {
         if ( AnyError == 0 )
         {
            /* Using cursor BC001K8 */
            pr_datastore1.execute(6, new Object[] {n387BAS_InstituteLogo, A387BAS_InstituteLogo, n358InstituteCode, A358InstituteCode});
            pr_datastore1.close(6);
            dsDataStore1.SmartCacheProvider.SetUpdated("BAS_INSTITUTE") ;
         }
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate1K57( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1K57( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1K57( ) ;
            AfterConfirm1K57( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1K57( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC001K9 */
                  pr_datastore1.execute(7, new Object[] {n358InstituteCode, A358InstituteCode});
                  pr_datastore1.close(7);
                  dsDataStore1.SmartCacheProvider.SetUpdated("BAS_INSTITUTE") ;
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
         sMode57 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel1K57( ) ;
         Gx_mode = sMode57;
      }

      protected void OnDeleteControls1K57( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor BC001K10 */
            pr_datastore1.execute(8, new Object[] {n358InstituteCode, A358InstituteCode});
            if ( (pr_datastore1.getStatus(8) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"BAS_Tenant"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_datastore1.close(8);
            /* Using cursor BC001K11 */
            pr_datastore1.execute(9, new Object[] {n358InstituteCode, A358InstituteCode});
            if ( (pr_datastore1.getStatus(9) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"SYS_Institute User"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_datastore1.close(9);
         }
      }

      protected void EndLevel1K57( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_datastore1.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1K57( ) ;
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

      public void ScanKeyStart1K57( )
      {
         /* Using cursor BC001K12 */
         pr_datastore1.execute(10, new Object[] {n358InstituteCode, A358InstituteCode});
         RcdFound57 = 0;
         if ( (pr_datastore1.getStatus(10) != 101) )
         {
            RcdFound57 = 1;
            A358InstituteCode = BC001K12_A358InstituteCode[0];
            n358InstituteCode = BC001K12_n358InstituteCode[0];
            A386InstituteName = BC001K12_A386InstituteName[0];
            A388BAS_InstituteCreator = BC001K12_A388BAS_InstituteCreator[0];
            A389BAS_InstituteCreateTime = BC001K12_A389BAS_InstituteCreateTime[0];
            A390BAS_InstituteModifier = BC001K12_A390BAS_InstituteModifier[0];
            n390BAS_InstituteModifier = BC001K12_n390BAS_InstituteModifier[0];
            A391BAS_InstituteModifyTime = BC001K12_A391BAS_InstituteModifyTime[0];
            n391BAS_InstituteModifyTime = BC001K12_n391BAS_InstituteModifyTime[0];
            A392BAS_InstituteIsDeleted = BC001K12_A392BAS_InstituteIsDeleted[0];
            A393BAS_InstituteDescription = BC001K12_A393BAS_InstituteDescription[0];
            n393BAS_InstituteDescription = BC001K12_n393BAS_InstituteDescription[0];
            A387BAS_InstituteLogo = BC001K12_A387BAS_InstituteLogo[0];
            n387BAS_InstituteLogo = BC001K12_n387BAS_InstituteLogo[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext1K57( )
      {
         /* Scan next routine */
         pr_datastore1.readNext(10);
         RcdFound57 = 0;
         ScanKeyLoad1K57( ) ;
      }

      protected void ScanKeyLoad1K57( )
      {
         sMode57 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_datastore1.getStatus(10) != 101) )
         {
            RcdFound57 = 1;
            A358InstituteCode = BC001K12_A358InstituteCode[0];
            n358InstituteCode = BC001K12_n358InstituteCode[0];
            A386InstituteName = BC001K12_A386InstituteName[0];
            A388BAS_InstituteCreator = BC001K12_A388BAS_InstituteCreator[0];
            A389BAS_InstituteCreateTime = BC001K12_A389BAS_InstituteCreateTime[0];
            A390BAS_InstituteModifier = BC001K12_A390BAS_InstituteModifier[0];
            n390BAS_InstituteModifier = BC001K12_n390BAS_InstituteModifier[0];
            A391BAS_InstituteModifyTime = BC001K12_A391BAS_InstituteModifyTime[0];
            n391BAS_InstituteModifyTime = BC001K12_n391BAS_InstituteModifyTime[0];
            A392BAS_InstituteIsDeleted = BC001K12_A392BAS_InstituteIsDeleted[0];
            A393BAS_InstituteDescription = BC001K12_A393BAS_InstituteDescription[0];
            n393BAS_InstituteDescription = BC001K12_n393BAS_InstituteDescription[0];
            A387BAS_InstituteLogo = BC001K12_A387BAS_InstituteLogo[0];
            n387BAS_InstituteLogo = BC001K12_n387BAS_InstituteLogo[0];
         }
         Gx_mode = sMode57;
      }

      protected void ScanKeyEnd1K57( )
      {
         pr_datastore1.close(10);
      }

      protected void AfterConfirm1K57( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1K57( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1K57( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1K57( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1K57( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1K57( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1K57( )
      {
      }

      protected void send_integrity_lvl_hashes1K57( )
      {
      }

      protected void AddRow1K57( )
      {
         VarsToRow57( bcBAS_Institute) ;
      }

      protected void ReadRow1K57( )
      {
         RowToVars57( bcBAS_Institute, 1) ;
      }

      protected void InitializeNonKey1K57( )
      {
         A386InstituteName = "";
         A387BAS_InstituteLogo = "";
         n387BAS_InstituteLogo = false;
         A388BAS_InstituteCreator = "";
         A389BAS_InstituteCreateTime = (DateTime)(DateTime.MinValue);
         A390BAS_InstituteModifier = "";
         n390BAS_InstituteModifier = false;
         A391BAS_InstituteModifyTime = (DateTime)(DateTime.MinValue);
         n391BAS_InstituteModifyTime = false;
         A392BAS_InstituteIsDeleted = 0;
         A393BAS_InstituteDescription = "";
         n393BAS_InstituteDescription = false;
         Z386InstituteName = "";
         Z388BAS_InstituteCreator = "";
         Z389BAS_InstituteCreateTime = (DateTime)(DateTime.MinValue);
         Z390BAS_InstituteModifier = "";
         Z391BAS_InstituteModifyTime = (DateTime)(DateTime.MinValue);
         Z392BAS_InstituteIsDeleted = 0;
      }

      protected void InitAll1K57( )
      {
         A358InstituteCode = "";
         n358InstituteCode = false;
         InitializeNonKey1K57( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow57( SdtBAS_Institute obj57 )
      {
         obj57.gxTpr_Mode = Gx_mode;
         obj57.gxTpr_Institutename = A386InstituteName;
         obj57.gxTpr_Bas_institutelogo = A387BAS_InstituteLogo;
         obj57.gxTpr_Bas_institutecreator = A388BAS_InstituteCreator;
         obj57.gxTpr_Bas_institutecreatetime = A389BAS_InstituteCreateTime;
         obj57.gxTpr_Bas_institutemodifier = A390BAS_InstituteModifier;
         obj57.gxTpr_Bas_institutemodifytime = A391BAS_InstituteModifyTime;
         obj57.gxTpr_Bas_instituteisdeleted = A392BAS_InstituteIsDeleted;
         obj57.gxTpr_Bas_institutedescription = A393BAS_InstituteDescription;
         obj57.gxTpr_Institutecode = A358InstituteCode;
         obj57.gxTpr_Institutecode_Z = Z358InstituteCode;
         obj57.gxTpr_Institutename_Z = Z386InstituteName;
         obj57.gxTpr_Bas_institutecreator_Z = Z388BAS_InstituteCreator;
         obj57.gxTpr_Bas_institutecreatetime_Z = Z389BAS_InstituteCreateTime;
         obj57.gxTpr_Bas_institutemodifier_Z = Z390BAS_InstituteModifier;
         obj57.gxTpr_Bas_institutemodifytime_Z = Z391BAS_InstituteModifyTime;
         obj57.gxTpr_Bas_instituteisdeleted_Z = Z392BAS_InstituteIsDeleted;
         obj57.gxTpr_Institutecode_N = (short)(Convert.ToInt16(n358InstituteCode));
         obj57.gxTpr_Bas_institutelogo_N = (short)(Convert.ToInt16(n387BAS_InstituteLogo));
         obj57.gxTpr_Bas_institutemodifier_N = (short)(Convert.ToInt16(n390BAS_InstituteModifier));
         obj57.gxTpr_Bas_institutemodifytime_N = (short)(Convert.ToInt16(n391BAS_InstituteModifyTime));
         obj57.gxTpr_Bas_institutedescription_N = (short)(Convert.ToInt16(n393BAS_InstituteDescription));
         obj57.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow57( SdtBAS_Institute obj57 )
      {
         obj57.gxTpr_Institutecode = A358InstituteCode;
         return  ;
      }

      public void RowToVars57( SdtBAS_Institute obj57 ,
                               int forceLoad )
      {
         Gx_mode = obj57.gxTpr_Mode;
         A386InstituteName = obj57.gxTpr_Institutename;
         A387BAS_InstituteLogo = obj57.gxTpr_Bas_institutelogo;
         n387BAS_InstituteLogo = false;
         A388BAS_InstituteCreator = obj57.gxTpr_Bas_institutecreator;
         A389BAS_InstituteCreateTime = obj57.gxTpr_Bas_institutecreatetime;
         A390BAS_InstituteModifier = obj57.gxTpr_Bas_institutemodifier;
         n390BAS_InstituteModifier = false;
         A391BAS_InstituteModifyTime = obj57.gxTpr_Bas_institutemodifytime;
         n391BAS_InstituteModifyTime = false;
         A392BAS_InstituteIsDeleted = obj57.gxTpr_Bas_instituteisdeleted;
         A393BAS_InstituteDescription = obj57.gxTpr_Bas_institutedescription;
         n393BAS_InstituteDescription = false;
         A358InstituteCode = obj57.gxTpr_Institutecode;
         n358InstituteCode = false;
         Z358InstituteCode = obj57.gxTpr_Institutecode_Z;
         Z386InstituteName = obj57.gxTpr_Institutename_Z;
         Z388BAS_InstituteCreator = obj57.gxTpr_Bas_institutecreator_Z;
         Z389BAS_InstituteCreateTime = obj57.gxTpr_Bas_institutecreatetime_Z;
         Z390BAS_InstituteModifier = obj57.gxTpr_Bas_institutemodifier_Z;
         Z391BAS_InstituteModifyTime = obj57.gxTpr_Bas_institutemodifytime_Z;
         Z392BAS_InstituteIsDeleted = obj57.gxTpr_Bas_instituteisdeleted_Z;
         n358InstituteCode = (bool)(Convert.ToBoolean(obj57.gxTpr_Institutecode_N));
         n387BAS_InstituteLogo = (bool)(Convert.ToBoolean(obj57.gxTpr_Bas_institutelogo_N));
         n390BAS_InstituteModifier = (bool)(Convert.ToBoolean(obj57.gxTpr_Bas_institutemodifier_N));
         n391BAS_InstituteModifyTime = (bool)(Convert.ToBoolean(obj57.gxTpr_Bas_institutemodifytime_N));
         n393BAS_InstituteDescription = (bool)(Convert.ToBoolean(obj57.gxTpr_Bas_institutedescription_N));
         Gx_mode = obj57.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A358InstituteCode = (String)getParm(obj,0);
         n358InstituteCode = false;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey1K57( ) ;
         ScanKeyStart1K57( ) ;
         if ( RcdFound57 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z358InstituteCode = A358InstituteCode;
         }
         ZM1K57( -3) ;
         OnLoadActions1K57( ) ;
         AddRow1K57( ) ;
         ScanKeyEnd1K57( ) ;
         if ( RcdFound57 == 0 )
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
         RowToVars57( bcBAS_Institute, 0) ;
         ScanKeyStart1K57( ) ;
         if ( RcdFound57 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z358InstituteCode = A358InstituteCode;
         }
         ZM1K57( -3) ;
         OnLoadActions1K57( ) ;
         AddRow1K57( ) ;
         ScanKeyEnd1K57( ) ;
         if ( RcdFound57 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey1K57( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert1K57( ) ;
         }
         else
         {
            if ( RcdFound57 == 1 )
            {
               if ( StringUtil.StrCmp(A358InstituteCode, Z358InstituteCode) != 0 )
               {
                  A358InstituteCode = Z358InstituteCode;
                  n358InstituteCode = false;
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
                  Update1K57( ) ;
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
                  if ( StringUtil.StrCmp(A358InstituteCode, Z358InstituteCode) != 0 )
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
                        Insert1K57( ) ;
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
                        Insert1K57( ) ;
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
         RowToVars57( bcBAS_Institute, 0) ;
         SaveImpl( ) ;
         VarsToRow57( bcBAS_Institute) ;
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
         RowToVars57( bcBAS_Institute, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert1K57( ) ;
         AfterTrn( ) ;
         VarsToRow57( bcBAS_Institute) ;
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
            SdtBAS_Institute auxBC = new SdtBAS_Institute(context) ;
            auxBC.Load(A358InstituteCode);
            auxBC.UpdateDirties(bcBAS_Institute);
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
         RowToVars57( bcBAS_Institute, 0) ;
         UpdateImpl( ) ;
         VarsToRow57( bcBAS_Institute) ;
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
         RowToVars57( bcBAS_Institute, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert1K57( ) ;
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
         VarsToRow57( bcBAS_Institute) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars57( bcBAS_Institute, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey1K57( ) ;
         if ( RcdFound57 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( StringUtil.StrCmp(A358InstituteCode, Z358InstituteCode) != 0 )
            {
               A358InstituteCode = Z358InstituteCode;
               n358InstituteCode = false;
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
            if ( StringUtil.StrCmp(A358InstituteCode, Z358InstituteCode) != 0 )
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
         context.RollbackDataStores("bas_institute_bc",pr_default);
         VarsToRow57( bcBAS_Institute) ;
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
         Gx_mode = bcBAS_Institute.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcBAS_Institute.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcBAS_Institute )
         {
            bcBAS_Institute = (SdtBAS_Institute)(sdt);
            if ( StringUtil.StrCmp(bcBAS_Institute.gxTpr_Mode, "") == 0 )
            {
               bcBAS_Institute.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow57( bcBAS_Institute) ;
            }
            else
            {
               RowToVars57( bcBAS_Institute, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcBAS_Institute.gxTpr_Mode, "") == 0 )
            {
               bcBAS_Institute.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars57( bcBAS_Institute, 1) ;
         return  ;
      }

      public SdtBAS_Institute BAS_Institute_BC
      {
         get {
            return bcBAS_Institute ;
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
         Z358InstituteCode = "";
         A358InstituteCode = "";
         Z386InstituteName = "";
         A386InstituteName = "";
         Z388BAS_InstituteCreator = "";
         A388BAS_InstituteCreator = "";
         Z389BAS_InstituteCreateTime = (DateTime)(DateTime.MinValue);
         A389BAS_InstituteCreateTime = (DateTime)(DateTime.MinValue);
         Z390BAS_InstituteModifier = "";
         A390BAS_InstituteModifier = "";
         Z391BAS_InstituteModifyTime = (DateTime)(DateTime.MinValue);
         A391BAS_InstituteModifyTime = (DateTime)(DateTime.MinValue);
         Z387BAS_InstituteLogo = "";
         A387BAS_InstituteLogo = "";
         Z393BAS_InstituteDescription = "";
         A393BAS_InstituteDescription = "";
         BC001K4_A358InstituteCode = new String[] {""} ;
         BC001K4_n358InstituteCode = new bool[] {false} ;
         BC001K4_A386InstituteName = new String[] {""} ;
         BC001K4_A388BAS_InstituteCreator = new String[] {""} ;
         BC001K4_A389BAS_InstituteCreateTime = new DateTime[] {DateTime.MinValue} ;
         BC001K4_A390BAS_InstituteModifier = new String[] {""} ;
         BC001K4_n390BAS_InstituteModifier = new bool[] {false} ;
         BC001K4_A391BAS_InstituteModifyTime = new DateTime[] {DateTime.MinValue} ;
         BC001K4_n391BAS_InstituteModifyTime = new bool[] {false} ;
         BC001K4_A392BAS_InstituteIsDeleted = new short[1] ;
         BC001K4_A393BAS_InstituteDescription = new String[] {""} ;
         BC001K4_n393BAS_InstituteDescription = new bool[] {false} ;
         BC001K4_A387BAS_InstituteLogo = new String[] {""} ;
         BC001K4_n387BAS_InstituteLogo = new bool[] {false} ;
         BC001K5_A358InstituteCode = new String[] {""} ;
         BC001K5_n358InstituteCode = new bool[] {false} ;
         BC001K3_A358InstituteCode = new String[] {""} ;
         BC001K3_n358InstituteCode = new bool[] {false} ;
         BC001K3_A386InstituteName = new String[] {""} ;
         BC001K3_A388BAS_InstituteCreator = new String[] {""} ;
         BC001K3_A389BAS_InstituteCreateTime = new DateTime[] {DateTime.MinValue} ;
         BC001K3_A390BAS_InstituteModifier = new String[] {""} ;
         BC001K3_n390BAS_InstituteModifier = new bool[] {false} ;
         BC001K3_A391BAS_InstituteModifyTime = new DateTime[] {DateTime.MinValue} ;
         BC001K3_n391BAS_InstituteModifyTime = new bool[] {false} ;
         BC001K3_A392BAS_InstituteIsDeleted = new short[1] ;
         BC001K3_A393BAS_InstituteDescription = new String[] {""} ;
         BC001K3_n393BAS_InstituteDescription = new bool[] {false} ;
         BC001K3_A387BAS_InstituteLogo = new String[] {""} ;
         BC001K3_n387BAS_InstituteLogo = new bool[] {false} ;
         sMode57 = "";
         BC001K2_A358InstituteCode = new String[] {""} ;
         BC001K2_n358InstituteCode = new bool[] {false} ;
         BC001K2_A386InstituteName = new String[] {""} ;
         BC001K2_A388BAS_InstituteCreator = new String[] {""} ;
         BC001K2_A389BAS_InstituteCreateTime = new DateTime[] {DateTime.MinValue} ;
         BC001K2_A390BAS_InstituteModifier = new String[] {""} ;
         BC001K2_n390BAS_InstituteModifier = new bool[] {false} ;
         BC001K2_A391BAS_InstituteModifyTime = new DateTime[] {DateTime.MinValue} ;
         BC001K2_n391BAS_InstituteModifyTime = new bool[] {false} ;
         BC001K2_A392BAS_InstituteIsDeleted = new short[1] ;
         BC001K2_A393BAS_InstituteDescription = new String[] {""} ;
         BC001K2_n393BAS_InstituteDescription = new bool[] {false} ;
         BC001K2_A387BAS_InstituteLogo = new String[] {""} ;
         BC001K2_n387BAS_InstituteLogo = new bool[] {false} ;
         BC001K10_A360BAS_TenantTenantCode = new String[] {""} ;
         BC001K11_A358InstituteCode = new String[] {""} ;
         BC001K11_n358InstituteCode = new bool[] {false} ;
         BC001K11_A359UserID = new Guid[] {Guid.Empty} ;
         BC001K12_A358InstituteCode = new String[] {""} ;
         BC001K12_n358InstituteCode = new bool[] {false} ;
         BC001K12_A386InstituteName = new String[] {""} ;
         BC001K12_A388BAS_InstituteCreator = new String[] {""} ;
         BC001K12_A389BAS_InstituteCreateTime = new DateTime[] {DateTime.MinValue} ;
         BC001K12_A390BAS_InstituteModifier = new String[] {""} ;
         BC001K12_n390BAS_InstituteModifier = new bool[] {false} ;
         BC001K12_A391BAS_InstituteModifyTime = new DateTime[] {DateTime.MinValue} ;
         BC001K12_n391BAS_InstituteModifyTime = new bool[] {false} ;
         BC001K12_A392BAS_InstituteIsDeleted = new short[1] ;
         BC001K12_A393BAS_InstituteDescription = new String[] {""} ;
         BC001K12_n393BAS_InstituteDescription = new bool[] {false} ;
         BC001K12_A387BAS_InstituteLogo = new String[] {""} ;
         BC001K12_n387BAS_InstituteLogo = new bool[] {false} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.bas_institute_bc__datastore1(),
            new Object[][] {
                new Object[] {
               BC001K2_A358InstituteCode, BC001K2_A386InstituteName, BC001K2_A388BAS_InstituteCreator, BC001K2_A389BAS_InstituteCreateTime, BC001K2_A390BAS_InstituteModifier, BC001K2_n390BAS_InstituteModifier, BC001K2_A391BAS_InstituteModifyTime, BC001K2_n391BAS_InstituteModifyTime, BC001K2_A392BAS_InstituteIsDeleted, BC001K2_A393BAS_InstituteDescription,
               BC001K2_n393BAS_InstituteDescription, BC001K2_A387BAS_InstituteLogo, BC001K2_n387BAS_InstituteLogo
               }
               , new Object[] {
               BC001K3_A358InstituteCode, BC001K3_A386InstituteName, BC001K3_A388BAS_InstituteCreator, BC001K3_A389BAS_InstituteCreateTime, BC001K3_A390BAS_InstituteModifier, BC001K3_n390BAS_InstituteModifier, BC001K3_A391BAS_InstituteModifyTime, BC001K3_n391BAS_InstituteModifyTime, BC001K3_A392BAS_InstituteIsDeleted, BC001K3_A393BAS_InstituteDescription,
               BC001K3_n393BAS_InstituteDescription, BC001K3_A387BAS_InstituteLogo, BC001K3_n387BAS_InstituteLogo
               }
               , new Object[] {
               BC001K4_A358InstituteCode, BC001K4_A386InstituteName, BC001K4_A388BAS_InstituteCreator, BC001K4_A389BAS_InstituteCreateTime, BC001K4_A390BAS_InstituteModifier, BC001K4_n390BAS_InstituteModifier, BC001K4_A391BAS_InstituteModifyTime, BC001K4_n391BAS_InstituteModifyTime, BC001K4_A392BAS_InstituteIsDeleted, BC001K4_A393BAS_InstituteDescription,
               BC001K4_n393BAS_InstituteDescription, BC001K4_A387BAS_InstituteLogo, BC001K4_n387BAS_InstituteLogo
               }
               , new Object[] {
               BC001K5_A358InstituteCode
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
               BC001K10_A360BAS_TenantTenantCode
               }
               , new Object[] {
               BC001K11_A358InstituteCode, BC001K11_A359UserID
               }
               , new Object[] {
               BC001K12_A358InstituteCode, BC001K12_A386InstituteName, BC001K12_A388BAS_InstituteCreator, BC001K12_A389BAS_InstituteCreateTime, BC001K12_A390BAS_InstituteModifier, BC001K12_n390BAS_InstituteModifier, BC001K12_A391BAS_InstituteModifyTime, BC001K12_n391BAS_InstituteModifyTime, BC001K12_A392BAS_InstituteIsDeleted, BC001K12_A393BAS_InstituteDescription,
               BC001K12_n393BAS_InstituteDescription, BC001K12_A387BAS_InstituteLogo, BC001K12_n387BAS_InstituteLogo
               }
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.bas_institute_bc__default(),
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
      private short Z392BAS_InstituteIsDeleted ;
      private short A392BAS_InstituteIsDeleted ;
      private short RcdFound57 ;
      private int trnEnded ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String sMode57 ;
      private DateTime Z389BAS_InstituteCreateTime ;
      private DateTime A389BAS_InstituteCreateTime ;
      private DateTime Z391BAS_InstituteModifyTime ;
      private DateTime A391BAS_InstituteModifyTime ;
      private bool n358InstituteCode ;
      private bool n390BAS_InstituteModifier ;
      private bool n391BAS_InstituteModifyTime ;
      private bool n393BAS_InstituteDescription ;
      private bool n387BAS_InstituteLogo ;
      private bool Gx_longc ;
      private String Z393BAS_InstituteDescription ;
      private String A393BAS_InstituteDescription ;
      private String Z358InstituteCode ;
      private String A358InstituteCode ;
      private String Z386InstituteName ;
      private String A386InstituteName ;
      private String Z388BAS_InstituteCreator ;
      private String A388BAS_InstituteCreator ;
      private String Z390BAS_InstituteModifier ;
      private String A390BAS_InstituteModifier ;
      private String Z387BAS_InstituteLogo ;
      private String A387BAS_InstituteLogo ;
      private SdtBAS_Institute bcBAS_Institute ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_datastore1 ;
      private String[] BC001K4_A358InstituteCode ;
      private bool[] BC001K4_n358InstituteCode ;
      private String[] BC001K4_A386InstituteName ;
      private String[] BC001K4_A388BAS_InstituteCreator ;
      private DateTime[] BC001K4_A389BAS_InstituteCreateTime ;
      private String[] BC001K4_A390BAS_InstituteModifier ;
      private bool[] BC001K4_n390BAS_InstituteModifier ;
      private DateTime[] BC001K4_A391BAS_InstituteModifyTime ;
      private bool[] BC001K4_n391BAS_InstituteModifyTime ;
      private short[] BC001K4_A392BAS_InstituteIsDeleted ;
      private String[] BC001K4_A393BAS_InstituteDescription ;
      private bool[] BC001K4_n393BAS_InstituteDescription ;
      private String[] BC001K4_A387BAS_InstituteLogo ;
      private bool[] BC001K4_n387BAS_InstituteLogo ;
      private String[] BC001K5_A358InstituteCode ;
      private bool[] BC001K5_n358InstituteCode ;
      private String[] BC001K3_A358InstituteCode ;
      private bool[] BC001K3_n358InstituteCode ;
      private String[] BC001K3_A386InstituteName ;
      private String[] BC001K3_A388BAS_InstituteCreator ;
      private DateTime[] BC001K3_A389BAS_InstituteCreateTime ;
      private String[] BC001K3_A390BAS_InstituteModifier ;
      private bool[] BC001K3_n390BAS_InstituteModifier ;
      private DateTime[] BC001K3_A391BAS_InstituteModifyTime ;
      private bool[] BC001K3_n391BAS_InstituteModifyTime ;
      private short[] BC001K3_A392BAS_InstituteIsDeleted ;
      private String[] BC001K3_A393BAS_InstituteDescription ;
      private bool[] BC001K3_n393BAS_InstituteDescription ;
      private String[] BC001K3_A387BAS_InstituteLogo ;
      private bool[] BC001K3_n387BAS_InstituteLogo ;
      private String[] BC001K2_A358InstituteCode ;
      private bool[] BC001K2_n358InstituteCode ;
      private String[] BC001K2_A386InstituteName ;
      private String[] BC001K2_A388BAS_InstituteCreator ;
      private DateTime[] BC001K2_A389BAS_InstituteCreateTime ;
      private String[] BC001K2_A390BAS_InstituteModifier ;
      private bool[] BC001K2_n390BAS_InstituteModifier ;
      private DateTime[] BC001K2_A391BAS_InstituteModifyTime ;
      private bool[] BC001K2_n391BAS_InstituteModifyTime ;
      private short[] BC001K2_A392BAS_InstituteIsDeleted ;
      private String[] BC001K2_A393BAS_InstituteDescription ;
      private bool[] BC001K2_n393BAS_InstituteDescription ;
      private String[] BC001K2_A387BAS_InstituteLogo ;
      private bool[] BC001K2_n387BAS_InstituteLogo ;
      private String[] BC001K10_A360BAS_TenantTenantCode ;
      private String[] BC001K11_A358InstituteCode ;
      private bool[] BC001K11_n358InstituteCode ;
      private Guid[] BC001K11_A359UserID ;
      private String[] BC001K12_A358InstituteCode ;
      private bool[] BC001K12_n358InstituteCode ;
      private String[] BC001K12_A386InstituteName ;
      private String[] BC001K12_A388BAS_InstituteCreator ;
      private DateTime[] BC001K12_A389BAS_InstituteCreateTime ;
      private String[] BC001K12_A390BAS_InstituteModifier ;
      private bool[] BC001K12_n390BAS_InstituteModifier ;
      private DateTime[] BC001K12_A391BAS_InstituteModifyTime ;
      private bool[] BC001K12_n391BAS_InstituteModifyTime ;
      private short[] BC001K12_A392BAS_InstituteIsDeleted ;
      private String[] BC001K12_A393BAS_InstituteDescription ;
      private bool[] BC001K12_n393BAS_InstituteDescription ;
      private String[] BC001K12_A387BAS_InstituteLogo ;
      private bool[] BC001K12_n387BAS_InstituteLogo ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_default ;
   }

   public class bas_institute_bc__datastore1 : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmBC001K4 ;
          prmBC001K4 = new Object[] {
          new Object[] {"@InstituteCode",SqlDbType.NVarChar,20,0}
          } ;
          Object[] prmBC001K5 ;
          prmBC001K5 = new Object[] {
          new Object[] {"@InstituteCode",SqlDbType.NVarChar,20,0}
          } ;
          Object[] prmBC001K3 ;
          prmBC001K3 = new Object[] {
          new Object[] {"@InstituteCode",SqlDbType.NVarChar,20,0}
          } ;
          Object[] prmBC001K2 ;
          prmBC001K2 = new Object[] {
          new Object[] {"@InstituteCode",SqlDbType.NVarChar,20,0}
          } ;
          Object[] prmBC001K6 ;
          prmBC001K6 = new Object[] {
          new Object[] {"@InstituteCode",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@InstituteName",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@BAS_InstituteLogo",SqlDbType.VarBinary,1024,0} ,
          new Object[] {"@BAS_InstituteCreator",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@BAS_InstituteCreateTime",SqlDbType.DateTime,10,8} ,
          new Object[] {"@BAS_InstituteModifier",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@BAS_InstituteModifyTime",SqlDbType.DateTime,10,8} ,
          new Object[] {"@BAS_InstituteIsDeleted",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@BAS_InstituteDescription",SqlDbType.NVarChar,2048,0}
          } ;
          Object[] prmBC001K7 ;
          prmBC001K7 = new Object[] {
          new Object[] {"@InstituteName",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@BAS_InstituteCreator",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@BAS_InstituteCreateTime",SqlDbType.DateTime,10,8} ,
          new Object[] {"@BAS_InstituteModifier",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@BAS_InstituteModifyTime",SqlDbType.DateTime,10,8} ,
          new Object[] {"@BAS_InstituteIsDeleted",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@BAS_InstituteDescription",SqlDbType.NVarChar,2048,0} ,
          new Object[] {"@InstituteCode",SqlDbType.NVarChar,20,0}
          } ;
          Object[] prmBC001K8 ;
          prmBC001K8 = new Object[] {
          new Object[] {"@BAS_InstituteLogo",SqlDbType.VarBinary,1024,0} ,
          new Object[] {"@InstituteCode",SqlDbType.NVarChar,20,0}
          } ;
          Object[] prmBC001K9 ;
          prmBC001K9 = new Object[] {
          new Object[] {"@InstituteCode",SqlDbType.NVarChar,20,0}
          } ;
          Object[] prmBC001K10 ;
          prmBC001K10 = new Object[] {
          new Object[] {"@InstituteCode",SqlDbType.NVarChar,20,0}
          } ;
          Object[] prmBC001K11 ;
          prmBC001K11 = new Object[] {
          new Object[] {"@InstituteCode",SqlDbType.NVarChar,20,0}
          } ;
          Object[] prmBC001K12 ;
          prmBC001K12 = new Object[] {
          new Object[] {"@InstituteCode",SqlDbType.NVarChar,20,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("BC001K2", "SELECT [InstituteCode], [InstituteName], [Creator] AS BAS_InstituteCreator, [CreateTime] AS BAS_InstituteCreateTime, [Modifier] AS BAS_InstituteModifier, [ModifyTime] AS BAS_InstituteModifyTime, [IsDeleted] AS BAS_InstituteIsDeleted, [Description] AS BAS_InstituteDescription, [Logo] AS BAS_InstituteLogo FROM dbo.[BAS_Institute] WITH (UPDLOCK) WHERE [InstituteCode] = @InstituteCode ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001K2,1,0,true,false )
             ,new CursorDef("BC001K3", "SELECT [InstituteCode], [InstituteName], [Creator] AS BAS_InstituteCreator, [CreateTime] AS BAS_InstituteCreateTime, [Modifier] AS BAS_InstituteModifier, [ModifyTime] AS BAS_InstituteModifyTime, [IsDeleted] AS BAS_InstituteIsDeleted, [Description] AS BAS_InstituteDescription, [Logo] AS BAS_InstituteLogo FROM dbo.[BAS_Institute] WITH (NOLOCK) WHERE [InstituteCode] = @InstituteCode ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001K3,1,0,true,false )
             ,new CursorDef("BC001K4", "SELECT TM1.[InstituteCode], TM1.[InstituteName], TM1.[Creator] AS BAS_InstituteCreator, TM1.[CreateTime] AS BAS_InstituteCreateTime, TM1.[Modifier] AS BAS_InstituteModifier, TM1.[ModifyTime] AS BAS_InstituteModifyTime, TM1.[IsDeleted] AS BAS_InstituteIsDeleted, TM1.[Description] AS BAS_InstituteDescription, TM1.[Logo] AS BAS_InstituteLogo FROM dbo.[BAS_Institute] TM1 WITH (NOLOCK) WHERE TM1.[InstituteCode] = @InstituteCode ORDER BY TM1.[InstituteCode]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001K4,100,0,true,false )
             ,new CursorDef("BC001K5", "SELECT [InstituteCode] FROM dbo.[BAS_Institute] WITH (NOLOCK) WHERE [InstituteCode] = @InstituteCode  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001K5,1,0,true,false )
             ,new CursorDef("BC001K6", "INSERT INTO dbo.[BAS_Institute]([InstituteCode], [InstituteName], [Logo], [Creator], [CreateTime], [Modifier], [ModifyTime], [IsDeleted], [Description]) VALUES(@InstituteCode, @InstituteName, @BAS_InstituteLogo, @BAS_InstituteCreator, @BAS_InstituteCreateTime, @BAS_InstituteModifier, @BAS_InstituteModifyTime, @BAS_InstituteIsDeleted, @BAS_InstituteDescription)", GxErrorMask.GX_NOMASK,prmBC001K6)
             ,new CursorDef("BC001K7", "UPDATE dbo.[BAS_Institute] SET [InstituteName]=@InstituteName, [Creator]=@BAS_InstituteCreator, [CreateTime]=@BAS_InstituteCreateTime, [Modifier]=@BAS_InstituteModifier, [ModifyTime]=@BAS_InstituteModifyTime, [IsDeleted]=@BAS_InstituteIsDeleted, [Description]=@BAS_InstituteDescription  WHERE [InstituteCode] = @InstituteCode", GxErrorMask.GX_NOMASK,prmBC001K7)
             ,new CursorDef("BC001K8", "UPDATE dbo.[BAS_Institute] SET [Logo]=@BAS_InstituteLogo  WHERE [InstituteCode] = @InstituteCode", GxErrorMask.GX_NOMASK,prmBC001K8)
             ,new CursorDef("BC001K9", "DELETE FROM dbo.[BAS_Institute]  WHERE [InstituteCode] = @InstituteCode", GxErrorMask.GX_NOMASK,prmBC001K9)
             ,new CursorDef("BC001K10", "SELECT TOP 1 [TenantCode] FROM dbo.[BAS_Tenant] WITH (NOLOCK) WHERE [InstituteCode] = @InstituteCode ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001K10,1,0,true,true )
             ,new CursorDef("BC001K11", "SELECT TOP 1 [InstituteCode], [UserID] FROM dbo.[SYS_InstituteUser] WITH (NOLOCK) WHERE [InstituteCode] = @InstituteCode ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001K11,1,0,true,true )
             ,new CursorDef("BC001K12", "SELECT TM1.[InstituteCode], TM1.[InstituteName], TM1.[Creator] AS BAS_InstituteCreator, TM1.[CreateTime] AS BAS_InstituteCreateTime, TM1.[Modifier] AS BAS_InstituteModifier, TM1.[ModifyTime] AS BAS_InstituteModifyTime, TM1.[IsDeleted] AS BAS_InstituteIsDeleted, TM1.[Description] AS BAS_InstituteDescription, TM1.[Logo] AS BAS_InstituteLogo FROM dbo.[BAS_Institute] TM1 WITH (NOLOCK) WHERE TM1.[InstituteCode] = @InstituteCode ORDER BY TM1.[InstituteCode]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001K12,100,0,true,false )
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
                ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(5);
                ((DateTime[]) buf[6])[0] = rslt.getGXDateTime(6) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(6);
                ((short[]) buf[8])[0] = rslt.getShort(7) ;
                ((String[]) buf[9])[0] = rslt.getLongVarchar(8) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(8);
                ((String[]) buf[11])[0] = rslt.getBLOBFile(9, "tmp", "") ;
                ((bool[]) buf[12])[0] = rslt.wasNull(9);
                return;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(5);
                ((DateTime[]) buf[6])[0] = rslt.getGXDateTime(6) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(6);
                ((short[]) buf[8])[0] = rslt.getShort(7) ;
                ((String[]) buf[9])[0] = rslt.getLongVarchar(8) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(8);
                ((String[]) buf[11])[0] = rslt.getBLOBFile(9, "tmp", "") ;
                ((bool[]) buf[12])[0] = rslt.wasNull(9);
                return;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(5);
                ((DateTime[]) buf[6])[0] = rslt.getGXDateTime(6) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(6);
                ((short[]) buf[8])[0] = rslt.getShort(7) ;
                ((String[]) buf[9])[0] = rslt.getLongVarchar(8) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(8);
                ((String[]) buf[11])[0] = rslt.getBLOBFile(9, "tmp", "") ;
                ((bool[]) buf[12])[0] = rslt.wasNull(9);
                return;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                return;
             case 8 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                return;
             case 9 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((Guid[]) buf[1])[0] = rslt.getGuid(2) ;
                return;
             case 10 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(5);
                ((DateTime[]) buf[6])[0] = rslt.getGXDateTime(6) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(6);
                ((short[]) buf[8])[0] = rslt.getShort(7) ;
                ((String[]) buf[9])[0] = rslt.getLongVarchar(8) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(8);
                ((String[]) buf[11])[0] = rslt.getBLOBFile(9, "tmp", "") ;
                ((bool[]) buf[12])[0] = rslt.wasNull(9);
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
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                return;
             case 4 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                stmt.SetParameter(2, (String)parms[2]);
                if ( (bool)parms[3] )
                {
                   stmt.setNull( 3 , SqlDbType.VarBinary );
                }
                else
                {
                   stmt.SetParameterBlob(3, (String)parms[4], true);
                }
                stmt.SetParameter(4, (String)parms[5]);
                stmt.SetParameterDatetime(5, (DateTime)parms[6]);
                if ( (bool)parms[7] )
                {
                   stmt.setNull( 6 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(6, (String)parms[8]);
                }
                if ( (bool)parms[9] )
                {
                   stmt.setNull( 7 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(7, (DateTime)parms[10]);
                }
                stmt.SetParameter(8, (short)parms[11]);
                if ( (bool)parms[12] )
                {
                   stmt.setNull( 9 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(9, (String)parms[13]);
                }
                return;
             case 5 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameterDatetime(3, (DateTime)parms[2]);
                if ( (bool)parms[3] )
                {
                   stmt.setNull( 4 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(4, (String)parms[4]);
                }
                if ( (bool)parms[5] )
                {
                   stmt.setNull( 5 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(5, (DateTime)parms[6]);
                }
                stmt.SetParameter(6, (short)parms[7]);
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
                   stmt.setNull( 8 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(8, (String)parms[11]);
                }
                return;
             case 6 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.VarBinary );
                }
                else
                {
                   stmt.SetParameterBlob(1, (String)parms[1], true);
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
                   stmt.setNull( 1 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                return;
             case 8 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                return;
             case 9 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                return;
             case 10 :
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

 public class bas_institute_bc__default : DataStoreHelperBase, IDataStoreHelper
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
