/*
               File: WWPBaseObjects.SecUser_BC
        Description: 账号
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:6:26.15
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
   public class secuser_bc : GXHttpHandler, IGxSilentTrn
   {
      public secuser_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public secuser_bc( IGxContext context )
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
         ReadRow056( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey056( ) ;
         standaloneModal( ) ;
         AddRow056( ) ;
         Gx_mode = "INS";
         return  ;
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E11052 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               Z6SecUserId = A6SecUserId;
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

      protected void CONFIRM_050( )
      {
         BeforeValidate056( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls056( ) ;
            }
            else
            {
               CheckExtendedTable056( ) ;
               if ( AnyError == 0 )
               {
               }
               CloseExtendedTableCursors056( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void E12052( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV15WWPContext) ;
         AV9IsAuthorized = true;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWSecUser_Insert", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWSecUser_Update", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWSecUser_Delete", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
         }
         if ( ! AV9IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV17Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV11TrnContext.FromXml(AV12WebSession.Get("TrnContext"), null, "WWPTransactionContext", "DataAnalysisPlatform");
      }

      protected void E11052( )
      {
         /* After Trn Routine */
      }

      protected void ZM056( short GX_JID )
      {
         if ( ( GX_JID == 6 ) || ( GX_JID == 0 ) )
         {
            Z178SecUserCrtUser = A178SecUserCrtUser;
            Z180SecUserCrtDate = A180SecUserCrtDate;
            Z14SecUserName = A14SecUserName;
            Z15SecUserPassword = A15SecUserPassword;
            Z179SecUserUpdUser = A179SecUserUpdUser;
            Z181SecUserUpdDate = A181SecUserUpdDate;
            Z194SecUserWorkload = A194SecUserWorkload;
         }
         if ( GX_JID == -6 )
         {
            Z6SecUserId = A6SecUserId;
            Z178SecUserCrtUser = A178SecUserCrtUser;
            Z180SecUserCrtDate = A180SecUserCrtDate;
            Z14SecUserName = A14SecUserName;
            Z15SecUserPassword = A15SecUserPassword;
            Z179SecUserUpdUser = A179SecUserUpdUser;
            Z181SecUserUpdDate = A181SecUserUpdDate;
            Z194SecUserWorkload = A194SecUserWorkload;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load056( )
      {
         /* Using cursor BC00054 */
         pr_default.execute(2, new Object[] {A6SecUserId});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound6 = 1;
            A178SecUserCrtUser = BC00054_A178SecUserCrtUser[0];
            n178SecUserCrtUser = BC00054_n178SecUserCrtUser[0];
            A180SecUserCrtDate = BC00054_A180SecUserCrtDate[0];
            n180SecUserCrtDate = BC00054_n180SecUserCrtDate[0];
            A14SecUserName = BC00054_A14SecUserName[0];
            A15SecUserPassword = BC00054_A15SecUserPassword[0];
            A179SecUserUpdUser = BC00054_A179SecUserUpdUser[0];
            n179SecUserUpdUser = BC00054_n179SecUserUpdUser[0];
            A181SecUserUpdDate = BC00054_A181SecUserUpdDate[0];
            n181SecUserUpdDate = BC00054_n181SecUserUpdDate[0];
            A194SecUserWorkload = BC00054_A194SecUserWorkload[0];
            n194SecUserWorkload = BC00054_n194SecUserWorkload[0];
            ZM056( -6) ;
         }
         pr_default.close(2);
         OnLoadActions056( ) ;
      }

      protected void OnLoadActions056( )
      {
         AV17Pgmname = "WWPBaseObjects.SecUser_BC";
      }

      protected void CheckExtendedTable056( )
      {
         standaloneModal( ) ;
         AV17Pgmname = "WWPBaseObjects.SecUser_BC";
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A14SecUserName)) )
         {
            GX_msglist.addItem("姓名是必须填写的。", 1, "");
            AnyError = 1;
         }
         if ( ! ( (DateTime.MinValue==A180SecUserCrtDate) || ( A180SecUserCrtDate >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("域创建时间超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
         if ( ! ( (DateTime.MinValue==A181SecUserUpdDate) || ( A181SecUserUpdDate >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("域更新时间超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
      }

      protected void CloseExtendedTableCursors056( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey056( )
      {
         /* Using cursor BC00055 */
         pr_default.execute(3, new Object[] {A6SecUserId});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound6 = 1;
         }
         else
         {
            RcdFound6 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC00053 */
         pr_default.execute(1, new Object[] {A6SecUserId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM056( 6) ;
            RcdFound6 = 1;
            A6SecUserId = BC00053_A6SecUserId[0];
            A178SecUserCrtUser = BC00053_A178SecUserCrtUser[0];
            n178SecUserCrtUser = BC00053_n178SecUserCrtUser[0];
            A180SecUserCrtDate = BC00053_A180SecUserCrtDate[0];
            n180SecUserCrtDate = BC00053_n180SecUserCrtDate[0];
            A14SecUserName = BC00053_A14SecUserName[0];
            A15SecUserPassword = BC00053_A15SecUserPassword[0];
            A179SecUserUpdUser = BC00053_A179SecUserUpdUser[0];
            n179SecUserUpdUser = BC00053_n179SecUserUpdUser[0];
            A181SecUserUpdDate = BC00053_A181SecUserUpdDate[0];
            n181SecUserUpdDate = BC00053_n181SecUserUpdDate[0];
            A194SecUserWorkload = BC00053_A194SecUserWorkload[0];
            n194SecUserWorkload = BC00053_n194SecUserWorkload[0];
            Z6SecUserId = A6SecUserId;
            sMode6 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load056( ) ;
            if ( AnyError == 1 )
            {
               RcdFound6 = 0;
               InitializeNonKey056( ) ;
            }
            Gx_mode = sMode6;
         }
         else
         {
            RcdFound6 = 0;
            InitializeNonKey056( ) ;
            sMode6 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode6;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey056( ) ;
         if ( RcdFound6 == 0 )
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
         CONFIRM_050( ) ;
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

      protected void CheckOptimisticConcurrency056( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC00052 */
            pr_default.execute(0, new Object[] {A6SecUserId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SecUser"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z178SecUserCrtUser, BC00052_A178SecUserCrtUser[0]) != 0 ) || ( Z180SecUserCrtDate != BC00052_A180SecUserCrtDate[0] ) || ( StringUtil.StrCmp(Z14SecUserName, BC00052_A14SecUserName[0]) != 0 ) || ( StringUtil.StrCmp(Z15SecUserPassword, BC00052_A15SecUserPassword[0]) != 0 ) || ( StringUtil.StrCmp(Z179SecUserUpdUser, BC00052_A179SecUserUpdUser[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z181SecUserUpdDate != BC00052_A181SecUserUpdDate[0] ) || ( Z194SecUserWorkload != BC00052_A194SecUserWorkload[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"SecUser"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert056( )
      {
         BeforeValidate056( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable056( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM056( 0) ;
            CheckOptimisticConcurrency056( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm056( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert056( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00056 */
                     pr_default.execute(4, new Object[] {n178SecUserCrtUser, A178SecUserCrtUser, n180SecUserCrtDate, A180SecUserCrtDate, A14SecUserName, A15SecUserPassword, n179SecUserUpdUser, A179SecUserUpdUser, n181SecUserUpdDate, A181SecUserUpdDate, n194SecUserWorkload, A194SecUserWorkload});
                     A6SecUserId = BC00056_A6SecUserId[0];
                     pr_default.close(4);
                     dsDefault.SmartCacheProvider.SetUpdated("SecUser") ;
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
               Load056( ) ;
            }
            EndLevel056( ) ;
         }
         CloseExtendedTableCursors056( ) ;
      }

      protected void Update056( )
      {
         BeforeValidate056( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable056( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency056( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm056( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate056( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00057 */
                     pr_default.execute(5, new Object[] {n178SecUserCrtUser, A178SecUserCrtUser, n180SecUserCrtDate, A180SecUserCrtDate, A14SecUserName, A15SecUserPassword, n179SecUserUpdUser, A179SecUserUpdUser, n181SecUserUpdDate, A181SecUserUpdDate, n194SecUserWorkload, A194SecUserWorkload, A6SecUserId});
                     pr_default.close(5);
                     dsDefault.SmartCacheProvider.SetUpdated("SecUser") ;
                     if ( (pr_default.getStatus(5) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SecUser"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate056( ) ;
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
            EndLevel056( ) ;
         }
         CloseExtendedTableCursors056( ) ;
      }

      protected void DeferredUpdate056( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate056( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency056( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls056( ) ;
            AfterConfirm056( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete056( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC00058 */
                  pr_default.execute(6, new Object[] {A6SecUserId});
                  pr_default.close(6);
                  dsDefault.SmartCacheProvider.SetUpdated("SecUser") ;
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
         sMode6 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel056( ) ;
         Gx_mode = sMode6;
      }

      protected void OnDeleteControls056( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV17Pgmname = "WWPBaseObjects.SecUser_BC";
         }
         if ( AnyError == 0 )
         {
            /* Using cursor BC00059 */
            pr_default.execute(7, new Object[] {A6SecUserId});
            if ( (pr_default.getStatus(7) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"医院账号关系表"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(7);
            /* Using cursor BC000510 */
            pr_default.execute(8, new Object[] {A6SecUserId});
            if ( (pr_default.getStatus(8) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Sec User Role"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(8);
         }
      }

      protected void EndLevel056( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete056( ) ;
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

      public void ScanKeyStart056( )
      {
         /* Scan By routine */
         /* Using cursor BC000511 */
         pr_default.execute(9, new Object[] {A6SecUserId});
         RcdFound6 = 0;
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound6 = 1;
            A6SecUserId = BC000511_A6SecUserId[0];
            A178SecUserCrtUser = BC000511_A178SecUserCrtUser[0];
            n178SecUserCrtUser = BC000511_n178SecUserCrtUser[0];
            A180SecUserCrtDate = BC000511_A180SecUserCrtDate[0];
            n180SecUserCrtDate = BC000511_n180SecUserCrtDate[0];
            A14SecUserName = BC000511_A14SecUserName[0];
            A15SecUserPassword = BC000511_A15SecUserPassword[0];
            A179SecUserUpdUser = BC000511_A179SecUserUpdUser[0];
            n179SecUserUpdUser = BC000511_n179SecUserUpdUser[0];
            A181SecUserUpdDate = BC000511_A181SecUserUpdDate[0];
            n181SecUserUpdDate = BC000511_n181SecUserUpdDate[0];
            A194SecUserWorkload = BC000511_A194SecUserWorkload[0];
            n194SecUserWorkload = BC000511_n194SecUserWorkload[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext056( )
      {
         /* Scan next routine */
         pr_default.readNext(9);
         RcdFound6 = 0;
         ScanKeyLoad056( ) ;
      }

      protected void ScanKeyLoad056( )
      {
         sMode6 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound6 = 1;
            A6SecUserId = BC000511_A6SecUserId[0];
            A178SecUserCrtUser = BC000511_A178SecUserCrtUser[0];
            n178SecUserCrtUser = BC000511_n178SecUserCrtUser[0];
            A180SecUserCrtDate = BC000511_A180SecUserCrtDate[0];
            n180SecUserCrtDate = BC000511_n180SecUserCrtDate[0];
            A14SecUserName = BC000511_A14SecUserName[0];
            A15SecUserPassword = BC000511_A15SecUserPassword[0];
            A179SecUserUpdUser = BC000511_A179SecUserUpdUser[0];
            n179SecUserUpdUser = BC000511_n179SecUserUpdUser[0];
            A181SecUserUpdDate = BC000511_A181SecUserUpdDate[0];
            n181SecUserUpdDate = BC000511_n181SecUserUpdDate[0];
            A194SecUserWorkload = BC000511_A194SecUserWorkload[0];
            n194SecUserWorkload = BC000511_n194SecUserWorkload[0];
         }
         Gx_mode = sMode6;
      }

      protected void ScanKeyEnd056( )
      {
         pr_default.close(9);
      }

      protected void AfterConfirm056( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert056( )
      {
         /* Before Insert Rules */
         A180SecUserCrtDate = DateTimeUtil.ServerNow( context, pr_default);
         n180SecUserCrtDate = false;
         A178SecUserCrtUser = AV15WWPContext.gxTpr_Username;
         n178SecUserCrtUser = false;
      }

      protected void BeforeUpdate056( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete056( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete056( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate056( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes056( )
      {
      }

      protected void send_integrity_lvl_hashes056( )
      {
      }

      protected void AddRow056( )
      {
         VarsToRow6( bcwwpbaseobjects_SecUser) ;
      }

      protected void ReadRow056( )
      {
         RowToVars6( bcwwpbaseobjects_SecUser, 1) ;
      }

      protected void InitializeNonKey056( )
      {
         A178SecUserCrtUser = "";
         n178SecUserCrtUser = false;
         A180SecUserCrtDate = (DateTime)(DateTime.MinValue);
         n180SecUserCrtDate = false;
         A14SecUserName = "";
         A15SecUserPassword = "";
         A179SecUserUpdUser = "";
         n179SecUserUpdUser = false;
         A181SecUserUpdDate = (DateTime)(DateTime.MinValue);
         n181SecUserUpdDate = false;
         A194SecUserWorkload = 0;
         n194SecUserWorkload = false;
         Z178SecUserCrtUser = "";
         Z180SecUserCrtDate = (DateTime)(DateTime.MinValue);
         Z14SecUserName = "";
         Z15SecUserPassword = "";
         Z179SecUserUpdUser = "";
         Z181SecUserUpdDate = (DateTime)(DateTime.MinValue);
         Z194SecUserWorkload = 0;
      }

      protected void InitAll056( )
      {
         A6SecUserId = 0;
         InitializeNonKey056( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow6( GeneXus.Programs.wwpbaseobjects.SdtSecUser obj6 )
      {
         obj6.gxTpr_Mode = Gx_mode;
         obj6.gxTpr_Secusercrtuser = A178SecUserCrtUser;
         obj6.gxTpr_Secusercrtdate = A180SecUserCrtDate;
         obj6.gxTpr_Secusername = A14SecUserName;
         obj6.gxTpr_Secuserpassword = A15SecUserPassword;
         obj6.gxTpr_Secuserupduser = A179SecUserUpdUser;
         obj6.gxTpr_Secuserupddate = A181SecUserUpdDate;
         obj6.gxTpr_Secuserworkload = A194SecUserWorkload;
         obj6.gxTpr_Secuserid = A6SecUserId;
         obj6.gxTpr_Secuserid_Z = Z6SecUserId;
         obj6.gxTpr_Secusername_Z = Z14SecUserName;
         obj6.gxTpr_Secuserpassword_Z = Z15SecUserPassword;
         obj6.gxTpr_Secusercrtuser_Z = Z178SecUserCrtUser;
         obj6.gxTpr_Secuserupduser_Z = Z179SecUserUpdUser;
         obj6.gxTpr_Secusercrtdate_Z = Z180SecUserCrtDate;
         obj6.gxTpr_Secuserupddate_Z = Z181SecUserUpdDate;
         obj6.gxTpr_Secuserworkload_Z = Z194SecUserWorkload;
         obj6.gxTpr_Secusercrtuser_N = (short)(Convert.ToInt16(n178SecUserCrtUser));
         obj6.gxTpr_Secuserupduser_N = (short)(Convert.ToInt16(n179SecUserUpdUser));
         obj6.gxTpr_Secusercrtdate_N = (short)(Convert.ToInt16(n180SecUserCrtDate));
         obj6.gxTpr_Secuserupddate_N = (short)(Convert.ToInt16(n181SecUserUpdDate));
         obj6.gxTpr_Secuserworkload_N = (short)(Convert.ToInt16(n194SecUserWorkload));
         obj6.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow6( GeneXus.Programs.wwpbaseobjects.SdtSecUser obj6 )
      {
         obj6.gxTpr_Secuserid = A6SecUserId;
         return  ;
      }

      public void RowToVars6( GeneXus.Programs.wwpbaseobjects.SdtSecUser obj6 ,
                              int forceLoad )
      {
         Gx_mode = obj6.gxTpr_Mode;
         A178SecUserCrtUser = obj6.gxTpr_Secusercrtuser;
         n178SecUserCrtUser = false;
         A180SecUserCrtDate = obj6.gxTpr_Secusercrtdate;
         n180SecUserCrtDate = false;
         A14SecUserName = obj6.gxTpr_Secusername;
         A15SecUserPassword = obj6.gxTpr_Secuserpassword;
         A179SecUserUpdUser = obj6.gxTpr_Secuserupduser;
         n179SecUserUpdUser = false;
         A181SecUserUpdDate = obj6.gxTpr_Secuserupddate;
         n181SecUserUpdDate = false;
         A194SecUserWorkload = obj6.gxTpr_Secuserworkload;
         n194SecUserWorkload = false;
         A6SecUserId = obj6.gxTpr_Secuserid;
         Z6SecUserId = obj6.gxTpr_Secuserid_Z;
         Z14SecUserName = obj6.gxTpr_Secusername_Z;
         Z15SecUserPassword = obj6.gxTpr_Secuserpassword_Z;
         Z178SecUserCrtUser = obj6.gxTpr_Secusercrtuser_Z;
         Z179SecUserUpdUser = obj6.gxTpr_Secuserupduser_Z;
         Z180SecUserCrtDate = obj6.gxTpr_Secusercrtdate_Z;
         Z181SecUserUpdDate = obj6.gxTpr_Secuserupddate_Z;
         Z194SecUserWorkload = obj6.gxTpr_Secuserworkload_Z;
         n178SecUserCrtUser = (bool)(Convert.ToBoolean(obj6.gxTpr_Secusercrtuser_N));
         n179SecUserUpdUser = (bool)(Convert.ToBoolean(obj6.gxTpr_Secuserupduser_N));
         n180SecUserCrtDate = (bool)(Convert.ToBoolean(obj6.gxTpr_Secusercrtdate_N));
         n181SecUserUpdDate = (bool)(Convert.ToBoolean(obj6.gxTpr_Secuserupddate_N));
         n194SecUserWorkload = (bool)(Convert.ToBoolean(obj6.gxTpr_Secuserworkload_N));
         Gx_mode = obj6.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A6SecUserId = (short)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey056( ) ;
         ScanKeyStart056( ) ;
         if ( RcdFound6 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z6SecUserId = A6SecUserId;
         }
         ZM056( -6) ;
         OnLoadActions056( ) ;
         AddRow056( ) ;
         ScanKeyEnd056( ) ;
         if ( RcdFound6 == 0 )
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
         RowToVars6( bcwwpbaseobjects_SecUser, 0) ;
         ScanKeyStart056( ) ;
         if ( RcdFound6 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z6SecUserId = A6SecUserId;
         }
         ZM056( -6) ;
         OnLoadActions056( ) ;
         AddRow056( ) ;
         ScanKeyEnd056( ) ;
         if ( RcdFound6 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey056( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert056( ) ;
         }
         else
         {
            if ( RcdFound6 == 1 )
            {
               if ( A6SecUserId != Z6SecUserId )
               {
                  A6SecUserId = Z6SecUserId;
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
                  Update056( ) ;
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
                  if ( A6SecUserId != Z6SecUserId )
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
                        Insert056( ) ;
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
                        Insert056( ) ;
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
         RowToVars6( bcwwpbaseobjects_SecUser, 0) ;
         SaveImpl( ) ;
         VarsToRow6( bcwwpbaseobjects_SecUser) ;
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
         RowToVars6( bcwwpbaseobjects_SecUser, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert056( ) ;
         AfterTrn( ) ;
         VarsToRow6( bcwwpbaseobjects_SecUser) ;
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
            GeneXus.Programs.wwpbaseobjects.SdtSecUser auxBC = new GeneXus.Programs.wwpbaseobjects.SdtSecUser(context) ;
            auxBC.Load(A6SecUserId);
            auxBC.UpdateDirties(bcwwpbaseobjects_SecUser);
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
         RowToVars6( bcwwpbaseobjects_SecUser, 0) ;
         UpdateImpl( ) ;
         VarsToRow6( bcwwpbaseobjects_SecUser) ;
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
         RowToVars6( bcwwpbaseobjects_SecUser, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert056( ) ;
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
         VarsToRow6( bcwwpbaseobjects_SecUser) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars6( bcwwpbaseobjects_SecUser, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey056( ) ;
         if ( RcdFound6 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A6SecUserId != Z6SecUserId )
            {
               A6SecUserId = Z6SecUserId;
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
            if ( A6SecUserId != Z6SecUserId )
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
         context.RollbackDataStores("wwpbaseobjects.secuser_bc",pr_default);
         VarsToRow6( bcwwpbaseobjects_SecUser) ;
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
         Gx_mode = bcwwpbaseobjects_SecUser.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcwwpbaseobjects_SecUser.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcwwpbaseobjects_SecUser )
         {
            bcwwpbaseobjects_SecUser = (GeneXus.Programs.wwpbaseobjects.SdtSecUser)(sdt);
            if ( StringUtil.StrCmp(bcwwpbaseobjects_SecUser.gxTpr_Mode, "") == 0 )
            {
               bcwwpbaseobjects_SecUser.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow6( bcwwpbaseobjects_SecUser) ;
            }
            else
            {
               RowToVars6( bcwwpbaseobjects_SecUser, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcwwpbaseobjects_SecUser.gxTpr_Mode, "") == 0 )
            {
               bcwwpbaseobjects_SecUser.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars6( bcwwpbaseobjects_SecUser, 1) ;
         return  ;
      }

      public SdtSecUser SecUser_BC
      {
         get {
            return bcwwpbaseobjects_SecUser ;
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
         AV15WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV17Pgmname = "";
         AV11TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV12WebSession = context.GetSession();
         Z178SecUserCrtUser = "";
         A178SecUserCrtUser = "";
         Z180SecUserCrtDate = (DateTime)(DateTime.MinValue);
         A180SecUserCrtDate = (DateTime)(DateTime.MinValue);
         Z14SecUserName = "";
         A14SecUserName = "";
         Z15SecUserPassword = "";
         A15SecUserPassword = "";
         Z179SecUserUpdUser = "";
         A179SecUserUpdUser = "";
         Z181SecUserUpdDate = (DateTime)(DateTime.MinValue);
         A181SecUserUpdDate = (DateTime)(DateTime.MinValue);
         BC00054_A6SecUserId = new short[1] ;
         BC00054_A178SecUserCrtUser = new String[] {""} ;
         BC00054_n178SecUserCrtUser = new bool[] {false} ;
         BC00054_A180SecUserCrtDate = new DateTime[] {DateTime.MinValue} ;
         BC00054_n180SecUserCrtDate = new bool[] {false} ;
         BC00054_A14SecUserName = new String[] {""} ;
         BC00054_A15SecUserPassword = new String[] {""} ;
         BC00054_A179SecUserUpdUser = new String[] {""} ;
         BC00054_n179SecUserUpdUser = new bool[] {false} ;
         BC00054_A181SecUserUpdDate = new DateTime[] {DateTime.MinValue} ;
         BC00054_n181SecUserUpdDate = new bool[] {false} ;
         BC00054_A194SecUserWorkload = new long[1] ;
         BC00054_n194SecUserWorkload = new bool[] {false} ;
         BC00055_A6SecUserId = new short[1] ;
         BC00053_A6SecUserId = new short[1] ;
         BC00053_A178SecUserCrtUser = new String[] {""} ;
         BC00053_n178SecUserCrtUser = new bool[] {false} ;
         BC00053_A180SecUserCrtDate = new DateTime[] {DateTime.MinValue} ;
         BC00053_n180SecUserCrtDate = new bool[] {false} ;
         BC00053_A14SecUserName = new String[] {""} ;
         BC00053_A15SecUserPassword = new String[] {""} ;
         BC00053_A179SecUserUpdUser = new String[] {""} ;
         BC00053_n179SecUserUpdUser = new bool[] {false} ;
         BC00053_A181SecUserUpdDate = new DateTime[] {DateTime.MinValue} ;
         BC00053_n181SecUserUpdDate = new bool[] {false} ;
         BC00053_A194SecUserWorkload = new long[1] ;
         BC00053_n194SecUserWorkload = new bool[] {false} ;
         sMode6 = "";
         BC00052_A6SecUserId = new short[1] ;
         BC00052_A178SecUserCrtUser = new String[] {""} ;
         BC00052_n178SecUserCrtUser = new bool[] {false} ;
         BC00052_A180SecUserCrtDate = new DateTime[] {DateTime.MinValue} ;
         BC00052_n180SecUserCrtDate = new bool[] {false} ;
         BC00052_A14SecUserName = new String[] {""} ;
         BC00052_A15SecUserPassword = new String[] {""} ;
         BC00052_A179SecUserUpdUser = new String[] {""} ;
         BC00052_n179SecUserUpdUser = new bool[] {false} ;
         BC00052_A181SecUserUpdDate = new DateTime[] {DateTime.MinValue} ;
         BC00052_n181SecUserUpdDate = new bool[] {false} ;
         BC00052_A194SecUserWorkload = new long[1] ;
         BC00052_n194SecUserWorkload = new bool[] {false} ;
         BC00056_A6SecUserId = new short[1] ;
         BC00059_A6SecUserId = new short[1] ;
         BC00059_A87JC_ProviderID = new long[1] ;
         BC000510_A6SecUserId = new short[1] ;
         BC000510_A4SecRoleId = new short[1] ;
         BC000511_A6SecUserId = new short[1] ;
         BC000511_A178SecUserCrtUser = new String[] {""} ;
         BC000511_n178SecUserCrtUser = new bool[] {false} ;
         BC000511_A180SecUserCrtDate = new DateTime[] {DateTime.MinValue} ;
         BC000511_n180SecUserCrtDate = new bool[] {false} ;
         BC000511_A14SecUserName = new String[] {""} ;
         BC000511_A15SecUserPassword = new String[] {""} ;
         BC000511_A179SecUserUpdUser = new String[] {""} ;
         BC000511_n179SecUserUpdUser = new bool[] {false} ;
         BC000511_A181SecUserUpdDate = new DateTime[] {DateTime.MinValue} ;
         BC000511_n181SecUserUpdDate = new bool[] {false} ;
         BC000511_A194SecUserWorkload = new long[1] ;
         BC000511_n194SecUserWorkload = new bool[] {false} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.wwpbaseobjects.secuser_bc__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wwpbaseobjects.secuser_bc__default(),
            new Object[][] {
                new Object[] {
               BC00052_A6SecUserId, BC00052_A178SecUserCrtUser, BC00052_n178SecUserCrtUser, BC00052_A180SecUserCrtDate, BC00052_n180SecUserCrtDate, BC00052_A14SecUserName, BC00052_A15SecUserPassword, BC00052_A179SecUserUpdUser, BC00052_n179SecUserUpdUser, BC00052_A181SecUserUpdDate,
               BC00052_n181SecUserUpdDate, BC00052_A194SecUserWorkload, BC00052_n194SecUserWorkload
               }
               , new Object[] {
               BC00053_A6SecUserId, BC00053_A178SecUserCrtUser, BC00053_n178SecUserCrtUser, BC00053_A180SecUserCrtDate, BC00053_n180SecUserCrtDate, BC00053_A14SecUserName, BC00053_A15SecUserPassword, BC00053_A179SecUserUpdUser, BC00053_n179SecUserUpdUser, BC00053_A181SecUserUpdDate,
               BC00053_n181SecUserUpdDate, BC00053_A194SecUserWorkload, BC00053_n194SecUserWorkload
               }
               , new Object[] {
               BC00054_A6SecUserId, BC00054_A178SecUserCrtUser, BC00054_n178SecUserCrtUser, BC00054_A180SecUserCrtDate, BC00054_n180SecUserCrtDate, BC00054_A14SecUserName, BC00054_A15SecUserPassword, BC00054_A179SecUserUpdUser, BC00054_n179SecUserUpdUser, BC00054_A181SecUserUpdDate,
               BC00054_n181SecUserUpdDate, BC00054_A194SecUserWorkload, BC00054_n194SecUserWorkload
               }
               , new Object[] {
               BC00055_A6SecUserId
               }
               , new Object[] {
               BC00056_A6SecUserId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC00059_A6SecUserId, BC00059_A87JC_ProviderID
               }
               , new Object[] {
               BC000510_A6SecUserId, BC000510_A4SecRoleId
               }
               , new Object[] {
               BC000511_A6SecUserId, BC000511_A178SecUserCrtUser, BC000511_n178SecUserCrtUser, BC000511_A180SecUserCrtDate, BC000511_n180SecUserCrtDate, BC000511_A14SecUserName, BC000511_A15SecUserPassword, BC000511_A179SecUserUpdUser, BC000511_n179SecUserUpdUser, BC000511_A181SecUserUpdDate,
               BC000511_n181SecUserUpdDate, BC000511_A194SecUserWorkload, BC000511_n194SecUserWorkload
               }
            }
         );
         AV17Pgmname = "WWPBaseObjects.SecUser_BC";
         INITTRN();
         /* Execute Start event if defined. */
         /* Execute user event: Start */
         E12052 ();
         standaloneNotModal( ) ;
      }

      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short Z6SecUserId ;
      private short A6SecUserId ;
      private short GX_JID ;
      private short RcdFound6 ;
      private int trnEnded ;
      private long Z194SecUserWorkload ;
      private long A194SecUserWorkload ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String AV17Pgmname ;
      private String sMode6 ;
      private DateTime Z180SecUserCrtDate ;
      private DateTime A180SecUserCrtDate ;
      private DateTime Z181SecUserUpdDate ;
      private DateTime A181SecUserUpdDate ;
      private bool AV9IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool n178SecUserCrtUser ;
      private bool n180SecUserCrtDate ;
      private bool n179SecUserUpdUser ;
      private bool n181SecUserUpdDate ;
      private bool n194SecUserWorkload ;
      private bool Gx_longc ;
      private String Z178SecUserCrtUser ;
      private String A178SecUserCrtUser ;
      private String Z14SecUserName ;
      private String A14SecUserName ;
      private String Z15SecUserPassword ;
      private String A15SecUserPassword ;
      private String Z179SecUserUpdUser ;
      private String A179SecUserUpdUser ;
      private IGxSession AV12WebSession ;
      private GeneXus.Programs.wwpbaseobjects.SdtSecUser bcwwpbaseobjects_SecUser ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] BC00054_A6SecUserId ;
      private String[] BC00054_A178SecUserCrtUser ;
      private bool[] BC00054_n178SecUserCrtUser ;
      private DateTime[] BC00054_A180SecUserCrtDate ;
      private bool[] BC00054_n180SecUserCrtDate ;
      private String[] BC00054_A14SecUserName ;
      private String[] BC00054_A15SecUserPassword ;
      private String[] BC00054_A179SecUserUpdUser ;
      private bool[] BC00054_n179SecUserUpdUser ;
      private DateTime[] BC00054_A181SecUserUpdDate ;
      private bool[] BC00054_n181SecUserUpdDate ;
      private long[] BC00054_A194SecUserWorkload ;
      private bool[] BC00054_n194SecUserWorkload ;
      private short[] BC00055_A6SecUserId ;
      private short[] BC00053_A6SecUserId ;
      private String[] BC00053_A178SecUserCrtUser ;
      private bool[] BC00053_n178SecUserCrtUser ;
      private DateTime[] BC00053_A180SecUserCrtDate ;
      private bool[] BC00053_n180SecUserCrtDate ;
      private String[] BC00053_A14SecUserName ;
      private String[] BC00053_A15SecUserPassword ;
      private String[] BC00053_A179SecUserUpdUser ;
      private bool[] BC00053_n179SecUserUpdUser ;
      private DateTime[] BC00053_A181SecUserUpdDate ;
      private bool[] BC00053_n181SecUserUpdDate ;
      private long[] BC00053_A194SecUserWorkload ;
      private bool[] BC00053_n194SecUserWorkload ;
      private short[] BC00052_A6SecUserId ;
      private String[] BC00052_A178SecUserCrtUser ;
      private bool[] BC00052_n178SecUserCrtUser ;
      private DateTime[] BC00052_A180SecUserCrtDate ;
      private bool[] BC00052_n180SecUserCrtDate ;
      private String[] BC00052_A14SecUserName ;
      private String[] BC00052_A15SecUserPassword ;
      private String[] BC00052_A179SecUserUpdUser ;
      private bool[] BC00052_n179SecUserUpdUser ;
      private DateTime[] BC00052_A181SecUserUpdDate ;
      private bool[] BC00052_n181SecUserUpdDate ;
      private long[] BC00052_A194SecUserWorkload ;
      private bool[] BC00052_n194SecUserWorkload ;
      private short[] BC00056_A6SecUserId ;
      private short[] BC00059_A6SecUserId ;
      private long[] BC00059_A87JC_ProviderID ;
      private short[] BC000510_A6SecUserId ;
      private short[] BC000510_A4SecRoleId ;
      private short[] BC000511_A6SecUserId ;
      private String[] BC000511_A178SecUserCrtUser ;
      private bool[] BC000511_n178SecUserCrtUser ;
      private DateTime[] BC000511_A180SecUserCrtDate ;
      private bool[] BC000511_n180SecUserCrtDate ;
      private String[] BC000511_A14SecUserName ;
      private String[] BC000511_A15SecUserPassword ;
      private String[] BC000511_A179SecUserUpdUser ;
      private bool[] BC000511_n179SecUserUpdUser ;
      private DateTime[] BC000511_A181SecUserUpdDate ;
      private bool[] BC000511_n181SecUserUpdDate ;
      private long[] BC000511_A194SecUserWorkload ;
      private bool[] BC000511_n194SecUserWorkload ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_datastore1 ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV15WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV11TrnContext ;
   }

   public class secuser_bc__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class secuser_bc__default : DataStoreHelperBase, IDataStoreHelper
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
        Object[] prmBC00054 ;
        prmBC00054 = new Object[] {
        new Object[] {"@SecUserId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmBC00055 ;
        prmBC00055 = new Object[] {
        new Object[] {"@SecUserId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmBC00053 ;
        prmBC00053 = new Object[] {
        new Object[] {"@SecUserId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmBC00052 ;
        prmBC00052 = new Object[] {
        new Object[] {"@SecUserId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmBC00056 ;
        prmBC00056 = new Object[] {
        new Object[] {"@SecUserCrtUser",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@SecUserCrtDate",SqlDbType.DateTime,8,5} ,
        new Object[] {"@SecUserName",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@SecUserPassword",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@SecUserUpdUser",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@SecUserUpdDate",SqlDbType.DateTime,10,8} ,
        new Object[] {"@SecUserWorkload",SqlDbType.Decimal,10,0}
        } ;
        Object[] prmBC00057 ;
        prmBC00057 = new Object[] {
        new Object[] {"@SecUserCrtUser",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@SecUserCrtDate",SqlDbType.DateTime,8,5} ,
        new Object[] {"@SecUserName",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@SecUserPassword",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@SecUserUpdUser",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@SecUserUpdDate",SqlDbType.DateTime,10,8} ,
        new Object[] {"@SecUserWorkload",SqlDbType.Decimal,10,0} ,
        new Object[] {"@SecUserId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmBC00058 ;
        prmBC00058 = new Object[] {
        new Object[] {"@SecUserId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmBC00059 ;
        prmBC00059 = new Object[] {
        new Object[] {"@SecUserId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmBC000510 ;
        prmBC000510 = new Object[] {
        new Object[] {"@SecUserId",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmBC000511 ;
        prmBC000511 = new Object[] {
        new Object[] {"@SecUserId",SqlDbType.SmallInt,4,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("BC00052", "SELECT [SecUserId], [SecUserCrtUser], [SecUserCrtDate], [SecUserName], [SecUserPassword], [SecUserUpdUser], [SecUserUpdDate], [SecUserWorkload] FROM [SecUser] WITH (UPDLOCK) WHERE [SecUserId] = @SecUserId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00052,1,0,true,false )
           ,new CursorDef("BC00053", "SELECT [SecUserId], [SecUserCrtUser], [SecUserCrtDate], [SecUserName], [SecUserPassword], [SecUserUpdUser], [SecUserUpdDate], [SecUserWorkload] FROM [SecUser] WITH (NOLOCK) WHERE [SecUserId] = @SecUserId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00053,1,0,true,false )
           ,new CursorDef("BC00054", "SELECT TM1.[SecUserId], TM1.[SecUserCrtUser], TM1.[SecUserCrtDate], TM1.[SecUserName], TM1.[SecUserPassword], TM1.[SecUserUpdUser], TM1.[SecUserUpdDate], TM1.[SecUserWorkload] FROM [SecUser] TM1 WITH (NOLOCK) WHERE TM1.[SecUserId] = @SecUserId ORDER BY TM1.[SecUserId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00054,100,0,true,false )
           ,new CursorDef("BC00055", "SELECT [SecUserId] FROM [SecUser] WITH (NOLOCK) WHERE [SecUserId] = @SecUserId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00055,1,0,true,false )
           ,new CursorDef("BC00056", "INSERT INTO [SecUser]([SecUserCrtUser], [SecUserCrtDate], [SecUserName], [SecUserPassword], [SecUserUpdUser], [SecUserUpdDate], [SecUserWorkload]) VALUES(@SecUserCrtUser, @SecUserCrtDate, @SecUserName, @SecUserPassword, @SecUserUpdUser, @SecUserUpdDate, @SecUserWorkload); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmBC00056)
           ,new CursorDef("BC00057", "UPDATE [SecUser] SET [SecUserCrtUser]=@SecUserCrtUser, [SecUserCrtDate]=@SecUserCrtDate, [SecUserName]=@SecUserName, [SecUserPassword]=@SecUserPassword, [SecUserUpdUser]=@SecUserUpdUser, [SecUserUpdDate]=@SecUserUpdDate, [SecUserWorkload]=@SecUserWorkload  WHERE [SecUserId] = @SecUserId", GxErrorMask.GX_NOMASK,prmBC00057)
           ,new CursorDef("BC00058", "DELETE FROM [SecUser]  WHERE [SecUserId] = @SecUserId", GxErrorMask.GX_NOMASK,prmBC00058)
           ,new CursorDef("BC00059", "SELECT TOP 1 [SecUserId], [JC_ProviderID] FROM [JC_ProviderSecUser] WITH (NOLOCK) WHERE [SecUserId] = @SecUserId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00059,1,0,true,true )
           ,new CursorDef("BC000510", "SELECT TOP 1 [SecUserId], [SecRoleId] FROM [SecUserRole] WITH (NOLOCK) WHERE [SecUserId] = @SecUserId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000510,1,0,true,true )
           ,new CursorDef("BC000511", "SELECT TM1.[SecUserId], TM1.[SecUserCrtUser], TM1.[SecUserCrtDate], TM1.[SecUserName], TM1.[SecUserPassword], TM1.[SecUserUpdUser], TM1.[SecUserUpdDate], TM1.[SecUserWorkload] FROM [SecUser] TM1 WITH (NOLOCK) WHERE TM1.[SecUserId] = @SecUserId ORDER BY TM1.[SecUserId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000511,100,0,true,false )
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
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((String[]) buf[6])[0] = rslt.getVarchar(5) ;
              ((String[]) buf[7])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(6);
              ((DateTime[]) buf[9])[0] = rslt.getGXDateTime(7) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(7);
              ((long[]) buf[11])[0] = rslt.getLong(8) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(8);
              return;
           case 1 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((String[]) buf[6])[0] = rslt.getVarchar(5) ;
              ((String[]) buf[7])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(6);
              ((DateTime[]) buf[9])[0] = rslt.getGXDateTime(7) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(7);
              ((long[]) buf[11])[0] = rslt.getLong(8) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(8);
              return;
           case 2 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((String[]) buf[6])[0] = rslt.getVarchar(5) ;
              ((String[]) buf[7])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(6);
              ((DateTime[]) buf[9])[0] = rslt.getGXDateTime(7) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(7);
              ((long[]) buf[11])[0] = rslt.getLong(8) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(8);
              return;
           case 3 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              return;
           case 4 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              return;
           case 7 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              return;
           case 8 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              ((short[]) buf[1])[0] = rslt.getShort(2) ;
              return;
           case 9 :
              ((short[]) buf[0])[0] = rslt.getShort(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((String[]) buf[6])[0] = rslt.getVarchar(5) ;
              ((String[]) buf[7])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(6);
              ((DateTime[]) buf[9])[0] = rslt.getGXDateTime(7) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(7);
              ((long[]) buf[11])[0] = rslt.getLong(8) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(8);
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
                 stmt.SetParameterDatetime(2, (DateTime)parms[3]);
              }
              stmt.SetParameter(3, (String)parms[4]);
              stmt.SetParameter(4, (String)parms[5]);
              if ( (bool)parms[6] )
              {
                 stmt.setNull( 5 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(5, (String)parms[7]);
              }
              if ( (bool)parms[8] )
              {
                 stmt.setNull( 6 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(6, (DateTime)parms[9]);
              }
              if ( (bool)parms[10] )
              {
                 stmt.setNull( 7 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(7, (long)parms[11]);
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
                 stmt.SetParameterDatetime(2, (DateTime)parms[3]);
              }
              stmt.SetParameter(3, (String)parms[4]);
              stmt.SetParameter(4, (String)parms[5]);
              if ( (bool)parms[6] )
              {
                 stmt.setNull( 5 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(5, (String)parms[7]);
              }
              if ( (bool)parms[8] )
              {
                 stmt.setNull( 6 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(6, (DateTime)parms[9]);
              }
              if ( (bool)parms[10] )
              {
                 stmt.setNull( 7 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(7, (long)parms[11]);
              }
              stmt.SetParameter(8, (short)parms[12]);
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
