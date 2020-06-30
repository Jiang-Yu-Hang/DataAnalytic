/*
               File: BR_Scheme_BC
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:8:44.76
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
   public class br_scheme_bc : GXHttpHandler, IGxSilentTrn
   {
      public br_scheme_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_scheme_bc( IGxContext context )
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
         ReadRow1239( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey1239( ) ;
         standaloneModal( ) ;
         AddRow1239( ) ;
         Gx_mode = "INS";
         return  ;
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E11122 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               Z327BR_SchemeID = A327BR_SchemeID;
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

      protected void CONFIRM_120( )
      {
         BeforeValidate1239( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls1239( ) ;
            }
            else
            {
               CheckExtendedTable1239( ) ;
               if ( AnyError == 0 )
               {
                  ZM1239( 9) ;
               }
               CloseExtendedTableCursors1239( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void E12122( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV8WWPContext) ;
         AV9IsAuthorized = true;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Scheme", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Scheme", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Scheme", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
         }
         if ( ! AV9IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV19Pgmname)));
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
         if ( ( StringUtil.StrCmp(AV11TrnContext.gxTpr_Transactionname, AV19Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV20GXV1 = 1;
            while ( AV20GXV1 <= AV11TrnContext.gxTpr_Attributes.Count )
            {
               AV14TrnContextAtt = ((GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute)AV11TrnContext.gxTpr_Attributes.Item(AV20GXV1));
               if ( StringUtil.StrCmp(AV14TrnContextAtt.gxTpr_Attributename, "BR_EncounterID") == 0 )
               {
                  AV13Insert_BR_EncounterID = (long)(NumberUtil.Val( AV14TrnContextAtt.gxTpr_Attributevalue, "."));
               }
               AV20GXV1 = (int)(AV20GXV1+1);
            }
         }
      }

      protected void E11122( )
      {
         /* After Trn Routine */
      }

      protected void S112( )
      {
         /* 'ATTRIBUTESSECURITYCODE' Routine */
      }

      protected void ZM1239( short GX_JID )
      {
         if ( ( GX_JID == 8 ) || ( GX_JID == 0 ) )
         {
            Z500BR_Scheme_Therapy_Line_Code = A500BR_Scheme_Therapy_Line_Code;
            Z328BR_Scheme_Chem_Regimens = A328BR_Scheme_Chem_Regimens;
            Z329BR_Scheme_Therapy_Line = A329BR_Scheme_Therapy_Line;
            Z330BR_Scheme_Chem_Cycle = A330BR_Scheme_Chem_Cycle;
            Z331BR_Scheme_Chem_Detail = A331BR_Scheme_Chem_Detail;
            Z19BR_EncounterID = A19BR_EncounterID;
         }
         if ( ( GX_JID == 9 ) || ( GX_JID == 0 ) )
         {
         }
         if ( GX_JID == -8 )
         {
            Z327BR_SchemeID = A327BR_SchemeID;
            Z500BR_Scheme_Therapy_Line_Code = A500BR_Scheme_Therapy_Line_Code;
            Z328BR_Scheme_Chem_Regimens = A328BR_Scheme_Chem_Regimens;
            Z329BR_Scheme_Therapy_Line = A329BR_Scheme_Therapy_Line;
            Z330BR_Scheme_Chem_Cycle = A330BR_Scheme_Chem_Cycle;
            Z331BR_Scheme_Chem_Detail = A331BR_Scheme_Chem_Detail;
            Z19BR_EncounterID = A19BR_EncounterID;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load1239( )
      {
         /* Using cursor BC00125 */
         pr_default.execute(3, new Object[] {n327BR_SchemeID, A327BR_SchemeID});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound39 = 1;
            A500BR_Scheme_Therapy_Line_Code = BC00125_A500BR_Scheme_Therapy_Line_Code[0];
            n500BR_Scheme_Therapy_Line_Code = BC00125_n500BR_Scheme_Therapy_Line_Code[0];
            A328BR_Scheme_Chem_Regimens = BC00125_A328BR_Scheme_Chem_Regimens[0];
            n328BR_Scheme_Chem_Regimens = BC00125_n328BR_Scheme_Chem_Regimens[0];
            A329BR_Scheme_Therapy_Line = BC00125_A329BR_Scheme_Therapy_Line[0];
            n329BR_Scheme_Therapy_Line = BC00125_n329BR_Scheme_Therapy_Line[0];
            A330BR_Scheme_Chem_Cycle = BC00125_A330BR_Scheme_Chem_Cycle[0];
            n330BR_Scheme_Chem_Cycle = BC00125_n330BR_Scheme_Chem_Cycle[0];
            A331BR_Scheme_Chem_Detail = BC00125_A331BR_Scheme_Chem_Detail[0];
            n331BR_Scheme_Chem_Detail = BC00125_n331BR_Scheme_Chem_Detail[0];
            A19BR_EncounterID = BC00125_A19BR_EncounterID[0];
            ZM1239( -8) ;
         }
         pr_default.close(3);
         OnLoadActions1239( ) ;
      }

      protected void OnLoadActions1239( )
      {
         AV19Pgmname = "BR_Scheme_BC";
      }

      protected void CheckExtendedTable1239( )
      {
         standaloneModal( ) ;
         AV19Pgmname = "BR_Scheme_BC";
         /* Using cursor BC00124 */
         pr_default.execute(2, new Object[] {A19BR_EncounterID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("不匹配' T15'", "ForeignKeyNotFound", 1, "BR_ENCOUNTERID");
            AnyError = 1;
         }
         pr_default.close(2);
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A328BR_Scheme_Chem_Regimens)) )
         {
            GX_msglist.addItem("化疗方案是必须填写的。", 1, "");
            AnyError = 1;
         }
      }

      protected void CloseExtendedTableCursors1239( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey1239( )
      {
         /* Using cursor BC00126 */
         pr_default.execute(4, new Object[] {n327BR_SchemeID, A327BR_SchemeID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound39 = 1;
         }
         else
         {
            RcdFound39 = 0;
         }
         pr_default.close(4);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC00123 */
         pr_default.execute(1, new Object[] {n327BR_SchemeID, A327BR_SchemeID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM1239( 8) ;
            RcdFound39 = 1;
            A327BR_SchemeID = BC00123_A327BR_SchemeID[0];
            n327BR_SchemeID = BC00123_n327BR_SchemeID[0];
            A500BR_Scheme_Therapy_Line_Code = BC00123_A500BR_Scheme_Therapy_Line_Code[0];
            n500BR_Scheme_Therapy_Line_Code = BC00123_n500BR_Scheme_Therapy_Line_Code[0];
            A328BR_Scheme_Chem_Regimens = BC00123_A328BR_Scheme_Chem_Regimens[0];
            n328BR_Scheme_Chem_Regimens = BC00123_n328BR_Scheme_Chem_Regimens[0];
            A329BR_Scheme_Therapy_Line = BC00123_A329BR_Scheme_Therapy_Line[0];
            n329BR_Scheme_Therapy_Line = BC00123_n329BR_Scheme_Therapy_Line[0];
            A330BR_Scheme_Chem_Cycle = BC00123_A330BR_Scheme_Chem_Cycle[0];
            n330BR_Scheme_Chem_Cycle = BC00123_n330BR_Scheme_Chem_Cycle[0];
            A331BR_Scheme_Chem_Detail = BC00123_A331BR_Scheme_Chem_Detail[0];
            n331BR_Scheme_Chem_Detail = BC00123_n331BR_Scheme_Chem_Detail[0];
            A19BR_EncounterID = BC00123_A19BR_EncounterID[0];
            Z327BR_SchemeID = A327BR_SchemeID;
            sMode39 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load1239( ) ;
            if ( AnyError == 1 )
            {
               RcdFound39 = 0;
               InitializeNonKey1239( ) ;
            }
            Gx_mode = sMode39;
         }
         else
         {
            RcdFound39 = 0;
            InitializeNonKey1239( ) ;
            sMode39 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode39;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1239( ) ;
         if ( RcdFound39 == 0 )
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
         CONFIRM_120( ) ;
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

      protected void CheckOptimisticConcurrency1239( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC00122 */
            pr_default.execute(0, new Object[] {n327BR_SchemeID, A327BR_SchemeID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Scheme"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z500BR_Scheme_Therapy_Line_Code, BC00122_A500BR_Scheme_Therapy_Line_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z328BR_Scheme_Chem_Regimens, BC00122_A328BR_Scheme_Chem_Regimens[0]) != 0 ) || ( StringUtil.StrCmp(Z329BR_Scheme_Therapy_Line, BC00122_A329BR_Scheme_Therapy_Line[0]) != 0 ) || ( Z330BR_Scheme_Chem_Cycle != BC00122_A330BR_Scheme_Chem_Cycle[0] ) || ( StringUtil.StrCmp(Z331BR_Scheme_Chem_Detail, BC00122_A331BR_Scheme_Chem_Detail[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z19BR_EncounterID != BC00122_A19BR_EncounterID[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"BR_Scheme"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert1239( )
      {
         BeforeValidate1239( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1239( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1239( 0) ;
            CheckOptimisticConcurrency1239( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1239( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1239( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00127 */
                     pr_default.execute(5, new Object[] {n500BR_Scheme_Therapy_Line_Code, A500BR_Scheme_Therapy_Line_Code, n328BR_Scheme_Chem_Regimens, A328BR_Scheme_Chem_Regimens, n329BR_Scheme_Therapy_Line, A329BR_Scheme_Therapy_Line, n330BR_Scheme_Chem_Cycle, A330BR_Scheme_Chem_Cycle, n331BR_Scheme_Chem_Detail, A331BR_Scheme_Chem_Detail, A19BR_EncounterID});
                     A327BR_SchemeID = BC00127_A327BR_SchemeID[0];
                     n327BR_SchemeID = BC00127_n327BR_SchemeID[0];
                     pr_default.close(5);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Scheme") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(A327BR_SchemeID), 18, 0)),  "化疗方案",  "Create",  1) ;
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
               Load1239( ) ;
            }
            EndLevel1239( ) ;
         }
         CloseExtendedTableCursors1239( ) ;
      }

      protected void Update1239( )
      {
         BeforeValidate1239( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1239( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1239( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1239( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1239( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00128 */
                     pr_default.execute(6, new Object[] {n500BR_Scheme_Therapy_Line_Code, A500BR_Scheme_Therapy_Line_Code, n328BR_Scheme_Chem_Regimens, A328BR_Scheme_Chem_Regimens, n329BR_Scheme_Therapy_Line, A329BR_Scheme_Therapy_Line, n330BR_Scheme_Chem_Cycle, A330BR_Scheme_Chem_Cycle, n331BR_Scheme_Chem_Detail, A331BR_Scheme_Chem_Detail, A19BR_EncounterID, n327BR_SchemeID, A327BR_SchemeID});
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Scheme") ;
                     if ( (pr_default.getStatus(6) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Scheme"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate1239( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(A327BR_SchemeID), 18, 0)),  "化疗方案",  "Update",  1) ;
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
            EndLevel1239( ) ;
         }
         CloseExtendedTableCursors1239( ) ;
      }

      protected void DeferredUpdate1239( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate1239( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1239( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1239( ) ;
            AfterConfirm1239( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1239( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC00129 */
                  pr_default.execute(7, new Object[] {n327BR_SchemeID, A327BR_SchemeID});
                  pr_default.close(7);
                  dsDefault.SmartCacheProvider.SetUpdated("BR_Scheme") ;
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
         sMode39 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel1239( ) ;
         Gx_mode = sMode39;
      }

      protected void OnDeleteControls1239( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV19Pgmname = "BR_Scheme_BC";
         }
         if ( AnyError == 0 )
         {
            /* Using cursor BC001210 */
            pr_default.execute(8, new Object[] {n327BR_SchemeID, A327BR_SchemeID});
            if ( (pr_default.getStatus(8) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {" T40"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(8);
         }
      }

      protected void EndLevel1239( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1239( ) ;
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

      public void ScanKeyStart1239( )
      {
         /* Scan By routine */
         /* Using cursor BC001211 */
         pr_default.execute(9, new Object[] {n327BR_SchemeID, A327BR_SchemeID});
         RcdFound39 = 0;
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound39 = 1;
            A327BR_SchemeID = BC001211_A327BR_SchemeID[0];
            n327BR_SchemeID = BC001211_n327BR_SchemeID[0];
            A500BR_Scheme_Therapy_Line_Code = BC001211_A500BR_Scheme_Therapy_Line_Code[0];
            n500BR_Scheme_Therapy_Line_Code = BC001211_n500BR_Scheme_Therapy_Line_Code[0];
            A328BR_Scheme_Chem_Regimens = BC001211_A328BR_Scheme_Chem_Regimens[0];
            n328BR_Scheme_Chem_Regimens = BC001211_n328BR_Scheme_Chem_Regimens[0];
            A329BR_Scheme_Therapy_Line = BC001211_A329BR_Scheme_Therapy_Line[0];
            n329BR_Scheme_Therapy_Line = BC001211_n329BR_Scheme_Therapy_Line[0];
            A330BR_Scheme_Chem_Cycle = BC001211_A330BR_Scheme_Chem_Cycle[0];
            n330BR_Scheme_Chem_Cycle = BC001211_n330BR_Scheme_Chem_Cycle[0];
            A331BR_Scheme_Chem_Detail = BC001211_A331BR_Scheme_Chem_Detail[0];
            n331BR_Scheme_Chem_Detail = BC001211_n331BR_Scheme_Chem_Detail[0];
            A19BR_EncounterID = BC001211_A19BR_EncounterID[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext1239( )
      {
         /* Scan next routine */
         pr_default.readNext(9);
         RcdFound39 = 0;
         ScanKeyLoad1239( ) ;
      }

      protected void ScanKeyLoad1239( )
      {
         sMode39 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound39 = 1;
            A327BR_SchemeID = BC001211_A327BR_SchemeID[0];
            n327BR_SchemeID = BC001211_n327BR_SchemeID[0];
            A500BR_Scheme_Therapy_Line_Code = BC001211_A500BR_Scheme_Therapy_Line_Code[0];
            n500BR_Scheme_Therapy_Line_Code = BC001211_n500BR_Scheme_Therapy_Line_Code[0];
            A328BR_Scheme_Chem_Regimens = BC001211_A328BR_Scheme_Chem_Regimens[0];
            n328BR_Scheme_Chem_Regimens = BC001211_n328BR_Scheme_Chem_Regimens[0];
            A329BR_Scheme_Therapy_Line = BC001211_A329BR_Scheme_Therapy_Line[0];
            n329BR_Scheme_Therapy_Line = BC001211_n329BR_Scheme_Therapy_Line[0];
            A330BR_Scheme_Chem_Cycle = BC001211_A330BR_Scheme_Chem_Cycle[0];
            n330BR_Scheme_Chem_Cycle = BC001211_n330BR_Scheme_Chem_Cycle[0];
            A331BR_Scheme_Chem_Detail = BC001211_A331BR_Scheme_Chem_Detail[0];
            n331BR_Scheme_Chem_Detail = BC001211_n331BR_Scheme_Chem_Detail[0];
            A19BR_EncounterID = BC001211_A19BR_EncounterID[0];
         }
         Gx_mode = sMode39;
      }

      protected void ScanKeyEnd1239( )
      {
         pr_default.close(9);
      }

      protected void AfterConfirm1239( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1239( )
      {
         /* Before Insert Rules */
         GXt_char2 = A500BR_Scheme_Therapy_Line_Code;
         new zutil_findtargetcode(context ).execute(  27,  A329BR_Scheme_Therapy_Line, out  GXt_char2) ;
         A500BR_Scheme_Therapy_Line_Code = GXt_char2;
         n500BR_Scheme_Therapy_Line_Code = false;
      }

      protected void BeforeUpdate1239( )
      {
         /* Before Update Rules */
         GXt_char2 = A500BR_Scheme_Therapy_Line_Code;
         new zutil_findtargetcode(context ).execute(  27,  A329BR_Scheme_Therapy_Line, out  GXt_char2) ;
         A500BR_Scheme_Therapy_Line_Code = GXt_char2;
         n500BR_Scheme_Therapy_Line_Code = false;
      }

      protected void BeforeDelete1239( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1239( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1239( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1239( )
      {
      }

      protected void send_integrity_lvl_hashes1239( )
      {
      }

      protected void AddRow1239( )
      {
         VarsToRow39( bcBR_Scheme) ;
      }

      protected void ReadRow1239( )
      {
         RowToVars39( bcBR_Scheme, 1) ;
      }

      protected void InitializeNonKey1239( )
      {
         A500BR_Scheme_Therapy_Line_Code = "";
         n500BR_Scheme_Therapy_Line_Code = false;
         A19BR_EncounterID = 0;
         A328BR_Scheme_Chem_Regimens = "";
         n328BR_Scheme_Chem_Regimens = false;
         A329BR_Scheme_Therapy_Line = "";
         n329BR_Scheme_Therapy_Line = false;
         A330BR_Scheme_Chem_Cycle = 0;
         n330BR_Scheme_Chem_Cycle = false;
         A331BR_Scheme_Chem_Detail = "";
         n331BR_Scheme_Chem_Detail = false;
         Z500BR_Scheme_Therapy_Line_Code = "";
         Z328BR_Scheme_Chem_Regimens = "";
         Z329BR_Scheme_Therapy_Line = "";
         Z330BR_Scheme_Chem_Cycle = 0;
         Z331BR_Scheme_Chem_Detail = "";
         Z19BR_EncounterID = 0;
      }

      protected void InitAll1239( )
      {
         A327BR_SchemeID = 0;
         n327BR_SchemeID = false;
         InitializeNonKey1239( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow39( SdtBR_Scheme obj39 )
      {
         obj39.gxTpr_Mode = Gx_mode;
         obj39.gxTpr_Br_scheme_therapy_line_code = A500BR_Scheme_Therapy_Line_Code;
         obj39.gxTpr_Br_encounterid = A19BR_EncounterID;
         obj39.gxTpr_Br_scheme_chem_regimens = A328BR_Scheme_Chem_Regimens;
         obj39.gxTpr_Br_scheme_therapy_line = A329BR_Scheme_Therapy_Line;
         obj39.gxTpr_Br_scheme_chem_cycle = A330BR_Scheme_Chem_Cycle;
         obj39.gxTpr_Br_scheme_chem_detail = A331BR_Scheme_Chem_Detail;
         obj39.gxTpr_Br_schemeid = A327BR_SchemeID;
         obj39.gxTpr_Br_schemeid_Z = Z327BR_SchemeID;
         obj39.gxTpr_Br_encounterid_Z = Z19BR_EncounterID;
         obj39.gxTpr_Br_scheme_chem_regimens_Z = Z328BR_Scheme_Chem_Regimens;
         obj39.gxTpr_Br_scheme_therapy_line_Z = Z329BR_Scheme_Therapy_Line;
         obj39.gxTpr_Br_scheme_therapy_line_code_Z = Z500BR_Scheme_Therapy_Line_Code;
         obj39.gxTpr_Br_scheme_chem_cycle_Z = Z330BR_Scheme_Chem_Cycle;
         obj39.gxTpr_Br_scheme_chem_detail_Z = Z331BR_Scheme_Chem_Detail;
         obj39.gxTpr_Br_schemeid_N = (short)(Convert.ToInt16(n327BR_SchemeID));
         obj39.gxTpr_Br_scheme_chem_regimens_N = (short)(Convert.ToInt16(n328BR_Scheme_Chem_Regimens));
         obj39.gxTpr_Br_scheme_therapy_line_N = (short)(Convert.ToInt16(n329BR_Scheme_Therapy_Line));
         obj39.gxTpr_Br_scheme_therapy_line_code_N = (short)(Convert.ToInt16(n500BR_Scheme_Therapy_Line_Code));
         obj39.gxTpr_Br_scheme_chem_cycle_N = (short)(Convert.ToInt16(n330BR_Scheme_Chem_Cycle));
         obj39.gxTpr_Br_scheme_chem_detail_N = (short)(Convert.ToInt16(n331BR_Scheme_Chem_Detail));
         obj39.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow39( SdtBR_Scheme obj39 )
      {
         obj39.gxTpr_Br_schemeid = A327BR_SchemeID;
         return  ;
      }

      public void RowToVars39( SdtBR_Scheme obj39 ,
                               int forceLoad )
      {
         Gx_mode = obj39.gxTpr_Mode;
         A500BR_Scheme_Therapy_Line_Code = obj39.gxTpr_Br_scheme_therapy_line_code;
         n500BR_Scheme_Therapy_Line_Code = false;
         A19BR_EncounterID = obj39.gxTpr_Br_encounterid;
         A328BR_Scheme_Chem_Regimens = obj39.gxTpr_Br_scheme_chem_regimens;
         n328BR_Scheme_Chem_Regimens = false;
         A329BR_Scheme_Therapy_Line = obj39.gxTpr_Br_scheme_therapy_line;
         n329BR_Scheme_Therapy_Line = false;
         A330BR_Scheme_Chem_Cycle = obj39.gxTpr_Br_scheme_chem_cycle;
         n330BR_Scheme_Chem_Cycle = false;
         A331BR_Scheme_Chem_Detail = obj39.gxTpr_Br_scheme_chem_detail;
         n331BR_Scheme_Chem_Detail = false;
         A327BR_SchemeID = obj39.gxTpr_Br_schemeid;
         n327BR_SchemeID = false;
         Z327BR_SchemeID = obj39.gxTpr_Br_schemeid_Z;
         Z19BR_EncounterID = obj39.gxTpr_Br_encounterid_Z;
         Z328BR_Scheme_Chem_Regimens = obj39.gxTpr_Br_scheme_chem_regimens_Z;
         Z329BR_Scheme_Therapy_Line = obj39.gxTpr_Br_scheme_therapy_line_Z;
         Z500BR_Scheme_Therapy_Line_Code = obj39.gxTpr_Br_scheme_therapy_line_code_Z;
         Z330BR_Scheme_Chem_Cycle = obj39.gxTpr_Br_scheme_chem_cycle_Z;
         Z331BR_Scheme_Chem_Detail = obj39.gxTpr_Br_scheme_chem_detail_Z;
         n327BR_SchemeID = (bool)(Convert.ToBoolean(obj39.gxTpr_Br_schemeid_N));
         n328BR_Scheme_Chem_Regimens = (bool)(Convert.ToBoolean(obj39.gxTpr_Br_scheme_chem_regimens_N));
         n329BR_Scheme_Therapy_Line = (bool)(Convert.ToBoolean(obj39.gxTpr_Br_scheme_therapy_line_N));
         n500BR_Scheme_Therapy_Line_Code = (bool)(Convert.ToBoolean(obj39.gxTpr_Br_scheme_therapy_line_code_N));
         n330BR_Scheme_Chem_Cycle = (bool)(Convert.ToBoolean(obj39.gxTpr_Br_scheme_chem_cycle_N));
         n331BR_Scheme_Chem_Detail = (bool)(Convert.ToBoolean(obj39.gxTpr_Br_scheme_chem_detail_N));
         Gx_mode = obj39.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A327BR_SchemeID = (long)getParm(obj,0);
         n327BR_SchemeID = false;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey1239( ) ;
         ScanKeyStart1239( ) ;
         if ( RcdFound39 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z327BR_SchemeID = A327BR_SchemeID;
         }
         ZM1239( -8) ;
         OnLoadActions1239( ) ;
         AddRow1239( ) ;
         ScanKeyEnd1239( ) ;
         if ( RcdFound39 == 0 )
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
         RowToVars39( bcBR_Scheme, 0) ;
         ScanKeyStart1239( ) ;
         if ( RcdFound39 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z327BR_SchemeID = A327BR_SchemeID;
         }
         ZM1239( -8) ;
         OnLoadActions1239( ) ;
         AddRow1239( ) ;
         ScanKeyEnd1239( ) ;
         if ( RcdFound39 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey1239( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert1239( ) ;
         }
         else
         {
            if ( RcdFound39 == 1 )
            {
               if ( A327BR_SchemeID != Z327BR_SchemeID )
               {
                  A327BR_SchemeID = Z327BR_SchemeID;
                  n327BR_SchemeID = false;
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
                  Update1239( ) ;
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
                  if ( A327BR_SchemeID != Z327BR_SchemeID )
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
                        Insert1239( ) ;
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
                        Insert1239( ) ;
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
         RowToVars39( bcBR_Scheme, 0) ;
         SaveImpl( ) ;
         VarsToRow39( bcBR_Scheme) ;
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
         RowToVars39( bcBR_Scheme, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert1239( ) ;
         AfterTrn( ) ;
         VarsToRow39( bcBR_Scheme) ;
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
            SdtBR_Scheme auxBC = new SdtBR_Scheme(context) ;
            auxBC.Load(A327BR_SchemeID);
            auxBC.UpdateDirties(bcBR_Scheme);
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
         RowToVars39( bcBR_Scheme, 0) ;
         UpdateImpl( ) ;
         VarsToRow39( bcBR_Scheme) ;
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
         RowToVars39( bcBR_Scheme, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert1239( ) ;
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
         VarsToRow39( bcBR_Scheme) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars39( bcBR_Scheme, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey1239( ) ;
         if ( RcdFound39 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A327BR_SchemeID != Z327BR_SchemeID )
            {
               A327BR_SchemeID = Z327BR_SchemeID;
               n327BR_SchemeID = false;
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
            if ( A327BR_SchemeID != Z327BR_SchemeID )
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
         context.RollbackDataStores("br_scheme_bc",pr_default);
         VarsToRow39( bcBR_Scheme) ;
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
         Gx_mode = bcBR_Scheme.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcBR_Scheme.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcBR_Scheme )
         {
            bcBR_Scheme = (SdtBR_Scheme)(sdt);
            if ( StringUtil.StrCmp(bcBR_Scheme.gxTpr_Mode, "") == 0 )
            {
               bcBR_Scheme.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow39( bcBR_Scheme) ;
            }
            else
            {
               RowToVars39( bcBR_Scheme, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcBR_Scheme.gxTpr_Mode, "") == 0 )
            {
               bcBR_Scheme.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars39( bcBR_Scheme, 1) ;
         return  ;
      }

      public SdtBR_Scheme BR_Scheme_BC
      {
         get {
            return bcBR_Scheme ;
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
         AV19Pgmname = "";
         AV11TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV12WebSession = context.GetSession();
         AV14TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         Z500BR_Scheme_Therapy_Line_Code = "";
         A500BR_Scheme_Therapy_Line_Code = "";
         Z328BR_Scheme_Chem_Regimens = "";
         A328BR_Scheme_Chem_Regimens = "";
         Z329BR_Scheme_Therapy_Line = "";
         A329BR_Scheme_Therapy_Line = "";
         Z331BR_Scheme_Chem_Detail = "";
         A331BR_Scheme_Chem_Detail = "";
         BC00125_A327BR_SchemeID = new long[1] ;
         BC00125_n327BR_SchemeID = new bool[] {false} ;
         BC00125_A500BR_Scheme_Therapy_Line_Code = new String[] {""} ;
         BC00125_n500BR_Scheme_Therapy_Line_Code = new bool[] {false} ;
         BC00125_A328BR_Scheme_Chem_Regimens = new String[] {""} ;
         BC00125_n328BR_Scheme_Chem_Regimens = new bool[] {false} ;
         BC00125_A329BR_Scheme_Therapy_Line = new String[] {""} ;
         BC00125_n329BR_Scheme_Therapy_Line = new bool[] {false} ;
         BC00125_A330BR_Scheme_Chem_Cycle = new decimal[1] ;
         BC00125_n330BR_Scheme_Chem_Cycle = new bool[] {false} ;
         BC00125_A331BR_Scheme_Chem_Detail = new String[] {""} ;
         BC00125_n331BR_Scheme_Chem_Detail = new bool[] {false} ;
         BC00125_A19BR_EncounterID = new long[1] ;
         BC00124_A19BR_EncounterID = new long[1] ;
         BC00126_A327BR_SchemeID = new long[1] ;
         BC00126_n327BR_SchemeID = new bool[] {false} ;
         BC00123_A327BR_SchemeID = new long[1] ;
         BC00123_n327BR_SchemeID = new bool[] {false} ;
         BC00123_A500BR_Scheme_Therapy_Line_Code = new String[] {""} ;
         BC00123_n500BR_Scheme_Therapy_Line_Code = new bool[] {false} ;
         BC00123_A328BR_Scheme_Chem_Regimens = new String[] {""} ;
         BC00123_n328BR_Scheme_Chem_Regimens = new bool[] {false} ;
         BC00123_A329BR_Scheme_Therapy_Line = new String[] {""} ;
         BC00123_n329BR_Scheme_Therapy_Line = new bool[] {false} ;
         BC00123_A330BR_Scheme_Chem_Cycle = new decimal[1] ;
         BC00123_n330BR_Scheme_Chem_Cycle = new bool[] {false} ;
         BC00123_A331BR_Scheme_Chem_Detail = new String[] {""} ;
         BC00123_n331BR_Scheme_Chem_Detail = new bool[] {false} ;
         BC00123_A19BR_EncounterID = new long[1] ;
         sMode39 = "";
         BC00122_A327BR_SchemeID = new long[1] ;
         BC00122_n327BR_SchemeID = new bool[] {false} ;
         BC00122_A500BR_Scheme_Therapy_Line_Code = new String[] {""} ;
         BC00122_n500BR_Scheme_Therapy_Line_Code = new bool[] {false} ;
         BC00122_A328BR_Scheme_Chem_Regimens = new String[] {""} ;
         BC00122_n328BR_Scheme_Chem_Regimens = new bool[] {false} ;
         BC00122_A329BR_Scheme_Therapy_Line = new String[] {""} ;
         BC00122_n329BR_Scheme_Therapy_Line = new bool[] {false} ;
         BC00122_A330BR_Scheme_Chem_Cycle = new decimal[1] ;
         BC00122_n330BR_Scheme_Chem_Cycle = new bool[] {false} ;
         BC00122_A331BR_Scheme_Chem_Detail = new String[] {""} ;
         BC00122_n331BR_Scheme_Chem_Detail = new bool[] {false} ;
         BC00122_A19BR_EncounterID = new long[1] ;
         BC00127_A327BR_SchemeID = new long[1] ;
         BC00127_n327BR_SchemeID = new bool[] {false} ;
         BC001210_A332BR_Scheme_MedicationID = new long[1] ;
         BC001211_A327BR_SchemeID = new long[1] ;
         BC001211_n327BR_SchemeID = new bool[] {false} ;
         BC001211_A500BR_Scheme_Therapy_Line_Code = new String[] {""} ;
         BC001211_n500BR_Scheme_Therapy_Line_Code = new bool[] {false} ;
         BC001211_A328BR_Scheme_Chem_Regimens = new String[] {""} ;
         BC001211_n328BR_Scheme_Chem_Regimens = new bool[] {false} ;
         BC001211_A329BR_Scheme_Therapy_Line = new String[] {""} ;
         BC001211_n329BR_Scheme_Therapy_Line = new bool[] {false} ;
         BC001211_A330BR_Scheme_Chem_Cycle = new decimal[1] ;
         BC001211_n330BR_Scheme_Chem_Cycle = new bool[] {false} ;
         BC001211_A331BR_Scheme_Chem_Detail = new String[] {""} ;
         BC001211_n331BR_Scheme_Chem_Detail = new bool[] {false} ;
         BC001211_A19BR_EncounterID = new long[1] ;
         GXt_char2 = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_scheme_bc__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_scheme_bc__default(),
            new Object[][] {
                new Object[] {
               BC00122_A327BR_SchemeID, BC00122_A500BR_Scheme_Therapy_Line_Code, BC00122_n500BR_Scheme_Therapy_Line_Code, BC00122_A328BR_Scheme_Chem_Regimens, BC00122_n328BR_Scheme_Chem_Regimens, BC00122_A329BR_Scheme_Therapy_Line, BC00122_n329BR_Scheme_Therapy_Line, BC00122_A330BR_Scheme_Chem_Cycle, BC00122_n330BR_Scheme_Chem_Cycle, BC00122_A331BR_Scheme_Chem_Detail,
               BC00122_n331BR_Scheme_Chem_Detail, BC00122_A19BR_EncounterID
               }
               , new Object[] {
               BC00123_A327BR_SchemeID, BC00123_A500BR_Scheme_Therapy_Line_Code, BC00123_n500BR_Scheme_Therapy_Line_Code, BC00123_A328BR_Scheme_Chem_Regimens, BC00123_n328BR_Scheme_Chem_Regimens, BC00123_A329BR_Scheme_Therapy_Line, BC00123_n329BR_Scheme_Therapy_Line, BC00123_A330BR_Scheme_Chem_Cycle, BC00123_n330BR_Scheme_Chem_Cycle, BC00123_A331BR_Scheme_Chem_Detail,
               BC00123_n331BR_Scheme_Chem_Detail, BC00123_A19BR_EncounterID
               }
               , new Object[] {
               BC00124_A19BR_EncounterID
               }
               , new Object[] {
               BC00125_A327BR_SchemeID, BC00125_A500BR_Scheme_Therapy_Line_Code, BC00125_n500BR_Scheme_Therapy_Line_Code, BC00125_A328BR_Scheme_Chem_Regimens, BC00125_n328BR_Scheme_Chem_Regimens, BC00125_A329BR_Scheme_Therapy_Line, BC00125_n329BR_Scheme_Therapy_Line, BC00125_A330BR_Scheme_Chem_Cycle, BC00125_n330BR_Scheme_Chem_Cycle, BC00125_A331BR_Scheme_Chem_Detail,
               BC00125_n331BR_Scheme_Chem_Detail, BC00125_A19BR_EncounterID
               }
               , new Object[] {
               BC00126_A327BR_SchemeID
               }
               , new Object[] {
               BC00127_A327BR_SchemeID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC001210_A332BR_Scheme_MedicationID
               }
               , new Object[] {
               BC001211_A327BR_SchemeID, BC001211_A500BR_Scheme_Therapy_Line_Code, BC001211_n500BR_Scheme_Therapy_Line_Code, BC001211_A328BR_Scheme_Chem_Regimens, BC001211_n328BR_Scheme_Chem_Regimens, BC001211_A329BR_Scheme_Therapy_Line, BC001211_n329BR_Scheme_Therapy_Line, BC001211_A330BR_Scheme_Chem_Cycle, BC001211_n330BR_Scheme_Chem_Cycle, BC001211_A331BR_Scheme_Chem_Detail,
               BC001211_n331BR_Scheme_Chem_Detail, BC001211_A19BR_EncounterID
               }
            }
         );
         AV19Pgmname = "BR_Scheme_BC";
         INITTRN();
         /* Execute Start event if defined. */
         /* Execute user event: Start */
         E12122 ();
         standaloneNotModal( ) ;
      }

      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short GX_JID ;
      private short RcdFound39 ;
      private int trnEnded ;
      private int AV20GXV1 ;
      private long Z327BR_SchemeID ;
      private long A327BR_SchemeID ;
      private long AV13Insert_BR_EncounterID ;
      private long Z19BR_EncounterID ;
      private long A19BR_EncounterID ;
      private decimal Z330BR_Scheme_Chem_Cycle ;
      private decimal A330BR_Scheme_Chem_Cycle ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String AV19Pgmname ;
      private String sMode39 ;
      private String GXt_char2 ;
      private bool AV9IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool returnInSub ;
      private bool n327BR_SchemeID ;
      private bool n500BR_Scheme_Therapy_Line_Code ;
      private bool n328BR_Scheme_Chem_Regimens ;
      private bool n329BR_Scheme_Therapy_Line ;
      private bool n330BR_Scheme_Chem_Cycle ;
      private bool n331BR_Scheme_Chem_Detail ;
      private bool Gx_longc ;
      private String Z500BR_Scheme_Therapy_Line_Code ;
      private String A500BR_Scheme_Therapy_Line_Code ;
      private String Z328BR_Scheme_Chem_Regimens ;
      private String A328BR_Scheme_Chem_Regimens ;
      private String Z329BR_Scheme_Therapy_Line ;
      private String A329BR_Scheme_Therapy_Line ;
      private String Z331BR_Scheme_Chem_Detail ;
      private String A331BR_Scheme_Chem_Detail ;
      private IGxSession AV12WebSession ;
      private SdtBR_Scheme bcBR_Scheme ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] BC00125_A327BR_SchemeID ;
      private bool[] BC00125_n327BR_SchemeID ;
      private String[] BC00125_A500BR_Scheme_Therapy_Line_Code ;
      private bool[] BC00125_n500BR_Scheme_Therapy_Line_Code ;
      private String[] BC00125_A328BR_Scheme_Chem_Regimens ;
      private bool[] BC00125_n328BR_Scheme_Chem_Regimens ;
      private String[] BC00125_A329BR_Scheme_Therapy_Line ;
      private bool[] BC00125_n329BR_Scheme_Therapy_Line ;
      private decimal[] BC00125_A330BR_Scheme_Chem_Cycle ;
      private bool[] BC00125_n330BR_Scheme_Chem_Cycle ;
      private String[] BC00125_A331BR_Scheme_Chem_Detail ;
      private bool[] BC00125_n331BR_Scheme_Chem_Detail ;
      private long[] BC00125_A19BR_EncounterID ;
      private long[] BC00124_A19BR_EncounterID ;
      private long[] BC00126_A327BR_SchemeID ;
      private bool[] BC00126_n327BR_SchemeID ;
      private long[] BC00123_A327BR_SchemeID ;
      private bool[] BC00123_n327BR_SchemeID ;
      private String[] BC00123_A500BR_Scheme_Therapy_Line_Code ;
      private bool[] BC00123_n500BR_Scheme_Therapy_Line_Code ;
      private String[] BC00123_A328BR_Scheme_Chem_Regimens ;
      private bool[] BC00123_n328BR_Scheme_Chem_Regimens ;
      private String[] BC00123_A329BR_Scheme_Therapy_Line ;
      private bool[] BC00123_n329BR_Scheme_Therapy_Line ;
      private decimal[] BC00123_A330BR_Scheme_Chem_Cycle ;
      private bool[] BC00123_n330BR_Scheme_Chem_Cycle ;
      private String[] BC00123_A331BR_Scheme_Chem_Detail ;
      private bool[] BC00123_n331BR_Scheme_Chem_Detail ;
      private long[] BC00123_A19BR_EncounterID ;
      private long[] BC00122_A327BR_SchemeID ;
      private bool[] BC00122_n327BR_SchemeID ;
      private String[] BC00122_A500BR_Scheme_Therapy_Line_Code ;
      private bool[] BC00122_n500BR_Scheme_Therapy_Line_Code ;
      private String[] BC00122_A328BR_Scheme_Chem_Regimens ;
      private bool[] BC00122_n328BR_Scheme_Chem_Regimens ;
      private String[] BC00122_A329BR_Scheme_Therapy_Line ;
      private bool[] BC00122_n329BR_Scheme_Therapy_Line ;
      private decimal[] BC00122_A330BR_Scheme_Chem_Cycle ;
      private bool[] BC00122_n330BR_Scheme_Chem_Cycle ;
      private String[] BC00122_A331BR_Scheme_Chem_Detail ;
      private bool[] BC00122_n331BR_Scheme_Chem_Detail ;
      private long[] BC00122_A19BR_EncounterID ;
      private long[] BC00127_A327BR_SchemeID ;
      private bool[] BC00127_n327BR_SchemeID ;
      private long[] BC001210_A332BR_Scheme_MedicationID ;
      private long[] BC001211_A327BR_SchemeID ;
      private bool[] BC001211_n327BR_SchemeID ;
      private String[] BC001211_A500BR_Scheme_Therapy_Line_Code ;
      private bool[] BC001211_n500BR_Scheme_Therapy_Line_Code ;
      private String[] BC001211_A328BR_Scheme_Chem_Regimens ;
      private bool[] BC001211_n328BR_Scheme_Chem_Regimens ;
      private String[] BC001211_A329BR_Scheme_Therapy_Line ;
      private bool[] BC001211_n329BR_Scheme_Therapy_Line ;
      private decimal[] BC001211_A330BR_Scheme_Chem_Cycle ;
      private bool[] BC001211_n330BR_Scheme_Chem_Cycle ;
      private String[] BC001211_A331BR_Scheme_Chem_Detail ;
      private bool[] BC001211_n331BR_Scheme_Chem_Detail ;
      private long[] BC001211_A19BR_EncounterID ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_datastore1 ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV8WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV11TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV14TrnContextAtt ;
   }

   public class br_scheme_bc__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class br_scheme_bc__default : DataStoreHelperBase, IDataStoreHelper
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
        Object[] prmBC00125 ;
        prmBC00125 = new Object[] {
        new Object[] {"@BR_SchemeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00124 ;
        prmBC00124 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00126 ;
        prmBC00126 = new Object[] {
        new Object[] {"@BR_SchemeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00123 ;
        prmBC00123 = new Object[] {
        new Object[] {"@BR_SchemeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00122 ;
        prmBC00122 = new Object[] {
        new Object[] {"@BR_SchemeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00127 ;
        prmBC00127 = new Object[] {
        new Object[] {"@BR_Scheme_Therapy_Line_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Scheme_Chem_Regimens",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Scheme_Therapy_Line",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Scheme_Chem_Cycle",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_Scheme_Chem_Detail",SqlDbType.NVarChar,4000,0} ,
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00128 ;
        prmBC00128 = new Object[] {
        new Object[] {"@BR_Scheme_Therapy_Line_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Scheme_Chem_Regimens",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Scheme_Therapy_Line",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Scheme_Chem_Cycle",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_Scheme_Chem_Detail",SqlDbType.NVarChar,4000,0} ,
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_SchemeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00129 ;
        prmBC00129 = new Object[] {
        new Object[] {"@BR_SchemeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC001210 ;
        prmBC001210 = new Object[] {
        new Object[] {"@BR_SchemeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC001211 ;
        prmBC001211 = new Object[] {
        new Object[] {"@BR_SchemeID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("BC00122", "SELECT [BR_SchemeID], [BR_Scheme_Therapy_Line_Code], [BR_Scheme_Chem_Regimens], [BR_Scheme_Therapy_Line], [BR_Scheme_Chem_Cycle], [BR_Scheme_Chem_Detail], [BR_EncounterID] FROM [BR_Scheme] WITH (UPDLOCK) WHERE [BR_SchemeID] = @BR_SchemeID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00122,1,0,true,false )
           ,new CursorDef("BC00123", "SELECT [BR_SchemeID], [BR_Scheme_Therapy_Line_Code], [BR_Scheme_Chem_Regimens], [BR_Scheme_Therapy_Line], [BR_Scheme_Chem_Cycle], [BR_Scheme_Chem_Detail], [BR_EncounterID] FROM [BR_Scheme] WITH (NOLOCK) WHERE [BR_SchemeID] = @BR_SchemeID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00123,1,0,true,false )
           ,new CursorDef("BC00124", "SELECT [BR_EncounterID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00124,1,0,true,false )
           ,new CursorDef("BC00125", "SELECT TM1.[BR_SchemeID], TM1.[BR_Scheme_Therapy_Line_Code], TM1.[BR_Scheme_Chem_Regimens], TM1.[BR_Scheme_Therapy_Line], TM1.[BR_Scheme_Chem_Cycle], TM1.[BR_Scheme_Chem_Detail], TM1.[BR_EncounterID] FROM [BR_Scheme] TM1 WITH (NOLOCK) WHERE TM1.[BR_SchemeID] = @BR_SchemeID ORDER BY TM1.[BR_SchemeID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00125,100,0,true,false )
           ,new CursorDef("BC00126", "SELECT [BR_SchemeID] FROM [BR_Scheme] WITH (NOLOCK) WHERE [BR_SchemeID] = @BR_SchemeID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00126,1,0,true,false )
           ,new CursorDef("BC00127", "INSERT INTO [BR_Scheme]([BR_Scheme_Therapy_Line_Code], [BR_Scheme_Chem_Regimens], [BR_Scheme_Therapy_Line], [BR_Scheme_Chem_Cycle], [BR_Scheme_Chem_Detail], [BR_EncounterID]) VALUES(@BR_Scheme_Therapy_Line_Code, @BR_Scheme_Chem_Regimens, @BR_Scheme_Therapy_Line, @BR_Scheme_Chem_Cycle, @BR_Scheme_Chem_Detail, @BR_EncounterID); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmBC00127)
           ,new CursorDef("BC00128", "UPDATE [BR_Scheme] SET [BR_Scheme_Therapy_Line_Code]=@BR_Scheme_Therapy_Line_Code, [BR_Scheme_Chem_Regimens]=@BR_Scheme_Chem_Regimens, [BR_Scheme_Therapy_Line]=@BR_Scheme_Therapy_Line, [BR_Scheme_Chem_Cycle]=@BR_Scheme_Chem_Cycle, [BR_Scheme_Chem_Detail]=@BR_Scheme_Chem_Detail, [BR_EncounterID]=@BR_EncounterID  WHERE [BR_SchemeID] = @BR_SchemeID", GxErrorMask.GX_NOMASK,prmBC00128)
           ,new CursorDef("BC00129", "DELETE FROM [BR_Scheme]  WHERE [BR_SchemeID] = @BR_SchemeID", GxErrorMask.GX_NOMASK,prmBC00129)
           ,new CursorDef("BC001210", "SELECT TOP 1 [BR_Scheme_MedicationID] FROM [BR_Scheme_Medication] WITH (NOLOCK) WHERE [BR_SchemeID] = @BR_SchemeID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001210,1,0,true,true )
           ,new CursorDef("BC001211", "SELECT TM1.[BR_SchemeID], TM1.[BR_Scheme_Therapy_Line_Code], TM1.[BR_Scheme_Chem_Regimens], TM1.[BR_Scheme_Therapy_Line], TM1.[BR_Scheme_Chem_Cycle], TM1.[BR_Scheme_Chem_Detail], TM1.[BR_EncounterID] FROM [BR_Scheme] TM1 WITH (NOLOCK) WHERE TM1.[BR_SchemeID] = @BR_SchemeID ORDER BY TM1.[BR_SchemeID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001211,100,0,true,false )
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
              ((decimal[]) buf[7])[0] = rslt.getDecimal(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((long[]) buf[11])[0] = rslt.getLong(7) ;
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((decimal[]) buf[7])[0] = rslt.getDecimal(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((long[]) buf[11])[0] = rslt.getLong(7) ;
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
              ((decimal[]) buf[7])[0] = rslt.getDecimal(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((long[]) buf[11])[0] = rslt.getLong(7) ;
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
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((decimal[]) buf[7])[0] = rslt.getDecimal(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((long[]) buf[11])[0] = rslt.getLong(7) ;
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
                 stmt.SetParameter(4, (decimal)parms[7]);
              }
              if ( (bool)parms[8] )
              {
                 stmt.setNull( 5 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(5, (String)parms[9]);
              }
              stmt.SetParameter(6, (long)parms[10]);
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
                 stmt.SetParameter(4, (decimal)parms[7]);
              }
              if ( (bool)parms[8] )
              {
                 stmt.setNull( 5 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(5, (String)parms[9]);
              }
              stmt.SetParameter(6, (long)parms[10]);
              if ( (bool)parms[11] )
              {
                 stmt.setNull( 7 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(7, (long)parms[12]);
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
