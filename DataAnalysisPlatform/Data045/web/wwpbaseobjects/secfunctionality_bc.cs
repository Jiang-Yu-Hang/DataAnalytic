/*
               File: WWPBaseObjects.SecFunctionality_BC
        Description: 权限
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:6:22.54
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
   public class secfunctionality_bc : GXHttpHandler, IGxSilentTrn
   {
      public secfunctionality_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public secfunctionality_bc( IGxContext context )
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
         ReadRow011( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey011( ) ;
         standaloneModal( ) ;
         AddRow011( ) ;
         Gx_mode = "INS";
         return  ;
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E11012 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               Z1SecFunctionalityId = A1SecFunctionalityId;
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

      protected void CONFIRM_010( )
      {
         BeforeValidate011( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls011( ) ;
            }
            else
            {
               CheckExtendedTable011( ) ;
               if ( AnyError == 0 )
               {
                  ZM011( 5) ;
               }
               CloseExtendedTableCursors011( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void E12012( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV18WWPContext) ;
         AV10TrnContext.FromXml(AV11WebSession.Get("TrnContext"), null, "WWPTransactionContext", "DataAnalysisPlatform");
         if ( ( StringUtil.StrCmp(AV10TrnContext.gxTpr_Transactionname, AV19Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV20GXV1 = 1;
            while ( AV20GXV1 <= AV10TrnContext.gxTpr_Attributes.Count )
            {
               AV13TrnContextAtt = ((GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute)AV10TrnContext.gxTpr_Attributes.Item(AV20GXV1));
               if ( StringUtil.StrCmp(AV13TrnContextAtt.gxTpr_Attributename, "SecParentFunctionalityId") == 0 )
               {
                  AV12Insert_SecParentFunctionalityId = (long)(NumberUtil.Val( AV13TrnContextAtt.gxTpr_Attributevalue, "."));
               }
               AV20GXV1 = (int)(AV20GXV1+1);
            }
         }
      }

      protected void E11012( )
      {
         /* After Trn Routine */
      }

      protected void ZM011( short GX_JID )
      {
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            Z3SecFunctionalityKey = A3SecFunctionalityKey;
            Z8SecFunctionalityDescription = A8SecFunctionalityDescription;
            Z9SecFunctionalityType = A9SecFunctionalityType;
            Z7SecFunctionalityActive = A7SecFunctionalityActive;
            Z2SecParentFunctionalityId = A2SecParentFunctionalityId;
         }
         if ( ( GX_JID == 5 ) || ( GX_JID == 0 ) )
         {
            Z11SecParentFunctionalityDescription = A11SecParentFunctionalityDescription;
         }
         if ( GX_JID == -3 )
         {
            Z1SecFunctionalityId = A1SecFunctionalityId;
            Z3SecFunctionalityKey = A3SecFunctionalityKey;
            Z8SecFunctionalityDescription = A8SecFunctionalityDescription;
            Z9SecFunctionalityType = A9SecFunctionalityType;
            Z7SecFunctionalityActive = A7SecFunctionalityActive;
            Z2SecParentFunctionalityId = A2SecParentFunctionalityId;
            Z11SecParentFunctionalityDescription = A11SecParentFunctionalityDescription;
         }
      }

      protected void standaloneNotModal( )
      {
         AV19Pgmname = "WWPBaseObjects.SecFunctionality_BC";
      }

      protected void standaloneModal( )
      {
      }

      protected void Load011( )
      {
         /* Using cursor BC00015 */
         pr_default.execute(3, new Object[] {A1SecFunctionalityId});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound1 = 1;
            A3SecFunctionalityKey = BC00015_A3SecFunctionalityKey[0];
            A8SecFunctionalityDescription = BC00015_A8SecFunctionalityDescription[0];
            A9SecFunctionalityType = BC00015_A9SecFunctionalityType[0];
            A11SecParentFunctionalityDescription = BC00015_A11SecParentFunctionalityDescription[0];
            A7SecFunctionalityActive = BC00015_A7SecFunctionalityActive[0];
            A2SecParentFunctionalityId = BC00015_A2SecParentFunctionalityId[0];
            n2SecParentFunctionalityId = BC00015_n2SecParentFunctionalityId[0];
            ZM011( -3) ;
         }
         pr_default.close(3);
         OnLoadActions011( ) ;
      }

      protected void OnLoadActions011( )
      {
      }

      protected void CheckExtendedTable011( )
      {
         standaloneModal( ) ;
         /* Using cursor BC00016 */
         pr_default.execute(4, new Object[] {A3SecFunctionalityKey, A1SecFunctionalityId});
         if ( (pr_default.getStatus(4) != 101) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_1004", new   object[]  {"权限名称"}), 1, "");
            AnyError = 1;
         }
         pr_default.close(4);
         /* Using cursor BC00014 */
         pr_default.execute(2, new Object[] {n2SecParentFunctionalityId, A2SecParentFunctionalityId});
         if ( (pr_default.getStatus(2) == 101) )
         {
            if ( ! ( (0==A2SecParentFunctionalityId) ) )
            {
               GX_msglist.addItem("不匹配'Sec Functionality Functionality'", "ForeignKeyNotFound", 1, "SECPARENTFUNCTIONALITYID");
               AnyError = 1;
            }
         }
         A11SecParentFunctionalityDescription = BC00014_A11SecParentFunctionalityDescription[0];
         pr_default.close(2);
      }

      protected void CloseExtendedTableCursors011( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey011( )
      {
         /* Using cursor BC00017 */
         pr_default.execute(5, new Object[] {A1SecFunctionalityId});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound1 = 1;
         }
         else
         {
            RcdFound1 = 0;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC00013 */
         pr_default.execute(1, new Object[] {A1SecFunctionalityId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM011( 3) ;
            RcdFound1 = 1;
            A1SecFunctionalityId = BC00013_A1SecFunctionalityId[0];
            A3SecFunctionalityKey = BC00013_A3SecFunctionalityKey[0];
            A8SecFunctionalityDescription = BC00013_A8SecFunctionalityDescription[0];
            A9SecFunctionalityType = BC00013_A9SecFunctionalityType[0];
            A7SecFunctionalityActive = BC00013_A7SecFunctionalityActive[0];
            A2SecParentFunctionalityId = BC00013_A2SecParentFunctionalityId[0];
            n2SecParentFunctionalityId = BC00013_n2SecParentFunctionalityId[0];
            Z1SecFunctionalityId = A1SecFunctionalityId;
            sMode1 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load011( ) ;
            if ( AnyError == 1 )
            {
               RcdFound1 = 0;
               InitializeNonKey011( ) ;
            }
            Gx_mode = sMode1;
         }
         else
         {
            RcdFound1 = 0;
            InitializeNonKey011( ) ;
            sMode1 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode1;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey011( ) ;
         if ( RcdFound1 == 0 )
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
         CONFIRM_010( ) ;
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

      protected void CheckOptimisticConcurrency011( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC00012 */
            pr_default.execute(0, new Object[] {A1SecFunctionalityId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SecFunctionality"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z3SecFunctionalityKey, BC00012_A3SecFunctionalityKey[0]) != 0 ) || ( StringUtil.StrCmp(Z8SecFunctionalityDescription, BC00012_A8SecFunctionalityDescription[0]) != 0 ) || ( Z9SecFunctionalityType != BC00012_A9SecFunctionalityType[0] ) || ( Z7SecFunctionalityActive != BC00012_A7SecFunctionalityActive[0] ) || ( Z2SecParentFunctionalityId != BC00012_A2SecParentFunctionalityId[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"SecFunctionality"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert011( )
      {
         BeforeValidate011( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable011( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM011( 0) ;
            CheckOptimisticConcurrency011( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm011( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert011( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00018 */
                     pr_default.execute(6, new Object[] {A3SecFunctionalityKey, A8SecFunctionalityDescription, A9SecFunctionalityType, A7SecFunctionalityActive, n2SecParentFunctionalityId, A2SecParentFunctionalityId});
                     A1SecFunctionalityId = BC00018_A1SecFunctionalityId[0];
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("SecFunctionality") ;
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
               Load011( ) ;
            }
            EndLevel011( ) ;
         }
         CloseExtendedTableCursors011( ) ;
      }

      protected void Update011( )
      {
         BeforeValidate011( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable011( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency011( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm011( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate011( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00019 */
                     pr_default.execute(7, new Object[] {A3SecFunctionalityKey, A8SecFunctionalityDescription, A9SecFunctionalityType, A7SecFunctionalityActive, n2SecParentFunctionalityId, A2SecParentFunctionalityId, A1SecFunctionalityId});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("SecFunctionality") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"SecFunctionality"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate011( ) ;
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
            EndLevel011( ) ;
         }
         CloseExtendedTableCursors011( ) ;
      }

      protected void DeferredUpdate011( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate011( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency011( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls011( ) ;
            AfterConfirm011( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete011( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC000110 */
                  pr_default.execute(8, new Object[] {A1SecFunctionalityId});
                  pr_default.close(8);
                  dsDefault.SmartCacheProvider.SetUpdated("SecFunctionality") ;
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
         sMode1 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel011( ) ;
         Gx_mode = sMode1;
      }

      protected void OnDeleteControls011( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor BC000111 */
            pr_default.execute(9, new Object[] {n2SecParentFunctionalityId, A2SecParentFunctionalityId});
            A11SecParentFunctionalityDescription = BC000111_A11SecParentFunctionalityDescription[0];
            pr_default.close(9);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor BC000112 */
            pr_default.execute(10, new Object[] {A1SecFunctionalityId});
            if ( (pr_default.getStatus(10) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Functionality"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(10);
            /* Using cursor BC000113 */
            pr_default.execute(11, new Object[] {A1SecFunctionalityId});
            if ( (pr_default.getStatus(11) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Functionalities"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(11);
            /* Using cursor BC000114 */
            pr_default.execute(12, new Object[] {A1SecFunctionalityId});
            if ( (pr_default.getStatus(12) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Functionality Role"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(12);
         }
      }

      protected void EndLevel011( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete011( ) ;
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

      public void ScanKeyStart011( )
      {
         /* Scan By routine */
         /* Using cursor BC000115 */
         pr_default.execute(13, new Object[] {A1SecFunctionalityId});
         RcdFound1 = 0;
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound1 = 1;
            A1SecFunctionalityId = BC000115_A1SecFunctionalityId[0];
            A3SecFunctionalityKey = BC000115_A3SecFunctionalityKey[0];
            A8SecFunctionalityDescription = BC000115_A8SecFunctionalityDescription[0];
            A9SecFunctionalityType = BC000115_A9SecFunctionalityType[0];
            A11SecParentFunctionalityDescription = BC000115_A11SecParentFunctionalityDescription[0];
            A7SecFunctionalityActive = BC000115_A7SecFunctionalityActive[0];
            A2SecParentFunctionalityId = BC000115_A2SecParentFunctionalityId[0];
            n2SecParentFunctionalityId = BC000115_n2SecParentFunctionalityId[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext011( )
      {
         /* Scan next routine */
         pr_default.readNext(13);
         RcdFound1 = 0;
         ScanKeyLoad011( ) ;
      }

      protected void ScanKeyLoad011( )
      {
         sMode1 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound1 = 1;
            A1SecFunctionalityId = BC000115_A1SecFunctionalityId[0];
            A3SecFunctionalityKey = BC000115_A3SecFunctionalityKey[0];
            A8SecFunctionalityDescription = BC000115_A8SecFunctionalityDescription[0];
            A9SecFunctionalityType = BC000115_A9SecFunctionalityType[0];
            A11SecParentFunctionalityDescription = BC000115_A11SecParentFunctionalityDescription[0];
            A7SecFunctionalityActive = BC000115_A7SecFunctionalityActive[0];
            A2SecParentFunctionalityId = BC000115_A2SecParentFunctionalityId[0];
            n2SecParentFunctionalityId = BC000115_n2SecParentFunctionalityId[0];
         }
         Gx_mode = sMode1;
      }

      protected void ScanKeyEnd011( )
      {
         pr_default.close(13);
      }

      protected void AfterConfirm011( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert011( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate011( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete011( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete011( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate011( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes011( )
      {
      }

      protected void send_integrity_lvl_hashes011( )
      {
      }

      protected void AddRow011( )
      {
         VarsToRow1( bcwwpbaseobjects_SecFunctionality) ;
      }

      protected void ReadRow011( )
      {
         RowToVars1( bcwwpbaseobjects_SecFunctionality, 1) ;
      }

      protected void InitializeNonKey011( )
      {
         A3SecFunctionalityKey = "";
         A8SecFunctionalityDescription = "";
         A9SecFunctionalityType = 0;
         A2SecParentFunctionalityId = 0;
         n2SecParentFunctionalityId = false;
         A11SecParentFunctionalityDescription = "";
         A7SecFunctionalityActive = false;
         Z3SecFunctionalityKey = "";
         Z8SecFunctionalityDescription = "";
         Z9SecFunctionalityType = 0;
         Z7SecFunctionalityActive = false;
         Z2SecParentFunctionalityId = 0;
      }

      protected void InitAll011( )
      {
         A1SecFunctionalityId = 0;
         InitializeNonKey011( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow1( GeneXus.Programs.wwpbaseobjects.SdtSecFunctionality obj1 )
      {
         obj1.gxTpr_Mode = Gx_mode;
         obj1.gxTpr_Secfunctionalitykey = A3SecFunctionalityKey;
         obj1.gxTpr_Secfunctionalitydescription = A8SecFunctionalityDescription;
         obj1.gxTpr_Secfunctionalitytype = A9SecFunctionalityType;
         obj1.gxTpr_Secparentfunctionalityid = A2SecParentFunctionalityId;
         obj1.gxTpr_Secparentfunctionalitydescription = A11SecParentFunctionalityDescription;
         obj1.gxTpr_Secfunctionalityactive = A7SecFunctionalityActive;
         obj1.gxTpr_Secfunctionalityid = A1SecFunctionalityId;
         obj1.gxTpr_Secfunctionalityid_Z = Z1SecFunctionalityId;
         obj1.gxTpr_Secfunctionalitykey_Z = Z3SecFunctionalityKey;
         obj1.gxTpr_Secfunctionalitydescription_Z = Z8SecFunctionalityDescription;
         obj1.gxTpr_Secfunctionalitytype_Z = Z9SecFunctionalityType;
         obj1.gxTpr_Secparentfunctionalityid_Z = Z2SecParentFunctionalityId;
         obj1.gxTpr_Secparentfunctionalitydescription_Z = Z11SecParentFunctionalityDescription;
         obj1.gxTpr_Secfunctionalityactive_Z = Z7SecFunctionalityActive;
         obj1.gxTpr_Secparentfunctionalityid_N = (short)(Convert.ToInt16(n2SecParentFunctionalityId));
         obj1.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow1( GeneXus.Programs.wwpbaseobjects.SdtSecFunctionality obj1 )
      {
         obj1.gxTpr_Secfunctionalityid = A1SecFunctionalityId;
         return  ;
      }

      public void RowToVars1( GeneXus.Programs.wwpbaseobjects.SdtSecFunctionality obj1 ,
                              int forceLoad )
      {
         Gx_mode = obj1.gxTpr_Mode;
         A3SecFunctionalityKey = obj1.gxTpr_Secfunctionalitykey;
         A8SecFunctionalityDescription = obj1.gxTpr_Secfunctionalitydescription;
         if ( forceLoad == 1 )
         {
            A9SecFunctionalityType = obj1.gxTpr_Secfunctionalitytype;
         }
         A2SecParentFunctionalityId = obj1.gxTpr_Secparentfunctionalityid;
         n2SecParentFunctionalityId = false;
         A11SecParentFunctionalityDescription = obj1.gxTpr_Secparentfunctionalitydescription;
         A7SecFunctionalityActive = obj1.gxTpr_Secfunctionalityactive;
         A1SecFunctionalityId = obj1.gxTpr_Secfunctionalityid;
         Z1SecFunctionalityId = obj1.gxTpr_Secfunctionalityid_Z;
         Z3SecFunctionalityKey = obj1.gxTpr_Secfunctionalitykey_Z;
         Z8SecFunctionalityDescription = obj1.gxTpr_Secfunctionalitydescription_Z;
         Z9SecFunctionalityType = obj1.gxTpr_Secfunctionalitytype_Z;
         Z2SecParentFunctionalityId = obj1.gxTpr_Secparentfunctionalityid_Z;
         Z11SecParentFunctionalityDescription = obj1.gxTpr_Secparentfunctionalitydescription_Z;
         Z7SecFunctionalityActive = obj1.gxTpr_Secfunctionalityactive_Z;
         n2SecParentFunctionalityId = (bool)(Convert.ToBoolean(obj1.gxTpr_Secparentfunctionalityid_N));
         Gx_mode = obj1.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A1SecFunctionalityId = (long)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey011( ) ;
         ScanKeyStart011( ) ;
         if ( RcdFound1 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z1SecFunctionalityId = A1SecFunctionalityId;
         }
         ZM011( -3) ;
         OnLoadActions011( ) ;
         AddRow011( ) ;
         ScanKeyEnd011( ) ;
         if ( RcdFound1 == 0 )
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
         RowToVars1( bcwwpbaseobjects_SecFunctionality, 0) ;
         ScanKeyStart011( ) ;
         if ( RcdFound1 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z1SecFunctionalityId = A1SecFunctionalityId;
         }
         ZM011( -3) ;
         OnLoadActions011( ) ;
         AddRow011( ) ;
         ScanKeyEnd011( ) ;
         if ( RcdFound1 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey011( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert011( ) ;
         }
         else
         {
            if ( RcdFound1 == 1 )
            {
               if ( A1SecFunctionalityId != Z1SecFunctionalityId )
               {
                  A1SecFunctionalityId = Z1SecFunctionalityId;
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
                  Update011( ) ;
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
                  if ( A1SecFunctionalityId != Z1SecFunctionalityId )
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
                        Insert011( ) ;
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
                        Insert011( ) ;
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
         RowToVars1( bcwwpbaseobjects_SecFunctionality, 0) ;
         SaveImpl( ) ;
         VarsToRow1( bcwwpbaseobjects_SecFunctionality) ;
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
         RowToVars1( bcwwpbaseobjects_SecFunctionality, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert011( ) ;
         AfterTrn( ) ;
         VarsToRow1( bcwwpbaseobjects_SecFunctionality) ;
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
            GeneXus.Programs.wwpbaseobjects.SdtSecFunctionality auxBC = new GeneXus.Programs.wwpbaseobjects.SdtSecFunctionality(context) ;
            auxBC.Load(A1SecFunctionalityId);
            auxBC.UpdateDirties(bcwwpbaseobjects_SecFunctionality);
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
         RowToVars1( bcwwpbaseobjects_SecFunctionality, 0) ;
         UpdateImpl( ) ;
         VarsToRow1( bcwwpbaseobjects_SecFunctionality) ;
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
         RowToVars1( bcwwpbaseobjects_SecFunctionality, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert011( ) ;
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
         VarsToRow1( bcwwpbaseobjects_SecFunctionality) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars1( bcwwpbaseobjects_SecFunctionality, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey011( ) ;
         if ( RcdFound1 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A1SecFunctionalityId != Z1SecFunctionalityId )
            {
               A1SecFunctionalityId = Z1SecFunctionalityId;
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
            if ( A1SecFunctionalityId != Z1SecFunctionalityId )
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
         pr_default.close(9);
         context.RollbackDataStores("wwpbaseobjects.secfunctionality_bc",pr_default);
         VarsToRow1( bcwwpbaseobjects_SecFunctionality) ;
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
         Gx_mode = bcwwpbaseobjects_SecFunctionality.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcwwpbaseobjects_SecFunctionality.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcwwpbaseobjects_SecFunctionality )
         {
            bcwwpbaseobjects_SecFunctionality = (GeneXus.Programs.wwpbaseobjects.SdtSecFunctionality)(sdt);
            if ( StringUtil.StrCmp(bcwwpbaseobjects_SecFunctionality.gxTpr_Mode, "") == 0 )
            {
               bcwwpbaseobjects_SecFunctionality.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow1( bcwwpbaseobjects_SecFunctionality) ;
            }
            else
            {
               RowToVars1( bcwwpbaseobjects_SecFunctionality, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcwwpbaseobjects_SecFunctionality.gxTpr_Mode, "") == 0 )
            {
               bcwwpbaseobjects_SecFunctionality.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars1( bcwwpbaseobjects_SecFunctionality, 1) ;
         return  ;
      }

      public SdtSecFunctionality SecFunctionality_BC
      {
         get {
            return bcwwpbaseobjects_SecFunctionality ;
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
         pr_default.close(9);
      }

      public override void initialize( )
      {
         scmdbuf = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Gx_mode = "";
         AV18WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV10TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV11WebSession = context.GetSession();
         AV19Pgmname = "";
         AV13TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         Z3SecFunctionalityKey = "";
         A3SecFunctionalityKey = "";
         Z8SecFunctionalityDescription = "";
         A8SecFunctionalityDescription = "";
         Z11SecParentFunctionalityDescription = "";
         A11SecParentFunctionalityDescription = "";
         BC00015_A1SecFunctionalityId = new long[1] ;
         BC00015_A3SecFunctionalityKey = new String[] {""} ;
         BC00015_A8SecFunctionalityDescription = new String[] {""} ;
         BC00015_A9SecFunctionalityType = new short[1] ;
         BC00015_A11SecParentFunctionalityDescription = new String[] {""} ;
         BC00015_A7SecFunctionalityActive = new bool[] {false} ;
         BC00015_A2SecParentFunctionalityId = new long[1] ;
         BC00015_n2SecParentFunctionalityId = new bool[] {false} ;
         BC00016_A3SecFunctionalityKey = new String[] {""} ;
         BC00014_A11SecParentFunctionalityDescription = new String[] {""} ;
         BC00017_A1SecFunctionalityId = new long[1] ;
         BC00013_A1SecFunctionalityId = new long[1] ;
         BC00013_A3SecFunctionalityKey = new String[] {""} ;
         BC00013_A8SecFunctionalityDescription = new String[] {""} ;
         BC00013_A9SecFunctionalityType = new short[1] ;
         BC00013_A7SecFunctionalityActive = new bool[] {false} ;
         BC00013_A2SecParentFunctionalityId = new long[1] ;
         BC00013_n2SecParentFunctionalityId = new bool[] {false} ;
         sMode1 = "";
         BC00012_A1SecFunctionalityId = new long[1] ;
         BC00012_A3SecFunctionalityKey = new String[] {""} ;
         BC00012_A8SecFunctionalityDescription = new String[] {""} ;
         BC00012_A9SecFunctionalityType = new short[1] ;
         BC00012_A7SecFunctionalityActive = new bool[] {false} ;
         BC00012_A2SecParentFunctionalityId = new long[1] ;
         BC00012_n2SecParentFunctionalityId = new bool[] {false} ;
         BC00018_A1SecFunctionalityId = new long[1] ;
         BC000111_A11SecParentFunctionalityDescription = new String[] {""} ;
         BC000112_A2SecParentFunctionalityId = new long[1] ;
         BC000112_n2SecParentFunctionalityId = new bool[] {false} ;
         BC000113_A5SecObjectName = new String[] {""} ;
         BC000113_A1SecFunctionalityId = new long[1] ;
         BC000114_A1SecFunctionalityId = new long[1] ;
         BC000114_A4SecRoleId = new short[1] ;
         BC000115_A1SecFunctionalityId = new long[1] ;
         BC000115_A3SecFunctionalityKey = new String[] {""} ;
         BC000115_A8SecFunctionalityDescription = new String[] {""} ;
         BC000115_A9SecFunctionalityType = new short[1] ;
         BC000115_A11SecParentFunctionalityDescription = new String[] {""} ;
         BC000115_A7SecFunctionalityActive = new bool[] {false} ;
         BC000115_A2SecParentFunctionalityId = new long[1] ;
         BC000115_n2SecParentFunctionalityId = new bool[] {false} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.wwpbaseobjects.secfunctionality_bc__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wwpbaseobjects.secfunctionality_bc__default(),
            new Object[][] {
                new Object[] {
               BC00012_A1SecFunctionalityId, BC00012_A3SecFunctionalityKey, BC00012_A8SecFunctionalityDescription, BC00012_A9SecFunctionalityType, BC00012_A7SecFunctionalityActive, BC00012_A2SecParentFunctionalityId, BC00012_n2SecParentFunctionalityId
               }
               , new Object[] {
               BC00013_A1SecFunctionalityId, BC00013_A3SecFunctionalityKey, BC00013_A8SecFunctionalityDescription, BC00013_A9SecFunctionalityType, BC00013_A7SecFunctionalityActive, BC00013_A2SecParentFunctionalityId, BC00013_n2SecParentFunctionalityId
               }
               , new Object[] {
               BC00014_A11SecParentFunctionalityDescription
               }
               , new Object[] {
               BC00015_A1SecFunctionalityId, BC00015_A3SecFunctionalityKey, BC00015_A8SecFunctionalityDescription, BC00015_A9SecFunctionalityType, BC00015_A11SecParentFunctionalityDescription, BC00015_A7SecFunctionalityActive, BC00015_A2SecParentFunctionalityId, BC00015_n2SecParentFunctionalityId
               }
               , new Object[] {
               BC00016_A3SecFunctionalityKey
               }
               , new Object[] {
               BC00017_A1SecFunctionalityId
               }
               , new Object[] {
               BC00018_A1SecFunctionalityId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000111_A11SecParentFunctionalityDescription
               }
               , new Object[] {
               BC000112_A2SecParentFunctionalityId
               }
               , new Object[] {
               BC000113_A5SecObjectName, BC000113_A1SecFunctionalityId
               }
               , new Object[] {
               BC000114_A1SecFunctionalityId, BC000114_A4SecRoleId
               }
               , new Object[] {
               BC000115_A1SecFunctionalityId, BC000115_A3SecFunctionalityKey, BC000115_A8SecFunctionalityDescription, BC000115_A9SecFunctionalityType, BC000115_A11SecParentFunctionalityDescription, BC000115_A7SecFunctionalityActive, BC000115_A2SecParentFunctionalityId, BC000115_n2SecParentFunctionalityId
               }
            }
         );
         AV19Pgmname = "WWPBaseObjects.SecFunctionality_BC";
         INITTRN();
         /* Execute Start event if defined. */
         /* Execute user event: Start */
         E12012 ();
         standaloneNotModal( ) ;
      }

      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short GX_JID ;
      private short Z9SecFunctionalityType ;
      private short A9SecFunctionalityType ;
      private short RcdFound1 ;
      private int trnEnded ;
      private int AV20GXV1 ;
      private long Z1SecFunctionalityId ;
      private long A1SecFunctionalityId ;
      private long AV12Insert_SecParentFunctionalityId ;
      private long Z2SecParentFunctionalityId ;
      private long A2SecParentFunctionalityId ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String AV19Pgmname ;
      private String sMode1 ;
      private bool Z7SecFunctionalityActive ;
      private bool A7SecFunctionalityActive ;
      private bool n2SecParentFunctionalityId ;
      private String Z3SecFunctionalityKey ;
      private String A3SecFunctionalityKey ;
      private String Z8SecFunctionalityDescription ;
      private String A8SecFunctionalityDescription ;
      private String Z11SecParentFunctionalityDescription ;
      private String A11SecParentFunctionalityDescription ;
      private IGxSession AV11WebSession ;
      private GeneXus.Programs.wwpbaseobjects.SdtSecFunctionality bcwwpbaseobjects_SecFunctionality ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] BC00015_A1SecFunctionalityId ;
      private String[] BC00015_A3SecFunctionalityKey ;
      private String[] BC00015_A8SecFunctionalityDescription ;
      private short[] BC00015_A9SecFunctionalityType ;
      private String[] BC00015_A11SecParentFunctionalityDescription ;
      private bool[] BC00015_A7SecFunctionalityActive ;
      private long[] BC00015_A2SecParentFunctionalityId ;
      private bool[] BC00015_n2SecParentFunctionalityId ;
      private String[] BC00016_A3SecFunctionalityKey ;
      private String[] BC00014_A11SecParentFunctionalityDescription ;
      private long[] BC00017_A1SecFunctionalityId ;
      private long[] BC00013_A1SecFunctionalityId ;
      private String[] BC00013_A3SecFunctionalityKey ;
      private String[] BC00013_A8SecFunctionalityDescription ;
      private short[] BC00013_A9SecFunctionalityType ;
      private bool[] BC00013_A7SecFunctionalityActive ;
      private long[] BC00013_A2SecParentFunctionalityId ;
      private bool[] BC00013_n2SecParentFunctionalityId ;
      private long[] BC00012_A1SecFunctionalityId ;
      private String[] BC00012_A3SecFunctionalityKey ;
      private String[] BC00012_A8SecFunctionalityDescription ;
      private short[] BC00012_A9SecFunctionalityType ;
      private bool[] BC00012_A7SecFunctionalityActive ;
      private long[] BC00012_A2SecParentFunctionalityId ;
      private bool[] BC00012_n2SecParentFunctionalityId ;
      private long[] BC00018_A1SecFunctionalityId ;
      private String[] BC000111_A11SecParentFunctionalityDescription ;
      private long[] BC000112_A2SecParentFunctionalityId ;
      private bool[] BC000112_n2SecParentFunctionalityId ;
      private String[] BC000113_A5SecObjectName ;
      private long[] BC000113_A1SecFunctionalityId ;
      private long[] BC000114_A1SecFunctionalityId ;
      private short[] BC000114_A4SecRoleId ;
      private long[] BC000115_A1SecFunctionalityId ;
      private String[] BC000115_A3SecFunctionalityKey ;
      private String[] BC000115_A8SecFunctionalityDescription ;
      private short[] BC000115_A9SecFunctionalityType ;
      private String[] BC000115_A11SecParentFunctionalityDescription ;
      private bool[] BC000115_A7SecFunctionalityActive ;
      private long[] BC000115_A2SecParentFunctionalityId ;
      private bool[] BC000115_n2SecParentFunctionalityId ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_datastore1 ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV18WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV10TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV13TrnContextAtt ;
   }

   public class secfunctionality_bc__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class secfunctionality_bc__default : DataStoreHelperBase, IDataStoreHelper
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
       ,new ForEachCursor(def[12])
       ,new ForEachCursor(def[13])
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmBC00015 ;
        prmBC00015 = new Object[] {
        new Object[] {"@SecFunctionalityId",SqlDbType.Decimal,10,0}
        } ;
        Object[] prmBC00016 ;
        prmBC00016 = new Object[] {
        new Object[] {"@SecFunctionalityKey",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@SecFunctionalityId",SqlDbType.Decimal,10,0}
        } ;
        Object[] prmBC00014 ;
        prmBC00014 = new Object[] {
        new Object[] {"@SecParentFunctionalityId",SqlDbType.Decimal,10,0}
        } ;
        Object[] prmBC00017 ;
        prmBC00017 = new Object[] {
        new Object[] {"@SecFunctionalityId",SqlDbType.Decimal,10,0}
        } ;
        Object[] prmBC00013 ;
        prmBC00013 = new Object[] {
        new Object[] {"@SecFunctionalityId",SqlDbType.Decimal,10,0}
        } ;
        Object[] prmBC00012 ;
        prmBC00012 = new Object[] {
        new Object[] {"@SecFunctionalityId",SqlDbType.Decimal,10,0}
        } ;
        Object[] prmBC00018 ;
        prmBC00018 = new Object[] {
        new Object[] {"@SecFunctionalityKey",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@SecFunctionalityDescription",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@SecFunctionalityType",SqlDbType.SmallInt,2,0} ,
        new Object[] {"@SecFunctionalityActive",SqlDbType.Bit,4,0} ,
        new Object[] {"@SecParentFunctionalityId",SqlDbType.Decimal,10,0}
        } ;
        Object[] prmBC00019 ;
        prmBC00019 = new Object[] {
        new Object[] {"@SecFunctionalityKey",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@SecFunctionalityDescription",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@SecFunctionalityType",SqlDbType.SmallInt,2,0} ,
        new Object[] {"@SecFunctionalityActive",SqlDbType.Bit,4,0} ,
        new Object[] {"@SecParentFunctionalityId",SqlDbType.Decimal,10,0} ,
        new Object[] {"@SecFunctionalityId",SqlDbType.Decimal,10,0}
        } ;
        Object[] prmBC000110 ;
        prmBC000110 = new Object[] {
        new Object[] {"@SecFunctionalityId",SqlDbType.Decimal,10,0}
        } ;
        Object[] prmBC000111 ;
        prmBC000111 = new Object[] {
        new Object[] {"@SecParentFunctionalityId",SqlDbType.Decimal,10,0}
        } ;
        Object[] prmBC000112 ;
        prmBC000112 = new Object[] {
        new Object[] {"@SecFunctionalityId",SqlDbType.Decimal,10,0}
        } ;
        Object[] prmBC000113 ;
        prmBC000113 = new Object[] {
        new Object[] {"@SecFunctionalityId",SqlDbType.Decimal,10,0}
        } ;
        Object[] prmBC000114 ;
        prmBC000114 = new Object[] {
        new Object[] {"@SecFunctionalityId",SqlDbType.Decimal,10,0}
        } ;
        Object[] prmBC000115 ;
        prmBC000115 = new Object[] {
        new Object[] {"@SecFunctionalityId",SqlDbType.Decimal,10,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("BC00012", "SELECT [SecFunctionalityId], [SecFunctionalityKey], [SecFunctionalityDescription], [SecFunctionalityType], [SecFunctionalityActive], [SecParentFunctionalityId] AS SecParentFunctionalityId FROM [SecFunctionality] WITH (UPDLOCK) WHERE [SecFunctionalityId] = @SecFunctionalityId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00012,1,0,true,false )
           ,new CursorDef("BC00013", "SELECT [SecFunctionalityId], [SecFunctionalityKey], [SecFunctionalityDescription], [SecFunctionalityType], [SecFunctionalityActive], [SecParentFunctionalityId] AS SecParentFunctionalityId FROM [SecFunctionality] WITH (NOLOCK) WHERE [SecFunctionalityId] = @SecFunctionalityId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00013,1,0,true,false )
           ,new CursorDef("BC00014", "SELECT [SecFunctionalityDescription] AS SecParentFunctionalityDescription FROM [SecFunctionality] WITH (NOLOCK) WHERE [SecFunctionalityId] = @SecParentFunctionalityId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00014,1,0,true,false )
           ,new CursorDef("BC00015", "SELECT TM1.[SecFunctionalityId], TM1.[SecFunctionalityKey], TM1.[SecFunctionalityDescription], TM1.[SecFunctionalityType], T2.[SecFunctionalityDescription] AS SecParentFunctionalityDescription, TM1.[SecFunctionalityActive], TM1.[SecParentFunctionalityId] AS SecParentFunctionalityId FROM ([SecFunctionality] TM1 WITH (NOLOCK) LEFT JOIN [SecFunctionality] T2 WITH (NOLOCK) ON T2.[SecFunctionalityId] = TM1.[SecParentFunctionalityId]) WHERE TM1.[SecFunctionalityId] = @SecFunctionalityId ORDER BY TM1.[SecFunctionalityId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00015,100,0,true,false )
           ,new CursorDef("BC00016", "SELECT [SecFunctionalityKey] FROM [SecFunctionality] WITH (NOLOCK) WHERE ([SecFunctionalityKey] = @SecFunctionalityKey) AND (Not ( [SecFunctionalityId] = @SecFunctionalityId)) ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00016,1,0,true,false )
           ,new CursorDef("BC00017", "SELECT [SecFunctionalityId] FROM [SecFunctionality] WITH (NOLOCK) WHERE [SecFunctionalityId] = @SecFunctionalityId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00017,1,0,true,false )
           ,new CursorDef("BC00018", "INSERT INTO [SecFunctionality]([SecFunctionalityKey], [SecFunctionalityDescription], [SecFunctionalityType], [SecFunctionalityActive], [SecParentFunctionalityId]) VALUES(@SecFunctionalityKey, @SecFunctionalityDescription, @SecFunctionalityType, @SecFunctionalityActive, @SecParentFunctionalityId); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmBC00018)
           ,new CursorDef("BC00019", "UPDATE [SecFunctionality] SET [SecFunctionalityKey]=@SecFunctionalityKey, [SecFunctionalityDescription]=@SecFunctionalityDescription, [SecFunctionalityType]=@SecFunctionalityType, [SecFunctionalityActive]=@SecFunctionalityActive, [SecParentFunctionalityId]=@SecParentFunctionalityId  WHERE [SecFunctionalityId] = @SecFunctionalityId", GxErrorMask.GX_NOMASK,prmBC00019)
           ,new CursorDef("BC000110", "DELETE FROM [SecFunctionality]  WHERE [SecFunctionalityId] = @SecFunctionalityId", GxErrorMask.GX_NOMASK,prmBC000110)
           ,new CursorDef("BC000111", "SELECT [SecFunctionalityDescription] AS SecParentFunctionalityDescription FROM [SecFunctionality] WITH (NOLOCK) WHERE [SecFunctionalityId] = @SecParentFunctionalityId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000111,1,0,true,false )
           ,new CursorDef("BC000112", "SELECT TOP 1 [SecFunctionalityId] AS SecParentFunctionalityId FROM [SecFunctionality] WITH (NOLOCK) WHERE [SecParentFunctionalityId] = @SecFunctionalityId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000112,1,0,true,true )
           ,new CursorDef("BC000113", "SELECT TOP 1 [SecObjectName], [SecFunctionalityId] FROM [SecObjectFunctionalities] WITH (NOLOCK) WHERE [SecFunctionalityId] = @SecFunctionalityId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000113,1,0,true,true )
           ,new CursorDef("BC000114", "SELECT TOP 1 [SecFunctionalityId], [SecRoleId] FROM [SecFunctionalityRole] WITH (NOLOCK) WHERE [SecFunctionalityId] = @SecFunctionalityId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000114,1,0,true,true )
           ,new CursorDef("BC000115", "SELECT TM1.[SecFunctionalityId], TM1.[SecFunctionalityKey], TM1.[SecFunctionalityDescription], TM1.[SecFunctionalityType], T2.[SecFunctionalityDescription] AS SecParentFunctionalityDescription, TM1.[SecFunctionalityActive], TM1.[SecParentFunctionalityId] AS SecParentFunctionalityId FROM ([SecFunctionality] TM1 WITH (NOLOCK) LEFT JOIN [SecFunctionality] T2 WITH (NOLOCK) ON T2.[SecFunctionalityId] = TM1.[SecParentFunctionalityId]) WHERE TM1.[SecFunctionalityId] = @SecFunctionalityId ORDER BY TM1.[SecFunctionalityId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000115,100,0,true,false )
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
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
              ((short[]) buf[3])[0] = rslt.getShort(4) ;
              ((bool[]) buf[4])[0] = rslt.getBool(5) ;
              ((long[]) buf[5])[0] = rslt.getLong(6) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(6);
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
              ((short[]) buf[3])[0] = rslt.getShort(4) ;
              ((bool[]) buf[4])[0] = rslt.getBool(5) ;
              ((long[]) buf[5])[0] = rslt.getLong(6) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(6);
              return;
           case 2 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              return;
           case 3 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
              ((short[]) buf[3])[0] = rslt.getShort(4) ;
              ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[5])[0] = rslt.getBool(6) ;
              ((long[]) buf[6])[0] = rslt.getLong(7) ;
              ((bool[]) buf[7])[0] = rslt.wasNull(7);
              return;
           case 4 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              return;
           case 5 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 6 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 9 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              return;
           case 10 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 11 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              return;
           case 12 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((short[]) buf[1])[0] = rslt.getShort(2) ;
              return;
           case 13 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
              ((short[]) buf[3])[0] = rslt.getShort(4) ;
              ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[5])[0] = rslt.getBool(6) ;
              ((long[]) buf[6])[0] = rslt.getLong(7) ;
              ((bool[]) buf[7])[0] = rslt.wasNull(7);
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
              return;
           case 1 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 2 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 3 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 4 :
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameter(2, (long)parms[1]);
              return;
           case 5 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 6 :
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              stmt.SetParameter(3, (short)parms[2]);
              stmt.SetParameter(4, (bool)parms[3]);
              if ( (bool)parms[4] )
              {
                 stmt.setNull( 5 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(5, (long)parms[5]);
              }
              return;
           case 7 :
              stmt.SetParameter(1, (String)parms[0]);
              stmt.SetParameter(2, (String)parms[1]);
              stmt.SetParameter(3, (short)parms[2]);
              stmt.SetParameter(4, (bool)parms[3]);
              if ( (bool)parms[4] )
              {
                 stmt.setNull( 5 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(5, (long)parms[5]);
              }
              stmt.SetParameter(6, (long)parms[6]);
              return;
           case 8 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 9 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 10 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 11 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 12 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 13 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
     }
  }

}

}
