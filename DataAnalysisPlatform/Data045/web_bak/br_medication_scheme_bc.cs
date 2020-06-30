/*
               File: BR_Medication_Scheme_BC
        Description: 药物治疗化疗方案0813弃用
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:38:0.48
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
   public class br_medication_scheme_bc : GXHttpHandler, IGxSilentTrn
   {
      public br_medication_scheme_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_medication_scheme_bc( IGxContext context )
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
         ReadRow0V32( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey0V32( ) ;
         standaloneModal( ) ;
         AddRow0V32( ) ;
         Gx_mode = "INS";
         return  ;
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E110V2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               Z296BR_Medication_SchemeID = A296BR_Medication_SchemeID;
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

      protected void CONFIRM_0V0( )
      {
         BeforeValidate0V32( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0V32( ) ;
            }
            else
            {
               CheckExtendedTable0V32( ) ;
               if ( AnyError == 0 )
               {
                  ZM0V32( 7) ;
               }
               CloseExtendedTableCursors0V32( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void E120V2( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV8WWPContext) ;
         AV9IsAuthorized = true;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWBR_Medication_Scheme_Insert", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWBR_Medication_Scheme_Update", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWBR_Medication_Scheme_Delete", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
         }
         if ( ! AV9IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV16Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         /* Execute user subroutine: 'ATTRIBUTESSECURITYCODE' */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         AV11TrnContext.FromXml(AV12WebSession.Get("TrnContext"), null, "WWPTransactionContext", "DataAnalysisPlatform");
         if ( ( StringUtil.StrCmp(AV11TrnContext.gxTpr_Transactionname, AV16Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV17GXV1 = 1;
            while ( AV17GXV1 <= AV11TrnContext.gxTpr_Attributes.Count )
            {
               AV14TrnContextAtt = ((GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute)AV11TrnContext.gxTpr_Attributes.Item(AV17GXV1));
               if ( StringUtil.StrCmp(AV14TrnContextAtt.gxTpr_Attributename, "BR_MedicationID") == 0 )
               {
                  AV13Insert_BR_MedicationID = (long)(NumberUtil.Val( AV14TrnContextAtt.gxTpr_Attributevalue, "."));
               }
               AV17GXV1 = (int)(AV17GXV1+1);
            }
         }
      }

      protected void E110V2( )
      {
         /* After Trn Routine */
      }

      protected void S112( )
      {
         /* 'ATTRIBUTESSECURITYCODE' Routine */
      }

      protected void ZM0V32( short GX_JID )
      {
         if ( ( GX_JID == 6 ) || ( GX_JID == 0 ) )
         {
            Z305BR_Medication_Chem_Name = A305BR_Medication_Chem_Name;
            Z306BR_Medication_Chem_Cycle = A306BR_Medication_Chem_Cycle;
            Z307BR_Medication_Chem_Line = A307BR_Medication_Chem_Line;
            Z313BR_Medication_Chem_Detail = A313BR_Medication_Chem_Detail;
            Z119BR_MedicationID = A119BR_MedicationID;
         }
         if ( ( GX_JID == 7 ) || ( GX_JID == 0 ) )
         {
         }
         if ( GX_JID == -6 )
         {
            Z296BR_Medication_SchemeID = A296BR_Medication_SchemeID;
            Z305BR_Medication_Chem_Name = A305BR_Medication_Chem_Name;
            Z306BR_Medication_Chem_Cycle = A306BR_Medication_Chem_Cycle;
            Z307BR_Medication_Chem_Line = A307BR_Medication_Chem_Line;
            Z313BR_Medication_Chem_Detail = A313BR_Medication_Chem_Detail;
            Z119BR_MedicationID = A119BR_MedicationID;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load0V32( )
      {
         /* Using cursor BC000V5 */
         pr_default.execute(3, new Object[] {n296BR_Medication_SchemeID, A296BR_Medication_SchemeID});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound32 = 1;
            A305BR_Medication_Chem_Name = BC000V5_A305BR_Medication_Chem_Name[0];
            n305BR_Medication_Chem_Name = BC000V5_n305BR_Medication_Chem_Name[0];
            A306BR_Medication_Chem_Cycle = BC000V5_A306BR_Medication_Chem_Cycle[0];
            n306BR_Medication_Chem_Cycle = BC000V5_n306BR_Medication_Chem_Cycle[0];
            A307BR_Medication_Chem_Line = BC000V5_A307BR_Medication_Chem_Line[0];
            n307BR_Medication_Chem_Line = BC000V5_n307BR_Medication_Chem_Line[0];
            A313BR_Medication_Chem_Detail = BC000V5_A313BR_Medication_Chem_Detail[0];
            n313BR_Medication_Chem_Detail = BC000V5_n313BR_Medication_Chem_Detail[0];
            A119BR_MedicationID = BC000V5_A119BR_MedicationID[0];
            n119BR_MedicationID = BC000V5_n119BR_MedicationID[0];
            ZM0V32( -6) ;
         }
         pr_default.close(3);
         OnLoadActions0V32( ) ;
      }

      protected void OnLoadActions0V32( )
      {
         AV16Pgmname = "BR_Medication_Scheme_BC";
      }

      protected void CheckExtendedTable0V32( )
      {
         standaloneModal( ) ;
         AV16Pgmname = "BR_Medication_Scheme_BC";
         /* Using cursor BC000V4 */
         pr_default.execute(2, new Object[] {n119BR_MedicationID, A119BR_MedicationID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            if ( ! ( (0==A119BR_MedicationID) ) )
            {
               GX_msglist.addItem("不匹配' T18'", "ForeignKeyNotFound", 1, "BR_MEDICATIONID");
               AnyError = 1;
            }
         }
         pr_default.close(2);
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A305BR_Medication_Chem_Name)) )
         {
            GX_msglist.addItem("化疗方案名称是必须填写的。", 1, "");
            AnyError = 1;
         }
      }

      protected void CloseExtendedTableCursors0V32( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0V32( )
      {
         /* Using cursor BC000V6 */
         pr_default.execute(4, new Object[] {n296BR_Medication_SchemeID, A296BR_Medication_SchemeID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound32 = 1;
         }
         else
         {
            RcdFound32 = 0;
         }
         pr_default.close(4);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC000V3 */
         pr_default.execute(1, new Object[] {n296BR_Medication_SchemeID, A296BR_Medication_SchemeID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0V32( 6) ;
            RcdFound32 = 1;
            A296BR_Medication_SchemeID = BC000V3_A296BR_Medication_SchemeID[0];
            n296BR_Medication_SchemeID = BC000V3_n296BR_Medication_SchemeID[0];
            A305BR_Medication_Chem_Name = BC000V3_A305BR_Medication_Chem_Name[0];
            n305BR_Medication_Chem_Name = BC000V3_n305BR_Medication_Chem_Name[0];
            A306BR_Medication_Chem_Cycle = BC000V3_A306BR_Medication_Chem_Cycle[0];
            n306BR_Medication_Chem_Cycle = BC000V3_n306BR_Medication_Chem_Cycle[0];
            A307BR_Medication_Chem_Line = BC000V3_A307BR_Medication_Chem_Line[0];
            n307BR_Medication_Chem_Line = BC000V3_n307BR_Medication_Chem_Line[0];
            A313BR_Medication_Chem_Detail = BC000V3_A313BR_Medication_Chem_Detail[0];
            n313BR_Medication_Chem_Detail = BC000V3_n313BR_Medication_Chem_Detail[0];
            A119BR_MedicationID = BC000V3_A119BR_MedicationID[0];
            n119BR_MedicationID = BC000V3_n119BR_MedicationID[0];
            Z296BR_Medication_SchemeID = A296BR_Medication_SchemeID;
            sMode32 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load0V32( ) ;
            if ( AnyError == 1 )
            {
               RcdFound32 = 0;
               InitializeNonKey0V32( ) ;
            }
            Gx_mode = sMode32;
         }
         else
         {
            RcdFound32 = 0;
            InitializeNonKey0V32( ) ;
            sMode32 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode32;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0V32( ) ;
         if ( RcdFound32 == 0 )
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
         CONFIRM_0V0( ) ;
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

      protected void CheckOptimisticConcurrency0V32( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC000V2 */
            pr_default.execute(0, new Object[] {n296BR_Medication_SchemeID, A296BR_Medication_SchemeID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Medication_Scheme"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z305BR_Medication_Chem_Name, BC000V2_A305BR_Medication_Chem_Name[0]) != 0 ) || ( Z306BR_Medication_Chem_Cycle != BC000V2_A306BR_Medication_Chem_Cycle[0] ) || ( StringUtil.StrCmp(Z307BR_Medication_Chem_Line, BC000V2_A307BR_Medication_Chem_Line[0]) != 0 ) || ( StringUtil.StrCmp(Z313BR_Medication_Chem_Detail, BC000V2_A313BR_Medication_Chem_Detail[0]) != 0 ) || ( Z119BR_MedicationID != BC000V2_A119BR_MedicationID[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"BR_Medication_Scheme"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0V32( )
      {
         BeforeValidate0V32( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0V32( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0V32( 0) ;
            CheckOptimisticConcurrency0V32( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0V32( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0V32( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000V7 */
                     pr_default.execute(5, new Object[] {n305BR_Medication_Chem_Name, A305BR_Medication_Chem_Name, n306BR_Medication_Chem_Cycle, A306BR_Medication_Chem_Cycle, n307BR_Medication_Chem_Line, A307BR_Medication_Chem_Line, n313BR_Medication_Chem_Detail, A313BR_Medication_Chem_Detail, n119BR_MedicationID, A119BR_MedicationID});
                     A296BR_Medication_SchemeID = BC000V7_A296BR_Medication_SchemeID[0];
                     n296BR_Medication_SchemeID = BC000V7_n296BR_Medication_SchemeID[0];
                     pr_default.close(5);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Medication_Scheme") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A119BR_MedicationID), 18, 0)),  "药物治疗",  StringUtil.Trim( StringUtil.Str( (decimal)(A296BR_Medication_SchemeID), 18, 0)),  "化疗方案",  "Create",  1) ;
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
               Load0V32( ) ;
            }
            EndLevel0V32( ) ;
         }
         CloseExtendedTableCursors0V32( ) ;
      }

      protected void Update0V32( )
      {
         BeforeValidate0V32( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0V32( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0V32( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0V32( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0V32( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000V8 */
                     pr_default.execute(6, new Object[] {n305BR_Medication_Chem_Name, A305BR_Medication_Chem_Name, n306BR_Medication_Chem_Cycle, A306BR_Medication_Chem_Cycle, n307BR_Medication_Chem_Line, A307BR_Medication_Chem_Line, n313BR_Medication_Chem_Detail, A313BR_Medication_Chem_Detail, n119BR_MedicationID, A119BR_MedicationID, n296BR_Medication_SchemeID, A296BR_Medication_SchemeID});
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Medication_Scheme") ;
                     if ( (pr_default.getStatus(6) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Medication_Scheme"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0V32( ) ;
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
            EndLevel0V32( ) ;
         }
         CloseExtendedTableCursors0V32( ) ;
      }

      protected void DeferredUpdate0V32( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate0V32( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0V32( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0V32( ) ;
            AfterConfirm0V32( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0V32( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC000V9 */
                  pr_default.execute(7, new Object[] {n296BR_Medication_SchemeID, A296BR_Medication_SchemeID});
                  pr_default.close(7);
                  dsDefault.SmartCacheProvider.SetUpdated("BR_Medication_Scheme") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A119BR_MedicationID), 18, 0)),  "药物治疗",  StringUtil.Trim( StringUtil.Str( (decimal)(A296BR_Medication_SchemeID), 18, 0)),  "化疗方案",  "Delete",  1) ;
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
         sMode32 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel0V32( ) ;
         Gx_mode = sMode32;
      }

      protected void OnDeleteControls0V32( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV16Pgmname = "BR_Medication_Scheme_BC";
         }
         if ( AnyError == 0 )
         {
            /* Using cursor BC000V10 */
            pr_default.execute(8, new Object[] {n296BR_Medication_SchemeID, A296BR_Medication_SchemeID});
            if ( (pr_default.getStatus(8) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {" T31"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(8);
         }
      }

      protected void EndLevel0V32( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0V32( ) ;
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

      public void ScanKeyStart0V32( )
      {
         /* Scan By routine */
         /* Using cursor BC000V11 */
         pr_default.execute(9, new Object[] {n296BR_Medication_SchemeID, A296BR_Medication_SchemeID});
         RcdFound32 = 0;
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound32 = 1;
            A296BR_Medication_SchemeID = BC000V11_A296BR_Medication_SchemeID[0];
            n296BR_Medication_SchemeID = BC000V11_n296BR_Medication_SchemeID[0];
            A305BR_Medication_Chem_Name = BC000V11_A305BR_Medication_Chem_Name[0];
            n305BR_Medication_Chem_Name = BC000V11_n305BR_Medication_Chem_Name[0];
            A306BR_Medication_Chem_Cycle = BC000V11_A306BR_Medication_Chem_Cycle[0];
            n306BR_Medication_Chem_Cycle = BC000V11_n306BR_Medication_Chem_Cycle[0];
            A307BR_Medication_Chem_Line = BC000V11_A307BR_Medication_Chem_Line[0];
            n307BR_Medication_Chem_Line = BC000V11_n307BR_Medication_Chem_Line[0];
            A313BR_Medication_Chem_Detail = BC000V11_A313BR_Medication_Chem_Detail[0];
            n313BR_Medication_Chem_Detail = BC000V11_n313BR_Medication_Chem_Detail[0];
            A119BR_MedicationID = BC000V11_A119BR_MedicationID[0];
            n119BR_MedicationID = BC000V11_n119BR_MedicationID[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext0V32( )
      {
         /* Scan next routine */
         pr_default.readNext(9);
         RcdFound32 = 0;
         ScanKeyLoad0V32( ) ;
      }

      protected void ScanKeyLoad0V32( )
      {
         sMode32 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound32 = 1;
            A296BR_Medication_SchemeID = BC000V11_A296BR_Medication_SchemeID[0];
            n296BR_Medication_SchemeID = BC000V11_n296BR_Medication_SchemeID[0];
            A305BR_Medication_Chem_Name = BC000V11_A305BR_Medication_Chem_Name[0];
            n305BR_Medication_Chem_Name = BC000V11_n305BR_Medication_Chem_Name[0];
            A306BR_Medication_Chem_Cycle = BC000V11_A306BR_Medication_Chem_Cycle[0];
            n306BR_Medication_Chem_Cycle = BC000V11_n306BR_Medication_Chem_Cycle[0];
            A307BR_Medication_Chem_Line = BC000V11_A307BR_Medication_Chem_Line[0];
            n307BR_Medication_Chem_Line = BC000V11_n307BR_Medication_Chem_Line[0];
            A313BR_Medication_Chem_Detail = BC000V11_A313BR_Medication_Chem_Detail[0];
            n313BR_Medication_Chem_Detail = BC000V11_n313BR_Medication_Chem_Detail[0];
            A119BR_MedicationID = BC000V11_A119BR_MedicationID[0];
            n119BR_MedicationID = BC000V11_n119BR_MedicationID[0];
         }
         Gx_mode = sMode32;
      }

      protected void ScanKeyEnd0V32( )
      {
         pr_default.close(9);
      }

      protected void AfterConfirm0V32( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0V32( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0V32( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0V32( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0V32( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0V32( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0V32( )
      {
      }

      protected void send_integrity_lvl_hashes0V32( )
      {
      }

      protected void AddRow0V32( )
      {
         VarsToRow32( bcBR_Medication_Scheme) ;
      }

      protected void ReadRow0V32( )
      {
         RowToVars32( bcBR_Medication_Scheme, 1) ;
      }

      protected void InitializeNonKey0V32( )
      {
         A119BR_MedicationID = 0;
         n119BR_MedicationID = false;
         A305BR_Medication_Chem_Name = "";
         n305BR_Medication_Chem_Name = false;
         A306BR_Medication_Chem_Cycle = 0;
         n306BR_Medication_Chem_Cycle = false;
         A307BR_Medication_Chem_Line = "";
         n307BR_Medication_Chem_Line = false;
         A313BR_Medication_Chem_Detail = "";
         n313BR_Medication_Chem_Detail = false;
         Z305BR_Medication_Chem_Name = "";
         Z306BR_Medication_Chem_Cycle = 0;
         Z307BR_Medication_Chem_Line = "";
         Z313BR_Medication_Chem_Detail = "";
         Z119BR_MedicationID = 0;
      }

      protected void InitAll0V32( )
      {
         A296BR_Medication_SchemeID = 0;
         n296BR_Medication_SchemeID = false;
         InitializeNonKey0V32( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow32( SdtBR_Medication_Scheme obj32 )
      {
         obj32.gxTpr_Mode = Gx_mode;
         obj32.gxTpr_Br_medicationid = A119BR_MedicationID;
         obj32.gxTpr_Br_medication_chem_name = A305BR_Medication_Chem_Name;
         obj32.gxTpr_Br_medication_chem_cycle = A306BR_Medication_Chem_Cycle;
         obj32.gxTpr_Br_medication_chem_line = A307BR_Medication_Chem_Line;
         obj32.gxTpr_Br_medication_chem_detail = A313BR_Medication_Chem_Detail;
         obj32.gxTpr_Br_medication_schemeid = A296BR_Medication_SchemeID;
         obj32.gxTpr_Br_medication_schemeid_Z = Z296BR_Medication_SchemeID;
         obj32.gxTpr_Br_medicationid_Z = Z119BR_MedicationID;
         obj32.gxTpr_Br_medication_chem_name_Z = Z305BR_Medication_Chem_Name;
         obj32.gxTpr_Br_medication_chem_cycle_Z = Z306BR_Medication_Chem_Cycle;
         obj32.gxTpr_Br_medication_chem_line_Z = Z307BR_Medication_Chem_Line;
         obj32.gxTpr_Br_medication_chem_detail_Z = Z313BR_Medication_Chem_Detail;
         obj32.gxTpr_Br_medication_schemeid_N = (short)(Convert.ToInt16(n296BR_Medication_SchemeID));
         obj32.gxTpr_Br_medicationid_N = (short)(Convert.ToInt16(n119BR_MedicationID));
         obj32.gxTpr_Br_medication_chem_name_N = (short)(Convert.ToInt16(n305BR_Medication_Chem_Name));
         obj32.gxTpr_Br_medication_chem_cycle_N = (short)(Convert.ToInt16(n306BR_Medication_Chem_Cycle));
         obj32.gxTpr_Br_medication_chem_line_N = (short)(Convert.ToInt16(n307BR_Medication_Chem_Line));
         obj32.gxTpr_Br_medication_chem_detail_N = (short)(Convert.ToInt16(n313BR_Medication_Chem_Detail));
         obj32.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow32( SdtBR_Medication_Scheme obj32 )
      {
         obj32.gxTpr_Br_medication_schemeid = A296BR_Medication_SchemeID;
         return  ;
      }

      public void RowToVars32( SdtBR_Medication_Scheme obj32 ,
                               int forceLoad )
      {
         Gx_mode = obj32.gxTpr_Mode;
         A119BR_MedicationID = obj32.gxTpr_Br_medicationid;
         n119BR_MedicationID = false;
         A305BR_Medication_Chem_Name = obj32.gxTpr_Br_medication_chem_name;
         n305BR_Medication_Chem_Name = false;
         A306BR_Medication_Chem_Cycle = obj32.gxTpr_Br_medication_chem_cycle;
         n306BR_Medication_Chem_Cycle = false;
         A307BR_Medication_Chem_Line = obj32.gxTpr_Br_medication_chem_line;
         n307BR_Medication_Chem_Line = false;
         A313BR_Medication_Chem_Detail = obj32.gxTpr_Br_medication_chem_detail;
         n313BR_Medication_Chem_Detail = false;
         A296BR_Medication_SchemeID = obj32.gxTpr_Br_medication_schemeid;
         n296BR_Medication_SchemeID = false;
         Z296BR_Medication_SchemeID = obj32.gxTpr_Br_medication_schemeid_Z;
         Z119BR_MedicationID = obj32.gxTpr_Br_medicationid_Z;
         Z305BR_Medication_Chem_Name = obj32.gxTpr_Br_medication_chem_name_Z;
         Z306BR_Medication_Chem_Cycle = obj32.gxTpr_Br_medication_chem_cycle_Z;
         Z307BR_Medication_Chem_Line = obj32.gxTpr_Br_medication_chem_line_Z;
         Z313BR_Medication_Chem_Detail = obj32.gxTpr_Br_medication_chem_detail_Z;
         n296BR_Medication_SchemeID = (bool)(Convert.ToBoolean(obj32.gxTpr_Br_medication_schemeid_N));
         n119BR_MedicationID = (bool)(Convert.ToBoolean(obj32.gxTpr_Br_medicationid_N));
         n305BR_Medication_Chem_Name = (bool)(Convert.ToBoolean(obj32.gxTpr_Br_medication_chem_name_N));
         n306BR_Medication_Chem_Cycle = (bool)(Convert.ToBoolean(obj32.gxTpr_Br_medication_chem_cycle_N));
         n307BR_Medication_Chem_Line = (bool)(Convert.ToBoolean(obj32.gxTpr_Br_medication_chem_line_N));
         n313BR_Medication_Chem_Detail = (bool)(Convert.ToBoolean(obj32.gxTpr_Br_medication_chem_detail_N));
         Gx_mode = obj32.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A296BR_Medication_SchemeID = (long)getParm(obj,0);
         n296BR_Medication_SchemeID = false;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey0V32( ) ;
         ScanKeyStart0V32( ) ;
         if ( RcdFound32 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z296BR_Medication_SchemeID = A296BR_Medication_SchemeID;
         }
         ZM0V32( -6) ;
         OnLoadActions0V32( ) ;
         AddRow0V32( ) ;
         ScanKeyEnd0V32( ) ;
         if ( RcdFound32 == 0 )
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
         RowToVars32( bcBR_Medication_Scheme, 0) ;
         ScanKeyStart0V32( ) ;
         if ( RcdFound32 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z296BR_Medication_SchemeID = A296BR_Medication_SchemeID;
         }
         ZM0V32( -6) ;
         OnLoadActions0V32( ) ;
         AddRow0V32( ) ;
         ScanKeyEnd0V32( ) ;
         if ( RcdFound32 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey0V32( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert0V32( ) ;
         }
         else
         {
            if ( RcdFound32 == 1 )
            {
               if ( A296BR_Medication_SchemeID != Z296BR_Medication_SchemeID )
               {
                  A296BR_Medication_SchemeID = Z296BR_Medication_SchemeID;
                  n296BR_Medication_SchemeID = false;
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
                  Update0V32( ) ;
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
                  if ( A296BR_Medication_SchemeID != Z296BR_Medication_SchemeID )
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
                        Insert0V32( ) ;
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
                        Insert0V32( ) ;
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
         RowToVars32( bcBR_Medication_Scheme, 0) ;
         SaveImpl( ) ;
         VarsToRow32( bcBR_Medication_Scheme) ;
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
         RowToVars32( bcBR_Medication_Scheme, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert0V32( ) ;
         AfterTrn( ) ;
         VarsToRow32( bcBR_Medication_Scheme) ;
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
            SdtBR_Medication_Scheme auxBC = new SdtBR_Medication_Scheme(context) ;
            auxBC.Load(A296BR_Medication_SchemeID);
            auxBC.UpdateDirties(bcBR_Medication_Scheme);
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
         RowToVars32( bcBR_Medication_Scheme, 0) ;
         UpdateImpl( ) ;
         VarsToRow32( bcBR_Medication_Scheme) ;
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
         RowToVars32( bcBR_Medication_Scheme, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert0V32( ) ;
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
         VarsToRow32( bcBR_Medication_Scheme) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars32( bcBR_Medication_Scheme, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey0V32( ) ;
         if ( RcdFound32 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A296BR_Medication_SchemeID != Z296BR_Medication_SchemeID )
            {
               A296BR_Medication_SchemeID = Z296BR_Medication_SchemeID;
               n296BR_Medication_SchemeID = false;
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
            if ( A296BR_Medication_SchemeID != Z296BR_Medication_SchemeID )
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
         context.RollbackDataStores("br_medication_scheme_bc",pr_default);
         VarsToRow32( bcBR_Medication_Scheme) ;
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
         Gx_mode = bcBR_Medication_Scheme.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcBR_Medication_Scheme.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcBR_Medication_Scheme )
         {
            bcBR_Medication_Scheme = (SdtBR_Medication_Scheme)(sdt);
            if ( StringUtil.StrCmp(bcBR_Medication_Scheme.gxTpr_Mode, "") == 0 )
            {
               bcBR_Medication_Scheme.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow32( bcBR_Medication_Scheme) ;
            }
            else
            {
               RowToVars32( bcBR_Medication_Scheme, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcBR_Medication_Scheme.gxTpr_Mode, "") == 0 )
            {
               bcBR_Medication_Scheme.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars32( bcBR_Medication_Scheme, 1) ;
         return  ;
      }

      public SdtBR_Medication_Scheme BR_Medication_Scheme_BC
      {
         get {
            return bcBR_Medication_Scheme ;
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
      }

      public override void initialize( )
      {
         scmdbuf = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Gx_mode = "";
         AV8WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV16Pgmname = "";
         AV11TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV12WebSession = context.GetSession();
         AV14TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         Z305BR_Medication_Chem_Name = "";
         A305BR_Medication_Chem_Name = "";
         Z307BR_Medication_Chem_Line = "";
         A307BR_Medication_Chem_Line = "";
         Z313BR_Medication_Chem_Detail = "";
         A313BR_Medication_Chem_Detail = "";
         BC000V5_A296BR_Medication_SchemeID = new long[1] ;
         BC000V5_n296BR_Medication_SchemeID = new bool[] {false} ;
         BC000V5_A305BR_Medication_Chem_Name = new String[] {""} ;
         BC000V5_n305BR_Medication_Chem_Name = new bool[] {false} ;
         BC000V5_A306BR_Medication_Chem_Cycle = new decimal[1] ;
         BC000V5_n306BR_Medication_Chem_Cycle = new bool[] {false} ;
         BC000V5_A307BR_Medication_Chem_Line = new String[] {""} ;
         BC000V5_n307BR_Medication_Chem_Line = new bool[] {false} ;
         BC000V5_A313BR_Medication_Chem_Detail = new String[] {""} ;
         BC000V5_n313BR_Medication_Chem_Detail = new bool[] {false} ;
         BC000V5_A119BR_MedicationID = new long[1] ;
         BC000V5_n119BR_MedicationID = new bool[] {false} ;
         BC000V4_A119BR_MedicationID = new long[1] ;
         BC000V4_n119BR_MedicationID = new bool[] {false} ;
         BC000V6_A296BR_Medication_SchemeID = new long[1] ;
         BC000V6_n296BR_Medication_SchemeID = new bool[] {false} ;
         BC000V3_A296BR_Medication_SchemeID = new long[1] ;
         BC000V3_n296BR_Medication_SchemeID = new bool[] {false} ;
         BC000V3_A305BR_Medication_Chem_Name = new String[] {""} ;
         BC000V3_n305BR_Medication_Chem_Name = new bool[] {false} ;
         BC000V3_A306BR_Medication_Chem_Cycle = new decimal[1] ;
         BC000V3_n306BR_Medication_Chem_Cycle = new bool[] {false} ;
         BC000V3_A307BR_Medication_Chem_Line = new String[] {""} ;
         BC000V3_n307BR_Medication_Chem_Line = new bool[] {false} ;
         BC000V3_A313BR_Medication_Chem_Detail = new String[] {""} ;
         BC000V3_n313BR_Medication_Chem_Detail = new bool[] {false} ;
         BC000V3_A119BR_MedicationID = new long[1] ;
         BC000V3_n119BR_MedicationID = new bool[] {false} ;
         sMode32 = "";
         BC000V2_A296BR_Medication_SchemeID = new long[1] ;
         BC000V2_n296BR_Medication_SchemeID = new bool[] {false} ;
         BC000V2_A305BR_Medication_Chem_Name = new String[] {""} ;
         BC000V2_n305BR_Medication_Chem_Name = new bool[] {false} ;
         BC000V2_A306BR_Medication_Chem_Cycle = new decimal[1] ;
         BC000V2_n306BR_Medication_Chem_Cycle = new bool[] {false} ;
         BC000V2_A307BR_Medication_Chem_Line = new String[] {""} ;
         BC000V2_n307BR_Medication_Chem_Line = new bool[] {false} ;
         BC000V2_A313BR_Medication_Chem_Detail = new String[] {""} ;
         BC000V2_n313BR_Medication_Chem_Detail = new bool[] {false} ;
         BC000V2_A119BR_MedicationID = new long[1] ;
         BC000V2_n119BR_MedicationID = new bool[] {false} ;
         BC000V7_A296BR_Medication_SchemeID = new long[1] ;
         BC000V7_n296BR_Medication_SchemeID = new bool[] {false} ;
         BC000V10_A301BR_Medication_DetailID = new long[1] ;
         BC000V11_A296BR_Medication_SchemeID = new long[1] ;
         BC000V11_n296BR_Medication_SchemeID = new bool[] {false} ;
         BC000V11_A305BR_Medication_Chem_Name = new String[] {""} ;
         BC000V11_n305BR_Medication_Chem_Name = new bool[] {false} ;
         BC000V11_A306BR_Medication_Chem_Cycle = new decimal[1] ;
         BC000V11_n306BR_Medication_Chem_Cycle = new bool[] {false} ;
         BC000V11_A307BR_Medication_Chem_Line = new String[] {""} ;
         BC000V11_n307BR_Medication_Chem_Line = new bool[] {false} ;
         BC000V11_A313BR_Medication_Chem_Detail = new String[] {""} ;
         BC000V11_n313BR_Medication_Chem_Detail = new bool[] {false} ;
         BC000V11_A119BR_MedicationID = new long[1] ;
         BC000V11_n119BR_MedicationID = new bool[] {false} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_medication_scheme_bc__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_medication_scheme_bc__default(),
            new Object[][] {
                new Object[] {
               BC000V2_A296BR_Medication_SchemeID, BC000V2_A305BR_Medication_Chem_Name, BC000V2_n305BR_Medication_Chem_Name, BC000V2_A306BR_Medication_Chem_Cycle, BC000V2_n306BR_Medication_Chem_Cycle, BC000V2_A307BR_Medication_Chem_Line, BC000V2_n307BR_Medication_Chem_Line, BC000V2_A313BR_Medication_Chem_Detail, BC000V2_n313BR_Medication_Chem_Detail, BC000V2_A119BR_MedicationID,
               BC000V2_n119BR_MedicationID
               }
               , new Object[] {
               BC000V3_A296BR_Medication_SchemeID, BC000V3_A305BR_Medication_Chem_Name, BC000V3_n305BR_Medication_Chem_Name, BC000V3_A306BR_Medication_Chem_Cycle, BC000V3_n306BR_Medication_Chem_Cycle, BC000V3_A307BR_Medication_Chem_Line, BC000V3_n307BR_Medication_Chem_Line, BC000V3_A313BR_Medication_Chem_Detail, BC000V3_n313BR_Medication_Chem_Detail, BC000V3_A119BR_MedicationID,
               BC000V3_n119BR_MedicationID
               }
               , new Object[] {
               BC000V4_A119BR_MedicationID
               }
               , new Object[] {
               BC000V5_A296BR_Medication_SchemeID, BC000V5_A305BR_Medication_Chem_Name, BC000V5_n305BR_Medication_Chem_Name, BC000V5_A306BR_Medication_Chem_Cycle, BC000V5_n306BR_Medication_Chem_Cycle, BC000V5_A307BR_Medication_Chem_Line, BC000V5_n307BR_Medication_Chem_Line, BC000V5_A313BR_Medication_Chem_Detail, BC000V5_n313BR_Medication_Chem_Detail, BC000V5_A119BR_MedicationID,
               BC000V5_n119BR_MedicationID
               }
               , new Object[] {
               BC000V6_A296BR_Medication_SchemeID
               }
               , new Object[] {
               BC000V7_A296BR_Medication_SchemeID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000V10_A301BR_Medication_DetailID
               }
               , new Object[] {
               BC000V11_A296BR_Medication_SchemeID, BC000V11_A305BR_Medication_Chem_Name, BC000V11_n305BR_Medication_Chem_Name, BC000V11_A306BR_Medication_Chem_Cycle, BC000V11_n306BR_Medication_Chem_Cycle, BC000V11_A307BR_Medication_Chem_Line, BC000V11_n307BR_Medication_Chem_Line, BC000V11_A313BR_Medication_Chem_Detail, BC000V11_n313BR_Medication_Chem_Detail, BC000V11_A119BR_MedicationID,
               BC000V11_n119BR_MedicationID
               }
            }
         );
         AV16Pgmname = "BR_Medication_Scheme_BC";
         INITTRN();
         /* Execute Start event if defined. */
         /* Execute user event: Start */
         E120V2 ();
         standaloneNotModal( ) ;
      }

      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short GX_JID ;
      private short RcdFound32 ;
      private int trnEnded ;
      private int AV17GXV1 ;
      private long Z296BR_Medication_SchemeID ;
      private long A296BR_Medication_SchemeID ;
      private long AV13Insert_BR_MedicationID ;
      private long Z119BR_MedicationID ;
      private long A119BR_MedicationID ;
      private decimal Z306BR_Medication_Chem_Cycle ;
      private decimal A306BR_Medication_Chem_Cycle ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String AV16Pgmname ;
      private String sMode32 ;
      private bool AV9IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool returnInSub ;
      private bool n296BR_Medication_SchemeID ;
      private bool n305BR_Medication_Chem_Name ;
      private bool n306BR_Medication_Chem_Cycle ;
      private bool n307BR_Medication_Chem_Line ;
      private bool n313BR_Medication_Chem_Detail ;
      private bool n119BR_MedicationID ;
      private String Z305BR_Medication_Chem_Name ;
      private String A305BR_Medication_Chem_Name ;
      private String Z307BR_Medication_Chem_Line ;
      private String A307BR_Medication_Chem_Line ;
      private String Z313BR_Medication_Chem_Detail ;
      private String A313BR_Medication_Chem_Detail ;
      private IGxSession AV12WebSession ;
      private SdtBR_Medication_Scheme bcBR_Medication_Scheme ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] BC000V5_A296BR_Medication_SchemeID ;
      private bool[] BC000V5_n296BR_Medication_SchemeID ;
      private String[] BC000V5_A305BR_Medication_Chem_Name ;
      private bool[] BC000V5_n305BR_Medication_Chem_Name ;
      private decimal[] BC000V5_A306BR_Medication_Chem_Cycle ;
      private bool[] BC000V5_n306BR_Medication_Chem_Cycle ;
      private String[] BC000V5_A307BR_Medication_Chem_Line ;
      private bool[] BC000V5_n307BR_Medication_Chem_Line ;
      private String[] BC000V5_A313BR_Medication_Chem_Detail ;
      private bool[] BC000V5_n313BR_Medication_Chem_Detail ;
      private long[] BC000V5_A119BR_MedicationID ;
      private bool[] BC000V5_n119BR_MedicationID ;
      private long[] BC000V4_A119BR_MedicationID ;
      private bool[] BC000V4_n119BR_MedicationID ;
      private long[] BC000V6_A296BR_Medication_SchemeID ;
      private bool[] BC000V6_n296BR_Medication_SchemeID ;
      private long[] BC000V3_A296BR_Medication_SchemeID ;
      private bool[] BC000V3_n296BR_Medication_SchemeID ;
      private String[] BC000V3_A305BR_Medication_Chem_Name ;
      private bool[] BC000V3_n305BR_Medication_Chem_Name ;
      private decimal[] BC000V3_A306BR_Medication_Chem_Cycle ;
      private bool[] BC000V3_n306BR_Medication_Chem_Cycle ;
      private String[] BC000V3_A307BR_Medication_Chem_Line ;
      private bool[] BC000V3_n307BR_Medication_Chem_Line ;
      private String[] BC000V3_A313BR_Medication_Chem_Detail ;
      private bool[] BC000V3_n313BR_Medication_Chem_Detail ;
      private long[] BC000V3_A119BR_MedicationID ;
      private bool[] BC000V3_n119BR_MedicationID ;
      private long[] BC000V2_A296BR_Medication_SchemeID ;
      private bool[] BC000V2_n296BR_Medication_SchemeID ;
      private String[] BC000V2_A305BR_Medication_Chem_Name ;
      private bool[] BC000V2_n305BR_Medication_Chem_Name ;
      private decimal[] BC000V2_A306BR_Medication_Chem_Cycle ;
      private bool[] BC000V2_n306BR_Medication_Chem_Cycle ;
      private String[] BC000V2_A307BR_Medication_Chem_Line ;
      private bool[] BC000V2_n307BR_Medication_Chem_Line ;
      private String[] BC000V2_A313BR_Medication_Chem_Detail ;
      private bool[] BC000V2_n313BR_Medication_Chem_Detail ;
      private long[] BC000V2_A119BR_MedicationID ;
      private bool[] BC000V2_n119BR_MedicationID ;
      private long[] BC000V7_A296BR_Medication_SchemeID ;
      private bool[] BC000V7_n296BR_Medication_SchemeID ;
      private long[] BC000V10_A301BR_Medication_DetailID ;
      private long[] BC000V11_A296BR_Medication_SchemeID ;
      private bool[] BC000V11_n296BR_Medication_SchemeID ;
      private String[] BC000V11_A305BR_Medication_Chem_Name ;
      private bool[] BC000V11_n305BR_Medication_Chem_Name ;
      private decimal[] BC000V11_A306BR_Medication_Chem_Cycle ;
      private bool[] BC000V11_n306BR_Medication_Chem_Cycle ;
      private String[] BC000V11_A307BR_Medication_Chem_Line ;
      private bool[] BC000V11_n307BR_Medication_Chem_Line ;
      private String[] BC000V11_A313BR_Medication_Chem_Detail ;
      private bool[] BC000V11_n313BR_Medication_Chem_Detail ;
      private long[] BC000V11_A119BR_MedicationID ;
      private bool[] BC000V11_n119BR_MedicationID ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_datastore1 ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV8WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV11TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV14TrnContextAtt ;
   }

   public class br_medication_scheme_bc__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

    public String getDataStoreName( )
    {
       return "DATASTORE1";
    }

 }

 public class br_medication_scheme_bc__default : DataStoreHelperBase, IDataStoreHelper
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
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmBC000V5 ;
        prmBC000V5 = new Object[] {
        new Object[] {"@BR_Medication_SchemeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000V4 ;
        prmBC000V4 = new Object[] {
        new Object[] {"@BR_MedicationID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000V6 ;
        prmBC000V6 = new Object[] {
        new Object[] {"@BR_Medication_SchemeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000V3 ;
        prmBC000V3 = new Object[] {
        new Object[] {"@BR_Medication_SchemeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000V2 ;
        prmBC000V2 = new Object[] {
        new Object[] {"@BR_Medication_SchemeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000V7 ;
        prmBC000V7 = new Object[] {
        new Object[] {"@BR_Medication_Chem_Name",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Medication_Chem_Cycle",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_Medication_Chem_Line",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Medication_Chem_Detail",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_MedicationID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000V8 ;
        prmBC000V8 = new Object[] {
        new Object[] {"@BR_Medication_Chem_Name",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Medication_Chem_Cycle",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_Medication_Chem_Line",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Medication_Chem_Detail",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_MedicationID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_Medication_SchemeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000V9 ;
        prmBC000V9 = new Object[] {
        new Object[] {"@BR_Medication_SchemeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000V10 ;
        prmBC000V10 = new Object[] {
        new Object[] {"@BR_Medication_SchemeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000V11 ;
        prmBC000V11 = new Object[] {
        new Object[] {"@BR_Medication_SchemeID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("BC000V2", "SELECT [BR_Medication_SchemeID], [BR_Medication_Chem_Name], [BR_Medication_Chem_Cycle], [BR_Medication_Chem_Line], [BR_Medication_Chem_Detail], [BR_MedicationID] FROM [BR_Medication_Scheme] WITH (UPDLOCK) WHERE [BR_Medication_SchemeID] = @BR_Medication_SchemeID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000V2,1,0,true,false )
           ,new CursorDef("BC000V3", "SELECT [BR_Medication_SchemeID], [BR_Medication_Chem_Name], [BR_Medication_Chem_Cycle], [BR_Medication_Chem_Line], [BR_Medication_Chem_Detail], [BR_MedicationID] FROM [BR_Medication_Scheme] WITH (NOLOCK) WHERE [BR_Medication_SchemeID] = @BR_Medication_SchemeID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000V3,1,0,true,false )
           ,new CursorDef("BC000V4", "SELECT [BR_MedicationID] FROM [BR_Medication] WITH (NOLOCK) WHERE [BR_MedicationID] = @BR_MedicationID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000V4,1,0,true,false )
           ,new CursorDef("BC000V5", "SELECT TM1.[BR_Medication_SchemeID], TM1.[BR_Medication_Chem_Name], TM1.[BR_Medication_Chem_Cycle], TM1.[BR_Medication_Chem_Line], TM1.[BR_Medication_Chem_Detail], TM1.[BR_MedicationID] FROM [BR_Medication_Scheme] TM1 WITH (NOLOCK) WHERE TM1.[BR_Medication_SchemeID] = @BR_Medication_SchemeID ORDER BY TM1.[BR_Medication_SchemeID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000V5,100,0,true,false )
           ,new CursorDef("BC000V6", "SELECT [BR_Medication_SchemeID] FROM [BR_Medication_Scheme] WITH (NOLOCK) WHERE [BR_Medication_SchemeID] = @BR_Medication_SchemeID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000V6,1,0,true,false )
           ,new CursorDef("BC000V7", "INSERT INTO [BR_Medication_Scheme]([BR_Medication_Chem_Name], [BR_Medication_Chem_Cycle], [BR_Medication_Chem_Line], [BR_Medication_Chem_Detail], [BR_MedicationID]) VALUES(@BR_Medication_Chem_Name, @BR_Medication_Chem_Cycle, @BR_Medication_Chem_Line, @BR_Medication_Chem_Detail, @BR_MedicationID); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmBC000V7)
           ,new CursorDef("BC000V8", "UPDATE [BR_Medication_Scheme] SET [BR_Medication_Chem_Name]=@BR_Medication_Chem_Name, [BR_Medication_Chem_Cycle]=@BR_Medication_Chem_Cycle, [BR_Medication_Chem_Line]=@BR_Medication_Chem_Line, [BR_Medication_Chem_Detail]=@BR_Medication_Chem_Detail, [BR_MedicationID]=@BR_MedicationID  WHERE [BR_Medication_SchemeID] = @BR_Medication_SchemeID", GxErrorMask.GX_NOMASK,prmBC000V8)
           ,new CursorDef("BC000V9", "DELETE FROM [BR_Medication_Scheme]  WHERE [BR_Medication_SchemeID] = @BR_Medication_SchemeID", GxErrorMask.GX_NOMASK,prmBC000V9)
           ,new CursorDef("BC000V10", "SELECT TOP 1 [BR_Medication_DetailID] FROM [BR_Medication_Detail] WITH (NOLOCK) WHERE [BR_Medication_SchemeID] = @BR_Medication_SchemeID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000V10,1,0,true,true )
           ,new CursorDef("BC000V11", "SELECT TM1.[BR_Medication_SchemeID], TM1.[BR_Medication_Chem_Name], TM1.[BR_Medication_Chem_Cycle], TM1.[BR_Medication_Chem_Line], TM1.[BR_Medication_Chem_Detail], TM1.[BR_MedicationID] FROM [BR_Medication_Scheme] TM1 WITH (NOLOCK) WHERE TM1.[BR_Medication_SchemeID] = @BR_Medication_SchemeID ORDER BY TM1.[BR_Medication_SchemeID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000V11,100,0,true,false )
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
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((decimal[]) buf[3])[0] = rslt.getDecimal(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((long[]) buf[9])[0] = rslt.getLong(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((decimal[]) buf[3])[0] = rslt.getDecimal(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((long[]) buf[9])[0] = rslt.getLong(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              return;
           case 2 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 3 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((decimal[]) buf[3])[0] = rslt.getDecimal(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((long[]) buf[9])[0] = rslt.getLong(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              return;
           case 4 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 5 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 8 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 9 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((decimal[]) buf[3])[0] = rslt.getDecimal(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((long[]) buf[9])[0] = rslt.getLong(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
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
              if ( (bool)parms[2] )
              {
                 stmt.setNull( 2 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(2, (decimal)parms[3]);
              }
              if ( (bool)parms[4] )
              {
                 stmt.setNull( 3 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(3, (String)parms[5]);
              }
              if ( (bool)parms[6] )
              {
                 stmt.setNull( 4 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(4, (String)parms[7]);
              }
              if ( (bool)parms[8] )
              {
                 stmt.setNull( 5 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(5, (long)parms[9]);
              }
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
              if ( (bool)parms[2] )
              {
                 stmt.setNull( 2 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(2, (decimal)parms[3]);
              }
              if ( (bool)parms[4] )
              {
                 stmt.setNull( 3 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(3, (String)parms[5]);
              }
              if ( (bool)parms[6] )
              {
                 stmt.setNull( 4 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(4, (String)parms[7]);
              }
              if ( (bool)parms[8] )
              {
                 stmt.setNull( 5 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(5, (long)parms[9]);
              }
              if ( (bool)parms[10] )
              {
                 stmt.setNull( 6 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(6, (long)parms[11]);
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
