/*
               File: JC_Provider_BC
        Description: 医院
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:37:6.21
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
   public class jc_provider_bc : GXHttpHandler, IGxSilentTrn
   {
      public jc_provider_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public jc_provider_bc( IGxContext context )
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
         ReadRow0K21( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey0K21( ) ;
         standaloneModal( ) ;
         AddRow0K21( ) ;
         Gx_mode = "INS";
         return  ;
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E110K2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               Z87JC_ProviderID = A87JC_ProviderID;
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

      protected void CONFIRM_0K0( )
      {
         BeforeValidate0K21( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0K21( ) ;
            }
            else
            {
               CheckExtendedTable0K21( ) ;
               if ( AnyError == 0 )
               {
               }
               CloseExtendedTableCursors0K21( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void E120K2( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV7WWPContext) ;
         AV11IsAuthorized = true;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            GXt_boolean1 = AV11IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWJC_Provider_Insert", out  GXt_boolean1) ;
            AV11IsAuthorized = GXt_boolean1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            GXt_boolean1 = AV11IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWJC_Provider_Update", out  GXt_boolean1) ;
            AV11IsAuthorized = GXt_boolean1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            GXt_boolean1 = AV11IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWJC_Provider_Delete", out  GXt_boolean1) ;
            AV11IsAuthorized = GXt_boolean1;
         }
         if ( ! AV11IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV14Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV8TrnContext.FromXml(AV9WebSession.Get("TrnContext"), null, "WWPTransactionContext", "DataAnalysisPlatform");
      }

      protected void E110K2( )
      {
         /* After Trn Routine */
      }

      protected void ZM0K21( short GX_JID )
      {
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            Z89JC_ProviderName = A89JC_ProviderName;
            Z160JC_ProviderShortName = A160JC_ProviderShortName;
            Z161JC_ProviderAddresss = A161JC_ProviderAddresss;
            Z162JC_ProviderPhone = A162JC_ProviderPhone;
            Z163JC_ProviderUser = A163JC_ProviderUser;
         }
         if ( GX_JID == -3 )
         {
            Z87JC_ProviderID = A87JC_ProviderID;
            Z89JC_ProviderName = A89JC_ProviderName;
            Z160JC_ProviderShortName = A160JC_ProviderShortName;
            Z161JC_ProviderAddresss = A161JC_ProviderAddresss;
            Z162JC_ProviderPhone = A162JC_ProviderPhone;
            Z163JC_ProviderUser = A163JC_ProviderUser;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load0K21( )
      {
         /* Using cursor BC000K4 */
         pr_default.execute(2, new Object[] {A87JC_ProviderID});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound21 = 1;
            A89JC_ProviderName = BC000K4_A89JC_ProviderName[0];
            n89JC_ProviderName = BC000K4_n89JC_ProviderName[0];
            A160JC_ProviderShortName = BC000K4_A160JC_ProviderShortName[0];
            n160JC_ProviderShortName = BC000K4_n160JC_ProviderShortName[0];
            A161JC_ProviderAddresss = BC000K4_A161JC_ProviderAddresss[0];
            n161JC_ProviderAddresss = BC000K4_n161JC_ProviderAddresss[0];
            A162JC_ProviderPhone = BC000K4_A162JC_ProviderPhone[0];
            n162JC_ProviderPhone = BC000K4_n162JC_ProviderPhone[0];
            A163JC_ProviderUser = BC000K4_A163JC_ProviderUser[0];
            n163JC_ProviderUser = BC000K4_n163JC_ProviderUser[0];
            ZM0K21( -3) ;
         }
         pr_default.close(2);
         OnLoadActions0K21( ) ;
      }

      protected void OnLoadActions0K21( )
      {
         AV14Pgmname = "JC_Provider_BC";
      }

      protected void CheckExtendedTable0K21( )
      {
         standaloneModal( ) ;
         AV14Pgmname = "JC_Provider_BC";
      }

      protected void CloseExtendedTableCursors0K21( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0K21( )
      {
         /* Using cursor BC000K5 */
         pr_default.execute(3, new Object[] {A87JC_ProviderID});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound21 = 1;
         }
         else
         {
            RcdFound21 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC000K3 */
         pr_default.execute(1, new Object[] {A87JC_ProviderID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0K21( 3) ;
            RcdFound21 = 1;
            A87JC_ProviderID = BC000K3_A87JC_ProviderID[0];
            A89JC_ProviderName = BC000K3_A89JC_ProviderName[0];
            n89JC_ProviderName = BC000K3_n89JC_ProviderName[0];
            A160JC_ProviderShortName = BC000K3_A160JC_ProviderShortName[0];
            n160JC_ProviderShortName = BC000K3_n160JC_ProviderShortName[0];
            A161JC_ProviderAddresss = BC000K3_A161JC_ProviderAddresss[0];
            n161JC_ProviderAddresss = BC000K3_n161JC_ProviderAddresss[0];
            A162JC_ProviderPhone = BC000K3_A162JC_ProviderPhone[0];
            n162JC_ProviderPhone = BC000K3_n162JC_ProviderPhone[0];
            A163JC_ProviderUser = BC000K3_A163JC_ProviderUser[0];
            n163JC_ProviderUser = BC000K3_n163JC_ProviderUser[0];
            Z87JC_ProviderID = A87JC_ProviderID;
            sMode21 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load0K21( ) ;
            if ( AnyError == 1 )
            {
               RcdFound21 = 0;
               InitializeNonKey0K21( ) ;
            }
            Gx_mode = sMode21;
         }
         else
         {
            RcdFound21 = 0;
            InitializeNonKey0K21( ) ;
            sMode21 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode21;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0K21( ) ;
         if ( RcdFound21 == 0 )
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
         CONFIRM_0K0( ) ;
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

      protected void CheckOptimisticConcurrency0K21( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC000K2 */
            pr_default.execute(0, new Object[] {A87JC_ProviderID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"JC_Provider"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z89JC_ProviderName, BC000K2_A89JC_ProviderName[0]) != 0 ) || ( StringUtil.StrCmp(Z160JC_ProviderShortName, BC000K2_A160JC_ProviderShortName[0]) != 0 ) || ( StringUtil.StrCmp(Z161JC_ProviderAddresss, BC000K2_A161JC_ProviderAddresss[0]) != 0 ) || ( StringUtil.StrCmp(Z162JC_ProviderPhone, BC000K2_A162JC_ProviderPhone[0]) != 0 ) || ( StringUtil.StrCmp(Z163JC_ProviderUser, BC000K2_A163JC_ProviderUser[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"JC_Provider"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0K21( )
      {
         BeforeValidate0K21( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0K21( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0K21( 0) ;
            CheckOptimisticConcurrency0K21( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0K21( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0K21( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000K6 */
                     pr_default.execute(4, new Object[] {n89JC_ProviderName, A89JC_ProviderName, n160JC_ProviderShortName, A160JC_ProviderShortName, n161JC_ProviderAddresss, A161JC_ProviderAddresss, n162JC_ProviderPhone, A162JC_ProviderPhone, n163JC_ProviderUser, A163JC_ProviderUser});
                     A87JC_ProviderID = BC000K6_A87JC_ProviderID[0];
                     pr_default.close(4);
                     dsDefault.SmartCacheProvider.SetUpdated("JC_Provider") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        new zutil_recordlog(context ).execute(  A89JC_ProviderName,  "医院信息",  "Create",  1) ;
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
               Load0K21( ) ;
            }
            EndLevel0K21( ) ;
         }
         CloseExtendedTableCursors0K21( ) ;
      }

      protected void Update0K21( )
      {
         BeforeValidate0K21( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0K21( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0K21( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0K21( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0K21( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000K7 */
                     pr_default.execute(5, new Object[] {n89JC_ProviderName, A89JC_ProviderName, n160JC_ProviderShortName, A160JC_ProviderShortName, n161JC_ProviderAddresss, A161JC_ProviderAddresss, n162JC_ProviderPhone, A162JC_ProviderPhone, n163JC_ProviderUser, A163JC_ProviderUser, A87JC_ProviderID});
                     pr_default.close(5);
                     dsDefault.SmartCacheProvider.SetUpdated("JC_Provider") ;
                     if ( (pr_default.getStatus(5) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"JC_Provider"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0K21( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        new zutil_recordlog(context ).execute(  A89JC_ProviderName,  "医院信息",  "Update",  1) ;
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
            EndLevel0K21( ) ;
         }
         CloseExtendedTableCursors0K21( ) ;
      }

      protected void DeferredUpdate0K21( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate0K21( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0K21( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0K21( ) ;
            AfterConfirm0K21( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0K21( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC000K8 */
                  pr_default.execute(6, new Object[] {A87JC_ProviderID});
                  pr_default.close(6);
                  dsDefault.SmartCacheProvider.SetUpdated("JC_Provider") ;
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
         sMode21 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel0K21( ) ;
         Gx_mode = sMode21;
      }

      protected void OnDeleteControls0K21( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV14Pgmname = "JC_Provider_BC";
         }
         if ( AnyError == 0 )
         {
            /* Using cursor BC000K9 */
            pr_default.execute(7, new Object[] {A87JC_ProviderID});
            if ( (pr_default.getStatus(7) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {" T28"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(7);
            /* Using cursor BC000K10 */
            pr_default.execute(8, new Object[] {A87JC_ProviderID});
            if ( (pr_default.getStatus(8) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"医院账号关系表"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(8);
         }
      }

      protected void EndLevel0K21( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0K21( ) ;
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

      public void ScanKeyStart0K21( )
      {
         /* Scan By routine */
         /* Using cursor BC000K11 */
         pr_default.execute(9, new Object[] {A87JC_ProviderID});
         RcdFound21 = 0;
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound21 = 1;
            A87JC_ProviderID = BC000K11_A87JC_ProviderID[0];
            A89JC_ProviderName = BC000K11_A89JC_ProviderName[0];
            n89JC_ProviderName = BC000K11_n89JC_ProviderName[0];
            A160JC_ProviderShortName = BC000K11_A160JC_ProviderShortName[0];
            n160JC_ProviderShortName = BC000K11_n160JC_ProviderShortName[0];
            A161JC_ProviderAddresss = BC000K11_A161JC_ProviderAddresss[0];
            n161JC_ProviderAddresss = BC000K11_n161JC_ProviderAddresss[0];
            A162JC_ProviderPhone = BC000K11_A162JC_ProviderPhone[0];
            n162JC_ProviderPhone = BC000K11_n162JC_ProviderPhone[0];
            A163JC_ProviderUser = BC000K11_A163JC_ProviderUser[0];
            n163JC_ProviderUser = BC000K11_n163JC_ProviderUser[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext0K21( )
      {
         /* Scan next routine */
         pr_default.readNext(9);
         RcdFound21 = 0;
         ScanKeyLoad0K21( ) ;
      }

      protected void ScanKeyLoad0K21( )
      {
         sMode21 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound21 = 1;
            A87JC_ProviderID = BC000K11_A87JC_ProviderID[0];
            A89JC_ProviderName = BC000K11_A89JC_ProviderName[0];
            n89JC_ProviderName = BC000K11_n89JC_ProviderName[0];
            A160JC_ProviderShortName = BC000K11_A160JC_ProviderShortName[0];
            n160JC_ProviderShortName = BC000K11_n160JC_ProviderShortName[0];
            A161JC_ProviderAddresss = BC000K11_A161JC_ProviderAddresss[0];
            n161JC_ProviderAddresss = BC000K11_n161JC_ProviderAddresss[0];
            A162JC_ProviderPhone = BC000K11_A162JC_ProviderPhone[0];
            n162JC_ProviderPhone = BC000K11_n162JC_ProviderPhone[0];
            A163JC_ProviderUser = BC000K11_A163JC_ProviderUser[0];
            n163JC_ProviderUser = BC000K11_n163JC_ProviderUser[0];
         }
         Gx_mode = sMode21;
      }

      protected void ScanKeyEnd0K21( )
      {
         pr_default.close(9);
      }

      protected void AfterConfirm0K21( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0K21( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0K21( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0K21( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0K21( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0K21( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0K21( )
      {
      }

      protected void send_integrity_lvl_hashes0K21( )
      {
      }

      protected void AddRow0K21( )
      {
         VarsToRow21( bcJC_Provider) ;
      }

      protected void ReadRow0K21( )
      {
         RowToVars21( bcJC_Provider, 1) ;
      }

      protected void InitializeNonKey0K21( )
      {
         A89JC_ProviderName = "";
         n89JC_ProviderName = false;
         A160JC_ProviderShortName = "";
         n160JC_ProviderShortName = false;
         A161JC_ProviderAddresss = "";
         n161JC_ProviderAddresss = false;
         A162JC_ProviderPhone = "";
         n162JC_ProviderPhone = false;
         A163JC_ProviderUser = "";
         n163JC_ProviderUser = false;
         Z89JC_ProviderName = "";
         Z160JC_ProviderShortName = "";
         Z161JC_ProviderAddresss = "";
         Z162JC_ProviderPhone = "";
         Z163JC_ProviderUser = "";
      }

      protected void InitAll0K21( )
      {
         A87JC_ProviderID = 0;
         InitializeNonKey0K21( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow21( SdtJC_Provider obj21 )
      {
         obj21.gxTpr_Mode = Gx_mode;
         obj21.gxTpr_Jc_providername = A89JC_ProviderName;
         obj21.gxTpr_Jc_providershortname = A160JC_ProviderShortName;
         obj21.gxTpr_Jc_provideraddresss = A161JC_ProviderAddresss;
         obj21.gxTpr_Jc_providerphone = A162JC_ProviderPhone;
         obj21.gxTpr_Jc_provideruser = A163JC_ProviderUser;
         obj21.gxTpr_Jc_providerid = A87JC_ProviderID;
         obj21.gxTpr_Jc_providerid_Z = Z87JC_ProviderID;
         obj21.gxTpr_Jc_providername_Z = Z89JC_ProviderName;
         obj21.gxTpr_Jc_providershortname_Z = Z160JC_ProviderShortName;
         obj21.gxTpr_Jc_provideraddresss_Z = Z161JC_ProviderAddresss;
         obj21.gxTpr_Jc_providerphone_Z = Z162JC_ProviderPhone;
         obj21.gxTpr_Jc_provideruser_Z = Z163JC_ProviderUser;
         obj21.gxTpr_Jc_providername_N = (short)(Convert.ToInt16(n89JC_ProviderName));
         obj21.gxTpr_Jc_providershortname_N = (short)(Convert.ToInt16(n160JC_ProviderShortName));
         obj21.gxTpr_Jc_provideraddresss_N = (short)(Convert.ToInt16(n161JC_ProviderAddresss));
         obj21.gxTpr_Jc_providerphone_N = (short)(Convert.ToInt16(n162JC_ProviderPhone));
         obj21.gxTpr_Jc_provideruser_N = (short)(Convert.ToInt16(n163JC_ProviderUser));
         obj21.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow21( SdtJC_Provider obj21 )
      {
         obj21.gxTpr_Jc_providerid = A87JC_ProviderID;
         return  ;
      }

      public void RowToVars21( SdtJC_Provider obj21 ,
                               int forceLoad )
      {
         Gx_mode = obj21.gxTpr_Mode;
         A89JC_ProviderName = obj21.gxTpr_Jc_providername;
         n89JC_ProviderName = false;
         A160JC_ProviderShortName = obj21.gxTpr_Jc_providershortname;
         n160JC_ProviderShortName = false;
         A161JC_ProviderAddresss = obj21.gxTpr_Jc_provideraddresss;
         n161JC_ProviderAddresss = false;
         A162JC_ProviderPhone = obj21.gxTpr_Jc_providerphone;
         n162JC_ProviderPhone = false;
         A163JC_ProviderUser = obj21.gxTpr_Jc_provideruser;
         n163JC_ProviderUser = false;
         A87JC_ProviderID = obj21.gxTpr_Jc_providerid;
         Z87JC_ProviderID = obj21.gxTpr_Jc_providerid_Z;
         Z89JC_ProviderName = obj21.gxTpr_Jc_providername_Z;
         Z160JC_ProviderShortName = obj21.gxTpr_Jc_providershortname_Z;
         Z161JC_ProviderAddresss = obj21.gxTpr_Jc_provideraddresss_Z;
         Z162JC_ProviderPhone = obj21.gxTpr_Jc_providerphone_Z;
         Z163JC_ProviderUser = obj21.gxTpr_Jc_provideruser_Z;
         n89JC_ProviderName = (bool)(Convert.ToBoolean(obj21.gxTpr_Jc_providername_N));
         n160JC_ProviderShortName = (bool)(Convert.ToBoolean(obj21.gxTpr_Jc_providershortname_N));
         n161JC_ProviderAddresss = (bool)(Convert.ToBoolean(obj21.gxTpr_Jc_provideraddresss_N));
         n162JC_ProviderPhone = (bool)(Convert.ToBoolean(obj21.gxTpr_Jc_providerphone_N));
         n163JC_ProviderUser = (bool)(Convert.ToBoolean(obj21.gxTpr_Jc_provideruser_N));
         Gx_mode = obj21.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A87JC_ProviderID = (long)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey0K21( ) ;
         ScanKeyStart0K21( ) ;
         if ( RcdFound21 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z87JC_ProviderID = A87JC_ProviderID;
         }
         ZM0K21( -3) ;
         OnLoadActions0K21( ) ;
         AddRow0K21( ) ;
         ScanKeyEnd0K21( ) ;
         if ( RcdFound21 == 0 )
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
         RowToVars21( bcJC_Provider, 0) ;
         ScanKeyStart0K21( ) ;
         if ( RcdFound21 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z87JC_ProviderID = A87JC_ProviderID;
         }
         ZM0K21( -3) ;
         OnLoadActions0K21( ) ;
         AddRow0K21( ) ;
         ScanKeyEnd0K21( ) ;
         if ( RcdFound21 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey0K21( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert0K21( ) ;
         }
         else
         {
            if ( RcdFound21 == 1 )
            {
               if ( A87JC_ProviderID != Z87JC_ProviderID )
               {
                  A87JC_ProviderID = Z87JC_ProviderID;
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
                  Update0K21( ) ;
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
                  if ( A87JC_ProviderID != Z87JC_ProviderID )
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
                        Insert0K21( ) ;
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
                        Insert0K21( ) ;
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
         RowToVars21( bcJC_Provider, 0) ;
         SaveImpl( ) ;
         VarsToRow21( bcJC_Provider) ;
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
         RowToVars21( bcJC_Provider, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert0K21( ) ;
         AfterTrn( ) ;
         VarsToRow21( bcJC_Provider) ;
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
            SdtJC_Provider auxBC = new SdtJC_Provider(context) ;
            auxBC.Load(A87JC_ProviderID);
            auxBC.UpdateDirties(bcJC_Provider);
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
         RowToVars21( bcJC_Provider, 0) ;
         UpdateImpl( ) ;
         VarsToRow21( bcJC_Provider) ;
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
         RowToVars21( bcJC_Provider, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert0K21( ) ;
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
         VarsToRow21( bcJC_Provider) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars21( bcJC_Provider, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey0K21( ) ;
         if ( RcdFound21 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A87JC_ProviderID != Z87JC_ProviderID )
            {
               A87JC_ProviderID = Z87JC_ProviderID;
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
            if ( A87JC_ProviderID != Z87JC_ProviderID )
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
         context.RollbackDataStores("jc_provider_bc",pr_default);
         VarsToRow21( bcJC_Provider) ;
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
         Gx_mode = bcJC_Provider.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcJC_Provider.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcJC_Provider )
         {
            bcJC_Provider = (SdtJC_Provider)(sdt);
            if ( StringUtil.StrCmp(bcJC_Provider.gxTpr_Mode, "") == 0 )
            {
               bcJC_Provider.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow21( bcJC_Provider) ;
            }
            else
            {
               RowToVars21( bcJC_Provider, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcJC_Provider.gxTpr_Mode, "") == 0 )
            {
               bcJC_Provider.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars21( bcJC_Provider, 1) ;
         return  ;
      }

      public SdtJC_Provider JC_Provider_BC
      {
         get {
            return bcJC_Provider ;
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
         AV7WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV14Pgmname = "";
         AV8TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9WebSession = context.GetSession();
         Z89JC_ProviderName = "";
         A89JC_ProviderName = "";
         Z160JC_ProviderShortName = "";
         A160JC_ProviderShortName = "";
         Z161JC_ProviderAddresss = "";
         A161JC_ProviderAddresss = "";
         Z162JC_ProviderPhone = "";
         A162JC_ProviderPhone = "";
         Z163JC_ProviderUser = "";
         A163JC_ProviderUser = "";
         BC000K4_A87JC_ProviderID = new long[1] ;
         BC000K4_A89JC_ProviderName = new String[] {""} ;
         BC000K4_n89JC_ProviderName = new bool[] {false} ;
         BC000K4_A160JC_ProviderShortName = new String[] {""} ;
         BC000K4_n160JC_ProviderShortName = new bool[] {false} ;
         BC000K4_A161JC_ProviderAddresss = new String[] {""} ;
         BC000K4_n161JC_ProviderAddresss = new bool[] {false} ;
         BC000K4_A162JC_ProviderPhone = new String[] {""} ;
         BC000K4_n162JC_ProviderPhone = new bool[] {false} ;
         BC000K4_A163JC_ProviderUser = new String[] {""} ;
         BC000K4_n163JC_ProviderUser = new bool[] {false} ;
         BC000K5_A87JC_ProviderID = new long[1] ;
         BC000K3_A87JC_ProviderID = new long[1] ;
         BC000K3_A89JC_ProviderName = new String[] {""} ;
         BC000K3_n89JC_ProviderName = new bool[] {false} ;
         BC000K3_A160JC_ProviderShortName = new String[] {""} ;
         BC000K3_n160JC_ProviderShortName = new bool[] {false} ;
         BC000K3_A161JC_ProviderAddresss = new String[] {""} ;
         BC000K3_n161JC_ProviderAddresss = new bool[] {false} ;
         BC000K3_A162JC_ProviderPhone = new String[] {""} ;
         BC000K3_n162JC_ProviderPhone = new bool[] {false} ;
         BC000K3_A163JC_ProviderUser = new String[] {""} ;
         BC000K3_n163JC_ProviderUser = new bool[] {false} ;
         sMode21 = "";
         BC000K2_A87JC_ProviderID = new long[1] ;
         BC000K2_A89JC_ProviderName = new String[] {""} ;
         BC000K2_n89JC_ProviderName = new bool[] {false} ;
         BC000K2_A160JC_ProviderShortName = new String[] {""} ;
         BC000K2_n160JC_ProviderShortName = new bool[] {false} ;
         BC000K2_A161JC_ProviderAddresss = new String[] {""} ;
         BC000K2_n161JC_ProviderAddresss = new bool[] {false} ;
         BC000K2_A162JC_ProviderPhone = new String[] {""} ;
         BC000K2_n162JC_ProviderPhone = new bool[] {false} ;
         BC000K2_A163JC_ProviderUser = new String[] {""} ;
         BC000K2_n163JC_ProviderUser = new bool[] {false} ;
         BC000K6_A87JC_ProviderID = new long[1] ;
         BC000K9_A87JC_ProviderID = new long[1] ;
         BC000K9_A85BR_Information_ID = new long[1] ;
         BC000K10_A6SecUserId = new short[1] ;
         BC000K10_A87JC_ProviderID = new long[1] ;
         BC000K11_A87JC_ProviderID = new long[1] ;
         BC000K11_A89JC_ProviderName = new String[] {""} ;
         BC000K11_n89JC_ProviderName = new bool[] {false} ;
         BC000K11_A160JC_ProviderShortName = new String[] {""} ;
         BC000K11_n160JC_ProviderShortName = new bool[] {false} ;
         BC000K11_A161JC_ProviderAddresss = new String[] {""} ;
         BC000K11_n161JC_ProviderAddresss = new bool[] {false} ;
         BC000K11_A162JC_ProviderPhone = new String[] {""} ;
         BC000K11_n162JC_ProviderPhone = new bool[] {false} ;
         BC000K11_A163JC_ProviderUser = new String[] {""} ;
         BC000K11_n163JC_ProviderUser = new bool[] {false} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.jc_provider_bc__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.jc_provider_bc__default(),
            new Object[][] {
                new Object[] {
               BC000K2_A87JC_ProviderID, BC000K2_A89JC_ProviderName, BC000K2_n89JC_ProviderName, BC000K2_A160JC_ProviderShortName, BC000K2_n160JC_ProviderShortName, BC000K2_A161JC_ProviderAddresss, BC000K2_n161JC_ProviderAddresss, BC000K2_A162JC_ProviderPhone, BC000K2_n162JC_ProviderPhone, BC000K2_A163JC_ProviderUser,
               BC000K2_n163JC_ProviderUser
               }
               , new Object[] {
               BC000K3_A87JC_ProviderID, BC000K3_A89JC_ProviderName, BC000K3_n89JC_ProviderName, BC000K3_A160JC_ProviderShortName, BC000K3_n160JC_ProviderShortName, BC000K3_A161JC_ProviderAddresss, BC000K3_n161JC_ProviderAddresss, BC000K3_A162JC_ProviderPhone, BC000K3_n162JC_ProviderPhone, BC000K3_A163JC_ProviderUser,
               BC000K3_n163JC_ProviderUser
               }
               , new Object[] {
               BC000K4_A87JC_ProviderID, BC000K4_A89JC_ProviderName, BC000K4_n89JC_ProviderName, BC000K4_A160JC_ProviderShortName, BC000K4_n160JC_ProviderShortName, BC000K4_A161JC_ProviderAddresss, BC000K4_n161JC_ProviderAddresss, BC000K4_A162JC_ProviderPhone, BC000K4_n162JC_ProviderPhone, BC000K4_A163JC_ProviderUser,
               BC000K4_n163JC_ProviderUser
               }
               , new Object[] {
               BC000K5_A87JC_ProviderID
               }
               , new Object[] {
               BC000K6_A87JC_ProviderID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000K9_A87JC_ProviderID, BC000K9_A85BR_Information_ID
               }
               , new Object[] {
               BC000K10_A6SecUserId, BC000K10_A87JC_ProviderID
               }
               , new Object[] {
               BC000K11_A87JC_ProviderID, BC000K11_A89JC_ProviderName, BC000K11_n89JC_ProviderName, BC000K11_A160JC_ProviderShortName, BC000K11_n160JC_ProviderShortName, BC000K11_A161JC_ProviderAddresss, BC000K11_n161JC_ProviderAddresss, BC000K11_A162JC_ProviderPhone, BC000K11_n162JC_ProviderPhone, BC000K11_A163JC_ProviderUser,
               BC000K11_n163JC_ProviderUser
               }
            }
         );
         AV14Pgmname = "JC_Provider_BC";
         INITTRN();
         /* Execute Start event if defined. */
         /* Execute user event: Start */
         E120K2 ();
         standaloneNotModal( ) ;
      }

      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short GX_JID ;
      private short RcdFound21 ;
      private int trnEnded ;
      private long Z87JC_ProviderID ;
      private long A87JC_ProviderID ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String AV14Pgmname ;
      private String Z162JC_ProviderPhone ;
      private String A162JC_ProviderPhone ;
      private String sMode21 ;
      private bool AV11IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool n89JC_ProviderName ;
      private bool n160JC_ProviderShortName ;
      private bool n161JC_ProviderAddresss ;
      private bool n162JC_ProviderPhone ;
      private bool n163JC_ProviderUser ;
      private String Z89JC_ProviderName ;
      private String A89JC_ProviderName ;
      private String Z160JC_ProviderShortName ;
      private String A160JC_ProviderShortName ;
      private String Z161JC_ProviderAddresss ;
      private String A161JC_ProviderAddresss ;
      private String Z163JC_ProviderUser ;
      private String A163JC_ProviderUser ;
      private IGxSession AV9WebSession ;
      private SdtJC_Provider bcJC_Provider ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] BC000K4_A87JC_ProviderID ;
      private String[] BC000K4_A89JC_ProviderName ;
      private bool[] BC000K4_n89JC_ProviderName ;
      private String[] BC000K4_A160JC_ProviderShortName ;
      private bool[] BC000K4_n160JC_ProviderShortName ;
      private String[] BC000K4_A161JC_ProviderAddresss ;
      private bool[] BC000K4_n161JC_ProviderAddresss ;
      private String[] BC000K4_A162JC_ProviderPhone ;
      private bool[] BC000K4_n162JC_ProviderPhone ;
      private String[] BC000K4_A163JC_ProviderUser ;
      private bool[] BC000K4_n163JC_ProviderUser ;
      private long[] BC000K5_A87JC_ProviderID ;
      private long[] BC000K3_A87JC_ProviderID ;
      private String[] BC000K3_A89JC_ProviderName ;
      private bool[] BC000K3_n89JC_ProviderName ;
      private String[] BC000K3_A160JC_ProviderShortName ;
      private bool[] BC000K3_n160JC_ProviderShortName ;
      private String[] BC000K3_A161JC_ProviderAddresss ;
      private bool[] BC000K3_n161JC_ProviderAddresss ;
      private String[] BC000K3_A162JC_ProviderPhone ;
      private bool[] BC000K3_n162JC_ProviderPhone ;
      private String[] BC000K3_A163JC_ProviderUser ;
      private bool[] BC000K3_n163JC_ProviderUser ;
      private long[] BC000K2_A87JC_ProviderID ;
      private String[] BC000K2_A89JC_ProviderName ;
      private bool[] BC000K2_n89JC_ProviderName ;
      private String[] BC000K2_A160JC_ProviderShortName ;
      private bool[] BC000K2_n160JC_ProviderShortName ;
      private String[] BC000K2_A161JC_ProviderAddresss ;
      private bool[] BC000K2_n161JC_ProviderAddresss ;
      private String[] BC000K2_A162JC_ProviderPhone ;
      private bool[] BC000K2_n162JC_ProviderPhone ;
      private String[] BC000K2_A163JC_ProviderUser ;
      private bool[] BC000K2_n163JC_ProviderUser ;
      private long[] BC000K6_A87JC_ProviderID ;
      private long[] BC000K9_A87JC_ProviderID ;
      private long[] BC000K9_A85BR_Information_ID ;
      private short[] BC000K10_A6SecUserId ;
      private long[] BC000K10_A87JC_ProviderID ;
      private long[] BC000K11_A87JC_ProviderID ;
      private String[] BC000K11_A89JC_ProviderName ;
      private bool[] BC000K11_n89JC_ProviderName ;
      private String[] BC000K11_A160JC_ProviderShortName ;
      private bool[] BC000K11_n160JC_ProviderShortName ;
      private String[] BC000K11_A161JC_ProviderAddresss ;
      private bool[] BC000K11_n161JC_ProviderAddresss ;
      private String[] BC000K11_A162JC_ProviderPhone ;
      private bool[] BC000K11_n162JC_ProviderPhone ;
      private String[] BC000K11_A163JC_ProviderUser ;
      private bool[] BC000K11_n163JC_ProviderUser ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_datastore1 ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV7WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV8TrnContext ;
   }

   public class jc_provider_bc__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class jc_provider_bc__default : DataStoreHelperBase, IDataStoreHelper
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
       ,new ForEachCursor(def[9])
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmBC000K4 ;
        prmBC000K4 = new Object[] {
        new Object[] {"@JC_ProviderID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000K5 ;
        prmBC000K5 = new Object[] {
        new Object[] {"@JC_ProviderID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000K3 ;
        prmBC000K3 = new Object[] {
        new Object[] {"@JC_ProviderID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000K2 ;
        prmBC000K2 = new Object[] {
        new Object[] {"@JC_ProviderID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000K6 ;
        prmBC000K6 = new Object[] {
        new Object[] {"@JC_ProviderName",SqlDbType.NVarChar,200,0} ,
        new Object[] {"@JC_ProviderShortName",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@JC_ProviderAddresss",SqlDbType.NVarChar,1024,0} ,
        new Object[] {"@JC_ProviderPhone",SqlDbType.NChar,20,0} ,
        new Object[] {"@JC_ProviderUser",SqlDbType.NVarChar,40,0}
        } ;
        Object[] prmBC000K7 ;
        prmBC000K7 = new Object[] {
        new Object[] {"@JC_ProviderName",SqlDbType.NVarChar,200,0} ,
        new Object[] {"@JC_ProviderShortName",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@JC_ProviderAddresss",SqlDbType.NVarChar,1024,0} ,
        new Object[] {"@JC_ProviderPhone",SqlDbType.NChar,20,0} ,
        new Object[] {"@JC_ProviderUser",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@JC_ProviderID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000K8 ;
        prmBC000K8 = new Object[] {
        new Object[] {"@JC_ProviderID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000K9 ;
        prmBC000K9 = new Object[] {
        new Object[] {"@JC_ProviderID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000K10 ;
        prmBC000K10 = new Object[] {
        new Object[] {"@JC_ProviderID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000K11 ;
        prmBC000K11 = new Object[] {
        new Object[] {"@JC_ProviderID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("BC000K2", "SELECT [JC_ProviderID], [JC_ProviderName], [JC_ProviderShortName], [JC_ProviderAddresss], [JC_ProviderPhone], [JC_ProviderUser] FROM [JC_Provider] WITH (UPDLOCK) WHERE [JC_ProviderID] = @JC_ProviderID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000K2,1,0,true,false )
           ,new CursorDef("BC000K3", "SELECT [JC_ProviderID], [JC_ProviderName], [JC_ProviderShortName], [JC_ProviderAddresss], [JC_ProviderPhone], [JC_ProviderUser] FROM [JC_Provider] WITH (NOLOCK) WHERE [JC_ProviderID] = @JC_ProviderID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000K3,1,0,true,false )
           ,new CursorDef("BC000K4", "SELECT TM1.[JC_ProviderID], TM1.[JC_ProviderName], TM1.[JC_ProviderShortName], TM1.[JC_ProviderAddresss], TM1.[JC_ProviderPhone], TM1.[JC_ProviderUser] FROM [JC_Provider] TM1 WITH (NOLOCK) WHERE TM1.[JC_ProviderID] = @JC_ProviderID ORDER BY TM1.[JC_ProviderID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000K4,100,0,true,false )
           ,new CursorDef("BC000K5", "SELECT [JC_ProviderID] FROM [JC_Provider] WITH (NOLOCK) WHERE [JC_ProviderID] = @JC_ProviderID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000K5,1,0,true,false )
           ,new CursorDef("BC000K6", "INSERT INTO [JC_Provider]([JC_ProviderName], [JC_ProviderShortName], [JC_ProviderAddresss], [JC_ProviderPhone], [JC_ProviderUser]) VALUES(@JC_ProviderName, @JC_ProviderShortName, @JC_ProviderAddresss, @JC_ProviderPhone, @JC_ProviderUser); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmBC000K6)
           ,new CursorDef("BC000K7", "UPDATE [JC_Provider] SET [JC_ProviderName]=@JC_ProviderName, [JC_ProviderShortName]=@JC_ProviderShortName, [JC_ProviderAddresss]=@JC_ProviderAddresss, [JC_ProviderPhone]=@JC_ProviderPhone, [JC_ProviderUser]=@JC_ProviderUser  WHERE [JC_ProviderID] = @JC_ProviderID", GxErrorMask.GX_NOMASK,prmBC000K7)
           ,new CursorDef("BC000K8", "DELETE FROM [JC_Provider]  WHERE [JC_ProviderID] = @JC_ProviderID", GxErrorMask.GX_NOMASK,prmBC000K8)
           ,new CursorDef("BC000K9", "SELECT TOP 1 [JC_ProviderID], [BR_Information_ID] FROM [JC_Provider_Br_Information] WITH (NOLOCK) WHERE [JC_ProviderID] = @JC_ProviderID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000K9,1,0,true,true )
           ,new CursorDef("BC000K10", "SELECT TOP 1 [SecUserId], [JC_ProviderID] FROM [JC_ProviderSecUser] WITH (NOLOCK) WHERE [JC_ProviderID] = @JC_ProviderID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000K10,1,0,true,true )
           ,new CursorDef("BC000K11", "SELECT TM1.[JC_ProviderID], TM1.[JC_ProviderName], TM1.[JC_ProviderShortName], TM1.[JC_ProviderAddresss], TM1.[JC_ProviderPhone], TM1.[JC_ProviderUser] FROM [JC_Provider] TM1 WITH (NOLOCK) WHERE TM1.[JC_ProviderID] = @JC_ProviderID ORDER BY TM1.[JC_ProviderID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000K11,100,0,true,false )
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
              ((String[]) buf[7])[0] = rslt.getString(5, 20) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
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
              ((String[]) buf[7])[0] = rslt.getString(5, 20) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              return;
           case 2 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getString(5, 20) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              return;
           case 3 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 4 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 7 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              return;
           case 8 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              return;
           case 9 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getString(5, 20) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
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
                 stmt.setNull( 4 , SqlDbType.NChar );
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
                 stmt.setNull( 4 , SqlDbType.NChar );
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
              stmt.SetParameter(6, (long)parms[10]);
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
           case 9 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
     }
  }

}

}
