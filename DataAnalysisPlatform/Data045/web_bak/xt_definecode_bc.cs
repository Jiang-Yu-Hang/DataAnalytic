/*
               File: XT_DefineCode_BC
        Description: 数据字典数据
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:37:18.27
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
   public class xt_definecode_bc : GXHttpHandler, IGxSilentTrn
   {
      public xt_definecode_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public xt_definecode_bc( IGxContext context )
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
         ReadRow0N24( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey0N24( ) ;
         standaloneModal( ) ;
         AddRow0N24( ) ;
         Gx_mode = "INS";
         return  ;
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E110N2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               Z167XT_DefineCodeID = A167XT_DefineCodeID;
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

      protected void CONFIRM_0N0( )
      {
         BeforeValidate0N24( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0N24( ) ;
            }
            else
            {
               CheckExtendedTable0N24( ) ;
               if ( AnyError == 0 )
               {
                  ZM0N24( 10) ;
               }
               CloseExtendedTableCursors0N24( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void E120N2( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV8WWPContext) ;
         AV9IsAuthorized = true;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_DefineCode", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_DefineCode", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_DefineCode", out  GXt_boolean1) ;
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
               if ( StringUtil.StrCmp(AV14TrnContextAtt.gxTpr_Attributename, "XT_DefindcodeTypeID") == 0 )
               {
                  AV13Insert_XT_DefindcodeTypeID = (long)(NumberUtil.Val( AV14TrnContextAtt.gxTpr_Attributevalue, "."));
               }
               AV16GXV1 = (int)(AV16GXV1+1);
            }
         }
      }

      protected void E110N2( )
      {
         /* After Trn Routine */
      }

      protected void ZM0N24( short GX_JID )
      {
         if ( ( GX_JID == 9 ) || ( GX_JID == 0 ) )
         {
            Z168XT_DefineCodeName = A168XT_DefineCodeName;
            Z171XT_DefineCodeOrder = A171XT_DefineCodeOrder;
            Z431XT_TypeCode = A431XT_TypeCode;
            Z432XT_TenantCode = A432XT_TenantCode;
            Z510XT_DefineCodeIntialType = A510XT_DefineCodeIntialType;
            Z165XT_DefindcodeTypeID = A165XT_DefindcodeTypeID;
         }
         if ( ( GX_JID == 10 ) || ( GX_JID == 0 ) )
         {
            Z166XT_DefindcodeTypeName = A166XT_DefindcodeTypeName;
         }
         if ( GX_JID == -9 )
         {
            Z167XT_DefineCodeID = A167XT_DefineCodeID;
            Z168XT_DefineCodeName = A168XT_DefineCodeName;
            Z171XT_DefineCodeOrder = A171XT_DefineCodeOrder;
            Z431XT_TypeCode = A431XT_TypeCode;
            Z432XT_TenantCode = A432XT_TenantCode;
            Z510XT_DefineCodeIntialType = A510XT_DefineCodeIntialType;
            Z165XT_DefindcodeTypeID = A165XT_DefindcodeTypeID;
            Z166XT_DefindcodeTypeName = A166XT_DefindcodeTypeName;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load0N24( )
      {
         /* Using cursor BC000N5 */
         pr_default.execute(3, new Object[] {A167XT_DefineCodeID});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound24 = 1;
            A168XT_DefineCodeName = BC000N5_A168XT_DefineCodeName[0];
            n168XT_DefineCodeName = BC000N5_n168XT_DefineCodeName[0];
            A166XT_DefindcodeTypeName = BC000N5_A166XT_DefindcodeTypeName[0];
            n166XT_DefindcodeTypeName = BC000N5_n166XT_DefindcodeTypeName[0];
            A171XT_DefineCodeOrder = BC000N5_A171XT_DefineCodeOrder[0];
            n171XT_DefineCodeOrder = BC000N5_n171XT_DefineCodeOrder[0];
            A431XT_TypeCode = BC000N5_A431XT_TypeCode[0];
            n431XT_TypeCode = BC000N5_n431XT_TypeCode[0];
            A432XT_TenantCode = BC000N5_A432XT_TenantCode[0];
            n432XT_TenantCode = BC000N5_n432XT_TenantCode[0];
            A510XT_DefineCodeIntialType = BC000N5_A510XT_DefineCodeIntialType[0];
            n510XT_DefineCodeIntialType = BC000N5_n510XT_DefineCodeIntialType[0];
            A165XT_DefindcodeTypeID = BC000N5_A165XT_DefindcodeTypeID[0];
            ZM0N24( -9) ;
         }
         pr_default.close(3);
         OnLoadActions0N24( ) ;
      }

      protected void OnLoadActions0N24( )
      {
         AV15Pgmname = "XT_DefineCode_BC";
      }

      protected void CheckExtendedTable0N24( )
      {
         standaloneModal( ) ;
         AV15Pgmname = "XT_DefineCode_BC";
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A168XT_DefineCodeName)) )
         {
            GX_msglist.addItem("数据字典名称是必须填写的。", 1, "");
            AnyError = 1;
         }
         /* Using cursor BC000N4 */
         pr_default.execute(2, new Object[] {A165XT_DefindcodeTypeID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("不匹配'������������������'", "ForeignKeyNotFound", 1, "XT_DEFINDCODETYPEID");
            AnyError = 1;
         }
         A166XT_DefindcodeTypeName = BC000N4_A166XT_DefindcodeTypeName[0];
         n166XT_DefindcodeTypeName = BC000N4_n166XT_DefindcodeTypeName[0];
         pr_default.close(2);
         if ( (0==A165XT_DefindcodeTypeID) )
         {
            GX_msglist.addItem("数据字典类型主键是必须填写的。", 1, "");
            AnyError = 1;
         }
         if ( ! ( ( A510XT_DefineCodeIntialType == 1 ) || ( A510XT_DefineCodeIntialType == 2 ) || (0==A510XT_DefineCodeIntialType) ) )
         {
            GX_msglist.addItem("域������������������������超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
      }

      protected void CloseExtendedTableCursors0N24( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0N24( )
      {
         /* Using cursor BC000N6 */
         pr_default.execute(4, new Object[] {A167XT_DefineCodeID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound24 = 1;
         }
         else
         {
            RcdFound24 = 0;
         }
         pr_default.close(4);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC000N3 */
         pr_default.execute(1, new Object[] {A167XT_DefineCodeID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0N24( 9) ;
            RcdFound24 = 1;
            A167XT_DefineCodeID = BC000N3_A167XT_DefineCodeID[0];
            A168XT_DefineCodeName = BC000N3_A168XT_DefineCodeName[0];
            n168XT_DefineCodeName = BC000N3_n168XT_DefineCodeName[0];
            A171XT_DefineCodeOrder = BC000N3_A171XT_DefineCodeOrder[0];
            n171XT_DefineCodeOrder = BC000N3_n171XT_DefineCodeOrder[0];
            A431XT_TypeCode = BC000N3_A431XT_TypeCode[0];
            n431XT_TypeCode = BC000N3_n431XT_TypeCode[0];
            A432XT_TenantCode = BC000N3_A432XT_TenantCode[0];
            n432XT_TenantCode = BC000N3_n432XT_TenantCode[0];
            A510XT_DefineCodeIntialType = BC000N3_A510XT_DefineCodeIntialType[0];
            n510XT_DefineCodeIntialType = BC000N3_n510XT_DefineCodeIntialType[0];
            A165XT_DefindcodeTypeID = BC000N3_A165XT_DefindcodeTypeID[0];
            Z167XT_DefineCodeID = A167XT_DefineCodeID;
            sMode24 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load0N24( ) ;
            if ( AnyError == 1 )
            {
               RcdFound24 = 0;
               InitializeNonKey0N24( ) ;
            }
            Gx_mode = sMode24;
         }
         else
         {
            RcdFound24 = 0;
            InitializeNonKey0N24( ) ;
            sMode24 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode24;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0N24( ) ;
         if ( RcdFound24 == 0 )
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
         CONFIRM_0N0( ) ;
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

      protected void CheckOptimisticConcurrency0N24( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC000N2 */
            pr_default.execute(0, new Object[] {A167XT_DefineCodeID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"XT_DefineCode"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z168XT_DefineCodeName, BC000N2_A168XT_DefineCodeName[0]) != 0 ) || ( Z171XT_DefineCodeOrder != BC000N2_A171XT_DefineCodeOrder[0] ) || ( StringUtil.StrCmp(Z431XT_TypeCode, BC000N2_A431XT_TypeCode[0]) != 0 ) || ( StringUtil.StrCmp(Z432XT_TenantCode, BC000N2_A432XT_TenantCode[0]) != 0 ) || ( Z510XT_DefineCodeIntialType != BC000N2_A510XT_DefineCodeIntialType[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z165XT_DefindcodeTypeID != BC000N2_A165XT_DefindcodeTypeID[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"XT_DefineCode"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0N24( )
      {
         BeforeValidate0N24( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0N24( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0N24( 0) ;
            CheckOptimisticConcurrency0N24( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0N24( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0N24( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000N7 */
                     pr_default.execute(5, new Object[] {n168XT_DefineCodeName, A168XT_DefineCodeName, n171XT_DefineCodeOrder, A171XT_DefineCodeOrder, n431XT_TypeCode, A431XT_TypeCode, n432XT_TenantCode, A432XT_TenantCode, n510XT_DefineCodeIntialType, A510XT_DefineCodeIntialType, A165XT_DefindcodeTypeID});
                     A167XT_DefineCodeID = BC000N7_A167XT_DefineCodeID[0];
                     pr_default.close(5);
                     dsDefault.SmartCacheProvider.SetUpdated("XT_DefineCode") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        new zutil_recordlog(context ).execute(  A168XT_DefineCodeName,  "数据字典信息",  "Create",  1) ;
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
               Load0N24( ) ;
            }
            EndLevel0N24( ) ;
         }
         CloseExtendedTableCursors0N24( ) ;
      }

      protected void Update0N24( )
      {
         BeforeValidate0N24( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0N24( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0N24( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0N24( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0N24( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000N8 */
                     pr_default.execute(6, new Object[] {n168XT_DefineCodeName, A168XT_DefineCodeName, n171XT_DefineCodeOrder, A171XT_DefineCodeOrder, n431XT_TypeCode, A431XT_TypeCode, n432XT_TenantCode, A432XT_TenantCode, n510XT_DefineCodeIntialType, A510XT_DefineCodeIntialType, A165XT_DefindcodeTypeID, A167XT_DefineCodeID});
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("XT_DefineCode") ;
                     if ( (pr_default.getStatus(6) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"XT_DefineCode"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0N24( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        new zutil_recordlog(context ).execute(  A168XT_DefineCodeName,  "数据字典信息",  "Update",  1) ;
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
            EndLevel0N24( ) ;
         }
         CloseExtendedTableCursors0N24( ) ;
      }

      protected void DeferredUpdate0N24( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate0N24( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0N24( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0N24( ) ;
            AfterConfirm0N24( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0N24( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC000N9 */
                  pr_default.execute(7, new Object[] {A167XT_DefineCodeID});
                  pr_default.close(7);
                  dsDefault.SmartCacheProvider.SetUpdated("XT_DefineCode") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     new zutil_recordlog(context ).execute(  A168XT_DefineCodeName,  "数据字典信息",  "Delete",  1) ;
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
         sMode24 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel0N24( ) ;
         Gx_mode = sMode24;
      }

      protected void OnDeleteControls0N24( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV15Pgmname = "XT_DefineCode_BC";
            /* Using cursor BC000N10 */
            pr_default.execute(8, new Object[] {A165XT_DefindcodeTypeID});
            A166XT_DefindcodeTypeName = BC000N10_A166XT_DefindcodeTypeName[0];
            n166XT_DefindcodeTypeName = BC000N10_n166XT_DefindcodeTypeName[0];
            pr_default.close(8);
         }
      }

      protected void EndLevel0N24( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0N24( ) ;
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

      public void ScanKeyStart0N24( )
      {
         /* Scan By routine */
         /* Using cursor BC000N11 */
         pr_default.execute(9, new Object[] {A167XT_DefineCodeID});
         RcdFound24 = 0;
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound24 = 1;
            A167XT_DefineCodeID = BC000N11_A167XT_DefineCodeID[0];
            A168XT_DefineCodeName = BC000N11_A168XT_DefineCodeName[0];
            n168XT_DefineCodeName = BC000N11_n168XT_DefineCodeName[0];
            A166XT_DefindcodeTypeName = BC000N11_A166XT_DefindcodeTypeName[0];
            n166XT_DefindcodeTypeName = BC000N11_n166XT_DefindcodeTypeName[0];
            A171XT_DefineCodeOrder = BC000N11_A171XT_DefineCodeOrder[0];
            n171XT_DefineCodeOrder = BC000N11_n171XT_DefineCodeOrder[0];
            A431XT_TypeCode = BC000N11_A431XT_TypeCode[0];
            n431XT_TypeCode = BC000N11_n431XT_TypeCode[0];
            A432XT_TenantCode = BC000N11_A432XT_TenantCode[0];
            n432XT_TenantCode = BC000N11_n432XT_TenantCode[0];
            A510XT_DefineCodeIntialType = BC000N11_A510XT_DefineCodeIntialType[0];
            n510XT_DefineCodeIntialType = BC000N11_n510XT_DefineCodeIntialType[0];
            A165XT_DefindcodeTypeID = BC000N11_A165XT_DefindcodeTypeID[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext0N24( )
      {
         /* Scan next routine */
         pr_default.readNext(9);
         RcdFound24 = 0;
         ScanKeyLoad0N24( ) ;
      }

      protected void ScanKeyLoad0N24( )
      {
         sMode24 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound24 = 1;
            A167XT_DefineCodeID = BC000N11_A167XT_DefineCodeID[0];
            A168XT_DefineCodeName = BC000N11_A168XT_DefineCodeName[0];
            n168XT_DefineCodeName = BC000N11_n168XT_DefineCodeName[0];
            A166XT_DefindcodeTypeName = BC000N11_A166XT_DefindcodeTypeName[0];
            n166XT_DefindcodeTypeName = BC000N11_n166XT_DefindcodeTypeName[0];
            A171XT_DefineCodeOrder = BC000N11_A171XT_DefineCodeOrder[0];
            n171XT_DefineCodeOrder = BC000N11_n171XT_DefineCodeOrder[0];
            A431XT_TypeCode = BC000N11_A431XT_TypeCode[0];
            n431XT_TypeCode = BC000N11_n431XT_TypeCode[0];
            A432XT_TenantCode = BC000N11_A432XT_TenantCode[0];
            n432XT_TenantCode = BC000N11_n432XT_TenantCode[0];
            A510XT_DefineCodeIntialType = BC000N11_A510XT_DefineCodeIntialType[0];
            n510XT_DefineCodeIntialType = BC000N11_n510XT_DefineCodeIntialType[0];
            A165XT_DefindcodeTypeID = BC000N11_A165XT_DefindcodeTypeID[0];
         }
         Gx_mode = sMode24;
      }

      protected void ScanKeyEnd0N24( )
      {
         pr_default.close(9);
      }

      protected void AfterConfirm0N24( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0N24( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0N24( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0N24( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0N24( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0N24( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0N24( )
      {
      }

      protected void send_integrity_lvl_hashes0N24( )
      {
      }

      protected void AddRow0N24( )
      {
         VarsToRow24( bcXT_DefineCode) ;
      }

      protected void ReadRow0N24( )
      {
         RowToVars24( bcXT_DefineCode, 1) ;
      }

      protected void InitializeNonKey0N24( )
      {
         A168XT_DefineCodeName = "";
         n168XT_DefineCodeName = false;
         A165XT_DefindcodeTypeID = 0;
         A166XT_DefindcodeTypeName = "";
         n166XT_DefindcodeTypeName = false;
         A171XT_DefineCodeOrder = 0;
         n171XT_DefineCodeOrder = false;
         A431XT_TypeCode = "";
         n431XT_TypeCode = false;
         A432XT_TenantCode = "";
         n432XT_TenantCode = false;
         A510XT_DefineCodeIntialType = 0;
         n510XT_DefineCodeIntialType = false;
         Z168XT_DefineCodeName = "";
         Z171XT_DefineCodeOrder = 0;
         Z431XT_TypeCode = "";
         Z432XT_TenantCode = "";
         Z510XT_DefineCodeIntialType = 0;
         Z165XT_DefindcodeTypeID = 0;
      }

      protected void InitAll0N24( )
      {
         A167XT_DefineCodeID = 0;
         InitializeNonKey0N24( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow24( SdtXT_DefineCode obj24 )
      {
         obj24.gxTpr_Mode = Gx_mode;
         obj24.gxTpr_Xt_definecodename = A168XT_DefineCodeName;
         obj24.gxTpr_Xt_defindcodetypeid = A165XT_DefindcodeTypeID;
         obj24.gxTpr_Xt_defindcodetypename = A166XT_DefindcodeTypeName;
         obj24.gxTpr_Xt_definecodeorder = A171XT_DefineCodeOrder;
         obj24.gxTpr_Xt_typecode = A431XT_TypeCode;
         obj24.gxTpr_Xt_tenantcode = A432XT_TenantCode;
         obj24.gxTpr_Xt_definecodeintialtype = A510XT_DefineCodeIntialType;
         obj24.gxTpr_Xt_definecodeid = A167XT_DefineCodeID;
         obj24.gxTpr_Xt_definecodeid_Z = Z167XT_DefineCodeID;
         obj24.gxTpr_Xt_definecodename_Z = Z168XT_DefineCodeName;
         obj24.gxTpr_Xt_defindcodetypeid_Z = Z165XT_DefindcodeTypeID;
         obj24.gxTpr_Xt_defindcodetypename_Z = Z166XT_DefindcodeTypeName;
         obj24.gxTpr_Xt_definecodeorder_Z = Z171XT_DefineCodeOrder;
         obj24.gxTpr_Xt_typecode_Z = Z431XT_TypeCode;
         obj24.gxTpr_Xt_tenantcode_Z = Z432XT_TenantCode;
         obj24.gxTpr_Xt_definecodeintialtype_Z = Z510XT_DefineCodeIntialType;
         obj24.gxTpr_Xt_definecodename_N = (short)(Convert.ToInt16(n168XT_DefineCodeName));
         obj24.gxTpr_Xt_defindcodetypename_N = (short)(Convert.ToInt16(n166XT_DefindcodeTypeName));
         obj24.gxTpr_Xt_definecodeorder_N = (short)(Convert.ToInt16(n171XT_DefineCodeOrder));
         obj24.gxTpr_Xt_typecode_N = (short)(Convert.ToInt16(n431XT_TypeCode));
         obj24.gxTpr_Xt_tenantcode_N = (short)(Convert.ToInt16(n432XT_TenantCode));
         obj24.gxTpr_Xt_definecodeintialtype_N = (short)(Convert.ToInt16(n510XT_DefineCodeIntialType));
         obj24.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow24( SdtXT_DefineCode obj24 )
      {
         obj24.gxTpr_Xt_definecodeid = A167XT_DefineCodeID;
         return  ;
      }

      public void RowToVars24( SdtXT_DefineCode obj24 ,
                               int forceLoad )
      {
         Gx_mode = obj24.gxTpr_Mode;
         A168XT_DefineCodeName = obj24.gxTpr_Xt_definecodename;
         n168XT_DefineCodeName = false;
         A165XT_DefindcodeTypeID = obj24.gxTpr_Xt_defindcodetypeid;
         A166XT_DefindcodeTypeName = obj24.gxTpr_Xt_defindcodetypename;
         n166XT_DefindcodeTypeName = false;
         A171XT_DefineCodeOrder = obj24.gxTpr_Xt_definecodeorder;
         n171XT_DefineCodeOrder = false;
         A431XT_TypeCode = obj24.gxTpr_Xt_typecode;
         n431XT_TypeCode = false;
         A432XT_TenantCode = obj24.gxTpr_Xt_tenantcode;
         n432XT_TenantCode = false;
         A510XT_DefineCodeIntialType = obj24.gxTpr_Xt_definecodeintialtype;
         n510XT_DefineCodeIntialType = false;
         A167XT_DefineCodeID = obj24.gxTpr_Xt_definecodeid;
         Z167XT_DefineCodeID = obj24.gxTpr_Xt_definecodeid_Z;
         Z168XT_DefineCodeName = obj24.gxTpr_Xt_definecodename_Z;
         Z165XT_DefindcodeTypeID = obj24.gxTpr_Xt_defindcodetypeid_Z;
         Z166XT_DefindcodeTypeName = obj24.gxTpr_Xt_defindcodetypename_Z;
         Z171XT_DefineCodeOrder = obj24.gxTpr_Xt_definecodeorder_Z;
         Z431XT_TypeCode = obj24.gxTpr_Xt_typecode_Z;
         Z432XT_TenantCode = obj24.gxTpr_Xt_tenantcode_Z;
         Z510XT_DefineCodeIntialType = obj24.gxTpr_Xt_definecodeintialtype_Z;
         n168XT_DefineCodeName = (bool)(Convert.ToBoolean(obj24.gxTpr_Xt_definecodename_N));
         n166XT_DefindcodeTypeName = (bool)(Convert.ToBoolean(obj24.gxTpr_Xt_defindcodetypename_N));
         n171XT_DefineCodeOrder = (bool)(Convert.ToBoolean(obj24.gxTpr_Xt_definecodeorder_N));
         n431XT_TypeCode = (bool)(Convert.ToBoolean(obj24.gxTpr_Xt_typecode_N));
         n432XT_TenantCode = (bool)(Convert.ToBoolean(obj24.gxTpr_Xt_tenantcode_N));
         n510XT_DefineCodeIntialType = (bool)(Convert.ToBoolean(obj24.gxTpr_Xt_definecodeintialtype_N));
         Gx_mode = obj24.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A167XT_DefineCodeID = (long)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey0N24( ) ;
         ScanKeyStart0N24( ) ;
         if ( RcdFound24 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z167XT_DefineCodeID = A167XT_DefineCodeID;
         }
         ZM0N24( -9) ;
         OnLoadActions0N24( ) ;
         AddRow0N24( ) ;
         ScanKeyEnd0N24( ) ;
         if ( RcdFound24 == 0 )
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
         RowToVars24( bcXT_DefineCode, 0) ;
         ScanKeyStart0N24( ) ;
         if ( RcdFound24 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z167XT_DefineCodeID = A167XT_DefineCodeID;
         }
         ZM0N24( -9) ;
         OnLoadActions0N24( ) ;
         AddRow0N24( ) ;
         ScanKeyEnd0N24( ) ;
         if ( RcdFound24 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey0N24( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert0N24( ) ;
         }
         else
         {
            if ( RcdFound24 == 1 )
            {
               if ( A167XT_DefineCodeID != Z167XT_DefineCodeID )
               {
                  A167XT_DefineCodeID = Z167XT_DefineCodeID;
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
                  Update0N24( ) ;
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
                  if ( A167XT_DefineCodeID != Z167XT_DefineCodeID )
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
                        Insert0N24( ) ;
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
                        Insert0N24( ) ;
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
         RowToVars24( bcXT_DefineCode, 0) ;
         SaveImpl( ) ;
         VarsToRow24( bcXT_DefineCode) ;
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
         RowToVars24( bcXT_DefineCode, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert0N24( ) ;
         AfterTrn( ) ;
         VarsToRow24( bcXT_DefineCode) ;
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
            SdtXT_DefineCode auxBC = new SdtXT_DefineCode(context) ;
            auxBC.Load(A167XT_DefineCodeID);
            auxBC.UpdateDirties(bcXT_DefineCode);
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
         RowToVars24( bcXT_DefineCode, 0) ;
         UpdateImpl( ) ;
         VarsToRow24( bcXT_DefineCode) ;
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
         RowToVars24( bcXT_DefineCode, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert0N24( ) ;
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
         VarsToRow24( bcXT_DefineCode) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars24( bcXT_DefineCode, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey0N24( ) ;
         if ( RcdFound24 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A167XT_DefineCodeID != Z167XT_DefineCodeID )
            {
               A167XT_DefineCodeID = Z167XT_DefineCodeID;
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
            if ( A167XT_DefineCodeID != Z167XT_DefineCodeID )
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
         pr_default.close(8);
         context.RollbackDataStores("xt_definecode_bc",pr_default);
         VarsToRow24( bcXT_DefineCode) ;
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
         Gx_mode = bcXT_DefineCode.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcXT_DefineCode.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcXT_DefineCode )
         {
            bcXT_DefineCode = (SdtXT_DefineCode)(sdt);
            if ( StringUtil.StrCmp(bcXT_DefineCode.gxTpr_Mode, "") == 0 )
            {
               bcXT_DefineCode.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow24( bcXT_DefineCode) ;
            }
            else
            {
               RowToVars24( bcXT_DefineCode, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcXT_DefineCode.gxTpr_Mode, "") == 0 )
            {
               bcXT_DefineCode.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars24( bcXT_DefineCode, 1) ;
         return  ;
      }

      public SdtXT_DefineCode XT_DefineCode_BC
      {
         get {
            return bcXT_DefineCode ;
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
         pr_default.close(8);
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
         Z168XT_DefineCodeName = "";
         A168XT_DefineCodeName = "";
         Z431XT_TypeCode = "";
         A431XT_TypeCode = "";
         Z432XT_TenantCode = "";
         A432XT_TenantCode = "";
         Z166XT_DefindcodeTypeName = "";
         A166XT_DefindcodeTypeName = "";
         BC000N5_A167XT_DefineCodeID = new long[1] ;
         BC000N5_A168XT_DefineCodeName = new String[] {""} ;
         BC000N5_n168XT_DefineCodeName = new bool[] {false} ;
         BC000N5_A166XT_DefindcodeTypeName = new String[] {""} ;
         BC000N5_n166XT_DefindcodeTypeName = new bool[] {false} ;
         BC000N5_A171XT_DefineCodeOrder = new short[1] ;
         BC000N5_n171XT_DefineCodeOrder = new bool[] {false} ;
         BC000N5_A431XT_TypeCode = new String[] {""} ;
         BC000N5_n431XT_TypeCode = new bool[] {false} ;
         BC000N5_A432XT_TenantCode = new String[] {""} ;
         BC000N5_n432XT_TenantCode = new bool[] {false} ;
         BC000N5_A510XT_DefineCodeIntialType = new short[1] ;
         BC000N5_n510XT_DefineCodeIntialType = new bool[] {false} ;
         BC000N5_A165XT_DefindcodeTypeID = new long[1] ;
         BC000N4_A166XT_DefindcodeTypeName = new String[] {""} ;
         BC000N4_n166XT_DefindcodeTypeName = new bool[] {false} ;
         BC000N6_A167XT_DefineCodeID = new long[1] ;
         BC000N3_A167XT_DefineCodeID = new long[1] ;
         BC000N3_A168XT_DefineCodeName = new String[] {""} ;
         BC000N3_n168XT_DefineCodeName = new bool[] {false} ;
         BC000N3_A171XT_DefineCodeOrder = new short[1] ;
         BC000N3_n171XT_DefineCodeOrder = new bool[] {false} ;
         BC000N3_A431XT_TypeCode = new String[] {""} ;
         BC000N3_n431XT_TypeCode = new bool[] {false} ;
         BC000N3_A432XT_TenantCode = new String[] {""} ;
         BC000N3_n432XT_TenantCode = new bool[] {false} ;
         BC000N3_A510XT_DefineCodeIntialType = new short[1] ;
         BC000N3_n510XT_DefineCodeIntialType = new bool[] {false} ;
         BC000N3_A165XT_DefindcodeTypeID = new long[1] ;
         sMode24 = "";
         BC000N2_A167XT_DefineCodeID = new long[1] ;
         BC000N2_A168XT_DefineCodeName = new String[] {""} ;
         BC000N2_n168XT_DefineCodeName = new bool[] {false} ;
         BC000N2_A171XT_DefineCodeOrder = new short[1] ;
         BC000N2_n171XT_DefineCodeOrder = new bool[] {false} ;
         BC000N2_A431XT_TypeCode = new String[] {""} ;
         BC000N2_n431XT_TypeCode = new bool[] {false} ;
         BC000N2_A432XT_TenantCode = new String[] {""} ;
         BC000N2_n432XT_TenantCode = new bool[] {false} ;
         BC000N2_A510XT_DefineCodeIntialType = new short[1] ;
         BC000N2_n510XT_DefineCodeIntialType = new bool[] {false} ;
         BC000N2_A165XT_DefindcodeTypeID = new long[1] ;
         BC000N7_A167XT_DefineCodeID = new long[1] ;
         BC000N10_A166XT_DefindcodeTypeName = new String[] {""} ;
         BC000N10_n166XT_DefindcodeTypeName = new bool[] {false} ;
         BC000N11_A167XT_DefineCodeID = new long[1] ;
         BC000N11_A168XT_DefineCodeName = new String[] {""} ;
         BC000N11_n168XT_DefineCodeName = new bool[] {false} ;
         BC000N11_A166XT_DefindcodeTypeName = new String[] {""} ;
         BC000N11_n166XT_DefindcodeTypeName = new bool[] {false} ;
         BC000N11_A171XT_DefineCodeOrder = new short[1] ;
         BC000N11_n171XT_DefineCodeOrder = new bool[] {false} ;
         BC000N11_A431XT_TypeCode = new String[] {""} ;
         BC000N11_n431XT_TypeCode = new bool[] {false} ;
         BC000N11_A432XT_TenantCode = new String[] {""} ;
         BC000N11_n432XT_TenantCode = new bool[] {false} ;
         BC000N11_A510XT_DefineCodeIntialType = new short[1] ;
         BC000N11_n510XT_DefineCodeIntialType = new bool[] {false} ;
         BC000N11_A165XT_DefindcodeTypeID = new long[1] ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.xt_definecode_bc__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.xt_definecode_bc__default(),
            new Object[][] {
                new Object[] {
               BC000N2_A167XT_DefineCodeID, BC000N2_A168XT_DefineCodeName, BC000N2_n168XT_DefineCodeName, BC000N2_A171XT_DefineCodeOrder, BC000N2_n171XT_DefineCodeOrder, BC000N2_A431XT_TypeCode, BC000N2_n431XT_TypeCode, BC000N2_A432XT_TenantCode, BC000N2_n432XT_TenantCode, BC000N2_A510XT_DefineCodeIntialType,
               BC000N2_n510XT_DefineCodeIntialType, BC000N2_A165XT_DefindcodeTypeID
               }
               , new Object[] {
               BC000N3_A167XT_DefineCodeID, BC000N3_A168XT_DefineCodeName, BC000N3_n168XT_DefineCodeName, BC000N3_A171XT_DefineCodeOrder, BC000N3_n171XT_DefineCodeOrder, BC000N3_A431XT_TypeCode, BC000N3_n431XT_TypeCode, BC000N3_A432XT_TenantCode, BC000N3_n432XT_TenantCode, BC000N3_A510XT_DefineCodeIntialType,
               BC000N3_n510XT_DefineCodeIntialType, BC000N3_A165XT_DefindcodeTypeID
               }
               , new Object[] {
               BC000N4_A166XT_DefindcodeTypeName, BC000N4_n166XT_DefindcodeTypeName
               }
               , new Object[] {
               BC000N5_A167XT_DefineCodeID, BC000N5_A168XT_DefineCodeName, BC000N5_n168XT_DefineCodeName, BC000N5_A166XT_DefindcodeTypeName, BC000N5_n166XT_DefindcodeTypeName, BC000N5_A171XT_DefineCodeOrder, BC000N5_n171XT_DefineCodeOrder, BC000N5_A431XT_TypeCode, BC000N5_n431XT_TypeCode, BC000N5_A432XT_TenantCode,
               BC000N5_n432XT_TenantCode, BC000N5_A510XT_DefineCodeIntialType, BC000N5_n510XT_DefineCodeIntialType, BC000N5_A165XT_DefindcodeTypeID
               }
               , new Object[] {
               BC000N6_A167XT_DefineCodeID
               }
               , new Object[] {
               BC000N7_A167XT_DefineCodeID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000N10_A166XT_DefindcodeTypeName, BC000N10_n166XT_DefindcodeTypeName
               }
               , new Object[] {
               BC000N11_A167XT_DefineCodeID, BC000N11_A168XT_DefineCodeName, BC000N11_n168XT_DefineCodeName, BC000N11_A166XT_DefindcodeTypeName, BC000N11_n166XT_DefindcodeTypeName, BC000N11_A171XT_DefineCodeOrder, BC000N11_n171XT_DefineCodeOrder, BC000N11_A431XT_TypeCode, BC000N11_n431XT_TypeCode, BC000N11_A432XT_TenantCode,
               BC000N11_n432XT_TenantCode, BC000N11_A510XT_DefineCodeIntialType, BC000N11_n510XT_DefineCodeIntialType, BC000N11_A165XT_DefindcodeTypeID
               }
            }
         );
         AV15Pgmname = "XT_DefineCode_BC";
         INITTRN();
         /* Execute Start event if defined. */
         /* Execute user event: Start */
         E120N2 ();
         standaloneNotModal( ) ;
      }

      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short GX_JID ;
      private short Z171XT_DefineCodeOrder ;
      private short A171XT_DefineCodeOrder ;
      private short Z510XT_DefineCodeIntialType ;
      private short A510XT_DefineCodeIntialType ;
      private short RcdFound24 ;
      private int trnEnded ;
      private int AV16GXV1 ;
      private long Z167XT_DefineCodeID ;
      private long A167XT_DefineCodeID ;
      private long AV13Insert_XT_DefindcodeTypeID ;
      private long Z165XT_DefindcodeTypeID ;
      private long A165XT_DefindcodeTypeID ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String AV15Pgmname ;
      private String sMode24 ;
      private bool AV9IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool n168XT_DefineCodeName ;
      private bool n166XT_DefindcodeTypeName ;
      private bool n171XT_DefineCodeOrder ;
      private bool n431XT_TypeCode ;
      private bool n432XT_TenantCode ;
      private bool n510XT_DefineCodeIntialType ;
      private bool Gx_longc ;
      private String Z168XT_DefineCodeName ;
      private String A168XT_DefineCodeName ;
      private String Z431XT_TypeCode ;
      private String A431XT_TypeCode ;
      private String Z432XT_TenantCode ;
      private String A432XT_TenantCode ;
      private String Z166XT_DefindcodeTypeName ;
      private String A166XT_DefindcodeTypeName ;
      private IGxSession AV12WebSession ;
      private SdtXT_DefineCode bcXT_DefineCode ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] BC000N5_A167XT_DefineCodeID ;
      private String[] BC000N5_A168XT_DefineCodeName ;
      private bool[] BC000N5_n168XT_DefineCodeName ;
      private String[] BC000N5_A166XT_DefindcodeTypeName ;
      private bool[] BC000N5_n166XT_DefindcodeTypeName ;
      private short[] BC000N5_A171XT_DefineCodeOrder ;
      private bool[] BC000N5_n171XT_DefineCodeOrder ;
      private String[] BC000N5_A431XT_TypeCode ;
      private bool[] BC000N5_n431XT_TypeCode ;
      private String[] BC000N5_A432XT_TenantCode ;
      private bool[] BC000N5_n432XT_TenantCode ;
      private short[] BC000N5_A510XT_DefineCodeIntialType ;
      private bool[] BC000N5_n510XT_DefineCodeIntialType ;
      private long[] BC000N5_A165XT_DefindcodeTypeID ;
      private String[] BC000N4_A166XT_DefindcodeTypeName ;
      private bool[] BC000N4_n166XT_DefindcodeTypeName ;
      private long[] BC000N6_A167XT_DefineCodeID ;
      private long[] BC000N3_A167XT_DefineCodeID ;
      private String[] BC000N3_A168XT_DefineCodeName ;
      private bool[] BC000N3_n168XT_DefineCodeName ;
      private short[] BC000N3_A171XT_DefineCodeOrder ;
      private bool[] BC000N3_n171XT_DefineCodeOrder ;
      private String[] BC000N3_A431XT_TypeCode ;
      private bool[] BC000N3_n431XT_TypeCode ;
      private String[] BC000N3_A432XT_TenantCode ;
      private bool[] BC000N3_n432XT_TenantCode ;
      private short[] BC000N3_A510XT_DefineCodeIntialType ;
      private bool[] BC000N3_n510XT_DefineCodeIntialType ;
      private long[] BC000N3_A165XT_DefindcodeTypeID ;
      private long[] BC000N2_A167XT_DefineCodeID ;
      private String[] BC000N2_A168XT_DefineCodeName ;
      private bool[] BC000N2_n168XT_DefineCodeName ;
      private short[] BC000N2_A171XT_DefineCodeOrder ;
      private bool[] BC000N2_n171XT_DefineCodeOrder ;
      private String[] BC000N2_A431XT_TypeCode ;
      private bool[] BC000N2_n431XT_TypeCode ;
      private String[] BC000N2_A432XT_TenantCode ;
      private bool[] BC000N2_n432XT_TenantCode ;
      private short[] BC000N2_A510XT_DefineCodeIntialType ;
      private bool[] BC000N2_n510XT_DefineCodeIntialType ;
      private long[] BC000N2_A165XT_DefindcodeTypeID ;
      private long[] BC000N7_A167XT_DefineCodeID ;
      private String[] BC000N10_A166XT_DefindcodeTypeName ;
      private bool[] BC000N10_n166XT_DefindcodeTypeName ;
      private long[] BC000N11_A167XT_DefineCodeID ;
      private String[] BC000N11_A168XT_DefineCodeName ;
      private bool[] BC000N11_n168XT_DefineCodeName ;
      private String[] BC000N11_A166XT_DefindcodeTypeName ;
      private bool[] BC000N11_n166XT_DefindcodeTypeName ;
      private short[] BC000N11_A171XT_DefineCodeOrder ;
      private bool[] BC000N11_n171XT_DefineCodeOrder ;
      private String[] BC000N11_A431XT_TypeCode ;
      private bool[] BC000N11_n431XT_TypeCode ;
      private String[] BC000N11_A432XT_TenantCode ;
      private bool[] BC000N11_n432XT_TenantCode ;
      private short[] BC000N11_A510XT_DefineCodeIntialType ;
      private bool[] BC000N11_n510XT_DefineCodeIntialType ;
      private long[] BC000N11_A165XT_DefindcodeTypeID ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_datastore1 ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV8WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV11TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV14TrnContextAtt ;
   }

   public class xt_definecode_bc__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class xt_definecode_bc__default : DataStoreHelperBase, IDataStoreHelper
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
        Object[] prmBC000N5 ;
        prmBC000N5 = new Object[] {
        new Object[] {"@XT_DefineCodeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000N4 ;
        prmBC000N4 = new Object[] {
        new Object[] {"@XT_DefindcodeTypeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000N6 ;
        prmBC000N6 = new Object[] {
        new Object[] {"@XT_DefineCodeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000N3 ;
        prmBC000N3 = new Object[] {
        new Object[] {"@XT_DefineCodeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000N2 ;
        prmBC000N2 = new Object[] {
        new Object[] {"@XT_DefineCodeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000N7 ;
        prmBC000N7 = new Object[] {
        new Object[] {"@XT_DefineCodeName",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@XT_DefineCodeOrder",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@XT_TypeCode",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@XT_TenantCode",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@XT_DefineCodeIntialType",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@XT_DefindcodeTypeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000N8 ;
        prmBC000N8 = new Object[] {
        new Object[] {"@XT_DefineCodeName",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@XT_DefineCodeOrder",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@XT_TypeCode",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@XT_TenantCode",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@XT_DefineCodeIntialType",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@XT_DefindcodeTypeID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@XT_DefineCodeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000N9 ;
        prmBC000N9 = new Object[] {
        new Object[] {"@XT_DefineCodeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000N10 ;
        prmBC000N10 = new Object[] {
        new Object[] {"@XT_DefindcodeTypeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000N11 ;
        prmBC000N11 = new Object[] {
        new Object[] {"@XT_DefineCodeID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("BC000N2", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefineCodeOrder], [XT_TypeCode], [XT_TenantCode], [XT_DefineCodeIntialType], [XT_DefindcodeTypeID] FROM [XT_DefineCode] WITH (UPDLOCK) WHERE [XT_DefineCodeID] = @XT_DefineCodeID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000N2,1,0,true,false )
           ,new CursorDef("BC000N3", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefineCodeOrder], [XT_TypeCode], [XT_TenantCode], [XT_DefineCodeIntialType], [XT_DefindcodeTypeID] FROM [XT_DefineCode] WITH (NOLOCK) WHERE [XT_DefineCodeID] = @XT_DefineCodeID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000N3,1,0,true,false )
           ,new CursorDef("BC000N4", "SELECT [XT_DefindcodeTypeName] FROM [XT_DefindcodeType] WITH (NOLOCK) WHERE [XT_DefindcodeTypeID] = @XT_DefindcodeTypeID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000N4,1,0,true,false )
           ,new CursorDef("BC000N5", "SELECT TM1.[XT_DefineCodeID], TM1.[XT_DefineCodeName], T2.[XT_DefindcodeTypeName], TM1.[XT_DefineCodeOrder], TM1.[XT_TypeCode], TM1.[XT_TenantCode], TM1.[XT_DefineCodeIntialType], TM1.[XT_DefindcodeTypeID] FROM ([XT_DefineCode] TM1 WITH (NOLOCK) INNER JOIN [XT_DefindcodeType] T2 WITH (NOLOCK) ON T2.[XT_DefindcodeTypeID] = TM1.[XT_DefindcodeTypeID]) WHERE TM1.[XT_DefineCodeID] = @XT_DefineCodeID ORDER BY TM1.[XT_DefineCodeID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000N5,100,0,true,false )
           ,new CursorDef("BC000N6", "SELECT [XT_DefineCodeID] FROM [XT_DefineCode] WITH (NOLOCK) WHERE [XT_DefineCodeID] = @XT_DefineCodeID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000N6,1,0,true,false )
           ,new CursorDef("BC000N7", "INSERT INTO [XT_DefineCode]([XT_DefineCodeName], [XT_DefineCodeOrder], [XT_TypeCode], [XT_TenantCode], [XT_DefineCodeIntialType], [XT_DefindcodeTypeID]) VALUES(@XT_DefineCodeName, @XT_DefineCodeOrder, @XT_TypeCode, @XT_TenantCode, @XT_DefineCodeIntialType, @XT_DefindcodeTypeID); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmBC000N7)
           ,new CursorDef("BC000N8", "UPDATE [XT_DefineCode] SET [XT_DefineCodeName]=@XT_DefineCodeName, [XT_DefineCodeOrder]=@XT_DefineCodeOrder, [XT_TypeCode]=@XT_TypeCode, [XT_TenantCode]=@XT_TenantCode, [XT_DefineCodeIntialType]=@XT_DefineCodeIntialType, [XT_DefindcodeTypeID]=@XT_DefindcodeTypeID  WHERE [XT_DefineCodeID] = @XT_DefineCodeID", GxErrorMask.GX_NOMASK,prmBC000N8)
           ,new CursorDef("BC000N9", "DELETE FROM [XT_DefineCode]  WHERE [XT_DefineCodeID] = @XT_DefineCodeID", GxErrorMask.GX_NOMASK,prmBC000N9)
           ,new CursorDef("BC000N10", "SELECT [XT_DefindcodeTypeName] FROM [XT_DefindcodeType] WITH (NOLOCK) WHERE [XT_DefindcodeTypeID] = @XT_DefindcodeTypeID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000N10,1,0,true,false )
           ,new CursorDef("BC000N11", "SELECT TM1.[XT_DefineCodeID], TM1.[XT_DefineCodeName], T2.[XT_DefindcodeTypeName], TM1.[XT_DefineCodeOrder], TM1.[XT_TypeCode], TM1.[XT_TenantCode], TM1.[XT_DefineCodeIntialType], TM1.[XT_DefindcodeTypeID] FROM ([XT_DefineCode] TM1 WITH (NOLOCK) INNER JOIN [XT_DefindcodeType] T2 WITH (NOLOCK) ON T2.[XT_DefindcodeTypeID] = TM1.[XT_DefindcodeTypeID]) WHERE TM1.[XT_DefineCodeID] = @XT_DefineCodeID ORDER BY TM1.[XT_DefineCodeID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000N11,100,0,true,false )
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
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((short[]) buf[9])[0] = rslt.getShort(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((long[]) buf[11])[0] = rslt.getLong(7) ;
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((short[]) buf[3])[0] = rslt.getShort(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((short[]) buf[9])[0] = rslt.getShort(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((long[]) buf[11])[0] = rslt.getLong(7) ;
              return;
           case 2 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              return;
           case 3 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((short[]) buf[5])[0] = rslt.getShort(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((short[]) buf[11])[0] = rslt.getShort(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((long[]) buf[13])[0] = rslt.getLong(8) ;
              return;
           case 4 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 5 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 8 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              return;
           case 9 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((short[]) buf[5])[0] = rslt.getShort(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((short[]) buf[11])[0] = rslt.getShort(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((long[]) buf[13])[0] = rslt.getLong(8) ;
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
                 stmt.setNull( 2 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(2, (short)parms[3]);
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
                 stmt.setNull( 5 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(5, (short)parms[9]);
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
                 stmt.setNull( 2 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(2, (short)parms[3]);
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
                 stmt.setNull( 5 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(5, (short)parms[9]);
              }
              stmt.SetParameter(6, (long)parms[10]);
              stmt.SetParameter(7, (long)parms[11]);
              return;
           case 7 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 8 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 9 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
     }
  }

}

}
