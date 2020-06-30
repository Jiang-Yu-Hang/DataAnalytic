/*
               File: WWPBaseObjects.SecRole_BC
        Description: 角色
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:6:25.14
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
namespace GeneXus.Programs.wwpbaseobjects {
   public class secrole_bc : GXHttpHandler, IGxSilentTrn
   {
      public secrole_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public secrole_bc( IGxContext context )
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
         ReadRow045( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey045( ) ;
         standaloneModal( ) ;
         AddRow045( ) ;
         Gx_mode = "INS";
         return  ;
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E11042 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               Z4SecRoleId = A4SecRoleId;
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

      protected void CONFIRM_040( )
      {
         BeforeValidate045( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls045( ) ;
            }
            else
            {
               CheckExtendedTable045( ) ;
               if ( AnyError == 0 )
               {
               }
               CloseExtendedTableCursors045( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void E12042( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV16WWPContext) ;
         AV9IsAuthorized = true;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "RoleModes", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "RoleModes", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "RoleModes", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
         }
         if ( ! AV9IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV17Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV10TrnContext.FromXml(AV11WebSession.Get("TrnContext"), null, "WWPTransactionContext", "DataAnalysisPlatform");
      }

      protected void E11042( )
      {
         /* After Trn Routine */
      }

      protected void ZM045( short GX_JID )
      {
         if ( ( GX_JID == 2 ) || ( GX_JID == 0 ) )
         {
            Z13SecRoleName = A13SecRoleName;
            Z12SecRoleDescription = A12SecRoleDescription;
         }
         if ( GX_JID == -2 )
         {
            Z4SecRoleId = A4SecRoleId;
            Z13SecRoleName = A13SecRoleName;
            Z12SecRoleDescription = A12SecRoleDescription;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load045( )
      {
         /* Using cursor BC00044 */
         pr_default.execute(2, new Object[] {A4SecRoleId});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound5 = 1;
            A13SecRoleName = BC00044_A13SecRoleName[0];
            A12SecRoleDescription = BC00044_A12SecRoleDescription[0];
            ZM045( -2) ;
         }
         pr_default.close(2);
         OnLoadActions045( ) ;
      }

      protected void OnLoadActions045( )
      {
         AV17Pgmname = "WWPBaseObjects.SecRole_BC";
      }

      protected void CheckExtendedTable045( )
      {
         standaloneModal( ) ;
         AV17Pgmname = "WWPBaseObjects.SecRole_BC";
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A13SecRoleName)) )
         {
            GX_msglist.addItem("角色名称是必须填写的。", 1, "");
            AnyError = 1;
         }
      }

      protected void CloseExtendedTableCursors045( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey045( )
      {
         /* Using cursor BC00045 */
         pr_default.execute(3, new Object[] {A4SecRoleId});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound5 = 1;
         }
         else
         {
            RcdFound5 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC00043 */
         pr_default.execute(1, new Object[] {A4SecRoleId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM045( 2) ;
            RcdFound5 = 1;
            A4SecRoleId = BC00043_A4SecRoleId[0];
            A13SecRoleName = BC00043_A13SecRoleName[0];
            A12SecRoleDescription = BC00043_A12SecRoleDescription[0];
            Z4SecRoleId = A4SecRoleId;
            sMode5 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load045( ) ;
            if ( AnyError == 1 )
            {
               RcdFound5 = 0;
               InitializeNonKey045( ) ;
            }
            Gx_mode = sMode5;
         }
         else
         {
            RcdFound5 = 0;
            InitializeNonKey045( ) ;
            sMode5 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode5;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey045( ) ;
         if ( RcdFound5 == 0 )
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
         CONFIRM_040( ) ;
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

      protected void CheckOptimisticConcurrency045( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC00042 */
            pr_default.execute(0, new Object[] {A4SecRoleId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SecRole"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z13SecRoleName, BC00042_A13SecRoleName[0]) != 0 ) || ( StringUtil.StrCmp(Z12SecRoleDescription, BC00042_A12SecRoleDescription[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"SecRole"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert045( )
      {
         BeforeValidate045( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable045( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM045( 0) ;
            CheckOptimisticConcurrency045( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm045( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert045( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00046 */
                     pr_default.execute(4, new Object[] {A13SecRoleName, A12SecRoleDescription});
                     A4SecRoleId = BC00046_A4SecRoleId[0];
                     pr_default.close(4);
                     dsDefault.SmartCacheProvider.SetUpdated("SecRole") ;
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
               Load045( ) ;
            }
            EndLevel045( ) ;
         }
         CloseExtendedTableCursors045( ) ;
      }

      protected void Update045( )
      {
         BeforeValidate045( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable045( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency045( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm045( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate045( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00047 */
                     pr_default.execute(5, new Object[] {A13SecRoleName, A12SecRoleDescription, A4SecRoleId});
                     pr_default.close(5);
                     dsDefault.SmartCacheProvider.SetUpdated("SecRole") ;
                     if ( (pr_default.getStatus(5) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SecRole"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate045( ) ;
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
            EndLevel045( ) ;
         }
         CloseExtendedTableCursors045( ) ;
      }

      protected void DeferredUpdate045( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate045( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency045( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls045( ) ;
            AfterConfirm045( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete045( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC00048 */
                  pr_default.execute(6, new Object[] {A4SecRoleId});
                  pr_default.close(6);
                  dsDefault.SmartCacheProvider.SetUpdated("SecRole") ;
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
         sMode5 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel045( ) ;
         Gx_mode = sMode5;
      }

      protected void OnDeleteControls045( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV17Pgmname = "WWPBaseObjects.SecRole_BC";
         }
         if ( AnyError == 0 )
         {
            /* Using cursor BC00049 */
            pr_default.execute(7, new Object[] {A4SecRoleId});
            if ( (pr_default.getStatus(7) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Sec User Role"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(7);
            /* Using cursor BC000410 */
            pr_default.execute(8, new Object[] {A4SecRoleId});
            if ( (pr_default.getStatus(8) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Functionality Role"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(8);
         }
      }

      protected void EndLevel045( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete045( ) ;
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

      public void ScanKeyStart045( )
      {
         /* Scan By routine */
         /* Using cursor BC000411 */
         pr_default.execute(9, new Object[] {A4SecRoleId});
         RcdFound5 = 0;
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound5 = 1;
            A4SecRoleId = BC000411_A4SecRoleId[0];
            A13SecRoleName = BC000411_A13SecRoleName[0];
            A12SecRoleDescription = BC000411_A12SecRoleDescription[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext045( )
      {
         /* Scan next routine */
         pr_default.readNext(9);
         RcdFound5 = 0;
         ScanKeyLoad045( ) ;
      }

      protected void ScanKeyLoad045( )
      {
         sMode5 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound5 = 1;
            A4SecRoleId = BC000411_A4SecRoleId[0];
            A13SecRoleName = BC000411_A13SecRoleName[0];
            A12SecRoleDescription = BC000411_A12SecRoleDescription[0];
         }
         Gx_mode = sMode5;
      }

      protected void ScanKeyEnd045( )
      {
         pr_default.close(9);
      }

      protected void AfterConfirm045( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert045( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate045( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete045( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete045( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate045( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes045( )
      {
      }

      protected void send_integrity_lvl_hashes045( )
      {
      }

      protected void AddRow045( )
      {
         VarsToRow5( bcwwpbaseobjects_SecRole) ;
      }

      protected void ReadRow045( )
      {
         RowToVars5( bcwwpbaseobjects_SecRole, 1) ;
      }

      protected void InitializeNonKey045( )
      {
         A13SecRoleName = "";
         A12SecRoleDescription = "";
         Z13SecRoleName = "";
         Z12SecRoleDescription = "";
      }

      protected void InitAll045( )
      {
         A4SecRoleId = 0;
         InitializeNonKey045( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow5( GeneXus.Programs.wwpbaseobjects.SdtSecRole obj5 )
      {
         obj5.gxTpr_Mode = Gx_mode;
         obj5.gxTpr_Secrolename = A13SecRoleName;
         obj5.gxTpr_Secroledescription = A12SecRoleDescription;
         obj5.gxTpr_Secroleid = A4SecRoleId;
         obj5.gxTpr_Secroleid_Z = Z4SecRoleId;
         obj5.gxTpr_Secrolename_Z = Z13SecRoleName;
         obj5.gxTpr_Secroledescription_Z = Z12SecRoleDescription;
         obj5.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow5( GeneXus.Programs.wwpbaseobjects.SdtSecRole obj5 )
      {
         obj5.gxTpr_Secroleid = A4SecRoleId;
         return  ;
      }

      public void RowToVars5( GeneXus.Programs.wwpbaseobjects.SdtSecRole obj5 ,
                              int forceLoad )
      {
         Gx_mode = obj5.gxTpr_Mode;
         A13SecRoleName = obj5.gxTpr_Secrolename;
         A12SecRoleDescription = obj5.gxTpr_Secroledescription;
         A4SecRoleId = obj5.gxTpr_Secroleid;
         Z4SecRoleId = obj5.gxTpr_Secroleid_Z;
         Z13SecRoleName = obj5.gxTpr_Secrolename_Z;
         Z12SecRoleDescription = obj5.gxTpr_Secroledescription_Z;
         Gx_mode = obj5.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A4SecRoleId = (short)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey045( ) ;
         ScanKeyStart045( ) ;
         if ( RcdFound5 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z4SecRoleId = A4SecRoleId;
         }
         ZM045( -2) ;
         OnLoadActions045( ) ;
         AddRow045( ) ;
         ScanKeyEnd045( ) ;
         if ( RcdFound5 == 0 )
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
         RowToVars5( bcwwpbaseobjects_SecRole, 0) ;
         ScanKeyStart045( ) ;
         if ( RcdFound5 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z4SecRoleId = A4SecRoleId;
         }
         ZM045( -2) ;
         OnLoadActions045( ) ;
         AddRow045( ) ;
         ScanKeyEnd045( ) ;
         if ( RcdFound5 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey045( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert045( ) ;
         }
         else
         {
            if ( RcdFound5 == 1 )
            {
               if ( A4SecRoleId != Z4SecRoleId )
               {
                  A4SecRoleId = Z4SecRoleId;
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
                  Update045( ) ;
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
                  if ( A4SecRoleId != Z4SecRoleId )
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
                        Insert045( ) ;
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
                        Insert045( ) ;
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
         RowToVars5( bcwwpbaseobjects_SecRole, 0) ;
         SaveImpl( ) ;
         VarsToRow5( bcwwpbaseobjects_SecRole) ;
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
         RowToVars5( bcwwpbaseobjects_SecRole, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert045( ) ;
         AfterTrn( ) ;
         VarsToRow5( bcwwpbaseobjects_SecRole) ;
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
            GeneXus.Programs.wwpbaseobjects.SdtSecRole auxBC = new GeneXus.Programs.wwpbaseobjects.SdtSecRole(context) ;
            auxBC.Load(A4SecRoleId);
            auxBC.UpdateDirties(bcwwpbaseobjects_SecRole);
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
         RowToVars5( bcwwpbaseobjects_SecRole, 0) ;
         UpdateImpl( ) ;
         VarsToRow5( bcwwpbaseobjects_SecRole) ;
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
         RowToVars5( bcwwpbaseobjects_SecRole, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert045( ) ;
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
         VarsToRow5( bcwwpbaseobjects_SecRole) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars5( bcwwpbaseobjects_SecRole, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey045( ) ;
         if ( RcdFound5 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A4SecRoleId != Z4SecRoleId )
            {
               A4SecRoleId = Z4SecRoleId;
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
            if ( A4SecRoleId != Z4SecRoleId )
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
         context.RollbackDataStores("wwpbaseobjects.secrole_bc",pr_default);
         VarsToRow5( bcwwpbaseobjects_SecRole) ;
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
         Gx_mode = bcwwpbaseobjects_SecRole.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcwwpbaseobjects_SecRole.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcwwpbaseobjects_SecRole )
         {
            bcwwpbaseobjects_SecRole = (GeneXus.Programs.wwpbaseobjects.SdtSecRole)(sdt);
            if ( StringUtil.StrCmp(bcwwpbaseobjects_SecRole.gxTpr_Mode, "") == 0 )
            {
               bcwwpbaseobjects_SecRole.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow5( bcwwpbaseobjects_SecRole) ;
            }
            else
            {
               RowToVars5( bcwwpbaseobjects_SecRole, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcwwpbaseobjects_SecRole.gxTpr_Mode, "") == 0 )
            {
               bcwwpbaseobjects_SecRole.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars5( bcwwpbaseobjects_SecRole, 1) ;
         return  ;
      }

      public SdtSecRole SecRole_BC
      {
         get {
            return bcwwpbaseobjects_SecRole ;
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
         AV16WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV17Pgmname = "";
         AV10TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV11WebSession = context.GetSession();
         Z13SecRoleName = "";
         A13SecRoleName = "";
         Z12SecRoleDescription = "";
         A12SecRoleDescription = "";
         BC00044_A4SecRoleId = new short[1] ;
         BC00044_A13SecRoleName = new String[] {""} ;
         BC00044_A12SecRoleDescription = new String[] {""} ;
         BC00045_A4SecRoleId = new short[1] ;
         BC00043_A4SecRoleId = new short[1] ;
         BC00043_A13SecRoleName = new String[] {""} ;
         BC00043_A12SecRoleDescription = new String[] {""} ;
         sMode5 = "";
         BC00042_A4SecRoleId = new short[1] ;
         BC00042_A13SecRoleName = new String[] {""} ;
         BC00042_A12SecRoleDescription = new String[] {""} ;
         BC00046_A4SecRoleId = new short[1] ;
         BC00049_A6SecUserId = new short[1] ;
         BC00049_A4SecRoleId = new short[1] ;
         BC000410_A1SecFunctionalityId = new long[1] ;
         BC000410_A4SecRoleId = new short[1] ;
         BC000411_A4SecRoleId = new short[1] ;
         BC000411_A13SecRoleName = new String[] {""} ;
         BC000411_A12SecRoleDescription = new String[] {""} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.wwpbaseobjects.secrole_bc__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wwpbaseobjects.secrole_bc__default(),
            new Object[][] {
                new Object[] {
               BC00042_A4SecRoleId, BC00042_A13SecRoleName, BC00042_A12SecRoleDescription
               }
               , new Object[] {
               BC00043_A4SecRoleId, BC00043_A13SecRoleName, BC00043_A12SecRoleDescription
               }
               , new Object[] {
               BC00044_A4SecRoleId, BC00044_A13SecRoleName, BC00044_A12SecRoleDescription
               }
               , new Object[] {
               BC00045_A4SecRoleId
               }
               , new Object[] {
               BC00046_A4SecRoleId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC00049_A6SecUserId, BC00049_A4SecRoleId
               }
               , new Object[] {
               BC000410_A1SecFunctionalityId, BC000410_A4SecRoleId
               }
               , new Object[] {
               BC000411_A4SecRoleId, BC000411_A13SecRoleName, BC000411_A12SecRoleDescription
               }
            }
         );
         AV17Pgmname = "WWPBaseObjects.SecRole_BC";
         INITTRN();
         /* Execute Start event if defined. */
         /* Execute user event: Start */
         E12042 ();
         standaloneNotModal( ) ;
      }

      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short Z4SecRoleId ;
      private short A4SecRoleId ;
      private short GX_JID ;
      private short RcdFound5 ;
      private int trnEnded ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String AV17Pgmname ;
      private String sMode5 ;
      private bool AV9IsAuthorized ;
      private bool GXt_boolean1 ;
      private String Z13SecRoleName ;
      private String A13SecRoleName ;
      private String Z12SecRoleDescription ;
      private String A12SecRoleDescription ;
      private IGxSession AV11WebSession ;
      private GeneXus.Programs.wwpbaseobjects.SdtSecRole bcwwpbaseobjects_SecRole ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] BC00044_A4SecRoleId ;
      private String[] BC00044_A13SecRoleName ;
      private String[] BC00044_A12SecRoleDescription ;
      private short[] BC00045_A4SecRoleId ;
      private short[] BC00043_A4SecRoleId ;
      private String[] BC00043_A13SecRoleName ;
      private String[] BC00043_A12SecRoleDescription ;
      private short[] BC00042_A4SecRoleId ;
      private String[] BC00042_A13SecRoleName ;
      private String[] BC00042_A12SecRoleDescription ;
      private short[] BC00046_A4SecRoleId ;
      private short[] BC00049_A6SecUserId ;
      private short[] BC00049_A4SecRoleId ;
      private long[] BC000410_A1SecFunctionalityId ;
      private short[] BC000410_A4SecRoleId ;
      private short[] BC000411_A4SecRoleId ;
      private String[] BC000411_A13SecRoleName ;
      private String[] BC000411_A12SecRoleDescription ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_datastore1 ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV16WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV10TrnContext ;
   }

   public class secrole_bc__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class secrole_bc__default : DataStoreHelperBase, IDataStoreHelper
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
        Object[] prmBC00044 ;
        prmBC00044 = new Object[] {
        new Object[] {"@SecRoleId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmBC00045 ;
        prmBC00045 = new Object[] {
        new Object[] {"@SecRoleId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmBC00043 ;
        prmBC00043 = new Object[] {
        new Object[] {"@SecRoleId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmBC00042 ;
        prmBC00042 = new Object[] {
        new Object[] {"@SecRoleId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmBC00046 ;
        prmBC00046 = new Object[] {
        new Object[] {"@SecRoleName",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@SecRoleDescription",SqlDbType.NVarChar,120,0}
        } ;
        Object[] prmBC00047 ;
        prmBC00047 = new Object[] {
        new Object[] {"@SecRoleName",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@SecRoleDescription",SqlDbType.NVarChar,120,0} ,
        new Object[] {"@SecRoleId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmBC00048 ;
        prmBC00048 = new Object[] {
        new Object[] {"@SecRoleId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmBC00049 ;
        prmBC00049 = new Object[] {
        new Object[] {"@SecRoleId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmBC000410 ;
        prmBC000410 = new Object[] {
        new Object[] {"@SecRoleId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmBC000411 ;
        prmBC000411 = new Object[] {
        new Object[] {"@SecRoleId",SqlDbType.SmallInt,4,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("BC00042", "SELECT [SecRoleId], [SecRoleName], [SecRoleDescription] FROM [SecRole] WITH (UPDLOCK) WHERE [SecRoleId] = @SecRoleId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00042,1,0,true,false )
           ,new CursorDef("BC00043", "SELECT [SecRoleId], [SecRoleName], [SecRoleDescription] FROM [SecRole] WITH (NOLOCK) WHERE [SecRoleId] = @SecRoleId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00043,1,0,true,false )
           ,new CursorDef("BC00044", "SELECT TM1.[SecRoleId], TM1.[SecRoleName], TM1.[SecRoleDescription] FROM [SecRole] TM1 WITH (NOLOCK) WHERE TM1.[SecRoleId] = @SecRoleId ORDER BY TM1.[SecRoleId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00044,100,0,true,false )
           ,new CursorDef("BC00045", "SELECT [SecRoleId] FROM [SecRole] WITH (NOLOCK) WHERE [SecRoleId] = @SecRoleId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00045,1,0,true,false )
           ,new CursorDef("BC00046", "INSERT INTO [SecRole]([SecRoleName], [SecRoleDescription]) VALUES(@SecRoleName, @SecRoleDescription); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmBC00046)
           ,new CursorDef("BC00047", "UPDATE [SecRole] SET [SecRoleName]=@SecRoleName, [SecRoleDescription]=@SecRoleDescription  WHERE [SecRoleId] = @SecRoleId", GxErrorMask.GX_NOMASK,prmBC00047)
           ,new CursorDef("BC00048", "DELETE FROM [SecRole]  WHERE [SecRoleId] = @SecRoleId", GxErrorMask.GX_NOMASK,prmBC00048)
           ,new CursorDef("BC00049", "SELECT TOP 1 [SecUserId], [SecRoleId] FROM [SecUserRole] WITH (NOLOCK) WHERE [SecRoleId] = @SecRoleId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00049,1,0,true,true )
           ,new CursorDef("BC000410", "SELECT TOP 1 [SecFunctionalityId], [SecRoleId] FROM [SecFunctionalityRole] WITH (NOLOCK) WHERE [SecRoleId] = @SecRoleId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000410,1,0,true,true )
           ,new CursorDef("BC000411", "SELECT TM1.[SecRoleId], TM1.[SecRoleName], TM1.[SecRoleDescription] FROM [SecRole] TM1 WITH (NOLOCK) WHERE TM1.[SecRoleId] = @SecRoleId ORDER BY TM1.[SecRoleId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000411,100,0,true,false )
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
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
              return;
           case 1 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
              return;
           case 2 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
              return;
           case 3 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              return;
           case 4 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              return;
           case 7 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              ((short[]) buf[1])[0] = rslt.getShort(2) ;
              return;
           case 8 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((short[]) buf[1])[0] = rslt.getShort(2) ;
              return;
           case 9 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
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
              return;
           case 1 :
              stmt.SetParameter(1, (short)parms[0]);
              return;
           case 2 :
              stmt.SetParameter(1, (short)parms[0]);
              return;
           case 3 :
              stmt.SetParameter(1, (short)parms[0]);
              return;
           case 4 :
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              return;
           case 5 :
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              stmt.SetParameter(3, (short)parms[2]);
              return;
           case 6 :
              stmt.SetParameter(1, (short)parms[0]);
              return;
           case 7 :
              stmt.SetParameter(1, (short)parms[0]);
              return;
           case 8 :
              stmt.SetParameter(1, (short)parms[0]);
              return;
           case 9 :
              stmt.SetParameter(1, (short)parms[0]);
              return;
     }
  }

}

}
