/*
               File: JC_Provider_Br_Information_BC
        Description: 患者分院表
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:7:51.50
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
   public class jc_provider_br_information_bc : GXHttpHandler, IGxSilentTrn
   {
      public jc_provider_br_information_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public jc_provider_br_information_bc( IGxContext context )
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
         ReadRow0R28( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey0R28( ) ;
         standaloneModal( ) ;
         AddRow0R28( ) ;
         Gx_mode = "INS";
         return  ;
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               Z87JC_ProviderID = A87JC_ProviderID;
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

      protected void CONFIRM_0R0( )
      {
         BeforeValidate0R28( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0R28( ) ;
            }
            else
            {
               CheckExtendedTable0R28( ) ;
               if ( AnyError == 0 )
               {
                  ZM0R28( 2) ;
                  ZM0R28( 3) ;
               }
               CloseExtendedTableCursors0R28( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void ZM0R28( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
         }
         if ( ( GX_JID == 2 ) || ( GX_JID == 0 ) )
         {
            Z89JC_ProviderName = A89JC_ProviderName;
         }
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            Z36BR_Information_PatientNo = A36BR_Information_PatientNo;
         }
         if ( GX_JID == -1 )
         {
            Z87JC_ProviderID = A87JC_ProviderID;
            Z85BR_Information_ID = A85BR_Information_ID;
            Z89JC_ProviderName = A89JC_ProviderName;
            Z36BR_Information_PatientNo = A36BR_Information_PatientNo;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load0R28( )
      {
         /* Using cursor BC000R6 */
         pr_default.execute(4, new Object[] {A87JC_ProviderID, A85BR_Information_ID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound28 = 1;
            A89JC_ProviderName = BC000R6_A89JC_ProviderName[0];
            n89JC_ProviderName = BC000R6_n89JC_ProviderName[0];
            A36BR_Information_PatientNo = BC000R6_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = BC000R6_n36BR_Information_PatientNo[0];
            ZM0R28( -1) ;
         }
         pr_default.close(4);
         OnLoadActions0R28( ) ;
      }

      protected void OnLoadActions0R28( )
      {
      }

      protected void CheckExtendedTable0R28( )
      {
         standaloneModal( ) ;
         /* Using cursor BC000R4 */
         pr_default.execute(2, new Object[] {A87JC_ProviderID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("不匹配' T21'", "ForeignKeyNotFound", 1, "JC_PROVIDERID");
            AnyError = 1;
         }
         A89JC_ProviderName = BC000R4_A89JC_ProviderName[0];
         n89JC_ProviderName = BC000R4_n89JC_ProviderName[0];
         pr_default.close(2);
         /* Using cursor BC000R5 */
         pr_default.execute(3, new Object[] {A85BR_Information_ID});
         if ( (pr_default.getStatus(3) == 101) )
         {
            GX_msglist.addItem("不匹配' T16'", "ForeignKeyNotFound", 1, "BR_INFORMATION_ID");
            AnyError = 1;
         }
         A36BR_Information_PatientNo = BC000R5_A36BR_Information_PatientNo[0];
         n36BR_Information_PatientNo = BC000R5_n36BR_Information_PatientNo[0];
         pr_default.close(3);
      }

      protected void CloseExtendedTableCursors0R28( )
      {
         pr_default.close(2);
         pr_default.close(3);
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0R28( )
      {
         /* Using cursor BC000R7 */
         pr_default.execute(5, new Object[] {A87JC_ProviderID, A85BR_Information_ID});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound28 = 1;
         }
         else
         {
            RcdFound28 = 0;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC000R3 */
         pr_default.execute(1, new Object[] {A87JC_ProviderID, A85BR_Information_ID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0R28( 1) ;
            RcdFound28 = 1;
            A87JC_ProviderID = BC000R3_A87JC_ProviderID[0];
            A85BR_Information_ID = BC000R3_A85BR_Information_ID[0];
            Z87JC_ProviderID = A87JC_ProviderID;
            Z85BR_Information_ID = A85BR_Information_ID;
            sMode28 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load0R28( ) ;
            if ( AnyError == 1 )
            {
               RcdFound28 = 0;
               InitializeNonKey0R28( ) ;
            }
            Gx_mode = sMode28;
         }
         else
         {
            RcdFound28 = 0;
            InitializeNonKey0R28( ) ;
            sMode28 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode28;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0R28( ) ;
         if ( RcdFound28 == 0 )
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
         CONFIRM_0R0( ) ;
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

      protected void CheckOptimisticConcurrency0R28( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC000R2 */
            pr_default.execute(0, new Object[] {A87JC_ProviderID, A85BR_Information_ID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"JC_Provider_Br_Information"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"JC_Provider_Br_Information"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0R28( )
      {
         BeforeValidate0R28( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0R28( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0R28( 0) ;
            CheckOptimisticConcurrency0R28( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0R28( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0R28( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000R8 */
                     pr_default.execute(6, new Object[] {A87JC_ProviderID, A85BR_Information_ID});
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("JC_Provider_Br_Information") ;
                     if ( (pr_default.getStatus(6) == 1) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
                        AnyError = 1;
                     }
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
               Load0R28( ) ;
            }
            EndLevel0R28( ) ;
         }
         CloseExtendedTableCursors0R28( ) ;
      }

      protected void Update0R28( )
      {
         BeforeValidate0R28( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0R28( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0R28( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0R28( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0R28( ) ;
                  if ( AnyError == 0 )
                  {
                     /* No attributes to update on table [JC_Provider_Br_Information] */
                     DeferredUpdate0R28( ) ;
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
            EndLevel0R28( ) ;
         }
         CloseExtendedTableCursors0R28( ) ;
      }

      protected void DeferredUpdate0R28( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate0R28( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0R28( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0R28( ) ;
            AfterConfirm0R28( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0R28( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC000R9 */
                  pr_default.execute(7, new Object[] {A87JC_ProviderID, A85BR_Information_ID});
                  pr_default.close(7);
                  dsDefault.SmartCacheProvider.SetUpdated("JC_Provider_Br_Information") ;
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
         sMode28 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel0R28( ) ;
         Gx_mode = sMode28;
      }

      protected void OnDeleteControls0R28( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor BC000R10 */
            pr_default.execute(8, new Object[] {A87JC_ProviderID});
            A89JC_ProviderName = BC000R10_A89JC_ProviderName[0];
            n89JC_ProviderName = BC000R10_n89JC_ProviderName[0];
            pr_default.close(8);
            /* Using cursor BC000R11 */
            pr_default.execute(9, new Object[] {A85BR_Information_ID});
            A36BR_Information_PatientNo = BC000R11_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = BC000R11_n36BR_Information_PatientNo[0];
            pr_default.close(9);
         }
      }

      protected void EndLevel0R28( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0R28( ) ;
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

      public void ScanKeyStart0R28( )
      {
         /* Using cursor BC000R12 */
         pr_default.execute(10, new Object[] {A87JC_ProviderID, A85BR_Information_ID});
         RcdFound28 = 0;
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound28 = 1;
            A89JC_ProviderName = BC000R12_A89JC_ProviderName[0];
            n89JC_ProviderName = BC000R12_n89JC_ProviderName[0];
            A36BR_Information_PatientNo = BC000R12_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = BC000R12_n36BR_Information_PatientNo[0];
            A87JC_ProviderID = BC000R12_A87JC_ProviderID[0];
            A85BR_Information_ID = BC000R12_A85BR_Information_ID[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext0R28( )
      {
         /* Scan next routine */
         pr_default.readNext(10);
         RcdFound28 = 0;
         ScanKeyLoad0R28( ) ;
      }

      protected void ScanKeyLoad0R28( )
      {
         sMode28 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound28 = 1;
            A89JC_ProviderName = BC000R12_A89JC_ProviderName[0];
            n89JC_ProviderName = BC000R12_n89JC_ProviderName[0];
            A36BR_Information_PatientNo = BC000R12_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = BC000R12_n36BR_Information_PatientNo[0];
            A87JC_ProviderID = BC000R12_A87JC_ProviderID[0];
            A85BR_Information_ID = BC000R12_A85BR_Information_ID[0];
         }
         Gx_mode = sMode28;
      }

      protected void ScanKeyEnd0R28( )
      {
         pr_default.close(10);
      }

      protected void AfterConfirm0R28( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0R28( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0R28( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0R28( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0R28( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0R28( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0R28( )
      {
      }

      protected void send_integrity_lvl_hashes0R28( )
      {
      }

      protected void AddRow0R28( )
      {
         VarsToRow28( bcJC_Provider_Br_Information) ;
      }

      protected void ReadRow0R28( )
      {
         RowToVars28( bcJC_Provider_Br_Information, 1) ;
      }

      protected void InitializeNonKey0R28( )
      {
         A89JC_ProviderName = "";
         n89JC_ProviderName = false;
         A36BR_Information_PatientNo = "";
         n36BR_Information_PatientNo = false;
      }

      protected void InitAll0R28( )
      {
         A87JC_ProviderID = 0;
         A85BR_Information_ID = 0;
         InitializeNonKey0R28( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow28( SdtJC_Provider_Br_Information obj28 )
      {
         obj28.gxTpr_Mode = Gx_mode;
         obj28.gxTpr_Jc_providername = A89JC_ProviderName;
         obj28.gxTpr_Br_information_patientno = A36BR_Information_PatientNo;
         obj28.gxTpr_Jc_providerid = A87JC_ProviderID;
         obj28.gxTpr_Br_information_id = A85BR_Information_ID;
         obj28.gxTpr_Jc_providerid_Z = Z87JC_ProviderID;
         obj28.gxTpr_Br_information_id_Z = Z85BR_Information_ID;
         obj28.gxTpr_Jc_providername_Z = Z89JC_ProviderName;
         obj28.gxTpr_Br_information_patientno_Z = Z36BR_Information_PatientNo;
         obj28.gxTpr_Jc_providername_N = (short)(Convert.ToInt16(n89JC_ProviderName));
         obj28.gxTpr_Br_information_patientno_N = (short)(Convert.ToInt16(n36BR_Information_PatientNo));
         obj28.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow28( SdtJC_Provider_Br_Information obj28 )
      {
         obj28.gxTpr_Jc_providerid = A87JC_ProviderID;
         obj28.gxTpr_Br_information_id = A85BR_Information_ID;
         return  ;
      }

      public void RowToVars28( SdtJC_Provider_Br_Information obj28 ,
                               int forceLoad )
      {
         Gx_mode = obj28.gxTpr_Mode;
         A89JC_ProviderName = obj28.gxTpr_Jc_providername;
         n89JC_ProviderName = false;
         A36BR_Information_PatientNo = obj28.gxTpr_Br_information_patientno;
         n36BR_Information_PatientNo = false;
         A87JC_ProviderID = obj28.gxTpr_Jc_providerid;
         A85BR_Information_ID = obj28.gxTpr_Br_information_id;
         Z87JC_ProviderID = obj28.gxTpr_Jc_providerid_Z;
         Z85BR_Information_ID = obj28.gxTpr_Br_information_id_Z;
         Z89JC_ProviderName = obj28.gxTpr_Jc_providername_Z;
         Z36BR_Information_PatientNo = obj28.gxTpr_Br_information_patientno_Z;
         n89JC_ProviderName = (bool)(Convert.ToBoolean(obj28.gxTpr_Jc_providername_N));
         n36BR_Information_PatientNo = (bool)(Convert.ToBoolean(obj28.gxTpr_Br_information_patientno_N));
         Gx_mode = obj28.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A87JC_ProviderID = (long)getParm(obj,0);
         A85BR_Information_ID = (long)getParm(obj,1);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey0R28( ) ;
         ScanKeyStart0R28( ) ;
         if ( RcdFound28 == 0 )
         {
            Gx_mode = "INS";
            /* Using cursor BC000R10 */
            pr_default.execute(8, new Object[] {A87JC_ProviderID});
            if ( (pr_default.getStatus(8) == 101) )
            {
               GX_msglist.addItem("不匹配' T21'", "ForeignKeyNotFound", 1, "JC_PROVIDERID");
               AnyError = 1;
            }
            A89JC_ProviderName = BC000R10_A89JC_ProviderName[0];
            n89JC_ProviderName = BC000R10_n89JC_ProviderName[0];
            pr_default.close(8);
            /* Using cursor BC000R11 */
            pr_default.execute(9, new Object[] {A85BR_Information_ID});
            if ( (pr_default.getStatus(9) == 101) )
            {
               GX_msglist.addItem("不匹配' T16'", "ForeignKeyNotFound", 1, "BR_INFORMATION_ID");
               AnyError = 1;
            }
            A36BR_Information_PatientNo = BC000R11_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = BC000R11_n36BR_Information_PatientNo[0];
            pr_default.close(9);
         }
         else
         {
            Gx_mode = "UPD";
            Z87JC_ProviderID = A87JC_ProviderID;
            Z85BR_Information_ID = A85BR_Information_ID;
         }
         ZM0R28( -1) ;
         OnLoadActions0R28( ) ;
         AddRow0R28( ) ;
         ScanKeyEnd0R28( ) ;
         if ( RcdFound28 == 0 )
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
         RowToVars28( bcJC_Provider_Br_Information, 0) ;
         ScanKeyStart0R28( ) ;
         if ( RcdFound28 == 0 )
         {
            Gx_mode = "INS";
            /* Using cursor BC000R10 */
            pr_default.execute(8, new Object[] {A87JC_ProviderID});
            if ( (pr_default.getStatus(8) == 101) )
            {
               GX_msglist.addItem("不匹配' T21'", "ForeignKeyNotFound", 1, "JC_PROVIDERID");
               AnyError = 1;
            }
            A89JC_ProviderName = BC000R10_A89JC_ProviderName[0];
            n89JC_ProviderName = BC000R10_n89JC_ProviderName[0];
            pr_default.close(8);
            /* Using cursor BC000R11 */
            pr_default.execute(9, new Object[] {A85BR_Information_ID});
            if ( (pr_default.getStatus(9) == 101) )
            {
               GX_msglist.addItem("不匹配' T16'", "ForeignKeyNotFound", 1, "BR_INFORMATION_ID");
               AnyError = 1;
            }
            A36BR_Information_PatientNo = BC000R11_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = BC000R11_n36BR_Information_PatientNo[0];
            pr_default.close(9);
         }
         else
         {
            Gx_mode = "UPD";
            Z87JC_ProviderID = A87JC_ProviderID;
            Z85BR_Information_ID = A85BR_Information_ID;
         }
         ZM0R28( -1) ;
         OnLoadActions0R28( ) ;
         AddRow0R28( ) ;
         ScanKeyEnd0R28( ) ;
         if ( RcdFound28 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey0R28( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert0R28( ) ;
         }
         else
         {
            if ( RcdFound28 == 1 )
            {
               if ( ( A87JC_ProviderID != Z87JC_ProviderID ) || ( A85BR_Information_ID != Z85BR_Information_ID ) )
               {
                  A87JC_ProviderID = Z87JC_ProviderID;
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
                  Update0R28( ) ;
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
                  if ( ( A87JC_ProviderID != Z87JC_ProviderID ) || ( A85BR_Information_ID != Z85BR_Information_ID ) )
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
                        Insert0R28( ) ;
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
                        Insert0R28( ) ;
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
         RowToVars28( bcJC_Provider_Br_Information, 0) ;
         SaveImpl( ) ;
         VarsToRow28( bcJC_Provider_Br_Information) ;
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
         RowToVars28( bcJC_Provider_Br_Information, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert0R28( ) ;
         AfterTrn( ) ;
         VarsToRow28( bcJC_Provider_Br_Information) ;
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
            SdtJC_Provider_Br_Information auxBC = new SdtJC_Provider_Br_Information(context) ;
            auxBC.Load(A87JC_ProviderID, A85BR_Information_ID);
            auxBC.UpdateDirties(bcJC_Provider_Br_Information);
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
         RowToVars28( bcJC_Provider_Br_Information, 0) ;
         UpdateImpl( ) ;
         VarsToRow28( bcJC_Provider_Br_Information) ;
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
         RowToVars28( bcJC_Provider_Br_Information, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert0R28( ) ;
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
         VarsToRow28( bcJC_Provider_Br_Information) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars28( bcJC_Provider_Br_Information, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey0R28( ) ;
         if ( RcdFound28 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( ( A87JC_ProviderID != Z87JC_ProviderID ) || ( A85BR_Information_ID != Z85BR_Information_ID ) )
            {
               A87JC_ProviderID = Z87JC_ProviderID;
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
            if ( ( A87JC_ProviderID != Z87JC_ProviderID ) || ( A85BR_Information_ID != Z85BR_Information_ID ) )
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
         pr_default.close(9);
         context.RollbackDataStores("jc_provider_br_information_bc",pr_default);
         VarsToRow28( bcJC_Provider_Br_Information) ;
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
         Gx_mode = bcJC_Provider_Br_Information.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcJC_Provider_Br_Information.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcJC_Provider_Br_Information )
         {
            bcJC_Provider_Br_Information = (SdtJC_Provider_Br_Information)(sdt);
            if ( StringUtil.StrCmp(bcJC_Provider_Br_Information.gxTpr_Mode, "") == 0 )
            {
               bcJC_Provider_Br_Information.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow28( bcJC_Provider_Br_Information) ;
            }
            else
            {
               RowToVars28( bcJC_Provider_Br_Information, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcJC_Provider_Br_Information.gxTpr_Mode, "") == 0 )
            {
               bcJC_Provider_Br_Information.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars28( bcJC_Provider_Br_Information, 1) ;
         return  ;
      }

      public SdtJC_Provider_Br_Information JC_Provider_Br_Information_BC
      {
         get {
            return bcJC_Provider_Br_Information ;
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
         pr_default.close(9);
      }

      public override void initialize( )
      {
         scmdbuf = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Gx_mode = "";
         Z89JC_ProviderName = "";
         A89JC_ProviderName = "";
         Z36BR_Information_PatientNo = "";
         A36BR_Information_PatientNo = "";
         BC000R6_A89JC_ProviderName = new String[] {""} ;
         BC000R6_n89JC_ProviderName = new bool[] {false} ;
         BC000R6_A36BR_Information_PatientNo = new String[] {""} ;
         BC000R6_n36BR_Information_PatientNo = new bool[] {false} ;
         BC000R6_A87JC_ProviderID = new long[1] ;
         BC000R6_A85BR_Information_ID = new long[1] ;
         BC000R4_A89JC_ProviderName = new String[] {""} ;
         BC000R4_n89JC_ProviderName = new bool[] {false} ;
         BC000R5_A36BR_Information_PatientNo = new String[] {""} ;
         BC000R5_n36BR_Information_PatientNo = new bool[] {false} ;
         BC000R7_A87JC_ProviderID = new long[1] ;
         BC000R7_A85BR_Information_ID = new long[1] ;
         BC000R3_A87JC_ProviderID = new long[1] ;
         BC000R3_A85BR_Information_ID = new long[1] ;
         sMode28 = "";
         BC000R2_A87JC_ProviderID = new long[1] ;
         BC000R2_A85BR_Information_ID = new long[1] ;
         BC000R10_A89JC_ProviderName = new String[] {""} ;
         BC000R10_n89JC_ProviderName = new bool[] {false} ;
         BC000R11_A36BR_Information_PatientNo = new String[] {""} ;
         BC000R11_n36BR_Information_PatientNo = new bool[] {false} ;
         BC000R12_A89JC_ProviderName = new String[] {""} ;
         BC000R12_n89JC_ProviderName = new bool[] {false} ;
         BC000R12_A36BR_Information_PatientNo = new String[] {""} ;
         BC000R12_n36BR_Information_PatientNo = new bool[] {false} ;
         BC000R12_A87JC_ProviderID = new long[1] ;
         BC000R12_A85BR_Information_ID = new long[1] ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.jc_provider_br_information_bc__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.jc_provider_br_information_bc__default(),
            new Object[][] {
                new Object[] {
               BC000R2_A87JC_ProviderID, BC000R2_A85BR_Information_ID
               }
               , new Object[] {
               BC000R3_A87JC_ProviderID, BC000R3_A85BR_Information_ID
               }
               , new Object[] {
               BC000R4_A89JC_ProviderName, BC000R4_n89JC_ProviderName
               }
               , new Object[] {
               BC000R5_A36BR_Information_PatientNo, BC000R5_n36BR_Information_PatientNo
               }
               , new Object[] {
               BC000R6_A89JC_ProviderName, BC000R6_n89JC_ProviderName, BC000R6_A36BR_Information_PatientNo, BC000R6_n36BR_Information_PatientNo, BC000R6_A87JC_ProviderID, BC000R6_A85BR_Information_ID
               }
               , new Object[] {
               BC000R7_A87JC_ProviderID, BC000R7_A85BR_Information_ID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000R10_A89JC_ProviderName, BC000R10_n89JC_ProviderName
               }
               , new Object[] {
               BC000R11_A36BR_Information_PatientNo, BC000R11_n36BR_Information_PatientNo
               }
               , new Object[] {
               BC000R12_A89JC_ProviderName, BC000R12_n89JC_ProviderName, BC000R12_A36BR_Information_PatientNo, BC000R12_n36BR_Information_PatientNo, BC000R12_A87JC_ProviderID, BC000R12_A85BR_Information_ID
               }
            }
         );
         INITTRN();
         /* Execute Start event if defined. */
         standaloneNotModal( ) ;
      }

      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short GX_JID ;
      private short RcdFound28 ;
      private int trnEnded ;
      private long Z87JC_ProviderID ;
      private long A87JC_ProviderID ;
      private long Z85BR_Information_ID ;
      private long A85BR_Information_ID ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String sMode28 ;
      private bool n89JC_ProviderName ;
      private bool n36BR_Information_PatientNo ;
      private String Z89JC_ProviderName ;
      private String A89JC_ProviderName ;
      private String Z36BR_Information_PatientNo ;
      private String A36BR_Information_PatientNo ;
      private SdtJC_Provider_Br_Information bcJC_Provider_Br_Information ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] BC000R6_A89JC_ProviderName ;
      private bool[] BC000R6_n89JC_ProviderName ;
      private String[] BC000R6_A36BR_Information_PatientNo ;
      private bool[] BC000R6_n36BR_Information_PatientNo ;
      private long[] BC000R6_A87JC_ProviderID ;
      private long[] BC000R6_A85BR_Information_ID ;
      private String[] BC000R4_A89JC_ProviderName ;
      private bool[] BC000R4_n89JC_ProviderName ;
      private String[] BC000R5_A36BR_Information_PatientNo ;
      private bool[] BC000R5_n36BR_Information_PatientNo ;
      private long[] BC000R7_A87JC_ProviderID ;
      private long[] BC000R7_A85BR_Information_ID ;
      private long[] BC000R3_A87JC_ProviderID ;
      private long[] BC000R3_A85BR_Information_ID ;
      private long[] BC000R2_A87JC_ProviderID ;
      private long[] BC000R2_A85BR_Information_ID ;
      private String[] BC000R10_A89JC_ProviderName ;
      private bool[] BC000R10_n89JC_ProviderName ;
      private String[] BC000R11_A36BR_Information_PatientNo ;
      private bool[] BC000R11_n36BR_Information_PatientNo ;
      private String[] BC000R12_A89JC_ProviderName ;
      private bool[] BC000R12_n89JC_ProviderName ;
      private String[] BC000R12_A36BR_Information_PatientNo ;
      private bool[] BC000R12_n36BR_Information_PatientNo ;
      private long[] BC000R12_A87JC_ProviderID ;
      private long[] BC000R12_A85BR_Information_ID ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_datastore1 ;
   }

   public class jc_provider_br_information_bc__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class jc_provider_br_information_bc__default : DataStoreHelperBase, IDataStoreHelper
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
       ,new ForEachCursor(def[10])
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmBC000R6 ;
        prmBC000R6 = new Object[] {
        new Object[] {"@JC_ProviderID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000R4 ;
        prmBC000R4 = new Object[] {
        new Object[] {"@JC_ProviderID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000R5 ;
        prmBC000R5 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000R7 ;
        prmBC000R7 = new Object[] {
        new Object[] {"@JC_ProviderID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000R3 ;
        prmBC000R3 = new Object[] {
        new Object[] {"@JC_ProviderID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000R2 ;
        prmBC000R2 = new Object[] {
        new Object[] {"@JC_ProviderID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000R8 ;
        prmBC000R8 = new Object[] {
        new Object[] {"@JC_ProviderID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000R9 ;
        prmBC000R9 = new Object[] {
        new Object[] {"@JC_ProviderID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000R12 ;
        prmBC000R12 = new Object[] {
        new Object[] {"@JC_ProviderID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000R10 ;
        prmBC000R10 = new Object[] {
        new Object[] {"@JC_ProviderID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000R11 ;
        prmBC000R11 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("BC000R2", "SELECT [JC_ProviderID], [BR_Information_ID] FROM [JC_Provider_Br_Information] WITH (UPDLOCK) WHERE [JC_ProviderID] = @JC_ProviderID AND [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000R2,1,0,true,false )
           ,new CursorDef("BC000R3", "SELECT [JC_ProviderID], [BR_Information_ID] FROM [JC_Provider_Br_Information] WITH (NOLOCK) WHERE [JC_ProviderID] = @JC_ProviderID AND [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000R3,1,0,true,false )
           ,new CursorDef("BC000R4", "SELECT [JC_ProviderName] FROM [JC_Provider] WITH (NOLOCK) WHERE [JC_ProviderID] = @JC_ProviderID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000R4,1,0,true,false )
           ,new CursorDef("BC000R5", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000R5,1,0,true,false )
           ,new CursorDef("BC000R6", "SELECT T2.[JC_ProviderName], T3.[BR_Information_PatientNo], TM1.[JC_ProviderID], TM1.[BR_Information_ID] FROM (([JC_Provider_Br_Information] TM1 WITH (NOLOCK) INNER JOIN [JC_Provider] T2 WITH (NOLOCK) ON T2.[JC_ProviderID] = TM1.[JC_ProviderID]) INNER JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = TM1.[BR_Information_ID]) WHERE TM1.[JC_ProviderID] = @JC_ProviderID and TM1.[BR_Information_ID] = @BR_Information_ID ORDER BY TM1.[JC_ProviderID], TM1.[BR_Information_ID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000R6,100,0,true,false )
           ,new CursorDef("BC000R7", "SELECT [JC_ProviderID], [BR_Information_ID] FROM [JC_Provider_Br_Information] WITH (NOLOCK) WHERE [JC_ProviderID] = @JC_ProviderID AND [BR_Information_ID] = @BR_Information_ID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000R7,1,0,true,false )
           ,new CursorDef("BC000R8", "INSERT INTO [JC_Provider_Br_Information]([JC_ProviderID], [BR_Information_ID]) VALUES(@JC_ProviderID, @BR_Information_ID)", GxErrorMask.GX_NOMASK,prmBC000R8)
           ,new CursorDef("BC000R9", "DELETE FROM [JC_Provider_Br_Information]  WHERE [JC_ProviderID] = @JC_ProviderID AND [BR_Information_ID] = @BR_Information_ID", GxErrorMask.GX_NOMASK,prmBC000R9)
           ,new CursorDef("BC000R10", "SELECT [JC_ProviderName] FROM [JC_Provider] WITH (NOLOCK) WHERE [JC_ProviderID] = @JC_ProviderID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000R10,1,0,true,false )
           ,new CursorDef("BC000R11", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000R11,1,0,true,false )
           ,new CursorDef("BC000R12", "SELECT T2.[JC_ProviderName], T3.[BR_Information_PatientNo], TM1.[JC_ProviderID], TM1.[BR_Information_ID] FROM (([JC_Provider_Br_Information] TM1 WITH (NOLOCK) INNER JOIN [JC_Provider] T2 WITH (NOLOCK) ON T2.[JC_ProviderID] = TM1.[JC_ProviderID]) INNER JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = TM1.[BR_Information_ID]) WHERE TM1.[JC_ProviderID] = @JC_ProviderID and TM1.[BR_Information_ID] = @BR_Information_ID ORDER BY TM1.[JC_ProviderID], TM1.[BR_Information_ID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000R12,100,0,true,false )
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
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              return;
           case 2 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              return;
           case 3 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              return;
           case 4 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[3])[0] = rslt.wasNull(2);
              ((long[]) buf[4])[0] = rslt.getLong(3) ;
              ((long[]) buf[5])[0] = rslt.getLong(4) ;
              return;
           case 5 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              return;
           case 8 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              return;
           case 9 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              return;
           case 10 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[3])[0] = rslt.wasNull(2);
              ((long[]) buf[4])[0] = rslt.getLong(3) ;
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
              stmt.SetParameter(2, (long)parms[1]);
              return;
           case 1 :
              stmt.SetParameter(1, (long)parms[0]);
              stmt.SetParameter(2, (long)parms[1]);
              return;
           case 2 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 3 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 4 :
              stmt.SetParameter(1, (long)parms[0]);
              stmt.SetParameter(2, (long)parms[1]);
              return;
           case 5 :
              stmt.SetParameter(1, (long)parms[0]);
              stmt.SetParameter(2, (long)parms[1]);
              return;
           case 6 :
              stmt.SetParameter(1, (long)parms[0]);
              stmt.SetParameter(2, (long)parms[1]);
              return;
           case 7 :
              stmt.SetParameter(1, (long)parms[0]);
              stmt.SetParameter(2, (long)parms[1]);
              return;
           case 8 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 9 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 10 :
              stmt.SetParameter(1, (long)parms[0]);
              stmt.SetParameter(2, (long)parms[1]);
              return;
     }
  }

}

}
