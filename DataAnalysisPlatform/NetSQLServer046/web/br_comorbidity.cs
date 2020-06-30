/*
               File: BR_Comorbidity
        Description: 既往病史
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 13:20:12.52
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
   public class br_comorbidity : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      protected void INITENV( )
      {
         if ( GxWebError != 0 )
         {
            return  ;
         }
      }

      protected void INITTRN( )
      {
         initialize_properties( ) ;
         entryPointCalled = false;
         gxfirstwebparm = GetNextPar( );
         gxfirstwebparm_bkp = gxfirstwebparm;
         gxfirstwebparm = DecryptAjaxCall( gxfirstwebparm);
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         if ( StringUtil.StrCmp(gxfirstwebparm, "dyncall") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            dyncall( GetNextPar( )) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel11"+"_"+"BR_COMORBIDITY_HYPERTENSION_CODE") == 0 )
         {
            A38BR_Comorbidity_Hypertension = GetNextPar( );
            n38BR_Comorbidity_Hypertension = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38BR_Comorbidity_Hypertension", A38BR_Comorbidity_Hypertension);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX11ASABR_COMORBIDITY_HYPERTENSION_CODE0910( A38BR_Comorbidity_Hypertension) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel12"+"_"+"BR_COMORBIDITY_HYPERTENSION_CODE") == 0 )
         {
            A38BR_Comorbidity_Hypertension = GetNextPar( );
            n38BR_Comorbidity_Hypertension = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38BR_Comorbidity_Hypertension", A38BR_Comorbidity_Hypertension);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX12ASABR_COMORBIDITY_HYPERTENSION_CODE0910( A38BR_Comorbidity_Hypertension) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel13"+"_"+"BR_COMORBIDITY_DIABETES_CODE") == 0 )
         {
            A39BR_Comorbidity_Diabetes = GetNextPar( );
            n39BR_Comorbidity_Diabetes = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39BR_Comorbidity_Diabetes", A39BR_Comorbidity_Diabetes);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX13ASABR_COMORBIDITY_DIABETES_CODE0910( A39BR_Comorbidity_Diabetes) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel14"+"_"+"BR_COMORBIDITY_DIABETES_CODE") == 0 )
         {
            A39BR_Comorbidity_Diabetes = GetNextPar( );
            n39BR_Comorbidity_Diabetes = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39BR_Comorbidity_Diabetes", A39BR_Comorbidity_Diabetes);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX14ASABR_COMORBIDITY_DIABETES_CODE0910( A39BR_Comorbidity_Diabetes) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel15"+"_"+"BR_COMORBIDITY_CHD_CODE") == 0 )
         {
            A40BR_Comorbidity_CHD = GetNextPar( );
            n40BR_Comorbidity_CHD = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40BR_Comorbidity_CHD", A40BR_Comorbidity_CHD);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX15ASABR_COMORBIDITY_CHD_CODE0910( A40BR_Comorbidity_CHD) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel16"+"_"+"BR_COMORBIDITY_CHD_CODE") == 0 )
         {
            A40BR_Comorbidity_CHD = GetNextPar( );
            n40BR_Comorbidity_CHD = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40BR_Comorbidity_CHD", A40BR_Comorbidity_CHD);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX16ASABR_COMORBIDITY_CHD_CODE0910( A40BR_Comorbidity_CHD) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel17"+"_"+"BR_COMORBIDITY_HAPETITIS_CODE") == 0 )
         {
            A41BR_Comorbidity_Hapetitis = GetNextPar( );
            n41BR_Comorbidity_Hapetitis = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41BR_Comorbidity_Hapetitis", A41BR_Comorbidity_Hapetitis);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX17ASABR_COMORBIDITY_HAPETITIS_CODE0910( A41BR_Comorbidity_Hapetitis) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel18"+"_"+"BR_COMORBIDITY_HAPETITIS_CODE") == 0 )
         {
            A41BR_Comorbidity_Hapetitis = GetNextPar( );
            n41BR_Comorbidity_Hapetitis = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41BR_Comorbidity_Hapetitis", A41BR_Comorbidity_Hapetitis);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX18ASABR_COMORBIDITY_HAPETITIS_CODE0910( A41BR_Comorbidity_Hapetitis) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel19"+"_"+"BR_COMORBIDITY_TB_CODE") == 0 )
         {
            A42BR_Comorbidity_TB = GetNextPar( );
            n42BR_Comorbidity_TB = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BR_Comorbidity_TB", A42BR_Comorbidity_TB);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX19ASABR_COMORBIDITY_TB_CODE0910( A42BR_Comorbidity_TB) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel20"+"_"+"BR_COMORBIDITY_TB_CODE") == 0 )
         {
            A42BR_Comorbidity_TB = GetNextPar( );
            n42BR_Comorbidity_TB = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BR_Comorbidity_TB", A42BR_Comorbidity_TB);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX20ASABR_COMORBIDITY_TB_CODE0910( A42BR_Comorbidity_TB) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel21"+"_"+"BR_COMORBIDITY_KIDNEYDISEASE_CODE") == 0 )
         {
            A43BR_Comorbidity_KidneyDisease = GetNextPar( );
            n43BR_Comorbidity_KidneyDisease = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43BR_Comorbidity_KidneyDisease", A43BR_Comorbidity_KidneyDisease);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX21ASABR_COMORBIDITY_KIDNEYDISEASE_CODE0910( A43BR_Comorbidity_KidneyDisease) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel22"+"_"+"BR_COMORBIDITY_KIDNEYDISEASE_CODE") == 0 )
         {
            A43BR_Comorbidity_KidneyDisease = GetNextPar( );
            n43BR_Comorbidity_KidneyDisease = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43BR_Comorbidity_KidneyDisease", A43BR_Comorbidity_KidneyDisease);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX22ASABR_COMORBIDITY_KIDNEYDISEASE_CODE0910( A43BR_Comorbidity_KidneyDisease) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel23"+"_"+"BR_COMORBIDITY_SURGERYHISTORY_CODE") == 0 )
         {
            A44BR_Comorbidity_SurgeryHistory = GetNextPar( );
            n44BR_Comorbidity_SurgeryHistory = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44BR_Comorbidity_SurgeryHistory", A44BR_Comorbidity_SurgeryHistory);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX23ASABR_COMORBIDITY_SURGERYHISTORY_CODE0910( A44BR_Comorbidity_SurgeryHistory) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel24"+"_"+"BR_COMORBIDITY_SURGERYHISTORY_CODE") == 0 )
         {
            A44BR_Comorbidity_SurgeryHistory = GetNextPar( );
            n44BR_Comorbidity_SurgeryHistory = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44BR_Comorbidity_SurgeryHistory", A44BR_Comorbidity_SurgeryHistory);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX24ASABR_COMORBIDITY_SURGERYHISTORY_CODE0910( A44BR_Comorbidity_SurgeryHistory) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel25"+"_"+"BR_COMORBIDITY_INJURYHISTORY_CODE") == 0 )
         {
            A45BR_Comorbidity_InjuryHistory = GetNextPar( );
            n45BR_Comorbidity_InjuryHistory = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A45BR_Comorbidity_InjuryHistory", A45BR_Comorbidity_InjuryHistory);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX25ASABR_COMORBIDITY_INJURYHISTORY_CODE0910( A45BR_Comorbidity_InjuryHistory) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel26"+"_"+"BR_COMORBIDITY_INJURYHISTORY_CODE") == 0 )
         {
            A45BR_Comorbidity_InjuryHistory = GetNextPar( );
            n45BR_Comorbidity_InjuryHistory = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A45BR_Comorbidity_InjuryHistory", A45BR_Comorbidity_InjuryHistory);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX26ASABR_COMORBIDITY_INJURYHISTORY_CODE0910( A45BR_Comorbidity_InjuryHistory) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel27"+"_"+"BR_COMORBIDITY_BLOODHISTORY_CODE") == 0 )
         {
            A46BR_Comorbidity_BloodHistory = GetNextPar( );
            n46BR_Comorbidity_BloodHistory = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46BR_Comorbidity_BloodHistory", A46BR_Comorbidity_BloodHistory);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX27ASABR_COMORBIDITY_BLOODHISTORY_CODE0910( A46BR_Comorbidity_BloodHistory) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel28"+"_"+"BR_COMORBIDITY_BLOODHISTORY_CODE") == 0 )
         {
            A46BR_Comorbidity_BloodHistory = GetNextPar( );
            n46BR_Comorbidity_BloodHistory = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46BR_Comorbidity_BloodHistory", A46BR_Comorbidity_BloodHistory);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX28ASABR_COMORBIDITY_BLOODHISTORY_CODE0910( A46BR_Comorbidity_BloodHistory) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel29"+"_"+"BR_COMORBIDITY_ALLERGY_CODE") == 0 )
         {
            A47BR_Comorbidity_allergy = GetNextPar( );
            n47BR_Comorbidity_allergy = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A47BR_Comorbidity_allergy", A47BR_Comorbidity_allergy);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX29ASABR_COMORBIDITY_ALLERGY_CODE0910( A47BR_Comorbidity_allergy) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel30"+"_"+"BR_COMORBIDITY_ALLERGY_CODE") == 0 )
         {
            A47BR_Comorbidity_allergy = GetNextPar( );
            n47BR_Comorbidity_allergy = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A47BR_Comorbidity_allergy", A47BR_Comorbidity_allergy);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX30ASABR_COMORBIDITY_ALLERGY_CODE0910( A47BR_Comorbidity_allergy) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_32") == 0 )
         {
            A19BR_EncounterID = (long)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_32( A19BR_EncounterID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_33") == 0 )
         {
            A85BR_Information_ID = (long)(NumberUtil.Val( GetNextPar( ), "."));
            n85BR_Information_ID = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A85BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A85BR_Information_ID), 18, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_33( A85BR_Information_ID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxEvt") == 0 )
         {
            setAjaxEventMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxfirstwebparm = GetNextPar( );
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxfullajaxEvt") == 0 )
         {
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxfirstwebparm = GetNextPar( );
         }
         else
         {
            if ( ! IsValidAjaxCall( false) )
            {
               GxWebError = 1;
               return  ;
            }
            gxfirstwebparm = gxfirstwebparm_bkp;
         }
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
         {
            gxcookieaux = context.SetCookie( "GX_SESSION_ID", Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0);
         }
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         toggleJsOutput = isJsOutputEnabled( );
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_web_controls( ) ;
         if ( toggleJsOutput )
         {
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
         }
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", "既往病史", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtBR_EncounterID_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public br_comorbidity( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_comorbidity( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( )
      {
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbBR_Comorbidity_Hypertension = new GXCombobox();
         cmbBR_Comorbidity_Diabetes = new GXCombobox();
         cmbBR_Comorbidity_CHD = new GXCombobox();
         cmbBR_Comorbidity_Hapetitis = new GXCombobox();
         cmbBR_Comorbidity_TB = new GXCombobox();
         cmbBR_Comorbidity_KidneyDisease = new GXCombobox();
         cmbBR_Comorbidity_SurgeryHistory = new GXCombobox();
         cmbBR_Comorbidity_InjuryHistory = new GXCombobox();
         cmbBR_Comorbidity_BloodHistory = new GXCombobox();
         cmbBR_Comorbidity_allergy = new GXCombobox();
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITENV( ) ;
         INITTRN( ) ;
         if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
         {
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("wwpbaseobjects.workwithplusmasterpage", "GeneXus.Programs.wwpbaseobjects.workwithplusmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,false);
            ValidateSpaRequest();
            MasterPageObj.webExecute();
            if ( ( GxWebError == 0 ) && context.isAjaxRequest( ) )
            {
               enableOutput();
               if ( ! context.isAjaxRequest( ) )
               {
                  context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
               }
               if ( ! context.WillRedirect( ) )
               {
                  context.GX_webresponse.AddString((String)(context.getJSONResponse( )));
               }
               else
               {
                  if ( context.isAjaxRequest( ) )
                  {
                     disableOutput();
                  }
                  RenderHtmlHeaders( ) ;
                  context.Redirect( context.wjLoc );
                  context.DispatchAjaxCommands();
               }
            }
         }
         this.cleanup();
      }

      protected void fix_multi_value_controls( )
      {
         if ( cmbBR_Comorbidity_Hypertension.ItemCount > 0 )
         {
            A38BR_Comorbidity_Hypertension = cmbBR_Comorbidity_Hypertension.getValidValue(A38BR_Comorbidity_Hypertension);
            n38BR_Comorbidity_Hypertension = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38BR_Comorbidity_Hypertension", A38BR_Comorbidity_Hypertension);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbBR_Comorbidity_Hypertension.CurrentValue = StringUtil.RTrim( A38BR_Comorbidity_Hypertension);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Comorbidity_Hypertension_Internalname, "Values", cmbBR_Comorbidity_Hypertension.ToJavascriptSource(), true);
         }
         if ( cmbBR_Comorbidity_Diabetes.ItemCount > 0 )
         {
            A39BR_Comorbidity_Diabetes = cmbBR_Comorbidity_Diabetes.getValidValue(A39BR_Comorbidity_Diabetes);
            n39BR_Comorbidity_Diabetes = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39BR_Comorbidity_Diabetes", A39BR_Comorbidity_Diabetes);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbBR_Comorbidity_Diabetes.CurrentValue = StringUtil.RTrim( A39BR_Comorbidity_Diabetes);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Comorbidity_Diabetes_Internalname, "Values", cmbBR_Comorbidity_Diabetes.ToJavascriptSource(), true);
         }
         if ( cmbBR_Comorbidity_CHD.ItemCount > 0 )
         {
            A40BR_Comorbidity_CHD = cmbBR_Comorbidity_CHD.getValidValue(A40BR_Comorbidity_CHD);
            n40BR_Comorbidity_CHD = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40BR_Comorbidity_CHD", A40BR_Comorbidity_CHD);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbBR_Comorbidity_CHD.CurrentValue = StringUtil.RTrim( A40BR_Comorbidity_CHD);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Comorbidity_CHD_Internalname, "Values", cmbBR_Comorbidity_CHD.ToJavascriptSource(), true);
         }
         if ( cmbBR_Comorbidity_Hapetitis.ItemCount > 0 )
         {
            A41BR_Comorbidity_Hapetitis = cmbBR_Comorbidity_Hapetitis.getValidValue(A41BR_Comorbidity_Hapetitis);
            n41BR_Comorbidity_Hapetitis = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41BR_Comorbidity_Hapetitis", A41BR_Comorbidity_Hapetitis);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbBR_Comorbidity_Hapetitis.CurrentValue = StringUtil.RTrim( A41BR_Comorbidity_Hapetitis);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Comorbidity_Hapetitis_Internalname, "Values", cmbBR_Comorbidity_Hapetitis.ToJavascriptSource(), true);
         }
         if ( cmbBR_Comorbidity_TB.ItemCount > 0 )
         {
            A42BR_Comorbidity_TB = cmbBR_Comorbidity_TB.getValidValue(A42BR_Comorbidity_TB);
            n42BR_Comorbidity_TB = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BR_Comorbidity_TB", A42BR_Comorbidity_TB);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbBR_Comorbidity_TB.CurrentValue = StringUtil.RTrim( A42BR_Comorbidity_TB);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Comorbidity_TB_Internalname, "Values", cmbBR_Comorbidity_TB.ToJavascriptSource(), true);
         }
         if ( cmbBR_Comorbidity_KidneyDisease.ItemCount > 0 )
         {
            A43BR_Comorbidity_KidneyDisease = cmbBR_Comorbidity_KidneyDisease.getValidValue(A43BR_Comorbidity_KidneyDisease);
            n43BR_Comorbidity_KidneyDisease = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43BR_Comorbidity_KidneyDisease", A43BR_Comorbidity_KidneyDisease);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbBR_Comorbidity_KidneyDisease.CurrentValue = StringUtil.RTrim( A43BR_Comorbidity_KidneyDisease);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Comorbidity_KidneyDisease_Internalname, "Values", cmbBR_Comorbidity_KidneyDisease.ToJavascriptSource(), true);
         }
         if ( cmbBR_Comorbidity_SurgeryHistory.ItemCount > 0 )
         {
            A44BR_Comorbidity_SurgeryHistory = cmbBR_Comorbidity_SurgeryHistory.getValidValue(A44BR_Comorbidity_SurgeryHistory);
            n44BR_Comorbidity_SurgeryHistory = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44BR_Comorbidity_SurgeryHistory", A44BR_Comorbidity_SurgeryHistory);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbBR_Comorbidity_SurgeryHistory.CurrentValue = StringUtil.RTrim( A44BR_Comorbidity_SurgeryHistory);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Comorbidity_SurgeryHistory_Internalname, "Values", cmbBR_Comorbidity_SurgeryHistory.ToJavascriptSource(), true);
         }
         if ( cmbBR_Comorbidity_InjuryHistory.ItemCount > 0 )
         {
            A45BR_Comorbidity_InjuryHistory = cmbBR_Comorbidity_InjuryHistory.getValidValue(A45BR_Comorbidity_InjuryHistory);
            n45BR_Comorbidity_InjuryHistory = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A45BR_Comorbidity_InjuryHistory", A45BR_Comorbidity_InjuryHistory);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbBR_Comorbidity_InjuryHistory.CurrentValue = StringUtil.RTrim( A45BR_Comorbidity_InjuryHistory);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Comorbidity_InjuryHistory_Internalname, "Values", cmbBR_Comorbidity_InjuryHistory.ToJavascriptSource(), true);
         }
         if ( cmbBR_Comorbidity_BloodHistory.ItemCount > 0 )
         {
            A46BR_Comorbidity_BloodHistory = cmbBR_Comorbidity_BloodHistory.getValidValue(A46BR_Comorbidity_BloodHistory);
            n46BR_Comorbidity_BloodHistory = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46BR_Comorbidity_BloodHistory", A46BR_Comorbidity_BloodHistory);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbBR_Comorbidity_BloodHistory.CurrentValue = StringUtil.RTrim( A46BR_Comorbidity_BloodHistory);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Comorbidity_BloodHistory_Internalname, "Values", cmbBR_Comorbidity_BloodHistory.ToJavascriptSource(), true);
         }
         if ( cmbBR_Comorbidity_allergy.ItemCount > 0 )
         {
            A47BR_Comorbidity_allergy = cmbBR_Comorbidity_allergy.getValidValue(A47BR_Comorbidity_allergy);
            n47BR_Comorbidity_allergy = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A47BR_Comorbidity_allergy", A47BR_Comorbidity_allergy);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbBR_Comorbidity_allergy.CurrentValue = StringUtil.RTrim( A47BR_Comorbidity_allergy);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Comorbidity_allergy_Internalname, "Values", cmbBR_Comorbidity_allergy.ToJavascriptSource(), true);
         }
      }

      protected void Draw( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! GxWebStd.gx_redirect( context) )
         {
            disable_std_buttons( ) ;
            enableDisable( ) ;
            set_caption( ) ;
            /* Form start */
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayoutmaintable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablemain_Internalname, 1, 0, "px", 0, "px", "TableMainTransaction", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            ClassString = "ErrorViewer";
            StyleString = "";
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablecontent_Internalname, 1, 0, "px", 0, "px", "TableContent", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9 col-lg-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divHtml_dvpanel_tableattributes_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* User Defined Control */
            ucDvpanel_tableattributes.SetProperty("Width", Dvpanel_tableattributes_Width);
            ucDvpanel_tableattributes.SetProperty("AutoWidth", Dvpanel_tableattributes_Autowidth);
            ucDvpanel_tableattributes.SetProperty("AutoHeight", Dvpanel_tableattributes_Autoheight);
            ucDvpanel_tableattributes.SetProperty("Cls", Dvpanel_tableattributes_Cls);
            ucDvpanel_tableattributes.SetProperty("Title", Dvpanel_tableattributes_Title);
            ucDvpanel_tableattributes.SetProperty("Collapsible", Dvpanel_tableattributes_Collapsible);
            ucDvpanel_tableattributes.SetProperty("Collapsed", Dvpanel_tableattributes_Collapsed);
            ucDvpanel_tableattributes.SetProperty("ShowCollapseIcon", Dvpanel_tableattributes_Showcollapseicon);
            ucDvpanel_tableattributes.SetProperty("IconPosition", Dvpanel_tableattributes_Iconposition);
            ucDvpanel_tableattributes.SetProperty("AutoScroll", Dvpanel_tableattributes_Autoscroll);
            ucDvpanel_tableattributes.Render(context, "dvelop.gxbootstrap.panel", Dvpanel_tableattributes_Internalname, "DVPANEL_TABLEATTRIBUTESContainer");
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"DVPANEL_TABLEATTRIBUTESContainer"+"Body"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayout_tableattributes_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTableattributes_Internalname, 1, 0, "px", 0, "px", "TableData", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_EncounterID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_EncounterID_Internalname, "病人就诊信息ID", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_EncounterID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")), ((edtBR_EncounterID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ")) : context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,25);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_EncounterID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_EncounterID_Enabled, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_Comorbidity.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-6 DataContentCell", "left", "top", "", "", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-6 DataContentCell", "left", "top", "", "", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbBR_Comorbidity_Hypertension_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbBR_Comorbidity_Hypertension_Internalname, "高血压", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 32,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbBR_Comorbidity_Hypertension, cmbBR_Comorbidity_Hypertension_Internalname, StringUtil.RTrim( A38BR_Comorbidity_Hypertension), 1, cmbBR_Comorbidity_Hypertension_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, cmbBR_Comorbidity_Hypertension.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,32);\"", "", true, "HLP_BR_Comorbidity.htm");
            cmbBR_Comorbidity_Hypertension.CurrentValue = StringUtil.RTrim( A38BR_Comorbidity_Hypertension);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Comorbidity_Hypertension_Internalname, "Values", (String)(cmbBR_Comorbidity_Hypertension.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbBR_Comorbidity_Diabetes_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbBR_Comorbidity_Diabetes_Internalname, "糖尿病", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 37,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbBR_Comorbidity_Diabetes, cmbBR_Comorbidity_Diabetes_Internalname, StringUtil.RTrim( A39BR_Comorbidity_Diabetes), 1, cmbBR_Comorbidity_Diabetes_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, cmbBR_Comorbidity_Diabetes.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,37);\"", "", true, "HLP_BR_Comorbidity.htm");
            cmbBR_Comorbidity_Diabetes.CurrentValue = StringUtil.RTrim( A39BR_Comorbidity_Diabetes);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Comorbidity_Diabetes_Internalname, "Values", (String)(cmbBR_Comorbidity_Diabetes.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbBR_Comorbidity_CHD_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbBR_Comorbidity_CHD_Internalname, "冠心病", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 41,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbBR_Comorbidity_CHD, cmbBR_Comorbidity_CHD_Internalname, StringUtil.RTrim( A40BR_Comorbidity_CHD), 1, cmbBR_Comorbidity_CHD_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, cmbBR_Comorbidity_CHD.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,41);\"", "", true, "HLP_BR_Comorbidity.htm");
            cmbBR_Comorbidity_CHD.CurrentValue = StringUtil.RTrim( A40BR_Comorbidity_CHD);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Comorbidity_CHD_Internalname, "Values", (String)(cmbBR_Comorbidity_CHD.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbBR_Comorbidity_Hapetitis_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbBR_Comorbidity_Hapetitis_Internalname, "肝炎", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbBR_Comorbidity_Hapetitis, cmbBR_Comorbidity_Hapetitis_Internalname, StringUtil.RTrim( A41BR_Comorbidity_Hapetitis), 1, cmbBR_Comorbidity_Hapetitis_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, cmbBR_Comorbidity_Hapetitis.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,46);\"", "", true, "HLP_BR_Comorbidity.htm");
            cmbBR_Comorbidity_Hapetitis.CurrentValue = StringUtil.RTrim( A41BR_Comorbidity_Hapetitis);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Comorbidity_Hapetitis_Internalname, "Values", (String)(cmbBR_Comorbidity_Hapetitis.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbBR_Comorbidity_TB_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbBR_Comorbidity_TB_Internalname, "结核病", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbBR_Comorbidity_TB, cmbBR_Comorbidity_TB_Internalname, StringUtil.RTrim( A42BR_Comorbidity_TB), 1, cmbBR_Comorbidity_TB_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, cmbBR_Comorbidity_TB.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,50);\"", "", true, "HLP_BR_Comorbidity.htm");
            cmbBR_Comorbidity_TB.CurrentValue = StringUtil.RTrim( A42BR_Comorbidity_TB);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Comorbidity_TB_Internalname, "Values", (String)(cmbBR_Comorbidity_TB.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbBR_Comorbidity_KidneyDisease_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbBR_Comorbidity_KidneyDisease_Internalname, "肾病", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 55,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbBR_Comorbidity_KidneyDisease, cmbBR_Comorbidity_KidneyDisease_Internalname, StringUtil.RTrim( A43BR_Comorbidity_KidneyDisease), 1, cmbBR_Comorbidity_KidneyDisease_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, cmbBR_Comorbidity_KidneyDisease.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,55);\"", "", true, "HLP_BR_Comorbidity.htm");
            cmbBR_Comorbidity_KidneyDisease.CurrentValue = StringUtil.RTrim( A43BR_Comorbidity_KidneyDisease);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Comorbidity_KidneyDisease_Internalname, "Values", (String)(cmbBR_Comorbidity_KidneyDisease.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbBR_Comorbidity_SurgeryHistory_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbBR_Comorbidity_SurgeryHistory_Internalname, "手术史", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbBR_Comorbidity_SurgeryHistory, cmbBR_Comorbidity_SurgeryHistory_Internalname, StringUtil.RTrim( A44BR_Comorbidity_SurgeryHistory), 1, cmbBR_Comorbidity_SurgeryHistory_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, cmbBR_Comorbidity_SurgeryHistory.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,59);\"", "", true, "HLP_BR_Comorbidity.htm");
            cmbBR_Comorbidity_SurgeryHistory.CurrentValue = StringUtil.RTrim( A44BR_Comorbidity_SurgeryHistory);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Comorbidity_SurgeryHistory_Internalname, "Values", (String)(cmbBR_Comorbidity_SurgeryHistory.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbBR_Comorbidity_InjuryHistory_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbBR_Comorbidity_InjuryHistory_Internalname, "外伤史", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbBR_Comorbidity_InjuryHistory, cmbBR_Comorbidity_InjuryHistory_Internalname, StringUtil.RTrim( A45BR_Comorbidity_InjuryHistory), 1, cmbBR_Comorbidity_InjuryHistory_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, cmbBR_Comorbidity_InjuryHistory.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,64);\"", "", true, "HLP_BR_Comorbidity.htm");
            cmbBR_Comorbidity_InjuryHistory.CurrentValue = StringUtil.RTrim( A45BR_Comorbidity_InjuryHistory);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Comorbidity_InjuryHistory_Internalname, "Values", (String)(cmbBR_Comorbidity_InjuryHistory.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbBR_Comorbidity_BloodHistory_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbBR_Comorbidity_BloodHistory_Internalname, "输血史", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbBR_Comorbidity_BloodHistory, cmbBR_Comorbidity_BloodHistory_Internalname, StringUtil.RTrim( A46BR_Comorbidity_BloodHistory), 1, cmbBR_Comorbidity_BloodHistory_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, cmbBR_Comorbidity_BloodHistory.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,68);\"", "", true, "HLP_BR_Comorbidity.htm");
            cmbBR_Comorbidity_BloodHistory.CurrentValue = StringUtil.RTrim( A46BR_Comorbidity_BloodHistory);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Comorbidity_BloodHistory_Internalname, "Values", (String)(cmbBR_Comorbidity_BloodHistory.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbBR_Comorbidity_allergy_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbBR_Comorbidity_allergy_Internalname, "过敏史", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbBR_Comorbidity_allergy, cmbBR_Comorbidity_allergy_Internalname, StringUtil.RTrim( A47BR_Comorbidity_allergy), 1, cmbBR_Comorbidity_allergy_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, cmbBR_Comorbidity_allergy.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,73);\"", "", true, "HLP_BR_Comorbidity.htm");
            cmbBR_Comorbidity_allergy.CurrentValue = StringUtil.RTrim( A47BR_Comorbidity_allergy);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Comorbidity_allergy_Internalname, "Values", (String)(cmbBR_Comorbidity_allergy.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group TrnActionGroup", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 78,'',false,'',0)\"";
            ClassString = "Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_enter_Internalname, "", "确认", bttBtntrn_enter_Jsonclick, 5, "确认", "", StyleString, ClassString, bttBtntrn_enter_Visible, bttBtntrn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Comorbidity.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 80,'',false,'',0)\"";
            ClassString = "BtnDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_cancel_Internalname, "", "取消", bttBtntrn_cancel_Jsonclick, 1, "取消", "", StyleString, ClassString, bttBtntrn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Comorbidity.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 82,'',false,'',0)\"";
            ClassString = "BtnDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_delete_Internalname, "", "删除", bttBtntrn_delete_Jsonclick, 5, "删除", "", StyleString, ClassString, bttBtntrn_delete_Visible, bttBtntrn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Comorbidity.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divHtml_bottomauxiliarcontrols_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 86,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_ComorbidityID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A37BR_ComorbidityID), 18, 0, ".", "")), ((edtBR_ComorbidityID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A37BR_ComorbidityID), "ZZZZZZZZZZZZZZZZZZ")) : context.localUtil.Format( (decimal)(A37BR_ComorbidityID), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,86);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_ComorbidityID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_ComorbidityID_Enabled, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_Comorbidity.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            fix_multi_value_controls( ) ;
         }
         /* Execute Exit event if defined. */
      }

      protected void UserMain( )
      {
         standaloneStartup( ) ;
      }

      protected void UserMainFullajax( )
      {
         INITENV( ) ;
         INITTRN( ) ;
         UserMain( ) ;
         Draw( ) ;
         SendCloseFormHiddens( ) ;
      }

      protected void standaloneStartup( )
      {
         standaloneStartupServer( ) ;
         disable_std_buttons( ) ;
         enableDisable( ) ;
         Process( ) ;
      }

      protected void standaloneStartupServer( )
      {
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E11092 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               if ( ( ( context.localUtil.CToN( cgiGet( edtBR_EncounterID_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtBR_EncounterID_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_ENCOUNTERID");
                  AnyError = 1;
                  GX_FocusControl = edtBR_EncounterID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A19BR_EncounterID = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
               }
               else
               {
                  A19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( edtBR_EncounterID_Internalname), ".", ","));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
               }
               cmbBR_Comorbidity_Hypertension.CurrentValue = cgiGet( cmbBR_Comorbidity_Hypertension_Internalname);
               A38BR_Comorbidity_Hypertension = cgiGet( cmbBR_Comorbidity_Hypertension_Internalname);
               n38BR_Comorbidity_Hypertension = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38BR_Comorbidity_Hypertension", A38BR_Comorbidity_Hypertension);
               n38BR_Comorbidity_Hypertension = (String.IsNullOrEmpty(StringUtil.RTrim( A38BR_Comorbidity_Hypertension)) ? true : false);
               cmbBR_Comorbidity_Diabetes.CurrentValue = cgiGet( cmbBR_Comorbidity_Diabetes_Internalname);
               A39BR_Comorbidity_Diabetes = cgiGet( cmbBR_Comorbidity_Diabetes_Internalname);
               n39BR_Comorbidity_Diabetes = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39BR_Comorbidity_Diabetes", A39BR_Comorbidity_Diabetes);
               n39BR_Comorbidity_Diabetes = (String.IsNullOrEmpty(StringUtil.RTrim( A39BR_Comorbidity_Diabetes)) ? true : false);
               cmbBR_Comorbidity_CHD.CurrentValue = cgiGet( cmbBR_Comorbidity_CHD_Internalname);
               A40BR_Comorbidity_CHD = cgiGet( cmbBR_Comorbidity_CHD_Internalname);
               n40BR_Comorbidity_CHD = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40BR_Comorbidity_CHD", A40BR_Comorbidity_CHD);
               n40BR_Comorbidity_CHD = (String.IsNullOrEmpty(StringUtil.RTrim( A40BR_Comorbidity_CHD)) ? true : false);
               cmbBR_Comorbidity_Hapetitis.CurrentValue = cgiGet( cmbBR_Comorbidity_Hapetitis_Internalname);
               A41BR_Comorbidity_Hapetitis = cgiGet( cmbBR_Comorbidity_Hapetitis_Internalname);
               n41BR_Comorbidity_Hapetitis = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41BR_Comorbidity_Hapetitis", A41BR_Comorbidity_Hapetitis);
               n41BR_Comorbidity_Hapetitis = (String.IsNullOrEmpty(StringUtil.RTrim( A41BR_Comorbidity_Hapetitis)) ? true : false);
               cmbBR_Comorbidity_TB.CurrentValue = cgiGet( cmbBR_Comorbidity_TB_Internalname);
               A42BR_Comorbidity_TB = cgiGet( cmbBR_Comorbidity_TB_Internalname);
               n42BR_Comorbidity_TB = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BR_Comorbidity_TB", A42BR_Comorbidity_TB);
               n42BR_Comorbidity_TB = (String.IsNullOrEmpty(StringUtil.RTrim( A42BR_Comorbidity_TB)) ? true : false);
               cmbBR_Comorbidity_KidneyDisease.CurrentValue = cgiGet( cmbBR_Comorbidity_KidneyDisease_Internalname);
               A43BR_Comorbidity_KidneyDisease = cgiGet( cmbBR_Comorbidity_KidneyDisease_Internalname);
               n43BR_Comorbidity_KidneyDisease = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43BR_Comorbidity_KidneyDisease", A43BR_Comorbidity_KidneyDisease);
               n43BR_Comorbidity_KidneyDisease = (String.IsNullOrEmpty(StringUtil.RTrim( A43BR_Comorbidity_KidneyDisease)) ? true : false);
               cmbBR_Comorbidity_SurgeryHistory.CurrentValue = cgiGet( cmbBR_Comorbidity_SurgeryHistory_Internalname);
               A44BR_Comorbidity_SurgeryHistory = cgiGet( cmbBR_Comorbidity_SurgeryHistory_Internalname);
               n44BR_Comorbidity_SurgeryHistory = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44BR_Comorbidity_SurgeryHistory", A44BR_Comorbidity_SurgeryHistory);
               n44BR_Comorbidity_SurgeryHistory = (String.IsNullOrEmpty(StringUtil.RTrim( A44BR_Comorbidity_SurgeryHistory)) ? true : false);
               cmbBR_Comorbidity_InjuryHistory.CurrentValue = cgiGet( cmbBR_Comorbidity_InjuryHistory_Internalname);
               A45BR_Comorbidity_InjuryHistory = cgiGet( cmbBR_Comorbidity_InjuryHistory_Internalname);
               n45BR_Comorbidity_InjuryHistory = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A45BR_Comorbidity_InjuryHistory", A45BR_Comorbidity_InjuryHistory);
               n45BR_Comorbidity_InjuryHistory = (String.IsNullOrEmpty(StringUtil.RTrim( A45BR_Comorbidity_InjuryHistory)) ? true : false);
               cmbBR_Comorbidity_BloodHistory.CurrentValue = cgiGet( cmbBR_Comorbidity_BloodHistory_Internalname);
               A46BR_Comorbidity_BloodHistory = cgiGet( cmbBR_Comorbidity_BloodHistory_Internalname);
               n46BR_Comorbidity_BloodHistory = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46BR_Comorbidity_BloodHistory", A46BR_Comorbidity_BloodHistory);
               n46BR_Comorbidity_BloodHistory = (String.IsNullOrEmpty(StringUtil.RTrim( A46BR_Comorbidity_BloodHistory)) ? true : false);
               cmbBR_Comorbidity_allergy.CurrentValue = cgiGet( cmbBR_Comorbidity_allergy_Internalname);
               A47BR_Comorbidity_allergy = cgiGet( cmbBR_Comorbidity_allergy_Internalname);
               n47BR_Comorbidity_allergy = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A47BR_Comorbidity_allergy", A47BR_Comorbidity_allergy);
               n47BR_Comorbidity_allergy = (String.IsNullOrEmpty(StringUtil.RTrim( A47BR_Comorbidity_allergy)) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtBR_ComorbidityID_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtBR_ComorbidityID_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_COMORBIDITYID");
                  AnyError = 1;
                  GX_FocusControl = edtBR_ComorbidityID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A37BR_ComorbidityID = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37BR_ComorbidityID", StringUtil.LTrim( StringUtil.Str( (decimal)(A37BR_ComorbidityID), 18, 0)));
               }
               else
               {
                  A37BR_ComorbidityID = (long)(context.localUtil.CToN( cgiGet( edtBR_ComorbidityID_Internalname), ".", ","));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37BR_ComorbidityID", StringUtil.LTrim( StringUtil.Str( (decimal)(A37BR_ComorbidityID), 18, 0)));
               }
               /* Read saved values. */
               Z37BR_ComorbidityID = (long)(context.localUtil.CToN( cgiGet( "Z37BR_ComorbidityID"), ".", ","));
               Z487BR_Comorbidity_Hypertension_Code = cgiGet( "Z487BR_Comorbidity_Hypertension_Code");
               n487BR_Comorbidity_Hypertension_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A487BR_Comorbidity_Hypertension_Code)) ? true : false);
               Z488BR_Comorbidity_Diabetes_Code = cgiGet( "Z488BR_Comorbidity_Diabetes_Code");
               n488BR_Comorbidity_Diabetes_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A488BR_Comorbidity_Diabetes_Code)) ? true : false);
               Z489BR_Comorbidity_CHD_Code = cgiGet( "Z489BR_Comorbidity_CHD_Code");
               n489BR_Comorbidity_CHD_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A489BR_Comorbidity_CHD_Code)) ? true : false);
               Z490BR_Comorbidity_Hapetitis_Code = cgiGet( "Z490BR_Comorbidity_Hapetitis_Code");
               n490BR_Comorbidity_Hapetitis_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A490BR_Comorbidity_Hapetitis_Code)) ? true : false);
               Z491BR_Comorbidity_TB_Code = cgiGet( "Z491BR_Comorbidity_TB_Code");
               n491BR_Comorbidity_TB_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A491BR_Comorbidity_TB_Code)) ? true : false);
               Z492BR_Comorbidity_KidneyDisease_Code = cgiGet( "Z492BR_Comorbidity_KidneyDisease_Code");
               n492BR_Comorbidity_KidneyDisease_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A492BR_Comorbidity_KidneyDisease_Code)) ? true : false);
               Z493BR_Comorbidity_SurgeryHistory_Code = cgiGet( "Z493BR_Comorbidity_SurgeryHistory_Code");
               n493BR_Comorbidity_SurgeryHistory_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A493BR_Comorbidity_SurgeryHistory_Code)) ? true : false);
               Z494BR_Comorbidity_InjuryHistory_Code = cgiGet( "Z494BR_Comorbidity_InjuryHistory_Code");
               n494BR_Comorbidity_InjuryHistory_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A494BR_Comorbidity_InjuryHistory_Code)) ? true : false);
               Z495BR_Comorbidity_BloodHistory_Code = cgiGet( "Z495BR_Comorbidity_BloodHistory_Code");
               n495BR_Comorbidity_BloodHistory_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A495BR_Comorbidity_BloodHistory_Code)) ? true : false);
               Z496BR_Comorbidity_allergy_Code = cgiGet( "Z496BR_Comorbidity_allergy_Code");
               n496BR_Comorbidity_allergy_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A496BR_Comorbidity_allergy_Code)) ? true : false);
               Z38BR_Comorbidity_Hypertension = cgiGet( "Z38BR_Comorbidity_Hypertension");
               n38BR_Comorbidity_Hypertension = (String.IsNullOrEmpty(StringUtil.RTrim( A38BR_Comorbidity_Hypertension)) ? true : false);
               Z39BR_Comorbidity_Diabetes = cgiGet( "Z39BR_Comorbidity_Diabetes");
               n39BR_Comorbidity_Diabetes = (String.IsNullOrEmpty(StringUtil.RTrim( A39BR_Comorbidity_Diabetes)) ? true : false);
               Z40BR_Comorbidity_CHD = cgiGet( "Z40BR_Comorbidity_CHD");
               n40BR_Comorbidity_CHD = (String.IsNullOrEmpty(StringUtil.RTrim( A40BR_Comorbidity_CHD)) ? true : false);
               Z41BR_Comorbidity_Hapetitis = cgiGet( "Z41BR_Comorbidity_Hapetitis");
               n41BR_Comorbidity_Hapetitis = (String.IsNullOrEmpty(StringUtil.RTrim( A41BR_Comorbidity_Hapetitis)) ? true : false);
               Z42BR_Comorbidity_TB = cgiGet( "Z42BR_Comorbidity_TB");
               n42BR_Comorbidity_TB = (String.IsNullOrEmpty(StringUtil.RTrim( A42BR_Comorbidity_TB)) ? true : false);
               Z43BR_Comorbidity_KidneyDisease = cgiGet( "Z43BR_Comorbidity_KidneyDisease");
               n43BR_Comorbidity_KidneyDisease = (String.IsNullOrEmpty(StringUtil.RTrim( A43BR_Comorbidity_KidneyDisease)) ? true : false);
               Z44BR_Comorbidity_SurgeryHistory = cgiGet( "Z44BR_Comorbidity_SurgeryHistory");
               n44BR_Comorbidity_SurgeryHistory = (String.IsNullOrEmpty(StringUtil.RTrim( A44BR_Comorbidity_SurgeryHistory)) ? true : false);
               Z45BR_Comorbidity_InjuryHistory = cgiGet( "Z45BR_Comorbidity_InjuryHistory");
               n45BR_Comorbidity_InjuryHistory = (String.IsNullOrEmpty(StringUtil.RTrim( A45BR_Comorbidity_InjuryHistory)) ? true : false);
               Z46BR_Comorbidity_BloodHistory = cgiGet( "Z46BR_Comorbidity_BloodHistory");
               n46BR_Comorbidity_BloodHistory = (String.IsNullOrEmpty(StringUtil.RTrim( A46BR_Comorbidity_BloodHistory)) ? true : false);
               Z47BR_Comorbidity_allergy = cgiGet( "Z47BR_Comorbidity_allergy");
               n47BR_Comorbidity_allergy = (String.IsNullOrEmpty(StringUtil.RTrim( A47BR_Comorbidity_allergy)) ? true : false);
               Z259BR_Comorbidity_Others = cgiGet( "Z259BR_Comorbidity_Others");
               n259BR_Comorbidity_Others = (String.IsNullOrEmpty(StringUtil.RTrim( A259BR_Comorbidity_Others)) ? true : false);
               Z561BR_Comorbidity_HapetitisB = cgiGet( "Z561BR_Comorbidity_HapetitisB");
               n561BR_Comorbidity_HapetitisB = (String.IsNullOrEmpty(StringUtil.RTrim( A561BR_Comorbidity_HapetitisB)) ? true : false);
               Z562BR_Comorbidity_HapetitisB_Code = cgiGet( "Z562BR_Comorbidity_HapetitisB_Code");
               n562BR_Comorbidity_HapetitisB_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A562BR_Comorbidity_HapetitisB_Code)) ? true : false);
               Z563BR_Comorbidity_HapetitisC = cgiGet( "Z563BR_Comorbidity_HapetitisC");
               n563BR_Comorbidity_HapetitisC = (String.IsNullOrEmpty(StringUtil.RTrim( A563BR_Comorbidity_HapetitisC)) ? true : false);
               Z564BR_Comorbidity_HapetitisC_Code = cgiGet( "Z564BR_Comorbidity_HapetitisC_Code");
               n564BR_Comorbidity_HapetitisC_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A564BR_Comorbidity_HapetitisC_Code)) ? true : false);
               Z565BR_Comorbidity_LiverCirrhosis = cgiGet( "Z565BR_Comorbidity_LiverCirrhosis");
               n565BR_Comorbidity_LiverCirrhosis = (String.IsNullOrEmpty(StringUtil.RTrim( A565BR_Comorbidity_LiverCirrhosis)) ? true : false);
               Z566BR_Comorbidity_LiverCirrhosis_Code = cgiGet( "Z566BR_Comorbidity_LiverCirrhosis_Code");
               n566BR_Comorbidity_LiverCirrhosis_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A566BR_Comorbidity_LiverCirrhosis_Code)) ? true : false);
               Z567BR_Comorbidity_Druginducedliverinjury = cgiGet( "Z567BR_Comorbidity_Druginducedliverinjury");
               n567BR_Comorbidity_Druginducedliverinjury = (String.IsNullOrEmpty(StringUtil.RTrim( A567BR_Comorbidity_Druginducedliverinjury)) ? true : false);
               Z568BR_Comorbidity_Druginducedliverinjury_Code = cgiGet( "Z568BR_Comorbidity_Druginducedliverinjury_Code");
               n568BR_Comorbidity_Druginducedliverinjury_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A568BR_Comorbidity_Druginducedliverinjury_Code)) ? true : false);
               Z19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( "Z19BR_EncounterID"), ".", ","));
               A487BR_Comorbidity_Hypertension_Code = cgiGet( "Z487BR_Comorbidity_Hypertension_Code");
               n487BR_Comorbidity_Hypertension_Code = false;
               n487BR_Comorbidity_Hypertension_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A487BR_Comorbidity_Hypertension_Code)) ? true : false);
               A488BR_Comorbidity_Diabetes_Code = cgiGet( "Z488BR_Comorbidity_Diabetes_Code");
               n488BR_Comorbidity_Diabetes_Code = false;
               n488BR_Comorbidity_Diabetes_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A488BR_Comorbidity_Diabetes_Code)) ? true : false);
               A489BR_Comorbidity_CHD_Code = cgiGet( "Z489BR_Comorbidity_CHD_Code");
               n489BR_Comorbidity_CHD_Code = false;
               n489BR_Comorbidity_CHD_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A489BR_Comorbidity_CHD_Code)) ? true : false);
               A490BR_Comorbidity_Hapetitis_Code = cgiGet( "Z490BR_Comorbidity_Hapetitis_Code");
               n490BR_Comorbidity_Hapetitis_Code = false;
               n490BR_Comorbidity_Hapetitis_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A490BR_Comorbidity_Hapetitis_Code)) ? true : false);
               A491BR_Comorbidity_TB_Code = cgiGet( "Z491BR_Comorbidity_TB_Code");
               n491BR_Comorbidity_TB_Code = false;
               n491BR_Comorbidity_TB_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A491BR_Comorbidity_TB_Code)) ? true : false);
               A492BR_Comorbidity_KidneyDisease_Code = cgiGet( "Z492BR_Comorbidity_KidneyDisease_Code");
               n492BR_Comorbidity_KidneyDisease_Code = false;
               n492BR_Comorbidity_KidneyDisease_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A492BR_Comorbidity_KidneyDisease_Code)) ? true : false);
               A493BR_Comorbidity_SurgeryHistory_Code = cgiGet( "Z493BR_Comorbidity_SurgeryHistory_Code");
               n493BR_Comorbidity_SurgeryHistory_Code = false;
               n493BR_Comorbidity_SurgeryHistory_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A493BR_Comorbidity_SurgeryHistory_Code)) ? true : false);
               A494BR_Comorbidity_InjuryHistory_Code = cgiGet( "Z494BR_Comorbidity_InjuryHistory_Code");
               n494BR_Comorbidity_InjuryHistory_Code = false;
               n494BR_Comorbidity_InjuryHistory_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A494BR_Comorbidity_InjuryHistory_Code)) ? true : false);
               A495BR_Comorbidity_BloodHistory_Code = cgiGet( "Z495BR_Comorbidity_BloodHistory_Code");
               n495BR_Comorbidity_BloodHistory_Code = false;
               n495BR_Comorbidity_BloodHistory_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A495BR_Comorbidity_BloodHistory_Code)) ? true : false);
               A496BR_Comorbidity_allergy_Code = cgiGet( "Z496BR_Comorbidity_allergy_Code");
               n496BR_Comorbidity_allergy_Code = false;
               n496BR_Comorbidity_allergy_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A496BR_Comorbidity_allergy_Code)) ? true : false);
               A259BR_Comorbidity_Others = cgiGet( "Z259BR_Comorbidity_Others");
               n259BR_Comorbidity_Others = false;
               n259BR_Comorbidity_Others = (String.IsNullOrEmpty(StringUtil.RTrim( A259BR_Comorbidity_Others)) ? true : false);
               A561BR_Comorbidity_HapetitisB = cgiGet( "Z561BR_Comorbidity_HapetitisB");
               n561BR_Comorbidity_HapetitisB = false;
               n561BR_Comorbidity_HapetitisB = (String.IsNullOrEmpty(StringUtil.RTrim( A561BR_Comorbidity_HapetitisB)) ? true : false);
               A562BR_Comorbidity_HapetitisB_Code = cgiGet( "Z562BR_Comorbidity_HapetitisB_Code");
               n562BR_Comorbidity_HapetitisB_Code = false;
               n562BR_Comorbidity_HapetitisB_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A562BR_Comorbidity_HapetitisB_Code)) ? true : false);
               A563BR_Comorbidity_HapetitisC = cgiGet( "Z563BR_Comorbidity_HapetitisC");
               n563BR_Comorbidity_HapetitisC = false;
               n563BR_Comorbidity_HapetitisC = (String.IsNullOrEmpty(StringUtil.RTrim( A563BR_Comorbidity_HapetitisC)) ? true : false);
               A564BR_Comorbidity_HapetitisC_Code = cgiGet( "Z564BR_Comorbidity_HapetitisC_Code");
               n564BR_Comorbidity_HapetitisC_Code = false;
               n564BR_Comorbidity_HapetitisC_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A564BR_Comorbidity_HapetitisC_Code)) ? true : false);
               A565BR_Comorbidity_LiverCirrhosis = cgiGet( "Z565BR_Comorbidity_LiverCirrhosis");
               n565BR_Comorbidity_LiverCirrhosis = false;
               n565BR_Comorbidity_LiverCirrhosis = (String.IsNullOrEmpty(StringUtil.RTrim( A565BR_Comorbidity_LiverCirrhosis)) ? true : false);
               A566BR_Comorbidity_LiverCirrhosis_Code = cgiGet( "Z566BR_Comorbidity_LiverCirrhosis_Code");
               n566BR_Comorbidity_LiverCirrhosis_Code = false;
               n566BR_Comorbidity_LiverCirrhosis_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A566BR_Comorbidity_LiverCirrhosis_Code)) ? true : false);
               A567BR_Comorbidity_Druginducedliverinjury = cgiGet( "Z567BR_Comorbidity_Druginducedliverinjury");
               n567BR_Comorbidity_Druginducedliverinjury = false;
               n567BR_Comorbidity_Druginducedliverinjury = (String.IsNullOrEmpty(StringUtil.RTrim( A567BR_Comorbidity_Druginducedliverinjury)) ? true : false);
               A568BR_Comorbidity_Druginducedliverinjury_Code = cgiGet( "Z568BR_Comorbidity_Druginducedliverinjury_Code");
               n568BR_Comorbidity_Druginducedliverinjury_Code = false;
               n568BR_Comorbidity_Druginducedliverinjury_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A568BR_Comorbidity_Druginducedliverinjury_Code)) ? true : false);
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
               Gx_mode = cgiGet( "Mode");
               A487BR_Comorbidity_Hypertension_Code = cgiGet( "BR_COMORBIDITY_HYPERTENSION_CODE");
               n487BR_Comorbidity_Hypertension_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A487BR_Comorbidity_Hypertension_Code)) ? true : false);
               A488BR_Comorbidity_Diabetes_Code = cgiGet( "BR_COMORBIDITY_DIABETES_CODE");
               n488BR_Comorbidity_Diabetes_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A488BR_Comorbidity_Diabetes_Code)) ? true : false);
               A489BR_Comorbidity_CHD_Code = cgiGet( "BR_COMORBIDITY_CHD_CODE");
               n489BR_Comorbidity_CHD_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A489BR_Comorbidity_CHD_Code)) ? true : false);
               A490BR_Comorbidity_Hapetitis_Code = cgiGet( "BR_COMORBIDITY_HAPETITIS_CODE");
               n490BR_Comorbidity_Hapetitis_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A490BR_Comorbidity_Hapetitis_Code)) ? true : false);
               A491BR_Comorbidity_TB_Code = cgiGet( "BR_COMORBIDITY_TB_CODE");
               n491BR_Comorbidity_TB_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A491BR_Comorbidity_TB_Code)) ? true : false);
               A492BR_Comorbidity_KidneyDisease_Code = cgiGet( "BR_COMORBIDITY_KIDNEYDISEASE_CODE");
               n492BR_Comorbidity_KidneyDisease_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A492BR_Comorbidity_KidneyDisease_Code)) ? true : false);
               A493BR_Comorbidity_SurgeryHistory_Code = cgiGet( "BR_COMORBIDITY_SURGERYHISTORY_CODE");
               n493BR_Comorbidity_SurgeryHistory_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A493BR_Comorbidity_SurgeryHistory_Code)) ? true : false);
               A494BR_Comorbidity_InjuryHistory_Code = cgiGet( "BR_COMORBIDITY_INJURYHISTORY_CODE");
               n494BR_Comorbidity_InjuryHistory_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A494BR_Comorbidity_InjuryHistory_Code)) ? true : false);
               A495BR_Comorbidity_BloodHistory_Code = cgiGet( "BR_COMORBIDITY_BLOODHISTORY_CODE");
               n495BR_Comorbidity_BloodHistory_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A495BR_Comorbidity_BloodHistory_Code)) ? true : false);
               A496BR_Comorbidity_allergy_Code = cgiGet( "BR_COMORBIDITY_ALLERGY_CODE");
               n496BR_Comorbidity_allergy_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A496BR_Comorbidity_allergy_Code)) ? true : false);
               A259BR_Comorbidity_Others = cgiGet( "BR_COMORBIDITY_OTHERS");
               n259BR_Comorbidity_Others = (String.IsNullOrEmpty(StringUtil.RTrim( A259BR_Comorbidity_Others)) ? true : false);
               A561BR_Comorbidity_HapetitisB = cgiGet( "BR_COMORBIDITY_HAPETITISB");
               n561BR_Comorbidity_HapetitisB = (String.IsNullOrEmpty(StringUtil.RTrim( A561BR_Comorbidity_HapetitisB)) ? true : false);
               A562BR_Comorbidity_HapetitisB_Code = cgiGet( "BR_COMORBIDITY_HAPETITISB_CODE");
               n562BR_Comorbidity_HapetitisB_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A562BR_Comorbidity_HapetitisB_Code)) ? true : false);
               A563BR_Comorbidity_HapetitisC = cgiGet( "BR_COMORBIDITY_HAPETITISC");
               n563BR_Comorbidity_HapetitisC = (String.IsNullOrEmpty(StringUtil.RTrim( A563BR_Comorbidity_HapetitisC)) ? true : false);
               A564BR_Comorbidity_HapetitisC_Code = cgiGet( "BR_COMORBIDITY_HAPETITISC_CODE");
               n564BR_Comorbidity_HapetitisC_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A564BR_Comorbidity_HapetitisC_Code)) ? true : false);
               A565BR_Comorbidity_LiverCirrhosis = cgiGet( "BR_COMORBIDITY_LIVERCIRRHOSIS");
               n565BR_Comorbidity_LiverCirrhosis = (String.IsNullOrEmpty(StringUtil.RTrim( A565BR_Comorbidity_LiverCirrhosis)) ? true : false);
               A566BR_Comorbidity_LiverCirrhosis_Code = cgiGet( "BR_COMORBIDITY_LIVERCIRRHOSIS_CODE");
               n566BR_Comorbidity_LiverCirrhosis_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A566BR_Comorbidity_LiverCirrhosis_Code)) ? true : false);
               A567BR_Comorbidity_Druginducedliverinjury = cgiGet( "BR_COMORBIDITY_DRUGINDUCEDLIVERINJURY");
               n567BR_Comorbidity_Druginducedliverinjury = (String.IsNullOrEmpty(StringUtil.RTrim( A567BR_Comorbidity_Druginducedliverinjury)) ? true : false);
               A568BR_Comorbidity_Druginducedliverinjury_Code = cgiGet( "BR_COMORBIDITY_DRUGINDUCEDLIVERINJURY_CODE");
               n568BR_Comorbidity_Druginducedliverinjury_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A568BR_Comorbidity_Druginducedliverinjury_Code)) ? true : false);
               A85BR_Information_ID = (long)(context.localUtil.CToN( cgiGet( "BR_INFORMATION_ID"), ".", ","));
               A36BR_Information_PatientNo = cgiGet( "BR_INFORMATION_PATIENTNO");
               n36BR_Information_PatientNo = false;
               Gx_mode = cgiGet( "vMODE");
               Dvpanel_tableattributes_Objectcall = cgiGet( "DVPANEL_TABLEATTRIBUTES_Objectcall");
               Dvpanel_tableattributes_Class = cgiGet( "DVPANEL_TABLEATTRIBUTES_Class");
               Dvpanel_tableattributes_Enabled = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Enabled"));
               Dvpanel_tableattributes_Width = cgiGet( "DVPANEL_TABLEATTRIBUTES_Width");
               Dvpanel_tableattributes_Height = cgiGet( "DVPANEL_TABLEATTRIBUTES_Height");
               Dvpanel_tableattributes_Cls = cgiGet( "DVPANEL_TABLEATTRIBUTES_Cls");
               Dvpanel_tableattributes_Title = cgiGet( "DVPANEL_TABLEATTRIBUTES_Title");
               Dvpanel_tableattributes_Collapsible = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Collapsible"));
               Dvpanel_tableattributes_Collapsed = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Collapsed"));
               Dvpanel_tableattributes_Autowidth = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Autowidth"));
               Dvpanel_tableattributes_Autoheight = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Autoheight"));
               Dvpanel_tableattributes_Showheader = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Showheader"));
               Dvpanel_tableattributes_Showcollapseicon = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Showcollapseicon"));
               Dvpanel_tableattributes_Iconposition = cgiGet( "DVPANEL_TABLEATTRIBUTES_Iconposition");
               Dvpanel_tableattributes_Autoscroll = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Autoscroll"));
               Dvpanel_tableattributes_Visible = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Visible"));
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "BR_Comorbidity";
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A259BR_Comorbidity_Others, ""));
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A561BR_Comorbidity_HapetitisB, ""));
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A562BR_Comorbidity_HapetitisB_Code, ""));
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A563BR_Comorbidity_HapetitisC, ""));
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A564BR_Comorbidity_HapetitisC_Code, ""));
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A565BR_Comorbidity_LiverCirrhosis, ""));
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A566BR_Comorbidity_LiverCirrhosis_Code, ""));
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A567BR_Comorbidity_Druginducedliverinjury, ""));
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A568BR_Comorbidity_Druginducedliverinjury_Code, ""));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A37BR_ComorbidityID != Z37BR_ComorbidityID ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("br_comorbidity:[SecurityCheckFailed value for]"+"BR_Comorbidity_Others:"+StringUtil.RTrim( context.localUtil.Format( A259BR_Comorbidity_Others, "")));
                  GXUtil.WriteLog("br_comorbidity:[SecurityCheckFailed value for]"+"BR_Comorbidity_HapetitisB:"+StringUtil.RTrim( context.localUtil.Format( A561BR_Comorbidity_HapetitisB, "")));
                  GXUtil.WriteLog("br_comorbidity:[SecurityCheckFailed value for]"+"BR_Comorbidity_HapetitisB_Code:"+StringUtil.RTrim( context.localUtil.Format( A562BR_Comorbidity_HapetitisB_Code, "")));
                  GXUtil.WriteLog("br_comorbidity:[SecurityCheckFailed value for]"+"BR_Comorbidity_HapetitisC:"+StringUtil.RTrim( context.localUtil.Format( A563BR_Comorbidity_HapetitisC, "")));
                  GXUtil.WriteLog("br_comorbidity:[SecurityCheckFailed value for]"+"BR_Comorbidity_HapetitisC_Code:"+StringUtil.RTrim( context.localUtil.Format( A564BR_Comorbidity_HapetitisC_Code, "")));
                  GXUtil.WriteLog("br_comorbidity:[SecurityCheckFailed value for]"+"BR_Comorbidity_LiverCirrhosis:"+StringUtil.RTrim( context.localUtil.Format( A565BR_Comorbidity_LiverCirrhosis, "")));
                  GXUtil.WriteLog("br_comorbidity:[SecurityCheckFailed value for]"+"BR_Comorbidity_LiverCirrhosis_Code:"+StringUtil.RTrim( context.localUtil.Format( A566BR_Comorbidity_LiverCirrhosis_Code, "")));
                  GXUtil.WriteLog("br_comorbidity:[SecurityCheckFailed value for]"+"BR_Comorbidity_Druginducedliverinjury:"+StringUtil.RTrim( context.localUtil.Format( A567BR_Comorbidity_Druginducedliverinjury, "")));
                  GXUtil.WriteLog("br_comorbidity:[SecurityCheckFailed value for]"+"BR_Comorbidity_Druginducedliverinjury_Code:"+StringUtil.RTrim( context.localUtil.Format( A568BR_Comorbidity_Druginducedliverinjury_Code, "")));
                  GxWebError = 1;
                  context.HttpContext.Response.StatusDescription = 403.ToString();
                  context.HttpContext.Response.StatusCode = 403;
                  context.WriteHtmlText( "<title>403 Forbidden</title>") ;
                  context.WriteHtmlText( "<h1>403 Forbidden</h1>") ;
                  context.WriteHtmlText( "<p /><hr />") ;
                  GXUtil.WriteLog("send_http_error_code " + 403.ToString());
                  AnyError = 1;
                  return  ;
               }
               standaloneNotModal( ) ;
            }
            else
            {
               standaloneNotModal( ) ;
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") == 0 )
               {
                  Gx_mode = "DSP";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  A37BR_ComorbidityID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37BR_ComorbidityID", StringUtil.LTrim( StringUtil.Str( (decimal)(A37BR_ComorbidityID), 18, 0)));
                  getEqualNoModal( ) ;
                  Gx_mode = "DSP";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  disable_std_buttons_dsp( ) ;
                  standaloneModal( ) ;
               }
               else
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  standaloneModal( ) ;
               }
            }
         }
      }

      protected void Process( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read Transaction buttons. */
            sEvt = cgiGet( "_EventName");
            EvtGridId = cgiGet( "_EventGridId");
            EvtRowId = cgiGet( "_EventRowId");
            if ( StringUtil.Len( sEvt) > 0 )
            {
               sEvtType = StringUtil.Left( sEvt, 1);
               sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1));
               if ( StringUtil.StrCmp(sEvtType, "M") != 0 )
               {
                  if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                  {
                     sEvtType = StringUtil.Right( sEvt, 1);
                     if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                     {
                        sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                        if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: Start */
                           E11092 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E12092 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_enter( ) ;
                           /* No code required for Cancel button. It is implemented as the Reset button. */
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DELETE") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_delete( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                        {
                           context.wbHandled = 1;
                           AfterKeyLoadScreen( ) ;
                        }
                     }
                     else
                     {
                     }
                  }
                  context.wbHandled = 1;
               }
            }
         }
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E12092 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0910( ) ;
               standaloneNotModal( ) ;
               standaloneModal( ) ;
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

      protected void disable_std_buttons( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            bttBtntrn_delete_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_delete_Enabled), 5, 0)), true);
         }
      }

      protected void disable_std_buttons_dsp( )
      {
         bttBtntrn_delete_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_delete_Visible), 5, 0)), true);
         bttBtntrn_delete_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_delete_Visible), 5, 0)), true);
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            bttBtntrn_enter_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_enter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_enter_Visible), 5, 0)), true);
         }
         DisableAttributes0910( ) ;
      }

      protected void set_caption( )
      {
         if ( ( IsConfirmed == 1 ) && ( AnyError == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_confdelete", ""), 0, "", true);
            }
            else
            {
               GX_msglist.addItem(context.GetMessage( "GXM_mustconfirm", ""), 0, "", true);
            }
         }
      }

      protected void ResetCaption090( )
      {
      }

      protected void E11092( )
      {
         /* Start Routine */
      }

      protected void E12092( )
      {
         /* After Trn Routine */
      }

      protected void ZM0910( short GX_JID )
      {
         if ( ( GX_JID == 31 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z487BR_Comorbidity_Hypertension_Code = T00093_A487BR_Comorbidity_Hypertension_Code[0];
               Z488BR_Comorbidity_Diabetes_Code = T00093_A488BR_Comorbidity_Diabetes_Code[0];
               Z489BR_Comorbidity_CHD_Code = T00093_A489BR_Comorbidity_CHD_Code[0];
               Z490BR_Comorbidity_Hapetitis_Code = T00093_A490BR_Comorbidity_Hapetitis_Code[0];
               Z491BR_Comorbidity_TB_Code = T00093_A491BR_Comorbidity_TB_Code[0];
               Z492BR_Comorbidity_KidneyDisease_Code = T00093_A492BR_Comorbidity_KidneyDisease_Code[0];
               Z493BR_Comorbidity_SurgeryHistory_Code = T00093_A493BR_Comorbidity_SurgeryHistory_Code[0];
               Z494BR_Comorbidity_InjuryHistory_Code = T00093_A494BR_Comorbidity_InjuryHistory_Code[0];
               Z495BR_Comorbidity_BloodHistory_Code = T00093_A495BR_Comorbidity_BloodHistory_Code[0];
               Z496BR_Comorbidity_allergy_Code = T00093_A496BR_Comorbidity_allergy_Code[0];
               Z38BR_Comorbidity_Hypertension = T00093_A38BR_Comorbidity_Hypertension[0];
               Z39BR_Comorbidity_Diabetes = T00093_A39BR_Comorbidity_Diabetes[0];
               Z40BR_Comorbidity_CHD = T00093_A40BR_Comorbidity_CHD[0];
               Z41BR_Comorbidity_Hapetitis = T00093_A41BR_Comorbidity_Hapetitis[0];
               Z42BR_Comorbidity_TB = T00093_A42BR_Comorbidity_TB[0];
               Z43BR_Comorbidity_KidneyDisease = T00093_A43BR_Comorbidity_KidneyDisease[0];
               Z44BR_Comorbidity_SurgeryHistory = T00093_A44BR_Comorbidity_SurgeryHistory[0];
               Z45BR_Comorbidity_InjuryHistory = T00093_A45BR_Comorbidity_InjuryHistory[0];
               Z46BR_Comorbidity_BloodHistory = T00093_A46BR_Comorbidity_BloodHistory[0];
               Z47BR_Comorbidity_allergy = T00093_A47BR_Comorbidity_allergy[0];
               Z259BR_Comorbidity_Others = T00093_A259BR_Comorbidity_Others[0];
               Z561BR_Comorbidity_HapetitisB = T00093_A561BR_Comorbidity_HapetitisB[0];
               Z562BR_Comorbidity_HapetitisB_Code = T00093_A562BR_Comorbidity_HapetitisB_Code[0];
               Z563BR_Comorbidity_HapetitisC = T00093_A563BR_Comorbidity_HapetitisC[0];
               Z564BR_Comorbidity_HapetitisC_Code = T00093_A564BR_Comorbidity_HapetitisC_Code[0];
               Z565BR_Comorbidity_LiverCirrhosis = T00093_A565BR_Comorbidity_LiverCirrhosis[0];
               Z566BR_Comorbidity_LiverCirrhosis_Code = T00093_A566BR_Comorbidity_LiverCirrhosis_Code[0];
               Z567BR_Comorbidity_Druginducedliverinjury = T00093_A567BR_Comorbidity_Druginducedliverinjury[0];
               Z568BR_Comorbidity_Druginducedliverinjury_Code = T00093_A568BR_Comorbidity_Druginducedliverinjury_Code[0];
               Z19BR_EncounterID = T00093_A19BR_EncounterID[0];
            }
            else
            {
               Z487BR_Comorbidity_Hypertension_Code = A487BR_Comorbidity_Hypertension_Code;
               Z488BR_Comorbidity_Diabetes_Code = A488BR_Comorbidity_Diabetes_Code;
               Z489BR_Comorbidity_CHD_Code = A489BR_Comorbidity_CHD_Code;
               Z490BR_Comorbidity_Hapetitis_Code = A490BR_Comorbidity_Hapetitis_Code;
               Z491BR_Comorbidity_TB_Code = A491BR_Comorbidity_TB_Code;
               Z492BR_Comorbidity_KidneyDisease_Code = A492BR_Comorbidity_KidneyDisease_Code;
               Z493BR_Comorbidity_SurgeryHistory_Code = A493BR_Comorbidity_SurgeryHistory_Code;
               Z494BR_Comorbidity_InjuryHistory_Code = A494BR_Comorbidity_InjuryHistory_Code;
               Z495BR_Comorbidity_BloodHistory_Code = A495BR_Comorbidity_BloodHistory_Code;
               Z496BR_Comorbidity_allergy_Code = A496BR_Comorbidity_allergy_Code;
               Z38BR_Comorbidity_Hypertension = A38BR_Comorbidity_Hypertension;
               Z39BR_Comorbidity_Diabetes = A39BR_Comorbidity_Diabetes;
               Z40BR_Comorbidity_CHD = A40BR_Comorbidity_CHD;
               Z41BR_Comorbidity_Hapetitis = A41BR_Comorbidity_Hapetitis;
               Z42BR_Comorbidity_TB = A42BR_Comorbidity_TB;
               Z43BR_Comorbidity_KidneyDisease = A43BR_Comorbidity_KidneyDisease;
               Z44BR_Comorbidity_SurgeryHistory = A44BR_Comorbidity_SurgeryHistory;
               Z45BR_Comorbidity_InjuryHistory = A45BR_Comorbidity_InjuryHistory;
               Z46BR_Comorbidity_BloodHistory = A46BR_Comorbidity_BloodHistory;
               Z47BR_Comorbidity_allergy = A47BR_Comorbidity_allergy;
               Z259BR_Comorbidity_Others = A259BR_Comorbidity_Others;
               Z561BR_Comorbidity_HapetitisB = A561BR_Comorbidity_HapetitisB;
               Z562BR_Comorbidity_HapetitisB_Code = A562BR_Comorbidity_HapetitisB_Code;
               Z563BR_Comorbidity_HapetitisC = A563BR_Comorbidity_HapetitisC;
               Z564BR_Comorbidity_HapetitisC_Code = A564BR_Comorbidity_HapetitisC_Code;
               Z565BR_Comorbidity_LiverCirrhosis = A565BR_Comorbidity_LiverCirrhosis;
               Z566BR_Comorbidity_LiverCirrhosis_Code = A566BR_Comorbidity_LiverCirrhosis_Code;
               Z567BR_Comorbidity_Druginducedliverinjury = A567BR_Comorbidity_Druginducedliverinjury;
               Z568BR_Comorbidity_Druginducedliverinjury_Code = A568BR_Comorbidity_Druginducedliverinjury_Code;
               Z19BR_EncounterID = A19BR_EncounterID;
            }
         }
         if ( GX_JID == -31 )
         {
            Z37BR_ComorbidityID = A37BR_ComorbidityID;
            Z487BR_Comorbidity_Hypertension_Code = A487BR_Comorbidity_Hypertension_Code;
            Z488BR_Comorbidity_Diabetes_Code = A488BR_Comorbidity_Diabetes_Code;
            Z489BR_Comorbidity_CHD_Code = A489BR_Comorbidity_CHD_Code;
            Z490BR_Comorbidity_Hapetitis_Code = A490BR_Comorbidity_Hapetitis_Code;
            Z491BR_Comorbidity_TB_Code = A491BR_Comorbidity_TB_Code;
            Z492BR_Comorbidity_KidneyDisease_Code = A492BR_Comorbidity_KidneyDisease_Code;
            Z493BR_Comorbidity_SurgeryHistory_Code = A493BR_Comorbidity_SurgeryHistory_Code;
            Z494BR_Comorbidity_InjuryHistory_Code = A494BR_Comorbidity_InjuryHistory_Code;
            Z495BR_Comorbidity_BloodHistory_Code = A495BR_Comorbidity_BloodHistory_Code;
            Z496BR_Comorbidity_allergy_Code = A496BR_Comorbidity_allergy_Code;
            Z38BR_Comorbidity_Hypertension = A38BR_Comorbidity_Hypertension;
            Z39BR_Comorbidity_Diabetes = A39BR_Comorbidity_Diabetes;
            Z40BR_Comorbidity_CHD = A40BR_Comorbidity_CHD;
            Z41BR_Comorbidity_Hapetitis = A41BR_Comorbidity_Hapetitis;
            Z42BR_Comorbidity_TB = A42BR_Comorbidity_TB;
            Z43BR_Comorbidity_KidneyDisease = A43BR_Comorbidity_KidneyDisease;
            Z44BR_Comorbidity_SurgeryHistory = A44BR_Comorbidity_SurgeryHistory;
            Z45BR_Comorbidity_InjuryHistory = A45BR_Comorbidity_InjuryHistory;
            Z46BR_Comorbidity_BloodHistory = A46BR_Comorbidity_BloodHistory;
            Z47BR_Comorbidity_allergy = A47BR_Comorbidity_allergy;
            Z259BR_Comorbidity_Others = A259BR_Comorbidity_Others;
            Z561BR_Comorbidity_HapetitisB = A561BR_Comorbidity_HapetitisB;
            Z562BR_Comorbidity_HapetitisB_Code = A562BR_Comorbidity_HapetitisB_Code;
            Z563BR_Comorbidity_HapetitisC = A563BR_Comorbidity_HapetitisC;
            Z564BR_Comorbidity_HapetitisC_Code = A564BR_Comorbidity_HapetitisC_Code;
            Z565BR_Comorbidity_LiverCirrhosis = A565BR_Comorbidity_LiverCirrhosis;
            Z566BR_Comorbidity_LiverCirrhosis_Code = A566BR_Comorbidity_LiverCirrhosis_Code;
            Z567BR_Comorbidity_Druginducedliverinjury = A567BR_Comorbidity_Druginducedliverinjury;
            Z568BR_Comorbidity_Druginducedliverinjury_Code = A568BR_Comorbidity_Druginducedliverinjury_Code;
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
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            bttBtntrn_delete_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_delete_Enabled), 5, 0)), true);
         }
         else
         {
            bttBtntrn_delete_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_delete_Enabled), 5, 0)), true);
         }
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            bttBtntrn_enter_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_enter_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_enter_Enabled), 5, 0)), true);
         }
         else
         {
            bttBtntrn_enter_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_enter_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_enter_Enabled), 5, 0)), true);
         }
      }

      protected void Load0910( )
      {
         /* Using cursor T00096 */
         pr_default.execute(4, new Object[] {A37BR_ComorbidityID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound10 = 1;
            A85BR_Information_ID = T00096_A85BR_Information_ID[0];
            n85BR_Information_ID = T00096_n85BR_Information_ID[0];
            A487BR_Comorbidity_Hypertension_Code = T00096_A487BR_Comorbidity_Hypertension_Code[0];
            n487BR_Comorbidity_Hypertension_Code = T00096_n487BR_Comorbidity_Hypertension_Code[0];
            A488BR_Comorbidity_Diabetes_Code = T00096_A488BR_Comorbidity_Diabetes_Code[0];
            n488BR_Comorbidity_Diabetes_Code = T00096_n488BR_Comorbidity_Diabetes_Code[0];
            A489BR_Comorbidity_CHD_Code = T00096_A489BR_Comorbidity_CHD_Code[0];
            n489BR_Comorbidity_CHD_Code = T00096_n489BR_Comorbidity_CHD_Code[0];
            A490BR_Comorbidity_Hapetitis_Code = T00096_A490BR_Comorbidity_Hapetitis_Code[0];
            n490BR_Comorbidity_Hapetitis_Code = T00096_n490BR_Comorbidity_Hapetitis_Code[0];
            A491BR_Comorbidity_TB_Code = T00096_A491BR_Comorbidity_TB_Code[0];
            n491BR_Comorbidity_TB_Code = T00096_n491BR_Comorbidity_TB_Code[0];
            A492BR_Comorbidity_KidneyDisease_Code = T00096_A492BR_Comorbidity_KidneyDisease_Code[0];
            n492BR_Comorbidity_KidneyDisease_Code = T00096_n492BR_Comorbidity_KidneyDisease_Code[0];
            A493BR_Comorbidity_SurgeryHistory_Code = T00096_A493BR_Comorbidity_SurgeryHistory_Code[0];
            n493BR_Comorbidity_SurgeryHistory_Code = T00096_n493BR_Comorbidity_SurgeryHistory_Code[0];
            A494BR_Comorbidity_InjuryHistory_Code = T00096_A494BR_Comorbidity_InjuryHistory_Code[0];
            n494BR_Comorbidity_InjuryHistory_Code = T00096_n494BR_Comorbidity_InjuryHistory_Code[0];
            A495BR_Comorbidity_BloodHistory_Code = T00096_A495BR_Comorbidity_BloodHistory_Code[0];
            n495BR_Comorbidity_BloodHistory_Code = T00096_n495BR_Comorbidity_BloodHistory_Code[0];
            A496BR_Comorbidity_allergy_Code = T00096_A496BR_Comorbidity_allergy_Code[0];
            n496BR_Comorbidity_allergy_Code = T00096_n496BR_Comorbidity_allergy_Code[0];
            A36BR_Information_PatientNo = T00096_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = T00096_n36BR_Information_PatientNo[0];
            A38BR_Comorbidity_Hypertension = T00096_A38BR_Comorbidity_Hypertension[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38BR_Comorbidity_Hypertension", A38BR_Comorbidity_Hypertension);
            n38BR_Comorbidity_Hypertension = T00096_n38BR_Comorbidity_Hypertension[0];
            A39BR_Comorbidity_Diabetes = T00096_A39BR_Comorbidity_Diabetes[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39BR_Comorbidity_Diabetes", A39BR_Comorbidity_Diabetes);
            n39BR_Comorbidity_Diabetes = T00096_n39BR_Comorbidity_Diabetes[0];
            A40BR_Comorbidity_CHD = T00096_A40BR_Comorbidity_CHD[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40BR_Comorbidity_CHD", A40BR_Comorbidity_CHD);
            n40BR_Comorbidity_CHD = T00096_n40BR_Comorbidity_CHD[0];
            A41BR_Comorbidity_Hapetitis = T00096_A41BR_Comorbidity_Hapetitis[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41BR_Comorbidity_Hapetitis", A41BR_Comorbidity_Hapetitis);
            n41BR_Comorbidity_Hapetitis = T00096_n41BR_Comorbidity_Hapetitis[0];
            A42BR_Comorbidity_TB = T00096_A42BR_Comorbidity_TB[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BR_Comorbidity_TB", A42BR_Comorbidity_TB);
            n42BR_Comorbidity_TB = T00096_n42BR_Comorbidity_TB[0];
            A43BR_Comorbidity_KidneyDisease = T00096_A43BR_Comorbidity_KidneyDisease[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43BR_Comorbidity_KidneyDisease", A43BR_Comorbidity_KidneyDisease);
            n43BR_Comorbidity_KidneyDisease = T00096_n43BR_Comorbidity_KidneyDisease[0];
            A44BR_Comorbidity_SurgeryHistory = T00096_A44BR_Comorbidity_SurgeryHistory[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44BR_Comorbidity_SurgeryHistory", A44BR_Comorbidity_SurgeryHistory);
            n44BR_Comorbidity_SurgeryHistory = T00096_n44BR_Comorbidity_SurgeryHistory[0];
            A45BR_Comorbidity_InjuryHistory = T00096_A45BR_Comorbidity_InjuryHistory[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A45BR_Comorbidity_InjuryHistory", A45BR_Comorbidity_InjuryHistory);
            n45BR_Comorbidity_InjuryHistory = T00096_n45BR_Comorbidity_InjuryHistory[0];
            A46BR_Comorbidity_BloodHistory = T00096_A46BR_Comorbidity_BloodHistory[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46BR_Comorbidity_BloodHistory", A46BR_Comorbidity_BloodHistory);
            n46BR_Comorbidity_BloodHistory = T00096_n46BR_Comorbidity_BloodHistory[0];
            A47BR_Comorbidity_allergy = T00096_A47BR_Comorbidity_allergy[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A47BR_Comorbidity_allergy", A47BR_Comorbidity_allergy);
            n47BR_Comorbidity_allergy = T00096_n47BR_Comorbidity_allergy[0];
            A259BR_Comorbidity_Others = T00096_A259BR_Comorbidity_Others[0];
            n259BR_Comorbidity_Others = T00096_n259BR_Comorbidity_Others[0];
            A561BR_Comorbidity_HapetitisB = T00096_A561BR_Comorbidity_HapetitisB[0];
            n561BR_Comorbidity_HapetitisB = T00096_n561BR_Comorbidity_HapetitisB[0];
            A562BR_Comorbidity_HapetitisB_Code = T00096_A562BR_Comorbidity_HapetitisB_Code[0];
            n562BR_Comorbidity_HapetitisB_Code = T00096_n562BR_Comorbidity_HapetitisB_Code[0];
            A563BR_Comorbidity_HapetitisC = T00096_A563BR_Comorbidity_HapetitisC[0];
            n563BR_Comorbidity_HapetitisC = T00096_n563BR_Comorbidity_HapetitisC[0];
            A564BR_Comorbidity_HapetitisC_Code = T00096_A564BR_Comorbidity_HapetitisC_Code[0];
            n564BR_Comorbidity_HapetitisC_Code = T00096_n564BR_Comorbidity_HapetitisC_Code[0];
            A565BR_Comorbidity_LiverCirrhosis = T00096_A565BR_Comorbidity_LiverCirrhosis[0];
            n565BR_Comorbidity_LiverCirrhosis = T00096_n565BR_Comorbidity_LiverCirrhosis[0];
            A566BR_Comorbidity_LiverCirrhosis_Code = T00096_A566BR_Comorbidity_LiverCirrhosis_Code[0];
            n566BR_Comorbidity_LiverCirrhosis_Code = T00096_n566BR_Comorbidity_LiverCirrhosis_Code[0];
            A567BR_Comorbidity_Druginducedliverinjury = T00096_A567BR_Comorbidity_Druginducedliverinjury[0];
            n567BR_Comorbidity_Druginducedliverinjury = T00096_n567BR_Comorbidity_Druginducedliverinjury[0];
            A568BR_Comorbidity_Druginducedliverinjury_Code = T00096_A568BR_Comorbidity_Druginducedliverinjury_Code[0];
            n568BR_Comorbidity_Druginducedliverinjury_Code = T00096_n568BR_Comorbidity_Druginducedliverinjury_Code[0];
            A19BR_EncounterID = T00096_A19BR_EncounterID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
            ZM0910( -31) ;
         }
         pr_default.close(4);
         OnLoadActions0910( ) ;
      }

      protected void OnLoadActions0910( )
      {
      }

      protected void CheckExtendedTable0910( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         /* Using cursor T00094 */
         pr_default.execute(2, new Object[] {A19BR_EncounterID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("不匹配' T15'", "ForeignKeyNotFound", 1, "BR_ENCOUNTERID");
            AnyError = 1;
            GX_FocusControl = edtBR_EncounterID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A85BR_Information_ID = T00094_A85BR_Information_ID[0];
         n85BR_Information_ID = T00094_n85BR_Information_ID[0];
         pr_default.close(2);
         /* Using cursor T00095 */
         pr_default.execute(3, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
         if ( (pr_default.getStatus(3) == 101) )
         {
            if ( ! ( (0==A85BR_Information_ID) ) )
            {
               GX_msglist.addItem("不匹配' T16'", "ForeignKeyNotFound", 1, "");
               AnyError = 1;
            }
         }
         A36BR_Information_PatientNo = T00095_A36BR_Information_PatientNo[0];
         n36BR_Information_PatientNo = T00095_n36BR_Information_PatientNo[0];
         pr_default.close(3);
         if ( ! ( ( StringUtil.StrCmp(A38BR_Comorbidity_Hypertension, "否") == 0 ) || ( StringUtil.StrCmp(A38BR_Comorbidity_Hypertension, "是") == 0 ) || ( StringUtil.StrCmp(A38BR_Comorbidity_Hypertension, "不详") == 0 ) || String.IsNullOrEmpty(StringUtil.RTrim( A38BR_Comorbidity_Hypertension)) ) )
         {
            GX_msglist.addItem("域���������超界", "OutOfRange", 1, "BR_COMORBIDITY_HYPERTENSION");
            AnyError = 1;
            GX_FocusControl = cmbBR_Comorbidity_Hypertension_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ! ( ( StringUtil.StrCmp(A39BR_Comorbidity_Diabetes, "否") == 0 ) || ( StringUtil.StrCmp(A39BR_Comorbidity_Diabetes, "是") == 0 ) || ( StringUtil.StrCmp(A39BR_Comorbidity_Diabetes, "不详") == 0 ) || String.IsNullOrEmpty(StringUtil.RTrim( A39BR_Comorbidity_Diabetes)) ) )
         {
            GX_msglist.addItem("域���������超界", "OutOfRange", 1, "BR_COMORBIDITY_DIABETES");
            AnyError = 1;
            GX_FocusControl = cmbBR_Comorbidity_Diabetes_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ! ( ( StringUtil.StrCmp(A40BR_Comorbidity_CHD, "否") == 0 ) || ( StringUtil.StrCmp(A40BR_Comorbidity_CHD, "是") == 0 ) || ( StringUtil.StrCmp(A40BR_Comorbidity_CHD, "不详") == 0 ) || String.IsNullOrEmpty(StringUtil.RTrim( A40BR_Comorbidity_CHD)) ) )
         {
            GX_msglist.addItem("域���������超界", "OutOfRange", 1, "BR_COMORBIDITY_CHD");
            AnyError = 1;
            GX_FocusControl = cmbBR_Comorbidity_CHD_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ! ( ( StringUtil.StrCmp(A41BR_Comorbidity_Hapetitis, "否") == 0 ) || ( StringUtil.StrCmp(A41BR_Comorbidity_Hapetitis, "是") == 0 ) || ( StringUtil.StrCmp(A41BR_Comorbidity_Hapetitis, "不详") == 0 ) || String.IsNullOrEmpty(StringUtil.RTrim( A41BR_Comorbidity_Hapetitis)) ) )
         {
            GX_msglist.addItem("域������超界", "OutOfRange", 1, "BR_COMORBIDITY_HAPETITIS");
            AnyError = 1;
            GX_FocusControl = cmbBR_Comorbidity_Hapetitis_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ! ( ( StringUtil.StrCmp(A42BR_Comorbidity_TB, "否") == 0 ) || ( StringUtil.StrCmp(A42BR_Comorbidity_TB, "是") == 0 ) || ( StringUtil.StrCmp(A42BR_Comorbidity_TB, "不详") == 0 ) || String.IsNullOrEmpty(StringUtil.RTrim( A42BR_Comorbidity_TB)) ) )
         {
            GX_msglist.addItem("域���������超界", "OutOfRange", 1, "BR_COMORBIDITY_TB");
            AnyError = 1;
            GX_FocusControl = cmbBR_Comorbidity_TB_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ! ( ( StringUtil.StrCmp(A43BR_Comorbidity_KidneyDisease, "否") == 0 ) || ( StringUtil.StrCmp(A43BR_Comorbidity_KidneyDisease, "是") == 0 ) || ( StringUtil.StrCmp(A43BR_Comorbidity_KidneyDisease, "不详") == 0 ) || String.IsNullOrEmpty(StringUtil.RTrim( A43BR_Comorbidity_KidneyDisease)) ) )
         {
            GX_msglist.addItem("域������超界", "OutOfRange", 1, "BR_COMORBIDITY_KIDNEYDISEASE");
            AnyError = 1;
            GX_FocusControl = cmbBR_Comorbidity_KidneyDisease_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ! ( ( StringUtil.StrCmp(A44BR_Comorbidity_SurgeryHistory, "否") == 0 ) || ( StringUtil.StrCmp(A44BR_Comorbidity_SurgeryHistory, "是") == 0 ) || ( StringUtil.StrCmp(A44BR_Comorbidity_SurgeryHistory, "不详") == 0 ) || String.IsNullOrEmpty(StringUtil.RTrim( A44BR_Comorbidity_SurgeryHistory)) ) )
         {
            GX_msglist.addItem("域���������超界", "OutOfRange", 1, "BR_COMORBIDITY_SURGERYHISTORY");
            AnyError = 1;
            GX_FocusControl = cmbBR_Comorbidity_SurgeryHistory_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ! ( ( StringUtil.StrCmp(A45BR_Comorbidity_InjuryHistory, "否") == 0 ) || ( StringUtil.StrCmp(A45BR_Comorbidity_InjuryHistory, "是") == 0 ) || ( StringUtil.StrCmp(A45BR_Comorbidity_InjuryHistory, "不详") == 0 ) || String.IsNullOrEmpty(StringUtil.RTrim( A45BR_Comorbidity_InjuryHistory)) ) )
         {
            GX_msglist.addItem("域���������超界", "OutOfRange", 1, "BR_COMORBIDITY_INJURYHISTORY");
            AnyError = 1;
            GX_FocusControl = cmbBR_Comorbidity_InjuryHistory_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ! ( ( StringUtil.StrCmp(A46BR_Comorbidity_BloodHistory, "否") == 0 ) || ( StringUtil.StrCmp(A46BR_Comorbidity_BloodHistory, "是") == 0 ) || ( StringUtil.StrCmp(A46BR_Comorbidity_BloodHistory, "不详") == 0 ) || String.IsNullOrEmpty(StringUtil.RTrim( A46BR_Comorbidity_BloodHistory)) ) )
         {
            GX_msglist.addItem("域���������超界", "OutOfRange", 1, "BR_COMORBIDITY_BLOODHISTORY");
            AnyError = 1;
            GX_FocusControl = cmbBR_Comorbidity_BloodHistory_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ! ( ( StringUtil.StrCmp(A47BR_Comorbidity_allergy, "否") == 0 ) || ( StringUtil.StrCmp(A47BR_Comorbidity_allergy, "是") == 0 ) || ( StringUtil.StrCmp(A47BR_Comorbidity_allergy, "不详") == 0 ) || String.IsNullOrEmpty(StringUtil.RTrim( A47BR_Comorbidity_allergy)) ) )
         {
            GX_msglist.addItem("域���������超界", "OutOfRange", 1, "BR_COMORBIDITY_ALLERGY");
            AnyError = 1;
            GX_FocusControl = cmbBR_Comorbidity_allergy_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors0910( )
      {
         pr_default.close(2);
         pr_default.close(3);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_32( long A19BR_EncounterID )
      {
         /* Using cursor T00097 */
         pr_default.execute(5, new Object[] {A19BR_EncounterID});
         if ( (pr_default.getStatus(5) == 101) )
         {
            GX_msglist.addItem("不匹配' T15'", "ForeignKeyNotFound", 1, "BR_ENCOUNTERID");
            AnyError = 1;
            GX_FocusControl = edtBR_EncounterID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A85BR_Information_ID = T00097_A85BR_Information_ID[0];
         n85BR_Information_ID = T00097_n85BR_Information_ID[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A85BR_Information_ID), 18, 0, ".", "")))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(5) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(5);
      }

      protected void gxLoad_33( long A85BR_Information_ID )
      {
         /* Using cursor T00098 */
         pr_default.execute(6, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
         if ( (pr_default.getStatus(6) == 101) )
         {
            if ( ! ( (0==A85BR_Information_ID) ) )
            {
               GX_msglist.addItem("不匹配' T16'", "ForeignKeyNotFound", 1, "");
               AnyError = 1;
            }
         }
         A36BR_Information_PatientNo = T00098_A36BR_Information_PatientNo[0];
         n36BR_Information_PatientNo = T00098_n36BR_Information_PatientNo[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A36BR_Information_PatientNo)+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(6) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(6);
      }

      protected void GetKey0910( )
      {
         /* Using cursor T00099 */
         pr_default.execute(7, new Object[] {A37BR_ComorbidityID});
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound10 = 1;
         }
         else
         {
            RcdFound10 = 0;
         }
         pr_default.close(7);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00093 */
         pr_default.execute(1, new Object[] {A37BR_ComorbidityID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0910( 31) ;
            RcdFound10 = 1;
            A37BR_ComorbidityID = T00093_A37BR_ComorbidityID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37BR_ComorbidityID", StringUtil.LTrim( StringUtil.Str( (decimal)(A37BR_ComorbidityID), 18, 0)));
            A487BR_Comorbidity_Hypertension_Code = T00093_A487BR_Comorbidity_Hypertension_Code[0];
            n487BR_Comorbidity_Hypertension_Code = T00093_n487BR_Comorbidity_Hypertension_Code[0];
            A488BR_Comorbidity_Diabetes_Code = T00093_A488BR_Comorbidity_Diabetes_Code[0];
            n488BR_Comorbidity_Diabetes_Code = T00093_n488BR_Comorbidity_Diabetes_Code[0];
            A489BR_Comorbidity_CHD_Code = T00093_A489BR_Comorbidity_CHD_Code[0];
            n489BR_Comorbidity_CHD_Code = T00093_n489BR_Comorbidity_CHD_Code[0];
            A490BR_Comorbidity_Hapetitis_Code = T00093_A490BR_Comorbidity_Hapetitis_Code[0];
            n490BR_Comorbidity_Hapetitis_Code = T00093_n490BR_Comorbidity_Hapetitis_Code[0];
            A491BR_Comorbidity_TB_Code = T00093_A491BR_Comorbidity_TB_Code[0];
            n491BR_Comorbidity_TB_Code = T00093_n491BR_Comorbidity_TB_Code[0];
            A492BR_Comorbidity_KidneyDisease_Code = T00093_A492BR_Comorbidity_KidneyDisease_Code[0];
            n492BR_Comorbidity_KidneyDisease_Code = T00093_n492BR_Comorbidity_KidneyDisease_Code[0];
            A493BR_Comorbidity_SurgeryHistory_Code = T00093_A493BR_Comorbidity_SurgeryHistory_Code[0];
            n493BR_Comorbidity_SurgeryHistory_Code = T00093_n493BR_Comorbidity_SurgeryHistory_Code[0];
            A494BR_Comorbidity_InjuryHistory_Code = T00093_A494BR_Comorbidity_InjuryHistory_Code[0];
            n494BR_Comorbidity_InjuryHistory_Code = T00093_n494BR_Comorbidity_InjuryHistory_Code[0];
            A495BR_Comorbidity_BloodHistory_Code = T00093_A495BR_Comorbidity_BloodHistory_Code[0];
            n495BR_Comorbidity_BloodHistory_Code = T00093_n495BR_Comorbidity_BloodHistory_Code[0];
            A496BR_Comorbidity_allergy_Code = T00093_A496BR_Comorbidity_allergy_Code[0];
            n496BR_Comorbidity_allergy_Code = T00093_n496BR_Comorbidity_allergy_Code[0];
            A38BR_Comorbidity_Hypertension = T00093_A38BR_Comorbidity_Hypertension[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38BR_Comorbidity_Hypertension", A38BR_Comorbidity_Hypertension);
            n38BR_Comorbidity_Hypertension = T00093_n38BR_Comorbidity_Hypertension[0];
            A39BR_Comorbidity_Diabetes = T00093_A39BR_Comorbidity_Diabetes[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39BR_Comorbidity_Diabetes", A39BR_Comorbidity_Diabetes);
            n39BR_Comorbidity_Diabetes = T00093_n39BR_Comorbidity_Diabetes[0];
            A40BR_Comorbidity_CHD = T00093_A40BR_Comorbidity_CHD[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40BR_Comorbidity_CHD", A40BR_Comorbidity_CHD);
            n40BR_Comorbidity_CHD = T00093_n40BR_Comorbidity_CHD[0];
            A41BR_Comorbidity_Hapetitis = T00093_A41BR_Comorbidity_Hapetitis[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41BR_Comorbidity_Hapetitis", A41BR_Comorbidity_Hapetitis);
            n41BR_Comorbidity_Hapetitis = T00093_n41BR_Comorbidity_Hapetitis[0];
            A42BR_Comorbidity_TB = T00093_A42BR_Comorbidity_TB[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BR_Comorbidity_TB", A42BR_Comorbidity_TB);
            n42BR_Comorbidity_TB = T00093_n42BR_Comorbidity_TB[0];
            A43BR_Comorbidity_KidneyDisease = T00093_A43BR_Comorbidity_KidneyDisease[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43BR_Comorbidity_KidneyDisease", A43BR_Comorbidity_KidneyDisease);
            n43BR_Comorbidity_KidneyDisease = T00093_n43BR_Comorbidity_KidneyDisease[0];
            A44BR_Comorbidity_SurgeryHistory = T00093_A44BR_Comorbidity_SurgeryHistory[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44BR_Comorbidity_SurgeryHistory", A44BR_Comorbidity_SurgeryHistory);
            n44BR_Comorbidity_SurgeryHistory = T00093_n44BR_Comorbidity_SurgeryHistory[0];
            A45BR_Comorbidity_InjuryHistory = T00093_A45BR_Comorbidity_InjuryHistory[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A45BR_Comorbidity_InjuryHistory", A45BR_Comorbidity_InjuryHistory);
            n45BR_Comorbidity_InjuryHistory = T00093_n45BR_Comorbidity_InjuryHistory[0];
            A46BR_Comorbidity_BloodHistory = T00093_A46BR_Comorbidity_BloodHistory[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46BR_Comorbidity_BloodHistory", A46BR_Comorbidity_BloodHistory);
            n46BR_Comorbidity_BloodHistory = T00093_n46BR_Comorbidity_BloodHistory[0];
            A47BR_Comorbidity_allergy = T00093_A47BR_Comorbidity_allergy[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A47BR_Comorbidity_allergy", A47BR_Comorbidity_allergy);
            n47BR_Comorbidity_allergy = T00093_n47BR_Comorbidity_allergy[0];
            A259BR_Comorbidity_Others = T00093_A259BR_Comorbidity_Others[0];
            n259BR_Comorbidity_Others = T00093_n259BR_Comorbidity_Others[0];
            A561BR_Comorbidity_HapetitisB = T00093_A561BR_Comorbidity_HapetitisB[0];
            n561BR_Comorbidity_HapetitisB = T00093_n561BR_Comorbidity_HapetitisB[0];
            A562BR_Comorbidity_HapetitisB_Code = T00093_A562BR_Comorbidity_HapetitisB_Code[0];
            n562BR_Comorbidity_HapetitisB_Code = T00093_n562BR_Comorbidity_HapetitisB_Code[0];
            A563BR_Comorbidity_HapetitisC = T00093_A563BR_Comorbidity_HapetitisC[0];
            n563BR_Comorbidity_HapetitisC = T00093_n563BR_Comorbidity_HapetitisC[0];
            A564BR_Comorbidity_HapetitisC_Code = T00093_A564BR_Comorbidity_HapetitisC_Code[0];
            n564BR_Comorbidity_HapetitisC_Code = T00093_n564BR_Comorbidity_HapetitisC_Code[0];
            A565BR_Comorbidity_LiverCirrhosis = T00093_A565BR_Comorbidity_LiverCirrhosis[0];
            n565BR_Comorbidity_LiverCirrhosis = T00093_n565BR_Comorbidity_LiverCirrhosis[0];
            A566BR_Comorbidity_LiverCirrhosis_Code = T00093_A566BR_Comorbidity_LiverCirrhosis_Code[0];
            n566BR_Comorbidity_LiverCirrhosis_Code = T00093_n566BR_Comorbidity_LiverCirrhosis_Code[0];
            A567BR_Comorbidity_Druginducedliverinjury = T00093_A567BR_Comorbidity_Druginducedliverinjury[0];
            n567BR_Comorbidity_Druginducedliverinjury = T00093_n567BR_Comorbidity_Druginducedliverinjury[0];
            A568BR_Comorbidity_Druginducedliverinjury_Code = T00093_A568BR_Comorbidity_Druginducedliverinjury_Code[0];
            n568BR_Comorbidity_Druginducedliverinjury_Code = T00093_n568BR_Comorbidity_Druginducedliverinjury_Code[0];
            A19BR_EncounterID = T00093_A19BR_EncounterID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
            Z37BR_ComorbidityID = A37BR_ComorbidityID;
            sMode10 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load0910( ) ;
            if ( AnyError == 1 )
            {
               RcdFound10 = 0;
               InitializeNonKey0910( ) ;
            }
            Gx_mode = sMode10;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound10 = 0;
            InitializeNonKey0910( ) ;
            sMode10 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode10;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0910( ) ;
         if ( RcdFound10 == 0 )
         {
            Gx_mode = "INS";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound10 = 0;
         /* Using cursor T000910 */
         pr_default.execute(8, new Object[] {A37BR_ComorbidityID});
         if ( (pr_default.getStatus(8) != 101) )
         {
            while ( (pr_default.getStatus(8) != 101) && ( ( T000910_A37BR_ComorbidityID[0] < A37BR_ComorbidityID ) ) )
            {
               pr_default.readNext(8);
            }
            if ( (pr_default.getStatus(8) != 101) && ( ( T000910_A37BR_ComorbidityID[0] > A37BR_ComorbidityID ) ) )
            {
               A37BR_ComorbidityID = T000910_A37BR_ComorbidityID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37BR_ComorbidityID", StringUtil.LTrim( StringUtil.Str( (decimal)(A37BR_ComorbidityID), 18, 0)));
               RcdFound10 = 1;
            }
         }
         pr_default.close(8);
      }

      protected void move_previous( )
      {
         RcdFound10 = 0;
         /* Using cursor T000911 */
         pr_default.execute(9, new Object[] {A37BR_ComorbidityID});
         if ( (pr_default.getStatus(9) != 101) )
         {
            while ( (pr_default.getStatus(9) != 101) && ( ( T000911_A37BR_ComorbidityID[0] > A37BR_ComorbidityID ) ) )
            {
               pr_default.readNext(9);
            }
            if ( (pr_default.getStatus(9) != 101) && ( ( T000911_A37BR_ComorbidityID[0] < A37BR_ComorbidityID ) ) )
            {
               A37BR_ComorbidityID = T000911_A37BR_ComorbidityID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37BR_ComorbidityID", StringUtil.LTrim( StringUtil.Str( (decimal)(A37BR_ComorbidityID), 18, 0)));
               RcdFound10 = 1;
            }
         }
         pr_default.close(9);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0910( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtBR_EncounterID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0910( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound10 == 1 )
            {
               if ( A37BR_ComorbidityID != Z37BR_ComorbidityID )
               {
                  A37BR_ComorbidityID = Z37BR_ComorbidityID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37BR_ComorbidityID", StringUtil.LTrim( StringUtil.Str( (decimal)(A37BR_ComorbidityID), 18, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "BR_COMORBIDITYID");
                  AnyError = 1;
                  GX_FocusControl = edtBR_ComorbidityID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtBR_EncounterID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "UPD";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Update record */
                  Update0910( ) ;
                  GX_FocusControl = edtBR_EncounterID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A37BR_ComorbidityID != Z37BR_ComorbidityID )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtBR_EncounterID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0910( ) ;
                  if ( AnyError == 1 )
                  {
                     GX_FocusControl = "";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "BR_COMORBIDITYID");
                     AnyError = 1;
                     GX_FocusControl = edtBR_ComorbidityID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     /* Insert record */
                     GX_FocusControl = edtBR_EncounterID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0910( ) ;
                     if ( AnyError == 1 )
                     {
                        GX_FocusControl = "";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
         }
         AfterTrn( ) ;
      }

      protected void btn_delete( )
      {
         if ( A37BR_ComorbidityID != Z37BR_ComorbidityID )
         {
            A37BR_ComorbidityID = Z37BR_ComorbidityID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37BR_ComorbidityID", StringUtil.LTrim( StringUtil.Str( (decimal)(A37BR_ComorbidityID), 18, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "BR_COMORBIDITYID");
            AnyError = 1;
            GX_FocusControl = edtBR_ComorbidityID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtBR_EncounterID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            getByPrimaryKey( ) ;
         }
         CloseOpenCursors();
      }

      protected void btn_get( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         getEqualNoModal( ) ;
         if ( RcdFound10 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "BR_COMORBIDITYID");
            AnyError = 1;
            GX_FocusControl = edtBR_ComorbidityID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GX_FocusControl = edtBR_EncounterID_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         ScanStart0910( ) ;
         if ( RcdFound10 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtBR_EncounterID_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0910( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         move_previous( ) ;
         if ( RcdFound10 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtBR_EncounterID_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_next( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         move_next( ) ;
         if ( RcdFound10 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtBR_EncounterID_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         ScanStart0910( ) ;
         if ( RcdFound10 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound10 != 0 )
            {
               ScanNext0910( ) ;
            }
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtBR_EncounterID_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0910( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency0910( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00092 */
            pr_default.execute(0, new Object[] {A37BR_ComorbidityID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Comorbidity"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z487BR_Comorbidity_Hypertension_Code, T00092_A487BR_Comorbidity_Hypertension_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z488BR_Comorbidity_Diabetes_Code, T00092_A488BR_Comorbidity_Diabetes_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z489BR_Comorbidity_CHD_Code, T00092_A489BR_Comorbidity_CHD_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z490BR_Comorbidity_Hapetitis_Code, T00092_A490BR_Comorbidity_Hapetitis_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z491BR_Comorbidity_TB_Code, T00092_A491BR_Comorbidity_TB_Code[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z492BR_Comorbidity_KidneyDisease_Code, T00092_A492BR_Comorbidity_KidneyDisease_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z493BR_Comorbidity_SurgeryHistory_Code, T00092_A493BR_Comorbidity_SurgeryHistory_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z494BR_Comorbidity_InjuryHistory_Code, T00092_A494BR_Comorbidity_InjuryHistory_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z495BR_Comorbidity_BloodHistory_Code, T00092_A495BR_Comorbidity_BloodHistory_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z496BR_Comorbidity_allergy_Code, T00092_A496BR_Comorbidity_allergy_Code[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z38BR_Comorbidity_Hypertension, T00092_A38BR_Comorbidity_Hypertension[0]) != 0 ) || ( StringUtil.StrCmp(Z39BR_Comorbidity_Diabetes, T00092_A39BR_Comorbidity_Diabetes[0]) != 0 ) || ( StringUtil.StrCmp(Z40BR_Comorbidity_CHD, T00092_A40BR_Comorbidity_CHD[0]) != 0 ) || ( StringUtil.StrCmp(Z41BR_Comorbidity_Hapetitis, T00092_A41BR_Comorbidity_Hapetitis[0]) != 0 ) || ( StringUtil.StrCmp(Z42BR_Comorbidity_TB, T00092_A42BR_Comorbidity_TB[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z43BR_Comorbidity_KidneyDisease, T00092_A43BR_Comorbidity_KidneyDisease[0]) != 0 ) || ( StringUtil.StrCmp(Z44BR_Comorbidity_SurgeryHistory, T00092_A44BR_Comorbidity_SurgeryHistory[0]) != 0 ) || ( StringUtil.StrCmp(Z45BR_Comorbidity_InjuryHistory, T00092_A45BR_Comorbidity_InjuryHistory[0]) != 0 ) || ( StringUtil.StrCmp(Z46BR_Comorbidity_BloodHistory, T00092_A46BR_Comorbidity_BloodHistory[0]) != 0 ) || ( StringUtil.StrCmp(Z47BR_Comorbidity_allergy, T00092_A47BR_Comorbidity_allergy[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z259BR_Comorbidity_Others, T00092_A259BR_Comorbidity_Others[0]) != 0 ) || ( StringUtil.StrCmp(Z561BR_Comorbidity_HapetitisB, T00092_A561BR_Comorbidity_HapetitisB[0]) != 0 ) || ( StringUtil.StrCmp(Z562BR_Comorbidity_HapetitisB_Code, T00092_A562BR_Comorbidity_HapetitisB_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z563BR_Comorbidity_HapetitisC, T00092_A563BR_Comorbidity_HapetitisC[0]) != 0 ) || ( StringUtil.StrCmp(Z564BR_Comorbidity_HapetitisC_Code, T00092_A564BR_Comorbidity_HapetitisC_Code[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z565BR_Comorbidity_LiverCirrhosis, T00092_A565BR_Comorbidity_LiverCirrhosis[0]) != 0 ) || ( StringUtil.StrCmp(Z566BR_Comorbidity_LiverCirrhosis_Code, T00092_A566BR_Comorbidity_LiverCirrhosis_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z567BR_Comorbidity_Druginducedliverinjury, T00092_A567BR_Comorbidity_Druginducedliverinjury[0]) != 0 ) || ( StringUtil.StrCmp(Z568BR_Comorbidity_Druginducedliverinjury_Code, T00092_A568BR_Comorbidity_Druginducedliverinjury_Code[0]) != 0 ) || ( Z19BR_EncounterID != T00092_A19BR_EncounterID[0] ) )
            {
               if ( StringUtil.StrCmp(Z487BR_Comorbidity_Hypertension_Code, T00092_A487BR_Comorbidity_Hypertension_Code[0]) != 0 )
               {
                  GXUtil.WriteLog("br_comorbidity:[seudo value changed for attri]"+"BR_Comorbidity_Hypertension_Code");
                  GXUtil.WriteLogRaw("Old: ",Z487BR_Comorbidity_Hypertension_Code);
                  GXUtil.WriteLogRaw("Current: ",T00092_A487BR_Comorbidity_Hypertension_Code[0]);
               }
               if ( StringUtil.StrCmp(Z488BR_Comorbidity_Diabetes_Code, T00092_A488BR_Comorbidity_Diabetes_Code[0]) != 0 )
               {
                  GXUtil.WriteLog("br_comorbidity:[seudo value changed for attri]"+"BR_Comorbidity_Diabetes_Code");
                  GXUtil.WriteLogRaw("Old: ",Z488BR_Comorbidity_Diabetes_Code);
                  GXUtil.WriteLogRaw("Current: ",T00092_A488BR_Comorbidity_Diabetes_Code[0]);
               }
               if ( StringUtil.StrCmp(Z489BR_Comorbidity_CHD_Code, T00092_A489BR_Comorbidity_CHD_Code[0]) != 0 )
               {
                  GXUtil.WriteLog("br_comorbidity:[seudo value changed for attri]"+"BR_Comorbidity_CHD_Code");
                  GXUtil.WriteLogRaw("Old: ",Z489BR_Comorbidity_CHD_Code);
                  GXUtil.WriteLogRaw("Current: ",T00092_A489BR_Comorbidity_CHD_Code[0]);
               }
               if ( StringUtil.StrCmp(Z490BR_Comorbidity_Hapetitis_Code, T00092_A490BR_Comorbidity_Hapetitis_Code[0]) != 0 )
               {
                  GXUtil.WriteLog("br_comorbidity:[seudo value changed for attri]"+"BR_Comorbidity_Hapetitis_Code");
                  GXUtil.WriteLogRaw("Old: ",Z490BR_Comorbidity_Hapetitis_Code);
                  GXUtil.WriteLogRaw("Current: ",T00092_A490BR_Comorbidity_Hapetitis_Code[0]);
               }
               if ( StringUtil.StrCmp(Z491BR_Comorbidity_TB_Code, T00092_A491BR_Comorbidity_TB_Code[0]) != 0 )
               {
                  GXUtil.WriteLog("br_comorbidity:[seudo value changed for attri]"+"BR_Comorbidity_TB_Code");
                  GXUtil.WriteLogRaw("Old: ",Z491BR_Comorbidity_TB_Code);
                  GXUtil.WriteLogRaw("Current: ",T00092_A491BR_Comorbidity_TB_Code[0]);
               }
               if ( StringUtil.StrCmp(Z492BR_Comorbidity_KidneyDisease_Code, T00092_A492BR_Comorbidity_KidneyDisease_Code[0]) != 0 )
               {
                  GXUtil.WriteLog("br_comorbidity:[seudo value changed for attri]"+"BR_Comorbidity_KidneyDisease_Code");
                  GXUtil.WriteLogRaw("Old: ",Z492BR_Comorbidity_KidneyDisease_Code);
                  GXUtil.WriteLogRaw("Current: ",T00092_A492BR_Comorbidity_KidneyDisease_Code[0]);
               }
               if ( StringUtil.StrCmp(Z493BR_Comorbidity_SurgeryHistory_Code, T00092_A493BR_Comorbidity_SurgeryHistory_Code[0]) != 0 )
               {
                  GXUtil.WriteLog("br_comorbidity:[seudo value changed for attri]"+"BR_Comorbidity_SurgeryHistory_Code");
                  GXUtil.WriteLogRaw("Old: ",Z493BR_Comorbidity_SurgeryHistory_Code);
                  GXUtil.WriteLogRaw("Current: ",T00092_A493BR_Comorbidity_SurgeryHistory_Code[0]);
               }
               if ( StringUtil.StrCmp(Z494BR_Comorbidity_InjuryHistory_Code, T00092_A494BR_Comorbidity_InjuryHistory_Code[0]) != 0 )
               {
                  GXUtil.WriteLog("br_comorbidity:[seudo value changed for attri]"+"BR_Comorbidity_InjuryHistory_Code");
                  GXUtil.WriteLogRaw("Old: ",Z494BR_Comorbidity_InjuryHistory_Code);
                  GXUtil.WriteLogRaw("Current: ",T00092_A494BR_Comorbidity_InjuryHistory_Code[0]);
               }
               if ( StringUtil.StrCmp(Z495BR_Comorbidity_BloodHistory_Code, T00092_A495BR_Comorbidity_BloodHistory_Code[0]) != 0 )
               {
                  GXUtil.WriteLog("br_comorbidity:[seudo value changed for attri]"+"BR_Comorbidity_BloodHistory_Code");
                  GXUtil.WriteLogRaw("Old: ",Z495BR_Comorbidity_BloodHistory_Code);
                  GXUtil.WriteLogRaw("Current: ",T00092_A495BR_Comorbidity_BloodHistory_Code[0]);
               }
               if ( StringUtil.StrCmp(Z496BR_Comorbidity_allergy_Code, T00092_A496BR_Comorbidity_allergy_Code[0]) != 0 )
               {
                  GXUtil.WriteLog("br_comorbidity:[seudo value changed for attri]"+"BR_Comorbidity_allergy_Code");
                  GXUtil.WriteLogRaw("Old: ",Z496BR_Comorbidity_allergy_Code);
                  GXUtil.WriteLogRaw("Current: ",T00092_A496BR_Comorbidity_allergy_Code[0]);
               }
               if ( StringUtil.StrCmp(Z38BR_Comorbidity_Hypertension, T00092_A38BR_Comorbidity_Hypertension[0]) != 0 )
               {
                  GXUtil.WriteLog("br_comorbidity:[seudo value changed for attri]"+"BR_Comorbidity_Hypertension");
                  GXUtil.WriteLogRaw("Old: ",Z38BR_Comorbidity_Hypertension);
                  GXUtil.WriteLogRaw("Current: ",T00092_A38BR_Comorbidity_Hypertension[0]);
               }
               if ( StringUtil.StrCmp(Z39BR_Comorbidity_Diabetes, T00092_A39BR_Comorbidity_Diabetes[0]) != 0 )
               {
                  GXUtil.WriteLog("br_comorbidity:[seudo value changed for attri]"+"BR_Comorbidity_Diabetes");
                  GXUtil.WriteLogRaw("Old: ",Z39BR_Comorbidity_Diabetes);
                  GXUtil.WriteLogRaw("Current: ",T00092_A39BR_Comorbidity_Diabetes[0]);
               }
               if ( StringUtil.StrCmp(Z40BR_Comorbidity_CHD, T00092_A40BR_Comorbidity_CHD[0]) != 0 )
               {
                  GXUtil.WriteLog("br_comorbidity:[seudo value changed for attri]"+"BR_Comorbidity_CHD");
                  GXUtil.WriteLogRaw("Old: ",Z40BR_Comorbidity_CHD);
                  GXUtil.WriteLogRaw("Current: ",T00092_A40BR_Comorbidity_CHD[0]);
               }
               if ( StringUtil.StrCmp(Z41BR_Comorbidity_Hapetitis, T00092_A41BR_Comorbidity_Hapetitis[0]) != 0 )
               {
                  GXUtil.WriteLog("br_comorbidity:[seudo value changed for attri]"+"BR_Comorbidity_Hapetitis");
                  GXUtil.WriteLogRaw("Old: ",Z41BR_Comorbidity_Hapetitis);
                  GXUtil.WriteLogRaw("Current: ",T00092_A41BR_Comorbidity_Hapetitis[0]);
               }
               if ( StringUtil.StrCmp(Z42BR_Comorbidity_TB, T00092_A42BR_Comorbidity_TB[0]) != 0 )
               {
                  GXUtil.WriteLog("br_comorbidity:[seudo value changed for attri]"+"BR_Comorbidity_TB");
                  GXUtil.WriteLogRaw("Old: ",Z42BR_Comorbidity_TB);
                  GXUtil.WriteLogRaw("Current: ",T00092_A42BR_Comorbidity_TB[0]);
               }
               if ( StringUtil.StrCmp(Z43BR_Comorbidity_KidneyDisease, T00092_A43BR_Comorbidity_KidneyDisease[0]) != 0 )
               {
                  GXUtil.WriteLog("br_comorbidity:[seudo value changed for attri]"+"BR_Comorbidity_KidneyDisease");
                  GXUtil.WriteLogRaw("Old: ",Z43BR_Comorbidity_KidneyDisease);
                  GXUtil.WriteLogRaw("Current: ",T00092_A43BR_Comorbidity_KidneyDisease[0]);
               }
               if ( StringUtil.StrCmp(Z44BR_Comorbidity_SurgeryHistory, T00092_A44BR_Comorbidity_SurgeryHistory[0]) != 0 )
               {
                  GXUtil.WriteLog("br_comorbidity:[seudo value changed for attri]"+"BR_Comorbidity_SurgeryHistory");
                  GXUtil.WriteLogRaw("Old: ",Z44BR_Comorbidity_SurgeryHistory);
                  GXUtil.WriteLogRaw("Current: ",T00092_A44BR_Comorbidity_SurgeryHistory[0]);
               }
               if ( StringUtil.StrCmp(Z45BR_Comorbidity_InjuryHistory, T00092_A45BR_Comorbidity_InjuryHistory[0]) != 0 )
               {
                  GXUtil.WriteLog("br_comorbidity:[seudo value changed for attri]"+"BR_Comorbidity_InjuryHistory");
                  GXUtil.WriteLogRaw("Old: ",Z45BR_Comorbidity_InjuryHistory);
                  GXUtil.WriteLogRaw("Current: ",T00092_A45BR_Comorbidity_InjuryHistory[0]);
               }
               if ( StringUtil.StrCmp(Z46BR_Comorbidity_BloodHistory, T00092_A46BR_Comorbidity_BloodHistory[0]) != 0 )
               {
                  GXUtil.WriteLog("br_comorbidity:[seudo value changed for attri]"+"BR_Comorbidity_BloodHistory");
                  GXUtil.WriteLogRaw("Old: ",Z46BR_Comorbidity_BloodHistory);
                  GXUtil.WriteLogRaw("Current: ",T00092_A46BR_Comorbidity_BloodHistory[0]);
               }
               if ( StringUtil.StrCmp(Z47BR_Comorbidity_allergy, T00092_A47BR_Comorbidity_allergy[0]) != 0 )
               {
                  GXUtil.WriteLog("br_comorbidity:[seudo value changed for attri]"+"BR_Comorbidity_allergy");
                  GXUtil.WriteLogRaw("Old: ",Z47BR_Comorbidity_allergy);
                  GXUtil.WriteLogRaw("Current: ",T00092_A47BR_Comorbidity_allergy[0]);
               }
               if ( StringUtil.StrCmp(Z259BR_Comorbidity_Others, T00092_A259BR_Comorbidity_Others[0]) != 0 )
               {
                  GXUtil.WriteLog("br_comorbidity:[seudo value changed for attri]"+"BR_Comorbidity_Others");
                  GXUtil.WriteLogRaw("Old: ",Z259BR_Comorbidity_Others);
                  GXUtil.WriteLogRaw("Current: ",T00092_A259BR_Comorbidity_Others[0]);
               }
               if ( StringUtil.StrCmp(Z561BR_Comorbidity_HapetitisB, T00092_A561BR_Comorbidity_HapetitisB[0]) != 0 )
               {
                  GXUtil.WriteLog("br_comorbidity:[seudo value changed for attri]"+"BR_Comorbidity_HapetitisB");
                  GXUtil.WriteLogRaw("Old: ",Z561BR_Comorbidity_HapetitisB);
                  GXUtil.WriteLogRaw("Current: ",T00092_A561BR_Comorbidity_HapetitisB[0]);
               }
               if ( StringUtil.StrCmp(Z562BR_Comorbidity_HapetitisB_Code, T00092_A562BR_Comorbidity_HapetitisB_Code[0]) != 0 )
               {
                  GXUtil.WriteLog("br_comorbidity:[seudo value changed for attri]"+"BR_Comorbidity_HapetitisB_Code");
                  GXUtil.WriteLogRaw("Old: ",Z562BR_Comorbidity_HapetitisB_Code);
                  GXUtil.WriteLogRaw("Current: ",T00092_A562BR_Comorbidity_HapetitisB_Code[0]);
               }
               if ( StringUtil.StrCmp(Z563BR_Comorbidity_HapetitisC, T00092_A563BR_Comorbidity_HapetitisC[0]) != 0 )
               {
                  GXUtil.WriteLog("br_comorbidity:[seudo value changed for attri]"+"BR_Comorbidity_HapetitisC");
                  GXUtil.WriteLogRaw("Old: ",Z563BR_Comorbidity_HapetitisC);
                  GXUtil.WriteLogRaw("Current: ",T00092_A563BR_Comorbidity_HapetitisC[0]);
               }
               if ( StringUtil.StrCmp(Z564BR_Comorbidity_HapetitisC_Code, T00092_A564BR_Comorbidity_HapetitisC_Code[0]) != 0 )
               {
                  GXUtil.WriteLog("br_comorbidity:[seudo value changed for attri]"+"BR_Comorbidity_HapetitisC_Code");
                  GXUtil.WriteLogRaw("Old: ",Z564BR_Comorbidity_HapetitisC_Code);
                  GXUtil.WriteLogRaw("Current: ",T00092_A564BR_Comorbidity_HapetitisC_Code[0]);
               }
               if ( StringUtil.StrCmp(Z565BR_Comorbidity_LiverCirrhosis, T00092_A565BR_Comorbidity_LiverCirrhosis[0]) != 0 )
               {
                  GXUtil.WriteLog("br_comorbidity:[seudo value changed for attri]"+"BR_Comorbidity_LiverCirrhosis");
                  GXUtil.WriteLogRaw("Old: ",Z565BR_Comorbidity_LiverCirrhosis);
                  GXUtil.WriteLogRaw("Current: ",T00092_A565BR_Comorbidity_LiverCirrhosis[0]);
               }
               if ( StringUtil.StrCmp(Z566BR_Comorbidity_LiverCirrhosis_Code, T00092_A566BR_Comorbidity_LiverCirrhosis_Code[0]) != 0 )
               {
                  GXUtil.WriteLog("br_comorbidity:[seudo value changed for attri]"+"BR_Comorbidity_LiverCirrhosis_Code");
                  GXUtil.WriteLogRaw("Old: ",Z566BR_Comorbidity_LiverCirrhosis_Code);
                  GXUtil.WriteLogRaw("Current: ",T00092_A566BR_Comorbidity_LiverCirrhosis_Code[0]);
               }
               if ( StringUtil.StrCmp(Z567BR_Comorbidity_Druginducedliverinjury, T00092_A567BR_Comorbidity_Druginducedliverinjury[0]) != 0 )
               {
                  GXUtil.WriteLog("br_comorbidity:[seudo value changed for attri]"+"BR_Comorbidity_Druginducedliverinjury");
                  GXUtil.WriteLogRaw("Old: ",Z567BR_Comorbidity_Druginducedliverinjury);
                  GXUtil.WriteLogRaw("Current: ",T00092_A567BR_Comorbidity_Druginducedliverinjury[0]);
               }
               if ( StringUtil.StrCmp(Z568BR_Comorbidity_Druginducedliverinjury_Code, T00092_A568BR_Comorbidity_Druginducedliverinjury_Code[0]) != 0 )
               {
                  GXUtil.WriteLog("br_comorbidity:[seudo value changed for attri]"+"BR_Comorbidity_Druginducedliverinjury_Code");
                  GXUtil.WriteLogRaw("Old: ",Z568BR_Comorbidity_Druginducedliverinjury_Code);
                  GXUtil.WriteLogRaw("Current: ",T00092_A568BR_Comorbidity_Druginducedliverinjury_Code[0]);
               }
               if ( Z19BR_EncounterID != T00092_A19BR_EncounterID[0] )
               {
                  GXUtil.WriteLog("br_comorbidity:[seudo value changed for attri]"+"BR_EncounterID");
                  GXUtil.WriteLogRaw("Old: ",Z19BR_EncounterID);
                  GXUtil.WriteLogRaw("Current: ",T00092_A19BR_EncounterID[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"BR_Comorbidity"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0910( )
      {
         BeforeValidate0910( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0910( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0910( 0) ;
            CheckOptimisticConcurrency0910( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0910( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0910( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000912 */
                     pr_default.execute(10, new Object[] {n487BR_Comorbidity_Hypertension_Code, A487BR_Comorbidity_Hypertension_Code, n488BR_Comorbidity_Diabetes_Code, A488BR_Comorbidity_Diabetes_Code, n489BR_Comorbidity_CHD_Code, A489BR_Comorbidity_CHD_Code, n490BR_Comorbidity_Hapetitis_Code, A490BR_Comorbidity_Hapetitis_Code, n491BR_Comorbidity_TB_Code, A491BR_Comorbidity_TB_Code, n492BR_Comorbidity_KidneyDisease_Code, A492BR_Comorbidity_KidneyDisease_Code, n493BR_Comorbidity_SurgeryHistory_Code, A493BR_Comorbidity_SurgeryHistory_Code, n494BR_Comorbidity_InjuryHistory_Code, A494BR_Comorbidity_InjuryHistory_Code, n495BR_Comorbidity_BloodHistory_Code, A495BR_Comorbidity_BloodHistory_Code, n496BR_Comorbidity_allergy_Code, A496BR_Comorbidity_allergy_Code, n38BR_Comorbidity_Hypertension, A38BR_Comorbidity_Hypertension, n39BR_Comorbidity_Diabetes, A39BR_Comorbidity_Diabetes, n40BR_Comorbidity_CHD, A40BR_Comorbidity_CHD, n41BR_Comorbidity_Hapetitis, A41BR_Comorbidity_Hapetitis, n42BR_Comorbidity_TB, A42BR_Comorbidity_TB, n43BR_Comorbidity_KidneyDisease, A43BR_Comorbidity_KidneyDisease, n44BR_Comorbidity_SurgeryHistory, A44BR_Comorbidity_SurgeryHistory, n45BR_Comorbidity_InjuryHistory, A45BR_Comorbidity_InjuryHistory, n46BR_Comorbidity_BloodHistory, A46BR_Comorbidity_BloodHistory, n47BR_Comorbidity_allergy, A47BR_Comorbidity_allergy, n259BR_Comorbidity_Others, A259BR_Comorbidity_Others, n561BR_Comorbidity_HapetitisB, A561BR_Comorbidity_HapetitisB, n562BR_Comorbidity_HapetitisB_Code, A562BR_Comorbidity_HapetitisB_Code, n563BR_Comorbidity_HapetitisC, A563BR_Comorbidity_HapetitisC, n564BR_Comorbidity_HapetitisC_Code, A564BR_Comorbidity_HapetitisC_Code, n565BR_Comorbidity_LiverCirrhosis, A565BR_Comorbidity_LiverCirrhosis, n566BR_Comorbidity_LiverCirrhosis_Code, A566BR_Comorbidity_LiverCirrhosis_Code, n567BR_Comorbidity_Druginducedliverinjury, A567BR_Comorbidity_Druginducedliverinjury, n568BR_Comorbidity_Druginducedliverinjury_Code, A568BR_Comorbidity_Druginducedliverinjury_Code, A19BR_EncounterID});
                     A37BR_ComorbidityID = T000912_A37BR_ComorbidityID[0];
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37BR_ComorbidityID", StringUtil.LTrim( StringUtil.Str( (decimal)(A37BR_ComorbidityID), 18, 0)));
                     pr_default.close(10);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Comorbidity") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption090( ) ;
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
               Load0910( ) ;
            }
            EndLevel0910( ) ;
         }
         CloseExtendedTableCursors0910( ) ;
      }

      protected void Update0910( )
      {
         BeforeValidate0910( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0910( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0910( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0910( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0910( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000913 */
                     pr_default.execute(11, new Object[] {n487BR_Comorbidity_Hypertension_Code, A487BR_Comorbidity_Hypertension_Code, n488BR_Comorbidity_Diabetes_Code, A488BR_Comorbidity_Diabetes_Code, n489BR_Comorbidity_CHD_Code, A489BR_Comorbidity_CHD_Code, n490BR_Comorbidity_Hapetitis_Code, A490BR_Comorbidity_Hapetitis_Code, n491BR_Comorbidity_TB_Code, A491BR_Comorbidity_TB_Code, n492BR_Comorbidity_KidneyDisease_Code, A492BR_Comorbidity_KidneyDisease_Code, n493BR_Comorbidity_SurgeryHistory_Code, A493BR_Comorbidity_SurgeryHistory_Code, n494BR_Comorbidity_InjuryHistory_Code, A494BR_Comorbidity_InjuryHistory_Code, n495BR_Comorbidity_BloodHistory_Code, A495BR_Comorbidity_BloodHistory_Code, n496BR_Comorbidity_allergy_Code, A496BR_Comorbidity_allergy_Code, n38BR_Comorbidity_Hypertension, A38BR_Comorbidity_Hypertension, n39BR_Comorbidity_Diabetes, A39BR_Comorbidity_Diabetes, n40BR_Comorbidity_CHD, A40BR_Comorbidity_CHD, n41BR_Comorbidity_Hapetitis, A41BR_Comorbidity_Hapetitis, n42BR_Comorbidity_TB, A42BR_Comorbidity_TB, n43BR_Comorbidity_KidneyDisease, A43BR_Comorbidity_KidneyDisease, n44BR_Comorbidity_SurgeryHistory, A44BR_Comorbidity_SurgeryHistory, n45BR_Comorbidity_InjuryHistory, A45BR_Comorbidity_InjuryHistory, n46BR_Comorbidity_BloodHistory, A46BR_Comorbidity_BloodHistory, n47BR_Comorbidity_allergy, A47BR_Comorbidity_allergy, n259BR_Comorbidity_Others, A259BR_Comorbidity_Others, n561BR_Comorbidity_HapetitisB, A561BR_Comorbidity_HapetitisB, n562BR_Comorbidity_HapetitisB_Code, A562BR_Comorbidity_HapetitisB_Code, n563BR_Comorbidity_HapetitisC, A563BR_Comorbidity_HapetitisC, n564BR_Comorbidity_HapetitisC_Code, A564BR_Comorbidity_HapetitisC_Code, n565BR_Comorbidity_LiverCirrhosis, A565BR_Comorbidity_LiverCirrhosis, n566BR_Comorbidity_LiverCirrhosis_Code, A566BR_Comorbidity_LiverCirrhosis_Code, n567BR_Comorbidity_Druginducedliverinjury, A567BR_Comorbidity_Druginducedliverinjury, n568BR_Comorbidity_Druginducedliverinjury_Code, A568BR_Comorbidity_Druginducedliverinjury_Code, A19BR_EncounterID, A37BR_ComorbidityID});
                     pr_default.close(11);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Comorbidity") ;
                     if ( (pr_default.getStatus(11) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Comorbidity"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0910( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), "SuccessfullyUpdated", 0, "", true);
                           ResetCaption090( ) ;
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
            EndLevel0910( ) ;
         }
         CloseExtendedTableCursors0910( ) ;
      }

      protected void DeferredUpdate0910( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate0910( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0910( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0910( ) ;
            AfterConfirm0910( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0910( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000914 */
                  pr_default.execute(12, new Object[] {A37BR_ComorbidityID});
                  pr_default.close(12);
                  dsDefault.SmartCacheProvider.SetUpdated("BR_Comorbidity") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound10 == 0 )
                        {
                           InitAll0910( ) ;
                           Gx_mode = "INS";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        }
                        else
                        {
                           getByPrimaryKey( ) ;
                           Gx_mode = "UPD";
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        }
                        GX_msglist.addItem(context.GetMessage( "GXM_sucdeleted", ""), "SuccessfullyDeleted", 0, "", true);
                        ResetCaption090( ) ;
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
         sMode10 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0910( ) ;
         Gx_mode = sMode10;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0910( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T000915 */
            pr_default.execute(13, new Object[] {A19BR_EncounterID});
            A85BR_Information_ID = T000915_A85BR_Information_ID[0];
            n85BR_Information_ID = T000915_n85BR_Information_ID[0];
            pr_default.close(13);
            /* Using cursor T000916 */
            pr_default.execute(14, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
            A36BR_Information_PatientNo = T000916_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = T000916_n36BR_Information_PatientNo[0];
            pr_default.close(14);
         }
      }

      protected void EndLevel0910( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0910( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            pr_default.close(13);
            pr_default.close(14);
            context.CommitDataStores("br_comorbidity",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues090( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            pr_default.close(13);
            pr_default.close(14);
            context.RollbackDataStores("br_comorbidity",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0910( )
      {
         /* Scan By routine */
         /* Using cursor T000917 */
         pr_default.execute(15);
         RcdFound10 = 0;
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound10 = 1;
            A37BR_ComorbidityID = T000917_A37BR_ComorbidityID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37BR_ComorbidityID", StringUtil.LTrim( StringUtil.Str( (decimal)(A37BR_ComorbidityID), 18, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0910( )
      {
         /* Scan next routine */
         pr_default.readNext(15);
         RcdFound10 = 0;
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound10 = 1;
            A37BR_ComorbidityID = T000917_A37BR_ComorbidityID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37BR_ComorbidityID", StringUtil.LTrim( StringUtil.Str( (decimal)(A37BR_ComorbidityID), 18, 0)));
         }
      }

      protected void ScanEnd0910( )
      {
         pr_default.close(15);
      }

      protected void AfterConfirm0910( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0910( )
      {
         /* Before Insert Rules */
         GXt_char1 = A487BR_Comorbidity_Hypertension_Code;
         new zutil_findtargetcode(context ).execute(  37,  A38BR_Comorbidity_Hypertension, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38BR_Comorbidity_Hypertension", A38BR_Comorbidity_Hypertension);
         A487BR_Comorbidity_Hypertension_Code = GXt_char1;
         n487BR_Comorbidity_Hypertension_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A487BR_Comorbidity_Hypertension_Code", A487BR_Comorbidity_Hypertension_Code);
         GXt_char1 = A488BR_Comorbidity_Diabetes_Code;
         new zutil_findtargetcode(context ).execute(  37,  A39BR_Comorbidity_Diabetes, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39BR_Comorbidity_Diabetes", A39BR_Comorbidity_Diabetes);
         A488BR_Comorbidity_Diabetes_Code = GXt_char1;
         n488BR_Comorbidity_Diabetes_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A488BR_Comorbidity_Diabetes_Code", A488BR_Comorbidity_Diabetes_Code);
         GXt_char1 = A489BR_Comorbidity_CHD_Code;
         new zutil_findtargetcode(context ).execute(  37,  A40BR_Comorbidity_CHD, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40BR_Comorbidity_CHD", A40BR_Comorbidity_CHD);
         A489BR_Comorbidity_CHD_Code = GXt_char1;
         n489BR_Comorbidity_CHD_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A489BR_Comorbidity_CHD_Code", A489BR_Comorbidity_CHD_Code);
         GXt_char1 = A490BR_Comorbidity_Hapetitis_Code;
         new zutil_findtargetcode(context ).execute(  37,  A41BR_Comorbidity_Hapetitis, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41BR_Comorbidity_Hapetitis", A41BR_Comorbidity_Hapetitis);
         A490BR_Comorbidity_Hapetitis_Code = GXt_char1;
         n490BR_Comorbidity_Hapetitis_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A490BR_Comorbidity_Hapetitis_Code", A490BR_Comorbidity_Hapetitis_Code);
         GXt_char1 = A491BR_Comorbidity_TB_Code;
         new zutil_findtargetcode(context ).execute(  37,  A42BR_Comorbidity_TB, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BR_Comorbidity_TB", A42BR_Comorbidity_TB);
         A491BR_Comorbidity_TB_Code = GXt_char1;
         n491BR_Comorbidity_TB_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A491BR_Comorbidity_TB_Code", A491BR_Comorbidity_TB_Code);
         GXt_char1 = A492BR_Comorbidity_KidneyDisease_Code;
         new zutil_findtargetcode(context ).execute(  37,  A43BR_Comorbidity_KidneyDisease, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43BR_Comorbidity_KidneyDisease", A43BR_Comorbidity_KidneyDisease);
         A492BR_Comorbidity_KidneyDisease_Code = GXt_char1;
         n492BR_Comorbidity_KidneyDisease_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A492BR_Comorbidity_KidneyDisease_Code", A492BR_Comorbidity_KidneyDisease_Code);
         GXt_char1 = A493BR_Comorbidity_SurgeryHistory_Code;
         new zutil_findtargetcode(context ).execute(  37,  A44BR_Comorbidity_SurgeryHistory, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44BR_Comorbidity_SurgeryHistory", A44BR_Comorbidity_SurgeryHistory);
         A493BR_Comorbidity_SurgeryHistory_Code = GXt_char1;
         n493BR_Comorbidity_SurgeryHistory_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A493BR_Comorbidity_SurgeryHistory_Code", A493BR_Comorbidity_SurgeryHistory_Code);
         GXt_char1 = A494BR_Comorbidity_InjuryHistory_Code;
         new zutil_findtargetcode(context ).execute(  37,  A45BR_Comorbidity_InjuryHistory, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A45BR_Comorbidity_InjuryHistory", A45BR_Comorbidity_InjuryHistory);
         A494BR_Comorbidity_InjuryHistory_Code = GXt_char1;
         n494BR_Comorbidity_InjuryHistory_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A494BR_Comorbidity_InjuryHistory_Code", A494BR_Comorbidity_InjuryHistory_Code);
         GXt_char1 = A495BR_Comorbidity_BloodHistory_Code;
         new zutil_findtargetcode(context ).execute(  37,  A46BR_Comorbidity_BloodHistory, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46BR_Comorbidity_BloodHistory", A46BR_Comorbidity_BloodHistory);
         A495BR_Comorbidity_BloodHistory_Code = GXt_char1;
         n495BR_Comorbidity_BloodHistory_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A495BR_Comorbidity_BloodHistory_Code", A495BR_Comorbidity_BloodHistory_Code);
         GXt_char1 = A496BR_Comorbidity_allergy_Code;
         new zutil_findtargetcode(context ).execute(  37,  A47BR_Comorbidity_allergy, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A47BR_Comorbidity_allergy", A47BR_Comorbidity_allergy);
         A496BR_Comorbidity_allergy_Code = GXt_char1;
         n496BR_Comorbidity_allergy_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A496BR_Comorbidity_allergy_Code", A496BR_Comorbidity_allergy_Code);
      }

      protected void BeforeUpdate0910( )
      {
         /* Before Update Rules */
         GXt_char1 = A487BR_Comorbidity_Hypertension_Code;
         new zutil_findtargetcode(context ).execute(  37,  A38BR_Comorbidity_Hypertension, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38BR_Comorbidity_Hypertension", A38BR_Comorbidity_Hypertension);
         A487BR_Comorbidity_Hypertension_Code = GXt_char1;
         n487BR_Comorbidity_Hypertension_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A487BR_Comorbidity_Hypertension_Code", A487BR_Comorbidity_Hypertension_Code);
         GXt_char1 = A488BR_Comorbidity_Diabetes_Code;
         new zutil_findtargetcode(context ).execute(  37,  A39BR_Comorbidity_Diabetes, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39BR_Comorbidity_Diabetes", A39BR_Comorbidity_Diabetes);
         A488BR_Comorbidity_Diabetes_Code = GXt_char1;
         n488BR_Comorbidity_Diabetes_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A488BR_Comorbidity_Diabetes_Code", A488BR_Comorbidity_Diabetes_Code);
         GXt_char1 = A489BR_Comorbidity_CHD_Code;
         new zutil_findtargetcode(context ).execute(  37,  A40BR_Comorbidity_CHD, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40BR_Comorbidity_CHD", A40BR_Comorbidity_CHD);
         A489BR_Comorbidity_CHD_Code = GXt_char1;
         n489BR_Comorbidity_CHD_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A489BR_Comorbidity_CHD_Code", A489BR_Comorbidity_CHD_Code);
         GXt_char1 = A490BR_Comorbidity_Hapetitis_Code;
         new zutil_findtargetcode(context ).execute(  37,  A41BR_Comorbidity_Hapetitis, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41BR_Comorbidity_Hapetitis", A41BR_Comorbidity_Hapetitis);
         A490BR_Comorbidity_Hapetitis_Code = GXt_char1;
         n490BR_Comorbidity_Hapetitis_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A490BR_Comorbidity_Hapetitis_Code", A490BR_Comorbidity_Hapetitis_Code);
         GXt_char1 = A491BR_Comorbidity_TB_Code;
         new zutil_findtargetcode(context ).execute(  37,  A42BR_Comorbidity_TB, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BR_Comorbidity_TB", A42BR_Comorbidity_TB);
         A491BR_Comorbidity_TB_Code = GXt_char1;
         n491BR_Comorbidity_TB_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A491BR_Comorbidity_TB_Code", A491BR_Comorbidity_TB_Code);
         GXt_char1 = A492BR_Comorbidity_KidneyDisease_Code;
         new zutil_findtargetcode(context ).execute(  37,  A43BR_Comorbidity_KidneyDisease, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43BR_Comorbidity_KidneyDisease", A43BR_Comorbidity_KidneyDisease);
         A492BR_Comorbidity_KidneyDisease_Code = GXt_char1;
         n492BR_Comorbidity_KidneyDisease_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A492BR_Comorbidity_KidneyDisease_Code", A492BR_Comorbidity_KidneyDisease_Code);
         GXt_char1 = A493BR_Comorbidity_SurgeryHistory_Code;
         new zutil_findtargetcode(context ).execute(  37,  A44BR_Comorbidity_SurgeryHistory, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44BR_Comorbidity_SurgeryHistory", A44BR_Comorbidity_SurgeryHistory);
         A493BR_Comorbidity_SurgeryHistory_Code = GXt_char1;
         n493BR_Comorbidity_SurgeryHistory_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A493BR_Comorbidity_SurgeryHistory_Code", A493BR_Comorbidity_SurgeryHistory_Code);
         GXt_char1 = A494BR_Comorbidity_InjuryHistory_Code;
         new zutil_findtargetcode(context ).execute(  37,  A45BR_Comorbidity_InjuryHistory, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A45BR_Comorbidity_InjuryHistory", A45BR_Comorbidity_InjuryHistory);
         A494BR_Comorbidity_InjuryHistory_Code = GXt_char1;
         n494BR_Comorbidity_InjuryHistory_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A494BR_Comorbidity_InjuryHistory_Code", A494BR_Comorbidity_InjuryHistory_Code);
         GXt_char1 = A495BR_Comorbidity_BloodHistory_Code;
         new zutil_findtargetcode(context ).execute(  37,  A46BR_Comorbidity_BloodHistory, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46BR_Comorbidity_BloodHistory", A46BR_Comorbidity_BloodHistory);
         A495BR_Comorbidity_BloodHistory_Code = GXt_char1;
         n495BR_Comorbidity_BloodHistory_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A495BR_Comorbidity_BloodHistory_Code", A495BR_Comorbidity_BloodHistory_Code);
         GXt_char1 = A496BR_Comorbidity_allergy_Code;
         new zutil_findtargetcode(context ).execute(  37,  A47BR_Comorbidity_allergy, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A47BR_Comorbidity_allergy", A47BR_Comorbidity_allergy);
         A496BR_Comorbidity_allergy_Code = GXt_char1;
         n496BR_Comorbidity_allergy_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A496BR_Comorbidity_allergy_Code", A496BR_Comorbidity_allergy_Code);
      }

      protected void BeforeDelete0910( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0910( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0910( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0910( )
      {
         edtBR_EncounterID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_EncounterID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_EncounterID_Enabled), 5, 0)), true);
         cmbBR_Comorbidity_Hypertension.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Comorbidity_Hypertension_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbBR_Comorbidity_Hypertension.Enabled), 5, 0)), true);
         cmbBR_Comorbidity_Diabetes.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Comorbidity_Diabetes_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbBR_Comorbidity_Diabetes.Enabled), 5, 0)), true);
         cmbBR_Comorbidity_CHD.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Comorbidity_CHD_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbBR_Comorbidity_CHD.Enabled), 5, 0)), true);
         cmbBR_Comorbidity_Hapetitis.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Comorbidity_Hapetitis_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbBR_Comorbidity_Hapetitis.Enabled), 5, 0)), true);
         cmbBR_Comorbidity_TB.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Comorbidity_TB_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbBR_Comorbidity_TB.Enabled), 5, 0)), true);
         cmbBR_Comorbidity_KidneyDisease.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Comorbidity_KidneyDisease_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbBR_Comorbidity_KidneyDisease.Enabled), 5, 0)), true);
         cmbBR_Comorbidity_SurgeryHistory.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Comorbidity_SurgeryHistory_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbBR_Comorbidity_SurgeryHistory.Enabled), 5, 0)), true);
         cmbBR_Comorbidity_InjuryHistory.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Comorbidity_InjuryHistory_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbBR_Comorbidity_InjuryHistory.Enabled), 5, 0)), true);
         cmbBR_Comorbidity_BloodHistory.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Comorbidity_BloodHistory_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbBR_Comorbidity_BloodHistory.Enabled), 5, 0)), true);
         cmbBR_Comorbidity_allergy.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Comorbidity_allergy_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbBR_Comorbidity_allergy.Enabled), 5, 0)), true);
         edtBR_ComorbidityID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_ComorbidityID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_ComorbidityID_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes0910( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues090( )
      {
      }

      public override void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, true);
      }

      public override void RenderHtmlOpenForm( )
      {
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.WriteHtmlText( "<title>") ;
         context.SendWebValue( Form.Caption) ;
         context.WriteHtmlTextNl( "</title>") ;
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         if ( StringUtil.Len( sDynURL) > 0 )
         {
            context.WriteHtmlText( "<BASE href=\""+sDynURL+"\" />") ;
         }
         define_styles( ) ;
         MasterPageObj.master_styles();
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 127771), false);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxtimezone.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxcfg.js", "?202022713201487", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         FormProcess = " data-HasEnter=\"true\" data-Skiponenter=\"false\"";
         context.WriteHtmlText( "<body ") ;
         bodyStyle = "" + "background-color:" + context.BuildHTMLColor( Form.Backcolor) + ";color:" + context.BuildHTMLColor( Form.Textcolor) + ";";
         bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            bodyStyle = bodyStyle + " background-image:url(" + context.convertURL( Form.Background) + ")";
         }
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_comorbidity.aspx") +"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         context.WriteHtmlText( "<input type=\"submit\" title=\"submit\" style=\"display:none\" disabled>") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Class", "form-horizontal Form", true);
         toggleJsOutput = isJsOutputEnabled( );
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
      }

      protected void send_integrity_footer_hashes( )
      {
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         forbiddenHiddens = "hsh" + "BR_Comorbidity";
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A259BR_Comorbidity_Others, ""));
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A561BR_Comorbidity_HapetitisB, ""));
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A562BR_Comorbidity_HapetitisB_Code, ""));
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A563BR_Comorbidity_HapetitisC, ""));
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A564BR_Comorbidity_HapetitisC_Code, ""));
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A565BR_Comorbidity_LiverCirrhosis, ""));
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A566BR_Comorbidity_LiverCirrhosis_Code, ""));
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A567BR_Comorbidity_Druginducedliverinjury, ""));
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A568BR_Comorbidity_Druginducedliverinjury_Code, ""));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("br_comorbidity:[SendSecurityCheck value for]"+"BR_Comorbidity_Others:"+StringUtil.RTrim( context.localUtil.Format( A259BR_Comorbidity_Others, "")));
         GXUtil.WriteLog("br_comorbidity:[SendSecurityCheck value for]"+"BR_Comorbidity_HapetitisB:"+StringUtil.RTrim( context.localUtil.Format( A561BR_Comorbidity_HapetitisB, "")));
         GXUtil.WriteLog("br_comorbidity:[SendSecurityCheck value for]"+"BR_Comorbidity_HapetitisB_Code:"+StringUtil.RTrim( context.localUtil.Format( A562BR_Comorbidity_HapetitisB_Code, "")));
         GXUtil.WriteLog("br_comorbidity:[SendSecurityCheck value for]"+"BR_Comorbidity_HapetitisC:"+StringUtil.RTrim( context.localUtil.Format( A563BR_Comorbidity_HapetitisC, "")));
         GXUtil.WriteLog("br_comorbidity:[SendSecurityCheck value for]"+"BR_Comorbidity_HapetitisC_Code:"+StringUtil.RTrim( context.localUtil.Format( A564BR_Comorbidity_HapetitisC_Code, "")));
         GXUtil.WriteLog("br_comorbidity:[SendSecurityCheck value for]"+"BR_Comorbidity_LiverCirrhosis:"+StringUtil.RTrim( context.localUtil.Format( A565BR_Comorbidity_LiverCirrhosis, "")));
         GXUtil.WriteLog("br_comorbidity:[SendSecurityCheck value for]"+"BR_Comorbidity_LiverCirrhosis_Code:"+StringUtil.RTrim( context.localUtil.Format( A566BR_Comorbidity_LiverCirrhosis_Code, "")));
         GXUtil.WriteLog("br_comorbidity:[SendSecurityCheck value for]"+"BR_Comorbidity_Druginducedliverinjury:"+StringUtil.RTrim( context.localUtil.Format( A567BR_Comorbidity_Druginducedliverinjury, "")));
         GXUtil.WriteLog("br_comorbidity:[SendSecurityCheck value for]"+"BR_Comorbidity_Druginducedliverinjury_Code:"+StringUtil.RTrim( context.localUtil.Format( A568BR_Comorbidity_Druginducedliverinjury_Code, "")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z37BR_ComorbidityID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z37BR_ComorbidityID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z487BR_Comorbidity_Hypertension_Code", Z487BR_Comorbidity_Hypertension_Code);
         GxWebStd.gx_hidden_field( context, "Z488BR_Comorbidity_Diabetes_Code", Z488BR_Comorbidity_Diabetes_Code);
         GxWebStd.gx_hidden_field( context, "Z489BR_Comorbidity_CHD_Code", Z489BR_Comorbidity_CHD_Code);
         GxWebStd.gx_hidden_field( context, "Z490BR_Comorbidity_Hapetitis_Code", Z490BR_Comorbidity_Hapetitis_Code);
         GxWebStd.gx_hidden_field( context, "Z491BR_Comorbidity_TB_Code", Z491BR_Comorbidity_TB_Code);
         GxWebStd.gx_hidden_field( context, "Z492BR_Comorbidity_KidneyDisease_Code", Z492BR_Comorbidity_KidneyDisease_Code);
         GxWebStd.gx_hidden_field( context, "Z493BR_Comorbidity_SurgeryHistory_Code", Z493BR_Comorbidity_SurgeryHistory_Code);
         GxWebStd.gx_hidden_field( context, "Z494BR_Comorbidity_InjuryHistory_Code", Z494BR_Comorbidity_InjuryHistory_Code);
         GxWebStd.gx_hidden_field( context, "Z495BR_Comorbidity_BloodHistory_Code", Z495BR_Comorbidity_BloodHistory_Code);
         GxWebStd.gx_hidden_field( context, "Z496BR_Comorbidity_allergy_Code", Z496BR_Comorbidity_allergy_Code);
         GxWebStd.gx_hidden_field( context, "Z38BR_Comorbidity_Hypertension", Z38BR_Comorbidity_Hypertension);
         GxWebStd.gx_hidden_field( context, "Z39BR_Comorbidity_Diabetes", Z39BR_Comorbidity_Diabetes);
         GxWebStd.gx_hidden_field( context, "Z40BR_Comorbidity_CHD", Z40BR_Comorbidity_CHD);
         GxWebStd.gx_hidden_field( context, "Z41BR_Comorbidity_Hapetitis", Z41BR_Comorbidity_Hapetitis);
         GxWebStd.gx_hidden_field( context, "Z42BR_Comorbidity_TB", Z42BR_Comorbidity_TB);
         GxWebStd.gx_hidden_field( context, "Z43BR_Comorbidity_KidneyDisease", Z43BR_Comorbidity_KidneyDisease);
         GxWebStd.gx_hidden_field( context, "Z44BR_Comorbidity_SurgeryHistory", Z44BR_Comorbidity_SurgeryHistory);
         GxWebStd.gx_hidden_field( context, "Z45BR_Comorbidity_InjuryHistory", Z45BR_Comorbidity_InjuryHistory);
         GxWebStd.gx_hidden_field( context, "Z46BR_Comorbidity_BloodHistory", Z46BR_Comorbidity_BloodHistory);
         GxWebStd.gx_hidden_field( context, "Z47BR_Comorbidity_allergy", Z47BR_Comorbidity_allergy);
         GxWebStd.gx_hidden_field( context, "Z259BR_Comorbidity_Others", Z259BR_Comorbidity_Others);
         GxWebStd.gx_hidden_field( context, "Z561BR_Comorbidity_HapetitisB", Z561BR_Comorbidity_HapetitisB);
         GxWebStd.gx_hidden_field( context, "Z562BR_Comorbidity_HapetitisB_Code", Z562BR_Comorbidity_HapetitisB_Code);
         GxWebStd.gx_hidden_field( context, "Z563BR_Comorbidity_HapetitisC", Z563BR_Comorbidity_HapetitisC);
         GxWebStd.gx_hidden_field( context, "Z564BR_Comorbidity_HapetitisC_Code", Z564BR_Comorbidity_HapetitisC_Code);
         GxWebStd.gx_hidden_field( context, "Z565BR_Comorbidity_LiverCirrhosis", Z565BR_Comorbidity_LiverCirrhosis);
         GxWebStd.gx_hidden_field( context, "Z566BR_Comorbidity_LiverCirrhosis_Code", Z566BR_Comorbidity_LiverCirrhosis_Code);
         GxWebStd.gx_hidden_field( context, "Z567BR_Comorbidity_Druginducedliverinjury", Z567BR_Comorbidity_Druginducedliverinjury);
         GxWebStd.gx_hidden_field( context, "Z568BR_Comorbidity_Druginducedliverinjury_Code", Z568BR_Comorbidity_Druginducedliverinjury_Code);
         GxWebStd.gx_hidden_field( context, "Z19BR_EncounterID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z19BR_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "BR_COMORBIDITY_HYPERTENSION_CODE", A487BR_Comorbidity_Hypertension_Code);
         GxWebStd.gx_hidden_field( context, "BR_COMORBIDITY_DIABETES_CODE", A488BR_Comorbidity_Diabetes_Code);
         GxWebStd.gx_hidden_field( context, "BR_COMORBIDITY_CHD_CODE", A489BR_Comorbidity_CHD_Code);
         GxWebStd.gx_hidden_field( context, "BR_COMORBIDITY_HAPETITIS_CODE", A490BR_Comorbidity_Hapetitis_Code);
         GxWebStd.gx_hidden_field( context, "BR_COMORBIDITY_TB_CODE", A491BR_Comorbidity_TB_Code);
         GxWebStd.gx_hidden_field( context, "BR_COMORBIDITY_KIDNEYDISEASE_CODE", A492BR_Comorbidity_KidneyDisease_Code);
         GxWebStd.gx_hidden_field( context, "BR_COMORBIDITY_SURGERYHISTORY_CODE", A493BR_Comorbidity_SurgeryHistory_Code);
         GxWebStd.gx_hidden_field( context, "BR_COMORBIDITY_INJURYHISTORY_CODE", A494BR_Comorbidity_InjuryHistory_Code);
         GxWebStd.gx_hidden_field( context, "BR_COMORBIDITY_BLOODHISTORY_CODE", A495BR_Comorbidity_BloodHistory_Code);
         GxWebStd.gx_hidden_field( context, "BR_COMORBIDITY_ALLERGY_CODE", A496BR_Comorbidity_allergy_Code);
         GxWebStd.gx_hidden_field( context, "BR_COMORBIDITY_OTHERS", A259BR_Comorbidity_Others);
         GxWebStd.gx_hidden_field( context, "BR_COMORBIDITY_HAPETITISB", A561BR_Comorbidity_HapetitisB);
         GxWebStd.gx_hidden_field( context, "BR_COMORBIDITY_HAPETITISB_CODE", A562BR_Comorbidity_HapetitisB_Code);
         GxWebStd.gx_hidden_field( context, "BR_COMORBIDITY_HAPETITISC", A563BR_Comorbidity_HapetitisC);
         GxWebStd.gx_hidden_field( context, "BR_COMORBIDITY_HAPETITISC_CODE", A564BR_Comorbidity_HapetitisC_Code);
         GxWebStd.gx_hidden_field( context, "BR_COMORBIDITY_LIVERCIRRHOSIS", A565BR_Comorbidity_LiverCirrhosis);
         GxWebStd.gx_hidden_field( context, "BR_COMORBIDITY_LIVERCIRRHOSIS_CODE", A566BR_Comorbidity_LiverCirrhosis_Code);
         GxWebStd.gx_hidden_field( context, "BR_COMORBIDITY_DRUGINDUCEDLIVERINJURY", A567BR_Comorbidity_Druginducedliverinjury);
         GxWebStd.gx_hidden_field( context, "BR_COMORBIDITY_DRUGINDUCEDLIVERINJURY_CODE", A568BR_Comorbidity_Druginducedliverinjury_Code);
         GxWebStd.gx_hidden_field( context, "BR_INFORMATION_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A85BR_Information_ID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "BR_INFORMATION_PATIENTNO", A36BR_Information_PatientNo);
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Objectcall", StringUtil.RTrim( Dvpanel_tableattributes_Objectcall));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Enabled", StringUtil.BoolToStr( Dvpanel_tableattributes_Enabled));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Width", StringUtil.RTrim( Dvpanel_tableattributes_Width));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Cls", StringUtil.RTrim( Dvpanel_tableattributes_Cls));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Title", StringUtil.RTrim( Dvpanel_tableattributes_Title));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Collapsible", StringUtil.BoolToStr( Dvpanel_tableattributes_Collapsible));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Collapsed", StringUtil.BoolToStr( Dvpanel_tableattributes_Collapsed));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Autowidth", StringUtil.BoolToStr( Dvpanel_tableattributes_Autowidth));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Autoheight", StringUtil.BoolToStr( Dvpanel_tableattributes_Autoheight));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Showcollapseicon", StringUtil.BoolToStr( Dvpanel_tableattributes_Showcollapseicon));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Iconposition", StringUtil.RTrim( Dvpanel_tableattributes_Iconposition));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Autoscroll", StringUtil.BoolToStr( Dvpanel_tableattributes_Autoscroll));
      }

      public override void RenderHtmlCloseForm( )
      {
         SendCloseFormHiddens( ) ;
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendSecurityToken(sPrefix);
         SendComponentObjects();
         SendServerCommands();
         SendState();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         context.WriteHtmlTextNl( "</form>") ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         include_jscripts( ) ;
      }

      public override short ExecuteStartEvent( )
      {
         standaloneStartup( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         return gxajaxcallmode ;
      }

      public override void RenderHtmlContent( )
      {
         context.WriteHtmlText( "<div") ;
         GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
         context.WriteHtmlText( ">") ;
         Draw( ) ;
         context.WriteHtmlText( "</div>") ;
      }

      public override void DispatchEvents( )
      {
         Process( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("br_comorbidity.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "BR_Comorbidity" ;
      }

      public override String GetPgmdesc( )
      {
         return "既往病史" ;
      }

      protected void InitializeNonKey0910( )
      {
         A85BR_Information_ID = 0;
         n85BR_Information_ID = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A85BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A85BR_Information_ID), 18, 0)));
         A487BR_Comorbidity_Hypertension_Code = "";
         n487BR_Comorbidity_Hypertension_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A487BR_Comorbidity_Hypertension_Code", A487BR_Comorbidity_Hypertension_Code);
         A488BR_Comorbidity_Diabetes_Code = "";
         n488BR_Comorbidity_Diabetes_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A488BR_Comorbidity_Diabetes_Code", A488BR_Comorbidity_Diabetes_Code);
         A489BR_Comorbidity_CHD_Code = "";
         n489BR_Comorbidity_CHD_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A489BR_Comorbidity_CHD_Code", A489BR_Comorbidity_CHD_Code);
         A490BR_Comorbidity_Hapetitis_Code = "";
         n490BR_Comorbidity_Hapetitis_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A490BR_Comorbidity_Hapetitis_Code", A490BR_Comorbidity_Hapetitis_Code);
         A491BR_Comorbidity_TB_Code = "";
         n491BR_Comorbidity_TB_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A491BR_Comorbidity_TB_Code", A491BR_Comorbidity_TB_Code);
         A492BR_Comorbidity_KidneyDisease_Code = "";
         n492BR_Comorbidity_KidneyDisease_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A492BR_Comorbidity_KidneyDisease_Code", A492BR_Comorbidity_KidneyDisease_Code);
         A493BR_Comorbidity_SurgeryHistory_Code = "";
         n493BR_Comorbidity_SurgeryHistory_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A493BR_Comorbidity_SurgeryHistory_Code", A493BR_Comorbidity_SurgeryHistory_Code);
         A494BR_Comorbidity_InjuryHistory_Code = "";
         n494BR_Comorbidity_InjuryHistory_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A494BR_Comorbidity_InjuryHistory_Code", A494BR_Comorbidity_InjuryHistory_Code);
         A495BR_Comorbidity_BloodHistory_Code = "";
         n495BR_Comorbidity_BloodHistory_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A495BR_Comorbidity_BloodHistory_Code", A495BR_Comorbidity_BloodHistory_Code);
         A496BR_Comorbidity_allergy_Code = "";
         n496BR_Comorbidity_allergy_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A496BR_Comorbidity_allergy_Code", A496BR_Comorbidity_allergy_Code);
         A19BR_EncounterID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
         A36BR_Information_PatientNo = "";
         n36BR_Information_PatientNo = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
         A38BR_Comorbidity_Hypertension = "";
         n38BR_Comorbidity_Hypertension = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38BR_Comorbidity_Hypertension", A38BR_Comorbidity_Hypertension);
         n38BR_Comorbidity_Hypertension = (String.IsNullOrEmpty(StringUtil.RTrim( A38BR_Comorbidity_Hypertension)) ? true : false);
         A39BR_Comorbidity_Diabetes = "";
         n39BR_Comorbidity_Diabetes = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39BR_Comorbidity_Diabetes", A39BR_Comorbidity_Diabetes);
         n39BR_Comorbidity_Diabetes = (String.IsNullOrEmpty(StringUtil.RTrim( A39BR_Comorbidity_Diabetes)) ? true : false);
         A40BR_Comorbidity_CHD = "";
         n40BR_Comorbidity_CHD = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40BR_Comorbidity_CHD", A40BR_Comorbidity_CHD);
         n40BR_Comorbidity_CHD = (String.IsNullOrEmpty(StringUtil.RTrim( A40BR_Comorbidity_CHD)) ? true : false);
         A41BR_Comorbidity_Hapetitis = "";
         n41BR_Comorbidity_Hapetitis = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41BR_Comorbidity_Hapetitis", A41BR_Comorbidity_Hapetitis);
         n41BR_Comorbidity_Hapetitis = (String.IsNullOrEmpty(StringUtil.RTrim( A41BR_Comorbidity_Hapetitis)) ? true : false);
         A42BR_Comorbidity_TB = "";
         n42BR_Comorbidity_TB = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BR_Comorbidity_TB", A42BR_Comorbidity_TB);
         n42BR_Comorbidity_TB = (String.IsNullOrEmpty(StringUtil.RTrim( A42BR_Comorbidity_TB)) ? true : false);
         A43BR_Comorbidity_KidneyDisease = "";
         n43BR_Comorbidity_KidneyDisease = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43BR_Comorbidity_KidneyDisease", A43BR_Comorbidity_KidneyDisease);
         n43BR_Comorbidity_KidneyDisease = (String.IsNullOrEmpty(StringUtil.RTrim( A43BR_Comorbidity_KidneyDisease)) ? true : false);
         A44BR_Comorbidity_SurgeryHistory = "";
         n44BR_Comorbidity_SurgeryHistory = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44BR_Comorbidity_SurgeryHistory", A44BR_Comorbidity_SurgeryHistory);
         n44BR_Comorbidity_SurgeryHistory = (String.IsNullOrEmpty(StringUtil.RTrim( A44BR_Comorbidity_SurgeryHistory)) ? true : false);
         A45BR_Comorbidity_InjuryHistory = "";
         n45BR_Comorbidity_InjuryHistory = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A45BR_Comorbidity_InjuryHistory", A45BR_Comorbidity_InjuryHistory);
         n45BR_Comorbidity_InjuryHistory = (String.IsNullOrEmpty(StringUtil.RTrim( A45BR_Comorbidity_InjuryHistory)) ? true : false);
         A46BR_Comorbidity_BloodHistory = "";
         n46BR_Comorbidity_BloodHistory = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46BR_Comorbidity_BloodHistory", A46BR_Comorbidity_BloodHistory);
         n46BR_Comorbidity_BloodHistory = (String.IsNullOrEmpty(StringUtil.RTrim( A46BR_Comorbidity_BloodHistory)) ? true : false);
         A47BR_Comorbidity_allergy = "";
         n47BR_Comorbidity_allergy = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A47BR_Comorbidity_allergy", A47BR_Comorbidity_allergy);
         n47BR_Comorbidity_allergy = (String.IsNullOrEmpty(StringUtil.RTrim( A47BR_Comorbidity_allergy)) ? true : false);
         A259BR_Comorbidity_Others = "";
         n259BR_Comorbidity_Others = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A259BR_Comorbidity_Others", A259BR_Comorbidity_Others);
         A561BR_Comorbidity_HapetitisB = "";
         n561BR_Comorbidity_HapetitisB = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A561BR_Comorbidity_HapetitisB", A561BR_Comorbidity_HapetitisB);
         A562BR_Comorbidity_HapetitisB_Code = "";
         n562BR_Comorbidity_HapetitisB_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A562BR_Comorbidity_HapetitisB_Code", A562BR_Comorbidity_HapetitisB_Code);
         A563BR_Comorbidity_HapetitisC = "";
         n563BR_Comorbidity_HapetitisC = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A563BR_Comorbidity_HapetitisC", A563BR_Comorbidity_HapetitisC);
         A564BR_Comorbidity_HapetitisC_Code = "";
         n564BR_Comorbidity_HapetitisC_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A564BR_Comorbidity_HapetitisC_Code", A564BR_Comorbidity_HapetitisC_Code);
         A565BR_Comorbidity_LiverCirrhosis = "";
         n565BR_Comorbidity_LiverCirrhosis = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A565BR_Comorbidity_LiverCirrhosis", A565BR_Comorbidity_LiverCirrhosis);
         A566BR_Comorbidity_LiverCirrhosis_Code = "";
         n566BR_Comorbidity_LiverCirrhosis_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A566BR_Comorbidity_LiverCirrhosis_Code", A566BR_Comorbidity_LiverCirrhosis_Code);
         A567BR_Comorbidity_Druginducedliverinjury = "";
         n567BR_Comorbidity_Druginducedliverinjury = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A567BR_Comorbidity_Druginducedliverinjury", A567BR_Comorbidity_Druginducedliverinjury);
         A568BR_Comorbidity_Druginducedliverinjury_Code = "";
         n568BR_Comorbidity_Druginducedliverinjury_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A568BR_Comorbidity_Druginducedliverinjury_Code", A568BR_Comorbidity_Druginducedliverinjury_Code);
         Z487BR_Comorbidity_Hypertension_Code = "";
         Z488BR_Comorbidity_Diabetes_Code = "";
         Z489BR_Comorbidity_CHD_Code = "";
         Z490BR_Comorbidity_Hapetitis_Code = "";
         Z491BR_Comorbidity_TB_Code = "";
         Z492BR_Comorbidity_KidneyDisease_Code = "";
         Z493BR_Comorbidity_SurgeryHistory_Code = "";
         Z494BR_Comorbidity_InjuryHistory_Code = "";
         Z495BR_Comorbidity_BloodHistory_Code = "";
         Z496BR_Comorbidity_allergy_Code = "";
         Z38BR_Comorbidity_Hypertension = "";
         Z39BR_Comorbidity_Diabetes = "";
         Z40BR_Comorbidity_CHD = "";
         Z41BR_Comorbidity_Hapetitis = "";
         Z42BR_Comorbidity_TB = "";
         Z43BR_Comorbidity_KidneyDisease = "";
         Z44BR_Comorbidity_SurgeryHistory = "";
         Z45BR_Comorbidity_InjuryHistory = "";
         Z46BR_Comorbidity_BloodHistory = "";
         Z47BR_Comorbidity_allergy = "";
         Z259BR_Comorbidity_Others = "";
         Z561BR_Comorbidity_HapetitisB = "";
         Z562BR_Comorbidity_HapetitisB_Code = "";
         Z563BR_Comorbidity_HapetitisC = "";
         Z564BR_Comorbidity_HapetitisC_Code = "";
         Z565BR_Comorbidity_LiverCirrhosis = "";
         Z566BR_Comorbidity_LiverCirrhosis_Code = "";
         Z567BR_Comorbidity_Druginducedliverinjury = "";
         Z568BR_Comorbidity_Druginducedliverinjury_Code = "";
         Z19BR_EncounterID = 0;
      }

      protected void InitAll0910( )
      {
         A37BR_ComorbidityID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37BR_ComorbidityID", StringUtil.LTrim( StringUtil.Str( (decimal)(A37BR_ComorbidityID), 18, 0)));
         InitializeNonKey0910( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ));
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202022713201516", true);
            idxLst = (int)(idxLst+1);
         }
         if ( ! outputEnabled )
         {
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.chs.js", "?"+GetCacheInvalidationToken( ), false);
         context.AddJavascriptSource("gxdec.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("br_comorbidity.js", "?202022713201516", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID";
         cmbBR_Comorbidity_Hypertension_Internalname = "BR_COMORBIDITY_HYPERTENSION";
         cmbBR_Comorbidity_Diabetes_Internalname = "BR_COMORBIDITY_DIABETES";
         cmbBR_Comorbidity_CHD_Internalname = "BR_COMORBIDITY_CHD";
         cmbBR_Comorbidity_Hapetitis_Internalname = "BR_COMORBIDITY_HAPETITIS";
         cmbBR_Comorbidity_TB_Internalname = "BR_COMORBIDITY_TB";
         cmbBR_Comorbidity_KidneyDisease_Internalname = "BR_COMORBIDITY_KIDNEYDISEASE";
         cmbBR_Comorbidity_SurgeryHistory_Internalname = "BR_COMORBIDITY_SURGERYHISTORY";
         cmbBR_Comorbidity_InjuryHistory_Internalname = "BR_COMORBIDITY_INJURYHISTORY";
         cmbBR_Comorbidity_BloodHistory_Internalname = "BR_COMORBIDITY_BLOODHISTORY";
         cmbBR_Comorbidity_allergy_Internalname = "BR_COMORBIDITY_ALLERGY";
         divTableattributes_Internalname = "TABLEATTRIBUTES";
         divLayout_tableattributes_Internalname = "LAYOUT_TABLEATTRIBUTES";
         Dvpanel_tableattributes_Internalname = "DVPANEL_TABLEATTRIBUTES";
         divHtml_dvpanel_tableattributes_Internalname = "HTML_DVPANEL_TABLEATTRIBUTES";
         divTablecontent_Internalname = "TABLECONTENT";
         bttBtntrn_enter_Internalname = "BTNTRN_ENTER";
         bttBtntrn_cancel_Internalname = "BTNTRN_CANCEL";
         bttBtntrn_delete_Internalname = "BTNTRN_DELETE";
         divTablemain_Internalname = "TABLEMAIN";
         edtBR_ComorbidityID_Internalname = "BR_COMORBIDITYID";
         divHtml_bottomauxiliarcontrols_Internalname = "HTML_BOTTOMAUXILIARCONTROLS";
         divLayoutmaintable_Internalname = "LAYOUTMAINTABLE";
         Form.Internalname = "FORM";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "既往病史";
         edtBR_ComorbidityID_Jsonclick = "";
         edtBR_ComorbidityID_Enabled = 1;
         bttBtntrn_delete_Enabled = 1;
         bttBtntrn_delete_Visible = 1;
         bttBtntrn_cancel_Visible = 1;
         bttBtntrn_enter_Enabled = 1;
         bttBtntrn_enter_Visible = 1;
         cmbBR_Comorbidity_allergy_Jsonclick = "";
         cmbBR_Comorbidity_allergy.Enabled = 1;
         cmbBR_Comorbidity_BloodHistory_Jsonclick = "";
         cmbBR_Comorbidity_BloodHistory.Enabled = 1;
         cmbBR_Comorbidity_InjuryHistory_Jsonclick = "";
         cmbBR_Comorbidity_InjuryHistory.Enabled = 1;
         cmbBR_Comorbidity_SurgeryHistory_Jsonclick = "";
         cmbBR_Comorbidity_SurgeryHistory.Enabled = 1;
         cmbBR_Comorbidity_KidneyDisease_Jsonclick = "";
         cmbBR_Comorbidity_KidneyDisease.Enabled = 1;
         cmbBR_Comorbidity_TB_Jsonclick = "";
         cmbBR_Comorbidity_TB.Enabled = 1;
         cmbBR_Comorbidity_Hapetitis_Jsonclick = "";
         cmbBR_Comorbidity_Hapetitis.Enabled = 1;
         cmbBR_Comorbidity_CHD_Jsonclick = "";
         cmbBR_Comorbidity_CHD.Enabled = 1;
         cmbBR_Comorbidity_Diabetes_Jsonclick = "";
         cmbBR_Comorbidity_Diabetes.Enabled = 1;
         cmbBR_Comorbidity_Hypertension_Jsonclick = "";
         cmbBR_Comorbidity_Hypertension.Enabled = 1;
         edtBR_EncounterID_Jsonclick = "";
         edtBR_EncounterID_Enabled = 1;
         Dvpanel_tableattributes_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Iconposition = "left";
         Dvpanel_tableattributes_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsible = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Title = "基础信息";
         Dvpanel_tableattributes_Cls = "PanelCard_BaseColor";
         Dvpanel_tableattributes_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_tableattributes_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Width = "100%";
         context.GX_msglist.DisplayMode = 1;
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void GX11ASABR_COMORBIDITY_HYPERTENSION_CODE0910( String A38BR_Comorbidity_Hypertension )
      {
         GXt_char1 = A487BR_Comorbidity_Hypertension_Code;
         new zutil_findtargetcode(context ).execute(  37,  A38BR_Comorbidity_Hypertension, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38BR_Comorbidity_Hypertension", A38BR_Comorbidity_Hypertension);
         A487BR_Comorbidity_Hypertension_Code = GXt_char1;
         n487BR_Comorbidity_Hypertension_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A487BR_Comorbidity_Hypertension_Code", A487BR_Comorbidity_Hypertension_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A487BR_Comorbidity_Hypertension_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX12ASABR_COMORBIDITY_HYPERTENSION_CODE0910( String A38BR_Comorbidity_Hypertension )
      {
         GXt_char1 = A487BR_Comorbidity_Hypertension_Code;
         new zutil_findtargetcode(context ).execute(  37,  A38BR_Comorbidity_Hypertension, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38BR_Comorbidity_Hypertension", A38BR_Comorbidity_Hypertension);
         A487BR_Comorbidity_Hypertension_Code = GXt_char1;
         n487BR_Comorbidity_Hypertension_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A487BR_Comorbidity_Hypertension_Code", A487BR_Comorbidity_Hypertension_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A487BR_Comorbidity_Hypertension_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX13ASABR_COMORBIDITY_DIABETES_CODE0910( String A39BR_Comorbidity_Diabetes )
      {
         GXt_char1 = A488BR_Comorbidity_Diabetes_Code;
         new zutil_findtargetcode(context ).execute(  37,  A39BR_Comorbidity_Diabetes, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39BR_Comorbidity_Diabetes", A39BR_Comorbidity_Diabetes);
         A488BR_Comorbidity_Diabetes_Code = GXt_char1;
         n488BR_Comorbidity_Diabetes_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A488BR_Comorbidity_Diabetes_Code", A488BR_Comorbidity_Diabetes_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A488BR_Comorbidity_Diabetes_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX14ASABR_COMORBIDITY_DIABETES_CODE0910( String A39BR_Comorbidity_Diabetes )
      {
         GXt_char1 = A488BR_Comorbidity_Diabetes_Code;
         new zutil_findtargetcode(context ).execute(  37,  A39BR_Comorbidity_Diabetes, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39BR_Comorbidity_Diabetes", A39BR_Comorbidity_Diabetes);
         A488BR_Comorbidity_Diabetes_Code = GXt_char1;
         n488BR_Comorbidity_Diabetes_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A488BR_Comorbidity_Diabetes_Code", A488BR_Comorbidity_Diabetes_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A488BR_Comorbidity_Diabetes_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX15ASABR_COMORBIDITY_CHD_CODE0910( String A40BR_Comorbidity_CHD )
      {
         GXt_char1 = A489BR_Comorbidity_CHD_Code;
         new zutil_findtargetcode(context ).execute(  37,  A40BR_Comorbidity_CHD, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40BR_Comorbidity_CHD", A40BR_Comorbidity_CHD);
         A489BR_Comorbidity_CHD_Code = GXt_char1;
         n489BR_Comorbidity_CHD_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A489BR_Comorbidity_CHD_Code", A489BR_Comorbidity_CHD_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A489BR_Comorbidity_CHD_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX16ASABR_COMORBIDITY_CHD_CODE0910( String A40BR_Comorbidity_CHD )
      {
         GXt_char1 = A489BR_Comorbidity_CHD_Code;
         new zutil_findtargetcode(context ).execute(  37,  A40BR_Comorbidity_CHD, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40BR_Comorbidity_CHD", A40BR_Comorbidity_CHD);
         A489BR_Comorbidity_CHD_Code = GXt_char1;
         n489BR_Comorbidity_CHD_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A489BR_Comorbidity_CHD_Code", A489BR_Comorbidity_CHD_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A489BR_Comorbidity_CHD_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX17ASABR_COMORBIDITY_HAPETITIS_CODE0910( String A41BR_Comorbidity_Hapetitis )
      {
         GXt_char1 = A490BR_Comorbidity_Hapetitis_Code;
         new zutil_findtargetcode(context ).execute(  37,  A41BR_Comorbidity_Hapetitis, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41BR_Comorbidity_Hapetitis", A41BR_Comorbidity_Hapetitis);
         A490BR_Comorbidity_Hapetitis_Code = GXt_char1;
         n490BR_Comorbidity_Hapetitis_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A490BR_Comorbidity_Hapetitis_Code", A490BR_Comorbidity_Hapetitis_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A490BR_Comorbidity_Hapetitis_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX18ASABR_COMORBIDITY_HAPETITIS_CODE0910( String A41BR_Comorbidity_Hapetitis )
      {
         GXt_char1 = A490BR_Comorbidity_Hapetitis_Code;
         new zutil_findtargetcode(context ).execute(  37,  A41BR_Comorbidity_Hapetitis, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41BR_Comorbidity_Hapetitis", A41BR_Comorbidity_Hapetitis);
         A490BR_Comorbidity_Hapetitis_Code = GXt_char1;
         n490BR_Comorbidity_Hapetitis_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A490BR_Comorbidity_Hapetitis_Code", A490BR_Comorbidity_Hapetitis_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A490BR_Comorbidity_Hapetitis_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX19ASABR_COMORBIDITY_TB_CODE0910( String A42BR_Comorbidity_TB )
      {
         GXt_char1 = A491BR_Comorbidity_TB_Code;
         new zutil_findtargetcode(context ).execute(  37,  A42BR_Comorbidity_TB, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BR_Comorbidity_TB", A42BR_Comorbidity_TB);
         A491BR_Comorbidity_TB_Code = GXt_char1;
         n491BR_Comorbidity_TB_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A491BR_Comorbidity_TB_Code", A491BR_Comorbidity_TB_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A491BR_Comorbidity_TB_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX20ASABR_COMORBIDITY_TB_CODE0910( String A42BR_Comorbidity_TB )
      {
         GXt_char1 = A491BR_Comorbidity_TB_Code;
         new zutil_findtargetcode(context ).execute(  37,  A42BR_Comorbidity_TB, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BR_Comorbidity_TB", A42BR_Comorbidity_TB);
         A491BR_Comorbidity_TB_Code = GXt_char1;
         n491BR_Comorbidity_TB_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A491BR_Comorbidity_TB_Code", A491BR_Comorbidity_TB_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A491BR_Comorbidity_TB_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX21ASABR_COMORBIDITY_KIDNEYDISEASE_CODE0910( String A43BR_Comorbidity_KidneyDisease )
      {
         GXt_char1 = A492BR_Comorbidity_KidneyDisease_Code;
         new zutil_findtargetcode(context ).execute(  37,  A43BR_Comorbidity_KidneyDisease, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43BR_Comorbidity_KidneyDisease", A43BR_Comorbidity_KidneyDisease);
         A492BR_Comorbidity_KidneyDisease_Code = GXt_char1;
         n492BR_Comorbidity_KidneyDisease_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A492BR_Comorbidity_KidneyDisease_Code", A492BR_Comorbidity_KidneyDisease_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A492BR_Comorbidity_KidneyDisease_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX22ASABR_COMORBIDITY_KIDNEYDISEASE_CODE0910( String A43BR_Comorbidity_KidneyDisease )
      {
         GXt_char1 = A492BR_Comorbidity_KidneyDisease_Code;
         new zutil_findtargetcode(context ).execute(  37,  A43BR_Comorbidity_KidneyDisease, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43BR_Comorbidity_KidneyDisease", A43BR_Comorbidity_KidneyDisease);
         A492BR_Comorbidity_KidneyDisease_Code = GXt_char1;
         n492BR_Comorbidity_KidneyDisease_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A492BR_Comorbidity_KidneyDisease_Code", A492BR_Comorbidity_KidneyDisease_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A492BR_Comorbidity_KidneyDisease_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX23ASABR_COMORBIDITY_SURGERYHISTORY_CODE0910( String A44BR_Comorbidity_SurgeryHistory )
      {
         GXt_char1 = A493BR_Comorbidity_SurgeryHistory_Code;
         new zutil_findtargetcode(context ).execute(  37,  A44BR_Comorbidity_SurgeryHistory, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44BR_Comorbidity_SurgeryHistory", A44BR_Comorbidity_SurgeryHistory);
         A493BR_Comorbidity_SurgeryHistory_Code = GXt_char1;
         n493BR_Comorbidity_SurgeryHistory_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A493BR_Comorbidity_SurgeryHistory_Code", A493BR_Comorbidity_SurgeryHistory_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A493BR_Comorbidity_SurgeryHistory_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX24ASABR_COMORBIDITY_SURGERYHISTORY_CODE0910( String A44BR_Comorbidity_SurgeryHistory )
      {
         GXt_char1 = A493BR_Comorbidity_SurgeryHistory_Code;
         new zutil_findtargetcode(context ).execute(  37,  A44BR_Comorbidity_SurgeryHistory, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44BR_Comorbidity_SurgeryHistory", A44BR_Comorbidity_SurgeryHistory);
         A493BR_Comorbidity_SurgeryHistory_Code = GXt_char1;
         n493BR_Comorbidity_SurgeryHistory_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A493BR_Comorbidity_SurgeryHistory_Code", A493BR_Comorbidity_SurgeryHistory_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A493BR_Comorbidity_SurgeryHistory_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX25ASABR_COMORBIDITY_INJURYHISTORY_CODE0910( String A45BR_Comorbidity_InjuryHistory )
      {
         GXt_char1 = A494BR_Comorbidity_InjuryHistory_Code;
         new zutil_findtargetcode(context ).execute(  37,  A45BR_Comorbidity_InjuryHistory, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A45BR_Comorbidity_InjuryHistory", A45BR_Comorbidity_InjuryHistory);
         A494BR_Comorbidity_InjuryHistory_Code = GXt_char1;
         n494BR_Comorbidity_InjuryHistory_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A494BR_Comorbidity_InjuryHistory_Code", A494BR_Comorbidity_InjuryHistory_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A494BR_Comorbidity_InjuryHistory_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX26ASABR_COMORBIDITY_INJURYHISTORY_CODE0910( String A45BR_Comorbidity_InjuryHistory )
      {
         GXt_char1 = A494BR_Comorbidity_InjuryHistory_Code;
         new zutil_findtargetcode(context ).execute(  37,  A45BR_Comorbidity_InjuryHistory, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A45BR_Comorbidity_InjuryHistory", A45BR_Comorbidity_InjuryHistory);
         A494BR_Comorbidity_InjuryHistory_Code = GXt_char1;
         n494BR_Comorbidity_InjuryHistory_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A494BR_Comorbidity_InjuryHistory_Code", A494BR_Comorbidity_InjuryHistory_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A494BR_Comorbidity_InjuryHistory_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX27ASABR_COMORBIDITY_BLOODHISTORY_CODE0910( String A46BR_Comorbidity_BloodHistory )
      {
         GXt_char1 = A495BR_Comorbidity_BloodHistory_Code;
         new zutil_findtargetcode(context ).execute(  37,  A46BR_Comorbidity_BloodHistory, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46BR_Comorbidity_BloodHistory", A46BR_Comorbidity_BloodHistory);
         A495BR_Comorbidity_BloodHistory_Code = GXt_char1;
         n495BR_Comorbidity_BloodHistory_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A495BR_Comorbidity_BloodHistory_Code", A495BR_Comorbidity_BloodHistory_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A495BR_Comorbidity_BloodHistory_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX28ASABR_COMORBIDITY_BLOODHISTORY_CODE0910( String A46BR_Comorbidity_BloodHistory )
      {
         GXt_char1 = A495BR_Comorbidity_BloodHistory_Code;
         new zutil_findtargetcode(context ).execute(  37,  A46BR_Comorbidity_BloodHistory, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46BR_Comorbidity_BloodHistory", A46BR_Comorbidity_BloodHistory);
         A495BR_Comorbidity_BloodHistory_Code = GXt_char1;
         n495BR_Comorbidity_BloodHistory_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A495BR_Comorbidity_BloodHistory_Code", A495BR_Comorbidity_BloodHistory_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A495BR_Comorbidity_BloodHistory_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX29ASABR_COMORBIDITY_ALLERGY_CODE0910( String A47BR_Comorbidity_allergy )
      {
         GXt_char1 = A496BR_Comorbidity_allergy_Code;
         new zutil_findtargetcode(context ).execute(  37,  A47BR_Comorbidity_allergy, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A47BR_Comorbidity_allergy", A47BR_Comorbidity_allergy);
         A496BR_Comorbidity_allergy_Code = GXt_char1;
         n496BR_Comorbidity_allergy_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A496BR_Comorbidity_allergy_Code", A496BR_Comorbidity_allergy_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A496BR_Comorbidity_allergy_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX30ASABR_COMORBIDITY_ALLERGY_CODE0910( String A47BR_Comorbidity_allergy )
      {
         GXt_char1 = A496BR_Comorbidity_allergy_Code;
         new zutil_findtargetcode(context ).execute(  37,  A47BR_Comorbidity_allergy, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A47BR_Comorbidity_allergy", A47BR_Comorbidity_allergy);
         A496BR_Comorbidity_allergy_Code = GXt_char1;
         n496BR_Comorbidity_allergy_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A496BR_Comorbidity_allergy_Code", A496BR_Comorbidity_allergy_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A496BR_Comorbidity_allergy_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void init_web_controls( )
      {
         cmbBR_Comorbidity_Hypertension.Name = "BR_COMORBIDITY_HYPERTENSION";
         cmbBR_Comorbidity_Hypertension.WebTags = "";
         cmbBR_Comorbidity_Hypertension.addItem("", "(请选择)", 0);
         cmbBR_Comorbidity_Hypertension.addItem("否", "否", 0);
         cmbBR_Comorbidity_Hypertension.addItem("是", "是", 0);
         cmbBR_Comorbidity_Hypertension.addItem("不详", "不详", 0);
         if ( cmbBR_Comorbidity_Hypertension.ItemCount > 0 )
         {
            A38BR_Comorbidity_Hypertension = cmbBR_Comorbidity_Hypertension.getValidValue(A38BR_Comorbidity_Hypertension);
            n38BR_Comorbidity_Hypertension = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38BR_Comorbidity_Hypertension", A38BR_Comorbidity_Hypertension);
         }
         cmbBR_Comorbidity_Diabetes.Name = "BR_COMORBIDITY_DIABETES";
         cmbBR_Comorbidity_Diabetes.WebTags = "";
         cmbBR_Comorbidity_Diabetes.addItem("", "(请选择)", 0);
         cmbBR_Comorbidity_Diabetes.addItem("否", "否", 0);
         cmbBR_Comorbidity_Diabetes.addItem("是", "是", 0);
         cmbBR_Comorbidity_Diabetes.addItem("不详", "不详", 0);
         if ( cmbBR_Comorbidity_Diabetes.ItemCount > 0 )
         {
            A39BR_Comorbidity_Diabetes = cmbBR_Comorbidity_Diabetes.getValidValue(A39BR_Comorbidity_Diabetes);
            n39BR_Comorbidity_Diabetes = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39BR_Comorbidity_Diabetes", A39BR_Comorbidity_Diabetes);
         }
         cmbBR_Comorbidity_CHD.Name = "BR_COMORBIDITY_CHD";
         cmbBR_Comorbidity_CHD.WebTags = "";
         cmbBR_Comorbidity_CHD.addItem("", "(请选择)", 0);
         cmbBR_Comorbidity_CHD.addItem("否", "否", 0);
         cmbBR_Comorbidity_CHD.addItem("是", "是", 0);
         cmbBR_Comorbidity_CHD.addItem("不详", "不详", 0);
         if ( cmbBR_Comorbidity_CHD.ItemCount > 0 )
         {
            A40BR_Comorbidity_CHD = cmbBR_Comorbidity_CHD.getValidValue(A40BR_Comorbidity_CHD);
            n40BR_Comorbidity_CHD = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40BR_Comorbidity_CHD", A40BR_Comorbidity_CHD);
         }
         cmbBR_Comorbidity_Hapetitis.Name = "BR_COMORBIDITY_HAPETITIS";
         cmbBR_Comorbidity_Hapetitis.WebTags = "";
         cmbBR_Comorbidity_Hapetitis.addItem("", "(请选择)", 0);
         cmbBR_Comorbidity_Hapetitis.addItem("否", "否", 0);
         cmbBR_Comorbidity_Hapetitis.addItem("是", "是", 0);
         cmbBR_Comorbidity_Hapetitis.addItem("不详", "不详", 0);
         if ( cmbBR_Comorbidity_Hapetitis.ItemCount > 0 )
         {
            A41BR_Comorbidity_Hapetitis = cmbBR_Comorbidity_Hapetitis.getValidValue(A41BR_Comorbidity_Hapetitis);
            n41BR_Comorbidity_Hapetitis = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41BR_Comorbidity_Hapetitis", A41BR_Comorbidity_Hapetitis);
         }
         cmbBR_Comorbidity_TB.Name = "BR_COMORBIDITY_TB";
         cmbBR_Comorbidity_TB.WebTags = "";
         cmbBR_Comorbidity_TB.addItem("", "(请选择)", 0);
         cmbBR_Comorbidity_TB.addItem("否", "否", 0);
         cmbBR_Comorbidity_TB.addItem("是", "是", 0);
         cmbBR_Comorbidity_TB.addItem("不详", "不详", 0);
         if ( cmbBR_Comorbidity_TB.ItemCount > 0 )
         {
            A42BR_Comorbidity_TB = cmbBR_Comorbidity_TB.getValidValue(A42BR_Comorbidity_TB);
            n42BR_Comorbidity_TB = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42BR_Comorbidity_TB", A42BR_Comorbidity_TB);
         }
         cmbBR_Comorbidity_KidneyDisease.Name = "BR_COMORBIDITY_KIDNEYDISEASE";
         cmbBR_Comorbidity_KidneyDisease.WebTags = "";
         cmbBR_Comorbidity_KidneyDisease.addItem("", "(请选择)", 0);
         cmbBR_Comorbidity_KidneyDisease.addItem("否", "否", 0);
         cmbBR_Comorbidity_KidneyDisease.addItem("是", "是", 0);
         cmbBR_Comorbidity_KidneyDisease.addItem("不详", "不详", 0);
         if ( cmbBR_Comorbidity_KidneyDisease.ItemCount > 0 )
         {
            A43BR_Comorbidity_KidneyDisease = cmbBR_Comorbidity_KidneyDisease.getValidValue(A43BR_Comorbidity_KidneyDisease);
            n43BR_Comorbidity_KidneyDisease = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A43BR_Comorbidity_KidneyDisease", A43BR_Comorbidity_KidneyDisease);
         }
         cmbBR_Comorbidity_SurgeryHistory.Name = "BR_COMORBIDITY_SURGERYHISTORY";
         cmbBR_Comorbidity_SurgeryHistory.WebTags = "";
         cmbBR_Comorbidity_SurgeryHistory.addItem("", "(请选择)", 0);
         cmbBR_Comorbidity_SurgeryHistory.addItem("否", "否", 0);
         cmbBR_Comorbidity_SurgeryHistory.addItem("是", "是", 0);
         cmbBR_Comorbidity_SurgeryHistory.addItem("不详", "不详", 0);
         if ( cmbBR_Comorbidity_SurgeryHistory.ItemCount > 0 )
         {
            A44BR_Comorbidity_SurgeryHistory = cmbBR_Comorbidity_SurgeryHistory.getValidValue(A44BR_Comorbidity_SurgeryHistory);
            n44BR_Comorbidity_SurgeryHistory = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A44BR_Comorbidity_SurgeryHistory", A44BR_Comorbidity_SurgeryHistory);
         }
         cmbBR_Comorbidity_InjuryHistory.Name = "BR_COMORBIDITY_INJURYHISTORY";
         cmbBR_Comorbidity_InjuryHistory.WebTags = "";
         cmbBR_Comorbidity_InjuryHistory.addItem("", "(请选择)", 0);
         cmbBR_Comorbidity_InjuryHistory.addItem("否", "否", 0);
         cmbBR_Comorbidity_InjuryHistory.addItem("是", "是", 0);
         cmbBR_Comorbidity_InjuryHistory.addItem("不详", "不详", 0);
         if ( cmbBR_Comorbidity_InjuryHistory.ItemCount > 0 )
         {
            A45BR_Comorbidity_InjuryHistory = cmbBR_Comorbidity_InjuryHistory.getValidValue(A45BR_Comorbidity_InjuryHistory);
            n45BR_Comorbidity_InjuryHistory = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A45BR_Comorbidity_InjuryHistory", A45BR_Comorbidity_InjuryHistory);
         }
         cmbBR_Comorbidity_BloodHistory.Name = "BR_COMORBIDITY_BLOODHISTORY";
         cmbBR_Comorbidity_BloodHistory.WebTags = "";
         cmbBR_Comorbidity_BloodHistory.addItem("", "(请选择)", 0);
         cmbBR_Comorbidity_BloodHistory.addItem("否", "否", 0);
         cmbBR_Comorbidity_BloodHistory.addItem("是", "是", 0);
         cmbBR_Comorbidity_BloodHistory.addItem("不详", "不详", 0);
         if ( cmbBR_Comorbidity_BloodHistory.ItemCount > 0 )
         {
            A46BR_Comorbidity_BloodHistory = cmbBR_Comorbidity_BloodHistory.getValidValue(A46BR_Comorbidity_BloodHistory);
            n46BR_Comorbidity_BloodHistory = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A46BR_Comorbidity_BloodHistory", A46BR_Comorbidity_BloodHistory);
         }
         cmbBR_Comorbidity_allergy.Name = "BR_COMORBIDITY_ALLERGY";
         cmbBR_Comorbidity_allergy.WebTags = "";
         cmbBR_Comorbidity_allergy.addItem("", "(请选择)", 0);
         cmbBR_Comorbidity_allergy.addItem("否", "否", 0);
         cmbBR_Comorbidity_allergy.addItem("是", "是", 0);
         cmbBR_Comorbidity_allergy.addItem("不详", "不详", 0);
         if ( cmbBR_Comorbidity_allergy.ItemCount > 0 )
         {
            A47BR_Comorbidity_allergy = cmbBR_Comorbidity_allergy.getValidValue(A47BR_Comorbidity_allergy);
            n47BR_Comorbidity_allergy = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A47BR_Comorbidity_allergy", A47BR_Comorbidity_allergy);
         }
         /* End function init_web_controls */
      }

      protected void AfterKeyLoadScreen( )
      {
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         getEqualNoModal( ) ;
         GX_FocusControl = edtBR_EncounterID_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Br_comorbidityid( long GX_Parm1 ,
                                          String GX_Parm2 ,
                                          String GX_Parm3 ,
                                          String GX_Parm4 ,
                                          String GX_Parm5 ,
                                          String GX_Parm6 ,
                                          String GX_Parm7 ,
                                          String GX_Parm8 ,
                                          String GX_Parm9 ,
                                          String GX_Parm10 ,
                                          String GX_Parm11 ,
                                          GXCombobox cmbGX_Parm12 ,
                                          GXCombobox cmbGX_Parm13 ,
                                          GXCombobox cmbGX_Parm14 ,
                                          GXCombobox cmbGX_Parm15 ,
                                          GXCombobox cmbGX_Parm16 ,
                                          GXCombobox cmbGX_Parm17 ,
                                          GXCombobox cmbGX_Parm18 ,
                                          GXCombobox cmbGX_Parm19 ,
                                          GXCombobox cmbGX_Parm20 ,
                                          GXCombobox cmbGX_Parm21 ,
                                          String GX_Parm22 ,
                                          String GX_Parm23 ,
                                          String GX_Parm24 ,
                                          String GX_Parm25 ,
                                          String GX_Parm26 ,
                                          String GX_Parm27 ,
                                          String GX_Parm28 ,
                                          String GX_Parm29 ,
                                          String GX_Parm30 ,
                                          long GX_Parm31 )
      {
         A37BR_ComorbidityID = GX_Parm1;
         A487BR_Comorbidity_Hypertension_Code = GX_Parm2;
         n487BR_Comorbidity_Hypertension_Code = false;
         A488BR_Comorbidity_Diabetes_Code = GX_Parm3;
         n488BR_Comorbidity_Diabetes_Code = false;
         A489BR_Comorbidity_CHD_Code = GX_Parm4;
         n489BR_Comorbidity_CHD_Code = false;
         A490BR_Comorbidity_Hapetitis_Code = GX_Parm5;
         n490BR_Comorbidity_Hapetitis_Code = false;
         A491BR_Comorbidity_TB_Code = GX_Parm6;
         n491BR_Comorbidity_TB_Code = false;
         A492BR_Comorbidity_KidneyDisease_Code = GX_Parm7;
         n492BR_Comorbidity_KidneyDisease_Code = false;
         A493BR_Comorbidity_SurgeryHistory_Code = GX_Parm8;
         n493BR_Comorbidity_SurgeryHistory_Code = false;
         A494BR_Comorbidity_InjuryHistory_Code = GX_Parm9;
         n494BR_Comorbidity_InjuryHistory_Code = false;
         A495BR_Comorbidity_BloodHistory_Code = GX_Parm10;
         n495BR_Comorbidity_BloodHistory_Code = false;
         A496BR_Comorbidity_allergy_Code = GX_Parm11;
         n496BR_Comorbidity_allergy_Code = false;
         cmbBR_Comorbidity_Hypertension = cmbGX_Parm12;
         A38BR_Comorbidity_Hypertension = cmbBR_Comorbidity_Hypertension.CurrentValue;
         n38BR_Comorbidity_Hypertension = false;
         cmbBR_Comorbidity_Hypertension.CurrentValue = A38BR_Comorbidity_Hypertension;
         cmbBR_Comorbidity_Diabetes = cmbGX_Parm13;
         A39BR_Comorbidity_Diabetes = cmbBR_Comorbidity_Diabetes.CurrentValue;
         n39BR_Comorbidity_Diabetes = false;
         cmbBR_Comorbidity_Diabetes.CurrentValue = A39BR_Comorbidity_Diabetes;
         cmbBR_Comorbidity_CHD = cmbGX_Parm14;
         A40BR_Comorbidity_CHD = cmbBR_Comorbidity_CHD.CurrentValue;
         n40BR_Comorbidity_CHD = false;
         cmbBR_Comorbidity_CHD.CurrentValue = A40BR_Comorbidity_CHD;
         cmbBR_Comorbidity_Hapetitis = cmbGX_Parm15;
         A41BR_Comorbidity_Hapetitis = cmbBR_Comorbidity_Hapetitis.CurrentValue;
         n41BR_Comorbidity_Hapetitis = false;
         cmbBR_Comorbidity_Hapetitis.CurrentValue = A41BR_Comorbidity_Hapetitis;
         cmbBR_Comorbidity_TB = cmbGX_Parm16;
         A42BR_Comorbidity_TB = cmbBR_Comorbidity_TB.CurrentValue;
         n42BR_Comorbidity_TB = false;
         cmbBR_Comorbidity_TB.CurrentValue = A42BR_Comorbidity_TB;
         cmbBR_Comorbidity_KidneyDisease = cmbGX_Parm17;
         A43BR_Comorbidity_KidneyDisease = cmbBR_Comorbidity_KidneyDisease.CurrentValue;
         n43BR_Comorbidity_KidneyDisease = false;
         cmbBR_Comorbidity_KidneyDisease.CurrentValue = A43BR_Comorbidity_KidneyDisease;
         cmbBR_Comorbidity_SurgeryHistory = cmbGX_Parm18;
         A44BR_Comorbidity_SurgeryHistory = cmbBR_Comorbidity_SurgeryHistory.CurrentValue;
         n44BR_Comorbidity_SurgeryHistory = false;
         cmbBR_Comorbidity_SurgeryHistory.CurrentValue = A44BR_Comorbidity_SurgeryHistory;
         cmbBR_Comorbidity_InjuryHistory = cmbGX_Parm19;
         A45BR_Comorbidity_InjuryHistory = cmbBR_Comorbidity_InjuryHistory.CurrentValue;
         n45BR_Comorbidity_InjuryHistory = false;
         cmbBR_Comorbidity_InjuryHistory.CurrentValue = A45BR_Comorbidity_InjuryHistory;
         cmbBR_Comorbidity_BloodHistory = cmbGX_Parm20;
         A46BR_Comorbidity_BloodHistory = cmbBR_Comorbidity_BloodHistory.CurrentValue;
         n46BR_Comorbidity_BloodHistory = false;
         cmbBR_Comorbidity_BloodHistory.CurrentValue = A46BR_Comorbidity_BloodHistory;
         cmbBR_Comorbidity_allergy = cmbGX_Parm21;
         A47BR_Comorbidity_allergy = cmbBR_Comorbidity_allergy.CurrentValue;
         n47BR_Comorbidity_allergy = false;
         cmbBR_Comorbidity_allergy.CurrentValue = A47BR_Comorbidity_allergy;
         A259BR_Comorbidity_Others = GX_Parm22;
         n259BR_Comorbidity_Others = false;
         A561BR_Comorbidity_HapetitisB = GX_Parm23;
         n561BR_Comorbidity_HapetitisB = false;
         A562BR_Comorbidity_HapetitisB_Code = GX_Parm24;
         n562BR_Comorbidity_HapetitisB_Code = false;
         A563BR_Comorbidity_HapetitisC = GX_Parm25;
         n563BR_Comorbidity_HapetitisC = false;
         A564BR_Comorbidity_HapetitisC_Code = GX_Parm26;
         n564BR_Comorbidity_HapetitisC_Code = false;
         A565BR_Comorbidity_LiverCirrhosis = GX_Parm27;
         n565BR_Comorbidity_LiverCirrhosis = false;
         A566BR_Comorbidity_LiverCirrhosis_Code = GX_Parm28;
         n566BR_Comorbidity_LiverCirrhosis_Code = false;
         A567BR_Comorbidity_Druginducedliverinjury = GX_Parm29;
         n567BR_Comorbidity_Druginducedliverinjury = false;
         A568BR_Comorbidity_Druginducedliverinjury_Code = GX_Parm30;
         n568BR_Comorbidity_Druginducedliverinjury_Code = false;
         A19BR_EncounterID = GX_Parm31;
         context.wbHandled = 1;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         send_integrity_footer_hashes( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A85BR_Information_ID = 0;
            n85BR_Information_ID = false;
            A36BR_Information_PatientNo = "";
            n36BR_Information_PatientNo = false;
         }
         isValidOutput.Add(A487BR_Comorbidity_Hypertension_Code);
         isValidOutput.Add(A488BR_Comorbidity_Diabetes_Code);
         isValidOutput.Add(A489BR_Comorbidity_CHD_Code);
         isValidOutput.Add(A490BR_Comorbidity_Hapetitis_Code);
         isValidOutput.Add(A491BR_Comorbidity_TB_Code);
         isValidOutput.Add(A492BR_Comorbidity_KidneyDisease_Code);
         isValidOutput.Add(A493BR_Comorbidity_SurgeryHistory_Code);
         isValidOutput.Add(A494BR_Comorbidity_InjuryHistory_Code);
         isValidOutput.Add(A495BR_Comorbidity_BloodHistory_Code);
         isValidOutput.Add(A496BR_Comorbidity_allergy_Code);
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")));
         cmbBR_Comorbidity_Hypertension.CurrentValue = A38BR_Comorbidity_Hypertension;
         isValidOutput.Add(cmbBR_Comorbidity_Hypertension);
         cmbBR_Comorbidity_Diabetes.CurrentValue = A39BR_Comorbidity_Diabetes;
         isValidOutput.Add(cmbBR_Comorbidity_Diabetes);
         cmbBR_Comorbidity_CHD.CurrentValue = A40BR_Comorbidity_CHD;
         isValidOutput.Add(cmbBR_Comorbidity_CHD);
         cmbBR_Comorbidity_Hapetitis.CurrentValue = A41BR_Comorbidity_Hapetitis;
         isValidOutput.Add(cmbBR_Comorbidity_Hapetitis);
         cmbBR_Comorbidity_TB.CurrentValue = A42BR_Comorbidity_TB;
         isValidOutput.Add(cmbBR_Comorbidity_TB);
         cmbBR_Comorbidity_KidneyDisease.CurrentValue = A43BR_Comorbidity_KidneyDisease;
         isValidOutput.Add(cmbBR_Comorbidity_KidneyDisease);
         cmbBR_Comorbidity_SurgeryHistory.CurrentValue = A44BR_Comorbidity_SurgeryHistory;
         isValidOutput.Add(cmbBR_Comorbidity_SurgeryHistory);
         cmbBR_Comorbidity_InjuryHistory.CurrentValue = A45BR_Comorbidity_InjuryHistory;
         isValidOutput.Add(cmbBR_Comorbidity_InjuryHistory);
         cmbBR_Comorbidity_BloodHistory.CurrentValue = A46BR_Comorbidity_BloodHistory;
         isValidOutput.Add(cmbBR_Comorbidity_BloodHistory);
         cmbBR_Comorbidity_allergy.CurrentValue = A47BR_Comorbidity_allergy;
         isValidOutput.Add(cmbBR_Comorbidity_allergy);
         isValidOutput.Add(A259BR_Comorbidity_Others);
         isValidOutput.Add(A561BR_Comorbidity_HapetitisB);
         isValidOutput.Add(A562BR_Comorbidity_HapetitisB_Code);
         isValidOutput.Add(A563BR_Comorbidity_HapetitisC);
         isValidOutput.Add(A564BR_Comorbidity_HapetitisC_Code);
         isValidOutput.Add(A565BR_Comorbidity_LiverCirrhosis);
         isValidOutput.Add(A566BR_Comorbidity_LiverCirrhosis_Code);
         isValidOutput.Add(A567BR_Comorbidity_Druginducedliverinjury);
         isValidOutput.Add(A568BR_Comorbidity_Druginducedliverinjury_Code);
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A85BR_Information_ID), 18, 0, ".", "")));
         isValidOutput.Add(A36BR_Information_PatientNo);
         isValidOutput.Add(StringUtil.RTrim( Gx_mode));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z37BR_ComorbidityID), 18, 0, ".", "")));
         isValidOutput.Add(Z487BR_Comorbidity_Hypertension_Code);
         isValidOutput.Add(Z488BR_Comorbidity_Diabetes_Code);
         isValidOutput.Add(Z489BR_Comorbidity_CHD_Code);
         isValidOutput.Add(Z490BR_Comorbidity_Hapetitis_Code);
         isValidOutput.Add(Z491BR_Comorbidity_TB_Code);
         isValidOutput.Add(Z492BR_Comorbidity_KidneyDisease_Code);
         isValidOutput.Add(Z493BR_Comorbidity_SurgeryHistory_Code);
         isValidOutput.Add(Z494BR_Comorbidity_InjuryHistory_Code);
         isValidOutput.Add(Z495BR_Comorbidity_BloodHistory_Code);
         isValidOutput.Add(Z496BR_Comorbidity_allergy_Code);
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z19BR_EncounterID), 18, 0, ".", "")));
         isValidOutput.Add(Z38BR_Comorbidity_Hypertension);
         isValidOutput.Add(Z39BR_Comorbidity_Diabetes);
         isValidOutput.Add(Z40BR_Comorbidity_CHD);
         isValidOutput.Add(Z41BR_Comorbidity_Hapetitis);
         isValidOutput.Add(Z42BR_Comorbidity_TB);
         isValidOutput.Add(Z43BR_Comorbidity_KidneyDisease);
         isValidOutput.Add(Z44BR_Comorbidity_SurgeryHistory);
         isValidOutput.Add(Z45BR_Comorbidity_InjuryHistory);
         isValidOutput.Add(Z46BR_Comorbidity_BloodHistory);
         isValidOutput.Add(Z47BR_Comorbidity_allergy);
         isValidOutput.Add(Z259BR_Comorbidity_Others);
         isValidOutput.Add(Z561BR_Comorbidity_HapetitisB);
         isValidOutput.Add(Z562BR_Comorbidity_HapetitisB_Code);
         isValidOutput.Add(Z563BR_Comorbidity_HapetitisC);
         isValidOutput.Add(Z564BR_Comorbidity_HapetitisC_Code);
         isValidOutput.Add(Z565BR_Comorbidity_LiverCirrhosis);
         isValidOutput.Add(Z566BR_Comorbidity_LiverCirrhosis_Code);
         isValidOutput.Add(Z567BR_Comorbidity_Druginducedliverinjury);
         isValidOutput.Add(Z568BR_Comorbidity_Druginducedliverinjury_Code);
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z85BR_Information_ID), 18, 0, ".", "")));
         isValidOutput.Add(Z36BR_Information_PatientNo);
         isValidOutput.Add(bttBtntrn_delete_Enabled);
         isValidOutput.Add(bttBtntrn_enter_Enabled);
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Br_encounterid( long GX_Parm1 ,
                                        long GX_Parm2 ,
                                        String GX_Parm3 )
      {
         A19BR_EncounterID = GX_Parm1;
         A85BR_Information_ID = GX_Parm2;
         n85BR_Information_ID = false;
         A36BR_Information_PatientNo = GX_Parm3;
         n36BR_Information_PatientNo = false;
         /* Using cursor T000915 */
         pr_default.execute(13, new Object[] {A19BR_EncounterID});
         if ( (pr_default.getStatus(13) == 101) )
         {
            GX_msglist.addItem("不匹配' T15'", "ForeignKeyNotFound", 1, "BR_ENCOUNTERID");
            AnyError = 1;
            GX_FocusControl = edtBR_EncounterID_Internalname;
         }
         A85BR_Information_ID = T000915_A85BR_Information_ID[0];
         n85BR_Information_ID = T000915_n85BR_Information_ID[0];
         pr_default.close(13);
         /* Using cursor T000916 */
         pr_default.execute(14, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
         if ( (pr_default.getStatus(14) == 101) )
         {
            if ( ! ( (0==A85BR_Information_ID) ) )
            {
               GX_msglist.addItem("不匹配' T16'", "ForeignKeyNotFound", 1, "");
               AnyError = 1;
            }
         }
         A36BR_Information_PatientNo = T000916_A36BR_Information_PatientNo[0];
         n36BR_Information_PatientNo = T000916_n36BR_Information_PatientNo[0];
         pr_default.close(14);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A85BR_Information_ID = 0;
            n85BR_Information_ID = false;
            A36BR_Information_PatientNo = "";
            n36BR_Information_PatientNo = false;
         }
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A85BR_Information_ID), 18, 0, ".", "")));
         isValidOutput.Add(A36BR_Information_PatientNo);
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'A259BR_Comorbidity_Others',fld:'BR_COMORBIDITY_OTHERS',pic:''},{av:'A561BR_Comorbidity_HapetitisB',fld:'BR_COMORBIDITY_HAPETITISB',pic:''},{av:'A562BR_Comorbidity_HapetitisB_Code',fld:'BR_COMORBIDITY_HAPETITISB_CODE',pic:''},{av:'A563BR_Comorbidity_HapetitisC',fld:'BR_COMORBIDITY_HAPETITISC',pic:''},{av:'A564BR_Comorbidity_HapetitisC_Code',fld:'BR_COMORBIDITY_HAPETITISC_CODE',pic:''},{av:'A565BR_Comorbidity_LiverCirrhosis',fld:'BR_COMORBIDITY_LIVERCIRRHOSIS',pic:''},{av:'A566BR_Comorbidity_LiverCirrhosis_Code',fld:'BR_COMORBIDITY_LIVERCIRRHOSIS_CODE',pic:''},{av:'A567BR_Comorbidity_Druginducedliverinjury',fld:'BR_COMORBIDITY_DRUGINDUCEDLIVERINJURY',pic:''},{av:'A568BR_Comorbidity_Druginducedliverinjury_Code',fld:'BR_COMORBIDITY_DRUGINDUCEDLIVERINJURY_CODE',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E12092',iparms:[]");
         setEventMetadata("AFTER TRN",",oparms:[]}");
         return  ;
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
         pr_default.close(13);
         pr_default.close(14);
      }

      public override void initialize( )
      {
         sPrefix = "";
         Z487BR_Comorbidity_Hypertension_Code = "";
         Z488BR_Comorbidity_Diabetes_Code = "";
         Z489BR_Comorbidity_CHD_Code = "";
         Z490BR_Comorbidity_Hapetitis_Code = "";
         Z491BR_Comorbidity_TB_Code = "";
         Z492BR_Comorbidity_KidneyDisease_Code = "";
         Z493BR_Comorbidity_SurgeryHistory_Code = "";
         Z494BR_Comorbidity_InjuryHistory_Code = "";
         Z495BR_Comorbidity_BloodHistory_Code = "";
         Z496BR_Comorbidity_allergy_Code = "";
         Z38BR_Comorbidity_Hypertension = "";
         Z39BR_Comorbidity_Diabetes = "";
         Z40BR_Comorbidity_CHD = "";
         Z41BR_Comorbidity_Hapetitis = "";
         Z42BR_Comorbidity_TB = "";
         Z43BR_Comorbidity_KidneyDisease = "";
         Z44BR_Comorbidity_SurgeryHistory = "";
         Z45BR_Comorbidity_InjuryHistory = "";
         Z46BR_Comorbidity_BloodHistory = "";
         Z47BR_Comorbidity_allergy = "";
         Z259BR_Comorbidity_Others = "";
         Z561BR_Comorbidity_HapetitisB = "";
         Z562BR_Comorbidity_HapetitisB_Code = "";
         Z563BR_Comorbidity_HapetitisC = "";
         Z564BR_Comorbidity_HapetitisC_Code = "";
         Z565BR_Comorbidity_LiverCirrhosis = "";
         Z566BR_Comorbidity_LiverCirrhosis_Code = "";
         Z567BR_Comorbidity_Druginducedliverinjury = "";
         Z568BR_Comorbidity_Druginducedliverinjury_Code = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         A38BR_Comorbidity_Hypertension = "";
         A39BR_Comorbidity_Diabetes = "";
         A40BR_Comorbidity_CHD = "";
         A41BR_Comorbidity_Hapetitis = "";
         A42BR_Comorbidity_TB = "";
         A43BR_Comorbidity_KidneyDisease = "";
         A44BR_Comorbidity_SurgeryHistory = "";
         A45BR_Comorbidity_InjuryHistory = "";
         A46BR_Comorbidity_BloodHistory = "";
         A47BR_Comorbidity_allergy = "";
         GXKey = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         GX_FocusControl = "";
         ClassString = "";
         StyleString = "";
         ucDvpanel_tableattributes = new GXUserControl();
         TempTags = "";
         bttBtntrn_enter_Jsonclick = "";
         bttBtntrn_cancel_Jsonclick = "";
         bttBtntrn_delete_Jsonclick = "";
         A487BR_Comorbidity_Hypertension_Code = "";
         A488BR_Comorbidity_Diabetes_Code = "";
         A489BR_Comorbidity_CHD_Code = "";
         A490BR_Comorbidity_Hapetitis_Code = "";
         A491BR_Comorbidity_TB_Code = "";
         A492BR_Comorbidity_KidneyDisease_Code = "";
         A493BR_Comorbidity_SurgeryHistory_Code = "";
         A494BR_Comorbidity_InjuryHistory_Code = "";
         A495BR_Comorbidity_BloodHistory_Code = "";
         A496BR_Comorbidity_allergy_Code = "";
         A259BR_Comorbidity_Others = "";
         A561BR_Comorbidity_HapetitisB = "";
         A562BR_Comorbidity_HapetitisB_Code = "";
         A563BR_Comorbidity_HapetitisC = "";
         A564BR_Comorbidity_HapetitisC_Code = "";
         A565BR_Comorbidity_LiverCirrhosis = "";
         A566BR_Comorbidity_LiverCirrhosis_Code = "";
         A567BR_Comorbidity_Druginducedliverinjury = "";
         A568BR_Comorbidity_Druginducedliverinjury_Code = "";
         Gx_mode = "";
         A36BR_Information_PatientNo = "";
         Dvpanel_tableattributes_Objectcall = "";
         Dvpanel_tableattributes_Class = "";
         Dvpanel_tableattributes_Height = "";
         forbiddenHiddens = "";
         hsh = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         Z36BR_Information_PatientNo = "";
         T00096_A85BR_Information_ID = new long[1] ;
         T00096_n85BR_Information_ID = new bool[] {false} ;
         T00096_A37BR_ComorbidityID = new long[1] ;
         T00096_A487BR_Comorbidity_Hypertension_Code = new String[] {""} ;
         T00096_n487BR_Comorbidity_Hypertension_Code = new bool[] {false} ;
         T00096_A488BR_Comorbidity_Diabetes_Code = new String[] {""} ;
         T00096_n488BR_Comorbidity_Diabetes_Code = new bool[] {false} ;
         T00096_A489BR_Comorbidity_CHD_Code = new String[] {""} ;
         T00096_n489BR_Comorbidity_CHD_Code = new bool[] {false} ;
         T00096_A490BR_Comorbidity_Hapetitis_Code = new String[] {""} ;
         T00096_n490BR_Comorbidity_Hapetitis_Code = new bool[] {false} ;
         T00096_A491BR_Comorbidity_TB_Code = new String[] {""} ;
         T00096_n491BR_Comorbidity_TB_Code = new bool[] {false} ;
         T00096_A492BR_Comorbidity_KidneyDisease_Code = new String[] {""} ;
         T00096_n492BR_Comorbidity_KidneyDisease_Code = new bool[] {false} ;
         T00096_A493BR_Comorbidity_SurgeryHistory_Code = new String[] {""} ;
         T00096_n493BR_Comorbidity_SurgeryHistory_Code = new bool[] {false} ;
         T00096_A494BR_Comorbidity_InjuryHistory_Code = new String[] {""} ;
         T00096_n494BR_Comorbidity_InjuryHistory_Code = new bool[] {false} ;
         T00096_A495BR_Comorbidity_BloodHistory_Code = new String[] {""} ;
         T00096_n495BR_Comorbidity_BloodHistory_Code = new bool[] {false} ;
         T00096_A496BR_Comorbidity_allergy_Code = new String[] {""} ;
         T00096_n496BR_Comorbidity_allergy_Code = new bool[] {false} ;
         T00096_A36BR_Information_PatientNo = new String[] {""} ;
         T00096_n36BR_Information_PatientNo = new bool[] {false} ;
         T00096_A38BR_Comorbidity_Hypertension = new String[] {""} ;
         T00096_n38BR_Comorbidity_Hypertension = new bool[] {false} ;
         T00096_A39BR_Comorbidity_Diabetes = new String[] {""} ;
         T00096_n39BR_Comorbidity_Diabetes = new bool[] {false} ;
         T00096_A40BR_Comorbidity_CHD = new String[] {""} ;
         T00096_n40BR_Comorbidity_CHD = new bool[] {false} ;
         T00096_A41BR_Comorbidity_Hapetitis = new String[] {""} ;
         T00096_n41BR_Comorbidity_Hapetitis = new bool[] {false} ;
         T00096_A42BR_Comorbidity_TB = new String[] {""} ;
         T00096_n42BR_Comorbidity_TB = new bool[] {false} ;
         T00096_A43BR_Comorbidity_KidneyDisease = new String[] {""} ;
         T00096_n43BR_Comorbidity_KidneyDisease = new bool[] {false} ;
         T00096_A44BR_Comorbidity_SurgeryHistory = new String[] {""} ;
         T00096_n44BR_Comorbidity_SurgeryHistory = new bool[] {false} ;
         T00096_A45BR_Comorbidity_InjuryHistory = new String[] {""} ;
         T00096_n45BR_Comorbidity_InjuryHistory = new bool[] {false} ;
         T00096_A46BR_Comorbidity_BloodHistory = new String[] {""} ;
         T00096_n46BR_Comorbidity_BloodHistory = new bool[] {false} ;
         T00096_A47BR_Comorbidity_allergy = new String[] {""} ;
         T00096_n47BR_Comorbidity_allergy = new bool[] {false} ;
         T00096_A259BR_Comorbidity_Others = new String[] {""} ;
         T00096_n259BR_Comorbidity_Others = new bool[] {false} ;
         T00096_A561BR_Comorbidity_HapetitisB = new String[] {""} ;
         T00096_n561BR_Comorbidity_HapetitisB = new bool[] {false} ;
         T00096_A562BR_Comorbidity_HapetitisB_Code = new String[] {""} ;
         T00096_n562BR_Comorbidity_HapetitisB_Code = new bool[] {false} ;
         T00096_A563BR_Comorbidity_HapetitisC = new String[] {""} ;
         T00096_n563BR_Comorbidity_HapetitisC = new bool[] {false} ;
         T00096_A564BR_Comorbidity_HapetitisC_Code = new String[] {""} ;
         T00096_n564BR_Comorbidity_HapetitisC_Code = new bool[] {false} ;
         T00096_A565BR_Comorbidity_LiverCirrhosis = new String[] {""} ;
         T00096_n565BR_Comorbidity_LiverCirrhosis = new bool[] {false} ;
         T00096_A566BR_Comorbidity_LiverCirrhosis_Code = new String[] {""} ;
         T00096_n566BR_Comorbidity_LiverCirrhosis_Code = new bool[] {false} ;
         T00096_A567BR_Comorbidity_Druginducedliverinjury = new String[] {""} ;
         T00096_n567BR_Comorbidity_Druginducedliverinjury = new bool[] {false} ;
         T00096_A568BR_Comorbidity_Druginducedliverinjury_Code = new String[] {""} ;
         T00096_n568BR_Comorbidity_Druginducedliverinjury_Code = new bool[] {false} ;
         T00096_A19BR_EncounterID = new long[1] ;
         T00094_A85BR_Information_ID = new long[1] ;
         T00094_n85BR_Information_ID = new bool[] {false} ;
         T00095_A36BR_Information_PatientNo = new String[] {""} ;
         T00095_n36BR_Information_PatientNo = new bool[] {false} ;
         T00097_A85BR_Information_ID = new long[1] ;
         T00097_n85BR_Information_ID = new bool[] {false} ;
         T00098_A36BR_Information_PatientNo = new String[] {""} ;
         T00098_n36BR_Information_PatientNo = new bool[] {false} ;
         T00099_A37BR_ComorbidityID = new long[1] ;
         T00093_A37BR_ComorbidityID = new long[1] ;
         T00093_A487BR_Comorbidity_Hypertension_Code = new String[] {""} ;
         T00093_n487BR_Comorbidity_Hypertension_Code = new bool[] {false} ;
         T00093_A488BR_Comorbidity_Diabetes_Code = new String[] {""} ;
         T00093_n488BR_Comorbidity_Diabetes_Code = new bool[] {false} ;
         T00093_A489BR_Comorbidity_CHD_Code = new String[] {""} ;
         T00093_n489BR_Comorbidity_CHD_Code = new bool[] {false} ;
         T00093_A490BR_Comorbidity_Hapetitis_Code = new String[] {""} ;
         T00093_n490BR_Comorbidity_Hapetitis_Code = new bool[] {false} ;
         T00093_A491BR_Comorbidity_TB_Code = new String[] {""} ;
         T00093_n491BR_Comorbidity_TB_Code = new bool[] {false} ;
         T00093_A492BR_Comorbidity_KidneyDisease_Code = new String[] {""} ;
         T00093_n492BR_Comorbidity_KidneyDisease_Code = new bool[] {false} ;
         T00093_A493BR_Comorbidity_SurgeryHistory_Code = new String[] {""} ;
         T00093_n493BR_Comorbidity_SurgeryHistory_Code = new bool[] {false} ;
         T00093_A494BR_Comorbidity_InjuryHistory_Code = new String[] {""} ;
         T00093_n494BR_Comorbidity_InjuryHistory_Code = new bool[] {false} ;
         T00093_A495BR_Comorbidity_BloodHistory_Code = new String[] {""} ;
         T00093_n495BR_Comorbidity_BloodHistory_Code = new bool[] {false} ;
         T00093_A496BR_Comorbidity_allergy_Code = new String[] {""} ;
         T00093_n496BR_Comorbidity_allergy_Code = new bool[] {false} ;
         T00093_A38BR_Comorbidity_Hypertension = new String[] {""} ;
         T00093_n38BR_Comorbidity_Hypertension = new bool[] {false} ;
         T00093_A39BR_Comorbidity_Diabetes = new String[] {""} ;
         T00093_n39BR_Comorbidity_Diabetes = new bool[] {false} ;
         T00093_A40BR_Comorbidity_CHD = new String[] {""} ;
         T00093_n40BR_Comorbidity_CHD = new bool[] {false} ;
         T00093_A41BR_Comorbidity_Hapetitis = new String[] {""} ;
         T00093_n41BR_Comorbidity_Hapetitis = new bool[] {false} ;
         T00093_A42BR_Comorbidity_TB = new String[] {""} ;
         T00093_n42BR_Comorbidity_TB = new bool[] {false} ;
         T00093_A43BR_Comorbidity_KidneyDisease = new String[] {""} ;
         T00093_n43BR_Comorbidity_KidneyDisease = new bool[] {false} ;
         T00093_A44BR_Comorbidity_SurgeryHistory = new String[] {""} ;
         T00093_n44BR_Comorbidity_SurgeryHistory = new bool[] {false} ;
         T00093_A45BR_Comorbidity_InjuryHistory = new String[] {""} ;
         T00093_n45BR_Comorbidity_InjuryHistory = new bool[] {false} ;
         T00093_A46BR_Comorbidity_BloodHistory = new String[] {""} ;
         T00093_n46BR_Comorbidity_BloodHistory = new bool[] {false} ;
         T00093_A47BR_Comorbidity_allergy = new String[] {""} ;
         T00093_n47BR_Comorbidity_allergy = new bool[] {false} ;
         T00093_A259BR_Comorbidity_Others = new String[] {""} ;
         T00093_n259BR_Comorbidity_Others = new bool[] {false} ;
         T00093_A561BR_Comorbidity_HapetitisB = new String[] {""} ;
         T00093_n561BR_Comorbidity_HapetitisB = new bool[] {false} ;
         T00093_A562BR_Comorbidity_HapetitisB_Code = new String[] {""} ;
         T00093_n562BR_Comorbidity_HapetitisB_Code = new bool[] {false} ;
         T00093_A563BR_Comorbidity_HapetitisC = new String[] {""} ;
         T00093_n563BR_Comorbidity_HapetitisC = new bool[] {false} ;
         T00093_A564BR_Comorbidity_HapetitisC_Code = new String[] {""} ;
         T00093_n564BR_Comorbidity_HapetitisC_Code = new bool[] {false} ;
         T00093_A565BR_Comorbidity_LiverCirrhosis = new String[] {""} ;
         T00093_n565BR_Comorbidity_LiverCirrhosis = new bool[] {false} ;
         T00093_A566BR_Comorbidity_LiverCirrhosis_Code = new String[] {""} ;
         T00093_n566BR_Comorbidity_LiverCirrhosis_Code = new bool[] {false} ;
         T00093_A567BR_Comorbidity_Druginducedliverinjury = new String[] {""} ;
         T00093_n567BR_Comorbidity_Druginducedliverinjury = new bool[] {false} ;
         T00093_A568BR_Comorbidity_Druginducedliverinjury_Code = new String[] {""} ;
         T00093_n568BR_Comorbidity_Druginducedliverinjury_Code = new bool[] {false} ;
         T00093_A19BR_EncounterID = new long[1] ;
         sMode10 = "";
         T000910_A37BR_ComorbidityID = new long[1] ;
         T000911_A37BR_ComorbidityID = new long[1] ;
         T00092_A37BR_ComorbidityID = new long[1] ;
         T00092_A487BR_Comorbidity_Hypertension_Code = new String[] {""} ;
         T00092_n487BR_Comorbidity_Hypertension_Code = new bool[] {false} ;
         T00092_A488BR_Comorbidity_Diabetes_Code = new String[] {""} ;
         T00092_n488BR_Comorbidity_Diabetes_Code = new bool[] {false} ;
         T00092_A489BR_Comorbidity_CHD_Code = new String[] {""} ;
         T00092_n489BR_Comorbidity_CHD_Code = new bool[] {false} ;
         T00092_A490BR_Comorbidity_Hapetitis_Code = new String[] {""} ;
         T00092_n490BR_Comorbidity_Hapetitis_Code = new bool[] {false} ;
         T00092_A491BR_Comorbidity_TB_Code = new String[] {""} ;
         T00092_n491BR_Comorbidity_TB_Code = new bool[] {false} ;
         T00092_A492BR_Comorbidity_KidneyDisease_Code = new String[] {""} ;
         T00092_n492BR_Comorbidity_KidneyDisease_Code = new bool[] {false} ;
         T00092_A493BR_Comorbidity_SurgeryHistory_Code = new String[] {""} ;
         T00092_n493BR_Comorbidity_SurgeryHistory_Code = new bool[] {false} ;
         T00092_A494BR_Comorbidity_InjuryHistory_Code = new String[] {""} ;
         T00092_n494BR_Comorbidity_InjuryHistory_Code = new bool[] {false} ;
         T00092_A495BR_Comorbidity_BloodHistory_Code = new String[] {""} ;
         T00092_n495BR_Comorbidity_BloodHistory_Code = new bool[] {false} ;
         T00092_A496BR_Comorbidity_allergy_Code = new String[] {""} ;
         T00092_n496BR_Comorbidity_allergy_Code = new bool[] {false} ;
         T00092_A38BR_Comorbidity_Hypertension = new String[] {""} ;
         T00092_n38BR_Comorbidity_Hypertension = new bool[] {false} ;
         T00092_A39BR_Comorbidity_Diabetes = new String[] {""} ;
         T00092_n39BR_Comorbidity_Diabetes = new bool[] {false} ;
         T00092_A40BR_Comorbidity_CHD = new String[] {""} ;
         T00092_n40BR_Comorbidity_CHD = new bool[] {false} ;
         T00092_A41BR_Comorbidity_Hapetitis = new String[] {""} ;
         T00092_n41BR_Comorbidity_Hapetitis = new bool[] {false} ;
         T00092_A42BR_Comorbidity_TB = new String[] {""} ;
         T00092_n42BR_Comorbidity_TB = new bool[] {false} ;
         T00092_A43BR_Comorbidity_KidneyDisease = new String[] {""} ;
         T00092_n43BR_Comorbidity_KidneyDisease = new bool[] {false} ;
         T00092_A44BR_Comorbidity_SurgeryHistory = new String[] {""} ;
         T00092_n44BR_Comorbidity_SurgeryHistory = new bool[] {false} ;
         T00092_A45BR_Comorbidity_InjuryHistory = new String[] {""} ;
         T00092_n45BR_Comorbidity_InjuryHistory = new bool[] {false} ;
         T00092_A46BR_Comorbidity_BloodHistory = new String[] {""} ;
         T00092_n46BR_Comorbidity_BloodHistory = new bool[] {false} ;
         T00092_A47BR_Comorbidity_allergy = new String[] {""} ;
         T00092_n47BR_Comorbidity_allergy = new bool[] {false} ;
         T00092_A259BR_Comorbidity_Others = new String[] {""} ;
         T00092_n259BR_Comorbidity_Others = new bool[] {false} ;
         T00092_A561BR_Comorbidity_HapetitisB = new String[] {""} ;
         T00092_n561BR_Comorbidity_HapetitisB = new bool[] {false} ;
         T00092_A562BR_Comorbidity_HapetitisB_Code = new String[] {""} ;
         T00092_n562BR_Comorbidity_HapetitisB_Code = new bool[] {false} ;
         T00092_A563BR_Comorbidity_HapetitisC = new String[] {""} ;
         T00092_n563BR_Comorbidity_HapetitisC = new bool[] {false} ;
         T00092_A564BR_Comorbidity_HapetitisC_Code = new String[] {""} ;
         T00092_n564BR_Comorbidity_HapetitisC_Code = new bool[] {false} ;
         T00092_A565BR_Comorbidity_LiverCirrhosis = new String[] {""} ;
         T00092_n565BR_Comorbidity_LiverCirrhosis = new bool[] {false} ;
         T00092_A566BR_Comorbidity_LiverCirrhosis_Code = new String[] {""} ;
         T00092_n566BR_Comorbidity_LiverCirrhosis_Code = new bool[] {false} ;
         T00092_A567BR_Comorbidity_Druginducedliverinjury = new String[] {""} ;
         T00092_n567BR_Comorbidity_Druginducedliverinjury = new bool[] {false} ;
         T00092_A568BR_Comorbidity_Druginducedliverinjury_Code = new String[] {""} ;
         T00092_n568BR_Comorbidity_Druginducedliverinjury_Code = new bool[] {false} ;
         T00092_A19BR_EncounterID = new long[1] ;
         T000912_A37BR_ComorbidityID = new long[1] ;
         T000915_A85BR_Information_ID = new long[1] ;
         T000915_n85BR_Information_ID = new bool[] {false} ;
         T000916_A36BR_Information_PatientNo = new String[] {""} ;
         T000916_n36BR_Information_PatientNo = new bool[] {false} ;
         T000917_A37BR_ComorbidityID = new long[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXt_char1 = "";
         isValidOutput = new GxUnknownObjectCollection();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_comorbidity__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_comorbidity__default(),
            new Object[][] {
                new Object[] {
               T00092_A37BR_ComorbidityID, T00092_A487BR_Comorbidity_Hypertension_Code, T00092_n487BR_Comorbidity_Hypertension_Code, T00092_A488BR_Comorbidity_Diabetes_Code, T00092_n488BR_Comorbidity_Diabetes_Code, T00092_A489BR_Comorbidity_CHD_Code, T00092_n489BR_Comorbidity_CHD_Code, T00092_A490BR_Comorbidity_Hapetitis_Code, T00092_n490BR_Comorbidity_Hapetitis_Code, T00092_A491BR_Comorbidity_TB_Code,
               T00092_n491BR_Comorbidity_TB_Code, T00092_A492BR_Comorbidity_KidneyDisease_Code, T00092_n492BR_Comorbidity_KidneyDisease_Code, T00092_A493BR_Comorbidity_SurgeryHistory_Code, T00092_n493BR_Comorbidity_SurgeryHistory_Code, T00092_A494BR_Comorbidity_InjuryHistory_Code, T00092_n494BR_Comorbidity_InjuryHistory_Code, T00092_A495BR_Comorbidity_BloodHistory_Code, T00092_n495BR_Comorbidity_BloodHistory_Code, T00092_A496BR_Comorbidity_allergy_Code,
               T00092_n496BR_Comorbidity_allergy_Code, T00092_A38BR_Comorbidity_Hypertension, T00092_n38BR_Comorbidity_Hypertension, T00092_A39BR_Comorbidity_Diabetes, T00092_n39BR_Comorbidity_Diabetes, T00092_A40BR_Comorbidity_CHD, T00092_n40BR_Comorbidity_CHD, T00092_A41BR_Comorbidity_Hapetitis, T00092_n41BR_Comorbidity_Hapetitis, T00092_A42BR_Comorbidity_TB,
               T00092_n42BR_Comorbidity_TB, T00092_A43BR_Comorbidity_KidneyDisease, T00092_n43BR_Comorbidity_KidneyDisease, T00092_A44BR_Comorbidity_SurgeryHistory, T00092_n44BR_Comorbidity_SurgeryHistory, T00092_A45BR_Comorbidity_InjuryHistory, T00092_n45BR_Comorbidity_InjuryHistory, T00092_A46BR_Comorbidity_BloodHistory, T00092_n46BR_Comorbidity_BloodHistory, T00092_A47BR_Comorbidity_allergy,
               T00092_n47BR_Comorbidity_allergy, T00092_A259BR_Comorbidity_Others, T00092_n259BR_Comorbidity_Others, T00092_A561BR_Comorbidity_HapetitisB, T00092_n561BR_Comorbidity_HapetitisB, T00092_A562BR_Comorbidity_HapetitisB_Code, T00092_n562BR_Comorbidity_HapetitisB_Code, T00092_A563BR_Comorbidity_HapetitisC, T00092_n563BR_Comorbidity_HapetitisC, T00092_A564BR_Comorbidity_HapetitisC_Code,
               T00092_n564BR_Comorbidity_HapetitisC_Code, T00092_A565BR_Comorbidity_LiverCirrhosis, T00092_n565BR_Comorbidity_LiverCirrhosis, T00092_A566BR_Comorbidity_LiverCirrhosis_Code, T00092_n566BR_Comorbidity_LiverCirrhosis_Code, T00092_A567BR_Comorbidity_Druginducedliverinjury, T00092_n567BR_Comorbidity_Druginducedliverinjury, T00092_A568BR_Comorbidity_Druginducedliverinjury_Code, T00092_n568BR_Comorbidity_Druginducedliverinjury_Code, T00092_A19BR_EncounterID
               }
               , new Object[] {
               T00093_A37BR_ComorbidityID, T00093_A487BR_Comorbidity_Hypertension_Code, T00093_n487BR_Comorbidity_Hypertension_Code, T00093_A488BR_Comorbidity_Diabetes_Code, T00093_n488BR_Comorbidity_Diabetes_Code, T00093_A489BR_Comorbidity_CHD_Code, T00093_n489BR_Comorbidity_CHD_Code, T00093_A490BR_Comorbidity_Hapetitis_Code, T00093_n490BR_Comorbidity_Hapetitis_Code, T00093_A491BR_Comorbidity_TB_Code,
               T00093_n491BR_Comorbidity_TB_Code, T00093_A492BR_Comorbidity_KidneyDisease_Code, T00093_n492BR_Comorbidity_KidneyDisease_Code, T00093_A493BR_Comorbidity_SurgeryHistory_Code, T00093_n493BR_Comorbidity_SurgeryHistory_Code, T00093_A494BR_Comorbidity_InjuryHistory_Code, T00093_n494BR_Comorbidity_InjuryHistory_Code, T00093_A495BR_Comorbidity_BloodHistory_Code, T00093_n495BR_Comorbidity_BloodHistory_Code, T00093_A496BR_Comorbidity_allergy_Code,
               T00093_n496BR_Comorbidity_allergy_Code, T00093_A38BR_Comorbidity_Hypertension, T00093_n38BR_Comorbidity_Hypertension, T00093_A39BR_Comorbidity_Diabetes, T00093_n39BR_Comorbidity_Diabetes, T00093_A40BR_Comorbidity_CHD, T00093_n40BR_Comorbidity_CHD, T00093_A41BR_Comorbidity_Hapetitis, T00093_n41BR_Comorbidity_Hapetitis, T00093_A42BR_Comorbidity_TB,
               T00093_n42BR_Comorbidity_TB, T00093_A43BR_Comorbidity_KidneyDisease, T00093_n43BR_Comorbidity_KidneyDisease, T00093_A44BR_Comorbidity_SurgeryHistory, T00093_n44BR_Comorbidity_SurgeryHistory, T00093_A45BR_Comorbidity_InjuryHistory, T00093_n45BR_Comorbidity_InjuryHistory, T00093_A46BR_Comorbidity_BloodHistory, T00093_n46BR_Comorbidity_BloodHistory, T00093_A47BR_Comorbidity_allergy,
               T00093_n47BR_Comorbidity_allergy, T00093_A259BR_Comorbidity_Others, T00093_n259BR_Comorbidity_Others, T00093_A561BR_Comorbidity_HapetitisB, T00093_n561BR_Comorbidity_HapetitisB, T00093_A562BR_Comorbidity_HapetitisB_Code, T00093_n562BR_Comorbidity_HapetitisB_Code, T00093_A563BR_Comorbidity_HapetitisC, T00093_n563BR_Comorbidity_HapetitisC, T00093_A564BR_Comorbidity_HapetitisC_Code,
               T00093_n564BR_Comorbidity_HapetitisC_Code, T00093_A565BR_Comorbidity_LiverCirrhosis, T00093_n565BR_Comorbidity_LiverCirrhosis, T00093_A566BR_Comorbidity_LiverCirrhosis_Code, T00093_n566BR_Comorbidity_LiverCirrhosis_Code, T00093_A567BR_Comorbidity_Druginducedliverinjury, T00093_n567BR_Comorbidity_Druginducedliverinjury, T00093_A568BR_Comorbidity_Druginducedliverinjury_Code, T00093_n568BR_Comorbidity_Druginducedliverinjury_Code, T00093_A19BR_EncounterID
               }
               , new Object[] {
               T00094_A85BR_Information_ID, T00094_n85BR_Information_ID
               }
               , new Object[] {
               T00095_A36BR_Information_PatientNo, T00095_n36BR_Information_PatientNo
               }
               , new Object[] {
               T00096_A85BR_Information_ID, T00096_n85BR_Information_ID, T00096_A37BR_ComorbidityID, T00096_A487BR_Comorbidity_Hypertension_Code, T00096_n487BR_Comorbidity_Hypertension_Code, T00096_A488BR_Comorbidity_Diabetes_Code, T00096_n488BR_Comorbidity_Diabetes_Code, T00096_A489BR_Comorbidity_CHD_Code, T00096_n489BR_Comorbidity_CHD_Code, T00096_A490BR_Comorbidity_Hapetitis_Code,
               T00096_n490BR_Comorbidity_Hapetitis_Code, T00096_A491BR_Comorbidity_TB_Code, T00096_n491BR_Comorbidity_TB_Code, T00096_A492BR_Comorbidity_KidneyDisease_Code, T00096_n492BR_Comorbidity_KidneyDisease_Code, T00096_A493BR_Comorbidity_SurgeryHistory_Code, T00096_n493BR_Comorbidity_SurgeryHistory_Code, T00096_A494BR_Comorbidity_InjuryHistory_Code, T00096_n494BR_Comorbidity_InjuryHistory_Code, T00096_A495BR_Comorbidity_BloodHistory_Code,
               T00096_n495BR_Comorbidity_BloodHistory_Code, T00096_A496BR_Comorbidity_allergy_Code, T00096_n496BR_Comorbidity_allergy_Code, T00096_A36BR_Information_PatientNo, T00096_n36BR_Information_PatientNo, T00096_A38BR_Comorbidity_Hypertension, T00096_n38BR_Comorbidity_Hypertension, T00096_A39BR_Comorbidity_Diabetes, T00096_n39BR_Comorbidity_Diabetes, T00096_A40BR_Comorbidity_CHD,
               T00096_n40BR_Comorbidity_CHD, T00096_A41BR_Comorbidity_Hapetitis, T00096_n41BR_Comorbidity_Hapetitis, T00096_A42BR_Comorbidity_TB, T00096_n42BR_Comorbidity_TB, T00096_A43BR_Comorbidity_KidneyDisease, T00096_n43BR_Comorbidity_KidneyDisease, T00096_A44BR_Comorbidity_SurgeryHistory, T00096_n44BR_Comorbidity_SurgeryHistory, T00096_A45BR_Comorbidity_InjuryHistory,
               T00096_n45BR_Comorbidity_InjuryHistory, T00096_A46BR_Comorbidity_BloodHistory, T00096_n46BR_Comorbidity_BloodHistory, T00096_A47BR_Comorbidity_allergy, T00096_n47BR_Comorbidity_allergy, T00096_A259BR_Comorbidity_Others, T00096_n259BR_Comorbidity_Others, T00096_A561BR_Comorbidity_HapetitisB, T00096_n561BR_Comorbidity_HapetitisB, T00096_A562BR_Comorbidity_HapetitisB_Code,
               T00096_n562BR_Comorbidity_HapetitisB_Code, T00096_A563BR_Comorbidity_HapetitisC, T00096_n563BR_Comorbidity_HapetitisC, T00096_A564BR_Comorbidity_HapetitisC_Code, T00096_n564BR_Comorbidity_HapetitisC_Code, T00096_A565BR_Comorbidity_LiverCirrhosis, T00096_n565BR_Comorbidity_LiverCirrhosis, T00096_A566BR_Comorbidity_LiverCirrhosis_Code, T00096_n566BR_Comorbidity_LiverCirrhosis_Code, T00096_A567BR_Comorbidity_Druginducedliverinjury,
               T00096_n567BR_Comorbidity_Druginducedliverinjury, T00096_A568BR_Comorbidity_Druginducedliverinjury_Code, T00096_n568BR_Comorbidity_Druginducedliverinjury_Code, T00096_A19BR_EncounterID
               }
               , new Object[] {
               T00097_A85BR_Information_ID, T00097_n85BR_Information_ID
               }
               , new Object[] {
               T00098_A36BR_Information_PatientNo, T00098_n36BR_Information_PatientNo
               }
               , new Object[] {
               T00099_A37BR_ComorbidityID
               }
               , new Object[] {
               T000910_A37BR_ComorbidityID
               }
               , new Object[] {
               T000911_A37BR_ComorbidityID
               }
               , new Object[] {
               T000912_A37BR_ComorbidityID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000915_A85BR_Information_ID, T000915_n85BR_Information_ID
               }
               , new Object[] {
               T000916_A36BR_Information_PatientNo, T000916_n36BR_Information_PatientNo
               }
               , new Object[] {
               T000917_A37BR_ComorbidityID
               }
            }
         );
      }

      private short GxWebError ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short GX_JID ;
      private short RcdFound10 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int edtBR_EncounterID_Enabled ;
      private int bttBtntrn_enter_Visible ;
      private int bttBtntrn_enter_Enabled ;
      private int bttBtntrn_cancel_Visible ;
      private int bttBtntrn_delete_Visible ;
      private int bttBtntrn_delete_Enabled ;
      private int edtBR_ComorbidityID_Enabled ;
      private int idxLst ;
      private long Z37BR_ComorbidityID ;
      private long Z19BR_EncounterID ;
      private long A19BR_EncounterID ;
      private long A85BR_Information_ID ;
      private long A37BR_ComorbidityID ;
      private long Z85BR_Information_ID ;
      private String sPrefix ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtBR_EncounterID_Internalname ;
      private String cmbBR_Comorbidity_Hypertension_Internalname ;
      private String cmbBR_Comorbidity_Diabetes_Internalname ;
      private String cmbBR_Comorbidity_CHD_Internalname ;
      private String cmbBR_Comorbidity_Hapetitis_Internalname ;
      private String cmbBR_Comorbidity_TB_Internalname ;
      private String cmbBR_Comorbidity_KidneyDisease_Internalname ;
      private String cmbBR_Comorbidity_SurgeryHistory_Internalname ;
      private String cmbBR_Comorbidity_InjuryHistory_Internalname ;
      private String cmbBR_Comorbidity_BloodHistory_Internalname ;
      private String cmbBR_Comorbidity_allergy_Internalname ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String divTablecontent_Internalname ;
      private String divHtml_dvpanel_tableattributes_Internalname ;
      private String Dvpanel_tableattributes_Width ;
      private String Dvpanel_tableattributes_Cls ;
      private String Dvpanel_tableattributes_Title ;
      private String Dvpanel_tableattributes_Iconposition ;
      private String Dvpanel_tableattributes_Internalname ;
      private String divLayout_tableattributes_Internalname ;
      private String divTableattributes_Internalname ;
      private String TempTags ;
      private String edtBR_EncounterID_Jsonclick ;
      private String cmbBR_Comorbidity_Hypertension_Jsonclick ;
      private String cmbBR_Comorbidity_Diabetes_Jsonclick ;
      private String cmbBR_Comorbidity_CHD_Jsonclick ;
      private String cmbBR_Comorbidity_Hapetitis_Jsonclick ;
      private String cmbBR_Comorbidity_TB_Jsonclick ;
      private String cmbBR_Comorbidity_KidneyDisease_Jsonclick ;
      private String cmbBR_Comorbidity_SurgeryHistory_Jsonclick ;
      private String cmbBR_Comorbidity_InjuryHistory_Jsonclick ;
      private String cmbBR_Comorbidity_BloodHistory_Jsonclick ;
      private String cmbBR_Comorbidity_allergy_Jsonclick ;
      private String bttBtntrn_enter_Internalname ;
      private String bttBtntrn_enter_Jsonclick ;
      private String bttBtntrn_cancel_Internalname ;
      private String bttBtntrn_cancel_Jsonclick ;
      private String bttBtntrn_delete_Internalname ;
      private String bttBtntrn_delete_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtBR_ComorbidityID_Internalname ;
      private String edtBR_ComorbidityID_Jsonclick ;
      private String Gx_mode ;
      private String Dvpanel_tableattributes_Objectcall ;
      private String Dvpanel_tableattributes_Class ;
      private String Dvpanel_tableattributes_Height ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sMode10 ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXt_char1 ;
      private bool entryPointCalled ;
      private bool n38BR_Comorbidity_Hypertension ;
      private bool n39BR_Comorbidity_Diabetes ;
      private bool n40BR_Comorbidity_CHD ;
      private bool n41BR_Comorbidity_Hapetitis ;
      private bool n42BR_Comorbidity_TB ;
      private bool n43BR_Comorbidity_KidneyDisease ;
      private bool n44BR_Comorbidity_SurgeryHistory ;
      private bool n45BR_Comorbidity_InjuryHistory ;
      private bool n46BR_Comorbidity_BloodHistory ;
      private bool n47BR_Comorbidity_allergy ;
      private bool n85BR_Information_ID ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool Dvpanel_tableattributes_Autowidth ;
      private bool Dvpanel_tableattributes_Autoheight ;
      private bool Dvpanel_tableattributes_Collapsible ;
      private bool Dvpanel_tableattributes_Collapsed ;
      private bool Dvpanel_tableattributes_Showcollapseicon ;
      private bool Dvpanel_tableattributes_Autoscroll ;
      private bool n487BR_Comorbidity_Hypertension_Code ;
      private bool n488BR_Comorbidity_Diabetes_Code ;
      private bool n489BR_Comorbidity_CHD_Code ;
      private bool n490BR_Comorbidity_Hapetitis_Code ;
      private bool n491BR_Comorbidity_TB_Code ;
      private bool n492BR_Comorbidity_KidneyDisease_Code ;
      private bool n493BR_Comorbidity_SurgeryHistory_Code ;
      private bool n494BR_Comorbidity_InjuryHistory_Code ;
      private bool n495BR_Comorbidity_BloodHistory_Code ;
      private bool n496BR_Comorbidity_allergy_Code ;
      private bool n259BR_Comorbidity_Others ;
      private bool n561BR_Comorbidity_HapetitisB ;
      private bool n562BR_Comorbidity_HapetitisB_Code ;
      private bool n563BR_Comorbidity_HapetitisC ;
      private bool n564BR_Comorbidity_HapetitisC_Code ;
      private bool n565BR_Comorbidity_LiverCirrhosis ;
      private bool n566BR_Comorbidity_LiverCirrhosis_Code ;
      private bool n567BR_Comorbidity_Druginducedliverinjury ;
      private bool n568BR_Comorbidity_Druginducedliverinjury_Code ;
      private bool n36BR_Information_PatientNo ;
      private bool Dvpanel_tableattributes_Enabled ;
      private bool Dvpanel_tableattributes_Showheader ;
      private bool Dvpanel_tableattributes_Visible ;
      private bool Gx_longc ;
      private String Z487BR_Comorbidity_Hypertension_Code ;
      private String Z488BR_Comorbidity_Diabetes_Code ;
      private String Z489BR_Comorbidity_CHD_Code ;
      private String Z490BR_Comorbidity_Hapetitis_Code ;
      private String Z491BR_Comorbidity_TB_Code ;
      private String Z492BR_Comorbidity_KidneyDisease_Code ;
      private String Z493BR_Comorbidity_SurgeryHistory_Code ;
      private String Z494BR_Comorbidity_InjuryHistory_Code ;
      private String Z495BR_Comorbidity_BloodHistory_Code ;
      private String Z496BR_Comorbidity_allergy_Code ;
      private String Z38BR_Comorbidity_Hypertension ;
      private String Z39BR_Comorbidity_Diabetes ;
      private String Z40BR_Comorbidity_CHD ;
      private String Z41BR_Comorbidity_Hapetitis ;
      private String Z42BR_Comorbidity_TB ;
      private String Z43BR_Comorbidity_KidneyDisease ;
      private String Z44BR_Comorbidity_SurgeryHistory ;
      private String Z45BR_Comorbidity_InjuryHistory ;
      private String Z46BR_Comorbidity_BloodHistory ;
      private String Z47BR_Comorbidity_allergy ;
      private String Z259BR_Comorbidity_Others ;
      private String Z561BR_Comorbidity_HapetitisB ;
      private String Z562BR_Comorbidity_HapetitisB_Code ;
      private String Z563BR_Comorbidity_HapetitisC ;
      private String Z564BR_Comorbidity_HapetitisC_Code ;
      private String Z565BR_Comorbidity_LiverCirrhosis ;
      private String Z566BR_Comorbidity_LiverCirrhosis_Code ;
      private String Z567BR_Comorbidity_Druginducedliverinjury ;
      private String Z568BR_Comorbidity_Druginducedliverinjury_Code ;
      private String A38BR_Comorbidity_Hypertension ;
      private String A39BR_Comorbidity_Diabetes ;
      private String A40BR_Comorbidity_CHD ;
      private String A41BR_Comorbidity_Hapetitis ;
      private String A42BR_Comorbidity_TB ;
      private String A43BR_Comorbidity_KidneyDisease ;
      private String A44BR_Comorbidity_SurgeryHistory ;
      private String A45BR_Comorbidity_InjuryHistory ;
      private String A46BR_Comorbidity_BloodHistory ;
      private String A47BR_Comorbidity_allergy ;
      private String A487BR_Comorbidity_Hypertension_Code ;
      private String A488BR_Comorbidity_Diabetes_Code ;
      private String A489BR_Comorbidity_CHD_Code ;
      private String A490BR_Comorbidity_Hapetitis_Code ;
      private String A491BR_Comorbidity_TB_Code ;
      private String A492BR_Comorbidity_KidneyDisease_Code ;
      private String A493BR_Comorbidity_SurgeryHistory_Code ;
      private String A494BR_Comorbidity_InjuryHistory_Code ;
      private String A495BR_Comorbidity_BloodHistory_Code ;
      private String A496BR_Comorbidity_allergy_Code ;
      private String A259BR_Comorbidity_Others ;
      private String A561BR_Comorbidity_HapetitisB ;
      private String A562BR_Comorbidity_HapetitisB_Code ;
      private String A563BR_Comorbidity_HapetitisC ;
      private String A564BR_Comorbidity_HapetitisC_Code ;
      private String A565BR_Comorbidity_LiverCirrhosis ;
      private String A566BR_Comorbidity_LiverCirrhosis_Code ;
      private String A567BR_Comorbidity_Druginducedliverinjury ;
      private String A568BR_Comorbidity_Druginducedliverinjury_Code ;
      private String A36BR_Information_PatientNo ;
      private String Z36BR_Information_PatientNo ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXUserControl ucDvpanel_tableattributes ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbBR_Comorbidity_Hypertension ;
      private GXCombobox cmbBR_Comorbidity_Diabetes ;
      private GXCombobox cmbBR_Comorbidity_CHD ;
      private GXCombobox cmbBR_Comorbidity_Hapetitis ;
      private GXCombobox cmbBR_Comorbidity_TB ;
      private GXCombobox cmbBR_Comorbidity_KidneyDisease ;
      private GXCombobox cmbBR_Comorbidity_SurgeryHistory ;
      private GXCombobox cmbBR_Comorbidity_InjuryHistory ;
      private GXCombobox cmbBR_Comorbidity_BloodHistory ;
      private GXCombobox cmbBR_Comorbidity_allergy ;
      private IDataStoreProvider pr_default ;
      private long[] T00096_A85BR_Information_ID ;
      private bool[] T00096_n85BR_Information_ID ;
      private long[] T00096_A37BR_ComorbidityID ;
      private String[] T00096_A487BR_Comorbidity_Hypertension_Code ;
      private bool[] T00096_n487BR_Comorbidity_Hypertension_Code ;
      private String[] T00096_A488BR_Comorbidity_Diabetes_Code ;
      private bool[] T00096_n488BR_Comorbidity_Diabetes_Code ;
      private String[] T00096_A489BR_Comorbidity_CHD_Code ;
      private bool[] T00096_n489BR_Comorbidity_CHD_Code ;
      private String[] T00096_A490BR_Comorbidity_Hapetitis_Code ;
      private bool[] T00096_n490BR_Comorbidity_Hapetitis_Code ;
      private String[] T00096_A491BR_Comorbidity_TB_Code ;
      private bool[] T00096_n491BR_Comorbidity_TB_Code ;
      private String[] T00096_A492BR_Comorbidity_KidneyDisease_Code ;
      private bool[] T00096_n492BR_Comorbidity_KidneyDisease_Code ;
      private String[] T00096_A493BR_Comorbidity_SurgeryHistory_Code ;
      private bool[] T00096_n493BR_Comorbidity_SurgeryHistory_Code ;
      private String[] T00096_A494BR_Comorbidity_InjuryHistory_Code ;
      private bool[] T00096_n494BR_Comorbidity_InjuryHistory_Code ;
      private String[] T00096_A495BR_Comorbidity_BloodHistory_Code ;
      private bool[] T00096_n495BR_Comorbidity_BloodHistory_Code ;
      private String[] T00096_A496BR_Comorbidity_allergy_Code ;
      private bool[] T00096_n496BR_Comorbidity_allergy_Code ;
      private String[] T00096_A36BR_Information_PatientNo ;
      private bool[] T00096_n36BR_Information_PatientNo ;
      private String[] T00096_A38BR_Comorbidity_Hypertension ;
      private bool[] T00096_n38BR_Comorbidity_Hypertension ;
      private String[] T00096_A39BR_Comorbidity_Diabetes ;
      private bool[] T00096_n39BR_Comorbidity_Diabetes ;
      private String[] T00096_A40BR_Comorbidity_CHD ;
      private bool[] T00096_n40BR_Comorbidity_CHD ;
      private String[] T00096_A41BR_Comorbidity_Hapetitis ;
      private bool[] T00096_n41BR_Comorbidity_Hapetitis ;
      private String[] T00096_A42BR_Comorbidity_TB ;
      private bool[] T00096_n42BR_Comorbidity_TB ;
      private String[] T00096_A43BR_Comorbidity_KidneyDisease ;
      private bool[] T00096_n43BR_Comorbidity_KidneyDisease ;
      private String[] T00096_A44BR_Comorbidity_SurgeryHistory ;
      private bool[] T00096_n44BR_Comorbidity_SurgeryHistory ;
      private String[] T00096_A45BR_Comorbidity_InjuryHistory ;
      private bool[] T00096_n45BR_Comorbidity_InjuryHistory ;
      private String[] T00096_A46BR_Comorbidity_BloodHistory ;
      private bool[] T00096_n46BR_Comorbidity_BloodHistory ;
      private String[] T00096_A47BR_Comorbidity_allergy ;
      private bool[] T00096_n47BR_Comorbidity_allergy ;
      private String[] T00096_A259BR_Comorbidity_Others ;
      private bool[] T00096_n259BR_Comorbidity_Others ;
      private String[] T00096_A561BR_Comorbidity_HapetitisB ;
      private bool[] T00096_n561BR_Comorbidity_HapetitisB ;
      private String[] T00096_A562BR_Comorbidity_HapetitisB_Code ;
      private bool[] T00096_n562BR_Comorbidity_HapetitisB_Code ;
      private String[] T00096_A563BR_Comorbidity_HapetitisC ;
      private bool[] T00096_n563BR_Comorbidity_HapetitisC ;
      private String[] T00096_A564BR_Comorbidity_HapetitisC_Code ;
      private bool[] T00096_n564BR_Comorbidity_HapetitisC_Code ;
      private String[] T00096_A565BR_Comorbidity_LiverCirrhosis ;
      private bool[] T00096_n565BR_Comorbidity_LiverCirrhosis ;
      private String[] T00096_A566BR_Comorbidity_LiverCirrhosis_Code ;
      private bool[] T00096_n566BR_Comorbidity_LiverCirrhosis_Code ;
      private String[] T00096_A567BR_Comorbidity_Druginducedliverinjury ;
      private bool[] T00096_n567BR_Comorbidity_Druginducedliverinjury ;
      private String[] T00096_A568BR_Comorbidity_Druginducedliverinjury_Code ;
      private bool[] T00096_n568BR_Comorbidity_Druginducedliverinjury_Code ;
      private long[] T00096_A19BR_EncounterID ;
      private long[] T00094_A85BR_Information_ID ;
      private bool[] T00094_n85BR_Information_ID ;
      private String[] T00095_A36BR_Information_PatientNo ;
      private bool[] T00095_n36BR_Information_PatientNo ;
      private long[] T00097_A85BR_Information_ID ;
      private bool[] T00097_n85BR_Information_ID ;
      private String[] T00098_A36BR_Information_PatientNo ;
      private bool[] T00098_n36BR_Information_PatientNo ;
      private long[] T00099_A37BR_ComorbidityID ;
      private long[] T00093_A37BR_ComorbidityID ;
      private String[] T00093_A487BR_Comorbidity_Hypertension_Code ;
      private bool[] T00093_n487BR_Comorbidity_Hypertension_Code ;
      private String[] T00093_A488BR_Comorbidity_Diabetes_Code ;
      private bool[] T00093_n488BR_Comorbidity_Diabetes_Code ;
      private String[] T00093_A489BR_Comorbidity_CHD_Code ;
      private bool[] T00093_n489BR_Comorbidity_CHD_Code ;
      private String[] T00093_A490BR_Comorbidity_Hapetitis_Code ;
      private bool[] T00093_n490BR_Comorbidity_Hapetitis_Code ;
      private String[] T00093_A491BR_Comorbidity_TB_Code ;
      private bool[] T00093_n491BR_Comorbidity_TB_Code ;
      private String[] T00093_A492BR_Comorbidity_KidneyDisease_Code ;
      private bool[] T00093_n492BR_Comorbidity_KidneyDisease_Code ;
      private String[] T00093_A493BR_Comorbidity_SurgeryHistory_Code ;
      private bool[] T00093_n493BR_Comorbidity_SurgeryHistory_Code ;
      private String[] T00093_A494BR_Comorbidity_InjuryHistory_Code ;
      private bool[] T00093_n494BR_Comorbidity_InjuryHistory_Code ;
      private String[] T00093_A495BR_Comorbidity_BloodHistory_Code ;
      private bool[] T00093_n495BR_Comorbidity_BloodHistory_Code ;
      private String[] T00093_A496BR_Comorbidity_allergy_Code ;
      private bool[] T00093_n496BR_Comorbidity_allergy_Code ;
      private String[] T00093_A38BR_Comorbidity_Hypertension ;
      private bool[] T00093_n38BR_Comorbidity_Hypertension ;
      private String[] T00093_A39BR_Comorbidity_Diabetes ;
      private bool[] T00093_n39BR_Comorbidity_Diabetes ;
      private String[] T00093_A40BR_Comorbidity_CHD ;
      private bool[] T00093_n40BR_Comorbidity_CHD ;
      private String[] T00093_A41BR_Comorbidity_Hapetitis ;
      private bool[] T00093_n41BR_Comorbidity_Hapetitis ;
      private String[] T00093_A42BR_Comorbidity_TB ;
      private bool[] T00093_n42BR_Comorbidity_TB ;
      private String[] T00093_A43BR_Comorbidity_KidneyDisease ;
      private bool[] T00093_n43BR_Comorbidity_KidneyDisease ;
      private String[] T00093_A44BR_Comorbidity_SurgeryHistory ;
      private bool[] T00093_n44BR_Comorbidity_SurgeryHistory ;
      private String[] T00093_A45BR_Comorbidity_InjuryHistory ;
      private bool[] T00093_n45BR_Comorbidity_InjuryHistory ;
      private String[] T00093_A46BR_Comorbidity_BloodHistory ;
      private bool[] T00093_n46BR_Comorbidity_BloodHistory ;
      private String[] T00093_A47BR_Comorbidity_allergy ;
      private bool[] T00093_n47BR_Comorbidity_allergy ;
      private String[] T00093_A259BR_Comorbidity_Others ;
      private bool[] T00093_n259BR_Comorbidity_Others ;
      private String[] T00093_A561BR_Comorbidity_HapetitisB ;
      private bool[] T00093_n561BR_Comorbidity_HapetitisB ;
      private String[] T00093_A562BR_Comorbidity_HapetitisB_Code ;
      private bool[] T00093_n562BR_Comorbidity_HapetitisB_Code ;
      private String[] T00093_A563BR_Comorbidity_HapetitisC ;
      private bool[] T00093_n563BR_Comorbidity_HapetitisC ;
      private String[] T00093_A564BR_Comorbidity_HapetitisC_Code ;
      private bool[] T00093_n564BR_Comorbidity_HapetitisC_Code ;
      private String[] T00093_A565BR_Comorbidity_LiverCirrhosis ;
      private bool[] T00093_n565BR_Comorbidity_LiverCirrhosis ;
      private String[] T00093_A566BR_Comorbidity_LiverCirrhosis_Code ;
      private bool[] T00093_n566BR_Comorbidity_LiverCirrhosis_Code ;
      private String[] T00093_A567BR_Comorbidity_Druginducedliverinjury ;
      private bool[] T00093_n567BR_Comorbidity_Druginducedliverinjury ;
      private String[] T00093_A568BR_Comorbidity_Druginducedliverinjury_Code ;
      private bool[] T00093_n568BR_Comorbidity_Druginducedliverinjury_Code ;
      private long[] T00093_A19BR_EncounterID ;
      private long[] T000910_A37BR_ComorbidityID ;
      private long[] T000911_A37BR_ComorbidityID ;
      private long[] T00092_A37BR_ComorbidityID ;
      private String[] T00092_A487BR_Comorbidity_Hypertension_Code ;
      private bool[] T00092_n487BR_Comorbidity_Hypertension_Code ;
      private String[] T00092_A488BR_Comorbidity_Diabetes_Code ;
      private bool[] T00092_n488BR_Comorbidity_Diabetes_Code ;
      private String[] T00092_A489BR_Comorbidity_CHD_Code ;
      private bool[] T00092_n489BR_Comorbidity_CHD_Code ;
      private String[] T00092_A490BR_Comorbidity_Hapetitis_Code ;
      private bool[] T00092_n490BR_Comorbidity_Hapetitis_Code ;
      private String[] T00092_A491BR_Comorbidity_TB_Code ;
      private bool[] T00092_n491BR_Comorbidity_TB_Code ;
      private String[] T00092_A492BR_Comorbidity_KidneyDisease_Code ;
      private bool[] T00092_n492BR_Comorbidity_KidneyDisease_Code ;
      private String[] T00092_A493BR_Comorbidity_SurgeryHistory_Code ;
      private bool[] T00092_n493BR_Comorbidity_SurgeryHistory_Code ;
      private String[] T00092_A494BR_Comorbidity_InjuryHistory_Code ;
      private bool[] T00092_n494BR_Comorbidity_InjuryHistory_Code ;
      private String[] T00092_A495BR_Comorbidity_BloodHistory_Code ;
      private bool[] T00092_n495BR_Comorbidity_BloodHistory_Code ;
      private String[] T00092_A496BR_Comorbidity_allergy_Code ;
      private bool[] T00092_n496BR_Comorbidity_allergy_Code ;
      private String[] T00092_A38BR_Comorbidity_Hypertension ;
      private bool[] T00092_n38BR_Comorbidity_Hypertension ;
      private String[] T00092_A39BR_Comorbidity_Diabetes ;
      private bool[] T00092_n39BR_Comorbidity_Diabetes ;
      private String[] T00092_A40BR_Comorbidity_CHD ;
      private bool[] T00092_n40BR_Comorbidity_CHD ;
      private String[] T00092_A41BR_Comorbidity_Hapetitis ;
      private bool[] T00092_n41BR_Comorbidity_Hapetitis ;
      private String[] T00092_A42BR_Comorbidity_TB ;
      private bool[] T00092_n42BR_Comorbidity_TB ;
      private String[] T00092_A43BR_Comorbidity_KidneyDisease ;
      private bool[] T00092_n43BR_Comorbidity_KidneyDisease ;
      private String[] T00092_A44BR_Comorbidity_SurgeryHistory ;
      private bool[] T00092_n44BR_Comorbidity_SurgeryHistory ;
      private String[] T00092_A45BR_Comorbidity_InjuryHistory ;
      private bool[] T00092_n45BR_Comorbidity_InjuryHistory ;
      private String[] T00092_A46BR_Comorbidity_BloodHistory ;
      private bool[] T00092_n46BR_Comorbidity_BloodHistory ;
      private String[] T00092_A47BR_Comorbidity_allergy ;
      private bool[] T00092_n47BR_Comorbidity_allergy ;
      private String[] T00092_A259BR_Comorbidity_Others ;
      private bool[] T00092_n259BR_Comorbidity_Others ;
      private String[] T00092_A561BR_Comorbidity_HapetitisB ;
      private bool[] T00092_n561BR_Comorbidity_HapetitisB ;
      private String[] T00092_A562BR_Comorbidity_HapetitisB_Code ;
      private bool[] T00092_n562BR_Comorbidity_HapetitisB_Code ;
      private String[] T00092_A563BR_Comorbidity_HapetitisC ;
      private bool[] T00092_n563BR_Comorbidity_HapetitisC ;
      private String[] T00092_A564BR_Comorbidity_HapetitisC_Code ;
      private bool[] T00092_n564BR_Comorbidity_HapetitisC_Code ;
      private String[] T00092_A565BR_Comorbidity_LiverCirrhosis ;
      private bool[] T00092_n565BR_Comorbidity_LiverCirrhosis ;
      private String[] T00092_A566BR_Comorbidity_LiverCirrhosis_Code ;
      private bool[] T00092_n566BR_Comorbidity_LiverCirrhosis_Code ;
      private String[] T00092_A567BR_Comorbidity_Druginducedliverinjury ;
      private bool[] T00092_n567BR_Comorbidity_Druginducedliverinjury ;
      private String[] T00092_A568BR_Comorbidity_Druginducedliverinjury_Code ;
      private bool[] T00092_n568BR_Comorbidity_Druginducedliverinjury_Code ;
      private long[] T00092_A19BR_EncounterID ;
      private long[] T000912_A37BR_ComorbidityID ;
      private long[] T000915_A85BR_Information_ID ;
      private bool[] T000915_n85BR_Information_ID ;
      private String[] T000916_A36BR_Information_PatientNo ;
      private bool[] T000916_n36BR_Information_PatientNo ;
      private long[] T000917_A37BR_ComorbidityID ;
      private IDataStoreProvider pr_datastore1 ;
      private GXWebForm Form ;
   }

   public class br_comorbidity__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class br_comorbidity__default : DataStoreHelperBase, IDataStoreHelper
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
       ,new ForEachCursor(def[7])
       ,new ForEachCursor(def[8])
       ,new ForEachCursor(def[9])
       ,new ForEachCursor(def[10])
       ,new UpdateCursor(def[11])
       ,new UpdateCursor(def[12])
       ,new ForEachCursor(def[13])
       ,new ForEachCursor(def[14])
       ,new ForEachCursor(def[15])
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmT00096 ;
        prmT00096 = new Object[] {
        new Object[] {"@BR_ComorbidityID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00094 ;
        prmT00094 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00095 ;
        prmT00095 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00097 ;
        prmT00097 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00098 ;
        prmT00098 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00099 ;
        prmT00099 = new Object[] {
        new Object[] {"@BR_ComorbidityID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00093 ;
        prmT00093 = new Object[] {
        new Object[] {"@BR_ComorbidityID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000910 ;
        prmT000910 = new Object[] {
        new Object[] {"@BR_ComorbidityID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000911 ;
        prmT000911 = new Object[] {
        new Object[] {"@BR_ComorbidityID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00092 ;
        prmT00092 = new Object[] {
        new Object[] {"@BR_ComorbidityID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000912 ;
        prmT000912 = new Object[] {
        new Object[] {"@BR_Comorbidity_Hypertension_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_Diabetes_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_CHD_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_Hapetitis_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_TB_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_KidneyDisease_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_SurgeryHistory_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_InjuryHistory_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_BloodHistory_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_allergy_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_Hypertension",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_Diabetes",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_CHD",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_Hapetitis",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_TB",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_KidneyDisease",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_SurgeryHistory",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_InjuryHistory",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_BloodHistory",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_allergy",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_Others",SqlDbType.NVarChar,255,0} ,
        new Object[] {"@BR_Comorbidity_HapetitisB",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_HapetitisB_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_HapetitisC",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_HapetitisC_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_LiverCirrhosis",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_LiverCirrhosis_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_Druginducedliverinjury",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_Druginducedliverinjury_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        String cmdBufferT000912 ;
        cmdBufferT000912=" INSERT INTO [BR_Comorbidity]([BR_Comorbidity_Hypertension_Code], [BR_Comorbidity_Diabetes_Code], [BR_Comorbidity_CHD_Code], [BR_Comorbidity_Hapetitis_Code], [BR_Comorbidity_TB_Code], [BR_Comorbidity_KidneyDisease_Code], [BR_Comorbidity_SurgeryHistory_Code], [BR_Comorbidity_InjuryHistory_Code], [BR_Comorbidity_BloodHistory_Code], [BR_Comorbidity_allergy_Code], [BR_Comorbidity_Hypertension], [BR_Comorbidity_Diabetes], [BR_Comorbidity_CHD], [BR_Comorbidity_Hapetitis], [BR_Comorbidity_TB], [BR_Comorbidity_KidneyDisease], [BR_Comorbidity_SurgeryHistory], [BR_Comorbidity_InjuryHistory], [BR_Comorbidity_BloodHistory], [BR_Comorbidity_allergy], [BR_Comorbidity_Others], [BR_Comorbidity_HapetitisB], [BR_Comorbidity_HapetitisB_Code], [BR_Comorbidity_HapetitisC], [BR_Comorbidity_HapetitisC_Code], [BR_Comorbidity_LiverCirrhosis], [BR_Comorbidity_LiverCirrhosis_Code], [BR_Comorbidity_Druginducedliverinjury], [BR_Comorbidity_Druginducedliverinjury_Code], [BR_EncounterID]) VALUES(@BR_Comorbidity_Hypertension_Code, @BR_Comorbidity_Diabetes_Code, @BR_Comorbidity_CHD_Code, @BR_Comorbidity_Hapetitis_Code, @BR_Comorbidity_TB_Code, @BR_Comorbidity_KidneyDisease_Code, @BR_Comorbidity_SurgeryHistory_Code, @BR_Comorbidity_InjuryHistory_Code, @BR_Comorbidity_BloodHistory_Code, @BR_Comorbidity_allergy_Code, @BR_Comorbidity_Hypertension, @BR_Comorbidity_Diabetes, @BR_Comorbidity_CHD, @BR_Comorbidity_Hapetitis, @BR_Comorbidity_TB, @BR_Comorbidity_KidneyDisease, @BR_Comorbidity_SurgeryHistory, @BR_Comorbidity_InjuryHistory, @BR_Comorbidity_BloodHistory, @BR_Comorbidity_allergy, @BR_Comorbidity_Others, @BR_Comorbidity_HapetitisB, @BR_Comorbidity_HapetitisB_Code, @BR_Comorbidity_HapetitisC, @BR_Comorbidity_HapetitisC_Code, @BR_Comorbidity_LiverCirrhosis, @BR_Comorbidity_LiverCirrhosis_Code, @BR_Comorbidity_Druginducedliverinjury, "
        + " @BR_Comorbidity_Druginducedliverinjury_Code, @BR_EncounterID); SELECT SCOPE_IDENTITY()" ;
        Object[] prmT000913 ;
        prmT000913 = new Object[] {
        new Object[] {"@BR_Comorbidity_Hypertension_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_Diabetes_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_CHD_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_Hapetitis_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_TB_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_KidneyDisease_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_SurgeryHistory_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_InjuryHistory_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_BloodHistory_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_allergy_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_Hypertension",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_Diabetes",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_CHD",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_Hapetitis",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_TB",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_KidneyDisease",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_SurgeryHistory",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_InjuryHistory",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_BloodHistory",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_allergy",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_Others",SqlDbType.NVarChar,255,0} ,
        new Object[] {"@BR_Comorbidity_HapetitisB",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_HapetitisB_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_HapetitisC",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_HapetitisC_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_LiverCirrhosis",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_LiverCirrhosis_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_Druginducedliverinjury",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Comorbidity_Druginducedliverinjury_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_ComorbidityID",SqlDbType.Decimal,18,0}
        } ;
        String cmdBufferT000913 ;
        cmdBufferT000913=" UPDATE [BR_Comorbidity] SET [BR_Comorbidity_Hypertension_Code]=@BR_Comorbidity_Hypertension_Code, [BR_Comorbidity_Diabetes_Code]=@BR_Comorbidity_Diabetes_Code, [BR_Comorbidity_CHD_Code]=@BR_Comorbidity_CHD_Code, [BR_Comorbidity_Hapetitis_Code]=@BR_Comorbidity_Hapetitis_Code, [BR_Comorbidity_TB_Code]=@BR_Comorbidity_TB_Code, [BR_Comorbidity_KidneyDisease_Code]=@BR_Comorbidity_KidneyDisease_Code, [BR_Comorbidity_SurgeryHistory_Code]=@BR_Comorbidity_SurgeryHistory_Code, [BR_Comorbidity_InjuryHistory_Code]=@BR_Comorbidity_InjuryHistory_Code, [BR_Comorbidity_BloodHistory_Code]=@BR_Comorbidity_BloodHistory_Code, [BR_Comorbidity_allergy_Code]=@BR_Comorbidity_allergy_Code, [BR_Comorbidity_Hypertension]=@BR_Comorbidity_Hypertension, [BR_Comorbidity_Diabetes]=@BR_Comorbidity_Diabetes, [BR_Comorbidity_CHD]=@BR_Comorbidity_CHD, [BR_Comorbidity_Hapetitis]=@BR_Comorbidity_Hapetitis, [BR_Comorbidity_TB]=@BR_Comorbidity_TB, [BR_Comorbidity_KidneyDisease]=@BR_Comorbidity_KidneyDisease, [BR_Comorbidity_SurgeryHistory]=@BR_Comorbidity_SurgeryHistory, [BR_Comorbidity_InjuryHistory]=@BR_Comorbidity_InjuryHistory, [BR_Comorbidity_BloodHistory]=@BR_Comorbidity_BloodHistory, [BR_Comorbidity_allergy]=@BR_Comorbidity_allergy, [BR_Comorbidity_Others]=@BR_Comorbidity_Others, [BR_Comorbidity_HapetitisB]=@BR_Comorbidity_HapetitisB, [BR_Comorbidity_HapetitisB_Code]=@BR_Comorbidity_HapetitisB_Code, [BR_Comorbidity_HapetitisC]=@BR_Comorbidity_HapetitisC, [BR_Comorbidity_HapetitisC_Code]=@BR_Comorbidity_HapetitisC_Code, [BR_Comorbidity_LiverCirrhosis]=@BR_Comorbidity_LiverCirrhosis, [BR_Comorbidity_LiverCirrhosis_Code]=@BR_Comorbidity_LiverCirrhosis_Code, [BR_Comorbidity_Druginducedliverinjury]=@BR_Comorbidity_Druginducedliverinjury, [BR_Comorbidity_Druginducedliverinjury_Code]=@BR_Comorbidity_Druginducedliverinjury_Code, "
        + " [BR_EncounterID]=@BR_EncounterID  WHERE [BR_ComorbidityID] = @BR_ComorbidityID" ;
        Object[] prmT000914 ;
        prmT000914 = new Object[] {
        new Object[] {"@BR_ComorbidityID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000917 ;
        prmT000917 = new Object[] {
        } ;
        Object[] prmT000915 ;
        prmT000915 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000916 ;
        prmT000916 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("T00092", "SELECT [BR_ComorbidityID], [BR_Comorbidity_Hypertension_Code], [BR_Comorbidity_Diabetes_Code], [BR_Comorbidity_CHD_Code], [BR_Comorbidity_Hapetitis_Code], [BR_Comorbidity_TB_Code], [BR_Comorbidity_KidneyDisease_Code], [BR_Comorbidity_SurgeryHistory_Code], [BR_Comorbidity_InjuryHistory_Code], [BR_Comorbidity_BloodHistory_Code], [BR_Comorbidity_allergy_Code], [BR_Comorbidity_Hypertension], [BR_Comorbidity_Diabetes], [BR_Comorbidity_CHD], [BR_Comorbidity_Hapetitis], [BR_Comorbidity_TB], [BR_Comorbidity_KidneyDisease], [BR_Comorbidity_SurgeryHistory], [BR_Comorbidity_InjuryHistory], [BR_Comorbidity_BloodHistory], [BR_Comorbidity_allergy], [BR_Comorbidity_Others], [BR_Comorbidity_HapetitisB], [BR_Comorbidity_HapetitisB_Code], [BR_Comorbidity_HapetitisC], [BR_Comorbidity_HapetitisC_Code], [BR_Comorbidity_LiverCirrhosis], [BR_Comorbidity_LiverCirrhosis_Code], [BR_Comorbidity_Druginducedliverinjury], [BR_Comorbidity_Druginducedliverinjury_Code], [BR_EncounterID] FROM [BR_Comorbidity] WITH (UPDLOCK) WHERE [BR_ComorbidityID] = @BR_ComorbidityID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00092,1,0,true,false )
           ,new CursorDef("T00093", "SELECT [BR_ComorbidityID], [BR_Comorbidity_Hypertension_Code], [BR_Comorbidity_Diabetes_Code], [BR_Comorbidity_CHD_Code], [BR_Comorbidity_Hapetitis_Code], [BR_Comorbidity_TB_Code], [BR_Comorbidity_KidneyDisease_Code], [BR_Comorbidity_SurgeryHistory_Code], [BR_Comorbidity_InjuryHistory_Code], [BR_Comorbidity_BloodHistory_Code], [BR_Comorbidity_allergy_Code], [BR_Comorbidity_Hypertension], [BR_Comorbidity_Diabetes], [BR_Comorbidity_CHD], [BR_Comorbidity_Hapetitis], [BR_Comorbidity_TB], [BR_Comorbidity_KidneyDisease], [BR_Comorbidity_SurgeryHistory], [BR_Comorbidity_InjuryHistory], [BR_Comorbidity_BloodHistory], [BR_Comorbidity_allergy], [BR_Comorbidity_Others], [BR_Comorbidity_HapetitisB], [BR_Comorbidity_HapetitisB_Code], [BR_Comorbidity_HapetitisC], [BR_Comorbidity_HapetitisC_Code], [BR_Comorbidity_LiverCirrhosis], [BR_Comorbidity_LiverCirrhosis_Code], [BR_Comorbidity_Druginducedliverinjury], [BR_Comorbidity_Druginducedliverinjury_Code], [BR_EncounterID] FROM [BR_Comorbidity] WITH (NOLOCK) WHERE [BR_ComorbidityID] = @BR_ComorbidityID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00093,1,0,true,false )
           ,new CursorDef("T00094", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00094,1,0,true,false )
           ,new CursorDef("T00095", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00095,1,0,true,false )
           ,new CursorDef("T00096", "SELECT T2.[BR_Information_ID], TM1.[BR_ComorbidityID], TM1.[BR_Comorbidity_Hypertension_Code], TM1.[BR_Comorbidity_Diabetes_Code], TM1.[BR_Comorbidity_CHD_Code], TM1.[BR_Comorbidity_Hapetitis_Code], TM1.[BR_Comorbidity_TB_Code], TM1.[BR_Comorbidity_KidneyDisease_Code], TM1.[BR_Comorbidity_SurgeryHistory_Code], TM1.[BR_Comorbidity_InjuryHistory_Code], TM1.[BR_Comorbidity_BloodHistory_Code], TM1.[BR_Comorbidity_allergy_Code], T3.[BR_Information_PatientNo], TM1.[BR_Comorbidity_Hypertension], TM1.[BR_Comorbidity_Diabetes], TM1.[BR_Comorbidity_CHD], TM1.[BR_Comorbidity_Hapetitis], TM1.[BR_Comorbidity_TB], TM1.[BR_Comorbidity_KidneyDisease], TM1.[BR_Comorbidity_SurgeryHistory], TM1.[BR_Comorbidity_InjuryHistory], TM1.[BR_Comorbidity_BloodHistory], TM1.[BR_Comorbidity_allergy], TM1.[BR_Comorbidity_Others], TM1.[BR_Comorbidity_HapetitisB], TM1.[BR_Comorbidity_HapetitisB_Code], TM1.[BR_Comorbidity_HapetitisC], TM1.[BR_Comorbidity_HapetitisC_Code], TM1.[BR_Comorbidity_LiverCirrhosis], TM1.[BR_Comorbidity_LiverCirrhosis_Code], TM1.[BR_Comorbidity_Druginducedliverinjury], TM1.[BR_Comorbidity_Druginducedliverinjury_Code], TM1.[BR_EncounterID] FROM (([BR_Comorbidity] TM1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = TM1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID]) WHERE TM1.[BR_ComorbidityID] = @BR_ComorbidityID ORDER BY TM1.[BR_ComorbidityID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00096,100,0,true,false )
           ,new CursorDef("T00097", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00097,1,0,true,false )
           ,new CursorDef("T00098", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00098,1,0,true,false )
           ,new CursorDef("T00099", "SELECT [BR_ComorbidityID] FROM [BR_Comorbidity] WITH (NOLOCK) WHERE [BR_ComorbidityID] = @BR_ComorbidityID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00099,1,0,true,false )
           ,new CursorDef("T000910", "SELECT TOP 1 [BR_ComorbidityID] FROM [BR_Comorbidity] WITH (NOLOCK) WHERE ( [BR_ComorbidityID] > @BR_ComorbidityID) ORDER BY [BR_ComorbidityID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000910,1,0,true,true )
           ,new CursorDef("T000911", "SELECT TOP 1 [BR_ComorbidityID] FROM [BR_Comorbidity] WITH (NOLOCK) WHERE ( [BR_ComorbidityID] < @BR_ComorbidityID) ORDER BY [BR_ComorbidityID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000911,1,0,true,true )
           ,new CursorDef("T000912", cmdBufferT000912, GxErrorMask.GX_NOMASK,prmT000912)
           ,new CursorDef("T000913", cmdBufferT000913, GxErrorMask.GX_NOMASK,prmT000913)
           ,new CursorDef("T000914", "DELETE FROM [BR_Comorbidity]  WHERE [BR_ComorbidityID] = @BR_ComorbidityID", GxErrorMask.GX_NOMASK,prmT000914)
           ,new CursorDef("T000915", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000915,1,0,true,false )
           ,new CursorDef("T000916", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000916,1,0,true,false )
           ,new CursorDef("T000917", "SELECT [BR_ComorbidityID] FROM [BR_Comorbidity] WITH (NOLOCK) ORDER BY [BR_ComorbidityID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000917,100,0,true,false )
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
              ((String[]) buf[47])[0] = rslt.getVarchar(25) ;
              ((bool[]) buf[48])[0] = rslt.wasNull(25);
              ((String[]) buf[49])[0] = rslt.getVarchar(26) ;
              ((bool[]) buf[50])[0] = rslt.wasNull(26);
              ((String[]) buf[51])[0] = rslt.getVarchar(27) ;
              ((bool[]) buf[52])[0] = rslt.wasNull(27);
              ((String[]) buf[53])[0] = rslt.getVarchar(28) ;
              ((bool[]) buf[54])[0] = rslt.wasNull(28);
              ((String[]) buf[55])[0] = rslt.getVarchar(29) ;
              ((bool[]) buf[56])[0] = rslt.wasNull(29);
              ((String[]) buf[57])[0] = rslt.getVarchar(30) ;
              ((bool[]) buf[58])[0] = rslt.wasNull(30);
              ((long[]) buf[59])[0] = rslt.getLong(31) ;
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
              ((String[]) buf[47])[0] = rslt.getVarchar(25) ;
              ((bool[]) buf[48])[0] = rslt.wasNull(25);
              ((String[]) buf[49])[0] = rslt.getVarchar(26) ;
              ((bool[]) buf[50])[0] = rslt.wasNull(26);
              ((String[]) buf[51])[0] = rslt.getVarchar(27) ;
              ((bool[]) buf[52])[0] = rslt.wasNull(27);
              ((String[]) buf[53])[0] = rslt.getVarchar(28) ;
              ((bool[]) buf[54])[0] = rslt.wasNull(28);
              ((String[]) buf[55])[0] = rslt.getVarchar(29) ;
              ((bool[]) buf[56])[0] = rslt.wasNull(29);
              ((String[]) buf[57])[0] = rslt.getVarchar(30) ;
              ((bool[]) buf[58])[0] = rslt.wasNull(30);
              ((long[]) buf[59])[0] = rslt.getLong(31) ;
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
              ((String[]) buf[51])[0] = rslt.getVarchar(27) ;
              ((bool[]) buf[52])[0] = rslt.wasNull(27);
              ((String[]) buf[53])[0] = rslt.getVarchar(28) ;
              ((bool[]) buf[54])[0] = rslt.wasNull(28);
              ((String[]) buf[55])[0] = rslt.getVarchar(29) ;
              ((bool[]) buf[56])[0] = rslt.wasNull(29);
              ((String[]) buf[57])[0] = rslt.getVarchar(30) ;
              ((bool[]) buf[58])[0] = rslt.wasNull(30);
              ((String[]) buf[59])[0] = rslt.getVarchar(31) ;
              ((bool[]) buf[60])[0] = rslt.wasNull(31);
              ((String[]) buf[61])[0] = rslt.getVarchar(32) ;
              ((bool[]) buf[62])[0] = rslt.wasNull(32);
              ((long[]) buf[63])[0] = rslt.getLong(33) ;
              return;
           case 5 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              return;
           case 6 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              return;
           case 7 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 8 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 9 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 10 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 13 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              return;
           case 14 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              return;
           case 15 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
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
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 7 :
              stmt.SetParameter(1, (long)parms[0]);
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
                 stmt.setNull( 24 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(24, (String)parms[47]);
              }
              if ( (bool)parms[48] )
              {
                 stmt.setNull( 25 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(25, (String)parms[49]);
              }
              if ( (bool)parms[50] )
              {
                 stmt.setNull( 26 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(26, (String)parms[51]);
              }
              if ( (bool)parms[52] )
              {
                 stmt.setNull( 27 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(27, (String)parms[53]);
              }
              if ( (bool)parms[54] )
              {
                 stmt.setNull( 28 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(28, (String)parms[55]);
              }
              if ( (bool)parms[56] )
              {
                 stmt.setNull( 29 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(29, (String)parms[57]);
              }
              stmt.SetParameter(30, (long)parms[58]);
              return;
           case 11 :
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
                 stmt.setNull( 24 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(24, (String)parms[47]);
              }
              if ( (bool)parms[48] )
              {
                 stmt.setNull( 25 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(25, (String)parms[49]);
              }
              if ( (bool)parms[50] )
              {
                 stmt.setNull( 26 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(26, (String)parms[51]);
              }
              if ( (bool)parms[52] )
              {
                 stmt.setNull( 27 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(27, (String)parms[53]);
              }
              if ( (bool)parms[54] )
              {
                 stmt.setNull( 28 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(28, (String)parms[55]);
              }
              if ( (bool)parms[56] )
              {
                 stmt.setNull( 29 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(29, (String)parms[57]);
              }
              stmt.SetParameter(30, (long)parms[58]);
              stmt.SetParameter(31, (long)parms[59]);
              return;
           case 12 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 13 :
              stmt.SetParameter(1, (long)parms[0]);
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
