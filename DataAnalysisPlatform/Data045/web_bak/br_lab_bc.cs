/*
               File: BR_Lab_BC
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:36:45.40
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
   public class br_lab_bc : GXHttpHandler, IGxSilentTrn
   {
      public br_lab_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_lab_bc( IGxContext context )
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
         ReadRow0G17( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey0G17( ) ;
         standaloneModal( ) ;
         AddRow0G17( ) ;
         Gx_mode = "INS";
         return  ;
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E110G2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               Z101BR_LabID = A101BR_LabID;
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

      protected void CONFIRM_0G0( )
      {
         BeforeValidate0G17( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0G17( ) ;
            }
            else
            {
               CheckExtendedTable0G17( ) ;
               if ( AnyError == 0 )
               {
                  ZM0G17( 18) ;
                  ZM0G17( 19) ;
               }
               CloseExtendedTableCursors0G17( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void E120G2( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV7WWPContext) ;
         AV13IsAuthorized = true;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            GXt_boolean1 = AV13IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Lab", out  GXt_boolean1) ;
            AV13IsAuthorized = GXt_boolean1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            GXt_boolean1 = AV13IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Lab", out  GXt_boolean1) ;
            AV13IsAuthorized = GXt_boolean1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            GXt_boolean1 = AV13IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Lab", out  GXt_boolean1) ;
            AV13IsAuthorized = GXt_boolean1;
         }
         if ( ! AV13IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV17Pgmname)));
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
         if ( ( StringUtil.StrCmp(AV8TrnContext.gxTpr_Transactionname, AV17Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV18GXV1 = 1;
            while ( AV18GXV1 <= AV8TrnContext.gxTpr_Attributes.Count )
            {
               AV11TrnContextAtt = ((GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute)AV8TrnContext.gxTpr_Attributes.Item(AV18GXV1));
               if ( StringUtil.StrCmp(AV11TrnContextAtt.gxTpr_Attributename, "BR_EncounterID") == 0 )
               {
                  AV10Insert_BR_EncounterID = (long)(NumberUtil.Val( AV11TrnContextAtt.gxTpr_Attributevalue, "."));
               }
               AV18GXV1 = (int)(AV18GXV1+1);
            }
         }
      }

      protected void E110G2( )
      {
         /* After Trn Routine */
      }

      protected void S112( )
      {
         /* 'ATTRIBUTESSECURITYCODE' Routine */
      }

      protected void ZM0G17( short GX_JID )
      {
         if ( ( GX_JID == 17 ) || ( GX_JID == 0 ) )
         {
            Z474BR_Lab_SpecimenSource_Code = A474BR_Lab_SpecimenSource_Code;
            Z475BR_Lab_ResultQual_Code = A475BR_Lab_ResultQual_Code;
            Z476BR_Lab_AbnInd_Code = A476BR_Lab_AbnInd_Code;
            Z224BR_Lab_SampleID = A224BR_Lab_SampleID;
            Z102BR_Lab_TestID = A102BR_Lab_TestID;
            Z103BR_Lab_TestCode = A103BR_Lab_TestCode;
            Z104BR_Lab_TestName = A104BR_Lab_TestName;
            Z261BR_Lab_TestEngName = A261BR_Lab_TestEngName;
            Z262BR_Lab_Age = A262BR_Lab_Age;
            Z263BR_Lab_Diag = A263BR_Lab_Diag;
            Z105BR_Lab_SpecimenDate = A105BR_Lab_SpecimenDate;
            Z264BR_Lab_ReceivingTime = A264BR_Lab_ReceivingTime;
            Z265BR_Lab_ReportTime = A265BR_Lab_ReportTime;
            Z106BR_Lab_SpecimenSource = A106BR_Lab_SpecimenSource;
            Z109BR_Lab_ResultQual = A109BR_Lab_ResultQual;
            Z110BR_Lab_ResultNum = A110BR_Lab_ResultNum;
            Z111BR_Lab_ResultUnit = A111BR_Lab_ResultUnit;
            Z112BR_Lab_AbnInd = A112BR_Lab_AbnInd;
            Z113BR_Lab_NormRangeLow = A113BR_Lab_NormRangeLow;
            Z114BR_Lab_NormRangeHigh = A114BR_Lab_NormRangeHigh;
            Z115BR_Lab_TestMethod = A115BR_Lab_TestMethod;
            Z117BR_Lab_InstrumentName = A117BR_Lab_InstrumentName;
            Z118BR_Lab_InstrumentCode = A118BR_Lab_InstrumentCode;
            Z430BR_SampleId = A430BR_SampleId;
            Z19BR_EncounterID = A19BR_EncounterID;
         }
         if ( ( GX_JID == 18 ) || ( GX_JID == 0 ) )
         {
            Z85BR_Information_ID = A85BR_Information_ID;
         }
         if ( ( GX_JID == 19 ) || ( GX_JID == 0 ) )
         {
            Z36BR_Information_PatientNo = A36BR_Information_PatientNo;
         }
         if ( GX_JID == -17 )
         {
            Z101BR_LabID = A101BR_LabID;
            Z474BR_Lab_SpecimenSource_Code = A474BR_Lab_SpecimenSource_Code;
            Z475BR_Lab_ResultQual_Code = A475BR_Lab_ResultQual_Code;
            Z476BR_Lab_AbnInd_Code = A476BR_Lab_AbnInd_Code;
            Z224BR_Lab_SampleID = A224BR_Lab_SampleID;
            Z102BR_Lab_TestID = A102BR_Lab_TestID;
            Z103BR_Lab_TestCode = A103BR_Lab_TestCode;
            Z104BR_Lab_TestName = A104BR_Lab_TestName;
            Z261BR_Lab_TestEngName = A261BR_Lab_TestEngName;
            Z262BR_Lab_Age = A262BR_Lab_Age;
            Z263BR_Lab_Diag = A263BR_Lab_Diag;
            Z105BR_Lab_SpecimenDate = A105BR_Lab_SpecimenDate;
            Z264BR_Lab_ReceivingTime = A264BR_Lab_ReceivingTime;
            Z265BR_Lab_ReportTime = A265BR_Lab_ReportTime;
            Z106BR_Lab_SpecimenSource = A106BR_Lab_SpecimenSource;
            Z109BR_Lab_ResultQual = A109BR_Lab_ResultQual;
            Z110BR_Lab_ResultNum = A110BR_Lab_ResultNum;
            Z111BR_Lab_ResultUnit = A111BR_Lab_ResultUnit;
            Z112BR_Lab_AbnInd = A112BR_Lab_AbnInd;
            Z113BR_Lab_NormRangeLow = A113BR_Lab_NormRangeLow;
            Z114BR_Lab_NormRangeHigh = A114BR_Lab_NormRangeHigh;
            Z115BR_Lab_TestMethod = A115BR_Lab_TestMethod;
            Z117BR_Lab_InstrumentName = A117BR_Lab_InstrumentName;
            Z118BR_Lab_InstrumentCode = A118BR_Lab_InstrumentCode;
            Z430BR_SampleId = A430BR_SampleId;
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

      protected void Load0G17( )
      {
         /* Using cursor BC000G6 */
         pr_default.execute(4, new Object[] {A101BR_LabID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound17 = 1;
            A85BR_Information_ID = BC000G6_A85BR_Information_ID[0];
            n85BR_Information_ID = BC000G6_n85BR_Information_ID[0];
            A474BR_Lab_SpecimenSource_Code = BC000G6_A474BR_Lab_SpecimenSource_Code[0];
            n474BR_Lab_SpecimenSource_Code = BC000G6_n474BR_Lab_SpecimenSource_Code[0];
            A475BR_Lab_ResultQual_Code = BC000G6_A475BR_Lab_ResultQual_Code[0];
            n475BR_Lab_ResultQual_Code = BC000G6_n475BR_Lab_ResultQual_Code[0];
            A476BR_Lab_AbnInd_Code = BC000G6_A476BR_Lab_AbnInd_Code[0];
            n476BR_Lab_AbnInd_Code = BC000G6_n476BR_Lab_AbnInd_Code[0];
            A36BR_Information_PatientNo = BC000G6_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = BC000G6_n36BR_Information_PatientNo[0];
            A224BR_Lab_SampleID = BC000G6_A224BR_Lab_SampleID[0];
            n224BR_Lab_SampleID = BC000G6_n224BR_Lab_SampleID[0];
            A102BR_Lab_TestID = BC000G6_A102BR_Lab_TestID[0];
            n102BR_Lab_TestID = BC000G6_n102BR_Lab_TestID[0];
            A103BR_Lab_TestCode = BC000G6_A103BR_Lab_TestCode[0];
            n103BR_Lab_TestCode = BC000G6_n103BR_Lab_TestCode[0];
            A104BR_Lab_TestName = BC000G6_A104BR_Lab_TestName[0];
            n104BR_Lab_TestName = BC000G6_n104BR_Lab_TestName[0];
            A261BR_Lab_TestEngName = BC000G6_A261BR_Lab_TestEngName[0];
            n261BR_Lab_TestEngName = BC000G6_n261BR_Lab_TestEngName[0];
            A262BR_Lab_Age = BC000G6_A262BR_Lab_Age[0];
            n262BR_Lab_Age = BC000G6_n262BR_Lab_Age[0];
            A263BR_Lab_Diag = BC000G6_A263BR_Lab_Diag[0];
            n263BR_Lab_Diag = BC000G6_n263BR_Lab_Diag[0];
            A105BR_Lab_SpecimenDate = BC000G6_A105BR_Lab_SpecimenDate[0];
            n105BR_Lab_SpecimenDate = BC000G6_n105BR_Lab_SpecimenDate[0];
            A264BR_Lab_ReceivingTime = BC000G6_A264BR_Lab_ReceivingTime[0];
            n264BR_Lab_ReceivingTime = BC000G6_n264BR_Lab_ReceivingTime[0];
            A265BR_Lab_ReportTime = BC000G6_A265BR_Lab_ReportTime[0];
            n265BR_Lab_ReportTime = BC000G6_n265BR_Lab_ReportTime[0];
            A106BR_Lab_SpecimenSource = BC000G6_A106BR_Lab_SpecimenSource[0];
            n106BR_Lab_SpecimenSource = BC000G6_n106BR_Lab_SpecimenSource[0];
            A109BR_Lab_ResultQual = BC000G6_A109BR_Lab_ResultQual[0];
            n109BR_Lab_ResultQual = BC000G6_n109BR_Lab_ResultQual[0];
            A110BR_Lab_ResultNum = BC000G6_A110BR_Lab_ResultNum[0];
            n110BR_Lab_ResultNum = BC000G6_n110BR_Lab_ResultNum[0];
            A111BR_Lab_ResultUnit = BC000G6_A111BR_Lab_ResultUnit[0];
            n111BR_Lab_ResultUnit = BC000G6_n111BR_Lab_ResultUnit[0];
            A112BR_Lab_AbnInd = BC000G6_A112BR_Lab_AbnInd[0];
            n112BR_Lab_AbnInd = BC000G6_n112BR_Lab_AbnInd[0];
            A113BR_Lab_NormRangeLow = BC000G6_A113BR_Lab_NormRangeLow[0];
            n113BR_Lab_NormRangeLow = BC000G6_n113BR_Lab_NormRangeLow[0];
            A114BR_Lab_NormRangeHigh = BC000G6_A114BR_Lab_NormRangeHigh[0];
            n114BR_Lab_NormRangeHigh = BC000G6_n114BR_Lab_NormRangeHigh[0];
            A115BR_Lab_TestMethod = BC000G6_A115BR_Lab_TestMethod[0];
            n115BR_Lab_TestMethod = BC000G6_n115BR_Lab_TestMethod[0];
            A117BR_Lab_InstrumentName = BC000G6_A117BR_Lab_InstrumentName[0];
            n117BR_Lab_InstrumentName = BC000G6_n117BR_Lab_InstrumentName[0];
            A118BR_Lab_InstrumentCode = BC000G6_A118BR_Lab_InstrumentCode[0];
            n118BR_Lab_InstrumentCode = BC000G6_n118BR_Lab_InstrumentCode[0];
            A430BR_SampleId = BC000G6_A430BR_SampleId[0];
            n430BR_SampleId = BC000G6_n430BR_SampleId[0];
            A19BR_EncounterID = BC000G6_A19BR_EncounterID[0];
            ZM0G17( -17) ;
         }
         pr_default.close(4);
         OnLoadActions0G17( ) ;
      }

      protected void OnLoadActions0G17( )
      {
         AV17Pgmname = "BR_Lab_BC";
      }

      protected void CheckExtendedTable0G17( )
      {
         standaloneModal( ) ;
         AV17Pgmname = "BR_Lab_BC";
         /* Using cursor BC000G4 */
         pr_default.execute(2, new Object[] {A19BR_EncounterID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("不匹配' T15'", "ForeignKeyNotFound", 1, "BR_ENCOUNTERID");
            AnyError = 1;
         }
         A85BR_Information_ID = BC000G4_A85BR_Information_ID[0];
         n85BR_Information_ID = BC000G4_n85BR_Information_ID[0];
         pr_default.close(2);
         /* Using cursor BC000G5 */
         pr_default.execute(3, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
         if ( (pr_default.getStatus(3) == 101) )
         {
            if ( ! ( (0==A85BR_Information_ID) ) )
            {
               GX_msglist.addItem("不匹配' T16'", "ForeignKeyNotFound", 1, "");
               AnyError = 1;
            }
         }
         A36BR_Information_PatientNo = BC000G5_A36BR_Information_PatientNo[0];
         n36BR_Information_PatientNo = BC000G5_n36BR_Information_PatientNo[0];
         pr_default.close(3);
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A104BR_Lab_TestName)) )
         {
            GX_msglist.addItem("项目名称是必须填写的。", 1, "");
            AnyError = 1;
         }
         if ( ! ( (DateTime.MinValue==A105BR_Lab_SpecimenDate) || ( A105BR_Lab_SpecimenDate >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("域������������超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
         if ( (DateTime.MinValue==A105BR_Lab_SpecimenDate) )
         {
            GX_msglist.addItem("采样时间是必须填写的。", 1, "");
            AnyError = 1;
         }
         if ( ! ( (DateTime.MinValue==A264BR_Lab_ReceivingTime) || ( A264BR_Lab_ReceivingTime >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("域������������超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
         if ( ! ( (DateTime.MinValue==A265BR_Lab_ReportTime) || ( A265BR_Lab_ReportTime >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("域������������超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
      }

      protected void CloseExtendedTableCursors0G17( )
      {
         pr_default.close(2);
         pr_default.close(3);
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0G17( )
      {
         /* Using cursor BC000G7 */
         pr_default.execute(5, new Object[] {A101BR_LabID});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound17 = 1;
         }
         else
         {
            RcdFound17 = 0;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC000G3 */
         pr_default.execute(1, new Object[] {A101BR_LabID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0G17( 17) ;
            RcdFound17 = 1;
            A101BR_LabID = BC000G3_A101BR_LabID[0];
            A474BR_Lab_SpecimenSource_Code = BC000G3_A474BR_Lab_SpecimenSource_Code[0];
            n474BR_Lab_SpecimenSource_Code = BC000G3_n474BR_Lab_SpecimenSource_Code[0];
            A475BR_Lab_ResultQual_Code = BC000G3_A475BR_Lab_ResultQual_Code[0];
            n475BR_Lab_ResultQual_Code = BC000G3_n475BR_Lab_ResultQual_Code[0];
            A476BR_Lab_AbnInd_Code = BC000G3_A476BR_Lab_AbnInd_Code[0];
            n476BR_Lab_AbnInd_Code = BC000G3_n476BR_Lab_AbnInd_Code[0];
            A224BR_Lab_SampleID = BC000G3_A224BR_Lab_SampleID[0];
            n224BR_Lab_SampleID = BC000G3_n224BR_Lab_SampleID[0];
            A102BR_Lab_TestID = BC000G3_A102BR_Lab_TestID[0];
            n102BR_Lab_TestID = BC000G3_n102BR_Lab_TestID[0];
            A103BR_Lab_TestCode = BC000G3_A103BR_Lab_TestCode[0];
            n103BR_Lab_TestCode = BC000G3_n103BR_Lab_TestCode[0];
            A104BR_Lab_TestName = BC000G3_A104BR_Lab_TestName[0];
            n104BR_Lab_TestName = BC000G3_n104BR_Lab_TestName[0];
            A261BR_Lab_TestEngName = BC000G3_A261BR_Lab_TestEngName[0];
            n261BR_Lab_TestEngName = BC000G3_n261BR_Lab_TestEngName[0];
            A262BR_Lab_Age = BC000G3_A262BR_Lab_Age[0];
            n262BR_Lab_Age = BC000G3_n262BR_Lab_Age[0];
            A263BR_Lab_Diag = BC000G3_A263BR_Lab_Diag[0];
            n263BR_Lab_Diag = BC000G3_n263BR_Lab_Diag[0];
            A105BR_Lab_SpecimenDate = BC000G3_A105BR_Lab_SpecimenDate[0];
            n105BR_Lab_SpecimenDate = BC000G3_n105BR_Lab_SpecimenDate[0];
            A264BR_Lab_ReceivingTime = BC000G3_A264BR_Lab_ReceivingTime[0];
            n264BR_Lab_ReceivingTime = BC000G3_n264BR_Lab_ReceivingTime[0];
            A265BR_Lab_ReportTime = BC000G3_A265BR_Lab_ReportTime[0];
            n265BR_Lab_ReportTime = BC000G3_n265BR_Lab_ReportTime[0];
            A106BR_Lab_SpecimenSource = BC000G3_A106BR_Lab_SpecimenSource[0];
            n106BR_Lab_SpecimenSource = BC000G3_n106BR_Lab_SpecimenSource[0];
            A109BR_Lab_ResultQual = BC000G3_A109BR_Lab_ResultQual[0];
            n109BR_Lab_ResultQual = BC000G3_n109BR_Lab_ResultQual[0];
            A110BR_Lab_ResultNum = BC000G3_A110BR_Lab_ResultNum[0];
            n110BR_Lab_ResultNum = BC000G3_n110BR_Lab_ResultNum[0];
            A111BR_Lab_ResultUnit = BC000G3_A111BR_Lab_ResultUnit[0];
            n111BR_Lab_ResultUnit = BC000G3_n111BR_Lab_ResultUnit[0];
            A112BR_Lab_AbnInd = BC000G3_A112BR_Lab_AbnInd[0];
            n112BR_Lab_AbnInd = BC000G3_n112BR_Lab_AbnInd[0];
            A113BR_Lab_NormRangeLow = BC000G3_A113BR_Lab_NormRangeLow[0];
            n113BR_Lab_NormRangeLow = BC000G3_n113BR_Lab_NormRangeLow[0];
            A114BR_Lab_NormRangeHigh = BC000G3_A114BR_Lab_NormRangeHigh[0];
            n114BR_Lab_NormRangeHigh = BC000G3_n114BR_Lab_NormRangeHigh[0];
            A115BR_Lab_TestMethod = BC000G3_A115BR_Lab_TestMethod[0];
            n115BR_Lab_TestMethod = BC000G3_n115BR_Lab_TestMethod[0];
            A117BR_Lab_InstrumentName = BC000G3_A117BR_Lab_InstrumentName[0];
            n117BR_Lab_InstrumentName = BC000G3_n117BR_Lab_InstrumentName[0];
            A118BR_Lab_InstrumentCode = BC000G3_A118BR_Lab_InstrumentCode[0];
            n118BR_Lab_InstrumentCode = BC000G3_n118BR_Lab_InstrumentCode[0];
            A430BR_SampleId = BC000G3_A430BR_SampleId[0];
            n430BR_SampleId = BC000G3_n430BR_SampleId[0];
            A19BR_EncounterID = BC000G3_A19BR_EncounterID[0];
            Z101BR_LabID = A101BR_LabID;
            sMode17 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load0G17( ) ;
            if ( AnyError == 1 )
            {
               RcdFound17 = 0;
               InitializeNonKey0G17( ) ;
            }
            Gx_mode = sMode17;
         }
         else
         {
            RcdFound17 = 0;
            InitializeNonKey0G17( ) ;
            sMode17 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode17;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0G17( ) ;
         if ( RcdFound17 == 0 )
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
         CONFIRM_0G0( ) ;
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

      protected void CheckOptimisticConcurrency0G17( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC000G2 */
            pr_default.execute(0, new Object[] {A101BR_LabID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Lab"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z474BR_Lab_SpecimenSource_Code, BC000G2_A474BR_Lab_SpecimenSource_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z475BR_Lab_ResultQual_Code, BC000G2_A475BR_Lab_ResultQual_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z476BR_Lab_AbnInd_Code, BC000G2_A476BR_Lab_AbnInd_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z224BR_Lab_SampleID, BC000G2_A224BR_Lab_SampleID[0]) != 0 ) || ( Z102BR_Lab_TestID != BC000G2_A102BR_Lab_TestID[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z103BR_Lab_TestCode, BC000G2_A103BR_Lab_TestCode[0]) != 0 ) || ( StringUtil.StrCmp(Z104BR_Lab_TestName, BC000G2_A104BR_Lab_TestName[0]) != 0 ) || ( StringUtil.StrCmp(Z261BR_Lab_TestEngName, BC000G2_A261BR_Lab_TestEngName[0]) != 0 ) || ( Z262BR_Lab_Age != BC000G2_A262BR_Lab_Age[0] ) || ( StringUtil.StrCmp(Z263BR_Lab_Diag, BC000G2_A263BR_Lab_Diag[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z105BR_Lab_SpecimenDate != BC000G2_A105BR_Lab_SpecimenDate[0] ) || ( Z264BR_Lab_ReceivingTime != BC000G2_A264BR_Lab_ReceivingTime[0] ) || ( Z265BR_Lab_ReportTime != BC000G2_A265BR_Lab_ReportTime[0] ) || ( StringUtil.StrCmp(Z106BR_Lab_SpecimenSource, BC000G2_A106BR_Lab_SpecimenSource[0]) != 0 ) || ( StringUtil.StrCmp(Z109BR_Lab_ResultQual, BC000G2_A109BR_Lab_ResultQual[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z110BR_Lab_ResultNum, BC000G2_A110BR_Lab_ResultNum[0]) != 0 ) || ( StringUtil.StrCmp(Z111BR_Lab_ResultUnit, BC000G2_A111BR_Lab_ResultUnit[0]) != 0 ) || ( StringUtil.StrCmp(Z112BR_Lab_AbnInd, BC000G2_A112BR_Lab_AbnInd[0]) != 0 ) || ( StringUtil.StrCmp(Z113BR_Lab_NormRangeLow, BC000G2_A113BR_Lab_NormRangeLow[0]) != 0 ) || ( StringUtil.StrCmp(Z114BR_Lab_NormRangeHigh, BC000G2_A114BR_Lab_NormRangeHigh[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z115BR_Lab_TestMethod, BC000G2_A115BR_Lab_TestMethod[0]) != 0 ) || ( StringUtil.StrCmp(Z117BR_Lab_InstrumentName, BC000G2_A117BR_Lab_InstrumentName[0]) != 0 ) || ( StringUtil.StrCmp(Z118BR_Lab_InstrumentCode, BC000G2_A118BR_Lab_InstrumentCode[0]) != 0 ) || ( Z430BR_SampleId != BC000G2_A430BR_SampleId[0] ) || ( Z19BR_EncounterID != BC000G2_A19BR_EncounterID[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"BR_Lab"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0G17( )
      {
         BeforeValidate0G17( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0G17( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0G17( 0) ;
            CheckOptimisticConcurrency0G17( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0G17( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0G17( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000G8 */
                     pr_default.execute(6, new Object[] {n474BR_Lab_SpecimenSource_Code, A474BR_Lab_SpecimenSource_Code, n475BR_Lab_ResultQual_Code, A475BR_Lab_ResultQual_Code, n476BR_Lab_AbnInd_Code, A476BR_Lab_AbnInd_Code, n224BR_Lab_SampleID, A224BR_Lab_SampleID, n102BR_Lab_TestID, A102BR_Lab_TestID, n103BR_Lab_TestCode, A103BR_Lab_TestCode, n104BR_Lab_TestName, A104BR_Lab_TestName, n261BR_Lab_TestEngName, A261BR_Lab_TestEngName, n262BR_Lab_Age, A262BR_Lab_Age, n263BR_Lab_Diag, A263BR_Lab_Diag, n105BR_Lab_SpecimenDate, A105BR_Lab_SpecimenDate, n264BR_Lab_ReceivingTime, A264BR_Lab_ReceivingTime, n265BR_Lab_ReportTime, A265BR_Lab_ReportTime, n106BR_Lab_SpecimenSource, A106BR_Lab_SpecimenSource, n109BR_Lab_ResultQual, A109BR_Lab_ResultQual, n110BR_Lab_ResultNum, A110BR_Lab_ResultNum, n111BR_Lab_ResultUnit, A111BR_Lab_ResultUnit, n112BR_Lab_AbnInd, A112BR_Lab_AbnInd, n113BR_Lab_NormRangeLow, A113BR_Lab_NormRangeLow, n114BR_Lab_NormRangeHigh, A114BR_Lab_NormRangeHigh, n115BR_Lab_TestMethod, A115BR_Lab_TestMethod, n117BR_Lab_InstrumentName, A117BR_Lab_InstrumentName, n118BR_Lab_InstrumentCode, A118BR_Lab_InstrumentCode, n430BR_SampleId, A430BR_SampleId, A19BR_EncounterID});
                     A101BR_LabID = BC000G8_A101BR_LabID[0];
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Lab") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(A101BR_LabID), 18, 0)),  "实验室检查",  "Create",  1) ;
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
               Load0G17( ) ;
            }
            EndLevel0G17( ) ;
         }
         CloseExtendedTableCursors0G17( ) ;
      }

      protected void Update0G17( )
      {
         BeforeValidate0G17( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0G17( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0G17( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0G17( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0G17( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000G9 */
                     pr_default.execute(7, new Object[] {n474BR_Lab_SpecimenSource_Code, A474BR_Lab_SpecimenSource_Code, n475BR_Lab_ResultQual_Code, A475BR_Lab_ResultQual_Code, n476BR_Lab_AbnInd_Code, A476BR_Lab_AbnInd_Code, n224BR_Lab_SampleID, A224BR_Lab_SampleID, n102BR_Lab_TestID, A102BR_Lab_TestID, n103BR_Lab_TestCode, A103BR_Lab_TestCode, n104BR_Lab_TestName, A104BR_Lab_TestName, n261BR_Lab_TestEngName, A261BR_Lab_TestEngName, n262BR_Lab_Age, A262BR_Lab_Age, n263BR_Lab_Diag, A263BR_Lab_Diag, n105BR_Lab_SpecimenDate, A105BR_Lab_SpecimenDate, n264BR_Lab_ReceivingTime, A264BR_Lab_ReceivingTime, n265BR_Lab_ReportTime, A265BR_Lab_ReportTime, n106BR_Lab_SpecimenSource, A106BR_Lab_SpecimenSource, n109BR_Lab_ResultQual, A109BR_Lab_ResultQual, n110BR_Lab_ResultNum, A110BR_Lab_ResultNum, n111BR_Lab_ResultUnit, A111BR_Lab_ResultUnit, n112BR_Lab_AbnInd, A112BR_Lab_AbnInd, n113BR_Lab_NormRangeLow, A113BR_Lab_NormRangeLow, n114BR_Lab_NormRangeHigh, A114BR_Lab_NormRangeHigh, n115BR_Lab_TestMethod, A115BR_Lab_TestMethod, n117BR_Lab_InstrumentName, A117BR_Lab_InstrumentName, n118BR_Lab_InstrumentCode, A118BR_Lab_InstrumentCode, n430BR_SampleId, A430BR_SampleId, A19BR_EncounterID, A101BR_LabID});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Lab") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Lab"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0G17( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(A101BR_LabID), 18, 0)),  "实验室检查",  "Update",  1) ;
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
            EndLevel0G17( ) ;
         }
         CloseExtendedTableCursors0G17( ) ;
      }

      protected void DeferredUpdate0G17( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate0G17( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0G17( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0G17( ) ;
            AfterConfirm0G17( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0G17( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC000G10 */
                  pr_default.execute(8, new Object[] {A101BR_LabID});
                  pr_default.close(8);
                  dsDefault.SmartCacheProvider.SetUpdated("BR_Lab") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(A101BR_LabID), 18, 0)),  "实验室检查",  "Delete",  1) ;
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
         sMode17 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel0G17( ) ;
         Gx_mode = sMode17;
      }

      protected void OnDeleteControls0G17( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV17Pgmname = "BR_Lab_BC";
            /* Using cursor BC000G11 */
            pr_default.execute(9, new Object[] {A19BR_EncounterID});
            A85BR_Information_ID = BC000G11_A85BR_Information_ID[0];
            n85BR_Information_ID = BC000G11_n85BR_Information_ID[0];
            pr_default.close(9);
            /* Using cursor BC000G12 */
            pr_default.execute(10, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
            A36BR_Information_PatientNo = BC000G12_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = BC000G12_n36BR_Information_PatientNo[0];
            pr_default.close(10);
         }
      }

      protected void EndLevel0G17( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0G17( ) ;
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

      public void ScanKeyStart0G17( )
      {
         /* Scan By routine */
         /* Using cursor BC000G13 */
         pr_default.execute(11, new Object[] {A101BR_LabID});
         RcdFound17 = 0;
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound17 = 1;
            A85BR_Information_ID = BC000G13_A85BR_Information_ID[0];
            n85BR_Information_ID = BC000G13_n85BR_Information_ID[0];
            A101BR_LabID = BC000G13_A101BR_LabID[0];
            A474BR_Lab_SpecimenSource_Code = BC000G13_A474BR_Lab_SpecimenSource_Code[0];
            n474BR_Lab_SpecimenSource_Code = BC000G13_n474BR_Lab_SpecimenSource_Code[0];
            A475BR_Lab_ResultQual_Code = BC000G13_A475BR_Lab_ResultQual_Code[0];
            n475BR_Lab_ResultQual_Code = BC000G13_n475BR_Lab_ResultQual_Code[0];
            A476BR_Lab_AbnInd_Code = BC000G13_A476BR_Lab_AbnInd_Code[0];
            n476BR_Lab_AbnInd_Code = BC000G13_n476BR_Lab_AbnInd_Code[0];
            A36BR_Information_PatientNo = BC000G13_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = BC000G13_n36BR_Information_PatientNo[0];
            A224BR_Lab_SampleID = BC000G13_A224BR_Lab_SampleID[0];
            n224BR_Lab_SampleID = BC000G13_n224BR_Lab_SampleID[0];
            A102BR_Lab_TestID = BC000G13_A102BR_Lab_TestID[0];
            n102BR_Lab_TestID = BC000G13_n102BR_Lab_TestID[0];
            A103BR_Lab_TestCode = BC000G13_A103BR_Lab_TestCode[0];
            n103BR_Lab_TestCode = BC000G13_n103BR_Lab_TestCode[0];
            A104BR_Lab_TestName = BC000G13_A104BR_Lab_TestName[0];
            n104BR_Lab_TestName = BC000G13_n104BR_Lab_TestName[0];
            A261BR_Lab_TestEngName = BC000G13_A261BR_Lab_TestEngName[0];
            n261BR_Lab_TestEngName = BC000G13_n261BR_Lab_TestEngName[0];
            A262BR_Lab_Age = BC000G13_A262BR_Lab_Age[0];
            n262BR_Lab_Age = BC000G13_n262BR_Lab_Age[0];
            A263BR_Lab_Diag = BC000G13_A263BR_Lab_Diag[0];
            n263BR_Lab_Diag = BC000G13_n263BR_Lab_Diag[0];
            A105BR_Lab_SpecimenDate = BC000G13_A105BR_Lab_SpecimenDate[0];
            n105BR_Lab_SpecimenDate = BC000G13_n105BR_Lab_SpecimenDate[0];
            A264BR_Lab_ReceivingTime = BC000G13_A264BR_Lab_ReceivingTime[0];
            n264BR_Lab_ReceivingTime = BC000G13_n264BR_Lab_ReceivingTime[0];
            A265BR_Lab_ReportTime = BC000G13_A265BR_Lab_ReportTime[0];
            n265BR_Lab_ReportTime = BC000G13_n265BR_Lab_ReportTime[0];
            A106BR_Lab_SpecimenSource = BC000G13_A106BR_Lab_SpecimenSource[0];
            n106BR_Lab_SpecimenSource = BC000G13_n106BR_Lab_SpecimenSource[0];
            A109BR_Lab_ResultQual = BC000G13_A109BR_Lab_ResultQual[0];
            n109BR_Lab_ResultQual = BC000G13_n109BR_Lab_ResultQual[0];
            A110BR_Lab_ResultNum = BC000G13_A110BR_Lab_ResultNum[0];
            n110BR_Lab_ResultNum = BC000G13_n110BR_Lab_ResultNum[0];
            A111BR_Lab_ResultUnit = BC000G13_A111BR_Lab_ResultUnit[0];
            n111BR_Lab_ResultUnit = BC000G13_n111BR_Lab_ResultUnit[0];
            A112BR_Lab_AbnInd = BC000G13_A112BR_Lab_AbnInd[0];
            n112BR_Lab_AbnInd = BC000G13_n112BR_Lab_AbnInd[0];
            A113BR_Lab_NormRangeLow = BC000G13_A113BR_Lab_NormRangeLow[0];
            n113BR_Lab_NormRangeLow = BC000G13_n113BR_Lab_NormRangeLow[0];
            A114BR_Lab_NormRangeHigh = BC000G13_A114BR_Lab_NormRangeHigh[0];
            n114BR_Lab_NormRangeHigh = BC000G13_n114BR_Lab_NormRangeHigh[0];
            A115BR_Lab_TestMethod = BC000G13_A115BR_Lab_TestMethod[0];
            n115BR_Lab_TestMethod = BC000G13_n115BR_Lab_TestMethod[0];
            A117BR_Lab_InstrumentName = BC000G13_A117BR_Lab_InstrumentName[0];
            n117BR_Lab_InstrumentName = BC000G13_n117BR_Lab_InstrumentName[0];
            A118BR_Lab_InstrumentCode = BC000G13_A118BR_Lab_InstrumentCode[0];
            n118BR_Lab_InstrumentCode = BC000G13_n118BR_Lab_InstrumentCode[0];
            A430BR_SampleId = BC000G13_A430BR_SampleId[0];
            n430BR_SampleId = BC000G13_n430BR_SampleId[0];
            A19BR_EncounterID = BC000G13_A19BR_EncounterID[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext0G17( )
      {
         /* Scan next routine */
         pr_default.readNext(11);
         RcdFound17 = 0;
         ScanKeyLoad0G17( ) ;
      }

      protected void ScanKeyLoad0G17( )
      {
         sMode17 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound17 = 1;
            A85BR_Information_ID = BC000G13_A85BR_Information_ID[0];
            n85BR_Information_ID = BC000G13_n85BR_Information_ID[0];
            A101BR_LabID = BC000G13_A101BR_LabID[0];
            A474BR_Lab_SpecimenSource_Code = BC000G13_A474BR_Lab_SpecimenSource_Code[0];
            n474BR_Lab_SpecimenSource_Code = BC000G13_n474BR_Lab_SpecimenSource_Code[0];
            A475BR_Lab_ResultQual_Code = BC000G13_A475BR_Lab_ResultQual_Code[0];
            n475BR_Lab_ResultQual_Code = BC000G13_n475BR_Lab_ResultQual_Code[0];
            A476BR_Lab_AbnInd_Code = BC000G13_A476BR_Lab_AbnInd_Code[0];
            n476BR_Lab_AbnInd_Code = BC000G13_n476BR_Lab_AbnInd_Code[0];
            A36BR_Information_PatientNo = BC000G13_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = BC000G13_n36BR_Information_PatientNo[0];
            A224BR_Lab_SampleID = BC000G13_A224BR_Lab_SampleID[0];
            n224BR_Lab_SampleID = BC000G13_n224BR_Lab_SampleID[0];
            A102BR_Lab_TestID = BC000G13_A102BR_Lab_TestID[0];
            n102BR_Lab_TestID = BC000G13_n102BR_Lab_TestID[0];
            A103BR_Lab_TestCode = BC000G13_A103BR_Lab_TestCode[0];
            n103BR_Lab_TestCode = BC000G13_n103BR_Lab_TestCode[0];
            A104BR_Lab_TestName = BC000G13_A104BR_Lab_TestName[0];
            n104BR_Lab_TestName = BC000G13_n104BR_Lab_TestName[0];
            A261BR_Lab_TestEngName = BC000G13_A261BR_Lab_TestEngName[0];
            n261BR_Lab_TestEngName = BC000G13_n261BR_Lab_TestEngName[0];
            A262BR_Lab_Age = BC000G13_A262BR_Lab_Age[0];
            n262BR_Lab_Age = BC000G13_n262BR_Lab_Age[0];
            A263BR_Lab_Diag = BC000G13_A263BR_Lab_Diag[0];
            n263BR_Lab_Diag = BC000G13_n263BR_Lab_Diag[0];
            A105BR_Lab_SpecimenDate = BC000G13_A105BR_Lab_SpecimenDate[0];
            n105BR_Lab_SpecimenDate = BC000G13_n105BR_Lab_SpecimenDate[0];
            A264BR_Lab_ReceivingTime = BC000G13_A264BR_Lab_ReceivingTime[0];
            n264BR_Lab_ReceivingTime = BC000G13_n264BR_Lab_ReceivingTime[0];
            A265BR_Lab_ReportTime = BC000G13_A265BR_Lab_ReportTime[0];
            n265BR_Lab_ReportTime = BC000G13_n265BR_Lab_ReportTime[0];
            A106BR_Lab_SpecimenSource = BC000G13_A106BR_Lab_SpecimenSource[0];
            n106BR_Lab_SpecimenSource = BC000G13_n106BR_Lab_SpecimenSource[0];
            A109BR_Lab_ResultQual = BC000G13_A109BR_Lab_ResultQual[0];
            n109BR_Lab_ResultQual = BC000G13_n109BR_Lab_ResultQual[0];
            A110BR_Lab_ResultNum = BC000G13_A110BR_Lab_ResultNum[0];
            n110BR_Lab_ResultNum = BC000G13_n110BR_Lab_ResultNum[0];
            A111BR_Lab_ResultUnit = BC000G13_A111BR_Lab_ResultUnit[0];
            n111BR_Lab_ResultUnit = BC000G13_n111BR_Lab_ResultUnit[0];
            A112BR_Lab_AbnInd = BC000G13_A112BR_Lab_AbnInd[0];
            n112BR_Lab_AbnInd = BC000G13_n112BR_Lab_AbnInd[0];
            A113BR_Lab_NormRangeLow = BC000G13_A113BR_Lab_NormRangeLow[0];
            n113BR_Lab_NormRangeLow = BC000G13_n113BR_Lab_NormRangeLow[0];
            A114BR_Lab_NormRangeHigh = BC000G13_A114BR_Lab_NormRangeHigh[0];
            n114BR_Lab_NormRangeHigh = BC000G13_n114BR_Lab_NormRangeHigh[0];
            A115BR_Lab_TestMethod = BC000G13_A115BR_Lab_TestMethod[0];
            n115BR_Lab_TestMethod = BC000G13_n115BR_Lab_TestMethod[0];
            A117BR_Lab_InstrumentName = BC000G13_A117BR_Lab_InstrumentName[0];
            n117BR_Lab_InstrumentName = BC000G13_n117BR_Lab_InstrumentName[0];
            A118BR_Lab_InstrumentCode = BC000G13_A118BR_Lab_InstrumentCode[0];
            n118BR_Lab_InstrumentCode = BC000G13_n118BR_Lab_InstrumentCode[0];
            A430BR_SampleId = BC000G13_A430BR_SampleId[0];
            n430BR_SampleId = BC000G13_n430BR_SampleId[0];
            A19BR_EncounterID = BC000G13_A19BR_EncounterID[0];
         }
         Gx_mode = sMode17;
      }

      protected void ScanKeyEnd0G17( )
      {
         pr_default.close(11);
      }

      protected void AfterConfirm0G17( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0G17( )
      {
         /* Before Insert Rules */
         GXt_char2 = A474BR_Lab_SpecimenSource_Code;
         new zutil_findtargetcode(context ).execute(  22,  A106BR_Lab_SpecimenSource, out  GXt_char2) ;
         A474BR_Lab_SpecimenSource_Code = GXt_char2;
         n474BR_Lab_SpecimenSource_Code = false;
         GXt_char2 = A475BR_Lab_ResultQual_Code;
         new zutil_findtargetcode(context ).execute(  23,  A109BR_Lab_ResultQual, out  GXt_char2) ;
         A475BR_Lab_ResultQual_Code = GXt_char2;
         n475BR_Lab_ResultQual_Code = false;
         GXt_char2 = A476BR_Lab_AbnInd_Code;
         new zutil_findtargetcode(context ).execute(  24,  A112BR_Lab_AbnInd, out  GXt_char2) ;
         A476BR_Lab_AbnInd_Code = GXt_char2;
         n476BR_Lab_AbnInd_Code = false;
      }

      protected void BeforeUpdate0G17( )
      {
         /* Before Update Rules */
         GXt_char2 = A474BR_Lab_SpecimenSource_Code;
         new zutil_findtargetcode(context ).execute(  22,  A106BR_Lab_SpecimenSource, out  GXt_char2) ;
         A474BR_Lab_SpecimenSource_Code = GXt_char2;
         n474BR_Lab_SpecimenSource_Code = false;
         GXt_char2 = A475BR_Lab_ResultQual_Code;
         new zutil_findtargetcode(context ).execute(  23,  A109BR_Lab_ResultQual, out  GXt_char2) ;
         A475BR_Lab_ResultQual_Code = GXt_char2;
         n475BR_Lab_ResultQual_Code = false;
         GXt_char2 = A476BR_Lab_AbnInd_Code;
         new zutil_findtargetcode(context ).execute(  24,  A112BR_Lab_AbnInd, out  GXt_char2) ;
         A476BR_Lab_AbnInd_Code = GXt_char2;
         n476BR_Lab_AbnInd_Code = false;
      }

      protected void BeforeDelete0G17( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0G17( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0G17( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0G17( )
      {
      }

      protected void send_integrity_lvl_hashes0G17( )
      {
      }

      protected void AddRow0G17( )
      {
         VarsToRow17( bcBR_Lab) ;
      }

      protected void ReadRow0G17( )
      {
         RowToVars17( bcBR_Lab, 1) ;
      }

      protected void InitializeNonKey0G17( )
      {
         A85BR_Information_ID = 0;
         n85BR_Information_ID = false;
         A474BR_Lab_SpecimenSource_Code = "";
         n474BR_Lab_SpecimenSource_Code = false;
         A475BR_Lab_ResultQual_Code = "";
         n475BR_Lab_ResultQual_Code = false;
         A476BR_Lab_AbnInd_Code = "";
         n476BR_Lab_AbnInd_Code = false;
         A19BR_EncounterID = 0;
         A36BR_Information_PatientNo = "";
         n36BR_Information_PatientNo = false;
         A224BR_Lab_SampleID = "";
         n224BR_Lab_SampleID = false;
         A102BR_Lab_TestID = 0;
         n102BR_Lab_TestID = false;
         A103BR_Lab_TestCode = "";
         n103BR_Lab_TestCode = false;
         A104BR_Lab_TestName = "";
         n104BR_Lab_TestName = false;
         A261BR_Lab_TestEngName = "";
         n261BR_Lab_TestEngName = false;
         A262BR_Lab_Age = 0;
         n262BR_Lab_Age = false;
         A263BR_Lab_Diag = "";
         n263BR_Lab_Diag = false;
         A105BR_Lab_SpecimenDate = (DateTime)(DateTime.MinValue);
         n105BR_Lab_SpecimenDate = false;
         A264BR_Lab_ReceivingTime = (DateTime)(DateTime.MinValue);
         n264BR_Lab_ReceivingTime = false;
         A265BR_Lab_ReportTime = (DateTime)(DateTime.MinValue);
         n265BR_Lab_ReportTime = false;
         A106BR_Lab_SpecimenSource = "";
         n106BR_Lab_SpecimenSource = false;
         A109BR_Lab_ResultQual = "";
         n109BR_Lab_ResultQual = false;
         A110BR_Lab_ResultNum = "";
         n110BR_Lab_ResultNum = false;
         A111BR_Lab_ResultUnit = "";
         n111BR_Lab_ResultUnit = false;
         A112BR_Lab_AbnInd = "";
         n112BR_Lab_AbnInd = false;
         A113BR_Lab_NormRangeLow = "";
         n113BR_Lab_NormRangeLow = false;
         A114BR_Lab_NormRangeHigh = "";
         n114BR_Lab_NormRangeHigh = false;
         A115BR_Lab_TestMethod = "";
         n115BR_Lab_TestMethod = false;
         A117BR_Lab_InstrumentName = "";
         n117BR_Lab_InstrumentName = false;
         A118BR_Lab_InstrumentCode = "";
         n118BR_Lab_InstrumentCode = false;
         A430BR_SampleId = 0;
         n430BR_SampleId = false;
         Z474BR_Lab_SpecimenSource_Code = "";
         Z475BR_Lab_ResultQual_Code = "";
         Z476BR_Lab_AbnInd_Code = "";
         Z224BR_Lab_SampleID = "";
         Z102BR_Lab_TestID = 0;
         Z103BR_Lab_TestCode = "";
         Z104BR_Lab_TestName = "";
         Z261BR_Lab_TestEngName = "";
         Z262BR_Lab_Age = 0;
         Z263BR_Lab_Diag = "";
         Z105BR_Lab_SpecimenDate = (DateTime)(DateTime.MinValue);
         Z264BR_Lab_ReceivingTime = (DateTime)(DateTime.MinValue);
         Z265BR_Lab_ReportTime = (DateTime)(DateTime.MinValue);
         Z106BR_Lab_SpecimenSource = "";
         Z109BR_Lab_ResultQual = "";
         Z110BR_Lab_ResultNum = "";
         Z111BR_Lab_ResultUnit = "";
         Z112BR_Lab_AbnInd = "";
         Z113BR_Lab_NormRangeLow = "";
         Z114BR_Lab_NormRangeHigh = "";
         Z115BR_Lab_TestMethod = "";
         Z117BR_Lab_InstrumentName = "";
         Z118BR_Lab_InstrumentCode = "";
         Z430BR_SampleId = 0;
         Z19BR_EncounterID = 0;
      }

      protected void InitAll0G17( )
      {
         A101BR_LabID = 0;
         InitializeNonKey0G17( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow17( SdtBR_Lab obj17 )
      {
         obj17.gxTpr_Mode = Gx_mode;
         obj17.gxTpr_Br_lab_specimensource_code = A474BR_Lab_SpecimenSource_Code;
         obj17.gxTpr_Br_lab_resultqual_code = A475BR_Lab_ResultQual_Code;
         obj17.gxTpr_Br_lab_abnind_code = A476BR_Lab_AbnInd_Code;
         obj17.gxTpr_Br_encounterid = A19BR_EncounterID;
         obj17.gxTpr_Br_information_patientno = A36BR_Information_PatientNo;
         obj17.gxTpr_Br_lab_sampleid = A224BR_Lab_SampleID;
         obj17.gxTpr_Br_lab_testid = A102BR_Lab_TestID;
         obj17.gxTpr_Br_lab_testcode = A103BR_Lab_TestCode;
         obj17.gxTpr_Br_lab_testname = A104BR_Lab_TestName;
         obj17.gxTpr_Br_lab_testengname = A261BR_Lab_TestEngName;
         obj17.gxTpr_Br_lab_age = A262BR_Lab_Age;
         obj17.gxTpr_Br_lab_diag = A263BR_Lab_Diag;
         obj17.gxTpr_Br_lab_specimendate = A105BR_Lab_SpecimenDate;
         obj17.gxTpr_Br_lab_receivingtime = A264BR_Lab_ReceivingTime;
         obj17.gxTpr_Br_lab_reporttime = A265BR_Lab_ReportTime;
         obj17.gxTpr_Br_lab_specimensource = A106BR_Lab_SpecimenSource;
         obj17.gxTpr_Br_lab_resultqual = A109BR_Lab_ResultQual;
         obj17.gxTpr_Br_lab_resultnum = A110BR_Lab_ResultNum;
         obj17.gxTpr_Br_lab_resultunit = A111BR_Lab_ResultUnit;
         obj17.gxTpr_Br_lab_abnind = A112BR_Lab_AbnInd;
         obj17.gxTpr_Br_lab_normrangelow = A113BR_Lab_NormRangeLow;
         obj17.gxTpr_Br_lab_normrangehigh = A114BR_Lab_NormRangeHigh;
         obj17.gxTpr_Br_lab_testmethod = A115BR_Lab_TestMethod;
         obj17.gxTpr_Br_lab_instrumentname = A117BR_Lab_InstrumentName;
         obj17.gxTpr_Br_lab_instrumentcode = A118BR_Lab_InstrumentCode;
         obj17.gxTpr_Br_sampleid = A430BR_SampleId;
         obj17.gxTpr_Br_labid = A101BR_LabID;
         obj17.gxTpr_Br_labid_Z = Z101BR_LabID;
         obj17.gxTpr_Br_encounterid_Z = Z19BR_EncounterID;
         obj17.gxTpr_Br_information_patientno_Z = Z36BR_Information_PatientNo;
         obj17.gxTpr_Br_lab_sampleid_Z = Z224BR_Lab_SampleID;
         obj17.gxTpr_Br_lab_testid_Z = Z102BR_Lab_TestID;
         obj17.gxTpr_Br_lab_testcode_Z = Z103BR_Lab_TestCode;
         obj17.gxTpr_Br_lab_testname_Z = Z104BR_Lab_TestName;
         obj17.gxTpr_Br_lab_testengname_Z = Z261BR_Lab_TestEngName;
         obj17.gxTpr_Br_lab_age_Z = Z262BR_Lab_Age;
         obj17.gxTpr_Br_lab_diag_Z = Z263BR_Lab_Diag;
         obj17.gxTpr_Br_lab_specimendate_Z = Z105BR_Lab_SpecimenDate;
         obj17.gxTpr_Br_lab_receivingtime_Z = Z264BR_Lab_ReceivingTime;
         obj17.gxTpr_Br_lab_reporttime_Z = Z265BR_Lab_ReportTime;
         obj17.gxTpr_Br_lab_specimensource_Z = Z106BR_Lab_SpecimenSource;
         obj17.gxTpr_Br_lab_specimensource_code_Z = Z474BR_Lab_SpecimenSource_Code;
         obj17.gxTpr_Br_lab_resultqual_Z = Z109BR_Lab_ResultQual;
         obj17.gxTpr_Br_lab_resultqual_code_Z = Z475BR_Lab_ResultQual_Code;
         obj17.gxTpr_Br_lab_resultnum_Z = Z110BR_Lab_ResultNum;
         obj17.gxTpr_Br_lab_resultunit_Z = Z111BR_Lab_ResultUnit;
         obj17.gxTpr_Br_lab_abnind_Z = Z112BR_Lab_AbnInd;
         obj17.gxTpr_Br_lab_abnind_code_Z = Z476BR_Lab_AbnInd_Code;
         obj17.gxTpr_Br_lab_normrangelow_Z = Z113BR_Lab_NormRangeLow;
         obj17.gxTpr_Br_lab_normrangehigh_Z = Z114BR_Lab_NormRangeHigh;
         obj17.gxTpr_Br_lab_testmethod_Z = Z115BR_Lab_TestMethod;
         obj17.gxTpr_Br_lab_instrumentname_Z = Z117BR_Lab_InstrumentName;
         obj17.gxTpr_Br_lab_instrumentcode_Z = Z118BR_Lab_InstrumentCode;
         obj17.gxTpr_Br_sampleid_Z = Z430BR_SampleId;
         obj17.gxTpr_Br_information_patientno_N = (short)(Convert.ToInt16(n36BR_Information_PatientNo));
         obj17.gxTpr_Br_lab_sampleid_N = (short)(Convert.ToInt16(n224BR_Lab_SampleID));
         obj17.gxTpr_Br_lab_testid_N = (short)(Convert.ToInt16(n102BR_Lab_TestID));
         obj17.gxTpr_Br_lab_testcode_N = (short)(Convert.ToInt16(n103BR_Lab_TestCode));
         obj17.gxTpr_Br_lab_testname_N = (short)(Convert.ToInt16(n104BR_Lab_TestName));
         obj17.gxTpr_Br_lab_testengname_N = (short)(Convert.ToInt16(n261BR_Lab_TestEngName));
         obj17.gxTpr_Br_lab_age_N = (short)(Convert.ToInt16(n262BR_Lab_Age));
         obj17.gxTpr_Br_lab_diag_N = (short)(Convert.ToInt16(n263BR_Lab_Diag));
         obj17.gxTpr_Br_lab_specimendate_N = (short)(Convert.ToInt16(n105BR_Lab_SpecimenDate));
         obj17.gxTpr_Br_lab_receivingtime_N = (short)(Convert.ToInt16(n264BR_Lab_ReceivingTime));
         obj17.gxTpr_Br_lab_reporttime_N = (short)(Convert.ToInt16(n265BR_Lab_ReportTime));
         obj17.gxTpr_Br_lab_specimensource_N = (short)(Convert.ToInt16(n106BR_Lab_SpecimenSource));
         obj17.gxTpr_Br_lab_specimensource_code_N = (short)(Convert.ToInt16(n474BR_Lab_SpecimenSource_Code));
         obj17.gxTpr_Br_lab_resultqual_N = (short)(Convert.ToInt16(n109BR_Lab_ResultQual));
         obj17.gxTpr_Br_lab_resultqual_code_N = (short)(Convert.ToInt16(n475BR_Lab_ResultQual_Code));
         obj17.gxTpr_Br_lab_resultnum_N = (short)(Convert.ToInt16(n110BR_Lab_ResultNum));
         obj17.gxTpr_Br_lab_resultunit_N = (short)(Convert.ToInt16(n111BR_Lab_ResultUnit));
         obj17.gxTpr_Br_lab_abnind_N = (short)(Convert.ToInt16(n112BR_Lab_AbnInd));
         obj17.gxTpr_Br_lab_abnind_code_N = (short)(Convert.ToInt16(n476BR_Lab_AbnInd_Code));
         obj17.gxTpr_Br_lab_normrangelow_N = (short)(Convert.ToInt16(n113BR_Lab_NormRangeLow));
         obj17.gxTpr_Br_lab_normrangehigh_N = (short)(Convert.ToInt16(n114BR_Lab_NormRangeHigh));
         obj17.gxTpr_Br_lab_testmethod_N = (short)(Convert.ToInt16(n115BR_Lab_TestMethod));
         obj17.gxTpr_Br_lab_instrumentname_N = (short)(Convert.ToInt16(n117BR_Lab_InstrumentName));
         obj17.gxTpr_Br_lab_instrumentcode_N = (short)(Convert.ToInt16(n118BR_Lab_InstrumentCode));
         obj17.gxTpr_Br_sampleid_N = (short)(Convert.ToInt16(n430BR_SampleId));
         obj17.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow17( SdtBR_Lab obj17 )
      {
         obj17.gxTpr_Br_labid = A101BR_LabID;
         return  ;
      }

      public void RowToVars17( SdtBR_Lab obj17 ,
                               int forceLoad )
      {
         Gx_mode = obj17.gxTpr_Mode;
         A474BR_Lab_SpecimenSource_Code = obj17.gxTpr_Br_lab_specimensource_code;
         n474BR_Lab_SpecimenSource_Code = false;
         A475BR_Lab_ResultQual_Code = obj17.gxTpr_Br_lab_resultqual_code;
         n475BR_Lab_ResultQual_Code = false;
         A476BR_Lab_AbnInd_Code = obj17.gxTpr_Br_lab_abnind_code;
         n476BR_Lab_AbnInd_Code = false;
         A19BR_EncounterID = obj17.gxTpr_Br_encounterid;
         A36BR_Information_PatientNo = obj17.gxTpr_Br_information_patientno;
         n36BR_Information_PatientNo = false;
         A224BR_Lab_SampleID = obj17.gxTpr_Br_lab_sampleid;
         n224BR_Lab_SampleID = false;
         A102BR_Lab_TestID = obj17.gxTpr_Br_lab_testid;
         n102BR_Lab_TestID = false;
         A103BR_Lab_TestCode = obj17.gxTpr_Br_lab_testcode;
         n103BR_Lab_TestCode = false;
         A104BR_Lab_TestName = obj17.gxTpr_Br_lab_testname;
         n104BR_Lab_TestName = false;
         A261BR_Lab_TestEngName = obj17.gxTpr_Br_lab_testengname;
         n261BR_Lab_TestEngName = false;
         A262BR_Lab_Age = obj17.gxTpr_Br_lab_age;
         n262BR_Lab_Age = false;
         A263BR_Lab_Diag = obj17.gxTpr_Br_lab_diag;
         n263BR_Lab_Diag = false;
         A105BR_Lab_SpecimenDate = obj17.gxTpr_Br_lab_specimendate;
         n105BR_Lab_SpecimenDate = false;
         A264BR_Lab_ReceivingTime = obj17.gxTpr_Br_lab_receivingtime;
         n264BR_Lab_ReceivingTime = false;
         A265BR_Lab_ReportTime = obj17.gxTpr_Br_lab_reporttime;
         n265BR_Lab_ReportTime = false;
         A106BR_Lab_SpecimenSource = obj17.gxTpr_Br_lab_specimensource;
         n106BR_Lab_SpecimenSource = false;
         A109BR_Lab_ResultQual = obj17.gxTpr_Br_lab_resultqual;
         n109BR_Lab_ResultQual = false;
         A110BR_Lab_ResultNum = obj17.gxTpr_Br_lab_resultnum;
         n110BR_Lab_ResultNum = false;
         A111BR_Lab_ResultUnit = obj17.gxTpr_Br_lab_resultunit;
         n111BR_Lab_ResultUnit = false;
         A112BR_Lab_AbnInd = obj17.gxTpr_Br_lab_abnind;
         n112BR_Lab_AbnInd = false;
         A113BR_Lab_NormRangeLow = obj17.gxTpr_Br_lab_normrangelow;
         n113BR_Lab_NormRangeLow = false;
         A114BR_Lab_NormRangeHigh = obj17.gxTpr_Br_lab_normrangehigh;
         n114BR_Lab_NormRangeHigh = false;
         A115BR_Lab_TestMethod = obj17.gxTpr_Br_lab_testmethod;
         n115BR_Lab_TestMethod = false;
         A117BR_Lab_InstrumentName = obj17.gxTpr_Br_lab_instrumentname;
         n117BR_Lab_InstrumentName = false;
         A118BR_Lab_InstrumentCode = obj17.gxTpr_Br_lab_instrumentcode;
         n118BR_Lab_InstrumentCode = false;
         A430BR_SampleId = obj17.gxTpr_Br_sampleid;
         n430BR_SampleId = false;
         A101BR_LabID = obj17.gxTpr_Br_labid;
         Z101BR_LabID = obj17.gxTpr_Br_labid_Z;
         Z19BR_EncounterID = obj17.gxTpr_Br_encounterid_Z;
         Z36BR_Information_PatientNo = obj17.gxTpr_Br_information_patientno_Z;
         Z224BR_Lab_SampleID = obj17.gxTpr_Br_lab_sampleid_Z;
         Z102BR_Lab_TestID = obj17.gxTpr_Br_lab_testid_Z;
         Z103BR_Lab_TestCode = obj17.gxTpr_Br_lab_testcode_Z;
         Z104BR_Lab_TestName = obj17.gxTpr_Br_lab_testname_Z;
         Z261BR_Lab_TestEngName = obj17.gxTpr_Br_lab_testengname_Z;
         Z262BR_Lab_Age = obj17.gxTpr_Br_lab_age_Z;
         Z263BR_Lab_Diag = obj17.gxTpr_Br_lab_diag_Z;
         Z105BR_Lab_SpecimenDate = obj17.gxTpr_Br_lab_specimendate_Z;
         Z264BR_Lab_ReceivingTime = obj17.gxTpr_Br_lab_receivingtime_Z;
         Z265BR_Lab_ReportTime = obj17.gxTpr_Br_lab_reporttime_Z;
         Z106BR_Lab_SpecimenSource = obj17.gxTpr_Br_lab_specimensource_Z;
         Z474BR_Lab_SpecimenSource_Code = obj17.gxTpr_Br_lab_specimensource_code_Z;
         Z109BR_Lab_ResultQual = obj17.gxTpr_Br_lab_resultqual_Z;
         Z475BR_Lab_ResultQual_Code = obj17.gxTpr_Br_lab_resultqual_code_Z;
         Z110BR_Lab_ResultNum = obj17.gxTpr_Br_lab_resultnum_Z;
         Z111BR_Lab_ResultUnit = obj17.gxTpr_Br_lab_resultunit_Z;
         Z112BR_Lab_AbnInd = obj17.gxTpr_Br_lab_abnind_Z;
         Z476BR_Lab_AbnInd_Code = obj17.gxTpr_Br_lab_abnind_code_Z;
         Z113BR_Lab_NormRangeLow = obj17.gxTpr_Br_lab_normrangelow_Z;
         Z114BR_Lab_NormRangeHigh = obj17.gxTpr_Br_lab_normrangehigh_Z;
         Z115BR_Lab_TestMethod = obj17.gxTpr_Br_lab_testmethod_Z;
         Z117BR_Lab_InstrumentName = obj17.gxTpr_Br_lab_instrumentname_Z;
         Z118BR_Lab_InstrumentCode = obj17.gxTpr_Br_lab_instrumentcode_Z;
         Z430BR_SampleId = obj17.gxTpr_Br_sampleid_Z;
         n36BR_Information_PatientNo = (bool)(Convert.ToBoolean(obj17.gxTpr_Br_information_patientno_N));
         n224BR_Lab_SampleID = (bool)(Convert.ToBoolean(obj17.gxTpr_Br_lab_sampleid_N));
         n102BR_Lab_TestID = (bool)(Convert.ToBoolean(obj17.gxTpr_Br_lab_testid_N));
         n103BR_Lab_TestCode = (bool)(Convert.ToBoolean(obj17.gxTpr_Br_lab_testcode_N));
         n104BR_Lab_TestName = (bool)(Convert.ToBoolean(obj17.gxTpr_Br_lab_testname_N));
         n261BR_Lab_TestEngName = (bool)(Convert.ToBoolean(obj17.gxTpr_Br_lab_testengname_N));
         n262BR_Lab_Age = (bool)(Convert.ToBoolean(obj17.gxTpr_Br_lab_age_N));
         n263BR_Lab_Diag = (bool)(Convert.ToBoolean(obj17.gxTpr_Br_lab_diag_N));
         n105BR_Lab_SpecimenDate = (bool)(Convert.ToBoolean(obj17.gxTpr_Br_lab_specimendate_N));
         n264BR_Lab_ReceivingTime = (bool)(Convert.ToBoolean(obj17.gxTpr_Br_lab_receivingtime_N));
         n265BR_Lab_ReportTime = (bool)(Convert.ToBoolean(obj17.gxTpr_Br_lab_reporttime_N));
         n106BR_Lab_SpecimenSource = (bool)(Convert.ToBoolean(obj17.gxTpr_Br_lab_specimensource_N));
         n474BR_Lab_SpecimenSource_Code = (bool)(Convert.ToBoolean(obj17.gxTpr_Br_lab_specimensource_code_N));
         n109BR_Lab_ResultQual = (bool)(Convert.ToBoolean(obj17.gxTpr_Br_lab_resultqual_N));
         n475BR_Lab_ResultQual_Code = (bool)(Convert.ToBoolean(obj17.gxTpr_Br_lab_resultqual_code_N));
         n110BR_Lab_ResultNum = (bool)(Convert.ToBoolean(obj17.gxTpr_Br_lab_resultnum_N));
         n111BR_Lab_ResultUnit = (bool)(Convert.ToBoolean(obj17.gxTpr_Br_lab_resultunit_N));
         n112BR_Lab_AbnInd = (bool)(Convert.ToBoolean(obj17.gxTpr_Br_lab_abnind_N));
         n476BR_Lab_AbnInd_Code = (bool)(Convert.ToBoolean(obj17.gxTpr_Br_lab_abnind_code_N));
         n113BR_Lab_NormRangeLow = (bool)(Convert.ToBoolean(obj17.gxTpr_Br_lab_normrangelow_N));
         n114BR_Lab_NormRangeHigh = (bool)(Convert.ToBoolean(obj17.gxTpr_Br_lab_normrangehigh_N));
         n115BR_Lab_TestMethod = (bool)(Convert.ToBoolean(obj17.gxTpr_Br_lab_testmethod_N));
         n117BR_Lab_InstrumentName = (bool)(Convert.ToBoolean(obj17.gxTpr_Br_lab_instrumentname_N));
         n118BR_Lab_InstrumentCode = (bool)(Convert.ToBoolean(obj17.gxTpr_Br_lab_instrumentcode_N));
         n430BR_SampleId = (bool)(Convert.ToBoolean(obj17.gxTpr_Br_sampleid_N));
         Gx_mode = obj17.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A101BR_LabID = (long)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey0G17( ) ;
         ScanKeyStart0G17( ) ;
         if ( RcdFound17 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z101BR_LabID = A101BR_LabID;
         }
         ZM0G17( -17) ;
         OnLoadActions0G17( ) ;
         AddRow0G17( ) ;
         ScanKeyEnd0G17( ) ;
         if ( RcdFound17 == 0 )
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
         RowToVars17( bcBR_Lab, 0) ;
         ScanKeyStart0G17( ) ;
         if ( RcdFound17 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z101BR_LabID = A101BR_LabID;
         }
         ZM0G17( -17) ;
         OnLoadActions0G17( ) ;
         AddRow0G17( ) ;
         ScanKeyEnd0G17( ) ;
         if ( RcdFound17 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey0G17( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert0G17( ) ;
         }
         else
         {
            if ( RcdFound17 == 1 )
            {
               if ( A101BR_LabID != Z101BR_LabID )
               {
                  A101BR_LabID = Z101BR_LabID;
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
                  Update0G17( ) ;
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
                  if ( A101BR_LabID != Z101BR_LabID )
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
                        Insert0G17( ) ;
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
                        Insert0G17( ) ;
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
         RowToVars17( bcBR_Lab, 0) ;
         SaveImpl( ) ;
         VarsToRow17( bcBR_Lab) ;
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
         RowToVars17( bcBR_Lab, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert0G17( ) ;
         AfterTrn( ) ;
         VarsToRow17( bcBR_Lab) ;
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
            SdtBR_Lab auxBC = new SdtBR_Lab(context) ;
            auxBC.Load(A101BR_LabID);
            auxBC.UpdateDirties(bcBR_Lab);
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
         RowToVars17( bcBR_Lab, 0) ;
         UpdateImpl( ) ;
         VarsToRow17( bcBR_Lab) ;
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
         RowToVars17( bcBR_Lab, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert0G17( ) ;
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
         VarsToRow17( bcBR_Lab) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars17( bcBR_Lab, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey0G17( ) ;
         if ( RcdFound17 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A101BR_LabID != Z101BR_LabID )
            {
               A101BR_LabID = Z101BR_LabID;
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
            if ( A101BR_LabID != Z101BR_LabID )
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
         context.RollbackDataStores("br_lab_bc",pr_default);
         VarsToRow17( bcBR_Lab) ;
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
         Gx_mode = bcBR_Lab.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcBR_Lab.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcBR_Lab )
         {
            bcBR_Lab = (SdtBR_Lab)(sdt);
            if ( StringUtil.StrCmp(bcBR_Lab.gxTpr_Mode, "") == 0 )
            {
               bcBR_Lab.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow17( bcBR_Lab) ;
            }
            else
            {
               RowToVars17( bcBR_Lab, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcBR_Lab.gxTpr_Mode, "") == 0 )
            {
               bcBR_Lab.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars17( bcBR_Lab, 1) ;
         return  ;
      }

      public SdtBR_Lab BR_Lab_BC
      {
         get {
            return bcBR_Lab ;
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
         AV17Pgmname = "";
         AV8TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9WebSession = context.GetSession();
         AV11TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         Z474BR_Lab_SpecimenSource_Code = "";
         A474BR_Lab_SpecimenSource_Code = "";
         Z475BR_Lab_ResultQual_Code = "";
         A475BR_Lab_ResultQual_Code = "";
         Z476BR_Lab_AbnInd_Code = "";
         A476BR_Lab_AbnInd_Code = "";
         Z224BR_Lab_SampleID = "";
         A224BR_Lab_SampleID = "";
         Z103BR_Lab_TestCode = "";
         A103BR_Lab_TestCode = "";
         Z104BR_Lab_TestName = "";
         A104BR_Lab_TestName = "";
         Z261BR_Lab_TestEngName = "";
         A261BR_Lab_TestEngName = "";
         Z263BR_Lab_Diag = "";
         A263BR_Lab_Diag = "";
         Z105BR_Lab_SpecimenDate = (DateTime)(DateTime.MinValue);
         A105BR_Lab_SpecimenDate = (DateTime)(DateTime.MinValue);
         Z264BR_Lab_ReceivingTime = (DateTime)(DateTime.MinValue);
         A264BR_Lab_ReceivingTime = (DateTime)(DateTime.MinValue);
         Z265BR_Lab_ReportTime = (DateTime)(DateTime.MinValue);
         A265BR_Lab_ReportTime = (DateTime)(DateTime.MinValue);
         Z106BR_Lab_SpecimenSource = "";
         A106BR_Lab_SpecimenSource = "";
         Z109BR_Lab_ResultQual = "";
         A109BR_Lab_ResultQual = "";
         Z110BR_Lab_ResultNum = "";
         A110BR_Lab_ResultNum = "";
         Z111BR_Lab_ResultUnit = "";
         A111BR_Lab_ResultUnit = "";
         Z112BR_Lab_AbnInd = "";
         A112BR_Lab_AbnInd = "";
         Z113BR_Lab_NormRangeLow = "";
         A113BR_Lab_NormRangeLow = "";
         Z114BR_Lab_NormRangeHigh = "";
         A114BR_Lab_NormRangeHigh = "";
         Z115BR_Lab_TestMethod = "";
         A115BR_Lab_TestMethod = "";
         Z117BR_Lab_InstrumentName = "";
         A117BR_Lab_InstrumentName = "";
         Z118BR_Lab_InstrumentCode = "";
         A118BR_Lab_InstrumentCode = "";
         Z36BR_Information_PatientNo = "";
         A36BR_Information_PatientNo = "";
         BC000G6_A85BR_Information_ID = new long[1] ;
         BC000G6_n85BR_Information_ID = new bool[] {false} ;
         BC000G6_A101BR_LabID = new long[1] ;
         BC000G6_A474BR_Lab_SpecimenSource_Code = new String[] {""} ;
         BC000G6_n474BR_Lab_SpecimenSource_Code = new bool[] {false} ;
         BC000G6_A475BR_Lab_ResultQual_Code = new String[] {""} ;
         BC000G6_n475BR_Lab_ResultQual_Code = new bool[] {false} ;
         BC000G6_A476BR_Lab_AbnInd_Code = new String[] {""} ;
         BC000G6_n476BR_Lab_AbnInd_Code = new bool[] {false} ;
         BC000G6_A36BR_Information_PatientNo = new String[] {""} ;
         BC000G6_n36BR_Information_PatientNo = new bool[] {false} ;
         BC000G6_A224BR_Lab_SampleID = new String[] {""} ;
         BC000G6_n224BR_Lab_SampleID = new bool[] {false} ;
         BC000G6_A102BR_Lab_TestID = new long[1] ;
         BC000G6_n102BR_Lab_TestID = new bool[] {false} ;
         BC000G6_A103BR_Lab_TestCode = new String[] {""} ;
         BC000G6_n103BR_Lab_TestCode = new bool[] {false} ;
         BC000G6_A104BR_Lab_TestName = new String[] {""} ;
         BC000G6_n104BR_Lab_TestName = new bool[] {false} ;
         BC000G6_A261BR_Lab_TestEngName = new String[] {""} ;
         BC000G6_n261BR_Lab_TestEngName = new bool[] {false} ;
         BC000G6_A262BR_Lab_Age = new short[1] ;
         BC000G6_n262BR_Lab_Age = new bool[] {false} ;
         BC000G6_A263BR_Lab_Diag = new String[] {""} ;
         BC000G6_n263BR_Lab_Diag = new bool[] {false} ;
         BC000G6_A105BR_Lab_SpecimenDate = new DateTime[] {DateTime.MinValue} ;
         BC000G6_n105BR_Lab_SpecimenDate = new bool[] {false} ;
         BC000G6_A264BR_Lab_ReceivingTime = new DateTime[] {DateTime.MinValue} ;
         BC000G6_n264BR_Lab_ReceivingTime = new bool[] {false} ;
         BC000G6_A265BR_Lab_ReportTime = new DateTime[] {DateTime.MinValue} ;
         BC000G6_n265BR_Lab_ReportTime = new bool[] {false} ;
         BC000G6_A106BR_Lab_SpecimenSource = new String[] {""} ;
         BC000G6_n106BR_Lab_SpecimenSource = new bool[] {false} ;
         BC000G6_A109BR_Lab_ResultQual = new String[] {""} ;
         BC000G6_n109BR_Lab_ResultQual = new bool[] {false} ;
         BC000G6_A110BR_Lab_ResultNum = new String[] {""} ;
         BC000G6_n110BR_Lab_ResultNum = new bool[] {false} ;
         BC000G6_A111BR_Lab_ResultUnit = new String[] {""} ;
         BC000G6_n111BR_Lab_ResultUnit = new bool[] {false} ;
         BC000G6_A112BR_Lab_AbnInd = new String[] {""} ;
         BC000G6_n112BR_Lab_AbnInd = new bool[] {false} ;
         BC000G6_A113BR_Lab_NormRangeLow = new String[] {""} ;
         BC000G6_n113BR_Lab_NormRangeLow = new bool[] {false} ;
         BC000G6_A114BR_Lab_NormRangeHigh = new String[] {""} ;
         BC000G6_n114BR_Lab_NormRangeHigh = new bool[] {false} ;
         BC000G6_A115BR_Lab_TestMethod = new String[] {""} ;
         BC000G6_n115BR_Lab_TestMethod = new bool[] {false} ;
         BC000G6_A117BR_Lab_InstrumentName = new String[] {""} ;
         BC000G6_n117BR_Lab_InstrumentName = new bool[] {false} ;
         BC000G6_A118BR_Lab_InstrumentCode = new String[] {""} ;
         BC000G6_n118BR_Lab_InstrumentCode = new bool[] {false} ;
         BC000G6_A430BR_SampleId = new long[1] ;
         BC000G6_n430BR_SampleId = new bool[] {false} ;
         BC000G6_A19BR_EncounterID = new long[1] ;
         BC000G4_A85BR_Information_ID = new long[1] ;
         BC000G4_n85BR_Information_ID = new bool[] {false} ;
         BC000G5_A36BR_Information_PatientNo = new String[] {""} ;
         BC000G5_n36BR_Information_PatientNo = new bool[] {false} ;
         BC000G7_A101BR_LabID = new long[1] ;
         BC000G3_A101BR_LabID = new long[1] ;
         BC000G3_A474BR_Lab_SpecimenSource_Code = new String[] {""} ;
         BC000G3_n474BR_Lab_SpecimenSource_Code = new bool[] {false} ;
         BC000G3_A475BR_Lab_ResultQual_Code = new String[] {""} ;
         BC000G3_n475BR_Lab_ResultQual_Code = new bool[] {false} ;
         BC000G3_A476BR_Lab_AbnInd_Code = new String[] {""} ;
         BC000G3_n476BR_Lab_AbnInd_Code = new bool[] {false} ;
         BC000G3_A224BR_Lab_SampleID = new String[] {""} ;
         BC000G3_n224BR_Lab_SampleID = new bool[] {false} ;
         BC000G3_A102BR_Lab_TestID = new long[1] ;
         BC000G3_n102BR_Lab_TestID = new bool[] {false} ;
         BC000G3_A103BR_Lab_TestCode = new String[] {""} ;
         BC000G3_n103BR_Lab_TestCode = new bool[] {false} ;
         BC000G3_A104BR_Lab_TestName = new String[] {""} ;
         BC000G3_n104BR_Lab_TestName = new bool[] {false} ;
         BC000G3_A261BR_Lab_TestEngName = new String[] {""} ;
         BC000G3_n261BR_Lab_TestEngName = new bool[] {false} ;
         BC000G3_A262BR_Lab_Age = new short[1] ;
         BC000G3_n262BR_Lab_Age = new bool[] {false} ;
         BC000G3_A263BR_Lab_Diag = new String[] {""} ;
         BC000G3_n263BR_Lab_Diag = new bool[] {false} ;
         BC000G3_A105BR_Lab_SpecimenDate = new DateTime[] {DateTime.MinValue} ;
         BC000G3_n105BR_Lab_SpecimenDate = new bool[] {false} ;
         BC000G3_A264BR_Lab_ReceivingTime = new DateTime[] {DateTime.MinValue} ;
         BC000G3_n264BR_Lab_ReceivingTime = new bool[] {false} ;
         BC000G3_A265BR_Lab_ReportTime = new DateTime[] {DateTime.MinValue} ;
         BC000G3_n265BR_Lab_ReportTime = new bool[] {false} ;
         BC000G3_A106BR_Lab_SpecimenSource = new String[] {""} ;
         BC000G3_n106BR_Lab_SpecimenSource = new bool[] {false} ;
         BC000G3_A109BR_Lab_ResultQual = new String[] {""} ;
         BC000G3_n109BR_Lab_ResultQual = new bool[] {false} ;
         BC000G3_A110BR_Lab_ResultNum = new String[] {""} ;
         BC000G3_n110BR_Lab_ResultNum = new bool[] {false} ;
         BC000G3_A111BR_Lab_ResultUnit = new String[] {""} ;
         BC000G3_n111BR_Lab_ResultUnit = new bool[] {false} ;
         BC000G3_A112BR_Lab_AbnInd = new String[] {""} ;
         BC000G3_n112BR_Lab_AbnInd = new bool[] {false} ;
         BC000G3_A113BR_Lab_NormRangeLow = new String[] {""} ;
         BC000G3_n113BR_Lab_NormRangeLow = new bool[] {false} ;
         BC000G3_A114BR_Lab_NormRangeHigh = new String[] {""} ;
         BC000G3_n114BR_Lab_NormRangeHigh = new bool[] {false} ;
         BC000G3_A115BR_Lab_TestMethod = new String[] {""} ;
         BC000G3_n115BR_Lab_TestMethod = new bool[] {false} ;
         BC000G3_A117BR_Lab_InstrumentName = new String[] {""} ;
         BC000G3_n117BR_Lab_InstrumentName = new bool[] {false} ;
         BC000G3_A118BR_Lab_InstrumentCode = new String[] {""} ;
         BC000G3_n118BR_Lab_InstrumentCode = new bool[] {false} ;
         BC000G3_A430BR_SampleId = new long[1] ;
         BC000G3_n430BR_SampleId = new bool[] {false} ;
         BC000G3_A19BR_EncounterID = new long[1] ;
         sMode17 = "";
         BC000G2_A101BR_LabID = new long[1] ;
         BC000G2_A474BR_Lab_SpecimenSource_Code = new String[] {""} ;
         BC000G2_n474BR_Lab_SpecimenSource_Code = new bool[] {false} ;
         BC000G2_A475BR_Lab_ResultQual_Code = new String[] {""} ;
         BC000G2_n475BR_Lab_ResultQual_Code = new bool[] {false} ;
         BC000G2_A476BR_Lab_AbnInd_Code = new String[] {""} ;
         BC000G2_n476BR_Lab_AbnInd_Code = new bool[] {false} ;
         BC000G2_A224BR_Lab_SampleID = new String[] {""} ;
         BC000G2_n224BR_Lab_SampleID = new bool[] {false} ;
         BC000G2_A102BR_Lab_TestID = new long[1] ;
         BC000G2_n102BR_Lab_TestID = new bool[] {false} ;
         BC000G2_A103BR_Lab_TestCode = new String[] {""} ;
         BC000G2_n103BR_Lab_TestCode = new bool[] {false} ;
         BC000G2_A104BR_Lab_TestName = new String[] {""} ;
         BC000G2_n104BR_Lab_TestName = new bool[] {false} ;
         BC000G2_A261BR_Lab_TestEngName = new String[] {""} ;
         BC000G2_n261BR_Lab_TestEngName = new bool[] {false} ;
         BC000G2_A262BR_Lab_Age = new short[1] ;
         BC000G2_n262BR_Lab_Age = new bool[] {false} ;
         BC000G2_A263BR_Lab_Diag = new String[] {""} ;
         BC000G2_n263BR_Lab_Diag = new bool[] {false} ;
         BC000G2_A105BR_Lab_SpecimenDate = new DateTime[] {DateTime.MinValue} ;
         BC000G2_n105BR_Lab_SpecimenDate = new bool[] {false} ;
         BC000G2_A264BR_Lab_ReceivingTime = new DateTime[] {DateTime.MinValue} ;
         BC000G2_n264BR_Lab_ReceivingTime = new bool[] {false} ;
         BC000G2_A265BR_Lab_ReportTime = new DateTime[] {DateTime.MinValue} ;
         BC000G2_n265BR_Lab_ReportTime = new bool[] {false} ;
         BC000G2_A106BR_Lab_SpecimenSource = new String[] {""} ;
         BC000G2_n106BR_Lab_SpecimenSource = new bool[] {false} ;
         BC000G2_A109BR_Lab_ResultQual = new String[] {""} ;
         BC000G2_n109BR_Lab_ResultQual = new bool[] {false} ;
         BC000G2_A110BR_Lab_ResultNum = new String[] {""} ;
         BC000G2_n110BR_Lab_ResultNum = new bool[] {false} ;
         BC000G2_A111BR_Lab_ResultUnit = new String[] {""} ;
         BC000G2_n111BR_Lab_ResultUnit = new bool[] {false} ;
         BC000G2_A112BR_Lab_AbnInd = new String[] {""} ;
         BC000G2_n112BR_Lab_AbnInd = new bool[] {false} ;
         BC000G2_A113BR_Lab_NormRangeLow = new String[] {""} ;
         BC000G2_n113BR_Lab_NormRangeLow = new bool[] {false} ;
         BC000G2_A114BR_Lab_NormRangeHigh = new String[] {""} ;
         BC000G2_n114BR_Lab_NormRangeHigh = new bool[] {false} ;
         BC000G2_A115BR_Lab_TestMethod = new String[] {""} ;
         BC000G2_n115BR_Lab_TestMethod = new bool[] {false} ;
         BC000G2_A117BR_Lab_InstrumentName = new String[] {""} ;
         BC000G2_n117BR_Lab_InstrumentName = new bool[] {false} ;
         BC000G2_A118BR_Lab_InstrumentCode = new String[] {""} ;
         BC000G2_n118BR_Lab_InstrumentCode = new bool[] {false} ;
         BC000G2_A430BR_SampleId = new long[1] ;
         BC000G2_n430BR_SampleId = new bool[] {false} ;
         BC000G2_A19BR_EncounterID = new long[1] ;
         BC000G8_A101BR_LabID = new long[1] ;
         BC000G11_A85BR_Information_ID = new long[1] ;
         BC000G11_n85BR_Information_ID = new bool[] {false} ;
         BC000G12_A36BR_Information_PatientNo = new String[] {""} ;
         BC000G12_n36BR_Information_PatientNo = new bool[] {false} ;
         BC000G13_A85BR_Information_ID = new long[1] ;
         BC000G13_n85BR_Information_ID = new bool[] {false} ;
         BC000G13_A101BR_LabID = new long[1] ;
         BC000G13_A474BR_Lab_SpecimenSource_Code = new String[] {""} ;
         BC000G13_n474BR_Lab_SpecimenSource_Code = new bool[] {false} ;
         BC000G13_A475BR_Lab_ResultQual_Code = new String[] {""} ;
         BC000G13_n475BR_Lab_ResultQual_Code = new bool[] {false} ;
         BC000G13_A476BR_Lab_AbnInd_Code = new String[] {""} ;
         BC000G13_n476BR_Lab_AbnInd_Code = new bool[] {false} ;
         BC000G13_A36BR_Information_PatientNo = new String[] {""} ;
         BC000G13_n36BR_Information_PatientNo = new bool[] {false} ;
         BC000G13_A224BR_Lab_SampleID = new String[] {""} ;
         BC000G13_n224BR_Lab_SampleID = new bool[] {false} ;
         BC000G13_A102BR_Lab_TestID = new long[1] ;
         BC000G13_n102BR_Lab_TestID = new bool[] {false} ;
         BC000G13_A103BR_Lab_TestCode = new String[] {""} ;
         BC000G13_n103BR_Lab_TestCode = new bool[] {false} ;
         BC000G13_A104BR_Lab_TestName = new String[] {""} ;
         BC000G13_n104BR_Lab_TestName = new bool[] {false} ;
         BC000G13_A261BR_Lab_TestEngName = new String[] {""} ;
         BC000G13_n261BR_Lab_TestEngName = new bool[] {false} ;
         BC000G13_A262BR_Lab_Age = new short[1] ;
         BC000G13_n262BR_Lab_Age = new bool[] {false} ;
         BC000G13_A263BR_Lab_Diag = new String[] {""} ;
         BC000G13_n263BR_Lab_Diag = new bool[] {false} ;
         BC000G13_A105BR_Lab_SpecimenDate = new DateTime[] {DateTime.MinValue} ;
         BC000G13_n105BR_Lab_SpecimenDate = new bool[] {false} ;
         BC000G13_A264BR_Lab_ReceivingTime = new DateTime[] {DateTime.MinValue} ;
         BC000G13_n264BR_Lab_ReceivingTime = new bool[] {false} ;
         BC000G13_A265BR_Lab_ReportTime = new DateTime[] {DateTime.MinValue} ;
         BC000G13_n265BR_Lab_ReportTime = new bool[] {false} ;
         BC000G13_A106BR_Lab_SpecimenSource = new String[] {""} ;
         BC000G13_n106BR_Lab_SpecimenSource = new bool[] {false} ;
         BC000G13_A109BR_Lab_ResultQual = new String[] {""} ;
         BC000G13_n109BR_Lab_ResultQual = new bool[] {false} ;
         BC000G13_A110BR_Lab_ResultNum = new String[] {""} ;
         BC000G13_n110BR_Lab_ResultNum = new bool[] {false} ;
         BC000G13_A111BR_Lab_ResultUnit = new String[] {""} ;
         BC000G13_n111BR_Lab_ResultUnit = new bool[] {false} ;
         BC000G13_A112BR_Lab_AbnInd = new String[] {""} ;
         BC000G13_n112BR_Lab_AbnInd = new bool[] {false} ;
         BC000G13_A113BR_Lab_NormRangeLow = new String[] {""} ;
         BC000G13_n113BR_Lab_NormRangeLow = new bool[] {false} ;
         BC000G13_A114BR_Lab_NormRangeHigh = new String[] {""} ;
         BC000G13_n114BR_Lab_NormRangeHigh = new bool[] {false} ;
         BC000G13_A115BR_Lab_TestMethod = new String[] {""} ;
         BC000G13_n115BR_Lab_TestMethod = new bool[] {false} ;
         BC000G13_A117BR_Lab_InstrumentName = new String[] {""} ;
         BC000G13_n117BR_Lab_InstrumentName = new bool[] {false} ;
         BC000G13_A118BR_Lab_InstrumentCode = new String[] {""} ;
         BC000G13_n118BR_Lab_InstrumentCode = new bool[] {false} ;
         BC000G13_A430BR_SampleId = new long[1] ;
         BC000G13_n430BR_SampleId = new bool[] {false} ;
         BC000G13_A19BR_EncounterID = new long[1] ;
         GXt_char2 = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_lab_bc__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_lab_bc__default(),
            new Object[][] {
                new Object[] {
               BC000G2_A101BR_LabID, BC000G2_A474BR_Lab_SpecimenSource_Code, BC000G2_n474BR_Lab_SpecimenSource_Code, BC000G2_A475BR_Lab_ResultQual_Code, BC000G2_n475BR_Lab_ResultQual_Code, BC000G2_A476BR_Lab_AbnInd_Code, BC000G2_n476BR_Lab_AbnInd_Code, BC000G2_A224BR_Lab_SampleID, BC000G2_n224BR_Lab_SampleID, BC000G2_A102BR_Lab_TestID,
               BC000G2_n102BR_Lab_TestID, BC000G2_A103BR_Lab_TestCode, BC000G2_n103BR_Lab_TestCode, BC000G2_A104BR_Lab_TestName, BC000G2_n104BR_Lab_TestName, BC000G2_A261BR_Lab_TestEngName, BC000G2_n261BR_Lab_TestEngName, BC000G2_A262BR_Lab_Age, BC000G2_n262BR_Lab_Age, BC000G2_A263BR_Lab_Diag,
               BC000G2_n263BR_Lab_Diag, BC000G2_A105BR_Lab_SpecimenDate, BC000G2_n105BR_Lab_SpecimenDate, BC000G2_A264BR_Lab_ReceivingTime, BC000G2_n264BR_Lab_ReceivingTime, BC000G2_A265BR_Lab_ReportTime, BC000G2_n265BR_Lab_ReportTime, BC000G2_A106BR_Lab_SpecimenSource, BC000G2_n106BR_Lab_SpecimenSource, BC000G2_A109BR_Lab_ResultQual,
               BC000G2_n109BR_Lab_ResultQual, BC000G2_A110BR_Lab_ResultNum, BC000G2_n110BR_Lab_ResultNum, BC000G2_A111BR_Lab_ResultUnit, BC000G2_n111BR_Lab_ResultUnit, BC000G2_A112BR_Lab_AbnInd, BC000G2_n112BR_Lab_AbnInd, BC000G2_A113BR_Lab_NormRangeLow, BC000G2_n113BR_Lab_NormRangeLow, BC000G2_A114BR_Lab_NormRangeHigh,
               BC000G2_n114BR_Lab_NormRangeHigh, BC000G2_A115BR_Lab_TestMethod, BC000G2_n115BR_Lab_TestMethod, BC000G2_A117BR_Lab_InstrumentName, BC000G2_n117BR_Lab_InstrumentName, BC000G2_A118BR_Lab_InstrumentCode, BC000G2_n118BR_Lab_InstrumentCode, BC000G2_A430BR_SampleId, BC000G2_n430BR_SampleId, BC000G2_A19BR_EncounterID
               }
               , new Object[] {
               BC000G3_A101BR_LabID, BC000G3_A474BR_Lab_SpecimenSource_Code, BC000G3_n474BR_Lab_SpecimenSource_Code, BC000G3_A475BR_Lab_ResultQual_Code, BC000G3_n475BR_Lab_ResultQual_Code, BC000G3_A476BR_Lab_AbnInd_Code, BC000G3_n476BR_Lab_AbnInd_Code, BC000G3_A224BR_Lab_SampleID, BC000G3_n224BR_Lab_SampleID, BC000G3_A102BR_Lab_TestID,
               BC000G3_n102BR_Lab_TestID, BC000G3_A103BR_Lab_TestCode, BC000G3_n103BR_Lab_TestCode, BC000G3_A104BR_Lab_TestName, BC000G3_n104BR_Lab_TestName, BC000G3_A261BR_Lab_TestEngName, BC000G3_n261BR_Lab_TestEngName, BC000G3_A262BR_Lab_Age, BC000G3_n262BR_Lab_Age, BC000G3_A263BR_Lab_Diag,
               BC000G3_n263BR_Lab_Diag, BC000G3_A105BR_Lab_SpecimenDate, BC000G3_n105BR_Lab_SpecimenDate, BC000G3_A264BR_Lab_ReceivingTime, BC000G3_n264BR_Lab_ReceivingTime, BC000G3_A265BR_Lab_ReportTime, BC000G3_n265BR_Lab_ReportTime, BC000G3_A106BR_Lab_SpecimenSource, BC000G3_n106BR_Lab_SpecimenSource, BC000G3_A109BR_Lab_ResultQual,
               BC000G3_n109BR_Lab_ResultQual, BC000G3_A110BR_Lab_ResultNum, BC000G3_n110BR_Lab_ResultNum, BC000G3_A111BR_Lab_ResultUnit, BC000G3_n111BR_Lab_ResultUnit, BC000G3_A112BR_Lab_AbnInd, BC000G3_n112BR_Lab_AbnInd, BC000G3_A113BR_Lab_NormRangeLow, BC000G3_n113BR_Lab_NormRangeLow, BC000G3_A114BR_Lab_NormRangeHigh,
               BC000G3_n114BR_Lab_NormRangeHigh, BC000G3_A115BR_Lab_TestMethod, BC000G3_n115BR_Lab_TestMethod, BC000G3_A117BR_Lab_InstrumentName, BC000G3_n117BR_Lab_InstrumentName, BC000G3_A118BR_Lab_InstrumentCode, BC000G3_n118BR_Lab_InstrumentCode, BC000G3_A430BR_SampleId, BC000G3_n430BR_SampleId, BC000G3_A19BR_EncounterID
               }
               , new Object[] {
               BC000G4_A85BR_Information_ID, BC000G4_n85BR_Information_ID
               }
               , new Object[] {
               BC000G5_A36BR_Information_PatientNo, BC000G5_n36BR_Information_PatientNo
               }
               , new Object[] {
               BC000G6_A85BR_Information_ID, BC000G6_n85BR_Information_ID, BC000G6_A101BR_LabID, BC000G6_A474BR_Lab_SpecimenSource_Code, BC000G6_n474BR_Lab_SpecimenSource_Code, BC000G6_A475BR_Lab_ResultQual_Code, BC000G6_n475BR_Lab_ResultQual_Code, BC000G6_A476BR_Lab_AbnInd_Code, BC000G6_n476BR_Lab_AbnInd_Code, BC000G6_A36BR_Information_PatientNo,
               BC000G6_n36BR_Information_PatientNo, BC000G6_A224BR_Lab_SampleID, BC000G6_n224BR_Lab_SampleID, BC000G6_A102BR_Lab_TestID, BC000G6_n102BR_Lab_TestID, BC000G6_A103BR_Lab_TestCode, BC000G6_n103BR_Lab_TestCode, BC000G6_A104BR_Lab_TestName, BC000G6_n104BR_Lab_TestName, BC000G6_A261BR_Lab_TestEngName,
               BC000G6_n261BR_Lab_TestEngName, BC000G6_A262BR_Lab_Age, BC000G6_n262BR_Lab_Age, BC000G6_A263BR_Lab_Diag, BC000G6_n263BR_Lab_Diag, BC000G6_A105BR_Lab_SpecimenDate, BC000G6_n105BR_Lab_SpecimenDate, BC000G6_A264BR_Lab_ReceivingTime, BC000G6_n264BR_Lab_ReceivingTime, BC000G6_A265BR_Lab_ReportTime,
               BC000G6_n265BR_Lab_ReportTime, BC000G6_A106BR_Lab_SpecimenSource, BC000G6_n106BR_Lab_SpecimenSource, BC000G6_A109BR_Lab_ResultQual, BC000G6_n109BR_Lab_ResultQual, BC000G6_A110BR_Lab_ResultNum, BC000G6_n110BR_Lab_ResultNum, BC000G6_A111BR_Lab_ResultUnit, BC000G6_n111BR_Lab_ResultUnit, BC000G6_A112BR_Lab_AbnInd,
               BC000G6_n112BR_Lab_AbnInd, BC000G6_A113BR_Lab_NormRangeLow, BC000G6_n113BR_Lab_NormRangeLow, BC000G6_A114BR_Lab_NormRangeHigh, BC000G6_n114BR_Lab_NormRangeHigh, BC000G6_A115BR_Lab_TestMethod, BC000G6_n115BR_Lab_TestMethod, BC000G6_A117BR_Lab_InstrumentName, BC000G6_n117BR_Lab_InstrumentName, BC000G6_A118BR_Lab_InstrumentCode,
               BC000G6_n118BR_Lab_InstrumentCode, BC000G6_A430BR_SampleId, BC000G6_n430BR_SampleId, BC000G6_A19BR_EncounterID
               }
               , new Object[] {
               BC000G7_A101BR_LabID
               }
               , new Object[] {
               BC000G8_A101BR_LabID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000G11_A85BR_Information_ID, BC000G11_n85BR_Information_ID
               }
               , new Object[] {
               BC000G12_A36BR_Information_PatientNo, BC000G12_n36BR_Information_PatientNo
               }
               , new Object[] {
               BC000G13_A85BR_Information_ID, BC000G13_n85BR_Information_ID, BC000G13_A101BR_LabID, BC000G13_A474BR_Lab_SpecimenSource_Code, BC000G13_n474BR_Lab_SpecimenSource_Code, BC000G13_A475BR_Lab_ResultQual_Code, BC000G13_n475BR_Lab_ResultQual_Code, BC000G13_A476BR_Lab_AbnInd_Code, BC000G13_n476BR_Lab_AbnInd_Code, BC000G13_A36BR_Information_PatientNo,
               BC000G13_n36BR_Information_PatientNo, BC000G13_A224BR_Lab_SampleID, BC000G13_n224BR_Lab_SampleID, BC000G13_A102BR_Lab_TestID, BC000G13_n102BR_Lab_TestID, BC000G13_A103BR_Lab_TestCode, BC000G13_n103BR_Lab_TestCode, BC000G13_A104BR_Lab_TestName, BC000G13_n104BR_Lab_TestName, BC000G13_A261BR_Lab_TestEngName,
               BC000G13_n261BR_Lab_TestEngName, BC000G13_A262BR_Lab_Age, BC000G13_n262BR_Lab_Age, BC000G13_A263BR_Lab_Diag, BC000G13_n263BR_Lab_Diag, BC000G13_A105BR_Lab_SpecimenDate, BC000G13_n105BR_Lab_SpecimenDate, BC000G13_A264BR_Lab_ReceivingTime, BC000G13_n264BR_Lab_ReceivingTime, BC000G13_A265BR_Lab_ReportTime,
               BC000G13_n265BR_Lab_ReportTime, BC000G13_A106BR_Lab_SpecimenSource, BC000G13_n106BR_Lab_SpecimenSource, BC000G13_A109BR_Lab_ResultQual, BC000G13_n109BR_Lab_ResultQual, BC000G13_A110BR_Lab_ResultNum, BC000G13_n110BR_Lab_ResultNum, BC000G13_A111BR_Lab_ResultUnit, BC000G13_n111BR_Lab_ResultUnit, BC000G13_A112BR_Lab_AbnInd,
               BC000G13_n112BR_Lab_AbnInd, BC000G13_A113BR_Lab_NormRangeLow, BC000G13_n113BR_Lab_NormRangeLow, BC000G13_A114BR_Lab_NormRangeHigh, BC000G13_n114BR_Lab_NormRangeHigh, BC000G13_A115BR_Lab_TestMethod, BC000G13_n115BR_Lab_TestMethod, BC000G13_A117BR_Lab_InstrumentName, BC000G13_n117BR_Lab_InstrumentName, BC000G13_A118BR_Lab_InstrumentCode,
               BC000G13_n118BR_Lab_InstrumentCode, BC000G13_A430BR_SampleId, BC000G13_n430BR_SampleId, BC000G13_A19BR_EncounterID
               }
            }
         );
         AV17Pgmname = "BR_Lab_BC";
         INITTRN();
         /* Execute Start event if defined. */
         /* Execute user event: Start */
         E120G2 ();
         standaloneNotModal( ) ;
      }

      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short GX_JID ;
      private short Z262BR_Lab_Age ;
      private short A262BR_Lab_Age ;
      private short RcdFound17 ;
      private int trnEnded ;
      private int AV18GXV1 ;
      private long Z101BR_LabID ;
      private long A101BR_LabID ;
      private long AV10Insert_BR_EncounterID ;
      private long Z102BR_Lab_TestID ;
      private long A102BR_Lab_TestID ;
      private long Z430BR_SampleId ;
      private long A430BR_SampleId ;
      private long Z19BR_EncounterID ;
      private long A19BR_EncounterID ;
      private long Z85BR_Information_ID ;
      private long A85BR_Information_ID ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String AV17Pgmname ;
      private String sMode17 ;
      private String GXt_char2 ;
      private DateTime Z105BR_Lab_SpecimenDate ;
      private DateTime A105BR_Lab_SpecimenDate ;
      private DateTime Z264BR_Lab_ReceivingTime ;
      private DateTime A264BR_Lab_ReceivingTime ;
      private DateTime Z265BR_Lab_ReportTime ;
      private DateTime A265BR_Lab_ReportTime ;
      private bool AV13IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool returnInSub ;
      private bool n85BR_Information_ID ;
      private bool n474BR_Lab_SpecimenSource_Code ;
      private bool n475BR_Lab_ResultQual_Code ;
      private bool n476BR_Lab_AbnInd_Code ;
      private bool n36BR_Information_PatientNo ;
      private bool n224BR_Lab_SampleID ;
      private bool n102BR_Lab_TestID ;
      private bool n103BR_Lab_TestCode ;
      private bool n104BR_Lab_TestName ;
      private bool n261BR_Lab_TestEngName ;
      private bool n262BR_Lab_Age ;
      private bool n263BR_Lab_Diag ;
      private bool n105BR_Lab_SpecimenDate ;
      private bool n264BR_Lab_ReceivingTime ;
      private bool n265BR_Lab_ReportTime ;
      private bool n106BR_Lab_SpecimenSource ;
      private bool n109BR_Lab_ResultQual ;
      private bool n110BR_Lab_ResultNum ;
      private bool n111BR_Lab_ResultUnit ;
      private bool n112BR_Lab_AbnInd ;
      private bool n113BR_Lab_NormRangeLow ;
      private bool n114BR_Lab_NormRangeHigh ;
      private bool n115BR_Lab_TestMethod ;
      private bool n117BR_Lab_InstrumentName ;
      private bool n118BR_Lab_InstrumentCode ;
      private bool n430BR_SampleId ;
      private bool Gx_longc ;
      private String Z474BR_Lab_SpecimenSource_Code ;
      private String A474BR_Lab_SpecimenSource_Code ;
      private String Z475BR_Lab_ResultQual_Code ;
      private String A475BR_Lab_ResultQual_Code ;
      private String Z476BR_Lab_AbnInd_Code ;
      private String A476BR_Lab_AbnInd_Code ;
      private String Z224BR_Lab_SampleID ;
      private String A224BR_Lab_SampleID ;
      private String Z103BR_Lab_TestCode ;
      private String A103BR_Lab_TestCode ;
      private String Z104BR_Lab_TestName ;
      private String A104BR_Lab_TestName ;
      private String Z261BR_Lab_TestEngName ;
      private String A261BR_Lab_TestEngName ;
      private String Z263BR_Lab_Diag ;
      private String A263BR_Lab_Diag ;
      private String Z106BR_Lab_SpecimenSource ;
      private String A106BR_Lab_SpecimenSource ;
      private String Z109BR_Lab_ResultQual ;
      private String A109BR_Lab_ResultQual ;
      private String Z110BR_Lab_ResultNum ;
      private String A110BR_Lab_ResultNum ;
      private String Z111BR_Lab_ResultUnit ;
      private String A111BR_Lab_ResultUnit ;
      private String Z112BR_Lab_AbnInd ;
      private String A112BR_Lab_AbnInd ;
      private String Z113BR_Lab_NormRangeLow ;
      private String A113BR_Lab_NormRangeLow ;
      private String Z114BR_Lab_NormRangeHigh ;
      private String A114BR_Lab_NormRangeHigh ;
      private String Z115BR_Lab_TestMethod ;
      private String A115BR_Lab_TestMethod ;
      private String Z117BR_Lab_InstrumentName ;
      private String A117BR_Lab_InstrumentName ;
      private String Z118BR_Lab_InstrumentCode ;
      private String A118BR_Lab_InstrumentCode ;
      private String Z36BR_Information_PatientNo ;
      private String A36BR_Information_PatientNo ;
      private IGxSession AV9WebSession ;
      private SdtBR_Lab bcBR_Lab ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] BC000G6_A85BR_Information_ID ;
      private bool[] BC000G6_n85BR_Information_ID ;
      private long[] BC000G6_A101BR_LabID ;
      private String[] BC000G6_A474BR_Lab_SpecimenSource_Code ;
      private bool[] BC000G6_n474BR_Lab_SpecimenSource_Code ;
      private String[] BC000G6_A475BR_Lab_ResultQual_Code ;
      private bool[] BC000G6_n475BR_Lab_ResultQual_Code ;
      private String[] BC000G6_A476BR_Lab_AbnInd_Code ;
      private bool[] BC000G6_n476BR_Lab_AbnInd_Code ;
      private String[] BC000G6_A36BR_Information_PatientNo ;
      private bool[] BC000G6_n36BR_Information_PatientNo ;
      private String[] BC000G6_A224BR_Lab_SampleID ;
      private bool[] BC000G6_n224BR_Lab_SampleID ;
      private long[] BC000G6_A102BR_Lab_TestID ;
      private bool[] BC000G6_n102BR_Lab_TestID ;
      private String[] BC000G6_A103BR_Lab_TestCode ;
      private bool[] BC000G6_n103BR_Lab_TestCode ;
      private String[] BC000G6_A104BR_Lab_TestName ;
      private bool[] BC000G6_n104BR_Lab_TestName ;
      private String[] BC000G6_A261BR_Lab_TestEngName ;
      private bool[] BC000G6_n261BR_Lab_TestEngName ;
      private short[] BC000G6_A262BR_Lab_Age ;
      private bool[] BC000G6_n262BR_Lab_Age ;
      private String[] BC000G6_A263BR_Lab_Diag ;
      private bool[] BC000G6_n263BR_Lab_Diag ;
      private DateTime[] BC000G6_A105BR_Lab_SpecimenDate ;
      private bool[] BC000G6_n105BR_Lab_SpecimenDate ;
      private DateTime[] BC000G6_A264BR_Lab_ReceivingTime ;
      private bool[] BC000G6_n264BR_Lab_ReceivingTime ;
      private DateTime[] BC000G6_A265BR_Lab_ReportTime ;
      private bool[] BC000G6_n265BR_Lab_ReportTime ;
      private String[] BC000G6_A106BR_Lab_SpecimenSource ;
      private bool[] BC000G6_n106BR_Lab_SpecimenSource ;
      private String[] BC000G6_A109BR_Lab_ResultQual ;
      private bool[] BC000G6_n109BR_Lab_ResultQual ;
      private String[] BC000G6_A110BR_Lab_ResultNum ;
      private bool[] BC000G6_n110BR_Lab_ResultNum ;
      private String[] BC000G6_A111BR_Lab_ResultUnit ;
      private bool[] BC000G6_n111BR_Lab_ResultUnit ;
      private String[] BC000G6_A112BR_Lab_AbnInd ;
      private bool[] BC000G6_n112BR_Lab_AbnInd ;
      private String[] BC000G6_A113BR_Lab_NormRangeLow ;
      private bool[] BC000G6_n113BR_Lab_NormRangeLow ;
      private String[] BC000G6_A114BR_Lab_NormRangeHigh ;
      private bool[] BC000G6_n114BR_Lab_NormRangeHigh ;
      private String[] BC000G6_A115BR_Lab_TestMethod ;
      private bool[] BC000G6_n115BR_Lab_TestMethod ;
      private String[] BC000G6_A117BR_Lab_InstrumentName ;
      private bool[] BC000G6_n117BR_Lab_InstrumentName ;
      private String[] BC000G6_A118BR_Lab_InstrumentCode ;
      private bool[] BC000G6_n118BR_Lab_InstrumentCode ;
      private long[] BC000G6_A430BR_SampleId ;
      private bool[] BC000G6_n430BR_SampleId ;
      private long[] BC000G6_A19BR_EncounterID ;
      private long[] BC000G4_A85BR_Information_ID ;
      private bool[] BC000G4_n85BR_Information_ID ;
      private String[] BC000G5_A36BR_Information_PatientNo ;
      private bool[] BC000G5_n36BR_Information_PatientNo ;
      private long[] BC000G7_A101BR_LabID ;
      private long[] BC000G3_A101BR_LabID ;
      private String[] BC000G3_A474BR_Lab_SpecimenSource_Code ;
      private bool[] BC000G3_n474BR_Lab_SpecimenSource_Code ;
      private String[] BC000G3_A475BR_Lab_ResultQual_Code ;
      private bool[] BC000G3_n475BR_Lab_ResultQual_Code ;
      private String[] BC000G3_A476BR_Lab_AbnInd_Code ;
      private bool[] BC000G3_n476BR_Lab_AbnInd_Code ;
      private String[] BC000G3_A224BR_Lab_SampleID ;
      private bool[] BC000G3_n224BR_Lab_SampleID ;
      private long[] BC000G3_A102BR_Lab_TestID ;
      private bool[] BC000G3_n102BR_Lab_TestID ;
      private String[] BC000G3_A103BR_Lab_TestCode ;
      private bool[] BC000G3_n103BR_Lab_TestCode ;
      private String[] BC000G3_A104BR_Lab_TestName ;
      private bool[] BC000G3_n104BR_Lab_TestName ;
      private String[] BC000G3_A261BR_Lab_TestEngName ;
      private bool[] BC000G3_n261BR_Lab_TestEngName ;
      private short[] BC000G3_A262BR_Lab_Age ;
      private bool[] BC000G3_n262BR_Lab_Age ;
      private String[] BC000G3_A263BR_Lab_Diag ;
      private bool[] BC000G3_n263BR_Lab_Diag ;
      private DateTime[] BC000G3_A105BR_Lab_SpecimenDate ;
      private bool[] BC000G3_n105BR_Lab_SpecimenDate ;
      private DateTime[] BC000G3_A264BR_Lab_ReceivingTime ;
      private bool[] BC000G3_n264BR_Lab_ReceivingTime ;
      private DateTime[] BC000G3_A265BR_Lab_ReportTime ;
      private bool[] BC000G3_n265BR_Lab_ReportTime ;
      private String[] BC000G3_A106BR_Lab_SpecimenSource ;
      private bool[] BC000G3_n106BR_Lab_SpecimenSource ;
      private String[] BC000G3_A109BR_Lab_ResultQual ;
      private bool[] BC000G3_n109BR_Lab_ResultQual ;
      private String[] BC000G3_A110BR_Lab_ResultNum ;
      private bool[] BC000G3_n110BR_Lab_ResultNum ;
      private String[] BC000G3_A111BR_Lab_ResultUnit ;
      private bool[] BC000G3_n111BR_Lab_ResultUnit ;
      private String[] BC000G3_A112BR_Lab_AbnInd ;
      private bool[] BC000G3_n112BR_Lab_AbnInd ;
      private String[] BC000G3_A113BR_Lab_NormRangeLow ;
      private bool[] BC000G3_n113BR_Lab_NormRangeLow ;
      private String[] BC000G3_A114BR_Lab_NormRangeHigh ;
      private bool[] BC000G3_n114BR_Lab_NormRangeHigh ;
      private String[] BC000G3_A115BR_Lab_TestMethod ;
      private bool[] BC000G3_n115BR_Lab_TestMethod ;
      private String[] BC000G3_A117BR_Lab_InstrumentName ;
      private bool[] BC000G3_n117BR_Lab_InstrumentName ;
      private String[] BC000G3_A118BR_Lab_InstrumentCode ;
      private bool[] BC000G3_n118BR_Lab_InstrumentCode ;
      private long[] BC000G3_A430BR_SampleId ;
      private bool[] BC000G3_n430BR_SampleId ;
      private long[] BC000G3_A19BR_EncounterID ;
      private long[] BC000G2_A101BR_LabID ;
      private String[] BC000G2_A474BR_Lab_SpecimenSource_Code ;
      private bool[] BC000G2_n474BR_Lab_SpecimenSource_Code ;
      private String[] BC000G2_A475BR_Lab_ResultQual_Code ;
      private bool[] BC000G2_n475BR_Lab_ResultQual_Code ;
      private String[] BC000G2_A476BR_Lab_AbnInd_Code ;
      private bool[] BC000G2_n476BR_Lab_AbnInd_Code ;
      private String[] BC000G2_A224BR_Lab_SampleID ;
      private bool[] BC000G2_n224BR_Lab_SampleID ;
      private long[] BC000G2_A102BR_Lab_TestID ;
      private bool[] BC000G2_n102BR_Lab_TestID ;
      private String[] BC000G2_A103BR_Lab_TestCode ;
      private bool[] BC000G2_n103BR_Lab_TestCode ;
      private String[] BC000G2_A104BR_Lab_TestName ;
      private bool[] BC000G2_n104BR_Lab_TestName ;
      private String[] BC000G2_A261BR_Lab_TestEngName ;
      private bool[] BC000G2_n261BR_Lab_TestEngName ;
      private short[] BC000G2_A262BR_Lab_Age ;
      private bool[] BC000G2_n262BR_Lab_Age ;
      private String[] BC000G2_A263BR_Lab_Diag ;
      private bool[] BC000G2_n263BR_Lab_Diag ;
      private DateTime[] BC000G2_A105BR_Lab_SpecimenDate ;
      private bool[] BC000G2_n105BR_Lab_SpecimenDate ;
      private DateTime[] BC000G2_A264BR_Lab_ReceivingTime ;
      private bool[] BC000G2_n264BR_Lab_ReceivingTime ;
      private DateTime[] BC000G2_A265BR_Lab_ReportTime ;
      private bool[] BC000G2_n265BR_Lab_ReportTime ;
      private String[] BC000G2_A106BR_Lab_SpecimenSource ;
      private bool[] BC000G2_n106BR_Lab_SpecimenSource ;
      private String[] BC000G2_A109BR_Lab_ResultQual ;
      private bool[] BC000G2_n109BR_Lab_ResultQual ;
      private String[] BC000G2_A110BR_Lab_ResultNum ;
      private bool[] BC000G2_n110BR_Lab_ResultNum ;
      private String[] BC000G2_A111BR_Lab_ResultUnit ;
      private bool[] BC000G2_n111BR_Lab_ResultUnit ;
      private String[] BC000G2_A112BR_Lab_AbnInd ;
      private bool[] BC000G2_n112BR_Lab_AbnInd ;
      private String[] BC000G2_A113BR_Lab_NormRangeLow ;
      private bool[] BC000G2_n113BR_Lab_NormRangeLow ;
      private String[] BC000G2_A114BR_Lab_NormRangeHigh ;
      private bool[] BC000G2_n114BR_Lab_NormRangeHigh ;
      private String[] BC000G2_A115BR_Lab_TestMethod ;
      private bool[] BC000G2_n115BR_Lab_TestMethod ;
      private String[] BC000G2_A117BR_Lab_InstrumentName ;
      private bool[] BC000G2_n117BR_Lab_InstrumentName ;
      private String[] BC000G2_A118BR_Lab_InstrumentCode ;
      private bool[] BC000G2_n118BR_Lab_InstrumentCode ;
      private long[] BC000G2_A430BR_SampleId ;
      private bool[] BC000G2_n430BR_SampleId ;
      private long[] BC000G2_A19BR_EncounterID ;
      private long[] BC000G8_A101BR_LabID ;
      private long[] BC000G11_A85BR_Information_ID ;
      private bool[] BC000G11_n85BR_Information_ID ;
      private String[] BC000G12_A36BR_Information_PatientNo ;
      private bool[] BC000G12_n36BR_Information_PatientNo ;
      private long[] BC000G13_A85BR_Information_ID ;
      private bool[] BC000G13_n85BR_Information_ID ;
      private long[] BC000G13_A101BR_LabID ;
      private String[] BC000G13_A474BR_Lab_SpecimenSource_Code ;
      private bool[] BC000G13_n474BR_Lab_SpecimenSource_Code ;
      private String[] BC000G13_A475BR_Lab_ResultQual_Code ;
      private bool[] BC000G13_n475BR_Lab_ResultQual_Code ;
      private String[] BC000G13_A476BR_Lab_AbnInd_Code ;
      private bool[] BC000G13_n476BR_Lab_AbnInd_Code ;
      private String[] BC000G13_A36BR_Information_PatientNo ;
      private bool[] BC000G13_n36BR_Information_PatientNo ;
      private String[] BC000G13_A224BR_Lab_SampleID ;
      private bool[] BC000G13_n224BR_Lab_SampleID ;
      private long[] BC000G13_A102BR_Lab_TestID ;
      private bool[] BC000G13_n102BR_Lab_TestID ;
      private String[] BC000G13_A103BR_Lab_TestCode ;
      private bool[] BC000G13_n103BR_Lab_TestCode ;
      private String[] BC000G13_A104BR_Lab_TestName ;
      private bool[] BC000G13_n104BR_Lab_TestName ;
      private String[] BC000G13_A261BR_Lab_TestEngName ;
      private bool[] BC000G13_n261BR_Lab_TestEngName ;
      private short[] BC000G13_A262BR_Lab_Age ;
      private bool[] BC000G13_n262BR_Lab_Age ;
      private String[] BC000G13_A263BR_Lab_Diag ;
      private bool[] BC000G13_n263BR_Lab_Diag ;
      private DateTime[] BC000G13_A105BR_Lab_SpecimenDate ;
      private bool[] BC000G13_n105BR_Lab_SpecimenDate ;
      private DateTime[] BC000G13_A264BR_Lab_ReceivingTime ;
      private bool[] BC000G13_n264BR_Lab_ReceivingTime ;
      private DateTime[] BC000G13_A265BR_Lab_ReportTime ;
      private bool[] BC000G13_n265BR_Lab_ReportTime ;
      private String[] BC000G13_A106BR_Lab_SpecimenSource ;
      private bool[] BC000G13_n106BR_Lab_SpecimenSource ;
      private String[] BC000G13_A109BR_Lab_ResultQual ;
      private bool[] BC000G13_n109BR_Lab_ResultQual ;
      private String[] BC000G13_A110BR_Lab_ResultNum ;
      private bool[] BC000G13_n110BR_Lab_ResultNum ;
      private String[] BC000G13_A111BR_Lab_ResultUnit ;
      private bool[] BC000G13_n111BR_Lab_ResultUnit ;
      private String[] BC000G13_A112BR_Lab_AbnInd ;
      private bool[] BC000G13_n112BR_Lab_AbnInd ;
      private String[] BC000G13_A113BR_Lab_NormRangeLow ;
      private bool[] BC000G13_n113BR_Lab_NormRangeLow ;
      private String[] BC000G13_A114BR_Lab_NormRangeHigh ;
      private bool[] BC000G13_n114BR_Lab_NormRangeHigh ;
      private String[] BC000G13_A115BR_Lab_TestMethod ;
      private bool[] BC000G13_n115BR_Lab_TestMethod ;
      private String[] BC000G13_A117BR_Lab_InstrumentName ;
      private bool[] BC000G13_n117BR_Lab_InstrumentName ;
      private String[] BC000G13_A118BR_Lab_InstrumentCode ;
      private bool[] BC000G13_n118BR_Lab_InstrumentCode ;
      private long[] BC000G13_A430BR_SampleId ;
      private bool[] BC000G13_n430BR_SampleId ;
      private long[] BC000G13_A19BR_EncounterID ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_datastore1 ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV7WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV8TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV11TrnContextAtt ;
   }

   public class br_lab_bc__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class br_lab_bc__default : DataStoreHelperBase, IDataStoreHelper
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
        Object[] prmBC000G6 ;
        prmBC000G6 = new Object[] {
        new Object[] {"@BR_LabID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000G4 ;
        prmBC000G4 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000G5 ;
        prmBC000G5 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000G7 ;
        prmBC000G7 = new Object[] {
        new Object[] {"@BR_LabID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000G3 ;
        prmBC000G3 = new Object[] {
        new Object[] {"@BR_LabID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000G2 ;
        prmBC000G2 = new Object[] {
        new Object[] {"@BR_LabID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000G8 ;
        prmBC000G8 = new Object[] {
        new Object[] {"@BR_Lab_SpecimenSource_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Lab_ResultQual_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Lab_AbnInd_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Lab_SampleID",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Lab_TestID",SqlDbType.Decimal,10,0} ,
        new Object[] {"@BR_Lab_TestCode",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Lab_TestName",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Lab_TestEngName",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Lab_Age",SqlDbType.SmallInt,3,0} ,
        new Object[] {"@BR_Lab_Diag",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Lab_SpecimenDate",SqlDbType.DateTime,10,8} ,
        new Object[] {"@BR_Lab_ReceivingTime",SqlDbType.DateTime,10,8} ,
        new Object[] {"@BR_Lab_ReportTime",SqlDbType.DateTime,10,8} ,
        new Object[] {"@BR_Lab_SpecimenSource",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Lab_ResultQual",SqlDbType.NVarChar,500,0} ,
        new Object[] {"@BR_Lab_ResultNum",SqlDbType.NVarChar,500,0} ,
        new Object[] {"@BR_Lab_ResultUnit",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Lab_AbnInd",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Lab_NormRangeLow",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Lab_NormRangeHigh",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Lab_TestMethod",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Lab_InstrumentName",SqlDbType.NVarChar,200,0} ,
        new Object[] {"@BR_Lab_InstrumentCode",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_SampleId",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000G9 ;
        prmBC000G9 = new Object[] {
        new Object[] {"@BR_Lab_SpecimenSource_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Lab_ResultQual_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Lab_AbnInd_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Lab_SampleID",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Lab_TestID",SqlDbType.Decimal,10,0} ,
        new Object[] {"@BR_Lab_TestCode",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Lab_TestName",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Lab_TestEngName",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Lab_Age",SqlDbType.SmallInt,3,0} ,
        new Object[] {"@BR_Lab_Diag",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Lab_SpecimenDate",SqlDbType.DateTime,10,8} ,
        new Object[] {"@BR_Lab_ReceivingTime",SqlDbType.DateTime,10,8} ,
        new Object[] {"@BR_Lab_ReportTime",SqlDbType.DateTime,10,8} ,
        new Object[] {"@BR_Lab_SpecimenSource",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Lab_ResultQual",SqlDbType.NVarChar,500,0} ,
        new Object[] {"@BR_Lab_ResultNum",SqlDbType.NVarChar,500,0} ,
        new Object[] {"@BR_Lab_ResultUnit",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Lab_AbnInd",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Lab_NormRangeLow",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Lab_NormRangeHigh",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Lab_TestMethod",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Lab_InstrumentName",SqlDbType.NVarChar,200,0} ,
        new Object[] {"@BR_Lab_InstrumentCode",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_SampleId",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_LabID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000G10 ;
        prmBC000G10 = new Object[] {
        new Object[] {"@BR_LabID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000G11 ;
        prmBC000G11 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000G12 ;
        prmBC000G12 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000G13 ;
        prmBC000G13 = new Object[] {
        new Object[] {"@BR_LabID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("BC000G2", "SELECT [BR_LabID], [BR_Lab_SpecimenSource_Code], [BR_Lab_ResultQual_Code], [BR_Lab_AbnInd_Code], [BR_Lab_SampleID], [BR_Lab_TestID], [BR_Lab_TestCode], [BR_Lab_TestName], [BR_Lab_TestEngName], [BR_Lab_Age], [BR_Lab_Diag], [BR_Lab_SpecimenDate], [BR_Lab_ReceivingTime], [BR_Lab_ReportTime], [BR_Lab_SpecimenSource], [BR_Lab_ResultQual], [BR_Lab_ResultNum], [BR_Lab_ResultUnit], [BR_Lab_AbnInd], [BR_Lab_NormRangeLow], [BR_Lab_NormRangeHigh], [BR_Lab_TestMethod], [BR_Lab_InstrumentName], [BR_Lab_InstrumentCode], [BR_SampleId], [BR_EncounterID] FROM [BR_Lab] WITH (UPDLOCK) WHERE [BR_LabID] = @BR_LabID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000G2,1,0,true,false )
           ,new CursorDef("BC000G3", "SELECT [BR_LabID], [BR_Lab_SpecimenSource_Code], [BR_Lab_ResultQual_Code], [BR_Lab_AbnInd_Code], [BR_Lab_SampleID], [BR_Lab_TestID], [BR_Lab_TestCode], [BR_Lab_TestName], [BR_Lab_TestEngName], [BR_Lab_Age], [BR_Lab_Diag], [BR_Lab_SpecimenDate], [BR_Lab_ReceivingTime], [BR_Lab_ReportTime], [BR_Lab_SpecimenSource], [BR_Lab_ResultQual], [BR_Lab_ResultNum], [BR_Lab_ResultUnit], [BR_Lab_AbnInd], [BR_Lab_NormRangeLow], [BR_Lab_NormRangeHigh], [BR_Lab_TestMethod], [BR_Lab_InstrumentName], [BR_Lab_InstrumentCode], [BR_SampleId], [BR_EncounterID] FROM [BR_Lab] WITH (NOLOCK) WHERE [BR_LabID] = @BR_LabID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000G3,1,0,true,false )
           ,new CursorDef("BC000G4", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000G4,1,0,true,false )
           ,new CursorDef("BC000G5", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000G5,1,0,true,false )
           ,new CursorDef("BC000G6", "SELECT T2.[BR_Information_ID], TM1.[BR_LabID], TM1.[BR_Lab_SpecimenSource_Code], TM1.[BR_Lab_ResultQual_Code], TM1.[BR_Lab_AbnInd_Code], T3.[BR_Information_PatientNo], TM1.[BR_Lab_SampleID], TM1.[BR_Lab_TestID], TM1.[BR_Lab_TestCode], TM1.[BR_Lab_TestName], TM1.[BR_Lab_TestEngName], TM1.[BR_Lab_Age], TM1.[BR_Lab_Diag], TM1.[BR_Lab_SpecimenDate], TM1.[BR_Lab_ReceivingTime], TM1.[BR_Lab_ReportTime], TM1.[BR_Lab_SpecimenSource], TM1.[BR_Lab_ResultQual], TM1.[BR_Lab_ResultNum], TM1.[BR_Lab_ResultUnit], TM1.[BR_Lab_AbnInd], TM1.[BR_Lab_NormRangeLow], TM1.[BR_Lab_NormRangeHigh], TM1.[BR_Lab_TestMethod], TM1.[BR_Lab_InstrumentName], TM1.[BR_Lab_InstrumentCode], TM1.[BR_SampleId], TM1.[BR_EncounterID] FROM (([BR_Lab] TM1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = TM1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID]) WHERE TM1.[BR_LabID] = @BR_LabID ORDER BY TM1.[BR_LabID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000G6,100,0,true,false )
           ,new CursorDef("BC000G7", "SELECT [BR_LabID] FROM [BR_Lab] WITH (NOLOCK) WHERE [BR_LabID] = @BR_LabID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000G7,1,0,true,false )
           ,new CursorDef("BC000G8", "INSERT INTO [BR_Lab]([BR_Lab_SpecimenSource_Code], [BR_Lab_ResultQual_Code], [BR_Lab_AbnInd_Code], [BR_Lab_SampleID], [BR_Lab_TestID], [BR_Lab_TestCode], [BR_Lab_TestName], [BR_Lab_TestEngName], [BR_Lab_Age], [BR_Lab_Diag], [BR_Lab_SpecimenDate], [BR_Lab_ReceivingTime], [BR_Lab_ReportTime], [BR_Lab_SpecimenSource], [BR_Lab_ResultQual], [BR_Lab_ResultNum], [BR_Lab_ResultUnit], [BR_Lab_AbnInd], [BR_Lab_NormRangeLow], [BR_Lab_NormRangeHigh], [BR_Lab_TestMethod], [BR_Lab_InstrumentName], [BR_Lab_InstrumentCode], [BR_SampleId], [BR_EncounterID]) VALUES(@BR_Lab_SpecimenSource_Code, @BR_Lab_ResultQual_Code, @BR_Lab_AbnInd_Code, @BR_Lab_SampleID, @BR_Lab_TestID, @BR_Lab_TestCode, @BR_Lab_TestName, @BR_Lab_TestEngName, @BR_Lab_Age, @BR_Lab_Diag, @BR_Lab_SpecimenDate, @BR_Lab_ReceivingTime, @BR_Lab_ReportTime, @BR_Lab_SpecimenSource, @BR_Lab_ResultQual, @BR_Lab_ResultNum, @BR_Lab_ResultUnit, @BR_Lab_AbnInd, @BR_Lab_NormRangeLow, @BR_Lab_NormRangeHigh, @BR_Lab_TestMethod, @BR_Lab_InstrumentName, @BR_Lab_InstrumentCode, @BR_SampleId, @BR_EncounterID); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmBC000G8)
           ,new CursorDef("BC000G9", "UPDATE [BR_Lab] SET [BR_Lab_SpecimenSource_Code]=@BR_Lab_SpecimenSource_Code, [BR_Lab_ResultQual_Code]=@BR_Lab_ResultQual_Code, [BR_Lab_AbnInd_Code]=@BR_Lab_AbnInd_Code, [BR_Lab_SampleID]=@BR_Lab_SampleID, [BR_Lab_TestID]=@BR_Lab_TestID, [BR_Lab_TestCode]=@BR_Lab_TestCode, [BR_Lab_TestName]=@BR_Lab_TestName, [BR_Lab_TestEngName]=@BR_Lab_TestEngName, [BR_Lab_Age]=@BR_Lab_Age, [BR_Lab_Diag]=@BR_Lab_Diag, [BR_Lab_SpecimenDate]=@BR_Lab_SpecimenDate, [BR_Lab_ReceivingTime]=@BR_Lab_ReceivingTime, [BR_Lab_ReportTime]=@BR_Lab_ReportTime, [BR_Lab_SpecimenSource]=@BR_Lab_SpecimenSource, [BR_Lab_ResultQual]=@BR_Lab_ResultQual, [BR_Lab_ResultNum]=@BR_Lab_ResultNum, [BR_Lab_ResultUnit]=@BR_Lab_ResultUnit, [BR_Lab_AbnInd]=@BR_Lab_AbnInd, [BR_Lab_NormRangeLow]=@BR_Lab_NormRangeLow, [BR_Lab_NormRangeHigh]=@BR_Lab_NormRangeHigh, [BR_Lab_TestMethod]=@BR_Lab_TestMethod, [BR_Lab_InstrumentName]=@BR_Lab_InstrumentName, [BR_Lab_InstrumentCode]=@BR_Lab_InstrumentCode, [BR_SampleId]=@BR_SampleId, [BR_EncounterID]=@BR_EncounterID  WHERE [BR_LabID] = @BR_LabID", GxErrorMask.GX_NOMASK,prmBC000G9)
           ,new CursorDef("BC000G10", "DELETE FROM [BR_Lab]  WHERE [BR_LabID] = @BR_LabID", GxErrorMask.GX_NOMASK,prmBC000G10)
           ,new CursorDef("BC000G11", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000G11,1,0,true,false )
           ,new CursorDef("BC000G12", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000G12,1,0,true,false )
           ,new CursorDef("BC000G13", "SELECT T2.[BR_Information_ID], TM1.[BR_LabID], TM1.[BR_Lab_SpecimenSource_Code], TM1.[BR_Lab_ResultQual_Code], TM1.[BR_Lab_AbnInd_Code], T3.[BR_Information_PatientNo], TM1.[BR_Lab_SampleID], TM1.[BR_Lab_TestID], TM1.[BR_Lab_TestCode], TM1.[BR_Lab_TestName], TM1.[BR_Lab_TestEngName], TM1.[BR_Lab_Age], TM1.[BR_Lab_Diag], TM1.[BR_Lab_SpecimenDate], TM1.[BR_Lab_ReceivingTime], TM1.[BR_Lab_ReportTime], TM1.[BR_Lab_SpecimenSource], TM1.[BR_Lab_ResultQual], TM1.[BR_Lab_ResultNum], TM1.[BR_Lab_ResultUnit], TM1.[BR_Lab_AbnInd], TM1.[BR_Lab_NormRangeLow], TM1.[BR_Lab_NormRangeHigh], TM1.[BR_Lab_TestMethod], TM1.[BR_Lab_InstrumentName], TM1.[BR_Lab_InstrumentCode], TM1.[BR_SampleId], TM1.[BR_EncounterID] FROM (([BR_Lab] TM1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = TM1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID]) WHERE TM1.[BR_LabID] = @BR_LabID ORDER BY TM1.[BR_LabID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000G13,100,0,true,false )
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
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((long[]) buf[9])[0] = rslt.getLong(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((short[]) buf[17])[0] = rslt.getShort(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              ((String[]) buf[19])[0] = rslt.getVarchar(11) ;
              ((bool[]) buf[20])[0] = rslt.wasNull(11);
              ((DateTime[]) buf[21])[0] = rslt.getGXDateTime(12) ;
              ((bool[]) buf[22])[0] = rslt.wasNull(12);
              ((DateTime[]) buf[23])[0] = rslt.getGXDateTime(13) ;
              ((bool[]) buf[24])[0] = rslt.wasNull(13);
              ((DateTime[]) buf[25])[0] = rslt.getGXDateTime(14) ;
              ((bool[]) buf[26])[0] = rslt.wasNull(14);
              ((String[]) buf[27])[0] = rslt.getVarchar(15) ;
              ((bool[]) buf[28])[0] = rslt.wasNull(15);
              ((String[]) buf[29])[0] = rslt.getVarchar(16) ;
              ((bool[]) buf[30])[0] = rslt.wasNull(16);
              ((String[]) buf[31])[0] = rslt.getVarchar(17) ;
              ((bool[]) buf[32])[0] = rslt.wasNull(17);
              ((String[]) buf[33])[0] = rslt.getVarchar(18) ;
              ((bool[]) buf[34])[0] = rslt.wasNull(18);
              ((String[]) buf[35])[0] = rslt.getVarchar(19) ;
              ((bool[]) buf[36])[0] = rslt.wasNull(19);
              ((String[]) buf[37])[0] = rslt.getVarchar(20) ;
              ((bool[]) buf[38])[0] = rslt.wasNull(20);
              ((String[]) buf[39])[0] = rslt.getVarchar(21) ;
              ((bool[]) buf[40])[0] = rslt.wasNull(21);
              ((String[]) buf[41])[0] = rslt.getVarchar(22) ;
              ((bool[]) buf[42])[0] = rslt.wasNull(22);
              ((String[]) buf[43])[0] = rslt.getVarchar(23) ;
              ((bool[]) buf[44])[0] = rslt.wasNull(23);
              ((String[]) buf[45])[0] = rslt.getVarchar(24) ;
              ((bool[]) buf[46])[0] = rslt.wasNull(24);
              ((long[]) buf[47])[0] = rslt.getLong(25) ;
              ((bool[]) buf[48])[0] = rslt.wasNull(25);
              ((long[]) buf[49])[0] = rslt.getLong(26) ;
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((long[]) buf[9])[0] = rslt.getLong(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((short[]) buf[17])[0] = rslt.getShort(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              ((String[]) buf[19])[0] = rslt.getVarchar(11) ;
              ((bool[]) buf[20])[0] = rslt.wasNull(11);
              ((DateTime[]) buf[21])[0] = rslt.getGXDateTime(12) ;
              ((bool[]) buf[22])[0] = rslt.wasNull(12);
              ((DateTime[]) buf[23])[0] = rslt.getGXDateTime(13) ;
              ((bool[]) buf[24])[0] = rslt.wasNull(13);
              ((DateTime[]) buf[25])[0] = rslt.getGXDateTime(14) ;
              ((bool[]) buf[26])[0] = rslt.wasNull(14);
              ((String[]) buf[27])[0] = rslt.getVarchar(15) ;
              ((bool[]) buf[28])[0] = rslt.wasNull(15);
              ((String[]) buf[29])[0] = rslt.getVarchar(16) ;
              ((bool[]) buf[30])[0] = rslt.wasNull(16);
              ((String[]) buf[31])[0] = rslt.getVarchar(17) ;
              ((bool[]) buf[32])[0] = rslt.wasNull(17);
              ((String[]) buf[33])[0] = rslt.getVarchar(18) ;
              ((bool[]) buf[34])[0] = rslt.wasNull(18);
              ((String[]) buf[35])[0] = rslt.getVarchar(19) ;
              ((bool[]) buf[36])[0] = rslt.wasNull(19);
              ((String[]) buf[37])[0] = rslt.getVarchar(20) ;
              ((bool[]) buf[38])[0] = rslt.wasNull(20);
              ((String[]) buf[39])[0] = rslt.getVarchar(21) ;
              ((bool[]) buf[40])[0] = rslt.wasNull(21);
              ((String[]) buf[41])[0] = rslt.getVarchar(22) ;
              ((bool[]) buf[42])[0] = rslt.wasNull(22);
              ((String[]) buf[43])[0] = rslt.getVarchar(23) ;
              ((bool[]) buf[44])[0] = rslt.wasNull(23);
              ((String[]) buf[45])[0] = rslt.getVarchar(24) ;
              ((bool[]) buf[46])[0] = rslt.wasNull(24);
              ((long[]) buf[47])[0] = rslt.getLong(25) ;
              ((bool[]) buf[48])[0] = rslt.wasNull(25);
              ((long[]) buf[49])[0] = rslt.getLong(26) ;
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
              ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((long[]) buf[13])[0] = rslt.getLong(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((String[]) buf[17])[0] = rslt.getVarchar(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              ((String[]) buf[19])[0] = rslt.getVarchar(11) ;
              ((bool[]) buf[20])[0] = rslt.wasNull(11);
              ((short[]) buf[21])[0] = rslt.getShort(12) ;
              ((bool[]) buf[22])[0] = rslt.wasNull(12);
              ((String[]) buf[23])[0] = rslt.getVarchar(13) ;
              ((bool[]) buf[24])[0] = rslt.wasNull(13);
              ((DateTime[]) buf[25])[0] = rslt.getGXDateTime(14) ;
              ((bool[]) buf[26])[0] = rslt.wasNull(14);
              ((DateTime[]) buf[27])[0] = rslt.getGXDateTime(15) ;
              ((bool[]) buf[28])[0] = rslt.wasNull(15);
              ((DateTime[]) buf[29])[0] = rslt.getGXDateTime(16) ;
              ((bool[]) buf[30])[0] = rslt.wasNull(16);
              ((String[]) buf[31])[0] = rslt.getVarchar(17) ;
              ((bool[]) buf[32])[0] = rslt.wasNull(17);
              ((String[]) buf[33])[0] = rslt.getVarchar(18) ;
              ((bool[]) buf[34])[0] = rslt.wasNull(18);
              ((String[]) buf[35])[0] = rslt.getVarchar(19) ;
              ((bool[]) buf[36])[0] = rslt.wasNull(19);
              ((String[]) buf[37])[0] = rslt.getVarchar(20) ;
              ((bool[]) buf[38])[0] = rslt.wasNull(20);
              ((String[]) buf[39])[0] = rslt.getVarchar(21) ;
              ((bool[]) buf[40])[0] = rslt.wasNull(21);
              ((String[]) buf[41])[0] = rslt.getVarchar(22) ;
              ((bool[]) buf[42])[0] = rslt.wasNull(22);
              ((String[]) buf[43])[0] = rslt.getVarchar(23) ;
              ((bool[]) buf[44])[0] = rslt.wasNull(23);
              ((String[]) buf[45])[0] = rslt.getVarchar(24) ;
              ((bool[]) buf[46])[0] = rslt.wasNull(24);
              ((String[]) buf[47])[0] = rslt.getVarchar(25) ;
              ((bool[]) buf[48])[0] = rslt.wasNull(25);
              ((String[]) buf[49])[0] = rslt.getVarchar(26) ;
              ((bool[]) buf[50])[0] = rslt.wasNull(26);
              ((long[]) buf[51])[0] = rslt.getLong(27) ;
              ((bool[]) buf[52])[0] = rslt.wasNull(27);
              ((long[]) buf[53])[0] = rslt.getLong(28) ;
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
              ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((long[]) buf[13])[0] = rslt.getLong(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((String[]) buf[17])[0] = rslt.getVarchar(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              ((String[]) buf[19])[0] = rslt.getVarchar(11) ;
              ((bool[]) buf[20])[0] = rslt.wasNull(11);
              ((short[]) buf[21])[0] = rslt.getShort(12) ;
              ((bool[]) buf[22])[0] = rslt.wasNull(12);
              ((String[]) buf[23])[0] = rslt.getVarchar(13) ;
              ((bool[]) buf[24])[0] = rslt.wasNull(13);
              ((DateTime[]) buf[25])[0] = rslt.getGXDateTime(14) ;
              ((bool[]) buf[26])[0] = rslt.wasNull(14);
              ((DateTime[]) buf[27])[0] = rslt.getGXDateTime(15) ;
              ((bool[]) buf[28])[0] = rslt.wasNull(15);
              ((DateTime[]) buf[29])[0] = rslt.getGXDateTime(16) ;
              ((bool[]) buf[30])[0] = rslt.wasNull(16);
              ((String[]) buf[31])[0] = rslt.getVarchar(17) ;
              ((bool[]) buf[32])[0] = rslt.wasNull(17);
              ((String[]) buf[33])[0] = rslt.getVarchar(18) ;
              ((bool[]) buf[34])[0] = rslt.wasNull(18);
              ((String[]) buf[35])[0] = rslt.getVarchar(19) ;
              ((bool[]) buf[36])[0] = rslt.wasNull(19);
              ((String[]) buf[37])[0] = rslt.getVarchar(20) ;
              ((bool[]) buf[38])[0] = rslt.wasNull(20);
              ((String[]) buf[39])[0] = rslt.getVarchar(21) ;
              ((bool[]) buf[40])[0] = rslt.wasNull(21);
              ((String[]) buf[41])[0] = rslt.getVarchar(22) ;
              ((bool[]) buf[42])[0] = rslt.wasNull(22);
              ((String[]) buf[43])[0] = rslt.getVarchar(23) ;
              ((bool[]) buf[44])[0] = rslt.wasNull(23);
              ((String[]) buf[45])[0] = rslt.getVarchar(24) ;
              ((bool[]) buf[46])[0] = rslt.wasNull(24);
              ((String[]) buf[47])[0] = rslt.getVarchar(25) ;
              ((bool[]) buf[48])[0] = rslt.wasNull(25);
              ((String[]) buf[49])[0] = rslt.getVarchar(26) ;
              ((bool[]) buf[50])[0] = rslt.wasNull(26);
              ((long[]) buf[51])[0] = rslt.getLong(27) ;
              ((bool[]) buf[52])[0] = rslt.wasNull(27);
              ((long[]) buf[53])[0] = rslt.getLong(28) ;
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
              if ( (bool)parms[6] )
              {
                 stmt.setNull( 4 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(4, (String)parms[7]);
              }
              if ( (bool)parms[8] )
              {
                 stmt.setNull( 5 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(5, (long)parms[9]);
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
                 stmt.setNull( 9 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(9, (short)parms[17]);
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
                 stmt.setNull( 11 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(11, (DateTime)parms[21]);
              }
              if ( (bool)parms[22] )
              {
                 stmt.setNull( 12 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(12, (DateTime)parms[23]);
              }
              if ( (bool)parms[24] )
              {
                 stmt.setNull( 13 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(13, (DateTime)parms[25]);
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
                 stmt.setNull( 15 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(15, (String)parms[29]);
              }
              if ( (bool)parms[30] )
              {
                 stmt.setNull( 16 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(16, (String)parms[31]);
              }
              if ( (bool)parms[32] )
              {
                 stmt.setNull( 17 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(17, (String)parms[33]);
              }
              if ( (bool)parms[34] )
              {
                 stmt.setNull( 18 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(18, (String)parms[35]);
              }
              if ( (bool)parms[36] )
              {
                 stmt.setNull( 19 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(19, (String)parms[37]);
              }
              if ( (bool)parms[38] )
              {
                 stmt.setNull( 20 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(20, (String)parms[39]);
              }
              if ( (bool)parms[40] )
              {
                 stmt.setNull( 21 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(21, (String)parms[41]);
              }
              if ( (bool)parms[42] )
              {
                 stmt.setNull( 22 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(22, (String)parms[43]);
              }
              if ( (bool)parms[44] )
              {
                 stmt.setNull( 23 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(23, (String)parms[45]);
              }
              if ( (bool)parms[46] )
              {
                 stmt.setNull( 24 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(24, (long)parms[47]);
              }
              stmt.SetParameter(25, (long)parms[48]);
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
                 stmt.setNull( 4 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(4, (String)parms[7]);
              }
              if ( (bool)parms[8] )
              {
                 stmt.setNull( 5 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(5, (long)parms[9]);
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
                 stmt.setNull( 9 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(9, (short)parms[17]);
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
                 stmt.setNull( 11 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(11, (DateTime)parms[21]);
              }
              if ( (bool)parms[22] )
              {
                 stmt.setNull( 12 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(12, (DateTime)parms[23]);
              }
              if ( (bool)parms[24] )
              {
                 stmt.setNull( 13 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(13, (DateTime)parms[25]);
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
                 stmt.setNull( 15 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(15, (String)parms[29]);
              }
              if ( (bool)parms[30] )
              {
                 stmt.setNull( 16 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(16, (String)parms[31]);
              }
              if ( (bool)parms[32] )
              {
                 stmt.setNull( 17 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(17, (String)parms[33]);
              }
              if ( (bool)parms[34] )
              {
                 stmt.setNull( 18 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(18, (String)parms[35]);
              }
              if ( (bool)parms[36] )
              {
                 stmt.setNull( 19 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(19, (String)parms[37]);
              }
              if ( (bool)parms[38] )
              {
                 stmt.setNull( 20 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(20, (String)parms[39]);
              }
              if ( (bool)parms[40] )
              {
                 stmt.setNull( 21 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(21, (String)parms[41]);
              }
              if ( (bool)parms[42] )
              {
                 stmt.setNull( 22 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(22, (String)parms[43]);
              }
              if ( (bool)parms[44] )
              {
                 stmt.setNull( 23 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(23, (String)parms[45]);
              }
              if ( (bool)parms[46] )
              {
                 stmt.setNull( 24 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(24, (long)parms[47]);
              }
              stmt.SetParameter(25, (long)parms[48]);
              stmt.SetParameter(26, (long)parms[49]);
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
