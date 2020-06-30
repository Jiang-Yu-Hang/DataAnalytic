/*
               File: BR_Familyhistory_BC
        Description: 家族史
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:9:4.77
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
   public class br_familyhistory_bc : GXHttpHandler, IGxSilentTrn
   {
      public br_familyhistory_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_familyhistory_bc( IGxContext context )
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
         ReadRow1S74( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey1S74( ) ;
         standaloneModal( ) ;
         AddRow1S74( ) ;
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
               Z576BR_FamilyhistoryID = A576BR_FamilyhistoryID;
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

      protected void CONFIRM_1S0( )
      {
         BeforeValidate1S74( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls1S74( ) ;
            }
            else
            {
               CheckExtendedTable1S74( ) ;
               if ( AnyError == 0 )
               {
                  ZM1S74( 3) ;
                  ZM1S74( 4) ;
               }
               CloseExtendedTableCursors1S74( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void ZM1S74( short GX_JID )
      {
         if ( ( GX_JID == 2 ) || ( GX_JID == 0 ) )
         {
            Z577BR_FamilyCaHistory = A577BR_FamilyCaHistory;
            Z578BR_FamilyCaHistory_Code = A578BR_FamilyCaHistory_Code;
            Z579BR_FamilyCancer = A579BR_FamilyCancer;
            Z19BR_EncounterID = A19BR_EncounterID;
         }
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            Z85BR_Information_ID = A85BR_Information_ID;
         }
         if ( ( GX_JID == 4 ) || ( GX_JID == 0 ) )
         {
            Z36BR_Information_PatientNo = A36BR_Information_PatientNo;
         }
         if ( GX_JID == -2 )
         {
            Z576BR_FamilyhistoryID = A576BR_FamilyhistoryID;
            Z577BR_FamilyCaHistory = A577BR_FamilyCaHistory;
            Z578BR_FamilyCaHistory_Code = A578BR_FamilyCaHistory_Code;
            Z579BR_FamilyCancer = A579BR_FamilyCancer;
            Z19BR_EncounterID = A19BR_EncounterID;
            Z85BR_Information_ID = A85BR_Information_ID;
            Z36BR_Information_PatientNo = A36BR_Information_PatientNo;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load1S74( )
      {
         /* Using cursor BC001S6 */
         pr_default.execute(4, new Object[] {A576BR_FamilyhistoryID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound74 = 1;
            A85BR_Information_ID = BC001S6_A85BR_Information_ID[0];
            n85BR_Information_ID = BC001S6_n85BR_Information_ID[0];
            A36BR_Information_PatientNo = BC001S6_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = BC001S6_n36BR_Information_PatientNo[0];
            A577BR_FamilyCaHistory = BC001S6_A577BR_FamilyCaHistory[0];
            n577BR_FamilyCaHistory = BC001S6_n577BR_FamilyCaHistory[0];
            A578BR_FamilyCaHistory_Code = BC001S6_A578BR_FamilyCaHistory_Code[0];
            n578BR_FamilyCaHistory_Code = BC001S6_n578BR_FamilyCaHistory_Code[0];
            A579BR_FamilyCancer = BC001S6_A579BR_FamilyCancer[0];
            n579BR_FamilyCancer = BC001S6_n579BR_FamilyCancer[0];
            A19BR_EncounterID = BC001S6_A19BR_EncounterID[0];
            ZM1S74( -2) ;
         }
         pr_default.close(4);
         OnLoadActions1S74( ) ;
      }

      protected void OnLoadActions1S74( )
      {
      }

      protected void CheckExtendedTable1S74( )
      {
         standaloneModal( ) ;
         /* Using cursor BC001S4 */
         pr_default.execute(2, new Object[] {A19BR_EncounterID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("不匹配' T15'", "ForeignKeyNotFound", 1, "BR_ENCOUNTERID");
            AnyError = 1;
         }
         A85BR_Information_ID = BC001S4_A85BR_Information_ID[0];
         n85BR_Information_ID = BC001S4_n85BR_Information_ID[0];
         pr_default.close(2);
         /* Using cursor BC001S5 */
         pr_default.execute(3, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
         if ( (pr_default.getStatus(3) == 101) )
         {
            if ( ! ( (0==A85BR_Information_ID) ) )
            {
               GX_msglist.addItem("不匹配' T16'", "ForeignKeyNotFound", 1, "");
               AnyError = 1;
            }
         }
         A36BR_Information_PatientNo = BC001S5_A36BR_Information_PatientNo[0];
         n36BR_Information_PatientNo = BC001S5_n36BR_Information_PatientNo[0];
         pr_default.close(3);
         if ( ! ( ( StringUtil.StrCmp(A577BR_FamilyCaHistory, "否") == 0 ) || ( StringUtil.StrCmp(A577BR_FamilyCaHistory, "是") == 0 ) || ( StringUtil.StrCmp(A577BR_FamilyCaHistory, "不详") == 0 ) || String.IsNullOrEmpty(StringUtil.RTrim( A577BR_FamilyCaHistory)) ) )
         {
            GX_msglist.addItem("域是否有家族肿瘤史超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
      }

      protected void CloseExtendedTableCursors1S74( )
      {
         pr_default.close(2);
         pr_default.close(3);
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey1S74( )
      {
         /* Using cursor BC001S7 */
         pr_default.execute(5, new Object[] {A576BR_FamilyhistoryID});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound74 = 1;
         }
         else
         {
            RcdFound74 = 0;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC001S3 */
         pr_default.execute(1, new Object[] {A576BR_FamilyhistoryID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM1S74( 2) ;
            RcdFound74 = 1;
            A576BR_FamilyhistoryID = BC001S3_A576BR_FamilyhistoryID[0];
            A577BR_FamilyCaHistory = BC001S3_A577BR_FamilyCaHistory[0];
            n577BR_FamilyCaHistory = BC001S3_n577BR_FamilyCaHistory[0];
            A578BR_FamilyCaHistory_Code = BC001S3_A578BR_FamilyCaHistory_Code[0];
            n578BR_FamilyCaHistory_Code = BC001S3_n578BR_FamilyCaHistory_Code[0];
            A579BR_FamilyCancer = BC001S3_A579BR_FamilyCancer[0];
            n579BR_FamilyCancer = BC001S3_n579BR_FamilyCancer[0];
            A19BR_EncounterID = BC001S3_A19BR_EncounterID[0];
            Z576BR_FamilyhistoryID = A576BR_FamilyhistoryID;
            sMode74 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load1S74( ) ;
            if ( AnyError == 1 )
            {
               RcdFound74 = 0;
               InitializeNonKey1S74( ) ;
            }
            Gx_mode = sMode74;
         }
         else
         {
            RcdFound74 = 0;
            InitializeNonKey1S74( ) ;
            sMode74 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode74;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1S74( ) ;
         if ( RcdFound74 == 0 )
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
         CONFIRM_1S0( ) ;
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

      protected void CheckOptimisticConcurrency1S74( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC001S2 */
            pr_default.execute(0, new Object[] {A576BR_FamilyhistoryID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Familyhistory"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z577BR_FamilyCaHistory, BC001S2_A577BR_FamilyCaHistory[0]) != 0 ) || ( StringUtil.StrCmp(Z578BR_FamilyCaHistory_Code, BC001S2_A578BR_FamilyCaHistory_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z579BR_FamilyCancer, BC001S2_A579BR_FamilyCancer[0]) != 0 ) || ( Z19BR_EncounterID != BC001S2_A19BR_EncounterID[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"BR_Familyhistory"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert1S74( )
      {
         BeforeValidate1S74( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1S74( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1S74( 0) ;
            CheckOptimisticConcurrency1S74( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1S74( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1S74( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC001S8 */
                     pr_default.execute(6, new Object[] {n577BR_FamilyCaHistory, A577BR_FamilyCaHistory, n578BR_FamilyCaHistory_Code, A578BR_FamilyCaHistory_Code, n579BR_FamilyCancer, A579BR_FamilyCancer, A19BR_EncounterID});
                     A576BR_FamilyhistoryID = BC001S8_A576BR_FamilyhistoryID[0];
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Familyhistory") ;
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
               Load1S74( ) ;
            }
            EndLevel1S74( ) ;
         }
         CloseExtendedTableCursors1S74( ) ;
      }

      protected void Update1S74( )
      {
         BeforeValidate1S74( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1S74( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1S74( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1S74( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1S74( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC001S9 */
                     pr_default.execute(7, new Object[] {n577BR_FamilyCaHistory, A577BR_FamilyCaHistory, n578BR_FamilyCaHistory_Code, A578BR_FamilyCaHistory_Code, n579BR_FamilyCancer, A579BR_FamilyCancer, A19BR_EncounterID, A576BR_FamilyhistoryID});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Familyhistory") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Familyhistory"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate1S74( ) ;
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
            EndLevel1S74( ) ;
         }
         CloseExtendedTableCursors1S74( ) ;
      }

      protected void DeferredUpdate1S74( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate1S74( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1S74( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1S74( ) ;
            AfterConfirm1S74( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1S74( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC001S10 */
                  pr_default.execute(8, new Object[] {A576BR_FamilyhistoryID});
                  pr_default.close(8);
                  dsDefault.SmartCacheProvider.SetUpdated("BR_Familyhistory") ;
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
         sMode74 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel1S74( ) ;
         Gx_mode = sMode74;
      }

      protected void OnDeleteControls1S74( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor BC001S11 */
            pr_default.execute(9, new Object[] {A19BR_EncounterID});
            A85BR_Information_ID = BC001S11_A85BR_Information_ID[0];
            n85BR_Information_ID = BC001S11_n85BR_Information_ID[0];
            pr_default.close(9);
            /* Using cursor BC001S12 */
            pr_default.execute(10, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
            A36BR_Information_PatientNo = BC001S12_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = BC001S12_n36BR_Information_PatientNo[0];
            pr_default.close(10);
         }
      }

      protected void EndLevel1S74( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1S74( ) ;
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

      public void ScanKeyStart1S74( )
      {
         /* Using cursor BC001S13 */
         pr_default.execute(11, new Object[] {A576BR_FamilyhistoryID});
         RcdFound74 = 0;
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound74 = 1;
            A85BR_Information_ID = BC001S13_A85BR_Information_ID[0];
            n85BR_Information_ID = BC001S13_n85BR_Information_ID[0];
            A576BR_FamilyhistoryID = BC001S13_A576BR_FamilyhistoryID[0];
            A36BR_Information_PatientNo = BC001S13_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = BC001S13_n36BR_Information_PatientNo[0];
            A577BR_FamilyCaHistory = BC001S13_A577BR_FamilyCaHistory[0];
            n577BR_FamilyCaHistory = BC001S13_n577BR_FamilyCaHistory[0];
            A578BR_FamilyCaHistory_Code = BC001S13_A578BR_FamilyCaHistory_Code[0];
            n578BR_FamilyCaHistory_Code = BC001S13_n578BR_FamilyCaHistory_Code[0];
            A579BR_FamilyCancer = BC001S13_A579BR_FamilyCancer[0];
            n579BR_FamilyCancer = BC001S13_n579BR_FamilyCancer[0];
            A19BR_EncounterID = BC001S13_A19BR_EncounterID[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext1S74( )
      {
         /* Scan next routine */
         pr_default.readNext(11);
         RcdFound74 = 0;
         ScanKeyLoad1S74( ) ;
      }

      protected void ScanKeyLoad1S74( )
      {
         sMode74 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound74 = 1;
            A85BR_Information_ID = BC001S13_A85BR_Information_ID[0];
            n85BR_Information_ID = BC001S13_n85BR_Information_ID[0];
            A576BR_FamilyhistoryID = BC001S13_A576BR_FamilyhistoryID[0];
            A36BR_Information_PatientNo = BC001S13_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = BC001S13_n36BR_Information_PatientNo[0];
            A577BR_FamilyCaHistory = BC001S13_A577BR_FamilyCaHistory[0];
            n577BR_FamilyCaHistory = BC001S13_n577BR_FamilyCaHistory[0];
            A578BR_FamilyCaHistory_Code = BC001S13_A578BR_FamilyCaHistory_Code[0];
            n578BR_FamilyCaHistory_Code = BC001S13_n578BR_FamilyCaHistory_Code[0];
            A579BR_FamilyCancer = BC001S13_A579BR_FamilyCancer[0];
            n579BR_FamilyCancer = BC001S13_n579BR_FamilyCancer[0];
            A19BR_EncounterID = BC001S13_A19BR_EncounterID[0];
         }
         Gx_mode = sMode74;
      }

      protected void ScanKeyEnd1S74( )
      {
         pr_default.close(11);
      }

      protected void AfterConfirm1S74( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1S74( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1S74( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1S74( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1S74( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1S74( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1S74( )
      {
      }

      protected void send_integrity_lvl_hashes1S74( )
      {
      }

      protected void AddRow1S74( )
      {
         VarsToRow74( bcBR_Familyhistory) ;
      }

      protected void ReadRow1S74( )
      {
         RowToVars74( bcBR_Familyhistory, 1) ;
      }

      protected void InitializeNonKey1S74( )
      {
         A85BR_Information_ID = 0;
         n85BR_Information_ID = false;
         A19BR_EncounterID = 0;
         A36BR_Information_PatientNo = "";
         n36BR_Information_PatientNo = false;
         A577BR_FamilyCaHistory = "";
         n577BR_FamilyCaHistory = false;
         A578BR_FamilyCaHistory_Code = "";
         n578BR_FamilyCaHistory_Code = false;
         A579BR_FamilyCancer = "";
         n579BR_FamilyCancer = false;
         Z577BR_FamilyCaHistory = "";
         Z578BR_FamilyCaHistory_Code = "";
         Z579BR_FamilyCancer = "";
         Z19BR_EncounterID = 0;
      }

      protected void InitAll1S74( )
      {
         A576BR_FamilyhistoryID = 0;
         InitializeNonKey1S74( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow74( SdtBR_Familyhistory obj74 )
      {
         obj74.gxTpr_Mode = Gx_mode;
         obj74.gxTpr_Br_encounterid = A19BR_EncounterID;
         obj74.gxTpr_Br_information_patientno = A36BR_Information_PatientNo;
         obj74.gxTpr_Br_familycahistory = A577BR_FamilyCaHistory;
         obj74.gxTpr_Br_familycahistory_code = A578BR_FamilyCaHistory_Code;
         obj74.gxTpr_Br_familycancer = A579BR_FamilyCancer;
         obj74.gxTpr_Br_familyhistoryid = A576BR_FamilyhistoryID;
         obj74.gxTpr_Br_familyhistoryid_Z = Z576BR_FamilyhistoryID;
         obj74.gxTpr_Br_encounterid_Z = Z19BR_EncounterID;
         obj74.gxTpr_Br_information_patientno_Z = Z36BR_Information_PatientNo;
         obj74.gxTpr_Br_familycahistory_Z = Z577BR_FamilyCaHistory;
         obj74.gxTpr_Br_familycahistory_code_Z = Z578BR_FamilyCaHistory_Code;
         obj74.gxTpr_Br_familycancer_Z = Z579BR_FamilyCancer;
         obj74.gxTpr_Br_information_patientno_N = (short)(Convert.ToInt16(n36BR_Information_PatientNo));
         obj74.gxTpr_Br_familycahistory_N = (short)(Convert.ToInt16(n577BR_FamilyCaHistory));
         obj74.gxTpr_Br_familycahistory_code_N = (short)(Convert.ToInt16(n578BR_FamilyCaHistory_Code));
         obj74.gxTpr_Br_familycancer_N = (short)(Convert.ToInt16(n579BR_FamilyCancer));
         obj74.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow74( SdtBR_Familyhistory obj74 )
      {
         obj74.gxTpr_Br_familyhistoryid = A576BR_FamilyhistoryID;
         return  ;
      }

      public void RowToVars74( SdtBR_Familyhistory obj74 ,
                               int forceLoad )
      {
         Gx_mode = obj74.gxTpr_Mode;
         A19BR_EncounterID = obj74.gxTpr_Br_encounterid;
         A36BR_Information_PatientNo = obj74.gxTpr_Br_information_patientno;
         n36BR_Information_PatientNo = false;
         A577BR_FamilyCaHistory = obj74.gxTpr_Br_familycahistory;
         n577BR_FamilyCaHistory = false;
         A578BR_FamilyCaHistory_Code = obj74.gxTpr_Br_familycahistory_code;
         n578BR_FamilyCaHistory_Code = false;
         A579BR_FamilyCancer = obj74.gxTpr_Br_familycancer;
         n579BR_FamilyCancer = false;
         A576BR_FamilyhistoryID = obj74.gxTpr_Br_familyhistoryid;
         Z576BR_FamilyhistoryID = obj74.gxTpr_Br_familyhistoryid_Z;
         Z19BR_EncounterID = obj74.gxTpr_Br_encounterid_Z;
         Z36BR_Information_PatientNo = obj74.gxTpr_Br_information_patientno_Z;
         Z577BR_FamilyCaHistory = obj74.gxTpr_Br_familycahistory_Z;
         Z578BR_FamilyCaHistory_Code = obj74.gxTpr_Br_familycahistory_code_Z;
         Z579BR_FamilyCancer = obj74.gxTpr_Br_familycancer_Z;
         n36BR_Information_PatientNo = (bool)(Convert.ToBoolean(obj74.gxTpr_Br_information_patientno_N));
         n577BR_FamilyCaHistory = (bool)(Convert.ToBoolean(obj74.gxTpr_Br_familycahistory_N));
         n578BR_FamilyCaHistory_Code = (bool)(Convert.ToBoolean(obj74.gxTpr_Br_familycahistory_code_N));
         n579BR_FamilyCancer = (bool)(Convert.ToBoolean(obj74.gxTpr_Br_familycancer_N));
         Gx_mode = obj74.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A576BR_FamilyhistoryID = (long)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey1S74( ) ;
         ScanKeyStart1S74( ) ;
         if ( RcdFound74 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z576BR_FamilyhistoryID = A576BR_FamilyhistoryID;
         }
         ZM1S74( -2) ;
         OnLoadActions1S74( ) ;
         AddRow1S74( ) ;
         ScanKeyEnd1S74( ) ;
         if ( RcdFound74 == 0 )
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
         RowToVars74( bcBR_Familyhistory, 0) ;
         ScanKeyStart1S74( ) ;
         if ( RcdFound74 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z576BR_FamilyhistoryID = A576BR_FamilyhistoryID;
         }
         ZM1S74( -2) ;
         OnLoadActions1S74( ) ;
         AddRow1S74( ) ;
         ScanKeyEnd1S74( ) ;
         if ( RcdFound74 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey1S74( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert1S74( ) ;
         }
         else
         {
            if ( RcdFound74 == 1 )
            {
               if ( A576BR_FamilyhistoryID != Z576BR_FamilyhistoryID )
               {
                  A576BR_FamilyhistoryID = Z576BR_FamilyhistoryID;
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
                  Update1S74( ) ;
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
                  if ( A576BR_FamilyhistoryID != Z576BR_FamilyhistoryID )
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
                        Insert1S74( ) ;
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
                        Insert1S74( ) ;
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
         RowToVars74( bcBR_Familyhistory, 0) ;
         SaveImpl( ) ;
         VarsToRow74( bcBR_Familyhistory) ;
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
         RowToVars74( bcBR_Familyhistory, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert1S74( ) ;
         AfterTrn( ) ;
         VarsToRow74( bcBR_Familyhistory) ;
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
            SdtBR_Familyhistory auxBC = new SdtBR_Familyhistory(context) ;
            auxBC.Load(A576BR_FamilyhistoryID);
            auxBC.UpdateDirties(bcBR_Familyhistory);
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
         RowToVars74( bcBR_Familyhistory, 0) ;
         UpdateImpl( ) ;
         VarsToRow74( bcBR_Familyhistory) ;
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
         RowToVars74( bcBR_Familyhistory, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert1S74( ) ;
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
         VarsToRow74( bcBR_Familyhistory) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars74( bcBR_Familyhistory, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey1S74( ) ;
         if ( RcdFound74 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A576BR_FamilyhistoryID != Z576BR_FamilyhistoryID )
            {
               A576BR_FamilyhistoryID = Z576BR_FamilyhistoryID;
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
            if ( A576BR_FamilyhistoryID != Z576BR_FamilyhistoryID )
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
         pr_default.close(10);
         context.RollbackDataStores("br_familyhistory_bc",pr_default);
         VarsToRow74( bcBR_Familyhistory) ;
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
         Gx_mode = bcBR_Familyhistory.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcBR_Familyhistory.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcBR_Familyhistory )
         {
            bcBR_Familyhistory = (SdtBR_Familyhistory)(sdt);
            if ( StringUtil.StrCmp(bcBR_Familyhistory.gxTpr_Mode, "") == 0 )
            {
               bcBR_Familyhistory.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow74( bcBR_Familyhistory) ;
            }
            else
            {
               RowToVars74( bcBR_Familyhistory, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcBR_Familyhistory.gxTpr_Mode, "") == 0 )
            {
               bcBR_Familyhistory.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars74( bcBR_Familyhistory, 1) ;
         return  ;
      }

      public SdtBR_Familyhistory BR_Familyhistory_BC
      {
         get {
            return bcBR_Familyhistory ;
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
         pr_default.close(10);
      }

      public override void initialize( )
      {
         scmdbuf = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Gx_mode = "";
         Z577BR_FamilyCaHistory = "";
         A577BR_FamilyCaHistory = "";
         Z578BR_FamilyCaHistory_Code = "";
         A578BR_FamilyCaHistory_Code = "";
         Z579BR_FamilyCancer = "";
         A579BR_FamilyCancer = "";
         Z36BR_Information_PatientNo = "";
         A36BR_Information_PatientNo = "";
         BC001S6_A85BR_Information_ID = new long[1] ;
         BC001S6_n85BR_Information_ID = new bool[] {false} ;
         BC001S6_A576BR_FamilyhistoryID = new long[1] ;
         BC001S6_A36BR_Information_PatientNo = new String[] {""} ;
         BC001S6_n36BR_Information_PatientNo = new bool[] {false} ;
         BC001S6_A577BR_FamilyCaHistory = new String[] {""} ;
         BC001S6_n577BR_FamilyCaHistory = new bool[] {false} ;
         BC001S6_A578BR_FamilyCaHistory_Code = new String[] {""} ;
         BC001S6_n578BR_FamilyCaHistory_Code = new bool[] {false} ;
         BC001S6_A579BR_FamilyCancer = new String[] {""} ;
         BC001S6_n579BR_FamilyCancer = new bool[] {false} ;
         BC001S6_A19BR_EncounterID = new long[1] ;
         BC001S4_A85BR_Information_ID = new long[1] ;
         BC001S4_n85BR_Information_ID = new bool[] {false} ;
         BC001S5_A36BR_Information_PatientNo = new String[] {""} ;
         BC001S5_n36BR_Information_PatientNo = new bool[] {false} ;
         BC001S7_A576BR_FamilyhistoryID = new long[1] ;
         BC001S3_A576BR_FamilyhistoryID = new long[1] ;
         BC001S3_A577BR_FamilyCaHistory = new String[] {""} ;
         BC001S3_n577BR_FamilyCaHistory = new bool[] {false} ;
         BC001S3_A578BR_FamilyCaHistory_Code = new String[] {""} ;
         BC001S3_n578BR_FamilyCaHistory_Code = new bool[] {false} ;
         BC001S3_A579BR_FamilyCancer = new String[] {""} ;
         BC001S3_n579BR_FamilyCancer = new bool[] {false} ;
         BC001S3_A19BR_EncounterID = new long[1] ;
         sMode74 = "";
         BC001S2_A576BR_FamilyhistoryID = new long[1] ;
         BC001S2_A577BR_FamilyCaHistory = new String[] {""} ;
         BC001S2_n577BR_FamilyCaHistory = new bool[] {false} ;
         BC001S2_A578BR_FamilyCaHistory_Code = new String[] {""} ;
         BC001S2_n578BR_FamilyCaHistory_Code = new bool[] {false} ;
         BC001S2_A579BR_FamilyCancer = new String[] {""} ;
         BC001S2_n579BR_FamilyCancer = new bool[] {false} ;
         BC001S2_A19BR_EncounterID = new long[1] ;
         BC001S8_A576BR_FamilyhistoryID = new long[1] ;
         BC001S11_A85BR_Information_ID = new long[1] ;
         BC001S11_n85BR_Information_ID = new bool[] {false} ;
         BC001S12_A36BR_Information_PatientNo = new String[] {""} ;
         BC001S12_n36BR_Information_PatientNo = new bool[] {false} ;
         BC001S13_A85BR_Information_ID = new long[1] ;
         BC001S13_n85BR_Information_ID = new bool[] {false} ;
         BC001S13_A576BR_FamilyhistoryID = new long[1] ;
         BC001S13_A36BR_Information_PatientNo = new String[] {""} ;
         BC001S13_n36BR_Information_PatientNo = new bool[] {false} ;
         BC001S13_A577BR_FamilyCaHistory = new String[] {""} ;
         BC001S13_n577BR_FamilyCaHistory = new bool[] {false} ;
         BC001S13_A578BR_FamilyCaHistory_Code = new String[] {""} ;
         BC001S13_n578BR_FamilyCaHistory_Code = new bool[] {false} ;
         BC001S13_A579BR_FamilyCancer = new String[] {""} ;
         BC001S13_n579BR_FamilyCancer = new bool[] {false} ;
         BC001S13_A19BR_EncounterID = new long[1] ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_familyhistory_bc__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_familyhistory_bc__default(),
            new Object[][] {
                new Object[] {
               BC001S2_A576BR_FamilyhistoryID, BC001S2_A577BR_FamilyCaHistory, BC001S2_n577BR_FamilyCaHistory, BC001S2_A578BR_FamilyCaHistory_Code, BC001S2_n578BR_FamilyCaHistory_Code, BC001S2_A579BR_FamilyCancer, BC001S2_n579BR_FamilyCancer, BC001S2_A19BR_EncounterID
               }
               , new Object[] {
               BC001S3_A576BR_FamilyhistoryID, BC001S3_A577BR_FamilyCaHistory, BC001S3_n577BR_FamilyCaHistory, BC001S3_A578BR_FamilyCaHistory_Code, BC001S3_n578BR_FamilyCaHistory_Code, BC001S3_A579BR_FamilyCancer, BC001S3_n579BR_FamilyCancer, BC001S3_A19BR_EncounterID
               }
               , new Object[] {
               BC001S4_A85BR_Information_ID, BC001S4_n85BR_Information_ID
               }
               , new Object[] {
               BC001S5_A36BR_Information_PatientNo, BC001S5_n36BR_Information_PatientNo
               }
               , new Object[] {
               BC001S6_A85BR_Information_ID, BC001S6_n85BR_Information_ID, BC001S6_A576BR_FamilyhistoryID, BC001S6_A36BR_Information_PatientNo, BC001S6_n36BR_Information_PatientNo, BC001S6_A577BR_FamilyCaHistory, BC001S6_n577BR_FamilyCaHistory, BC001S6_A578BR_FamilyCaHistory_Code, BC001S6_n578BR_FamilyCaHistory_Code, BC001S6_A579BR_FamilyCancer,
               BC001S6_n579BR_FamilyCancer, BC001S6_A19BR_EncounterID
               }
               , new Object[] {
               BC001S7_A576BR_FamilyhistoryID
               }
               , new Object[] {
               BC001S8_A576BR_FamilyhistoryID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC001S11_A85BR_Information_ID, BC001S11_n85BR_Information_ID
               }
               , new Object[] {
               BC001S12_A36BR_Information_PatientNo, BC001S12_n36BR_Information_PatientNo
               }
               , new Object[] {
               BC001S13_A85BR_Information_ID, BC001S13_n85BR_Information_ID, BC001S13_A576BR_FamilyhistoryID, BC001S13_A36BR_Information_PatientNo, BC001S13_n36BR_Information_PatientNo, BC001S13_A577BR_FamilyCaHistory, BC001S13_n577BR_FamilyCaHistory, BC001S13_A578BR_FamilyCaHistory_Code, BC001S13_n578BR_FamilyCaHistory_Code, BC001S13_A579BR_FamilyCancer,
               BC001S13_n579BR_FamilyCancer, BC001S13_A19BR_EncounterID
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
      private short RcdFound74 ;
      private int trnEnded ;
      private long Z576BR_FamilyhistoryID ;
      private long A576BR_FamilyhistoryID ;
      private long Z19BR_EncounterID ;
      private long A19BR_EncounterID ;
      private long Z85BR_Information_ID ;
      private long A85BR_Information_ID ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String sMode74 ;
      private bool n85BR_Information_ID ;
      private bool n36BR_Information_PatientNo ;
      private bool n577BR_FamilyCaHistory ;
      private bool n578BR_FamilyCaHistory_Code ;
      private bool n579BR_FamilyCancer ;
      private String Z577BR_FamilyCaHistory ;
      private String A577BR_FamilyCaHistory ;
      private String Z578BR_FamilyCaHistory_Code ;
      private String A578BR_FamilyCaHistory_Code ;
      private String Z579BR_FamilyCancer ;
      private String A579BR_FamilyCancer ;
      private String Z36BR_Information_PatientNo ;
      private String A36BR_Information_PatientNo ;
      private SdtBR_Familyhistory bcBR_Familyhistory ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] BC001S6_A85BR_Information_ID ;
      private bool[] BC001S6_n85BR_Information_ID ;
      private long[] BC001S6_A576BR_FamilyhistoryID ;
      private String[] BC001S6_A36BR_Information_PatientNo ;
      private bool[] BC001S6_n36BR_Information_PatientNo ;
      private String[] BC001S6_A577BR_FamilyCaHistory ;
      private bool[] BC001S6_n577BR_FamilyCaHistory ;
      private String[] BC001S6_A578BR_FamilyCaHistory_Code ;
      private bool[] BC001S6_n578BR_FamilyCaHistory_Code ;
      private String[] BC001S6_A579BR_FamilyCancer ;
      private bool[] BC001S6_n579BR_FamilyCancer ;
      private long[] BC001S6_A19BR_EncounterID ;
      private long[] BC001S4_A85BR_Information_ID ;
      private bool[] BC001S4_n85BR_Information_ID ;
      private String[] BC001S5_A36BR_Information_PatientNo ;
      private bool[] BC001S5_n36BR_Information_PatientNo ;
      private long[] BC001S7_A576BR_FamilyhistoryID ;
      private long[] BC001S3_A576BR_FamilyhistoryID ;
      private String[] BC001S3_A577BR_FamilyCaHistory ;
      private bool[] BC001S3_n577BR_FamilyCaHistory ;
      private String[] BC001S3_A578BR_FamilyCaHistory_Code ;
      private bool[] BC001S3_n578BR_FamilyCaHistory_Code ;
      private String[] BC001S3_A579BR_FamilyCancer ;
      private bool[] BC001S3_n579BR_FamilyCancer ;
      private long[] BC001S3_A19BR_EncounterID ;
      private long[] BC001S2_A576BR_FamilyhistoryID ;
      private String[] BC001S2_A577BR_FamilyCaHistory ;
      private bool[] BC001S2_n577BR_FamilyCaHistory ;
      private String[] BC001S2_A578BR_FamilyCaHistory_Code ;
      private bool[] BC001S2_n578BR_FamilyCaHistory_Code ;
      private String[] BC001S2_A579BR_FamilyCancer ;
      private bool[] BC001S2_n579BR_FamilyCancer ;
      private long[] BC001S2_A19BR_EncounterID ;
      private long[] BC001S8_A576BR_FamilyhistoryID ;
      private long[] BC001S11_A85BR_Information_ID ;
      private bool[] BC001S11_n85BR_Information_ID ;
      private String[] BC001S12_A36BR_Information_PatientNo ;
      private bool[] BC001S12_n36BR_Information_PatientNo ;
      private long[] BC001S13_A85BR_Information_ID ;
      private bool[] BC001S13_n85BR_Information_ID ;
      private long[] BC001S13_A576BR_FamilyhistoryID ;
      private String[] BC001S13_A36BR_Information_PatientNo ;
      private bool[] BC001S13_n36BR_Information_PatientNo ;
      private String[] BC001S13_A577BR_FamilyCaHistory ;
      private bool[] BC001S13_n577BR_FamilyCaHistory ;
      private String[] BC001S13_A578BR_FamilyCaHistory_Code ;
      private bool[] BC001S13_n578BR_FamilyCaHistory_Code ;
      private String[] BC001S13_A579BR_FamilyCancer ;
      private bool[] BC001S13_n579BR_FamilyCancer ;
      private long[] BC001S13_A19BR_EncounterID ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_datastore1 ;
   }

   public class br_familyhistory_bc__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class br_familyhistory_bc__default : DataStoreHelperBase, IDataStoreHelper
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
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmBC001S6 ;
        prmBC001S6 = new Object[] {
        new Object[] {"@BR_FamilyhistoryID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC001S4 ;
        prmBC001S4 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC001S5 ;
        prmBC001S5 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC001S7 ;
        prmBC001S7 = new Object[] {
        new Object[] {"@BR_FamilyhistoryID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC001S3 ;
        prmBC001S3 = new Object[] {
        new Object[] {"@BR_FamilyhistoryID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC001S2 ;
        prmBC001S2 = new Object[] {
        new Object[] {"@BR_FamilyhistoryID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC001S8 ;
        prmBC001S8 = new Object[] {
        new Object[] {"@BR_FamilyCaHistory",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_FamilyCaHistory_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_FamilyCancer",SqlDbType.NVarChar,200,0} ,
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC001S9 ;
        prmBC001S9 = new Object[] {
        new Object[] {"@BR_FamilyCaHistory",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_FamilyCaHistory_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_FamilyCancer",SqlDbType.NVarChar,200,0} ,
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_FamilyhistoryID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC001S10 ;
        prmBC001S10 = new Object[] {
        new Object[] {"@BR_FamilyhistoryID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC001S11 ;
        prmBC001S11 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC001S12 ;
        prmBC001S12 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC001S13 ;
        prmBC001S13 = new Object[] {
        new Object[] {"@BR_FamilyhistoryID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("BC001S2", "SELECT [BR_FamilyhistoryID], [BR_FamilyCaHistory], [BR_FamilyCaHistory_Code], [BR_FamilyCancer], [BR_EncounterID] FROM [BR_Familyhistory] WITH (UPDLOCK) WHERE [BR_FamilyhistoryID] = @BR_FamilyhistoryID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001S2,1,0,true,false )
           ,new CursorDef("BC001S3", "SELECT [BR_FamilyhistoryID], [BR_FamilyCaHistory], [BR_FamilyCaHistory_Code], [BR_FamilyCancer], [BR_EncounterID] FROM [BR_Familyhistory] WITH (NOLOCK) WHERE [BR_FamilyhistoryID] = @BR_FamilyhistoryID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001S3,1,0,true,false )
           ,new CursorDef("BC001S4", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001S4,1,0,true,false )
           ,new CursorDef("BC001S5", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001S5,1,0,true,false )
           ,new CursorDef("BC001S6", "SELECT T2.[BR_Information_ID], TM1.[BR_FamilyhistoryID], T3.[BR_Information_PatientNo], TM1.[BR_FamilyCaHistory], TM1.[BR_FamilyCaHistory_Code], TM1.[BR_FamilyCancer], TM1.[BR_EncounterID] FROM (([BR_Familyhistory] TM1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = TM1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID]) WHERE TM1.[BR_FamilyhistoryID] = @BR_FamilyhistoryID ORDER BY TM1.[BR_FamilyhistoryID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001S6,100,0,true,false )
           ,new CursorDef("BC001S7", "SELECT [BR_FamilyhistoryID] FROM [BR_Familyhistory] WITH (NOLOCK) WHERE [BR_FamilyhistoryID] = @BR_FamilyhistoryID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001S7,1,0,true,false )
           ,new CursorDef("BC001S8", "INSERT INTO [BR_Familyhistory]([BR_FamilyCaHistory], [BR_FamilyCaHistory_Code], [BR_FamilyCancer], [BR_EncounterID]) VALUES(@BR_FamilyCaHistory, @BR_FamilyCaHistory_Code, @BR_FamilyCancer, @BR_EncounterID); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmBC001S8)
           ,new CursorDef("BC001S9", "UPDATE [BR_Familyhistory] SET [BR_FamilyCaHistory]=@BR_FamilyCaHistory, [BR_FamilyCaHistory_Code]=@BR_FamilyCaHistory_Code, [BR_FamilyCancer]=@BR_FamilyCancer, [BR_EncounterID]=@BR_EncounterID  WHERE [BR_FamilyhistoryID] = @BR_FamilyhistoryID", GxErrorMask.GX_NOMASK,prmBC001S9)
           ,new CursorDef("BC001S10", "DELETE FROM [BR_Familyhistory]  WHERE [BR_FamilyhistoryID] = @BR_FamilyhistoryID", GxErrorMask.GX_NOMASK,prmBC001S10)
           ,new CursorDef("BC001S11", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001S11,1,0,true,false )
           ,new CursorDef("BC001S12", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001S12,1,0,true,false )
           ,new CursorDef("BC001S13", "SELECT T2.[BR_Information_ID], TM1.[BR_FamilyhistoryID], T3.[BR_Information_PatientNo], TM1.[BR_FamilyCaHistory], TM1.[BR_FamilyCaHistory_Code], TM1.[BR_FamilyCancer], TM1.[BR_EncounterID] FROM (([BR_Familyhistory] TM1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = TM1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID]) WHERE TM1.[BR_FamilyhistoryID] = @BR_FamilyhistoryID ORDER BY TM1.[BR_FamilyhistoryID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001S13,100,0,true,false )
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
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((long[]) buf[7])[0] = rslt.getLong(5) ;
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((long[]) buf[7])[0] = rslt.getLong(5) ;
              return;
           case 2 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              return;
           case 3 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              return;
           case 4 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              ((long[]) buf[2])[0] = rslt.getLong(2) ;
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((long[]) buf[11])[0] = rslt.getLong(7) ;
              return;
           case 5 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 6 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 9 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              return;
           case 10 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              return;
           case 11 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              ((long[]) buf[2])[0] = rslt.getLong(2) ;
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((long[]) buf[11])[0] = rslt.getLong(7) ;
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
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 3 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 4 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 5 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 6 :
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
                 stmt.setNull( 2 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(2, (String)parms[3]);
              }
              if ( (bool)parms[4] )
              {
                 stmt.setNull( 3 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(3, (String)parms[5]);
              }
              stmt.SetParameter(4, (long)parms[6]);
              return;
           case 7 :
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
                 stmt.setNull( 2 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(2, (String)parms[3]);
              }
              if ( (bool)parms[4] )
              {
                 stmt.setNull( 3 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(3, (String)parms[5]);
              }
              stmt.SetParameter(4, (long)parms[6]);
              stmt.SetParameter(5, (long)parms[7]);
              return;
           case 8 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 9 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 10 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 11 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
     }
  }

}

}
