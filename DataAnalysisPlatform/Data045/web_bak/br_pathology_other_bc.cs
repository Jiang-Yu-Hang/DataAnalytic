/*
               File: BR_Pathology_Other_BC
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:38:36.36
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
   public class br_pathology_other_bc : GXHttpHandler, IGxSilentTrn
   {
      public br_pathology_other_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_pathology_other_bc( IGxContext context )
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
         ReadRow0Y35( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey0Y35( ) ;
         standaloneModal( ) ;
         AddRow0Y35( ) ;
         Gx_mode = "INS";
         return  ;
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E110Y2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               Z288BR_Pathology_OtherID = A288BR_Pathology_OtherID;
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

      protected void CONFIRM_0Y0( )
      {
         BeforeValidate0Y35( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0Y35( ) ;
            }
            else
            {
               CheckExtendedTable0Y35( ) ;
               if ( AnyError == 0 )
               {
                  ZM0Y35( 11) ;
               }
               CloseExtendedTableCursors0Y35( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void E120Y2( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV8WWPContext) ;
         AV9IsAuthorized = true;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Pathology_Other", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Pathology_Other", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Pathology_Other", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
         }
         if ( ! AV9IsAuthorized )
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
         AV11TrnContext.FromXml(AV12WebSession.Get("TrnContext"), null, "WWPTransactionContext", "DataAnalysisPlatform");
         if ( ( StringUtil.StrCmp(AV11TrnContext.gxTpr_Transactionname, AV20Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV21GXV1 = 1;
            while ( AV21GXV1 <= AV11TrnContext.gxTpr_Attributes.Count )
            {
               AV14TrnContextAtt = ((GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute)AV11TrnContext.gxTpr_Attributes.Item(AV21GXV1));
               if ( StringUtil.StrCmp(AV14TrnContextAtt.gxTpr_Attributename, "BR_PathologyID") == 0 )
               {
                  AV13Insert_BR_PathologyID = (long)(NumberUtil.Val( AV14TrnContextAtt.gxTpr_Attributevalue, "."));
               }
               AV21GXV1 = (int)(AV21GXV1+1);
            }
         }
      }

      protected void E110Y2( )
      {
         /* After Trn Routine */
      }

      protected void E130Y2( )
      {
         /* 'Dobeizhu' Routine */
         context.PopUp(formatLink("beizhu.aspx") , new Object[] {});
      }

      protected void S112( )
      {
         /* 'ATTRIBUTESSECURITYCODE' Routine */
      }

      protected void ZM0Y35( short GX_JID )
      {
         if ( ( GX_JID == 10 ) || ( GX_JID == 0 ) )
         {
            Z509BR_Pathology_Other_AbnInd_Code = A509BR_Pathology_Other_AbnInd_Code;
            Z289BR_Pathology_Other_Bio = A289BR_Pathology_Other_Bio;
            Z480BR_Pathology_Other_Bio_Code = A480BR_Pathology_Other_Bio_Code;
            Z290BR_Pathology_Other_BioNum = A290BR_Pathology_Other_BioNum;
            Z481BR_Pathology_Other_BioNum_Code = A481BR_Pathology_Other_BioNum_Code;
            Z291BR_Pathology_Other_BioNumUnit = A291BR_Pathology_Other_BioNumUnit;
            Z292BR_Pathology_Other_BioQual = A292BR_Pathology_Other_BioQual;
            Z482BR_Pathology_Other_BioQual_Code = A482BR_Pathology_Other_BioQual_Code;
            Z293BR_Pathology_Other_Low = A293BR_Pathology_Other_Low;
            Z294BR_Pathology_Other_High = A294BR_Pathology_Other_High;
            Z295BR_Pathology_Other_AbnInd = A295BR_Pathology_Other_AbnInd;
            Z226BR_PathologyID = A226BR_PathologyID;
         }
         if ( ( GX_JID == 11 ) || ( GX_JID == 0 ) )
         {
         }
         if ( GX_JID == -10 )
         {
            Z288BR_Pathology_OtherID = A288BR_Pathology_OtherID;
            Z509BR_Pathology_Other_AbnInd_Code = A509BR_Pathology_Other_AbnInd_Code;
            Z289BR_Pathology_Other_Bio = A289BR_Pathology_Other_Bio;
            Z480BR_Pathology_Other_Bio_Code = A480BR_Pathology_Other_Bio_Code;
            Z290BR_Pathology_Other_BioNum = A290BR_Pathology_Other_BioNum;
            Z481BR_Pathology_Other_BioNum_Code = A481BR_Pathology_Other_BioNum_Code;
            Z291BR_Pathology_Other_BioNumUnit = A291BR_Pathology_Other_BioNumUnit;
            Z292BR_Pathology_Other_BioQual = A292BR_Pathology_Other_BioQual;
            Z482BR_Pathology_Other_BioQual_Code = A482BR_Pathology_Other_BioQual_Code;
            Z293BR_Pathology_Other_Low = A293BR_Pathology_Other_Low;
            Z294BR_Pathology_Other_High = A294BR_Pathology_Other_High;
            Z295BR_Pathology_Other_AbnInd = A295BR_Pathology_Other_AbnInd;
            Z226BR_PathologyID = A226BR_PathologyID;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load0Y35( )
      {
         /* Using cursor BC000Y5 */
         pr_default.execute(3, new Object[] {A288BR_Pathology_OtherID});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound35 = 1;
            A509BR_Pathology_Other_AbnInd_Code = BC000Y5_A509BR_Pathology_Other_AbnInd_Code[0];
            n509BR_Pathology_Other_AbnInd_Code = BC000Y5_n509BR_Pathology_Other_AbnInd_Code[0];
            A289BR_Pathology_Other_Bio = BC000Y5_A289BR_Pathology_Other_Bio[0];
            n289BR_Pathology_Other_Bio = BC000Y5_n289BR_Pathology_Other_Bio[0];
            A480BR_Pathology_Other_Bio_Code = BC000Y5_A480BR_Pathology_Other_Bio_Code[0];
            n480BR_Pathology_Other_Bio_Code = BC000Y5_n480BR_Pathology_Other_Bio_Code[0];
            A290BR_Pathology_Other_BioNum = BC000Y5_A290BR_Pathology_Other_BioNum[0];
            n290BR_Pathology_Other_BioNum = BC000Y5_n290BR_Pathology_Other_BioNum[0];
            A481BR_Pathology_Other_BioNum_Code = BC000Y5_A481BR_Pathology_Other_BioNum_Code[0];
            n481BR_Pathology_Other_BioNum_Code = BC000Y5_n481BR_Pathology_Other_BioNum_Code[0];
            A291BR_Pathology_Other_BioNumUnit = BC000Y5_A291BR_Pathology_Other_BioNumUnit[0];
            n291BR_Pathology_Other_BioNumUnit = BC000Y5_n291BR_Pathology_Other_BioNumUnit[0];
            A292BR_Pathology_Other_BioQual = BC000Y5_A292BR_Pathology_Other_BioQual[0];
            n292BR_Pathology_Other_BioQual = BC000Y5_n292BR_Pathology_Other_BioQual[0];
            A482BR_Pathology_Other_BioQual_Code = BC000Y5_A482BR_Pathology_Other_BioQual_Code[0];
            n482BR_Pathology_Other_BioQual_Code = BC000Y5_n482BR_Pathology_Other_BioQual_Code[0];
            A293BR_Pathology_Other_Low = BC000Y5_A293BR_Pathology_Other_Low[0];
            n293BR_Pathology_Other_Low = BC000Y5_n293BR_Pathology_Other_Low[0];
            A294BR_Pathology_Other_High = BC000Y5_A294BR_Pathology_Other_High[0];
            n294BR_Pathology_Other_High = BC000Y5_n294BR_Pathology_Other_High[0];
            A295BR_Pathology_Other_AbnInd = BC000Y5_A295BR_Pathology_Other_AbnInd[0];
            n295BR_Pathology_Other_AbnInd = BC000Y5_n295BR_Pathology_Other_AbnInd[0];
            A226BR_PathologyID = BC000Y5_A226BR_PathologyID[0];
            n226BR_PathologyID = BC000Y5_n226BR_PathologyID[0];
            ZM0Y35( -10) ;
         }
         pr_default.close(3);
         OnLoadActions0Y35( ) ;
      }

      protected void OnLoadActions0Y35( )
      {
         AV20Pgmname = "BR_Pathology_Other_BC";
      }

      protected void CheckExtendedTable0Y35( )
      {
         standaloneModal( ) ;
         AV20Pgmname = "BR_Pathology_Other_BC";
         /* Using cursor BC000Y4 */
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
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A289BR_Pathology_Other_Bio)) )
         {
            GX_msglist.addItem("肿瘤标志物是必须填写的。", 1, "");
            AnyError = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A292BR_Pathology_Other_BioQual)) )
         {
            GX_msglist.addItem("定性结果是必须填写的。", 1, "");
            AnyError = 1;
         }
      }

      protected void CloseExtendedTableCursors0Y35( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0Y35( )
      {
         /* Using cursor BC000Y6 */
         pr_default.execute(4, new Object[] {A288BR_Pathology_OtherID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound35 = 1;
         }
         else
         {
            RcdFound35 = 0;
         }
         pr_default.close(4);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC000Y3 */
         pr_default.execute(1, new Object[] {A288BR_Pathology_OtherID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0Y35( 10) ;
            RcdFound35 = 1;
            A288BR_Pathology_OtherID = BC000Y3_A288BR_Pathology_OtherID[0];
            A509BR_Pathology_Other_AbnInd_Code = BC000Y3_A509BR_Pathology_Other_AbnInd_Code[0];
            n509BR_Pathology_Other_AbnInd_Code = BC000Y3_n509BR_Pathology_Other_AbnInd_Code[0];
            A289BR_Pathology_Other_Bio = BC000Y3_A289BR_Pathology_Other_Bio[0];
            n289BR_Pathology_Other_Bio = BC000Y3_n289BR_Pathology_Other_Bio[0];
            A480BR_Pathology_Other_Bio_Code = BC000Y3_A480BR_Pathology_Other_Bio_Code[0];
            n480BR_Pathology_Other_Bio_Code = BC000Y3_n480BR_Pathology_Other_Bio_Code[0];
            A290BR_Pathology_Other_BioNum = BC000Y3_A290BR_Pathology_Other_BioNum[0];
            n290BR_Pathology_Other_BioNum = BC000Y3_n290BR_Pathology_Other_BioNum[0];
            A481BR_Pathology_Other_BioNum_Code = BC000Y3_A481BR_Pathology_Other_BioNum_Code[0];
            n481BR_Pathology_Other_BioNum_Code = BC000Y3_n481BR_Pathology_Other_BioNum_Code[0];
            A291BR_Pathology_Other_BioNumUnit = BC000Y3_A291BR_Pathology_Other_BioNumUnit[0];
            n291BR_Pathology_Other_BioNumUnit = BC000Y3_n291BR_Pathology_Other_BioNumUnit[0];
            A292BR_Pathology_Other_BioQual = BC000Y3_A292BR_Pathology_Other_BioQual[0];
            n292BR_Pathology_Other_BioQual = BC000Y3_n292BR_Pathology_Other_BioQual[0];
            A482BR_Pathology_Other_BioQual_Code = BC000Y3_A482BR_Pathology_Other_BioQual_Code[0];
            n482BR_Pathology_Other_BioQual_Code = BC000Y3_n482BR_Pathology_Other_BioQual_Code[0];
            A293BR_Pathology_Other_Low = BC000Y3_A293BR_Pathology_Other_Low[0];
            n293BR_Pathology_Other_Low = BC000Y3_n293BR_Pathology_Other_Low[0];
            A294BR_Pathology_Other_High = BC000Y3_A294BR_Pathology_Other_High[0];
            n294BR_Pathology_Other_High = BC000Y3_n294BR_Pathology_Other_High[0];
            A295BR_Pathology_Other_AbnInd = BC000Y3_A295BR_Pathology_Other_AbnInd[0];
            n295BR_Pathology_Other_AbnInd = BC000Y3_n295BR_Pathology_Other_AbnInd[0];
            A226BR_PathologyID = BC000Y3_A226BR_PathologyID[0];
            n226BR_PathologyID = BC000Y3_n226BR_PathologyID[0];
            Z288BR_Pathology_OtherID = A288BR_Pathology_OtherID;
            sMode35 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load0Y35( ) ;
            if ( AnyError == 1 )
            {
               RcdFound35 = 0;
               InitializeNonKey0Y35( ) ;
            }
            Gx_mode = sMode35;
         }
         else
         {
            RcdFound35 = 0;
            InitializeNonKey0Y35( ) ;
            sMode35 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode35;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0Y35( ) ;
         if ( RcdFound35 == 0 )
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
         CONFIRM_0Y0( ) ;
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

      protected void CheckOptimisticConcurrency0Y35( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC000Y2 */
            pr_default.execute(0, new Object[] {A288BR_Pathology_OtherID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Pathology_Other"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z509BR_Pathology_Other_AbnInd_Code, BC000Y2_A509BR_Pathology_Other_AbnInd_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z289BR_Pathology_Other_Bio, BC000Y2_A289BR_Pathology_Other_Bio[0]) != 0 ) || ( StringUtil.StrCmp(Z480BR_Pathology_Other_Bio_Code, BC000Y2_A480BR_Pathology_Other_Bio_Code[0]) != 0 ) || ( Z290BR_Pathology_Other_BioNum != BC000Y2_A290BR_Pathology_Other_BioNum[0] ) || ( StringUtil.StrCmp(Z481BR_Pathology_Other_BioNum_Code, BC000Y2_A481BR_Pathology_Other_BioNum_Code[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z291BR_Pathology_Other_BioNumUnit, BC000Y2_A291BR_Pathology_Other_BioNumUnit[0]) != 0 ) || ( StringUtil.StrCmp(Z292BR_Pathology_Other_BioQual, BC000Y2_A292BR_Pathology_Other_BioQual[0]) != 0 ) || ( StringUtil.StrCmp(Z482BR_Pathology_Other_BioQual_Code, BC000Y2_A482BR_Pathology_Other_BioQual_Code[0]) != 0 ) || ( Z293BR_Pathology_Other_Low != BC000Y2_A293BR_Pathology_Other_Low[0] ) || ( Z294BR_Pathology_Other_High != BC000Y2_A294BR_Pathology_Other_High[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z295BR_Pathology_Other_AbnInd, BC000Y2_A295BR_Pathology_Other_AbnInd[0]) != 0 ) || ( Z226BR_PathologyID != BC000Y2_A226BR_PathologyID[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"BR_Pathology_Other"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0Y35( )
      {
         BeforeValidate0Y35( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0Y35( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0Y35( 0) ;
            CheckOptimisticConcurrency0Y35( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0Y35( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0Y35( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000Y7 */
                     pr_default.execute(5, new Object[] {n509BR_Pathology_Other_AbnInd_Code, A509BR_Pathology_Other_AbnInd_Code, n289BR_Pathology_Other_Bio, A289BR_Pathology_Other_Bio, n480BR_Pathology_Other_Bio_Code, A480BR_Pathology_Other_Bio_Code, n290BR_Pathology_Other_BioNum, A290BR_Pathology_Other_BioNum, n481BR_Pathology_Other_BioNum_Code, A481BR_Pathology_Other_BioNum_Code, n291BR_Pathology_Other_BioNumUnit, A291BR_Pathology_Other_BioNumUnit, n292BR_Pathology_Other_BioQual, A292BR_Pathology_Other_BioQual, n482BR_Pathology_Other_BioQual_Code, A482BR_Pathology_Other_BioQual_Code, n293BR_Pathology_Other_Low, A293BR_Pathology_Other_Low, n294BR_Pathology_Other_High, A294BR_Pathology_Other_High, n295BR_Pathology_Other_AbnInd, A295BR_Pathology_Other_AbnInd, n226BR_PathologyID, A226BR_PathologyID});
                     A288BR_Pathology_OtherID = BC000Y7_A288BR_Pathology_OtherID[0];
                     pr_default.close(5);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Pathology_Other") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)),  "病理学",  StringUtil.Trim( StringUtil.Str( (decimal)(A288BR_Pathology_OtherID), 18, 0)),  "其它信息",  "Create",  1) ;
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
               Load0Y35( ) ;
            }
            EndLevel0Y35( ) ;
         }
         CloseExtendedTableCursors0Y35( ) ;
      }

      protected void Update0Y35( )
      {
         BeforeValidate0Y35( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0Y35( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0Y35( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0Y35( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0Y35( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000Y8 */
                     pr_default.execute(6, new Object[] {n509BR_Pathology_Other_AbnInd_Code, A509BR_Pathology_Other_AbnInd_Code, n289BR_Pathology_Other_Bio, A289BR_Pathology_Other_Bio, n480BR_Pathology_Other_Bio_Code, A480BR_Pathology_Other_Bio_Code, n290BR_Pathology_Other_BioNum, A290BR_Pathology_Other_BioNum, n481BR_Pathology_Other_BioNum_Code, A481BR_Pathology_Other_BioNum_Code, n291BR_Pathology_Other_BioNumUnit, A291BR_Pathology_Other_BioNumUnit, n292BR_Pathology_Other_BioQual, A292BR_Pathology_Other_BioQual, n482BR_Pathology_Other_BioQual_Code, A482BR_Pathology_Other_BioQual_Code, n293BR_Pathology_Other_Low, A293BR_Pathology_Other_Low, n294BR_Pathology_Other_High, A294BR_Pathology_Other_High, n295BR_Pathology_Other_AbnInd, A295BR_Pathology_Other_AbnInd, n226BR_PathologyID, A226BR_PathologyID, A288BR_Pathology_OtherID});
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Pathology_Other") ;
                     if ( (pr_default.getStatus(6) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Pathology_Other"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0Y35( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)),  "病理学",  StringUtil.Trim( StringUtil.Str( (decimal)(A288BR_Pathology_OtherID), 18, 0)),  "其它信息",  "Update",  1) ;
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
            EndLevel0Y35( ) ;
         }
         CloseExtendedTableCursors0Y35( ) ;
      }

      protected void DeferredUpdate0Y35( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate0Y35( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0Y35( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0Y35( ) ;
            AfterConfirm0Y35( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0Y35( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC000Y9 */
                  pr_default.execute(7, new Object[] {A288BR_Pathology_OtherID});
                  pr_default.close(7);
                  dsDefault.SmartCacheProvider.SetUpdated("BR_Pathology_Other") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)),  "病理学",  StringUtil.Trim( StringUtil.Str( (decimal)(A288BR_Pathology_OtherID), 18, 0)),  "其它信息",  "Delete",  1) ;
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
         sMode35 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel0Y35( ) ;
         Gx_mode = sMode35;
      }

      protected void OnDeleteControls0Y35( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV20Pgmname = "BR_Pathology_Other_BC";
         }
      }

      protected void EndLevel0Y35( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0Y35( ) ;
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

      public void ScanKeyStart0Y35( )
      {
         /* Scan By routine */
         /* Using cursor BC000Y10 */
         pr_default.execute(8, new Object[] {A288BR_Pathology_OtherID});
         RcdFound35 = 0;
         if ( (pr_default.getStatus(8) != 101) )
         {
            RcdFound35 = 1;
            A288BR_Pathology_OtherID = BC000Y10_A288BR_Pathology_OtherID[0];
            A509BR_Pathology_Other_AbnInd_Code = BC000Y10_A509BR_Pathology_Other_AbnInd_Code[0];
            n509BR_Pathology_Other_AbnInd_Code = BC000Y10_n509BR_Pathology_Other_AbnInd_Code[0];
            A289BR_Pathology_Other_Bio = BC000Y10_A289BR_Pathology_Other_Bio[0];
            n289BR_Pathology_Other_Bio = BC000Y10_n289BR_Pathology_Other_Bio[0];
            A480BR_Pathology_Other_Bio_Code = BC000Y10_A480BR_Pathology_Other_Bio_Code[0];
            n480BR_Pathology_Other_Bio_Code = BC000Y10_n480BR_Pathology_Other_Bio_Code[0];
            A290BR_Pathology_Other_BioNum = BC000Y10_A290BR_Pathology_Other_BioNum[0];
            n290BR_Pathology_Other_BioNum = BC000Y10_n290BR_Pathology_Other_BioNum[0];
            A481BR_Pathology_Other_BioNum_Code = BC000Y10_A481BR_Pathology_Other_BioNum_Code[0];
            n481BR_Pathology_Other_BioNum_Code = BC000Y10_n481BR_Pathology_Other_BioNum_Code[0];
            A291BR_Pathology_Other_BioNumUnit = BC000Y10_A291BR_Pathology_Other_BioNumUnit[0];
            n291BR_Pathology_Other_BioNumUnit = BC000Y10_n291BR_Pathology_Other_BioNumUnit[0];
            A292BR_Pathology_Other_BioQual = BC000Y10_A292BR_Pathology_Other_BioQual[0];
            n292BR_Pathology_Other_BioQual = BC000Y10_n292BR_Pathology_Other_BioQual[0];
            A482BR_Pathology_Other_BioQual_Code = BC000Y10_A482BR_Pathology_Other_BioQual_Code[0];
            n482BR_Pathology_Other_BioQual_Code = BC000Y10_n482BR_Pathology_Other_BioQual_Code[0];
            A293BR_Pathology_Other_Low = BC000Y10_A293BR_Pathology_Other_Low[0];
            n293BR_Pathology_Other_Low = BC000Y10_n293BR_Pathology_Other_Low[0];
            A294BR_Pathology_Other_High = BC000Y10_A294BR_Pathology_Other_High[0];
            n294BR_Pathology_Other_High = BC000Y10_n294BR_Pathology_Other_High[0];
            A295BR_Pathology_Other_AbnInd = BC000Y10_A295BR_Pathology_Other_AbnInd[0];
            n295BR_Pathology_Other_AbnInd = BC000Y10_n295BR_Pathology_Other_AbnInd[0];
            A226BR_PathologyID = BC000Y10_A226BR_PathologyID[0];
            n226BR_PathologyID = BC000Y10_n226BR_PathologyID[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext0Y35( )
      {
         /* Scan next routine */
         pr_default.readNext(8);
         RcdFound35 = 0;
         ScanKeyLoad0Y35( ) ;
      }

      protected void ScanKeyLoad0Y35( )
      {
         sMode35 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(8) != 101) )
         {
            RcdFound35 = 1;
            A288BR_Pathology_OtherID = BC000Y10_A288BR_Pathology_OtherID[0];
            A509BR_Pathology_Other_AbnInd_Code = BC000Y10_A509BR_Pathology_Other_AbnInd_Code[0];
            n509BR_Pathology_Other_AbnInd_Code = BC000Y10_n509BR_Pathology_Other_AbnInd_Code[0];
            A289BR_Pathology_Other_Bio = BC000Y10_A289BR_Pathology_Other_Bio[0];
            n289BR_Pathology_Other_Bio = BC000Y10_n289BR_Pathology_Other_Bio[0];
            A480BR_Pathology_Other_Bio_Code = BC000Y10_A480BR_Pathology_Other_Bio_Code[0];
            n480BR_Pathology_Other_Bio_Code = BC000Y10_n480BR_Pathology_Other_Bio_Code[0];
            A290BR_Pathology_Other_BioNum = BC000Y10_A290BR_Pathology_Other_BioNum[0];
            n290BR_Pathology_Other_BioNum = BC000Y10_n290BR_Pathology_Other_BioNum[0];
            A481BR_Pathology_Other_BioNum_Code = BC000Y10_A481BR_Pathology_Other_BioNum_Code[0];
            n481BR_Pathology_Other_BioNum_Code = BC000Y10_n481BR_Pathology_Other_BioNum_Code[0];
            A291BR_Pathology_Other_BioNumUnit = BC000Y10_A291BR_Pathology_Other_BioNumUnit[0];
            n291BR_Pathology_Other_BioNumUnit = BC000Y10_n291BR_Pathology_Other_BioNumUnit[0];
            A292BR_Pathology_Other_BioQual = BC000Y10_A292BR_Pathology_Other_BioQual[0];
            n292BR_Pathology_Other_BioQual = BC000Y10_n292BR_Pathology_Other_BioQual[0];
            A482BR_Pathology_Other_BioQual_Code = BC000Y10_A482BR_Pathology_Other_BioQual_Code[0];
            n482BR_Pathology_Other_BioQual_Code = BC000Y10_n482BR_Pathology_Other_BioQual_Code[0];
            A293BR_Pathology_Other_Low = BC000Y10_A293BR_Pathology_Other_Low[0];
            n293BR_Pathology_Other_Low = BC000Y10_n293BR_Pathology_Other_Low[0];
            A294BR_Pathology_Other_High = BC000Y10_A294BR_Pathology_Other_High[0];
            n294BR_Pathology_Other_High = BC000Y10_n294BR_Pathology_Other_High[0];
            A295BR_Pathology_Other_AbnInd = BC000Y10_A295BR_Pathology_Other_AbnInd[0];
            n295BR_Pathology_Other_AbnInd = BC000Y10_n295BR_Pathology_Other_AbnInd[0];
            A226BR_PathologyID = BC000Y10_A226BR_PathologyID[0];
            n226BR_PathologyID = BC000Y10_n226BR_PathologyID[0];
         }
         Gx_mode = sMode35;
      }

      protected void ScanKeyEnd0Y35( )
      {
         pr_default.close(8);
      }

      protected void AfterConfirm0Y35( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0Y35( )
      {
         /* Before Insert Rules */
         GXt_char2 = A509BR_Pathology_Other_AbnInd_Code;
         new zutil_findtargetcode(context ).execute(  38,  A295BR_Pathology_Other_AbnInd, out  GXt_char2) ;
         A509BR_Pathology_Other_AbnInd_Code = GXt_char2;
         n509BR_Pathology_Other_AbnInd_Code = false;
      }

      protected void BeforeUpdate0Y35( )
      {
         /* Before Update Rules */
         GXt_char2 = A509BR_Pathology_Other_AbnInd_Code;
         new zutil_findtargetcode(context ).execute(  38,  A295BR_Pathology_Other_AbnInd, out  GXt_char2) ;
         A509BR_Pathology_Other_AbnInd_Code = GXt_char2;
         n509BR_Pathology_Other_AbnInd_Code = false;
      }

      protected void BeforeDelete0Y35( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0Y35( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0Y35( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0Y35( )
      {
      }

      protected void send_integrity_lvl_hashes0Y35( )
      {
      }

      protected void AddRow0Y35( )
      {
         VarsToRow35( bcBR_Pathology_Other) ;
      }

      protected void ReadRow0Y35( )
      {
         RowToVars35( bcBR_Pathology_Other, 1) ;
      }

      protected void InitializeNonKey0Y35( )
      {
         A509BR_Pathology_Other_AbnInd_Code = "";
         n509BR_Pathology_Other_AbnInd_Code = false;
         A226BR_PathologyID = 0;
         n226BR_PathologyID = false;
         A289BR_Pathology_Other_Bio = "";
         n289BR_Pathology_Other_Bio = false;
         A480BR_Pathology_Other_Bio_Code = "";
         n480BR_Pathology_Other_Bio_Code = false;
         A290BR_Pathology_Other_BioNum = 0;
         n290BR_Pathology_Other_BioNum = false;
         A481BR_Pathology_Other_BioNum_Code = "";
         n481BR_Pathology_Other_BioNum_Code = false;
         A291BR_Pathology_Other_BioNumUnit = "";
         n291BR_Pathology_Other_BioNumUnit = false;
         A292BR_Pathology_Other_BioQual = "";
         n292BR_Pathology_Other_BioQual = false;
         A482BR_Pathology_Other_BioQual_Code = "";
         n482BR_Pathology_Other_BioQual_Code = false;
         A293BR_Pathology_Other_Low = 0;
         n293BR_Pathology_Other_Low = false;
         A294BR_Pathology_Other_High = 0;
         n294BR_Pathology_Other_High = false;
         A295BR_Pathology_Other_AbnInd = "";
         n295BR_Pathology_Other_AbnInd = false;
         Z509BR_Pathology_Other_AbnInd_Code = "";
         Z289BR_Pathology_Other_Bio = "";
         Z480BR_Pathology_Other_Bio_Code = "";
         Z290BR_Pathology_Other_BioNum = 0;
         Z481BR_Pathology_Other_BioNum_Code = "";
         Z291BR_Pathology_Other_BioNumUnit = "";
         Z292BR_Pathology_Other_BioQual = "";
         Z482BR_Pathology_Other_BioQual_Code = "";
         Z293BR_Pathology_Other_Low = 0;
         Z294BR_Pathology_Other_High = 0;
         Z295BR_Pathology_Other_AbnInd = "";
         Z226BR_PathologyID = 0;
      }

      protected void InitAll0Y35( )
      {
         A288BR_Pathology_OtherID = 0;
         InitializeNonKey0Y35( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow35( SdtBR_Pathology_Other obj35 )
      {
         obj35.gxTpr_Mode = Gx_mode;
         obj35.gxTpr_Br_pathology_other_abnind_code = A509BR_Pathology_Other_AbnInd_Code;
         obj35.gxTpr_Br_pathologyid = A226BR_PathologyID;
         obj35.gxTpr_Br_pathology_other_bio = A289BR_Pathology_Other_Bio;
         obj35.gxTpr_Br_pathology_other_bio_code = A480BR_Pathology_Other_Bio_Code;
         obj35.gxTpr_Br_pathology_other_bionum = A290BR_Pathology_Other_BioNum;
         obj35.gxTpr_Br_pathology_other_bionum_code = A481BR_Pathology_Other_BioNum_Code;
         obj35.gxTpr_Br_pathology_other_bionumunit = A291BR_Pathology_Other_BioNumUnit;
         obj35.gxTpr_Br_pathology_other_bioqual = A292BR_Pathology_Other_BioQual;
         obj35.gxTpr_Br_pathology_other_bioqual_code = A482BR_Pathology_Other_BioQual_Code;
         obj35.gxTpr_Br_pathology_other_low = A293BR_Pathology_Other_Low;
         obj35.gxTpr_Br_pathology_other_high = A294BR_Pathology_Other_High;
         obj35.gxTpr_Br_pathology_other_abnind = A295BR_Pathology_Other_AbnInd;
         obj35.gxTpr_Br_pathology_otherid = A288BR_Pathology_OtherID;
         obj35.gxTpr_Br_pathology_otherid_Z = Z288BR_Pathology_OtherID;
         obj35.gxTpr_Br_pathologyid_Z = Z226BR_PathologyID;
         obj35.gxTpr_Br_pathology_other_bio_Z = Z289BR_Pathology_Other_Bio;
         obj35.gxTpr_Br_pathology_other_bio_code_Z = Z480BR_Pathology_Other_Bio_Code;
         obj35.gxTpr_Br_pathology_other_bionum_Z = Z290BR_Pathology_Other_BioNum;
         obj35.gxTpr_Br_pathology_other_bionum_code_Z = Z481BR_Pathology_Other_BioNum_Code;
         obj35.gxTpr_Br_pathology_other_bionumunit_Z = Z291BR_Pathology_Other_BioNumUnit;
         obj35.gxTpr_Br_pathology_other_bioqual_Z = Z292BR_Pathology_Other_BioQual;
         obj35.gxTpr_Br_pathology_other_bioqual_code_Z = Z482BR_Pathology_Other_BioQual_Code;
         obj35.gxTpr_Br_pathology_other_low_Z = Z293BR_Pathology_Other_Low;
         obj35.gxTpr_Br_pathology_other_high_Z = Z294BR_Pathology_Other_High;
         obj35.gxTpr_Br_pathology_other_abnind_Z = Z295BR_Pathology_Other_AbnInd;
         obj35.gxTpr_Br_pathology_other_abnind_code_Z = Z509BR_Pathology_Other_AbnInd_Code;
         obj35.gxTpr_Br_pathologyid_N = (short)(Convert.ToInt16(n226BR_PathologyID));
         obj35.gxTpr_Br_pathology_other_bio_N = (short)(Convert.ToInt16(n289BR_Pathology_Other_Bio));
         obj35.gxTpr_Br_pathology_other_bio_code_N = (short)(Convert.ToInt16(n480BR_Pathology_Other_Bio_Code));
         obj35.gxTpr_Br_pathology_other_bionum_N = (short)(Convert.ToInt16(n290BR_Pathology_Other_BioNum));
         obj35.gxTpr_Br_pathology_other_bionum_code_N = (short)(Convert.ToInt16(n481BR_Pathology_Other_BioNum_Code));
         obj35.gxTpr_Br_pathology_other_bionumunit_N = (short)(Convert.ToInt16(n291BR_Pathology_Other_BioNumUnit));
         obj35.gxTpr_Br_pathology_other_bioqual_N = (short)(Convert.ToInt16(n292BR_Pathology_Other_BioQual));
         obj35.gxTpr_Br_pathology_other_bioqual_code_N = (short)(Convert.ToInt16(n482BR_Pathology_Other_BioQual_Code));
         obj35.gxTpr_Br_pathology_other_low_N = (short)(Convert.ToInt16(n293BR_Pathology_Other_Low));
         obj35.gxTpr_Br_pathology_other_high_N = (short)(Convert.ToInt16(n294BR_Pathology_Other_High));
         obj35.gxTpr_Br_pathology_other_abnind_N = (short)(Convert.ToInt16(n295BR_Pathology_Other_AbnInd));
         obj35.gxTpr_Br_pathology_other_abnind_code_N = (short)(Convert.ToInt16(n509BR_Pathology_Other_AbnInd_Code));
         obj35.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow35( SdtBR_Pathology_Other obj35 )
      {
         obj35.gxTpr_Br_pathology_otherid = A288BR_Pathology_OtherID;
         return  ;
      }

      public void RowToVars35( SdtBR_Pathology_Other obj35 ,
                               int forceLoad )
      {
         Gx_mode = obj35.gxTpr_Mode;
         A509BR_Pathology_Other_AbnInd_Code = obj35.gxTpr_Br_pathology_other_abnind_code;
         n509BR_Pathology_Other_AbnInd_Code = false;
         A226BR_PathologyID = obj35.gxTpr_Br_pathologyid;
         n226BR_PathologyID = false;
         A289BR_Pathology_Other_Bio = obj35.gxTpr_Br_pathology_other_bio;
         n289BR_Pathology_Other_Bio = false;
         A480BR_Pathology_Other_Bio_Code = obj35.gxTpr_Br_pathology_other_bio_code;
         n480BR_Pathology_Other_Bio_Code = false;
         A290BR_Pathology_Other_BioNum = obj35.gxTpr_Br_pathology_other_bionum;
         n290BR_Pathology_Other_BioNum = false;
         A481BR_Pathology_Other_BioNum_Code = obj35.gxTpr_Br_pathology_other_bionum_code;
         n481BR_Pathology_Other_BioNum_Code = false;
         A291BR_Pathology_Other_BioNumUnit = obj35.gxTpr_Br_pathology_other_bionumunit;
         n291BR_Pathology_Other_BioNumUnit = false;
         A292BR_Pathology_Other_BioQual = obj35.gxTpr_Br_pathology_other_bioqual;
         n292BR_Pathology_Other_BioQual = false;
         A482BR_Pathology_Other_BioQual_Code = obj35.gxTpr_Br_pathology_other_bioqual_code;
         n482BR_Pathology_Other_BioQual_Code = false;
         A293BR_Pathology_Other_Low = obj35.gxTpr_Br_pathology_other_low;
         n293BR_Pathology_Other_Low = false;
         A294BR_Pathology_Other_High = obj35.gxTpr_Br_pathology_other_high;
         n294BR_Pathology_Other_High = false;
         A295BR_Pathology_Other_AbnInd = obj35.gxTpr_Br_pathology_other_abnind;
         n295BR_Pathology_Other_AbnInd = false;
         A288BR_Pathology_OtherID = obj35.gxTpr_Br_pathology_otherid;
         Z288BR_Pathology_OtherID = obj35.gxTpr_Br_pathology_otherid_Z;
         Z226BR_PathologyID = obj35.gxTpr_Br_pathologyid_Z;
         Z289BR_Pathology_Other_Bio = obj35.gxTpr_Br_pathology_other_bio_Z;
         Z480BR_Pathology_Other_Bio_Code = obj35.gxTpr_Br_pathology_other_bio_code_Z;
         Z290BR_Pathology_Other_BioNum = obj35.gxTpr_Br_pathology_other_bionum_Z;
         Z481BR_Pathology_Other_BioNum_Code = obj35.gxTpr_Br_pathology_other_bionum_code_Z;
         Z291BR_Pathology_Other_BioNumUnit = obj35.gxTpr_Br_pathology_other_bionumunit_Z;
         Z292BR_Pathology_Other_BioQual = obj35.gxTpr_Br_pathology_other_bioqual_Z;
         Z482BR_Pathology_Other_BioQual_Code = obj35.gxTpr_Br_pathology_other_bioqual_code_Z;
         Z293BR_Pathology_Other_Low = obj35.gxTpr_Br_pathology_other_low_Z;
         Z294BR_Pathology_Other_High = obj35.gxTpr_Br_pathology_other_high_Z;
         Z295BR_Pathology_Other_AbnInd = obj35.gxTpr_Br_pathology_other_abnind_Z;
         Z509BR_Pathology_Other_AbnInd_Code = obj35.gxTpr_Br_pathology_other_abnind_code_Z;
         n226BR_PathologyID = (bool)(Convert.ToBoolean(obj35.gxTpr_Br_pathologyid_N));
         n289BR_Pathology_Other_Bio = (bool)(Convert.ToBoolean(obj35.gxTpr_Br_pathology_other_bio_N));
         n480BR_Pathology_Other_Bio_Code = (bool)(Convert.ToBoolean(obj35.gxTpr_Br_pathology_other_bio_code_N));
         n290BR_Pathology_Other_BioNum = (bool)(Convert.ToBoolean(obj35.gxTpr_Br_pathology_other_bionum_N));
         n481BR_Pathology_Other_BioNum_Code = (bool)(Convert.ToBoolean(obj35.gxTpr_Br_pathology_other_bionum_code_N));
         n291BR_Pathology_Other_BioNumUnit = (bool)(Convert.ToBoolean(obj35.gxTpr_Br_pathology_other_bionumunit_N));
         n292BR_Pathology_Other_BioQual = (bool)(Convert.ToBoolean(obj35.gxTpr_Br_pathology_other_bioqual_N));
         n482BR_Pathology_Other_BioQual_Code = (bool)(Convert.ToBoolean(obj35.gxTpr_Br_pathology_other_bioqual_code_N));
         n293BR_Pathology_Other_Low = (bool)(Convert.ToBoolean(obj35.gxTpr_Br_pathology_other_low_N));
         n294BR_Pathology_Other_High = (bool)(Convert.ToBoolean(obj35.gxTpr_Br_pathology_other_high_N));
         n295BR_Pathology_Other_AbnInd = (bool)(Convert.ToBoolean(obj35.gxTpr_Br_pathology_other_abnind_N));
         n509BR_Pathology_Other_AbnInd_Code = (bool)(Convert.ToBoolean(obj35.gxTpr_Br_pathology_other_abnind_code_N));
         Gx_mode = obj35.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A288BR_Pathology_OtherID = (long)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey0Y35( ) ;
         ScanKeyStart0Y35( ) ;
         if ( RcdFound35 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z288BR_Pathology_OtherID = A288BR_Pathology_OtherID;
         }
         ZM0Y35( -10) ;
         OnLoadActions0Y35( ) ;
         AddRow0Y35( ) ;
         ScanKeyEnd0Y35( ) ;
         if ( RcdFound35 == 0 )
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
         RowToVars35( bcBR_Pathology_Other, 0) ;
         ScanKeyStart0Y35( ) ;
         if ( RcdFound35 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z288BR_Pathology_OtherID = A288BR_Pathology_OtherID;
         }
         ZM0Y35( -10) ;
         OnLoadActions0Y35( ) ;
         AddRow0Y35( ) ;
         ScanKeyEnd0Y35( ) ;
         if ( RcdFound35 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey0Y35( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert0Y35( ) ;
         }
         else
         {
            if ( RcdFound35 == 1 )
            {
               if ( A288BR_Pathology_OtherID != Z288BR_Pathology_OtherID )
               {
                  A288BR_Pathology_OtherID = Z288BR_Pathology_OtherID;
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
                  Update0Y35( ) ;
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
                  if ( A288BR_Pathology_OtherID != Z288BR_Pathology_OtherID )
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
                        Insert0Y35( ) ;
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
                        Insert0Y35( ) ;
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
         RowToVars35( bcBR_Pathology_Other, 0) ;
         SaveImpl( ) ;
         VarsToRow35( bcBR_Pathology_Other) ;
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
         RowToVars35( bcBR_Pathology_Other, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert0Y35( ) ;
         AfterTrn( ) ;
         VarsToRow35( bcBR_Pathology_Other) ;
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
            SdtBR_Pathology_Other auxBC = new SdtBR_Pathology_Other(context) ;
            auxBC.Load(A288BR_Pathology_OtherID);
            auxBC.UpdateDirties(bcBR_Pathology_Other);
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
         RowToVars35( bcBR_Pathology_Other, 0) ;
         UpdateImpl( ) ;
         VarsToRow35( bcBR_Pathology_Other) ;
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
         RowToVars35( bcBR_Pathology_Other, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert0Y35( ) ;
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
         VarsToRow35( bcBR_Pathology_Other) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars35( bcBR_Pathology_Other, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey0Y35( ) ;
         if ( RcdFound35 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A288BR_Pathology_OtherID != Z288BR_Pathology_OtherID )
            {
               A288BR_Pathology_OtherID = Z288BR_Pathology_OtherID;
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
            if ( A288BR_Pathology_OtherID != Z288BR_Pathology_OtherID )
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
         context.RollbackDataStores("br_pathology_other_bc",pr_default);
         VarsToRow35( bcBR_Pathology_Other) ;
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
         Gx_mode = bcBR_Pathology_Other.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcBR_Pathology_Other.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcBR_Pathology_Other )
         {
            bcBR_Pathology_Other = (SdtBR_Pathology_Other)(sdt);
            if ( StringUtil.StrCmp(bcBR_Pathology_Other.gxTpr_Mode, "") == 0 )
            {
               bcBR_Pathology_Other.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow35( bcBR_Pathology_Other) ;
            }
            else
            {
               RowToVars35( bcBR_Pathology_Other, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcBR_Pathology_Other.gxTpr_Mode, "") == 0 )
            {
               bcBR_Pathology_Other.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars35( bcBR_Pathology_Other, 1) ;
         return  ;
      }

      public SdtBR_Pathology_Other BR_Pathology_Other_BC
      {
         get {
            return bcBR_Pathology_Other ;
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
         AV20Pgmname = "";
         AV11TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV12WebSession = context.GetSession();
         AV14TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         Z509BR_Pathology_Other_AbnInd_Code = "";
         A509BR_Pathology_Other_AbnInd_Code = "";
         Z289BR_Pathology_Other_Bio = "";
         A289BR_Pathology_Other_Bio = "";
         Z480BR_Pathology_Other_Bio_Code = "";
         A480BR_Pathology_Other_Bio_Code = "";
         Z481BR_Pathology_Other_BioNum_Code = "";
         A481BR_Pathology_Other_BioNum_Code = "";
         Z291BR_Pathology_Other_BioNumUnit = "";
         A291BR_Pathology_Other_BioNumUnit = "";
         Z292BR_Pathology_Other_BioQual = "";
         A292BR_Pathology_Other_BioQual = "";
         Z482BR_Pathology_Other_BioQual_Code = "";
         A482BR_Pathology_Other_BioQual_Code = "";
         Z295BR_Pathology_Other_AbnInd = "";
         A295BR_Pathology_Other_AbnInd = "";
         BC000Y5_A288BR_Pathology_OtherID = new long[1] ;
         BC000Y5_A509BR_Pathology_Other_AbnInd_Code = new String[] {""} ;
         BC000Y5_n509BR_Pathology_Other_AbnInd_Code = new bool[] {false} ;
         BC000Y5_A289BR_Pathology_Other_Bio = new String[] {""} ;
         BC000Y5_n289BR_Pathology_Other_Bio = new bool[] {false} ;
         BC000Y5_A480BR_Pathology_Other_Bio_Code = new String[] {""} ;
         BC000Y5_n480BR_Pathology_Other_Bio_Code = new bool[] {false} ;
         BC000Y5_A290BR_Pathology_Other_BioNum = new decimal[1] ;
         BC000Y5_n290BR_Pathology_Other_BioNum = new bool[] {false} ;
         BC000Y5_A481BR_Pathology_Other_BioNum_Code = new String[] {""} ;
         BC000Y5_n481BR_Pathology_Other_BioNum_Code = new bool[] {false} ;
         BC000Y5_A291BR_Pathology_Other_BioNumUnit = new String[] {""} ;
         BC000Y5_n291BR_Pathology_Other_BioNumUnit = new bool[] {false} ;
         BC000Y5_A292BR_Pathology_Other_BioQual = new String[] {""} ;
         BC000Y5_n292BR_Pathology_Other_BioQual = new bool[] {false} ;
         BC000Y5_A482BR_Pathology_Other_BioQual_Code = new String[] {""} ;
         BC000Y5_n482BR_Pathology_Other_BioQual_Code = new bool[] {false} ;
         BC000Y5_A293BR_Pathology_Other_Low = new decimal[1] ;
         BC000Y5_n293BR_Pathology_Other_Low = new bool[] {false} ;
         BC000Y5_A294BR_Pathology_Other_High = new decimal[1] ;
         BC000Y5_n294BR_Pathology_Other_High = new bool[] {false} ;
         BC000Y5_A295BR_Pathology_Other_AbnInd = new String[] {""} ;
         BC000Y5_n295BR_Pathology_Other_AbnInd = new bool[] {false} ;
         BC000Y5_A226BR_PathologyID = new long[1] ;
         BC000Y5_n226BR_PathologyID = new bool[] {false} ;
         BC000Y4_A226BR_PathologyID = new long[1] ;
         BC000Y4_n226BR_PathologyID = new bool[] {false} ;
         BC000Y6_A288BR_Pathology_OtherID = new long[1] ;
         BC000Y3_A288BR_Pathology_OtherID = new long[1] ;
         BC000Y3_A509BR_Pathology_Other_AbnInd_Code = new String[] {""} ;
         BC000Y3_n509BR_Pathology_Other_AbnInd_Code = new bool[] {false} ;
         BC000Y3_A289BR_Pathology_Other_Bio = new String[] {""} ;
         BC000Y3_n289BR_Pathology_Other_Bio = new bool[] {false} ;
         BC000Y3_A480BR_Pathology_Other_Bio_Code = new String[] {""} ;
         BC000Y3_n480BR_Pathology_Other_Bio_Code = new bool[] {false} ;
         BC000Y3_A290BR_Pathology_Other_BioNum = new decimal[1] ;
         BC000Y3_n290BR_Pathology_Other_BioNum = new bool[] {false} ;
         BC000Y3_A481BR_Pathology_Other_BioNum_Code = new String[] {""} ;
         BC000Y3_n481BR_Pathology_Other_BioNum_Code = new bool[] {false} ;
         BC000Y3_A291BR_Pathology_Other_BioNumUnit = new String[] {""} ;
         BC000Y3_n291BR_Pathology_Other_BioNumUnit = new bool[] {false} ;
         BC000Y3_A292BR_Pathology_Other_BioQual = new String[] {""} ;
         BC000Y3_n292BR_Pathology_Other_BioQual = new bool[] {false} ;
         BC000Y3_A482BR_Pathology_Other_BioQual_Code = new String[] {""} ;
         BC000Y3_n482BR_Pathology_Other_BioQual_Code = new bool[] {false} ;
         BC000Y3_A293BR_Pathology_Other_Low = new decimal[1] ;
         BC000Y3_n293BR_Pathology_Other_Low = new bool[] {false} ;
         BC000Y3_A294BR_Pathology_Other_High = new decimal[1] ;
         BC000Y3_n294BR_Pathology_Other_High = new bool[] {false} ;
         BC000Y3_A295BR_Pathology_Other_AbnInd = new String[] {""} ;
         BC000Y3_n295BR_Pathology_Other_AbnInd = new bool[] {false} ;
         BC000Y3_A226BR_PathologyID = new long[1] ;
         BC000Y3_n226BR_PathologyID = new bool[] {false} ;
         sMode35 = "";
         BC000Y2_A288BR_Pathology_OtherID = new long[1] ;
         BC000Y2_A509BR_Pathology_Other_AbnInd_Code = new String[] {""} ;
         BC000Y2_n509BR_Pathology_Other_AbnInd_Code = new bool[] {false} ;
         BC000Y2_A289BR_Pathology_Other_Bio = new String[] {""} ;
         BC000Y2_n289BR_Pathology_Other_Bio = new bool[] {false} ;
         BC000Y2_A480BR_Pathology_Other_Bio_Code = new String[] {""} ;
         BC000Y2_n480BR_Pathology_Other_Bio_Code = new bool[] {false} ;
         BC000Y2_A290BR_Pathology_Other_BioNum = new decimal[1] ;
         BC000Y2_n290BR_Pathology_Other_BioNum = new bool[] {false} ;
         BC000Y2_A481BR_Pathology_Other_BioNum_Code = new String[] {""} ;
         BC000Y2_n481BR_Pathology_Other_BioNum_Code = new bool[] {false} ;
         BC000Y2_A291BR_Pathology_Other_BioNumUnit = new String[] {""} ;
         BC000Y2_n291BR_Pathology_Other_BioNumUnit = new bool[] {false} ;
         BC000Y2_A292BR_Pathology_Other_BioQual = new String[] {""} ;
         BC000Y2_n292BR_Pathology_Other_BioQual = new bool[] {false} ;
         BC000Y2_A482BR_Pathology_Other_BioQual_Code = new String[] {""} ;
         BC000Y2_n482BR_Pathology_Other_BioQual_Code = new bool[] {false} ;
         BC000Y2_A293BR_Pathology_Other_Low = new decimal[1] ;
         BC000Y2_n293BR_Pathology_Other_Low = new bool[] {false} ;
         BC000Y2_A294BR_Pathology_Other_High = new decimal[1] ;
         BC000Y2_n294BR_Pathology_Other_High = new bool[] {false} ;
         BC000Y2_A295BR_Pathology_Other_AbnInd = new String[] {""} ;
         BC000Y2_n295BR_Pathology_Other_AbnInd = new bool[] {false} ;
         BC000Y2_A226BR_PathologyID = new long[1] ;
         BC000Y2_n226BR_PathologyID = new bool[] {false} ;
         BC000Y7_A288BR_Pathology_OtherID = new long[1] ;
         BC000Y10_A288BR_Pathology_OtherID = new long[1] ;
         BC000Y10_A509BR_Pathology_Other_AbnInd_Code = new String[] {""} ;
         BC000Y10_n509BR_Pathology_Other_AbnInd_Code = new bool[] {false} ;
         BC000Y10_A289BR_Pathology_Other_Bio = new String[] {""} ;
         BC000Y10_n289BR_Pathology_Other_Bio = new bool[] {false} ;
         BC000Y10_A480BR_Pathology_Other_Bio_Code = new String[] {""} ;
         BC000Y10_n480BR_Pathology_Other_Bio_Code = new bool[] {false} ;
         BC000Y10_A290BR_Pathology_Other_BioNum = new decimal[1] ;
         BC000Y10_n290BR_Pathology_Other_BioNum = new bool[] {false} ;
         BC000Y10_A481BR_Pathology_Other_BioNum_Code = new String[] {""} ;
         BC000Y10_n481BR_Pathology_Other_BioNum_Code = new bool[] {false} ;
         BC000Y10_A291BR_Pathology_Other_BioNumUnit = new String[] {""} ;
         BC000Y10_n291BR_Pathology_Other_BioNumUnit = new bool[] {false} ;
         BC000Y10_A292BR_Pathology_Other_BioQual = new String[] {""} ;
         BC000Y10_n292BR_Pathology_Other_BioQual = new bool[] {false} ;
         BC000Y10_A482BR_Pathology_Other_BioQual_Code = new String[] {""} ;
         BC000Y10_n482BR_Pathology_Other_BioQual_Code = new bool[] {false} ;
         BC000Y10_A293BR_Pathology_Other_Low = new decimal[1] ;
         BC000Y10_n293BR_Pathology_Other_Low = new bool[] {false} ;
         BC000Y10_A294BR_Pathology_Other_High = new decimal[1] ;
         BC000Y10_n294BR_Pathology_Other_High = new bool[] {false} ;
         BC000Y10_A295BR_Pathology_Other_AbnInd = new String[] {""} ;
         BC000Y10_n295BR_Pathology_Other_AbnInd = new bool[] {false} ;
         BC000Y10_A226BR_PathologyID = new long[1] ;
         BC000Y10_n226BR_PathologyID = new bool[] {false} ;
         GXt_char2 = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_pathology_other_bc__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_pathology_other_bc__default(),
            new Object[][] {
                new Object[] {
               BC000Y2_A288BR_Pathology_OtherID, BC000Y2_A509BR_Pathology_Other_AbnInd_Code, BC000Y2_n509BR_Pathology_Other_AbnInd_Code, BC000Y2_A289BR_Pathology_Other_Bio, BC000Y2_n289BR_Pathology_Other_Bio, BC000Y2_A480BR_Pathology_Other_Bio_Code, BC000Y2_n480BR_Pathology_Other_Bio_Code, BC000Y2_A290BR_Pathology_Other_BioNum, BC000Y2_n290BR_Pathology_Other_BioNum, BC000Y2_A481BR_Pathology_Other_BioNum_Code,
               BC000Y2_n481BR_Pathology_Other_BioNum_Code, BC000Y2_A291BR_Pathology_Other_BioNumUnit, BC000Y2_n291BR_Pathology_Other_BioNumUnit, BC000Y2_A292BR_Pathology_Other_BioQual, BC000Y2_n292BR_Pathology_Other_BioQual, BC000Y2_A482BR_Pathology_Other_BioQual_Code, BC000Y2_n482BR_Pathology_Other_BioQual_Code, BC000Y2_A293BR_Pathology_Other_Low, BC000Y2_n293BR_Pathology_Other_Low, BC000Y2_A294BR_Pathology_Other_High,
               BC000Y2_n294BR_Pathology_Other_High, BC000Y2_A295BR_Pathology_Other_AbnInd, BC000Y2_n295BR_Pathology_Other_AbnInd, BC000Y2_A226BR_PathologyID, BC000Y2_n226BR_PathologyID
               }
               , new Object[] {
               BC000Y3_A288BR_Pathology_OtherID, BC000Y3_A509BR_Pathology_Other_AbnInd_Code, BC000Y3_n509BR_Pathology_Other_AbnInd_Code, BC000Y3_A289BR_Pathology_Other_Bio, BC000Y3_n289BR_Pathology_Other_Bio, BC000Y3_A480BR_Pathology_Other_Bio_Code, BC000Y3_n480BR_Pathology_Other_Bio_Code, BC000Y3_A290BR_Pathology_Other_BioNum, BC000Y3_n290BR_Pathology_Other_BioNum, BC000Y3_A481BR_Pathology_Other_BioNum_Code,
               BC000Y3_n481BR_Pathology_Other_BioNum_Code, BC000Y3_A291BR_Pathology_Other_BioNumUnit, BC000Y3_n291BR_Pathology_Other_BioNumUnit, BC000Y3_A292BR_Pathology_Other_BioQual, BC000Y3_n292BR_Pathology_Other_BioQual, BC000Y3_A482BR_Pathology_Other_BioQual_Code, BC000Y3_n482BR_Pathology_Other_BioQual_Code, BC000Y3_A293BR_Pathology_Other_Low, BC000Y3_n293BR_Pathology_Other_Low, BC000Y3_A294BR_Pathology_Other_High,
               BC000Y3_n294BR_Pathology_Other_High, BC000Y3_A295BR_Pathology_Other_AbnInd, BC000Y3_n295BR_Pathology_Other_AbnInd, BC000Y3_A226BR_PathologyID, BC000Y3_n226BR_PathologyID
               }
               , new Object[] {
               BC000Y4_A226BR_PathologyID
               }
               , new Object[] {
               BC000Y5_A288BR_Pathology_OtherID, BC000Y5_A509BR_Pathology_Other_AbnInd_Code, BC000Y5_n509BR_Pathology_Other_AbnInd_Code, BC000Y5_A289BR_Pathology_Other_Bio, BC000Y5_n289BR_Pathology_Other_Bio, BC000Y5_A480BR_Pathology_Other_Bio_Code, BC000Y5_n480BR_Pathology_Other_Bio_Code, BC000Y5_A290BR_Pathology_Other_BioNum, BC000Y5_n290BR_Pathology_Other_BioNum, BC000Y5_A481BR_Pathology_Other_BioNum_Code,
               BC000Y5_n481BR_Pathology_Other_BioNum_Code, BC000Y5_A291BR_Pathology_Other_BioNumUnit, BC000Y5_n291BR_Pathology_Other_BioNumUnit, BC000Y5_A292BR_Pathology_Other_BioQual, BC000Y5_n292BR_Pathology_Other_BioQual, BC000Y5_A482BR_Pathology_Other_BioQual_Code, BC000Y5_n482BR_Pathology_Other_BioQual_Code, BC000Y5_A293BR_Pathology_Other_Low, BC000Y5_n293BR_Pathology_Other_Low, BC000Y5_A294BR_Pathology_Other_High,
               BC000Y5_n294BR_Pathology_Other_High, BC000Y5_A295BR_Pathology_Other_AbnInd, BC000Y5_n295BR_Pathology_Other_AbnInd, BC000Y5_A226BR_PathologyID, BC000Y5_n226BR_PathologyID
               }
               , new Object[] {
               BC000Y6_A288BR_Pathology_OtherID
               }
               , new Object[] {
               BC000Y7_A288BR_Pathology_OtherID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000Y10_A288BR_Pathology_OtherID, BC000Y10_A509BR_Pathology_Other_AbnInd_Code, BC000Y10_n509BR_Pathology_Other_AbnInd_Code, BC000Y10_A289BR_Pathology_Other_Bio, BC000Y10_n289BR_Pathology_Other_Bio, BC000Y10_A480BR_Pathology_Other_Bio_Code, BC000Y10_n480BR_Pathology_Other_Bio_Code, BC000Y10_A290BR_Pathology_Other_BioNum, BC000Y10_n290BR_Pathology_Other_BioNum, BC000Y10_A481BR_Pathology_Other_BioNum_Code,
               BC000Y10_n481BR_Pathology_Other_BioNum_Code, BC000Y10_A291BR_Pathology_Other_BioNumUnit, BC000Y10_n291BR_Pathology_Other_BioNumUnit, BC000Y10_A292BR_Pathology_Other_BioQual, BC000Y10_n292BR_Pathology_Other_BioQual, BC000Y10_A482BR_Pathology_Other_BioQual_Code, BC000Y10_n482BR_Pathology_Other_BioQual_Code, BC000Y10_A293BR_Pathology_Other_Low, BC000Y10_n293BR_Pathology_Other_Low, BC000Y10_A294BR_Pathology_Other_High,
               BC000Y10_n294BR_Pathology_Other_High, BC000Y10_A295BR_Pathology_Other_AbnInd, BC000Y10_n295BR_Pathology_Other_AbnInd, BC000Y10_A226BR_PathologyID, BC000Y10_n226BR_PathologyID
               }
            }
         );
         AV20Pgmname = "BR_Pathology_Other_BC";
         INITTRN();
         /* Execute Start event if defined. */
         /* Execute user event: Start */
         E120Y2 ();
         standaloneNotModal( ) ;
      }

      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short GX_JID ;
      private short RcdFound35 ;
      private int trnEnded ;
      private int AV21GXV1 ;
      private long Z288BR_Pathology_OtherID ;
      private long A288BR_Pathology_OtherID ;
      private long AV13Insert_BR_PathologyID ;
      private long Z226BR_PathologyID ;
      private long A226BR_PathologyID ;
      private decimal Z290BR_Pathology_Other_BioNum ;
      private decimal A290BR_Pathology_Other_BioNum ;
      private decimal Z293BR_Pathology_Other_Low ;
      private decimal A293BR_Pathology_Other_Low ;
      private decimal Z294BR_Pathology_Other_High ;
      private decimal A294BR_Pathology_Other_High ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String AV20Pgmname ;
      private String sMode35 ;
      private String GXt_char2 ;
      private bool AV9IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool returnInSub ;
      private bool n509BR_Pathology_Other_AbnInd_Code ;
      private bool n289BR_Pathology_Other_Bio ;
      private bool n480BR_Pathology_Other_Bio_Code ;
      private bool n290BR_Pathology_Other_BioNum ;
      private bool n481BR_Pathology_Other_BioNum_Code ;
      private bool n291BR_Pathology_Other_BioNumUnit ;
      private bool n292BR_Pathology_Other_BioQual ;
      private bool n482BR_Pathology_Other_BioQual_Code ;
      private bool n293BR_Pathology_Other_Low ;
      private bool n294BR_Pathology_Other_High ;
      private bool n295BR_Pathology_Other_AbnInd ;
      private bool n226BR_PathologyID ;
      private bool Gx_longc ;
      private String Z509BR_Pathology_Other_AbnInd_Code ;
      private String A509BR_Pathology_Other_AbnInd_Code ;
      private String Z289BR_Pathology_Other_Bio ;
      private String A289BR_Pathology_Other_Bio ;
      private String Z480BR_Pathology_Other_Bio_Code ;
      private String A480BR_Pathology_Other_Bio_Code ;
      private String Z481BR_Pathology_Other_BioNum_Code ;
      private String A481BR_Pathology_Other_BioNum_Code ;
      private String Z291BR_Pathology_Other_BioNumUnit ;
      private String A291BR_Pathology_Other_BioNumUnit ;
      private String Z292BR_Pathology_Other_BioQual ;
      private String A292BR_Pathology_Other_BioQual ;
      private String Z482BR_Pathology_Other_BioQual_Code ;
      private String A482BR_Pathology_Other_BioQual_Code ;
      private String Z295BR_Pathology_Other_AbnInd ;
      private String A295BR_Pathology_Other_AbnInd ;
      private IGxSession AV12WebSession ;
      private SdtBR_Pathology_Other bcBR_Pathology_Other ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] BC000Y5_A288BR_Pathology_OtherID ;
      private String[] BC000Y5_A509BR_Pathology_Other_AbnInd_Code ;
      private bool[] BC000Y5_n509BR_Pathology_Other_AbnInd_Code ;
      private String[] BC000Y5_A289BR_Pathology_Other_Bio ;
      private bool[] BC000Y5_n289BR_Pathology_Other_Bio ;
      private String[] BC000Y5_A480BR_Pathology_Other_Bio_Code ;
      private bool[] BC000Y5_n480BR_Pathology_Other_Bio_Code ;
      private decimal[] BC000Y5_A290BR_Pathology_Other_BioNum ;
      private bool[] BC000Y5_n290BR_Pathology_Other_BioNum ;
      private String[] BC000Y5_A481BR_Pathology_Other_BioNum_Code ;
      private bool[] BC000Y5_n481BR_Pathology_Other_BioNum_Code ;
      private String[] BC000Y5_A291BR_Pathology_Other_BioNumUnit ;
      private bool[] BC000Y5_n291BR_Pathology_Other_BioNumUnit ;
      private String[] BC000Y5_A292BR_Pathology_Other_BioQual ;
      private bool[] BC000Y5_n292BR_Pathology_Other_BioQual ;
      private String[] BC000Y5_A482BR_Pathology_Other_BioQual_Code ;
      private bool[] BC000Y5_n482BR_Pathology_Other_BioQual_Code ;
      private decimal[] BC000Y5_A293BR_Pathology_Other_Low ;
      private bool[] BC000Y5_n293BR_Pathology_Other_Low ;
      private decimal[] BC000Y5_A294BR_Pathology_Other_High ;
      private bool[] BC000Y5_n294BR_Pathology_Other_High ;
      private String[] BC000Y5_A295BR_Pathology_Other_AbnInd ;
      private bool[] BC000Y5_n295BR_Pathology_Other_AbnInd ;
      private long[] BC000Y5_A226BR_PathologyID ;
      private bool[] BC000Y5_n226BR_PathologyID ;
      private long[] BC000Y4_A226BR_PathologyID ;
      private bool[] BC000Y4_n226BR_PathologyID ;
      private long[] BC000Y6_A288BR_Pathology_OtherID ;
      private long[] BC000Y3_A288BR_Pathology_OtherID ;
      private String[] BC000Y3_A509BR_Pathology_Other_AbnInd_Code ;
      private bool[] BC000Y3_n509BR_Pathology_Other_AbnInd_Code ;
      private String[] BC000Y3_A289BR_Pathology_Other_Bio ;
      private bool[] BC000Y3_n289BR_Pathology_Other_Bio ;
      private String[] BC000Y3_A480BR_Pathology_Other_Bio_Code ;
      private bool[] BC000Y3_n480BR_Pathology_Other_Bio_Code ;
      private decimal[] BC000Y3_A290BR_Pathology_Other_BioNum ;
      private bool[] BC000Y3_n290BR_Pathology_Other_BioNum ;
      private String[] BC000Y3_A481BR_Pathology_Other_BioNum_Code ;
      private bool[] BC000Y3_n481BR_Pathology_Other_BioNum_Code ;
      private String[] BC000Y3_A291BR_Pathology_Other_BioNumUnit ;
      private bool[] BC000Y3_n291BR_Pathology_Other_BioNumUnit ;
      private String[] BC000Y3_A292BR_Pathology_Other_BioQual ;
      private bool[] BC000Y3_n292BR_Pathology_Other_BioQual ;
      private String[] BC000Y3_A482BR_Pathology_Other_BioQual_Code ;
      private bool[] BC000Y3_n482BR_Pathology_Other_BioQual_Code ;
      private decimal[] BC000Y3_A293BR_Pathology_Other_Low ;
      private bool[] BC000Y3_n293BR_Pathology_Other_Low ;
      private decimal[] BC000Y3_A294BR_Pathology_Other_High ;
      private bool[] BC000Y3_n294BR_Pathology_Other_High ;
      private String[] BC000Y3_A295BR_Pathology_Other_AbnInd ;
      private bool[] BC000Y3_n295BR_Pathology_Other_AbnInd ;
      private long[] BC000Y3_A226BR_PathologyID ;
      private bool[] BC000Y3_n226BR_PathologyID ;
      private long[] BC000Y2_A288BR_Pathology_OtherID ;
      private String[] BC000Y2_A509BR_Pathology_Other_AbnInd_Code ;
      private bool[] BC000Y2_n509BR_Pathology_Other_AbnInd_Code ;
      private String[] BC000Y2_A289BR_Pathology_Other_Bio ;
      private bool[] BC000Y2_n289BR_Pathology_Other_Bio ;
      private String[] BC000Y2_A480BR_Pathology_Other_Bio_Code ;
      private bool[] BC000Y2_n480BR_Pathology_Other_Bio_Code ;
      private decimal[] BC000Y2_A290BR_Pathology_Other_BioNum ;
      private bool[] BC000Y2_n290BR_Pathology_Other_BioNum ;
      private String[] BC000Y2_A481BR_Pathology_Other_BioNum_Code ;
      private bool[] BC000Y2_n481BR_Pathology_Other_BioNum_Code ;
      private String[] BC000Y2_A291BR_Pathology_Other_BioNumUnit ;
      private bool[] BC000Y2_n291BR_Pathology_Other_BioNumUnit ;
      private String[] BC000Y2_A292BR_Pathology_Other_BioQual ;
      private bool[] BC000Y2_n292BR_Pathology_Other_BioQual ;
      private String[] BC000Y2_A482BR_Pathology_Other_BioQual_Code ;
      private bool[] BC000Y2_n482BR_Pathology_Other_BioQual_Code ;
      private decimal[] BC000Y2_A293BR_Pathology_Other_Low ;
      private bool[] BC000Y2_n293BR_Pathology_Other_Low ;
      private decimal[] BC000Y2_A294BR_Pathology_Other_High ;
      private bool[] BC000Y2_n294BR_Pathology_Other_High ;
      private String[] BC000Y2_A295BR_Pathology_Other_AbnInd ;
      private bool[] BC000Y2_n295BR_Pathology_Other_AbnInd ;
      private long[] BC000Y2_A226BR_PathologyID ;
      private bool[] BC000Y2_n226BR_PathologyID ;
      private long[] BC000Y7_A288BR_Pathology_OtherID ;
      private long[] BC000Y10_A288BR_Pathology_OtherID ;
      private String[] BC000Y10_A509BR_Pathology_Other_AbnInd_Code ;
      private bool[] BC000Y10_n509BR_Pathology_Other_AbnInd_Code ;
      private String[] BC000Y10_A289BR_Pathology_Other_Bio ;
      private bool[] BC000Y10_n289BR_Pathology_Other_Bio ;
      private String[] BC000Y10_A480BR_Pathology_Other_Bio_Code ;
      private bool[] BC000Y10_n480BR_Pathology_Other_Bio_Code ;
      private decimal[] BC000Y10_A290BR_Pathology_Other_BioNum ;
      private bool[] BC000Y10_n290BR_Pathology_Other_BioNum ;
      private String[] BC000Y10_A481BR_Pathology_Other_BioNum_Code ;
      private bool[] BC000Y10_n481BR_Pathology_Other_BioNum_Code ;
      private String[] BC000Y10_A291BR_Pathology_Other_BioNumUnit ;
      private bool[] BC000Y10_n291BR_Pathology_Other_BioNumUnit ;
      private String[] BC000Y10_A292BR_Pathology_Other_BioQual ;
      private bool[] BC000Y10_n292BR_Pathology_Other_BioQual ;
      private String[] BC000Y10_A482BR_Pathology_Other_BioQual_Code ;
      private bool[] BC000Y10_n482BR_Pathology_Other_BioQual_Code ;
      private decimal[] BC000Y10_A293BR_Pathology_Other_Low ;
      private bool[] BC000Y10_n293BR_Pathology_Other_Low ;
      private decimal[] BC000Y10_A294BR_Pathology_Other_High ;
      private bool[] BC000Y10_n294BR_Pathology_Other_High ;
      private String[] BC000Y10_A295BR_Pathology_Other_AbnInd ;
      private bool[] BC000Y10_n295BR_Pathology_Other_AbnInd ;
      private long[] BC000Y10_A226BR_PathologyID ;
      private bool[] BC000Y10_n226BR_PathologyID ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_datastore1 ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV8WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV11TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV14TrnContextAtt ;
   }

   public class br_pathology_other_bc__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class br_pathology_other_bc__default : DataStoreHelperBase, IDataStoreHelper
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
        Object[] prmBC000Y5 ;
        prmBC000Y5 = new Object[] {
        new Object[] {"@BR_Pathology_OtherID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000Y4 ;
        prmBC000Y4 = new Object[] {
        new Object[] {"@BR_PathologyID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000Y6 ;
        prmBC000Y6 = new Object[] {
        new Object[] {"@BR_Pathology_OtherID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000Y3 ;
        prmBC000Y3 = new Object[] {
        new Object[] {"@BR_Pathology_OtherID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000Y2 ;
        prmBC000Y2 = new Object[] {
        new Object[] {"@BR_Pathology_OtherID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000Y7 ;
        prmBC000Y7 = new Object[] {
        new Object[] {"@BR_Pathology_Other_AbnInd_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Pathology_Other_Bio",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Pathology_Other_Bio_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Pathology_Other_BioNum",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_Pathology_Other_BioNum_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Pathology_Other_BioNumUnit",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Pathology_Other_BioQual",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Pathology_Other_BioQual_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Pathology_Other_Low",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_Pathology_Other_High",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_Pathology_Other_AbnInd",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_PathologyID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000Y8 ;
        prmBC000Y8 = new Object[] {
        new Object[] {"@BR_Pathology_Other_AbnInd_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Pathology_Other_Bio",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Pathology_Other_Bio_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Pathology_Other_BioNum",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_Pathology_Other_BioNum_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Pathology_Other_BioNumUnit",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Pathology_Other_BioQual",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Pathology_Other_BioQual_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Pathology_Other_Low",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_Pathology_Other_High",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_Pathology_Other_AbnInd",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_PathologyID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_Pathology_OtherID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000Y9 ;
        prmBC000Y9 = new Object[] {
        new Object[] {"@BR_Pathology_OtherID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000Y10 ;
        prmBC000Y10 = new Object[] {
        new Object[] {"@BR_Pathology_OtherID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("BC000Y2", "SELECT [BR_Pathology_OtherID], [BR_Pathology_Other_AbnInd_Code], [BR_Pathology_Other_Bio], [BR_Pathology_Other_Bio_Code], [BR_Pathology_Other_BioNum], [BR_Pathology_Other_BioNum_Code], [BR_Pathology_Other_BioNumUnit], [BR_Pathology_Other_BioQual], [BR_Pathology_Other_BioQual_Code], [BR_Pathology_Other_Low], [BR_Pathology_Other_High], [BR_Pathology_Other_AbnInd], [BR_PathologyID] FROM [BR_Pathology_Other] WITH (UPDLOCK) WHERE [BR_Pathology_OtherID] = @BR_Pathology_OtherID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000Y2,1,0,true,false )
           ,new CursorDef("BC000Y3", "SELECT [BR_Pathology_OtherID], [BR_Pathology_Other_AbnInd_Code], [BR_Pathology_Other_Bio], [BR_Pathology_Other_Bio_Code], [BR_Pathology_Other_BioNum], [BR_Pathology_Other_BioNum_Code], [BR_Pathology_Other_BioNumUnit], [BR_Pathology_Other_BioQual], [BR_Pathology_Other_BioQual_Code], [BR_Pathology_Other_Low], [BR_Pathology_Other_High], [BR_Pathology_Other_AbnInd], [BR_PathologyID] FROM [BR_Pathology_Other] WITH (NOLOCK) WHERE [BR_Pathology_OtherID] = @BR_Pathology_OtherID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000Y3,1,0,true,false )
           ,new CursorDef("BC000Y4", "SELECT [BR_PathologyID] FROM [BR_Pathology] WITH (NOLOCK) WHERE [BR_PathologyID] = @BR_PathologyID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000Y4,1,0,true,false )
           ,new CursorDef("BC000Y5", "SELECT TM1.[BR_Pathology_OtherID], TM1.[BR_Pathology_Other_AbnInd_Code], TM1.[BR_Pathology_Other_Bio], TM1.[BR_Pathology_Other_Bio_Code], TM1.[BR_Pathology_Other_BioNum], TM1.[BR_Pathology_Other_BioNum_Code], TM1.[BR_Pathology_Other_BioNumUnit], TM1.[BR_Pathology_Other_BioQual], TM1.[BR_Pathology_Other_BioQual_Code], TM1.[BR_Pathology_Other_Low], TM1.[BR_Pathology_Other_High], TM1.[BR_Pathology_Other_AbnInd], TM1.[BR_PathologyID] FROM [BR_Pathology_Other] TM1 WITH (NOLOCK) WHERE TM1.[BR_Pathology_OtherID] = @BR_Pathology_OtherID ORDER BY TM1.[BR_Pathology_OtherID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000Y5,100,0,true,false )
           ,new CursorDef("BC000Y6", "SELECT [BR_Pathology_OtherID] FROM [BR_Pathology_Other] WITH (NOLOCK) WHERE [BR_Pathology_OtherID] = @BR_Pathology_OtherID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000Y6,1,0,true,false )
           ,new CursorDef("BC000Y7", "INSERT INTO [BR_Pathology_Other]([BR_Pathology_Other_AbnInd_Code], [BR_Pathology_Other_Bio], [BR_Pathology_Other_Bio_Code], [BR_Pathology_Other_BioNum], [BR_Pathology_Other_BioNum_Code], [BR_Pathology_Other_BioNumUnit], [BR_Pathology_Other_BioQual], [BR_Pathology_Other_BioQual_Code], [BR_Pathology_Other_Low], [BR_Pathology_Other_High], [BR_Pathology_Other_AbnInd], [BR_PathologyID]) VALUES(@BR_Pathology_Other_AbnInd_Code, @BR_Pathology_Other_Bio, @BR_Pathology_Other_Bio_Code, @BR_Pathology_Other_BioNum, @BR_Pathology_Other_BioNum_Code, @BR_Pathology_Other_BioNumUnit, @BR_Pathology_Other_BioQual, @BR_Pathology_Other_BioQual_Code, @BR_Pathology_Other_Low, @BR_Pathology_Other_High, @BR_Pathology_Other_AbnInd, @BR_PathologyID); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmBC000Y7)
           ,new CursorDef("BC000Y8", "UPDATE [BR_Pathology_Other] SET [BR_Pathology_Other_AbnInd_Code]=@BR_Pathology_Other_AbnInd_Code, [BR_Pathology_Other_Bio]=@BR_Pathology_Other_Bio, [BR_Pathology_Other_Bio_Code]=@BR_Pathology_Other_Bio_Code, [BR_Pathology_Other_BioNum]=@BR_Pathology_Other_BioNum, [BR_Pathology_Other_BioNum_Code]=@BR_Pathology_Other_BioNum_Code, [BR_Pathology_Other_BioNumUnit]=@BR_Pathology_Other_BioNumUnit, [BR_Pathology_Other_BioQual]=@BR_Pathology_Other_BioQual, [BR_Pathology_Other_BioQual_Code]=@BR_Pathology_Other_BioQual_Code, [BR_Pathology_Other_Low]=@BR_Pathology_Other_Low, [BR_Pathology_Other_High]=@BR_Pathology_Other_High, [BR_Pathology_Other_AbnInd]=@BR_Pathology_Other_AbnInd, [BR_PathologyID]=@BR_PathologyID  WHERE [BR_Pathology_OtherID] = @BR_Pathology_OtherID", GxErrorMask.GX_NOMASK,prmBC000Y8)
           ,new CursorDef("BC000Y9", "DELETE FROM [BR_Pathology_Other]  WHERE [BR_Pathology_OtherID] = @BR_Pathology_OtherID", GxErrorMask.GX_NOMASK,prmBC000Y9)
           ,new CursorDef("BC000Y10", "SELECT TM1.[BR_Pathology_OtherID], TM1.[BR_Pathology_Other_AbnInd_Code], TM1.[BR_Pathology_Other_Bio], TM1.[BR_Pathology_Other_Bio_Code], TM1.[BR_Pathology_Other_BioNum], TM1.[BR_Pathology_Other_BioNum_Code], TM1.[BR_Pathology_Other_BioNumUnit], TM1.[BR_Pathology_Other_BioQual], TM1.[BR_Pathology_Other_BioQual_Code], TM1.[BR_Pathology_Other_Low], TM1.[BR_Pathology_Other_High], TM1.[BR_Pathology_Other_AbnInd], TM1.[BR_PathologyID] FROM [BR_Pathology_Other] TM1 WITH (NOLOCK) WHERE TM1.[BR_Pathology_OtherID] = @BR_Pathology_OtherID ORDER BY TM1.[BR_Pathology_OtherID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000Y10,100,0,true,false )
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
              ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((decimal[]) buf[17])[0] = rslt.getDecimal(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              ((decimal[]) buf[19])[0] = rslt.getDecimal(11) ;
              ((bool[]) buf[20])[0] = rslt.wasNull(11);
              ((String[]) buf[21])[0] = rslt.getVarchar(12) ;
              ((bool[]) buf[22])[0] = rslt.wasNull(12);
              ((long[]) buf[23])[0] = rslt.getLong(13) ;
              ((bool[]) buf[24])[0] = rslt.wasNull(13);
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
              ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((decimal[]) buf[17])[0] = rslt.getDecimal(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              ((decimal[]) buf[19])[0] = rslt.getDecimal(11) ;
              ((bool[]) buf[20])[0] = rslt.wasNull(11);
              ((String[]) buf[21])[0] = rslt.getVarchar(12) ;
              ((bool[]) buf[22])[0] = rslt.wasNull(12);
              ((long[]) buf[23])[0] = rslt.getLong(13) ;
              ((bool[]) buf[24])[0] = rslt.wasNull(13);
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
              ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((decimal[]) buf[17])[0] = rslt.getDecimal(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              ((decimal[]) buf[19])[0] = rslt.getDecimal(11) ;
              ((bool[]) buf[20])[0] = rslt.wasNull(11);
              ((String[]) buf[21])[0] = rslt.getVarchar(12) ;
              ((bool[]) buf[22])[0] = rslt.wasNull(12);
              ((long[]) buf[23])[0] = rslt.getLong(13) ;
              ((bool[]) buf[24])[0] = rslt.wasNull(13);
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
              ((decimal[]) buf[7])[0] = rslt.getDecimal(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((decimal[]) buf[17])[0] = rslt.getDecimal(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              ((decimal[]) buf[19])[0] = rslt.getDecimal(11) ;
              ((bool[]) buf[20])[0] = rslt.wasNull(11);
              ((String[]) buf[21])[0] = rslt.getVarchar(12) ;
              ((bool[]) buf[22])[0] = rslt.wasNull(12);
              ((long[]) buf[23])[0] = rslt.getLong(13) ;
              ((bool[]) buf[24])[0] = rslt.wasNull(13);
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
                 stmt.setNull( 7 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(7, (String)parms[13]);
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
                 stmt.SetParameter(9, (decimal)parms[17]);
              }
              if ( (bool)parms[18] )
              {
                 stmt.setNull( 10 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(10, (decimal)parms[19]);
              }
              if ( (bool)parms[20] )
              {
                 stmt.setNull( 11 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(11, (String)parms[21]);
              }
              if ( (bool)parms[22] )
              {
                 stmt.setNull( 12 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(12, (long)parms[23]);
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
                 stmt.setNull( 7 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(7, (String)parms[13]);
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
                 stmt.SetParameter(9, (decimal)parms[17]);
              }
              if ( (bool)parms[18] )
              {
                 stmt.setNull( 10 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(10, (decimal)parms[19]);
              }
              if ( (bool)parms[20] )
              {
                 stmt.setNull( 11 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(11, (String)parms[21]);
              }
              if ( (bool)parms[22] )
              {
                 stmt.setNull( 12 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(12, (long)parms[23]);
              }
              stmt.SetParameter(13, (long)parms[24]);
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
