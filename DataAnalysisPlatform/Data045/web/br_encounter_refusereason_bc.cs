/*
               File: BR_Encounter_RefuseReason_BC
        Description: 就诊信息驳回原因
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:8:48.38
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
   public class br_encounter_refusereason_bc : GXHttpHandler, IGxSilentTrn
   {
      public br_encounter_refusereason_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_encounter_refusereason_bc( IGxContext context )
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
         ReadRow1542( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey1542( ) ;
         standaloneModal( ) ;
         AddRow1542( ) ;
         Gx_mode = "INS";
         return  ;
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E11152 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               Z348BR_Encounter_RefuseReasonID = A348BR_Encounter_RefuseReasonID;
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

      protected void CONFIRM_150( )
      {
         BeforeValidate1542( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls1542( ) ;
            }
            else
            {
               CheckExtendedTable1542( ) ;
               if ( AnyError == 0 )
               {
                  ZM1542( 8) ;
               }
               CloseExtendedTableCursors1542( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void E12152( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV8WWPContext) ;
         AV9IsAuthorized = true;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWBR_Encounter_RefuseReason_Insert", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWBR_Encounter_RefuseReason_Update", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWBR_Encounter_RefuseReason_Delete", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
         }
         if ( ! AV9IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV16Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV11TrnContext.FromXml(AV12WebSession.Get("TrnContext"), null, "WWPTransactionContext", "DataAnalysisPlatform");
         if ( ( StringUtil.StrCmp(AV11TrnContext.gxTpr_Transactionname, AV16Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV17GXV1 = 1;
            while ( AV17GXV1 <= AV11TrnContext.gxTpr_Attributes.Count )
            {
               AV14TrnContextAtt = ((GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute)AV11TrnContext.gxTpr_Attributes.Item(AV17GXV1));
               if ( StringUtil.StrCmp(AV14TrnContextAtt.gxTpr_Attributename, "BR_EncounterID") == 0 )
               {
                  AV13Insert_BR_EncounterID = (long)(NumberUtil.Val( AV14TrnContextAtt.gxTpr_Attributevalue, "."));
               }
               AV17GXV1 = (int)(AV17GXV1+1);
            }
         }
      }

      protected void E11152( )
      {
         /* After Trn Routine */
      }

      protected void ZM1542( short GX_JID )
      {
         if ( ( GX_JID == 7 ) || ( GX_JID == 0 ) )
         {
            Z349BR_Encounter_RefuseReason_Reason = A349BR_Encounter_RefuseReason_Reason;
            Z350BR_Encounter_RefuseReason_NoApproveDate = A350BR_Encounter_RefuseReason_NoApproveDate;
            Z351BR_Encounter_RefuseReason_Status = A351BR_Encounter_RefuseReason_Status;
            Z352BR_Encounter_RefuseReason_Approver = A352BR_Encounter_RefuseReason_Approver;
            Z353BR_EncounterReason_IsApprove = A353BR_EncounterReason_IsApprove;
            Z356BR_EncounterReason_vStatus = A356BR_EncounterReason_vStatus;
            Z355BR_Encounter_RefuseReason_FReason = A355BR_Encounter_RefuseReason_FReason;
            Z354BR_Encounter_RefuseReason_FApproveDate = A354BR_Encounter_RefuseReason_FApproveDate;
            Z19BR_EncounterID = A19BR_EncounterID;
         }
         if ( ( GX_JID == 8 ) || ( GX_JID == 0 ) )
         {
            Z85BR_Information_ID = A85BR_Information_ID;
         }
         if ( GX_JID == -7 )
         {
            Z348BR_Encounter_RefuseReasonID = A348BR_Encounter_RefuseReasonID;
            Z349BR_Encounter_RefuseReason_Reason = A349BR_Encounter_RefuseReason_Reason;
            Z350BR_Encounter_RefuseReason_NoApproveDate = A350BR_Encounter_RefuseReason_NoApproveDate;
            Z351BR_Encounter_RefuseReason_Status = A351BR_Encounter_RefuseReason_Status;
            Z352BR_Encounter_RefuseReason_Approver = A352BR_Encounter_RefuseReason_Approver;
            Z353BR_EncounterReason_IsApprove = A353BR_EncounterReason_IsApprove;
            Z356BR_EncounterReason_vStatus = A356BR_EncounterReason_vStatus;
            Z355BR_Encounter_RefuseReason_FReason = A355BR_Encounter_RefuseReason_FReason;
            Z354BR_Encounter_RefuseReason_FApproveDate = A354BR_Encounter_RefuseReason_FApproveDate;
            Z19BR_EncounterID = A19BR_EncounterID;
            Z85BR_Information_ID = A85BR_Information_ID;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load1542( )
      {
         /* Using cursor BC00155 */
         pr_default.execute(3, new Object[] {A348BR_Encounter_RefuseReasonID});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound42 = 1;
            A349BR_Encounter_RefuseReason_Reason = BC00155_A349BR_Encounter_RefuseReason_Reason[0];
            n349BR_Encounter_RefuseReason_Reason = BC00155_n349BR_Encounter_RefuseReason_Reason[0];
            A350BR_Encounter_RefuseReason_NoApproveDate = BC00155_A350BR_Encounter_RefuseReason_NoApproveDate[0];
            n350BR_Encounter_RefuseReason_NoApproveDate = BC00155_n350BR_Encounter_RefuseReason_NoApproveDate[0];
            A351BR_Encounter_RefuseReason_Status = BC00155_A351BR_Encounter_RefuseReason_Status[0];
            n351BR_Encounter_RefuseReason_Status = BC00155_n351BR_Encounter_RefuseReason_Status[0];
            A352BR_Encounter_RefuseReason_Approver = BC00155_A352BR_Encounter_RefuseReason_Approver[0];
            n352BR_Encounter_RefuseReason_Approver = BC00155_n352BR_Encounter_RefuseReason_Approver[0];
            A353BR_EncounterReason_IsApprove = BC00155_A353BR_EncounterReason_IsApprove[0];
            n353BR_EncounterReason_IsApprove = BC00155_n353BR_EncounterReason_IsApprove[0];
            A356BR_EncounterReason_vStatus = BC00155_A356BR_EncounterReason_vStatus[0];
            n356BR_EncounterReason_vStatus = BC00155_n356BR_EncounterReason_vStatus[0];
            A355BR_Encounter_RefuseReason_FReason = BC00155_A355BR_Encounter_RefuseReason_FReason[0];
            n355BR_Encounter_RefuseReason_FReason = BC00155_n355BR_Encounter_RefuseReason_FReason[0];
            A354BR_Encounter_RefuseReason_FApproveDate = BC00155_A354BR_Encounter_RefuseReason_FApproveDate[0];
            n354BR_Encounter_RefuseReason_FApproveDate = BC00155_n354BR_Encounter_RefuseReason_FApproveDate[0];
            A19BR_EncounterID = BC00155_A19BR_EncounterID[0];
            A85BR_Information_ID = BC00155_A85BR_Information_ID[0];
            n85BR_Information_ID = BC00155_n85BR_Information_ID[0];
            ZM1542( -7) ;
         }
         pr_default.close(3);
         OnLoadActions1542( ) ;
      }

      protected void OnLoadActions1542( )
      {
         AV16Pgmname = "BR_Encounter_RefuseReason_BC";
      }

      protected void CheckExtendedTable1542( )
      {
         standaloneModal( ) ;
         AV16Pgmname = "BR_Encounter_RefuseReason_BC";
         /* Using cursor BC00154 */
         pr_default.execute(2, new Object[] {A19BR_EncounterID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("不匹配' T15'", "ForeignKeyNotFound", 1, "BR_ENCOUNTERID");
            AnyError = 1;
         }
         A85BR_Information_ID = BC00154_A85BR_Information_ID[0];
         n85BR_Information_ID = BC00154_n85BR_Information_ID[0];
         pr_default.close(2);
         if ( ! ( (DateTime.MinValue==A350BR_Encounter_RefuseReason_NoApproveDate) || ( A350BR_Encounter_RefuseReason_NoApproveDate >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("域初审不通过时间超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
         if ( ! ( ( A351BR_Encounter_RefuseReason_Status == 1 ) || ( A351BR_Encounter_RefuseReason_Status == 2 ) || (0==A351BR_Encounter_RefuseReason_Status) ) )
         {
            GX_msglist.addItem("域初审不通过状态超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
         if ( ! ( ( A356BR_EncounterReason_vStatus == 1 ) || ( A356BR_EncounterReason_vStatus == 2 ) || (0==A356BR_EncounterReason_vStatus) ) )
         {
            GX_msglist.addItem("域是否复审/是否初审超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
         if ( ! ( (DateTime.MinValue==A354BR_Encounter_RefuseReason_FApproveDate) || ( A354BR_Encounter_RefuseReason_FApproveDate >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("域复审不通过时间超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
      }

      protected void CloseExtendedTableCursors1542( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey1542( )
      {
         /* Using cursor BC00156 */
         pr_default.execute(4, new Object[] {A348BR_Encounter_RefuseReasonID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound42 = 1;
         }
         else
         {
            RcdFound42 = 0;
         }
         pr_default.close(4);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC00153 */
         pr_default.execute(1, new Object[] {A348BR_Encounter_RefuseReasonID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM1542( 7) ;
            RcdFound42 = 1;
            A348BR_Encounter_RefuseReasonID = BC00153_A348BR_Encounter_RefuseReasonID[0];
            A349BR_Encounter_RefuseReason_Reason = BC00153_A349BR_Encounter_RefuseReason_Reason[0];
            n349BR_Encounter_RefuseReason_Reason = BC00153_n349BR_Encounter_RefuseReason_Reason[0];
            A350BR_Encounter_RefuseReason_NoApproveDate = BC00153_A350BR_Encounter_RefuseReason_NoApproveDate[0];
            n350BR_Encounter_RefuseReason_NoApproveDate = BC00153_n350BR_Encounter_RefuseReason_NoApproveDate[0];
            A351BR_Encounter_RefuseReason_Status = BC00153_A351BR_Encounter_RefuseReason_Status[0];
            n351BR_Encounter_RefuseReason_Status = BC00153_n351BR_Encounter_RefuseReason_Status[0];
            A352BR_Encounter_RefuseReason_Approver = BC00153_A352BR_Encounter_RefuseReason_Approver[0];
            n352BR_Encounter_RefuseReason_Approver = BC00153_n352BR_Encounter_RefuseReason_Approver[0];
            A353BR_EncounterReason_IsApprove = BC00153_A353BR_EncounterReason_IsApprove[0];
            n353BR_EncounterReason_IsApprove = BC00153_n353BR_EncounterReason_IsApprove[0];
            A356BR_EncounterReason_vStatus = BC00153_A356BR_EncounterReason_vStatus[0];
            n356BR_EncounterReason_vStatus = BC00153_n356BR_EncounterReason_vStatus[0];
            A355BR_Encounter_RefuseReason_FReason = BC00153_A355BR_Encounter_RefuseReason_FReason[0];
            n355BR_Encounter_RefuseReason_FReason = BC00153_n355BR_Encounter_RefuseReason_FReason[0];
            A354BR_Encounter_RefuseReason_FApproveDate = BC00153_A354BR_Encounter_RefuseReason_FApproveDate[0];
            n354BR_Encounter_RefuseReason_FApproveDate = BC00153_n354BR_Encounter_RefuseReason_FApproveDate[0];
            A19BR_EncounterID = BC00153_A19BR_EncounterID[0];
            Z348BR_Encounter_RefuseReasonID = A348BR_Encounter_RefuseReasonID;
            sMode42 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load1542( ) ;
            if ( AnyError == 1 )
            {
               RcdFound42 = 0;
               InitializeNonKey1542( ) ;
            }
            Gx_mode = sMode42;
         }
         else
         {
            RcdFound42 = 0;
            InitializeNonKey1542( ) ;
            sMode42 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode42;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1542( ) ;
         if ( RcdFound42 == 0 )
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
         CONFIRM_150( ) ;
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

      protected void CheckOptimisticConcurrency1542( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC00152 */
            pr_default.execute(0, new Object[] {A348BR_Encounter_RefuseReasonID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Encounter_RefuseReason"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z349BR_Encounter_RefuseReason_Reason, BC00152_A349BR_Encounter_RefuseReason_Reason[0]) != 0 ) || ( Z350BR_Encounter_RefuseReason_NoApproveDate != BC00152_A350BR_Encounter_RefuseReason_NoApproveDate[0] ) || ( Z351BR_Encounter_RefuseReason_Status != BC00152_A351BR_Encounter_RefuseReason_Status[0] ) || ( StringUtil.StrCmp(Z352BR_Encounter_RefuseReason_Approver, BC00152_A352BR_Encounter_RefuseReason_Approver[0]) != 0 ) || ( Z353BR_EncounterReason_IsApprove != BC00152_A353BR_EncounterReason_IsApprove[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z356BR_EncounterReason_vStatus != BC00152_A356BR_EncounterReason_vStatus[0] ) || ( StringUtil.StrCmp(Z355BR_Encounter_RefuseReason_FReason, BC00152_A355BR_Encounter_RefuseReason_FReason[0]) != 0 ) || ( Z354BR_Encounter_RefuseReason_FApproveDate != BC00152_A354BR_Encounter_RefuseReason_FApproveDate[0] ) || ( Z19BR_EncounterID != BC00152_A19BR_EncounterID[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"BR_Encounter_RefuseReason"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert1542( )
      {
         BeforeValidate1542( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1542( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1542( 0) ;
            CheckOptimisticConcurrency1542( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1542( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1542( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00157 */
                     pr_default.execute(5, new Object[] {n349BR_Encounter_RefuseReason_Reason, A349BR_Encounter_RefuseReason_Reason, n350BR_Encounter_RefuseReason_NoApproveDate, A350BR_Encounter_RefuseReason_NoApproveDate, n351BR_Encounter_RefuseReason_Status, A351BR_Encounter_RefuseReason_Status, n352BR_Encounter_RefuseReason_Approver, A352BR_Encounter_RefuseReason_Approver, n353BR_EncounterReason_IsApprove, A353BR_EncounterReason_IsApprove, n356BR_EncounterReason_vStatus, A356BR_EncounterReason_vStatus, n355BR_Encounter_RefuseReason_FReason, A355BR_Encounter_RefuseReason_FReason, n354BR_Encounter_RefuseReason_FApproveDate, A354BR_Encounter_RefuseReason_FApproveDate, A19BR_EncounterID});
                     A348BR_Encounter_RefuseReasonID = BC00157_A348BR_Encounter_RefuseReasonID[0];
                     pr_default.close(5);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Encounter_RefuseReason") ;
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
               Load1542( ) ;
            }
            EndLevel1542( ) ;
         }
         CloseExtendedTableCursors1542( ) ;
      }

      protected void Update1542( )
      {
         BeforeValidate1542( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1542( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1542( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1542( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1542( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00158 */
                     pr_default.execute(6, new Object[] {n349BR_Encounter_RefuseReason_Reason, A349BR_Encounter_RefuseReason_Reason, n350BR_Encounter_RefuseReason_NoApproveDate, A350BR_Encounter_RefuseReason_NoApproveDate, n351BR_Encounter_RefuseReason_Status, A351BR_Encounter_RefuseReason_Status, n352BR_Encounter_RefuseReason_Approver, A352BR_Encounter_RefuseReason_Approver, n353BR_EncounterReason_IsApprove, A353BR_EncounterReason_IsApprove, n356BR_EncounterReason_vStatus, A356BR_EncounterReason_vStatus, n355BR_Encounter_RefuseReason_FReason, A355BR_Encounter_RefuseReason_FReason, n354BR_Encounter_RefuseReason_FApproveDate, A354BR_Encounter_RefuseReason_FApproveDate, A19BR_EncounterID, A348BR_Encounter_RefuseReasonID});
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Encounter_RefuseReason") ;
                     if ( (pr_default.getStatus(6) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Encounter_RefuseReason"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate1542( ) ;
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
            EndLevel1542( ) ;
         }
         CloseExtendedTableCursors1542( ) ;
      }

      protected void DeferredUpdate1542( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate1542( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1542( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1542( ) ;
            AfterConfirm1542( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1542( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC00159 */
                  pr_default.execute(7, new Object[] {A348BR_Encounter_RefuseReasonID});
                  pr_default.close(7);
                  dsDefault.SmartCacheProvider.SetUpdated("BR_Encounter_RefuseReason") ;
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
         sMode42 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel1542( ) ;
         Gx_mode = sMode42;
      }

      protected void OnDeleteControls1542( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV16Pgmname = "BR_Encounter_RefuseReason_BC";
            /* Using cursor BC001510 */
            pr_default.execute(8, new Object[] {A19BR_EncounterID});
            A85BR_Information_ID = BC001510_A85BR_Information_ID[0];
            n85BR_Information_ID = BC001510_n85BR_Information_ID[0];
            pr_default.close(8);
         }
      }

      protected void EndLevel1542( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1542( ) ;
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

      public void ScanKeyStart1542( )
      {
         /* Scan By routine */
         /* Using cursor BC001511 */
         pr_default.execute(9, new Object[] {A348BR_Encounter_RefuseReasonID});
         RcdFound42 = 0;
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound42 = 1;
            A348BR_Encounter_RefuseReasonID = BC001511_A348BR_Encounter_RefuseReasonID[0];
            A349BR_Encounter_RefuseReason_Reason = BC001511_A349BR_Encounter_RefuseReason_Reason[0];
            n349BR_Encounter_RefuseReason_Reason = BC001511_n349BR_Encounter_RefuseReason_Reason[0];
            A350BR_Encounter_RefuseReason_NoApproveDate = BC001511_A350BR_Encounter_RefuseReason_NoApproveDate[0];
            n350BR_Encounter_RefuseReason_NoApproveDate = BC001511_n350BR_Encounter_RefuseReason_NoApproveDate[0];
            A351BR_Encounter_RefuseReason_Status = BC001511_A351BR_Encounter_RefuseReason_Status[0];
            n351BR_Encounter_RefuseReason_Status = BC001511_n351BR_Encounter_RefuseReason_Status[0];
            A352BR_Encounter_RefuseReason_Approver = BC001511_A352BR_Encounter_RefuseReason_Approver[0];
            n352BR_Encounter_RefuseReason_Approver = BC001511_n352BR_Encounter_RefuseReason_Approver[0];
            A353BR_EncounterReason_IsApprove = BC001511_A353BR_EncounterReason_IsApprove[0];
            n353BR_EncounterReason_IsApprove = BC001511_n353BR_EncounterReason_IsApprove[0];
            A356BR_EncounterReason_vStatus = BC001511_A356BR_EncounterReason_vStatus[0];
            n356BR_EncounterReason_vStatus = BC001511_n356BR_EncounterReason_vStatus[0];
            A355BR_Encounter_RefuseReason_FReason = BC001511_A355BR_Encounter_RefuseReason_FReason[0];
            n355BR_Encounter_RefuseReason_FReason = BC001511_n355BR_Encounter_RefuseReason_FReason[0];
            A354BR_Encounter_RefuseReason_FApproveDate = BC001511_A354BR_Encounter_RefuseReason_FApproveDate[0];
            n354BR_Encounter_RefuseReason_FApproveDate = BC001511_n354BR_Encounter_RefuseReason_FApproveDate[0];
            A19BR_EncounterID = BC001511_A19BR_EncounterID[0];
            A85BR_Information_ID = BC001511_A85BR_Information_ID[0];
            n85BR_Information_ID = BC001511_n85BR_Information_ID[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext1542( )
      {
         /* Scan next routine */
         pr_default.readNext(9);
         RcdFound42 = 0;
         ScanKeyLoad1542( ) ;
      }

      protected void ScanKeyLoad1542( )
      {
         sMode42 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound42 = 1;
            A348BR_Encounter_RefuseReasonID = BC001511_A348BR_Encounter_RefuseReasonID[0];
            A349BR_Encounter_RefuseReason_Reason = BC001511_A349BR_Encounter_RefuseReason_Reason[0];
            n349BR_Encounter_RefuseReason_Reason = BC001511_n349BR_Encounter_RefuseReason_Reason[0];
            A350BR_Encounter_RefuseReason_NoApproveDate = BC001511_A350BR_Encounter_RefuseReason_NoApproveDate[0];
            n350BR_Encounter_RefuseReason_NoApproveDate = BC001511_n350BR_Encounter_RefuseReason_NoApproveDate[0];
            A351BR_Encounter_RefuseReason_Status = BC001511_A351BR_Encounter_RefuseReason_Status[0];
            n351BR_Encounter_RefuseReason_Status = BC001511_n351BR_Encounter_RefuseReason_Status[0];
            A352BR_Encounter_RefuseReason_Approver = BC001511_A352BR_Encounter_RefuseReason_Approver[0];
            n352BR_Encounter_RefuseReason_Approver = BC001511_n352BR_Encounter_RefuseReason_Approver[0];
            A353BR_EncounterReason_IsApprove = BC001511_A353BR_EncounterReason_IsApprove[0];
            n353BR_EncounterReason_IsApprove = BC001511_n353BR_EncounterReason_IsApprove[0];
            A356BR_EncounterReason_vStatus = BC001511_A356BR_EncounterReason_vStatus[0];
            n356BR_EncounterReason_vStatus = BC001511_n356BR_EncounterReason_vStatus[0];
            A355BR_Encounter_RefuseReason_FReason = BC001511_A355BR_Encounter_RefuseReason_FReason[0];
            n355BR_Encounter_RefuseReason_FReason = BC001511_n355BR_Encounter_RefuseReason_FReason[0];
            A354BR_Encounter_RefuseReason_FApproveDate = BC001511_A354BR_Encounter_RefuseReason_FApproveDate[0];
            n354BR_Encounter_RefuseReason_FApproveDate = BC001511_n354BR_Encounter_RefuseReason_FApproveDate[0];
            A19BR_EncounterID = BC001511_A19BR_EncounterID[0];
            A85BR_Information_ID = BC001511_A85BR_Information_ID[0];
            n85BR_Information_ID = BC001511_n85BR_Information_ID[0];
         }
         Gx_mode = sMode42;
      }

      protected void ScanKeyEnd1542( )
      {
         pr_default.close(9);
      }

      protected void AfterConfirm1542( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1542( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1542( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1542( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1542( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1542( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1542( )
      {
      }

      protected void send_integrity_lvl_hashes1542( )
      {
      }

      protected void AddRow1542( )
      {
         VarsToRow42( bcBR_Encounter_RefuseReason) ;
      }

      protected void ReadRow1542( )
      {
         RowToVars42( bcBR_Encounter_RefuseReason, 1) ;
      }

      protected void InitializeNonKey1542( )
      {
         A19BR_EncounterID = 0;
         A349BR_Encounter_RefuseReason_Reason = "";
         n349BR_Encounter_RefuseReason_Reason = false;
         A350BR_Encounter_RefuseReason_NoApproveDate = (DateTime)(DateTime.MinValue);
         n350BR_Encounter_RefuseReason_NoApproveDate = false;
         A351BR_Encounter_RefuseReason_Status = 0;
         n351BR_Encounter_RefuseReason_Status = false;
         A352BR_Encounter_RefuseReason_Approver = "";
         n352BR_Encounter_RefuseReason_Approver = false;
         A353BR_EncounterReason_IsApprove = false;
         n353BR_EncounterReason_IsApprove = false;
         A85BR_Information_ID = 0;
         n85BR_Information_ID = false;
         A356BR_EncounterReason_vStatus = 0;
         n356BR_EncounterReason_vStatus = false;
         A355BR_Encounter_RefuseReason_FReason = "";
         n355BR_Encounter_RefuseReason_FReason = false;
         A354BR_Encounter_RefuseReason_FApproveDate = (DateTime)(DateTime.MinValue);
         n354BR_Encounter_RefuseReason_FApproveDate = false;
         Z349BR_Encounter_RefuseReason_Reason = "";
         Z350BR_Encounter_RefuseReason_NoApproveDate = (DateTime)(DateTime.MinValue);
         Z351BR_Encounter_RefuseReason_Status = 0;
         Z352BR_Encounter_RefuseReason_Approver = "";
         Z353BR_EncounterReason_IsApprove = false;
         Z356BR_EncounterReason_vStatus = 0;
         Z355BR_Encounter_RefuseReason_FReason = "";
         Z354BR_Encounter_RefuseReason_FApproveDate = (DateTime)(DateTime.MinValue);
         Z19BR_EncounterID = 0;
      }

      protected void InitAll1542( )
      {
         A348BR_Encounter_RefuseReasonID = 0;
         InitializeNonKey1542( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow42( SdtBR_Encounter_RefuseReason obj42 )
      {
         obj42.gxTpr_Mode = Gx_mode;
         obj42.gxTpr_Br_encounterid = A19BR_EncounterID;
         obj42.gxTpr_Br_encounter_refusereason_reason = A349BR_Encounter_RefuseReason_Reason;
         obj42.gxTpr_Br_encounter_refusereason_noapprovedate = A350BR_Encounter_RefuseReason_NoApproveDate;
         obj42.gxTpr_Br_encounter_refusereason_status = A351BR_Encounter_RefuseReason_Status;
         obj42.gxTpr_Br_encounter_refusereason_approver = A352BR_Encounter_RefuseReason_Approver;
         obj42.gxTpr_Br_encounterreason_isapprove = A353BR_EncounterReason_IsApprove;
         obj42.gxTpr_Br_information_id = A85BR_Information_ID;
         obj42.gxTpr_Br_encounterreason_vstatus = A356BR_EncounterReason_vStatus;
         obj42.gxTpr_Br_encounter_refusereason_freason = A355BR_Encounter_RefuseReason_FReason;
         obj42.gxTpr_Br_encounter_refusereason_fapprovedate = A354BR_Encounter_RefuseReason_FApproveDate;
         obj42.gxTpr_Br_encounter_refusereasonid = A348BR_Encounter_RefuseReasonID;
         obj42.gxTpr_Br_encounter_refusereasonid_Z = Z348BR_Encounter_RefuseReasonID;
         obj42.gxTpr_Br_encounterid_Z = Z19BR_EncounterID;
         obj42.gxTpr_Br_encounter_refusereason_reason_Z = Z349BR_Encounter_RefuseReason_Reason;
         obj42.gxTpr_Br_encounter_refusereason_noapprovedate_Z = Z350BR_Encounter_RefuseReason_NoApproveDate;
         obj42.gxTpr_Br_encounter_refusereason_status_Z = Z351BR_Encounter_RefuseReason_Status;
         obj42.gxTpr_Br_encounter_refusereason_approver_Z = Z352BR_Encounter_RefuseReason_Approver;
         obj42.gxTpr_Br_encounterreason_isapprove_Z = Z353BR_EncounterReason_IsApprove;
         obj42.gxTpr_Br_information_id_Z = Z85BR_Information_ID;
         obj42.gxTpr_Br_encounterreason_vstatus_Z = Z356BR_EncounterReason_vStatus;
         obj42.gxTpr_Br_encounter_refusereason_freason_Z = Z355BR_Encounter_RefuseReason_FReason;
         obj42.gxTpr_Br_encounter_refusereason_fapprovedate_Z = Z354BR_Encounter_RefuseReason_FApproveDate;
         obj42.gxTpr_Br_encounter_refusereason_reason_N = (short)(Convert.ToInt16(n349BR_Encounter_RefuseReason_Reason));
         obj42.gxTpr_Br_encounter_refusereason_noapprovedate_N = (short)(Convert.ToInt16(n350BR_Encounter_RefuseReason_NoApproveDate));
         obj42.gxTpr_Br_encounter_refusereason_status_N = (short)(Convert.ToInt16(n351BR_Encounter_RefuseReason_Status));
         obj42.gxTpr_Br_encounter_refusereason_approver_N = (short)(Convert.ToInt16(n352BR_Encounter_RefuseReason_Approver));
         obj42.gxTpr_Br_encounterreason_isapprove_N = (short)(Convert.ToInt16(n353BR_EncounterReason_IsApprove));
         obj42.gxTpr_Br_information_id_N = (short)(Convert.ToInt16(n85BR_Information_ID));
         obj42.gxTpr_Br_encounterreason_vstatus_N = (short)(Convert.ToInt16(n356BR_EncounterReason_vStatus));
         obj42.gxTpr_Br_encounter_refusereason_freason_N = (short)(Convert.ToInt16(n355BR_Encounter_RefuseReason_FReason));
         obj42.gxTpr_Br_encounter_refusereason_fapprovedate_N = (short)(Convert.ToInt16(n354BR_Encounter_RefuseReason_FApproveDate));
         obj42.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow42( SdtBR_Encounter_RefuseReason obj42 )
      {
         obj42.gxTpr_Br_encounter_refusereasonid = A348BR_Encounter_RefuseReasonID;
         return  ;
      }

      public void RowToVars42( SdtBR_Encounter_RefuseReason obj42 ,
                               int forceLoad )
      {
         Gx_mode = obj42.gxTpr_Mode;
         A19BR_EncounterID = obj42.gxTpr_Br_encounterid;
         A349BR_Encounter_RefuseReason_Reason = obj42.gxTpr_Br_encounter_refusereason_reason;
         n349BR_Encounter_RefuseReason_Reason = false;
         A350BR_Encounter_RefuseReason_NoApproveDate = obj42.gxTpr_Br_encounter_refusereason_noapprovedate;
         n350BR_Encounter_RefuseReason_NoApproveDate = false;
         A351BR_Encounter_RefuseReason_Status = obj42.gxTpr_Br_encounter_refusereason_status;
         n351BR_Encounter_RefuseReason_Status = false;
         A352BR_Encounter_RefuseReason_Approver = obj42.gxTpr_Br_encounter_refusereason_approver;
         n352BR_Encounter_RefuseReason_Approver = false;
         A353BR_EncounterReason_IsApprove = obj42.gxTpr_Br_encounterreason_isapprove;
         n353BR_EncounterReason_IsApprove = false;
         A85BR_Information_ID = obj42.gxTpr_Br_information_id;
         n85BR_Information_ID = false;
         A356BR_EncounterReason_vStatus = obj42.gxTpr_Br_encounterreason_vstatus;
         n356BR_EncounterReason_vStatus = false;
         A355BR_Encounter_RefuseReason_FReason = obj42.gxTpr_Br_encounter_refusereason_freason;
         n355BR_Encounter_RefuseReason_FReason = false;
         A354BR_Encounter_RefuseReason_FApproveDate = obj42.gxTpr_Br_encounter_refusereason_fapprovedate;
         n354BR_Encounter_RefuseReason_FApproveDate = false;
         A348BR_Encounter_RefuseReasonID = obj42.gxTpr_Br_encounter_refusereasonid;
         Z348BR_Encounter_RefuseReasonID = obj42.gxTpr_Br_encounter_refusereasonid_Z;
         Z19BR_EncounterID = obj42.gxTpr_Br_encounterid_Z;
         Z349BR_Encounter_RefuseReason_Reason = obj42.gxTpr_Br_encounter_refusereason_reason_Z;
         Z350BR_Encounter_RefuseReason_NoApproveDate = obj42.gxTpr_Br_encounter_refusereason_noapprovedate_Z;
         Z351BR_Encounter_RefuseReason_Status = obj42.gxTpr_Br_encounter_refusereason_status_Z;
         Z352BR_Encounter_RefuseReason_Approver = obj42.gxTpr_Br_encounter_refusereason_approver_Z;
         Z353BR_EncounterReason_IsApprove = obj42.gxTpr_Br_encounterreason_isapprove_Z;
         Z85BR_Information_ID = obj42.gxTpr_Br_information_id_Z;
         Z356BR_EncounterReason_vStatus = obj42.gxTpr_Br_encounterreason_vstatus_Z;
         Z355BR_Encounter_RefuseReason_FReason = obj42.gxTpr_Br_encounter_refusereason_freason_Z;
         Z354BR_Encounter_RefuseReason_FApproveDate = obj42.gxTpr_Br_encounter_refusereason_fapprovedate_Z;
         n349BR_Encounter_RefuseReason_Reason = (bool)(Convert.ToBoolean(obj42.gxTpr_Br_encounter_refusereason_reason_N));
         n350BR_Encounter_RefuseReason_NoApproveDate = (bool)(Convert.ToBoolean(obj42.gxTpr_Br_encounter_refusereason_noapprovedate_N));
         n351BR_Encounter_RefuseReason_Status = (bool)(Convert.ToBoolean(obj42.gxTpr_Br_encounter_refusereason_status_N));
         n352BR_Encounter_RefuseReason_Approver = (bool)(Convert.ToBoolean(obj42.gxTpr_Br_encounter_refusereason_approver_N));
         n353BR_EncounterReason_IsApprove = (bool)(Convert.ToBoolean(obj42.gxTpr_Br_encounterreason_isapprove_N));
         n85BR_Information_ID = (bool)(Convert.ToBoolean(obj42.gxTpr_Br_information_id_N));
         n356BR_EncounterReason_vStatus = (bool)(Convert.ToBoolean(obj42.gxTpr_Br_encounterreason_vstatus_N));
         n355BR_Encounter_RefuseReason_FReason = (bool)(Convert.ToBoolean(obj42.gxTpr_Br_encounter_refusereason_freason_N));
         n354BR_Encounter_RefuseReason_FApproveDate = (bool)(Convert.ToBoolean(obj42.gxTpr_Br_encounter_refusereason_fapprovedate_N));
         Gx_mode = obj42.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A348BR_Encounter_RefuseReasonID = (long)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey1542( ) ;
         ScanKeyStart1542( ) ;
         if ( RcdFound42 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z348BR_Encounter_RefuseReasonID = A348BR_Encounter_RefuseReasonID;
         }
         ZM1542( -7) ;
         OnLoadActions1542( ) ;
         AddRow1542( ) ;
         ScanKeyEnd1542( ) ;
         if ( RcdFound42 == 0 )
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
         RowToVars42( bcBR_Encounter_RefuseReason, 0) ;
         ScanKeyStart1542( ) ;
         if ( RcdFound42 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z348BR_Encounter_RefuseReasonID = A348BR_Encounter_RefuseReasonID;
         }
         ZM1542( -7) ;
         OnLoadActions1542( ) ;
         AddRow1542( ) ;
         ScanKeyEnd1542( ) ;
         if ( RcdFound42 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey1542( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert1542( ) ;
         }
         else
         {
            if ( RcdFound42 == 1 )
            {
               if ( A348BR_Encounter_RefuseReasonID != Z348BR_Encounter_RefuseReasonID )
               {
                  A348BR_Encounter_RefuseReasonID = Z348BR_Encounter_RefuseReasonID;
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
                  Update1542( ) ;
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
                  if ( A348BR_Encounter_RefuseReasonID != Z348BR_Encounter_RefuseReasonID )
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
                        Insert1542( ) ;
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
                        Insert1542( ) ;
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
         RowToVars42( bcBR_Encounter_RefuseReason, 0) ;
         SaveImpl( ) ;
         VarsToRow42( bcBR_Encounter_RefuseReason) ;
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
         RowToVars42( bcBR_Encounter_RefuseReason, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert1542( ) ;
         AfterTrn( ) ;
         VarsToRow42( bcBR_Encounter_RefuseReason) ;
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
            SdtBR_Encounter_RefuseReason auxBC = new SdtBR_Encounter_RefuseReason(context) ;
            auxBC.Load(A348BR_Encounter_RefuseReasonID);
            auxBC.UpdateDirties(bcBR_Encounter_RefuseReason);
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
         RowToVars42( bcBR_Encounter_RefuseReason, 0) ;
         UpdateImpl( ) ;
         VarsToRow42( bcBR_Encounter_RefuseReason) ;
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
         RowToVars42( bcBR_Encounter_RefuseReason, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert1542( ) ;
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
         VarsToRow42( bcBR_Encounter_RefuseReason) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars42( bcBR_Encounter_RefuseReason, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey1542( ) ;
         if ( RcdFound42 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A348BR_Encounter_RefuseReasonID != Z348BR_Encounter_RefuseReasonID )
            {
               A348BR_Encounter_RefuseReasonID = Z348BR_Encounter_RefuseReasonID;
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
            if ( A348BR_Encounter_RefuseReasonID != Z348BR_Encounter_RefuseReasonID )
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
         context.RollbackDataStores("br_encounter_refusereason_bc",pr_default);
         VarsToRow42( bcBR_Encounter_RefuseReason) ;
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
         Gx_mode = bcBR_Encounter_RefuseReason.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcBR_Encounter_RefuseReason.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcBR_Encounter_RefuseReason )
         {
            bcBR_Encounter_RefuseReason = (SdtBR_Encounter_RefuseReason)(sdt);
            if ( StringUtil.StrCmp(bcBR_Encounter_RefuseReason.gxTpr_Mode, "") == 0 )
            {
               bcBR_Encounter_RefuseReason.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow42( bcBR_Encounter_RefuseReason) ;
            }
            else
            {
               RowToVars42( bcBR_Encounter_RefuseReason, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcBR_Encounter_RefuseReason.gxTpr_Mode, "") == 0 )
            {
               bcBR_Encounter_RefuseReason.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars42( bcBR_Encounter_RefuseReason, 1) ;
         return  ;
      }

      public SdtBR_Encounter_RefuseReason BR_Encounter_RefuseReason_BC
      {
         get {
            return bcBR_Encounter_RefuseReason ;
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
         Z349BR_Encounter_RefuseReason_Reason = "";
         A349BR_Encounter_RefuseReason_Reason = "";
         Z350BR_Encounter_RefuseReason_NoApproveDate = (DateTime)(DateTime.MinValue);
         A350BR_Encounter_RefuseReason_NoApproveDate = (DateTime)(DateTime.MinValue);
         Z352BR_Encounter_RefuseReason_Approver = "";
         A352BR_Encounter_RefuseReason_Approver = "";
         Z355BR_Encounter_RefuseReason_FReason = "";
         A355BR_Encounter_RefuseReason_FReason = "";
         Z354BR_Encounter_RefuseReason_FApproveDate = (DateTime)(DateTime.MinValue);
         A354BR_Encounter_RefuseReason_FApproveDate = (DateTime)(DateTime.MinValue);
         BC00155_A348BR_Encounter_RefuseReasonID = new long[1] ;
         BC00155_A349BR_Encounter_RefuseReason_Reason = new String[] {""} ;
         BC00155_n349BR_Encounter_RefuseReason_Reason = new bool[] {false} ;
         BC00155_A350BR_Encounter_RefuseReason_NoApproveDate = new DateTime[] {DateTime.MinValue} ;
         BC00155_n350BR_Encounter_RefuseReason_NoApproveDate = new bool[] {false} ;
         BC00155_A351BR_Encounter_RefuseReason_Status = new short[1] ;
         BC00155_n351BR_Encounter_RefuseReason_Status = new bool[] {false} ;
         BC00155_A352BR_Encounter_RefuseReason_Approver = new String[] {""} ;
         BC00155_n352BR_Encounter_RefuseReason_Approver = new bool[] {false} ;
         BC00155_A353BR_EncounterReason_IsApprove = new bool[] {false} ;
         BC00155_n353BR_EncounterReason_IsApprove = new bool[] {false} ;
         BC00155_A356BR_EncounterReason_vStatus = new short[1] ;
         BC00155_n356BR_EncounterReason_vStatus = new bool[] {false} ;
         BC00155_A355BR_Encounter_RefuseReason_FReason = new String[] {""} ;
         BC00155_n355BR_Encounter_RefuseReason_FReason = new bool[] {false} ;
         BC00155_A354BR_Encounter_RefuseReason_FApproveDate = new DateTime[] {DateTime.MinValue} ;
         BC00155_n354BR_Encounter_RefuseReason_FApproveDate = new bool[] {false} ;
         BC00155_A19BR_EncounterID = new long[1] ;
         BC00155_A85BR_Information_ID = new long[1] ;
         BC00155_n85BR_Information_ID = new bool[] {false} ;
         BC00154_A85BR_Information_ID = new long[1] ;
         BC00154_n85BR_Information_ID = new bool[] {false} ;
         BC00156_A348BR_Encounter_RefuseReasonID = new long[1] ;
         BC00153_A348BR_Encounter_RefuseReasonID = new long[1] ;
         BC00153_A349BR_Encounter_RefuseReason_Reason = new String[] {""} ;
         BC00153_n349BR_Encounter_RefuseReason_Reason = new bool[] {false} ;
         BC00153_A350BR_Encounter_RefuseReason_NoApproveDate = new DateTime[] {DateTime.MinValue} ;
         BC00153_n350BR_Encounter_RefuseReason_NoApproveDate = new bool[] {false} ;
         BC00153_A351BR_Encounter_RefuseReason_Status = new short[1] ;
         BC00153_n351BR_Encounter_RefuseReason_Status = new bool[] {false} ;
         BC00153_A352BR_Encounter_RefuseReason_Approver = new String[] {""} ;
         BC00153_n352BR_Encounter_RefuseReason_Approver = new bool[] {false} ;
         BC00153_A353BR_EncounterReason_IsApprove = new bool[] {false} ;
         BC00153_n353BR_EncounterReason_IsApprove = new bool[] {false} ;
         BC00153_A356BR_EncounterReason_vStatus = new short[1] ;
         BC00153_n356BR_EncounterReason_vStatus = new bool[] {false} ;
         BC00153_A355BR_Encounter_RefuseReason_FReason = new String[] {""} ;
         BC00153_n355BR_Encounter_RefuseReason_FReason = new bool[] {false} ;
         BC00153_A354BR_Encounter_RefuseReason_FApproveDate = new DateTime[] {DateTime.MinValue} ;
         BC00153_n354BR_Encounter_RefuseReason_FApproveDate = new bool[] {false} ;
         BC00153_A19BR_EncounterID = new long[1] ;
         sMode42 = "";
         BC00152_A348BR_Encounter_RefuseReasonID = new long[1] ;
         BC00152_A349BR_Encounter_RefuseReason_Reason = new String[] {""} ;
         BC00152_n349BR_Encounter_RefuseReason_Reason = new bool[] {false} ;
         BC00152_A350BR_Encounter_RefuseReason_NoApproveDate = new DateTime[] {DateTime.MinValue} ;
         BC00152_n350BR_Encounter_RefuseReason_NoApproveDate = new bool[] {false} ;
         BC00152_A351BR_Encounter_RefuseReason_Status = new short[1] ;
         BC00152_n351BR_Encounter_RefuseReason_Status = new bool[] {false} ;
         BC00152_A352BR_Encounter_RefuseReason_Approver = new String[] {""} ;
         BC00152_n352BR_Encounter_RefuseReason_Approver = new bool[] {false} ;
         BC00152_A353BR_EncounterReason_IsApprove = new bool[] {false} ;
         BC00152_n353BR_EncounterReason_IsApprove = new bool[] {false} ;
         BC00152_A356BR_EncounterReason_vStatus = new short[1] ;
         BC00152_n356BR_EncounterReason_vStatus = new bool[] {false} ;
         BC00152_A355BR_Encounter_RefuseReason_FReason = new String[] {""} ;
         BC00152_n355BR_Encounter_RefuseReason_FReason = new bool[] {false} ;
         BC00152_A354BR_Encounter_RefuseReason_FApproveDate = new DateTime[] {DateTime.MinValue} ;
         BC00152_n354BR_Encounter_RefuseReason_FApproveDate = new bool[] {false} ;
         BC00152_A19BR_EncounterID = new long[1] ;
         BC00157_A348BR_Encounter_RefuseReasonID = new long[1] ;
         BC001510_A85BR_Information_ID = new long[1] ;
         BC001510_n85BR_Information_ID = new bool[] {false} ;
         BC001511_A348BR_Encounter_RefuseReasonID = new long[1] ;
         BC001511_A349BR_Encounter_RefuseReason_Reason = new String[] {""} ;
         BC001511_n349BR_Encounter_RefuseReason_Reason = new bool[] {false} ;
         BC001511_A350BR_Encounter_RefuseReason_NoApproveDate = new DateTime[] {DateTime.MinValue} ;
         BC001511_n350BR_Encounter_RefuseReason_NoApproveDate = new bool[] {false} ;
         BC001511_A351BR_Encounter_RefuseReason_Status = new short[1] ;
         BC001511_n351BR_Encounter_RefuseReason_Status = new bool[] {false} ;
         BC001511_A352BR_Encounter_RefuseReason_Approver = new String[] {""} ;
         BC001511_n352BR_Encounter_RefuseReason_Approver = new bool[] {false} ;
         BC001511_A353BR_EncounterReason_IsApprove = new bool[] {false} ;
         BC001511_n353BR_EncounterReason_IsApprove = new bool[] {false} ;
         BC001511_A356BR_EncounterReason_vStatus = new short[1] ;
         BC001511_n356BR_EncounterReason_vStatus = new bool[] {false} ;
         BC001511_A355BR_Encounter_RefuseReason_FReason = new String[] {""} ;
         BC001511_n355BR_Encounter_RefuseReason_FReason = new bool[] {false} ;
         BC001511_A354BR_Encounter_RefuseReason_FApproveDate = new DateTime[] {DateTime.MinValue} ;
         BC001511_n354BR_Encounter_RefuseReason_FApproveDate = new bool[] {false} ;
         BC001511_A19BR_EncounterID = new long[1] ;
         BC001511_A85BR_Information_ID = new long[1] ;
         BC001511_n85BR_Information_ID = new bool[] {false} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_encounter_refusereason_bc__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_encounter_refusereason_bc__default(),
            new Object[][] {
                new Object[] {
               BC00152_A348BR_Encounter_RefuseReasonID, BC00152_A349BR_Encounter_RefuseReason_Reason, BC00152_n349BR_Encounter_RefuseReason_Reason, BC00152_A350BR_Encounter_RefuseReason_NoApproveDate, BC00152_n350BR_Encounter_RefuseReason_NoApproveDate, BC00152_A351BR_Encounter_RefuseReason_Status, BC00152_n351BR_Encounter_RefuseReason_Status, BC00152_A352BR_Encounter_RefuseReason_Approver, BC00152_n352BR_Encounter_RefuseReason_Approver, BC00152_A353BR_EncounterReason_IsApprove,
               BC00152_n353BR_EncounterReason_IsApprove, BC00152_A356BR_EncounterReason_vStatus, BC00152_n356BR_EncounterReason_vStatus, BC00152_A355BR_Encounter_RefuseReason_FReason, BC00152_n355BR_Encounter_RefuseReason_FReason, BC00152_A354BR_Encounter_RefuseReason_FApproveDate, BC00152_n354BR_Encounter_RefuseReason_FApproveDate, BC00152_A19BR_EncounterID
               }
               , new Object[] {
               BC00153_A348BR_Encounter_RefuseReasonID, BC00153_A349BR_Encounter_RefuseReason_Reason, BC00153_n349BR_Encounter_RefuseReason_Reason, BC00153_A350BR_Encounter_RefuseReason_NoApproveDate, BC00153_n350BR_Encounter_RefuseReason_NoApproveDate, BC00153_A351BR_Encounter_RefuseReason_Status, BC00153_n351BR_Encounter_RefuseReason_Status, BC00153_A352BR_Encounter_RefuseReason_Approver, BC00153_n352BR_Encounter_RefuseReason_Approver, BC00153_A353BR_EncounterReason_IsApprove,
               BC00153_n353BR_EncounterReason_IsApprove, BC00153_A356BR_EncounterReason_vStatus, BC00153_n356BR_EncounterReason_vStatus, BC00153_A355BR_Encounter_RefuseReason_FReason, BC00153_n355BR_Encounter_RefuseReason_FReason, BC00153_A354BR_Encounter_RefuseReason_FApproveDate, BC00153_n354BR_Encounter_RefuseReason_FApproveDate, BC00153_A19BR_EncounterID
               }
               , new Object[] {
               BC00154_A85BR_Information_ID, BC00154_n85BR_Information_ID
               }
               , new Object[] {
               BC00155_A348BR_Encounter_RefuseReasonID, BC00155_A349BR_Encounter_RefuseReason_Reason, BC00155_n349BR_Encounter_RefuseReason_Reason, BC00155_A350BR_Encounter_RefuseReason_NoApproveDate, BC00155_n350BR_Encounter_RefuseReason_NoApproveDate, BC00155_A351BR_Encounter_RefuseReason_Status, BC00155_n351BR_Encounter_RefuseReason_Status, BC00155_A352BR_Encounter_RefuseReason_Approver, BC00155_n352BR_Encounter_RefuseReason_Approver, BC00155_A353BR_EncounterReason_IsApprove,
               BC00155_n353BR_EncounterReason_IsApprove, BC00155_A356BR_EncounterReason_vStatus, BC00155_n356BR_EncounterReason_vStatus, BC00155_A355BR_Encounter_RefuseReason_FReason, BC00155_n355BR_Encounter_RefuseReason_FReason, BC00155_A354BR_Encounter_RefuseReason_FApproveDate, BC00155_n354BR_Encounter_RefuseReason_FApproveDate, BC00155_A19BR_EncounterID, BC00155_A85BR_Information_ID, BC00155_n85BR_Information_ID
               }
               , new Object[] {
               BC00156_A348BR_Encounter_RefuseReasonID
               }
               , new Object[] {
               BC00157_A348BR_Encounter_RefuseReasonID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC001510_A85BR_Information_ID, BC001510_n85BR_Information_ID
               }
               , new Object[] {
               BC001511_A348BR_Encounter_RefuseReasonID, BC001511_A349BR_Encounter_RefuseReason_Reason, BC001511_n349BR_Encounter_RefuseReason_Reason, BC001511_A350BR_Encounter_RefuseReason_NoApproveDate, BC001511_n350BR_Encounter_RefuseReason_NoApproveDate, BC001511_A351BR_Encounter_RefuseReason_Status, BC001511_n351BR_Encounter_RefuseReason_Status, BC001511_A352BR_Encounter_RefuseReason_Approver, BC001511_n352BR_Encounter_RefuseReason_Approver, BC001511_A353BR_EncounterReason_IsApprove,
               BC001511_n353BR_EncounterReason_IsApprove, BC001511_A356BR_EncounterReason_vStatus, BC001511_n356BR_EncounterReason_vStatus, BC001511_A355BR_Encounter_RefuseReason_FReason, BC001511_n355BR_Encounter_RefuseReason_FReason, BC001511_A354BR_Encounter_RefuseReason_FApproveDate, BC001511_n354BR_Encounter_RefuseReason_FApproveDate, BC001511_A19BR_EncounterID, BC001511_A85BR_Information_ID, BC001511_n85BR_Information_ID
               }
            }
         );
         AV16Pgmname = "BR_Encounter_RefuseReason_BC";
         INITTRN();
         /* Execute Start event if defined. */
         /* Execute user event: Start */
         E12152 ();
         standaloneNotModal( ) ;
      }

      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short GX_JID ;
      private short Z351BR_Encounter_RefuseReason_Status ;
      private short A351BR_Encounter_RefuseReason_Status ;
      private short Z356BR_EncounterReason_vStatus ;
      private short A356BR_EncounterReason_vStatus ;
      private short RcdFound42 ;
      private int trnEnded ;
      private int AV17GXV1 ;
      private long Z348BR_Encounter_RefuseReasonID ;
      private long A348BR_Encounter_RefuseReasonID ;
      private long AV13Insert_BR_EncounterID ;
      private long Z19BR_EncounterID ;
      private long A19BR_EncounterID ;
      private long Z85BR_Information_ID ;
      private long A85BR_Information_ID ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String AV16Pgmname ;
      private String sMode42 ;
      private DateTime Z350BR_Encounter_RefuseReason_NoApproveDate ;
      private DateTime A350BR_Encounter_RefuseReason_NoApproveDate ;
      private DateTime Z354BR_Encounter_RefuseReason_FApproveDate ;
      private DateTime A354BR_Encounter_RefuseReason_FApproveDate ;
      private bool AV9IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool Z353BR_EncounterReason_IsApprove ;
      private bool A353BR_EncounterReason_IsApprove ;
      private bool n349BR_Encounter_RefuseReason_Reason ;
      private bool n350BR_Encounter_RefuseReason_NoApproveDate ;
      private bool n351BR_Encounter_RefuseReason_Status ;
      private bool n352BR_Encounter_RefuseReason_Approver ;
      private bool n353BR_EncounterReason_IsApprove ;
      private bool n356BR_EncounterReason_vStatus ;
      private bool n355BR_Encounter_RefuseReason_FReason ;
      private bool n354BR_Encounter_RefuseReason_FApproveDate ;
      private bool n85BR_Information_ID ;
      private bool Gx_longc ;
      private String Z349BR_Encounter_RefuseReason_Reason ;
      private String A349BR_Encounter_RefuseReason_Reason ;
      private String Z352BR_Encounter_RefuseReason_Approver ;
      private String A352BR_Encounter_RefuseReason_Approver ;
      private String Z355BR_Encounter_RefuseReason_FReason ;
      private String A355BR_Encounter_RefuseReason_FReason ;
      private IGxSession AV12WebSession ;
      private SdtBR_Encounter_RefuseReason bcBR_Encounter_RefuseReason ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] BC00155_A348BR_Encounter_RefuseReasonID ;
      private String[] BC00155_A349BR_Encounter_RefuseReason_Reason ;
      private bool[] BC00155_n349BR_Encounter_RefuseReason_Reason ;
      private DateTime[] BC00155_A350BR_Encounter_RefuseReason_NoApproveDate ;
      private bool[] BC00155_n350BR_Encounter_RefuseReason_NoApproveDate ;
      private short[] BC00155_A351BR_Encounter_RefuseReason_Status ;
      private bool[] BC00155_n351BR_Encounter_RefuseReason_Status ;
      private String[] BC00155_A352BR_Encounter_RefuseReason_Approver ;
      private bool[] BC00155_n352BR_Encounter_RefuseReason_Approver ;
      private bool[] BC00155_A353BR_EncounterReason_IsApprove ;
      private bool[] BC00155_n353BR_EncounterReason_IsApprove ;
      private short[] BC00155_A356BR_EncounterReason_vStatus ;
      private bool[] BC00155_n356BR_EncounterReason_vStatus ;
      private String[] BC00155_A355BR_Encounter_RefuseReason_FReason ;
      private bool[] BC00155_n355BR_Encounter_RefuseReason_FReason ;
      private DateTime[] BC00155_A354BR_Encounter_RefuseReason_FApproveDate ;
      private bool[] BC00155_n354BR_Encounter_RefuseReason_FApproveDate ;
      private long[] BC00155_A19BR_EncounterID ;
      private long[] BC00155_A85BR_Information_ID ;
      private bool[] BC00155_n85BR_Information_ID ;
      private long[] BC00154_A85BR_Information_ID ;
      private bool[] BC00154_n85BR_Information_ID ;
      private long[] BC00156_A348BR_Encounter_RefuseReasonID ;
      private long[] BC00153_A348BR_Encounter_RefuseReasonID ;
      private String[] BC00153_A349BR_Encounter_RefuseReason_Reason ;
      private bool[] BC00153_n349BR_Encounter_RefuseReason_Reason ;
      private DateTime[] BC00153_A350BR_Encounter_RefuseReason_NoApproveDate ;
      private bool[] BC00153_n350BR_Encounter_RefuseReason_NoApproveDate ;
      private short[] BC00153_A351BR_Encounter_RefuseReason_Status ;
      private bool[] BC00153_n351BR_Encounter_RefuseReason_Status ;
      private String[] BC00153_A352BR_Encounter_RefuseReason_Approver ;
      private bool[] BC00153_n352BR_Encounter_RefuseReason_Approver ;
      private bool[] BC00153_A353BR_EncounterReason_IsApprove ;
      private bool[] BC00153_n353BR_EncounterReason_IsApprove ;
      private short[] BC00153_A356BR_EncounterReason_vStatus ;
      private bool[] BC00153_n356BR_EncounterReason_vStatus ;
      private String[] BC00153_A355BR_Encounter_RefuseReason_FReason ;
      private bool[] BC00153_n355BR_Encounter_RefuseReason_FReason ;
      private DateTime[] BC00153_A354BR_Encounter_RefuseReason_FApproveDate ;
      private bool[] BC00153_n354BR_Encounter_RefuseReason_FApproveDate ;
      private long[] BC00153_A19BR_EncounterID ;
      private long[] BC00152_A348BR_Encounter_RefuseReasonID ;
      private String[] BC00152_A349BR_Encounter_RefuseReason_Reason ;
      private bool[] BC00152_n349BR_Encounter_RefuseReason_Reason ;
      private DateTime[] BC00152_A350BR_Encounter_RefuseReason_NoApproveDate ;
      private bool[] BC00152_n350BR_Encounter_RefuseReason_NoApproveDate ;
      private short[] BC00152_A351BR_Encounter_RefuseReason_Status ;
      private bool[] BC00152_n351BR_Encounter_RefuseReason_Status ;
      private String[] BC00152_A352BR_Encounter_RefuseReason_Approver ;
      private bool[] BC00152_n352BR_Encounter_RefuseReason_Approver ;
      private bool[] BC00152_A353BR_EncounterReason_IsApprove ;
      private bool[] BC00152_n353BR_EncounterReason_IsApprove ;
      private short[] BC00152_A356BR_EncounterReason_vStatus ;
      private bool[] BC00152_n356BR_EncounterReason_vStatus ;
      private String[] BC00152_A355BR_Encounter_RefuseReason_FReason ;
      private bool[] BC00152_n355BR_Encounter_RefuseReason_FReason ;
      private DateTime[] BC00152_A354BR_Encounter_RefuseReason_FApproveDate ;
      private bool[] BC00152_n354BR_Encounter_RefuseReason_FApproveDate ;
      private long[] BC00152_A19BR_EncounterID ;
      private long[] BC00157_A348BR_Encounter_RefuseReasonID ;
      private long[] BC001510_A85BR_Information_ID ;
      private bool[] BC001510_n85BR_Information_ID ;
      private long[] BC001511_A348BR_Encounter_RefuseReasonID ;
      private String[] BC001511_A349BR_Encounter_RefuseReason_Reason ;
      private bool[] BC001511_n349BR_Encounter_RefuseReason_Reason ;
      private DateTime[] BC001511_A350BR_Encounter_RefuseReason_NoApproveDate ;
      private bool[] BC001511_n350BR_Encounter_RefuseReason_NoApproveDate ;
      private short[] BC001511_A351BR_Encounter_RefuseReason_Status ;
      private bool[] BC001511_n351BR_Encounter_RefuseReason_Status ;
      private String[] BC001511_A352BR_Encounter_RefuseReason_Approver ;
      private bool[] BC001511_n352BR_Encounter_RefuseReason_Approver ;
      private bool[] BC001511_A353BR_EncounterReason_IsApprove ;
      private bool[] BC001511_n353BR_EncounterReason_IsApprove ;
      private short[] BC001511_A356BR_EncounterReason_vStatus ;
      private bool[] BC001511_n356BR_EncounterReason_vStatus ;
      private String[] BC001511_A355BR_Encounter_RefuseReason_FReason ;
      private bool[] BC001511_n355BR_Encounter_RefuseReason_FReason ;
      private DateTime[] BC001511_A354BR_Encounter_RefuseReason_FApproveDate ;
      private bool[] BC001511_n354BR_Encounter_RefuseReason_FApproveDate ;
      private long[] BC001511_A19BR_EncounterID ;
      private long[] BC001511_A85BR_Information_ID ;
      private bool[] BC001511_n85BR_Information_ID ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_datastore1 ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV8WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV11TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV14TrnContextAtt ;
   }

   public class br_encounter_refusereason_bc__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class br_encounter_refusereason_bc__default : DataStoreHelperBase, IDataStoreHelper
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
        Object[] prmBC00155 ;
        prmBC00155 = new Object[] {
        new Object[] {"@BR_Encounter_RefuseReasonID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00154 ;
        prmBC00154 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00156 ;
        prmBC00156 = new Object[] {
        new Object[] {"@BR_Encounter_RefuseReasonID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00153 ;
        prmBC00153 = new Object[] {
        new Object[] {"@BR_Encounter_RefuseReasonID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00152 ;
        prmBC00152 = new Object[] {
        new Object[] {"@BR_Encounter_RefuseReasonID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00157 ;
        prmBC00157 = new Object[] {
        new Object[] {"@BR_Encounter_RefuseReason_Reason",SqlDbType.NVarChar,300,0} ,
        new Object[] {"@BR_Encounter_RefuseReason_NoApproveDate",SqlDbType.DateTime,10,8} ,
        new Object[] {"@BR_Encounter_RefuseReason_Status",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@BR_Encounter_RefuseReason_Approver",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_EncounterReason_IsApprove",SqlDbType.Bit,4,0} ,
        new Object[] {"@BR_EncounterReason_vStatus",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@BR_Encounter_RefuseReason_FReason",SqlDbType.NVarChar,300,0} ,
        new Object[] {"@BR_Encounter_RefuseReason_FApproveDate",SqlDbType.DateTime,10,8} ,
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00158 ;
        prmBC00158 = new Object[] {
        new Object[] {"@BR_Encounter_RefuseReason_Reason",SqlDbType.NVarChar,300,0} ,
        new Object[] {"@BR_Encounter_RefuseReason_NoApproveDate",SqlDbType.DateTime,10,8} ,
        new Object[] {"@BR_Encounter_RefuseReason_Status",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@BR_Encounter_RefuseReason_Approver",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_EncounterReason_IsApprove",SqlDbType.Bit,4,0} ,
        new Object[] {"@BR_EncounterReason_vStatus",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@BR_Encounter_RefuseReason_FReason",SqlDbType.NVarChar,300,0} ,
        new Object[] {"@BR_Encounter_RefuseReason_FApproveDate",SqlDbType.DateTime,10,8} ,
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_Encounter_RefuseReasonID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00159 ;
        prmBC00159 = new Object[] {
        new Object[] {"@BR_Encounter_RefuseReasonID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC001510 ;
        prmBC001510 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC001511 ;
        prmBC001511 = new Object[] {
        new Object[] {"@BR_Encounter_RefuseReasonID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("BC00152", "SELECT [BR_Encounter_RefuseReasonID], [BR_Encounter_RefuseReason_Reason], [BR_Encounter_RefuseReason_NoApproveDate], [BR_Encounter_RefuseReason_Status], [BR_Encounter_RefuseReason_Approver], [BR_EncounterReason_IsApprove], [BR_EncounterReason_vStatus], [BR_Encounter_RefuseReason_FReason], [BR_Encounter_RefuseReason_FApproveDate], [BR_EncounterID] FROM [BR_Encounter_RefuseReason] WITH (UPDLOCK) WHERE [BR_Encounter_RefuseReasonID] = @BR_Encounter_RefuseReasonID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00152,1,0,true,false )
           ,new CursorDef("BC00153", "SELECT [BR_Encounter_RefuseReasonID], [BR_Encounter_RefuseReason_Reason], [BR_Encounter_RefuseReason_NoApproveDate], [BR_Encounter_RefuseReason_Status], [BR_Encounter_RefuseReason_Approver], [BR_EncounterReason_IsApprove], [BR_EncounterReason_vStatus], [BR_Encounter_RefuseReason_FReason], [BR_Encounter_RefuseReason_FApproveDate], [BR_EncounterID] FROM [BR_Encounter_RefuseReason] WITH (NOLOCK) WHERE [BR_Encounter_RefuseReasonID] = @BR_Encounter_RefuseReasonID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00153,1,0,true,false )
           ,new CursorDef("BC00154", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00154,1,0,true,false )
           ,new CursorDef("BC00155", "SELECT TM1.[BR_Encounter_RefuseReasonID], TM1.[BR_Encounter_RefuseReason_Reason], TM1.[BR_Encounter_RefuseReason_NoApproveDate], TM1.[BR_Encounter_RefuseReason_Status], TM1.[BR_Encounter_RefuseReason_Approver], TM1.[BR_EncounterReason_IsApprove], TM1.[BR_EncounterReason_vStatus], TM1.[BR_Encounter_RefuseReason_FReason], TM1.[BR_Encounter_RefuseReason_FApproveDate], TM1.[BR_EncounterID], T2.[BR_Information_ID] FROM ([BR_Encounter_RefuseReason] TM1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = TM1.[BR_EncounterID]) WHERE TM1.[BR_Encounter_RefuseReasonID] = @BR_Encounter_RefuseReasonID ORDER BY TM1.[BR_Encounter_RefuseReasonID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00155,100,0,true,false )
           ,new CursorDef("BC00156", "SELECT [BR_Encounter_RefuseReasonID] FROM [BR_Encounter_RefuseReason] WITH (NOLOCK) WHERE [BR_Encounter_RefuseReasonID] = @BR_Encounter_RefuseReasonID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00156,1,0,true,false )
           ,new CursorDef("BC00157", "INSERT INTO [BR_Encounter_RefuseReason]([BR_Encounter_RefuseReason_Reason], [BR_Encounter_RefuseReason_NoApproveDate], [BR_Encounter_RefuseReason_Status], [BR_Encounter_RefuseReason_Approver], [BR_EncounterReason_IsApprove], [BR_EncounterReason_vStatus], [BR_Encounter_RefuseReason_FReason], [BR_Encounter_RefuseReason_FApproveDate], [BR_EncounterID]) VALUES(@BR_Encounter_RefuseReason_Reason, @BR_Encounter_RefuseReason_NoApproveDate, @BR_Encounter_RefuseReason_Status, @BR_Encounter_RefuseReason_Approver, @BR_EncounterReason_IsApprove, @BR_EncounterReason_vStatus, @BR_Encounter_RefuseReason_FReason, @BR_Encounter_RefuseReason_FApproveDate, @BR_EncounterID); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmBC00157)
           ,new CursorDef("BC00158", "UPDATE [BR_Encounter_RefuseReason] SET [BR_Encounter_RefuseReason_Reason]=@BR_Encounter_RefuseReason_Reason, [BR_Encounter_RefuseReason_NoApproveDate]=@BR_Encounter_RefuseReason_NoApproveDate, [BR_Encounter_RefuseReason_Status]=@BR_Encounter_RefuseReason_Status, [BR_Encounter_RefuseReason_Approver]=@BR_Encounter_RefuseReason_Approver, [BR_EncounterReason_IsApprove]=@BR_EncounterReason_IsApprove, [BR_EncounterReason_vStatus]=@BR_EncounterReason_vStatus, [BR_Encounter_RefuseReason_FReason]=@BR_Encounter_RefuseReason_FReason, [BR_Encounter_RefuseReason_FApproveDate]=@BR_Encounter_RefuseReason_FApproveDate, [BR_EncounterID]=@BR_EncounterID  WHERE [BR_Encounter_RefuseReasonID] = @BR_Encounter_RefuseReasonID", GxErrorMask.GX_NOMASK,prmBC00158)
           ,new CursorDef("BC00159", "DELETE FROM [BR_Encounter_RefuseReason]  WHERE [BR_Encounter_RefuseReasonID] = @BR_Encounter_RefuseReasonID", GxErrorMask.GX_NOMASK,prmBC00159)
           ,new CursorDef("BC001510", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001510,1,0,true,false )
           ,new CursorDef("BC001511", "SELECT TM1.[BR_Encounter_RefuseReasonID], TM1.[BR_Encounter_RefuseReason_Reason], TM1.[BR_Encounter_RefuseReason_NoApproveDate], TM1.[BR_Encounter_RefuseReason_Status], TM1.[BR_Encounter_RefuseReason_Approver], TM1.[BR_EncounterReason_IsApprove], TM1.[BR_EncounterReason_vStatus], TM1.[BR_Encounter_RefuseReason_FReason], TM1.[BR_Encounter_RefuseReason_FApproveDate], TM1.[BR_EncounterID], T2.[BR_Information_ID] FROM ([BR_Encounter_RefuseReason] TM1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = TM1.[BR_EncounterID]) WHERE TM1.[BR_Encounter_RefuseReasonID] = @BR_Encounter_RefuseReasonID ORDER BY TM1.[BR_Encounter_RefuseReasonID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001511,100,0,true,false )
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
              ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((short[]) buf[5])[0] = rslt.getShort(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((bool[]) buf[9])[0] = rslt.getBool(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((short[]) buf[11])[0] = rslt.getShort(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((DateTime[]) buf[15])[0] = rslt.getGXDateTime(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((long[]) buf[17])[0] = rslt.getLong(10) ;
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((short[]) buf[5])[0] = rslt.getShort(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((bool[]) buf[9])[0] = rslt.getBool(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((short[]) buf[11])[0] = rslt.getShort(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((DateTime[]) buf[15])[0] = rslt.getGXDateTime(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((long[]) buf[17])[0] = rslt.getLong(10) ;
              return;
           case 2 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              return;
           case 3 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((short[]) buf[5])[0] = rslt.getShort(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((bool[]) buf[9])[0] = rslt.getBool(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((short[]) buf[11])[0] = rslt.getShort(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((DateTime[]) buf[15])[0] = rslt.getGXDateTime(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((long[]) buf[17])[0] = rslt.getLong(10) ;
              ((long[]) buf[18])[0] = rslt.getLong(11) ;
              ((bool[]) buf[19])[0] = rslt.wasNull(11);
              return;
           case 4 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 5 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 8 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              return;
           case 9 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((short[]) buf[5])[0] = rslt.getShort(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((bool[]) buf[9])[0] = rslt.getBool(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((short[]) buf[11])[0] = rslt.getShort(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((DateTime[]) buf[15])[0] = rslt.getGXDateTime(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((long[]) buf[17])[0] = rslt.getLong(10) ;
              ((long[]) buf[18])[0] = rslt.getLong(11) ;
              ((bool[]) buf[19])[0] = rslt.wasNull(11);
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
                 stmt.setNull( 2 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(2, (DateTime)parms[3]);
              }
              if ( (bool)parms[4] )
              {
                 stmt.setNull( 3 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(3, (short)parms[5]);
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
                 stmt.setNull( 5 , SqlDbType.Bit );
              }
              else
              {
                 stmt.SetParameter(5, (bool)parms[9]);
              }
              if ( (bool)parms[10] )
              {
                 stmt.setNull( 6 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(6, (short)parms[11]);
              }
              if ( (bool)parms[12] )
              {
                 stmt.setNull( 7 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(7, (String)parms[13]);
              }
              if ( (bool)parms[14] )
              {
                 stmt.setNull( 8 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(8, (DateTime)parms[15]);
              }
              stmt.SetParameter(9, (long)parms[16]);
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
                 stmt.setNull( 2 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(2, (DateTime)parms[3]);
              }
              if ( (bool)parms[4] )
              {
                 stmt.setNull( 3 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(3, (short)parms[5]);
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
                 stmt.setNull( 5 , SqlDbType.Bit );
              }
              else
              {
                 stmt.SetParameter(5, (bool)parms[9]);
              }
              if ( (bool)parms[10] )
              {
                 stmt.setNull( 6 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(6, (short)parms[11]);
              }
              if ( (bool)parms[12] )
              {
                 stmt.setNull( 7 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(7, (String)parms[13]);
              }
              if ( (bool)parms[14] )
              {
                 stmt.setNull( 8 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(8, (DateTime)parms[15]);
              }
              stmt.SetParameter(9, (long)parms[16]);
              stmt.SetParameter(10, (long)parms[17]);
              return;
           case 7 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 8 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 9 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
     }
  }

}

}
