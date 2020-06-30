/*
               File: BR_Medication_BC
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:56:55.66
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
   public class br_medication_bc : GXHttpHandler, IGxSilentTrn
   {
      public br_medication_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_medication_bc( IGxContext context )
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
         ReadRow0H18( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey0H18( ) ;
         standaloneModal( ) ;
         AddRow0H18( ) ;
         Gx_mode = "INS";
         return  ;
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E110H2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               Z119BR_MedicationID = A119BR_MedicationID;
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

      protected void CONFIRM_0H0( )
      {
         BeforeValidate0H18( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0H18( ) ;
            }
            else
            {
               CheckExtendedTable0H18( ) ;
               if ( AnyError == 0 )
               {
                  ZM0H18( 17) ;
                  ZM0H18( 18) ;
               }
               CloseExtendedTableCursors0H18( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void E120H2( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV7WWPContext) ;
         AV13IsAuthorized = true;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            GXt_boolean1 = AV13IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Medication", out  GXt_boolean1) ;
            AV13IsAuthorized = GXt_boolean1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            GXt_boolean1 = AV13IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Medication", out  GXt_boolean1) ;
            AV13IsAuthorized = GXt_boolean1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            GXt_boolean1 = AV13IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Medication", out  GXt_boolean1) ;
            AV13IsAuthorized = GXt_boolean1;
         }
         if ( ! AV13IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV22Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         /* Execute user subroutine: 'ATTRIBUTESSECURITYCODE' */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         AV8TrnContext.FromXml(AV9WebSession.Get("TrnContext"), null, "WWPTransactionContext", "DataAnalysisPlatform");
         if ( ( StringUtil.StrCmp(AV8TrnContext.gxTpr_Transactionname, AV22Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV23GXV1 = 1;
            while ( AV23GXV1 <= AV8TrnContext.gxTpr_Attributes.Count )
            {
               AV11TrnContextAtt = ((GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute)AV8TrnContext.gxTpr_Attributes.Item(AV23GXV1));
               if ( StringUtil.StrCmp(AV11TrnContextAtt.gxTpr_Attributename, "BR_EncounterID") == 0 )
               {
                  AV10Insert_BR_EncounterID = (long)(NumberUtil.Val( AV11TrnContextAtt.gxTpr_Attributevalue, "."));
               }
               AV23GXV1 = (int)(AV23GXV1+1);
            }
         }
      }

      protected void E110H2( )
      {
         /* After Trn Routine */
      }

      protected void S112( )
      {
         /* 'ATTRIBUTESSECURITYCODE' Routine */
      }

      protected void ZM0H18( short GX_JID )
      {
         if ( ( GX_JID == 16 ) || ( GX_JID == 0 ) )
         {
            Z478BR_Medication_RXFrequency_Code = A478BR_Medication_RXFrequency_Code;
            Z477BR_Medication_RXRoute_Code = A477BR_Medication_RXRoute_Code;
            Z507BR_Medication_InpatientChemo_Code = A507BR_Medication_InpatientChemo_Code;
            Z120BR_Medication_RXID = A120BR_Medication_RXID;
            Z121BR_Medication_RXName = A121BR_Medication_RXName;
            Z499BR_Medication_RXName_Code = A499BR_Medication_RXName_Code;
            Z122BR_Medication_RXCode = A122BR_Medication_RXCode;
            Z123BR_Medication_RXType = A123BR_Medication_RXType;
            Z124BR_Medication_RXDose = A124BR_Medication_RXDose;
            Z125BR_Medication_RXUnit = A125BR_Medication_RXUnit;
            Z126BR_Medication_RXFrequency = A126BR_Medication_RXFrequency;
            Z127BR_Medication_RXQuantity = A127BR_Medication_RXQuantity;
            Z128BR_Medication_RXDaysSupply = A128BR_Medication_RXDaysSupply;
            Z129BR_Medication_RXRoute = A129BR_Medication_RXRoute;
            Z130BR_Medication_PrescriptionDate = A130BR_Medication_PrescriptionDate;
            Z132BR_Medication_AdmitStartDate = A132BR_Medication_AdmitStartDate;
            Z133BR_Medication_AdmitEndDate = A133BR_Medication_AdmitEndDate;
            Z131BR_Medication_InpatientChemo = A131BR_Medication_InpatientChemo;
            Z19BR_EncounterID = A19BR_EncounterID;
         }
         if ( ( GX_JID == 17 ) || ( GX_JID == 0 ) )
         {
            Z85BR_Information_ID = A85BR_Information_ID;
         }
         if ( ( GX_JID == 18 ) || ( GX_JID == 0 ) )
         {
            Z36BR_Information_PatientNo = A36BR_Information_PatientNo;
         }
         if ( GX_JID == -16 )
         {
            Z119BR_MedicationID = A119BR_MedicationID;
            Z478BR_Medication_RXFrequency_Code = A478BR_Medication_RXFrequency_Code;
            Z477BR_Medication_RXRoute_Code = A477BR_Medication_RXRoute_Code;
            Z507BR_Medication_InpatientChemo_Code = A507BR_Medication_InpatientChemo_Code;
            Z120BR_Medication_RXID = A120BR_Medication_RXID;
            Z121BR_Medication_RXName = A121BR_Medication_RXName;
            Z499BR_Medication_RXName_Code = A499BR_Medication_RXName_Code;
            Z122BR_Medication_RXCode = A122BR_Medication_RXCode;
            Z123BR_Medication_RXType = A123BR_Medication_RXType;
            Z124BR_Medication_RXDose = A124BR_Medication_RXDose;
            Z125BR_Medication_RXUnit = A125BR_Medication_RXUnit;
            Z126BR_Medication_RXFrequency = A126BR_Medication_RXFrequency;
            Z127BR_Medication_RXQuantity = A127BR_Medication_RXQuantity;
            Z128BR_Medication_RXDaysSupply = A128BR_Medication_RXDaysSupply;
            Z129BR_Medication_RXRoute = A129BR_Medication_RXRoute;
            Z130BR_Medication_PrescriptionDate = A130BR_Medication_PrescriptionDate;
            Z132BR_Medication_AdmitStartDate = A132BR_Medication_AdmitStartDate;
            Z133BR_Medication_AdmitEndDate = A133BR_Medication_AdmitEndDate;
            Z131BR_Medication_InpatientChemo = A131BR_Medication_InpatientChemo;
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

      protected void Load0H18( )
      {
         /* Using cursor BC000H6 */
         pr_default.execute(4, new Object[] {n119BR_MedicationID, A119BR_MedicationID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound18 = 1;
            A85BR_Information_ID = BC000H6_A85BR_Information_ID[0];
            n85BR_Information_ID = BC000H6_n85BR_Information_ID[0];
            A478BR_Medication_RXFrequency_Code = BC000H6_A478BR_Medication_RXFrequency_Code[0];
            n478BR_Medication_RXFrequency_Code = BC000H6_n478BR_Medication_RXFrequency_Code[0];
            A477BR_Medication_RXRoute_Code = BC000H6_A477BR_Medication_RXRoute_Code[0];
            n477BR_Medication_RXRoute_Code = BC000H6_n477BR_Medication_RXRoute_Code[0];
            A507BR_Medication_InpatientChemo_Code = BC000H6_A507BR_Medication_InpatientChemo_Code[0];
            n507BR_Medication_InpatientChemo_Code = BC000H6_n507BR_Medication_InpatientChemo_Code[0];
            A36BR_Information_PatientNo = BC000H6_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = BC000H6_n36BR_Information_PatientNo[0];
            A120BR_Medication_RXID = BC000H6_A120BR_Medication_RXID[0];
            n120BR_Medication_RXID = BC000H6_n120BR_Medication_RXID[0];
            A121BR_Medication_RXName = BC000H6_A121BR_Medication_RXName[0];
            n121BR_Medication_RXName = BC000H6_n121BR_Medication_RXName[0];
            A499BR_Medication_RXName_Code = BC000H6_A499BR_Medication_RXName_Code[0];
            n499BR_Medication_RXName_Code = BC000H6_n499BR_Medication_RXName_Code[0];
            A122BR_Medication_RXCode = BC000H6_A122BR_Medication_RXCode[0];
            n122BR_Medication_RXCode = BC000H6_n122BR_Medication_RXCode[0];
            A123BR_Medication_RXType = BC000H6_A123BR_Medication_RXType[0];
            n123BR_Medication_RXType = BC000H6_n123BR_Medication_RXType[0];
            A124BR_Medication_RXDose = BC000H6_A124BR_Medication_RXDose[0];
            n124BR_Medication_RXDose = BC000H6_n124BR_Medication_RXDose[0];
            A125BR_Medication_RXUnit = BC000H6_A125BR_Medication_RXUnit[0];
            n125BR_Medication_RXUnit = BC000H6_n125BR_Medication_RXUnit[0];
            A126BR_Medication_RXFrequency = BC000H6_A126BR_Medication_RXFrequency[0];
            n126BR_Medication_RXFrequency = BC000H6_n126BR_Medication_RXFrequency[0];
            A127BR_Medication_RXQuantity = BC000H6_A127BR_Medication_RXQuantity[0];
            n127BR_Medication_RXQuantity = BC000H6_n127BR_Medication_RXQuantity[0];
            A128BR_Medication_RXDaysSupply = BC000H6_A128BR_Medication_RXDaysSupply[0];
            n128BR_Medication_RXDaysSupply = BC000H6_n128BR_Medication_RXDaysSupply[0];
            A129BR_Medication_RXRoute = BC000H6_A129BR_Medication_RXRoute[0];
            n129BR_Medication_RXRoute = BC000H6_n129BR_Medication_RXRoute[0];
            A130BR_Medication_PrescriptionDate = BC000H6_A130BR_Medication_PrescriptionDate[0];
            n130BR_Medication_PrescriptionDate = BC000H6_n130BR_Medication_PrescriptionDate[0];
            A132BR_Medication_AdmitStartDate = BC000H6_A132BR_Medication_AdmitStartDate[0];
            n132BR_Medication_AdmitStartDate = BC000H6_n132BR_Medication_AdmitStartDate[0];
            A133BR_Medication_AdmitEndDate = BC000H6_A133BR_Medication_AdmitEndDate[0];
            n133BR_Medication_AdmitEndDate = BC000H6_n133BR_Medication_AdmitEndDate[0];
            A131BR_Medication_InpatientChemo = BC000H6_A131BR_Medication_InpatientChemo[0];
            n131BR_Medication_InpatientChemo = BC000H6_n131BR_Medication_InpatientChemo[0];
            A19BR_EncounterID = BC000H6_A19BR_EncounterID[0];
            ZM0H18( -16) ;
         }
         pr_default.close(4);
         OnLoadActions0H18( ) ;
      }

      protected void OnLoadActions0H18( )
      {
         AV22Pgmname = "BR_Medication_BC";
      }

      protected void CheckExtendedTable0H18( )
      {
         standaloneModal( ) ;
         AV22Pgmname = "BR_Medication_BC";
         /* Using cursor BC000H4 */
         pr_default.execute(2, new Object[] {A19BR_EncounterID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("不匹配' T15'", "ForeignKeyNotFound", 1, "BR_ENCOUNTERID");
            AnyError = 1;
         }
         A85BR_Information_ID = BC000H4_A85BR_Information_ID[0];
         n85BR_Information_ID = BC000H4_n85BR_Information_ID[0];
         pr_default.close(2);
         /* Using cursor BC000H5 */
         pr_default.execute(3, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
         if ( (pr_default.getStatus(3) == 101) )
         {
            if ( ! ( (0==A85BR_Information_ID) ) )
            {
               GX_msglist.addItem("不匹配' T16'", "ForeignKeyNotFound", 1, "");
               AnyError = 1;
            }
         }
         A36BR_Information_PatientNo = BC000H5_A36BR_Information_PatientNo[0];
         n36BR_Information_PatientNo = BC000H5_n36BR_Information_PatientNo[0];
         pr_default.close(3);
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A121BR_Medication_RXName)) )
         {
            GX_msglist.addItem("药物名称是必须填写的。", 1, "");
            AnyError = 1;
         }
         if ( ! ( (DateTime.MinValue==A130BR_Medication_PrescriptionDate) || ( A130BR_Medication_PrescriptionDate >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("域������������超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
         if ( ! ( (DateTime.MinValue==A132BR_Medication_AdmitStartDate) || ( A132BR_Medication_AdmitStartDate >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("域������������超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
         if ( (DateTime.MinValue==A132BR_Medication_AdmitStartDate) )
         {
            GX_msglist.addItem("服药日期是必须填写的。", 1, "");
            AnyError = 1;
         }
         if ( ! ( (DateTime.MinValue==A133BR_Medication_AdmitEndDate) || ( A133BR_Medication_AdmitEndDate >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("域������������超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
         if ( ! ( ( StringUtil.StrCmp(A131BR_Medication_InpatientChemo, "否") == 0 ) || ( StringUtil.StrCmp(A131BR_Medication_InpatientChemo, "是") == 0 ) || ( StringUtil.StrCmp(A131BR_Medication_InpatientChemo, "不详") == 0 ) || String.IsNullOrEmpty(StringUtil.RTrim( A131BR_Medication_InpatientChemo)) ) )
         {
            GX_msglist.addItem("域������������������������超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
      }

      protected void CloseExtendedTableCursors0H18( )
      {
         pr_default.close(2);
         pr_default.close(3);
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0H18( )
      {
         /* Using cursor BC000H7 */
         pr_default.execute(5, new Object[] {n119BR_MedicationID, A119BR_MedicationID});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound18 = 1;
         }
         else
         {
            RcdFound18 = 0;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC000H3 */
         pr_default.execute(1, new Object[] {n119BR_MedicationID, A119BR_MedicationID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0H18( 16) ;
            RcdFound18 = 1;
            A119BR_MedicationID = BC000H3_A119BR_MedicationID[0];
            n119BR_MedicationID = BC000H3_n119BR_MedicationID[0];
            A478BR_Medication_RXFrequency_Code = BC000H3_A478BR_Medication_RXFrequency_Code[0];
            n478BR_Medication_RXFrequency_Code = BC000H3_n478BR_Medication_RXFrequency_Code[0];
            A477BR_Medication_RXRoute_Code = BC000H3_A477BR_Medication_RXRoute_Code[0];
            n477BR_Medication_RXRoute_Code = BC000H3_n477BR_Medication_RXRoute_Code[0];
            A507BR_Medication_InpatientChemo_Code = BC000H3_A507BR_Medication_InpatientChemo_Code[0];
            n507BR_Medication_InpatientChemo_Code = BC000H3_n507BR_Medication_InpatientChemo_Code[0];
            A120BR_Medication_RXID = BC000H3_A120BR_Medication_RXID[0];
            n120BR_Medication_RXID = BC000H3_n120BR_Medication_RXID[0];
            A121BR_Medication_RXName = BC000H3_A121BR_Medication_RXName[0];
            n121BR_Medication_RXName = BC000H3_n121BR_Medication_RXName[0];
            A499BR_Medication_RXName_Code = BC000H3_A499BR_Medication_RXName_Code[0];
            n499BR_Medication_RXName_Code = BC000H3_n499BR_Medication_RXName_Code[0];
            A122BR_Medication_RXCode = BC000H3_A122BR_Medication_RXCode[0];
            n122BR_Medication_RXCode = BC000H3_n122BR_Medication_RXCode[0];
            A123BR_Medication_RXType = BC000H3_A123BR_Medication_RXType[0];
            n123BR_Medication_RXType = BC000H3_n123BR_Medication_RXType[0];
            A124BR_Medication_RXDose = BC000H3_A124BR_Medication_RXDose[0];
            n124BR_Medication_RXDose = BC000H3_n124BR_Medication_RXDose[0];
            A125BR_Medication_RXUnit = BC000H3_A125BR_Medication_RXUnit[0];
            n125BR_Medication_RXUnit = BC000H3_n125BR_Medication_RXUnit[0];
            A126BR_Medication_RXFrequency = BC000H3_A126BR_Medication_RXFrequency[0];
            n126BR_Medication_RXFrequency = BC000H3_n126BR_Medication_RXFrequency[0];
            A127BR_Medication_RXQuantity = BC000H3_A127BR_Medication_RXQuantity[0];
            n127BR_Medication_RXQuantity = BC000H3_n127BR_Medication_RXQuantity[0];
            A128BR_Medication_RXDaysSupply = BC000H3_A128BR_Medication_RXDaysSupply[0];
            n128BR_Medication_RXDaysSupply = BC000H3_n128BR_Medication_RXDaysSupply[0];
            A129BR_Medication_RXRoute = BC000H3_A129BR_Medication_RXRoute[0];
            n129BR_Medication_RXRoute = BC000H3_n129BR_Medication_RXRoute[0];
            A130BR_Medication_PrescriptionDate = BC000H3_A130BR_Medication_PrescriptionDate[0];
            n130BR_Medication_PrescriptionDate = BC000H3_n130BR_Medication_PrescriptionDate[0];
            A132BR_Medication_AdmitStartDate = BC000H3_A132BR_Medication_AdmitStartDate[0];
            n132BR_Medication_AdmitStartDate = BC000H3_n132BR_Medication_AdmitStartDate[0];
            A133BR_Medication_AdmitEndDate = BC000H3_A133BR_Medication_AdmitEndDate[0];
            n133BR_Medication_AdmitEndDate = BC000H3_n133BR_Medication_AdmitEndDate[0];
            A131BR_Medication_InpatientChemo = BC000H3_A131BR_Medication_InpatientChemo[0];
            n131BR_Medication_InpatientChemo = BC000H3_n131BR_Medication_InpatientChemo[0];
            A19BR_EncounterID = BC000H3_A19BR_EncounterID[0];
            Z119BR_MedicationID = A119BR_MedicationID;
            sMode18 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load0H18( ) ;
            if ( AnyError == 1 )
            {
               RcdFound18 = 0;
               InitializeNonKey0H18( ) ;
            }
            Gx_mode = sMode18;
         }
         else
         {
            RcdFound18 = 0;
            InitializeNonKey0H18( ) ;
            sMode18 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode18;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0H18( ) ;
         if ( RcdFound18 == 0 )
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
         CONFIRM_0H0( ) ;
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

      protected void CheckOptimisticConcurrency0H18( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC000H2 */
            pr_default.execute(0, new Object[] {n119BR_MedicationID, A119BR_MedicationID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Medication"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z478BR_Medication_RXFrequency_Code, BC000H2_A478BR_Medication_RXFrequency_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z477BR_Medication_RXRoute_Code, BC000H2_A477BR_Medication_RXRoute_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z507BR_Medication_InpatientChemo_Code, BC000H2_A507BR_Medication_InpatientChemo_Code[0]) != 0 ) || ( Z120BR_Medication_RXID != BC000H2_A120BR_Medication_RXID[0] ) || ( StringUtil.StrCmp(Z121BR_Medication_RXName, BC000H2_A121BR_Medication_RXName[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z499BR_Medication_RXName_Code, BC000H2_A499BR_Medication_RXName_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z122BR_Medication_RXCode, BC000H2_A122BR_Medication_RXCode[0]) != 0 ) || ( StringUtil.StrCmp(Z123BR_Medication_RXType, BC000H2_A123BR_Medication_RXType[0]) != 0 ) || ( Z124BR_Medication_RXDose != BC000H2_A124BR_Medication_RXDose[0] ) || ( StringUtil.StrCmp(Z125BR_Medication_RXUnit, BC000H2_A125BR_Medication_RXUnit[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z126BR_Medication_RXFrequency, BC000H2_A126BR_Medication_RXFrequency[0]) != 0 ) || ( StringUtil.StrCmp(Z127BR_Medication_RXQuantity, BC000H2_A127BR_Medication_RXQuantity[0]) != 0 ) || ( Z128BR_Medication_RXDaysSupply != BC000H2_A128BR_Medication_RXDaysSupply[0] ) || ( StringUtil.StrCmp(Z129BR_Medication_RXRoute, BC000H2_A129BR_Medication_RXRoute[0]) != 0 ) || ( Z130BR_Medication_PrescriptionDate != BC000H2_A130BR_Medication_PrescriptionDate[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z132BR_Medication_AdmitStartDate != BC000H2_A132BR_Medication_AdmitStartDate[0] ) || ( Z133BR_Medication_AdmitEndDate != BC000H2_A133BR_Medication_AdmitEndDate[0] ) || ( StringUtil.StrCmp(Z131BR_Medication_InpatientChemo, BC000H2_A131BR_Medication_InpatientChemo[0]) != 0 ) || ( Z19BR_EncounterID != BC000H2_A19BR_EncounterID[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"BR_Medication"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0H18( )
      {
         BeforeValidate0H18( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0H18( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0H18( 0) ;
            CheckOptimisticConcurrency0H18( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0H18( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0H18( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000H8 */
                     pr_default.execute(6, new Object[] {n478BR_Medication_RXFrequency_Code, A478BR_Medication_RXFrequency_Code, n477BR_Medication_RXRoute_Code, A477BR_Medication_RXRoute_Code, n507BR_Medication_InpatientChemo_Code, A507BR_Medication_InpatientChemo_Code, n120BR_Medication_RXID, A120BR_Medication_RXID, n121BR_Medication_RXName, A121BR_Medication_RXName, n499BR_Medication_RXName_Code, A499BR_Medication_RXName_Code, n122BR_Medication_RXCode, A122BR_Medication_RXCode, n123BR_Medication_RXType, A123BR_Medication_RXType, n124BR_Medication_RXDose, A124BR_Medication_RXDose, n125BR_Medication_RXUnit, A125BR_Medication_RXUnit, n126BR_Medication_RXFrequency, A126BR_Medication_RXFrequency, n127BR_Medication_RXQuantity, A127BR_Medication_RXQuantity, n128BR_Medication_RXDaysSupply, A128BR_Medication_RXDaysSupply, n129BR_Medication_RXRoute, A129BR_Medication_RXRoute, n130BR_Medication_PrescriptionDate, A130BR_Medication_PrescriptionDate, n132BR_Medication_AdmitStartDate, A132BR_Medication_AdmitStartDate, n133BR_Medication_AdmitEndDate, A133BR_Medication_AdmitEndDate, n131BR_Medication_InpatientChemo, A131BR_Medication_InpatientChemo, A19BR_EncounterID});
                     A119BR_MedicationID = BC000H8_A119BR_MedicationID[0];
                     n119BR_MedicationID = BC000H8_n119BR_MedicationID[0];
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Medication") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(A119BR_MedicationID), 18, 0)),  "药物治疗",  "Create",  1) ;
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
               Load0H18( ) ;
            }
            EndLevel0H18( ) ;
         }
         CloseExtendedTableCursors0H18( ) ;
      }

      protected void Update0H18( )
      {
         BeforeValidate0H18( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0H18( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0H18( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0H18( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0H18( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000H9 */
                     pr_default.execute(7, new Object[] {n478BR_Medication_RXFrequency_Code, A478BR_Medication_RXFrequency_Code, n477BR_Medication_RXRoute_Code, A477BR_Medication_RXRoute_Code, n507BR_Medication_InpatientChemo_Code, A507BR_Medication_InpatientChemo_Code, n120BR_Medication_RXID, A120BR_Medication_RXID, n121BR_Medication_RXName, A121BR_Medication_RXName, n499BR_Medication_RXName_Code, A499BR_Medication_RXName_Code, n122BR_Medication_RXCode, A122BR_Medication_RXCode, n123BR_Medication_RXType, A123BR_Medication_RXType, n124BR_Medication_RXDose, A124BR_Medication_RXDose, n125BR_Medication_RXUnit, A125BR_Medication_RXUnit, n126BR_Medication_RXFrequency, A126BR_Medication_RXFrequency, n127BR_Medication_RXQuantity, A127BR_Medication_RXQuantity, n128BR_Medication_RXDaysSupply, A128BR_Medication_RXDaysSupply, n129BR_Medication_RXRoute, A129BR_Medication_RXRoute, n130BR_Medication_PrescriptionDate, A130BR_Medication_PrescriptionDate, n132BR_Medication_AdmitStartDate, A132BR_Medication_AdmitStartDate, n133BR_Medication_AdmitEndDate, A133BR_Medication_AdmitEndDate, n131BR_Medication_InpatientChemo, A131BR_Medication_InpatientChemo, A19BR_EncounterID, n119BR_MedicationID, A119BR_MedicationID});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Medication") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Medication"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0H18( ) ;
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
            EndLevel0H18( ) ;
         }
         CloseExtendedTableCursors0H18( ) ;
      }

      protected void DeferredUpdate0H18( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate0H18( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0H18( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0H18( ) ;
            AfterConfirm0H18( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0H18( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC000H10 */
                  pr_default.execute(8, new Object[] {n119BR_MedicationID, A119BR_MedicationID});
                  pr_default.close(8);
                  dsDefault.SmartCacheProvider.SetUpdated("BR_Medication") ;
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
         sMode18 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel0H18( ) ;
         Gx_mode = sMode18;
      }

      protected void OnDeleteControls0H18( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV22Pgmname = "BR_Medication_BC";
            /* Using cursor BC000H11 */
            pr_default.execute(9, new Object[] {A19BR_EncounterID});
            A85BR_Information_ID = BC000H11_A85BR_Information_ID[0];
            n85BR_Information_ID = BC000H11_n85BR_Information_ID[0];
            pr_default.close(9);
            /* Using cursor BC000H12 */
            pr_default.execute(10, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
            A36BR_Information_PatientNo = BC000H12_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = BC000H12_n36BR_Information_PatientNo[0];
            pr_default.close(10);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor BC000H13 */
            pr_default.execute(11, new Object[] {n119BR_MedicationID, A119BR_MedicationID});
            if ( (pr_default.getStatus(11) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {" T40"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(11);
            /* Using cursor BC000H14 */
            pr_default.execute(12, new Object[] {n119BR_MedicationID, A119BR_MedicationID});
            if ( (pr_default.getStatus(12) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {" T32"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(12);
         }
      }

      protected void EndLevel0H18( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0H18( ) ;
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

      public void ScanKeyStart0H18( )
      {
         /* Scan By routine */
         /* Using cursor BC000H15 */
         pr_default.execute(13, new Object[] {n119BR_MedicationID, A119BR_MedicationID});
         RcdFound18 = 0;
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound18 = 1;
            A85BR_Information_ID = BC000H15_A85BR_Information_ID[0];
            n85BR_Information_ID = BC000H15_n85BR_Information_ID[0];
            A119BR_MedicationID = BC000H15_A119BR_MedicationID[0];
            n119BR_MedicationID = BC000H15_n119BR_MedicationID[0];
            A478BR_Medication_RXFrequency_Code = BC000H15_A478BR_Medication_RXFrequency_Code[0];
            n478BR_Medication_RXFrequency_Code = BC000H15_n478BR_Medication_RXFrequency_Code[0];
            A477BR_Medication_RXRoute_Code = BC000H15_A477BR_Medication_RXRoute_Code[0];
            n477BR_Medication_RXRoute_Code = BC000H15_n477BR_Medication_RXRoute_Code[0];
            A507BR_Medication_InpatientChemo_Code = BC000H15_A507BR_Medication_InpatientChemo_Code[0];
            n507BR_Medication_InpatientChemo_Code = BC000H15_n507BR_Medication_InpatientChemo_Code[0];
            A36BR_Information_PatientNo = BC000H15_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = BC000H15_n36BR_Information_PatientNo[0];
            A120BR_Medication_RXID = BC000H15_A120BR_Medication_RXID[0];
            n120BR_Medication_RXID = BC000H15_n120BR_Medication_RXID[0];
            A121BR_Medication_RXName = BC000H15_A121BR_Medication_RXName[0];
            n121BR_Medication_RXName = BC000H15_n121BR_Medication_RXName[0];
            A499BR_Medication_RXName_Code = BC000H15_A499BR_Medication_RXName_Code[0];
            n499BR_Medication_RXName_Code = BC000H15_n499BR_Medication_RXName_Code[0];
            A122BR_Medication_RXCode = BC000H15_A122BR_Medication_RXCode[0];
            n122BR_Medication_RXCode = BC000H15_n122BR_Medication_RXCode[0];
            A123BR_Medication_RXType = BC000H15_A123BR_Medication_RXType[0];
            n123BR_Medication_RXType = BC000H15_n123BR_Medication_RXType[0];
            A124BR_Medication_RXDose = BC000H15_A124BR_Medication_RXDose[0];
            n124BR_Medication_RXDose = BC000H15_n124BR_Medication_RXDose[0];
            A125BR_Medication_RXUnit = BC000H15_A125BR_Medication_RXUnit[0];
            n125BR_Medication_RXUnit = BC000H15_n125BR_Medication_RXUnit[0];
            A126BR_Medication_RXFrequency = BC000H15_A126BR_Medication_RXFrequency[0];
            n126BR_Medication_RXFrequency = BC000H15_n126BR_Medication_RXFrequency[0];
            A127BR_Medication_RXQuantity = BC000H15_A127BR_Medication_RXQuantity[0];
            n127BR_Medication_RXQuantity = BC000H15_n127BR_Medication_RXQuantity[0];
            A128BR_Medication_RXDaysSupply = BC000H15_A128BR_Medication_RXDaysSupply[0];
            n128BR_Medication_RXDaysSupply = BC000H15_n128BR_Medication_RXDaysSupply[0];
            A129BR_Medication_RXRoute = BC000H15_A129BR_Medication_RXRoute[0];
            n129BR_Medication_RXRoute = BC000H15_n129BR_Medication_RXRoute[0];
            A130BR_Medication_PrescriptionDate = BC000H15_A130BR_Medication_PrescriptionDate[0];
            n130BR_Medication_PrescriptionDate = BC000H15_n130BR_Medication_PrescriptionDate[0];
            A132BR_Medication_AdmitStartDate = BC000H15_A132BR_Medication_AdmitStartDate[0];
            n132BR_Medication_AdmitStartDate = BC000H15_n132BR_Medication_AdmitStartDate[0];
            A133BR_Medication_AdmitEndDate = BC000H15_A133BR_Medication_AdmitEndDate[0];
            n133BR_Medication_AdmitEndDate = BC000H15_n133BR_Medication_AdmitEndDate[0];
            A131BR_Medication_InpatientChemo = BC000H15_A131BR_Medication_InpatientChemo[0];
            n131BR_Medication_InpatientChemo = BC000H15_n131BR_Medication_InpatientChemo[0];
            A19BR_EncounterID = BC000H15_A19BR_EncounterID[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext0H18( )
      {
         /* Scan next routine */
         pr_default.readNext(13);
         RcdFound18 = 0;
         ScanKeyLoad0H18( ) ;
      }

      protected void ScanKeyLoad0H18( )
      {
         sMode18 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound18 = 1;
            A85BR_Information_ID = BC000H15_A85BR_Information_ID[0];
            n85BR_Information_ID = BC000H15_n85BR_Information_ID[0];
            A119BR_MedicationID = BC000H15_A119BR_MedicationID[0];
            n119BR_MedicationID = BC000H15_n119BR_MedicationID[0];
            A478BR_Medication_RXFrequency_Code = BC000H15_A478BR_Medication_RXFrequency_Code[0];
            n478BR_Medication_RXFrequency_Code = BC000H15_n478BR_Medication_RXFrequency_Code[0];
            A477BR_Medication_RXRoute_Code = BC000H15_A477BR_Medication_RXRoute_Code[0];
            n477BR_Medication_RXRoute_Code = BC000H15_n477BR_Medication_RXRoute_Code[0];
            A507BR_Medication_InpatientChemo_Code = BC000H15_A507BR_Medication_InpatientChemo_Code[0];
            n507BR_Medication_InpatientChemo_Code = BC000H15_n507BR_Medication_InpatientChemo_Code[0];
            A36BR_Information_PatientNo = BC000H15_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = BC000H15_n36BR_Information_PatientNo[0];
            A120BR_Medication_RXID = BC000H15_A120BR_Medication_RXID[0];
            n120BR_Medication_RXID = BC000H15_n120BR_Medication_RXID[0];
            A121BR_Medication_RXName = BC000H15_A121BR_Medication_RXName[0];
            n121BR_Medication_RXName = BC000H15_n121BR_Medication_RXName[0];
            A499BR_Medication_RXName_Code = BC000H15_A499BR_Medication_RXName_Code[0];
            n499BR_Medication_RXName_Code = BC000H15_n499BR_Medication_RXName_Code[0];
            A122BR_Medication_RXCode = BC000H15_A122BR_Medication_RXCode[0];
            n122BR_Medication_RXCode = BC000H15_n122BR_Medication_RXCode[0];
            A123BR_Medication_RXType = BC000H15_A123BR_Medication_RXType[0];
            n123BR_Medication_RXType = BC000H15_n123BR_Medication_RXType[0];
            A124BR_Medication_RXDose = BC000H15_A124BR_Medication_RXDose[0];
            n124BR_Medication_RXDose = BC000H15_n124BR_Medication_RXDose[0];
            A125BR_Medication_RXUnit = BC000H15_A125BR_Medication_RXUnit[0];
            n125BR_Medication_RXUnit = BC000H15_n125BR_Medication_RXUnit[0];
            A126BR_Medication_RXFrequency = BC000H15_A126BR_Medication_RXFrequency[0];
            n126BR_Medication_RXFrequency = BC000H15_n126BR_Medication_RXFrequency[0];
            A127BR_Medication_RXQuantity = BC000H15_A127BR_Medication_RXQuantity[0];
            n127BR_Medication_RXQuantity = BC000H15_n127BR_Medication_RXQuantity[0];
            A128BR_Medication_RXDaysSupply = BC000H15_A128BR_Medication_RXDaysSupply[0];
            n128BR_Medication_RXDaysSupply = BC000H15_n128BR_Medication_RXDaysSupply[0];
            A129BR_Medication_RXRoute = BC000H15_A129BR_Medication_RXRoute[0];
            n129BR_Medication_RXRoute = BC000H15_n129BR_Medication_RXRoute[0];
            A130BR_Medication_PrescriptionDate = BC000H15_A130BR_Medication_PrescriptionDate[0];
            n130BR_Medication_PrescriptionDate = BC000H15_n130BR_Medication_PrescriptionDate[0];
            A132BR_Medication_AdmitStartDate = BC000H15_A132BR_Medication_AdmitStartDate[0];
            n132BR_Medication_AdmitStartDate = BC000H15_n132BR_Medication_AdmitStartDate[0];
            A133BR_Medication_AdmitEndDate = BC000H15_A133BR_Medication_AdmitEndDate[0];
            n133BR_Medication_AdmitEndDate = BC000H15_n133BR_Medication_AdmitEndDate[0];
            A131BR_Medication_InpatientChemo = BC000H15_A131BR_Medication_InpatientChemo[0];
            n131BR_Medication_InpatientChemo = BC000H15_n131BR_Medication_InpatientChemo[0];
            A19BR_EncounterID = BC000H15_A19BR_EncounterID[0];
         }
         Gx_mode = sMode18;
      }

      protected void ScanKeyEnd0H18( )
      {
         pr_default.close(13);
      }

      protected void AfterConfirm0H18( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0H18( )
      {
         /* Before Insert Rules */
         GXt_char2 = A478BR_Medication_RXFrequency_Code;
         new zutil_findtargetcode(context ).execute(  25,  A126BR_Medication_RXFrequency, out  GXt_char2) ;
         A478BR_Medication_RXFrequency_Code = GXt_char2;
         n478BR_Medication_RXFrequency_Code = false;
         GXt_char2 = A477BR_Medication_RXRoute_Code;
         new zutil_findtargetcode(context ).execute(  26,  A129BR_Medication_RXRoute, out  GXt_char2) ;
         A477BR_Medication_RXRoute_Code = GXt_char2;
         n477BR_Medication_RXRoute_Code = false;
         GXt_char2 = A507BR_Medication_InpatientChemo_Code;
         new zutil_findtargetcode(context ).execute(  37,  A131BR_Medication_InpatientChemo, out  GXt_char2) ;
         A507BR_Medication_InpatientChemo_Code = GXt_char2;
         n507BR_Medication_InpatientChemo_Code = false;
      }

      protected void BeforeUpdate0H18( )
      {
         /* Before Update Rules */
         GXt_char2 = A478BR_Medication_RXFrequency_Code;
         new zutil_findtargetcode(context ).execute(  25,  A126BR_Medication_RXFrequency, out  GXt_char2) ;
         A478BR_Medication_RXFrequency_Code = GXt_char2;
         n478BR_Medication_RXFrequency_Code = false;
         GXt_char2 = A477BR_Medication_RXRoute_Code;
         new zutil_findtargetcode(context ).execute(  26,  A129BR_Medication_RXRoute, out  GXt_char2) ;
         A477BR_Medication_RXRoute_Code = GXt_char2;
         n477BR_Medication_RXRoute_Code = false;
         GXt_char2 = A507BR_Medication_InpatientChemo_Code;
         new zutil_findtargetcode(context ).execute(  37,  A131BR_Medication_InpatientChemo, out  GXt_char2) ;
         A507BR_Medication_InpatientChemo_Code = GXt_char2;
         n507BR_Medication_InpatientChemo_Code = false;
      }

      protected void BeforeDelete0H18( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0H18( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0H18( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0H18( )
      {
      }

      protected void send_integrity_lvl_hashes0H18( )
      {
      }

      protected void AddRow0H18( )
      {
         VarsToRow18( bcBR_Medication) ;
      }

      protected void ReadRow0H18( )
      {
         RowToVars18( bcBR_Medication, 1) ;
      }

      protected void InitializeNonKey0H18( )
      {
         A85BR_Information_ID = 0;
         n85BR_Information_ID = false;
         A478BR_Medication_RXFrequency_Code = "";
         n478BR_Medication_RXFrequency_Code = false;
         A477BR_Medication_RXRoute_Code = "";
         n477BR_Medication_RXRoute_Code = false;
         A507BR_Medication_InpatientChemo_Code = "";
         n507BR_Medication_InpatientChemo_Code = false;
         A19BR_EncounterID = 0;
         A36BR_Information_PatientNo = "";
         n36BR_Information_PatientNo = false;
         A120BR_Medication_RXID = 0;
         n120BR_Medication_RXID = false;
         A121BR_Medication_RXName = "";
         n121BR_Medication_RXName = false;
         A499BR_Medication_RXName_Code = "";
         n499BR_Medication_RXName_Code = false;
         A122BR_Medication_RXCode = "";
         n122BR_Medication_RXCode = false;
         A123BR_Medication_RXType = "";
         n123BR_Medication_RXType = false;
         A124BR_Medication_RXDose = 0;
         n124BR_Medication_RXDose = false;
         A125BR_Medication_RXUnit = "";
         n125BR_Medication_RXUnit = false;
         A126BR_Medication_RXFrequency = "";
         n126BR_Medication_RXFrequency = false;
         A127BR_Medication_RXQuantity = "";
         n127BR_Medication_RXQuantity = false;
         A128BR_Medication_RXDaysSupply = 0;
         n128BR_Medication_RXDaysSupply = false;
         A129BR_Medication_RXRoute = "";
         n129BR_Medication_RXRoute = false;
         A130BR_Medication_PrescriptionDate = DateTime.MinValue;
         n130BR_Medication_PrescriptionDate = false;
         A132BR_Medication_AdmitStartDate = DateTime.MinValue;
         n132BR_Medication_AdmitStartDate = false;
         A133BR_Medication_AdmitEndDate = DateTime.MinValue;
         n133BR_Medication_AdmitEndDate = false;
         A131BR_Medication_InpatientChemo = "";
         n131BR_Medication_InpatientChemo = false;
         Z478BR_Medication_RXFrequency_Code = "";
         Z477BR_Medication_RXRoute_Code = "";
         Z507BR_Medication_InpatientChemo_Code = "";
         Z120BR_Medication_RXID = 0;
         Z121BR_Medication_RXName = "";
         Z499BR_Medication_RXName_Code = "";
         Z122BR_Medication_RXCode = "";
         Z123BR_Medication_RXType = "";
         Z124BR_Medication_RXDose = 0;
         Z125BR_Medication_RXUnit = "";
         Z126BR_Medication_RXFrequency = "";
         Z127BR_Medication_RXQuantity = "";
         Z128BR_Medication_RXDaysSupply = 0;
         Z129BR_Medication_RXRoute = "";
         Z130BR_Medication_PrescriptionDate = DateTime.MinValue;
         Z132BR_Medication_AdmitStartDate = DateTime.MinValue;
         Z133BR_Medication_AdmitEndDate = DateTime.MinValue;
         Z131BR_Medication_InpatientChemo = "";
         Z19BR_EncounterID = 0;
      }

      protected void InitAll0H18( )
      {
         A119BR_MedicationID = 0;
         n119BR_MedicationID = false;
         InitializeNonKey0H18( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow18( SdtBR_Medication obj18 )
      {
         obj18.gxTpr_Mode = Gx_mode;
         obj18.gxTpr_Br_medication_rxfrequency_code = A478BR_Medication_RXFrequency_Code;
         obj18.gxTpr_Br_medication_rxroute_code = A477BR_Medication_RXRoute_Code;
         obj18.gxTpr_Br_medication_inpatientchemo_code = A507BR_Medication_InpatientChemo_Code;
         obj18.gxTpr_Br_encounterid = A19BR_EncounterID;
         obj18.gxTpr_Br_information_patientno = A36BR_Information_PatientNo;
         obj18.gxTpr_Br_medication_rxid = A120BR_Medication_RXID;
         obj18.gxTpr_Br_medication_rxname = A121BR_Medication_RXName;
         obj18.gxTpr_Br_medication_rxname_code = A499BR_Medication_RXName_Code;
         obj18.gxTpr_Br_medication_rxcode = A122BR_Medication_RXCode;
         obj18.gxTpr_Br_medication_rxtype = A123BR_Medication_RXType;
         obj18.gxTpr_Br_medication_rxdose = A124BR_Medication_RXDose;
         obj18.gxTpr_Br_medication_rxunit = A125BR_Medication_RXUnit;
         obj18.gxTpr_Br_medication_rxfrequency = A126BR_Medication_RXFrequency;
         obj18.gxTpr_Br_medication_rxquantity = A127BR_Medication_RXQuantity;
         obj18.gxTpr_Br_medication_rxdayssupply = A128BR_Medication_RXDaysSupply;
         obj18.gxTpr_Br_medication_rxroute = A129BR_Medication_RXRoute;
         obj18.gxTpr_Br_medication_prescriptiondate = A130BR_Medication_PrescriptionDate;
         obj18.gxTpr_Br_medication_admitstartdate = A132BR_Medication_AdmitStartDate;
         obj18.gxTpr_Br_medication_admitenddate = A133BR_Medication_AdmitEndDate;
         obj18.gxTpr_Br_medication_inpatientchemo = A131BR_Medication_InpatientChemo;
         obj18.gxTpr_Br_medicationid = A119BR_MedicationID;
         obj18.gxTpr_Br_medicationid_Z = Z119BR_MedicationID;
         obj18.gxTpr_Br_encounterid_Z = Z19BR_EncounterID;
         obj18.gxTpr_Br_information_patientno_Z = Z36BR_Information_PatientNo;
         obj18.gxTpr_Br_medication_rxid_Z = Z120BR_Medication_RXID;
         obj18.gxTpr_Br_medication_rxname_Z = Z121BR_Medication_RXName;
         obj18.gxTpr_Br_medication_rxname_code_Z = Z499BR_Medication_RXName_Code;
         obj18.gxTpr_Br_medication_rxcode_Z = Z122BR_Medication_RXCode;
         obj18.gxTpr_Br_medication_rxtype_Z = Z123BR_Medication_RXType;
         obj18.gxTpr_Br_medication_rxdose_Z = Z124BR_Medication_RXDose;
         obj18.gxTpr_Br_medication_rxunit_Z = Z125BR_Medication_RXUnit;
         obj18.gxTpr_Br_medication_rxfrequency_Z = Z126BR_Medication_RXFrequency;
         obj18.gxTpr_Br_medication_rxfrequency_code_Z = Z478BR_Medication_RXFrequency_Code;
         obj18.gxTpr_Br_medication_rxquantity_Z = Z127BR_Medication_RXQuantity;
         obj18.gxTpr_Br_medication_rxdayssupply_Z = Z128BR_Medication_RXDaysSupply;
         obj18.gxTpr_Br_medication_rxroute_Z = Z129BR_Medication_RXRoute;
         obj18.gxTpr_Br_medication_rxroute_code_Z = Z477BR_Medication_RXRoute_Code;
         obj18.gxTpr_Br_medication_prescriptiondate_Z = Z130BR_Medication_PrescriptionDate;
         obj18.gxTpr_Br_medication_admitstartdate_Z = Z132BR_Medication_AdmitStartDate;
         obj18.gxTpr_Br_medication_admitenddate_Z = Z133BR_Medication_AdmitEndDate;
         obj18.gxTpr_Br_medication_inpatientchemo_Z = Z131BR_Medication_InpatientChemo;
         obj18.gxTpr_Br_medication_inpatientchemo_code_Z = Z507BR_Medication_InpatientChemo_Code;
         obj18.gxTpr_Br_medicationid_N = (short)(Convert.ToInt16(n119BR_MedicationID));
         obj18.gxTpr_Br_information_patientno_N = (short)(Convert.ToInt16(n36BR_Information_PatientNo));
         obj18.gxTpr_Br_medication_rxid_N = (short)(Convert.ToInt16(n120BR_Medication_RXID));
         obj18.gxTpr_Br_medication_rxname_N = (short)(Convert.ToInt16(n121BR_Medication_RXName));
         obj18.gxTpr_Br_medication_rxname_code_N = (short)(Convert.ToInt16(n499BR_Medication_RXName_Code));
         obj18.gxTpr_Br_medication_rxcode_N = (short)(Convert.ToInt16(n122BR_Medication_RXCode));
         obj18.gxTpr_Br_medication_rxtype_N = (short)(Convert.ToInt16(n123BR_Medication_RXType));
         obj18.gxTpr_Br_medication_rxdose_N = (short)(Convert.ToInt16(n124BR_Medication_RXDose));
         obj18.gxTpr_Br_medication_rxunit_N = (short)(Convert.ToInt16(n125BR_Medication_RXUnit));
         obj18.gxTpr_Br_medication_rxfrequency_N = (short)(Convert.ToInt16(n126BR_Medication_RXFrequency));
         obj18.gxTpr_Br_medication_rxfrequency_code_N = (short)(Convert.ToInt16(n478BR_Medication_RXFrequency_Code));
         obj18.gxTpr_Br_medication_rxquantity_N = (short)(Convert.ToInt16(n127BR_Medication_RXQuantity));
         obj18.gxTpr_Br_medication_rxdayssupply_N = (short)(Convert.ToInt16(n128BR_Medication_RXDaysSupply));
         obj18.gxTpr_Br_medication_rxroute_N = (short)(Convert.ToInt16(n129BR_Medication_RXRoute));
         obj18.gxTpr_Br_medication_rxroute_code_N = (short)(Convert.ToInt16(n477BR_Medication_RXRoute_Code));
         obj18.gxTpr_Br_medication_prescriptiondate_N = (short)(Convert.ToInt16(n130BR_Medication_PrescriptionDate));
         obj18.gxTpr_Br_medication_admitstartdate_N = (short)(Convert.ToInt16(n132BR_Medication_AdmitStartDate));
         obj18.gxTpr_Br_medication_admitenddate_N = (short)(Convert.ToInt16(n133BR_Medication_AdmitEndDate));
         obj18.gxTpr_Br_medication_inpatientchemo_N = (short)(Convert.ToInt16(n131BR_Medication_InpatientChemo));
         obj18.gxTpr_Br_medication_inpatientchemo_code_N = (short)(Convert.ToInt16(n507BR_Medication_InpatientChemo_Code));
         obj18.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow18( SdtBR_Medication obj18 )
      {
         obj18.gxTpr_Br_medicationid = A119BR_MedicationID;
         return  ;
      }

      public void RowToVars18( SdtBR_Medication obj18 ,
                               int forceLoad )
      {
         Gx_mode = obj18.gxTpr_Mode;
         A478BR_Medication_RXFrequency_Code = obj18.gxTpr_Br_medication_rxfrequency_code;
         n478BR_Medication_RXFrequency_Code = false;
         A477BR_Medication_RXRoute_Code = obj18.gxTpr_Br_medication_rxroute_code;
         n477BR_Medication_RXRoute_Code = false;
         A507BR_Medication_InpatientChemo_Code = obj18.gxTpr_Br_medication_inpatientchemo_code;
         n507BR_Medication_InpatientChemo_Code = false;
         A19BR_EncounterID = obj18.gxTpr_Br_encounterid;
         A36BR_Information_PatientNo = obj18.gxTpr_Br_information_patientno;
         n36BR_Information_PatientNo = false;
         A120BR_Medication_RXID = obj18.gxTpr_Br_medication_rxid;
         n120BR_Medication_RXID = false;
         A121BR_Medication_RXName = obj18.gxTpr_Br_medication_rxname;
         n121BR_Medication_RXName = false;
         A499BR_Medication_RXName_Code = obj18.gxTpr_Br_medication_rxname_code;
         n499BR_Medication_RXName_Code = false;
         A122BR_Medication_RXCode = obj18.gxTpr_Br_medication_rxcode;
         n122BR_Medication_RXCode = false;
         A123BR_Medication_RXType = obj18.gxTpr_Br_medication_rxtype;
         n123BR_Medication_RXType = false;
         A124BR_Medication_RXDose = obj18.gxTpr_Br_medication_rxdose;
         n124BR_Medication_RXDose = false;
         A125BR_Medication_RXUnit = obj18.gxTpr_Br_medication_rxunit;
         n125BR_Medication_RXUnit = false;
         A126BR_Medication_RXFrequency = obj18.gxTpr_Br_medication_rxfrequency;
         n126BR_Medication_RXFrequency = false;
         A127BR_Medication_RXQuantity = obj18.gxTpr_Br_medication_rxquantity;
         n127BR_Medication_RXQuantity = false;
         A128BR_Medication_RXDaysSupply = obj18.gxTpr_Br_medication_rxdayssupply;
         n128BR_Medication_RXDaysSupply = false;
         A129BR_Medication_RXRoute = obj18.gxTpr_Br_medication_rxroute;
         n129BR_Medication_RXRoute = false;
         A130BR_Medication_PrescriptionDate = obj18.gxTpr_Br_medication_prescriptiondate;
         n130BR_Medication_PrescriptionDate = false;
         A132BR_Medication_AdmitStartDate = obj18.gxTpr_Br_medication_admitstartdate;
         n132BR_Medication_AdmitStartDate = false;
         A133BR_Medication_AdmitEndDate = obj18.gxTpr_Br_medication_admitenddate;
         n133BR_Medication_AdmitEndDate = false;
         A131BR_Medication_InpatientChemo = obj18.gxTpr_Br_medication_inpatientchemo;
         n131BR_Medication_InpatientChemo = false;
         A119BR_MedicationID = obj18.gxTpr_Br_medicationid;
         n119BR_MedicationID = false;
         Z119BR_MedicationID = obj18.gxTpr_Br_medicationid_Z;
         Z19BR_EncounterID = obj18.gxTpr_Br_encounterid_Z;
         Z36BR_Information_PatientNo = obj18.gxTpr_Br_information_patientno_Z;
         Z120BR_Medication_RXID = obj18.gxTpr_Br_medication_rxid_Z;
         Z121BR_Medication_RXName = obj18.gxTpr_Br_medication_rxname_Z;
         Z499BR_Medication_RXName_Code = obj18.gxTpr_Br_medication_rxname_code_Z;
         Z122BR_Medication_RXCode = obj18.gxTpr_Br_medication_rxcode_Z;
         Z123BR_Medication_RXType = obj18.gxTpr_Br_medication_rxtype_Z;
         Z124BR_Medication_RXDose = obj18.gxTpr_Br_medication_rxdose_Z;
         Z125BR_Medication_RXUnit = obj18.gxTpr_Br_medication_rxunit_Z;
         Z126BR_Medication_RXFrequency = obj18.gxTpr_Br_medication_rxfrequency_Z;
         Z478BR_Medication_RXFrequency_Code = obj18.gxTpr_Br_medication_rxfrequency_code_Z;
         Z127BR_Medication_RXQuantity = obj18.gxTpr_Br_medication_rxquantity_Z;
         Z128BR_Medication_RXDaysSupply = obj18.gxTpr_Br_medication_rxdayssupply_Z;
         Z129BR_Medication_RXRoute = obj18.gxTpr_Br_medication_rxroute_Z;
         Z477BR_Medication_RXRoute_Code = obj18.gxTpr_Br_medication_rxroute_code_Z;
         Z130BR_Medication_PrescriptionDate = obj18.gxTpr_Br_medication_prescriptiondate_Z;
         Z132BR_Medication_AdmitStartDate = obj18.gxTpr_Br_medication_admitstartdate_Z;
         Z133BR_Medication_AdmitEndDate = obj18.gxTpr_Br_medication_admitenddate_Z;
         Z131BR_Medication_InpatientChemo = obj18.gxTpr_Br_medication_inpatientchemo_Z;
         Z507BR_Medication_InpatientChemo_Code = obj18.gxTpr_Br_medication_inpatientchemo_code_Z;
         n119BR_MedicationID = (bool)(Convert.ToBoolean(obj18.gxTpr_Br_medicationid_N));
         n36BR_Information_PatientNo = (bool)(Convert.ToBoolean(obj18.gxTpr_Br_information_patientno_N));
         n120BR_Medication_RXID = (bool)(Convert.ToBoolean(obj18.gxTpr_Br_medication_rxid_N));
         n121BR_Medication_RXName = (bool)(Convert.ToBoolean(obj18.gxTpr_Br_medication_rxname_N));
         n499BR_Medication_RXName_Code = (bool)(Convert.ToBoolean(obj18.gxTpr_Br_medication_rxname_code_N));
         n122BR_Medication_RXCode = (bool)(Convert.ToBoolean(obj18.gxTpr_Br_medication_rxcode_N));
         n123BR_Medication_RXType = (bool)(Convert.ToBoolean(obj18.gxTpr_Br_medication_rxtype_N));
         n124BR_Medication_RXDose = (bool)(Convert.ToBoolean(obj18.gxTpr_Br_medication_rxdose_N));
         n125BR_Medication_RXUnit = (bool)(Convert.ToBoolean(obj18.gxTpr_Br_medication_rxunit_N));
         n126BR_Medication_RXFrequency = (bool)(Convert.ToBoolean(obj18.gxTpr_Br_medication_rxfrequency_N));
         n478BR_Medication_RXFrequency_Code = (bool)(Convert.ToBoolean(obj18.gxTpr_Br_medication_rxfrequency_code_N));
         n127BR_Medication_RXQuantity = (bool)(Convert.ToBoolean(obj18.gxTpr_Br_medication_rxquantity_N));
         n128BR_Medication_RXDaysSupply = (bool)(Convert.ToBoolean(obj18.gxTpr_Br_medication_rxdayssupply_N));
         n129BR_Medication_RXRoute = (bool)(Convert.ToBoolean(obj18.gxTpr_Br_medication_rxroute_N));
         n477BR_Medication_RXRoute_Code = (bool)(Convert.ToBoolean(obj18.gxTpr_Br_medication_rxroute_code_N));
         n130BR_Medication_PrescriptionDate = (bool)(Convert.ToBoolean(obj18.gxTpr_Br_medication_prescriptiondate_N));
         n132BR_Medication_AdmitStartDate = (bool)(Convert.ToBoolean(obj18.gxTpr_Br_medication_admitstartdate_N));
         n133BR_Medication_AdmitEndDate = (bool)(Convert.ToBoolean(obj18.gxTpr_Br_medication_admitenddate_N));
         n131BR_Medication_InpatientChemo = (bool)(Convert.ToBoolean(obj18.gxTpr_Br_medication_inpatientchemo_N));
         n507BR_Medication_InpatientChemo_Code = (bool)(Convert.ToBoolean(obj18.gxTpr_Br_medication_inpatientchemo_code_N));
         Gx_mode = obj18.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A119BR_MedicationID = (long)getParm(obj,0);
         n119BR_MedicationID = false;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey0H18( ) ;
         ScanKeyStart0H18( ) ;
         if ( RcdFound18 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z119BR_MedicationID = A119BR_MedicationID;
         }
         ZM0H18( -16) ;
         OnLoadActions0H18( ) ;
         AddRow0H18( ) ;
         ScanKeyEnd0H18( ) ;
         if ( RcdFound18 == 0 )
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
         RowToVars18( bcBR_Medication, 0) ;
         ScanKeyStart0H18( ) ;
         if ( RcdFound18 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z119BR_MedicationID = A119BR_MedicationID;
         }
         ZM0H18( -16) ;
         OnLoadActions0H18( ) ;
         AddRow0H18( ) ;
         ScanKeyEnd0H18( ) ;
         if ( RcdFound18 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey0H18( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert0H18( ) ;
         }
         else
         {
            if ( RcdFound18 == 1 )
            {
               if ( A119BR_MedicationID != Z119BR_MedicationID )
               {
                  A119BR_MedicationID = Z119BR_MedicationID;
                  n119BR_MedicationID = false;
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
                  Update0H18( ) ;
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
                  if ( A119BR_MedicationID != Z119BR_MedicationID )
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
                        Insert0H18( ) ;
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
                        Insert0H18( ) ;
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
         RowToVars18( bcBR_Medication, 0) ;
         SaveImpl( ) ;
         VarsToRow18( bcBR_Medication) ;
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
         RowToVars18( bcBR_Medication, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert0H18( ) ;
         AfterTrn( ) ;
         VarsToRow18( bcBR_Medication) ;
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
            SdtBR_Medication auxBC = new SdtBR_Medication(context) ;
            auxBC.Load(A119BR_MedicationID);
            auxBC.UpdateDirties(bcBR_Medication);
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
         RowToVars18( bcBR_Medication, 0) ;
         UpdateImpl( ) ;
         VarsToRow18( bcBR_Medication) ;
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
         RowToVars18( bcBR_Medication, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert0H18( ) ;
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
         VarsToRow18( bcBR_Medication) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars18( bcBR_Medication, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey0H18( ) ;
         if ( RcdFound18 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A119BR_MedicationID != Z119BR_MedicationID )
            {
               A119BR_MedicationID = Z119BR_MedicationID;
               n119BR_MedicationID = false;
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
            if ( A119BR_MedicationID != Z119BR_MedicationID )
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
         context.RollbackDataStores("br_medication_bc",pr_default);
         VarsToRow18( bcBR_Medication) ;
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
         Gx_mode = bcBR_Medication.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcBR_Medication.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcBR_Medication )
         {
            bcBR_Medication = (SdtBR_Medication)(sdt);
            if ( StringUtil.StrCmp(bcBR_Medication.gxTpr_Mode, "") == 0 )
            {
               bcBR_Medication.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow18( bcBR_Medication) ;
            }
            else
            {
               RowToVars18( bcBR_Medication, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcBR_Medication.gxTpr_Mode, "") == 0 )
            {
               bcBR_Medication.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars18( bcBR_Medication, 1) ;
         return  ;
      }

      public SdtBR_Medication BR_Medication_BC
      {
         get {
            return bcBR_Medication ;
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
         AV7WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV22Pgmname = "";
         AV8TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9WebSession = context.GetSession();
         AV11TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         Z478BR_Medication_RXFrequency_Code = "";
         A478BR_Medication_RXFrequency_Code = "";
         Z477BR_Medication_RXRoute_Code = "";
         A477BR_Medication_RXRoute_Code = "";
         Z507BR_Medication_InpatientChemo_Code = "";
         A507BR_Medication_InpatientChemo_Code = "";
         Z121BR_Medication_RXName = "";
         A121BR_Medication_RXName = "";
         Z499BR_Medication_RXName_Code = "";
         A499BR_Medication_RXName_Code = "";
         Z122BR_Medication_RXCode = "";
         A122BR_Medication_RXCode = "";
         Z123BR_Medication_RXType = "";
         A123BR_Medication_RXType = "";
         Z125BR_Medication_RXUnit = "";
         A125BR_Medication_RXUnit = "";
         Z126BR_Medication_RXFrequency = "";
         A126BR_Medication_RXFrequency = "";
         Z127BR_Medication_RXQuantity = "";
         A127BR_Medication_RXQuantity = "";
         Z129BR_Medication_RXRoute = "";
         A129BR_Medication_RXRoute = "";
         Z130BR_Medication_PrescriptionDate = DateTime.MinValue;
         A130BR_Medication_PrescriptionDate = DateTime.MinValue;
         Z132BR_Medication_AdmitStartDate = DateTime.MinValue;
         A132BR_Medication_AdmitStartDate = DateTime.MinValue;
         Z133BR_Medication_AdmitEndDate = DateTime.MinValue;
         A133BR_Medication_AdmitEndDate = DateTime.MinValue;
         Z131BR_Medication_InpatientChemo = "";
         A131BR_Medication_InpatientChemo = "";
         Z36BR_Information_PatientNo = "";
         A36BR_Information_PatientNo = "";
         BC000H6_A85BR_Information_ID = new long[1] ;
         BC000H6_n85BR_Information_ID = new bool[] {false} ;
         BC000H6_A119BR_MedicationID = new long[1] ;
         BC000H6_n119BR_MedicationID = new bool[] {false} ;
         BC000H6_A478BR_Medication_RXFrequency_Code = new String[] {""} ;
         BC000H6_n478BR_Medication_RXFrequency_Code = new bool[] {false} ;
         BC000H6_A477BR_Medication_RXRoute_Code = new String[] {""} ;
         BC000H6_n477BR_Medication_RXRoute_Code = new bool[] {false} ;
         BC000H6_A507BR_Medication_InpatientChemo_Code = new String[] {""} ;
         BC000H6_n507BR_Medication_InpatientChemo_Code = new bool[] {false} ;
         BC000H6_A36BR_Information_PatientNo = new String[] {""} ;
         BC000H6_n36BR_Information_PatientNo = new bool[] {false} ;
         BC000H6_A120BR_Medication_RXID = new short[1] ;
         BC000H6_n120BR_Medication_RXID = new bool[] {false} ;
         BC000H6_A121BR_Medication_RXName = new String[] {""} ;
         BC000H6_n121BR_Medication_RXName = new bool[] {false} ;
         BC000H6_A499BR_Medication_RXName_Code = new String[] {""} ;
         BC000H6_n499BR_Medication_RXName_Code = new bool[] {false} ;
         BC000H6_A122BR_Medication_RXCode = new String[] {""} ;
         BC000H6_n122BR_Medication_RXCode = new bool[] {false} ;
         BC000H6_A123BR_Medication_RXType = new String[] {""} ;
         BC000H6_n123BR_Medication_RXType = new bool[] {false} ;
         BC000H6_A124BR_Medication_RXDose = new decimal[1] ;
         BC000H6_n124BR_Medication_RXDose = new bool[] {false} ;
         BC000H6_A125BR_Medication_RXUnit = new String[] {""} ;
         BC000H6_n125BR_Medication_RXUnit = new bool[] {false} ;
         BC000H6_A126BR_Medication_RXFrequency = new String[] {""} ;
         BC000H6_n126BR_Medication_RXFrequency = new bool[] {false} ;
         BC000H6_A127BR_Medication_RXQuantity = new String[] {""} ;
         BC000H6_n127BR_Medication_RXQuantity = new bool[] {false} ;
         BC000H6_A128BR_Medication_RXDaysSupply = new decimal[1] ;
         BC000H6_n128BR_Medication_RXDaysSupply = new bool[] {false} ;
         BC000H6_A129BR_Medication_RXRoute = new String[] {""} ;
         BC000H6_n129BR_Medication_RXRoute = new bool[] {false} ;
         BC000H6_A130BR_Medication_PrescriptionDate = new DateTime[] {DateTime.MinValue} ;
         BC000H6_n130BR_Medication_PrescriptionDate = new bool[] {false} ;
         BC000H6_A132BR_Medication_AdmitStartDate = new DateTime[] {DateTime.MinValue} ;
         BC000H6_n132BR_Medication_AdmitStartDate = new bool[] {false} ;
         BC000H6_A133BR_Medication_AdmitEndDate = new DateTime[] {DateTime.MinValue} ;
         BC000H6_n133BR_Medication_AdmitEndDate = new bool[] {false} ;
         BC000H6_A131BR_Medication_InpatientChemo = new String[] {""} ;
         BC000H6_n131BR_Medication_InpatientChemo = new bool[] {false} ;
         BC000H6_A19BR_EncounterID = new long[1] ;
         BC000H4_A85BR_Information_ID = new long[1] ;
         BC000H4_n85BR_Information_ID = new bool[] {false} ;
         BC000H5_A36BR_Information_PatientNo = new String[] {""} ;
         BC000H5_n36BR_Information_PatientNo = new bool[] {false} ;
         BC000H7_A119BR_MedicationID = new long[1] ;
         BC000H7_n119BR_MedicationID = new bool[] {false} ;
         BC000H3_A119BR_MedicationID = new long[1] ;
         BC000H3_n119BR_MedicationID = new bool[] {false} ;
         BC000H3_A478BR_Medication_RXFrequency_Code = new String[] {""} ;
         BC000H3_n478BR_Medication_RXFrequency_Code = new bool[] {false} ;
         BC000H3_A477BR_Medication_RXRoute_Code = new String[] {""} ;
         BC000H3_n477BR_Medication_RXRoute_Code = new bool[] {false} ;
         BC000H3_A507BR_Medication_InpatientChemo_Code = new String[] {""} ;
         BC000H3_n507BR_Medication_InpatientChemo_Code = new bool[] {false} ;
         BC000H3_A120BR_Medication_RXID = new short[1] ;
         BC000H3_n120BR_Medication_RXID = new bool[] {false} ;
         BC000H3_A121BR_Medication_RXName = new String[] {""} ;
         BC000H3_n121BR_Medication_RXName = new bool[] {false} ;
         BC000H3_A499BR_Medication_RXName_Code = new String[] {""} ;
         BC000H3_n499BR_Medication_RXName_Code = new bool[] {false} ;
         BC000H3_A122BR_Medication_RXCode = new String[] {""} ;
         BC000H3_n122BR_Medication_RXCode = new bool[] {false} ;
         BC000H3_A123BR_Medication_RXType = new String[] {""} ;
         BC000H3_n123BR_Medication_RXType = new bool[] {false} ;
         BC000H3_A124BR_Medication_RXDose = new decimal[1] ;
         BC000H3_n124BR_Medication_RXDose = new bool[] {false} ;
         BC000H3_A125BR_Medication_RXUnit = new String[] {""} ;
         BC000H3_n125BR_Medication_RXUnit = new bool[] {false} ;
         BC000H3_A126BR_Medication_RXFrequency = new String[] {""} ;
         BC000H3_n126BR_Medication_RXFrequency = new bool[] {false} ;
         BC000H3_A127BR_Medication_RXQuantity = new String[] {""} ;
         BC000H3_n127BR_Medication_RXQuantity = new bool[] {false} ;
         BC000H3_A128BR_Medication_RXDaysSupply = new decimal[1] ;
         BC000H3_n128BR_Medication_RXDaysSupply = new bool[] {false} ;
         BC000H3_A129BR_Medication_RXRoute = new String[] {""} ;
         BC000H3_n129BR_Medication_RXRoute = new bool[] {false} ;
         BC000H3_A130BR_Medication_PrescriptionDate = new DateTime[] {DateTime.MinValue} ;
         BC000H3_n130BR_Medication_PrescriptionDate = new bool[] {false} ;
         BC000H3_A132BR_Medication_AdmitStartDate = new DateTime[] {DateTime.MinValue} ;
         BC000H3_n132BR_Medication_AdmitStartDate = new bool[] {false} ;
         BC000H3_A133BR_Medication_AdmitEndDate = new DateTime[] {DateTime.MinValue} ;
         BC000H3_n133BR_Medication_AdmitEndDate = new bool[] {false} ;
         BC000H3_A131BR_Medication_InpatientChemo = new String[] {""} ;
         BC000H3_n131BR_Medication_InpatientChemo = new bool[] {false} ;
         BC000H3_A19BR_EncounterID = new long[1] ;
         sMode18 = "";
         BC000H2_A119BR_MedicationID = new long[1] ;
         BC000H2_n119BR_MedicationID = new bool[] {false} ;
         BC000H2_A478BR_Medication_RXFrequency_Code = new String[] {""} ;
         BC000H2_n478BR_Medication_RXFrequency_Code = new bool[] {false} ;
         BC000H2_A477BR_Medication_RXRoute_Code = new String[] {""} ;
         BC000H2_n477BR_Medication_RXRoute_Code = new bool[] {false} ;
         BC000H2_A507BR_Medication_InpatientChemo_Code = new String[] {""} ;
         BC000H2_n507BR_Medication_InpatientChemo_Code = new bool[] {false} ;
         BC000H2_A120BR_Medication_RXID = new short[1] ;
         BC000H2_n120BR_Medication_RXID = new bool[] {false} ;
         BC000H2_A121BR_Medication_RXName = new String[] {""} ;
         BC000H2_n121BR_Medication_RXName = new bool[] {false} ;
         BC000H2_A499BR_Medication_RXName_Code = new String[] {""} ;
         BC000H2_n499BR_Medication_RXName_Code = new bool[] {false} ;
         BC000H2_A122BR_Medication_RXCode = new String[] {""} ;
         BC000H2_n122BR_Medication_RXCode = new bool[] {false} ;
         BC000H2_A123BR_Medication_RXType = new String[] {""} ;
         BC000H2_n123BR_Medication_RXType = new bool[] {false} ;
         BC000H2_A124BR_Medication_RXDose = new decimal[1] ;
         BC000H2_n124BR_Medication_RXDose = new bool[] {false} ;
         BC000H2_A125BR_Medication_RXUnit = new String[] {""} ;
         BC000H2_n125BR_Medication_RXUnit = new bool[] {false} ;
         BC000H2_A126BR_Medication_RXFrequency = new String[] {""} ;
         BC000H2_n126BR_Medication_RXFrequency = new bool[] {false} ;
         BC000H2_A127BR_Medication_RXQuantity = new String[] {""} ;
         BC000H2_n127BR_Medication_RXQuantity = new bool[] {false} ;
         BC000H2_A128BR_Medication_RXDaysSupply = new decimal[1] ;
         BC000H2_n128BR_Medication_RXDaysSupply = new bool[] {false} ;
         BC000H2_A129BR_Medication_RXRoute = new String[] {""} ;
         BC000H2_n129BR_Medication_RXRoute = new bool[] {false} ;
         BC000H2_A130BR_Medication_PrescriptionDate = new DateTime[] {DateTime.MinValue} ;
         BC000H2_n130BR_Medication_PrescriptionDate = new bool[] {false} ;
         BC000H2_A132BR_Medication_AdmitStartDate = new DateTime[] {DateTime.MinValue} ;
         BC000H2_n132BR_Medication_AdmitStartDate = new bool[] {false} ;
         BC000H2_A133BR_Medication_AdmitEndDate = new DateTime[] {DateTime.MinValue} ;
         BC000H2_n133BR_Medication_AdmitEndDate = new bool[] {false} ;
         BC000H2_A131BR_Medication_InpatientChemo = new String[] {""} ;
         BC000H2_n131BR_Medication_InpatientChemo = new bool[] {false} ;
         BC000H2_A19BR_EncounterID = new long[1] ;
         BC000H8_A119BR_MedicationID = new long[1] ;
         BC000H8_n119BR_MedicationID = new bool[] {false} ;
         BC000H11_A85BR_Information_ID = new long[1] ;
         BC000H11_n85BR_Information_ID = new bool[] {false} ;
         BC000H12_A36BR_Information_PatientNo = new String[] {""} ;
         BC000H12_n36BR_Information_PatientNo = new bool[] {false} ;
         BC000H13_A332BR_Scheme_MedicationID = new long[1] ;
         BC000H14_A296BR_Medication_SchemeID = new long[1] ;
         BC000H15_A85BR_Information_ID = new long[1] ;
         BC000H15_n85BR_Information_ID = new bool[] {false} ;
         BC000H15_A119BR_MedicationID = new long[1] ;
         BC000H15_n119BR_MedicationID = new bool[] {false} ;
         BC000H15_A478BR_Medication_RXFrequency_Code = new String[] {""} ;
         BC000H15_n478BR_Medication_RXFrequency_Code = new bool[] {false} ;
         BC000H15_A477BR_Medication_RXRoute_Code = new String[] {""} ;
         BC000H15_n477BR_Medication_RXRoute_Code = new bool[] {false} ;
         BC000H15_A507BR_Medication_InpatientChemo_Code = new String[] {""} ;
         BC000H15_n507BR_Medication_InpatientChemo_Code = new bool[] {false} ;
         BC000H15_A36BR_Information_PatientNo = new String[] {""} ;
         BC000H15_n36BR_Information_PatientNo = new bool[] {false} ;
         BC000H15_A120BR_Medication_RXID = new short[1] ;
         BC000H15_n120BR_Medication_RXID = new bool[] {false} ;
         BC000H15_A121BR_Medication_RXName = new String[] {""} ;
         BC000H15_n121BR_Medication_RXName = new bool[] {false} ;
         BC000H15_A499BR_Medication_RXName_Code = new String[] {""} ;
         BC000H15_n499BR_Medication_RXName_Code = new bool[] {false} ;
         BC000H15_A122BR_Medication_RXCode = new String[] {""} ;
         BC000H15_n122BR_Medication_RXCode = new bool[] {false} ;
         BC000H15_A123BR_Medication_RXType = new String[] {""} ;
         BC000H15_n123BR_Medication_RXType = new bool[] {false} ;
         BC000H15_A124BR_Medication_RXDose = new decimal[1] ;
         BC000H15_n124BR_Medication_RXDose = new bool[] {false} ;
         BC000H15_A125BR_Medication_RXUnit = new String[] {""} ;
         BC000H15_n125BR_Medication_RXUnit = new bool[] {false} ;
         BC000H15_A126BR_Medication_RXFrequency = new String[] {""} ;
         BC000H15_n126BR_Medication_RXFrequency = new bool[] {false} ;
         BC000H15_A127BR_Medication_RXQuantity = new String[] {""} ;
         BC000H15_n127BR_Medication_RXQuantity = new bool[] {false} ;
         BC000H15_A128BR_Medication_RXDaysSupply = new decimal[1] ;
         BC000H15_n128BR_Medication_RXDaysSupply = new bool[] {false} ;
         BC000H15_A129BR_Medication_RXRoute = new String[] {""} ;
         BC000H15_n129BR_Medication_RXRoute = new bool[] {false} ;
         BC000H15_A130BR_Medication_PrescriptionDate = new DateTime[] {DateTime.MinValue} ;
         BC000H15_n130BR_Medication_PrescriptionDate = new bool[] {false} ;
         BC000H15_A132BR_Medication_AdmitStartDate = new DateTime[] {DateTime.MinValue} ;
         BC000H15_n132BR_Medication_AdmitStartDate = new bool[] {false} ;
         BC000H15_A133BR_Medication_AdmitEndDate = new DateTime[] {DateTime.MinValue} ;
         BC000H15_n133BR_Medication_AdmitEndDate = new bool[] {false} ;
         BC000H15_A131BR_Medication_InpatientChemo = new String[] {""} ;
         BC000H15_n131BR_Medication_InpatientChemo = new bool[] {false} ;
         BC000H15_A19BR_EncounterID = new long[1] ;
         GXt_char2 = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_medication_bc__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_medication_bc__default(),
            new Object[][] {
                new Object[] {
               BC000H2_A119BR_MedicationID, BC000H2_A478BR_Medication_RXFrequency_Code, BC000H2_n478BR_Medication_RXFrequency_Code, BC000H2_A477BR_Medication_RXRoute_Code, BC000H2_n477BR_Medication_RXRoute_Code, BC000H2_A507BR_Medication_InpatientChemo_Code, BC000H2_n507BR_Medication_InpatientChemo_Code, BC000H2_A120BR_Medication_RXID, BC000H2_n120BR_Medication_RXID, BC000H2_A121BR_Medication_RXName,
               BC000H2_n121BR_Medication_RXName, BC000H2_A499BR_Medication_RXName_Code, BC000H2_n499BR_Medication_RXName_Code, BC000H2_A122BR_Medication_RXCode, BC000H2_n122BR_Medication_RXCode, BC000H2_A123BR_Medication_RXType, BC000H2_n123BR_Medication_RXType, BC000H2_A124BR_Medication_RXDose, BC000H2_n124BR_Medication_RXDose, BC000H2_A125BR_Medication_RXUnit,
               BC000H2_n125BR_Medication_RXUnit, BC000H2_A126BR_Medication_RXFrequency, BC000H2_n126BR_Medication_RXFrequency, BC000H2_A127BR_Medication_RXQuantity, BC000H2_n127BR_Medication_RXQuantity, BC000H2_A128BR_Medication_RXDaysSupply, BC000H2_n128BR_Medication_RXDaysSupply, BC000H2_A129BR_Medication_RXRoute, BC000H2_n129BR_Medication_RXRoute, BC000H2_A130BR_Medication_PrescriptionDate,
               BC000H2_n130BR_Medication_PrescriptionDate, BC000H2_A132BR_Medication_AdmitStartDate, BC000H2_n132BR_Medication_AdmitStartDate, BC000H2_A133BR_Medication_AdmitEndDate, BC000H2_n133BR_Medication_AdmitEndDate, BC000H2_A131BR_Medication_InpatientChemo, BC000H2_n131BR_Medication_InpatientChemo, BC000H2_A19BR_EncounterID
               }
               , new Object[] {
               BC000H3_A119BR_MedicationID, BC000H3_A478BR_Medication_RXFrequency_Code, BC000H3_n478BR_Medication_RXFrequency_Code, BC000H3_A477BR_Medication_RXRoute_Code, BC000H3_n477BR_Medication_RXRoute_Code, BC000H3_A507BR_Medication_InpatientChemo_Code, BC000H3_n507BR_Medication_InpatientChemo_Code, BC000H3_A120BR_Medication_RXID, BC000H3_n120BR_Medication_RXID, BC000H3_A121BR_Medication_RXName,
               BC000H3_n121BR_Medication_RXName, BC000H3_A499BR_Medication_RXName_Code, BC000H3_n499BR_Medication_RXName_Code, BC000H3_A122BR_Medication_RXCode, BC000H3_n122BR_Medication_RXCode, BC000H3_A123BR_Medication_RXType, BC000H3_n123BR_Medication_RXType, BC000H3_A124BR_Medication_RXDose, BC000H3_n124BR_Medication_RXDose, BC000H3_A125BR_Medication_RXUnit,
               BC000H3_n125BR_Medication_RXUnit, BC000H3_A126BR_Medication_RXFrequency, BC000H3_n126BR_Medication_RXFrequency, BC000H3_A127BR_Medication_RXQuantity, BC000H3_n127BR_Medication_RXQuantity, BC000H3_A128BR_Medication_RXDaysSupply, BC000H3_n128BR_Medication_RXDaysSupply, BC000H3_A129BR_Medication_RXRoute, BC000H3_n129BR_Medication_RXRoute, BC000H3_A130BR_Medication_PrescriptionDate,
               BC000H3_n130BR_Medication_PrescriptionDate, BC000H3_A132BR_Medication_AdmitStartDate, BC000H3_n132BR_Medication_AdmitStartDate, BC000H3_A133BR_Medication_AdmitEndDate, BC000H3_n133BR_Medication_AdmitEndDate, BC000H3_A131BR_Medication_InpatientChemo, BC000H3_n131BR_Medication_InpatientChemo, BC000H3_A19BR_EncounterID
               }
               , new Object[] {
               BC000H4_A85BR_Information_ID, BC000H4_n85BR_Information_ID
               }
               , new Object[] {
               BC000H5_A36BR_Information_PatientNo, BC000H5_n36BR_Information_PatientNo
               }
               , new Object[] {
               BC000H6_A85BR_Information_ID, BC000H6_n85BR_Information_ID, BC000H6_A119BR_MedicationID, BC000H6_A478BR_Medication_RXFrequency_Code, BC000H6_n478BR_Medication_RXFrequency_Code, BC000H6_A477BR_Medication_RXRoute_Code, BC000H6_n477BR_Medication_RXRoute_Code, BC000H6_A507BR_Medication_InpatientChemo_Code, BC000H6_n507BR_Medication_InpatientChemo_Code, BC000H6_A36BR_Information_PatientNo,
               BC000H6_n36BR_Information_PatientNo, BC000H6_A120BR_Medication_RXID, BC000H6_n120BR_Medication_RXID, BC000H6_A121BR_Medication_RXName, BC000H6_n121BR_Medication_RXName, BC000H6_A499BR_Medication_RXName_Code, BC000H6_n499BR_Medication_RXName_Code, BC000H6_A122BR_Medication_RXCode, BC000H6_n122BR_Medication_RXCode, BC000H6_A123BR_Medication_RXType,
               BC000H6_n123BR_Medication_RXType, BC000H6_A124BR_Medication_RXDose, BC000H6_n124BR_Medication_RXDose, BC000H6_A125BR_Medication_RXUnit, BC000H6_n125BR_Medication_RXUnit, BC000H6_A126BR_Medication_RXFrequency, BC000H6_n126BR_Medication_RXFrequency, BC000H6_A127BR_Medication_RXQuantity, BC000H6_n127BR_Medication_RXQuantity, BC000H6_A128BR_Medication_RXDaysSupply,
               BC000H6_n128BR_Medication_RXDaysSupply, BC000H6_A129BR_Medication_RXRoute, BC000H6_n129BR_Medication_RXRoute, BC000H6_A130BR_Medication_PrescriptionDate, BC000H6_n130BR_Medication_PrescriptionDate, BC000H6_A132BR_Medication_AdmitStartDate, BC000H6_n132BR_Medication_AdmitStartDate, BC000H6_A133BR_Medication_AdmitEndDate, BC000H6_n133BR_Medication_AdmitEndDate, BC000H6_A131BR_Medication_InpatientChemo,
               BC000H6_n131BR_Medication_InpatientChemo, BC000H6_A19BR_EncounterID
               }
               , new Object[] {
               BC000H7_A119BR_MedicationID
               }
               , new Object[] {
               BC000H8_A119BR_MedicationID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000H11_A85BR_Information_ID, BC000H11_n85BR_Information_ID
               }
               , new Object[] {
               BC000H12_A36BR_Information_PatientNo, BC000H12_n36BR_Information_PatientNo
               }
               , new Object[] {
               BC000H13_A332BR_Scheme_MedicationID
               }
               , new Object[] {
               BC000H14_A296BR_Medication_SchemeID
               }
               , new Object[] {
               BC000H15_A85BR_Information_ID, BC000H15_n85BR_Information_ID, BC000H15_A119BR_MedicationID, BC000H15_A478BR_Medication_RXFrequency_Code, BC000H15_n478BR_Medication_RXFrequency_Code, BC000H15_A477BR_Medication_RXRoute_Code, BC000H15_n477BR_Medication_RXRoute_Code, BC000H15_A507BR_Medication_InpatientChemo_Code, BC000H15_n507BR_Medication_InpatientChemo_Code, BC000H15_A36BR_Information_PatientNo,
               BC000H15_n36BR_Information_PatientNo, BC000H15_A120BR_Medication_RXID, BC000H15_n120BR_Medication_RXID, BC000H15_A121BR_Medication_RXName, BC000H15_n121BR_Medication_RXName, BC000H15_A499BR_Medication_RXName_Code, BC000H15_n499BR_Medication_RXName_Code, BC000H15_A122BR_Medication_RXCode, BC000H15_n122BR_Medication_RXCode, BC000H15_A123BR_Medication_RXType,
               BC000H15_n123BR_Medication_RXType, BC000H15_A124BR_Medication_RXDose, BC000H15_n124BR_Medication_RXDose, BC000H15_A125BR_Medication_RXUnit, BC000H15_n125BR_Medication_RXUnit, BC000H15_A126BR_Medication_RXFrequency, BC000H15_n126BR_Medication_RXFrequency, BC000H15_A127BR_Medication_RXQuantity, BC000H15_n127BR_Medication_RXQuantity, BC000H15_A128BR_Medication_RXDaysSupply,
               BC000H15_n128BR_Medication_RXDaysSupply, BC000H15_A129BR_Medication_RXRoute, BC000H15_n129BR_Medication_RXRoute, BC000H15_A130BR_Medication_PrescriptionDate, BC000H15_n130BR_Medication_PrescriptionDate, BC000H15_A132BR_Medication_AdmitStartDate, BC000H15_n132BR_Medication_AdmitStartDate, BC000H15_A133BR_Medication_AdmitEndDate, BC000H15_n133BR_Medication_AdmitEndDate, BC000H15_A131BR_Medication_InpatientChemo,
               BC000H15_n131BR_Medication_InpatientChemo, BC000H15_A19BR_EncounterID
               }
            }
         );
         AV22Pgmname = "BR_Medication_BC";
         INITTRN();
         /* Execute Start event if defined. */
         /* Execute user event: Start */
         E120H2 ();
         standaloneNotModal( ) ;
      }

      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short GX_JID ;
      private short Z120BR_Medication_RXID ;
      private short A120BR_Medication_RXID ;
      private short RcdFound18 ;
      private int trnEnded ;
      private int AV23GXV1 ;
      private long Z119BR_MedicationID ;
      private long A119BR_MedicationID ;
      private long AV10Insert_BR_EncounterID ;
      private long Z19BR_EncounterID ;
      private long A19BR_EncounterID ;
      private long Z85BR_Information_ID ;
      private long A85BR_Information_ID ;
      private decimal Z124BR_Medication_RXDose ;
      private decimal A124BR_Medication_RXDose ;
      private decimal Z128BR_Medication_RXDaysSupply ;
      private decimal A128BR_Medication_RXDaysSupply ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String AV22Pgmname ;
      private String sMode18 ;
      private String GXt_char2 ;
      private DateTime Z130BR_Medication_PrescriptionDate ;
      private DateTime A130BR_Medication_PrescriptionDate ;
      private DateTime Z132BR_Medication_AdmitStartDate ;
      private DateTime A132BR_Medication_AdmitStartDate ;
      private DateTime Z133BR_Medication_AdmitEndDate ;
      private DateTime A133BR_Medication_AdmitEndDate ;
      private bool AV13IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool returnInSub ;
      private bool n119BR_MedicationID ;
      private bool n85BR_Information_ID ;
      private bool n478BR_Medication_RXFrequency_Code ;
      private bool n477BR_Medication_RXRoute_Code ;
      private bool n507BR_Medication_InpatientChemo_Code ;
      private bool n36BR_Information_PatientNo ;
      private bool n120BR_Medication_RXID ;
      private bool n121BR_Medication_RXName ;
      private bool n499BR_Medication_RXName_Code ;
      private bool n122BR_Medication_RXCode ;
      private bool n123BR_Medication_RXType ;
      private bool n124BR_Medication_RXDose ;
      private bool n125BR_Medication_RXUnit ;
      private bool n126BR_Medication_RXFrequency ;
      private bool n127BR_Medication_RXQuantity ;
      private bool n128BR_Medication_RXDaysSupply ;
      private bool n129BR_Medication_RXRoute ;
      private bool n130BR_Medication_PrescriptionDate ;
      private bool n132BR_Medication_AdmitStartDate ;
      private bool n133BR_Medication_AdmitEndDate ;
      private bool n131BR_Medication_InpatientChemo ;
      private bool Gx_longc ;
      private String Z478BR_Medication_RXFrequency_Code ;
      private String A478BR_Medication_RXFrequency_Code ;
      private String Z477BR_Medication_RXRoute_Code ;
      private String A477BR_Medication_RXRoute_Code ;
      private String Z507BR_Medication_InpatientChemo_Code ;
      private String A507BR_Medication_InpatientChemo_Code ;
      private String Z121BR_Medication_RXName ;
      private String A121BR_Medication_RXName ;
      private String Z499BR_Medication_RXName_Code ;
      private String A499BR_Medication_RXName_Code ;
      private String Z122BR_Medication_RXCode ;
      private String A122BR_Medication_RXCode ;
      private String Z123BR_Medication_RXType ;
      private String A123BR_Medication_RXType ;
      private String Z125BR_Medication_RXUnit ;
      private String A125BR_Medication_RXUnit ;
      private String Z126BR_Medication_RXFrequency ;
      private String A126BR_Medication_RXFrequency ;
      private String Z127BR_Medication_RXQuantity ;
      private String A127BR_Medication_RXQuantity ;
      private String Z129BR_Medication_RXRoute ;
      private String A129BR_Medication_RXRoute ;
      private String Z131BR_Medication_InpatientChemo ;
      private String A131BR_Medication_InpatientChemo ;
      private String Z36BR_Information_PatientNo ;
      private String A36BR_Information_PatientNo ;
      private IGxSession AV9WebSession ;
      private SdtBR_Medication bcBR_Medication ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] BC000H6_A85BR_Information_ID ;
      private bool[] BC000H6_n85BR_Information_ID ;
      private long[] BC000H6_A119BR_MedicationID ;
      private bool[] BC000H6_n119BR_MedicationID ;
      private String[] BC000H6_A478BR_Medication_RXFrequency_Code ;
      private bool[] BC000H6_n478BR_Medication_RXFrequency_Code ;
      private String[] BC000H6_A477BR_Medication_RXRoute_Code ;
      private bool[] BC000H6_n477BR_Medication_RXRoute_Code ;
      private String[] BC000H6_A507BR_Medication_InpatientChemo_Code ;
      private bool[] BC000H6_n507BR_Medication_InpatientChemo_Code ;
      private String[] BC000H6_A36BR_Information_PatientNo ;
      private bool[] BC000H6_n36BR_Information_PatientNo ;
      private short[] BC000H6_A120BR_Medication_RXID ;
      private bool[] BC000H6_n120BR_Medication_RXID ;
      private String[] BC000H6_A121BR_Medication_RXName ;
      private bool[] BC000H6_n121BR_Medication_RXName ;
      private String[] BC000H6_A499BR_Medication_RXName_Code ;
      private bool[] BC000H6_n499BR_Medication_RXName_Code ;
      private String[] BC000H6_A122BR_Medication_RXCode ;
      private bool[] BC000H6_n122BR_Medication_RXCode ;
      private String[] BC000H6_A123BR_Medication_RXType ;
      private bool[] BC000H6_n123BR_Medication_RXType ;
      private decimal[] BC000H6_A124BR_Medication_RXDose ;
      private bool[] BC000H6_n124BR_Medication_RXDose ;
      private String[] BC000H6_A125BR_Medication_RXUnit ;
      private bool[] BC000H6_n125BR_Medication_RXUnit ;
      private String[] BC000H6_A126BR_Medication_RXFrequency ;
      private bool[] BC000H6_n126BR_Medication_RXFrequency ;
      private String[] BC000H6_A127BR_Medication_RXQuantity ;
      private bool[] BC000H6_n127BR_Medication_RXQuantity ;
      private decimal[] BC000H6_A128BR_Medication_RXDaysSupply ;
      private bool[] BC000H6_n128BR_Medication_RXDaysSupply ;
      private String[] BC000H6_A129BR_Medication_RXRoute ;
      private bool[] BC000H6_n129BR_Medication_RXRoute ;
      private DateTime[] BC000H6_A130BR_Medication_PrescriptionDate ;
      private bool[] BC000H6_n130BR_Medication_PrescriptionDate ;
      private DateTime[] BC000H6_A132BR_Medication_AdmitStartDate ;
      private bool[] BC000H6_n132BR_Medication_AdmitStartDate ;
      private DateTime[] BC000H6_A133BR_Medication_AdmitEndDate ;
      private bool[] BC000H6_n133BR_Medication_AdmitEndDate ;
      private String[] BC000H6_A131BR_Medication_InpatientChemo ;
      private bool[] BC000H6_n131BR_Medication_InpatientChemo ;
      private long[] BC000H6_A19BR_EncounterID ;
      private long[] BC000H4_A85BR_Information_ID ;
      private bool[] BC000H4_n85BR_Information_ID ;
      private String[] BC000H5_A36BR_Information_PatientNo ;
      private bool[] BC000H5_n36BR_Information_PatientNo ;
      private long[] BC000H7_A119BR_MedicationID ;
      private bool[] BC000H7_n119BR_MedicationID ;
      private long[] BC000H3_A119BR_MedicationID ;
      private bool[] BC000H3_n119BR_MedicationID ;
      private String[] BC000H3_A478BR_Medication_RXFrequency_Code ;
      private bool[] BC000H3_n478BR_Medication_RXFrequency_Code ;
      private String[] BC000H3_A477BR_Medication_RXRoute_Code ;
      private bool[] BC000H3_n477BR_Medication_RXRoute_Code ;
      private String[] BC000H3_A507BR_Medication_InpatientChemo_Code ;
      private bool[] BC000H3_n507BR_Medication_InpatientChemo_Code ;
      private short[] BC000H3_A120BR_Medication_RXID ;
      private bool[] BC000H3_n120BR_Medication_RXID ;
      private String[] BC000H3_A121BR_Medication_RXName ;
      private bool[] BC000H3_n121BR_Medication_RXName ;
      private String[] BC000H3_A499BR_Medication_RXName_Code ;
      private bool[] BC000H3_n499BR_Medication_RXName_Code ;
      private String[] BC000H3_A122BR_Medication_RXCode ;
      private bool[] BC000H3_n122BR_Medication_RXCode ;
      private String[] BC000H3_A123BR_Medication_RXType ;
      private bool[] BC000H3_n123BR_Medication_RXType ;
      private decimal[] BC000H3_A124BR_Medication_RXDose ;
      private bool[] BC000H3_n124BR_Medication_RXDose ;
      private String[] BC000H3_A125BR_Medication_RXUnit ;
      private bool[] BC000H3_n125BR_Medication_RXUnit ;
      private String[] BC000H3_A126BR_Medication_RXFrequency ;
      private bool[] BC000H3_n126BR_Medication_RXFrequency ;
      private String[] BC000H3_A127BR_Medication_RXQuantity ;
      private bool[] BC000H3_n127BR_Medication_RXQuantity ;
      private decimal[] BC000H3_A128BR_Medication_RXDaysSupply ;
      private bool[] BC000H3_n128BR_Medication_RXDaysSupply ;
      private String[] BC000H3_A129BR_Medication_RXRoute ;
      private bool[] BC000H3_n129BR_Medication_RXRoute ;
      private DateTime[] BC000H3_A130BR_Medication_PrescriptionDate ;
      private bool[] BC000H3_n130BR_Medication_PrescriptionDate ;
      private DateTime[] BC000H3_A132BR_Medication_AdmitStartDate ;
      private bool[] BC000H3_n132BR_Medication_AdmitStartDate ;
      private DateTime[] BC000H3_A133BR_Medication_AdmitEndDate ;
      private bool[] BC000H3_n133BR_Medication_AdmitEndDate ;
      private String[] BC000H3_A131BR_Medication_InpatientChemo ;
      private bool[] BC000H3_n131BR_Medication_InpatientChemo ;
      private long[] BC000H3_A19BR_EncounterID ;
      private long[] BC000H2_A119BR_MedicationID ;
      private bool[] BC000H2_n119BR_MedicationID ;
      private String[] BC000H2_A478BR_Medication_RXFrequency_Code ;
      private bool[] BC000H2_n478BR_Medication_RXFrequency_Code ;
      private String[] BC000H2_A477BR_Medication_RXRoute_Code ;
      private bool[] BC000H2_n477BR_Medication_RXRoute_Code ;
      private String[] BC000H2_A507BR_Medication_InpatientChemo_Code ;
      private bool[] BC000H2_n507BR_Medication_InpatientChemo_Code ;
      private short[] BC000H2_A120BR_Medication_RXID ;
      private bool[] BC000H2_n120BR_Medication_RXID ;
      private String[] BC000H2_A121BR_Medication_RXName ;
      private bool[] BC000H2_n121BR_Medication_RXName ;
      private String[] BC000H2_A499BR_Medication_RXName_Code ;
      private bool[] BC000H2_n499BR_Medication_RXName_Code ;
      private String[] BC000H2_A122BR_Medication_RXCode ;
      private bool[] BC000H2_n122BR_Medication_RXCode ;
      private String[] BC000H2_A123BR_Medication_RXType ;
      private bool[] BC000H2_n123BR_Medication_RXType ;
      private decimal[] BC000H2_A124BR_Medication_RXDose ;
      private bool[] BC000H2_n124BR_Medication_RXDose ;
      private String[] BC000H2_A125BR_Medication_RXUnit ;
      private bool[] BC000H2_n125BR_Medication_RXUnit ;
      private String[] BC000H2_A126BR_Medication_RXFrequency ;
      private bool[] BC000H2_n126BR_Medication_RXFrequency ;
      private String[] BC000H2_A127BR_Medication_RXQuantity ;
      private bool[] BC000H2_n127BR_Medication_RXQuantity ;
      private decimal[] BC000H2_A128BR_Medication_RXDaysSupply ;
      private bool[] BC000H2_n128BR_Medication_RXDaysSupply ;
      private String[] BC000H2_A129BR_Medication_RXRoute ;
      private bool[] BC000H2_n129BR_Medication_RXRoute ;
      private DateTime[] BC000H2_A130BR_Medication_PrescriptionDate ;
      private bool[] BC000H2_n130BR_Medication_PrescriptionDate ;
      private DateTime[] BC000H2_A132BR_Medication_AdmitStartDate ;
      private bool[] BC000H2_n132BR_Medication_AdmitStartDate ;
      private DateTime[] BC000H2_A133BR_Medication_AdmitEndDate ;
      private bool[] BC000H2_n133BR_Medication_AdmitEndDate ;
      private String[] BC000H2_A131BR_Medication_InpatientChemo ;
      private bool[] BC000H2_n131BR_Medication_InpatientChemo ;
      private long[] BC000H2_A19BR_EncounterID ;
      private long[] BC000H8_A119BR_MedicationID ;
      private bool[] BC000H8_n119BR_MedicationID ;
      private long[] BC000H11_A85BR_Information_ID ;
      private bool[] BC000H11_n85BR_Information_ID ;
      private String[] BC000H12_A36BR_Information_PatientNo ;
      private bool[] BC000H12_n36BR_Information_PatientNo ;
      private long[] BC000H13_A332BR_Scheme_MedicationID ;
      private long[] BC000H14_A296BR_Medication_SchemeID ;
      private long[] BC000H15_A85BR_Information_ID ;
      private bool[] BC000H15_n85BR_Information_ID ;
      private long[] BC000H15_A119BR_MedicationID ;
      private bool[] BC000H15_n119BR_MedicationID ;
      private String[] BC000H15_A478BR_Medication_RXFrequency_Code ;
      private bool[] BC000H15_n478BR_Medication_RXFrequency_Code ;
      private String[] BC000H15_A477BR_Medication_RXRoute_Code ;
      private bool[] BC000H15_n477BR_Medication_RXRoute_Code ;
      private String[] BC000H15_A507BR_Medication_InpatientChemo_Code ;
      private bool[] BC000H15_n507BR_Medication_InpatientChemo_Code ;
      private String[] BC000H15_A36BR_Information_PatientNo ;
      private bool[] BC000H15_n36BR_Information_PatientNo ;
      private short[] BC000H15_A120BR_Medication_RXID ;
      private bool[] BC000H15_n120BR_Medication_RXID ;
      private String[] BC000H15_A121BR_Medication_RXName ;
      private bool[] BC000H15_n121BR_Medication_RXName ;
      private String[] BC000H15_A499BR_Medication_RXName_Code ;
      private bool[] BC000H15_n499BR_Medication_RXName_Code ;
      private String[] BC000H15_A122BR_Medication_RXCode ;
      private bool[] BC000H15_n122BR_Medication_RXCode ;
      private String[] BC000H15_A123BR_Medication_RXType ;
      private bool[] BC000H15_n123BR_Medication_RXType ;
      private decimal[] BC000H15_A124BR_Medication_RXDose ;
      private bool[] BC000H15_n124BR_Medication_RXDose ;
      private String[] BC000H15_A125BR_Medication_RXUnit ;
      private bool[] BC000H15_n125BR_Medication_RXUnit ;
      private String[] BC000H15_A126BR_Medication_RXFrequency ;
      private bool[] BC000H15_n126BR_Medication_RXFrequency ;
      private String[] BC000H15_A127BR_Medication_RXQuantity ;
      private bool[] BC000H15_n127BR_Medication_RXQuantity ;
      private decimal[] BC000H15_A128BR_Medication_RXDaysSupply ;
      private bool[] BC000H15_n128BR_Medication_RXDaysSupply ;
      private String[] BC000H15_A129BR_Medication_RXRoute ;
      private bool[] BC000H15_n129BR_Medication_RXRoute ;
      private DateTime[] BC000H15_A130BR_Medication_PrescriptionDate ;
      private bool[] BC000H15_n130BR_Medication_PrescriptionDate ;
      private DateTime[] BC000H15_A132BR_Medication_AdmitStartDate ;
      private bool[] BC000H15_n132BR_Medication_AdmitStartDate ;
      private DateTime[] BC000H15_A133BR_Medication_AdmitEndDate ;
      private bool[] BC000H15_n133BR_Medication_AdmitEndDate ;
      private String[] BC000H15_A131BR_Medication_InpatientChemo ;
      private bool[] BC000H15_n131BR_Medication_InpatientChemo ;
      private long[] BC000H15_A19BR_EncounterID ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_datastore1 ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV7WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV8TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV11TrnContextAtt ;
   }

   public class br_medication_bc__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class br_medication_bc__default : DataStoreHelperBase, IDataStoreHelper
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
        Object[] prmBC000H6 ;
        prmBC000H6 = new Object[] {
        new Object[] {"@BR_MedicationID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000H4 ;
        prmBC000H4 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000H5 ;
        prmBC000H5 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000H7 ;
        prmBC000H7 = new Object[] {
        new Object[] {"@BR_MedicationID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000H3 ;
        prmBC000H3 = new Object[] {
        new Object[] {"@BR_MedicationID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000H2 ;
        prmBC000H2 = new Object[] {
        new Object[] {"@BR_MedicationID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000H8 ;
        prmBC000H8 = new Object[] {
        new Object[] {"@BR_Medication_RXFrequency_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Medication_RXRoute_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Medication_InpatientChemo_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Medication_RXID",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@BR_Medication_RXName",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Medication_RXName_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Medication_RXCode",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Medication_RXType",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Medication_RXDose",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_Medication_RXUnit",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Medication_RXFrequency",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Medication_RXQuantity",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Medication_RXDaysSupply",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_Medication_RXRoute",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Medication_PrescriptionDate",SqlDbType.DateTime,8,0} ,
        new Object[] {"@BR_Medication_AdmitStartDate",SqlDbType.DateTime,8,0} ,
        new Object[] {"@BR_Medication_AdmitEndDate",SqlDbType.DateTime,8,0} ,
        new Object[] {"@BR_Medication_InpatientChemo",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000H9 ;
        prmBC000H9 = new Object[] {
        new Object[] {"@BR_Medication_RXFrequency_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Medication_RXRoute_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Medication_InpatientChemo_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Medication_RXID",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@BR_Medication_RXName",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Medication_RXName_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Medication_RXCode",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Medication_RXType",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Medication_RXDose",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_Medication_RXUnit",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Medication_RXFrequency",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Medication_RXQuantity",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Medication_RXDaysSupply",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_Medication_RXRoute",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Medication_PrescriptionDate",SqlDbType.DateTime,8,0} ,
        new Object[] {"@BR_Medication_AdmitStartDate",SqlDbType.DateTime,8,0} ,
        new Object[] {"@BR_Medication_AdmitEndDate",SqlDbType.DateTime,8,0} ,
        new Object[] {"@BR_Medication_InpatientChemo",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_MedicationID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000H10 ;
        prmBC000H10 = new Object[] {
        new Object[] {"@BR_MedicationID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000H11 ;
        prmBC000H11 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000H12 ;
        prmBC000H12 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000H13 ;
        prmBC000H13 = new Object[] {
        new Object[] {"@BR_MedicationID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000H14 ;
        prmBC000H14 = new Object[] {
        new Object[] {"@BR_MedicationID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000H15 ;
        prmBC000H15 = new Object[] {
        new Object[] {"@BR_MedicationID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("BC000H2", "SELECT [BR_MedicationID], [BR_Medication_RXFrequency_Code], [BR_Medication_RXRoute_Code], [BR_Medication_InpatientChemo_Code], [BR_Medication_RXID], [BR_Medication_RXName], [BR_Medication_RXName_Code], [BR_Medication_RXCode], [BR_Medication_RXType], [BR_Medication_RXDose], [BR_Medication_RXUnit], [BR_Medication_RXFrequency], [BR_Medication_RXQuantity], [BR_Medication_RXDaysSupply], [BR_Medication_RXRoute], [BR_Medication_PrescriptionDate], [BR_Medication_AdmitStartDate], [BR_Medication_AdmitEndDate], [BR_Medication_InpatientChemo], [BR_EncounterID] FROM [BR_Medication] WITH (UPDLOCK) WHERE [BR_MedicationID] = @BR_MedicationID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000H2,1,0,true,false )
           ,new CursorDef("BC000H3", "SELECT [BR_MedicationID], [BR_Medication_RXFrequency_Code], [BR_Medication_RXRoute_Code], [BR_Medication_InpatientChemo_Code], [BR_Medication_RXID], [BR_Medication_RXName], [BR_Medication_RXName_Code], [BR_Medication_RXCode], [BR_Medication_RXType], [BR_Medication_RXDose], [BR_Medication_RXUnit], [BR_Medication_RXFrequency], [BR_Medication_RXQuantity], [BR_Medication_RXDaysSupply], [BR_Medication_RXRoute], [BR_Medication_PrescriptionDate], [BR_Medication_AdmitStartDate], [BR_Medication_AdmitEndDate], [BR_Medication_InpatientChemo], [BR_EncounterID] FROM [BR_Medication] WITH (NOLOCK) WHERE [BR_MedicationID] = @BR_MedicationID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000H3,1,0,true,false )
           ,new CursorDef("BC000H4", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000H4,1,0,true,false )
           ,new CursorDef("BC000H5", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000H5,1,0,true,false )
           ,new CursorDef("BC000H6", "SELECT T2.[BR_Information_ID], TM1.[BR_MedicationID], TM1.[BR_Medication_RXFrequency_Code], TM1.[BR_Medication_RXRoute_Code], TM1.[BR_Medication_InpatientChemo_Code], T3.[BR_Information_PatientNo], TM1.[BR_Medication_RXID], TM1.[BR_Medication_RXName], TM1.[BR_Medication_RXName_Code], TM1.[BR_Medication_RXCode], TM1.[BR_Medication_RXType], TM1.[BR_Medication_RXDose], TM1.[BR_Medication_RXUnit], TM1.[BR_Medication_RXFrequency], TM1.[BR_Medication_RXQuantity], TM1.[BR_Medication_RXDaysSupply], TM1.[BR_Medication_RXRoute], TM1.[BR_Medication_PrescriptionDate], TM1.[BR_Medication_AdmitStartDate], TM1.[BR_Medication_AdmitEndDate], TM1.[BR_Medication_InpatientChemo], TM1.[BR_EncounterID] FROM (([BR_Medication] TM1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = TM1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID]) WHERE TM1.[BR_MedicationID] = @BR_MedicationID ORDER BY TM1.[BR_MedicationID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000H6,100,0,true,false )
           ,new CursorDef("BC000H7", "SELECT [BR_MedicationID] FROM [BR_Medication] WITH (NOLOCK) WHERE [BR_MedicationID] = @BR_MedicationID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000H7,1,0,true,false )
           ,new CursorDef("BC000H8", "INSERT INTO [BR_Medication]([BR_Medication_RXFrequency_Code], [BR_Medication_RXRoute_Code], [BR_Medication_InpatientChemo_Code], [BR_Medication_RXID], [BR_Medication_RXName], [BR_Medication_RXName_Code], [BR_Medication_RXCode], [BR_Medication_RXType], [BR_Medication_RXDose], [BR_Medication_RXUnit], [BR_Medication_RXFrequency], [BR_Medication_RXQuantity], [BR_Medication_RXDaysSupply], [BR_Medication_RXRoute], [BR_Medication_PrescriptionDate], [BR_Medication_AdmitStartDate], [BR_Medication_AdmitEndDate], [BR_Medication_InpatientChemo], [BR_EncounterID]) VALUES(@BR_Medication_RXFrequency_Code, @BR_Medication_RXRoute_Code, @BR_Medication_InpatientChemo_Code, @BR_Medication_RXID, @BR_Medication_RXName, @BR_Medication_RXName_Code, @BR_Medication_RXCode, @BR_Medication_RXType, @BR_Medication_RXDose, @BR_Medication_RXUnit, @BR_Medication_RXFrequency, @BR_Medication_RXQuantity, @BR_Medication_RXDaysSupply, @BR_Medication_RXRoute, @BR_Medication_PrescriptionDate, @BR_Medication_AdmitStartDate, @BR_Medication_AdmitEndDate, @BR_Medication_InpatientChemo, @BR_EncounterID); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmBC000H8)
           ,new CursorDef("BC000H9", "UPDATE [BR_Medication] SET [BR_Medication_RXFrequency_Code]=@BR_Medication_RXFrequency_Code, [BR_Medication_RXRoute_Code]=@BR_Medication_RXRoute_Code, [BR_Medication_InpatientChemo_Code]=@BR_Medication_InpatientChemo_Code, [BR_Medication_RXID]=@BR_Medication_RXID, [BR_Medication_RXName]=@BR_Medication_RXName, [BR_Medication_RXName_Code]=@BR_Medication_RXName_Code, [BR_Medication_RXCode]=@BR_Medication_RXCode, [BR_Medication_RXType]=@BR_Medication_RXType, [BR_Medication_RXDose]=@BR_Medication_RXDose, [BR_Medication_RXUnit]=@BR_Medication_RXUnit, [BR_Medication_RXFrequency]=@BR_Medication_RXFrequency, [BR_Medication_RXQuantity]=@BR_Medication_RXQuantity, [BR_Medication_RXDaysSupply]=@BR_Medication_RXDaysSupply, [BR_Medication_RXRoute]=@BR_Medication_RXRoute, [BR_Medication_PrescriptionDate]=@BR_Medication_PrescriptionDate, [BR_Medication_AdmitStartDate]=@BR_Medication_AdmitStartDate, [BR_Medication_AdmitEndDate]=@BR_Medication_AdmitEndDate, [BR_Medication_InpatientChemo]=@BR_Medication_InpatientChemo, [BR_EncounterID]=@BR_EncounterID  WHERE [BR_MedicationID] = @BR_MedicationID", GxErrorMask.GX_NOMASK,prmBC000H9)
           ,new CursorDef("BC000H10", "DELETE FROM [BR_Medication]  WHERE [BR_MedicationID] = @BR_MedicationID", GxErrorMask.GX_NOMASK,prmBC000H10)
           ,new CursorDef("BC000H11", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000H11,1,0,true,false )
           ,new CursorDef("BC000H12", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000H12,1,0,true,false )
           ,new CursorDef("BC000H13", "SELECT TOP 1 [BR_Scheme_MedicationID] FROM [BR_Scheme_Medication] WITH (NOLOCK) WHERE [BR_MedicationID] = @BR_MedicationID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000H13,1,0,true,true )
           ,new CursorDef("BC000H14", "SELECT TOP 1 [BR_Medication_SchemeID] FROM [BR_Medication_Scheme] WITH (NOLOCK) WHERE [BR_MedicationID] = @BR_MedicationID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000H14,1,0,true,true )
           ,new CursorDef("BC000H15", "SELECT T2.[BR_Information_ID], TM1.[BR_MedicationID], TM1.[BR_Medication_RXFrequency_Code], TM1.[BR_Medication_RXRoute_Code], TM1.[BR_Medication_InpatientChemo_Code], T3.[BR_Information_PatientNo], TM1.[BR_Medication_RXID], TM1.[BR_Medication_RXName], TM1.[BR_Medication_RXName_Code], TM1.[BR_Medication_RXCode], TM1.[BR_Medication_RXType], TM1.[BR_Medication_RXDose], TM1.[BR_Medication_RXUnit], TM1.[BR_Medication_RXFrequency], TM1.[BR_Medication_RXQuantity], TM1.[BR_Medication_RXDaysSupply], TM1.[BR_Medication_RXRoute], TM1.[BR_Medication_PrescriptionDate], TM1.[BR_Medication_AdmitStartDate], TM1.[BR_Medication_AdmitEndDate], TM1.[BR_Medication_InpatientChemo], TM1.[BR_EncounterID] FROM (([BR_Medication] TM1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = TM1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID]) WHERE TM1.[BR_MedicationID] = @BR_MedicationID ORDER BY TM1.[BR_MedicationID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000H15,100,0,true,false )
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
              ((short[]) buf[7])[0] = rslt.getShort(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((decimal[]) buf[17])[0] = rslt.getDecimal(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              ((String[]) buf[19])[0] = rslt.getVarchar(11) ;
              ((bool[]) buf[20])[0] = rslt.wasNull(11);
              ((String[]) buf[21])[0] = rslt.getVarchar(12) ;
              ((bool[]) buf[22])[0] = rslt.wasNull(12);
              ((String[]) buf[23])[0] = rslt.getVarchar(13) ;
              ((bool[]) buf[24])[0] = rslt.wasNull(13);
              ((decimal[]) buf[25])[0] = rslt.getDecimal(14) ;
              ((bool[]) buf[26])[0] = rslt.wasNull(14);
              ((String[]) buf[27])[0] = rslt.getVarchar(15) ;
              ((bool[]) buf[28])[0] = rslt.wasNull(15);
              ((DateTime[]) buf[29])[0] = rslt.getGXDate(16) ;
              ((bool[]) buf[30])[0] = rslt.wasNull(16);
              ((DateTime[]) buf[31])[0] = rslt.getGXDate(17) ;
              ((bool[]) buf[32])[0] = rslt.wasNull(17);
              ((DateTime[]) buf[33])[0] = rslt.getGXDate(18) ;
              ((bool[]) buf[34])[0] = rslt.wasNull(18);
              ((String[]) buf[35])[0] = rslt.getVarchar(19) ;
              ((bool[]) buf[36])[0] = rslt.wasNull(19);
              ((long[]) buf[37])[0] = rslt.getLong(20) ;
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((short[]) buf[7])[0] = rslt.getShort(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((decimal[]) buf[17])[0] = rslt.getDecimal(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              ((String[]) buf[19])[0] = rslt.getVarchar(11) ;
              ((bool[]) buf[20])[0] = rslt.wasNull(11);
              ((String[]) buf[21])[0] = rslt.getVarchar(12) ;
              ((bool[]) buf[22])[0] = rslt.wasNull(12);
              ((String[]) buf[23])[0] = rslt.getVarchar(13) ;
              ((bool[]) buf[24])[0] = rslt.wasNull(13);
              ((decimal[]) buf[25])[0] = rslt.getDecimal(14) ;
              ((bool[]) buf[26])[0] = rslt.wasNull(14);
              ((String[]) buf[27])[0] = rslt.getVarchar(15) ;
              ((bool[]) buf[28])[0] = rslt.wasNull(15);
              ((DateTime[]) buf[29])[0] = rslt.getGXDate(16) ;
              ((bool[]) buf[30])[0] = rslt.wasNull(16);
              ((DateTime[]) buf[31])[0] = rslt.getGXDate(17) ;
              ((bool[]) buf[32])[0] = rslt.wasNull(17);
              ((DateTime[]) buf[33])[0] = rslt.getGXDate(18) ;
              ((bool[]) buf[34])[0] = rslt.wasNull(18);
              ((String[]) buf[35])[0] = rslt.getVarchar(19) ;
              ((bool[]) buf[36])[0] = rslt.wasNull(19);
              ((long[]) buf[37])[0] = rslt.getLong(20) ;
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
              ((short[]) buf[11])[0] = rslt.getShort(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((String[]) buf[17])[0] = rslt.getVarchar(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              ((String[]) buf[19])[0] = rslt.getVarchar(11) ;
              ((bool[]) buf[20])[0] = rslt.wasNull(11);
              ((decimal[]) buf[21])[0] = rslt.getDecimal(12) ;
              ((bool[]) buf[22])[0] = rslt.wasNull(12);
              ((String[]) buf[23])[0] = rslt.getVarchar(13) ;
              ((bool[]) buf[24])[0] = rslt.wasNull(13);
              ((String[]) buf[25])[0] = rslt.getVarchar(14) ;
              ((bool[]) buf[26])[0] = rslt.wasNull(14);
              ((String[]) buf[27])[0] = rslt.getVarchar(15) ;
              ((bool[]) buf[28])[0] = rslt.wasNull(15);
              ((decimal[]) buf[29])[0] = rslt.getDecimal(16) ;
              ((bool[]) buf[30])[0] = rslt.wasNull(16);
              ((String[]) buf[31])[0] = rslt.getVarchar(17) ;
              ((bool[]) buf[32])[0] = rslt.wasNull(17);
              ((DateTime[]) buf[33])[0] = rslt.getGXDate(18) ;
              ((bool[]) buf[34])[0] = rslt.wasNull(18);
              ((DateTime[]) buf[35])[0] = rslt.getGXDate(19) ;
              ((bool[]) buf[36])[0] = rslt.wasNull(19);
              ((DateTime[]) buf[37])[0] = rslt.getGXDate(20) ;
              ((bool[]) buf[38])[0] = rslt.wasNull(20);
              ((String[]) buf[39])[0] = rslt.getVarchar(21) ;
              ((bool[]) buf[40])[0] = rslt.wasNull(21);
              ((long[]) buf[41])[0] = rslt.getLong(22) ;
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
              return;
           case 12 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 13 :
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
              ((short[]) buf[11])[0] = rslt.getShort(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((String[]) buf[17])[0] = rslt.getVarchar(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              ((String[]) buf[19])[0] = rslt.getVarchar(11) ;
              ((bool[]) buf[20])[0] = rslt.wasNull(11);
              ((decimal[]) buf[21])[0] = rslt.getDecimal(12) ;
              ((bool[]) buf[22])[0] = rslt.wasNull(12);
              ((String[]) buf[23])[0] = rslt.getVarchar(13) ;
              ((bool[]) buf[24])[0] = rslt.wasNull(13);
              ((String[]) buf[25])[0] = rslt.getVarchar(14) ;
              ((bool[]) buf[26])[0] = rslt.wasNull(14);
              ((String[]) buf[27])[0] = rslt.getVarchar(15) ;
              ((bool[]) buf[28])[0] = rslt.wasNull(15);
              ((decimal[]) buf[29])[0] = rslt.getDecimal(16) ;
              ((bool[]) buf[30])[0] = rslt.wasNull(16);
              ((String[]) buf[31])[0] = rslt.getVarchar(17) ;
              ((bool[]) buf[32])[0] = rslt.wasNull(17);
              ((DateTime[]) buf[33])[0] = rslt.getGXDate(18) ;
              ((bool[]) buf[34])[0] = rslt.wasNull(18);
              ((DateTime[]) buf[35])[0] = rslt.getGXDate(19) ;
              ((bool[]) buf[36])[0] = rslt.wasNull(19);
              ((DateTime[]) buf[37])[0] = rslt.getGXDate(20) ;
              ((bool[]) buf[38])[0] = rslt.wasNull(20);
              ((String[]) buf[39])[0] = rslt.getVarchar(21) ;
              ((bool[]) buf[40])[0] = rslt.wasNull(21);
              ((long[]) buf[41])[0] = rslt.getLong(22) ;
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
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 1 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
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
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 5 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
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
              if ( (bool)parms[6] )
              {
                 stmt.setNull( 4 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(4, (short)parms[7]);
              }
              if ( (bool)parms[8] )
              {
                 stmt.setNull( 5 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(5, (String)parms[9]);
              }
              if ( (bool)parms[10] )
              {
                 stmt.setNull( 6 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(6, (String)parms[11]);
              }
              if ( (bool)parms[12] )
              {
                 stmt.setNull( 7 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(7, (String)parms[13]);
              }
              if ( (bool)parms[14] )
              {
                 stmt.setNull( 8 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(8, (String)parms[15]);
              }
              if ( (bool)parms[16] )
              {
                 stmt.setNull( 9 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(9, (decimal)parms[17]);
              }
              if ( (bool)parms[18] )
              {
                 stmt.setNull( 10 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(10, (String)parms[19]);
              }
              if ( (bool)parms[20] )
              {
                 stmt.setNull( 11 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(11, (String)parms[21]);
              }
              if ( (bool)parms[22] )
              {
                 stmt.setNull( 12 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(12, (String)parms[23]);
              }
              if ( (bool)parms[24] )
              {
                 stmt.setNull( 13 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(13, (decimal)parms[25]);
              }
              if ( (bool)parms[26] )
              {
                 stmt.setNull( 14 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(14, (String)parms[27]);
              }
              if ( (bool)parms[28] )
              {
                 stmt.setNull( 15 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameter(15, (DateTime)parms[29]);
              }
              if ( (bool)parms[30] )
              {
                 stmt.setNull( 16 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameter(16, (DateTime)parms[31]);
              }
              if ( (bool)parms[32] )
              {
                 stmt.setNull( 17 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameter(17, (DateTime)parms[33]);
              }
              if ( (bool)parms[34] )
              {
                 stmt.setNull( 18 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(18, (String)parms[35]);
              }
              stmt.SetParameter(19, (long)parms[36]);
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
              if ( (bool)parms[6] )
              {
                 stmt.setNull( 4 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(4, (short)parms[7]);
              }
              if ( (bool)parms[8] )
              {
                 stmt.setNull( 5 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(5, (String)parms[9]);
              }
              if ( (bool)parms[10] )
              {
                 stmt.setNull( 6 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(6, (String)parms[11]);
              }
              if ( (bool)parms[12] )
              {
                 stmt.setNull( 7 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(7, (String)parms[13]);
              }
              if ( (bool)parms[14] )
              {
                 stmt.setNull( 8 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(8, (String)parms[15]);
              }
              if ( (bool)parms[16] )
              {
                 stmt.setNull( 9 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(9, (decimal)parms[17]);
              }
              if ( (bool)parms[18] )
              {
                 stmt.setNull( 10 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(10, (String)parms[19]);
              }
              if ( (bool)parms[20] )
              {
                 stmt.setNull( 11 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(11, (String)parms[21]);
              }
              if ( (bool)parms[22] )
              {
                 stmt.setNull( 12 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(12, (String)parms[23]);
              }
              if ( (bool)parms[24] )
              {
                 stmt.setNull( 13 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(13, (decimal)parms[25]);
              }
              if ( (bool)parms[26] )
              {
                 stmt.setNull( 14 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(14, (String)parms[27]);
              }
              if ( (bool)parms[28] )
              {
                 stmt.setNull( 15 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameter(15, (DateTime)parms[29]);
              }
              if ( (bool)parms[30] )
              {
                 stmt.setNull( 16 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameter(16, (DateTime)parms[31]);
              }
              if ( (bool)parms[32] )
              {
                 stmt.setNull( 17 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameter(17, (DateTime)parms[33]);
              }
              if ( (bool)parms[34] )
              {
                 stmt.setNull( 18 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(18, (String)parms[35]);
              }
              stmt.SetParameter(19, (long)parms[36]);
              if ( (bool)parms[37] )
              {
                 stmt.setNull( 20 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(20, (long)parms[38]);
              }
              return;
           case 8 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
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
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 12 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 13 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
     }
  }

}

}
