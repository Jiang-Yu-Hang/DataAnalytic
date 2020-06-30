/*
               File: BR_Information_BC
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:36:26.98
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
   public class br_information_bc : GXHttpHandler, IGxSilentTrn
   {
      public br_information_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_information_bc( IGxContext context )
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
         ReadRow0F16( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey0F16( ) ;
         standaloneModal( ) ;
         AddRow0F16( ) ;
         Gx_mode = "INS";
         return  ;
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E110F2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               Z85BR_Information_ID = A85BR_Information_ID;
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

      protected void CONFIRM_0F0( )
      {
         BeforeValidate0F16( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0F16( ) ;
            }
            else
            {
               CheckExtendedTable0F16( ) ;
               if ( AnyError == 0 )
               {
               }
               CloseExtendedTableCursors0F16( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void E120F2( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV8WWPContext) ;
         AV13IsAuthorized = true;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            GXt_boolean1 = AV13IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Information", out  GXt_boolean1) ;
            AV13IsAuthorized = GXt_boolean1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            GXt_boolean1 = AV13IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Information", out  GXt_boolean1) ;
            AV13IsAuthorized = GXt_boolean1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            GXt_boolean1 = AV13IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Information", out  GXt_boolean1) ;
            AV13IsAuthorized = GXt_boolean1;
         }
         if ( ! AV13IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV17Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV9TrnContext.FromXml(AV10WebSession.Get("TrnContext"), null, "WWPTransactionContext", "DataAnalysisPlatform");
      }

      protected void E110F2( )
      {
         /* After Trn Routine */
      }

      protected void ZM0F16( short GX_JID )
      {
         if ( ( GX_JID == 4 ) || ( GX_JID == 0 ) )
         {
            Z36BR_Information_PatientNo = A36BR_Information_PatientNo;
            Z100BR_Information_BirthDate = A100BR_Information_BirthDate;
            Z96BR_Information_CrtUser = A96BR_Information_CrtUser;
            Z95BR_Information_CrtDate = A95BR_Information_CrtDate;
         }
         if ( GX_JID == -4 )
         {
            Z85BR_Information_ID = A85BR_Information_ID;
            Z36BR_Information_PatientNo = A36BR_Information_PatientNo;
            Z100BR_Information_BirthDate = A100BR_Information_BirthDate;
            Z96BR_Information_CrtUser = A96BR_Information_CrtUser;
            Z95BR_Information_CrtDate = A95BR_Information_CrtDate;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load0F16( )
      {
         /* Using cursor BC000F4 */
         pr_default.execute(2, new Object[] {A85BR_Information_ID});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound16 = 1;
            A36BR_Information_PatientNo = BC000F4_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = BC000F4_n36BR_Information_PatientNo[0];
            A100BR_Information_BirthDate = BC000F4_A100BR_Information_BirthDate[0];
            n100BR_Information_BirthDate = BC000F4_n100BR_Information_BirthDate[0];
            A96BR_Information_CrtUser = BC000F4_A96BR_Information_CrtUser[0];
            n96BR_Information_CrtUser = BC000F4_n96BR_Information_CrtUser[0];
            A95BR_Information_CrtDate = BC000F4_A95BR_Information_CrtDate[0];
            n95BR_Information_CrtDate = BC000F4_n95BR_Information_CrtDate[0];
            ZM0F16( -4) ;
         }
         pr_default.close(2);
         OnLoadActions0F16( ) ;
      }

      protected void OnLoadActions0F16( )
      {
         AV17Pgmname = "BR_Information_BC";
      }

      protected void CheckExtendedTable0F16( )
      {
         standaloneModal( ) ;
         AV17Pgmname = "BR_Information_BC";
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A36BR_Information_PatientNo)) )
         {
            GX_msglist.addItem("患者编号是必须填写的。", 1, "");
            AnyError = 1;
         }
         if ( ! ( (DateTime.MinValue==A100BR_Information_BirthDate) || ( A100BR_Information_BirthDate >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("域������������������超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
         if ( ! ( (DateTime.MinValue==A95BR_Information_CrtDate) || ( A95BR_Information_CrtDate >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("域������������超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
      }

      protected void CloseExtendedTableCursors0F16( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0F16( )
      {
         /* Using cursor BC000F5 */
         pr_default.execute(3, new Object[] {A85BR_Information_ID});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound16 = 1;
         }
         else
         {
            RcdFound16 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC000F3 */
         pr_default.execute(1, new Object[] {A85BR_Information_ID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0F16( 4) ;
            RcdFound16 = 1;
            A85BR_Information_ID = BC000F3_A85BR_Information_ID[0];
            A36BR_Information_PatientNo = BC000F3_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = BC000F3_n36BR_Information_PatientNo[0];
            A100BR_Information_BirthDate = BC000F3_A100BR_Information_BirthDate[0];
            n100BR_Information_BirthDate = BC000F3_n100BR_Information_BirthDate[0];
            A96BR_Information_CrtUser = BC000F3_A96BR_Information_CrtUser[0];
            n96BR_Information_CrtUser = BC000F3_n96BR_Information_CrtUser[0];
            A95BR_Information_CrtDate = BC000F3_A95BR_Information_CrtDate[0];
            n95BR_Information_CrtDate = BC000F3_n95BR_Information_CrtDate[0];
            Z85BR_Information_ID = A85BR_Information_ID;
            sMode16 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load0F16( ) ;
            if ( AnyError == 1 )
            {
               RcdFound16 = 0;
               InitializeNonKey0F16( ) ;
            }
            Gx_mode = sMode16;
         }
         else
         {
            RcdFound16 = 0;
            InitializeNonKey0F16( ) ;
            sMode16 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode16;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0F16( ) ;
         if ( RcdFound16 == 0 )
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
         CONFIRM_0F0( ) ;
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

      protected void CheckOptimisticConcurrency0F16( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC000F2 */
            pr_default.execute(0, new Object[] {A85BR_Information_ID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Information"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z36BR_Information_PatientNo, BC000F2_A36BR_Information_PatientNo[0]) != 0 ) || ( Z100BR_Information_BirthDate != BC000F2_A100BR_Information_BirthDate[0] ) || ( StringUtil.StrCmp(Z96BR_Information_CrtUser, BC000F2_A96BR_Information_CrtUser[0]) != 0 ) || ( Z95BR_Information_CrtDate != BC000F2_A95BR_Information_CrtDate[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"BR_Information"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0F16( )
      {
         BeforeValidate0F16( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0F16( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0F16( 0) ;
            CheckOptimisticConcurrency0F16( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0F16( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0F16( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000F6 */
                     pr_default.execute(4, new Object[] {n36BR_Information_PatientNo, A36BR_Information_PatientNo, n100BR_Information_BirthDate, A100BR_Information_BirthDate, n96BR_Information_CrtUser, A96BR_Information_CrtUser, n95BR_Information_CrtDate, A95BR_Information_CrtDate});
                     A85BR_Information_ID = BC000F6_A85BR_Information_ID[0];
                     pr_default.close(4);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Information") ;
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
               Load0F16( ) ;
            }
            EndLevel0F16( ) ;
         }
         CloseExtendedTableCursors0F16( ) ;
      }

      protected void Update0F16( )
      {
         BeforeValidate0F16( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0F16( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0F16( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0F16( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0F16( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000F7 */
                     pr_default.execute(5, new Object[] {n36BR_Information_PatientNo, A36BR_Information_PatientNo, n100BR_Information_BirthDate, A100BR_Information_BirthDate, n96BR_Information_CrtUser, A96BR_Information_CrtUser, n95BR_Information_CrtDate, A95BR_Information_CrtDate, A85BR_Information_ID});
                     pr_default.close(5);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Information") ;
                     if ( (pr_default.getStatus(5) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Information"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0F16( ) ;
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
            EndLevel0F16( ) ;
         }
         CloseExtendedTableCursors0F16( ) ;
      }

      protected void DeferredUpdate0F16( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate0F16( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0F16( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0F16( ) ;
            AfterConfirm0F16( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0F16( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC000F8 */
                  pr_default.execute(6, new Object[] {A85BR_Information_ID});
                  pr_default.close(6);
                  dsDefault.SmartCacheProvider.SetUpdated("BR_Information") ;
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
         sMode16 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel0F16( ) ;
         Gx_mode = sMode16;
      }

      protected void OnDeleteControls0F16( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV17Pgmname = "BR_Information_BC";
         }
         if ( AnyError == 0 )
         {
            /* Using cursor BC000F9 */
            pr_default.execute(7, new Object[] {A85BR_Information_ID});
            if ( (pr_default.getStatus(7) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {" T64"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(7);
            /* Using cursor BC000F10 */
            pr_default.execute(8, new Object[] {A85BR_Information_ID});
            if ( (pr_default.getStatus(8) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {" T63"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(8);
            /* Using cursor BC000F11 */
            pr_default.execute(9, new Object[] {A85BR_Information_ID});
            if ( (pr_default.getStatus(9) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {" T28"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(9);
         }
      }

      protected void EndLevel0F16( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0F16( ) ;
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

      public void ScanKeyStart0F16( )
      {
         /* Scan By routine */
         /* Using cursor BC000F12 */
         pr_default.execute(10, new Object[] {A85BR_Information_ID});
         RcdFound16 = 0;
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound16 = 1;
            A85BR_Information_ID = BC000F12_A85BR_Information_ID[0];
            A36BR_Information_PatientNo = BC000F12_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = BC000F12_n36BR_Information_PatientNo[0];
            A100BR_Information_BirthDate = BC000F12_A100BR_Information_BirthDate[0];
            n100BR_Information_BirthDate = BC000F12_n100BR_Information_BirthDate[0];
            A96BR_Information_CrtUser = BC000F12_A96BR_Information_CrtUser[0];
            n96BR_Information_CrtUser = BC000F12_n96BR_Information_CrtUser[0];
            A95BR_Information_CrtDate = BC000F12_A95BR_Information_CrtDate[0];
            n95BR_Information_CrtDate = BC000F12_n95BR_Information_CrtDate[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext0F16( )
      {
         /* Scan next routine */
         pr_default.readNext(10);
         RcdFound16 = 0;
         ScanKeyLoad0F16( ) ;
      }

      protected void ScanKeyLoad0F16( )
      {
         sMode16 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound16 = 1;
            A85BR_Information_ID = BC000F12_A85BR_Information_ID[0];
            A36BR_Information_PatientNo = BC000F12_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = BC000F12_n36BR_Information_PatientNo[0];
            A100BR_Information_BirthDate = BC000F12_A100BR_Information_BirthDate[0];
            n100BR_Information_BirthDate = BC000F12_n100BR_Information_BirthDate[0];
            A96BR_Information_CrtUser = BC000F12_A96BR_Information_CrtUser[0];
            n96BR_Information_CrtUser = BC000F12_n96BR_Information_CrtUser[0];
            A95BR_Information_CrtDate = BC000F12_A95BR_Information_CrtDate[0];
            n95BR_Information_CrtDate = BC000F12_n95BR_Information_CrtDate[0];
         }
         Gx_mode = sMode16;
      }

      protected void ScanKeyEnd0F16( )
      {
         pr_default.close(10);
      }

      protected void AfterConfirm0F16( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0F16( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0F16( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0F16( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0F16( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0F16( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0F16( )
      {
      }

      protected void send_integrity_lvl_hashes0F16( )
      {
      }

      protected void AddRow0F16( )
      {
         VarsToRow16( bcBR_Information) ;
      }

      protected void ReadRow0F16( )
      {
         RowToVars16( bcBR_Information, 1) ;
      }

      protected void InitializeNonKey0F16( )
      {
         A36BR_Information_PatientNo = "";
         n36BR_Information_PatientNo = false;
         A100BR_Information_BirthDate = DateTime.MinValue;
         n100BR_Information_BirthDate = false;
         A96BR_Information_CrtUser = "";
         n96BR_Information_CrtUser = false;
         A95BR_Information_CrtDate = (DateTime)(DateTime.MinValue);
         n95BR_Information_CrtDate = false;
         Z36BR_Information_PatientNo = "";
         Z100BR_Information_BirthDate = DateTime.MinValue;
         Z96BR_Information_CrtUser = "";
         Z95BR_Information_CrtDate = (DateTime)(DateTime.MinValue);
      }

      protected void InitAll0F16( )
      {
         A85BR_Information_ID = 0;
         InitializeNonKey0F16( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow16( SdtBR_Information obj16 )
      {
         obj16.gxTpr_Mode = Gx_mode;
         obj16.gxTpr_Br_information_patientno = A36BR_Information_PatientNo;
         obj16.gxTpr_Br_information_birthdate = A100BR_Information_BirthDate;
         obj16.gxTpr_Br_information_crtuser = A96BR_Information_CrtUser;
         obj16.gxTpr_Br_information_crtdate = A95BR_Information_CrtDate;
         obj16.gxTpr_Br_information_id = A85BR_Information_ID;
         obj16.gxTpr_Br_information_id_Z = Z85BR_Information_ID;
         obj16.gxTpr_Br_information_patientno_Z = Z36BR_Information_PatientNo;
         obj16.gxTpr_Br_information_birthdate_Z = Z100BR_Information_BirthDate;
         obj16.gxTpr_Br_information_crtuser_Z = Z96BR_Information_CrtUser;
         obj16.gxTpr_Br_information_crtdate_Z = Z95BR_Information_CrtDate;
         obj16.gxTpr_Br_information_patientno_N = (short)(Convert.ToInt16(n36BR_Information_PatientNo));
         obj16.gxTpr_Br_information_birthdate_N = (short)(Convert.ToInt16(n100BR_Information_BirthDate));
         obj16.gxTpr_Br_information_crtuser_N = (short)(Convert.ToInt16(n96BR_Information_CrtUser));
         obj16.gxTpr_Br_information_crtdate_N = (short)(Convert.ToInt16(n95BR_Information_CrtDate));
         obj16.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow16( SdtBR_Information obj16 )
      {
         obj16.gxTpr_Br_information_id = A85BR_Information_ID;
         return  ;
      }

      public void RowToVars16( SdtBR_Information obj16 ,
                               int forceLoad )
      {
         Gx_mode = obj16.gxTpr_Mode;
         A36BR_Information_PatientNo = obj16.gxTpr_Br_information_patientno;
         n36BR_Information_PatientNo = false;
         A100BR_Information_BirthDate = obj16.gxTpr_Br_information_birthdate;
         n100BR_Information_BirthDate = false;
         A96BR_Information_CrtUser = obj16.gxTpr_Br_information_crtuser;
         n96BR_Information_CrtUser = false;
         A95BR_Information_CrtDate = obj16.gxTpr_Br_information_crtdate;
         n95BR_Information_CrtDate = false;
         A85BR_Information_ID = obj16.gxTpr_Br_information_id;
         Z85BR_Information_ID = obj16.gxTpr_Br_information_id_Z;
         Z36BR_Information_PatientNo = obj16.gxTpr_Br_information_patientno_Z;
         Z100BR_Information_BirthDate = obj16.gxTpr_Br_information_birthdate_Z;
         Z96BR_Information_CrtUser = obj16.gxTpr_Br_information_crtuser_Z;
         Z95BR_Information_CrtDate = obj16.gxTpr_Br_information_crtdate_Z;
         n36BR_Information_PatientNo = (bool)(Convert.ToBoolean(obj16.gxTpr_Br_information_patientno_N));
         n100BR_Information_BirthDate = (bool)(Convert.ToBoolean(obj16.gxTpr_Br_information_birthdate_N));
         n96BR_Information_CrtUser = (bool)(Convert.ToBoolean(obj16.gxTpr_Br_information_crtuser_N));
         n95BR_Information_CrtDate = (bool)(Convert.ToBoolean(obj16.gxTpr_Br_information_crtdate_N));
         Gx_mode = obj16.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A85BR_Information_ID = (long)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey0F16( ) ;
         ScanKeyStart0F16( ) ;
         if ( RcdFound16 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z85BR_Information_ID = A85BR_Information_ID;
         }
         ZM0F16( -4) ;
         OnLoadActions0F16( ) ;
         AddRow0F16( ) ;
         ScanKeyEnd0F16( ) ;
         if ( RcdFound16 == 0 )
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
         RowToVars16( bcBR_Information, 0) ;
         ScanKeyStart0F16( ) ;
         if ( RcdFound16 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z85BR_Information_ID = A85BR_Information_ID;
         }
         ZM0F16( -4) ;
         OnLoadActions0F16( ) ;
         AddRow0F16( ) ;
         ScanKeyEnd0F16( ) ;
         if ( RcdFound16 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey0F16( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert0F16( ) ;
         }
         else
         {
            if ( RcdFound16 == 1 )
            {
               if ( A85BR_Information_ID != Z85BR_Information_ID )
               {
                  A85BR_Information_ID = Z85BR_Information_ID;
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
                  Update0F16( ) ;
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
                  if ( A85BR_Information_ID != Z85BR_Information_ID )
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
                        Insert0F16( ) ;
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
                        Insert0F16( ) ;
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
         RowToVars16( bcBR_Information, 0) ;
         SaveImpl( ) ;
         VarsToRow16( bcBR_Information) ;
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
         RowToVars16( bcBR_Information, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert0F16( ) ;
         AfterTrn( ) ;
         VarsToRow16( bcBR_Information) ;
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
            SdtBR_Information auxBC = new SdtBR_Information(context) ;
            auxBC.Load(A85BR_Information_ID);
            auxBC.UpdateDirties(bcBR_Information);
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
         RowToVars16( bcBR_Information, 0) ;
         UpdateImpl( ) ;
         VarsToRow16( bcBR_Information) ;
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
         RowToVars16( bcBR_Information, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert0F16( ) ;
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
         VarsToRow16( bcBR_Information) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars16( bcBR_Information, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey0F16( ) ;
         if ( RcdFound16 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A85BR_Information_ID != Z85BR_Information_ID )
            {
               A85BR_Information_ID = Z85BR_Information_ID;
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
            if ( A85BR_Information_ID != Z85BR_Information_ID )
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
         context.RollbackDataStores("br_information_bc",pr_default);
         VarsToRow16( bcBR_Information) ;
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
         Gx_mode = bcBR_Information.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcBR_Information.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcBR_Information )
         {
            bcBR_Information = (SdtBR_Information)(sdt);
            if ( StringUtil.StrCmp(bcBR_Information.gxTpr_Mode, "") == 0 )
            {
               bcBR_Information.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow16( bcBR_Information) ;
            }
            else
            {
               RowToVars16( bcBR_Information, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcBR_Information.gxTpr_Mode, "") == 0 )
            {
               bcBR_Information.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars16( bcBR_Information, 1) ;
         return  ;
      }

      public SdtBR_Information BR_Information_BC
      {
         get {
            return bcBR_Information ;
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
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV10WebSession = context.GetSession();
         Z36BR_Information_PatientNo = "";
         A36BR_Information_PatientNo = "";
         Z100BR_Information_BirthDate = DateTime.MinValue;
         A100BR_Information_BirthDate = DateTime.MinValue;
         Z96BR_Information_CrtUser = "";
         A96BR_Information_CrtUser = "";
         Z95BR_Information_CrtDate = (DateTime)(DateTime.MinValue);
         A95BR_Information_CrtDate = (DateTime)(DateTime.MinValue);
         BC000F4_A85BR_Information_ID = new long[1] ;
         BC000F4_A36BR_Information_PatientNo = new String[] {""} ;
         BC000F4_n36BR_Information_PatientNo = new bool[] {false} ;
         BC000F4_A100BR_Information_BirthDate = new DateTime[] {DateTime.MinValue} ;
         BC000F4_n100BR_Information_BirthDate = new bool[] {false} ;
         BC000F4_A96BR_Information_CrtUser = new String[] {""} ;
         BC000F4_n96BR_Information_CrtUser = new bool[] {false} ;
         BC000F4_A95BR_Information_CrtDate = new DateTime[] {DateTime.MinValue} ;
         BC000F4_n95BR_Information_CrtDate = new bool[] {false} ;
         BC000F5_A85BR_Information_ID = new long[1] ;
         BC000F3_A85BR_Information_ID = new long[1] ;
         BC000F3_A36BR_Information_PatientNo = new String[] {""} ;
         BC000F3_n36BR_Information_PatientNo = new bool[] {false} ;
         BC000F3_A100BR_Information_BirthDate = new DateTime[] {DateTime.MinValue} ;
         BC000F3_n100BR_Information_BirthDate = new bool[] {false} ;
         BC000F3_A96BR_Information_CrtUser = new String[] {""} ;
         BC000F3_n96BR_Information_CrtUser = new bool[] {false} ;
         BC000F3_A95BR_Information_CrtDate = new DateTime[] {DateTime.MinValue} ;
         BC000F3_n95BR_Information_CrtDate = new bool[] {false} ;
         sMode16 = "";
         BC000F2_A85BR_Information_ID = new long[1] ;
         BC000F2_A36BR_Information_PatientNo = new String[] {""} ;
         BC000F2_n36BR_Information_PatientNo = new bool[] {false} ;
         BC000F2_A100BR_Information_BirthDate = new DateTime[] {DateTime.MinValue} ;
         BC000F2_n100BR_Information_BirthDate = new bool[] {false} ;
         BC000F2_A96BR_Information_CrtUser = new String[] {""} ;
         BC000F2_n96BR_Information_CrtUser = new bool[] {false} ;
         BC000F2_A95BR_Information_CrtDate = new DateTime[] {DateTime.MinValue} ;
         BC000F2_n95BR_Information_CrtDate = new bool[] {false} ;
         BC000F6_A85BR_Information_ID = new long[1] ;
         BC000F9_A85BR_Information_ID = new long[1] ;
         BC000F9_A360BAS_TenantTenantCode = new String[] {""} ;
         BC000F10_A85BR_Information_ID = new long[1] ;
         BC000F10_A366DataPackage = new String[] {""} ;
         BC000F11_A87JC_ProviderID = new long[1] ;
         BC000F11_A85BR_Information_ID = new long[1] ;
         BC000F12_A85BR_Information_ID = new long[1] ;
         BC000F12_A36BR_Information_PatientNo = new String[] {""} ;
         BC000F12_n36BR_Information_PatientNo = new bool[] {false} ;
         BC000F12_A100BR_Information_BirthDate = new DateTime[] {DateTime.MinValue} ;
         BC000F12_n100BR_Information_BirthDate = new bool[] {false} ;
         BC000F12_A96BR_Information_CrtUser = new String[] {""} ;
         BC000F12_n96BR_Information_CrtUser = new bool[] {false} ;
         BC000F12_A95BR_Information_CrtDate = new DateTime[] {DateTime.MinValue} ;
         BC000F12_n95BR_Information_CrtDate = new bool[] {false} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_information_bc__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_information_bc__default(),
            new Object[][] {
                new Object[] {
               BC000F2_A85BR_Information_ID, BC000F2_A36BR_Information_PatientNo, BC000F2_n36BR_Information_PatientNo, BC000F2_A100BR_Information_BirthDate, BC000F2_n100BR_Information_BirthDate, BC000F2_A96BR_Information_CrtUser, BC000F2_n96BR_Information_CrtUser, BC000F2_A95BR_Information_CrtDate, BC000F2_n95BR_Information_CrtDate
               }
               , new Object[] {
               BC000F3_A85BR_Information_ID, BC000F3_A36BR_Information_PatientNo, BC000F3_n36BR_Information_PatientNo, BC000F3_A100BR_Information_BirthDate, BC000F3_n100BR_Information_BirthDate, BC000F3_A96BR_Information_CrtUser, BC000F3_n96BR_Information_CrtUser, BC000F3_A95BR_Information_CrtDate, BC000F3_n95BR_Information_CrtDate
               }
               , new Object[] {
               BC000F4_A85BR_Information_ID, BC000F4_A36BR_Information_PatientNo, BC000F4_n36BR_Information_PatientNo, BC000F4_A100BR_Information_BirthDate, BC000F4_n100BR_Information_BirthDate, BC000F4_A96BR_Information_CrtUser, BC000F4_n96BR_Information_CrtUser, BC000F4_A95BR_Information_CrtDate, BC000F4_n95BR_Information_CrtDate
               }
               , new Object[] {
               BC000F5_A85BR_Information_ID
               }
               , new Object[] {
               BC000F6_A85BR_Information_ID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000F9_A85BR_Information_ID, BC000F9_A360BAS_TenantTenantCode
               }
               , new Object[] {
               BC000F10_A85BR_Information_ID, BC000F10_A366DataPackage
               }
               , new Object[] {
               BC000F11_A87JC_ProviderID, BC000F11_A85BR_Information_ID
               }
               , new Object[] {
               BC000F12_A85BR_Information_ID, BC000F12_A36BR_Information_PatientNo, BC000F12_n36BR_Information_PatientNo, BC000F12_A100BR_Information_BirthDate, BC000F12_n100BR_Information_BirthDate, BC000F12_A96BR_Information_CrtUser, BC000F12_n96BR_Information_CrtUser, BC000F12_A95BR_Information_CrtDate, BC000F12_n95BR_Information_CrtDate
               }
            }
         );
         AV17Pgmname = "BR_Information_BC";
         INITTRN();
         /* Execute Start event if defined. */
         /* Execute user event: Start */
         E120F2 ();
         standaloneNotModal( ) ;
      }

      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short GX_JID ;
      private short RcdFound16 ;
      private int trnEnded ;
      private long Z85BR_Information_ID ;
      private long A85BR_Information_ID ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String AV17Pgmname ;
      private String sMode16 ;
      private DateTime Z95BR_Information_CrtDate ;
      private DateTime A95BR_Information_CrtDate ;
      private DateTime Z100BR_Information_BirthDate ;
      private DateTime A100BR_Information_BirthDate ;
      private bool AV13IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool n36BR_Information_PatientNo ;
      private bool n100BR_Information_BirthDate ;
      private bool n96BR_Information_CrtUser ;
      private bool n95BR_Information_CrtDate ;
      private String Z36BR_Information_PatientNo ;
      private String A36BR_Information_PatientNo ;
      private String Z96BR_Information_CrtUser ;
      private String A96BR_Information_CrtUser ;
      private IGxSession AV10WebSession ;
      private SdtBR_Information bcBR_Information ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] BC000F4_A85BR_Information_ID ;
      private String[] BC000F4_A36BR_Information_PatientNo ;
      private bool[] BC000F4_n36BR_Information_PatientNo ;
      private DateTime[] BC000F4_A100BR_Information_BirthDate ;
      private bool[] BC000F4_n100BR_Information_BirthDate ;
      private String[] BC000F4_A96BR_Information_CrtUser ;
      private bool[] BC000F4_n96BR_Information_CrtUser ;
      private DateTime[] BC000F4_A95BR_Information_CrtDate ;
      private bool[] BC000F4_n95BR_Information_CrtDate ;
      private long[] BC000F5_A85BR_Information_ID ;
      private long[] BC000F3_A85BR_Information_ID ;
      private String[] BC000F3_A36BR_Information_PatientNo ;
      private bool[] BC000F3_n36BR_Information_PatientNo ;
      private DateTime[] BC000F3_A100BR_Information_BirthDate ;
      private bool[] BC000F3_n100BR_Information_BirthDate ;
      private String[] BC000F3_A96BR_Information_CrtUser ;
      private bool[] BC000F3_n96BR_Information_CrtUser ;
      private DateTime[] BC000F3_A95BR_Information_CrtDate ;
      private bool[] BC000F3_n95BR_Information_CrtDate ;
      private long[] BC000F2_A85BR_Information_ID ;
      private String[] BC000F2_A36BR_Information_PatientNo ;
      private bool[] BC000F2_n36BR_Information_PatientNo ;
      private DateTime[] BC000F2_A100BR_Information_BirthDate ;
      private bool[] BC000F2_n100BR_Information_BirthDate ;
      private String[] BC000F2_A96BR_Information_CrtUser ;
      private bool[] BC000F2_n96BR_Information_CrtUser ;
      private DateTime[] BC000F2_A95BR_Information_CrtDate ;
      private bool[] BC000F2_n95BR_Information_CrtDate ;
      private long[] BC000F6_A85BR_Information_ID ;
      private long[] BC000F9_A85BR_Information_ID ;
      private String[] BC000F9_A360BAS_TenantTenantCode ;
      private long[] BC000F10_A85BR_Information_ID ;
      private String[] BC000F10_A366DataPackage ;
      private long[] BC000F11_A87JC_ProviderID ;
      private long[] BC000F11_A85BR_Information_ID ;
      private long[] BC000F12_A85BR_Information_ID ;
      private String[] BC000F12_A36BR_Information_PatientNo ;
      private bool[] BC000F12_n36BR_Information_PatientNo ;
      private DateTime[] BC000F12_A100BR_Information_BirthDate ;
      private bool[] BC000F12_n100BR_Information_BirthDate ;
      private String[] BC000F12_A96BR_Information_CrtUser ;
      private bool[] BC000F12_n96BR_Information_CrtUser ;
      private DateTime[] BC000F12_A95BR_Information_CrtDate ;
      private bool[] BC000F12_n95BR_Information_CrtDate ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_datastore1 ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV8WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV9TrnContext ;
   }

   public class br_information_bc__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class br_information_bc__default : DataStoreHelperBase, IDataStoreHelper
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
       ,new ForEachCursor(def[10])
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmBC000F4 ;
        prmBC000F4 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000F5 ;
        prmBC000F5 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000F3 ;
        prmBC000F3 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000F2 ;
        prmBC000F2 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000F6 ;
        prmBC000F6 = new Object[] {
        new Object[] {"@BR_Information_PatientNo",SqlDbType.NVarChar,2000,0} ,
        new Object[] {"@BR_Information_BirthDate",SqlDbType.DateTime,8,0} ,
        new Object[] {"@BR_Information_CrtUser",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Information_CrtDate",SqlDbType.DateTime,10,8}
        } ;
        Object[] prmBC000F7 ;
        prmBC000F7 = new Object[] {
        new Object[] {"@BR_Information_PatientNo",SqlDbType.NVarChar,2000,0} ,
        new Object[] {"@BR_Information_BirthDate",SqlDbType.DateTime,8,0} ,
        new Object[] {"@BR_Information_CrtUser",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Information_CrtDate",SqlDbType.DateTime,10,8} ,
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000F8 ;
        prmBC000F8 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000F9 ;
        prmBC000F9 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000F10 ;
        prmBC000F10 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000F11 ;
        prmBC000F11 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000F12 ;
        prmBC000F12 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("BC000F2", "SELECT [BR_Information_ID], [BR_Information_PatientNo], [BR_Information_BirthDate], [BR_Information_CrtUser], [BR_Information_CrtDate] FROM [BR_Information] WITH (UPDLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000F2,1,0,true,false )
           ,new CursorDef("BC000F3", "SELECT [BR_Information_ID], [BR_Information_PatientNo], [BR_Information_BirthDate], [BR_Information_CrtUser], [BR_Information_CrtDate] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000F3,1,0,true,false )
           ,new CursorDef("BC000F4", "SELECT TM1.[BR_Information_ID], TM1.[BR_Information_PatientNo], TM1.[BR_Information_BirthDate], TM1.[BR_Information_CrtUser], TM1.[BR_Information_CrtDate] FROM [BR_Information] TM1 WITH (NOLOCK) WHERE TM1.[BR_Information_ID] = @BR_Information_ID ORDER BY TM1.[BR_Information_ID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000F4,100,0,true,false )
           ,new CursorDef("BC000F5", "SELECT [BR_Information_ID] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000F5,1,0,true,false )
           ,new CursorDef("BC000F6", "INSERT INTO [BR_Information]([BR_Information_PatientNo], [BR_Information_BirthDate], [BR_Information_CrtUser], [BR_Information_CrtDate]) VALUES(@BR_Information_PatientNo, @BR_Information_BirthDate, @BR_Information_CrtUser, @BR_Information_CrtDate); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmBC000F6)
           ,new CursorDef("BC000F7", "UPDATE [BR_Information] SET [BR_Information_PatientNo]=@BR_Information_PatientNo, [BR_Information_BirthDate]=@BR_Information_BirthDate, [BR_Information_CrtUser]=@BR_Information_CrtUser, [BR_Information_CrtDate]=@BR_Information_CrtDate  WHERE [BR_Information_ID] = @BR_Information_ID", GxErrorMask.GX_NOMASK,prmBC000F7)
           ,new CursorDef("BC000F8", "DELETE FROM [BR_Information]  WHERE [BR_Information_ID] = @BR_Information_ID", GxErrorMask.GX_NOMASK,prmBC000F8)
           ,new CursorDef("BC000F9", "SELECT TOP 1 [BR_Information_ID], [BAS_TenantTenantCode] FROM [BR_PatientReTenant] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000F9,1,0,true,true )
           ,new CursorDef("BC000F10", "SELECT TOP 1 [BR_Information_ID], [DataPackage] FROM [BR_PatientReEntity] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000F10,1,0,true,true )
           ,new CursorDef("BC000F11", "SELECT TOP 1 [JC_ProviderID], [BR_Information_ID] FROM [JC_Provider_Br_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000F11,1,0,true,true )
           ,new CursorDef("BC000F12", "SELECT TM1.[BR_Information_ID], TM1.[BR_Information_PatientNo], TM1.[BR_Information_BirthDate], TM1.[BR_Information_CrtUser], TM1.[BR_Information_CrtDate] FROM [BR_Information] TM1 WITH (NOLOCK) WHERE TM1.[BR_Information_ID] = @BR_Information_ID ORDER BY TM1.[BR_Information_ID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000F12,100,0,true,false )
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
              ((DateTime[]) buf[3])[0] = rslt.getGXDate(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((DateTime[]) buf[7])[0] = rslt.getGXDateTime(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((DateTime[]) buf[3])[0] = rslt.getGXDate(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((DateTime[]) buf[7])[0] = rslt.getGXDateTime(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              return;
           case 2 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((DateTime[]) buf[3])[0] = rslt.getGXDate(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((DateTime[]) buf[7])[0] = rslt.getGXDateTime(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
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
              return;
           case 8 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              return;
           case 9 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              return;
           case 10 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((DateTime[]) buf[3])[0] = rslt.getGXDate(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((DateTime[]) buf[7])[0] = rslt.getGXDateTime(5) ;
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
                 stmt.setNull( 2 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameter(2, (DateTime)parms[3]);
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
                 stmt.setNull( 4 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(4, (DateTime)parms[7]);
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
                 stmt.setNull( 2 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameter(2, (DateTime)parms[3]);
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
                 stmt.setNull( 4 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(4, (DateTime)parms[7]);
              }
              stmt.SetParameter(5, (long)parms[8]);
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
           case 10 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
     }
  }

}

}
