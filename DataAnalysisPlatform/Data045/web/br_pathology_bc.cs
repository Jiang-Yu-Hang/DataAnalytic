/*
               File: BR_Pathology_BC
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:8:27.62
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
   public class br_pathology_bc : GXHttpHandler, IGxSilentTrn
   {
      public br_pathology_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_pathology_bc( IGxContext context )
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
         ReadRow0Z36( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey0Z36( ) ;
         standaloneModal( ) ;
         AddRow0Z36( ) ;
         Gx_mode = "INS";
         return  ;
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E110Z2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               Z226BR_PathologyID = A226BR_PathologyID;
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

      protected void CONFIRM_0Z0( )
      {
         BeforeValidate0Z36( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0Z36( ) ;
            }
            else
            {
               CheckExtendedTable0Z36( ) ;
               if ( AnyError == 0 )
               {
                  ZM0Z36( 19) ;
                  ZM0Z36( 20) ;
               }
               CloseExtendedTableCursors0Z36( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void E120Z2( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV8WWPContext) ;
         AV9IsAuthorized = true;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_Pathology", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_Pathology", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Pathology", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
         }
         if ( ! AV9IsAuthorized )
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
         AV11TrnContext.FromXml(AV12WebSession.Get("TrnContext"), null, "WWPTransactionContext", "DataAnalysisPlatform");
         if ( ( StringUtil.StrCmp(AV11TrnContext.gxTpr_Transactionname, AV17Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV18GXV1 = 1;
            while ( AV18GXV1 <= AV11TrnContext.gxTpr_Attributes.Count )
            {
               AV14TrnContextAtt = ((GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute)AV11TrnContext.gxTpr_Attributes.Item(AV18GXV1));
               if ( StringUtil.StrCmp(AV14TrnContextAtt.gxTpr_Attributename, "BR_EncounterID") == 0 )
               {
                  AV13Insert_BR_EncounterID = (long)(NumberUtil.Val( AV14TrnContextAtt.gxTpr_Attributevalue, "."));
               }
               AV18GXV1 = (int)(AV18GXV1+1);
            }
         }
      }

      protected void E110Z2( )
      {
         /* After Trn Routine */
      }

      protected void S112( )
      {
         /* 'ATTRIBUTESSECURITYCODE' Routine */
      }

      protected void ZM0Z36( short GX_JID )
      {
         if ( ( GX_JID == 18 ) || ( GX_JID == 0 ) )
         {
            Z505BR_Pathology_N_Code = A505BR_Pathology_N_Code;
            Z506BR_Pathology_M_Code = A506BR_Pathology_M_Code;
            Z508BR_PathologyID_PAHosp_Code = A508BR_PathologyID_PAHosp_Code;
            Z237BR_PathologyID_TestID = A237BR_PathologyID_TestID;
            Z238BR_PathologyID_PADate = A238BR_PathologyID_PADate;
            Z239BR_PathologyID_PAHosp = A239BR_PathologyID_PAHosp;
            Z240BR_PathologyID_PAAge = A240BR_PathologyID_PAAge;
            Z241BR_PathologyID_PrePaDia = A241BR_PathologyID_PrePaDia;
            Z242BR_PathologyID_PAResult = A242BR_PathologyID_PAResult;
            Z326BR_Pathology_Dia_Name = A326BR_Pathology_Dia_Name;
            Z314BR_Pathology_T = A314BR_Pathology_T;
            Z315BR_Pathology_N = A315BR_Pathology_N;
            Z316BR_Pathology_LymphNum = A316BR_Pathology_LymphNum;
            Z317BR_Pathology_LymphRate = A317BR_Pathology_LymphRate;
            Z318BR_Pathology_M = A318BR_Pathology_M;
            Z319BR_Pathology_MetaLoc = A319BR_Pathology_MetaLoc;
            Z19BR_EncounterID = A19BR_EncounterID;
         }
         if ( ( GX_JID == 19 ) || ( GX_JID == 0 ) )
         {
            Z85BR_Information_ID = A85BR_Information_ID;
         }
         if ( ( GX_JID == 20 ) || ( GX_JID == 0 ) )
         {
            Z36BR_Information_PatientNo = A36BR_Information_PatientNo;
         }
         if ( GX_JID == -18 )
         {
            Z226BR_PathologyID = A226BR_PathologyID;
            Z505BR_Pathology_N_Code = A505BR_Pathology_N_Code;
            Z506BR_Pathology_M_Code = A506BR_Pathology_M_Code;
            Z508BR_PathologyID_PAHosp_Code = A508BR_PathologyID_PAHosp_Code;
            Z237BR_PathologyID_TestID = A237BR_PathologyID_TestID;
            Z238BR_PathologyID_PADate = A238BR_PathologyID_PADate;
            Z239BR_PathologyID_PAHosp = A239BR_PathologyID_PAHosp;
            Z240BR_PathologyID_PAAge = A240BR_PathologyID_PAAge;
            Z241BR_PathologyID_PrePaDia = A241BR_PathologyID_PrePaDia;
            Z242BR_PathologyID_PAResult = A242BR_PathologyID_PAResult;
            Z326BR_Pathology_Dia_Name = A326BR_Pathology_Dia_Name;
            Z314BR_Pathology_T = A314BR_Pathology_T;
            Z315BR_Pathology_N = A315BR_Pathology_N;
            Z316BR_Pathology_LymphNum = A316BR_Pathology_LymphNum;
            Z317BR_Pathology_LymphRate = A317BR_Pathology_LymphRate;
            Z318BR_Pathology_M = A318BR_Pathology_M;
            Z319BR_Pathology_MetaLoc = A319BR_Pathology_MetaLoc;
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

      protected void Load0Z36( )
      {
         /* Using cursor BC000Z6 */
         pr_default.execute(4, new Object[] {n226BR_PathologyID, A226BR_PathologyID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound36 = 1;
            A85BR_Information_ID = BC000Z6_A85BR_Information_ID[0];
            n85BR_Information_ID = BC000Z6_n85BR_Information_ID[0];
            A505BR_Pathology_N_Code = BC000Z6_A505BR_Pathology_N_Code[0];
            n505BR_Pathology_N_Code = BC000Z6_n505BR_Pathology_N_Code[0];
            A506BR_Pathology_M_Code = BC000Z6_A506BR_Pathology_M_Code[0];
            n506BR_Pathology_M_Code = BC000Z6_n506BR_Pathology_M_Code[0];
            A508BR_PathologyID_PAHosp_Code = BC000Z6_A508BR_PathologyID_PAHosp_Code[0];
            n508BR_PathologyID_PAHosp_Code = BC000Z6_n508BR_PathologyID_PAHosp_Code[0];
            A36BR_Information_PatientNo = BC000Z6_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = BC000Z6_n36BR_Information_PatientNo[0];
            A237BR_PathologyID_TestID = BC000Z6_A237BR_PathologyID_TestID[0];
            n237BR_PathologyID_TestID = BC000Z6_n237BR_PathologyID_TestID[0];
            A238BR_PathologyID_PADate = BC000Z6_A238BR_PathologyID_PADate[0];
            n238BR_PathologyID_PADate = BC000Z6_n238BR_PathologyID_PADate[0];
            A239BR_PathologyID_PAHosp = BC000Z6_A239BR_PathologyID_PAHosp[0];
            n239BR_PathologyID_PAHosp = BC000Z6_n239BR_PathologyID_PAHosp[0];
            A240BR_PathologyID_PAAge = BC000Z6_A240BR_PathologyID_PAAge[0];
            n240BR_PathologyID_PAAge = BC000Z6_n240BR_PathologyID_PAAge[0];
            A241BR_PathologyID_PrePaDia = BC000Z6_A241BR_PathologyID_PrePaDia[0];
            n241BR_PathologyID_PrePaDia = BC000Z6_n241BR_PathologyID_PrePaDia[0];
            A242BR_PathologyID_PAResult = BC000Z6_A242BR_PathologyID_PAResult[0];
            n242BR_PathologyID_PAResult = BC000Z6_n242BR_PathologyID_PAResult[0];
            A326BR_Pathology_Dia_Name = BC000Z6_A326BR_Pathology_Dia_Name[0];
            n326BR_Pathology_Dia_Name = BC000Z6_n326BR_Pathology_Dia_Name[0];
            A314BR_Pathology_T = BC000Z6_A314BR_Pathology_T[0];
            n314BR_Pathology_T = BC000Z6_n314BR_Pathology_T[0];
            A315BR_Pathology_N = BC000Z6_A315BR_Pathology_N[0];
            n315BR_Pathology_N = BC000Z6_n315BR_Pathology_N[0];
            A316BR_Pathology_LymphNum = BC000Z6_A316BR_Pathology_LymphNum[0];
            n316BR_Pathology_LymphNum = BC000Z6_n316BR_Pathology_LymphNum[0];
            A317BR_Pathology_LymphRate = BC000Z6_A317BR_Pathology_LymphRate[0];
            n317BR_Pathology_LymphRate = BC000Z6_n317BR_Pathology_LymphRate[0];
            A318BR_Pathology_M = BC000Z6_A318BR_Pathology_M[0];
            n318BR_Pathology_M = BC000Z6_n318BR_Pathology_M[0];
            A319BR_Pathology_MetaLoc = BC000Z6_A319BR_Pathology_MetaLoc[0];
            n319BR_Pathology_MetaLoc = BC000Z6_n319BR_Pathology_MetaLoc[0];
            A19BR_EncounterID = BC000Z6_A19BR_EncounterID[0];
            n19BR_EncounterID = BC000Z6_n19BR_EncounterID[0];
            ZM0Z36( -18) ;
         }
         pr_default.close(4);
         OnLoadActions0Z36( ) ;
      }

      protected void OnLoadActions0Z36( )
      {
         AV17Pgmname = "BR_Pathology_BC";
      }

      protected void CheckExtendedTable0Z36( )
      {
         standaloneModal( ) ;
         AV17Pgmname = "BR_Pathology_BC";
         /* Using cursor BC000Z4 */
         pr_default.execute(2, new Object[] {n19BR_EncounterID, A19BR_EncounterID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            if ( ! ( (0==A19BR_EncounterID) ) )
            {
               GX_msglist.addItem("不匹配' T15'", "ForeignKeyNotFound", 1, "BR_ENCOUNTERID");
               AnyError = 1;
            }
         }
         A85BR_Information_ID = BC000Z4_A85BR_Information_ID[0];
         n85BR_Information_ID = BC000Z4_n85BR_Information_ID[0];
         pr_default.close(2);
         /* Using cursor BC000Z5 */
         pr_default.execute(3, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
         if ( (pr_default.getStatus(3) == 101) )
         {
            if ( ! ( (0==A85BR_Information_ID) ) )
            {
               GX_msglist.addItem("不匹配' T16'", "ForeignKeyNotFound", 1, "");
               AnyError = 1;
            }
         }
         A36BR_Information_PatientNo = BC000Z5_A36BR_Information_PatientNo[0];
         n36BR_Information_PatientNo = BC000Z5_n36BR_Information_PatientNo[0];
         pr_default.close(3);
         if ( ! ( (DateTime.MinValue==A238BR_PathologyID_PADate) || ( A238BR_PathologyID_PADate >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("域病理检查日期超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
         if ( (DateTime.MinValue==A238BR_PathologyID_PADate) )
         {
            GX_msglist.addItem("病理检查日期是必须填写的。", 1, "");
            AnyError = 1;
         }
         if ( (0==A240BR_PathologyID_PAAge) )
         {
            GX_msglist.addItem("年龄是必须填写的。", 1, "");
            AnyError = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A326BR_Pathology_Dia_Name)) )
         {
            GX_msglist.addItem("病理诊断名称是必须填写的。", 1, "");
            AnyError = 1;
         }
         if ( ! ( ( StringUtil.StrCmp(A315BR_Pathology_N, "否") == 0 ) || ( StringUtil.StrCmp(A315BR_Pathology_N, "是") == 0 ) || ( StringUtil.StrCmp(A315BR_Pathology_N, "不详") == 0 ) || String.IsNullOrEmpty(StringUtil.RTrim( A315BR_Pathology_N)) ) )
         {
            GX_msglist.addItem("域是否淋巴结转移超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
         if ( ! ( ( StringUtil.StrCmp(A318BR_Pathology_M, "否") == 0 ) || ( StringUtil.StrCmp(A318BR_Pathology_M, "是") == 0 ) || ( StringUtil.StrCmp(A318BR_Pathology_M, "不详") == 0 ) || String.IsNullOrEmpty(StringUtil.RTrim( A318BR_Pathology_M)) ) )
         {
            GX_msglist.addItem("域是否远端转移超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
      }

      protected void CloseExtendedTableCursors0Z36( )
      {
         pr_default.close(2);
         pr_default.close(3);
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0Z36( )
      {
         /* Using cursor BC000Z7 */
         pr_default.execute(5, new Object[] {n226BR_PathologyID, A226BR_PathologyID});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound36 = 1;
         }
         else
         {
            RcdFound36 = 0;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC000Z3 */
         pr_default.execute(1, new Object[] {n226BR_PathologyID, A226BR_PathologyID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0Z36( 18) ;
            RcdFound36 = 1;
            A226BR_PathologyID = BC000Z3_A226BR_PathologyID[0];
            n226BR_PathologyID = BC000Z3_n226BR_PathologyID[0];
            A505BR_Pathology_N_Code = BC000Z3_A505BR_Pathology_N_Code[0];
            n505BR_Pathology_N_Code = BC000Z3_n505BR_Pathology_N_Code[0];
            A506BR_Pathology_M_Code = BC000Z3_A506BR_Pathology_M_Code[0];
            n506BR_Pathology_M_Code = BC000Z3_n506BR_Pathology_M_Code[0];
            A508BR_PathologyID_PAHosp_Code = BC000Z3_A508BR_PathologyID_PAHosp_Code[0];
            n508BR_PathologyID_PAHosp_Code = BC000Z3_n508BR_PathologyID_PAHosp_Code[0];
            A237BR_PathologyID_TestID = BC000Z3_A237BR_PathologyID_TestID[0];
            n237BR_PathologyID_TestID = BC000Z3_n237BR_PathologyID_TestID[0];
            A238BR_PathologyID_PADate = BC000Z3_A238BR_PathologyID_PADate[0];
            n238BR_PathologyID_PADate = BC000Z3_n238BR_PathologyID_PADate[0];
            A239BR_PathologyID_PAHosp = BC000Z3_A239BR_PathologyID_PAHosp[0];
            n239BR_PathologyID_PAHosp = BC000Z3_n239BR_PathologyID_PAHosp[0];
            A240BR_PathologyID_PAAge = BC000Z3_A240BR_PathologyID_PAAge[0];
            n240BR_PathologyID_PAAge = BC000Z3_n240BR_PathologyID_PAAge[0];
            A241BR_PathologyID_PrePaDia = BC000Z3_A241BR_PathologyID_PrePaDia[0];
            n241BR_PathologyID_PrePaDia = BC000Z3_n241BR_PathologyID_PrePaDia[0];
            A242BR_PathologyID_PAResult = BC000Z3_A242BR_PathologyID_PAResult[0];
            n242BR_PathologyID_PAResult = BC000Z3_n242BR_PathologyID_PAResult[0];
            A326BR_Pathology_Dia_Name = BC000Z3_A326BR_Pathology_Dia_Name[0];
            n326BR_Pathology_Dia_Name = BC000Z3_n326BR_Pathology_Dia_Name[0];
            A314BR_Pathology_T = BC000Z3_A314BR_Pathology_T[0];
            n314BR_Pathology_T = BC000Z3_n314BR_Pathology_T[0];
            A315BR_Pathology_N = BC000Z3_A315BR_Pathology_N[0];
            n315BR_Pathology_N = BC000Z3_n315BR_Pathology_N[0];
            A316BR_Pathology_LymphNum = BC000Z3_A316BR_Pathology_LymphNum[0];
            n316BR_Pathology_LymphNum = BC000Z3_n316BR_Pathology_LymphNum[0];
            A317BR_Pathology_LymphRate = BC000Z3_A317BR_Pathology_LymphRate[0];
            n317BR_Pathology_LymphRate = BC000Z3_n317BR_Pathology_LymphRate[0];
            A318BR_Pathology_M = BC000Z3_A318BR_Pathology_M[0];
            n318BR_Pathology_M = BC000Z3_n318BR_Pathology_M[0];
            A319BR_Pathology_MetaLoc = BC000Z3_A319BR_Pathology_MetaLoc[0];
            n319BR_Pathology_MetaLoc = BC000Z3_n319BR_Pathology_MetaLoc[0];
            A19BR_EncounterID = BC000Z3_A19BR_EncounterID[0];
            n19BR_EncounterID = BC000Z3_n19BR_EncounterID[0];
            Z226BR_PathologyID = A226BR_PathologyID;
            sMode36 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load0Z36( ) ;
            if ( AnyError == 1 )
            {
               RcdFound36 = 0;
               InitializeNonKey0Z36( ) ;
            }
            Gx_mode = sMode36;
         }
         else
         {
            RcdFound36 = 0;
            InitializeNonKey0Z36( ) ;
            sMode36 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode36;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0Z36( ) ;
         if ( RcdFound36 == 0 )
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
         CONFIRM_0Z0( ) ;
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

      protected void CheckOptimisticConcurrency0Z36( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC000Z2 */
            pr_default.execute(0, new Object[] {n226BR_PathologyID, A226BR_PathologyID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Pathology"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z505BR_Pathology_N_Code, BC000Z2_A505BR_Pathology_N_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z506BR_Pathology_M_Code, BC000Z2_A506BR_Pathology_M_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z508BR_PathologyID_PAHosp_Code, BC000Z2_A508BR_PathologyID_PAHosp_Code[0]) != 0 ) || ( Z237BR_PathologyID_TestID != BC000Z2_A237BR_PathologyID_TestID[0] ) || ( Z238BR_PathologyID_PADate != BC000Z2_A238BR_PathologyID_PADate[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z239BR_PathologyID_PAHosp, BC000Z2_A239BR_PathologyID_PAHosp[0]) != 0 ) || ( Z240BR_PathologyID_PAAge != BC000Z2_A240BR_PathologyID_PAAge[0] ) || ( StringUtil.StrCmp(Z241BR_PathologyID_PrePaDia, BC000Z2_A241BR_PathologyID_PrePaDia[0]) != 0 ) || ( StringUtil.StrCmp(Z242BR_PathologyID_PAResult, BC000Z2_A242BR_PathologyID_PAResult[0]) != 0 ) || ( StringUtil.StrCmp(Z326BR_Pathology_Dia_Name, BC000Z2_A326BR_Pathology_Dia_Name[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z314BR_Pathology_T != BC000Z2_A314BR_Pathology_T[0] ) || ( StringUtil.StrCmp(Z315BR_Pathology_N, BC000Z2_A315BR_Pathology_N[0]) != 0 ) || ( Z316BR_Pathology_LymphNum != BC000Z2_A316BR_Pathology_LymphNum[0] ) || ( StringUtil.StrCmp(Z317BR_Pathology_LymphRate, BC000Z2_A317BR_Pathology_LymphRate[0]) != 0 ) || ( StringUtil.StrCmp(Z318BR_Pathology_M, BC000Z2_A318BR_Pathology_M[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z319BR_Pathology_MetaLoc, BC000Z2_A319BR_Pathology_MetaLoc[0]) != 0 ) || ( Z19BR_EncounterID != BC000Z2_A19BR_EncounterID[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"BR_Pathology"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0Z36( )
      {
         BeforeValidate0Z36( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0Z36( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0Z36( 0) ;
            CheckOptimisticConcurrency0Z36( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0Z36( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0Z36( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000Z8 */
                     pr_default.execute(6, new Object[] {n505BR_Pathology_N_Code, A505BR_Pathology_N_Code, n506BR_Pathology_M_Code, A506BR_Pathology_M_Code, n508BR_PathologyID_PAHosp_Code, A508BR_PathologyID_PAHosp_Code, n237BR_PathologyID_TestID, A237BR_PathologyID_TestID, n238BR_PathologyID_PADate, A238BR_PathologyID_PADate, n239BR_PathologyID_PAHosp, A239BR_PathologyID_PAHosp, n240BR_PathologyID_PAAge, A240BR_PathologyID_PAAge, n241BR_PathologyID_PrePaDia, A241BR_PathologyID_PrePaDia, n242BR_PathologyID_PAResult, A242BR_PathologyID_PAResult, n326BR_Pathology_Dia_Name, A326BR_Pathology_Dia_Name, n314BR_Pathology_T, A314BR_Pathology_T, n315BR_Pathology_N, A315BR_Pathology_N, n316BR_Pathology_LymphNum, A316BR_Pathology_LymphNum, n317BR_Pathology_LymphRate, A317BR_Pathology_LymphRate, n318BR_Pathology_M, A318BR_Pathology_M, n319BR_Pathology_MetaLoc, A319BR_Pathology_MetaLoc, n19BR_EncounterID, A19BR_EncounterID});
                     A226BR_PathologyID = BC000Z8_A226BR_PathologyID[0];
                     n226BR_PathologyID = BC000Z8_n226BR_PathologyID[0];
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Pathology") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)),  "病理学",  "Create",  1) ;
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
               Load0Z36( ) ;
            }
            EndLevel0Z36( ) ;
         }
         CloseExtendedTableCursors0Z36( ) ;
      }

      protected void Update0Z36( )
      {
         BeforeValidate0Z36( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0Z36( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0Z36( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0Z36( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0Z36( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000Z9 */
                     pr_default.execute(7, new Object[] {n505BR_Pathology_N_Code, A505BR_Pathology_N_Code, n506BR_Pathology_M_Code, A506BR_Pathology_M_Code, n508BR_PathologyID_PAHosp_Code, A508BR_PathologyID_PAHosp_Code, n237BR_PathologyID_TestID, A237BR_PathologyID_TestID, n238BR_PathologyID_PADate, A238BR_PathologyID_PADate, n239BR_PathologyID_PAHosp, A239BR_PathologyID_PAHosp, n240BR_PathologyID_PAAge, A240BR_PathologyID_PAAge, n241BR_PathologyID_PrePaDia, A241BR_PathologyID_PrePaDia, n242BR_PathologyID_PAResult, A242BR_PathologyID_PAResult, n326BR_Pathology_Dia_Name, A326BR_Pathology_Dia_Name, n314BR_Pathology_T, A314BR_Pathology_T, n315BR_Pathology_N, A315BR_Pathology_N, n316BR_Pathology_LymphNum, A316BR_Pathology_LymphNum, n317BR_Pathology_LymphRate, A317BR_Pathology_LymphRate, n318BR_Pathology_M, A318BR_Pathology_M, n319BR_Pathology_MetaLoc, A319BR_Pathology_MetaLoc, n19BR_EncounterID, A19BR_EncounterID, n226BR_PathologyID, A226BR_PathologyID});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Pathology") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Pathology"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0Z36( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)),  "病理学",  "Update",  1) ;
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
            EndLevel0Z36( ) ;
         }
         CloseExtendedTableCursors0Z36( ) ;
      }

      protected void DeferredUpdate0Z36( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate0Z36( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0Z36( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0Z36( ) ;
            AfterConfirm0Z36( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0Z36( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC000Z10 */
                  pr_default.execute(8, new Object[] {n226BR_PathologyID, A226BR_PathologyID});
                  pr_default.close(8);
                  dsDefault.SmartCacheProvider.SetUpdated("BR_Pathology") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)),  "病理学",  "Delete",  1) ;
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
         sMode36 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel0Z36( ) ;
         Gx_mode = sMode36;
      }

      protected void OnDeleteControls0Z36( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV17Pgmname = "BR_Pathology_BC";
            /* Using cursor BC000Z11 */
            pr_default.execute(9, new Object[] {n19BR_EncounterID, A19BR_EncounterID});
            A85BR_Information_ID = BC000Z11_A85BR_Information_ID[0];
            n85BR_Information_ID = BC000Z11_n85BR_Information_ID[0];
            pr_default.close(9);
            /* Using cursor BC000Z12 */
            pr_default.execute(10, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
            A36BR_Information_PatientNo = BC000Z12_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = BC000Z12_n36BR_Information_PatientNo[0];
            pr_default.close(10);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor BC000Z13 */
            pr_default.execute(11, new Object[] {n226BR_PathologyID, A226BR_PathologyID});
            if ( (pr_default.getStatus(11) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {" T35"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(11);
            /* Using cursor BC000Z14 */
            pr_default.execute(12, new Object[] {n226BR_PathologyID, A226BR_PathologyID});
            if ( (pr_default.getStatus(12) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {" T34"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(12);
            /* Using cursor BC000Z15 */
            pr_default.execute(13, new Object[] {n226BR_PathologyID, A226BR_PathologyID});
            if ( (pr_default.getStatus(13) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {" T33"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(13);
         }
      }

      protected void EndLevel0Z36( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0Z36( ) ;
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

      public void ScanKeyStart0Z36( )
      {
         /* Scan By routine */
         /* Using cursor BC000Z16 */
         pr_default.execute(14, new Object[] {n226BR_PathologyID, A226BR_PathologyID});
         RcdFound36 = 0;
         if ( (pr_default.getStatus(14) != 101) )
         {
            RcdFound36 = 1;
            A85BR_Information_ID = BC000Z16_A85BR_Information_ID[0];
            n85BR_Information_ID = BC000Z16_n85BR_Information_ID[0];
            A226BR_PathologyID = BC000Z16_A226BR_PathologyID[0];
            n226BR_PathologyID = BC000Z16_n226BR_PathologyID[0];
            A505BR_Pathology_N_Code = BC000Z16_A505BR_Pathology_N_Code[0];
            n505BR_Pathology_N_Code = BC000Z16_n505BR_Pathology_N_Code[0];
            A506BR_Pathology_M_Code = BC000Z16_A506BR_Pathology_M_Code[0];
            n506BR_Pathology_M_Code = BC000Z16_n506BR_Pathology_M_Code[0];
            A508BR_PathologyID_PAHosp_Code = BC000Z16_A508BR_PathologyID_PAHosp_Code[0];
            n508BR_PathologyID_PAHosp_Code = BC000Z16_n508BR_PathologyID_PAHosp_Code[0];
            A36BR_Information_PatientNo = BC000Z16_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = BC000Z16_n36BR_Information_PatientNo[0];
            A237BR_PathologyID_TestID = BC000Z16_A237BR_PathologyID_TestID[0];
            n237BR_PathologyID_TestID = BC000Z16_n237BR_PathologyID_TestID[0];
            A238BR_PathologyID_PADate = BC000Z16_A238BR_PathologyID_PADate[0];
            n238BR_PathologyID_PADate = BC000Z16_n238BR_PathologyID_PADate[0];
            A239BR_PathologyID_PAHosp = BC000Z16_A239BR_PathologyID_PAHosp[0];
            n239BR_PathologyID_PAHosp = BC000Z16_n239BR_PathologyID_PAHosp[0];
            A240BR_PathologyID_PAAge = BC000Z16_A240BR_PathologyID_PAAge[0];
            n240BR_PathologyID_PAAge = BC000Z16_n240BR_PathologyID_PAAge[0];
            A241BR_PathologyID_PrePaDia = BC000Z16_A241BR_PathologyID_PrePaDia[0];
            n241BR_PathologyID_PrePaDia = BC000Z16_n241BR_PathologyID_PrePaDia[0];
            A242BR_PathologyID_PAResult = BC000Z16_A242BR_PathologyID_PAResult[0];
            n242BR_PathologyID_PAResult = BC000Z16_n242BR_PathologyID_PAResult[0];
            A326BR_Pathology_Dia_Name = BC000Z16_A326BR_Pathology_Dia_Name[0];
            n326BR_Pathology_Dia_Name = BC000Z16_n326BR_Pathology_Dia_Name[0];
            A314BR_Pathology_T = BC000Z16_A314BR_Pathology_T[0];
            n314BR_Pathology_T = BC000Z16_n314BR_Pathology_T[0];
            A315BR_Pathology_N = BC000Z16_A315BR_Pathology_N[0];
            n315BR_Pathology_N = BC000Z16_n315BR_Pathology_N[0];
            A316BR_Pathology_LymphNum = BC000Z16_A316BR_Pathology_LymphNum[0];
            n316BR_Pathology_LymphNum = BC000Z16_n316BR_Pathology_LymphNum[0];
            A317BR_Pathology_LymphRate = BC000Z16_A317BR_Pathology_LymphRate[0];
            n317BR_Pathology_LymphRate = BC000Z16_n317BR_Pathology_LymphRate[0];
            A318BR_Pathology_M = BC000Z16_A318BR_Pathology_M[0];
            n318BR_Pathology_M = BC000Z16_n318BR_Pathology_M[0];
            A319BR_Pathology_MetaLoc = BC000Z16_A319BR_Pathology_MetaLoc[0];
            n319BR_Pathology_MetaLoc = BC000Z16_n319BR_Pathology_MetaLoc[0];
            A19BR_EncounterID = BC000Z16_A19BR_EncounterID[0];
            n19BR_EncounterID = BC000Z16_n19BR_EncounterID[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext0Z36( )
      {
         /* Scan next routine */
         pr_default.readNext(14);
         RcdFound36 = 0;
         ScanKeyLoad0Z36( ) ;
      }

      protected void ScanKeyLoad0Z36( )
      {
         sMode36 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(14) != 101) )
         {
            RcdFound36 = 1;
            A85BR_Information_ID = BC000Z16_A85BR_Information_ID[0];
            n85BR_Information_ID = BC000Z16_n85BR_Information_ID[0];
            A226BR_PathologyID = BC000Z16_A226BR_PathologyID[0];
            n226BR_PathologyID = BC000Z16_n226BR_PathologyID[0];
            A505BR_Pathology_N_Code = BC000Z16_A505BR_Pathology_N_Code[0];
            n505BR_Pathology_N_Code = BC000Z16_n505BR_Pathology_N_Code[0];
            A506BR_Pathology_M_Code = BC000Z16_A506BR_Pathology_M_Code[0];
            n506BR_Pathology_M_Code = BC000Z16_n506BR_Pathology_M_Code[0];
            A508BR_PathologyID_PAHosp_Code = BC000Z16_A508BR_PathologyID_PAHosp_Code[0];
            n508BR_PathologyID_PAHosp_Code = BC000Z16_n508BR_PathologyID_PAHosp_Code[0];
            A36BR_Information_PatientNo = BC000Z16_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = BC000Z16_n36BR_Information_PatientNo[0];
            A237BR_PathologyID_TestID = BC000Z16_A237BR_PathologyID_TestID[0];
            n237BR_PathologyID_TestID = BC000Z16_n237BR_PathologyID_TestID[0];
            A238BR_PathologyID_PADate = BC000Z16_A238BR_PathologyID_PADate[0];
            n238BR_PathologyID_PADate = BC000Z16_n238BR_PathologyID_PADate[0];
            A239BR_PathologyID_PAHosp = BC000Z16_A239BR_PathologyID_PAHosp[0];
            n239BR_PathologyID_PAHosp = BC000Z16_n239BR_PathologyID_PAHosp[0];
            A240BR_PathologyID_PAAge = BC000Z16_A240BR_PathologyID_PAAge[0];
            n240BR_PathologyID_PAAge = BC000Z16_n240BR_PathologyID_PAAge[0];
            A241BR_PathologyID_PrePaDia = BC000Z16_A241BR_PathologyID_PrePaDia[0];
            n241BR_PathologyID_PrePaDia = BC000Z16_n241BR_PathologyID_PrePaDia[0];
            A242BR_PathologyID_PAResult = BC000Z16_A242BR_PathologyID_PAResult[0];
            n242BR_PathologyID_PAResult = BC000Z16_n242BR_PathologyID_PAResult[0];
            A326BR_Pathology_Dia_Name = BC000Z16_A326BR_Pathology_Dia_Name[0];
            n326BR_Pathology_Dia_Name = BC000Z16_n326BR_Pathology_Dia_Name[0];
            A314BR_Pathology_T = BC000Z16_A314BR_Pathology_T[0];
            n314BR_Pathology_T = BC000Z16_n314BR_Pathology_T[0];
            A315BR_Pathology_N = BC000Z16_A315BR_Pathology_N[0];
            n315BR_Pathology_N = BC000Z16_n315BR_Pathology_N[0];
            A316BR_Pathology_LymphNum = BC000Z16_A316BR_Pathology_LymphNum[0];
            n316BR_Pathology_LymphNum = BC000Z16_n316BR_Pathology_LymphNum[0];
            A317BR_Pathology_LymphRate = BC000Z16_A317BR_Pathology_LymphRate[0];
            n317BR_Pathology_LymphRate = BC000Z16_n317BR_Pathology_LymphRate[0];
            A318BR_Pathology_M = BC000Z16_A318BR_Pathology_M[0];
            n318BR_Pathology_M = BC000Z16_n318BR_Pathology_M[0];
            A319BR_Pathology_MetaLoc = BC000Z16_A319BR_Pathology_MetaLoc[0];
            n319BR_Pathology_MetaLoc = BC000Z16_n319BR_Pathology_MetaLoc[0];
            A19BR_EncounterID = BC000Z16_A19BR_EncounterID[0];
            n19BR_EncounterID = BC000Z16_n19BR_EncounterID[0];
         }
         Gx_mode = sMode36;
      }

      protected void ScanKeyEnd0Z36( )
      {
         pr_default.close(14);
      }

      protected void AfterConfirm0Z36( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0Z36( )
      {
         /* Before Insert Rules */
         GXt_char2 = A508BR_PathologyID_PAHosp_Code;
         new zutil_findtargetcode(context ).execute(  32,  A239BR_PathologyID_PAHosp, out  GXt_char2) ;
         A508BR_PathologyID_PAHosp_Code = GXt_char2;
         n508BR_PathologyID_PAHosp_Code = false;
         GXt_char2 = A505BR_Pathology_N_Code;
         new zutil_findtargetcode(context ).execute(  37,  A315BR_Pathology_N, out  GXt_char2) ;
         A505BR_Pathology_N_Code = GXt_char2;
         n505BR_Pathology_N_Code = false;
         GXt_char2 = A506BR_Pathology_M_Code;
         new zutil_findtargetcode(context ).execute(  37,  A318BR_Pathology_M, out  GXt_char2) ;
         A506BR_Pathology_M_Code = GXt_char2;
         n506BR_Pathology_M_Code = false;
      }

      protected void BeforeUpdate0Z36( )
      {
         /* Before Update Rules */
         GXt_char2 = A508BR_PathologyID_PAHosp_Code;
         new zutil_findtargetcode(context ).execute(  32,  A239BR_PathologyID_PAHosp, out  GXt_char2) ;
         A508BR_PathologyID_PAHosp_Code = GXt_char2;
         n508BR_PathologyID_PAHosp_Code = false;
         GXt_char2 = A505BR_Pathology_N_Code;
         new zutil_findtargetcode(context ).execute(  37,  A315BR_Pathology_N, out  GXt_char2) ;
         A505BR_Pathology_N_Code = GXt_char2;
         n505BR_Pathology_N_Code = false;
         GXt_char2 = A506BR_Pathology_M_Code;
         new zutil_findtargetcode(context ).execute(  37,  A318BR_Pathology_M, out  GXt_char2) ;
         A506BR_Pathology_M_Code = GXt_char2;
         n506BR_Pathology_M_Code = false;
      }

      protected void BeforeDelete0Z36( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0Z36( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0Z36( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0Z36( )
      {
      }

      protected void send_integrity_lvl_hashes0Z36( )
      {
      }

      protected void AddRow0Z36( )
      {
         VarsToRow36( bcBR_Pathology) ;
      }

      protected void ReadRow0Z36( )
      {
         RowToVars36( bcBR_Pathology, 1) ;
      }

      protected void InitializeNonKey0Z36( )
      {
         A85BR_Information_ID = 0;
         n85BR_Information_ID = false;
         A505BR_Pathology_N_Code = "";
         n505BR_Pathology_N_Code = false;
         A506BR_Pathology_M_Code = "";
         n506BR_Pathology_M_Code = false;
         A508BR_PathologyID_PAHosp_Code = "";
         n508BR_PathologyID_PAHosp_Code = false;
         A19BR_EncounterID = 0;
         n19BR_EncounterID = false;
         A36BR_Information_PatientNo = "";
         n36BR_Information_PatientNo = false;
         A237BR_PathologyID_TestID = 0;
         n237BR_PathologyID_TestID = false;
         A238BR_PathologyID_PADate = DateTime.MinValue;
         n238BR_PathologyID_PADate = false;
         A239BR_PathologyID_PAHosp = "";
         n239BR_PathologyID_PAHosp = false;
         A240BR_PathologyID_PAAge = 0;
         n240BR_PathologyID_PAAge = false;
         A241BR_PathologyID_PrePaDia = "";
         n241BR_PathologyID_PrePaDia = false;
         A242BR_PathologyID_PAResult = "";
         n242BR_PathologyID_PAResult = false;
         A326BR_Pathology_Dia_Name = "";
         n326BR_Pathology_Dia_Name = false;
         A314BR_Pathology_T = 0;
         n314BR_Pathology_T = false;
         A315BR_Pathology_N = "";
         n315BR_Pathology_N = false;
         A316BR_Pathology_LymphNum = 0;
         n316BR_Pathology_LymphNum = false;
         A317BR_Pathology_LymphRate = "";
         n317BR_Pathology_LymphRate = false;
         A318BR_Pathology_M = "";
         n318BR_Pathology_M = false;
         A319BR_Pathology_MetaLoc = "";
         n319BR_Pathology_MetaLoc = false;
         Z505BR_Pathology_N_Code = "";
         Z506BR_Pathology_M_Code = "";
         Z508BR_PathologyID_PAHosp_Code = "";
         Z237BR_PathologyID_TestID = 0;
         Z238BR_PathologyID_PADate = DateTime.MinValue;
         Z239BR_PathologyID_PAHosp = "";
         Z240BR_PathologyID_PAAge = 0;
         Z241BR_PathologyID_PrePaDia = "";
         Z242BR_PathologyID_PAResult = "";
         Z326BR_Pathology_Dia_Name = "";
         Z314BR_Pathology_T = 0;
         Z315BR_Pathology_N = "";
         Z316BR_Pathology_LymphNum = 0;
         Z317BR_Pathology_LymphRate = "";
         Z318BR_Pathology_M = "";
         Z319BR_Pathology_MetaLoc = "";
         Z19BR_EncounterID = 0;
      }

      protected void InitAll0Z36( )
      {
         A226BR_PathologyID = 0;
         n226BR_PathologyID = false;
         InitializeNonKey0Z36( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow36( SdtBR_Pathology obj36 )
      {
         obj36.gxTpr_Mode = Gx_mode;
         obj36.gxTpr_Br_pathology_n_code = A505BR_Pathology_N_Code;
         obj36.gxTpr_Br_pathology_m_code = A506BR_Pathology_M_Code;
         obj36.gxTpr_Br_pathologyid_pahosp_code = A508BR_PathologyID_PAHosp_Code;
         obj36.gxTpr_Br_encounterid = A19BR_EncounterID;
         obj36.gxTpr_Br_information_patientno = A36BR_Information_PatientNo;
         obj36.gxTpr_Br_pathologyid_testid = A237BR_PathologyID_TestID;
         obj36.gxTpr_Br_pathologyid_padate = A238BR_PathologyID_PADate;
         obj36.gxTpr_Br_pathologyid_pahosp = A239BR_PathologyID_PAHosp;
         obj36.gxTpr_Br_pathologyid_paage = A240BR_PathologyID_PAAge;
         obj36.gxTpr_Br_pathologyid_prepadia = A241BR_PathologyID_PrePaDia;
         obj36.gxTpr_Br_pathologyid_paresult = A242BR_PathologyID_PAResult;
         obj36.gxTpr_Br_pathology_dia_name = A326BR_Pathology_Dia_Name;
         obj36.gxTpr_Br_pathology_t = A314BR_Pathology_T;
         obj36.gxTpr_Br_pathology_n = A315BR_Pathology_N;
         obj36.gxTpr_Br_pathology_lymphnum = A316BR_Pathology_LymphNum;
         obj36.gxTpr_Br_pathology_lymphrate = A317BR_Pathology_LymphRate;
         obj36.gxTpr_Br_pathology_m = A318BR_Pathology_M;
         obj36.gxTpr_Br_pathology_metaloc = A319BR_Pathology_MetaLoc;
         obj36.gxTpr_Br_pathologyid = A226BR_PathologyID;
         obj36.gxTpr_Br_pathologyid_Z = Z226BR_PathologyID;
         obj36.gxTpr_Br_encounterid_Z = Z19BR_EncounterID;
         obj36.gxTpr_Br_information_patientno_Z = Z36BR_Information_PatientNo;
         obj36.gxTpr_Br_pathologyid_testid_Z = Z237BR_PathologyID_TestID;
         obj36.gxTpr_Br_pathologyid_padate_Z = Z238BR_PathologyID_PADate;
         obj36.gxTpr_Br_pathologyid_pahosp_Z = Z239BR_PathologyID_PAHosp;
         obj36.gxTpr_Br_pathologyid_pahosp_code_Z = Z508BR_PathologyID_PAHosp_Code;
         obj36.gxTpr_Br_pathologyid_paage_Z = Z240BR_PathologyID_PAAge;
         obj36.gxTpr_Br_pathologyid_prepadia_Z = Z241BR_PathologyID_PrePaDia;
         obj36.gxTpr_Br_pathologyid_paresult_Z = Z242BR_PathologyID_PAResult;
         obj36.gxTpr_Br_pathology_dia_name_Z = Z326BR_Pathology_Dia_Name;
         obj36.gxTpr_Br_pathology_t_Z = Z314BR_Pathology_T;
         obj36.gxTpr_Br_pathology_n_Z = Z315BR_Pathology_N;
         obj36.gxTpr_Br_pathology_n_code_Z = Z505BR_Pathology_N_Code;
         obj36.gxTpr_Br_pathology_lymphnum_Z = Z316BR_Pathology_LymphNum;
         obj36.gxTpr_Br_pathology_lymphrate_Z = Z317BR_Pathology_LymphRate;
         obj36.gxTpr_Br_pathology_m_Z = Z318BR_Pathology_M;
         obj36.gxTpr_Br_pathology_m_code_Z = Z506BR_Pathology_M_Code;
         obj36.gxTpr_Br_pathology_metaloc_Z = Z319BR_Pathology_MetaLoc;
         obj36.gxTpr_Br_pathologyid_N = (short)(Convert.ToInt16(n226BR_PathologyID));
         obj36.gxTpr_Br_encounterid_N = (short)(Convert.ToInt16(n19BR_EncounterID));
         obj36.gxTpr_Br_information_patientno_N = (short)(Convert.ToInt16(n36BR_Information_PatientNo));
         obj36.gxTpr_Br_pathologyid_testid_N = (short)(Convert.ToInt16(n237BR_PathologyID_TestID));
         obj36.gxTpr_Br_pathologyid_padate_N = (short)(Convert.ToInt16(n238BR_PathologyID_PADate));
         obj36.gxTpr_Br_pathologyid_pahosp_N = (short)(Convert.ToInt16(n239BR_PathologyID_PAHosp));
         obj36.gxTpr_Br_pathologyid_pahosp_code_N = (short)(Convert.ToInt16(n508BR_PathologyID_PAHosp_Code));
         obj36.gxTpr_Br_pathologyid_paage_N = (short)(Convert.ToInt16(n240BR_PathologyID_PAAge));
         obj36.gxTpr_Br_pathologyid_prepadia_N = (short)(Convert.ToInt16(n241BR_PathologyID_PrePaDia));
         obj36.gxTpr_Br_pathologyid_paresult_N = (short)(Convert.ToInt16(n242BR_PathologyID_PAResult));
         obj36.gxTpr_Br_pathology_dia_name_N = (short)(Convert.ToInt16(n326BR_Pathology_Dia_Name));
         obj36.gxTpr_Br_pathology_t_N = (short)(Convert.ToInt16(n314BR_Pathology_T));
         obj36.gxTpr_Br_pathology_n_N = (short)(Convert.ToInt16(n315BR_Pathology_N));
         obj36.gxTpr_Br_pathology_n_code_N = (short)(Convert.ToInt16(n505BR_Pathology_N_Code));
         obj36.gxTpr_Br_pathology_lymphnum_N = (short)(Convert.ToInt16(n316BR_Pathology_LymphNum));
         obj36.gxTpr_Br_pathology_lymphrate_N = (short)(Convert.ToInt16(n317BR_Pathology_LymphRate));
         obj36.gxTpr_Br_pathology_m_N = (short)(Convert.ToInt16(n318BR_Pathology_M));
         obj36.gxTpr_Br_pathology_m_code_N = (short)(Convert.ToInt16(n506BR_Pathology_M_Code));
         obj36.gxTpr_Br_pathology_metaloc_N = (short)(Convert.ToInt16(n319BR_Pathology_MetaLoc));
         obj36.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow36( SdtBR_Pathology obj36 )
      {
         obj36.gxTpr_Br_pathologyid = A226BR_PathologyID;
         return  ;
      }

      public void RowToVars36( SdtBR_Pathology obj36 ,
                               int forceLoad )
      {
         Gx_mode = obj36.gxTpr_Mode;
         A505BR_Pathology_N_Code = obj36.gxTpr_Br_pathology_n_code;
         n505BR_Pathology_N_Code = false;
         A506BR_Pathology_M_Code = obj36.gxTpr_Br_pathology_m_code;
         n506BR_Pathology_M_Code = false;
         A508BR_PathologyID_PAHosp_Code = obj36.gxTpr_Br_pathologyid_pahosp_code;
         n508BR_PathologyID_PAHosp_Code = false;
         A19BR_EncounterID = obj36.gxTpr_Br_encounterid;
         n19BR_EncounterID = false;
         A36BR_Information_PatientNo = obj36.gxTpr_Br_information_patientno;
         n36BR_Information_PatientNo = false;
         A237BR_PathologyID_TestID = obj36.gxTpr_Br_pathologyid_testid;
         n237BR_PathologyID_TestID = false;
         A238BR_PathologyID_PADate = obj36.gxTpr_Br_pathologyid_padate;
         n238BR_PathologyID_PADate = false;
         A239BR_PathologyID_PAHosp = obj36.gxTpr_Br_pathologyid_pahosp;
         n239BR_PathologyID_PAHosp = false;
         A240BR_PathologyID_PAAge = obj36.gxTpr_Br_pathologyid_paage;
         n240BR_PathologyID_PAAge = false;
         A241BR_PathologyID_PrePaDia = obj36.gxTpr_Br_pathologyid_prepadia;
         n241BR_PathologyID_PrePaDia = false;
         A242BR_PathologyID_PAResult = obj36.gxTpr_Br_pathologyid_paresult;
         n242BR_PathologyID_PAResult = false;
         A326BR_Pathology_Dia_Name = obj36.gxTpr_Br_pathology_dia_name;
         n326BR_Pathology_Dia_Name = false;
         A314BR_Pathology_T = obj36.gxTpr_Br_pathology_t;
         n314BR_Pathology_T = false;
         A315BR_Pathology_N = obj36.gxTpr_Br_pathology_n;
         n315BR_Pathology_N = false;
         A316BR_Pathology_LymphNum = obj36.gxTpr_Br_pathology_lymphnum;
         n316BR_Pathology_LymphNum = false;
         A317BR_Pathology_LymphRate = obj36.gxTpr_Br_pathology_lymphrate;
         n317BR_Pathology_LymphRate = false;
         A318BR_Pathology_M = obj36.gxTpr_Br_pathology_m;
         n318BR_Pathology_M = false;
         A319BR_Pathology_MetaLoc = obj36.gxTpr_Br_pathology_metaloc;
         n319BR_Pathology_MetaLoc = false;
         A226BR_PathologyID = obj36.gxTpr_Br_pathologyid;
         n226BR_PathologyID = false;
         Z226BR_PathologyID = obj36.gxTpr_Br_pathologyid_Z;
         Z19BR_EncounterID = obj36.gxTpr_Br_encounterid_Z;
         Z36BR_Information_PatientNo = obj36.gxTpr_Br_information_patientno_Z;
         Z237BR_PathologyID_TestID = obj36.gxTpr_Br_pathologyid_testid_Z;
         Z238BR_PathologyID_PADate = obj36.gxTpr_Br_pathologyid_padate_Z;
         Z239BR_PathologyID_PAHosp = obj36.gxTpr_Br_pathologyid_pahosp_Z;
         Z508BR_PathologyID_PAHosp_Code = obj36.gxTpr_Br_pathologyid_pahosp_code_Z;
         Z240BR_PathologyID_PAAge = obj36.gxTpr_Br_pathologyid_paage_Z;
         Z241BR_PathologyID_PrePaDia = obj36.gxTpr_Br_pathologyid_prepadia_Z;
         Z242BR_PathologyID_PAResult = obj36.gxTpr_Br_pathologyid_paresult_Z;
         Z326BR_Pathology_Dia_Name = obj36.gxTpr_Br_pathology_dia_name_Z;
         Z314BR_Pathology_T = obj36.gxTpr_Br_pathology_t_Z;
         Z315BR_Pathology_N = obj36.gxTpr_Br_pathology_n_Z;
         Z505BR_Pathology_N_Code = obj36.gxTpr_Br_pathology_n_code_Z;
         Z316BR_Pathology_LymphNum = obj36.gxTpr_Br_pathology_lymphnum_Z;
         Z317BR_Pathology_LymphRate = obj36.gxTpr_Br_pathology_lymphrate_Z;
         Z318BR_Pathology_M = obj36.gxTpr_Br_pathology_m_Z;
         Z506BR_Pathology_M_Code = obj36.gxTpr_Br_pathology_m_code_Z;
         Z319BR_Pathology_MetaLoc = obj36.gxTpr_Br_pathology_metaloc_Z;
         n226BR_PathologyID = (bool)(Convert.ToBoolean(obj36.gxTpr_Br_pathologyid_N));
         n19BR_EncounterID = (bool)(Convert.ToBoolean(obj36.gxTpr_Br_encounterid_N));
         n36BR_Information_PatientNo = (bool)(Convert.ToBoolean(obj36.gxTpr_Br_information_patientno_N));
         n237BR_PathologyID_TestID = (bool)(Convert.ToBoolean(obj36.gxTpr_Br_pathologyid_testid_N));
         n238BR_PathologyID_PADate = (bool)(Convert.ToBoolean(obj36.gxTpr_Br_pathologyid_padate_N));
         n239BR_PathologyID_PAHosp = (bool)(Convert.ToBoolean(obj36.gxTpr_Br_pathologyid_pahosp_N));
         n508BR_PathologyID_PAHosp_Code = (bool)(Convert.ToBoolean(obj36.gxTpr_Br_pathologyid_pahosp_code_N));
         n240BR_PathologyID_PAAge = (bool)(Convert.ToBoolean(obj36.gxTpr_Br_pathologyid_paage_N));
         n241BR_PathologyID_PrePaDia = (bool)(Convert.ToBoolean(obj36.gxTpr_Br_pathologyid_prepadia_N));
         n242BR_PathologyID_PAResult = (bool)(Convert.ToBoolean(obj36.gxTpr_Br_pathologyid_paresult_N));
         n326BR_Pathology_Dia_Name = (bool)(Convert.ToBoolean(obj36.gxTpr_Br_pathology_dia_name_N));
         n314BR_Pathology_T = (bool)(Convert.ToBoolean(obj36.gxTpr_Br_pathology_t_N));
         n315BR_Pathology_N = (bool)(Convert.ToBoolean(obj36.gxTpr_Br_pathology_n_N));
         n505BR_Pathology_N_Code = (bool)(Convert.ToBoolean(obj36.gxTpr_Br_pathology_n_code_N));
         n316BR_Pathology_LymphNum = (bool)(Convert.ToBoolean(obj36.gxTpr_Br_pathology_lymphnum_N));
         n317BR_Pathology_LymphRate = (bool)(Convert.ToBoolean(obj36.gxTpr_Br_pathology_lymphrate_N));
         n318BR_Pathology_M = (bool)(Convert.ToBoolean(obj36.gxTpr_Br_pathology_m_N));
         n506BR_Pathology_M_Code = (bool)(Convert.ToBoolean(obj36.gxTpr_Br_pathology_m_code_N));
         n319BR_Pathology_MetaLoc = (bool)(Convert.ToBoolean(obj36.gxTpr_Br_pathology_metaloc_N));
         Gx_mode = obj36.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A226BR_PathologyID = (long)getParm(obj,0);
         n226BR_PathologyID = false;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey0Z36( ) ;
         ScanKeyStart0Z36( ) ;
         if ( RcdFound36 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z226BR_PathologyID = A226BR_PathologyID;
         }
         ZM0Z36( -18) ;
         OnLoadActions0Z36( ) ;
         AddRow0Z36( ) ;
         ScanKeyEnd0Z36( ) ;
         if ( RcdFound36 == 0 )
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
         RowToVars36( bcBR_Pathology, 0) ;
         ScanKeyStart0Z36( ) ;
         if ( RcdFound36 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z226BR_PathologyID = A226BR_PathologyID;
         }
         ZM0Z36( -18) ;
         OnLoadActions0Z36( ) ;
         AddRow0Z36( ) ;
         ScanKeyEnd0Z36( ) ;
         if ( RcdFound36 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey0Z36( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert0Z36( ) ;
         }
         else
         {
            if ( RcdFound36 == 1 )
            {
               if ( A226BR_PathologyID != Z226BR_PathologyID )
               {
                  A226BR_PathologyID = Z226BR_PathologyID;
                  n226BR_PathologyID = false;
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
                  Update0Z36( ) ;
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
                  if ( A226BR_PathologyID != Z226BR_PathologyID )
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
                        Insert0Z36( ) ;
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
                        Insert0Z36( ) ;
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
         RowToVars36( bcBR_Pathology, 0) ;
         SaveImpl( ) ;
         VarsToRow36( bcBR_Pathology) ;
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
         RowToVars36( bcBR_Pathology, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert0Z36( ) ;
         AfterTrn( ) ;
         VarsToRow36( bcBR_Pathology) ;
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
            SdtBR_Pathology auxBC = new SdtBR_Pathology(context) ;
            auxBC.Load(A226BR_PathologyID);
            auxBC.UpdateDirties(bcBR_Pathology);
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
         RowToVars36( bcBR_Pathology, 0) ;
         UpdateImpl( ) ;
         VarsToRow36( bcBR_Pathology) ;
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
         RowToVars36( bcBR_Pathology, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert0Z36( ) ;
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
         VarsToRow36( bcBR_Pathology) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars36( bcBR_Pathology, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey0Z36( ) ;
         if ( RcdFound36 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A226BR_PathologyID != Z226BR_PathologyID )
            {
               A226BR_PathologyID = Z226BR_PathologyID;
               n226BR_PathologyID = false;
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
            if ( A226BR_PathologyID != Z226BR_PathologyID )
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
         context.RollbackDataStores("br_pathology_bc",pr_default);
         VarsToRow36( bcBR_Pathology) ;
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
         Gx_mode = bcBR_Pathology.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcBR_Pathology.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcBR_Pathology )
         {
            bcBR_Pathology = (SdtBR_Pathology)(sdt);
            if ( StringUtil.StrCmp(bcBR_Pathology.gxTpr_Mode, "") == 0 )
            {
               bcBR_Pathology.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow36( bcBR_Pathology) ;
            }
            else
            {
               RowToVars36( bcBR_Pathology, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcBR_Pathology.gxTpr_Mode, "") == 0 )
            {
               bcBR_Pathology.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars36( bcBR_Pathology, 1) ;
         return  ;
      }

      public SdtBR_Pathology BR_Pathology_BC
      {
         get {
            return bcBR_Pathology ;
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
         AV17Pgmname = "";
         AV11TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV12WebSession = context.GetSession();
         AV14TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         Z505BR_Pathology_N_Code = "";
         A505BR_Pathology_N_Code = "";
         Z506BR_Pathology_M_Code = "";
         A506BR_Pathology_M_Code = "";
         Z508BR_PathologyID_PAHosp_Code = "";
         A508BR_PathologyID_PAHosp_Code = "";
         Z238BR_PathologyID_PADate = DateTime.MinValue;
         A238BR_PathologyID_PADate = DateTime.MinValue;
         Z239BR_PathologyID_PAHosp = "";
         A239BR_PathologyID_PAHosp = "";
         Z241BR_PathologyID_PrePaDia = "";
         A241BR_PathologyID_PrePaDia = "";
         Z242BR_PathologyID_PAResult = "";
         A242BR_PathologyID_PAResult = "";
         Z326BR_Pathology_Dia_Name = "";
         A326BR_Pathology_Dia_Name = "";
         Z315BR_Pathology_N = "";
         A315BR_Pathology_N = "";
         Z317BR_Pathology_LymphRate = "";
         A317BR_Pathology_LymphRate = "";
         Z318BR_Pathology_M = "";
         A318BR_Pathology_M = "";
         Z319BR_Pathology_MetaLoc = "";
         A319BR_Pathology_MetaLoc = "";
         Z36BR_Information_PatientNo = "";
         A36BR_Information_PatientNo = "";
         BC000Z6_A85BR_Information_ID = new long[1] ;
         BC000Z6_n85BR_Information_ID = new bool[] {false} ;
         BC000Z6_A226BR_PathologyID = new long[1] ;
         BC000Z6_n226BR_PathologyID = new bool[] {false} ;
         BC000Z6_A505BR_Pathology_N_Code = new String[] {""} ;
         BC000Z6_n505BR_Pathology_N_Code = new bool[] {false} ;
         BC000Z6_A506BR_Pathology_M_Code = new String[] {""} ;
         BC000Z6_n506BR_Pathology_M_Code = new bool[] {false} ;
         BC000Z6_A508BR_PathologyID_PAHosp_Code = new String[] {""} ;
         BC000Z6_n508BR_PathologyID_PAHosp_Code = new bool[] {false} ;
         BC000Z6_A36BR_Information_PatientNo = new String[] {""} ;
         BC000Z6_n36BR_Information_PatientNo = new bool[] {false} ;
         BC000Z6_A237BR_PathologyID_TestID = new long[1] ;
         BC000Z6_n237BR_PathologyID_TestID = new bool[] {false} ;
         BC000Z6_A238BR_PathologyID_PADate = new DateTime[] {DateTime.MinValue} ;
         BC000Z6_n238BR_PathologyID_PADate = new bool[] {false} ;
         BC000Z6_A239BR_PathologyID_PAHosp = new String[] {""} ;
         BC000Z6_n239BR_PathologyID_PAHosp = new bool[] {false} ;
         BC000Z6_A240BR_PathologyID_PAAge = new short[1] ;
         BC000Z6_n240BR_PathologyID_PAAge = new bool[] {false} ;
         BC000Z6_A241BR_PathologyID_PrePaDia = new String[] {""} ;
         BC000Z6_n241BR_PathologyID_PrePaDia = new bool[] {false} ;
         BC000Z6_A242BR_PathologyID_PAResult = new String[] {""} ;
         BC000Z6_n242BR_PathologyID_PAResult = new bool[] {false} ;
         BC000Z6_A326BR_Pathology_Dia_Name = new String[] {""} ;
         BC000Z6_n326BR_Pathology_Dia_Name = new bool[] {false} ;
         BC000Z6_A314BR_Pathology_T = new decimal[1] ;
         BC000Z6_n314BR_Pathology_T = new bool[] {false} ;
         BC000Z6_A315BR_Pathology_N = new String[] {""} ;
         BC000Z6_n315BR_Pathology_N = new bool[] {false} ;
         BC000Z6_A316BR_Pathology_LymphNum = new decimal[1] ;
         BC000Z6_n316BR_Pathology_LymphNum = new bool[] {false} ;
         BC000Z6_A317BR_Pathology_LymphRate = new String[] {""} ;
         BC000Z6_n317BR_Pathology_LymphRate = new bool[] {false} ;
         BC000Z6_A318BR_Pathology_M = new String[] {""} ;
         BC000Z6_n318BR_Pathology_M = new bool[] {false} ;
         BC000Z6_A319BR_Pathology_MetaLoc = new String[] {""} ;
         BC000Z6_n319BR_Pathology_MetaLoc = new bool[] {false} ;
         BC000Z6_A19BR_EncounterID = new long[1] ;
         BC000Z6_n19BR_EncounterID = new bool[] {false} ;
         BC000Z4_A85BR_Information_ID = new long[1] ;
         BC000Z4_n85BR_Information_ID = new bool[] {false} ;
         BC000Z5_A36BR_Information_PatientNo = new String[] {""} ;
         BC000Z5_n36BR_Information_PatientNo = new bool[] {false} ;
         BC000Z7_A226BR_PathologyID = new long[1] ;
         BC000Z7_n226BR_PathologyID = new bool[] {false} ;
         BC000Z3_A226BR_PathologyID = new long[1] ;
         BC000Z3_n226BR_PathologyID = new bool[] {false} ;
         BC000Z3_A505BR_Pathology_N_Code = new String[] {""} ;
         BC000Z3_n505BR_Pathology_N_Code = new bool[] {false} ;
         BC000Z3_A506BR_Pathology_M_Code = new String[] {""} ;
         BC000Z3_n506BR_Pathology_M_Code = new bool[] {false} ;
         BC000Z3_A508BR_PathologyID_PAHosp_Code = new String[] {""} ;
         BC000Z3_n508BR_PathologyID_PAHosp_Code = new bool[] {false} ;
         BC000Z3_A237BR_PathologyID_TestID = new long[1] ;
         BC000Z3_n237BR_PathologyID_TestID = new bool[] {false} ;
         BC000Z3_A238BR_PathologyID_PADate = new DateTime[] {DateTime.MinValue} ;
         BC000Z3_n238BR_PathologyID_PADate = new bool[] {false} ;
         BC000Z3_A239BR_PathologyID_PAHosp = new String[] {""} ;
         BC000Z3_n239BR_PathologyID_PAHosp = new bool[] {false} ;
         BC000Z3_A240BR_PathologyID_PAAge = new short[1] ;
         BC000Z3_n240BR_PathologyID_PAAge = new bool[] {false} ;
         BC000Z3_A241BR_PathologyID_PrePaDia = new String[] {""} ;
         BC000Z3_n241BR_PathologyID_PrePaDia = new bool[] {false} ;
         BC000Z3_A242BR_PathologyID_PAResult = new String[] {""} ;
         BC000Z3_n242BR_PathologyID_PAResult = new bool[] {false} ;
         BC000Z3_A326BR_Pathology_Dia_Name = new String[] {""} ;
         BC000Z3_n326BR_Pathology_Dia_Name = new bool[] {false} ;
         BC000Z3_A314BR_Pathology_T = new decimal[1] ;
         BC000Z3_n314BR_Pathology_T = new bool[] {false} ;
         BC000Z3_A315BR_Pathology_N = new String[] {""} ;
         BC000Z3_n315BR_Pathology_N = new bool[] {false} ;
         BC000Z3_A316BR_Pathology_LymphNum = new decimal[1] ;
         BC000Z3_n316BR_Pathology_LymphNum = new bool[] {false} ;
         BC000Z3_A317BR_Pathology_LymphRate = new String[] {""} ;
         BC000Z3_n317BR_Pathology_LymphRate = new bool[] {false} ;
         BC000Z3_A318BR_Pathology_M = new String[] {""} ;
         BC000Z3_n318BR_Pathology_M = new bool[] {false} ;
         BC000Z3_A319BR_Pathology_MetaLoc = new String[] {""} ;
         BC000Z3_n319BR_Pathology_MetaLoc = new bool[] {false} ;
         BC000Z3_A19BR_EncounterID = new long[1] ;
         BC000Z3_n19BR_EncounterID = new bool[] {false} ;
         sMode36 = "";
         BC000Z2_A226BR_PathologyID = new long[1] ;
         BC000Z2_n226BR_PathologyID = new bool[] {false} ;
         BC000Z2_A505BR_Pathology_N_Code = new String[] {""} ;
         BC000Z2_n505BR_Pathology_N_Code = new bool[] {false} ;
         BC000Z2_A506BR_Pathology_M_Code = new String[] {""} ;
         BC000Z2_n506BR_Pathology_M_Code = new bool[] {false} ;
         BC000Z2_A508BR_PathologyID_PAHosp_Code = new String[] {""} ;
         BC000Z2_n508BR_PathologyID_PAHosp_Code = new bool[] {false} ;
         BC000Z2_A237BR_PathologyID_TestID = new long[1] ;
         BC000Z2_n237BR_PathologyID_TestID = new bool[] {false} ;
         BC000Z2_A238BR_PathologyID_PADate = new DateTime[] {DateTime.MinValue} ;
         BC000Z2_n238BR_PathologyID_PADate = new bool[] {false} ;
         BC000Z2_A239BR_PathologyID_PAHosp = new String[] {""} ;
         BC000Z2_n239BR_PathologyID_PAHosp = new bool[] {false} ;
         BC000Z2_A240BR_PathologyID_PAAge = new short[1] ;
         BC000Z2_n240BR_PathologyID_PAAge = new bool[] {false} ;
         BC000Z2_A241BR_PathologyID_PrePaDia = new String[] {""} ;
         BC000Z2_n241BR_PathologyID_PrePaDia = new bool[] {false} ;
         BC000Z2_A242BR_PathologyID_PAResult = new String[] {""} ;
         BC000Z2_n242BR_PathologyID_PAResult = new bool[] {false} ;
         BC000Z2_A326BR_Pathology_Dia_Name = new String[] {""} ;
         BC000Z2_n326BR_Pathology_Dia_Name = new bool[] {false} ;
         BC000Z2_A314BR_Pathology_T = new decimal[1] ;
         BC000Z2_n314BR_Pathology_T = new bool[] {false} ;
         BC000Z2_A315BR_Pathology_N = new String[] {""} ;
         BC000Z2_n315BR_Pathology_N = new bool[] {false} ;
         BC000Z2_A316BR_Pathology_LymphNum = new decimal[1] ;
         BC000Z2_n316BR_Pathology_LymphNum = new bool[] {false} ;
         BC000Z2_A317BR_Pathology_LymphRate = new String[] {""} ;
         BC000Z2_n317BR_Pathology_LymphRate = new bool[] {false} ;
         BC000Z2_A318BR_Pathology_M = new String[] {""} ;
         BC000Z2_n318BR_Pathology_M = new bool[] {false} ;
         BC000Z2_A319BR_Pathology_MetaLoc = new String[] {""} ;
         BC000Z2_n319BR_Pathology_MetaLoc = new bool[] {false} ;
         BC000Z2_A19BR_EncounterID = new long[1] ;
         BC000Z2_n19BR_EncounterID = new bool[] {false} ;
         BC000Z8_A226BR_PathologyID = new long[1] ;
         BC000Z8_n226BR_PathologyID = new bool[] {false} ;
         BC000Z11_A85BR_Information_ID = new long[1] ;
         BC000Z11_n85BR_Information_ID = new bool[] {false} ;
         BC000Z12_A36BR_Information_PatientNo = new String[] {""} ;
         BC000Z12_n36BR_Information_PatientNo = new bool[] {false} ;
         BC000Z13_A288BR_Pathology_OtherID = new long[1] ;
         BC000Z14_A276BR_Pathology_DiagID = new long[1] ;
         BC000Z15_A274BR_Pathology_SpecimenID = new long[1] ;
         BC000Z16_A85BR_Information_ID = new long[1] ;
         BC000Z16_n85BR_Information_ID = new bool[] {false} ;
         BC000Z16_A226BR_PathologyID = new long[1] ;
         BC000Z16_n226BR_PathologyID = new bool[] {false} ;
         BC000Z16_A505BR_Pathology_N_Code = new String[] {""} ;
         BC000Z16_n505BR_Pathology_N_Code = new bool[] {false} ;
         BC000Z16_A506BR_Pathology_M_Code = new String[] {""} ;
         BC000Z16_n506BR_Pathology_M_Code = new bool[] {false} ;
         BC000Z16_A508BR_PathologyID_PAHosp_Code = new String[] {""} ;
         BC000Z16_n508BR_PathologyID_PAHosp_Code = new bool[] {false} ;
         BC000Z16_A36BR_Information_PatientNo = new String[] {""} ;
         BC000Z16_n36BR_Information_PatientNo = new bool[] {false} ;
         BC000Z16_A237BR_PathologyID_TestID = new long[1] ;
         BC000Z16_n237BR_PathologyID_TestID = new bool[] {false} ;
         BC000Z16_A238BR_PathologyID_PADate = new DateTime[] {DateTime.MinValue} ;
         BC000Z16_n238BR_PathologyID_PADate = new bool[] {false} ;
         BC000Z16_A239BR_PathologyID_PAHosp = new String[] {""} ;
         BC000Z16_n239BR_PathologyID_PAHosp = new bool[] {false} ;
         BC000Z16_A240BR_PathologyID_PAAge = new short[1] ;
         BC000Z16_n240BR_PathologyID_PAAge = new bool[] {false} ;
         BC000Z16_A241BR_PathologyID_PrePaDia = new String[] {""} ;
         BC000Z16_n241BR_PathologyID_PrePaDia = new bool[] {false} ;
         BC000Z16_A242BR_PathologyID_PAResult = new String[] {""} ;
         BC000Z16_n242BR_PathologyID_PAResult = new bool[] {false} ;
         BC000Z16_A326BR_Pathology_Dia_Name = new String[] {""} ;
         BC000Z16_n326BR_Pathology_Dia_Name = new bool[] {false} ;
         BC000Z16_A314BR_Pathology_T = new decimal[1] ;
         BC000Z16_n314BR_Pathology_T = new bool[] {false} ;
         BC000Z16_A315BR_Pathology_N = new String[] {""} ;
         BC000Z16_n315BR_Pathology_N = new bool[] {false} ;
         BC000Z16_A316BR_Pathology_LymphNum = new decimal[1] ;
         BC000Z16_n316BR_Pathology_LymphNum = new bool[] {false} ;
         BC000Z16_A317BR_Pathology_LymphRate = new String[] {""} ;
         BC000Z16_n317BR_Pathology_LymphRate = new bool[] {false} ;
         BC000Z16_A318BR_Pathology_M = new String[] {""} ;
         BC000Z16_n318BR_Pathology_M = new bool[] {false} ;
         BC000Z16_A319BR_Pathology_MetaLoc = new String[] {""} ;
         BC000Z16_n319BR_Pathology_MetaLoc = new bool[] {false} ;
         BC000Z16_A19BR_EncounterID = new long[1] ;
         BC000Z16_n19BR_EncounterID = new bool[] {false} ;
         GXt_char2 = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_pathology_bc__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_pathology_bc__default(),
            new Object[][] {
                new Object[] {
               BC000Z2_A226BR_PathologyID, BC000Z2_A505BR_Pathology_N_Code, BC000Z2_n505BR_Pathology_N_Code, BC000Z2_A506BR_Pathology_M_Code, BC000Z2_n506BR_Pathology_M_Code, BC000Z2_A508BR_PathologyID_PAHosp_Code, BC000Z2_n508BR_PathologyID_PAHosp_Code, BC000Z2_A237BR_PathologyID_TestID, BC000Z2_n237BR_PathologyID_TestID, BC000Z2_A238BR_PathologyID_PADate,
               BC000Z2_n238BR_PathologyID_PADate, BC000Z2_A239BR_PathologyID_PAHosp, BC000Z2_n239BR_PathologyID_PAHosp, BC000Z2_A240BR_PathologyID_PAAge, BC000Z2_n240BR_PathologyID_PAAge, BC000Z2_A241BR_PathologyID_PrePaDia, BC000Z2_n241BR_PathologyID_PrePaDia, BC000Z2_A242BR_PathologyID_PAResult, BC000Z2_n242BR_PathologyID_PAResult, BC000Z2_A326BR_Pathology_Dia_Name,
               BC000Z2_n326BR_Pathology_Dia_Name, BC000Z2_A314BR_Pathology_T, BC000Z2_n314BR_Pathology_T, BC000Z2_A315BR_Pathology_N, BC000Z2_n315BR_Pathology_N, BC000Z2_A316BR_Pathology_LymphNum, BC000Z2_n316BR_Pathology_LymphNum, BC000Z2_A317BR_Pathology_LymphRate, BC000Z2_n317BR_Pathology_LymphRate, BC000Z2_A318BR_Pathology_M,
               BC000Z2_n318BR_Pathology_M, BC000Z2_A319BR_Pathology_MetaLoc, BC000Z2_n319BR_Pathology_MetaLoc, BC000Z2_A19BR_EncounterID, BC000Z2_n19BR_EncounterID
               }
               , new Object[] {
               BC000Z3_A226BR_PathologyID, BC000Z3_A505BR_Pathology_N_Code, BC000Z3_n505BR_Pathology_N_Code, BC000Z3_A506BR_Pathology_M_Code, BC000Z3_n506BR_Pathology_M_Code, BC000Z3_A508BR_PathologyID_PAHosp_Code, BC000Z3_n508BR_PathologyID_PAHosp_Code, BC000Z3_A237BR_PathologyID_TestID, BC000Z3_n237BR_PathologyID_TestID, BC000Z3_A238BR_PathologyID_PADate,
               BC000Z3_n238BR_PathologyID_PADate, BC000Z3_A239BR_PathologyID_PAHosp, BC000Z3_n239BR_PathologyID_PAHosp, BC000Z3_A240BR_PathologyID_PAAge, BC000Z3_n240BR_PathologyID_PAAge, BC000Z3_A241BR_PathologyID_PrePaDia, BC000Z3_n241BR_PathologyID_PrePaDia, BC000Z3_A242BR_PathologyID_PAResult, BC000Z3_n242BR_PathologyID_PAResult, BC000Z3_A326BR_Pathology_Dia_Name,
               BC000Z3_n326BR_Pathology_Dia_Name, BC000Z3_A314BR_Pathology_T, BC000Z3_n314BR_Pathology_T, BC000Z3_A315BR_Pathology_N, BC000Z3_n315BR_Pathology_N, BC000Z3_A316BR_Pathology_LymphNum, BC000Z3_n316BR_Pathology_LymphNum, BC000Z3_A317BR_Pathology_LymphRate, BC000Z3_n317BR_Pathology_LymphRate, BC000Z3_A318BR_Pathology_M,
               BC000Z3_n318BR_Pathology_M, BC000Z3_A319BR_Pathology_MetaLoc, BC000Z3_n319BR_Pathology_MetaLoc, BC000Z3_A19BR_EncounterID, BC000Z3_n19BR_EncounterID
               }
               , new Object[] {
               BC000Z4_A85BR_Information_ID, BC000Z4_n85BR_Information_ID
               }
               , new Object[] {
               BC000Z5_A36BR_Information_PatientNo, BC000Z5_n36BR_Information_PatientNo
               }
               , new Object[] {
               BC000Z6_A85BR_Information_ID, BC000Z6_n85BR_Information_ID, BC000Z6_A226BR_PathologyID, BC000Z6_A505BR_Pathology_N_Code, BC000Z6_n505BR_Pathology_N_Code, BC000Z6_A506BR_Pathology_M_Code, BC000Z6_n506BR_Pathology_M_Code, BC000Z6_A508BR_PathologyID_PAHosp_Code, BC000Z6_n508BR_PathologyID_PAHosp_Code, BC000Z6_A36BR_Information_PatientNo,
               BC000Z6_n36BR_Information_PatientNo, BC000Z6_A237BR_PathologyID_TestID, BC000Z6_n237BR_PathologyID_TestID, BC000Z6_A238BR_PathologyID_PADate, BC000Z6_n238BR_PathologyID_PADate, BC000Z6_A239BR_PathologyID_PAHosp, BC000Z6_n239BR_PathologyID_PAHosp, BC000Z6_A240BR_PathologyID_PAAge, BC000Z6_n240BR_PathologyID_PAAge, BC000Z6_A241BR_PathologyID_PrePaDia,
               BC000Z6_n241BR_PathologyID_PrePaDia, BC000Z6_A242BR_PathologyID_PAResult, BC000Z6_n242BR_PathologyID_PAResult, BC000Z6_A326BR_Pathology_Dia_Name, BC000Z6_n326BR_Pathology_Dia_Name, BC000Z6_A314BR_Pathology_T, BC000Z6_n314BR_Pathology_T, BC000Z6_A315BR_Pathology_N, BC000Z6_n315BR_Pathology_N, BC000Z6_A316BR_Pathology_LymphNum,
               BC000Z6_n316BR_Pathology_LymphNum, BC000Z6_A317BR_Pathology_LymphRate, BC000Z6_n317BR_Pathology_LymphRate, BC000Z6_A318BR_Pathology_M, BC000Z6_n318BR_Pathology_M, BC000Z6_A319BR_Pathology_MetaLoc, BC000Z6_n319BR_Pathology_MetaLoc, BC000Z6_A19BR_EncounterID, BC000Z6_n19BR_EncounterID
               }
               , new Object[] {
               BC000Z7_A226BR_PathologyID
               }
               , new Object[] {
               BC000Z8_A226BR_PathologyID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000Z11_A85BR_Information_ID, BC000Z11_n85BR_Information_ID
               }
               , new Object[] {
               BC000Z12_A36BR_Information_PatientNo, BC000Z12_n36BR_Information_PatientNo
               }
               , new Object[] {
               BC000Z13_A288BR_Pathology_OtherID
               }
               , new Object[] {
               BC000Z14_A276BR_Pathology_DiagID
               }
               , new Object[] {
               BC000Z15_A274BR_Pathology_SpecimenID
               }
               , new Object[] {
               BC000Z16_A85BR_Information_ID, BC000Z16_n85BR_Information_ID, BC000Z16_A226BR_PathologyID, BC000Z16_A505BR_Pathology_N_Code, BC000Z16_n505BR_Pathology_N_Code, BC000Z16_A506BR_Pathology_M_Code, BC000Z16_n506BR_Pathology_M_Code, BC000Z16_A508BR_PathologyID_PAHosp_Code, BC000Z16_n508BR_PathologyID_PAHosp_Code, BC000Z16_A36BR_Information_PatientNo,
               BC000Z16_n36BR_Information_PatientNo, BC000Z16_A237BR_PathologyID_TestID, BC000Z16_n237BR_PathologyID_TestID, BC000Z16_A238BR_PathologyID_PADate, BC000Z16_n238BR_PathologyID_PADate, BC000Z16_A239BR_PathologyID_PAHosp, BC000Z16_n239BR_PathologyID_PAHosp, BC000Z16_A240BR_PathologyID_PAAge, BC000Z16_n240BR_PathologyID_PAAge, BC000Z16_A241BR_PathologyID_PrePaDia,
               BC000Z16_n241BR_PathologyID_PrePaDia, BC000Z16_A242BR_PathologyID_PAResult, BC000Z16_n242BR_PathologyID_PAResult, BC000Z16_A326BR_Pathology_Dia_Name, BC000Z16_n326BR_Pathology_Dia_Name, BC000Z16_A314BR_Pathology_T, BC000Z16_n314BR_Pathology_T, BC000Z16_A315BR_Pathology_N, BC000Z16_n315BR_Pathology_N, BC000Z16_A316BR_Pathology_LymphNum,
               BC000Z16_n316BR_Pathology_LymphNum, BC000Z16_A317BR_Pathology_LymphRate, BC000Z16_n317BR_Pathology_LymphRate, BC000Z16_A318BR_Pathology_M, BC000Z16_n318BR_Pathology_M, BC000Z16_A319BR_Pathology_MetaLoc, BC000Z16_n319BR_Pathology_MetaLoc, BC000Z16_A19BR_EncounterID, BC000Z16_n19BR_EncounterID
               }
            }
         );
         AV17Pgmname = "BR_Pathology_BC";
         INITTRN();
         /* Execute Start event if defined. */
         /* Execute user event: Start */
         E120Z2 ();
         standaloneNotModal( ) ;
      }

      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short GX_JID ;
      private short Z240BR_PathologyID_PAAge ;
      private short A240BR_PathologyID_PAAge ;
      private short RcdFound36 ;
      private int trnEnded ;
      private int AV18GXV1 ;
      private long Z226BR_PathologyID ;
      private long A226BR_PathologyID ;
      private long AV13Insert_BR_EncounterID ;
      private long Z237BR_PathologyID_TestID ;
      private long A237BR_PathologyID_TestID ;
      private long Z19BR_EncounterID ;
      private long A19BR_EncounterID ;
      private long Z85BR_Information_ID ;
      private long A85BR_Information_ID ;
      private decimal Z314BR_Pathology_T ;
      private decimal A314BR_Pathology_T ;
      private decimal Z316BR_Pathology_LymphNum ;
      private decimal A316BR_Pathology_LymphNum ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String AV17Pgmname ;
      private String sMode36 ;
      private String GXt_char2 ;
      private DateTime Z238BR_PathologyID_PADate ;
      private DateTime A238BR_PathologyID_PADate ;
      private bool AV9IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool returnInSub ;
      private bool n226BR_PathologyID ;
      private bool n85BR_Information_ID ;
      private bool n505BR_Pathology_N_Code ;
      private bool n506BR_Pathology_M_Code ;
      private bool n508BR_PathologyID_PAHosp_Code ;
      private bool n36BR_Information_PatientNo ;
      private bool n237BR_PathologyID_TestID ;
      private bool n238BR_PathologyID_PADate ;
      private bool n239BR_PathologyID_PAHosp ;
      private bool n240BR_PathologyID_PAAge ;
      private bool n241BR_PathologyID_PrePaDia ;
      private bool n242BR_PathologyID_PAResult ;
      private bool n326BR_Pathology_Dia_Name ;
      private bool n314BR_Pathology_T ;
      private bool n315BR_Pathology_N ;
      private bool n316BR_Pathology_LymphNum ;
      private bool n317BR_Pathology_LymphRate ;
      private bool n318BR_Pathology_M ;
      private bool n319BR_Pathology_MetaLoc ;
      private bool n19BR_EncounterID ;
      private bool Gx_longc ;
      private String Z505BR_Pathology_N_Code ;
      private String A505BR_Pathology_N_Code ;
      private String Z506BR_Pathology_M_Code ;
      private String A506BR_Pathology_M_Code ;
      private String Z508BR_PathologyID_PAHosp_Code ;
      private String A508BR_PathologyID_PAHosp_Code ;
      private String Z239BR_PathologyID_PAHosp ;
      private String A239BR_PathologyID_PAHosp ;
      private String Z241BR_PathologyID_PrePaDia ;
      private String A241BR_PathologyID_PrePaDia ;
      private String Z242BR_PathologyID_PAResult ;
      private String A242BR_PathologyID_PAResult ;
      private String Z326BR_Pathology_Dia_Name ;
      private String A326BR_Pathology_Dia_Name ;
      private String Z315BR_Pathology_N ;
      private String A315BR_Pathology_N ;
      private String Z317BR_Pathology_LymphRate ;
      private String A317BR_Pathology_LymphRate ;
      private String Z318BR_Pathology_M ;
      private String A318BR_Pathology_M ;
      private String Z319BR_Pathology_MetaLoc ;
      private String A319BR_Pathology_MetaLoc ;
      private String Z36BR_Information_PatientNo ;
      private String A36BR_Information_PatientNo ;
      private IGxSession AV12WebSession ;
      private SdtBR_Pathology bcBR_Pathology ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] BC000Z6_A85BR_Information_ID ;
      private bool[] BC000Z6_n85BR_Information_ID ;
      private long[] BC000Z6_A226BR_PathologyID ;
      private bool[] BC000Z6_n226BR_PathologyID ;
      private String[] BC000Z6_A505BR_Pathology_N_Code ;
      private bool[] BC000Z6_n505BR_Pathology_N_Code ;
      private String[] BC000Z6_A506BR_Pathology_M_Code ;
      private bool[] BC000Z6_n506BR_Pathology_M_Code ;
      private String[] BC000Z6_A508BR_PathologyID_PAHosp_Code ;
      private bool[] BC000Z6_n508BR_PathologyID_PAHosp_Code ;
      private String[] BC000Z6_A36BR_Information_PatientNo ;
      private bool[] BC000Z6_n36BR_Information_PatientNo ;
      private long[] BC000Z6_A237BR_PathologyID_TestID ;
      private bool[] BC000Z6_n237BR_PathologyID_TestID ;
      private DateTime[] BC000Z6_A238BR_PathologyID_PADate ;
      private bool[] BC000Z6_n238BR_PathologyID_PADate ;
      private String[] BC000Z6_A239BR_PathologyID_PAHosp ;
      private bool[] BC000Z6_n239BR_PathologyID_PAHosp ;
      private short[] BC000Z6_A240BR_PathologyID_PAAge ;
      private bool[] BC000Z6_n240BR_PathologyID_PAAge ;
      private String[] BC000Z6_A241BR_PathologyID_PrePaDia ;
      private bool[] BC000Z6_n241BR_PathologyID_PrePaDia ;
      private String[] BC000Z6_A242BR_PathologyID_PAResult ;
      private bool[] BC000Z6_n242BR_PathologyID_PAResult ;
      private String[] BC000Z6_A326BR_Pathology_Dia_Name ;
      private bool[] BC000Z6_n326BR_Pathology_Dia_Name ;
      private decimal[] BC000Z6_A314BR_Pathology_T ;
      private bool[] BC000Z6_n314BR_Pathology_T ;
      private String[] BC000Z6_A315BR_Pathology_N ;
      private bool[] BC000Z6_n315BR_Pathology_N ;
      private decimal[] BC000Z6_A316BR_Pathology_LymphNum ;
      private bool[] BC000Z6_n316BR_Pathology_LymphNum ;
      private String[] BC000Z6_A317BR_Pathology_LymphRate ;
      private bool[] BC000Z6_n317BR_Pathology_LymphRate ;
      private String[] BC000Z6_A318BR_Pathology_M ;
      private bool[] BC000Z6_n318BR_Pathology_M ;
      private String[] BC000Z6_A319BR_Pathology_MetaLoc ;
      private bool[] BC000Z6_n319BR_Pathology_MetaLoc ;
      private long[] BC000Z6_A19BR_EncounterID ;
      private bool[] BC000Z6_n19BR_EncounterID ;
      private long[] BC000Z4_A85BR_Information_ID ;
      private bool[] BC000Z4_n85BR_Information_ID ;
      private String[] BC000Z5_A36BR_Information_PatientNo ;
      private bool[] BC000Z5_n36BR_Information_PatientNo ;
      private long[] BC000Z7_A226BR_PathologyID ;
      private bool[] BC000Z7_n226BR_PathologyID ;
      private long[] BC000Z3_A226BR_PathologyID ;
      private bool[] BC000Z3_n226BR_PathologyID ;
      private String[] BC000Z3_A505BR_Pathology_N_Code ;
      private bool[] BC000Z3_n505BR_Pathology_N_Code ;
      private String[] BC000Z3_A506BR_Pathology_M_Code ;
      private bool[] BC000Z3_n506BR_Pathology_M_Code ;
      private String[] BC000Z3_A508BR_PathologyID_PAHosp_Code ;
      private bool[] BC000Z3_n508BR_PathologyID_PAHosp_Code ;
      private long[] BC000Z3_A237BR_PathologyID_TestID ;
      private bool[] BC000Z3_n237BR_PathologyID_TestID ;
      private DateTime[] BC000Z3_A238BR_PathologyID_PADate ;
      private bool[] BC000Z3_n238BR_PathologyID_PADate ;
      private String[] BC000Z3_A239BR_PathologyID_PAHosp ;
      private bool[] BC000Z3_n239BR_PathologyID_PAHosp ;
      private short[] BC000Z3_A240BR_PathologyID_PAAge ;
      private bool[] BC000Z3_n240BR_PathologyID_PAAge ;
      private String[] BC000Z3_A241BR_PathologyID_PrePaDia ;
      private bool[] BC000Z3_n241BR_PathologyID_PrePaDia ;
      private String[] BC000Z3_A242BR_PathologyID_PAResult ;
      private bool[] BC000Z3_n242BR_PathologyID_PAResult ;
      private String[] BC000Z3_A326BR_Pathology_Dia_Name ;
      private bool[] BC000Z3_n326BR_Pathology_Dia_Name ;
      private decimal[] BC000Z3_A314BR_Pathology_T ;
      private bool[] BC000Z3_n314BR_Pathology_T ;
      private String[] BC000Z3_A315BR_Pathology_N ;
      private bool[] BC000Z3_n315BR_Pathology_N ;
      private decimal[] BC000Z3_A316BR_Pathology_LymphNum ;
      private bool[] BC000Z3_n316BR_Pathology_LymphNum ;
      private String[] BC000Z3_A317BR_Pathology_LymphRate ;
      private bool[] BC000Z3_n317BR_Pathology_LymphRate ;
      private String[] BC000Z3_A318BR_Pathology_M ;
      private bool[] BC000Z3_n318BR_Pathology_M ;
      private String[] BC000Z3_A319BR_Pathology_MetaLoc ;
      private bool[] BC000Z3_n319BR_Pathology_MetaLoc ;
      private long[] BC000Z3_A19BR_EncounterID ;
      private bool[] BC000Z3_n19BR_EncounterID ;
      private long[] BC000Z2_A226BR_PathologyID ;
      private bool[] BC000Z2_n226BR_PathologyID ;
      private String[] BC000Z2_A505BR_Pathology_N_Code ;
      private bool[] BC000Z2_n505BR_Pathology_N_Code ;
      private String[] BC000Z2_A506BR_Pathology_M_Code ;
      private bool[] BC000Z2_n506BR_Pathology_M_Code ;
      private String[] BC000Z2_A508BR_PathologyID_PAHosp_Code ;
      private bool[] BC000Z2_n508BR_PathologyID_PAHosp_Code ;
      private long[] BC000Z2_A237BR_PathologyID_TestID ;
      private bool[] BC000Z2_n237BR_PathologyID_TestID ;
      private DateTime[] BC000Z2_A238BR_PathologyID_PADate ;
      private bool[] BC000Z2_n238BR_PathologyID_PADate ;
      private String[] BC000Z2_A239BR_PathologyID_PAHosp ;
      private bool[] BC000Z2_n239BR_PathologyID_PAHosp ;
      private short[] BC000Z2_A240BR_PathologyID_PAAge ;
      private bool[] BC000Z2_n240BR_PathologyID_PAAge ;
      private String[] BC000Z2_A241BR_PathologyID_PrePaDia ;
      private bool[] BC000Z2_n241BR_PathologyID_PrePaDia ;
      private String[] BC000Z2_A242BR_PathologyID_PAResult ;
      private bool[] BC000Z2_n242BR_PathologyID_PAResult ;
      private String[] BC000Z2_A326BR_Pathology_Dia_Name ;
      private bool[] BC000Z2_n326BR_Pathology_Dia_Name ;
      private decimal[] BC000Z2_A314BR_Pathology_T ;
      private bool[] BC000Z2_n314BR_Pathology_T ;
      private String[] BC000Z2_A315BR_Pathology_N ;
      private bool[] BC000Z2_n315BR_Pathology_N ;
      private decimal[] BC000Z2_A316BR_Pathology_LymphNum ;
      private bool[] BC000Z2_n316BR_Pathology_LymphNum ;
      private String[] BC000Z2_A317BR_Pathology_LymphRate ;
      private bool[] BC000Z2_n317BR_Pathology_LymphRate ;
      private String[] BC000Z2_A318BR_Pathology_M ;
      private bool[] BC000Z2_n318BR_Pathology_M ;
      private String[] BC000Z2_A319BR_Pathology_MetaLoc ;
      private bool[] BC000Z2_n319BR_Pathology_MetaLoc ;
      private long[] BC000Z2_A19BR_EncounterID ;
      private bool[] BC000Z2_n19BR_EncounterID ;
      private long[] BC000Z8_A226BR_PathologyID ;
      private bool[] BC000Z8_n226BR_PathologyID ;
      private long[] BC000Z11_A85BR_Information_ID ;
      private bool[] BC000Z11_n85BR_Information_ID ;
      private String[] BC000Z12_A36BR_Information_PatientNo ;
      private bool[] BC000Z12_n36BR_Information_PatientNo ;
      private long[] BC000Z13_A288BR_Pathology_OtherID ;
      private long[] BC000Z14_A276BR_Pathology_DiagID ;
      private long[] BC000Z15_A274BR_Pathology_SpecimenID ;
      private long[] BC000Z16_A85BR_Information_ID ;
      private bool[] BC000Z16_n85BR_Information_ID ;
      private long[] BC000Z16_A226BR_PathologyID ;
      private bool[] BC000Z16_n226BR_PathologyID ;
      private String[] BC000Z16_A505BR_Pathology_N_Code ;
      private bool[] BC000Z16_n505BR_Pathology_N_Code ;
      private String[] BC000Z16_A506BR_Pathology_M_Code ;
      private bool[] BC000Z16_n506BR_Pathology_M_Code ;
      private String[] BC000Z16_A508BR_PathologyID_PAHosp_Code ;
      private bool[] BC000Z16_n508BR_PathologyID_PAHosp_Code ;
      private String[] BC000Z16_A36BR_Information_PatientNo ;
      private bool[] BC000Z16_n36BR_Information_PatientNo ;
      private long[] BC000Z16_A237BR_PathologyID_TestID ;
      private bool[] BC000Z16_n237BR_PathologyID_TestID ;
      private DateTime[] BC000Z16_A238BR_PathologyID_PADate ;
      private bool[] BC000Z16_n238BR_PathologyID_PADate ;
      private String[] BC000Z16_A239BR_PathologyID_PAHosp ;
      private bool[] BC000Z16_n239BR_PathologyID_PAHosp ;
      private short[] BC000Z16_A240BR_PathologyID_PAAge ;
      private bool[] BC000Z16_n240BR_PathologyID_PAAge ;
      private String[] BC000Z16_A241BR_PathologyID_PrePaDia ;
      private bool[] BC000Z16_n241BR_PathologyID_PrePaDia ;
      private String[] BC000Z16_A242BR_PathologyID_PAResult ;
      private bool[] BC000Z16_n242BR_PathologyID_PAResult ;
      private String[] BC000Z16_A326BR_Pathology_Dia_Name ;
      private bool[] BC000Z16_n326BR_Pathology_Dia_Name ;
      private decimal[] BC000Z16_A314BR_Pathology_T ;
      private bool[] BC000Z16_n314BR_Pathology_T ;
      private String[] BC000Z16_A315BR_Pathology_N ;
      private bool[] BC000Z16_n315BR_Pathology_N ;
      private decimal[] BC000Z16_A316BR_Pathology_LymphNum ;
      private bool[] BC000Z16_n316BR_Pathology_LymphNum ;
      private String[] BC000Z16_A317BR_Pathology_LymphRate ;
      private bool[] BC000Z16_n317BR_Pathology_LymphRate ;
      private String[] BC000Z16_A318BR_Pathology_M ;
      private bool[] BC000Z16_n318BR_Pathology_M ;
      private String[] BC000Z16_A319BR_Pathology_MetaLoc ;
      private bool[] BC000Z16_n319BR_Pathology_MetaLoc ;
      private long[] BC000Z16_A19BR_EncounterID ;
      private bool[] BC000Z16_n19BR_EncounterID ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_datastore1 ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV8WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV11TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV14TrnContextAtt ;
   }

   public class br_pathology_bc__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class br_pathology_bc__default : DataStoreHelperBase, IDataStoreHelper
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
       ,new ForEachCursor(def[14])
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmBC000Z6 ;
        prmBC000Z6 = new Object[] {
        new Object[] {"@BR_PathologyID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000Z4 ;
        prmBC000Z4 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000Z5 ;
        prmBC000Z5 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000Z7 ;
        prmBC000Z7 = new Object[] {
        new Object[] {"@BR_PathologyID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000Z3 ;
        prmBC000Z3 = new Object[] {
        new Object[] {"@BR_PathologyID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000Z2 ;
        prmBC000Z2 = new Object[] {
        new Object[] {"@BR_PathologyID",SqlDbType.Decimal,18,0}
        } ;
        /* Definition of BR_PathologyID_PAResult changed to svchar length 4000 decimals 0 */
        Object[] prmBC000Z8 ;
        prmBC000Z8 = new Object[] {
        new Object[] {"@BR_Pathology_N_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Pathology_M_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_PathologyID_PAHosp_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_PathologyID_TestID",SqlDbType.Decimal,10,0} ,
        new Object[] {"@BR_PathologyID_PADate",SqlDbType.DateTime,8,0} ,
        new Object[] {"@BR_PathologyID_PAHosp",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_PathologyID_PAAge",SqlDbType.SmallInt,3,0} ,
        new Object[] {"@BR_PathologyID_PrePaDia",SqlDbType.NVarChar,4000,0} ,
        new Object[] {"@BR_PathologyID_PAResult",SqlDbType.NVarChar,4000,0} ,
        new Object[] {"@BR_Pathology_Dia_Name",SqlDbType.NVarChar,3000,0} ,
        new Object[] {"@BR_Pathology_T",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_Pathology_N",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Pathology_LymphNum",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_Pathology_LymphRate",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Pathology_M",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Pathology_MetaLoc",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        /* Definition of BR_PathologyID_PAResult changed to svchar length 4000 decimals 0 */
        Object[] prmBC000Z9 ;
        prmBC000Z9 = new Object[] {
        new Object[] {"@BR_Pathology_N_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Pathology_M_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_PathologyID_PAHosp_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_PathologyID_TestID",SqlDbType.Decimal,10,0} ,
        new Object[] {"@BR_PathologyID_PADate",SqlDbType.DateTime,8,0} ,
        new Object[] {"@BR_PathologyID_PAHosp",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_PathologyID_PAAge",SqlDbType.SmallInt,3,0} ,
        new Object[] {"@BR_PathologyID_PrePaDia",SqlDbType.NVarChar,4000,0} ,
        new Object[] {"@BR_PathologyID_PAResult",SqlDbType.NVarChar,4000,0} ,
        new Object[] {"@BR_Pathology_Dia_Name",SqlDbType.NVarChar,3000,0} ,
        new Object[] {"@BR_Pathology_T",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_Pathology_N",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Pathology_LymphNum",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_Pathology_LymphRate",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Pathology_M",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Pathology_MetaLoc",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_PathologyID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000Z10 ;
        prmBC000Z10 = new Object[] {
        new Object[] {"@BR_PathologyID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000Z11 ;
        prmBC000Z11 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000Z12 ;
        prmBC000Z12 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000Z13 ;
        prmBC000Z13 = new Object[] {
        new Object[] {"@BR_PathologyID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000Z14 ;
        prmBC000Z14 = new Object[] {
        new Object[] {"@BR_PathologyID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000Z15 ;
        prmBC000Z15 = new Object[] {
        new Object[] {"@BR_PathologyID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000Z16 ;
        prmBC000Z16 = new Object[] {
        new Object[] {"@BR_PathologyID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("BC000Z2", "SELECT [BR_PathologyID], [BR_Pathology_N_Code], [BR_Pathology_M_Code], [BR_PathologyID_PAHosp_Code], [BR_PathologyID_TestID], [BR_PathologyID_PADate], [BR_PathologyID_PAHosp], [BR_PathologyID_PAAge], [BR_PathologyID_PrePaDia], [BR_PathologyID_PAResult], [BR_Pathology_Dia_Name], [BR_Pathology_T], [BR_Pathology_N], [BR_Pathology_LymphNum], [BR_Pathology_LymphRate], [BR_Pathology_M], [BR_Pathology_MetaLoc], [BR_EncounterID] FROM [BR_Pathology] WITH (UPDLOCK) WHERE [BR_PathologyID] = @BR_PathologyID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000Z2,1,0,true,false )
           ,new CursorDef("BC000Z3", "SELECT [BR_PathologyID], [BR_Pathology_N_Code], [BR_Pathology_M_Code], [BR_PathologyID_PAHosp_Code], [BR_PathologyID_TestID], [BR_PathologyID_PADate], [BR_PathologyID_PAHosp], [BR_PathologyID_PAAge], [BR_PathologyID_PrePaDia], [BR_PathologyID_PAResult], [BR_Pathology_Dia_Name], [BR_Pathology_T], [BR_Pathology_N], [BR_Pathology_LymphNum], [BR_Pathology_LymphRate], [BR_Pathology_M], [BR_Pathology_MetaLoc], [BR_EncounterID] FROM [BR_Pathology] WITH (NOLOCK) WHERE [BR_PathologyID] = @BR_PathologyID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000Z3,1,0,true,false )
           ,new CursorDef("BC000Z4", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000Z4,1,0,true,false )
           ,new CursorDef("BC000Z5", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000Z5,1,0,true,false )
           ,new CursorDef("BC000Z6", "SELECT T2.[BR_Information_ID], TM1.[BR_PathologyID], TM1.[BR_Pathology_N_Code], TM1.[BR_Pathology_M_Code], TM1.[BR_PathologyID_PAHosp_Code], T3.[BR_Information_PatientNo], TM1.[BR_PathologyID_TestID], TM1.[BR_PathologyID_PADate], TM1.[BR_PathologyID_PAHosp], TM1.[BR_PathologyID_PAAge], TM1.[BR_PathologyID_PrePaDia], TM1.[BR_PathologyID_PAResult], TM1.[BR_Pathology_Dia_Name], TM1.[BR_Pathology_T], TM1.[BR_Pathology_N], TM1.[BR_Pathology_LymphNum], TM1.[BR_Pathology_LymphRate], TM1.[BR_Pathology_M], TM1.[BR_Pathology_MetaLoc], TM1.[BR_EncounterID] FROM (([BR_Pathology] TM1 WITH (NOLOCK) LEFT JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = TM1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID]) WHERE TM1.[BR_PathologyID] = @BR_PathologyID ORDER BY TM1.[BR_PathologyID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000Z6,100,0,true,false )
           ,new CursorDef("BC000Z7", "SELECT [BR_PathologyID] FROM [BR_Pathology] WITH (NOLOCK) WHERE [BR_PathologyID] = @BR_PathologyID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000Z7,1,0,true,false )
           ,new CursorDef("BC000Z8", "INSERT INTO [BR_Pathology]([BR_Pathology_N_Code], [BR_Pathology_M_Code], [BR_PathologyID_PAHosp_Code], [BR_PathologyID_TestID], [BR_PathologyID_PADate], [BR_PathologyID_PAHosp], [BR_PathologyID_PAAge], [BR_PathologyID_PrePaDia], [BR_PathologyID_PAResult], [BR_Pathology_Dia_Name], [BR_Pathology_T], [BR_Pathology_N], [BR_Pathology_LymphNum], [BR_Pathology_LymphRate], [BR_Pathology_M], [BR_Pathology_MetaLoc], [BR_EncounterID]) VALUES(@BR_Pathology_N_Code, @BR_Pathology_M_Code, @BR_PathologyID_PAHosp_Code, @BR_PathologyID_TestID, @BR_PathologyID_PADate, @BR_PathologyID_PAHosp, @BR_PathologyID_PAAge, @BR_PathologyID_PrePaDia, @BR_PathologyID_PAResult, @BR_Pathology_Dia_Name, @BR_Pathology_T, @BR_Pathology_N, @BR_Pathology_LymphNum, @BR_Pathology_LymphRate, @BR_Pathology_M, @BR_Pathology_MetaLoc, @BR_EncounterID); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmBC000Z8)
           ,new CursorDef("BC000Z9", "UPDATE [BR_Pathology] SET [BR_Pathology_N_Code]=@BR_Pathology_N_Code, [BR_Pathology_M_Code]=@BR_Pathology_M_Code, [BR_PathologyID_PAHosp_Code]=@BR_PathologyID_PAHosp_Code, [BR_PathologyID_TestID]=@BR_PathologyID_TestID, [BR_PathologyID_PADate]=@BR_PathologyID_PADate, [BR_PathologyID_PAHosp]=@BR_PathologyID_PAHosp, [BR_PathologyID_PAAge]=@BR_PathologyID_PAAge, [BR_PathologyID_PrePaDia]=@BR_PathologyID_PrePaDia, [BR_PathologyID_PAResult]=@BR_PathologyID_PAResult, [BR_Pathology_Dia_Name]=@BR_Pathology_Dia_Name, [BR_Pathology_T]=@BR_Pathology_T, [BR_Pathology_N]=@BR_Pathology_N, [BR_Pathology_LymphNum]=@BR_Pathology_LymphNum, [BR_Pathology_LymphRate]=@BR_Pathology_LymphRate, [BR_Pathology_M]=@BR_Pathology_M, [BR_Pathology_MetaLoc]=@BR_Pathology_MetaLoc, [BR_EncounterID]=@BR_EncounterID  WHERE [BR_PathologyID] = @BR_PathologyID", GxErrorMask.GX_NOMASK,prmBC000Z9)
           ,new CursorDef("BC000Z10", "DELETE FROM [BR_Pathology]  WHERE [BR_PathologyID] = @BR_PathologyID", GxErrorMask.GX_NOMASK,prmBC000Z10)
           ,new CursorDef("BC000Z11", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000Z11,1,0,true,false )
           ,new CursorDef("BC000Z12", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000Z12,1,0,true,false )
           ,new CursorDef("BC000Z13", "SELECT TOP 1 [BR_Pathology_OtherID] FROM [BR_Pathology_Other] WITH (NOLOCK) WHERE [BR_PathologyID] = @BR_PathologyID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000Z13,1,0,true,true )
           ,new CursorDef("BC000Z14", "SELECT TOP 1 [BR_Pathology_DiagID] FROM [BR_Pathology_Diag] WITH (NOLOCK) WHERE [BR_PathologyID] = @BR_PathologyID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000Z14,1,0,true,true )
           ,new CursorDef("BC000Z15", "SELECT TOP 1 [BR_Pathology_SpecimenID] FROM [BR_Pathology_Specimen] WITH (NOLOCK) WHERE [BR_PathologyID] = @BR_PathologyID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000Z15,1,0,true,true )
           ,new CursorDef("BC000Z16", "SELECT T2.[BR_Information_ID], TM1.[BR_PathologyID], TM1.[BR_Pathology_N_Code], TM1.[BR_Pathology_M_Code], TM1.[BR_PathologyID_PAHosp_Code], T3.[BR_Information_PatientNo], TM1.[BR_PathologyID_TestID], TM1.[BR_PathologyID_PADate], TM1.[BR_PathologyID_PAHosp], TM1.[BR_PathologyID_PAAge], TM1.[BR_PathologyID_PrePaDia], TM1.[BR_PathologyID_PAResult], TM1.[BR_Pathology_Dia_Name], TM1.[BR_Pathology_T], TM1.[BR_Pathology_N], TM1.[BR_Pathology_LymphNum], TM1.[BR_Pathology_LymphRate], TM1.[BR_Pathology_M], TM1.[BR_Pathology_MetaLoc], TM1.[BR_EncounterID] FROM (([BR_Pathology] TM1 WITH (NOLOCK) LEFT JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = TM1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID]) WHERE TM1.[BR_PathologyID] = @BR_PathologyID ORDER BY TM1.[BR_PathologyID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000Z16,100,0,true,false )
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
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((DateTime[]) buf[9])[0] = rslt.getGXDate(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((short[]) buf[13])[0] = rslt.getShort(8) ;
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
              ((decimal[]) buf[25])[0] = rslt.getDecimal(14) ;
              ((bool[]) buf[26])[0] = rslt.wasNull(14);
              ((String[]) buf[27])[0] = rslt.getVarchar(15) ;
              ((bool[]) buf[28])[0] = rslt.wasNull(15);
              ((String[]) buf[29])[0] = rslt.getVarchar(16) ;
              ((bool[]) buf[30])[0] = rslt.wasNull(16);
              ((String[]) buf[31])[0] = rslt.getVarchar(17) ;
              ((bool[]) buf[32])[0] = rslt.wasNull(17);
              ((long[]) buf[33])[0] = rslt.getLong(18) ;
              ((bool[]) buf[34])[0] = rslt.wasNull(18);
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
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((DateTime[]) buf[9])[0] = rslt.getGXDate(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((short[]) buf[13])[0] = rslt.getShort(8) ;
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
              ((decimal[]) buf[25])[0] = rslt.getDecimal(14) ;
              ((bool[]) buf[26])[0] = rslt.wasNull(14);
              ((String[]) buf[27])[0] = rslt.getVarchar(15) ;
              ((bool[]) buf[28])[0] = rslt.wasNull(15);
              ((String[]) buf[29])[0] = rslt.getVarchar(16) ;
              ((bool[]) buf[30])[0] = rslt.wasNull(16);
              ((String[]) buf[31])[0] = rslt.getVarchar(17) ;
              ((bool[]) buf[32])[0] = rslt.wasNull(17);
              ((long[]) buf[33])[0] = rslt.getLong(18) ;
              ((bool[]) buf[34])[0] = rslt.wasNull(18);
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
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((DateTime[]) buf[13])[0] = rslt.getGXDate(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((short[]) buf[17])[0] = rslt.getShort(10) ;
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
              ((decimal[]) buf[29])[0] = rslt.getDecimal(16) ;
              ((bool[]) buf[30])[0] = rslt.wasNull(16);
              ((String[]) buf[31])[0] = rslt.getVarchar(17) ;
              ((bool[]) buf[32])[0] = rslt.wasNull(17);
              ((String[]) buf[33])[0] = rslt.getVarchar(18) ;
              ((bool[]) buf[34])[0] = rslt.wasNull(18);
              ((String[]) buf[35])[0] = rslt.getVarchar(19) ;
              ((bool[]) buf[36])[0] = rslt.wasNull(19);
              ((long[]) buf[37])[0] = rslt.getLong(20) ;
              ((bool[]) buf[38])[0] = rslt.wasNull(20);
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
              return;
           case 14 :
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
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((DateTime[]) buf[13])[0] = rslt.getGXDate(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((short[]) buf[17])[0] = rslt.getShort(10) ;
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
              ((decimal[]) buf[29])[0] = rslt.getDecimal(16) ;
              ((bool[]) buf[30])[0] = rslt.wasNull(16);
              ((String[]) buf[31])[0] = rslt.getVarchar(17) ;
              ((bool[]) buf[32])[0] = rslt.wasNull(17);
              ((String[]) buf[33])[0] = rslt.getVarchar(18) ;
              ((bool[]) buf[34])[0] = rslt.wasNull(18);
              ((String[]) buf[35])[0] = rslt.getVarchar(19) ;
              ((bool[]) buf[36])[0] = rslt.wasNull(19);
              ((long[]) buf[37])[0] = rslt.getLong(20) ;
              ((bool[]) buf[38])[0] = rslt.wasNull(20);
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
                 stmt.setNull( 3 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(3, (String)parms[5]);
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
                 stmt.setNull( 5 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameter(5, (DateTime)parms[9]);
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
                 stmt.setNull( 7 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(7, (short)parms[13]);
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
                 stmt.setNull( 11 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(11, (decimal)parms[21]);
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
                 stmt.setNull( 17 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(17, (long)parms[33]);
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
                 stmt.setNull( 3 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(3, (String)parms[5]);
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
                 stmt.setNull( 5 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameter(5, (DateTime)parms[9]);
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
                 stmt.setNull( 7 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(7, (short)parms[13]);
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
                 stmt.setNull( 11 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(11, (decimal)parms[21]);
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
                 stmt.setNull( 17 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(17, (long)parms[33]);
              }
              if ( (bool)parms[34] )
              {
                 stmt.setNull( 18 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(18, (long)parms[35]);
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
           case 14 :
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
