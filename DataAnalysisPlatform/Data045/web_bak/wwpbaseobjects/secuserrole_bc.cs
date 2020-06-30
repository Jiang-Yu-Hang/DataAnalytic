/*
               File: WWPBaseObjects.SecUserRole_BC
        Description: 用户角色关系表
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:35:51.87
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
   public class secuserrole_bc : GXHttpHandler, IGxSilentTrn
   {
      public secuserrole_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public secuserrole_bc( IGxContext context )
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
         ReadRow067( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey067( ) ;
         standaloneModal( ) ;
         AddRow067( ) ;
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

      protected void CONFIRM_060( )
      {
         BeforeValidate067( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls067( ) ;
            }
            else
            {
               CheckExtendedTable067( ) ;
               if ( AnyError == 0 )
               {
                  ZM067( 2) ;
                  ZM067( 3) ;
               }
               CloseExtendedTableCursors067( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void ZM067( short GX_JID )
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
            Z13SecRoleName = A13SecRoleName;
            Z12SecRoleDescription = A12SecRoleDescription;
         }
         if ( GX_JID == -1 )
         {
            Z6SecUserId = A6SecUserId;
            Z4SecRoleId = A4SecRoleId;
            Z14SecUserName = A14SecUserName;
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

      protected void Load067( )
      {
         /* Using cursor BC00066 */
         pr_default.execute(4, new Object[] {A6SecUserId, A4SecRoleId});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound7 = 1;
            A14SecUserName = BC00066_A14SecUserName[0];
            A13SecRoleName = BC00066_A13SecRoleName[0];
            A12SecRoleDescription = BC00066_A12SecRoleDescription[0];
            ZM067( -1) ;
         }
         pr_default.close(4);
         OnLoadActions067( ) ;
      }

      protected void OnLoadActions067( )
      {
      }

      protected void CheckExtendedTable067( )
      {
         standaloneModal( ) ;
         /* Using cursor BC00064 */
         pr_default.execute(2, new Object[] {A6SecUserId});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("不匹配'User'", "ForeignKeyNotFound", 1, "SECUSERID");
            AnyError = 1;
         }
         A14SecUserName = BC00064_A14SecUserName[0];
         pr_default.close(2);
         /* Using cursor BC00065 */
         pr_default.execute(3, new Object[] {A4SecRoleId});
         if ( (pr_default.getStatus(3) == 101) )
         {
            GX_msglist.addItem("不匹配'Role'", "ForeignKeyNotFound", 1, "SECROLEID");
            AnyError = 1;
         }
         A13SecRoleName = BC00065_A13SecRoleName[0];
         A12SecRoleDescription = BC00065_A12SecRoleDescription[0];
         pr_default.close(3);
      }

      protected void CloseExtendedTableCursors067( )
      {
         pr_default.close(2);
         pr_default.close(3);
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey067( )
      {
         /* Using cursor BC00067 */
         pr_default.execute(5, new Object[] {A6SecUserId, A4SecRoleId});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound7 = 1;
         }
         else
         {
            RcdFound7 = 0;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC00063 */
         pr_default.execute(1, new Object[] {A6SecUserId, A4SecRoleId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM067( 1) ;
            RcdFound7 = 1;
            A6SecUserId = BC00063_A6SecUserId[0];
            A4SecRoleId = BC00063_A4SecRoleId[0];
            Z6SecUserId = A6SecUserId;
            Z4SecRoleId = A4SecRoleId;
            sMode7 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load067( ) ;
            if ( AnyError == 1 )
            {
               RcdFound7 = 0;
               InitializeNonKey067( ) ;
            }
            Gx_mode = sMode7;
         }
         else
         {
            RcdFound7 = 0;
            InitializeNonKey067( ) ;
            sMode7 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode7;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey067( ) ;
         if ( RcdFound7 == 0 )
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
         CONFIRM_060( ) ;
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

      protected void CheckOptimisticConcurrency067( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC00062 */
            pr_default.execute(0, new Object[] {A6SecUserId, A4SecRoleId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SecUserRole"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"SecUserRole"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert067( )
      {
         BeforeValidate067( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable067( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM067( 0) ;
            CheckOptimisticConcurrency067( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm067( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert067( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00068 */
                     pr_default.execute(6, new Object[] {A6SecUserId, A4SecRoleId});
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("SecUserRole") ;
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
               Load067( ) ;
            }
            EndLevel067( ) ;
         }
         CloseExtendedTableCursors067( ) ;
      }

      protected void Update067( )
      {
         BeforeValidate067( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable067( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency067( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm067( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate067( ) ;
                  if ( AnyError == 0 )
                  {
                     /* No attributes to update on table [SecUserRole] */
                     DeferredUpdate067( ) ;
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
            EndLevel067( ) ;
         }
         CloseExtendedTableCursors067( ) ;
      }

      protected void DeferredUpdate067( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate067( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency067( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls067( ) ;
            AfterConfirm067( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete067( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC00069 */
                  pr_default.execute(7, new Object[] {A6SecUserId, A4SecRoleId});
                  pr_default.close(7);
                  dsDefault.SmartCacheProvider.SetUpdated("SecUserRole") ;
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
         sMode7 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel067( ) ;
         Gx_mode = sMode7;
      }

      protected void OnDeleteControls067( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor BC000610 */
            pr_default.execute(8, new Object[] {A6SecUserId});
            A14SecUserName = BC000610_A14SecUserName[0];
            pr_default.close(8);
            /* Using cursor BC000611 */
            pr_default.execute(9, new Object[] {A4SecRoleId});
            A13SecRoleName = BC000611_A13SecRoleName[0];
            A12SecRoleDescription = BC000611_A12SecRoleDescription[0];
            pr_default.close(9);
         }
      }

      protected void EndLevel067( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete067( ) ;
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

      public void ScanKeyStart067( )
      {
         /* Using cursor BC000612 */
         pr_default.execute(10, new Object[] {A6SecUserId, A4SecRoleId});
         RcdFound7 = 0;
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound7 = 1;
            A14SecUserName = BC000612_A14SecUserName[0];
            A13SecRoleName = BC000612_A13SecRoleName[0];
            A12SecRoleDescription = BC000612_A12SecRoleDescription[0];
            A6SecUserId = BC000612_A6SecUserId[0];
            A4SecRoleId = BC000612_A4SecRoleId[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext067( )
      {
         /* Scan next routine */
         pr_default.readNext(10);
         RcdFound7 = 0;
         ScanKeyLoad067( ) ;
      }

      protected void ScanKeyLoad067( )
      {
         sMode7 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound7 = 1;
            A14SecUserName = BC000612_A14SecUserName[0];
            A13SecRoleName = BC000612_A13SecRoleName[0];
            A12SecRoleDescription = BC000612_A12SecRoleDescription[0];
            A6SecUserId = BC000612_A6SecUserId[0];
            A4SecRoleId = BC000612_A4SecRoleId[0];
         }
         Gx_mode = sMode7;
      }

      protected void ScanKeyEnd067( )
      {
         pr_default.close(10);
      }

      protected void AfterConfirm067( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert067( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate067( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete067( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete067( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate067( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes067( )
      {
      }

      protected void send_integrity_lvl_hashes067( )
      {
      }

      protected void AddRow067( )
      {
         VarsToRow7( bcwwpbaseobjects_SecUserRole) ;
      }

      protected void ReadRow067( )
      {
         RowToVars7( bcwwpbaseobjects_SecUserRole, 1) ;
      }

      protected void InitializeNonKey067( )
      {
         A14SecUserName = "";
         A13SecRoleName = "";
         A12SecRoleDescription = "";
      }

      protected void InitAll067( )
      {
         A6SecUserId = 0;
         A4SecRoleId = 0;
         InitializeNonKey067( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow7( GeneXus.Programs.wwpbaseobjects.SdtSecUserRole obj7 )
      {
         obj7.gxTpr_Mode = Gx_mode;
         obj7.gxTpr_Secusername = A14SecUserName;
         obj7.gxTpr_Secrolename = A13SecRoleName;
         obj7.gxTpr_Secroledescription = A12SecRoleDescription;
         obj7.gxTpr_Secuserid = A6SecUserId;
         obj7.gxTpr_Secroleid = A4SecRoleId;
         obj7.gxTpr_Secuserid_Z = Z6SecUserId;
         obj7.gxTpr_Secroleid_Z = Z4SecRoleId;
         obj7.gxTpr_Secusername_Z = Z14SecUserName;
         obj7.gxTpr_Secrolename_Z = Z13SecRoleName;
         obj7.gxTpr_Secroledescription_Z = Z12SecRoleDescription;
         obj7.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow7( GeneXus.Programs.wwpbaseobjects.SdtSecUserRole obj7 )
      {
         obj7.gxTpr_Secuserid = A6SecUserId;
         obj7.gxTpr_Secroleid = A4SecRoleId;
         return  ;
      }

      public void RowToVars7( GeneXus.Programs.wwpbaseobjects.SdtSecUserRole obj7 ,
                              int forceLoad )
      {
         Gx_mode = obj7.gxTpr_Mode;
         A14SecUserName = obj7.gxTpr_Secusername;
         A13SecRoleName = obj7.gxTpr_Secrolename;
         A12SecRoleDescription = obj7.gxTpr_Secroledescription;
         A6SecUserId = obj7.gxTpr_Secuserid;
         A4SecRoleId = obj7.gxTpr_Secroleid;
         Z6SecUserId = obj7.gxTpr_Secuserid_Z;
         Z4SecRoleId = obj7.gxTpr_Secroleid_Z;
         Z14SecUserName = obj7.gxTpr_Secusername_Z;
         Z13SecRoleName = obj7.gxTpr_Secrolename_Z;
         Z12SecRoleDescription = obj7.gxTpr_Secroledescription_Z;
         Gx_mode = obj7.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A6SecUserId = (short)getParm(obj,0);
         A4SecRoleId = (short)getParm(obj,1);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey067( ) ;
         ScanKeyStart067( ) ;
         if ( RcdFound7 == 0 )
         {
            Gx_mode = "INS";
            /* Using cursor BC000610 */
            pr_default.execute(8, new Object[] {A6SecUserId});
            if ( (pr_default.getStatus(8) == 101) )
            {
               GX_msglist.addItem("不匹配'User'", "ForeignKeyNotFound", 1, "SECUSERID");
               AnyError = 1;
            }
            A14SecUserName = BC000610_A14SecUserName[0];
            pr_default.close(8);
            /* Using cursor BC000611 */
            pr_default.execute(9, new Object[] {A4SecRoleId});
            if ( (pr_default.getStatus(9) == 101) )
            {
               GX_msglist.addItem("不匹配'Role'", "ForeignKeyNotFound", 1, "SECROLEID");
               AnyError = 1;
            }
            A13SecRoleName = BC000611_A13SecRoleName[0];
            A12SecRoleDescription = BC000611_A12SecRoleDescription[0];
            pr_default.close(9);
         }
         else
         {
            Gx_mode = "UPD";
            Z6SecUserId = A6SecUserId;
            Z4SecRoleId = A4SecRoleId;
         }
         ZM067( -1) ;
         OnLoadActions067( ) ;
         AddRow067( ) ;
         ScanKeyEnd067( ) ;
         if ( RcdFound7 == 0 )
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
         RowToVars7( bcwwpbaseobjects_SecUserRole, 0) ;
         ScanKeyStart067( ) ;
         if ( RcdFound7 == 0 )
         {
            Gx_mode = "INS";
            /* Using cursor BC000610 */
            pr_default.execute(8, new Object[] {A6SecUserId});
            if ( (pr_default.getStatus(8) == 101) )
            {
               GX_msglist.addItem("不匹配'User'", "ForeignKeyNotFound", 1, "SECUSERID");
               AnyError = 1;
            }
            A14SecUserName = BC000610_A14SecUserName[0];
            pr_default.close(8);
            /* Using cursor BC000611 */
            pr_default.execute(9, new Object[] {A4SecRoleId});
            if ( (pr_default.getStatus(9) == 101) )
            {
               GX_msglist.addItem("不匹配'Role'", "ForeignKeyNotFound", 1, "SECROLEID");
               AnyError = 1;
            }
            A13SecRoleName = BC000611_A13SecRoleName[0];
            A12SecRoleDescription = BC000611_A12SecRoleDescription[0];
            pr_default.close(9);
         }
         else
         {
            Gx_mode = "UPD";
            Z6SecUserId = A6SecUserId;
            Z4SecRoleId = A4SecRoleId;
         }
         ZM067( -1) ;
         OnLoadActions067( ) ;
         AddRow067( ) ;
         ScanKeyEnd067( ) ;
         if ( RcdFound7 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey067( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert067( ) ;
         }
         else
         {
            if ( RcdFound7 == 1 )
            {
               if ( ( A6SecUserId != Z6SecUserId ) || ( A4SecRoleId != Z4SecRoleId ) )
               {
                  A6SecUserId = Z6SecUserId;
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
                  Update067( ) ;
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
                  if ( ( A6SecUserId != Z6SecUserId ) || ( A4SecRoleId != Z4SecRoleId ) )
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
                        Insert067( ) ;
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
                        Insert067( ) ;
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
         RowToVars7( bcwwpbaseobjects_SecUserRole, 0) ;
         SaveImpl( ) ;
         VarsToRow7( bcwwpbaseobjects_SecUserRole) ;
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
         RowToVars7( bcwwpbaseobjects_SecUserRole, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert067( ) ;
         AfterTrn( ) ;
         VarsToRow7( bcwwpbaseobjects_SecUserRole) ;
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
            GeneXus.Programs.wwpbaseobjects.SdtSecUserRole auxBC = new GeneXus.Programs.wwpbaseobjects.SdtSecUserRole(context) ;
            auxBC.Load(A6SecUserId, A4SecRoleId);
            auxBC.UpdateDirties(bcwwpbaseobjects_SecUserRole);
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
         RowToVars7( bcwwpbaseobjects_SecUserRole, 0) ;
         UpdateImpl( ) ;
         VarsToRow7( bcwwpbaseobjects_SecUserRole) ;
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
         RowToVars7( bcwwpbaseobjects_SecUserRole, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert067( ) ;
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
         VarsToRow7( bcwwpbaseobjects_SecUserRole) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars7( bcwwpbaseobjects_SecUserRole, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey067( ) ;
         if ( RcdFound7 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( ( A6SecUserId != Z6SecUserId ) || ( A4SecRoleId != Z4SecRoleId ) )
            {
               A6SecUserId = Z6SecUserId;
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
            if ( ( A6SecUserId != Z6SecUserId ) || ( A4SecRoleId != Z4SecRoleId ) )
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
         context.RollbackDataStores("wwpbaseobjects.secuserrole_bc",pr_default);
         VarsToRow7( bcwwpbaseobjects_SecUserRole) ;
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
         Gx_mode = bcwwpbaseobjects_SecUserRole.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcwwpbaseobjects_SecUserRole.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcwwpbaseobjects_SecUserRole )
         {
            bcwwpbaseobjects_SecUserRole = (GeneXus.Programs.wwpbaseobjects.SdtSecUserRole)(sdt);
            if ( StringUtil.StrCmp(bcwwpbaseobjects_SecUserRole.gxTpr_Mode, "") == 0 )
            {
               bcwwpbaseobjects_SecUserRole.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow7( bcwwpbaseobjects_SecUserRole) ;
            }
            else
            {
               RowToVars7( bcwwpbaseobjects_SecUserRole, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcwwpbaseobjects_SecUserRole.gxTpr_Mode, "") == 0 )
            {
               bcwwpbaseobjects_SecUserRole.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars7( bcwwpbaseobjects_SecUserRole, 1) ;
         return  ;
      }

      public SdtSecUserRole SecUserRole_BC
      {
         get {
            return bcwwpbaseobjects_SecUserRole ;
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
         Z13SecRoleName = "";
         A13SecRoleName = "";
         Z12SecRoleDescription = "";
         A12SecRoleDescription = "";
         BC00066_A14SecUserName = new String[] {""} ;
         BC00066_A13SecRoleName = new String[] {""} ;
         BC00066_A12SecRoleDescription = new String[] {""} ;
         BC00066_A6SecUserId = new short[1] ;
         BC00066_A4SecRoleId = new short[1] ;
         BC00064_A14SecUserName = new String[] {""} ;
         BC00065_A13SecRoleName = new String[] {""} ;
         BC00065_A12SecRoleDescription = new String[] {""} ;
         BC00067_A6SecUserId = new short[1] ;
         BC00067_A4SecRoleId = new short[1] ;
         BC00063_A6SecUserId = new short[1] ;
         BC00063_A4SecRoleId = new short[1] ;
         sMode7 = "";
         BC00062_A6SecUserId = new short[1] ;
         BC00062_A4SecRoleId = new short[1] ;
         BC000610_A14SecUserName = new String[] {""} ;
         BC000611_A13SecRoleName = new String[] {""} ;
         BC000611_A12SecRoleDescription = new String[] {""} ;
         BC000612_A14SecUserName = new String[] {""} ;
         BC000612_A13SecRoleName = new String[] {""} ;
         BC000612_A12SecRoleDescription = new String[] {""} ;
         BC000612_A6SecUserId = new short[1] ;
         BC000612_A4SecRoleId = new short[1] ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.wwpbaseobjects.secuserrole_bc__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wwpbaseobjects.secuserrole_bc__default(),
            new Object[][] {
                new Object[] {
               BC00062_A6SecUserId, BC00062_A4SecRoleId
               }
               , new Object[] {
               BC00063_A6SecUserId, BC00063_A4SecRoleId
               }
               , new Object[] {
               BC00064_A14SecUserName
               }
               , new Object[] {
               BC00065_A13SecRoleName, BC00065_A12SecRoleDescription
               }
               , new Object[] {
               BC00066_A14SecUserName, BC00066_A13SecRoleName, BC00066_A12SecRoleDescription, BC00066_A6SecUserId, BC00066_A4SecRoleId
               }
               , new Object[] {
               BC00067_A6SecUserId, BC00067_A4SecRoleId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000610_A14SecUserName
               }
               , new Object[] {
               BC000611_A13SecRoleName, BC000611_A12SecRoleDescription
               }
               , new Object[] {
               BC000612_A14SecUserName, BC000612_A13SecRoleName, BC000612_A12SecRoleDescription, BC000612_A6SecUserId, BC000612_A4SecRoleId
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
      private short Z4SecRoleId ;
      private short A4SecRoleId ;
      private short GX_JID ;
      private short RcdFound7 ;
      private int trnEnded ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String sMode7 ;
      private String Z14SecUserName ;
      private String A14SecUserName ;
      private String Z13SecRoleName ;
      private String A13SecRoleName ;
      private String Z12SecRoleDescription ;
      private String A12SecRoleDescription ;
      private GeneXus.Programs.wwpbaseobjects.SdtSecUserRole bcwwpbaseobjects_SecUserRole ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] BC00066_A14SecUserName ;
      private String[] BC00066_A13SecRoleName ;
      private String[] BC00066_A12SecRoleDescription ;
      private short[] BC00066_A6SecUserId ;
      private short[] BC00066_A4SecRoleId ;
      private String[] BC00064_A14SecUserName ;
      private String[] BC00065_A13SecRoleName ;
      private String[] BC00065_A12SecRoleDescription ;
      private short[] BC00067_A6SecUserId ;
      private short[] BC00067_A4SecRoleId ;
      private short[] BC00063_A6SecUserId ;
      private short[] BC00063_A4SecRoleId ;
      private short[] BC00062_A6SecUserId ;
      private short[] BC00062_A4SecRoleId ;
      private String[] BC000610_A14SecUserName ;
      private String[] BC000611_A13SecRoleName ;
      private String[] BC000611_A12SecRoleDescription ;
      private String[] BC000612_A14SecUserName ;
      private String[] BC000612_A13SecRoleName ;
      private String[] BC000612_A12SecRoleDescription ;
      private short[] BC000612_A6SecUserId ;
      private short[] BC000612_A4SecRoleId ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_datastore1 ;
   }

   public class secuserrole_bc__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class secuserrole_bc__default : DataStoreHelperBase, IDataStoreHelper
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
        Object[] prmBC00066 ;
        prmBC00066 = new Object[] {
        new Object[] {"@SecUserId",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@SecRoleId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmBC00064 ;
        prmBC00064 = new Object[] {
        new Object[] {"@SecUserId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmBC00065 ;
        prmBC00065 = new Object[] {
        new Object[] {"@SecRoleId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmBC00067 ;
        prmBC00067 = new Object[] {
        new Object[] {"@SecUserId",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@SecRoleId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmBC00063 ;
        prmBC00063 = new Object[] {
        new Object[] {"@SecUserId",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@SecRoleId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmBC00062 ;
        prmBC00062 = new Object[] {
        new Object[] {"@SecUserId",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@SecRoleId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmBC00068 ;
        prmBC00068 = new Object[] {
        new Object[] {"@SecUserId",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@SecRoleId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmBC00069 ;
        prmBC00069 = new Object[] {
        new Object[] {"@SecUserId",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@SecRoleId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmBC000612 ;
        prmBC000612 = new Object[] {
        new Object[] {"@SecUserId",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@SecRoleId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmBC000610 ;
        prmBC000610 = new Object[] {
        new Object[] {"@SecUserId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmBC000611 ;
        prmBC000611 = new Object[] {
        new Object[] {"@SecRoleId",SqlDbType.SmallInt,4,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("BC00062", "SELECT [SecUserId], [SecRoleId] FROM [SecUserRole] WITH (UPDLOCK) WHERE [SecUserId] = @SecUserId AND [SecRoleId] = @SecRoleId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00062,1,0,true,false )
           ,new CursorDef("BC00063", "SELECT [SecUserId], [SecRoleId] FROM [SecUserRole] WITH (NOLOCK) WHERE [SecUserId] = @SecUserId AND [SecRoleId] = @SecRoleId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00063,1,0,true,false )
           ,new CursorDef("BC00064", "SELECT [SecUserName] FROM [SecUser] WITH (NOLOCK) WHERE [SecUserId] = @SecUserId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00064,1,0,true,false )
           ,new CursorDef("BC00065", "SELECT [SecRoleName], [SecRoleDescription] FROM [SecRole] WITH (NOLOCK) WHERE [SecRoleId] = @SecRoleId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00065,1,0,true,false )
           ,new CursorDef("BC00066", "SELECT T2.[SecUserName], T3.[SecRoleName], T3.[SecRoleDescription], TM1.[SecUserId], TM1.[SecRoleId] FROM (([SecUserRole] TM1 WITH (NOLOCK) INNER JOIN [SecUser] T2 WITH (NOLOCK) ON T2.[SecUserId] = TM1.[SecUserId]) INNER JOIN [SecRole] T3 WITH (NOLOCK) ON T3.[SecRoleId] = TM1.[SecRoleId]) WHERE TM1.[SecUserId] = @SecUserId and TM1.[SecRoleId] = @SecRoleId ORDER BY TM1.[SecUserId], TM1.[SecRoleId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00066,100,0,true,false )
           ,new CursorDef("BC00067", "SELECT [SecUserId], [SecRoleId] FROM [SecUserRole] WITH (NOLOCK) WHERE [SecUserId] = @SecUserId AND [SecRoleId] = @SecRoleId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00067,1,0,true,false )
           ,new CursorDef("BC00068", "INSERT INTO [SecUserRole]([SecUserId], [SecRoleId]) VALUES(@SecUserId, @SecRoleId)", GxErrorMask.GX_NOMASK,prmBC00068)
           ,new CursorDef("BC00069", "DELETE FROM [SecUserRole]  WHERE [SecUserId] = @SecUserId AND [SecRoleId] = @SecRoleId", GxErrorMask.GX_NOMASK,prmBC00069)
           ,new CursorDef("BC000610", "SELECT [SecUserName] FROM [SecUser] WITH (NOLOCK) WHERE [SecUserId] = @SecUserId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000610,1,0,true,false )
           ,new CursorDef("BC000611", "SELECT [SecRoleName], [SecRoleDescription] FROM [SecRole] WITH (NOLOCK) WHERE [SecRoleId] = @SecRoleId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000611,1,0,true,false )
           ,new CursorDef("BC000612", "SELECT T2.[SecUserName], T3.[SecRoleName], T3.[SecRoleDescription], TM1.[SecUserId], TM1.[SecRoleId] FROM (([SecUserRole] TM1 WITH (NOLOCK) INNER JOIN [SecUser] T2 WITH (NOLOCK) ON T2.[SecUserId] = TM1.[SecUserId]) INNER JOIN [SecRole] T3 WITH (NOLOCK) ON T3.[SecRoleId] = TM1.[SecRoleId]) WHERE TM1.[SecUserId] = @SecUserId and TM1.[SecRoleId] = @SecRoleId ORDER BY TM1.[SecUserId], TM1.[SecRoleId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000612,100,0,true,false )
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
              ((short[]) buf[1])[0] = rslt.getShort(2) ;
              return;
           case 1 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              ((short[]) buf[1])[0] = rslt.getShort(2) ;
              return;
           case 2 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              return;
           case 3 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              return;
           case 4 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
              ((short[]) buf[3])[0] = rslt.getShort(4) ;
              ((short[]) buf[4])[0] = rslt.getShort(5) ;
              return;
           case 5 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              ((short[]) buf[1])[0] = rslt.getShort(2) ;
              return;
           case 8 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              return;
           case 9 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              return;
           case 10 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
              ((short[]) buf[3])[0] = rslt.getShort(4) ;
              ((short[]) buf[4])[0] = rslt.getShort(5) ;
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
              stmt.SetParameter(2, (short)parms[1]);
              return;
           case 1 :
              stmt.SetParameter(1, (short)parms[0]);
              stmt.SetParameter(2, (short)parms[1]);
              return;
           case 2 :
              stmt.SetParameter(1, (short)parms[0]);
              return;
           case 3 :
              stmt.SetParameter(1, (short)parms[0]);
              return;
           case 4 :
              stmt.SetParameter(1, (short)parms[0]);
              stmt.SetParameter(2, (short)parms[1]);
              return;
           case 5 :
              stmt.SetParameter(1, (short)parms[0]);
              stmt.SetParameter(2, (short)parms[1]);
              return;
           case 6 :
              stmt.SetParameter(1, (short)parms[0]);
              stmt.SetParameter(2, (short)parms[1]);
              return;
           case 7 :
              stmt.SetParameter(1, (short)parms[0]);
              stmt.SetParameter(2, (short)parms[1]);
              return;
           case 8 :
              stmt.SetParameter(1, (short)parms[0]);
              return;
           case 9 :
              stmt.SetParameter(1, (short)parms[0]);
              return;
           case 10 :
              stmt.SetParameter(1, (short)parms[0]);
              stmt.SetParameter(2, (short)parms[1]);
              return;
     }
  }

}

}
