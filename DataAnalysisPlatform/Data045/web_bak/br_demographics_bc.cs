/*
               File: BR_Demographics_BC
        Description: 人口信息学
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:36:12.30
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
   public class br_demographics_bc : GXHttpHandler, IGxSilentTrn
   {
      public br_demographics_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_demographics_bc( IGxContext context )
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
         ReadRow0B12( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey0B12( ) ;
         standaloneModal( ) ;
         AddRow0B12( ) ;
         Gx_mode = "INS";
         return  ;
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E110B2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               Z61BR_Demographics_ID = A61BR_Demographics_ID;
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

      protected void CONFIRM_0B0( )
      {
         BeforeValidate0B12( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0B12( ) ;
            }
            else
            {
               CheckExtendedTable0B12( ) ;
               if ( AnyError == 0 )
               {
                  ZM0B12( 16) ;
                  ZM0B12( 17) ;
               }
               CloseExtendedTableCursors0B12( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void E120B2( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV7WWPContext) ;
         AV13IsAuthorized = true;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            GXt_boolean1 = AV13IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Demographics", out  GXt_boolean1) ;
            AV13IsAuthorized = GXt_boolean1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            GXt_boolean1 = AV13IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Demographics", out  GXt_boolean1) ;
            AV13IsAuthorized = GXt_boolean1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            GXt_boolean1 = AV13IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Demographics", out  GXt_boolean1) ;
            AV13IsAuthorized = GXt_boolean1;
         }
         if ( ! AV13IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV16Pgmname)));
            context.wjLocDisableFrm = 1;
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

      protected void E110B2( )
      {
         /* After Trn Routine */
      }

      protected void ZM0B12( short GX_JID )
      {
         if ( ( GX_JID == 15 ) || ( GX_JID == 0 ) )
         {
            Z455BR_Demographics_Sex_Code = A455BR_Demographics_Sex_Code;
            Z456BR_Demographics_MarritalStatus_Code = A456BR_Demographics_MarritalStatus_Code;
            Z457BR_Demographics_Ethnic_Code = A457BR_Demographics_Ethnic_Code;
            Z458BR_Demographics_Education_Code = A458BR_Demographics_Education_Code;
            Z459BR_Demographics_Insurance_Code = A459BR_Demographics_Insurance_Code;
            Z53BR_Demographics_BirthDate = A53BR_Demographics_BirthDate;
            Z54BR_Demographics_Sex = A54BR_Demographics_Sex;
            Z63BR_Demographics_MarritalStatus = A63BR_Demographics_MarritalStatus;
            Z55BR_Demographics_Ethnic = A55BR_Demographics_Ethnic;
            Z56BR_Demographics_Education = A56BR_Demographics_Education;
            Z57BR_Demographics_Occupation = A57BR_Demographics_Occupation;
            Z58BR_Demographics_Insurance = A58BR_Demographics_Insurance;
            Z59BR_Demographics_Province = A59BR_Demographics_Province;
            Z60BR_Demographics_City = A60BR_Demographics_City;
            Z19BR_EncounterID = A19BR_EncounterID;
         }
         if ( ( GX_JID == 16 ) || ( GX_JID == 0 ) )
         {
            Z85BR_Information_ID = A85BR_Information_ID;
         }
         if ( ( GX_JID == 17 ) || ( GX_JID == 0 ) )
         {
            Z36BR_Information_PatientNo = A36BR_Information_PatientNo;
         }
         if ( GX_JID == -15 )
         {
            Z61BR_Demographics_ID = A61BR_Demographics_ID;
            Z455BR_Demographics_Sex_Code = A455BR_Demographics_Sex_Code;
            Z456BR_Demographics_MarritalStatus_Code = A456BR_Demographics_MarritalStatus_Code;
            Z457BR_Demographics_Ethnic_Code = A457BR_Demographics_Ethnic_Code;
            Z458BR_Demographics_Education_Code = A458BR_Demographics_Education_Code;
            Z459BR_Demographics_Insurance_Code = A459BR_Demographics_Insurance_Code;
            Z53BR_Demographics_BirthDate = A53BR_Demographics_BirthDate;
            Z54BR_Demographics_Sex = A54BR_Demographics_Sex;
            Z63BR_Demographics_MarritalStatus = A63BR_Demographics_MarritalStatus;
            Z55BR_Demographics_Ethnic = A55BR_Demographics_Ethnic;
            Z56BR_Demographics_Education = A56BR_Demographics_Education;
            Z57BR_Demographics_Occupation = A57BR_Demographics_Occupation;
            Z58BR_Demographics_Insurance = A58BR_Demographics_Insurance;
            Z59BR_Demographics_Province = A59BR_Demographics_Province;
            Z60BR_Demographics_City = A60BR_Demographics_City;
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

      protected void Load0B12( )
      {
         /* Using cursor BC000B6 */
         pr_default.execute(4, new Object[] {A61BR_Demographics_ID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound12 = 1;
            A85BR_Information_ID = BC000B6_A85BR_Information_ID[0];
            n85BR_Information_ID = BC000B6_n85BR_Information_ID[0];
            A455BR_Demographics_Sex_Code = BC000B6_A455BR_Demographics_Sex_Code[0];
            n455BR_Demographics_Sex_Code = BC000B6_n455BR_Demographics_Sex_Code[0];
            A456BR_Demographics_MarritalStatus_Code = BC000B6_A456BR_Demographics_MarritalStatus_Code[0];
            n456BR_Demographics_MarritalStatus_Code = BC000B6_n456BR_Demographics_MarritalStatus_Code[0];
            A457BR_Demographics_Ethnic_Code = BC000B6_A457BR_Demographics_Ethnic_Code[0];
            n457BR_Demographics_Ethnic_Code = BC000B6_n457BR_Demographics_Ethnic_Code[0];
            A458BR_Demographics_Education_Code = BC000B6_A458BR_Demographics_Education_Code[0];
            n458BR_Demographics_Education_Code = BC000B6_n458BR_Demographics_Education_Code[0];
            A459BR_Demographics_Insurance_Code = BC000B6_A459BR_Demographics_Insurance_Code[0];
            n459BR_Demographics_Insurance_Code = BC000B6_n459BR_Demographics_Insurance_Code[0];
            A36BR_Information_PatientNo = BC000B6_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = BC000B6_n36BR_Information_PatientNo[0];
            A53BR_Demographics_BirthDate = BC000B6_A53BR_Demographics_BirthDate[0];
            n53BR_Demographics_BirthDate = BC000B6_n53BR_Demographics_BirthDate[0];
            A54BR_Demographics_Sex = BC000B6_A54BR_Demographics_Sex[0];
            n54BR_Demographics_Sex = BC000B6_n54BR_Demographics_Sex[0];
            A63BR_Demographics_MarritalStatus = BC000B6_A63BR_Demographics_MarritalStatus[0];
            n63BR_Demographics_MarritalStatus = BC000B6_n63BR_Demographics_MarritalStatus[0];
            A55BR_Demographics_Ethnic = BC000B6_A55BR_Demographics_Ethnic[0];
            n55BR_Demographics_Ethnic = BC000B6_n55BR_Demographics_Ethnic[0];
            A56BR_Demographics_Education = BC000B6_A56BR_Demographics_Education[0];
            n56BR_Demographics_Education = BC000B6_n56BR_Demographics_Education[0];
            A57BR_Demographics_Occupation = BC000B6_A57BR_Demographics_Occupation[0];
            n57BR_Demographics_Occupation = BC000B6_n57BR_Demographics_Occupation[0];
            A58BR_Demographics_Insurance = BC000B6_A58BR_Demographics_Insurance[0];
            n58BR_Demographics_Insurance = BC000B6_n58BR_Demographics_Insurance[0];
            A59BR_Demographics_Province = BC000B6_A59BR_Demographics_Province[0];
            n59BR_Demographics_Province = BC000B6_n59BR_Demographics_Province[0];
            A60BR_Demographics_City = BC000B6_A60BR_Demographics_City[0];
            n60BR_Demographics_City = BC000B6_n60BR_Demographics_City[0];
            A19BR_EncounterID = BC000B6_A19BR_EncounterID[0];
            ZM0B12( -15) ;
         }
         pr_default.close(4);
         OnLoadActions0B12( ) ;
      }

      protected void OnLoadActions0B12( )
      {
         AV16Pgmname = "BR_Demographics_BC";
      }

      protected void CheckExtendedTable0B12( )
      {
         standaloneModal( ) ;
         AV16Pgmname = "BR_Demographics_BC";
         /* Using cursor BC000B4 */
         pr_default.execute(2, new Object[] {A19BR_EncounterID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("不匹配' T15'", "ForeignKeyNotFound", 1, "BR_ENCOUNTERID");
            AnyError = 1;
         }
         A85BR_Information_ID = BC000B4_A85BR_Information_ID[0];
         n85BR_Information_ID = BC000B4_n85BR_Information_ID[0];
         pr_default.close(2);
         /* Using cursor BC000B5 */
         pr_default.execute(3, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
         if ( (pr_default.getStatus(3) == 101) )
         {
            if ( ! ( (0==A85BR_Information_ID) ) )
            {
               GX_msglist.addItem("不匹配' T16'", "ForeignKeyNotFound", 1, "");
               AnyError = 1;
            }
         }
         A36BR_Information_PatientNo = BC000B5_A36BR_Information_PatientNo[0];
         n36BR_Information_PatientNo = BC000B5_n36BR_Information_PatientNo[0];
         pr_default.close(3);
         if ( ! ( (DateTime.MinValue==A53BR_Demographics_BirthDate) || ( A53BR_Demographics_BirthDate >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("域������������超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A54BR_Demographics_Sex)) )
         {
            GX_msglist.addItem("性别是必须选择的", 1, "");
            AnyError = 1;
         }
      }

      protected void CloseExtendedTableCursors0B12( )
      {
         pr_default.close(2);
         pr_default.close(3);
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0B12( )
      {
         /* Using cursor BC000B7 */
         pr_default.execute(5, new Object[] {A61BR_Demographics_ID});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound12 = 1;
         }
         else
         {
            RcdFound12 = 0;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC000B3 */
         pr_default.execute(1, new Object[] {A61BR_Demographics_ID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0B12( 15) ;
            RcdFound12 = 1;
            A61BR_Demographics_ID = BC000B3_A61BR_Demographics_ID[0];
            A455BR_Demographics_Sex_Code = BC000B3_A455BR_Demographics_Sex_Code[0];
            n455BR_Demographics_Sex_Code = BC000B3_n455BR_Demographics_Sex_Code[0];
            A456BR_Demographics_MarritalStatus_Code = BC000B3_A456BR_Demographics_MarritalStatus_Code[0];
            n456BR_Demographics_MarritalStatus_Code = BC000B3_n456BR_Demographics_MarritalStatus_Code[0];
            A457BR_Demographics_Ethnic_Code = BC000B3_A457BR_Demographics_Ethnic_Code[0];
            n457BR_Demographics_Ethnic_Code = BC000B3_n457BR_Demographics_Ethnic_Code[0];
            A458BR_Demographics_Education_Code = BC000B3_A458BR_Demographics_Education_Code[0];
            n458BR_Demographics_Education_Code = BC000B3_n458BR_Demographics_Education_Code[0];
            A459BR_Demographics_Insurance_Code = BC000B3_A459BR_Demographics_Insurance_Code[0];
            n459BR_Demographics_Insurance_Code = BC000B3_n459BR_Demographics_Insurance_Code[0];
            A53BR_Demographics_BirthDate = BC000B3_A53BR_Demographics_BirthDate[0];
            n53BR_Demographics_BirthDate = BC000B3_n53BR_Demographics_BirthDate[0];
            A54BR_Demographics_Sex = BC000B3_A54BR_Demographics_Sex[0];
            n54BR_Demographics_Sex = BC000B3_n54BR_Demographics_Sex[0];
            A63BR_Demographics_MarritalStatus = BC000B3_A63BR_Demographics_MarritalStatus[0];
            n63BR_Demographics_MarritalStatus = BC000B3_n63BR_Demographics_MarritalStatus[0];
            A55BR_Demographics_Ethnic = BC000B3_A55BR_Demographics_Ethnic[0];
            n55BR_Demographics_Ethnic = BC000B3_n55BR_Demographics_Ethnic[0];
            A56BR_Demographics_Education = BC000B3_A56BR_Demographics_Education[0];
            n56BR_Demographics_Education = BC000B3_n56BR_Demographics_Education[0];
            A57BR_Demographics_Occupation = BC000B3_A57BR_Demographics_Occupation[0];
            n57BR_Demographics_Occupation = BC000B3_n57BR_Demographics_Occupation[0];
            A58BR_Demographics_Insurance = BC000B3_A58BR_Demographics_Insurance[0];
            n58BR_Demographics_Insurance = BC000B3_n58BR_Demographics_Insurance[0];
            A59BR_Demographics_Province = BC000B3_A59BR_Demographics_Province[0];
            n59BR_Demographics_Province = BC000B3_n59BR_Demographics_Province[0];
            A60BR_Demographics_City = BC000B3_A60BR_Demographics_City[0];
            n60BR_Demographics_City = BC000B3_n60BR_Demographics_City[0];
            A19BR_EncounterID = BC000B3_A19BR_EncounterID[0];
            Z61BR_Demographics_ID = A61BR_Demographics_ID;
            sMode12 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load0B12( ) ;
            if ( AnyError == 1 )
            {
               RcdFound12 = 0;
               InitializeNonKey0B12( ) ;
            }
            Gx_mode = sMode12;
         }
         else
         {
            RcdFound12 = 0;
            InitializeNonKey0B12( ) ;
            sMode12 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode12;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0B12( ) ;
         if ( RcdFound12 == 0 )
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
         CONFIRM_0B0( ) ;
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

      protected void CheckOptimisticConcurrency0B12( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC000B2 */
            pr_default.execute(0, new Object[] {A61BR_Demographics_ID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Demographics"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z455BR_Demographics_Sex_Code, BC000B2_A455BR_Demographics_Sex_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z456BR_Demographics_MarritalStatus_Code, BC000B2_A456BR_Demographics_MarritalStatus_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z457BR_Demographics_Ethnic_Code, BC000B2_A457BR_Demographics_Ethnic_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z458BR_Demographics_Education_Code, BC000B2_A458BR_Demographics_Education_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z459BR_Demographics_Insurance_Code, BC000B2_A459BR_Demographics_Insurance_Code[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z53BR_Demographics_BirthDate != BC000B2_A53BR_Demographics_BirthDate[0] ) || ( StringUtil.StrCmp(Z54BR_Demographics_Sex, BC000B2_A54BR_Demographics_Sex[0]) != 0 ) || ( StringUtil.StrCmp(Z63BR_Demographics_MarritalStatus, BC000B2_A63BR_Demographics_MarritalStatus[0]) != 0 ) || ( StringUtil.StrCmp(Z55BR_Demographics_Ethnic, BC000B2_A55BR_Demographics_Ethnic[0]) != 0 ) || ( StringUtil.StrCmp(Z56BR_Demographics_Education, BC000B2_A56BR_Demographics_Education[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z57BR_Demographics_Occupation, BC000B2_A57BR_Demographics_Occupation[0]) != 0 ) || ( StringUtil.StrCmp(Z58BR_Demographics_Insurance, BC000B2_A58BR_Demographics_Insurance[0]) != 0 ) || ( StringUtil.StrCmp(Z59BR_Demographics_Province, BC000B2_A59BR_Demographics_Province[0]) != 0 ) || ( StringUtil.StrCmp(Z60BR_Demographics_City, BC000B2_A60BR_Demographics_City[0]) != 0 ) || ( Z19BR_EncounterID != BC000B2_A19BR_EncounterID[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"BR_Demographics"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0B12( )
      {
         BeforeValidate0B12( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0B12( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0B12( 0) ;
            CheckOptimisticConcurrency0B12( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0B12( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0B12( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000B8 */
                     pr_default.execute(6, new Object[] {n455BR_Demographics_Sex_Code, A455BR_Demographics_Sex_Code, n456BR_Demographics_MarritalStatus_Code, A456BR_Demographics_MarritalStatus_Code, n457BR_Demographics_Ethnic_Code, A457BR_Demographics_Ethnic_Code, n458BR_Demographics_Education_Code, A458BR_Demographics_Education_Code, n459BR_Demographics_Insurance_Code, A459BR_Demographics_Insurance_Code, n53BR_Demographics_BirthDate, A53BR_Demographics_BirthDate, n54BR_Demographics_Sex, A54BR_Demographics_Sex, n63BR_Demographics_MarritalStatus, A63BR_Demographics_MarritalStatus, n55BR_Demographics_Ethnic, A55BR_Demographics_Ethnic, n56BR_Demographics_Education, A56BR_Demographics_Education, n57BR_Demographics_Occupation, A57BR_Demographics_Occupation, n58BR_Demographics_Insurance, A58BR_Demographics_Insurance, n59BR_Demographics_Province, A59BR_Demographics_Province, n60BR_Demographics_City, A60BR_Demographics_City, A19BR_EncounterID});
                     A61BR_Demographics_ID = BC000B8_A61BR_Demographics_ID[0];
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Demographics") ;
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
               Load0B12( ) ;
            }
            EndLevel0B12( ) ;
         }
         CloseExtendedTableCursors0B12( ) ;
      }

      protected void Update0B12( )
      {
         BeforeValidate0B12( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0B12( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0B12( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0B12( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0B12( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000B9 */
                     pr_default.execute(7, new Object[] {n455BR_Demographics_Sex_Code, A455BR_Demographics_Sex_Code, n456BR_Demographics_MarritalStatus_Code, A456BR_Demographics_MarritalStatus_Code, n457BR_Demographics_Ethnic_Code, A457BR_Demographics_Ethnic_Code, n458BR_Demographics_Education_Code, A458BR_Demographics_Education_Code, n459BR_Demographics_Insurance_Code, A459BR_Demographics_Insurance_Code, n53BR_Demographics_BirthDate, A53BR_Demographics_BirthDate, n54BR_Demographics_Sex, A54BR_Demographics_Sex, n63BR_Demographics_MarritalStatus, A63BR_Demographics_MarritalStatus, n55BR_Demographics_Ethnic, A55BR_Demographics_Ethnic, n56BR_Demographics_Education, A56BR_Demographics_Education, n57BR_Demographics_Occupation, A57BR_Demographics_Occupation, n58BR_Demographics_Insurance, A58BR_Demographics_Insurance, n59BR_Demographics_Province, A59BR_Demographics_Province, n60BR_Demographics_City, A60BR_Demographics_City, A19BR_EncounterID, A61BR_Demographics_ID});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Demographics") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Demographics"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0B12( ) ;
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
            EndLevel0B12( ) ;
         }
         CloseExtendedTableCursors0B12( ) ;
      }

      protected void DeferredUpdate0B12( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate0B12( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0B12( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0B12( ) ;
            AfterConfirm0B12( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0B12( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC000B10 */
                  pr_default.execute(8, new Object[] {A61BR_Demographics_ID});
                  pr_default.close(8);
                  dsDefault.SmartCacheProvider.SetUpdated("BR_Demographics") ;
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
         sMode12 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel0B12( ) ;
         Gx_mode = sMode12;
      }

      protected void OnDeleteControls0B12( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV16Pgmname = "BR_Demographics_BC";
            /* Using cursor BC000B11 */
            pr_default.execute(9, new Object[] {A19BR_EncounterID});
            A85BR_Information_ID = BC000B11_A85BR_Information_ID[0];
            n85BR_Information_ID = BC000B11_n85BR_Information_ID[0];
            pr_default.close(9);
            /* Using cursor BC000B12 */
            pr_default.execute(10, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
            A36BR_Information_PatientNo = BC000B12_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = BC000B12_n36BR_Information_PatientNo[0];
            pr_default.close(10);
         }
      }

      protected void EndLevel0B12( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0B12( ) ;
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

      public void ScanKeyStart0B12( )
      {
         /* Scan By routine */
         /* Using cursor BC000B13 */
         pr_default.execute(11, new Object[] {A61BR_Demographics_ID});
         RcdFound12 = 0;
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound12 = 1;
            A85BR_Information_ID = BC000B13_A85BR_Information_ID[0];
            n85BR_Information_ID = BC000B13_n85BR_Information_ID[0];
            A61BR_Demographics_ID = BC000B13_A61BR_Demographics_ID[0];
            A455BR_Demographics_Sex_Code = BC000B13_A455BR_Demographics_Sex_Code[0];
            n455BR_Demographics_Sex_Code = BC000B13_n455BR_Demographics_Sex_Code[0];
            A456BR_Demographics_MarritalStatus_Code = BC000B13_A456BR_Demographics_MarritalStatus_Code[0];
            n456BR_Demographics_MarritalStatus_Code = BC000B13_n456BR_Demographics_MarritalStatus_Code[0];
            A457BR_Demographics_Ethnic_Code = BC000B13_A457BR_Demographics_Ethnic_Code[0];
            n457BR_Demographics_Ethnic_Code = BC000B13_n457BR_Demographics_Ethnic_Code[0];
            A458BR_Demographics_Education_Code = BC000B13_A458BR_Demographics_Education_Code[0];
            n458BR_Demographics_Education_Code = BC000B13_n458BR_Demographics_Education_Code[0];
            A459BR_Demographics_Insurance_Code = BC000B13_A459BR_Demographics_Insurance_Code[0];
            n459BR_Demographics_Insurance_Code = BC000B13_n459BR_Demographics_Insurance_Code[0];
            A36BR_Information_PatientNo = BC000B13_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = BC000B13_n36BR_Information_PatientNo[0];
            A53BR_Demographics_BirthDate = BC000B13_A53BR_Demographics_BirthDate[0];
            n53BR_Demographics_BirthDate = BC000B13_n53BR_Demographics_BirthDate[0];
            A54BR_Demographics_Sex = BC000B13_A54BR_Demographics_Sex[0];
            n54BR_Demographics_Sex = BC000B13_n54BR_Demographics_Sex[0];
            A63BR_Demographics_MarritalStatus = BC000B13_A63BR_Demographics_MarritalStatus[0];
            n63BR_Demographics_MarritalStatus = BC000B13_n63BR_Demographics_MarritalStatus[0];
            A55BR_Demographics_Ethnic = BC000B13_A55BR_Demographics_Ethnic[0];
            n55BR_Demographics_Ethnic = BC000B13_n55BR_Demographics_Ethnic[0];
            A56BR_Demographics_Education = BC000B13_A56BR_Demographics_Education[0];
            n56BR_Demographics_Education = BC000B13_n56BR_Demographics_Education[0];
            A57BR_Demographics_Occupation = BC000B13_A57BR_Demographics_Occupation[0];
            n57BR_Demographics_Occupation = BC000B13_n57BR_Demographics_Occupation[0];
            A58BR_Demographics_Insurance = BC000B13_A58BR_Demographics_Insurance[0];
            n58BR_Demographics_Insurance = BC000B13_n58BR_Demographics_Insurance[0];
            A59BR_Demographics_Province = BC000B13_A59BR_Demographics_Province[0];
            n59BR_Demographics_Province = BC000B13_n59BR_Demographics_Province[0];
            A60BR_Demographics_City = BC000B13_A60BR_Demographics_City[0];
            n60BR_Demographics_City = BC000B13_n60BR_Demographics_City[0];
            A19BR_EncounterID = BC000B13_A19BR_EncounterID[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext0B12( )
      {
         /* Scan next routine */
         pr_default.readNext(11);
         RcdFound12 = 0;
         ScanKeyLoad0B12( ) ;
      }

      protected void ScanKeyLoad0B12( )
      {
         sMode12 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound12 = 1;
            A85BR_Information_ID = BC000B13_A85BR_Information_ID[0];
            n85BR_Information_ID = BC000B13_n85BR_Information_ID[0];
            A61BR_Demographics_ID = BC000B13_A61BR_Demographics_ID[0];
            A455BR_Demographics_Sex_Code = BC000B13_A455BR_Demographics_Sex_Code[0];
            n455BR_Demographics_Sex_Code = BC000B13_n455BR_Demographics_Sex_Code[0];
            A456BR_Demographics_MarritalStatus_Code = BC000B13_A456BR_Demographics_MarritalStatus_Code[0];
            n456BR_Demographics_MarritalStatus_Code = BC000B13_n456BR_Demographics_MarritalStatus_Code[0];
            A457BR_Demographics_Ethnic_Code = BC000B13_A457BR_Demographics_Ethnic_Code[0];
            n457BR_Demographics_Ethnic_Code = BC000B13_n457BR_Demographics_Ethnic_Code[0];
            A458BR_Demographics_Education_Code = BC000B13_A458BR_Demographics_Education_Code[0];
            n458BR_Demographics_Education_Code = BC000B13_n458BR_Demographics_Education_Code[0];
            A459BR_Demographics_Insurance_Code = BC000B13_A459BR_Demographics_Insurance_Code[0];
            n459BR_Demographics_Insurance_Code = BC000B13_n459BR_Demographics_Insurance_Code[0];
            A36BR_Information_PatientNo = BC000B13_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = BC000B13_n36BR_Information_PatientNo[0];
            A53BR_Demographics_BirthDate = BC000B13_A53BR_Demographics_BirthDate[0];
            n53BR_Demographics_BirthDate = BC000B13_n53BR_Demographics_BirthDate[0];
            A54BR_Demographics_Sex = BC000B13_A54BR_Demographics_Sex[0];
            n54BR_Demographics_Sex = BC000B13_n54BR_Demographics_Sex[0];
            A63BR_Demographics_MarritalStatus = BC000B13_A63BR_Demographics_MarritalStatus[0];
            n63BR_Demographics_MarritalStatus = BC000B13_n63BR_Demographics_MarritalStatus[0];
            A55BR_Demographics_Ethnic = BC000B13_A55BR_Demographics_Ethnic[0];
            n55BR_Demographics_Ethnic = BC000B13_n55BR_Demographics_Ethnic[0];
            A56BR_Demographics_Education = BC000B13_A56BR_Demographics_Education[0];
            n56BR_Demographics_Education = BC000B13_n56BR_Demographics_Education[0];
            A57BR_Demographics_Occupation = BC000B13_A57BR_Demographics_Occupation[0];
            n57BR_Demographics_Occupation = BC000B13_n57BR_Demographics_Occupation[0];
            A58BR_Demographics_Insurance = BC000B13_A58BR_Demographics_Insurance[0];
            n58BR_Demographics_Insurance = BC000B13_n58BR_Demographics_Insurance[0];
            A59BR_Demographics_Province = BC000B13_A59BR_Demographics_Province[0];
            n59BR_Demographics_Province = BC000B13_n59BR_Demographics_Province[0];
            A60BR_Demographics_City = BC000B13_A60BR_Demographics_City[0];
            n60BR_Demographics_City = BC000B13_n60BR_Demographics_City[0];
            A19BR_EncounterID = BC000B13_A19BR_EncounterID[0];
         }
         Gx_mode = sMode12;
      }

      protected void ScanKeyEnd0B12( )
      {
         pr_default.close(11);
      }

      protected void AfterConfirm0B12( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0B12( )
      {
         /* Before Insert Rules */
         GXt_char2 = A455BR_Demographics_Sex_Code;
         new zutil_findtargetcode(context ).execute(  7,  A54BR_Demographics_Sex, out  GXt_char2) ;
         A455BR_Demographics_Sex_Code = GXt_char2;
         n455BR_Demographics_Sex_Code = false;
         GXt_char2 = A456BR_Demographics_MarritalStatus_Code;
         new zutil_findtargetcode(context ).execute(  8,  A63BR_Demographics_MarritalStatus, out  GXt_char2) ;
         A456BR_Demographics_MarritalStatus_Code = GXt_char2;
         n456BR_Demographics_MarritalStatus_Code = false;
         GXt_char2 = A457BR_Demographics_Ethnic_Code;
         new zutil_findtargetcode(context ).execute(  9,  A55BR_Demographics_Ethnic, out  GXt_char2) ;
         A457BR_Demographics_Ethnic_Code = GXt_char2;
         n457BR_Demographics_Ethnic_Code = false;
         GXt_char2 = A458BR_Demographics_Education_Code;
         new zutil_findtargetcode(context ).execute(  10,  A56BR_Demographics_Education, out  GXt_char2) ;
         A458BR_Demographics_Education_Code = GXt_char2;
         n458BR_Demographics_Education_Code = false;
         GXt_char2 = A459BR_Demographics_Insurance_Code;
         new zutil_findtargetcode(context ).execute(  11,  A58BR_Demographics_Insurance, out  GXt_char2) ;
         A459BR_Demographics_Insurance_Code = GXt_char2;
         n459BR_Demographics_Insurance_Code = false;
      }

      protected void BeforeUpdate0B12( )
      {
         /* Before Update Rules */
         GXt_char2 = A455BR_Demographics_Sex_Code;
         new zutil_findtargetcode(context ).execute(  7,  A54BR_Demographics_Sex, out  GXt_char2) ;
         A455BR_Demographics_Sex_Code = GXt_char2;
         n455BR_Demographics_Sex_Code = false;
         GXt_char2 = A456BR_Demographics_MarritalStatus_Code;
         new zutil_findtargetcode(context ).execute(  8,  A63BR_Demographics_MarritalStatus, out  GXt_char2) ;
         A456BR_Demographics_MarritalStatus_Code = GXt_char2;
         n456BR_Demographics_MarritalStatus_Code = false;
         GXt_char2 = A457BR_Demographics_Ethnic_Code;
         new zutil_findtargetcode(context ).execute(  9,  A55BR_Demographics_Ethnic, out  GXt_char2) ;
         A457BR_Demographics_Ethnic_Code = GXt_char2;
         n457BR_Demographics_Ethnic_Code = false;
         GXt_char2 = A458BR_Demographics_Education_Code;
         new zutil_findtargetcode(context ).execute(  10,  A56BR_Demographics_Education, out  GXt_char2) ;
         A458BR_Demographics_Education_Code = GXt_char2;
         n458BR_Demographics_Education_Code = false;
         GXt_char2 = A459BR_Demographics_Insurance_Code;
         new zutil_findtargetcode(context ).execute(  11,  A58BR_Demographics_Insurance, out  GXt_char2) ;
         A459BR_Demographics_Insurance_Code = GXt_char2;
         n459BR_Demographics_Insurance_Code = false;
      }

      protected void BeforeDelete0B12( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0B12( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0B12( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0B12( )
      {
      }

      protected void send_integrity_lvl_hashes0B12( )
      {
      }

      protected void AddRow0B12( )
      {
         VarsToRow12( bcBR_Demographics) ;
      }

      protected void ReadRow0B12( )
      {
         RowToVars12( bcBR_Demographics, 1) ;
      }

      protected void InitializeNonKey0B12( )
      {
         A85BR_Information_ID = 0;
         n85BR_Information_ID = false;
         A455BR_Demographics_Sex_Code = "";
         n455BR_Demographics_Sex_Code = false;
         A456BR_Demographics_MarritalStatus_Code = "";
         n456BR_Demographics_MarritalStatus_Code = false;
         A457BR_Demographics_Ethnic_Code = "";
         n457BR_Demographics_Ethnic_Code = false;
         A458BR_Demographics_Education_Code = "";
         n458BR_Demographics_Education_Code = false;
         A459BR_Demographics_Insurance_Code = "";
         n459BR_Demographics_Insurance_Code = false;
         A19BR_EncounterID = 0;
         A36BR_Information_PatientNo = "";
         n36BR_Information_PatientNo = false;
         A53BR_Demographics_BirthDate = DateTime.MinValue;
         n53BR_Demographics_BirthDate = false;
         A54BR_Demographics_Sex = "";
         n54BR_Demographics_Sex = false;
         A63BR_Demographics_MarritalStatus = "";
         n63BR_Demographics_MarritalStatus = false;
         A55BR_Demographics_Ethnic = "";
         n55BR_Demographics_Ethnic = false;
         A56BR_Demographics_Education = "";
         n56BR_Demographics_Education = false;
         A57BR_Demographics_Occupation = "";
         n57BR_Demographics_Occupation = false;
         A58BR_Demographics_Insurance = "";
         n58BR_Demographics_Insurance = false;
         A59BR_Demographics_Province = "";
         n59BR_Demographics_Province = false;
         A60BR_Demographics_City = "";
         n60BR_Demographics_City = false;
         Z455BR_Demographics_Sex_Code = "";
         Z456BR_Demographics_MarritalStatus_Code = "";
         Z457BR_Demographics_Ethnic_Code = "";
         Z458BR_Demographics_Education_Code = "";
         Z459BR_Demographics_Insurance_Code = "";
         Z53BR_Demographics_BirthDate = DateTime.MinValue;
         Z54BR_Demographics_Sex = "";
         Z63BR_Demographics_MarritalStatus = "";
         Z55BR_Demographics_Ethnic = "";
         Z56BR_Demographics_Education = "";
         Z57BR_Demographics_Occupation = "";
         Z58BR_Demographics_Insurance = "";
         Z59BR_Demographics_Province = "";
         Z60BR_Demographics_City = "";
         Z19BR_EncounterID = 0;
      }

      protected void InitAll0B12( )
      {
         A61BR_Demographics_ID = 0;
         InitializeNonKey0B12( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow12( SdtBR_Demographics obj12 )
      {
         obj12.gxTpr_Mode = Gx_mode;
         obj12.gxTpr_Br_demographics_sex_code = A455BR_Demographics_Sex_Code;
         obj12.gxTpr_Br_demographics_marritalstatus_code = A456BR_Demographics_MarritalStatus_Code;
         obj12.gxTpr_Br_demographics_ethnic_code = A457BR_Demographics_Ethnic_Code;
         obj12.gxTpr_Br_demographics_education_code = A458BR_Demographics_Education_Code;
         obj12.gxTpr_Br_demographics_insurance_code = A459BR_Demographics_Insurance_Code;
         obj12.gxTpr_Br_encounterid = A19BR_EncounterID;
         obj12.gxTpr_Br_information_patientno = A36BR_Information_PatientNo;
         obj12.gxTpr_Br_demographics_birthdate = A53BR_Demographics_BirthDate;
         obj12.gxTpr_Br_demographics_sex = A54BR_Demographics_Sex;
         obj12.gxTpr_Br_demographics_marritalstatus = A63BR_Demographics_MarritalStatus;
         obj12.gxTpr_Br_demographics_ethnic = A55BR_Demographics_Ethnic;
         obj12.gxTpr_Br_demographics_education = A56BR_Demographics_Education;
         obj12.gxTpr_Br_demographics_occupation = A57BR_Demographics_Occupation;
         obj12.gxTpr_Br_demographics_insurance = A58BR_Demographics_Insurance;
         obj12.gxTpr_Br_demographics_province = A59BR_Demographics_Province;
         obj12.gxTpr_Br_demographics_city = A60BR_Demographics_City;
         obj12.gxTpr_Br_demographics_id = A61BR_Demographics_ID;
         obj12.gxTpr_Br_demographics_id_Z = Z61BR_Demographics_ID;
         obj12.gxTpr_Br_encounterid_Z = Z19BR_EncounterID;
         obj12.gxTpr_Br_information_patientno_Z = Z36BR_Information_PatientNo;
         obj12.gxTpr_Br_demographics_birthdate_Z = Z53BR_Demographics_BirthDate;
         obj12.gxTpr_Br_demographics_sex_Z = Z54BR_Demographics_Sex;
         obj12.gxTpr_Br_demographics_sex_code_Z = Z455BR_Demographics_Sex_Code;
         obj12.gxTpr_Br_demographics_marritalstatus_Z = Z63BR_Demographics_MarritalStatus;
         obj12.gxTpr_Br_demographics_marritalstatus_code_Z = Z456BR_Demographics_MarritalStatus_Code;
         obj12.gxTpr_Br_demographics_ethnic_Z = Z55BR_Demographics_Ethnic;
         obj12.gxTpr_Br_demographics_ethnic_code_Z = Z457BR_Demographics_Ethnic_Code;
         obj12.gxTpr_Br_demographics_education_Z = Z56BR_Demographics_Education;
         obj12.gxTpr_Br_demographics_education_code_Z = Z458BR_Demographics_Education_Code;
         obj12.gxTpr_Br_demographics_occupation_Z = Z57BR_Demographics_Occupation;
         obj12.gxTpr_Br_demographics_insurance_Z = Z58BR_Demographics_Insurance;
         obj12.gxTpr_Br_demographics_insurance_code_Z = Z459BR_Demographics_Insurance_Code;
         obj12.gxTpr_Br_demographics_province_Z = Z59BR_Demographics_Province;
         obj12.gxTpr_Br_demographics_city_Z = Z60BR_Demographics_City;
         obj12.gxTpr_Br_information_patientno_N = (short)(Convert.ToInt16(n36BR_Information_PatientNo));
         obj12.gxTpr_Br_demographics_birthdate_N = (short)(Convert.ToInt16(n53BR_Demographics_BirthDate));
         obj12.gxTpr_Br_demographics_sex_N = (short)(Convert.ToInt16(n54BR_Demographics_Sex));
         obj12.gxTpr_Br_demographics_sex_code_N = (short)(Convert.ToInt16(n455BR_Demographics_Sex_Code));
         obj12.gxTpr_Br_demographics_marritalstatus_N = (short)(Convert.ToInt16(n63BR_Demographics_MarritalStatus));
         obj12.gxTpr_Br_demographics_marritalstatus_code_N = (short)(Convert.ToInt16(n456BR_Demographics_MarritalStatus_Code));
         obj12.gxTpr_Br_demographics_ethnic_N = (short)(Convert.ToInt16(n55BR_Demographics_Ethnic));
         obj12.gxTpr_Br_demographics_ethnic_code_N = (short)(Convert.ToInt16(n457BR_Demographics_Ethnic_Code));
         obj12.gxTpr_Br_demographics_education_N = (short)(Convert.ToInt16(n56BR_Demographics_Education));
         obj12.gxTpr_Br_demographics_education_code_N = (short)(Convert.ToInt16(n458BR_Demographics_Education_Code));
         obj12.gxTpr_Br_demographics_occupation_N = (short)(Convert.ToInt16(n57BR_Demographics_Occupation));
         obj12.gxTpr_Br_demographics_insurance_N = (short)(Convert.ToInt16(n58BR_Demographics_Insurance));
         obj12.gxTpr_Br_demographics_insurance_code_N = (short)(Convert.ToInt16(n459BR_Demographics_Insurance_Code));
         obj12.gxTpr_Br_demographics_province_N = (short)(Convert.ToInt16(n59BR_Demographics_Province));
         obj12.gxTpr_Br_demographics_city_N = (short)(Convert.ToInt16(n60BR_Demographics_City));
         obj12.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow12( SdtBR_Demographics obj12 )
      {
         obj12.gxTpr_Br_demographics_id = A61BR_Demographics_ID;
         return  ;
      }

      public void RowToVars12( SdtBR_Demographics obj12 ,
                               int forceLoad )
      {
         Gx_mode = obj12.gxTpr_Mode;
         A455BR_Demographics_Sex_Code = obj12.gxTpr_Br_demographics_sex_code;
         n455BR_Demographics_Sex_Code = false;
         A456BR_Demographics_MarritalStatus_Code = obj12.gxTpr_Br_demographics_marritalstatus_code;
         n456BR_Demographics_MarritalStatus_Code = false;
         A457BR_Demographics_Ethnic_Code = obj12.gxTpr_Br_demographics_ethnic_code;
         n457BR_Demographics_Ethnic_Code = false;
         A458BR_Demographics_Education_Code = obj12.gxTpr_Br_demographics_education_code;
         n458BR_Demographics_Education_Code = false;
         A459BR_Demographics_Insurance_Code = obj12.gxTpr_Br_demographics_insurance_code;
         n459BR_Demographics_Insurance_Code = false;
         A19BR_EncounterID = obj12.gxTpr_Br_encounterid;
         A36BR_Information_PatientNo = obj12.gxTpr_Br_information_patientno;
         n36BR_Information_PatientNo = false;
         A53BR_Demographics_BirthDate = obj12.gxTpr_Br_demographics_birthdate;
         n53BR_Demographics_BirthDate = false;
         A54BR_Demographics_Sex = obj12.gxTpr_Br_demographics_sex;
         n54BR_Demographics_Sex = false;
         A63BR_Demographics_MarritalStatus = obj12.gxTpr_Br_demographics_marritalstatus;
         n63BR_Demographics_MarritalStatus = false;
         A55BR_Demographics_Ethnic = obj12.gxTpr_Br_demographics_ethnic;
         n55BR_Demographics_Ethnic = false;
         A56BR_Demographics_Education = obj12.gxTpr_Br_demographics_education;
         n56BR_Demographics_Education = false;
         A57BR_Demographics_Occupation = obj12.gxTpr_Br_demographics_occupation;
         n57BR_Demographics_Occupation = false;
         A58BR_Demographics_Insurance = obj12.gxTpr_Br_demographics_insurance;
         n58BR_Demographics_Insurance = false;
         A59BR_Demographics_Province = obj12.gxTpr_Br_demographics_province;
         n59BR_Demographics_Province = false;
         A60BR_Demographics_City = obj12.gxTpr_Br_demographics_city;
         n60BR_Demographics_City = false;
         A61BR_Demographics_ID = obj12.gxTpr_Br_demographics_id;
         Z61BR_Demographics_ID = obj12.gxTpr_Br_demographics_id_Z;
         Z19BR_EncounterID = obj12.gxTpr_Br_encounterid_Z;
         Z36BR_Information_PatientNo = obj12.gxTpr_Br_information_patientno_Z;
         Z53BR_Demographics_BirthDate = obj12.gxTpr_Br_demographics_birthdate_Z;
         Z54BR_Demographics_Sex = obj12.gxTpr_Br_demographics_sex_Z;
         Z455BR_Demographics_Sex_Code = obj12.gxTpr_Br_demographics_sex_code_Z;
         Z63BR_Demographics_MarritalStatus = obj12.gxTpr_Br_demographics_marritalstatus_Z;
         Z456BR_Demographics_MarritalStatus_Code = obj12.gxTpr_Br_demographics_marritalstatus_code_Z;
         Z55BR_Demographics_Ethnic = obj12.gxTpr_Br_demographics_ethnic_Z;
         Z457BR_Demographics_Ethnic_Code = obj12.gxTpr_Br_demographics_ethnic_code_Z;
         Z56BR_Demographics_Education = obj12.gxTpr_Br_demographics_education_Z;
         Z458BR_Demographics_Education_Code = obj12.gxTpr_Br_demographics_education_code_Z;
         Z57BR_Demographics_Occupation = obj12.gxTpr_Br_demographics_occupation_Z;
         Z58BR_Demographics_Insurance = obj12.gxTpr_Br_demographics_insurance_Z;
         Z459BR_Demographics_Insurance_Code = obj12.gxTpr_Br_demographics_insurance_code_Z;
         Z59BR_Demographics_Province = obj12.gxTpr_Br_demographics_province_Z;
         Z60BR_Demographics_City = obj12.gxTpr_Br_demographics_city_Z;
         n36BR_Information_PatientNo = (bool)(Convert.ToBoolean(obj12.gxTpr_Br_information_patientno_N));
         n53BR_Demographics_BirthDate = (bool)(Convert.ToBoolean(obj12.gxTpr_Br_demographics_birthdate_N));
         n54BR_Demographics_Sex = (bool)(Convert.ToBoolean(obj12.gxTpr_Br_demographics_sex_N));
         n455BR_Demographics_Sex_Code = (bool)(Convert.ToBoolean(obj12.gxTpr_Br_demographics_sex_code_N));
         n63BR_Demographics_MarritalStatus = (bool)(Convert.ToBoolean(obj12.gxTpr_Br_demographics_marritalstatus_N));
         n456BR_Demographics_MarritalStatus_Code = (bool)(Convert.ToBoolean(obj12.gxTpr_Br_demographics_marritalstatus_code_N));
         n55BR_Demographics_Ethnic = (bool)(Convert.ToBoolean(obj12.gxTpr_Br_demographics_ethnic_N));
         n457BR_Demographics_Ethnic_Code = (bool)(Convert.ToBoolean(obj12.gxTpr_Br_demographics_ethnic_code_N));
         n56BR_Demographics_Education = (bool)(Convert.ToBoolean(obj12.gxTpr_Br_demographics_education_N));
         n458BR_Demographics_Education_Code = (bool)(Convert.ToBoolean(obj12.gxTpr_Br_demographics_education_code_N));
         n57BR_Demographics_Occupation = (bool)(Convert.ToBoolean(obj12.gxTpr_Br_demographics_occupation_N));
         n58BR_Demographics_Insurance = (bool)(Convert.ToBoolean(obj12.gxTpr_Br_demographics_insurance_N));
         n459BR_Demographics_Insurance_Code = (bool)(Convert.ToBoolean(obj12.gxTpr_Br_demographics_insurance_code_N));
         n59BR_Demographics_Province = (bool)(Convert.ToBoolean(obj12.gxTpr_Br_demographics_province_N));
         n60BR_Demographics_City = (bool)(Convert.ToBoolean(obj12.gxTpr_Br_demographics_city_N));
         Gx_mode = obj12.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A61BR_Demographics_ID = (long)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey0B12( ) ;
         ScanKeyStart0B12( ) ;
         if ( RcdFound12 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z61BR_Demographics_ID = A61BR_Demographics_ID;
         }
         ZM0B12( -15) ;
         OnLoadActions0B12( ) ;
         AddRow0B12( ) ;
         ScanKeyEnd0B12( ) ;
         if ( RcdFound12 == 0 )
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
         RowToVars12( bcBR_Demographics, 0) ;
         ScanKeyStart0B12( ) ;
         if ( RcdFound12 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z61BR_Demographics_ID = A61BR_Demographics_ID;
         }
         ZM0B12( -15) ;
         OnLoadActions0B12( ) ;
         AddRow0B12( ) ;
         ScanKeyEnd0B12( ) ;
         if ( RcdFound12 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey0B12( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert0B12( ) ;
         }
         else
         {
            if ( RcdFound12 == 1 )
            {
               if ( A61BR_Demographics_ID != Z61BR_Demographics_ID )
               {
                  A61BR_Demographics_ID = Z61BR_Demographics_ID;
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
                  Update0B12( ) ;
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
                  if ( A61BR_Demographics_ID != Z61BR_Demographics_ID )
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
                        Insert0B12( ) ;
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
                        Insert0B12( ) ;
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
         RowToVars12( bcBR_Demographics, 0) ;
         SaveImpl( ) ;
         VarsToRow12( bcBR_Demographics) ;
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
         RowToVars12( bcBR_Demographics, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert0B12( ) ;
         AfterTrn( ) ;
         VarsToRow12( bcBR_Demographics) ;
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
            SdtBR_Demographics auxBC = new SdtBR_Demographics(context) ;
            auxBC.Load(A61BR_Demographics_ID);
            auxBC.UpdateDirties(bcBR_Demographics);
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
         RowToVars12( bcBR_Demographics, 0) ;
         UpdateImpl( ) ;
         VarsToRow12( bcBR_Demographics) ;
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
         RowToVars12( bcBR_Demographics, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert0B12( ) ;
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
         VarsToRow12( bcBR_Demographics) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars12( bcBR_Demographics, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey0B12( ) ;
         if ( RcdFound12 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A61BR_Demographics_ID != Z61BR_Demographics_ID )
            {
               A61BR_Demographics_ID = Z61BR_Demographics_ID;
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
            if ( A61BR_Demographics_ID != Z61BR_Demographics_ID )
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
         context.RollbackDataStores("br_demographics_bc",pr_default);
         VarsToRow12( bcBR_Demographics) ;
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
         Gx_mode = bcBR_Demographics.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcBR_Demographics.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcBR_Demographics )
         {
            bcBR_Demographics = (SdtBR_Demographics)(sdt);
            if ( StringUtil.StrCmp(bcBR_Demographics.gxTpr_Mode, "") == 0 )
            {
               bcBR_Demographics.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow12( bcBR_Demographics) ;
            }
            else
            {
               RowToVars12( bcBR_Demographics, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcBR_Demographics.gxTpr_Mode, "") == 0 )
            {
               bcBR_Demographics.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars12( bcBR_Demographics, 1) ;
         return  ;
      }

      public SdtBR_Demographics BR_Demographics_BC
      {
         get {
            return bcBR_Demographics ;
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
         Z455BR_Demographics_Sex_Code = "";
         A455BR_Demographics_Sex_Code = "";
         Z456BR_Demographics_MarritalStatus_Code = "";
         A456BR_Demographics_MarritalStatus_Code = "";
         Z457BR_Demographics_Ethnic_Code = "";
         A457BR_Demographics_Ethnic_Code = "";
         Z458BR_Demographics_Education_Code = "";
         A458BR_Demographics_Education_Code = "";
         Z459BR_Demographics_Insurance_Code = "";
         A459BR_Demographics_Insurance_Code = "";
         Z53BR_Demographics_BirthDate = DateTime.MinValue;
         A53BR_Demographics_BirthDate = DateTime.MinValue;
         Z54BR_Demographics_Sex = "";
         A54BR_Demographics_Sex = "";
         Z63BR_Demographics_MarritalStatus = "";
         A63BR_Demographics_MarritalStatus = "";
         Z55BR_Demographics_Ethnic = "";
         A55BR_Demographics_Ethnic = "";
         Z56BR_Demographics_Education = "";
         A56BR_Demographics_Education = "";
         Z57BR_Demographics_Occupation = "";
         A57BR_Demographics_Occupation = "";
         Z58BR_Demographics_Insurance = "";
         A58BR_Demographics_Insurance = "";
         Z59BR_Demographics_Province = "";
         A59BR_Demographics_Province = "";
         Z60BR_Demographics_City = "";
         A60BR_Demographics_City = "";
         Z36BR_Information_PatientNo = "";
         A36BR_Information_PatientNo = "";
         BC000B6_A85BR_Information_ID = new long[1] ;
         BC000B6_n85BR_Information_ID = new bool[] {false} ;
         BC000B6_A61BR_Demographics_ID = new long[1] ;
         BC000B6_A455BR_Demographics_Sex_Code = new String[] {""} ;
         BC000B6_n455BR_Demographics_Sex_Code = new bool[] {false} ;
         BC000B6_A456BR_Demographics_MarritalStatus_Code = new String[] {""} ;
         BC000B6_n456BR_Demographics_MarritalStatus_Code = new bool[] {false} ;
         BC000B6_A457BR_Demographics_Ethnic_Code = new String[] {""} ;
         BC000B6_n457BR_Demographics_Ethnic_Code = new bool[] {false} ;
         BC000B6_A458BR_Demographics_Education_Code = new String[] {""} ;
         BC000B6_n458BR_Demographics_Education_Code = new bool[] {false} ;
         BC000B6_A459BR_Demographics_Insurance_Code = new String[] {""} ;
         BC000B6_n459BR_Demographics_Insurance_Code = new bool[] {false} ;
         BC000B6_A36BR_Information_PatientNo = new String[] {""} ;
         BC000B6_n36BR_Information_PatientNo = new bool[] {false} ;
         BC000B6_A53BR_Demographics_BirthDate = new DateTime[] {DateTime.MinValue} ;
         BC000B6_n53BR_Demographics_BirthDate = new bool[] {false} ;
         BC000B6_A54BR_Demographics_Sex = new String[] {""} ;
         BC000B6_n54BR_Demographics_Sex = new bool[] {false} ;
         BC000B6_A63BR_Demographics_MarritalStatus = new String[] {""} ;
         BC000B6_n63BR_Demographics_MarritalStatus = new bool[] {false} ;
         BC000B6_A55BR_Demographics_Ethnic = new String[] {""} ;
         BC000B6_n55BR_Demographics_Ethnic = new bool[] {false} ;
         BC000B6_A56BR_Demographics_Education = new String[] {""} ;
         BC000B6_n56BR_Demographics_Education = new bool[] {false} ;
         BC000B6_A57BR_Demographics_Occupation = new String[] {""} ;
         BC000B6_n57BR_Demographics_Occupation = new bool[] {false} ;
         BC000B6_A58BR_Demographics_Insurance = new String[] {""} ;
         BC000B6_n58BR_Demographics_Insurance = new bool[] {false} ;
         BC000B6_A59BR_Demographics_Province = new String[] {""} ;
         BC000B6_n59BR_Demographics_Province = new bool[] {false} ;
         BC000B6_A60BR_Demographics_City = new String[] {""} ;
         BC000B6_n60BR_Demographics_City = new bool[] {false} ;
         BC000B6_A19BR_EncounterID = new long[1] ;
         BC000B4_A85BR_Information_ID = new long[1] ;
         BC000B4_n85BR_Information_ID = new bool[] {false} ;
         BC000B5_A36BR_Information_PatientNo = new String[] {""} ;
         BC000B5_n36BR_Information_PatientNo = new bool[] {false} ;
         BC000B7_A61BR_Demographics_ID = new long[1] ;
         BC000B3_A61BR_Demographics_ID = new long[1] ;
         BC000B3_A455BR_Demographics_Sex_Code = new String[] {""} ;
         BC000B3_n455BR_Demographics_Sex_Code = new bool[] {false} ;
         BC000B3_A456BR_Demographics_MarritalStatus_Code = new String[] {""} ;
         BC000B3_n456BR_Demographics_MarritalStatus_Code = new bool[] {false} ;
         BC000B3_A457BR_Demographics_Ethnic_Code = new String[] {""} ;
         BC000B3_n457BR_Demographics_Ethnic_Code = new bool[] {false} ;
         BC000B3_A458BR_Demographics_Education_Code = new String[] {""} ;
         BC000B3_n458BR_Demographics_Education_Code = new bool[] {false} ;
         BC000B3_A459BR_Demographics_Insurance_Code = new String[] {""} ;
         BC000B3_n459BR_Demographics_Insurance_Code = new bool[] {false} ;
         BC000B3_A53BR_Demographics_BirthDate = new DateTime[] {DateTime.MinValue} ;
         BC000B3_n53BR_Demographics_BirthDate = new bool[] {false} ;
         BC000B3_A54BR_Demographics_Sex = new String[] {""} ;
         BC000B3_n54BR_Demographics_Sex = new bool[] {false} ;
         BC000B3_A63BR_Demographics_MarritalStatus = new String[] {""} ;
         BC000B3_n63BR_Demographics_MarritalStatus = new bool[] {false} ;
         BC000B3_A55BR_Demographics_Ethnic = new String[] {""} ;
         BC000B3_n55BR_Demographics_Ethnic = new bool[] {false} ;
         BC000B3_A56BR_Demographics_Education = new String[] {""} ;
         BC000B3_n56BR_Demographics_Education = new bool[] {false} ;
         BC000B3_A57BR_Demographics_Occupation = new String[] {""} ;
         BC000B3_n57BR_Demographics_Occupation = new bool[] {false} ;
         BC000B3_A58BR_Demographics_Insurance = new String[] {""} ;
         BC000B3_n58BR_Demographics_Insurance = new bool[] {false} ;
         BC000B3_A59BR_Demographics_Province = new String[] {""} ;
         BC000B3_n59BR_Demographics_Province = new bool[] {false} ;
         BC000B3_A60BR_Demographics_City = new String[] {""} ;
         BC000B3_n60BR_Demographics_City = new bool[] {false} ;
         BC000B3_A19BR_EncounterID = new long[1] ;
         sMode12 = "";
         BC000B2_A61BR_Demographics_ID = new long[1] ;
         BC000B2_A455BR_Demographics_Sex_Code = new String[] {""} ;
         BC000B2_n455BR_Demographics_Sex_Code = new bool[] {false} ;
         BC000B2_A456BR_Demographics_MarritalStatus_Code = new String[] {""} ;
         BC000B2_n456BR_Demographics_MarritalStatus_Code = new bool[] {false} ;
         BC000B2_A457BR_Demographics_Ethnic_Code = new String[] {""} ;
         BC000B2_n457BR_Demographics_Ethnic_Code = new bool[] {false} ;
         BC000B2_A458BR_Demographics_Education_Code = new String[] {""} ;
         BC000B2_n458BR_Demographics_Education_Code = new bool[] {false} ;
         BC000B2_A459BR_Demographics_Insurance_Code = new String[] {""} ;
         BC000B2_n459BR_Demographics_Insurance_Code = new bool[] {false} ;
         BC000B2_A53BR_Demographics_BirthDate = new DateTime[] {DateTime.MinValue} ;
         BC000B2_n53BR_Demographics_BirthDate = new bool[] {false} ;
         BC000B2_A54BR_Demographics_Sex = new String[] {""} ;
         BC000B2_n54BR_Demographics_Sex = new bool[] {false} ;
         BC000B2_A63BR_Demographics_MarritalStatus = new String[] {""} ;
         BC000B2_n63BR_Demographics_MarritalStatus = new bool[] {false} ;
         BC000B2_A55BR_Demographics_Ethnic = new String[] {""} ;
         BC000B2_n55BR_Demographics_Ethnic = new bool[] {false} ;
         BC000B2_A56BR_Demographics_Education = new String[] {""} ;
         BC000B2_n56BR_Demographics_Education = new bool[] {false} ;
         BC000B2_A57BR_Demographics_Occupation = new String[] {""} ;
         BC000B2_n57BR_Demographics_Occupation = new bool[] {false} ;
         BC000B2_A58BR_Demographics_Insurance = new String[] {""} ;
         BC000B2_n58BR_Demographics_Insurance = new bool[] {false} ;
         BC000B2_A59BR_Demographics_Province = new String[] {""} ;
         BC000B2_n59BR_Demographics_Province = new bool[] {false} ;
         BC000B2_A60BR_Demographics_City = new String[] {""} ;
         BC000B2_n60BR_Demographics_City = new bool[] {false} ;
         BC000B2_A19BR_EncounterID = new long[1] ;
         BC000B8_A61BR_Demographics_ID = new long[1] ;
         BC000B11_A85BR_Information_ID = new long[1] ;
         BC000B11_n85BR_Information_ID = new bool[] {false} ;
         BC000B12_A36BR_Information_PatientNo = new String[] {""} ;
         BC000B12_n36BR_Information_PatientNo = new bool[] {false} ;
         BC000B13_A85BR_Information_ID = new long[1] ;
         BC000B13_n85BR_Information_ID = new bool[] {false} ;
         BC000B13_A61BR_Demographics_ID = new long[1] ;
         BC000B13_A455BR_Demographics_Sex_Code = new String[] {""} ;
         BC000B13_n455BR_Demographics_Sex_Code = new bool[] {false} ;
         BC000B13_A456BR_Demographics_MarritalStatus_Code = new String[] {""} ;
         BC000B13_n456BR_Demographics_MarritalStatus_Code = new bool[] {false} ;
         BC000B13_A457BR_Demographics_Ethnic_Code = new String[] {""} ;
         BC000B13_n457BR_Demographics_Ethnic_Code = new bool[] {false} ;
         BC000B13_A458BR_Demographics_Education_Code = new String[] {""} ;
         BC000B13_n458BR_Demographics_Education_Code = new bool[] {false} ;
         BC000B13_A459BR_Demographics_Insurance_Code = new String[] {""} ;
         BC000B13_n459BR_Demographics_Insurance_Code = new bool[] {false} ;
         BC000B13_A36BR_Information_PatientNo = new String[] {""} ;
         BC000B13_n36BR_Information_PatientNo = new bool[] {false} ;
         BC000B13_A53BR_Demographics_BirthDate = new DateTime[] {DateTime.MinValue} ;
         BC000B13_n53BR_Demographics_BirthDate = new bool[] {false} ;
         BC000B13_A54BR_Demographics_Sex = new String[] {""} ;
         BC000B13_n54BR_Demographics_Sex = new bool[] {false} ;
         BC000B13_A63BR_Demographics_MarritalStatus = new String[] {""} ;
         BC000B13_n63BR_Demographics_MarritalStatus = new bool[] {false} ;
         BC000B13_A55BR_Demographics_Ethnic = new String[] {""} ;
         BC000B13_n55BR_Demographics_Ethnic = new bool[] {false} ;
         BC000B13_A56BR_Demographics_Education = new String[] {""} ;
         BC000B13_n56BR_Demographics_Education = new bool[] {false} ;
         BC000B13_A57BR_Demographics_Occupation = new String[] {""} ;
         BC000B13_n57BR_Demographics_Occupation = new bool[] {false} ;
         BC000B13_A58BR_Demographics_Insurance = new String[] {""} ;
         BC000B13_n58BR_Demographics_Insurance = new bool[] {false} ;
         BC000B13_A59BR_Demographics_Province = new String[] {""} ;
         BC000B13_n59BR_Demographics_Province = new bool[] {false} ;
         BC000B13_A60BR_Demographics_City = new String[] {""} ;
         BC000B13_n60BR_Demographics_City = new bool[] {false} ;
         BC000B13_A19BR_EncounterID = new long[1] ;
         GXt_char2 = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_demographics_bc__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_demographics_bc__default(),
            new Object[][] {
                new Object[] {
               BC000B2_A61BR_Demographics_ID, BC000B2_A455BR_Demographics_Sex_Code, BC000B2_n455BR_Demographics_Sex_Code, BC000B2_A456BR_Demographics_MarritalStatus_Code, BC000B2_n456BR_Demographics_MarritalStatus_Code, BC000B2_A457BR_Demographics_Ethnic_Code, BC000B2_n457BR_Demographics_Ethnic_Code, BC000B2_A458BR_Demographics_Education_Code, BC000B2_n458BR_Demographics_Education_Code, BC000B2_A459BR_Demographics_Insurance_Code,
               BC000B2_n459BR_Demographics_Insurance_Code, BC000B2_A53BR_Demographics_BirthDate, BC000B2_n53BR_Demographics_BirthDate, BC000B2_A54BR_Demographics_Sex, BC000B2_n54BR_Demographics_Sex, BC000B2_A63BR_Demographics_MarritalStatus, BC000B2_n63BR_Demographics_MarritalStatus, BC000B2_A55BR_Demographics_Ethnic, BC000B2_n55BR_Demographics_Ethnic, BC000B2_A56BR_Demographics_Education,
               BC000B2_n56BR_Demographics_Education, BC000B2_A57BR_Demographics_Occupation, BC000B2_n57BR_Demographics_Occupation, BC000B2_A58BR_Demographics_Insurance, BC000B2_n58BR_Demographics_Insurance, BC000B2_A59BR_Demographics_Province, BC000B2_n59BR_Demographics_Province, BC000B2_A60BR_Demographics_City, BC000B2_n60BR_Demographics_City, BC000B2_A19BR_EncounterID
               }
               , new Object[] {
               BC000B3_A61BR_Demographics_ID, BC000B3_A455BR_Demographics_Sex_Code, BC000B3_n455BR_Demographics_Sex_Code, BC000B3_A456BR_Demographics_MarritalStatus_Code, BC000B3_n456BR_Demographics_MarritalStatus_Code, BC000B3_A457BR_Demographics_Ethnic_Code, BC000B3_n457BR_Demographics_Ethnic_Code, BC000B3_A458BR_Demographics_Education_Code, BC000B3_n458BR_Demographics_Education_Code, BC000B3_A459BR_Demographics_Insurance_Code,
               BC000B3_n459BR_Demographics_Insurance_Code, BC000B3_A53BR_Demographics_BirthDate, BC000B3_n53BR_Demographics_BirthDate, BC000B3_A54BR_Demographics_Sex, BC000B3_n54BR_Demographics_Sex, BC000B3_A63BR_Demographics_MarritalStatus, BC000B3_n63BR_Demographics_MarritalStatus, BC000B3_A55BR_Demographics_Ethnic, BC000B3_n55BR_Demographics_Ethnic, BC000B3_A56BR_Demographics_Education,
               BC000B3_n56BR_Demographics_Education, BC000B3_A57BR_Demographics_Occupation, BC000B3_n57BR_Demographics_Occupation, BC000B3_A58BR_Demographics_Insurance, BC000B3_n58BR_Demographics_Insurance, BC000B3_A59BR_Demographics_Province, BC000B3_n59BR_Demographics_Province, BC000B3_A60BR_Demographics_City, BC000B3_n60BR_Demographics_City, BC000B3_A19BR_EncounterID
               }
               , new Object[] {
               BC000B4_A85BR_Information_ID, BC000B4_n85BR_Information_ID
               }
               , new Object[] {
               BC000B5_A36BR_Information_PatientNo, BC000B5_n36BR_Information_PatientNo
               }
               , new Object[] {
               BC000B6_A85BR_Information_ID, BC000B6_n85BR_Information_ID, BC000B6_A61BR_Demographics_ID, BC000B6_A455BR_Demographics_Sex_Code, BC000B6_n455BR_Demographics_Sex_Code, BC000B6_A456BR_Demographics_MarritalStatus_Code, BC000B6_n456BR_Demographics_MarritalStatus_Code, BC000B6_A457BR_Demographics_Ethnic_Code, BC000B6_n457BR_Demographics_Ethnic_Code, BC000B6_A458BR_Demographics_Education_Code,
               BC000B6_n458BR_Demographics_Education_Code, BC000B6_A459BR_Demographics_Insurance_Code, BC000B6_n459BR_Demographics_Insurance_Code, BC000B6_A36BR_Information_PatientNo, BC000B6_n36BR_Information_PatientNo, BC000B6_A53BR_Demographics_BirthDate, BC000B6_n53BR_Demographics_BirthDate, BC000B6_A54BR_Demographics_Sex, BC000B6_n54BR_Demographics_Sex, BC000B6_A63BR_Demographics_MarritalStatus,
               BC000B6_n63BR_Demographics_MarritalStatus, BC000B6_A55BR_Demographics_Ethnic, BC000B6_n55BR_Demographics_Ethnic, BC000B6_A56BR_Demographics_Education, BC000B6_n56BR_Demographics_Education, BC000B6_A57BR_Demographics_Occupation, BC000B6_n57BR_Demographics_Occupation, BC000B6_A58BR_Demographics_Insurance, BC000B6_n58BR_Demographics_Insurance, BC000B6_A59BR_Demographics_Province,
               BC000B6_n59BR_Demographics_Province, BC000B6_A60BR_Demographics_City, BC000B6_n60BR_Demographics_City, BC000B6_A19BR_EncounterID
               }
               , new Object[] {
               BC000B7_A61BR_Demographics_ID
               }
               , new Object[] {
               BC000B8_A61BR_Demographics_ID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000B11_A85BR_Information_ID, BC000B11_n85BR_Information_ID
               }
               , new Object[] {
               BC000B12_A36BR_Information_PatientNo, BC000B12_n36BR_Information_PatientNo
               }
               , new Object[] {
               BC000B13_A85BR_Information_ID, BC000B13_n85BR_Information_ID, BC000B13_A61BR_Demographics_ID, BC000B13_A455BR_Demographics_Sex_Code, BC000B13_n455BR_Demographics_Sex_Code, BC000B13_A456BR_Demographics_MarritalStatus_Code, BC000B13_n456BR_Demographics_MarritalStatus_Code, BC000B13_A457BR_Demographics_Ethnic_Code, BC000B13_n457BR_Demographics_Ethnic_Code, BC000B13_A458BR_Demographics_Education_Code,
               BC000B13_n458BR_Demographics_Education_Code, BC000B13_A459BR_Demographics_Insurance_Code, BC000B13_n459BR_Demographics_Insurance_Code, BC000B13_A36BR_Information_PatientNo, BC000B13_n36BR_Information_PatientNo, BC000B13_A53BR_Demographics_BirthDate, BC000B13_n53BR_Demographics_BirthDate, BC000B13_A54BR_Demographics_Sex, BC000B13_n54BR_Demographics_Sex, BC000B13_A63BR_Demographics_MarritalStatus,
               BC000B13_n63BR_Demographics_MarritalStatus, BC000B13_A55BR_Demographics_Ethnic, BC000B13_n55BR_Demographics_Ethnic, BC000B13_A56BR_Demographics_Education, BC000B13_n56BR_Demographics_Education, BC000B13_A57BR_Demographics_Occupation, BC000B13_n57BR_Demographics_Occupation, BC000B13_A58BR_Demographics_Insurance, BC000B13_n58BR_Demographics_Insurance, BC000B13_A59BR_Demographics_Province,
               BC000B13_n59BR_Demographics_Province, BC000B13_A60BR_Demographics_City, BC000B13_n60BR_Demographics_City, BC000B13_A19BR_EncounterID
               }
            }
         );
         AV16Pgmname = "BR_Demographics_BC";
         INITTRN();
         /* Execute Start event if defined. */
         /* Execute user event: Start */
         E120B2 ();
         standaloneNotModal( ) ;
      }

      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short GX_JID ;
      private short RcdFound12 ;
      private int trnEnded ;
      private int AV17GXV1 ;
      private long Z61BR_Demographics_ID ;
      private long A61BR_Demographics_ID ;
      private long AV10Insert_BR_EncounterID ;
      private long Z19BR_EncounterID ;
      private long A19BR_EncounterID ;
      private long Z85BR_Information_ID ;
      private long A85BR_Information_ID ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String AV16Pgmname ;
      private String sMode12 ;
      private String GXt_char2 ;
      private DateTime Z53BR_Demographics_BirthDate ;
      private DateTime A53BR_Demographics_BirthDate ;
      private bool AV13IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool n85BR_Information_ID ;
      private bool n455BR_Demographics_Sex_Code ;
      private bool n456BR_Demographics_MarritalStatus_Code ;
      private bool n457BR_Demographics_Ethnic_Code ;
      private bool n458BR_Demographics_Education_Code ;
      private bool n459BR_Demographics_Insurance_Code ;
      private bool n36BR_Information_PatientNo ;
      private bool n53BR_Demographics_BirthDate ;
      private bool n54BR_Demographics_Sex ;
      private bool n63BR_Demographics_MarritalStatus ;
      private bool n55BR_Demographics_Ethnic ;
      private bool n56BR_Demographics_Education ;
      private bool n57BR_Demographics_Occupation ;
      private bool n58BR_Demographics_Insurance ;
      private bool n59BR_Demographics_Province ;
      private bool n60BR_Demographics_City ;
      private bool Gx_longc ;
      private String Z455BR_Demographics_Sex_Code ;
      private String A455BR_Demographics_Sex_Code ;
      private String Z456BR_Demographics_MarritalStatus_Code ;
      private String A456BR_Demographics_MarritalStatus_Code ;
      private String Z457BR_Demographics_Ethnic_Code ;
      private String A457BR_Demographics_Ethnic_Code ;
      private String Z458BR_Demographics_Education_Code ;
      private String A458BR_Demographics_Education_Code ;
      private String Z459BR_Demographics_Insurance_Code ;
      private String A459BR_Demographics_Insurance_Code ;
      private String Z54BR_Demographics_Sex ;
      private String A54BR_Demographics_Sex ;
      private String Z63BR_Demographics_MarritalStatus ;
      private String A63BR_Demographics_MarritalStatus ;
      private String Z55BR_Demographics_Ethnic ;
      private String A55BR_Demographics_Ethnic ;
      private String Z56BR_Demographics_Education ;
      private String A56BR_Demographics_Education ;
      private String Z57BR_Demographics_Occupation ;
      private String A57BR_Demographics_Occupation ;
      private String Z58BR_Demographics_Insurance ;
      private String A58BR_Demographics_Insurance ;
      private String Z59BR_Demographics_Province ;
      private String A59BR_Demographics_Province ;
      private String Z60BR_Demographics_City ;
      private String A60BR_Demographics_City ;
      private String Z36BR_Information_PatientNo ;
      private String A36BR_Information_PatientNo ;
      private IGxSession AV9WebSession ;
      private SdtBR_Demographics bcBR_Demographics ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] BC000B6_A85BR_Information_ID ;
      private bool[] BC000B6_n85BR_Information_ID ;
      private long[] BC000B6_A61BR_Demographics_ID ;
      private String[] BC000B6_A455BR_Demographics_Sex_Code ;
      private bool[] BC000B6_n455BR_Demographics_Sex_Code ;
      private String[] BC000B6_A456BR_Demographics_MarritalStatus_Code ;
      private bool[] BC000B6_n456BR_Demographics_MarritalStatus_Code ;
      private String[] BC000B6_A457BR_Demographics_Ethnic_Code ;
      private bool[] BC000B6_n457BR_Demographics_Ethnic_Code ;
      private String[] BC000B6_A458BR_Demographics_Education_Code ;
      private bool[] BC000B6_n458BR_Demographics_Education_Code ;
      private String[] BC000B6_A459BR_Demographics_Insurance_Code ;
      private bool[] BC000B6_n459BR_Demographics_Insurance_Code ;
      private String[] BC000B6_A36BR_Information_PatientNo ;
      private bool[] BC000B6_n36BR_Information_PatientNo ;
      private DateTime[] BC000B6_A53BR_Demographics_BirthDate ;
      private bool[] BC000B6_n53BR_Demographics_BirthDate ;
      private String[] BC000B6_A54BR_Demographics_Sex ;
      private bool[] BC000B6_n54BR_Demographics_Sex ;
      private String[] BC000B6_A63BR_Demographics_MarritalStatus ;
      private bool[] BC000B6_n63BR_Demographics_MarritalStatus ;
      private String[] BC000B6_A55BR_Demographics_Ethnic ;
      private bool[] BC000B6_n55BR_Demographics_Ethnic ;
      private String[] BC000B6_A56BR_Demographics_Education ;
      private bool[] BC000B6_n56BR_Demographics_Education ;
      private String[] BC000B6_A57BR_Demographics_Occupation ;
      private bool[] BC000B6_n57BR_Demographics_Occupation ;
      private String[] BC000B6_A58BR_Demographics_Insurance ;
      private bool[] BC000B6_n58BR_Demographics_Insurance ;
      private String[] BC000B6_A59BR_Demographics_Province ;
      private bool[] BC000B6_n59BR_Demographics_Province ;
      private String[] BC000B6_A60BR_Demographics_City ;
      private bool[] BC000B6_n60BR_Demographics_City ;
      private long[] BC000B6_A19BR_EncounterID ;
      private long[] BC000B4_A85BR_Information_ID ;
      private bool[] BC000B4_n85BR_Information_ID ;
      private String[] BC000B5_A36BR_Information_PatientNo ;
      private bool[] BC000B5_n36BR_Information_PatientNo ;
      private long[] BC000B7_A61BR_Demographics_ID ;
      private long[] BC000B3_A61BR_Demographics_ID ;
      private String[] BC000B3_A455BR_Demographics_Sex_Code ;
      private bool[] BC000B3_n455BR_Demographics_Sex_Code ;
      private String[] BC000B3_A456BR_Demographics_MarritalStatus_Code ;
      private bool[] BC000B3_n456BR_Demographics_MarritalStatus_Code ;
      private String[] BC000B3_A457BR_Demographics_Ethnic_Code ;
      private bool[] BC000B3_n457BR_Demographics_Ethnic_Code ;
      private String[] BC000B3_A458BR_Demographics_Education_Code ;
      private bool[] BC000B3_n458BR_Demographics_Education_Code ;
      private String[] BC000B3_A459BR_Demographics_Insurance_Code ;
      private bool[] BC000B3_n459BR_Demographics_Insurance_Code ;
      private DateTime[] BC000B3_A53BR_Demographics_BirthDate ;
      private bool[] BC000B3_n53BR_Demographics_BirthDate ;
      private String[] BC000B3_A54BR_Demographics_Sex ;
      private bool[] BC000B3_n54BR_Demographics_Sex ;
      private String[] BC000B3_A63BR_Demographics_MarritalStatus ;
      private bool[] BC000B3_n63BR_Demographics_MarritalStatus ;
      private String[] BC000B3_A55BR_Demographics_Ethnic ;
      private bool[] BC000B3_n55BR_Demographics_Ethnic ;
      private String[] BC000B3_A56BR_Demographics_Education ;
      private bool[] BC000B3_n56BR_Demographics_Education ;
      private String[] BC000B3_A57BR_Demographics_Occupation ;
      private bool[] BC000B3_n57BR_Demographics_Occupation ;
      private String[] BC000B3_A58BR_Demographics_Insurance ;
      private bool[] BC000B3_n58BR_Demographics_Insurance ;
      private String[] BC000B3_A59BR_Demographics_Province ;
      private bool[] BC000B3_n59BR_Demographics_Province ;
      private String[] BC000B3_A60BR_Demographics_City ;
      private bool[] BC000B3_n60BR_Demographics_City ;
      private long[] BC000B3_A19BR_EncounterID ;
      private long[] BC000B2_A61BR_Demographics_ID ;
      private String[] BC000B2_A455BR_Demographics_Sex_Code ;
      private bool[] BC000B2_n455BR_Demographics_Sex_Code ;
      private String[] BC000B2_A456BR_Demographics_MarritalStatus_Code ;
      private bool[] BC000B2_n456BR_Demographics_MarritalStatus_Code ;
      private String[] BC000B2_A457BR_Demographics_Ethnic_Code ;
      private bool[] BC000B2_n457BR_Demographics_Ethnic_Code ;
      private String[] BC000B2_A458BR_Demographics_Education_Code ;
      private bool[] BC000B2_n458BR_Demographics_Education_Code ;
      private String[] BC000B2_A459BR_Demographics_Insurance_Code ;
      private bool[] BC000B2_n459BR_Demographics_Insurance_Code ;
      private DateTime[] BC000B2_A53BR_Demographics_BirthDate ;
      private bool[] BC000B2_n53BR_Demographics_BirthDate ;
      private String[] BC000B2_A54BR_Demographics_Sex ;
      private bool[] BC000B2_n54BR_Demographics_Sex ;
      private String[] BC000B2_A63BR_Demographics_MarritalStatus ;
      private bool[] BC000B2_n63BR_Demographics_MarritalStatus ;
      private String[] BC000B2_A55BR_Demographics_Ethnic ;
      private bool[] BC000B2_n55BR_Demographics_Ethnic ;
      private String[] BC000B2_A56BR_Demographics_Education ;
      private bool[] BC000B2_n56BR_Demographics_Education ;
      private String[] BC000B2_A57BR_Demographics_Occupation ;
      private bool[] BC000B2_n57BR_Demographics_Occupation ;
      private String[] BC000B2_A58BR_Demographics_Insurance ;
      private bool[] BC000B2_n58BR_Demographics_Insurance ;
      private String[] BC000B2_A59BR_Demographics_Province ;
      private bool[] BC000B2_n59BR_Demographics_Province ;
      private String[] BC000B2_A60BR_Demographics_City ;
      private bool[] BC000B2_n60BR_Demographics_City ;
      private long[] BC000B2_A19BR_EncounterID ;
      private long[] BC000B8_A61BR_Demographics_ID ;
      private long[] BC000B11_A85BR_Information_ID ;
      private bool[] BC000B11_n85BR_Information_ID ;
      private String[] BC000B12_A36BR_Information_PatientNo ;
      private bool[] BC000B12_n36BR_Information_PatientNo ;
      private long[] BC000B13_A85BR_Information_ID ;
      private bool[] BC000B13_n85BR_Information_ID ;
      private long[] BC000B13_A61BR_Demographics_ID ;
      private String[] BC000B13_A455BR_Demographics_Sex_Code ;
      private bool[] BC000B13_n455BR_Demographics_Sex_Code ;
      private String[] BC000B13_A456BR_Demographics_MarritalStatus_Code ;
      private bool[] BC000B13_n456BR_Demographics_MarritalStatus_Code ;
      private String[] BC000B13_A457BR_Demographics_Ethnic_Code ;
      private bool[] BC000B13_n457BR_Demographics_Ethnic_Code ;
      private String[] BC000B13_A458BR_Demographics_Education_Code ;
      private bool[] BC000B13_n458BR_Demographics_Education_Code ;
      private String[] BC000B13_A459BR_Demographics_Insurance_Code ;
      private bool[] BC000B13_n459BR_Demographics_Insurance_Code ;
      private String[] BC000B13_A36BR_Information_PatientNo ;
      private bool[] BC000B13_n36BR_Information_PatientNo ;
      private DateTime[] BC000B13_A53BR_Demographics_BirthDate ;
      private bool[] BC000B13_n53BR_Demographics_BirthDate ;
      private String[] BC000B13_A54BR_Demographics_Sex ;
      private bool[] BC000B13_n54BR_Demographics_Sex ;
      private String[] BC000B13_A63BR_Demographics_MarritalStatus ;
      private bool[] BC000B13_n63BR_Demographics_MarritalStatus ;
      private String[] BC000B13_A55BR_Demographics_Ethnic ;
      private bool[] BC000B13_n55BR_Demographics_Ethnic ;
      private String[] BC000B13_A56BR_Demographics_Education ;
      private bool[] BC000B13_n56BR_Demographics_Education ;
      private String[] BC000B13_A57BR_Demographics_Occupation ;
      private bool[] BC000B13_n57BR_Demographics_Occupation ;
      private String[] BC000B13_A58BR_Demographics_Insurance ;
      private bool[] BC000B13_n58BR_Demographics_Insurance ;
      private String[] BC000B13_A59BR_Demographics_Province ;
      private bool[] BC000B13_n59BR_Demographics_Province ;
      private String[] BC000B13_A60BR_Demographics_City ;
      private bool[] BC000B13_n60BR_Demographics_City ;
      private long[] BC000B13_A19BR_EncounterID ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_datastore1 ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV8TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV11TrnContextAtt ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV7WWPContext ;
   }

   public class br_demographics_bc__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class br_demographics_bc__default : DataStoreHelperBase, IDataStoreHelper
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
        Object[] prmBC000B6 ;
        prmBC000B6 = new Object[] {
        new Object[] {"@BR_Demographics_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000B4 ;
        prmBC000B4 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000B5 ;
        prmBC000B5 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000B7 ;
        prmBC000B7 = new Object[] {
        new Object[] {"@BR_Demographics_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000B3 ;
        prmBC000B3 = new Object[] {
        new Object[] {"@BR_Demographics_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000B2 ;
        prmBC000B2 = new Object[] {
        new Object[] {"@BR_Demographics_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000B8 ;
        prmBC000B8 = new Object[] {
        new Object[] {"@BR_Demographics_Sex_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Demographics_MarritalStatus_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Demographics_Ethnic_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Demographics_Education_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Demographics_Insurance_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Demographics_BirthDate",SqlDbType.DateTime,8,0} ,
        new Object[] {"@BR_Demographics_Sex",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Demographics_MarritalStatus",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Demographics_Ethnic",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Demographics_Education",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Demographics_Occupation",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Demographics_Insurance",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Demographics_Province",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Demographics_City",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000B9 ;
        prmBC000B9 = new Object[] {
        new Object[] {"@BR_Demographics_Sex_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Demographics_MarritalStatus_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Demographics_Ethnic_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Demographics_Education_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Demographics_Insurance_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Demographics_BirthDate",SqlDbType.DateTime,8,0} ,
        new Object[] {"@BR_Demographics_Sex",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Demographics_MarritalStatus",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Demographics_Ethnic",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Demographics_Education",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Demographics_Occupation",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Demographics_Insurance",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Demographics_Province",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Demographics_City",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_Demographics_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000B10 ;
        prmBC000B10 = new Object[] {
        new Object[] {"@BR_Demographics_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000B11 ;
        prmBC000B11 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000B12 ;
        prmBC000B12 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000B13 ;
        prmBC000B13 = new Object[] {
        new Object[] {"@BR_Demographics_ID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("BC000B2", "SELECT [BR_Demographics_ID], [BR_Demographics_Sex_Code], [BR_Demographics_MarritalStatus_Code], [BR_Demographics_Ethnic_Code], [BR_Demographics_Education_Code], [BR_Demographics_Insurance_Code], [BR_Demographics_BirthDate], [BR_Demographics_Sex], [BR_Demographics_MarritalStatus], [BR_Demographics_Ethnic], [BR_Demographics_Education], [BR_Demographics_Occupation], [BR_Demographics_Insurance], [BR_Demographics_Province], [BR_Demographics_City], [BR_EncounterID] FROM [BR_Demographics] WITH (UPDLOCK) WHERE [BR_Demographics_ID] = @BR_Demographics_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000B2,1,0,true,false )
           ,new CursorDef("BC000B3", "SELECT [BR_Demographics_ID], [BR_Demographics_Sex_Code], [BR_Demographics_MarritalStatus_Code], [BR_Demographics_Ethnic_Code], [BR_Demographics_Education_Code], [BR_Demographics_Insurance_Code], [BR_Demographics_BirthDate], [BR_Demographics_Sex], [BR_Demographics_MarritalStatus], [BR_Demographics_Ethnic], [BR_Demographics_Education], [BR_Demographics_Occupation], [BR_Demographics_Insurance], [BR_Demographics_Province], [BR_Demographics_City], [BR_EncounterID] FROM [BR_Demographics] WITH (NOLOCK) WHERE [BR_Demographics_ID] = @BR_Demographics_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000B3,1,0,true,false )
           ,new CursorDef("BC000B4", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000B4,1,0,true,false )
           ,new CursorDef("BC000B5", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000B5,1,0,true,false )
           ,new CursorDef("BC000B6", "SELECT T2.[BR_Information_ID], TM1.[BR_Demographics_ID], TM1.[BR_Demographics_Sex_Code], TM1.[BR_Demographics_MarritalStatus_Code], TM1.[BR_Demographics_Ethnic_Code], TM1.[BR_Demographics_Education_Code], TM1.[BR_Demographics_Insurance_Code], T3.[BR_Information_PatientNo], TM1.[BR_Demographics_BirthDate], TM1.[BR_Demographics_Sex], TM1.[BR_Demographics_MarritalStatus], TM1.[BR_Demographics_Ethnic], TM1.[BR_Demographics_Education], TM1.[BR_Demographics_Occupation], TM1.[BR_Demographics_Insurance], TM1.[BR_Demographics_Province], TM1.[BR_Demographics_City], TM1.[BR_EncounterID] FROM (([BR_Demographics] TM1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = TM1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID]) WHERE TM1.[BR_Demographics_ID] = @BR_Demographics_ID ORDER BY TM1.[BR_Demographics_ID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000B6,100,0,true,false )
           ,new CursorDef("BC000B7", "SELECT [BR_Demographics_ID] FROM [BR_Demographics] WITH (NOLOCK) WHERE [BR_Demographics_ID] = @BR_Demographics_ID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000B7,1,0,true,false )
           ,new CursorDef("BC000B8", "INSERT INTO [BR_Demographics]([BR_Demographics_Sex_Code], [BR_Demographics_MarritalStatus_Code], [BR_Demographics_Ethnic_Code], [BR_Demographics_Education_Code], [BR_Demographics_Insurance_Code], [BR_Demographics_BirthDate], [BR_Demographics_Sex], [BR_Demographics_MarritalStatus], [BR_Demographics_Ethnic], [BR_Demographics_Education], [BR_Demographics_Occupation], [BR_Demographics_Insurance], [BR_Demographics_Province], [BR_Demographics_City], [BR_EncounterID]) VALUES(@BR_Demographics_Sex_Code, @BR_Demographics_MarritalStatus_Code, @BR_Demographics_Ethnic_Code, @BR_Demographics_Education_Code, @BR_Demographics_Insurance_Code, @BR_Demographics_BirthDate, @BR_Demographics_Sex, @BR_Demographics_MarritalStatus, @BR_Demographics_Ethnic, @BR_Demographics_Education, @BR_Demographics_Occupation, @BR_Demographics_Insurance, @BR_Demographics_Province, @BR_Demographics_City, @BR_EncounterID); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmBC000B8)
           ,new CursorDef("BC000B9", "UPDATE [BR_Demographics] SET [BR_Demographics_Sex_Code]=@BR_Demographics_Sex_Code, [BR_Demographics_MarritalStatus_Code]=@BR_Demographics_MarritalStatus_Code, [BR_Demographics_Ethnic_Code]=@BR_Demographics_Ethnic_Code, [BR_Demographics_Education_Code]=@BR_Demographics_Education_Code, [BR_Demographics_Insurance_Code]=@BR_Demographics_Insurance_Code, [BR_Demographics_BirthDate]=@BR_Demographics_BirthDate, [BR_Demographics_Sex]=@BR_Demographics_Sex, [BR_Demographics_MarritalStatus]=@BR_Demographics_MarritalStatus, [BR_Demographics_Ethnic]=@BR_Demographics_Ethnic, [BR_Demographics_Education]=@BR_Demographics_Education, [BR_Demographics_Occupation]=@BR_Demographics_Occupation, [BR_Demographics_Insurance]=@BR_Demographics_Insurance, [BR_Demographics_Province]=@BR_Demographics_Province, [BR_Demographics_City]=@BR_Demographics_City, [BR_EncounterID]=@BR_EncounterID  WHERE [BR_Demographics_ID] = @BR_Demographics_ID", GxErrorMask.GX_NOMASK,prmBC000B9)
           ,new CursorDef("BC000B10", "DELETE FROM [BR_Demographics]  WHERE [BR_Demographics_ID] = @BR_Demographics_ID", GxErrorMask.GX_NOMASK,prmBC000B10)
           ,new CursorDef("BC000B11", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000B11,1,0,true,false )
           ,new CursorDef("BC000B12", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000B12,1,0,true,false )
           ,new CursorDef("BC000B13", "SELECT T2.[BR_Information_ID], TM1.[BR_Demographics_ID], TM1.[BR_Demographics_Sex_Code], TM1.[BR_Demographics_MarritalStatus_Code], TM1.[BR_Demographics_Ethnic_Code], TM1.[BR_Demographics_Education_Code], TM1.[BR_Demographics_Insurance_Code], T3.[BR_Information_PatientNo], TM1.[BR_Demographics_BirthDate], TM1.[BR_Demographics_Sex], TM1.[BR_Demographics_MarritalStatus], TM1.[BR_Demographics_Ethnic], TM1.[BR_Demographics_Education], TM1.[BR_Demographics_Occupation], TM1.[BR_Demographics_Insurance], TM1.[BR_Demographics_Province], TM1.[BR_Demographics_City], TM1.[BR_EncounterID] FROM (([BR_Demographics] TM1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = TM1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID]) WHERE TM1.[BR_Demographics_ID] = @BR_Demographics_ID ORDER BY TM1.[BR_Demographics_ID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000B13,100,0,true,false )
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
              ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((DateTime[]) buf[11])[0] = rslt.getGXDate(7) ;
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
              ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((DateTime[]) buf[11])[0] = rslt.getGXDate(7) ;
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
              ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((DateTime[]) buf[15])[0] = rslt.getGXDate(9) ;
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
              ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((DateTime[]) buf[15])[0] = rslt.getGXDate(9) ;
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
