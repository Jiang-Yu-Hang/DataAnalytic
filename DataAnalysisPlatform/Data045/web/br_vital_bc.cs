/*
               File: BR_Vital_BC
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:7:16.21
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
   public class br_vital_bc : GXHttpHandler, IGxSilentTrn
   {
      public br_vital_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_vital_bc( IGxContext context )
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
         ReadRow0J20( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey0J20( ) ;
         standaloneModal( ) ;
         AddRow0J20( ) ;
         Gx_mode = "INS";
         return  ;
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E110J2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               Z150BR_VitalID = A150BR_VitalID;
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

      protected void CONFIRM_0J0( )
      {
         BeforeValidate0J20( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0J20( ) ;
            }
            else
            {
               CheckExtendedTable0J20( ) ;
               if ( AnyError == 0 )
               {
                  ZM0J20( 9) ;
                  ZM0J20( 10) ;
               }
               CloseExtendedTableCursors0J20( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void E120J2( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV7WWPContext) ;
         AV13IsAuthorized = true;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            GXt_boolean1 = AV13IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Vital", out  GXt_boolean1) ;
            AV13IsAuthorized = GXt_boolean1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            GXt_boolean1 = AV13IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Vital", out  GXt_boolean1) ;
            AV13IsAuthorized = GXt_boolean1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            GXt_boolean1 = AV13IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Vital", out  GXt_boolean1) ;
            AV13IsAuthorized = GXt_boolean1;
         }
         if ( ! AV13IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV16Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV8TrnContext.FromXml(AV9WebSession.Get("TrnContext"), null, "WWPTransactionContext", "DataAnalysisPlatform");
         if ( ( StringUtil.StrCmp(AV8TrnContext.gxTpr_Transactionname, AV16Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV17GXV1 = 1;
            while ( AV17GXV1 <= AV8TrnContext.gxTpr_Attributes.Count )
            {
               AV11TrnContextAtt = ((GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute)AV8TrnContext.gxTpr_Attributes.Item(AV17GXV1));
               if ( StringUtil.StrCmp(AV11TrnContextAtt.gxTpr_Attributename, "BR_EncounterID") == 0 )
               {
                  AV10Insert_BR_EncounterID = (long)(NumberUtil.Val( AV11TrnContextAtt.gxTpr_Attributevalue, "."));
               }
               AV17GXV1 = (int)(AV17GXV1+1);
            }
         }
      }

      protected void E110J2( )
      {
         /* After Trn Routine */
      }

      protected void ZM0J20( short GX_JID )
      {
         if ( ( GX_JID == 8 ) || ( GX_JID == 0 ) )
         {
            Z151BR_Vital_VitalID = A151BR_Vital_VitalID;
            Z152BR_Vital_MeasureDate = A152BR_Vital_MeasureDate;
            Z153BR_Vital_Temperature = A153BR_Vital_Temperature;
            Z154BR_Vital_Pulse = A154BR_Vital_Pulse;
            Z155BR_Vital_Respiration = A155BR_Vital_Respiration;
            Z156BR_Vital_Systolic = A156BR_Vital_Systolic;
            Z157BR_Vital_Diastolic = A157BR_Vital_Diastolic;
            Z158BR_Vital_Height = A158BR_Vital_Height;
            Z159BR_Vital_Weight = A159BR_Vital_Weight;
            Z19BR_EncounterID = A19BR_EncounterID;
         }
         if ( ( GX_JID == 9 ) || ( GX_JID == 0 ) )
         {
            Z85BR_Information_ID = A85BR_Information_ID;
         }
         if ( ( GX_JID == 10 ) || ( GX_JID == 0 ) )
         {
            Z36BR_Information_PatientNo = A36BR_Information_PatientNo;
         }
         if ( GX_JID == -8 )
         {
            Z150BR_VitalID = A150BR_VitalID;
            Z151BR_Vital_VitalID = A151BR_Vital_VitalID;
            Z152BR_Vital_MeasureDate = A152BR_Vital_MeasureDate;
            Z153BR_Vital_Temperature = A153BR_Vital_Temperature;
            Z154BR_Vital_Pulse = A154BR_Vital_Pulse;
            Z155BR_Vital_Respiration = A155BR_Vital_Respiration;
            Z156BR_Vital_Systolic = A156BR_Vital_Systolic;
            Z157BR_Vital_Diastolic = A157BR_Vital_Diastolic;
            Z158BR_Vital_Height = A158BR_Vital_Height;
            Z159BR_Vital_Weight = A159BR_Vital_Weight;
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

      protected void Load0J20( )
      {
         /* Using cursor BC000J6 */
         pr_default.execute(4, new Object[] {A150BR_VitalID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound20 = 1;
            A85BR_Information_ID = BC000J6_A85BR_Information_ID[0];
            n85BR_Information_ID = BC000J6_n85BR_Information_ID[0];
            A36BR_Information_PatientNo = BC000J6_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = BC000J6_n36BR_Information_PatientNo[0];
            A151BR_Vital_VitalID = BC000J6_A151BR_Vital_VitalID[0];
            n151BR_Vital_VitalID = BC000J6_n151BR_Vital_VitalID[0];
            A152BR_Vital_MeasureDate = BC000J6_A152BR_Vital_MeasureDate[0];
            n152BR_Vital_MeasureDate = BC000J6_n152BR_Vital_MeasureDate[0];
            A153BR_Vital_Temperature = BC000J6_A153BR_Vital_Temperature[0];
            n153BR_Vital_Temperature = BC000J6_n153BR_Vital_Temperature[0];
            A154BR_Vital_Pulse = BC000J6_A154BR_Vital_Pulse[0];
            n154BR_Vital_Pulse = BC000J6_n154BR_Vital_Pulse[0];
            A155BR_Vital_Respiration = BC000J6_A155BR_Vital_Respiration[0];
            n155BR_Vital_Respiration = BC000J6_n155BR_Vital_Respiration[0];
            A156BR_Vital_Systolic = BC000J6_A156BR_Vital_Systolic[0];
            n156BR_Vital_Systolic = BC000J6_n156BR_Vital_Systolic[0];
            A157BR_Vital_Diastolic = BC000J6_A157BR_Vital_Diastolic[0];
            n157BR_Vital_Diastolic = BC000J6_n157BR_Vital_Diastolic[0];
            A158BR_Vital_Height = BC000J6_A158BR_Vital_Height[0];
            n158BR_Vital_Height = BC000J6_n158BR_Vital_Height[0];
            A159BR_Vital_Weight = BC000J6_A159BR_Vital_Weight[0];
            n159BR_Vital_Weight = BC000J6_n159BR_Vital_Weight[0];
            A19BR_EncounterID = BC000J6_A19BR_EncounterID[0];
            ZM0J20( -8) ;
         }
         pr_default.close(4);
         OnLoadActions0J20( ) ;
      }

      protected void OnLoadActions0J20( )
      {
         AV16Pgmname = "BR_Vital_BC";
      }

      protected void CheckExtendedTable0J20( )
      {
         standaloneModal( ) ;
         AV16Pgmname = "BR_Vital_BC";
         /* Using cursor BC000J4 */
         pr_default.execute(2, new Object[] {A19BR_EncounterID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("不匹配' T15'", "ForeignKeyNotFound", 1, "BR_ENCOUNTERID");
            AnyError = 1;
         }
         A85BR_Information_ID = BC000J4_A85BR_Information_ID[0];
         n85BR_Information_ID = BC000J4_n85BR_Information_ID[0];
         pr_default.close(2);
         /* Using cursor BC000J5 */
         pr_default.execute(3, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
         if ( (pr_default.getStatus(3) == 101) )
         {
            if ( ! ( (0==A85BR_Information_ID) ) )
            {
               GX_msglist.addItem("不匹配' T16'", "ForeignKeyNotFound", 1, "");
               AnyError = 1;
            }
         }
         A36BR_Information_PatientNo = BC000J5_A36BR_Information_PatientNo[0];
         n36BR_Information_PatientNo = BC000J5_n36BR_Information_PatientNo[0];
         pr_default.close(3);
         if ( ! ( (DateTime.MinValue==A152BR_Vital_MeasureDate) || ( A152BR_Vital_MeasureDate >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("域测量日期超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
         if ( (DateTime.MinValue==A152BR_Vital_MeasureDate) )
         {
            GX_msglist.addItem("测量日期是必须填写的。", 1, "");
            AnyError = 1;
         }
      }

      protected void CloseExtendedTableCursors0J20( )
      {
         pr_default.close(2);
         pr_default.close(3);
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0J20( )
      {
         /* Using cursor BC000J7 */
         pr_default.execute(5, new Object[] {A150BR_VitalID});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound20 = 1;
         }
         else
         {
            RcdFound20 = 0;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC000J3 */
         pr_default.execute(1, new Object[] {A150BR_VitalID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0J20( 8) ;
            RcdFound20 = 1;
            A150BR_VitalID = BC000J3_A150BR_VitalID[0];
            A151BR_Vital_VitalID = BC000J3_A151BR_Vital_VitalID[0];
            n151BR_Vital_VitalID = BC000J3_n151BR_Vital_VitalID[0];
            A152BR_Vital_MeasureDate = BC000J3_A152BR_Vital_MeasureDate[0];
            n152BR_Vital_MeasureDate = BC000J3_n152BR_Vital_MeasureDate[0];
            A153BR_Vital_Temperature = BC000J3_A153BR_Vital_Temperature[0];
            n153BR_Vital_Temperature = BC000J3_n153BR_Vital_Temperature[0];
            A154BR_Vital_Pulse = BC000J3_A154BR_Vital_Pulse[0];
            n154BR_Vital_Pulse = BC000J3_n154BR_Vital_Pulse[0];
            A155BR_Vital_Respiration = BC000J3_A155BR_Vital_Respiration[0];
            n155BR_Vital_Respiration = BC000J3_n155BR_Vital_Respiration[0];
            A156BR_Vital_Systolic = BC000J3_A156BR_Vital_Systolic[0];
            n156BR_Vital_Systolic = BC000J3_n156BR_Vital_Systolic[0];
            A157BR_Vital_Diastolic = BC000J3_A157BR_Vital_Diastolic[0];
            n157BR_Vital_Diastolic = BC000J3_n157BR_Vital_Diastolic[0];
            A158BR_Vital_Height = BC000J3_A158BR_Vital_Height[0];
            n158BR_Vital_Height = BC000J3_n158BR_Vital_Height[0];
            A159BR_Vital_Weight = BC000J3_A159BR_Vital_Weight[0];
            n159BR_Vital_Weight = BC000J3_n159BR_Vital_Weight[0];
            A19BR_EncounterID = BC000J3_A19BR_EncounterID[0];
            Z150BR_VitalID = A150BR_VitalID;
            sMode20 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load0J20( ) ;
            if ( AnyError == 1 )
            {
               RcdFound20 = 0;
               InitializeNonKey0J20( ) ;
            }
            Gx_mode = sMode20;
         }
         else
         {
            RcdFound20 = 0;
            InitializeNonKey0J20( ) ;
            sMode20 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode20;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0J20( ) ;
         if ( RcdFound20 == 0 )
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
         CONFIRM_0J0( ) ;
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

      protected void CheckOptimisticConcurrency0J20( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC000J2 */
            pr_default.execute(0, new Object[] {A150BR_VitalID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Vital"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( Z151BR_Vital_VitalID != BC000J2_A151BR_Vital_VitalID[0] ) || ( Z152BR_Vital_MeasureDate != BC000J2_A152BR_Vital_MeasureDate[0] ) || ( Z153BR_Vital_Temperature != BC000J2_A153BR_Vital_Temperature[0] ) || ( Z154BR_Vital_Pulse != BC000J2_A154BR_Vital_Pulse[0] ) || ( Z155BR_Vital_Respiration != BC000J2_A155BR_Vital_Respiration[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z156BR_Vital_Systolic != BC000J2_A156BR_Vital_Systolic[0] ) || ( Z157BR_Vital_Diastolic != BC000J2_A157BR_Vital_Diastolic[0] ) || ( Z158BR_Vital_Height != BC000J2_A158BR_Vital_Height[0] ) || ( Z159BR_Vital_Weight != BC000J2_A159BR_Vital_Weight[0] ) || ( Z19BR_EncounterID != BC000J2_A19BR_EncounterID[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"BR_Vital"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0J20( )
      {
         BeforeValidate0J20( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0J20( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0J20( 0) ;
            CheckOptimisticConcurrency0J20( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0J20( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0J20( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000J8 */
                     pr_default.execute(6, new Object[] {n151BR_Vital_VitalID, A151BR_Vital_VitalID, n152BR_Vital_MeasureDate, A152BR_Vital_MeasureDate, n153BR_Vital_Temperature, A153BR_Vital_Temperature, n154BR_Vital_Pulse, A154BR_Vital_Pulse, n155BR_Vital_Respiration, A155BR_Vital_Respiration, n156BR_Vital_Systolic, A156BR_Vital_Systolic, n157BR_Vital_Diastolic, A157BR_Vital_Diastolic, n158BR_Vital_Height, A158BR_Vital_Height, n159BR_Vital_Weight, A159BR_Vital_Weight, A19BR_EncounterID});
                     A150BR_VitalID = BC000J8_A150BR_VitalID[0];
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Vital") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(A150BR_VitalID), 18, 0)),  "生命体征",  "Create",  1) ;
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
               Load0J20( ) ;
            }
            EndLevel0J20( ) ;
         }
         CloseExtendedTableCursors0J20( ) ;
      }

      protected void Update0J20( )
      {
         BeforeValidate0J20( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0J20( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0J20( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0J20( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0J20( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000J9 */
                     pr_default.execute(7, new Object[] {n151BR_Vital_VitalID, A151BR_Vital_VitalID, n152BR_Vital_MeasureDate, A152BR_Vital_MeasureDate, n153BR_Vital_Temperature, A153BR_Vital_Temperature, n154BR_Vital_Pulse, A154BR_Vital_Pulse, n155BR_Vital_Respiration, A155BR_Vital_Respiration, n156BR_Vital_Systolic, A156BR_Vital_Systolic, n157BR_Vital_Diastolic, A157BR_Vital_Diastolic, n158BR_Vital_Height, A158BR_Vital_Height, n159BR_Vital_Weight, A159BR_Vital_Weight, A19BR_EncounterID, A150BR_VitalID});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Vital") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Vital"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0J20( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(A150BR_VitalID), 18, 0)),  "生命体征",  "Update",  1) ;
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
            EndLevel0J20( ) ;
         }
         CloseExtendedTableCursors0J20( ) ;
      }

      protected void DeferredUpdate0J20( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate0J20( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0J20( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0J20( ) ;
            AfterConfirm0J20( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0J20( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC000J10 */
                  pr_default.execute(8, new Object[] {A150BR_VitalID});
                  pr_default.close(8);
                  dsDefault.SmartCacheProvider.SetUpdated("BR_Vital") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(A150BR_VitalID), 18, 0)),  "生命体征",  "Delete",  1) ;
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
         sMode20 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel0J20( ) ;
         Gx_mode = sMode20;
      }

      protected void OnDeleteControls0J20( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV16Pgmname = "BR_Vital_BC";
            /* Using cursor BC000J11 */
            pr_default.execute(9, new Object[] {A19BR_EncounterID});
            A85BR_Information_ID = BC000J11_A85BR_Information_ID[0];
            n85BR_Information_ID = BC000J11_n85BR_Information_ID[0];
            pr_default.close(9);
            /* Using cursor BC000J12 */
            pr_default.execute(10, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
            A36BR_Information_PatientNo = BC000J12_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = BC000J12_n36BR_Information_PatientNo[0];
            pr_default.close(10);
         }
      }

      protected void EndLevel0J20( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0J20( ) ;
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

      public void ScanKeyStart0J20( )
      {
         /* Scan By routine */
         /* Using cursor BC000J13 */
         pr_default.execute(11, new Object[] {A150BR_VitalID});
         RcdFound20 = 0;
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound20 = 1;
            A85BR_Information_ID = BC000J13_A85BR_Information_ID[0];
            n85BR_Information_ID = BC000J13_n85BR_Information_ID[0];
            A150BR_VitalID = BC000J13_A150BR_VitalID[0];
            A36BR_Information_PatientNo = BC000J13_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = BC000J13_n36BR_Information_PatientNo[0];
            A151BR_Vital_VitalID = BC000J13_A151BR_Vital_VitalID[0];
            n151BR_Vital_VitalID = BC000J13_n151BR_Vital_VitalID[0];
            A152BR_Vital_MeasureDate = BC000J13_A152BR_Vital_MeasureDate[0];
            n152BR_Vital_MeasureDate = BC000J13_n152BR_Vital_MeasureDate[0];
            A153BR_Vital_Temperature = BC000J13_A153BR_Vital_Temperature[0];
            n153BR_Vital_Temperature = BC000J13_n153BR_Vital_Temperature[0];
            A154BR_Vital_Pulse = BC000J13_A154BR_Vital_Pulse[0];
            n154BR_Vital_Pulse = BC000J13_n154BR_Vital_Pulse[0];
            A155BR_Vital_Respiration = BC000J13_A155BR_Vital_Respiration[0];
            n155BR_Vital_Respiration = BC000J13_n155BR_Vital_Respiration[0];
            A156BR_Vital_Systolic = BC000J13_A156BR_Vital_Systolic[0];
            n156BR_Vital_Systolic = BC000J13_n156BR_Vital_Systolic[0];
            A157BR_Vital_Diastolic = BC000J13_A157BR_Vital_Diastolic[0];
            n157BR_Vital_Diastolic = BC000J13_n157BR_Vital_Diastolic[0];
            A158BR_Vital_Height = BC000J13_A158BR_Vital_Height[0];
            n158BR_Vital_Height = BC000J13_n158BR_Vital_Height[0];
            A159BR_Vital_Weight = BC000J13_A159BR_Vital_Weight[0];
            n159BR_Vital_Weight = BC000J13_n159BR_Vital_Weight[0];
            A19BR_EncounterID = BC000J13_A19BR_EncounterID[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext0J20( )
      {
         /* Scan next routine */
         pr_default.readNext(11);
         RcdFound20 = 0;
         ScanKeyLoad0J20( ) ;
      }

      protected void ScanKeyLoad0J20( )
      {
         sMode20 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound20 = 1;
            A85BR_Information_ID = BC000J13_A85BR_Information_ID[0];
            n85BR_Information_ID = BC000J13_n85BR_Information_ID[0];
            A150BR_VitalID = BC000J13_A150BR_VitalID[0];
            A36BR_Information_PatientNo = BC000J13_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = BC000J13_n36BR_Information_PatientNo[0];
            A151BR_Vital_VitalID = BC000J13_A151BR_Vital_VitalID[0];
            n151BR_Vital_VitalID = BC000J13_n151BR_Vital_VitalID[0];
            A152BR_Vital_MeasureDate = BC000J13_A152BR_Vital_MeasureDate[0];
            n152BR_Vital_MeasureDate = BC000J13_n152BR_Vital_MeasureDate[0];
            A153BR_Vital_Temperature = BC000J13_A153BR_Vital_Temperature[0];
            n153BR_Vital_Temperature = BC000J13_n153BR_Vital_Temperature[0];
            A154BR_Vital_Pulse = BC000J13_A154BR_Vital_Pulse[0];
            n154BR_Vital_Pulse = BC000J13_n154BR_Vital_Pulse[0];
            A155BR_Vital_Respiration = BC000J13_A155BR_Vital_Respiration[0];
            n155BR_Vital_Respiration = BC000J13_n155BR_Vital_Respiration[0];
            A156BR_Vital_Systolic = BC000J13_A156BR_Vital_Systolic[0];
            n156BR_Vital_Systolic = BC000J13_n156BR_Vital_Systolic[0];
            A157BR_Vital_Diastolic = BC000J13_A157BR_Vital_Diastolic[0];
            n157BR_Vital_Diastolic = BC000J13_n157BR_Vital_Diastolic[0];
            A158BR_Vital_Height = BC000J13_A158BR_Vital_Height[0];
            n158BR_Vital_Height = BC000J13_n158BR_Vital_Height[0];
            A159BR_Vital_Weight = BC000J13_A159BR_Vital_Weight[0];
            n159BR_Vital_Weight = BC000J13_n159BR_Vital_Weight[0];
            A19BR_EncounterID = BC000J13_A19BR_EncounterID[0];
         }
         Gx_mode = sMode20;
      }

      protected void ScanKeyEnd0J20( )
      {
         pr_default.close(11);
      }

      protected void AfterConfirm0J20( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0J20( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0J20( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0J20( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0J20( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0J20( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0J20( )
      {
      }

      protected void send_integrity_lvl_hashes0J20( )
      {
      }

      protected void AddRow0J20( )
      {
         VarsToRow20( bcBR_Vital) ;
      }

      protected void ReadRow0J20( )
      {
         RowToVars20( bcBR_Vital, 1) ;
      }

      protected void InitializeNonKey0J20( )
      {
         A85BR_Information_ID = 0;
         n85BR_Information_ID = false;
         A19BR_EncounterID = 0;
         A36BR_Information_PatientNo = "";
         n36BR_Information_PatientNo = false;
         A151BR_Vital_VitalID = 0;
         n151BR_Vital_VitalID = false;
         A152BR_Vital_MeasureDate = DateTime.MinValue;
         n152BR_Vital_MeasureDate = false;
         A153BR_Vital_Temperature = 0;
         n153BR_Vital_Temperature = false;
         A154BR_Vital_Pulse = 0;
         n154BR_Vital_Pulse = false;
         A155BR_Vital_Respiration = 0;
         n155BR_Vital_Respiration = false;
         A156BR_Vital_Systolic = 0;
         n156BR_Vital_Systolic = false;
         A157BR_Vital_Diastolic = 0;
         n157BR_Vital_Diastolic = false;
         A158BR_Vital_Height = 0;
         n158BR_Vital_Height = false;
         A159BR_Vital_Weight = 0;
         n159BR_Vital_Weight = false;
         Z151BR_Vital_VitalID = 0;
         Z152BR_Vital_MeasureDate = DateTime.MinValue;
         Z153BR_Vital_Temperature = 0;
         Z154BR_Vital_Pulse = 0;
         Z155BR_Vital_Respiration = 0;
         Z156BR_Vital_Systolic = 0;
         Z157BR_Vital_Diastolic = 0;
         Z158BR_Vital_Height = 0;
         Z159BR_Vital_Weight = 0;
         Z19BR_EncounterID = 0;
      }

      protected void InitAll0J20( )
      {
         A150BR_VitalID = 0;
         InitializeNonKey0J20( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow20( SdtBR_Vital obj20 )
      {
         obj20.gxTpr_Mode = Gx_mode;
         obj20.gxTpr_Br_encounterid = A19BR_EncounterID;
         obj20.gxTpr_Br_information_patientno = A36BR_Information_PatientNo;
         obj20.gxTpr_Br_vital_vitalid = A151BR_Vital_VitalID;
         obj20.gxTpr_Br_vital_measuredate = A152BR_Vital_MeasureDate;
         obj20.gxTpr_Br_vital_temperature = A153BR_Vital_Temperature;
         obj20.gxTpr_Br_vital_pulse = A154BR_Vital_Pulse;
         obj20.gxTpr_Br_vital_respiration = A155BR_Vital_Respiration;
         obj20.gxTpr_Br_vital_systolic = A156BR_Vital_Systolic;
         obj20.gxTpr_Br_vital_diastolic = A157BR_Vital_Diastolic;
         obj20.gxTpr_Br_vital_height = A158BR_Vital_Height;
         obj20.gxTpr_Br_vital_weight = A159BR_Vital_Weight;
         obj20.gxTpr_Br_vitalid = A150BR_VitalID;
         obj20.gxTpr_Br_vitalid_Z = Z150BR_VitalID;
         obj20.gxTpr_Br_encounterid_Z = Z19BR_EncounterID;
         obj20.gxTpr_Br_information_patientno_Z = Z36BR_Information_PatientNo;
         obj20.gxTpr_Br_vital_vitalid_Z = Z151BR_Vital_VitalID;
         obj20.gxTpr_Br_vital_measuredate_Z = Z152BR_Vital_MeasureDate;
         obj20.gxTpr_Br_vital_temperature_Z = Z153BR_Vital_Temperature;
         obj20.gxTpr_Br_vital_pulse_Z = Z154BR_Vital_Pulse;
         obj20.gxTpr_Br_vital_respiration_Z = Z155BR_Vital_Respiration;
         obj20.gxTpr_Br_vital_systolic_Z = Z156BR_Vital_Systolic;
         obj20.gxTpr_Br_vital_diastolic_Z = Z157BR_Vital_Diastolic;
         obj20.gxTpr_Br_vital_height_Z = Z158BR_Vital_Height;
         obj20.gxTpr_Br_vital_weight_Z = Z159BR_Vital_Weight;
         obj20.gxTpr_Br_information_patientno_N = (short)(Convert.ToInt16(n36BR_Information_PatientNo));
         obj20.gxTpr_Br_vital_vitalid_N = (short)(Convert.ToInt16(n151BR_Vital_VitalID));
         obj20.gxTpr_Br_vital_measuredate_N = (short)(Convert.ToInt16(n152BR_Vital_MeasureDate));
         obj20.gxTpr_Br_vital_temperature_N = (short)(Convert.ToInt16(n153BR_Vital_Temperature));
         obj20.gxTpr_Br_vital_pulse_N = (short)(Convert.ToInt16(n154BR_Vital_Pulse));
         obj20.gxTpr_Br_vital_respiration_N = (short)(Convert.ToInt16(n155BR_Vital_Respiration));
         obj20.gxTpr_Br_vital_systolic_N = (short)(Convert.ToInt16(n156BR_Vital_Systolic));
         obj20.gxTpr_Br_vital_diastolic_N = (short)(Convert.ToInt16(n157BR_Vital_Diastolic));
         obj20.gxTpr_Br_vital_height_N = (short)(Convert.ToInt16(n158BR_Vital_Height));
         obj20.gxTpr_Br_vital_weight_N = (short)(Convert.ToInt16(n159BR_Vital_Weight));
         obj20.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow20( SdtBR_Vital obj20 )
      {
         obj20.gxTpr_Br_vitalid = A150BR_VitalID;
         return  ;
      }

      public void RowToVars20( SdtBR_Vital obj20 ,
                               int forceLoad )
      {
         Gx_mode = obj20.gxTpr_Mode;
         A19BR_EncounterID = obj20.gxTpr_Br_encounterid;
         A36BR_Information_PatientNo = obj20.gxTpr_Br_information_patientno;
         n36BR_Information_PatientNo = false;
         A151BR_Vital_VitalID = obj20.gxTpr_Br_vital_vitalid;
         n151BR_Vital_VitalID = false;
         A152BR_Vital_MeasureDate = obj20.gxTpr_Br_vital_measuredate;
         n152BR_Vital_MeasureDate = false;
         A153BR_Vital_Temperature = obj20.gxTpr_Br_vital_temperature;
         n153BR_Vital_Temperature = false;
         A154BR_Vital_Pulse = obj20.gxTpr_Br_vital_pulse;
         n154BR_Vital_Pulse = false;
         A155BR_Vital_Respiration = obj20.gxTpr_Br_vital_respiration;
         n155BR_Vital_Respiration = false;
         A156BR_Vital_Systolic = obj20.gxTpr_Br_vital_systolic;
         n156BR_Vital_Systolic = false;
         A157BR_Vital_Diastolic = obj20.gxTpr_Br_vital_diastolic;
         n157BR_Vital_Diastolic = false;
         A158BR_Vital_Height = obj20.gxTpr_Br_vital_height;
         n158BR_Vital_Height = false;
         A159BR_Vital_Weight = obj20.gxTpr_Br_vital_weight;
         n159BR_Vital_Weight = false;
         A150BR_VitalID = obj20.gxTpr_Br_vitalid;
         Z150BR_VitalID = obj20.gxTpr_Br_vitalid_Z;
         Z19BR_EncounterID = obj20.gxTpr_Br_encounterid_Z;
         Z36BR_Information_PatientNo = obj20.gxTpr_Br_information_patientno_Z;
         Z151BR_Vital_VitalID = obj20.gxTpr_Br_vital_vitalid_Z;
         Z152BR_Vital_MeasureDate = obj20.gxTpr_Br_vital_measuredate_Z;
         Z153BR_Vital_Temperature = obj20.gxTpr_Br_vital_temperature_Z;
         Z154BR_Vital_Pulse = obj20.gxTpr_Br_vital_pulse_Z;
         Z155BR_Vital_Respiration = obj20.gxTpr_Br_vital_respiration_Z;
         Z156BR_Vital_Systolic = obj20.gxTpr_Br_vital_systolic_Z;
         Z157BR_Vital_Diastolic = obj20.gxTpr_Br_vital_diastolic_Z;
         Z158BR_Vital_Height = obj20.gxTpr_Br_vital_height_Z;
         Z159BR_Vital_Weight = obj20.gxTpr_Br_vital_weight_Z;
         n36BR_Information_PatientNo = (bool)(Convert.ToBoolean(obj20.gxTpr_Br_information_patientno_N));
         n151BR_Vital_VitalID = (bool)(Convert.ToBoolean(obj20.gxTpr_Br_vital_vitalid_N));
         n152BR_Vital_MeasureDate = (bool)(Convert.ToBoolean(obj20.gxTpr_Br_vital_measuredate_N));
         n153BR_Vital_Temperature = (bool)(Convert.ToBoolean(obj20.gxTpr_Br_vital_temperature_N));
         n154BR_Vital_Pulse = (bool)(Convert.ToBoolean(obj20.gxTpr_Br_vital_pulse_N));
         n155BR_Vital_Respiration = (bool)(Convert.ToBoolean(obj20.gxTpr_Br_vital_respiration_N));
         n156BR_Vital_Systolic = (bool)(Convert.ToBoolean(obj20.gxTpr_Br_vital_systolic_N));
         n157BR_Vital_Diastolic = (bool)(Convert.ToBoolean(obj20.gxTpr_Br_vital_diastolic_N));
         n158BR_Vital_Height = (bool)(Convert.ToBoolean(obj20.gxTpr_Br_vital_height_N));
         n159BR_Vital_Weight = (bool)(Convert.ToBoolean(obj20.gxTpr_Br_vital_weight_N));
         Gx_mode = obj20.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A150BR_VitalID = (long)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey0J20( ) ;
         ScanKeyStart0J20( ) ;
         if ( RcdFound20 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z150BR_VitalID = A150BR_VitalID;
         }
         ZM0J20( -8) ;
         OnLoadActions0J20( ) ;
         AddRow0J20( ) ;
         ScanKeyEnd0J20( ) ;
         if ( RcdFound20 == 0 )
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
         RowToVars20( bcBR_Vital, 0) ;
         ScanKeyStart0J20( ) ;
         if ( RcdFound20 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z150BR_VitalID = A150BR_VitalID;
         }
         ZM0J20( -8) ;
         OnLoadActions0J20( ) ;
         AddRow0J20( ) ;
         ScanKeyEnd0J20( ) ;
         if ( RcdFound20 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey0J20( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert0J20( ) ;
         }
         else
         {
            if ( RcdFound20 == 1 )
            {
               if ( A150BR_VitalID != Z150BR_VitalID )
               {
                  A150BR_VitalID = Z150BR_VitalID;
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
                  Update0J20( ) ;
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
                  if ( A150BR_VitalID != Z150BR_VitalID )
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
                        Insert0J20( ) ;
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
                        Insert0J20( ) ;
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
         RowToVars20( bcBR_Vital, 0) ;
         SaveImpl( ) ;
         VarsToRow20( bcBR_Vital) ;
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
         RowToVars20( bcBR_Vital, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert0J20( ) ;
         AfterTrn( ) ;
         VarsToRow20( bcBR_Vital) ;
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
            SdtBR_Vital auxBC = new SdtBR_Vital(context) ;
            auxBC.Load(A150BR_VitalID);
            auxBC.UpdateDirties(bcBR_Vital);
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
         RowToVars20( bcBR_Vital, 0) ;
         UpdateImpl( ) ;
         VarsToRow20( bcBR_Vital) ;
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
         RowToVars20( bcBR_Vital, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert0J20( ) ;
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
         VarsToRow20( bcBR_Vital) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars20( bcBR_Vital, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey0J20( ) ;
         if ( RcdFound20 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A150BR_VitalID != Z150BR_VitalID )
            {
               A150BR_VitalID = Z150BR_VitalID;
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
            if ( A150BR_VitalID != Z150BR_VitalID )
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
         context.RollbackDataStores("br_vital_bc",pr_default);
         VarsToRow20( bcBR_Vital) ;
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
         Gx_mode = bcBR_Vital.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcBR_Vital.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcBR_Vital )
         {
            bcBR_Vital = (SdtBR_Vital)(sdt);
            if ( StringUtil.StrCmp(bcBR_Vital.gxTpr_Mode, "") == 0 )
            {
               bcBR_Vital.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow20( bcBR_Vital) ;
            }
            else
            {
               RowToVars20( bcBR_Vital, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcBR_Vital.gxTpr_Mode, "") == 0 )
            {
               bcBR_Vital.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars20( bcBR_Vital, 1) ;
         return  ;
      }

      public SdtBR_Vital BR_Vital_BC
      {
         get {
            return bcBR_Vital ;
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
         AV16Pgmname = "";
         AV8TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9WebSession = context.GetSession();
         AV11TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         Z152BR_Vital_MeasureDate = DateTime.MinValue;
         A152BR_Vital_MeasureDate = DateTime.MinValue;
         Z36BR_Information_PatientNo = "";
         A36BR_Information_PatientNo = "";
         BC000J6_A85BR_Information_ID = new long[1] ;
         BC000J6_n85BR_Information_ID = new bool[] {false} ;
         BC000J6_A150BR_VitalID = new long[1] ;
         BC000J6_A36BR_Information_PatientNo = new String[] {""} ;
         BC000J6_n36BR_Information_PatientNo = new bool[] {false} ;
         BC000J6_A151BR_Vital_VitalID = new long[1] ;
         BC000J6_n151BR_Vital_VitalID = new bool[] {false} ;
         BC000J6_A152BR_Vital_MeasureDate = new DateTime[] {DateTime.MinValue} ;
         BC000J6_n152BR_Vital_MeasureDate = new bool[] {false} ;
         BC000J6_A153BR_Vital_Temperature = new decimal[1] ;
         BC000J6_n153BR_Vital_Temperature = new bool[] {false} ;
         BC000J6_A154BR_Vital_Pulse = new decimal[1] ;
         BC000J6_n154BR_Vital_Pulse = new bool[] {false} ;
         BC000J6_A155BR_Vital_Respiration = new decimal[1] ;
         BC000J6_n155BR_Vital_Respiration = new bool[] {false} ;
         BC000J6_A156BR_Vital_Systolic = new decimal[1] ;
         BC000J6_n156BR_Vital_Systolic = new bool[] {false} ;
         BC000J6_A157BR_Vital_Diastolic = new decimal[1] ;
         BC000J6_n157BR_Vital_Diastolic = new bool[] {false} ;
         BC000J6_A158BR_Vital_Height = new decimal[1] ;
         BC000J6_n158BR_Vital_Height = new bool[] {false} ;
         BC000J6_A159BR_Vital_Weight = new decimal[1] ;
         BC000J6_n159BR_Vital_Weight = new bool[] {false} ;
         BC000J6_A19BR_EncounterID = new long[1] ;
         BC000J4_A85BR_Information_ID = new long[1] ;
         BC000J4_n85BR_Information_ID = new bool[] {false} ;
         BC000J5_A36BR_Information_PatientNo = new String[] {""} ;
         BC000J5_n36BR_Information_PatientNo = new bool[] {false} ;
         BC000J7_A150BR_VitalID = new long[1] ;
         BC000J3_A150BR_VitalID = new long[1] ;
         BC000J3_A151BR_Vital_VitalID = new long[1] ;
         BC000J3_n151BR_Vital_VitalID = new bool[] {false} ;
         BC000J3_A152BR_Vital_MeasureDate = new DateTime[] {DateTime.MinValue} ;
         BC000J3_n152BR_Vital_MeasureDate = new bool[] {false} ;
         BC000J3_A153BR_Vital_Temperature = new decimal[1] ;
         BC000J3_n153BR_Vital_Temperature = new bool[] {false} ;
         BC000J3_A154BR_Vital_Pulse = new decimal[1] ;
         BC000J3_n154BR_Vital_Pulse = new bool[] {false} ;
         BC000J3_A155BR_Vital_Respiration = new decimal[1] ;
         BC000J3_n155BR_Vital_Respiration = new bool[] {false} ;
         BC000J3_A156BR_Vital_Systolic = new decimal[1] ;
         BC000J3_n156BR_Vital_Systolic = new bool[] {false} ;
         BC000J3_A157BR_Vital_Diastolic = new decimal[1] ;
         BC000J3_n157BR_Vital_Diastolic = new bool[] {false} ;
         BC000J3_A158BR_Vital_Height = new decimal[1] ;
         BC000J3_n158BR_Vital_Height = new bool[] {false} ;
         BC000J3_A159BR_Vital_Weight = new decimal[1] ;
         BC000J3_n159BR_Vital_Weight = new bool[] {false} ;
         BC000J3_A19BR_EncounterID = new long[1] ;
         sMode20 = "";
         BC000J2_A150BR_VitalID = new long[1] ;
         BC000J2_A151BR_Vital_VitalID = new long[1] ;
         BC000J2_n151BR_Vital_VitalID = new bool[] {false} ;
         BC000J2_A152BR_Vital_MeasureDate = new DateTime[] {DateTime.MinValue} ;
         BC000J2_n152BR_Vital_MeasureDate = new bool[] {false} ;
         BC000J2_A153BR_Vital_Temperature = new decimal[1] ;
         BC000J2_n153BR_Vital_Temperature = new bool[] {false} ;
         BC000J2_A154BR_Vital_Pulse = new decimal[1] ;
         BC000J2_n154BR_Vital_Pulse = new bool[] {false} ;
         BC000J2_A155BR_Vital_Respiration = new decimal[1] ;
         BC000J2_n155BR_Vital_Respiration = new bool[] {false} ;
         BC000J2_A156BR_Vital_Systolic = new decimal[1] ;
         BC000J2_n156BR_Vital_Systolic = new bool[] {false} ;
         BC000J2_A157BR_Vital_Diastolic = new decimal[1] ;
         BC000J2_n157BR_Vital_Diastolic = new bool[] {false} ;
         BC000J2_A158BR_Vital_Height = new decimal[1] ;
         BC000J2_n158BR_Vital_Height = new bool[] {false} ;
         BC000J2_A159BR_Vital_Weight = new decimal[1] ;
         BC000J2_n159BR_Vital_Weight = new bool[] {false} ;
         BC000J2_A19BR_EncounterID = new long[1] ;
         BC000J8_A150BR_VitalID = new long[1] ;
         BC000J11_A85BR_Information_ID = new long[1] ;
         BC000J11_n85BR_Information_ID = new bool[] {false} ;
         BC000J12_A36BR_Information_PatientNo = new String[] {""} ;
         BC000J12_n36BR_Information_PatientNo = new bool[] {false} ;
         BC000J13_A85BR_Information_ID = new long[1] ;
         BC000J13_n85BR_Information_ID = new bool[] {false} ;
         BC000J13_A150BR_VitalID = new long[1] ;
         BC000J13_A36BR_Information_PatientNo = new String[] {""} ;
         BC000J13_n36BR_Information_PatientNo = new bool[] {false} ;
         BC000J13_A151BR_Vital_VitalID = new long[1] ;
         BC000J13_n151BR_Vital_VitalID = new bool[] {false} ;
         BC000J13_A152BR_Vital_MeasureDate = new DateTime[] {DateTime.MinValue} ;
         BC000J13_n152BR_Vital_MeasureDate = new bool[] {false} ;
         BC000J13_A153BR_Vital_Temperature = new decimal[1] ;
         BC000J13_n153BR_Vital_Temperature = new bool[] {false} ;
         BC000J13_A154BR_Vital_Pulse = new decimal[1] ;
         BC000J13_n154BR_Vital_Pulse = new bool[] {false} ;
         BC000J13_A155BR_Vital_Respiration = new decimal[1] ;
         BC000J13_n155BR_Vital_Respiration = new bool[] {false} ;
         BC000J13_A156BR_Vital_Systolic = new decimal[1] ;
         BC000J13_n156BR_Vital_Systolic = new bool[] {false} ;
         BC000J13_A157BR_Vital_Diastolic = new decimal[1] ;
         BC000J13_n157BR_Vital_Diastolic = new bool[] {false} ;
         BC000J13_A158BR_Vital_Height = new decimal[1] ;
         BC000J13_n158BR_Vital_Height = new bool[] {false} ;
         BC000J13_A159BR_Vital_Weight = new decimal[1] ;
         BC000J13_n159BR_Vital_Weight = new bool[] {false} ;
         BC000J13_A19BR_EncounterID = new long[1] ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_vital_bc__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_vital_bc__default(),
            new Object[][] {
                new Object[] {
               BC000J2_A150BR_VitalID, BC000J2_A151BR_Vital_VitalID, BC000J2_n151BR_Vital_VitalID, BC000J2_A152BR_Vital_MeasureDate, BC000J2_n152BR_Vital_MeasureDate, BC000J2_A153BR_Vital_Temperature, BC000J2_n153BR_Vital_Temperature, BC000J2_A154BR_Vital_Pulse, BC000J2_n154BR_Vital_Pulse, BC000J2_A155BR_Vital_Respiration,
               BC000J2_n155BR_Vital_Respiration, BC000J2_A156BR_Vital_Systolic, BC000J2_n156BR_Vital_Systolic, BC000J2_A157BR_Vital_Diastolic, BC000J2_n157BR_Vital_Diastolic, BC000J2_A158BR_Vital_Height, BC000J2_n158BR_Vital_Height, BC000J2_A159BR_Vital_Weight, BC000J2_n159BR_Vital_Weight, BC000J2_A19BR_EncounterID
               }
               , new Object[] {
               BC000J3_A150BR_VitalID, BC000J3_A151BR_Vital_VitalID, BC000J3_n151BR_Vital_VitalID, BC000J3_A152BR_Vital_MeasureDate, BC000J3_n152BR_Vital_MeasureDate, BC000J3_A153BR_Vital_Temperature, BC000J3_n153BR_Vital_Temperature, BC000J3_A154BR_Vital_Pulse, BC000J3_n154BR_Vital_Pulse, BC000J3_A155BR_Vital_Respiration,
               BC000J3_n155BR_Vital_Respiration, BC000J3_A156BR_Vital_Systolic, BC000J3_n156BR_Vital_Systolic, BC000J3_A157BR_Vital_Diastolic, BC000J3_n157BR_Vital_Diastolic, BC000J3_A158BR_Vital_Height, BC000J3_n158BR_Vital_Height, BC000J3_A159BR_Vital_Weight, BC000J3_n159BR_Vital_Weight, BC000J3_A19BR_EncounterID
               }
               , new Object[] {
               BC000J4_A85BR_Information_ID, BC000J4_n85BR_Information_ID
               }
               , new Object[] {
               BC000J5_A36BR_Information_PatientNo, BC000J5_n36BR_Information_PatientNo
               }
               , new Object[] {
               BC000J6_A85BR_Information_ID, BC000J6_n85BR_Information_ID, BC000J6_A150BR_VitalID, BC000J6_A36BR_Information_PatientNo, BC000J6_n36BR_Information_PatientNo, BC000J6_A151BR_Vital_VitalID, BC000J6_n151BR_Vital_VitalID, BC000J6_A152BR_Vital_MeasureDate, BC000J6_n152BR_Vital_MeasureDate, BC000J6_A153BR_Vital_Temperature,
               BC000J6_n153BR_Vital_Temperature, BC000J6_A154BR_Vital_Pulse, BC000J6_n154BR_Vital_Pulse, BC000J6_A155BR_Vital_Respiration, BC000J6_n155BR_Vital_Respiration, BC000J6_A156BR_Vital_Systolic, BC000J6_n156BR_Vital_Systolic, BC000J6_A157BR_Vital_Diastolic, BC000J6_n157BR_Vital_Diastolic, BC000J6_A158BR_Vital_Height,
               BC000J6_n158BR_Vital_Height, BC000J6_A159BR_Vital_Weight, BC000J6_n159BR_Vital_Weight, BC000J6_A19BR_EncounterID
               }
               , new Object[] {
               BC000J7_A150BR_VitalID
               }
               , new Object[] {
               BC000J8_A150BR_VitalID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000J11_A85BR_Information_ID, BC000J11_n85BR_Information_ID
               }
               , new Object[] {
               BC000J12_A36BR_Information_PatientNo, BC000J12_n36BR_Information_PatientNo
               }
               , new Object[] {
               BC000J13_A85BR_Information_ID, BC000J13_n85BR_Information_ID, BC000J13_A150BR_VitalID, BC000J13_A36BR_Information_PatientNo, BC000J13_n36BR_Information_PatientNo, BC000J13_A151BR_Vital_VitalID, BC000J13_n151BR_Vital_VitalID, BC000J13_A152BR_Vital_MeasureDate, BC000J13_n152BR_Vital_MeasureDate, BC000J13_A153BR_Vital_Temperature,
               BC000J13_n153BR_Vital_Temperature, BC000J13_A154BR_Vital_Pulse, BC000J13_n154BR_Vital_Pulse, BC000J13_A155BR_Vital_Respiration, BC000J13_n155BR_Vital_Respiration, BC000J13_A156BR_Vital_Systolic, BC000J13_n156BR_Vital_Systolic, BC000J13_A157BR_Vital_Diastolic, BC000J13_n157BR_Vital_Diastolic, BC000J13_A158BR_Vital_Height,
               BC000J13_n158BR_Vital_Height, BC000J13_A159BR_Vital_Weight, BC000J13_n159BR_Vital_Weight, BC000J13_A19BR_EncounterID
               }
            }
         );
         AV16Pgmname = "BR_Vital_BC";
         INITTRN();
         /* Execute Start event if defined. */
         /* Execute user event: Start */
         E120J2 ();
         standaloneNotModal( ) ;
      }

      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short GX_JID ;
      private short RcdFound20 ;
      private int trnEnded ;
      private int AV17GXV1 ;
      private long Z150BR_VitalID ;
      private long A150BR_VitalID ;
      private long AV10Insert_BR_EncounterID ;
      private long Z151BR_Vital_VitalID ;
      private long A151BR_Vital_VitalID ;
      private long Z19BR_EncounterID ;
      private long A19BR_EncounterID ;
      private long Z85BR_Information_ID ;
      private long A85BR_Information_ID ;
      private decimal Z153BR_Vital_Temperature ;
      private decimal A153BR_Vital_Temperature ;
      private decimal Z154BR_Vital_Pulse ;
      private decimal A154BR_Vital_Pulse ;
      private decimal Z155BR_Vital_Respiration ;
      private decimal A155BR_Vital_Respiration ;
      private decimal Z156BR_Vital_Systolic ;
      private decimal A156BR_Vital_Systolic ;
      private decimal Z157BR_Vital_Diastolic ;
      private decimal A157BR_Vital_Diastolic ;
      private decimal Z158BR_Vital_Height ;
      private decimal A158BR_Vital_Height ;
      private decimal Z159BR_Vital_Weight ;
      private decimal A159BR_Vital_Weight ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String AV16Pgmname ;
      private String sMode20 ;
      private DateTime Z152BR_Vital_MeasureDate ;
      private DateTime A152BR_Vital_MeasureDate ;
      private bool AV13IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool n85BR_Information_ID ;
      private bool n36BR_Information_PatientNo ;
      private bool n151BR_Vital_VitalID ;
      private bool n152BR_Vital_MeasureDate ;
      private bool n153BR_Vital_Temperature ;
      private bool n154BR_Vital_Pulse ;
      private bool n155BR_Vital_Respiration ;
      private bool n156BR_Vital_Systolic ;
      private bool n157BR_Vital_Diastolic ;
      private bool n158BR_Vital_Height ;
      private bool n159BR_Vital_Weight ;
      private bool Gx_longc ;
      private String Z36BR_Information_PatientNo ;
      private String A36BR_Information_PatientNo ;
      private IGxSession AV9WebSession ;
      private SdtBR_Vital bcBR_Vital ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] BC000J6_A85BR_Information_ID ;
      private bool[] BC000J6_n85BR_Information_ID ;
      private long[] BC000J6_A150BR_VitalID ;
      private String[] BC000J6_A36BR_Information_PatientNo ;
      private bool[] BC000J6_n36BR_Information_PatientNo ;
      private long[] BC000J6_A151BR_Vital_VitalID ;
      private bool[] BC000J6_n151BR_Vital_VitalID ;
      private DateTime[] BC000J6_A152BR_Vital_MeasureDate ;
      private bool[] BC000J6_n152BR_Vital_MeasureDate ;
      private decimal[] BC000J6_A153BR_Vital_Temperature ;
      private bool[] BC000J6_n153BR_Vital_Temperature ;
      private decimal[] BC000J6_A154BR_Vital_Pulse ;
      private bool[] BC000J6_n154BR_Vital_Pulse ;
      private decimal[] BC000J6_A155BR_Vital_Respiration ;
      private bool[] BC000J6_n155BR_Vital_Respiration ;
      private decimal[] BC000J6_A156BR_Vital_Systolic ;
      private bool[] BC000J6_n156BR_Vital_Systolic ;
      private decimal[] BC000J6_A157BR_Vital_Diastolic ;
      private bool[] BC000J6_n157BR_Vital_Diastolic ;
      private decimal[] BC000J6_A158BR_Vital_Height ;
      private bool[] BC000J6_n158BR_Vital_Height ;
      private decimal[] BC000J6_A159BR_Vital_Weight ;
      private bool[] BC000J6_n159BR_Vital_Weight ;
      private long[] BC000J6_A19BR_EncounterID ;
      private long[] BC000J4_A85BR_Information_ID ;
      private bool[] BC000J4_n85BR_Information_ID ;
      private String[] BC000J5_A36BR_Information_PatientNo ;
      private bool[] BC000J5_n36BR_Information_PatientNo ;
      private long[] BC000J7_A150BR_VitalID ;
      private long[] BC000J3_A150BR_VitalID ;
      private long[] BC000J3_A151BR_Vital_VitalID ;
      private bool[] BC000J3_n151BR_Vital_VitalID ;
      private DateTime[] BC000J3_A152BR_Vital_MeasureDate ;
      private bool[] BC000J3_n152BR_Vital_MeasureDate ;
      private decimal[] BC000J3_A153BR_Vital_Temperature ;
      private bool[] BC000J3_n153BR_Vital_Temperature ;
      private decimal[] BC000J3_A154BR_Vital_Pulse ;
      private bool[] BC000J3_n154BR_Vital_Pulse ;
      private decimal[] BC000J3_A155BR_Vital_Respiration ;
      private bool[] BC000J3_n155BR_Vital_Respiration ;
      private decimal[] BC000J3_A156BR_Vital_Systolic ;
      private bool[] BC000J3_n156BR_Vital_Systolic ;
      private decimal[] BC000J3_A157BR_Vital_Diastolic ;
      private bool[] BC000J3_n157BR_Vital_Diastolic ;
      private decimal[] BC000J3_A158BR_Vital_Height ;
      private bool[] BC000J3_n158BR_Vital_Height ;
      private decimal[] BC000J3_A159BR_Vital_Weight ;
      private bool[] BC000J3_n159BR_Vital_Weight ;
      private long[] BC000J3_A19BR_EncounterID ;
      private long[] BC000J2_A150BR_VitalID ;
      private long[] BC000J2_A151BR_Vital_VitalID ;
      private bool[] BC000J2_n151BR_Vital_VitalID ;
      private DateTime[] BC000J2_A152BR_Vital_MeasureDate ;
      private bool[] BC000J2_n152BR_Vital_MeasureDate ;
      private decimal[] BC000J2_A153BR_Vital_Temperature ;
      private bool[] BC000J2_n153BR_Vital_Temperature ;
      private decimal[] BC000J2_A154BR_Vital_Pulse ;
      private bool[] BC000J2_n154BR_Vital_Pulse ;
      private decimal[] BC000J2_A155BR_Vital_Respiration ;
      private bool[] BC000J2_n155BR_Vital_Respiration ;
      private decimal[] BC000J2_A156BR_Vital_Systolic ;
      private bool[] BC000J2_n156BR_Vital_Systolic ;
      private decimal[] BC000J2_A157BR_Vital_Diastolic ;
      private bool[] BC000J2_n157BR_Vital_Diastolic ;
      private decimal[] BC000J2_A158BR_Vital_Height ;
      private bool[] BC000J2_n158BR_Vital_Height ;
      private decimal[] BC000J2_A159BR_Vital_Weight ;
      private bool[] BC000J2_n159BR_Vital_Weight ;
      private long[] BC000J2_A19BR_EncounterID ;
      private long[] BC000J8_A150BR_VitalID ;
      private long[] BC000J11_A85BR_Information_ID ;
      private bool[] BC000J11_n85BR_Information_ID ;
      private String[] BC000J12_A36BR_Information_PatientNo ;
      private bool[] BC000J12_n36BR_Information_PatientNo ;
      private long[] BC000J13_A85BR_Information_ID ;
      private bool[] BC000J13_n85BR_Information_ID ;
      private long[] BC000J13_A150BR_VitalID ;
      private String[] BC000J13_A36BR_Information_PatientNo ;
      private bool[] BC000J13_n36BR_Information_PatientNo ;
      private long[] BC000J13_A151BR_Vital_VitalID ;
      private bool[] BC000J13_n151BR_Vital_VitalID ;
      private DateTime[] BC000J13_A152BR_Vital_MeasureDate ;
      private bool[] BC000J13_n152BR_Vital_MeasureDate ;
      private decimal[] BC000J13_A153BR_Vital_Temperature ;
      private bool[] BC000J13_n153BR_Vital_Temperature ;
      private decimal[] BC000J13_A154BR_Vital_Pulse ;
      private bool[] BC000J13_n154BR_Vital_Pulse ;
      private decimal[] BC000J13_A155BR_Vital_Respiration ;
      private bool[] BC000J13_n155BR_Vital_Respiration ;
      private decimal[] BC000J13_A156BR_Vital_Systolic ;
      private bool[] BC000J13_n156BR_Vital_Systolic ;
      private decimal[] BC000J13_A157BR_Vital_Diastolic ;
      private bool[] BC000J13_n157BR_Vital_Diastolic ;
      private decimal[] BC000J13_A158BR_Vital_Height ;
      private bool[] BC000J13_n158BR_Vital_Height ;
      private decimal[] BC000J13_A159BR_Vital_Weight ;
      private bool[] BC000J13_n159BR_Vital_Weight ;
      private long[] BC000J13_A19BR_EncounterID ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_datastore1 ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV7WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV8TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV11TrnContextAtt ;
   }

   public class br_vital_bc__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class br_vital_bc__default : DataStoreHelperBase, IDataStoreHelper
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
        Object[] prmBC000J6 ;
        prmBC000J6 = new Object[] {
        new Object[] {"@BR_VitalID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000J4 ;
        prmBC000J4 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000J5 ;
        prmBC000J5 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000J7 ;
        prmBC000J7 = new Object[] {
        new Object[] {"@BR_VitalID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000J3 ;
        prmBC000J3 = new Object[] {
        new Object[] {"@BR_VitalID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000J2 ;
        prmBC000J2 = new Object[] {
        new Object[] {"@BR_VitalID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000J8 ;
        prmBC000J8 = new Object[] {
        new Object[] {"@BR_Vital_VitalID",SqlDbType.Decimal,10,0} ,
        new Object[] {"@BR_Vital_MeasureDate",SqlDbType.DateTime,8,0} ,
        new Object[] {"@BR_Vital_Temperature",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_Vital_Pulse",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_Vital_Respiration",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_Vital_Systolic",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_Vital_Diastolic",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_Vital_Height",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_Vital_Weight",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000J9 ;
        prmBC000J9 = new Object[] {
        new Object[] {"@BR_Vital_VitalID",SqlDbType.Decimal,10,0} ,
        new Object[] {"@BR_Vital_MeasureDate",SqlDbType.DateTime,8,0} ,
        new Object[] {"@BR_Vital_Temperature",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_Vital_Pulse",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_Vital_Respiration",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_Vital_Systolic",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_Vital_Diastolic",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_Vital_Height",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_Vital_Weight",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_VitalID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000J10 ;
        prmBC000J10 = new Object[] {
        new Object[] {"@BR_VitalID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000J11 ;
        prmBC000J11 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000J12 ;
        prmBC000J12 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000J13 ;
        prmBC000J13 = new Object[] {
        new Object[] {"@BR_VitalID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("BC000J2", "SELECT [BR_VitalID], [BR_Vital_VitalID], [BR_Vital_MeasureDate], [BR_Vital_Temperature], [BR_Vital_Pulse], [BR_Vital_Respiration], [BR_Vital_Systolic], [BR_Vital_Diastolic], [BR_Vital_Height], [BR_Vital_Weight], [BR_EncounterID] FROM [BR_Vital] WITH (UPDLOCK) WHERE [BR_VitalID] = @BR_VitalID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000J2,1,0,true,false )
           ,new CursorDef("BC000J3", "SELECT [BR_VitalID], [BR_Vital_VitalID], [BR_Vital_MeasureDate], [BR_Vital_Temperature], [BR_Vital_Pulse], [BR_Vital_Respiration], [BR_Vital_Systolic], [BR_Vital_Diastolic], [BR_Vital_Height], [BR_Vital_Weight], [BR_EncounterID] FROM [BR_Vital] WITH (NOLOCK) WHERE [BR_VitalID] = @BR_VitalID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000J3,1,0,true,false )
           ,new CursorDef("BC000J4", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000J4,1,0,true,false )
           ,new CursorDef("BC000J5", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000J5,1,0,true,false )
           ,new CursorDef("BC000J6", "SELECT T2.[BR_Information_ID], TM1.[BR_VitalID], T3.[BR_Information_PatientNo], TM1.[BR_Vital_VitalID], TM1.[BR_Vital_MeasureDate], TM1.[BR_Vital_Temperature], TM1.[BR_Vital_Pulse], TM1.[BR_Vital_Respiration], TM1.[BR_Vital_Systolic], TM1.[BR_Vital_Diastolic], TM1.[BR_Vital_Height], TM1.[BR_Vital_Weight], TM1.[BR_EncounterID] FROM (([BR_Vital] TM1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = TM1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID]) WHERE TM1.[BR_VitalID] = @BR_VitalID ORDER BY TM1.[BR_VitalID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000J6,100,0,true,false )
           ,new CursorDef("BC000J7", "SELECT [BR_VitalID] FROM [BR_Vital] WITH (NOLOCK) WHERE [BR_VitalID] = @BR_VitalID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000J7,1,0,true,false )
           ,new CursorDef("BC000J8", "INSERT INTO [BR_Vital]([BR_Vital_VitalID], [BR_Vital_MeasureDate], [BR_Vital_Temperature], [BR_Vital_Pulse], [BR_Vital_Respiration], [BR_Vital_Systolic], [BR_Vital_Diastolic], [BR_Vital_Height], [BR_Vital_Weight], [BR_EncounterID]) VALUES(@BR_Vital_VitalID, @BR_Vital_MeasureDate, @BR_Vital_Temperature, @BR_Vital_Pulse, @BR_Vital_Respiration, @BR_Vital_Systolic, @BR_Vital_Diastolic, @BR_Vital_Height, @BR_Vital_Weight, @BR_EncounterID); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmBC000J8)
           ,new CursorDef("BC000J9", "UPDATE [BR_Vital] SET [BR_Vital_VitalID]=@BR_Vital_VitalID, [BR_Vital_MeasureDate]=@BR_Vital_MeasureDate, [BR_Vital_Temperature]=@BR_Vital_Temperature, [BR_Vital_Pulse]=@BR_Vital_Pulse, [BR_Vital_Respiration]=@BR_Vital_Respiration, [BR_Vital_Systolic]=@BR_Vital_Systolic, [BR_Vital_Diastolic]=@BR_Vital_Diastolic, [BR_Vital_Height]=@BR_Vital_Height, [BR_Vital_Weight]=@BR_Vital_Weight, [BR_EncounterID]=@BR_EncounterID  WHERE [BR_VitalID] = @BR_VitalID", GxErrorMask.GX_NOMASK,prmBC000J9)
           ,new CursorDef("BC000J10", "DELETE FROM [BR_Vital]  WHERE [BR_VitalID] = @BR_VitalID", GxErrorMask.GX_NOMASK,prmBC000J10)
           ,new CursorDef("BC000J11", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000J11,1,0,true,false )
           ,new CursorDef("BC000J12", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000J12,1,0,true,false )
           ,new CursorDef("BC000J13", "SELECT T2.[BR_Information_ID], TM1.[BR_VitalID], T3.[BR_Information_PatientNo], TM1.[BR_Vital_VitalID], TM1.[BR_Vital_MeasureDate], TM1.[BR_Vital_Temperature], TM1.[BR_Vital_Pulse], TM1.[BR_Vital_Respiration], TM1.[BR_Vital_Systolic], TM1.[BR_Vital_Diastolic], TM1.[BR_Vital_Height], TM1.[BR_Vital_Weight], TM1.[BR_EncounterID] FROM (([BR_Vital] TM1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = TM1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID]) WHERE TM1.[BR_VitalID] = @BR_VitalID ORDER BY TM1.[BR_VitalID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000J13,100,0,true,false )
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
              ((DateTime[]) buf[3])[0] = rslt.getGXDate(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((decimal[]) buf[5])[0] = rslt.getDecimal(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((decimal[]) buf[7])[0] = rslt.getDecimal(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((decimal[]) buf[9])[0] = rslt.getDecimal(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((decimal[]) buf[11])[0] = rslt.getDecimal(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((decimal[]) buf[13])[0] = rslt.getDecimal(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((decimal[]) buf[15])[0] = rslt.getDecimal(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((decimal[]) buf[17])[0] = rslt.getDecimal(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              ((long[]) buf[19])[0] = rslt.getLong(11) ;
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((DateTime[]) buf[3])[0] = rslt.getGXDate(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((decimal[]) buf[5])[0] = rslt.getDecimal(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((decimal[]) buf[7])[0] = rslt.getDecimal(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((decimal[]) buf[9])[0] = rslt.getDecimal(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((decimal[]) buf[11])[0] = rslt.getDecimal(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((decimal[]) buf[13])[0] = rslt.getDecimal(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((decimal[]) buf[15])[0] = rslt.getDecimal(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((decimal[]) buf[17])[0] = rslt.getDecimal(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              ((long[]) buf[19])[0] = rslt.getLong(11) ;
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
              ((long[]) buf[5])[0] = rslt.getLong(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((DateTime[]) buf[7])[0] = rslt.getGXDate(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((decimal[]) buf[9])[0] = rslt.getDecimal(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((decimal[]) buf[11])[0] = rslt.getDecimal(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((decimal[]) buf[13])[0] = rslt.getDecimal(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((decimal[]) buf[15])[0] = rslt.getDecimal(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((decimal[]) buf[17])[0] = rslt.getDecimal(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              ((decimal[]) buf[19])[0] = rslt.getDecimal(11) ;
              ((bool[]) buf[20])[0] = rslt.wasNull(11);
              ((decimal[]) buf[21])[0] = rslt.getDecimal(12) ;
              ((bool[]) buf[22])[0] = rslt.wasNull(12);
              ((long[]) buf[23])[0] = rslt.getLong(13) ;
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
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              ((long[]) buf[2])[0] = rslt.getLong(2) ;
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((long[]) buf[5])[0] = rslt.getLong(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((DateTime[]) buf[7])[0] = rslt.getGXDate(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((decimal[]) buf[9])[0] = rslt.getDecimal(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((decimal[]) buf[11])[0] = rslt.getDecimal(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((decimal[]) buf[13])[0] = rslt.getDecimal(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((decimal[]) buf[15])[0] = rslt.getDecimal(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((decimal[]) buf[17])[0] = rslt.getDecimal(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              ((decimal[]) buf[19])[0] = rslt.getDecimal(11) ;
              ((bool[]) buf[20])[0] = rslt.wasNull(11);
              ((decimal[]) buf[21])[0] = rslt.getDecimal(12) ;
              ((bool[]) buf[22])[0] = rslt.wasNull(12);
              ((long[]) buf[23])[0] = rslt.getLong(13) ;
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
                 stmt.setNull( 2 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameter(2, (DateTime)parms[3]);
              }
              if ( (bool)parms[4] )
              {
                 stmt.setNull( 3 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(3, (decimal)parms[5]);
              }
              if ( (bool)parms[6] )
              {
                 stmt.setNull( 4 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(4, (decimal)parms[7]);
              }
              if ( (bool)parms[8] )
              {
                 stmt.setNull( 5 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(5, (decimal)parms[9]);
              }
              if ( (bool)parms[10] )
              {
                 stmt.setNull( 6 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(6, (decimal)parms[11]);
              }
              if ( (bool)parms[12] )
              {
                 stmt.setNull( 7 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(7, (decimal)parms[13]);
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
                 stmt.SetParameter(9, (decimal)parms[17]);
              }
              stmt.SetParameter(10, (long)parms[18]);
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
                 stmt.setNull( 2 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameter(2, (DateTime)parms[3]);
              }
              if ( (bool)parms[4] )
              {
                 stmt.setNull( 3 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(3, (decimal)parms[5]);
              }
              if ( (bool)parms[6] )
              {
                 stmt.setNull( 4 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(4, (decimal)parms[7]);
              }
              if ( (bool)parms[8] )
              {
                 stmt.setNull( 5 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(5, (decimal)parms[9]);
              }
              if ( (bool)parms[10] )
              {
                 stmt.setNull( 6 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(6, (decimal)parms[11]);
              }
              if ( (bool)parms[12] )
              {
                 stmt.setNull( 7 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(7, (decimal)parms[13]);
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
                 stmt.SetParameter(9, (decimal)parms[17]);
              }
              stmt.SetParameter(10, (long)parms[18]);
              stmt.SetParameter(11, (long)parms[19]);
              return;
           case 8 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 9 :
              stmt.SetParameter(1, (long)parms[0]);
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
