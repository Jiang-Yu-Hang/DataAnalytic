/*
               File: BR_Scheme_Medication_BC
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:38:43.15
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
   public class br_scheme_medication_bc : GXHttpHandler, IGxSilentTrn
   {
      public br_scheme_medication_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_scheme_medication_bc( IGxContext context )
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
         ReadRow1340( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey1340( ) ;
         standaloneModal( ) ;
         AddRow1340( ) ;
         Gx_mode = "INS";
         return  ;
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E11132 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               Z332BR_Scheme_MedicationID = A332BR_Scheme_MedicationID;
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

      protected void CONFIRM_130( )
      {
         BeforeValidate1340( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls1340( ) ;
            }
            else
            {
               CheckExtendedTable1340( ) ;
               if ( AnyError == 0 )
               {
                  ZM1340( 10) ;
                  ZM1340( 11) ;
               }
               CloseExtendedTableCursors1340( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void E12132( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV8WWPContext) ;
         AV9IsAuthorized = true;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Scheme_Medication", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Scheme_Medication", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Scheme_Medication", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
         }
         if ( ! AV9IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV20Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV11TrnContext.FromXml(AV12WebSession.Get("TrnContext"), null, "WWPTransactionContext", "DataAnalysisPlatform");
         if ( ( StringUtil.StrCmp(AV11TrnContext.gxTpr_Transactionname, AV20Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV21GXV1 = 1;
            while ( AV21GXV1 <= AV11TrnContext.gxTpr_Attributes.Count )
            {
               AV15TrnContextAtt = ((GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute)AV11TrnContext.gxTpr_Attributes.Item(AV21GXV1));
               if ( StringUtil.StrCmp(AV15TrnContextAtt.gxTpr_Attributename, "BR_SchemeID") == 0 )
               {
                  AV13Insert_BR_SchemeID = (long)(NumberUtil.Val( AV15TrnContextAtt.gxTpr_Attributevalue, "."));
               }
               else if ( StringUtil.StrCmp(AV15TrnContextAtt.gxTpr_Attributename, "BR_MedicationID") == 0 )
               {
                  AV14Insert_BR_MedicationID = (long)(NumberUtil.Val( AV15TrnContextAtt.gxTpr_Attributevalue, "."));
               }
               AV21GXV1 = (int)(AV21GXV1+1);
            }
         }
      }

      protected void E11132( )
      {
         /* After Trn Routine */
      }

      protected void ZM1340( short GX_JID )
      {
         if ( ( GX_JID == 9 ) || ( GX_JID == 0 ) )
         {
            Z327BR_SchemeID = A327BR_SchemeID;
            Z119BR_MedicationID = A119BR_MedicationID;
         }
         if ( ( GX_JID == 10 ) || ( GX_JID == 0 ) )
         {
            Z328BR_Scheme_Chem_Regimens = A328BR_Scheme_Chem_Regimens;
         }
         if ( ( GX_JID == 11 ) || ( GX_JID == 0 ) )
         {
            Z121BR_Medication_RXName = A121BR_Medication_RXName;
            Z124BR_Medication_RXDose = A124BR_Medication_RXDose;
            Z125BR_Medication_RXUnit = A125BR_Medication_RXUnit;
         }
         if ( GX_JID == -9 )
         {
            Z332BR_Scheme_MedicationID = A332BR_Scheme_MedicationID;
            Z327BR_SchemeID = A327BR_SchemeID;
            Z119BR_MedicationID = A119BR_MedicationID;
            Z328BR_Scheme_Chem_Regimens = A328BR_Scheme_Chem_Regimens;
            Z121BR_Medication_RXName = A121BR_Medication_RXName;
            Z124BR_Medication_RXDose = A124BR_Medication_RXDose;
            Z125BR_Medication_RXUnit = A125BR_Medication_RXUnit;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load1340( )
      {
         /* Using cursor BC00136 */
         pr_default.execute(4, new Object[] {A332BR_Scheme_MedicationID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound40 = 1;
            A328BR_Scheme_Chem_Regimens = BC00136_A328BR_Scheme_Chem_Regimens[0];
            n328BR_Scheme_Chem_Regimens = BC00136_n328BR_Scheme_Chem_Regimens[0];
            A121BR_Medication_RXName = BC00136_A121BR_Medication_RXName[0];
            n121BR_Medication_RXName = BC00136_n121BR_Medication_RXName[0];
            A124BR_Medication_RXDose = BC00136_A124BR_Medication_RXDose[0];
            n124BR_Medication_RXDose = BC00136_n124BR_Medication_RXDose[0];
            A125BR_Medication_RXUnit = BC00136_A125BR_Medication_RXUnit[0];
            n125BR_Medication_RXUnit = BC00136_n125BR_Medication_RXUnit[0];
            A327BR_SchemeID = BC00136_A327BR_SchemeID[0];
            n327BR_SchemeID = BC00136_n327BR_SchemeID[0];
            A119BR_MedicationID = BC00136_A119BR_MedicationID[0];
            n119BR_MedicationID = BC00136_n119BR_MedicationID[0];
            ZM1340( -9) ;
         }
         pr_default.close(4);
         OnLoadActions1340( ) ;
      }

      protected void OnLoadActions1340( )
      {
         AV20Pgmname = "BR_Scheme_Medication_BC";
         AV19vMedicationName = A121BR_Medication_RXName;
         AV16vDose = A124BR_Medication_RXDose;
      }

      protected void CheckExtendedTable1340( )
      {
         standaloneModal( ) ;
         AV20Pgmname = "BR_Scheme_Medication_BC";
         /* Using cursor BC00134 */
         pr_default.execute(2, new Object[] {n327BR_SchemeID, A327BR_SchemeID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            if ( ! ( (0==A327BR_SchemeID) ) )
            {
               GX_msglist.addItem("不匹配' T39'", "ForeignKeyNotFound", 1, "BR_SCHEMEID");
               AnyError = 1;
            }
         }
         A328BR_Scheme_Chem_Regimens = BC00134_A328BR_Scheme_Chem_Regimens[0];
         n328BR_Scheme_Chem_Regimens = BC00134_n328BR_Scheme_Chem_Regimens[0];
         pr_default.close(2);
         /* Using cursor BC00135 */
         pr_default.execute(3, new Object[] {n119BR_MedicationID, A119BR_MedicationID});
         if ( (pr_default.getStatus(3) == 101) )
         {
            if ( ! ( (0==A119BR_MedicationID) ) )
            {
               GX_msglist.addItem("不匹配' T18'", "ForeignKeyNotFound", 1, "BR_MEDICATIONID");
               AnyError = 1;
            }
         }
         A121BR_Medication_RXName = BC00135_A121BR_Medication_RXName[0];
         n121BR_Medication_RXName = BC00135_n121BR_Medication_RXName[0];
         A124BR_Medication_RXDose = BC00135_A124BR_Medication_RXDose[0];
         n124BR_Medication_RXDose = BC00135_n124BR_Medication_RXDose[0];
         A125BR_Medication_RXUnit = BC00135_A125BR_Medication_RXUnit[0];
         n125BR_Medication_RXUnit = BC00135_n125BR_Medication_RXUnit[0];
         pr_default.close(3);
         AV19vMedicationName = A121BR_Medication_RXName;
         AV16vDose = A124BR_Medication_RXDose;
         if ( (0==A119BR_MedicationID) )
         {
            GX_msglist.addItem("药物是必须选择的", 1, "");
            AnyError = 1;
         }
      }

      protected void CloseExtendedTableCursors1340( )
      {
         pr_default.close(2);
         pr_default.close(3);
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey1340( )
      {
         /* Using cursor BC00137 */
         pr_default.execute(5, new Object[] {A332BR_Scheme_MedicationID});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound40 = 1;
         }
         else
         {
            RcdFound40 = 0;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC00133 */
         pr_default.execute(1, new Object[] {A332BR_Scheme_MedicationID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM1340( 9) ;
            RcdFound40 = 1;
            A332BR_Scheme_MedicationID = BC00133_A332BR_Scheme_MedicationID[0];
            A327BR_SchemeID = BC00133_A327BR_SchemeID[0];
            n327BR_SchemeID = BC00133_n327BR_SchemeID[0];
            A119BR_MedicationID = BC00133_A119BR_MedicationID[0];
            n119BR_MedicationID = BC00133_n119BR_MedicationID[0];
            Z332BR_Scheme_MedicationID = A332BR_Scheme_MedicationID;
            sMode40 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load1340( ) ;
            if ( AnyError == 1 )
            {
               RcdFound40 = 0;
               InitializeNonKey1340( ) ;
            }
            Gx_mode = sMode40;
         }
         else
         {
            RcdFound40 = 0;
            InitializeNonKey1340( ) ;
            sMode40 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode40;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1340( ) ;
         if ( RcdFound40 == 0 )
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
         CONFIRM_130( ) ;
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

      protected void CheckOptimisticConcurrency1340( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC00132 */
            pr_default.execute(0, new Object[] {A332BR_Scheme_MedicationID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Scheme_Medication"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( Z327BR_SchemeID != BC00132_A327BR_SchemeID[0] ) || ( Z119BR_MedicationID != BC00132_A119BR_MedicationID[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"BR_Scheme_Medication"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert1340( )
      {
         BeforeValidate1340( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1340( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1340( 0) ;
            CheckOptimisticConcurrency1340( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1340( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1340( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00138 */
                     pr_default.execute(6, new Object[] {n327BR_SchemeID, A327BR_SchemeID, n119BR_MedicationID, A119BR_MedicationID});
                     A332BR_Scheme_MedicationID = BC00138_A332BR_Scheme_MedicationID[0];
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Scheme_Medication") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A327BR_SchemeID), 18, 0)),  "化疗方案",  StringUtil.Trim( StringUtil.Str( (decimal)(A332BR_Scheme_MedicationID), 18, 0)),  "药物详情",  "Create",  1) ;
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
               Load1340( ) ;
            }
            EndLevel1340( ) ;
         }
         CloseExtendedTableCursors1340( ) ;
      }

      protected void Update1340( )
      {
         BeforeValidate1340( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1340( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1340( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1340( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1340( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00139 */
                     pr_default.execute(7, new Object[] {n327BR_SchemeID, A327BR_SchemeID, n119BR_MedicationID, A119BR_MedicationID, A332BR_Scheme_MedicationID});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Scheme_Medication") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Scheme_Medication"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate1340( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A327BR_SchemeID), 18, 0)),  "化疗方案",  StringUtil.Trim( StringUtil.Str( (decimal)(A332BR_Scheme_MedicationID), 18, 0)),  "药物详情",  "Update",  1) ;
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
            EndLevel1340( ) ;
         }
         CloseExtendedTableCursors1340( ) ;
      }

      protected void DeferredUpdate1340( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate1340( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1340( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1340( ) ;
            AfterConfirm1340( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1340( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC001310 */
                  pr_default.execute(8, new Object[] {A332BR_Scheme_MedicationID});
                  pr_default.close(8);
                  dsDefault.SmartCacheProvider.SetUpdated("BR_Scheme_Medication") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A327BR_SchemeID), 18, 0)),  "化疗方案",  StringUtil.Trim( StringUtil.Str( (decimal)(A332BR_Scheme_MedicationID), 18, 0)),  "药物详情",  "Delete",  1) ;
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
         sMode40 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel1340( ) ;
         Gx_mode = sMode40;
      }

      protected void OnDeleteControls1340( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV20Pgmname = "BR_Scheme_Medication_BC";
            /* Using cursor BC001311 */
            pr_default.execute(9, new Object[] {n327BR_SchemeID, A327BR_SchemeID});
            A328BR_Scheme_Chem_Regimens = BC001311_A328BR_Scheme_Chem_Regimens[0];
            n328BR_Scheme_Chem_Regimens = BC001311_n328BR_Scheme_Chem_Regimens[0];
            pr_default.close(9);
            /* Using cursor BC001312 */
            pr_default.execute(10, new Object[] {n119BR_MedicationID, A119BR_MedicationID});
            A121BR_Medication_RXName = BC001312_A121BR_Medication_RXName[0];
            n121BR_Medication_RXName = BC001312_n121BR_Medication_RXName[0];
            A124BR_Medication_RXDose = BC001312_A124BR_Medication_RXDose[0];
            n124BR_Medication_RXDose = BC001312_n124BR_Medication_RXDose[0];
            A125BR_Medication_RXUnit = BC001312_A125BR_Medication_RXUnit[0];
            n125BR_Medication_RXUnit = BC001312_n125BR_Medication_RXUnit[0];
            pr_default.close(10);
            AV19vMedicationName = A121BR_Medication_RXName;
            AV16vDose = A124BR_Medication_RXDose;
         }
      }

      protected void EndLevel1340( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1340( ) ;
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

      public void ScanKeyStart1340( )
      {
         /* Scan By routine */
         /* Using cursor BC001313 */
         pr_default.execute(11, new Object[] {A332BR_Scheme_MedicationID});
         RcdFound40 = 0;
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound40 = 1;
            A332BR_Scheme_MedicationID = BC001313_A332BR_Scheme_MedicationID[0];
            A328BR_Scheme_Chem_Regimens = BC001313_A328BR_Scheme_Chem_Regimens[0];
            n328BR_Scheme_Chem_Regimens = BC001313_n328BR_Scheme_Chem_Regimens[0];
            A121BR_Medication_RXName = BC001313_A121BR_Medication_RXName[0];
            n121BR_Medication_RXName = BC001313_n121BR_Medication_RXName[0];
            A124BR_Medication_RXDose = BC001313_A124BR_Medication_RXDose[0];
            n124BR_Medication_RXDose = BC001313_n124BR_Medication_RXDose[0];
            A125BR_Medication_RXUnit = BC001313_A125BR_Medication_RXUnit[0];
            n125BR_Medication_RXUnit = BC001313_n125BR_Medication_RXUnit[0];
            A327BR_SchemeID = BC001313_A327BR_SchemeID[0];
            n327BR_SchemeID = BC001313_n327BR_SchemeID[0];
            A119BR_MedicationID = BC001313_A119BR_MedicationID[0];
            n119BR_MedicationID = BC001313_n119BR_MedicationID[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext1340( )
      {
         /* Scan next routine */
         pr_default.readNext(11);
         RcdFound40 = 0;
         ScanKeyLoad1340( ) ;
      }

      protected void ScanKeyLoad1340( )
      {
         sMode40 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound40 = 1;
            A332BR_Scheme_MedicationID = BC001313_A332BR_Scheme_MedicationID[0];
            A328BR_Scheme_Chem_Regimens = BC001313_A328BR_Scheme_Chem_Regimens[0];
            n328BR_Scheme_Chem_Regimens = BC001313_n328BR_Scheme_Chem_Regimens[0];
            A121BR_Medication_RXName = BC001313_A121BR_Medication_RXName[0];
            n121BR_Medication_RXName = BC001313_n121BR_Medication_RXName[0];
            A124BR_Medication_RXDose = BC001313_A124BR_Medication_RXDose[0];
            n124BR_Medication_RXDose = BC001313_n124BR_Medication_RXDose[0];
            A125BR_Medication_RXUnit = BC001313_A125BR_Medication_RXUnit[0];
            n125BR_Medication_RXUnit = BC001313_n125BR_Medication_RXUnit[0];
            A327BR_SchemeID = BC001313_A327BR_SchemeID[0];
            n327BR_SchemeID = BC001313_n327BR_SchemeID[0];
            A119BR_MedicationID = BC001313_A119BR_MedicationID[0];
            n119BR_MedicationID = BC001313_n119BR_MedicationID[0];
         }
         Gx_mode = sMode40;
      }

      protected void ScanKeyEnd1340( )
      {
         pr_default.close(11);
      }

      protected void AfterConfirm1340( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1340( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1340( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1340( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1340( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1340( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1340( )
      {
      }

      protected void send_integrity_lvl_hashes1340( )
      {
      }

      protected void AddRow1340( )
      {
         VarsToRow40( bcBR_Scheme_Medication) ;
      }

      protected void ReadRow1340( )
      {
         RowToVars40( bcBR_Scheme_Medication, 1) ;
      }

      protected void InitializeNonKey1340( )
      {
         AV19vMedicationName = "";
         AV16vDose = 0;
         A327BR_SchemeID = 0;
         n327BR_SchemeID = false;
         A119BR_MedicationID = 0;
         n119BR_MedicationID = false;
         A328BR_Scheme_Chem_Regimens = "";
         n328BR_Scheme_Chem_Regimens = false;
         A121BR_Medication_RXName = "";
         n121BR_Medication_RXName = false;
         A124BR_Medication_RXDose = 0;
         n124BR_Medication_RXDose = false;
         A125BR_Medication_RXUnit = "";
         n125BR_Medication_RXUnit = false;
         Z327BR_SchemeID = 0;
         Z119BR_MedicationID = 0;
      }

      protected void InitAll1340( )
      {
         A332BR_Scheme_MedicationID = 0;
         InitializeNonKey1340( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow40( SdtBR_Scheme_Medication obj40 )
      {
         obj40.gxTpr_Mode = Gx_mode;
         obj40.gxTpr_Br_schemeid = A327BR_SchemeID;
         obj40.gxTpr_Br_medicationid = A119BR_MedicationID;
         obj40.gxTpr_Br_scheme_chem_regimens = A328BR_Scheme_Chem_Regimens;
         obj40.gxTpr_Br_medication_rxname = A121BR_Medication_RXName;
         obj40.gxTpr_Br_medication_rxdose = A124BR_Medication_RXDose;
         obj40.gxTpr_Br_medication_rxunit = A125BR_Medication_RXUnit;
         obj40.gxTpr_Br_scheme_medicationid = A332BR_Scheme_MedicationID;
         obj40.gxTpr_Br_scheme_medicationid_Z = Z332BR_Scheme_MedicationID;
         obj40.gxTpr_Br_schemeid_Z = Z327BR_SchemeID;
         obj40.gxTpr_Br_medicationid_Z = Z119BR_MedicationID;
         obj40.gxTpr_Br_scheme_chem_regimens_Z = Z328BR_Scheme_Chem_Regimens;
         obj40.gxTpr_Br_medication_rxname_Z = Z121BR_Medication_RXName;
         obj40.gxTpr_Br_medication_rxdose_Z = Z124BR_Medication_RXDose;
         obj40.gxTpr_Br_medication_rxunit_Z = Z125BR_Medication_RXUnit;
         obj40.gxTpr_Br_schemeid_N = (short)(Convert.ToInt16(n327BR_SchemeID));
         obj40.gxTpr_Br_medicationid_N = (short)(Convert.ToInt16(n119BR_MedicationID));
         obj40.gxTpr_Br_scheme_chem_regimens_N = (short)(Convert.ToInt16(n328BR_Scheme_Chem_Regimens));
         obj40.gxTpr_Br_medication_rxname_N = (short)(Convert.ToInt16(n121BR_Medication_RXName));
         obj40.gxTpr_Br_medication_rxdose_N = (short)(Convert.ToInt16(n124BR_Medication_RXDose));
         obj40.gxTpr_Br_medication_rxunit_N = (short)(Convert.ToInt16(n125BR_Medication_RXUnit));
         obj40.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow40( SdtBR_Scheme_Medication obj40 )
      {
         obj40.gxTpr_Br_scheme_medicationid = A332BR_Scheme_MedicationID;
         return  ;
      }

      public void RowToVars40( SdtBR_Scheme_Medication obj40 ,
                               int forceLoad )
      {
         Gx_mode = obj40.gxTpr_Mode;
         A327BR_SchemeID = obj40.gxTpr_Br_schemeid;
         n327BR_SchemeID = false;
         A119BR_MedicationID = obj40.gxTpr_Br_medicationid;
         n119BR_MedicationID = false;
         A328BR_Scheme_Chem_Regimens = obj40.gxTpr_Br_scheme_chem_regimens;
         n328BR_Scheme_Chem_Regimens = false;
         A121BR_Medication_RXName = obj40.gxTpr_Br_medication_rxname;
         n121BR_Medication_RXName = false;
         A124BR_Medication_RXDose = obj40.gxTpr_Br_medication_rxdose;
         n124BR_Medication_RXDose = false;
         A125BR_Medication_RXUnit = obj40.gxTpr_Br_medication_rxunit;
         n125BR_Medication_RXUnit = false;
         A332BR_Scheme_MedicationID = obj40.gxTpr_Br_scheme_medicationid;
         Z332BR_Scheme_MedicationID = obj40.gxTpr_Br_scheme_medicationid_Z;
         Z327BR_SchemeID = obj40.gxTpr_Br_schemeid_Z;
         Z119BR_MedicationID = obj40.gxTpr_Br_medicationid_Z;
         Z328BR_Scheme_Chem_Regimens = obj40.gxTpr_Br_scheme_chem_regimens_Z;
         Z121BR_Medication_RXName = obj40.gxTpr_Br_medication_rxname_Z;
         Z124BR_Medication_RXDose = obj40.gxTpr_Br_medication_rxdose_Z;
         Z125BR_Medication_RXUnit = obj40.gxTpr_Br_medication_rxunit_Z;
         n327BR_SchemeID = (bool)(Convert.ToBoolean(obj40.gxTpr_Br_schemeid_N));
         n119BR_MedicationID = (bool)(Convert.ToBoolean(obj40.gxTpr_Br_medicationid_N));
         n328BR_Scheme_Chem_Regimens = (bool)(Convert.ToBoolean(obj40.gxTpr_Br_scheme_chem_regimens_N));
         n121BR_Medication_RXName = (bool)(Convert.ToBoolean(obj40.gxTpr_Br_medication_rxname_N));
         n124BR_Medication_RXDose = (bool)(Convert.ToBoolean(obj40.gxTpr_Br_medication_rxdose_N));
         n125BR_Medication_RXUnit = (bool)(Convert.ToBoolean(obj40.gxTpr_Br_medication_rxunit_N));
         Gx_mode = obj40.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A332BR_Scheme_MedicationID = (long)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey1340( ) ;
         ScanKeyStart1340( ) ;
         if ( RcdFound40 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z332BR_Scheme_MedicationID = A332BR_Scheme_MedicationID;
         }
         ZM1340( -9) ;
         OnLoadActions1340( ) ;
         AddRow1340( ) ;
         ScanKeyEnd1340( ) ;
         if ( RcdFound40 == 0 )
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
         RowToVars40( bcBR_Scheme_Medication, 0) ;
         ScanKeyStart1340( ) ;
         if ( RcdFound40 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z332BR_Scheme_MedicationID = A332BR_Scheme_MedicationID;
         }
         ZM1340( -9) ;
         OnLoadActions1340( ) ;
         AddRow1340( ) ;
         ScanKeyEnd1340( ) ;
         if ( RcdFound40 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey1340( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert1340( ) ;
         }
         else
         {
            if ( RcdFound40 == 1 )
            {
               if ( A332BR_Scheme_MedicationID != Z332BR_Scheme_MedicationID )
               {
                  A332BR_Scheme_MedicationID = Z332BR_Scheme_MedicationID;
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
                  Update1340( ) ;
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
                  if ( A332BR_Scheme_MedicationID != Z332BR_Scheme_MedicationID )
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
                        Insert1340( ) ;
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
                        Insert1340( ) ;
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
         RowToVars40( bcBR_Scheme_Medication, 0) ;
         SaveImpl( ) ;
         VarsToRow40( bcBR_Scheme_Medication) ;
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
         RowToVars40( bcBR_Scheme_Medication, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert1340( ) ;
         AfterTrn( ) ;
         VarsToRow40( bcBR_Scheme_Medication) ;
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
            SdtBR_Scheme_Medication auxBC = new SdtBR_Scheme_Medication(context) ;
            auxBC.Load(A332BR_Scheme_MedicationID);
            auxBC.UpdateDirties(bcBR_Scheme_Medication);
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
         RowToVars40( bcBR_Scheme_Medication, 0) ;
         UpdateImpl( ) ;
         VarsToRow40( bcBR_Scheme_Medication) ;
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
         RowToVars40( bcBR_Scheme_Medication, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert1340( ) ;
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
         VarsToRow40( bcBR_Scheme_Medication) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars40( bcBR_Scheme_Medication, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey1340( ) ;
         if ( RcdFound40 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A332BR_Scheme_MedicationID != Z332BR_Scheme_MedicationID )
            {
               A332BR_Scheme_MedicationID = Z332BR_Scheme_MedicationID;
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
            if ( A332BR_Scheme_MedicationID != Z332BR_Scheme_MedicationID )
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
         pr_default.close(10);
         context.RollbackDataStores("br_scheme_medication_bc",pr_default);
         VarsToRow40( bcBR_Scheme_Medication) ;
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
         Gx_mode = bcBR_Scheme_Medication.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcBR_Scheme_Medication.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcBR_Scheme_Medication )
         {
            bcBR_Scheme_Medication = (SdtBR_Scheme_Medication)(sdt);
            if ( StringUtil.StrCmp(bcBR_Scheme_Medication.gxTpr_Mode, "") == 0 )
            {
               bcBR_Scheme_Medication.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow40( bcBR_Scheme_Medication) ;
            }
            else
            {
               RowToVars40( bcBR_Scheme_Medication, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcBR_Scheme_Medication.gxTpr_Mode, "") == 0 )
            {
               bcBR_Scheme_Medication.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars40( bcBR_Scheme_Medication, 1) ;
         return  ;
      }

      public SdtBR_Scheme_Medication BR_Scheme_Medication_BC
      {
         get {
            return bcBR_Scheme_Medication ;
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
         pr_default.close(10);
      }

      public override void initialize( )
      {
         scmdbuf = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Gx_mode = "";
         AV8WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV20Pgmname = "";
         AV11TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV12WebSession = context.GetSession();
         AV15TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         Z328BR_Scheme_Chem_Regimens = "";
         A328BR_Scheme_Chem_Regimens = "";
         Z121BR_Medication_RXName = "";
         A121BR_Medication_RXName = "";
         Z125BR_Medication_RXUnit = "";
         A125BR_Medication_RXUnit = "";
         BC00136_A332BR_Scheme_MedicationID = new long[1] ;
         BC00136_A328BR_Scheme_Chem_Regimens = new String[] {""} ;
         BC00136_n328BR_Scheme_Chem_Regimens = new bool[] {false} ;
         BC00136_A121BR_Medication_RXName = new String[] {""} ;
         BC00136_n121BR_Medication_RXName = new bool[] {false} ;
         BC00136_A124BR_Medication_RXDose = new decimal[1] ;
         BC00136_n124BR_Medication_RXDose = new bool[] {false} ;
         BC00136_A125BR_Medication_RXUnit = new String[] {""} ;
         BC00136_n125BR_Medication_RXUnit = new bool[] {false} ;
         BC00136_A327BR_SchemeID = new long[1] ;
         BC00136_n327BR_SchemeID = new bool[] {false} ;
         BC00136_A119BR_MedicationID = new long[1] ;
         BC00136_n119BR_MedicationID = new bool[] {false} ;
         AV19vMedicationName = "";
         BC00134_A328BR_Scheme_Chem_Regimens = new String[] {""} ;
         BC00134_n328BR_Scheme_Chem_Regimens = new bool[] {false} ;
         BC00135_A121BR_Medication_RXName = new String[] {""} ;
         BC00135_n121BR_Medication_RXName = new bool[] {false} ;
         BC00135_A124BR_Medication_RXDose = new decimal[1] ;
         BC00135_n124BR_Medication_RXDose = new bool[] {false} ;
         BC00135_A125BR_Medication_RXUnit = new String[] {""} ;
         BC00135_n125BR_Medication_RXUnit = new bool[] {false} ;
         BC00137_A332BR_Scheme_MedicationID = new long[1] ;
         BC00133_A332BR_Scheme_MedicationID = new long[1] ;
         BC00133_A327BR_SchemeID = new long[1] ;
         BC00133_n327BR_SchemeID = new bool[] {false} ;
         BC00133_A119BR_MedicationID = new long[1] ;
         BC00133_n119BR_MedicationID = new bool[] {false} ;
         sMode40 = "";
         BC00132_A332BR_Scheme_MedicationID = new long[1] ;
         BC00132_A327BR_SchemeID = new long[1] ;
         BC00132_n327BR_SchemeID = new bool[] {false} ;
         BC00132_A119BR_MedicationID = new long[1] ;
         BC00132_n119BR_MedicationID = new bool[] {false} ;
         BC00138_A332BR_Scheme_MedicationID = new long[1] ;
         BC001311_A328BR_Scheme_Chem_Regimens = new String[] {""} ;
         BC001311_n328BR_Scheme_Chem_Regimens = new bool[] {false} ;
         BC001312_A121BR_Medication_RXName = new String[] {""} ;
         BC001312_n121BR_Medication_RXName = new bool[] {false} ;
         BC001312_A124BR_Medication_RXDose = new decimal[1] ;
         BC001312_n124BR_Medication_RXDose = new bool[] {false} ;
         BC001312_A125BR_Medication_RXUnit = new String[] {""} ;
         BC001312_n125BR_Medication_RXUnit = new bool[] {false} ;
         BC001313_A332BR_Scheme_MedicationID = new long[1] ;
         BC001313_A328BR_Scheme_Chem_Regimens = new String[] {""} ;
         BC001313_n328BR_Scheme_Chem_Regimens = new bool[] {false} ;
         BC001313_A121BR_Medication_RXName = new String[] {""} ;
         BC001313_n121BR_Medication_RXName = new bool[] {false} ;
         BC001313_A124BR_Medication_RXDose = new decimal[1] ;
         BC001313_n124BR_Medication_RXDose = new bool[] {false} ;
         BC001313_A125BR_Medication_RXUnit = new String[] {""} ;
         BC001313_n125BR_Medication_RXUnit = new bool[] {false} ;
         BC001313_A327BR_SchemeID = new long[1] ;
         BC001313_n327BR_SchemeID = new bool[] {false} ;
         BC001313_A119BR_MedicationID = new long[1] ;
         BC001313_n119BR_MedicationID = new bool[] {false} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_scheme_medication_bc__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_scheme_medication_bc__default(),
            new Object[][] {
                new Object[] {
               BC00132_A332BR_Scheme_MedicationID, BC00132_A327BR_SchemeID, BC00132_n327BR_SchemeID, BC00132_A119BR_MedicationID, BC00132_n119BR_MedicationID
               }
               , new Object[] {
               BC00133_A332BR_Scheme_MedicationID, BC00133_A327BR_SchemeID, BC00133_n327BR_SchemeID, BC00133_A119BR_MedicationID, BC00133_n119BR_MedicationID
               }
               , new Object[] {
               BC00134_A328BR_Scheme_Chem_Regimens, BC00134_n328BR_Scheme_Chem_Regimens
               }
               , new Object[] {
               BC00135_A121BR_Medication_RXName, BC00135_n121BR_Medication_RXName, BC00135_A124BR_Medication_RXDose, BC00135_n124BR_Medication_RXDose, BC00135_A125BR_Medication_RXUnit, BC00135_n125BR_Medication_RXUnit
               }
               , new Object[] {
               BC00136_A332BR_Scheme_MedicationID, BC00136_A328BR_Scheme_Chem_Regimens, BC00136_n328BR_Scheme_Chem_Regimens, BC00136_A121BR_Medication_RXName, BC00136_n121BR_Medication_RXName, BC00136_A124BR_Medication_RXDose, BC00136_n124BR_Medication_RXDose, BC00136_A125BR_Medication_RXUnit, BC00136_n125BR_Medication_RXUnit, BC00136_A327BR_SchemeID,
               BC00136_n327BR_SchemeID, BC00136_A119BR_MedicationID, BC00136_n119BR_MedicationID
               }
               , new Object[] {
               BC00137_A332BR_Scheme_MedicationID
               }
               , new Object[] {
               BC00138_A332BR_Scheme_MedicationID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC001311_A328BR_Scheme_Chem_Regimens, BC001311_n328BR_Scheme_Chem_Regimens
               }
               , new Object[] {
               BC001312_A121BR_Medication_RXName, BC001312_n121BR_Medication_RXName, BC001312_A124BR_Medication_RXDose, BC001312_n124BR_Medication_RXDose, BC001312_A125BR_Medication_RXUnit, BC001312_n125BR_Medication_RXUnit
               }
               , new Object[] {
               BC001313_A332BR_Scheme_MedicationID, BC001313_A328BR_Scheme_Chem_Regimens, BC001313_n328BR_Scheme_Chem_Regimens, BC001313_A121BR_Medication_RXName, BC001313_n121BR_Medication_RXName, BC001313_A124BR_Medication_RXDose, BC001313_n124BR_Medication_RXDose, BC001313_A125BR_Medication_RXUnit, BC001313_n125BR_Medication_RXUnit, BC001313_A327BR_SchemeID,
               BC001313_n327BR_SchemeID, BC001313_A119BR_MedicationID, BC001313_n119BR_MedicationID
               }
            }
         );
         AV20Pgmname = "BR_Scheme_Medication_BC";
         INITTRN();
         /* Execute Start event if defined. */
         /* Execute user event: Start */
         E12132 ();
         standaloneNotModal( ) ;
      }

      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short GX_JID ;
      private short RcdFound40 ;
      private int trnEnded ;
      private int AV21GXV1 ;
      private long Z332BR_Scheme_MedicationID ;
      private long A332BR_Scheme_MedicationID ;
      private long AV13Insert_BR_SchemeID ;
      private long AV14Insert_BR_MedicationID ;
      private long Z327BR_SchemeID ;
      private long A327BR_SchemeID ;
      private long Z119BR_MedicationID ;
      private long A119BR_MedicationID ;
      private decimal Z124BR_Medication_RXDose ;
      private decimal A124BR_Medication_RXDose ;
      private decimal AV16vDose ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String AV20Pgmname ;
      private String sMode40 ;
      private bool AV9IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool n328BR_Scheme_Chem_Regimens ;
      private bool n121BR_Medication_RXName ;
      private bool n124BR_Medication_RXDose ;
      private bool n125BR_Medication_RXUnit ;
      private bool n327BR_SchemeID ;
      private bool n119BR_MedicationID ;
      private String Z328BR_Scheme_Chem_Regimens ;
      private String A328BR_Scheme_Chem_Regimens ;
      private String Z121BR_Medication_RXName ;
      private String A121BR_Medication_RXName ;
      private String Z125BR_Medication_RXUnit ;
      private String A125BR_Medication_RXUnit ;
      private String AV19vMedicationName ;
      private IGxSession AV12WebSession ;
      private SdtBR_Scheme_Medication bcBR_Scheme_Medication ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] BC00136_A332BR_Scheme_MedicationID ;
      private String[] BC00136_A328BR_Scheme_Chem_Regimens ;
      private bool[] BC00136_n328BR_Scheme_Chem_Regimens ;
      private String[] BC00136_A121BR_Medication_RXName ;
      private bool[] BC00136_n121BR_Medication_RXName ;
      private decimal[] BC00136_A124BR_Medication_RXDose ;
      private bool[] BC00136_n124BR_Medication_RXDose ;
      private String[] BC00136_A125BR_Medication_RXUnit ;
      private bool[] BC00136_n125BR_Medication_RXUnit ;
      private long[] BC00136_A327BR_SchemeID ;
      private bool[] BC00136_n327BR_SchemeID ;
      private long[] BC00136_A119BR_MedicationID ;
      private bool[] BC00136_n119BR_MedicationID ;
      private String[] BC00134_A328BR_Scheme_Chem_Regimens ;
      private bool[] BC00134_n328BR_Scheme_Chem_Regimens ;
      private String[] BC00135_A121BR_Medication_RXName ;
      private bool[] BC00135_n121BR_Medication_RXName ;
      private decimal[] BC00135_A124BR_Medication_RXDose ;
      private bool[] BC00135_n124BR_Medication_RXDose ;
      private String[] BC00135_A125BR_Medication_RXUnit ;
      private bool[] BC00135_n125BR_Medication_RXUnit ;
      private long[] BC00137_A332BR_Scheme_MedicationID ;
      private long[] BC00133_A332BR_Scheme_MedicationID ;
      private long[] BC00133_A327BR_SchemeID ;
      private bool[] BC00133_n327BR_SchemeID ;
      private long[] BC00133_A119BR_MedicationID ;
      private bool[] BC00133_n119BR_MedicationID ;
      private long[] BC00132_A332BR_Scheme_MedicationID ;
      private long[] BC00132_A327BR_SchemeID ;
      private bool[] BC00132_n327BR_SchemeID ;
      private long[] BC00132_A119BR_MedicationID ;
      private bool[] BC00132_n119BR_MedicationID ;
      private long[] BC00138_A332BR_Scheme_MedicationID ;
      private String[] BC001311_A328BR_Scheme_Chem_Regimens ;
      private bool[] BC001311_n328BR_Scheme_Chem_Regimens ;
      private String[] BC001312_A121BR_Medication_RXName ;
      private bool[] BC001312_n121BR_Medication_RXName ;
      private decimal[] BC001312_A124BR_Medication_RXDose ;
      private bool[] BC001312_n124BR_Medication_RXDose ;
      private String[] BC001312_A125BR_Medication_RXUnit ;
      private bool[] BC001312_n125BR_Medication_RXUnit ;
      private long[] BC001313_A332BR_Scheme_MedicationID ;
      private String[] BC001313_A328BR_Scheme_Chem_Regimens ;
      private bool[] BC001313_n328BR_Scheme_Chem_Regimens ;
      private String[] BC001313_A121BR_Medication_RXName ;
      private bool[] BC001313_n121BR_Medication_RXName ;
      private decimal[] BC001313_A124BR_Medication_RXDose ;
      private bool[] BC001313_n124BR_Medication_RXDose ;
      private String[] BC001313_A125BR_Medication_RXUnit ;
      private bool[] BC001313_n125BR_Medication_RXUnit ;
      private long[] BC001313_A327BR_SchemeID ;
      private bool[] BC001313_n327BR_SchemeID ;
      private long[] BC001313_A119BR_MedicationID ;
      private bool[] BC001313_n119BR_MedicationID ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_datastore1 ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV11TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV15TrnContextAtt ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV8WWPContext ;
   }

   public class br_scheme_medication_bc__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class br_scheme_medication_bc__default : DataStoreHelperBase, IDataStoreHelper
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
       ,new ForEachCursor(def[6])
       ,new UpdateCursor(def[7])
       ,new UpdateCursor(def[8])
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
        Object[] prmBC00136 ;
        prmBC00136 = new Object[] {
        new Object[] {"@BR_Scheme_MedicationID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00134 ;
        prmBC00134 = new Object[] {
        new Object[] {"@BR_SchemeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00135 ;
        prmBC00135 = new Object[] {
        new Object[] {"@BR_MedicationID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00137 ;
        prmBC00137 = new Object[] {
        new Object[] {"@BR_Scheme_MedicationID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00133 ;
        prmBC00133 = new Object[] {
        new Object[] {"@BR_Scheme_MedicationID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00132 ;
        prmBC00132 = new Object[] {
        new Object[] {"@BR_Scheme_MedicationID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00138 ;
        prmBC00138 = new Object[] {
        new Object[] {"@BR_SchemeID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_MedicationID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00139 ;
        prmBC00139 = new Object[] {
        new Object[] {"@BR_SchemeID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_MedicationID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_Scheme_MedicationID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC001310 ;
        prmBC001310 = new Object[] {
        new Object[] {"@BR_Scheme_MedicationID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC001311 ;
        prmBC001311 = new Object[] {
        new Object[] {"@BR_SchemeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC001312 ;
        prmBC001312 = new Object[] {
        new Object[] {"@BR_MedicationID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC001313 ;
        prmBC001313 = new Object[] {
        new Object[] {"@BR_Scheme_MedicationID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("BC00132", "SELECT [BR_Scheme_MedicationID], [BR_SchemeID], [BR_MedicationID] FROM [BR_Scheme_Medication] WITH (UPDLOCK) WHERE [BR_Scheme_MedicationID] = @BR_Scheme_MedicationID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00132,1,0,true,false )
           ,new CursorDef("BC00133", "SELECT [BR_Scheme_MedicationID], [BR_SchemeID], [BR_MedicationID] FROM [BR_Scheme_Medication] WITH (NOLOCK) WHERE [BR_Scheme_MedicationID] = @BR_Scheme_MedicationID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00133,1,0,true,false )
           ,new CursorDef("BC00134", "SELECT [BR_Scheme_Chem_Regimens] FROM [BR_Scheme] WITH (NOLOCK) WHERE [BR_SchemeID] = @BR_SchemeID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00134,1,0,true,false )
           ,new CursorDef("BC00135", "SELECT [BR_Medication_RXName], [BR_Medication_RXDose], [BR_Medication_RXUnit] FROM [BR_Medication] WITH (NOLOCK) WHERE [BR_MedicationID] = @BR_MedicationID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00135,1,0,true,false )
           ,new CursorDef("BC00136", "SELECT TM1.[BR_Scheme_MedicationID], T2.[BR_Scheme_Chem_Regimens], T3.[BR_Medication_RXName], T3.[BR_Medication_RXDose], T3.[BR_Medication_RXUnit], TM1.[BR_SchemeID], TM1.[BR_MedicationID] FROM (([BR_Scheme_Medication] TM1 WITH (NOLOCK) LEFT JOIN [BR_Scheme] T2 WITH (NOLOCK) ON T2.[BR_SchemeID] = TM1.[BR_SchemeID]) LEFT JOIN [BR_Medication] T3 WITH (NOLOCK) ON T3.[BR_MedicationID] = TM1.[BR_MedicationID]) WHERE TM1.[BR_Scheme_MedicationID] = @BR_Scheme_MedicationID ORDER BY TM1.[BR_Scheme_MedicationID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00136,100,0,true,false )
           ,new CursorDef("BC00137", "SELECT [BR_Scheme_MedicationID] FROM [BR_Scheme_Medication] WITH (NOLOCK) WHERE [BR_Scheme_MedicationID] = @BR_Scheme_MedicationID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00137,1,0,true,false )
           ,new CursorDef("BC00138", "INSERT INTO [BR_Scheme_Medication]([BR_SchemeID], [BR_MedicationID]) VALUES(@BR_SchemeID, @BR_MedicationID); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmBC00138)
           ,new CursorDef("BC00139", "UPDATE [BR_Scheme_Medication] SET [BR_SchemeID]=@BR_SchemeID, [BR_MedicationID]=@BR_MedicationID  WHERE [BR_Scheme_MedicationID] = @BR_Scheme_MedicationID", GxErrorMask.GX_NOMASK,prmBC00139)
           ,new CursorDef("BC001310", "DELETE FROM [BR_Scheme_Medication]  WHERE [BR_Scheme_MedicationID] = @BR_Scheme_MedicationID", GxErrorMask.GX_NOMASK,prmBC001310)
           ,new CursorDef("BC001311", "SELECT [BR_Scheme_Chem_Regimens] FROM [BR_Scheme] WITH (NOLOCK) WHERE [BR_SchemeID] = @BR_SchemeID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001311,1,0,true,false )
           ,new CursorDef("BC001312", "SELECT [BR_Medication_RXName], [BR_Medication_RXDose], [BR_Medication_RXUnit] FROM [BR_Medication] WITH (NOLOCK) WHERE [BR_MedicationID] = @BR_MedicationID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001312,1,0,true,false )
           ,new CursorDef("BC001313", "SELECT TM1.[BR_Scheme_MedicationID], T2.[BR_Scheme_Chem_Regimens], T3.[BR_Medication_RXName], T3.[BR_Medication_RXDose], T3.[BR_Medication_RXUnit], TM1.[BR_SchemeID], TM1.[BR_MedicationID] FROM (([BR_Scheme_Medication] TM1 WITH (NOLOCK) LEFT JOIN [BR_Scheme] T2 WITH (NOLOCK) ON T2.[BR_SchemeID] = TM1.[BR_SchemeID]) LEFT JOIN [BR_Medication] T3 WITH (NOLOCK) ON T3.[BR_MedicationID] = TM1.[BR_MedicationID]) WHERE TM1.[BR_Scheme_MedicationID] = @BR_Scheme_MedicationID ORDER BY TM1.[BR_Scheme_MedicationID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001313,100,0,true,false )
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
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((long[]) buf[3])[0] = rslt.getLong(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((long[]) buf[3])[0] = rslt.getLong(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              return;
           case 2 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              return;
           case 3 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              ((decimal[]) buf[2])[0] = rslt.getDecimal(2) ;
              ((bool[]) buf[3])[0] = rslt.wasNull(2);
              ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[5])[0] = rslt.wasNull(3);
              return;
           case 4 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((decimal[]) buf[5])[0] = rslt.getDecimal(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((long[]) buf[9])[0] = rslt.getLong(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((long[]) buf[11])[0] = rslt.getLong(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              return;
           case 5 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 6 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 9 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              return;
           case 10 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              ((decimal[]) buf[2])[0] = rslt.getDecimal(2) ;
              ((bool[]) buf[3])[0] = rslt.wasNull(2);
              ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[5])[0] = rslt.wasNull(3);
              return;
           case 11 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((decimal[]) buf[5])[0] = rslt.getDecimal(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((long[]) buf[9])[0] = rslt.getLong(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((long[]) buf[11])[0] = rslt.getLong(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
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
              return;
           case 1 :
              stmt.SetParameter(1, (long)parms[0]);
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
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 5 :
              stmt.SetParameter(1, (long)parms[0]);
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
                 stmt.setNull( 2 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(2, (long)parms[3]);
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
                 stmt.setNull( 2 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(2, (long)parms[3]);
              }
              stmt.SetParameter(3, (long)parms[4]);
              return;
           case 8 :
              stmt.SetParameter(1, (long)parms[0]);
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
           case 10 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 11 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
     }
  }

}

}
