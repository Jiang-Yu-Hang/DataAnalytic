/*
               File: BR_Procedure_Surgery_BC
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:8:24.79
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
   public class br_procedure_surgery_bc : GXHttpHandler, IGxSilentTrn
   {
      public br_procedure_surgery_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_procedure_surgery_bc( IGxContext context )
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
         ReadRow1037( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey1037( ) ;
         standaloneModal( ) ;
         AddRow1037( ) ;
         Gx_mode = "INS";
         return  ;
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E11102 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               Z320BR_Procedure_SurgeryID = A320BR_Procedure_SurgeryID;
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

      protected void CONFIRM_100( )
      {
         BeforeValidate1037( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls1037( ) ;
            }
            else
            {
               CheckExtendedTable1037( ) ;
               if ( AnyError == 0 )
               {
                  ZM1037( 8) ;
               }
               CloseExtendedTableCursors1037( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void E12102( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV8WWPContext) ;
         AV9IsAuthorized = true;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_Procedure_Surgery", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_Procedure_Surgery", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Procedure_Surgery", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
         }
         if ( ! AV9IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV17Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV11TrnContext.FromXml(AV12WebSession.Get("TrnContext"), null, "WWPTransactionContext", "DataAnalysisPlatform");
         if ( ( StringUtil.StrCmp(AV11TrnContext.gxTpr_Transactionname, AV17Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV18GXV1 = 1;
            while ( AV18GXV1 <= AV11TrnContext.gxTpr_Attributes.Count )
            {
               AV14TrnContextAtt = ((GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute)AV11TrnContext.gxTpr_Attributes.Item(AV18GXV1));
               if ( StringUtil.StrCmp(AV14TrnContextAtt.gxTpr_Attributename, "BR_ProcedureID") == 0 )
               {
                  AV13Insert_BR_ProcedureID = (long)(NumberUtil.Val( AV14TrnContextAtt.gxTpr_Attributevalue, "."));
               }
               AV18GXV1 = (int)(AV18GXV1+1);
            }
         }
      }

      protected void E11102( )
      {
         /* After Trn Routine */
      }

      protected void ZM1037( short GX_JID )
      {
         if ( ( GX_JID == 7 ) || ( GX_JID == 0 ) )
         {
            Z321BR_Procedure_Surgery_Name = A321BR_Procedure_Surgery_Name;
            Z322BR_Procedure_Surgery_Loc = A322BR_Procedure_Surgery_Loc;
            Z139BR_ProcedureID = A139BR_ProcedureID;
         }
         if ( ( GX_JID == 8 ) || ( GX_JID == 0 ) )
         {
         }
         if ( GX_JID == -7 )
         {
            Z320BR_Procedure_SurgeryID = A320BR_Procedure_SurgeryID;
            Z321BR_Procedure_Surgery_Name = A321BR_Procedure_Surgery_Name;
            Z322BR_Procedure_Surgery_Loc = A322BR_Procedure_Surgery_Loc;
            Z139BR_ProcedureID = A139BR_ProcedureID;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load1037( )
      {
         /* Using cursor BC00105 */
         pr_default.execute(3, new Object[] {A320BR_Procedure_SurgeryID});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound37 = 1;
            A321BR_Procedure_Surgery_Name = BC00105_A321BR_Procedure_Surgery_Name[0];
            n321BR_Procedure_Surgery_Name = BC00105_n321BR_Procedure_Surgery_Name[0];
            A322BR_Procedure_Surgery_Loc = BC00105_A322BR_Procedure_Surgery_Loc[0];
            n322BR_Procedure_Surgery_Loc = BC00105_n322BR_Procedure_Surgery_Loc[0];
            A139BR_ProcedureID = BC00105_A139BR_ProcedureID[0];
            ZM1037( -7) ;
         }
         pr_default.close(3);
         OnLoadActions1037( ) ;
      }

      protected void OnLoadActions1037( )
      {
         AV17Pgmname = "BR_Procedure_Surgery_BC";
      }

      protected void CheckExtendedTable1037( )
      {
         standaloneModal( ) ;
         AV17Pgmname = "BR_Procedure_Surgery_BC";
         /* Using cursor BC00104 */
         pr_default.execute(2, new Object[] {A139BR_ProcedureID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("不匹配' T19'", "ForeignKeyNotFound", 1, "BR_PROCEDUREID");
            AnyError = 1;
         }
         pr_default.close(2);
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A321BR_Procedure_Surgery_Name)) )
         {
            GX_msglist.addItem("手术名称是必须填写的。", 1, "");
            AnyError = 1;
         }
      }

      protected void CloseExtendedTableCursors1037( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey1037( )
      {
         /* Using cursor BC00106 */
         pr_default.execute(4, new Object[] {A320BR_Procedure_SurgeryID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound37 = 1;
         }
         else
         {
            RcdFound37 = 0;
         }
         pr_default.close(4);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC00103 */
         pr_default.execute(1, new Object[] {A320BR_Procedure_SurgeryID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM1037( 7) ;
            RcdFound37 = 1;
            A320BR_Procedure_SurgeryID = BC00103_A320BR_Procedure_SurgeryID[0];
            A321BR_Procedure_Surgery_Name = BC00103_A321BR_Procedure_Surgery_Name[0];
            n321BR_Procedure_Surgery_Name = BC00103_n321BR_Procedure_Surgery_Name[0];
            A322BR_Procedure_Surgery_Loc = BC00103_A322BR_Procedure_Surgery_Loc[0];
            n322BR_Procedure_Surgery_Loc = BC00103_n322BR_Procedure_Surgery_Loc[0];
            A139BR_ProcedureID = BC00103_A139BR_ProcedureID[0];
            Z320BR_Procedure_SurgeryID = A320BR_Procedure_SurgeryID;
            sMode37 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load1037( ) ;
            if ( AnyError == 1 )
            {
               RcdFound37 = 0;
               InitializeNonKey1037( ) ;
            }
            Gx_mode = sMode37;
         }
         else
         {
            RcdFound37 = 0;
            InitializeNonKey1037( ) ;
            sMode37 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode37;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1037( ) ;
         if ( RcdFound37 == 0 )
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
         CONFIRM_100( ) ;
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

      protected void CheckOptimisticConcurrency1037( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC00102 */
            pr_default.execute(0, new Object[] {A320BR_Procedure_SurgeryID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Procedure_Surgery"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z321BR_Procedure_Surgery_Name, BC00102_A321BR_Procedure_Surgery_Name[0]) != 0 ) || ( StringUtil.StrCmp(Z322BR_Procedure_Surgery_Loc, BC00102_A322BR_Procedure_Surgery_Loc[0]) != 0 ) || ( Z139BR_ProcedureID != BC00102_A139BR_ProcedureID[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"BR_Procedure_Surgery"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert1037( )
      {
         BeforeValidate1037( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1037( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1037( 0) ;
            CheckOptimisticConcurrency1037( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1037( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1037( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00107 */
                     pr_default.execute(5, new Object[] {n321BR_Procedure_Surgery_Name, A321BR_Procedure_Surgery_Name, n322BR_Procedure_Surgery_Loc, A322BR_Procedure_Surgery_Loc, A139BR_ProcedureID});
                     A320BR_Procedure_SurgeryID = BC00107_A320BR_Procedure_SurgeryID[0];
                     pr_default.close(5);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Procedure_Surgery") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A139BR_ProcedureID), 18, 0)),  "诊疗处理",  StringUtil.Trim( StringUtil.Str( (decimal)(A320BR_Procedure_SurgeryID), 18, 0)),  "手术信息",  "Create",  1) ;
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
               Load1037( ) ;
            }
            EndLevel1037( ) ;
         }
         CloseExtendedTableCursors1037( ) ;
      }

      protected void Update1037( )
      {
         BeforeValidate1037( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1037( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1037( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1037( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1037( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00108 */
                     pr_default.execute(6, new Object[] {n321BR_Procedure_Surgery_Name, A321BR_Procedure_Surgery_Name, n322BR_Procedure_Surgery_Loc, A322BR_Procedure_Surgery_Loc, A139BR_ProcedureID, A320BR_Procedure_SurgeryID});
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Procedure_Surgery") ;
                     if ( (pr_default.getStatus(6) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Procedure_Surgery"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate1037( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A139BR_ProcedureID), 18, 0)),  "诊疗处理",  StringUtil.Trim( StringUtil.Str( (decimal)(A320BR_Procedure_SurgeryID), 18, 0)),  "手术信息",  "Update",  1) ;
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
            EndLevel1037( ) ;
         }
         CloseExtendedTableCursors1037( ) ;
      }

      protected void DeferredUpdate1037( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate1037( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1037( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1037( ) ;
            AfterConfirm1037( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1037( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC00109 */
                  pr_default.execute(7, new Object[] {A320BR_Procedure_SurgeryID});
                  pr_default.close(7);
                  dsDefault.SmartCacheProvider.SetUpdated("BR_Procedure_Surgery") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A139BR_ProcedureID), 18, 0)),  "诊疗处理",  StringUtil.Trim( StringUtil.Str( (decimal)(A320BR_Procedure_SurgeryID), 18, 0)),  "手术信息",  "Delete",  1) ;
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
         sMode37 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel1037( ) ;
         Gx_mode = sMode37;
      }

      protected void OnDeleteControls1037( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV17Pgmname = "BR_Procedure_Surgery_BC";
         }
      }

      protected void EndLevel1037( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1037( ) ;
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

      public void ScanKeyStart1037( )
      {
         /* Scan By routine */
         /* Using cursor BC001010 */
         pr_default.execute(8, new Object[] {A320BR_Procedure_SurgeryID});
         RcdFound37 = 0;
         if ( (pr_default.getStatus(8) != 101) )
         {
            RcdFound37 = 1;
            A320BR_Procedure_SurgeryID = BC001010_A320BR_Procedure_SurgeryID[0];
            A321BR_Procedure_Surgery_Name = BC001010_A321BR_Procedure_Surgery_Name[0];
            n321BR_Procedure_Surgery_Name = BC001010_n321BR_Procedure_Surgery_Name[0];
            A322BR_Procedure_Surgery_Loc = BC001010_A322BR_Procedure_Surgery_Loc[0];
            n322BR_Procedure_Surgery_Loc = BC001010_n322BR_Procedure_Surgery_Loc[0];
            A139BR_ProcedureID = BC001010_A139BR_ProcedureID[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext1037( )
      {
         /* Scan next routine */
         pr_default.readNext(8);
         RcdFound37 = 0;
         ScanKeyLoad1037( ) ;
      }

      protected void ScanKeyLoad1037( )
      {
         sMode37 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(8) != 101) )
         {
            RcdFound37 = 1;
            A320BR_Procedure_SurgeryID = BC001010_A320BR_Procedure_SurgeryID[0];
            A321BR_Procedure_Surgery_Name = BC001010_A321BR_Procedure_Surgery_Name[0];
            n321BR_Procedure_Surgery_Name = BC001010_n321BR_Procedure_Surgery_Name[0];
            A322BR_Procedure_Surgery_Loc = BC001010_A322BR_Procedure_Surgery_Loc[0];
            n322BR_Procedure_Surgery_Loc = BC001010_n322BR_Procedure_Surgery_Loc[0];
            A139BR_ProcedureID = BC001010_A139BR_ProcedureID[0];
         }
         Gx_mode = sMode37;
      }

      protected void ScanKeyEnd1037( )
      {
         pr_default.close(8);
      }

      protected void AfterConfirm1037( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1037( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1037( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1037( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1037( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1037( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1037( )
      {
      }

      protected void send_integrity_lvl_hashes1037( )
      {
      }

      protected void AddRow1037( )
      {
         VarsToRow37( bcBR_Procedure_Surgery) ;
      }

      protected void ReadRow1037( )
      {
         RowToVars37( bcBR_Procedure_Surgery, 1) ;
      }

      protected void InitializeNonKey1037( )
      {
         A139BR_ProcedureID = 0;
         A321BR_Procedure_Surgery_Name = "";
         n321BR_Procedure_Surgery_Name = false;
         A322BR_Procedure_Surgery_Loc = "";
         n322BR_Procedure_Surgery_Loc = false;
         Z321BR_Procedure_Surgery_Name = "";
         Z322BR_Procedure_Surgery_Loc = "";
         Z139BR_ProcedureID = 0;
      }

      protected void InitAll1037( )
      {
         A320BR_Procedure_SurgeryID = 0;
         InitializeNonKey1037( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow37( SdtBR_Procedure_Surgery obj37 )
      {
         obj37.gxTpr_Mode = Gx_mode;
         obj37.gxTpr_Br_procedureid = A139BR_ProcedureID;
         obj37.gxTpr_Br_procedure_surgery_name = A321BR_Procedure_Surgery_Name;
         obj37.gxTpr_Br_procedure_surgery_loc = A322BR_Procedure_Surgery_Loc;
         obj37.gxTpr_Br_procedure_surgeryid = A320BR_Procedure_SurgeryID;
         obj37.gxTpr_Br_procedure_surgeryid_Z = Z320BR_Procedure_SurgeryID;
         obj37.gxTpr_Br_procedureid_Z = Z139BR_ProcedureID;
         obj37.gxTpr_Br_procedure_surgery_name_Z = Z321BR_Procedure_Surgery_Name;
         obj37.gxTpr_Br_procedure_surgery_loc_Z = Z322BR_Procedure_Surgery_Loc;
         obj37.gxTpr_Br_procedure_surgery_name_N = (short)(Convert.ToInt16(n321BR_Procedure_Surgery_Name));
         obj37.gxTpr_Br_procedure_surgery_loc_N = (short)(Convert.ToInt16(n322BR_Procedure_Surgery_Loc));
         obj37.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow37( SdtBR_Procedure_Surgery obj37 )
      {
         obj37.gxTpr_Br_procedure_surgeryid = A320BR_Procedure_SurgeryID;
         return  ;
      }

      public void RowToVars37( SdtBR_Procedure_Surgery obj37 ,
                               int forceLoad )
      {
         Gx_mode = obj37.gxTpr_Mode;
         A139BR_ProcedureID = obj37.gxTpr_Br_procedureid;
         A321BR_Procedure_Surgery_Name = obj37.gxTpr_Br_procedure_surgery_name;
         n321BR_Procedure_Surgery_Name = false;
         A322BR_Procedure_Surgery_Loc = obj37.gxTpr_Br_procedure_surgery_loc;
         n322BR_Procedure_Surgery_Loc = false;
         A320BR_Procedure_SurgeryID = obj37.gxTpr_Br_procedure_surgeryid;
         Z320BR_Procedure_SurgeryID = obj37.gxTpr_Br_procedure_surgeryid_Z;
         Z139BR_ProcedureID = obj37.gxTpr_Br_procedureid_Z;
         Z321BR_Procedure_Surgery_Name = obj37.gxTpr_Br_procedure_surgery_name_Z;
         Z322BR_Procedure_Surgery_Loc = obj37.gxTpr_Br_procedure_surgery_loc_Z;
         n321BR_Procedure_Surgery_Name = (bool)(Convert.ToBoolean(obj37.gxTpr_Br_procedure_surgery_name_N));
         n322BR_Procedure_Surgery_Loc = (bool)(Convert.ToBoolean(obj37.gxTpr_Br_procedure_surgery_loc_N));
         Gx_mode = obj37.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A320BR_Procedure_SurgeryID = (long)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey1037( ) ;
         ScanKeyStart1037( ) ;
         if ( RcdFound37 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z320BR_Procedure_SurgeryID = A320BR_Procedure_SurgeryID;
         }
         ZM1037( -7) ;
         OnLoadActions1037( ) ;
         AddRow1037( ) ;
         ScanKeyEnd1037( ) ;
         if ( RcdFound37 == 0 )
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
         RowToVars37( bcBR_Procedure_Surgery, 0) ;
         ScanKeyStart1037( ) ;
         if ( RcdFound37 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z320BR_Procedure_SurgeryID = A320BR_Procedure_SurgeryID;
         }
         ZM1037( -7) ;
         OnLoadActions1037( ) ;
         AddRow1037( ) ;
         ScanKeyEnd1037( ) ;
         if ( RcdFound37 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey1037( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert1037( ) ;
         }
         else
         {
            if ( RcdFound37 == 1 )
            {
               if ( A320BR_Procedure_SurgeryID != Z320BR_Procedure_SurgeryID )
               {
                  A320BR_Procedure_SurgeryID = Z320BR_Procedure_SurgeryID;
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
                  Update1037( ) ;
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
                  if ( A320BR_Procedure_SurgeryID != Z320BR_Procedure_SurgeryID )
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
                        Insert1037( ) ;
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
                        Insert1037( ) ;
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
         RowToVars37( bcBR_Procedure_Surgery, 0) ;
         SaveImpl( ) ;
         VarsToRow37( bcBR_Procedure_Surgery) ;
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
         RowToVars37( bcBR_Procedure_Surgery, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert1037( ) ;
         AfterTrn( ) ;
         VarsToRow37( bcBR_Procedure_Surgery) ;
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
            SdtBR_Procedure_Surgery auxBC = new SdtBR_Procedure_Surgery(context) ;
            auxBC.Load(A320BR_Procedure_SurgeryID);
            auxBC.UpdateDirties(bcBR_Procedure_Surgery);
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
         RowToVars37( bcBR_Procedure_Surgery, 0) ;
         UpdateImpl( ) ;
         VarsToRow37( bcBR_Procedure_Surgery) ;
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
         RowToVars37( bcBR_Procedure_Surgery, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert1037( ) ;
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
         VarsToRow37( bcBR_Procedure_Surgery) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars37( bcBR_Procedure_Surgery, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey1037( ) ;
         if ( RcdFound37 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A320BR_Procedure_SurgeryID != Z320BR_Procedure_SurgeryID )
            {
               A320BR_Procedure_SurgeryID = Z320BR_Procedure_SurgeryID;
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
            if ( A320BR_Procedure_SurgeryID != Z320BR_Procedure_SurgeryID )
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
         context.RollbackDataStores("br_procedure_surgery_bc",pr_default);
         VarsToRow37( bcBR_Procedure_Surgery) ;
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
         Gx_mode = bcBR_Procedure_Surgery.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcBR_Procedure_Surgery.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcBR_Procedure_Surgery )
         {
            bcBR_Procedure_Surgery = (SdtBR_Procedure_Surgery)(sdt);
            if ( StringUtil.StrCmp(bcBR_Procedure_Surgery.gxTpr_Mode, "") == 0 )
            {
               bcBR_Procedure_Surgery.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow37( bcBR_Procedure_Surgery) ;
            }
            else
            {
               RowToVars37( bcBR_Procedure_Surgery, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcBR_Procedure_Surgery.gxTpr_Mode, "") == 0 )
            {
               bcBR_Procedure_Surgery.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars37( bcBR_Procedure_Surgery, 1) ;
         return  ;
      }

      public SdtBR_Procedure_Surgery BR_Procedure_Surgery_BC
      {
         get {
            return bcBR_Procedure_Surgery ;
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
         AV17Pgmname = "";
         AV11TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV12WebSession = context.GetSession();
         AV14TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         Z321BR_Procedure_Surgery_Name = "";
         A321BR_Procedure_Surgery_Name = "";
         Z322BR_Procedure_Surgery_Loc = "";
         A322BR_Procedure_Surgery_Loc = "";
         BC00105_A320BR_Procedure_SurgeryID = new long[1] ;
         BC00105_A321BR_Procedure_Surgery_Name = new String[] {""} ;
         BC00105_n321BR_Procedure_Surgery_Name = new bool[] {false} ;
         BC00105_A322BR_Procedure_Surgery_Loc = new String[] {""} ;
         BC00105_n322BR_Procedure_Surgery_Loc = new bool[] {false} ;
         BC00105_A139BR_ProcedureID = new long[1] ;
         BC00104_A139BR_ProcedureID = new long[1] ;
         BC00106_A320BR_Procedure_SurgeryID = new long[1] ;
         BC00103_A320BR_Procedure_SurgeryID = new long[1] ;
         BC00103_A321BR_Procedure_Surgery_Name = new String[] {""} ;
         BC00103_n321BR_Procedure_Surgery_Name = new bool[] {false} ;
         BC00103_A322BR_Procedure_Surgery_Loc = new String[] {""} ;
         BC00103_n322BR_Procedure_Surgery_Loc = new bool[] {false} ;
         BC00103_A139BR_ProcedureID = new long[1] ;
         sMode37 = "";
         BC00102_A320BR_Procedure_SurgeryID = new long[1] ;
         BC00102_A321BR_Procedure_Surgery_Name = new String[] {""} ;
         BC00102_n321BR_Procedure_Surgery_Name = new bool[] {false} ;
         BC00102_A322BR_Procedure_Surgery_Loc = new String[] {""} ;
         BC00102_n322BR_Procedure_Surgery_Loc = new bool[] {false} ;
         BC00102_A139BR_ProcedureID = new long[1] ;
         BC00107_A320BR_Procedure_SurgeryID = new long[1] ;
         BC001010_A320BR_Procedure_SurgeryID = new long[1] ;
         BC001010_A321BR_Procedure_Surgery_Name = new String[] {""} ;
         BC001010_n321BR_Procedure_Surgery_Name = new bool[] {false} ;
         BC001010_A322BR_Procedure_Surgery_Loc = new String[] {""} ;
         BC001010_n322BR_Procedure_Surgery_Loc = new bool[] {false} ;
         BC001010_A139BR_ProcedureID = new long[1] ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_procedure_surgery_bc__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_procedure_surgery_bc__default(),
            new Object[][] {
                new Object[] {
               BC00102_A320BR_Procedure_SurgeryID, BC00102_A321BR_Procedure_Surgery_Name, BC00102_n321BR_Procedure_Surgery_Name, BC00102_A322BR_Procedure_Surgery_Loc, BC00102_n322BR_Procedure_Surgery_Loc, BC00102_A139BR_ProcedureID
               }
               , new Object[] {
               BC00103_A320BR_Procedure_SurgeryID, BC00103_A321BR_Procedure_Surgery_Name, BC00103_n321BR_Procedure_Surgery_Name, BC00103_A322BR_Procedure_Surgery_Loc, BC00103_n322BR_Procedure_Surgery_Loc, BC00103_A139BR_ProcedureID
               }
               , new Object[] {
               BC00104_A139BR_ProcedureID
               }
               , new Object[] {
               BC00105_A320BR_Procedure_SurgeryID, BC00105_A321BR_Procedure_Surgery_Name, BC00105_n321BR_Procedure_Surgery_Name, BC00105_A322BR_Procedure_Surgery_Loc, BC00105_n322BR_Procedure_Surgery_Loc, BC00105_A139BR_ProcedureID
               }
               , new Object[] {
               BC00106_A320BR_Procedure_SurgeryID
               }
               , new Object[] {
               BC00107_A320BR_Procedure_SurgeryID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC001010_A320BR_Procedure_SurgeryID, BC001010_A321BR_Procedure_Surgery_Name, BC001010_n321BR_Procedure_Surgery_Name, BC001010_A322BR_Procedure_Surgery_Loc, BC001010_n322BR_Procedure_Surgery_Loc, BC001010_A139BR_ProcedureID
               }
            }
         );
         AV17Pgmname = "BR_Procedure_Surgery_BC";
         INITTRN();
         /* Execute Start event if defined. */
         /* Execute user event: Start */
         E12102 ();
         standaloneNotModal( ) ;
      }

      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short GX_JID ;
      private short RcdFound37 ;
      private int trnEnded ;
      private int AV18GXV1 ;
      private long Z320BR_Procedure_SurgeryID ;
      private long A320BR_Procedure_SurgeryID ;
      private long AV13Insert_BR_ProcedureID ;
      private long Z139BR_ProcedureID ;
      private long A139BR_ProcedureID ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String AV17Pgmname ;
      private String sMode37 ;
      private bool AV9IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool n321BR_Procedure_Surgery_Name ;
      private bool n322BR_Procedure_Surgery_Loc ;
      private String Z321BR_Procedure_Surgery_Name ;
      private String A321BR_Procedure_Surgery_Name ;
      private String Z322BR_Procedure_Surgery_Loc ;
      private String A322BR_Procedure_Surgery_Loc ;
      private IGxSession AV12WebSession ;
      private SdtBR_Procedure_Surgery bcBR_Procedure_Surgery ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] BC00105_A320BR_Procedure_SurgeryID ;
      private String[] BC00105_A321BR_Procedure_Surgery_Name ;
      private bool[] BC00105_n321BR_Procedure_Surgery_Name ;
      private String[] BC00105_A322BR_Procedure_Surgery_Loc ;
      private bool[] BC00105_n322BR_Procedure_Surgery_Loc ;
      private long[] BC00105_A139BR_ProcedureID ;
      private long[] BC00104_A139BR_ProcedureID ;
      private long[] BC00106_A320BR_Procedure_SurgeryID ;
      private long[] BC00103_A320BR_Procedure_SurgeryID ;
      private String[] BC00103_A321BR_Procedure_Surgery_Name ;
      private bool[] BC00103_n321BR_Procedure_Surgery_Name ;
      private String[] BC00103_A322BR_Procedure_Surgery_Loc ;
      private bool[] BC00103_n322BR_Procedure_Surgery_Loc ;
      private long[] BC00103_A139BR_ProcedureID ;
      private long[] BC00102_A320BR_Procedure_SurgeryID ;
      private String[] BC00102_A321BR_Procedure_Surgery_Name ;
      private bool[] BC00102_n321BR_Procedure_Surgery_Name ;
      private String[] BC00102_A322BR_Procedure_Surgery_Loc ;
      private bool[] BC00102_n322BR_Procedure_Surgery_Loc ;
      private long[] BC00102_A139BR_ProcedureID ;
      private long[] BC00107_A320BR_Procedure_SurgeryID ;
      private long[] BC001010_A320BR_Procedure_SurgeryID ;
      private String[] BC001010_A321BR_Procedure_Surgery_Name ;
      private bool[] BC001010_n321BR_Procedure_Surgery_Name ;
      private String[] BC001010_A322BR_Procedure_Surgery_Loc ;
      private bool[] BC001010_n322BR_Procedure_Surgery_Loc ;
      private long[] BC001010_A139BR_ProcedureID ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_datastore1 ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV8WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV11TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV14TrnContextAtt ;
   }

   public class br_procedure_surgery_bc__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class br_procedure_surgery_bc__default : DataStoreHelperBase, IDataStoreHelper
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
        Object[] prmBC00105 ;
        prmBC00105 = new Object[] {
        new Object[] {"@BR_Procedure_SurgeryID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00104 ;
        prmBC00104 = new Object[] {
        new Object[] {"@BR_ProcedureID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00106 ;
        prmBC00106 = new Object[] {
        new Object[] {"@BR_Procedure_SurgeryID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00103 ;
        prmBC00103 = new Object[] {
        new Object[] {"@BR_Procedure_SurgeryID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00102 ;
        prmBC00102 = new Object[] {
        new Object[] {"@BR_Procedure_SurgeryID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00107 ;
        prmBC00107 = new Object[] {
        new Object[] {"@BR_Procedure_Surgery_Name",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Procedure_Surgery_Loc",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_ProcedureID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00108 ;
        prmBC00108 = new Object[] {
        new Object[] {"@BR_Procedure_Surgery_Name",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Procedure_Surgery_Loc",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_ProcedureID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_Procedure_SurgeryID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC00109 ;
        prmBC00109 = new Object[] {
        new Object[] {"@BR_Procedure_SurgeryID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC001010 ;
        prmBC001010 = new Object[] {
        new Object[] {"@BR_Procedure_SurgeryID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("BC00102", "SELECT [BR_Procedure_SurgeryID], [BR_Procedure_Surgery_Name], [BR_Procedure_Surgery_Loc], [BR_ProcedureID] FROM [BR_Procedure_Surgery] WITH (UPDLOCK) WHERE [BR_Procedure_SurgeryID] = @BR_Procedure_SurgeryID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00102,1,0,true,false )
           ,new CursorDef("BC00103", "SELECT [BR_Procedure_SurgeryID], [BR_Procedure_Surgery_Name], [BR_Procedure_Surgery_Loc], [BR_ProcedureID] FROM [BR_Procedure_Surgery] WITH (NOLOCK) WHERE [BR_Procedure_SurgeryID] = @BR_Procedure_SurgeryID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00103,1,0,true,false )
           ,new CursorDef("BC00104", "SELECT [BR_ProcedureID] FROM [BR_Procedure] WITH (NOLOCK) WHERE [BR_ProcedureID] = @BR_ProcedureID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00104,1,0,true,false )
           ,new CursorDef("BC00105", "SELECT TM1.[BR_Procedure_SurgeryID], TM1.[BR_Procedure_Surgery_Name], TM1.[BR_Procedure_Surgery_Loc], TM1.[BR_ProcedureID] FROM [BR_Procedure_Surgery] TM1 WITH (NOLOCK) WHERE TM1.[BR_Procedure_SurgeryID] = @BR_Procedure_SurgeryID ORDER BY TM1.[BR_Procedure_SurgeryID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00105,100,0,true,false )
           ,new CursorDef("BC00106", "SELECT [BR_Procedure_SurgeryID] FROM [BR_Procedure_Surgery] WITH (NOLOCK) WHERE [BR_Procedure_SurgeryID] = @BR_Procedure_SurgeryID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00106,1,0,true,false )
           ,new CursorDef("BC00107", "INSERT INTO [BR_Procedure_Surgery]([BR_Procedure_Surgery_Name], [BR_Procedure_Surgery_Loc], [BR_ProcedureID]) VALUES(@BR_Procedure_Surgery_Name, @BR_Procedure_Surgery_Loc, @BR_ProcedureID); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmBC00107)
           ,new CursorDef("BC00108", "UPDATE [BR_Procedure_Surgery] SET [BR_Procedure_Surgery_Name]=@BR_Procedure_Surgery_Name, [BR_Procedure_Surgery_Loc]=@BR_Procedure_Surgery_Loc, [BR_ProcedureID]=@BR_ProcedureID  WHERE [BR_Procedure_SurgeryID] = @BR_Procedure_SurgeryID", GxErrorMask.GX_NOMASK,prmBC00108)
           ,new CursorDef("BC00109", "DELETE FROM [BR_Procedure_Surgery]  WHERE [BR_Procedure_SurgeryID] = @BR_Procedure_SurgeryID", GxErrorMask.GX_NOMASK,prmBC00109)
           ,new CursorDef("BC001010", "SELECT TM1.[BR_Procedure_SurgeryID], TM1.[BR_Procedure_Surgery_Name], TM1.[BR_Procedure_Surgery_Loc], TM1.[BR_ProcedureID] FROM [BR_Procedure_Surgery] TM1 WITH (NOLOCK) WHERE TM1.[BR_Procedure_SurgeryID] = @BR_Procedure_SurgeryID ORDER BY TM1.[BR_Procedure_SurgeryID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001010,100,0,true,false )
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
