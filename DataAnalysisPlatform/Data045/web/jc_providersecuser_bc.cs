/*
               File: JC_ProviderSecUser_BC
        Description: 医院账号关系表
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:7:39.18
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
   public class jc_providersecuser_bc : GXHttpHandler, IGxSilentTrn
   {
      public jc_providersecuser_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public jc_providersecuser_bc( IGxContext context )
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
         ReadRow0P26( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey0P26( ) ;
         standaloneModal( ) ;
         AddRow0P26( ) ;
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
               Z6SecUserId = A6SecUserId;
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

      protected void CONFIRM_0P0( )
      {
         BeforeValidate0P26( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0P26( ) ;
            }
            else
            {
               CheckExtendedTable0P26( ) ;
               if ( AnyError == 0 )
               {
                  ZM0P26( 2) ;
                  ZM0P26( 3) ;
               }
               CloseExtendedTableCursors0P26( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void ZM0P26( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
         }
         if ( ( GX_JID == 2 ) || ( GX_JID == 0 ) )
         {
            Z14SecUserName = A14SecUserName;
         }
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            Z89JC_ProviderName = A89JC_ProviderName;
         }
         if ( GX_JID == -1 )
         {
            Z6SecUserId = A6SecUserId;
            Z87JC_ProviderID = A87JC_ProviderID;
            Z14SecUserName = A14SecUserName;
            Z89JC_ProviderName = A89JC_ProviderName;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load0P26( )
      {
         /* Using cursor BC000P6 */
         pr_default.execute(4, new Object[] {A6SecUserId, A87JC_ProviderID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound26 = 1;
            A14SecUserName = BC000P6_A14SecUserName[0];
            A89JC_ProviderName = BC000P6_A89JC_ProviderName[0];
            n89JC_ProviderName = BC000P6_n89JC_ProviderName[0];
            ZM0P26( -1) ;
         }
         pr_default.close(4);
         OnLoadActions0P26( ) ;
      }

      protected void OnLoadActions0P26( )
      {
      }

      protected void CheckExtendedTable0P26( )
      {
         standaloneModal( ) ;
         /* Using cursor BC000P4 */
         pr_default.execute(2, new Object[] {A6SecUserId});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("不匹配'User'", "ForeignKeyNotFound", 1, "SECUSERID");
            AnyError = 1;
         }
         A14SecUserName = BC000P4_A14SecUserName[0];
         pr_default.close(2);
         /* Using cursor BC000P5 */
         pr_default.execute(3, new Object[] {A87JC_ProviderID});
         if ( (pr_default.getStatus(3) == 101) )
         {
            GX_msglist.addItem("不匹配' T21'", "ForeignKeyNotFound", 1, "JC_PROVIDERID");
            AnyError = 1;
         }
         A89JC_ProviderName = BC000P5_A89JC_ProviderName[0];
         n89JC_ProviderName = BC000P5_n89JC_ProviderName[0];
         pr_default.close(3);
      }

      protected void CloseExtendedTableCursors0P26( )
      {
         pr_default.close(2);
         pr_default.close(3);
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0P26( )
      {
         /* Using cursor BC000P7 */
         pr_default.execute(5, new Object[] {A6SecUserId, A87JC_ProviderID});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound26 = 1;
         }
         else
         {
            RcdFound26 = 0;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC000P3 */
         pr_default.execute(1, new Object[] {A6SecUserId, A87JC_ProviderID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0P26( 1) ;
            RcdFound26 = 1;
            A6SecUserId = BC000P3_A6SecUserId[0];
            A87JC_ProviderID = BC000P3_A87JC_ProviderID[0];
            Z6SecUserId = A6SecUserId;
            Z87JC_ProviderID = A87JC_ProviderID;
            sMode26 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load0P26( ) ;
            if ( AnyError == 1 )
            {
               RcdFound26 = 0;
               InitializeNonKey0P26( ) ;
            }
            Gx_mode = sMode26;
         }
         else
         {
            RcdFound26 = 0;
            InitializeNonKey0P26( ) ;
            sMode26 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode26;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0P26( ) ;
         if ( RcdFound26 == 0 )
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
         CONFIRM_0P0( ) ;
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

      protected void CheckOptimisticConcurrency0P26( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC000P2 */
            pr_default.execute(0, new Object[] {A6SecUserId, A87JC_ProviderID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"JC_ProviderSecUser"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"JC_ProviderSecUser"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0P26( )
      {
         BeforeValidate0P26( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0P26( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0P26( 0) ;
            CheckOptimisticConcurrency0P26( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0P26( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0P26( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000P8 */
                     pr_default.execute(6, new Object[] {A6SecUserId, A87JC_ProviderID});
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("JC_ProviderSecUser") ;
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
               Load0P26( ) ;
            }
            EndLevel0P26( ) ;
         }
         CloseExtendedTableCursors0P26( ) ;
      }

      protected void Update0P26( )
      {
         BeforeValidate0P26( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0P26( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0P26( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0P26( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0P26( ) ;
                  if ( AnyError == 0 )
                  {
                     /* No attributes to update on table [JC_ProviderSecUser] */
                     DeferredUpdate0P26( ) ;
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
            EndLevel0P26( ) ;
         }
         CloseExtendedTableCursors0P26( ) ;
      }

      protected void DeferredUpdate0P26( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate0P26( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0P26( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0P26( ) ;
            AfterConfirm0P26( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0P26( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC000P9 */
                  pr_default.execute(7, new Object[] {A6SecUserId, A87JC_ProviderID});
                  pr_default.close(7);
                  dsDefault.SmartCacheProvider.SetUpdated("JC_ProviderSecUser") ;
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
         sMode26 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel0P26( ) ;
         Gx_mode = sMode26;
      }

      protected void OnDeleteControls0P26( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor BC000P10 */
            pr_default.execute(8, new Object[] {A6SecUserId});
            A14SecUserName = BC000P10_A14SecUserName[0];
            pr_default.close(8);
            /* Using cursor BC000P11 */
            pr_default.execute(9, new Object[] {A87JC_ProviderID});
            A89JC_ProviderName = BC000P11_A89JC_ProviderName[0];
            n89JC_ProviderName = BC000P11_n89JC_ProviderName[0];
            pr_default.close(9);
         }
      }

      protected void EndLevel0P26( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0P26( ) ;
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

      public void ScanKeyStart0P26( )
      {
         /* Using cursor BC000P12 */
         pr_default.execute(10, new Object[] {A6SecUserId, A87JC_ProviderID});
         RcdFound26 = 0;
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound26 = 1;
            A14SecUserName = BC000P12_A14SecUserName[0];
            A89JC_ProviderName = BC000P12_A89JC_ProviderName[0];
            n89JC_ProviderName = BC000P12_n89JC_ProviderName[0];
            A6SecUserId = BC000P12_A6SecUserId[0];
            A87JC_ProviderID = BC000P12_A87JC_ProviderID[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext0P26( )
      {
         /* Scan next routine */
         pr_default.readNext(10);
         RcdFound26 = 0;
         ScanKeyLoad0P26( ) ;
      }

      protected void ScanKeyLoad0P26( )
      {
         sMode26 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound26 = 1;
            A14SecUserName = BC000P12_A14SecUserName[0];
            A89JC_ProviderName = BC000P12_A89JC_ProviderName[0];
            n89JC_ProviderName = BC000P12_n89JC_ProviderName[0];
            A6SecUserId = BC000P12_A6SecUserId[0];
            A87JC_ProviderID = BC000P12_A87JC_ProviderID[0];
         }
         Gx_mode = sMode26;
      }

      protected void ScanKeyEnd0P26( )
      {
         pr_default.close(10);
      }

      protected void AfterConfirm0P26( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0P26( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0P26( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0P26( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0P26( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0P26( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0P26( )
      {
      }

      protected void send_integrity_lvl_hashes0P26( )
      {
      }

      protected void AddRow0P26( )
      {
         VarsToRow26( bcJC_ProviderSecUser) ;
      }

      protected void ReadRow0P26( )
      {
         RowToVars26( bcJC_ProviderSecUser, 1) ;
      }

      protected void InitializeNonKey0P26( )
      {
         A14SecUserName = "";
         A89JC_ProviderName = "";
         n89JC_ProviderName = false;
      }

      protected void InitAll0P26( )
      {
         A6SecUserId = 0;
         A87JC_ProviderID = 0;
         InitializeNonKey0P26( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow26( SdtJC_ProviderSecUser obj26 )
      {
         obj26.gxTpr_Mode = Gx_mode;
         obj26.gxTpr_Secusername = A14SecUserName;
         obj26.gxTpr_Jc_providername = A89JC_ProviderName;
         obj26.gxTpr_Secuserid = A6SecUserId;
         obj26.gxTpr_Jc_providerid = A87JC_ProviderID;
         obj26.gxTpr_Secuserid_Z = Z6SecUserId;
         obj26.gxTpr_Jc_providerid_Z = Z87JC_ProviderID;
         obj26.gxTpr_Secusername_Z = Z14SecUserName;
         obj26.gxTpr_Jc_providername_Z = Z89JC_ProviderName;
         obj26.gxTpr_Jc_providername_N = (short)(Convert.ToInt16(n89JC_ProviderName));
         obj26.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow26( SdtJC_ProviderSecUser obj26 )
      {
         obj26.gxTpr_Secuserid = A6SecUserId;
         obj26.gxTpr_Jc_providerid = A87JC_ProviderID;
         return  ;
      }

      public void RowToVars26( SdtJC_ProviderSecUser obj26 ,
                               int forceLoad )
      {
         Gx_mode = obj26.gxTpr_Mode;
         A14SecUserName = obj26.gxTpr_Secusername;
         A89JC_ProviderName = obj26.gxTpr_Jc_providername;
         n89JC_ProviderName = false;
         A6SecUserId = obj26.gxTpr_Secuserid;
         A87JC_ProviderID = obj26.gxTpr_Jc_providerid;
         Z6SecUserId = obj26.gxTpr_Secuserid_Z;
         Z87JC_ProviderID = obj26.gxTpr_Jc_providerid_Z;
         Z14SecUserName = obj26.gxTpr_Secusername_Z;
         Z89JC_ProviderName = obj26.gxTpr_Jc_providername_Z;
         n89JC_ProviderName = (bool)(Convert.ToBoolean(obj26.gxTpr_Jc_providername_N));
         Gx_mode = obj26.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A6SecUserId = (short)getParm(obj,0);
         A87JC_ProviderID = (long)getParm(obj,1);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey0P26( ) ;
         ScanKeyStart0P26( ) ;
         if ( RcdFound26 == 0 )
         {
            Gx_mode = "INS";
            /* Using cursor BC000P10 */
            pr_default.execute(8, new Object[] {A6SecUserId});
            if ( (pr_default.getStatus(8) == 101) )
            {
               GX_msglist.addItem("不匹配'User'", "ForeignKeyNotFound", 1, "SECUSERID");
               AnyError = 1;
            }
            A14SecUserName = BC000P10_A14SecUserName[0];
            pr_default.close(8);
            /* Using cursor BC000P11 */
            pr_default.execute(9, new Object[] {A87JC_ProviderID});
            if ( (pr_default.getStatus(9) == 101) )
            {
               GX_msglist.addItem("不匹配' T21'", "ForeignKeyNotFound", 1, "JC_PROVIDERID");
               AnyError = 1;
            }
            A89JC_ProviderName = BC000P11_A89JC_ProviderName[0];
            n89JC_ProviderName = BC000P11_n89JC_ProviderName[0];
            pr_default.close(9);
         }
         else
         {
            Gx_mode = "UPD";
            Z6SecUserId = A6SecUserId;
            Z87JC_ProviderID = A87JC_ProviderID;
         }
         ZM0P26( -1) ;
         OnLoadActions0P26( ) ;
         AddRow0P26( ) ;
         ScanKeyEnd0P26( ) ;
         if ( RcdFound26 == 0 )
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
         RowToVars26( bcJC_ProviderSecUser, 0) ;
         ScanKeyStart0P26( ) ;
         if ( RcdFound26 == 0 )
         {
            Gx_mode = "INS";
            /* Using cursor BC000P10 */
            pr_default.execute(8, new Object[] {A6SecUserId});
            if ( (pr_default.getStatus(8) == 101) )
            {
               GX_msglist.addItem("不匹配'User'", "ForeignKeyNotFound", 1, "SECUSERID");
               AnyError = 1;
            }
            A14SecUserName = BC000P10_A14SecUserName[0];
            pr_default.close(8);
            /* Using cursor BC000P11 */
            pr_default.execute(9, new Object[] {A87JC_ProviderID});
            if ( (pr_default.getStatus(9) == 101) )
            {
               GX_msglist.addItem("不匹配' T21'", "ForeignKeyNotFound", 1, "JC_PROVIDERID");
               AnyError = 1;
            }
            A89JC_ProviderName = BC000P11_A89JC_ProviderName[0];
            n89JC_ProviderName = BC000P11_n89JC_ProviderName[0];
            pr_default.close(9);
         }
         else
         {
            Gx_mode = "UPD";
            Z6SecUserId = A6SecUserId;
            Z87JC_ProviderID = A87JC_ProviderID;
         }
         ZM0P26( -1) ;
         OnLoadActions0P26( ) ;
         AddRow0P26( ) ;
         ScanKeyEnd0P26( ) ;
         if ( RcdFound26 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey0P26( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert0P26( ) ;
         }
         else
         {
            if ( RcdFound26 == 1 )
            {
               if ( ( A6SecUserId != Z6SecUserId ) || ( A87JC_ProviderID != Z87JC_ProviderID ) )
               {
                  A6SecUserId = Z6SecUserId;
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
                  Update0P26( ) ;
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
                  if ( ( A6SecUserId != Z6SecUserId ) || ( A87JC_ProviderID != Z87JC_ProviderID ) )
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
                        Insert0P26( ) ;
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
                        Insert0P26( ) ;
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
         RowToVars26( bcJC_ProviderSecUser, 0) ;
         SaveImpl( ) ;
         VarsToRow26( bcJC_ProviderSecUser) ;
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
         RowToVars26( bcJC_ProviderSecUser, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert0P26( ) ;
         AfterTrn( ) ;
         VarsToRow26( bcJC_ProviderSecUser) ;
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
            SdtJC_ProviderSecUser auxBC = new SdtJC_ProviderSecUser(context) ;
            auxBC.Load(A6SecUserId, A87JC_ProviderID);
            auxBC.UpdateDirties(bcJC_ProviderSecUser);
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
         RowToVars26( bcJC_ProviderSecUser, 0) ;
         UpdateImpl( ) ;
         VarsToRow26( bcJC_ProviderSecUser) ;
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
         RowToVars26( bcJC_ProviderSecUser, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert0P26( ) ;
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
         VarsToRow26( bcJC_ProviderSecUser) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars26( bcJC_ProviderSecUser, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey0P26( ) ;
         if ( RcdFound26 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( ( A6SecUserId != Z6SecUserId ) || ( A87JC_ProviderID != Z87JC_ProviderID ) )
            {
               A6SecUserId = Z6SecUserId;
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
            if ( ( A6SecUserId != Z6SecUserId ) || ( A87JC_ProviderID != Z87JC_ProviderID ) )
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
         context.RollbackDataStores("jc_providersecuser_bc",pr_default);
         VarsToRow26( bcJC_ProviderSecUser) ;
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
         Gx_mode = bcJC_ProviderSecUser.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcJC_ProviderSecUser.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcJC_ProviderSecUser )
         {
            bcJC_ProviderSecUser = (SdtJC_ProviderSecUser)(sdt);
            if ( StringUtil.StrCmp(bcJC_ProviderSecUser.gxTpr_Mode, "") == 0 )
            {
               bcJC_ProviderSecUser.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow26( bcJC_ProviderSecUser) ;
            }
            else
            {
               RowToVars26( bcJC_ProviderSecUser, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcJC_ProviderSecUser.gxTpr_Mode, "") == 0 )
            {
               bcJC_ProviderSecUser.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars26( bcJC_ProviderSecUser, 1) ;
         return  ;
      }

      public SdtJC_ProviderSecUser JC_ProviderSecUser_BC
      {
         get {
            return bcJC_ProviderSecUser ;
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
         Z14SecUserName = "";
         A14SecUserName = "";
         Z89JC_ProviderName = "";
         A89JC_ProviderName = "";
         BC000P6_A14SecUserName = new String[] {""} ;
         BC000P6_A89JC_ProviderName = new String[] {""} ;
         BC000P6_n89JC_ProviderName = new bool[] {false} ;
         BC000P6_A6SecUserId = new short[1] ;
         BC000P6_A87JC_ProviderID = new long[1] ;
         BC000P4_A14SecUserName = new String[] {""} ;
         BC000P5_A89JC_ProviderName = new String[] {""} ;
         BC000P5_n89JC_ProviderName = new bool[] {false} ;
         BC000P7_A6SecUserId = new short[1] ;
         BC000P7_A87JC_ProviderID = new long[1] ;
         BC000P3_A6SecUserId = new short[1] ;
         BC000P3_A87JC_ProviderID = new long[1] ;
         sMode26 = "";
         BC000P2_A6SecUserId = new short[1] ;
         BC000P2_A87JC_ProviderID = new long[1] ;
         BC000P10_A14SecUserName = new String[] {""} ;
         BC000P11_A89JC_ProviderName = new String[] {""} ;
         BC000P11_n89JC_ProviderName = new bool[] {false} ;
         BC000P12_A14SecUserName = new String[] {""} ;
         BC000P12_A89JC_ProviderName = new String[] {""} ;
         BC000P12_n89JC_ProviderName = new bool[] {false} ;
         BC000P12_A6SecUserId = new short[1] ;
         BC000P12_A87JC_ProviderID = new long[1] ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.jc_providersecuser_bc__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.jc_providersecuser_bc__default(),
            new Object[][] {
                new Object[] {
               BC000P2_A6SecUserId, BC000P2_A87JC_ProviderID
               }
               , new Object[] {
               BC000P3_A6SecUserId, BC000P3_A87JC_ProviderID
               }
               , new Object[] {
               BC000P4_A14SecUserName
               }
               , new Object[] {
               BC000P5_A89JC_ProviderName, BC000P5_n89JC_ProviderName
               }
               , new Object[] {
               BC000P6_A14SecUserName, BC000P6_A89JC_ProviderName, BC000P6_n89JC_ProviderName, BC000P6_A6SecUserId, BC000P6_A87JC_ProviderID
               }
               , new Object[] {
               BC000P7_A6SecUserId, BC000P7_A87JC_ProviderID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000P10_A14SecUserName
               }
               , new Object[] {
               BC000P11_A89JC_ProviderName, BC000P11_n89JC_ProviderName
               }
               , new Object[] {
               BC000P12_A14SecUserName, BC000P12_A89JC_ProviderName, BC000P12_n89JC_ProviderName, BC000P12_A6SecUserId, BC000P12_A87JC_ProviderID
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
      private short Z6SecUserId ;
      private short A6SecUserId ;
      private short GX_JID ;
      private short RcdFound26 ;
      private int trnEnded ;
      private long Z87JC_ProviderID ;
      private long A87JC_ProviderID ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String sMode26 ;
      private bool n89JC_ProviderName ;
      private String Z14SecUserName ;
      private String A14SecUserName ;
      private String Z89JC_ProviderName ;
      private String A89JC_ProviderName ;
      private SdtJC_ProviderSecUser bcJC_ProviderSecUser ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] BC000P6_A14SecUserName ;
      private String[] BC000P6_A89JC_ProviderName ;
      private bool[] BC000P6_n89JC_ProviderName ;
      private short[] BC000P6_A6SecUserId ;
      private long[] BC000P6_A87JC_ProviderID ;
      private String[] BC000P4_A14SecUserName ;
      private String[] BC000P5_A89JC_ProviderName ;
      private bool[] BC000P5_n89JC_ProviderName ;
      private short[] BC000P7_A6SecUserId ;
      private long[] BC000P7_A87JC_ProviderID ;
      private short[] BC000P3_A6SecUserId ;
      private long[] BC000P3_A87JC_ProviderID ;
      private short[] BC000P2_A6SecUserId ;
      private long[] BC000P2_A87JC_ProviderID ;
      private String[] BC000P10_A14SecUserName ;
      private String[] BC000P11_A89JC_ProviderName ;
      private bool[] BC000P11_n89JC_ProviderName ;
      private String[] BC000P12_A14SecUserName ;
      private String[] BC000P12_A89JC_ProviderName ;
      private bool[] BC000P12_n89JC_ProviderName ;
      private short[] BC000P12_A6SecUserId ;
      private long[] BC000P12_A87JC_ProviderID ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_datastore1 ;
   }

   public class jc_providersecuser_bc__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class jc_providersecuser_bc__default : DataStoreHelperBase, IDataStoreHelper
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
        Object[] prmBC000P6 ;
        prmBC000P6 = new Object[] {
        new Object[] {"@SecUserId",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@JC_ProviderID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000P4 ;
        prmBC000P4 = new Object[] {
        new Object[] {"@SecUserId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmBC000P5 ;
        prmBC000P5 = new Object[] {
        new Object[] {"@JC_ProviderID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000P7 ;
        prmBC000P7 = new Object[] {
        new Object[] {"@SecUserId",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@JC_ProviderID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000P3 ;
        prmBC000P3 = new Object[] {
        new Object[] {"@SecUserId",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@JC_ProviderID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000P2 ;
        prmBC000P2 = new Object[] {
        new Object[] {"@SecUserId",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@JC_ProviderID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000P8 ;
        prmBC000P8 = new Object[] {
        new Object[] {"@SecUserId",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@JC_ProviderID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000P9 ;
        prmBC000P9 = new Object[] {
        new Object[] {"@SecUserId",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@JC_ProviderID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000P12 ;
        prmBC000P12 = new Object[] {
        new Object[] {"@SecUserId",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@JC_ProviderID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000P10 ;
        prmBC000P10 = new Object[] {
        new Object[] {"@SecUserId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmBC000P11 ;
        prmBC000P11 = new Object[] {
        new Object[] {"@JC_ProviderID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("BC000P2", "SELECT [SecUserId], [JC_ProviderID] FROM [JC_ProviderSecUser] WITH (UPDLOCK) WHERE [SecUserId] = @SecUserId AND [JC_ProviderID] = @JC_ProviderID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000P2,1,0,true,false )
           ,new CursorDef("BC000P3", "SELECT [SecUserId], [JC_ProviderID] FROM [JC_ProviderSecUser] WITH (NOLOCK) WHERE [SecUserId] = @SecUserId AND [JC_ProviderID] = @JC_ProviderID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000P3,1,0,true,false )
           ,new CursorDef("BC000P4", "SELECT [SecUserName] FROM [SecUser] WITH (NOLOCK) WHERE [SecUserId] = @SecUserId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000P4,1,0,true,false )
           ,new CursorDef("BC000P5", "SELECT [JC_ProviderName] FROM [JC_Provider] WITH (NOLOCK) WHERE [JC_ProviderID] = @JC_ProviderID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000P5,1,0,true,false )
           ,new CursorDef("BC000P6", "SELECT T2.[SecUserName], T3.[JC_ProviderName], TM1.[SecUserId], TM1.[JC_ProviderID] FROM (([JC_ProviderSecUser] TM1 WITH (NOLOCK) INNER JOIN [SecUser] T2 WITH (NOLOCK) ON T2.[SecUserId] = TM1.[SecUserId]) INNER JOIN [JC_Provider] T3 WITH (NOLOCK) ON T3.[JC_ProviderID] = TM1.[JC_ProviderID]) WHERE TM1.[SecUserId] = @SecUserId and TM1.[JC_ProviderID] = @JC_ProviderID ORDER BY TM1.[SecUserId], TM1.[JC_ProviderID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000P6,100,0,true,false )
           ,new CursorDef("BC000P7", "SELECT [SecUserId], [JC_ProviderID] FROM [JC_ProviderSecUser] WITH (NOLOCK) WHERE [SecUserId] = @SecUserId AND [JC_ProviderID] = @JC_ProviderID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000P7,1,0,true,false )
           ,new CursorDef("BC000P8", "INSERT INTO [JC_ProviderSecUser]([SecUserId], [JC_ProviderID]) VALUES(@SecUserId, @JC_ProviderID)", GxErrorMask.GX_NOMASK,prmBC000P8)
           ,new CursorDef("BC000P9", "DELETE FROM [JC_ProviderSecUser]  WHERE [SecUserId] = @SecUserId AND [JC_ProviderID] = @JC_ProviderID", GxErrorMask.GX_NOMASK,prmBC000P9)
           ,new CursorDef("BC000P10", "SELECT [SecUserName] FROM [SecUser] WITH (NOLOCK) WHERE [SecUserId] = @SecUserId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000P10,1,0,true,false )
           ,new CursorDef("BC000P11", "SELECT [JC_ProviderName] FROM [JC_Provider] WITH (NOLOCK) WHERE [JC_ProviderID] = @JC_ProviderID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000P11,1,0,true,false )
           ,new CursorDef("BC000P12", "SELECT T2.[SecUserName], T3.[JC_ProviderName], TM1.[SecUserId], TM1.[JC_ProviderID] FROM (([JC_ProviderSecUser] TM1 WITH (NOLOCK) INNER JOIN [SecUser] T2 WITH (NOLOCK) ON T2.[SecUserId] = TM1.[SecUserId]) INNER JOIN [JC_Provider] T3 WITH (NOLOCK) ON T3.[JC_ProviderID] = TM1.[JC_ProviderID]) WHERE TM1.[SecUserId] = @SecUserId and TM1.[JC_ProviderID] = @JC_ProviderID ORDER BY TM1.[SecUserId], TM1.[JC_ProviderID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000P12,100,0,true,false )
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
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              return;
           case 1 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              return;
           case 2 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              return;
           case 3 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              return;
           case 4 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((short[]) buf[3])[0] = rslt.getShort(3) ;
              ((long[]) buf[4])[0] = rslt.getLong(4) ;
              return;
           case 5 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              return;
           case 8 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              return;
           case 9 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              return;
           case 10 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((short[]) buf[3])[0] = rslt.getShort(3) ;
              ((long[]) buf[4])[0] = rslt.getLong(4) ;
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
              stmt.SetParameter(1, (short)parms[0]);
              stmt.SetParameter(2, (long)parms[1]);
              return;
           case 1 :
              stmt.SetParameter(1, (short)parms[0]);
              stmt.SetParameter(2, (long)parms[1]);
              return;
           case 2 :
              stmt.SetParameter(1, (short)parms[0]);
              return;
           case 3 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 4 :
              stmt.SetParameter(1, (short)parms[0]);
              stmt.SetParameter(2, (long)parms[1]);
              return;
           case 5 :
              stmt.SetParameter(1, (short)parms[0]);
              stmt.SetParameter(2, (long)parms[1]);
              return;
           case 6 :
              stmt.SetParameter(1, (short)parms[0]);
              stmt.SetParameter(2, (long)parms[1]);
              return;
           case 7 :
              stmt.SetParameter(1, (short)parms[0]);
              stmt.SetParameter(2, (long)parms[1]);
              return;
           case 8 :
              stmt.SetParameter(1, (short)parms[0]);
              return;
           case 9 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 10 :
              stmt.SetParameter(1, (short)parms[0]);
              stmt.SetParameter(2, (long)parms[1]);
              return;
     }
  }

}

}
