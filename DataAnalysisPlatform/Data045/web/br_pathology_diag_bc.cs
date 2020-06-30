/*
               File: BR_Pathology_Diag_BC
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:8:17.59
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
   public class br_pathology_diag_bc : GXHttpHandler, IGxSilentTrn
   {
      public br_pathology_diag_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_pathology_diag_bc( IGxContext context )
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
         ReadRow0X34( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey0X34( ) ;
         standaloneModal( ) ;
         AddRow0X34( ) ;
         Gx_mode = "INS";
         return  ;
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E110X2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               Z276BR_Pathology_DiagID = A276BR_Pathology_DiagID;
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

      protected void CONFIRM_0X0( )
      {
         BeforeValidate0X34( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0X34( ) ;
            }
            else
            {
               CheckExtendedTable0X34( ) ;
               if ( AnyError == 0 )
               {
                  ZM0X34( 9) ;
               }
               CloseExtendedTableCursors0X34( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void E120X2( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV8WWPContext) ;
         AV9IsAuthorized = true;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Pathology_Diag", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Pathology_Diag", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Pathology_Diag", out  GXt_boolean1) ;
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
               if ( StringUtil.StrCmp(AV14TrnContextAtt.gxTpr_Attributename, "BR_PathologyID") == 0 )
               {
                  AV13Insert_BR_PathologyID = (long)(NumberUtil.Val( AV14TrnContextAtt.gxTpr_Attributevalue, "."));
               }
               AV17GXV1 = (int)(AV17GXV1+1);
            }
         }
      }

      protected void E110X2( )
      {
         /* After Trn Routine */
      }

      protected void ZM0X34( short GX_JID )
      {
         if ( ( GX_JID == 8 ) || ( GX_JID == 0 ) )
         {
            Z277BR_Pathology_Diag_Loc = A277BR_Pathology_Diag_Loc;
            Z278BR_Pathology_Diag_Organ = A278BR_Pathology_Diag_Organ;
            Z279BR_Pathology_Diag_TumorType = A279BR_Pathology_Diag_TumorType;
            Z280BR_Pathology_Diag_TumorStage = A280BR_Pathology_Diag_TumorStage;
            Z281BR_Pathology_Diag_TumorGrade = A281BR_Pathology_Diag_TumorGrade;
            Z226BR_PathologyID = A226BR_PathologyID;
         }
         if ( ( GX_JID == 9 ) || ( GX_JID == 0 ) )
         {
         }
         if ( GX_JID == -8 )
         {
            Z276BR_Pathology_DiagID = A276BR_Pathology_DiagID;
            Z277BR_Pathology_Diag_Loc = A277BR_Pathology_Diag_Loc;
            Z278BR_Pathology_Diag_Organ = A278BR_Pathology_Diag_Organ;
            Z279BR_Pathology_Diag_TumorType = A279BR_Pathology_Diag_TumorType;
            Z280BR_Pathology_Diag_TumorStage = A280BR_Pathology_Diag_TumorStage;
            Z281BR_Pathology_Diag_TumorGrade = A281BR_Pathology_Diag_TumorGrade;
            Z226BR_PathologyID = A226BR_PathologyID;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load0X34( )
      {
         /* Using cursor BC000X5 */
         pr_default.execute(3, new Object[] {A276BR_Pathology_DiagID});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound34 = 1;
            A277BR_Pathology_Diag_Loc = BC000X5_A277BR_Pathology_Diag_Loc[0];
            n277BR_Pathology_Diag_Loc = BC000X5_n277BR_Pathology_Diag_Loc[0];
            A278BR_Pathology_Diag_Organ = BC000X5_A278BR_Pathology_Diag_Organ[0];
            n278BR_Pathology_Diag_Organ = BC000X5_n278BR_Pathology_Diag_Organ[0];
            A279BR_Pathology_Diag_TumorType = BC000X5_A279BR_Pathology_Diag_TumorType[0];
            n279BR_Pathology_Diag_TumorType = BC000X5_n279BR_Pathology_Diag_TumorType[0];
            A280BR_Pathology_Diag_TumorStage = BC000X5_A280BR_Pathology_Diag_TumorStage[0];
            n280BR_Pathology_Diag_TumorStage = BC000X5_n280BR_Pathology_Diag_TumorStage[0];
            A281BR_Pathology_Diag_TumorGrade = BC000X5_A281BR_Pathology_Diag_TumorGrade[0];
            n281BR_Pathology_Diag_TumorGrade = BC000X5_n281BR_Pathology_Diag_TumorGrade[0];
            A226BR_PathologyID = BC000X5_A226BR_PathologyID[0];
            n226BR_PathologyID = BC000X5_n226BR_PathologyID[0];
            ZM0X34( -8) ;
         }
         pr_default.close(3);
         OnLoadActions0X34( ) ;
      }

      protected void OnLoadActions0X34( )
      {
         AV16Pgmname = "BR_Pathology_Diag_BC";
      }

      protected void CheckExtendedTable0X34( )
      {
         standaloneModal( ) ;
         AV16Pgmname = "BR_Pathology_Diag_BC";
         /* Using cursor BC000X4 */
         pr_default.execute(2, new Object[] {n226BR_PathologyID, A226BR_PathologyID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            if ( ! ( (0==A226BR_PathologyID) ) )
            {
               GX_msglist.addItem("不匹配' T36'", "ForeignKeyNotFound", 1, "BR_PATHOLOGYID");
               AnyError = 1;
            }
         }
         pr_default.close(2);
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A277BR_Pathology_Diag_Loc)) )
         {
            GX_msglist.addItem("病理诊断(部位)是必须填写的。", 1, "");
            AnyError = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A278BR_Pathology_Diag_Organ)) )
         {
            GX_msglist.addItem("病理诊断(器官)是必须填写的。", 1, "");
            AnyError = 1;
         }
      }

      protected void CloseExtendedTableCursors0X34( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0X34( )
      {
         /* Using cursor BC000X6 */
         pr_default.execute(4, new Object[] {A276BR_Pathology_DiagID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound34 = 1;
         }
         else
         {
            RcdFound34 = 0;
         }
         pr_default.close(4);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC000X3 */
         pr_default.execute(1, new Object[] {A276BR_Pathology_DiagID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0X34( 8) ;
            RcdFound34 = 1;
            A276BR_Pathology_DiagID = BC000X3_A276BR_Pathology_DiagID[0];
            A277BR_Pathology_Diag_Loc = BC000X3_A277BR_Pathology_Diag_Loc[0];
            n277BR_Pathology_Diag_Loc = BC000X3_n277BR_Pathology_Diag_Loc[0];
            A278BR_Pathology_Diag_Organ = BC000X3_A278BR_Pathology_Diag_Organ[0];
            n278BR_Pathology_Diag_Organ = BC000X3_n278BR_Pathology_Diag_Organ[0];
            A279BR_Pathology_Diag_TumorType = BC000X3_A279BR_Pathology_Diag_TumorType[0];
            n279BR_Pathology_Diag_TumorType = BC000X3_n279BR_Pathology_Diag_TumorType[0];
            A280BR_Pathology_Diag_TumorStage = BC000X3_A280BR_Pathology_Diag_TumorStage[0];
            n280BR_Pathology_Diag_TumorStage = BC000X3_n280BR_Pathology_Diag_TumorStage[0];
            A281BR_Pathology_Diag_TumorGrade = BC000X3_A281BR_Pathology_Diag_TumorGrade[0];
            n281BR_Pathology_Diag_TumorGrade = BC000X3_n281BR_Pathology_Diag_TumorGrade[0];
            A226BR_PathologyID = BC000X3_A226BR_PathologyID[0];
            n226BR_PathologyID = BC000X3_n226BR_PathologyID[0];
            Z276BR_Pathology_DiagID = A276BR_Pathology_DiagID;
            sMode34 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load0X34( ) ;
            if ( AnyError == 1 )
            {
               RcdFound34 = 0;
               InitializeNonKey0X34( ) ;
            }
            Gx_mode = sMode34;
         }
         else
         {
            RcdFound34 = 0;
            InitializeNonKey0X34( ) ;
            sMode34 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode34;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0X34( ) ;
         if ( RcdFound34 == 0 )
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
         CONFIRM_0X0( ) ;
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

      protected void CheckOptimisticConcurrency0X34( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC000X2 */
            pr_default.execute(0, new Object[] {A276BR_Pathology_DiagID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Pathology_Diag"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z277BR_Pathology_Diag_Loc, BC000X2_A277BR_Pathology_Diag_Loc[0]) != 0 ) || ( StringUtil.StrCmp(Z278BR_Pathology_Diag_Organ, BC000X2_A278BR_Pathology_Diag_Organ[0]) != 0 ) || ( StringUtil.StrCmp(Z279BR_Pathology_Diag_TumorType, BC000X2_A279BR_Pathology_Diag_TumorType[0]) != 0 ) || ( StringUtil.StrCmp(Z280BR_Pathology_Diag_TumorStage, BC000X2_A280BR_Pathology_Diag_TumorStage[0]) != 0 ) || ( StringUtil.StrCmp(Z281BR_Pathology_Diag_TumorGrade, BC000X2_A281BR_Pathology_Diag_TumorGrade[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z226BR_PathologyID != BC000X2_A226BR_PathologyID[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"BR_Pathology_Diag"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0X34( )
      {
         BeforeValidate0X34( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0X34( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0X34( 0) ;
            CheckOptimisticConcurrency0X34( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0X34( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0X34( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000X7 */
                     pr_default.execute(5, new Object[] {n277BR_Pathology_Diag_Loc, A277BR_Pathology_Diag_Loc, n278BR_Pathology_Diag_Organ, A278BR_Pathology_Diag_Organ, n279BR_Pathology_Diag_TumorType, A279BR_Pathology_Diag_TumorType, n280BR_Pathology_Diag_TumorStage, A280BR_Pathology_Diag_TumorStage, n281BR_Pathology_Diag_TumorGrade, A281BR_Pathology_Diag_TumorGrade, n226BR_PathologyID, A226BR_PathologyID});
                     A276BR_Pathology_DiagID = BC000X7_A276BR_Pathology_DiagID[0];
                     pr_default.close(5);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Pathology_Diag") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)),  "病理学",  StringUtil.Trim( StringUtil.Str( (decimal)(A276BR_Pathology_DiagID), 18, 0)),  "诊断",  "Create",  1) ;
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
               Load0X34( ) ;
            }
            EndLevel0X34( ) ;
         }
         CloseExtendedTableCursors0X34( ) ;
      }

      protected void Update0X34( )
      {
         BeforeValidate0X34( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0X34( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0X34( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0X34( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0X34( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000X8 */
                     pr_default.execute(6, new Object[] {n277BR_Pathology_Diag_Loc, A277BR_Pathology_Diag_Loc, n278BR_Pathology_Diag_Organ, A278BR_Pathology_Diag_Organ, n279BR_Pathology_Diag_TumorType, A279BR_Pathology_Diag_TumorType, n280BR_Pathology_Diag_TumorStage, A280BR_Pathology_Diag_TumorStage, n281BR_Pathology_Diag_TumorGrade, A281BR_Pathology_Diag_TumorGrade, n226BR_PathologyID, A226BR_PathologyID, A276BR_Pathology_DiagID});
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Pathology_Diag") ;
                     if ( (pr_default.getStatus(6) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Pathology_Diag"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0X34( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)),  "病理学",  StringUtil.Trim( StringUtil.Str( (decimal)(A276BR_Pathology_DiagID), 18, 0)),  "诊断",  "Update",  1) ;
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
            EndLevel0X34( ) ;
         }
         CloseExtendedTableCursors0X34( ) ;
      }

      protected void DeferredUpdate0X34( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate0X34( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0X34( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0X34( ) ;
            AfterConfirm0X34( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0X34( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC000X9 */
                  pr_default.execute(7, new Object[] {A276BR_Pathology_DiagID});
                  pr_default.close(7);
                  dsDefault.SmartCacheProvider.SetUpdated("BR_Pathology_Diag") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)),  "病理学",  StringUtil.Trim( StringUtil.Str( (decimal)(A276BR_Pathology_DiagID), 18, 0)),  "诊断",  "Delete",  1) ;
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
         sMode34 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel0X34( ) ;
         Gx_mode = sMode34;
      }

      protected void OnDeleteControls0X34( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV16Pgmname = "BR_Pathology_Diag_BC";
         }
      }

      protected void EndLevel0X34( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0X34( ) ;
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

      public void ScanKeyStart0X34( )
      {
         /* Scan By routine */
         /* Using cursor BC000X10 */
         pr_default.execute(8, new Object[] {A276BR_Pathology_DiagID});
         RcdFound34 = 0;
         if ( (pr_default.getStatus(8) != 101) )
         {
            RcdFound34 = 1;
            A276BR_Pathology_DiagID = BC000X10_A276BR_Pathology_DiagID[0];
            A277BR_Pathology_Diag_Loc = BC000X10_A277BR_Pathology_Diag_Loc[0];
            n277BR_Pathology_Diag_Loc = BC000X10_n277BR_Pathology_Diag_Loc[0];
            A278BR_Pathology_Diag_Organ = BC000X10_A278BR_Pathology_Diag_Organ[0];
            n278BR_Pathology_Diag_Organ = BC000X10_n278BR_Pathology_Diag_Organ[0];
            A279BR_Pathology_Diag_TumorType = BC000X10_A279BR_Pathology_Diag_TumorType[0];
            n279BR_Pathology_Diag_TumorType = BC000X10_n279BR_Pathology_Diag_TumorType[0];
            A280BR_Pathology_Diag_TumorStage = BC000X10_A280BR_Pathology_Diag_TumorStage[0];
            n280BR_Pathology_Diag_TumorStage = BC000X10_n280BR_Pathology_Diag_TumorStage[0];
            A281BR_Pathology_Diag_TumorGrade = BC000X10_A281BR_Pathology_Diag_TumorGrade[0];
            n281BR_Pathology_Diag_TumorGrade = BC000X10_n281BR_Pathology_Diag_TumorGrade[0];
            A226BR_PathologyID = BC000X10_A226BR_PathologyID[0];
            n226BR_PathologyID = BC000X10_n226BR_PathologyID[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext0X34( )
      {
         /* Scan next routine */
         pr_default.readNext(8);
         RcdFound34 = 0;
         ScanKeyLoad0X34( ) ;
      }

      protected void ScanKeyLoad0X34( )
      {
         sMode34 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(8) != 101) )
         {
            RcdFound34 = 1;
            A276BR_Pathology_DiagID = BC000X10_A276BR_Pathology_DiagID[0];
            A277BR_Pathology_Diag_Loc = BC000X10_A277BR_Pathology_Diag_Loc[0];
            n277BR_Pathology_Diag_Loc = BC000X10_n277BR_Pathology_Diag_Loc[0];
            A278BR_Pathology_Diag_Organ = BC000X10_A278BR_Pathology_Diag_Organ[0];
            n278BR_Pathology_Diag_Organ = BC000X10_n278BR_Pathology_Diag_Organ[0];
            A279BR_Pathology_Diag_TumorType = BC000X10_A279BR_Pathology_Diag_TumorType[0];
            n279BR_Pathology_Diag_TumorType = BC000X10_n279BR_Pathology_Diag_TumorType[0];
            A280BR_Pathology_Diag_TumorStage = BC000X10_A280BR_Pathology_Diag_TumorStage[0];
            n280BR_Pathology_Diag_TumorStage = BC000X10_n280BR_Pathology_Diag_TumorStage[0];
            A281BR_Pathology_Diag_TumorGrade = BC000X10_A281BR_Pathology_Diag_TumorGrade[0];
            n281BR_Pathology_Diag_TumorGrade = BC000X10_n281BR_Pathology_Diag_TumorGrade[0];
            A226BR_PathologyID = BC000X10_A226BR_PathologyID[0];
            n226BR_PathologyID = BC000X10_n226BR_PathologyID[0];
         }
         Gx_mode = sMode34;
      }

      protected void ScanKeyEnd0X34( )
      {
         pr_default.close(8);
      }

      protected void AfterConfirm0X34( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0X34( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0X34( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0X34( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0X34( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0X34( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0X34( )
      {
      }

      protected void send_integrity_lvl_hashes0X34( )
      {
      }

      protected void AddRow0X34( )
      {
         VarsToRow34( bcBR_Pathology_Diag) ;
      }

      protected void ReadRow0X34( )
      {
         RowToVars34( bcBR_Pathology_Diag, 1) ;
      }

      protected void InitializeNonKey0X34( )
      {
         A226BR_PathologyID = 0;
         n226BR_PathologyID = false;
         A277BR_Pathology_Diag_Loc = "";
         n277BR_Pathology_Diag_Loc = false;
         A278BR_Pathology_Diag_Organ = "";
         n278BR_Pathology_Diag_Organ = false;
         A279BR_Pathology_Diag_TumorType = "";
         n279BR_Pathology_Diag_TumorType = false;
         A280BR_Pathology_Diag_TumorStage = "";
         n280BR_Pathology_Diag_TumorStage = false;
         A281BR_Pathology_Diag_TumorGrade = "";
         n281BR_Pathology_Diag_TumorGrade = false;
         Z277BR_Pathology_Diag_Loc = "";
         Z278BR_Pathology_Diag_Organ = "";
         Z279BR_Pathology_Diag_TumorType = "";
         Z280BR_Pathology_Diag_TumorStage = "";
         Z281BR_Pathology_Diag_TumorGrade = "";
         Z226BR_PathologyID = 0;
      }

      protected void InitAll0X34( )
      {
         A276BR_Pathology_DiagID = 0;
         InitializeNonKey0X34( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow34( SdtBR_Pathology_Diag obj34 )
      {
         obj34.gxTpr_Mode = Gx_mode;
         obj34.gxTpr_Br_pathologyid = A226BR_PathologyID;
         obj34.gxTpr_Br_pathology_diag_loc = A277BR_Pathology_Diag_Loc;
         obj34.gxTpr_Br_pathology_diag_organ = A278BR_Pathology_Diag_Organ;
         obj34.gxTpr_Br_pathology_diag_tumortype = A279BR_Pathology_Diag_TumorType;
         obj34.gxTpr_Br_pathology_diag_tumorstage = A280BR_Pathology_Diag_TumorStage;
         obj34.gxTpr_Br_pathology_diag_tumorgrade = A281BR_Pathology_Diag_TumorGrade;
         obj34.gxTpr_Br_pathology_diagid = A276BR_Pathology_DiagID;
         obj34.gxTpr_Br_pathology_diagid_Z = Z276BR_Pathology_DiagID;
         obj34.gxTpr_Br_pathologyid_Z = Z226BR_PathologyID;
         obj34.gxTpr_Br_pathology_diag_loc_Z = Z277BR_Pathology_Diag_Loc;
         obj34.gxTpr_Br_pathology_diag_organ_Z = Z278BR_Pathology_Diag_Organ;
         obj34.gxTpr_Br_pathology_diag_tumortype_Z = Z279BR_Pathology_Diag_TumorType;
         obj34.gxTpr_Br_pathology_diag_tumorstage_Z = Z280BR_Pathology_Diag_TumorStage;
         obj34.gxTpr_Br_pathology_diag_tumorgrade_Z = Z281BR_Pathology_Diag_TumorGrade;
         obj34.gxTpr_Br_pathologyid_N = (short)(Convert.ToInt16(n226BR_PathologyID));
         obj34.gxTpr_Br_pathology_diag_loc_N = (short)(Convert.ToInt16(n277BR_Pathology_Diag_Loc));
         obj34.gxTpr_Br_pathology_diag_organ_N = (short)(Convert.ToInt16(n278BR_Pathology_Diag_Organ));
         obj34.gxTpr_Br_pathology_diag_tumortype_N = (short)(Convert.ToInt16(n279BR_Pathology_Diag_TumorType));
         obj34.gxTpr_Br_pathology_diag_tumorstage_N = (short)(Convert.ToInt16(n280BR_Pathology_Diag_TumorStage));
         obj34.gxTpr_Br_pathology_diag_tumorgrade_N = (short)(Convert.ToInt16(n281BR_Pathology_Diag_TumorGrade));
         obj34.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow34( SdtBR_Pathology_Diag obj34 )
      {
         obj34.gxTpr_Br_pathology_diagid = A276BR_Pathology_DiagID;
         return  ;
      }

      public void RowToVars34( SdtBR_Pathology_Diag obj34 ,
                               int forceLoad )
      {
         Gx_mode = obj34.gxTpr_Mode;
         A226BR_PathologyID = obj34.gxTpr_Br_pathologyid;
         n226BR_PathologyID = false;
         A277BR_Pathology_Diag_Loc = obj34.gxTpr_Br_pathology_diag_loc;
         n277BR_Pathology_Diag_Loc = false;
         A278BR_Pathology_Diag_Organ = obj34.gxTpr_Br_pathology_diag_organ;
         n278BR_Pathology_Diag_Organ = false;
         A279BR_Pathology_Diag_TumorType = obj34.gxTpr_Br_pathology_diag_tumortype;
         n279BR_Pathology_Diag_TumorType = false;
         A280BR_Pathology_Diag_TumorStage = obj34.gxTpr_Br_pathology_diag_tumorstage;
         n280BR_Pathology_Diag_TumorStage = false;
         A281BR_Pathology_Diag_TumorGrade = obj34.gxTpr_Br_pathology_diag_tumorgrade;
         n281BR_Pathology_Diag_TumorGrade = false;
         A276BR_Pathology_DiagID = obj34.gxTpr_Br_pathology_diagid;
         Z276BR_Pathology_DiagID = obj34.gxTpr_Br_pathology_diagid_Z;
         Z226BR_PathologyID = obj34.gxTpr_Br_pathologyid_Z;
         Z277BR_Pathology_Diag_Loc = obj34.gxTpr_Br_pathology_diag_loc_Z;
         Z278BR_Pathology_Diag_Organ = obj34.gxTpr_Br_pathology_diag_organ_Z;
         Z279BR_Pathology_Diag_TumorType = obj34.gxTpr_Br_pathology_diag_tumortype_Z;
         Z280BR_Pathology_Diag_TumorStage = obj34.gxTpr_Br_pathology_diag_tumorstage_Z;
         Z281BR_Pathology_Diag_TumorGrade = obj34.gxTpr_Br_pathology_diag_tumorgrade_Z;
         n226BR_PathologyID = (bool)(Convert.ToBoolean(obj34.gxTpr_Br_pathologyid_N));
         n277BR_Pathology_Diag_Loc = (bool)(Convert.ToBoolean(obj34.gxTpr_Br_pathology_diag_loc_N));
         n278BR_Pathology_Diag_Organ = (bool)(Convert.ToBoolean(obj34.gxTpr_Br_pathology_diag_organ_N));
         n279BR_Pathology_Diag_TumorType = (bool)(Convert.ToBoolean(obj34.gxTpr_Br_pathology_diag_tumortype_N));
         n280BR_Pathology_Diag_TumorStage = (bool)(Convert.ToBoolean(obj34.gxTpr_Br_pathology_diag_tumorstage_N));
         n281BR_Pathology_Diag_TumorGrade = (bool)(Convert.ToBoolean(obj34.gxTpr_Br_pathology_diag_tumorgrade_N));
         Gx_mode = obj34.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A276BR_Pathology_DiagID = (long)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey0X34( ) ;
         ScanKeyStart0X34( ) ;
         if ( RcdFound34 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z276BR_Pathology_DiagID = A276BR_Pathology_DiagID;
         }
         ZM0X34( -8) ;
         OnLoadActions0X34( ) ;
         AddRow0X34( ) ;
         ScanKeyEnd0X34( ) ;
         if ( RcdFound34 == 0 )
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
         RowToVars34( bcBR_Pathology_Diag, 0) ;
         ScanKeyStart0X34( ) ;
         if ( RcdFound34 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z276BR_Pathology_DiagID = A276BR_Pathology_DiagID;
         }
         ZM0X34( -8) ;
         OnLoadActions0X34( ) ;
         AddRow0X34( ) ;
         ScanKeyEnd0X34( ) ;
         if ( RcdFound34 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey0X34( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert0X34( ) ;
         }
         else
         {
            if ( RcdFound34 == 1 )
            {
               if ( A276BR_Pathology_DiagID != Z276BR_Pathology_DiagID )
               {
                  A276BR_Pathology_DiagID = Z276BR_Pathology_DiagID;
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
                  Update0X34( ) ;
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
                  if ( A276BR_Pathology_DiagID != Z276BR_Pathology_DiagID )
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
                        Insert0X34( ) ;
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
                        Insert0X34( ) ;
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
         RowToVars34( bcBR_Pathology_Diag, 0) ;
         SaveImpl( ) ;
         VarsToRow34( bcBR_Pathology_Diag) ;
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
         RowToVars34( bcBR_Pathology_Diag, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert0X34( ) ;
         AfterTrn( ) ;
         VarsToRow34( bcBR_Pathology_Diag) ;
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
            SdtBR_Pathology_Diag auxBC = new SdtBR_Pathology_Diag(context) ;
            auxBC.Load(A276BR_Pathology_DiagID);
            auxBC.UpdateDirties(bcBR_Pathology_Diag);
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
         RowToVars34( bcBR_Pathology_Diag, 0) ;
         UpdateImpl( ) ;
         VarsToRow34( bcBR_Pathology_Diag) ;
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
         RowToVars34( bcBR_Pathology_Diag, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert0X34( ) ;
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
         VarsToRow34( bcBR_Pathology_Diag) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars34( bcBR_Pathology_Diag, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey0X34( ) ;
         if ( RcdFound34 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A276BR_Pathology_DiagID != Z276BR_Pathology_DiagID )
            {
               A276BR_Pathology_DiagID = Z276BR_Pathology_DiagID;
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
            if ( A276BR_Pathology_DiagID != Z276BR_Pathology_DiagID )
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
         context.RollbackDataStores("br_pathology_diag_bc",pr_default);
         VarsToRow34( bcBR_Pathology_Diag) ;
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
         Gx_mode = bcBR_Pathology_Diag.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcBR_Pathology_Diag.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcBR_Pathology_Diag )
         {
            bcBR_Pathology_Diag = (SdtBR_Pathology_Diag)(sdt);
            if ( StringUtil.StrCmp(bcBR_Pathology_Diag.gxTpr_Mode, "") == 0 )
            {
               bcBR_Pathology_Diag.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow34( bcBR_Pathology_Diag) ;
            }
            else
            {
               RowToVars34( bcBR_Pathology_Diag, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcBR_Pathology_Diag.gxTpr_Mode, "") == 0 )
            {
               bcBR_Pathology_Diag.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars34( bcBR_Pathology_Diag, 1) ;
         return  ;
      }

      public SdtBR_Pathology_Diag BR_Pathology_Diag_BC
      {
         get {
            return bcBR_Pathology_Diag ;
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
         Z277BR_Pathology_Diag_Loc = "";
         A277BR_Pathology_Diag_Loc = "";
         Z278BR_Pathology_Diag_Organ = "";
         A278BR_Pathology_Diag_Organ = "";
         Z279BR_Pathology_Diag_TumorType = "";
         A279BR_Pathology_Diag_TumorType = "";
         Z280BR_Pathology_Diag_TumorStage = "";
         A280BR_Pathology_Diag_TumorStage = "";
         Z281BR_Pathology_Diag_TumorGrade = "";
         A281BR_Pathology_Diag_TumorGrade = "";
         BC000X5_A276BR_Pathology_DiagID = new long[1] ;
         BC000X5_A277BR_Pathology_Diag_Loc = new String[] {""} ;
         BC000X5_n277BR_Pathology_Diag_Loc = new bool[] {false} ;
         BC000X5_A278BR_Pathology_Diag_Organ = new String[] {""} ;
         BC000X5_n278BR_Pathology_Diag_Organ = new bool[] {false} ;
         BC000X5_A279BR_Pathology_Diag_TumorType = new String[] {""} ;
         BC000X5_n279BR_Pathology_Diag_TumorType = new bool[] {false} ;
         BC000X5_A280BR_Pathology_Diag_TumorStage = new String[] {""} ;
         BC000X5_n280BR_Pathology_Diag_TumorStage = new bool[] {false} ;
         BC000X5_A281BR_Pathology_Diag_TumorGrade = new String[] {""} ;
         BC000X5_n281BR_Pathology_Diag_TumorGrade = new bool[] {false} ;
         BC000X5_A226BR_PathologyID = new long[1] ;
         BC000X5_n226BR_PathologyID = new bool[] {false} ;
         BC000X4_A226BR_PathologyID = new long[1] ;
         BC000X4_n226BR_PathologyID = new bool[] {false} ;
         BC000X6_A276BR_Pathology_DiagID = new long[1] ;
         BC000X3_A276BR_Pathology_DiagID = new long[1] ;
         BC000X3_A277BR_Pathology_Diag_Loc = new String[] {""} ;
         BC000X3_n277BR_Pathology_Diag_Loc = new bool[] {false} ;
         BC000X3_A278BR_Pathology_Diag_Organ = new String[] {""} ;
         BC000X3_n278BR_Pathology_Diag_Organ = new bool[] {false} ;
         BC000X3_A279BR_Pathology_Diag_TumorType = new String[] {""} ;
         BC000X3_n279BR_Pathology_Diag_TumorType = new bool[] {false} ;
         BC000X3_A280BR_Pathology_Diag_TumorStage = new String[] {""} ;
         BC000X3_n280BR_Pathology_Diag_TumorStage = new bool[] {false} ;
         BC000X3_A281BR_Pathology_Diag_TumorGrade = new String[] {""} ;
         BC000X3_n281BR_Pathology_Diag_TumorGrade = new bool[] {false} ;
         BC000X3_A226BR_PathologyID = new long[1] ;
         BC000X3_n226BR_PathologyID = new bool[] {false} ;
         sMode34 = "";
         BC000X2_A276BR_Pathology_DiagID = new long[1] ;
         BC000X2_A277BR_Pathology_Diag_Loc = new String[] {""} ;
         BC000X2_n277BR_Pathology_Diag_Loc = new bool[] {false} ;
         BC000X2_A278BR_Pathology_Diag_Organ = new String[] {""} ;
         BC000X2_n278BR_Pathology_Diag_Organ = new bool[] {false} ;
         BC000X2_A279BR_Pathology_Diag_TumorType = new String[] {""} ;
         BC000X2_n279BR_Pathology_Diag_TumorType = new bool[] {false} ;
         BC000X2_A280BR_Pathology_Diag_TumorStage = new String[] {""} ;
         BC000X2_n280BR_Pathology_Diag_TumorStage = new bool[] {false} ;
         BC000X2_A281BR_Pathology_Diag_TumorGrade = new String[] {""} ;
         BC000X2_n281BR_Pathology_Diag_TumorGrade = new bool[] {false} ;
         BC000X2_A226BR_PathologyID = new long[1] ;
         BC000X2_n226BR_PathologyID = new bool[] {false} ;
         BC000X7_A276BR_Pathology_DiagID = new long[1] ;
         BC000X10_A276BR_Pathology_DiagID = new long[1] ;
         BC000X10_A277BR_Pathology_Diag_Loc = new String[] {""} ;
         BC000X10_n277BR_Pathology_Diag_Loc = new bool[] {false} ;
         BC000X10_A278BR_Pathology_Diag_Organ = new String[] {""} ;
         BC000X10_n278BR_Pathology_Diag_Organ = new bool[] {false} ;
         BC000X10_A279BR_Pathology_Diag_TumorType = new String[] {""} ;
         BC000X10_n279BR_Pathology_Diag_TumorType = new bool[] {false} ;
         BC000X10_A280BR_Pathology_Diag_TumorStage = new String[] {""} ;
         BC000X10_n280BR_Pathology_Diag_TumorStage = new bool[] {false} ;
         BC000X10_A281BR_Pathology_Diag_TumorGrade = new String[] {""} ;
         BC000X10_n281BR_Pathology_Diag_TumorGrade = new bool[] {false} ;
         BC000X10_A226BR_PathologyID = new long[1] ;
         BC000X10_n226BR_PathologyID = new bool[] {false} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_pathology_diag_bc__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_pathology_diag_bc__default(),
            new Object[][] {
                new Object[] {
               BC000X2_A276BR_Pathology_DiagID, BC000X2_A277BR_Pathology_Diag_Loc, BC000X2_n277BR_Pathology_Diag_Loc, BC000X2_A278BR_Pathology_Diag_Organ, BC000X2_n278BR_Pathology_Diag_Organ, BC000X2_A279BR_Pathology_Diag_TumorType, BC000X2_n279BR_Pathology_Diag_TumorType, BC000X2_A280BR_Pathology_Diag_TumorStage, BC000X2_n280BR_Pathology_Diag_TumorStage, BC000X2_A281BR_Pathology_Diag_TumorGrade,
               BC000X2_n281BR_Pathology_Diag_TumorGrade, BC000X2_A226BR_PathologyID, BC000X2_n226BR_PathologyID
               }
               , new Object[] {
               BC000X3_A276BR_Pathology_DiagID, BC000X3_A277BR_Pathology_Diag_Loc, BC000X3_n277BR_Pathology_Diag_Loc, BC000X3_A278BR_Pathology_Diag_Organ, BC000X3_n278BR_Pathology_Diag_Organ, BC000X3_A279BR_Pathology_Diag_TumorType, BC000X3_n279BR_Pathology_Diag_TumorType, BC000X3_A280BR_Pathology_Diag_TumorStage, BC000X3_n280BR_Pathology_Diag_TumorStage, BC000X3_A281BR_Pathology_Diag_TumorGrade,
               BC000X3_n281BR_Pathology_Diag_TumorGrade, BC000X3_A226BR_PathologyID, BC000X3_n226BR_PathologyID
               }
               , new Object[] {
               BC000X4_A226BR_PathologyID
               }
               , new Object[] {
               BC000X5_A276BR_Pathology_DiagID, BC000X5_A277BR_Pathology_Diag_Loc, BC000X5_n277BR_Pathology_Diag_Loc, BC000X5_A278BR_Pathology_Diag_Organ, BC000X5_n278BR_Pathology_Diag_Organ, BC000X5_A279BR_Pathology_Diag_TumorType, BC000X5_n279BR_Pathology_Diag_TumorType, BC000X5_A280BR_Pathology_Diag_TumorStage, BC000X5_n280BR_Pathology_Diag_TumorStage, BC000X5_A281BR_Pathology_Diag_TumorGrade,
               BC000X5_n281BR_Pathology_Diag_TumorGrade, BC000X5_A226BR_PathologyID, BC000X5_n226BR_PathologyID
               }
               , new Object[] {
               BC000X6_A276BR_Pathology_DiagID
               }
               , new Object[] {
               BC000X7_A276BR_Pathology_DiagID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000X10_A276BR_Pathology_DiagID, BC000X10_A277BR_Pathology_Diag_Loc, BC000X10_n277BR_Pathology_Diag_Loc, BC000X10_A278BR_Pathology_Diag_Organ, BC000X10_n278BR_Pathology_Diag_Organ, BC000X10_A279BR_Pathology_Diag_TumorType, BC000X10_n279BR_Pathology_Diag_TumorType, BC000X10_A280BR_Pathology_Diag_TumorStage, BC000X10_n280BR_Pathology_Diag_TumorStage, BC000X10_A281BR_Pathology_Diag_TumorGrade,
               BC000X10_n281BR_Pathology_Diag_TumorGrade, BC000X10_A226BR_PathologyID, BC000X10_n226BR_PathologyID
               }
            }
         );
         AV16Pgmname = "BR_Pathology_Diag_BC";
         INITTRN();
         /* Execute Start event if defined. */
         /* Execute user event: Start */
         E120X2 ();
         standaloneNotModal( ) ;
      }

      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short GX_JID ;
      private short RcdFound34 ;
      private int trnEnded ;
      private int AV17GXV1 ;
      private long Z276BR_Pathology_DiagID ;
      private long A276BR_Pathology_DiagID ;
      private long AV13Insert_BR_PathologyID ;
      private long Z226BR_PathologyID ;
      private long A226BR_PathologyID ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String AV16Pgmname ;
      private String sMode34 ;
      private bool AV9IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool n277BR_Pathology_Diag_Loc ;
      private bool n278BR_Pathology_Diag_Organ ;
      private bool n279BR_Pathology_Diag_TumorType ;
      private bool n280BR_Pathology_Diag_TumorStage ;
      private bool n281BR_Pathology_Diag_TumorGrade ;
      private bool n226BR_PathologyID ;
      private bool Gx_longc ;
      private String Z277BR_Pathology_Diag_Loc ;
      private String A277BR_Pathology_Diag_Loc ;
      private String Z278BR_Pathology_Diag_Organ ;
      private String A278BR_Pathology_Diag_Organ ;
      private String Z279BR_Pathology_Diag_TumorType ;
      private String A279BR_Pathology_Diag_TumorType ;
      private String Z280BR_Pathology_Diag_TumorStage ;
      private String A280BR_Pathology_Diag_TumorStage ;
      private String Z281BR_Pathology_Diag_TumorGrade ;
      private String A281BR_Pathology_Diag_TumorGrade ;
      private IGxSession AV12WebSession ;
      private SdtBR_Pathology_Diag bcBR_Pathology_Diag ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] BC000X5_A276BR_Pathology_DiagID ;
      private String[] BC000X5_A277BR_Pathology_Diag_Loc ;
      private bool[] BC000X5_n277BR_Pathology_Diag_Loc ;
      private String[] BC000X5_A278BR_Pathology_Diag_Organ ;
      private bool[] BC000X5_n278BR_Pathology_Diag_Organ ;
      private String[] BC000X5_A279BR_Pathology_Diag_TumorType ;
      private bool[] BC000X5_n279BR_Pathology_Diag_TumorType ;
      private String[] BC000X5_A280BR_Pathology_Diag_TumorStage ;
      private bool[] BC000X5_n280BR_Pathology_Diag_TumorStage ;
      private String[] BC000X5_A281BR_Pathology_Diag_TumorGrade ;
      private bool[] BC000X5_n281BR_Pathology_Diag_TumorGrade ;
      private long[] BC000X5_A226BR_PathologyID ;
      private bool[] BC000X5_n226BR_PathologyID ;
      private long[] BC000X4_A226BR_PathologyID ;
      private bool[] BC000X4_n226BR_PathologyID ;
      private long[] BC000X6_A276BR_Pathology_DiagID ;
      private long[] BC000X3_A276BR_Pathology_DiagID ;
      private String[] BC000X3_A277BR_Pathology_Diag_Loc ;
      private bool[] BC000X3_n277BR_Pathology_Diag_Loc ;
      private String[] BC000X3_A278BR_Pathology_Diag_Organ ;
      private bool[] BC000X3_n278BR_Pathology_Diag_Organ ;
      private String[] BC000X3_A279BR_Pathology_Diag_TumorType ;
      private bool[] BC000X3_n279BR_Pathology_Diag_TumorType ;
      private String[] BC000X3_A280BR_Pathology_Diag_TumorStage ;
      private bool[] BC000X3_n280BR_Pathology_Diag_TumorStage ;
      private String[] BC000X3_A281BR_Pathology_Diag_TumorGrade ;
      private bool[] BC000X3_n281BR_Pathology_Diag_TumorGrade ;
      private long[] BC000X3_A226BR_PathologyID ;
      private bool[] BC000X3_n226BR_PathologyID ;
      private long[] BC000X2_A276BR_Pathology_DiagID ;
      private String[] BC000X2_A277BR_Pathology_Diag_Loc ;
      private bool[] BC000X2_n277BR_Pathology_Diag_Loc ;
      private String[] BC000X2_A278BR_Pathology_Diag_Organ ;
      private bool[] BC000X2_n278BR_Pathology_Diag_Organ ;
      private String[] BC000X2_A279BR_Pathology_Diag_TumorType ;
      private bool[] BC000X2_n279BR_Pathology_Diag_TumorType ;
      private String[] BC000X2_A280BR_Pathology_Diag_TumorStage ;
      private bool[] BC000X2_n280BR_Pathology_Diag_TumorStage ;
      private String[] BC000X2_A281BR_Pathology_Diag_TumorGrade ;
      private bool[] BC000X2_n281BR_Pathology_Diag_TumorGrade ;
      private long[] BC000X2_A226BR_PathologyID ;
      private bool[] BC000X2_n226BR_PathologyID ;
      private long[] BC000X7_A276BR_Pathology_DiagID ;
      private long[] BC000X10_A276BR_Pathology_DiagID ;
      private String[] BC000X10_A277BR_Pathology_Diag_Loc ;
      private bool[] BC000X10_n277BR_Pathology_Diag_Loc ;
      private String[] BC000X10_A278BR_Pathology_Diag_Organ ;
      private bool[] BC000X10_n278BR_Pathology_Diag_Organ ;
      private String[] BC000X10_A279BR_Pathology_Diag_TumorType ;
      private bool[] BC000X10_n279BR_Pathology_Diag_TumorType ;
      private String[] BC000X10_A280BR_Pathology_Diag_TumorStage ;
      private bool[] BC000X10_n280BR_Pathology_Diag_TumorStage ;
      private String[] BC000X10_A281BR_Pathology_Diag_TumorGrade ;
      private bool[] BC000X10_n281BR_Pathology_Diag_TumorGrade ;
      private long[] BC000X10_A226BR_PathologyID ;
      private bool[] BC000X10_n226BR_PathologyID ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_datastore1 ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV8WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV11TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV14TrnContextAtt ;
   }

   public class br_pathology_diag_bc__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class br_pathology_diag_bc__default : DataStoreHelperBase, IDataStoreHelper
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
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmBC000X5 ;
        prmBC000X5 = new Object[] {
        new Object[] {"@BR_Pathology_DiagID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000X4 ;
        prmBC000X4 = new Object[] {
        new Object[] {"@BR_PathologyID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000X6 ;
        prmBC000X6 = new Object[] {
        new Object[] {"@BR_Pathology_DiagID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000X3 ;
        prmBC000X3 = new Object[] {
        new Object[] {"@BR_Pathology_DiagID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000X2 ;
        prmBC000X2 = new Object[] {
        new Object[] {"@BR_Pathology_DiagID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000X7 ;
        prmBC000X7 = new Object[] {
        new Object[] {"@BR_Pathology_Diag_Loc",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Pathology_Diag_Organ",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Pathology_Diag_TumorType",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Pathology_Diag_TumorStage",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Pathology_Diag_TumorGrade",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_PathologyID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000X8 ;
        prmBC000X8 = new Object[] {
        new Object[] {"@BR_Pathology_Diag_Loc",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Pathology_Diag_Organ",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Pathology_Diag_TumorType",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Pathology_Diag_TumorStage",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Pathology_Diag_TumorGrade",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_PathologyID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_Pathology_DiagID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000X9 ;
        prmBC000X9 = new Object[] {
        new Object[] {"@BR_Pathology_DiagID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000X10 ;
        prmBC000X10 = new Object[] {
        new Object[] {"@BR_Pathology_DiagID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("BC000X2", "SELECT [BR_Pathology_DiagID], [BR_Pathology_Diag_Loc], [BR_Pathology_Diag_Organ], [BR_Pathology_Diag_TumorType], [BR_Pathology_Diag_TumorStage], [BR_Pathology_Diag_TumorGrade], [BR_PathologyID] FROM [BR_Pathology_Diag] WITH (UPDLOCK) WHERE [BR_Pathology_DiagID] = @BR_Pathology_DiagID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000X2,1,0,true,false )
           ,new CursorDef("BC000X3", "SELECT [BR_Pathology_DiagID], [BR_Pathology_Diag_Loc], [BR_Pathology_Diag_Organ], [BR_Pathology_Diag_TumorType], [BR_Pathology_Diag_TumorStage], [BR_Pathology_Diag_TumorGrade], [BR_PathologyID] FROM [BR_Pathology_Diag] WITH (NOLOCK) WHERE [BR_Pathology_DiagID] = @BR_Pathology_DiagID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000X3,1,0,true,false )
           ,new CursorDef("BC000X4", "SELECT [BR_PathologyID] FROM [BR_Pathology] WITH (NOLOCK) WHERE [BR_PathologyID] = @BR_PathologyID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000X4,1,0,true,false )
           ,new CursorDef("BC000X5", "SELECT TM1.[BR_Pathology_DiagID], TM1.[BR_Pathology_Diag_Loc], TM1.[BR_Pathology_Diag_Organ], TM1.[BR_Pathology_Diag_TumorType], TM1.[BR_Pathology_Diag_TumorStage], TM1.[BR_Pathology_Diag_TumorGrade], TM1.[BR_PathologyID] FROM [BR_Pathology_Diag] TM1 WITH (NOLOCK) WHERE TM1.[BR_Pathology_DiagID] = @BR_Pathology_DiagID ORDER BY TM1.[BR_Pathology_DiagID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000X5,100,0,true,false )
           ,new CursorDef("BC000X6", "SELECT [BR_Pathology_DiagID] FROM [BR_Pathology_Diag] WITH (NOLOCK) WHERE [BR_Pathology_DiagID] = @BR_Pathology_DiagID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000X6,1,0,true,false )
           ,new CursorDef("BC000X7", "INSERT INTO [BR_Pathology_Diag]([BR_Pathology_Diag_Loc], [BR_Pathology_Diag_Organ], [BR_Pathology_Diag_TumorType], [BR_Pathology_Diag_TumorStage], [BR_Pathology_Diag_TumorGrade], [BR_PathologyID]) VALUES(@BR_Pathology_Diag_Loc, @BR_Pathology_Diag_Organ, @BR_Pathology_Diag_TumorType, @BR_Pathology_Diag_TumorStage, @BR_Pathology_Diag_TumorGrade, @BR_PathologyID); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmBC000X7)
           ,new CursorDef("BC000X8", "UPDATE [BR_Pathology_Diag] SET [BR_Pathology_Diag_Loc]=@BR_Pathology_Diag_Loc, [BR_Pathology_Diag_Organ]=@BR_Pathology_Diag_Organ, [BR_Pathology_Diag_TumorType]=@BR_Pathology_Diag_TumorType, [BR_Pathology_Diag_TumorStage]=@BR_Pathology_Diag_TumorStage, [BR_Pathology_Diag_TumorGrade]=@BR_Pathology_Diag_TumorGrade, [BR_PathologyID]=@BR_PathologyID  WHERE [BR_Pathology_DiagID] = @BR_Pathology_DiagID", GxErrorMask.GX_NOMASK,prmBC000X8)
           ,new CursorDef("BC000X9", "DELETE FROM [BR_Pathology_Diag]  WHERE [BR_Pathology_DiagID] = @BR_Pathology_DiagID", GxErrorMask.GX_NOMASK,prmBC000X9)
           ,new CursorDef("BC000X10", "SELECT TM1.[BR_Pathology_DiagID], TM1.[BR_Pathology_Diag_Loc], TM1.[BR_Pathology_Diag_Organ], TM1.[BR_Pathology_Diag_TumorType], TM1.[BR_Pathology_Diag_TumorStage], TM1.[BR_Pathology_Diag_TumorGrade], TM1.[BR_PathologyID] FROM [BR_Pathology_Diag] TM1 WITH (NOLOCK) WHERE TM1.[BR_Pathology_DiagID] = @BR_Pathology_DiagID ORDER BY TM1.[BR_Pathology_DiagID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000X10,100,0,true,false )
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
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((long[]) buf[11])[0] = rslt.getLong(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((long[]) buf[11])[0] = rslt.getLong(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              return;
           case 2 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 3 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((long[]) buf[11])[0] = rslt.getLong(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              return;
           case 4 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 5 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 8 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
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
                 stmt.setNull( 2 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(2, (String)parms[3]);
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
                 stmt.setNull( 5 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(5, (String)parms[9]);
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
                 stmt.setNull( 5 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(5, (String)parms[9]);
              }
              if ( (bool)parms[10] )
              {
                 stmt.setNull( 6 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(6, (long)parms[11]);
              }
              stmt.SetParameter(7, (long)parms[12]);
              return;
           case 7 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 8 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
     }
  }

}

}
