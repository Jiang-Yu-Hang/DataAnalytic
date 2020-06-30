/*
               File: SYS_Database_BC
        Description: SYS_Database
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:38:54.66
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
   public class sys_database_bc : GXHttpHandler, IGxSilentTrn
   {
      public sys_database_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public sys_database_bc( IGxContext context )
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
         ReadRow1B48( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey1B48( ) ;
         standaloneModal( ) ;
         AddRow1B48( ) ;
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
               Z365DatabaseID = A365DatabaseID;
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

      protected void CONFIRM_1B0( )
      {
         BeforeValidate1B48( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls1B48( ) ;
            }
            else
            {
               CheckExtendedTable1B48( ) ;
               if ( AnyError == 0 )
               {
               }
               CloseExtendedTableCursors1B48( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void ZM1B48( short GX_JID )
      {
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            Z380DatabaseName = A380DatabaseName;
            Z381ConnectionString = A381ConnectionString;
            Z382SYS_DatabaseCreator = A382SYS_DatabaseCreator;
            Z383SYS_DatabaseCreateTime = A383SYS_DatabaseCreateTime;
            Z384SYS_DatabaseModifier = A384SYS_DatabaseModifier;
            Z385SYS_DatabaseModifyTime = A385SYS_DatabaseModifyTime;
         }
         if ( GX_JID == -3 )
         {
            Z365DatabaseID = A365DatabaseID;
            Z380DatabaseName = A380DatabaseName;
            Z381ConnectionString = A381ConnectionString;
            Z382SYS_DatabaseCreator = A382SYS_DatabaseCreator;
            Z383SYS_DatabaseCreateTime = A383SYS_DatabaseCreateTime;
            Z384SYS_DatabaseModifier = A384SYS_DatabaseModifier;
            Z385SYS_DatabaseModifyTime = A385SYS_DatabaseModifyTime;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load1B48( )
      {
         /* Using cursor BC001B4 */
         pr_datastore1.execute(2, new Object[] {A365DatabaseID});
         if ( (pr_datastore1.getStatus(2) != 101) )
         {
            RcdFound48 = 1;
            A380DatabaseName = BC001B4_A380DatabaseName[0];
            A381ConnectionString = BC001B4_A381ConnectionString[0];
            A382SYS_DatabaseCreator = BC001B4_A382SYS_DatabaseCreator[0];
            A383SYS_DatabaseCreateTime = BC001B4_A383SYS_DatabaseCreateTime[0];
            A384SYS_DatabaseModifier = BC001B4_A384SYS_DatabaseModifier[0];
            n384SYS_DatabaseModifier = BC001B4_n384SYS_DatabaseModifier[0];
            A385SYS_DatabaseModifyTime = BC001B4_A385SYS_DatabaseModifyTime[0];
            n385SYS_DatabaseModifyTime = BC001B4_n385SYS_DatabaseModifyTime[0];
            ZM1B48( -3) ;
         }
         pr_datastore1.close(2);
         OnLoadActions1B48( ) ;
      }

      protected void OnLoadActions1B48( )
      {
      }

      protected void CheckExtendedTable1B48( )
      {
         standaloneModal( ) ;
         if ( ! ( (DateTime.MinValue==A383SYS_DatabaseCreateTime) || ( A383SYS_DatabaseCreateTime >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("域SYS_Database Create Time超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
         if ( ! ( (DateTime.MinValue==A385SYS_DatabaseModifyTime) || ( A385SYS_DatabaseModifyTime >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("域SYS_Database Modify Time超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
      }

      protected void CloseExtendedTableCursors1B48( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey1B48( )
      {
         /* Using cursor BC001B5 */
         pr_datastore1.execute(3, new Object[] {A365DatabaseID});
         if ( (pr_datastore1.getStatus(3) != 101) )
         {
            RcdFound48 = 1;
         }
         else
         {
            RcdFound48 = 0;
         }
         pr_datastore1.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC001B3 */
         pr_datastore1.execute(1, new Object[] {A365DatabaseID});
         if ( (pr_datastore1.getStatus(1) != 101) )
         {
            ZM1B48( 3) ;
            RcdFound48 = 1;
            A365DatabaseID = BC001B3_A365DatabaseID[0];
            A380DatabaseName = BC001B3_A380DatabaseName[0];
            A381ConnectionString = BC001B3_A381ConnectionString[0];
            A382SYS_DatabaseCreator = BC001B3_A382SYS_DatabaseCreator[0];
            A383SYS_DatabaseCreateTime = BC001B3_A383SYS_DatabaseCreateTime[0];
            A384SYS_DatabaseModifier = BC001B3_A384SYS_DatabaseModifier[0];
            n384SYS_DatabaseModifier = BC001B3_n384SYS_DatabaseModifier[0];
            A385SYS_DatabaseModifyTime = BC001B3_A385SYS_DatabaseModifyTime[0];
            n385SYS_DatabaseModifyTime = BC001B3_n385SYS_DatabaseModifyTime[0];
            Z365DatabaseID = A365DatabaseID;
            sMode48 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load1B48( ) ;
            if ( AnyError == 1 )
            {
               RcdFound48 = 0;
               InitializeNonKey1B48( ) ;
            }
            Gx_mode = sMode48;
         }
         else
         {
            RcdFound48 = 0;
            InitializeNonKey1B48( ) ;
            sMode48 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode48;
         }
         pr_datastore1.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1B48( ) ;
         if ( RcdFound48 == 0 )
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
         CONFIRM_1B0( ) ;
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

      protected void CheckOptimisticConcurrency1B48( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC001B2 */
            pr_datastore1.execute(0, new Object[] {A365DatabaseID});
            if ( (pr_datastore1.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SYS_DATABASE"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_datastore1.getStatus(0) == 101) || ( StringUtil.StrCmp(Z380DatabaseName, BC001B2_A380DatabaseName[0]) != 0 ) || ( StringUtil.StrCmp(Z381ConnectionString, BC001B2_A381ConnectionString[0]) != 0 ) || ( StringUtil.StrCmp(Z382SYS_DatabaseCreator, BC001B2_A382SYS_DatabaseCreator[0]) != 0 ) || ( Z383SYS_DatabaseCreateTime != BC001B2_A383SYS_DatabaseCreateTime[0] ) || ( StringUtil.StrCmp(Z384SYS_DatabaseModifier, BC001B2_A384SYS_DatabaseModifier[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z385SYS_DatabaseModifyTime != BC001B2_A385SYS_DatabaseModifyTime[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"SYS_DATABASE"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert1B48( )
      {
         BeforeValidate1B48( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1B48( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1B48( 0) ;
            CheckOptimisticConcurrency1B48( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1B48( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1B48( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC001B6 */
                     pr_datastore1.execute(4, new Object[] {A365DatabaseID, A380DatabaseName, A381ConnectionString, A382SYS_DatabaseCreator, A383SYS_DatabaseCreateTime, n384SYS_DatabaseModifier, A384SYS_DatabaseModifier, n385SYS_DatabaseModifyTime, A385SYS_DatabaseModifyTime});
                     pr_datastore1.close(4);
                     dsDataStore1.SmartCacheProvider.SetUpdated("SYS_DATABASE") ;
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
               Load1B48( ) ;
            }
            EndLevel1B48( ) ;
         }
         CloseExtendedTableCursors1B48( ) ;
      }

      protected void Update1B48( )
      {
         BeforeValidate1B48( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1B48( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1B48( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1B48( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1B48( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC001B7 */
                     pr_datastore1.execute(5, new Object[] {A380DatabaseName, A381ConnectionString, A382SYS_DatabaseCreator, A383SYS_DatabaseCreateTime, n384SYS_DatabaseModifier, A384SYS_DatabaseModifier, n385SYS_DatabaseModifyTime, A385SYS_DatabaseModifyTime, A365DatabaseID});
                     pr_datastore1.close(5);
                     dsDataStore1.SmartCacheProvider.SetUpdated("SYS_DATABASE") ;
                     if ( (pr_datastore1.getStatus(5) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SYS_DATABASE"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate1B48( ) ;
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
            EndLevel1B48( ) ;
         }
         CloseExtendedTableCursors1B48( ) ;
      }

      protected void DeferredUpdate1B48( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate1B48( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1B48( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1B48( ) ;
            AfterConfirm1B48( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1B48( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC001B8 */
                  pr_datastore1.execute(6, new Object[] {A365DatabaseID});
                  pr_datastore1.close(6);
                  dsDataStore1.SmartCacheProvider.SetUpdated("SYS_DATABASE") ;
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
         sMode48 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel1B48( ) ;
         Gx_mode = sMode48;
      }

      protected void OnDeleteControls1B48( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor BC001B9 */
            pr_datastore1.execute(7, new Object[] {A365DatabaseID});
            if ( (pr_datastore1.getStatus(7) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"BAS_Tenant"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_datastore1.close(7);
         }
      }

      protected void EndLevel1B48( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_datastore1.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1B48( ) ;
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

      public void ScanKeyStart1B48( )
      {
         /* Using cursor BC001B10 */
         pr_datastore1.execute(8, new Object[] {A365DatabaseID});
         RcdFound48 = 0;
         if ( (pr_datastore1.getStatus(8) != 101) )
         {
            RcdFound48 = 1;
            A365DatabaseID = BC001B10_A365DatabaseID[0];
            A380DatabaseName = BC001B10_A380DatabaseName[0];
            A381ConnectionString = BC001B10_A381ConnectionString[0];
            A382SYS_DatabaseCreator = BC001B10_A382SYS_DatabaseCreator[0];
            A383SYS_DatabaseCreateTime = BC001B10_A383SYS_DatabaseCreateTime[0];
            A384SYS_DatabaseModifier = BC001B10_A384SYS_DatabaseModifier[0];
            n384SYS_DatabaseModifier = BC001B10_n384SYS_DatabaseModifier[0];
            A385SYS_DatabaseModifyTime = BC001B10_A385SYS_DatabaseModifyTime[0];
            n385SYS_DatabaseModifyTime = BC001B10_n385SYS_DatabaseModifyTime[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext1B48( )
      {
         /* Scan next routine */
         pr_datastore1.readNext(8);
         RcdFound48 = 0;
         ScanKeyLoad1B48( ) ;
      }

      protected void ScanKeyLoad1B48( )
      {
         sMode48 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_datastore1.getStatus(8) != 101) )
         {
            RcdFound48 = 1;
            A365DatabaseID = BC001B10_A365DatabaseID[0];
            A380DatabaseName = BC001B10_A380DatabaseName[0];
            A381ConnectionString = BC001B10_A381ConnectionString[0];
            A382SYS_DatabaseCreator = BC001B10_A382SYS_DatabaseCreator[0];
            A383SYS_DatabaseCreateTime = BC001B10_A383SYS_DatabaseCreateTime[0];
            A384SYS_DatabaseModifier = BC001B10_A384SYS_DatabaseModifier[0];
            n384SYS_DatabaseModifier = BC001B10_n384SYS_DatabaseModifier[0];
            A385SYS_DatabaseModifyTime = BC001B10_A385SYS_DatabaseModifyTime[0];
            n385SYS_DatabaseModifyTime = BC001B10_n385SYS_DatabaseModifyTime[0];
         }
         Gx_mode = sMode48;
      }

      protected void ScanKeyEnd1B48( )
      {
         pr_datastore1.close(8);
      }

      protected void AfterConfirm1B48( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1B48( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1B48( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1B48( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1B48( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1B48( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1B48( )
      {
      }

      protected void send_integrity_lvl_hashes1B48( )
      {
      }

      protected void AddRow1B48( )
      {
         VarsToRow48( bcSYS_Database) ;
      }

      protected void ReadRow1B48( )
      {
         RowToVars48( bcSYS_Database, 1) ;
      }

      protected void InitializeNonKey1B48( )
      {
         A380DatabaseName = "";
         A381ConnectionString = "";
         A382SYS_DatabaseCreator = "";
         A383SYS_DatabaseCreateTime = (DateTime)(DateTime.MinValue);
         A384SYS_DatabaseModifier = "";
         n384SYS_DatabaseModifier = false;
         A385SYS_DatabaseModifyTime = (DateTime)(DateTime.MinValue);
         n385SYS_DatabaseModifyTime = false;
         Z380DatabaseName = "";
         Z381ConnectionString = "";
         Z382SYS_DatabaseCreator = "";
         Z383SYS_DatabaseCreateTime = (DateTime)(DateTime.MinValue);
         Z384SYS_DatabaseModifier = "";
         Z385SYS_DatabaseModifyTime = (DateTime)(DateTime.MinValue);
      }

      protected void InitAll1B48( )
      {
         A365DatabaseID = 0;
         InitializeNonKey1B48( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow48( SdtSYS_Database obj48 )
      {
         obj48.gxTpr_Mode = Gx_mode;
         obj48.gxTpr_Databasename = A380DatabaseName;
         obj48.gxTpr_Connectionstring = A381ConnectionString;
         obj48.gxTpr_Sys_databasecreator = A382SYS_DatabaseCreator;
         obj48.gxTpr_Sys_databasecreatetime = A383SYS_DatabaseCreateTime;
         obj48.gxTpr_Sys_databasemodifier = A384SYS_DatabaseModifier;
         obj48.gxTpr_Sys_databasemodifytime = A385SYS_DatabaseModifyTime;
         obj48.gxTpr_Databaseid = A365DatabaseID;
         obj48.gxTpr_Databaseid_Z = Z365DatabaseID;
         obj48.gxTpr_Databasename_Z = Z380DatabaseName;
         obj48.gxTpr_Connectionstring_Z = Z381ConnectionString;
         obj48.gxTpr_Sys_databasecreator_Z = Z382SYS_DatabaseCreator;
         obj48.gxTpr_Sys_databasecreatetime_Z = Z383SYS_DatabaseCreateTime;
         obj48.gxTpr_Sys_databasemodifier_Z = Z384SYS_DatabaseModifier;
         obj48.gxTpr_Sys_databasemodifytime_Z = Z385SYS_DatabaseModifyTime;
         obj48.gxTpr_Sys_databasemodifier_N = (short)(Convert.ToInt16(n384SYS_DatabaseModifier));
         obj48.gxTpr_Sys_databasemodifytime_N = (short)(Convert.ToInt16(n385SYS_DatabaseModifyTime));
         obj48.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow48( SdtSYS_Database obj48 )
      {
         obj48.gxTpr_Databaseid = A365DatabaseID;
         return  ;
      }

      public void RowToVars48( SdtSYS_Database obj48 ,
                               int forceLoad )
      {
         Gx_mode = obj48.gxTpr_Mode;
         A380DatabaseName = obj48.gxTpr_Databasename;
         A381ConnectionString = obj48.gxTpr_Connectionstring;
         A382SYS_DatabaseCreator = obj48.gxTpr_Sys_databasecreator;
         A383SYS_DatabaseCreateTime = obj48.gxTpr_Sys_databasecreatetime;
         A384SYS_DatabaseModifier = obj48.gxTpr_Sys_databasemodifier;
         n384SYS_DatabaseModifier = false;
         A385SYS_DatabaseModifyTime = obj48.gxTpr_Sys_databasemodifytime;
         n385SYS_DatabaseModifyTime = false;
         A365DatabaseID = obj48.gxTpr_Databaseid;
         Z365DatabaseID = obj48.gxTpr_Databaseid_Z;
         Z380DatabaseName = obj48.gxTpr_Databasename_Z;
         Z381ConnectionString = obj48.gxTpr_Connectionstring_Z;
         Z382SYS_DatabaseCreator = obj48.gxTpr_Sys_databasecreator_Z;
         Z383SYS_DatabaseCreateTime = obj48.gxTpr_Sys_databasecreatetime_Z;
         Z384SYS_DatabaseModifier = obj48.gxTpr_Sys_databasemodifier_Z;
         Z385SYS_DatabaseModifyTime = obj48.gxTpr_Sys_databasemodifytime_Z;
         n384SYS_DatabaseModifier = (bool)(Convert.ToBoolean(obj48.gxTpr_Sys_databasemodifier_N));
         n385SYS_DatabaseModifyTime = (bool)(Convert.ToBoolean(obj48.gxTpr_Sys_databasemodifytime_N));
         Gx_mode = obj48.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A365DatabaseID = (int)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey1B48( ) ;
         ScanKeyStart1B48( ) ;
         if ( RcdFound48 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z365DatabaseID = A365DatabaseID;
         }
         ZM1B48( -3) ;
         OnLoadActions1B48( ) ;
         AddRow1B48( ) ;
         ScanKeyEnd1B48( ) ;
         if ( RcdFound48 == 0 )
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
         RowToVars48( bcSYS_Database, 0) ;
         ScanKeyStart1B48( ) ;
         if ( RcdFound48 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z365DatabaseID = A365DatabaseID;
         }
         ZM1B48( -3) ;
         OnLoadActions1B48( ) ;
         AddRow1B48( ) ;
         ScanKeyEnd1B48( ) ;
         if ( RcdFound48 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey1B48( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert1B48( ) ;
         }
         else
         {
            if ( RcdFound48 == 1 )
            {
               if ( A365DatabaseID != Z365DatabaseID )
               {
                  A365DatabaseID = Z365DatabaseID;
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
                  Update1B48( ) ;
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
                  if ( A365DatabaseID != Z365DatabaseID )
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
                        Insert1B48( ) ;
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
                        Insert1B48( ) ;
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
         RowToVars48( bcSYS_Database, 0) ;
         SaveImpl( ) ;
         VarsToRow48( bcSYS_Database) ;
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
         RowToVars48( bcSYS_Database, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert1B48( ) ;
         AfterTrn( ) ;
         VarsToRow48( bcSYS_Database) ;
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
            SdtSYS_Database auxBC = new SdtSYS_Database(context) ;
            auxBC.Load(A365DatabaseID);
            auxBC.UpdateDirties(bcSYS_Database);
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
         RowToVars48( bcSYS_Database, 0) ;
         UpdateImpl( ) ;
         VarsToRow48( bcSYS_Database) ;
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
         RowToVars48( bcSYS_Database, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert1B48( ) ;
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
         VarsToRow48( bcSYS_Database) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars48( bcSYS_Database, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey1B48( ) ;
         if ( RcdFound48 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A365DatabaseID != Z365DatabaseID )
            {
               A365DatabaseID = Z365DatabaseID;
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
            if ( A365DatabaseID != Z365DatabaseID )
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
         context.RollbackDataStores("sys_database_bc",pr_default);
         VarsToRow48( bcSYS_Database) ;
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
         Gx_mode = bcSYS_Database.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcSYS_Database.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcSYS_Database )
         {
            bcSYS_Database = (SdtSYS_Database)(sdt);
            if ( StringUtil.StrCmp(bcSYS_Database.gxTpr_Mode, "") == 0 )
            {
               bcSYS_Database.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow48( bcSYS_Database) ;
            }
            else
            {
               RowToVars48( bcSYS_Database, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcSYS_Database.gxTpr_Mode, "") == 0 )
            {
               bcSYS_Database.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars48( bcSYS_Database, 1) ;
         return  ;
      }

      public SdtSYS_Database SYS_Database_BC
      {
         get {
            return bcSYS_Database ;
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
         Z380DatabaseName = "";
         A380DatabaseName = "";
         Z381ConnectionString = "";
         A381ConnectionString = "";
         Z382SYS_DatabaseCreator = "";
         A382SYS_DatabaseCreator = "";
         Z383SYS_DatabaseCreateTime = (DateTime)(DateTime.MinValue);
         A383SYS_DatabaseCreateTime = (DateTime)(DateTime.MinValue);
         Z384SYS_DatabaseModifier = "";
         A384SYS_DatabaseModifier = "";
         Z385SYS_DatabaseModifyTime = (DateTime)(DateTime.MinValue);
         A385SYS_DatabaseModifyTime = (DateTime)(DateTime.MinValue);
         BC001B4_A365DatabaseID = new int[1] ;
         BC001B4_A380DatabaseName = new String[] {""} ;
         BC001B4_A381ConnectionString = new String[] {""} ;
         BC001B4_A382SYS_DatabaseCreator = new String[] {""} ;
         BC001B4_A383SYS_DatabaseCreateTime = new DateTime[] {DateTime.MinValue} ;
         BC001B4_A384SYS_DatabaseModifier = new String[] {""} ;
         BC001B4_n384SYS_DatabaseModifier = new bool[] {false} ;
         BC001B4_A385SYS_DatabaseModifyTime = new DateTime[] {DateTime.MinValue} ;
         BC001B4_n385SYS_DatabaseModifyTime = new bool[] {false} ;
         BC001B5_A365DatabaseID = new int[1] ;
         BC001B3_A365DatabaseID = new int[1] ;
         BC001B3_A380DatabaseName = new String[] {""} ;
         BC001B3_A381ConnectionString = new String[] {""} ;
         BC001B3_A382SYS_DatabaseCreator = new String[] {""} ;
         BC001B3_A383SYS_DatabaseCreateTime = new DateTime[] {DateTime.MinValue} ;
         BC001B3_A384SYS_DatabaseModifier = new String[] {""} ;
         BC001B3_n384SYS_DatabaseModifier = new bool[] {false} ;
         BC001B3_A385SYS_DatabaseModifyTime = new DateTime[] {DateTime.MinValue} ;
         BC001B3_n385SYS_DatabaseModifyTime = new bool[] {false} ;
         sMode48 = "";
         BC001B2_A365DatabaseID = new int[1] ;
         BC001B2_A380DatabaseName = new String[] {""} ;
         BC001B2_A381ConnectionString = new String[] {""} ;
         BC001B2_A382SYS_DatabaseCreator = new String[] {""} ;
         BC001B2_A383SYS_DatabaseCreateTime = new DateTime[] {DateTime.MinValue} ;
         BC001B2_A384SYS_DatabaseModifier = new String[] {""} ;
         BC001B2_n384SYS_DatabaseModifier = new bool[] {false} ;
         BC001B2_A385SYS_DatabaseModifyTime = new DateTime[] {DateTime.MinValue} ;
         BC001B2_n385SYS_DatabaseModifyTime = new bool[] {false} ;
         BC001B9_A360BAS_TenantTenantCode = new String[] {""} ;
         BC001B10_A365DatabaseID = new int[1] ;
         BC001B10_A380DatabaseName = new String[] {""} ;
         BC001B10_A381ConnectionString = new String[] {""} ;
         BC001B10_A382SYS_DatabaseCreator = new String[] {""} ;
         BC001B10_A383SYS_DatabaseCreateTime = new DateTime[] {DateTime.MinValue} ;
         BC001B10_A384SYS_DatabaseModifier = new String[] {""} ;
         BC001B10_n384SYS_DatabaseModifier = new bool[] {false} ;
         BC001B10_A385SYS_DatabaseModifyTime = new DateTime[] {DateTime.MinValue} ;
         BC001B10_n385SYS_DatabaseModifyTime = new bool[] {false} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.sys_database_bc__datastore1(),
            new Object[][] {
                new Object[] {
               BC001B2_A365DatabaseID, BC001B2_A380DatabaseName, BC001B2_A381ConnectionString, BC001B2_A382SYS_DatabaseCreator, BC001B2_A383SYS_DatabaseCreateTime, BC001B2_A384SYS_DatabaseModifier, BC001B2_n384SYS_DatabaseModifier, BC001B2_A385SYS_DatabaseModifyTime, BC001B2_n385SYS_DatabaseModifyTime
               }
               , new Object[] {
               BC001B3_A365DatabaseID, BC001B3_A380DatabaseName, BC001B3_A381ConnectionString, BC001B3_A382SYS_DatabaseCreator, BC001B3_A383SYS_DatabaseCreateTime, BC001B3_A384SYS_DatabaseModifier, BC001B3_n384SYS_DatabaseModifier, BC001B3_A385SYS_DatabaseModifyTime, BC001B3_n385SYS_DatabaseModifyTime
               }
               , new Object[] {
               BC001B4_A365DatabaseID, BC001B4_A380DatabaseName, BC001B4_A381ConnectionString, BC001B4_A382SYS_DatabaseCreator, BC001B4_A383SYS_DatabaseCreateTime, BC001B4_A384SYS_DatabaseModifier, BC001B4_n384SYS_DatabaseModifier, BC001B4_A385SYS_DatabaseModifyTime, BC001B4_n385SYS_DatabaseModifyTime
               }
               , new Object[] {
               BC001B5_A365DatabaseID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC001B9_A360BAS_TenantTenantCode
               }
               , new Object[] {
               BC001B10_A365DatabaseID, BC001B10_A380DatabaseName, BC001B10_A381ConnectionString, BC001B10_A382SYS_DatabaseCreator, BC001B10_A383SYS_DatabaseCreateTime, BC001B10_A384SYS_DatabaseModifier, BC001B10_n384SYS_DatabaseModifier, BC001B10_A385SYS_DatabaseModifyTime, BC001B10_n385SYS_DatabaseModifyTime
               }
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.sys_database_bc__default(),
            new Object[][] {
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
      private short RcdFound48 ;
      private int trnEnded ;
      private int Z365DatabaseID ;
      private int A365DatabaseID ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String sMode48 ;
      private DateTime Z383SYS_DatabaseCreateTime ;
      private DateTime A383SYS_DatabaseCreateTime ;
      private DateTime Z385SYS_DatabaseModifyTime ;
      private DateTime A385SYS_DatabaseModifyTime ;
      private bool n384SYS_DatabaseModifier ;
      private bool n385SYS_DatabaseModifyTime ;
      private bool Gx_longc ;
      private String Z380DatabaseName ;
      private String A380DatabaseName ;
      private String Z381ConnectionString ;
      private String A381ConnectionString ;
      private String Z382SYS_DatabaseCreator ;
      private String A382SYS_DatabaseCreator ;
      private String Z384SYS_DatabaseModifier ;
      private String A384SYS_DatabaseModifier ;
      private SdtSYS_Database bcSYS_Database ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_datastore1 ;
      private int[] BC001B4_A365DatabaseID ;
      private String[] BC001B4_A380DatabaseName ;
      private String[] BC001B4_A381ConnectionString ;
      private String[] BC001B4_A382SYS_DatabaseCreator ;
      private DateTime[] BC001B4_A383SYS_DatabaseCreateTime ;
      private String[] BC001B4_A384SYS_DatabaseModifier ;
      private bool[] BC001B4_n384SYS_DatabaseModifier ;
      private DateTime[] BC001B4_A385SYS_DatabaseModifyTime ;
      private bool[] BC001B4_n385SYS_DatabaseModifyTime ;
      private int[] BC001B5_A365DatabaseID ;
      private int[] BC001B3_A365DatabaseID ;
      private String[] BC001B3_A380DatabaseName ;
      private String[] BC001B3_A381ConnectionString ;
      private String[] BC001B3_A382SYS_DatabaseCreator ;
      private DateTime[] BC001B3_A383SYS_DatabaseCreateTime ;
      private String[] BC001B3_A384SYS_DatabaseModifier ;
      private bool[] BC001B3_n384SYS_DatabaseModifier ;
      private DateTime[] BC001B3_A385SYS_DatabaseModifyTime ;
      private bool[] BC001B3_n385SYS_DatabaseModifyTime ;
      private int[] BC001B2_A365DatabaseID ;
      private String[] BC001B2_A380DatabaseName ;
      private String[] BC001B2_A381ConnectionString ;
      private String[] BC001B2_A382SYS_DatabaseCreator ;
      private DateTime[] BC001B2_A383SYS_DatabaseCreateTime ;
      private String[] BC001B2_A384SYS_DatabaseModifier ;
      private bool[] BC001B2_n384SYS_DatabaseModifier ;
      private DateTime[] BC001B2_A385SYS_DatabaseModifyTime ;
      private bool[] BC001B2_n385SYS_DatabaseModifyTime ;
      private String[] BC001B9_A360BAS_TenantTenantCode ;
      private int[] BC001B10_A365DatabaseID ;
      private String[] BC001B10_A380DatabaseName ;
      private String[] BC001B10_A381ConnectionString ;
      private String[] BC001B10_A382SYS_DatabaseCreator ;
      private DateTime[] BC001B10_A383SYS_DatabaseCreateTime ;
      private String[] BC001B10_A384SYS_DatabaseModifier ;
      private bool[] BC001B10_n384SYS_DatabaseModifier ;
      private DateTime[] BC001B10_A385SYS_DatabaseModifyTime ;
      private bool[] BC001B10_n385SYS_DatabaseModifyTime ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_default ;
   }

   public class sys_database_bc__datastore1 : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[8])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmBC001B4 ;
          prmBC001B4 = new Object[] {
          new Object[] {"@DatabaseID",SqlDbType.Int,9,0}
          } ;
          Object[] prmBC001B5 ;
          prmBC001B5 = new Object[] {
          new Object[] {"@DatabaseID",SqlDbType.Int,9,0}
          } ;
          Object[] prmBC001B3 ;
          prmBC001B3 = new Object[] {
          new Object[] {"@DatabaseID",SqlDbType.Int,9,0}
          } ;
          Object[] prmBC001B2 ;
          prmBC001B2 = new Object[] {
          new Object[] {"@DatabaseID",SqlDbType.Int,9,0}
          } ;
          Object[] prmBC001B6 ;
          prmBC001B6 = new Object[] {
          new Object[] {"@DatabaseID",SqlDbType.Int,9,0} ,
          new Object[] {"@DatabaseName",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@ConnectionString",SqlDbType.NVarChar,200,0} ,
          new Object[] {"@SYS_DatabaseCreator",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@SYS_DatabaseCreateTime",SqlDbType.DateTime,10,8} ,
          new Object[] {"@SYS_DatabaseModifier",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@SYS_DatabaseModifyTime",SqlDbType.DateTime,10,8}
          } ;
          Object[] prmBC001B7 ;
          prmBC001B7 = new Object[] {
          new Object[] {"@DatabaseName",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@ConnectionString",SqlDbType.NVarChar,200,0} ,
          new Object[] {"@SYS_DatabaseCreator",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@SYS_DatabaseCreateTime",SqlDbType.DateTime,10,8} ,
          new Object[] {"@SYS_DatabaseModifier",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@SYS_DatabaseModifyTime",SqlDbType.DateTime,10,8} ,
          new Object[] {"@DatabaseID",SqlDbType.Int,9,0}
          } ;
          Object[] prmBC001B8 ;
          prmBC001B8 = new Object[] {
          new Object[] {"@DatabaseID",SqlDbType.Int,9,0}
          } ;
          Object[] prmBC001B9 ;
          prmBC001B9 = new Object[] {
          new Object[] {"@DatabaseID",SqlDbType.Int,9,0}
          } ;
          Object[] prmBC001B10 ;
          prmBC001B10 = new Object[] {
          new Object[] {"@DatabaseID",SqlDbType.Int,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("BC001B2", "SELECT [DatabaseID], [DatabaseName], [ConnectionString], [Creator] AS SYS_DatabaseCreator, [CreateTime] AS SYS_DatabaseCreateTime, [Modifier] AS SYS_DatabaseModifier, [ModifyTime] AS SYS_DatabaseModifyTime FROM dbo.[SYS_Database] WITH (UPDLOCK) WHERE [DatabaseID] = @DatabaseID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001B2,1,0,true,false )
             ,new CursorDef("BC001B3", "SELECT [DatabaseID], [DatabaseName], [ConnectionString], [Creator] AS SYS_DatabaseCreator, [CreateTime] AS SYS_DatabaseCreateTime, [Modifier] AS SYS_DatabaseModifier, [ModifyTime] AS SYS_DatabaseModifyTime FROM dbo.[SYS_Database] WITH (NOLOCK) WHERE [DatabaseID] = @DatabaseID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001B3,1,0,true,false )
             ,new CursorDef("BC001B4", "SELECT TM1.[DatabaseID], TM1.[DatabaseName], TM1.[ConnectionString], TM1.[Creator] AS SYS_DatabaseCreator, TM1.[CreateTime] AS SYS_DatabaseCreateTime, TM1.[Modifier] AS SYS_DatabaseModifier, TM1.[ModifyTime] AS SYS_DatabaseModifyTime FROM dbo.[SYS_Database] TM1 WITH (NOLOCK) WHERE TM1.[DatabaseID] = @DatabaseID ORDER BY TM1.[DatabaseID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001B4,100,0,true,false )
             ,new CursorDef("BC001B5", "SELECT [DatabaseID] FROM dbo.[SYS_Database] WITH (NOLOCK) WHERE [DatabaseID] = @DatabaseID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001B5,1,0,true,false )
             ,new CursorDef("BC001B6", "INSERT INTO dbo.[SYS_Database]([DatabaseID], [DatabaseName], [ConnectionString], [Creator], [CreateTime], [Modifier], [ModifyTime]) VALUES(@DatabaseID, @DatabaseName, @ConnectionString, @SYS_DatabaseCreator, @SYS_DatabaseCreateTime, @SYS_DatabaseModifier, @SYS_DatabaseModifyTime)", GxErrorMask.GX_NOMASK,prmBC001B6)
             ,new CursorDef("BC001B7", "UPDATE dbo.[SYS_Database] SET [DatabaseName]=@DatabaseName, [ConnectionString]=@ConnectionString, [Creator]=@SYS_DatabaseCreator, [CreateTime]=@SYS_DatabaseCreateTime, [Modifier]=@SYS_DatabaseModifier, [ModifyTime]=@SYS_DatabaseModifyTime  WHERE [DatabaseID] = @DatabaseID", GxErrorMask.GX_NOMASK,prmBC001B7)
             ,new CursorDef("BC001B8", "DELETE FROM dbo.[SYS_Database]  WHERE [DatabaseID] = @DatabaseID", GxErrorMask.GX_NOMASK,prmBC001B8)
             ,new CursorDef("BC001B9", "SELECT TOP 1 [TenantCode] FROM dbo.[BAS_Tenant] WITH (NOLOCK) WHERE [DatabaseID] = @DatabaseID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001B9,1,0,true,true )
             ,new CursorDef("BC001B10", "SELECT TM1.[DatabaseID], TM1.[DatabaseName], TM1.[ConnectionString], TM1.[Creator] AS SYS_DatabaseCreator, TM1.[CreateTime] AS SYS_DatabaseCreateTime, TM1.[Modifier] AS SYS_DatabaseModifier, TM1.[ModifyTime] AS SYS_DatabaseModifyTime FROM dbo.[SYS_Database] TM1 WITH (NOLOCK) WHERE TM1.[DatabaseID] = @DatabaseID ORDER BY TM1.[DatabaseID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001B10,100,0,true,false )
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
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((DateTime[]) buf[4])[0] = rslt.getGXDateTime(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[7])[0] = rslt.getGXDateTime(7) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(7);
                return;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((DateTime[]) buf[4])[0] = rslt.getGXDateTime(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[7])[0] = rslt.getGXDateTime(7) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(7);
                return;
             case 2 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((DateTime[]) buf[4])[0] = rslt.getGXDateTime(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[7])[0] = rslt.getGXDateTime(7) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(7);
                return;
             case 3 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                return;
             case 7 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                return;
             case 8 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((DateTime[]) buf[4])[0] = rslt.getGXDateTime(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[7])[0] = rslt.getGXDateTime(7) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(7);
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
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 1 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 2 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 3 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 4 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameterDatetime(5, (DateTime)parms[4]);
                if ( (bool)parms[5] )
                {
                   stmt.setNull( 6 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(6, (String)parms[6]);
                }
                if ( (bool)parms[7] )
                {
                   stmt.setNull( 7 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(7, (DateTime)parms[8]);
                }
                return;
             case 5 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameterDatetime(4, (DateTime)parms[3]);
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 5 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(5, (String)parms[5]);
                }
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 6 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameterDatetime(6, (DateTime)parms[7]);
                }
                stmt.SetParameter(7, (int)parms[8]);
                return;
             case 6 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 7 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
             case 8 :
                stmt.SetParameter(1, (int)parms[0]);
                return;
       }
    }

    public String getDataStoreName( )
    {
       return "DATASTORE1";
    }

 }

 public class sys_database_bc__default : DataStoreHelperBase, IDataStoreHelper
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
