/*
               File: BR_Procedure_BC
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:58:4.95
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
   public class br_procedure_bc : GXHttpHandler, IGxSilentTrn
   {
      public br_procedure_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_procedure_bc( IGxContext context )
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
         ReadRow0I19( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey0I19( ) ;
         standaloneModal( ) ;
         AddRow0I19( ) ;
         Gx_mode = "INS";
         return  ;
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E110I2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               Z139BR_ProcedureID = A139BR_ProcedureID;
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

      protected void CONFIRM_0I0( )
      {
         BeforeValidate0I19( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0I19( ) ;
            }
            else
            {
               CheckExtendedTable0I19( ) ;
               if ( AnyError == 0 )
               {
                  ZM0I19( 23) ;
                  ZM0I19( 24) ;
               }
               CloseExtendedTableCursors0I19( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void E120I2( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV7WWPContext) ;
         AV13IsAuthorized = true;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            GXt_boolean1 = AV13IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Procedure", out  GXt_boolean1) ;
            AV13IsAuthorized = GXt_boolean1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            GXt_boolean1 = AV13IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Procedure", out  GXt_boolean1) ;
            AV13IsAuthorized = GXt_boolean1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            GXt_boolean1 = AV13IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Procedure", out  GXt_boolean1) ;
            AV13IsAuthorized = GXt_boolean1;
         }
         if ( ! AV13IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV20Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         /* Execute user subroutine: 'ATTRIBUTESSECURITYCODE' */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         AV8TrnContext.FromXml(AV9WebSession.Get("TrnContext"), null, "WWPTransactionContext", "DataAnalysisPlatform");
         if ( ( StringUtil.StrCmp(AV8TrnContext.gxTpr_Transactionname, AV20Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV21GXV1 = 1;
            while ( AV21GXV1 <= AV8TrnContext.gxTpr_Attributes.Count )
            {
               AV11TrnContextAtt = ((GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute)AV8TrnContext.gxTpr_Attributes.Item(AV21GXV1));
               if ( StringUtil.StrCmp(AV11TrnContextAtt.gxTpr_Attributename, "BR_EncounterID") == 0 )
               {
                  AV10Insert_BR_EncounterID = (long)(NumberUtil.Val( AV11TrnContextAtt.gxTpr_Attributevalue, "."));
               }
               AV21GXV1 = (int)(AV21GXV1+1);
            }
         }
      }

      protected void E110I2( )
      {
         /* After Trn Routine */
      }

      protected void S112( )
      {
         /* 'ATTRIBUTESSECURITYCODE' Routine */
      }

      protected void ZM0I19( short GX_JID )
      {
         if ( ( GX_JID == 22 ) || ( GX_JID == 0 ) )
         {
            Z497BR_Procedure_PXSurgery_Code = A497BR_Procedure_PXSurgery_Code;
            Z498BR_Procedure_PXRadiotherapy_Code = A498BR_Procedure_PXRadiotherapy_Code;
            Z140BR_Procedure_PXID = A140BR_Procedure_PXID;
            Z141BR_Procedure_PXSurgery = A141BR_Procedure_PXSurgery;
            Z266BR_Procedure_Date = A266BR_Procedure_Date;
            Z143BR_Procedure_PXRadiotherapy = A143BR_Procedure_PXRadiotherapy;
            Z268BR_Procedure_RadioDate = A268BR_Procedure_RadioDate;
            Z269BR_Procedure_RadioTime = A269BR_Procedure_RadioTime;
            Z19BR_EncounterID = A19BR_EncounterID;
         }
         if ( ( GX_JID == 23 ) || ( GX_JID == 0 ) )
         {
            Z85BR_Information_ID = A85BR_Information_ID;
         }
         if ( ( GX_JID == 24 ) || ( GX_JID == 0 ) )
         {
            Z36BR_Information_PatientNo = A36BR_Information_PatientNo;
         }
         if ( GX_JID == -22 )
         {
            Z139BR_ProcedureID = A139BR_ProcedureID;
            Z497BR_Procedure_PXSurgery_Code = A497BR_Procedure_PXSurgery_Code;
            Z498BR_Procedure_PXRadiotherapy_Code = A498BR_Procedure_PXRadiotherapy_Code;
            Z140BR_Procedure_PXID = A140BR_Procedure_PXID;
            Z141BR_Procedure_PXSurgery = A141BR_Procedure_PXSurgery;
            Z266BR_Procedure_Date = A266BR_Procedure_Date;
            Z143BR_Procedure_PXRadiotherapy = A143BR_Procedure_PXRadiotherapy;
            Z268BR_Procedure_RadioDate = A268BR_Procedure_RadioDate;
            Z269BR_Procedure_RadioTime = A269BR_Procedure_RadioTime;
            Z19BR_EncounterID = A19BR_EncounterID;
            Z85BR_Information_ID = A85BR_Information_ID;
            Z36BR_Information_PatientNo = A36BR_Information_PatientNo;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load0I19( )
      {
         /* Using cursor BC000I6 */
         pr_default.execute(4, new Object[] {A139BR_ProcedureID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound19 = 1;
            A85BR_Information_ID = BC000I6_A85BR_Information_ID[0];
            n85BR_Information_ID = BC000I6_n85BR_Information_ID[0];
            A497BR_Procedure_PXSurgery_Code = BC000I6_A497BR_Procedure_PXSurgery_Code[0];
            n497BR_Procedure_PXSurgery_Code = BC000I6_n497BR_Procedure_PXSurgery_Code[0];
            A498BR_Procedure_PXRadiotherapy_Code = BC000I6_A498BR_Procedure_PXRadiotherapy_Code[0];
            n498BR_Procedure_PXRadiotherapy_Code = BC000I6_n498BR_Procedure_PXRadiotherapy_Code[0];
            A36BR_Information_PatientNo = BC000I6_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = BC000I6_n36BR_Information_PatientNo[0];
            A140BR_Procedure_PXID = BC000I6_A140BR_Procedure_PXID[0];
            n140BR_Procedure_PXID = BC000I6_n140BR_Procedure_PXID[0];
            A141BR_Procedure_PXSurgery = BC000I6_A141BR_Procedure_PXSurgery[0];
            n141BR_Procedure_PXSurgery = BC000I6_n141BR_Procedure_PXSurgery[0];
            A266BR_Procedure_Date = BC000I6_A266BR_Procedure_Date[0];
            n266BR_Procedure_Date = BC000I6_n266BR_Procedure_Date[0];
            A143BR_Procedure_PXRadiotherapy = BC000I6_A143BR_Procedure_PXRadiotherapy[0];
            n143BR_Procedure_PXRadiotherapy = BC000I6_n143BR_Procedure_PXRadiotherapy[0];
            A268BR_Procedure_RadioDate = BC000I6_A268BR_Procedure_RadioDate[0];
            n268BR_Procedure_RadioDate = BC000I6_n268BR_Procedure_RadioDate[0];
            A269BR_Procedure_RadioTime = BC000I6_A269BR_Procedure_RadioTime[0];
            n269BR_Procedure_RadioTime = BC000I6_n269BR_Procedure_RadioTime[0];
            A19BR_EncounterID = BC000I6_A19BR_EncounterID[0];
            n19BR_EncounterID = BC000I6_n19BR_EncounterID[0];
            ZM0I19( -22) ;
         }
         pr_default.close(4);
         OnLoadActions0I19( ) ;
      }

      protected void OnLoadActions0I19( )
      {
         AV20Pgmname = "BR_Procedure_BC";
      }

      protected void CheckExtendedTable0I19( )
      {
         standaloneModal( ) ;
         AV20Pgmname = "BR_Procedure_BC";
         /* Using cursor BC000I4 */
         pr_default.execute(2, new Object[] {n19BR_EncounterID, A19BR_EncounterID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            if ( ! ( (0==A19BR_EncounterID) ) )
            {
               GX_msglist.addItem("不匹配' T15'", "ForeignKeyNotFound", 1, "BR_ENCOUNTERID");
               AnyError = 1;
            }
         }
         A85BR_Information_ID = BC000I4_A85BR_Information_ID[0];
         n85BR_Information_ID = BC000I4_n85BR_Information_ID[0];
         pr_default.close(2);
         /* Using cursor BC000I5 */
         pr_default.execute(3, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
         if ( (pr_default.getStatus(3) == 101) )
         {
            if ( ! ( (0==A85BR_Information_ID) ) )
            {
               GX_msglist.addItem("不匹配' T16'", "ForeignKeyNotFound", 1, "");
               AnyError = 1;
            }
         }
         A36BR_Information_PatientNo = BC000I5_A36BR_Information_PatientNo[0];
         n36BR_Information_PatientNo = BC000I5_n36BR_Information_PatientNo[0];
         pr_default.close(3);
         if ( ! ( ( StringUtil.StrCmp(A141BR_Procedure_PXSurgery, "否") == 0 ) || ( StringUtil.StrCmp(A141BR_Procedure_PXSurgery, "是") == 0 ) || ( StringUtil.StrCmp(A141BR_Procedure_PXSurgery, "不详") == 0 ) || String.IsNullOrEmpty(StringUtil.RTrim( A141BR_Procedure_PXSurgery)) ) )
         {
            GX_msglist.addItem("域������������超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A141BR_Procedure_PXSurgery)) )
         {
            GX_msglist.addItem("是否手术是必须填写的。", 1, "");
            AnyError = 1;
         }
         if ( ! ( (DateTime.MinValue==A266BR_Procedure_Date) || ( A266BR_Procedure_Date >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("域������������超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
         if ( ! ( ( StringUtil.StrCmp(A143BR_Procedure_PXRadiotherapy, "否") == 0 ) || ( StringUtil.StrCmp(A143BR_Procedure_PXRadiotherapy, "是") == 0 ) || ( StringUtil.StrCmp(A143BR_Procedure_PXRadiotherapy, "不详") == 0 ) || String.IsNullOrEmpty(StringUtil.RTrim( A143BR_Procedure_PXRadiotherapy)) ) )
         {
            GX_msglist.addItem("域������������������������超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A143BR_Procedure_PXRadiotherapy)) )
         {
            GX_msglist.addItem("是否接受放射疗法是必须填写的。", 1, "");
            AnyError = 1;
         }
         if ( ! ( (DateTime.MinValue==A268BR_Procedure_RadioDate) || ( A268BR_Procedure_RadioDate >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("域������������超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
      }

      protected void CloseExtendedTableCursors0I19( )
      {
         pr_default.close(2);
         pr_default.close(3);
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0I19( )
      {
         /* Using cursor BC000I7 */
         pr_default.execute(5, new Object[] {A139BR_ProcedureID});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound19 = 1;
         }
         else
         {
            RcdFound19 = 0;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC000I3 */
         pr_default.execute(1, new Object[] {A139BR_ProcedureID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0I19( 22) ;
            RcdFound19 = 1;
            A139BR_ProcedureID = BC000I3_A139BR_ProcedureID[0];
            A497BR_Procedure_PXSurgery_Code = BC000I3_A497BR_Procedure_PXSurgery_Code[0];
            n497BR_Procedure_PXSurgery_Code = BC000I3_n497BR_Procedure_PXSurgery_Code[0];
            A498BR_Procedure_PXRadiotherapy_Code = BC000I3_A498BR_Procedure_PXRadiotherapy_Code[0];
            n498BR_Procedure_PXRadiotherapy_Code = BC000I3_n498BR_Procedure_PXRadiotherapy_Code[0];
            A140BR_Procedure_PXID = BC000I3_A140BR_Procedure_PXID[0];
            n140BR_Procedure_PXID = BC000I3_n140BR_Procedure_PXID[0];
            A141BR_Procedure_PXSurgery = BC000I3_A141BR_Procedure_PXSurgery[0];
            n141BR_Procedure_PXSurgery = BC000I3_n141BR_Procedure_PXSurgery[0];
            A266BR_Procedure_Date = BC000I3_A266BR_Procedure_Date[0];
            n266BR_Procedure_Date = BC000I3_n266BR_Procedure_Date[0];
            A143BR_Procedure_PXRadiotherapy = BC000I3_A143BR_Procedure_PXRadiotherapy[0];
            n143BR_Procedure_PXRadiotherapy = BC000I3_n143BR_Procedure_PXRadiotherapy[0];
            A268BR_Procedure_RadioDate = BC000I3_A268BR_Procedure_RadioDate[0];
            n268BR_Procedure_RadioDate = BC000I3_n268BR_Procedure_RadioDate[0];
            A269BR_Procedure_RadioTime = BC000I3_A269BR_Procedure_RadioTime[0];
            n269BR_Procedure_RadioTime = BC000I3_n269BR_Procedure_RadioTime[0];
            A19BR_EncounterID = BC000I3_A19BR_EncounterID[0];
            n19BR_EncounterID = BC000I3_n19BR_EncounterID[0];
            Z139BR_ProcedureID = A139BR_ProcedureID;
            sMode19 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load0I19( ) ;
            if ( AnyError == 1 )
            {
               RcdFound19 = 0;
               InitializeNonKey0I19( ) ;
            }
            Gx_mode = sMode19;
         }
         else
         {
            RcdFound19 = 0;
            InitializeNonKey0I19( ) ;
            sMode19 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode19;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0I19( ) ;
         if ( RcdFound19 == 0 )
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
         CONFIRM_0I0( ) ;
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

      protected void CheckOptimisticConcurrency0I19( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC000I2 */
            pr_default.execute(0, new Object[] {A139BR_ProcedureID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Procedure"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z497BR_Procedure_PXSurgery_Code, BC000I2_A497BR_Procedure_PXSurgery_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z498BR_Procedure_PXRadiotherapy_Code, BC000I2_A498BR_Procedure_PXRadiotherapy_Code[0]) != 0 ) || ( Z140BR_Procedure_PXID != BC000I2_A140BR_Procedure_PXID[0] ) || ( StringUtil.StrCmp(Z141BR_Procedure_PXSurgery, BC000I2_A141BR_Procedure_PXSurgery[0]) != 0 ) || ( Z266BR_Procedure_Date != BC000I2_A266BR_Procedure_Date[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z143BR_Procedure_PXRadiotherapy, BC000I2_A143BR_Procedure_PXRadiotherapy[0]) != 0 ) || ( Z268BR_Procedure_RadioDate != BC000I2_A268BR_Procedure_RadioDate[0] ) || ( Z269BR_Procedure_RadioTime != BC000I2_A269BR_Procedure_RadioTime[0] ) || ( Z19BR_EncounterID != BC000I2_A19BR_EncounterID[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"BR_Procedure"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0I19( )
      {
         BeforeValidate0I19( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0I19( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0I19( 0) ;
            CheckOptimisticConcurrency0I19( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0I19( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0I19( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000I8 */
                     pr_default.execute(6, new Object[] {n497BR_Procedure_PXSurgery_Code, A497BR_Procedure_PXSurgery_Code, n498BR_Procedure_PXRadiotherapy_Code, A498BR_Procedure_PXRadiotherapy_Code, n140BR_Procedure_PXID, A140BR_Procedure_PXID, n141BR_Procedure_PXSurgery, A141BR_Procedure_PXSurgery, n266BR_Procedure_Date, A266BR_Procedure_Date, n143BR_Procedure_PXRadiotherapy, A143BR_Procedure_PXRadiotherapy, n268BR_Procedure_RadioDate, A268BR_Procedure_RadioDate, n269BR_Procedure_RadioTime, A269BR_Procedure_RadioTime, n19BR_EncounterID, A19BR_EncounterID});
                     A139BR_ProcedureID = BC000I8_A139BR_ProcedureID[0];
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Procedure") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(A139BR_ProcedureID), 18, 0)),  "诊疗处理",  "Create",  1) ;
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
               Load0I19( ) ;
            }
            EndLevel0I19( ) ;
         }
         CloseExtendedTableCursors0I19( ) ;
      }

      protected void Update0I19( )
      {
         BeforeValidate0I19( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0I19( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0I19( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0I19( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0I19( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000I9 */
                     pr_default.execute(7, new Object[] {n497BR_Procedure_PXSurgery_Code, A497BR_Procedure_PXSurgery_Code, n498BR_Procedure_PXRadiotherapy_Code, A498BR_Procedure_PXRadiotherapy_Code, n140BR_Procedure_PXID, A140BR_Procedure_PXID, n141BR_Procedure_PXSurgery, A141BR_Procedure_PXSurgery, n266BR_Procedure_Date, A266BR_Procedure_Date, n143BR_Procedure_PXRadiotherapy, A143BR_Procedure_PXRadiotherapy, n268BR_Procedure_RadioDate, A268BR_Procedure_RadioDate, n269BR_Procedure_RadioTime, A269BR_Procedure_RadioTime, n19BR_EncounterID, A19BR_EncounterID, A139BR_ProcedureID});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Procedure") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Procedure"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0I19( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(A139BR_ProcedureID), 18, 0)),  "诊疗处理",  "Update",  1) ;
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
            EndLevel0I19( ) ;
         }
         CloseExtendedTableCursors0I19( ) ;
      }

      protected void DeferredUpdate0I19( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate0I19( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0I19( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0I19( ) ;
            AfterConfirm0I19( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0I19( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC000I10 */
                  pr_default.execute(8, new Object[] {A139BR_ProcedureID});
                  pr_default.close(8);
                  dsDefault.SmartCacheProvider.SetUpdated("BR_Procedure") ;
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
         sMode19 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel0I19( ) ;
         Gx_mode = sMode19;
      }

      protected void OnDeleteControls0I19( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV20Pgmname = "BR_Procedure_BC";
            /* Using cursor BC000I11 */
            pr_default.execute(9, new Object[] {n19BR_EncounterID, A19BR_EncounterID});
            A85BR_Information_ID = BC000I11_A85BR_Information_ID[0];
            n85BR_Information_ID = BC000I11_n85BR_Information_ID[0];
            pr_default.close(9);
            /* Using cursor BC000I12 */
            pr_default.execute(10, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
            A36BR_Information_PatientNo = BC000I12_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = BC000I12_n36BR_Information_PatientNo[0];
            pr_default.close(10);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor BC000I13 */
            pr_default.execute(11, new Object[] {A139BR_ProcedureID});
            if ( (pr_default.getStatus(11) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {" T38"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(11);
            /* Using cursor BC000I14 */
            pr_default.execute(12, new Object[] {A139BR_ProcedureID});
            if ( (pr_default.getStatus(12) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {" T37"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(12);
         }
      }

      protected void EndLevel0I19( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0I19( ) ;
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

      public void ScanKeyStart0I19( )
      {
         /* Scan By routine */
         /* Using cursor BC000I15 */
         pr_default.execute(13, new Object[] {A139BR_ProcedureID});
         RcdFound19 = 0;
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound19 = 1;
            A85BR_Information_ID = BC000I15_A85BR_Information_ID[0];
            n85BR_Information_ID = BC000I15_n85BR_Information_ID[0];
            A139BR_ProcedureID = BC000I15_A139BR_ProcedureID[0];
            A497BR_Procedure_PXSurgery_Code = BC000I15_A497BR_Procedure_PXSurgery_Code[0];
            n497BR_Procedure_PXSurgery_Code = BC000I15_n497BR_Procedure_PXSurgery_Code[0];
            A498BR_Procedure_PXRadiotherapy_Code = BC000I15_A498BR_Procedure_PXRadiotherapy_Code[0];
            n498BR_Procedure_PXRadiotherapy_Code = BC000I15_n498BR_Procedure_PXRadiotherapy_Code[0];
            A36BR_Information_PatientNo = BC000I15_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = BC000I15_n36BR_Information_PatientNo[0];
            A140BR_Procedure_PXID = BC000I15_A140BR_Procedure_PXID[0];
            n140BR_Procedure_PXID = BC000I15_n140BR_Procedure_PXID[0];
            A141BR_Procedure_PXSurgery = BC000I15_A141BR_Procedure_PXSurgery[0];
            n141BR_Procedure_PXSurgery = BC000I15_n141BR_Procedure_PXSurgery[0];
            A266BR_Procedure_Date = BC000I15_A266BR_Procedure_Date[0];
            n266BR_Procedure_Date = BC000I15_n266BR_Procedure_Date[0];
            A143BR_Procedure_PXRadiotherapy = BC000I15_A143BR_Procedure_PXRadiotherapy[0];
            n143BR_Procedure_PXRadiotherapy = BC000I15_n143BR_Procedure_PXRadiotherapy[0];
            A268BR_Procedure_RadioDate = BC000I15_A268BR_Procedure_RadioDate[0];
            n268BR_Procedure_RadioDate = BC000I15_n268BR_Procedure_RadioDate[0];
            A269BR_Procedure_RadioTime = BC000I15_A269BR_Procedure_RadioTime[0];
            n269BR_Procedure_RadioTime = BC000I15_n269BR_Procedure_RadioTime[0];
            A19BR_EncounterID = BC000I15_A19BR_EncounterID[0];
            n19BR_EncounterID = BC000I15_n19BR_EncounterID[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext0I19( )
      {
         /* Scan next routine */
         pr_default.readNext(13);
         RcdFound19 = 0;
         ScanKeyLoad0I19( ) ;
      }

      protected void ScanKeyLoad0I19( )
      {
         sMode19 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound19 = 1;
            A85BR_Information_ID = BC000I15_A85BR_Information_ID[0];
            n85BR_Information_ID = BC000I15_n85BR_Information_ID[0];
            A139BR_ProcedureID = BC000I15_A139BR_ProcedureID[0];
            A497BR_Procedure_PXSurgery_Code = BC000I15_A497BR_Procedure_PXSurgery_Code[0];
            n497BR_Procedure_PXSurgery_Code = BC000I15_n497BR_Procedure_PXSurgery_Code[0];
            A498BR_Procedure_PXRadiotherapy_Code = BC000I15_A498BR_Procedure_PXRadiotherapy_Code[0];
            n498BR_Procedure_PXRadiotherapy_Code = BC000I15_n498BR_Procedure_PXRadiotherapy_Code[0];
            A36BR_Information_PatientNo = BC000I15_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = BC000I15_n36BR_Information_PatientNo[0];
            A140BR_Procedure_PXID = BC000I15_A140BR_Procedure_PXID[0];
            n140BR_Procedure_PXID = BC000I15_n140BR_Procedure_PXID[0];
            A141BR_Procedure_PXSurgery = BC000I15_A141BR_Procedure_PXSurgery[0];
            n141BR_Procedure_PXSurgery = BC000I15_n141BR_Procedure_PXSurgery[0];
            A266BR_Procedure_Date = BC000I15_A266BR_Procedure_Date[0];
            n266BR_Procedure_Date = BC000I15_n266BR_Procedure_Date[0];
            A143BR_Procedure_PXRadiotherapy = BC000I15_A143BR_Procedure_PXRadiotherapy[0];
            n143BR_Procedure_PXRadiotherapy = BC000I15_n143BR_Procedure_PXRadiotherapy[0];
            A268BR_Procedure_RadioDate = BC000I15_A268BR_Procedure_RadioDate[0];
            n268BR_Procedure_RadioDate = BC000I15_n268BR_Procedure_RadioDate[0];
            A269BR_Procedure_RadioTime = BC000I15_A269BR_Procedure_RadioTime[0];
            n269BR_Procedure_RadioTime = BC000I15_n269BR_Procedure_RadioTime[0];
            A19BR_EncounterID = BC000I15_A19BR_EncounterID[0];
            n19BR_EncounterID = BC000I15_n19BR_EncounterID[0];
         }
         Gx_mode = sMode19;
      }

      protected void ScanKeyEnd0I19( )
      {
         pr_default.close(13);
      }

      protected void AfterConfirm0I19( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0I19( )
      {
         /* Before Insert Rules */
         GXt_char2 = A497BR_Procedure_PXSurgery_Code;
         new zutil_findtargetcode(context ).execute(  37,  A141BR_Procedure_PXSurgery, out  GXt_char2) ;
         A497BR_Procedure_PXSurgery_Code = GXt_char2;
         n497BR_Procedure_PXSurgery_Code = false;
         GXt_char2 = A498BR_Procedure_PXRadiotherapy_Code;
         new zutil_findtargetcode(context ).execute(  37,  A143BR_Procedure_PXRadiotherapy, out  GXt_char2) ;
         A498BR_Procedure_PXRadiotherapy_Code = GXt_char2;
         n498BR_Procedure_PXRadiotherapy_Code = false;
      }

      protected void BeforeUpdate0I19( )
      {
         /* Before Update Rules */
         if ( StringUtil.StrCmp(A141BR_Procedure_PXSurgery, "否") == 0 )
         {
            A266BR_Procedure_Date = DateTime.MinValue;
            n266BR_Procedure_Date = false;
            n266BR_Procedure_Date = false;
         }
         else
         {
            if ( StringUtil.StrCmp(A141BR_Procedure_PXSurgery, "不详") == 0 )
            {
               A266BR_Procedure_Date = DateTime.MinValue;
               n266BR_Procedure_Date = false;
               n266BR_Procedure_Date = false;
            }
         }
         GXt_char2 = A497BR_Procedure_PXSurgery_Code;
         new zutil_findtargetcode(context ).execute(  37,  A141BR_Procedure_PXSurgery, out  GXt_char2) ;
         A497BR_Procedure_PXSurgery_Code = GXt_char2;
         n497BR_Procedure_PXSurgery_Code = false;
         if ( StringUtil.StrCmp(A141BR_Procedure_PXSurgery, "否") == 0 )
         {
            new zbr_deleteproceduresurgery(context ).execute( ) ;
         }
         if ( StringUtil.StrCmp(A141BR_Procedure_PXSurgery, "不详") == 0 )
         {
            new zbr_deleteproceduresurgery(context ).execute( ) ;
         }
         if ( StringUtil.StrCmp(A143BR_Procedure_PXRadiotherapy, "否") == 0 )
         {
            A268BR_Procedure_RadioDate = DateTime.MinValue;
            n268BR_Procedure_RadioDate = false;
            n268BR_Procedure_RadioDate = false;
         }
         else
         {
            if ( StringUtil.StrCmp(A143BR_Procedure_PXRadiotherapy, "不详") == 0 )
            {
               A268BR_Procedure_RadioDate = DateTime.MinValue;
               n268BR_Procedure_RadioDate = false;
               n268BR_Procedure_RadioDate = false;
            }
         }
         if ( StringUtil.StrCmp(A143BR_Procedure_PXRadiotherapy, "否") == 0 )
         {
            A269BR_Procedure_RadioTime = 0;
            n269BR_Procedure_RadioTime = false;
            n269BR_Procedure_RadioTime = false;
         }
         else
         {
            if ( StringUtil.StrCmp(A143BR_Procedure_PXRadiotherapy, "不详") == 0 )
            {
               A269BR_Procedure_RadioTime = 0;
               n269BR_Procedure_RadioTime = false;
               n269BR_Procedure_RadioTime = false;
            }
         }
         GXt_char2 = A498BR_Procedure_PXRadiotherapy_Code;
         new zutil_findtargetcode(context ).execute(  37,  A143BR_Procedure_PXRadiotherapy, out  GXt_char2) ;
         A498BR_Procedure_PXRadiotherapy_Code = GXt_char2;
         n498BR_Procedure_PXRadiotherapy_Code = false;
         if ( StringUtil.StrCmp(A143BR_Procedure_PXRadiotherapy, "否") == 0 )
         {
            new zbr_deleteprocedureradio(context ).execute( ) ;
         }
         if ( StringUtil.StrCmp(A143BR_Procedure_PXRadiotherapy, "不详") == 0 )
         {
            new zbr_deleteprocedureradio(context ).execute( ) ;
         }
      }

      protected void BeforeDelete0I19( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0I19( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0I19( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0I19( )
      {
      }

      protected void send_integrity_lvl_hashes0I19( )
      {
      }

      protected void AddRow0I19( )
      {
         VarsToRow19( bcBR_Procedure) ;
      }

      protected void ReadRow0I19( )
      {
         RowToVars19( bcBR_Procedure, 1) ;
      }

      protected void InitializeNonKey0I19( )
      {
         A85BR_Information_ID = 0;
         n85BR_Information_ID = false;
         A497BR_Procedure_PXSurgery_Code = "";
         n497BR_Procedure_PXSurgery_Code = false;
         A498BR_Procedure_PXRadiotherapy_Code = "";
         n498BR_Procedure_PXRadiotherapy_Code = false;
         A19BR_EncounterID = 0;
         n19BR_EncounterID = false;
         A36BR_Information_PatientNo = "";
         n36BR_Information_PatientNo = false;
         A140BR_Procedure_PXID = 0;
         n140BR_Procedure_PXID = false;
         A141BR_Procedure_PXSurgery = "";
         n141BR_Procedure_PXSurgery = false;
         A266BR_Procedure_Date = DateTime.MinValue;
         n266BR_Procedure_Date = false;
         A143BR_Procedure_PXRadiotherapy = "";
         n143BR_Procedure_PXRadiotherapy = false;
         A268BR_Procedure_RadioDate = DateTime.MinValue;
         n268BR_Procedure_RadioDate = false;
         A269BR_Procedure_RadioTime = 0;
         n269BR_Procedure_RadioTime = false;
         Z497BR_Procedure_PXSurgery_Code = "";
         Z498BR_Procedure_PXRadiotherapy_Code = "";
         Z140BR_Procedure_PXID = 0;
         Z141BR_Procedure_PXSurgery = "";
         Z266BR_Procedure_Date = DateTime.MinValue;
         Z143BR_Procedure_PXRadiotherapy = "";
         Z268BR_Procedure_RadioDate = DateTime.MinValue;
         Z269BR_Procedure_RadioTime = 0;
         Z19BR_EncounterID = 0;
      }

      protected void InitAll0I19( )
      {
         A139BR_ProcedureID = 0;
         InitializeNonKey0I19( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow19( SdtBR_Procedure obj19 )
      {
         obj19.gxTpr_Mode = Gx_mode;
         obj19.gxTpr_Br_procedure_pxsurgery_code = A497BR_Procedure_PXSurgery_Code;
         obj19.gxTpr_Br_procedure_pxradiotherapy_code = A498BR_Procedure_PXRadiotherapy_Code;
         obj19.gxTpr_Br_encounterid = A19BR_EncounterID;
         obj19.gxTpr_Br_information_patientno = A36BR_Information_PatientNo;
         obj19.gxTpr_Br_procedure_pxid = A140BR_Procedure_PXID;
         obj19.gxTpr_Br_procedure_pxsurgery = A141BR_Procedure_PXSurgery;
         obj19.gxTpr_Br_procedure_date = A266BR_Procedure_Date;
         obj19.gxTpr_Br_procedure_pxradiotherapy = A143BR_Procedure_PXRadiotherapy;
         obj19.gxTpr_Br_procedure_radiodate = A268BR_Procedure_RadioDate;
         obj19.gxTpr_Br_procedure_radiotime = A269BR_Procedure_RadioTime;
         obj19.gxTpr_Br_procedureid = A139BR_ProcedureID;
         obj19.gxTpr_Br_procedureid_Z = Z139BR_ProcedureID;
         obj19.gxTpr_Br_encounterid_Z = Z19BR_EncounterID;
         obj19.gxTpr_Br_information_patientno_Z = Z36BR_Information_PatientNo;
         obj19.gxTpr_Br_procedure_pxid_Z = Z140BR_Procedure_PXID;
         obj19.gxTpr_Br_procedure_pxsurgery_Z = Z141BR_Procedure_PXSurgery;
         obj19.gxTpr_Br_procedure_pxsurgery_code_Z = Z497BR_Procedure_PXSurgery_Code;
         obj19.gxTpr_Br_procedure_date_Z = Z266BR_Procedure_Date;
         obj19.gxTpr_Br_procedure_pxradiotherapy_Z = Z143BR_Procedure_PXRadiotherapy;
         obj19.gxTpr_Br_procedure_pxradiotherapy_code_Z = Z498BR_Procedure_PXRadiotherapy_Code;
         obj19.gxTpr_Br_procedure_radiodate_Z = Z268BR_Procedure_RadioDate;
         obj19.gxTpr_Br_procedure_radiotime_Z = Z269BR_Procedure_RadioTime;
         obj19.gxTpr_Br_encounterid_N = (short)(Convert.ToInt16(n19BR_EncounterID));
         obj19.gxTpr_Br_information_patientno_N = (short)(Convert.ToInt16(n36BR_Information_PatientNo));
         obj19.gxTpr_Br_procedure_pxid_N = (short)(Convert.ToInt16(n140BR_Procedure_PXID));
         obj19.gxTpr_Br_procedure_pxsurgery_N = (short)(Convert.ToInt16(n141BR_Procedure_PXSurgery));
         obj19.gxTpr_Br_procedure_pxsurgery_code_N = (short)(Convert.ToInt16(n497BR_Procedure_PXSurgery_Code));
         obj19.gxTpr_Br_procedure_date_N = (short)(Convert.ToInt16(n266BR_Procedure_Date));
         obj19.gxTpr_Br_procedure_pxradiotherapy_N = (short)(Convert.ToInt16(n143BR_Procedure_PXRadiotherapy));
         obj19.gxTpr_Br_procedure_pxradiotherapy_code_N = (short)(Convert.ToInt16(n498BR_Procedure_PXRadiotherapy_Code));
         obj19.gxTpr_Br_procedure_radiodate_N = (short)(Convert.ToInt16(n268BR_Procedure_RadioDate));
         obj19.gxTpr_Br_procedure_radiotime_N = (short)(Convert.ToInt16(n269BR_Procedure_RadioTime));
         obj19.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow19( SdtBR_Procedure obj19 )
      {
         obj19.gxTpr_Br_procedureid = A139BR_ProcedureID;
         return  ;
      }

      public void RowToVars19( SdtBR_Procedure obj19 ,
                               int forceLoad )
      {
         Gx_mode = obj19.gxTpr_Mode;
         A497BR_Procedure_PXSurgery_Code = obj19.gxTpr_Br_procedure_pxsurgery_code;
         n497BR_Procedure_PXSurgery_Code = false;
         A498BR_Procedure_PXRadiotherapy_Code = obj19.gxTpr_Br_procedure_pxradiotherapy_code;
         n498BR_Procedure_PXRadiotherapy_Code = false;
         A19BR_EncounterID = obj19.gxTpr_Br_encounterid;
         n19BR_EncounterID = false;
         A36BR_Information_PatientNo = obj19.gxTpr_Br_information_patientno;
         n36BR_Information_PatientNo = false;
         A140BR_Procedure_PXID = obj19.gxTpr_Br_procedure_pxid;
         n140BR_Procedure_PXID = false;
         A141BR_Procedure_PXSurgery = obj19.gxTpr_Br_procedure_pxsurgery;
         n141BR_Procedure_PXSurgery = false;
         A266BR_Procedure_Date = obj19.gxTpr_Br_procedure_date;
         n266BR_Procedure_Date = false;
         A143BR_Procedure_PXRadiotherapy = obj19.gxTpr_Br_procedure_pxradiotherapy;
         n143BR_Procedure_PXRadiotherapy = false;
         A268BR_Procedure_RadioDate = obj19.gxTpr_Br_procedure_radiodate;
         n268BR_Procedure_RadioDate = false;
         A269BR_Procedure_RadioTime = obj19.gxTpr_Br_procedure_radiotime;
         n269BR_Procedure_RadioTime = false;
         A139BR_ProcedureID = obj19.gxTpr_Br_procedureid;
         Z139BR_ProcedureID = obj19.gxTpr_Br_procedureid_Z;
         Z19BR_EncounterID = obj19.gxTpr_Br_encounterid_Z;
         Z36BR_Information_PatientNo = obj19.gxTpr_Br_information_patientno_Z;
         Z140BR_Procedure_PXID = obj19.gxTpr_Br_procedure_pxid_Z;
         Z141BR_Procedure_PXSurgery = obj19.gxTpr_Br_procedure_pxsurgery_Z;
         Z497BR_Procedure_PXSurgery_Code = obj19.gxTpr_Br_procedure_pxsurgery_code_Z;
         Z266BR_Procedure_Date = obj19.gxTpr_Br_procedure_date_Z;
         Z143BR_Procedure_PXRadiotherapy = obj19.gxTpr_Br_procedure_pxradiotherapy_Z;
         Z498BR_Procedure_PXRadiotherapy_Code = obj19.gxTpr_Br_procedure_pxradiotherapy_code_Z;
         Z268BR_Procedure_RadioDate = obj19.gxTpr_Br_procedure_radiodate_Z;
         Z269BR_Procedure_RadioTime = obj19.gxTpr_Br_procedure_radiotime_Z;
         n19BR_EncounterID = (bool)(Convert.ToBoolean(obj19.gxTpr_Br_encounterid_N));
         n36BR_Information_PatientNo = (bool)(Convert.ToBoolean(obj19.gxTpr_Br_information_patientno_N));
         n140BR_Procedure_PXID = (bool)(Convert.ToBoolean(obj19.gxTpr_Br_procedure_pxid_N));
         n141BR_Procedure_PXSurgery = (bool)(Convert.ToBoolean(obj19.gxTpr_Br_procedure_pxsurgery_N));
         n497BR_Procedure_PXSurgery_Code = (bool)(Convert.ToBoolean(obj19.gxTpr_Br_procedure_pxsurgery_code_N));
         n266BR_Procedure_Date = (bool)(Convert.ToBoolean(obj19.gxTpr_Br_procedure_date_N));
         n143BR_Procedure_PXRadiotherapy = (bool)(Convert.ToBoolean(obj19.gxTpr_Br_procedure_pxradiotherapy_N));
         n498BR_Procedure_PXRadiotherapy_Code = (bool)(Convert.ToBoolean(obj19.gxTpr_Br_procedure_pxradiotherapy_code_N));
         n268BR_Procedure_RadioDate = (bool)(Convert.ToBoolean(obj19.gxTpr_Br_procedure_radiodate_N));
         n269BR_Procedure_RadioTime = (bool)(Convert.ToBoolean(obj19.gxTpr_Br_procedure_radiotime_N));
         Gx_mode = obj19.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A139BR_ProcedureID = (long)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey0I19( ) ;
         ScanKeyStart0I19( ) ;
         if ( RcdFound19 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z139BR_ProcedureID = A139BR_ProcedureID;
         }
         ZM0I19( -22) ;
         OnLoadActions0I19( ) ;
         AddRow0I19( ) ;
         ScanKeyEnd0I19( ) ;
         if ( RcdFound19 == 0 )
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
         RowToVars19( bcBR_Procedure, 0) ;
         ScanKeyStart0I19( ) ;
         if ( RcdFound19 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z139BR_ProcedureID = A139BR_ProcedureID;
         }
         ZM0I19( -22) ;
         OnLoadActions0I19( ) ;
         AddRow0I19( ) ;
         ScanKeyEnd0I19( ) ;
         if ( RcdFound19 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey0I19( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert0I19( ) ;
         }
         else
         {
            if ( RcdFound19 == 1 )
            {
               if ( A139BR_ProcedureID != Z139BR_ProcedureID )
               {
                  A139BR_ProcedureID = Z139BR_ProcedureID;
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
                  Update0I19( ) ;
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
                  if ( A139BR_ProcedureID != Z139BR_ProcedureID )
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
                        Insert0I19( ) ;
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
                        Insert0I19( ) ;
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
         RowToVars19( bcBR_Procedure, 0) ;
         SaveImpl( ) ;
         VarsToRow19( bcBR_Procedure) ;
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
         RowToVars19( bcBR_Procedure, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert0I19( ) ;
         AfterTrn( ) ;
         VarsToRow19( bcBR_Procedure) ;
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
            SdtBR_Procedure auxBC = new SdtBR_Procedure(context) ;
            auxBC.Load(A139BR_ProcedureID);
            auxBC.UpdateDirties(bcBR_Procedure);
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
         RowToVars19( bcBR_Procedure, 0) ;
         UpdateImpl( ) ;
         VarsToRow19( bcBR_Procedure) ;
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
         RowToVars19( bcBR_Procedure, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert0I19( ) ;
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
         VarsToRow19( bcBR_Procedure) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars19( bcBR_Procedure, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey0I19( ) ;
         if ( RcdFound19 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A139BR_ProcedureID != Z139BR_ProcedureID )
            {
               A139BR_ProcedureID = Z139BR_ProcedureID;
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
            if ( A139BR_ProcedureID != Z139BR_ProcedureID )
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
         context.RollbackDataStores("br_procedure_bc",pr_default);
         VarsToRow19( bcBR_Procedure) ;
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
         Gx_mode = bcBR_Procedure.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcBR_Procedure.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcBR_Procedure )
         {
            bcBR_Procedure = (SdtBR_Procedure)(sdt);
            if ( StringUtil.StrCmp(bcBR_Procedure.gxTpr_Mode, "") == 0 )
            {
               bcBR_Procedure.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow19( bcBR_Procedure) ;
            }
            else
            {
               RowToVars19( bcBR_Procedure, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcBR_Procedure.gxTpr_Mode, "") == 0 )
            {
               bcBR_Procedure.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars19( bcBR_Procedure, 1) ;
         return  ;
      }

      public SdtBR_Procedure BR_Procedure_BC
      {
         get {
            return bcBR_Procedure ;
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
         AV7WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV20Pgmname = "";
         AV8TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9WebSession = context.GetSession();
         AV11TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         Z497BR_Procedure_PXSurgery_Code = "";
         A497BR_Procedure_PXSurgery_Code = "";
         Z498BR_Procedure_PXRadiotherapy_Code = "";
         A498BR_Procedure_PXRadiotherapy_Code = "";
         Z141BR_Procedure_PXSurgery = "";
         A141BR_Procedure_PXSurgery = "";
         Z266BR_Procedure_Date = DateTime.MinValue;
         A266BR_Procedure_Date = DateTime.MinValue;
         Z143BR_Procedure_PXRadiotherapy = "";
         A143BR_Procedure_PXRadiotherapy = "";
         Z268BR_Procedure_RadioDate = DateTime.MinValue;
         A268BR_Procedure_RadioDate = DateTime.MinValue;
         Z36BR_Information_PatientNo = "";
         A36BR_Information_PatientNo = "";
         BC000I6_A85BR_Information_ID = new long[1] ;
         BC000I6_n85BR_Information_ID = new bool[] {false} ;
         BC000I6_A139BR_ProcedureID = new long[1] ;
         BC000I6_A497BR_Procedure_PXSurgery_Code = new String[] {""} ;
         BC000I6_n497BR_Procedure_PXSurgery_Code = new bool[] {false} ;
         BC000I6_A498BR_Procedure_PXRadiotherapy_Code = new String[] {""} ;
         BC000I6_n498BR_Procedure_PXRadiotherapy_Code = new bool[] {false} ;
         BC000I6_A36BR_Information_PatientNo = new String[] {""} ;
         BC000I6_n36BR_Information_PatientNo = new bool[] {false} ;
         BC000I6_A140BR_Procedure_PXID = new long[1] ;
         BC000I6_n140BR_Procedure_PXID = new bool[] {false} ;
         BC000I6_A141BR_Procedure_PXSurgery = new String[] {""} ;
         BC000I6_n141BR_Procedure_PXSurgery = new bool[] {false} ;
         BC000I6_A266BR_Procedure_Date = new DateTime[] {DateTime.MinValue} ;
         BC000I6_n266BR_Procedure_Date = new bool[] {false} ;
         BC000I6_A143BR_Procedure_PXRadiotherapy = new String[] {""} ;
         BC000I6_n143BR_Procedure_PXRadiotherapy = new bool[] {false} ;
         BC000I6_A268BR_Procedure_RadioDate = new DateTime[] {DateTime.MinValue} ;
         BC000I6_n268BR_Procedure_RadioDate = new bool[] {false} ;
         BC000I6_A269BR_Procedure_RadioTime = new decimal[1] ;
         BC000I6_n269BR_Procedure_RadioTime = new bool[] {false} ;
         BC000I6_A19BR_EncounterID = new long[1] ;
         BC000I6_n19BR_EncounterID = new bool[] {false} ;
         BC000I4_A85BR_Information_ID = new long[1] ;
         BC000I4_n85BR_Information_ID = new bool[] {false} ;
         BC000I5_A36BR_Information_PatientNo = new String[] {""} ;
         BC000I5_n36BR_Information_PatientNo = new bool[] {false} ;
         BC000I7_A139BR_ProcedureID = new long[1] ;
         BC000I3_A139BR_ProcedureID = new long[1] ;
         BC000I3_A497BR_Procedure_PXSurgery_Code = new String[] {""} ;
         BC000I3_n497BR_Procedure_PXSurgery_Code = new bool[] {false} ;
         BC000I3_A498BR_Procedure_PXRadiotherapy_Code = new String[] {""} ;
         BC000I3_n498BR_Procedure_PXRadiotherapy_Code = new bool[] {false} ;
         BC000I3_A140BR_Procedure_PXID = new long[1] ;
         BC000I3_n140BR_Procedure_PXID = new bool[] {false} ;
         BC000I3_A141BR_Procedure_PXSurgery = new String[] {""} ;
         BC000I3_n141BR_Procedure_PXSurgery = new bool[] {false} ;
         BC000I3_A266BR_Procedure_Date = new DateTime[] {DateTime.MinValue} ;
         BC000I3_n266BR_Procedure_Date = new bool[] {false} ;
         BC000I3_A143BR_Procedure_PXRadiotherapy = new String[] {""} ;
         BC000I3_n143BR_Procedure_PXRadiotherapy = new bool[] {false} ;
         BC000I3_A268BR_Procedure_RadioDate = new DateTime[] {DateTime.MinValue} ;
         BC000I3_n268BR_Procedure_RadioDate = new bool[] {false} ;
         BC000I3_A269BR_Procedure_RadioTime = new decimal[1] ;
         BC000I3_n269BR_Procedure_RadioTime = new bool[] {false} ;
         BC000I3_A19BR_EncounterID = new long[1] ;
         BC000I3_n19BR_EncounterID = new bool[] {false} ;
         sMode19 = "";
         BC000I2_A139BR_ProcedureID = new long[1] ;
         BC000I2_A497BR_Procedure_PXSurgery_Code = new String[] {""} ;
         BC000I2_n497BR_Procedure_PXSurgery_Code = new bool[] {false} ;
         BC000I2_A498BR_Procedure_PXRadiotherapy_Code = new String[] {""} ;
         BC000I2_n498BR_Procedure_PXRadiotherapy_Code = new bool[] {false} ;
         BC000I2_A140BR_Procedure_PXID = new long[1] ;
         BC000I2_n140BR_Procedure_PXID = new bool[] {false} ;
         BC000I2_A141BR_Procedure_PXSurgery = new String[] {""} ;
         BC000I2_n141BR_Procedure_PXSurgery = new bool[] {false} ;
         BC000I2_A266BR_Procedure_Date = new DateTime[] {DateTime.MinValue} ;
         BC000I2_n266BR_Procedure_Date = new bool[] {false} ;
         BC000I2_A143BR_Procedure_PXRadiotherapy = new String[] {""} ;
         BC000I2_n143BR_Procedure_PXRadiotherapy = new bool[] {false} ;
         BC000I2_A268BR_Procedure_RadioDate = new DateTime[] {DateTime.MinValue} ;
         BC000I2_n268BR_Procedure_RadioDate = new bool[] {false} ;
         BC000I2_A269BR_Procedure_RadioTime = new decimal[1] ;
         BC000I2_n269BR_Procedure_RadioTime = new bool[] {false} ;
         BC000I2_A19BR_EncounterID = new long[1] ;
         BC000I2_n19BR_EncounterID = new bool[] {false} ;
         BC000I8_A139BR_ProcedureID = new long[1] ;
         BC000I11_A85BR_Information_ID = new long[1] ;
         BC000I11_n85BR_Information_ID = new bool[] {false} ;
         BC000I12_A36BR_Information_PatientNo = new String[] {""} ;
         BC000I12_n36BR_Information_PatientNo = new bool[] {false} ;
         BC000I13_A323BR_Procedure_RadioID = new long[1] ;
         BC000I14_A320BR_Procedure_SurgeryID = new long[1] ;
         BC000I15_A85BR_Information_ID = new long[1] ;
         BC000I15_n85BR_Information_ID = new bool[] {false} ;
         BC000I15_A139BR_ProcedureID = new long[1] ;
         BC000I15_A497BR_Procedure_PXSurgery_Code = new String[] {""} ;
         BC000I15_n497BR_Procedure_PXSurgery_Code = new bool[] {false} ;
         BC000I15_A498BR_Procedure_PXRadiotherapy_Code = new String[] {""} ;
         BC000I15_n498BR_Procedure_PXRadiotherapy_Code = new bool[] {false} ;
         BC000I15_A36BR_Information_PatientNo = new String[] {""} ;
         BC000I15_n36BR_Information_PatientNo = new bool[] {false} ;
         BC000I15_A140BR_Procedure_PXID = new long[1] ;
         BC000I15_n140BR_Procedure_PXID = new bool[] {false} ;
         BC000I15_A141BR_Procedure_PXSurgery = new String[] {""} ;
         BC000I15_n141BR_Procedure_PXSurgery = new bool[] {false} ;
         BC000I15_A266BR_Procedure_Date = new DateTime[] {DateTime.MinValue} ;
         BC000I15_n266BR_Procedure_Date = new bool[] {false} ;
         BC000I15_A143BR_Procedure_PXRadiotherapy = new String[] {""} ;
         BC000I15_n143BR_Procedure_PXRadiotherapy = new bool[] {false} ;
         BC000I15_A268BR_Procedure_RadioDate = new DateTime[] {DateTime.MinValue} ;
         BC000I15_n268BR_Procedure_RadioDate = new bool[] {false} ;
         BC000I15_A269BR_Procedure_RadioTime = new decimal[1] ;
         BC000I15_n269BR_Procedure_RadioTime = new bool[] {false} ;
         BC000I15_A19BR_EncounterID = new long[1] ;
         BC000I15_n19BR_EncounterID = new bool[] {false} ;
         GXt_char2 = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_procedure_bc__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_procedure_bc__default(),
            new Object[][] {
                new Object[] {
               BC000I2_A139BR_ProcedureID, BC000I2_A497BR_Procedure_PXSurgery_Code, BC000I2_n497BR_Procedure_PXSurgery_Code, BC000I2_A498BR_Procedure_PXRadiotherapy_Code, BC000I2_n498BR_Procedure_PXRadiotherapy_Code, BC000I2_A140BR_Procedure_PXID, BC000I2_n140BR_Procedure_PXID, BC000I2_A141BR_Procedure_PXSurgery, BC000I2_n141BR_Procedure_PXSurgery, BC000I2_A266BR_Procedure_Date,
               BC000I2_n266BR_Procedure_Date, BC000I2_A143BR_Procedure_PXRadiotherapy, BC000I2_n143BR_Procedure_PXRadiotherapy, BC000I2_A268BR_Procedure_RadioDate, BC000I2_n268BR_Procedure_RadioDate, BC000I2_A269BR_Procedure_RadioTime, BC000I2_n269BR_Procedure_RadioTime, BC000I2_A19BR_EncounterID, BC000I2_n19BR_EncounterID
               }
               , new Object[] {
               BC000I3_A139BR_ProcedureID, BC000I3_A497BR_Procedure_PXSurgery_Code, BC000I3_n497BR_Procedure_PXSurgery_Code, BC000I3_A498BR_Procedure_PXRadiotherapy_Code, BC000I3_n498BR_Procedure_PXRadiotherapy_Code, BC000I3_A140BR_Procedure_PXID, BC000I3_n140BR_Procedure_PXID, BC000I3_A141BR_Procedure_PXSurgery, BC000I3_n141BR_Procedure_PXSurgery, BC000I3_A266BR_Procedure_Date,
               BC000I3_n266BR_Procedure_Date, BC000I3_A143BR_Procedure_PXRadiotherapy, BC000I3_n143BR_Procedure_PXRadiotherapy, BC000I3_A268BR_Procedure_RadioDate, BC000I3_n268BR_Procedure_RadioDate, BC000I3_A269BR_Procedure_RadioTime, BC000I3_n269BR_Procedure_RadioTime, BC000I3_A19BR_EncounterID, BC000I3_n19BR_EncounterID
               }
               , new Object[] {
               BC000I4_A85BR_Information_ID, BC000I4_n85BR_Information_ID
               }
               , new Object[] {
               BC000I5_A36BR_Information_PatientNo, BC000I5_n36BR_Information_PatientNo
               }
               , new Object[] {
               BC000I6_A85BR_Information_ID, BC000I6_n85BR_Information_ID, BC000I6_A139BR_ProcedureID, BC000I6_A497BR_Procedure_PXSurgery_Code, BC000I6_n497BR_Procedure_PXSurgery_Code, BC000I6_A498BR_Procedure_PXRadiotherapy_Code, BC000I6_n498BR_Procedure_PXRadiotherapy_Code, BC000I6_A36BR_Information_PatientNo, BC000I6_n36BR_Information_PatientNo, BC000I6_A140BR_Procedure_PXID,
               BC000I6_n140BR_Procedure_PXID, BC000I6_A141BR_Procedure_PXSurgery, BC000I6_n141BR_Procedure_PXSurgery, BC000I6_A266BR_Procedure_Date, BC000I6_n266BR_Procedure_Date, BC000I6_A143BR_Procedure_PXRadiotherapy, BC000I6_n143BR_Procedure_PXRadiotherapy, BC000I6_A268BR_Procedure_RadioDate, BC000I6_n268BR_Procedure_RadioDate, BC000I6_A269BR_Procedure_RadioTime,
               BC000I6_n269BR_Procedure_RadioTime, BC000I6_A19BR_EncounterID, BC000I6_n19BR_EncounterID
               }
               , new Object[] {
               BC000I7_A139BR_ProcedureID
               }
               , new Object[] {
               BC000I8_A139BR_ProcedureID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000I11_A85BR_Information_ID, BC000I11_n85BR_Information_ID
               }
               , new Object[] {
               BC000I12_A36BR_Information_PatientNo, BC000I12_n36BR_Information_PatientNo
               }
               , new Object[] {
               BC000I13_A323BR_Procedure_RadioID
               }
               , new Object[] {
               BC000I14_A320BR_Procedure_SurgeryID
               }
               , new Object[] {
               BC000I15_A85BR_Information_ID, BC000I15_n85BR_Information_ID, BC000I15_A139BR_ProcedureID, BC000I15_A497BR_Procedure_PXSurgery_Code, BC000I15_n497BR_Procedure_PXSurgery_Code, BC000I15_A498BR_Procedure_PXRadiotherapy_Code, BC000I15_n498BR_Procedure_PXRadiotherapy_Code, BC000I15_A36BR_Information_PatientNo, BC000I15_n36BR_Information_PatientNo, BC000I15_A140BR_Procedure_PXID,
               BC000I15_n140BR_Procedure_PXID, BC000I15_A141BR_Procedure_PXSurgery, BC000I15_n141BR_Procedure_PXSurgery, BC000I15_A266BR_Procedure_Date, BC000I15_n266BR_Procedure_Date, BC000I15_A143BR_Procedure_PXRadiotherapy, BC000I15_n143BR_Procedure_PXRadiotherapy, BC000I15_A268BR_Procedure_RadioDate, BC000I15_n268BR_Procedure_RadioDate, BC000I15_A269BR_Procedure_RadioTime,
               BC000I15_n269BR_Procedure_RadioTime, BC000I15_A19BR_EncounterID, BC000I15_n19BR_EncounterID
               }
            }
         );
         AV20Pgmname = "BR_Procedure_BC";
         INITTRN();
         /* Execute Start event if defined. */
         /* Execute user event: Start */
         E120I2 ();
         standaloneNotModal( ) ;
      }

      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short GX_JID ;
      private short RcdFound19 ;
      private int trnEnded ;
      private int AV21GXV1 ;
      private long Z139BR_ProcedureID ;
      private long A139BR_ProcedureID ;
      private long AV10Insert_BR_EncounterID ;
      private long Z140BR_Procedure_PXID ;
      private long A140BR_Procedure_PXID ;
      private long Z19BR_EncounterID ;
      private long A19BR_EncounterID ;
      private long Z85BR_Information_ID ;
      private long A85BR_Information_ID ;
      private decimal Z269BR_Procedure_RadioTime ;
      private decimal A269BR_Procedure_RadioTime ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String AV20Pgmname ;
      private String sMode19 ;
      private String GXt_char2 ;
      private DateTime Z266BR_Procedure_Date ;
      private DateTime A266BR_Procedure_Date ;
      private DateTime Z268BR_Procedure_RadioDate ;
      private DateTime A268BR_Procedure_RadioDate ;
      private bool AV13IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool returnInSub ;
      private bool n85BR_Information_ID ;
      private bool n497BR_Procedure_PXSurgery_Code ;
      private bool n498BR_Procedure_PXRadiotherapy_Code ;
      private bool n36BR_Information_PatientNo ;
      private bool n140BR_Procedure_PXID ;
      private bool n141BR_Procedure_PXSurgery ;
      private bool n266BR_Procedure_Date ;
      private bool n143BR_Procedure_PXRadiotherapy ;
      private bool n268BR_Procedure_RadioDate ;
      private bool n269BR_Procedure_RadioTime ;
      private bool n19BR_EncounterID ;
      private bool Gx_longc ;
      private String Z497BR_Procedure_PXSurgery_Code ;
      private String A497BR_Procedure_PXSurgery_Code ;
      private String Z498BR_Procedure_PXRadiotherapy_Code ;
      private String A498BR_Procedure_PXRadiotherapy_Code ;
      private String Z141BR_Procedure_PXSurgery ;
      private String A141BR_Procedure_PXSurgery ;
      private String Z143BR_Procedure_PXRadiotherapy ;
      private String A143BR_Procedure_PXRadiotherapy ;
      private String Z36BR_Information_PatientNo ;
      private String A36BR_Information_PatientNo ;
      private IGxSession AV9WebSession ;
      private SdtBR_Procedure bcBR_Procedure ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] BC000I6_A85BR_Information_ID ;
      private bool[] BC000I6_n85BR_Information_ID ;
      private long[] BC000I6_A139BR_ProcedureID ;
      private String[] BC000I6_A497BR_Procedure_PXSurgery_Code ;
      private bool[] BC000I6_n497BR_Procedure_PXSurgery_Code ;
      private String[] BC000I6_A498BR_Procedure_PXRadiotherapy_Code ;
      private bool[] BC000I6_n498BR_Procedure_PXRadiotherapy_Code ;
      private String[] BC000I6_A36BR_Information_PatientNo ;
      private bool[] BC000I6_n36BR_Information_PatientNo ;
      private long[] BC000I6_A140BR_Procedure_PXID ;
      private bool[] BC000I6_n140BR_Procedure_PXID ;
      private String[] BC000I6_A141BR_Procedure_PXSurgery ;
      private bool[] BC000I6_n141BR_Procedure_PXSurgery ;
      private DateTime[] BC000I6_A266BR_Procedure_Date ;
      private bool[] BC000I6_n266BR_Procedure_Date ;
      private String[] BC000I6_A143BR_Procedure_PXRadiotherapy ;
      private bool[] BC000I6_n143BR_Procedure_PXRadiotherapy ;
      private DateTime[] BC000I6_A268BR_Procedure_RadioDate ;
      private bool[] BC000I6_n268BR_Procedure_RadioDate ;
      private decimal[] BC000I6_A269BR_Procedure_RadioTime ;
      private bool[] BC000I6_n269BR_Procedure_RadioTime ;
      private long[] BC000I6_A19BR_EncounterID ;
      private bool[] BC000I6_n19BR_EncounterID ;
      private long[] BC000I4_A85BR_Information_ID ;
      private bool[] BC000I4_n85BR_Information_ID ;
      private String[] BC000I5_A36BR_Information_PatientNo ;
      private bool[] BC000I5_n36BR_Information_PatientNo ;
      private long[] BC000I7_A139BR_ProcedureID ;
      private long[] BC000I3_A139BR_ProcedureID ;
      private String[] BC000I3_A497BR_Procedure_PXSurgery_Code ;
      private bool[] BC000I3_n497BR_Procedure_PXSurgery_Code ;
      private String[] BC000I3_A498BR_Procedure_PXRadiotherapy_Code ;
      private bool[] BC000I3_n498BR_Procedure_PXRadiotherapy_Code ;
      private long[] BC000I3_A140BR_Procedure_PXID ;
      private bool[] BC000I3_n140BR_Procedure_PXID ;
      private String[] BC000I3_A141BR_Procedure_PXSurgery ;
      private bool[] BC000I3_n141BR_Procedure_PXSurgery ;
      private DateTime[] BC000I3_A266BR_Procedure_Date ;
      private bool[] BC000I3_n266BR_Procedure_Date ;
      private String[] BC000I3_A143BR_Procedure_PXRadiotherapy ;
      private bool[] BC000I3_n143BR_Procedure_PXRadiotherapy ;
      private DateTime[] BC000I3_A268BR_Procedure_RadioDate ;
      private bool[] BC000I3_n268BR_Procedure_RadioDate ;
      private decimal[] BC000I3_A269BR_Procedure_RadioTime ;
      private bool[] BC000I3_n269BR_Procedure_RadioTime ;
      private long[] BC000I3_A19BR_EncounterID ;
      private bool[] BC000I3_n19BR_EncounterID ;
      private long[] BC000I2_A139BR_ProcedureID ;
      private String[] BC000I2_A497BR_Procedure_PXSurgery_Code ;
      private bool[] BC000I2_n497BR_Procedure_PXSurgery_Code ;
      private String[] BC000I2_A498BR_Procedure_PXRadiotherapy_Code ;
      private bool[] BC000I2_n498BR_Procedure_PXRadiotherapy_Code ;
      private long[] BC000I2_A140BR_Procedure_PXID ;
      private bool[] BC000I2_n140BR_Procedure_PXID ;
      private String[] BC000I2_A141BR_Procedure_PXSurgery ;
      private bool[] BC000I2_n141BR_Procedure_PXSurgery ;
      private DateTime[] BC000I2_A266BR_Procedure_Date ;
      private bool[] BC000I2_n266BR_Procedure_Date ;
      private String[] BC000I2_A143BR_Procedure_PXRadiotherapy ;
      private bool[] BC000I2_n143BR_Procedure_PXRadiotherapy ;
      private DateTime[] BC000I2_A268BR_Procedure_RadioDate ;
      private bool[] BC000I2_n268BR_Procedure_RadioDate ;
      private decimal[] BC000I2_A269BR_Procedure_RadioTime ;
      private bool[] BC000I2_n269BR_Procedure_RadioTime ;
      private long[] BC000I2_A19BR_EncounterID ;
      private bool[] BC000I2_n19BR_EncounterID ;
      private long[] BC000I8_A139BR_ProcedureID ;
      private long[] BC000I11_A85BR_Information_ID ;
      private bool[] BC000I11_n85BR_Information_ID ;
      private String[] BC000I12_A36BR_Information_PatientNo ;
      private bool[] BC000I12_n36BR_Information_PatientNo ;
      private long[] BC000I13_A323BR_Procedure_RadioID ;
      private long[] BC000I14_A320BR_Procedure_SurgeryID ;
      private long[] BC000I15_A85BR_Information_ID ;
      private bool[] BC000I15_n85BR_Information_ID ;
      private long[] BC000I15_A139BR_ProcedureID ;
      private String[] BC000I15_A497BR_Procedure_PXSurgery_Code ;
      private bool[] BC000I15_n497BR_Procedure_PXSurgery_Code ;
      private String[] BC000I15_A498BR_Procedure_PXRadiotherapy_Code ;
      private bool[] BC000I15_n498BR_Procedure_PXRadiotherapy_Code ;
      private String[] BC000I15_A36BR_Information_PatientNo ;
      private bool[] BC000I15_n36BR_Information_PatientNo ;
      private long[] BC000I15_A140BR_Procedure_PXID ;
      private bool[] BC000I15_n140BR_Procedure_PXID ;
      private String[] BC000I15_A141BR_Procedure_PXSurgery ;
      private bool[] BC000I15_n141BR_Procedure_PXSurgery ;
      private DateTime[] BC000I15_A266BR_Procedure_Date ;
      private bool[] BC000I15_n266BR_Procedure_Date ;
      private String[] BC000I15_A143BR_Procedure_PXRadiotherapy ;
      private bool[] BC000I15_n143BR_Procedure_PXRadiotherapy ;
      private DateTime[] BC000I15_A268BR_Procedure_RadioDate ;
      private bool[] BC000I15_n268BR_Procedure_RadioDate ;
      private decimal[] BC000I15_A269BR_Procedure_RadioTime ;
      private bool[] BC000I15_n269BR_Procedure_RadioTime ;
      private long[] BC000I15_A19BR_EncounterID ;
      private bool[] BC000I15_n19BR_EncounterID ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_datastore1 ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV8TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV11TrnContextAtt ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV7WWPContext ;
   }

   public class br_procedure_bc__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class br_procedure_bc__default : DataStoreHelperBase, IDataStoreHelper
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
       ,new ForEachCursor(def[12])
       ,new ForEachCursor(def[13])
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmBC000I6 ;
        prmBC000I6 = new Object[] {
        new Object[] {"@BR_ProcedureID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000I4 ;
        prmBC000I4 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000I5 ;
        prmBC000I5 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000I7 ;
        prmBC000I7 = new Object[] {
        new Object[] {"@BR_ProcedureID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000I3 ;
        prmBC000I3 = new Object[] {
        new Object[] {"@BR_ProcedureID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000I2 ;
        prmBC000I2 = new Object[] {
        new Object[] {"@BR_ProcedureID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000I8 ;
        prmBC000I8 = new Object[] {
        new Object[] {"@BR_Procedure_PXSurgery_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Procedure_PXRadiotherapy_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Procedure_PXID",SqlDbType.Decimal,10,0} ,
        new Object[] {"@BR_Procedure_PXSurgery",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Procedure_Date",SqlDbType.DateTime,8,0} ,
        new Object[] {"@BR_Procedure_PXRadiotherapy",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Procedure_RadioDate",SqlDbType.DateTime,8,0} ,
        new Object[] {"@BR_Procedure_RadioTime",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000I9 ;
        prmBC000I9 = new Object[] {
        new Object[] {"@BR_Procedure_PXSurgery_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Procedure_PXRadiotherapy_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Procedure_PXID",SqlDbType.Decimal,10,0} ,
        new Object[] {"@BR_Procedure_PXSurgery",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Procedure_Date",SqlDbType.DateTime,8,0} ,
        new Object[] {"@BR_Procedure_PXRadiotherapy",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Procedure_RadioDate",SqlDbType.DateTime,8,0} ,
        new Object[] {"@BR_Procedure_RadioTime",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_ProcedureID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000I10 ;
        prmBC000I10 = new Object[] {
        new Object[] {"@BR_ProcedureID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000I11 ;
        prmBC000I11 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000I12 ;
        prmBC000I12 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000I13 ;
        prmBC000I13 = new Object[] {
        new Object[] {"@BR_ProcedureID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000I14 ;
        prmBC000I14 = new Object[] {
        new Object[] {"@BR_ProcedureID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000I15 ;
        prmBC000I15 = new Object[] {
        new Object[] {"@BR_ProcedureID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("BC000I2", "SELECT [BR_ProcedureID], [BR_Procedure_PXSurgery_Code], [BR_Procedure_PXRadiotherapy_Code], [BR_Procedure_PXID], [BR_Procedure_PXSurgery], [BR_Procedure_Date], [BR_Procedure_PXRadiotherapy], [BR_Procedure_RadioDate], [BR_Procedure_RadioTime], [BR_EncounterID] FROM [BR_Procedure] WITH (UPDLOCK) WHERE [BR_ProcedureID] = @BR_ProcedureID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000I2,1,0,true,false )
           ,new CursorDef("BC000I3", "SELECT [BR_ProcedureID], [BR_Procedure_PXSurgery_Code], [BR_Procedure_PXRadiotherapy_Code], [BR_Procedure_PXID], [BR_Procedure_PXSurgery], [BR_Procedure_Date], [BR_Procedure_PXRadiotherapy], [BR_Procedure_RadioDate], [BR_Procedure_RadioTime], [BR_EncounterID] FROM [BR_Procedure] WITH (NOLOCK) WHERE [BR_ProcedureID] = @BR_ProcedureID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000I3,1,0,true,false )
           ,new CursorDef("BC000I4", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000I4,1,0,true,false )
           ,new CursorDef("BC000I5", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000I5,1,0,true,false )
           ,new CursorDef("BC000I6", "SELECT T2.[BR_Information_ID], TM1.[BR_ProcedureID], TM1.[BR_Procedure_PXSurgery_Code], TM1.[BR_Procedure_PXRadiotherapy_Code], T3.[BR_Information_PatientNo], TM1.[BR_Procedure_PXID], TM1.[BR_Procedure_PXSurgery], TM1.[BR_Procedure_Date], TM1.[BR_Procedure_PXRadiotherapy], TM1.[BR_Procedure_RadioDate], TM1.[BR_Procedure_RadioTime], TM1.[BR_EncounterID] FROM (([BR_Procedure] TM1 WITH (NOLOCK) LEFT JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = TM1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID]) WHERE TM1.[BR_ProcedureID] = @BR_ProcedureID ORDER BY TM1.[BR_ProcedureID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000I6,100,0,true,false )
           ,new CursorDef("BC000I7", "SELECT [BR_ProcedureID] FROM [BR_Procedure] WITH (NOLOCK) WHERE [BR_ProcedureID] = @BR_ProcedureID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000I7,1,0,true,false )
           ,new CursorDef("BC000I8", "INSERT INTO [BR_Procedure]([BR_Procedure_PXSurgery_Code], [BR_Procedure_PXRadiotherapy_Code], [BR_Procedure_PXID], [BR_Procedure_PXSurgery], [BR_Procedure_Date], [BR_Procedure_PXRadiotherapy], [BR_Procedure_RadioDate], [BR_Procedure_RadioTime], [BR_EncounterID]) VALUES(@BR_Procedure_PXSurgery_Code, @BR_Procedure_PXRadiotherapy_Code, @BR_Procedure_PXID, @BR_Procedure_PXSurgery, @BR_Procedure_Date, @BR_Procedure_PXRadiotherapy, @BR_Procedure_RadioDate, @BR_Procedure_RadioTime, @BR_EncounterID); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmBC000I8)
           ,new CursorDef("BC000I9", "UPDATE [BR_Procedure] SET [BR_Procedure_PXSurgery_Code]=@BR_Procedure_PXSurgery_Code, [BR_Procedure_PXRadiotherapy_Code]=@BR_Procedure_PXRadiotherapy_Code, [BR_Procedure_PXID]=@BR_Procedure_PXID, [BR_Procedure_PXSurgery]=@BR_Procedure_PXSurgery, [BR_Procedure_Date]=@BR_Procedure_Date, [BR_Procedure_PXRadiotherapy]=@BR_Procedure_PXRadiotherapy, [BR_Procedure_RadioDate]=@BR_Procedure_RadioDate, [BR_Procedure_RadioTime]=@BR_Procedure_RadioTime, [BR_EncounterID]=@BR_EncounterID  WHERE [BR_ProcedureID] = @BR_ProcedureID", GxErrorMask.GX_NOMASK,prmBC000I9)
           ,new CursorDef("BC000I10", "DELETE FROM [BR_Procedure]  WHERE [BR_ProcedureID] = @BR_ProcedureID", GxErrorMask.GX_NOMASK,prmBC000I10)
           ,new CursorDef("BC000I11", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000I11,1,0,true,false )
           ,new CursorDef("BC000I12", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000I12,1,0,true,false )
           ,new CursorDef("BC000I13", "SELECT TOP 1 [BR_Procedure_RadioID] FROM [BR_Procedure_Radio] WITH (NOLOCK) WHERE [BR_ProcedureID] = @BR_ProcedureID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000I13,1,0,true,true )
           ,new CursorDef("BC000I14", "SELECT TOP 1 [BR_Procedure_SurgeryID] FROM [BR_Procedure_Surgery] WITH (NOLOCK) WHERE [BR_ProcedureID] = @BR_ProcedureID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000I14,1,0,true,true )
           ,new CursorDef("BC000I15", "SELECT T2.[BR_Information_ID], TM1.[BR_ProcedureID], TM1.[BR_Procedure_PXSurgery_Code], TM1.[BR_Procedure_PXRadiotherapy_Code], T3.[BR_Information_PatientNo], TM1.[BR_Procedure_PXID], TM1.[BR_Procedure_PXSurgery], TM1.[BR_Procedure_Date], TM1.[BR_Procedure_PXRadiotherapy], TM1.[BR_Procedure_RadioDate], TM1.[BR_Procedure_RadioTime], TM1.[BR_EncounterID] FROM (([BR_Procedure] TM1 WITH (NOLOCK) LEFT JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = TM1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID]) WHERE TM1.[BR_ProcedureID] = @BR_ProcedureID ORDER BY TM1.[BR_ProcedureID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000I15,100,0,true,false )
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
              ((long[]) buf[5])[0] = rslt.getLong(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((DateTime[]) buf[9])[0] = rslt.getGXDate(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((DateTime[]) buf[13])[0] = rslt.getGXDate(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((decimal[]) buf[15])[0] = rslt.getDecimal(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((long[]) buf[17])[0] = rslt.getLong(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((long[]) buf[5])[0] = rslt.getLong(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((DateTime[]) buf[9])[0] = rslt.getGXDate(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((DateTime[]) buf[13])[0] = rslt.getGXDate(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((decimal[]) buf[15])[0] = rslt.getDecimal(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((long[]) buf[17])[0] = rslt.getLong(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              return;
           case 2 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              return;
           case 3 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              return;
           case 4 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              ((long[]) buf[2])[0] = rslt.getLong(2) ;
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((long[]) buf[9])[0] = rslt.getLong(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((DateTime[]) buf[13])[0] = rslt.getGXDate(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((DateTime[]) buf[17])[0] = rslt.getGXDate(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              ((decimal[]) buf[19])[0] = rslt.getDecimal(11) ;
              ((bool[]) buf[20])[0] = rslt.wasNull(11);
              ((long[]) buf[21])[0] = rslt.getLong(12) ;
              ((bool[]) buf[22])[0] = rslt.wasNull(12);
              return;
           case 5 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 6 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 9 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              return;
           case 10 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              return;
           case 11 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 12 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 13 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              ((long[]) buf[2])[0] = rslt.getLong(2) ;
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((long[]) buf[9])[0] = rslt.getLong(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((DateTime[]) buf[13])[0] = rslt.getGXDate(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((DateTime[]) buf[17])[0] = rslt.getGXDate(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              ((decimal[]) buf[19])[0] = rslt.getDecimal(11) ;
              ((bool[]) buf[20])[0] = rslt.wasNull(11);
              ((long[]) buf[21])[0] = rslt.getLong(12) ;
              ((bool[]) buf[22])[0] = rslt.wasNull(12);
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
                 stmt.setNull( 3 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(3, (long)parms[5]);
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
                 stmt.setNull( 5 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameter(5, (DateTime)parms[9]);
              }
              if ( (bool)parms[10] )
              {
                 stmt.setNull( 6 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(6, (String)parms[11]);
              }
              if ( (bool)parms[12] )
              {
                 stmt.setNull( 7 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameter(7, (DateTime)parms[13]);
              }
              if ( (bool)parms[14] )
              {
                 stmt.setNull( 8 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(8, (decimal)parms[15]);
              }
              if ( (bool)parms[16] )
              {
                 stmt.setNull( 9 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(9, (long)parms[17]);
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
                 stmt.setNull( 3 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(3, (long)parms[5]);
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
                 stmt.setNull( 5 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameter(5, (DateTime)parms[9]);
              }
              if ( (bool)parms[10] )
              {
                 stmt.setNull( 6 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(6, (String)parms[11]);
              }
              if ( (bool)parms[12] )
              {
                 stmt.setNull( 7 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameter(7, (DateTime)parms[13]);
              }
              if ( (bool)parms[14] )
              {
                 stmt.setNull( 8 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(8, (decimal)parms[15]);
              }
              if ( (bool)parms[16] )
              {
                 stmt.setNull( 9 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(9, (long)parms[17]);
              }
              stmt.SetParameter(10, (long)parms[18]);
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
           case 12 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 13 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
     }
  }

}

}
