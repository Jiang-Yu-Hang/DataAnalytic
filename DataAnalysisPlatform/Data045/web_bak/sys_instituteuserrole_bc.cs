/*
               File: SYS_InstituteUserRole_BC
        Description: SYS_Institute User Role
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:38:55.19
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
   public class sys_instituteuserrole_bc : GXHttpHandler, IGxSilentTrn
   {
      public sys_instituteuserrole_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public sys_instituteuserrole_bc( IGxContext context )
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
         ReadRow1E51( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey1E51( ) ;
         standaloneModal( ) ;
         AddRow1E51( ) ;
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
               Z363SYS_InstituteUserRoleUserRoleID = (Guid)(A363SYS_InstituteUserRoleUserRoleID);
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

      protected void CONFIRM_1E0( )
      {
         BeforeValidate1E51( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls1E51( ) ;
            }
            else
            {
               CheckExtendedTable1E51( ) ;
               if ( AnyError == 0 )
               {
               }
               CloseExtendedTableCursors1E51( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void ZM1E51( short GX_JID )
      {
         if ( ( GX_JID == 7 ) || ( GX_JID == 0 ) )
         {
            Z435SYS_InstituteUserRoleUserID = (Guid)(A435SYS_InstituteUserRoleUserID);
            Z436SYS_InstituteUserRoleRoleID = (Guid)(A436SYS_InstituteUserRoleRoleID);
            Z443SYS_InstituteUserRoleInstituteCode = A443SYS_InstituteUserRoleInstituteCode;
         }
         if ( GX_JID == -7 )
         {
            Z363SYS_InstituteUserRoleUserRoleID = (Guid)(A363SYS_InstituteUserRoleUserRoleID);
            Z435SYS_InstituteUserRoleUserID = (Guid)(A435SYS_InstituteUserRoleUserID);
            Z436SYS_InstituteUserRoleRoleID = (Guid)(A436SYS_InstituteUserRoleRoleID);
            Z443SYS_InstituteUserRoleInstituteCode = A443SYS_InstituteUserRoleInstituteCode;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (Guid.Empty==A435SYS_InstituteUserRoleUserID) )
         {
            A435SYS_InstituteUserRoleUserID = (Guid)(Guid.NewGuid( ));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (Guid.Empty==A436SYS_InstituteUserRoleRoleID) )
         {
            A436SYS_InstituteUserRoleRoleID = (Guid)(Guid.NewGuid( ));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (Guid.Empty==A363SYS_InstituteUserRoleUserRoleID) )
         {
            A363SYS_InstituteUserRoleUserRoleID = (Guid)(Guid.NewGuid( ));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( Gx_BScreen == 0 ) )
         {
         }
      }

      protected void Load1E51( )
      {
         /* Using cursor BC001E4 */
         pr_datastore1.execute(2, new Object[] {A363SYS_InstituteUserRoleUserRoleID});
         if ( (pr_datastore1.getStatus(2) != 101) )
         {
            RcdFound51 = 1;
            A435SYS_InstituteUserRoleUserID = (Guid)((Guid)(BC001E4_A435SYS_InstituteUserRoleUserID[0]));
            A436SYS_InstituteUserRoleRoleID = (Guid)((Guid)(BC001E4_A436SYS_InstituteUserRoleRoleID[0]));
            A443SYS_InstituteUserRoleInstituteCode = BC001E4_A443SYS_InstituteUserRoleInstituteCode[0];
            ZM1E51( -7) ;
         }
         pr_datastore1.close(2);
         OnLoadActions1E51( ) ;
      }

      protected void OnLoadActions1E51( )
      {
      }

      protected void CheckExtendedTable1E51( )
      {
         standaloneModal( ) ;
      }

      protected void CloseExtendedTableCursors1E51( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey1E51( )
      {
         /* Using cursor BC001E5 */
         pr_datastore1.execute(3, new Object[] {A363SYS_InstituteUserRoleUserRoleID});
         if ( (pr_datastore1.getStatus(3) != 101) )
         {
            RcdFound51 = 1;
         }
         else
         {
            RcdFound51 = 0;
         }
         pr_datastore1.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC001E3 */
         pr_datastore1.execute(1, new Object[] {A363SYS_InstituteUserRoleUserRoleID});
         if ( (pr_datastore1.getStatus(1) != 101) )
         {
            ZM1E51( 7) ;
            RcdFound51 = 1;
            A363SYS_InstituteUserRoleUserRoleID = (Guid)((Guid)(BC001E3_A363SYS_InstituteUserRoleUserRoleID[0]));
            A435SYS_InstituteUserRoleUserID = (Guid)((Guid)(BC001E3_A435SYS_InstituteUserRoleUserID[0]));
            A436SYS_InstituteUserRoleRoleID = (Guid)((Guid)(BC001E3_A436SYS_InstituteUserRoleRoleID[0]));
            A443SYS_InstituteUserRoleInstituteCode = BC001E3_A443SYS_InstituteUserRoleInstituteCode[0];
            Z363SYS_InstituteUserRoleUserRoleID = (Guid)(A363SYS_InstituteUserRoleUserRoleID);
            sMode51 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load1E51( ) ;
            if ( AnyError == 1 )
            {
               RcdFound51 = 0;
               InitializeNonKey1E51( ) ;
            }
            Gx_mode = sMode51;
         }
         else
         {
            RcdFound51 = 0;
            InitializeNonKey1E51( ) ;
            sMode51 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode51;
         }
         pr_datastore1.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1E51( ) ;
         if ( RcdFound51 == 0 )
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
         CONFIRM_1E0( ) ;
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

      protected void CheckOptimisticConcurrency1E51( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC001E2 */
            pr_datastore1.execute(0, new Object[] {A363SYS_InstituteUserRoleUserRoleID});
            if ( (pr_datastore1.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SYS_INSTITUTEUSERROLE"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_datastore1.getStatus(0) == 101) || ( Z435SYS_InstituteUserRoleUserID != BC001E2_A435SYS_InstituteUserRoleUserID[0] ) || ( Z436SYS_InstituteUserRoleRoleID != BC001E2_A436SYS_InstituteUserRoleRoleID[0] ) || ( StringUtil.StrCmp(Z443SYS_InstituteUserRoleInstituteCode, BC001E2_A443SYS_InstituteUserRoleInstituteCode[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"SYS_INSTITUTEUSERROLE"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert1E51( )
      {
         BeforeValidate1E51( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1E51( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1E51( 0) ;
            CheckOptimisticConcurrency1E51( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1E51( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1E51( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC001E6 */
                     pr_datastore1.execute(4, new Object[] {A443SYS_InstituteUserRoleInstituteCode, A363SYS_InstituteUserRoleUserRoleID, A435SYS_InstituteUserRoleUserID, A436SYS_InstituteUserRoleRoleID});
                     pr_datastore1.close(4);
                     dsDataStore1.SmartCacheProvider.SetUpdated("SYS_INSTITUTEUSERROLE") ;
                     if ( (pr_datastore1.getStatus(4) == 1) )
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
               Load1E51( ) ;
            }
            EndLevel1E51( ) ;
         }
         CloseExtendedTableCursors1E51( ) ;
      }

      protected void Update1E51( )
      {
         BeforeValidate1E51( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1E51( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1E51( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1E51( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1E51( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC001E7 */
                     pr_datastore1.execute(5, new Object[] {A435SYS_InstituteUserRoleUserID, A436SYS_InstituteUserRoleRoleID, A443SYS_InstituteUserRoleInstituteCode, A363SYS_InstituteUserRoleUserRoleID});
                     pr_datastore1.close(5);
                     dsDataStore1.SmartCacheProvider.SetUpdated("SYS_INSTITUTEUSERROLE") ;
                     if ( (pr_datastore1.getStatus(5) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SYS_INSTITUTEUSERROLE"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate1E51( ) ;
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
            EndLevel1E51( ) ;
         }
         CloseExtendedTableCursors1E51( ) ;
      }

      protected void DeferredUpdate1E51( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate1E51( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1E51( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1E51( ) ;
            AfterConfirm1E51( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1E51( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC001E8 */
                  pr_datastore1.execute(6, new Object[] {A363SYS_InstituteUserRoleUserRoleID});
                  pr_datastore1.close(6);
                  dsDataStore1.SmartCacheProvider.SetUpdated("SYS_INSTITUTEUSERROLE") ;
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
         sMode51 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel1E51( ) ;
         Gx_mode = sMode51;
      }

      protected void OnDeleteControls1E51( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel1E51( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_datastore1.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1E51( ) ;
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

      public void ScanKeyStart1E51( )
      {
         /* Using cursor BC001E9 */
         pr_datastore1.execute(7, new Object[] {A363SYS_InstituteUserRoleUserRoleID});
         RcdFound51 = 0;
         if ( (pr_datastore1.getStatus(7) != 101) )
         {
            RcdFound51 = 1;
            A363SYS_InstituteUserRoleUserRoleID = (Guid)((Guid)(BC001E9_A363SYS_InstituteUserRoleUserRoleID[0]));
            A435SYS_InstituteUserRoleUserID = (Guid)((Guid)(BC001E9_A435SYS_InstituteUserRoleUserID[0]));
            A436SYS_InstituteUserRoleRoleID = (Guid)((Guid)(BC001E9_A436SYS_InstituteUserRoleRoleID[0]));
            A443SYS_InstituteUserRoleInstituteCode = BC001E9_A443SYS_InstituteUserRoleInstituteCode[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext1E51( )
      {
         /* Scan next routine */
         pr_datastore1.readNext(7);
         RcdFound51 = 0;
         ScanKeyLoad1E51( ) ;
      }

      protected void ScanKeyLoad1E51( )
      {
         sMode51 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_datastore1.getStatus(7) != 101) )
         {
            RcdFound51 = 1;
            A363SYS_InstituteUserRoleUserRoleID = (Guid)((Guid)(BC001E9_A363SYS_InstituteUserRoleUserRoleID[0]));
            A435SYS_InstituteUserRoleUserID = (Guid)((Guid)(BC001E9_A435SYS_InstituteUserRoleUserID[0]));
            A436SYS_InstituteUserRoleRoleID = (Guid)((Guid)(BC001E9_A436SYS_InstituteUserRoleRoleID[0]));
            A443SYS_InstituteUserRoleInstituteCode = BC001E9_A443SYS_InstituteUserRoleInstituteCode[0];
         }
         Gx_mode = sMode51;
      }

      protected void ScanKeyEnd1E51( )
      {
         pr_datastore1.close(7);
      }

      protected void AfterConfirm1E51( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1E51( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1E51( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1E51( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1E51( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1E51( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1E51( )
      {
      }

      protected void send_integrity_lvl_hashes1E51( )
      {
      }

      protected void AddRow1E51( )
      {
         VarsToRow51( bcSYS_InstituteUserRole) ;
      }

      protected void ReadRow1E51( )
      {
         RowToVars51( bcSYS_InstituteUserRole, 1) ;
      }

      protected void InitializeNonKey1E51( )
      {
         A443SYS_InstituteUserRoleInstituteCode = "";
         A435SYS_InstituteUserRoleUserID = (Guid)(Guid.NewGuid( ));
         A436SYS_InstituteUserRoleRoleID = (Guid)(Guid.NewGuid( ));
         Z435SYS_InstituteUserRoleUserID = (Guid)(Guid.Empty);
         Z436SYS_InstituteUserRoleRoleID = (Guid)(Guid.Empty);
         Z443SYS_InstituteUserRoleInstituteCode = "";
      }

      protected void InitAll1E51( )
      {
         A363SYS_InstituteUserRoleUserRoleID = (Guid)(Guid.NewGuid( ));
         InitializeNonKey1E51( ) ;
      }

      protected void StandaloneModalInsert( )
      {
         A435SYS_InstituteUserRoleUserID = (Guid)(i435SYS_InstituteUserRoleUserID);
         A436SYS_InstituteUserRoleRoleID = (Guid)(i436SYS_InstituteUserRoleRoleID);
      }

      public void VarsToRow51( SdtSYS_InstituteUserRole obj51 )
      {
         obj51.gxTpr_Mode = Gx_mode;
         obj51.gxTpr_Sys_instituteuserroleinstitutecode = A443SYS_InstituteUserRoleInstituteCode;
         obj51.gxTpr_Sys_instituteuserroleuserid = (Guid)(A435SYS_InstituteUserRoleUserID);
         obj51.gxTpr_Sys_instituteuserroleroleid = (Guid)(A436SYS_InstituteUserRoleRoleID);
         obj51.gxTpr_Sys_instituteuserroleuserroleid = (Guid)(A363SYS_InstituteUserRoleUserRoleID);
         obj51.gxTpr_Sys_instituteuserroleuserroleid_Z = (Guid)(Z363SYS_InstituteUserRoleUserRoleID);
         obj51.gxTpr_Sys_instituteuserroleroleid_Z = (Guid)(Z436SYS_InstituteUserRoleRoleID);
         obj51.gxTpr_Sys_instituteuserroleinstitutecode_Z = Z443SYS_InstituteUserRoleInstituteCode;
         obj51.gxTpr_Sys_instituteuserroleuserid_Z = (Guid)(Z435SYS_InstituteUserRoleUserID);
         obj51.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow51( SdtSYS_InstituteUserRole obj51 )
      {
         obj51.gxTpr_Sys_instituteuserroleuserroleid = (Guid)(A363SYS_InstituteUserRoleUserRoleID);
         return  ;
      }

      public void RowToVars51( SdtSYS_InstituteUserRole obj51 ,
                               int forceLoad )
      {
         Gx_mode = obj51.gxTpr_Mode;
         A443SYS_InstituteUserRoleInstituteCode = obj51.gxTpr_Sys_instituteuserroleinstitutecode;
         A435SYS_InstituteUserRoleUserID = (Guid)(obj51.gxTpr_Sys_instituteuserroleuserid);
         A436SYS_InstituteUserRoleRoleID = (Guid)(obj51.gxTpr_Sys_instituteuserroleroleid);
         A363SYS_InstituteUserRoleUserRoleID = (Guid)(obj51.gxTpr_Sys_instituteuserroleuserroleid);
         Z363SYS_InstituteUserRoleUserRoleID = (Guid)(obj51.gxTpr_Sys_instituteuserroleuserroleid_Z);
         Z436SYS_InstituteUserRoleRoleID = (Guid)(obj51.gxTpr_Sys_instituteuserroleroleid_Z);
         Z443SYS_InstituteUserRoleInstituteCode = obj51.gxTpr_Sys_instituteuserroleinstitutecode_Z;
         Z435SYS_InstituteUserRoleUserID = (Guid)(obj51.gxTpr_Sys_instituteuserroleuserid_Z);
         Gx_mode = obj51.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A363SYS_InstituteUserRoleUserRoleID = (Guid)((Guid)getParm(obj,0));
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey1E51( ) ;
         ScanKeyStart1E51( ) ;
         if ( RcdFound51 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z363SYS_InstituteUserRoleUserRoleID = (Guid)(A363SYS_InstituteUserRoleUserRoleID);
         }
         ZM1E51( -7) ;
         OnLoadActions1E51( ) ;
         AddRow1E51( ) ;
         ScanKeyEnd1E51( ) ;
         if ( RcdFound51 == 0 )
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
         RowToVars51( bcSYS_InstituteUserRole, 0) ;
         ScanKeyStart1E51( ) ;
         if ( RcdFound51 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z363SYS_InstituteUserRoleUserRoleID = (Guid)(A363SYS_InstituteUserRoleUserRoleID);
         }
         ZM1E51( -7) ;
         OnLoadActions1E51( ) ;
         AddRow1E51( ) ;
         ScanKeyEnd1E51( ) ;
         if ( RcdFound51 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey1E51( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert1E51( ) ;
         }
         else
         {
            if ( RcdFound51 == 1 )
            {
               if ( A363SYS_InstituteUserRoleUserRoleID != Z363SYS_InstituteUserRoleUserRoleID )
               {
                  A363SYS_InstituteUserRoleUserRoleID = (Guid)(Z363SYS_InstituteUserRoleUserRoleID);
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
                  Update1E51( ) ;
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
                  if ( A363SYS_InstituteUserRoleUserRoleID != Z363SYS_InstituteUserRoleUserRoleID )
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
                        Insert1E51( ) ;
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
                        Insert1E51( ) ;
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
         RowToVars51( bcSYS_InstituteUserRole, 0) ;
         SaveImpl( ) ;
         VarsToRow51( bcSYS_InstituteUserRole) ;
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
         RowToVars51( bcSYS_InstituteUserRole, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert1E51( ) ;
         AfterTrn( ) ;
         VarsToRow51( bcSYS_InstituteUserRole) ;
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
            SdtSYS_InstituteUserRole auxBC = new SdtSYS_InstituteUserRole(context) ;
            auxBC.Load(A363SYS_InstituteUserRoleUserRoleID);
            auxBC.UpdateDirties(bcSYS_InstituteUserRole);
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
         RowToVars51( bcSYS_InstituteUserRole, 0) ;
         UpdateImpl( ) ;
         VarsToRow51( bcSYS_InstituteUserRole) ;
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
         RowToVars51( bcSYS_InstituteUserRole, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert1E51( ) ;
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
         VarsToRow51( bcSYS_InstituteUserRole) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars51( bcSYS_InstituteUserRole, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey1E51( ) ;
         if ( RcdFound51 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A363SYS_InstituteUserRoleUserRoleID != Z363SYS_InstituteUserRoleUserRoleID )
            {
               A363SYS_InstituteUserRoleUserRoleID = (Guid)(Z363SYS_InstituteUserRoleUserRoleID);
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
            if ( A363SYS_InstituteUserRoleUserRoleID != Z363SYS_InstituteUserRoleUserRoleID )
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
         pr_datastore1.close(1);
         context.RollbackDataStores("sys_instituteuserrole_bc",pr_default);
         VarsToRow51( bcSYS_InstituteUserRole) ;
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
         Gx_mode = bcSYS_InstituteUserRole.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcSYS_InstituteUserRole.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcSYS_InstituteUserRole )
         {
            bcSYS_InstituteUserRole = (SdtSYS_InstituteUserRole)(sdt);
            if ( StringUtil.StrCmp(bcSYS_InstituteUserRole.gxTpr_Mode, "") == 0 )
            {
               bcSYS_InstituteUserRole.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow51( bcSYS_InstituteUserRole) ;
            }
            else
            {
               RowToVars51( bcSYS_InstituteUserRole, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcSYS_InstituteUserRole.gxTpr_Mode, "") == 0 )
            {
               bcSYS_InstituteUserRole.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars51( bcSYS_InstituteUserRole, 1) ;
         return  ;
      }

      public SdtSYS_InstituteUserRole SYS_InstituteUserRole_BC
      {
         get {
            return bcSYS_InstituteUserRole ;
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
         pr_datastore1.close(1);
      }

      public override void initialize( )
      {
         scmdbuf = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Gx_mode = "";
         Z363SYS_InstituteUserRoleUserRoleID = (Guid)(Guid.Empty);
         A363SYS_InstituteUserRoleUserRoleID = (Guid)(Guid.Empty);
         Z435SYS_InstituteUserRoleUserID = (Guid)(Guid.Empty);
         A435SYS_InstituteUserRoleUserID = (Guid)(Guid.Empty);
         Z436SYS_InstituteUserRoleRoleID = (Guid)(Guid.Empty);
         A436SYS_InstituteUserRoleRoleID = (Guid)(Guid.Empty);
         Z443SYS_InstituteUserRoleInstituteCode = "";
         A443SYS_InstituteUserRoleInstituteCode = "";
         BC001E4_A363SYS_InstituteUserRoleUserRoleID = new Guid[] {Guid.Empty} ;
         BC001E4_A435SYS_InstituteUserRoleUserID = new Guid[] {Guid.Empty} ;
         BC001E4_A436SYS_InstituteUserRoleRoleID = new Guid[] {Guid.Empty} ;
         BC001E4_A443SYS_InstituteUserRoleInstituteCode = new String[] {""} ;
         BC001E5_A363SYS_InstituteUserRoleUserRoleID = new Guid[] {Guid.Empty} ;
         BC001E3_A363SYS_InstituteUserRoleUserRoleID = new Guid[] {Guid.Empty} ;
         BC001E3_A435SYS_InstituteUserRoleUserID = new Guid[] {Guid.Empty} ;
         BC001E3_A436SYS_InstituteUserRoleRoleID = new Guid[] {Guid.Empty} ;
         BC001E3_A443SYS_InstituteUserRoleInstituteCode = new String[] {""} ;
         sMode51 = "";
         BC001E2_A363SYS_InstituteUserRoleUserRoleID = new Guid[] {Guid.Empty} ;
         BC001E2_A435SYS_InstituteUserRoleUserID = new Guid[] {Guid.Empty} ;
         BC001E2_A436SYS_InstituteUserRoleRoleID = new Guid[] {Guid.Empty} ;
         BC001E2_A443SYS_InstituteUserRoleInstituteCode = new String[] {""} ;
         BC001E9_A363SYS_InstituteUserRoleUserRoleID = new Guid[] {Guid.Empty} ;
         BC001E9_A435SYS_InstituteUserRoleUserID = new Guid[] {Guid.Empty} ;
         BC001E9_A436SYS_InstituteUserRoleRoleID = new Guid[] {Guid.Empty} ;
         BC001E9_A443SYS_InstituteUserRoleInstituteCode = new String[] {""} ;
         i435SYS_InstituteUserRoleUserID = (Guid)(Guid.Empty);
         i436SYS_InstituteUserRoleRoleID = (Guid)(Guid.Empty);
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.sys_instituteuserrole_bc__datastore1(),
            new Object[][] {
                new Object[] {
               BC001E2_A363SYS_InstituteUserRoleUserRoleID, BC001E2_A435SYS_InstituteUserRoleUserID, BC001E2_A436SYS_InstituteUserRoleRoleID, BC001E2_A443SYS_InstituteUserRoleInstituteCode
               }
               , new Object[] {
               BC001E3_A363SYS_InstituteUserRoleUserRoleID, BC001E3_A435SYS_InstituteUserRoleUserID, BC001E3_A436SYS_InstituteUserRoleRoleID, BC001E3_A443SYS_InstituteUserRoleInstituteCode
               }
               , new Object[] {
               BC001E4_A363SYS_InstituteUserRoleUserRoleID, BC001E4_A435SYS_InstituteUserRoleUserID, BC001E4_A436SYS_InstituteUserRoleRoleID, BC001E4_A443SYS_InstituteUserRoleInstituteCode
               }
               , new Object[] {
               BC001E5_A363SYS_InstituteUserRoleUserRoleID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC001E9_A363SYS_InstituteUserRoleUserRoleID, BC001E9_A435SYS_InstituteUserRoleUserID, BC001E9_A436SYS_InstituteUserRoleRoleID, BC001E9_A443SYS_InstituteUserRoleInstituteCode
               }
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.sys_instituteuserrole_bc__default(),
            new Object[][] {
            }
         );
         Z435SYS_InstituteUserRoleUserID = (Guid)(Guid.NewGuid( ));
         A435SYS_InstituteUserRoleUserID = (Guid)(Guid.NewGuid( ));
         i435SYS_InstituteUserRoleUserID = (Guid)(Guid.NewGuid( ));
         Z436SYS_InstituteUserRoleRoleID = (Guid)(Guid.NewGuid( ));
         A436SYS_InstituteUserRoleRoleID = (Guid)(Guid.NewGuid( ));
         i436SYS_InstituteUserRoleRoleID = (Guid)(Guid.NewGuid( ));
         Z363SYS_InstituteUserRoleUserRoleID = (Guid)(Guid.NewGuid( ));
         A363SYS_InstituteUserRoleUserRoleID = (Guid)(Guid.NewGuid( ));
         INITTRN();
         /* Execute Start event if defined. */
         standaloneNotModal( ) ;
      }

      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short RcdFound51 ;
      private int trnEnded ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String sMode51 ;
      private String Z443SYS_InstituteUserRoleInstituteCode ;
      private String A443SYS_InstituteUserRoleInstituteCode ;
      private Guid Z363SYS_InstituteUserRoleUserRoleID ;
      private Guid A363SYS_InstituteUserRoleUserRoleID ;
      private Guid Z435SYS_InstituteUserRoleUserID ;
      private Guid A435SYS_InstituteUserRoleUserID ;
      private Guid Z436SYS_InstituteUserRoleRoleID ;
      private Guid A436SYS_InstituteUserRoleRoleID ;
      private Guid i435SYS_InstituteUserRoleUserID ;
      private Guid i436SYS_InstituteUserRoleRoleID ;
      private SdtSYS_InstituteUserRole bcSYS_InstituteUserRole ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_datastore1 ;
      private Guid[] BC001E4_A363SYS_InstituteUserRoleUserRoleID ;
      private Guid[] BC001E4_A435SYS_InstituteUserRoleUserID ;
      private Guid[] BC001E4_A436SYS_InstituteUserRoleRoleID ;
      private String[] BC001E4_A443SYS_InstituteUserRoleInstituteCode ;
      private Guid[] BC001E5_A363SYS_InstituteUserRoleUserRoleID ;
      private Guid[] BC001E3_A363SYS_InstituteUserRoleUserRoleID ;
      private Guid[] BC001E3_A435SYS_InstituteUserRoleUserID ;
      private Guid[] BC001E3_A436SYS_InstituteUserRoleRoleID ;
      private String[] BC001E3_A443SYS_InstituteUserRoleInstituteCode ;
      private Guid[] BC001E2_A363SYS_InstituteUserRoleUserRoleID ;
      private Guid[] BC001E2_A435SYS_InstituteUserRoleUserID ;
      private Guid[] BC001E2_A436SYS_InstituteUserRoleRoleID ;
      private String[] BC001E2_A443SYS_InstituteUserRoleInstituteCode ;
      private Guid[] BC001E9_A363SYS_InstituteUserRoleUserRoleID ;
      private Guid[] BC001E9_A435SYS_InstituteUserRoleUserID ;
      private Guid[] BC001E9_A436SYS_InstituteUserRoleRoleID ;
      private String[] BC001E9_A443SYS_InstituteUserRoleInstituteCode ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_default ;
   }

   public class sys_instituteuserrole_bc__datastore1 : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
         ,new UpdateCursor(def[4])
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
          Object[] prmBC001E4 ;
          prmBC001E4 = new Object[] {
          new Object[] {"@SYS_InstituteUserRoleUserRoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC001E5 ;
          prmBC001E5 = new Object[] {
          new Object[] {"@SYS_InstituteUserRoleUserRoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC001E3 ;
          prmBC001E3 = new Object[] {
          new Object[] {"@SYS_InstituteUserRoleUserRoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC001E2 ;
          prmBC001E2 = new Object[] {
          new Object[] {"@SYS_InstituteUserRoleUserRoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC001E6 ;
          prmBC001E6 = new Object[] {
          new Object[] {"@SYS_InstituteUserRoleInstituteCode",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@SYS_InstituteUserRoleUserRoleID",SqlDbType.UniqueIdentifier,16,0} ,
          new Object[] {"@SYS_InstituteUserRoleUserID",SqlDbType.UniqueIdentifier,16,0} ,
          new Object[] {"@SYS_InstituteUserRoleRoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC001E7 ;
          prmBC001E7 = new Object[] {
          new Object[] {"@SYS_InstituteUserRoleUserID",SqlDbType.UniqueIdentifier,16,0} ,
          new Object[] {"@SYS_InstituteUserRoleRoleID",SqlDbType.UniqueIdentifier,16,0} ,
          new Object[] {"@SYS_InstituteUserRoleInstituteCode",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@SYS_InstituteUserRoleUserRoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC001E8 ;
          prmBC001E8 = new Object[] {
          new Object[] {"@SYS_InstituteUserRoleUserRoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          Object[] prmBC001E9 ;
          prmBC001E9 = new Object[] {
          new Object[] {"@SYS_InstituteUserRoleUserRoleID",SqlDbType.UniqueIdentifier,16,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("BC001E2", "SELECT [UserRoleID], [UserID], [RoleID], [InstituteCode] FROM [SYS_InstituteUserRole] WITH (UPDLOCK) WHERE [UserRoleID] = @SYS_InstituteUserRoleUserRoleID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001E2,1,0,true,false )
             ,new CursorDef("BC001E3", "SELECT [UserRoleID], [UserID], [RoleID], [InstituteCode] FROM [SYS_InstituteUserRole] WITH (NOLOCK) WHERE [UserRoleID] = @SYS_InstituteUserRoleUserRoleID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001E3,1,0,true,false )
             ,new CursorDef("BC001E4", "SELECT TM1.[UserRoleID], TM1.[UserID], TM1.[RoleID], TM1.[InstituteCode] FROM [SYS_InstituteUserRole] TM1 WITH (NOLOCK) WHERE TM1.[UserRoleID] = @SYS_InstituteUserRoleUserRoleID ORDER BY TM1.[UserRoleID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001E4,100,0,true,false )
             ,new CursorDef("BC001E5", "SELECT [UserRoleID] FROM [SYS_InstituteUserRole] WITH (NOLOCK) WHERE [UserRoleID] = @SYS_InstituteUserRoleUserRoleID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001E5,1,0,true,false )
             ,new CursorDef("BC001E6", "INSERT INTO [SYS_InstituteUserRole]([InstituteCode], [UserRoleID], [UserID], [RoleID]) VALUES(@SYS_InstituteUserRoleInstituteCode, @SYS_InstituteUserRoleUserRoleID, @SYS_InstituteUserRoleUserID, @SYS_InstituteUserRoleRoleID)", GxErrorMask.GX_NOMASK,prmBC001E6)
             ,new CursorDef("BC001E7", "UPDATE [SYS_InstituteUserRole] SET [UserID]=@SYS_InstituteUserRoleUserID, [RoleID]=@SYS_InstituteUserRoleRoleID, [InstituteCode]=@SYS_InstituteUserRoleInstituteCode  WHERE [UserRoleID] = @SYS_InstituteUserRoleUserRoleID", GxErrorMask.GX_NOMASK,prmBC001E7)
             ,new CursorDef("BC001E8", "DELETE FROM [SYS_InstituteUserRole]  WHERE [UserRoleID] = @SYS_InstituteUserRoleUserRoleID", GxErrorMask.GX_NOMASK,prmBC001E8)
             ,new CursorDef("BC001E9", "SELECT TM1.[UserRoleID], TM1.[UserID], TM1.[RoleID], TM1.[InstituteCode] FROM [SYS_InstituteUserRole] TM1 WITH (NOLOCK) WHERE TM1.[UserRoleID] = @SYS_InstituteUserRoleUserRoleID ORDER BY TM1.[UserRoleID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001E9,100,0,true,false )
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
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                ((Guid[]) buf[1])[0] = rslt.getGuid(2) ;
                ((Guid[]) buf[2])[0] = rslt.getGuid(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                return;
             case 1 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                ((Guid[]) buf[1])[0] = rslt.getGuid(2) ;
                ((Guid[]) buf[2])[0] = rslt.getGuid(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                return;
             case 2 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                ((Guid[]) buf[1])[0] = rslt.getGuid(2) ;
                ((Guid[]) buf[2])[0] = rslt.getGuid(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                return;
             case 3 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                return;
             case 7 :
                ((Guid[]) buf[0])[0] = rslt.getGuid(1) ;
                ((Guid[]) buf[1])[0] = rslt.getGuid(2) ;
                ((Guid[]) buf[2])[0] = rslt.getGuid(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
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
                stmt.SetParameter(1, (Guid)parms[0]);
                return;
             case 1 :
                stmt.SetParameter(1, (Guid)parms[0]);
                return;
             case 2 :
                stmt.SetParameter(1, (Guid)parms[0]);
                return;
             case 3 :
                stmt.SetParameter(1, (Guid)parms[0]);
                return;
             case 4 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (Guid)parms[1]);
                stmt.SetParameter(3, (Guid)parms[2]);
                stmt.SetParameter(4, (Guid)parms[3]);
                return;
             case 5 :
                stmt.SetParameter(1, (Guid)parms[0]);
                stmt.SetParameter(2, (Guid)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (Guid)parms[3]);
                return;
             case 6 :
                stmt.SetParameter(1, (Guid)parms[0]);
                return;
             case 7 :
                stmt.SetParameter(1, (Guid)parms[0]);
                return;
       }
    }

    public String getDataStoreName( )
    {
       return "DATASTORE1";
    }

 }

 public class sys_instituteuserrole_bc__default : DataStoreHelperBase, IDataStoreHelper
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

}

}
