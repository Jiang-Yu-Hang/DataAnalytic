/*
               File: WWPBaseObjects.UserCustomizations_BC
        Description: User Custom
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:35:49.13
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
   public class usercustomizations_bc : GXHttpHandler, IGxSilentTrn
   {
      public usercustomizations_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public usercustomizations_bc( IGxContext context )
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
         ReadRow078( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey078( ) ;
         standaloneModal( ) ;
         AddRow078( ) ;
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
               Z16UserCustomizationsId = A16UserCustomizationsId;
               Z17UserCustomizationsKey = A17UserCustomizationsKey;
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

      protected void CONFIRM_070( )
      {
         BeforeValidate078( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls078( ) ;
            }
            else
            {
               CheckExtendedTable078( ) ;
               if ( AnyError == 0 )
               {
               }
               CloseExtendedTableCursors078( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void ZM078( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
         }
         if ( GX_JID == -1 )
         {
            Z16UserCustomizationsId = A16UserCustomizationsId;
            Z17UserCustomizationsKey = A17UserCustomizationsKey;
            Z18UserCustomizationsValue = A18UserCustomizationsValue;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load078( )
      {
         /* Using cursor BC00074 */
         pr_default.execute(2, new Object[] {A16UserCustomizationsId, A17UserCustomizationsKey});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound8 = 1;
            A18UserCustomizationsValue = BC00074_A18UserCustomizationsValue[0];
            ZM078( -1) ;
         }
         pr_default.close(2);
         OnLoadActions078( ) ;
      }

      protected void OnLoadActions078( )
      {
      }

      protected void CheckExtendedTable078( )
      {
         standaloneModal( ) ;
      }

      protected void CloseExtendedTableCursors078( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey078( )
      {
         /* Using cursor BC00075 */
         pr_default.execute(3, new Object[] {A16UserCustomizationsId, A17UserCustomizationsKey});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound8 = 1;
         }
         else
         {
            RcdFound8 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC00073 */
         pr_default.execute(1, new Object[] {A16UserCustomizationsId, A17UserCustomizationsKey});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM078( 1) ;
            RcdFound8 = 1;
            A16UserCustomizationsId = BC00073_A16UserCustomizationsId[0];
            A17UserCustomizationsKey = BC00073_A17UserCustomizationsKey[0];
            A18UserCustomizationsValue = BC00073_A18UserCustomizationsValue[0];
            Z16UserCustomizationsId = A16UserCustomizationsId;
            Z17UserCustomizationsKey = A17UserCustomizationsKey;
            sMode8 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load078( ) ;
            if ( AnyError == 1 )
            {
               RcdFound8 = 0;
               InitializeNonKey078( ) ;
            }
            Gx_mode = sMode8;
         }
         else
         {
            RcdFound8 = 0;
            InitializeNonKey078( ) ;
            sMode8 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode8;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey078( ) ;
         if ( RcdFound8 == 0 )
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
         CONFIRM_070( ) ;
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

      protected void CheckOptimisticConcurrency078( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC00072 */
            pr_default.execute(0, new Object[] {A16UserCustomizationsId, A17UserCustomizationsKey});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"UserCustomizations"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"UserCustomizations"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert078( )
      {
         BeforeValidate078( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable078( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM078( 0) ;
            CheckOptimisticConcurrency078( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm078( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert078( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00076 */
                     pr_default.execute(4, new Object[] {A16UserCustomizationsId, A17UserCustomizationsKey, A18UserCustomizationsValue});
                     pr_default.close(4);
                     dsDefault.SmartCacheProvider.SetUpdated("UserCustomizations") ;
                     if ( (pr_default.getStatus(4) == 1) )
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
               Load078( ) ;
            }
            EndLevel078( ) ;
         }
         CloseExtendedTableCursors078( ) ;
      }

      protected void Update078( )
      {
         BeforeValidate078( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable078( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency078( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm078( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate078( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00077 */
                     pr_default.execute(5, new Object[] {A18UserCustomizationsValue, A16UserCustomizationsId, A17UserCustomizationsKey});
                     pr_default.close(5);
                     dsDefault.SmartCacheProvider.SetUpdated("UserCustomizations") ;
                     if ( (pr_default.getStatus(5) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"UserCustomizations"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate078( ) ;
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
            EndLevel078( ) ;
         }
         CloseExtendedTableCursors078( ) ;
      }

      protected void DeferredUpdate078( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate078( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency078( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls078( ) ;
            AfterConfirm078( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete078( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC00078 */
                  pr_default.execute(6, new Object[] {A16UserCustomizationsId, A17UserCustomizationsKey});
                  pr_default.close(6);
                  dsDefault.SmartCacheProvider.SetUpdated("UserCustomizations") ;
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
         sMode8 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel078( ) ;
         Gx_mode = sMode8;
      }

      protected void OnDeleteControls078( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel078( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete078( ) ;
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

      public void ScanKeyStart078( )
      {
         /* Using cursor BC00079 */
         pr_default.execute(7, new Object[] {A16UserCustomizationsId, A17UserCustomizationsKey});
         RcdFound8 = 0;
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound8 = 1;
            A16UserCustomizationsId = BC00079_A16UserCustomizationsId[0];
            A17UserCustomizationsKey = BC00079_A17UserCustomizationsKey[0];
            A18UserCustomizationsValue = BC00079_A18UserCustomizationsValue[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext078( )
      {
         /* Scan next routine */
         pr_default.readNext(7);
         RcdFound8 = 0;
         ScanKeyLoad078( ) ;
      }

      protected void ScanKeyLoad078( )
      {
         sMode8 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound8 = 1;
            A16UserCustomizationsId = BC00079_A16UserCustomizationsId[0];
            A17UserCustomizationsKey = BC00079_A17UserCustomizationsKey[0];
            A18UserCustomizationsValue = BC00079_A18UserCustomizationsValue[0];
         }
         Gx_mode = sMode8;
      }

      protected void ScanKeyEnd078( )
      {
         pr_default.close(7);
      }

      protected void AfterConfirm078( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert078( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate078( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete078( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete078( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate078( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes078( )
      {
      }

      protected void send_integrity_lvl_hashes078( )
      {
      }

      protected void AddRow078( )
      {
         VarsToRow8( bcwwpbaseobjects_UserCustomizations) ;
      }

      protected void ReadRow078( )
      {
         RowToVars8( bcwwpbaseobjects_UserCustomizations, 1) ;
      }

      protected void InitializeNonKey078( )
      {
         A18UserCustomizationsValue = "";
      }

      protected void InitAll078( )
      {
         A16UserCustomizationsId = 0;
         A17UserCustomizationsKey = "";
         InitializeNonKey078( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow8( GeneXus.Programs.wwpbaseobjects.SdtUserCustomizations obj8 )
      {
         obj8.gxTpr_Mode = Gx_mode;
         obj8.gxTpr_Usercustomizationsvalue = A18UserCustomizationsValue;
         obj8.gxTpr_Usercustomizationsid = A16UserCustomizationsId;
         obj8.gxTpr_Usercustomizationskey = A17UserCustomizationsKey;
         obj8.gxTpr_Usercustomizationsid_Z = Z16UserCustomizationsId;
         obj8.gxTpr_Usercustomizationskey_Z = Z17UserCustomizationsKey;
         obj8.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow8( GeneXus.Programs.wwpbaseobjects.SdtUserCustomizations obj8 )
      {
         obj8.gxTpr_Usercustomizationsid = A16UserCustomizationsId;
         obj8.gxTpr_Usercustomizationskey = A17UserCustomizationsKey;
         return  ;
      }

      public void RowToVars8( GeneXus.Programs.wwpbaseobjects.SdtUserCustomizations obj8 ,
                              int forceLoad )
      {
         Gx_mode = obj8.gxTpr_Mode;
         A18UserCustomizationsValue = obj8.gxTpr_Usercustomizationsvalue;
         A16UserCustomizationsId = obj8.gxTpr_Usercustomizationsid;
         A17UserCustomizationsKey = obj8.gxTpr_Usercustomizationskey;
         Z16UserCustomizationsId = obj8.gxTpr_Usercustomizationsid_Z;
         Z17UserCustomizationsKey = obj8.gxTpr_Usercustomizationskey_Z;
         Gx_mode = obj8.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A16UserCustomizationsId = (int)getParm(obj,0);
         A17UserCustomizationsKey = (String)getParm(obj,1);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey078( ) ;
         ScanKeyStart078( ) ;
         if ( RcdFound8 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z16UserCustomizationsId = A16UserCustomizationsId;
            Z17UserCustomizationsKey = A17UserCustomizationsKey;
         }
         ZM078( -1) ;
         OnLoadActions078( ) ;
         AddRow078( ) ;
         ScanKeyEnd078( ) ;
         if ( RcdFound8 == 0 )
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
         RowToVars8( bcwwpbaseobjects_UserCustomizations, 0) ;
         ScanKeyStart078( ) ;
         if ( RcdFound8 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z16UserCustomizationsId = A16UserCustomizationsId;
            Z17UserCustomizationsKey = A17UserCustomizationsKey;
         }
         ZM078( -1) ;
         OnLoadActions078( ) ;
         AddRow078( ) ;
         ScanKeyEnd078( ) ;
         if ( RcdFound8 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey078( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert078( ) ;
         }
         else
         {
            if ( RcdFound8 == 1 )
            {
               if ( ( A16UserCustomizationsId != Z16UserCustomizationsId ) || ( StringUtil.StrCmp(A17UserCustomizationsKey, Z17UserCustomizationsKey) != 0 ) )
               {
                  A16UserCustomizationsId = Z16UserCustomizationsId;
                  A17UserCustomizationsKey = Z17UserCustomizationsKey;
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
                  Update078( ) ;
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
                  if ( ( A16UserCustomizationsId != Z16UserCustomizationsId ) || ( StringUtil.StrCmp(A17UserCustomizationsKey, Z17UserCustomizationsKey) != 0 ) )
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
                        Insert078( ) ;
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
                        Insert078( ) ;
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
         RowToVars8( bcwwpbaseobjects_UserCustomizations, 0) ;
         SaveImpl( ) ;
         VarsToRow8( bcwwpbaseobjects_UserCustomizations) ;
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
         RowToVars8( bcwwpbaseobjects_UserCustomizations, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert078( ) ;
         AfterTrn( ) ;
         VarsToRow8( bcwwpbaseobjects_UserCustomizations) ;
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
            GeneXus.Programs.wwpbaseobjects.SdtUserCustomizations auxBC = new GeneXus.Programs.wwpbaseobjects.SdtUserCustomizations(context) ;
            auxBC.Load(A16UserCustomizationsId, A17UserCustomizationsKey);
            auxBC.UpdateDirties(bcwwpbaseobjects_UserCustomizations);
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
         RowToVars8( bcwwpbaseobjects_UserCustomizations, 0) ;
         UpdateImpl( ) ;
         VarsToRow8( bcwwpbaseobjects_UserCustomizations) ;
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
         RowToVars8( bcwwpbaseobjects_UserCustomizations, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert078( ) ;
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
         VarsToRow8( bcwwpbaseobjects_UserCustomizations) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars8( bcwwpbaseobjects_UserCustomizations, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey078( ) ;
         if ( RcdFound8 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( ( A16UserCustomizationsId != Z16UserCustomizationsId ) || ( StringUtil.StrCmp(A17UserCustomizationsKey, Z17UserCustomizationsKey) != 0 ) )
            {
               A16UserCustomizationsId = Z16UserCustomizationsId;
               A17UserCustomizationsKey = Z17UserCustomizationsKey;
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
            if ( ( A16UserCustomizationsId != Z16UserCustomizationsId ) || ( StringUtil.StrCmp(A17UserCustomizationsKey, Z17UserCustomizationsKey) != 0 ) )
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
         context.RollbackDataStores("wwpbaseobjects.usercustomizations_bc",pr_default);
         VarsToRow8( bcwwpbaseobjects_UserCustomizations) ;
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
         Gx_mode = bcwwpbaseobjects_UserCustomizations.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcwwpbaseobjects_UserCustomizations.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcwwpbaseobjects_UserCustomizations )
         {
            bcwwpbaseobjects_UserCustomizations = (GeneXus.Programs.wwpbaseobjects.SdtUserCustomizations)(sdt);
            if ( StringUtil.StrCmp(bcwwpbaseobjects_UserCustomizations.gxTpr_Mode, "") == 0 )
            {
               bcwwpbaseobjects_UserCustomizations.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow8( bcwwpbaseobjects_UserCustomizations) ;
            }
            else
            {
               RowToVars8( bcwwpbaseobjects_UserCustomizations, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcwwpbaseobjects_UserCustomizations.gxTpr_Mode, "") == 0 )
            {
               bcwwpbaseobjects_UserCustomizations.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars8( bcwwpbaseobjects_UserCustomizations, 1) ;
         return  ;
      }

      public SdtUserCustomizations UserCustomizations_BC
      {
         get {
            return bcwwpbaseobjects_UserCustomizations ;
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
         Z17UserCustomizationsKey = "";
         A17UserCustomizationsKey = "";
         Z18UserCustomizationsValue = "";
         A18UserCustomizationsValue = "";
         BC00074_A16UserCustomizationsId = new int[1] ;
         BC00074_A17UserCustomizationsKey = new String[] {""} ;
         BC00074_A18UserCustomizationsValue = new String[] {""} ;
         BC00075_A16UserCustomizationsId = new int[1] ;
         BC00075_A17UserCustomizationsKey = new String[] {""} ;
         BC00073_A16UserCustomizationsId = new int[1] ;
         BC00073_A17UserCustomizationsKey = new String[] {""} ;
         BC00073_A18UserCustomizationsValue = new String[] {""} ;
         sMode8 = "";
         BC00072_A16UserCustomizationsId = new int[1] ;
         BC00072_A17UserCustomizationsKey = new String[] {""} ;
         BC00072_A18UserCustomizationsValue = new String[] {""} ;
         BC00079_A16UserCustomizationsId = new int[1] ;
         BC00079_A17UserCustomizationsKey = new String[] {""} ;
         BC00079_A18UserCustomizationsValue = new String[] {""} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.wwpbaseobjects.usercustomizations_bc__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wwpbaseobjects.usercustomizations_bc__default(),
            new Object[][] {
                new Object[] {
               BC00072_A16UserCustomizationsId, BC00072_A17UserCustomizationsKey, BC00072_A18UserCustomizationsValue
               }
               , new Object[] {
               BC00073_A16UserCustomizationsId, BC00073_A17UserCustomizationsKey, BC00073_A18UserCustomizationsValue
               }
               , new Object[] {
               BC00074_A16UserCustomizationsId, BC00074_A17UserCustomizationsKey, BC00074_A18UserCustomizationsValue
               }
               , new Object[] {
               BC00075_A16UserCustomizationsId, BC00075_A17UserCustomizationsKey
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC00079_A16UserCustomizationsId, BC00079_A17UserCustomizationsKey, BC00079_A18UserCustomizationsValue
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
      private short RcdFound8 ;
      private int trnEnded ;
      private int Z16UserCustomizationsId ;
      private int A16UserCustomizationsId ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String sMode8 ;
      private String Z18UserCustomizationsValue ;
      private String A18UserCustomizationsValue ;
      private String Z17UserCustomizationsKey ;
      private String A17UserCustomizationsKey ;
      private GeneXus.Programs.wwpbaseobjects.SdtUserCustomizations bcwwpbaseobjects_UserCustomizations ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] BC00074_A16UserCustomizationsId ;
      private String[] BC00074_A17UserCustomizationsKey ;
      private String[] BC00074_A18UserCustomizationsValue ;
      private int[] BC00075_A16UserCustomizationsId ;
      private String[] BC00075_A17UserCustomizationsKey ;
      private int[] BC00073_A16UserCustomizationsId ;
      private String[] BC00073_A17UserCustomizationsKey ;
      private String[] BC00073_A18UserCustomizationsValue ;
      private int[] BC00072_A16UserCustomizationsId ;
      private String[] BC00072_A17UserCustomizationsKey ;
      private String[] BC00072_A18UserCustomizationsValue ;
      private int[] BC00079_A16UserCustomizationsId ;
      private String[] BC00079_A17UserCustomizationsKey ;
      private String[] BC00079_A18UserCustomizationsValue ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_datastore1 ;
   }

   public class usercustomizations_bc__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class usercustomizations_bc__default : DataStoreHelperBase, IDataStoreHelper
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
        Object[] prmBC00074 ;
        prmBC00074 = new Object[] {
        new Object[] {"@UserCustomizationsId",SqlDbType.Int,6,0} ,
        new Object[] {"@UserCustomizationsKey",SqlDbType.NVarChar,200,0}
        } ;
        Object[] prmBC00075 ;
        prmBC00075 = new Object[] {
        new Object[] {"@UserCustomizationsId",SqlDbType.Int,6,0} ,
        new Object[] {"@UserCustomizationsKey",SqlDbType.NVarChar,200,0}
        } ;
        Object[] prmBC00073 ;
        prmBC00073 = new Object[] {
        new Object[] {"@UserCustomizationsId",SqlDbType.Int,6,0} ,
        new Object[] {"@UserCustomizationsKey",SqlDbType.NVarChar,200,0}
        } ;
        Object[] prmBC00072 ;
        prmBC00072 = new Object[] {
        new Object[] {"@UserCustomizationsId",SqlDbType.Int,6,0} ,
        new Object[] {"@UserCustomizationsKey",SqlDbType.NVarChar,200,0}
        } ;
        Object[] prmBC00076 ;
        prmBC00076 = new Object[] {
        new Object[] {"@UserCustomizationsId",SqlDbType.Int,6,0} ,
        new Object[] {"@UserCustomizationsKey",SqlDbType.NVarChar,200,0} ,
        new Object[] {"@UserCustomizationsValue",SqlDbType.NVarChar,2097152,0}
        } ;
        Object[] prmBC00077 ;
        prmBC00077 = new Object[] {
        new Object[] {"@UserCustomizationsValue",SqlDbType.NVarChar,2097152,0} ,
        new Object[] {"@UserCustomizationsId",SqlDbType.Int,6,0} ,
        new Object[] {"@UserCustomizationsKey",SqlDbType.NVarChar,200,0}
        } ;
        Object[] prmBC00078 ;
        prmBC00078 = new Object[] {
        new Object[] {"@UserCustomizationsId",SqlDbType.Int,6,0} ,
        new Object[] {"@UserCustomizationsKey",SqlDbType.NVarChar,200,0}
        } ;
        Object[] prmBC00079 ;
        prmBC00079 = new Object[] {
        new Object[] {"@UserCustomizationsId",SqlDbType.Int,6,0} ,
        new Object[] {"@UserCustomizationsKey",SqlDbType.NVarChar,200,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("BC00072", "SELECT [UserCustomizationsId], [UserCustomizationsKey], [UserCustomizationsValue] FROM [UserCustomizations] WITH (UPDLOCK) WHERE [UserCustomizationsId] = @UserCustomizationsId AND [UserCustomizationsKey] = @UserCustomizationsKey ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00072,1,0,true,false )
           ,new CursorDef("BC00073", "SELECT [UserCustomizationsId], [UserCustomizationsKey], [UserCustomizationsValue] FROM [UserCustomizations] WITH (NOLOCK) WHERE [UserCustomizationsId] = @UserCustomizationsId AND [UserCustomizationsKey] = @UserCustomizationsKey ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00073,1,0,true,false )
           ,new CursorDef("BC00074", "SELECT TM1.[UserCustomizationsId], TM1.[UserCustomizationsKey], TM1.[UserCustomizationsValue] FROM [UserCustomizations] TM1 WITH (NOLOCK) WHERE TM1.[UserCustomizationsId] = @UserCustomizationsId and TM1.[UserCustomizationsKey] = @UserCustomizationsKey ORDER BY TM1.[UserCustomizationsId], TM1.[UserCustomizationsKey]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00074,100,0,true,false )
           ,new CursorDef("BC00075", "SELECT [UserCustomizationsId], [UserCustomizationsKey] FROM [UserCustomizations] WITH (NOLOCK) WHERE [UserCustomizationsId] = @UserCustomizationsId AND [UserCustomizationsKey] = @UserCustomizationsKey  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00075,1,0,true,false )
           ,new CursorDef("BC00076", "INSERT INTO [UserCustomizations]([UserCustomizationsId], [UserCustomizationsKey], [UserCustomizationsValue]) VALUES(@UserCustomizationsId, @UserCustomizationsKey, @UserCustomizationsValue)", GxErrorMask.GX_NOMASK,prmBC00076)
           ,new CursorDef("BC00077", "UPDATE [UserCustomizations] SET [UserCustomizationsValue]=@UserCustomizationsValue  WHERE [UserCustomizationsId] = @UserCustomizationsId AND [UserCustomizationsKey] = @UserCustomizationsKey", GxErrorMask.GX_NOMASK,prmBC00077)
           ,new CursorDef("BC00078", "DELETE FROM [UserCustomizations]  WHERE [UserCustomizationsId] = @UserCustomizationsId AND [UserCustomizationsKey] = @UserCustomizationsKey", GxErrorMask.GX_NOMASK,prmBC00078)
           ,new CursorDef("BC00079", "SELECT TM1.[UserCustomizationsId], TM1.[UserCustomizationsKey], TM1.[UserCustomizationsValue] FROM [UserCustomizations] TM1 WITH (NOLOCK) WHERE TM1.[UserCustomizationsId] = @UserCustomizationsId and TM1.[UserCustomizationsKey] = @UserCustomizationsKey ORDER BY TM1.[UserCustomizationsId], TM1.[UserCustomizationsKey]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00079,100,0,true,false )
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
              ((String[]) buf[2])[0] = rslt.getLongVarchar(3) ;
              return;
           case 1 :
              ((int[]) buf[0])[0] = rslt.getInt(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((String[]) buf[2])[0] = rslt.getLongVarchar(3) ;
              return;
           case 2 :
              ((int[]) buf[0])[0] = rslt.getInt(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((String[]) buf[2])[0] = rslt.getLongVarchar(3) ;
              return;
           case 3 :
              ((int[]) buf[0])[0] = rslt.getInt(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              return;
           case 7 :
              ((int[]) buf[0])[0] = rslt.getInt(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((String[]) buf[2])[0] = rslt.getLongVarchar(3) ;
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
              stmt.SetParameter(2, (String)parms[1]);
              return;
           case 1 :
              stmt.SetParameter(1, (int)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              return;
           case 2 :
              stmt.SetParameter(1, (int)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              return;
           case 3 :
              stmt.SetParameter(1, (int)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              return;
           case 4 :
              stmt.SetParameter(1, (int)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              stmt.SetParameter(3, (String)parms[2]);
              return;
           case 5 :
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameter(2, (int)parms[1]);
              stmt.SetParameter(3, (String)parms[2]);
              return;
           case 6 :
              stmt.SetParameter(1, (int)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              return;
           case 7 :
              stmt.SetParameter(1, (int)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              return;
     }
  }

}

}
