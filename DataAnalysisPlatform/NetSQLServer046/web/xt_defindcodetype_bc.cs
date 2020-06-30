/*
               File: XT_DefindcodeType_BC
        Description: 数据字典类型
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:56:48.41
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
   public class xt_defindcodetype_bc : GXHttpHandler, IGxSilentTrn
   {
      public xt_defindcodetype_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public xt_defindcodetype_bc( IGxContext context )
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
         ReadRow0M23( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey0M23( ) ;
         standaloneModal( ) ;
         AddRow0M23( ) ;
         Gx_mode = "INS";
         return  ;
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E110M2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               Z165XT_DefindcodeTypeID = A165XT_DefindcodeTypeID;
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

      protected void CONFIRM_0M0( )
      {
         BeforeValidate0M23( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0M23( ) ;
            }
            else
            {
               CheckExtendedTable0M23( ) ;
               if ( AnyError == 0 )
               {
               }
               CloseExtendedTableCursors0M23( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void E120M2( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV8WWPContext) ;
         AV9IsAuthorized = true;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_DefindcodeType", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_DefindcodeType", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_DefindcodeType", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
         }
         if ( ! AV9IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV14Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV11TrnContext.FromXml(AV12WebSession.Get("TrnContext"), null, "WWPTransactionContext", "DataAnalysisPlatform");
      }

      protected void E110M2( )
      {
         /* After Trn Routine */
      }

      protected void ZM0M23( short GX_JID )
      {
         if ( ( GX_JID == 2 ) || ( GX_JID == 0 ) )
         {
            Z166XT_DefindcodeTypeName = A166XT_DefindcodeTypeName;
            Z511XT_DefindcodeTypeIsShow = A511XT_DefindcodeTypeIsShow;
         }
         if ( GX_JID == -2 )
         {
            Z165XT_DefindcodeTypeID = A165XT_DefindcodeTypeID;
            Z166XT_DefindcodeTypeName = A166XT_DefindcodeTypeName;
            Z511XT_DefindcodeTypeIsShow = A511XT_DefindcodeTypeIsShow;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load0M23( )
      {
         /* Using cursor BC000M4 */
         pr_default.execute(2, new Object[] {A165XT_DefindcodeTypeID});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound23 = 1;
            A166XT_DefindcodeTypeName = BC000M4_A166XT_DefindcodeTypeName[0];
            n166XT_DefindcodeTypeName = BC000M4_n166XT_DefindcodeTypeName[0];
            A511XT_DefindcodeTypeIsShow = BC000M4_A511XT_DefindcodeTypeIsShow[0];
            n511XT_DefindcodeTypeIsShow = BC000M4_n511XT_DefindcodeTypeIsShow[0];
            ZM0M23( -2) ;
         }
         pr_default.close(2);
         OnLoadActions0M23( ) ;
      }

      protected void OnLoadActions0M23( )
      {
         AV14Pgmname = "XT_DefindcodeType_BC";
      }

      protected void CheckExtendedTable0M23( )
      {
         standaloneModal( ) ;
         AV14Pgmname = "XT_DefindcodeType_BC";
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A166XT_DefindcodeTypeName)) )
         {
            GX_msglist.addItem("数据字典类型名称是必须填写的。", 1, "");
            AnyError = 1;
         }
      }

      protected void CloseExtendedTableCursors0M23( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0M23( )
      {
         /* Using cursor BC000M5 */
         pr_default.execute(3, new Object[] {A165XT_DefindcodeTypeID});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound23 = 1;
         }
         else
         {
            RcdFound23 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC000M3 */
         pr_default.execute(1, new Object[] {A165XT_DefindcodeTypeID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0M23( 2) ;
            RcdFound23 = 1;
            A165XT_DefindcodeTypeID = BC000M3_A165XT_DefindcodeTypeID[0];
            A166XT_DefindcodeTypeName = BC000M3_A166XT_DefindcodeTypeName[0];
            n166XT_DefindcodeTypeName = BC000M3_n166XT_DefindcodeTypeName[0];
            A511XT_DefindcodeTypeIsShow = BC000M3_A511XT_DefindcodeTypeIsShow[0];
            n511XT_DefindcodeTypeIsShow = BC000M3_n511XT_DefindcodeTypeIsShow[0];
            Z165XT_DefindcodeTypeID = A165XT_DefindcodeTypeID;
            sMode23 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load0M23( ) ;
            if ( AnyError == 1 )
            {
               RcdFound23 = 0;
               InitializeNonKey0M23( ) ;
            }
            Gx_mode = sMode23;
         }
         else
         {
            RcdFound23 = 0;
            InitializeNonKey0M23( ) ;
            sMode23 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode23;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0M23( ) ;
         if ( RcdFound23 == 0 )
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
         CONFIRM_0M0( ) ;
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

      protected void CheckOptimisticConcurrency0M23( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC000M2 */
            pr_default.execute(0, new Object[] {A165XT_DefindcodeTypeID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"XT_DefindcodeType"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z166XT_DefindcodeTypeName, BC000M2_A166XT_DefindcodeTypeName[0]) != 0 ) || ( Z511XT_DefindcodeTypeIsShow != BC000M2_A511XT_DefindcodeTypeIsShow[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"XT_DefindcodeType"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0M23( )
      {
         BeforeValidate0M23( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0M23( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0M23( 0) ;
            CheckOptimisticConcurrency0M23( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0M23( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0M23( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000M6 */
                     pr_default.execute(4, new Object[] {n166XT_DefindcodeTypeName, A166XT_DefindcodeTypeName, n511XT_DefindcodeTypeIsShow, A511XT_DefindcodeTypeIsShow});
                     A165XT_DefindcodeTypeID = BC000M6_A165XT_DefindcodeTypeID[0];
                     pr_default.close(4);
                     dsDefault.SmartCacheProvider.SetUpdated("XT_DefindcodeType") ;
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
               Load0M23( ) ;
            }
            EndLevel0M23( ) ;
         }
         CloseExtendedTableCursors0M23( ) ;
      }

      protected void Update0M23( )
      {
         BeforeValidate0M23( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0M23( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0M23( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0M23( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0M23( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000M7 */
                     pr_default.execute(5, new Object[] {n166XT_DefindcodeTypeName, A166XT_DefindcodeTypeName, n511XT_DefindcodeTypeIsShow, A511XT_DefindcodeTypeIsShow, A165XT_DefindcodeTypeID});
                     pr_default.close(5);
                     dsDefault.SmartCacheProvider.SetUpdated("XT_DefindcodeType") ;
                     if ( (pr_default.getStatus(5) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"XT_DefindcodeType"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0M23( ) ;
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
            EndLevel0M23( ) ;
         }
         CloseExtendedTableCursors0M23( ) ;
      }

      protected void DeferredUpdate0M23( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate0M23( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0M23( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0M23( ) ;
            AfterConfirm0M23( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0M23( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC000M8 */
                  pr_default.execute(6, new Object[] {A165XT_DefindcodeTypeID});
                  pr_default.close(6);
                  dsDefault.SmartCacheProvider.SetUpdated("XT_DefindcodeType") ;
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
         sMode23 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel0M23( ) ;
         Gx_mode = sMode23;
      }

      protected void OnDeleteControls0M23( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV14Pgmname = "XT_DefindcodeType_BC";
         }
         if ( AnyError == 0 )
         {
            /* Using cursor BC000M9 */
            pr_default.execute(7, new Object[] {A165XT_DefindcodeTypeID});
            if ( (pr_default.getStatus(7) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"数据字典数据"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(7);
         }
      }

      protected void EndLevel0M23( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0M23( ) ;
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

      public void ScanKeyStart0M23( )
      {
         /* Scan By routine */
         /* Using cursor BC000M10 */
         pr_default.execute(8, new Object[] {A165XT_DefindcodeTypeID});
         RcdFound23 = 0;
         if ( (pr_default.getStatus(8) != 101) )
         {
            RcdFound23 = 1;
            A165XT_DefindcodeTypeID = BC000M10_A165XT_DefindcodeTypeID[0];
            A166XT_DefindcodeTypeName = BC000M10_A166XT_DefindcodeTypeName[0];
            n166XT_DefindcodeTypeName = BC000M10_n166XT_DefindcodeTypeName[0];
            A511XT_DefindcodeTypeIsShow = BC000M10_A511XT_DefindcodeTypeIsShow[0];
            n511XT_DefindcodeTypeIsShow = BC000M10_n511XT_DefindcodeTypeIsShow[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext0M23( )
      {
         /* Scan next routine */
         pr_default.readNext(8);
         RcdFound23 = 0;
         ScanKeyLoad0M23( ) ;
      }

      protected void ScanKeyLoad0M23( )
      {
         sMode23 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(8) != 101) )
         {
            RcdFound23 = 1;
            A165XT_DefindcodeTypeID = BC000M10_A165XT_DefindcodeTypeID[0];
            A166XT_DefindcodeTypeName = BC000M10_A166XT_DefindcodeTypeName[0];
            n166XT_DefindcodeTypeName = BC000M10_n166XT_DefindcodeTypeName[0];
            A511XT_DefindcodeTypeIsShow = BC000M10_A511XT_DefindcodeTypeIsShow[0];
            n511XT_DefindcodeTypeIsShow = BC000M10_n511XT_DefindcodeTypeIsShow[0];
         }
         Gx_mode = sMode23;
      }

      protected void ScanKeyEnd0M23( )
      {
         pr_default.close(8);
      }

      protected void AfterConfirm0M23( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0M23( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0M23( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0M23( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0M23( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0M23( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0M23( )
      {
      }

      protected void send_integrity_lvl_hashes0M23( )
      {
      }

      protected void AddRow0M23( )
      {
         VarsToRow23( bcXT_DefindcodeType) ;
      }

      protected void ReadRow0M23( )
      {
         RowToVars23( bcXT_DefindcodeType, 1) ;
      }

      protected void InitializeNonKey0M23( )
      {
         A166XT_DefindcodeTypeName = "";
         n166XT_DefindcodeTypeName = false;
         A511XT_DefindcodeTypeIsShow = 0;
         n511XT_DefindcodeTypeIsShow = false;
         Z166XT_DefindcodeTypeName = "";
         Z511XT_DefindcodeTypeIsShow = 0;
      }

      protected void InitAll0M23( )
      {
         A165XT_DefindcodeTypeID = 0;
         InitializeNonKey0M23( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow23( SdtXT_DefindcodeType obj23 )
      {
         obj23.gxTpr_Mode = Gx_mode;
         obj23.gxTpr_Xt_defindcodetypename = A166XT_DefindcodeTypeName;
         obj23.gxTpr_Xt_defindcodetypeisshow = A511XT_DefindcodeTypeIsShow;
         obj23.gxTpr_Xt_defindcodetypeid = A165XT_DefindcodeTypeID;
         obj23.gxTpr_Xt_defindcodetypeid_Z = Z165XT_DefindcodeTypeID;
         obj23.gxTpr_Xt_defindcodetypename_Z = Z166XT_DefindcodeTypeName;
         obj23.gxTpr_Xt_defindcodetypeisshow_Z = Z511XT_DefindcodeTypeIsShow;
         obj23.gxTpr_Xt_defindcodetypename_N = (short)(Convert.ToInt16(n166XT_DefindcodeTypeName));
         obj23.gxTpr_Xt_defindcodetypeisshow_N = (short)(Convert.ToInt16(n511XT_DefindcodeTypeIsShow));
         obj23.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow23( SdtXT_DefindcodeType obj23 )
      {
         obj23.gxTpr_Xt_defindcodetypeid = A165XT_DefindcodeTypeID;
         return  ;
      }

      public void RowToVars23( SdtXT_DefindcodeType obj23 ,
                               int forceLoad )
      {
         Gx_mode = obj23.gxTpr_Mode;
         A166XT_DefindcodeTypeName = obj23.gxTpr_Xt_defindcodetypename;
         n166XT_DefindcodeTypeName = false;
         A511XT_DefindcodeTypeIsShow = obj23.gxTpr_Xt_defindcodetypeisshow;
         n511XT_DefindcodeTypeIsShow = false;
         A165XT_DefindcodeTypeID = obj23.gxTpr_Xt_defindcodetypeid;
         Z165XT_DefindcodeTypeID = obj23.gxTpr_Xt_defindcodetypeid_Z;
         Z166XT_DefindcodeTypeName = obj23.gxTpr_Xt_defindcodetypename_Z;
         Z511XT_DefindcodeTypeIsShow = obj23.gxTpr_Xt_defindcodetypeisshow_Z;
         n166XT_DefindcodeTypeName = (bool)(Convert.ToBoolean(obj23.gxTpr_Xt_defindcodetypename_N));
         n511XT_DefindcodeTypeIsShow = (bool)(Convert.ToBoolean(obj23.gxTpr_Xt_defindcodetypeisshow_N));
         Gx_mode = obj23.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A165XT_DefindcodeTypeID = (long)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey0M23( ) ;
         ScanKeyStart0M23( ) ;
         if ( RcdFound23 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z165XT_DefindcodeTypeID = A165XT_DefindcodeTypeID;
         }
         ZM0M23( -2) ;
         OnLoadActions0M23( ) ;
         AddRow0M23( ) ;
         ScanKeyEnd0M23( ) ;
         if ( RcdFound23 == 0 )
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
         RowToVars23( bcXT_DefindcodeType, 0) ;
         ScanKeyStart0M23( ) ;
         if ( RcdFound23 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z165XT_DefindcodeTypeID = A165XT_DefindcodeTypeID;
         }
         ZM0M23( -2) ;
         OnLoadActions0M23( ) ;
         AddRow0M23( ) ;
         ScanKeyEnd0M23( ) ;
         if ( RcdFound23 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey0M23( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert0M23( ) ;
         }
         else
         {
            if ( RcdFound23 == 1 )
            {
               if ( A165XT_DefindcodeTypeID != Z165XT_DefindcodeTypeID )
               {
                  A165XT_DefindcodeTypeID = Z165XT_DefindcodeTypeID;
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
                  Update0M23( ) ;
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
                  if ( A165XT_DefindcodeTypeID != Z165XT_DefindcodeTypeID )
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
                        Insert0M23( ) ;
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
                        Insert0M23( ) ;
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
         RowToVars23( bcXT_DefindcodeType, 0) ;
         SaveImpl( ) ;
         VarsToRow23( bcXT_DefindcodeType) ;
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
         RowToVars23( bcXT_DefindcodeType, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert0M23( ) ;
         AfterTrn( ) ;
         VarsToRow23( bcXT_DefindcodeType) ;
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
            SdtXT_DefindcodeType auxBC = new SdtXT_DefindcodeType(context) ;
            auxBC.Load(A165XT_DefindcodeTypeID);
            auxBC.UpdateDirties(bcXT_DefindcodeType);
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
         RowToVars23( bcXT_DefindcodeType, 0) ;
         UpdateImpl( ) ;
         VarsToRow23( bcXT_DefindcodeType) ;
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
         RowToVars23( bcXT_DefindcodeType, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert0M23( ) ;
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
         VarsToRow23( bcXT_DefindcodeType) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars23( bcXT_DefindcodeType, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey0M23( ) ;
         if ( RcdFound23 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A165XT_DefindcodeTypeID != Z165XT_DefindcodeTypeID )
            {
               A165XT_DefindcodeTypeID = Z165XT_DefindcodeTypeID;
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
            if ( A165XT_DefindcodeTypeID != Z165XT_DefindcodeTypeID )
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
         context.RollbackDataStores("xt_defindcodetype_bc",pr_default);
         VarsToRow23( bcXT_DefindcodeType) ;
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
         Gx_mode = bcXT_DefindcodeType.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcXT_DefindcodeType.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcXT_DefindcodeType )
         {
            bcXT_DefindcodeType = (SdtXT_DefindcodeType)(sdt);
            if ( StringUtil.StrCmp(bcXT_DefindcodeType.gxTpr_Mode, "") == 0 )
            {
               bcXT_DefindcodeType.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow23( bcXT_DefindcodeType) ;
            }
            else
            {
               RowToVars23( bcXT_DefindcodeType, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcXT_DefindcodeType.gxTpr_Mode, "") == 0 )
            {
               bcXT_DefindcodeType.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars23( bcXT_DefindcodeType, 1) ;
         return  ;
      }

      public SdtXT_DefindcodeType XT_DefindcodeType_BC
      {
         get {
            return bcXT_DefindcodeType ;
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
         AV14Pgmname = "";
         AV11TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV12WebSession = context.GetSession();
         Z166XT_DefindcodeTypeName = "";
         A166XT_DefindcodeTypeName = "";
         BC000M4_A165XT_DefindcodeTypeID = new long[1] ;
         BC000M4_A166XT_DefindcodeTypeName = new String[] {""} ;
         BC000M4_n166XT_DefindcodeTypeName = new bool[] {false} ;
         BC000M4_A511XT_DefindcodeTypeIsShow = new short[1] ;
         BC000M4_n511XT_DefindcodeTypeIsShow = new bool[] {false} ;
         BC000M5_A165XT_DefindcodeTypeID = new long[1] ;
         BC000M3_A165XT_DefindcodeTypeID = new long[1] ;
         BC000M3_A166XT_DefindcodeTypeName = new String[] {""} ;
         BC000M3_n166XT_DefindcodeTypeName = new bool[] {false} ;
         BC000M3_A511XT_DefindcodeTypeIsShow = new short[1] ;
         BC000M3_n511XT_DefindcodeTypeIsShow = new bool[] {false} ;
         sMode23 = "";
         BC000M2_A165XT_DefindcodeTypeID = new long[1] ;
         BC000M2_A166XT_DefindcodeTypeName = new String[] {""} ;
         BC000M2_n166XT_DefindcodeTypeName = new bool[] {false} ;
         BC000M2_A511XT_DefindcodeTypeIsShow = new short[1] ;
         BC000M2_n511XT_DefindcodeTypeIsShow = new bool[] {false} ;
         BC000M6_A165XT_DefindcodeTypeID = new long[1] ;
         BC000M9_A167XT_DefineCodeID = new long[1] ;
         BC000M10_A165XT_DefindcodeTypeID = new long[1] ;
         BC000M10_A166XT_DefindcodeTypeName = new String[] {""} ;
         BC000M10_n166XT_DefindcodeTypeName = new bool[] {false} ;
         BC000M10_A511XT_DefindcodeTypeIsShow = new short[1] ;
         BC000M10_n511XT_DefindcodeTypeIsShow = new bool[] {false} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.xt_defindcodetype_bc__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.xt_defindcodetype_bc__default(),
            new Object[][] {
                new Object[] {
               BC000M2_A165XT_DefindcodeTypeID, BC000M2_A166XT_DefindcodeTypeName, BC000M2_n166XT_DefindcodeTypeName, BC000M2_A511XT_DefindcodeTypeIsShow, BC000M2_n511XT_DefindcodeTypeIsShow
               }
               , new Object[] {
               BC000M3_A165XT_DefindcodeTypeID, BC000M3_A166XT_DefindcodeTypeName, BC000M3_n166XT_DefindcodeTypeName, BC000M3_A511XT_DefindcodeTypeIsShow, BC000M3_n511XT_DefindcodeTypeIsShow
               }
               , new Object[] {
               BC000M4_A165XT_DefindcodeTypeID, BC000M4_A166XT_DefindcodeTypeName, BC000M4_n166XT_DefindcodeTypeName, BC000M4_A511XT_DefindcodeTypeIsShow, BC000M4_n511XT_DefindcodeTypeIsShow
               }
               , new Object[] {
               BC000M5_A165XT_DefindcodeTypeID
               }
               , new Object[] {
               BC000M6_A165XT_DefindcodeTypeID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000M9_A167XT_DefineCodeID
               }
               , new Object[] {
               BC000M10_A165XT_DefindcodeTypeID, BC000M10_A166XT_DefindcodeTypeName, BC000M10_n166XT_DefindcodeTypeName, BC000M10_A511XT_DefindcodeTypeIsShow, BC000M10_n511XT_DefindcodeTypeIsShow
               }
            }
         );
         AV14Pgmname = "XT_DefindcodeType_BC";
         INITTRN();
         /* Execute Start event if defined. */
         /* Execute user event: Start */
         E120M2 ();
         standaloneNotModal( ) ;
      }

      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short GX_JID ;
      private short Z511XT_DefindcodeTypeIsShow ;
      private short A511XT_DefindcodeTypeIsShow ;
      private short RcdFound23 ;
      private int trnEnded ;
      private long Z165XT_DefindcodeTypeID ;
      private long A165XT_DefindcodeTypeID ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String AV14Pgmname ;
      private String sMode23 ;
      private bool AV9IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool n166XT_DefindcodeTypeName ;
      private bool n511XT_DefindcodeTypeIsShow ;
      private String Z166XT_DefindcodeTypeName ;
      private String A166XT_DefindcodeTypeName ;
      private IGxSession AV12WebSession ;
      private SdtXT_DefindcodeType bcXT_DefindcodeType ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] BC000M4_A165XT_DefindcodeTypeID ;
      private String[] BC000M4_A166XT_DefindcodeTypeName ;
      private bool[] BC000M4_n166XT_DefindcodeTypeName ;
      private short[] BC000M4_A511XT_DefindcodeTypeIsShow ;
      private bool[] BC000M4_n511XT_DefindcodeTypeIsShow ;
      private long[] BC000M5_A165XT_DefindcodeTypeID ;
      private long[] BC000M3_A165XT_DefindcodeTypeID ;
      private String[] BC000M3_A166XT_DefindcodeTypeName ;
      private bool[] BC000M3_n166XT_DefindcodeTypeName ;
      private short[] BC000M3_A511XT_DefindcodeTypeIsShow ;
      private bool[] BC000M3_n511XT_DefindcodeTypeIsShow ;
      private long[] BC000M2_A165XT_DefindcodeTypeID ;
      private String[] BC000M2_A166XT_DefindcodeTypeName ;
      private bool[] BC000M2_n166XT_DefindcodeTypeName ;
      private short[] BC000M2_A511XT_DefindcodeTypeIsShow ;
      private bool[] BC000M2_n511XT_DefindcodeTypeIsShow ;
      private long[] BC000M6_A165XT_DefindcodeTypeID ;
      private long[] BC000M9_A167XT_DefineCodeID ;
      private long[] BC000M10_A165XT_DefindcodeTypeID ;
      private String[] BC000M10_A166XT_DefindcodeTypeName ;
      private bool[] BC000M10_n166XT_DefindcodeTypeName ;
      private short[] BC000M10_A511XT_DefindcodeTypeIsShow ;
      private bool[] BC000M10_n511XT_DefindcodeTypeIsShow ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_datastore1 ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV8WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV11TrnContext ;
   }

   public class xt_defindcodetype_bc__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class xt_defindcodetype_bc__default : DataStoreHelperBase, IDataStoreHelper
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
       ,new UpdateCursor(def[5])
       ,new UpdateCursor(def[6])
       ,new ForEachCursor(def[7])
       ,new ForEachCursor(def[8])
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmBC000M4 ;
        prmBC000M4 = new Object[] {
        new Object[] {"@XT_DefindcodeTypeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000M5 ;
        prmBC000M5 = new Object[] {
        new Object[] {"@XT_DefindcodeTypeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000M3 ;
        prmBC000M3 = new Object[] {
        new Object[] {"@XT_DefindcodeTypeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000M2 ;
        prmBC000M2 = new Object[] {
        new Object[] {"@XT_DefindcodeTypeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000M6 ;
        prmBC000M6 = new Object[] {
        new Object[] {"@XT_DefindcodeTypeName",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@XT_DefindcodeTypeIsShow",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmBC000M7 ;
        prmBC000M7 = new Object[] {
        new Object[] {"@XT_DefindcodeTypeName",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@XT_DefindcodeTypeIsShow",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@XT_DefindcodeTypeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000M8 ;
        prmBC000M8 = new Object[] {
        new Object[] {"@XT_DefindcodeTypeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000M9 ;
        prmBC000M9 = new Object[] {
        new Object[] {"@XT_DefindcodeTypeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000M10 ;
        prmBC000M10 = new Object[] {
        new Object[] {"@XT_DefindcodeTypeID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("BC000M2", "SELECT [XT_DefindcodeTypeID], [XT_DefindcodeTypeName], [XT_DefindcodeTypeIsShow] FROM [XT_DefindcodeType] WITH (UPDLOCK) WHERE [XT_DefindcodeTypeID] = @XT_DefindcodeTypeID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000M2,1,0,true,false )
           ,new CursorDef("BC000M3", "SELECT [XT_DefindcodeTypeID], [XT_DefindcodeTypeName], [XT_DefindcodeTypeIsShow] FROM [XT_DefindcodeType] WITH (NOLOCK) WHERE [XT_DefindcodeTypeID] = @XT_DefindcodeTypeID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000M3,1,0,true,false )
           ,new CursorDef("BC000M4", "SELECT TM1.[XT_DefindcodeTypeID], TM1.[XT_DefindcodeTypeName], TM1.[XT_DefindcodeTypeIsShow] FROM [XT_DefindcodeType] TM1 WITH (NOLOCK) WHERE TM1.[XT_DefindcodeTypeID] = @XT_DefindcodeTypeID ORDER BY TM1.[XT_DefindcodeTypeID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000M4,100,0,true,false )
           ,new CursorDef("BC000M5", "SELECT [XT_DefindcodeTypeID] FROM [XT_DefindcodeType] WITH (NOLOCK) WHERE [XT_DefindcodeTypeID] = @XT_DefindcodeTypeID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000M5,1,0,true,false )
           ,new CursorDef("BC000M6", "INSERT INTO [XT_DefindcodeType]([XT_DefindcodeTypeName], [XT_DefindcodeTypeIsShow]) VALUES(@XT_DefindcodeTypeName, @XT_DefindcodeTypeIsShow); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmBC000M6)
           ,new CursorDef("BC000M7", "UPDATE [XT_DefindcodeType] SET [XT_DefindcodeTypeName]=@XT_DefindcodeTypeName, [XT_DefindcodeTypeIsShow]=@XT_DefindcodeTypeIsShow  WHERE [XT_DefindcodeTypeID] = @XT_DefindcodeTypeID", GxErrorMask.GX_NOMASK,prmBC000M7)
           ,new CursorDef("BC000M8", "DELETE FROM [XT_DefindcodeType]  WHERE [XT_DefindcodeTypeID] = @XT_DefindcodeTypeID", GxErrorMask.GX_NOMASK,prmBC000M8)
           ,new CursorDef("BC000M9", "SELECT TOP 1 [XT_DefineCodeID] FROM [XT_DefineCode] WITH (NOLOCK) WHERE [XT_DefindcodeTypeID] = @XT_DefindcodeTypeID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000M9,1,0,true,true )
           ,new CursorDef("BC000M10", "SELECT TM1.[XT_DefindcodeTypeID], TM1.[XT_DefindcodeTypeName], TM1.[XT_DefindcodeTypeIsShow] FROM [XT_DefindcodeType] TM1 WITH (NOLOCK) WHERE TM1.[XT_DefindcodeTypeID] = @XT_DefindcodeTypeID ORDER BY TM1.[XT_DefindcodeTypeID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000M10,100,0,true,false )
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
              ((short[]) buf[3])[0] = rslt.getShort(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((short[]) buf[3])[0] = rslt.getShort(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              return;
           case 2 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((short[]) buf[3])[0] = rslt.getShort(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              return;
           case 3 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 4 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 7 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 8 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((short[]) buf[3])[0] = rslt.getShort(3) ;
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
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 3 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 4 :
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
                 stmt.setNull( 2 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(2, (short)parms[3]);
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
                 stmt.setNull( 2 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(2, (short)parms[3]);
              }
              stmt.SetParameter(3, (long)parms[4]);
              return;
           case 6 :
              stmt.SetParameter(1, (long)parms[0]);
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
