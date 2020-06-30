/*
               File: BR_MedicalImaging_BC
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:38:2.65
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
   public class br_medicalimaging_bc : GXHttpHandler, IGxSilentTrn
   {
      public br_medicalimaging_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_medicalimaging_bc( IGxContext context )
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
         ReadRow0T30( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey0T30( ) ;
         standaloneModal( ) ;
         AddRow0T30( ) ;
         Gx_mode = "INS";
         return  ;
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E110T2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               Z225BR_MedicalImagingID = A225BR_MedicalImagingID;
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

      protected void CONFIRM_0T0( )
      {
         BeforeValidate0T30( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0T30( ) ;
            }
            else
            {
               CheckExtendedTable0T30( ) ;
               if ( AnyError == 0 )
               {
                  ZM0T30( 17) ;
                  ZM0T30( 18) ;
               }
               CloseExtendedTableCursors0T30( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void E120T2( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV8WWPContext) ;
         AV9IsAuthorized = true;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_MedicalImaging", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_MedicalImaging", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_MedicalImaging", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
         }
         if ( ! AV9IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV19Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         /* Execute user subroutine: 'ATTRIBUTESSECURITYCODE' */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         AV11TrnContext.FromXml(AV12WebSession.Get("TrnContext"), null, "WWPTransactionContext", "DataAnalysisPlatform");
         if ( ( StringUtil.StrCmp(AV11TrnContext.gxTpr_Transactionname, AV19Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV20GXV1 = 1;
            while ( AV20GXV1 <= AV11TrnContext.gxTpr_Attributes.Count )
            {
               AV14TrnContextAtt = ((GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute)AV11TrnContext.gxTpr_Attributes.Item(AV20GXV1));
               if ( StringUtil.StrCmp(AV14TrnContextAtt.gxTpr_Attributename, "BR_EncounterID") == 0 )
               {
                  AV13Insert_BR_EncounterID = (long)(NumberUtil.Val( AV14TrnContextAtt.gxTpr_Attributevalue, "."));
               }
               AV20GXV1 = (int)(AV20GXV1+1);
            }
         }
      }

      protected void E110T2( )
      {
         /* After Trn Routine */
      }

      protected void S112( )
      {
         /* 'ATTRIBUTESSECURITYCODE' Routine */
      }

      protected void ZM0T30( short GX_JID )
      {
         if ( ( GX_JID == 16 ) || ( GX_JID == 0 ) )
         {
            Z484BR_MedicalImaging_ImageName_Code = A484BR_MedicalImaging_ImageName_Code;
            Z485BR_MedicalImaging_ImageHosp_Code = A485BR_MedicalImaging_ImageHosp_Code;
            Z227BR_MedicalImaging_ID = A227BR_MedicalImaging_ID;
            Z518BR_MedicalImaging_No = A518BR_MedicalImaging_No;
            Z228BR_MedicalImaging_ImageName = A228BR_MedicalImaging_ImageName;
            Z229BR_MedicalImaging_ImageDate = A229BR_MedicalImaging_ImageDate;
            Z230BR_MedicalImaging_ImageHosp = A230BR_MedicalImaging_ImageHosp;
            Z231BR_MedicalImaging_ImageAge = A231BR_MedicalImaging_ImageAge;
            Z232BR_MedicalImaging_ImageLoc = A232BR_MedicalImaging_ImageLoc;
            Z486BR_MedicalImaging_ImageLoc_Code = A486BR_MedicalImaging_ImageLoc_Code;
            Z233BR_MedicalImaging_ImageOrgan = A233BR_MedicalImaging_ImageOrgan;
            Z234BR_MedicalImaging_PreImageDiag = A234BR_MedicalImaging_PreImageDiag;
            Z235BR_MedicalImaging_ImageDes = A235BR_MedicalImaging_ImageDes;
            Z236BR_MedicalImaging_TumorSize = A236BR_MedicalImaging_TumorSize;
            Z514BR_MedicalImaging_MetastasesDX = A514BR_MedicalImaging_MetastasesDX;
            Z515BR_MedicalImaging_MetaLoc = A515BR_MedicalImaging_MetaLoc;
            Z516BR_MedicalImaging_MetaDate = A516BR_MedicalImaging_MetaDate;
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
            Z225BR_MedicalImagingID = A225BR_MedicalImagingID;
            Z484BR_MedicalImaging_ImageName_Code = A484BR_MedicalImaging_ImageName_Code;
            Z485BR_MedicalImaging_ImageHosp_Code = A485BR_MedicalImaging_ImageHosp_Code;
            Z227BR_MedicalImaging_ID = A227BR_MedicalImaging_ID;
            Z518BR_MedicalImaging_No = A518BR_MedicalImaging_No;
            Z228BR_MedicalImaging_ImageName = A228BR_MedicalImaging_ImageName;
            Z229BR_MedicalImaging_ImageDate = A229BR_MedicalImaging_ImageDate;
            Z230BR_MedicalImaging_ImageHosp = A230BR_MedicalImaging_ImageHosp;
            Z231BR_MedicalImaging_ImageAge = A231BR_MedicalImaging_ImageAge;
            Z232BR_MedicalImaging_ImageLoc = A232BR_MedicalImaging_ImageLoc;
            Z486BR_MedicalImaging_ImageLoc_Code = A486BR_MedicalImaging_ImageLoc_Code;
            Z233BR_MedicalImaging_ImageOrgan = A233BR_MedicalImaging_ImageOrgan;
            Z234BR_MedicalImaging_PreImageDiag = A234BR_MedicalImaging_PreImageDiag;
            Z235BR_MedicalImaging_ImageDes = A235BR_MedicalImaging_ImageDes;
            Z236BR_MedicalImaging_TumorSize = A236BR_MedicalImaging_TumorSize;
            Z334BR_MedicalImaging_ImageHtml = A334BR_MedicalImaging_ImageHtml;
            Z514BR_MedicalImaging_MetastasesDX = A514BR_MedicalImaging_MetastasesDX;
            Z515BR_MedicalImaging_MetaLoc = A515BR_MedicalImaging_MetaLoc;
            Z516BR_MedicalImaging_MetaDate = A516BR_MedicalImaging_MetaDate;
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

      protected void Load0T30( )
      {
         /* Using cursor BC000T6 */
         pr_default.execute(4, new Object[] {n225BR_MedicalImagingID, A225BR_MedicalImagingID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound30 = 1;
            A85BR_Information_ID = BC000T6_A85BR_Information_ID[0];
            n85BR_Information_ID = BC000T6_n85BR_Information_ID[0];
            A484BR_MedicalImaging_ImageName_Code = BC000T6_A484BR_MedicalImaging_ImageName_Code[0];
            n484BR_MedicalImaging_ImageName_Code = BC000T6_n484BR_MedicalImaging_ImageName_Code[0];
            A485BR_MedicalImaging_ImageHosp_Code = BC000T6_A485BR_MedicalImaging_ImageHosp_Code[0];
            n485BR_MedicalImaging_ImageHosp_Code = BC000T6_n485BR_MedicalImaging_ImageHosp_Code[0];
            A36BR_Information_PatientNo = BC000T6_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = BC000T6_n36BR_Information_PatientNo[0];
            A227BR_MedicalImaging_ID = BC000T6_A227BR_MedicalImaging_ID[0];
            n227BR_MedicalImaging_ID = BC000T6_n227BR_MedicalImaging_ID[0];
            A518BR_MedicalImaging_No = BC000T6_A518BR_MedicalImaging_No[0];
            n518BR_MedicalImaging_No = BC000T6_n518BR_MedicalImaging_No[0];
            A228BR_MedicalImaging_ImageName = BC000T6_A228BR_MedicalImaging_ImageName[0];
            n228BR_MedicalImaging_ImageName = BC000T6_n228BR_MedicalImaging_ImageName[0];
            A229BR_MedicalImaging_ImageDate = BC000T6_A229BR_MedicalImaging_ImageDate[0];
            n229BR_MedicalImaging_ImageDate = BC000T6_n229BR_MedicalImaging_ImageDate[0];
            A230BR_MedicalImaging_ImageHosp = BC000T6_A230BR_MedicalImaging_ImageHosp[0];
            n230BR_MedicalImaging_ImageHosp = BC000T6_n230BR_MedicalImaging_ImageHosp[0];
            A231BR_MedicalImaging_ImageAge = BC000T6_A231BR_MedicalImaging_ImageAge[0];
            n231BR_MedicalImaging_ImageAge = BC000T6_n231BR_MedicalImaging_ImageAge[0];
            A232BR_MedicalImaging_ImageLoc = BC000T6_A232BR_MedicalImaging_ImageLoc[0];
            n232BR_MedicalImaging_ImageLoc = BC000T6_n232BR_MedicalImaging_ImageLoc[0];
            A486BR_MedicalImaging_ImageLoc_Code = BC000T6_A486BR_MedicalImaging_ImageLoc_Code[0];
            n486BR_MedicalImaging_ImageLoc_Code = BC000T6_n486BR_MedicalImaging_ImageLoc_Code[0];
            A233BR_MedicalImaging_ImageOrgan = BC000T6_A233BR_MedicalImaging_ImageOrgan[0];
            n233BR_MedicalImaging_ImageOrgan = BC000T6_n233BR_MedicalImaging_ImageOrgan[0];
            A234BR_MedicalImaging_PreImageDiag = BC000T6_A234BR_MedicalImaging_PreImageDiag[0];
            n234BR_MedicalImaging_PreImageDiag = BC000T6_n234BR_MedicalImaging_PreImageDiag[0];
            A235BR_MedicalImaging_ImageDes = BC000T6_A235BR_MedicalImaging_ImageDes[0];
            n235BR_MedicalImaging_ImageDes = BC000T6_n235BR_MedicalImaging_ImageDes[0];
            A236BR_MedicalImaging_TumorSize = BC000T6_A236BR_MedicalImaging_TumorSize[0];
            n236BR_MedicalImaging_TumorSize = BC000T6_n236BR_MedicalImaging_TumorSize[0];
            A334BR_MedicalImaging_ImageHtml = BC000T6_A334BR_MedicalImaging_ImageHtml[0];
            n334BR_MedicalImaging_ImageHtml = BC000T6_n334BR_MedicalImaging_ImageHtml[0];
            A514BR_MedicalImaging_MetastasesDX = BC000T6_A514BR_MedicalImaging_MetastasesDX[0];
            n514BR_MedicalImaging_MetastasesDX = BC000T6_n514BR_MedicalImaging_MetastasesDX[0];
            A515BR_MedicalImaging_MetaLoc = BC000T6_A515BR_MedicalImaging_MetaLoc[0];
            n515BR_MedicalImaging_MetaLoc = BC000T6_n515BR_MedicalImaging_MetaLoc[0];
            A516BR_MedicalImaging_MetaDate = BC000T6_A516BR_MedicalImaging_MetaDate[0];
            n516BR_MedicalImaging_MetaDate = BC000T6_n516BR_MedicalImaging_MetaDate[0];
            A19BR_EncounterID = BC000T6_A19BR_EncounterID[0];
            n19BR_EncounterID = BC000T6_n19BR_EncounterID[0];
            ZM0T30( -16) ;
         }
         pr_default.close(4);
         OnLoadActions0T30( ) ;
      }

      protected void OnLoadActions0T30( )
      {
         AV19Pgmname = "BR_MedicalImaging_BC";
      }

      protected void CheckExtendedTable0T30( )
      {
         standaloneModal( ) ;
         AV19Pgmname = "BR_MedicalImaging_BC";
         /* Using cursor BC000T4 */
         pr_default.execute(2, new Object[] {n19BR_EncounterID, A19BR_EncounterID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            if ( ! ( (0==A19BR_EncounterID) ) )
            {
               GX_msglist.addItem("不匹配' T15'", "ForeignKeyNotFound", 1, "BR_ENCOUNTERID");
               AnyError = 1;
            }
         }
         A85BR_Information_ID = BC000T4_A85BR_Information_ID[0];
         n85BR_Information_ID = BC000T4_n85BR_Information_ID[0];
         pr_default.close(2);
         /* Using cursor BC000T5 */
         pr_default.execute(3, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
         if ( (pr_default.getStatus(3) == 101) )
         {
            if ( ! ( (0==A85BR_Information_ID) ) )
            {
               GX_msglist.addItem("不匹配' T16'", "ForeignKeyNotFound", 1, "");
               AnyError = 1;
            }
         }
         A36BR_Information_PatientNo = BC000T5_A36BR_Information_PatientNo[0];
         n36BR_Information_PatientNo = BC000T5_n36BR_Information_PatientNo[0];
         pr_default.close(3);
         if ( (0==A518BR_MedicalImaging_No) )
         {
            GX_msglist.addItem("编号是必须填写的。", 1, "");
            AnyError = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A228BR_MedicalImaging_ImageName)) )
         {
            GX_msglist.addItem("影像名称是必须填写的。", 1, "");
            AnyError = 1;
         }
         if ( ! ( (DateTime.MinValue==A229BR_MedicalImaging_ImageDate) || ( A229BR_MedicalImaging_ImageDate >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("域������������超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
         if ( (0==A231BR_MedicalImaging_ImageAge) )
         {
            GX_msglist.addItem("年龄是必须填写的。", 1, "");
            AnyError = 1;
         }
         if ( ! ( ( StringUtil.StrCmp(A514BR_MedicalImaging_MetastasesDX, "否") == 0 ) || ( StringUtil.StrCmp(A514BR_MedicalImaging_MetastasesDX, "是") == 0 ) || ( StringUtil.StrCmp(A514BR_MedicalImaging_MetastasesDX, "不详") == 0 ) || String.IsNullOrEmpty(StringUtil.RTrim( A514BR_MedicalImaging_MetastasesDX)) ) )
         {
            GX_msglist.addItem("域���������������������超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
         if ( ! ( (DateTime.MinValue==A516BR_MedicalImaging_MetaDate) || ( A516BR_MedicalImaging_MetaDate >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("域������������������超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
      }

      protected void CloseExtendedTableCursors0T30( )
      {
         pr_default.close(2);
         pr_default.close(3);
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0T30( )
      {
         /* Using cursor BC000T7 */
         pr_default.execute(5, new Object[] {n225BR_MedicalImagingID, A225BR_MedicalImagingID});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound30 = 1;
         }
         else
         {
            RcdFound30 = 0;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC000T3 */
         pr_default.execute(1, new Object[] {n225BR_MedicalImagingID, A225BR_MedicalImagingID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0T30( 16) ;
            RcdFound30 = 1;
            A225BR_MedicalImagingID = BC000T3_A225BR_MedicalImagingID[0];
            n225BR_MedicalImagingID = BC000T3_n225BR_MedicalImagingID[0];
            A484BR_MedicalImaging_ImageName_Code = BC000T3_A484BR_MedicalImaging_ImageName_Code[0];
            n484BR_MedicalImaging_ImageName_Code = BC000T3_n484BR_MedicalImaging_ImageName_Code[0];
            A485BR_MedicalImaging_ImageHosp_Code = BC000T3_A485BR_MedicalImaging_ImageHosp_Code[0];
            n485BR_MedicalImaging_ImageHosp_Code = BC000T3_n485BR_MedicalImaging_ImageHosp_Code[0];
            A227BR_MedicalImaging_ID = BC000T3_A227BR_MedicalImaging_ID[0];
            n227BR_MedicalImaging_ID = BC000T3_n227BR_MedicalImaging_ID[0];
            A518BR_MedicalImaging_No = BC000T3_A518BR_MedicalImaging_No[0];
            n518BR_MedicalImaging_No = BC000T3_n518BR_MedicalImaging_No[0];
            A228BR_MedicalImaging_ImageName = BC000T3_A228BR_MedicalImaging_ImageName[0];
            n228BR_MedicalImaging_ImageName = BC000T3_n228BR_MedicalImaging_ImageName[0];
            A229BR_MedicalImaging_ImageDate = BC000T3_A229BR_MedicalImaging_ImageDate[0];
            n229BR_MedicalImaging_ImageDate = BC000T3_n229BR_MedicalImaging_ImageDate[0];
            A230BR_MedicalImaging_ImageHosp = BC000T3_A230BR_MedicalImaging_ImageHosp[0];
            n230BR_MedicalImaging_ImageHosp = BC000T3_n230BR_MedicalImaging_ImageHosp[0];
            A231BR_MedicalImaging_ImageAge = BC000T3_A231BR_MedicalImaging_ImageAge[0];
            n231BR_MedicalImaging_ImageAge = BC000T3_n231BR_MedicalImaging_ImageAge[0];
            A232BR_MedicalImaging_ImageLoc = BC000T3_A232BR_MedicalImaging_ImageLoc[0];
            n232BR_MedicalImaging_ImageLoc = BC000T3_n232BR_MedicalImaging_ImageLoc[0];
            A486BR_MedicalImaging_ImageLoc_Code = BC000T3_A486BR_MedicalImaging_ImageLoc_Code[0];
            n486BR_MedicalImaging_ImageLoc_Code = BC000T3_n486BR_MedicalImaging_ImageLoc_Code[0];
            A233BR_MedicalImaging_ImageOrgan = BC000T3_A233BR_MedicalImaging_ImageOrgan[0];
            n233BR_MedicalImaging_ImageOrgan = BC000T3_n233BR_MedicalImaging_ImageOrgan[0];
            A234BR_MedicalImaging_PreImageDiag = BC000T3_A234BR_MedicalImaging_PreImageDiag[0];
            n234BR_MedicalImaging_PreImageDiag = BC000T3_n234BR_MedicalImaging_PreImageDiag[0];
            A235BR_MedicalImaging_ImageDes = BC000T3_A235BR_MedicalImaging_ImageDes[0];
            n235BR_MedicalImaging_ImageDes = BC000T3_n235BR_MedicalImaging_ImageDes[0];
            A236BR_MedicalImaging_TumorSize = BC000T3_A236BR_MedicalImaging_TumorSize[0];
            n236BR_MedicalImaging_TumorSize = BC000T3_n236BR_MedicalImaging_TumorSize[0];
            A334BR_MedicalImaging_ImageHtml = BC000T3_A334BR_MedicalImaging_ImageHtml[0];
            n334BR_MedicalImaging_ImageHtml = BC000T3_n334BR_MedicalImaging_ImageHtml[0];
            A514BR_MedicalImaging_MetastasesDX = BC000T3_A514BR_MedicalImaging_MetastasesDX[0];
            n514BR_MedicalImaging_MetastasesDX = BC000T3_n514BR_MedicalImaging_MetastasesDX[0];
            A515BR_MedicalImaging_MetaLoc = BC000T3_A515BR_MedicalImaging_MetaLoc[0];
            n515BR_MedicalImaging_MetaLoc = BC000T3_n515BR_MedicalImaging_MetaLoc[0];
            A516BR_MedicalImaging_MetaDate = BC000T3_A516BR_MedicalImaging_MetaDate[0];
            n516BR_MedicalImaging_MetaDate = BC000T3_n516BR_MedicalImaging_MetaDate[0];
            A19BR_EncounterID = BC000T3_A19BR_EncounterID[0];
            n19BR_EncounterID = BC000T3_n19BR_EncounterID[0];
            Z225BR_MedicalImagingID = A225BR_MedicalImagingID;
            sMode30 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load0T30( ) ;
            if ( AnyError == 1 )
            {
               RcdFound30 = 0;
               InitializeNonKey0T30( ) ;
            }
            Gx_mode = sMode30;
         }
         else
         {
            RcdFound30 = 0;
            InitializeNonKey0T30( ) ;
            sMode30 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode30;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0T30( ) ;
         if ( RcdFound30 == 0 )
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
         CONFIRM_0T0( ) ;
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

      protected void CheckOptimisticConcurrency0T30( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC000T2 */
            pr_default.execute(0, new Object[] {n225BR_MedicalImagingID, A225BR_MedicalImagingID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_MedicalImaging"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z484BR_MedicalImaging_ImageName_Code, BC000T2_A484BR_MedicalImaging_ImageName_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z485BR_MedicalImaging_ImageHosp_Code, BC000T2_A485BR_MedicalImaging_ImageHosp_Code[0]) != 0 ) || ( Z227BR_MedicalImaging_ID != BC000T2_A227BR_MedicalImaging_ID[0] ) || ( Z518BR_MedicalImaging_No != BC000T2_A518BR_MedicalImaging_No[0] ) || ( StringUtil.StrCmp(Z228BR_MedicalImaging_ImageName, BC000T2_A228BR_MedicalImaging_ImageName[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z229BR_MedicalImaging_ImageDate != BC000T2_A229BR_MedicalImaging_ImageDate[0] ) || ( StringUtil.StrCmp(Z230BR_MedicalImaging_ImageHosp, BC000T2_A230BR_MedicalImaging_ImageHosp[0]) != 0 ) || ( Z231BR_MedicalImaging_ImageAge != BC000T2_A231BR_MedicalImaging_ImageAge[0] ) || ( StringUtil.StrCmp(Z232BR_MedicalImaging_ImageLoc, BC000T2_A232BR_MedicalImaging_ImageLoc[0]) != 0 ) || ( StringUtil.StrCmp(Z486BR_MedicalImaging_ImageLoc_Code, BC000T2_A486BR_MedicalImaging_ImageLoc_Code[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z233BR_MedicalImaging_ImageOrgan, BC000T2_A233BR_MedicalImaging_ImageOrgan[0]) != 0 ) || ( StringUtil.StrCmp(Z234BR_MedicalImaging_PreImageDiag, BC000T2_A234BR_MedicalImaging_PreImageDiag[0]) != 0 ) || ( StringUtil.StrCmp(Z235BR_MedicalImaging_ImageDes, BC000T2_A235BR_MedicalImaging_ImageDes[0]) != 0 ) || ( StringUtil.StrCmp(Z236BR_MedicalImaging_TumorSize, BC000T2_A236BR_MedicalImaging_TumorSize[0]) != 0 ) || ( StringUtil.StrCmp(Z514BR_MedicalImaging_MetastasesDX, BC000T2_A514BR_MedicalImaging_MetastasesDX[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z515BR_MedicalImaging_MetaLoc, BC000T2_A515BR_MedicalImaging_MetaLoc[0]) != 0 ) || ( Z516BR_MedicalImaging_MetaDate != BC000T2_A516BR_MedicalImaging_MetaDate[0] ) || ( Z19BR_EncounterID != BC000T2_A19BR_EncounterID[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"BR_MedicalImaging"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0T30( )
      {
         BeforeValidate0T30( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0T30( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0T30( 0) ;
            CheckOptimisticConcurrency0T30( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0T30( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0T30( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000T8 */
                     pr_default.execute(6, new Object[] {n484BR_MedicalImaging_ImageName_Code, A484BR_MedicalImaging_ImageName_Code, n485BR_MedicalImaging_ImageHosp_Code, A485BR_MedicalImaging_ImageHosp_Code, n227BR_MedicalImaging_ID, A227BR_MedicalImaging_ID, n518BR_MedicalImaging_No, A518BR_MedicalImaging_No, n228BR_MedicalImaging_ImageName, A228BR_MedicalImaging_ImageName, n229BR_MedicalImaging_ImageDate, A229BR_MedicalImaging_ImageDate, n230BR_MedicalImaging_ImageHosp, A230BR_MedicalImaging_ImageHosp, n231BR_MedicalImaging_ImageAge, A231BR_MedicalImaging_ImageAge, n232BR_MedicalImaging_ImageLoc, A232BR_MedicalImaging_ImageLoc, n486BR_MedicalImaging_ImageLoc_Code, A486BR_MedicalImaging_ImageLoc_Code, n233BR_MedicalImaging_ImageOrgan, A233BR_MedicalImaging_ImageOrgan, n234BR_MedicalImaging_PreImageDiag, A234BR_MedicalImaging_PreImageDiag, n235BR_MedicalImaging_ImageDes, A235BR_MedicalImaging_ImageDes, n236BR_MedicalImaging_TumorSize, A236BR_MedicalImaging_TumorSize, n334BR_MedicalImaging_ImageHtml, A334BR_MedicalImaging_ImageHtml, n514BR_MedicalImaging_MetastasesDX, A514BR_MedicalImaging_MetastasesDX, n515BR_MedicalImaging_MetaLoc, A515BR_MedicalImaging_MetaLoc, n516BR_MedicalImaging_MetaDate, A516BR_MedicalImaging_MetaDate, n19BR_EncounterID, A19BR_EncounterID});
                     A225BR_MedicalImagingID = BC000T8_A225BR_MedicalImagingID[0];
                     n225BR_MedicalImagingID = BC000T8_n225BR_MedicalImagingID[0];
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_MedicalImaging") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(A225BR_MedicalImagingID), 18, 0)),  "影像学",  "Create",  1) ;
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
               Load0T30( ) ;
            }
            EndLevel0T30( ) ;
         }
         CloseExtendedTableCursors0T30( ) ;
      }

      protected void Update0T30( )
      {
         BeforeValidate0T30( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0T30( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0T30( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0T30( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0T30( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000T9 */
                     pr_default.execute(7, new Object[] {n484BR_MedicalImaging_ImageName_Code, A484BR_MedicalImaging_ImageName_Code, n485BR_MedicalImaging_ImageHosp_Code, A485BR_MedicalImaging_ImageHosp_Code, n227BR_MedicalImaging_ID, A227BR_MedicalImaging_ID, n518BR_MedicalImaging_No, A518BR_MedicalImaging_No, n228BR_MedicalImaging_ImageName, A228BR_MedicalImaging_ImageName, n229BR_MedicalImaging_ImageDate, A229BR_MedicalImaging_ImageDate, n230BR_MedicalImaging_ImageHosp, A230BR_MedicalImaging_ImageHosp, n231BR_MedicalImaging_ImageAge, A231BR_MedicalImaging_ImageAge, n232BR_MedicalImaging_ImageLoc, A232BR_MedicalImaging_ImageLoc, n486BR_MedicalImaging_ImageLoc_Code, A486BR_MedicalImaging_ImageLoc_Code, n233BR_MedicalImaging_ImageOrgan, A233BR_MedicalImaging_ImageOrgan, n234BR_MedicalImaging_PreImageDiag, A234BR_MedicalImaging_PreImageDiag, n235BR_MedicalImaging_ImageDes, A235BR_MedicalImaging_ImageDes, n236BR_MedicalImaging_TumorSize, A236BR_MedicalImaging_TumorSize, n334BR_MedicalImaging_ImageHtml, A334BR_MedicalImaging_ImageHtml, n514BR_MedicalImaging_MetastasesDX, A514BR_MedicalImaging_MetastasesDX, n515BR_MedicalImaging_MetaLoc, A515BR_MedicalImaging_MetaLoc, n516BR_MedicalImaging_MetaDate, A516BR_MedicalImaging_MetaDate, n19BR_EncounterID, A19BR_EncounterID, n225BR_MedicalImagingID, A225BR_MedicalImagingID});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_MedicalImaging") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_MedicalImaging"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0T30( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(A225BR_MedicalImagingID), 18, 0)),  "影像学",  "Update",  1) ;
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
            EndLevel0T30( ) ;
         }
         CloseExtendedTableCursors0T30( ) ;
      }

      protected void DeferredUpdate0T30( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate0T30( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0T30( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0T30( ) ;
            AfterConfirm0T30( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0T30( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC000T10 */
                  pr_default.execute(8, new Object[] {n225BR_MedicalImagingID, A225BR_MedicalImagingID});
                  pr_default.close(8);
                  dsDefault.SmartCacheProvider.SetUpdated("BR_MedicalImaging") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(A225BR_MedicalImagingID), 18, 0)),  "影像学",  "Delete",  1) ;
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
         sMode30 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel0T30( ) ;
         Gx_mode = sMode30;
      }

      protected void OnDeleteControls0T30( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV19Pgmname = "BR_MedicalImaging_BC";
            /* Using cursor BC000T11 */
            pr_default.execute(9, new Object[] {n19BR_EncounterID, A19BR_EncounterID});
            A85BR_Information_ID = BC000T11_A85BR_Information_ID[0];
            n85BR_Information_ID = BC000T11_n85BR_Information_ID[0];
            pr_default.close(9);
            /* Using cursor BC000T12 */
            pr_default.execute(10, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
            A36BR_Information_PatientNo = BC000T12_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = BC000T12_n36BR_Information_PatientNo[0];
            pr_default.close(10);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor BC000T13 */
            pr_default.execute(11, new Object[] {n225BR_MedicalImagingID, A225BR_MedicalImagingID});
            if ( (pr_default.getStatus(11) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {" T29"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(11);
         }
      }

      protected void EndLevel0T30( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0T30( ) ;
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

      public void ScanKeyStart0T30( )
      {
         /* Scan By routine */
         /* Using cursor BC000T14 */
         pr_default.execute(12, new Object[] {n225BR_MedicalImagingID, A225BR_MedicalImagingID});
         RcdFound30 = 0;
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound30 = 1;
            A85BR_Information_ID = BC000T14_A85BR_Information_ID[0];
            n85BR_Information_ID = BC000T14_n85BR_Information_ID[0];
            A225BR_MedicalImagingID = BC000T14_A225BR_MedicalImagingID[0];
            n225BR_MedicalImagingID = BC000T14_n225BR_MedicalImagingID[0];
            A484BR_MedicalImaging_ImageName_Code = BC000T14_A484BR_MedicalImaging_ImageName_Code[0];
            n484BR_MedicalImaging_ImageName_Code = BC000T14_n484BR_MedicalImaging_ImageName_Code[0];
            A485BR_MedicalImaging_ImageHosp_Code = BC000T14_A485BR_MedicalImaging_ImageHosp_Code[0];
            n485BR_MedicalImaging_ImageHosp_Code = BC000T14_n485BR_MedicalImaging_ImageHosp_Code[0];
            A36BR_Information_PatientNo = BC000T14_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = BC000T14_n36BR_Information_PatientNo[0];
            A227BR_MedicalImaging_ID = BC000T14_A227BR_MedicalImaging_ID[0];
            n227BR_MedicalImaging_ID = BC000T14_n227BR_MedicalImaging_ID[0];
            A518BR_MedicalImaging_No = BC000T14_A518BR_MedicalImaging_No[0];
            n518BR_MedicalImaging_No = BC000T14_n518BR_MedicalImaging_No[0];
            A228BR_MedicalImaging_ImageName = BC000T14_A228BR_MedicalImaging_ImageName[0];
            n228BR_MedicalImaging_ImageName = BC000T14_n228BR_MedicalImaging_ImageName[0];
            A229BR_MedicalImaging_ImageDate = BC000T14_A229BR_MedicalImaging_ImageDate[0];
            n229BR_MedicalImaging_ImageDate = BC000T14_n229BR_MedicalImaging_ImageDate[0];
            A230BR_MedicalImaging_ImageHosp = BC000T14_A230BR_MedicalImaging_ImageHosp[0];
            n230BR_MedicalImaging_ImageHosp = BC000T14_n230BR_MedicalImaging_ImageHosp[0];
            A231BR_MedicalImaging_ImageAge = BC000T14_A231BR_MedicalImaging_ImageAge[0];
            n231BR_MedicalImaging_ImageAge = BC000T14_n231BR_MedicalImaging_ImageAge[0];
            A232BR_MedicalImaging_ImageLoc = BC000T14_A232BR_MedicalImaging_ImageLoc[0];
            n232BR_MedicalImaging_ImageLoc = BC000T14_n232BR_MedicalImaging_ImageLoc[0];
            A486BR_MedicalImaging_ImageLoc_Code = BC000T14_A486BR_MedicalImaging_ImageLoc_Code[0];
            n486BR_MedicalImaging_ImageLoc_Code = BC000T14_n486BR_MedicalImaging_ImageLoc_Code[0];
            A233BR_MedicalImaging_ImageOrgan = BC000T14_A233BR_MedicalImaging_ImageOrgan[0];
            n233BR_MedicalImaging_ImageOrgan = BC000T14_n233BR_MedicalImaging_ImageOrgan[0];
            A234BR_MedicalImaging_PreImageDiag = BC000T14_A234BR_MedicalImaging_PreImageDiag[0];
            n234BR_MedicalImaging_PreImageDiag = BC000T14_n234BR_MedicalImaging_PreImageDiag[0];
            A235BR_MedicalImaging_ImageDes = BC000T14_A235BR_MedicalImaging_ImageDes[0];
            n235BR_MedicalImaging_ImageDes = BC000T14_n235BR_MedicalImaging_ImageDes[0];
            A236BR_MedicalImaging_TumorSize = BC000T14_A236BR_MedicalImaging_TumorSize[0];
            n236BR_MedicalImaging_TumorSize = BC000T14_n236BR_MedicalImaging_TumorSize[0];
            A334BR_MedicalImaging_ImageHtml = BC000T14_A334BR_MedicalImaging_ImageHtml[0];
            n334BR_MedicalImaging_ImageHtml = BC000T14_n334BR_MedicalImaging_ImageHtml[0];
            A514BR_MedicalImaging_MetastasesDX = BC000T14_A514BR_MedicalImaging_MetastasesDX[0];
            n514BR_MedicalImaging_MetastasesDX = BC000T14_n514BR_MedicalImaging_MetastasesDX[0];
            A515BR_MedicalImaging_MetaLoc = BC000T14_A515BR_MedicalImaging_MetaLoc[0];
            n515BR_MedicalImaging_MetaLoc = BC000T14_n515BR_MedicalImaging_MetaLoc[0];
            A516BR_MedicalImaging_MetaDate = BC000T14_A516BR_MedicalImaging_MetaDate[0];
            n516BR_MedicalImaging_MetaDate = BC000T14_n516BR_MedicalImaging_MetaDate[0];
            A19BR_EncounterID = BC000T14_A19BR_EncounterID[0];
            n19BR_EncounterID = BC000T14_n19BR_EncounterID[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext0T30( )
      {
         /* Scan next routine */
         pr_default.readNext(12);
         RcdFound30 = 0;
         ScanKeyLoad0T30( ) ;
      }

      protected void ScanKeyLoad0T30( )
      {
         sMode30 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound30 = 1;
            A85BR_Information_ID = BC000T14_A85BR_Information_ID[0];
            n85BR_Information_ID = BC000T14_n85BR_Information_ID[0];
            A225BR_MedicalImagingID = BC000T14_A225BR_MedicalImagingID[0];
            n225BR_MedicalImagingID = BC000T14_n225BR_MedicalImagingID[0];
            A484BR_MedicalImaging_ImageName_Code = BC000T14_A484BR_MedicalImaging_ImageName_Code[0];
            n484BR_MedicalImaging_ImageName_Code = BC000T14_n484BR_MedicalImaging_ImageName_Code[0];
            A485BR_MedicalImaging_ImageHosp_Code = BC000T14_A485BR_MedicalImaging_ImageHosp_Code[0];
            n485BR_MedicalImaging_ImageHosp_Code = BC000T14_n485BR_MedicalImaging_ImageHosp_Code[0];
            A36BR_Information_PatientNo = BC000T14_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = BC000T14_n36BR_Information_PatientNo[0];
            A227BR_MedicalImaging_ID = BC000T14_A227BR_MedicalImaging_ID[0];
            n227BR_MedicalImaging_ID = BC000T14_n227BR_MedicalImaging_ID[0];
            A518BR_MedicalImaging_No = BC000T14_A518BR_MedicalImaging_No[0];
            n518BR_MedicalImaging_No = BC000T14_n518BR_MedicalImaging_No[0];
            A228BR_MedicalImaging_ImageName = BC000T14_A228BR_MedicalImaging_ImageName[0];
            n228BR_MedicalImaging_ImageName = BC000T14_n228BR_MedicalImaging_ImageName[0];
            A229BR_MedicalImaging_ImageDate = BC000T14_A229BR_MedicalImaging_ImageDate[0];
            n229BR_MedicalImaging_ImageDate = BC000T14_n229BR_MedicalImaging_ImageDate[0];
            A230BR_MedicalImaging_ImageHosp = BC000T14_A230BR_MedicalImaging_ImageHosp[0];
            n230BR_MedicalImaging_ImageHosp = BC000T14_n230BR_MedicalImaging_ImageHosp[0];
            A231BR_MedicalImaging_ImageAge = BC000T14_A231BR_MedicalImaging_ImageAge[0];
            n231BR_MedicalImaging_ImageAge = BC000T14_n231BR_MedicalImaging_ImageAge[0];
            A232BR_MedicalImaging_ImageLoc = BC000T14_A232BR_MedicalImaging_ImageLoc[0];
            n232BR_MedicalImaging_ImageLoc = BC000T14_n232BR_MedicalImaging_ImageLoc[0];
            A486BR_MedicalImaging_ImageLoc_Code = BC000T14_A486BR_MedicalImaging_ImageLoc_Code[0];
            n486BR_MedicalImaging_ImageLoc_Code = BC000T14_n486BR_MedicalImaging_ImageLoc_Code[0];
            A233BR_MedicalImaging_ImageOrgan = BC000T14_A233BR_MedicalImaging_ImageOrgan[0];
            n233BR_MedicalImaging_ImageOrgan = BC000T14_n233BR_MedicalImaging_ImageOrgan[0];
            A234BR_MedicalImaging_PreImageDiag = BC000T14_A234BR_MedicalImaging_PreImageDiag[0];
            n234BR_MedicalImaging_PreImageDiag = BC000T14_n234BR_MedicalImaging_PreImageDiag[0];
            A235BR_MedicalImaging_ImageDes = BC000T14_A235BR_MedicalImaging_ImageDes[0];
            n235BR_MedicalImaging_ImageDes = BC000T14_n235BR_MedicalImaging_ImageDes[0];
            A236BR_MedicalImaging_TumorSize = BC000T14_A236BR_MedicalImaging_TumorSize[0];
            n236BR_MedicalImaging_TumorSize = BC000T14_n236BR_MedicalImaging_TumorSize[0];
            A334BR_MedicalImaging_ImageHtml = BC000T14_A334BR_MedicalImaging_ImageHtml[0];
            n334BR_MedicalImaging_ImageHtml = BC000T14_n334BR_MedicalImaging_ImageHtml[0];
            A514BR_MedicalImaging_MetastasesDX = BC000T14_A514BR_MedicalImaging_MetastasesDX[0];
            n514BR_MedicalImaging_MetastasesDX = BC000T14_n514BR_MedicalImaging_MetastasesDX[0];
            A515BR_MedicalImaging_MetaLoc = BC000T14_A515BR_MedicalImaging_MetaLoc[0];
            n515BR_MedicalImaging_MetaLoc = BC000T14_n515BR_MedicalImaging_MetaLoc[0];
            A516BR_MedicalImaging_MetaDate = BC000T14_A516BR_MedicalImaging_MetaDate[0];
            n516BR_MedicalImaging_MetaDate = BC000T14_n516BR_MedicalImaging_MetaDate[0];
            A19BR_EncounterID = BC000T14_A19BR_EncounterID[0];
            n19BR_EncounterID = BC000T14_n19BR_EncounterID[0];
         }
         Gx_mode = sMode30;
      }

      protected void ScanKeyEnd0T30( )
      {
         pr_default.close(12);
      }

      protected void AfterConfirm0T30( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0T30( )
      {
         /* Before Insert Rules */
         GXt_char2 = A484BR_MedicalImaging_ImageName_Code;
         new zutil_findtargetcode(context ).execute(  30,  A228BR_MedicalImaging_ImageName, out  GXt_char2) ;
         A484BR_MedicalImaging_ImageName_Code = GXt_char2;
         n484BR_MedicalImaging_ImageName_Code = false;
         GXt_char2 = A485BR_MedicalImaging_ImageHosp_Code;
         new zutil_findtargetcode(context ).execute(  31,  A230BR_MedicalImaging_ImageHosp, out  GXt_char2) ;
         A485BR_MedicalImaging_ImageHosp_Code = GXt_char2;
         n485BR_MedicalImaging_ImageHosp_Code = false;
      }

      protected void BeforeUpdate0T30( )
      {
         /* Before Update Rules */
         GXt_char2 = A484BR_MedicalImaging_ImageName_Code;
         new zutil_findtargetcode(context ).execute(  30,  A228BR_MedicalImaging_ImageName, out  GXt_char2) ;
         A484BR_MedicalImaging_ImageName_Code = GXt_char2;
         n484BR_MedicalImaging_ImageName_Code = false;
         GXt_char2 = A485BR_MedicalImaging_ImageHosp_Code;
         new zutil_findtargetcode(context ).execute(  31,  A230BR_MedicalImaging_ImageHosp, out  GXt_char2) ;
         A485BR_MedicalImaging_ImageHosp_Code = GXt_char2;
         n485BR_MedicalImaging_ImageHosp_Code = false;
      }

      protected void BeforeDelete0T30( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0T30( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0T30( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0T30( )
      {
      }

      protected void send_integrity_lvl_hashes0T30( )
      {
      }

      protected void AddRow0T30( )
      {
         VarsToRow30( bcBR_MedicalImaging) ;
      }

      protected void ReadRow0T30( )
      {
         RowToVars30( bcBR_MedicalImaging, 1) ;
      }

      protected void InitializeNonKey0T30( )
      {
         A85BR_Information_ID = 0;
         n85BR_Information_ID = false;
         A484BR_MedicalImaging_ImageName_Code = "";
         n484BR_MedicalImaging_ImageName_Code = false;
         A485BR_MedicalImaging_ImageHosp_Code = "";
         n485BR_MedicalImaging_ImageHosp_Code = false;
         A19BR_EncounterID = 0;
         n19BR_EncounterID = false;
         A36BR_Information_PatientNo = "";
         n36BR_Information_PatientNo = false;
         A227BR_MedicalImaging_ID = 0;
         n227BR_MedicalImaging_ID = false;
         A518BR_MedicalImaging_No = 0;
         n518BR_MedicalImaging_No = false;
         A228BR_MedicalImaging_ImageName = "";
         n228BR_MedicalImaging_ImageName = false;
         A229BR_MedicalImaging_ImageDate = DateTime.MinValue;
         n229BR_MedicalImaging_ImageDate = false;
         A230BR_MedicalImaging_ImageHosp = "";
         n230BR_MedicalImaging_ImageHosp = false;
         A231BR_MedicalImaging_ImageAge = 0;
         n231BR_MedicalImaging_ImageAge = false;
         A232BR_MedicalImaging_ImageLoc = "";
         n232BR_MedicalImaging_ImageLoc = false;
         A486BR_MedicalImaging_ImageLoc_Code = "";
         n486BR_MedicalImaging_ImageLoc_Code = false;
         A233BR_MedicalImaging_ImageOrgan = "";
         n233BR_MedicalImaging_ImageOrgan = false;
         A234BR_MedicalImaging_PreImageDiag = "";
         n234BR_MedicalImaging_PreImageDiag = false;
         A235BR_MedicalImaging_ImageDes = "";
         n235BR_MedicalImaging_ImageDes = false;
         A236BR_MedicalImaging_TumorSize = "";
         n236BR_MedicalImaging_TumorSize = false;
         A334BR_MedicalImaging_ImageHtml = "";
         n334BR_MedicalImaging_ImageHtml = false;
         A514BR_MedicalImaging_MetastasesDX = "";
         n514BR_MedicalImaging_MetastasesDX = false;
         A515BR_MedicalImaging_MetaLoc = "";
         n515BR_MedicalImaging_MetaLoc = false;
         A516BR_MedicalImaging_MetaDate = DateTime.MinValue;
         n516BR_MedicalImaging_MetaDate = false;
         Z484BR_MedicalImaging_ImageName_Code = "";
         Z485BR_MedicalImaging_ImageHosp_Code = "";
         Z227BR_MedicalImaging_ID = 0;
         Z518BR_MedicalImaging_No = 0;
         Z228BR_MedicalImaging_ImageName = "";
         Z229BR_MedicalImaging_ImageDate = DateTime.MinValue;
         Z230BR_MedicalImaging_ImageHosp = "";
         Z231BR_MedicalImaging_ImageAge = 0;
         Z232BR_MedicalImaging_ImageLoc = "";
         Z486BR_MedicalImaging_ImageLoc_Code = "";
         Z233BR_MedicalImaging_ImageOrgan = "";
         Z234BR_MedicalImaging_PreImageDiag = "";
         Z235BR_MedicalImaging_ImageDes = "";
         Z236BR_MedicalImaging_TumorSize = "";
         Z514BR_MedicalImaging_MetastasesDX = "";
         Z515BR_MedicalImaging_MetaLoc = "";
         Z516BR_MedicalImaging_MetaDate = DateTime.MinValue;
         Z19BR_EncounterID = 0;
      }

      protected void InitAll0T30( )
      {
         A225BR_MedicalImagingID = 0;
         n225BR_MedicalImagingID = false;
         InitializeNonKey0T30( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow30( SdtBR_MedicalImaging obj30 )
      {
         obj30.gxTpr_Mode = Gx_mode;
         obj30.gxTpr_Br_medicalimaging_imagename_code = A484BR_MedicalImaging_ImageName_Code;
         obj30.gxTpr_Br_medicalimaging_imagehosp_code = A485BR_MedicalImaging_ImageHosp_Code;
         obj30.gxTpr_Br_encounterid = A19BR_EncounterID;
         obj30.gxTpr_Br_information_patientno = A36BR_Information_PatientNo;
         obj30.gxTpr_Br_medicalimaging_id = A227BR_MedicalImaging_ID;
         obj30.gxTpr_Br_medicalimaging_no = A518BR_MedicalImaging_No;
         obj30.gxTpr_Br_medicalimaging_imagename = A228BR_MedicalImaging_ImageName;
         obj30.gxTpr_Br_medicalimaging_imagedate = A229BR_MedicalImaging_ImageDate;
         obj30.gxTpr_Br_medicalimaging_imagehosp = A230BR_MedicalImaging_ImageHosp;
         obj30.gxTpr_Br_medicalimaging_imageage = A231BR_MedicalImaging_ImageAge;
         obj30.gxTpr_Br_medicalimaging_imageloc = A232BR_MedicalImaging_ImageLoc;
         obj30.gxTpr_Br_medicalimaging_imageloc_code = A486BR_MedicalImaging_ImageLoc_Code;
         obj30.gxTpr_Br_medicalimaging_imageorgan = A233BR_MedicalImaging_ImageOrgan;
         obj30.gxTpr_Br_medicalimaging_preimagediag = A234BR_MedicalImaging_PreImageDiag;
         obj30.gxTpr_Br_medicalimaging_imagedes = A235BR_MedicalImaging_ImageDes;
         obj30.gxTpr_Br_medicalimaging_tumorsize = A236BR_MedicalImaging_TumorSize;
         obj30.gxTpr_Br_medicalimaging_imagehtml = A334BR_MedicalImaging_ImageHtml;
         obj30.gxTpr_Br_medicalimaging_metastasesdx = A514BR_MedicalImaging_MetastasesDX;
         obj30.gxTpr_Br_medicalimaging_metaloc = A515BR_MedicalImaging_MetaLoc;
         obj30.gxTpr_Br_medicalimaging_metadate = A516BR_MedicalImaging_MetaDate;
         obj30.gxTpr_Br_medicalimagingid = A225BR_MedicalImagingID;
         obj30.gxTpr_Br_medicalimagingid_Z = Z225BR_MedicalImagingID;
         obj30.gxTpr_Br_encounterid_Z = Z19BR_EncounterID;
         obj30.gxTpr_Br_information_patientno_Z = Z36BR_Information_PatientNo;
         obj30.gxTpr_Br_medicalimaging_id_Z = Z227BR_MedicalImaging_ID;
         obj30.gxTpr_Br_medicalimaging_no_Z = Z518BR_MedicalImaging_No;
         obj30.gxTpr_Br_medicalimaging_imagename_Z = Z228BR_MedicalImaging_ImageName;
         obj30.gxTpr_Br_medicalimaging_imagename_code_Z = Z484BR_MedicalImaging_ImageName_Code;
         obj30.gxTpr_Br_medicalimaging_imagedate_Z = Z229BR_MedicalImaging_ImageDate;
         obj30.gxTpr_Br_medicalimaging_imagehosp_Z = Z230BR_MedicalImaging_ImageHosp;
         obj30.gxTpr_Br_medicalimaging_imagehosp_code_Z = Z485BR_MedicalImaging_ImageHosp_Code;
         obj30.gxTpr_Br_medicalimaging_imageage_Z = Z231BR_MedicalImaging_ImageAge;
         obj30.gxTpr_Br_medicalimaging_imageloc_Z = Z232BR_MedicalImaging_ImageLoc;
         obj30.gxTpr_Br_medicalimaging_imageloc_code_Z = Z486BR_MedicalImaging_ImageLoc_Code;
         obj30.gxTpr_Br_medicalimaging_imageorgan_Z = Z233BR_MedicalImaging_ImageOrgan;
         obj30.gxTpr_Br_medicalimaging_preimagediag_Z = Z234BR_MedicalImaging_PreImageDiag;
         obj30.gxTpr_Br_medicalimaging_imagedes_Z = Z235BR_MedicalImaging_ImageDes;
         obj30.gxTpr_Br_medicalimaging_tumorsize_Z = Z236BR_MedicalImaging_TumorSize;
         obj30.gxTpr_Br_medicalimaging_metastasesdx_Z = Z514BR_MedicalImaging_MetastasesDX;
         obj30.gxTpr_Br_medicalimaging_metaloc_Z = Z515BR_MedicalImaging_MetaLoc;
         obj30.gxTpr_Br_medicalimaging_metadate_Z = Z516BR_MedicalImaging_MetaDate;
         obj30.gxTpr_Br_medicalimagingid_N = (short)(Convert.ToInt16(n225BR_MedicalImagingID));
         obj30.gxTpr_Br_encounterid_N = (short)(Convert.ToInt16(n19BR_EncounterID));
         obj30.gxTpr_Br_information_patientno_N = (short)(Convert.ToInt16(n36BR_Information_PatientNo));
         obj30.gxTpr_Br_medicalimaging_id_N = (short)(Convert.ToInt16(n227BR_MedicalImaging_ID));
         obj30.gxTpr_Br_medicalimaging_no_N = (short)(Convert.ToInt16(n518BR_MedicalImaging_No));
         obj30.gxTpr_Br_medicalimaging_imagename_N = (short)(Convert.ToInt16(n228BR_MedicalImaging_ImageName));
         obj30.gxTpr_Br_medicalimaging_imagename_code_N = (short)(Convert.ToInt16(n484BR_MedicalImaging_ImageName_Code));
         obj30.gxTpr_Br_medicalimaging_imagedate_N = (short)(Convert.ToInt16(n229BR_MedicalImaging_ImageDate));
         obj30.gxTpr_Br_medicalimaging_imagehosp_N = (short)(Convert.ToInt16(n230BR_MedicalImaging_ImageHosp));
         obj30.gxTpr_Br_medicalimaging_imagehosp_code_N = (short)(Convert.ToInt16(n485BR_MedicalImaging_ImageHosp_Code));
         obj30.gxTpr_Br_medicalimaging_imageage_N = (short)(Convert.ToInt16(n231BR_MedicalImaging_ImageAge));
         obj30.gxTpr_Br_medicalimaging_imageloc_N = (short)(Convert.ToInt16(n232BR_MedicalImaging_ImageLoc));
         obj30.gxTpr_Br_medicalimaging_imageloc_code_N = (short)(Convert.ToInt16(n486BR_MedicalImaging_ImageLoc_Code));
         obj30.gxTpr_Br_medicalimaging_imageorgan_N = (short)(Convert.ToInt16(n233BR_MedicalImaging_ImageOrgan));
         obj30.gxTpr_Br_medicalimaging_preimagediag_N = (short)(Convert.ToInt16(n234BR_MedicalImaging_PreImageDiag));
         obj30.gxTpr_Br_medicalimaging_imagedes_N = (short)(Convert.ToInt16(n235BR_MedicalImaging_ImageDes));
         obj30.gxTpr_Br_medicalimaging_tumorsize_N = (short)(Convert.ToInt16(n236BR_MedicalImaging_TumorSize));
         obj30.gxTpr_Br_medicalimaging_imagehtml_N = (short)(Convert.ToInt16(n334BR_MedicalImaging_ImageHtml));
         obj30.gxTpr_Br_medicalimaging_metastasesdx_N = (short)(Convert.ToInt16(n514BR_MedicalImaging_MetastasesDX));
         obj30.gxTpr_Br_medicalimaging_metaloc_N = (short)(Convert.ToInt16(n515BR_MedicalImaging_MetaLoc));
         obj30.gxTpr_Br_medicalimaging_metadate_N = (short)(Convert.ToInt16(n516BR_MedicalImaging_MetaDate));
         obj30.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow30( SdtBR_MedicalImaging obj30 )
      {
         obj30.gxTpr_Br_medicalimagingid = A225BR_MedicalImagingID;
         return  ;
      }

      public void RowToVars30( SdtBR_MedicalImaging obj30 ,
                               int forceLoad )
      {
         Gx_mode = obj30.gxTpr_Mode;
         A484BR_MedicalImaging_ImageName_Code = obj30.gxTpr_Br_medicalimaging_imagename_code;
         n484BR_MedicalImaging_ImageName_Code = false;
         A485BR_MedicalImaging_ImageHosp_Code = obj30.gxTpr_Br_medicalimaging_imagehosp_code;
         n485BR_MedicalImaging_ImageHosp_Code = false;
         A19BR_EncounterID = obj30.gxTpr_Br_encounterid;
         n19BR_EncounterID = false;
         A36BR_Information_PatientNo = obj30.gxTpr_Br_information_patientno;
         n36BR_Information_PatientNo = false;
         A227BR_MedicalImaging_ID = obj30.gxTpr_Br_medicalimaging_id;
         n227BR_MedicalImaging_ID = false;
         A518BR_MedicalImaging_No = obj30.gxTpr_Br_medicalimaging_no;
         n518BR_MedicalImaging_No = false;
         A228BR_MedicalImaging_ImageName = obj30.gxTpr_Br_medicalimaging_imagename;
         n228BR_MedicalImaging_ImageName = false;
         A229BR_MedicalImaging_ImageDate = obj30.gxTpr_Br_medicalimaging_imagedate;
         n229BR_MedicalImaging_ImageDate = false;
         A230BR_MedicalImaging_ImageHosp = obj30.gxTpr_Br_medicalimaging_imagehosp;
         n230BR_MedicalImaging_ImageHosp = false;
         A231BR_MedicalImaging_ImageAge = obj30.gxTpr_Br_medicalimaging_imageage;
         n231BR_MedicalImaging_ImageAge = false;
         A232BR_MedicalImaging_ImageLoc = obj30.gxTpr_Br_medicalimaging_imageloc;
         n232BR_MedicalImaging_ImageLoc = false;
         A486BR_MedicalImaging_ImageLoc_Code = obj30.gxTpr_Br_medicalimaging_imageloc_code;
         n486BR_MedicalImaging_ImageLoc_Code = false;
         A233BR_MedicalImaging_ImageOrgan = obj30.gxTpr_Br_medicalimaging_imageorgan;
         n233BR_MedicalImaging_ImageOrgan = false;
         A234BR_MedicalImaging_PreImageDiag = obj30.gxTpr_Br_medicalimaging_preimagediag;
         n234BR_MedicalImaging_PreImageDiag = false;
         A235BR_MedicalImaging_ImageDes = obj30.gxTpr_Br_medicalimaging_imagedes;
         n235BR_MedicalImaging_ImageDes = false;
         A236BR_MedicalImaging_TumorSize = obj30.gxTpr_Br_medicalimaging_tumorsize;
         n236BR_MedicalImaging_TumorSize = false;
         A334BR_MedicalImaging_ImageHtml = obj30.gxTpr_Br_medicalimaging_imagehtml;
         n334BR_MedicalImaging_ImageHtml = false;
         A514BR_MedicalImaging_MetastasesDX = obj30.gxTpr_Br_medicalimaging_metastasesdx;
         n514BR_MedicalImaging_MetastasesDX = false;
         A515BR_MedicalImaging_MetaLoc = obj30.gxTpr_Br_medicalimaging_metaloc;
         n515BR_MedicalImaging_MetaLoc = false;
         A516BR_MedicalImaging_MetaDate = obj30.gxTpr_Br_medicalimaging_metadate;
         n516BR_MedicalImaging_MetaDate = false;
         A225BR_MedicalImagingID = obj30.gxTpr_Br_medicalimagingid;
         n225BR_MedicalImagingID = false;
         Z225BR_MedicalImagingID = obj30.gxTpr_Br_medicalimagingid_Z;
         Z19BR_EncounterID = obj30.gxTpr_Br_encounterid_Z;
         Z36BR_Information_PatientNo = obj30.gxTpr_Br_information_patientno_Z;
         Z227BR_MedicalImaging_ID = obj30.gxTpr_Br_medicalimaging_id_Z;
         Z518BR_MedicalImaging_No = obj30.gxTpr_Br_medicalimaging_no_Z;
         Z228BR_MedicalImaging_ImageName = obj30.gxTpr_Br_medicalimaging_imagename_Z;
         Z484BR_MedicalImaging_ImageName_Code = obj30.gxTpr_Br_medicalimaging_imagename_code_Z;
         Z229BR_MedicalImaging_ImageDate = obj30.gxTpr_Br_medicalimaging_imagedate_Z;
         Z230BR_MedicalImaging_ImageHosp = obj30.gxTpr_Br_medicalimaging_imagehosp_Z;
         Z485BR_MedicalImaging_ImageHosp_Code = obj30.gxTpr_Br_medicalimaging_imagehosp_code_Z;
         Z231BR_MedicalImaging_ImageAge = obj30.gxTpr_Br_medicalimaging_imageage_Z;
         Z232BR_MedicalImaging_ImageLoc = obj30.gxTpr_Br_medicalimaging_imageloc_Z;
         Z486BR_MedicalImaging_ImageLoc_Code = obj30.gxTpr_Br_medicalimaging_imageloc_code_Z;
         Z233BR_MedicalImaging_ImageOrgan = obj30.gxTpr_Br_medicalimaging_imageorgan_Z;
         Z234BR_MedicalImaging_PreImageDiag = obj30.gxTpr_Br_medicalimaging_preimagediag_Z;
         Z235BR_MedicalImaging_ImageDes = obj30.gxTpr_Br_medicalimaging_imagedes_Z;
         Z236BR_MedicalImaging_TumorSize = obj30.gxTpr_Br_medicalimaging_tumorsize_Z;
         Z514BR_MedicalImaging_MetastasesDX = obj30.gxTpr_Br_medicalimaging_metastasesdx_Z;
         Z515BR_MedicalImaging_MetaLoc = obj30.gxTpr_Br_medicalimaging_metaloc_Z;
         Z516BR_MedicalImaging_MetaDate = obj30.gxTpr_Br_medicalimaging_metadate_Z;
         n225BR_MedicalImagingID = (bool)(Convert.ToBoolean(obj30.gxTpr_Br_medicalimagingid_N));
         n19BR_EncounterID = (bool)(Convert.ToBoolean(obj30.gxTpr_Br_encounterid_N));
         n36BR_Information_PatientNo = (bool)(Convert.ToBoolean(obj30.gxTpr_Br_information_patientno_N));
         n227BR_MedicalImaging_ID = (bool)(Convert.ToBoolean(obj30.gxTpr_Br_medicalimaging_id_N));
         n518BR_MedicalImaging_No = (bool)(Convert.ToBoolean(obj30.gxTpr_Br_medicalimaging_no_N));
         n228BR_MedicalImaging_ImageName = (bool)(Convert.ToBoolean(obj30.gxTpr_Br_medicalimaging_imagename_N));
         n484BR_MedicalImaging_ImageName_Code = (bool)(Convert.ToBoolean(obj30.gxTpr_Br_medicalimaging_imagename_code_N));
         n229BR_MedicalImaging_ImageDate = (bool)(Convert.ToBoolean(obj30.gxTpr_Br_medicalimaging_imagedate_N));
         n230BR_MedicalImaging_ImageHosp = (bool)(Convert.ToBoolean(obj30.gxTpr_Br_medicalimaging_imagehosp_N));
         n485BR_MedicalImaging_ImageHosp_Code = (bool)(Convert.ToBoolean(obj30.gxTpr_Br_medicalimaging_imagehosp_code_N));
         n231BR_MedicalImaging_ImageAge = (bool)(Convert.ToBoolean(obj30.gxTpr_Br_medicalimaging_imageage_N));
         n232BR_MedicalImaging_ImageLoc = (bool)(Convert.ToBoolean(obj30.gxTpr_Br_medicalimaging_imageloc_N));
         n486BR_MedicalImaging_ImageLoc_Code = (bool)(Convert.ToBoolean(obj30.gxTpr_Br_medicalimaging_imageloc_code_N));
         n233BR_MedicalImaging_ImageOrgan = (bool)(Convert.ToBoolean(obj30.gxTpr_Br_medicalimaging_imageorgan_N));
         n234BR_MedicalImaging_PreImageDiag = (bool)(Convert.ToBoolean(obj30.gxTpr_Br_medicalimaging_preimagediag_N));
         n235BR_MedicalImaging_ImageDes = (bool)(Convert.ToBoolean(obj30.gxTpr_Br_medicalimaging_imagedes_N));
         n236BR_MedicalImaging_TumorSize = (bool)(Convert.ToBoolean(obj30.gxTpr_Br_medicalimaging_tumorsize_N));
         n334BR_MedicalImaging_ImageHtml = (bool)(Convert.ToBoolean(obj30.gxTpr_Br_medicalimaging_imagehtml_N));
         n514BR_MedicalImaging_MetastasesDX = (bool)(Convert.ToBoolean(obj30.gxTpr_Br_medicalimaging_metastasesdx_N));
         n515BR_MedicalImaging_MetaLoc = (bool)(Convert.ToBoolean(obj30.gxTpr_Br_medicalimaging_metaloc_N));
         n516BR_MedicalImaging_MetaDate = (bool)(Convert.ToBoolean(obj30.gxTpr_Br_medicalimaging_metadate_N));
         Gx_mode = obj30.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A225BR_MedicalImagingID = (long)getParm(obj,0);
         n225BR_MedicalImagingID = false;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey0T30( ) ;
         ScanKeyStart0T30( ) ;
         if ( RcdFound30 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z225BR_MedicalImagingID = A225BR_MedicalImagingID;
         }
         ZM0T30( -16) ;
         OnLoadActions0T30( ) ;
         AddRow0T30( ) ;
         ScanKeyEnd0T30( ) ;
         if ( RcdFound30 == 0 )
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
         RowToVars30( bcBR_MedicalImaging, 0) ;
         ScanKeyStart0T30( ) ;
         if ( RcdFound30 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z225BR_MedicalImagingID = A225BR_MedicalImagingID;
         }
         ZM0T30( -16) ;
         OnLoadActions0T30( ) ;
         AddRow0T30( ) ;
         ScanKeyEnd0T30( ) ;
         if ( RcdFound30 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey0T30( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert0T30( ) ;
         }
         else
         {
            if ( RcdFound30 == 1 )
            {
               if ( A225BR_MedicalImagingID != Z225BR_MedicalImagingID )
               {
                  A225BR_MedicalImagingID = Z225BR_MedicalImagingID;
                  n225BR_MedicalImagingID = false;
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
                  Update0T30( ) ;
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
                  if ( A225BR_MedicalImagingID != Z225BR_MedicalImagingID )
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
                        Insert0T30( ) ;
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
                        Insert0T30( ) ;
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
         RowToVars30( bcBR_MedicalImaging, 0) ;
         SaveImpl( ) ;
         VarsToRow30( bcBR_MedicalImaging) ;
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
         RowToVars30( bcBR_MedicalImaging, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert0T30( ) ;
         AfterTrn( ) ;
         VarsToRow30( bcBR_MedicalImaging) ;
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
            SdtBR_MedicalImaging auxBC = new SdtBR_MedicalImaging(context) ;
            auxBC.Load(A225BR_MedicalImagingID);
            auxBC.UpdateDirties(bcBR_MedicalImaging);
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
         RowToVars30( bcBR_MedicalImaging, 0) ;
         UpdateImpl( ) ;
         VarsToRow30( bcBR_MedicalImaging) ;
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
         RowToVars30( bcBR_MedicalImaging, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert0T30( ) ;
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
         VarsToRow30( bcBR_MedicalImaging) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars30( bcBR_MedicalImaging, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey0T30( ) ;
         if ( RcdFound30 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A225BR_MedicalImagingID != Z225BR_MedicalImagingID )
            {
               A225BR_MedicalImagingID = Z225BR_MedicalImagingID;
               n225BR_MedicalImagingID = false;
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
            if ( A225BR_MedicalImagingID != Z225BR_MedicalImagingID )
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
         context.RollbackDataStores("br_medicalimaging_bc",pr_default);
         VarsToRow30( bcBR_MedicalImaging) ;
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
         Gx_mode = bcBR_MedicalImaging.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcBR_MedicalImaging.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcBR_MedicalImaging )
         {
            bcBR_MedicalImaging = (SdtBR_MedicalImaging)(sdt);
            if ( StringUtil.StrCmp(bcBR_MedicalImaging.gxTpr_Mode, "") == 0 )
            {
               bcBR_MedicalImaging.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow30( bcBR_MedicalImaging) ;
            }
            else
            {
               RowToVars30( bcBR_MedicalImaging, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcBR_MedicalImaging.gxTpr_Mode, "") == 0 )
            {
               bcBR_MedicalImaging.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars30( bcBR_MedicalImaging, 1) ;
         return  ;
      }

      public SdtBR_MedicalImaging BR_MedicalImaging_BC
      {
         get {
            return bcBR_MedicalImaging ;
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
         AV8WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV19Pgmname = "";
         AV11TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV12WebSession = context.GetSession();
         AV14TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         Z484BR_MedicalImaging_ImageName_Code = "";
         A484BR_MedicalImaging_ImageName_Code = "";
         Z485BR_MedicalImaging_ImageHosp_Code = "";
         A485BR_MedicalImaging_ImageHosp_Code = "";
         Z228BR_MedicalImaging_ImageName = "";
         A228BR_MedicalImaging_ImageName = "";
         Z229BR_MedicalImaging_ImageDate = DateTime.MinValue;
         A229BR_MedicalImaging_ImageDate = DateTime.MinValue;
         Z230BR_MedicalImaging_ImageHosp = "";
         A230BR_MedicalImaging_ImageHosp = "";
         Z232BR_MedicalImaging_ImageLoc = "";
         A232BR_MedicalImaging_ImageLoc = "";
         Z486BR_MedicalImaging_ImageLoc_Code = "";
         A486BR_MedicalImaging_ImageLoc_Code = "";
         Z233BR_MedicalImaging_ImageOrgan = "";
         A233BR_MedicalImaging_ImageOrgan = "";
         Z234BR_MedicalImaging_PreImageDiag = "";
         A234BR_MedicalImaging_PreImageDiag = "";
         Z235BR_MedicalImaging_ImageDes = "";
         A235BR_MedicalImaging_ImageDes = "";
         Z236BR_MedicalImaging_TumorSize = "";
         A236BR_MedicalImaging_TumorSize = "";
         Z514BR_MedicalImaging_MetastasesDX = "";
         A514BR_MedicalImaging_MetastasesDX = "";
         Z515BR_MedicalImaging_MetaLoc = "";
         A515BR_MedicalImaging_MetaLoc = "";
         Z516BR_MedicalImaging_MetaDate = DateTime.MinValue;
         A516BR_MedicalImaging_MetaDate = DateTime.MinValue;
         Z36BR_Information_PatientNo = "";
         A36BR_Information_PatientNo = "";
         Z334BR_MedicalImaging_ImageHtml = "";
         A334BR_MedicalImaging_ImageHtml = "";
         BC000T6_A85BR_Information_ID = new long[1] ;
         BC000T6_n85BR_Information_ID = new bool[] {false} ;
         BC000T6_A225BR_MedicalImagingID = new long[1] ;
         BC000T6_n225BR_MedicalImagingID = new bool[] {false} ;
         BC000T6_A484BR_MedicalImaging_ImageName_Code = new String[] {""} ;
         BC000T6_n484BR_MedicalImaging_ImageName_Code = new bool[] {false} ;
         BC000T6_A485BR_MedicalImaging_ImageHosp_Code = new String[] {""} ;
         BC000T6_n485BR_MedicalImaging_ImageHosp_Code = new bool[] {false} ;
         BC000T6_A36BR_Information_PatientNo = new String[] {""} ;
         BC000T6_n36BR_Information_PatientNo = new bool[] {false} ;
         BC000T6_A227BR_MedicalImaging_ID = new long[1] ;
         BC000T6_n227BR_MedicalImaging_ID = new bool[] {false} ;
         BC000T6_A518BR_MedicalImaging_No = new long[1] ;
         BC000T6_n518BR_MedicalImaging_No = new bool[] {false} ;
         BC000T6_A228BR_MedicalImaging_ImageName = new String[] {""} ;
         BC000T6_n228BR_MedicalImaging_ImageName = new bool[] {false} ;
         BC000T6_A229BR_MedicalImaging_ImageDate = new DateTime[] {DateTime.MinValue} ;
         BC000T6_n229BR_MedicalImaging_ImageDate = new bool[] {false} ;
         BC000T6_A230BR_MedicalImaging_ImageHosp = new String[] {""} ;
         BC000T6_n230BR_MedicalImaging_ImageHosp = new bool[] {false} ;
         BC000T6_A231BR_MedicalImaging_ImageAge = new short[1] ;
         BC000T6_n231BR_MedicalImaging_ImageAge = new bool[] {false} ;
         BC000T6_A232BR_MedicalImaging_ImageLoc = new String[] {""} ;
         BC000T6_n232BR_MedicalImaging_ImageLoc = new bool[] {false} ;
         BC000T6_A486BR_MedicalImaging_ImageLoc_Code = new String[] {""} ;
         BC000T6_n486BR_MedicalImaging_ImageLoc_Code = new bool[] {false} ;
         BC000T6_A233BR_MedicalImaging_ImageOrgan = new String[] {""} ;
         BC000T6_n233BR_MedicalImaging_ImageOrgan = new bool[] {false} ;
         BC000T6_A234BR_MedicalImaging_PreImageDiag = new String[] {""} ;
         BC000T6_n234BR_MedicalImaging_PreImageDiag = new bool[] {false} ;
         BC000T6_A235BR_MedicalImaging_ImageDes = new String[] {""} ;
         BC000T6_n235BR_MedicalImaging_ImageDes = new bool[] {false} ;
         BC000T6_A236BR_MedicalImaging_TumorSize = new String[] {""} ;
         BC000T6_n236BR_MedicalImaging_TumorSize = new bool[] {false} ;
         BC000T6_A334BR_MedicalImaging_ImageHtml = new String[] {""} ;
         BC000T6_n334BR_MedicalImaging_ImageHtml = new bool[] {false} ;
         BC000T6_A514BR_MedicalImaging_MetastasesDX = new String[] {""} ;
         BC000T6_n514BR_MedicalImaging_MetastasesDX = new bool[] {false} ;
         BC000T6_A515BR_MedicalImaging_MetaLoc = new String[] {""} ;
         BC000T6_n515BR_MedicalImaging_MetaLoc = new bool[] {false} ;
         BC000T6_A516BR_MedicalImaging_MetaDate = new DateTime[] {DateTime.MinValue} ;
         BC000T6_n516BR_MedicalImaging_MetaDate = new bool[] {false} ;
         BC000T6_A19BR_EncounterID = new long[1] ;
         BC000T6_n19BR_EncounterID = new bool[] {false} ;
         BC000T4_A85BR_Information_ID = new long[1] ;
         BC000T4_n85BR_Information_ID = new bool[] {false} ;
         BC000T5_A36BR_Information_PatientNo = new String[] {""} ;
         BC000T5_n36BR_Information_PatientNo = new bool[] {false} ;
         BC000T7_A225BR_MedicalImagingID = new long[1] ;
         BC000T7_n225BR_MedicalImagingID = new bool[] {false} ;
         BC000T3_A225BR_MedicalImagingID = new long[1] ;
         BC000T3_n225BR_MedicalImagingID = new bool[] {false} ;
         BC000T3_A484BR_MedicalImaging_ImageName_Code = new String[] {""} ;
         BC000T3_n484BR_MedicalImaging_ImageName_Code = new bool[] {false} ;
         BC000T3_A485BR_MedicalImaging_ImageHosp_Code = new String[] {""} ;
         BC000T3_n485BR_MedicalImaging_ImageHosp_Code = new bool[] {false} ;
         BC000T3_A227BR_MedicalImaging_ID = new long[1] ;
         BC000T3_n227BR_MedicalImaging_ID = new bool[] {false} ;
         BC000T3_A518BR_MedicalImaging_No = new long[1] ;
         BC000T3_n518BR_MedicalImaging_No = new bool[] {false} ;
         BC000T3_A228BR_MedicalImaging_ImageName = new String[] {""} ;
         BC000T3_n228BR_MedicalImaging_ImageName = new bool[] {false} ;
         BC000T3_A229BR_MedicalImaging_ImageDate = new DateTime[] {DateTime.MinValue} ;
         BC000T3_n229BR_MedicalImaging_ImageDate = new bool[] {false} ;
         BC000T3_A230BR_MedicalImaging_ImageHosp = new String[] {""} ;
         BC000T3_n230BR_MedicalImaging_ImageHosp = new bool[] {false} ;
         BC000T3_A231BR_MedicalImaging_ImageAge = new short[1] ;
         BC000T3_n231BR_MedicalImaging_ImageAge = new bool[] {false} ;
         BC000T3_A232BR_MedicalImaging_ImageLoc = new String[] {""} ;
         BC000T3_n232BR_MedicalImaging_ImageLoc = new bool[] {false} ;
         BC000T3_A486BR_MedicalImaging_ImageLoc_Code = new String[] {""} ;
         BC000T3_n486BR_MedicalImaging_ImageLoc_Code = new bool[] {false} ;
         BC000T3_A233BR_MedicalImaging_ImageOrgan = new String[] {""} ;
         BC000T3_n233BR_MedicalImaging_ImageOrgan = new bool[] {false} ;
         BC000T3_A234BR_MedicalImaging_PreImageDiag = new String[] {""} ;
         BC000T3_n234BR_MedicalImaging_PreImageDiag = new bool[] {false} ;
         BC000T3_A235BR_MedicalImaging_ImageDes = new String[] {""} ;
         BC000T3_n235BR_MedicalImaging_ImageDes = new bool[] {false} ;
         BC000T3_A236BR_MedicalImaging_TumorSize = new String[] {""} ;
         BC000T3_n236BR_MedicalImaging_TumorSize = new bool[] {false} ;
         BC000T3_A334BR_MedicalImaging_ImageHtml = new String[] {""} ;
         BC000T3_n334BR_MedicalImaging_ImageHtml = new bool[] {false} ;
         BC000T3_A514BR_MedicalImaging_MetastasesDX = new String[] {""} ;
         BC000T3_n514BR_MedicalImaging_MetastasesDX = new bool[] {false} ;
         BC000T3_A515BR_MedicalImaging_MetaLoc = new String[] {""} ;
         BC000T3_n515BR_MedicalImaging_MetaLoc = new bool[] {false} ;
         BC000T3_A516BR_MedicalImaging_MetaDate = new DateTime[] {DateTime.MinValue} ;
         BC000T3_n516BR_MedicalImaging_MetaDate = new bool[] {false} ;
         BC000T3_A19BR_EncounterID = new long[1] ;
         BC000T3_n19BR_EncounterID = new bool[] {false} ;
         sMode30 = "";
         BC000T2_A225BR_MedicalImagingID = new long[1] ;
         BC000T2_n225BR_MedicalImagingID = new bool[] {false} ;
         BC000T2_A484BR_MedicalImaging_ImageName_Code = new String[] {""} ;
         BC000T2_n484BR_MedicalImaging_ImageName_Code = new bool[] {false} ;
         BC000T2_A485BR_MedicalImaging_ImageHosp_Code = new String[] {""} ;
         BC000T2_n485BR_MedicalImaging_ImageHosp_Code = new bool[] {false} ;
         BC000T2_A227BR_MedicalImaging_ID = new long[1] ;
         BC000T2_n227BR_MedicalImaging_ID = new bool[] {false} ;
         BC000T2_A518BR_MedicalImaging_No = new long[1] ;
         BC000T2_n518BR_MedicalImaging_No = new bool[] {false} ;
         BC000T2_A228BR_MedicalImaging_ImageName = new String[] {""} ;
         BC000T2_n228BR_MedicalImaging_ImageName = new bool[] {false} ;
         BC000T2_A229BR_MedicalImaging_ImageDate = new DateTime[] {DateTime.MinValue} ;
         BC000T2_n229BR_MedicalImaging_ImageDate = new bool[] {false} ;
         BC000T2_A230BR_MedicalImaging_ImageHosp = new String[] {""} ;
         BC000T2_n230BR_MedicalImaging_ImageHosp = new bool[] {false} ;
         BC000T2_A231BR_MedicalImaging_ImageAge = new short[1] ;
         BC000T2_n231BR_MedicalImaging_ImageAge = new bool[] {false} ;
         BC000T2_A232BR_MedicalImaging_ImageLoc = new String[] {""} ;
         BC000T2_n232BR_MedicalImaging_ImageLoc = new bool[] {false} ;
         BC000T2_A486BR_MedicalImaging_ImageLoc_Code = new String[] {""} ;
         BC000T2_n486BR_MedicalImaging_ImageLoc_Code = new bool[] {false} ;
         BC000T2_A233BR_MedicalImaging_ImageOrgan = new String[] {""} ;
         BC000T2_n233BR_MedicalImaging_ImageOrgan = new bool[] {false} ;
         BC000T2_A234BR_MedicalImaging_PreImageDiag = new String[] {""} ;
         BC000T2_n234BR_MedicalImaging_PreImageDiag = new bool[] {false} ;
         BC000T2_A235BR_MedicalImaging_ImageDes = new String[] {""} ;
         BC000T2_n235BR_MedicalImaging_ImageDes = new bool[] {false} ;
         BC000T2_A236BR_MedicalImaging_TumorSize = new String[] {""} ;
         BC000T2_n236BR_MedicalImaging_TumorSize = new bool[] {false} ;
         BC000T2_A334BR_MedicalImaging_ImageHtml = new String[] {""} ;
         BC000T2_n334BR_MedicalImaging_ImageHtml = new bool[] {false} ;
         BC000T2_A514BR_MedicalImaging_MetastasesDX = new String[] {""} ;
         BC000T2_n514BR_MedicalImaging_MetastasesDX = new bool[] {false} ;
         BC000T2_A515BR_MedicalImaging_MetaLoc = new String[] {""} ;
         BC000T2_n515BR_MedicalImaging_MetaLoc = new bool[] {false} ;
         BC000T2_A516BR_MedicalImaging_MetaDate = new DateTime[] {DateTime.MinValue} ;
         BC000T2_n516BR_MedicalImaging_MetaDate = new bool[] {false} ;
         BC000T2_A19BR_EncounterID = new long[1] ;
         BC000T2_n19BR_EncounterID = new bool[] {false} ;
         BC000T8_A225BR_MedicalImagingID = new long[1] ;
         BC000T8_n225BR_MedicalImagingID = new bool[] {false} ;
         BC000T11_A85BR_Information_ID = new long[1] ;
         BC000T11_n85BR_Information_ID = new bool[] {false} ;
         BC000T12_A36BR_Information_PatientNo = new String[] {""} ;
         BC000T12_n36BR_Information_PatientNo = new bool[] {false} ;
         BC000T13_A270BR_MedicalImaging_DiagID = new long[1] ;
         BC000T14_A85BR_Information_ID = new long[1] ;
         BC000T14_n85BR_Information_ID = new bool[] {false} ;
         BC000T14_A225BR_MedicalImagingID = new long[1] ;
         BC000T14_n225BR_MedicalImagingID = new bool[] {false} ;
         BC000T14_A484BR_MedicalImaging_ImageName_Code = new String[] {""} ;
         BC000T14_n484BR_MedicalImaging_ImageName_Code = new bool[] {false} ;
         BC000T14_A485BR_MedicalImaging_ImageHosp_Code = new String[] {""} ;
         BC000T14_n485BR_MedicalImaging_ImageHosp_Code = new bool[] {false} ;
         BC000T14_A36BR_Information_PatientNo = new String[] {""} ;
         BC000T14_n36BR_Information_PatientNo = new bool[] {false} ;
         BC000T14_A227BR_MedicalImaging_ID = new long[1] ;
         BC000T14_n227BR_MedicalImaging_ID = new bool[] {false} ;
         BC000T14_A518BR_MedicalImaging_No = new long[1] ;
         BC000T14_n518BR_MedicalImaging_No = new bool[] {false} ;
         BC000T14_A228BR_MedicalImaging_ImageName = new String[] {""} ;
         BC000T14_n228BR_MedicalImaging_ImageName = new bool[] {false} ;
         BC000T14_A229BR_MedicalImaging_ImageDate = new DateTime[] {DateTime.MinValue} ;
         BC000T14_n229BR_MedicalImaging_ImageDate = new bool[] {false} ;
         BC000T14_A230BR_MedicalImaging_ImageHosp = new String[] {""} ;
         BC000T14_n230BR_MedicalImaging_ImageHosp = new bool[] {false} ;
         BC000T14_A231BR_MedicalImaging_ImageAge = new short[1] ;
         BC000T14_n231BR_MedicalImaging_ImageAge = new bool[] {false} ;
         BC000T14_A232BR_MedicalImaging_ImageLoc = new String[] {""} ;
         BC000T14_n232BR_MedicalImaging_ImageLoc = new bool[] {false} ;
         BC000T14_A486BR_MedicalImaging_ImageLoc_Code = new String[] {""} ;
         BC000T14_n486BR_MedicalImaging_ImageLoc_Code = new bool[] {false} ;
         BC000T14_A233BR_MedicalImaging_ImageOrgan = new String[] {""} ;
         BC000T14_n233BR_MedicalImaging_ImageOrgan = new bool[] {false} ;
         BC000T14_A234BR_MedicalImaging_PreImageDiag = new String[] {""} ;
         BC000T14_n234BR_MedicalImaging_PreImageDiag = new bool[] {false} ;
         BC000T14_A235BR_MedicalImaging_ImageDes = new String[] {""} ;
         BC000T14_n235BR_MedicalImaging_ImageDes = new bool[] {false} ;
         BC000T14_A236BR_MedicalImaging_TumorSize = new String[] {""} ;
         BC000T14_n236BR_MedicalImaging_TumorSize = new bool[] {false} ;
         BC000T14_A334BR_MedicalImaging_ImageHtml = new String[] {""} ;
         BC000T14_n334BR_MedicalImaging_ImageHtml = new bool[] {false} ;
         BC000T14_A514BR_MedicalImaging_MetastasesDX = new String[] {""} ;
         BC000T14_n514BR_MedicalImaging_MetastasesDX = new bool[] {false} ;
         BC000T14_A515BR_MedicalImaging_MetaLoc = new String[] {""} ;
         BC000T14_n515BR_MedicalImaging_MetaLoc = new bool[] {false} ;
         BC000T14_A516BR_MedicalImaging_MetaDate = new DateTime[] {DateTime.MinValue} ;
         BC000T14_n516BR_MedicalImaging_MetaDate = new bool[] {false} ;
         BC000T14_A19BR_EncounterID = new long[1] ;
         BC000T14_n19BR_EncounterID = new bool[] {false} ;
         GXt_char2 = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_medicalimaging_bc__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_medicalimaging_bc__default(),
            new Object[][] {
                new Object[] {
               BC000T2_A225BR_MedicalImagingID, BC000T2_A484BR_MedicalImaging_ImageName_Code, BC000T2_n484BR_MedicalImaging_ImageName_Code, BC000T2_A485BR_MedicalImaging_ImageHosp_Code, BC000T2_n485BR_MedicalImaging_ImageHosp_Code, BC000T2_A227BR_MedicalImaging_ID, BC000T2_n227BR_MedicalImaging_ID, BC000T2_A518BR_MedicalImaging_No, BC000T2_n518BR_MedicalImaging_No, BC000T2_A228BR_MedicalImaging_ImageName,
               BC000T2_n228BR_MedicalImaging_ImageName, BC000T2_A229BR_MedicalImaging_ImageDate, BC000T2_n229BR_MedicalImaging_ImageDate, BC000T2_A230BR_MedicalImaging_ImageHosp, BC000T2_n230BR_MedicalImaging_ImageHosp, BC000T2_A231BR_MedicalImaging_ImageAge, BC000T2_n231BR_MedicalImaging_ImageAge, BC000T2_A232BR_MedicalImaging_ImageLoc, BC000T2_n232BR_MedicalImaging_ImageLoc, BC000T2_A486BR_MedicalImaging_ImageLoc_Code,
               BC000T2_n486BR_MedicalImaging_ImageLoc_Code, BC000T2_A233BR_MedicalImaging_ImageOrgan, BC000T2_n233BR_MedicalImaging_ImageOrgan, BC000T2_A234BR_MedicalImaging_PreImageDiag, BC000T2_n234BR_MedicalImaging_PreImageDiag, BC000T2_A235BR_MedicalImaging_ImageDes, BC000T2_n235BR_MedicalImaging_ImageDes, BC000T2_A236BR_MedicalImaging_TumorSize, BC000T2_n236BR_MedicalImaging_TumorSize, BC000T2_A334BR_MedicalImaging_ImageHtml,
               BC000T2_n334BR_MedicalImaging_ImageHtml, BC000T2_A514BR_MedicalImaging_MetastasesDX, BC000T2_n514BR_MedicalImaging_MetastasesDX, BC000T2_A515BR_MedicalImaging_MetaLoc, BC000T2_n515BR_MedicalImaging_MetaLoc, BC000T2_A516BR_MedicalImaging_MetaDate, BC000T2_n516BR_MedicalImaging_MetaDate, BC000T2_A19BR_EncounterID, BC000T2_n19BR_EncounterID
               }
               , new Object[] {
               BC000T3_A225BR_MedicalImagingID, BC000T3_A484BR_MedicalImaging_ImageName_Code, BC000T3_n484BR_MedicalImaging_ImageName_Code, BC000T3_A485BR_MedicalImaging_ImageHosp_Code, BC000T3_n485BR_MedicalImaging_ImageHosp_Code, BC000T3_A227BR_MedicalImaging_ID, BC000T3_n227BR_MedicalImaging_ID, BC000T3_A518BR_MedicalImaging_No, BC000T3_n518BR_MedicalImaging_No, BC000T3_A228BR_MedicalImaging_ImageName,
               BC000T3_n228BR_MedicalImaging_ImageName, BC000T3_A229BR_MedicalImaging_ImageDate, BC000T3_n229BR_MedicalImaging_ImageDate, BC000T3_A230BR_MedicalImaging_ImageHosp, BC000T3_n230BR_MedicalImaging_ImageHosp, BC000T3_A231BR_MedicalImaging_ImageAge, BC000T3_n231BR_MedicalImaging_ImageAge, BC000T3_A232BR_MedicalImaging_ImageLoc, BC000T3_n232BR_MedicalImaging_ImageLoc, BC000T3_A486BR_MedicalImaging_ImageLoc_Code,
               BC000T3_n486BR_MedicalImaging_ImageLoc_Code, BC000T3_A233BR_MedicalImaging_ImageOrgan, BC000T3_n233BR_MedicalImaging_ImageOrgan, BC000T3_A234BR_MedicalImaging_PreImageDiag, BC000T3_n234BR_MedicalImaging_PreImageDiag, BC000T3_A235BR_MedicalImaging_ImageDes, BC000T3_n235BR_MedicalImaging_ImageDes, BC000T3_A236BR_MedicalImaging_TumorSize, BC000T3_n236BR_MedicalImaging_TumorSize, BC000T3_A334BR_MedicalImaging_ImageHtml,
               BC000T3_n334BR_MedicalImaging_ImageHtml, BC000T3_A514BR_MedicalImaging_MetastasesDX, BC000T3_n514BR_MedicalImaging_MetastasesDX, BC000T3_A515BR_MedicalImaging_MetaLoc, BC000T3_n515BR_MedicalImaging_MetaLoc, BC000T3_A516BR_MedicalImaging_MetaDate, BC000T3_n516BR_MedicalImaging_MetaDate, BC000T3_A19BR_EncounterID, BC000T3_n19BR_EncounterID
               }
               , new Object[] {
               BC000T4_A85BR_Information_ID, BC000T4_n85BR_Information_ID
               }
               , new Object[] {
               BC000T5_A36BR_Information_PatientNo, BC000T5_n36BR_Information_PatientNo
               }
               , new Object[] {
               BC000T6_A85BR_Information_ID, BC000T6_n85BR_Information_ID, BC000T6_A225BR_MedicalImagingID, BC000T6_A484BR_MedicalImaging_ImageName_Code, BC000T6_n484BR_MedicalImaging_ImageName_Code, BC000T6_A485BR_MedicalImaging_ImageHosp_Code, BC000T6_n485BR_MedicalImaging_ImageHosp_Code, BC000T6_A36BR_Information_PatientNo, BC000T6_n36BR_Information_PatientNo, BC000T6_A227BR_MedicalImaging_ID,
               BC000T6_n227BR_MedicalImaging_ID, BC000T6_A518BR_MedicalImaging_No, BC000T6_n518BR_MedicalImaging_No, BC000T6_A228BR_MedicalImaging_ImageName, BC000T6_n228BR_MedicalImaging_ImageName, BC000T6_A229BR_MedicalImaging_ImageDate, BC000T6_n229BR_MedicalImaging_ImageDate, BC000T6_A230BR_MedicalImaging_ImageHosp, BC000T6_n230BR_MedicalImaging_ImageHosp, BC000T6_A231BR_MedicalImaging_ImageAge,
               BC000T6_n231BR_MedicalImaging_ImageAge, BC000T6_A232BR_MedicalImaging_ImageLoc, BC000T6_n232BR_MedicalImaging_ImageLoc, BC000T6_A486BR_MedicalImaging_ImageLoc_Code, BC000T6_n486BR_MedicalImaging_ImageLoc_Code, BC000T6_A233BR_MedicalImaging_ImageOrgan, BC000T6_n233BR_MedicalImaging_ImageOrgan, BC000T6_A234BR_MedicalImaging_PreImageDiag, BC000T6_n234BR_MedicalImaging_PreImageDiag, BC000T6_A235BR_MedicalImaging_ImageDes,
               BC000T6_n235BR_MedicalImaging_ImageDes, BC000T6_A236BR_MedicalImaging_TumorSize, BC000T6_n236BR_MedicalImaging_TumorSize, BC000T6_A334BR_MedicalImaging_ImageHtml, BC000T6_n334BR_MedicalImaging_ImageHtml, BC000T6_A514BR_MedicalImaging_MetastasesDX, BC000T6_n514BR_MedicalImaging_MetastasesDX, BC000T6_A515BR_MedicalImaging_MetaLoc, BC000T6_n515BR_MedicalImaging_MetaLoc, BC000T6_A516BR_MedicalImaging_MetaDate,
               BC000T6_n516BR_MedicalImaging_MetaDate, BC000T6_A19BR_EncounterID, BC000T6_n19BR_EncounterID
               }
               , new Object[] {
               BC000T7_A225BR_MedicalImagingID
               }
               , new Object[] {
               BC000T8_A225BR_MedicalImagingID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000T11_A85BR_Information_ID, BC000T11_n85BR_Information_ID
               }
               , new Object[] {
               BC000T12_A36BR_Information_PatientNo, BC000T12_n36BR_Information_PatientNo
               }
               , new Object[] {
               BC000T13_A270BR_MedicalImaging_DiagID
               }
               , new Object[] {
               BC000T14_A85BR_Information_ID, BC000T14_n85BR_Information_ID, BC000T14_A225BR_MedicalImagingID, BC000T14_A484BR_MedicalImaging_ImageName_Code, BC000T14_n484BR_MedicalImaging_ImageName_Code, BC000T14_A485BR_MedicalImaging_ImageHosp_Code, BC000T14_n485BR_MedicalImaging_ImageHosp_Code, BC000T14_A36BR_Information_PatientNo, BC000T14_n36BR_Information_PatientNo, BC000T14_A227BR_MedicalImaging_ID,
               BC000T14_n227BR_MedicalImaging_ID, BC000T14_A518BR_MedicalImaging_No, BC000T14_n518BR_MedicalImaging_No, BC000T14_A228BR_MedicalImaging_ImageName, BC000T14_n228BR_MedicalImaging_ImageName, BC000T14_A229BR_MedicalImaging_ImageDate, BC000T14_n229BR_MedicalImaging_ImageDate, BC000T14_A230BR_MedicalImaging_ImageHosp, BC000T14_n230BR_MedicalImaging_ImageHosp, BC000T14_A231BR_MedicalImaging_ImageAge,
               BC000T14_n231BR_MedicalImaging_ImageAge, BC000T14_A232BR_MedicalImaging_ImageLoc, BC000T14_n232BR_MedicalImaging_ImageLoc, BC000T14_A486BR_MedicalImaging_ImageLoc_Code, BC000T14_n486BR_MedicalImaging_ImageLoc_Code, BC000T14_A233BR_MedicalImaging_ImageOrgan, BC000T14_n233BR_MedicalImaging_ImageOrgan, BC000T14_A234BR_MedicalImaging_PreImageDiag, BC000T14_n234BR_MedicalImaging_PreImageDiag, BC000T14_A235BR_MedicalImaging_ImageDes,
               BC000T14_n235BR_MedicalImaging_ImageDes, BC000T14_A236BR_MedicalImaging_TumorSize, BC000T14_n236BR_MedicalImaging_TumorSize, BC000T14_A334BR_MedicalImaging_ImageHtml, BC000T14_n334BR_MedicalImaging_ImageHtml, BC000T14_A514BR_MedicalImaging_MetastasesDX, BC000T14_n514BR_MedicalImaging_MetastasesDX, BC000T14_A515BR_MedicalImaging_MetaLoc, BC000T14_n515BR_MedicalImaging_MetaLoc, BC000T14_A516BR_MedicalImaging_MetaDate,
               BC000T14_n516BR_MedicalImaging_MetaDate, BC000T14_A19BR_EncounterID, BC000T14_n19BR_EncounterID
               }
            }
         );
         AV19Pgmname = "BR_MedicalImaging_BC";
         INITTRN();
         /* Execute Start event if defined. */
         /* Execute user event: Start */
         E120T2 ();
         standaloneNotModal( ) ;
      }

      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short GX_JID ;
      private short Z231BR_MedicalImaging_ImageAge ;
      private short A231BR_MedicalImaging_ImageAge ;
      private short RcdFound30 ;
      private int trnEnded ;
      private int AV20GXV1 ;
      private long Z225BR_MedicalImagingID ;
      private long A225BR_MedicalImagingID ;
      private long AV13Insert_BR_EncounterID ;
      private long Z227BR_MedicalImaging_ID ;
      private long A227BR_MedicalImaging_ID ;
      private long Z518BR_MedicalImaging_No ;
      private long A518BR_MedicalImaging_No ;
      private long Z19BR_EncounterID ;
      private long A19BR_EncounterID ;
      private long Z85BR_Information_ID ;
      private long A85BR_Information_ID ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String AV19Pgmname ;
      private String sMode30 ;
      private String GXt_char2 ;
      private DateTime Z229BR_MedicalImaging_ImageDate ;
      private DateTime A229BR_MedicalImaging_ImageDate ;
      private DateTime Z516BR_MedicalImaging_MetaDate ;
      private DateTime A516BR_MedicalImaging_MetaDate ;
      private bool AV9IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool returnInSub ;
      private bool n225BR_MedicalImagingID ;
      private bool n85BR_Information_ID ;
      private bool n484BR_MedicalImaging_ImageName_Code ;
      private bool n485BR_MedicalImaging_ImageHosp_Code ;
      private bool n36BR_Information_PatientNo ;
      private bool n227BR_MedicalImaging_ID ;
      private bool n518BR_MedicalImaging_No ;
      private bool n228BR_MedicalImaging_ImageName ;
      private bool n229BR_MedicalImaging_ImageDate ;
      private bool n230BR_MedicalImaging_ImageHosp ;
      private bool n231BR_MedicalImaging_ImageAge ;
      private bool n232BR_MedicalImaging_ImageLoc ;
      private bool n486BR_MedicalImaging_ImageLoc_Code ;
      private bool n233BR_MedicalImaging_ImageOrgan ;
      private bool n234BR_MedicalImaging_PreImageDiag ;
      private bool n235BR_MedicalImaging_ImageDes ;
      private bool n236BR_MedicalImaging_TumorSize ;
      private bool n334BR_MedicalImaging_ImageHtml ;
      private bool n514BR_MedicalImaging_MetastasesDX ;
      private bool n515BR_MedicalImaging_MetaLoc ;
      private bool n516BR_MedicalImaging_MetaDate ;
      private bool n19BR_EncounterID ;
      private bool Gx_longc ;
      private String Z334BR_MedicalImaging_ImageHtml ;
      private String A334BR_MedicalImaging_ImageHtml ;
      private String Z484BR_MedicalImaging_ImageName_Code ;
      private String A484BR_MedicalImaging_ImageName_Code ;
      private String Z485BR_MedicalImaging_ImageHosp_Code ;
      private String A485BR_MedicalImaging_ImageHosp_Code ;
      private String Z228BR_MedicalImaging_ImageName ;
      private String A228BR_MedicalImaging_ImageName ;
      private String Z230BR_MedicalImaging_ImageHosp ;
      private String A230BR_MedicalImaging_ImageHosp ;
      private String Z232BR_MedicalImaging_ImageLoc ;
      private String A232BR_MedicalImaging_ImageLoc ;
      private String Z486BR_MedicalImaging_ImageLoc_Code ;
      private String A486BR_MedicalImaging_ImageLoc_Code ;
      private String Z233BR_MedicalImaging_ImageOrgan ;
      private String A233BR_MedicalImaging_ImageOrgan ;
      private String Z234BR_MedicalImaging_PreImageDiag ;
      private String A234BR_MedicalImaging_PreImageDiag ;
      private String Z235BR_MedicalImaging_ImageDes ;
      private String A235BR_MedicalImaging_ImageDes ;
      private String Z236BR_MedicalImaging_TumorSize ;
      private String A236BR_MedicalImaging_TumorSize ;
      private String Z514BR_MedicalImaging_MetastasesDX ;
      private String A514BR_MedicalImaging_MetastasesDX ;
      private String Z515BR_MedicalImaging_MetaLoc ;
      private String A515BR_MedicalImaging_MetaLoc ;
      private String Z36BR_Information_PatientNo ;
      private String A36BR_Information_PatientNo ;
      private IGxSession AV12WebSession ;
      private SdtBR_MedicalImaging bcBR_MedicalImaging ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] BC000T6_A85BR_Information_ID ;
      private bool[] BC000T6_n85BR_Information_ID ;
      private long[] BC000T6_A225BR_MedicalImagingID ;
      private bool[] BC000T6_n225BR_MedicalImagingID ;
      private String[] BC000T6_A484BR_MedicalImaging_ImageName_Code ;
      private bool[] BC000T6_n484BR_MedicalImaging_ImageName_Code ;
      private String[] BC000T6_A485BR_MedicalImaging_ImageHosp_Code ;
      private bool[] BC000T6_n485BR_MedicalImaging_ImageHosp_Code ;
      private String[] BC000T6_A36BR_Information_PatientNo ;
      private bool[] BC000T6_n36BR_Information_PatientNo ;
      private long[] BC000T6_A227BR_MedicalImaging_ID ;
      private bool[] BC000T6_n227BR_MedicalImaging_ID ;
      private long[] BC000T6_A518BR_MedicalImaging_No ;
      private bool[] BC000T6_n518BR_MedicalImaging_No ;
      private String[] BC000T6_A228BR_MedicalImaging_ImageName ;
      private bool[] BC000T6_n228BR_MedicalImaging_ImageName ;
      private DateTime[] BC000T6_A229BR_MedicalImaging_ImageDate ;
      private bool[] BC000T6_n229BR_MedicalImaging_ImageDate ;
      private String[] BC000T6_A230BR_MedicalImaging_ImageHosp ;
      private bool[] BC000T6_n230BR_MedicalImaging_ImageHosp ;
      private short[] BC000T6_A231BR_MedicalImaging_ImageAge ;
      private bool[] BC000T6_n231BR_MedicalImaging_ImageAge ;
      private String[] BC000T6_A232BR_MedicalImaging_ImageLoc ;
      private bool[] BC000T6_n232BR_MedicalImaging_ImageLoc ;
      private String[] BC000T6_A486BR_MedicalImaging_ImageLoc_Code ;
      private bool[] BC000T6_n486BR_MedicalImaging_ImageLoc_Code ;
      private String[] BC000T6_A233BR_MedicalImaging_ImageOrgan ;
      private bool[] BC000T6_n233BR_MedicalImaging_ImageOrgan ;
      private String[] BC000T6_A234BR_MedicalImaging_PreImageDiag ;
      private bool[] BC000T6_n234BR_MedicalImaging_PreImageDiag ;
      private String[] BC000T6_A235BR_MedicalImaging_ImageDes ;
      private bool[] BC000T6_n235BR_MedicalImaging_ImageDes ;
      private String[] BC000T6_A236BR_MedicalImaging_TumorSize ;
      private bool[] BC000T6_n236BR_MedicalImaging_TumorSize ;
      private String[] BC000T6_A334BR_MedicalImaging_ImageHtml ;
      private bool[] BC000T6_n334BR_MedicalImaging_ImageHtml ;
      private String[] BC000T6_A514BR_MedicalImaging_MetastasesDX ;
      private bool[] BC000T6_n514BR_MedicalImaging_MetastasesDX ;
      private String[] BC000T6_A515BR_MedicalImaging_MetaLoc ;
      private bool[] BC000T6_n515BR_MedicalImaging_MetaLoc ;
      private DateTime[] BC000T6_A516BR_MedicalImaging_MetaDate ;
      private bool[] BC000T6_n516BR_MedicalImaging_MetaDate ;
      private long[] BC000T6_A19BR_EncounterID ;
      private bool[] BC000T6_n19BR_EncounterID ;
      private long[] BC000T4_A85BR_Information_ID ;
      private bool[] BC000T4_n85BR_Information_ID ;
      private String[] BC000T5_A36BR_Information_PatientNo ;
      private bool[] BC000T5_n36BR_Information_PatientNo ;
      private long[] BC000T7_A225BR_MedicalImagingID ;
      private bool[] BC000T7_n225BR_MedicalImagingID ;
      private long[] BC000T3_A225BR_MedicalImagingID ;
      private bool[] BC000T3_n225BR_MedicalImagingID ;
      private String[] BC000T3_A484BR_MedicalImaging_ImageName_Code ;
      private bool[] BC000T3_n484BR_MedicalImaging_ImageName_Code ;
      private String[] BC000T3_A485BR_MedicalImaging_ImageHosp_Code ;
      private bool[] BC000T3_n485BR_MedicalImaging_ImageHosp_Code ;
      private long[] BC000T3_A227BR_MedicalImaging_ID ;
      private bool[] BC000T3_n227BR_MedicalImaging_ID ;
      private long[] BC000T3_A518BR_MedicalImaging_No ;
      private bool[] BC000T3_n518BR_MedicalImaging_No ;
      private String[] BC000T3_A228BR_MedicalImaging_ImageName ;
      private bool[] BC000T3_n228BR_MedicalImaging_ImageName ;
      private DateTime[] BC000T3_A229BR_MedicalImaging_ImageDate ;
      private bool[] BC000T3_n229BR_MedicalImaging_ImageDate ;
      private String[] BC000T3_A230BR_MedicalImaging_ImageHosp ;
      private bool[] BC000T3_n230BR_MedicalImaging_ImageHosp ;
      private short[] BC000T3_A231BR_MedicalImaging_ImageAge ;
      private bool[] BC000T3_n231BR_MedicalImaging_ImageAge ;
      private String[] BC000T3_A232BR_MedicalImaging_ImageLoc ;
      private bool[] BC000T3_n232BR_MedicalImaging_ImageLoc ;
      private String[] BC000T3_A486BR_MedicalImaging_ImageLoc_Code ;
      private bool[] BC000T3_n486BR_MedicalImaging_ImageLoc_Code ;
      private String[] BC000T3_A233BR_MedicalImaging_ImageOrgan ;
      private bool[] BC000T3_n233BR_MedicalImaging_ImageOrgan ;
      private String[] BC000T3_A234BR_MedicalImaging_PreImageDiag ;
      private bool[] BC000T3_n234BR_MedicalImaging_PreImageDiag ;
      private String[] BC000T3_A235BR_MedicalImaging_ImageDes ;
      private bool[] BC000T3_n235BR_MedicalImaging_ImageDes ;
      private String[] BC000T3_A236BR_MedicalImaging_TumorSize ;
      private bool[] BC000T3_n236BR_MedicalImaging_TumorSize ;
      private String[] BC000T3_A334BR_MedicalImaging_ImageHtml ;
      private bool[] BC000T3_n334BR_MedicalImaging_ImageHtml ;
      private String[] BC000T3_A514BR_MedicalImaging_MetastasesDX ;
      private bool[] BC000T3_n514BR_MedicalImaging_MetastasesDX ;
      private String[] BC000T3_A515BR_MedicalImaging_MetaLoc ;
      private bool[] BC000T3_n515BR_MedicalImaging_MetaLoc ;
      private DateTime[] BC000T3_A516BR_MedicalImaging_MetaDate ;
      private bool[] BC000T3_n516BR_MedicalImaging_MetaDate ;
      private long[] BC000T3_A19BR_EncounterID ;
      private bool[] BC000T3_n19BR_EncounterID ;
      private long[] BC000T2_A225BR_MedicalImagingID ;
      private bool[] BC000T2_n225BR_MedicalImagingID ;
      private String[] BC000T2_A484BR_MedicalImaging_ImageName_Code ;
      private bool[] BC000T2_n484BR_MedicalImaging_ImageName_Code ;
      private String[] BC000T2_A485BR_MedicalImaging_ImageHosp_Code ;
      private bool[] BC000T2_n485BR_MedicalImaging_ImageHosp_Code ;
      private long[] BC000T2_A227BR_MedicalImaging_ID ;
      private bool[] BC000T2_n227BR_MedicalImaging_ID ;
      private long[] BC000T2_A518BR_MedicalImaging_No ;
      private bool[] BC000T2_n518BR_MedicalImaging_No ;
      private String[] BC000T2_A228BR_MedicalImaging_ImageName ;
      private bool[] BC000T2_n228BR_MedicalImaging_ImageName ;
      private DateTime[] BC000T2_A229BR_MedicalImaging_ImageDate ;
      private bool[] BC000T2_n229BR_MedicalImaging_ImageDate ;
      private String[] BC000T2_A230BR_MedicalImaging_ImageHosp ;
      private bool[] BC000T2_n230BR_MedicalImaging_ImageHosp ;
      private short[] BC000T2_A231BR_MedicalImaging_ImageAge ;
      private bool[] BC000T2_n231BR_MedicalImaging_ImageAge ;
      private String[] BC000T2_A232BR_MedicalImaging_ImageLoc ;
      private bool[] BC000T2_n232BR_MedicalImaging_ImageLoc ;
      private String[] BC000T2_A486BR_MedicalImaging_ImageLoc_Code ;
      private bool[] BC000T2_n486BR_MedicalImaging_ImageLoc_Code ;
      private String[] BC000T2_A233BR_MedicalImaging_ImageOrgan ;
      private bool[] BC000T2_n233BR_MedicalImaging_ImageOrgan ;
      private String[] BC000T2_A234BR_MedicalImaging_PreImageDiag ;
      private bool[] BC000T2_n234BR_MedicalImaging_PreImageDiag ;
      private String[] BC000T2_A235BR_MedicalImaging_ImageDes ;
      private bool[] BC000T2_n235BR_MedicalImaging_ImageDes ;
      private String[] BC000T2_A236BR_MedicalImaging_TumorSize ;
      private bool[] BC000T2_n236BR_MedicalImaging_TumorSize ;
      private String[] BC000T2_A334BR_MedicalImaging_ImageHtml ;
      private bool[] BC000T2_n334BR_MedicalImaging_ImageHtml ;
      private String[] BC000T2_A514BR_MedicalImaging_MetastasesDX ;
      private bool[] BC000T2_n514BR_MedicalImaging_MetastasesDX ;
      private String[] BC000T2_A515BR_MedicalImaging_MetaLoc ;
      private bool[] BC000T2_n515BR_MedicalImaging_MetaLoc ;
      private DateTime[] BC000T2_A516BR_MedicalImaging_MetaDate ;
      private bool[] BC000T2_n516BR_MedicalImaging_MetaDate ;
      private long[] BC000T2_A19BR_EncounterID ;
      private bool[] BC000T2_n19BR_EncounterID ;
      private long[] BC000T8_A225BR_MedicalImagingID ;
      private bool[] BC000T8_n225BR_MedicalImagingID ;
      private long[] BC000T11_A85BR_Information_ID ;
      private bool[] BC000T11_n85BR_Information_ID ;
      private String[] BC000T12_A36BR_Information_PatientNo ;
      private bool[] BC000T12_n36BR_Information_PatientNo ;
      private long[] BC000T13_A270BR_MedicalImaging_DiagID ;
      private long[] BC000T14_A85BR_Information_ID ;
      private bool[] BC000T14_n85BR_Information_ID ;
      private long[] BC000T14_A225BR_MedicalImagingID ;
      private bool[] BC000T14_n225BR_MedicalImagingID ;
      private String[] BC000T14_A484BR_MedicalImaging_ImageName_Code ;
      private bool[] BC000T14_n484BR_MedicalImaging_ImageName_Code ;
      private String[] BC000T14_A485BR_MedicalImaging_ImageHosp_Code ;
      private bool[] BC000T14_n485BR_MedicalImaging_ImageHosp_Code ;
      private String[] BC000T14_A36BR_Information_PatientNo ;
      private bool[] BC000T14_n36BR_Information_PatientNo ;
      private long[] BC000T14_A227BR_MedicalImaging_ID ;
      private bool[] BC000T14_n227BR_MedicalImaging_ID ;
      private long[] BC000T14_A518BR_MedicalImaging_No ;
      private bool[] BC000T14_n518BR_MedicalImaging_No ;
      private String[] BC000T14_A228BR_MedicalImaging_ImageName ;
      private bool[] BC000T14_n228BR_MedicalImaging_ImageName ;
      private DateTime[] BC000T14_A229BR_MedicalImaging_ImageDate ;
      private bool[] BC000T14_n229BR_MedicalImaging_ImageDate ;
      private String[] BC000T14_A230BR_MedicalImaging_ImageHosp ;
      private bool[] BC000T14_n230BR_MedicalImaging_ImageHosp ;
      private short[] BC000T14_A231BR_MedicalImaging_ImageAge ;
      private bool[] BC000T14_n231BR_MedicalImaging_ImageAge ;
      private String[] BC000T14_A232BR_MedicalImaging_ImageLoc ;
      private bool[] BC000T14_n232BR_MedicalImaging_ImageLoc ;
      private String[] BC000T14_A486BR_MedicalImaging_ImageLoc_Code ;
      private bool[] BC000T14_n486BR_MedicalImaging_ImageLoc_Code ;
      private String[] BC000T14_A233BR_MedicalImaging_ImageOrgan ;
      private bool[] BC000T14_n233BR_MedicalImaging_ImageOrgan ;
      private String[] BC000T14_A234BR_MedicalImaging_PreImageDiag ;
      private bool[] BC000T14_n234BR_MedicalImaging_PreImageDiag ;
      private String[] BC000T14_A235BR_MedicalImaging_ImageDes ;
      private bool[] BC000T14_n235BR_MedicalImaging_ImageDes ;
      private String[] BC000T14_A236BR_MedicalImaging_TumorSize ;
      private bool[] BC000T14_n236BR_MedicalImaging_TumorSize ;
      private String[] BC000T14_A334BR_MedicalImaging_ImageHtml ;
      private bool[] BC000T14_n334BR_MedicalImaging_ImageHtml ;
      private String[] BC000T14_A514BR_MedicalImaging_MetastasesDX ;
      private bool[] BC000T14_n514BR_MedicalImaging_MetastasesDX ;
      private String[] BC000T14_A515BR_MedicalImaging_MetaLoc ;
      private bool[] BC000T14_n515BR_MedicalImaging_MetaLoc ;
      private DateTime[] BC000T14_A516BR_MedicalImaging_MetaDate ;
      private bool[] BC000T14_n516BR_MedicalImaging_MetaDate ;
      private long[] BC000T14_A19BR_EncounterID ;
      private bool[] BC000T14_n19BR_EncounterID ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_datastore1 ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV8WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV11TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV14TrnContextAtt ;
   }

   public class br_medicalimaging_bc__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class br_medicalimaging_bc__default : DataStoreHelperBase, IDataStoreHelper
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
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmBC000T6 ;
        prmBC000T6 = new Object[] {
        new Object[] {"@BR_MedicalImagingID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000T4 ;
        prmBC000T4 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000T5 ;
        prmBC000T5 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000T7 ;
        prmBC000T7 = new Object[] {
        new Object[] {"@BR_MedicalImagingID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000T3 ;
        prmBC000T3 = new Object[] {
        new Object[] {"@BR_MedicalImagingID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000T2 ;
        prmBC000T2 = new Object[] {
        new Object[] {"@BR_MedicalImagingID",SqlDbType.Decimal,18,0}
        } ;
        /* Definition of BR_MedicalImaging_ImageLoc changed to svchar length 4000 decimals 0 */
        /* Definition of BR_MedicalImaging_ImageOrgan changed to svchar length 4000 decimals 0 */
        /* Definition of BR_MedicalImaging_ImageDes changed to svchar length 4000 decimals 0 */
        Object[] prmBC000T8 ;
        prmBC000T8 = new Object[] {
        new Object[] {"@BR_MedicalImaging_ImageName_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_MedicalImaging_ImageHosp_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_MedicalImaging_ID",SqlDbType.Decimal,10,0} ,
        new Object[] {"@BR_MedicalImaging_No",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_MedicalImaging_ImageName",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_MedicalImaging_ImageDate",SqlDbType.DateTime,8,0} ,
        new Object[] {"@BR_MedicalImaging_ImageHosp",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_MedicalImaging_ImageAge",SqlDbType.SmallInt,3,0} ,
        new Object[] {"@BR_MedicalImaging_ImageLoc",SqlDbType.NVarChar,4000,0} ,
        new Object[] {"@BR_MedicalImaging_ImageLoc_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_MedicalImaging_ImageOrgan",SqlDbType.NVarChar,4000,0} ,
        new Object[] {"@BR_MedicalImaging_PreImageDiag",SqlDbType.NVarChar,4000,0} ,
        new Object[] {"@BR_MedicalImaging_ImageDes",SqlDbType.NVarChar,4000,0} ,
        new Object[] {"@BR_MedicalImaging_TumorSize",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_MedicalImaging_ImageHtml",SqlDbType.NVarChar,2097152,0} ,
        new Object[] {"@BR_MedicalImaging_MetastasesDX",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_MedicalImaging_MetaLoc",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_MedicalImaging_MetaDate",SqlDbType.DateTime,8,0} ,
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        /* Definition of BR_MedicalImaging_ImageLoc changed to svchar length 4000 decimals 0 */
        /* Definition of BR_MedicalImaging_ImageOrgan changed to svchar length 4000 decimals 0 */
        /* Definition of BR_MedicalImaging_ImageDes changed to svchar length 4000 decimals 0 */
        Object[] prmBC000T9 ;
        prmBC000T9 = new Object[] {
        new Object[] {"@BR_MedicalImaging_ImageName_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_MedicalImaging_ImageHosp_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_MedicalImaging_ID",SqlDbType.Decimal,10,0} ,
        new Object[] {"@BR_MedicalImaging_No",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_MedicalImaging_ImageName",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_MedicalImaging_ImageDate",SqlDbType.DateTime,8,0} ,
        new Object[] {"@BR_MedicalImaging_ImageHosp",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_MedicalImaging_ImageAge",SqlDbType.SmallInt,3,0} ,
        new Object[] {"@BR_MedicalImaging_ImageLoc",SqlDbType.NVarChar,4000,0} ,
        new Object[] {"@BR_MedicalImaging_ImageLoc_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_MedicalImaging_ImageOrgan",SqlDbType.NVarChar,4000,0} ,
        new Object[] {"@BR_MedicalImaging_PreImageDiag",SqlDbType.NVarChar,4000,0} ,
        new Object[] {"@BR_MedicalImaging_ImageDes",SqlDbType.NVarChar,4000,0} ,
        new Object[] {"@BR_MedicalImaging_TumorSize",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_MedicalImaging_ImageHtml",SqlDbType.NVarChar,2097152,0} ,
        new Object[] {"@BR_MedicalImaging_MetastasesDX",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_MedicalImaging_MetaLoc",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_MedicalImaging_MetaDate",SqlDbType.DateTime,8,0} ,
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_MedicalImagingID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000T10 ;
        prmBC000T10 = new Object[] {
        new Object[] {"@BR_MedicalImagingID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000T11 ;
        prmBC000T11 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000T12 ;
        prmBC000T12 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000T13 ;
        prmBC000T13 = new Object[] {
        new Object[] {"@BR_MedicalImagingID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000T14 ;
        prmBC000T14 = new Object[] {
        new Object[] {"@BR_MedicalImagingID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("BC000T2", "SELECT [BR_MedicalImagingID], [BR_MedicalImaging_ImageName_Code], [BR_MedicalImaging_ImageHosp_Code], [BR_MedicalImaging_ID], [BR_MedicalImaging_No], [BR_MedicalImaging_ImageName], [BR_MedicalImaging_ImageDate], [BR_MedicalImaging_ImageHosp], [BR_MedicalImaging_ImageAge], [BR_MedicalImaging_ImageLoc], [BR_MedicalImaging_ImageLoc_Code], [BR_MedicalImaging_ImageOrgan], [BR_MedicalImaging_PreImageDiag], [BR_MedicalImaging_ImageDes], [BR_MedicalImaging_TumorSize], [BR_MedicalImaging_ImageHtml], [BR_MedicalImaging_MetastasesDX], [BR_MedicalImaging_MetaLoc], [BR_MedicalImaging_MetaDate], [BR_EncounterID] FROM [BR_MedicalImaging] WITH (UPDLOCK) WHERE [BR_MedicalImagingID] = @BR_MedicalImagingID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000T2,1,0,true,false )
           ,new CursorDef("BC000T3", "SELECT [BR_MedicalImagingID], [BR_MedicalImaging_ImageName_Code], [BR_MedicalImaging_ImageHosp_Code], [BR_MedicalImaging_ID], [BR_MedicalImaging_No], [BR_MedicalImaging_ImageName], [BR_MedicalImaging_ImageDate], [BR_MedicalImaging_ImageHosp], [BR_MedicalImaging_ImageAge], [BR_MedicalImaging_ImageLoc], [BR_MedicalImaging_ImageLoc_Code], [BR_MedicalImaging_ImageOrgan], [BR_MedicalImaging_PreImageDiag], [BR_MedicalImaging_ImageDes], [BR_MedicalImaging_TumorSize], [BR_MedicalImaging_ImageHtml], [BR_MedicalImaging_MetastasesDX], [BR_MedicalImaging_MetaLoc], [BR_MedicalImaging_MetaDate], [BR_EncounterID] FROM [BR_MedicalImaging] WITH (NOLOCK) WHERE [BR_MedicalImagingID] = @BR_MedicalImagingID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000T3,1,0,true,false )
           ,new CursorDef("BC000T4", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000T4,1,0,true,false )
           ,new CursorDef("BC000T5", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000T5,1,0,true,false )
           ,new CursorDef("BC000T6", "SELECT T2.[BR_Information_ID], TM1.[BR_MedicalImagingID], TM1.[BR_MedicalImaging_ImageName_Code], TM1.[BR_MedicalImaging_ImageHosp_Code], T3.[BR_Information_PatientNo], TM1.[BR_MedicalImaging_ID], TM1.[BR_MedicalImaging_No], TM1.[BR_MedicalImaging_ImageName], TM1.[BR_MedicalImaging_ImageDate], TM1.[BR_MedicalImaging_ImageHosp], TM1.[BR_MedicalImaging_ImageAge], TM1.[BR_MedicalImaging_ImageLoc], TM1.[BR_MedicalImaging_ImageLoc_Code], TM1.[BR_MedicalImaging_ImageOrgan], TM1.[BR_MedicalImaging_PreImageDiag], TM1.[BR_MedicalImaging_ImageDes], TM1.[BR_MedicalImaging_TumorSize], TM1.[BR_MedicalImaging_ImageHtml], TM1.[BR_MedicalImaging_MetastasesDX], TM1.[BR_MedicalImaging_MetaLoc], TM1.[BR_MedicalImaging_MetaDate], TM1.[BR_EncounterID] FROM (([BR_MedicalImaging] TM1 WITH (NOLOCK) LEFT JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = TM1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID]) WHERE TM1.[BR_MedicalImagingID] = @BR_MedicalImagingID ORDER BY TM1.[BR_MedicalImagingID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000T6,100,0,true,false )
           ,new CursorDef("BC000T7", "SELECT [BR_MedicalImagingID] FROM [BR_MedicalImaging] WITH (NOLOCK) WHERE [BR_MedicalImagingID] = @BR_MedicalImagingID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000T7,1,0,true,false )
           ,new CursorDef("BC000T8", "INSERT INTO [BR_MedicalImaging]([BR_MedicalImaging_ImageName_Code], [BR_MedicalImaging_ImageHosp_Code], [BR_MedicalImaging_ID], [BR_MedicalImaging_No], [BR_MedicalImaging_ImageName], [BR_MedicalImaging_ImageDate], [BR_MedicalImaging_ImageHosp], [BR_MedicalImaging_ImageAge], [BR_MedicalImaging_ImageLoc], [BR_MedicalImaging_ImageLoc_Code], [BR_MedicalImaging_ImageOrgan], [BR_MedicalImaging_PreImageDiag], [BR_MedicalImaging_ImageDes], [BR_MedicalImaging_TumorSize], [BR_MedicalImaging_ImageHtml], [BR_MedicalImaging_MetastasesDX], [BR_MedicalImaging_MetaLoc], [BR_MedicalImaging_MetaDate], [BR_EncounterID]) VALUES(@BR_MedicalImaging_ImageName_Code, @BR_MedicalImaging_ImageHosp_Code, @BR_MedicalImaging_ID, @BR_MedicalImaging_No, @BR_MedicalImaging_ImageName, @BR_MedicalImaging_ImageDate, @BR_MedicalImaging_ImageHosp, @BR_MedicalImaging_ImageAge, @BR_MedicalImaging_ImageLoc, @BR_MedicalImaging_ImageLoc_Code, @BR_MedicalImaging_ImageOrgan, @BR_MedicalImaging_PreImageDiag, @BR_MedicalImaging_ImageDes, @BR_MedicalImaging_TumorSize, @BR_MedicalImaging_ImageHtml, @BR_MedicalImaging_MetastasesDX, @BR_MedicalImaging_MetaLoc, @BR_MedicalImaging_MetaDate, @BR_EncounterID); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmBC000T8)
           ,new CursorDef("BC000T9", "UPDATE [BR_MedicalImaging] SET [BR_MedicalImaging_ImageName_Code]=@BR_MedicalImaging_ImageName_Code, [BR_MedicalImaging_ImageHosp_Code]=@BR_MedicalImaging_ImageHosp_Code, [BR_MedicalImaging_ID]=@BR_MedicalImaging_ID, [BR_MedicalImaging_No]=@BR_MedicalImaging_No, [BR_MedicalImaging_ImageName]=@BR_MedicalImaging_ImageName, [BR_MedicalImaging_ImageDate]=@BR_MedicalImaging_ImageDate, [BR_MedicalImaging_ImageHosp]=@BR_MedicalImaging_ImageHosp, [BR_MedicalImaging_ImageAge]=@BR_MedicalImaging_ImageAge, [BR_MedicalImaging_ImageLoc]=@BR_MedicalImaging_ImageLoc, [BR_MedicalImaging_ImageLoc_Code]=@BR_MedicalImaging_ImageLoc_Code, [BR_MedicalImaging_ImageOrgan]=@BR_MedicalImaging_ImageOrgan, [BR_MedicalImaging_PreImageDiag]=@BR_MedicalImaging_PreImageDiag, [BR_MedicalImaging_ImageDes]=@BR_MedicalImaging_ImageDes, [BR_MedicalImaging_TumorSize]=@BR_MedicalImaging_TumorSize, [BR_MedicalImaging_ImageHtml]=@BR_MedicalImaging_ImageHtml, [BR_MedicalImaging_MetastasesDX]=@BR_MedicalImaging_MetastasesDX, [BR_MedicalImaging_MetaLoc]=@BR_MedicalImaging_MetaLoc, [BR_MedicalImaging_MetaDate]=@BR_MedicalImaging_MetaDate, [BR_EncounterID]=@BR_EncounterID  WHERE [BR_MedicalImagingID] = @BR_MedicalImagingID", GxErrorMask.GX_NOMASK,prmBC000T9)
           ,new CursorDef("BC000T10", "DELETE FROM [BR_MedicalImaging]  WHERE [BR_MedicalImagingID] = @BR_MedicalImagingID", GxErrorMask.GX_NOMASK,prmBC000T10)
           ,new CursorDef("BC000T11", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000T11,1,0,true,false )
           ,new CursorDef("BC000T12", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000T12,1,0,true,false )
           ,new CursorDef("BC000T13", "SELECT TOP 1 [BR_MedicalImaging_DiagID] FROM [BR_MedicalImaging_Diag] WITH (NOLOCK) WHERE [BR_MedicalImagingID] = @BR_MedicalImagingID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000T13,1,0,true,true )
           ,new CursorDef("BC000T14", "SELECT T2.[BR_Information_ID], TM1.[BR_MedicalImagingID], TM1.[BR_MedicalImaging_ImageName_Code], TM1.[BR_MedicalImaging_ImageHosp_Code], T3.[BR_Information_PatientNo], TM1.[BR_MedicalImaging_ID], TM1.[BR_MedicalImaging_No], TM1.[BR_MedicalImaging_ImageName], TM1.[BR_MedicalImaging_ImageDate], TM1.[BR_MedicalImaging_ImageHosp], TM1.[BR_MedicalImaging_ImageAge], TM1.[BR_MedicalImaging_ImageLoc], TM1.[BR_MedicalImaging_ImageLoc_Code], TM1.[BR_MedicalImaging_ImageOrgan], TM1.[BR_MedicalImaging_PreImageDiag], TM1.[BR_MedicalImaging_ImageDes], TM1.[BR_MedicalImaging_TumorSize], TM1.[BR_MedicalImaging_ImageHtml], TM1.[BR_MedicalImaging_MetastasesDX], TM1.[BR_MedicalImaging_MetaLoc], TM1.[BR_MedicalImaging_MetaDate], TM1.[BR_EncounterID] FROM (([BR_MedicalImaging] TM1 WITH (NOLOCK) LEFT JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = TM1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID]) WHERE TM1.[BR_MedicalImagingID] = @BR_MedicalImagingID ORDER BY TM1.[BR_MedicalImagingID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000T14,100,0,true,false )
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
              ((long[]) buf[5])[0] = rslt.getLong(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((long[]) buf[7])[0] = rslt.getLong(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((DateTime[]) buf[11])[0] = rslt.getGXDate(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((short[]) buf[15])[0] = rslt.getShort(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((String[]) buf[17])[0] = rslt.getVarchar(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              ((String[]) buf[19])[0] = rslt.getVarchar(11) ;
              ((bool[]) buf[20])[0] = rslt.wasNull(11);
              ((String[]) buf[21])[0] = rslt.getVarchar(12) ;
              ((bool[]) buf[22])[0] = rslt.wasNull(12);
              ((String[]) buf[23])[0] = rslt.getVarchar(13) ;
              ((bool[]) buf[24])[0] = rslt.wasNull(13);
              ((String[]) buf[25])[0] = rslt.getVarchar(14) ;
              ((bool[]) buf[26])[0] = rslt.wasNull(14);
              ((String[]) buf[27])[0] = rslt.getVarchar(15) ;
              ((bool[]) buf[28])[0] = rslt.wasNull(15);
              ((String[]) buf[29])[0] = rslt.getLongVarchar(16) ;
              ((bool[]) buf[30])[0] = rslt.wasNull(16);
              ((String[]) buf[31])[0] = rslt.getVarchar(17) ;
              ((bool[]) buf[32])[0] = rslt.wasNull(17);
              ((String[]) buf[33])[0] = rslt.getVarchar(18) ;
              ((bool[]) buf[34])[0] = rslt.wasNull(18);
              ((DateTime[]) buf[35])[0] = rslt.getGXDate(19) ;
              ((bool[]) buf[36])[0] = rslt.wasNull(19);
              ((long[]) buf[37])[0] = rslt.getLong(20) ;
              ((bool[]) buf[38])[0] = rslt.wasNull(20);
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((long[]) buf[5])[0] = rslt.getLong(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((long[]) buf[7])[0] = rslt.getLong(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((DateTime[]) buf[11])[0] = rslt.getGXDate(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((short[]) buf[15])[0] = rslt.getShort(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((String[]) buf[17])[0] = rslt.getVarchar(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              ((String[]) buf[19])[0] = rslt.getVarchar(11) ;
              ((bool[]) buf[20])[0] = rslt.wasNull(11);
              ((String[]) buf[21])[0] = rslt.getVarchar(12) ;
              ((bool[]) buf[22])[0] = rslt.wasNull(12);
              ((String[]) buf[23])[0] = rslt.getVarchar(13) ;
              ((bool[]) buf[24])[0] = rslt.wasNull(13);
              ((String[]) buf[25])[0] = rslt.getVarchar(14) ;
              ((bool[]) buf[26])[0] = rslt.wasNull(14);
              ((String[]) buf[27])[0] = rslt.getVarchar(15) ;
              ((bool[]) buf[28])[0] = rslt.wasNull(15);
              ((String[]) buf[29])[0] = rslt.getLongVarchar(16) ;
              ((bool[]) buf[30])[0] = rslt.wasNull(16);
              ((String[]) buf[31])[0] = rslt.getVarchar(17) ;
              ((bool[]) buf[32])[0] = rslt.wasNull(17);
              ((String[]) buf[33])[0] = rslt.getVarchar(18) ;
              ((bool[]) buf[34])[0] = rslt.wasNull(18);
              ((DateTime[]) buf[35])[0] = rslt.getGXDate(19) ;
              ((bool[]) buf[36])[0] = rslt.wasNull(19);
              ((long[]) buf[37])[0] = rslt.getLong(20) ;
              ((bool[]) buf[38])[0] = rslt.wasNull(20);
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
              ((long[]) buf[9])[0] = rslt.getLong(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((long[]) buf[11])[0] = rslt.getLong(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((DateTime[]) buf[15])[0] = rslt.getGXDate(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((String[]) buf[17])[0] = rslt.getVarchar(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              ((short[]) buf[19])[0] = rslt.getShort(11) ;
              ((bool[]) buf[20])[0] = rslt.wasNull(11);
              ((String[]) buf[21])[0] = rslt.getVarchar(12) ;
              ((bool[]) buf[22])[0] = rslt.wasNull(12);
              ((String[]) buf[23])[0] = rslt.getVarchar(13) ;
              ((bool[]) buf[24])[0] = rslt.wasNull(13);
              ((String[]) buf[25])[0] = rslt.getVarchar(14) ;
              ((bool[]) buf[26])[0] = rslt.wasNull(14);
              ((String[]) buf[27])[0] = rslt.getVarchar(15) ;
              ((bool[]) buf[28])[0] = rslt.wasNull(15);
              ((String[]) buf[29])[0] = rslt.getVarchar(16) ;
              ((bool[]) buf[30])[0] = rslt.wasNull(16);
              ((String[]) buf[31])[0] = rslt.getVarchar(17) ;
              ((bool[]) buf[32])[0] = rslt.wasNull(17);
              ((String[]) buf[33])[0] = rslt.getLongVarchar(18) ;
              ((bool[]) buf[34])[0] = rslt.wasNull(18);
              ((String[]) buf[35])[0] = rslt.getVarchar(19) ;
              ((bool[]) buf[36])[0] = rslt.wasNull(19);
              ((String[]) buf[37])[0] = rslt.getVarchar(20) ;
              ((bool[]) buf[38])[0] = rslt.wasNull(20);
              ((DateTime[]) buf[39])[0] = rslt.getGXDate(21) ;
              ((bool[]) buf[40])[0] = rslt.wasNull(21);
              ((long[]) buf[41])[0] = rslt.getLong(22) ;
              ((bool[]) buf[42])[0] = rslt.wasNull(22);
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
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              ((long[]) buf[2])[0] = rslt.getLong(2) ;
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((long[]) buf[9])[0] = rslt.getLong(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((long[]) buf[11])[0] = rslt.getLong(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((DateTime[]) buf[15])[0] = rslt.getGXDate(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((String[]) buf[17])[0] = rslt.getVarchar(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              ((short[]) buf[19])[0] = rslt.getShort(11) ;
              ((bool[]) buf[20])[0] = rslt.wasNull(11);
              ((String[]) buf[21])[0] = rslt.getVarchar(12) ;
              ((bool[]) buf[22])[0] = rslt.wasNull(12);
              ((String[]) buf[23])[0] = rslt.getVarchar(13) ;
              ((bool[]) buf[24])[0] = rslt.wasNull(13);
              ((String[]) buf[25])[0] = rslt.getVarchar(14) ;
              ((bool[]) buf[26])[0] = rslt.wasNull(14);
              ((String[]) buf[27])[0] = rslt.getVarchar(15) ;
              ((bool[]) buf[28])[0] = rslt.wasNull(15);
              ((String[]) buf[29])[0] = rslt.getVarchar(16) ;
              ((bool[]) buf[30])[0] = rslt.wasNull(16);
              ((String[]) buf[31])[0] = rslt.getVarchar(17) ;
              ((bool[]) buf[32])[0] = rslt.wasNull(17);
              ((String[]) buf[33])[0] = rslt.getLongVarchar(18) ;
              ((bool[]) buf[34])[0] = rslt.wasNull(18);
              ((String[]) buf[35])[0] = rslt.getVarchar(19) ;
              ((bool[]) buf[36])[0] = rslt.wasNull(19);
              ((String[]) buf[37])[0] = rslt.getVarchar(20) ;
              ((bool[]) buf[38])[0] = rslt.wasNull(20);
              ((DateTime[]) buf[39])[0] = rslt.getGXDate(21) ;
              ((bool[]) buf[40])[0] = rslt.wasNull(21);
              ((long[]) buf[41])[0] = rslt.getLong(22) ;
              ((bool[]) buf[42])[0] = rslt.wasNull(22);
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
                 stmt.setNull( 3 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(3, (long)parms[5]);
              }
              if ( (bool)parms[6] )
              {
                 stmt.setNull( 4 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(4, (long)parms[7]);
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
                 stmt.setNull( 6 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameter(6, (DateTime)parms[11]);
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
                 stmt.setNull( 8 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(8, (short)parms[15]);
              }
              if ( (bool)parms[16] )
              {
                 stmt.setNull( 9 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(9, (String)parms[17]);
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
                 stmt.setNull( 13 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(13, (String)parms[25]);
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
                 stmt.setNull( 18 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameter(18, (DateTime)parms[35]);
              }
              if ( (bool)parms[36] )
              {
                 stmt.setNull( 19 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(19, (long)parms[37]);
              }
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
                 stmt.setNull( 3 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(3, (long)parms[5]);
              }
              if ( (bool)parms[6] )
              {
                 stmt.setNull( 4 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(4, (long)parms[7]);
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
                 stmt.setNull( 6 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameter(6, (DateTime)parms[11]);
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
                 stmt.setNull( 8 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(8, (short)parms[15]);
              }
              if ( (bool)parms[16] )
              {
                 stmt.setNull( 9 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(9, (String)parms[17]);
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
                 stmt.setNull( 13 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(13, (String)parms[25]);
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
                 stmt.setNull( 18 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameter(18, (DateTime)parms[35]);
              }
              if ( (bool)parms[36] )
              {
                 stmt.setNull( 19 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(19, (long)parms[37]);
              }
              if ( (bool)parms[38] )
              {
                 stmt.setNull( 20 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(20, (long)parms[39]);
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
     }
  }

}

}
