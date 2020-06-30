/*
               File: View_New_Encounter_BC
        Description: View_New_Encounter
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:39:6.34
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
   public class view_new_encounter_bc : GXHttpHandler, IGxSilentTrn
   {
      public view_new_encounter_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public view_new_encounter_bc( IGxContext context )
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
         ReadRow1Q72( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey1Q72( ) ;
         standaloneModal( ) ;
         AddRow1Q72( ) ;
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
               Z549view_NE_EncounterID = A549view_NE_EncounterID;
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

      protected void CONFIRM_1Q0( )
      {
         BeforeValidate1Q72( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls1Q72( ) ;
            }
            else
            {
               CheckExtendedTable1Q72( ) ;
               if ( AnyError == 0 )
               {
               }
               CloseExtendedTableCursors1Q72( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void ZM1Q72( short GX_JID )
      {
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            Z550view_NE_Department = A550view_NE_Department;
            Z551view_NE_ENCType = A551view_NE_ENCType;
            Z552view_NE_AdmitDate = A552view_NE_AdmitDate;
            Z553view_NE_Status = A553view_NE_Status;
            Z554view_NE_IsRandRecheck = A554view_NE_IsRandRecheck;
            Z555view_NE_IsRandApprove = A555view_NE_IsRandApprove;
            Z556view_NE_IsUpdate = A556view_NE_IsUpdate;
            Z557view_NE_TenantTenantCode = A557view_NE_TenantTenantCode;
            Z558view_NE_Information_ID = A558view_NE_Information_ID;
            Z559view_NE_Information_PatientNo = A559view_NE_Information_PatientNo;
         }
         if ( GX_JID == -3 )
         {
            Z549view_NE_EncounterID = A549view_NE_EncounterID;
            Z550view_NE_Department = A550view_NE_Department;
            Z551view_NE_ENCType = A551view_NE_ENCType;
            Z552view_NE_AdmitDate = A552view_NE_AdmitDate;
            Z553view_NE_Status = A553view_NE_Status;
            Z554view_NE_IsRandRecheck = A554view_NE_IsRandRecheck;
            Z555view_NE_IsRandApprove = A555view_NE_IsRandApprove;
            Z556view_NE_IsUpdate = A556view_NE_IsUpdate;
            Z557view_NE_TenantTenantCode = A557view_NE_TenantTenantCode;
            Z558view_NE_Information_ID = A558view_NE_Information_ID;
            Z559view_NE_Information_PatientNo = A559view_NE_Information_PatientNo;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load1Q72( )
      {
         /* Using cursor BC001Q4 */
         pr_default.execute(2, new Object[] {A549view_NE_EncounterID});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound72 = 1;
            A550view_NE_Department = BC001Q4_A550view_NE_Department[0];
            n550view_NE_Department = BC001Q4_n550view_NE_Department[0];
            A551view_NE_ENCType = BC001Q4_A551view_NE_ENCType[0];
            n551view_NE_ENCType = BC001Q4_n551view_NE_ENCType[0];
            A552view_NE_AdmitDate = BC001Q4_A552view_NE_AdmitDate[0];
            n552view_NE_AdmitDate = BC001Q4_n552view_NE_AdmitDate[0];
            A553view_NE_Status = BC001Q4_A553view_NE_Status[0];
            n553view_NE_Status = BC001Q4_n553view_NE_Status[0];
            A554view_NE_IsRandRecheck = BC001Q4_A554view_NE_IsRandRecheck[0];
            n554view_NE_IsRandRecheck = BC001Q4_n554view_NE_IsRandRecheck[0];
            A555view_NE_IsRandApprove = BC001Q4_A555view_NE_IsRandApprove[0];
            n555view_NE_IsRandApprove = BC001Q4_n555view_NE_IsRandApprove[0];
            A556view_NE_IsUpdate = BC001Q4_A556view_NE_IsUpdate[0];
            n556view_NE_IsUpdate = BC001Q4_n556view_NE_IsUpdate[0];
            A557view_NE_TenantTenantCode = BC001Q4_A557view_NE_TenantTenantCode[0];
            n557view_NE_TenantTenantCode = BC001Q4_n557view_NE_TenantTenantCode[0];
            A558view_NE_Information_ID = BC001Q4_A558view_NE_Information_ID[0];
            n558view_NE_Information_ID = BC001Q4_n558view_NE_Information_ID[0];
            A559view_NE_Information_PatientNo = BC001Q4_A559view_NE_Information_PatientNo[0];
            n559view_NE_Information_PatientNo = BC001Q4_n559view_NE_Information_PatientNo[0];
            ZM1Q72( -3) ;
         }
         pr_default.close(2);
         OnLoadActions1Q72( ) ;
      }

      protected void OnLoadActions1Q72( )
      {
      }

      protected void CheckExtendedTable1Q72( )
      {
         standaloneModal( ) ;
         if ( ! ( (DateTime.MinValue==A552view_NE_AdmitDate) || ( A552view_NE_AdmitDate >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("域view_NE_Admit Date超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
         if ( ! ( ( A553view_NE_Status == 1 ) || ( A553view_NE_Status == 2 ) || ( A553view_NE_Status == 3 ) || ( A553view_NE_Status == 4 ) || ( A553view_NE_Status == 5 ) || ( A553view_NE_Status == 6 ) || (0==A553view_NE_Status) ) )
         {
            GX_msglist.addItem("域view_NE_Status超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
      }

      protected void CloseExtendedTableCursors1Q72( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey1Q72( )
      {
         /* Using cursor BC001Q5 */
         pr_default.execute(3, new Object[] {A549view_NE_EncounterID});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound72 = 1;
         }
         else
         {
            RcdFound72 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC001Q3 */
         pr_default.execute(1, new Object[] {A549view_NE_EncounterID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM1Q72( 3) ;
            RcdFound72 = 1;
            A549view_NE_EncounterID = BC001Q3_A549view_NE_EncounterID[0];
            A550view_NE_Department = BC001Q3_A550view_NE_Department[0];
            n550view_NE_Department = BC001Q3_n550view_NE_Department[0];
            A551view_NE_ENCType = BC001Q3_A551view_NE_ENCType[0];
            n551view_NE_ENCType = BC001Q3_n551view_NE_ENCType[0];
            A552view_NE_AdmitDate = BC001Q3_A552view_NE_AdmitDate[0];
            n552view_NE_AdmitDate = BC001Q3_n552view_NE_AdmitDate[0];
            A553view_NE_Status = BC001Q3_A553view_NE_Status[0];
            n553view_NE_Status = BC001Q3_n553view_NE_Status[0];
            A554view_NE_IsRandRecheck = BC001Q3_A554view_NE_IsRandRecheck[0];
            n554view_NE_IsRandRecheck = BC001Q3_n554view_NE_IsRandRecheck[0];
            A555view_NE_IsRandApprove = BC001Q3_A555view_NE_IsRandApprove[0];
            n555view_NE_IsRandApprove = BC001Q3_n555view_NE_IsRandApprove[0];
            A556view_NE_IsUpdate = BC001Q3_A556view_NE_IsUpdate[0];
            n556view_NE_IsUpdate = BC001Q3_n556view_NE_IsUpdate[0];
            A557view_NE_TenantTenantCode = BC001Q3_A557view_NE_TenantTenantCode[0];
            n557view_NE_TenantTenantCode = BC001Q3_n557view_NE_TenantTenantCode[0];
            A558view_NE_Information_ID = BC001Q3_A558view_NE_Information_ID[0];
            n558view_NE_Information_ID = BC001Q3_n558view_NE_Information_ID[0];
            A559view_NE_Information_PatientNo = BC001Q3_A559view_NE_Information_PatientNo[0];
            n559view_NE_Information_PatientNo = BC001Q3_n559view_NE_Information_PatientNo[0];
            Z549view_NE_EncounterID = A549view_NE_EncounterID;
            sMode72 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load1Q72( ) ;
            if ( AnyError == 1 )
            {
               RcdFound72 = 0;
               InitializeNonKey1Q72( ) ;
            }
            Gx_mode = sMode72;
         }
         else
         {
            RcdFound72 = 0;
            InitializeNonKey1Q72( ) ;
            sMode72 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode72;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1Q72( ) ;
         if ( RcdFound72 == 0 )
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
         CONFIRM_1Q0( ) ;
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

      protected void CheckOptimisticConcurrency1Q72( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC001Q2 */
            pr_default.execute(0, new Object[] {A549view_NE_EncounterID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"VIEW_NEW_ENCOUNTER"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z550view_NE_Department, BC001Q2_A550view_NE_Department[0]) != 0 ) || ( StringUtil.StrCmp(Z551view_NE_ENCType, BC001Q2_A551view_NE_ENCType[0]) != 0 ) || ( Z552view_NE_AdmitDate != BC001Q2_A552view_NE_AdmitDate[0] ) || ( Z553view_NE_Status != BC001Q2_A553view_NE_Status[0] ) || ( Z554view_NE_IsRandRecheck != BC001Q2_A554view_NE_IsRandRecheck[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z555view_NE_IsRandApprove != BC001Q2_A555view_NE_IsRandApprove[0] ) || ( Z556view_NE_IsUpdate != BC001Q2_A556view_NE_IsUpdate[0] ) || ( StringUtil.StrCmp(Z557view_NE_TenantTenantCode, BC001Q2_A557view_NE_TenantTenantCode[0]) != 0 ) || ( Z558view_NE_Information_ID != BC001Q2_A558view_NE_Information_ID[0] ) || ( StringUtil.StrCmp(Z559view_NE_Information_PatientNo, BC001Q2_A559view_NE_Information_PatientNo[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"VIEW_NEW_ENCOUNTER"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert1Q72( )
      {
         BeforeValidate1Q72( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1Q72( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1Q72( 0) ;
            CheckOptimisticConcurrency1Q72( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1Q72( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1Q72( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC001Q6 */
                     pr_default.execute(4, new Object[] {A549view_NE_EncounterID, n550view_NE_Department, A550view_NE_Department, n551view_NE_ENCType, A551view_NE_ENCType, n552view_NE_AdmitDate, A552view_NE_AdmitDate, n553view_NE_Status, A553view_NE_Status, n554view_NE_IsRandRecheck, A554view_NE_IsRandRecheck, n555view_NE_IsRandApprove, A555view_NE_IsRandApprove, n556view_NE_IsUpdate, A556view_NE_IsUpdate, n557view_NE_TenantTenantCode, A557view_NE_TenantTenantCode, n558view_NE_Information_ID, A558view_NE_Information_ID, n559view_NE_Information_PatientNo, A559view_NE_Information_PatientNo});
                     pr_default.close(4);
                     dsDefault.SmartCacheProvider.SetUpdated("VIEW_NEW_ENCOUNTER") ;
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
               Load1Q72( ) ;
            }
            EndLevel1Q72( ) ;
         }
         CloseExtendedTableCursors1Q72( ) ;
      }

      protected void Update1Q72( )
      {
         BeforeValidate1Q72( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1Q72( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1Q72( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1Q72( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1Q72( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC001Q7 */
                     pr_default.execute(5, new Object[] {n550view_NE_Department, A550view_NE_Department, n551view_NE_ENCType, A551view_NE_ENCType, n552view_NE_AdmitDate, A552view_NE_AdmitDate, n553view_NE_Status, A553view_NE_Status, n554view_NE_IsRandRecheck, A554view_NE_IsRandRecheck, n555view_NE_IsRandApprove, A555view_NE_IsRandApprove, n556view_NE_IsUpdate, A556view_NE_IsUpdate, n557view_NE_TenantTenantCode, A557view_NE_TenantTenantCode, n558view_NE_Information_ID, A558view_NE_Information_ID, n559view_NE_Information_PatientNo, A559view_NE_Information_PatientNo, A549view_NE_EncounterID});
                     pr_default.close(5);
                     dsDefault.SmartCacheProvider.SetUpdated("VIEW_NEW_ENCOUNTER") ;
                     if ( (pr_default.getStatus(5) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"VIEW_NEW_ENCOUNTER"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate1Q72( ) ;
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
            EndLevel1Q72( ) ;
         }
         CloseExtendedTableCursors1Q72( ) ;
      }

      protected void DeferredUpdate1Q72( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate1Q72( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1Q72( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1Q72( ) ;
            AfterConfirm1Q72( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1Q72( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC001Q8 */
                  pr_default.execute(6, new Object[] {A549view_NE_EncounterID});
                  pr_default.close(6);
                  dsDefault.SmartCacheProvider.SetUpdated("VIEW_NEW_ENCOUNTER") ;
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
         sMode72 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel1Q72( ) ;
         Gx_mode = sMode72;
      }

      protected void OnDeleteControls1Q72( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel1Q72( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1Q72( ) ;
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

      public void ScanKeyStart1Q72( )
      {
         /* Using cursor BC001Q9 */
         pr_default.execute(7, new Object[] {A549view_NE_EncounterID});
         RcdFound72 = 0;
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound72 = 1;
            A549view_NE_EncounterID = BC001Q9_A549view_NE_EncounterID[0];
            A550view_NE_Department = BC001Q9_A550view_NE_Department[0];
            n550view_NE_Department = BC001Q9_n550view_NE_Department[0];
            A551view_NE_ENCType = BC001Q9_A551view_NE_ENCType[0];
            n551view_NE_ENCType = BC001Q9_n551view_NE_ENCType[0];
            A552view_NE_AdmitDate = BC001Q9_A552view_NE_AdmitDate[0];
            n552view_NE_AdmitDate = BC001Q9_n552view_NE_AdmitDate[0];
            A553view_NE_Status = BC001Q9_A553view_NE_Status[0];
            n553view_NE_Status = BC001Q9_n553view_NE_Status[0];
            A554view_NE_IsRandRecheck = BC001Q9_A554view_NE_IsRandRecheck[0];
            n554view_NE_IsRandRecheck = BC001Q9_n554view_NE_IsRandRecheck[0];
            A555view_NE_IsRandApprove = BC001Q9_A555view_NE_IsRandApprove[0];
            n555view_NE_IsRandApprove = BC001Q9_n555view_NE_IsRandApprove[0];
            A556view_NE_IsUpdate = BC001Q9_A556view_NE_IsUpdate[0];
            n556view_NE_IsUpdate = BC001Q9_n556view_NE_IsUpdate[0];
            A557view_NE_TenantTenantCode = BC001Q9_A557view_NE_TenantTenantCode[0];
            n557view_NE_TenantTenantCode = BC001Q9_n557view_NE_TenantTenantCode[0];
            A558view_NE_Information_ID = BC001Q9_A558view_NE_Information_ID[0];
            n558view_NE_Information_ID = BC001Q9_n558view_NE_Information_ID[0];
            A559view_NE_Information_PatientNo = BC001Q9_A559view_NE_Information_PatientNo[0];
            n559view_NE_Information_PatientNo = BC001Q9_n559view_NE_Information_PatientNo[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext1Q72( )
      {
         /* Scan next routine */
         pr_default.readNext(7);
         RcdFound72 = 0;
         ScanKeyLoad1Q72( ) ;
      }

      protected void ScanKeyLoad1Q72( )
      {
         sMode72 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound72 = 1;
            A549view_NE_EncounterID = BC001Q9_A549view_NE_EncounterID[0];
            A550view_NE_Department = BC001Q9_A550view_NE_Department[0];
            n550view_NE_Department = BC001Q9_n550view_NE_Department[0];
            A551view_NE_ENCType = BC001Q9_A551view_NE_ENCType[0];
            n551view_NE_ENCType = BC001Q9_n551view_NE_ENCType[0];
            A552view_NE_AdmitDate = BC001Q9_A552view_NE_AdmitDate[0];
            n552view_NE_AdmitDate = BC001Q9_n552view_NE_AdmitDate[0];
            A553view_NE_Status = BC001Q9_A553view_NE_Status[0];
            n553view_NE_Status = BC001Q9_n553view_NE_Status[0];
            A554view_NE_IsRandRecheck = BC001Q9_A554view_NE_IsRandRecheck[0];
            n554view_NE_IsRandRecheck = BC001Q9_n554view_NE_IsRandRecheck[0];
            A555view_NE_IsRandApprove = BC001Q9_A555view_NE_IsRandApprove[0];
            n555view_NE_IsRandApprove = BC001Q9_n555view_NE_IsRandApprove[0];
            A556view_NE_IsUpdate = BC001Q9_A556view_NE_IsUpdate[0];
            n556view_NE_IsUpdate = BC001Q9_n556view_NE_IsUpdate[0];
            A557view_NE_TenantTenantCode = BC001Q9_A557view_NE_TenantTenantCode[0];
            n557view_NE_TenantTenantCode = BC001Q9_n557view_NE_TenantTenantCode[0];
            A558view_NE_Information_ID = BC001Q9_A558view_NE_Information_ID[0];
            n558view_NE_Information_ID = BC001Q9_n558view_NE_Information_ID[0];
            A559view_NE_Information_PatientNo = BC001Q9_A559view_NE_Information_PatientNo[0];
            n559view_NE_Information_PatientNo = BC001Q9_n559view_NE_Information_PatientNo[0];
         }
         Gx_mode = sMode72;
      }

      protected void ScanKeyEnd1Q72( )
      {
         pr_default.close(7);
      }

      protected void AfterConfirm1Q72( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1Q72( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1Q72( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1Q72( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1Q72( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1Q72( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1Q72( )
      {
      }

      protected void send_integrity_lvl_hashes1Q72( )
      {
      }

      protected void AddRow1Q72( )
      {
         VarsToRow72( bcView_New_Encounter) ;
      }

      protected void ReadRow1Q72( )
      {
         RowToVars72( bcView_New_Encounter, 1) ;
      }

      protected void InitializeNonKey1Q72( )
      {
         A550view_NE_Department = "";
         n550view_NE_Department = false;
         A551view_NE_ENCType = "";
         n551view_NE_ENCType = false;
         A552view_NE_AdmitDate = DateTime.MinValue;
         n552view_NE_AdmitDate = false;
         A553view_NE_Status = 0;
         n553view_NE_Status = false;
         A554view_NE_IsRandRecheck = false;
         n554view_NE_IsRandRecheck = false;
         A555view_NE_IsRandApprove = false;
         n555view_NE_IsRandApprove = false;
         A556view_NE_IsUpdate = false;
         n556view_NE_IsUpdate = false;
         A557view_NE_TenantTenantCode = "";
         n557view_NE_TenantTenantCode = false;
         A558view_NE_Information_ID = 0;
         n558view_NE_Information_ID = false;
         A559view_NE_Information_PatientNo = "";
         n559view_NE_Information_PatientNo = false;
         Z550view_NE_Department = "";
         Z551view_NE_ENCType = "";
         Z552view_NE_AdmitDate = DateTime.MinValue;
         Z553view_NE_Status = 0;
         Z554view_NE_IsRandRecheck = false;
         Z555view_NE_IsRandApprove = false;
         Z556view_NE_IsUpdate = false;
         Z557view_NE_TenantTenantCode = "";
         Z558view_NE_Information_ID = 0;
         Z559view_NE_Information_PatientNo = "";
      }

      protected void InitAll1Q72( )
      {
         A549view_NE_EncounterID = 0;
         InitializeNonKey1Q72( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow72( SdtView_New_Encounter obj72 )
      {
         obj72.gxTpr_Mode = Gx_mode;
         obj72.gxTpr_View_ne_department = A550view_NE_Department;
         obj72.gxTpr_View_ne_enctype = A551view_NE_ENCType;
         obj72.gxTpr_View_ne_admitdate = A552view_NE_AdmitDate;
         obj72.gxTpr_View_ne_status = A553view_NE_Status;
         obj72.gxTpr_View_ne_israndrecheck = A554view_NE_IsRandRecheck;
         obj72.gxTpr_View_ne_israndapprove = A555view_NE_IsRandApprove;
         obj72.gxTpr_View_ne_isupdate = A556view_NE_IsUpdate;
         obj72.gxTpr_View_ne_tenanttenantcode = A557view_NE_TenantTenantCode;
         obj72.gxTpr_View_ne_information_id = A558view_NE_Information_ID;
         obj72.gxTpr_View_ne_information_patientno = A559view_NE_Information_PatientNo;
         obj72.gxTpr_View_ne_encounterid = A549view_NE_EncounterID;
         obj72.gxTpr_View_ne_encounterid_Z = Z549view_NE_EncounterID;
         obj72.gxTpr_View_ne_department_Z = Z550view_NE_Department;
         obj72.gxTpr_View_ne_enctype_Z = Z551view_NE_ENCType;
         obj72.gxTpr_View_ne_admitdate_Z = Z552view_NE_AdmitDate;
         obj72.gxTpr_View_ne_status_Z = Z553view_NE_Status;
         obj72.gxTpr_View_ne_israndrecheck_Z = Z554view_NE_IsRandRecheck;
         obj72.gxTpr_View_ne_israndapprove_Z = Z555view_NE_IsRandApprove;
         obj72.gxTpr_View_ne_isupdate_Z = Z556view_NE_IsUpdate;
         obj72.gxTpr_View_ne_tenanttenantcode_Z = Z557view_NE_TenantTenantCode;
         obj72.gxTpr_View_ne_information_id_Z = Z558view_NE_Information_ID;
         obj72.gxTpr_View_ne_information_patientno_Z = Z559view_NE_Information_PatientNo;
         obj72.gxTpr_View_ne_department_N = (short)(Convert.ToInt16(n550view_NE_Department));
         obj72.gxTpr_View_ne_enctype_N = (short)(Convert.ToInt16(n551view_NE_ENCType));
         obj72.gxTpr_View_ne_admitdate_N = (short)(Convert.ToInt16(n552view_NE_AdmitDate));
         obj72.gxTpr_View_ne_status_N = (short)(Convert.ToInt16(n553view_NE_Status));
         obj72.gxTpr_View_ne_israndrecheck_N = (short)(Convert.ToInt16(n554view_NE_IsRandRecheck));
         obj72.gxTpr_View_ne_israndapprove_N = (short)(Convert.ToInt16(n555view_NE_IsRandApprove));
         obj72.gxTpr_View_ne_isupdate_N = (short)(Convert.ToInt16(n556view_NE_IsUpdate));
         obj72.gxTpr_View_ne_tenanttenantcode_N = (short)(Convert.ToInt16(n557view_NE_TenantTenantCode));
         obj72.gxTpr_View_ne_information_id_N = (short)(Convert.ToInt16(n558view_NE_Information_ID));
         obj72.gxTpr_View_ne_information_patientno_N = (short)(Convert.ToInt16(n559view_NE_Information_PatientNo));
         obj72.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow72( SdtView_New_Encounter obj72 )
      {
         obj72.gxTpr_View_ne_encounterid = A549view_NE_EncounterID;
         return  ;
      }

      public void RowToVars72( SdtView_New_Encounter obj72 ,
                               int forceLoad )
      {
         Gx_mode = obj72.gxTpr_Mode;
         A550view_NE_Department = obj72.gxTpr_View_ne_department;
         n550view_NE_Department = false;
         A551view_NE_ENCType = obj72.gxTpr_View_ne_enctype;
         n551view_NE_ENCType = false;
         A552view_NE_AdmitDate = obj72.gxTpr_View_ne_admitdate;
         n552view_NE_AdmitDate = false;
         A553view_NE_Status = obj72.gxTpr_View_ne_status;
         n553view_NE_Status = false;
         A554view_NE_IsRandRecheck = obj72.gxTpr_View_ne_israndrecheck;
         n554view_NE_IsRandRecheck = false;
         A555view_NE_IsRandApprove = obj72.gxTpr_View_ne_israndapprove;
         n555view_NE_IsRandApprove = false;
         A556view_NE_IsUpdate = obj72.gxTpr_View_ne_isupdate;
         n556view_NE_IsUpdate = false;
         A557view_NE_TenantTenantCode = obj72.gxTpr_View_ne_tenanttenantcode;
         n557view_NE_TenantTenantCode = false;
         A558view_NE_Information_ID = obj72.gxTpr_View_ne_information_id;
         n558view_NE_Information_ID = false;
         A559view_NE_Information_PatientNo = obj72.gxTpr_View_ne_information_patientno;
         n559view_NE_Information_PatientNo = false;
         A549view_NE_EncounterID = obj72.gxTpr_View_ne_encounterid;
         Z549view_NE_EncounterID = obj72.gxTpr_View_ne_encounterid_Z;
         Z550view_NE_Department = obj72.gxTpr_View_ne_department_Z;
         Z551view_NE_ENCType = obj72.gxTpr_View_ne_enctype_Z;
         Z552view_NE_AdmitDate = obj72.gxTpr_View_ne_admitdate_Z;
         Z553view_NE_Status = obj72.gxTpr_View_ne_status_Z;
         Z554view_NE_IsRandRecheck = obj72.gxTpr_View_ne_israndrecheck_Z;
         Z555view_NE_IsRandApprove = obj72.gxTpr_View_ne_israndapprove_Z;
         Z556view_NE_IsUpdate = obj72.gxTpr_View_ne_isupdate_Z;
         Z557view_NE_TenantTenantCode = obj72.gxTpr_View_ne_tenanttenantcode_Z;
         Z558view_NE_Information_ID = obj72.gxTpr_View_ne_information_id_Z;
         Z559view_NE_Information_PatientNo = obj72.gxTpr_View_ne_information_patientno_Z;
         n550view_NE_Department = (bool)(Convert.ToBoolean(obj72.gxTpr_View_ne_department_N));
         n551view_NE_ENCType = (bool)(Convert.ToBoolean(obj72.gxTpr_View_ne_enctype_N));
         n552view_NE_AdmitDate = (bool)(Convert.ToBoolean(obj72.gxTpr_View_ne_admitdate_N));
         n553view_NE_Status = (bool)(Convert.ToBoolean(obj72.gxTpr_View_ne_status_N));
         n554view_NE_IsRandRecheck = (bool)(Convert.ToBoolean(obj72.gxTpr_View_ne_israndrecheck_N));
         n555view_NE_IsRandApprove = (bool)(Convert.ToBoolean(obj72.gxTpr_View_ne_israndapprove_N));
         n556view_NE_IsUpdate = (bool)(Convert.ToBoolean(obj72.gxTpr_View_ne_isupdate_N));
         n557view_NE_TenantTenantCode = (bool)(Convert.ToBoolean(obj72.gxTpr_View_ne_tenanttenantcode_N));
         n558view_NE_Information_ID = (bool)(Convert.ToBoolean(obj72.gxTpr_View_ne_information_id_N));
         n559view_NE_Information_PatientNo = (bool)(Convert.ToBoolean(obj72.gxTpr_View_ne_information_patientno_N));
         Gx_mode = obj72.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A549view_NE_EncounterID = (long)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey1Q72( ) ;
         ScanKeyStart1Q72( ) ;
         if ( RcdFound72 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z549view_NE_EncounterID = A549view_NE_EncounterID;
         }
         ZM1Q72( -3) ;
         OnLoadActions1Q72( ) ;
         AddRow1Q72( ) ;
         ScanKeyEnd1Q72( ) ;
         if ( RcdFound72 == 0 )
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
         RowToVars72( bcView_New_Encounter, 0) ;
         ScanKeyStart1Q72( ) ;
         if ( RcdFound72 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z549view_NE_EncounterID = A549view_NE_EncounterID;
         }
         ZM1Q72( -3) ;
         OnLoadActions1Q72( ) ;
         AddRow1Q72( ) ;
         ScanKeyEnd1Q72( ) ;
         if ( RcdFound72 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey1Q72( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert1Q72( ) ;
         }
         else
         {
            if ( RcdFound72 == 1 )
            {
               if ( A549view_NE_EncounterID != Z549view_NE_EncounterID )
               {
                  A549view_NE_EncounterID = Z549view_NE_EncounterID;
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
                  Update1Q72( ) ;
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
                  if ( A549view_NE_EncounterID != Z549view_NE_EncounterID )
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
                        Insert1Q72( ) ;
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
                        Insert1Q72( ) ;
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
         RowToVars72( bcView_New_Encounter, 0) ;
         SaveImpl( ) ;
         VarsToRow72( bcView_New_Encounter) ;
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
         RowToVars72( bcView_New_Encounter, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert1Q72( ) ;
         AfterTrn( ) ;
         VarsToRow72( bcView_New_Encounter) ;
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
            SdtView_New_Encounter auxBC = new SdtView_New_Encounter(context) ;
            auxBC.Load(A549view_NE_EncounterID);
            auxBC.UpdateDirties(bcView_New_Encounter);
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
         RowToVars72( bcView_New_Encounter, 0) ;
         UpdateImpl( ) ;
         VarsToRow72( bcView_New_Encounter) ;
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
         RowToVars72( bcView_New_Encounter, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert1Q72( ) ;
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
         VarsToRow72( bcView_New_Encounter) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars72( bcView_New_Encounter, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey1Q72( ) ;
         if ( RcdFound72 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A549view_NE_EncounterID != Z549view_NE_EncounterID )
            {
               A549view_NE_EncounterID = Z549view_NE_EncounterID;
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
            if ( A549view_NE_EncounterID != Z549view_NE_EncounterID )
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
         context.RollbackDataStores("view_new_encounter_bc",pr_default);
         VarsToRow72( bcView_New_Encounter) ;
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
         Gx_mode = bcView_New_Encounter.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcView_New_Encounter.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcView_New_Encounter )
         {
            bcView_New_Encounter = (SdtView_New_Encounter)(sdt);
            if ( StringUtil.StrCmp(bcView_New_Encounter.gxTpr_Mode, "") == 0 )
            {
               bcView_New_Encounter.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow72( bcView_New_Encounter) ;
            }
            else
            {
               RowToVars72( bcView_New_Encounter, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcView_New_Encounter.gxTpr_Mode, "") == 0 )
            {
               bcView_New_Encounter.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars72( bcView_New_Encounter, 1) ;
         return  ;
      }

      public SdtView_New_Encounter View_New_Encounter_BC
      {
         get {
            return bcView_New_Encounter ;
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
         Z550view_NE_Department = "";
         A550view_NE_Department = "";
         Z551view_NE_ENCType = "";
         A551view_NE_ENCType = "";
         Z552view_NE_AdmitDate = DateTime.MinValue;
         A552view_NE_AdmitDate = DateTime.MinValue;
         Z557view_NE_TenantTenantCode = "";
         A557view_NE_TenantTenantCode = "";
         Z559view_NE_Information_PatientNo = "";
         A559view_NE_Information_PatientNo = "";
         BC001Q4_A549view_NE_EncounterID = new long[1] ;
         BC001Q4_A550view_NE_Department = new String[] {""} ;
         BC001Q4_n550view_NE_Department = new bool[] {false} ;
         BC001Q4_A551view_NE_ENCType = new String[] {""} ;
         BC001Q4_n551view_NE_ENCType = new bool[] {false} ;
         BC001Q4_A552view_NE_AdmitDate = new DateTime[] {DateTime.MinValue} ;
         BC001Q4_n552view_NE_AdmitDate = new bool[] {false} ;
         BC001Q4_A553view_NE_Status = new short[1] ;
         BC001Q4_n553view_NE_Status = new bool[] {false} ;
         BC001Q4_A554view_NE_IsRandRecheck = new bool[] {false} ;
         BC001Q4_n554view_NE_IsRandRecheck = new bool[] {false} ;
         BC001Q4_A555view_NE_IsRandApprove = new bool[] {false} ;
         BC001Q4_n555view_NE_IsRandApprove = new bool[] {false} ;
         BC001Q4_A556view_NE_IsUpdate = new bool[] {false} ;
         BC001Q4_n556view_NE_IsUpdate = new bool[] {false} ;
         BC001Q4_A557view_NE_TenantTenantCode = new String[] {""} ;
         BC001Q4_n557view_NE_TenantTenantCode = new bool[] {false} ;
         BC001Q4_A558view_NE_Information_ID = new long[1] ;
         BC001Q4_n558view_NE_Information_ID = new bool[] {false} ;
         BC001Q4_A559view_NE_Information_PatientNo = new String[] {""} ;
         BC001Q4_n559view_NE_Information_PatientNo = new bool[] {false} ;
         BC001Q5_A549view_NE_EncounterID = new long[1] ;
         BC001Q3_A549view_NE_EncounterID = new long[1] ;
         BC001Q3_A550view_NE_Department = new String[] {""} ;
         BC001Q3_n550view_NE_Department = new bool[] {false} ;
         BC001Q3_A551view_NE_ENCType = new String[] {""} ;
         BC001Q3_n551view_NE_ENCType = new bool[] {false} ;
         BC001Q3_A552view_NE_AdmitDate = new DateTime[] {DateTime.MinValue} ;
         BC001Q3_n552view_NE_AdmitDate = new bool[] {false} ;
         BC001Q3_A553view_NE_Status = new short[1] ;
         BC001Q3_n553view_NE_Status = new bool[] {false} ;
         BC001Q3_A554view_NE_IsRandRecheck = new bool[] {false} ;
         BC001Q3_n554view_NE_IsRandRecheck = new bool[] {false} ;
         BC001Q3_A555view_NE_IsRandApprove = new bool[] {false} ;
         BC001Q3_n555view_NE_IsRandApprove = new bool[] {false} ;
         BC001Q3_A556view_NE_IsUpdate = new bool[] {false} ;
         BC001Q3_n556view_NE_IsUpdate = new bool[] {false} ;
         BC001Q3_A557view_NE_TenantTenantCode = new String[] {""} ;
         BC001Q3_n557view_NE_TenantTenantCode = new bool[] {false} ;
         BC001Q3_A558view_NE_Information_ID = new long[1] ;
         BC001Q3_n558view_NE_Information_ID = new bool[] {false} ;
         BC001Q3_A559view_NE_Information_PatientNo = new String[] {""} ;
         BC001Q3_n559view_NE_Information_PatientNo = new bool[] {false} ;
         sMode72 = "";
         BC001Q2_A549view_NE_EncounterID = new long[1] ;
         BC001Q2_A550view_NE_Department = new String[] {""} ;
         BC001Q2_n550view_NE_Department = new bool[] {false} ;
         BC001Q2_A551view_NE_ENCType = new String[] {""} ;
         BC001Q2_n551view_NE_ENCType = new bool[] {false} ;
         BC001Q2_A552view_NE_AdmitDate = new DateTime[] {DateTime.MinValue} ;
         BC001Q2_n552view_NE_AdmitDate = new bool[] {false} ;
         BC001Q2_A553view_NE_Status = new short[1] ;
         BC001Q2_n553view_NE_Status = new bool[] {false} ;
         BC001Q2_A554view_NE_IsRandRecheck = new bool[] {false} ;
         BC001Q2_n554view_NE_IsRandRecheck = new bool[] {false} ;
         BC001Q2_A555view_NE_IsRandApprove = new bool[] {false} ;
         BC001Q2_n555view_NE_IsRandApprove = new bool[] {false} ;
         BC001Q2_A556view_NE_IsUpdate = new bool[] {false} ;
         BC001Q2_n556view_NE_IsUpdate = new bool[] {false} ;
         BC001Q2_A557view_NE_TenantTenantCode = new String[] {""} ;
         BC001Q2_n557view_NE_TenantTenantCode = new bool[] {false} ;
         BC001Q2_A558view_NE_Information_ID = new long[1] ;
         BC001Q2_n558view_NE_Information_ID = new bool[] {false} ;
         BC001Q2_A559view_NE_Information_PatientNo = new String[] {""} ;
         BC001Q2_n559view_NE_Information_PatientNo = new bool[] {false} ;
         BC001Q9_A549view_NE_EncounterID = new long[1] ;
         BC001Q9_A550view_NE_Department = new String[] {""} ;
         BC001Q9_n550view_NE_Department = new bool[] {false} ;
         BC001Q9_A551view_NE_ENCType = new String[] {""} ;
         BC001Q9_n551view_NE_ENCType = new bool[] {false} ;
         BC001Q9_A552view_NE_AdmitDate = new DateTime[] {DateTime.MinValue} ;
         BC001Q9_n552view_NE_AdmitDate = new bool[] {false} ;
         BC001Q9_A553view_NE_Status = new short[1] ;
         BC001Q9_n553view_NE_Status = new bool[] {false} ;
         BC001Q9_A554view_NE_IsRandRecheck = new bool[] {false} ;
         BC001Q9_n554view_NE_IsRandRecheck = new bool[] {false} ;
         BC001Q9_A555view_NE_IsRandApprove = new bool[] {false} ;
         BC001Q9_n555view_NE_IsRandApprove = new bool[] {false} ;
         BC001Q9_A556view_NE_IsUpdate = new bool[] {false} ;
         BC001Q9_n556view_NE_IsUpdate = new bool[] {false} ;
         BC001Q9_A557view_NE_TenantTenantCode = new String[] {""} ;
         BC001Q9_n557view_NE_TenantTenantCode = new bool[] {false} ;
         BC001Q9_A558view_NE_Information_ID = new long[1] ;
         BC001Q9_n558view_NE_Information_ID = new bool[] {false} ;
         BC001Q9_A559view_NE_Information_PatientNo = new String[] {""} ;
         BC001Q9_n559view_NE_Information_PatientNo = new bool[] {false} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.view_new_encounter_bc__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.view_new_encounter_bc__default(),
            new Object[][] {
                new Object[] {
               BC001Q2_A549view_NE_EncounterID, BC001Q2_A550view_NE_Department, BC001Q2_n550view_NE_Department, BC001Q2_A551view_NE_ENCType, BC001Q2_n551view_NE_ENCType, BC001Q2_A552view_NE_AdmitDate, BC001Q2_n552view_NE_AdmitDate, BC001Q2_A553view_NE_Status, BC001Q2_n553view_NE_Status, BC001Q2_A554view_NE_IsRandRecheck,
               BC001Q2_n554view_NE_IsRandRecheck, BC001Q2_A555view_NE_IsRandApprove, BC001Q2_n555view_NE_IsRandApprove, BC001Q2_A556view_NE_IsUpdate, BC001Q2_n556view_NE_IsUpdate, BC001Q2_A557view_NE_TenantTenantCode, BC001Q2_n557view_NE_TenantTenantCode, BC001Q2_A558view_NE_Information_ID, BC001Q2_n558view_NE_Information_ID, BC001Q2_A559view_NE_Information_PatientNo,
               BC001Q2_n559view_NE_Information_PatientNo
               }
               , new Object[] {
               BC001Q3_A549view_NE_EncounterID, BC001Q3_A550view_NE_Department, BC001Q3_n550view_NE_Department, BC001Q3_A551view_NE_ENCType, BC001Q3_n551view_NE_ENCType, BC001Q3_A552view_NE_AdmitDate, BC001Q3_n552view_NE_AdmitDate, BC001Q3_A553view_NE_Status, BC001Q3_n553view_NE_Status, BC001Q3_A554view_NE_IsRandRecheck,
               BC001Q3_n554view_NE_IsRandRecheck, BC001Q3_A555view_NE_IsRandApprove, BC001Q3_n555view_NE_IsRandApprove, BC001Q3_A556view_NE_IsUpdate, BC001Q3_n556view_NE_IsUpdate, BC001Q3_A557view_NE_TenantTenantCode, BC001Q3_n557view_NE_TenantTenantCode, BC001Q3_A558view_NE_Information_ID, BC001Q3_n558view_NE_Information_ID, BC001Q3_A559view_NE_Information_PatientNo,
               BC001Q3_n559view_NE_Information_PatientNo
               }
               , new Object[] {
               BC001Q4_A549view_NE_EncounterID, BC001Q4_A550view_NE_Department, BC001Q4_n550view_NE_Department, BC001Q4_A551view_NE_ENCType, BC001Q4_n551view_NE_ENCType, BC001Q4_A552view_NE_AdmitDate, BC001Q4_n552view_NE_AdmitDate, BC001Q4_A553view_NE_Status, BC001Q4_n553view_NE_Status, BC001Q4_A554view_NE_IsRandRecheck,
               BC001Q4_n554view_NE_IsRandRecheck, BC001Q4_A555view_NE_IsRandApprove, BC001Q4_n555view_NE_IsRandApprove, BC001Q4_A556view_NE_IsUpdate, BC001Q4_n556view_NE_IsUpdate, BC001Q4_A557view_NE_TenantTenantCode, BC001Q4_n557view_NE_TenantTenantCode, BC001Q4_A558view_NE_Information_ID, BC001Q4_n558view_NE_Information_ID, BC001Q4_A559view_NE_Information_PatientNo,
               BC001Q4_n559view_NE_Information_PatientNo
               }
               , new Object[] {
               BC001Q5_A549view_NE_EncounterID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC001Q9_A549view_NE_EncounterID, BC001Q9_A550view_NE_Department, BC001Q9_n550view_NE_Department, BC001Q9_A551view_NE_ENCType, BC001Q9_n551view_NE_ENCType, BC001Q9_A552view_NE_AdmitDate, BC001Q9_n552view_NE_AdmitDate, BC001Q9_A553view_NE_Status, BC001Q9_n553view_NE_Status, BC001Q9_A554view_NE_IsRandRecheck,
               BC001Q9_n554view_NE_IsRandRecheck, BC001Q9_A555view_NE_IsRandApprove, BC001Q9_n555view_NE_IsRandApprove, BC001Q9_A556view_NE_IsUpdate, BC001Q9_n556view_NE_IsUpdate, BC001Q9_A557view_NE_TenantTenantCode, BC001Q9_n557view_NE_TenantTenantCode, BC001Q9_A558view_NE_Information_ID, BC001Q9_n558view_NE_Information_ID, BC001Q9_A559view_NE_Information_PatientNo,
               BC001Q9_n559view_NE_Information_PatientNo
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
      private short Z553view_NE_Status ;
      private short A553view_NE_Status ;
      private short RcdFound72 ;
      private int trnEnded ;
      private long Z549view_NE_EncounterID ;
      private long A549view_NE_EncounterID ;
      private long Z558view_NE_Information_ID ;
      private long A558view_NE_Information_ID ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String sMode72 ;
      private DateTime Z552view_NE_AdmitDate ;
      private DateTime A552view_NE_AdmitDate ;
      private bool Z554view_NE_IsRandRecheck ;
      private bool A554view_NE_IsRandRecheck ;
      private bool Z555view_NE_IsRandApprove ;
      private bool A555view_NE_IsRandApprove ;
      private bool Z556view_NE_IsUpdate ;
      private bool A556view_NE_IsUpdate ;
      private bool n550view_NE_Department ;
      private bool n551view_NE_ENCType ;
      private bool n552view_NE_AdmitDate ;
      private bool n553view_NE_Status ;
      private bool n554view_NE_IsRandRecheck ;
      private bool n555view_NE_IsRandApprove ;
      private bool n556view_NE_IsUpdate ;
      private bool n557view_NE_TenantTenantCode ;
      private bool n558view_NE_Information_ID ;
      private bool n559view_NE_Information_PatientNo ;
      private bool Gx_longc ;
      private String Z550view_NE_Department ;
      private String A550view_NE_Department ;
      private String Z551view_NE_ENCType ;
      private String A551view_NE_ENCType ;
      private String Z557view_NE_TenantTenantCode ;
      private String A557view_NE_TenantTenantCode ;
      private String Z559view_NE_Information_PatientNo ;
      private String A559view_NE_Information_PatientNo ;
      private SdtView_New_Encounter bcView_New_Encounter ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] BC001Q4_A549view_NE_EncounterID ;
      private String[] BC001Q4_A550view_NE_Department ;
      private bool[] BC001Q4_n550view_NE_Department ;
      private String[] BC001Q4_A551view_NE_ENCType ;
      private bool[] BC001Q4_n551view_NE_ENCType ;
      private DateTime[] BC001Q4_A552view_NE_AdmitDate ;
      private bool[] BC001Q4_n552view_NE_AdmitDate ;
      private short[] BC001Q4_A553view_NE_Status ;
      private bool[] BC001Q4_n553view_NE_Status ;
      private bool[] BC001Q4_A554view_NE_IsRandRecheck ;
      private bool[] BC001Q4_n554view_NE_IsRandRecheck ;
      private bool[] BC001Q4_A555view_NE_IsRandApprove ;
      private bool[] BC001Q4_n555view_NE_IsRandApprove ;
      private bool[] BC001Q4_A556view_NE_IsUpdate ;
      private bool[] BC001Q4_n556view_NE_IsUpdate ;
      private String[] BC001Q4_A557view_NE_TenantTenantCode ;
      private bool[] BC001Q4_n557view_NE_TenantTenantCode ;
      private long[] BC001Q4_A558view_NE_Information_ID ;
      private bool[] BC001Q4_n558view_NE_Information_ID ;
      private String[] BC001Q4_A559view_NE_Information_PatientNo ;
      private bool[] BC001Q4_n559view_NE_Information_PatientNo ;
      private long[] BC001Q5_A549view_NE_EncounterID ;
      private long[] BC001Q3_A549view_NE_EncounterID ;
      private String[] BC001Q3_A550view_NE_Department ;
      private bool[] BC001Q3_n550view_NE_Department ;
      private String[] BC001Q3_A551view_NE_ENCType ;
      private bool[] BC001Q3_n551view_NE_ENCType ;
      private DateTime[] BC001Q3_A552view_NE_AdmitDate ;
      private bool[] BC001Q3_n552view_NE_AdmitDate ;
      private short[] BC001Q3_A553view_NE_Status ;
      private bool[] BC001Q3_n553view_NE_Status ;
      private bool[] BC001Q3_A554view_NE_IsRandRecheck ;
      private bool[] BC001Q3_n554view_NE_IsRandRecheck ;
      private bool[] BC001Q3_A555view_NE_IsRandApprove ;
      private bool[] BC001Q3_n555view_NE_IsRandApprove ;
      private bool[] BC001Q3_A556view_NE_IsUpdate ;
      private bool[] BC001Q3_n556view_NE_IsUpdate ;
      private String[] BC001Q3_A557view_NE_TenantTenantCode ;
      private bool[] BC001Q3_n557view_NE_TenantTenantCode ;
      private long[] BC001Q3_A558view_NE_Information_ID ;
      private bool[] BC001Q3_n558view_NE_Information_ID ;
      private String[] BC001Q3_A559view_NE_Information_PatientNo ;
      private bool[] BC001Q3_n559view_NE_Information_PatientNo ;
      private long[] BC001Q2_A549view_NE_EncounterID ;
      private String[] BC001Q2_A550view_NE_Department ;
      private bool[] BC001Q2_n550view_NE_Department ;
      private String[] BC001Q2_A551view_NE_ENCType ;
      private bool[] BC001Q2_n551view_NE_ENCType ;
      private DateTime[] BC001Q2_A552view_NE_AdmitDate ;
      private bool[] BC001Q2_n552view_NE_AdmitDate ;
      private short[] BC001Q2_A553view_NE_Status ;
      private bool[] BC001Q2_n553view_NE_Status ;
      private bool[] BC001Q2_A554view_NE_IsRandRecheck ;
      private bool[] BC001Q2_n554view_NE_IsRandRecheck ;
      private bool[] BC001Q2_A555view_NE_IsRandApprove ;
      private bool[] BC001Q2_n555view_NE_IsRandApprove ;
      private bool[] BC001Q2_A556view_NE_IsUpdate ;
      private bool[] BC001Q2_n556view_NE_IsUpdate ;
      private String[] BC001Q2_A557view_NE_TenantTenantCode ;
      private bool[] BC001Q2_n557view_NE_TenantTenantCode ;
      private long[] BC001Q2_A558view_NE_Information_ID ;
      private bool[] BC001Q2_n558view_NE_Information_ID ;
      private String[] BC001Q2_A559view_NE_Information_PatientNo ;
      private bool[] BC001Q2_n559view_NE_Information_PatientNo ;
      private long[] BC001Q9_A549view_NE_EncounterID ;
      private String[] BC001Q9_A550view_NE_Department ;
      private bool[] BC001Q9_n550view_NE_Department ;
      private String[] BC001Q9_A551view_NE_ENCType ;
      private bool[] BC001Q9_n551view_NE_ENCType ;
      private DateTime[] BC001Q9_A552view_NE_AdmitDate ;
      private bool[] BC001Q9_n552view_NE_AdmitDate ;
      private short[] BC001Q9_A553view_NE_Status ;
      private bool[] BC001Q9_n553view_NE_Status ;
      private bool[] BC001Q9_A554view_NE_IsRandRecheck ;
      private bool[] BC001Q9_n554view_NE_IsRandRecheck ;
      private bool[] BC001Q9_A555view_NE_IsRandApprove ;
      private bool[] BC001Q9_n555view_NE_IsRandApprove ;
      private bool[] BC001Q9_A556view_NE_IsUpdate ;
      private bool[] BC001Q9_n556view_NE_IsUpdate ;
      private String[] BC001Q9_A557view_NE_TenantTenantCode ;
      private bool[] BC001Q9_n557view_NE_TenantTenantCode ;
      private long[] BC001Q9_A558view_NE_Information_ID ;
      private bool[] BC001Q9_n558view_NE_Information_ID ;
      private String[] BC001Q9_A559view_NE_Information_PatientNo ;
      private bool[] BC001Q9_n559view_NE_Information_PatientNo ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_datastore1 ;
   }

   public class view_new_encounter_bc__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class view_new_encounter_bc__default : DataStoreHelperBase, IDataStoreHelper
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
        Object[] prmBC001Q4 ;
        prmBC001Q4 = new Object[] {
        new Object[] {"@view_NE_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC001Q5 ;
        prmBC001Q5 = new Object[] {
        new Object[] {"@view_NE_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC001Q3 ;
        prmBC001Q3 = new Object[] {
        new Object[] {"@view_NE_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC001Q2 ;
        prmBC001Q2 = new Object[] {
        new Object[] {"@view_NE_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC001Q6 ;
        prmBC001Q6 = new Object[] {
        new Object[] {"@view_NE_EncounterID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@view_NE_Department",SqlDbType.NVarChar,4000,0} ,
        new Object[] {"@view_NE_ENCType",SqlDbType.NVarChar,4000,0} ,
        new Object[] {"@view_NE_AdmitDate",SqlDbType.DateTime,8,0} ,
        new Object[] {"@view_NE_Status",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@view_NE_IsRandRecheck",SqlDbType.Bit,1,0} ,
        new Object[] {"@view_NE_IsRandApprove",SqlDbType.Bit,1,0} ,
        new Object[] {"@view_NE_IsUpdate",SqlDbType.Bit,1,0} ,
        new Object[] {"@view_NE_TenantTenantCode",SqlDbType.NVarChar,20,0} ,
        new Object[] {"@view_NE_Information_ID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@view_NE_Information_PatientNo",SqlDbType.NVarChar,4000,0}
        } ;
        Object[] prmBC001Q7 ;
        prmBC001Q7 = new Object[] {
        new Object[] {"@view_NE_Department",SqlDbType.NVarChar,4000,0} ,
        new Object[] {"@view_NE_ENCType",SqlDbType.NVarChar,4000,0} ,
        new Object[] {"@view_NE_AdmitDate",SqlDbType.DateTime,8,0} ,
        new Object[] {"@view_NE_Status",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@view_NE_IsRandRecheck",SqlDbType.Bit,1,0} ,
        new Object[] {"@view_NE_IsRandApprove",SqlDbType.Bit,1,0} ,
        new Object[] {"@view_NE_IsUpdate",SqlDbType.Bit,1,0} ,
        new Object[] {"@view_NE_TenantTenantCode",SqlDbType.NVarChar,20,0} ,
        new Object[] {"@view_NE_Information_ID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@view_NE_Information_PatientNo",SqlDbType.NVarChar,4000,0} ,
        new Object[] {"@view_NE_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC001Q8 ;
        prmBC001Q8 = new Object[] {
        new Object[] {"@view_NE_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC001Q9 ;
        prmBC001Q9 = new Object[] {
        new Object[] {"@view_NE_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("BC001Q2", "SELECT [view_NE_EncounterID], [view_NE_Department], [view_NE_ENCType], [view_NE_AdmitDate], [view_NE_Status], [view_NE_IsRandRecheck], [view_NE_IsRandApprove], [view_NE_IsUpdate], [view_NE_TenantTenantCode], [view_NE_Information_ID], [view_NE_Information_PatientNo] FROM dbo.[View_New_Encounter] WITH (UPDLOCK) WHERE [view_NE_EncounterID] = @view_NE_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001Q2,1,0,true,false )
           ,new CursorDef("BC001Q3", "SELECT [view_NE_EncounterID], [view_NE_Department], [view_NE_ENCType], [view_NE_AdmitDate], [view_NE_Status], [view_NE_IsRandRecheck], [view_NE_IsRandApprove], [view_NE_IsUpdate], [view_NE_TenantTenantCode], [view_NE_Information_ID], [view_NE_Information_PatientNo] FROM dbo.[View_New_Encounter] WITH (NOLOCK) WHERE [view_NE_EncounterID] = @view_NE_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001Q3,1,0,true,false )
           ,new CursorDef("BC001Q4", "SELECT TM1.[view_NE_EncounterID], TM1.[view_NE_Department], TM1.[view_NE_ENCType], TM1.[view_NE_AdmitDate], TM1.[view_NE_Status], TM1.[view_NE_IsRandRecheck], TM1.[view_NE_IsRandApprove], TM1.[view_NE_IsUpdate], TM1.[view_NE_TenantTenantCode], TM1.[view_NE_Information_ID], TM1.[view_NE_Information_PatientNo] FROM dbo.[View_New_Encounter] TM1 WITH (NOLOCK) WHERE TM1.[view_NE_EncounterID] = @view_NE_EncounterID ORDER BY TM1.[view_NE_EncounterID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001Q4,100,0,true,false )
           ,new CursorDef("BC001Q5", "SELECT [view_NE_EncounterID] FROM dbo.[View_New_Encounter] WITH (NOLOCK) WHERE [view_NE_EncounterID] = @view_NE_EncounterID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001Q5,1,0,true,false )
           ,new CursorDef("BC001Q6", "INSERT INTO dbo.[View_New_Encounter]([view_NE_EncounterID], [view_NE_Department], [view_NE_ENCType], [view_NE_AdmitDate], [view_NE_Status], [view_NE_IsRandRecheck], [view_NE_IsRandApprove], [view_NE_IsUpdate], [view_NE_TenantTenantCode], [view_NE_Information_ID], [view_NE_Information_PatientNo]) VALUES(@view_NE_EncounterID, @view_NE_Department, @view_NE_ENCType, @view_NE_AdmitDate, @view_NE_Status, @view_NE_IsRandRecheck, @view_NE_IsRandApprove, @view_NE_IsUpdate, @view_NE_TenantTenantCode, @view_NE_Information_ID, @view_NE_Information_PatientNo)", GxErrorMask.GX_NOMASK,prmBC001Q6)
           ,new CursorDef("BC001Q7", "UPDATE dbo.[View_New_Encounter] SET [view_NE_Department]=@view_NE_Department, [view_NE_ENCType]=@view_NE_ENCType, [view_NE_AdmitDate]=@view_NE_AdmitDate, [view_NE_Status]=@view_NE_Status, [view_NE_IsRandRecheck]=@view_NE_IsRandRecheck, [view_NE_IsRandApprove]=@view_NE_IsRandApprove, [view_NE_IsUpdate]=@view_NE_IsUpdate, [view_NE_TenantTenantCode]=@view_NE_TenantTenantCode, [view_NE_Information_ID]=@view_NE_Information_ID, [view_NE_Information_PatientNo]=@view_NE_Information_PatientNo  WHERE [view_NE_EncounterID] = @view_NE_EncounterID", GxErrorMask.GX_NOMASK,prmBC001Q7)
           ,new CursorDef("BC001Q8", "DELETE FROM dbo.[View_New_Encounter]  WHERE [view_NE_EncounterID] = @view_NE_EncounterID", GxErrorMask.GX_NOMASK,prmBC001Q8)
           ,new CursorDef("BC001Q9", "SELECT TM1.[view_NE_EncounterID], TM1.[view_NE_Department], TM1.[view_NE_ENCType], TM1.[view_NE_AdmitDate], TM1.[view_NE_Status], TM1.[view_NE_IsRandRecheck], TM1.[view_NE_IsRandApprove], TM1.[view_NE_IsUpdate], TM1.[view_NE_TenantTenantCode], TM1.[view_NE_Information_ID], TM1.[view_NE_Information_PatientNo] FROM dbo.[View_New_Encounter] TM1 WITH (NOLOCK) WHERE TM1.[view_NE_EncounterID] = @view_NE_EncounterID ORDER BY TM1.[view_NE_EncounterID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001Q9,100,0,true,false )
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
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((DateTime[]) buf[5])[0] = rslt.getGXDate(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((short[]) buf[7])[0] = rslt.getShort(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((bool[]) buf[9])[0] = rslt.getBool(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((bool[]) buf[11])[0] = rslt.getBool(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((bool[]) buf[13])[0] = rslt.getBool(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((long[]) buf[17])[0] = rslt.getLong(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              ((String[]) buf[19])[0] = rslt.getVarchar(11) ;
              ((bool[]) buf[20])[0] = rslt.wasNull(11);
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((DateTime[]) buf[5])[0] = rslt.getGXDate(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((short[]) buf[7])[0] = rslt.getShort(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((bool[]) buf[9])[0] = rslt.getBool(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((bool[]) buf[11])[0] = rslt.getBool(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((bool[]) buf[13])[0] = rslt.getBool(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((long[]) buf[17])[0] = rslt.getLong(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              ((String[]) buf[19])[0] = rslt.getVarchar(11) ;
              ((bool[]) buf[20])[0] = rslt.wasNull(11);
              return;
           case 2 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((DateTime[]) buf[5])[0] = rslt.getGXDate(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((short[]) buf[7])[0] = rslt.getShort(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((bool[]) buf[9])[0] = rslt.getBool(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((bool[]) buf[11])[0] = rslt.getBool(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((bool[]) buf[13])[0] = rslt.getBool(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((long[]) buf[17])[0] = rslt.getLong(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              ((String[]) buf[19])[0] = rslt.getVarchar(11) ;
              ((bool[]) buf[20])[0] = rslt.wasNull(11);
              return;
           case 3 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 7 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((DateTime[]) buf[5])[0] = rslt.getGXDate(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((short[]) buf[7])[0] = rslt.getShort(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((bool[]) buf[9])[0] = rslt.getBool(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((bool[]) buf[11])[0] = rslt.getBool(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((bool[]) buf[13])[0] = rslt.getBool(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((long[]) buf[17])[0] = rslt.getLong(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              ((String[]) buf[19])[0] = rslt.getVarchar(11) ;
              ((bool[]) buf[20])[0] = rslt.wasNull(11);
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
              if ( (bool)parms[1] )
              {
                 stmt.setNull( 2 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(2, (String)parms[2]);
              }
              if ( (bool)parms[3] )
              {
                 stmt.setNull( 3 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(3, (String)parms[4]);
              }
              if ( (bool)parms[5] )
              {
                 stmt.setNull( 4 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameter(4, (DateTime)parms[6]);
              }
              if ( (bool)parms[7] )
              {
                 stmt.setNull( 5 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(5, (short)parms[8]);
              }
              if ( (bool)parms[9] )
              {
                 stmt.setNull( 6 , SqlDbType.Bit );
              }
              else
              {
                 stmt.SetParameter(6, (bool)parms[10]);
              }
              if ( (bool)parms[11] )
              {
                 stmt.setNull( 7 , SqlDbType.Bit );
              }
              else
              {
                 stmt.SetParameter(7, (bool)parms[12]);
              }
              if ( (bool)parms[13] )
              {
                 stmt.setNull( 8 , SqlDbType.Bit );
              }
              else
              {
                 stmt.SetParameter(8, (bool)parms[14]);
              }
              if ( (bool)parms[15] )
              {
                 stmt.setNull( 9 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(9, (String)parms[16]);
              }
              if ( (bool)parms[17] )
              {
                 stmt.setNull( 10 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(10, (long)parms[18]);
              }
              if ( (bool)parms[19] )
              {
                 stmt.setNull( 11 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(11, (String)parms[20]);
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
                 stmt.setNull( 2 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(2, (String)parms[3]);
              }
              if ( (bool)parms[4] )
              {
                 stmt.setNull( 3 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameter(3, (DateTime)parms[5]);
              }
              if ( (bool)parms[6] )
              {
                 stmt.setNull( 4 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(4, (short)parms[7]);
              }
              if ( (bool)parms[8] )
              {
                 stmt.setNull( 5 , SqlDbType.Bit );
              }
              else
              {
                 stmt.SetParameter(5, (bool)parms[9]);
              }
              if ( (bool)parms[10] )
              {
                 stmt.setNull( 6 , SqlDbType.Bit );
              }
              else
              {
                 stmt.SetParameter(6, (bool)parms[11]);
              }
              if ( (bool)parms[12] )
              {
                 stmt.setNull( 7 , SqlDbType.Bit );
              }
              else
              {
                 stmt.SetParameter(7, (bool)parms[13]);
              }
              if ( (bool)parms[14] )
              {
                 stmt.setNull( 8 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(8, (String)parms[15]);
              }
              if ( (bool)parms[16] )
              {
                 stmt.setNull( 9 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(9, (long)parms[17]);
              }
              if ( (bool)parms[18] )
              {
                 stmt.setNull( 10 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(10, (String)parms[19]);
              }
              stmt.SetParameter(11, (long)parms[20]);
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
