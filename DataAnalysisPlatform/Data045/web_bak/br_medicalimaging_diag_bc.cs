/*
               File: BR_MedicalImaging_Diag_BC
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:37:37.27
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
   public class br_medicalimaging_diag_bc : GXHttpHandler, IGxSilentTrn
   {
      public br_medicalimaging_diag_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_medicalimaging_diag_bc( IGxContext context )
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
         ReadRow0S29( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey0S29( ) ;
         standaloneModal( ) ;
         AddRow0S29( ) ;
         Gx_mode = "INS";
         return  ;
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E110S2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               Z270BR_MedicalImaging_DiagID = A270BR_MedicalImaging_DiagID;
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

      protected void CONFIRM_0S0( )
      {
         BeforeValidate0S29( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0S29( ) ;
            }
            else
            {
               CheckExtendedTable0S29( ) ;
               if ( AnyError == 0 )
               {
                  ZM0S29( 9) ;
               }
               CloseExtendedTableCursors0S29( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void E120S2( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV8WWPContext) ;
         AV9IsAuthorized = true;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_MedicalImaging_Diag", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_MedicalImaging_Diag", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_MedicalImaging_Diag", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
         }
         if ( ! AV9IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV15Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV11TrnContext.FromXml(AV12WebSession.Get("TrnContext"), null, "WWPTransactionContext", "DataAnalysisPlatform");
         if ( ( StringUtil.StrCmp(AV11TrnContext.gxTpr_Transactionname, AV15Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV16GXV1 = 1;
            while ( AV16GXV1 <= AV11TrnContext.gxTpr_Attributes.Count )
            {
               AV14TrnContextAtt = ((GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute)AV11TrnContext.gxTpr_Attributes.Item(AV16GXV1));
               if ( StringUtil.StrCmp(AV14TrnContextAtt.gxTpr_Attributename, "BR_MedicalImagingID") == 0 )
               {
                  AV13Insert_BR_MedicalImagingID = (long)(NumberUtil.Val( AV14TrnContextAtt.gxTpr_Attributevalue, "."));
               }
               AV16GXV1 = (int)(AV16GXV1+1);
            }
         }
      }

      protected void E110S2( )
      {
         /* After Trn Routine */
      }

      protected void ZM0S29( short GX_JID )
      {
         if ( ( GX_JID == 8 ) || ( GX_JID == 0 ) )
         {
            Z271BR_MedicalImaging_Diag_Loc = A271BR_MedicalImaging_Diag_Loc;
            Z272BR_MedicalImaging_Diag_Organ = A272BR_MedicalImaging_Diag_Organ;
            Z273BR_MedicalImaging_Diag_Dis = A273BR_MedicalImaging_Diag_Dis;
            Z517BR_MedicalImaging_Diag_No = A517BR_MedicalImaging_Diag_No;
            Z225BR_MedicalImagingID = A225BR_MedicalImagingID;
         }
         if ( ( GX_JID == 9 ) || ( GX_JID == 0 ) )
         {
         }
         if ( GX_JID == -8 )
         {
            Z270BR_MedicalImaging_DiagID = A270BR_MedicalImaging_DiagID;
            Z271BR_MedicalImaging_Diag_Loc = A271BR_MedicalImaging_Diag_Loc;
            Z272BR_MedicalImaging_Diag_Organ = A272BR_MedicalImaging_Diag_Organ;
            Z273BR_MedicalImaging_Diag_Dis = A273BR_MedicalImaging_Diag_Dis;
            Z517BR_MedicalImaging_Diag_No = A517BR_MedicalImaging_Diag_No;
            Z225BR_MedicalImagingID = A225BR_MedicalImagingID;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load0S29( )
      {
         /* Using cursor BC000S5 */
         pr_default.execute(3, new Object[] {A270BR_MedicalImaging_DiagID});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound29 = 1;
            A271BR_MedicalImaging_Diag_Loc = BC000S5_A271BR_MedicalImaging_Diag_Loc[0];
            n271BR_MedicalImaging_Diag_Loc = BC000S5_n271BR_MedicalImaging_Diag_Loc[0];
            A272BR_MedicalImaging_Diag_Organ = BC000S5_A272BR_MedicalImaging_Diag_Organ[0];
            n272BR_MedicalImaging_Diag_Organ = BC000S5_n272BR_MedicalImaging_Diag_Organ[0];
            A273BR_MedicalImaging_Diag_Dis = BC000S5_A273BR_MedicalImaging_Diag_Dis[0];
            n273BR_MedicalImaging_Diag_Dis = BC000S5_n273BR_MedicalImaging_Diag_Dis[0];
            A517BR_MedicalImaging_Diag_No = BC000S5_A517BR_MedicalImaging_Diag_No[0];
            n517BR_MedicalImaging_Diag_No = BC000S5_n517BR_MedicalImaging_Diag_No[0];
            A225BR_MedicalImagingID = BC000S5_A225BR_MedicalImagingID[0];
            n225BR_MedicalImagingID = BC000S5_n225BR_MedicalImagingID[0];
            ZM0S29( -8) ;
         }
         pr_default.close(3);
         OnLoadActions0S29( ) ;
      }

      protected void OnLoadActions0S29( )
      {
         AV15Pgmname = "BR_MedicalImaging_Diag_BC";
      }

      protected void CheckExtendedTable0S29( )
      {
         standaloneModal( ) ;
         AV15Pgmname = "BR_MedicalImaging_Diag_BC";
         /* Using cursor BC000S4 */
         pr_default.execute(2, new Object[] {n225BR_MedicalImagingID, A225BR_MedicalImagingID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            if ( ! ( (0==A225BR_MedicalImagingID) ) )
            {
               GX_msglist.addItem("不匹配' T30'", "ForeignKeyNotFound", 1, "BR_MEDICALIMAGINGID");
               AnyError = 1;
            }
         }
         pr_default.close(2);
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A271BR_MedicalImaging_Diag_Loc)) )
         {
            GX_msglist.addItem("诊断意见(部位)是必须填写的。", 1, "");
            AnyError = 1;
         }
         if ( (0==A517BR_MedicalImaging_Diag_No) )
         {
            GX_msglist.addItem("序号是必须填写的。", 1, "");
            AnyError = 1;
         }
      }

      protected void CloseExtendedTableCursors0S29( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0S29( )
      {
         /* Using cursor BC000S6 */
         pr_default.execute(4, new Object[] {A270BR_MedicalImaging_DiagID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound29 = 1;
         }
         else
         {
            RcdFound29 = 0;
         }
         pr_default.close(4);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC000S3 */
         pr_default.execute(1, new Object[] {A270BR_MedicalImaging_DiagID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0S29( 8) ;
            RcdFound29 = 1;
            A270BR_MedicalImaging_DiagID = BC000S3_A270BR_MedicalImaging_DiagID[0];
            A271BR_MedicalImaging_Diag_Loc = BC000S3_A271BR_MedicalImaging_Diag_Loc[0];
            n271BR_MedicalImaging_Diag_Loc = BC000S3_n271BR_MedicalImaging_Diag_Loc[0];
            A272BR_MedicalImaging_Diag_Organ = BC000S3_A272BR_MedicalImaging_Diag_Organ[0];
            n272BR_MedicalImaging_Diag_Organ = BC000S3_n272BR_MedicalImaging_Diag_Organ[0];
            A273BR_MedicalImaging_Diag_Dis = BC000S3_A273BR_MedicalImaging_Diag_Dis[0];
            n273BR_MedicalImaging_Diag_Dis = BC000S3_n273BR_MedicalImaging_Diag_Dis[0];
            A517BR_MedicalImaging_Diag_No = BC000S3_A517BR_MedicalImaging_Diag_No[0];
            n517BR_MedicalImaging_Diag_No = BC000S3_n517BR_MedicalImaging_Diag_No[0];
            A225BR_MedicalImagingID = BC000S3_A225BR_MedicalImagingID[0];
            n225BR_MedicalImagingID = BC000S3_n225BR_MedicalImagingID[0];
            Z270BR_MedicalImaging_DiagID = A270BR_MedicalImaging_DiagID;
            sMode29 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load0S29( ) ;
            if ( AnyError == 1 )
            {
               RcdFound29 = 0;
               InitializeNonKey0S29( ) ;
            }
            Gx_mode = sMode29;
         }
         else
         {
            RcdFound29 = 0;
            InitializeNonKey0S29( ) ;
            sMode29 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode29;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0S29( ) ;
         if ( RcdFound29 == 0 )
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
         CONFIRM_0S0( ) ;
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

      protected void CheckOptimisticConcurrency0S29( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC000S2 */
            pr_default.execute(0, new Object[] {A270BR_MedicalImaging_DiagID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_MedicalImaging_Diag"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z271BR_MedicalImaging_Diag_Loc, BC000S2_A271BR_MedicalImaging_Diag_Loc[0]) != 0 ) || ( StringUtil.StrCmp(Z272BR_MedicalImaging_Diag_Organ, BC000S2_A272BR_MedicalImaging_Diag_Organ[0]) != 0 ) || ( StringUtil.StrCmp(Z273BR_MedicalImaging_Diag_Dis, BC000S2_A273BR_MedicalImaging_Diag_Dis[0]) != 0 ) || ( Z517BR_MedicalImaging_Diag_No != BC000S2_A517BR_MedicalImaging_Diag_No[0] ) || ( Z225BR_MedicalImagingID != BC000S2_A225BR_MedicalImagingID[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"BR_MedicalImaging_Diag"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0S29( )
      {
         BeforeValidate0S29( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0S29( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0S29( 0) ;
            CheckOptimisticConcurrency0S29( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0S29( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0S29( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000S7 */
                     pr_default.execute(5, new Object[] {n271BR_MedicalImaging_Diag_Loc, A271BR_MedicalImaging_Diag_Loc, n272BR_MedicalImaging_Diag_Organ, A272BR_MedicalImaging_Diag_Organ, n273BR_MedicalImaging_Diag_Dis, A273BR_MedicalImaging_Diag_Dis, n517BR_MedicalImaging_Diag_No, A517BR_MedicalImaging_Diag_No, n225BR_MedicalImagingID, A225BR_MedicalImagingID});
                     A270BR_MedicalImaging_DiagID = BC000S7_A270BR_MedicalImaging_DiagID[0];
                     pr_default.close(5);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_MedicalImaging_Diag") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A225BR_MedicalImagingID), 18, 0)),  "影像学",  StringUtil.Trim( StringUtil.Str( (decimal)(A270BR_MedicalImaging_DiagID), 18, 0)),  "诊断意见",  "Create",  1) ;
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
               Load0S29( ) ;
            }
            EndLevel0S29( ) ;
         }
         CloseExtendedTableCursors0S29( ) ;
      }

      protected void Update0S29( )
      {
         BeforeValidate0S29( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0S29( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0S29( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0S29( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0S29( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000S8 */
                     pr_default.execute(6, new Object[] {n271BR_MedicalImaging_Diag_Loc, A271BR_MedicalImaging_Diag_Loc, n272BR_MedicalImaging_Diag_Organ, A272BR_MedicalImaging_Diag_Organ, n273BR_MedicalImaging_Diag_Dis, A273BR_MedicalImaging_Diag_Dis, n517BR_MedicalImaging_Diag_No, A517BR_MedicalImaging_Diag_No, n225BR_MedicalImagingID, A225BR_MedicalImagingID, A270BR_MedicalImaging_DiagID});
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_MedicalImaging_Diag") ;
                     if ( (pr_default.getStatus(6) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_MedicalImaging_Diag"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0S29( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A225BR_MedicalImagingID), 18, 0)),  "影像学",  StringUtil.Trim( StringUtil.Str( (decimal)(A270BR_MedicalImaging_DiagID), 18, 0)),  "诊断意见",  "Update",  1) ;
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
            EndLevel0S29( ) ;
         }
         CloseExtendedTableCursors0S29( ) ;
      }

      protected void DeferredUpdate0S29( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate0S29( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0S29( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0S29( ) ;
            AfterConfirm0S29( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0S29( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC000S9 */
                  pr_default.execute(7, new Object[] {A270BR_MedicalImaging_DiagID});
                  pr_default.close(7);
                  dsDefault.SmartCacheProvider.SetUpdated("BR_MedicalImaging_Diag") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A225BR_MedicalImagingID), 18, 0)),  "影像学",  StringUtil.Trim( StringUtil.Str( (decimal)(A270BR_MedicalImaging_DiagID), 18, 0)),  "诊断意见",  "Delete",  1) ;
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
         sMode29 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel0S29( ) ;
         Gx_mode = sMode29;
      }

      protected void OnDeleteControls0S29( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV15Pgmname = "BR_MedicalImaging_Diag_BC";
         }
      }

      protected void EndLevel0S29( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0S29( ) ;
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

      public void ScanKeyStart0S29( )
      {
         /* Scan By routine */
         /* Using cursor BC000S10 */
         pr_default.execute(8, new Object[] {A270BR_MedicalImaging_DiagID});
         RcdFound29 = 0;
         if ( (pr_default.getStatus(8) != 101) )
         {
            RcdFound29 = 1;
            A270BR_MedicalImaging_DiagID = BC000S10_A270BR_MedicalImaging_DiagID[0];
            A271BR_MedicalImaging_Diag_Loc = BC000S10_A271BR_MedicalImaging_Diag_Loc[0];
            n271BR_MedicalImaging_Diag_Loc = BC000S10_n271BR_MedicalImaging_Diag_Loc[0];
            A272BR_MedicalImaging_Diag_Organ = BC000S10_A272BR_MedicalImaging_Diag_Organ[0];
            n272BR_MedicalImaging_Diag_Organ = BC000S10_n272BR_MedicalImaging_Diag_Organ[0];
            A273BR_MedicalImaging_Diag_Dis = BC000S10_A273BR_MedicalImaging_Diag_Dis[0];
            n273BR_MedicalImaging_Diag_Dis = BC000S10_n273BR_MedicalImaging_Diag_Dis[0];
            A517BR_MedicalImaging_Diag_No = BC000S10_A517BR_MedicalImaging_Diag_No[0];
            n517BR_MedicalImaging_Diag_No = BC000S10_n517BR_MedicalImaging_Diag_No[0];
            A225BR_MedicalImagingID = BC000S10_A225BR_MedicalImagingID[0];
            n225BR_MedicalImagingID = BC000S10_n225BR_MedicalImagingID[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext0S29( )
      {
         /* Scan next routine */
         pr_default.readNext(8);
         RcdFound29 = 0;
         ScanKeyLoad0S29( ) ;
      }

      protected void ScanKeyLoad0S29( )
      {
         sMode29 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(8) != 101) )
         {
            RcdFound29 = 1;
            A270BR_MedicalImaging_DiagID = BC000S10_A270BR_MedicalImaging_DiagID[0];
            A271BR_MedicalImaging_Diag_Loc = BC000S10_A271BR_MedicalImaging_Diag_Loc[0];
            n271BR_MedicalImaging_Diag_Loc = BC000S10_n271BR_MedicalImaging_Diag_Loc[0];
            A272BR_MedicalImaging_Diag_Organ = BC000S10_A272BR_MedicalImaging_Diag_Organ[0];
            n272BR_MedicalImaging_Diag_Organ = BC000S10_n272BR_MedicalImaging_Diag_Organ[0];
            A273BR_MedicalImaging_Diag_Dis = BC000S10_A273BR_MedicalImaging_Diag_Dis[0];
            n273BR_MedicalImaging_Diag_Dis = BC000S10_n273BR_MedicalImaging_Diag_Dis[0];
            A517BR_MedicalImaging_Diag_No = BC000S10_A517BR_MedicalImaging_Diag_No[0];
            n517BR_MedicalImaging_Diag_No = BC000S10_n517BR_MedicalImaging_Diag_No[0];
            A225BR_MedicalImagingID = BC000S10_A225BR_MedicalImagingID[0];
            n225BR_MedicalImagingID = BC000S10_n225BR_MedicalImagingID[0];
         }
         Gx_mode = sMode29;
      }

      protected void ScanKeyEnd0S29( )
      {
         pr_default.close(8);
      }

      protected void AfterConfirm0S29( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0S29( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0S29( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0S29( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0S29( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0S29( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0S29( )
      {
      }

      protected void send_integrity_lvl_hashes0S29( )
      {
      }

      protected void AddRow0S29( )
      {
         VarsToRow29( bcBR_MedicalImaging_Diag) ;
      }

      protected void ReadRow0S29( )
      {
         RowToVars29( bcBR_MedicalImaging_Diag, 1) ;
      }

      protected void InitializeNonKey0S29( )
      {
         A225BR_MedicalImagingID = 0;
         n225BR_MedicalImagingID = false;
         A271BR_MedicalImaging_Diag_Loc = "";
         n271BR_MedicalImaging_Diag_Loc = false;
         A272BR_MedicalImaging_Diag_Organ = "";
         n272BR_MedicalImaging_Diag_Organ = false;
         A273BR_MedicalImaging_Diag_Dis = "";
         n273BR_MedicalImaging_Diag_Dis = false;
         A517BR_MedicalImaging_Diag_No = 0;
         n517BR_MedicalImaging_Diag_No = false;
         Z271BR_MedicalImaging_Diag_Loc = "";
         Z272BR_MedicalImaging_Diag_Organ = "";
         Z273BR_MedicalImaging_Diag_Dis = "";
         Z517BR_MedicalImaging_Diag_No = 0;
         Z225BR_MedicalImagingID = 0;
      }

      protected void InitAll0S29( )
      {
         A270BR_MedicalImaging_DiagID = 0;
         InitializeNonKey0S29( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow29( SdtBR_MedicalImaging_Diag obj29 )
      {
         obj29.gxTpr_Mode = Gx_mode;
         obj29.gxTpr_Br_medicalimagingid = A225BR_MedicalImagingID;
         obj29.gxTpr_Br_medicalimaging_diag_loc = A271BR_MedicalImaging_Diag_Loc;
         obj29.gxTpr_Br_medicalimaging_diag_organ = A272BR_MedicalImaging_Diag_Organ;
         obj29.gxTpr_Br_medicalimaging_diag_dis = A273BR_MedicalImaging_Diag_Dis;
         obj29.gxTpr_Br_medicalimaging_diag_no = A517BR_MedicalImaging_Diag_No;
         obj29.gxTpr_Br_medicalimaging_diagid = A270BR_MedicalImaging_DiagID;
         obj29.gxTpr_Br_medicalimaging_diagid_Z = Z270BR_MedicalImaging_DiagID;
         obj29.gxTpr_Br_medicalimagingid_Z = Z225BR_MedicalImagingID;
         obj29.gxTpr_Br_medicalimaging_diag_loc_Z = Z271BR_MedicalImaging_Diag_Loc;
         obj29.gxTpr_Br_medicalimaging_diag_organ_Z = Z272BR_MedicalImaging_Diag_Organ;
         obj29.gxTpr_Br_medicalimaging_diag_dis_Z = Z273BR_MedicalImaging_Diag_Dis;
         obj29.gxTpr_Br_medicalimaging_diag_no_Z = Z517BR_MedicalImaging_Diag_No;
         obj29.gxTpr_Br_medicalimagingid_N = (short)(Convert.ToInt16(n225BR_MedicalImagingID));
         obj29.gxTpr_Br_medicalimaging_diag_loc_N = (short)(Convert.ToInt16(n271BR_MedicalImaging_Diag_Loc));
         obj29.gxTpr_Br_medicalimaging_diag_organ_N = (short)(Convert.ToInt16(n272BR_MedicalImaging_Diag_Organ));
         obj29.gxTpr_Br_medicalimaging_diag_dis_N = (short)(Convert.ToInt16(n273BR_MedicalImaging_Diag_Dis));
         obj29.gxTpr_Br_medicalimaging_diag_no_N = (short)(Convert.ToInt16(n517BR_MedicalImaging_Diag_No));
         obj29.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow29( SdtBR_MedicalImaging_Diag obj29 )
      {
         obj29.gxTpr_Br_medicalimaging_diagid = A270BR_MedicalImaging_DiagID;
         return  ;
      }

      public void RowToVars29( SdtBR_MedicalImaging_Diag obj29 ,
                               int forceLoad )
      {
         Gx_mode = obj29.gxTpr_Mode;
         A225BR_MedicalImagingID = obj29.gxTpr_Br_medicalimagingid;
         n225BR_MedicalImagingID = false;
         A271BR_MedicalImaging_Diag_Loc = obj29.gxTpr_Br_medicalimaging_diag_loc;
         n271BR_MedicalImaging_Diag_Loc = false;
         A272BR_MedicalImaging_Diag_Organ = obj29.gxTpr_Br_medicalimaging_diag_organ;
         n272BR_MedicalImaging_Diag_Organ = false;
         A273BR_MedicalImaging_Diag_Dis = obj29.gxTpr_Br_medicalimaging_diag_dis;
         n273BR_MedicalImaging_Diag_Dis = false;
         A517BR_MedicalImaging_Diag_No = obj29.gxTpr_Br_medicalimaging_diag_no;
         n517BR_MedicalImaging_Diag_No = false;
         A270BR_MedicalImaging_DiagID = obj29.gxTpr_Br_medicalimaging_diagid;
         Z270BR_MedicalImaging_DiagID = obj29.gxTpr_Br_medicalimaging_diagid_Z;
         Z225BR_MedicalImagingID = obj29.gxTpr_Br_medicalimagingid_Z;
         Z271BR_MedicalImaging_Diag_Loc = obj29.gxTpr_Br_medicalimaging_diag_loc_Z;
         Z272BR_MedicalImaging_Diag_Organ = obj29.gxTpr_Br_medicalimaging_diag_organ_Z;
         Z273BR_MedicalImaging_Diag_Dis = obj29.gxTpr_Br_medicalimaging_diag_dis_Z;
         Z517BR_MedicalImaging_Diag_No = obj29.gxTpr_Br_medicalimaging_diag_no_Z;
         n225BR_MedicalImagingID = (bool)(Convert.ToBoolean(obj29.gxTpr_Br_medicalimagingid_N));
         n271BR_MedicalImaging_Diag_Loc = (bool)(Convert.ToBoolean(obj29.gxTpr_Br_medicalimaging_diag_loc_N));
         n272BR_MedicalImaging_Diag_Organ = (bool)(Convert.ToBoolean(obj29.gxTpr_Br_medicalimaging_diag_organ_N));
         n273BR_MedicalImaging_Diag_Dis = (bool)(Convert.ToBoolean(obj29.gxTpr_Br_medicalimaging_diag_dis_N));
         n517BR_MedicalImaging_Diag_No = (bool)(Convert.ToBoolean(obj29.gxTpr_Br_medicalimaging_diag_no_N));
         Gx_mode = obj29.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A270BR_MedicalImaging_DiagID = (long)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey0S29( ) ;
         ScanKeyStart0S29( ) ;
         if ( RcdFound29 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z270BR_MedicalImaging_DiagID = A270BR_MedicalImaging_DiagID;
         }
         ZM0S29( -8) ;
         OnLoadActions0S29( ) ;
         AddRow0S29( ) ;
         ScanKeyEnd0S29( ) ;
         if ( RcdFound29 == 0 )
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
         RowToVars29( bcBR_MedicalImaging_Diag, 0) ;
         ScanKeyStart0S29( ) ;
         if ( RcdFound29 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z270BR_MedicalImaging_DiagID = A270BR_MedicalImaging_DiagID;
         }
         ZM0S29( -8) ;
         OnLoadActions0S29( ) ;
         AddRow0S29( ) ;
         ScanKeyEnd0S29( ) ;
         if ( RcdFound29 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey0S29( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert0S29( ) ;
         }
         else
         {
            if ( RcdFound29 == 1 )
            {
               if ( A270BR_MedicalImaging_DiagID != Z270BR_MedicalImaging_DiagID )
               {
                  A270BR_MedicalImaging_DiagID = Z270BR_MedicalImaging_DiagID;
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
                  Update0S29( ) ;
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
                  if ( A270BR_MedicalImaging_DiagID != Z270BR_MedicalImaging_DiagID )
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
                        Insert0S29( ) ;
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
                        Insert0S29( ) ;
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
         RowToVars29( bcBR_MedicalImaging_Diag, 0) ;
         SaveImpl( ) ;
         VarsToRow29( bcBR_MedicalImaging_Diag) ;
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
         RowToVars29( bcBR_MedicalImaging_Diag, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert0S29( ) ;
         AfterTrn( ) ;
         VarsToRow29( bcBR_MedicalImaging_Diag) ;
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
            SdtBR_MedicalImaging_Diag auxBC = new SdtBR_MedicalImaging_Diag(context) ;
            auxBC.Load(A270BR_MedicalImaging_DiagID);
            auxBC.UpdateDirties(bcBR_MedicalImaging_Diag);
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
         RowToVars29( bcBR_MedicalImaging_Diag, 0) ;
         UpdateImpl( ) ;
         VarsToRow29( bcBR_MedicalImaging_Diag) ;
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
         RowToVars29( bcBR_MedicalImaging_Diag, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert0S29( ) ;
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
         VarsToRow29( bcBR_MedicalImaging_Diag) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars29( bcBR_MedicalImaging_Diag, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey0S29( ) ;
         if ( RcdFound29 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A270BR_MedicalImaging_DiagID != Z270BR_MedicalImaging_DiagID )
            {
               A270BR_MedicalImaging_DiagID = Z270BR_MedicalImaging_DiagID;
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
            if ( A270BR_MedicalImaging_DiagID != Z270BR_MedicalImaging_DiagID )
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
         context.RollbackDataStores("br_medicalimaging_diag_bc",pr_default);
         VarsToRow29( bcBR_MedicalImaging_Diag) ;
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
         Gx_mode = bcBR_MedicalImaging_Diag.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcBR_MedicalImaging_Diag.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcBR_MedicalImaging_Diag )
         {
            bcBR_MedicalImaging_Diag = (SdtBR_MedicalImaging_Diag)(sdt);
            if ( StringUtil.StrCmp(bcBR_MedicalImaging_Diag.gxTpr_Mode, "") == 0 )
            {
               bcBR_MedicalImaging_Diag.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow29( bcBR_MedicalImaging_Diag) ;
            }
            else
            {
               RowToVars29( bcBR_MedicalImaging_Diag, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcBR_MedicalImaging_Diag.gxTpr_Mode, "") == 0 )
            {
               bcBR_MedicalImaging_Diag.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars29( bcBR_MedicalImaging_Diag, 1) ;
         return  ;
      }

      public SdtBR_MedicalImaging_Diag BR_MedicalImaging_Diag_BC
      {
         get {
            return bcBR_MedicalImaging_Diag ;
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
         AV15Pgmname = "";
         AV11TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV12WebSession = context.GetSession();
         AV14TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         Z271BR_MedicalImaging_Diag_Loc = "";
         A271BR_MedicalImaging_Diag_Loc = "";
         Z272BR_MedicalImaging_Diag_Organ = "";
         A272BR_MedicalImaging_Diag_Organ = "";
         Z273BR_MedicalImaging_Diag_Dis = "";
         A273BR_MedicalImaging_Diag_Dis = "";
         BC000S5_A270BR_MedicalImaging_DiagID = new long[1] ;
         BC000S5_A271BR_MedicalImaging_Diag_Loc = new String[] {""} ;
         BC000S5_n271BR_MedicalImaging_Diag_Loc = new bool[] {false} ;
         BC000S5_A272BR_MedicalImaging_Diag_Organ = new String[] {""} ;
         BC000S5_n272BR_MedicalImaging_Diag_Organ = new bool[] {false} ;
         BC000S5_A273BR_MedicalImaging_Diag_Dis = new String[] {""} ;
         BC000S5_n273BR_MedicalImaging_Diag_Dis = new bool[] {false} ;
         BC000S5_A517BR_MedicalImaging_Diag_No = new long[1] ;
         BC000S5_n517BR_MedicalImaging_Diag_No = new bool[] {false} ;
         BC000S5_A225BR_MedicalImagingID = new long[1] ;
         BC000S5_n225BR_MedicalImagingID = new bool[] {false} ;
         BC000S4_A225BR_MedicalImagingID = new long[1] ;
         BC000S4_n225BR_MedicalImagingID = new bool[] {false} ;
         BC000S6_A270BR_MedicalImaging_DiagID = new long[1] ;
         BC000S3_A270BR_MedicalImaging_DiagID = new long[1] ;
         BC000S3_A271BR_MedicalImaging_Diag_Loc = new String[] {""} ;
         BC000S3_n271BR_MedicalImaging_Diag_Loc = new bool[] {false} ;
         BC000S3_A272BR_MedicalImaging_Diag_Organ = new String[] {""} ;
         BC000S3_n272BR_MedicalImaging_Diag_Organ = new bool[] {false} ;
         BC000S3_A273BR_MedicalImaging_Diag_Dis = new String[] {""} ;
         BC000S3_n273BR_MedicalImaging_Diag_Dis = new bool[] {false} ;
         BC000S3_A517BR_MedicalImaging_Diag_No = new long[1] ;
         BC000S3_n517BR_MedicalImaging_Diag_No = new bool[] {false} ;
         BC000S3_A225BR_MedicalImagingID = new long[1] ;
         BC000S3_n225BR_MedicalImagingID = new bool[] {false} ;
         sMode29 = "";
         BC000S2_A270BR_MedicalImaging_DiagID = new long[1] ;
         BC000S2_A271BR_MedicalImaging_Diag_Loc = new String[] {""} ;
         BC000S2_n271BR_MedicalImaging_Diag_Loc = new bool[] {false} ;
         BC000S2_A272BR_MedicalImaging_Diag_Organ = new String[] {""} ;
         BC000S2_n272BR_MedicalImaging_Diag_Organ = new bool[] {false} ;
         BC000S2_A273BR_MedicalImaging_Diag_Dis = new String[] {""} ;
         BC000S2_n273BR_MedicalImaging_Diag_Dis = new bool[] {false} ;
         BC000S2_A517BR_MedicalImaging_Diag_No = new long[1] ;
         BC000S2_n517BR_MedicalImaging_Diag_No = new bool[] {false} ;
         BC000S2_A225BR_MedicalImagingID = new long[1] ;
         BC000S2_n225BR_MedicalImagingID = new bool[] {false} ;
         BC000S7_A270BR_MedicalImaging_DiagID = new long[1] ;
         BC000S10_A270BR_MedicalImaging_DiagID = new long[1] ;
         BC000S10_A271BR_MedicalImaging_Diag_Loc = new String[] {""} ;
         BC000S10_n271BR_MedicalImaging_Diag_Loc = new bool[] {false} ;
         BC000S10_A272BR_MedicalImaging_Diag_Organ = new String[] {""} ;
         BC000S10_n272BR_MedicalImaging_Diag_Organ = new bool[] {false} ;
         BC000S10_A273BR_MedicalImaging_Diag_Dis = new String[] {""} ;
         BC000S10_n273BR_MedicalImaging_Diag_Dis = new bool[] {false} ;
         BC000S10_A517BR_MedicalImaging_Diag_No = new long[1] ;
         BC000S10_n517BR_MedicalImaging_Diag_No = new bool[] {false} ;
         BC000S10_A225BR_MedicalImagingID = new long[1] ;
         BC000S10_n225BR_MedicalImagingID = new bool[] {false} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_medicalimaging_diag_bc__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_medicalimaging_diag_bc__default(),
            new Object[][] {
                new Object[] {
               BC000S2_A270BR_MedicalImaging_DiagID, BC000S2_A271BR_MedicalImaging_Diag_Loc, BC000S2_n271BR_MedicalImaging_Diag_Loc, BC000S2_A272BR_MedicalImaging_Diag_Organ, BC000S2_n272BR_MedicalImaging_Diag_Organ, BC000S2_A273BR_MedicalImaging_Diag_Dis, BC000S2_n273BR_MedicalImaging_Diag_Dis, BC000S2_A517BR_MedicalImaging_Diag_No, BC000S2_n517BR_MedicalImaging_Diag_No, BC000S2_A225BR_MedicalImagingID,
               BC000S2_n225BR_MedicalImagingID
               }
               , new Object[] {
               BC000S3_A270BR_MedicalImaging_DiagID, BC000S3_A271BR_MedicalImaging_Diag_Loc, BC000S3_n271BR_MedicalImaging_Diag_Loc, BC000S3_A272BR_MedicalImaging_Diag_Organ, BC000S3_n272BR_MedicalImaging_Diag_Organ, BC000S3_A273BR_MedicalImaging_Diag_Dis, BC000S3_n273BR_MedicalImaging_Diag_Dis, BC000S3_A517BR_MedicalImaging_Diag_No, BC000S3_n517BR_MedicalImaging_Diag_No, BC000S3_A225BR_MedicalImagingID,
               BC000S3_n225BR_MedicalImagingID
               }
               , new Object[] {
               BC000S4_A225BR_MedicalImagingID
               }
               , new Object[] {
               BC000S5_A270BR_MedicalImaging_DiagID, BC000S5_A271BR_MedicalImaging_Diag_Loc, BC000S5_n271BR_MedicalImaging_Diag_Loc, BC000S5_A272BR_MedicalImaging_Diag_Organ, BC000S5_n272BR_MedicalImaging_Diag_Organ, BC000S5_A273BR_MedicalImaging_Diag_Dis, BC000S5_n273BR_MedicalImaging_Diag_Dis, BC000S5_A517BR_MedicalImaging_Diag_No, BC000S5_n517BR_MedicalImaging_Diag_No, BC000S5_A225BR_MedicalImagingID,
               BC000S5_n225BR_MedicalImagingID
               }
               , new Object[] {
               BC000S6_A270BR_MedicalImaging_DiagID
               }
               , new Object[] {
               BC000S7_A270BR_MedicalImaging_DiagID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000S10_A270BR_MedicalImaging_DiagID, BC000S10_A271BR_MedicalImaging_Diag_Loc, BC000S10_n271BR_MedicalImaging_Diag_Loc, BC000S10_A272BR_MedicalImaging_Diag_Organ, BC000S10_n272BR_MedicalImaging_Diag_Organ, BC000S10_A273BR_MedicalImaging_Diag_Dis, BC000S10_n273BR_MedicalImaging_Diag_Dis, BC000S10_A517BR_MedicalImaging_Diag_No, BC000S10_n517BR_MedicalImaging_Diag_No, BC000S10_A225BR_MedicalImagingID,
               BC000S10_n225BR_MedicalImagingID
               }
            }
         );
         AV15Pgmname = "BR_MedicalImaging_Diag_BC";
         INITTRN();
         /* Execute Start event if defined. */
         /* Execute user event: Start */
         E120S2 ();
         standaloneNotModal( ) ;
      }

      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short GX_JID ;
      private short RcdFound29 ;
      private int trnEnded ;
      private int AV16GXV1 ;
      private long Z270BR_MedicalImaging_DiagID ;
      private long A270BR_MedicalImaging_DiagID ;
      private long AV13Insert_BR_MedicalImagingID ;
      private long Z517BR_MedicalImaging_Diag_No ;
      private long A517BR_MedicalImaging_Diag_No ;
      private long Z225BR_MedicalImagingID ;
      private long A225BR_MedicalImagingID ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String AV15Pgmname ;
      private String sMode29 ;
      private bool AV9IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool n271BR_MedicalImaging_Diag_Loc ;
      private bool n272BR_MedicalImaging_Diag_Organ ;
      private bool n273BR_MedicalImaging_Diag_Dis ;
      private bool n517BR_MedicalImaging_Diag_No ;
      private bool n225BR_MedicalImagingID ;
      private String Z271BR_MedicalImaging_Diag_Loc ;
      private String A271BR_MedicalImaging_Diag_Loc ;
      private String Z272BR_MedicalImaging_Diag_Organ ;
      private String A272BR_MedicalImaging_Diag_Organ ;
      private String Z273BR_MedicalImaging_Diag_Dis ;
      private String A273BR_MedicalImaging_Diag_Dis ;
      private IGxSession AV12WebSession ;
      private SdtBR_MedicalImaging_Diag bcBR_MedicalImaging_Diag ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] BC000S5_A270BR_MedicalImaging_DiagID ;
      private String[] BC000S5_A271BR_MedicalImaging_Diag_Loc ;
      private bool[] BC000S5_n271BR_MedicalImaging_Diag_Loc ;
      private String[] BC000S5_A272BR_MedicalImaging_Diag_Organ ;
      private bool[] BC000S5_n272BR_MedicalImaging_Diag_Organ ;
      private String[] BC000S5_A273BR_MedicalImaging_Diag_Dis ;
      private bool[] BC000S5_n273BR_MedicalImaging_Diag_Dis ;
      private long[] BC000S5_A517BR_MedicalImaging_Diag_No ;
      private bool[] BC000S5_n517BR_MedicalImaging_Diag_No ;
      private long[] BC000S5_A225BR_MedicalImagingID ;
      private bool[] BC000S5_n225BR_MedicalImagingID ;
      private long[] BC000S4_A225BR_MedicalImagingID ;
      private bool[] BC000S4_n225BR_MedicalImagingID ;
      private long[] BC000S6_A270BR_MedicalImaging_DiagID ;
      private long[] BC000S3_A270BR_MedicalImaging_DiagID ;
      private String[] BC000S3_A271BR_MedicalImaging_Diag_Loc ;
      private bool[] BC000S3_n271BR_MedicalImaging_Diag_Loc ;
      private String[] BC000S3_A272BR_MedicalImaging_Diag_Organ ;
      private bool[] BC000S3_n272BR_MedicalImaging_Diag_Organ ;
      private String[] BC000S3_A273BR_MedicalImaging_Diag_Dis ;
      private bool[] BC000S3_n273BR_MedicalImaging_Diag_Dis ;
      private long[] BC000S3_A517BR_MedicalImaging_Diag_No ;
      private bool[] BC000S3_n517BR_MedicalImaging_Diag_No ;
      private long[] BC000S3_A225BR_MedicalImagingID ;
      private bool[] BC000S3_n225BR_MedicalImagingID ;
      private long[] BC000S2_A270BR_MedicalImaging_DiagID ;
      private String[] BC000S2_A271BR_MedicalImaging_Diag_Loc ;
      private bool[] BC000S2_n271BR_MedicalImaging_Diag_Loc ;
      private String[] BC000S2_A272BR_MedicalImaging_Diag_Organ ;
      private bool[] BC000S2_n272BR_MedicalImaging_Diag_Organ ;
      private String[] BC000S2_A273BR_MedicalImaging_Diag_Dis ;
      private bool[] BC000S2_n273BR_MedicalImaging_Diag_Dis ;
      private long[] BC000S2_A517BR_MedicalImaging_Diag_No ;
      private bool[] BC000S2_n517BR_MedicalImaging_Diag_No ;
      private long[] BC000S2_A225BR_MedicalImagingID ;
      private bool[] BC000S2_n225BR_MedicalImagingID ;
      private long[] BC000S7_A270BR_MedicalImaging_DiagID ;
      private long[] BC000S10_A270BR_MedicalImaging_DiagID ;
      private String[] BC000S10_A271BR_MedicalImaging_Diag_Loc ;
      private bool[] BC000S10_n271BR_MedicalImaging_Diag_Loc ;
      private String[] BC000S10_A272BR_MedicalImaging_Diag_Organ ;
      private bool[] BC000S10_n272BR_MedicalImaging_Diag_Organ ;
      private String[] BC000S10_A273BR_MedicalImaging_Diag_Dis ;
      private bool[] BC000S10_n273BR_MedicalImaging_Diag_Dis ;
      private long[] BC000S10_A517BR_MedicalImaging_Diag_No ;
      private bool[] BC000S10_n517BR_MedicalImaging_Diag_No ;
      private long[] BC000S10_A225BR_MedicalImagingID ;
      private bool[] BC000S10_n225BR_MedicalImagingID ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_datastore1 ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV8WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV11TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV14TrnContextAtt ;
   }

   public class br_medicalimaging_diag_bc__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class br_medicalimaging_diag_bc__default : DataStoreHelperBase, IDataStoreHelper
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
        Object[] prmBC000S5 ;
        prmBC000S5 = new Object[] {
        new Object[] {"@BR_MedicalImaging_DiagID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000S4 ;
        prmBC000S4 = new Object[] {
        new Object[] {"@BR_MedicalImagingID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000S6 ;
        prmBC000S6 = new Object[] {
        new Object[] {"@BR_MedicalImaging_DiagID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000S3 ;
        prmBC000S3 = new Object[] {
        new Object[] {"@BR_MedicalImaging_DiagID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000S2 ;
        prmBC000S2 = new Object[] {
        new Object[] {"@BR_MedicalImaging_DiagID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000S7 ;
        prmBC000S7 = new Object[] {
        new Object[] {"@BR_MedicalImaging_Diag_Loc",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_MedicalImaging_Diag_Organ",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_MedicalImaging_Diag_Dis",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_MedicalImaging_Diag_No",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_MedicalImagingID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000S8 ;
        prmBC000S8 = new Object[] {
        new Object[] {"@BR_MedicalImaging_Diag_Loc",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_MedicalImaging_Diag_Organ",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_MedicalImaging_Diag_Dis",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_MedicalImaging_Diag_No",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_MedicalImagingID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_MedicalImaging_DiagID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000S9 ;
        prmBC000S9 = new Object[] {
        new Object[] {"@BR_MedicalImaging_DiagID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000S10 ;
        prmBC000S10 = new Object[] {
        new Object[] {"@BR_MedicalImaging_DiagID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("BC000S2", "SELECT [BR_MedicalImaging_DiagID], [BR_MedicalImaging_Diag_Loc], [BR_MedicalImaging_Diag_Organ], [BR_MedicalImaging_Diag_Dis], [BR_MedicalImaging_Diag_No], [BR_MedicalImagingID] FROM [BR_MedicalImaging_Diag] WITH (UPDLOCK) WHERE [BR_MedicalImaging_DiagID] = @BR_MedicalImaging_DiagID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000S2,1,0,true,false )
           ,new CursorDef("BC000S3", "SELECT [BR_MedicalImaging_DiagID], [BR_MedicalImaging_Diag_Loc], [BR_MedicalImaging_Diag_Organ], [BR_MedicalImaging_Diag_Dis], [BR_MedicalImaging_Diag_No], [BR_MedicalImagingID] FROM [BR_MedicalImaging_Diag] WITH (NOLOCK) WHERE [BR_MedicalImaging_DiagID] = @BR_MedicalImaging_DiagID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000S3,1,0,true,false )
           ,new CursorDef("BC000S4", "SELECT [BR_MedicalImagingID] FROM [BR_MedicalImaging] WITH (NOLOCK) WHERE [BR_MedicalImagingID] = @BR_MedicalImagingID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000S4,1,0,true,false )
           ,new CursorDef("BC000S5", "SELECT TM1.[BR_MedicalImaging_DiagID], TM1.[BR_MedicalImaging_Diag_Loc], TM1.[BR_MedicalImaging_Diag_Organ], TM1.[BR_MedicalImaging_Diag_Dis], TM1.[BR_MedicalImaging_Diag_No], TM1.[BR_MedicalImagingID] FROM [BR_MedicalImaging_Diag] TM1 WITH (NOLOCK) WHERE TM1.[BR_MedicalImaging_DiagID] = @BR_MedicalImaging_DiagID ORDER BY TM1.[BR_MedicalImaging_DiagID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000S5,100,0,true,false )
           ,new CursorDef("BC000S6", "SELECT [BR_MedicalImaging_DiagID] FROM [BR_MedicalImaging_Diag] WITH (NOLOCK) WHERE [BR_MedicalImaging_DiagID] = @BR_MedicalImaging_DiagID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000S6,1,0,true,false )
           ,new CursorDef("BC000S7", "INSERT INTO [BR_MedicalImaging_Diag]([BR_MedicalImaging_Diag_Loc], [BR_MedicalImaging_Diag_Organ], [BR_MedicalImaging_Diag_Dis], [BR_MedicalImaging_Diag_No], [BR_MedicalImagingID]) VALUES(@BR_MedicalImaging_Diag_Loc, @BR_MedicalImaging_Diag_Organ, @BR_MedicalImaging_Diag_Dis, @BR_MedicalImaging_Diag_No, @BR_MedicalImagingID); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmBC000S7)
           ,new CursorDef("BC000S8", "UPDATE [BR_MedicalImaging_Diag] SET [BR_MedicalImaging_Diag_Loc]=@BR_MedicalImaging_Diag_Loc, [BR_MedicalImaging_Diag_Organ]=@BR_MedicalImaging_Diag_Organ, [BR_MedicalImaging_Diag_Dis]=@BR_MedicalImaging_Diag_Dis, [BR_MedicalImaging_Diag_No]=@BR_MedicalImaging_Diag_No, [BR_MedicalImagingID]=@BR_MedicalImagingID  WHERE [BR_MedicalImaging_DiagID] = @BR_MedicalImaging_DiagID", GxErrorMask.GX_NOMASK,prmBC000S8)
           ,new CursorDef("BC000S9", "DELETE FROM [BR_MedicalImaging_Diag]  WHERE [BR_MedicalImaging_DiagID] = @BR_MedicalImaging_DiagID", GxErrorMask.GX_NOMASK,prmBC000S9)
           ,new CursorDef("BC000S10", "SELECT TM1.[BR_MedicalImaging_DiagID], TM1.[BR_MedicalImaging_Diag_Loc], TM1.[BR_MedicalImaging_Diag_Organ], TM1.[BR_MedicalImaging_Diag_Dis], TM1.[BR_MedicalImaging_Diag_No], TM1.[BR_MedicalImagingID] FROM [BR_MedicalImaging_Diag] TM1 WITH (NOLOCK) WHERE TM1.[BR_MedicalImaging_DiagID] = @BR_MedicalImaging_DiagID ORDER BY TM1.[BR_MedicalImaging_DiagID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000S10,100,0,true,false )
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
              ((long[]) buf[7])[0] = rslt.getLong(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((long[]) buf[9])[0] = rslt.getLong(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((long[]) buf[7])[0] = rslt.getLong(5) ;
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
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((long[]) buf[7])[0] = rslt.getLong(5) ;
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
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((long[]) buf[7])[0] = rslt.getLong(5) ;
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
                 stmt.setNull( 4 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(4, (long)parms[7]);
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
                 stmt.setNull( 4 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(4, (long)parms[7]);
              }
              if ( (bool)parms[8] )
              {
                 stmt.setNull( 5 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(5, (long)parms[9]);
              }
              stmt.SetParameter(6, (long)parms[10]);
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
