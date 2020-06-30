/*
               File: WWPBaseObjects.SecFunctionalityRole_BC
        Description: 权限-角色表
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:6:18.24
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
   public class secfunctionalityrole_bc : GXHttpHandler, IGxSilentTrn
   {
      public secfunctionalityrole_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public secfunctionalityrole_bc( IGxContext context )
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
         ReadRow022( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey022( ) ;
         standaloneModal( ) ;
         AddRow022( ) ;
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
               Z1SecFunctionalityId = A1SecFunctionalityId;
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

      protected void CONFIRM_020( )
      {
         BeforeValidate022( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls022( ) ;
            }
            else
            {
               CheckExtendedTable022( ) ;
               if ( AnyError == 0 )
               {
                  ZM022( 2) ;
                  ZM022( 3) ;
               }
               CloseExtendedTableCursors022( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void ZM022( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
         }
         if ( ( GX_JID == 2 ) || ( GX_JID == 0 ) )
         {
            Z8SecFunctionalityDescription = A8SecFunctionalityDescription;
         }
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
         }
         if ( GX_JID == -1 )
         {
            Z1SecFunctionalityId = A1SecFunctionalityId;
            Z4SecRoleId = A4SecRoleId;
            Z8SecFunctionalityDescription = A8SecFunctionalityDescription;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load022( )
      {
         /* Using cursor BC00026 */
         pr_default.execute(4, new Object[] {A1SecFunctionalityId, A4SecRoleId});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound2 = 1;
            A8SecFunctionalityDescription = BC00026_A8SecFunctionalityDescription[0];
            ZM022( -1) ;
         }
         pr_default.close(4);
         OnLoadActions022( ) ;
      }

      protected void OnLoadActions022( )
      {
      }

      protected void CheckExtendedTable022( )
      {
         standaloneModal( ) ;
         /* Using cursor BC00024 */
         pr_default.execute(2, new Object[] {A1SecFunctionalityId});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("不匹配'Functionality'", "ForeignKeyNotFound", 1, "SECFUNCTIONALITYID");
            AnyError = 1;
         }
         A8SecFunctionalityDescription = BC00024_A8SecFunctionalityDescription[0];
         pr_default.close(2);
         /* Using cursor BC00025 */
         pr_default.execute(3, new Object[] {A4SecRoleId});
         if ( (pr_default.getStatus(3) == 101) )
         {
            GX_msglist.addItem("不匹配'Role'", "ForeignKeyNotFound", 1, "SECROLEID");
            AnyError = 1;
         }
         pr_default.close(3);
      }

      protected void CloseExtendedTableCursors022( )
      {
         pr_default.close(2);
         pr_default.close(3);
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey022( )
      {
         /* Using cursor BC00027 */
         pr_default.execute(5, new Object[] {A1SecFunctionalityId, A4SecRoleId});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound2 = 1;
         }
         else
         {
            RcdFound2 = 0;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC00023 */
         pr_default.execute(1, new Object[] {A1SecFunctionalityId, A4SecRoleId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM022( 1) ;
            RcdFound2 = 1;
            A1SecFunctionalityId = BC00023_A1SecFunctionalityId[0];
            A4SecRoleId = BC00023_A4SecRoleId[0];
            Z1SecFunctionalityId = A1SecFunctionalityId;
            Z4SecRoleId = A4SecRoleId;
            sMode2 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load022( ) ;
            if ( AnyError == 1 )
            {
               RcdFound2 = 0;
               InitializeNonKey022( ) ;
            }
            Gx_mode = sMode2;
         }
         else
         {
            RcdFound2 = 0;
            InitializeNonKey022( ) ;
            sMode2 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode2;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey022( ) ;
         if ( RcdFound2 == 0 )
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
         CONFIRM_020( ) ;
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

      protected void CheckOptimisticConcurrency022( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC00022 */
            pr_default.execute(0, new Object[] {A1SecFunctionalityId, A4SecRoleId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SecFunctionalityRole"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"SecFunctionalityRole"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert022( )
      {
         BeforeValidate022( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable022( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM022( 0) ;
            CheckOptimisticConcurrency022( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm022( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert022( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00028 */
                     pr_default.execute(6, new Object[] {A1SecFunctionalityId, A4SecRoleId});
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("SecFunctionalityRole") ;
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
               Load022( ) ;
            }
            EndLevel022( ) ;
         }
         CloseExtendedTableCursors022( ) ;
      }

      protected void Update022( )
      {
         BeforeValidate022( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable022( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency022( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm022( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate022( ) ;
                  if ( AnyError == 0 )
                  {
                     /* No attributes to update on table [SecFunctionalityRole] */
                     DeferredUpdate022( ) ;
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
            EndLevel022( ) ;
         }
         CloseExtendedTableCursors022( ) ;
      }

      protected void DeferredUpdate022( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate022( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency022( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls022( ) ;
            AfterConfirm022( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete022( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC00029 */
                  pr_default.execute(7, new Object[] {A1SecFunctionalityId, A4SecRoleId});
                  pr_default.close(7);
                  dsDefault.SmartCacheProvider.SetUpdated("SecFunctionalityRole") ;
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
         sMode2 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel022( ) ;
         Gx_mode = sMode2;
      }

      protected void OnDeleteControls022( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor BC000210 */
            pr_default.execute(8, new Object[] {A1SecFunctionalityId});
            A8SecFunctionalityDescription = BC000210_A8SecFunctionalityDescription[0];
            pr_default.close(8);
         }
      }

      protected void EndLevel022( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete022( ) ;
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

      public void ScanKeyStart022( )
      {
         /* Scan By routine */
         /* Using cursor BC000211 */
         pr_default.execute(9, new Object[] {A1SecFunctionalityId, A4SecRoleId});
         RcdFound2 = 0;
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound2 = 1;
            A8SecFunctionalityDescription = BC000211_A8SecFunctionalityDescription[0];
            A1SecFunctionalityId = BC000211_A1SecFunctionalityId[0];
            A4SecRoleId = BC000211_A4SecRoleId[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext022( )
      {
         /* Scan next routine */
         pr_default.readNext(9);
         RcdFound2 = 0;
         ScanKeyLoad022( ) ;
      }

      protected void ScanKeyLoad022( )
      {
         sMode2 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound2 = 1;
            A8SecFunctionalityDescription = BC000211_A8SecFunctionalityDescription[0];
            A1SecFunctionalityId = BC000211_A1SecFunctionalityId[0];
            A4SecRoleId = BC000211_A4SecRoleId[0];
         }
         Gx_mode = sMode2;
      }

      protected void ScanKeyEnd022( )
      {
         pr_default.close(9);
      }

      protected void AfterConfirm022( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert022( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate022( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete022( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete022( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate022( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes022( )
      {
      }

      protected void send_integrity_lvl_hashes022( )
      {
      }

      protected void AddRow022( )
      {
         VarsToRow2( bcwwpbaseobjects_SecFunctionalityRole) ;
      }

      protected void ReadRow022( )
      {
         RowToVars2( bcwwpbaseobjects_SecFunctionalityRole, 1) ;
      }

      protected void InitializeNonKey022( )
      {
         A8SecFunctionalityDescription = "";
      }

      protected void InitAll022( )
      {
         A1SecFunctionalityId = 0;
         A4SecRoleId = 0;
         InitializeNonKey022( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow2( GeneXus.Programs.wwpbaseobjects.SdtSecFunctionalityRole obj2 )
      {
         obj2.gxTpr_Mode = Gx_mode;
         obj2.gxTpr_Secfunctionalitydescription = A8SecFunctionalityDescription;
         obj2.gxTpr_Secfunctionalityid = A1SecFunctionalityId;
         obj2.gxTpr_Secroleid = A4SecRoleId;
         obj2.gxTpr_Secfunctionalityid_Z = Z1SecFunctionalityId;
         obj2.gxTpr_Secfunctionalitydescription_Z = Z8SecFunctionalityDescription;
         obj2.gxTpr_Secroleid_Z = Z4SecRoleId;
         obj2.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow2( GeneXus.Programs.wwpbaseobjects.SdtSecFunctionalityRole obj2 )
      {
         obj2.gxTpr_Secfunctionalityid = A1SecFunctionalityId;
         obj2.gxTpr_Secroleid = A4SecRoleId;
         return  ;
      }

      public void RowToVars2( GeneXus.Programs.wwpbaseobjects.SdtSecFunctionalityRole obj2 ,
                              int forceLoad )
      {
         Gx_mode = obj2.gxTpr_Mode;
         A8SecFunctionalityDescription = obj2.gxTpr_Secfunctionalitydescription;
         A1SecFunctionalityId = obj2.gxTpr_Secfunctionalityid;
         A4SecRoleId = obj2.gxTpr_Secroleid;
         Z1SecFunctionalityId = obj2.gxTpr_Secfunctionalityid_Z;
         Z8SecFunctionalityDescription = obj2.gxTpr_Secfunctionalitydescription_Z;
         Z4SecRoleId = obj2.gxTpr_Secroleid_Z;
         Gx_mode = obj2.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A1SecFunctionalityId = (long)getParm(obj,0);
         A4SecRoleId = (short)getParm(obj,1);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey022( ) ;
         ScanKeyStart022( ) ;
         if ( RcdFound2 == 0 )
         {
            Gx_mode = "INS";
            /* Using cursor BC000210 */
            pr_default.execute(8, new Object[] {A1SecFunctionalityId});
            if ( (pr_default.getStatus(8) == 101) )
            {
               GX_msglist.addItem("不匹配'Functionality'", "ForeignKeyNotFound", 1, "SECFUNCTIONALITYID");
               AnyError = 1;
            }
            A8SecFunctionalityDescription = BC000210_A8SecFunctionalityDescription[0];
            pr_default.close(8);
            /* Using cursor BC000212 */
            pr_default.execute(10, new Object[] {A4SecRoleId});
            if ( (pr_default.getStatus(10) == 101) )
            {
               GX_msglist.addItem("不匹配'Role'", "ForeignKeyNotFound", 1, "SECROLEID");
               AnyError = 1;
            }
            pr_default.close(10);
         }
         else
         {
            Gx_mode = "UPD";
            Z1SecFunctionalityId = A1SecFunctionalityId;
            Z4SecRoleId = A4SecRoleId;
         }
         ZM022( -1) ;
         OnLoadActions022( ) ;
         AddRow022( ) ;
         ScanKeyEnd022( ) ;
         if ( RcdFound2 == 0 )
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
         RowToVars2( bcwwpbaseobjects_SecFunctionalityRole, 0) ;
         ScanKeyStart022( ) ;
         if ( RcdFound2 == 0 )
         {
            Gx_mode = "INS";
            /* Using cursor BC000210 */
            pr_default.execute(8, new Object[] {A1SecFunctionalityId});
            if ( (pr_default.getStatus(8) == 101) )
            {
               GX_msglist.addItem("不匹配'Functionality'", "ForeignKeyNotFound", 1, "SECFUNCTIONALITYID");
               AnyError = 1;
            }
            A8SecFunctionalityDescription = BC000210_A8SecFunctionalityDescription[0];
            pr_default.close(8);
            /* Using cursor BC000212 */
            pr_default.execute(10, new Object[] {A4SecRoleId});
            if ( (pr_default.getStatus(10) == 101) )
            {
               GX_msglist.addItem("不匹配'Role'", "ForeignKeyNotFound", 1, "SECROLEID");
               AnyError = 1;
            }
            pr_default.close(10);
         }
         else
         {
            Gx_mode = "UPD";
            Z1SecFunctionalityId = A1SecFunctionalityId;
            Z4SecRoleId = A4SecRoleId;
         }
         ZM022( -1) ;
         OnLoadActions022( ) ;
         AddRow022( ) ;
         ScanKeyEnd022( ) ;
         if ( RcdFound2 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey022( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert022( ) ;
         }
         else
         {
            if ( RcdFound2 == 1 )
            {
               if ( ( A1SecFunctionalityId != Z1SecFunctionalityId ) || ( A4SecRoleId != Z4SecRoleId ) )
               {
                  A1SecFunctionalityId = Z1SecFunctionalityId;
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
                  Update022( ) ;
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
                  if ( ( A1SecFunctionalityId != Z1SecFunctionalityId ) || ( A4SecRoleId != Z4SecRoleId ) )
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
                        Insert022( ) ;
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
                        Insert022( ) ;
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
         RowToVars2( bcwwpbaseobjects_SecFunctionalityRole, 0) ;
         SaveImpl( ) ;
         VarsToRow2( bcwwpbaseobjects_SecFunctionalityRole) ;
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
         RowToVars2( bcwwpbaseobjects_SecFunctionalityRole, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert022( ) ;
         AfterTrn( ) ;
         VarsToRow2( bcwwpbaseobjects_SecFunctionalityRole) ;
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
            GeneXus.Programs.wwpbaseobjects.SdtSecFunctionalityRole auxBC = new GeneXus.Programs.wwpbaseobjects.SdtSecFunctionalityRole(context) ;
            auxBC.Load(A1SecFunctionalityId, A4SecRoleId);
            auxBC.UpdateDirties(bcwwpbaseobjects_SecFunctionalityRole);
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
         RowToVars2( bcwwpbaseobjects_SecFunctionalityRole, 0) ;
         UpdateImpl( ) ;
         VarsToRow2( bcwwpbaseobjects_SecFunctionalityRole) ;
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
         RowToVars2( bcwwpbaseobjects_SecFunctionalityRole, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert022( ) ;
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
         VarsToRow2( bcwwpbaseobjects_SecFunctionalityRole) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars2( bcwwpbaseobjects_SecFunctionalityRole, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey022( ) ;
         if ( RcdFound2 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( ( A1SecFunctionalityId != Z1SecFunctionalityId ) || ( A4SecRoleId != Z4SecRoleId ) )
            {
               A1SecFunctionalityId = Z1SecFunctionalityId;
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
            if ( ( A1SecFunctionalityId != Z1SecFunctionalityId ) || ( A4SecRoleId != Z4SecRoleId ) )
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
         pr_default.close(10);
         context.RollbackDataStores("wwpbaseobjects.secfunctionalityrole_bc",pr_default);
         VarsToRow2( bcwwpbaseobjects_SecFunctionalityRole) ;
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
         Gx_mode = bcwwpbaseobjects_SecFunctionalityRole.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcwwpbaseobjects_SecFunctionalityRole.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcwwpbaseobjects_SecFunctionalityRole )
         {
            bcwwpbaseobjects_SecFunctionalityRole = (GeneXus.Programs.wwpbaseobjects.SdtSecFunctionalityRole)(sdt);
            if ( StringUtil.StrCmp(bcwwpbaseobjects_SecFunctionalityRole.gxTpr_Mode, "") == 0 )
            {
               bcwwpbaseobjects_SecFunctionalityRole.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow2( bcwwpbaseobjects_SecFunctionalityRole) ;
            }
            else
            {
               RowToVars2( bcwwpbaseobjects_SecFunctionalityRole, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcwwpbaseobjects_SecFunctionalityRole.gxTpr_Mode, "") == 0 )
            {
               bcwwpbaseobjects_SecFunctionalityRole.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars2( bcwwpbaseobjects_SecFunctionalityRole, 1) ;
         return  ;
      }

      public SdtSecFunctionalityRole SecFunctionalityRole_BC
      {
         get {
            return bcwwpbaseobjects_SecFunctionalityRole ;
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
         pr_default.close(10);
      }

      public override void initialize( )
      {
         scmdbuf = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Gx_mode = "";
         Z8SecFunctionalityDescription = "";
         A8SecFunctionalityDescription = "";
         BC00026_A8SecFunctionalityDescription = new String[] {""} ;
         BC00026_A1SecFunctionalityId = new long[1] ;
         BC00026_A4SecRoleId = new short[1] ;
         BC00024_A8SecFunctionalityDescription = new String[] {""} ;
         BC00025_A4SecRoleId = new short[1] ;
         BC00027_A1SecFunctionalityId = new long[1] ;
         BC00027_A4SecRoleId = new short[1] ;
         BC00023_A1SecFunctionalityId = new long[1] ;
         BC00023_A4SecRoleId = new short[1] ;
         sMode2 = "";
         BC00022_A1SecFunctionalityId = new long[1] ;
         BC00022_A4SecRoleId = new short[1] ;
         BC000210_A8SecFunctionalityDescription = new String[] {""} ;
         BC000211_A8SecFunctionalityDescription = new String[] {""} ;
         BC000211_A1SecFunctionalityId = new long[1] ;
         BC000211_A4SecRoleId = new short[1] ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         BC000212_A4SecRoleId = new short[1] ;
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.wwpbaseobjects.secfunctionalityrole_bc__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wwpbaseobjects.secfunctionalityrole_bc__default(),
            new Object[][] {
                new Object[] {
               BC00022_A1SecFunctionalityId, BC00022_A4SecRoleId
               }
               , new Object[] {
               BC00023_A1SecFunctionalityId, BC00023_A4SecRoleId
               }
               , new Object[] {
               BC00024_A8SecFunctionalityDescription
               }
               , new Object[] {
               BC00025_A4SecRoleId
               }
               , new Object[] {
               BC00026_A8SecFunctionalityDescription, BC00026_A1SecFunctionalityId, BC00026_A4SecRoleId
               }
               , new Object[] {
               BC00027_A1SecFunctionalityId, BC00027_A4SecRoleId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000210_A8SecFunctionalityDescription
               }
               , new Object[] {
               BC000211_A8SecFunctionalityDescription, BC000211_A1SecFunctionalityId, BC000211_A4SecRoleId
               }
               , new Object[] {
               BC000212_A4SecRoleId
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
      private short Z4SecRoleId ;
      private short A4SecRoleId ;
      private short GX_JID ;
      private short RcdFound2 ;
      private int trnEnded ;
      private long Z1SecFunctionalityId ;
      private long A1SecFunctionalityId ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String sMode2 ;
      private String Z8SecFunctionalityDescription ;
      private String A8SecFunctionalityDescription ;
      private GeneXus.Programs.wwpbaseobjects.SdtSecFunctionalityRole bcwwpbaseobjects_SecFunctionalityRole ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] BC00026_A8SecFunctionalityDescription ;
      private long[] BC00026_A1SecFunctionalityId ;
      private short[] BC00026_A4SecRoleId ;
      private String[] BC00024_A8SecFunctionalityDescription ;
      private short[] BC00025_A4SecRoleId ;
      private long[] BC00027_A1SecFunctionalityId ;
      private short[] BC00027_A4SecRoleId ;
      private long[] BC00023_A1SecFunctionalityId ;
      private short[] BC00023_A4SecRoleId ;
      private long[] BC00022_A1SecFunctionalityId ;
      private short[] BC00022_A4SecRoleId ;
      private String[] BC000210_A8SecFunctionalityDescription ;
      private String[] BC000211_A8SecFunctionalityDescription ;
      private long[] BC000211_A1SecFunctionalityId ;
      private short[] BC000211_A4SecRoleId ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private short[] BC000212_A4SecRoleId ;
      private IDataStoreProvider pr_datastore1 ;
   }

   public class secfunctionalityrole_bc__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class secfunctionalityrole_bc__default : DataStoreHelperBase, IDataStoreHelper
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
        Object[] prmBC00026 ;
        prmBC00026 = new Object[] {
        new Object[] {"@SecFunctionalityId",SqlDbType.Decimal,10,0} ,
        new Object[] {"@SecRoleId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmBC00024 ;
        prmBC00024 = new Object[] {
        new Object[] {"@SecFunctionalityId",SqlDbType.Decimal,10,0}
        } ;
        Object[] prmBC00025 ;
        prmBC00025 = new Object[] {
        new Object[] {"@SecRoleId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmBC00027 ;
        prmBC00027 = new Object[] {
        new Object[] {"@SecFunctionalityId",SqlDbType.Decimal,10,0} ,
        new Object[] {"@SecRoleId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmBC00023 ;
        prmBC00023 = new Object[] {
        new Object[] {"@SecFunctionalityId",SqlDbType.Decimal,10,0} ,
        new Object[] {"@SecRoleId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmBC00022 ;
        prmBC00022 = new Object[] {
        new Object[] {"@SecFunctionalityId",SqlDbType.Decimal,10,0} ,
        new Object[] {"@SecRoleId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmBC00028 ;
        prmBC00028 = new Object[] {
        new Object[] {"@SecFunctionalityId",SqlDbType.Decimal,10,0} ,
        new Object[] {"@SecRoleId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmBC00029 ;
        prmBC00029 = new Object[] {
        new Object[] {"@SecFunctionalityId",SqlDbType.Decimal,10,0} ,
        new Object[] {"@SecRoleId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmBC000211 ;
        prmBC000211 = new Object[] {
        new Object[] {"@SecFunctionalityId",SqlDbType.Decimal,10,0} ,
        new Object[] {"@SecRoleId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmBC000210 ;
        prmBC000210 = new Object[] {
        new Object[] {"@SecFunctionalityId",SqlDbType.Decimal,10,0}
        } ;
        Object[] prmBC000212 ;
        prmBC000212 = new Object[] {
        new Object[] {"@SecRoleId",SqlDbType.SmallInt,4,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("BC00022", "SELECT [SecFunctionalityId], [SecRoleId] FROM [SecFunctionalityRole] WITH (UPDLOCK) WHERE [SecFunctionalityId] = @SecFunctionalityId AND [SecRoleId] = @SecRoleId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00022,1,0,true,false )
           ,new CursorDef("BC00023", "SELECT [SecFunctionalityId], [SecRoleId] FROM [SecFunctionalityRole] WITH (NOLOCK) WHERE [SecFunctionalityId] = @SecFunctionalityId AND [SecRoleId] = @SecRoleId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00023,1,0,true,false )
           ,new CursorDef("BC00024", "SELECT [SecFunctionalityDescription] FROM [SecFunctionality] WITH (NOLOCK) WHERE [SecFunctionalityId] = @SecFunctionalityId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00024,1,0,true,false )
           ,new CursorDef("BC00025", "SELECT [SecRoleId] FROM [SecRole] WITH (NOLOCK) WHERE [SecRoleId] = @SecRoleId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00025,1,0,true,false )
           ,new CursorDef("BC00026", "SELECT T2.[SecFunctionalityDescription], TM1.[SecFunctionalityId], TM1.[SecRoleId] FROM ([SecFunctionalityRole] TM1 WITH (NOLOCK) INNER JOIN [SecFunctionality] T2 WITH (NOLOCK) ON T2.[SecFunctionalityId] = TM1.[SecFunctionalityId]) WHERE TM1.[SecFunctionalityId] = @SecFunctionalityId and TM1.[SecRoleId] = @SecRoleId ORDER BY TM1.[SecFunctionalityId], TM1.[SecRoleId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00026,100,0,true,false )
           ,new CursorDef("BC00027", "SELECT [SecFunctionalityId], [SecRoleId] FROM [SecFunctionalityRole] WITH (NOLOCK) WHERE [SecFunctionalityId] = @SecFunctionalityId AND [SecRoleId] = @SecRoleId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00027,1,0,true,false )
           ,new CursorDef("BC00028", "INSERT INTO [SecFunctionalityRole]([SecFunctionalityId], [SecRoleId]) VALUES(@SecFunctionalityId, @SecRoleId)", GxErrorMask.GX_NOMASK,prmBC00028)
           ,new CursorDef("BC00029", "DELETE FROM [SecFunctionalityRole]  WHERE [SecFunctionalityId] = @SecFunctionalityId AND [SecRoleId] = @SecRoleId", GxErrorMask.GX_NOMASK,prmBC00029)
           ,new CursorDef("BC000210", "SELECT [SecFunctionalityDescription] FROM [SecFunctionality] WITH (NOLOCK) WHERE [SecFunctionalityId] = @SecFunctionalityId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000210,1,0,true,false )
           ,new CursorDef("BC000211", "SELECT T2.[SecFunctionalityDescription], TM1.[SecFunctionalityId], TM1.[SecRoleId] FROM ([SecFunctionalityRole] TM1 WITH (NOLOCK) INNER JOIN [SecFunctionality] T2 WITH (NOLOCK) ON T2.[SecFunctionalityId] = TM1.[SecFunctionalityId]) WHERE TM1.[SecFunctionalityId] = @SecFunctionalityId and TM1.[SecRoleId] = @SecRoleId ORDER BY TM1.[SecFunctionalityId], TM1.[SecRoleId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000211,100,0,true,false )
           ,new CursorDef("BC000212", "SELECT [SecRoleId] FROM [SecRole] WITH (NOLOCK) WHERE [SecRoleId] = @SecRoleId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000212,1,0,true,false )
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
              ((short[]) buf[1])[0] = rslt.getShort(2) ;
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((short[]) buf[1])[0] = rslt.getShort(2) ;
              return;
           case 2 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              return;
           case 3 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              return;
           case 4 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              ((short[]) buf[2])[0] = rslt.getShort(3) ;
              return;
           case 5 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((short[]) buf[1])[0] = rslt.getShort(2) ;
              return;
           case 8 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              return;
           case 9 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              ((short[]) buf[2])[0] = rslt.getShort(3) ;
              return;
           case 10 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
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
              stmt.SetParameter(2, (short)parms[1]);
              return;
           case 1 :
              stmt.SetParameter(1, (long)parms[0]);
              stmt.SetParameter(2, (short)parms[1]);
              return;
           case 2 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 3 :
              stmt.SetParameter(1, (short)parms[0]);
              return;
           case 4 :
              stmt.SetParameter(1, (long)parms[0]);
              stmt.SetParameter(2, (short)parms[1]);
              return;
           case 5 :
              stmt.SetParameter(1, (long)parms[0]);
              stmt.SetParameter(2, (short)parms[1]);
              return;
           case 6 :
              stmt.SetParameter(1, (long)parms[0]);
              stmt.SetParameter(2, (short)parms[1]);
              return;
           case 7 :
              stmt.SetParameter(1, (long)parms[0]);
              stmt.SetParameter(2, (short)parms[1]);
              return;
           case 8 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 9 :
              stmt.SetParameter(1, (long)parms[0]);
              stmt.SetParameter(2, (short)parms[1]);
              return;
           case 10 :
              stmt.SetParameter(1, (short)parms[0]);
              return;
     }
  }

}

}
