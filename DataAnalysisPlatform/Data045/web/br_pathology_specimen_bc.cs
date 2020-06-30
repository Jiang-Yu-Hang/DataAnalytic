/*
               File: BR_Pathology_Specimen_BC
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:8:18.7
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
   public class br_pathology_specimen_bc : GXHttpHandler, IGxSilentTrn
   {
      public br_pathology_specimen_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_pathology_specimen_bc( IGxContext context )
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
         ReadRow0W33( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey0W33( ) ;
         standaloneModal( ) ;
         AddRow0W33( ) ;
         Gx_mode = "INS";
         return  ;
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E110W2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               Z274BR_Pathology_SpecimenID = A274BR_Pathology_SpecimenID;
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

      protected void CONFIRM_0W0( )
      {
         BeforeValidate0W33( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0W33( ) ;
            }
            else
            {
               CheckExtendedTable0W33( ) ;
               if ( AnyError == 0 )
               {
                  ZM0W33( 8) ;
               }
               CloseExtendedTableCursors0W33( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void E120W2( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV8WWPContext) ;
         AV9IsAuthorized = true;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Pathology_Specimen", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Pathology_Specimen", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Pathology_Specimen", out  GXt_boolean1) ;
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

      protected void E110W2( )
      {
         /* After Trn Routine */
      }

      protected void ZM0W33( short GX_JID )
      {
         if ( ( GX_JID == 7 ) || ( GX_JID == 0 ) )
         {
            Z275BR_Pathology_Specimen_Name = A275BR_Pathology_Specimen_Name;
            Z226BR_PathologyID = A226BR_PathologyID;
         }
         if ( ( GX_JID == 8 ) || ( GX_JID == 0 ) )
         {
         }
         if ( GX_JID == -7 )
         {
            Z274BR_Pathology_SpecimenID = A274BR_Pathology_SpecimenID;
            Z275BR_Pathology_Specimen_Name = A275BR_Pathology_Specimen_Name;
            Z226BR_PathologyID = A226BR_PathologyID;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load0W33( )
      {
         /* Using cursor BC000W5 */
         pr_default.execute(3, new Object[] {A274BR_Pathology_SpecimenID});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound33 = 1;
            A275BR_Pathology_Specimen_Name = BC000W5_A275BR_Pathology_Specimen_Name[0];
            n275BR_Pathology_Specimen_Name = BC000W5_n275BR_Pathology_Specimen_Name[0];
            A226BR_PathologyID = BC000W5_A226BR_PathologyID[0];
            n226BR_PathologyID = BC000W5_n226BR_PathologyID[0];
            ZM0W33( -7) ;
         }
         pr_default.close(3);
         OnLoadActions0W33( ) ;
      }

      protected void OnLoadActions0W33( )
      {
         AV16Pgmname = "BR_Pathology_Specimen_BC";
      }

      protected void CheckExtendedTable0W33( )
      {
         standaloneModal( ) ;
         AV16Pgmname = "BR_Pathology_Specimen_BC";
         /* Using cursor BC000W4 */
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
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A275BR_Pathology_Specimen_Name)) )
         {
            GX_msglist.addItem("送检组织名称是必须填写的。", 1, "");
            AnyError = 1;
         }
      }

      protected void CloseExtendedTableCursors0W33( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0W33( )
      {
         /* Using cursor BC000W6 */
         pr_default.execute(4, new Object[] {A274BR_Pathology_SpecimenID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound33 = 1;
         }
         else
         {
            RcdFound33 = 0;
         }
         pr_default.close(4);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC000W3 */
         pr_default.execute(1, new Object[] {A274BR_Pathology_SpecimenID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0W33( 7) ;
            RcdFound33 = 1;
            A274BR_Pathology_SpecimenID = BC000W3_A274BR_Pathology_SpecimenID[0];
            A275BR_Pathology_Specimen_Name = BC000W3_A275BR_Pathology_Specimen_Name[0];
            n275BR_Pathology_Specimen_Name = BC000W3_n275BR_Pathology_Specimen_Name[0];
            A226BR_PathologyID = BC000W3_A226BR_PathologyID[0];
            n226BR_PathologyID = BC000W3_n226BR_PathologyID[0];
            Z274BR_Pathology_SpecimenID = A274BR_Pathology_SpecimenID;
            sMode33 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load0W33( ) ;
            if ( AnyError == 1 )
            {
               RcdFound33 = 0;
               InitializeNonKey0W33( ) ;
            }
            Gx_mode = sMode33;
         }
         else
         {
            RcdFound33 = 0;
            InitializeNonKey0W33( ) ;
            sMode33 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode33;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0W33( ) ;
         if ( RcdFound33 == 0 )
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
         CONFIRM_0W0( ) ;
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

      protected void CheckOptimisticConcurrency0W33( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC000W2 */
            pr_default.execute(0, new Object[] {A274BR_Pathology_SpecimenID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Pathology_Specimen"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z275BR_Pathology_Specimen_Name, BC000W2_A275BR_Pathology_Specimen_Name[0]) != 0 ) || ( Z226BR_PathologyID != BC000W2_A226BR_PathologyID[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"BR_Pathology_Specimen"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0W33( )
      {
         BeforeValidate0W33( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0W33( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0W33( 0) ;
            CheckOptimisticConcurrency0W33( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0W33( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0W33( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000W7 */
                     pr_default.execute(5, new Object[] {n275BR_Pathology_Specimen_Name, A275BR_Pathology_Specimen_Name, n226BR_PathologyID, A226BR_PathologyID});
                     A274BR_Pathology_SpecimenID = BC000W7_A274BR_Pathology_SpecimenID[0];
                     pr_default.close(5);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Pathology_Specimen") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)),  "病理学",  StringUtil.Trim( StringUtil.Str( (decimal)(A274BR_Pathology_SpecimenID), 18, 0)),  "送检组织",  "Create",  1) ;
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
               Load0W33( ) ;
            }
            EndLevel0W33( ) ;
         }
         CloseExtendedTableCursors0W33( ) ;
      }

      protected void Update0W33( )
      {
         BeforeValidate0W33( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0W33( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0W33( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0W33( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0W33( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000W8 */
                     pr_default.execute(6, new Object[] {n275BR_Pathology_Specimen_Name, A275BR_Pathology_Specimen_Name, n226BR_PathologyID, A226BR_PathologyID, A274BR_Pathology_SpecimenID});
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Pathology_Specimen") ;
                     if ( (pr_default.getStatus(6) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Pathology_Specimen"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0W33( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)),  "病理学",  StringUtil.Trim( StringUtil.Str( (decimal)(A274BR_Pathology_SpecimenID), 18, 0)),  "送检组织",  "Update",  1) ;
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
            EndLevel0W33( ) ;
         }
         CloseExtendedTableCursors0W33( ) ;
      }

      protected void DeferredUpdate0W33( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate0W33( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0W33( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0W33( ) ;
            AfterConfirm0W33( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0W33( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC000W9 */
                  pr_default.execute(7, new Object[] {A274BR_Pathology_SpecimenID});
                  pr_default.close(7);
                  dsDefault.SmartCacheProvider.SetUpdated("BR_Pathology_Specimen") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)),  "病理学",  StringUtil.Trim( StringUtil.Str( (decimal)(A274BR_Pathology_SpecimenID), 18, 0)),  "送检组织",  "Delete",  1) ;
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
         sMode33 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel0W33( ) ;
         Gx_mode = sMode33;
      }

      protected void OnDeleteControls0W33( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV16Pgmname = "BR_Pathology_Specimen_BC";
         }
      }

      protected void EndLevel0W33( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0W33( ) ;
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

      public void ScanKeyStart0W33( )
      {
         /* Scan By routine */
         /* Using cursor BC000W10 */
         pr_default.execute(8, new Object[] {A274BR_Pathology_SpecimenID});
         RcdFound33 = 0;
         if ( (pr_default.getStatus(8) != 101) )
         {
            RcdFound33 = 1;
            A274BR_Pathology_SpecimenID = BC000W10_A274BR_Pathology_SpecimenID[0];
            A275BR_Pathology_Specimen_Name = BC000W10_A275BR_Pathology_Specimen_Name[0];
            n275BR_Pathology_Specimen_Name = BC000W10_n275BR_Pathology_Specimen_Name[0];
            A226BR_PathologyID = BC000W10_A226BR_PathologyID[0];
            n226BR_PathologyID = BC000W10_n226BR_PathologyID[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext0W33( )
      {
         /* Scan next routine */
         pr_default.readNext(8);
         RcdFound33 = 0;
         ScanKeyLoad0W33( ) ;
      }

      protected void ScanKeyLoad0W33( )
      {
         sMode33 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(8) != 101) )
         {
            RcdFound33 = 1;
            A274BR_Pathology_SpecimenID = BC000W10_A274BR_Pathology_SpecimenID[0];
            A275BR_Pathology_Specimen_Name = BC000W10_A275BR_Pathology_Specimen_Name[0];
            n275BR_Pathology_Specimen_Name = BC000W10_n275BR_Pathology_Specimen_Name[0];
            A226BR_PathologyID = BC000W10_A226BR_PathologyID[0];
            n226BR_PathologyID = BC000W10_n226BR_PathologyID[0];
         }
         Gx_mode = sMode33;
      }

      protected void ScanKeyEnd0W33( )
      {
         pr_default.close(8);
      }

      protected void AfterConfirm0W33( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0W33( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0W33( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0W33( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0W33( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0W33( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0W33( )
      {
      }

      protected void send_integrity_lvl_hashes0W33( )
      {
      }

      protected void AddRow0W33( )
      {
         VarsToRow33( bcBR_Pathology_Specimen) ;
      }

      protected void ReadRow0W33( )
      {
         RowToVars33( bcBR_Pathology_Specimen, 1) ;
      }

      protected void InitializeNonKey0W33( )
      {
         A226BR_PathologyID = 0;
         n226BR_PathologyID = false;
         A275BR_Pathology_Specimen_Name = "";
         n275BR_Pathology_Specimen_Name = false;
         Z275BR_Pathology_Specimen_Name = "";
         Z226BR_PathologyID = 0;
      }

      protected void InitAll0W33( )
      {
         A274BR_Pathology_SpecimenID = 0;
         InitializeNonKey0W33( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow33( SdtBR_Pathology_Specimen obj33 )
      {
         obj33.gxTpr_Mode = Gx_mode;
         obj33.gxTpr_Br_pathologyid = A226BR_PathologyID;
         obj33.gxTpr_Br_pathology_specimen_name = A275BR_Pathology_Specimen_Name;
         obj33.gxTpr_Br_pathology_specimenid = A274BR_Pathology_SpecimenID;
         obj33.gxTpr_Br_pathology_specimenid_Z = Z274BR_Pathology_SpecimenID;
         obj33.gxTpr_Br_pathologyid_Z = Z226BR_PathologyID;
         obj33.gxTpr_Br_pathology_specimen_name_Z = Z275BR_Pathology_Specimen_Name;
         obj33.gxTpr_Br_pathologyid_N = (short)(Convert.ToInt16(n226BR_PathologyID));
         obj33.gxTpr_Br_pathology_specimen_name_N = (short)(Convert.ToInt16(n275BR_Pathology_Specimen_Name));
         obj33.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow33( SdtBR_Pathology_Specimen obj33 )
      {
         obj33.gxTpr_Br_pathology_specimenid = A274BR_Pathology_SpecimenID;
         return  ;
      }

      public void RowToVars33( SdtBR_Pathology_Specimen obj33 ,
                               int forceLoad )
      {
         Gx_mode = obj33.gxTpr_Mode;
         A226BR_PathologyID = obj33.gxTpr_Br_pathologyid;
         n226BR_PathologyID = false;
         A275BR_Pathology_Specimen_Name = obj33.gxTpr_Br_pathology_specimen_name;
         n275BR_Pathology_Specimen_Name = false;
         A274BR_Pathology_SpecimenID = obj33.gxTpr_Br_pathology_specimenid;
         Z274BR_Pathology_SpecimenID = obj33.gxTpr_Br_pathology_specimenid_Z;
         Z226BR_PathologyID = obj33.gxTpr_Br_pathologyid_Z;
         Z275BR_Pathology_Specimen_Name = obj33.gxTpr_Br_pathology_specimen_name_Z;
         n226BR_PathologyID = (bool)(Convert.ToBoolean(obj33.gxTpr_Br_pathologyid_N));
         n275BR_Pathology_Specimen_Name = (bool)(Convert.ToBoolean(obj33.gxTpr_Br_pathology_specimen_name_N));
         Gx_mode = obj33.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A274BR_Pathology_SpecimenID = (long)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey0W33( ) ;
         ScanKeyStart0W33( ) ;
         if ( RcdFound33 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z274BR_Pathology_SpecimenID = A274BR_Pathology_SpecimenID;
         }
         ZM0W33( -7) ;
         OnLoadActions0W33( ) ;
         AddRow0W33( ) ;
         ScanKeyEnd0W33( ) ;
         if ( RcdFound33 == 0 )
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
         RowToVars33( bcBR_Pathology_Specimen, 0) ;
         ScanKeyStart0W33( ) ;
         if ( RcdFound33 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z274BR_Pathology_SpecimenID = A274BR_Pathology_SpecimenID;
         }
         ZM0W33( -7) ;
         OnLoadActions0W33( ) ;
         AddRow0W33( ) ;
         ScanKeyEnd0W33( ) ;
         if ( RcdFound33 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey0W33( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert0W33( ) ;
         }
         else
         {
            if ( RcdFound33 == 1 )
            {
               if ( A274BR_Pathology_SpecimenID != Z274BR_Pathology_SpecimenID )
               {
                  A274BR_Pathology_SpecimenID = Z274BR_Pathology_SpecimenID;
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
                  Update0W33( ) ;
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
                  if ( A274BR_Pathology_SpecimenID != Z274BR_Pathology_SpecimenID )
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
                        Insert0W33( ) ;
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
                        Insert0W33( ) ;
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
         RowToVars33( bcBR_Pathology_Specimen, 0) ;
         SaveImpl( ) ;
         VarsToRow33( bcBR_Pathology_Specimen) ;
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
         RowToVars33( bcBR_Pathology_Specimen, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert0W33( ) ;
         AfterTrn( ) ;
         VarsToRow33( bcBR_Pathology_Specimen) ;
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
            SdtBR_Pathology_Specimen auxBC = new SdtBR_Pathology_Specimen(context) ;
            auxBC.Load(A274BR_Pathology_SpecimenID);
            auxBC.UpdateDirties(bcBR_Pathology_Specimen);
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
         RowToVars33( bcBR_Pathology_Specimen, 0) ;
         UpdateImpl( ) ;
         VarsToRow33( bcBR_Pathology_Specimen) ;
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
         RowToVars33( bcBR_Pathology_Specimen, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert0W33( ) ;
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
         VarsToRow33( bcBR_Pathology_Specimen) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars33( bcBR_Pathology_Specimen, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey0W33( ) ;
         if ( RcdFound33 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A274BR_Pathology_SpecimenID != Z274BR_Pathology_SpecimenID )
            {
               A274BR_Pathology_SpecimenID = Z274BR_Pathology_SpecimenID;
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
            if ( A274BR_Pathology_SpecimenID != Z274BR_Pathology_SpecimenID )
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
         context.RollbackDataStores("br_pathology_specimen_bc",pr_default);
         VarsToRow33( bcBR_Pathology_Specimen) ;
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
         Gx_mode = bcBR_Pathology_Specimen.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcBR_Pathology_Specimen.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcBR_Pathology_Specimen )
         {
            bcBR_Pathology_Specimen = (SdtBR_Pathology_Specimen)(sdt);
            if ( StringUtil.StrCmp(bcBR_Pathology_Specimen.gxTpr_Mode, "") == 0 )
            {
               bcBR_Pathology_Specimen.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow33( bcBR_Pathology_Specimen) ;
            }
            else
            {
               RowToVars33( bcBR_Pathology_Specimen, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcBR_Pathology_Specimen.gxTpr_Mode, "") == 0 )
            {
               bcBR_Pathology_Specimen.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars33( bcBR_Pathology_Specimen, 1) ;
         return  ;
      }

      public SdtBR_Pathology_Specimen BR_Pathology_Specimen_BC
      {
         get {
            return bcBR_Pathology_Specimen ;
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
         Z275BR_Pathology_Specimen_Name = "";
         A275BR_Pathology_Specimen_Name = "";
         BC000W5_A274BR_Pathology_SpecimenID = new long[1] ;
         BC000W5_A275BR_Pathology_Specimen_Name = new String[] {""} ;
         BC000W5_n275BR_Pathology_Specimen_Name = new bool[] {false} ;
         BC000W5_A226BR_PathologyID = new long[1] ;
         BC000W5_n226BR_PathologyID = new bool[] {false} ;
         BC000W4_A226BR_PathologyID = new long[1] ;
         BC000W4_n226BR_PathologyID = new bool[] {false} ;
         BC000W6_A274BR_Pathology_SpecimenID = new long[1] ;
         BC000W3_A274BR_Pathology_SpecimenID = new long[1] ;
         BC000W3_A275BR_Pathology_Specimen_Name = new String[] {""} ;
         BC000W3_n275BR_Pathology_Specimen_Name = new bool[] {false} ;
         BC000W3_A226BR_PathologyID = new long[1] ;
         BC000W3_n226BR_PathologyID = new bool[] {false} ;
         sMode33 = "";
         BC000W2_A274BR_Pathology_SpecimenID = new long[1] ;
         BC000W2_A275BR_Pathology_Specimen_Name = new String[] {""} ;
         BC000W2_n275BR_Pathology_Specimen_Name = new bool[] {false} ;
         BC000W2_A226BR_PathologyID = new long[1] ;
         BC000W2_n226BR_PathologyID = new bool[] {false} ;
         BC000W7_A274BR_Pathology_SpecimenID = new long[1] ;
         BC000W10_A274BR_Pathology_SpecimenID = new long[1] ;
         BC000W10_A275BR_Pathology_Specimen_Name = new String[] {""} ;
         BC000W10_n275BR_Pathology_Specimen_Name = new bool[] {false} ;
         BC000W10_A226BR_PathologyID = new long[1] ;
         BC000W10_n226BR_PathologyID = new bool[] {false} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_pathology_specimen_bc__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_pathology_specimen_bc__default(),
            new Object[][] {
                new Object[] {
               BC000W2_A274BR_Pathology_SpecimenID, BC000W2_A275BR_Pathology_Specimen_Name, BC000W2_n275BR_Pathology_Specimen_Name, BC000W2_A226BR_PathologyID, BC000W2_n226BR_PathologyID
               }
               , new Object[] {
               BC000W3_A274BR_Pathology_SpecimenID, BC000W3_A275BR_Pathology_Specimen_Name, BC000W3_n275BR_Pathology_Specimen_Name, BC000W3_A226BR_PathologyID, BC000W3_n226BR_PathologyID
               }
               , new Object[] {
               BC000W4_A226BR_PathologyID
               }
               , new Object[] {
               BC000W5_A274BR_Pathology_SpecimenID, BC000W5_A275BR_Pathology_Specimen_Name, BC000W5_n275BR_Pathology_Specimen_Name, BC000W5_A226BR_PathologyID, BC000W5_n226BR_PathologyID
               }
               , new Object[] {
               BC000W6_A274BR_Pathology_SpecimenID
               }
               , new Object[] {
               BC000W7_A274BR_Pathology_SpecimenID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000W10_A274BR_Pathology_SpecimenID, BC000W10_A275BR_Pathology_Specimen_Name, BC000W10_n275BR_Pathology_Specimen_Name, BC000W10_A226BR_PathologyID, BC000W10_n226BR_PathologyID
               }
            }
         );
         AV16Pgmname = "BR_Pathology_Specimen_BC";
         INITTRN();
         /* Execute Start event if defined. */
         /* Execute user event: Start */
         E120W2 ();
         standaloneNotModal( ) ;
      }

      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short GX_JID ;
      private short RcdFound33 ;
      private int trnEnded ;
      private int AV17GXV1 ;
      private long Z274BR_Pathology_SpecimenID ;
      private long A274BR_Pathology_SpecimenID ;
      private long AV13Insert_BR_PathologyID ;
      private long Z226BR_PathologyID ;
      private long A226BR_PathologyID ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String AV16Pgmname ;
      private String sMode33 ;
      private bool AV9IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool n275BR_Pathology_Specimen_Name ;
      private bool n226BR_PathologyID ;
      private String Z275BR_Pathology_Specimen_Name ;
      private String A275BR_Pathology_Specimen_Name ;
      private IGxSession AV12WebSession ;
      private SdtBR_Pathology_Specimen bcBR_Pathology_Specimen ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] BC000W5_A274BR_Pathology_SpecimenID ;
      private String[] BC000W5_A275BR_Pathology_Specimen_Name ;
      private bool[] BC000W5_n275BR_Pathology_Specimen_Name ;
      private long[] BC000W5_A226BR_PathologyID ;
      private bool[] BC000W5_n226BR_PathologyID ;
      private long[] BC000W4_A226BR_PathologyID ;
      private bool[] BC000W4_n226BR_PathologyID ;
      private long[] BC000W6_A274BR_Pathology_SpecimenID ;
      private long[] BC000W3_A274BR_Pathology_SpecimenID ;
      private String[] BC000W3_A275BR_Pathology_Specimen_Name ;
      private bool[] BC000W3_n275BR_Pathology_Specimen_Name ;
      private long[] BC000W3_A226BR_PathologyID ;
      private bool[] BC000W3_n226BR_PathologyID ;
      private long[] BC000W2_A274BR_Pathology_SpecimenID ;
      private String[] BC000W2_A275BR_Pathology_Specimen_Name ;
      private bool[] BC000W2_n275BR_Pathology_Specimen_Name ;
      private long[] BC000W2_A226BR_PathologyID ;
      private bool[] BC000W2_n226BR_PathologyID ;
      private long[] BC000W7_A274BR_Pathology_SpecimenID ;
      private long[] BC000W10_A274BR_Pathology_SpecimenID ;
      private String[] BC000W10_A275BR_Pathology_Specimen_Name ;
      private bool[] BC000W10_n275BR_Pathology_Specimen_Name ;
      private long[] BC000W10_A226BR_PathologyID ;
      private bool[] BC000W10_n226BR_PathologyID ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_datastore1 ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV8WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV11TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV14TrnContextAtt ;
   }

   public class br_pathology_specimen_bc__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class br_pathology_specimen_bc__default : DataStoreHelperBase, IDataStoreHelper
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
        Object[] prmBC000W5 ;
        prmBC000W5 = new Object[] {
        new Object[] {"@BR_Pathology_SpecimenID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000W4 ;
        prmBC000W4 = new Object[] {
        new Object[] {"@BR_PathologyID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000W6 ;
        prmBC000W6 = new Object[] {
        new Object[] {"@BR_Pathology_SpecimenID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000W3 ;
        prmBC000W3 = new Object[] {
        new Object[] {"@BR_Pathology_SpecimenID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000W2 ;
        prmBC000W2 = new Object[] {
        new Object[] {"@BR_Pathology_SpecimenID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000W7 ;
        prmBC000W7 = new Object[] {
        new Object[] {"@BR_Pathology_Specimen_Name",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_PathologyID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000W8 ;
        prmBC000W8 = new Object[] {
        new Object[] {"@BR_Pathology_Specimen_Name",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_PathologyID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_Pathology_SpecimenID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000W9 ;
        prmBC000W9 = new Object[] {
        new Object[] {"@BR_Pathology_SpecimenID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000W10 ;
        prmBC000W10 = new Object[] {
        new Object[] {"@BR_Pathology_SpecimenID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("BC000W2", "SELECT [BR_Pathology_SpecimenID], [BR_Pathology_Specimen_Name], [BR_PathologyID] FROM [BR_Pathology_Specimen] WITH (UPDLOCK) WHERE [BR_Pathology_SpecimenID] = @BR_Pathology_SpecimenID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000W2,1,0,true,false )
           ,new CursorDef("BC000W3", "SELECT [BR_Pathology_SpecimenID], [BR_Pathology_Specimen_Name], [BR_PathologyID] FROM [BR_Pathology_Specimen] WITH (NOLOCK) WHERE [BR_Pathology_SpecimenID] = @BR_Pathology_SpecimenID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000W3,1,0,true,false )
           ,new CursorDef("BC000W4", "SELECT [BR_PathologyID] FROM [BR_Pathology] WITH (NOLOCK) WHERE [BR_PathologyID] = @BR_PathologyID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000W4,1,0,true,false )
           ,new CursorDef("BC000W5", "SELECT TM1.[BR_Pathology_SpecimenID], TM1.[BR_Pathology_Specimen_Name], TM1.[BR_PathologyID] FROM [BR_Pathology_Specimen] TM1 WITH (NOLOCK) WHERE TM1.[BR_Pathology_SpecimenID] = @BR_Pathology_SpecimenID ORDER BY TM1.[BR_Pathology_SpecimenID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000W5,100,0,true,false )
           ,new CursorDef("BC000W6", "SELECT [BR_Pathology_SpecimenID] FROM [BR_Pathology_Specimen] WITH (NOLOCK) WHERE [BR_Pathology_SpecimenID] = @BR_Pathology_SpecimenID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000W6,1,0,true,false )
           ,new CursorDef("BC000W7", "INSERT INTO [BR_Pathology_Specimen]([BR_Pathology_Specimen_Name], [BR_PathologyID]) VALUES(@BR_Pathology_Specimen_Name, @BR_PathologyID); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmBC000W7)
           ,new CursorDef("BC000W8", "UPDATE [BR_Pathology_Specimen] SET [BR_Pathology_Specimen_Name]=@BR_Pathology_Specimen_Name, [BR_PathologyID]=@BR_PathologyID  WHERE [BR_Pathology_SpecimenID] = @BR_Pathology_SpecimenID", GxErrorMask.GX_NOMASK,prmBC000W8)
           ,new CursorDef("BC000W9", "DELETE FROM [BR_Pathology_Specimen]  WHERE [BR_Pathology_SpecimenID] = @BR_Pathology_SpecimenID", GxErrorMask.GX_NOMASK,prmBC000W9)
           ,new CursorDef("BC000W10", "SELECT TM1.[BR_Pathology_SpecimenID], TM1.[BR_Pathology_Specimen_Name], TM1.[BR_PathologyID] FROM [BR_Pathology_Specimen] TM1 WITH (NOLOCK) WHERE TM1.[BR_Pathology_SpecimenID] = @BR_Pathology_SpecimenID ORDER BY TM1.[BR_Pathology_SpecimenID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000W10,100,0,true,false )
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
              ((long[]) buf[3])[0] = rslt.getLong(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((long[]) buf[3])[0] = rslt.getLong(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              return;
           case 2 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 3 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((long[]) buf[3])[0] = rslt.getLong(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
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
              ((long[]) buf[3])[0] = rslt.getLong(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
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
                 stmt.SetParameter(2, (long)parms[3]);
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
                 stmt.SetParameter(2, (long)parms[3]);
              }
              stmt.SetParameter(3, (long)parms[4]);
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
