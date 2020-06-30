/*
               File: BR_Medication_Detail_BC
        Description: 药物治疗药物详情0813弃用
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:8:8.26
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
   public class br_medication_detail_bc : GXHttpHandler, IGxSilentTrn
   {
      public br_medication_detail_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_medication_detail_bc( IGxContext context )
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
         ReadRow0U31( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey0U31( ) ;
         standaloneModal( ) ;
         AddRow0U31( ) ;
         Gx_mode = "INS";
         return  ;
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E110U2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               Z301BR_Medication_DetailID = A301BR_Medication_DetailID;
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

      protected void CONFIRM_0U0( )
      {
         BeforeValidate0U31( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0U31( ) ;
            }
            else
            {
               CheckExtendedTable0U31( ) ;
               if ( AnyError == 0 )
               {
                  ZM0U31( 8) ;
               }
               CloseExtendedTableCursors0U31( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void E120U2( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV8WWPContext) ;
         AV9IsAuthorized = true;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWBR_Medication_Detail_Insert", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWBR_Medication_Detail_Update", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWBR_Medication_Detail_Delete", out  GXt_boolean1) ;
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
               if ( StringUtil.StrCmp(AV14TrnContextAtt.gxTpr_Attributename, "BR_Medication_SchemeID") == 0 )
               {
                  AV13Insert_BR_Medication_SchemeID = (long)(NumberUtil.Val( AV14TrnContextAtt.gxTpr_Attributevalue, "."));
               }
               AV16GXV1 = (int)(AV16GXV1+1);
            }
         }
      }

      protected void E110U2( )
      {
         /* After Trn Routine */
      }

      protected void ZM0U31( short GX_JID )
      {
         if ( ( GX_JID == 7 ) || ( GX_JID == 0 ) )
         {
            Z310BR_Medication_Drug_Name = A310BR_Medication_Drug_Name;
            Z311BR_Medication_Drug_Num = A311BR_Medication_Drug_Num;
            Z312BR_Medication_Drug_Unit = A312BR_Medication_Drug_Unit;
            Z296BR_Medication_SchemeID = A296BR_Medication_SchemeID;
         }
         if ( ( GX_JID == 8 ) || ( GX_JID == 0 ) )
         {
         }
         if ( GX_JID == -7 )
         {
            Z301BR_Medication_DetailID = A301BR_Medication_DetailID;
            Z310BR_Medication_Drug_Name = A310BR_Medication_Drug_Name;
            Z311BR_Medication_Drug_Num = A311BR_Medication_Drug_Num;
            Z312BR_Medication_Drug_Unit = A312BR_Medication_Drug_Unit;
            Z296BR_Medication_SchemeID = A296BR_Medication_SchemeID;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load0U31( )
      {
         /* Using cursor BC000U5 */
         pr_default.execute(3, new Object[] {A301BR_Medication_DetailID});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound31 = 1;
            A310BR_Medication_Drug_Name = BC000U5_A310BR_Medication_Drug_Name[0];
            n310BR_Medication_Drug_Name = BC000U5_n310BR_Medication_Drug_Name[0];
            A311BR_Medication_Drug_Num = BC000U5_A311BR_Medication_Drug_Num[0];
            n311BR_Medication_Drug_Num = BC000U5_n311BR_Medication_Drug_Num[0];
            A312BR_Medication_Drug_Unit = BC000U5_A312BR_Medication_Drug_Unit[0];
            n312BR_Medication_Drug_Unit = BC000U5_n312BR_Medication_Drug_Unit[0];
            A296BR_Medication_SchemeID = BC000U5_A296BR_Medication_SchemeID[0];
            n296BR_Medication_SchemeID = BC000U5_n296BR_Medication_SchemeID[0];
            ZM0U31( -7) ;
         }
         pr_default.close(3);
         OnLoadActions0U31( ) ;
      }

      protected void OnLoadActions0U31( )
      {
         AV15Pgmname = "BR_Medication_Detail_BC";
      }

      protected void CheckExtendedTable0U31( )
      {
         standaloneModal( ) ;
         AV15Pgmname = "BR_Medication_Detail_BC";
         /* Using cursor BC000U4 */
         pr_default.execute(2, new Object[] {n296BR_Medication_SchemeID, A296BR_Medication_SchemeID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            if ( ! ( (0==A296BR_Medication_SchemeID) ) )
            {
               GX_msglist.addItem("不匹配' T32'", "ForeignKeyNotFound", 1, "BR_MEDICATION_SCHEMEID");
               AnyError = 1;
            }
         }
         pr_default.close(2);
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A310BR_Medication_Drug_Name)) )
         {
            GX_msglist.addItem("药物名称是必须填写的。", 1, "");
            AnyError = 1;
         }
      }

      protected void CloseExtendedTableCursors0U31( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0U31( )
      {
         /* Using cursor BC000U6 */
         pr_default.execute(4, new Object[] {A301BR_Medication_DetailID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound31 = 1;
         }
         else
         {
            RcdFound31 = 0;
         }
         pr_default.close(4);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC000U3 */
         pr_default.execute(1, new Object[] {A301BR_Medication_DetailID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0U31( 7) ;
            RcdFound31 = 1;
            A301BR_Medication_DetailID = BC000U3_A301BR_Medication_DetailID[0];
            A310BR_Medication_Drug_Name = BC000U3_A310BR_Medication_Drug_Name[0];
            n310BR_Medication_Drug_Name = BC000U3_n310BR_Medication_Drug_Name[0];
            A311BR_Medication_Drug_Num = BC000U3_A311BR_Medication_Drug_Num[0];
            n311BR_Medication_Drug_Num = BC000U3_n311BR_Medication_Drug_Num[0];
            A312BR_Medication_Drug_Unit = BC000U3_A312BR_Medication_Drug_Unit[0];
            n312BR_Medication_Drug_Unit = BC000U3_n312BR_Medication_Drug_Unit[0];
            A296BR_Medication_SchemeID = BC000U3_A296BR_Medication_SchemeID[0];
            n296BR_Medication_SchemeID = BC000U3_n296BR_Medication_SchemeID[0];
            Z301BR_Medication_DetailID = A301BR_Medication_DetailID;
            sMode31 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load0U31( ) ;
            if ( AnyError == 1 )
            {
               RcdFound31 = 0;
               InitializeNonKey0U31( ) ;
            }
            Gx_mode = sMode31;
         }
         else
         {
            RcdFound31 = 0;
            InitializeNonKey0U31( ) ;
            sMode31 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode31;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0U31( ) ;
         if ( RcdFound31 == 0 )
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
         CONFIRM_0U0( ) ;
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

      protected void CheckOptimisticConcurrency0U31( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC000U2 */
            pr_default.execute(0, new Object[] {A301BR_Medication_DetailID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Medication_Detail"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z310BR_Medication_Drug_Name, BC000U2_A310BR_Medication_Drug_Name[0]) != 0 ) || ( Z311BR_Medication_Drug_Num != BC000U2_A311BR_Medication_Drug_Num[0] ) || ( StringUtil.StrCmp(Z312BR_Medication_Drug_Unit, BC000U2_A312BR_Medication_Drug_Unit[0]) != 0 ) || ( Z296BR_Medication_SchemeID != BC000U2_A296BR_Medication_SchemeID[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"BR_Medication_Detail"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0U31( )
      {
         BeforeValidate0U31( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0U31( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0U31( 0) ;
            CheckOptimisticConcurrency0U31( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0U31( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0U31( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000U7 */
                     pr_default.execute(5, new Object[] {n310BR_Medication_Drug_Name, A310BR_Medication_Drug_Name, n311BR_Medication_Drug_Num, A311BR_Medication_Drug_Num, n312BR_Medication_Drug_Unit, A312BR_Medication_Drug_Unit, n296BR_Medication_SchemeID, A296BR_Medication_SchemeID});
                     A301BR_Medication_DetailID = BC000U7_A301BR_Medication_DetailID[0];
                     pr_default.close(5);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Medication_Detail") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A296BR_Medication_SchemeID), 18, 0)),  "化疗方案",  StringUtil.Trim( StringUtil.Str( (decimal)(A301BR_Medication_DetailID), 18, 0)),  "药物详情",  "Create",  1) ;
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
               Load0U31( ) ;
            }
            EndLevel0U31( ) ;
         }
         CloseExtendedTableCursors0U31( ) ;
      }

      protected void Update0U31( )
      {
         BeforeValidate0U31( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0U31( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0U31( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0U31( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0U31( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000U8 */
                     pr_default.execute(6, new Object[] {n310BR_Medication_Drug_Name, A310BR_Medication_Drug_Name, n311BR_Medication_Drug_Num, A311BR_Medication_Drug_Num, n312BR_Medication_Drug_Unit, A312BR_Medication_Drug_Unit, n296BR_Medication_SchemeID, A296BR_Medication_SchemeID, A301BR_Medication_DetailID});
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Medication_Detail") ;
                     if ( (pr_default.getStatus(6) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Medication_Detail"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0U31( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A296BR_Medication_SchemeID), 18, 0)),  "化疗方案",  StringUtil.Trim( StringUtil.Str( (decimal)(A301BR_Medication_DetailID), 18, 0)),  "药物详情",  "Update",  1) ;
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
            EndLevel0U31( ) ;
         }
         CloseExtendedTableCursors0U31( ) ;
      }

      protected void DeferredUpdate0U31( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate0U31( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0U31( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0U31( ) ;
            AfterConfirm0U31( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0U31( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC000U9 */
                  pr_default.execute(7, new Object[] {A301BR_Medication_DetailID});
                  pr_default.close(7);
                  dsDefault.SmartCacheProvider.SetUpdated("BR_Medication_Detail") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A296BR_Medication_SchemeID), 18, 0)),  "化疗方案",  StringUtil.Trim( StringUtil.Str( (decimal)(A301BR_Medication_DetailID), 18, 0)),  "药物详情",  "Delete",  1) ;
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
         sMode31 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel0U31( ) ;
         Gx_mode = sMode31;
      }

      protected void OnDeleteControls0U31( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV15Pgmname = "BR_Medication_Detail_BC";
         }
      }

      protected void EndLevel0U31( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0U31( ) ;
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

      public void ScanKeyStart0U31( )
      {
         /* Scan By routine */
         /* Using cursor BC000U10 */
         pr_default.execute(8, new Object[] {A301BR_Medication_DetailID});
         RcdFound31 = 0;
         if ( (pr_default.getStatus(8) != 101) )
         {
            RcdFound31 = 1;
            A301BR_Medication_DetailID = BC000U10_A301BR_Medication_DetailID[0];
            A310BR_Medication_Drug_Name = BC000U10_A310BR_Medication_Drug_Name[0];
            n310BR_Medication_Drug_Name = BC000U10_n310BR_Medication_Drug_Name[0];
            A311BR_Medication_Drug_Num = BC000U10_A311BR_Medication_Drug_Num[0];
            n311BR_Medication_Drug_Num = BC000U10_n311BR_Medication_Drug_Num[0];
            A312BR_Medication_Drug_Unit = BC000U10_A312BR_Medication_Drug_Unit[0];
            n312BR_Medication_Drug_Unit = BC000U10_n312BR_Medication_Drug_Unit[0];
            A296BR_Medication_SchemeID = BC000U10_A296BR_Medication_SchemeID[0];
            n296BR_Medication_SchemeID = BC000U10_n296BR_Medication_SchemeID[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext0U31( )
      {
         /* Scan next routine */
         pr_default.readNext(8);
         RcdFound31 = 0;
         ScanKeyLoad0U31( ) ;
      }

      protected void ScanKeyLoad0U31( )
      {
         sMode31 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(8) != 101) )
         {
            RcdFound31 = 1;
            A301BR_Medication_DetailID = BC000U10_A301BR_Medication_DetailID[0];
            A310BR_Medication_Drug_Name = BC000U10_A310BR_Medication_Drug_Name[0];
            n310BR_Medication_Drug_Name = BC000U10_n310BR_Medication_Drug_Name[0];
            A311BR_Medication_Drug_Num = BC000U10_A311BR_Medication_Drug_Num[0];
            n311BR_Medication_Drug_Num = BC000U10_n311BR_Medication_Drug_Num[0];
            A312BR_Medication_Drug_Unit = BC000U10_A312BR_Medication_Drug_Unit[0];
            n312BR_Medication_Drug_Unit = BC000U10_n312BR_Medication_Drug_Unit[0];
            A296BR_Medication_SchemeID = BC000U10_A296BR_Medication_SchemeID[0];
            n296BR_Medication_SchemeID = BC000U10_n296BR_Medication_SchemeID[0];
         }
         Gx_mode = sMode31;
      }

      protected void ScanKeyEnd0U31( )
      {
         pr_default.close(8);
      }

      protected void AfterConfirm0U31( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0U31( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0U31( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0U31( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0U31( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0U31( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0U31( )
      {
      }

      protected void send_integrity_lvl_hashes0U31( )
      {
      }

      protected void AddRow0U31( )
      {
         VarsToRow31( bcBR_Medication_Detail) ;
      }

      protected void ReadRow0U31( )
      {
         RowToVars31( bcBR_Medication_Detail, 1) ;
      }

      protected void InitializeNonKey0U31( )
      {
         A296BR_Medication_SchemeID = 0;
         n296BR_Medication_SchemeID = false;
         A310BR_Medication_Drug_Name = "";
         n310BR_Medication_Drug_Name = false;
         A311BR_Medication_Drug_Num = 0;
         n311BR_Medication_Drug_Num = false;
         A312BR_Medication_Drug_Unit = "";
         n312BR_Medication_Drug_Unit = false;
         Z310BR_Medication_Drug_Name = "";
         Z311BR_Medication_Drug_Num = 0;
         Z312BR_Medication_Drug_Unit = "";
         Z296BR_Medication_SchemeID = 0;
      }

      protected void InitAll0U31( )
      {
         A301BR_Medication_DetailID = 0;
         InitializeNonKey0U31( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow31( SdtBR_Medication_Detail obj31 )
      {
         obj31.gxTpr_Mode = Gx_mode;
         obj31.gxTpr_Br_medication_schemeid = A296BR_Medication_SchemeID;
         obj31.gxTpr_Br_medication_drug_name = A310BR_Medication_Drug_Name;
         obj31.gxTpr_Br_medication_drug_num = A311BR_Medication_Drug_Num;
         obj31.gxTpr_Br_medication_drug_unit = A312BR_Medication_Drug_Unit;
         obj31.gxTpr_Br_medication_detailid = A301BR_Medication_DetailID;
         obj31.gxTpr_Br_medication_detailid_Z = Z301BR_Medication_DetailID;
         obj31.gxTpr_Br_medication_schemeid_Z = Z296BR_Medication_SchemeID;
         obj31.gxTpr_Br_medication_drug_name_Z = Z310BR_Medication_Drug_Name;
         obj31.gxTpr_Br_medication_drug_num_Z = Z311BR_Medication_Drug_Num;
         obj31.gxTpr_Br_medication_drug_unit_Z = Z312BR_Medication_Drug_Unit;
         obj31.gxTpr_Br_medication_schemeid_N = (short)(Convert.ToInt16(n296BR_Medication_SchemeID));
         obj31.gxTpr_Br_medication_drug_name_N = (short)(Convert.ToInt16(n310BR_Medication_Drug_Name));
         obj31.gxTpr_Br_medication_drug_num_N = (short)(Convert.ToInt16(n311BR_Medication_Drug_Num));
         obj31.gxTpr_Br_medication_drug_unit_N = (short)(Convert.ToInt16(n312BR_Medication_Drug_Unit));
         obj31.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow31( SdtBR_Medication_Detail obj31 )
      {
         obj31.gxTpr_Br_medication_detailid = A301BR_Medication_DetailID;
         return  ;
      }

      public void RowToVars31( SdtBR_Medication_Detail obj31 ,
                               int forceLoad )
      {
         Gx_mode = obj31.gxTpr_Mode;
         A296BR_Medication_SchemeID = obj31.gxTpr_Br_medication_schemeid;
         n296BR_Medication_SchemeID = false;
         A310BR_Medication_Drug_Name = obj31.gxTpr_Br_medication_drug_name;
         n310BR_Medication_Drug_Name = false;
         A311BR_Medication_Drug_Num = obj31.gxTpr_Br_medication_drug_num;
         n311BR_Medication_Drug_Num = false;
         A312BR_Medication_Drug_Unit = obj31.gxTpr_Br_medication_drug_unit;
         n312BR_Medication_Drug_Unit = false;
         A301BR_Medication_DetailID = obj31.gxTpr_Br_medication_detailid;
         Z301BR_Medication_DetailID = obj31.gxTpr_Br_medication_detailid_Z;
         Z296BR_Medication_SchemeID = obj31.gxTpr_Br_medication_schemeid_Z;
         Z310BR_Medication_Drug_Name = obj31.gxTpr_Br_medication_drug_name_Z;
         Z311BR_Medication_Drug_Num = obj31.gxTpr_Br_medication_drug_num_Z;
         Z312BR_Medication_Drug_Unit = obj31.gxTpr_Br_medication_drug_unit_Z;
         n296BR_Medication_SchemeID = (bool)(Convert.ToBoolean(obj31.gxTpr_Br_medication_schemeid_N));
         n310BR_Medication_Drug_Name = (bool)(Convert.ToBoolean(obj31.gxTpr_Br_medication_drug_name_N));
         n311BR_Medication_Drug_Num = (bool)(Convert.ToBoolean(obj31.gxTpr_Br_medication_drug_num_N));
         n312BR_Medication_Drug_Unit = (bool)(Convert.ToBoolean(obj31.gxTpr_Br_medication_drug_unit_N));
         Gx_mode = obj31.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A301BR_Medication_DetailID = (long)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey0U31( ) ;
         ScanKeyStart0U31( ) ;
         if ( RcdFound31 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z301BR_Medication_DetailID = A301BR_Medication_DetailID;
         }
         ZM0U31( -7) ;
         OnLoadActions0U31( ) ;
         AddRow0U31( ) ;
         ScanKeyEnd0U31( ) ;
         if ( RcdFound31 == 0 )
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
         RowToVars31( bcBR_Medication_Detail, 0) ;
         ScanKeyStart0U31( ) ;
         if ( RcdFound31 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z301BR_Medication_DetailID = A301BR_Medication_DetailID;
         }
         ZM0U31( -7) ;
         OnLoadActions0U31( ) ;
         AddRow0U31( ) ;
         ScanKeyEnd0U31( ) ;
         if ( RcdFound31 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey0U31( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert0U31( ) ;
         }
         else
         {
            if ( RcdFound31 == 1 )
            {
               if ( A301BR_Medication_DetailID != Z301BR_Medication_DetailID )
               {
                  A301BR_Medication_DetailID = Z301BR_Medication_DetailID;
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
                  Update0U31( ) ;
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
                  if ( A301BR_Medication_DetailID != Z301BR_Medication_DetailID )
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
                        Insert0U31( ) ;
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
                        Insert0U31( ) ;
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
         RowToVars31( bcBR_Medication_Detail, 0) ;
         SaveImpl( ) ;
         VarsToRow31( bcBR_Medication_Detail) ;
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
         RowToVars31( bcBR_Medication_Detail, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert0U31( ) ;
         AfterTrn( ) ;
         VarsToRow31( bcBR_Medication_Detail) ;
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
            SdtBR_Medication_Detail auxBC = new SdtBR_Medication_Detail(context) ;
            auxBC.Load(A301BR_Medication_DetailID);
            auxBC.UpdateDirties(bcBR_Medication_Detail);
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
         RowToVars31( bcBR_Medication_Detail, 0) ;
         UpdateImpl( ) ;
         VarsToRow31( bcBR_Medication_Detail) ;
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
         RowToVars31( bcBR_Medication_Detail, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert0U31( ) ;
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
         VarsToRow31( bcBR_Medication_Detail) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars31( bcBR_Medication_Detail, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey0U31( ) ;
         if ( RcdFound31 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A301BR_Medication_DetailID != Z301BR_Medication_DetailID )
            {
               A301BR_Medication_DetailID = Z301BR_Medication_DetailID;
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
            if ( A301BR_Medication_DetailID != Z301BR_Medication_DetailID )
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
         context.RollbackDataStores("br_medication_detail_bc",pr_default);
         VarsToRow31( bcBR_Medication_Detail) ;
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
         Gx_mode = bcBR_Medication_Detail.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcBR_Medication_Detail.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcBR_Medication_Detail )
         {
            bcBR_Medication_Detail = (SdtBR_Medication_Detail)(sdt);
            if ( StringUtil.StrCmp(bcBR_Medication_Detail.gxTpr_Mode, "") == 0 )
            {
               bcBR_Medication_Detail.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow31( bcBR_Medication_Detail) ;
            }
            else
            {
               RowToVars31( bcBR_Medication_Detail, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcBR_Medication_Detail.gxTpr_Mode, "") == 0 )
            {
               bcBR_Medication_Detail.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars31( bcBR_Medication_Detail, 1) ;
         return  ;
      }

      public SdtBR_Medication_Detail BR_Medication_Detail_BC
      {
         get {
            return bcBR_Medication_Detail ;
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
         Z310BR_Medication_Drug_Name = "";
         A310BR_Medication_Drug_Name = "";
         Z312BR_Medication_Drug_Unit = "";
         A312BR_Medication_Drug_Unit = "";
         BC000U5_A301BR_Medication_DetailID = new long[1] ;
         BC000U5_A310BR_Medication_Drug_Name = new String[] {""} ;
         BC000U5_n310BR_Medication_Drug_Name = new bool[] {false} ;
         BC000U5_A311BR_Medication_Drug_Num = new decimal[1] ;
         BC000U5_n311BR_Medication_Drug_Num = new bool[] {false} ;
         BC000U5_A312BR_Medication_Drug_Unit = new String[] {""} ;
         BC000U5_n312BR_Medication_Drug_Unit = new bool[] {false} ;
         BC000U5_A296BR_Medication_SchemeID = new long[1] ;
         BC000U5_n296BR_Medication_SchemeID = new bool[] {false} ;
         BC000U4_A296BR_Medication_SchemeID = new long[1] ;
         BC000U4_n296BR_Medication_SchemeID = new bool[] {false} ;
         BC000U6_A301BR_Medication_DetailID = new long[1] ;
         BC000U3_A301BR_Medication_DetailID = new long[1] ;
         BC000U3_A310BR_Medication_Drug_Name = new String[] {""} ;
         BC000U3_n310BR_Medication_Drug_Name = new bool[] {false} ;
         BC000U3_A311BR_Medication_Drug_Num = new decimal[1] ;
         BC000U3_n311BR_Medication_Drug_Num = new bool[] {false} ;
         BC000U3_A312BR_Medication_Drug_Unit = new String[] {""} ;
         BC000U3_n312BR_Medication_Drug_Unit = new bool[] {false} ;
         BC000U3_A296BR_Medication_SchemeID = new long[1] ;
         BC000U3_n296BR_Medication_SchemeID = new bool[] {false} ;
         sMode31 = "";
         BC000U2_A301BR_Medication_DetailID = new long[1] ;
         BC000U2_A310BR_Medication_Drug_Name = new String[] {""} ;
         BC000U2_n310BR_Medication_Drug_Name = new bool[] {false} ;
         BC000U2_A311BR_Medication_Drug_Num = new decimal[1] ;
         BC000U2_n311BR_Medication_Drug_Num = new bool[] {false} ;
         BC000U2_A312BR_Medication_Drug_Unit = new String[] {""} ;
         BC000U2_n312BR_Medication_Drug_Unit = new bool[] {false} ;
         BC000U2_A296BR_Medication_SchemeID = new long[1] ;
         BC000U2_n296BR_Medication_SchemeID = new bool[] {false} ;
         BC000U7_A301BR_Medication_DetailID = new long[1] ;
         BC000U10_A301BR_Medication_DetailID = new long[1] ;
         BC000U10_A310BR_Medication_Drug_Name = new String[] {""} ;
         BC000U10_n310BR_Medication_Drug_Name = new bool[] {false} ;
         BC000U10_A311BR_Medication_Drug_Num = new decimal[1] ;
         BC000U10_n311BR_Medication_Drug_Num = new bool[] {false} ;
         BC000U10_A312BR_Medication_Drug_Unit = new String[] {""} ;
         BC000U10_n312BR_Medication_Drug_Unit = new bool[] {false} ;
         BC000U10_A296BR_Medication_SchemeID = new long[1] ;
         BC000U10_n296BR_Medication_SchemeID = new bool[] {false} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_medication_detail_bc__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_medication_detail_bc__default(),
            new Object[][] {
                new Object[] {
               BC000U2_A301BR_Medication_DetailID, BC000U2_A310BR_Medication_Drug_Name, BC000U2_n310BR_Medication_Drug_Name, BC000U2_A311BR_Medication_Drug_Num, BC000U2_n311BR_Medication_Drug_Num, BC000U2_A312BR_Medication_Drug_Unit, BC000U2_n312BR_Medication_Drug_Unit, BC000U2_A296BR_Medication_SchemeID, BC000U2_n296BR_Medication_SchemeID
               }
               , new Object[] {
               BC000U3_A301BR_Medication_DetailID, BC000U3_A310BR_Medication_Drug_Name, BC000U3_n310BR_Medication_Drug_Name, BC000U3_A311BR_Medication_Drug_Num, BC000U3_n311BR_Medication_Drug_Num, BC000U3_A312BR_Medication_Drug_Unit, BC000U3_n312BR_Medication_Drug_Unit, BC000U3_A296BR_Medication_SchemeID, BC000U3_n296BR_Medication_SchemeID
               }
               , new Object[] {
               BC000U4_A296BR_Medication_SchemeID
               }
               , new Object[] {
               BC000U5_A301BR_Medication_DetailID, BC000U5_A310BR_Medication_Drug_Name, BC000U5_n310BR_Medication_Drug_Name, BC000U5_A311BR_Medication_Drug_Num, BC000U5_n311BR_Medication_Drug_Num, BC000U5_A312BR_Medication_Drug_Unit, BC000U5_n312BR_Medication_Drug_Unit, BC000U5_A296BR_Medication_SchemeID, BC000U5_n296BR_Medication_SchemeID
               }
               , new Object[] {
               BC000U6_A301BR_Medication_DetailID
               }
               , new Object[] {
               BC000U7_A301BR_Medication_DetailID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000U10_A301BR_Medication_DetailID, BC000U10_A310BR_Medication_Drug_Name, BC000U10_n310BR_Medication_Drug_Name, BC000U10_A311BR_Medication_Drug_Num, BC000U10_n311BR_Medication_Drug_Num, BC000U10_A312BR_Medication_Drug_Unit, BC000U10_n312BR_Medication_Drug_Unit, BC000U10_A296BR_Medication_SchemeID, BC000U10_n296BR_Medication_SchemeID
               }
            }
         );
         AV15Pgmname = "BR_Medication_Detail_BC";
         INITTRN();
         /* Execute Start event if defined. */
         /* Execute user event: Start */
         E120U2 ();
         standaloneNotModal( ) ;
      }

      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short GX_JID ;
      private short RcdFound31 ;
      private int trnEnded ;
      private int AV16GXV1 ;
      private long Z301BR_Medication_DetailID ;
      private long A301BR_Medication_DetailID ;
      private long AV13Insert_BR_Medication_SchemeID ;
      private long Z296BR_Medication_SchemeID ;
      private long A296BR_Medication_SchemeID ;
      private decimal Z311BR_Medication_Drug_Num ;
      private decimal A311BR_Medication_Drug_Num ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String AV15Pgmname ;
      private String sMode31 ;
      private bool AV9IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool n310BR_Medication_Drug_Name ;
      private bool n311BR_Medication_Drug_Num ;
      private bool n312BR_Medication_Drug_Unit ;
      private bool n296BR_Medication_SchemeID ;
      private String Z310BR_Medication_Drug_Name ;
      private String A310BR_Medication_Drug_Name ;
      private String Z312BR_Medication_Drug_Unit ;
      private String A312BR_Medication_Drug_Unit ;
      private IGxSession AV12WebSession ;
      private SdtBR_Medication_Detail bcBR_Medication_Detail ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] BC000U5_A301BR_Medication_DetailID ;
      private String[] BC000U5_A310BR_Medication_Drug_Name ;
      private bool[] BC000U5_n310BR_Medication_Drug_Name ;
      private decimal[] BC000U5_A311BR_Medication_Drug_Num ;
      private bool[] BC000U5_n311BR_Medication_Drug_Num ;
      private String[] BC000U5_A312BR_Medication_Drug_Unit ;
      private bool[] BC000U5_n312BR_Medication_Drug_Unit ;
      private long[] BC000U5_A296BR_Medication_SchemeID ;
      private bool[] BC000U5_n296BR_Medication_SchemeID ;
      private long[] BC000U4_A296BR_Medication_SchemeID ;
      private bool[] BC000U4_n296BR_Medication_SchemeID ;
      private long[] BC000U6_A301BR_Medication_DetailID ;
      private long[] BC000U3_A301BR_Medication_DetailID ;
      private String[] BC000U3_A310BR_Medication_Drug_Name ;
      private bool[] BC000U3_n310BR_Medication_Drug_Name ;
      private decimal[] BC000U3_A311BR_Medication_Drug_Num ;
      private bool[] BC000U3_n311BR_Medication_Drug_Num ;
      private String[] BC000U3_A312BR_Medication_Drug_Unit ;
      private bool[] BC000U3_n312BR_Medication_Drug_Unit ;
      private long[] BC000U3_A296BR_Medication_SchemeID ;
      private bool[] BC000U3_n296BR_Medication_SchemeID ;
      private long[] BC000U2_A301BR_Medication_DetailID ;
      private String[] BC000U2_A310BR_Medication_Drug_Name ;
      private bool[] BC000U2_n310BR_Medication_Drug_Name ;
      private decimal[] BC000U2_A311BR_Medication_Drug_Num ;
      private bool[] BC000U2_n311BR_Medication_Drug_Num ;
      private String[] BC000U2_A312BR_Medication_Drug_Unit ;
      private bool[] BC000U2_n312BR_Medication_Drug_Unit ;
      private long[] BC000U2_A296BR_Medication_SchemeID ;
      private bool[] BC000U2_n296BR_Medication_SchemeID ;
      private long[] BC000U7_A301BR_Medication_DetailID ;
      private long[] BC000U10_A301BR_Medication_DetailID ;
      private String[] BC000U10_A310BR_Medication_Drug_Name ;
      private bool[] BC000U10_n310BR_Medication_Drug_Name ;
      private decimal[] BC000U10_A311BR_Medication_Drug_Num ;
      private bool[] BC000U10_n311BR_Medication_Drug_Num ;
      private String[] BC000U10_A312BR_Medication_Drug_Unit ;
      private bool[] BC000U10_n312BR_Medication_Drug_Unit ;
      private long[] BC000U10_A296BR_Medication_SchemeID ;
      private bool[] BC000U10_n296BR_Medication_SchemeID ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_datastore1 ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV8WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV11TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV14TrnContextAtt ;
   }

   public class br_medication_detail_bc__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class br_medication_detail_bc__default : DataStoreHelperBase, IDataStoreHelper
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
        Object[] prmBC000U5 ;
        prmBC000U5 = new Object[] {
        new Object[] {"@BR_Medication_DetailID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000U4 ;
        prmBC000U4 = new Object[] {
        new Object[] {"@BR_Medication_SchemeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000U6 ;
        prmBC000U6 = new Object[] {
        new Object[] {"@BR_Medication_DetailID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000U3 ;
        prmBC000U3 = new Object[] {
        new Object[] {"@BR_Medication_DetailID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000U2 ;
        prmBC000U2 = new Object[] {
        new Object[] {"@BR_Medication_DetailID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000U7 ;
        prmBC000U7 = new Object[] {
        new Object[] {"@BR_Medication_Drug_Name",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Medication_Drug_Num",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_Medication_Drug_Unit",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Medication_SchemeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000U8 ;
        prmBC000U8 = new Object[] {
        new Object[] {"@BR_Medication_Drug_Name",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Medication_Drug_Num",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_Medication_Drug_Unit",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Medication_SchemeID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_Medication_DetailID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000U9 ;
        prmBC000U9 = new Object[] {
        new Object[] {"@BR_Medication_DetailID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000U10 ;
        prmBC000U10 = new Object[] {
        new Object[] {"@BR_Medication_DetailID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("BC000U2", "SELECT [BR_Medication_DetailID], [BR_Medication_Drug_Name], [BR_Medication_Drug_Num], [BR_Medication_Drug_Unit], [BR_Medication_SchemeID] FROM [BR_Medication_Detail] WITH (UPDLOCK) WHERE [BR_Medication_DetailID] = @BR_Medication_DetailID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000U2,1,0,true,false )
           ,new CursorDef("BC000U3", "SELECT [BR_Medication_DetailID], [BR_Medication_Drug_Name], [BR_Medication_Drug_Num], [BR_Medication_Drug_Unit], [BR_Medication_SchemeID] FROM [BR_Medication_Detail] WITH (NOLOCK) WHERE [BR_Medication_DetailID] = @BR_Medication_DetailID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000U3,1,0,true,false )
           ,new CursorDef("BC000U4", "SELECT [BR_Medication_SchemeID] FROM [BR_Medication_Scheme] WITH (NOLOCK) WHERE [BR_Medication_SchemeID] = @BR_Medication_SchemeID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000U4,1,0,true,false )
           ,new CursorDef("BC000U5", "SELECT TM1.[BR_Medication_DetailID], TM1.[BR_Medication_Drug_Name], TM1.[BR_Medication_Drug_Num], TM1.[BR_Medication_Drug_Unit], TM1.[BR_Medication_SchemeID] FROM [BR_Medication_Detail] TM1 WITH (NOLOCK) WHERE TM1.[BR_Medication_DetailID] = @BR_Medication_DetailID ORDER BY TM1.[BR_Medication_DetailID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000U5,100,0,true,false )
           ,new CursorDef("BC000U6", "SELECT [BR_Medication_DetailID] FROM [BR_Medication_Detail] WITH (NOLOCK) WHERE [BR_Medication_DetailID] = @BR_Medication_DetailID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000U6,1,0,true,false )
           ,new CursorDef("BC000U7", "INSERT INTO [BR_Medication_Detail]([BR_Medication_Drug_Name], [BR_Medication_Drug_Num], [BR_Medication_Drug_Unit], [BR_Medication_SchemeID]) VALUES(@BR_Medication_Drug_Name, @BR_Medication_Drug_Num, @BR_Medication_Drug_Unit, @BR_Medication_SchemeID); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmBC000U7)
           ,new CursorDef("BC000U8", "UPDATE [BR_Medication_Detail] SET [BR_Medication_Drug_Name]=@BR_Medication_Drug_Name, [BR_Medication_Drug_Num]=@BR_Medication_Drug_Num, [BR_Medication_Drug_Unit]=@BR_Medication_Drug_Unit, [BR_Medication_SchemeID]=@BR_Medication_SchemeID  WHERE [BR_Medication_DetailID] = @BR_Medication_DetailID", GxErrorMask.GX_NOMASK,prmBC000U8)
           ,new CursorDef("BC000U9", "DELETE FROM [BR_Medication_Detail]  WHERE [BR_Medication_DetailID] = @BR_Medication_DetailID", GxErrorMask.GX_NOMASK,prmBC000U9)
           ,new CursorDef("BC000U10", "SELECT TM1.[BR_Medication_DetailID], TM1.[BR_Medication_Drug_Name], TM1.[BR_Medication_Drug_Num], TM1.[BR_Medication_Drug_Unit], TM1.[BR_Medication_SchemeID] FROM [BR_Medication_Detail] TM1 WITH (NOLOCK) WHERE TM1.[BR_Medication_DetailID] = @BR_Medication_DetailID ORDER BY TM1.[BR_Medication_DetailID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000U10,100,0,true,false )
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
              ((decimal[]) buf[3])[0] = rslt.getDecimal(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((long[]) buf[7])[0] = rslt.getLong(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((decimal[]) buf[3])[0] = rslt.getDecimal(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((long[]) buf[7])[0] = rslt.getLong(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              return;
           case 2 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 3 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((decimal[]) buf[3])[0] = rslt.getDecimal(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((long[]) buf[7])[0] = rslt.getLong(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
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
              ((decimal[]) buf[3])[0] = rslt.getDecimal(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((long[]) buf[7])[0] = rslt.getLong(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
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
                 stmt.setNull( 2 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(2, (decimal)parms[3]);
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
                 stmt.setNull( 2 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(2, (decimal)parms[3]);
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
              stmt.SetParameter(5, (long)parms[8]);
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
