/*
               File: View_New_Encounter2_BC
        Description: View_New_Encounter2
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:9:7.42
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
   public class view_new_encounter2_bc : GXHttpHandler, IGxSilentTrn
   {
      public view_new_encounter2_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public view_new_encounter2_bc( IGxContext context )
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
         ReadRow1T75( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey1T75( ) ;
         standaloneModal( ) ;
         AddRow1T75( ) ;
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
               Z591View_New_Encounter2view_NE_EncounterID = A591View_New_Encounter2view_NE_EncounterID;
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

      protected void CONFIRM_1T0( )
      {
         BeforeValidate1T75( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls1T75( ) ;
            }
            else
            {
               CheckExtendedTable1T75( ) ;
               if ( AnyError == 0 )
               {
               }
               CloseExtendedTableCursors1T75( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void ZM1T75( short GX_JID )
      {
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            Z592View_New_Encounter2view_NE_ENCType = A592View_New_Encounter2view_NE_ENCType;
            Z593View_New_Encounter2view_NE_Departmentadm = A593View_New_Encounter2view_NE_Departmentadm;
            Z594View_New_Encounter2view_NE_AdmitDate = A594View_New_Encounter2view_NE_AdmitDate;
            Z595View_New_Encounter2view_NE_Status = A595View_New_Encounter2view_NE_Status;
            Z596View_New_Encounter2view_NE_IsRandRecheck = A596View_New_Encounter2view_NE_IsRandRecheck;
            Z597View_New_Encounter2view_NE_IsRandApprove = A597View_New_Encounter2view_NE_IsRandApprove;
            Z598View_New_Encounter2view_NE_IsUpdate = A598View_New_Encounter2view_NE_IsUpdate;
            Z599View_New_Encounter2view_NE_TenantTenantCode = A599View_New_Encounter2view_NE_TenantTenantCode;
            Z600View_New_Encounter2view_NE_Information_ID = A600View_New_Encounter2view_NE_Information_ID;
            Z601View_New_Encounter2view_NE_Information_PatientNo = A601View_New_Encounter2view_NE_Information_PatientNo;
         }
         if ( GX_JID == -3 )
         {
            Z591View_New_Encounter2view_NE_EncounterID = A591View_New_Encounter2view_NE_EncounterID;
            Z592View_New_Encounter2view_NE_ENCType = A592View_New_Encounter2view_NE_ENCType;
            Z593View_New_Encounter2view_NE_Departmentadm = A593View_New_Encounter2view_NE_Departmentadm;
            Z594View_New_Encounter2view_NE_AdmitDate = A594View_New_Encounter2view_NE_AdmitDate;
            Z595View_New_Encounter2view_NE_Status = A595View_New_Encounter2view_NE_Status;
            Z596View_New_Encounter2view_NE_IsRandRecheck = A596View_New_Encounter2view_NE_IsRandRecheck;
            Z597View_New_Encounter2view_NE_IsRandApprove = A597View_New_Encounter2view_NE_IsRandApprove;
            Z598View_New_Encounter2view_NE_IsUpdate = A598View_New_Encounter2view_NE_IsUpdate;
            Z599View_New_Encounter2view_NE_TenantTenantCode = A599View_New_Encounter2view_NE_TenantTenantCode;
            Z600View_New_Encounter2view_NE_Information_ID = A600View_New_Encounter2view_NE_Information_ID;
            Z601View_New_Encounter2view_NE_Information_PatientNo = A601View_New_Encounter2view_NE_Information_PatientNo;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load1T75( )
      {
         /* Using cursor BC001T4 */
         pr_default.execute(2, new Object[] {A591View_New_Encounter2view_NE_EncounterID});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound75 = 1;
            A592View_New_Encounter2view_NE_ENCType = BC001T4_A592View_New_Encounter2view_NE_ENCType[0];
            n592View_New_Encounter2view_NE_ENCType = BC001T4_n592View_New_Encounter2view_NE_ENCType[0];
            A593View_New_Encounter2view_NE_Departmentadm = BC001T4_A593View_New_Encounter2view_NE_Departmentadm[0];
            n593View_New_Encounter2view_NE_Departmentadm = BC001T4_n593View_New_Encounter2view_NE_Departmentadm[0];
            A594View_New_Encounter2view_NE_AdmitDate = BC001T4_A594View_New_Encounter2view_NE_AdmitDate[0];
            n594View_New_Encounter2view_NE_AdmitDate = BC001T4_n594View_New_Encounter2view_NE_AdmitDate[0];
            A595View_New_Encounter2view_NE_Status = BC001T4_A595View_New_Encounter2view_NE_Status[0];
            n595View_New_Encounter2view_NE_Status = BC001T4_n595View_New_Encounter2view_NE_Status[0];
            A596View_New_Encounter2view_NE_IsRandRecheck = BC001T4_A596View_New_Encounter2view_NE_IsRandRecheck[0];
            n596View_New_Encounter2view_NE_IsRandRecheck = BC001T4_n596View_New_Encounter2view_NE_IsRandRecheck[0];
            A597View_New_Encounter2view_NE_IsRandApprove = BC001T4_A597View_New_Encounter2view_NE_IsRandApprove[0];
            n597View_New_Encounter2view_NE_IsRandApprove = BC001T4_n597View_New_Encounter2view_NE_IsRandApprove[0];
            A598View_New_Encounter2view_NE_IsUpdate = BC001T4_A598View_New_Encounter2view_NE_IsUpdate[0];
            n598View_New_Encounter2view_NE_IsUpdate = BC001T4_n598View_New_Encounter2view_NE_IsUpdate[0];
            A599View_New_Encounter2view_NE_TenantTenantCode = BC001T4_A599View_New_Encounter2view_NE_TenantTenantCode[0];
            n599View_New_Encounter2view_NE_TenantTenantCode = BC001T4_n599View_New_Encounter2view_NE_TenantTenantCode[0];
            A600View_New_Encounter2view_NE_Information_ID = BC001T4_A600View_New_Encounter2view_NE_Information_ID[0];
            n600View_New_Encounter2view_NE_Information_ID = BC001T4_n600View_New_Encounter2view_NE_Information_ID[0];
            A601View_New_Encounter2view_NE_Information_PatientNo = BC001T4_A601View_New_Encounter2view_NE_Information_PatientNo[0];
            n601View_New_Encounter2view_NE_Information_PatientNo = BC001T4_n601View_New_Encounter2view_NE_Information_PatientNo[0];
            ZM1T75( -3) ;
         }
         pr_default.close(2);
         OnLoadActions1T75( ) ;
      }

      protected void OnLoadActions1T75( )
      {
      }

      protected void CheckExtendedTable1T75( )
      {
         standaloneModal( ) ;
         if ( ! ( (DateTime.MinValue==A594View_New_Encounter2view_NE_AdmitDate) || ( A594View_New_Encounter2view_NE_AdmitDate >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("”ÚView_New_Encounter2view_NE_Admit Date≥¨ΩÁ", "OutOfRange", 1, "");
            AnyError = 1;
         }
         if ( ! ( ( A595View_New_Encounter2view_NE_Status == 1 ) || ( A595View_New_Encounter2view_NE_Status == 2 ) || ( A595View_New_Encounter2view_NE_Status == 3 ) || ( A595View_New_Encounter2view_NE_Status == 4 ) || ( A595View_New_Encounter2view_NE_Status == 5 ) || ( A595View_New_Encounter2view_NE_Status == 6 ) || (0==A595View_New_Encounter2view_NE_Status) ) )
         {
            GX_msglist.addItem("”ÚView_New_Encounter2view_NE_Status≥¨ΩÁ", "OutOfRange", 1, "");
            AnyError = 1;
         }
      }

      protected void CloseExtendedTableCursors1T75( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey1T75( )
      {
         /* Using cursor BC001T5 */
         pr_default.execute(3, new Object[] {A591View_New_Encounter2view_NE_EncounterID});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound75 = 1;
         }
         else
         {
            RcdFound75 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC001T3 */
         pr_default.execute(1, new Object[] {A591View_New_Encounter2view_NE_EncounterID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM1T75( 3) ;
            RcdFound75 = 1;
            A591View_New_Encounter2view_NE_EncounterID = BC001T3_A591View_New_Encounter2view_NE_EncounterID[0];
            A592View_New_Encounter2view_NE_ENCType = BC001T3_A592View_New_Encounter2view_NE_ENCType[0];
            n592View_New_Encounter2view_NE_ENCType = BC001T3_n592View_New_Encounter2view_NE_ENCType[0];
            A593View_New_Encounter2view_NE_Departmentadm = BC001T3_A593View_New_Encounter2view_NE_Departmentadm[0];
            n593View_New_Encounter2view_NE_Departmentadm = BC001T3_n593View_New_Encounter2view_NE_Departmentadm[0];
            A594View_New_Encounter2view_NE_AdmitDate = BC001T3_A594View_New_Encounter2view_NE_AdmitDate[0];
            n594View_New_Encounter2view_NE_AdmitDate = BC001T3_n594View_New_Encounter2view_NE_AdmitDate[0];
            A595View_New_Encounter2view_NE_Status = BC001T3_A595View_New_Encounter2view_NE_Status[0];
            n595View_New_Encounter2view_NE_Status = BC001T3_n595View_New_Encounter2view_NE_Status[0];
            A596View_New_Encounter2view_NE_IsRandRecheck = BC001T3_A596View_New_Encounter2view_NE_IsRandRecheck[0];
            n596View_New_Encounter2view_NE_IsRandRecheck = BC001T3_n596View_New_Encounter2view_NE_IsRandRecheck[0];
            A597View_New_Encounter2view_NE_IsRandApprove = BC001T3_A597View_New_Encounter2view_NE_IsRandApprove[0];
            n597View_New_Encounter2view_NE_IsRandApprove = BC001T3_n597View_New_Encounter2view_NE_IsRandApprove[0];
            A598View_New_Encounter2view_NE_IsUpdate = BC001T3_A598View_New_Encounter2view_NE_IsUpdate[0];
            n598View_New_Encounter2view_NE_IsUpdate = BC001T3_n598View_New_Encounter2view_NE_IsUpdate[0];
            A599View_New_Encounter2view_NE_TenantTenantCode = BC001T3_A599View_New_Encounter2view_NE_TenantTenantCode[0];
            n599View_New_Encounter2view_NE_TenantTenantCode = BC001T3_n599View_New_Encounter2view_NE_TenantTenantCode[0];
            A600View_New_Encounter2view_NE_Information_ID = BC001T3_A600View_New_Encounter2view_NE_Information_ID[0];
            n600View_New_Encounter2view_NE_Information_ID = BC001T3_n600View_New_Encounter2view_NE_Information_ID[0];
            A601View_New_Encounter2view_NE_Information_PatientNo = BC001T3_A601View_New_Encounter2view_NE_Information_PatientNo[0];
            n601View_New_Encounter2view_NE_Information_PatientNo = BC001T3_n601View_New_Encounter2view_NE_Information_PatientNo[0];
            Z591View_New_Encounter2view_NE_EncounterID = A591View_New_Encounter2view_NE_EncounterID;
            sMode75 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load1T75( ) ;
            if ( AnyError == 1 )
            {
               RcdFound75 = 0;
               InitializeNonKey1T75( ) ;
            }
            Gx_mode = sMode75;
         }
         else
         {
            RcdFound75 = 0;
            InitializeNonKey1T75( ) ;
            sMode75 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode75;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1T75( ) ;
         if ( RcdFound75 == 0 )
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
         CONFIRM_1T0( ) ;
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

      protected void CheckOptimisticConcurrency1T75( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC001T2 */
            pr_default.execute(0, new Object[] {A591View_New_Encounter2view_NE_EncounterID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"View_New_Encounter"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z592View_New_Encounter2view_NE_ENCType, BC001T2_A592View_New_Encounter2view_NE_ENCType[0]) != 0 ) || ( StringUtil.StrCmp(Z593View_New_Encounter2view_NE_Departmentadm, BC001T2_A593View_New_Encounter2view_NE_Departmentadm[0]) != 0 ) || ( Z594View_New_Encounter2view_NE_AdmitDate != BC001T2_A594View_New_Encounter2view_NE_AdmitDate[0] ) || ( Z595View_New_Encounter2view_NE_Status != BC001T2_A595View_New_Encounter2view_NE_Status[0] ) || ( Z596View_New_Encounter2view_NE_IsRandRecheck != BC001T2_A596View_New_Encounter2view_NE_IsRandRecheck[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z597View_New_Encounter2view_NE_IsRandApprove != BC001T2_A597View_New_Encounter2view_NE_IsRandApprove[0] ) || ( Z598View_New_Encounter2view_NE_IsUpdate != BC001T2_A598View_New_Encounter2view_NE_IsUpdate[0] ) || ( StringUtil.StrCmp(Z599View_New_Encounter2view_NE_TenantTenantCode, BC001T2_A599View_New_Encounter2view_NE_TenantTenantCode[0]) != 0 ) || ( Z600View_New_Encounter2view_NE_Information_ID != BC001T2_A600View_New_Encounter2view_NE_Information_ID[0] ) || ( StringUtil.StrCmp(Z601View_New_Encounter2view_NE_Information_PatientNo, BC001T2_A601View_New_Encounter2view_NE_Information_PatientNo[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"View_New_Encounter"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert1T75( )
      {
         BeforeValidate1T75( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1T75( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1T75( 0) ;
            CheckOptimisticConcurrency1T75( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1T75( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1T75( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC001T6 */
                     pr_default.execute(4, new Object[] {A591View_New_Encounter2view_NE_EncounterID, n592View_New_Encounter2view_NE_ENCType, A592View_New_Encounter2view_NE_ENCType, n593View_New_Encounter2view_NE_Departmentadm, A593View_New_Encounter2view_NE_Departmentadm, n594View_New_Encounter2view_NE_AdmitDate, A594View_New_Encounter2view_NE_AdmitDate, n595View_New_Encounter2view_NE_Status, A595View_New_Encounter2view_NE_Status, n596View_New_Encounter2view_NE_IsRandRecheck, A596View_New_Encounter2view_NE_IsRandRecheck, n597View_New_Encounter2view_NE_IsRandApprove, A597View_New_Encounter2view_NE_IsRandApprove, n598View_New_Encounter2view_NE_IsUpdate, A598View_New_Encounter2view_NE_IsUpdate, n599View_New_Encounter2view_NE_TenantTenantCode, A599View_New_Encounter2view_NE_TenantTenantCode, n600View_New_Encounter2view_NE_Information_ID, A600View_New_Encounter2view_NE_Information_ID, n601View_New_Encounter2view_NE_Information_PatientNo, A601View_New_Encounter2view_NE_Information_PatientNo});
                     pr_default.close(4);
                     dsDefault.SmartCacheProvider.SetUpdated("View_New_Encounter") ;
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
               Load1T75( ) ;
            }
            EndLevel1T75( ) ;
         }
         CloseExtendedTableCursors1T75( ) ;
      }

      protected void Update1T75( )
      {
         BeforeValidate1T75( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1T75( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1T75( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1T75( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1T75( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC001T7 */
                     pr_default.execute(5, new Object[] {n592View_New_Encounter2view_NE_ENCType, A592View_New_Encounter2view_NE_ENCType, n593View_New_Encounter2view_NE_Departmentadm, A593View_New_Encounter2view_NE_Departmentadm, n594View_New_Encounter2view_NE_AdmitDate, A594View_New_Encounter2view_NE_AdmitDate, n595View_New_Encounter2view_NE_Status, A595View_New_Encounter2view_NE_Status, n596View_New_Encounter2view_NE_IsRandRecheck, A596View_New_Encounter2view_NE_IsRandRecheck, n597View_New_Encounter2view_NE_IsRandApprove, A597View_New_Encounter2view_NE_IsRandApprove, n598View_New_Encounter2view_NE_IsUpdate, A598View_New_Encounter2view_NE_IsUpdate, n599View_New_Encounter2view_NE_TenantTenantCode, A599View_New_Encounter2view_NE_TenantTenantCode, n600View_New_Encounter2view_NE_Information_ID, A600View_New_Encounter2view_NE_Information_ID, n601View_New_Encounter2view_NE_Information_PatientNo, A601View_New_Encounter2view_NE_Information_PatientNo, A591View_New_Encounter2view_NE_EncounterID});
                     pr_default.close(5);
                     dsDefault.SmartCacheProvider.SetUpdated("View_New_Encounter") ;
                     if ( (pr_default.getStatus(5) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"View_New_Encounter"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate1T75( ) ;
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
            EndLevel1T75( ) ;
         }
         CloseExtendedTableCursors1T75( ) ;
      }

      protected void DeferredUpdate1T75( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate1T75( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1T75( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1T75( ) ;
            AfterConfirm1T75( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1T75( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC001T8 */
                  pr_default.execute(6, new Object[] {A591View_New_Encounter2view_NE_EncounterID});
                  pr_default.close(6);
                  dsDefault.SmartCacheProvider.SetUpdated("View_New_Encounter") ;
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
         sMode75 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel1T75( ) ;
         Gx_mode = sMode75;
      }

      protected void OnDeleteControls1T75( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel1T75( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1T75( ) ;
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

      public void ScanKeyStart1T75( )
      {
         /* Using cursor BC001T9 */
         pr_default.execute(7, new Object[] {A591View_New_Encounter2view_NE_EncounterID});
         RcdFound75 = 0;
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound75 = 1;
            A591View_New_Encounter2view_NE_EncounterID = BC001T9_A591View_New_Encounter2view_NE_EncounterID[0];
            A592View_New_Encounter2view_NE_ENCType = BC001T9_A592View_New_Encounter2view_NE_ENCType[0];
            n592View_New_Encounter2view_NE_ENCType = BC001T9_n592View_New_Encounter2view_NE_ENCType[0];
            A593View_New_Encounter2view_NE_Departmentadm = BC001T9_A593View_New_Encounter2view_NE_Departmentadm[0];
            n593View_New_Encounter2view_NE_Departmentadm = BC001T9_n593View_New_Encounter2view_NE_Departmentadm[0];
            A594View_New_Encounter2view_NE_AdmitDate = BC001T9_A594View_New_Encounter2view_NE_AdmitDate[0];
            n594View_New_Encounter2view_NE_AdmitDate = BC001T9_n594View_New_Encounter2view_NE_AdmitDate[0];
            A595View_New_Encounter2view_NE_Status = BC001T9_A595View_New_Encounter2view_NE_Status[0];
            n595View_New_Encounter2view_NE_Status = BC001T9_n595View_New_Encounter2view_NE_Status[0];
            A596View_New_Encounter2view_NE_IsRandRecheck = BC001T9_A596View_New_Encounter2view_NE_IsRandRecheck[0];
            n596View_New_Encounter2view_NE_IsRandRecheck = BC001T9_n596View_New_Encounter2view_NE_IsRandRecheck[0];
            A597View_New_Encounter2view_NE_IsRandApprove = BC001T9_A597View_New_Encounter2view_NE_IsRandApprove[0];
            n597View_New_Encounter2view_NE_IsRandApprove = BC001T9_n597View_New_Encounter2view_NE_IsRandApprove[0];
            A598View_New_Encounter2view_NE_IsUpdate = BC001T9_A598View_New_Encounter2view_NE_IsUpdate[0];
            n598View_New_Encounter2view_NE_IsUpdate = BC001T9_n598View_New_Encounter2view_NE_IsUpdate[0];
            A599View_New_Encounter2view_NE_TenantTenantCode = BC001T9_A599View_New_Encounter2view_NE_TenantTenantCode[0];
            n599View_New_Encounter2view_NE_TenantTenantCode = BC001T9_n599View_New_Encounter2view_NE_TenantTenantCode[0];
            A600View_New_Encounter2view_NE_Information_ID = BC001T9_A600View_New_Encounter2view_NE_Information_ID[0];
            n600View_New_Encounter2view_NE_Information_ID = BC001T9_n600View_New_Encounter2view_NE_Information_ID[0];
            A601View_New_Encounter2view_NE_Information_PatientNo = BC001T9_A601View_New_Encounter2view_NE_Information_PatientNo[0];
            n601View_New_Encounter2view_NE_Information_PatientNo = BC001T9_n601View_New_Encounter2view_NE_Information_PatientNo[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext1T75( )
      {
         /* Scan next routine */
         pr_default.readNext(7);
         RcdFound75 = 0;
         ScanKeyLoad1T75( ) ;
      }

      protected void ScanKeyLoad1T75( )
      {
         sMode75 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound75 = 1;
            A591View_New_Encounter2view_NE_EncounterID = BC001T9_A591View_New_Encounter2view_NE_EncounterID[0];
            A592View_New_Encounter2view_NE_ENCType = BC001T9_A592View_New_Encounter2view_NE_ENCType[0];
            n592View_New_Encounter2view_NE_ENCType = BC001T9_n592View_New_Encounter2view_NE_ENCType[0];
            A593View_New_Encounter2view_NE_Departmentadm = BC001T9_A593View_New_Encounter2view_NE_Departmentadm[0];
            n593View_New_Encounter2view_NE_Departmentadm = BC001T9_n593View_New_Encounter2view_NE_Departmentadm[0];
            A594View_New_Encounter2view_NE_AdmitDate = BC001T9_A594View_New_Encounter2view_NE_AdmitDate[0];
            n594View_New_Encounter2view_NE_AdmitDate = BC001T9_n594View_New_Encounter2view_NE_AdmitDate[0];
            A595View_New_Encounter2view_NE_Status = BC001T9_A595View_New_Encounter2view_NE_Status[0];
            n595View_New_Encounter2view_NE_Status = BC001T9_n595View_New_Encounter2view_NE_Status[0];
            A596View_New_Encounter2view_NE_IsRandRecheck = BC001T9_A596View_New_Encounter2view_NE_IsRandRecheck[0];
            n596View_New_Encounter2view_NE_IsRandRecheck = BC001T9_n596View_New_Encounter2view_NE_IsRandRecheck[0];
            A597View_New_Encounter2view_NE_IsRandApprove = BC001T9_A597View_New_Encounter2view_NE_IsRandApprove[0];
            n597View_New_Encounter2view_NE_IsRandApprove = BC001T9_n597View_New_Encounter2view_NE_IsRandApprove[0];
            A598View_New_Encounter2view_NE_IsUpdate = BC001T9_A598View_New_Encounter2view_NE_IsUpdate[0];
            n598View_New_Encounter2view_NE_IsUpdate = BC001T9_n598View_New_Encounter2view_NE_IsUpdate[0];
            A599View_New_Encounter2view_NE_TenantTenantCode = BC001T9_A599View_New_Encounter2view_NE_TenantTenantCode[0];
            n599View_New_Encounter2view_NE_TenantTenantCode = BC001T9_n599View_New_Encounter2view_NE_TenantTenantCode[0];
            A600View_New_Encounter2view_NE_Information_ID = BC001T9_A600View_New_Encounter2view_NE_Information_ID[0];
            n600View_New_Encounter2view_NE_Information_ID = BC001T9_n600View_New_Encounter2view_NE_Information_ID[0];
            A601View_New_Encounter2view_NE_Information_PatientNo = BC001T9_A601View_New_Encounter2view_NE_Information_PatientNo[0];
            n601View_New_Encounter2view_NE_Information_PatientNo = BC001T9_n601View_New_Encounter2view_NE_Information_PatientNo[0];
         }
         Gx_mode = sMode75;
      }

      protected void ScanKeyEnd1T75( )
      {
         pr_default.close(7);
      }

      protected void AfterConfirm1T75( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1T75( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1T75( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1T75( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1T75( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1T75( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1T75( )
      {
      }

      protected void send_integrity_lvl_hashes1T75( )
      {
      }

      protected void AddRow1T75( )
      {
         VarsToRow75( bcView_New_Encounter2) ;
      }

      protected void ReadRow1T75( )
      {
         RowToVars75( bcView_New_Encounter2, 1) ;
      }

      protected void InitializeNonKey1T75( )
      {
         A592View_New_Encounter2view_NE_ENCType = "";
         n592View_New_Encounter2view_NE_ENCType = false;
         A593View_New_Encounter2view_NE_Departmentadm = "";
         n593View_New_Encounter2view_NE_Departmentadm = false;
         A594View_New_Encounter2view_NE_AdmitDate = DateTime.MinValue;
         n594View_New_Encounter2view_NE_AdmitDate = false;
         A595View_New_Encounter2view_NE_Status = 0;
         n595View_New_Encounter2view_NE_Status = false;
         A596View_New_Encounter2view_NE_IsRandRecheck = false;
         n596View_New_Encounter2view_NE_IsRandRecheck = false;
         A597View_New_Encounter2view_NE_IsRandApprove = false;
         n597View_New_Encounter2view_NE_IsRandApprove = false;
         A598View_New_Encounter2view_NE_IsUpdate = false;
         n598View_New_Encounter2view_NE_IsUpdate = false;
         A599View_New_Encounter2view_NE_TenantTenantCode = "";
         n599View_New_Encounter2view_NE_TenantTenantCode = false;
         A600View_New_Encounter2view_NE_Information_ID = 0;
         n600View_New_Encounter2view_NE_Information_ID = false;
         A601View_New_Encounter2view_NE_Information_PatientNo = "";
         n601View_New_Encounter2view_NE_Information_PatientNo = false;
         Z592View_New_Encounter2view_NE_ENCType = "";
         Z593View_New_Encounter2view_NE_Departmentadm = "";
         Z594View_New_Encounter2view_NE_AdmitDate = DateTime.MinValue;
         Z595View_New_Encounter2view_NE_Status = 0;
         Z596View_New_Encounter2view_NE_IsRandRecheck = false;
         Z597View_New_Encounter2view_NE_IsRandApprove = false;
         Z598View_New_Encounter2view_NE_IsUpdate = false;
         Z599View_New_Encounter2view_NE_TenantTenantCode = "";
         Z600View_New_Encounter2view_NE_Information_ID = 0;
         Z601View_New_Encounter2view_NE_Information_PatientNo = "";
      }

      protected void InitAll1T75( )
      {
         A591View_New_Encounter2view_NE_EncounterID = 0;
         InitializeNonKey1T75( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow75( SdtView_New_Encounter2 obj75 )
      {
         obj75.gxTpr_Mode = Gx_mode;
         obj75.gxTpr_View_new_encounter2view_ne_enctype = A592View_New_Encounter2view_NE_ENCType;
         obj75.gxTpr_View_new_encounter2view_ne_departmentadm = A593View_New_Encounter2view_NE_Departmentadm;
         obj75.gxTpr_View_new_encounter2view_ne_admitdate = A594View_New_Encounter2view_NE_AdmitDate;
         obj75.gxTpr_View_new_encounter2view_ne_status = A595View_New_Encounter2view_NE_Status;
         obj75.gxTpr_View_new_encounter2view_ne_israndrecheck = A596View_New_Encounter2view_NE_IsRandRecheck;
         obj75.gxTpr_View_new_encounter2view_ne_israndapprove = A597View_New_Encounter2view_NE_IsRandApprove;
         obj75.gxTpr_View_new_encounter2view_ne_isupdate = A598View_New_Encounter2view_NE_IsUpdate;
         obj75.gxTpr_View_new_encounter2view_ne_tenanttenantcode = A599View_New_Encounter2view_NE_TenantTenantCode;
         obj75.gxTpr_View_new_encounter2view_ne_information_id = A600View_New_Encounter2view_NE_Information_ID;
         obj75.gxTpr_View_new_encounter2view_ne_information_patientno = A601View_New_Encounter2view_NE_Information_PatientNo;
         obj75.gxTpr_View_new_encounter2view_ne_encounterid = A591View_New_Encounter2view_NE_EncounterID;
         obj75.gxTpr_View_new_encounter2view_ne_encounterid_Z = Z591View_New_Encounter2view_NE_EncounterID;
         obj75.gxTpr_View_new_encounter2view_ne_enctype_Z = Z592View_New_Encounter2view_NE_ENCType;
         obj75.gxTpr_View_new_encounter2view_ne_departmentadm_Z = Z593View_New_Encounter2view_NE_Departmentadm;
         obj75.gxTpr_View_new_encounter2view_ne_admitdate_Z = Z594View_New_Encounter2view_NE_AdmitDate;
         obj75.gxTpr_View_new_encounter2view_ne_status_Z = Z595View_New_Encounter2view_NE_Status;
         obj75.gxTpr_View_new_encounter2view_ne_israndrecheck_Z = Z596View_New_Encounter2view_NE_IsRandRecheck;
         obj75.gxTpr_View_new_encounter2view_ne_israndapprove_Z = Z597View_New_Encounter2view_NE_IsRandApprove;
         obj75.gxTpr_View_new_encounter2view_ne_isupdate_Z = Z598View_New_Encounter2view_NE_IsUpdate;
         obj75.gxTpr_View_new_encounter2view_ne_tenanttenantcode_Z = Z599View_New_Encounter2view_NE_TenantTenantCode;
         obj75.gxTpr_View_new_encounter2view_ne_information_id_Z = Z600View_New_Encounter2view_NE_Information_ID;
         obj75.gxTpr_View_new_encounter2view_ne_information_patientno_Z = Z601View_New_Encounter2view_NE_Information_PatientNo;
         obj75.gxTpr_View_new_encounter2view_ne_enctype_N = (short)(Convert.ToInt16(n592View_New_Encounter2view_NE_ENCType));
         obj75.gxTpr_View_new_encounter2view_ne_departmentadm_N = (short)(Convert.ToInt16(n593View_New_Encounter2view_NE_Departmentadm));
         obj75.gxTpr_View_new_encounter2view_ne_admitdate_N = (short)(Convert.ToInt16(n594View_New_Encounter2view_NE_AdmitDate));
         obj75.gxTpr_View_new_encounter2view_ne_status_N = (short)(Convert.ToInt16(n595View_New_Encounter2view_NE_Status));
         obj75.gxTpr_View_new_encounter2view_ne_israndrecheck_N = (short)(Convert.ToInt16(n596View_New_Encounter2view_NE_IsRandRecheck));
         obj75.gxTpr_View_new_encounter2view_ne_israndapprove_N = (short)(Convert.ToInt16(n597View_New_Encounter2view_NE_IsRandApprove));
         obj75.gxTpr_View_new_encounter2view_ne_isupdate_N = (short)(Convert.ToInt16(n598View_New_Encounter2view_NE_IsUpdate));
         obj75.gxTpr_View_new_encounter2view_ne_tenanttenantcode_N = (short)(Convert.ToInt16(n599View_New_Encounter2view_NE_TenantTenantCode));
         obj75.gxTpr_View_new_encounter2view_ne_information_id_N = (short)(Convert.ToInt16(n600View_New_Encounter2view_NE_Information_ID));
         obj75.gxTpr_View_new_encounter2view_ne_information_patientno_N = (short)(Convert.ToInt16(n601View_New_Encounter2view_NE_Information_PatientNo));
         obj75.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow75( SdtView_New_Encounter2 obj75 )
      {
         obj75.gxTpr_View_new_encounter2view_ne_encounterid = A591View_New_Encounter2view_NE_EncounterID;
         return  ;
      }

      public void RowToVars75( SdtView_New_Encounter2 obj75 ,
                               int forceLoad )
      {
         Gx_mode = obj75.gxTpr_Mode;
         A592View_New_Encounter2view_NE_ENCType = obj75.gxTpr_View_new_encounter2view_ne_enctype;
         n592View_New_Encounter2view_NE_ENCType = false;
         A593View_New_Encounter2view_NE_Departmentadm = obj75.gxTpr_View_new_encounter2view_ne_departmentadm;
         n593View_New_Encounter2view_NE_Departmentadm = false;
         A594View_New_Encounter2view_NE_AdmitDate = obj75.gxTpr_View_new_encounter2view_ne_admitdate;
         n594View_New_Encounter2view_NE_AdmitDate = false;
         A595View_New_Encounter2view_NE_Status = obj75.gxTpr_View_new_encounter2view_ne_status;
         n595View_New_Encounter2view_NE_Status = false;
         A596View_New_Encounter2view_NE_IsRandRecheck = obj75.gxTpr_View_new_encounter2view_ne_israndrecheck;
         n596View_New_Encounter2view_NE_IsRandRecheck = false;
         A597View_New_Encounter2view_NE_IsRandApprove = obj75.gxTpr_View_new_encounter2view_ne_israndapprove;
         n597View_New_Encounter2view_NE_IsRandApprove = false;
         A598View_New_Encounter2view_NE_IsUpdate = obj75.gxTpr_View_new_encounter2view_ne_isupdate;
         n598View_New_Encounter2view_NE_IsUpdate = false;
         A599View_New_Encounter2view_NE_TenantTenantCode = obj75.gxTpr_View_new_encounter2view_ne_tenanttenantcode;
         n599View_New_Encounter2view_NE_TenantTenantCode = false;
         A600View_New_Encounter2view_NE_Information_ID = obj75.gxTpr_View_new_encounter2view_ne_information_id;
         n600View_New_Encounter2view_NE_Information_ID = false;
         A601View_New_Encounter2view_NE_Information_PatientNo = obj75.gxTpr_View_new_encounter2view_ne_information_patientno;
         n601View_New_Encounter2view_NE_Information_PatientNo = false;
         A591View_New_Encounter2view_NE_EncounterID = obj75.gxTpr_View_new_encounter2view_ne_encounterid;
         Z591View_New_Encounter2view_NE_EncounterID = obj75.gxTpr_View_new_encounter2view_ne_encounterid_Z;
         Z592View_New_Encounter2view_NE_ENCType = obj75.gxTpr_View_new_encounter2view_ne_enctype_Z;
         Z593View_New_Encounter2view_NE_Departmentadm = obj75.gxTpr_View_new_encounter2view_ne_departmentadm_Z;
         Z594View_New_Encounter2view_NE_AdmitDate = obj75.gxTpr_View_new_encounter2view_ne_admitdate_Z;
         Z595View_New_Encounter2view_NE_Status = obj75.gxTpr_View_new_encounter2view_ne_status_Z;
         Z596View_New_Encounter2view_NE_IsRandRecheck = obj75.gxTpr_View_new_encounter2view_ne_israndrecheck_Z;
         Z597View_New_Encounter2view_NE_IsRandApprove = obj75.gxTpr_View_new_encounter2view_ne_israndapprove_Z;
         Z598View_New_Encounter2view_NE_IsUpdate = obj75.gxTpr_View_new_encounter2view_ne_isupdate_Z;
         Z599View_New_Encounter2view_NE_TenantTenantCode = obj75.gxTpr_View_new_encounter2view_ne_tenanttenantcode_Z;
         Z600View_New_Encounter2view_NE_Information_ID = obj75.gxTpr_View_new_encounter2view_ne_information_id_Z;
         Z601View_New_Encounter2view_NE_Information_PatientNo = obj75.gxTpr_View_new_encounter2view_ne_information_patientno_Z;
         n592View_New_Encounter2view_NE_ENCType = (bool)(Convert.ToBoolean(obj75.gxTpr_View_new_encounter2view_ne_enctype_N));
         n593View_New_Encounter2view_NE_Departmentadm = (bool)(Convert.ToBoolean(obj75.gxTpr_View_new_encounter2view_ne_departmentadm_N));
         n594View_New_Encounter2view_NE_AdmitDate = (bool)(Convert.ToBoolean(obj75.gxTpr_View_new_encounter2view_ne_admitdate_N));
         n595View_New_Encounter2view_NE_Status = (bool)(Convert.ToBoolean(obj75.gxTpr_View_new_encounter2view_ne_status_N));
         n596View_New_Encounter2view_NE_IsRandRecheck = (bool)(Convert.ToBoolean(obj75.gxTpr_View_new_encounter2view_ne_israndrecheck_N));
         n597View_New_Encounter2view_NE_IsRandApprove = (bool)(Convert.ToBoolean(obj75.gxTpr_View_new_encounter2view_ne_israndapprove_N));
         n598View_New_Encounter2view_NE_IsUpdate = (bool)(Convert.ToBoolean(obj75.gxTpr_View_new_encounter2view_ne_isupdate_N));
         n599View_New_Encounter2view_NE_TenantTenantCode = (bool)(Convert.ToBoolean(obj75.gxTpr_View_new_encounter2view_ne_tenanttenantcode_N));
         n600View_New_Encounter2view_NE_Information_ID = (bool)(Convert.ToBoolean(obj75.gxTpr_View_new_encounter2view_ne_information_id_N));
         n601View_New_Encounter2view_NE_Information_PatientNo = (bool)(Convert.ToBoolean(obj75.gxTpr_View_new_encounter2view_ne_information_patientno_N));
         Gx_mode = obj75.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A591View_New_Encounter2view_NE_EncounterID = (long)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey1T75( ) ;
         ScanKeyStart1T75( ) ;
         if ( RcdFound75 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z591View_New_Encounter2view_NE_EncounterID = A591View_New_Encounter2view_NE_EncounterID;
         }
         ZM1T75( -3) ;
         OnLoadActions1T75( ) ;
         AddRow1T75( ) ;
         ScanKeyEnd1T75( ) ;
         if ( RcdFound75 == 0 )
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
         RowToVars75( bcView_New_Encounter2, 0) ;
         ScanKeyStart1T75( ) ;
         if ( RcdFound75 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z591View_New_Encounter2view_NE_EncounterID = A591View_New_Encounter2view_NE_EncounterID;
         }
         ZM1T75( -3) ;
         OnLoadActions1T75( ) ;
         AddRow1T75( ) ;
         ScanKeyEnd1T75( ) ;
         if ( RcdFound75 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey1T75( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert1T75( ) ;
         }
         else
         {
            if ( RcdFound75 == 1 )
            {
               if ( A591View_New_Encounter2view_NE_EncounterID != Z591View_New_Encounter2view_NE_EncounterID )
               {
                  A591View_New_Encounter2view_NE_EncounterID = Z591View_New_Encounter2view_NE_EncounterID;
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
                  Update1T75( ) ;
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
                  if ( A591View_New_Encounter2view_NE_EncounterID != Z591View_New_Encounter2view_NE_EncounterID )
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
                        Insert1T75( ) ;
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
                        Insert1T75( ) ;
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
         RowToVars75( bcView_New_Encounter2, 0) ;
         SaveImpl( ) ;
         VarsToRow75( bcView_New_Encounter2) ;
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
         RowToVars75( bcView_New_Encounter2, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert1T75( ) ;
         AfterTrn( ) ;
         VarsToRow75( bcView_New_Encounter2) ;
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
            SdtView_New_Encounter2 auxBC = new SdtView_New_Encounter2(context) ;
            auxBC.Load(A591View_New_Encounter2view_NE_EncounterID);
            auxBC.UpdateDirties(bcView_New_Encounter2);
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
         RowToVars75( bcView_New_Encounter2, 0) ;
         UpdateImpl( ) ;
         VarsToRow75( bcView_New_Encounter2) ;
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
         RowToVars75( bcView_New_Encounter2, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert1T75( ) ;
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
         VarsToRow75( bcView_New_Encounter2) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars75( bcView_New_Encounter2, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey1T75( ) ;
         if ( RcdFound75 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A591View_New_Encounter2view_NE_EncounterID != Z591View_New_Encounter2view_NE_EncounterID )
            {
               A591View_New_Encounter2view_NE_EncounterID = Z591View_New_Encounter2view_NE_EncounterID;
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
            if ( A591View_New_Encounter2view_NE_EncounterID != Z591View_New_Encounter2view_NE_EncounterID )
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
         context.RollbackDataStores("view_new_encounter2_bc",pr_default);
         VarsToRow75( bcView_New_Encounter2) ;
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
         Gx_mode = bcView_New_Encounter2.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcView_New_Encounter2.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcView_New_Encounter2 )
         {
            bcView_New_Encounter2 = (SdtView_New_Encounter2)(sdt);
            if ( StringUtil.StrCmp(bcView_New_Encounter2.gxTpr_Mode, "") == 0 )
            {
               bcView_New_Encounter2.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow75( bcView_New_Encounter2) ;
            }
            else
            {
               RowToVars75( bcView_New_Encounter2, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcView_New_Encounter2.gxTpr_Mode, "") == 0 )
            {
               bcView_New_Encounter2.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars75( bcView_New_Encounter2, 1) ;
         return  ;
      }

      public SdtView_New_Encounter2 View_New_Encounter2_BC
      {
         get {
            return bcView_New_Encounter2 ;
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
         Z592View_New_Encounter2view_NE_ENCType = "";
         A592View_New_Encounter2view_NE_ENCType = "";
         Z593View_New_Encounter2view_NE_Departmentadm = "";
         A593View_New_Encounter2view_NE_Departmentadm = "";
         Z594View_New_Encounter2view_NE_AdmitDate = DateTime.MinValue;
         A594View_New_Encounter2view_NE_AdmitDate = DateTime.MinValue;
         Z599View_New_Encounter2view_NE_TenantTenantCode = "";
         A599View_New_Encounter2view_NE_TenantTenantCode = "";
         Z601View_New_Encounter2view_NE_Information_PatientNo = "";
         A601View_New_Encounter2view_NE_Information_PatientNo = "";
         BC001T4_A591View_New_Encounter2view_NE_EncounterID = new long[1] ;
         BC001T4_A592View_New_Encounter2view_NE_ENCType = new String[] {""} ;
         BC001T4_n592View_New_Encounter2view_NE_ENCType = new bool[] {false} ;
         BC001T4_A593View_New_Encounter2view_NE_Departmentadm = new String[] {""} ;
         BC001T4_n593View_New_Encounter2view_NE_Departmentadm = new bool[] {false} ;
         BC001T4_A594View_New_Encounter2view_NE_AdmitDate = new DateTime[] {DateTime.MinValue} ;
         BC001T4_n594View_New_Encounter2view_NE_AdmitDate = new bool[] {false} ;
         BC001T4_A595View_New_Encounter2view_NE_Status = new short[1] ;
         BC001T4_n595View_New_Encounter2view_NE_Status = new bool[] {false} ;
         BC001T4_A596View_New_Encounter2view_NE_IsRandRecheck = new bool[] {false} ;
         BC001T4_n596View_New_Encounter2view_NE_IsRandRecheck = new bool[] {false} ;
         BC001T4_A597View_New_Encounter2view_NE_IsRandApprove = new bool[] {false} ;
         BC001T4_n597View_New_Encounter2view_NE_IsRandApprove = new bool[] {false} ;
         BC001T4_A598View_New_Encounter2view_NE_IsUpdate = new bool[] {false} ;
         BC001T4_n598View_New_Encounter2view_NE_IsUpdate = new bool[] {false} ;
         BC001T4_A599View_New_Encounter2view_NE_TenantTenantCode = new String[] {""} ;
         BC001T4_n599View_New_Encounter2view_NE_TenantTenantCode = new bool[] {false} ;
         BC001T4_A600View_New_Encounter2view_NE_Information_ID = new long[1] ;
         BC001T4_n600View_New_Encounter2view_NE_Information_ID = new bool[] {false} ;
         BC001T4_A601View_New_Encounter2view_NE_Information_PatientNo = new String[] {""} ;
         BC001T4_n601View_New_Encounter2view_NE_Information_PatientNo = new bool[] {false} ;
         BC001T5_A591View_New_Encounter2view_NE_EncounterID = new long[1] ;
         BC001T3_A591View_New_Encounter2view_NE_EncounterID = new long[1] ;
         BC001T3_A592View_New_Encounter2view_NE_ENCType = new String[] {""} ;
         BC001T3_n592View_New_Encounter2view_NE_ENCType = new bool[] {false} ;
         BC001T3_A593View_New_Encounter2view_NE_Departmentadm = new String[] {""} ;
         BC001T3_n593View_New_Encounter2view_NE_Departmentadm = new bool[] {false} ;
         BC001T3_A594View_New_Encounter2view_NE_AdmitDate = new DateTime[] {DateTime.MinValue} ;
         BC001T3_n594View_New_Encounter2view_NE_AdmitDate = new bool[] {false} ;
         BC001T3_A595View_New_Encounter2view_NE_Status = new short[1] ;
         BC001T3_n595View_New_Encounter2view_NE_Status = new bool[] {false} ;
         BC001T3_A596View_New_Encounter2view_NE_IsRandRecheck = new bool[] {false} ;
         BC001T3_n596View_New_Encounter2view_NE_IsRandRecheck = new bool[] {false} ;
         BC001T3_A597View_New_Encounter2view_NE_IsRandApprove = new bool[] {false} ;
         BC001T3_n597View_New_Encounter2view_NE_IsRandApprove = new bool[] {false} ;
         BC001T3_A598View_New_Encounter2view_NE_IsUpdate = new bool[] {false} ;
         BC001T3_n598View_New_Encounter2view_NE_IsUpdate = new bool[] {false} ;
         BC001T3_A599View_New_Encounter2view_NE_TenantTenantCode = new String[] {""} ;
         BC001T3_n599View_New_Encounter2view_NE_TenantTenantCode = new bool[] {false} ;
         BC001T3_A600View_New_Encounter2view_NE_Information_ID = new long[1] ;
         BC001T3_n600View_New_Encounter2view_NE_Information_ID = new bool[] {false} ;
         BC001T3_A601View_New_Encounter2view_NE_Information_PatientNo = new String[] {""} ;
         BC001T3_n601View_New_Encounter2view_NE_Information_PatientNo = new bool[] {false} ;
         sMode75 = "";
         BC001T2_A591View_New_Encounter2view_NE_EncounterID = new long[1] ;
         BC001T2_A592View_New_Encounter2view_NE_ENCType = new String[] {""} ;
         BC001T2_n592View_New_Encounter2view_NE_ENCType = new bool[] {false} ;
         BC001T2_A593View_New_Encounter2view_NE_Departmentadm = new String[] {""} ;
         BC001T2_n593View_New_Encounter2view_NE_Departmentadm = new bool[] {false} ;
         BC001T2_A594View_New_Encounter2view_NE_AdmitDate = new DateTime[] {DateTime.MinValue} ;
         BC001T2_n594View_New_Encounter2view_NE_AdmitDate = new bool[] {false} ;
         BC001T2_A595View_New_Encounter2view_NE_Status = new short[1] ;
         BC001T2_n595View_New_Encounter2view_NE_Status = new bool[] {false} ;
         BC001T2_A596View_New_Encounter2view_NE_IsRandRecheck = new bool[] {false} ;
         BC001T2_n596View_New_Encounter2view_NE_IsRandRecheck = new bool[] {false} ;
         BC001T2_A597View_New_Encounter2view_NE_IsRandApprove = new bool[] {false} ;
         BC001T2_n597View_New_Encounter2view_NE_IsRandApprove = new bool[] {false} ;
         BC001T2_A598View_New_Encounter2view_NE_IsUpdate = new bool[] {false} ;
         BC001T2_n598View_New_Encounter2view_NE_IsUpdate = new bool[] {false} ;
         BC001T2_A599View_New_Encounter2view_NE_TenantTenantCode = new String[] {""} ;
         BC001T2_n599View_New_Encounter2view_NE_TenantTenantCode = new bool[] {false} ;
         BC001T2_A600View_New_Encounter2view_NE_Information_ID = new long[1] ;
         BC001T2_n600View_New_Encounter2view_NE_Information_ID = new bool[] {false} ;
         BC001T2_A601View_New_Encounter2view_NE_Information_PatientNo = new String[] {""} ;
         BC001T2_n601View_New_Encounter2view_NE_Information_PatientNo = new bool[] {false} ;
         BC001T9_A591View_New_Encounter2view_NE_EncounterID = new long[1] ;
         BC001T9_A592View_New_Encounter2view_NE_ENCType = new String[] {""} ;
         BC001T9_n592View_New_Encounter2view_NE_ENCType = new bool[] {false} ;
         BC001T9_A593View_New_Encounter2view_NE_Departmentadm = new String[] {""} ;
         BC001T9_n593View_New_Encounter2view_NE_Departmentadm = new bool[] {false} ;
         BC001T9_A594View_New_Encounter2view_NE_AdmitDate = new DateTime[] {DateTime.MinValue} ;
         BC001T9_n594View_New_Encounter2view_NE_AdmitDate = new bool[] {false} ;
         BC001T9_A595View_New_Encounter2view_NE_Status = new short[1] ;
         BC001T9_n595View_New_Encounter2view_NE_Status = new bool[] {false} ;
         BC001T9_A596View_New_Encounter2view_NE_IsRandRecheck = new bool[] {false} ;
         BC001T9_n596View_New_Encounter2view_NE_IsRandRecheck = new bool[] {false} ;
         BC001T9_A597View_New_Encounter2view_NE_IsRandApprove = new bool[] {false} ;
         BC001T9_n597View_New_Encounter2view_NE_IsRandApprove = new bool[] {false} ;
         BC001T9_A598View_New_Encounter2view_NE_IsUpdate = new bool[] {false} ;
         BC001T9_n598View_New_Encounter2view_NE_IsUpdate = new bool[] {false} ;
         BC001T9_A599View_New_Encounter2view_NE_TenantTenantCode = new String[] {""} ;
         BC001T9_n599View_New_Encounter2view_NE_TenantTenantCode = new bool[] {false} ;
         BC001T9_A600View_New_Encounter2view_NE_Information_ID = new long[1] ;
         BC001T9_n600View_New_Encounter2view_NE_Information_ID = new bool[] {false} ;
         BC001T9_A601View_New_Encounter2view_NE_Information_PatientNo = new String[] {""} ;
         BC001T9_n601View_New_Encounter2view_NE_Information_PatientNo = new bool[] {false} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.view_new_encounter2_bc__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.view_new_encounter2_bc__default(),
            new Object[][] {
                new Object[] {
               BC001T2_A591View_New_Encounter2view_NE_EncounterID, BC001T2_A592View_New_Encounter2view_NE_ENCType, BC001T2_n592View_New_Encounter2view_NE_ENCType, BC001T2_A593View_New_Encounter2view_NE_Departmentadm, BC001T2_n593View_New_Encounter2view_NE_Departmentadm, BC001T2_A594View_New_Encounter2view_NE_AdmitDate, BC001T2_n594View_New_Encounter2view_NE_AdmitDate, BC001T2_A595View_New_Encounter2view_NE_Status, BC001T2_n595View_New_Encounter2view_NE_Status, BC001T2_A596View_New_Encounter2view_NE_IsRandRecheck,
               BC001T2_n596View_New_Encounter2view_NE_IsRandRecheck, BC001T2_A597View_New_Encounter2view_NE_IsRandApprove, BC001T2_n597View_New_Encounter2view_NE_IsRandApprove, BC001T2_A598View_New_Encounter2view_NE_IsUpdate, BC001T2_n598View_New_Encounter2view_NE_IsUpdate, BC001T2_A599View_New_Encounter2view_NE_TenantTenantCode, BC001T2_n599View_New_Encounter2view_NE_TenantTenantCode, BC001T2_A600View_New_Encounter2view_NE_Information_ID, BC001T2_n600View_New_Encounter2view_NE_Information_ID, BC001T2_A601View_New_Encounter2view_NE_Information_PatientNo,
               BC001T2_n601View_New_Encounter2view_NE_Information_PatientNo
               }
               , new Object[] {
               BC001T3_A591View_New_Encounter2view_NE_EncounterID, BC001T3_A592View_New_Encounter2view_NE_ENCType, BC001T3_n592View_New_Encounter2view_NE_ENCType, BC001T3_A593View_New_Encounter2view_NE_Departmentadm, BC001T3_n593View_New_Encounter2view_NE_Departmentadm, BC001T3_A594View_New_Encounter2view_NE_AdmitDate, BC001T3_n594View_New_Encounter2view_NE_AdmitDate, BC001T3_A595View_New_Encounter2view_NE_Status, BC001T3_n595View_New_Encounter2view_NE_Status, BC001T3_A596View_New_Encounter2view_NE_IsRandRecheck,
               BC001T3_n596View_New_Encounter2view_NE_IsRandRecheck, BC001T3_A597View_New_Encounter2view_NE_IsRandApprove, BC001T3_n597View_New_Encounter2view_NE_IsRandApprove, BC001T3_A598View_New_Encounter2view_NE_IsUpdate, BC001T3_n598View_New_Encounter2view_NE_IsUpdate, BC001T3_A599View_New_Encounter2view_NE_TenantTenantCode, BC001T3_n599View_New_Encounter2view_NE_TenantTenantCode, BC001T3_A600View_New_Encounter2view_NE_Information_ID, BC001T3_n600View_New_Encounter2view_NE_Information_ID, BC001T3_A601View_New_Encounter2view_NE_Information_PatientNo,
               BC001T3_n601View_New_Encounter2view_NE_Information_PatientNo
               }
               , new Object[] {
               BC001T4_A591View_New_Encounter2view_NE_EncounterID, BC001T4_A592View_New_Encounter2view_NE_ENCType, BC001T4_n592View_New_Encounter2view_NE_ENCType, BC001T4_A593View_New_Encounter2view_NE_Departmentadm, BC001T4_n593View_New_Encounter2view_NE_Departmentadm, BC001T4_A594View_New_Encounter2view_NE_AdmitDate, BC001T4_n594View_New_Encounter2view_NE_AdmitDate, BC001T4_A595View_New_Encounter2view_NE_Status, BC001T4_n595View_New_Encounter2view_NE_Status, BC001T4_A596View_New_Encounter2view_NE_IsRandRecheck,
               BC001T4_n596View_New_Encounter2view_NE_IsRandRecheck, BC001T4_A597View_New_Encounter2view_NE_IsRandApprove, BC001T4_n597View_New_Encounter2view_NE_IsRandApprove, BC001T4_A598View_New_Encounter2view_NE_IsUpdate, BC001T4_n598View_New_Encounter2view_NE_IsUpdate, BC001T4_A599View_New_Encounter2view_NE_TenantTenantCode, BC001T4_n599View_New_Encounter2view_NE_TenantTenantCode, BC001T4_A600View_New_Encounter2view_NE_Information_ID, BC001T4_n600View_New_Encounter2view_NE_Information_ID, BC001T4_A601View_New_Encounter2view_NE_Information_PatientNo,
               BC001T4_n601View_New_Encounter2view_NE_Information_PatientNo
               }
               , new Object[] {
               BC001T5_A591View_New_Encounter2view_NE_EncounterID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC001T9_A591View_New_Encounter2view_NE_EncounterID, BC001T9_A592View_New_Encounter2view_NE_ENCType, BC001T9_n592View_New_Encounter2view_NE_ENCType, BC001T9_A593View_New_Encounter2view_NE_Departmentadm, BC001T9_n593View_New_Encounter2view_NE_Departmentadm, BC001T9_A594View_New_Encounter2view_NE_AdmitDate, BC001T9_n594View_New_Encounter2view_NE_AdmitDate, BC001T9_A595View_New_Encounter2view_NE_Status, BC001T9_n595View_New_Encounter2view_NE_Status, BC001T9_A596View_New_Encounter2view_NE_IsRandRecheck,
               BC001T9_n596View_New_Encounter2view_NE_IsRandRecheck, BC001T9_A597View_New_Encounter2view_NE_IsRandApprove, BC001T9_n597View_New_Encounter2view_NE_IsRandApprove, BC001T9_A598View_New_Encounter2view_NE_IsUpdate, BC001T9_n598View_New_Encounter2view_NE_IsUpdate, BC001T9_A599View_New_Encounter2view_NE_TenantTenantCode, BC001T9_n599View_New_Encounter2view_NE_TenantTenantCode, BC001T9_A600View_New_Encounter2view_NE_Information_ID, BC001T9_n600View_New_Encounter2view_NE_Information_ID, BC001T9_A601View_New_Encounter2view_NE_Information_PatientNo,
               BC001T9_n601View_New_Encounter2view_NE_Information_PatientNo
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
      private short Z595View_New_Encounter2view_NE_Status ;
      private short A595View_New_Encounter2view_NE_Status ;
      private short RcdFound75 ;
      private int trnEnded ;
      private long Z591View_New_Encounter2view_NE_EncounterID ;
      private long A591View_New_Encounter2view_NE_EncounterID ;
      private long Z600View_New_Encounter2view_NE_Information_ID ;
      private long A600View_New_Encounter2view_NE_Information_ID ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String sMode75 ;
      private DateTime Z594View_New_Encounter2view_NE_AdmitDate ;
      private DateTime A594View_New_Encounter2view_NE_AdmitDate ;
      private bool Z596View_New_Encounter2view_NE_IsRandRecheck ;
      private bool A596View_New_Encounter2view_NE_IsRandRecheck ;
      private bool Z597View_New_Encounter2view_NE_IsRandApprove ;
      private bool A597View_New_Encounter2view_NE_IsRandApprove ;
      private bool Z598View_New_Encounter2view_NE_IsUpdate ;
      private bool A598View_New_Encounter2view_NE_IsUpdate ;
      private bool n592View_New_Encounter2view_NE_ENCType ;
      private bool n593View_New_Encounter2view_NE_Departmentadm ;
      private bool n594View_New_Encounter2view_NE_AdmitDate ;
      private bool n595View_New_Encounter2view_NE_Status ;
      private bool n596View_New_Encounter2view_NE_IsRandRecheck ;
      private bool n597View_New_Encounter2view_NE_IsRandApprove ;
      private bool n598View_New_Encounter2view_NE_IsUpdate ;
      private bool n599View_New_Encounter2view_NE_TenantTenantCode ;
      private bool n600View_New_Encounter2view_NE_Information_ID ;
      private bool n601View_New_Encounter2view_NE_Information_PatientNo ;
      private bool Gx_longc ;
      private String Z592View_New_Encounter2view_NE_ENCType ;
      private String A592View_New_Encounter2view_NE_ENCType ;
      private String Z593View_New_Encounter2view_NE_Departmentadm ;
      private String A593View_New_Encounter2view_NE_Departmentadm ;
      private String Z599View_New_Encounter2view_NE_TenantTenantCode ;
      private String A599View_New_Encounter2view_NE_TenantTenantCode ;
      private String Z601View_New_Encounter2view_NE_Information_PatientNo ;
      private String A601View_New_Encounter2view_NE_Information_PatientNo ;
      private SdtView_New_Encounter2 bcView_New_Encounter2 ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] BC001T4_A591View_New_Encounter2view_NE_EncounterID ;
      private String[] BC001T4_A592View_New_Encounter2view_NE_ENCType ;
      private bool[] BC001T4_n592View_New_Encounter2view_NE_ENCType ;
      private String[] BC001T4_A593View_New_Encounter2view_NE_Departmentadm ;
      private bool[] BC001T4_n593View_New_Encounter2view_NE_Departmentadm ;
      private DateTime[] BC001T4_A594View_New_Encounter2view_NE_AdmitDate ;
      private bool[] BC001T4_n594View_New_Encounter2view_NE_AdmitDate ;
      private short[] BC001T4_A595View_New_Encounter2view_NE_Status ;
      private bool[] BC001T4_n595View_New_Encounter2view_NE_Status ;
      private bool[] BC001T4_A596View_New_Encounter2view_NE_IsRandRecheck ;
      private bool[] BC001T4_n596View_New_Encounter2view_NE_IsRandRecheck ;
      private bool[] BC001T4_A597View_New_Encounter2view_NE_IsRandApprove ;
      private bool[] BC001T4_n597View_New_Encounter2view_NE_IsRandApprove ;
      private bool[] BC001T4_A598View_New_Encounter2view_NE_IsUpdate ;
      private bool[] BC001T4_n598View_New_Encounter2view_NE_IsUpdate ;
      private String[] BC001T4_A599View_New_Encounter2view_NE_TenantTenantCode ;
      private bool[] BC001T4_n599View_New_Encounter2view_NE_TenantTenantCode ;
      private long[] BC001T4_A600View_New_Encounter2view_NE_Information_ID ;
      private bool[] BC001T4_n600View_New_Encounter2view_NE_Information_ID ;
      private String[] BC001T4_A601View_New_Encounter2view_NE_Information_PatientNo ;
      private bool[] BC001T4_n601View_New_Encounter2view_NE_Information_PatientNo ;
      private long[] BC001T5_A591View_New_Encounter2view_NE_EncounterID ;
      private long[] BC001T3_A591View_New_Encounter2view_NE_EncounterID ;
      private String[] BC001T3_A592View_New_Encounter2view_NE_ENCType ;
      private bool[] BC001T3_n592View_New_Encounter2view_NE_ENCType ;
      private String[] BC001T3_A593View_New_Encounter2view_NE_Departmentadm ;
      private bool[] BC001T3_n593View_New_Encounter2view_NE_Departmentadm ;
      private DateTime[] BC001T3_A594View_New_Encounter2view_NE_AdmitDate ;
      private bool[] BC001T3_n594View_New_Encounter2view_NE_AdmitDate ;
      private short[] BC001T3_A595View_New_Encounter2view_NE_Status ;
      private bool[] BC001T3_n595View_New_Encounter2view_NE_Status ;
      private bool[] BC001T3_A596View_New_Encounter2view_NE_IsRandRecheck ;
      private bool[] BC001T3_n596View_New_Encounter2view_NE_IsRandRecheck ;
      private bool[] BC001T3_A597View_New_Encounter2view_NE_IsRandApprove ;
      private bool[] BC001T3_n597View_New_Encounter2view_NE_IsRandApprove ;
      private bool[] BC001T3_A598View_New_Encounter2view_NE_IsUpdate ;
      private bool[] BC001T3_n598View_New_Encounter2view_NE_IsUpdate ;
      private String[] BC001T3_A599View_New_Encounter2view_NE_TenantTenantCode ;
      private bool[] BC001T3_n599View_New_Encounter2view_NE_TenantTenantCode ;
      private long[] BC001T3_A600View_New_Encounter2view_NE_Information_ID ;
      private bool[] BC001T3_n600View_New_Encounter2view_NE_Information_ID ;
      private String[] BC001T3_A601View_New_Encounter2view_NE_Information_PatientNo ;
      private bool[] BC001T3_n601View_New_Encounter2view_NE_Information_PatientNo ;
      private long[] BC001T2_A591View_New_Encounter2view_NE_EncounterID ;
      private String[] BC001T2_A592View_New_Encounter2view_NE_ENCType ;
      private bool[] BC001T2_n592View_New_Encounter2view_NE_ENCType ;
      private String[] BC001T2_A593View_New_Encounter2view_NE_Departmentadm ;
      private bool[] BC001T2_n593View_New_Encounter2view_NE_Departmentadm ;
      private DateTime[] BC001T2_A594View_New_Encounter2view_NE_AdmitDate ;
      private bool[] BC001T2_n594View_New_Encounter2view_NE_AdmitDate ;
      private short[] BC001T2_A595View_New_Encounter2view_NE_Status ;
      private bool[] BC001T2_n595View_New_Encounter2view_NE_Status ;
      private bool[] BC001T2_A596View_New_Encounter2view_NE_IsRandRecheck ;
      private bool[] BC001T2_n596View_New_Encounter2view_NE_IsRandRecheck ;
      private bool[] BC001T2_A597View_New_Encounter2view_NE_IsRandApprove ;
      private bool[] BC001T2_n597View_New_Encounter2view_NE_IsRandApprove ;
      private bool[] BC001T2_A598View_New_Encounter2view_NE_IsUpdate ;
      private bool[] BC001T2_n598View_New_Encounter2view_NE_IsUpdate ;
      private String[] BC001T2_A599View_New_Encounter2view_NE_TenantTenantCode ;
      private bool[] BC001T2_n599View_New_Encounter2view_NE_TenantTenantCode ;
      private long[] BC001T2_A600View_New_Encounter2view_NE_Information_ID ;
      private bool[] BC001T2_n600View_New_Encounter2view_NE_Information_ID ;
      private String[] BC001T2_A601View_New_Encounter2view_NE_Information_PatientNo ;
      private bool[] BC001T2_n601View_New_Encounter2view_NE_Information_PatientNo ;
      private long[] BC001T9_A591View_New_Encounter2view_NE_EncounterID ;
      private String[] BC001T9_A592View_New_Encounter2view_NE_ENCType ;
      private bool[] BC001T9_n592View_New_Encounter2view_NE_ENCType ;
      private String[] BC001T9_A593View_New_Encounter2view_NE_Departmentadm ;
      private bool[] BC001T9_n593View_New_Encounter2view_NE_Departmentadm ;
      private DateTime[] BC001T9_A594View_New_Encounter2view_NE_AdmitDate ;
      private bool[] BC001T9_n594View_New_Encounter2view_NE_AdmitDate ;
      private short[] BC001T9_A595View_New_Encounter2view_NE_Status ;
      private bool[] BC001T9_n595View_New_Encounter2view_NE_Status ;
      private bool[] BC001T9_A596View_New_Encounter2view_NE_IsRandRecheck ;
      private bool[] BC001T9_n596View_New_Encounter2view_NE_IsRandRecheck ;
      private bool[] BC001T9_A597View_New_Encounter2view_NE_IsRandApprove ;
      private bool[] BC001T9_n597View_New_Encounter2view_NE_IsRandApprove ;
      private bool[] BC001T9_A598View_New_Encounter2view_NE_IsUpdate ;
      private bool[] BC001T9_n598View_New_Encounter2view_NE_IsUpdate ;
      private String[] BC001T9_A599View_New_Encounter2view_NE_TenantTenantCode ;
      private bool[] BC001T9_n599View_New_Encounter2view_NE_TenantTenantCode ;
      private long[] BC001T9_A600View_New_Encounter2view_NE_Information_ID ;
      private bool[] BC001T9_n600View_New_Encounter2view_NE_Information_ID ;
      private String[] BC001T9_A601View_New_Encounter2view_NE_Information_PatientNo ;
      private bool[] BC001T9_n601View_New_Encounter2view_NE_Information_PatientNo ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_datastore1 ;
   }

   public class view_new_encounter2_bc__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class view_new_encounter2_bc__default : DataStoreHelperBase, IDataStoreHelper
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
        Object[] prmBC001T4 ;
        prmBC001T4 = new Object[] {
        new Object[] {"@View_New_Encounter2view_NE_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC001T5 ;
        prmBC001T5 = new Object[] {
        new Object[] {"@View_New_Encounter2view_NE_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC001T3 ;
        prmBC001T3 = new Object[] {
        new Object[] {"@View_New_Encounter2view_NE_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC001T2 ;
        prmBC001T2 = new Object[] {
        new Object[] {"@View_New_Encounter2view_NE_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC001T6 ;
        prmBC001T6 = new Object[] {
        new Object[] {"@View_New_Encounter2view_NE_EncounterID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@View_New_Encounter2view_NE_ENCType",SqlDbType.NVarChar,4000,0} ,
        new Object[] {"@View_New_Encounter2view_NE_Departmentadm",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@View_New_Encounter2view_NE_AdmitDate",SqlDbType.DateTime,8,0} ,
        new Object[] {"@View_New_Encounter2view_NE_Status",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@View_New_Encounter2view_NE_IsRandRecheck",SqlDbType.Bit,1,0} ,
        new Object[] {"@View_New_Encounter2view_NE_IsRandApprove",SqlDbType.Bit,1,0} ,
        new Object[] {"@View_New_Encounter2view_NE_IsUpdate",SqlDbType.Bit,1,0} ,
        new Object[] {"@View_New_Encounter2view_NE_TenantTenantCode",SqlDbType.NVarChar,20,0} ,
        new Object[] {"@View_New_Encounter2view_NE_Information_ID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@View_New_Encounter2view_NE_Information_PatientNo",SqlDbType.NVarChar,4000,0}
        } ;
        Object[] prmBC001T7 ;
        prmBC001T7 = new Object[] {
        new Object[] {"@View_New_Encounter2view_NE_ENCType",SqlDbType.NVarChar,4000,0} ,
        new Object[] {"@View_New_Encounter2view_NE_Departmentadm",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@View_New_Encounter2view_NE_AdmitDate",SqlDbType.DateTime,8,0} ,
        new Object[] {"@View_New_Encounter2view_NE_Status",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@View_New_Encounter2view_NE_IsRandRecheck",SqlDbType.Bit,1,0} ,
        new Object[] {"@View_New_Encounter2view_NE_IsRandApprove",SqlDbType.Bit,1,0} ,
        new Object[] {"@View_New_Encounter2view_NE_IsUpdate",SqlDbType.Bit,1,0} ,
        new Object[] {"@View_New_Encounter2view_NE_TenantTenantCode",SqlDbType.NVarChar,20,0} ,
        new Object[] {"@View_New_Encounter2view_NE_Information_ID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@View_New_Encounter2view_NE_Information_PatientNo",SqlDbType.NVarChar,4000,0} ,
        new Object[] {"@View_New_Encounter2view_NE_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC001T8 ;
        prmBC001T8 = new Object[] {
        new Object[] {"@View_New_Encounter2view_NE_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC001T9 ;
        prmBC001T9 = new Object[] {
        new Object[] {"@View_New_Encounter2view_NE_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("BC001T2", "SELECT [View_New_Encounter2view_NE_EncounterID], [View_New_Encounter2view_NE_ENCType], [View_New_Encounter2view_NE_Departmentadm], [View_New_Encounter2view_NE_AdmitDate], [View_New_Encounter2view_NE_Status], [View_New_Encounter2view_NE_IsRandRecheck], [View_New_Encounter2view_NE_IsRandApprove], [View_New_Encounter2view_NE_IsUpdate], [View_New_Encounter2view_NE_TenantTenantCode], [View_New_Encounter2view_NE_Information_ID], [View_New_Encounter2view_NE_Information_PatientNo] FROM [View_New_Encounter] WITH (UPDLOCK) WHERE [View_New_Encounter2view_NE_EncounterID] = @View_New_Encounter2view_NE_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001T2,1,0,true,false )
           ,new CursorDef("BC001T3", "SELECT [View_New_Encounter2view_NE_EncounterID], [View_New_Encounter2view_NE_ENCType], [View_New_Encounter2view_NE_Departmentadm], [View_New_Encounter2view_NE_AdmitDate], [View_New_Encounter2view_NE_Status], [View_New_Encounter2view_NE_IsRandRecheck], [View_New_Encounter2view_NE_IsRandApprove], [View_New_Encounter2view_NE_IsUpdate], [View_New_Encounter2view_NE_TenantTenantCode], [View_New_Encounter2view_NE_Information_ID], [View_New_Encounter2view_NE_Information_PatientNo] FROM [View_New_Encounter] WITH (NOLOCK) WHERE [View_New_Encounter2view_NE_EncounterID] = @View_New_Encounter2view_NE_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001T3,1,0,true,false )
           ,new CursorDef("BC001T4", "SELECT TM1.[View_New_Encounter2view_NE_EncounterID], TM1.[View_New_Encounter2view_NE_ENCType], TM1.[View_New_Encounter2view_NE_Departmentadm], TM1.[View_New_Encounter2view_NE_AdmitDate], TM1.[View_New_Encounter2view_NE_Status], TM1.[View_New_Encounter2view_NE_IsRandRecheck], TM1.[View_New_Encounter2view_NE_IsRandApprove], TM1.[View_New_Encounter2view_NE_IsUpdate], TM1.[View_New_Encounter2view_NE_TenantTenantCode], TM1.[View_New_Encounter2view_NE_Information_ID], TM1.[View_New_Encounter2view_NE_Information_PatientNo] FROM [View_New_Encounter] TM1 WITH (NOLOCK) WHERE TM1.[View_New_Encounter2view_NE_EncounterID] = @View_New_Encounter2view_NE_EncounterID ORDER BY TM1.[View_New_Encounter2view_NE_EncounterID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001T4,100,0,true,false )
           ,new CursorDef("BC001T5", "SELECT [View_New_Encounter2view_NE_EncounterID] FROM [View_New_Encounter] WITH (NOLOCK) WHERE [View_New_Encounter2view_NE_EncounterID] = @View_New_Encounter2view_NE_EncounterID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001T5,1,0,true,false )
           ,new CursorDef("BC001T6", "INSERT INTO [View_New_Encounter]([View_New_Encounter2view_NE_EncounterID], [View_New_Encounter2view_NE_ENCType], [View_New_Encounter2view_NE_Departmentadm], [View_New_Encounter2view_NE_AdmitDate], [View_New_Encounter2view_NE_Status], [View_New_Encounter2view_NE_IsRandRecheck], [View_New_Encounter2view_NE_IsRandApprove], [View_New_Encounter2view_NE_IsUpdate], [View_New_Encounter2view_NE_TenantTenantCode], [View_New_Encounter2view_NE_Information_ID], [View_New_Encounter2view_NE_Information_PatientNo]) VALUES(@View_New_Encounter2view_NE_EncounterID, @View_New_Encounter2view_NE_ENCType, @View_New_Encounter2view_NE_Departmentadm, @View_New_Encounter2view_NE_AdmitDate, @View_New_Encounter2view_NE_Status, @View_New_Encounter2view_NE_IsRandRecheck, @View_New_Encounter2view_NE_IsRandApprove, @View_New_Encounter2view_NE_IsUpdate, @View_New_Encounter2view_NE_TenantTenantCode, @View_New_Encounter2view_NE_Information_ID, @View_New_Encounter2view_NE_Information_PatientNo)", GxErrorMask.GX_NOMASK,prmBC001T6)
           ,new CursorDef("BC001T7", "UPDATE [View_New_Encounter] SET [View_New_Encounter2view_NE_ENCType]=@View_New_Encounter2view_NE_ENCType, [View_New_Encounter2view_NE_Departmentadm]=@View_New_Encounter2view_NE_Departmentadm, [View_New_Encounter2view_NE_AdmitDate]=@View_New_Encounter2view_NE_AdmitDate, [View_New_Encounter2view_NE_Status]=@View_New_Encounter2view_NE_Status, [View_New_Encounter2view_NE_IsRandRecheck]=@View_New_Encounter2view_NE_IsRandRecheck, [View_New_Encounter2view_NE_IsRandApprove]=@View_New_Encounter2view_NE_IsRandApprove, [View_New_Encounter2view_NE_IsUpdate]=@View_New_Encounter2view_NE_IsUpdate, [View_New_Encounter2view_NE_TenantTenantCode]=@View_New_Encounter2view_NE_TenantTenantCode, [View_New_Encounter2view_NE_Information_ID]=@View_New_Encounter2view_NE_Information_ID, [View_New_Encounter2view_NE_Information_PatientNo]=@View_New_Encounter2view_NE_Information_PatientNo  WHERE [View_New_Encounter2view_NE_EncounterID] = @View_New_Encounter2view_NE_EncounterID", GxErrorMask.GX_NOMASK,prmBC001T7)
           ,new CursorDef("BC001T8", "DELETE FROM [View_New_Encounter]  WHERE [View_New_Encounter2view_NE_EncounterID] = @View_New_Encounter2view_NE_EncounterID", GxErrorMask.GX_NOMASK,prmBC001T8)
           ,new CursorDef("BC001T9", "SELECT TM1.[View_New_Encounter2view_NE_EncounterID], TM1.[View_New_Encounter2view_NE_ENCType], TM1.[View_New_Encounter2view_NE_Departmentadm], TM1.[View_New_Encounter2view_NE_AdmitDate], TM1.[View_New_Encounter2view_NE_Status], TM1.[View_New_Encounter2view_NE_IsRandRecheck], TM1.[View_New_Encounter2view_NE_IsRandApprove], TM1.[View_New_Encounter2view_NE_IsUpdate], TM1.[View_New_Encounter2view_NE_TenantTenantCode], TM1.[View_New_Encounter2view_NE_Information_ID], TM1.[View_New_Encounter2view_NE_Information_PatientNo] FROM [View_New_Encounter] TM1 WITH (NOLOCK) WHERE TM1.[View_New_Encounter2view_NE_EncounterID] = @View_New_Encounter2view_NE_EncounterID ORDER BY TM1.[View_New_Encounter2view_NE_EncounterID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001T9,100,0,true,false )
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
