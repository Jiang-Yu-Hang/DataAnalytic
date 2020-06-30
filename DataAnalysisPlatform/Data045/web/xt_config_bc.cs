/*
               File: XT_Config_BC
        Description: œµÕ≥≈‰÷√±Ì
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:7:48.98
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
   public class xt_config_bc : GXHttpHandler, IGxSilentTrn
   {
      public xt_config_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public xt_config_bc( IGxContext context )
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
         ReadRow0Q27( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey0Q27( ) ;
         standaloneModal( ) ;
         AddRow0Q27( ) ;
         Gx_mode = "INS";
         return  ;
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E110Q2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               Z195XT_ConfigID = A195XT_ConfigID;
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

      protected void CONFIRM_0Q0( )
      {
         BeforeValidate0Q27( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0Q27( ) ;
            }
            else
            {
               CheckExtendedTable0Q27( ) ;
               if ( AnyError == 0 )
               {
               }
               CloseExtendedTableCursors0Q27( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void E120Q2( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV8WWPContext) ;
         AV9IsAuthorized = true;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWXT_Config_Insert", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWXT_Config_Update", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWXT_Config_Delete", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
         }
         if ( ! AV9IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV13Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV11TrnContext.FromXml(AV12WebSession.Get("TrnContext"), null, "WWPTransactionContext", "DataAnalysisPlatform");
      }

      protected void E110Q2( )
      {
         /* After Trn Routine */
      }

      protected void ZM0Q27( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            Z196XT_ConfigKey = A196XT_ConfigKey;
            Z197XT_ConfigValue1 = A197XT_ConfigValue1;
            Z198XT_ConfigValue2 = A198XT_ConfigValue2;
            Z199XT_ConfigValue3 = A199XT_ConfigValue3;
            Z200XT_ConfigValue4 = A200XT_ConfigValue4;
            Z201XT_ConfigValue5 = A201XT_ConfigValue5;
         }
         if ( GX_JID == -1 )
         {
            Z195XT_ConfigID = A195XT_ConfigID;
            Z196XT_ConfigKey = A196XT_ConfigKey;
            Z197XT_ConfigValue1 = A197XT_ConfigValue1;
            Z198XT_ConfigValue2 = A198XT_ConfigValue2;
            Z199XT_ConfigValue3 = A199XT_ConfigValue3;
            Z200XT_ConfigValue4 = A200XT_ConfigValue4;
            Z201XT_ConfigValue5 = A201XT_ConfigValue5;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load0Q27( )
      {
         /* Using cursor BC000Q4 */
         pr_default.execute(2, new Object[] {A195XT_ConfigID});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound27 = 1;
            A196XT_ConfigKey = BC000Q4_A196XT_ConfigKey[0];
            n196XT_ConfigKey = BC000Q4_n196XT_ConfigKey[0];
            A197XT_ConfigValue1 = BC000Q4_A197XT_ConfigValue1[0];
            n197XT_ConfigValue1 = BC000Q4_n197XT_ConfigValue1[0];
            A198XT_ConfigValue2 = BC000Q4_A198XT_ConfigValue2[0];
            n198XT_ConfigValue2 = BC000Q4_n198XT_ConfigValue2[0];
            A199XT_ConfigValue3 = BC000Q4_A199XT_ConfigValue3[0];
            n199XT_ConfigValue3 = BC000Q4_n199XT_ConfigValue3[0];
            A200XT_ConfigValue4 = BC000Q4_A200XT_ConfigValue4[0];
            n200XT_ConfigValue4 = BC000Q4_n200XT_ConfigValue4[0];
            A201XT_ConfigValue5 = BC000Q4_A201XT_ConfigValue5[0];
            n201XT_ConfigValue5 = BC000Q4_n201XT_ConfigValue5[0];
            ZM0Q27( -1) ;
         }
         pr_default.close(2);
         OnLoadActions0Q27( ) ;
      }

      protected void OnLoadActions0Q27( )
      {
         AV13Pgmname = "XT_Config_BC";
      }

      protected void CheckExtendedTable0Q27( )
      {
         standaloneModal( ) ;
         AV13Pgmname = "XT_Config_BC";
      }

      protected void CloseExtendedTableCursors0Q27( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0Q27( )
      {
         /* Using cursor BC000Q5 */
         pr_default.execute(3, new Object[] {A195XT_ConfigID});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound27 = 1;
         }
         else
         {
            RcdFound27 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC000Q3 */
         pr_default.execute(1, new Object[] {A195XT_ConfigID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0Q27( 1) ;
            RcdFound27 = 1;
            A195XT_ConfigID = BC000Q3_A195XT_ConfigID[0];
            A196XT_ConfigKey = BC000Q3_A196XT_ConfigKey[0];
            n196XT_ConfigKey = BC000Q3_n196XT_ConfigKey[0];
            A197XT_ConfigValue1 = BC000Q3_A197XT_ConfigValue1[0];
            n197XT_ConfigValue1 = BC000Q3_n197XT_ConfigValue1[0];
            A198XT_ConfigValue2 = BC000Q3_A198XT_ConfigValue2[0];
            n198XT_ConfigValue2 = BC000Q3_n198XT_ConfigValue2[0];
            A199XT_ConfigValue3 = BC000Q3_A199XT_ConfigValue3[0];
            n199XT_ConfigValue3 = BC000Q3_n199XT_ConfigValue3[0];
            A200XT_ConfigValue4 = BC000Q3_A200XT_ConfigValue4[0];
            n200XT_ConfigValue4 = BC000Q3_n200XT_ConfigValue4[0];
            A201XT_ConfigValue5 = BC000Q3_A201XT_ConfigValue5[0];
            n201XT_ConfigValue5 = BC000Q3_n201XT_ConfigValue5[0];
            Z195XT_ConfigID = A195XT_ConfigID;
            sMode27 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load0Q27( ) ;
            if ( AnyError == 1 )
            {
               RcdFound27 = 0;
               InitializeNonKey0Q27( ) ;
            }
            Gx_mode = sMode27;
         }
         else
         {
            RcdFound27 = 0;
            InitializeNonKey0Q27( ) ;
            sMode27 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode27;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0Q27( ) ;
         if ( RcdFound27 == 0 )
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
         CONFIRM_0Q0( ) ;
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

      protected void CheckOptimisticConcurrency0Q27( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC000Q2 */
            pr_default.execute(0, new Object[] {A195XT_ConfigID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"XT_Config"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z196XT_ConfigKey, BC000Q2_A196XT_ConfigKey[0]) != 0 ) || ( StringUtil.StrCmp(Z197XT_ConfigValue1, BC000Q2_A197XT_ConfigValue1[0]) != 0 ) || ( StringUtil.StrCmp(Z198XT_ConfigValue2, BC000Q2_A198XT_ConfigValue2[0]) != 0 ) || ( StringUtil.StrCmp(Z199XT_ConfigValue3, BC000Q2_A199XT_ConfigValue3[0]) != 0 ) || ( StringUtil.StrCmp(Z200XT_ConfigValue4, BC000Q2_A200XT_ConfigValue4[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z201XT_ConfigValue5, BC000Q2_A201XT_ConfigValue5[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"XT_Config"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0Q27( )
      {
         BeforeValidate0Q27( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0Q27( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0Q27( 0) ;
            CheckOptimisticConcurrency0Q27( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0Q27( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0Q27( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000Q6 */
                     pr_default.execute(4, new Object[] {n196XT_ConfigKey, A196XT_ConfigKey, n197XT_ConfigValue1, A197XT_ConfigValue1, n198XT_ConfigValue2, A198XT_ConfigValue2, n199XT_ConfigValue3, A199XT_ConfigValue3, n200XT_ConfigValue4, A200XT_ConfigValue4, n201XT_ConfigValue5, A201XT_ConfigValue5});
                     A195XT_ConfigID = BC000Q6_A195XT_ConfigID[0];
                     pr_default.close(4);
                     dsDefault.SmartCacheProvider.SetUpdated("XT_Config") ;
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
               Load0Q27( ) ;
            }
            EndLevel0Q27( ) ;
         }
         CloseExtendedTableCursors0Q27( ) ;
      }

      protected void Update0Q27( )
      {
         BeforeValidate0Q27( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0Q27( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0Q27( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0Q27( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0Q27( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000Q7 */
                     pr_default.execute(5, new Object[] {n196XT_ConfigKey, A196XT_ConfigKey, n197XT_ConfigValue1, A197XT_ConfigValue1, n198XT_ConfigValue2, A198XT_ConfigValue2, n199XT_ConfigValue3, A199XT_ConfigValue3, n200XT_ConfigValue4, A200XT_ConfigValue4, n201XT_ConfigValue5, A201XT_ConfigValue5, A195XT_ConfigID});
                     pr_default.close(5);
                     dsDefault.SmartCacheProvider.SetUpdated("XT_Config") ;
                     if ( (pr_default.getStatus(5) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"XT_Config"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0Q27( ) ;
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
            EndLevel0Q27( ) ;
         }
         CloseExtendedTableCursors0Q27( ) ;
      }

      protected void DeferredUpdate0Q27( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate0Q27( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0Q27( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0Q27( ) ;
            AfterConfirm0Q27( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0Q27( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC000Q8 */
                  pr_default.execute(6, new Object[] {A195XT_ConfigID});
                  pr_default.close(6);
                  dsDefault.SmartCacheProvider.SetUpdated("XT_Config") ;
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
         sMode27 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel0Q27( ) ;
         Gx_mode = sMode27;
      }

      protected void OnDeleteControls0Q27( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV13Pgmname = "XT_Config_BC";
         }
      }

      protected void EndLevel0Q27( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0Q27( ) ;
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

      public void ScanKeyStart0Q27( )
      {
         /* Scan By routine */
         /* Using cursor BC000Q9 */
         pr_default.execute(7, new Object[] {A195XT_ConfigID});
         RcdFound27 = 0;
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound27 = 1;
            A195XT_ConfigID = BC000Q9_A195XT_ConfigID[0];
            A196XT_ConfigKey = BC000Q9_A196XT_ConfigKey[0];
            n196XT_ConfigKey = BC000Q9_n196XT_ConfigKey[0];
            A197XT_ConfigValue1 = BC000Q9_A197XT_ConfigValue1[0];
            n197XT_ConfigValue1 = BC000Q9_n197XT_ConfigValue1[0];
            A198XT_ConfigValue2 = BC000Q9_A198XT_ConfigValue2[0];
            n198XT_ConfigValue2 = BC000Q9_n198XT_ConfigValue2[0];
            A199XT_ConfigValue3 = BC000Q9_A199XT_ConfigValue3[0];
            n199XT_ConfigValue3 = BC000Q9_n199XT_ConfigValue3[0];
            A200XT_ConfigValue4 = BC000Q9_A200XT_ConfigValue4[0];
            n200XT_ConfigValue4 = BC000Q9_n200XT_ConfigValue4[0];
            A201XT_ConfigValue5 = BC000Q9_A201XT_ConfigValue5[0];
            n201XT_ConfigValue5 = BC000Q9_n201XT_ConfigValue5[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext0Q27( )
      {
         /* Scan next routine */
         pr_default.readNext(7);
         RcdFound27 = 0;
         ScanKeyLoad0Q27( ) ;
      }

      protected void ScanKeyLoad0Q27( )
      {
         sMode27 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound27 = 1;
            A195XT_ConfigID = BC000Q9_A195XT_ConfigID[0];
            A196XT_ConfigKey = BC000Q9_A196XT_ConfigKey[0];
            n196XT_ConfigKey = BC000Q9_n196XT_ConfigKey[0];
            A197XT_ConfigValue1 = BC000Q9_A197XT_ConfigValue1[0];
            n197XT_ConfigValue1 = BC000Q9_n197XT_ConfigValue1[0];
            A198XT_ConfigValue2 = BC000Q9_A198XT_ConfigValue2[0];
            n198XT_ConfigValue2 = BC000Q9_n198XT_ConfigValue2[0];
            A199XT_ConfigValue3 = BC000Q9_A199XT_ConfigValue3[0];
            n199XT_ConfigValue3 = BC000Q9_n199XT_ConfigValue3[0];
            A200XT_ConfigValue4 = BC000Q9_A200XT_ConfigValue4[0];
            n200XT_ConfigValue4 = BC000Q9_n200XT_ConfigValue4[0];
            A201XT_ConfigValue5 = BC000Q9_A201XT_ConfigValue5[0];
            n201XT_ConfigValue5 = BC000Q9_n201XT_ConfigValue5[0];
         }
         Gx_mode = sMode27;
      }

      protected void ScanKeyEnd0Q27( )
      {
         pr_default.close(7);
      }

      protected void AfterConfirm0Q27( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0Q27( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0Q27( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0Q27( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0Q27( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0Q27( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0Q27( )
      {
      }

      protected void send_integrity_lvl_hashes0Q27( )
      {
      }

      protected void AddRow0Q27( )
      {
         VarsToRow27( bcXT_Config) ;
      }

      protected void ReadRow0Q27( )
      {
         RowToVars27( bcXT_Config, 1) ;
      }

      protected void InitializeNonKey0Q27( )
      {
         A196XT_ConfigKey = "";
         n196XT_ConfigKey = false;
         A197XT_ConfigValue1 = "";
         n197XT_ConfigValue1 = false;
         A198XT_ConfigValue2 = "";
         n198XT_ConfigValue2 = false;
         A199XT_ConfigValue3 = "";
         n199XT_ConfigValue3 = false;
         A200XT_ConfigValue4 = "";
         n200XT_ConfigValue4 = false;
         A201XT_ConfigValue5 = "";
         n201XT_ConfigValue5 = false;
         Z196XT_ConfigKey = "";
         Z197XT_ConfigValue1 = "";
         Z198XT_ConfigValue2 = "";
         Z199XT_ConfigValue3 = "";
         Z200XT_ConfigValue4 = "";
         Z201XT_ConfigValue5 = "";
      }

      protected void InitAll0Q27( )
      {
         A195XT_ConfigID = 0;
         InitializeNonKey0Q27( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow27( SdtXT_Config obj27 )
      {
         obj27.gxTpr_Mode = Gx_mode;
         obj27.gxTpr_Xt_configkey = A196XT_ConfigKey;
         obj27.gxTpr_Xt_configvalue1 = A197XT_ConfigValue1;
         obj27.gxTpr_Xt_configvalue2 = A198XT_ConfigValue2;
         obj27.gxTpr_Xt_configvalue3 = A199XT_ConfigValue3;
         obj27.gxTpr_Xt_configvalue4 = A200XT_ConfigValue4;
         obj27.gxTpr_Xt_configvalue5 = A201XT_ConfigValue5;
         obj27.gxTpr_Xt_configid = A195XT_ConfigID;
         obj27.gxTpr_Xt_configid_Z = Z195XT_ConfigID;
         obj27.gxTpr_Xt_configkey_Z = Z196XT_ConfigKey;
         obj27.gxTpr_Xt_configvalue1_Z = Z197XT_ConfigValue1;
         obj27.gxTpr_Xt_configvalue2_Z = Z198XT_ConfigValue2;
         obj27.gxTpr_Xt_configvalue3_Z = Z199XT_ConfigValue3;
         obj27.gxTpr_Xt_configvalue4_Z = Z200XT_ConfigValue4;
         obj27.gxTpr_Xt_configvalue5_Z = Z201XT_ConfigValue5;
         obj27.gxTpr_Xt_configkey_N = (short)(Convert.ToInt16(n196XT_ConfigKey));
         obj27.gxTpr_Xt_configvalue1_N = (short)(Convert.ToInt16(n197XT_ConfigValue1));
         obj27.gxTpr_Xt_configvalue2_N = (short)(Convert.ToInt16(n198XT_ConfigValue2));
         obj27.gxTpr_Xt_configvalue3_N = (short)(Convert.ToInt16(n199XT_ConfigValue3));
         obj27.gxTpr_Xt_configvalue4_N = (short)(Convert.ToInt16(n200XT_ConfigValue4));
         obj27.gxTpr_Xt_configvalue5_N = (short)(Convert.ToInt16(n201XT_ConfigValue5));
         obj27.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow27( SdtXT_Config obj27 )
      {
         obj27.gxTpr_Xt_configid = A195XT_ConfigID;
         return  ;
      }

      public void RowToVars27( SdtXT_Config obj27 ,
                               int forceLoad )
      {
         Gx_mode = obj27.gxTpr_Mode;
         A196XT_ConfigKey = obj27.gxTpr_Xt_configkey;
         n196XT_ConfigKey = false;
         A197XT_ConfigValue1 = obj27.gxTpr_Xt_configvalue1;
         n197XT_ConfigValue1 = false;
         A198XT_ConfigValue2 = obj27.gxTpr_Xt_configvalue2;
         n198XT_ConfigValue2 = false;
         A199XT_ConfigValue3 = obj27.gxTpr_Xt_configvalue3;
         n199XT_ConfigValue3 = false;
         A200XT_ConfigValue4 = obj27.gxTpr_Xt_configvalue4;
         n200XT_ConfigValue4 = false;
         A201XT_ConfigValue5 = obj27.gxTpr_Xt_configvalue5;
         n201XT_ConfigValue5 = false;
         A195XT_ConfigID = obj27.gxTpr_Xt_configid;
         Z195XT_ConfigID = obj27.gxTpr_Xt_configid_Z;
         Z196XT_ConfigKey = obj27.gxTpr_Xt_configkey_Z;
         Z197XT_ConfigValue1 = obj27.gxTpr_Xt_configvalue1_Z;
         Z198XT_ConfigValue2 = obj27.gxTpr_Xt_configvalue2_Z;
         Z199XT_ConfigValue3 = obj27.gxTpr_Xt_configvalue3_Z;
         Z200XT_ConfigValue4 = obj27.gxTpr_Xt_configvalue4_Z;
         Z201XT_ConfigValue5 = obj27.gxTpr_Xt_configvalue5_Z;
         n196XT_ConfigKey = (bool)(Convert.ToBoolean(obj27.gxTpr_Xt_configkey_N));
         n197XT_ConfigValue1 = (bool)(Convert.ToBoolean(obj27.gxTpr_Xt_configvalue1_N));
         n198XT_ConfigValue2 = (bool)(Convert.ToBoolean(obj27.gxTpr_Xt_configvalue2_N));
         n199XT_ConfigValue3 = (bool)(Convert.ToBoolean(obj27.gxTpr_Xt_configvalue3_N));
         n200XT_ConfigValue4 = (bool)(Convert.ToBoolean(obj27.gxTpr_Xt_configvalue4_N));
         n201XT_ConfigValue5 = (bool)(Convert.ToBoolean(obj27.gxTpr_Xt_configvalue5_N));
         Gx_mode = obj27.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A195XT_ConfigID = (long)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey0Q27( ) ;
         ScanKeyStart0Q27( ) ;
         if ( RcdFound27 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z195XT_ConfigID = A195XT_ConfigID;
         }
         ZM0Q27( -1) ;
         OnLoadActions0Q27( ) ;
         AddRow0Q27( ) ;
         ScanKeyEnd0Q27( ) ;
         if ( RcdFound27 == 0 )
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
         RowToVars27( bcXT_Config, 0) ;
         ScanKeyStart0Q27( ) ;
         if ( RcdFound27 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z195XT_ConfigID = A195XT_ConfigID;
         }
         ZM0Q27( -1) ;
         OnLoadActions0Q27( ) ;
         AddRow0Q27( ) ;
         ScanKeyEnd0Q27( ) ;
         if ( RcdFound27 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey0Q27( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert0Q27( ) ;
         }
         else
         {
            if ( RcdFound27 == 1 )
            {
               if ( A195XT_ConfigID != Z195XT_ConfigID )
               {
                  A195XT_ConfigID = Z195XT_ConfigID;
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
                  Update0Q27( ) ;
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
                  if ( A195XT_ConfigID != Z195XT_ConfigID )
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
                        Insert0Q27( ) ;
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
                        Insert0Q27( ) ;
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
         RowToVars27( bcXT_Config, 0) ;
         SaveImpl( ) ;
         VarsToRow27( bcXT_Config) ;
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
         RowToVars27( bcXT_Config, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert0Q27( ) ;
         AfterTrn( ) ;
         VarsToRow27( bcXT_Config) ;
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
            SdtXT_Config auxBC = new SdtXT_Config(context) ;
            auxBC.Load(A195XT_ConfigID);
            auxBC.UpdateDirties(bcXT_Config);
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
         RowToVars27( bcXT_Config, 0) ;
         UpdateImpl( ) ;
         VarsToRow27( bcXT_Config) ;
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
         RowToVars27( bcXT_Config, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert0Q27( ) ;
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
         VarsToRow27( bcXT_Config) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars27( bcXT_Config, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey0Q27( ) ;
         if ( RcdFound27 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A195XT_ConfigID != Z195XT_ConfigID )
            {
               A195XT_ConfigID = Z195XT_ConfigID;
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
            if ( A195XT_ConfigID != Z195XT_ConfigID )
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
         context.RollbackDataStores("xt_config_bc",pr_default);
         VarsToRow27( bcXT_Config) ;
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
         Gx_mode = bcXT_Config.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcXT_Config.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcXT_Config )
         {
            bcXT_Config = (SdtXT_Config)(sdt);
            if ( StringUtil.StrCmp(bcXT_Config.gxTpr_Mode, "") == 0 )
            {
               bcXT_Config.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow27( bcXT_Config) ;
            }
            else
            {
               RowToVars27( bcXT_Config, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcXT_Config.gxTpr_Mode, "") == 0 )
            {
               bcXT_Config.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars27( bcXT_Config, 1) ;
         return  ;
      }

      public SdtXT_Config XT_Config_BC
      {
         get {
            return bcXT_Config ;
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
         AV13Pgmname = "";
         AV11TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV12WebSession = context.GetSession();
         Z196XT_ConfigKey = "";
         A196XT_ConfigKey = "";
         Z197XT_ConfigValue1 = "";
         A197XT_ConfigValue1 = "";
         Z198XT_ConfigValue2 = "";
         A198XT_ConfigValue2 = "";
         Z199XT_ConfigValue3 = "";
         A199XT_ConfigValue3 = "";
         Z200XT_ConfigValue4 = "";
         A200XT_ConfigValue4 = "";
         Z201XT_ConfigValue5 = "";
         A201XT_ConfigValue5 = "";
         BC000Q4_A195XT_ConfigID = new long[1] ;
         BC000Q4_A196XT_ConfigKey = new String[] {""} ;
         BC000Q4_n196XT_ConfigKey = new bool[] {false} ;
         BC000Q4_A197XT_ConfigValue1 = new String[] {""} ;
         BC000Q4_n197XT_ConfigValue1 = new bool[] {false} ;
         BC000Q4_A198XT_ConfigValue2 = new String[] {""} ;
         BC000Q4_n198XT_ConfigValue2 = new bool[] {false} ;
         BC000Q4_A199XT_ConfigValue3 = new String[] {""} ;
         BC000Q4_n199XT_ConfigValue3 = new bool[] {false} ;
         BC000Q4_A200XT_ConfigValue4 = new String[] {""} ;
         BC000Q4_n200XT_ConfigValue4 = new bool[] {false} ;
         BC000Q4_A201XT_ConfigValue5 = new String[] {""} ;
         BC000Q4_n201XT_ConfigValue5 = new bool[] {false} ;
         BC000Q5_A195XT_ConfigID = new long[1] ;
         BC000Q3_A195XT_ConfigID = new long[1] ;
         BC000Q3_A196XT_ConfigKey = new String[] {""} ;
         BC000Q3_n196XT_ConfigKey = new bool[] {false} ;
         BC000Q3_A197XT_ConfigValue1 = new String[] {""} ;
         BC000Q3_n197XT_ConfigValue1 = new bool[] {false} ;
         BC000Q3_A198XT_ConfigValue2 = new String[] {""} ;
         BC000Q3_n198XT_ConfigValue2 = new bool[] {false} ;
         BC000Q3_A199XT_ConfigValue3 = new String[] {""} ;
         BC000Q3_n199XT_ConfigValue3 = new bool[] {false} ;
         BC000Q3_A200XT_ConfigValue4 = new String[] {""} ;
         BC000Q3_n200XT_ConfigValue4 = new bool[] {false} ;
         BC000Q3_A201XT_ConfigValue5 = new String[] {""} ;
         BC000Q3_n201XT_ConfigValue5 = new bool[] {false} ;
         sMode27 = "";
         BC000Q2_A195XT_ConfigID = new long[1] ;
         BC000Q2_A196XT_ConfigKey = new String[] {""} ;
         BC000Q2_n196XT_ConfigKey = new bool[] {false} ;
         BC000Q2_A197XT_ConfigValue1 = new String[] {""} ;
         BC000Q2_n197XT_ConfigValue1 = new bool[] {false} ;
         BC000Q2_A198XT_ConfigValue2 = new String[] {""} ;
         BC000Q2_n198XT_ConfigValue2 = new bool[] {false} ;
         BC000Q2_A199XT_ConfigValue3 = new String[] {""} ;
         BC000Q2_n199XT_ConfigValue3 = new bool[] {false} ;
         BC000Q2_A200XT_ConfigValue4 = new String[] {""} ;
         BC000Q2_n200XT_ConfigValue4 = new bool[] {false} ;
         BC000Q2_A201XT_ConfigValue5 = new String[] {""} ;
         BC000Q2_n201XT_ConfigValue5 = new bool[] {false} ;
         BC000Q6_A195XT_ConfigID = new long[1] ;
         BC000Q9_A195XT_ConfigID = new long[1] ;
         BC000Q9_A196XT_ConfigKey = new String[] {""} ;
         BC000Q9_n196XT_ConfigKey = new bool[] {false} ;
         BC000Q9_A197XT_ConfigValue1 = new String[] {""} ;
         BC000Q9_n197XT_ConfigValue1 = new bool[] {false} ;
         BC000Q9_A198XT_ConfigValue2 = new String[] {""} ;
         BC000Q9_n198XT_ConfigValue2 = new bool[] {false} ;
         BC000Q9_A199XT_ConfigValue3 = new String[] {""} ;
         BC000Q9_n199XT_ConfigValue3 = new bool[] {false} ;
         BC000Q9_A200XT_ConfigValue4 = new String[] {""} ;
         BC000Q9_n200XT_ConfigValue4 = new bool[] {false} ;
         BC000Q9_A201XT_ConfigValue5 = new String[] {""} ;
         BC000Q9_n201XT_ConfigValue5 = new bool[] {false} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.xt_config_bc__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.xt_config_bc__default(),
            new Object[][] {
                new Object[] {
               BC000Q2_A195XT_ConfigID, BC000Q2_A196XT_ConfigKey, BC000Q2_n196XT_ConfigKey, BC000Q2_A197XT_ConfigValue1, BC000Q2_n197XT_ConfigValue1, BC000Q2_A198XT_ConfigValue2, BC000Q2_n198XT_ConfigValue2, BC000Q2_A199XT_ConfigValue3, BC000Q2_n199XT_ConfigValue3, BC000Q2_A200XT_ConfigValue4,
               BC000Q2_n200XT_ConfigValue4, BC000Q2_A201XT_ConfigValue5, BC000Q2_n201XT_ConfigValue5
               }
               , new Object[] {
               BC000Q3_A195XT_ConfigID, BC000Q3_A196XT_ConfigKey, BC000Q3_n196XT_ConfigKey, BC000Q3_A197XT_ConfigValue1, BC000Q3_n197XT_ConfigValue1, BC000Q3_A198XT_ConfigValue2, BC000Q3_n198XT_ConfigValue2, BC000Q3_A199XT_ConfigValue3, BC000Q3_n199XT_ConfigValue3, BC000Q3_A200XT_ConfigValue4,
               BC000Q3_n200XT_ConfigValue4, BC000Q3_A201XT_ConfigValue5, BC000Q3_n201XT_ConfigValue5
               }
               , new Object[] {
               BC000Q4_A195XT_ConfigID, BC000Q4_A196XT_ConfigKey, BC000Q4_n196XT_ConfigKey, BC000Q4_A197XT_ConfigValue1, BC000Q4_n197XT_ConfigValue1, BC000Q4_A198XT_ConfigValue2, BC000Q4_n198XT_ConfigValue2, BC000Q4_A199XT_ConfigValue3, BC000Q4_n199XT_ConfigValue3, BC000Q4_A200XT_ConfigValue4,
               BC000Q4_n200XT_ConfigValue4, BC000Q4_A201XT_ConfigValue5, BC000Q4_n201XT_ConfigValue5
               }
               , new Object[] {
               BC000Q5_A195XT_ConfigID
               }
               , new Object[] {
               BC000Q6_A195XT_ConfigID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000Q9_A195XT_ConfigID, BC000Q9_A196XT_ConfigKey, BC000Q9_n196XT_ConfigKey, BC000Q9_A197XT_ConfigValue1, BC000Q9_n197XT_ConfigValue1, BC000Q9_A198XT_ConfigValue2, BC000Q9_n198XT_ConfigValue2, BC000Q9_A199XT_ConfigValue3, BC000Q9_n199XT_ConfigValue3, BC000Q9_A200XT_ConfigValue4,
               BC000Q9_n200XT_ConfigValue4, BC000Q9_A201XT_ConfigValue5, BC000Q9_n201XT_ConfigValue5
               }
            }
         );
         AV13Pgmname = "XT_Config_BC";
         INITTRN();
         /* Execute Start event if defined. */
         /* Execute user event: Start */
         E120Q2 ();
         standaloneNotModal( ) ;
      }

      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short GX_JID ;
      private short RcdFound27 ;
      private int trnEnded ;
      private long Z195XT_ConfigID ;
      private long A195XT_ConfigID ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String AV13Pgmname ;
      private String sMode27 ;
      private bool AV9IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool n196XT_ConfigKey ;
      private bool n197XT_ConfigValue1 ;
      private bool n198XT_ConfigValue2 ;
      private bool n199XT_ConfigValue3 ;
      private bool n200XT_ConfigValue4 ;
      private bool n201XT_ConfigValue5 ;
      private bool Gx_longc ;
      private String Z196XT_ConfigKey ;
      private String A196XT_ConfigKey ;
      private String Z197XT_ConfigValue1 ;
      private String A197XT_ConfigValue1 ;
      private String Z198XT_ConfigValue2 ;
      private String A198XT_ConfigValue2 ;
      private String Z199XT_ConfigValue3 ;
      private String A199XT_ConfigValue3 ;
      private String Z200XT_ConfigValue4 ;
      private String A200XT_ConfigValue4 ;
      private String Z201XT_ConfigValue5 ;
      private String A201XT_ConfigValue5 ;
      private IGxSession AV12WebSession ;
      private SdtXT_Config bcXT_Config ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] BC000Q4_A195XT_ConfigID ;
      private String[] BC000Q4_A196XT_ConfigKey ;
      private bool[] BC000Q4_n196XT_ConfigKey ;
      private String[] BC000Q4_A197XT_ConfigValue1 ;
      private bool[] BC000Q4_n197XT_ConfigValue1 ;
      private String[] BC000Q4_A198XT_ConfigValue2 ;
      private bool[] BC000Q4_n198XT_ConfigValue2 ;
      private String[] BC000Q4_A199XT_ConfigValue3 ;
      private bool[] BC000Q4_n199XT_ConfigValue3 ;
      private String[] BC000Q4_A200XT_ConfigValue4 ;
      private bool[] BC000Q4_n200XT_ConfigValue4 ;
      private String[] BC000Q4_A201XT_ConfigValue5 ;
      private bool[] BC000Q4_n201XT_ConfigValue5 ;
      private long[] BC000Q5_A195XT_ConfigID ;
      private long[] BC000Q3_A195XT_ConfigID ;
      private String[] BC000Q3_A196XT_ConfigKey ;
      private bool[] BC000Q3_n196XT_ConfigKey ;
      private String[] BC000Q3_A197XT_ConfigValue1 ;
      private bool[] BC000Q3_n197XT_ConfigValue1 ;
      private String[] BC000Q3_A198XT_ConfigValue2 ;
      private bool[] BC000Q3_n198XT_ConfigValue2 ;
      private String[] BC000Q3_A199XT_ConfigValue3 ;
      private bool[] BC000Q3_n199XT_ConfigValue3 ;
      private String[] BC000Q3_A200XT_ConfigValue4 ;
      private bool[] BC000Q3_n200XT_ConfigValue4 ;
      private String[] BC000Q3_A201XT_ConfigValue5 ;
      private bool[] BC000Q3_n201XT_ConfigValue5 ;
      private long[] BC000Q2_A195XT_ConfigID ;
      private String[] BC000Q2_A196XT_ConfigKey ;
      private bool[] BC000Q2_n196XT_ConfigKey ;
      private String[] BC000Q2_A197XT_ConfigValue1 ;
      private bool[] BC000Q2_n197XT_ConfigValue1 ;
      private String[] BC000Q2_A198XT_ConfigValue2 ;
      private bool[] BC000Q2_n198XT_ConfigValue2 ;
      private String[] BC000Q2_A199XT_ConfigValue3 ;
      private bool[] BC000Q2_n199XT_ConfigValue3 ;
      private String[] BC000Q2_A200XT_ConfigValue4 ;
      private bool[] BC000Q2_n200XT_ConfigValue4 ;
      private String[] BC000Q2_A201XT_ConfigValue5 ;
      private bool[] BC000Q2_n201XT_ConfigValue5 ;
      private long[] BC000Q6_A195XT_ConfigID ;
      private long[] BC000Q9_A195XT_ConfigID ;
      private String[] BC000Q9_A196XT_ConfigKey ;
      private bool[] BC000Q9_n196XT_ConfigKey ;
      private String[] BC000Q9_A197XT_ConfigValue1 ;
      private bool[] BC000Q9_n197XT_ConfigValue1 ;
      private String[] BC000Q9_A198XT_ConfigValue2 ;
      private bool[] BC000Q9_n198XT_ConfigValue2 ;
      private String[] BC000Q9_A199XT_ConfigValue3 ;
      private bool[] BC000Q9_n199XT_ConfigValue3 ;
      private String[] BC000Q9_A200XT_ConfigValue4 ;
      private bool[] BC000Q9_n200XT_ConfigValue4 ;
      private String[] BC000Q9_A201XT_ConfigValue5 ;
      private bool[] BC000Q9_n201XT_ConfigValue5 ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_datastore1 ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV8WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV11TrnContext ;
   }

   public class xt_config_bc__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class xt_config_bc__default : DataStoreHelperBase, IDataStoreHelper
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
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmBC000Q4 ;
        prmBC000Q4 = new Object[] {
        new Object[] {"@XT_ConfigID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000Q5 ;
        prmBC000Q5 = new Object[] {
        new Object[] {"@XT_ConfigID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000Q3 ;
        prmBC000Q3 = new Object[] {
        new Object[] {"@XT_ConfigID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000Q2 ;
        prmBC000Q2 = new Object[] {
        new Object[] {"@XT_ConfigID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000Q6 ;
        prmBC000Q6 = new Object[] {
        new Object[] {"@XT_ConfigKey",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@XT_ConfigValue1",SqlDbType.NVarChar,200,0} ,
        new Object[] {"@XT_ConfigValue2",SqlDbType.NVarChar,200,0} ,
        new Object[] {"@XT_ConfigValue3",SqlDbType.NVarChar,200,0} ,
        new Object[] {"@XT_ConfigValue4",SqlDbType.NVarChar,200,0} ,
        new Object[] {"@XT_ConfigValue5",SqlDbType.NVarChar,200,0}
        } ;
        Object[] prmBC000Q7 ;
        prmBC000Q7 = new Object[] {
        new Object[] {"@XT_ConfigKey",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@XT_ConfigValue1",SqlDbType.NVarChar,200,0} ,
        new Object[] {"@XT_ConfigValue2",SqlDbType.NVarChar,200,0} ,
        new Object[] {"@XT_ConfigValue3",SqlDbType.NVarChar,200,0} ,
        new Object[] {"@XT_ConfigValue4",SqlDbType.NVarChar,200,0} ,
        new Object[] {"@XT_ConfigValue5",SqlDbType.NVarChar,200,0} ,
        new Object[] {"@XT_ConfigID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000Q8 ;
        prmBC000Q8 = new Object[] {
        new Object[] {"@XT_ConfigID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000Q9 ;
        prmBC000Q9 = new Object[] {
        new Object[] {"@XT_ConfigID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("BC000Q2", "SELECT [XT_ConfigID], [XT_ConfigKey], [XT_ConfigValue1], [XT_ConfigValue2], [XT_ConfigValue3], [XT_ConfigValue4], [XT_ConfigValue5] FROM [XT_Config] WITH (UPDLOCK) WHERE [XT_ConfigID] = @XT_ConfigID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000Q2,1,0,true,false )
           ,new CursorDef("BC000Q3", "SELECT [XT_ConfigID], [XT_ConfigKey], [XT_ConfigValue1], [XT_ConfigValue2], [XT_ConfigValue3], [XT_ConfigValue4], [XT_ConfigValue5] FROM [XT_Config] WITH (NOLOCK) WHERE [XT_ConfigID] = @XT_ConfigID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000Q3,1,0,true,false )
           ,new CursorDef("BC000Q4", "SELECT TM1.[XT_ConfigID], TM1.[XT_ConfigKey], TM1.[XT_ConfigValue1], TM1.[XT_ConfigValue2], TM1.[XT_ConfigValue3], TM1.[XT_ConfigValue4], TM1.[XT_ConfigValue5] FROM [XT_Config] TM1 WITH (NOLOCK) WHERE TM1.[XT_ConfigID] = @XT_ConfigID ORDER BY TM1.[XT_ConfigID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000Q4,100,0,true,false )
           ,new CursorDef("BC000Q5", "SELECT [XT_ConfigID] FROM [XT_Config] WITH (NOLOCK) WHERE [XT_ConfigID] = @XT_ConfigID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000Q5,1,0,true,false )
           ,new CursorDef("BC000Q6", "INSERT INTO [XT_Config]([XT_ConfigKey], [XT_ConfigValue1], [XT_ConfigValue2], [XT_ConfigValue3], [XT_ConfigValue4], [XT_ConfigValue5]) VALUES(@XT_ConfigKey, @XT_ConfigValue1, @XT_ConfigValue2, @XT_ConfigValue3, @XT_ConfigValue4, @XT_ConfigValue5); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmBC000Q6)
           ,new CursorDef("BC000Q7", "UPDATE [XT_Config] SET [XT_ConfigKey]=@XT_ConfigKey, [XT_ConfigValue1]=@XT_ConfigValue1, [XT_ConfigValue2]=@XT_ConfigValue2, [XT_ConfigValue3]=@XT_ConfigValue3, [XT_ConfigValue4]=@XT_ConfigValue4, [XT_ConfigValue5]=@XT_ConfigValue5  WHERE [XT_ConfigID] = @XT_ConfigID", GxErrorMask.GX_NOMASK,prmBC000Q7)
           ,new CursorDef("BC000Q8", "DELETE FROM [XT_Config]  WHERE [XT_ConfigID] = @XT_ConfigID", GxErrorMask.GX_NOMASK,prmBC000Q8)
           ,new CursorDef("BC000Q9", "SELECT TM1.[XT_ConfigID], TM1.[XT_ConfigKey], TM1.[XT_ConfigValue1], TM1.[XT_ConfigValue2], TM1.[XT_ConfigValue3], TM1.[XT_ConfigValue4], TM1.[XT_ConfigValue5] FROM [XT_Config] TM1 WITH (NOLOCK) WHERE TM1.[XT_ConfigID] = @XT_ConfigID ORDER BY TM1.[XT_ConfigID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000Q9,100,0,true,false )
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
              ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
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
              ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              return;
           case 2 :
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
              ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              return;
           case 3 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 4 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 7 :
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
              ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
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
                 stmt.setNull( 6 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(6, (String)parms[11]);
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
                 stmt.setNull( 6 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(6, (String)parms[11]);
              }
              stmt.SetParameter(7, (long)parms[12]);
              return;
           case 6 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 7 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
     }
  }

}

}
