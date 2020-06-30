/*
               File: BR_Procedure_Radio_BC
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:8:35.30
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
   public class br_procedure_radio_bc : GXHttpHandler, IGxSilentTrn
   {
      public br_procedure_radio_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_procedure_radio_bc( IGxContext context )
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
         ReadRow1138( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey1138( ) ;
         standaloneModal( ) ;
         AddRow1138( ) ;
         Gx_mode = "INS";
         return  ;
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E11112 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               Z323BR_Procedure_RadioID = A323BR_Procedure_RadioID;
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

      protected void CONFIRM_110( )
      {
         BeforeValidate1138( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls1138( ) ;
            }
            else
            {
               CheckExtendedTable1138( ) ;
               if ( AnyError == 0 )
               {
                  ZM1138( 8) ;
               }
               CloseExtendedTableCursors1138( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void E12112( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV8WWPContext) ;
         AV9IsAuthorized = true;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_Procedure_Radio", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_Procedure_Radio", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_Procedure_Radio", out  GXt_boolean1) ;
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
               if ( StringUtil.StrCmp(AV14TrnContextAtt.gxTpr_Attributename, "BR_ProcedureID") == 0 )
               {
                  AV13Insert_BR_ProcedureID = (long)(NumberUtil.Val( AV14TrnContextAtt.gxTpr_Attributevalue, "."));
               }
               AV17GXV1 = (int)(AV17GXV1+1);
            }
         }
      }

      protected void E11112( )
      {
         /* After Trn Routine */
      }

      protected void ZM1138( short GX_JID )
      {
         if ( ( GX_JID == 7 ) || ( GX_JID == 0 ) )
         {
            Z324BR_Procedure_Radio_Loc = A324BR_Procedure_Radio_Loc;
            Z325BR_Procedure_Radio_Amount = A325BR_Procedure_Radio_Amount;
            Z139BR_ProcedureID = A139BR_ProcedureID;
         }
         if ( ( GX_JID == 8 ) || ( GX_JID == 0 ) )
         {
         }
         if ( GX_JID == -7 )
         {
            Z323BR_Procedure_RadioID = A323BR_Procedure_RadioID;
            Z324BR_Procedure_Radio_Loc = A324BR_Procedure_Radio_Loc;
            Z325BR_Procedure_Radio_Amount = A325BR_Procedure_Radio_Amount;
            Z139BR_ProcedureID = A139BR_ProcedureID;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load1138( )
      {
         /* Using cursor BC00115 */
         pr_default.execute(3, new Object[] {A323BR_Procedure_RadioID});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound38 = 1;
            A324BR_Procedure_Radio_Loc = BC00115_A324BR_Procedure_Radio_Loc[0];
            n324BR_Procedure_Radio_Loc = BC00115_n324BR_Procedure_Radio_Loc[0];
            A325BR_Procedure_Radio_Amount = BC00115_A325BR_Procedure_Radio_Amount[0];
            n325BR_Procedure_Radio_Amount = BC00115_n325BR_Procedure_Radio_Amount[0];
            A139BR_ProcedureID = BC00115_A139BR_ProcedureID[0];
            ZM1138( -7) ;
         }
         pr_default.close(3);
         OnLoadActions1138( ) ;
      }

      protected void OnLoadActions1138( )
      {
         AV16Pgmname = "BR_Procedure_Radio_BC";
      }

      protected void CheckExtendedTable1138( )
      {
         standaloneModal( ) ;
         AV16Pgmname = "BR_Procedure_Radio_BC";
         /* Using cursor BC00114 */
         pr_default.execute(2, new Object[] {A139BR_ProcedureID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("不匹配' T19'", "ForeignKeyNotFound", 1, "BR_PROCEDUREID");
            AnyError = 1;
         }
         pr_default.close(2);
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A324BR_Procedure_Radio_Loc)) )
         {
            GX_msglist.addItem("放疗部位是必须填写的。", 1, "");
            AnyError = 1;
         }
      }

      protected void CloseExtendedTableCursors1138( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey1138( )
      {
         /* Using cursor BC00116 */
         pr_default.execute(4, new Object[] {A323BR_Procedure_RadioID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound38 = 1;
         }
         else
         {
            RcdFound38 = 0;
         }
         pr_default.close(4);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC00113 */
         pr_default.execute(1, new Object[] {A323BR_Procedure_RadioID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM1138( 7) ;
            RcdFound38 = 1;
            A323BR_Procedure_RadioID = BC00113_A323BR_Procedure_RadioID[0];
            A324BR_Procedure_Radio_Loc = BC00113_A324BR_Procedure_Radio_Loc[0];
            n324BR_Procedure_Radio_Loc = BC00113_n324BR_Procedure_Radio_Loc[0];
            A325BR_Procedure_Radio_Amount = BC00113_A325BR_Procedure_Radio_Amount[0];
            n325BR_Procedure_Radio_Amount = BC00113_n325BR_Procedure_Radio_Amount[0];
            A139BR_ProcedureID = BC00113_A139BR_ProcedureID[0];
            Z323BR_Procedure_RadioID = A323BR_Procedure_RadioID;
            sMode38 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load1138( ) ;
            if ( AnyError == 1 )
            {
               RcdFound38 = 0;
               InitializeNonKey1138( ) ;
            }
            Gx_mode = sMode38;
         }
         else
         {
            RcdFound38 = 0;
            InitializeNonKey1138( ) ;
            sMode38 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode38;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1138( ) ;
         if ( RcdFound38 == 0 )
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
         CONFIRM_110( ) ;
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

      protected void CheckOptimisticConcurrency1138( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC00112 */
            pr_default.execute(0, new Object[] {A323BR_Procedure_RadioID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Procedure_Radio"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z324BR_Procedure_Radio_Loc, BC00112_A324BR_Procedure_Radio_Loc[0]) != 0 ) || ( StringUtil.StrCmp(Z325BR_Procedure_Radio_Amount, BC00112_A325BR_Procedure_Radio_Amount[0]) != 0 ) || ( Z139BR_ProcedureID != BC00112_A139BR_ProcedureID[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"BR_Procedure_Radio"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert1138( )
      {
         BeforeValidate1138( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1138( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1138( 0) ;
            CheckOptimisticConcurrency1138( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1138( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1138( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00117 */
                     pr_default.execute(5, new Object[] {n324BR_Procedure_Radio_Loc, A324BR_Procedure_Radio_Loc, n325BR_Procedure_Radio_Amount, A325BR_Procedure_Radio_Amount, A139BR_ProcedureID});
                     A323BR_Procedure_RadioID = BC00117_A323BR_Procedure_RadioID[0];
                     pr_default.close(5);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Procedure_Radio") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A139BR_ProcedureID), 18, 0)),  "诊疗处理",  StringUtil.Trim( StringUtil.Str( (decimal)(A323BR_Procedure_RadioID), 18, 0)),  "化疗信息",  "Create",  1) ;
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
               Load1138( ) ;
            }
            EndLevel1138( ) ;
         }
         CloseExtendedTableCursors1138( ) ;
      }

      protected void Update1138( )
      {
         BeforeValidate1138( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1138( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1138( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1138( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1138( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00118 */
                     pr_default.execute(6, new Object[] {n324BR_Procedure_Radio_Loc, A324BR_Procedure_Radio_Loc, n325BR_Procedure_Radio_Amount, A325BR_Procedure_Radio_Amount, A139BR_ProcedureID, A323BR_Procedure_RadioID});
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Procedure_Radio") ;
                     if ( (pr_default.getStatus(6) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Procedure_Radio"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate1138( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A139BR_ProcedureID), 18, 0)),  "诊疗处理",  StringUtil.Trim( StringUtil.Str( (decimal)(A323BR_Procedure_RadioID), 18, 0)),  "化疗信息",  "Update",  1) ;
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
            EndLevel1138( ) ;
         }
         CloseExtendedTableCursors1138( ) ;
      }

      protected void DeferredUpdate1138( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate1138( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1138( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1138( ) ;
            AfterConfirm1138( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1138( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC00119 */
                  pr_default.execute(7, new Object[] {A323BR_Procedure_RadioID});
                  pr_default.close(7);
                  dsDefault.SmartCacheProvider.SetUpdated("BR_Procedure_Radio") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A139BR_ProcedureID), 18, 0)),  "诊疗处理",  StringUtil.Trim( StringUtil.Str( (decimal)(A323BR_Procedure_RadioID), 18, 0)),  "化疗信息",  "Delete",  1) ;
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
         sMode38 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel1138( ) ;
         Gx_mode = sMode38;
      }

      protected void OnDeleteControls1138( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV16Pgmname = "BR_Procedure_Radio_BC";
         }
      }

      protected void EndLevel1138( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1138( ) ;
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

      public void ScanKeyStart1138( )
      {
         /* Scan By routine */
         /* Using cursor BC001110 */
         pr_default.execute(8, new Object[] {A323BR_Procedure_RadioID});
         RcdFound38 = 0;
         if ( (pr_default.getStatus(8) != 101) )
         {
            RcdFound38 = 1;
            A323BR_Procedure_RadioID = BC001110_A323BR_Procedure_RadioID[0];
            A324BR_Procedure_Radio_Loc = BC001110_A324BR_Procedure_Radio_Loc[0];
            n324BR_Procedure_Radio_Loc = BC001110_n324BR_Procedure_Radio_Loc[0];
            A325BR_Procedure_Radio_Amount = BC001110_A325BR_Procedure_Radio_Amount[0];
            n325BR_Procedure_Radio_Amount = BC001110_n325BR_Procedure_Radio_Amount[0];
            A139BR_ProcedureID = BC001110_A139BR_ProcedureID[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext1138( )
      {
         /* Scan next routine */
         pr_default.readNext(8);
         RcdFound38 = 0;
         ScanKeyLoad1138( ) ;
      }

      protected void ScanKeyLoad1138( )
      {
         sMode38 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(8) != 101) )
         {
            RcdFound38 = 1;
            A323BR_Procedure_RadioID = BC001110_A323BR_Procedure_RadioID[0];
            A324BR_Procedure_Radio_Loc = BC001110_A324BR_Procedure_Radio_Loc[0];
            n324BR_Procedure_Radio_Loc = BC001110_n324BR_Procedure_Radio_Loc[0];
            A325BR_Procedure_Radio_Amount = BC001110_A325BR_Procedure_Radio_Amount[0];
            n325BR_Procedure_Radio_Amount = BC001110_n325BR_Procedure_Radio_Amount[0];
            A139BR_ProcedureID = BC001110_A139BR_ProcedureID[0];
         }
         Gx_mode = sMode38;
      }

      protected void ScanKeyEnd1138( )
      {
         pr_default.close(8);
      }

      protected void AfterConfirm1138( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1138( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1138( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1138( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1138( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1138( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1138( )
      {
      }

      protected void send_integrity_lvl_hashes1138( )
      {
      }

      protected void AddRow1138( )
      {
         VarsToRow38( bcBR_Procedure_Radio) ;
      }

      protected void ReadRow1138( )
      {
         RowToVars38( bcBR_Procedure_Radio, 1) ;
      }

      protected void InitializeNonKey1138( )
      {
         A139BR_ProcedureID = 0;
         A324BR_Procedure_Radio_Loc = "";
         n324BR_Procedure_Radio_Loc = false;
         A325BR_Procedure_Radio_Amount = "";
         n325BR_Procedure_Radio_Amount = false;
         Z324BR_Procedure_Radio_Loc = "";
         Z325BR_Procedure_Radio_Amount = "";
         Z139BR_ProcedureID = 0;
      }

      protected void InitAll1138( )
      {
         A323BR_Procedure_RadioID = 0;
         InitializeNonKey1138( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow38( SdtBR_Procedure_Radio obj38 )
      {
         obj38.gxTpr_Mode = Gx_mode;
         obj38.gxTpr_Br_procedureid = A139BR_ProcedureID;
         obj38.gxTpr_Br_procedure_radio_loc = A324BR_Procedure_Radio_Loc;
         obj38.gxTpr_Br_procedure_radio_amount = A325BR_Procedure_Radio_Amount;
         obj38.gxTpr_Br_procedure_radioid = A323BR_Procedure_RadioID;
         obj38.gxTpr_Br_procedure_radioid_Z = Z323BR_Procedure_RadioID;
         obj38.gxTpr_Br_procedureid_Z = Z139BR_ProcedureID;
         obj38.gxTpr_Br_procedure_radio_loc_Z = Z324BR_Procedure_Radio_Loc;
         obj38.gxTpr_Br_procedure_radio_amount_Z = Z325BR_Procedure_Radio_Amount;
         obj38.gxTpr_Br_procedure_radio_loc_N = (short)(Convert.ToInt16(n324BR_Procedure_Radio_Loc));
         obj38.gxTpr_Br_procedure_radio_amount_N = (short)(Convert.ToInt16(n325BR_Procedure_Radio_Amount));
         obj38.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow38( SdtBR_Procedure_Radio obj38 )
      {
         obj38.gxTpr_Br_procedure_radioid = A323BR_Procedure_RadioID;
         return  ;
      }

      public void RowToVars38( SdtBR_Procedure_Radio obj38 ,
                               int forceLoad )
      {
         Gx_mode = obj38.gxTpr_Mode;
         A139BR_ProcedureID = obj38.gxTpr_Br_procedureid;
         A324BR_Procedure_Radio_Loc = obj38.gxTpr_Br_procedure_radio_loc;
         n324BR_Procedure_Radio_Loc = false;
         A325BR_Procedure_Radio_Amount = obj38.gxTpr_Br_procedure_radio_amount;
         n325BR_Procedure_Radio_Amount = false;
         A323BR_Procedure_RadioID = obj38.gxTpr_Br_procedure_radioid;
         Z323BR_Procedure_RadioID = obj38.gxTpr_Br_procedure_radioid_Z;
         Z139BR_ProcedureID = obj38.gxTpr_Br_procedureid_Z;
         Z324BR_Procedure_Radio_Loc = obj38.gxTpr_Br_procedure_radio_loc_Z;
         Z325BR_Procedure_Radio_Amount = obj38.gxTpr_Br_procedure_radio_amount_Z;
         n324BR_Procedure_Radio_Loc = (bool)(Convert.ToBoolean(obj38.gxTpr_Br_procedure_radio_loc_N));
         n325BR_Procedure_Radio_Amount = (bool)(Convert.ToBoolean(obj38.gxTpr_Br_procedure_radio_amount_N));
         Gx_mode = obj38.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A323BR_Procedure_RadioID = (long)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey1138( ) ;
         ScanKeyStart1138( ) ;
         if ( RcdFound38 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z323BR_Procedure_RadioID = A323BR_Procedure_RadioID;
         }
         ZM1138( -7) ;
         OnLoadActions1138( ) ;
         AddRow1138( ) ;
         ScanKeyEnd1138( ) ;
         if ( RcdFound38 == 0 )
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
         RowToVars38( bcBR_Procedure_Radio, 0) ;
         ScanKeyStart1138( ) ;
         if ( RcdFound38 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z323BR_Procedure_RadioID = A323BR_Procedure_RadioID;
         }
         ZM1138( -7) ;
         OnLoadActions1138( ) ;
         AddRow1138( ) ;
         ScanKeyEnd1138( ) ;
         if ( RcdFound38 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey1138( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert1138( ) ;
         }
         else
         {
            if ( RcdFound38 == 1 )
            {
               if ( A323BR_Procedure_RadioID != Z323BR_Procedure_RadioID )
               {
                  A323BR_Procedure_RadioID = Z323BR_Procedure_RadioID;
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
                  Update1138( ) ;
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
                  if ( A323BR_Procedure_RadioID != Z323BR_Procedure_RadioID )
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
                        Insert1138( ) ;
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
                        Insert1138( ) ;
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
         RowToVars38( bcBR_Procedure_Radio, 0) ;
         SaveImpl( ) ;
         VarsToRow38( bcBR_Procedure_Radio) ;
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
         RowToVars38( bcBR_Procedure_Radio, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert1138( ) ;
         AfterTrn( ) ;
         VarsToRow38( bcBR_Procedure_Radio) ;
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
            SdtBR_Procedure_Radio auxBC = new SdtBR_Procedure_Radio(context) ;
            auxBC.Load(A323BR_Procedure_RadioID);
            auxBC.UpdateDirties(bcBR_Procedure_Radio);
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
         RowToVars38( bcBR_Procedure_Radio, 0) ;
         UpdateImpl( ) ;
         VarsToRow38( bcBR_Procedure_Radio) ;
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
         RowToVars38( bcBR_Procedure_Radio, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert1138( ) ;
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
         VarsToRow38( bcBR_Procedure_Radio) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars38( bcBR_Procedure_Radio, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey1138( ) ;
         if ( RcdFound38 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A323BR_Procedure_RadioID != Z323BR_Procedure_RadioID )
            {
               A323BR_Procedure_RadioID = Z323BR_Procedure_RadioID;
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
            if ( A323BR_Procedure_RadioID != Z323BR_Procedure_RadioID )
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
         context.RollbackDataStores("br_procedure_radio_bc",pr_default);
         VarsToRow38( bcBR_Procedure_Radio) ;
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
         Gx_mode = bcBR_Procedure_Radio.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcBR_Procedure_Radio.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcBR_Procedure_Radio )
         {
            bcBR_Procedure_Radio = (SdtBR_Procedure_Radio)(sdt);
            if ( StringUtil.StrCmp(bcBR_Procedure_Radio.gxTpr_Mode, "") == 0 )
            {
               bcBR_Procedure_Radio.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow38( bcBR_Procedure_Radio) ;
            }
            else
            {
               RowToVars38( bcBR_Procedure_Radio, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcBR_Procedure_Radio.gxTpr_Mode, "") == 0 )
            {
               bcBR_Procedure_Radio.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars38( bcBR_Procedure_Radio, 1) ;
         return  ;
      }

      public SdtBR_Procedure_Radio BR_Procedure_Radio_BC
      {
         get {
            return bcBR_Procedure_Radio ;
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
         Z324BR_Procedure_Radio_Loc = "";
         A324BR_Procedure_Radio_Loc = "";
         Z325BR_Procedure_Radio_Amount = "";
         A325BR_Procedure_Radio_Amount = "";
         BC00115_A323BR_Procedure_RadioID = new long[1] ;
         BC00115_A324BR_Procedure_Radio_Loc = new String[] {""} ;
         BC00115_n324BR_Procedure_Radio_Loc = new bool[] {false} ;
         BC00115_A325BR_Procedure_Radio_Amount = new String[] {""} ;
         BC00115_n325BR_Procedure_Radio_Amount = new bool[] {false} ;
         BC00115_A139BR_ProcedureID = new long[1] ;
         BC00114_A139BR_ProcedureID = new long[1] ;
         BC00116_A323BR_Procedure_RadioID = new long[1] ;
         BC00113_A323BR_Procedure_RadioID = new long[1] ;
         BC00113_A324BR_Procedure_Radio_Loc = new String[] {""} ;
         BC00113_n324BR_Procedure_Radio_Loc = new bool[] {false} ;
         BC00113_A325BR_Procedure_Radio_Amount = new String[] {""} ;
         BC00113_n325BR_Procedure_Radio_Amount = new bool[] {false} ;
         BC00113_A139BR_ProcedureID = new long[1] ;
         sMode38 = "";
         BC00112_A323BR_Procedure_RadioID = new long[1] ;
         BC00112_A324BR_Procedure_Radio_Loc = new String[] {""} ;
         BC00112_n324BR_Procedure_Radio_Loc = new bool[] {false} ;
         BC00112_A325BR_Procedure_Radio_Amount = new String[] {""} ;
         BC00112_n325BR_Procedure_Radio_Amount = new bool[] {false} ;
         BC00112_A139BR_ProcedureID = new long[1] ;
         BC00117_A323BR_Procedure_RadioID = new long[1] ;
         BC001110_A323BR_Procedure_RadioID = new long[1] ;
         BC001110_A324BR_Procedure_Radio_Loc = new String[] {""} ;
         BC001110_n324BR_Procedure_Radio_Loc = new bool[] {false} ;
         BC001110_A325BR_Procedure_Radio_Amount = new String[] {""} ;
         BC001110_n325BR_Procedure_Radio_Amount = new bool[] {false} ;
         BC001110_A139BR_ProcedureID = new long[1] ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_procedure_radio_bc__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_procedure_radio_bc__default(),
            new Object[][] {
                new Object[] {
               BC00112_A323BR_Procedure_RadioID, BC00112_A324BR_Procedure_Radio_Loc, BC00112_n324BR_Procedure_Radio_Loc, BC00112_A325BR_Procedure_Radio_Amount, BC00112_n325BR_Procedure_Radio_Amount, BC00112_A139BR_ProcedureID
               }
               , new Object[] {
               BC00113_A323BR_Procedure_RadioID, BC00113_A324BR_Procedure_Radio_Loc, BC00113_n324BR_Procedure_Radio_Loc, BC00113_A325BR_Procedure_Radio_Amount, BC00113_n325BR_Procedure_Radio_Amount, BC00113_A139BR_ProcedureID
               }
               , new Object[] {
               BC00114_A139BR_ProcedureID
               }
               , new Object[] {
               BC00115_A323BR_Procedure_RadioID, BC00115_A324BR_Procedure_Radio_Loc, BC00115_n324BR_Procedure_Radio_Loc, BC00115_A325BR_Procedure_Radio_Amount, BC00115_n325BR_Procedure_Radio_Amount, BC00115_A139BR_ProcedureID
               }
               , new Object[] {
               BC00116_A323BR_Procedure_RadioID
               }
               , new Object[] {
               BC00117_A323BR_Procedure_RadioID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC001110_A323BR_Procedure_RadioID, BC001110_A324BR_Procedure_Radio_Loc, BC001110_n324BR_Procedure_Radio_Loc, BC001110_A325BR_Procedure_Radio_Amount, BC001110_n325BR_Procedure_Radio_Amount, BC001110_A139BR_ProcedureID
               }
            }
         );
         AV16Pgmname = "BR_Procedure_Radio_BC";
         INITTRN();
         /* Execute Start event if defined. */
         /* Execute user event: Start */
         E12112 ();
         standaloneNotModal( ) ;
      }

      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short GX_JID ;
      private short RcdFound38 ;
      private int trnEnded ;
      private int AV17GXV1 ;
      private long Z323BR_Procedure_RadioID ;
      private long A323BR_Procedure_RadioID ;
      private long AV13Insert_BR_ProcedureID ;
      private long Z139BR_ProcedureID ;
      private long A139BR_ProcedureID ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String AV16Pgmname ;
      private String sMode38 ;
      private bool AV9IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool n324BR_Procedure_Radio_Loc ;
      private bool n325BR_Procedure_Radio_Amount ;
      private String Z324BR_Procedure_Radio_Loc ;
      private String A324BR_Procedure_Radio_Loc ;
      private String Z325BR_Procedure_Radio_Amount ;
      private String A325BR_Procedure_Radio_Amount ;
      private IGxSession AV12WebSession ;
      private SdtBR_Procedure_Radio bcBR_Procedure_Radio ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] BC00115_A323BR_Procedure_RadioID ;
      private String[] BC00115_A324BR_Procedure_Radio_Loc ;
      private bool[] BC00115_n324BR_Procedure_Radio_Loc ;
      private String[] BC00115_A325BR_Procedure_Radio_Amount ;
      private bool[] BC00115_n325BR_Procedure_Radio_Amount ;
      private long[] BC00115_A139BR_ProcedureID ;
      private long[] BC00114_A139BR_ProcedureID ;
      private long[] BC00116_A323BR_Procedure_RadioID ;
      private long[] BC00113_A323BR_Procedure_RadioID ;
      private String[] BC00113_A324BR_Procedure_Radio_Loc ;
      private bool[] BC00113_n324BR_Procedure_Radio_Loc ;
      private String[] BC00113_A325BR_Procedure_Radio_Amount ;
      private bool[] BC00113_n325BR_Procedure_Radio_Amount ;
      private long[] BC00113_A139BR_ProcedureID ;
      private long[] BC00112_A323BR_Procedure_RadioID ;
      private String[] BC00112_A324BR_Procedure_Radio_Loc ;
      private bool[] BC00112_n324BR_Procedure_Radio_Loc ;
      private String[] BC00112_A325BR_Procedure_Radio_Amount ;
      private bool[] BC00112_n325BR_Procedure_Radio_Amount ;
      private long[] BC00112_A139BR_ProcedureID ;
      private long[] BC00117_A323BR_Procedure_RadioID ;
      private long[] BC001110_A323BR_Procedure_RadioID ;
      private String[] BC001110_A324BR_Procedure_Radio_Loc ;
      private bool[] BC001110_n324BR_Procedure_Radio_Loc ;
      private String[] BC001110_A325BR_Procedure_Radio_Amount ;
      private bool[] BC001110_n325BR_Procedure_Radio_Amount ;
      private long[] BC001110_A139BR_ProcedureID ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_datastore1 ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV8WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV11TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV14TrnContextAtt ;
   }

   public class br_procedure_radio_bc__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class br_procedure_radio_bc__default : DataStoreHelperBase, IDataStoreHelper
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
        Object[] prmBC00115 ;
        prmBC00115 = new Object[] {
        new Object[] {"@BR_Procedure_RadioID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00114 ;
        prmBC00114 = new Object[] {
        new Object[] {"@BR_ProcedureID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00116 ;
        prmBC00116 = new Object[] {
        new Object[] {"@BR_Procedure_RadioID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00113 ;
        prmBC00113 = new Object[] {
        new Object[] {"@BR_Procedure_RadioID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00112 ;
        prmBC00112 = new Object[] {
        new Object[] {"@BR_Procedure_RadioID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00117 ;
        prmBC00117 = new Object[] {
        new Object[] {"@BR_Procedure_Radio_Loc",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Procedure_Radio_Amount",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_ProcedureID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00118 ;
        prmBC00118 = new Object[] {
        new Object[] {"@BR_Procedure_Radio_Loc",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Procedure_Radio_Amount",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_ProcedureID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_Procedure_RadioID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00119 ;
        prmBC00119 = new Object[] {
        new Object[] {"@BR_Procedure_RadioID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC001110 ;
        prmBC001110 = new Object[] {
        new Object[] {"@BR_Procedure_RadioID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("BC00112", "SELECT [BR_Procedure_RadioID], [BR_Procedure_Radio_Loc], [BR_Procedure_Radio_Amount], [BR_ProcedureID] FROM [BR_Procedure_Radio] WITH (UPDLOCK) WHERE [BR_Procedure_RadioID] = @BR_Procedure_RadioID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00112,1,0,true,false )
           ,new CursorDef("BC00113", "SELECT [BR_Procedure_RadioID], [BR_Procedure_Radio_Loc], [BR_Procedure_Radio_Amount], [BR_ProcedureID] FROM [BR_Procedure_Radio] WITH (NOLOCK) WHERE [BR_Procedure_RadioID] = @BR_Procedure_RadioID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00113,1,0,true,false )
           ,new CursorDef("BC00114", "SELECT [BR_ProcedureID] FROM [BR_Procedure] WITH (NOLOCK) WHERE [BR_ProcedureID] = @BR_ProcedureID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00114,1,0,true,false )
           ,new CursorDef("BC00115", "SELECT TM1.[BR_Procedure_RadioID], TM1.[BR_Procedure_Radio_Loc], TM1.[BR_Procedure_Radio_Amount], TM1.[BR_ProcedureID] FROM [BR_Procedure_Radio] TM1 WITH (NOLOCK) WHERE TM1.[BR_Procedure_RadioID] = @BR_Procedure_RadioID ORDER BY TM1.[BR_Procedure_RadioID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00115,100,0,true,false )
           ,new CursorDef("BC00116", "SELECT [BR_Procedure_RadioID] FROM [BR_Procedure_Radio] WITH (NOLOCK) WHERE [BR_Procedure_RadioID] = @BR_Procedure_RadioID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00116,1,0,true,false )
           ,new CursorDef("BC00117", "INSERT INTO [BR_Procedure_Radio]([BR_Procedure_Radio_Loc], [BR_Procedure_Radio_Amount], [BR_ProcedureID]) VALUES(@BR_Procedure_Radio_Loc, @BR_Procedure_Radio_Amount, @BR_ProcedureID); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmBC00117)
           ,new CursorDef("BC00118", "UPDATE [BR_Procedure_Radio] SET [BR_Procedure_Radio_Loc]=@BR_Procedure_Radio_Loc, [BR_Procedure_Radio_Amount]=@BR_Procedure_Radio_Amount, [BR_ProcedureID]=@BR_ProcedureID  WHERE [BR_Procedure_RadioID] = @BR_Procedure_RadioID", GxErrorMask.GX_NOMASK,prmBC00118)
           ,new CursorDef("BC00119", "DELETE FROM [BR_Procedure_Radio]  WHERE [BR_Procedure_RadioID] = @BR_Procedure_RadioID", GxErrorMask.GX_NOMASK,prmBC00119)
           ,new CursorDef("BC001110", "SELECT TM1.[BR_Procedure_RadioID], TM1.[BR_Procedure_Radio_Loc], TM1.[BR_Procedure_Radio_Amount], TM1.[BR_ProcedureID] FROM [BR_Procedure_Radio] TM1 WITH (NOLOCK) WHERE TM1.[BR_Procedure_RadioID] = @BR_Procedure_RadioID ORDER BY TM1.[BR_Procedure_RadioID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001110,100,0,true,false )
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
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((long[]) buf[5])[0] = rslt.getLong(4) ;
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
              ((long[]) buf[5])[0] = rslt.getLong(4) ;
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
              ((long[]) buf[5])[0] = rslt.getLong(4) ;
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
                 stmt.setNull( 2 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(2, (String)parms[3]);
              }
              stmt.SetParameter(3, (long)parms[4]);
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
              stmt.SetParameter(3, (long)parms[4]);
              stmt.SetParameter(4, (long)parms[5]);
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
