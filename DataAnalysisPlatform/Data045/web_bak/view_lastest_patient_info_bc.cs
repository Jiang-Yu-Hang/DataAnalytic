/*
               File: view_lastest_patient_info_BC
        Description: view_lastest_patient_info
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:39:6.71
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
   public class view_lastest_patient_info_bc : GXHttpHandler, IGxSilentTrn
   {
      public view_lastest_patient_info_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public view_lastest_patient_info_bc( IGxContext context )
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
         ReadRow1O71( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey1O71( ) ;
         standaloneModal( ) ;
         AddRow1O71( ) ;
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
               Z520VIEW_LPI_BR_Information_ID = A520VIEW_LPI_BR_Information_ID;
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

      protected void CONFIRM_1O0( )
      {
         BeforeValidate1O71( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls1O71( ) ;
            }
            else
            {
               CheckExtendedTable1O71( ) ;
               if ( AnyError == 0 )
               {
               }
               CloseExtendedTableCursors1O71( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void ZM1O71( short GX_JID )
      {
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            Z519VIEW_LPI_BR_Information_PatientNo = A519VIEW_LPI_BR_Information_PatientNo;
            Z521VIEW_LPI_BR_Encounter_AdmitDate = A521VIEW_LPI_BR_Encounter_AdmitDate;
            Z522VIEW_LPI_BR_Demographics_Sex = A522VIEW_LPI_BR_Demographics_Sex;
            Z523VIEW_LPI_BR_Demographics_BirthDate = A523VIEW_LPI_BR_Demographics_BirthDate;
            Z524VIEW_LPI_BR_Demographics_Ethnic = A524VIEW_LPI_BR_Demographics_Ethnic;
         }
         if ( GX_JID == -3 )
         {
            Z520VIEW_LPI_BR_Information_ID = A520VIEW_LPI_BR_Information_ID;
            Z519VIEW_LPI_BR_Information_PatientNo = A519VIEW_LPI_BR_Information_PatientNo;
            Z521VIEW_LPI_BR_Encounter_AdmitDate = A521VIEW_LPI_BR_Encounter_AdmitDate;
            Z522VIEW_LPI_BR_Demographics_Sex = A522VIEW_LPI_BR_Demographics_Sex;
            Z523VIEW_LPI_BR_Demographics_BirthDate = A523VIEW_LPI_BR_Demographics_BirthDate;
            Z524VIEW_LPI_BR_Demographics_Ethnic = A524VIEW_LPI_BR_Demographics_Ethnic;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load1O71( )
      {
         /* Using cursor BC001O4 */
         pr_default.execute(2, new Object[] {A520VIEW_LPI_BR_Information_ID});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound71 = 1;
            A519VIEW_LPI_BR_Information_PatientNo = BC001O4_A519VIEW_LPI_BR_Information_PatientNo[0];
            A521VIEW_LPI_BR_Encounter_AdmitDate = BC001O4_A521VIEW_LPI_BR_Encounter_AdmitDate[0];
            A522VIEW_LPI_BR_Demographics_Sex = BC001O4_A522VIEW_LPI_BR_Demographics_Sex[0];
            A523VIEW_LPI_BR_Demographics_BirthDate = BC001O4_A523VIEW_LPI_BR_Demographics_BirthDate[0];
            A524VIEW_LPI_BR_Demographics_Ethnic = BC001O4_A524VIEW_LPI_BR_Demographics_Ethnic[0];
            ZM1O71( -3) ;
         }
         pr_default.close(2);
         OnLoadActions1O71( ) ;
      }

      protected void OnLoadActions1O71( )
      {
      }

      protected void CheckExtendedTable1O71( )
      {
         standaloneModal( ) ;
         if ( ! ( (DateTime.MinValue==A521VIEW_LPI_BR_Encounter_AdmitDate) || ( A521VIEW_LPI_BR_Encounter_AdmitDate >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("域VIEW_LPI_BR_Encounter_Admit Date超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
         if ( ! ( (DateTime.MinValue==A523VIEW_LPI_BR_Demographics_BirthDate) || ( A523VIEW_LPI_BR_Demographics_BirthDate >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("域VIEW_LPI_BR_Demographics_Birth Date超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
      }

      protected void CloseExtendedTableCursors1O71( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey1O71( )
      {
         /* Using cursor BC001O5 */
         pr_default.execute(3, new Object[] {A520VIEW_LPI_BR_Information_ID});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound71 = 1;
         }
         else
         {
            RcdFound71 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC001O3 */
         pr_default.execute(1, new Object[] {A520VIEW_LPI_BR_Information_ID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM1O71( 3) ;
            RcdFound71 = 1;
            A520VIEW_LPI_BR_Information_ID = BC001O3_A520VIEW_LPI_BR_Information_ID[0];
            A519VIEW_LPI_BR_Information_PatientNo = BC001O3_A519VIEW_LPI_BR_Information_PatientNo[0];
            A521VIEW_LPI_BR_Encounter_AdmitDate = BC001O3_A521VIEW_LPI_BR_Encounter_AdmitDate[0];
            A522VIEW_LPI_BR_Demographics_Sex = BC001O3_A522VIEW_LPI_BR_Demographics_Sex[0];
            A523VIEW_LPI_BR_Demographics_BirthDate = BC001O3_A523VIEW_LPI_BR_Demographics_BirthDate[0];
            A524VIEW_LPI_BR_Demographics_Ethnic = BC001O3_A524VIEW_LPI_BR_Demographics_Ethnic[0];
            Z520VIEW_LPI_BR_Information_ID = A520VIEW_LPI_BR_Information_ID;
            sMode71 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load1O71( ) ;
            if ( AnyError == 1 )
            {
               RcdFound71 = 0;
               InitializeNonKey1O71( ) ;
            }
            Gx_mode = sMode71;
         }
         else
         {
            RcdFound71 = 0;
            InitializeNonKey1O71( ) ;
            sMode71 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode71;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1O71( ) ;
         if ( RcdFound71 == 0 )
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
         CONFIRM_1O0( ) ;
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

      protected void CheckOptimisticConcurrency1O71( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC001O2 */
            pr_default.execute(0, new Object[] {A520VIEW_LPI_BR_Information_ID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"VIEW_LASTEST_PATIENT_INFO"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z519VIEW_LPI_BR_Information_PatientNo, BC001O2_A519VIEW_LPI_BR_Information_PatientNo[0]) != 0 ) || ( Z521VIEW_LPI_BR_Encounter_AdmitDate != BC001O2_A521VIEW_LPI_BR_Encounter_AdmitDate[0] ) || ( StringUtil.StrCmp(Z522VIEW_LPI_BR_Demographics_Sex, BC001O2_A522VIEW_LPI_BR_Demographics_Sex[0]) != 0 ) || ( Z523VIEW_LPI_BR_Demographics_BirthDate != BC001O2_A523VIEW_LPI_BR_Demographics_BirthDate[0] ) || ( StringUtil.StrCmp(Z524VIEW_LPI_BR_Demographics_Ethnic, BC001O2_A524VIEW_LPI_BR_Demographics_Ethnic[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"VIEW_LASTEST_PATIENT_INFO"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert1O71( )
      {
         BeforeValidate1O71( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1O71( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1O71( 0) ;
            CheckOptimisticConcurrency1O71( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1O71( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1O71( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC001O6 */
                     pr_default.execute(4, new Object[] {A520VIEW_LPI_BR_Information_ID, A519VIEW_LPI_BR_Information_PatientNo, A521VIEW_LPI_BR_Encounter_AdmitDate, A522VIEW_LPI_BR_Demographics_Sex, A523VIEW_LPI_BR_Demographics_BirthDate, A524VIEW_LPI_BR_Demographics_Ethnic});
                     pr_default.close(4);
                     dsDefault.SmartCacheProvider.SetUpdated("VIEW_LASTEST_PATIENT_INFO") ;
                     if ( (pr_default.getStatus(4) == 1) )
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
               Load1O71( ) ;
            }
            EndLevel1O71( ) ;
         }
         CloseExtendedTableCursors1O71( ) ;
      }

      protected void Update1O71( )
      {
         BeforeValidate1O71( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1O71( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1O71( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1O71( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1O71( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC001O7 */
                     pr_default.execute(5, new Object[] {A519VIEW_LPI_BR_Information_PatientNo, A521VIEW_LPI_BR_Encounter_AdmitDate, A522VIEW_LPI_BR_Demographics_Sex, A523VIEW_LPI_BR_Demographics_BirthDate, A524VIEW_LPI_BR_Demographics_Ethnic, A520VIEW_LPI_BR_Information_ID});
                     pr_default.close(5);
                     dsDefault.SmartCacheProvider.SetUpdated("VIEW_LASTEST_PATIENT_INFO") ;
                     if ( (pr_default.getStatus(5) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"VIEW_LASTEST_PATIENT_INFO"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate1O71( ) ;
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
            EndLevel1O71( ) ;
         }
         CloseExtendedTableCursors1O71( ) ;
      }

      protected void DeferredUpdate1O71( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate1O71( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1O71( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1O71( ) ;
            AfterConfirm1O71( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1O71( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC001O8 */
                  pr_default.execute(6, new Object[] {A520VIEW_LPI_BR_Information_ID});
                  pr_default.close(6);
                  dsDefault.SmartCacheProvider.SetUpdated("VIEW_LASTEST_PATIENT_INFO") ;
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
         sMode71 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel1O71( ) ;
         Gx_mode = sMode71;
      }

      protected void OnDeleteControls1O71( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel1O71( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1O71( ) ;
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

      public void ScanKeyStart1O71( )
      {
         /* Using cursor BC001O9 */
         pr_default.execute(7, new Object[] {A520VIEW_LPI_BR_Information_ID});
         RcdFound71 = 0;
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound71 = 1;
            A520VIEW_LPI_BR_Information_ID = BC001O9_A520VIEW_LPI_BR_Information_ID[0];
            A519VIEW_LPI_BR_Information_PatientNo = BC001O9_A519VIEW_LPI_BR_Information_PatientNo[0];
            A521VIEW_LPI_BR_Encounter_AdmitDate = BC001O9_A521VIEW_LPI_BR_Encounter_AdmitDate[0];
            A522VIEW_LPI_BR_Demographics_Sex = BC001O9_A522VIEW_LPI_BR_Demographics_Sex[0];
            A523VIEW_LPI_BR_Demographics_BirthDate = BC001O9_A523VIEW_LPI_BR_Demographics_BirthDate[0];
            A524VIEW_LPI_BR_Demographics_Ethnic = BC001O9_A524VIEW_LPI_BR_Demographics_Ethnic[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext1O71( )
      {
         /* Scan next routine */
         pr_default.readNext(7);
         RcdFound71 = 0;
         ScanKeyLoad1O71( ) ;
      }

      protected void ScanKeyLoad1O71( )
      {
         sMode71 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound71 = 1;
            A520VIEW_LPI_BR_Information_ID = BC001O9_A520VIEW_LPI_BR_Information_ID[0];
            A519VIEW_LPI_BR_Information_PatientNo = BC001O9_A519VIEW_LPI_BR_Information_PatientNo[0];
            A521VIEW_LPI_BR_Encounter_AdmitDate = BC001O9_A521VIEW_LPI_BR_Encounter_AdmitDate[0];
            A522VIEW_LPI_BR_Demographics_Sex = BC001O9_A522VIEW_LPI_BR_Demographics_Sex[0];
            A523VIEW_LPI_BR_Demographics_BirthDate = BC001O9_A523VIEW_LPI_BR_Demographics_BirthDate[0];
            A524VIEW_LPI_BR_Demographics_Ethnic = BC001O9_A524VIEW_LPI_BR_Demographics_Ethnic[0];
         }
         Gx_mode = sMode71;
      }

      protected void ScanKeyEnd1O71( )
      {
         pr_default.close(7);
      }

      protected void AfterConfirm1O71( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1O71( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1O71( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1O71( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1O71( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1O71( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1O71( )
      {
      }

      protected void send_integrity_lvl_hashes1O71( )
      {
      }

      protected void AddRow1O71( )
      {
         VarsToRow71( bcview_lastest_patient_info) ;
      }

      protected void ReadRow1O71( )
      {
         RowToVars71( bcview_lastest_patient_info, 1) ;
      }

      protected void InitializeNonKey1O71( )
      {
         A519VIEW_LPI_BR_Information_PatientNo = "";
         A521VIEW_LPI_BR_Encounter_AdmitDate = (DateTime)(DateTime.MinValue);
         A522VIEW_LPI_BR_Demographics_Sex = "";
         A523VIEW_LPI_BR_Demographics_BirthDate = DateTime.MinValue;
         A524VIEW_LPI_BR_Demographics_Ethnic = "";
         Z519VIEW_LPI_BR_Information_PatientNo = "";
         Z521VIEW_LPI_BR_Encounter_AdmitDate = (DateTime)(DateTime.MinValue);
         Z522VIEW_LPI_BR_Demographics_Sex = "";
         Z523VIEW_LPI_BR_Demographics_BirthDate = DateTime.MinValue;
         Z524VIEW_LPI_BR_Demographics_Ethnic = "";
      }

      protected void InitAll1O71( )
      {
         A520VIEW_LPI_BR_Information_ID = 0;
         InitializeNonKey1O71( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow71( Sdtview_lastest_patient_info obj71 )
      {
         obj71.gxTpr_Mode = Gx_mode;
         obj71.gxTpr_View_lpi_br_information_patientno = A519VIEW_LPI_BR_Information_PatientNo;
         obj71.gxTpr_View_lpi_br_encounter_admitdate = A521VIEW_LPI_BR_Encounter_AdmitDate;
         obj71.gxTpr_View_lpi_br_demographics_sex = A522VIEW_LPI_BR_Demographics_Sex;
         obj71.gxTpr_View_lpi_br_demographics_birthdate = A523VIEW_LPI_BR_Demographics_BirthDate;
         obj71.gxTpr_View_lpi_br_demographics_ethnic = A524VIEW_LPI_BR_Demographics_Ethnic;
         obj71.gxTpr_View_lpi_br_information_id = A520VIEW_LPI_BR_Information_ID;
         obj71.gxTpr_View_lpi_br_information_id_Z = Z520VIEW_LPI_BR_Information_ID;
         obj71.gxTpr_View_lpi_br_information_patientno_Z = Z519VIEW_LPI_BR_Information_PatientNo;
         obj71.gxTpr_View_lpi_br_encounter_admitdate_Z = Z521VIEW_LPI_BR_Encounter_AdmitDate;
         obj71.gxTpr_View_lpi_br_demographics_sex_Z = Z522VIEW_LPI_BR_Demographics_Sex;
         obj71.gxTpr_View_lpi_br_demographics_birthdate_Z = Z523VIEW_LPI_BR_Demographics_BirthDate;
         obj71.gxTpr_View_lpi_br_demographics_ethnic_Z = Z524VIEW_LPI_BR_Demographics_Ethnic;
         obj71.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow71( Sdtview_lastest_patient_info obj71 )
      {
         obj71.gxTpr_View_lpi_br_information_id = A520VIEW_LPI_BR_Information_ID;
         return  ;
      }

      public void RowToVars71( Sdtview_lastest_patient_info obj71 ,
                               int forceLoad )
      {
         Gx_mode = obj71.gxTpr_Mode;
         A519VIEW_LPI_BR_Information_PatientNo = obj71.gxTpr_View_lpi_br_information_patientno;
         A521VIEW_LPI_BR_Encounter_AdmitDate = obj71.gxTpr_View_lpi_br_encounter_admitdate;
         A522VIEW_LPI_BR_Demographics_Sex = obj71.gxTpr_View_lpi_br_demographics_sex;
         A523VIEW_LPI_BR_Demographics_BirthDate = obj71.gxTpr_View_lpi_br_demographics_birthdate;
         A524VIEW_LPI_BR_Demographics_Ethnic = obj71.gxTpr_View_lpi_br_demographics_ethnic;
         A520VIEW_LPI_BR_Information_ID = obj71.gxTpr_View_lpi_br_information_id;
         Z520VIEW_LPI_BR_Information_ID = obj71.gxTpr_View_lpi_br_information_id_Z;
         Z519VIEW_LPI_BR_Information_PatientNo = obj71.gxTpr_View_lpi_br_information_patientno_Z;
         Z521VIEW_LPI_BR_Encounter_AdmitDate = obj71.gxTpr_View_lpi_br_encounter_admitdate_Z;
         Z522VIEW_LPI_BR_Demographics_Sex = obj71.gxTpr_View_lpi_br_demographics_sex_Z;
         Z523VIEW_LPI_BR_Demographics_BirthDate = obj71.gxTpr_View_lpi_br_demographics_birthdate_Z;
         Z524VIEW_LPI_BR_Demographics_Ethnic = obj71.gxTpr_View_lpi_br_demographics_ethnic_Z;
         Gx_mode = obj71.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A520VIEW_LPI_BR_Information_ID = (long)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey1O71( ) ;
         ScanKeyStart1O71( ) ;
         if ( RcdFound71 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z520VIEW_LPI_BR_Information_ID = A520VIEW_LPI_BR_Information_ID;
         }
         ZM1O71( -3) ;
         OnLoadActions1O71( ) ;
         AddRow1O71( ) ;
         ScanKeyEnd1O71( ) ;
         if ( RcdFound71 == 0 )
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
         RowToVars71( bcview_lastest_patient_info, 0) ;
         ScanKeyStart1O71( ) ;
         if ( RcdFound71 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z520VIEW_LPI_BR_Information_ID = A520VIEW_LPI_BR_Information_ID;
         }
         ZM1O71( -3) ;
         OnLoadActions1O71( ) ;
         AddRow1O71( ) ;
         ScanKeyEnd1O71( ) ;
         if ( RcdFound71 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey1O71( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert1O71( ) ;
         }
         else
         {
            if ( RcdFound71 == 1 )
            {
               if ( A520VIEW_LPI_BR_Information_ID != Z520VIEW_LPI_BR_Information_ID )
               {
                  A520VIEW_LPI_BR_Information_ID = Z520VIEW_LPI_BR_Information_ID;
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
                  Update1O71( ) ;
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
                  if ( A520VIEW_LPI_BR_Information_ID != Z520VIEW_LPI_BR_Information_ID )
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
                        Insert1O71( ) ;
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
                        Insert1O71( ) ;
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
         RowToVars71( bcview_lastest_patient_info, 0) ;
         SaveImpl( ) ;
         VarsToRow71( bcview_lastest_patient_info) ;
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
         RowToVars71( bcview_lastest_patient_info, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert1O71( ) ;
         AfterTrn( ) ;
         VarsToRow71( bcview_lastest_patient_info) ;
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
            Sdtview_lastest_patient_info auxBC = new Sdtview_lastest_patient_info(context) ;
            auxBC.Load(A520VIEW_LPI_BR_Information_ID);
            auxBC.UpdateDirties(bcview_lastest_patient_info);
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
         RowToVars71( bcview_lastest_patient_info, 0) ;
         UpdateImpl( ) ;
         VarsToRow71( bcview_lastest_patient_info) ;
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
         RowToVars71( bcview_lastest_patient_info, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert1O71( ) ;
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
         VarsToRow71( bcview_lastest_patient_info) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars71( bcview_lastest_patient_info, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey1O71( ) ;
         if ( RcdFound71 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A520VIEW_LPI_BR_Information_ID != Z520VIEW_LPI_BR_Information_ID )
            {
               A520VIEW_LPI_BR_Information_ID = Z520VIEW_LPI_BR_Information_ID;
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
            if ( A520VIEW_LPI_BR_Information_ID != Z520VIEW_LPI_BR_Information_ID )
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
         context.RollbackDataStores("view_lastest_patient_info_bc",pr_default);
         VarsToRow71( bcview_lastest_patient_info) ;
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
         Gx_mode = bcview_lastest_patient_info.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcview_lastest_patient_info.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcview_lastest_patient_info )
         {
            bcview_lastest_patient_info = (Sdtview_lastest_patient_info)(sdt);
            if ( StringUtil.StrCmp(bcview_lastest_patient_info.gxTpr_Mode, "") == 0 )
            {
               bcview_lastest_patient_info.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow71( bcview_lastest_patient_info) ;
            }
            else
            {
               RowToVars71( bcview_lastest_patient_info, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcview_lastest_patient_info.gxTpr_Mode, "") == 0 )
            {
               bcview_lastest_patient_info.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars71( bcview_lastest_patient_info, 1) ;
         return  ;
      }

      public Sdtview_lastest_patient_info view_lastest_patient_info_BC
      {
         get {
            return bcview_lastest_patient_info ;
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
         Z519VIEW_LPI_BR_Information_PatientNo = "";
         A519VIEW_LPI_BR_Information_PatientNo = "";
         Z521VIEW_LPI_BR_Encounter_AdmitDate = (DateTime)(DateTime.MinValue);
         A521VIEW_LPI_BR_Encounter_AdmitDate = (DateTime)(DateTime.MinValue);
         Z522VIEW_LPI_BR_Demographics_Sex = "";
         A522VIEW_LPI_BR_Demographics_Sex = "";
         Z523VIEW_LPI_BR_Demographics_BirthDate = DateTime.MinValue;
         A523VIEW_LPI_BR_Demographics_BirthDate = DateTime.MinValue;
         Z524VIEW_LPI_BR_Demographics_Ethnic = "";
         A524VIEW_LPI_BR_Demographics_Ethnic = "";
         BC001O4_A520VIEW_LPI_BR_Information_ID = new long[1] ;
         BC001O4_A519VIEW_LPI_BR_Information_PatientNo = new String[] {""} ;
         BC001O4_A521VIEW_LPI_BR_Encounter_AdmitDate = new DateTime[] {DateTime.MinValue} ;
         BC001O4_A522VIEW_LPI_BR_Demographics_Sex = new String[] {""} ;
         BC001O4_A523VIEW_LPI_BR_Demographics_BirthDate = new DateTime[] {DateTime.MinValue} ;
         BC001O4_A524VIEW_LPI_BR_Demographics_Ethnic = new String[] {""} ;
         BC001O5_A520VIEW_LPI_BR_Information_ID = new long[1] ;
         BC001O3_A520VIEW_LPI_BR_Information_ID = new long[1] ;
         BC001O3_A519VIEW_LPI_BR_Information_PatientNo = new String[] {""} ;
         BC001O3_A521VIEW_LPI_BR_Encounter_AdmitDate = new DateTime[] {DateTime.MinValue} ;
         BC001O3_A522VIEW_LPI_BR_Demographics_Sex = new String[] {""} ;
         BC001O3_A523VIEW_LPI_BR_Demographics_BirthDate = new DateTime[] {DateTime.MinValue} ;
         BC001O3_A524VIEW_LPI_BR_Demographics_Ethnic = new String[] {""} ;
         sMode71 = "";
         BC001O2_A520VIEW_LPI_BR_Information_ID = new long[1] ;
         BC001O2_A519VIEW_LPI_BR_Information_PatientNo = new String[] {""} ;
         BC001O2_A521VIEW_LPI_BR_Encounter_AdmitDate = new DateTime[] {DateTime.MinValue} ;
         BC001O2_A522VIEW_LPI_BR_Demographics_Sex = new String[] {""} ;
         BC001O2_A523VIEW_LPI_BR_Demographics_BirthDate = new DateTime[] {DateTime.MinValue} ;
         BC001O2_A524VIEW_LPI_BR_Demographics_Ethnic = new String[] {""} ;
         BC001O9_A520VIEW_LPI_BR_Information_ID = new long[1] ;
         BC001O9_A519VIEW_LPI_BR_Information_PatientNo = new String[] {""} ;
         BC001O9_A521VIEW_LPI_BR_Encounter_AdmitDate = new DateTime[] {DateTime.MinValue} ;
         BC001O9_A522VIEW_LPI_BR_Demographics_Sex = new String[] {""} ;
         BC001O9_A523VIEW_LPI_BR_Demographics_BirthDate = new DateTime[] {DateTime.MinValue} ;
         BC001O9_A524VIEW_LPI_BR_Demographics_Ethnic = new String[] {""} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.view_lastest_patient_info_bc__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.view_lastest_patient_info_bc__default(),
            new Object[][] {
                new Object[] {
               BC001O2_A520VIEW_LPI_BR_Information_ID, BC001O2_A519VIEW_LPI_BR_Information_PatientNo, BC001O2_A521VIEW_LPI_BR_Encounter_AdmitDate, BC001O2_A522VIEW_LPI_BR_Demographics_Sex, BC001O2_A523VIEW_LPI_BR_Demographics_BirthDate, BC001O2_A524VIEW_LPI_BR_Demographics_Ethnic
               }
               , new Object[] {
               BC001O3_A520VIEW_LPI_BR_Information_ID, BC001O3_A519VIEW_LPI_BR_Information_PatientNo, BC001O3_A521VIEW_LPI_BR_Encounter_AdmitDate, BC001O3_A522VIEW_LPI_BR_Demographics_Sex, BC001O3_A523VIEW_LPI_BR_Demographics_BirthDate, BC001O3_A524VIEW_LPI_BR_Demographics_Ethnic
               }
               , new Object[] {
               BC001O4_A520VIEW_LPI_BR_Information_ID, BC001O4_A519VIEW_LPI_BR_Information_PatientNo, BC001O4_A521VIEW_LPI_BR_Encounter_AdmitDate, BC001O4_A522VIEW_LPI_BR_Demographics_Sex, BC001O4_A523VIEW_LPI_BR_Demographics_BirthDate, BC001O4_A524VIEW_LPI_BR_Demographics_Ethnic
               }
               , new Object[] {
               BC001O5_A520VIEW_LPI_BR_Information_ID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC001O9_A520VIEW_LPI_BR_Information_ID, BC001O9_A519VIEW_LPI_BR_Information_PatientNo, BC001O9_A521VIEW_LPI_BR_Encounter_AdmitDate, BC001O9_A522VIEW_LPI_BR_Demographics_Sex, BC001O9_A523VIEW_LPI_BR_Demographics_BirthDate, BC001O9_A524VIEW_LPI_BR_Demographics_Ethnic
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
      private short RcdFound71 ;
      private int trnEnded ;
      private long Z520VIEW_LPI_BR_Information_ID ;
      private long A520VIEW_LPI_BR_Information_ID ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String sMode71 ;
      private DateTime Z521VIEW_LPI_BR_Encounter_AdmitDate ;
      private DateTime A521VIEW_LPI_BR_Encounter_AdmitDate ;
      private DateTime Z523VIEW_LPI_BR_Demographics_BirthDate ;
      private DateTime A523VIEW_LPI_BR_Demographics_BirthDate ;
      private String Z519VIEW_LPI_BR_Information_PatientNo ;
      private String A519VIEW_LPI_BR_Information_PatientNo ;
      private String Z522VIEW_LPI_BR_Demographics_Sex ;
      private String A522VIEW_LPI_BR_Demographics_Sex ;
      private String Z524VIEW_LPI_BR_Demographics_Ethnic ;
      private String A524VIEW_LPI_BR_Demographics_Ethnic ;
      private Sdtview_lastest_patient_info bcview_lastest_patient_info ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] BC001O4_A520VIEW_LPI_BR_Information_ID ;
      private String[] BC001O4_A519VIEW_LPI_BR_Information_PatientNo ;
      private DateTime[] BC001O4_A521VIEW_LPI_BR_Encounter_AdmitDate ;
      private String[] BC001O4_A522VIEW_LPI_BR_Demographics_Sex ;
      private DateTime[] BC001O4_A523VIEW_LPI_BR_Demographics_BirthDate ;
      private String[] BC001O4_A524VIEW_LPI_BR_Demographics_Ethnic ;
      private long[] BC001O5_A520VIEW_LPI_BR_Information_ID ;
      private long[] BC001O3_A520VIEW_LPI_BR_Information_ID ;
      private String[] BC001O3_A519VIEW_LPI_BR_Information_PatientNo ;
      private DateTime[] BC001O3_A521VIEW_LPI_BR_Encounter_AdmitDate ;
      private String[] BC001O3_A522VIEW_LPI_BR_Demographics_Sex ;
      private DateTime[] BC001O3_A523VIEW_LPI_BR_Demographics_BirthDate ;
      private String[] BC001O3_A524VIEW_LPI_BR_Demographics_Ethnic ;
      private long[] BC001O2_A520VIEW_LPI_BR_Information_ID ;
      private String[] BC001O2_A519VIEW_LPI_BR_Information_PatientNo ;
      private DateTime[] BC001O2_A521VIEW_LPI_BR_Encounter_AdmitDate ;
      private String[] BC001O2_A522VIEW_LPI_BR_Demographics_Sex ;
      private DateTime[] BC001O2_A523VIEW_LPI_BR_Demographics_BirthDate ;
      private String[] BC001O2_A524VIEW_LPI_BR_Demographics_Ethnic ;
      private long[] BC001O9_A520VIEW_LPI_BR_Information_ID ;
      private String[] BC001O9_A519VIEW_LPI_BR_Information_PatientNo ;
      private DateTime[] BC001O9_A521VIEW_LPI_BR_Encounter_AdmitDate ;
      private String[] BC001O9_A522VIEW_LPI_BR_Demographics_Sex ;
      private DateTime[] BC001O9_A523VIEW_LPI_BR_Demographics_BirthDate ;
      private String[] BC001O9_A524VIEW_LPI_BR_Demographics_Ethnic ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_datastore1 ;
   }

   public class view_lastest_patient_info_bc__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class view_lastest_patient_info_bc__default : DataStoreHelperBase, IDataStoreHelper
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
        Object[] prmBC001O4 ;
        prmBC001O4 = new Object[] {
        new Object[] {"@VIEW_LPI_BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC001O5 ;
        prmBC001O5 = new Object[] {
        new Object[] {"@VIEW_LPI_BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC001O3 ;
        prmBC001O3 = new Object[] {
        new Object[] {"@VIEW_LPI_BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC001O2 ;
        prmBC001O2 = new Object[] {
        new Object[] {"@VIEW_LPI_BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC001O6 ;
        prmBC001O6 = new Object[] {
        new Object[] {"@VIEW_LPI_BR_Information_ID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@VIEW_LPI_BR_Information_PatientNo",SqlDbType.NVarChar,4000,0} ,
        new Object[] {"@VIEW_LPI_BR_Encounter_AdmitDate",SqlDbType.DateTime,10,8} ,
        new Object[] {"@VIEW_LPI_BR_Demographics_Sex",SqlDbType.NVarChar,4000,0} ,
        new Object[] {"@VIEW_LPI_BR_Demographics_BirthDate",SqlDbType.DateTime,8,0} ,
        new Object[] {"@VIEW_LPI_BR_Demographics_Ethnic",SqlDbType.NVarChar,4000,0}
        } ;
        Object[] prmBC001O7 ;
        prmBC001O7 = new Object[] {
        new Object[] {"@VIEW_LPI_BR_Information_PatientNo",SqlDbType.NVarChar,4000,0} ,
        new Object[] {"@VIEW_LPI_BR_Encounter_AdmitDate",SqlDbType.DateTime,10,8} ,
        new Object[] {"@VIEW_LPI_BR_Demographics_Sex",SqlDbType.NVarChar,4000,0} ,
        new Object[] {"@VIEW_LPI_BR_Demographics_BirthDate",SqlDbType.DateTime,8,0} ,
        new Object[] {"@VIEW_LPI_BR_Demographics_Ethnic",SqlDbType.NVarChar,4000,0} ,
        new Object[] {"@VIEW_LPI_BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC001O8 ;
        prmBC001O8 = new Object[] {
        new Object[] {"@VIEW_LPI_BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC001O9 ;
        prmBC001O9 = new Object[] {
        new Object[] {"@VIEW_LPI_BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("BC001O2", "SELECT [VIEW_LPI_BR_Information_ID], [VIEW_LPI_BR_Information_PatientNo], [VIEW_LPI_BR_Encounter_AdmitDate], [VIEW_LPI_BR_Demographics_Sex], [VIEW_LPI_BR_Demographics_BirthDate], [VIEW_LPI_BR_Demographics_Ethnic] FROM dbo.[view_lastest_patient_info] WITH (UPDLOCK) WHERE [VIEW_LPI_BR_Information_ID] = @VIEW_LPI_BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001O2,1,0,true,false )
           ,new CursorDef("BC001O3", "SELECT [VIEW_LPI_BR_Information_ID], [VIEW_LPI_BR_Information_PatientNo], [VIEW_LPI_BR_Encounter_AdmitDate], [VIEW_LPI_BR_Demographics_Sex], [VIEW_LPI_BR_Demographics_BirthDate], [VIEW_LPI_BR_Demographics_Ethnic] FROM dbo.[view_lastest_patient_info] WITH (NOLOCK) WHERE [VIEW_LPI_BR_Information_ID] = @VIEW_LPI_BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001O3,1,0,true,false )
           ,new CursorDef("BC001O4", "SELECT TM1.[VIEW_LPI_BR_Information_ID], TM1.[VIEW_LPI_BR_Information_PatientNo], TM1.[VIEW_LPI_BR_Encounter_AdmitDate], TM1.[VIEW_LPI_BR_Demographics_Sex], TM1.[VIEW_LPI_BR_Demographics_BirthDate], TM1.[VIEW_LPI_BR_Demographics_Ethnic] FROM dbo.[view_lastest_patient_info] TM1 WITH (NOLOCK) WHERE TM1.[VIEW_LPI_BR_Information_ID] = @VIEW_LPI_BR_Information_ID ORDER BY TM1.[VIEW_LPI_BR_Information_ID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001O4,100,0,true,false )
           ,new CursorDef("BC001O5", "SELECT [VIEW_LPI_BR_Information_ID] FROM dbo.[view_lastest_patient_info] WITH (NOLOCK) WHERE [VIEW_LPI_BR_Information_ID] = @VIEW_LPI_BR_Information_ID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001O5,1,0,true,false )
           ,new CursorDef("BC001O6", "INSERT INTO dbo.[view_lastest_patient_info]([VIEW_LPI_BR_Information_ID], [VIEW_LPI_BR_Information_PatientNo], [VIEW_LPI_BR_Encounter_AdmitDate], [VIEW_LPI_BR_Demographics_Sex], [VIEW_LPI_BR_Demographics_BirthDate], [VIEW_LPI_BR_Demographics_Ethnic]) VALUES(@VIEW_LPI_BR_Information_ID, @VIEW_LPI_BR_Information_PatientNo, @VIEW_LPI_BR_Encounter_AdmitDate, @VIEW_LPI_BR_Demographics_Sex, @VIEW_LPI_BR_Demographics_BirthDate, @VIEW_LPI_BR_Demographics_Ethnic)", GxErrorMask.GX_NOMASK,prmBC001O6)
           ,new CursorDef("BC001O7", "UPDATE dbo.[view_lastest_patient_info] SET [VIEW_LPI_BR_Information_PatientNo]=@VIEW_LPI_BR_Information_PatientNo, [VIEW_LPI_BR_Encounter_AdmitDate]=@VIEW_LPI_BR_Encounter_AdmitDate, [VIEW_LPI_BR_Demographics_Sex]=@VIEW_LPI_BR_Demographics_Sex, [VIEW_LPI_BR_Demographics_BirthDate]=@VIEW_LPI_BR_Demographics_BirthDate, [VIEW_LPI_BR_Demographics_Ethnic]=@VIEW_LPI_BR_Demographics_Ethnic  WHERE [VIEW_LPI_BR_Information_ID] = @VIEW_LPI_BR_Information_ID", GxErrorMask.GX_NOMASK,prmBC001O7)
           ,new CursorDef("BC001O8", "DELETE FROM dbo.[view_lastest_patient_info]  WHERE [VIEW_LPI_BR_Information_ID] = @VIEW_LPI_BR_Information_ID", GxErrorMask.GX_NOMASK,prmBC001O8)
           ,new CursorDef("BC001O9", "SELECT TM1.[VIEW_LPI_BR_Information_ID], TM1.[VIEW_LPI_BR_Information_PatientNo], TM1.[VIEW_LPI_BR_Encounter_AdmitDate], TM1.[VIEW_LPI_BR_Demographics_Sex], TM1.[VIEW_LPI_BR_Demographics_BirthDate], TM1.[VIEW_LPI_BR_Demographics_Ethnic] FROM dbo.[view_lastest_patient_info] TM1 WITH (NOLOCK) WHERE TM1.[VIEW_LPI_BR_Information_ID] = @VIEW_LPI_BR_Information_ID ORDER BY TM1.[VIEW_LPI_BR_Information_ID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001O9,100,0,true,false )
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
              ((DateTime[]) buf[2])[0] = rslt.getGXDateTime(3) ;
              ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
              ((DateTime[]) buf[4])[0] = rslt.getGXDate(5) ;
              ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((DateTime[]) buf[2])[0] = rslt.getGXDateTime(3) ;
              ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
              ((DateTime[]) buf[4])[0] = rslt.getGXDate(5) ;
              ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
              return;
           case 2 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((DateTime[]) buf[2])[0] = rslt.getGXDateTime(3) ;
              ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
              ((DateTime[]) buf[4])[0] = rslt.getGXDate(5) ;
              ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
              return;
           case 3 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 7 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((DateTime[]) buf[2])[0] = rslt.getGXDateTime(3) ;
              ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
              ((DateTime[]) buf[4])[0] = rslt.getGXDate(5) ;
              ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
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
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 3 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 4 :
              stmt.SetParameter(1, (long)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              stmt.SetParameterDatetime(3, (DateTime)parms[2]);
              stmt.SetParameter(4, (String)parms[3]);
              stmt.SetParameter(5, (DateTime)parms[4]);
              stmt.SetParameter(6, (String)parms[5]);
              return;
           case 5 :
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameterDatetime(2, (DateTime)parms[1]);
              stmt.SetParameter(3, (String)parms[2]);
              stmt.SetParameter(4, (DateTime)parms[3]);
              stmt.SetParameter(5, (String)parms[4]);
              stmt.SetParameter(6, (long)parms[5]);
              return;
           case 6 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 7 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
     }
  }

}

}
