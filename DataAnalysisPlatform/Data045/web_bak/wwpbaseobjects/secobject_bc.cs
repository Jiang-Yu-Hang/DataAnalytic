/*
               File: WWPBaseObjects.SecObject_BC
        Description: Sec Object
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:35:45.83
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
   public class secobject_bc : GXHttpHandler, IGxSilentTrn
   {
      public secobject_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public secobject_bc( IGxContext context )
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
         ReadRow033( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey033( ) ;
         standaloneModal( ) ;
         AddRow033( ) ;
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
               Z5SecObjectName = A5SecObjectName;
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

      protected void CONFIRM_030( )
      {
         BeforeValidate033( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls033( ) ;
            }
            else
            {
               CheckExtendedTable033( ) ;
               if ( AnyError == 0 )
               {
               }
               CloseExtendedTableCursors033( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            /* Save parent mode. */
            sMode3 = Gx_mode;
            CONFIRM_034( ) ;
            if ( AnyError == 0 )
            {
               /* Restore parent mode. */
               Gx_mode = sMode3;
               IsConfirmed = 1;
            }
            /* Restore parent mode. */
            Gx_mode = sMode3;
         }
      }

      protected void CONFIRM_034( )
      {
         nGXsfl_4_idx = 0;
         while ( nGXsfl_4_idx < bcwwpbaseobjects_SecObject.gxTpr_Functionalities.Count )
         {
            ReadRow034( ) ;
            if ( String.IsNullOrEmpty(StringUtil.RTrim( Gx_mode)) )
            {
               if ( RcdFound4 == 0 )
               {
                  Gx_mode = "INS";
               }
               else
               {
                  Gx_mode = "UPD";
               }
            }
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) || ( nIsMod_4 != 0 ) )
            {
               GetKey034( ) ;
               if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( StringUtil.StrCmp(Gx_mode, "DLT") != 0 ) )
               {
                  if ( RcdFound4 == 0 )
                  {
                     Gx_mode = "INS";
                     BeforeValidate034( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable034( ) ;
                        if ( AnyError == 0 )
                        {
                           ZM034( 3) ;
                        }
                        CloseExtendedTableCursors034( ) ;
                        if ( AnyError == 0 )
                        {
                           IsConfirmed = 1;
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
                     AnyError = 1;
                  }
               }
               else
               {
                  if ( RcdFound4 != 0 )
                  {
                     if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                     {
                        Gx_mode = "DLT";
                        getByPrimaryKey034( ) ;
                        Load034( ) ;
                        BeforeValidate034( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls034( ) ;
                        }
                     }
                     else
                     {
                        if ( nIsMod_4 != 0 )
                        {
                           Gx_mode = "UPD";
                           BeforeValidate034( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable034( ) ;
                              if ( AnyError == 0 )
                              {
                                 ZM034( 3) ;
                              }
                              CloseExtendedTableCursors034( ) ;
                              if ( AnyError == 0 )
                              {
                                 IsConfirmed = 1;
                              }
                           }
                        }
                     }
                  }
                  else
                  {
                     if ( StringUtil.StrCmp(Gx_mode, "DLT") != 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                        AnyError = 1;
                     }
                  }
               }
               VarsToRow4( ((GeneXus.Programs.wwpbaseobjects.SdtSecObject_Functionalities)bcwwpbaseobjects_SecObject.gxTpr_Functionalities.Item(nGXsfl_4_idx))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ZM033( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
         }
         if ( GX_JID == -1 )
         {
            Z5SecObjectName = A5SecObjectName;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load033( )
      {
         /* Using cursor BC00037 */
         pr_default.execute(5, new Object[] {A5SecObjectName});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound3 = 1;
            ZM033( -1) ;
         }
         pr_default.close(5);
         OnLoadActions033( ) ;
      }

      protected void OnLoadActions033( )
      {
      }

      protected void CheckExtendedTable033( )
      {
         standaloneModal( ) ;
      }

      protected void CloseExtendedTableCursors033( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey033( )
      {
         /* Using cursor BC00038 */
         pr_default.execute(6, new Object[] {A5SecObjectName});
         if ( (pr_default.getStatus(6) != 101) )
         {
            RcdFound3 = 1;
         }
         else
         {
            RcdFound3 = 0;
         }
         pr_default.close(6);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC00036 */
         pr_default.execute(4, new Object[] {A5SecObjectName});
         if ( (pr_default.getStatus(4) != 101) )
         {
            ZM033( 1) ;
            RcdFound3 = 1;
            A5SecObjectName = BC00036_A5SecObjectName[0];
            Z5SecObjectName = A5SecObjectName;
            sMode3 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load033( ) ;
            if ( AnyError == 1 )
            {
               RcdFound3 = 0;
               InitializeNonKey033( ) ;
            }
            Gx_mode = sMode3;
         }
         else
         {
            RcdFound3 = 0;
            InitializeNonKey033( ) ;
            sMode3 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode3;
         }
         pr_default.close(4);
      }

      protected void getEqualNoModal( )
      {
         GetKey033( ) ;
         if ( RcdFound3 == 0 )
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
         CONFIRM_030( ) ;
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

      protected void CheckOptimisticConcurrency033( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC00035 */
            pr_default.execute(3, new Object[] {A5SecObjectName});
            if ( (pr_default.getStatus(3) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SecObject"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(3) == 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"SecObject"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert033( )
      {
         BeforeValidate033( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable033( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM033( 0) ;
            CheckOptimisticConcurrency033( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm033( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert033( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00039 */
                     pr_default.execute(7, new Object[] {A5SecObjectName});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("SecObject") ;
                     if ( (pr_default.getStatus(7) == 1) )
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
                           ProcessLevel033( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
                              GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           }
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
               Load033( ) ;
            }
            EndLevel033( ) ;
         }
         CloseExtendedTableCursors033( ) ;
      }

      protected void Update033( )
      {
         BeforeValidate033( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable033( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency033( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm033( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate033( ) ;
                  if ( AnyError == 0 )
                  {
                     /* No attributes to update on table [SecObject] */
                     DeferredUpdate033( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel033( ) ;
                           if ( AnyError == 0 )
                           {
                              getByPrimaryKey( ) ;
                              GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), "SuccessfullyUpdated", 0, "", true);
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
            }
            EndLevel033( ) ;
         }
         CloseExtendedTableCursors033( ) ;
      }

      protected void DeferredUpdate033( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate033( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency033( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls033( ) ;
            AfterConfirm033( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete033( ) ;
               if ( AnyError == 0 )
               {
                  ScanKeyStart034( ) ;
                  while ( RcdFound4 != 0 )
                  {
                     getByPrimaryKey034( ) ;
                     Delete034( ) ;
                     ScanKeyNext034( ) ;
                  }
                  ScanKeyEnd034( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000310 */
                     pr_default.execute(8, new Object[] {A5SecObjectName});
                     pr_default.close(8);
                     dsDefault.SmartCacheProvider.SetUpdated("SecObject") ;
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
         }
         sMode3 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel033( ) ;
         Gx_mode = sMode3;
      }

      protected void OnDeleteControls033( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void ProcessNestedLevel034( )
      {
         nGXsfl_4_idx = 0;
         while ( nGXsfl_4_idx < bcwwpbaseobjects_SecObject.gxTpr_Functionalities.Count )
         {
            ReadRow034( ) ;
            if ( String.IsNullOrEmpty(StringUtil.RTrim( Gx_mode)) )
            {
               if ( RcdFound4 == 0 )
               {
                  Gx_mode = "INS";
               }
               else
               {
                  Gx_mode = "UPD";
               }
            }
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) || ( nIsMod_4 != 0 ) )
            {
               standaloneNotModal034( ) ;
               if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
               {
                  Gx_mode = "INS";
                  Insert034( ) ;
               }
               else
               {
                  if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                  {
                     Gx_mode = "DLT";
                     Delete034( ) ;
                  }
                  else
                  {
                     Gx_mode = "UPD";
                     Update034( ) ;
                  }
               }
            }
            KeyVarsToRow4( ((GeneXus.Programs.wwpbaseobjects.SdtSecObject_Functionalities)bcwwpbaseobjects_SecObject.gxTpr_Functionalities.Item(nGXsfl_4_idx))) ;
         }
         if ( AnyError == 0 )
         {
            /* Batch update SDT rows */
            nGXsfl_4_idx = 0;
            while ( nGXsfl_4_idx < bcwwpbaseobjects_SecObject.gxTpr_Functionalities.Count )
            {
               ReadRow034( ) ;
               if ( String.IsNullOrEmpty(StringUtil.RTrim( Gx_mode)) )
               {
                  if ( RcdFound4 == 0 )
                  {
                     Gx_mode = "INS";
                  }
                  else
                  {
                     Gx_mode = "UPD";
                  }
               }
               /* Update SDT row */
               if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  bcwwpbaseobjects_SecObject.gxTpr_Functionalities.RemoveElement(nGXsfl_4_idx);
                  nGXsfl_4_idx = (short)(nGXsfl_4_idx-1);
               }
               else
               {
                  Gx_mode = "UPD";
                  getByPrimaryKey034( ) ;
                  VarsToRow4( ((GeneXus.Programs.wwpbaseobjects.SdtSecObject_Functionalities)bcwwpbaseobjects_SecObject.gxTpr_Functionalities.Item(nGXsfl_4_idx))) ;
               }
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll034( ) ;
         if ( AnyError != 0 )
         {
         }
         nRcdExists_4 = 0;
         nIsMod_4 = 0;
         Gxremove4 = 0;
      }

      protected void ProcessLevel033( )
      {
         /* Save parent mode. */
         sMode3 = Gx_mode;
         ProcessNestedLevel034( ) ;
         if ( AnyError != 0 )
         {
         }
         /* Restore parent mode. */
         Gx_mode = sMode3;
         /* ' Update level parameters */
      }

      protected void EndLevel033( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(3);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete033( ) ;
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

      public void ScanKeyStart033( )
      {
         /* Using cursor BC000311 */
         pr_default.execute(9, new Object[] {A5SecObjectName});
         RcdFound3 = 0;
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound3 = 1;
            A5SecObjectName = BC000311_A5SecObjectName[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext033( )
      {
         /* Scan next routine */
         pr_default.readNext(9);
         RcdFound3 = 0;
         ScanKeyLoad033( ) ;
      }

      protected void ScanKeyLoad033( )
      {
         sMode3 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound3 = 1;
            A5SecObjectName = BC000311_A5SecObjectName[0];
         }
         Gx_mode = sMode3;
      }

      protected void ScanKeyEnd033( )
      {
         pr_default.close(9);
      }

      protected void AfterConfirm033( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert033( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate033( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete033( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete033( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate033( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes033( )
      {
      }

      protected void ZM034( short GX_JID )
      {
         if ( ( GX_JID == 2 ) || ( GX_JID == 0 ) )
         {
         }
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            Z8SecFunctionalityDescription = A8SecFunctionalityDescription;
         }
         if ( GX_JID == -2 )
         {
            Z5SecObjectName = A5SecObjectName;
            Z1SecFunctionalityId = A1SecFunctionalityId;
            Z8SecFunctionalityDescription = A8SecFunctionalityDescription;
         }
      }

      protected void standaloneNotModal034( )
      {
      }

      protected void standaloneModal034( )
      {
      }

      protected void Load034( )
      {
         /* Using cursor BC000312 */
         pr_default.execute(10, new Object[] {A5SecObjectName, A1SecFunctionalityId});
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound4 = 1;
            A8SecFunctionalityDescription = BC000312_A8SecFunctionalityDescription[0];
            ZM034( -2) ;
         }
         pr_default.close(10);
         OnLoadActions034( ) ;
      }

      protected void OnLoadActions034( )
      {
      }

      protected void CheckExtendedTable034( )
      {
         Gx_BScreen = 1;
         standaloneModal034( ) ;
         Gx_BScreen = 0;
         /* Using cursor BC00034 */
         pr_default.execute(2, new Object[] {A1SecFunctionalityId});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("不匹配'Functionality'", "ForeignKeyNotFound", 1, "SECFUNCTIONALITYID");
            AnyError = 1;
         }
         A8SecFunctionalityDescription = BC00034_A8SecFunctionalityDescription[0];
         pr_default.close(2);
      }

      protected void CloseExtendedTableCursors034( )
      {
         pr_default.close(2);
      }

      protected void enableDisable034( )
      {
      }

      protected void GetKey034( )
      {
         /* Using cursor BC000313 */
         pr_default.execute(11, new Object[] {A5SecObjectName, A1SecFunctionalityId});
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound4 = 1;
         }
         else
         {
            RcdFound4 = 0;
         }
         pr_default.close(11);
      }

      protected void getByPrimaryKey034( )
      {
         /* Using cursor BC00033 */
         pr_default.execute(1, new Object[] {A5SecObjectName, A1SecFunctionalityId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM034( 2) ;
            RcdFound4 = 1;
            InitializeNonKey034( ) ;
            A1SecFunctionalityId = BC00033_A1SecFunctionalityId[0];
            Z5SecObjectName = A5SecObjectName;
            Z1SecFunctionalityId = A1SecFunctionalityId;
            sMode4 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal034( ) ;
            Load034( ) ;
            Gx_mode = sMode4;
         }
         else
         {
            RcdFound4 = 0;
            InitializeNonKey034( ) ;
            sMode4 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal034( ) ;
            Gx_mode = sMode4;
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            DisableAttributes034( ) ;
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency034( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC00032 */
            pr_default.execute(0, new Object[] {A5SecObjectName, A1SecFunctionalityId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SecObjectFunctionalities"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"SecObjectFunctionalities"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert034( )
      {
         BeforeValidate034( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable034( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM034( 0) ;
            CheckOptimisticConcurrency034( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm034( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert034( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000314 */
                     pr_default.execute(12, new Object[] {A5SecObjectName, A1SecFunctionalityId});
                     pr_default.close(12);
                     dsDefault.SmartCacheProvider.SetUpdated("SecObjectFunctionalities") ;
                     if ( (pr_default.getStatus(12) == 1) )
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
               Load034( ) ;
            }
            EndLevel034( ) ;
         }
         CloseExtendedTableCursors034( ) ;
      }

      protected void Update034( )
      {
         BeforeValidate034( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable034( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency034( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm034( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate034( ) ;
                  if ( AnyError == 0 )
                  {
                     /* No attributes to update on table [SecObjectFunctionalities] */
                     DeferredUpdate034( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey034( ) ;
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
            EndLevel034( ) ;
         }
         CloseExtendedTableCursors034( ) ;
      }

      protected void DeferredUpdate034( )
      {
      }

      protected void Delete034( )
      {
         Gx_mode = "DLT";
         BeforeValidate034( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency034( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls034( ) ;
            AfterConfirm034( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete034( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC000315 */
                  pr_default.execute(13, new Object[] {A5SecObjectName, A1SecFunctionalityId});
                  pr_default.close(13);
                  dsDefault.SmartCacheProvider.SetUpdated("SecObjectFunctionalities") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
         }
         sMode4 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel034( ) ;
         Gx_mode = sMode4;
      }

      protected void OnDeleteControls034( )
      {
         standaloneModal034( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor BC000316 */
            pr_default.execute(14, new Object[] {A1SecFunctionalityId});
            A8SecFunctionalityDescription = BC000316_A8SecFunctionalityDescription[0];
            pr_default.close(14);
         }
      }

      protected void EndLevel034( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanKeyStart034( )
      {
         /* Scan By routine */
         /* Using cursor BC000317 */
         pr_default.execute(15, new Object[] {A5SecObjectName});
         RcdFound4 = 0;
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound4 = 1;
            A8SecFunctionalityDescription = BC000317_A8SecFunctionalityDescription[0];
            A1SecFunctionalityId = BC000317_A1SecFunctionalityId[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext034( )
      {
         /* Scan next routine */
         pr_default.readNext(15);
         RcdFound4 = 0;
         ScanKeyLoad034( ) ;
      }

      protected void ScanKeyLoad034( )
      {
         sMode4 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound4 = 1;
            A8SecFunctionalityDescription = BC000317_A8SecFunctionalityDescription[0];
            A1SecFunctionalityId = BC000317_A1SecFunctionalityId[0];
         }
         Gx_mode = sMode4;
      }

      protected void ScanKeyEnd034( )
      {
         pr_default.close(15);
      }

      protected void AfterConfirm034( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert034( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate034( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete034( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete034( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate034( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes034( )
      {
      }

      protected void send_integrity_lvl_hashes034( )
      {
      }

      protected void send_integrity_lvl_hashes033( )
      {
      }

      protected void AddRow033( )
      {
         VarsToRow3( bcwwpbaseobjects_SecObject) ;
      }

      protected void ReadRow033( )
      {
         RowToVars3( bcwwpbaseobjects_SecObject, 1) ;
      }

      protected void AddRow034( )
      {
         GeneXus.Programs.wwpbaseobjects.SdtSecObject_Functionalities obj4 ;
         obj4 = new GeneXus.Programs.wwpbaseobjects.SdtSecObject_Functionalities(context);
         VarsToRow4( obj4) ;
         bcwwpbaseobjects_SecObject.gxTpr_Functionalities.Add(obj4, 0);
         obj4.gxTpr_Mode = "UPD";
         obj4.gxTpr_Modified = 0;
      }

      protected void ReadRow034( )
      {
         nGXsfl_4_idx = (short)(nGXsfl_4_idx+1);
         RowToVars4( ((GeneXus.Programs.wwpbaseobjects.SdtSecObject_Functionalities)bcwwpbaseobjects_SecObject.gxTpr_Functionalities.Item(nGXsfl_4_idx)), 1) ;
      }

      protected void InitializeNonKey033( )
      {
      }

      protected void InitAll033( )
      {
         A5SecObjectName = "";
         InitializeNonKey033( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void InitializeNonKey034( )
      {
         A8SecFunctionalityDescription = "";
      }

      protected void InitAll034( )
      {
         A1SecFunctionalityId = 0;
         InitializeNonKey034( ) ;
      }

      protected void StandaloneModalInsert034( )
      {
      }

      public void VarsToRow3( GeneXus.Programs.wwpbaseobjects.SdtSecObject obj3 )
      {
         obj3.gxTpr_Mode = Gx_mode;
         obj3.gxTpr_Secobjectname = A5SecObjectName;
         obj3.gxTpr_Secobjectname_Z = Z5SecObjectName;
         obj3.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow3( GeneXus.Programs.wwpbaseobjects.SdtSecObject obj3 )
      {
         obj3.gxTpr_Secobjectname = A5SecObjectName;
         return  ;
      }

      public void RowToVars3( GeneXus.Programs.wwpbaseobjects.SdtSecObject obj3 ,
                              int forceLoad )
      {
         Gx_mode = obj3.gxTpr_Mode;
         A5SecObjectName = obj3.gxTpr_Secobjectname;
         Z5SecObjectName = obj3.gxTpr_Secobjectname_Z;
         Gx_mode = obj3.gxTpr_Mode;
         return  ;
      }

      public void VarsToRow4( GeneXus.Programs.wwpbaseobjects.SdtSecObject_Functionalities obj4 )
      {
         obj4.gxTpr_Mode = Gx_mode;
         obj4.gxTpr_Secfunctionalitydescription = A8SecFunctionalityDescription;
         obj4.gxTpr_Secfunctionalityid = A1SecFunctionalityId;
         obj4.gxTpr_Secfunctionalityid_Z = Z1SecFunctionalityId;
         obj4.gxTpr_Secfunctionalitydescription_Z = Z8SecFunctionalityDescription;
         obj4.gxTpr_Modified = nIsMod_4;
         return  ;
      }

      public void KeyVarsToRow4( GeneXus.Programs.wwpbaseobjects.SdtSecObject_Functionalities obj4 )
      {
         obj4.gxTpr_Secfunctionalityid = A1SecFunctionalityId;
         return  ;
      }

      public void RowToVars4( GeneXus.Programs.wwpbaseobjects.SdtSecObject_Functionalities obj4 ,
                              int forceLoad )
      {
         Gx_mode = obj4.gxTpr_Mode;
         A8SecFunctionalityDescription = obj4.gxTpr_Secfunctionalitydescription;
         A1SecFunctionalityId = obj4.gxTpr_Secfunctionalityid;
         Z1SecFunctionalityId = obj4.gxTpr_Secfunctionalityid_Z;
         Z8SecFunctionalityDescription = obj4.gxTpr_Secfunctionalitydescription_Z;
         nIsMod_4 = obj4.gxTpr_Modified;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A5SecObjectName = (String)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey033( ) ;
         ScanKeyStart033( ) ;
         if ( RcdFound3 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z5SecObjectName = A5SecObjectName;
         }
         ZM033( -1) ;
         OnLoadActions033( ) ;
         AddRow033( ) ;
         bcwwpbaseobjects_SecObject.gxTpr_Functionalities.ClearCollection();
         if ( RcdFound3 == 1 )
         {
            ScanKeyStart034( ) ;
            nGXsfl_4_idx = 1;
            while ( RcdFound4 != 0 )
            {
               Z5SecObjectName = A5SecObjectName;
               Z1SecFunctionalityId = A1SecFunctionalityId;
               ZM034( -2) ;
               OnLoadActions034( ) ;
               nRcdExists_4 = 1;
               nIsMod_4 = 0;
               AddRow034( ) ;
               nGXsfl_4_idx = (short)(nGXsfl_4_idx+1);
               ScanKeyNext034( ) ;
            }
            ScanKeyEnd034( ) ;
         }
         ScanKeyEnd033( ) ;
         if ( RcdFound3 == 0 )
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
         RowToVars3( bcwwpbaseobjects_SecObject, 0) ;
         ScanKeyStart033( ) ;
         if ( RcdFound3 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z5SecObjectName = A5SecObjectName;
         }
         ZM033( -1) ;
         OnLoadActions033( ) ;
         AddRow033( ) ;
         bcwwpbaseobjects_SecObject.gxTpr_Functionalities.ClearCollection();
         if ( RcdFound3 == 1 )
         {
            ScanKeyStart034( ) ;
            nGXsfl_4_idx = 1;
            while ( RcdFound4 != 0 )
            {
               Z5SecObjectName = A5SecObjectName;
               Z1SecFunctionalityId = A1SecFunctionalityId;
               ZM034( -2) ;
               OnLoadActions034( ) ;
               nRcdExists_4 = 1;
               nIsMod_4 = 0;
               AddRow034( ) ;
               nGXsfl_4_idx = (short)(nGXsfl_4_idx+1);
               ScanKeyNext034( ) ;
            }
            ScanKeyEnd034( ) ;
         }
         ScanKeyEnd033( ) ;
         if ( RcdFound3 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey033( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert033( ) ;
         }
         else
         {
            if ( RcdFound3 == 1 )
            {
               if ( StringUtil.StrCmp(A5SecObjectName, Z5SecObjectName) != 0 )
               {
                  A5SecObjectName = Z5SecObjectName;
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
                  Update033( ) ;
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
                  if ( StringUtil.StrCmp(A5SecObjectName, Z5SecObjectName) != 0 )
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
                        Insert033( ) ;
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
                        Insert033( ) ;
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
         RowToVars3( bcwwpbaseobjects_SecObject, 0) ;
         SaveImpl( ) ;
         VarsToRow3( bcwwpbaseobjects_SecObject) ;
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
         RowToVars3( bcwwpbaseobjects_SecObject, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert033( ) ;
         AfterTrn( ) ;
         VarsToRow3( bcwwpbaseobjects_SecObject) ;
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
            GeneXus.Programs.wwpbaseobjects.SdtSecObject auxBC = new GeneXus.Programs.wwpbaseobjects.SdtSecObject(context) ;
            auxBC.Load(A5SecObjectName);
            auxBC.UpdateDirties(bcwwpbaseobjects_SecObject);
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
         RowToVars3( bcwwpbaseobjects_SecObject, 0) ;
         UpdateImpl( ) ;
         VarsToRow3( bcwwpbaseobjects_SecObject) ;
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
         RowToVars3( bcwwpbaseobjects_SecObject, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert033( ) ;
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
         VarsToRow3( bcwwpbaseobjects_SecObject) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars3( bcwwpbaseobjects_SecObject, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey033( ) ;
         if ( RcdFound3 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( StringUtil.StrCmp(A5SecObjectName, Z5SecObjectName) != 0 )
            {
               A5SecObjectName = Z5SecObjectName;
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
            if ( StringUtil.StrCmp(A5SecObjectName, Z5SecObjectName) != 0 )
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
         pr_default.close(4);
         pr_default.close(1);
         pr_default.close(14);
         context.RollbackDataStores("wwpbaseobjects.secobject_bc",pr_default);
         VarsToRow3( bcwwpbaseobjects_SecObject) ;
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
         Gx_mode = bcwwpbaseobjects_SecObject.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcwwpbaseobjects_SecObject.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcwwpbaseobjects_SecObject )
         {
            bcwwpbaseobjects_SecObject = (GeneXus.Programs.wwpbaseobjects.SdtSecObject)(sdt);
            if ( StringUtil.StrCmp(bcwwpbaseobjects_SecObject.gxTpr_Mode, "") == 0 )
            {
               bcwwpbaseobjects_SecObject.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow3( bcwwpbaseobjects_SecObject) ;
            }
            else
            {
               RowToVars3( bcwwpbaseobjects_SecObject, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcwwpbaseobjects_SecObject.gxTpr_Mode, "") == 0 )
            {
               bcwwpbaseobjects_SecObject.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars3( bcwwpbaseobjects_SecObject, 1) ;
         return  ;
      }

      public SdtSecObject SecObject_BC
      {
         get {
            return bcwwpbaseobjects_SecObject ;
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
         pr_default.close(14);
         pr_default.close(4);
      }

      public override void initialize( )
      {
         scmdbuf = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Gx_mode = "";
         Z5SecObjectName = "";
         A5SecObjectName = "";
         sMode3 = "";
         BC00037_A5SecObjectName = new String[] {""} ;
         BC00038_A5SecObjectName = new String[] {""} ;
         BC00036_A5SecObjectName = new String[] {""} ;
         BC00035_A5SecObjectName = new String[] {""} ;
         BC000311_A5SecObjectName = new String[] {""} ;
         Z8SecFunctionalityDescription = "";
         A8SecFunctionalityDescription = "";
         BC000312_A5SecObjectName = new String[] {""} ;
         BC000312_A8SecFunctionalityDescription = new String[] {""} ;
         BC000312_A1SecFunctionalityId = new long[1] ;
         BC00034_A8SecFunctionalityDescription = new String[] {""} ;
         BC000313_A5SecObjectName = new String[] {""} ;
         BC000313_A1SecFunctionalityId = new long[1] ;
         BC00033_A5SecObjectName = new String[] {""} ;
         BC00033_A1SecFunctionalityId = new long[1] ;
         sMode4 = "";
         BC00032_A5SecObjectName = new String[] {""} ;
         BC00032_A1SecFunctionalityId = new long[1] ;
         BC000316_A8SecFunctionalityDescription = new String[] {""} ;
         BC000317_A5SecObjectName = new String[] {""} ;
         BC000317_A8SecFunctionalityDescription = new String[] {""} ;
         BC000317_A1SecFunctionalityId = new long[1] ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.wwpbaseobjects.secobject_bc__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wwpbaseobjects.secobject_bc__default(),
            new Object[][] {
                new Object[] {
               BC00032_A5SecObjectName, BC00032_A1SecFunctionalityId
               }
               , new Object[] {
               BC00033_A5SecObjectName, BC00033_A1SecFunctionalityId
               }
               , new Object[] {
               BC00034_A8SecFunctionalityDescription
               }
               , new Object[] {
               BC00035_A5SecObjectName
               }
               , new Object[] {
               BC00036_A5SecObjectName
               }
               , new Object[] {
               BC00037_A5SecObjectName
               }
               , new Object[] {
               BC00038_A5SecObjectName
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000311_A5SecObjectName
               }
               , new Object[] {
               BC000312_A5SecObjectName, BC000312_A8SecFunctionalityDescription, BC000312_A1SecFunctionalityId
               }
               , new Object[] {
               BC000313_A5SecObjectName, BC000313_A1SecFunctionalityId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000316_A8SecFunctionalityDescription
               }
               , new Object[] {
               BC000317_A5SecObjectName, BC000317_A8SecFunctionalityDescription, BC000317_A1SecFunctionalityId
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
      private short nGXsfl_4_idx=1 ;
      private short nIsMod_4 ;
      private short RcdFound4 ;
      private short GX_JID ;
      private short RcdFound3 ;
      private short nRcdExists_4 ;
      private short Gxremove4 ;
      private short Gx_BScreen ;
      private int trnEnded ;
      private long Z1SecFunctionalityId ;
      private long A1SecFunctionalityId ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String sMode3 ;
      private String sMode4 ;
      private String Z5SecObjectName ;
      private String A5SecObjectName ;
      private String Z8SecFunctionalityDescription ;
      private String A8SecFunctionalityDescription ;
      private GeneXus.Programs.wwpbaseobjects.SdtSecObject bcwwpbaseobjects_SecObject ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] BC00037_A5SecObjectName ;
      private String[] BC00038_A5SecObjectName ;
      private String[] BC00036_A5SecObjectName ;
      private String[] BC00035_A5SecObjectName ;
      private String[] BC000311_A5SecObjectName ;
      private String[] BC000312_A5SecObjectName ;
      private String[] BC000312_A8SecFunctionalityDescription ;
      private long[] BC000312_A1SecFunctionalityId ;
      private String[] BC00034_A8SecFunctionalityDescription ;
      private String[] BC000313_A5SecObjectName ;
      private long[] BC000313_A1SecFunctionalityId ;
      private String[] BC00033_A5SecObjectName ;
      private long[] BC00033_A1SecFunctionalityId ;
      private String[] BC00032_A5SecObjectName ;
      private long[] BC00032_A1SecFunctionalityId ;
      private String[] BC000316_A8SecFunctionalityDescription ;
      private String[] BC000317_A5SecObjectName ;
      private String[] BC000317_A8SecFunctionalityDescription ;
      private long[] BC000317_A1SecFunctionalityId ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_datastore1 ;
   }

   public class secobject_bc__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class secobject_bc__default : DataStoreHelperBase, IDataStoreHelper
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
       ,new ForEachCursor(def[6])
       ,new UpdateCursor(def[7])
       ,new UpdateCursor(def[8])
       ,new ForEachCursor(def[9])
       ,new ForEachCursor(def[10])
       ,new ForEachCursor(def[11])
       ,new UpdateCursor(def[12])
       ,new UpdateCursor(def[13])
       ,new ForEachCursor(def[14])
       ,new ForEachCursor(def[15])
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmBC00037 ;
        prmBC00037 = new Object[] {
        new Object[] {"@SecObjectName",SqlDbType.NVarChar,120,0}
        } ;
        Object[] prmBC00038 ;
        prmBC00038 = new Object[] {
        new Object[] {"@SecObjectName",SqlDbType.NVarChar,120,0}
        } ;
        Object[] prmBC00036 ;
        prmBC00036 = new Object[] {
        new Object[] {"@SecObjectName",SqlDbType.NVarChar,120,0}
        } ;
        Object[] prmBC00035 ;
        prmBC00035 = new Object[] {
        new Object[] {"@SecObjectName",SqlDbType.NVarChar,120,0}
        } ;
        Object[] prmBC00039 ;
        prmBC00039 = new Object[] {
        new Object[] {"@SecObjectName",SqlDbType.NVarChar,120,0}
        } ;
        Object[] prmBC000310 ;
        prmBC000310 = new Object[] {
        new Object[] {"@SecObjectName",SqlDbType.NVarChar,120,0}
        } ;
        Object[] prmBC000311 ;
        prmBC000311 = new Object[] {
        new Object[] {"@SecObjectName",SqlDbType.NVarChar,120,0}
        } ;
        Object[] prmBC000312 ;
        prmBC000312 = new Object[] {
        new Object[] {"@SecObjectName",SqlDbType.NVarChar,120,0} ,
        new Object[] {"@SecFunctionalityId",SqlDbType.Decimal,10,0}
        } ;
        Object[] prmBC00034 ;
        prmBC00034 = new Object[] {
        new Object[] {"@SecFunctionalityId",SqlDbType.Decimal,10,0}
        } ;
        Object[] prmBC000313 ;
        prmBC000313 = new Object[] {
        new Object[] {"@SecObjectName",SqlDbType.NVarChar,120,0} ,
        new Object[] {"@SecFunctionalityId",SqlDbType.Decimal,10,0}
        } ;
        Object[] prmBC00033 ;
        prmBC00033 = new Object[] {
        new Object[] {"@SecObjectName",SqlDbType.NVarChar,120,0} ,
        new Object[] {"@SecFunctionalityId",SqlDbType.Decimal,10,0}
        } ;
        Object[] prmBC00032 ;
        prmBC00032 = new Object[] {
        new Object[] {"@SecObjectName",SqlDbType.NVarChar,120,0} ,
        new Object[] {"@SecFunctionalityId",SqlDbType.Decimal,10,0}
        } ;
        Object[] prmBC000314 ;
        prmBC000314 = new Object[] {
        new Object[] {"@SecObjectName",SqlDbType.NVarChar,120,0} ,
        new Object[] {"@SecFunctionalityId",SqlDbType.Decimal,10,0}
        } ;
        Object[] prmBC000315 ;
        prmBC000315 = new Object[] {
        new Object[] {"@SecObjectName",SqlDbType.NVarChar,120,0} ,
        new Object[] {"@SecFunctionalityId",SqlDbType.Decimal,10,0}
        } ;
        Object[] prmBC000316 ;
        prmBC000316 = new Object[] {
        new Object[] {"@SecFunctionalityId",SqlDbType.Decimal,10,0}
        } ;
        Object[] prmBC000317 ;
        prmBC000317 = new Object[] {
        new Object[] {"@SecObjectName",SqlDbType.NVarChar,120,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("BC00032", "SELECT [SecObjectName], [SecFunctionalityId] FROM [SecObjectFunctionalities] WITH (UPDLOCK) WHERE [SecObjectName] = @SecObjectName AND [SecFunctionalityId] = @SecFunctionalityId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00032,1,0,true,false )
           ,new CursorDef("BC00033", "SELECT [SecObjectName], [SecFunctionalityId] FROM [SecObjectFunctionalities] WITH (NOLOCK) WHERE [SecObjectName] = @SecObjectName AND [SecFunctionalityId] = @SecFunctionalityId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00033,1,0,true,false )
           ,new CursorDef("BC00034", "SELECT [SecFunctionalityDescription] FROM [SecFunctionality] WITH (NOLOCK) WHERE [SecFunctionalityId] = @SecFunctionalityId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00034,1,0,true,false )
           ,new CursorDef("BC00035", "SELECT [SecObjectName] FROM [SecObject] WITH (UPDLOCK) WHERE [SecObjectName] = @SecObjectName ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00035,1,0,true,false )
           ,new CursorDef("BC00036", "SELECT [SecObjectName] FROM [SecObject] WITH (NOLOCK) WHERE [SecObjectName] = @SecObjectName ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00036,1,0,true,false )
           ,new CursorDef("BC00037", "SELECT TM1.[SecObjectName] FROM [SecObject] TM1 WITH (NOLOCK) WHERE TM1.[SecObjectName] = @SecObjectName ORDER BY TM1.[SecObjectName]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00037,100,0,true,false )
           ,new CursorDef("BC00038", "SELECT [SecObjectName] FROM [SecObject] WITH (NOLOCK) WHERE [SecObjectName] = @SecObjectName  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00038,1,0,true,false )
           ,new CursorDef("BC00039", "INSERT INTO [SecObject]([SecObjectName]) VALUES(@SecObjectName)", GxErrorMask.GX_NOMASK,prmBC00039)
           ,new CursorDef("BC000310", "DELETE FROM [SecObject]  WHERE [SecObjectName] = @SecObjectName", GxErrorMask.GX_NOMASK,prmBC000310)
           ,new CursorDef("BC000311", "SELECT TM1.[SecObjectName] FROM [SecObject] TM1 WITH (NOLOCK) WHERE TM1.[SecObjectName] = @SecObjectName ORDER BY TM1.[SecObjectName]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000311,100,0,true,false )
           ,new CursorDef("BC000312", "SELECT T1.[SecObjectName], T2.[SecFunctionalityDescription], T1.[SecFunctionalityId] FROM ([SecObjectFunctionalities] T1 WITH (NOLOCK) INNER JOIN [SecFunctionality] T2 WITH (NOLOCK) ON T2.[SecFunctionalityId] = T1.[SecFunctionalityId]) WHERE T1.[SecObjectName] = @SecObjectName and T1.[SecFunctionalityId] = @SecFunctionalityId ORDER BY T1.[SecObjectName], T1.[SecFunctionalityId]  OPTION (FAST 11)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000312,11,0,true,false )
           ,new CursorDef("BC000313", "SELECT [SecObjectName], [SecFunctionalityId] FROM [SecObjectFunctionalities] WITH (NOLOCK) WHERE [SecObjectName] = @SecObjectName AND [SecFunctionalityId] = @SecFunctionalityId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000313,1,0,true,false )
           ,new CursorDef("BC000314", "INSERT INTO [SecObjectFunctionalities]([SecObjectName], [SecFunctionalityId]) VALUES(@SecObjectName, @SecFunctionalityId)", GxErrorMask.GX_NOMASK,prmBC000314)
           ,new CursorDef("BC000315", "DELETE FROM [SecObjectFunctionalities]  WHERE [SecObjectName] = @SecObjectName AND [SecFunctionalityId] = @SecFunctionalityId", GxErrorMask.GX_NOMASK,prmBC000315)
           ,new CursorDef("BC000316", "SELECT [SecFunctionalityDescription] FROM [SecFunctionality] WITH (NOLOCK) WHERE [SecFunctionalityId] = @SecFunctionalityId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000316,1,0,true,false )
           ,new CursorDef("BC000317", "SELECT T1.[SecObjectName], T2.[SecFunctionalityDescription], T1.[SecFunctionalityId] FROM ([SecObjectFunctionalities] T1 WITH (NOLOCK) INNER JOIN [SecFunctionality] T2 WITH (NOLOCK) ON T2.[SecFunctionalityId] = T1.[SecFunctionalityId]) WHERE T1.[SecObjectName] = @SecObjectName ORDER BY T1.[SecObjectName], T1.[SecFunctionalityId]  OPTION (FAST 11)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000317,11,0,true,false )
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
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              return;
           case 1 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              return;
           case 2 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              return;
           case 3 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              return;
           case 4 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              return;
           case 5 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              return;
           case 6 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              return;
           case 9 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              return;
           case 10 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((long[]) buf[2])[0] = rslt.getLong(3) ;
              return;
           case 11 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              return;
           case 14 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              return;
           case 15 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((long[]) buf[2])[0] = rslt.getLong(3) ;
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
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameter(2, (long)parms[1]);
              return;
           case 1 :
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameter(2, (long)parms[1]);
              return;
           case 2 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 3 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 4 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 5 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 6 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 7 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 8 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 9 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 10 :
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameter(2, (long)parms[1]);
              return;
           case 11 :
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameter(2, (long)parms[1]);
              return;
           case 12 :
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameter(2, (long)parms[1]);
              return;
           case 13 :
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameter(2, (long)parms[1]);
              return;
           case 14 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 15 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
     }
  }

}

}
