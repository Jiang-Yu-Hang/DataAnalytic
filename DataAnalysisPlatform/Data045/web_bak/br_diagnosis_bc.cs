/*
               File: BR_Diagnosis_BC
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:36:21.79
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
   public class br_diagnosis_bc : GXHttpHandler, IGxSilentTrn
   {
      public br_diagnosis_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_diagnosis_bc( IGxContext context )
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
         ReadRow0C13( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey0C13( ) ;
         standaloneModal( ) ;
         AddRow0C13( ) ;
         Gx_mode = "INS";
         return  ;
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E110C2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               Z64BR_DiagnosisID = A64BR_DiagnosisID;
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

      protected void CONFIRM_0C0( )
      {
         BeforeValidate0C13( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0C13( ) ;
            }
            else
            {
               CheckExtendedTable0C13( ) ;
               if ( AnyError == 0 )
               {
                  ZM0C13( 20) ;
                  ZM0C13( 21) ;
               }
               CloseExtendedTableCursors0C13( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void E120C2( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV7WWPContext) ;
         AV13IsAuthorized = true;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            GXt_boolean1 = AV13IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Diagnosis", out  GXt_boolean1) ;
            AV13IsAuthorized = GXt_boolean1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            GXt_boolean1 = AV13IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Diagnosis", out  GXt_boolean1) ;
            AV13IsAuthorized = GXt_boolean1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            GXt_boolean1 = AV13IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Diagnosis", out  GXt_boolean1) ;
            AV13IsAuthorized = GXt_boolean1;
         }
         if ( ! AV13IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV16Pgmname)));
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
         if ( ( StringUtil.StrCmp(AV8TrnContext.gxTpr_Transactionname, AV16Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV17GXV1 = 1;
            while ( AV17GXV1 <= AV8TrnContext.gxTpr_Attributes.Count )
            {
               AV11TrnContextAtt = ((GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute)AV8TrnContext.gxTpr_Attributes.Item(AV17GXV1));
               if ( StringUtil.StrCmp(AV11TrnContextAtt.gxTpr_Attributename, "BR_EncounterID") == 0 )
               {
                  AV10Insert_BR_EncounterID = (long)(NumberUtil.Val( AV11TrnContextAtt.gxTpr_Attributevalue, "."));
               }
               AV17GXV1 = (int)(AV17GXV1+1);
            }
         }
      }

      protected void E110C2( )
      {
         /* After Trn Routine */
      }

      protected void S112( )
      {
         /* 'ATTRIBUTESSECURITYCODE' Routine */
      }

      protected void ZM0C13( short GX_JID )
      {
         if ( ( GX_JID == 19 ) || ( GX_JID == 0 ) )
         {
            Z466BR_Diagnosis_DXType_Code = A466BR_Diagnosis_DXType_Code;
            Z467BR_Diagnosis_DXTsource_Code = A467BR_Diagnosis_DXTsource_Code;
            Z503BR_Diagnosis_InitialDX_Code = A503BR_Diagnosis_InitialDX_Code;
            Z504BR_Diagnosis_MetastasesDX_Code = A504BR_Diagnosis_MetastasesDX_Code;
            Z513BR_Diagnosis_No = A513BR_Diagnosis_No;
            Z65BR_Diagnosis_DXID = A65BR_Diagnosis_DXID;
            Z66BR_Diagnosis_DXCode = A66BR_Diagnosis_DXCode;
            Z67BR_Diagnosis_DXType = A67BR_Diagnosis_DXType;
            Z68BR_Diagnosis_DXTsource = A68BR_Diagnosis_DXTsource;
            Z69BR_Diagnosis_DXDescription = A69BR_Diagnosis_DXDescription;
            Z70BR_Diagnosis_InitialDX = A70BR_Diagnosis_InitialDX;
            Z71BR_Diagnosis_MetastasesDX = A71BR_Diagnosis_MetastasesDX;
            Z260BR_Diagnosis_DXSource = A260BR_Diagnosis_DXSource;
            Z569BR_Diagnosis_TumorStageClinical = A569BR_Diagnosis_TumorStageClinical;
            Z19BR_EncounterID = A19BR_EncounterID;
         }
         if ( ( GX_JID == 20 ) || ( GX_JID == 0 ) )
         {
            Z85BR_Information_ID = A85BR_Information_ID;
         }
         if ( ( GX_JID == 21 ) || ( GX_JID == 0 ) )
         {
            Z36BR_Information_PatientNo = A36BR_Information_PatientNo;
         }
         if ( GX_JID == -19 )
         {
            Z64BR_DiagnosisID = A64BR_DiagnosisID;
            Z466BR_Diagnosis_DXType_Code = A466BR_Diagnosis_DXType_Code;
            Z467BR_Diagnosis_DXTsource_Code = A467BR_Diagnosis_DXTsource_Code;
            Z503BR_Diagnosis_InitialDX_Code = A503BR_Diagnosis_InitialDX_Code;
            Z504BR_Diagnosis_MetastasesDX_Code = A504BR_Diagnosis_MetastasesDX_Code;
            Z513BR_Diagnosis_No = A513BR_Diagnosis_No;
            Z65BR_Diagnosis_DXID = A65BR_Diagnosis_DXID;
            Z66BR_Diagnosis_DXCode = A66BR_Diagnosis_DXCode;
            Z67BR_Diagnosis_DXType = A67BR_Diagnosis_DXType;
            Z68BR_Diagnosis_DXTsource = A68BR_Diagnosis_DXTsource;
            Z69BR_Diagnosis_DXDescription = A69BR_Diagnosis_DXDescription;
            Z70BR_Diagnosis_InitialDX = A70BR_Diagnosis_InitialDX;
            Z71BR_Diagnosis_MetastasesDX = A71BR_Diagnosis_MetastasesDX;
            Z260BR_Diagnosis_DXSource = A260BR_Diagnosis_DXSource;
            Z569BR_Diagnosis_TumorStageClinical = A569BR_Diagnosis_TumorStageClinical;
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

      protected void Load0C13( )
      {
         /* Using cursor BC000C6 */
         pr_default.execute(4, new Object[] {A64BR_DiagnosisID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound13 = 1;
            A85BR_Information_ID = BC000C6_A85BR_Information_ID[0];
            n85BR_Information_ID = BC000C6_n85BR_Information_ID[0];
            A466BR_Diagnosis_DXType_Code = BC000C6_A466BR_Diagnosis_DXType_Code[0];
            n466BR_Diagnosis_DXType_Code = BC000C6_n466BR_Diagnosis_DXType_Code[0];
            A467BR_Diagnosis_DXTsource_Code = BC000C6_A467BR_Diagnosis_DXTsource_Code[0];
            n467BR_Diagnosis_DXTsource_Code = BC000C6_n467BR_Diagnosis_DXTsource_Code[0];
            A503BR_Diagnosis_InitialDX_Code = BC000C6_A503BR_Diagnosis_InitialDX_Code[0];
            n503BR_Diagnosis_InitialDX_Code = BC000C6_n503BR_Diagnosis_InitialDX_Code[0];
            A504BR_Diagnosis_MetastasesDX_Code = BC000C6_A504BR_Diagnosis_MetastasesDX_Code[0];
            n504BR_Diagnosis_MetastasesDX_Code = BC000C6_n504BR_Diagnosis_MetastasesDX_Code[0];
            A36BR_Information_PatientNo = BC000C6_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = BC000C6_n36BR_Information_PatientNo[0];
            A513BR_Diagnosis_No = BC000C6_A513BR_Diagnosis_No[0];
            n513BR_Diagnosis_No = BC000C6_n513BR_Diagnosis_No[0];
            A65BR_Diagnosis_DXID = BC000C6_A65BR_Diagnosis_DXID[0];
            n65BR_Diagnosis_DXID = BC000C6_n65BR_Diagnosis_DXID[0];
            A66BR_Diagnosis_DXCode = BC000C6_A66BR_Diagnosis_DXCode[0];
            n66BR_Diagnosis_DXCode = BC000C6_n66BR_Diagnosis_DXCode[0];
            A67BR_Diagnosis_DXType = BC000C6_A67BR_Diagnosis_DXType[0];
            n67BR_Diagnosis_DXType = BC000C6_n67BR_Diagnosis_DXType[0];
            A68BR_Diagnosis_DXTsource = BC000C6_A68BR_Diagnosis_DXTsource[0];
            n68BR_Diagnosis_DXTsource = BC000C6_n68BR_Diagnosis_DXTsource[0];
            A69BR_Diagnosis_DXDescription = BC000C6_A69BR_Diagnosis_DXDescription[0];
            n69BR_Diagnosis_DXDescription = BC000C6_n69BR_Diagnosis_DXDescription[0];
            A70BR_Diagnosis_InitialDX = BC000C6_A70BR_Diagnosis_InitialDX[0];
            n70BR_Diagnosis_InitialDX = BC000C6_n70BR_Diagnosis_InitialDX[0];
            A71BR_Diagnosis_MetastasesDX = BC000C6_A71BR_Diagnosis_MetastasesDX[0];
            n71BR_Diagnosis_MetastasesDX = BC000C6_n71BR_Diagnosis_MetastasesDX[0];
            A260BR_Diagnosis_DXSource = BC000C6_A260BR_Diagnosis_DXSource[0];
            n260BR_Diagnosis_DXSource = BC000C6_n260BR_Diagnosis_DXSource[0];
            A569BR_Diagnosis_TumorStageClinical = BC000C6_A569BR_Diagnosis_TumorStageClinical[0];
            n569BR_Diagnosis_TumorStageClinical = BC000C6_n569BR_Diagnosis_TumorStageClinical[0];
            A19BR_EncounterID = BC000C6_A19BR_EncounterID[0];
            ZM0C13( -19) ;
         }
         pr_default.close(4);
         OnLoadActions0C13( ) ;
      }

      protected void OnLoadActions0C13( )
      {
         AV16Pgmname = "BR_Diagnosis_BC";
      }

      protected void CheckExtendedTable0C13( )
      {
         standaloneModal( ) ;
         AV16Pgmname = "BR_Diagnosis_BC";
         /* Using cursor BC000C4 */
         pr_default.execute(2, new Object[] {A19BR_EncounterID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("不匹配' T15'", "ForeignKeyNotFound", 1, "BR_ENCOUNTERID");
            AnyError = 1;
         }
         A85BR_Information_ID = BC000C4_A85BR_Information_ID[0];
         n85BR_Information_ID = BC000C4_n85BR_Information_ID[0];
         pr_default.close(2);
         /* Using cursor BC000C5 */
         pr_default.execute(3, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
         if ( (pr_default.getStatus(3) == 101) )
         {
            if ( ! ( (0==A85BR_Information_ID) ) )
            {
               GX_msglist.addItem("不匹配' T16'", "ForeignKeyNotFound", 1, "");
               AnyError = 1;
            }
         }
         A36BR_Information_PatientNo = BC000C5_A36BR_Information_PatientNo[0];
         n36BR_Information_PatientNo = BC000C5_n36BR_Information_PatientNo[0];
         pr_default.close(3);
         if ( (0==A513BR_Diagnosis_No) )
         {
            GX_msglist.addItem("诊断次序是必须填写的。", 1, "");
            AnyError = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A68BR_Diagnosis_DXTsource)) )
         {
            GX_msglist.addItem("诊断来源是必须填写的。", 1, "");
            AnyError = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A69BR_Diagnosis_DXDescription)) )
         {
            GX_msglist.addItem("诊断名称是必须填写的。", 1, "");
            AnyError = 1;
         }
         if ( ! ( ( StringUtil.StrCmp(A70BR_Diagnosis_InitialDX, "否") == 0 ) || ( StringUtil.StrCmp(A70BR_Diagnosis_InitialDX, "是") == 0 ) || ( StringUtil.StrCmp(A70BR_Diagnosis_InitialDX, "不详") == 0 ) || String.IsNullOrEmpty(StringUtil.RTrim( A70BR_Diagnosis_InitialDX)) ) )
         {
            GX_msglist.addItem("域���������������������超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
         if ( ! ( ( StringUtil.StrCmp(A71BR_Diagnosis_MetastasesDX, "否") == 0 ) || ( StringUtil.StrCmp(A71BR_Diagnosis_MetastasesDX, "是") == 0 ) || ( StringUtil.StrCmp(A71BR_Diagnosis_MetastasesDX, "不详") == 0 ) || String.IsNullOrEmpty(StringUtil.RTrim( A71BR_Diagnosis_MetastasesDX)) ) )
         {
            GX_msglist.addItem("域���������������������超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
      }

      protected void CloseExtendedTableCursors0C13( )
      {
         pr_default.close(2);
         pr_default.close(3);
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0C13( )
      {
         /* Using cursor BC000C7 */
         pr_default.execute(5, new Object[] {A64BR_DiagnosisID});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound13 = 1;
         }
         else
         {
            RcdFound13 = 0;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC000C3 */
         pr_default.execute(1, new Object[] {A64BR_DiagnosisID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0C13( 19) ;
            RcdFound13 = 1;
            A64BR_DiagnosisID = BC000C3_A64BR_DiagnosisID[0];
            A466BR_Diagnosis_DXType_Code = BC000C3_A466BR_Diagnosis_DXType_Code[0];
            n466BR_Diagnosis_DXType_Code = BC000C3_n466BR_Diagnosis_DXType_Code[0];
            A467BR_Diagnosis_DXTsource_Code = BC000C3_A467BR_Diagnosis_DXTsource_Code[0];
            n467BR_Diagnosis_DXTsource_Code = BC000C3_n467BR_Diagnosis_DXTsource_Code[0];
            A503BR_Diagnosis_InitialDX_Code = BC000C3_A503BR_Diagnosis_InitialDX_Code[0];
            n503BR_Diagnosis_InitialDX_Code = BC000C3_n503BR_Diagnosis_InitialDX_Code[0];
            A504BR_Diagnosis_MetastasesDX_Code = BC000C3_A504BR_Diagnosis_MetastasesDX_Code[0];
            n504BR_Diagnosis_MetastasesDX_Code = BC000C3_n504BR_Diagnosis_MetastasesDX_Code[0];
            A513BR_Diagnosis_No = BC000C3_A513BR_Diagnosis_No[0];
            n513BR_Diagnosis_No = BC000C3_n513BR_Diagnosis_No[0];
            A65BR_Diagnosis_DXID = BC000C3_A65BR_Diagnosis_DXID[0];
            n65BR_Diagnosis_DXID = BC000C3_n65BR_Diagnosis_DXID[0];
            A66BR_Diagnosis_DXCode = BC000C3_A66BR_Diagnosis_DXCode[0];
            n66BR_Diagnosis_DXCode = BC000C3_n66BR_Diagnosis_DXCode[0];
            A67BR_Diagnosis_DXType = BC000C3_A67BR_Diagnosis_DXType[0];
            n67BR_Diagnosis_DXType = BC000C3_n67BR_Diagnosis_DXType[0];
            A68BR_Diagnosis_DXTsource = BC000C3_A68BR_Diagnosis_DXTsource[0];
            n68BR_Diagnosis_DXTsource = BC000C3_n68BR_Diagnosis_DXTsource[0];
            A69BR_Diagnosis_DXDescription = BC000C3_A69BR_Diagnosis_DXDescription[0];
            n69BR_Diagnosis_DXDescription = BC000C3_n69BR_Diagnosis_DXDescription[0];
            A70BR_Diagnosis_InitialDX = BC000C3_A70BR_Diagnosis_InitialDX[0];
            n70BR_Diagnosis_InitialDX = BC000C3_n70BR_Diagnosis_InitialDX[0];
            A71BR_Diagnosis_MetastasesDX = BC000C3_A71BR_Diagnosis_MetastasesDX[0];
            n71BR_Diagnosis_MetastasesDX = BC000C3_n71BR_Diagnosis_MetastasesDX[0];
            A260BR_Diagnosis_DXSource = BC000C3_A260BR_Diagnosis_DXSource[0];
            n260BR_Diagnosis_DXSource = BC000C3_n260BR_Diagnosis_DXSource[0];
            A569BR_Diagnosis_TumorStageClinical = BC000C3_A569BR_Diagnosis_TumorStageClinical[0];
            n569BR_Diagnosis_TumorStageClinical = BC000C3_n569BR_Diagnosis_TumorStageClinical[0];
            A19BR_EncounterID = BC000C3_A19BR_EncounterID[0];
            Z64BR_DiagnosisID = A64BR_DiagnosisID;
            sMode13 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load0C13( ) ;
            if ( AnyError == 1 )
            {
               RcdFound13 = 0;
               InitializeNonKey0C13( ) ;
            }
            Gx_mode = sMode13;
         }
         else
         {
            RcdFound13 = 0;
            InitializeNonKey0C13( ) ;
            sMode13 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode13;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0C13( ) ;
         if ( RcdFound13 == 0 )
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
         CONFIRM_0C0( ) ;
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

      protected void CheckOptimisticConcurrency0C13( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC000C2 */
            pr_default.execute(0, new Object[] {A64BR_DiagnosisID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Diagnosis"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z466BR_Diagnosis_DXType_Code, BC000C2_A466BR_Diagnosis_DXType_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z467BR_Diagnosis_DXTsource_Code, BC000C2_A467BR_Diagnosis_DXTsource_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z503BR_Diagnosis_InitialDX_Code, BC000C2_A503BR_Diagnosis_InitialDX_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z504BR_Diagnosis_MetastasesDX_Code, BC000C2_A504BR_Diagnosis_MetastasesDX_Code[0]) != 0 ) || ( Z513BR_Diagnosis_No != BC000C2_A513BR_Diagnosis_No[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z65BR_Diagnosis_DXID, BC000C2_A65BR_Diagnosis_DXID[0]) != 0 ) || ( StringUtil.StrCmp(Z66BR_Diagnosis_DXCode, BC000C2_A66BR_Diagnosis_DXCode[0]) != 0 ) || ( StringUtil.StrCmp(Z67BR_Diagnosis_DXType, BC000C2_A67BR_Diagnosis_DXType[0]) != 0 ) || ( StringUtil.StrCmp(Z68BR_Diagnosis_DXTsource, BC000C2_A68BR_Diagnosis_DXTsource[0]) != 0 ) || ( StringUtil.StrCmp(Z69BR_Diagnosis_DXDescription, BC000C2_A69BR_Diagnosis_DXDescription[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z70BR_Diagnosis_InitialDX, BC000C2_A70BR_Diagnosis_InitialDX[0]) != 0 ) || ( StringUtil.StrCmp(Z71BR_Diagnosis_MetastasesDX, BC000C2_A71BR_Diagnosis_MetastasesDX[0]) != 0 ) || ( StringUtil.StrCmp(Z260BR_Diagnosis_DXSource, BC000C2_A260BR_Diagnosis_DXSource[0]) != 0 ) || ( StringUtil.StrCmp(Z569BR_Diagnosis_TumorStageClinical, BC000C2_A569BR_Diagnosis_TumorStageClinical[0]) != 0 ) || ( Z19BR_EncounterID != BC000C2_A19BR_EncounterID[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"BR_Diagnosis"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0C13( )
      {
         BeforeValidate0C13( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0C13( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0C13( 0) ;
            CheckOptimisticConcurrency0C13( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0C13( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0C13( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000C8 */
                     pr_default.execute(6, new Object[] {n466BR_Diagnosis_DXType_Code, A466BR_Diagnosis_DXType_Code, n467BR_Diagnosis_DXTsource_Code, A467BR_Diagnosis_DXTsource_Code, n503BR_Diagnosis_InitialDX_Code, A503BR_Diagnosis_InitialDX_Code, n504BR_Diagnosis_MetastasesDX_Code, A504BR_Diagnosis_MetastasesDX_Code, n513BR_Diagnosis_No, A513BR_Diagnosis_No, n65BR_Diagnosis_DXID, A65BR_Diagnosis_DXID, n66BR_Diagnosis_DXCode, A66BR_Diagnosis_DXCode, n67BR_Diagnosis_DXType, A67BR_Diagnosis_DXType, n68BR_Diagnosis_DXTsource, A68BR_Diagnosis_DXTsource, n69BR_Diagnosis_DXDescription, A69BR_Diagnosis_DXDescription, n70BR_Diagnosis_InitialDX, A70BR_Diagnosis_InitialDX, n71BR_Diagnosis_MetastasesDX, A71BR_Diagnosis_MetastasesDX, n260BR_Diagnosis_DXSource, A260BR_Diagnosis_DXSource, n569BR_Diagnosis_TumorStageClinical, A569BR_Diagnosis_TumorStageClinical, A19BR_EncounterID});
                     A64BR_DiagnosisID = BC000C8_A64BR_DiagnosisID[0];
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Diagnosis") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(A64BR_DiagnosisID), 18, 0)),  "诊断",  "Create",  1) ;
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
               Load0C13( ) ;
            }
            EndLevel0C13( ) ;
         }
         CloseExtendedTableCursors0C13( ) ;
      }

      protected void Update0C13( )
      {
         BeforeValidate0C13( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0C13( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0C13( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0C13( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0C13( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000C9 */
                     pr_default.execute(7, new Object[] {n466BR_Diagnosis_DXType_Code, A466BR_Diagnosis_DXType_Code, n467BR_Diagnosis_DXTsource_Code, A467BR_Diagnosis_DXTsource_Code, n503BR_Diagnosis_InitialDX_Code, A503BR_Diagnosis_InitialDX_Code, n504BR_Diagnosis_MetastasesDX_Code, A504BR_Diagnosis_MetastasesDX_Code, n513BR_Diagnosis_No, A513BR_Diagnosis_No, n65BR_Diagnosis_DXID, A65BR_Diagnosis_DXID, n66BR_Diagnosis_DXCode, A66BR_Diagnosis_DXCode, n67BR_Diagnosis_DXType, A67BR_Diagnosis_DXType, n68BR_Diagnosis_DXTsource, A68BR_Diagnosis_DXTsource, n69BR_Diagnosis_DXDescription, A69BR_Diagnosis_DXDescription, n70BR_Diagnosis_InitialDX, A70BR_Diagnosis_InitialDX, n71BR_Diagnosis_MetastasesDX, A71BR_Diagnosis_MetastasesDX, n260BR_Diagnosis_DXSource, A260BR_Diagnosis_DXSource, n569BR_Diagnosis_TumorStageClinical, A569BR_Diagnosis_TumorStageClinical, A19BR_EncounterID, A64BR_DiagnosisID});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Diagnosis") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Diagnosis"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0C13( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(A64BR_DiagnosisID), 18, 0)),  "诊断",  "Update",  1) ;
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
            EndLevel0C13( ) ;
         }
         CloseExtendedTableCursors0C13( ) ;
      }

      protected void DeferredUpdate0C13( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate0C13( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0C13( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0C13( ) ;
            AfterConfirm0C13( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0C13( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC000C10 */
                  pr_default.execute(8, new Object[] {A64BR_DiagnosisID});
                  pr_default.close(8);
                  dsDefault.SmartCacheProvider.SetUpdated("BR_Diagnosis") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(A64BR_DiagnosisID), 18, 0)),  "诊断",  "Delete",  1) ;
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
         sMode13 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel0C13( ) ;
         Gx_mode = sMode13;
      }

      protected void OnDeleteControls0C13( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV16Pgmname = "BR_Diagnosis_BC";
            /* Using cursor BC000C11 */
            pr_default.execute(9, new Object[] {A19BR_EncounterID});
            A85BR_Information_ID = BC000C11_A85BR_Information_ID[0];
            n85BR_Information_ID = BC000C11_n85BR_Information_ID[0];
            pr_default.close(9);
            /* Using cursor BC000C12 */
            pr_default.execute(10, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
            A36BR_Information_PatientNo = BC000C12_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = BC000C12_n36BR_Information_PatientNo[0];
            pr_default.close(10);
         }
      }

      protected void EndLevel0C13( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0C13( ) ;
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

      public void ScanKeyStart0C13( )
      {
         /* Scan By routine */
         /* Using cursor BC000C13 */
         pr_default.execute(11, new Object[] {A64BR_DiagnosisID});
         RcdFound13 = 0;
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound13 = 1;
            A85BR_Information_ID = BC000C13_A85BR_Information_ID[0];
            n85BR_Information_ID = BC000C13_n85BR_Information_ID[0];
            A64BR_DiagnosisID = BC000C13_A64BR_DiagnosisID[0];
            A466BR_Diagnosis_DXType_Code = BC000C13_A466BR_Diagnosis_DXType_Code[0];
            n466BR_Diagnosis_DXType_Code = BC000C13_n466BR_Diagnosis_DXType_Code[0];
            A467BR_Diagnosis_DXTsource_Code = BC000C13_A467BR_Diagnosis_DXTsource_Code[0];
            n467BR_Diagnosis_DXTsource_Code = BC000C13_n467BR_Diagnosis_DXTsource_Code[0];
            A503BR_Diagnosis_InitialDX_Code = BC000C13_A503BR_Diagnosis_InitialDX_Code[0];
            n503BR_Diagnosis_InitialDX_Code = BC000C13_n503BR_Diagnosis_InitialDX_Code[0];
            A504BR_Diagnosis_MetastasesDX_Code = BC000C13_A504BR_Diagnosis_MetastasesDX_Code[0];
            n504BR_Diagnosis_MetastasesDX_Code = BC000C13_n504BR_Diagnosis_MetastasesDX_Code[0];
            A36BR_Information_PatientNo = BC000C13_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = BC000C13_n36BR_Information_PatientNo[0];
            A513BR_Diagnosis_No = BC000C13_A513BR_Diagnosis_No[0];
            n513BR_Diagnosis_No = BC000C13_n513BR_Diagnosis_No[0];
            A65BR_Diagnosis_DXID = BC000C13_A65BR_Diagnosis_DXID[0];
            n65BR_Diagnosis_DXID = BC000C13_n65BR_Diagnosis_DXID[0];
            A66BR_Diagnosis_DXCode = BC000C13_A66BR_Diagnosis_DXCode[0];
            n66BR_Diagnosis_DXCode = BC000C13_n66BR_Diagnosis_DXCode[0];
            A67BR_Diagnosis_DXType = BC000C13_A67BR_Diagnosis_DXType[0];
            n67BR_Diagnosis_DXType = BC000C13_n67BR_Diagnosis_DXType[0];
            A68BR_Diagnosis_DXTsource = BC000C13_A68BR_Diagnosis_DXTsource[0];
            n68BR_Diagnosis_DXTsource = BC000C13_n68BR_Diagnosis_DXTsource[0];
            A69BR_Diagnosis_DXDescription = BC000C13_A69BR_Diagnosis_DXDescription[0];
            n69BR_Diagnosis_DXDescription = BC000C13_n69BR_Diagnosis_DXDescription[0];
            A70BR_Diagnosis_InitialDX = BC000C13_A70BR_Diagnosis_InitialDX[0];
            n70BR_Diagnosis_InitialDX = BC000C13_n70BR_Diagnosis_InitialDX[0];
            A71BR_Diagnosis_MetastasesDX = BC000C13_A71BR_Diagnosis_MetastasesDX[0];
            n71BR_Diagnosis_MetastasesDX = BC000C13_n71BR_Diagnosis_MetastasesDX[0];
            A260BR_Diagnosis_DXSource = BC000C13_A260BR_Diagnosis_DXSource[0];
            n260BR_Diagnosis_DXSource = BC000C13_n260BR_Diagnosis_DXSource[0];
            A569BR_Diagnosis_TumorStageClinical = BC000C13_A569BR_Diagnosis_TumorStageClinical[0];
            n569BR_Diagnosis_TumorStageClinical = BC000C13_n569BR_Diagnosis_TumorStageClinical[0];
            A19BR_EncounterID = BC000C13_A19BR_EncounterID[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext0C13( )
      {
         /* Scan next routine */
         pr_default.readNext(11);
         RcdFound13 = 0;
         ScanKeyLoad0C13( ) ;
      }

      protected void ScanKeyLoad0C13( )
      {
         sMode13 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound13 = 1;
            A85BR_Information_ID = BC000C13_A85BR_Information_ID[0];
            n85BR_Information_ID = BC000C13_n85BR_Information_ID[0];
            A64BR_DiagnosisID = BC000C13_A64BR_DiagnosisID[0];
            A466BR_Diagnosis_DXType_Code = BC000C13_A466BR_Diagnosis_DXType_Code[0];
            n466BR_Diagnosis_DXType_Code = BC000C13_n466BR_Diagnosis_DXType_Code[0];
            A467BR_Diagnosis_DXTsource_Code = BC000C13_A467BR_Diagnosis_DXTsource_Code[0];
            n467BR_Diagnosis_DXTsource_Code = BC000C13_n467BR_Diagnosis_DXTsource_Code[0];
            A503BR_Diagnosis_InitialDX_Code = BC000C13_A503BR_Diagnosis_InitialDX_Code[0];
            n503BR_Diagnosis_InitialDX_Code = BC000C13_n503BR_Diagnosis_InitialDX_Code[0];
            A504BR_Diagnosis_MetastasesDX_Code = BC000C13_A504BR_Diagnosis_MetastasesDX_Code[0];
            n504BR_Diagnosis_MetastasesDX_Code = BC000C13_n504BR_Diagnosis_MetastasesDX_Code[0];
            A36BR_Information_PatientNo = BC000C13_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = BC000C13_n36BR_Information_PatientNo[0];
            A513BR_Diagnosis_No = BC000C13_A513BR_Diagnosis_No[0];
            n513BR_Diagnosis_No = BC000C13_n513BR_Diagnosis_No[0];
            A65BR_Diagnosis_DXID = BC000C13_A65BR_Diagnosis_DXID[0];
            n65BR_Diagnosis_DXID = BC000C13_n65BR_Diagnosis_DXID[0];
            A66BR_Diagnosis_DXCode = BC000C13_A66BR_Diagnosis_DXCode[0];
            n66BR_Diagnosis_DXCode = BC000C13_n66BR_Diagnosis_DXCode[0];
            A67BR_Diagnosis_DXType = BC000C13_A67BR_Diagnosis_DXType[0];
            n67BR_Diagnosis_DXType = BC000C13_n67BR_Diagnosis_DXType[0];
            A68BR_Diagnosis_DXTsource = BC000C13_A68BR_Diagnosis_DXTsource[0];
            n68BR_Diagnosis_DXTsource = BC000C13_n68BR_Diagnosis_DXTsource[0];
            A69BR_Diagnosis_DXDescription = BC000C13_A69BR_Diagnosis_DXDescription[0];
            n69BR_Diagnosis_DXDescription = BC000C13_n69BR_Diagnosis_DXDescription[0];
            A70BR_Diagnosis_InitialDX = BC000C13_A70BR_Diagnosis_InitialDX[0];
            n70BR_Diagnosis_InitialDX = BC000C13_n70BR_Diagnosis_InitialDX[0];
            A71BR_Diagnosis_MetastasesDX = BC000C13_A71BR_Diagnosis_MetastasesDX[0];
            n71BR_Diagnosis_MetastasesDX = BC000C13_n71BR_Diagnosis_MetastasesDX[0];
            A260BR_Diagnosis_DXSource = BC000C13_A260BR_Diagnosis_DXSource[0];
            n260BR_Diagnosis_DXSource = BC000C13_n260BR_Diagnosis_DXSource[0];
            A569BR_Diagnosis_TumorStageClinical = BC000C13_A569BR_Diagnosis_TumorStageClinical[0];
            n569BR_Diagnosis_TumorStageClinical = BC000C13_n569BR_Diagnosis_TumorStageClinical[0];
            A19BR_EncounterID = BC000C13_A19BR_EncounterID[0];
         }
         Gx_mode = sMode13;
      }

      protected void ScanKeyEnd0C13( )
      {
         pr_default.close(11);
      }

      protected void AfterConfirm0C13( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0C13( )
      {
         /* Before Insert Rules */
         GXt_char2 = A466BR_Diagnosis_DXType_Code;
         new zutil_findtargetcode(context ).execute(  20,  A67BR_Diagnosis_DXType, out  GXt_char2) ;
         A466BR_Diagnosis_DXType_Code = GXt_char2;
         n466BR_Diagnosis_DXType_Code = false;
         GXt_char2 = A467BR_Diagnosis_DXTsource_Code;
         new zutil_findtargetcode(context ).execute(  21,  A68BR_Diagnosis_DXTsource, out  GXt_char2) ;
         A467BR_Diagnosis_DXTsource_Code = GXt_char2;
         n467BR_Diagnosis_DXTsource_Code = false;
         GXt_char2 = A503BR_Diagnosis_InitialDX_Code;
         new zutil_findtargetcode(context ).execute(  37,  A70BR_Diagnosis_InitialDX, out  GXt_char2) ;
         A503BR_Diagnosis_InitialDX_Code = GXt_char2;
         n503BR_Diagnosis_InitialDX_Code = false;
         GXt_char2 = A504BR_Diagnosis_MetastasesDX_Code;
         new zutil_findtargetcode(context ).execute(  37,  A71BR_Diagnosis_MetastasesDX, out  GXt_char2) ;
         A504BR_Diagnosis_MetastasesDX_Code = GXt_char2;
         n504BR_Diagnosis_MetastasesDX_Code = false;
      }

      protected void BeforeUpdate0C13( )
      {
         /* Before Update Rules */
         GXt_char2 = A466BR_Diagnosis_DXType_Code;
         new zutil_findtargetcode(context ).execute(  20,  A67BR_Diagnosis_DXType, out  GXt_char2) ;
         A466BR_Diagnosis_DXType_Code = GXt_char2;
         n466BR_Diagnosis_DXType_Code = false;
         GXt_char2 = A467BR_Diagnosis_DXTsource_Code;
         new zutil_findtargetcode(context ).execute(  21,  A68BR_Diagnosis_DXTsource, out  GXt_char2) ;
         A467BR_Diagnosis_DXTsource_Code = GXt_char2;
         n467BR_Diagnosis_DXTsource_Code = false;
         GXt_char2 = A503BR_Diagnosis_InitialDX_Code;
         new zutil_findtargetcode(context ).execute(  37,  A70BR_Diagnosis_InitialDX, out  GXt_char2) ;
         A503BR_Diagnosis_InitialDX_Code = GXt_char2;
         n503BR_Diagnosis_InitialDX_Code = false;
         GXt_char2 = A504BR_Diagnosis_MetastasesDX_Code;
         new zutil_findtargetcode(context ).execute(  37,  A71BR_Diagnosis_MetastasesDX, out  GXt_char2) ;
         A504BR_Diagnosis_MetastasesDX_Code = GXt_char2;
         n504BR_Diagnosis_MetastasesDX_Code = false;
      }

      protected void BeforeDelete0C13( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0C13( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0C13( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0C13( )
      {
      }

      protected void send_integrity_lvl_hashes0C13( )
      {
      }

      protected void AddRow0C13( )
      {
         VarsToRow13( bcBR_Diagnosis) ;
      }

      protected void ReadRow0C13( )
      {
         RowToVars13( bcBR_Diagnosis, 1) ;
      }

      protected void InitializeNonKey0C13( )
      {
         A85BR_Information_ID = 0;
         n85BR_Information_ID = false;
         A466BR_Diagnosis_DXType_Code = "";
         n466BR_Diagnosis_DXType_Code = false;
         A467BR_Diagnosis_DXTsource_Code = "";
         n467BR_Diagnosis_DXTsource_Code = false;
         A503BR_Diagnosis_InitialDX_Code = "";
         n503BR_Diagnosis_InitialDX_Code = false;
         A504BR_Diagnosis_MetastasesDX_Code = "";
         n504BR_Diagnosis_MetastasesDX_Code = false;
         A19BR_EncounterID = 0;
         A36BR_Information_PatientNo = "";
         n36BR_Information_PatientNo = false;
         A513BR_Diagnosis_No = 0;
         n513BR_Diagnosis_No = false;
         A65BR_Diagnosis_DXID = "";
         n65BR_Diagnosis_DXID = false;
         A66BR_Diagnosis_DXCode = "";
         n66BR_Diagnosis_DXCode = false;
         A67BR_Diagnosis_DXType = "";
         n67BR_Diagnosis_DXType = false;
         A68BR_Diagnosis_DXTsource = "";
         n68BR_Diagnosis_DXTsource = false;
         A69BR_Diagnosis_DXDescription = "";
         n69BR_Diagnosis_DXDescription = false;
         A70BR_Diagnosis_InitialDX = "";
         n70BR_Diagnosis_InitialDX = false;
         A71BR_Diagnosis_MetastasesDX = "";
         n71BR_Diagnosis_MetastasesDX = false;
         A260BR_Diagnosis_DXSource = "";
         n260BR_Diagnosis_DXSource = false;
         A569BR_Diagnosis_TumorStageClinical = "";
         n569BR_Diagnosis_TumorStageClinical = false;
         Z466BR_Diagnosis_DXType_Code = "";
         Z467BR_Diagnosis_DXTsource_Code = "";
         Z503BR_Diagnosis_InitialDX_Code = "";
         Z504BR_Diagnosis_MetastasesDX_Code = "";
         Z513BR_Diagnosis_No = 0;
         Z65BR_Diagnosis_DXID = "";
         Z66BR_Diagnosis_DXCode = "";
         Z67BR_Diagnosis_DXType = "";
         Z68BR_Diagnosis_DXTsource = "";
         Z69BR_Diagnosis_DXDescription = "";
         Z70BR_Diagnosis_InitialDX = "";
         Z71BR_Diagnosis_MetastasesDX = "";
         Z260BR_Diagnosis_DXSource = "";
         Z569BR_Diagnosis_TumorStageClinical = "";
         Z19BR_EncounterID = 0;
      }

      protected void InitAll0C13( )
      {
         A64BR_DiagnosisID = 0;
         InitializeNonKey0C13( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow13( SdtBR_Diagnosis obj13 )
      {
         obj13.gxTpr_Mode = Gx_mode;
         obj13.gxTpr_Br_diagnosis_dxtype_code = A466BR_Diagnosis_DXType_Code;
         obj13.gxTpr_Br_diagnosis_dxtsource_code = A467BR_Diagnosis_DXTsource_Code;
         obj13.gxTpr_Br_diagnosis_initialdx_code = A503BR_Diagnosis_InitialDX_Code;
         obj13.gxTpr_Br_diagnosis_metastasesdx_code = A504BR_Diagnosis_MetastasesDX_Code;
         obj13.gxTpr_Br_encounterid = A19BR_EncounterID;
         obj13.gxTpr_Br_information_patientno = A36BR_Information_PatientNo;
         obj13.gxTpr_Br_diagnosis_no = A513BR_Diagnosis_No;
         obj13.gxTpr_Br_diagnosis_dxid = A65BR_Diagnosis_DXID;
         obj13.gxTpr_Br_diagnosis_dxcode = A66BR_Diagnosis_DXCode;
         obj13.gxTpr_Br_diagnosis_dxtype = A67BR_Diagnosis_DXType;
         obj13.gxTpr_Br_diagnosis_dxtsource = A68BR_Diagnosis_DXTsource;
         obj13.gxTpr_Br_diagnosis_dxdescription = A69BR_Diagnosis_DXDescription;
         obj13.gxTpr_Br_diagnosis_initialdx = A70BR_Diagnosis_InitialDX;
         obj13.gxTpr_Br_diagnosis_metastasesdx = A71BR_Diagnosis_MetastasesDX;
         obj13.gxTpr_Br_diagnosis_dxsource = A260BR_Diagnosis_DXSource;
         obj13.gxTpr_Br_diagnosis_tumorstageclinical = A569BR_Diagnosis_TumorStageClinical;
         obj13.gxTpr_Br_diagnosisid = A64BR_DiagnosisID;
         obj13.gxTpr_Br_diagnosisid_Z = Z64BR_DiagnosisID;
         obj13.gxTpr_Br_encounterid_Z = Z19BR_EncounterID;
         obj13.gxTpr_Br_information_patientno_Z = Z36BR_Information_PatientNo;
         obj13.gxTpr_Br_diagnosis_no_Z = Z513BR_Diagnosis_No;
         obj13.gxTpr_Br_diagnosis_dxid_Z = Z65BR_Diagnosis_DXID;
         obj13.gxTpr_Br_diagnosis_dxcode_Z = Z66BR_Diagnosis_DXCode;
         obj13.gxTpr_Br_diagnosis_dxtype_Z = Z67BR_Diagnosis_DXType;
         obj13.gxTpr_Br_diagnosis_dxtype_code_Z = Z466BR_Diagnosis_DXType_Code;
         obj13.gxTpr_Br_diagnosis_dxtsource_Z = Z68BR_Diagnosis_DXTsource;
         obj13.gxTpr_Br_diagnosis_dxtsource_code_Z = Z467BR_Diagnosis_DXTsource_Code;
         obj13.gxTpr_Br_diagnosis_dxdescription_Z = Z69BR_Diagnosis_DXDescription;
         obj13.gxTpr_Br_diagnosis_initialdx_Z = Z70BR_Diagnosis_InitialDX;
         obj13.gxTpr_Br_diagnosis_initialdx_code_Z = Z503BR_Diagnosis_InitialDX_Code;
         obj13.gxTpr_Br_diagnosis_metastasesdx_Z = Z71BR_Diagnosis_MetastasesDX;
         obj13.gxTpr_Br_diagnosis_metastasesdx_code_Z = Z504BR_Diagnosis_MetastasesDX_Code;
         obj13.gxTpr_Br_diagnosis_dxsource_Z = Z260BR_Diagnosis_DXSource;
         obj13.gxTpr_Br_diagnosis_tumorstageclinical_Z = Z569BR_Diagnosis_TumorStageClinical;
         obj13.gxTpr_Br_information_patientno_N = (short)(Convert.ToInt16(n36BR_Information_PatientNo));
         obj13.gxTpr_Br_diagnosis_no_N = (short)(Convert.ToInt16(n513BR_Diagnosis_No));
         obj13.gxTpr_Br_diagnosis_dxid_N = (short)(Convert.ToInt16(n65BR_Diagnosis_DXID));
         obj13.gxTpr_Br_diagnosis_dxcode_N = (short)(Convert.ToInt16(n66BR_Diagnosis_DXCode));
         obj13.gxTpr_Br_diagnosis_dxtype_N = (short)(Convert.ToInt16(n67BR_Diagnosis_DXType));
         obj13.gxTpr_Br_diagnosis_dxtype_code_N = (short)(Convert.ToInt16(n466BR_Diagnosis_DXType_Code));
         obj13.gxTpr_Br_diagnosis_dxtsource_N = (short)(Convert.ToInt16(n68BR_Diagnosis_DXTsource));
         obj13.gxTpr_Br_diagnosis_dxtsource_code_N = (short)(Convert.ToInt16(n467BR_Diagnosis_DXTsource_Code));
         obj13.gxTpr_Br_diagnosis_dxdescription_N = (short)(Convert.ToInt16(n69BR_Diagnosis_DXDescription));
         obj13.gxTpr_Br_diagnosis_initialdx_N = (short)(Convert.ToInt16(n70BR_Diagnosis_InitialDX));
         obj13.gxTpr_Br_diagnosis_initialdx_code_N = (short)(Convert.ToInt16(n503BR_Diagnosis_InitialDX_Code));
         obj13.gxTpr_Br_diagnosis_metastasesdx_N = (short)(Convert.ToInt16(n71BR_Diagnosis_MetastasesDX));
         obj13.gxTpr_Br_diagnosis_metastasesdx_code_N = (short)(Convert.ToInt16(n504BR_Diagnosis_MetastasesDX_Code));
         obj13.gxTpr_Br_diagnosis_dxsource_N = (short)(Convert.ToInt16(n260BR_Diagnosis_DXSource));
         obj13.gxTpr_Br_diagnosis_tumorstageclinical_N = (short)(Convert.ToInt16(n569BR_Diagnosis_TumorStageClinical));
         obj13.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow13( SdtBR_Diagnosis obj13 )
      {
         obj13.gxTpr_Br_diagnosisid = A64BR_DiagnosisID;
         return  ;
      }

      public void RowToVars13( SdtBR_Diagnosis obj13 ,
                               int forceLoad )
      {
         Gx_mode = obj13.gxTpr_Mode;
         A466BR_Diagnosis_DXType_Code = obj13.gxTpr_Br_diagnosis_dxtype_code;
         n466BR_Diagnosis_DXType_Code = false;
         A467BR_Diagnosis_DXTsource_Code = obj13.gxTpr_Br_diagnosis_dxtsource_code;
         n467BR_Diagnosis_DXTsource_Code = false;
         A503BR_Diagnosis_InitialDX_Code = obj13.gxTpr_Br_diagnosis_initialdx_code;
         n503BR_Diagnosis_InitialDX_Code = false;
         A504BR_Diagnosis_MetastasesDX_Code = obj13.gxTpr_Br_diagnosis_metastasesdx_code;
         n504BR_Diagnosis_MetastasesDX_Code = false;
         A19BR_EncounterID = obj13.gxTpr_Br_encounterid;
         A36BR_Information_PatientNo = obj13.gxTpr_Br_information_patientno;
         n36BR_Information_PatientNo = false;
         A513BR_Diagnosis_No = obj13.gxTpr_Br_diagnosis_no;
         n513BR_Diagnosis_No = false;
         A65BR_Diagnosis_DXID = obj13.gxTpr_Br_diagnosis_dxid;
         n65BR_Diagnosis_DXID = false;
         A66BR_Diagnosis_DXCode = obj13.gxTpr_Br_diagnosis_dxcode;
         n66BR_Diagnosis_DXCode = false;
         A67BR_Diagnosis_DXType = obj13.gxTpr_Br_diagnosis_dxtype;
         n67BR_Diagnosis_DXType = false;
         A68BR_Diagnosis_DXTsource = obj13.gxTpr_Br_diagnosis_dxtsource;
         n68BR_Diagnosis_DXTsource = false;
         A69BR_Diagnosis_DXDescription = obj13.gxTpr_Br_diagnosis_dxdescription;
         n69BR_Diagnosis_DXDescription = false;
         A70BR_Diagnosis_InitialDX = obj13.gxTpr_Br_diagnosis_initialdx;
         n70BR_Diagnosis_InitialDX = false;
         A71BR_Diagnosis_MetastasesDX = obj13.gxTpr_Br_diagnosis_metastasesdx;
         n71BR_Diagnosis_MetastasesDX = false;
         A260BR_Diagnosis_DXSource = obj13.gxTpr_Br_diagnosis_dxsource;
         n260BR_Diagnosis_DXSource = false;
         A569BR_Diagnosis_TumorStageClinical = obj13.gxTpr_Br_diagnosis_tumorstageclinical;
         n569BR_Diagnosis_TumorStageClinical = false;
         A64BR_DiagnosisID = obj13.gxTpr_Br_diagnosisid;
         Z64BR_DiagnosisID = obj13.gxTpr_Br_diagnosisid_Z;
         Z19BR_EncounterID = obj13.gxTpr_Br_encounterid_Z;
         Z36BR_Information_PatientNo = obj13.gxTpr_Br_information_patientno_Z;
         Z513BR_Diagnosis_No = obj13.gxTpr_Br_diagnosis_no_Z;
         Z65BR_Diagnosis_DXID = obj13.gxTpr_Br_diagnosis_dxid_Z;
         Z66BR_Diagnosis_DXCode = obj13.gxTpr_Br_diagnosis_dxcode_Z;
         Z67BR_Diagnosis_DXType = obj13.gxTpr_Br_diagnosis_dxtype_Z;
         Z466BR_Diagnosis_DXType_Code = obj13.gxTpr_Br_diagnosis_dxtype_code_Z;
         Z68BR_Diagnosis_DXTsource = obj13.gxTpr_Br_diagnosis_dxtsource_Z;
         Z467BR_Diagnosis_DXTsource_Code = obj13.gxTpr_Br_diagnosis_dxtsource_code_Z;
         Z69BR_Diagnosis_DXDescription = obj13.gxTpr_Br_diagnosis_dxdescription_Z;
         Z70BR_Diagnosis_InitialDX = obj13.gxTpr_Br_diagnosis_initialdx_Z;
         Z503BR_Diagnosis_InitialDX_Code = obj13.gxTpr_Br_diagnosis_initialdx_code_Z;
         Z71BR_Diagnosis_MetastasesDX = obj13.gxTpr_Br_diagnosis_metastasesdx_Z;
         Z504BR_Diagnosis_MetastasesDX_Code = obj13.gxTpr_Br_diagnosis_metastasesdx_code_Z;
         Z260BR_Diagnosis_DXSource = obj13.gxTpr_Br_diagnosis_dxsource_Z;
         Z569BR_Diagnosis_TumorStageClinical = obj13.gxTpr_Br_diagnosis_tumorstageclinical_Z;
         n36BR_Information_PatientNo = (bool)(Convert.ToBoolean(obj13.gxTpr_Br_information_patientno_N));
         n513BR_Diagnosis_No = (bool)(Convert.ToBoolean(obj13.gxTpr_Br_diagnosis_no_N));
         n65BR_Diagnosis_DXID = (bool)(Convert.ToBoolean(obj13.gxTpr_Br_diagnosis_dxid_N));
         n66BR_Diagnosis_DXCode = (bool)(Convert.ToBoolean(obj13.gxTpr_Br_diagnosis_dxcode_N));
         n67BR_Diagnosis_DXType = (bool)(Convert.ToBoolean(obj13.gxTpr_Br_diagnosis_dxtype_N));
         n466BR_Diagnosis_DXType_Code = (bool)(Convert.ToBoolean(obj13.gxTpr_Br_diagnosis_dxtype_code_N));
         n68BR_Diagnosis_DXTsource = (bool)(Convert.ToBoolean(obj13.gxTpr_Br_diagnosis_dxtsource_N));
         n467BR_Diagnosis_DXTsource_Code = (bool)(Convert.ToBoolean(obj13.gxTpr_Br_diagnosis_dxtsource_code_N));
         n69BR_Diagnosis_DXDescription = (bool)(Convert.ToBoolean(obj13.gxTpr_Br_diagnosis_dxdescription_N));
         n70BR_Diagnosis_InitialDX = (bool)(Convert.ToBoolean(obj13.gxTpr_Br_diagnosis_initialdx_N));
         n503BR_Diagnosis_InitialDX_Code = (bool)(Convert.ToBoolean(obj13.gxTpr_Br_diagnosis_initialdx_code_N));
         n71BR_Diagnosis_MetastasesDX = (bool)(Convert.ToBoolean(obj13.gxTpr_Br_diagnosis_metastasesdx_N));
         n504BR_Diagnosis_MetastasesDX_Code = (bool)(Convert.ToBoolean(obj13.gxTpr_Br_diagnosis_metastasesdx_code_N));
         n260BR_Diagnosis_DXSource = (bool)(Convert.ToBoolean(obj13.gxTpr_Br_diagnosis_dxsource_N));
         n569BR_Diagnosis_TumorStageClinical = (bool)(Convert.ToBoolean(obj13.gxTpr_Br_diagnosis_tumorstageclinical_N));
         Gx_mode = obj13.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A64BR_DiagnosisID = (long)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey0C13( ) ;
         ScanKeyStart0C13( ) ;
         if ( RcdFound13 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z64BR_DiagnosisID = A64BR_DiagnosisID;
         }
         ZM0C13( -19) ;
         OnLoadActions0C13( ) ;
         AddRow0C13( ) ;
         ScanKeyEnd0C13( ) ;
         if ( RcdFound13 == 0 )
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
         RowToVars13( bcBR_Diagnosis, 0) ;
         ScanKeyStart0C13( ) ;
         if ( RcdFound13 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z64BR_DiagnosisID = A64BR_DiagnosisID;
         }
         ZM0C13( -19) ;
         OnLoadActions0C13( ) ;
         AddRow0C13( ) ;
         ScanKeyEnd0C13( ) ;
         if ( RcdFound13 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey0C13( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert0C13( ) ;
         }
         else
         {
            if ( RcdFound13 == 1 )
            {
               if ( A64BR_DiagnosisID != Z64BR_DiagnosisID )
               {
                  A64BR_DiagnosisID = Z64BR_DiagnosisID;
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
                  Update0C13( ) ;
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
                  if ( A64BR_DiagnosisID != Z64BR_DiagnosisID )
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
                        Insert0C13( ) ;
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
                        Insert0C13( ) ;
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
         RowToVars13( bcBR_Diagnosis, 0) ;
         SaveImpl( ) ;
         VarsToRow13( bcBR_Diagnosis) ;
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
         RowToVars13( bcBR_Diagnosis, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert0C13( ) ;
         AfterTrn( ) ;
         VarsToRow13( bcBR_Diagnosis) ;
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
            SdtBR_Diagnosis auxBC = new SdtBR_Diagnosis(context) ;
            auxBC.Load(A64BR_DiagnosisID);
            auxBC.UpdateDirties(bcBR_Diagnosis);
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
         RowToVars13( bcBR_Diagnosis, 0) ;
         UpdateImpl( ) ;
         VarsToRow13( bcBR_Diagnosis) ;
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
         RowToVars13( bcBR_Diagnosis, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert0C13( ) ;
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
         VarsToRow13( bcBR_Diagnosis) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars13( bcBR_Diagnosis, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey0C13( ) ;
         if ( RcdFound13 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A64BR_DiagnosisID != Z64BR_DiagnosisID )
            {
               A64BR_DiagnosisID = Z64BR_DiagnosisID;
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
            if ( A64BR_DiagnosisID != Z64BR_DiagnosisID )
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
         context.RollbackDataStores("br_diagnosis_bc",pr_default);
         VarsToRow13( bcBR_Diagnosis) ;
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
         Gx_mode = bcBR_Diagnosis.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcBR_Diagnosis.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcBR_Diagnosis )
         {
            bcBR_Diagnosis = (SdtBR_Diagnosis)(sdt);
            if ( StringUtil.StrCmp(bcBR_Diagnosis.gxTpr_Mode, "") == 0 )
            {
               bcBR_Diagnosis.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow13( bcBR_Diagnosis) ;
            }
            else
            {
               RowToVars13( bcBR_Diagnosis, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcBR_Diagnosis.gxTpr_Mode, "") == 0 )
            {
               bcBR_Diagnosis.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars13( bcBR_Diagnosis, 1) ;
         return  ;
      }

      public SdtBR_Diagnosis BR_Diagnosis_BC
      {
         get {
            return bcBR_Diagnosis ;
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
         AV16Pgmname = "";
         AV8TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9WebSession = context.GetSession();
         AV11TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         Z466BR_Diagnosis_DXType_Code = "";
         A466BR_Diagnosis_DXType_Code = "";
         Z467BR_Diagnosis_DXTsource_Code = "";
         A467BR_Diagnosis_DXTsource_Code = "";
         Z503BR_Diagnosis_InitialDX_Code = "";
         A503BR_Diagnosis_InitialDX_Code = "";
         Z504BR_Diagnosis_MetastasesDX_Code = "";
         A504BR_Diagnosis_MetastasesDX_Code = "";
         Z65BR_Diagnosis_DXID = "";
         A65BR_Diagnosis_DXID = "";
         Z66BR_Diagnosis_DXCode = "";
         A66BR_Diagnosis_DXCode = "";
         Z67BR_Diagnosis_DXType = "";
         A67BR_Diagnosis_DXType = "";
         Z68BR_Diagnosis_DXTsource = "";
         A68BR_Diagnosis_DXTsource = "";
         Z69BR_Diagnosis_DXDescription = "";
         A69BR_Diagnosis_DXDescription = "";
         Z70BR_Diagnosis_InitialDX = "";
         A70BR_Diagnosis_InitialDX = "";
         Z71BR_Diagnosis_MetastasesDX = "";
         A71BR_Diagnosis_MetastasesDX = "";
         Z260BR_Diagnosis_DXSource = "";
         A260BR_Diagnosis_DXSource = "";
         Z569BR_Diagnosis_TumorStageClinical = "";
         A569BR_Diagnosis_TumorStageClinical = "";
         Z36BR_Information_PatientNo = "";
         A36BR_Information_PatientNo = "";
         BC000C6_A85BR_Information_ID = new long[1] ;
         BC000C6_n85BR_Information_ID = new bool[] {false} ;
         BC000C6_A64BR_DiagnosisID = new long[1] ;
         BC000C6_A466BR_Diagnosis_DXType_Code = new String[] {""} ;
         BC000C6_n466BR_Diagnosis_DXType_Code = new bool[] {false} ;
         BC000C6_A467BR_Diagnosis_DXTsource_Code = new String[] {""} ;
         BC000C6_n467BR_Diagnosis_DXTsource_Code = new bool[] {false} ;
         BC000C6_A503BR_Diagnosis_InitialDX_Code = new String[] {""} ;
         BC000C6_n503BR_Diagnosis_InitialDX_Code = new bool[] {false} ;
         BC000C6_A504BR_Diagnosis_MetastasesDX_Code = new String[] {""} ;
         BC000C6_n504BR_Diagnosis_MetastasesDX_Code = new bool[] {false} ;
         BC000C6_A36BR_Information_PatientNo = new String[] {""} ;
         BC000C6_n36BR_Information_PatientNo = new bool[] {false} ;
         BC000C6_A513BR_Diagnosis_No = new long[1] ;
         BC000C6_n513BR_Diagnosis_No = new bool[] {false} ;
         BC000C6_A65BR_Diagnosis_DXID = new String[] {""} ;
         BC000C6_n65BR_Diagnosis_DXID = new bool[] {false} ;
         BC000C6_A66BR_Diagnosis_DXCode = new String[] {""} ;
         BC000C6_n66BR_Diagnosis_DXCode = new bool[] {false} ;
         BC000C6_A67BR_Diagnosis_DXType = new String[] {""} ;
         BC000C6_n67BR_Diagnosis_DXType = new bool[] {false} ;
         BC000C6_A68BR_Diagnosis_DXTsource = new String[] {""} ;
         BC000C6_n68BR_Diagnosis_DXTsource = new bool[] {false} ;
         BC000C6_A69BR_Diagnosis_DXDescription = new String[] {""} ;
         BC000C6_n69BR_Diagnosis_DXDescription = new bool[] {false} ;
         BC000C6_A70BR_Diagnosis_InitialDX = new String[] {""} ;
         BC000C6_n70BR_Diagnosis_InitialDX = new bool[] {false} ;
         BC000C6_A71BR_Diagnosis_MetastasesDX = new String[] {""} ;
         BC000C6_n71BR_Diagnosis_MetastasesDX = new bool[] {false} ;
         BC000C6_A260BR_Diagnosis_DXSource = new String[] {""} ;
         BC000C6_n260BR_Diagnosis_DXSource = new bool[] {false} ;
         BC000C6_A569BR_Diagnosis_TumorStageClinical = new String[] {""} ;
         BC000C6_n569BR_Diagnosis_TumorStageClinical = new bool[] {false} ;
         BC000C6_A19BR_EncounterID = new long[1] ;
         BC000C4_A85BR_Information_ID = new long[1] ;
         BC000C4_n85BR_Information_ID = new bool[] {false} ;
         BC000C5_A36BR_Information_PatientNo = new String[] {""} ;
         BC000C5_n36BR_Information_PatientNo = new bool[] {false} ;
         BC000C7_A64BR_DiagnosisID = new long[1] ;
         BC000C3_A64BR_DiagnosisID = new long[1] ;
         BC000C3_A466BR_Diagnosis_DXType_Code = new String[] {""} ;
         BC000C3_n466BR_Diagnosis_DXType_Code = new bool[] {false} ;
         BC000C3_A467BR_Diagnosis_DXTsource_Code = new String[] {""} ;
         BC000C3_n467BR_Diagnosis_DXTsource_Code = new bool[] {false} ;
         BC000C3_A503BR_Diagnosis_InitialDX_Code = new String[] {""} ;
         BC000C3_n503BR_Diagnosis_InitialDX_Code = new bool[] {false} ;
         BC000C3_A504BR_Diagnosis_MetastasesDX_Code = new String[] {""} ;
         BC000C3_n504BR_Diagnosis_MetastasesDX_Code = new bool[] {false} ;
         BC000C3_A513BR_Diagnosis_No = new long[1] ;
         BC000C3_n513BR_Diagnosis_No = new bool[] {false} ;
         BC000C3_A65BR_Diagnosis_DXID = new String[] {""} ;
         BC000C3_n65BR_Diagnosis_DXID = new bool[] {false} ;
         BC000C3_A66BR_Diagnosis_DXCode = new String[] {""} ;
         BC000C3_n66BR_Diagnosis_DXCode = new bool[] {false} ;
         BC000C3_A67BR_Diagnosis_DXType = new String[] {""} ;
         BC000C3_n67BR_Diagnosis_DXType = new bool[] {false} ;
         BC000C3_A68BR_Diagnosis_DXTsource = new String[] {""} ;
         BC000C3_n68BR_Diagnosis_DXTsource = new bool[] {false} ;
         BC000C3_A69BR_Diagnosis_DXDescription = new String[] {""} ;
         BC000C3_n69BR_Diagnosis_DXDescription = new bool[] {false} ;
         BC000C3_A70BR_Diagnosis_InitialDX = new String[] {""} ;
         BC000C3_n70BR_Diagnosis_InitialDX = new bool[] {false} ;
         BC000C3_A71BR_Diagnosis_MetastasesDX = new String[] {""} ;
         BC000C3_n71BR_Diagnosis_MetastasesDX = new bool[] {false} ;
         BC000C3_A260BR_Diagnosis_DXSource = new String[] {""} ;
         BC000C3_n260BR_Diagnosis_DXSource = new bool[] {false} ;
         BC000C3_A569BR_Diagnosis_TumorStageClinical = new String[] {""} ;
         BC000C3_n569BR_Diagnosis_TumorStageClinical = new bool[] {false} ;
         BC000C3_A19BR_EncounterID = new long[1] ;
         sMode13 = "";
         BC000C2_A64BR_DiagnosisID = new long[1] ;
         BC000C2_A466BR_Diagnosis_DXType_Code = new String[] {""} ;
         BC000C2_n466BR_Diagnosis_DXType_Code = new bool[] {false} ;
         BC000C2_A467BR_Diagnosis_DXTsource_Code = new String[] {""} ;
         BC000C2_n467BR_Diagnosis_DXTsource_Code = new bool[] {false} ;
         BC000C2_A503BR_Diagnosis_InitialDX_Code = new String[] {""} ;
         BC000C2_n503BR_Diagnosis_InitialDX_Code = new bool[] {false} ;
         BC000C2_A504BR_Diagnosis_MetastasesDX_Code = new String[] {""} ;
         BC000C2_n504BR_Diagnosis_MetastasesDX_Code = new bool[] {false} ;
         BC000C2_A513BR_Diagnosis_No = new long[1] ;
         BC000C2_n513BR_Diagnosis_No = new bool[] {false} ;
         BC000C2_A65BR_Diagnosis_DXID = new String[] {""} ;
         BC000C2_n65BR_Diagnosis_DXID = new bool[] {false} ;
         BC000C2_A66BR_Diagnosis_DXCode = new String[] {""} ;
         BC000C2_n66BR_Diagnosis_DXCode = new bool[] {false} ;
         BC000C2_A67BR_Diagnosis_DXType = new String[] {""} ;
         BC000C2_n67BR_Diagnosis_DXType = new bool[] {false} ;
         BC000C2_A68BR_Diagnosis_DXTsource = new String[] {""} ;
         BC000C2_n68BR_Diagnosis_DXTsource = new bool[] {false} ;
         BC000C2_A69BR_Diagnosis_DXDescription = new String[] {""} ;
         BC000C2_n69BR_Diagnosis_DXDescription = new bool[] {false} ;
         BC000C2_A70BR_Diagnosis_InitialDX = new String[] {""} ;
         BC000C2_n70BR_Diagnosis_InitialDX = new bool[] {false} ;
         BC000C2_A71BR_Diagnosis_MetastasesDX = new String[] {""} ;
         BC000C2_n71BR_Diagnosis_MetastasesDX = new bool[] {false} ;
         BC000C2_A260BR_Diagnosis_DXSource = new String[] {""} ;
         BC000C2_n260BR_Diagnosis_DXSource = new bool[] {false} ;
         BC000C2_A569BR_Diagnosis_TumorStageClinical = new String[] {""} ;
         BC000C2_n569BR_Diagnosis_TumorStageClinical = new bool[] {false} ;
         BC000C2_A19BR_EncounterID = new long[1] ;
         BC000C8_A64BR_DiagnosisID = new long[1] ;
         BC000C11_A85BR_Information_ID = new long[1] ;
         BC000C11_n85BR_Information_ID = new bool[] {false} ;
         BC000C12_A36BR_Information_PatientNo = new String[] {""} ;
         BC000C12_n36BR_Information_PatientNo = new bool[] {false} ;
         BC000C13_A85BR_Information_ID = new long[1] ;
         BC000C13_n85BR_Information_ID = new bool[] {false} ;
         BC000C13_A64BR_DiagnosisID = new long[1] ;
         BC000C13_A466BR_Diagnosis_DXType_Code = new String[] {""} ;
         BC000C13_n466BR_Diagnosis_DXType_Code = new bool[] {false} ;
         BC000C13_A467BR_Diagnosis_DXTsource_Code = new String[] {""} ;
         BC000C13_n467BR_Diagnosis_DXTsource_Code = new bool[] {false} ;
         BC000C13_A503BR_Diagnosis_InitialDX_Code = new String[] {""} ;
         BC000C13_n503BR_Diagnosis_InitialDX_Code = new bool[] {false} ;
         BC000C13_A504BR_Diagnosis_MetastasesDX_Code = new String[] {""} ;
         BC000C13_n504BR_Diagnosis_MetastasesDX_Code = new bool[] {false} ;
         BC000C13_A36BR_Information_PatientNo = new String[] {""} ;
         BC000C13_n36BR_Information_PatientNo = new bool[] {false} ;
         BC000C13_A513BR_Diagnosis_No = new long[1] ;
         BC000C13_n513BR_Diagnosis_No = new bool[] {false} ;
         BC000C13_A65BR_Diagnosis_DXID = new String[] {""} ;
         BC000C13_n65BR_Diagnosis_DXID = new bool[] {false} ;
         BC000C13_A66BR_Diagnosis_DXCode = new String[] {""} ;
         BC000C13_n66BR_Diagnosis_DXCode = new bool[] {false} ;
         BC000C13_A67BR_Diagnosis_DXType = new String[] {""} ;
         BC000C13_n67BR_Diagnosis_DXType = new bool[] {false} ;
         BC000C13_A68BR_Diagnosis_DXTsource = new String[] {""} ;
         BC000C13_n68BR_Diagnosis_DXTsource = new bool[] {false} ;
         BC000C13_A69BR_Diagnosis_DXDescription = new String[] {""} ;
         BC000C13_n69BR_Diagnosis_DXDescription = new bool[] {false} ;
         BC000C13_A70BR_Diagnosis_InitialDX = new String[] {""} ;
         BC000C13_n70BR_Diagnosis_InitialDX = new bool[] {false} ;
         BC000C13_A71BR_Diagnosis_MetastasesDX = new String[] {""} ;
         BC000C13_n71BR_Diagnosis_MetastasesDX = new bool[] {false} ;
         BC000C13_A260BR_Diagnosis_DXSource = new String[] {""} ;
         BC000C13_n260BR_Diagnosis_DXSource = new bool[] {false} ;
         BC000C13_A569BR_Diagnosis_TumorStageClinical = new String[] {""} ;
         BC000C13_n569BR_Diagnosis_TumorStageClinical = new bool[] {false} ;
         BC000C13_A19BR_EncounterID = new long[1] ;
         GXt_char2 = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_diagnosis_bc__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_diagnosis_bc__default(),
            new Object[][] {
                new Object[] {
               BC000C2_A64BR_DiagnosisID, BC000C2_A466BR_Diagnosis_DXType_Code, BC000C2_n466BR_Diagnosis_DXType_Code, BC000C2_A467BR_Diagnosis_DXTsource_Code, BC000C2_n467BR_Diagnosis_DXTsource_Code, BC000C2_A503BR_Diagnosis_InitialDX_Code, BC000C2_n503BR_Diagnosis_InitialDX_Code, BC000C2_A504BR_Diagnosis_MetastasesDX_Code, BC000C2_n504BR_Diagnosis_MetastasesDX_Code, BC000C2_A513BR_Diagnosis_No,
               BC000C2_n513BR_Diagnosis_No, BC000C2_A65BR_Diagnosis_DXID, BC000C2_n65BR_Diagnosis_DXID, BC000C2_A66BR_Diagnosis_DXCode, BC000C2_n66BR_Diagnosis_DXCode, BC000C2_A67BR_Diagnosis_DXType, BC000C2_n67BR_Diagnosis_DXType, BC000C2_A68BR_Diagnosis_DXTsource, BC000C2_n68BR_Diagnosis_DXTsource, BC000C2_A69BR_Diagnosis_DXDescription,
               BC000C2_n69BR_Diagnosis_DXDescription, BC000C2_A70BR_Diagnosis_InitialDX, BC000C2_n70BR_Diagnosis_InitialDX, BC000C2_A71BR_Diagnosis_MetastasesDX, BC000C2_n71BR_Diagnosis_MetastasesDX, BC000C2_A260BR_Diagnosis_DXSource, BC000C2_n260BR_Diagnosis_DXSource, BC000C2_A569BR_Diagnosis_TumorStageClinical, BC000C2_n569BR_Diagnosis_TumorStageClinical, BC000C2_A19BR_EncounterID
               }
               , new Object[] {
               BC000C3_A64BR_DiagnosisID, BC000C3_A466BR_Diagnosis_DXType_Code, BC000C3_n466BR_Diagnosis_DXType_Code, BC000C3_A467BR_Diagnosis_DXTsource_Code, BC000C3_n467BR_Diagnosis_DXTsource_Code, BC000C3_A503BR_Diagnosis_InitialDX_Code, BC000C3_n503BR_Diagnosis_InitialDX_Code, BC000C3_A504BR_Diagnosis_MetastasesDX_Code, BC000C3_n504BR_Diagnosis_MetastasesDX_Code, BC000C3_A513BR_Diagnosis_No,
               BC000C3_n513BR_Diagnosis_No, BC000C3_A65BR_Diagnosis_DXID, BC000C3_n65BR_Diagnosis_DXID, BC000C3_A66BR_Diagnosis_DXCode, BC000C3_n66BR_Diagnosis_DXCode, BC000C3_A67BR_Diagnosis_DXType, BC000C3_n67BR_Diagnosis_DXType, BC000C3_A68BR_Diagnosis_DXTsource, BC000C3_n68BR_Diagnosis_DXTsource, BC000C3_A69BR_Diagnosis_DXDescription,
               BC000C3_n69BR_Diagnosis_DXDescription, BC000C3_A70BR_Diagnosis_InitialDX, BC000C3_n70BR_Diagnosis_InitialDX, BC000C3_A71BR_Diagnosis_MetastasesDX, BC000C3_n71BR_Diagnosis_MetastasesDX, BC000C3_A260BR_Diagnosis_DXSource, BC000C3_n260BR_Diagnosis_DXSource, BC000C3_A569BR_Diagnosis_TumorStageClinical, BC000C3_n569BR_Diagnosis_TumorStageClinical, BC000C3_A19BR_EncounterID
               }
               , new Object[] {
               BC000C4_A85BR_Information_ID, BC000C4_n85BR_Information_ID
               }
               , new Object[] {
               BC000C5_A36BR_Information_PatientNo, BC000C5_n36BR_Information_PatientNo
               }
               , new Object[] {
               BC000C6_A85BR_Information_ID, BC000C6_n85BR_Information_ID, BC000C6_A64BR_DiagnosisID, BC000C6_A466BR_Diagnosis_DXType_Code, BC000C6_n466BR_Diagnosis_DXType_Code, BC000C6_A467BR_Diagnosis_DXTsource_Code, BC000C6_n467BR_Diagnosis_DXTsource_Code, BC000C6_A503BR_Diagnosis_InitialDX_Code, BC000C6_n503BR_Diagnosis_InitialDX_Code, BC000C6_A504BR_Diagnosis_MetastasesDX_Code,
               BC000C6_n504BR_Diagnosis_MetastasesDX_Code, BC000C6_A36BR_Information_PatientNo, BC000C6_n36BR_Information_PatientNo, BC000C6_A513BR_Diagnosis_No, BC000C6_n513BR_Diagnosis_No, BC000C6_A65BR_Diagnosis_DXID, BC000C6_n65BR_Diagnosis_DXID, BC000C6_A66BR_Diagnosis_DXCode, BC000C6_n66BR_Diagnosis_DXCode, BC000C6_A67BR_Diagnosis_DXType,
               BC000C6_n67BR_Diagnosis_DXType, BC000C6_A68BR_Diagnosis_DXTsource, BC000C6_n68BR_Diagnosis_DXTsource, BC000C6_A69BR_Diagnosis_DXDescription, BC000C6_n69BR_Diagnosis_DXDescription, BC000C6_A70BR_Diagnosis_InitialDX, BC000C6_n70BR_Diagnosis_InitialDX, BC000C6_A71BR_Diagnosis_MetastasesDX, BC000C6_n71BR_Diagnosis_MetastasesDX, BC000C6_A260BR_Diagnosis_DXSource,
               BC000C6_n260BR_Diagnosis_DXSource, BC000C6_A569BR_Diagnosis_TumorStageClinical, BC000C6_n569BR_Diagnosis_TumorStageClinical, BC000C6_A19BR_EncounterID
               }
               , new Object[] {
               BC000C7_A64BR_DiagnosisID
               }
               , new Object[] {
               BC000C8_A64BR_DiagnosisID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000C11_A85BR_Information_ID, BC000C11_n85BR_Information_ID
               }
               , new Object[] {
               BC000C12_A36BR_Information_PatientNo, BC000C12_n36BR_Information_PatientNo
               }
               , new Object[] {
               BC000C13_A85BR_Information_ID, BC000C13_n85BR_Information_ID, BC000C13_A64BR_DiagnosisID, BC000C13_A466BR_Diagnosis_DXType_Code, BC000C13_n466BR_Diagnosis_DXType_Code, BC000C13_A467BR_Diagnosis_DXTsource_Code, BC000C13_n467BR_Diagnosis_DXTsource_Code, BC000C13_A503BR_Diagnosis_InitialDX_Code, BC000C13_n503BR_Diagnosis_InitialDX_Code, BC000C13_A504BR_Diagnosis_MetastasesDX_Code,
               BC000C13_n504BR_Diagnosis_MetastasesDX_Code, BC000C13_A36BR_Information_PatientNo, BC000C13_n36BR_Information_PatientNo, BC000C13_A513BR_Diagnosis_No, BC000C13_n513BR_Diagnosis_No, BC000C13_A65BR_Diagnosis_DXID, BC000C13_n65BR_Diagnosis_DXID, BC000C13_A66BR_Diagnosis_DXCode, BC000C13_n66BR_Diagnosis_DXCode, BC000C13_A67BR_Diagnosis_DXType,
               BC000C13_n67BR_Diagnosis_DXType, BC000C13_A68BR_Diagnosis_DXTsource, BC000C13_n68BR_Diagnosis_DXTsource, BC000C13_A69BR_Diagnosis_DXDescription, BC000C13_n69BR_Diagnosis_DXDescription, BC000C13_A70BR_Diagnosis_InitialDX, BC000C13_n70BR_Diagnosis_InitialDX, BC000C13_A71BR_Diagnosis_MetastasesDX, BC000C13_n71BR_Diagnosis_MetastasesDX, BC000C13_A260BR_Diagnosis_DXSource,
               BC000C13_n260BR_Diagnosis_DXSource, BC000C13_A569BR_Diagnosis_TumorStageClinical, BC000C13_n569BR_Diagnosis_TumorStageClinical, BC000C13_A19BR_EncounterID
               }
            }
         );
         AV16Pgmname = "BR_Diagnosis_BC";
         INITTRN();
         /* Execute Start event if defined. */
         /* Execute user event: Start */
         E120C2 ();
         standaloneNotModal( ) ;
      }

      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short GX_JID ;
      private short RcdFound13 ;
      private int trnEnded ;
      private int AV17GXV1 ;
      private long Z64BR_DiagnosisID ;
      private long A64BR_DiagnosisID ;
      private long AV10Insert_BR_EncounterID ;
      private long Z513BR_Diagnosis_No ;
      private long A513BR_Diagnosis_No ;
      private long Z19BR_EncounterID ;
      private long A19BR_EncounterID ;
      private long Z85BR_Information_ID ;
      private long A85BR_Information_ID ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String AV16Pgmname ;
      private String sMode13 ;
      private String GXt_char2 ;
      private bool AV13IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool returnInSub ;
      private bool n85BR_Information_ID ;
      private bool n466BR_Diagnosis_DXType_Code ;
      private bool n467BR_Diagnosis_DXTsource_Code ;
      private bool n503BR_Diagnosis_InitialDX_Code ;
      private bool n504BR_Diagnosis_MetastasesDX_Code ;
      private bool n36BR_Information_PatientNo ;
      private bool n513BR_Diagnosis_No ;
      private bool n65BR_Diagnosis_DXID ;
      private bool n66BR_Diagnosis_DXCode ;
      private bool n67BR_Diagnosis_DXType ;
      private bool n68BR_Diagnosis_DXTsource ;
      private bool n69BR_Diagnosis_DXDescription ;
      private bool n70BR_Diagnosis_InitialDX ;
      private bool n71BR_Diagnosis_MetastasesDX ;
      private bool n260BR_Diagnosis_DXSource ;
      private bool n569BR_Diagnosis_TumorStageClinical ;
      private bool Gx_longc ;
      private String Z466BR_Diagnosis_DXType_Code ;
      private String A466BR_Diagnosis_DXType_Code ;
      private String Z467BR_Diagnosis_DXTsource_Code ;
      private String A467BR_Diagnosis_DXTsource_Code ;
      private String Z503BR_Diagnosis_InitialDX_Code ;
      private String A503BR_Diagnosis_InitialDX_Code ;
      private String Z504BR_Diagnosis_MetastasesDX_Code ;
      private String A504BR_Diagnosis_MetastasesDX_Code ;
      private String Z65BR_Diagnosis_DXID ;
      private String A65BR_Diagnosis_DXID ;
      private String Z66BR_Diagnosis_DXCode ;
      private String A66BR_Diagnosis_DXCode ;
      private String Z67BR_Diagnosis_DXType ;
      private String A67BR_Diagnosis_DXType ;
      private String Z68BR_Diagnosis_DXTsource ;
      private String A68BR_Diagnosis_DXTsource ;
      private String Z69BR_Diagnosis_DXDescription ;
      private String A69BR_Diagnosis_DXDescription ;
      private String Z70BR_Diagnosis_InitialDX ;
      private String A70BR_Diagnosis_InitialDX ;
      private String Z71BR_Diagnosis_MetastasesDX ;
      private String A71BR_Diagnosis_MetastasesDX ;
      private String Z260BR_Diagnosis_DXSource ;
      private String A260BR_Diagnosis_DXSource ;
      private String Z569BR_Diagnosis_TumorStageClinical ;
      private String A569BR_Diagnosis_TumorStageClinical ;
      private String Z36BR_Information_PatientNo ;
      private String A36BR_Information_PatientNo ;
      private IGxSession AV9WebSession ;
      private SdtBR_Diagnosis bcBR_Diagnosis ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] BC000C6_A85BR_Information_ID ;
      private bool[] BC000C6_n85BR_Information_ID ;
      private long[] BC000C6_A64BR_DiagnosisID ;
      private String[] BC000C6_A466BR_Diagnosis_DXType_Code ;
      private bool[] BC000C6_n466BR_Diagnosis_DXType_Code ;
      private String[] BC000C6_A467BR_Diagnosis_DXTsource_Code ;
      private bool[] BC000C6_n467BR_Diagnosis_DXTsource_Code ;
      private String[] BC000C6_A503BR_Diagnosis_InitialDX_Code ;
      private bool[] BC000C6_n503BR_Diagnosis_InitialDX_Code ;
      private String[] BC000C6_A504BR_Diagnosis_MetastasesDX_Code ;
      private bool[] BC000C6_n504BR_Diagnosis_MetastasesDX_Code ;
      private String[] BC000C6_A36BR_Information_PatientNo ;
      private bool[] BC000C6_n36BR_Information_PatientNo ;
      private long[] BC000C6_A513BR_Diagnosis_No ;
      private bool[] BC000C6_n513BR_Diagnosis_No ;
      private String[] BC000C6_A65BR_Diagnosis_DXID ;
      private bool[] BC000C6_n65BR_Diagnosis_DXID ;
      private String[] BC000C6_A66BR_Diagnosis_DXCode ;
      private bool[] BC000C6_n66BR_Diagnosis_DXCode ;
      private String[] BC000C6_A67BR_Diagnosis_DXType ;
      private bool[] BC000C6_n67BR_Diagnosis_DXType ;
      private String[] BC000C6_A68BR_Diagnosis_DXTsource ;
      private bool[] BC000C6_n68BR_Diagnosis_DXTsource ;
      private String[] BC000C6_A69BR_Diagnosis_DXDescription ;
      private bool[] BC000C6_n69BR_Diagnosis_DXDescription ;
      private String[] BC000C6_A70BR_Diagnosis_InitialDX ;
      private bool[] BC000C6_n70BR_Diagnosis_InitialDX ;
      private String[] BC000C6_A71BR_Diagnosis_MetastasesDX ;
      private bool[] BC000C6_n71BR_Diagnosis_MetastasesDX ;
      private String[] BC000C6_A260BR_Diagnosis_DXSource ;
      private bool[] BC000C6_n260BR_Diagnosis_DXSource ;
      private String[] BC000C6_A569BR_Diagnosis_TumorStageClinical ;
      private bool[] BC000C6_n569BR_Diagnosis_TumorStageClinical ;
      private long[] BC000C6_A19BR_EncounterID ;
      private long[] BC000C4_A85BR_Information_ID ;
      private bool[] BC000C4_n85BR_Information_ID ;
      private String[] BC000C5_A36BR_Information_PatientNo ;
      private bool[] BC000C5_n36BR_Information_PatientNo ;
      private long[] BC000C7_A64BR_DiagnosisID ;
      private long[] BC000C3_A64BR_DiagnosisID ;
      private String[] BC000C3_A466BR_Diagnosis_DXType_Code ;
      private bool[] BC000C3_n466BR_Diagnosis_DXType_Code ;
      private String[] BC000C3_A467BR_Diagnosis_DXTsource_Code ;
      private bool[] BC000C3_n467BR_Diagnosis_DXTsource_Code ;
      private String[] BC000C3_A503BR_Diagnosis_InitialDX_Code ;
      private bool[] BC000C3_n503BR_Diagnosis_InitialDX_Code ;
      private String[] BC000C3_A504BR_Diagnosis_MetastasesDX_Code ;
      private bool[] BC000C3_n504BR_Diagnosis_MetastasesDX_Code ;
      private long[] BC000C3_A513BR_Diagnosis_No ;
      private bool[] BC000C3_n513BR_Diagnosis_No ;
      private String[] BC000C3_A65BR_Diagnosis_DXID ;
      private bool[] BC000C3_n65BR_Diagnosis_DXID ;
      private String[] BC000C3_A66BR_Diagnosis_DXCode ;
      private bool[] BC000C3_n66BR_Diagnosis_DXCode ;
      private String[] BC000C3_A67BR_Diagnosis_DXType ;
      private bool[] BC000C3_n67BR_Diagnosis_DXType ;
      private String[] BC000C3_A68BR_Diagnosis_DXTsource ;
      private bool[] BC000C3_n68BR_Diagnosis_DXTsource ;
      private String[] BC000C3_A69BR_Diagnosis_DXDescription ;
      private bool[] BC000C3_n69BR_Diagnosis_DXDescription ;
      private String[] BC000C3_A70BR_Diagnosis_InitialDX ;
      private bool[] BC000C3_n70BR_Diagnosis_InitialDX ;
      private String[] BC000C3_A71BR_Diagnosis_MetastasesDX ;
      private bool[] BC000C3_n71BR_Diagnosis_MetastasesDX ;
      private String[] BC000C3_A260BR_Diagnosis_DXSource ;
      private bool[] BC000C3_n260BR_Diagnosis_DXSource ;
      private String[] BC000C3_A569BR_Diagnosis_TumorStageClinical ;
      private bool[] BC000C3_n569BR_Diagnosis_TumorStageClinical ;
      private long[] BC000C3_A19BR_EncounterID ;
      private long[] BC000C2_A64BR_DiagnosisID ;
      private String[] BC000C2_A466BR_Diagnosis_DXType_Code ;
      private bool[] BC000C2_n466BR_Diagnosis_DXType_Code ;
      private String[] BC000C2_A467BR_Diagnosis_DXTsource_Code ;
      private bool[] BC000C2_n467BR_Diagnosis_DXTsource_Code ;
      private String[] BC000C2_A503BR_Diagnosis_InitialDX_Code ;
      private bool[] BC000C2_n503BR_Diagnosis_InitialDX_Code ;
      private String[] BC000C2_A504BR_Diagnosis_MetastasesDX_Code ;
      private bool[] BC000C2_n504BR_Diagnosis_MetastasesDX_Code ;
      private long[] BC000C2_A513BR_Diagnosis_No ;
      private bool[] BC000C2_n513BR_Diagnosis_No ;
      private String[] BC000C2_A65BR_Diagnosis_DXID ;
      private bool[] BC000C2_n65BR_Diagnosis_DXID ;
      private String[] BC000C2_A66BR_Diagnosis_DXCode ;
      private bool[] BC000C2_n66BR_Diagnosis_DXCode ;
      private String[] BC000C2_A67BR_Diagnosis_DXType ;
      private bool[] BC000C2_n67BR_Diagnosis_DXType ;
      private String[] BC000C2_A68BR_Diagnosis_DXTsource ;
      private bool[] BC000C2_n68BR_Diagnosis_DXTsource ;
      private String[] BC000C2_A69BR_Diagnosis_DXDescription ;
      private bool[] BC000C2_n69BR_Diagnosis_DXDescription ;
      private String[] BC000C2_A70BR_Diagnosis_InitialDX ;
      private bool[] BC000C2_n70BR_Diagnosis_InitialDX ;
      private String[] BC000C2_A71BR_Diagnosis_MetastasesDX ;
      private bool[] BC000C2_n71BR_Diagnosis_MetastasesDX ;
      private String[] BC000C2_A260BR_Diagnosis_DXSource ;
      private bool[] BC000C2_n260BR_Diagnosis_DXSource ;
      private String[] BC000C2_A569BR_Diagnosis_TumorStageClinical ;
      private bool[] BC000C2_n569BR_Diagnosis_TumorStageClinical ;
      private long[] BC000C2_A19BR_EncounterID ;
      private long[] BC000C8_A64BR_DiagnosisID ;
      private long[] BC000C11_A85BR_Information_ID ;
      private bool[] BC000C11_n85BR_Information_ID ;
      private String[] BC000C12_A36BR_Information_PatientNo ;
      private bool[] BC000C12_n36BR_Information_PatientNo ;
      private long[] BC000C13_A85BR_Information_ID ;
      private bool[] BC000C13_n85BR_Information_ID ;
      private long[] BC000C13_A64BR_DiagnosisID ;
      private String[] BC000C13_A466BR_Diagnosis_DXType_Code ;
      private bool[] BC000C13_n466BR_Diagnosis_DXType_Code ;
      private String[] BC000C13_A467BR_Diagnosis_DXTsource_Code ;
      private bool[] BC000C13_n467BR_Diagnosis_DXTsource_Code ;
      private String[] BC000C13_A503BR_Diagnosis_InitialDX_Code ;
      private bool[] BC000C13_n503BR_Diagnosis_InitialDX_Code ;
      private String[] BC000C13_A504BR_Diagnosis_MetastasesDX_Code ;
      private bool[] BC000C13_n504BR_Diagnosis_MetastasesDX_Code ;
      private String[] BC000C13_A36BR_Information_PatientNo ;
      private bool[] BC000C13_n36BR_Information_PatientNo ;
      private long[] BC000C13_A513BR_Diagnosis_No ;
      private bool[] BC000C13_n513BR_Diagnosis_No ;
      private String[] BC000C13_A65BR_Diagnosis_DXID ;
      private bool[] BC000C13_n65BR_Diagnosis_DXID ;
      private String[] BC000C13_A66BR_Diagnosis_DXCode ;
      private bool[] BC000C13_n66BR_Diagnosis_DXCode ;
      private String[] BC000C13_A67BR_Diagnosis_DXType ;
      private bool[] BC000C13_n67BR_Diagnosis_DXType ;
      private String[] BC000C13_A68BR_Diagnosis_DXTsource ;
      private bool[] BC000C13_n68BR_Diagnosis_DXTsource ;
      private String[] BC000C13_A69BR_Diagnosis_DXDescription ;
      private bool[] BC000C13_n69BR_Diagnosis_DXDescription ;
      private String[] BC000C13_A70BR_Diagnosis_InitialDX ;
      private bool[] BC000C13_n70BR_Diagnosis_InitialDX ;
      private String[] BC000C13_A71BR_Diagnosis_MetastasesDX ;
      private bool[] BC000C13_n71BR_Diagnosis_MetastasesDX ;
      private String[] BC000C13_A260BR_Diagnosis_DXSource ;
      private bool[] BC000C13_n260BR_Diagnosis_DXSource ;
      private String[] BC000C13_A569BR_Diagnosis_TumorStageClinical ;
      private bool[] BC000C13_n569BR_Diagnosis_TumorStageClinical ;
      private long[] BC000C13_A19BR_EncounterID ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_datastore1 ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV7WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV8TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV11TrnContextAtt ;
   }

   public class br_diagnosis_bc__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class br_diagnosis_bc__default : DataStoreHelperBase, IDataStoreHelper
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
        Object[] prmBC000C6 ;
        prmBC000C6 = new Object[] {
        new Object[] {"@BR_DiagnosisID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000C4 ;
        prmBC000C4 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000C5 ;
        prmBC000C5 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000C7 ;
        prmBC000C7 = new Object[] {
        new Object[] {"@BR_DiagnosisID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000C3 ;
        prmBC000C3 = new Object[] {
        new Object[] {"@BR_DiagnosisID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000C2 ;
        prmBC000C2 = new Object[] {
        new Object[] {"@BR_DiagnosisID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000C8 ;
        prmBC000C8 = new Object[] {
        new Object[] {"@BR_Diagnosis_DXType_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Diagnosis_DXTsource_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Diagnosis_InitialDX_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Diagnosis_MetastasesDX_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Diagnosis_No",SqlDbType.Decimal,10,0} ,
        new Object[] {"@BR_Diagnosis_DXID",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Diagnosis_DXCode",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Diagnosis_DXType",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Diagnosis_DXTsource",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Diagnosis_DXDescription",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Diagnosis_InitialDX",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Diagnosis_MetastasesDX",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Diagnosis_DXSource",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Diagnosis_TumorStageClinical",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000C9 ;
        prmBC000C9 = new Object[] {
        new Object[] {"@BR_Diagnosis_DXType_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Diagnosis_DXTsource_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Diagnosis_InitialDX_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Diagnosis_MetastasesDX_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Diagnosis_No",SqlDbType.Decimal,10,0} ,
        new Object[] {"@BR_Diagnosis_DXID",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Diagnosis_DXCode",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Diagnosis_DXType",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Diagnosis_DXTsource",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Diagnosis_DXDescription",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Diagnosis_InitialDX",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Diagnosis_MetastasesDX",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Diagnosis_DXSource",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Diagnosis_TumorStageClinical",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_DiagnosisID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000C10 ;
        prmBC000C10 = new Object[] {
        new Object[] {"@BR_DiagnosisID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000C11 ;
        prmBC000C11 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000C12 ;
        prmBC000C12 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000C13 ;
        prmBC000C13 = new Object[] {
        new Object[] {"@BR_DiagnosisID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("BC000C2", "SELECT [BR_DiagnosisID], [BR_Diagnosis_DXType_Code], [BR_Diagnosis_DXTsource_Code], [BR_Diagnosis_InitialDX_Code], [BR_Diagnosis_MetastasesDX_Code], [BR_Diagnosis_No], [BR_Diagnosis_DXID], [BR_Diagnosis_DXCode], [BR_Diagnosis_DXType], [BR_Diagnosis_DXTsource], [BR_Diagnosis_DXDescription], [BR_Diagnosis_InitialDX], [BR_Diagnosis_MetastasesDX], [BR_Diagnosis_DXSource], [BR_Diagnosis_TumorStageClinical], [BR_EncounterID] FROM [BR_Diagnosis] WITH (UPDLOCK) WHERE [BR_DiagnosisID] = @BR_DiagnosisID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000C2,1,0,true,false )
           ,new CursorDef("BC000C3", "SELECT [BR_DiagnosisID], [BR_Diagnosis_DXType_Code], [BR_Diagnosis_DXTsource_Code], [BR_Diagnosis_InitialDX_Code], [BR_Diagnosis_MetastasesDX_Code], [BR_Diagnosis_No], [BR_Diagnosis_DXID], [BR_Diagnosis_DXCode], [BR_Diagnosis_DXType], [BR_Diagnosis_DXTsource], [BR_Diagnosis_DXDescription], [BR_Diagnosis_InitialDX], [BR_Diagnosis_MetastasesDX], [BR_Diagnosis_DXSource], [BR_Diagnosis_TumorStageClinical], [BR_EncounterID] FROM [BR_Diagnosis] WITH (NOLOCK) WHERE [BR_DiagnosisID] = @BR_DiagnosisID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000C3,1,0,true,false )
           ,new CursorDef("BC000C4", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000C4,1,0,true,false )
           ,new CursorDef("BC000C5", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000C5,1,0,true,false )
           ,new CursorDef("BC000C6", "SELECT T2.[BR_Information_ID], TM1.[BR_DiagnosisID], TM1.[BR_Diagnosis_DXType_Code], TM1.[BR_Diagnosis_DXTsource_Code], TM1.[BR_Diagnosis_InitialDX_Code], TM1.[BR_Diagnosis_MetastasesDX_Code], T3.[BR_Information_PatientNo], TM1.[BR_Diagnosis_No], TM1.[BR_Diagnosis_DXID], TM1.[BR_Diagnosis_DXCode], TM1.[BR_Diagnosis_DXType], TM1.[BR_Diagnosis_DXTsource], TM1.[BR_Diagnosis_DXDescription], TM1.[BR_Diagnosis_InitialDX], TM1.[BR_Diagnosis_MetastasesDX], TM1.[BR_Diagnosis_DXSource], TM1.[BR_Diagnosis_TumorStageClinical], TM1.[BR_EncounterID] FROM (([BR_Diagnosis] TM1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = TM1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID]) WHERE TM1.[BR_DiagnosisID] = @BR_DiagnosisID ORDER BY TM1.[BR_DiagnosisID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000C6,100,0,true,false )
           ,new CursorDef("BC000C7", "SELECT [BR_DiagnosisID] FROM [BR_Diagnosis] WITH (NOLOCK) WHERE [BR_DiagnosisID] = @BR_DiagnosisID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000C7,1,0,true,false )
           ,new CursorDef("BC000C8", "INSERT INTO [BR_Diagnosis]([BR_Diagnosis_DXType_Code], [BR_Diagnosis_DXTsource_Code], [BR_Diagnosis_InitialDX_Code], [BR_Diagnosis_MetastasesDX_Code], [BR_Diagnosis_No], [BR_Diagnosis_DXID], [BR_Diagnosis_DXCode], [BR_Diagnosis_DXType], [BR_Diagnosis_DXTsource], [BR_Diagnosis_DXDescription], [BR_Diagnosis_InitialDX], [BR_Diagnosis_MetastasesDX], [BR_Diagnosis_DXSource], [BR_Diagnosis_TumorStageClinical], [BR_EncounterID]) VALUES(@BR_Diagnosis_DXType_Code, @BR_Diagnosis_DXTsource_Code, @BR_Diagnosis_InitialDX_Code, @BR_Diagnosis_MetastasesDX_Code, @BR_Diagnosis_No, @BR_Diagnosis_DXID, @BR_Diagnosis_DXCode, @BR_Diagnosis_DXType, @BR_Diagnosis_DXTsource, @BR_Diagnosis_DXDescription, @BR_Diagnosis_InitialDX, @BR_Diagnosis_MetastasesDX, @BR_Diagnosis_DXSource, @BR_Diagnosis_TumorStageClinical, @BR_EncounterID); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmBC000C8)
           ,new CursorDef("BC000C9", "UPDATE [BR_Diagnosis] SET [BR_Diagnosis_DXType_Code]=@BR_Diagnosis_DXType_Code, [BR_Diagnosis_DXTsource_Code]=@BR_Diagnosis_DXTsource_Code, [BR_Diagnosis_InitialDX_Code]=@BR_Diagnosis_InitialDX_Code, [BR_Diagnosis_MetastasesDX_Code]=@BR_Diagnosis_MetastasesDX_Code, [BR_Diagnosis_No]=@BR_Diagnosis_No, [BR_Diagnosis_DXID]=@BR_Diagnosis_DXID, [BR_Diagnosis_DXCode]=@BR_Diagnosis_DXCode, [BR_Diagnosis_DXType]=@BR_Diagnosis_DXType, [BR_Diagnosis_DXTsource]=@BR_Diagnosis_DXTsource, [BR_Diagnosis_DXDescription]=@BR_Diagnosis_DXDescription, [BR_Diagnosis_InitialDX]=@BR_Diagnosis_InitialDX, [BR_Diagnosis_MetastasesDX]=@BR_Diagnosis_MetastasesDX, [BR_Diagnosis_DXSource]=@BR_Diagnosis_DXSource, [BR_Diagnosis_TumorStageClinical]=@BR_Diagnosis_TumorStageClinical, [BR_EncounterID]=@BR_EncounterID  WHERE [BR_DiagnosisID] = @BR_DiagnosisID", GxErrorMask.GX_NOMASK,prmBC000C9)
           ,new CursorDef("BC000C10", "DELETE FROM [BR_Diagnosis]  WHERE [BR_DiagnosisID] = @BR_DiagnosisID", GxErrorMask.GX_NOMASK,prmBC000C10)
           ,new CursorDef("BC000C11", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000C11,1,0,true,false )
           ,new CursorDef("BC000C12", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000C12,1,0,true,false )
           ,new CursorDef("BC000C13", "SELECT T2.[BR_Information_ID], TM1.[BR_DiagnosisID], TM1.[BR_Diagnosis_DXType_Code], TM1.[BR_Diagnosis_DXTsource_Code], TM1.[BR_Diagnosis_InitialDX_Code], TM1.[BR_Diagnosis_MetastasesDX_Code], T3.[BR_Information_PatientNo], TM1.[BR_Diagnosis_No], TM1.[BR_Diagnosis_DXID], TM1.[BR_Diagnosis_DXCode], TM1.[BR_Diagnosis_DXType], TM1.[BR_Diagnosis_DXTsource], TM1.[BR_Diagnosis_DXDescription], TM1.[BR_Diagnosis_InitialDX], TM1.[BR_Diagnosis_MetastasesDX], TM1.[BR_Diagnosis_DXSource], TM1.[BR_Diagnosis_TumorStageClinical], TM1.[BR_EncounterID] FROM (([BR_Diagnosis] TM1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = TM1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID]) WHERE TM1.[BR_DiagnosisID] = @BR_DiagnosisID ORDER BY TM1.[BR_DiagnosisID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000C13,100,0,true,false )
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
              ((long[]) buf[29])[0] = rslt.getLong(16) ;
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
              ((long[]) buf[29])[0] = rslt.getLong(16) ;
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
              ((long[]) buf[33])[0] = rslt.getLong(18) ;
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
              ((long[]) buf[33])[0] = rslt.getLong(18) ;
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
              stmt.SetParameter(15, (long)parms[28]);
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
              stmt.SetParameter(15, (long)parms[28]);
              stmt.SetParameter(16, (long)parms[29]);
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
